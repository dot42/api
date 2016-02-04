#pragma warning disable 1717
namespace Android.Test.Mock
{
		/// <summary>
		///  <para>A mock android.app.Application class. All methods are non-functional and throw java.lang.UnsupportedOperationException. Override it as necessary to provide the operations that you need. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockApplication
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockApplication", AccessFlags = 33)]
		public partial class MockApplication : global::Android.App.Application
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockApplication() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTerminate
				/// </java-name>
				[Dot42.DexImport("onTerminate", "()V", AccessFlags = 1)]
				public override void OnTerminate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the device configuration changes while your component is running. Note that, unlike activities, other components are never restarted when a configuration changes: they must always deal with the results of the change, such as by re-retrieving resources.</para> <para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para> <para>For more information, read .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public override void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An extension of android.content.ContentResolver that is designed for testing. </para> <para>MockContentResolver overrides Android's normal way of resolving providers by authority. To have access to a provider based on its authority, users of MockContentResolver first instantiate the provider and use MockContentResolver#addProvider(String, ContentProvider). Resolution of an authority occurs entirely within MockContentResolver. </para> <para>Users can also set an authority's entry in the map to null, so that a provider is completely mocked out. </para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about application testing, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockContentResolver
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockContentResolver", AccessFlags = 33)]
		public partial class MockContentResolver : global::Android.Content.ContentResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a local map of providers. This map is used instead of the global map when an API call tries to acquire a provider. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockContentResolver() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds access to a provider based on its authority</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addProvider
				/// </java-name>
				[Dot42.DexImport("addProvider", "(Ljava/lang/String;Landroid/content/ContentProvider;)V", AccessFlags = 1)]
				public virtual void AddProvider(string name, global::Android.Content.ContentProvider provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Overrides ContentResolver.notifChange(Uri, ContentObserver, boolean). All parameters are ignored. The method hides providers linked to MockContentResolver from other observers in the system.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notifyChange
				/// </java-name>
				[Dot42.DexImport("notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V", AccessFlags = 1)]
				public override void NotifyChange(global::Android.Net.Uri uri, global::Android.Database.ContentObserver observer, bool syncToNetwork) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A mock android.content.Context class. All methods are non-functional and throw java.lang.UnsupportedOperationException. You can use this to inject other dependencies, mocks, or monitors into the classes you are testing. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockContext
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockContext", AccessFlags = 33)]
		public partial class MockContext : global::Android.Content.Context
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockContext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1)]
				public override void SetTheme(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public override global::Android.Content.ISharedPreferences GetSharedPreferences(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <java-name>
				/// openFileInput
				/// </java-name>
				[Dot42.DexImport("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", AccessFlags = 1)]
				public override global::Java.IO.FileInputStream OpenFileInput(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.FileInputStream);
				}

				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public override global::Java.IO.FileOutputStream OpenFileOutput(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.FileOutputStream);
				}

				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteFile(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetFileStreamPath(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <java-name>
				/// fileList
				/// </java-name>
				[Dot42.DexImport("fileList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] FileList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getDir
				/// </java-name>
				[Dot42.DexImport("getDir", "(Ljava/lang/String;I)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetDir(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string file, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetDatabasePath(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
				}

				/// <java-name>
				/// databaseList
				/// </java-name>
				[Dot42.DexImport("databaseList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] DatabaseList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// deleteDatabase
				/// </java-name>
				[Dot42.DexImport("deleteDatabase", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteDatabase(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// peekWallpaper
				/// </java-name>
				[Dot42.DexImport("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable PeekWallpaper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public override void SetWallpaper(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public override void SetWallpaper(global::Java.IO.InputStream bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearWallpaper
				/// </java-name>
				[Dot42.DexImport("clearWallpaper", "()V", AccessFlags = 1)]
				public override void ClearWallpaper() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void StartActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", AccessFlags = 1)]
				public override void StartIntentSender(global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SendBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Lan" +
    "droid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SendStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendStickyOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;I" +
    "Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void SendStickyOrderedBroadcast(global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("removeStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void RemoveStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/conte" +
    "nt/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/Stri" +
    "ng;Landroid/os/Handler;)Landroid/content/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter, string broadcastPermission, global::Android.OS.Handler scheduler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1)]
				public override void UnregisterReceiver(global::Android.Content.BroadcastReceiver receiver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public override global::Android.Content.ComponentName StartService(global::Android.Content.Intent service) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <java-name>
				/// stopService
				/// </java-name>
				[Dot42.DexImport("stopService", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public override bool StopService(global::Android.Content.Intent service) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1)]
				public override bool BindService(global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unbindService
				/// </java-name>
				[Dot42.DexImport("unbindService", "(Landroid/content/ServiceConnection;)V", AccessFlags = 1)]
				public override void UnbindService(global::Android.Content.IServiceConnection conn) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startInstrumentation
				/// </java-name>
				[Dot42.DexImport("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public override bool StartInstrumentation(global::Android.Content.ComponentName className, string profileFile, global::Android.OS.Bundle arguments) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;II)I", AccessFlags = 1)]
				public override int CheckPermission(string permission, int pid, int uid) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingPermission(string permission) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfPermission(string permission) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enforcePermission
				/// </java-name>
				[Dot42.DexImport("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforcePermission(string permission, int pid, int uid, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingPermission(string permission, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfPermission(string permission, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// grantUriPermission
				/// </java-name>
				[Dot42.DexImport("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void GrantUriPermission(string toPackage, global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// revokeUriPermission
				/// </java-name>
				[Dot42.DexImport("revokeUriPermission", "(Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void RevokeUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingUriPermission(global::Android.Net.Uri uri, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfUriPermission(global::Android.Net.Uri uri, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createPackageContext
				/// </java-name>
				[Dot42.DexImport("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", AccessFlags = 1)]
				public override global::Android.Content.Context CreatePackageContext(string packageName, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				public override global::Android.Content.Res.AssetManager Assets
				{
						[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.AssetManager); }
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				public override global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

				/// <java-name>
				/// getPackageManager
				/// </java-name>
				public override global::Android.Content.PM.PackageManager PackageManager
				{
						[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.PackageManager); }
				}

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				public override global::Android.Content.ContentResolver ContentResolver
				{
						[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ContentResolver); }
				}

				/// <java-name>
				/// getMainLooper
				/// </java-name>
				public override global::Android.OS.Looper MainLooper
				{
						[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Looper); }
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public override global::Android.Content.Context ApplicationContext
				{
						[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				public override global::Android.Content.Res.Resources.Theme Theme
				{
						[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources.Theme); }
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public override global::Java.Lang.ClassLoader ClassLoader
				{
						[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ClassLoader); }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public override string PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				public override global::Android.Content.PM.ApplicationInfo ApplicationInfo
				{
						[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ApplicationInfo); }
				}

				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				public virtual string PackageResourcePath
				{
						[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				public virtual string PackageCodePath
				{
						[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getFilesDir
				/// </java-name>
				public override global::Java.IO.File FilesDir
				{
						[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public override global::Java.IO.File CacheDir
				{
						[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return default(global::Java.IO.File); }
				}

				/// <java-name>
				/// getWallpaper
				/// </java-name>
				public override global::Android.Graphics.Drawables.Drawable Wallpaper
				{
						[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				public override int WallpaperDesiredMinimumWidth
				{
						[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				public override int WallpaperDesiredMinimumHeight
				{
						[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isRestricted
				/// </java-name>
				public override bool IsRestricted
				{
						[Dot42.DexImport("isRestricted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A mock android.content.DialogInterface class. All methods are non-functional and throw java.lang.UnsupportedOperationException. Override it to provide the operations that you need. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockDialogInterface
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockDialogInterface", AccessFlags = 33)]
		public partial class MockDialogInterface : global::Android.Content.IDialogInterface
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockDialogInterface() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A mock android.content.pm.PackageManager class. All methods are non-functional and throw java.lang.UnsupportedOperationException. Override it to provide the operations that you need. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockPackageManager
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockPackageManager", AccessFlags = 33)]
		public partial class MockPackageManager : global::Android.Content.PM.PackageManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockPackageManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPackageInfo
				/// </java-name>
				[Dot42.DexImport("getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.PackageInfo GetPackageInfo(string packageName, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.PackageInfo);
				}

				/// <java-name>
				/// getLaunchIntentForPackage
				/// </java-name>
				[Dot42.DexImport("getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent GetLaunchIntentForPackage(string packageName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// getPackageGids
				/// </java-name>
				[Dot42.DexImport("getPackageGids", "(Ljava/lang/String;)[I", AccessFlags = 1)]
				public override int[] GetPackageGids(string packageName) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getPermissionInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.PermissionInfo GetPermissionInfo(string name, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.PermissionInfo);
				}

				/// <java-name>
				/// queryPermissionsByGroup
				/// </java-name>
				[Dot42.DexImport("queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/PermissionInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.PermissionInfo> QueryPermissionsByGroup(string group, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.PermissionInfo>);
				}

				/// <java-name>
				/// getPermissionGroupInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.PermissionGroupInfo GetPermissionGroupInfo(string name, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.PermissionGroupInfo);
				}

				/// <java-name>
				/// getAllPermissionGroups
				/// </java-name>
				[Dot42.DexImport("getAllPermissionGroups", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PermissionGroupInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.PermissionGroupInfo> GetAllPermissionGroups(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.PermissionGroupInfo>);
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.ApplicationInfo GetApplicationInfo(string packageName, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ApplicationInfo);
				}

				/// <java-name>
				/// getActivityInfo
				/// </java-name>
				[Dot42.DexImport("getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.ActivityInfo GetActivityInfo(global::Android.Content.ComponentName className, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ActivityInfo);
				}

				/// <java-name>
				/// getReceiverInfo
				/// </java-name>
				[Dot42.DexImport("getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.ActivityInfo GetReceiverInfo(global::Android.Content.ComponentName className, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ActivityInfo);
				}

				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				[Dot42.DexImport("getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.ServiceInfo GetServiceInfo(global::Android.Content.ComponentName className, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ServiceInfo);
				}

				/// <java-name>
				/// getInstalledPackages
				/// </java-name>
				[Dot42.DexImport("getInstalledPackages", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.PackageInfo> GetInstalledPackages(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.PackageInfo>);
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckPermission(string permName, string pkgName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addPermission
				/// </java-name>
				[Dot42.DexImport("addPermission", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1)]
				public override bool AddPermission(global::Android.Content.PM.PermissionInfo info) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removePermission
				/// </java-name>
				[Dot42.DexImport("removePermission", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void RemovePermission(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckSignatures(string uid1, string uid2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(II)I", AccessFlags = 1)]
				public override int CheckSignatures(int uid1, int uid2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPackagesForUid
				/// </java-name>
				[Dot42.DexImport("getPackagesForUid", "(I)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetPackagesForUid(int uid) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getNameForUid
				/// </java-name>
				[Dot42.DexImport("getNameForUid", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetNameForUid(int uid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInstalledApplications
				/// </java-name>
				[Dot42.DexImport("getInstalledApplications", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/ApplicationInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.ApplicationInfo> GetInstalledApplications(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.ApplicationInfo>);
				}

				/// <java-name>
				/// resolveActivity
				/// </java-name>
				[Dot42.DexImport("resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.ResolveInfo ResolveActivity(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ResolveInfo);
				}

				/// <java-name>
				/// queryIntentActivities
				/// </java-name>
				[Dot42.DexImport("queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> QueryIntentActivities(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.ResolveInfo>);
				}

				/// <java-name>
				/// queryIntentActivityOptions
				/// </java-name>
				[Dot42.DexImport("queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> QueryIntentActivityOptions(global::Android.Content.ComponentName caller, global::Android.Content.Intent[] specifics, global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.ResolveInfo>);
				}

				/// <java-name>
				/// queryBroadcastReceivers
				/// </java-name>
				[Dot42.DexImport("queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> QueryBroadcastReceivers(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.ResolveInfo>);
				}

				/// <java-name>
				/// resolveService
				/// </java-name>
				[Dot42.DexImport("resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.ResolveInfo ResolveService(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ResolveInfo);
				}

				/// <java-name>
				/// queryIntentServices
				/// </java-name>
				[Dot42.DexImport("queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.ResolveInfo> QueryIntentServices(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.ResolveInfo>);
				}

				/// <java-name>
				/// resolveContentProvider
				/// </java-name>
				[Dot42.DexImport("resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.ProviderInfo ResolveContentProvider(string name, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ProviderInfo);
				}

				/// <java-name>
				/// queryContentProviders
				/// </java-name>
				[Dot42.DexImport("queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;II)Ljava/util/List<Landroid/content/pm/ProviderInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.ProviderInfo> QueryContentProviders(string processName, int uid, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.ProviderInfo>);
				}

				/// <java-name>
				/// getInstrumentationInfo
				/// </java-name>
				[Dot42.DexImport("getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.InstrumentationInfo GetInstrumentationInfo(global::Android.Content.ComponentName className, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.InstrumentationInfo);
				}

				/// <java-name>
				/// queryInstrumentation
				/// </java-name>
				[Dot42.DexImport("queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/InstrumentationInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.InstrumentationInfo> QueryInstrumentation(string targetPackage, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.InstrumentationInfo>);
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawab" +
    "le/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetDrawable(string packageName, int resid, global::Android.Content.PM.ApplicationInfo appInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetActivityIcon(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetActivityIcon(global::Android.Content.Intent activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetApplicationIcon(global::Android.Content.PM.ApplicationInfo info) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetApplicationIcon(string info) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;" +
    "", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(string packageName, int resid, global::Android.Content.PM.ApplicationInfo appInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/Xml" +
    "ResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetXml(string packageName, int resid, global::Android.Content.PM.ApplicationInfo appInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// getApplicationLabel
				/// </java-name>
				[Dot42.DexImport("getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetApplicationLabel(global::Android.Content.PM.ApplicationInfo info) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getResourcesForActivity
				/// </java-name>
				[Dot42.DexImport("getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForActivity(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForApplication(global::Android.Content.PM.ApplicationInfo app) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForApplication(string app) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getPackageArchiveInfo
				/// </java-name>
				[Dot42.DexImport("getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.PackageInfo GetPackageArchiveInfo(string archiveFilePath, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.PackageInfo);
				}

				/// <java-name>
				/// getInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetInstallerPackageName(string packageName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// addPackageToPreferred
				/// </java-name>
				[Dot42.DexImport("addPackageToPreferred", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void AddPackageToPreferred(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePackageFromPreferred
				/// </java-name>
				[Dot42.DexImport("removePackageFromPreferred", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void RemovePackageFromPreferred(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPreferredPackages
				/// </java-name>
				[Dot42.DexImport("getPreferredPackages", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.PM.PackageInfo> GetPreferredPackages(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.PM.PackageInfo>);
				}

				/// <java-name>
				/// setComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V", AccessFlags = 1)]
				public override void SetComponentEnabledSetting(global::Android.Content.ComponentName componentName, int newState, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getComponentEnabledSetting", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public override int GetComponentEnabledSetting(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setApplicationEnabledSetting", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void SetApplicationEnabledSetting(string packageName, int newState, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getApplicationEnabledSetting", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int GetApplicationEnabledSetting(string packageName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addPreferredActivity
				/// </java-name>
				[Dot42.DexImport("addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/" +
    "ComponentName;)V", AccessFlags = 1)]
				public override void AddPreferredActivity(global::Android.Content.IntentFilter filter, int match, global::Android.Content.ComponentName[] set, global::Android.Content.ComponentName activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearPackagePreferredActivities
				/// </java-name>
				[Dot42.DexImport("clearPackagePreferredActivities", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void ClearPackagePreferredActivities(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPreferredActivities
				/// </java-name>
				[Dot42.DexImport("getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/content/IntentFilter;>;Ljava/util/List<Landroid/content" +
    "/ComponentName;>;Ljava/lang/String;)I")]
				public override int GetPreferredActivities(global::Java.Util.IList<global::Android.Content.IntentFilter> outFilters, global::Java.Util.IList<global::Android.Content.ComponentName> outActivities, string packageName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// hasSystemFeature
				/// </java-name>
				[Dot42.DexImport("hasSystemFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool HasSystemFeature(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDefaultActivityIcon
				/// </java-name>
				public override global::Android.Graphics.Drawables.Drawable DefaultActivityIcon
				{
						[Dot42.DexImport("getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getSystemSharedLibraryNames
				/// </java-name>
				public override string[] SystemSharedLibraryNames
				{
						[Dot42.DexImport("getSystemSharedLibraryNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// getSystemAvailableFeatures
				/// </java-name>
				public override global::Android.Content.PM.FeatureInfo[] SystemAvailableFeatures
				{
						[Dot42.DexImport("getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.FeatureInfo[]); }
				}

				/// <java-name>
				/// isSafeMode
				/// </java-name>
				public override bool IsSafeMode
				{
						[Dot42.DexImport("isSafeMode", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A mock android.content.res.Resources class. All methods are non-functional and throw java.lang.UnsupportedOperationException. Override it to provide the operations that you need. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockResources
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockResources", AccessFlags = 33)]
		public partial class MockResources : global::Android.Content.Res.Resources
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockResources() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateConfiguration
				/// </java-name>
				[Dot42.DexImport("updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public override void UpdateConfiguration(global::Android.Content.Res.Configuration config, global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getQuantityText
				/// </java-name>
				[Dot42.DexImport("getQuantityText", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetQuantityText(int id, int quantity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int id) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public override string GetString(int id, params object[] formatArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public override string GetQuantityString(int id, int quantity, params object[] formatArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetQuantityString(int id, int quantity) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(int id, global::Java.Lang.ICharSequence def) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getTextArray
				/// </java-name>
				[Dot42.DexImport("getTextArray", "(I)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence[] GetTextArray(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(I)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetStringArray(int id) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getIntArray
				/// </java-name>
				[Dot42.DexImport("getIntArray", "(I)[I", AccessFlags = 1)]
				public override int[] GetIntArray(int id) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// obtainTypedArray
				/// </java-name>
				[Dot42.DexImport("obtainTypedArray", "(I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public override global::Android.Content.Res.TypedArray ObtainTypedArray(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(I)F", AccessFlags = 1)]
				public override float GetDimension(int id) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelOffset", "(I)I", AccessFlags = 1)]
				public override int GetDimensionPixelOffset(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelSize", "(I)I", AccessFlags = 1)]
				public override int GetDimensionPixelSize(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetDrawable(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getMovie
				/// </java-name>
				[Dot42.DexImport("getMovie", "(I)Landroid/graphics/Movie;", AccessFlags = 1)]
				public override global::Android.Graphics.Movie GetMovie(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "(I)I", AccessFlags = 1)]
				public override int GetColor(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColorStateList
				/// </java-name>
				[Dot42.DexImport("getColorStateList", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public override global::Android.Content.Res.ColorStateList GetColorStateList(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(I)I", AccessFlags = 1)]
				public override int GetInteger(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLayout
				/// </java-name>
				[Dot42.DexImport("getLayout", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetLayout(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// getAnimation
				/// </java-name>
				[Dot42.DexImport("getAnimation", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetAnimation(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetXml(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// openRawResource
				/// </java-name>
				[Dot42.DexImport("openRawResource", "(I)Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.IO.InputStream OpenRawResource(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <java-name>
				/// openRawResourceFd
				/// </java-name>
				[Dot42.DexImport("openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 1)]
				public override global::Android.Content.Res.AssetFileDescriptor OpenRawResourceFd(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(ILandroid/util/TypedValue;Z)V", AccessFlags = 1)]
				public override void GetValue(int int32, global::Android.Util.TypedValue typedValue, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V", AccessFlags = 1)]
				public override void GetValue(string @string, global::Android.Util.TypedValue typedValue, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// obtainAttributes
				/// </java-name>
				[Dot42.DexImport("obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public override global::Android.Content.Res.TypedArray ObtainAttributes(global::Android.Util.IAttributeSet set, int[] attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// getIdentifier
				/// </java-name>
				[Dot42.DexImport("getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int GetIdentifier(string name, string defType, string defPackage) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getResourceName
				/// </java-name>
				[Dot42.DexImport("getResourceName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourcePackageName
				/// </java-name>
				[Dot42.DexImport("getResourcePackageName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourcePackageName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourceTypeName
				/// </java-name>
				[Dot42.DexImport("getResourceTypeName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceTypeName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourceEntryName
				/// </java-name>
				[Dot42.DexImport("getResourceEntryName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceEntryName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayMetrics
				/// </java-name>
				public override global::Android.Util.DisplayMetrics DisplayMetrics
				{
						[Dot42.DexImport("getDisplayMetrics", "()Landroid/util/DisplayMetrics;", AccessFlags = 1)]
						get{ return default(global::Android.Util.DisplayMetrics); }
				}

				/// <java-name>
				/// getConfiguration
				/// </java-name>
				public override global::Android.Content.Res.Configuration Configuration
				{
						[Dot42.DexImport("getConfiguration", "()Landroid/content/res/Configuration;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Configuration); }
				}

		}

}

