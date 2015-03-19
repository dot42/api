#pragma warning disable 1717
namespace Android.Os.Storage
{
		/// <java-name>
		/// android/os/storage/StorageManager
		/// </java-name>
		[Dot42.DexImport("android/os/storage/StorageManager", AccessFlags = 33)]
		public partial class StorageManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal StorageManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mountObb
				/// </java-name>
				[Dot42.DexImport("mountObb", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/storage/OnObbStateChangeListener" +
    ";)Z", AccessFlags = 1)]
				public virtual bool MountObb(string @string, string string1, global::Android.Os.Storage.OnObbStateChangeListener onObbStateChangeListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unmountObb
				/// </java-name>
				[Dot42.DexImport("unmountObb", "(Ljava/lang/String;ZLandroid/os/storage/OnObbStateChangeListener;)Z", AccessFlags = 1)]
				public virtual bool UnmountObb(string @string, bool boolean, global::Android.Os.Storage.OnObbStateChangeListener onObbStateChangeListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isObbMounted
				/// </java-name>
				[Dot42.DexImport("isObbMounted", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsObbMounted(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMountedObbPath
				/// </java-name>
				[Dot42.DexImport("getMountedObbPath", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMountedObbPath(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/os/storage/OnObbStateChangeListener
		/// </java-name>
		[Dot42.DexImport("android/os/storage/OnObbStateChangeListener", AccessFlags = 1057)]
		public abstract partial class OnObbStateChangeListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MOUNTED
				/// </java-name>
				[Dot42.DexImport("MOUNTED", "I", AccessFlags = 25)]
				public const int MOUNTED = 1;
				/// <java-name>
				/// UNMOUNTED
				/// </java-name>
				[Dot42.DexImport("UNMOUNTED", "I", AccessFlags = 25)]
				public const int UNMOUNTED = 2;
				/// <java-name>
				/// ERROR_INTERNAL
				/// </java-name>
				[Dot42.DexImport("ERROR_INTERNAL", "I", AccessFlags = 25)]
				public const int ERROR_INTERNAL = 20;
				/// <java-name>
				/// ERROR_COULD_NOT_MOUNT
				/// </java-name>
				[Dot42.DexImport("ERROR_COULD_NOT_MOUNT", "I", AccessFlags = 25)]
				public const int ERROR_COULD_NOT_MOUNT = 21;
				/// <java-name>
				/// ERROR_COULD_NOT_UNMOUNT
				/// </java-name>
				[Dot42.DexImport("ERROR_COULD_NOT_UNMOUNT", "I", AccessFlags = 25)]
				public const int ERROR_COULD_NOT_UNMOUNT = 22;
				/// <java-name>
				/// ERROR_NOT_MOUNTED
				/// </java-name>
				[Dot42.DexImport("ERROR_NOT_MOUNTED", "I", AccessFlags = 25)]
				public const int ERROR_NOT_MOUNTED = 23;
				/// <java-name>
				/// ERROR_ALREADY_MOUNTED
				/// </java-name>
				[Dot42.DexImport("ERROR_ALREADY_MOUNTED", "I", AccessFlags = 25)]
				public const int ERROR_ALREADY_MOUNTED = 24;
				/// <java-name>
				/// ERROR_PERMISSION_DENIED
				/// </java-name>
				[Dot42.DexImport("ERROR_PERMISSION_DENIED", "I", AccessFlags = 25)]
				public const int ERROR_PERMISSION_DENIED = 25;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OnObbStateChangeListener() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onObbStateChange
				/// </java-name>
				[Dot42.DexImport("onObbStateChange", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void OnObbStateChange(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

}

