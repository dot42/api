#pragma warning disable 1717
namespace Android.Hardware.Usb
{
		/// <java-name>
		/// android/hardware/usb/UsbManager
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbManager", AccessFlags = 33)]
		public partial class UsbManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_USB_DEVICE_ATTACHED
				/// </java-name>
				[Dot42.DexImport("ACTION_USB_DEVICE_ATTACHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USB_DEVICE_ATTACHED = "android.hardware.usb.action.USB_DEVICE_ATTACHED";
				/// <java-name>
				/// ACTION_USB_DEVICE_DETACHED
				/// </java-name>
				[Dot42.DexImport("ACTION_USB_DEVICE_DETACHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USB_DEVICE_DETACHED = "android.hardware.usb.action.USB_DEVICE_DETACHED";
				/// <java-name>
				/// ACTION_USB_ACCESSORY_ATTACHED
				/// </java-name>
				[Dot42.DexImport("ACTION_USB_ACCESSORY_ATTACHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USB_ACCESSORY_ATTACHED = "android.hardware.usb.action.USB_ACCESSORY_ATTACHED";
				/// <java-name>
				/// ACTION_USB_ACCESSORY_DETACHED
				/// </java-name>
				[Dot42.DexImport("ACTION_USB_ACCESSORY_DETACHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_USB_ACCESSORY_DETACHED = "android.hardware.usb.action.USB_ACCESSORY_DETACHED";
				/// <java-name>
				/// EXTRA_DEVICE
				/// </java-name>
				[Dot42.DexImport("EXTRA_DEVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DEVICE = "device";
				/// <java-name>
				/// EXTRA_ACCESSORY
				/// </java-name>
				[Dot42.DexImport("EXTRA_ACCESSORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ACCESSORY = "accessory";
				/// <java-name>
				/// EXTRA_PERMISSION_GRANTED
				/// </java-name>
				[Dot42.DexImport("EXTRA_PERMISSION_GRANTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PERMISSION_GRANTED = "permission";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal UsbManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDeviceList
				/// </java-name>
				[Dot42.DexImport("getDeviceList", "()Ljava/util/HashMap;", AccessFlags = 1, Signature = "()Ljava/util/HashMap<Ljava/lang/String;Landroid/hardware/usb/UsbDevice;>;")]
				public virtual global::Java.Util.HashMap<string, global::Android.Hardware.Usb.UsbDevice> GetDeviceList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.HashMap<string, global::Android.Hardware.Usb.UsbDevice>);
				}

				/// <java-name>
				/// openDevice
				/// </java-name>
				[Dot42.DexImport("openDevice", "(Landroid/hardware/usb/UsbDevice;)Landroid/hardware/usb/UsbDeviceConnection;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbDeviceConnection OpenDevice(global::Android.Hardware.Usb.UsbDevice usbDevice) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbDeviceConnection);
				}

				/// <java-name>
				/// getAccessoryList
				/// </java-name>
				[Dot42.DexImport("getAccessoryList", "()[Landroid/hardware/usb/UsbAccessory;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbAccessory[] GetAccessoryList() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbAccessory[]);
				}

				/// <java-name>
				/// openAccessory
				/// </java-name>
				[Dot42.DexImport("openAccessory", "(Landroid/hardware/usb/UsbAccessory;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public virtual global::Android.Os.ParcelFileDescriptor OpenAccessory(global::Android.Hardware.Usb.UsbAccessory usbAccessory) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.ParcelFileDescriptor);
				}

				/// <java-name>
				/// hasPermission
				/// </java-name>
				[Dot42.DexImport("hasPermission", "(Landroid/hardware/usb/UsbDevice;)Z", AccessFlags = 1)]
				public virtual bool HasPermission(global::Android.Hardware.Usb.UsbDevice usbDevice) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasPermission
				/// </java-name>
				[Dot42.DexImport("hasPermission", "(Landroid/hardware/usb/UsbAccessory;)Z", AccessFlags = 1)]
				public virtual bool HasPermission(global::Android.Hardware.Usb.UsbAccessory usbAccessory) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestPermission
				/// </java-name>
				[Dot42.DexImport("requestPermission", "(Landroid/hardware/usb/UsbDevice;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestPermission(global::Android.Hardware.Usb.UsbDevice usbDevice, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestPermission
				/// </java-name>
				[Dot42.DexImport("requestPermission", "(Landroid/hardware/usb/UsbAccessory;Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void RequestPermission(global::Android.Hardware.Usb.UsbAccessory usbAccessory, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDeviceList
				/// </java-name>
				public global::Java.Util.HashMap<string, global::Android.Hardware.Usb.UsbDevice> DeviceList
				{
				[Dot42.DexImport("getDeviceList", "()Ljava/util/HashMap;", AccessFlags = 1, Signature = "()Ljava/util/HashMap<Ljava/lang/String;Landroid/hardware/usb/UsbDevice;>;")]
						get{ return GetDeviceList(); }
				}

				/// <java-name>
				/// getAccessoryList
				/// </java-name>
				public global::Android.Hardware.Usb.UsbAccessory[] AccessoryList
				{
				[Dot42.DexImport("getAccessoryList", "()[Landroid/hardware/usb/UsbAccessory;", AccessFlags = 1)]
						get{ return GetAccessoryList(); }
				}

		}

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

				/// <java-name>
				/// getManufacturer
				/// </java-name>
				[Dot42.DexImport("getManufacturer", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetManufacturer() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getModel
				/// </java-name>
				[Dot42.DexImport("getModel", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetModel() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDescription() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetVersion() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUri() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getManufacturer
				/// </java-name>
				public string Manufacturer
				{
				[Dot42.DexImport("getManufacturer", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetManufacturer(); }
				}

				/// <java-name>
				/// getModel
				/// </java-name>
				public string Model
				{
				[Dot42.DexImport("getModel", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetModel(); }
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				public string Description
				{
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDescription(); }
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public string Version
				{
				[Dot42.DexImport("getVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				public string Uri
				{
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUri(); }
				}

				/// <java-name>
				/// getSerial
				/// </java-name>
				public string Serial
				{
				[Dot42.DexImport("getSerial", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSerial(); }
				}

		}

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

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				[Dot42.DexImport("getFileDescriptor", "()I", AccessFlags = 1)]
				public virtual int GetFileDescriptor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRawDescriptors
				/// </java-name>
				[Dot42.DexImport("getRawDescriptors", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetRawDescriptors() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getRawDescriptors
				/// </java-name>
				[Dot42.DexImport("getRawDescriptors", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetRawDescriptors() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// claimInterface
				/// </java-name>
				[Dot42.DexImport("claimInterface", "(Landroid/hardware/usb/UsbInterface;Z)Z", AccessFlags = 1)]
				public virtual bool ClaimInterface(global::Android.Hardware.Usb.UsbInterface usbInterface, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// releaseInterface
				/// </java-name>
				[Dot42.DexImport("releaseInterface", "(Landroid/hardware/usb/UsbInterface;)Z", AccessFlags = 1)]
				public virtual bool ReleaseInterface(global::Android.Hardware.Usb.UsbInterface usbInterface) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// controlTransfer
				/// </java-name>
				[Dot42.DexImport("controlTransfer", "(IIII[BII)I", AccessFlags = 1)]
				public virtual int ControlTransfer(int int32, int int321, int int322, int int323, sbyte[] sByte, int int324, int int325) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// controlTransfer
				/// </java-name>
				[Dot42.DexImport("controlTransfer", "(IIII[BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int ControlTransfer(int int32, int int321, int int322, int int323, byte[] @byte, int int324, int int325) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// bulkTransfer
				/// </java-name>
				[Dot42.DexImport("bulkTransfer", "(Landroid/hardware/usb/UsbEndpoint;[BII)I", AccessFlags = 1)]
				public virtual int BulkTransfer(global::Android.Hardware.Usb.UsbEndpoint usbEndpoint, sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// bulkTransfer
				/// </java-name>
				[Dot42.DexImport("bulkTransfer", "(Landroid/hardware/usb/UsbEndpoint;[BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int BulkTransfer(global::Android.Hardware.Usb.UsbEndpoint usbEndpoint, byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// requestWait
				/// </java-name>
				[Dot42.DexImport("requestWait", "()Landroid/hardware/usb/UsbRequest;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbRequest RequestWait() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbRequest);
				}

				/// <java-name>
				/// getSerial
				/// </java-name>
				[Dot42.DexImport("getSerial", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSerial() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public int FileDescriptor
				{
				[Dot42.DexImport("getFileDescriptor", "()I", AccessFlags = 1)]
						get{ return GetFileDescriptor(); }
				}

				/// <java-name>
				/// getRawDescriptors
				/// </java-name>
				public byte[] RawDescriptors
				{
				[Dot42.DexImport("getRawDescriptors", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetRawDescriptors(); }
				}

				/// <java-name>
				/// getSerial
				/// </java-name>
				public string Serial
				{
				[Dot42.DexImport("getSerial", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSerial(); }
				}

		}

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

				/// <java-name>
				/// getDeviceName
				/// </java-name>
				[Dot42.DexImport("getDeviceName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDeviceName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDeviceId
				/// </java-name>
				[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 1)]
				public virtual int GetDeviceId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getVendorId
				/// </java-name>
				[Dot42.DexImport("getVendorId", "()I", AccessFlags = 1)]
				public virtual int GetVendorId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getProductId
				/// </java-name>
				[Dot42.DexImport("getProductId", "()I", AccessFlags = 1)]
				public virtual int GetProductId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDeviceClass
				/// </java-name>
				[Dot42.DexImport("getDeviceClass", "()I", AccessFlags = 1)]
				public virtual int GetDeviceClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDeviceSubclass
				/// </java-name>
				[Dot42.DexImport("getDeviceSubclass", "()I", AccessFlags = 1)]
				public virtual int GetDeviceSubclass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDeviceProtocol
				/// </java-name>
				[Dot42.DexImport("getDeviceProtocol", "()I", AccessFlags = 1)]
				public virtual int GetDeviceProtocol() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInterfaceCount
				/// </java-name>
				[Dot42.DexImport("getInterfaceCount", "()I", AccessFlags = 1)]
				public virtual int GetInterfaceCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInterface
				/// </java-name>
				[Dot42.DexImport("getInterface", "(I)Landroid/hardware/usb/UsbInterface;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbInterface GetInterface(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbInterface);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDeviceId
				/// </java-name>
				[Dot42.DexImport("getDeviceId", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetDeviceId(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDeviceName
				/// </java-name>
				[Dot42.DexImport("getDeviceName", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetDeviceName(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDeviceName
				/// </java-name>
				public string DeviceName
				{
				[Dot42.DexImport("getDeviceName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDeviceName(); }
				}

				/// <java-name>
				/// getDeviceId
				/// </java-name>
				public int DeviceId
				{
				[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 1)]
						get{ return GetDeviceId(); }
				}

				/// <java-name>
				/// getVendorId
				/// </java-name>
				public int VendorId
				{
				[Dot42.DexImport("getVendorId", "()I", AccessFlags = 1)]
						get{ return GetVendorId(); }
				}

				/// <java-name>
				/// getProductId
				/// </java-name>
				public int ProductId
				{
				[Dot42.DexImport("getProductId", "()I", AccessFlags = 1)]
						get{ return GetProductId(); }
				}

				/// <java-name>
				/// getDeviceClass
				/// </java-name>
				public int DeviceClass
				{
				[Dot42.DexImport("getDeviceClass", "()I", AccessFlags = 1)]
						get{ return GetDeviceClass(); }
				}

				/// <java-name>
				/// getDeviceSubclass
				/// </java-name>
				public int DeviceSubclass
				{
				[Dot42.DexImport("getDeviceSubclass", "()I", AccessFlags = 1)]
						get{ return GetDeviceSubclass(); }
				}

				/// <java-name>
				/// getDeviceProtocol
				/// </java-name>
				public int DeviceProtocol
				{
				[Dot42.DexImport("getDeviceProtocol", "()I", AccessFlags = 1)]
						get{ return GetDeviceProtocol(); }
				}

				/// <java-name>
				/// getInterfaceCount
				/// </java-name>
				public int InterfaceCount
				{
				[Dot42.DexImport("getInterfaceCount", "()I", AccessFlags = 1)]
						get{ return GetInterfaceCount(); }
				}

		}

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

				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()I", AccessFlags = 1)]
				public virtual int GetAddress() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEndpointNumber
				/// </java-name>
				[Dot42.DexImport("getEndpointNumber", "()I", AccessFlags = 1)]
				public virtual int GetEndpointNumber() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDirection
				/// </java-name>
				[Dot42.DexImport("getDirection", "()I", AccessFlags = 1)]
				public virtual int GetDirection() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				[Dot42.DexImport("getAttributes", "()I", AccessFlags = 1)]
				public virtual int GetAttributes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
				public virtual int GetTypeJava() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMaxPacketSize
				/// </java-name>
				[Dot42.DexImport("getMaxPacketSize", "()I", AccessFlags = 1)]
				public virtual int GetMaxPacketSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				public int Address
				{
				[Dot42.DexImport("getAddress", "()I", AccessFlags = 1)]
						get{ return GetAddress(); }
				}

				/// <java-name>
				/// getEndpointNumber
				/// </java-name>
				public int EndpointNumber
				{
				[Dot42.DexImport("getEndpointNumber", "()I", AccessFlags = 1)]
						get{ return GetEndpointNumber(); }
				}

				/// <java-name>
				/// getDirection
				/// </java-name>
				public int Direction
				{
				[Dot42.DexImport("getDirection", "()I", AccessFlags = 1)]
						get{ return GetDirection(); }
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				public int Attributes
				{
				[Dot42.DexImport("getAttributes", "()I", AccessFlags = 1)]
						get{ return GetAttributes(); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
				[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return GetTypeJava(); }
				}

				/// <java-name>
				/// getMaxPacketSize
				/// </java-name>
				public int MaxPacketSize
				{
				[Dot42.DexImport("getMaxPacketSize", "()I", AccessFlags = 1)]
						get{ return GetMaxPacketSize(); }
				}

				/// <java-name>
				/// getInterval
				/// </java-name>
				public int Interval
				{
				[Dot42.DexImport("getInterval", "()I", AccessFlags = 1)]
						get{ return GetInterval(); }
				}

		}

		/// <java-name>
		/// android/hardware/usb/UsbConstants
		/// </java-name>
		[Dot42.DexImport("android/hardware/usb/UsbConstants", AccessFlags = 49)]
		public sealed partial class UsbConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// USB_ENDPOINT_DIR_MASK
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_DIR_MASK", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_DIR_MASK = 128;
				/// <java-name>
				/// USB_DIR_OUT
				/// </java-name>
				[Dot42.DexImport("USB_DIR_OUT", "I", AccessFlags = 25)]
				public const int USB_DIR_OUT = 0;
				/// <java-name>
				/// USB_DIR_IN
				/// </java-name>
				[Dot42.DexImport("USB_DIR_IN", "I", AccessFlags = 25)]
				public const int USB_DIR_IN = 128;
				/// <java-name>
				/// USB_ENDPOINT_NUMBER_MASK
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_NUMBER_MASK", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_NUMBER_MASK = 15;
				/// <java-name>
				/// USB_ENDPOINT_XFERTYPE_MASK
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFERTYPE_MASK", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFERTYPE_MASK = 3;
				/// <java-name>
				/// USB_ENDPOINT_XFER_CONTROL
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFER_CONTROL", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFER_CONTROL = 0;
				/// <java-name>
				/// USB_ENDPOINT_XFER_ISOC
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFER_ISOC", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFER_ISOC = 1;
				/// <java-name>
				/// USB_ENDPOINT_XFER_BULK
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFER_BULK", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFER_BULK = 2;
				/// <java-name>
				/// USB_ENDPOINT_XFER_INT
				/// </java-name>
				[Dot42.DexImport("USB_ENDPOINT_XFER_INT", "I", AccessFlags = 25)]
				public const int USB_ENDPOINT_XFER_INT = 3;
				/// <java-name>
				/// USB_TYPE_MASK
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_MASK", "I", AccessFlags = 25)]
				public const int USB_TYPE_MASK = 96;
				/// <java-name>
				/// USB_TYPE_STANDARD
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_STANDARD", "I", AccessFlags = 25)]
				public const int USB_TYPE_STANDARD = 0;
				/// <java-name>
				/// USB_TYPE_CLASS
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_CLASS", "I", AccessFlags = 25)]
				public const int USB_TYPE_CLASS = 32;
				/// <java-name>
				/// USB_TYPE_VENDOR
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_VENDOR", "I", AccessFlags = 25)]
				public const int USB_TYPE_VENDOR = 64;
				/// <java-name>
				/// USB_TYPE_RESERVED
				/// </java-name>
				[Dot42.DexImport("USB_TYPE_RESERVED", "I", AccessFlags = 25)]
				public const int USB_TYPE_RESERVED = 96;
				/// <java-name>
				/// USB_CLASS_PER_INTERFACE
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_PER_INTERFACE", "I", AccessFlags = 25)]
				public const int USB_CLASS_PER_INTERFACE = 0;
				/// <java-name>
				/// USB_CLASS_AUDIO
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_AUDIO", "I", AccessFlags = 25)]
				public const int USB_CLASS_AUDIO = 1;
				/// <java-name>
				/// USB_CLASS_COMM
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_COMM", "I", AccessFlags = 25)]
				public const int USB_CLASS_COMM = 2;
				/// <java-name>
				/// USB_CLASS_HID
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_HID", "I", AccessFlags = 25)]
				public const int USB_CLASS_HID = 3;
				/// <java-name>
				/// USB_CLASS_PHYSICA
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_PHYSICA", "I", AccessFlags = 25)]
				public const int USB_CLASS_PHYSICA = 5;
				/// <java-name>
				/// USB_CLASS_STILL_IMAGE
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_STILL_IMAGE", "I", AccessFlags = 25)]
				public const int USB_CLASS_STILL_IMAGE = 6;
				/// <java-name>
				/// USB_CLASS_PRINTER
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_PRINTER", "I", AccessFlags = 25)]
				public const int USB_CLASS_PRINTER = 7;
				/// <java-name>
				/// USB_CLASS_MASS_STORAGE
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_MASS_STORAGE", "I", AccessFlags = 25)]
				public const int USB_CLASS_MASS_STORAGE = 8;
				/// <java-name>
				/// USB_CLASS_HUB
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_HUB", "I", AccessFlags = 25)]
				public const int USB_CLASS_HUB = 9;
				/// <java-name>
				/// USB_CLASS_CDC_DATA
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_CDC_DATA", "I", AccessFlags = 25)]
				public const int USB_CLASS_CDC_DATA = 10;
				/// <java-name>
				/// USB_CLASS_CSCID
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_CSCID", "I", AccessFlags = 25)]
				public const int USB_CLASS_CSCID = 11;
				/// <java-name>
				/// USB_CLASS_CONTENT_SEC
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_CONTENT_SEC", "I", AccessFlags = 25)]
				public const int USB_CLASS_CONTENT_SEC = 13;
				/// <java-name>
				/// USB_CLASS_VIDEO
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_VIDEO", "I", AccessFlags = 25)]
				public const int USB_CLASS_VIDEO = 14;
				/// <java-name>
				/// USB_CLASS_WIRELESS_CONTROLLER
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_WIRELESS_CONTROLLER", "I", AccessFlags = 25)]
				public const int USB_CLASS_WIRELESS_CONTROLLER = 224;
				/// <java-name>
				/// USB_CLASS_MISC
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_MISC", "I", AccessFlags = 25)]
				public const int USB_CLASS_MISC = 239;
				/// <java-name>
				/// USB_CLASS_APP_SPEC
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_APP_SPEC", "I", AccessFlags = 25)]
				public const int USB_CLASS_APP_SPEC = 254;
				/// <java-name>
				/// USB_CLASS_VENDOR_SPEC
				/// </java-name>
				[Dot42.DexImport("USB_CLASS_VENDOR_SPEC", "I", AccessFlags = 25)]
				public const int USB_CLASS_VENDOR_SPEC = 255;
				/// <java-name>
				/// USB_INTERFACE_SUBCLASS_BOOT
				/// </java-name>
				[Dot42.DexImport("USB_INTERFACE_SUBCLASS_BOOT", "I", AccessFlags = 25)]
				public const int USB_INTERFACE_SUBCLASS_BOOT = 1;
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

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/hardware/usb/UsbDeviceConnection;Landroid/hardware/usb/UsbEndpoint;)Z", AccessFlags = 1)]
				public virtual bool Initialize(global::Android.Hardware.Usb.UsbDeviceConnection usbDeviceConnection, global::Android.Hardware.Usb.UsbEndpoint usbEndpoint) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

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

				/// <java-name>
				/// getEndpoint
				/// </java-name>
				[Dot42.DexImport("getEndpoint", "()Landroid/hardware/usb/UsbEndpoint;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbEndpoint GetEndpoint() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Hardware.Usb.UsbEndpoint);
				}

				/// <java-name>
				/// getClientData
				/// </java-name>
				[Dot42.DexImport("getClientData", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetClientData() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setClientData
				/// </java-name>
				[Dot42.DexImport("setClientData", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetClientData(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// queue
				/// </java-name>
				[Dot42.DexImport("queue", "(Ljava/nio/ByteBuffer;I)Z", AccessFlags = 1)]
				public virtual bool Queue(global::Java.Nio.ByteBuffer byteBuffer, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()Z", AccessFlags = 1)]
				public virtual bool Cancel() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getEndpoint
				/// </java-name>
				public global::Android.Hardware.Usb.UsbEndpoint Endpoint
				{
				[Dot42.DexImport("getEndpoint", "()Landroid/hardware/usb/UsbEndpoint;", AccessFlags = 1)]
						get{ return GetEndpoint(); }
				}

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

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
				public virtual int GetId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInterfaceClass
				/// </java-name>
				[Dot42.DexImport("getInterfaceClass", "()I", AccessFlags = 1)]
				public virtual int GetInterfaceClass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInterfaceSubclass
				/// </java-name>
				[Dot42.DexImport("getInterfaceSubclass", "()I", AccessFlags = 1)]
				public virtual int GetInterfaceSubclass() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInterfaceProtocol
				/// </java-name>
				[Dot42.DexImport("getInterfaceProtocol", "()I", AccessFlags = 1)]
				public virtual int GetInterfaceProtocol() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEndpointCount
				/// </java-name>
				[Dot42.DexImport("getEndpointCount", "()I", AccessFlags = 1)]
				public virtual int GetEndpointCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEndpoint
				/// </java-name>
				[Dot42.DexImport("getEndpoint", "(I)Landroid/hardware/usb/UsbEndpoint;", AccessFlags = 1)]
				public virtual global::Android.Hardware.Usb.UsbEndpoint GetEndpoint(int int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
				[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getInterfaceClass
				/// </java-name>
				public int InterfaceClass
				{
				[Dot42.DexImport("getInterfaceClass", "()I", AccessFlags = 1)]
						get{ return GetInterfaceClass(); }
				}

				/// <java-name>
				/// getInterfaceSubclass
				/// </java-name>
				public int InterfaceSubclass
				{
				[Dot42.DexImport("getInterfaceSubclass", "()I", AccessFlags = 1)]
						get{ return GetInterfaceSubclass(); }
				}

				/// <java-name>
				/// getInterfaceProtocol
				/// </java-name>
				public int InterfaceProtocol
				{
				[Dot42.DexImport("getInterfaceProtocol", "()I", AccessFlags = 1)]
						get{ return GetInterfaceProtocol(); }
				}

				/// <java-name>
				/// getEndpointCount
				/// </java-name>
				public int EndpointCount
				{
				[Dot42.DexImport("getEndpointCount", "()I", AccessFlags = 1)]
						get{ return GetEndpointCount(); }
				}

		}

}

