// Copyright (C) 2014 dot42
//
// Original filename: Android.Mtp.cs
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
namespace Android.Mtp
{
		/// <summary>
		/// <para>This class represents an MTP or PTP device connected on the USB host bus. An application can instantiate an object of this type, by referencing an attached android.hardware.usb.UsbDevice and then use methods in this class to get information about the device and objects stored on it, as well as open the connection and transfer data. </para>    
		/// </summary>
		/// <java-name>
		/// android/mtp/MtpDevice
		/// </java-name>
		[Dot42.DexImport("android/mtp/MtpDevice", AccessFlags = 49)]
		public sealed partial class MtpDevice
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>MtpClient constructor</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/hardware/usb/UsbDevice;)V", AccessFlags = 1)]
				public MtpDevice(global::Android.Hardware.Usb.UsbDevice device) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Opens the MTP device. Once the device is open it takes ownership of the android.hardware.usb.UsbDeviceConnection. The connection will be closed when you call close() The connection will also be closed if this method fails.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the device was successfully opened. </para>
				/// </returns>
				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "(Landroid/hardware/usb/UsbDeviceConnection;)Z", AccessFlags = 1)]
				public bool Open(global::Android.Hardware.Usb.UsbDeviceConnection connection) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Closes all resources related to the MtpDevice object. After this is called, the object can not be used until open is called again with a new android.hardware.usb.UsbDeviceConnection. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MtpDevice() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of the USB device This returns the same value as android.hardware.usb.UsbDevice#getDeviceName for the device's android.hardware.usb.UsbDevice</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device name </para>
				/// </returns>
				/// <java-name>
				/// getDeviceName
				/// </java-name>
				[Dot42.DexImport("getDeviceName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetDeviceName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the USB ID of the USB device. This returns the same value as android.hardware.usb.UsbDevice#getDeviceId for the device's android.hardware.usb.UsbDevice</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device ID </para>
				/// </returns>
				/// <java-name>
				/// getDeviceId
				/// </java-name>
				[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 1)]
				public int GetDeviceId() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// <para>Returns the MtpDeviceInfo for this device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device info </para>
				/// </returns>
				/// <java-name>
				/// getDeviceInfo
				/// </java-name>
				[Dot42.DexImport("getDeviceInfo", "()Landroid/mtp/MtpDeviceInfo;", AccessFlags = 1)]
				public global::Android.Mtp.MtpDeviceInfo GetDeviceInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Mtp.MtpDeviceInfo);
				}

				/// <summary>
				/// <para>Returns the list of IDs for all storage units on this device Information about each storage unit can be accessed via getStorageInfo.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of storage IDs </para>
				/// </returns>
				/// <java-name>
				/// getStorageIds
				/// </java-name>
				[Dot42.DexImport("getStorageIds", "()[I", AccessFlags = 1)]
				public int[] GetStorageIds() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				/// <para>Returns the list of object handles for all objects on the given storage unit, with the given format and parent. Information about each object can be accessed via getObjectInfo.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object handles </para>
				/// </returns>
				/// <java-name>
				/// getObjectHandles
				/// </java-name>
				[Dot42.DexImport("getObjectHandles", "(III)[I", AccessFlags = 1)]
				public int[] GetObjectHandles(int storageId, int format, int objectHandle) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				/// <para>Returns the data for an object as a byte array. This call may block for an arbitrary amount of time depending on the size of the data and speed of the devices.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's data, or null if reading fails </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(II)[B", AccessFlags = 1)]
				public sbyte[] JavaGetObject(int objectHandle, int objectSize) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the data for an object as a byte array. This call may block for an arbitrary amount of time depending on the size of the data and speed of the devices.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's data, or null if reading fails </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(II)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetObject(int objectHandle, int objectSize) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the thumbnail data for an object as a byte array. The size and format of the thumbnail data can be determined via MtpObjectInfo#getThumbCompressedSize and MtpObjectInfo#getThumbFormat. For typical devices the format is JPEG.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's thumbnail, or null if reading fails </para>
				/// </returns>
				/// <java-name>
				/// getThumbnail
				/// </java-name>
				[Dot42.DexImport("getThumbnail", "(I)[B", AccessFlags = 1)]
				public sbyte[] JavaGetThumbnail(int objectHandle) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the thumbnail data for an object as a byte array. The size and format of the thumbnail data can be determined via MtpObjectInfo#getThumbCompressedSize and MtpObjectInfo#getThumbFormat. For typical devices the format is JPEG.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's thumbnail, or null if reading fails </para>
				/// </returns>
				/// <java-name>
				/// getThumbnail
				/// </java-name>
				[Dot42.DexImport("getThumbnail", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetThumbnail(int objectHandle) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Retrieves the MtpStorageInfo for a storage unit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the MtpStorageInfo </para>
				/// </returns>
				/// <java-name>
				/// getStorageInfo
				/// </java-name>
				[Dot42.DexImport("getStorageInfo", "(I)Landroid/mtp/MtpStorageInfo;", AccessFlags = 1)]
				public global::Android.Mtp.MtpStorageInfo GetStorageInfo(int storageId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Mtp.MtpStorageInfo);
				}

				/// <summary>
				/// <para>Retrieves the MtpObjectInfo for an object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the MtpObjectInfo </para>
				/// </returns>
				/// <java-name>
				/// getObjectInfo
				/// </java-name>
				[Dot42.DexImport("getObjectInfo", "(I)Landroid/mtp/MtpObjectInfo;", AccessFlags = 1)]
				public global::Android.Mtp.MtpObjectInfo GetObjectInfo(int objectHandle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Mtp.MtpObjectInfo);
				}

				/// <summary>
				/// <para>Deletes an object on the device. This call may block, since deleting a directory containing many files may take a long time on some devices.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the deletion succeeds </para>
				/// </returns>
				/// <java-name>
				/// deleteObject
				/// </java-name>
				[Dot42.DexImport("deleteObject", "(I)Z", AccessFlags = 1)]
				public bool DeleteObject(int objectHandle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Retrieves the object handle for the parent of an object on the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parent's handle, or zero if it is in the root of the storage </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "(I)J", AccessFlags = 1)]
				public long GetParent(int objectHandle) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Retrieves the ID of the storage unit containing the given object on the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's storage unit ID </para>
				/// </returns>
				/// <java-name>
				/// getStorageId
				/// </java-name>
				[Dot42.DexImport("getStorageId", "(I)J", AccessFlags = 1)]
				public long GetStorageId(int objectHandle) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Copies the data for an object to a file in external storage. This call may block for an arbitrary amount of time depending on the size of the data and speed of the devices.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the file transfer succeeds </para>
				/// </returns>
				/// <java-name>
				/// importFile
				/// </java-name>
				[Dot42.DexImport("importFile", "(ILjava/lang/String;)Z", AccessFlags = 1)]
				public bool ImportFile(int objectHandle, string destPath) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MtpDevice() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the USB device This returns the same value as android.hardware.usb.UsbDevice#getDeviceName for the device's android.hardware.usb.UsbDevice</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device name </para>
				/// </returns>
				/// <java-name>
				/// getDeviceName
				/// </java-name>
				public string DeviceName
				{
				[Dot42.DexImport("getDeviceName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDeviceName(); }
				}

				/// <summary>
				/// <para>Returns the USB ID of the USB device. This returns the same value as android.hardware.usb.UsbDevice#getDeviceId for the device's android.hardware.usb.UsbDevice</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device ID </para>
				/// </returns>
				/// <java-name>
				/// getDeviceId
				/// </java-name>
				public int DeviceId
				{
				[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 1)]
						get{ return GetDeviceId(); }
				}

				/// <summary>
				/// <para>Returns the MtpDeviceInfo for this device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device info </para>
				/// </returns>
				/// <java-name>
				/// getDeviceInfo
				/// </java-name>
				public global::Android.Mtp.MtpDeviceInfo DeviceInfo
				{
				[Dot42.DexImport("getDeviceInfo", "()Landroid/mtp/MtpDeviceInfo;", AccessFlags = 1)]
						get{ return GetDeviceInfo(); }
				}

				/// <summary>
				/// <para>Returns the list of IDs for all storage units on this device Information about each storage unit can be accessed via getStorageInfo.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of storage IDs </para>
				/// </returns>
				/// <java-name>
				/// getStorageIds
				/// </java-name>
				public int[] StorageIds
				{
				[Dot42.DexImport("getStorageIds", "()[I", AccessFlags = 1)]
						get{ return GetStorageIds(); }
				}

		}

		/// <summary>
		/// <para>This class encapsulates information about a storage unit on an MTP device. This corresponds to the StorageInfo Dataset described in section 5.2.2 of the MTP specification. </para>    
		/// </summary>
		/// <java-name>
		/// android/mtp/MtpStorageInfo
		/// </java-name>
		[Dot42.DexImport("android/mtp/MtpStorageInfo", AccessFlags = 49)]
		public sealed partial class MtpStorageInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MtpStorageInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the storage ID for the storage unit. The storage ID uniquely identifies the storage unit on the MTP device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the storage ID </para>
				/// </returns>
				/// <java-name>
				/// getStorageId
				/// </java-name>
				[Dot42.DexImport("getStorageId", "()I", AccessFlags = 17)]
				public int GetStorageId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the maximum storage capacity for the storage unit in bytes</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum capacity </para>
				/// </returns>
				/// <java-name>
				/// getMaxCapacity
				/// </java-name>
				[Dot42.DexImport("getMaxCapacity", "()J", AccessFlags = 17)]
				public long GetMaxCapacity() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the amount of free space in the storage unit in bytes</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the amount of free space </para>
				/// </returns>
				/// <java-name>
				/// getFreeSpace
				/// </java-name>
				[Dot42.DexImport("getFreeSpace", "()J", AccessFlags = 17)]
				public long GetFreeSpace() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the description string for the storage unit. This is typically displayed to the user in the user interface on the MTP host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the storage unit description </para>
				/// </returns>
				/// <java-name>
				/// getDescription
				/// </java-name>
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetDescription() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the volume identifier for the storage unit</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the storage volume identifier </para>
				/// </returns>
				/// <java-name>
				/// getVolumeIdentifier
				/// </java-name>
				[Dot42.DexImport("getVolumeIdentifier", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetVolumeIdentifier() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the storage ID for the storage unit. The storage ID uniquely identifies the storage unit on the MTP device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the storage ID </para>
				/// </returns>
				/// <java-name>
				/// getStorageId
				/// </java-name>
				public int StorageId
				{
				[Dot42.DexImport("getStorageId", "()I", AccessFlags = 17)]
						get{ return GetStorageId(); }
				}

				/// <summary>
				/// <para>Returns the maximum storage capacity for the storage unit in bytes</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum capacity </para>
				/// </returns>
				/// <java-name>
				/// getMaxCapacity
				/// </java-name>
				public long MaxCapacity
				{
				[Dot42.DexImport("getMaxCapacity", "()J", AccessFlags = 17)]
						get{ return GetMaxCapacity(); }
				}

				/// <summary>
				/// <para>Returns the amount of free space in the storage unit in bytes</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the amount of free space </para>
				/// </returns>
				/// <java-name>
				/// getFreeSpace
				/// </java-name>
				public long FreeSpace
				{
				[Dot42.DexImport("getFreeSpace", "()J", AccessFlags = 17)]
						get{ return GetFreeSpace(); }
				}

				/// <summary>
				/// <para>Returns the description string for the storage unit. This is typically displayed to the user in the user interface on the MTP host.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the storage unit description </para>
				/// </returns>
				/// <java-name>
				/// getDescription
				/// </java-name>
				public string Description
				{
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetDescription(); }
				}

				/// <summary>
				/// <para>Returns the volume identifier for the storage unit</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the storage volume identifier </para>
				/// </returns>
				/// <java-name>
				/// getVolumeIdentifier
				/// </java-name>
				public string VolumeIdentifier
				{
				[Dot42.DexImport("getVolumeIdentifier", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetVolumeIdentifier(); }
				}

		}

		/// <summary>
		/// <para>A class containing constants in the MTP and PTP specifications. </para>    
		/// </summary>
		/// <java-name>
		/// android/mtp/MtpConstants
		/// </java-name>
		[Dot42.DexImport("android/mtp/MtpConstants", AccessFlags = 49)]
		public sealed partial class MtpConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Undefined format code </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("FORMAT_UNDEFINED", "I", AccessFlags = 25)]
				public const int FORMAT_UNDEFINED = 12288;
				/// <summary>
				/// <para>Format code for associations (folders and directories) </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ASSOCIATION
				/// </java-name>
				[Dot42.DexImport("FORMAT_ASSOCIATION", "I", AccessFlags = 25)]
				public const int FORMAT_ASSOCIATION = 12289;
				/// <summary>
				/// <para>Format code for script files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_SCRIPT
				/// </java-name>
				[Dot42.DexImport("FORMAT_SCRIPT", "I", AccessFlags = 25)]
				public const int FORMAT_SCRIPT = 12290;
				/// <summary>
				/// <para>Format code for executable files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_EXECUTABLE
				/// </java-name>
				[Dot42.DexImport("FORMAT_EXECUTABLE", "I", AccessFlags = 25)]
				public const int FORMAT_EXECUTABLE = 12291;
				/// <summary>
				/// <para>Format code for text files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_TEXT
				/// </java-name>
				[Dot42.DexImport("FORMAT_TEXT", "I", AccessFlags = 25)]
				public const int FORMAT_TEXT = 12292;
				/// <summary>
				/// <para>Format code for HTML files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_HTML
				/// </java-name>
				[Dot42.DexImport("FORMAT_HTML", "I", AccessFlags = 25)]
				public const int FORMAT_HTML = 12293;
				/// <summary>
				/// <para>Format code for DPOF files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_DPOF
				/// </java-name>
				[Dot42.DexImport("FORMAT_DPOF", "I", AccessFlags = 25)]
				public const int FORMAT_DPOF = 12294;
				/// <summary>
				/// <para>Format code for AIFF audio files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_AIFF
				/// </java-name>
				[Dot42.DexImport("FORMAT_AIFF", "I", AccessFlags = 25)]
				public const int FORMAT_AIFF = 12295;
				/// <summary>
				/// <para>Format code for WAV audio files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_WAV
				/// </java-name>
				[Dot42.DexImport("FORMAT_WAV", "I", AccessFlags = 25)]
				public const int FORMAT_WAV = 12296;
				/// <summary>
				/// <para>Format code for MP3 audio files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MP3
				/// </java-name>
				[Dot42.DexImport("FORMAT_MP3", "I", AccessFlags = 25)]
				public const int FORMAT_MP3 = 12297;
				/// <summary>
				/// <para>Format code for AVI video files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_AVI
				/// </java-name>
				[Dot42.DexImport("FORMAT_AVI", "I", AccessFlags = 25)]
				public const int FORMAT_AVI = 12298;
				/// <summary>
				/// <para>Format code for MPEG video files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MPEG
				/// </java-name>
				[Dot42.DexImport("FORMAT_MPEG", "I", AccessFlags = 25)]
				public const int FORMAT_MPEG = 12299;
				/// <summary>
				/// <para>Format code for ASF files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ASF
				/// </java-name>
				[Dot42.DexImport("FORMAT_ASF", "I", AccessFlags = 25)]
				public const int FORMAT_ASF = 12300;
				/// <summary>
				/// <para>Format code for JPEG image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_EXIF_JPEG
				/// </java-name>
				[Dot42.DexImport("FORMAT_EXIF_JPEG", "I", AccessFlags = 25)]
				public const int FORMAT_EXIF_JPEG = 14337;
				/// <summary>
				/// <para>Format code for TIFF EP image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_TIFF_EP
				/// </java-name>
				[Dot42.DexImport("FORMAT_TIFF_EP", "I", AccessFlags = 25)]
				public const int FORMAT_TIFF_EP = 14338;
				/// <summary>
				/// <para>Format code for BMP image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_BMP
				/// </java-name>
				[Dot42.DexImport("FORMAT_BMP", "I", AccessFlags = 25)]
				public const int FORMAT_BMP = 14340;
				/// <summary>
				/// <para>Format code for GIF image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_GIF
				/// </java-name>
				[Dot42.DexImport("FORMAT_GIF", "I", AccessFlags = 25)]
				public const int FORMAT_GIF = 14343;
				/// <summary>
				/// <para>Format code for JFIF image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_JFIF
				/// </java-name>
				[Dot42.DexImport("FORMAT_JFIF", "I", AccessFlags = 25)]
				public const int FORMAT_JFIF = 14344;
				/// <summary>
				/// <para>Format code for PICT image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_PICT
				/// </java-name>
				[Dot42.DexImport("FORMAT_PICT", "I", AccessFlags = 25)]
				public const int FORMAT_PICT = 14346;
				/// <summary>
				/// <para>Format code for PNG image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_PNG
				/// </java-name>
				[Dot42.DexImport("FORMAT_PNG", "I", AccessFlags = 25)]
				public const int FORMAT_PNG = 14347;
				/// <summary>
				/// <para>Format code for TIFF image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_TIFF
				/// </java-name>
				[Dot42.DexImport("FORMAT_TIFF", "I", AccessFlags = 25)]
				public const int FORMAT_TIFF = 14349;
				/// <summary>
				/// <para>Format code for JP2 files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_JP2
				/// </java-name>
				[Dot42.DexImport("FORMAT_JP2", "I", AccessFlags = 25)]
				public const int FORMAT_JP2 = 14351;
				/// <summary>
				/// <para>Format code for JPX files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_JPX
				/// </java-name>
				[Dot42.DexImport("FORMAT_JPX", "I", AccessFlags = 25)]
				public const int FORMAT_JPX = 14352;
				/// <summary>
				/// <para>Format code for firmware files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_UNDEFINED_FIRMWARE
				/// </java-name>
				[Dot42.DexImport("FORMAT_UNDEFINED_FIRMWARE", "I", AccessFlags = 25)]
				public const int FORMAT_UNDEFINED_FIRMWARE = 47106;
				/// <summary>
				/// <para>Format code for Windows image files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_WINDOWS_IMAGE_FORMAT
				/// </java-name>
				[Dot42.DexImport("FORMAT_WINDOWS_IMAGE_FORMAT", "I", AccessFlags = 25)]
				public const int FORMAT_WINDOWS_IMAGE_FORMAT = 47233;
				/// <summary>
				/// <para>Format code for undefined audio files files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_UNDEFINED_AUDIO
				/// </java-name>
				[Dot42.DexImport("FORMAT_UNDEFINED_AUDIO", "I", AccessFlags = 25)]
				public const int FORMAT_UNDEFINED_AUDIO = 47360;
				/// <summary>
				/// <para>Format code for WMA audio files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_WMA
				/// </java-name>
				[Dot42.DexImport("FORMAT_WMA", "I", AccessFlags = 25)]
				public const int FORMAT_WMA = 47361;
				/// <summary>
				/// <para>Format code for OGG audio files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_OGG
				/// </java-name>
				[Dot42.DexImport("FORMAT_OGG", "I", AccessFlags = 25)]
				public const int FORMAT_OGG = 47362;
				/// <summary>
				/// <para>Format code for AAC audio files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_AAC
				/// </java-name>
				[Dot42.DexImport("FORMAT_AAC", "I", AccessFlags = 25)]
				public const int FORMAT_AAC = 47363;
				/// <summary>
				/// <para>Format code for Audible audio files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_AUDIBLE
				/// </java-name>
				[Dot42.DexImport("FORMAT_AUDIBLE", "I", AccessFlags = 25)]
				public const int FORMAT_AUDIBLE = 47364;
				/// <summary>
				/// <para>Format code for FLAC audio files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_FLAC
				/// </java-name>
				[Dot42.DexImport("FORMAT_FLAC", "I", AccessFlags = 25)]
				public const int FORMAT_FLAC = 47366;
				/// <summary>
				/// <para>Format code for undefined video files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_UNDEFINED_VIDEO
				/// </java-name>
				[Dot42.DexImport("FORMAT_UNDEFINED_VIDEO", "I", AccessFlags = 25)]
				public const int FORMAT_UNDEFINED_VIDEO = 47488;
				/// <summary>
				/// <para>Format code for WMV video files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_WMV
				/// </java-name>
				[Dot42.DexImport("FORMAT_WMV", "I", AccessFlags = 25)]
				public const int FORMAT_WMV = 47489;
				/// <summary>
				/// <para>Format code for MP4 files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MP4_CONTAINER
				/// </java-name>
				[Dot42.DexImport("FORMAT_MP4_CONTAINER", "I", AccessFlags = 25)]
				public const int FORMAT_MP4_CONTAINER = 47490;
				/// <summary>
				/// <para>Format code for MP2 files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MP2
				/// </java-name>
				[Dot42.DexImport("FORMAT_MP2", "I", AccessFlags = 25)]
				public const int FORMAT_MP2 = 47491;
				/// <summary>
				/// <para>Format code for 3GP files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_3GP_CONTAINER
				/// </java-name>
				[Dot42.DexImport("FORMAT_3GP_CONTAINER", "I", AccessFlags = 25)]
				public const int FORMAT_3GP_CONTAINER = 47492;
				/// <summary>
				/// <para>Format code for undefined collections </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_UNDEFINED_COLLECTION
				/// </java-name>
				[Dot42.DexImport("FORMAT_UNDEFINED_COLLECTION", "I", AccessFlags = 25)]
				public const int FORMAT_UNDEFINED_COLLECTION = 47616;
				/// <summary>
				/// <para>Format code for multimedia albums </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_MULTIMEDIA_ALBUM
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_MULTIMEDIA_ALBUM", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_MULTIMEDIA_ALBUM = 47617;
				/// <summary>
				/// <para>Format code for image albums </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_IMAGE_ALBUM
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_IMAGE_ALBUM", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_IMAGE_ALBUM = 47618;
				/// <summary>
				/// <para>Format code for audio albums </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_AUDIO_ALBUM
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_AUDIO_ALBUM", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_AUDIO_ALBUM = 47619;
				/// <summary>
				/// <para>Format code for video albums </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_VIDEO_ALBUM
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_VIDEO_ALBUM", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_VIDEO_ALBUM = 47620;
				/// <summary>
				/// <para>Format code for abstract AV playlists </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_AV_PLAYLIST
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_AV_PLAYLIST", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_AV_PLAYLIST = 47621;
				/// <summary>
				/// <para>Format code for abstract audio playlists </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_AUDIO_PLAYLIST
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_AUDIO_PLAYLIST", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_AUDIO_PLAYLIST = 47625;
				/// <summary>
				/// <para>Format code for abstract video playlists </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_VIDEO_PLAYLIST
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_VIDEO_PLAYLIST", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_VIDEO_PLAYLIST = 47626;
				/// <summary>
				/// <para>Format code for abstract mediacasts </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_MEDIACAST
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_MEDIACAST", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_MEDIACAST = 47627;
				/// <summary>
				/// <para>Format code for WPL playlist files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_WPL_PLAYLIST
				/// </java-name>
				[Dot42.DexImport("FORMAT_WPL_PLAYLIST", "I", AccessFlags = 25)]
				public const int FORMAT_WPL_PLAYLIST = 47632;
				/// <summary>
				/// <para>Format code for M3u playlist files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_M3U_PLAYLIST
				/// </java-name>
				[Dot42.DexImport("FORMAT_M3U_PLAYLIST", "I", AccessFlags = 25)]
				public const int FORMAT_M3U_PLAYLIST = 47633;
				/// <summary>
				/// <para>Format code for MPL playlist files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MPL_PLAYLIST
				/// </java-name>
				[Dot42.DexImport("FORMAT_MPL_PLAYLIST", "I", AccessFlags = 25)]
				public const int FORMAT_MPL_PLAYLIST = 47634;
				/// <summary>
				/// <para>Format code for ASX playlist files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ASX_PLAYLIST
				/// </java-name>
				[Dot42.DexImport("FORMAT_ASX_PLAYLIST", "I", AccessFlags = 25)]
				public const int FORMAT_ASX_PLAYLIST = 47635;
				/// <summary>
				/// <para>Format code for PLS playlist files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_PLS_PLAYLIST
				/// </java-name>
				[Dot42.DexImport("FORMAT_PLS_PLAYLIST", "I", AccessFlags = 25)]
				public const int FORMAT_PLS_PLAYLIST = 47636;
				/// <summary>
				/// <para>Format code for undefined document files </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_UNDEFINED_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("FORMAT_UNDEFINED_DOCUMENT", "I", AccessFlags = 25)]
				public const int FORMAT_UNDEFINED_DOCUMENT = 47744;
				/// <summary>
				/// <para>Format code for abstract documents </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_ABSTRACT_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("FORMAT_ABSTRACT_DOCUMENT", "I", AccessFlags = 25)]
				public const int FORMAT_ABSTRACT_DOCUMENT = 47745;
				/// <summary>
				/// <para>Format code for XML documents </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_XML_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("FORMAT_XML_DOCUMENT", "I", AccessFlags = 25)]
				public const int FORMAT_XML_DOCUMENT = 47746;
				/// <summary>
				/// <para>Format code for MS Word documents </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MS_WORD_DOCUMENT
				/// </java-name>
				[Dot42.DexImport("FORMAT_MS_WORD_DOCUMENT", "I", AccessFlags = 25)]
				public const int FORMAT_MS_WORD_DOCUMENT = 47747;
				/// <summary>
				/// <para>Format code for MS Excel spreadsheets </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MS_EXCEL_SPREADSHEET
				/// </java-name>
				[Dot42.DexImport("FORMAT_MS_EXCEL_SPREADSHEET", "I", AccessFlags = 25)]
				public const int FORMAT_MS_EXCEL_SPREADSHEET = 47749;
				/// <summary>
				/// <para>Format code for MS PowerPoint presentatiosn </para>        
				/// </summary>
				/// <java-name>
				/// FORMAT_MS_POWERPOINT_PRESENTATION
				/// </java-name>
				[Dot42.DexImport("FORMAT_MS_POWERPOINT_PRESENTATION", "I", AccessFlags = 25)]
				public const int FORMAT_MS_POWERPOINT_PRESENTATION = 47750;
				/// <summary>
				/// <para>Object is not protected. It may be modified and deleted, and its properties may be modified. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTION_STATUS_NONE
				/// </java-name>
				[Dot42.DexImport("PROTECTION_STATUS_NONE", "I", AccessFlags = 25)]
				public const int PROTECTION_STATUS_NONE = 0;
				/// <summary>
				/// <para>Object can not be modified or deleted and its properties can not be modified. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTION_STATUS_READ_ONLY
				/// </java-name>
				[Dot42.DexImport("PROTECTION_STATUS_READ_ONLY", "I", AccessFlags = 25)]
				public const int PROTECTION_STATUS_READ_ONLY = 32769;
				/// <summary>
				/// <para>Object can not be modified or deleted but its properties are modifiable. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTION_STATUS_READ_ONLY_DATA
				/// </java-name>
				[Dot42.DexImport("PROTECTION_STATUS_READ_ONLY_DATA", "I", AccessFlags = 25)]
				public const int PROTECTION_STATUS_READ_ONLY_DATA = 32770;
				/// <summary>
				/// <para>Object's contents can not be transfered from the device, but the object may be moved or deleted and its properties may be modified. </para>        
				/// </summary>
				/// <java-name>
				/// PROTECTION_STATUS_NON_TRANSFERABLE_DATA
				/// </java-name>
				[Dot42.DexImport("PROTECTION_STATUS_NON_TRANSFERABLE_DATA", "I", AccessFlags = 25)]
				public const int PROTECTION_STATUS_NON_TRANSFERABLE_DATA = 32771;
				/// <summary>
				/// <para>Association type for objects representing file system directories. </para>        
				/// </summary>
				/// <java-name>
				/// ASSOCIATION_TYPE_GENERIC_FOLDER
				/// </java-name>
				[Dot42.DexImport("ASSOCIATION_TYPE_GENERIC_FOLDER", "I", AccessFlags = 25)]
				public const int ASSOCIATION_TYPE_GENERIC_FOLDER = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MtpConstants() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if the object is abstract (that is, it has no representation in the underlying file system).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the object is abstract </para>
				/// </returns>
				/// <java-name>
				/// isAbstractObject
				/// </java-name>
				[Dot42.DexImport("isAbstractObject", "(I)Z", AccessFlags = 9)]
				public static bool IsAbstractObject(int format) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>This class encapsulates information about an object on an MTP device. This corresponds to the ObjectInfo Dataset described in section 5.3.1 of the MTP specification. </para>    
		/// </summary>
		/// <java-name>
		/// android/mtp/MtpObjectInfo
		/// </java-name>
		[Dot42.DexImport("android/mtp/MtpObjectInfo", AccessFlags = 49)]
		public sealed partial class MtpObjectInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MtpObjectInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the object handle for the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object handle </para>
				/// </returns>
				/// <java-name>
				/// getObjectHandle
				/// </java-name>
				[Dot42.DexImport("getObjectHandle", "()I", AccessFlags = 17)]
				public int GetObjectHandle() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the storage ID for the MTP object's storage unit</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the storage ID </para>
				/// </returns>
				/// <java-name>
				/// getStorageId
				/// </java-name>
				[Dot42.DexImport("getStorageId", "()I", AccessFlags = 17)]
				public int GetStorageId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the format code for the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the format code </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				[Dot42.DexImport("getFormat", "()I", AccessFlags = 17)]
				public int GetFormat() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the protection status for the MTP object Possible values are:</para><para><ul><li><para>android.mtp.MtpConstants#PROTECTION_STATUS_NONE </para></li><li><para>android.mtp.MtpConstants#PROTECTION_STATUS_READ_ONLY </para></li><li><para>android.mtp.MtpConstants#PROTECTION_STATUS_NON_TRANSFERABLE_DATA </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protection status </para>
				/// </returns>
				/// <java-name>
				/// getProtectionStatus
				/// </java-name>
				[Dot42.DexImport("getProtectionStatus", "()I", AccessFlags = 17)]
				public int GetProtectionStatus() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the size of the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object size </para>
				/// </returns>
				/// <java-name>
				/// getCompressedSize
				/// </java-name>
				[Dot42.DexImport("getCompressedSize", "()I", AccessFlags = 17)]
				public int GetCompressedSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the format code for the MTP object's thumbnail Will be zero for objects with no thumbnail</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thumbnail format code </para>
				/// </returns>
				/// <java-name>
				/// getThumbFormat
				/// </java-name>
				[Dot42.DexImport("getThumbFormat", "()I", AccessFlags = 17)]
				public int GetThumbFormat() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the size of the MTP object's thumbnail Will be zero for objects with no thumbnail</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thumbnail size </para>
				/// </returns>
				/// <java-name>
				/// getThumbCompressedSize
				/// </java-name>
				[Dot42.DexImport("getThumbCompressedSize", "()I", AccessFlags = 17)]
				public int GetThumbCompressedSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the width of the MTP object's thumbnail in pixels Will be zero for objects with no thumbnail</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thumbnail width </para>
				/// </returns>
				/// <java-name>
				/// getThumbPixWidth
				/// </java-name>
				[Dot42.DexImport("getThumbPixWidth", "()I", AccessFlags = 17)]
				public int GetThumbPixWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the height of the MTP object's thumbnail in pixels Will be zero for objects with no thumbnail</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thumbnail height </para>
				/// </returns>
				/// <java-name>
				/// getThumbPixHeight
				/// </java-name>
				[Dot42.DexImport("getThumbPixHeight", "()I", AccessFlags = 17)]
				public int GetThumbPixHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the width of the MTP object in pixels Will be zero for non-image objects</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the image width </para>
				/// </returns>
				/// <java-name>
				/// getImagePixWidth
				/// </java-name>
				[Dot42.DexImport("getImagePixWidth", "()I", AccessFlags = 17)]
				public int GetImagePixWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the height of the MTP object in pixels Will be zero for non-image objects</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the image height </para>
				/// </returns>
				/// <java-name>
				/// getImagePixHeight
				/// </java-name>
				[Dot42.DexImport("getImagePixHeight", "()I", AccessFlags = 17)]
				public int GetImagePixHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the depth of the MTP object in bits per pixel Will be zero for non-image objects</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the image depth </para>
				/// </returns>
				/// <java-name>
				/// getImagePixDepth
				/// </java-name>
				[Dot42.DexImport("getImagePixDepth", "()I", AccessFlags = 17)]
				public int GetImagePixDepth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the object handle for the object's parent Will be zero for the root directory of a storage unit</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's parent </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()I", AccessFlags = 17)]
				public int GetParent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the association type for the MTP object Will be zero objects that are not of format android.mtp.MtpConstants#FORMAT_ASSOCIATION For directories the association type is typically android.mtp.MtpConstants#ASSOCIATION_TYPE_GENERIC_FOLDER</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's association type </para>
				/// </returns>
				/// <java-name>
				/// getAssociationType
				/// </java-name>
				[Dot42.DexImport("getAssociationType", "()I", AccessFlags = 17)]
				public int GetAssociationType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the association description for the MTP object Will be zero objects that are not of format android.mtp.MtpConstants#FORMAT_ASSOCIATION</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's association description </para>
				/// </returns>
				/// <java-name>
				/// getAssociationDesc
				/// </java-name>
				[Dot42.DexImport("getAssociationDesc", "()I", AccessFlags = 17)]
				public int GetAssociationDesc() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the sequence number for the MTP object This field is typically not used for MTP devices, but is sometimes used to define a sequence of photos on PTP cameras.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's sequence number </para>
				/// </returns>
				/// <java-name>
				/// getSequenceNumber
				/// </java-name>
				[Dot42.DexImport("getSequenceNumber", "()I", AccessFlags = 17)]
				public int GetSequenceNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the name of the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the creation date of the MTP object The value is represented as milliseconds since January 1, 1970</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's creation date </para>
				/// </returns>
				/// <java-name>
				/// getDateCreated
				/// </java-name>
				[Dot42.DexImport("getDateCreated", "()J", AccessFlags = 17)]
				public long GetDateCreated() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns the modification date of the MTP object The value is represented as milliseconds since January 1, 1970</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's modification date </para>
				/// </returns>
				/// <java-name>
				/// getDateModified
				/// </java-name>
				[Dot42.DexImport("getDateModified", "()J", AccessFlags = 17)]
				public long GetDateModified() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns a comma separated list of keywords for the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's keyword list </para>
				/// </returns>
				/// <java-name>
				/// getKeywords
				/// </java-name>
				[Dot42.DexImport("getKeywords", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetKeywords() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the object handle for the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object handle </para>
				/// </returns>
				/// <java-name>
				/// getObjectHandle
				/// </java-name>
				public int ObjectHandle
				{
				[Dot42.DexImport("getObjectHandle", "()I", AccessFlags = 17)]
						get{ return GetObjectHandle(); }
				}

				/// <summary>
				/// <para>Returns the storage ID for the MTP object's storage unit</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the storage ID </para>
				/// </returns>
				/// <java-name>
				/// getStorageId
				/// </java-name>
				public int StorageId
				{
				[Dot42.DexImport("getStorageId", "()I", AccessFlags = 17)]
						get{ return GetStorageId(); }
				}

				/// <summary>
				/// <para>Returns the format code for the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the format code </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				public int Format
				{
				[Dot42.DexImport("getFormat", "()I", AccessFlags = 17)]
						get{ return GetFormat(); }
				}

				/// <summary>
				/// <para>Returns the protection status for the MTP object Possible values are:</para><para><ul><li><para>android.mtp.MtpConstants#PROTECTION_STATUS_NONE </para></li><li><para>android.mtp.MtpConstants#PROTECTION_STATUS_READ_ONLY </para></li><li><para>android.mtp.MtpConstants#PROTECTION_STATUS_NON_TRANSFERABLE_DATA </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protection status </para>
				/// </returns>
				/// <java-name>
				/// getProtectionStatus
				/// </java-name>
				public int ProtectionStatus
				{
				[Dot42.DexImport("getProtectionStatus", "()I", AccessFlags = 17)]
						get{ return GetProtectionStatus(); }
				}

				/// <summary>
				/// <para>Returns the size of the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object size </para>
				/// </returns>
				/// <java-name>
				/// getCompressedSize
				/// </java-name>
				public int CompressedSize
				{
				[Dot42.DexImport("getCompressedSize", "()I", AccessFlags = 17)]
						get{ return GetCompressedSize(); }
				}

				/// <summary>
				/// <para>Returns the format code for the MTP object's thumbnail Will be zero for objects with no thumbnail</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thumbnail format code </para>
				/// </returns>
				/// <java-name>
				/// getThumbFormat
				/// </java-name>
				public int ThumbFormat
				{
				[Dot42.DexImport("getThumbFormat", "()I", AccessFlags = 17)]
						get{ return GetThumbFormat(); }
				}

				/// <summary>
				/// <para>Returns the size of the MTP object's thumbnail Will be zero for objects with no thumbnail</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thumbnail size </para>
				/// </returns>
				/// <java-name>
				/// getThumbCompressedSize
				/// </java-name>
				public int ThumbCompressedSize
				{
				[Dot42.DexImport("getThumbCompressedSize", "()I", AccessFlags = 17)]
						get{ return GetThumbCompressedSize(); }
				}

				/// <summary>
				/// <para>Returns the width of the MTP object's thumbnail in pixels Will be zero for objects with no thumbnail</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thumbnail width </para>
				/// </returns>
				/// <java-name>
				/// getThumbPixWidth
				/// </java-name>
				public int ThumbPixWidth
				{
				[Dot42.DexImport("getThumbPixWidth", "()I", AccessFlags = 17)]
						get{ return GetThumbPixWidth(); }
				}

				/// <summary>
				/// <para>Returns the height of the MTP object's thumbnail in pixels Will be zero for objects with no thumbnail</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the thumbnail height </para>
				/// </returns>
				/// <java-name>
				/// getThumbPixHeight
				/// </java-name>
				public int ThumbPixHeight
				{
				[Dot42.DexImport("getThumbPixHeight", "()I", AccessFlags = 17)]
						get{ return GetThumbPixHeight(); }
				}

				/// <summary>
				/// <para>Returns the width of the MTP object in pixels Will be zero for non-image objects</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the image width </para>
				/// </returns>
				/// <java-name>
				/// getImagePixWidth
				/// </java-name>
				public int ImagePixWidth
				{
				[Dot42.DexImport("getImagePixWidth", "()I", AccessFlags = 17)]
						get{ return GetImagePixWidth(); }
				}

				/// <summary>
				/// <para>Returns the height of the MTP object in pixels Will be zero for non-image objects</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the image height </para>
				/// </returns>
				/// <java-name>
				/// getImagePixHeight
				/// </java-name>
				public int ImagePixHeight
				{
				[Dot42.DexImport("getImagePixHeight", "()I", AccessFlags = 17)]
						get{ return GetImagePixHeight(); }
				}

				/// <summary>
				/// <para>Returns the depth of the MTP object in bits per pixel Will be zero for non-image objects</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the image depth </para>
				/// </returns>
				/// <java-name>
				/// getImagePixDepth
				/// </java-name>
				public int ImagePixDepth
				{
				[Dot42.DexImport("getImagePixDepth", "()I", AccessFlags = 17)]
						get{ return GetImagePixDepth(); }
				}

				/// <summary>
				/// <para>Returns the object handle for the object's parent Will be zero for the root directory of a storage unit</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's parent </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public int Parent
				{
				[Dot42.DexImport("getParent", "()I", AccessFlags = 17)]
						get{ return GetParent(); }
				}

				/// <summary>
				/// <para>Returns the association type for the MTP object Will be zero objects that are not of format android.mtp.MtpConstants#FORMAT_ASSOCIATION For directories the association type is typically android.mtp.MtpConstants#ASSOCIATION_TYPE_GENERIC_FOLDER</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's association type </para>
				/// </returns>
				/// <java-name>
				/// getAssociationType
				/// </java-name>
				public int AssociationType
				{
				[Dot42.DexImport("getAssociationType", "()I", AccessFlags = 17)]
						get{ return GetAssociationType(); }
				}

				/// <summary>
				/// <para>Returns the association description for the MTP object Will be zero objects that are not of format android.mtp.MtpConstants#FORMAT_ASSOCIATION</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's association description </para>
				/// </returns>
				/// <java-name>
				/// getAssociationDesc
				/// </java-name>
				public int AssociationDesc
				{
				[Dot42.DexImport("getAssociationDesc", "()I", AccessFlags = 17)]
						get{ return GetAssociationDesc(); }
				}

				/// <summary>
				/// <para>Returns the sequence number for the MTP object This field is typically not used for MTP devices, but is sometimes used to define a sequence of photos on PTP cameras.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's sequence number </para>
				/// </returns>
				/// <java-name>
				/// getSequenceNumber
				/// </java-name>
				public int SequenceNumber
				{
				[Dot42.DexImport("getSequenceNumber", "()I", AccessFlags = 17)]
						get{ return GetSequenceNumber(); }
				}

				/// <summary>
				/// <para>Returns the name of the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Returns the creation date of the MTP object The value is represented as milliseconds since January 1, 1970</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's creation date </para>
				/// </returns>
				/// <java-name>
				/// getDateCreated
				/// </java-name>
				public long DateCreated
				{
				[Dot42.DexImport("getDateCreated", "()J", AccessFlags = 17)]
						get{ return GetDateCreated(); }
				}

				/// <summary>
				/// <para>Returns the modification date of the MTP object The value is represented as milliseconds since January 1, 1970</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's modification date </para>
				/// </returns>
				/// <java-name>
				/// getDateModified
				/// </java-name>
				public long DateModified
				{
				[Dot42.DexImport("getDateModified", "()J", AccessFlags = 17)]
						get{ return GetDateModified(); }
				}

				/// <summary>
				/// <para>Returns a comma separated list of keywords for the MTP object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the object's keyword list </para>
				/// </returns>
				/// <java-name>
				/// getKeywords
				/// </java-name>
				public string Keywords
				{
				[Dot42.DexImport("getKeywords", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetKeywords(); }
				}

		}

		/// <summary>
		/// <para>This class encapsulates information about an MTP device. This corresponds to the DeviceInfo Dataset described in section 5.1.1 of the MTP specification. </para>    
		/// </summary>
		/// <java-name>
		/// android/mtp/MtpDeviceInfo
		/// </java-name>
		[Dot42.DexImport("android/mtp/MtpDeviceInfo", AccessFlags = 33)]
		public partial class MtpDeviceInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MtpDeviceInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the manufacturer's name for the MTP device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the manufacturer name </para>
				/// </returns>
				/// <java-name>
				/// getManufacturer
				/// </java-name>
				[Dot42.DexImport("getManufacturer", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetManufacturer() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the model name for the MTP device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the model name </para>
				/// </returns>
				/// <java-name>
				/// getModel
				/// </java-name>
				[Dot42.DexImport("getModel", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetModel() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the version string the MTP device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device version </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetVersion() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the unique serial number for the MTP device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the serial number </para>
				/// </returns>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				[Dot42.DexImport("getSerialNumber", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetSerialNumber() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the manufacturer's name for the MTP device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the manufacturer name </para>
				/// </returns>
				/// <java-name>
				/// getManufacturer
				/// </java-name>
				public string Manufacturer
				{
				[Dot42.DexImport("getManufacturer", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetManufacturer(); }
				}

				/// <summary>
				/// <para>Returns the model name for the MTP device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the model name </para>
				/// </returns>
				/// <java-name>
				/// getModel
				/// </java-name>
				public string Model
				{
				[Dot42.DexImport("getModel", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetModel(); }
				}

				/// <summary>
				/// <para>Returns the version string the MTP device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device version </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public string Version
				{
				[Dot42.DexImport("getVersion", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns the unique serial number for the MTP device</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the serial number </para>
				/// </returns>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public string SerialNumber
				{
				[Dot42.DexImport("getSerialNumber", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetSerialNumber(); }
				}

		}

}


