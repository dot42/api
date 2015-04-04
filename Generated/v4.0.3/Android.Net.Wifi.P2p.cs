#pragma warning disable 1717
namespace Android.Net.Wifi.P2p
{
		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pConfig
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pConfig", AccessFlags = 33)]
		public partial class WifiP2pConfig : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// deviceAddress
				/// </java-name>
				[Dot42.DexImport("deviceAddress", "Ljava/lang/String;", AccessFlags = 1)]
				public string DeviceAddress;
				/// <java-name>
				/// wps
				/// </java-name>
				[Dot42.DexImport("wps", "Landroid/net/wifi/WpsInfo;", AccessFlags = 1)]
				public global::Android.Net.Wifi.WpsInfo Wps;
				/// <java-name>
				/// groupOwnerIntent
				/// </java-name>
				[Dot42.DexImport("groupOwnerIntent", "I", AccessFlags = 1)]
				public int GroupOwnerIntent;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pConfig> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pConfig() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pConfig;)V", AccessFlags = 1)]
				public WifiP2pConfig(global::Android.Net.Wifi.P2p.WifiP2pConfig wifiP2pConfig) /* MethodBuilder.Create */ 
				{
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pDevice
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pDevice", AccessFlags = 33)]
		public partial class WifiP2pDevice : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// deviceName
				/// </java-name>
				[Dot42.DexImport("deviceName", "Ljava/lang/String;", AccessFlags = 1)]
				public string DeviceName;
				/// <java-name>
				/// deviceAddress
				/// </java-name>
				[Dot42.DexImport("deviceAddress", "Ljava/lang/String;", AccessFlags = 1)]
				public string DeviceAddress;
				/// <java-name>
				/// primaryDeviceType
				/// </java-name>
				[Dot42.DexImport("primaryDeviceType", "Ljava/lang/String;", AccessFlags = 1)]
				public string PrimaryDeviceType;
				/// <java-name>
				/// secondaryDeviceType
				/// </java-name>
				[Dot42.DexImport("secondaryDeviceType", "Ljava/lang/String;", AccessFlags = 1)]
				public string SecondaryDeviceType;
				/// <java-name>
				/// CONNECTED
				/// </java-name>
				[Dot42.DexImport("CONNECTED", "I", AccessFlags = 25)]
				public const int CONNECTED = 0;
				/// <java-name>
				/// INVITED
				/// </java-name>
				[Dot42.DexImport("INVITED", "I", AccessFlags = 25)]
				public const int INVITED = 1;
				/// <java-name>
				/// FAILED
				/// </java-name>
				[Dot42.DexImport("FAILED", "I", AccessFlags = 25)]
				public const int FAILED = 2;
				/// <java-name>
				/// AVAILABLE
				/// </java-name>
				[Dot42.DexImport("AVAILABLE", "I", AccessFlags = 25)]
				public const int AVAILABLE = 3;
				/// <java-name>
				/// UNAVAILABLE
				/// </java-name>
				[Dot42.DexImport("UNAVAILABLE", "I", AccessFlags = 25)]
				public const int UNAVAILABLE = 4;
				/// <java-name>
				/// status
				/// </java-name>
				[Dot42.DexImport("status", "I", AccessFlags = 1)]
				public int Status;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pDevice> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pDevice() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pDevice;)V", AccessFlags = 1)]
				public WifiP2pDevice(global::Android.Net.Wifi.P2p.WifiP2pDevice wifiP2pDevice) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// wpsPbcSupported
				/// </java-name>
				[Dot42.DexImport("wpsPbcSupported", "()Z", AccessFlags = 1)]
				public virtual bool WpsPbcSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// wpsKeypadSupported
				/// </java-name>
				[Dot42.DexImport("wpsKeypadSupported", "()Z", AccessFlags = 1)]
				public virtual bool WpsKeypadSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// wpsDisplaySupported
				/// </java-name>
				[Dot42.DexImport("wpsDisplaySupported", "()Z", AccessFlags = 1)]
				public virtual bool WpsDisplaySupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isServiceDiscoveryCapable
				/// </java-name>
				[Dot42.DexImport("isServiceDiscoveryCapable", "()Z", AccessFlags = 1)]
				public virtual bool IsServiceDiscoveryCapable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isGroupOwner
				/// </java-name>
				[Dot42.DexImport("isGroupOwner", "()Z", AccessFlags = 1)]
				public virtual bool IsGroupOwner() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pDeviceList
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pDeviceList", AccessFlags = 33)]
		public partial class WifiP2pDeviceList : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pDeviceList> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pDeviceList() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pDeviceList;)V", AccessFlags = 1)]
				public WifiP2pDeviceList(global::Android.Net.Wifi.P2p.WifiP2pDeviceList wifiP2pDeviceList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDeviceList
				/// </java-name>
				[Dot42.DexImport("getDeviceList", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Landroid/net/wifi/p2p/WifiP2pDevice;>;")]
				public virtual global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice> GetDeviceList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice>);
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDeviceList
				/// </java-name>
				public global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice> DeviceList
				{
				[Dot42.DexImport("getDeviceList", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Landroid/net/wifi/p2p/WifiP2pDevice;>;")]
						get{ return GetDeviceList(); }
				}

		}

		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pGroup
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pGroup", AccessFlags = 33)]
		public partial class WifiP2pGroup : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pGroup> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pGroup() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pGroup;)V", AccessFlags = 1)]
				public WifiP2pGroup(global::Android.Net.Wifi.P2p.WifiP2pGroup wifiP2pGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNetworkName
				/// </java-name>
				[Dot42.DexImport("getNetworkName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetNetworkName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isGroupOwner
				/// </java-name>
				[Dot42.DexImport("isGroupOwner", "()Z", AccessFlags = 1)]
				public virtual bool IsGroupOwner() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getOwner
				/// </java-name>
				[Dot42.DexImport("getOwner", "()Landroid/net/wifi/p2p/WifiP2pDevice;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.P2p.WifiP2pDevice GetOwner() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.WifiP2pDevice);
				}

				/// <java-name>
				/// getClientList
				/// </java-name>
				[Dot42.DexImport("getClientList", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Landroid/net/wifi/p2p/WifiP2pDevice;>;")]
				public virtual global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice> GetClientList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice>);
				}

				/// <java-name>
				/// getPassphrase
				/// </java-name>
				[Dot42.DexImport("getPassphrase", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPassphrase() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInterface
				/// </java-name>
				[Dot42.DexImport("getInterface", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetInterface() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNetworkName
				/// </java-name>
				public string NetworkName
				{
				[Dot42.DexImport("getNetworkName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetNetworkName(); }
				}

				/// <java-name>
				/// getOwner
				/// </java-name>
				public global::Android.Net.Wifi.P2p.WifiP2pDevice Owner
				{
				[Dot42.DexImport("getOwner", "()Landroid/net/wifi/p2p/WifiP2pDevice;", AccessFlags = 1)]
						get{ return GetOwner(); }
				}

				/// <java-name>
				/// getClientList
				/// </java-name>
				public global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice> ClientList
				{
				[Dot42.DexImport("getClientList", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Landroid/net/wifi/p2p/WifiP2pDevice;>;")]
						get{ return GetClientList(); }
				}

				/// <java-name>
				/// getPassphrase
				/// </java-name>
				public string Passphrase
				{
				[Dot42.DexImport("getPassphrase", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPassphrase(); }
				}

				/// <java-name>
				/// getInterface
				/// </java-name>
				public string Interface
				{
				[Dot42.DexImport("getInterface", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetInterface(); }
				}

		}

		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pInfo", AccessFlags = 33)]
		public partial class WifiP2pInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// groupFormed
				/// </java-name>
				[Dot42.DexImport("groupFormed", "Z", AccessFlags = 1)]
				public bool GroupFormed;
				/// <java-name>
				/// isGroupOwner
				/// </java-name>
				[Dot42.DexImport("isGroupOwner", "Z", AccessFlags = 1)]
				public bool IsGroupOwner;
				/// <java-name>
				/// groupOwnerAddress
				/// </java-name>
				[Dot42.DexImport("groupOwnerAddress", "Ljava/net/InetAddress;", AccessFlags = 1)]
				public global::Java.Net.InetAddress GroupOwnerAddress;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pInfo;)V", AccessFlags = 1)]
				public WifiP2pInfo(global::Android.Net.Wifi.P2p.WifiP2pInfo wifiP2pInfo) /* MethodBuilder.Create */ 
				{
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
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pManager
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager", AccessFlags = 33)]
		public partial class WifiP2pManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// WIFI_P2P_STATE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_STATE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_STATE_CHANGED_ACTION = "android.net.wifi.p2p.STATE_CHANGED";
				/// <java-name>
				/// EXTRA_WIFI_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_STATE = "wifi_p2p_state";
				/// <java-name>
				/// WIFI_P2P_STATE_DISABLED
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_STATE_DISABLED", "I", AccessFlags = 25)]
				public const int WIFI_P2P_STATE_DISABLED = 1;
				/// <java-name>
				/// WIFI_P2P_STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_STATE_ENABLED", "I", AccessFlags = 25)]
				public const int WIFI_P2P_STATE_ENABLED = 2;
				/// <java-name>
				/// WIFI_P2P_CONNECTION_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_CONNECTION_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_CONNECTION_CHANGED_ACTION = "android.net.wifi.p2p.CONNECTION_STATE_CHANGE";
				/// <java-name>
				/// EXTRA_WIFI_P2P_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_P2P_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_P2P_INFO = "wifiP2pInfo";
				/// <java-name>
				/// EXTRA_NETWORK_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_NETWORK_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NETWORK_INFO = "networkInfo";
				/// <java-name>
				/// WIFI_P2P_PEERS_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_PEERS_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_PEERS_CHANGED_ACTION = "android.net.wifi.p2p.PEERS_CHANGED";
				/// <java-name>
				/// WIFI_P2P_THIS_DEVICE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_THIS_DEVICE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_THIS_DEVICE_CHANGED_ACTION = "android.net.wifi.p2p.THIS_DEVICE_CHANGED";
				/// <java-name>
				/// EXTRA_WIFI_P2P_DEVICE
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_P2P_DEVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_P2P_DEVICE = "wifiP2pDevice";
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = 0;
				/// <java-name>
				/// P2P_UNSUPPORTED
				/// </java-name>
				[Dot42.DexImport("P2P_UNSUPPORTED", "I", AccessFlags = 25)]
				public const int P2P_UNSUPPORTED = 1;
				/// <java-name>
				/// BUSY
				/// </java-name>
				[Dot42.DexImport("BUSY", "I", AccessFlags = 25)]
				public const int BUSY = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiP2pManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/content/Context;Landroid/os/Looper;Landroid/net/wifi/p2p/WifiP2pManager" +
    "$ChannelListener;)Landroid/net/wifi/p2p/WifiP2pManager$Channel;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.P2p.WifiP2pManager.Channel Initialize(global::Android.Content.Context context, global::Android.OS.Looper looper, global::Android.Net.Wifi.P2p.WifiP2pManager.IChannelListener channelListener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel);
				}

				/// <java-name>
				/// discoverPeers
				/// </java-name>
				[Dot42.DexImport("discoverPeers", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ActionListener;)V", AccessFlags = 1)]
				public virtual void DiscoverPeers(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel channel, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener actionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pConfig" +
    ";Landroid/net/wifi/p2p/WifiP2pManager$ActionListener;)V", AccessFlags = 1)]
				public virtual void Connect(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel channel, global::Android.Net.Wifi.P2p.WifiP2pConfig wifiP2pConfig, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener actionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancelConnect
				/// </java-name>
				[Dot42.DexImport("cancelConnect", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ActionListener;)V", AccessFlags = 1)]
				public virtual void CancelConnect(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel channel, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener actionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createGroup
				/// </java-name>
				[Dot42.DexImport("createGroup", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ActionListener;)V", AccessFlags = 1)]
				public virtual void CreateGroup(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel channel, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener actionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeGroup
				/// </java-name>
				[Dot42.DexImport("removeGroup", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ActionListener;)V", AccessFlags = 1)]
				public virtual void RemoveGroup(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel channel, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener actionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestPeers
				/// </java-name>
				[Dot42.DexImport("requestPeers", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$PeerListListener;)V", AccessFlags = 1)]
				public virtual void RequestPeers(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel channel, global::Android.Net.Wifi.P2p.WifiP2pManager.IPeerListListener peerListListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestConnectionInfo
				/// </java-name>
				[Dot42.DexImport("requestConnectionInfo", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ConnectionInfoListener;)V", AccessFlags = 1)]
				public virtual void RequestConnectionInfo(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel channel, global::Android.Net.Wifi.P2p.WifiP2pManager.IConnectionInfoListener connectionInfoListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestGroupInfo
				/// </java-name>
				[Dot42.DexImport("requestGroupInfo", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$GroupInfoListener;)V", AccessFlags = 1)]
				public virtual void RequestGroupInfo(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel channel, global::Android.Net.Wifi.P2p.WifiP2pManager.IGroupInfoListener groupInfoListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$Channel
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$Channel", AccessFlags = 9)]
				public partial class Channel
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Channel() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$GroupInfoListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$GroupInfoListener", AccessFlags = 1545)]
				public partial interface IGroupInfoListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGroupInfoAvailable
						/// </java-name>
						[Dot42.DexImport("onGroupInfoAvailable", "(Landroid/net/wifi/p2p/WifiP2pGroup;)V", AccessFlags = 1025)]
						void OnGroupInfoAvailable(global::Android.Net.Wifi.P2p.WifiP2pGroup wifiP2pGroup) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$ConnectionInfoListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$ConnectionInfoListener", AccessFlags = 1545)]
				public partial interface IConnectionInfoListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onConnectionInfoAvailable
						/// </java-name>
						[Dot42.DexImport("onConnectionInfoAvailable", "(Landroid/net/wifi/p2p/WifiP2pInfo;)V", AccessFlags = 1025)]
						void OnConnectionInfoAvailable(global::Android.Net.Wifi.P2p.WifiP2pInfo wifiP2pInfo) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$PeerListListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$PeerListListener", AccessFlags = 1545)]
				public partial interface IPeerListListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPeersAvailable
						/// </java-name>
						[Dot42.DexImport("onPeersAvailable", "(Landroid/net/wifi/p2p/WifiP2pDeviceList;)V", AccessFlags = 1025)]
						void OnPeersAvailable(global::Android.Net.Wifi.P2p.WifiP2pDeviceList wifiP2pDeviceList) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$ActionListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$ActionListener", AccessFlags = 1545)]
				public partial interface IActionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSuccess
						/// </java-name>
						[Dot42.DexImport("onSuccess", "()V", AccessFlags = 1025)]
						void OnSuccess() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onFailure
						/// </java-name>
						[Dot42.DexImport("onFailure", "(I)V", AccessFlags = 1025)]
						void OnFailure(int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$ChannelListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$ChannelListener", AccessFlags = 1545)]
				public partial interface IChannelListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onChannelDisconnected
						/// </java-name>
						[Dot42.DexImport("onChannelDisconnected", "()V", AccessFlags = 1025)]
						void OnChannelDisconnected() /* MethodBuilder.Create */ ;

				}

		}

}

