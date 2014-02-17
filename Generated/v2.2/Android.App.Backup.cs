// Copyright (C) 2014 dot42
//
// Original filename: Android.App.Backup.cs
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
namespace Android.App.Backup
{
		/// <summary>
		/// <para>Provides the structured interface through which a BackupAgent commits information to the backup data set, via its onBackup() method. Data written for backup is presented as a set of "entities," key/value pairs in which each binary data record "value" is named with a string "key." </para><para>To commit a data record to the backup transport, the agent's onBackup() method first writes an "entity header" that supplies the key string for the record and the total size of the binary value for the record. After the header has been written, the agent then writes the binary entity value itself. The entity value can be written in multiple chunks if desired, as long as the total count of bytes written matches what was supplied to writeEntityHeader(). </para><para>Entity key strings are considered to be unique within a given application's backup data set. If a backup agent writes a new entity under an existing key string, its value will replace any previous value in the transport's remote data store. You can remove a record entirely from the remote data set by writing a new entity header using the existing record's key, but supplying a negative <code>dataSize</code> parameter. When you do so, the agent does not need to call writeEntityData(byte[], int). <h3>Example</h3></para><para>Here is an example illustrating a way to back up the value of a String variable called <code>mStringToBackUp</code>: <pre>
		///    static final String MY_STRING_KEY = "storedstring";
		/// 
		///    public void onBackup(ParcelFileDescriptor oldState, BackupDataOutput data, ParcelFileDescriptor newState)
		///            throws IOException {
		///        ...
		///        byte[] stringBytes = mStringToBackUp.getBytes();
		///        data.writeEntityHeader(MY_STRING_KEY, stringBytes.length);
		///        data.writeEntityData(stringBytes, stringBytes.length);
		///        ...
		///    }</pre></para><para><para>BackupAgent </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/BackupDataOutput
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupDataOutput", AccessFlags = 33)]
		public partial class BackupDataOutput
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BackupDataOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Mark the beginning of one record in the backup data stream. This must be called before writeEntityData. </para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes written to the backup stream </para>
				/// </returns>
				/// <java-name>
				/// writeEntityHeader
				/// </java-name>
				[Dot42.DexImport("writeEntityHeader", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int WriteEntityHeader(string key, int dataSize) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Write a chunk of data under the current entity to the backup transport. </para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written </para>
				/// </returns>
				/// <java-name>
				/// writeEntityData
				/// </java-name>
				[Dot42.DexImport("writeEntityData", "([BI)I", AccessFlags = 1)]
				public virtual int WriteEntityData(sbyte[] data, int size) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Write a chunk of data under the current entity to the backup transport. </para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written </para>
				/// </returns>
				/// <java-name>
				/// writeEntityData
				/// </java-name>
				[Dot42.DexImport("writeEntityData", "([BI)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int WriteEntityData(byte[] data, int size) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>Base class for the android.app.backup.FileBackupHelper implementation. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/FileBackupHelperBase
		/// </java-name>
		[Dot42.DexImport("android/app/backup/FileBackupHelperBase", AccessFlags = 32)]
		internal partial class FileBackupHelperBase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FileBackupHelperBase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FileBackupHelperBase() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeNewStateDescription
				/// </java-name>
				[Dot42.DexImport("writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public virtual void WriteNewStateDescription(global::Android.Os.ParcelFileDescriptor fd) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Provides the central interface between an application and Android's data backup infrastructure. An application that wishes to participate in the backup and restore mechanism will declare a subclass of android.app.backup.BackupAgent, implement the onBackup() and onRestore() methods, and provide the name of its backup agent class in its <c> AndroidManifest.xml </c> file via the <code> </code> tag's <c> android:backupAgent </c> attribute.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using BackupAgent, read the  developer guide.</para><para></para><para><h3>Basic Operation</h3></para><para>When the application makes changes to data that it wishes to keep backed up, it should call the BackupManager.dataChanged() method. This notifies the Android Backup Manager that the application needs an opportunity to update its backup image. The Backup Manager, in turn, schedules a backup pass to be performed at an opportune time. </para><para>Restore operations are typically performed only when applications are first installed on a device. At that time, the operating system checks to see whether there is a previously-saved data set available for the application being installed, and if so, begins an immediate restore pass to deliver the backup data as part of the installation process. </para><para>When a backup or restore pass is run, the application's process is launched (if not already running), the manifest-declared backup agent class (in the <c>   android:backupAgent </c> attribute) is instantiated within that process, and the agent's onCreate() method is invoked. This prepares the agent instance to run the actual backup or restore logic. At this point the agent's onBackup() or onRestore() method will be invoked as appropriate for the operation being performed. </para><para>A backup data set consists of one or more "entities," flattened binary data records that are each identified with a key string unique within the data set. Adding a record to the active data set or updating an existing record is done by simply writing new entity data under the desired key. Deleting an entity from the data set is done by writing an entity under that key with header specifying a negative data size, and no actual entity data. </para><para><b>Helper Classes</b> </para><para>An extensible agent based on convenient helper classes is available in android.app.backup.BackupAgentHelper. That class is particularly suited to handling of simple file or android.content.SharedPreferences backup and restore.</para><para><para>android.app.backup.BackupManager </para><simplesectsep></simplesectsep><para>android.app.backup.BackupAgentHelper </para><simplesectsep></simplesectsep><para>android.app.backup.BackupDataInput </para><simplesectsep></simplesectsep><para>android.app.backup.BackupDataOutput </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/BackupAgent
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupAgent", AccessFlags = 1057)]
		public abstract partial class BackupAgent : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BackupAgent() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Provided as a convenience for agent implementations that need an opportunity to do one-time initialization before the actual backup or restore operation is begun. </para><para>Agents do not need to override this method. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public virtual void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Provided as a convenience for agent implementations that need to do some sort of shutdown process after backup or restore is completed. </para><para>Agents do not need to override this method. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The application is being asked to write any data changed since the last time it performed a backup operation. The state data recorded during the last backup pass is provided in the <code>oldState</code> file descriptor. If <code>oldState</code> is <code>null</code>, no old state is available and the application should perform a full backup. In both cases, a representation of the final backup state after this pass should be written to the file pointed to by the file descriptor wrapped in <code>newState</code>. </para><para>Each entity written to the android.app.backup.BackupDataOutput <code>data</code> stream will be transmitted over the current backup transport and stored in the remote data set under the key supplied as part of the entity. Writing an entity with a negative data size instructs the transport to delete whatever entity currently exists under that key from the remote data set.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onBackup
				/// </java-name>
				[Dot42.DexImport("onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1025)]
				public abstract void OnBackup(global::Android.Os.ParcelFileDescriptor oldState, global::Android.App.Backup.BackupDataOutput data, global::Android.Os.ParcelFileDescriptor newState) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The application is being restored from backup and should replace any existing data with the contents of the backup. The backup data is provided through the <code>data</code> parameter. Once the restore is finished, the application should write a representation of the final state to the <code>newState</code> file descriptor. </para><para>The application is responsible for properly erasing its old data and replacing it with the data supplied to this method. No "clear user data" operation will be performed automatically by the operating system. The exception to this is in the case of a failed restore attempt: if onRestore() throws an exception, the OS will assume that the application's data may now be in an incoherent state, and will clear it before proceeding.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onRestore
				/// </java-name>
				[Dot42.DexImport("onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V", AccessFlags = 1025)]
				public abstract void OnRestore(global::Android.App.Backup.BackupDataInput data, int appVersionCode, global::Android.Os.ParcelFileDescriptor newState) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A helper class that can be used in conjunction with android.app.backup.BackupAgentHelper to manage the backup of android.content.SharedPreferences. Whenever a backup is performed, it will back up all named shared preferences that have changed since the last backup operation. </para><para>To use this class, the application's backup agent class should extend android.app.backup.BackupAgentHelper. Then, in the agent's BackupAgent#onCreate() method, an instance of this class should be allocated and installed as a backup/restore handler within the BackupAgentHelper framework. For example, an agent supporting backup and restore for an application with two groups of android.content.SharedPreferences data might look something like this: <pre>
		///    import android.app.backup.BackupAgentHelper;
		///    import android.app.backup.SharedPreferencesBackupHelper;
		/// 
		///    public class MyBackupAgent extends BackupAgentHelper {
		///        // The names of the SharedPreferences groups that the application maintains.  These
		///        // are the same strings that are passed to Context#getSharedPreferences(String, int).
		///        static final String PREFS_DISPLAY = "displayprefs";
		///        static final String PREFS_SCORES = "highscores";
		/// 
		///        // An arbitrary string used within the BackupAgentHelper implementation to
		///        // identify the SharedPreferenceBackupHelper's data.
		///        static final String MY_PREFS_BACKUP_KEY = "myprefs";
		/// 
		///        // Simply allocate a helper and install it
		///        void onCreate() {
		///            SharedPreferencesBackupHelper helper =
		///                    new SharedPreferencesBackupHelper(this, PREFS_DISPLAY, PREFS_SCORES);
		///            addHelper(MY_PREFS_BACKUP_KEY, helper);
		///        }
		///    }</pre> </para><para>No further implementation is needed; the BackupAgentHelper mechanism automatically dispatches the BackupAgent.onBackup() and BackupAgent.onRestore() callbacks to the SharedPreferencesBackupHelper as appropriate. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/SharedPreferencesBackupHelper
		/// </java-name>
		[Dot42.DexImport("android/app/backup/SharedPreferencesBackupHelper", AccessFlags = 33)]
		public partial class SharedPreferencesBackupHelper : global::Android.App.Backup.IBackupHelper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a helper for backing up and restoring the android.content.SharedPreferences under the given names.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;[Ljava/lang/String;)V", AccessFlags = 129)]
				public SharedPreferencesBackupHelper(global::Android.Content.Context context, params string[] prefGroups) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Backs up the configured android.content.SharedPreferences groups. </para>        
				/// </summary>
				/// <java-name>
				/// performBackup
				/// </java-name>
				[Dot42.DexImport("performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public virtual void PerformBackup(global::Android.Os.ParcelFileDescriptor oldState, global::Android.App.Backup.BackupDataOutput data, global::Android.Os.ParcelFileDescriptor newState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Restores one entity from the restore data stream to its proper shared preferences file store. </para>        
				/// </summary>
				/// <java-name>
				/// restoreEntity
				/// </java-name>
				[Dot42.DexImport("restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V", AccessFlags = 1)]
				public virtual void RestoreEntity(global::Android.App.Backup.BackupDataInputStream data) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~SharedPreferencesBackupHelper() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeNewStateDescription
				/// </java-name>
				[Dot42.DexImport("writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public virtual void WriteNewStateDescription(global::Android.Os.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SharedPreferencesBackupHelper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Provides an java.io.InputStream-like interface for accessing an entity's data during a restore operation. Used by BackupHelper classes within the BackupAgentHelper mechanism. </para><para>When BackupHelper.restoreEntity() is called, the current entity's header has already been read from the underlying BackupDataInput. The entity's key string and total data size are available through this class's getKey() and size() methods, respectively. </para><para><b>Note:</b> The caller should take care not to seek or close the underlying data source, nor read more than size() bytes from the stream.</para><para><para>BackupAgentHelper </para><simplesectsep></simplesectsep><para>BackupHelper </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/BackupDataInputStream
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupDataInputStream", AccessFlags = 33)]
		public partial class BackupDataInputStream : global::Java.Io.InputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BackupDataInputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Read one byte of entity data from the stream, returning it as an integer value. If more than size() bytes of data are read from the stream, the output of this method is undefined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The byte read, or undefined if the end of the stream has been reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read up to <c> size </c> bytes of data into a byte array, beginning at position <c> offset </c> within the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes of data read, or zero if all of the entity's data has already been read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] b, int offset, int size) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read up to <c> size </c> bytes of data into a byte array, beginning at position <c> offset </c> within the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes of data read, or zero if all of the entity's data has already been read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] b, int offset, int size) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read enough entity data into a byte array to fill the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes of data read, or zero if all of the entity's data has already been read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(sbyte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read enough entity data into a byte array to fill the array.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes of data read, or zero if all of the entity's data has already been read. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] b) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Report the key string associated with this entity within the backup data set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The key string for this entity, equivalent to calling BackupDataInput#getKey() on the underlying BackupDataInput. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetKey() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Report the total number of bytes of data available for the current entity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of data bytes available, equivalent to calling BackupDataInput#getDataSize() on the underlying BackupDataInput. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Report the key string associated with this entity within the backup data set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The key string for this entity, equivalent to calling BackupDataInput#getKey() on the underlying BackupDataInput. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				public string Key
				{
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetKey(); }
				}

		}

		/// <summary>
		/// <para>A convenient BackupAgent wrapper class that automatically manages heterogeneous data sets within the backup data, each identified by a unique key prefix. When processing a backup or restore operation, the BackupAgentHelper dispatches to one or more installed BackupHelper objects, each of which is responsible for a defined subset of the data being processed. </para><para>An application will typically extend this class in its own backup agent. Then, within the agent's onCreate() method, it will call addHelper() one or more times to install the handlers for each kind of data it wishes to manage within its backups. </para><para>The Android framework currently provides two predefined BackupHelper classes:</para><para><ul><li><para>FileBackupHelper - Manages the backup and restore of entire files within an application's data directory hierarchy. </para></li><li><para>SharedPreferencesBackupHelper - Manages the backup and restore of an application's android.content.SharedPreferences data.</para></li></ul></para><para>An application can also implement its own helper classes to work within the BackupAgentHelper framework. See the BackupHelper interface documentation for details.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using BackupAgentHelper, read the  developer guide.</para><para> </para><para><para>BackupHelper </para><simplesectsep></simplesectsep><para>FileBackupHelper </para><simplesectsep></simplesectsep><para>SharedPreferencesBackupHelper </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/BackupAgentHelper
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupAgentHelper", AccessFlags = 33)]
		public partial class BackupAgentHelper : global::Android.App.Backup.BackupAgent
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BackupAgentHelper() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Run the backup process on each of the configured handlers. </para>        
				/// </summary>
				/// <java-name>
				/// onBackup
				/// </java-name>
				[Dot42.DexImport("onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public override void OnBackup(global::Android.Os.ParcelFileDescriptor oldState, global::Android.App.Backup.BackupDataOutput data, global::Android.Os.ParcelFileDescriptor newState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Run the restore process on each of the configured handlers. </para>        
				/// </summary>
				/// <java-name>
				/// onRestore
				/// </java-name>
				[Dot42.DexImport("onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public override void OnRestore(global::Android.App.Backup.BackupDataInput data, int appVersionCode, global::Android.Os.ParcelFileDescriptor newState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Add a helper for a given data subset to the agent's configuration. Each helper must have a prefix string that is unique within this backup agent's set of helpers.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addHelper
				/// </java-name>
				[Dot42.DexImport("addHelper", "(Ljava/lang/String;Landroid/app/backup/BackupHelper;)V", AccessFlags = 1)]
				public virtual void AddHelper(string keyPrefix, global::Android.App.Backup.IBackupHelper helper) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The interface through which an application interacts with the Android backup service to request backup and restore operations. Applications instantiate it using the constructor and issue calls through that instance. </para><para>When an application has made changes to data which should be backed up, a call to dataChanged() will notify the backup service. The system will then schedule a backup operation to occur in the near future. Repeated calls to dataChanged() have no further effect until the backup operation actually occurs. </para><para>A backup or restore operation for your application begins when the system launches the android.app.backup.BackupAgent subclass you've declared in your manifest. See the documentation for android.app.backup.BackupAgent for a detailed description of how the operation then proceeds. </para><para>Several attributes affecting the operation of the backup and restore mechanism can be set on the <code> </code> tag in your application's AndroidManifest.xml file.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about using BackupManager, read the  developer guide.</para><para></para><para>ref android.R.styleable::AndroidManifestApplication_allowBackup  ref android.R.styleable::AndroidManifestApplication_backupAgent  ref android.R.styleable::AndroidManifestApplication_killAfterRestore  ref android.R.styleable::AndroidManifestApplication_restoreAnyVersion </para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/BackupManager
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupManager", AccessFlags = 33)]
		public partial class BackupManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a BackupManager object through which the application can communicate with the Android backup system.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public BackupManager(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies the Android backup system that your application wishes to back up new changes to its data. A backup operation using your application's android.app.backup.BackupAgent subclass will be scheduled when you call this method. </para>        
				/// </summary>
				/// <java-name>
				/// dataChanged
				/// </java-name>
				[Dot42.DexImport("dataChanged", "()V", AccessFlags = 1)]
				public virtual void DataChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Convenience method for callers who need to indicate that some other package needs a backup pass. This can be useful in the case of groups of packages that share a uid. </para><para>This method requires that the application hold the "android.permission.BACKUP" permission if the package named in the argument does not run under the same uid as the caller.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// dataChanged
				/// </java-name>
				[Dot42.DexImport("dataChanged", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void DataChanged(string packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Restore the calling application from backup. The data will be restored from the current backup dataset if the application has stored data there, or from the dataset used during the last full device setup operation if the current backup dataset has no matching data. If no backup data exists for this application in either source, a nonzero value will be returned.</para><para>If this method returns zero (meaning success), the OS will attempt to retrieve a backed-up dataset from the remote transport, instantiate the application's backup agent, and pass the dataset to the agent's onRestore() method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Zero on success; nonzero on error. </para>
				/// </returns>
				/// <java-name>
				/// requestRestore
				/// </java-name>
				[Dot42.DexImport("requestRestore", "(Landroid/app/backup/RestoreObserver;)I", AccessFlags = 1)]
				public virtual int RequestRestore(global::Android.App.Backup.RestoreObserver observer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BackupManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Provides the structured interface through which a BackupAgent reads information from the backup data set, via its onRestore() method. The data is presented as a set of "entities," each representing one named record as previously stored by the agent's onBackup() implementation. An entity is composed of a descriptive header plus a byte array that holds the raw data saved in the remote backup. </para><para>The agent must consume every entity in the data stream, otherwise the restored state of the application will be incomplete. <h3>Example</h3></para><para>A typical onRestore() implementation might be structured something like this: <pre>
		///    public void onRestore(BackupDataInput data, int appVersionCode,
		///                          ParcelFileDescriptor newState) {
		///        while (data.readNextHeader()) {
		///            String key = data.getKey();
		///            int dataSize = data.getDataSize();
		/// 
		///            if (key.equals(MY_BACKUP_KEY_ONE)) {
		///                // process this kind of record here
		///                byte[] buffer = new byte[dataSize];
		///                data.readEntityData(buffer, 0, dataSize); // reads the entire entity at once
		/// 
		///                // now 'buffer' holds the raw data and can be processed however
		///                // the agent wishes
		///                processBackupKeyOne(buffer);
		///            } else if (key.equals(MY_BACKUP_KEY_TO_IGNORE) {
		///                // a key we recognize but wish to discard
		///                data.skipEntityData();
		///            } // ... etc.
		///       }
		///    }</pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/BackupDataInput
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupDataInput", AccessFlags = 33)]
		public partial class BackupDataInput
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BackupDataInput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Extract the next entity header from the restore stream. After this method return success, the getKey() and getDataSize() methods can be used to inspect the entity that is now available for processing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> when there is an entity ready for consumption from the restore stream, <code>false</code> if the restore stream has been fully consumed. </para>
				/// </returns>
				/// <java-name>
				/// readNextHeader
				/// </java-name>
				[Dot42.DexImport("readNextHeader", "()Z", AccessFlags = 1)]
				public virtual bool ReadNextHeader() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Report the key associated with the current entity in the restore stream </para>        
				/// </summary>
				/// <returns>
				/// <para>the current entity's key string </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetKey() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Report the size in bytes of the data associated with the current entity in the restore stream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The size of the record's raw data, in bytes </para>
				/// </returns>
				/// <java-name>
				/// getDataSize
				/// </java-name>
				[Dot42.DexImport("getDataSize", "()I", AccessFlags = 1)]
				public virtual int GetDataSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read a record's raw data from the restore stream. The record's header must first have been processed by the readNextHeader() method. Multiple calls to this method may be made in order to process the data in chunks; not all of it must be read in a single call. Once all of the raw data for the current entity has been read, further calls to this method will simply return zero.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes of data read. Once all of the data for this entity has been read, further calls to this method will return zero. </para>
				/// </returns>
				/// <java-name>
				/// readEntityData
				/// </java-name>
				[Dot42.DexImport("readEntityData", "([BII)I", AccessFlags = 1)]
				public virtual int ReadEntityData(sbyte[] data, int offset, int size) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Read a record's raw data from the restore stream. The record's header must first have been processed by the readNextHeader() method. Multiple calls to this method may be made in order to process the data in chunks; not all of it must be read in a single call. Once all of the raw data for the current entity has been read, further calls to this method will simply return zero.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of bytes of data read. Once all of the data for this entity has been read, further calls to this method will return zero. </para>
				/// </returns>
				/// <java-name>
				/// readEntityData
				/// </java-name>
				[Dot42.DexImport("readEntityData", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int ReadEntityData(byte[] data, int offset, int size) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Consume the current entity's data without extracting it into a buffer for further processing. This allows a android.app.backup.BackupAgent to efficiently discard obsolete or otherwise uninteresting records during the restore operation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// skipEntityData
				/// </java-name>
				[Dot42.DexImport("skipEntityData", "()V", AccessFlags = 1)]
				public virtual void SkipEntityData() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report the key associated with the current entity in the restore stream </para>        
				/// </summary>
				/// <returns>
				/// <para>the current entity's key string </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				public string Key
				{
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetKey(); }
				}

				/// <summary>
				/// <para>Report the size in bytes of the data associated with the current entity in the restore stream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The size of the record's raw data, in bytes </para>
				/// </returns>
				/// <java-name>
				/// getDataSize
				/// </java-name>
				public int DataSize
				{
				[Dot42.DexImport("getDataSize", "()I", AccessFlags = 1)]
						get{ return GetDataSize(); }
				}

		}

		/// <summary>
		/// <para>Callback class for receiving progress reports during a restore operation. These methods will all be called on your application's main thread. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/RestoreObserver
		/// </java-name>
		[Dot42.DexImport("android/app/backup/RestoreObserver", AccessFlags = 1057)]
		public abstract partial class RestoreObserver
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RestoreObserver() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The restore operation has begun.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// restoreStarting
				/// </java-name>
				[Dot42.DexImport("restoreStarting", "(I)V", AccessFlags = 1)]
				public virtual void RestoreStarting(int numPackages) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>An indication of which package is being restored currently, out of the total number provided in the restoreStarting(int) callback. This method is not guaranteed to be called: if the transport is unable to obtain data for one or more of the requested packages, no onUpdate() call will occur for those packages.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onUpdate
				/// </java-name>
				[Dot42.DexImport("onUpdate", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnUpdate(int nowBeingRestored, string currentPackage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The restore process has completed. This method will always be called, even if no individual package restore operations were attempted.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// restoreFinished
				/// </java-name>
				[Dot42.DexImport("restoreFinished", "(I)V", AccessFlags = 1)]
				public virtual void RestoreFinished(int error) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A helper class that can be used in conjunction with android.app.backup.BackupAgentHelper to manage the backup of a set of files. Whenever backup is performed, all files changed since the last backup will be saved in their entirety. When backup first occurs, every file in the list provided to FileBackupHelper will be backed up. </para><para>During restore, if the helper encounters data for a file that was not specified when the FileBackupHelper object was constructed, that data will be ignored. </para><para><b>Note:</b> This should be used only with small configuration files, not large binary files. </para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/FileBackupHelper
		/// </java-name>
		[Dot42.DexImport("android/app/backup/FileBackupHelper", AccessFlags = 33)]
		public partial class FileBackupHelper : global::Android.App.Backup.IBackupHelper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a helper to manage backup/restore of entire files within the application's data directory hierarchy.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;[Ljava/lang/String;)V", AccessFlags = 129)]
				public FileBackupHelper(global::Android.Content.Context context, params string[] files) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Based on <code>oldState</code>, determine which of the files from the application's data directory need to be backed up, write them to the data stream, and fill in <code>newState</code> with the state as it exists now. When <code>oldState</code> is <code>null</code>, all the files will be backed up. </para><para>This should only be called directly from within the BackupAgentHelper implementation. See android.app.backup.BackupAgent#onBackup(ParcelFileDescriptor, BackupDataOutput, ParcelFileDescriptor) for a description of parameter meanings. </para>        
				/// </summary>
				/// <java-name>
				/// performBackup
				/// </java-name>
				[Dot42.DexImport("performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public virtual void PerformBackup(global::Android.Os.ParcelFileDescriptor oldState, global::Android.App.Backup.BackupDataOutput data, global::Android.Os.ParcelFileDescriptor newState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Restore one record [representing a single file] from the restore dataset. </para><para>This should only be called directly from within the BackupAgentHelper implementation. </para>        
				/// </summary>
				/// <java-name>
				/// restoreEntity
				/// </java-name>
				[Dot42.DexImport("restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V", AccessFlags = 1)]
				public virtual void RestoreEntity(global::Android.App.Backup.BackupDataInputStream data) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~FileBackupHelper() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeNewStateDescription
				/// </java-name>
				[Dot42.DexImport("writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public virtual void WriteNewStateDescription(global::Android.Os.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileBackupHelper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines the calling interface that BackupAgentHelper uses when dispatching backup and restore operations to the installed helpers. Applications can define and install their own helpers as well as using those provided as part of the Android framework. </para><para>Although multiple helper objects may be installed simultaneously, each helper is responsible only for handling its own data, and will not see entities created by other components within the backup system. Invocations of multiple helpers are performed sequentially by the BackupAgentHelper, with each helper given a chance to access its own saved state from within the state record produced during the previous backup operation.</para><para><para>BackupAgentHelper </para><simplesectsep></simplesectsep><para>FileBackupHelper </para><simplesectsep></simplesectsep><para>SharedPreferencesBackupHelper </para></para>    
		/// </summary>
		/// <java-name>
		/// android/app/backup/BackupHelper
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupHelper", AccessFlags = 1537)]
		public partial interface IBackupHelper
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Based on <code>oldState</code>, determine which of the files from the application's data directory need to be backed up, write them to <code>data</code>, and fill in <code>newState</code> with the state as it exists now. </para><para>Implementing this method is much like implementing onBackup()  the method parameters are the same. When this method is invoked the <c> oldState </c> descriptor points to the beginning of the state data written during this helper's previous backup operation, and the <c> newState </c> descriptor points to the file location at which the helper should write its new state after performing the backup operation. </para><para><b>Note:</b> The helper should not close or seek either the <c> oldState </c> or the <c> newState </c> file descriptors.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// performBackup
				/// </java-name>
				[Dot42.DexImport("performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1025)]
				void PerformBackup(global::Android.Os.ParcelFileDescriptor oldState, global::Android.App.Backup.BackupDataOutput data, global::Android.Os.ParcelFileDescriptor newState) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by BackupAgentHelper to restore a single entity from the restore data set. This method will be called for each entity in the data set that belongs to this handler. </para><para><b>Note:</b> Do not close the <code>data</code> stream. Do not read more than size() bytes from <code>data</code>.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// restoreEntity
				/// </java-name>
				[Dot42.DexImport("restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V", AccessFlags = 1025)]
				void RestoreEntity(global::Android.App.Backup.BackupDataInputStream data) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by BackupAgentHelper after a restore operation to write the backup state file corresponding to the data as processed by the helper. The data written here will be available to the helper during the next call to its performBackup() method. </para><para>This method will be called even if the handler's restoreEntity() method was never invoked during the restore operation. </para><para><b>Note:</b> The helper should not close or seek the <c> newState </c> file descriptor.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeNewStateDescription
				/// </java-name>
				[Dot42.DexImport("writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1025)]
				void WriteNewStateDescription(global::Android.Os.ParcelFileDescriptor newState) /* MethodBuilder.Create */ ;

		}

}


