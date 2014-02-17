// Copyright (C) 2014 dot42
//
// Original filename: Android.Hardware.Usb.cs
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
namespace Android.Hardware.Usb
{
		/// <summary>
		/// <para>This class is used for sending and receiving data and control messages to a USB device. Instances of this class are created by UsbManager#openDevice. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/usb/UsbDeviceConnection
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbDeviceConnection", AccessFlags = 33)]
		public partial class UsbDeviceConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UsbDeviceConnection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Releases all system resources related to the device. Once the object is closed it cannot be used again. The client must call UsbManager#openDevice again to retrieve a new instance to reestablish communication with the device. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the native file descriptor for the device, or -1 if the device is not opened. This is intended for passing to native code to access the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the native file descriptor </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				[Dot42.DexImport("getFileDescriptor", "()I", AccessFlags = 1)]
				public virtual int GetFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the raw USB descriptors for the device. This can be used to access descriptors not supported directly via the higher level APIs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>raw USB descriptors </para>
				/// </returns>
				/// <java-name>
				/// getRawDescriptors
				/// </java-name>
				[Dot42.DexImport("getRawDescriptors", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetRawDescriptors() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the raw USB descriptors for the device. This can be used to access descriptors not supported directly via the higher level APIs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>raw USB descriptors </para>
				/// </returns>
				/// <java-name>
				/// getRawDescriptors
				/// </java-name>
				[Dot42.DexImport("getRawDescriptors", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetRawDescriptors() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Claims exclusive access to a android.hardware.usb.UsbInterface. This must be done before sending or receiving data on any android.hardware.usb.UsbEndpoints belonging to the interface.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the interface was successfully claimed </para>
				/// </returns>
				/// <java-name>
				/// claimInterface
				/// </java-name>
				[Dot42.DexImport("claimInterface", "(Landroid/hardware/usb/UsbInterface;Z)Z", AccessFlags = 1)]
				public virtual bool ClaimInterface(global::Android.Hardware.Usb.UsbInterface intf, bool force) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Releases exclusive access to a android.hardware.usb.UsbInterface.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the interface was successfully released </para>
				/// </returns>
				/// <java-name>
				/// releaseInterface
				/// </java-name>
				[Dot42.DexImport("releaseInterface", "(Landroid/hardware/usb/UsbInterface;)Z", AccessFlags = 1)]
				public virtual bool ReleaseInterface(global::Android.Hardware.Usb.UsbInterface intf) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs a control transaction on endpoint zero for this device. The direction of the transfer is determined by the request type. If requestType &amp; UsbConstants#USB_ENDPOINT_DIR_MASK is UsbConstants#USB_DIR_OUT, then the transfer is a write, and if it is UsbConstants#USB_DIR_IN, then the transfer is a read. </para><para>This method transfers data starting from index 0 in the buffer. To specify a different offset, use controlTransfer(int, int, int, int, byte[], int, int, int). </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>length of data transferred (or zero) for success, or negative value for failure </para>
				/// </returns>
				/// <java-name>
				/// controlTransfer
				/// </java-name>
				[Dot42.DexImport("controlTransfer", "(IIII[BII)I", AccessFlags = 1)]
				public virtual int ControlTransfer(int requestType, int request, int value, int index, sbyte[] buffer, int length, int timeout) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Performs a control transaction on endpoint zero for this device. The direction of the transfer is determined by the request type. If requestType &amp; UsbConstants#USB_ENDPOINT_DIR_MASK is UsbConstants#USB_DIR_OUT, then the transfer is a write, and if it is UsbConstants#USB_DIR_IN, then the transfer is a read. </para><para>This method transfers data starting from index 0 in the buffer. To specify a different offset, use controlTransfer(int, int, int, int, byte[], int, int, int). </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>length of data transferred (or zero) for success, or negative value for failure </para>
				/// </returns>
				/// <java-name>
				/// controlTransfer
				/// </java-name>
				[Dot42.DexImport("controlTransfer", "(IIII[BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int ControlTransfer(int requestType, int request, int value, int index, byte[] buffer, int length, int timeout) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Performs a bulk transaction on the given endpoint. The direction of the transfer is determined by the direction of the endpoint. </para><para>This method transfers data starting from index 0 in the buffer. To specify a different offset, use bulkTransfer(UsbEndpoint, byte[], int, int, int). </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>length of data transferred (or zero) for success, or negative value for failure </para>
				/// </returns>
				/// <java-name>
				/// bulkTransfer
				/// </java-name>
				[Dot42.DexImport("bulkTransfer", "(Landroid/hardware/usb/UsbEndpoint;[BII)I", AccessFlags = 1)]
				public virtual int BulkTransfer(global::Android.Hardware.Usb.UsbEndpoint endpoint, sbyte[] buffer, int length, int timeout) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Performs a bulk transaction on the given endpoint. The direction of the transfer is determined by the direction of the endpoint. </para><para>This method transfers data starting from index 0 in the buffer. To specify a different offset, use bulkTransfer(UsbEndpoint, byte[], int, int, int). </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>length of data transferred (or zero) for success, or negative value for failure </para>
				/// </returns>
				/// <java-name>
				/// bulkTransfer
				/// </java-name>
				[Dot42.DexImport("bulkTransfer", "(Landroid/hardware/usb/UsbEndpoint;[BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int BulkTransfer(global::Android.Hardware.Usb.UsbEndpoint endpoint, byte[] buffer, int length, int timeout) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Waits for the result of a android.hardware.usb.UsbRequest#queue operation Note that this may return requests queued on multiple android.hardware.usb.UsbEndpoints. When multiple endpoints are in use, android.hardware.usb.UsbRequest#getEndpoint and android.hardware.usb.UsbRequest#getClientData can be useful in determining how to process the result of this function.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a completed USB request, or null if an error occurred </para>
				/// </returns>
				/// <java-name>
				/// requestWait
				/// </java-name>
				[Dot42.DexImport("requestWait", "()Landroid/hardware/usb/UsbRequest;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbRequest RequestWait() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbRequest);
				}

				/// <summary>
				/// <para>Returns the serial number for the device. This will return null if the device has not been opened.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device serial number </para>
				/// </returns>
				/// <java-name>
				/// getSerial
				/// </java-name>
				[Dot42.DexImport("getSerial", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSerial() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the native file descriptor for the device, or -1 if the device is not opened. This is intended for passing to native code to access the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the native file descriptor </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public int FileDescriptor
				{
				[Dot42.DexImport("getFileDescriptor", "()I", AccessFlags = 1)]
						get{ return GetFileDescriptor(); }
				}

				/// <summary>
				/// <para>Returns the raw USB descriptors for the device. This can be used to access descriptors not supported directly via the higher level APIs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>raw USB descriptors </para>
				/// </returns>
				/// <java-name>
				/// getRawDescriptors
				/// </java-name>
				public byte[] RawDescriptors
				{
				[Dot42.DexImport("getRawDescriptors", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetRawDescriptors(); }
				}

				/// <summary>
				/// <para>Returns the serial number for the device. This will return null if the device has not been opened.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device serial number </para>
				/// </returns>
				/// <java-name>
				/// getSerial
				/// </java-name>
				public string Serial
				{
				[Dot42.DexImport("getSerial", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSerial(); }
				}

		}

		/// <summary>
		/// <para>This class represents a USB device attached to the android device with the android device acting as the USB host. Each device contains one or more UsbInterfaces, each of which contains a number of UsbEndpoints (the channels via which data is transmitted over USB).</para><para>This class contains information (along with UsbInterface and UsbEndpoint) that describes the capabilities of the USB device. To communicate with the device, you open a UsbDeviceConnection for the device and use UsbRequest to send and receive data on an endpoint. UsbDeviceConnection#controlTransfer is used for control requests on endpoint zero.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about communicating with USB hardware, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/usb/UsbDevice
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbDevice", AccessFlags = 33)]
		public partial class UsbDevice : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Hardware.Usb.UsbDevice> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UsbDevice() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the device. In the standard implementation, this is the path of the device file for the device in the usbfs file system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device name </para>
				/// </returns>
				/// <java-name>
				/// getDeviceName
				/// </java-name>
				[Dot42.DexImport("getDeviceName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDeviceName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a unique integer ID for the device. This is a convenience for clients that want to use an integer to represent the device, rather than the device name. IDs are not persistent across USB disconnects.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device ID </para>
				/// </returns>
				/// <java-name>
				/// getDeviceId
				/// </java-name>
				[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 1)]
				public virtual int GetDeviceId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a vendor ID for the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device vendor ID </para>
				/// </returns>
				/// <java-name>
				/// getVendorId
				/// </java-name>
				[Dot42.DexImport("getVendorId", "()I", AccessFlags = 1)]
				public virtual int GetVendorId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a product ID for the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device product ID </para>
				/// </returns>
				/// <java-name>
				/// getProductId
				/// </java-name>
				[Dot42.DexImport("getProductId", "()I", AccessFlags = 1)]
				public virtual int GetProductId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the devices's class field. Some useful constants for USB device classes can be found in UsbConstants.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the devices's class </para>
				/// </returns>
				/// <java-name>
				/// getDeviceClass
				/// </java-name>
				[Dot42.DexImport("getDeviceClass", "()I", AccessFlags = 1)]
				public virtual int GetDeviceClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the device's subclass field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device's subclass </para>
				/// </returns>
				/// <java-name>
				/// getDeviceSubclass
				/// </java-name>
				[Dot42.DexImport("getDeviceSubclass", "()I", AccessFlags = 1)]
				public virtual int GetDeviceSubclass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the device's protocol field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device's protocol </para>
				/// </returns>
				/// <java-name>
				/// getDeviceProtocol
				/// </java-name>
				[Dot42.DexImport("getDeviceProtocol", "()I", AccessFlags = 1)]
				public virtual int GetDeviceProtocol() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the number of UsbInterfaces this device contains.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of interfaces </para>
				/// </returns>
				/// <java-name>
				/// getInterfaceCount
				/// </java-name>
				[Dot42.DexImport("getInterfaceCount", "()I", AccessFlags = 1)]
				public virtual int GetInterfaceCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the UsbInterface at the given index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface </para>
				/// </returns>
				/// <java-name>
				/// getInterface
				/// </java-name>
				[Dot42.DexImport("getInterface", "(I)Landroid/hardware/usb/UsbInterface;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbInterface GetInterface(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbInterface);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
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
				/// <para>Flatten this object in to a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDeviceId
				/// </java-name>
				[Dot42.DexImport("getDeviceId", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetDeviceId(string name) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDeviceName
				/// </java-name>
				[Dot42.DexImport("getDeviceName", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetDeviceName(int id) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the name of the device. In the standard implementation, this is the path of the device file for the device in the usbfs file system.</para><para></para>        
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
				/// <para>Returns a unique integer ID for the device. This is a convenience for clients that want to use an integer to represent the device, rather than the device name. IDs are not persistent across USB disconnects.</para><para></para>        
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
				/// <para>Returns a vendor ID for the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device vendor ID </para>
				/// </returns>
				/// <java-name>
				/// getVendorId
				/// </java-name>
				public int VendorId
				{
				[Dot42.DexImport("getVendorId", "()I", AccessFlags = 1)]
						get{ return GetVendorId(); }
				}

				/// <summary>
				/// <para>Returns a product ID for the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device product ID </para>
				/// </returns>
				/// <java-name>
				/// getProductId
				/// </java-name>
				public int ProductId
				{
				[Dot42.DexImport("getProductId", "()I", AccessFlags = 1)]
						get{ return GetProductId(); }
				}

				/// <summary>
				/// <para>Returns the devices's class field. Some useful constants for USB device classes can be found in UsbConstants.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the devices's class </para>
				/// </returns>
				/// <java-name>
				/// getDeviceClass
				/// </java-name>
				public int DeviceClass
				{
				[Dot42.DexImport("getDeviceClass", "()I", AccessFlags = 1)]
						get{ return GetDeviceClass(); }
				}

				/// <summary>
				/// <para>Returns the device's subclass field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device's subclass </para>
				/// </returns>
				/// <java-name>
				/// getDeviceSubclass
				/// </java-name>
				public int DeviceSubclass
				{
				[Dot42.DexImport("getDeviceSubclass", "()I", AccessFlags = 1)]
						get{ return GetDeviceSubclass(); }
				}

				/// <summary>
				/// <para>Returns the device's protocol field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the device's protocol </para>
				/// </returns>
				/// <java-name>
				/// getDeviceProtocol
				/// </java-name>
				public int DeviceProtocol
				{
				[Dot42.DexImport("getDeviceProtocol", "()I", AccessFlags = 1)]
						get{ return GetDeviceProtocol(); }
				}

				/// <summary>
				/// <para>Returns the number of UsbInterfaces this device contains.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of interfaces </para>
				/// </returns>
				/// <java-name>
				/// getInterfaceCount
				/// </java-name>
				public int InterfaceCount
				{
				[Dot42.DexImport("getInterfaceCount", "()I", AccessFlags = 1)]
						get{ return GetInterfaceCount(); }
				}

		}

		/// <summary>
		/// <para>This class allows you to access the state of USB and communicate with USB devices. Currently only host mode is supported in the public API.</para><para>You can obtain an instance of this class by calling Context.getSystemService().</para><para>{ UsbManager manager = (UsbManager) getSystemService(Context.USB_SERVICE);}</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about communicating with USB hardware, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/usb/UsbManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbManager", AccessFlags = 33)]
		public partial class UsbManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Broadcast Action: A broadcast for USB device attached event.</para><para>This intent is sent when a USB device is attached to the USB bus when in host mode. <ul><li><para>EXTRA_DEVICE containing the android.hardware.usb.UsbDevice for the attached device </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_USB_DEVICE_ATTACHED
				/// </java-name>
				[Dot42.DexImport("ACTION_USB_DEVICE_ATTACHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USB_DEVICE_ATTACHED = "android.hardware.usb.action.USB_DEVICE_ATTACHED";
				/// <summary>
				/// <para>Broadcast Action: A broadcast for USB device detached event.</para><para>This intent is sent when a USB device is detached from the USB bus when in host mode. <ul><li><para>EXTRA_DEVICE containing the android.hardware.usb.UsbDevice for the detached device </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_USB_DEVICE_DETACHED
				/// </java-name>
				[Dot42.DexImport("ACTION_USB_DEVICE_DETACHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USB_DEVICE_DETACHED = "android.hardware.usb.action.USB_DEVICE_DETACHED";
				/// <summary>
				/// <para>Broadcast Action: A broadcast for USB accessory attached event.</para><para>This intent is sent when a USB accessory is attached. <ul><li><para>EXTRA_ACCESSORY containing the android.hardware.usb.UsbAccessory for the attached accessory </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_USB_ACCESSORY_ATTACHED
				/// </java-name>
				[Dot42.DexImport("ACTION_USB_ACCESSORY_ATTACHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USB_ACCESSORY_ATTACHED = "android.hardware.usb.action.USB_ACCESSORY_ATTACHED";
				/// <summary>
				/// <para>Broadcast Action: A broadcast for USB accessory detached event.</para><para>This intent is sent when a USB accessory is detached. <ul><li><para>EXTRA_ACCESSORY containing the UsbAccessory for the attached accessory that was detached </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_USB_ACCESSORY_DETACHED
				/// </java-name>
				[Dot42.DexImport("ACTION_USB_ACCESSORY_DETACHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USB_ACCESSORY_DETACHED = "android.hardware.usb.action.USB_ACCESSORY_DETACHED";
				/// <summary>
				/// <para>Name of extra for ACTION_USB_DEVICE_ATTACHED and ACTION_USB_DEVICE_DETACHED broadcasts containing the UsbDevice object for the device. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_DEVICE
				/// </java-name>
				[Dot42.DexImport("EXTRA_DEVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DEVICE = "device";
				/// <summary>
				/// <para>Name of extra for ACTION_USB_ACCESSORY_ATTACHED and ACTION_USB_ACCESSORY_DETACHED broadcasts containing the UsbAccessory object for the accessory. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_ACCESSORY
				/// </java-name>
				[Dot42.DexImport("EXTRA_ACCESSORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ACCESSORY = "accessory";
				/// <summary>
				/// <para>Name of extra added to the android.app.PendingIntent passed into requestPermission(UsbDevice, PendingIntent) or requestPermission(UsbAccessory, PendingIntent) containing a boolean value indicating whether the user granted permission or not. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PERMISSION_GRANTED
				/// </java-name>
				[Dot42.DexImport("EXTRA_PERMISSION_GRANTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PERMISSION_GRANTED = "permission";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UsbManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a HashMap containing all USB devices currently attached. USB device name is the key for the returned HashMap. The result will be empty if no devices are attached, or if USB host mode is inactive or unsupported.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>HashMap containing all connected USB devices. </para>
				/// </returns>
				/// <java-name>
				/// getDeviceList
				/// </java-name>
				[Dot42.DexImport("getDeviceList", "()Ljava/util/HashMap;", AccessFlags = 1, Signature = "()Ljava/util/HashMap<Ljava/lang/String;Landroid/hardware/usb/UsbDevice;>;")]
				public virtual global::Java.Util.HashMap<string, global::Android.Hardware.Usb.UsbDevice> GetDeviceList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.HashMap<string, global::Android.Hardware.Usb.UsbDevice>);
				}

				/// <summary>
				/// <para>Opens the device so it can be used to send and receive data using android.hardware.usb.UsbRequest.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a UsbDeviceConnection, or <c> null </c> if open failed </para>
				/// </returns>
				/// <java-name>
				/// openDevice
				/// </java-name>
				[Dot42.DexImport("openDevice", "(Landroid/hardware/usb/UsbDevice;)Landroid/hardware/usb/UsbDeviceConnection;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbDeviceConnection OpenDevice(global::Android.Hardware.Usb.UsbDevice device) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbDeviceConnection);
				}

				/// <summary>
				/// <para>Returns a list of currently attached USB accessories. (in the current implementation there can be at most one)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of USB accessories, or null if none are attached. </para>
				/// </returns>
				/// <java-name>
				/// getAccessoryList
				/// </java-name>
				[Dot42.DexImport("getAccessoryList", "()[Landroid/hardware/usb/UsbAccessory;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbAccessory[] GetAccessoryList() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbAccessory[]);
				}

				/// <summary>
				/// <para>Opens a file descriptor for reading and writing data to the USB accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>file descriptor, or null if the accessor could not be opened. </para>
				/// </returns>
				/// <java-name>
				/// openAccessory
				/// </java-name>
				[Dot42.DexImport("openAccessory", "(Landroid/hardware/usb/UsbAccessory;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Os.ParcelFileDescriptor OpenAccessory(global::Android.Hardware.Usb.UsbAccessory accessory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <summary>
				/// <para>Returns true if the caller has permission to access the device. Permission might have been granted temporarily via requestPermission(UsbDevice, PendingIntent) or by the user choosing the caller as the default application for the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if caller has permission </para>
				/// </returns>
				/// <java-name>
				/// hasPermission
				/// </java-name>
				[Dot42.DexImport("hasPermission", "(Landroid/hardware/usb/UsbDevice;)Z", AccessFlags = 1)]
				public virtual bool HasPermission(global::Android.Hardware.Usb.UsbDevice device) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if the caller has permission to access the device. Permission might have been granted temporarily via requestPermission(UsbDevice, PendingIntent) or by the user choosing the caller as the default application for the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if caller has permission </para>
				/// </returns>
				/// <java-name>
				/// hasPermission
				/// </java-name>
				[Dot42.DexImport("hasPermission", "(Landroid/hardware/usb/UsbAccessory;)Z", AccessFlags = 1)]
				public virtual bool HasPermission(global::Android.Hardware.Usb.UsbAccessory device) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Requests temporary permission for the given package to access the device. This may result in a system dialog being displayed to the user if permission had not already been granted. Success or failure is returned via the android.app.PendingIntent pi. If successful, this grants the caller permission to access the device only until the device is disconnected.</para><para>The following extras will be added to pi: <ul><li><para>EXTRA_DEVICE containing the device passed into this call </para></li><li><para>EXTRA_PERMISSION_GRANTED containing boolean indicating whether permission was granted by the user </para></li></ul></para><para></para>        
				/// </summary>
				/// <java-name>
				/// requestPermission
				/// </java-name>
				[Dot42.DexImport("requestPermission", "(Landroid/hardware/usb/UsbDevice;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestPermission(global::Android.Hardware.Usb.UsbDevice device, global::Android.App.PendingIntent pi) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Requests temporary permission for the given package to access the device. This may result in a system dialog being displayed to the user if permission had not already been granted. Success or failure is returned via the android.app.PendingIntent pi. If successful, this grants the caller permission to access the device only until the device is disconnected.</para><para>The following extras will be added to pi: <ul><li><para>EXTRA_DEVICE containing the device passed into this call </para></li><li><para>EXTRA_PERMISSION_GRANTED containing boolean indicating whether permission was granted by the user </para></li></ul></para><para></para>        
				/// </summary>
				/// <java-name>
				/// requestPermission
				/// </java-name>
				[Dot42.DexImport("requestPermission", "(Landroid/hardware/usb/UsbAccessory;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestPermission(global::Android.Hardware.Usb.UsbAccessory device, global::Android.App.PendingIntent pi) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a HashMap containing all USB devices currently attached. USB device name is the key for the returned HashMap. The result will be empty if no devices are attached, or if USB host mode is inactive or unsupported.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>HashMap containing all connected USB devices. </para>
				/// </returns>
				/// <java-name>
				/// getDeviceList
				/// </java-name>
				public global::Java.Util.HashMap<string, global::Android.Hardware.Usb.UsbDevice> DeviceList
				{
				[Dot42.DexImport("getDeviceList", "()Ljava/util/HashMap;", AccessFlags = 1, Signature = "()Ljava/util/HashMap<Ljava/lang/String;Landroid/hardware/usb/UsbDevice;>;")]
						get{ return GetDeviceList(); }
				}

				/// <summary>
				/// <para>Returns a list of currently attached USB accessories. (in the current implementation there can be at most one)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of USB accessories, or null if none are attached. </para>
				/// </returns>
				/// <java-name>
				/// getAccessoryList
				/// </java-name>
				public global::Android.Hardware.Usb.UsbAccessory[] AccessoryList
				{
				[Dot42.DexImport("getAccessoryList", "()[Landroid/hardware/usb/UsbAccessory;", AccessFlags = 1)]
						get{ return GetAccessoryList(); }
				}

		}

		/// <summary>
		/// <para>A class representing USB request packet. This can be used for both reading and writing data to or from a android.hardware.usb.UsbDeviceConnection. UsbRequests can be used to transfer data on bulk and interrupt endpoints. Requests on bulk endpoints can be sent synchronously via UsbDeviceConnection#bulkTransfer or asynchronously via queue and UsbDeviceConnection#requestWait. Requests on interrupt endpoints are only send and received asynchronously.</para><para>Requests on endpoint zero are not supported by this class; use UsbDeviceConnection#controlTransfer for endpoint zero requests instead. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/usb/UsbRequest
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbRequest", AccessFlags = 33)]
		public partial class UsbRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UsbRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes the request so it can read or write data on the given endpoint. Whether the request allows reading or writing depends on the direction of the endpoint.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the request was successfully opened. </para>
				/// </returns>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/hardware/usb/UsbDeviceConnection;Landroid/hardware/usb/UsbEndpoint;)Z", AccessFlags = 1)]
				public virtual bool Initialize(global::Android.Hardware.Usb.UsbDeviceConnection connection, global::Android.Hardware.Usb.UsbEndpoint endpoint) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Releases all resources related to this request. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~UsbRequest() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the endpoint for the request, or null if the request is not opened.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the request's endpoint </para>
				/// </returns>
				/// <java-name>
				/// getEndpoint
				/// </java-name>
				[Dot42.DexImport("getEndpoint", "()Landroid/hardware/usb/UsbEndpoint;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbEndpoint GetEndpoint() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbEndpoint);
				}

				/// <summary>
				/// <para>Returns the client data for the request. This can be used in conjunction with setClientData to associate another object with this request, which can be useful for maintaining state between calls to queue and android.hardware.usb.UsbDeviceConnection#requestWait</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the client data for the request </para>
				/// </returns>
				/// <java-name>
				/// getClientData
				/// </java-name>
				[Dot42.DexImport("getClientData", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetClientData() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Sets the client data for the request. This can be used in conjunction with getClientData to associate another object with this request, which can be useful for maintaining state between calls to queue and android.hardware.usb.UsbDeviceConnection#requestWait</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setClientData
				/// </java-name>
				[Dot42.DexImport("setClientData", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetClientData(object data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Queues the request to send or receive data on its endpoint. For OUT endpoints, the given buffer data will be sent on the endpoint. For IN endpoints, the endpoint will attempt to read the given number of bytes into the specified buffer. If the queueing operation is successful, we return true and the result will be returned via android.hardware.usb.UsbDeviceConnection#requestWait</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the queueing operation succeeded </para>
				/// </returns>
				/// <java-name>
				/// queue
				/// </java-name>
				[Dot42.DexImport("queue", "(Ljava/nio/ByteBuffer;I)Z", AccessFlags = 1)]
				public virtual bool Queue(global::Java.Nio.ByteBuffer buffer, int length) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Cancels a pending queue operation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if cancelling succeeded </para>
				/// </returns>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()Z", AccessFlags = 1)]
				public virtual bool Cancel() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the endpoint for the request, or null if the request is not opened.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the request's endpoint </para>
				/// </returns>
				/// <java-name>
				/// getEndpoint
				/// </java-name>
				public global::Android.Hardware.Usb.UsbEndpoint Endpoint
				{
				[Dot42.DexImport("getEndpoint", "()Landroid/hardware/usb/UsbEndpoint;", AccessFlags = 1)]
						get{ return GetEndpoint(); }
				}

				/// <summary>
				/// <para>Returns the client data for the request. This can be used in conjunction with setClientData to associate another object with this request, which can be useful for maintaining state between calls to queue and android.hardware.usb.UsbDeviceConnection#requestWait</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the client data for the request </para>
				/// </returns>
				/// <java-name>
				/// getClientData
				/// </java-name>
				public object ClientData
				{
				[Dot42.DexImport("getClientData", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetClientData(); }
				[Dot42.DexImport("setClientData", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						set{ SetClientData(value); }
				}

		}

		/// <summary>
		/// <para>A class representing a USB accessory, which is an external hardware component that communicates with an android application over USB. The accessory is the USB host and android the device side of the USB connection.</para><para>When the accessory connects, it reports its manufacturer and model names, the version of the accessory, and a user visible description of the accessory to the device. The manufacturer, model and version strings are used by the USB Manager to choose an appropriate application for the accessory. The accessory may optionally provide a unique serial number and a URL to for the accessory's website to the device as well.</para><para>An instance of this class is sent to the application via the UsbManager#ACTION_USB_ACCESSORY_ATTACHED Intent. The application can then call UsbManager#openAccessory to open a file descriptor for reading and writing data to and from the accessory.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about communicating with USB hardware, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/usb/UsbAccessory
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbAccessory", AccessFlags = 33)]
		public partial class UsbAccessory : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Hardware.Usb.UsbAccessory> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UsbAccessory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the manufacturer name of the accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory manufacturer </para>
				/// </returns>
				/// <java-name>
				/// getManufacturer
				/// </java-name>
				[Dot42.DexImport("getManufacturer", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetManufacturer() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the model name of the accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory model </para>
				/// </returns>
				/// <java-name>
				/// getModel
				/// </java-name>
				[Dot42.DexImport("getModel", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetModel() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a user visible description of the accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory description </para>
				/// </returns>
				/// <java-name>
				/// getDescription
				/// </java-name>
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDescription() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the version of the accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory version </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetVersion() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the URI for the accessory. This is an optional URI that might show information about the accessory or provide the option to download an application for the accessory</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory URI </para>
				/// </returns>
				/// <java-name>
				/// getUri
				/// </java-name>
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUri() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the unique serial number for the accessory. This is an optional serial number that can be used to differentiate between individual accessories of the same model and manufacturer</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unique serial number </para>
				/// </returns>
				/// <java-name>
				/// getSerial
				/// </java-name>
				[Dot42.DexImport("getSerial", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSerial() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
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
				/// <para>Flatten this object in to a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the manufacturer name of the accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory manufacturer </para>
				/// </returns>
				/// <java-name>
				/// getManufacturer
				/// </java-name>
				public string Manufacturer
				{
				[Dot42.DexImport("getManufacturer", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetManufacturer(); }
				}

				/// <summary>
				/// <para>Returns the model name of the accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory model </para>
				/// </returns>
				/// <java-name>
				/// getModel
				/// </java-name>
				public string Model
				{
				[Dot42.DexImport("getModel", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetModel(); }
				}

				/// <summary>
				/// <para>Returns a user visible description of the accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory description </para>
				/// </returns>
				/// <java-name>
				/// getDescription
				/// </java-name>
				public string Description
				{
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDescription(); }
				}

				/// <summary>
				/// <para>Returns the version of the accessory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory version </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public string Version
				{
				[Dot42.DexImport("getVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns the URI for the accessory. This is an optional URI that might show information about the accessory or provide the option to download an application for the accessory</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the accessory URI </para>
				/// </returns>
				/// <java-name>
				/// getUri
				/// </java-name>
				public string Uri
				{
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUri(); }
				}

				/// <summary>
				/// <para>Returns the unique serial number for the accessory. This is an optional serial number that can be used to differentiate between individual accessories of the same model and manufacturer</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unique serial number </para>
				/// </returns>
				/// <java-name>
				/// getSerial
				/// </java-name>
				public string Serial
				{
				[Dot42.DexImport("getSerial", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSerial(); }
				}

		}

		/// <summary>
		/// <para>A class representing an interface on a UsbDevice. USB devices can have one or more interfaces, each one providing a different piece of functionality, separate from the other interfaces. An interface will have one or more UsbEndpoints, which are the channels by which the host transfers data with the device.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about communicating with USB hardware, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/usb/UsbInterface
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbInterface", AccessFlags = 33)]
		public partial class UsbInterface : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Hardware.Usb.UsbInterface> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UsbInterface() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the interface's ID field. This is an integer that uniquely identifies the interface on the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface's ID </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
				public virtual int GetId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the interface's class field. Some useful constants for USB classes can be found in UsbConstants</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface's class </para>
				/// </returns>
				/// <java-name>
				/// getInterfaceClass
				/// </java-name>
				[Dot42.DexImport("getInterfaceClass", "()I", AccessFlags = 1)]
				public virtual int GetInterfaceClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the interface's subclass field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface's subclass </para>
				/// </returns>
				/// <java-name>
				/// getInterfaceSubclass
				/// </java-name>
				[Dot42.DexImport("getInterfaceSubclass", "()I", AccessFlags = 1)]
				public virtual int GetInterfaceSubclass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the interface's protocol field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface's protocol </para>
				/// </returns>
				/// <java-name>
				/// getInterfaceProtocol
				/// </java-name>
				[Dot42.DexImport("getInterfaceProtocol", "()I", AccessFlags = 1)]
				public virtual int GetInterfaceProtocol() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the number of android.hardware.usb.UsbEndpoints this interface contains.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of endpoints </para>
				/// </returns>
				/// <java-name>
				/// getEndpointCount
				/// </java-name>
				[Dot42.DexImport("getEndpointCount", "()I", AccessFlags = 1)]
				public virtual int GetEndpointCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the android.hardware.usb.UsbEndpoint at the given index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint </para>
				/// </returns>
				/// <java-name>
				/// getEndpoint
				/// </java-name>
				[Dot42.DexImport("getEndpoint", "(I)Landroid/hardware/usb/UsbEndpoint;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbEndpoint GetEndpoint(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbEndpoint);
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
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
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
				/// <para>Flatten this object in to a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the interface's ID field. This is an integer that uniquely identifies the interface on the device.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface's ID </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <summary>
				/// <para>Returns the interface's class field. Some useful constants for USB classes can be found in UsbConstants</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface's class </para>
				/// </returns>
				/// <java-name>
				/// getInterfaceClass
				/// </java-name>
				public int InterfaceClass
				{
				[Dot42.DexImport("getInterfaceClass", "()I", AccessFlags = 1)]
						get{ return GetInterfaceClass(); }
				}

				/// <summary>
				/// <para>Returns the interface's subclass field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface's subclass </para>
				/// </returns>
				/// <java-name>
				/// getInterfaceSubclass
				/// </java-name>
				public int InterfaceSubclass
				{
				[Dot42.DexImport("getInterfaceSubclass", "()I", AccessFlags = 1)]
						get{ return GetInterfaceSubclass(); }
				}

				/// <summary>
				/// <para>Returns the interface's protocol field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the interface's protocol </para>
				/// </returns>
				/// <java-name>
				/// getInterfaceProtocol
				/// </java-name>
				public int InterfaceProtocol
				{
				[Dot42.DexImport("getInterfaceProtocol", "()I", AccessFlags = 1)]
						get{ return GetInterfaceProtocol(); }
				}

				/// <summary>
				/// <para>Returns the number of android.hardware.usb.UsbEndpoints this interface contains.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of endpoints </para>
				/// </returns>
				/// <java-name>
				/// getEndpointCount
				/// </java-name>
				public int EndpointCount
				{
				[Dot42.DexImport("getEndpointCount", "()I", AccessFlags = 1)]
						get{ return GetEndpointCount(); }
				}

		}

		/// <summary>
		/// <para>A class representing an endpoint on a UsbInterface. Endpoints are the channels for sending and receiving data over USB. Typically bulk endpoints are used for sending non-trivial amounts of data. Interrupt endpoints are used for sending small amounts of data, typically events, separately from the main data streams. The endpoint zero is a special endpoint for control messages sent from the host to device. Isochronous endpoints are currently unsupported. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/usb/UsbEndpoint
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbEndpoint", AccessFlags = 33)]
		public partial class UsbEndpoint : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Hardware.Usb.UsbEndpoint> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UsbEndpoint() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the endpoint's address field. The address is a bitfield containing both the endpoint number as well as the data direction of the endpoint. the endpoint number and direction can also be accessed via getEndpointNumber and getDirection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's address </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()I", AccessFlags = 1)]
				public virtual int GetAddress() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Extracts the endpoint's endpoint number from its address</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's endpoint number </para>
				/// </returns>
				/// <java-name>
				/// getEndpointNumber
				/// </java-name>
				[Dot42.DexImport("getEndpointNumber", "()I", AccessFlags = 1)]
				public virtual int GetEndpointNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the endpoint's direction. Returns UsbConstants#USB_DIR_OUT if the direction is host to device, and UsbConstants#USB_DIR_IN if the direction is device to host. <para>UsbConstants#USB_DIR_IN </para><simplesectsep></simplesectsep><para>UsbConstants#USB_DIR_OUT</para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's direction </para>
				/// </returns>
				/// <java-name>
				/// getDirection
				/// </java-name>
				[Dot42.DexImport("getDirection", "()I", AccessFlags = 1)]
				public virtual int GetDirection() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the endpoint's attributes field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's attributes </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()I", AccessFlags = 1)]
				public virtual int GetAttributes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the endpoint's type. Possible results are: <ul><li><para>UsbConstants#USB_ENDPOINT_XFER_CONTROL (endpoint zero) </para></li><li><para>UsbConstants#USB_ENDPOINT_XFER_ISOC (isochronous endpoint) </para></li><li><para>UsbConstants#USB_ENDPOINT_XFER_BULK (bulk endpoint) </para></li><li><para>UsbConstants#USB_ENDPOINT_XFER_INT (interrupt endpoint) </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
				public new virtual int GetType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the endpoint's maximum packet size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's maximum packet size </para>
				/// </returns>
				/// <java-name>
				/// getMaxPacketSize
				/// </java-name>
				[Dot42.DexImport("getMaxPacketSize", "()I", AccessFlags = 1)]
				public virtual int GetMaxPacketSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the endpoint's interval field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's interval </para>
				/// </returns>
				/// <java-name>
				/// getInterval
				/// </java-name>
				[Dot42.DexImport("getInterval", "()I", AccessFlags = 1)]
				public virtual int GetInterval() /* MethodBuilder.Create */ 
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
				/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
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
				/// <para>Flatten this object in to a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the endpoint's address field. The address is a bitfield containing both the endpoint number as well as the data direction of the endpoint. the endpoint number and direction can also be accessed via getEndpointNumber and getDirection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's address </para>
				/// </returns>
				/// <java-name>
				/// getAddress
				/// </java-name>
				public int Address
				{
				[Dot42.DexImport("getAddress", "()I", AccessFlags = 1)]
						get{ return GetAddress(); }
				}

				/// <summary>
				/// <para>Extracts the endpoint's endpoint number from its address</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's endpoint number </para>
				/// </returns>
				/// <java-name>
				/// getEndpointNumber
				/// </java-name>
				public int EndpointNumber
				{
				[Dot42.DexImport("getEndpointNumber", "()I", AccessFlags = 1)]
						get{ return GetEndpointNumber(); }
				}

				/// <summary>
				/// <para>Returns the endpoint's direction. Returns UsbConstants#USB_DIR_OUT if the direction is host to device, and UsbConstants#USB_DIR_IN if the direction is device to host. <para>UsbConstants#USB_DIR_IN </para><simplesectsep></simplesectsep><para>UsbConstants#USB_DIR_OUT</para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's direction </para>
				/// </returns>
				/// <java-name>
				/// getDirection
				/// </java-name>
				public int Direction
				{
				[Dot42.DexImport("getDirection", "()I", AccessFlags = 1)]
						get{ return GetDirection(); }
				}

				/// <summary>
				/// <para>Returns the endpoint's attributes field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's attributes </para>
				/// </returns>
				/// <java-name>
				/// getAttributes
				/// </java-name>
				public int Attributes
				{
				[Dot42.DexImport("getAttributes", "()I", AccessFlags = 1)]
						get{ return GetAttributes(); }
				}

				/// <summary>
				/// <para>Returns the endpoint's type. Possible results are: <ul><li><para>UsbConstants#USB_ENDPOINT_XFER_CONTROL (endpoint zero) </para></li><li><para>UsbConstants#USB_ENDPOINT_XFER_ISOC (isochronous endpoint) </para></li><li><para>UsbConstants#USB_ENDPOINT_XFER_BULK (bulk endpoint) </para></li><li><para>UsbConstants#USB_ENDPOINT_XFER_INT (interrupt endpoint) </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
				[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return GetType(); }
				}

				/// <summary>
				/// <para>Returns the endpoint's maximum packet size.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's maximum packet size </para>
				/// </returns>
				/// <java-name>
				/// getMaxPacketSize
				/// </java-name>
				public int MaxPacketSize
				{
				[Dot42.DexImport("getMaxPacketSize", "()I", AccessFlags = 1)]
						get{ return GetMaxPacketSize(); }
				}

				/// <summary>
				/// <para>Returns the endpoint's interval field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the endpoint's interval </para>
				/// </returns>
				/// <java-name>
				/// getInterval
				/// </java-name>
				public int Interval
				{
				[Dot42.DexImport("getInterval", "()I", AccessFlags = 1)]
						get{ return GetInterval(); }
				}

		}

		/// <summary>
		/// <para>Contains constants for the USB protocol. These constants correspond to definitions in linux/usb/ch9.h in the linux kernel. </para>    
		/// </summary>
		/// <java-name>
		/// android/hardware/usb/UsbConstants
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbConstants", AccessFlags = 49)]
		public sealed partial class UsbConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Bitmask used for extracting the UsbEndpoint direction from its address field. <para>UsbEndpoint::getAddress </para><simplesectsep></simplesectsep><para>UsbEndpoint::getDirection </para><simplesectsep></simplesectsep><para>USB_DIR_OUT </para><simplesectsep></simplesectsep><para>USB_DIR_IN </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_ENDPOINT_DIR_MASK
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_DIR_MASK", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_DIR_MASK = 128;
				/// <summary>
				/// <para>Used to signify direction of data for a UsbEndpoint is OUT (host to device) <para>UsbEndpoint::getDirection </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_DIR_OUT
				/// </java-name>
				[Dot42.DexImport("USB_DIR_OUT", "I", AccessFlags = 25)]
				public const int USB_DIR_OUT = 0;
				/// <summary>
				/// <para>Used to signify direction of data for a UsbEndpoint is IN (device to host) <para>UsbEndpoint::getDirection </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_DIR_IN
				/// </java-name>
				[Dot42.DexImport("USB_DIR_IN", "I", AccessFlags = 25)]
				public const int USB_DIR_IN = 128;
				/// <summary>
				/// <para>Bitmask used for extracting the UsbEndpoint number its address field. <para>UsbEndpoint::getAddress </para><simplesectsep></simplesectsep><para>UsbEndpoint::getEndpointNumber </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_ENDPOINT_NUMBER_MASK
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_NUMBER_MASK", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_NUMBER_MASK = 15;
				/// <summary>
				/// <para>Bitmask used for extracting the UsbEndpoint type from its address field. <para>UsbEndpoint::getAddress </para><simplesectsep></simplesectsep><para>UsbEndpoint::getType </para><simplesectsep></simplesectsep><para>USB_ENDPOINT_XFER_CONTROL </para><simplesectsep></simplesectsep><para>USB_ENDPOINT_XFER_ISOC </para><simplesectsep></simplesectsep><para>USB_ENDPOINT_XFER_BULK </para><simplesectsep></simplesectsep><para>USB_ENDPOINT_XFER_INT </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_ENDPOINT_XFERTYPE_MASK
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFERTYPE_MASK", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFERTYPE_MASK = 3;
				/// <summary>
				/// <para>Control endpoint type (endpoint zero) <para>UsbEndpoint::getType </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_ENDPOINT_XFER_CONTROL
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFER_CONTROL", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFER_CONTROL = 0;
				/// <summary>
				/// <para>Isochronous endpoint type (currently not supported) <para>UsbEndpoint::getType </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_ENDPOINT_XFER_ISOC
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFER_ISOC", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFER_ISOC = 1;
				/// <summary>
				/// <para>Bulk endpoint type <para>UsbEndpoint::getType </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_ENDPOINT_XFER_BULK
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFER_BULK", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFER_BULK = 2;
				/// <summary>
				/// <para>Interrupt endpoint type <para>UsbEndpoint::getType </para></para>        
				/// </summary>
				/// <java-name>
				/// USB_ENDPOINT_XFER_INT
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFER_INT", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFER_INT = 3;
				/// <summary>
				/// <para>Bitmask used for encoding the request type for a control request on endpoint zero. </para>        
				/// </summary>
				/// <java-name>
				/// USB_TYPE_MASK
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_MASK", "I", AccessFlags = 25)]
				public const int USB_TYPE_MASK = 96;
				/// <summary>
				/// <para>Used to specify that an endpoint zero control request is a standard request. </para>        
				/// </summary>
				/// <java-name>
				/// USB_TYPE_STANDARD
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_STANDARD", "I", AccessFlags = 25)]
				public const int USB_TYPE_STANDARD = 0;
				/// <summary>
				/// <para>Used to specify that an endpoint zero control request is a class specific request. </para>        
				/// </summary>
				/// <java-name>
				/// USB_TYPE_CLASS
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_CLASS", "I", AccessFlags = 25)]
				public const int USB_TYPE_CLASS = 32;
				/// <summary>
				/// <para>Used to specify that an endpoint zero control request is a vendor specific request. </para>        
				/// </summary>
				/// <java-name>
				/// USB_TYPE_VENDOR
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_VENDOR", "I", AccessFlags = 25)]
				public const int USB_TYPE_VENDOR = 64;
				/// <summary>
				/// <para>Reserved endpoint zero control request type (currently unused). </para>        
				/// </summary>
				/// <java-name>
				/// USB_TYPE_RESERVED
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_RESERVED", "I", AccessFlags = 25)]
				public const int USB_TYPE_RESERVED = 96;
				/// <summary>
				/// <para>USB class indicating that the class is determined on a per-interface basis. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_PER_INTERFACE
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_PER_INTERFACE", "I", AccessFlags = 25)]
				public const int USB_CLASS_PER_INTERFACE = 0;
				/// <summary>
				/// <para>USB class for audio devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_AUDIO
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_AUDIO", "I", AccessFlags = 25)]
				public const int USB_CLASS_AUDIO = 1;
				/// <summary>
				/// <para>USB class for communication devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_COMM
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_COMM", "I", AccessFlags = 25)]
				public const int USB_CLASS_COMM = 2;
				/// <summary>
				/// <para>USB class for human interface devices (for example, mice and keyboards). </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_HID
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_HID", "I", AccessFlags = 25)]
				public const int USB_CLASS_HID = 3;
				/// <summary>
				/// <para>USB class for physical devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_PHYSICA
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_PHYSICA", "I", AccessFlags = 25)]
				public const int USB_CLASS_PHYSICA = 5;
				/// <summary>
				/// <para>USB class for still image devices (digital cameras). </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_STILL_IMAGE
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_STILL_IMAGE", "I", AccessFlags = 25)]
				public const int USB_CLASS_STILL_IMAGE = 6;
				/// <summary>
				/// <para>USB class for printers. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_PRINTER
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_PRINTER", "I", AccessFlags = 25)]
				public const int USB_CLASS_PRINTER = 7;
				/// <summary>
				/// <para>USB class for mass storage devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_MASS_STORAGE
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_MASS_STORAGE", "I", AccessFlags = 25)]
				public const int USB_CLASS_MASS_STORAGE = 8;
				/// <summary>
				/// <para>USB class for USB hubs. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_HUB
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_HUB", "I", AccessFlags = 25)]
				public const int USB_CLASS_HUB = 9;
				/// <summary>
				/// <para>USB class for CDC devices (communications device class). </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_CDC_DATA
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_CDC_DATA", "I", AccessFlags = 25)]
				public const int USB_CLASS_CDC_DATA = 10;
				/// <summary>
				/// <para>USB class for content smart card devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_CSCID
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_CSCID", "I", AccessFlags = 25)]
				public const int USB_CLASS_CSCID = 11;
				/// <summary>
				/// <para>USB class for content security devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_CONTENT_SEC
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_CONTENT_SEC", "I", AccessFlags = 25)]
				public const int USB_CLASS_CONTENT_SEC = 13;
				/// <summary>
				/// <para>USB class for video devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_VIDEO
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_VIDEO", "I", AccessFlags = 25)]
				public const int USB_CLASS_VIDEO = 14;
				/// <summary>
				/// <para>USB class for wireless controller devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_WIRELESS_CONTROLLER
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_WIRELESS_CONTROLLER", "I", AccessFlags = 25)]
				public const int USB_CLASS_WIRELESS_CONTROLLER = 224;
				/// <summary>
				/// <para>USB class for wireless miscellaneous devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_MISC
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_MISC", "I", AccessFlags = 25)]
				public const int USB_CLASS_MISC = 239;
				/// <summary>
				/// <para>Application specific USB class. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_APP_SPEC
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_APP_SPEC", "I", AccessFlags = 25)]
				public const int USB_CLASS_APP_SPEC = 254;
				/// <summary>
				/// <para>Vendor specific USB class. </para>        
				/// </summary>
				/// <java-name>
				/// USB_CLASS_VENDOR_SPEC
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_VENDOR_SPEC", "I", AccessFlags = 25)]
				public const int USB_CLASS_VENDOR_SPEC = 255;
				/// <summary>
				/// <para>Boot subclass for HID devices. </para>        
				/// </summary>
				/// <java-name>
				/// USB_INTERFACE_SUBCLASS_BOOT
				/// </java-name>
				[Dot42.DexImport("USB_INTERFACE_SUBCLASS_BOOT", "I", AccessFlags = 25)]
				public const int USB_INTERFACE_SUBCLASS_BOOT = 1;
				/// <summary>
				/// <para>Vendor specific USB subclass. </para>        
				/// </summary>
				/// <java-name>
				/// USB_SUBCLASS_VENDOR_SPEC
				/// </java-name>
				[Dot42.DexImport("USB_SUBCLASS_VENDOR_SPEC", "I", AccessFlags = 25)]
				public const int USB_SUBCLASS_VENDOR_SPEC = 255;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UsbConstants() /* MethodBuilder.Create */ 
				{
				}

		}

}


