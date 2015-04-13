#pragma warning disable 1717
namespace Android.App.Backup
{
		/// <java-name>
		/// android/app/backup/BackupAgent
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupAgent", AccessFlags = 1057)]
		public abstract partial class BackupAgent : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_FILE
				/// </java-name>
				[Dot42.DexImport("TYPE_FILE", "I", AccessFlags = 25)]
				public const int TYPE_FILE = 1;
				/// <java-name>
				/// TYPE_DIRECTORY
				/// </java-name>
				[Dot42.DexImport("TYPE_DIRECTORY", "I", AccessFlags = 25)]
				public const int TYPE_DIRECTORY = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BackupAgent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public virtual void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public virtual void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBackup
				/// </java-name>
				[Dot42.DexImport("onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1025)]
				public abstract void OnBackup(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, global::Android.App.Backup.BackupDataOutput backupDataOutput, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onRestore
				/// </java-name>
				[Dot42.DexImport("onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V", AccessFlags = 1025)]
				public abstract void OnRestore(global::Android.App.Backup.BackupDataInput backupDataInput, int int32, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onFullBackup
				/// </java-name>
				[Dot42.DexImport("onFullBackup", "(Landroid/app/backup/FullBackupDataOutput;)V", AccessFlags = 1)]
				public virtual void OnFullBackup(global::Android.App.Backup.FullBackupDataOutput fullBackupDataOutput) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fullBackupFile
				/// </java-name>
				[Dot42.DexImport("fullBackupFile", "(Ljava/io/File;Landroid/app/backup/FullBackupDataOutput;)V", AccessFlags = 17)]
				public void FullBackupFile(global::Java.IO.File file, global::Android.App.Backup.FullBackupDataOutput fullBackupDataOutput) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreFile
				/// </java-name>
				[Dot42.DexImport("onRestoreFile", "(Landroid/os/ParcelFileDescriptor;JLjava/io/File;IJJ)V", AccessFlags = 1)]
				public virtual void OnRestoreFile(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, long int64, global::Java.IO.File file, int int32, long int641, long int642) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// onBackup
				/// </java-name>
				[Dot42.DexImport("onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public override void OnBackup(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, global::Android.App.Backup.BackupDataOutput backupDataOutput, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestore
				/// </java-name>
				[Dot42.DexImport("onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public override void OnRestore(global::Android.App.Backup.BackupDataInput backupDataInput, int int32, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addHelper
				/// </java-name>
				[Dot42.DexImport("addHelper", "(Ljava/lang/String;Landroid/app/backup/BackupHelper;)V", AccessFlags = 1)]
				public virtual void AddHelper(string @string, global::Android.App.Backup.IBackupHelper backupHelper) /* MethodBuilder.Create */ 
				{
				}

		}

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

				/// <java-name>
				/// readNextHeader
				/// </java-name>
				[Dot42.DexImport("readNextHeader", "()Z", AccessFlags = 1)]
				public virtual bool ReadNextHeader() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// readEntityData
				/// </java-name>
				[Dot42.DexImport("readEntityData", "([BII)I", AccessFlags = 1)]
				public virtual int ReadEntityData(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readEntityData
				/// </java-name>
				[Dot42.DexImport("readEntityData", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int ReadEntityData(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// skipEntityData
				/// </java-name>
				[Dot42.DexImport("skipEntityData", "()V", AccessFlags = 1)]
				public virtual void SkipEntityData() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				public virtual string Key
				{
						[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDataSize
				/// </java-name>
				public virtual int DataSize
				{
						[Dot42.DexImport("getDataSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/app/backup/BackupDataInputStream
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupDataInputStream", AccessFlags = 33)]
		public partial class BackupDataInputStream : global::Java.IO.InputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BackupDataInputStream() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([B)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1)]
				public virtual int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				public virtual string Key
				{
						[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

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

				/// <java-name>
				/// writeEntityHeader
				/// </java-name>
				[Dot42.DexImport("writeEntityHeader", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public virtual int WriteEntityHeader(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeEntityData
				/// </java-name>
				[Dot42.DexImport("writeEntityData", "([BI)I", AccessFlags = 1)]
				public virtual int WriteEntityData(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeEntityData
				/// </java-name>
				[Dot42.DexImport("writeEntityData", "([BI)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int WriteEntityData(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/app/backup/BackupManager
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupManager", AccessFlags = 33)]
		public partial class BackupManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public BackupManager(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dataChanged
				/// </java-name>
				[Dot42.DexImport("dataChanged", "()V", AccessFlags = 1)]
				public virtual void DataChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dataChanged
				/// </java-name>
				[Dot42.DexImport("dataChanged", "(Ljava/lang/String;)V", AccessFlags = 9)]
				public static void DataChanged(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestRestore
				/// </java-name>
				[Dot42.DexImport("requestRestore", "(Landroid/app/backup/RestoreObserver;)I", AccessFlags = 1)]
				public virtual int RequestRestore(global::Android.App.Backup.RestoreObserver restoreObserver) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BackupManager() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/app/backup/FileBackupHelper
		/// </java-name>
		[Dot42.DexImport("android/app/backup/FileBackupHelper", AccessFlags = 33)]
		public partial class FileBackupHelper : global::Android.App.Backup.IBackupHelper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;[Ljava/lang/String;)V", AccessFlags = 129)]
				public FileBackupHelper(global::Android.Content.Context context, params string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performBackup
				/// </java-name>
				[Dot42.DexImport("performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public virtual void PerformBackup(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, global::Android.App.Backup.BackupDataOutput backupDataOutput, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restoreEntity
				/// </java-name>
				[Dot42.DexImport("restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V", AccessFlags = 1)]
				public virtual void RestoreEntity(global::Android.App.Backup.BackupDataInputStream backupDataInputStream) /* MethodBuilder.Create */ 
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
				public virtual void WriteNewStateDescription(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FileBackupHelper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

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
				public virtual void WriteNewStateDescription(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/app/backup/FullBackupDataOutput
		/// </java-name>
		[Dot42.DexImport("android/app/backup/FullBackupDataOutput", AccessFlags = 33)]
		public partial class FullBackupDataOutput
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FullBackupDataOutput() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/app/backup/BackupHelper
		/// </java-name>
		[Dot42.DexImport("android/app/backup/BackupHelper", AccessFlags = 1537)]
		public partial interface IBackupHelper
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// performBackup
				/// </java-name>
				[Dot42.DexImport("performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1025)]
				void PerformBackup(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, global::Android.App.Backup.BackupDataOutput backupDataOutput, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// restoreEntity
				/// </java-name>
				[Dot42.DexImport("restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V", AccessFlags = 1025)]
				void RestoreEntity(global::Android.App.Backup.BackupDataInputStream backupDataInputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeNewStateDescription
				/// </java-name>
				[Dot42.DexImport("writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V", AccessFlags = 1025)]
				void WriteNewStateDescription(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ ;

		}

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

				/// <java-name>
				/// restoreStarting
				/// </java-name>
				[Dot42.DexImport("restoreStarting", "(I)V", AccessFlags = 1)]
				public virtual void RestoreStarting(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUpdate
				/// </java-name>
				[Dot42.DexImport("onUpdate", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnUpdate(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restoreFinished
				/// </java-name>
				[Dot42.DexImport("restoreFinished", "(I)V", AccessFlags = 1)]
				public virtual void RestoreFinished(int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/app/backup/SharedPreferencesBackupHelper
		/// </java-name>
		[Dot42.DexImport("android/app/backup/SharedPreferencesBackupHelper", AccessFlags = 33)]
		public partial class SharedPreferencesBackupHelper : global::Android.App.Backup.IBackupHelper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;[Ljava/lang/String;)V", AccessFlags = 129)]
				public SharedPreferencesBackupHelper(global::Android.Content.Context context, params string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performBackup
				/// </java-name>
				[Dot42.DexImport("performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/o" +
    "s/ParcelFileDescriptor;)V", AccessFlags = 1)]
				public virtual void PerformBackup(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, global::Android.App.Backup.BackupDataOutput backupDataOutput, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restoreEntity
				/// </java-name>
				[Dot42.DexImport("restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V", AccessFlags = 1)]
				public virtual void RestoreEntity(global::Android.App.Backup.BackupDataInputStream backupDataInputStream) /* MethodBuilder.Create */ 
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
				public virtual void WriteNewStateDescription(global::Android.OS.ParcelFileDescriptor parcelFileDescriptor) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SharedPreferencesBackupHelper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

