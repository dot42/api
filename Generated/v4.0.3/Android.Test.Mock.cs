// Copyright (C) 2014 dot42
//
// Original filename: Android.Test.Mock.cs
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
namespace Android.Test.Mock
{
		/// <summary>
		/// <para>A mock android.content.Context class. All methods are non-functional and throw java.lang.UnsupportedOperationException. You can use this to inject other dependencies, mocks, or monitors into the classes you are testing. </para>    
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

				/// <summary>
				/// <para>Return an AssetManager instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getAssets
				/// </java-name>
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1)]
				public override global::Android.Content.Res.AssetManager GetAssets() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetManager);
				}

				/// <summary>
				/// <para>Return a Resources instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getResources
				/// </java-name>
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResources() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <summary>
				/// <para>Return PackageManager instance to find global package information. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageManager
				/// </java-name>
				[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PackageManager GetPackageManager() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PackageManager);
				}

				/// <summary>
				/// <para>Return a ContentResolver instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getContentResolver
				/// </java-name>
				[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
				public override global::Android.Content.ContentResolver GetContentResolver() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentResolver);
				}

				/// <summary>
				/// <para>Return the Looper for the main thread of the current process. This is the thread used to dispatch calls to application components (activities, services, etc). </para><para>By definition, this method returns the same result as would be obtained by calling Looper.getMainLooper(). </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The main looper. </para>
				/// </returns>
				/// <java-name>
				/// getMainLooper
				/// </java-name>
				[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
				public override global::Android.Os.Looper GetMainLooper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Looper);
				}

				/// <summary>
				/// <para>Return the context of the single, global Application object of the current process. This generally should only be used if you need a Context whose lifecycle is separate from the current context, that is tied to the lifetime of the process rather than the current component.</para><para>Consider for example how this interacts with registerReceiver(BroadcastReceiver, IntentFilter): <ul><li><para></para><para>If used from an Activity context, the receiver is being registered within that activity. This means that you are expected to unregister before the activity is done being destroyed; in fact if you do not do so, the framework will clean up your leaked registration as it removes the activity and log an error. Thus, if you use the Activity context to register a receiver that is static (global to the process, not associated with an Activity instance) then that registration will be removed on you at whatever point the activity you used is destroyed. </para></li><li><para></para><para>If used from the Context returned here, the receiver is being registered with the global state associated with your application. Thus it will never be unregistered for you. This is necessary if the receiver is associated with static data, not a particular component. However using the ApplicationContext elsewhere can easily lead to serious leaks if you forget to unregister, unbind, etc. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1)]
				public override global::Android.Content.Context GetApplicationContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <summary>
				/// <para>Set the base theme for this context. Note that this should be called before any views are instantiated in the Context (for example before calling android.app.Activity#setContentView or android.view.LayoutInflater#inflate).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1)]
				public override void SetTheme(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the Theme object associated with this Context. </para>        
				/// </summary>
				/// <java-name>
				/// getTheme
				/// </java-name>
				[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources.Theme GetTheme() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources.Theme);
				}

				/// <summary>
				/// <para>Return a class loader you can use to retrieve classes in this package. </para>        
				/// </summary>
				/// <java-name>
				/// getClassLoader
				/// </java-name>
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
				public override global::Java.Lang.ClassLoader GetClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <summary>
				/// <para>Return the name of this application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the full application info for this context's package. </para>        
				/// </summary>
				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ApplicationInfo GetApplicationInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ApplicationInfo);
				}

				/// <summary>
				/// <para>Return the full path to this context's primary Android package. The Android package is a ZIP file which contains the application's primary resources.</para><para>Note: this is not generally useful for applications, since they should not be directly accessing the file system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String Path to the resources. </para>
				/// </returns>
				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageResourcePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the full path to this context's primary Android package. The Android package is a ZIP file which contains application's primary code and assets.</para><para>Note: this is not generally useful for applications, since they should not be directly accessing the file system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String Path to the code and assets. </para>
				/// </returns>
				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetPackageCodePath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Retrieve and hold the contents of the preferences file 'name', returning a SharedPreferences through which you can retrieve and modify its values. Only one instance of the SharedPreferences object is returned to any callers for the same name, meaning they will see each other's edits as soon as they are made.</para><para><para>MODE_PRIVATE </para><simplesectsep></simplesectsep><para>MODE_WORLD_READABLE </para><simplesectsep></simplesectsep><para>MODE_WORLD_WRITEABLE </para><simplesectsep></simplesectsep><para>MODE_MULTI_PROCESS </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the single SharedPreferences instance that can be used to retrieve and modify the preference values.</para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public override global::Android.Content.ISharedPreferences GetSharedPreferences(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <summary>
				/// <para>Open a private file associated with this Context's application package for reading.</para><para><para>openFileOutput </para><simplesectsep></simplesectsep><para>fileList </para><simplesectsep></simplesectsep><para>deleteFile </para><simplesectsep></simplesectsep><para>java.io.FileInputStream::FileInputStream(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>FileInputStream Resulting input stream.</para>
				/// </returns>
				/// <java-name>
				/// openFileInput
				/// </java-name>
				[Dot42.DexImport("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", AccessFlags = 1)]
				public override global::Java.Io.FileInputStream OpenFileInput(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileInputStream);
				}

				/// <summary>
				/// <para>Open a private file associated with this Context's application package for writing. Creates the file if it doesn't already exist.</para><para><para>MODE_APPEND </para><simplesectsep></simplesectsep><para>MODE_PRIVATE </para><simplesectsep></simplesectsep><para>MODE_WORLD_READABLE </para><simplesectsep></simplesectsep><para>MODE_WORLD_WRITEABLE </para><simplesectsep></simplesectsep><para>openFileInput </para><simplesectsep></simplesectsep><para>fileList </para><simplesectsep></simplesectsep><para>deleteFile </para><simplesectsep></simplesectsep><para>java.io.FileOutputStream::FileOutputStream(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>FileOutputStream Resulting output stream.</para>
				/// </returns>
				/// <java-name>
				/// openFileOutput
				/// </java-name>
				[Dot42.DexImport("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", AccessFlags = 1)]
				public override global::Java.Io.FileOutputStream OpenFileOutput(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.FileOutputStream);
				}

				/// <summary>
				/// <para>Delete the given private file associated with this Context's application package.</para><para><para>openFileInput </para><simplesectsep></simplesectsep><para>openFileOutput </para><simplesectsep></simplesectsep><para>fileList </para><simplesectsep></simplesectsep><para>java.io.File::delete() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the file was successfully deleted; else false.</para>
				/// </returns>
				/// <java-name>
				/// deleteFile
				/// </java-name>
				[Dot42.DexImport("deleteFile", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteFile(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the absolute path on the filesystem where a file created with openFileOutput is stored.</para><para><para>openFileOutput </para><simplesectsep></simplesectsep><para>getFilesDir </para><simplesectsep></simplesectsep><para>getDir </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an absolute path to the given file.</para>
				/// </returns>
				/// <java-name>
				/// getFileStreamPath
				/// </java-name>
				[Dot42.DexImport("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetFileStreamPath(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Returns an array of strings naming the private files associated with this Context's application package.</para><para><para>openFileInput </para><simplesectsep></simplesectsep><para>openFileOutput </para><simplesectsep></simplesectsep><para>deleteFile </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Array of strings naming the private files.</para>
				/// </returns>
				/// <java-name>
				/// fileList
				/// </java-name>
				[Dot42.DexImport("fileList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] FileList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the absolute path to the directory on the filesystem where files created with openFileOutput are stored.</para><para><para>openFileOutput </para><simplesectsep></simplesectsep><para>getFileStreamPath </para><simplesectsep></simplesectsep><para>getDir </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the path of the directory holding application files.</para>
				/// </returns>
				/// <java-name>
				/// getFilesDir
				/// </java-name>
				[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetFilesDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Returns the absolute path to the directory on the external filesystem (that is somewhere on Environment.getExternalStorageDirectory()) where the application can place persistent files it owns. These files are private to the applications, and not typically visible to the user as media.</para><para>This is like getFilesDir() in that these files will be deleted when the application is uninstalled, however there are some important differences:</para><para><ul><li><para>External files are not always available: they will disappear if the user mounts the external storage on a computer or removes it. See the APIs on android.os.Environment for information in the storage state. </para></li><li><para>There is no security enforced with these files. All applications can read and write files placed here. </para></li></ul></para><para>On devices with multiple users (as described by UserManager), each user has their own isolated external storage. Applications only have access to the external storage for the user they're running as.</para><para>Here is an example of typical code to manipulate a file in an application's private storage:</para><para>{ development/samples/ApiDemos/src/com/example/android/apis/content/ExternalStorage.java private_file}</para><para>If you supply a non-null <b>type</b> to this function, the returned file will be a path to a sub-directory of the given type. Though these files are not automatically scanned by the media scanner, you can explicitly add them to the media database with String[], String[], OnScanCompletedListener) MediaScannerConnection.scanFile. Note that this is not the same as Environment.getExternalStoragePublicDirectory(), which provides directories of media shared by all applications. The directories returned here are owned by the application, and their contents will be removed when the application is uninstalled. Unlike Environment.getExternalStoragePublicDirectory(), the directory returned here will be automatically created for you.</para><para>Here is an example of typical code to manipulate a picture in an application's private storage and add it to the media database:</para><para>{ development/samples/ApiDemos/src/com/example/android/apis/content/ExternalStorage.java private_picture}</para><para>Writing to this path requires the android.Manifest.permission#WRITE_EXTERNAL_STORAGE permission.</para><para><para>getFilesDir </para><simplesectsep></simplesectsep><para>android.os.Environment::getExternalStoragePublicDirectory </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the path of the directory holding application files on external storage. Returns null if external storage is not currently mounted so it could not ensure the path exists; you will need to call this method again when it is available.</para>
				/// </returns>
				/// <java-name>
				/// getExternalFilesDir
				/// </java-name>
				[Dot42.DexImport("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetExternalFilesDir(string type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Return the directory where this application's OBB files (if there are any) can be found. Note if the application does not have any OBB files, this directory may not exist.</para><para>On devices with multiple users (as described by UserManager), multiple users may share the same OBB storage location. Applications should ensure that multiple instances running under different users don't interfere with each other.</para>        
				/// </summary>
				/// <java-name>
				/// getObbDir
				/// </java-name>
				[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetObbDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Returns the absolute path to the application specific cache directory on the filesystem. These files will be ones that get deleted first when the device runs low on storage. There is no guarantee when these files will be deleted.</para><para><b>Note: you should not <b>rely</b> on the system deleting these files for you; you should always have a reasonable maximum, such as 1 MB, for the amount of space you consume with cache files, and prune those files when exceeding that space.</b></para><para><para>openFileOutput </para><simplesectsep></simplesectsep><para>getFileStreamPath </para><simplesectsep></simplesectsep><para>getDir </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the path of the directory holding application cache files.</para>
				/// </returns>
				/// <java-name>
				/// getCacheDir
				/// </java-name>
				[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetCacheDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Returns the absolute path to the directory on the external filesystem (that is somewhere on Environment.getExternalStorageDirectory() where the application can place cache files it owns.</para><para>This is like getCacheDir() in that these files will be deleted when the application is uninstalled, however there are some important differences:</para><para><ul><li><para>The platform does not always monitor the space available in external storage, and thus may not automatically delete these files. Currently the only time files here will be deleted by the platform is when running on android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 or later and Environment.isExternalStorageEmulated() returns true. Note that you should be managing the maximum space you will use for these anyway, just like with getCacheDir(). </para></li><li><para>External files are not always available: they will disappear if the user mounts the external storage on a computer or removes it. See the APIs on android.os.Environment for information in the storage state. </para></li><li><para>There is no security enforced with these files. All applications can read and write files placed here. </para></li></ul></para><para>On devices with multiple users (as described by UserManager), each user has their own isolated external storage. Applications only have access to the external storage for the user they're running as.</para><para>Writing to this path requires the android.Manifest.permission#WRITE_EXTERNAL_STORAGE permission.</para><para><para>getCacheDir </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the path of the directory holding application cache files on external storage. Returns null if external storage is not currently mounted so it could not ensure the path exists; you will need to call this method again when it is available.</para>
				/// </returns>
				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetExternalCacheDir() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Retrieve, creating if needed, a new directory in which the application can place its own custom data files. You can use the returned File object to create and access files in this directory. Note that files created through a File object will only be accessible by your own application; you can only set the mode of the entire directory, not of individual files.</para><para><para>openFileOutput(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a File object for the requested directory. The directory will have been created if it does not already exist.</para>
				/// </returns>
				/// <java-name>
				/// getDir
				/// </java-name>
				[Dot42.DexImport("getDir", "(Ljava/lang/String;I)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetDir(string name, int mode) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Open a new private SQLiteDatabase associated with this Context's application package. Create the database file if it doesn't exist.</para><para><para>MODE_PRIVATE </para><simplesectsep></simplesectsep><para>MODE_WORLD_READABLE </para><simplesectsep></simplesectsep><para>MODE_WORLD_WRITEABLE </para><simplesectsep></simplesectsep><para>MODE_ENABLE_WRITE_AHEAD_LOGGING </para><simplesectsep></simplesectsep><para>deleteDatabase </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The contents of a newly created database with the given name. </para>
				/// </returns>
				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landro" +
    "id/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Open a new private SQLiteDatabase associated with this Context's application package. Creates the database file if it doesn't exist.</para><para>Accepts input param: a concrete instance of DatabaseErrorHandler to be used to handle corruption when sqlite reports database corruption.</para><para><para>MODE_PRIVATE </para><simplesectsep></simplesectsep><para>MODE_WORLD_READABLE </para><simplesectsep></simplesectsep><para>MODE_WORLD_WRITEABLE </para><simplesectsep></simplesectsep><para>MODE_ENABLE_WRITE_AHEAD_LOGGING </para><simplesectsep></simplesectsep><para>deleteDatabase </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The contents of a newly created database with the given name. </para>
				/// </returns>
				/// <java-name>
				/// openOrCreateDatabase
				/// </java-name>
				[Dot42.DexImport("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroi" +
    "d/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", AccessFlags = 1)]
				public override global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase(string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, global::Android.Database.IDatabaseErrorHandler errorHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.Sqlite.SQLiteDatabase);
				}

				/// <summary>
				/// <para>Returns the absolute path on the filesystem where a database created with openOrCreateDatabase is stored.</para><para><para>openOrCreateDatabase </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an absolute path to the given database.</para>
				/// </returns>
				/// <java-name>
				/// getDatabasePath
				/// </java-name>
				[Dot42.DexImport("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", AccessFlags = 1)]
				public override global::Java.Io.File GetDatabasePath(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.File);
				}

				/// <summary>
				/// <para>Returns an array of strings naming the private databases associated with this Context's application package.</para><para><para>openOrCreateDatabase </para><simplesectsep></simplesectsep><para>deleteDatabase </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Array of strings naming the private databases.</para>
				/// </returns>
				/// <java-name>
				/// databaseList
				/// </java-name>
				[Dot42.DexImport("databaseList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] DatabaseList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Delete an existing private SQLiteDatabase associated with this Context's application package.</para><para><para>openOrCreateDatabase </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the database was successfully deleted; else false.</para>
				/// </returns>
				/// <java-name>
				/// deleteDatabase
				/// </java-name>
				[Dot42.DexImport("deleteDatabase", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool DeleteDatabase(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.get() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaper
				/// </java-name>
				[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetWallpaper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.peek() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// peekWallpaper
				/// </java-name>
				[Dot42.DexImport("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable PeekWallpaper() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.getDesiredMinimumWidth() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1)]
				public override int GetWallpaperDesiredMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.getDesiredMinimumHeight() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1)]
				public override int GetWallpaperDesiredMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.set() instead. </para></xrefdescription></xrefsect></para><para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER. </para>        
				/// </summary>
				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public override void SetWallpaper(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.set() instead. </para></xrefdescription></xrefsect></para><para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER. </para>        
				/// </summary>
				/// <java-name>
				/// setWallpaper
				/// </java-name>
				[Dot42.DexImport("setWallpaper", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public override void SetWallpaper(global::Java.Io.InputStream bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.clear() instead. </para></xrefdescription></xrefsect></para><para>This method requires the caller to hold the permission android.Manifest.permission#SET_WALLPAPER. </para>        
				/// </summary>
				/// <java-name>
				/// clearWallpaper
				/// </java-name>
				[Dot42.DexImport("clearWallpaper", "()V", AccessFlags = 1)]
				public override void ClearWallpaper() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Same as startActivity(Intent, Bundle) with no options specified.</para><para><para>startActivity(Intent, Bundle) </para><simplesectsep></simplesectsep><para>PackageManager::resolveActivity </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivity
				/// </java-name>
				[Dot42.DexImport("startActivity", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void StartActivity(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Same as startActivities(Intent[], Bundle) with no options specified.</para><para><para>startActivities(Intent[], Bundle) </para><simplesectsep></simplesectsep><para>PackageManager::resolveActivity </para></para>        
				/// </summary>
				/// <java-name>
				/// startActivities
				/// </java-name>
				[Dot42.DexImport("startActivities", "([Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void StartActivities(global::Android.Content.Intent[] intents) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Same as startIntentSender(IntentSender, Intent, int, int, int, Bundle) with no options specified.</para><para><para>startActivity(Intent) </para><simplesectsep></simplesectsep><para>startIntentSender(IntentSender, Intent, int, int, int, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// startIntentSender
				/// </java-name>
				[Dot42.DexImport("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", AccessFlags = 1)]
				public override void StartIntentSender(global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Broadcast the given intent to all interested BroadcastReceivers. This call is asynchronous; it returns immediately, and you will continue executing while the receivers are run. No results are propagated from receivers and receivers can not abort the broadcast. If you want to allow receivers to propagate results or abort the broadcast, you must send an ordered broadcast using sendOrderedBroadcast(Intent, String).</para><para>See BroadcastReceiver for more information on Intent broadcasts.</para><para><para>android.content.BroadcastReceiver </para><simplesectsep></simplesectsep><para>registerReceiver </para><simplesectsep></simplesectsep><para>sendBroadcast(Intent, String) </para><simplesectsep></simplesectsep><para>sendOrderedBroadcast(Intent, String) </para><simplesectsep></simplesectsep><para>sendOrderedBroadcast(Intent, String, BroadcastReceiver, Handler, int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SendBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Broadcast the given intent to all interested BroadcastReceivers, allowing an optional required permission to be enforced. This call is asynchronous; it returns immediately, and you will continue executing while the receivers are run. No results are propagated from receivers and receivers can not abort the broadcast. If you want to allow receivers to propagate results or abort the broadcast, you must send an ordered broadcast using sendOrderedBroadcast(Intent, String).</para><para>See BroadcastReceiver for more information on Intent broadcasts.</para><para><para>android.content.BroadcastReceiver </para><simplesectsep></simplesectsep><para>registerReceiver </para><simplesectsep></simplesectsep><para>sendBroadcast(Intent) </para><simplesectsep></simplesectsep><para>sendOrderedBroadcast(Intent, String) </para><simplesectsep></simplesectsep><para>sendOrderedBroadcast(Intent, String, BroadcastReceiver, Handler, int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendBroadcast
				/// </java-name>
				[Dot42.DexImport("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Broadcast the given intent to all interested BroadcastReceivers, delivering them one at a time to allow more preferred receivers to consume the broadcast before it is delivered to less preferred receivers. This call is asynchronous; it returns immediately, and you will continue executing while the receivers are run.</para><para>See BroadcastReceiver for more information on Intent broadcasts.</para><para><para>android.content.BroadcastReceiver </para><simplesectsep></simplesectsep><para>registerReceiver </para><simplesectsep></simplesectsep><para>sendBroadcast(Intent) </para><simplesectsep></simplesectsep><para>sendOrderedBroadcast(Intent, String, BroadcastReceiver, Handler, int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Version of sendBroadcast(Intent) that allows you to receive data back from the broadcast. This is accomplished by supplying your own BroadcastReceiver when calling, which will be treated as a final receiver at the end of the broadcast  its BroadcastReceiver#onReceive method will be called with the result values collected from the other receivers. The broadcast will be serialized in the same way as calling sendOrderedBroadcast(Intent, String).</para><para>Like sendBroadcast(Intent), this method is asynchronous; it will return before resultReceiver.onReceive() is called.</para><para>See BroadcastReceiver for more information on Intent broadcasts.</para><para><para>sendBroadcast(Intent) </para><simplesectsep></simplesectsep><para>sendBroadcast(Intent, String) </para><simplesectsep></simplesectsep><para>sendOrderedBroadcast(Intent, String) </para><simplesectsep></simplesectsep><para>sendStickyBroadcast(Intent) </para><simplesectsep></simplesectsep><para>sendStickyOrderedBroadcast(Intent, BroadcastReceiver, Handler, int, String, Bundle) </para><simplesectsep></simplesectsep><para>android.content.BroadcastReceiver </para><simplesectsep></simplesectsep><para>registerReceiver </para><simplesectsep></simplesectsep><para>android.app.Activity::RESULT_OK </para></para>        
				/// </summary>
				/// <java-name>
				/// sendOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Lan" +
    "droid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void SendOrderedBroadcast(global::Android.Content.Intent intent, string receiverPermission, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.Os.Handler scheduler, int initialCode, string initialData, global::Android.Os.Bundle initialExtras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Perform a sendBroadcast(Intent) that is "sticky," meaning the Intent you are sending stays around after the broadcast is complete, so that others can quickly retrieve that data through the return value of registerReceiver(BroadcastReceiver, IntentFilter). In all other ways, this behaves the same as sendBroadcast(Intent).</para><para>You must hold the android.Manifest.permission#BROADCAST_STICKY permission in order to use this API. If you do not hold that permission, SecurityException will be thrown.</para><para><para>sendBroadcast(Intent) </para><simplesectsep></simplesectsep><para>sendStickyOrderedBroadcast(Intent, BroadcastReceiver, Handler, int, String, Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SendStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Version of sendStickyBroadcast that allows you to receive data back from the broadcast. This is accomplished by supplying your own BroadcastReceiver when calling, which will be treated as a final receiver at the end of the broadcast  its BroadcastReceiver#onReceive method will be called with the result values collected from the other receivers. The broadcast will be serialized in the same way as calling sendOrderedBroadcast(Intent, String).</para><para>Like sendBroadcast(Intent), this method is asynchronous; it will return before resultReceiver.onReceive() is called. Note that the sticky data stored is only the data you initially supply to the broadcast, not the result of any changes made by the receivers.</para><para>See BroadcastReceiver for more information on Intent broadcasts.</para><para><para>sendBroadcast(Intent) </para><simplesectsep></simplesectsep><para>sendBroadcast(Intent, String) </para><simplesectsep></simplesectsep><para>sendOrderedBroadcast(Intent, String) </para><simplesectsep></simplesectsep><para>sendStickyBroadcast(Intent) </para><simplesectsep></simplesectsep><para>android.content.BroadcastReceiver </para><simplesectsep></simplesectsep><para>registerReceiver </para><simplesectsep></simplesectsep><para>android.app.Activity::RESULT_OK </para></para>        
				/// </summary>
				/// <java-name>
				/// sendStickyOrderedBroadcast
				/// </java-name>
				[Dot42.DexImport("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;I" +
    "Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void SendStickyOrderedBroadcast(global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.Os.Handler scheduler, int initialCode, string initialData, global::Android.Os.Bundle initialExtras) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove the data previously sent with sendStickyBroadcast, so that it is as if the sticky broadcast had never happened.</para><para>You must hold the android.Manifest.permission#BROADCAST_STICKY permission in order to use this API. If you do not hold that permission, SecurityException will be thrown.</para><para><para>sendStickyBroadcast </para></para>        
				/// </summary>
				/// <java-name>
				/// removeStickyBroadcast
				/// </java-name>
				[Dot42.DexImport("removeStickyBroadcast", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void RemoveStickyBroadcast(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register a BroadcastReceiver to be run in the main activity thread. The <b>receiver</b> will be called with any broadcast Intent that matches <b>filter</b>, in the main application thread.</para><para>The system may broadcast Intents that are "sticky"  these stay around after the broadcast as finished, to be sent to any later registrations. If your IntentFilter matches one of these sticky Intents, that Intent will be returned by this function <b>and</b> sent to your <b>receiver</b> as if it had just been broadcast.</para><para>There may be multiple sticky Intents that match <b>filter</b>, in which case each of these will be sent to <b>receiver</b>. In this case, only one of these can be returned directly by the function; which of these that is returned is arbitrarily decided by the system.</para><para>If you know the Intent your are registering for is sticky, you can supply null for your <b>receiver</b>. In this case, no receiver is registered  the function simply returns the sticky Intent that matches <b>filter</b>. In the case of multiple matches, the same rules as described above apply.</para><para>See BroadcastReceiver for more information on Intent broadcasts.</para><para>As of android.os.Build.VERSION_CODES#ICE_CREAM_SANDWICH, receivers registered with this method will correctly respect the Intent#setPackage(String) specified for an Intent being broadcast. Prior to that, it would be ignored and delivered to all matching registered receivers. Be careful if using this for security.</para><para>Note: this method <b>cannot be called from a BroadcastReceiver component;</b> that is, from a BroadcastReceiver that is declared in an application's manifest. It is okay, however, to call this method from another BroadcastReceiver that has itself been registered at run time with registerReceiver, since the lifetime of such a registered BroadcastReceiver is tied to the object that registered it.</para><para><para>registerReceiver(BroadcastReceiver, IntentFilter, String, Handler) </para><simplesectsep></simplesectsep><para>sendBroadcast </para><simplesectsep></simplesectsep><para>unregisterReceiver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The first sticky intent found that matches <b>filter</b>, or null if there are none.</para>
				/// </returns>
				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/conte" +
    "nt/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				/// <para>Register to receive intent broadcasts, to run in the context of <b>scheduler</b>. See registerReceiver(BroadcastReceiver, IntentFilter) for more information. This allows you to enforce permissions on who can broadcast intents to your receiver, or have the receiver run in a different thread than the main application thread.</para><para>See BroadcastReceiver for more information on Intent broadcasts.</para><para>As of android.os.Build.VERSION_CODES#ICE_CREAM_SANDWICH, receivers registered with this method will correctly respect the Intent#setPackage(String) specified for an Intent being broadcast. Prior to that, it would be ignored and delivered to all matching registered receivers. Be careful if using this for security.</para><para><para>registerReceiver(BroadcastReceiver, IntentFilter) </para><simplesectsep></simplesectsep><para>sendBroadcast </para><simplesectsep></simplesectsep><para>unregisterReceiver </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The first sticky intent found that matches <b>filter</b>, or null if there are none.</para>
				/// </returns>
				/// <java-name>
				/// registerReceiver
				/// </java-name>
				[Dot42.DexImport("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/Stri" +
    "ng;Landroid/os/Handler;)Landroid/content/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent RegisterReceiver(global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter, string broadcastPermission, global::Android.Os.Handler scheduler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				/// <para>Unregister a previously registered BroadcastReceiver. <b>All</b> filters that have been registered for this BroadcastReceiver will be removed.</para><para><para>registerReceiver </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterReceiver
				/// </java-name>
				[Dot42.DexImport("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", AccessFlags = 1)]
				public override void UnregisterReceiver(global::Android.Content.BroadcastReceiver receiver) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Request that a given application service be started. The Intent can either contain the complete class name of a specific service implementation to start, or an abstract definition through the action and other fields of the kind of service to start. If this service is not already running, it will be instantiated and started (creating a process for it if needed); if it is running then it remains running.</para><para>Every call to this method will result in a corresponding call to the target service's android.app.Service#onStartCommand method, with the <b>intent</b> given here. This provides a convenient way to submit jobs to a service without having to bind and call on to its interface.</para><para>Using startService() overrides the default service lifetime that is managed by bindService: it requires the service to remain running until stopService is called, regardless of whether any clients are connected to it. Note that calls to startService() are not nesting: no matter how many times you call startService(), a single call to stopService will stop it.</para><para>The system attempts to keep running services around as much as possible. The only time they should be stopped is if the current foreground application is using so many resources that the service needs to be killed. If any errors happen in the service's process, it will automatically be restarted.</para><para>This function will throw SecurityException if you do not have permission to start the given service.</para><para><para>stopService </para><simplesectsep></simplesectsep><para>bindService </para></para>        
				/// </summary>
				/// <returns>
				/// <para>If the service is being started or is already running, the ComponentName of the actual service that was started is returned; else if the service does not exist null is returned.</para>
				/// </returns>
				/// <java-name>
				/// startService
				/// </java-name>
				[Dot42.DexImport("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", AccessFlags = 1)]
				public override global::Android.Content.ComponentName StartService(global::Android.Content.Intent service) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <summary>
				/// <para>Request that a given application service be stopped. If the service is not running, nothing happens. Otherwise it is stopped. Note that calls to startService() are not counted  this stops the service no matter how many times it was started.</para><para>Note that if a stopped service still has ServiceConnection objects bound to it with the BIND_AUTO_CREATE set, it will not be destroyed until all of these bindings are removed. See the android.app.Service documentation for more details on a service's lifecycle.</para><para>This function will throw SecurityException if you do not have permission to stop the given service.</para><para><para>startService </para></para>        
				/// </summary>
				/// <returns>
				/// <para>If there is a service matching the given Intent that is already running, then it is stopped and true is returned; else false is returned.</para>
				/// </returns>
				/// <java-name>
				/// stopService
				/// </java-name>
				[Dot42.DexImport("stopService", "(Landroid/content/Intent;)Z", AccessFlags = 1)]
				public override bool StopService(global::Android.Content.Intent service) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Connect to an application service, creating it if needed. This defines a dependency between your application and the service. The given <b>conn</b> will receive the service object when it is created and be told if it dies and restarts. The service will be considered required by the system only for as long as the calling context exists. For example, if this Context is an Activity that is stopped, the service will not be required to continue running until the Activity is resumed.</para><para>This function will throw SecurityException if you do not have permission to bind to the given service.</para><para>Note: this method <b>can not be called from a BroadcastReceiver component</b>. A pattern you can use to communicate from a BroadcastReceiver to a Service is to call startService with the arguments containing the command to be sent, with the service calling its android.app.Service#stopSelf(int) method when done executing that command. See the API demo App/Service/Service Start Arguments Controller for an illustration of this. It is okay, however, to use this method from a BroadcastReceiver that has been registered with registerReceiver, since the lifetime of this BroadcastReceiver is tied to another object (the one that registered it).</para><para><para>unbindService </para><simplesectsep></simplesectsep><para>startService </para><simplesectsep></simplesectsep><para>BIND_AUTO_CREATE </para><simplesectsep></simplesectsep><para>BIND_DEBUG_UNBIND </para><simplesectsep></simplesectsep><para>BIND_NOT_FOREGROUND </para></para>        
				/// </summary>
				/// <returns>
				/// <para>If you have successfully bound to the service, true is returned; false is returned if the connection is not made so you will not receive the service object.</para>
				/// </returns>
				/// <java-name>
				/// bindService
				/// </java-name>
				[Dot42.DexImport("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", AccessFlags = 1)]
				public override bool BindService(global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Disconnect from an application service. You will no longer receive calls as the service is restarted, and the service is now allowed to stop at any time.</para><para><para>bindService </para></para>        
				/// </summary>
				/// <java-name>
				/// unbindService
				/// </java-name>
				[Dot42.DexImport("unbindService", "(Landroid/content/ServiceConnection;)V", AccessFlags = 1)]
				public override void UnbindService(global::Android.Content.IServiceConnection conn) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Start executing an android.app.Instrumentation class. The given Instrumentation component will be run by killing its target application (if currently running), starting the target process, instantiating the instrumentation component, and then letting it drive the application.</para><para>This function is not synchronous  it returns as soon as the instrumentation has started and while it is running.</para><para>Instrumentation is normally only allowed to run against a package that is either unsigned or signed with a signature that the the instrumentation package is also signed with (ensuring the target trusts the instrumentation).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the instrumentation was successfully started, else false if it could not be found. </para>
				/// </returns>
				/// <java-name>
				/// startInstrumentation
				/// </java-name>
				[Dot42.DexImport("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public override bool StartInstrumentation(global::Android.Content.ComponentName className, string profileFile, global::Android.Os.Bundle arguments) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the handle to a system-level service by name. The class of the returned object varies by the requested name. Currently available names are:</para><para></para><para>Note: System services obtained via this API may be closely associated with the Context in which they are obtained from. In general, do not share the service objects between various different contexts (Activities, Applications, Services, Providers, etc.)</para><para><para>WINDOW_SERVICE </para><simplesectsep></simplesectsep><para>android.view.WindowManager </para><simplesectsep></simplesectsep><para>LAYOUT_INFLATER_SERVICE </para><simplesectsep></simplesectsep><para>android.view.LayoutInflater </para><simplesectsep></simplesectsep><para>ACTIVITY_SERVICE </para><simplesectsep></simplesectsep><para>android.app.ActivityManager </para><simplesectsep></simplesectsep><para>POWER_SERVICE </para><simplesectsep></simplesectsep><para>android.os.PowerManager </para><simplesectsep></simplesectsep><para>ALARM_SERVICE </para><simplesectsep></simplesectsep><para>android.app.AlarmManager </para><simplesectsep></simplesectsep><para>NOTIFICATION_SERVICE </para><simplesectsep></simplesectsep><para>android.app.NotificationManager </para><simplesectsep></simplesectsep><para>KEYGUARD_SERVICE </para><simplesectsep></simplesectsep><para>android.app.KeyguardManager </para><simplesectsep></simplesectsep><para>LOCATION_SERVICE </para><simplesectsep></simplesectsep><para>android.location.LocationManager </para><simplesectsep></simplesectsep><para>SEARCH_SERVICE </para><simplesectsep></simplesectsep><para>android.app.SearchManager </para><simplesectsep></simplesectsep><para>SENSOR_SERVICE </para><simplesectsep></simplesectsep><para>android.hardware.SensorManager </para><simplesectsep></simplesectsep><para>STORAGE_SERVICE </para><simplesectsep></simplesectsep><para>android.os.storage.StorageManager </para><simplesectsep></simplesectsep><para>VIBRATOR_SERVICE </para><simplesectsep></simplesectsep><para>android.os.Vibrator </para><simplesectsep></simplesectsep><para>CONNECTIVITY_SERVICE </para><simplesectsep></simplesectsep><para>android.net.ConnectivityManager </para><simplesectsep></simplesectsep><para>WIFI_SERVICE </para><simplesectsep></simplesectsep><para>android.net.wifi.WifiManager </para><simplesectsep></simplesectsep><para>AUDIO_SERVICE </para><simplesectsep></simplesectsep><para>android.media.AudioManager </para><simplesectsep></simplesectsep><para>MEDIA_ROUTER_SERVICE </para><simplesectsep></simplesectsep><para>android.media.MediaRouter </para><simplesectsep></simplesectsep><para>TELEPHONY_SERVICE </para><simplesectsep></simplesectsep><para>android.telephony.TelephonyManager </para><simplesectsep></simplesectsep><para>INPUT_METHOD_SERVICE </para><simplesectsep></simplesectsep><para>android.view.inputmethod.InputMethodManager </para><simplesectsep></simplesectsep><para>UI_MODE_SERVICE </para><simplesectsep></simplesectsep><para>android.app.UiModeManager </para><simplesectsep></simplesectsep><para>DOWNLOAD_SERVICE </para><simplesectsep></simplesectsep><para>android.app.DownloadManager </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The service or null if the name does not exist.</para>
				/// </returns>
				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Determine whether the given permission is allowed for a particular process and user ID running in the system.</para><para><para>PackageManager::checkPermission(String, String) </para><simplesectsep></simplesectsep><para>checkCallingPermission </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns PackageManager#PERMISSION_GRANTED if the given pid/uid is allowed that permission, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;II)I", AccessFlags = 1)]
				public override int CheckPermission(string permission, int pid, int uid) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determine whether the calling process of an IPC you are handling has been granted a particular permission. This is basically the same as calling checkPermission(String, int, int) with the pid and uid returned by android.os.Binder#getCallingPid and android.os.Binder#getCallingUid. One important difference is that if you are not currently processing an IPC, this function will always fail. This is done to protect against accidentally leaking permissions; you can use checkCallingOrSelfPermission to avoid this protection.</para><para><para>PackageManager::checkPermission(String, String) </para><simplesectsep></simplesectsep><para>checkPermission </para><simplesectsep></simplesectsep><para>checkCallingOrSelfPermission </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns PackageManager#PERMISSION_GRANTED if the calling pid/uid is allowed that permission, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkCallingPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingPermission(string permission) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determine whether the calling process of an IPC <b>or you</b> have been granted a particular permission. This is the same as checkCallingPermission, except it grants your own permissions if you are not currently processing an IPC. Use with care!</para><para><para>PackageManager::checkPermission(String, String) </para><simplesectsep></simplesectsep><para>checkPermission </para><simplesectsep></simplesectsep><para>checkCallingPermission </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns PackageManager#PERMISSION_GRANTED if the calling pid/uid is allowed that permission, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfPermission(string permission) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>If the given permission is not allowed for a particular process and user ID running in the system, throw a SecurityException.</para><para><para>checkPermission(String, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforcePermission
				/// </java-name>
				[Dot42.DexImport("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforcePermission(string permission, int pid, int uid, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If the calling process of an IPC you are handling has not been granted a particular permission, throw a SecurityException. This is basically the same as calling enforcePermission(String, int, int, String) with the pid and uid returned by android.os.Binder#getCallingPid and android.os.Binder#getCallingUid. One important difference is that if you are not currently processing an IPC, this function will always throw the SecurityException. This is done to protect against accidentally leaking permissions; you can use enforceCallingOrSelfPermission to avoid this protection.</para><para><para>checkCallingPermission(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceCallingPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingPermission(string permission, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If neither you nor the calling process of an IPC you are handling has been granted a particular permission, throw a SecurityException. This is the same as enforceCallingPermission, except it grants your own permissions if you are not currently processing an IPC. Use with care!</para><para><para>checkCallingOrSelfPermission(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceCallingOrSelfPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfPermission(string permission, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Grant permission to access a specific Uri to another package, regardless of whether that package has general permission to access the Uri's content provider. This can be used to grant specific, temporary permissions, typically in response to user interaction (such as the user opening an attachment that you would like someone else to display).</para><para>Normally you should use Intent.FLAG_GRANT_READ_URI_PERMISSION or Intent.FLAG_GRANT_WRITE_URI_PERMISSION with the Intent being used to start an activity instead of this function directly. If you use this function directly, you should be sure to call revokeUriPermission when the target should no longer be allowed to access it.</para><para>To succeed, the content provider owning the Uri must have set the grantUriPermissions attribute in its manifest or included the &lt;grant-uri-permissions&gt; tag.</para><para><para>revokeUriPermission </para></para>        
				/// </summary>
				/// <java-name>
				/// grantUriPermission
				/// </java-name>
				[Dot42.DexImport("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void GrantUriPermission(string toPackage, global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove all permissions to access a particular content provider Uri that were previously added with grantUriPermission. The given Uri will match all previously granted Uris that are the same or a sub-path of the given Uri. That is, revoking "content://foo/one" will revoke both "content://foo/target" and "content://foo/target/sub", but not "content://foo".</para><para><para>grantUriPermission </para></para>        
				/// </summary>
				/// <java-name>
				/// revokeUriPermission
				/// </java-name>
				[Dot42.DexImport("revokeUriPermission", "(Landroid/net/Uri;I)V", AccessFlags = 1)]
				public override void RevokeUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Determine whether a particular process and user ID has been granted permission to access a specific URI. This only checks for permissions that have been explicitly granted  if the given process/uid has more general access to the URI's content provider then this check will always fail.</para><para><para>checkCallingUriPermission </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns PackageManager#PERMISSION_GRANTED if the given pid/uid is allowed to access that uri, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determine whether the calling process and user ID has been granted permission to access a specific URI. This is basically the same as calling int, int, int) with the pid and uid returned by android.os.Binder#getCallingPid and android.os.Binder#getCallingUid. One important difference is that if you are not currently processing an IPC, this function will always fail.</para><para><para>checkUriPermission(Uri, int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns PackageManager#PERMISSION_GRANTED if the caller is allowed to access that uri, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determine whether the calling process of an IPC <b>or you</b> has been granted permission to access a specific URI. This is the same as checkCallingUriPermission, except it grants your own permissions if you are not currently processing an IPC. Use with care!</para><para><para>checkCallingUriPermission </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns PackageManager#PERMISSION_GRANTED if the caller is allowed to access that uri, or PackageManager#PERMISSION_DENIED if it is not.</para>
				/// </returns>
				/// <java-name>
				/// checkCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", AccessFlags = 1)]
				public override int CheckCallingOrSelfUriPermission(global::Android.Net.Uri uri, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Check both a Uri and normal permission. This allows you to perform both checkPermission and checkUriPermission in one call.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns PackageManager#PERMISSION_GRANTED if the caller is allowed to access that uri or holds one of the given permissions, or PackageManager#PERMISSION_DENIED if it is not. </para>
				/// </returns>
				/// <java-name>
				/// checkUriPermission
				/// </java-name>
				[Dot42.DexImport("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", AccessFlags = 1)]
				public override int CheckUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>If a particular process and user ID has not been granted permission to access a specific URI, throw SecurityException. This only checks for permissions that have been explicitly granted  if the given process/uid has more general access to the URI's content provider then this check will always fail.</para><para><para>checkUriPermission(Uri, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, int pid, int uid, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If the calling process and user ID has not been granted permission to access a specific URI, throw SecurityException. This is basically the same as calling enforceUriPermission(Uri, int, int, int, String) with the pid and uid returned by android.os.Binder#getCallingPid and android.os.Binder#getCallingUid. One important difference is that if you are not currently processing an IPC, this function will always throw a SecurityException.</para><para><para>checkCallingUriPermission(Uri, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceCallingUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingUriPermission(global::Android.Net.Uri uri, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If the calling process of an IPC <b>or you</b> has not been granted permission to access a specific URI, throw SecurityException. This is the same as enforceCallingUriPermission, except it grants your own permissions if you are not currently processing an IPC. Use with care!</para><para><para>checkCallingOrSelfUriPermission(Uri, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceCallingOrSelfUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceCallingOrSelfUriPermission(global::Android.Net.Uri uri, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Enforce both a Uri and normal permission. This allows you to perform both enforcePermission and enforceUriPermission in one call.</para><para><para>checkUriPermission(Uri, String, String, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// enforceUriPermission
				/// </java-name>
				[Dot42.DexImport("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", AccessFlags = 1)]
				public override void EnforceUriPermission(global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags, string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a new Context object for the given application name. This Context is the same as what the named application gets when it is launched, containing the same resources and class loader. Each call to this method returns a new instance of a Context object; Context objects are not shared, however they share common state (Resources, ClassLoader, etc) so the Context instance itself is fairly lightweight.</para><para>Throws PackageManager.NameNotFoundException if there is no application with the given package name.</para><para>Throws java.lang.SecurityException if the Context requested can not be loaded into the caller's process for security reasons (see CONTEXT_INCLUDE_CODE for more information}.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Context for the application.</para>
				/// </returns>
				/// <java-name>
				/// createPackageContext
				/// </java-name>
				[Dot42.DexImport("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", AccessFlags = 1)]
				public override global::Android.Content.Context CreatePackageContext(string packageName, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <summary>
				/// <para>Indicates whether this Context is restricted.</para><para><para>CONTEXT_RESTRICTED </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this Context is restricted, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isRestricted
				/// </java-name>
				[Dot42.DexImport("isRestricted", "()Z", AccessFlags = 1)]
				public override bool IsRestricted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return an AssetManager instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getAssets
				/// </java-name>
				public global::Android.Content.Res.AssetManager Assets
				{
				[Dot42.DexImport("getAssets", "()Landroid/content/res/AssetManager;", AccessFlags = 1)]
						get{ return GetAssets(); }
				}

				/// <summary>
				/// <para>Return a Resources instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getResources
				/// </java-name>
				public global::Android.Content.Res.Resources Resources
				{
				[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return GetResources(); }
				}

				/// <summary>
				/// <para>Return PackageManager instance to find global package information. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageManager
				/// </java-name>
				public global::Android.Content.Pm.PackageManager PackageManager
				{
				[Dot42.DexImport("getPackageManager", "()Landroid/content/pm/PackageManager;", AccessFlags = 1)]
						get{ return GetPackageManager(); }
				}

				/// <summary>
				/// <para>Return a ContentResolver instance for your application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getContentResolver
				/// </java-name>
				public global::Android.Content.ContentResolver ContentResolver
				{
				[Dot42.DexImport("getContentResolver", "()Landroid/content/ContentResolver;", AccessFlags = 1)]
						get{ return GetContentResolver(); }
				}

				/// <summary>
				/// <para>Return the Looper for the main thread of the current process. This is the thread used to dispatch calls to application components (activities, services, etc). </para><para>By definition, this method returns the same result as would be obtained by calling Looper.getMainLooper(). </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The main looper. </para>
				/// </returns>
				/// <java-name>
				/// getMainLooper
				/// </java-name>
				public global::Android.Os.Looper MainLooper
				{
				[Dot42.DexImport("getMainLooper", "()Landroid/os/Looper;", AccessFlags = 1)]
						get{ return GetMainLooper(); }
				}

				/// <summary>
				/// <para>Return the context of the single, global Application object of the current process. This generally should only be used if you need a Context whose lifecycle is separate from the current context, that is tied to the lifetime of the process rather than the current component.</para><para>Consider for example how this interacts with registerReceiver(BroadcastReceiver, IntentFilter): <ul><li><para></para><para>If used from an Activity context, the receiver is being registered within that activity. This means that you are expected to unregister before the activity is done being destroyed; in fact if you do not do so, the framework will clean up your leaked registration as it removes the activity and log an error. Thus, if you use the Activity context to register a receiver that is static (global to the process, not associated with an Activity instance) then that registration will be removed on you at whatever point the activity you used is destroyed. </para></li><li><para></para><para>If used from the Context returned here, the receiver is being registered with the global state associated with your application. Thus it will never be unregistered for you. This is necessary if the receiver is associated with static data, not a particular component. However using the ApplicationContext elsewhere can easily lead to serious leaks if you forget to unregister, unbind, etc. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// getApplicationContext
				/// </java-name>
				public global::Android.Content.Context ApplicationContext
				{
				[Dot42.DexImport("getApplicationContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return GetApplicationContext(); }
				}

				/// <summary>
				/// <para>Return the Theme object associated with this Context. </para>        
				/// </summary>
				/// <java-name>
				/// getTheme
				/// </java-name>
				public global::Android.Content.Res.Resources.Theme Theme
				{
				[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
						get{ return GetTheme(); }
				}

				/// <summary>
				/// <para>Return a class loader you can use to retrieve classes in this package. </para>        
				/// </summary>
				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public global::Java.Lang.ClassLoader ClassLoader
				{
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
						get{ return GetClassLoader(); }
				}

				/// <summary>
				/// <para>Return the name of this application's package. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				}

				/// <summary>
				/// <para>Return the full application info for this context's package. </para>        
				/// </summary>
				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				public global::Android.Content.Pm.ApplicationInfo ApplicationInfo
				{
				[Dot42.DexImport("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
						get{ return GetApplicationInfo(); }
				}

				/// <summary>
				/// <para>Return the full path to this context's primary Android package. The Android package is a ZIP file which contains the application's primary resources.</para><para>Note: this is not generally useful for applications, since they should not be directly accessing the file system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String Path to the resources. </para>
				/// </returns>
				/// <java-name>
				/// getPackageResourcePath
				/// </java-name>
				public string PackageResourcePath
				{
				[Dot42.DexImport("getPackageResourcePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageResourcePath(); }
				}

				/// <summary>
				/// <para>Return the full path to this context's primary Android package. The Android package is a ZIP file which contains application's primary code and assets.</para><para>Note: this is not generally useful for applications, since they should not be directly accessing the file system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String Path to the code and assets. </para>
				/// </returns>
				/// <java-name>
				/// getPackageCodePath
				/// </java-name>
				public string PackageCodePath
				{
				[Dot42.DexImport("getPackageCodePath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageCodePath(); }
				}

				/// <summary>
				/// <para>Returns the absolute path to the directory on the filesystem where files created with openFileOutput are stored.</para><para><para>openFileOutput </para><simplesectsep></simplesectsep><para>getFileStreamPath </para><simplesectsep></simplesectsep><para>getDir </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the path of the directory holding application files.</para>
				/// </returns>
				/// <java-name>
				/// getFilesDir
				/// </java-name>
				public global::Java.Io.File FilesDir
				{
				[Dot42.DexImport("getFilesDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetFilesDir(); }
				}

				/// <summary>
				/// <para>Return the directory where this application's OBB files (if there are any) can be found. Note if the application does not have any OBB files, this directory may not exist.</para><para>On devices with multiple users (as described by UserManager), multiple users may share the same OBB storage location. Applications should ensure that multiple instances running under different users don't interfere with each other.</para>        
				/// </summary>
				/// <java-name>
				/// getObbDir
				/// </java-name>
				public global::Java.Io.File ObbDir
				{
				[Dot42.DexImport("getObbDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetObbDir(); }
				}

				/// <summary>
				/// <para>Returns the absolute path to the application specific cache directory on the filesystem. These files will be ones that get deleted first when the device runs low on storage. There is no guarantee when these files will be deleted.</para><para><b>Note: you should not <b>rely</b> on the system deleting these files for you; you should always have a reasonable maximum, such as 1 MB, for the amount of space you consume with cache files, and prune those files when exceeding that space.</b></para><para><para>openFileOutput </para><simplesectsep></simplesectsep><para>getFileStreamPath </para><simplesectsep></simplesectsep><para>getDir </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the path of the directory holding application cache files.</para>
				/// </returns>
				/// <java-name>
				/// getCacheDir
				/// </java-name>
				public global::Java.Io.File CacheDir
				{
				[Dot42.DexImport("getCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetCacheDir(); }
				}

				/// <summary>
				/// <para>Returns the absolute path to the directory on the external filesystem (that is somewhere on Environment.getExternalStorageDirectory() where the application can place cache files it owns.</para><para>This is like getCacheDir() in that these files will be deleted when the application is uninstalled, however there are some important differences:</para><para><ul><li><para>The platform does not always monitor the space available in external storage, and thus may not automatically delete these files. Currently the only time files here will be deleted by the platform is when running on android.os.Build.VERSION_CODES#JELLY_BEAN_MR1 or later and Environment.isExternalStorageEmulated() returns true. Note that you should be managing the maximum space you will use for these anyway, just like with getCacheDir(). </para></li><li><para>External files are not always available: they will disappear if the user mounts the external storage on a computer or removes it. See the APIs on android.os.Environment for information in the storage state. </para></li><li><para>There is no security enforced with these files. All applications can read and write files placed here. </para></li></ul></para><para>On devices with multiple users (as described by UserManager), each user has their own isolated external storage. Applications only have access to the external storage for the user they're running as.</para><para>Writing to this path requires the android.Manifest.permission#WRITE_EXTERNAL_STORAGE permission.</para><para><para>getCacheDir </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the path of the directory holding application cache files on external storage. Returns null if external storage is not currently mounted so it could not ensure the path exists; you will need to call this method again when it is available.</para>
				/// </returns>
				/// <java-name>
				/// getExternalCacheDir
				/// </java-name>
				public global::Java.Io.File ExternalCacheDir
				{
				[Dot42.DexImport("getExternalCacheDir", "()Ljava/io/File;", AccessFlags = 1)]
						get{ return GetExternalCacheDir(); }
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.get() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaper
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Wallpaper
				{
				[Dot42.DexImport("getWallpaper", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetWallpaper(); }
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.getDesiredMinimumWidth() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaperDesiredMinimumWidth
				/// </java-name>
				public int WallpaperDesiredMinimumWidth
				{
				[Dot42.DexImport("getWallpaperDesiredMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetWallpaperDesiredMinimumWidth(); }
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use WallpaperManager.getDesiredMinimumHeight() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWallpaperDesiredMinimumHeight
				/// </java-name>
				public int WallpaperDesiredMinimumHeight
				{
				[Dot42.DexImport("getWallpaperDesiredMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetWallpaperDesiredMinimumHeight(); }
				}

		}

		/// <summary>
		/// <para>A mock android.content.res.Resources class. All methods are non-functional and throw java.lang.UnsupportedOperationException. Override it to provide the operations that you need. </para>    
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

				/// <summary>
				/// <para>Store the newly updated configuration. </para>        
				/// </summary>
				/// <java-name>
				/// updateConfiguration
				/// </java-name>
				[Dot42.DexImport("updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public override void UpdateConfiguration(global::Android.Content.Res.Configuration config, global::Android.Util.DisplayMetrics metrics) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the string value associated with a particular resource ID. The returned object will be a String if this is a plain string; it will be some other type of CharSequence if it is styled. {}</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>CharSequence The string data associated with the resource, plus possibly styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Returns the character sequence necessary for grammatically correct pluralization of the given resource ID for the given quantity. Note that the character sequence is selected based solely on grammatical necessity, and that such rules differ between languages. Do not assume you know which string will be returned for a given quantity. See  for more detail.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>CharSequence The string data associated with the resource, plus possibly styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getQuantityText
				/// </java-name>
				[Dot42.DexImport("getQuantityText", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetQuantityText(int id, int quantity) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Return the string value associated with a particular resource ID. It will be stripped of any styled text information. {}</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String The string data associated with the resource, stripped of styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetString(int id) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the string value associated with a particular resource ID, substituting the format arguments as defined in java.util.Formatter and java.lang.String#format. It will be stripped of any styled text information. {}</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String The string data associated with the resource, stripped of styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getString
				/// </java-name>
				[Dot42.DexImport("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public override string GetString(int id, params object[] formatArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Formats the string necessary for grammatically correct pluralization of the given resource ID for the given quantity, using the given arguments. Note that the string is selected based solely on grammatical necessity, and that such rules differ between languages. Do not assume you know which string will be returned for a given quantity. See  for more detail.</para><para>Substitution of format arguments works as if using java.util.Formatter and java.lang.String#format. The resulting string will be stripped of any styled text information.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String The string data associated with the resource, stripped of styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 129)]
				public override string GetQuantityString(int id, int quantity, params object[] formatArgs) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the string necessary for grammatically correct pluralization of the given resource ID for the given quantity. Note that the string is selected based solely on grammatical necessity, and that such rules differ between languages. Do not assume you know which string will be returned for a given quantity. See  for more detail.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String The string data associated with the resource, stripped of styled text information. </para>
				/// </returns>
				/// <java-name>
				/// getQuantityString
				/// </java-name>
				[Dot42.DexImport("getQuantityString", "(II)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetQuantityString(int id, int quantity) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the string value associated with a particular resource ID. The returned object will be a String if this is a plain string; it will be some other type of CharSequence if it is styled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>CharSequence The string data associated with the resource, plus possibly styled text information, or def if id is 0 or not found. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(int id, global::Java.Lang.ICharSequence def) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Return the styled text array associated with a particular resource ID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The styled text array associated with the resource. </para>
				/// </returns>
				/// <java-name>
				/// getTextArray
				/// </java-name>
				[Dot42.DexImport("getTextArray", "(I)[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence[] GetTextArray(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				/// <para>Return the string array associated with a particular resource ID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The string array associated with the resource. </para>
				/// </returns>
				/// <java-name>
				/// getStringArray
				/// </java-name>
				[Dot42.DexImport("getStringArray", "(I)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetStringArray(int id) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Return the int array associated with a particular resource ID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The int array associated with the resource. </para>
				/// </returns>
				/// <java-name>
				/// getIntArray
				/// </java-name>
				[Dot42.DexImport("getIntArray", "(I)[I", AccessFlags = 1)]
				public override int[] GetIntArray(int id) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				/// <para>Return an array of heterogeneous values.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a TypedArray holding an array of the array values. Be sure to call TypedArray.recycle() when done with it. </para>
				/// </returns>
				/// <java-name>
				/// obtainTypedArray
				/// </java-name>
				[Dot42.DexImport("obtainTypedArray", "(I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public override global::Android.Content.Res.TypedArray ObtainTypedArray(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <summary>
				/// <para>Retrieve a dimensional for a particular resource ID. Unit conversions are based on the current DisplayMetrics associated with the resources.</para><para><para>getDimensionPixelOffset </para><simplesectsep></simplesectsep><para>getDimensionPixelSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Resource dimension value multiplied by the appropriate metric.</para>
				/// </returns>
				/// <java-name>
				/// getDimension
				/// </java-name>
				[Dot42.DexImport("getDimension", "(I)F", AccessFlags = 1)]
				public override float GetDimension(int id) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Retrieve a dimensional for a particular resource ID for use as an offset in raw pixels. This is the same as getDimension, except the returned value is converted to integer pixels for you. An offset conversion involves simply truncating the base value to an integer.</para><para><para>getDimension </para><simplesectsep></simplesectsep><para>getDimensionPixelSize </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Resource dimension value multiplied by the appropriate metric and truncated to integer pixels.</para>
				/// </returns>
				/// <java-name>
				/// getDimensionPixelOffset
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelOffset", "(I)I", AccessFlags = 1)]
				public override int GetDimensionPixelOffset(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Retrieve a dimensional for a particular resource ID for use as a size in raw pixels. This is the same as getDimension, except the returned value is converted to integer pixels for use as a size. A size conversion involves rounding the base value, and ensuring that a non-zero base value is at least one pixel in size.</para><para><para>getDimension </para><simplesectsep></simplesectsep><para>getDimensionPixelOffset </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Resource dimension value multiplied by the appropriate metric and truncated to integer pixels.</para>
				/// </returns>
				/// <java-name>
				/// getDimensionPixelSize
				/// </java-name>
				[Dot42.DexImport("getDimensionPixelSize", "(I)I", AccessFlags = 1)]
				public override int GetDimensionPixelSize(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a drawable object associated with a particular resource ID. Various types of objects will be returned depending on the underlying resource  for example, a solid color, PNG image, scalable image, etc. The Drawable API hides these implementation details.</para><para><b>Note:</b> Prior to android.os.Build.VERSION_CODES#JELLY_BEAN, this function would not correctly retrieve the final configuration density when the resource ID passed here is an alias to another Drawable resource. This means that if the density configuration of the alias resource is different than the actual resource, the density of the returned Drawable would be incorrect, resulting in bad scaling. To work around this, you can instead retrieve the Drawable through TypedArray.getDrawable. Use Context.obtainStyledAttributes with an array containing the resource ID of interest to create the TypedArray.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Drawable An object that can be used to draw this resource. </para>
				/// </returns>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetDrawable(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Return a movie object associated with the particular resource ID. </para>        
				/// </summary>
				/// <java-name>
				/// getMovie
				/// </java-name>
				[Dot42.DexImport("getMovie", "(I)Landroid/graphics/Movie;", AccessFlags = 1)]
				public override global::Android.Graphics.Movie GetMovie(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Movie);
				}

				/// <summary>
				/// <para>Return a color integer associated with a particular resource ID. If the resource holds a complex android.content.res.ColorStateList, then the default color from the set is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a single color value in the form 0xAARRGGBB. </para>
				/// </returns>
				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "(I)I", AccessFlags = 1)]
				public override int GetColor(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a color state list associated with a particular resource ID. The resource may contain either a single raw color value, or a complex android.content.res.ColorStateList holding multiple possible colors.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a ColorStateList object containing either a single solid color or multiple colors that can be selected based on a state. </para>
				/// </returns>
				/// <java-name>
				/// getColorStateList
				/// </java-name>
				[Dot42.DexImport("getColorStateList", "(I)Landroid/content/res/ColorStateList;", AccessFlags = 1)]
				public override global::Android.Content.Res.ColorStateList GetColorStateList(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <summary>
				/// <para>Return an integer associated with a particular resource ID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the integer value contained in the resource. </para>
				/// </returns>
				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(I)I", AccessFlags = 1)]
				public override int GetInteger(int id) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return an XmlResourceParser through which you can read a view layout description for the given resource ID. This parser has limited functionality  in particular, you can't change its input, and only the high-level events are available.</para><para>This function is really a simple wrapper for calling getXml with a layout resource.</para><para><para>getXml </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new parser object through which you can read the XML data.</para>
				/// </returns>
				/// <java-name>
				/// getLayout
				/// </java-name>
				[Dot42.DexImport("getLayout", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetLayout(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <summary>
				/// <para>Return an XmlResourceParser through which you can read an animation description for the given resource ID. This parser has limited functionality  in particular, you can't change its input, and only the high-level events are available.</para><para>This function is really a simple wrapper for calling getXml with an animation resource.</para><para><para>getXml </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new parser object through which you can read the XML data.</para>
				/// </returns>
				/// <java-name>
				/// getAnimation
				/// </java-name>
				[Dot42.DexImport("getAnimation", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetAnimation(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <summary>
				/// <para>Return an XmlResourceParser through which you can read a generic XML resource for the given resource ID.</para><para>The XmlPullParser implementation returned here has some limited functionality. In particular, you can't change its input, and only high-level parsing events are available (since the document was pre-parsed for you at build time, which involved merging text and stripping comments).</para><para><para>android.util.AttributeSet </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A new parser object through which you can read the XML data.</para>
				/// </returns>
				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(I)Landroid/content/res/XmlResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetXml(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <summary>
				/// <para>Open a data stream for reading a raw resource. This can only be used with resources whose value is the name of an asset files  that is, it can be used to open drawable, sound, and raw resources; it will fail on string and color resources.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>InputStream Access to the resource data.</para>
				/// </returns>
				/// <java-name>
				/// openRawResource
				/// </java-name>
				[Dot42.DexImport("openRawResource", "(I)Ljava/io/InputStream;", AccessFlags = 1)]
				public override global::Java.Io.InputStream OpenRawResource(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Io.InputStream);
				}

				/// <summary>
				/// <para>Open a file descriptor for reading a raw resource. This can only be used with resources whose value is the name of an asset files  that is, it can be used to open drawable, sound, and raw resources; it will fail on string and color resources.</para><para>This function only works for resources that are stored in the package as uncompressed data, which typically includes things like mp3 files and png images.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>AssetFileDescriptor A new file descriptor you can use to read the resource. This includes the file descriptor itself, as well as the offset and length of data where the resource appears in the file. A null is returned if the file exists but is compressed.</para>
				/// </returns>
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

				/// <summary>
				/// <para>Retrieve a set of basic attribute values from an AttributeSet, not performing styling of them using a theme and/or style resources.</para><para><para>Theme::obtainStyledAttributes(AttributeSet, int[], int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a TypedArray holding an array of the attribute values. Be sure to call TypedArray.recycle() when done with it.</para>
				/// </returns>
				/// <java-name>
				/// obtainAttributes
				/// </java-name>
				[Dot42.DexImport("obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", AccessFlags = 1)]
				public override global::Android.Content.Res.TypedArray ObtainAttributes(global::Android.Util.IAttributeSet set, int[] attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.TypedArray);
				}

				/// <summary>
				/// <para>Return the current display metrics that are in effect for this resource object. The returned object should be treated as read-only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The resource's current display metrics. </para>
				/// </returns>
				/// <java-name>
				/// getDisplayMetrics
				/// </java-name>
				[Dot42.DexImport("getDisplayMetrics", "()Landroid/util/DisplayMetrics;", AccessFlags = 1)]
				public override global::Android.Util.DisplayMetrics GetDisplayMetrics() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Util.DisplayMetrics);
				}

				/// <summary>
				/// <para>Return the current configuration that is in effect for this resource object. The returned object should be treated as read-only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The resource's current configuration. </para>
				/// </returns>
				/// <java-name>
				/// getConfiguration
				/// </java-name>
				[Dot42.DexImport("getConfiguration", "()Landroid/content/res/Configuration;", AccessFlags = 1)]
				public override global::Android.Content.Res.Configuration GetConfiguration() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Configuration);
				}

				/// <summary>
				/// <para>Return a resource identifier for the given resource name. A fully qualified resource name is of the form "package:type/entry". The first two components (package and type) are optional if defType and defPackage, respectively, are specified here.</para><para>Note: use of this function is discouraged. It is much more efficient to retrieve resources by identifier than by name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The associated resource identifier. Returns 0 if no such resource was found. (0 is not a valid resource ID.) </para>
				/// </returns>
				/// <java-name>
				/// getIdentifier
				/// </java-name>
				[Dot42.DexImport("getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int GetIdentifier(string name, string defType, string defPackage) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the full name for a given resource identifier. This name is a single string of the form "package:type/entry".</para><para><para>getResourcePackageName </para><simplesectsep></simplesectsep><para>getResourceTypeName </para><simplesectsep></simplesectsep><para>getResourceEntryName </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string holding the name of the resource.</para>
				/// </returns>
				/// <java-name>
				/// getResourceName
				/// </java-name>
				[Dot42.DexImport("getResourceName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the package name for a given resource identifier.</para><para><para>getResourceName </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string holding the package name of the resource.</para>
				/// </returns>
				/// <java-name>
				/// getResourcePackageName
				/// </java-name>
				[Dot42.DexImport("getResourcePackageName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourcePackageName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the type name for a given resource identifier.</para><para><para>getResourceName </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string holding the type name of the resource.</para>
				/// </returns>
				/// <java-name>
				/// getResourceTypeName
				/// </java-name>
				[Dot42.DexImport("getResourceTypeName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceTypeName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the entry name for a given resource identifier.</para><para><para>getResourceName </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string holding the entry name of the resource.</para>
				/// </returns>
				/// <java-name>
				/// getResourceEntryName
				/// </java-name>
				[Dot42.DexImport("getResourceEntryName", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetResourceEntryName(int resid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the current display metrics that are in effect for this resource object. The returned object should be treated as read-only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The resource's current display metrics. </para>
				/// </returns>
				/// <java-name>
				/// getDisplayMetrics
				/// </java-name>
				public global::Android.Util.DisplayMetrics DisplayMetrics
				{
				[Dot42.DexImport("getDisplayMetrics", "()Landroid/util/DisplayMetrics;", AccessFlags = 1)]
						get{ return GetDisplayMetrics(); }
				}

				/// <summary>
				/// <para>Return the current configuration that is in effect for this resource object. The returned object should be treated as read-only.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The resource's current configuration. </para>
				/// </returns>
				/// <java-name>
				/// getConfiguration
				/// </java-name>
				public global::Android.Content.Res.Configuration Configuration
				{
				[Dot42.DexImport("getConfiguration", "()Landroid/content/res/Configuration;", AccessFlags = 1)]
						get{ return GetConfiguration(); }
				}

		}

		/// <summary>
		/// <para>A mock android.content.pm.PackageManager class. All methods are non-functional and throw java.lang.UnsupportedOperationException. Override it to provide the operations that you need. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Retrieve overall information about an application package that is installed on the system. </para><para>Throws NameNotFoundException if a package with the given name can not be found on the system.</para><para><para>GET_ACTIVITIES </para><simplesectsep></simplesectsep><para>GET_GIDS </para><simplesectsep></simplesectsep><para>GET_CONFIGURATIONS </para><simplesectsep></simplesectsep><para>GET_INSTRUMENTATION </para><simplesectsep></simplesectsep><para>GET_PERMISSIONS </para><simplesectsep></simplesectsep><para>GET_PROVIDERS </para><simplesectsep></simplesectsep><para>GET_RECEIVERS </para><simplesectsep></simplesectsep><para>GET_SERVICES </para><simplesectsep></simplesectsep><para>GET_SIGNATURES </para><simplesectsep></simplesectsep><para>GET_UNINSTALLED_PACKAGES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a PackageInfo object containing information about the package. If flag GET_UNINSTALLED_PACKAGES is set and if the package is not found in the list of installed applications, the package information is retrieved from the list of uninstalled applications (which includes installed applications as well as applications with data directory i.e. applications which had been deleted with <c> DONT_DELETE_DATA </c> flag set). </para>
				/// </returns>
				/// <java-name>
				/// getPackageInfo
				/// </java-name>
				[Dot42.DexImport("getPackageInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PackageInfo GetPackageInfo(string packageName, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PackageInfo);
				}

				/// <summary>
				/// <para>Map from the current package names in use on the device to whatever the current canonical name of that package is. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an array of the same size as the original, containing the canonical name for each package. </para>
				/// </returns>
				/// <java-name>
				/// currentToCanonicalPackageNames
				/// </java-name>
				[Dot42.DexImport("currentToCanonicalPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] CurrentToCanonicalPackageNames(string[] names) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Map from a packages canonical name to the current name in use on the device. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an array of the same size as the original, containing the current name for each package. </para>
				/// </returns>
				/// <java-name>
				/// canonicalToCurrentPackageNames
				/// </java-name>
				[Dot42.DexImport("canonicalToCurrentPackageNames", "([Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] CanonicalToCurrentPackageNames(string[] names) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Return a "good" intent to launch a front-door activity in a package, for use for example to implement an "open" button when browsing through packages. The current implementation will look first for a main activity in the category Intent#CATEGORY_INFO, next for a main activity in the category Intent#CATEGORY_LAUNCHER, or return null if neither are found.</para><para>Throws NameNotFoundException if a package with the given name cannot be found on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns either a fully-qualified Intent that can be used to launch the main activity in the package, or null if the package does not contain such an activity. </para>
				/// </returns>
				/// <java-name>
				/// getLaunchIntentForPackage
				/// </java-name>
				[Dot42.DexImport("getLaunchIntentForPackage", "(Ljava/lang/String;)Landroid/content/Intent;", AccessFlags = 1)]
				public override global::Android.Content.Intent GetLaunchIntentForPackage(string packageName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				/// <para>Return an array of all of the secondary group-ids that have been assigned to a package.</para><para>Throws NameNotFoundException if a package with the given name cannot be found on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an int array of the assigned gids, or null if there are none. </para>
				/// </returns>
				/// <java-name>
				/// getPackageGids
				/// </java-name>
				[Dot42.DexImport("getPackageGids", "(Ljava/lang/String;)[I", AccessFlags = 1)]
				public override int[] GetPackageGids(string packageName) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				/// <para>Retrieve all of the information we know about a particular permission.</para><para>Throws NameNotFoundException if a permission with the given name cannot be found on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a PermissionInfo containing information about the permission. </para>
				/// </returns>
				/// <java-name>
				/// getPermissionInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PermissionInfo GetPermissionInfo(string name, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PermissionInfo);
				}

				/// <summary>
				/// <para>Query for all of the permissions associated with a particular group.</para><para>Throws NameNotFoundException if the given group does not exist.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a list of PermissionInfo containing information about all of the permissions in the given group. </para>
				/// </returns>
				/// <java-name>
				/// queryPermissionsByGroup
				/// </java-name>
				[Dot42.DexImport("queryPermissionsByGroup", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/PermissionInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.PermissionInfo> QueryPermissionsByGroup(string group, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.PermissionInfo>);
				}

				/// <summary>
				/// <para>Retrieve all of the information we know about a particular group of permissions.</para><para>Throws NameNotFoundException if a permission group with the given name cannot be found on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a PermissionGroupInfo containing information about the permission. </para>
				/// </returns>
				/// <java-name>
				/// getPermissionGroupInfo
				/// </java-name>
				[Dot42.DexImport("getPermissionGroupInfo", "(Ljava/lang/String;I)Landroid/content/pm/PermissionGroupInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PermissionGroupInfo GetPermissionGroupInfo(string name, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PermissionGroupInfo);
				}

				/// <summary>
				/// <para>Retrieve all of the known permission groups in the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a list of PermissionGroupInfo containing information about all of the known permission groups. </para>
				/// </returns>
				/// <java-name>
				/// getAllPermissionGroups
				/// </java-name>
				[Dot42.DexImport("getAllPermissionGroups", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PermissionGroupInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.PermissionGroupInfo> GetAllPermissionGroups(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.PermissionGroupInfo>);
				}

				/// <summary>
				/// <para>Retrieve all of the information we know about a particular package/application.</para><para>Throws NameNotFoundException if an application with the given package name cannot be found on the system.</para><para><para>GET_META_DATA </para><simplesectsep></simplesectsep><para>GET_SHARED_LIBRARY_FILES </para><simplesectsep></simplesectsep><para>GET_UNINSTALLED_PACKAGES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>ApplicationInfo Returns ApplicationInfo object containing information about the package. If flag GET_UNINSTALLED_PACKAGES is set and if the package is not found in the list of installed applications, the application information is retrieved from the list of uninstalled applications(which includes installed applications as well as applications with data directory ie applications which had been deleted with <c> DONT_DELETE_DATA </c> flag set).</para>
				/// </returns>
				/// <java-name>
				/// getApplicationInfo
				/// </java-name>
				[Dot42.DexImport("getApplicationInfo", "(Ljava/lang/String;I)Landroid/content/pm/ApplicationInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ApplicationInfo GetApplicationInfo(string packageName, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ApplicationInfo);
				}

				/// <summary>
				/// <para>Retrieve all of the information we know about a particular activity class.</para><para>Throws NameNotFoundException if an activity with the given class name cannot be found on the system.</para><para><para>GET_INTENT_FILTERS </para><simplesectsep></simplesectsep><para>GET_META_DATA </para><simplesectsep></simplesectsep><para>GET_SHARED_LIBRARY_FILES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>ActivityInfo containing information about the activity.</para>
				/// </returns>
				/// <java-name>
				/// getActivityInfo
				/// </java-name>
				[Dot42.DexImport("getActivityInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ActivityInfo GetActivityInfo(global::Android.Content.ComponentName component, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ActivityInfo);
				}

				/// <summary>
				/// <para>Retrieve all of the information we know about a particular receiver class.</para><para>Throws NameNotFoundException if a receiver with the given class name cannot be found on the system.</para><para><para>GET_INTENT_FILTERS </para><simplesectsep></simplesectsep><para>GET_META_DATA </para><simplesectsep></simplesectsep><para>GET_SHARED_LIBRARY_FILES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>ActivityInfo containing information about the receiver.</para>
				/// </returns>
				/// <java-name>
				/// getReceiverInfo
				/// </java-name>
				[Dot42.DexImport("getReceiverInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ActivityInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ActivityInfo GetReceiverInfo(global::Android.Content.ComponentName component, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ActivityInfo);
				}

				/// <summary>
				/// <para>Retrieve all of the information we know about a particular service class.</para><para>Throws NameNotFoundException if a service with the given class name cannot be found on the system.</para><para><para>GET_META_DATA </para><simplesectsep></simplesectsep><para>GET_SHARED_LIBRARY_FILES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>ServiceInfo containing information about the service.</para>
				/// </returns>
				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				[Dot42.DexImport("getServiceInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ServiceInfo GetServiceInfo(global::Android.Content.ComponentName component, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ServiceInfo);
				}

				/// <summary>
				/// <para>Retrieve all of the information we know about a particular content provider class.</para><para>Throws NameNotFoundException if a provider with the given class name cannot be found on the system.</para><para><para>GET_META_DATA </para><simplesectsep></simplesectsep><para>GET_SHARED_LIBRARY_FILES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>ProviderInfo containing information about the service.</para>
				/// </returns>
				/// <java-name>
				/// getProviderInfo
				/// </java-name>
				[Dot42.DexImport("getProviderInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ProviderInfo GetProviderInfo(global::Android.Content.ComponentName component, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ProviderInfo);
				}

				/// <summary>
				/// <para>Return a List of all packages that are installed on the device.</para><para><para>GET_ACTIVITIES </para><simplesectsep></simplesectsep><para>GET_GIDS </para><simplesectsep></simplesectsep><para>GET_CONFIGURATIONS </para><simplesectsep></simplesectsep><para>GET_INSTRUMENTATION </para><simplesectsep></simplesectsep><para>GET_PERMISSIONS </para><simplesectsep></simplesectsep><para>GET_PROVIDERS </para><simplesectsep></simplesectsep><para>GET_RECEIVERS </para><simplesectsep></simplesectsep><para>GET_SERVICES </para><simplesectsep></simplesectsep><para>GET_SIGNATURES </para><simplesectsep></simplesectsep><para>GET_UNINSTALLED_PACKAGES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A List of PackageInfo objects, one for each package that is installed on the device. In the unlikely case of there being no installed packages, an empty list is returned. If flag GET_UNINSTALLED_PACKAGES is set, a list of all applications including those deleted with <c> DONT_DELETE_DATA </c> (partially installed apps with data directory) will be returned.</para>
				/// </returns>
				/// <java-name>
				/// getInstalledPackages
				/// </java-name>
				[Dot42.DexImport("getInstalledPackages", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.PackageInfo> GetInstalledPackages(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.PackageInfo>);
				}

				/// <summary>
				/// <para>Check whether a particular package has been granted a particular permission.</para><para><para>PERMISSION_GRANTED </para><simplesectsep></simplesectsep><para>PERMISSION_DENIED </para></para>        
				/// </summary>
				/// <returns>
				/// <para>If the package has the permission, PERMISSION_GRANTED is returned. If it does not have the permission, PERMISSION_DENIED is returned.</para>
				/// </returns>
				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckPermission(string permName, string pkgName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Add a new dynamic permission to the system. For this to work, your package must have defined a permission tree through the &lt;permission-tree&gt; tag in its manifest. A package can only add permissions to trees that were defined by either its own package or another with the same user id; a permission is in a tree if it matches the name of the permission tree + ".": for example, "com.foo.bar" is a member of the permission tree "com.foo".</para><para>It is good to make your permission tree name descriptive, because you are taking possession of that entire set of permission names. Thus, it must be under a domain you control, with a suffix that will not match any normal permissions that may be declared in any applications that are part of that domain.</para><para>New permissions must be added before any .apks are installed that use those permissions. Permissions you add through this method are remembered across reboots of the device. If the given permission already exists, the info you supply here will be used to update it.</para><para><para>removePermission(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if a new permission was created, false if an existing one was updated.</para>
				/// </returns>
				/// <java-name>
				/// addPermission
				/// </java-name>
				[Dot42.DexImport("addPermission", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1)]
				public override bool AddPermission(global::Android.Content.Pm.PermissionInfo info) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Like addPermission(PermissionInfo) but asynchronously persists the package manager state after returning from the call, allowing it to return quicker and batch a series of adds at the expense of no guarantee the added permission will be retained if the device is rebooted before it is written. </para>        
				/// </summary>
				/// <java-name>
				/// addPermissionAsync
				/// </java-name>
				[Dot42.DexImport("addPermissionAsync", "(Landroid/content/pm/PermissionInfo;)Z", AccessFlags = 1)]
				public override bool AddPermissionAsync(global::Android.Content.Pm.PermissionInfo info) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes a permission that was previously added with addPermission(PermissionInfo). The same ownership rules apply  you are only allowed to remove permissions that you are allowed to add.</para><para><para>addPermission(PermissionInfo) </para></para>        
				/// </summary>
				/// <java-name>
				/// removePermission
				/// </java-name>
				[Dot42.DexImport("removePermission", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void RemovePermission(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Like checkSignatures(String, String), but takes UIDs of the two packages to be checked. This can be useful, for example, when doing the check in an IPC, where the UID is the only identity available. It is functionally identical to determining the package associated with the UIDs and checking their signatures.</para><para><para>checkSignatures(String, String) </para><simplesectsep></simplesectsep><para>SIGNATURE_MATCH </para><simplesectsep></simplesectsep><para>SIGNATURE_NO_MATCH </para><simplesectsep></simplesectsep><para>SIGNATURE_UNKNOWN_PACKAGE </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an integer indicating whether all signatures on the two packages match. The value is &gt;= 0 (SIGNATURE_MATCH) if all signatures match or &lt; 0 if there is not a match (SIGNATURE_NO_MATCH or SIGNATURE_UNKNOWN_PACKAGE).</para>
				/// </returns>
				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int CheckSignatures(string uid1, string uid2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Like checkSignatures(String, String), but takes UIDs of the two packages to be checked. This can be useful, for example, when doing the check in an IPC, where the UID is the only identity available. It is functionally identical to determining the package associated with the UIDs and checking their signatures.</para><para><para>checkSignatures(String, String) </para><simplesectsep></simplesectsep><para>SIGNATURE_MATCH </para><simplesectsep></simplesectsep><para>SIGNATURE_NO_MATCH </para><simplesectsep></simplesectsep><para>SIGNATURE_UNKNOWN_PACKAGE </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an integer indicating whether all signatures on the two packages match. The value is &gt;= 0 (SIGNATURE_MATCH) if all signatures match or &lt; 0 if there is not a match (SIGNATURE_NO_MATCH or SIGNATURE_UNKNOWN_PACKAGE).</para>
				/// </returns>
				/// <java-name>
				/// checkSignatures
				/// </java-name>
				[Dot42.DexImport("checkSignatures", "(II)I", AccessFlags = 1)]
				public override int CheckSignatures(int uid1, int uid2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Retrieve the names of all packages that are associated with a particular user id. In most cases, this will be a single package name, the package that has been assigned that user id. Where there are multiple packages sharing the same user id through the "sharedUserId" mechanism, all packages with that id will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an array of one or more packages assigned to the user id, or null if there are no known packages with the given id. </para>
				/// </returns>
				/// <java-name>
				/// getPackagesForUid
				/// </java-name>
				[Dot42.DexImport("getPackagesForUid", "(I)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetPackagesForUid(int uid) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Retrieve the official name associated with a user id. This name is guaranteed to never change, though it is possibly for the underlying user id to be changed. That is, if you are storing information about user ids in persistent storage, you should use the string returned by this function instead of the raw user-id.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a unique name for the given user id, or null if the user id is not currently assigned. </para>
				/// </returns>
				/// <java-name>
				/// getNameForUid
				/// </java-name>
				[Dot42.DexImport("getNameForUid", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetNameForUid(int uid) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return a List of all application packages that are installed on the device. If flag GET_UNINSTALLED_PACKAGES has been set, a list of all applications including those deleted with <c> DONT_DELETE_DATA </c> (partially installed apps with data directory) will be returned.</para><para><para>GET_META_DATA </para><simplesectsep></simplesectsep><para>GET_SHARED_LIBRARY_FILES </para><simplesectsep></simplesectsep><para>GET_UNINSTALLED_PACKAGES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a List of ApplicationInfo objects, one for each application that is installed on the device. In the unlikely case of there being no installed applications, an empty list is returned. If flag GET_UNINSTALLED_PACKAGES is set, a list of all applications including those deleted with <c> DONT_DELETE_DATA </c> (partially installed apps with data directory) will be returned.</para>
				/// </returns>
				/// <java-name>
				/// getInstalledApplications
				/// </java-name>
				[Dot42.DexImport("getInstalledApplications", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/ApplicationInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ApplicationInfo> GetInstalledApplications(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ApplicationInfo>);
				}

				/// <summary>
				/// <para>Determine the best action to perform for a given Intent. This is how Intent#resolveActivity finds an activity if a class has not been explicitly specified.</para><para><b>Note:</b> if using an implicit Intent (without an explicit ComponentName specified), be sure to consider whether to set the MATCH_DEFAULT_ONLY only flag. You need to do so to resolve the activity in the same way that android.content.Context#startActivity(Intent) and Intent.resolveActivity(PackageManager) do.</para><para><para>MATCH_DEFAULT_ONLY </para><simplesectsep></simplesectsep><para>GET_INTENT_FILTERS </para><simplesectsep></simplesectsep><para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a ResolveInfo containing the final activity intent that was determined to be the best action. Returns null if no matching activity was found. If multiple matching activities are found and there is no default set, returns a ResolveInfo containing something else, such as the activity resolver.</para>
				/// </returns>
				/// <java-name>
				/// resolveActivity
				/// </java-name>
				[Dot42.DexImport("resolveActivity", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ResolveInfo ResolveActivity(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ResolveInfo);
				}

				/// <summary>
				/// <para>Retrieve all activities that can be performed for the given intent.</para><para><para>MATCH_DEFAULT_ONLY </para><simplesectsep></simplesectsep><para>GET_INTENT_FILTERS </para><simplesectsep></simplesectsep><para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A List&lt;ResolveInfo&gt; containing one entry for each matching Activity. These are ordered from best to worst match  that is, the first item in the list is what is returned by resolveActivity. If there are no matching activities, an empty list is returned.</para>
				/// </returns>
				/// <java-name>
				/// queryIntentActivities
				/// </java-name>
				[Dot42.DexImport("queryIntentActivities", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentActivities(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo>);
				}

				/// <summary>
				/// <para>Retrieve a set of activities that should be presented to the user as similar options. This is like queryIntentActivities, except it also allows you to supply a list of more explicit Intents that you would like to resolve to particular options, and takes care of returning the final ResolveInfo list in a reasonable order, with no duplicates, based on those inputs.</para><para><para>MATCH_DEFAULT_ONLY </para><simplesectsep></simplesectsep><para>GET_INTENT_FILTERS </para><simplesectsep></simplesectsep><para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A List&lt;ResolveInfo&gt; containing one entry for each matching Activity. These are ordered first by all of the intents resolved in <b>specifics</b> and then any additional activities that can handle <b>intent</b> but did not get included by one of the <b>specifics</b> intents. If there are no matching activities, an empty list is returned.</para>
				/// </returns>
				/// <java-name>
				/// queryIntentActivityOptions
				/// </java-name>
				[Dot42.DexImport("queryIntentActivityOptions", "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;" +
    "I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentActivityOptions(global::Android.Content.ComponentName caller, global::Android.Content.Intent[] specifics, global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo>);
				}

				/// <summary>
				/// <para>Retrieve all receivers that can handle a broadcast of the given intent.</para><para><para>MATCH_DEFAULT_ONLY </para><simplesectsep></simplesectsep><para>GET_INTENT_FILTERS </para><simplesectsep></simplesectsep><para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A List&lt;ResolveInfo&gt; containing one entry for each matching Receiver. These are ordered from first to last in priority. If there are no matching receivers, an empty list is returned.</para>
				/// </returns>
				/// <java-name>
				/// queryBroadcastReceivers
				/// </java-name>
				[Dot42.DexImport("queryBroadcastReceivers", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryBroadcastReceivers(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo>);
				}

				/// <summary>
				/// <para>Determine the best service to handle for a given Intent.</para><para><para>GET_INTENT_FILTERS </para><simplesectsep></simplesectsep><para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a ResolveInfo containing the final service intent that was determined to be the best action. Returns null if no matching service was found.</para>
				/// </returns>
				/// <java-name>
				/// resolveService
				/// </java-name>
				[Dot42.DexImport("resolveService", "(Landroid/content/Intent;I)Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ResolveInfo ResolveService(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ResolveInfo);
				}

				/// <summary>
				/// <para>Retrieve all services that can match the given intent.</para><para><para>GET_INTENT_FILTERS </para><simplesectsep></simplesectsep><para>GET_RESOLVED_FILTER </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A List&lt;ResolveInfo&gt; containing one entry for each matching ServiceInfo. These are ordered from best to worst match  that is, the first item in the list is what is returned by resolveService(). If there are no matching services, an empty list is returned.</para>
				/// </returns>
				/// <java-name>
				/// queryIntentServices
				/// </java-name>
				[Dot42.DexImport("queryIntentServices", "(Landroid/content/Intent;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/content/Intent;I)Ljava/util/List<Landroid/content/pm/ResolveInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo> QueryIntentServices(global::Android.Content.Intent intent, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ResolveInfo>);
				}

				/// <summary>
				/// <para>Find a single content provider by its base path name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ContentProviderInfo Information about the provider, if found, else null. </para>
				/// </returns>
				/// <java-name>
				/// resolveContentProvider
				/// </java-name>
				[Dot42.DexImport("resolveContentProvider", "(Ljava/lang/String;I)Landroid/content/pm/ProviderInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.ProviderInfo ResolveContentProvider(string name, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ProviderInfo);
				}

				/// <summary>
				/// <para>Retrieve content provider information.</para><para><b>Note: unlike most other methods, an empty result set is indicated by a null return instead of an empty list.</b></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A List&lt;ContentProviderInfo&gt; containing one entry for each content provider either patching <b>processName</b> or, if <b>processName</b> is null, all known content providers. <b>If there are no matching providers, null is returned.</b> </para>
				/// </returns>
				/// <java-name>
				/// queryContentProviders
				/// </java-name>
				[Dot42.DexImport("queryContentProviders", "(Ljava/lang/String;II)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;II)Ljava/util/List<Landroid/content/pm/ProviderInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.ProviderInfo> QueryContentProviders(string processName, int uid, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ProviderInfo>);
				}

				/// <summary>
				/// <para>Retrieve all of the information we know about a particular instrumentation class.</para><para>Throws NameNotFoundException if instrumentation with the given class name cannot be found on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>InstrumentationInfo containing information about the instrumentation. </para>
				/// </returns>
				/// <java-name>
				/// getInstrumentationInfo
				/// </java-name>
				[Dot42.DexImport("getInstrumentationInfo", "(Landroid/content/ComponentName;I)Landroid/content/pm/InstrumentationInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.InstrumentationInfo GetInstrumentationInfo(global::Android.Content.ComponentName className, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.InstrumentationInfo);
				}

				/// <summary>
				/// <para>Retrieve information about available instrumentation code. May be used to retrieve either all instrumentation code, or only the code targeting a particular package.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A List&lt;InstrumentationInfo&gt; containing one entry for each matching available Instrumentation. Returns an empty list if there is no instrumentation available for the given package. </para>
				/// </returns>
				/// <java-name>
				/// queryInstrumentation
				/// </java-name>
				[Dot42.DexImport("queryInstrumentation", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/content/pm/InstrumentationInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.InstrumentationInfo> QueryInstrumentation(string targetPackage, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.InstrumentationInfo>);
				}

				/// <summary>
				/// <para>Retrieve an image from a package. This is a low-level API used by the various package manager info structures (such as ComponentInfo to implement retrieval of their associated icon.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a Drawable holding the requested image. Returns null if an image could not be found for any reason. </para>
				/// </returns>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/graphics/drawab" +
    "le/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetDrawable(string packageName, int resid, global::Android.Content.Pm.ApplicationInfo appInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve the icon associated with an activity. Given the full name of an activity, retrieves the information about it and calls ComponentInfo.loadIcon() to return its icon. If the activity cannot be found, NameNotFoundException is thrown.</para><para><para>getActivityIcon(Intent) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the image of the icon, or the default activity icon if it could not be found. Does not return null. </para>
				/// </returns>
				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetActivityIcon(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve the icon associated with an activity. Given the full name of an activity, retrieves the information about it and calls ComponentInfo.loadIcon() to return its icon. If the activity cannot be found, NameNotFoundException is thrown.</para><para><para>getActivityIcon(Intent) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the image of the icon, or the default activity icon if it could not be found. Does not return null. </para>
				/// </returns>
				/// <java-name>
				/// getActivityIcon
				/// </java-name>
				[Dot42.DexImport("getActivityIcon", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetActivityIcon(global::Android.Content.Intent activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Return the generic icon for an activity that is used when no specific icon is defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Drawable Image of the icon. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultActivityIcon
				/// </java-name>
				[Dot42.DexImport("getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetDefaultActivityIcon() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve the icon associated with an application. If it has not defined an icon, the default app icon is returned. Does not return null.</para><para><para>getApplicationIcon(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the image of the icon, or the default application icon if it could not be found.</para>
				/// </returns>
				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetApplicationIcon(global::Android.Content.Pm.ApplicationInfo info) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve the icon associated with an application. If it has not defined an icon, the default app icon is returned. Does not return null.</para><para><para>getApplicationIcon(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the image of the icon, or the default application icon if it could not be found.</para>
				/// </returns>
				/// <java-name>
				/// getApplicationIcon
				/// </java-name>
				[Dot42.DexImport("getApplicationIcon", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetApplicationIcon(string info) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve the logo associated with an activity. Given the full name of an activity, retrieves the information about it and calls ComponentInfo.loadLogo() to return its logo. If the activity cannot be found, NameNotFoundException is thrown.</para><para><para>getActivityLogo(Intent) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the image of the logo or null if the activity has no logo specified.</para>
				/// </returns>
				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/ComponentName;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetActivityLogo(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve the logo associated with an activity. Given the full name of an activity, retrieves the information about it and calls ComponentInfo.loadLogo() to return its logo. If the activity cannot be found, NameNotFoundException is thrown.</para><para><para>getActivityLogo(Intent) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the image of the logo or null if the activity has no logo specified.</para>
				/// </returns>
				/// <java-name>
				/// getActivityLogo
				/// </java-name>
				[Dot42.DexImport("getActivityLogo", "(Landroid/content/Intent;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetActivityLogo(global::Android.Content.Intent activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve the logo associated with an application. If it has not specified a logo, this method returns null.</para><para><para>getApplicationLogo(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the image of the logo, or null if no logo is specified by the application.</para>
				/// </returns>
				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Landroid/content/pm/ApplicationInfo;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetApplicationLogo(global::Android.Content.Pm.ApplicationInfo info) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve the logo associated with an application. If it has not specified a logo, this method returns null.</para><para><para>getApplicationLogo(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the image of the logo, or null if no logo is specified by the application.</para>
				/// </returns>
				/// <java-name>
				/// getApplicationLogo
				/// </java-name>
				[Dot42.DexImport("getApplicationLogo", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetApplicationLogo(string info) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Retrieve text from a package. This is a low-level API used by the various package manager info structures (such as ComponentInfo to implement retrieval of their associated labels and other text.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a CharSequence holding the requested text. Returns null if the text could not be found for any reason. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;" +
    "", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetText(string packageName, int resid, global::Android.Content.Pm.ApplicationInfo appInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Retrieve an XML file from a package. This is a low-level API used to retrieve XML meta data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an XmlPullParser allowing you to parse out the XML data. Returns null if the xml resource could not be found for any reason. </para>
				/// </returns>
				/// <java-name>
				/// getXml
				/// </java-name>
				[Dot42.DexImport("getXml", "(Ljava/lang/String;ILandroid/content/pm/ApplicationInfo;)Landroid/content/res/Xml" +
    "ResourceParser;", AccessFlags = 1)]
				public override global::Android.Content.Res.IXmlResourceParser GetXml(string packageName, int resid, global::Android.Content.Pm.ApplicationInfo appInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.IXmlResourceParser);
				}

				/// <summary>
				/// <para>Return the label to use for this application.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the label associated with this application, or null if it could not be found for any reason. </para>
				/// </returns>
				/// <java-name>
				/// getApplicationLabel
				/// </java-name>
				[Dot42.DexImport("getApplicationLabel", "(Landroid/content/pm/ApplicationInfo;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetApplicationLabel(global::Android.Content.Pm.ApplicationInfo info) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Retrieve the resources associated with an activity. Given the full name of an activity, retrieves the information about it and calls getResources() to return its application's resources. If the activity cannot be found, NameNotFoundException is thrown.</para><para><para>getResourcesForApplication(ApplicationInfo) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the application's Resources. </para>
				/// </returns>
				/// <java-name>
				/// getResourcesForActivity
				/// </java-name>
				[Dot42.DexImport("getResourcesForActivity", "(Landroid/content/ComponentName;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForActivity(global::Android.Content.ComponentName activityName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <summary>
				/// <para>Retrieve the resources for an application. Throws NameNotFoundException if the package is no longer installed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the application's Resources. </para>
				/// </returns>
				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Landroid/content/pm/ApplicationInfo;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForApplication(global::Android.Content.Pm.ApplicationInfo app) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <summary>
				/// <para>Retrieve the resources for an application. Throws NameNotFoundException if the package is no longer installed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the application's Resources. </para>
				/// </returns>
				/// <java-name>
				/// getResourcesForApplication
				/// </java-name>
				[Dot42.DexImport("getResourcesForApplication", "(Ljava/lang/String;)Landroid/content/res/Resources;", AccessFlags = 1)]
				public override global::Android.Content.Res.Resources GetResourcesForApplication(string app) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.Resources);
				}

				/// <summary>
				/// <para>Retrieve overall information about an application package defined in a package archive file</para><para><para>GET_ACTIVITIES </para><simplesectsep></simplesectsep><para>GET_GIDS </para><simplesectsep></simplesectsep><para>GET_CONFIGURATIONS </para><simplesectsep></simplesectsep><para>GET_INSTRUMENTATION </para><simplesectsep></simplesectsep><para>GET_PERMISSIONS </para><simplesectsep></simplesectsep><para>GET_PROVIDERS </para><simplesectsep></simplesectsep><para>GET_RECEIVERS </para><simplesectsep></simplesectsep><para>GET_SERVICES </para><simplesectsep></simplesectsep><para>GET_SIGNATURES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the information about the package. Returns null if the package could not be successfully parsed.</para>
				/// </returns>
				/// <java-name>
				/// getPackageArchiveInfo
				/// </java-name>
				[Dot42.DexImport("getPackageArchiveInfo", "(Ljava/lang/String;I)Landroid/content/pm/PackageInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.PackageInfo GetPackageArchiveInfo(string archiveFilePath, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.PackageInfo);
				}

				/// <summary>
				/// <para>Change the installer associated with a given package. There are limitations on how the installer package can be changed; in particular: <ul><li><para>A SecurityException will be thrown if <b>installerPackageName</b> is not signed with the same certificate as the calling application. </para></li><li><para>A SecurityException will be thrown if <b>targetPackage</b> already has an installer package, and that installer package is not signed with the same certificate as the calling application. </para></li></ul></para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("setInstallerPackageName", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void SetInstallerPackageName(string targetPackage, string installerPackageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retrieve the package name of the application that installed a package. This identifies which market the package came from.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getInstallerPackageName
				/// </java-name>
				[Dot42.DexImport("getInstallerPackageName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetInstallerPackageName(string packageName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function no longer does anything; it was an old approach to managing preferred activities, which has been superseded by (and conflicts with) the modern activity-based preferences. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// addPackageToPreferred
				/// </java-name>
				[Dot42.DexImport("addPackageToPreferred", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void AddPackageToPreferred(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function no longer does anything; it was an old approach to managing preferred activities, which has been superseded by (and conflicts with) the modern activity-based preferences. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// removePackageFromPreferred
				/// </java-name>
				[Dot42.DexImport("removePackageFromPreferred", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void RemovePackageFromPreferred(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retrieve the list of all currently configured preferred packages. The first package on the list is the most preferred, the last is the least preferred.</para><para><para>GET_ACTIVITIES </para><simplesectsep></simplesectsep><para>GET_GIDS </para><simplesectsep></simplesectsep><para>GET_CONFIGURATIONS </para><simplesectsep></simplesectsep><para>GET_INSTRUMENTATION </para><simplesectsep></simplesectsep><para>GET_PERMISSIONS </para><simplesectsep></simplesectsep><para>GET_PROVIDERS </para><simplesectsep></simplesectsep><para>GET_RECEIVERS </para><simplesectsep></simplesectsep><para>GET_SERVICES </para><simplesectsep></simplesectsep><para>GET_SIGNATURES </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a list of PackageInfo objects describing each preferred application, in order of preference.</para>
				/// </returns>
				/// <java-name>
				/// getPreferredPackages
				/// </java-name>
				[Dot42.DexImport("getPreferredPackages", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/content/pm/PackageInfo;>;")]
				public override global::Java.Util.IList<global::Android.Content.Pm.PackageInfo> GetPreferredPackages(int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.PackageInfo>);
				}

				/// <summary>
				/// <para>Set the enabled setting for a package component (activity, receiver, service, provider). This setting will override any enabled state which may have been set by the component in its manifest.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setComponentEnabledSetting", "(Landroid/content/ComponentName;II)V", AccessFlags = 1)]
				public override void SetComponentEnabledSetting(global::Android.Content.ComponentName componentName, int newState, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the the enabled setting for a package component (activity, receiver, service, provider). This returns the last value set by setComponentEnabledSetting(ComponentName, int, int); in most cases this value will be COMPONENT_ENABLED_STATE_DEFAULT since the value originally specified in the manifest has not been modified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the current enabled state for the component. May be one of COMPONENT_ENABLED_STATE_ENABLED, COMPONENT_ENABLED_STATE_DISABLED, or COMPONENT_ENABLED_STATE_DEFAULT. The last one means the component's enabled state is based on the original information in the manifest as found in ComponentInfo. </para>
				/// </returns>
				/// <java-name>
				/// getComponentEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getComponentEnabledSetting", "(Landroid/content/ComponentName;)I", AccessFlags = 1)]
				public override int GetComponentEnabledSetting(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Set the enabled setting for an application This setting will override any enabled state which may have been set by the application in its manifest. It also overrides the enabled state set in the manifest for any of the application's components. It does not override any enabled state set by setComponentEnabledSetting for any of the application's components.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("setApplicationEnabledSetting", "(Ljava/lang/String;II)V", AccessFlags = 1)]
				public override void SetApplicationEnabledSetting(string packageName, int newState, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the the enabled setting for an application. This returns the last value set by setApplicationEnabledSetting(String, int, int); in most cases this value will be COMPONENT_ENABLED_STATE_DEFAULT since the value originally specified in the manifest has not been modified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the current enabled state for the component. May be one of COMPONENT_ENABLED_STATE_ENABLED, COMPONENT_ENABLED_STATE_DISABLED, or COMPONENT_ENABLED_STATE_DEFAULT. The last one means the application's enabled state is based on the original information in the manifest as found in ComponentInfo. </para>
				/// </returns>
				/// <java-name>
				/// getApplicationEnabledSetting
				/// </java-name>
				[Dot42.DexImport("getApplicationEnabledSetting", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public override int GetApplicationEnabledSetting(string packageName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This is a protected API that should not have been available to third party applications. It is the platform's responsibility for assigning preferred activities and this cannot be directly modified.</para></xrefdescription></xrefsect></para><para>Add a new preferred activity mapping to the system. This will be used to automatically select the given activity component when Context.startActivity() finds multiple matching activities and also matches the given filter.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addPreferredActivity
				/// </java-name>
				[Dot42.DexImport("addPreferredActivity", "(Landroid/content/IntentFilter;I[Landroid/content/ComponentName;Landroid/content/" +
    "ComponentName;)V", AccessFlags = 1)]
				public override void AddPreferredActivity(global::Android.Content.IntentFilter filter, int match, global::Android.Content.ComponentName[] set, global::Android.Content.ComponentName activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove all preferred activity mappings, previously added with addPreferredActivity, from the system whose activities are implemented in the given package name. An application can only clear its own package(s).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clearPackagePreferredActivities
				/// </java-name>
				[Dot42.DexImport("clearPackagePreferredActivities", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public override void ClearPackagePreferredActivities(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retrieve all preferred activities, previously added with addPreferredActivity, that are currently registered with the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the total number of registered preferred activities (the number of distinct IntentFilter records, not the number of unique activity components) that were found. </para>
				/// </returns>
				/// <java-name>
				/// getPreferredActivities
				/// </java-name>
				[Dot42.DexImport("getPreferredActivities", "(Ljava/util/List;Ljava/util/List;Ljava/lang/String;)I", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/content/IntentFilter;>;Ljava/util/List<Landroid/content" +
    "/ComponentName;>;Ljava/lang/String;)I")]
				public override int GetPreferredActivities(global::Java.Util.IList<global::Android.Content.IntentFilter> outFilters, global::Java.Util.IList<global::Android.Content.ComponentName> outActivities, string packageName) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Get a list of shared libraries that are available on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of shared library names that are available on the system, or null if none are installed. </para>
				/// </returns>
				/// <java-name>
				/// getSystemSharedLibraryNames
				/// </java-name>
				[Dot42.DexImport("getSystemSharedLibraryNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetSystemSharedLibraryNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Get a list of features that are available on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of FeatureInfo classes describing the features that are available on the system, or null if there are none(!!). </para>
				/// </returns>
				/// <java-name>
				/// getSystemAvailableFeatures
				/// </java-name>
				[Dot42.DexImport("getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", AccessFlags = 1)]
				public override global::Android.Content.Pm.FeatureInfo[] GetSystemAvailableFeatures() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.FeatureInfo[]);
				}

				/// <summary>
				/// <para>Check whether the given feature name is one of the available features as returned by getSystemAvailableFeatures().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the devices supports the feature, else false. </para>
				/// </returns>
				/// <java-name>
				/// hasSystemFeature
				/// </java-name>
				[Dot42.DexImport("hasSystemFeature", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public override bool HasSystemFeature(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return whether the device has been booted into safe mode. </para>        
				/// </summary>
				/// <java-name>
				/// isSafeMode
				/// </java-name>
				[Dot42.DexImport("isSafeMode", "()Z", AccessFlags = 1)]
				public override bool IsSafeMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Allows a package listening to the package verification broadcast to respond to the package manager. The response must include the <c> verificationCode </c> which is one of PackageManager#VERIFICATION_ALLOW or PackageManager#VERIFICATION_REJECT.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// verifyPendingInstall
				/// </java-name>
				[Dot42.DexImport("verifyPendingInstall", "(II)V", AccessFlags = 1)]
				public override void VerifyPendingInstall(int id, int verificationCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the generic icon for an activity that is used when no specific icon is defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Drawable Image of the icon. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultActivityIcon
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable DefaultActivityIcon
				{
				[Dot42.DexImport("getDefaultActivityIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetDefaultActivityIcon(); }
				}

				/// <summary>
				/// <para>Get a list of shared libraries that are available on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of shared library names that are available on the system, or null if none are installed. </para>
				/// </returns>
				/// <java-name>
				/// getSystemSharedLibraryNames
				/// </java-name>
				public string[] SystemSharedLibraryNames
				{
				[Dot42.DexImport("getSystemSharedLibraryNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSystemSharedLibraryNames(); }
				}

				/// <summary>
				/// <para>Get a list of features that are available on the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An array of FeatureInfo classes describing the features that are available on the system, or null if there are none(!!). </para>
				/// </returns>
				/// <java-name>
				/// getSystemAvailableFeatures
				/// </java-name>
				public global::Android.Content.Pm.FeatureInfo[] SystemAvailableFeatures
				{
				[Dot42.DexImport("getSystemAvailableFeatures", "()[Landroid/content/pm/FeatureInfo;", AccessFlags = 1)]
						get{ return GetSystemAvailableFeatures(); }
				}

		}

		/// <summary>
		/// <para>Mock implementation of ContentProvider. All methods are non-functional and throw java.lang.UnsupportedOperationException. Tests can extend this class to implement behavior needed for tests. </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockContentProvider
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockContentProvider", AccessFlags = 33)]
		public partial class MockContentProvider : global::Android.Content.ContentProvider
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A constructor using MockContext instance as a Context in it. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal MockContentProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A constructor accepting a Context instance, which is supposed to be the subclasss of MockContext. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MockContentProvider(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A constructor which initialize four member variables which android.content.ContentProvider have internally.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;[Landroid/content/p" +
    "m/PathPermission;)V", AccessFlags = 1)]
				public MockContentProvider(global::Android.Content.Context context, string readPermission, string writePermission, global::Android.Content.Pm.PathPermission[] pathPermissions) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Implement this to handle requests to delete one or more rows. The implementation should apply the selection clause when performing deletion, allowing the operation to affect multiple rows in a directory. As a courtesy, call notifyDelete() after deleting. This method can be called from multiple threads, as described in .</para><para>The implementation is responsible for parsing out a row ID at the end of the URI, if a specific row is being deleted. That is, the client would pass in <code>content://contacts/people/22</code> and the implementation is responsible for parsing the record number (22) when creating a SQL statement.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of rows affected. </para>
				/// </returns>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I", AccessFlags = 1)]
				public override int Delete(global::Android.Net.Uri uri, string selection, string[] selectionArgs) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Implement this to handle requests for the MIME type of the data at the given URI. The returned MIME type should start with <code>vnd.android.cursor.item</code> for a single record, or <code>vnd.android.cursor.dir/</code> for multiple items. This method can be called from multiple threads, as described in .</para><para>Note that there are no permissions needed for an application to access this information; if your content provider requires read and/or write permissions, or is not exported, all applications can still call this method regardless of their access permissions. This allows them to retrieve the MIME type for a URI when dispatching intents.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a MIME type string, or <c> null </c> if there is no type. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(Landroid/net/Uri;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetType(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Implement this to handle requests to insert a new row. As a courtesy, call notifyChange() after inserting. This method can be called from multiple threads, as described in . </para>        
				/// </summary>
				/// <returns>
				/// <para>The URI for the newly inserted item. </para>
				/// </returns>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;", AccessFlags = 1)]
				public override global::Android.Net.Uri Insert(global::Android.Net.Uri uri, global::Android.Content.ContentValues values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				/// <para>Implement this to initialize your content provider on startup. This method is called for all registered content providers on the application main thread at application launch time. It must not perform lengthy operations, or application startup will be delayed.</para><para>You should defer nontrivial initialization (such as opening, upgrading, and scanning databases) until the content provider is used (via query, insert, etc). Deferred initialization keeps application startup fast, avoids unnecessary work if the provider turns out not to be needed, and stops database errors (such as a full disk) from halting application launch.</para><para>If you use SQLite, android.database.sqlite.SQLiteOpenHelper is a helpful utility class that makes it easy to manage databases, and will automatically defer opening until first use. If you do use SQLiteOpenHelper, make sure to avoid calling android.database.sqlite.SQLiteOpenHelper#getReadableDatabase or android.database.sqlite.SQLiteOpenHelper#getWritableDatabase from this method. (Instead, override android.database.sqlite.SQLiteOpenHelper#onOpen to initialize the database when it is first opened.)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the provider was successfully loaded, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()Z", AccessFlags = 1)]
				public override bool OnCreate() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><span>   Implement this to handle query requests from clients.   This method can be called from multiple threads, as described in   &lt;a href="{@docRoot}guide/topics/fundamentals/processes-and-threads.html#Threads"&gt;Processes   and Threads&lt;/a&gt;.   &lt;p&gt;   Example client call:&lt;p&gt;   &lt;pre&gt;// Request a specific record.   Cursor managedCursor = managedQuery(            ContentUris.withAppendedId(Contacts.People.CONTENT_URI, 2),            projection,    // Which columns to return.            null,          // WHERE clause.            null,          // WHERE clause value substitution            People.NAME + " ASC");   // Sort order.&lt;/pre&gt;   Example implementation:&lt;p&gt;   &lt;pre&gt;// SQLiteQueryBuilder is a helper class that creates the</span> proper SQL syntax for us. SQLiteQueryBuilder qBuilder = new SQLiteQueryBuilder();</para><para>Set the table we're querying. qBuilder.setTables(DATABASE_TABLE_NAME);</para><para>If the query ends in a specific record number, we're being asked for a specific record, so set the WHERE clause in our query. if((URI_MATCHER.match(uri)) == SPECIFIC_MESSAGE){ qBuilder.appendWhere("_id=" + uri.getPathLeafId()); }</para><para>Make the query. Cursor c = qBuilder.query(mDb, projection, selection, selectionArgs, groupBy, having, sortOrder); c.setNotificationUri(getContext().getContentResolver(), uri); return c;</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Cursor or <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// query
				/// </java-name>
				[Dot42.DexImport("query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/l" +
    "ang/String;)Landroid/database/Cursor;", AccessFlags = 1)]
				public override global::Android.Database.ICursor Query(global::Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <summary>
				/// <para>Implement this to handle requests to update one or more rows. The implementation should update all rows matching the selection to set the columns according to the provided values map. As a courtesy, call notifyChange() after updating. This method can be called from multiple threads, as described in .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows affected. </para>
				/// </returns>
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
				/// <para>If you're reluctant to implement this manually, please just call super.bulkInsert(). </para>        
				/// </summary>
				/// <java-name>
				/// bulkInsert
				/// </java-name>
				[Dot42.DexImport("bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I", AccessFlags = 1)]
				public override int BulkInsert(global::Android.Net.Uri uri, global::Android.Content.ContentValues[] values) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>After being instantiated, this is called to tell the content provider about itself.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// attachInfo
				/// </java-name>
				[Dot42.DexImport("attachInfo", "(Landroid/content/Context;Landroid/content/pm/ProviderInfo;)V", AccessFlags = 1)]
				public override void AttachInfo(global::Android.Content.Context context, global::Android.Content.Pm.ProviderInfo info) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Override this to handle requests to perform a batch of operations, or the default implementation will iterate over the operations and call ContentProviderOperation#apply on each of them. If all calls to ContentProviderOperation#apply succeed then a ContentProviderResult array with as many elements as there were operations will be returned. If any of the calls fail, it is up to the implementation how many of the others take effect. This method can be called from multiple threads, as described in .</para><para><para>ContentProviderOperation::apply </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the results of the applications </para>
				/// </returns>
				/// <java-name>
				/// applyBatch
				/// </java-name>
				[Dot42.DexImport("applyBatch", "(Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/content/ContentProviderOperation;>;)[Landroid/cont" +
    "ent/ContentProviderResult;")]
				public override global::Android.Content.ContentProviderResult[] ApplyBatch(global::Java.Util.ArrayList<global::Android.Content.ContentProviderOperation> operations) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ContentProviderResult[]);
				}

				/// <summary>
				/// <para>Called by a client to determine the types of data streams that this content provider supports for the given URI. The default implementation returns <c> null </c> , meaning no types. If your content provider stores data of a particular type, return that MIME type if it matches the given mimeTypeFilter. If it can perform type conversions, return an array of all supported MIME types that match mimeTypeFilter.</para><para><para>getType(Uri) </para><simplesectsep></simplesectsep><para>openTypedAssetFile(Uri, String, Bundle) </para><simplesectsep></simplesectsep><para>ClipDescription::compareMimeTypes(String, String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns <c> null </c> if there are no possible data streams for the given mimeTypeFilter. Otherwise returns an array of all available concrete MIME types.</para>
				/// </returns>
				/// <java-name>
				/// getStreamTypes
				/// </java-name>
				[Dot42.DexImport("getStreamTypes", "(Landroid/net/Uri;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetStreamTypes(global::Android.Net.Uri uri, string mimeTypeFilter) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Called by a client to open a read-only stream containing data of a particular MIME type. This is like openAssetFile(Uri, String), except the file can only be read-only and the content provider may perform data conversions to generate data of the desired type.</para><para>The default implementation compares the given mimeType against the result of getType(Uri) and, if they match, simply calls openAssetFile(Uri, String).</para><para>See ClipData for examples of the use and implementation of this method.</para><para>For better interoperability with other applications, it is recommended that for any URIs that can be opened, you also support queries on them containing at least the columns specified by android.provider.OpenableColumns. You may also want to support other common columns if you have additional meta-data to supply, such as android.provider.MediaStore.MediaColumns#DATE_ADDED in android.provider.MediaStore.MediaColumns.</para><para><para>getStreamTypes(Uri, String) </para><simplesectsep></simplesectsep><para>openAssetFile(Uri, String) </para><simplesectsep></simplesectsep><para>ClipDescription::compareMimeTypes(String, String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a new AssetFileDescriptor from which the client can read data of the desired type.</para>
				/// </returns>
				/// <java-name>
				/// openTypedAssetFile
				/// </java-name>
				[Dot42.DexImport("openTypedAssetFile", "(Landroid/net/Uri;Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/res/Asse" +
    "tFileDescriptor;", AccessFlags = 1)]
				public override global::Android.Content.Res.AssetFileDescriptor OpenTypedAssetFile(global::Android.Net.Uri uri, string mimeTypeFilter, global::Android.Os.Bundle opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.AssetFileDescriptor);
				}

		}

		/// <summary>
		/// <para>An extension of android.content.ContentResolver that is designed for testing. </para><para>MockContentResolver overrides Android's normal way of resolving providers by authority. To have access to a provider based on its authority, users of MockContentResolver first instantiate the provider and use MockContentResolver#addProvider(String, ContentProvider). Resolution of an authority occurs entirely within MockContentResolver. </para><para>Users can also set an authority's entry in the map to null, so that a provider is completely mocked out. </para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about application testing, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/test/mock/MockContentResolver
		/// </java-name>
		[Dot42.DexImport("android/test/mock/MockContentResolver", AccessFlags = 33)]
		public partial class MockContentResolver : global::Android.Content.ContentResolver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a local map of providers. This map is used instead of the global map when an API call tries to acquire a provider. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MockContentResolver() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds access to a provider based on its authority</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addProvider
				/// </java-name>
				[Dot42.DexImport("addProvider", "(Ljava/lang/String;Landroid/content/ContentProvider;)V", AccessFlags = 1)]
				public virtual void AddProvider(string name, global::Android.Content.ContentProvider provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Overrides ContentResolver.notifChange(Uri, ContentObserver, boolean). All parameters are ignored. The method hides providers linked to MockContentResolver from other observers in the system.</para><para></para>        
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
		/// <para>A mock android.content.DialogInterface class. All methods are non-functional and throw java.lang.UnsupportedOperationException. Override it to provide the operations that you need. </para>    
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
		/// <para>A mock android.app.Application class. All methods are non-functional and throw java.lang.UnsupportedOperationException. Override it as necessary to provide the operations that you need. </para>    
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

				/// <summary>
				/// <para>Called when the application is starting, before any activity, service, or receiver objects (excluding content providers) have been created. Implementations should be as quick as possible (for example using lazy initialization of state) since the time spent in this function directly impacts the performance of starting the first activity, service, or receiver in a process. If you override this method, be sure to call super.onCreate(). </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is for use in emulated process environments. It will never be called on a production Android device, where processes are removed by simply killing them; no user code (including this callback) is executed when doing so. </para>        
				/// </summary>
				/// <java-name>
				/// onTerminate
				/// </java-name>
				[Dot42.DexImport("onTerminate", "()V", AccessFlags = 1)]
				public override void OnTerminate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by the system when the device configuration changes while your component is running. Note that, unlike activities, other components are never restarted when a configuration changes: they must always deal with the results of the change, such as by re-retrieving resources.</para><para>At the time that this function has been called, your Resources object will have been updated to return resource values matching the new configuration.</para><para></para>        
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
		/// <para>A mock android.database.Cursor class that isolates the test code from real Cursor implementation. </para><para>All methods including ones related to querying the state of the cursor are are non-functional and throw java.lang.UnsupportedOperationException. </para>    
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
				/// <para>Return total number of columns </para>        
				/// </summary>
				/// <returns>
				/// <para>number of columns </para>
				/// </returns>
				/// <java-name>
				/// getColumnCount
				/// </java-name>
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
				public virtual int GetColumnCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the zero-based index for the given column name, or -1 if the column doesn't exist. If you expect the column to exist use getColumnIndexOrThrow(String) instead, which will make the error more clear.</para><para><para>getColumnIndexOrThrow(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the zero-based column index for the given column name, or -1 if the column name does not exist. </para>
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
				/// <para>Returns the zero-based index for the given column name, or throws IllegalArgumentException if the column doesn't exist. If you're not sure if a column will exist or not use getColumnIndex(String) and check for -1, which is more efficient than catching the exceptions.</para><para><para>getColumnIndex(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the zero-based column index for the given column name </para>
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
				/// <para>Returns the column name at the given zero-based column index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the column name for the given column index. </para>
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
				/// <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetColumnNames() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				/// <para>Returns the numbers of rows in the cursor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
				public virtual int GetCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns <code>true</code> if the value in the indicated column is null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the column value is null. </para>
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
				/// <para>Returns the value of the requested column as an int.</para><para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [<code>Integer.MIN_VALUE</code>, <code>Integer.MAX_VALUE</code>] is implementation-defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of that column as an int. </para>
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
				/// <para>Returns the value of the requested column as a long.</para><para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [<code>Long.MIN_VALUE</code>, <code>Long.MAX_VALUE</code>] is implementation-defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of that column as a long. </para>
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
				/// <para>Returns the value of the requested column as a short.</para><para>The result and whether this method throws an exception when the column value is null, the column type is not an integral type, or the integer value is outside the range [<code>Short.MIN_VALUE</code>, <code>Short.MAX_VALUE</code>] is implementation-defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of that column as a short. </para>
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
				/// <para>Returns the value of the requested column as a float.</para><para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a <code>float</code> value is implementation-defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of that column as a float. </para>
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
				/// <para>Returns the value of the requested column as a double.</para><para>The result and whether this method throws an exception when the column value is null, the column type is not a floating-point type, or the floating-point value is not representable as a <code>double</code> value is implementation-defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of that column as a double. </para>
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
				/// <para>Returns the value of the requested column as a byte array.</para><para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of that column as a byte array. </para>
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
				/// <para>Returns the value of the requested column as a byte array.</para><para>The result and whether this method throws an exception when the column value is null or the column type is not a blob type is implementation-defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of that column as a byte array. </para>
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
				/// <para>Returns the value of the requested column as a String.</para><para>The result and whether this method throws an exception when the column value is null or the column type is not a string type is implementation-defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of that column as a String. </para>
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
				/// <para>Returns a bundle of extra values. This is an optional way for cursors to provide out-of-band metadata to their users. One use of this is for reporting on the progress of network requests that are required to fetch data for the cursor.</para><para>These values may only change when requery is called. </para>        
				/// </summary>
				/// <returns>
				/// <para>cursor-defined values, or Bundle.EMPTY if there are no values. Never <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <summary>
				/// <para>Returns the current position of the cursor in the row set. The value is zero-based. When the row set is first returned the cursor will be at positon -1, which is before the first row. After the last row is returned another call to next() will leave the cursor past the last entry, at a position of count().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current cursor position. </para>
				/// </returns>
				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
				public virtual int GetPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns whether the cursor is pointing to the position after the last row.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the cursor is after the last result. </para>
				/// </returns>
				/// <java-name>
				/// isAfterLast
				/// </java-name>
				[Dot42.DexImport("isAfterLast", "()Z", AccessFlags = 1)]
				public virtual bool IsAfterLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the cursor is pointing to the position before the first row.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the cursor is before the first result. </para>
				/// </returns>
				/// <java-name>
				/// isBeforeFirst
				/// </java-name>
				[Dot42.DexImport("isBeforeFirst", "()Z", AccessFlags = 1)]
				public virtual bool IsBeforeFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the cursor is pointing to the first row.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the cursor is pointing at the first entry. </para>
				/// </returns>
				/// <java-name>
				/// isFirst
				/// </java-name>
				[Dot42.DexImport("isFirst", "()Z", AccessFlags = 1)]
				public virtual bool IsFirst() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the cursor is pointing to the last row.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the cursor is pointing at the last entry. </para>
				/// </returns>
				/// <java-name>
				/// isLast
				/// </java-name>
				[Dot42.DexImport("isLast", "()Z", AccessFlags = 1)]
				public virtual bool IsLast() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Move the cursor by a relative amount, forward or backward, from the current position. Positive offsets move forwards, negative offsets move backwards. If the final position is outside of the bounds of the result set then the resultant position will be pinned to -1 or count() depending on whether the value is off the front or end of the set, respectively.</para><para>This method will return true if the requested destination was reachable, otherwise, it returns false. For example, if the cursor is at currently on the second entry in the result set and move(-5) is called, the position will be pinned at -1, and false will be returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the requested move fully succeeded. </para>
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
				/// <para>Move the cursor to the first row.</para><para>This method will return false if the cursor is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the move succeeded. </para>
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
				/// <para>Move the cursor to the last row.</para><para>This method will return false if the cursor is empty.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the move succeeded. </para>
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
				/// <para>Move the cursor to the next row.</para><para>This method will return false if the cursor is already past the last entry in the result set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the move succeeded. </para>
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
				/// <para>Move the cursor to the previous row.</para><para>This method will return false if the cursor is already before the first entry in the result set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the move succeeded. </para>
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
				/// <para>Move the cursor to an absolute position. The valid range of values is -1 &lt;= position &lt;= count.</para><para>This method will return true if the request destination was reachable, otherwise, it returns false.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the requested move fully succeeded. </para>
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
				/// <para>Retrieves the requested column text and stores it in the buffer provided. If the buffer size is not sufficient, a new char buffer will be allocated and assigned to CharArrayBuffer.data </para>        
				/// </summary>
				/// <java-name>
				/// copyStringToBuffer
				/// </java-name>
				[Dot42.DexImport("copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V", AccessFlags = 1)]
				public virtual void CopyStringToBuffer(int columnIndex, global::Android.Database.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Deactivates the Cursor, making all calls on it fail until requery is called. Inactive Cursors use fewer resources than active Cursors. Calling requery will make the cursor active again. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Since requery() is deprecated, so too is this. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// deactivate
				/// </java-name>
				[Dot42.DexImport("deactivate", "()V", AccessFlags = 1)]
				public virtual void Deactivate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Closes the Cursor, releasing all of its resources and making it completely invalid. Unlike deactivate() a call to requery() will not make the Cursor valid again. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>return true if the cursor is closed </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the cursor is closed. </para>
				/// </returns>
				/// <java-name>
				/// isClosed
				/// </java-name>
				[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
				public virtual bool IsClosed() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs the query that created the cursor again, refreshing its contents. This may be done at any time, including after a call to deactivate.</para><para>Since this method could execute a query on the database and potentially take a while, it could cause ANR if it is called on Main (UI) thread. A warning is printed if this method is being executed on Main thread.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Don't use this. Just request a new cursor, so you can do this asynchronously and update your list view once the new cursor comes back. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the requery succeeded, false if not, in which case the cursor becomes invalid. </para>
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
				/// <para>Register an observer that is called when changes happen to the content backing this cursor. Typically the data set won't change until requery() is called.</para><para><para>unregisterContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerContentObserver
				/// </java-name>
				[Dot42.DexImport("registerContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void RegisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Register an observer that is called when changes happen to the contents of the this cursors data set, for example, when the data set is changed via requery(), deactivate(), or close().</para><para><para>unregisterDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This is an out-of-band way for the the user of a cursor to communicate with the cursor. The structure of each bundle is entirely defined by the cursor.</para><para>One use of this is to tell a cursor that it should retry its network request after it reported an error. </para>        
				/// </summary>
				/// <returns>
				/// <para>extra values, or Bundle.EMPTY. Never <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// respond
				/// </java-name>
				[Dot42.DexImport("respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle Respond(global::Android.Os.Bundle extras) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <summary>
				/// <para>onMove() will only be called across processes if this method returns true. </para>        
				/// </summary>
				/// <returns>
				/// <para>whether all cursor movement should result in a call to onMove(). </para>
				/// </returns>
				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
				public virtual bool GetWantsAllOnMoveCalls() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Register to watch a content URI for changes. This can be the URI of a specific data row (for example, "content://my_provider_type/23"), or a a generic URI for a content type.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setNotificationUri
				/// </java-name>
				[Dot42.DexImport("setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetNotificationUri(global::Android.Content.ContentResolver cr, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para><para><para>registerContentObserver(ContentObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterContentObserver
				/// </java-name>
				[Dot42.DexImport("unregisterContentObserver", "(Landroid/database/ContentObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterContentObserver(global::Android.Database.ContentObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregister an observer that has previously been registered with this cursor via registerContentObserver.</para><para><para>registerDataSetObserver(DataSetObserver) </para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver observer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns data type of the given column's value. The preferred type of the column is returned but the data may be converted to other types as documented in the get-type methods such as getInt(int), getFloat(int) etc. </para><para>Returned column types are <ul><li><para>FIELD_TYPE_NULL </para></li><li><para>FIELD_TYPE_INTEGER </para></li><li><para>FIELD_TYPE_FLOAT </para></li><li><para>FIELD_TYPE_STRING </para></li><li><para>FIELD_TYPE_BLOB </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>column value type </para>
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
				/// <para>Return total number of columns </para>        
				/// </summary>
				/// <returns>
				/// <para>number of columns </para>
				/// </returns>
				/// <java-name>
				/// getColumnCount
				/// </java-name>
				public int ColumnCount
				{
				[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						get{ return GetColumnCount(); }
				}

				/// <summary>
				/// <para>Returns a string array holding the names of all of the columns in the result set in the order in which they were listed in the result.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the names of the columns returned in this query. </para>
				/// </returns>
				/// <java-name>
				/// getColumnNames
				/// </java-name>
				public string[] ColumnNames
				{
				[Dot42.DexImport("getColumnNames", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetColumnNames(); }
				}

				/// <summary>
				/// <para>Returns the numbers of rows in the cursor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of rows in the cursor. </para>
				/// </returns>
				/// <java-name>
				/// getCount
				/// </java-name>
				public int Count
				{
				[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return GetCount(); }
				}

				/// <summary>
				/// <para>Returns a bundle of extra values. This is an optional way for cursors to provide out-of-band metadata to their users. One use of this is for reporting on the progress of network requests that are required to fetch data for the cursor.</para><para>These values may only change when requery is called. </para>        
				/// </summary>
				/// <returns>
				/// <para>cursor-defined values, or Bundle.EMPTY if there are no values. Never <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.Os.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				}

				/// <summary>
				/// <para>Returns the current position of the cursor in the row set. The value is zero-based. When the row set is first returned the cursor will be at positon -1, which is before the first row. After the last row is returned another call to next() will leave the cursor past the last entry, at a position of count().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current cursor position. </para>
				/// </returns>
				/// <java-name>
				/// getPosition
				/// </java-name>
				public int Position
				{
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
						get{ return GetPosition(); }
				}

				/// <summary>
				/// <para>onMove() will only be called across processes if this method returns true. </para>        
				/// </summary>
				/// <returns>
				/// <para>whether all cursor movement should result in a call to onMove(). </para>
				/// </returns>
				/// <java-name>
				/// getWantsAllOnMoveCalls
				/// </java-name>
				public bool IsWantsAllOnMoveCalls
				{
				[Dot42.DexImport("getWantsAllOnMoveCalls", "()Z", AccessFlags = 1)]
						get{ return GetWantsAllOnMoveCalls(); }
				}

		}

}


