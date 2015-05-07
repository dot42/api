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
		///  <para>Mock implementation of ContentProvider. All methods are non-functional and throw java.lang.UnsupportedOperationException. Tests can extend this class to implement behavior needed for tests. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockContentProvider
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockContentProvider", AccessFlags = 33)]
		public partial class MockContentProvider : global::Android.Content.ContentProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A constructor using MockContext instance as a Context in it. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal MockContentProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>A constructor accepting a Context instance, which is supposed to be the subclasss of MockContext. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MockContentProvider(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>A constructor which initialize four member variables which android.content.ContentProvider have internally.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Landroid/content/p" +
    "m/PathPermission;)V", AccessFlags = 1)]
				public MockContentProvider(global::Android.Content.Context context, string readPermission, string writePermission, global::Android.Content.PM.PathPermission[] pathPermissions) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public override int Delete(global::Android.Net.Uri uri, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 1)]
				public override global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()Z", AccessFlags = 1)]
				public override bool OnCreate() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public override global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 1)]
				public override int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues values, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>If you're reluctant to implement this manually, please just call super.bulkInsert(). </para>        
				/// </summary>
				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 1)]
				public override int BulkInsert(global::Android.Net.Uri uri, global::Android.Content.ContentValues[] values) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// attachInfo
				/// </java-name>
				[Dot42.DexImport("attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V", AccessFlags = 1)]
				public override void AttachInfo(global::Android.Content.Context context, global::Android.Content.PM.ProviderInfo info) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/content/ContentProviderOperation;>;)[Landroid/cont" +
    "ent/ContentProviderResult;")]
				public override global::Android.Content.ContentProviderResult[] ApplyBatch(global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> operations) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetStreamTypes(global::Android.Net.Uri url, string mimeTypeFilter) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// openTypedAssetFile
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFile", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 1)]
				public override global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFile(global::Android.Net.Uri url, string mimeType, global::Android.OS.Bundle opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
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
				/// getExternalFilesDir
				/// </java-name>
				[Dot42.DexImport("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.IO.File GetExternalFilesDir(string type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.File);
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
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string file, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, global::Android.Database.IDatabaseErrorHandler errorHandler) /* MethodBuilder.Create */ 
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
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "([Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void StartActivities(global::Android.Content.Intent[] intents) /* MethodBuilder.Create */ 
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
				public override string PackageResourcePath
				{
						[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				public override string PackageCodePath
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
				/// getObbDir
				/// </java-name>
				public override global::Java.IO.File ObbDir
				{
						[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1)]
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
				/// getExternalCacheDir
				/// </java-name>
				public override global::Java.IO.File ExternalCacheDir
				{
						[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
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
		///  <para>A mock android.database.Cursor class that isolates the test code from real Cursor implementation. </para> <para>All methods including ones related to querying the state of the cursor are are non-functional and throw java.lang.UnsupportedOperationException. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockCursor
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockCursor", AccessFlags = 33)]
		public partial class MockCursor : global::Android.Database.ICursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockCursor() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the zero-based index for the given column name, or -1 if the column doesn't exist. If you expect the column to exist use getColumnIndexOrThrow(String) instead, which will make the error more clear.</para> <para> <para>getColumnIndexOrThrow(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the zero-based column index for the given column name, or -1 if the column name does not exist. </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndex(string columnName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the zero-based index for the given column name, or throws IllegalArgumentException if the column doesn't exist. If you're not sure if a column will exist or not use getColumnIndex(String) and check for -1, which is more efficient than catching the exceptions.</para> <para> <para>getColumnIndex(String) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the zero-based column index for the given column name </para>
				/// </returns>
				/// <java-name>
				/// getColumnIndexOrThrow
				/// </java-name>
				[Dot42.DexImport("getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndexOrThrow(string columnName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the column name at the given zero-based column index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the column name for the given column index. </para>
				/// </returns>
				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetColumnName(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns  <code>true</code> if the value in the indicated column is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the column value is null. </para>
				/// </returns>
				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public virtual bool IsNull(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as an int.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Integer.MIN_VALUE</code>,  <code>Integer.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as an int. </para>
				/// </returns>
				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public virtual int GetInt(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a long.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Long.MIN_VALUE</code>,  <code>Long.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a long. </para>
				/// </returns>
				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public virtual long GetLong(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a short.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [ <code>Short.MIN_VALUE</code>,  <code>Short.MAX_VALUE</code>] is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a short. </para>
				/// </returns>
				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public virtual short GetShort(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a float.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>float</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a float. </para>
				/// </returns>
				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public virtual float GetFloat(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a double.</para> <para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a  <code>double</code> value is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a double. </para>
				/// </returns>
				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public virtual double GetDouble(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a byte array.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a byte array. </para>
				/// </returns>
				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetBlob(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns the value of the requested column as a String.</para> <para>The result and whether this method throws an exception when the column value is null or the column type is not a string type is implementation-defined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of that column as a String. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Move the cursor by a relative amount, forward or backward, from the current position. Positive offsets move forwards, negative offsets move backwards. If the final position is outside of the bounds of the result set then the resultant position will be pinned to -1 or count() depending on whether the value is off the front or end of the set, respectively.</para> <para>This method will return true if the requested destination was reachable, otherwise, it returns false. For example, if the cursor is at currently on the second entry in the result set and move(-5) is called, the position will be pinned at -1, and false will be returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the requested move fully succeeded. </para>
				/// </returns>
				/// <java-name>
				/// move
				/// </java-name>
				[Dot42.DexImport("move", "(I)Z", AccessFlags = 1)]
				public virtual bool Move(int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the first row.</para> <para>This method will return false if the cursor is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToFirst
				/// </java-name>
				[Dot42.DexImport("moveToFirst", "()Z", AccessFlags = 1)]
				public virtual bool MoveToFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the last row.</para> <para>This method will return false if the cursor is empty.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToLast
				/// </java-name>
				[Dot42.DexImport("moveToLast", "()Z", AccessFlags = 1)]
				public virtual bool MoveToLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the next row.</para> <para>This method will return false if the cursor is already past the last entry in the result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToNext
				/// </java-name>
				[Dot42.DexImport("moveToNext", "()Z", AccessFlags = 1)]
				public virtual bool MoveToNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the previous row.</para> <para>This method will return false if the cursor is already before the first entry in the result set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the move succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToPrevious
				/// </java-name>
				[Dot42.DexImport("moveToPrevious", "()Z", AccessFlags = 1)]
				public virtual bool MoveToPrevious() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to an absolute position. The valid range of values is -1 &lt;= position &lt;= count.</para> <para>This method will return true if the request destination was reachable, otherwise, it returns false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the requested move fully succeeded. </para>
				/// </returns>
				/// <java-name>
				/// moveToPosition
				/// </java-name>
				[Dot42.DexImport("moveToPosition", "(I)Z", AccessFlags = 1)]
				public virtual bool MoveToPosition(int position) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves the requested column text and stores it in the buffer provided. If the buffer size is not sufficient, a new char buffer will be allocated and assigned to CharArrayBuffer.data </para>        
				/// </summary>
				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int columnIndex, global::Android.Database.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Deactivates the Cursor, making all calls on it fail until requery is called. Inactive Cursors use fewer resources than active Cursors. Calling requery will make the cursor active again.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Since requery() is deprecated, so too is this. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public virtual void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the Cursor, releasing all of its resources and making it completely invalid. Unlike deactivate() a call to requery() will not make the Cursor valid again. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Performs the query that created the cursor again, refreshing its contents. This may be done at any time, including after a call to deactivate.</para> <para>Since this method could execute a query on the database and potentially take a while, it could cause ANR if it is called on Main (UI) thread. A warning is printed if this method is being executed on Main thread.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Don't use this. Just request a new cursor, so you can do this asynchronously and update your list view once the new cursor comes back. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the requery succeeded, false if not, in which case the cursor becomes invalid. </para>
				/// </returns>
				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1)]
				public virtual bool Requery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the content backing this cursor. Typically the data set won't change until requery() is called.</para> <para> <para>unregisterContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void RegisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register an observer that is called when changes happen to the contents of the this cursors data set, for example, when the data set is changed via requery(), deactivate(), or close().</para> <para> <para>unregisterDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is an out-of-band way for the the user of a cursor to communicate with the cursor. The structure of each bundle is entirely defined by the cursor.</para> <para>One use of this is to tell a cursor that it should retry its network request after it reported an error. </para>        
				/// </summary>
				/// <returns>
				///  <para>extra values, or Bundle.EMPTY. Never  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle Respond(global::Android.OS.Bundle extras) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Register to watch a content URI for changes. This can be the URI of a specific data row (for example, "content://my_provider_type/23"), or a a generic URI for a content type.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetNotificationUri(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para> <para> <para>registerDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns data type of the given column's value. The preferred type of the column is returned but the data may be converted to other types as documented in the get-type methods such as getInt(int), getFloat(int) etc. </para> <para>Returned column types are  <ul> <li> <para>FIELD_TYPE_NULL </para></li> <li> <para>FIELD_TYPE_INTEGER </para></li> <li> <para>FIELD_TYPE_FLOAT </para></li> <li> <para>FIELD_TYPE_STRING </para></li> <li> <para>FIELD_TYPE_BLOB </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>column value type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public virtual int GetType(int columnIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return total number of columns </para>        
				/// </summary>
				/// <returns>
				///  <para>number of columns </para>
				/// </returns>
				/// <java-name>
				/// getColumnCount
				/// </java-name>
				public virtual int ColumnCount
				{
						[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public virtual string[] ColumnNames
				{
						[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <summary>
				///  <para>Returns the numbers of rows in the cursor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public virtual int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a bundle of extra values. This is an optional way for cursors to provide out-of-band metadata to their users. One use of this is for reporting on the progress of network requests that are required to fetch data for the cursor.</para> <para>These values may only change when requery is called. </para>        
				/// </summary>
				/// <returns>
				///  <para>cursor-defined values, or Bundle.EMPTY if there are no values. Never  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getExtras
				/// </java-name>
				public virtual global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

				/// <summary>
				///  <para>Returns the current position of the cursor in the row set. The value is zero-based. When the row set is first returned the cursor will be at positon -1, which is before the first row. After the last row is returned another call to next() will leave the cursor past the last entry, at a position of count().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current cursor position. </para>
				/// </returns>
				/// <java-name>
				/// getPosition
				/// </java-name>
				public virtual int Position
				{
						[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the position after the last row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is after the last result. </para>
				/// </returns>
				/// <java-name>
				/// isAfterLast
				/// </java-name>
				public virtual bool IsAfterLast
				{
						[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the position before the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is before the first result. </para>
				/// </returns>
				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				public virtual bool IsBeforeFirst
				{
						[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the first row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is pointing at the first entry. </para>
				/// </returns>
				/// <java-name>
				/// isFirst
				/// </java-name>
				public virtual bool IsFirst
				{
						[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns whether the cursor is pointing to the last row.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether the cursor is pointing at the last entry. </para>
				/// </returns>
				/// <java-name>
				/// isLast
				/// </java-name>
				public virtual bool IsLast
				{
						[Dot42.DexImport("isLast", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>return true if the cursor is closed </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the cursor is closed. </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				public virtual bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>onMove() will only be called across processes if this method returns true. </para>        
				/// </summary>
				/// <returns>
				///  <para>whether all cursor movement should result in a call to onMove(). </para>
				/// </returns>
				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				public virtual bool WantsAllOnMoveCalls
				{
						[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
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
				/// currentToCanonicalPackageNames
				/// </java-name>
				[Dot42.DexImport("currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] CurrentToCanonicalPackageNames(string[] names) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// canonicalToCurrentPackageNames
				/// </java-name>
				[Dot42.DexImport("canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] CanonicalToCurrentPackageNames(string[] names) /* MethodBuilder.Create */ 
				{
						return default(string[]);
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
				/// getProviderInfo
				/// </java-name>
				[Dot42.DexImport("getProviderInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1)]
				public override global::Android.Content.PM.ProviderInfo GetProviderInfo(global::Android.Content.ComponentName className, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.PM.ProviderInfo);
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
				/// addPermissionAsync
				/// </java-name>
				[Dot42.DexImport("addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1)]
				public override bool AddPermissionAsync(global::Android.Content.PM.PermissionInfo info) /* MethodBuilder.Create */ 
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
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetActivityLogo(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetActivityLogo(global::Android.Content.Intent activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetApplicationLogo(global::Android.Content.PM.ApplicationInfo info) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetApplicationLogo(string info) /* MethodBuilder.Create */ 
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
				/// setInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("setInstallerPackageName", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SetInstallerPackageName(string targetPackage, string installerPackageName) /* MethodBuilder.Create */ 
				{
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
				/// verifyPendingInstall
				/// </java-name>
				[Dot42.DexImport("verifyPendingInstall", "(II)V", AccessFlags = 1)]
				public override void VerifyPendingInstall(int id, int verificationCode) /* MethodBuilder.Create */ 
				{
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

