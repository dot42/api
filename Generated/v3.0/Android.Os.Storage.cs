// Copyright (C) 2014 dot42
//
// Original filename: Android.Os.Storage.cs
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
namespace Android.Os.Storage
{
		/// <summary>
		/// <para>StorageManager is the interface to the systems storage service. The storage manager handles storage-related items such as Opaque Binary Blobs (OBBs). </para><para>OBBs contain a filesystem that maybe be encrypted on disk and mounted on-demand from an application. OBBs are a good way of providing large amounts of binary assets without packaging them into APKs as they may be multiple gigabytes in size. However, due to their size, they're most likely stored in a shared storage pool accessible from all programs. The system does not guarantee the security of the OBB file itself: if any program modifies the OBB, there is no guarantee that a read from that OBB will produce the expected output. </para><para>Get an instance of this class by calling android.content.Context#getSystemService(java.lang.String) with an argument of android.content.Context#STORAGE_SERVICE. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Mount an Opaque Binary Blob (OBB) file. If a <code>key</code> is specified, it is supplied to the mounting process to be used in any encryption used in the OBB. </para><para>The OBB will remain mounted for as long as the StorageManager reference is held by the application. As soon as this reference is lost, the OBBs in use will be unmounted. The OnObbStateChangeListener registered with this call will receive the success or failure of this operation. </para><para><b>Note:</b> you can only mount OBB files for which the OBB tag on the file matches a package ID that is owned by the calling program's UID. That is, shared UID applications can attempt to mount any other application's OBB that shares its UID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the mount call was successfully queued or not </para>
				/// </returns>
				/// <java-name>
				/// mountObb
				/// </java-name>
				[Dot42.DexImport("mountObb", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/storage/OnObbStateChangeListener" +
    ";)Z", AccessFlags = 1)]
				public virtual bool MountObb(string rawPath, string key, global::Android.Os.Storage.OnObbStateChangeListener listener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Unmount an Opaque Binary Blob (OBB) file asynchronously. If the <code>force</code> flag is true, it will kill any application needed to unmount the given OBB (even the calling application). </para><para>The OnObbStateChangeListener registered with this call will receive the success or failure of this operation. </para><para><b>Note:</b> you can only mount OBB files for which the OBB tag on the file matches a package ID that is owned by the calling program's UID. That is, shared UID applications can obtain access to any other application's OBB that shares its UID. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the unmount call was successfully queued or not </para>
				/// </returns>
				/// <java-name>
				/// unmountObb
				/// </java-name>
				[Dot42.DexImport("unmountObb", "(Ljava/lang/String;ZLandroid/os/storage/OnObbStateChangeListener;)Z", AccessFlags = 1)]
				public virtual bool UnmountObb(string rawPath, bool force, global::Android.Os.Storage.OnObbStateChangeListener listener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Check whether an Opaque Binary Blob (OBB) is mounted or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if OBB is mounted; false if not mounted or on error </para>
				/// </returns>
				/// <java-name>
				/// isObbMounted
				/// </java-name>
				[Dot42.DexImport("isObbMounted", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool IsObbMounted(string rawPath) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Check the mounted path of an Opaque Binary Blob (OBB) file. This will give you the path to where you can obtain access to the internals of the OBB.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>absolute path to mounted OBB image data or <code>null</code> if not mounted or exception encountered trying to read status </para>
				/// </returns>
				/// <java-name>
				/// getMountedObbPath
				/// </java-name>
				[Dot42.DexImport("getMountedObbPath", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMountedObbPath(string rawPath) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>Used for receiving notifications from StorageManager about OBB file states. </para>    
		/// </summary>
		/// <java-name>
		/// android/os/storage/OnObbStateChangeListener
		/// </java-name>
		[Dot42.DexImport("android/os/storage/OnObbStateChangeListener", AccessFlags = 1057)]
		public abstract partial class OnObbStateChangeListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The OBB container is now mounted and ready for use. Returned in status messages from calls made via StorageManager </para>        
				/// </summary>
				/// <java-name>
				/// MOUNTED
				/// </java-name>
				[Dot42.DexImport("MOUNTED", "I", AccessFlags = 25)]
				public const int MOUNTED = 1;
				/// <summary>
				/// <para>The OBB container is now unmounted and not usable. Returned in status messages from calls made via StorageManager </para>        
				/// </summary>
				/// <java-name>
				/// UNMOUNTED
				/// </java-name>
				[Dot42.DexImport("UNMOUNTED", "I", AccessFlags = 25)]
				public const int UNMOUNTED = 2;
				/// <summary>
				/// <para>There was an internal system error encountered while trying to mount the OBB. Returned in status messages from calls made via StorageManager </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_INTERNAL
				/// </java-name>
				[Dot42.DexImport("ERROR_INTERNAL", "I", AccessFlags = 25)]
				public const int ERROR_INTERNAL = 20;
				/// <summary>
				/// <para>The OBB could not be mounted by the system. Returned in status messages from calls made via StorageManager </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_COULD_NOT_MOUNT
				/// </java-name>
				[Dot42.DexImport("ERROR_COULD_NOT_MOUNT", "I", AccessFlags = 25)]
				public const int ERROR_COULD_NOT_MOUNT = 21;
				/// <summary>
				/// <para>The OBB could not be unmounted. This most likely indicates that a file is in use on the OBB. Returned in status messages from calls made via StorageManager </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_COULD_NOT_UNMOUNT
				/// </java-name>
				[Dot42.DexImport("ERROR_COULD_NOT_UNMOUNT", "I", AccessFlags = 25)]
				public const int ERROR_COULD_NOT_UNMOUNT = 22;
				/// <summary>
				/// <para>A call was made to unmount the OBB when it was not mounted. Returned in status messages from calls made via StorageManager </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_NOT_MOUNTED
				/// </java-name>
				[Dot42.DexImport("ERROR_NOT_MOUNTED", "I", AccessFlags = 25)]
				public const int ERROR_NOT_MOUNTED = 23;
				/// <summary>
				/// <para>The OBB has already been mounted. Returned in status messages from calls made via StorageManager </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_ALREADY_MOUNTED
				/// </java-name>
				[Dot42.DexImport("ERROR_ALREADY_MOUNTED", "I", AccessFlags = 25)]
				public const int ERROR_ALREADY_MOUNTED = 24;
				/// <summary>
				/// <para>The current application does not have permission to use this OBB. This could be because the OBB indicates it's owned by a different package or some other error. Returned in status messages from calls made via StorageManager </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_PERMISSION_DENIED
				/// </java-name>
				[Dot42.DexImport("ERROR_PERMISSION_DENIED", "I", AccessFlags = 25)]
				public const int ERROR_PERMISSION_DENIED = 25;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OnObbStateChangeListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when an OBB has changed states.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onObbStateChange
				/// </java-name>
				[Dot42.DexImport("onObbStateChange", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public virtual void OnObbStateChange(string path, int state) /* MethodBuilder.Create */ 
				{
				}

		}

}


