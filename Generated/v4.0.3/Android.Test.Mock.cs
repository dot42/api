#pragma warning disable 1717
namespace Android.Test.Mock
{
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

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public override void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/test/mock/MockContentProvider
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockContentProvider", AccessFlags = 33)]
		public partial class MockContentProvider : global::Android.Content.ContentProvider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal MockContentProvider() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MockContentProvider(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Landroid/content/p" +
    "m/PathPermission;)V", AccessFlags = 1)]
				public MockContentProvider(global::Android.Content.Context context, string @string, string string1, global::Android.Content.Pm.PathPermission[] pathPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public override int Delete(global::Android.Net.Uri uri, string @string, string[] string1) /* MethodBuilder.Create */ 
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
				public override global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues) /* MethodBuilder.Create */ 
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
				public override global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] @string, string string1, string[] string2, string string3) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/St" +
    "ring;)I", AccessFlags = 1)]
				public override int Update(global::Android.Net.Uri uri, global::Android.Content.ContentValues contentValues, string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 1)]
				public override int BulkInsert(global::Android.Net.Uri uri, global::Android.Content.ContentValues[] contentValues) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// attachInfo
				/// </java-name>
				[Dot42.DexImport("attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V", AccessFlags = 1)]
				public override void AttachInfo(global::Android.Content.Context context, global::Android.Content.Pm.ProviderInfo providerInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/content/ContentProviderOperation;>;)[Landroid/cont" +
    "ent/ContentProviderResult;")]
				public override global::Android.Content.ContentProviderResult[] ApplyBatch(global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> arrayList) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetStreamTypes(global::Android.Net.Uri uri, string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// openTypedAssetFile
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFile", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 1)]
				public override global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFile(global::Android.Net.Uri uri, string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

		}

		/// <java-name>
		/// android/test/mock/MockContentResolver
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockContentResolver", AccessFlags = 33)]
		public partial class MockContentResolver : global::Android.Content.ContentResolver
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockContentResolver() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addProvider
				/// </java-name>
				[Dot42.DexImport("addProvider", "(Ljava/lang/String;Landroid/content/ContentProvider;)V", AccessFlags = 1)]
				public virtual void AddProvider(string @string, global::Android.Content.ContentProvider contentProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyChange
				/// </java-name>
				[Dot42.DexImport("notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V", AccessFlags = 1)]
				public override void NotifyChange(global::Android.Net.Uri uri, global::Android.Database.ContentObserver contentObserver, bool boolean) /* MethodBuilder.Create */ 
				{
				}

		}

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
				/// getAssets
				/// </java-name>
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1)]
				public override global::Android.Content.Res.AssetManager GetAssets() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetManager);
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResources() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getPackageManager
				/// </java-name>
				[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PackageManager GetPackageManager() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PackageManager);
				}

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
				public override global::Android.Content.ContentResolver GetContentResolver() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentResolver);
				}

				/// <java-name>
				/// getMainLooper
				/// </java-name>
				[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
				public override global::Android.OS.Looper GetMainLooper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Looper);
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1)]
				public override global::Android.Content.Context GetApplicationContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1)]
				public override void SetTheme(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources.Theme GetTheme() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources.Theme);
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
				public override global::Java.Lang.ClassLoader GetClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ApplicationInfo GetApplicationInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ApplicationInfo);
				}

				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageResourcePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageCodePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public override global::Android.Content.ISharedPreferences GetSharedPreferences(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <java-name>
				/// openFileInput
				/// </java-name>
				[Dot42.DexImport("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", AccessFlags = 1)]
				public override global::Java.Io.FileInputStream OpenFileInput(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileInputStream);
				}

				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public override global::Java.Io.FileOutputStream OpenFileOutput(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileOutputStream);
				}

				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteFile(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetFileStreamPath(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
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
				/// getFilesDir
				/// </java-name>
				[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetFilesDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getExternalFilesDir
				/// </java-name>
				[Dot42.DexImport("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetExternalFilesDir(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getObbDir
				/// </java-name>
				[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetObbDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetCacheDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetExternalCacheDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// getDir
				/// </java-name>
				[Dot42.DexImport("getDir", "(Ljava/lang/String;I)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetDir(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, int int32, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string @string, int int32, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory cursorFactory, global::Android.Database.IDatabaseErrorHandler databaseErrorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetDatabasePath(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
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
				public override bool DeleteDatabase(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWallpaper
				/// </java-name>
				[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetWallpaper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
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
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1)]
				public override int GetWallpaperDesiredMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1)]
				public override int GetWallpaperDesiredMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				public override void SetWallpaper(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
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
				public override void StartActivities(global::Android.Content.Intent[] intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", AccessFlags = 1)]
				public override void StartIntentSender(global::Android.Content.IntentSender intentSender, global::Android.Content.Intent intent, int int32, int int321, int int322) /* MethodBuilder.Create */ 
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
				public override void SendBroadcast(global::Android.Content.Intent intent, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Lan" +
    "droid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string @string, global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.OS.Handler handler, int int32, string string1, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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
				public override void SendStickyOrderedBroadcast(global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.OS.Handler handler, int int32, string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
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
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Content.IntentFilter intentFilter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/Stri" +
    "ng;Landroid/os/Handler;)Landroid/content/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver, global::Android.Content.IntentFilter intentFilter, string @string, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1)]
				public override void UnregisterReceiver(global::Android.Content.BroadcastReceiver broadcastReceiver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public override global::Android.Content.ComponentName StartService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <java-name>
				/// stopService
				/// </java-name>
				[Dot42.DexImport("stopService", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public override bool StopService(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1)]
				public override bool BindService(global::Android.Content.Intent intent, global::Android.Content.IServiceConnection serviceConnection, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unbindService
				/// </java-name>
				[Dot42.DexImport("unbindService", "(Landroid/content/ServiceConnection;)V", AccessFlags = 1)]
				public override void UnbindService(global::Android.Content.IServiceConnection serviceConnection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startInstrumentation
				/// </java-name>
				[Dot42.DexImport("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public override bool StartInstrumentation(global::Android.Content.ComponentName componentName, string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;II)I", AccessFlags = 1)]
				public override int CheckPermission(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingPermission(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfPermission(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enforcePermission
				/// </java-name>
				[Dot42.DexImport("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforcePermission(string @string, int int32, int int321, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// grantUriPermission
				/// </java-name>
				[Dot42.DexImport("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void GrantUriPermission(string @string, global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// revokeUriPermission
				/// </java-name>
				[Dot42.DexImport("revokeUriPermission", "(Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void RevokeUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfUriPermission(global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, string @string, string string1, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, int int32, int int321, int int322, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingUriPermission(global::Android.Net.Uri uri, int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfUriPermission(global::Android.Net.Uri uri, int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, string @string, string string1, int int32, int int321, int int322, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createPackageContext
				/// </java-name>
				[Dot42.DexImport("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", AccessFlags = 1)]
				public override global::Android.Content.Context CreatePackageContext(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <java-name>
				/// isRestricted
				/// </java-name>
				[Dot42.DexImport("isRestricted", "()Z", AccessFlags = 1)]
				public override bool IsRestricted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAssets
				/// </java-name>
				public global::Android.Content.Res.AssetManager Assets
				{
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1)]
						get{ return GetAssets(); }
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				public global::Android.Content.Res.Resources Resources
				{
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return GetResources(); }
				}

				/// <java-name>
				/// getPackageManager
				/// </java-name>
				public global::Android.Content.Pm.PackageManager PackageManager
				{
				[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1)]
						get{ return GetPackageManager(); }
				}

				/// <java-name>
				/// getContentResolver
				/// </java-name>
				public global::Android.Content.ContentResolver ContentResolver
				{
				[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
						get{ return GetContentResolver(); }
				}

				/// <java-name>
				/// getMainLooper
				/// </java-name>
				public global::Android.OS.Looper MainLooper
				{
				[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
						get{ return GetMainLooper(); }
				}

				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public global::Android.Content.Context ApplicationContext
				{
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return GetApplicationContext(); }
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				public global::Android.Content.Res.Resources.Theme Theme
				{
				[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
						get{ return GetTheme(); }
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public global::Java.Lang.ClassLoader ClassLoader
				{
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return GetClassLoader(); }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				public global::Android.Content.Pm.ApplicationInfo ApplicationInfo
				{
				[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
						get{ return GetApplicationInfo(); }
				}

				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				public string PackageResourcePath
				{
				[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageResourcePath(); }
				}

				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				public string PackageCodePath
				{
				[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageCodePath(); }
				}

				/// <java-name>
				/// getFilesDir
				/// </java-name>
				public global::Java.Io.File FilesDir
				{
				[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetFilesDir(); }
				}

				/// <java-name>
				/// getObbDir
				/// </java-name>
				public global::Java.Io.File ObbDir
				{
				[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetObbDir(); }
				}

				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public global::Java.Io.File CacheDir
				{
				[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetCacheDir(); }
				}

				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				public global::Java.Io.File ExternalCacheDir
				{
				[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetExternalCacheDir(); }
				}

				/// <java-name>
				/// getWallpaper
				/// </java-name>
				public global::Android.Graphics.Drawables.Drawable Wallpaper
				{
				[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetWallpaper(); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				public int WallpaperDesiredMinimumWidth
				{
				[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetWallpaperDesiredMinimumWidth(); }
				}

				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				public int WallpaperDesiredMinimumHeight
				{
				[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetWallpaperDesiredMinimumHeight(); }
				}

		}

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

				/// <java-name>
				/// getColumnCount
				/// </java-name>
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
				public virtual int GetColumnCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnIndex
				/// </java-name>
				[Dot42.DexImport("getColumnIndex", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndex(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnIndexOrThrow
				/// </java-name>
				[Dot42.DexImport("getColumnIndexOrThrow", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int GetColumnIndexOrThrow(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnName
				/// </java-name>
				[Dot42.DexImport("getColumnName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetColumnName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetColumnNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
				public virtual int GetCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isNull
				/// </java-name>
				[Dot42.DexImport("isNull", "(I)Z", AccessFlags = 1)]
				public virtual bool IsNull(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getInt
				/// </java-name>
				[Dot42.DexImport("getInt", "(I)I", AccessFlags = 1)]
				public virtual int GetInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(I)J", AccessFlags = 1)]
				public virtual long GetLong(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getShort
				/// </java-name>
				[Dot42.DexImport("getShort", "(I)S", AccessFlags = 1)]
				public virtual short GetShort(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getFloat
				/// </java-name>
				[Dot42.DexImport("getFloat", "(I)F", AccessFlags = 1)]
				public virtual float GetFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDouble
				/// </java-name>
				[Dot42.DexImport("getDouble", "(I)D", AccessFlags = 1)]
				public virtual double GetDouble(int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBlob
				/// </java-name>
				[Dot42.DexImport("getBlob", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetBlob(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
				public virtual int GetPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isAfterLast
				/// </java-name>
				[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1)]
				public virtual bool IsAfterLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1)]
				public virtual bool IsBeforeFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFirst
				/// </java-name>
				[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1)]
				public virtual bool IsFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLast
				/// </java-name>
				[Dot42.DexImport("isLast", "()Z", AccessFlags = 1)]
				public virtual bool IsLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// move
				/// </java-name>
				[Dot42.DexImport("move", "(I)Z", AccessFlags = 1)]
				public virtual bool Move(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToFirst
				/// </java-name>
				[Dot42.DexImport("moveToFirst", "()Z", AccessFlags = 1)]
				public virtual bool MoveToFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToLast
				/// </java-name>
				[Dot42.DexImport("moveToLast", "()Z", AccessFlags = 1)]
				public virtual bool MoveToLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToNext
				/// </java-name>
				[Dot42.DexImport("moveToNext", "()Z", AccessFlags = 1)]
				public virtual bool MoveToNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToPrevious
				/// </java-name>
				[Dot42.DexImport("moveToPrevious", "()Z", AccessFlags = 1)]
				public virtual bool MoveToPrevious() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToPosition
				/// </java-name>
				[Dot42.DexImport("moveToPosition", "(I)Z", AccessFlags = 1)]
				public virtual bool MoveToPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int int32, global::Android.Database.CharArrayBuffer charArrayBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public virtual void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requery
				/// </java-name>
				[Dot42.DexImport("requery", "()Z", AccessFlags = 1)]
				public virtual bool Requery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void RegisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle Respond(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
				public virtual bool GetWantsAllOnMoveCalls() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetNotificationUri(global::Android.Content.ContentResolver contentResolver, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterContentObserver(global::Android.Database.ContentObserver contentObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 1)]
				public virtual int GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColumnCount
				/// </java-name>
				public int ColumnCount
				{
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						get{ return GetColumnCount(); }
				}

				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public string[] ColumnNames
				{
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetColumnNames(); }
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public int Count
				{
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return GetCount(); }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.OS.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				public int Position
				{
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
						get{ return GetPosition(); }
				}

				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				public bool IsWantsAllOnMoveCalls
				{
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
						get{ return GetWantsAllOnMoveCalls(); }
				}

		}

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

		/// <java-name>
		/// android/test/mock/MockPackageManager
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockPackageManager", AccessFlags = 33)]
		public partial class MockPackageManager : global::Android.Content.Pm.PackageManager
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
				public override global::Android.Content.Pm.PackageInfo GetPackageInfo(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PackageInfo);
				}

				/// <java-name>
				/// currentToCanonicalPackageNames
				/// </java-name>
				[Dot42.DexImport("currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] CurrentToCanonicalPackageNames(string[] @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// canonicalToCurrentPackageNames
				/// </java-name>
				[Dot42.DexImport("canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] CanonicalToCurrentPackageNames(string[] @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getLaunchIntentForPackage
				/// </java-name>
				[Dot42.DexImport("getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent GetLaunchIntentForPackage(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// getPackageGids
				/// </java-name>
				[Dot42.DexImport("getPackageGids", "(Ljava/lang/String;)[I", AccessFlags = 1)]
				public override int[] GetPackageGids(string @string) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getPermissionInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PermissionInfo GetPermissionInfo(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PermissionInfo);
				}

				/// <java-name>
				/// queryPermissionsByGroup
				/// </java-name>
				[Dot42.DexImport("queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/PermissionInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.PermissionInfo> QueryPermissionsByGroup(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.PermissionInfo>);
				}

				/// <java-name>
				/// getPermissionGroupInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PermissionGroupInfo GetPermissionGroupInfo(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PermissionGroupInfo);
				}

				/// <java-name>
				/// getAllPermissionGroups
				/// </java-name>
				[Dot42.DexImport("getAllPermissionGroups", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PermissionGroupInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.PermissionGroupInfo> GetAllPermissionGroups(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.PermissionGroupInfo>);
				}

				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ApplicationInfo GetApplicationInfo(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ApplicationInfo);
				}

				/// <java-name>
				/// getActivityInfo
				/// </java-name>
				[Dot42.DexImport("getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ActivityInfo GetActivityInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ActivityInfo);
				}

				/// <java-name>
				/// getReceiverInfo
				/// </java-name>
				[Dot42.DexImport("getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ActivityInfo GetReceiverInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ActivityInfo);
				}

				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				[Dot42.DexImport("getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ServiceInfo GetServiceInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ServiceInfo);
				}

				/// <java-name>
				/// getProviderInfo
				/// </java-name>
				[Dot42.DexImport("getProviderInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ProviderInfo GetProviderInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ProviderInfo);
				}

				/// <java-name>
				/// getInstalledPackages
				/// </java-name>
				[Dot42.DexImport("getInstalledPackages", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.PackageInfo> GetInstalledPackages(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.PackageInfo>);
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addPermission
				/// </java-name>
				[Dot42.DexImport("addPermission", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1)]
				public override bool AddPermission(global::Android.Content.Pm.PermissionInfo permissionInfo) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addPermissionAsync
				/// </java-name>
				[Dot42.DexImport("addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1)]
				public override bool AddPermissionAsync(global::Android.Content.Pm.PermissionInfo permissionInfo) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removePermission
				/// </java-name>
				[Dot42.DexImport("removePermission", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void RemovePermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckSignatures(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(II)I", AccessFlags = 1)]
				public override int CheckSignatures(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPackagesForUid
				/// </java-name>
				[Dot42.DexImport("getPackagesForUid", "(I)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetPackagesForUid(int int32) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getNameForUid
				/// </java-name>
				[Dot42.DexImport("getNameForUid", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetNameForUid(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInstalledApplications
				/// </java-name>
				[Dot42.DexImport("getInstalledApplications", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/ApplicationInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ApplicationInfo> GetInstalledApplications(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ApplicationInfo>);
				}

				/// <java-name>
				/// resolveActivity
				/// </java-name>
				[Dot42.DexImport("resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ResolveInfo ResolveActivity(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ResolveInfo);
				}

				/// <java-name>
				/// queryIntentActivities
				/// </java-name>
				[Dot42.DexImport("queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentActivities(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo>);
				}

				/// <java-name>
				/// queryIntentActivityOptions
				/// </java-name>
				[Dot42.DexImport("queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentActivityOptions(global::Android.Content.ComponentName componentName, global::Android.Content.Intent[] intent, global::Android.Content.Intent intent1, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo>);
				}

				/// <java-name>
				/// queryBroadcastReceivers
				/// </java-name>
				[Dot42.DexImport("queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryBroadcastReceivers(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo>);
				}

				/// <java-name>
				/// resolveService
				/// </java-name>
				[Dot42.DexImport("resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ResolveInfo ResolveService(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ResolveInfo);
				}

				/// <java-name>
				/// queryIntentServices
				/// </java-name>
				[Dot42.DexImport("queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentServices(global::Android.Content.Intent intent, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo>);
				}

				/// <java-name>
				/// resolveContentProvider
				/// </java-name>
				[Dot42.DexImport("resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ProviderInfo ResolveContentProvider(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ProviderInfo);
				}

				/// <java-name>
				/// queryContentProviders
				/// </java-name>
				[Dot42.DexImport("queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;II)Ljava/util/List<Landroid/content/pm/ProviderInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ProviderInfo> QueryContentProviders(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ProviderInfo>);
				}

				/// <java-name>
				/// getInstrumentationInfo
				/// </java-name>
				[Dot42.DexImport("getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.InstrumentationInfo GetInstrumentationInfo(global::Android.Content.ComponentName componentName, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.InstrumentationInfo);
				}

				/// <java-name>
				/// queryInstrumentation
				/// </java-name>
				[Dot42.DexImport("queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/InstrumentationInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.InstrumentationInfo> QueryInstrumentation(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.InstrumentationInfo>);
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawab" +
    "le/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetDrawable(string @string, int int32, global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetActivityIcon(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetActivityIcon(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getDefaultActivityIcon
				/// </java-name>
				[Dot42.DexImport("getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetDefaultActivityIcon() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetApplicationIcon(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetApplicationIcon(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetActivityLogo(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetActivityLogo(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetApplicationLogo(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetApplicationLogo(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;" +
    "", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(string @string, int int32, global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/Xml" +
    "ResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetXml(string @string, int int32, global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// getApplicationLabel
				/// </java-name>
				[Dot42.DexImport("getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetApplicationLabel(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getResourcesForActivity
				/// </java-name>
				[Dot42.DexImport("getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForActivity(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForApplication(global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForApplication(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <java-name>
				/// getPackageArchiveInfo
				/// </java-name>
				[Dot42.DexImport("getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PackageInfo GetPackageArchiveInfo(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PackageInfo);
				}

				/// <java-name>
				/// setInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("setInstallerPackageName", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SetInstallerPackageName(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetInstallerPackageName(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// addPackageToPreferred
				/// </java-name>
				[Dot42.DexImport("addPackageToPreferred", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void AddPackageToPreferred(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePackageFromPreferred
				/// </java-name>
				[Dot42.DexImport("removePackageFromPreferred", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void RemovePackageFromPreferred(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPreferredPackages
				/// </java-name>
				[Dot42.DexImport("getPreferredPackages", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.PackageInfo> GetPreferredPackages(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.PackageInfo>);
				}

				/// <java-name>
				/// setComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V", AccessFlags = 1)]
				public override void SetComponentEnabledSetting(global::Android.Content.ComponentName componentName, int int32, int int321) /* MethodBuilder.Create */ 
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
				public override void SetApplicationEnabledSetting(string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getApplicationEnabledSetting", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int GetApplicationEnabledSetting(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addPreferredActivity
				/// </java-name>
				[Dot42.DexImport("addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/" +
    "ComponentName;)V", AccessFlags = 1)]
				public override void AddPreferredActivity(global::Android.Content.IntentFilter intentFilter, int int32, global::Android.Content.ComponentName[] componentName, global::Android.Content.ComponentName componentName1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearPackagePreferredActivities
				/// </java-name>
				[Dot42.DexImport("clearPackagePreferredActivities", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void ClearPackagePreferredActivities(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPreferredActivities
				/// </java-name>
				[Dot42.DexImport("getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/content/IntentFilter;>;Ljava/util/List<Landroid/content" +
    "/ComponentName;>;Ljava/lang/String;)I")]
				public override int GetPreferredActivities(global::Java.Util.IList<global::Android.Content.IntentFilter> list, global::Java.Util.IList<global::Android.Content.ComponentName> list1, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSystemSharedLibraryNames
				/// </java-name>
				[Dot42.DexImport("getSystemSharedLibraryNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetSystemSharedLibraryNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getSystemAvailableFeatures
				/// </java-name>
				[Dot42.DexImport("getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.FeatureInfo[] GetSystemAvailableFeatures() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.FeatureInfo[]);
				}

				/// <java-name>
				/// hasSystemFeature
				/// </java-name>
				[Dot42.DexImport("hasSystemFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool HasSystemFeature(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSafeMode
				/// </java-name>
				[Dot42.DexImport("isSafeMode", "()Z", AccessFlags = 1)]
				public override bool IsSafeMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// verifyPendingInstall
				/// </java-name>
				[Dot42.DexImport("verifyPendingInstall", "(II)V", AccessFlags = 1)]
				public override void VerifyPendingInstall(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultActivityIcon
				/// </java-name>
				public global::Android.Graphics.Drawables.Drawable DefaultActivityIcon
				{
				[Dot42.DexImport("getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetDefaultActivityIcon(); }
				}

				/// <java-name>
				/// getSystemSharedLibraryNames
				/// </java-name>
				public string[] SystemSharedLibraryNames
				{
				[Dot42.DexImport("getSystemSharedLibraryNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSystemSharedLibraryNames(); }
				}

				/// <java-name>
				/// getSystemAvailableFeatures
				/// </java-name>
				public global::Android.Content.Pm.FeatureInfo[] SystemAvailableFeatures
				{
				[Dot42.DexImport("getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", AccessFlags = 1)]
						get{ return GetSystemAvailableFeatures(); }
				}

		}

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
				public override void UpdateConfiguration(global::Android.Content.Res.Configuration configuration, global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getQuantityText
				/// </java-name>
				[Dot42.DexImport("getQuantityText", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetQuantityText(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public override string GetString(int int32, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public override string GetQuantityString(int int32, int int321, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetQuantityString(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getTextArray
				/// </java-name>
				[Dot42.DexImport("getTextArray", "(I)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence[] GetTextArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(I)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetStringArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// getIntArray
				/// </java-name>
				[Dot42.DexImport("getIntArray", "(I)[I", AccessFlags = 1)]
				public override int[] GetIntArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// obtainTypedArray
				/// </java-name>
				[Dot42.DexImport("obtainTypedArray", "(I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public override global::Android.Content.Res.TypedArray ObtainTypedArray(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(I)F", AccessFlags = 1)]
				public override float GetDimension(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelOffset", "(I)I", AccessFlags = 1)]
				public override int GetDimensionPixelOffset(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelSize", "(I)I", AccessFlags = 1)]
				public override int GetDimensionPixelSize(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawables.Drawable GetDrawable(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawables.Drawable);
				}

				/// <java-name>
				/// getMovie
				/// </java-name>
				[Dot42.DexImport("getMovie", "(I)Landroid/graphics/Movie;", AccessFlags = 1)]
				public override global::Android.Graphics.Movie GetMovie(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "(I)I", AccessFlags = 1)]
				public override int GetColor(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getColorStateList
				/// </java-name>
				[Dot42.DexImport("getColorStateList", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public override global::Android.Content.Res.ColorStateList GetColorStateList(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(I)I", AccessFlags = 1)]
				public override int GetInteger(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLayout
				/// </java-name>
				[Dot42.DexImport("getLayout", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetLayout(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// getAnimation
				/// </java-name>
				[Dot42.DexImport("getAnimation", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetAnimation(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetXml(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <java-name>
				/// openRawResource
				/// </java-name>
				[Dot42.DexImport("openRawResource", "(I)Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream OpenRawResource(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <java-name>
				/// openRawResourceFd
				/// </java-name>
				[Dot42.DexImport("openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;", AccessFlags = 1)]
				public override global::Android.Content.Res.AssetFileDescriptor OpenRawResourceFd(int int32) /* MethodBuilder.Create */ 
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
				public override global::Android.Content.Res.TypedArray ObtainAttributes(global::Android.Util.IAttributeSet attributeSet, int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <java-name>
				/// getDisplayMetrics
				/// </java-name>
				[Dot42.DexImport("getDisplayMetrics", "()Landroid/util/DisplayMetrics;", AccessFlags = 1)]
				public override global::Android.Util.DisplayMetrics GetDisplayMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.DisplayMetrics);
				}

				/// <java-name>
				/// getConfiguration
				/// </java-name>
				[Dot42.DexImport("getConfiguration", "()Landroid/content/res/Configuration;", AccessFlags = 1)]
				public override global::Android.Content.Res.Configuration GetConfiguration() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Configuration);
				}

				/// <java-name>
				/// getIdentifier
				/// </java-name>
				[Dot42.DexImport("getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int GetIdentifier(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getResourceName
				/// </java-name>
				[Dot42.DexImport("getResourceName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourcePackageName
				/// </java-name>
				[Dot42.DexImport("getResourcePackageName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourcePackageName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourceTypeName
				/// </java-name>
				[Dot42.DexImport("getResourceTypeName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceTypeName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getResourceEntryName
				/// </java-name>
				[Dot42.DexImport("getResourceEntryName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceEntryName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayMetrics
				/// </java-name>
				public global::Android.Util.DisplayMetrics DisplayMetrics
				{
				[Dot42.DexImport("getDisplayMetrics", "()Landroid/util/DisplayMetrics;", AccessFlags = 1)]
						get{ return GetDisplayMetrics(); }
				}

				/// <java-name>
				/// getConfiguration
				/// </java-name>
				public global::Android.Content.Res.Configuration Configuration
				{
				[Dot42.DexImport("getConfiguration", "()Landroid/content/res/Configuration;", AccessFlags = 1)]
						get{ return GetConfiguration(); }
				}

		}

}

