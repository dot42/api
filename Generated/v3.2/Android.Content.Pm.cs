#pragma warning disable 1717
namespace Android.Content.PM
{
		/// <summary>
		///  <para>Information you can retrieve about a particular application activity or receiver. This corresponds to information collected from the AndroidManifest.xml's &lt;activity&gt; and &lt;receiver&gt; tags. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/ActivityInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ActivityInfo", AccessFlags = 33)]
		public partial class ActivityInfo : global::Android.Content.PM.ComponentInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A style resource identifier (in the package's resources) of this activity's theme. From the "theme" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// theme
				/// </java-name>
				[Dot42.DexImport("theme", "I", AccessFlags = 1)]
				public int Theme;
				/// <summary>
				///  <para>Constant corresponding to  <code>standard</code> in the android.R.attr#launchMode attribute. </para>        
				/// </summary>
				/// <java-name>
				/// LAUNCH_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("LAUNCH_MULTIPLE", "I", AccessFlags = 25)]
				public const int LAUNCH_MULTIPLE = 0;
				/// <summary>
				///  <para>Constant corresponding to  <code>singleTop</code> in the android.R.attr#launchMode attribute. </para>        
				/// </summary>
				/// <java-name>
				/// LAUNCH_SINGLE_TOP
				/// </java-name>
				[Dot42.DexImport("LAUNCH_SINGLE_TOP", "I", AccessFlags = 25)]
				public const int LAUNCH_SINGLE_TOP = 1;
				/// <summary>
				///  <para>Constant corresponding to  <code>singleTask</code> in the android.R.attr#launchMode attribute. </para>        
				/// </summary>
				/// <java-name>
				/// LAUNCH_SINGLE_TASK
				/// </java-name>
				[Dot42.DexImport("LAUNCH_SINGLE_TASK", "I", AccessFlags = 25)]
				public const int LAUNCH_SINGLE_TASK = 2;
				/// <summary>
				///  <para>Constant corresponding to  <code>singleInstance</code> in the android.R.attr#launchMode attribute. </para>        
				/// </summary>
				/// <java-name>
				/// LAUNCH_SINGLE_INSTANCE
				/// </java-name>
				[Dot42.DexImport("LAUNCH_SINGLE_INSTANCE", "I", AccessFlags = 25)]
				public const int LAUNCH_SINGLE_INSTANCE = 3;
				/// <summary>
				///  <para>The launch mode style requested by the activity. From the android.R.attr#launchMode attribute, one of LAUNCH_MULTIPLE, LAUNCH_SINGLE_TOP, LAUNCH_SINGLE_TASK, or LAUNCH_SINGLE_INSTANCE. </para>        
				/// </summary>
				/// <java-name>
				/// launchMode
				/// </java-name>
				[Dot42.DexImport("launchMode", "I", AccessFlags = 1)]
				public int LaunchMode;
				/// <summary>
				///  <para>Optional name of a permission required to be able to access this Activity. From the "permission" attribute. </para>        
				/// </summary>
				/// <java-name>
				/// permission
				/// </java-name>
				[Dot42.DexImport("permission", "Ljava/lang/String;", AccessFlags = 1)]
				public string Permission;
				/// <summary>
				///  <para>The affinity this activity has for another task in the system. The string here is the name of the task, often the package name of the overall package. If null, the activity has no affinity. Set from the android.R.attr#taskAffinity attribute. </para>        
				/// </summary>
				/// <java-name>
				/// taskAffinity
				/// </java-name>
				[Dot42.DexImport("taskAffinity", "Ljava/lang/String;", AccessFlags = 1)]
				public string TaskAffinity;
				/// <summary>
				///  <para>If this is an activity alias, this is the real activity class to run for it. Otherwise, this is null. </para>        
				/// </summary>
				/// <java-name>
				/// targetActivity
				/// </java-name>
				[Dot42.DexImport("targetActivity", "Ljava/lang/String;", AccessFlags = 1)]
				public string TargetActivity;
				/// <summary>
				///  <para>Bit in flags indicating whether this activity is able to run in multiple processes. If true, the system may instantiate it in the some process as the process starting it in order to conserve resources. If false, the default, it always runs in processName. Set from the android.R.attr#multiprocess attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_MULTIPROCESS
				/// </java-name>
				[Dot42.DexImport("FLAG_MULTIPROCESS", "I", AccessFlags = 25)]
				public const int FLAG_MULTIPROCESS = 1;
				/// <summary>
				///  <para>Bit in flags indicating that, when the activity's task is relaunched from home, this activity should be finished. Set from the android.R.attr#finishOnTaskLaunch attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_FINISH_ON_TASK_LAUNCH
				/// </java-name>
				[Dot42.DexImport("FLAG_FINISH_ON_TASK_LAUNCH", "I", AccessFlags = 25)]
				public const int FLAG_FINISH_ON_TASK_LAUNCH = 2;
				/// <summary>
				///  <para>Bit in flags indicating that, when the activity is the root of a task, that task's stack should be cleared each time the user re-launches it from home. As a result, the user will always return to the original activity at the top of the task. This flag only applies to activities that are used to start the root of a new task. Set from the android.R.attr#clearTaskOnLaunch attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_CLEAR_TASK_ON_LAUNCH
				/// </java-name>
				[Dot42.DexImport("FLAG_CLEAR_TASK_ON_LAUNCH", "I", AccessFlags = 25)]
				public const int FLAG_CLEAR_TASK_ON_LAUNCH = 4;
				/// <summary>
				///  <para>Bit in flags indicating that, when the activity is the root of a task, that task's stack should never be cleared when it is relaunched from home. Set from the android.R.attr#alwaysRetainTaskState attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALWAYS_RETAIN_TASK_STATE
				/// </java-name>
				[Dot42.DexImport("FLAG_ALWAYS_RETAIN_TASK_STATE", "I", AccessFlags = 25)]
				public const int FLAG_ALWAYS_RETAIN_TASK_STATE = 8;
				/// <summary>
				///  <para>Bit in flags indicating that the activity's state is not required to be saved, so that if there is a failure the activity will not be removed from the activity stack. Set from the android.R.attr#stateNotNeeded attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_STATE_NOT_NEEDED
				/// </java-name>
				[Dot42.DexImport("FLAG_STATE_NOT_NEEDED", "I", AccessFlags = 25)]
				public const int FLAG_STATE_NOT_NEEDED = 16;
				/// <summary>
				///  <para>Bit in flags that indicates that the activity should not appear in the list of recently launched activities. Set from the android.R.attr#excludeFromRecents attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_EXCLUDE_FROM_RECENTS
				/// </java-name>
				[Dot42.DexImport("FLAG_EXCLUDE_FROM_RECENTS", "I", AccessFlags = 25)]
				public const int FLAG_EXCLUDE_FROM_RECENTS = 32;
				/// <summary>
				///  <para>Bit in flags that indicates that the activity can be moved between tasks based on its task affinity. Set from the android.R.attr#allowTaskReparenting attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALLOW_TASK_REPARENTING
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_TASK_REPARENTING", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_TASK_REPARENTING = 64;
				/// <summary>
				///  <para>Bit in flags indicating that, when the user navigates away from an activity, it should be finished. Set from the android.R.attr#noHistory attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_NO_HISTORY
				/// </java-name>
				[Dot42.DexImport("FLAG_NO_HISTORY", "I", AccessFlags = 25)]
				public const int FLAG_NO_HISTORY = 128;
				/// <summary>
				///  <para>Bit in flags indicating that, when a request to close system windows happens, this activity is finished. Set from the android.R.attr#finishOnCloseSystemDialogs attribute. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_FINISH_ON_CLOSE_SYSTEM_DIALOGS
				/// </java-name>
				[Dot42.DexImport("FLAG_FINISH_ON_CLOSE_SYSTEM_DIALOGS", "I", AccessFlags = 25)]
				public const int FLAG_FINISH_ON_CLOSE_SYSTEM_DIALOGS = 256;
				/// <summary>
				///  <para>Value for flags: true when the application's rendering should be hardware accelerated. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_HARDWARE_ACCELERATED
				/// </java-name>
				[Dot42.DexImport("FLAG_HARDWARE_ACCELERATED", "I", AccessFlags = 25)]
				public const int FLAG_HARDWARE_ACCELERATED = 512;
				/// <summary>
				///  <para>Options that have been set in the activity declaration in the manifest. These include: FLAG_MULTIPROCESS, FLAG_FINISH_ON_TASK_LAUNCH, FLAG_CLEAR_TASK_ON_LAUNCH, FLAG_ALWAYS_RETAIN_TASK_STATE, FLAG_STATE_NOT_NEEDED, FLAG_EXCLUDE_FROM_RECENTS, FLAG_ALLOW_TASK_REPARENTING, FLAG_NO_HISTORY, FLAG_FINISH_ON_CLOSE_SYSTEM_DIALOGS, FLAG_HARDWARE_ACCELERATED, FLAG_SINGLE_USER. </para>        
				/// </summary>
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <summary>
				///  <para>Constant corresponding to  <code>unspecified</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_UNSPECIFIED = -1;
				/// <summary>
				///  <para>Constant corresponding to  <code>landscape</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_LANDSCAPE", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_LANDSCAPE = 0;
				/// <summary>
				///  <para>Constant corresponding to  <code>portrait</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_PORTRAIT", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_PORTRAIT = 1;
				/// <summary>
				///  <para>Constant corresponding to  <code>user</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_USER
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_USER", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_USER = 2;
				/// <summary>
				///  <para>Constant corresponding to  <code>behind</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_BEHIND
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_BEHIND", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_BEHIND = 3;
				/// <summary>
				///  <para>Constant corresponding to  <code>sensor</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_SENSOR
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_SENSOR", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_SENSOR = 4;
				/// <summary>
				///  <para>Constant corresponding to  <code>nosensor</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_NOSENSOR
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_NOSENSOR", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_NOSENSOR = 5;
				/// <summary>
				///  <para>Constant corresponding to  <code>sensorLandscape</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_SENSOR_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_SENSOR_LANDSCAPE", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_SENSOR_LANDSCAPE = 6;
				/// <summary>
				///  <para>Constant corresponding to  <code>sensorPortrait</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_SENSOR_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_SENSOR_PORTRAIT", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_SENSOR_PORTRAIT = 7;
				/// <summary>
				///  <para>Constant corresponding to  <code>reverseLandscape</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_REVERSE_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_REVERSE_LANDSCAPE", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_REVERSE_LANDSCAPE = 8;
				/// <summary>
				///  <para>Constant corresponding to  <code>reversePortrait</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_REVERSE_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_REVERSE_PORTRAIT", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_REVERSE_PORTRAIT = 9;
				/// <summary>
				///  <para>Constant corresponding to  <code>fullSensor</code> in the android.R.attr#screenOrientation attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SCREEN_ORIENTATION_FULL_SENSOR
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_FULL_SENSOR", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_FULL_SENSOR = 10;
				/// <summary>
				///  <para>The preferred screen orientation this activity would like to run in. From the android.R.attr#screenOrientation attribute, one of SCREEN_ORIENTATION_UNSPECIFIED, SCREEN_ORIENTATION_LANDSCAPE, SCREEN_ORIENTATION_PORTRAIT, SCREEN_ORIENTATION_USER, SCREEN_ORIENTATION_BEHIND, SCREEN_ORIENTATION_SENSOR, SCREEN_ORIENTATION_NOSENSOR, SCREEN_ORIENTATION_SENSOR_LANDSCAPE, SCREEN_ORIENTATION_SENSOR_PORTRAIT, SCREEN_ORIENTATION_REVERSE_LANDSCAPE, SCREEN_ORIENTATION_REVERSE_PORTRAIT, SCREEN_ORIENTATION_FULL_SENSOR, SCREEN_ORIENTATION_USER_LANDSCAPE, SCREEN_ORIENTATION_USER_PORTRAIT, SCREEN_ORIENTATION_FULL_USER, SCREEN_ORIENTATION_LOCKED, </para>        
				/// </summary>
				/// <java-name>
				/// screenOrientation
				/// </java-name>
				[Dot42.DexImport("screenOrientation", "I", AccessFlags = 1)]
				public int ScreenOrientation;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the IMSI MCC. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_MCC
				/// </java-name>
				[Dot42.DexImport("CONFIG_MCC", "I", AccessFlags = 25)]
				public const int CONFIG_MCC = 1;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the IMSI MNC. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_MNC
				/// </java-name>
				[Dot42.DexImport("CONFIG_MNC", "I", AccessFlags = 25)]
				public const int CONFIG_MNC = 2;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the locale. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_LOCALE
				/// </java-name>
				[Dot42.DexImport("CONFIG_LOCALE", "I", AccessFlags = 25)]
				public const int CONFIG_LOCALE = 4;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the touchscreen type. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_TOUCHSCREEN
				/// </java-name>
				[Dot42.DexImport("CONFIG_TOUCHSCREEN", "I", AccessFlags = 25)]
				public const int CONFIG_TOUCHSCREEN = 8;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the keyboard type. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("CONFIG_KEYBOARD", "I", AccessFlags = 25)]
				public const int CONFIG_KEYBOARD = 16;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the keyboard or navigation being hidden/exposed. Note that inspite of the name, this applies to the changes to any hidden states: keyboard or navigation. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_KEYBOARD_HIDDEN
				/// </java-name>
				[Dot42.DexImport("CONFIG_KEYBOARD_HIDDEN", "I", AccessFlags = 25)]
				public const int CONFIG_KEYBOARD_HIDDEN = 32;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the navigation type. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_NAVIGATION
				/// </java-name>
				[Dot42.DexImport("CONFIG_NAVIGATION", "I", AccessFlags = 25)]
				public const int CONFIG_NAVIGATION = 64;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the screen orientation. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("CONFIG_ORIENTATION", "I", AccessFlags = 25)]
				public const int CONFIG_ORIENTATION = 128;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the screen layout. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_SCREEN_LAYOUT
				/// </java-name>
				[Dot42.DexImport("CONFIG_SCREEN_LAYOUT", "I", AccessFlags = 25)]
				public const int CONFIG_SCREEN_LAYOUT = 256;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle the ui mode. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_UI_MODE
				/// </java-name>
				[Dot42.DexImport("CONFIG_UI_MODE", "I", AccessFlags = 25)]
				public const int CONFIG_UI_MODE = 512;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle the screen size. Set from the android.R.attr#configChanges attribute. This will be set by default for applications that target an earlier version than android.os.Build.VERSION_CODES#HONEYCOMB_MR2...  <b>however</b>, you will not see the bit set here becomes some applications incorrectly compare configChanges against an absolute value rather than correctly masking out the bits they are interested in. Please don't do that, thanks. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_SCREEN_SIZE
				/// </java-name>
				[Dot42.DexImport("CONFIG_SCREEN_SIZE", "I", AccessFlags = 25)]
				public const int CONFIG_SCREEN_SIZE = 1024;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle the smallest screen size. Set from the android.R.attr#configChanges attribute. This will be set by default for applications that target an earlier version than android.os.Build.VERSION_CODES#HONEYCOMB_MR2...  <b>however</b>, you will not see the bit set here becomes some applications incorrectly compare configChanges against an absolute value rather than correctly masking out the bits they are interested in. Please don't do that, thanks. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_SMALLEST_SCREEN_SIZE
				/// </java-name>
				[Dot42.DexImport("CONFIG_SMALLEST_SCREEN_SIZE", "I", AccessFlags = 25)]
				public const int CONFIG_SMALLEST_SCREEN_SIZE = 2048;
				/// <summary>
				///  <para>Bit in configChanges that indicates that the activity can itself handle changes to the font scaling factor. Set from the android.R.attr#configChanges attribute. This is not a core resource configuration, but a higher-level value, so its constant starts at the high bits. </para>        
				/// </summary>
				/// <java-name>
				/// CONFIG_FONT_SCALE
				/// </java-name>
				[Dot42.DexImport("CONFIG_FONT_SCALE", "I", AccessFlags = 25)]
				public const int CONFIG_FONT_SCALE = 1073741824;
				/// <summary>
				///  <para>Bit mask of kinds of configuration changes that this activity can handle itself (without being restarted by the system). Contains any combination of CONFIG_FONT_SCALE, CONFIG_MCC, CONFIG_MNC, CONFIG_LOCALE, CONFIG_TOUCHSCREEN, CONFIG_KEYBOARD, CONFIG_NAVIGATION, CONFIG_ORIENTATION, CONFIG_SCREEN_LAYOUT and CONFIG_LAYOUT_DIRECTION. Set from the android.R.attr#configChanges attribute. </para>        
				/// </summary>
				/// <java-name>
				/// configChanges
				/// </java-name>
				[Dot42.DexImport("configChanges", "I", AccessFlags = 1)]
				public int ConfigChanges;
				/// <summary>
				///  <para>The desired soft input mode for this activity's main window. Set from the android.R.attr#windowSoftInputMode attribute in the activity's manifest. May be any of the same values allowed for WindowManager.LayoutParams.softInputMode. If 0 (unspecified), the mode from the theme will be used. </para>        
				/// </summary>
				/// <java-name>
				/// softInputMode
				/// </java-name>
				[Dot42.DexImport("softInputMode", "I", AccessFlags = 1)]
				public int SoftInputMode;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.ActivityInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ActivityInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ActivityInfo;)V", AccessFlags = 1)]
				public ActivityInfo(global::Android.Content.PM.ActivityInfo orig) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the theme resource identifier to use for this activity. If the activity defines a theme, that is used; else, the application theme is used.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The theme associated with this activity. </para>
				/// </returns>
				/// <java-name>
				/// getThemeResource
				/// </java-name>
				public int ThemeResource
				{
						[Dot42.DexImport("getThemeResource", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Information you can retrieve about a particular application. This corresponds to information collected from the AndroidManifest.xml's &lt;application&gt; tag. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/ApplicationInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ApplicationInfo", AccessFlags = 33)]
		public partial class ApplicationInfo : global::Android.Content.PM.PackageItemInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default task affinity of all activities in this application. See ActivityInfo#taskAffinity for more information. This comes from the "taskAffinity" attribute. </para>        
				/// </summary>
				/// <java-name>
				/// taskAffinity
				/// </java-name>
				[Dot42.DexImport("taskAffinity", "Ljava/lang/String;", AccessFlags = 1)]
				public string TaskAffinity;
				/// <summary>
				///  <para>Optional name of a permission required to be able to access this application's components. From the "permission" attribute. </para>        
				/// </summary>
				/// <java-name>
				/// permission
				/// </java-name>
				[Dot42.DexImport("permission", "Ljava/lang/String;", AccessFlags = 1)]
				public string Permission;
				/// <summary>
				///  <para>The name of the process this application should run in. From the "process" attribute or, if not set, the same as  <b>packageName</b>. </para>        
				/// </summary>
				/// <java-name>
				/// processName
				/// </java-name>
				[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ProcessName;
				/// <summary>
				///  <para>Class implementing the Application object. From the "class" attribute. </para>        
				/// </summary>
				/// <java-name>
				/// className
				/// </java-name>
				[Dot42.DexImport("className", "Ljava/lang/String;", AccessFlags = 1)]
				public string ClassName;
				/// <summary>
				///  <para>A style resource identifier (in the package's resources) of the description of an application. From the "description" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// descriptionRes
				/// </java-name>
				[Dot42.DexImport("descriptionRes", "I", AccessFlags = 1)]
				public int DescriptionRes;
				/// <summary>
				///  <para>A style resource identifier (in the package's resources) of the default visual theme of the application. From the "theme" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// theme
				/// </java-name>
				[Dot42.DexImport("theme", "I", AccessFlags = 1)]
				public int Theme;
				/// <summary>
				///  <para>Class implementing the Application's manage space functionality. From the "manageSpaceActivity" attribute. This is an optional attribute and will be null if applications don't specify it in their manifest </para>        
				/// </summary>
				/// <java-name>
				/// manageSpaceActivityName
				/// </java-name>
				[Dot42.DexImport("manageSpaceActivityName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ManageSpaceActivityName;
				/// <summary>
				///  <para>Class implementing the Application's backup functionality. From the "backupAgent" attribute. This is an optional attribute and will be null if the application does not specify it in its manifest.</para> <para>If android:allowBackup is set to false, this attribute is ignored. </para>        
				/// </summary>
				/// <java-name>
				/// backupAgentName
				/// </java-name>
				[Dot42.DexImport("backupAgentName", "Ljava/lang/String;", AccessFlags = 1)]
				public string BackupAgentName;
				/// <summary>
				///  <para>Value for flags: if set, this application is installed in the device's system image. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SYSTEM
				/// </java-name>
				[Dot42.DexImport("FLAG_SYSTEM", "I", AccessFlags = 25)]
				public const int FLAG_SYSTEM = 1;
				/// <summary>
				///  <para>Value for flags: set to true if this application would like to allow debugging of its code, even when installed on a non-development system. Comes from android:debuggable of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_DEBUGGABLE
				/// </java-name>
				[Dot42.DexImport("FLAG_DEBUGGABLE", "I", AccessFlags = 25)]
				public const int FLAG_DEBUGGABLE = 2;
				/// <summary>
				///  <para>Value for flags: set to true if this application has code associated with it. Comes from android:hasCode of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_HAS_CODE
				/// </java-name>
				[Dot42.DexImport("FLAG_HAS_CODE", "I", AccessFlags = 25)]
				public const int FLAG_HAS_CODE = 4;
				/// <summary>
				///  <para>Value for flags: set to true if this application is persistent. Comes from android:persistent of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_PERSISTENT
				/// </java-name>
				[Dot42.DexImport("FLAG_PERSISTENT", "I", AccessFlags = 25)]
				public const int FLAG_PERSISTENT = 8;
				/// <summary>
				///  <para>Value for flags: set to true if this application holds the android.Manifest.permission#FACTORY_TEST permission and the device is running in factory test mode. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_FACTORY_TEST
				/// </java-name>
				[Dot42.DexImport("FLAG_FACTORY_TEST", "I", AccessFlags = 25)]
				public const int FLAG_FACTORY_TEST = 16;
				/// <summary>
				///  <para>Value for flags: default value for the corresponding ActivityInfo flag. Comes from android:allowTaskReparenting of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALLOW_TASK_REPARENTING
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_TASK_REPARENTING", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_TASK_REPARENTING = 32;
				/// <summary>
				///  <para>Value for flags: default value for the corresponding ActivityInfo flag. Comes from android:allowClearUserData of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALLOW_CLEAR_USER_DATA
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_CLEAR_USER_DATA", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_CLEAR_USER_DATA = 64;
				/// <summary>
				///  <para>Value for flags: this is set if this application has been install as an update to a built-in system application. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_UPDATED_SYSTEM_APP
				/// </java-name>
				[Dot42.DexImport("FLAG_UPDATED_SYSTEM_APP", "I", AccessFlags = 25)]
				public const int FLAG_UPDATED_SYSTEM_APP = 128;
				/// <summary>
				///  <para>Value for flags: this is set of the application has specified android:testOnly to be true. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_TEST_ONLY
				/// </java-name>
				[Dot42.DexImport("FLAG_TEST_ONLY", "I", AccessFlags = 25)]
				public const int FLAG_TEST_ONLY = 256;
				/// <summary>
				///  <para>Value for flags: true when the application's window can be reduced in size for smaller screens. Corresponds to android:smallScreens. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SUPPORTS_SMALL_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_SMALL_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_SMALL_SCREENS = 512;
				/// <summary>
				///  <para>Value for flags: true when the application's window can be displayed on normal screens. Corresponds to android:normalScreens. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SUPPORTS_NORMAL_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_NORMAL_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_NORMAL_SCREENS = 1024;
				/// <summary>
				///  <para>Value for flags: true when the application's window can be increased in size for larger screens. Corresponds to android:largeScreens. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SUPPORTS_LARGE_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_LARGE_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_LARGE_SCREENS = 2048;
				/// <summary>
				///  <para>Value for flags: true when the application knows how to adjust its UI for different screen sizes. Corresponds to android:resizeable. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_RESIZEABLE_FOR_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_RESIZEABLE_FOR_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_RESIZEABLE_FOR_SCREENS = 4096;
				/// <summary>
				///  <para>Value for flags: true when the application knows how to accomodate different screen densities. Corresponds to android:anyDensity. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SUPPORTS_SCREEN_DENSITIES
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_SCREEN_DENSITIES", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_SCREEN_DENSITIES = 8192;
				/// <summary>
				///  <para>Value for flags: set to true if this application would like to request the VM to operate under the safe mode. Comes from android:vmSafeMode of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_VM_SAFE_MODE
				/// </java-name>
				[Dot42.DexImport("FLAG_VM_SAFE_MODE", "I", AccessFlags = 25)]
				public const int FLAG_VM_SAFE_MODE = 16384;
				/// <summary>
				///  <para>Value for flags: set to  <code>false</code> if the application does not wish to permit any OS-driven backups of its data;  <code>true</code> otherwise.</para> <para>Comes from the android:allowBackup attribute of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALLOW_BACKUP
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_BACKUP", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_BACKUP = 32768;
				/// <summary>
				///  <para>Value for flags: set to  <code>false</code> if the application must be kept in memory following a full-system restore operation;  <code>true</code> otherwise. Ordinarily, during a full system restore operation each application is shut down following execution of its agent's onRestore() method. Setting this attribute to  <code>false</code> prevents this. Most applications will not need to set this attribute.</para> <para>If android:allowBackup is set to  <code>false</code> or no android:backupAgent is specified, this flag will be ignored.</para> <para>Comes from the android:killAfterRestore attribute of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_KILL_AFTER_RESTORE
				/// </java-name>
				[Dot42.DexImport("FLAG_KILL_AFTER_RESTORE", "I", AccessFlags = 25)]
				public const int FLAG_KILL_AFTER_RESTORE = 65536;
				/// <summary>
				///  <para>Value for flags: Set to  <code>true</code> if the application's backup agent claims to be able to handle restore data even "from the future," i.e. from versions of the application with a versionCode greater than the one currently installed on the device.  <b>Use with caution!</b> By default this attribute is  <code>false</code> and the Backup Manager will ensure that data from "future" versions of the application are never supplied during a restore operation.</para> <para>If android:allowBackup is set to  <code>false</code> or no android:backupAgent is specified, this flag will be ignored.</para> <para>Comes from the android:restoreAnyVersion attribute of the &lt;application&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_RESTORE_ANY_VERSION
				/// </java-name>
				[Dot42.DexImport("FLAG_RESTORE_ANY_VERSION", "I", AccessFlags = 25)]
				public const int FLAG_RESTORE_ANY_VERSION = 131072;
				/// <summary>
				///  <para>Value for flags: Set to true if the application is currently installed on external/removable/unprotected storage. Such applications may not be available if their storage is not currently mounted. When the storage it is on is not available, it will look like the application has been uninstalled (its .apk is no longer available) but its persistent data is not removed. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_EXTERNAL_STORAGE
				/// </java-name>
				[Dot42.DexImport("FLAG_EXTERNAL_STORAGE", "I", AccessFlags = 25)]
				public const int FLAG_EXTERNAL_STORAGE = 262144;
				/// <summary>
				///  <para>Value for flags: true when the application's window can be increased in size for extra large screens. Corresponds to android:xlargeScreens. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SUPPORTS_XLARGE_SCREENS
				/// </java-name>
				[Dot42.DexImport("FLAG_SUPPORTS_XLARGE_SCREENS", "I", AccessFlags = 25)]
				public const int FLAG_SUPPORTS_XLARGE_SCREENS = 524288;
				/// <summary>
				///  <para>Value for flags: true when the application has requested a large heap for its processes. Corresponds to android:largeHeap. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_LARGE_HEAP
				/// </java-name>
				[Dot42.DexImport("FLAG_LARGE_HEAP", "I", AccessFlags = 25)]
				public const int FLAG_LARGE_HEAP = 1048576;
				/// <summary>
				///  <para>Value for flags: true if this application's package is in the stopped state. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_STOPPED
				/// </java-name>
				[Dot42.DexImport("FLAG_STOPPED", "I", AccessFlags = 25)]
				public const int FLAG_STOPPED = 2097152;
				/// <summary>
				///  <para>Flags associated with the application. Any combination of FLAG_SYSTEM, FLAG_DEBUGGABLE, FLAG_HAS_CODE, FLAG_PERSISTENT, FLAG_FACTORY_TEST, and FLAG_ALLOW_TASK_REPARENTING FLAG_ALLOW_CLEAR_USER_DATA, FLAG_UPDATED_SYSTEM_APP, FLAG_TEST_ONLY, FLAG_SUPPORTS_SMALL_SCREENS, FLAG_SUPPORTS_NORMAL_SCREENS, FLAG_SUPPORTS_LARGE_SCREENS, FLAG_SUPPORTS_XLARGE_SCREENS, FLAG_RESIZEABLE_FOR_SCREENS, FLAG_SUPPORTS_SCREEN_DENSITIES, FLAG_VM_SAFE_MODE, FLAG_INSTALLED. </para>        
				/// </summary>
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <summary>
				///  <para>The required smallest screen width the application can run on. If 0, nothing has been specified. Comes from android:requiresSmallestWidthDp attribute of the &lt;supports-screens&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// requiresSmallestWidthDp
				/// </java-name>
				[Dot42.DexImport("requiresSmallestWidthDp", "I", AccessFlags = 1)]
				public int RequiresSmallestWidthDp;
				/// <summary>
				///  <para>The maximum smallest screen width the application is designed for. If 0, nothing has been specified. Comes from android:compatibleWidthLimitDp attribute of the &lt;supports-screens&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// compatibleWidthLimitDp
				/// </java-name>
				[Dot42.DexImport("compatibleWidthLimitDp", "I", AccessFlags = 1)]
				public int CompatibleWidthLimitDp;
				/// <summary>
				///  <para>The maximum smallest screen width the application will work on. If 0, nothing has been specified. Comes from android:largestWidthLimitDp attribute of the &lt;supports-screens&gt; tag. </para>        
				/// </summary>
				/// <java-name>
				/// largestWidthLimitDp
				/// </java-name>
				[Dot42.DexImport("largestWidthLimitDp", "I", AccessFlags = 1)]
				public int LargestWidthLimitDp;
				/// <summary>
				///  <para>Full path to the location of this package. </para>        
				/// </summary>
				/// <java-name>
				/// sourceDir
				/// </java-name>
				[Dot42.DexImport("sourceDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string SourceDir;
				/// <summary>
				///  <para>Full path to the location of the publicly available parts of this package (i.e. the primary resource package and manifest). For non-forward-locked apps this will be the same as sourceDir).</para>        
				/// </summary>
				/// <java-name>
				/// publicSourceDir
				/// </java-name>
				[Dot42.DexImport("publicSourceDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string PublicSourceDir;
				/// <summary>
				///  <para>Paths to all shared libraries this application is linked against. This field is only set if the PackageManager.GET_SHARED_LIBRARY_FILES flag was used when retrieving the structure. </para>        
				/// </summary>
				/// <java-name>
				/// sharedLibraryFiles
				/// </java-name>
				[Dot42.DexImport("sharedLibraryFiles", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] SharedLibraryFiles;
				/// <summary>
				///  <para>Full path to a directory assigned to the package for its persistent data. </para>        
				/// </summary>
				/// <java-name>
				/// dataDir
				/// </java-name>
				[Dot42.DexImport("dataDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string DataDir;
				/// <summary>
				///  <para>Full path to the directory where native JNI libraries are stored. </para>        
				/// </summary>
				/// <java-name>
				/// nativeLibraryDir
				/// </java-name>
				[Dot42.DexImport("nativeLibraryDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string NativeLibraryDir;
				/// <summary>
				///  <para>The kernel user-ID that has been assigned to this application; currently this is not a unique ID (multiple applications can have the same uid). </para>        
				/// </summary>
				/// <java-name>
				/// uid
				/// </java-name>
				[Dot42.DexImport("uid", "I", AccessFlags = 1)]
				public int Uid;
				/// <summary>
				///  <para>The minimum SDK version this application targets. It may run on earlier versions, but it knows how to work with any new behavior added at this version. Will be android.os.Build.VERSION_CODES#CUR_DEVELOPMENT if this is a development build and the app is targeting that. You should compare that this number is &gt;= the SDK version number at which your behavior was introduced. </para>        
				/// </summary>
				/// <java-name>
				/// targetSdkVersion
				/// </java-name>
				[Dot42.DexImport("targetSdkVersion", "I", AccessFlags = 1)]
				public int TargetSdkVersion;
				/// <summary>
				///  <para>When false, indicates that all components within this application are considered disabled, regardless of their individually set enabled status. </para>        
				/// </summary>
				/// <java-name>
				/// enabled
				/// </java-name>
				[Dot42.DexImport("enabled", "Z", AccessFlags = 1)]
				public bool Enabled;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.ApplicationInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ApplicationInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ApplicationInfo;)V", AccessFlags = 1)]
				public ApplicationInfo(global::Android.Content.PM.ApplicationInfo orig) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the textual description of the application. This will call back on the given PackageManager to load the description from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a CharSequence containing the application's description. If there is no description, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// android/content/pm/ApplicationInfo$DisplayNameComparator
				/// </java-name>
				[Dot42.DexImport("android/content/pm/ApplicationInfo$DisplayNameComparator", AccessFlags = 9, Signature = "Ljava/lang/Object;Ljava/util/Comparator<Landroid/content/pm/ApplicationInfo;>;")]
				public partial class DisplayNameComparator : global::Java.Util.IComparator<global::Android.Content.PM.ApplicationInfo>
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageManager;)V", AccessFlags = 1)]
						public DisplayNameComparator(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// compare
						/// </java-name>
						[Dot42.DexImport("compare", "(Landroid/content/pm/ApplicationInfo;Landroid/content/pm/ApplicationInfo;)I", AccessFlags = 17)]
						public int Compare(global::Android.Content.PM.ApplicationInfo aa, global::Android.Content.PM.ApplicationInfo ab) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Base class containing information common to all application components (ActivityInfo, ServiceInfo). This class is not intended to be used by itself; it is simply here to share common definitions between all application components. As such, it does not itself implement Parcelable, but does provide convenience methods to assist in the implementation of Parcelable in subclasses. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/ComponentInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ComponentInfo", AccessFlags = 33)]
		public partial class ComponentInfo : global::Android.Content.PM.PackageItemInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Global information about the application/package this component is a part of. </para>        
				/// </summary>
				/// <java-name>
				/// applicationInfo
				/// </java-name>
				[Dot42.DexImport("applicationInfo", "Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ApplicationInfo ApplicationInfo;
				/// <summary>
				///  <para>The name of the process this component should run in. From the "android:process" attribute or, if not set, the same as  <b>applicationInfo.processName</b>. </para>        
				/// </summary>
				/// <java-name>
				/// processName
				/// </java-name>
				[Dot42.DexImport("processName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ProcessName;
				/// <summary>
				///  <para>A string resource identifier (in the package's resources) containing a user-readable description of the component. From the "description" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// descriptionRes
				/// </java-name>
				[Dot42.DexImport("descriptionRes", "I", AccessFlags = 1)]
				public int DescriptionRes;
				/// <summary>
				///  <para>Indicates whether or not this component may be instantiated. Note that this value can be overriden by the one in its parent ApplicationInfo. </para>        
				/// </summary>
				/// <java-name>
				/// enabled
				/// </java-name>
				[Dot42.DexImport("enabled", "Z", AccessFlags = 1)]
				public bool Enabled;
				/// <summary>
				///  <para>Set to true if this component is available for use by other applications. Comes from android:exported of the &lt;activity&gt;, &lt;receiver&gt;, &lt;service&gt;, or &lt;provider&gt; tag. </para>        
				/// </summary>
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
				public ComponentInfo(global::Android.Content.PM.ComponentInfo orig) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 4)]
				protected internal ComponentInfo(global::Android.OS.Parcel orig) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// dumpFront
				/// </java-name>
				[Dot42.DexImport("dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void DumpFront(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpBack
				/// </java-name>
				[Dot42.DexImport("dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void DumpBack(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int parcelableFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return whether this component and its enclosing application are enabled. </para>        
				/// </summary>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				public virtual bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return the icon resource identifier to use for this component. If the component defines an icon, that is used; else, the application icon is used.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The icon associated with this component. </para>
				/// </returns>
				/// <java-name>
				/// getIconResource
				/// </java-name>
				public int IconResource
				{
						[Dot42.DexImport("getIconResource", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Information you can retrieve about hardware configuration preferences declared by an application. This corresponds to information collected from the AndroidManifest.xml's &lt;uses-configuration&gt; and &lt;uses-feature&gt; tags. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/ConfigurationInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ConfigurationInfo", AccessFlags = 33)]
		public partial class ConfigurationInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The kind of touch screen attached to the device. One of: android.content.res.Configuration#TOUCHSCREEN_NOTOUCH, android.content.res.Configuration#TOUCHSCREEN_STYLUS, android.content.res.Configuration#TOUCHSCREEN_FINGER. </para>        
				/// </summary>
				/// <java-name>
				/// reqTouchScreen
				/// </java-name>
				[Dot42.DexImport("reqTouchScreen", "I", AccessFlags = 1)]
				public int ReqTouchScreen;
				/// <summary>
				///  <para>Application's input method preference. One of: android.content.res.Configuration#KEYBOARD_UNDEFINED, android.content.res.Configuration#KEYBOARD_NOKEYS, android.content.res.Configuration#KEYBOARD_QWERTY, android.content.res.Configuration#KEYBOARD_12KEY </para>        
				/// </summary>
				/// <java-name>
				/// reqKeyboardType
				/// </java-name>
				[Dot42.DexImport("reqKeyboardType", "I", AccessFlags = 1)]
				public int ReqKeyboardType;
				/// <summary>
				///  <para>A flag indicating whether any keyboard is available. one of: android.content.res.Configuration#NAVIGATION_UNDEFINED, android.content.res.Configuration#NAVIGATION_DPAD, android.content.res.Configuration#NAVIGATION_TRACKBALL, android.content.res.Configuration#NAVIGATION_WHEEL </para>        
				/// </summary>
				/// <java-name>
				/// reqNavigation
				/// </java-name>
				[Dot42.DexImport("reqNavigation", "I", AccessFlags = 1)]
				public int ReqNavigation;
				/// <summary>
				///  <para>Value for reqInputFeatures: if set, indicates that the application requires a hard keyboard </para>        
				/// </summary>
				/// <java-name>
				/// INPUT_FEATURE_HARD_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("INPUT_FEATURE_HARD_KEYBOARD", "I", AccessFlags = 25)]
				public const int INPUT_FEATURE_HARD_KEYBOARD = 1;
				/// <summary>
				///  <para>Value for reqInputFeatures: if set, indicates that the application requires a five way navigation device </para>        
				/// </summary>
				/// <java-name>
				/// INPUT_FEATURE_FIVE_WAY_NAV
				/// </java-name>
				[Dot42.DexImport("INPUT_FEATURE_FIVE_WAY_NAV", "I", AccessFlags = 25)]
				public const int INPUT_FEATURE_FIVE_WAY_NAV = 2;
				/// <summary>
				///  <para>Flags associated with the input features. Any combination of INPUT_FEATURE_HARD_KEYBOARD, INPUT_FEATURE_FIVE_WAY_NAV </para>        
				/// </summary>
				/// <java-name>
				/// reqInputFeatures
				/// </java-name>
				[Dot42.DexImport("reqInputFeatures", "I", AccessFlags = 1)]
				public int ReqInputFeatures;
				/// <summary>
				///  <para>Default value for reqGlEsVersion; </para>        
				/// </summary>
				/// <java-name>
				/// GL_ES_VERSION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("GL_ES_VERSION_UNDEFINED", "I", AccessFlags = 25)]
				public const int GL_ES_VERSION_UNDEFINED = 0;
				/// <summary>
				///  <para>The GLES version used by an application. The upper order 16 bits represent the major version and the lower order 16 bits the minor version. </para>        
				/// </summary>
				/// <java-name>
				/// reqGlEsVersion
				/// </java-name>
				[Dot42.DexImport("reqGlEsVersion", "I", AccessFlags = 1)]
				public int ReqGlEsVersion;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.ConfigurationInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ConfigurationInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ConfigurationInfo;)V", AccessFlags = 1)]
				public ConfigurationInfo(global::Android.Content.PM.ConfigurationInfo orig) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method extracts the major and minor version of reqGLEsVersion attribute and returns it as a string. Say reqGlEsVersion value of 0x00010002 is returned as 1.2 </para>        
				/// </summary>
				/// <returns>
				///  <para>String representation of the reqGlEsVersion attribute </para>
				/// </returns>
				/// <java-name>
				/// getGlEsVersion
				/// </java-name>
				public virtual string GlEsVersion
				{
						[Dot42.DexImport("getGlEsVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>A single feature that can be requested by an application. This corresponds to information collected from the AndroidManifest.xml's &lt;uses-feature&gt; tag. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/FeatureInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/FeatureInfo", AccessFlags = 33)]
		public partial class FeatureInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The name of this feature, for example "android.hardware.camera". If this is null, then this is an OpenGL ES version feature as described in reqGlEsVersion. </para>        
				/// </summary>
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
				public string Name;
				/// <summary>
				///  <para>Default value for reqGlEsVersion; </para>        
				/// </summary>
				/// <java-name>
				/// GL_ES_VERSION_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("GL_ES_VERSION_UNDEFINED", "I", AccessFlags = 25)]
				public const int GL_ES_VERSION_UNDEFINED = 0;
				/// <summary>
				///  <para>The GLES version used by an application. The upper order 16 bits represent the major version and the lower order 16 bits the minor version. Only valid if name is null. </para>        
				/// </summary>
				/// <java-name>
				/// reqGlEsVersion
				/// </java-name>
				[Dot42.DexImport("reqGlEsVersion", "I", AccessFlags = 1)]
				public int ReqGlEsVersion;
				/// <summary>
				///  <para>Set on flags if this feature has been required by the application. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_REQUIRED
				/// </java-name>
				[Dot42.DexImport("FLAG_REQUIRED", "I", AccessFlags = 25)]
				public const int FLAG_REQUIRED = 1;
				/// <summary>
				///  <para>Additional flags. May be zero or more of FLAG_REQUIRED. </para>        
				/// </summary>
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.FeatureInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FeatureInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/FeatureInfo;)V", AccessFlags = 1)]
				public FeatureInfo(global::Android.Content.PM.FeatureInfo orig) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method extracts the major and minor version of reqGLEsVersion attribute and returns it as a string. Say reqGlEsVersion value of 0x00010002 is returned as 1.2 </para>        
				/// </summary>
				/// <returns>
				///  <para>String representation of the reqGlEsVersion attribute </para>
				/// </returns>
				/// <java-name>
				/// getGlEsVersion
				/// </java-name>
				public virtual string GlEsVersion
				{
						[Dot42.DexImport("getGlEsVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Information you can retrieve about a particular piece of test instrumentation. This corresponds to information collected from the AndroidManifest.xml's &lt;instrumentation&gt; tag. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/InstrumentationInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/InstrumentationInfo", AccessFlags = 33)]
		public partial class InstrumentationInfo : global::Android.Content.PM.PackageItemInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The name of the application package being instrumented. From the "package" attribute. </para>        
				/// </summary>
				/// <java-name>
				/// targetPackage
				/// </java-name>
				[Dot42.DexImport("targetPackage", "Ljava/lang/String;", AccessFlags = 1)]
				public string TargetPackage;
				/// <summary>
				///  <para>Full path to the location of this package. </para>        
				/// </summary>
				/// <java-name>
				/// sourceDir
				/// </java-name>
				[Dot42.DexImport("sourceDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string SourceDir;
				/// <summary>
				///  <para>Full path to the location of the publicly available parts of this package (i.e. the resources and manifest). For non-forward-locked apps this will be the same as sourceDir).</para>        
				/// </summary>
				/// <java-name>
				/// publicSourceDir
				/// </java-name>
				[Dot42.DexImport("publicSourceDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string PublicSourceDir;
				/// <summary>
				///  <para>Full path to a directory assigned to the package for its persistent data. </para>        
				/// </summary>
				/// <java-name>
				/// dataDir
				/// </java-name>
				[Dot42.DexImport("dataDir", "Ljava/lang/String;", AccessFlags = 1)]
				public string DataDir;
				/// <summary>
				///  <para>Specifies whether or not this instrumentation will handle profiling. </para>        
				/// </summary>
				/// <java-name>
				/// handleProfiling
				/// </java-name>
				[Dot42.DexImport("handleProfiling", "Z", AccessFlags = 1)]
				public bool HandleProfiling;
				/// <summary>
				///  <para>Specifies whether or not to run this instrumentation as a functional test </para>        
				/// </summary>
				/// <java-name>
				/// functionalTest
				/// </java-name>
				[Dot42.DexImport("functionalTest", "Z", AccessFlags = 1)]
				public bool FunctionalTest;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.InstrumentationInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InstrumentationInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/InstrumentationInfo;)V", AccessFlags = 1)]
				public InstrumentationInfo(global::Android.Content.PM.InstrumentationInfo orig) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A special subclass of Intent that can have a custom label/icon associated with it. Primarily for use with Intent#ACTION_CHOOSER. </para>    
		/// </summary>
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
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.LabeledIntent> CREATOR;
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

				/// <summary>
				///  <para>Retrieve the label associated with this object. If the object does not have a label, null will be returned, in which case you will probably want to load the label from the underlying resolved info for the Intent. </para>        
				/// </summary>
				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Retrieve the icon associated with this object. If the object does not have a icon, null will be returned, in which case you will probably want to load the icon from the underlying resolved info for the Intent. </para>        
				/// </summary>
				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable LoadIcon(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public override void ReadFromParcel(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LabeledIntent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the name of the package holding label and icon resources. </para>        
				/// </summary>
				/// <java-name>
				/// getSourcePackage
				/// </java-name>
				public virtual string SourcePackage
				{
						[Dot42.DexImport("getSourcePackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return any resource identifier that has been given for the label text. </para>        
				/// </summary>
				/// <java-name>
				/// getLabelResource
				/// </java-name>
				public virtual int LabelResource
				{
						[Dot42.DexImport("getLabelResource", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return any concrete text that has been given for the label text. </para>        
				/// </summary>
				/// <java-name>
				/// getNonLocalizedLabel
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence NonLocalizedLabel
				{
						[Dot42.DexImport("getNonLocalizedLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <summary>
				///  <para>Return any resource identifier that has been given for the label icon. </para>        
				/// </summary>
				/// <java-name>
				/// getIconResource
				/// </java-name>
				public virtual int IconResource
				{
						[Dot42.DexImport("getIconResource", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Overall information about the contents of a package. This corresponds to all of the information collected from AndroidManifest.xml. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/PackageInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PackageInfo", AccessFlags = 33)]
		public partial class PackageInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The name of this package. From the &lt;manifest&gt; tag's "name" attribute. </para>        
				/// </summary>
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <summary>
				///  <para>The version number of this package, as specified by the &lt;manifest&gt; tag's versionCode attribute. </para>        
				/// </summary>
				/// <java-name>
				/// versionCode
				/// </java-name>
				[Dot42.DexImport("versionCode", "I", AccessFlags = 1)]
				public int VersionCode;
				/// <summary>
				///  <para>The version name of this package, as specified by the &lt;manifest&gt; tag's versionName attribute. </para>        
				/// </summary>
				/// <java-name>
				/// versionName
				/// </java-name>
				[Dot42.DexImport("versionName", "Ljava/lang/String;", AccessFlags = 1)]
				public string VersionName;
				/// <summary>
				///  <para>The shared user ID name of this package, as specified by the &lt;manifest&gt; tag's sharedUserId attribute. </para>        
				/// </summary>
				/// <java-name>
				/// sharedUserId
				/// </java-name>
				[Dot42.DexImport("sharedUserId", "Ljava/lang/String;", AccessFlags = 1)]
				public string SharedUserId;
				/// <summary>
				///  <para>The shared user ID label of this package, as specified by the &lt;manifest&gt; tag's sharedUserLabel attribute. </para>        
				/// </summary>
				/// <java-name>
				/// sharedUserLabel
				/// </java-name>
				[Dot42.DexImport("sharedUserLabel", "I", AccessFlags = 1)]
				public int SharedUserLabel;
				/// <summary>
				///  <para>Information collected from the &lt;application&gt; tag, or null if there was none. </para>        
				/// </summary>
				/// <java-name>
				/// applicationInfo
				/// </java-name>
				[Dot42.DexImport("applicationInfo", "Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ApplicationInfo ApplicationInfo;
				/// <summary>
				///  <para>The time at which the app was first installed. Units are as per System#currentTimeMillis(). </para>        
				/// </summary>
				/// <java-name>
				/// firstInstallTime
				/// </java-name>
				[Dot42.DexImport("firstInstallTime", "J", AccessFlags = 1)]
				public long FirstInstallTime;
				/// <summary>
				///  <para>The time at which the app was last updated. Units are as per System#currentTimeMillis(). </para>        
				/// </summary>
				/// <java-name>
				/// lastUpdateTime
				/// </java-name>
				[Dot42.DexImport("lastUpdateTime", "J", AccessFlags = 1)]
				public long LastUpdateTime;
				/// <summary>
				///  <para>All kernel group-IDs that have been assigned to this package. This is only filled in if the flag PackageManager#GET_GIDS was set. </para>        
				/// </summary>
				/// <java-name>
				/// gids
				/// </java-name>
				[Dot42.DexImport("gids", "[I", AccessFlags = 1)]
				public int[] Gids;
				/// <summary>
				///  <para>Array of all &lt;activity&gt; tags included under &lt;application&gt;, or null if there were none. This is only filled in if the flag PackageManager#GET_ACTIVITIES was set. </para>        
				/// </summary>
				/// <java-name>
				/// activities
				/// </java-name>
				[Dot42.DexImport("activities", "[Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ActivityInfo[] Activities;
				/// <summary>
				///  <para>Array of all &lt;receiver&gt; tags included under &lt;application&gt;, or null if there were none. This is only filled in if the flag PackageManager#GET_RECEIVERS was set. </para>        
				/// </summary>
				/// <java-name>
				/// receivers
				/// </java-name>
				[Dot42.DexImport("receivers", "[Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ActivityInfo[] Receivers;
				/// <summary>
				///  <para>Array of all &lt;service&gt; tags included under &lt;application&gt;, or null if there were none. This is only filled in if the flag PackageManager#GET_SERVICES was set. </para>        
				/// </summary>
				/// <java-name>
				/// services
				/// </java-name>
				[Dot42.DexImport("services", "[Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ServiceInfo[] Services;
				/// <summary>
				///  <para>Array of all &lt;provider&gt; tags included under &lt;application&gt;, or null if there were none. This is only filled in if the flag PackageManager#GET_PROVIDERS was set. </para>        
				/// </summary>
				/// <java-name>
				/// providers
				/// </java-name>
				[Dot42.DexImport("providers", "[Landroid/content/pm/ProviderInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ProviderInfo[] Providers;
				/// <summary>
				///  <para>Array of all &lt;instrumentation&gt; tags included under &lt;manifest&gt;, or null if there were none. This is only filled in if the flag PackageManager#GET_INSTRUMENTATION was set. </para>        
				/// </summary>
				/// <java-name>
				/// instrumentation
				/// </java-name>
				[Dot42.DexImport("instrumentation", "[Landroid/content/pm/InstrumentationInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.InstrumentationInfo[] Instrumentation;
				/// <summary>
				///  <para>Array of all &lt;permission&gt; tags included under &lt;manifest&gt;, or null if there were none. This is only filled in if the flag PackageManager#GET_PERMISSIONS was set. </para>        
				/// </summary>
				/// <java-name>
				/// permissions
				/// </java-name>
				[Dot42.DexImport("permissions", "[Landroid/content/pm/PermissionInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.PermissionInfo[] Permissions;
				/// <summary>
				///  <para>Array of all &lt;uses-permission&gt; tags included under &lt;manifest&gt;, or null if there were none. This is only filled in if the flag PackageManager#GET_PERMISSIONS was set. This list includes all permissions requested, even those that were not granted or known by the system at install time. </para>        
				/// </summary>
				/// <java-name>
				/// requestedPermissions
				/// </java-name>
				[Dot42.DexImport("requestedPermissions", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] RequestedPermissions;
				/// <summary>
				///  <para>Array of all signatures read from the package file. This is only filled in if the flag PackageManager#GET_SIGNATURES was set. </para>        
				/// </summary>
				/// <java-name>
				/// signatures
				/// </java-name>
				[Dot42.DexImport("signatures", "[Landroid/content/pm/Signature;", AccessFlags = 1)]
				public global::Android.Content.PM.Signature[] Signatures;
				/// <summary>
				///  <para>Application specified preferred configuration &lt;uses-configuration&gt; tags included under &lt;manifest&gt;, or null if there were none. This is only filled in if the flag PackageManager#GET_CONFIGURATIONS was set. </para>        
				/// </summary>
				/// <java-name>
				/// configPreferences
				/// </java-name>
				[Dot42.DexImport("configPreferences", "[Landroid/content/pm/ConfigurationInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ConfigurationInfo[] ConfigPreferences;
				/// <summary>
				///  <para>The features that this application has said it requires. </para>        
				/// </summary>
				/// <java-name>
				/// reqFeatures
				/// </java-name>
				[Dot42.DexImport("reqFeatures", "[Landroid/content/pm/FeatureInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.FeatureInfo[] ReqFeatures;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.PackageInfo> CREATOR;
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Base class containing information common to all package items held by the package manager. This provides a very common basic set of attributes: a label, icon, and meta-data. This class is not intended to be used by itself; it is simply here to share common definitions between all items returned by the package manager. As such, it does not itself implement Parcelable, but does provide convenience methods to assist in the implementation of Parcelable in subclasses. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/PackageItemInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PackageItemInfo", AccessFlags = 33)]
		public partial class PackageItemInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Public name of this item. From the "android:name" attribute. </para>        
				/// </summary>
				/// <java-name>
				/// name
				/// </java-name>
				[Dot42.DexImport("name", "Ljava/lang/String;", AccessFlags = 1)]
				public string Name;
				/// <summary>
				///  <para>Name of the package that this item is in. </para>        
				/// </summary>
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <summary>
				///  <para>A string resource identifier (in the package's resources) of this component's label. From the "label" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// labelRes
				/// </java-name>
				[Dot42.DexImport("labelRes", "I", AccessFlags = 1)]
				public int LabelRes;
				/// <summary>
				///  <para>The string provided in the AndroidManifest file, if any. You probably don't want to use this. You probably want PackageManager#getApplicationLabel </para>        
				/// </summary>
				/// <java-name>
				/// nonLocalizedLabel
				/// </java-name>
				[Dot42.DexImport("nonLocalizedLabel", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence NonLocalizedLabel;
				/// <summary>
				///  <para>A drawable resource identifier (in the package's resources) of this component's icon. From the "icon" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <summary>
				///  <para>A drawable resource identifier (in the package's resources) of this component's logo. Logos may be larger/wider than icons and are displayed by certain UI elements in place of a name or name/icon combination. From the "logo" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// logo
				/// </java-name>
				[Dot42.DexImport("logo", "I", AccessFlags = 1)]
				public int Logo;
				/// <summary>
				///  <para>Additional meta-data associated with this component. This field will only be filled in if you set the PackageManager#GET_META_DATA flag when requesting the info. </para>        
				/// </summary>
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
				public PackageItemInfo(global::Android.Content.PM.PackageItemInfo orig) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 4)]
				protected internal PackageItemInfo(global::Android.OS.Parcel orig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current textual label associated with this item. This will call back on the given PackageManager to load the label from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a CharSequence containing the item's label. If the item does not have a label, its name is returned. </para>
				/// </returns>
				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Retrieve the current graphical icon associated with this item. This will call back on the given PackageManager to load the icon from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a Drawable containing the item's icon. If the item does not have an icon, the item's default icon is returned such as the default activity icon. </para>
				/// </returns>
				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable LoadIcon(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Retrieve the current graphical logo associated with this item. This will call back on the given PackageManager to load the logo from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a Drawable containing the item's logo. If the item does not have a logo, this method will return null. </para>
				/// </returns>
				/// <java-name>
				/// loadLogo
				/// </java-name>
				[Dot42.DexImport("loadLogo", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable LoadLogo(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <summary>
				///  <para>Load an XML resource attached to the meta-data of this item. This will retrieved the name meta-data entry, and if defined call back on the given PackageManager to load its XML file from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an XmlPullParser you can use to parse the XML file assigned as the given meta-data. If the meta-data name is not defined or the XML resource could not be found, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// loadXmlMetaData
				/// </java-name>
				[Dot42.DexImport("loadXmlMetaData", "(Landroid/content/pm/PackageManager;Ljava/lang/String;)Landroid/content/res/XmlRe" +
    "sourceParser;", AccessFlags = 1)]
				public virtual global::Android.Content.Res.IXmlResourceParser LoadXmlMetaData(global::Android.Content.PM.PackageManager pm, string name) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// dumpFront
				/// </java-name>
				[Dot42.DexImport("dumpFront", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void DumpFront(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpBack
				/// </java-name>
				[Dot42.DexImport("dumpBack", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void DumpBack(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int parcelableFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/content/pm/PackageItemInfo$DisplayNameComparator
				/// </java-name>
				[Dot42.DexImport("android/content/pm/PackageItemInfo$DisplayNameComparator", AccessFlags = 9, Signature = "Ljava/lang/Object;Ljava/util/Comparator<Landroid/content/pm/PackageItemInfo;>;")]
				public partial class DisplayNameComparator : global::Java.Util.IComparator<global::Android.Content.PM.PackageItemInfo>
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageManager;)V", AccessFlags = 1)]
						public DisplayNameComparator(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// compare
						/// </java-name>
						[Dot42.DexImport("compare", "(Landroid/content/pm/PackageItemInfo;Landroid/content/pm/PackageItemInfo;)I", AccessFlags = 17)]
						public int Compare(global::Android.Content.PM.PackageItemInfo aa, global::Android.Content.PM.PackageItemInfo ab) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Class for retrieving various kinds of information related to the application packages that are currently installed on the device.</para> <para>You can find this class through Context#getPackageManager. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/PackageManager
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PackageManager", AccessFlags = 1057)]
		public abstract partial class PackageManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>PackageInfo flag: return information about activities in the package in PackageInfo#activities. </para>        
				/// </summary>
				/// <java-name>
				/// GET_ACTIVITIES
				/// </java-name>
				[Dot42.DexImport("GET_ACTIVITIES", "I", AccessFlags = 25)]
				public const int GET_ACTIVITIES = 1;
				/// <summary>
				///  <para>PackageInfo flag: return information about intent receivers in the package in PackageInfo#receivers. </para>        
				/// </summary>
				/// <java-name>
				/// GET_RECEIVERS
				/// </java-name>
				[Dot42.DexImport("GET_RECEIVERS", "I", AccessFlags = 25)]
				public const int GET_RECEIVERS = 2;
				/// <summary>
				///  <para>PackageInfo flag: return information about services in the package in PackageInfo#services. </para>        
				/// </summary>
				/// <java-name>
				/// GET_SERVICES
				/// </java-name>
				[Dot42.DexImport("GET_SERVICES", "I", AccessFlags = 25)]
				public const int GET_SERVICES = 4;
				/// <summary>
				///  <para>PackageInfo flag: return information about content providers in the package in PackageInfo#providers. </para>        
				/// </summary>
				/// <java-name>
				/// GET_PROVIDERS
				/// </java-name>
				[Dot42.DexImport("GET_PROVIDERS", "I", AccessFlags = 25)]
				public const int GET_PROVIDERS = 8;
				/// <summary>
				///  <para>PackageInfo flag: return information about instrumentation in the package in PackageInfo#instrumentation. </para>        
				/// </summary>
				/// <java-name>
				/// GET_INSTRUMENTATION
				/// </java-name>
				[Dot42.DexImport("GET_INSTRUMENTATION", "I", AccessFlags = 25)]
				public const int GET_INSTRUMENTATION = 16;
				/// <summary>
				///  <para>PackageInfo flag: return information about the intent filters supported by the activity. </para>        
				/// </summary>
				/// <java-name>
				/// GET_INTENT_FILTERS
				/// </java-name>
				[Dot42.DexImport("GET_INTENT_FILTERS", "I", AccessFlags = 25)]
				public const int GET_INTENT_FILTERS = 32;
				/// <summary>
				///  <para>PackageInfo flag: return information about the signatures included in the package. </para>        
				/// </summary>
				/// <java-name>
				/// GET_SIGNATURES
				/// </java-name>
				[Dot42.DexImport("GET_SIGNATURES", "I", AccessFlags = 25)]
				public const int GET_SIGNATURES = 64;
				/// <summary>
				///  <para>ResolveInfo flag: return the IntentFilter that was matched for a particular ResolveInfo in ResolveInfo#filter. </para>        
				/// </summary>
				/// <java-name>
				/// GET_RESOLVED_FILTER
				/// </java-name>
				[Dot42.DexImport("GET_RESOLVED_FILTER", "I", AccessFlags = 25)]
				public const int GET_RESOLVED_FILTER = 64;
				/// <summary>
				///  <para>ComponentInfo flag: return the ComponentInfo#metaData data android.os.Bundles that are associated with a component. This applies for any API returning a ComponentInfo subclass. </para>        
				/// </summary>
				/// <java-name>
				/// GET_META_DATA
				/// </java-name>
				[Dot42.DexImport("GET_META_DATA", "I", AccessFlags = 25)]
				public const int GET_META_DATA = 128;
				/// <summary>
				///  <para>PackageInfo flag: return the group ids that are associated with an application. This applies for any API returning a PackageInfo class, either directly or nested inside of another. </para>        
				/// </summary>
				/// <java-name>
				/// GET_GIDS
				/// </java-name>
				[Dot42.DexImport("GET_GIDS", "I", AccessFlags = 25)]
				public const int GET_GIDS = 256;
				/// <summary>
				///  <para>PackageInfo flag: include disabled components in the returned info. </para>        
				/// </summary>
				/// <java-name>
				/// GET_DISABLED_COMPONENTS
				/// </java-name>
				[Dot42.DexImport("GET_DISABLED_COMPONENTS", "I", AccessFlags = 25)]
				public const int GET_DISABLED_COMPONENTS = 512;
				/// <summary>
				///  <para>ApplicationInfo flag: return the paths to the shared libraries that are associated with an application. This applies for any API returning an ApplicationInfo class, either directly or nested inside of another. </para>        
				/// </summary>
				/// <java-name>
				/// GET_SHARED_LIBRARY_FILES
				/// </java-name>
				[Dot42.DexImport("GET_SHARED_LIBRARY_FILES", "I", AccessFlags = 25)]
				public const int GET_SHARED_LIBRARY_FILES = 1024;
				/// <summary>
				///  <para>ProviderInfo flag: return the URI permission patterns that are associated with a content provider. This applies for any API returning a ProviderInfo class, either directly or nested inside of another. </para>        
				/// </summary>
				/// <java-name>
				/// GET_URI_PERMISSION_PATTERNS
				/// </java-name>
				[Dot42.DexImport("GET_URI_PERMISSION_PATTERNS", "I", AccessFlags = 25)]
				public const int GET_URI_PERMISSION_PATTERNS = 2048;
				/// <summary>
				///  <para>PackageInfo flag: return information about permissions in the package in PackageInfo#permissions. </para>        
				/// </summary>
				/// <java-name>
				/// GET_PERMISSIONS
				/// </java-name>
				[Dot42.DexImport("GET_PERMISSIONS", "I", AccessFlags = 25)]
				public const int GET_PERMISSIONS = 4096;
				/// <summary>
				///  <para>Flag parameter to retrieve some information about all applications (even uninstalled ones) which have data directories. This state could have resulted if applications have been deleted with flag  <c>DONT_DELETE_DATA </c> with a possibility of being replaced or reinstalled in future. </para> <para>Note: this flag may cause less information about currently installed applications to be returned. </para>        
				/// </summary>
				/// <java-name>
				/// GET_UNINSTALLED_PACKAGES
				/// </java-name>
				[Dot42.DexImport("GET_UNINSTALLED_PACKAGES", "I", AccessFlags = 25)]
				public const int GET_UNINSTALLED_PACKAGES = 8192;
				/// <summary>
				///  <para>PackageInfo flag: return information about hardware preferences in PackageInfo.configPreferences and requested features in PackageInfo.reqFeatures. </para>        
				/// </summary>
				/// <java-name>
				/// GET_CONFIGURATIONS
				/// </java-name>
				[Dot42.DexImport("GET_CONFIGURATIONS", "I", AccessFlags = 25)]
				public const int GET_CONFIGURATIONS = 16384;
				/// <summary>
				///  <para>Resolution and querying flag: if set, only filters that support the android.content.Intent#CATEGORY_DEFAULT will be considered for matching. This is a synonym for including the CATEGORY_DEFAULT in your supplied Intent. </para>        
				/// </summary>
				/// <java-name>
				/// MATCH_DEFAULT_ONLY
				/// </java-name>
				[Dot42.DexImport("MATCH_DEFAULT_ONLY", "I", AccessFlags = 25)]
				public const int MATCH_DEFAULT_ONLY = 65536;
				/// <summary>
				///  <para>Permission check result: this is returned by checkPermission if the permission has been granted to the given package. </para>        
				/// </summary>
				/// <java-name>
				/// PERMISSION_GRANTED
				/// </java-name>
				[Dot42.DexImport("PERMISSION_GRANTED", "I", AccessFlags = 25)]
				public const int PERMISSION_GRANTED = 0;
				/// <summary>
				///  <para>Permission check result: this is returned by checkPermission if the permission has not been granted to the given package. </para>        
				/// </summary>
				/// <java-name>
				/// PERMISSION_DENIED
				/// </java-name>
				[Dot42.DexImport("PERMISSION_DENIED", "I", AccessFlags = 25)]
				public const int PERMISSION_DENIED = -1;
				/// <summary>
				///  <para>Signature check result: this is returned by checkSignatures if all signatures on the two packages match. </para>        
				/// </summary>
				/// <java-name>
				/// SIGNATURE_MATCH
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_MATCH", "I", AccessFlags = 25)]
				public const int SIGNATURE_MATCH = 0;
				/// <summary>
				///  <para>Signature check result: this is returned by checkSignatures if neither of the two packages is signed. </para>        
				/// </summary>
				/// <java-name>
				/// SIGNATURE_NEITHER_SIGNED
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_NEITHER_SIGNED", "I", AccessFlags = 25)]
				public const int SIGNATURE_NEITHER_SIGNED = 1;
				/// <summary>
				///  <para>Signature check result: this is returned by checkSignatures if the first package is not signed but the second is. </para>        
				/// </summary>
				/// <java-name>
				/// SIGNATURE_FIRST_NOT_SIGNED
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_FIRST_NOT_SIGNED", "I", AccessFlags = 25)]
				public const int SIGNATURE_FIRST_NOT_SIGNED = -1;
				/// <summary>
				///  <para>Signature check result: this is returned by checkSignatures if the second package is not signed but the first is. </para>        
				/// </summary>
				/// <java-name>
				/// SIGNATURE_SECOND_NOT_SIGNED
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_SECOND_NOT_SIGNED", "I", AccessFlags = 25)]
				public const int SIGNATURE_SECOND_NOT_SIGNED = -2;
				/// <summary>
				///  <para>Signature check result: this is returned by checkSignatures if not all signatures on both packages match. </para>        
				/// </summary>
				/// <java-name>
				/// SIGNATURE_NO_MATCH
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_NO_MATCH", "I", AccessFlags = 25)]
				public const int SIGNATURE_NO_MATCH = -3;
				/// <summary>
				///  <para>Signature check result: this is returned by checkSignatures if either of the packages are not valid. </para>        
				/// </summary>
				/// <java-name>
				/// SIGNATURE_UNKNOWN_PACKAGE
				/// </java-name>
				[Dot42.DexImport("SIGNATURE_UNKNOWN_PACKAGE", "I", AccessFlags = 25)]
				public const int SIGNATURE_UNKNOWN_PACKAGE = -4;
				/// <summary>
				///  <para>Flag for setApplicationEnabledSetting(String, int, int) and setComponentEnabledSetting(ComponentName, int, int): This component or application is in its default enabled state (as specified in its manifest). </para>        
				/// </summary>
				/// <java-name>
				/// COMPONENT_ENABLED_STATE_DEFAULT
				/// </java-name>
				[Dot42.DexImport("COMPONENT_ENABLED_STATE_DEFAULT", "I", AccessFlags = 25)]
				public const int COMPONENT_ENABLED_STATE_DEFAULT = 0;
				/// <summary>
				///  <para>Flag for setApplicationEnabledSetting(String, int, int) and setComponentEnabledSetting(ComponentName, int, int): This component or application has been explictily enabled, regardless of what it has specified in its manifest. </para>        
				/// </summary>
				/// <java-name>
				/// COMPONENT_ENABLED_STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("COMPONENT_ENABLED_STATE_ENABLED", "I", AccessFlags = 25)]
				public const int COMPONENT_ENABLED_STATE_ENABLED = 1;
				/// <summary>
				///  <para>Flag for setApplicationEnabledSetting(String, int, int) and setComponentEnabledSetting(ComponentName, int, int): This component or application has been explicitly disabled, regardless of what it has specified in its manifest. </para>        
				/// </summary>
				/// <java-name>
				/// COMPONENT_ENABLED_STATE_DISABLED
				/// </java-name>
				[Dot42.DexImport("COMPONENT_ENABLED_STATE_DISABLED", "I", AccessFlags = 25)]
				public const int COMPONENT_ENABLED_STATE_DISABLED = 2;
				/// <summary>
				///  <para>Flag parameter for setComponentEnabledSetting(android.content.ComponentName, int, int) to indicate that you don't want to kill the app containing the component. Be careful when you set this since changing component states can make the containing application's behavior unpredictable. </para>        
				/// </summary>
				/// <java-name>
				/// DONT_KILL_APP
				/// </java-name>
				[Dot42.DexImport("DONT_KILL_APP", "I", AccessFlags = 25)]
				public const int DONT_KILL_APP = 1;
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device's audio pipeline is low-latency, more suitable for audio applications sensitive to delays or lag in sound input or output. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_AUDIO_LOW_LATENCY
				/// </java-name>
				[Dot42.DexImport("FEATURE_AUDIO_LOW_LATENCY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_AUDIO_LOW_LATENCY = "android.hardware.audio.low_latency";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device is capable of communicating with other devices via Bluetooth. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_BLUETOOTH
				/// </java-name>
				[Dot42.DexImport("FEATURE_BLUETOOTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_BLUETOOTH = "android.hardware.bluetooth";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device has a camera facing away from the screen. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_CAMERA
				/// </java-name>
				[Dot42.DexImport("FEATURE_CAMERA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_CAMERA = "android.hardware.camera";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device's camera supports auto-focus. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_CAMERA_AUTOFOCUS
				/// </java-name>
				[Dot42.DexImport("FEATURE_CAMERA_AUTOFOCUS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_CAMERA_AUTOFOCUS = "android.hardware.camera.autofocus";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device's camera supports flash. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_CAMERA_FLASH
				/// </java-name>
				[Dot42.DexImport("FEATURE_CAMERA_FLASH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_CAMERA_FLASH = "android.hardware.camera.flash";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device has a front facing camera. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_CAMERA_FRONT
				/// </java-name>
				[Dot42.DexImport("FEATURE_CAMERA_FRONT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_CAMERA_FRONT = "android.hardware.camera.front";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device supports one or more methods of reporting current location. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_LOCATION
				/// </java-name>
				[Dot42.DexImport("FEATURE_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_LOCATION = "android.hardware.location";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device has a Global Positioning System receiver and can report precise location. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_LOCATION_GPS
				/// </java-name>
				[Dot42.DexImport("FEATURE_LOCATION_GPS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_LOCATION_GPS = "android.hardware.location.gps";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device can report location with coarse accuracy using a network-based geolocation system. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_LOCATION_NETWORK
				/// </java-name>
				[Dot42.DexImport("FEATURE_LOCATION_NETWORK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_LOCATION_NETWORK = "android.hardware.location.network";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device can record audio via a microphone. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_MICROPHONE
				/// </java-name>
				[Dot42.DexImport("FEATURE_MICROPHONE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_MICROPHONE = "android.hardware.microphone";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device can communicate using Near-Field Communications (NFC). </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_NFC
				/// </java-name>
				[Dot42.DexImport("FEATURE_NFC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_NFC = "android.hardware.nfc";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device includes an accelerometer. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SENSOR_ACCELEROMETER
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_ACCELEROMETER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_ACCELEROMETER = "android.hardware.sensor.accelerometer";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device includes a barometer (air pressure sensor.) </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SENSOR_BAROMETER
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_BAROMETER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_BAROMETER = "android.hardware.sensor.barometer";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device includes a magnetometer (compass). </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SENSOR_COMPASS
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_COMPASS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_COMPASS = "android.hardware.sensor.compass";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device includes a gyroscope. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SENSOR_GYROSCOPE
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_GYROSCOPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_GYROSCOPE = "android.hardware.sensor.gyroscope";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device includes a light sensor. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SENSOR_LIGHT
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_LIGHT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_LIGHT = "android.hardware.sensor.light";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device includes a proximity sensor. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SENSOR_PROXIMITY
				/// </java-name>
				[Dot42.DexImport("FEATURE_SENSOR_PROXIMITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SENSOR_PROXIMITY = "android.hardware.sensor.proximity";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device has a telephony radio with data communication support. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_TELEPHONY
				/// </java-name>
				[Dot42.DexImport("FEATURE_TELEPHONY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TELEPHONY = "android.hardware.telephony";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device has a CDMA telephony stack. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_TELEPHONY_CDMA
				/// </java-name>
				[Dot42.DexImport("FEATURE_TELEPHONY_CDMA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TELEPHONY_CDMA = "android.hardware.telephony.cdma";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device has a GSM telephony stack. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_TELEPHONY_GSM
				/// </java-name>
				[Dot42.DexImport("FEATURE_TELEPHONY_GSM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TELEPHONY_GSM = "android.hardware.telephony.gsm";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device supports connecting to USB devices as the USB host. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_USB_HOST
				/// </java-name>
				[Dot42.DexImport("FEATURE_USB_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_USB_HOST = "android.hardware.usb.host";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device supports connecting to USB accessories. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_USB_ACCESSORY
				/// </java-name>
				[Dot42.DexImport("FEATURE_USB_ACCESSORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_USB_ACCESSORY = "android.hardware.usb.accessory";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The SIP API is enabled on the device. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SIP
				/// </java-name>
				[Dot42.DexImport("FEATURE_SIP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SIP = "android.software.sip";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device supports SIP-based VOIP. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SIP_VOIP
				/// </java-name>
				[Dot42.DexImport("FEATURE_SIP_VOIP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SIP_VOIP = "android.software.sip.voip";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device's display has a touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_TOUCHSCREEN
				/// </java-name>
				[Dot42.DexImport("FEATURE_TOUCHSCREEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TOUCHSCREEN = "android.hardware.touchscreen";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device's touch screen supports multitouch sufficient for basic two-finger gesture detection. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_TOUCHSCREEN_MULTITOUCH
				/// </java-name>
				[Dot42.DexImport("FEATURE_TOUCHSCREEN_MULTITOUCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TOUCHSCREEN_MULTITOUCH = "android.hardware.touchscreen.multitouch";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device's touch screen is capable of tracking two or more fingers fully independently. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_TOUCHSCREEN_MULTITOUCH_DISTINCT
				/// </java-name>
				[Dot42.DexImport("FEATURE_TOUCHSCREEN_MULTITOUCH_DISTINCT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TOUCHSCREEN_MULTITOUCH_DISTINCT = "android.hardware.touchscreen.multitouch.distinct";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device's touch screen is capable of tracking a full hand of fingers fully independently  that is, 5 or more simultaneous independent pointers. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_TOUCHSCREEN_MULTITOUCH_JAZZHAND
				/// </java-name>
				[Dot42.DexImport("FEATURE_TOUCHSCREEN_MULTITOUCH_JAZZHAND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_TOUCHSCREEN_MULTITOUCH_JAZZHAND = "android.hardware.touchscreen.multitouch.jazzhand";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device does not have a touch screen, but does support touch emulation for basic events. For instance, the device might use a mouse or remote control to drive a cursor, and emulate basic touch pointer events like down, up, drag, etc. All devices that support android.hardware.touchscreen or a sub-feature are presumed to also support faketouch. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_FAKETOUCH
				/// </java-name>
				[Dot42.DexImport("FEATURE_FAKETOUCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_FAKETOUCH = "android.hardware.faketouch";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device does not have a touch screen, but does support touch emulation for basic events that supports distinct tracking of two or more fingers. This is an extension of FEATURE_FAKETOUCH for input devices with this capability. Note that unlike a distinct multitouch screen as defined by FEATURE_TOUCHSCREEN_MULTITOUCH_DISTINCT, these kinds of input devices will not actually provide full two-finger gestures since the input is being transformed to cursor movement on the screen. That is, single finger gestures will move a cursor; two-finger swipes will result in single-finger touch events; other two-finger gestures will result in the corresponding two-finger touch event. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_FAKETOUCH_MULTITOUCH_DISTINCT
				/// </java-name>
				[Dot42.DexImport("FEATURE_FAKETOUCH_MULTITOUCH_DISTINCT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_FAKETOUCH_MULTITOUCH_DISTINCT = "android.hardware.faketouch.multitouch.distinct";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device does not have a touch screen, but does support touch emulation for basic events that supports tracking a hand of fingers (5 or more fingers) fully independently. This is an extension of FEATURE_FAKETOUCH for input devices with this capability. Note that unlike a multitouch screen as defined by FEATURE_TOUCHSCREEN_MULTITOUCH_JAZZHAND, not all two finger gestures can be detected due to the limitations described for FEATURE_FAKETOUCH_MULTITOUCH_DISTINCT. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_FAKETOUCH_MULTITOUCH_JAZZHAND
				/// </java-name>
				[Dot42.DexImport("FEATURE_FAKETOUCH_MULTITOUCH_JAZZHAND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_FAKETOUCH_MULTITOUCH_JAZZHAND = "android.hardware.faketouch.multitouch.jazzhand";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device supports portrait orientation screens. For backwards compatibility, you can assume that if neither this nor FEATURE_SCREEN_LANDSCAPE is set then the device supports both portrait and landscape. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SCREEN_PORTRAIT
				/// </java-name>
				[Dot42.DexImport("FEATURE_SCREEN_PORTRAIT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SCREEN_PORTRAIT = "android.hardware.screen.portrait";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device supports landscape orientation screens. For backwards compatibility, you can assume that if neither this nor FEATURE_SCREEN_PORTRAIT is set then the device supports both portrait and landscape. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_SCREEN_LANDSCAPE
				/// </java-name>
				[Dot42.DexImport("FEATURE_SCREEN_LANDSCAPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_SCREEN_LANDSCAPE = "android.hardware.screen.landscape";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device supports live wallpapers. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_LIVE_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("FEATURE_LIVE_WALLPAPER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_LIVE_WALLPAPER = "android.software.live_wallpaper";
				/// <summary>
				///  <para>Feature for getSystemAvailableFeatures and hasSystemFeature: The device supports WiFi (802.11) networking. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_WIFI
				/// </java-name>
				[Dot42.DexImport("FEATURE_WIFI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string FEATURE_WIFI = "android.hardware.wifi";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PackageManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve overall information about an application package that is installed on the system. </para> <para>Throws NameNotFoundException if a package with the given name can not be found on the system.</para> <para> <para>GET_ACTIVITIES </para> <para>GET_GIDS </para> <para>GET_CONFIGURATIONS </para> <para>GET_INSTRUMENTATION </para> <para>GET_PERMISSIONS </para> <para>GET_PROVIDERS </para> <para>GET_RECEIVERS </para> <para>GET_SERVICES </para> <para>GET_SIGNATURES </para> <para>GET_UNINSTALLED_PACKAGES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a PackageInfo object containing information about the package. If flag GET_UNINSTALLED_PACKAGES is set and if the package is not found in the list of installed applications, the package information is retrieved from the list of uninstalled applications (which includes installed applications as well as applications with data directory i.e. applications which had been deleted with <c>DONT_DELETE_DATA </c> flag set). </para>
				/// </returns>
				/// <java-name>
				/// getPackageInfo
				/// </java-name>
				[Dot42.DexImport("getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.PackageInfo GetPackageInfo(string packageName, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Map from the current package names in use on the device to whatever the current canonical name of that package is. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an array of the same size as the original, containing the canonical name for each package. </para>
				/// </returns>
				/// <java-name>
				/// currentToCanonicalPackageNames
				/// </java-name>
				[Dot42.DexImport("currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] CurrentToCanonicalPackageNames(string[] names) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Map from a packages canonical name to the current name in use on the device. </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an array of the same size as the original, containing the current name for each package. </para>
				/// </returns>
				/// <java-name>
				/// canonicalToCurrentPackageNames
				/// </java-name>
				[Dot42.DexImport("canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] CanonicalToCurrentPackageNames(string[] names) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return a "good" intent to launch a front-door activity in a package, for use for example to implement an "open" button when browsing through packages. The current implementation will look first for a main activity in the category Intent#CATEGORY_INFO, next for a main activity in the category Intent#CATEGORY_LAUNCHER, or return null if neither are found.</para> <para>Throws NameNotFoundException if a package with the given name cannot be found on the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns either a fully-qualified Intent that can be used to launch the main activity in the package, or null if the package does not contain such an activity. </para>
				/// </returns>
				/// <java-name>
				/// getLaunchIntentForPackage
				/// </java-name>
				[Dot42.DexImport("getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1025)]
				public abstract global::Android.Content.Intent GetLaunchIntentForPackage(string packageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return an array of all of the secondary group-ids that have been assigned to a package.</para> <para>Throws NameNotFoundException if a package with the given name cannot be found on the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an int array of the assigned gids, or null if there are none. </para>
				/// </returns>
				/// <java-name>
				/// getPackageGids
				/// </java-name>
				[Dot42.DexImport("getPackageGids", "(Ljava/lang/String;)[I", AccessFlags = 1025)]
				public abstract int[] GetPackageGids(string packageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the information we know about a particular permission.</para> <para>Throws NameNotFoundException if a permission with the given name cannot be found on the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a PermissionInfo containing information about the permission. </para>
				/// </returns>
				/// <java-name>
				/// getPermissionInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.PermissionInfo GetPermissionInfo(string name, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Query for all of the permissions associated with a particular group.</para> <para>Throws NameNotFoundException if the given group does not exist.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a list of PermissionInfo containing information about all of the permissions in the given group. </para>
				/// </returns>
				/// <java-name>
				/// queryPermissionsByGroup
				/// </java-name>
				[Dot42.DexImport("queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/PermissionInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.PermissionInfo> QueryPermissionsByGroup(string group, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the information we know about a particular group of permissions.</para> <para>Throws NameNotFoundException if a permission group with the given name cannot be found on the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a PermissionGroupInfo containing information about the permission. </para>
				/// </returns>
				/// <java-name>
				/// getPermissionGroupInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.PermissionGroupInfo GetPermissionGroupInfo(string name, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the known permission groups in the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a list of PermissionGroupInfo containing information about all of the known permission groups. </para>
				/// </returns>
				/// <java-name>
				/// getAllPermissionGroups
				/// </java-name>
				[Dot42.DexImport("getAllPermissionGroups", "(I)Ljava/util/List;", AccessFlags = 1025, Signature = "(I)Ljava/util/List<Landroid/content/pm/PermissionGroupInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.PermissionGroupInfo> GetAllPermissionGroups(int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the information we know about a particular package/application.</para> <para>Throws NameNotFoundException if an application with the given package name cannot be found on the system.</para> <para> <para>GET_META_DATA </para> <para>GET_SHARED_LIBRARY_FILES </para> <para>GET_UNINSTALLED_PACKAGES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>ApplicationInfo Returns ApplicationInfo object containing information about the package. If flag GET_UNINSTALLED_PACKAGES is set and if the package is not found in the list of installed applications, the application information is retrieved from the list of uninstalled applications(which includes installed applications as well as applications with data directory ie applications which had been deleted with <c>DONT_DELETE_DATA </c> flag set).</para>
				/// </returns>
				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.ApplicationInfo GetApplicationInfo(string packageName, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the information we know about a particular activity class.</para> <para>Throws NameNotFoundException if an activity with the given class name cannot be found on the system.</para> <para> <para>GET_INTENT_FILTERS </para> <para>GET_META_DATA </para> <para>GET_SHARED_LIBRARY_FILES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>ActivityInfo containing information about the activity.</para>
				/// </returns>
				/// <java-name>
				/// getActivityInfo
				/// </java-name>
				[Dot42.DexImport("getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.ActivityInfo GetActivityInfo(global::Android.Content.ComponentName component, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the information we know about a particular receiver class.</para> <para>Throws NameNotFoundException if a receiver with the given class name cannot be found on the system.</para> <para> <para>GET_INTENT_FILTERS </para> <para>GET_META_DATA </para> <para>GET_SHARED_LIBRARY_FILES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>ActivityInfo containing information about the receiver.</para>
				/// </returns>
				/// <java-name>
				/// getReceiverInfo
				/// </java-name>
				[Dot42.DexImport("getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.ActivityInfo GetReceiverInfo(global::Android.Content.ComponentName component, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the information we know about a particular service class.</para> <para>Throws NameNotFoundException if a service with the given class name cannot be found on the system.</para> <para> <para>GET_META_DATA </para> <para>GET_SHARED_LIBRARY_FILES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>ServiceInfo containing information about the service.</para>
				/// </returns>
				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				[Dot42.DexImport("getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.ServiceInfo GetServiceInfo(global::Android.Content.ComponentName component, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the information we know about a particular content provider class.</para> <para>Throws NameNotFoundException if a provider with the given class name cannot be found on the system.</para> <para> <para>GET_META_DATA </para> <para>GET_SHARED_LIBRARY_FILES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>ProviderInfo containing information about the service.</para>
				/// </returns>
				/// <java-name>
				/// getProviderInfo
				/// </java-name>
				[Dot42.DexImport("getProviderInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.ProviderInfo GetProviderInfo(global::Android.Content.ComponentName component, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return a List of all packages that are installed on the device.</para> <para> <para>GET_ACTIVITIES </para> <para>GET_GIDS </para> <para>GET_CONFIGURATIONS </para> <para>GET_INSTRUMENTATION </para> <para>GET_PERMISSIONS </para> <para>GET_PROVIDERS </para> <para>GET_RECEIVERS </para> <para>GET_SERVICES </para> <para>GET_SIGNATURES </para> <para>GET_UNINSTALLED_PACKAGES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A List of PackageInfo objects, one for each package that is installed on the device. In the unlikely case of there being no installed packages, an empty list is returned. If flag GET_UNINSTALLED_PACKAGES is set, a list of all applications including those deleted with <c>DONT_DELETE_DATA </c> (partially installed apps with data directory) will be returned.</para>
				/// </returns>
				/// <java-name>
				/// getInstalledPackages
				/// </java-name>
				[Dot42.DexImport("getInstalledPackages", "(I)Ljava/util/List;", AccessFlags = 1025, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.PackageInfo> GetInstalledPackages(int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Check whether a particular package has been granted a particular permission.</para> <para> <para>PERMISSION_GRANTED </para> <para>PERMISSION_DENIED </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the package has the permission, PERMISSION_GRANTED is returned. If it does not have the permission, PERMISSION_DENIED is returned.</para>
				/// </returns>
				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int CheckPermission(string permName, string pkgName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a new dynamic permission to the system. For this to work, your package must have defined a permission tree through the &lt;permission-tree&gt; tag in its manifest. A package can only add permissions to trees that were defined by either its own package or another with the same user id; a permission is in a tree if it matches the name of the permission tree + ".": for example, "com.foo.bar" is a member of the permission tree "com.foo".</para> <para>It is good to make your permission tree name descriptive, because you are taking possession of that entire set of permission names. Thus, it must be under a domain you control, with a suffix that will not match any normal permissions that may be declared in any applications that are part of that domain.</para> <para>New permissions must be added before any .apks are installed that use those permissions. Permissions you add through this method are remembered across reboots of the device. If the given permission already exists, the info you supply here will be used to update it.</para> <para> <para>removePermission(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if a new permission was created, false if an existing one was updated.</para>
				/// </returns>
				/// <java-name>
				/// addPermission
				/// </java-name>
				[Dot42.DexImport("addPermission", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1025)]
				public abstract bool AddPermission(global::Android.Content.PM.PermissionInfo info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Like addPermission(PermissionInfo) but asynchronously persists the package manager state after returning from the call, allowing it to return quicker and batch a series of adds at the expense of no guarantee the added permission will be retained if the device is rebooted before it is written. </para>        
				/// </summary>
				/// <java-name>
				/// addPermissionAsync
				/// </java-name>
				[Dot42.DexImport("addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1025)]
				public abstract bool AddPermissionAsync(global::Android.Content.PM.PermissionInfo info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes a permission that was previously added with addPermission(PermissionInfo). The same ownership rules apply  you are only allowed to remove permissions that you are allowed to add.</para> <para> <para>addPermission(PermissionInfo) </para></para>        
				/// </summary>
				/// <java-name>
				/// removePermission
				/// </java-name>
				[Dot42.DexImport("removePermission", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void RemovePermission(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Like checkSignatures(String, String), but takes UIDs of the two packages to be checked. This can be useful, for example, when doing the check in an IPC, where the UID is the only identity available. It is functionally identical to determining the package associated with the UIDs and checking their signatures.</para> <para> <para>checkSignatures(String, String) </para> <para>SIGNATURE_MATCH </para> <para>SIGNATURE_NO_MATCH </para> <para>SIGNATURE_UNKNOWN_PACKAGE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an integer indicating whether all signatures on the two packages match. The value is &gt;= 0 (SIGNATURE_MATCH) if all signatures match or &lt; 0 if there is not a match (SIGNATURE_NO_MATCH or SIGNATURE_UNKNOWN_PACKAGE).</para>
				/// </returns>
				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int CheckSignatures(string uid1, string uid2) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Like checkSignatures(String, String), but takes UIDs of the two packages to be checked. This can be useful, for example, when doing the check in an IPC, where the UID is the only identity available. It is functionally identical to determining the package associated with the UIDs and checking their signatures.</para> <para> <para>checkSignatures(String, String) </para> <para>SIGNATURE_MATCH </para> <para>SIGNATURE_NO_MATCH </para> <para>SIGNATURE_UNKNOWN_PACKAGE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an integer indicating whether all signatures on the two packages match. The value is &gt;= 0 (SIGNATURE_MATCH) if all signatures match or &lt; 0 if there is not a match (SIGNATURE_NO_MATCH or SIGNATURE_UNKNOWN_PACKAGE).</para>
				/// </returns>
				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(II)I", AccessFlags = 1025)]
				public abstract int CheckSignatures(int uid1, int uid2) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the names of all packages that are associated with a particular user id. In most cases, this will be a single package name, the package that has been assigned that user id. Where there are multiple packages sharing the same user id through the "sharedUserId" mechanism, all packages with that id will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an array of one or more packages assigned to the user id, or null if there are no known packages with the given id. </para>
				/// </returns>
				/// <java-name>
				/// getPackagesForUid
				/// </java-name>
				[Dot42.DexImport("getPackagesForUid", "(I)[Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string[] GetPackagesForUid(int uid) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the official name associated with a user id. This name is guaranteed to never change, though it is possibly for the underlying user id to be changed. That is, if you are storing information about user ids in persistent storage, you should use the string returned by this function instead of the raw user-id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a unique name for the given user id, or null if the user id is not currently assigned. </para>
				/// </returns>
				/// <java-name>
				/// getNameForUid
				/// </java-name>
				[Dot42.DexImport("getNameForUid", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetNameForUid(int uid) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return a List of all application packages that are installed on the device. If flag GET_UNINSTALLED_PACKAGES has been set, a list of all applications including those deleted with <c>DONT_DELETE_DATA </c> (partially installed apps with data directory) will be returned.</para> <para> <para>GET_META_DATA </para> <para>GET_SHARED_LIBRARY_FILES </para> <para>GET_UNINSTALLED_PACKAGES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a List of ApplicationInfo objects, one for each application that is installed on the device. In the unlikely case of there being no installed applications, an empty list is returned. If flag GET_UNINSTALLED_PACKAGES is set, a list of all applications including those deleted with <c>DONT_DELETE_DATA </c> (partially installed apps with data directory) will be returned.</para>
				/// </returns>
				/// <java-name>
				/// getInstalledApplications
				/// </java-name>
				[Dot42.DexImport("getInstalledApplications", "(I)Ljava/util/List;", AccessFlags = 1025, Signature = "(I)Ljava/util/List<Landroid/content/pm/ApplicationInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.ApplicationInfo> GetInstalledApplications(int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Check whether the given feature name is one of the available features as returned by getSystemAvailableFeatures().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the devices supports the feature, else false. </para>
				/// </returns>
				/// <java-name>
				/// hasSystemFeature
				/// </java-name>
				[Dot42.DexImport("hasSystemFeature", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool HasSystemFeature(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine the best action to perform for a given Intent. This is how Intent#resolveActivity finds an activity if a class has not been explicitly specified.</para> <para> <b>Note:</b> if using an implicit Intent (without an explicit ComponentName specified), be sure to consider whether to set the MATCH_DEFAULT_ONLY only flag. You need to do so to resolve the activity in the same way that android.content.Context#startActivity(Intent) and Intent.resolveActivity(PackageManager) do.</para> <para> <para>MATCH_DEFAULT_ONLY </para> <para>GET_INTENT_FILTERS </para> <para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a ResolveInfo containing the final activity intent that was determined to be the best action. Returns null if no matching activity was found. If multiple matching activities are found and there is no default set, returns a ResolveInfo containing something else, such as the activity resolver.</para>
				/// </returns>
				/// <java-name>
				/// resolveActivity
				/// </java-name>
				[Dot42.DexImport("resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.ResolveInfo ResolveActivity(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all activities that can be performed for the given intent.</para> <para> <para>MATCH_DEFAULT_ONLY </para> <para>GET_INTENT_FILTERS </para> <para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A List&lt;ResolveInfo&gt; containing one entry for each matching Activity. These are ordered from best to worst match  that is, the first item in the list is what is returned by resolveActivity. If there are no matching activities, an empty list is returned.</para>
				/// </returns>
				/// <java-name>
				/// queryIntentActivities
				/// </java-name>
				[Dot42.DexImport("queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> QueryIntentActivities(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve a set of activities that should be presented to the user as similar options. This is like queryIntentActivities, except it also allows you to supply a list of more explicit Intents that you would like to resolve to particular options, and takes care of returning the final ResolveInfo list in a reasonable order, with no duplicates, based on those inputs.</para> <para> <para>MATCH_DEFAULT_ONLY </para> <para>GET_INTENT_FILTERS </para> <para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A List&lt;ResolveInfo&gt; containing one entry for each matching Activity. These are ordered first by all of the intents resolved in  <b>specifics</b> and then any additional activities that can handle  <b>intent</b> but did not get included by one of the  <b>specifics</b> intents. If there are no matching activities, an empty list is returned.</para>
				/// </returns>
				/// <java-name>
				/// queryIntentActivityOptions
				/// </java-name>
				[Dot42.DexImport("queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> QueryIntentActivityOptions(global::Android.Content.ComponentName caller, global::Android.Content.Intent[] specifics, global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all receivers that can handle a broadcast of the given intent.</para> <para> <para>MATCH_DEFAULT_ONLY </para> <para>GET_INTENT_FILTERS </para> <para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A List&lt;ResolveInfo&gt; containing one entry for each matching Receiver. These are ordered from first to last in priority. If there are no matching receivers, an empty list is returned.</para>
				/// </returns>
				/// <java-name>
				/// queryBroadcastReceivers
				/// </java-name>
				[Dot42.DexImport("queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> QueryBroadcastReceivers(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Determine the best service to handle for a given Intent.</para> <para> <para>GET_INTENT_FILTERS </para> <para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a ResolveInfo containing the final service intent that was determined to be the best action. Returns null if no matching service was found.</para>
				/// </returns>
				/// <java-name>
				/// resolveService
				/// </java-name>
				[Dot42.DexImport("resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.ResolveInfo ResolveService(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all services that can match the given intent.</para> <para> <para>GET_INTENT_FILTERS </para> <para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A List&lt;ResolveInfo&gt; containing one entry for each matching ServiceInfo. These are ordered from best to worst match  that is, the first item in the list is what is returned by resolveService(). If there are no matching services, an empty list is returned.</para>
				/// </returns>
				/// <java-name>
				/// queryIntentServices
				/// </java-name>
				[Dot42.DexImport("queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> QueryIntentServices(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Find a single content provider by its base path name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ContentProviderInfo Information about the provider, if found, else null. </para>
				/// </returns>
				/// <java-name>
				/// resolveContentProvider
				/// </java-name>
				[Dot42.DexImport("resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.ProviderInfo ResolveContentProvider(string name, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve content provider information.</para> <para> <b>Note: unlike most other methods, an empty result set is indicated by a null return instead of an empty list.</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A List&lt;ContentProviderInfo&gt; containing one entry for each content provider either patching  <b>processName</b> or, if  <b>processName</b> is null, all known content providers.  <b>If there are no matching providers, null is returned.</b> </para>
				/// </returns>
				/// <java-name>
				/// queryContentProviders
				/// </java-name>
				[Dot42.DexImport("queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/lang/String;II)Ljava/util/List<Landroid/content/pm/ProviderInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.ProviderInfo> QueryContentProviders(string processName, int uid, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all of the information we know about a particular instrumentation class.</para> <para>Throws NameNotFoundException if instrumentation with the given class name cannot be found on the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>InstrumentationInfo containing information about the instrumentation. </para>
				/// </returns>
				/// <java-name>
				/// getInstrumentationInfo
				/// </java-name>
				[Dot42.DexImport("getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;", AccessFlags = 1025)]
				public abstract global::Android.Content.PM.InstrumentationInfo GetInstrumentationInfo(global::Android.Content.ComponentName className, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve information about available instrumentation code. May be used to retrieve either all instrumentation code, or only the code targeting a particular package.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A List&lt;InstrumentationInfo&gt; containing one entry for each matching available Instrumentation. Returns an empty list if there is no instrumentation available for the given package. </para>
				/// </returns>
				/// <java-name>
				/// queryInstrumentation
				/// </java-name>
				[Dot42.DexImport("queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/InstrumentationInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.InstrumentationInfo> QueryInstrumentation(string targetPackage, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve an image from a package. This is a low-level API used by the various package manager info structures (such as ComponentInfo to implement retrieval of their associated icon.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a Drawable holding the requested image. Returns null if an image could not be found for any reason. </para>
				/// </returns>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawab" +
    "le/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetDrawable(string packageName, int resid, global::Android.Content.PM.ApplicationInfo appInfo) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the icon associated with an activity. Given the full name of an activity, retrieves the information about it and calls ComponentInfo.loadIcon() to return its icon. If the activity cannot be found, NameNotFoundException is thrown.</para> <para> <para>getActivityIcon(Intent) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the image of the icon, or the default activity icon if it could not be found. Does not return null. </para>
				/// </returns>
				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetActivityIcon(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the icon associated with an activity. Given the full name of an activity, retrieves the information about it and calls ComponentInfo.loadIcon() to return its icon. If the activity cannot be found, NameNotFoundException is thrown.</para> <para> <para>getActivityIcon(Intent) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the image of the icon, or the default activity icon if it could not be found. Does not return null. </para>
				/// </returns>
				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetActivityIcon(global::Android.Content.Intent activityName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the icon associated with an application. If it has not defined an icon, the default app icon is returned. Does not return null.</para> <para> <para>getApplicationIcon(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the image of the icon, or the default application icon if it could not be found.</para>
				/// </returns>
				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetApplicationIcon(global::Android.Content.PM.ApplicationInfo info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the icon associated with an application. If it has not defined an icon, the default app icon is returned. Does not return null.</para> <para> <para>getApplicationIcon(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the image of the icon, or the default application icon if it could not be found.</para>
				/// </returns>
				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetApplicationIcon(string info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the logo associated with an activity. Given the full name of an activity, retrieves the information about it and calls ComponentInfo.loadLogo() to return its logo. If the activity cannot be found, NameNotFoundException is thrown.</para> <para> <para>getActivityLogo(Intent) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the image of the logo or null if the activity has no logo specified.</para>
				/// </returns>
				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetActivityLogo(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the logo associated with an activity. Given the full name of an activity, retrieves the information about it and calls ComponentInfo.loadLogo() to return its logo. If the activity cannot be found, NameNotFoundException is thrown.</para> <para> <para>getActivityLogo(Intent) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the image of the logo or null if the activity has no logo specified.</para>
				/// </returns>
				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetActivityLogo(global::Android.Content.Intent activityName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the logo associated with an application. If it has not specified a logo, this method returns null.</para> <para> <para>getApplicationLogo(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the image of the logo, or null if no logo is specified by the application.</para>
				/// </returns>
				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetApplicationLogo(global::Android.Content.PM.ApplicationInfo info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the logo associated with an application. If it has not specified a logo, this method returns null.</para> <para> <para>getApplicationLogo(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the image of the logo, or null if no logo is specified by the application.</para>
				/// </returns>
				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
				public abstract global::Android.Graphics.Drawables.Drawable GetApplicationLogo(string info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve text from a package. This is a low-level API used by the various package manager info structures (such as ComponentInfo to implement retrieval of their associated labels and other text.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a CharSequence holding the requested text. Returns null if the text could not be found for any reason. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;" +
    "", AccessFlags = 1025)]
				public abstract global::Java.Lang.ICharSequence GetText(string packageName, int resid, global::Android.Content.PM.ApplicationInfo appInfo) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve an XML file from a package. This is a low-level API used to retrieve XML meta data.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an XmlPullParser allowing you to parse out the XML data. Returns null if the xml resource could not be found for any reason. </para>
				/// </returns>
				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/Xml" +
    "ResourceParser;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.IXmlResourceParser GetXml(string packageName, int resid, global::Android.Content.PM.ApplicationInfo appInfo) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the label to use for this application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the label associated with this application, or null if it could not be found for any reason. </para>
				/// </returns>
				/// <java-name>
				/// getApplicationLabel
				/// </java-name>
				[Dot42.DexImport("getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				public abstract global::Java.Lang.ICharSequence GetApplicationLabel(global::Android.Content.PM.ApplicationInfo info) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the resources associated with an activity. Given the full name of an activity, retrieves the information about it and calls getResources() to return its application's resources. If the activity cannot be found, NameNotFoundException is thrown.</para> <para> <para>getResourcesForApplication(ApplicationInfo) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the application's Resources. </para>
				/// </returns>
				/// <java-name>
				/// getResourcesForActivity
				/// </java-name>
				[Dot42.DexImport("getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.Resources GetResourcesForActivity(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the resources for an application. Throws NameNotFoundException if the package is no longer installed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the application's Resources. </para>
				/// </returns>
				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.Resources GetResourcesForApplication(global::Android.Content.PM.ApplicationInfo app) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the resources for an application. Throws NameNotFoundException if the package is no longer installed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the application's Resources. </para>
				/// </returns>
				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;", AccessFlags = 1025)]
				public abstract global::Android.Content.Res.Resources GetResourcesForApplication(string app) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve overall information about an application package defined in a package archive file</para> <para> <para>GET_ACTIVITIES </para> <para>GET_GIDS </para> <para>GET_CONFIGURATIONS </para> <para>GET_INSTRUMENTATION </para> <para>GET_PERMISSIONS </para> <para>GET_PROVIDERS </para> <para>GET_RECEIVERS </para> <para>GET_SERVICES </para> <para>GET_SIGNATURES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the information about the package. Returns null if the package could not be successfully parsed.</para>
				/// </returns>
				/// <java-name>
				/// getPackageArchiveInfo
				/// </java-name>
				[Dot42.DexImport("getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1)]
				public virtual global::Android.Content.PM.PackageInfo GetPackageArchiveInfo(string archiveFilePath, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.PackageInfo);
				}

				/// <summary>
				///  <para>Change the installer associated with a given package. There are limitations on how the installer package can be changed; in particular:  <ul> <li> <para>A SecurityException will be thrown if  <b>installerPackageName</b> is not signed with the same certificate as the calling application. </para></li> <li> <para>A SecurityException will be thrown if  <b>targetPackage</b> already has an installer package, and that installer package is not signed with the same certificate as the calling application. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("setInstallerPackageName", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void SetInstallerPackageName(string targetPackage, string installerPackageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the package name of the application that installed a package. This identifies which market the package came from.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetInstallerPackageName(string packageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This function no longer does anything; it was an old approach to managing preferred activities, which has been superseded by (and conflicts with) the modern activity-based preferences. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// addPackageToPreferred
				/// </java-name>
				[Dot42.DexImport("addPackageToPreferred", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void AddPackageToPreferred(string packageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This function no longer does anything; it was an old approach to managing preferred activities, which has been superseded by (and conflicts with) the modern activity-based preferences. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// removePackageFromPreferred
				/// </java-name>
				[Dot42.DexImport("removePackageFromPreferred", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void RemovePackageFromPreferred(string packageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the list of all currently configured preferred packages. The first package on the list is the most preferred, the last is the least preferred.</para> <para> <para>GET_ACTIVITIES </para> <para>GET_GIDS </para> <para>GET_CONFIGURATIONS </para> <para>GET_INSTRUMENTATION </para> <para>GET_PERMISSIONS </para> <para>GET_PROVIDERS </para> <para>GET_RECEIVERS </para> <para>GET_SERVICES </para> <para>GET_SIGNATURES </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a list of PackageInfo objects describing each preferred application, in order of preference.</para>
				/// </returns>
				/// <java-name>
				/// getPreferredPackages
				/// </java-name>
				[Dot42.DexImport("getPreferredPackages", "(I)Ljava/util/List;", AccessFlags = 1025, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public abstract global::Java.Util.IList<global::Android.Content.PM.PackageInfo> GetPreferredPackages(int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This is a protected API that should not have been available to third party applications. It is the platform's responsibility for assigning preferred activities and this cannot be directly modified.</para></xrefdescription></xrefsect></para> <para>Add a new preferred activity mapping to the system. This will be used to automatically select the given activity component when Context.startActivity() finds multiple matching activities and also matches the given filter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addPreferredActivity
				/// </java-name>
				[Dot42.DexImport("addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/" +
    "ComponentName;)V", AccessFlags = 1025)]
				public abstract void AddPreferredActivity(global::Android.Content.IntentFilter filter, int match, global::Android.Content.ComponentName[] set, global::Android.Content.ComponentName activity) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove all preferred activity mappings, previously added with addPreferredActivity, from the system whose activities are implemented in the given package name. An application can only clear its own package(s).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearPackagePreferredActivities
				/// </java-name>
				[Dot42.DexImport("clearPackagePreferredActivities", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void ClearPackagePreferredActivities(string packageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve all preferred activities, previously added with addPreferredActivity, that are currently registered with the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the total number of registered preferred activities (the number of distinct IntentFilter records, not the number of unique activity components) that were found. </para>
				/// </returns>
				/// <java-name>
				/// getPreferredActivities
				/// </java-name>
				[Dot42.DexImport("getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I", AccessFlags = 1025, Signature = "(Ljava/util/List<Landroid/content/IntentFilter;>;Ljava/util/List<Landroid/content" +
    "/ComponentName;>;Ljava/lang/String;)I")]
				public abstract int GetPreferredActivities(global::Java.Util.IList<global::Android.Content.IntentFilter> outFilters, global::Java.Util.IList<global::Android.Content.ComponentName> outActivities, string packageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the enabled setting for a package component (activity, receiver, service, provider). This setting will override any enabled state which may have been set by the component in its manifest.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V", AccessFlags = 1025)]
				public abstract void SetComponentEnabledSetting(global::Android.Content.ComponentName componentName, int newState, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the the enabled setting for a package component (activity, receiver, service, provider). This returns the last value set by setComponentEnabledSetting(ComponentName, int, int); in most cases this value will be COMPONENT_ENABLED_STATE_DEFAULT since the value originally specified in the manifest has not been modified.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the current enabled state for the component. May be one of COMPONENT_ENABLED_STATE_ENABLED, COMPONENT_ENABLED_STATE_DISABLED, or COMPONENT_ENABLED_STATE_DEFAULT. The last one means the component's enabled state is based on the original information in the manifest as found in ComponentInfo. </para>
				/// </returns>
				/// <java-name>
				/// getComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getComponentEnabledSetting", "(Landroid/content/ComponentName;)I", AccessFlags = 1025)]
				public abstract int GetComponentEnabledSetting(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the enabled setting for an application This setting will override any enabled state which may have been set by the application in its manifest. It also overrides the enabled state set in the manifest for any of the application's components. It does not override any enabled state set by setComponentEnabledSetting for any of the application's components.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setApplicationEnabledSetting", "(Ljava/lang/String;II)V", AccessFlags = 1025)]
				public abstract void SetApplicationEnabledSetting(string packageName, int newState, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the the enabled setting for an application. This returns the last value set by setApplicationEnabledSetting(String, int, int); in most cases this value will be COMPONENT_ENABLED_STATE_DEFAULT since the value originally specified in the manifest has not been modified.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the current enabled state for the component. May be one of COMPONENT_ENABLED_STATE_ENABLED, COMPONENT_ENABLED_STATE_DISABLED, or COMPONENT_ENABLED_STATE_DEFAULT. The last one means the application's enabled state is based on the original information in the manifest as found in ComponentInfo. </para>
				/// </returns>
				/// <java-name>
				/// getApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getApplicationEnabledSetting", "(Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int GetApplicationEnabledSetting(string packageName) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get a list of shared libraries that are available on the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array of shared library names that are available on the system, or null if none are installed. </para>
				/// </returns>
				/// <java-name>
				/// getSystemSharedLibraryNames
				/// </java-name>
				public abstract string[] SystemSharedLibraryNames
				{
						[Dot42.DexImport("getSystemSharedLibraryNames", "()[Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get a list of features that are available on the system.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array of FeatureInfo classes describing the features that are available on the system, or null if there are none(!!). </para>
				/// </returns>
				/// <java-name>
				/// getSystemAvailableFeatures
				/// </java-name>
				public abstract global::Android.Content.PM.FeatureInfo[] SystemAvailableFeatures
				{
						[Dot42.DexImport("getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the generic icon for an activity that is used when no specific icon is defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Drawable Image of the icon. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultActivityIcon
				/// </java-name>
				public abstract global::Android.Graphics.Drawables.Drawable DefaultActivityIcon
				{
						[Dot42.DexImport("getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return whether the device has been booted into safe mode. </para>        
				/// </summary>
				/// <java-name>
				/// isSafeMode
				/// </java-name>
				public abstract bool IsSafeMode
				{
						[Dot42.DexImport("isSafeMode", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>This exception is thrown when a given package, application, or component name cannot be found. </para>    
				/// </summary>
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

		/// <summary>
		///  <para>implementation of PackageStats associated with a application package. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/PackageStats
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PackageStats", AccessFlags = 33)]
		public partial class PackageStats : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Name of the package to which this stats applies. </para>        
				/// </summary>
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <summary>
				///  <para>Size of the code (e.g., APK) </para>        
				/// </summary>
				/// <java-name>
				/// codeSize
				/// </java-name>
				[Dot42.DexImport("codeSize", "J", AccessFlags = 1)]
				public long CodeSize;
				/// <summary>
				///  <para>Size of the internal data size for the application. (e.g., /data/data/&lt;app&gt;) </para>        
				/// </summary>
				/// <java-name>
				/// dataSize
				/// </java-name>
				[Dot42.DexImport("dataSize", "J", AccessFlags = 1)]
				public long DataSize;
				/// <summary>
				///  <para>Size of cache used by the application. (e.g., /data/data/&lt;app&gt;/cache) </para>        
				/// </summary>
				/// <java-name>
				/// cacheSize
				/// </java-name>
				[Dot42.DexImport("cacheSize", "J", AccessFlags = 1)]
				public long CacheSize;
				/// <summary>
				///  <para>Size of the external data used by the application (e.g., &lt;sdcard&gt;/Android/data/&lt;app&gt;) </para>        
				/// </summary>
				/// <java-name>
				/// externalDataSize
				/// </java-name>
				[Dot42.DexImport("externalDataSize", "J", AccessFlags = 1)]
				public long ExternalDataSize;
				/// <summary>
				///  <para>Size of the external cache used by the application (i.e., on the SD card). If this is a subdirectory of the data directory, this size will be subtracted out of the external data size. </para>        
				/// </summary>
				/// <java-name>
				/// externalCacheSize
				/// </java-name>
				[Dot42.DexImport("externalCacheSize", "J", AccessFlags = 1)]
				public long ExternalCacheSize;
				/// <summary>
				///  <para>Size of the external media size used by the application. </para>        
				/// </summary>
				/// <java-name>
				/// externalMediaSize
				/// </java-name>
				[Dot42.DexImport("externalMediaSize", "J", AccessFlags = 1)]
				public long ExternalMediaSize;
				/// <summary>
				///  <para>Size of the package's OBBs placed on external media. </para>        
				/// </summary>
				/// <java-name>
				/// externalObbSize
				/// </java-name>
				[Dot42.DexImport("externalObbSize", "J", AccessFlags = 1)]
				public long ExternalObbSize;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.PackageStats> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public PackageStats(string source) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public PackageStats(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageStats;)V", AccessFlags = 1)]
				public PackageStats(global::Android.Content.PM.PackageStats source) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PackageStats() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Description of permissions needed to access a particular path in a ProviderInfo. </para>    
		/// </summary>
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
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.PathPermission> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PathPermission(string pattern, int type, string readPermission, string writePermission) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public PathPermission(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PathPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getReadPermission
				/// </java-name>
				public virtual string ReadPermission
				{
						[Dot42.DexImport("getReadPermission", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getWritePermission
				/// </java-name>
				public virtual string WritePermission
				{
						[Dot42.DexImport("getWritePermission", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Information you can retrieve about a particular security permission group known to the system. This corresponds to information collected from the AndroidManifest.xml's &lt;permission-group&gt; tags. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/PermissionGroupInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PermissionGroupInfo", AccessFlags = 33)]
		public partial class PermissionGroupInfo : global::Android.Content.PM.PackageItemInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A string resource identifier (in the package's resources) of this permission's description. From the "description" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// descriptionRes
				/// </java-name>
				[Dot42.DexImport("descriptionRes", "I", AccessFlags = 1)]
				public int DescriptionRes;
				/// <summary>
				///  <para>The description string provided in the AndroidManifest file, if any. You probably don't want to use this, since it will be null if the description is in a resource. You probably want PermissionInfo#loadDescription instead. </para>        
				/// </summary>
				/// <java-name>
				/// nonLocalizedDescription
				/// </java-name>
				[Dot42.DexImport("nonLocalizedDescription", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence NonLocalizedDescription;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.PermissionGroupInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PermissionGroupInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/PermissionGroupInfo;)V", AccessFlags = 1)]
				public PermissionGroupInfo(global::Android.Content.PM.PermissionGroupInfo orig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the textual description of this permission. This will call back on the given PackageManager to load the description from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a CharSequence containing the permission's description. If there is no description, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Information you can retrieve about a particular security permission known to the system. This corresponds to information collected from the AndroidManifest.xml's &lt;permission&gt; tags. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/PermissionInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/PermissionInfo", AccessFlags = 33)]
		public partial class PermissionInfo : global::Android.Content.PM.PackageItemInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A normal application value for protectionLevel, corresponding to the  <code>normal</code> value of android.R.attr#protectionLevel. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTION_NORMAL
				/// </java-name>
				[Dot42.DexImport("PROTECTION_NORMAL", "I", AccessFlags = 25)]
				public const int PROTECTION_NORMAL = 0;
				/// <summary>
				///  <para>Dangerous value for protectionLevel, corresponding to the  <code>dangerous</code> value of android.R.attr#protectionLevel. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTION_DANGEROUS
				/// </java-name>
				[Dot42.DexImport("PROTECTION_DANGEROUS", "I", AccessFlags = 25)]
				public const int PROTECTION_DANGEROUS = 1;
				/// <summary>
				///  <para>System-level value for protectionLevel, corresponding to the  <code>signature</code> value of android.R.attr#protectionLevel. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTION_SIGNATURE
				/// </java-name>
				[Dot42.DexImport("PROTECTION_SIGNATURE", "I", AccessFlags = 25)]
				public const int PROTECTION_SIGNATURE = 2;
				/// <summary>
				///  <para>System-level value for protectionLevel, corresponding to the  <code>signatureOrSystem</code> value of android.R.attr#protectionLevel. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTION_SIGNATURE_OR_SYSTEM
				/// </java-name>
				[Dot42.DexImport("PROTECTION_SIGNATURE_OR_SYSTEM", "I", AccessFlags = 25)]
				public const int PROTECTION_SIGNATURE_OR_SYSTEM = 3;
				/// <summary>
				///  <para>The group this permission is a part of, as per android.R.attr#permissionGroup. </para>        
				/// </summary>
				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "Ljava/lang/String;", AccessFlags = 1)]
				public string Group;
				/// <summary>
				///  <para>A string resource identifier (in the package's resources) of this permission's description. From the "description" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// descriptionRes
				/// </java-name>
				[Dot42.DexImport("descriptionRes", "I", AccessFlags = 1)]
				public int DescriptionRes;
				/// <summary>
				///  <para>The description string provided in the AndroidManifest file, if any. You probably don't want to use this, since it will be null if the description is in a resource. You probably want PermissionInfo#loadDescription instead. </para>        
				/// </summary>
				/// <java-name>
				/// nonLocalizedDescription
				/// </java-name>
				[Dot42.DexImport("nonLocalizedDescription", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence NonLocalizedDescription;
				/// <summary>
				///  <para>The level of access this permission is protecting, as per android.R.attr#protectionLevel. Values may be PROTECTION_NORMAL, PROTECTION_DANGEROUS, or PROTECTION_SIGNATURE. May also include the additional flags PROTECTION_FLAG_SYSTEM or PROTECTION_FLAG_DEVELOPMENT (which only make sense in combination with the base PROTECTION_SIGNATURE. </para>        
				/// </summary>
				/// <java-name>
				/// protectionLevel
				/// </java-name>
				[Dot42.DexImport("protectionLevel", "I", AccessFlags = 1)]
				public int ProtectionLevel;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.PermissionInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PermissionInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/PermissionInfo;)V", AccessFlags = 1)]
				public PermissionInfo(global::Android.Content.PM.PermissionInfo orig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the textual description of this permission. This will call back on the given PackageManager to load the description from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a CharSequence containing the permission's description. If there is no description, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadDescription(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Holds information about a specific content provider. This is returned by PackageManager.resolveContentProvider(). </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/ProviderInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ProviderInfo", AccessFlags = 49)]
		public sealed partial class ProviderInfo : global::Android.Content.PM.ComponentInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The name provider is published under content:// </para>        
				/// </summary>
				/// <java-name>
				/// authority
				/// </java-name>
				[Dot42.DexImport("authority", "Ljava/lang/String;", AccessFlags = 1)]
				public string Authority;
				/// <summary>
				///  <para>Optional permission required for read-only access this content provider. </para>        
				/// </summary>
				/// <java-name>
				/// readPermission
				/// </java-name>
				[Dot42.DexImport("readPermission", "Ljava/lang/String;", AccessFlags = 1)]
				public string ReadPermission;
				/// <summary>
				///  <para>Optional permission required for read/write access this content provider. </para>        
				/// </summary>
				/// <java-name>
				/// writePermission
				/// </java-name>
				[Dot42.DexImport("writePermission", "Ljava/lang/String;", AccessFlags = 1)]
				public string WritePermission;
				/// <summary>
				///  <para>If true, additional permissions to specific Uris in this content provider can be granted, as per the grantUriPermissions attribute. </para>        
				/// </summary>
				/// <java-name>
				/// grantUriPermissions
				/// </java-name>
				[Dot42.DexImport("grantUriPermissions", "Z", AccessFlags = 1)]
				public bool GrantUriPermissions;
				/// <summary>
				///  <para>If non-null, these are the patterns that are allowed for granting URI permissions. Any URI that does not match one of these patterns will not allowed to be granted. If null, all URIs are allowed. The PackageManager.GET_URI_PERMISSION_PATTERNS flag must be specified for this field to be filled in. </para>        
				/// </summary>
				/// <java-name>
				/// uriPermissionPatterns
				/// </java-name>
				[Dot42.DexImport("uriPermissionPatterns", "[Landroid/os/PatternMatcher;", AccessFlags = 1)]
				public global::Android.OS.PatternMatcher[] UriPermissionPatterns;
				/// <summary>
				///  <para>If non-null, these are path-specific permissions that are allowed for accessing the provider. Any permissions listed here will allow a holding client to access the provider, and the provider will check the URI it provides when making calls against the patterns here. </para>        
				/// </summary>
				/// <java-name>
				/// pathPermissions
				/// </java-name>
				[Dot42.DexImport("pathPermissions", "[Landroid/content/pm/PathPermission;", AccessFlags = 1)]
				public global::Android.Content.PM.PathPermission[] PathPermissions;
				/// <summary>
				///  <para>If true, this content provider allows multiple instances of itself to run in different process. If false, a single instances is always run in processName. </para>        
				/// </summary>
				/// <java-name>
				/// multiprocess
				/// </java-name>
				[Dot42.DexImport("multiprocess", "Z", AccessFlags = 1)]
				public bool Multiprocess;
				/// <summary>
				///  <para>Used to control initialization order of single-process providers running in the same process. Higher goes first. </para>        
				/// </summary>
				/// <java-name>
				/// initOrder
				/// </java-name>
				[Dot42.DexImport("initOrder", "I", AccessFlags = 1)]
				public int InitOrder;
				/// <summary>
				///  <para>Whether or not this provider is syncable.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This flag is now being ignored. The current way to make a provider syncable is to provide a SyncAdapter service for a given provider/account type. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isSyncable
				/// </java-name>
				[Dot42.DexImport("isSyncable", "Z", AccessFlags = 1)]
				public bool IsSyncable;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.ProviderInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProviderInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ProviderInfo;)V", AccessFlags = 1)]
				public ProviderInfo(global::Android.Content.PM.ProviderInfo orig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Information that is returned from resolving an intent against an IntentFilter. This partially corresponds to information collected from the AndroidManifest.xml's &lt;intent&gt; tags. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/ResolveInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ResolveInfo", AccessFlags = 33)]
		public partial class ResolveInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The activity or broadcast receiver that corresponds to this resolution match, if this resolution is for an activity or broadcast receiver. Exactly one of activityInfo, serviceInfo, or providerInfo will be non-null. </para>        
				/// </summary>
				/// <java-name>
				/// activityInfo
				/// </java-name>
				[Dot42.DexImport("activityInfo", "Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ActivityInfo ActivityInfo;
				/// <summary>
				///  <para>The service that corresponds to this resolution match, if this resolution is for a service. Exactly one of activityInfo, serviceInfo, or providerInfo will be non-null. </para>        
				/// </summary>
				/// <java-name>
				/// serviceInfo
				/// </java-name>
				[Dot42.DexImport("serviceInfo", "Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public global::Android.Content.PM.ServiceInfo ServiceInfo;
				/// <summary>
				///  <para>The IntentFilter that was matched for this ResolveInfo. </para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "Landroid/content/IntentFilter;", AccessFlags = 1)]
				public global::Android.Content.IntentFilter Filter;
				/// <summary>
				///  <para>The declared priority of this match. Comes from the "priority" attribute or, if not set, defaults to 0. Higher values are a higher priority. </para>        
				/// </summary>
				/// <java-name>
				/// priority
				/// </java-name>
				[Dot42.DexImport("priority", "I", AccessFlags = 1)]
				public int Priority;
				/// <summary>
				///  <para>Order of result according to the user's preference. If the user has not set a preference for this result, the value is 0; higher values are a higher priority. </para>        
				/// </summary>
				/// <java-name>
				/// preferredOrder
				/// </java-name>
				[Dot42.DexImport("preferredOrder", "I", AccessFlags = 1)]
				public int PreferredOrder;
				/// <summary>
				///  <para>The system's evaluation of how well the activity matches the IntentFilter. This is a match constant, a combination of IntentFilter.MATCH_CATEGORY_MASK and IntentFiler.MATCH_ADJUSTMENT_MASK. </para>        
				/// </summary>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "I", AccessFlags = 1)]
				public int Match;
				/// <summary>
				///  <para>Only set when returned by PackageManager#queryIntentActivityOptions, this tells you which of the given specific intents this result came from. 0 is the first in the list, &lt; 0 means it came from the generic Intent query. </para>        
				/// </summary>
				/// <java-name>
				/// specificIndex
				/// </java-name>
				[Dot42.DexImport("specificIndex", "I", AccessFlags = 1)]
				public int SpecificIndex;
				/// <summary>
				///  <para>This filter has specified the Intent.CATEGORY_DEFAULT, meaning it would like to be considered a default action that the user can perform on this data. </para>        
				/// </summary>
				/// <java-name>
				/// isDefault
				/// </java-name>
				[Dot42.DexImport("isDefault", "Z", AccessFlags = 1)]
				public bool IsDefault;
				/// <summary>
				///  <para>A string resource identifier (in the package's resources) of this match's label. From the "label" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// labelRes
				/// </java-name>
				[Dot42.DexImport("labelRes", "I", AccessFlags = 1)]
				public int LabelRes;
				/// <summary>
				///  <para>The actual string retrieve from  <b>labelRes</b> or null if none was provided. </para>        
				/// </summary>
				/// <java-name>
				/// nonLocalizedLabel
				/// </java-name>
				[Dot42.DexImport("nonLocalizedLabel", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence NonLocalizedLabel;
				/// <summary>
				///  <para>A drawable resource identifier (in the package's resources) of this match's icon. From the "icon" attribute or, if not set, 0. </para>        
				/// </summary>
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <summary>
				///  <para>Optional  if non-null, the labelRes and icon resources will be loaded from this package, rather than the one containing the resolved component. </para>        
				/// </summary>
				/// <java-name>
				/// resolvePackageName
				/// </java-name>
				[Dot42.DexImport("resolvePackageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string ResolvePackageName;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.ResolveInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResolveInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the current textual label associated with this resolution. This will call back on the given PackageManager to load the label from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a CharSequence containing the resolutions's label. If the item does not have a label, its name is returned. </para>
				/// </returns>
				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Retrieve the current graphical icon associated with this resolution. This will call back on the given PackageManager to load the icon from the application.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a Drawable containing the resolution's icon. If the item does not have an icon, the default activity icon is returned. </para>
				/// </returns>
				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawables.Drawable LoadIcon(global::Android.Content.PM.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the icon resource identifier to use for this match. If the match defines an icon, that is used; else if the activity defines an icon, that is used; else, the application icon is used.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The icon associated with this match. </para>
				/// </returns>
				/// <java-name>
				/// getIconResource
				/// </java-name>
				public int IconResource
				{
						[Dot42.DexImport("getIconResource", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/content/pm/ResolveInfo$DisplayNameComparator
				/// </java-name>
				[Dot42.DexImport("android/content/pm/ResolveInfo$DisplayNameComparator", AccessFlags = 9, Signature = "Ljava/lang/Object;Ljava/util/Comparator<Landroid/content/pm/ResolveInfo;>;")]
				public partial class DisplayNameComparator : global::Java.Util.IComparator<global::Android.Content.PM.ResolveInfo>
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/pm/PackageManager;)V", AccessFlags = 1)]
						public DisplayNameComparator(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// compare
						/// </java-name>
						[Dot42.DexImport("compare", "(Landroid/content/pm/ResolveInfo;Landroid/content/pm/ResolveInfo;)I", AccessFlags = 17)]
						public int Compare(global::Android.Content.PM.ResolveInfo a, global::Android.Content.PM.ResolveInfo b) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Information you can retrieve about a particular application service. This corresponds to information collected from the AndroidManifest.xml's &lt;service&gt; tags. </para>    
		/// </summary>
		/// <java-name>
		/// android/content/pm/ServiceInfo
		/// </java-name>
		[Dot42.DexImport("android/content/pm/ServiceInfo", AccessFlags = 33)]
		public partial class ServiceInfo : global::Android.Content.PM.ComponentInfo, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Optional name of a permission required to be able to access this Service. From the "permission" attribute. </para>        
				/// </summary>
				/// <java-name>
				/// permission
				/// </java-name>
				[Dot42.DexImport("permission", "Ljava/lang/String;", AccessFlags = 1)]
				public string Permission;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.ServiceInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ServiceInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/pm/ServiceInfo;)V", AccessFlags = 1)]
				public ServiceInfo(global::Android.Content.PM.ServiceInfo orig) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Opaque, immutable representation of a signature associated with an application package. </para>    
		/// </summary>
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
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Content.PM.Signature> CREATOR;
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public Signature(sbyte[] source) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Signature(byte[] source) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Signature(string source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Encode the Signature as ASCII text. </para>        
				/// </summary>
				/// <java-name>
				/// toChars
				/// </java-name>
				[Dot42.DexImport("toChars", "()[C", AccessFlags = 1)]
				public virtual char[] ToChars() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				///  <para>Encode the Signature as ASCII text in to an existing array.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns either  <b>existingArray</b> if it was large enough to hold the ASCII representation, or a newly created char[] array if needed. </para>
				/// </returns>
				/// <java-name>
				/// toChars
				/// </java-name>
				[Dot42.DexImport("toChars", "([C[I)[C", AccessFlags = 1)]
				public virtual char[] ToChars(char[] existingArray, int[] outLen) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				///  <para>Return the result of toChars() as a String. </para>        
				/// </summary>
				/// <java-name>
				/// toCharsString
				/// </java-name>
				[Dot42.DexImport("toCharsString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToCharsString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the contents of this signature as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the contents of this signature as a byte array. </para>
				/// </returns>
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
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
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
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Signature() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

