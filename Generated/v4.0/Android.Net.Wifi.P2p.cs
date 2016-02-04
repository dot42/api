#pragma warning disable 1717
namespace Android.Net.Wifi.P2p
{
		/// <summary>
		///  <para>A class representing a Wi-Fi P2p configuration for setting up a connection</para> <para>{ <para>WifiP2pManager} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pConfig
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pConfig", AccessFlags = 33)]
		public partial class WifiP2pConfig : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The device MAC address uniquely identifies a Wi-Fi p2p device </para>        
				/// </summary>
				/// <java-name>
				/// deviceAddress
				/// </java-name>
				[Dot42.DexImport("deviceAddress", "Ljava/lang/String;", AccessFlags = 1)]
				public string DeviceAddress;
				/// <summary>
				///  <para>Wi-Fi Protected Setup information </para>        
				/// </summary>
				/// <java-name>
				/// wps
				/// </java-name>
				[Dot42.DexImport("wps", "Landroid/net/wifi/WpsInfo;", AccessFlags = 1)]
				public global::Android.Net.Wifi.WpsInfo Wps;
				/// <summary>
				///  <para>This is an integer value between 0 and 15 where 0 indicates the least inclination to be a group owner and 15 indicates the highest inclination to be a group owner.</para> <para>A value of -1 indicates the system can choose an appropriate value. </para>        
				/// </summary>
				/// <java-name>
				/// groupOwnerIntent
				/// </java-name>
				[Dot42.DexImport("groupOwnerIntent", "I", AccessFlags = 1)]
				public int GroupOwnerIntent;
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pConfig> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pConfig() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>copy constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pConfig;)V", AccessFlags = 1)]
				public WifiP2pConfig(global::Android.Net.Wifi.P2p.WifiP2pConfig source) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A class representing a Wi-Fi p2p device</para> <para>Note that the operations are not thread safe { <para>WifiP2pManager} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pDevice
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pDevice", AccessFlags = 33)]
		public partial class WifiP2pDevice : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The device name is a user friendly string to identify a Wi-Fi p2p device </para>        
				/// </summary>
				/// <java-name>
				/// deviceName
				/// </java-name>
				[Dot42.DexImport("deviceName", "Ljava/lang/String;", AccessFlags = 1)]
				public string DeviceName;
				/// <summary>
				///  <para>The device MAC address uniquely identifies a Wi-Fi p2p device </para>        
				/// </summary>
				/// <java-name>
				/// deviceAddress
				/// </java-name>
				[Dot42.DexImport("deviceAddress", "Ljava/lang/String;", AccessFlags = 1)]
				public string DeviceAddress;
				/// <summary>
				///  <para>Primary device type identifies the type of device. For example, an application could filter the devices discovered to only display printers if the purpose is to enable a printing action from the user. See the Wi-Fi Direct technical specification for the full list of standard device types supported. </para>        
				/// </summary>
				/// <java-name>
				/// primaryDeviceType
				/// </java-name>
				[Dot42.DexImport("primaryDeviceType", "Ljava/lang/String;", AccessFlags = 1)]
				public string PrimaryDeviceType;
				/// <summary>
				///  <para>Secondary device type is an optional attribute that can be provided by a device in addition to the primary device type. </para>        
				/// </summary>
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
				/// <summary>
				///  <para>Device connection status </para>        
				/// </summary>
				/// <java-name>
				/// status
				/// </java-name>
				[Dot42.DexImport("status", "I", AccessFlags = 1)]
				public int Status;
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pDevice> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pDevice() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>copy constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pDevice;)V", AccessFlags = 1)]
				public WifiP2pDevice(global::Android.Net.Wifi.P2p.WifiP2pDevice source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if WPS push button configuration is supported </para>        
				/// </summary>
				/// <java-name>
				/// wpsPbcSupported
				/// </java-name>
				[Dot42.DexImport("wpsPbcSupported", "()Z", AccessFlags = 1)]
				public virtual bool WpsPbcSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if WPS keypad configuration is supported </para>        
				/// </summary>
				/// <java-name>
				/// wpsKeypadSupported
				/// </java-name>
				[Dot42.DexImport("wpsKeypadSupported", "()Z", AccessFlags = 1)]
				public virtual bool WpsKeypadSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if WPS display configuration is supported </para>        
				/// </summary>
				/// <java-name>
				/// wpsDisplaySupported
				/// </java-name>
				[Dot42.DexImport("wpsDisplaySupported", "()Z", AccessFlags = 1)]
				public virtual bool WpsDisplaySupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns true if the device is capable of service discovery </para>        
				/// </summary>
				/// <java-name>
				/// isServiceDiscoveryCapable
				/// </java-name>
				public virtual bool IsServiceDiscoveryCapable
				{
						[Dot42.DexImport("isServiceDiscoveryCapable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if the device is a group owner </para>        
				/// </summary>
				/// <java-name>
				/// isGroupOwner
				/// </java-name>
				public virtual bool IsGroupOwner
				{
						[Dot42.DexImport("isGroupOwner", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A class representing a Wi-Fi P2p device list.</para> <para>Note that the operations are not thread safe. { <para>WifiP2pManager} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pDeviceList
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pDeviceList", AccessFlags = 33)]
		public partial class WifiP2pDeviceList : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pDeviceList> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pDeviceList() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>copy constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pDeviceList;)V", AccessFlags = 1)]
				public WifiP2pDeviceList(global::Android.Net.Wifi.P2p.WifiP2pDeviceList source) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the list of devices </para>        
				/// </summary>
				/// <java-name>
				/// getDeviceList
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice> DeviceList
				{
						[Dot42.DexImport("getDeviceList", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Landroid/net/wifi/p2p/WifiP2pDevice;>;")]
						get{ return default(global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice>); }
				}

		}

		/// <summary>
		///  <para>A class representing a Wi-Fi P2p group. A p2p group consists of a single group owner and one or more clients. In the case of a group with only two devices, one will be the group owner and the other will be a group client.</para> <para>{ <para>WifiP2pManager} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pGroup
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pGroup", AccessFlags = 33)]
		public partial class WifiP2pGroup : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pGroup> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pGroup() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>copy constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pGroup;)V", AccessFlags = 1)]
				public WifiP2pGroup(global::Android.Net.Wifi.P2p.WifiP2pGroup source) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the network name (SSID) of the group. Legacy Wi-Fi clients will discover the p2p group using the network name. </para>        
				/// </summary>
				/// <java-name>
				/// getNetworkName
				/// </java-name>
				public virtual string NetworkName
				{
						[Dot42.DexImport("getNetworkName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Check whether this device is the group owner of the created p2p group </para>        
				/// </summary>
				/// <java-name>
				/// isGroupOwner
				/// </java-name>
				public virtual bool IsGroupOwner
				{
						[Dot42.DexImport("isGroupOwner", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Get the details of the group owner as a WifiP2pDevice object </para>        
				/// </summary>
				/// <java-name>
				/// getOwner
				/// </java-name>
				public virtual global::Android.Net.Wifi.P2p.WifiP2pDevice Owner
				{
						[Dot42.DexImport("getOwner", "()Landroid/net/wifi/p2p/WifiP2pDevice;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Wifi.P2p.WifiP2pDevice); }
				}

				/// <summary>
				///  <para>Get the list of clients currently part of the p2p group </para>        
				/// </summary>
				/// <java-name>
				/// getClientList
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice> ClientList
				{
						[Dot42.DexImport("getClientList", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Landroid/net/wifi/p2p/WifiP2pDevice;>;")]
						get{ return default(global::Java.Util.ICollection<global::Android.Net.Wifi.P2p.WifiP2pDevice>); }
				}

				/// <summary>
				///  <para>Get the passphrase of the group. This function will return a valid passphrase only at the group owner. Legacy Wi-Fi clients will need this passphrase alongside network name obtained from getNetworkName() to join the group </para>        
				/// </summary>
				/// <java-name>
				/// getPassphrase
				/// </java-name>
				public virtual string Passphrase
				{
						[Dot42.DexImport("getPassphrase", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Get the interface name on which the group is created </para>        
				/// </summary>
				/// <java-name>
				/// getInterface
				/// </java-name>
				public virtual string Interface
				{
						[Dot42.DexImport("getInterface", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>A class representing connection information about a Wi-Fi p2p group</para> <para>{ <para>WifiP2pManager} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pInfo", AccessFlags = 33)]
		public partial class WifiP2pInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates if a p2p group has been successfully formed </para>        
				/// </summary>
				/// <java-name>
				/// groupFormed
				/// </java-name>
				[Dot42.DexImport("groupFormed", "Z", AccessFlags = 1)]
				public bool GroupFormed;
				/// <summary>
				///  <para>Indicates if the current device is the group owner </para>        
				/// </summary>
				/// <java-name>
				/// isGroupOwner
				/// </java-name>
				[Dot42.DexImport("isGroupOwner", "Z", AccessFlags = 1)]
				public bool IsGroupOwner;
				/// <summary>
				///  <para>Group owner address </para>        
				/// </summary>
				/// <java-name>
				/// groupOwnerAddress
				/// </java-name>
				[Dot42.DexImport("groupOwnerAddress", "Ljava/net/InetAddress;", AccessFlags = 1)]
				public global::Java.Net.InetAddress GroupOwnerAddress;
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.P2p.WifiP2pInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiP2pInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>copy constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/net/wifi/p2p/WifiP2pInfo;)V", AccessFlags = 1)]
				public WifiP2pInfo(global::Android.Net.Wifi.P2p.WifiP2pInfo source) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class provides the API for managing Wi-Fi peer-to-peer connectivity. This lets an application discover available peers, setup connection to peers and query for the list of peers. When a p2p connection is formed over wifi, the device continues to maintain the uplink connection over mobile or any other available network for internet connectivity on the device.</para> <para>The API is asynchronous and responses to requests from an application are on listener callbacks provided by the application. The application needs to do an initialization with initialize before doing any p2p operation.</para> <para>Most application calls need a ActionListener instance for receiving callbacks ActionListener#onSuccess or ActionListener#onFailure. Action callbacks indicate whether the initiation of the action was a success or a failure. Upon failure, the reason of failure can be one of ERROR, P2P_UNSUPPORTED or BUSY.</para> <para>An application can initiate discovery of peers with discoverPeers. An initiated discovery request from an application stays active until the device starts connecting to a peer ,forms a p2p group or there is an explicit stopPeerDiscovery. Applications can listen to WIFI_P2P_DISCOVERY_CHANGED_ACTION to know if a peer-to-peer discovery is running or stopped. Additionally, WIFI_P2P_PEERS_CHANGED_ACTION indicates if the peer list has changed.</para> <para>When an application needs to fetch the current list of peers, it can request the list of peers with requestPeers. When the peer list is available PeerListListener#onPeersAvailable is called with the device list.</para> <para>An application can initiate a connection request to a peer through connect. See WifiP2pConfig for details on setting up the configuration. For communication with legacy Wi-Fi devices that do not support p2p, an app can create a group using createGroup which creates an access point whose details can be fetched with requestGroupInfo.</para> <para>After a successful group formation through createGroup or through connect, use requestConnectionInfo to fetch the connection details. The connection info WifiP2pInfo contains the address of the group owner WifiP2pInfo#groupOwnerAddress and a flag WifiP2pInfo#isGroupOwner to indicate if the current device is a p2p group owner. A p2p client can thus communicate with the p2p group owner through a socket connection.</para> <para>With peer discovery using discoverPeers, an application discovers the neighboring peers, but has no good way to figure out which peer to establish a connection with. For example, if a game application is interested in finding all the neighboring peers that are also running the same game, it has no way to find out until after the connection is setup. Pre-association service discovery is meant to address this issue of filtering the peers based on the running services.</para> <para>With pre-association service discovery, an application can advertise a service for a application on a peer device prior to a connection setup between the devices. Currently, DNS based service discovery (Bonjour) and Upnp are the higher layer protocols supported. Get Bonjour resources at dns-sd.org and Upnp resources at upnp.org As an example, a video application can discover a Upnp capable media renderer prior to setting up a Wi-fi p2p connection with the device.</para> <para>An application can advertise a Upnp or a Bonjour service with a call to addLocalService. After a local service is added, the framework automatically responds to a peer application discovering the service prior to establishing a p2p connection. A call to removeLocalService removes a local service and clearLocalServices can be used to clear all local services.</para> <para>An application that is looking for peer devices that support certain services can do so with a call to discoverServices. Prior to initiating the discovery, application can add service discovery request with a call to addServiceRequest, remove a service discovery request with a call to removeServiceRequest or clear all requests with a call to clearServiceRequests. When no service requests remain, a previously running service discovery will stop.</para> <para>The application is notified of a result of service discovery request through listener callbacks set through setDnsSdResponseListeners for Bonjour or setUpnpServiceResponseListener for Upnp.</para> <para> <b>Note:</b> Registering an application handler with initialize requires the permissions android.Manifest.permission#ACCESS_WIFI_STATE and android.Manifest.permission#CHANGE_WIFI_STATE to perform any further peer-to-peer operations.</para> <para>Get an instance of this class by calling Context.getSystemService(Context.WIFI_P2P_SERVICE).</para> <para>{ <para>WifiP2pConfig} {</para> <para>WifiP2pInfo} {</para> <para>WifiP2pGroup} {</para> <para>WifiP2pDevice} {</para> <para>WifiP2pDeviceList} {</para> <para>android.net.wifi.WpsInfo} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/WifiP2pManager
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager", AccessFlags = 33)]
		public partial class WifiP2pManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Broadcast intent action to indicate whether Wi-Fi p2p is enabled or disabled. An extra EXTRA_WIFI_STATE provides the state information as int.</para> <para> <para>EXTRA_WIFI_STATE </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_P2P_STATE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_STATE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_STATE_CHANGED_ACTION = "android.net.wifi.p2p.STATE_CHANGED";
				/// <summary>
				///  <para>The lookup key for an int that indicates whether Wi-Fi p2p is enabled or disabled. Retrieve it with android.content.Intent#getIntExtra(String,int).</para> <para> <para>WIFI_P2P_STATE_DISABLED </para> <para>WIFI_P2P_STATE_ENABLED </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_WIFI_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_STATE = "wifi_p2p_state";
				/// <summary>
				///  <para>Wi-Fi p2p is disabled.</para> <para> <para>WIFI_P2P_STATE_CHANGED_ACTION </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_P2P_STATE_DISABLED
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_STATE_DISABLED", "I", AccessFlags = 25)]
				public const int WIFI_P2P_STATE_DISABLED = 1;
				/// <summary>
				///  <para>Wi-Fi p2p is enabled.</para> <para> <para>WIFI_P2P_STATE_CHANGED_ACTION </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_P2P_STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_STATE_ENABLED", "I", AccessFlags = 25)]
				public const int WIFI_P2P_STATE_ENABLED = 2;
				/// <summary>
				///  <para>Broadcast intent action indicating that the state of Wi-Fi p2p connectivity has changed. One extra EXTRA_WIFI_P2P_INFO provides the p2p connection info in the form of a WifiP2pInfo object. Another extra EXTRA_NETWORK_INFO provides the network info in the form of a android.net.NetworkInfo. A third extra provides the details of the group.</para> <para> <para>EXTRA_WIFI_P2P_INFO </para> <para>EXTRA_NETWORK_INFO </para> <para>EXTRA_WIFI_P2P_GROUP </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_P2P_CONNECTION_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_CONNECTION_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_CONNECTION_CHANGED_ACTION = "android.net.wifi.p2p.CONNECTION_STATE_CHANGE";
				/// <summary>
				///  <para>The lookup key for a android.net.wifi.p2p.WifiP2pInfo object Retrieve with android.content.Intent#getParcelableExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_WIFI_P2P_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_P2P_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_P2P_INFO = "wifiP2pInfo";
				/// <summary>
				///  <para>The lookup key for a android.net.NetworkInfo object associated with the p2p network. Retrieve with android.content.Intent#getParcelableExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NETWORK_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_NETWORK_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NETWORK_INFO = "networkInfo";
				/// <summary>
				///  <para>Broadcast intent action indicating that the available peer list has changed. This can be sent as a result of peers being found, lost or updated.</para> <para>An extra EXTRA_P2P_DEVICE_LIST provides the full list of current peers. The full list of peers can also be obtained any time with requestPeers.</para> <para> <para>EXTRA_P2P_DEVICE_LIST </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_P2P_PEERS_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_PEERS_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_PEERS_CHANGED_ACTION = "android.net.wifi.p2p.PEERS_CHANGED";
				/// <summary>
				///  <para>Broadcast intent action indicating that this device details have changed. </para>        
				/// </summary>
				/// <java-name>
				/// WIFI_P2P_THIS_DEVICE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_P2P_THIS_DEVICE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_P2P_THIS_DEVICE_CHANGED_ACTION = "android.net.wifi.p2p.THIS_DEVICE_CHANGED";
				/// <summary>
				///  <para>The lookup key for a android.net.wifi.p2p.WifiP2pDevice object Retrieve with android.content.Intent#getParcelableExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_WIFI_P2P_DEVICE
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_P2P_DEVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_P2P_DEVICE = "wifiP2pDevice";
				/// <summary>
				///  <para>Passed with ActionListener#onFailure. Indicates that the operation failed due to an internal error. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = 0;
				/// <summary>
				///  <para>Passed with ActionListener#onFailure. Indicates that the operation failed because p2p is unsupported on the device. </para>        
				/// </summary>
				/// <java-name>
				/// P2P_UNSUPPORTED
				/// </java-name>
				[Dot42.DexImport("P2P_UNSUPPORTED", "I", AccessFlags = 25)]
				public const int P2P_UNSUPPORTED = 1;
				/// <summary>
				///  <para>Passed with ActionListener#onFailure. Indicates that the operation failed because the framework is busy and unable to service the request </para>        
				/// </summary>
				/// <java-name>
				/// BUSY
				/// </java-name>
				[Dot42.DexImport("BUSY", "I", AccessFlags = 25)]
				public const int BUSY = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiP2pManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Registers the application with the Wi-Fi framework. This function must be the first to be called before any p2p operations are performed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Channel instance that is necessary for performing any further p2p operations </para>
				/// </returns>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/content/Context;Landroid/os/Looper;Landroid/net/wifi/p2p/WifiP2pManager" +
    "$ChannelListener;)Landroid/net/wifi/p2p/WifiP2pManager$Channel;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.P2p.WifiP2pManager.Channel Initialize(global::Android.Content.Context srcContext, global::Android.OS.Looper srcLooper, global::Android.Net.Wifi.P2p.WifiP2pManager.IChannelListener listener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel);
				}

				/// <summary>
				///  <para>Initiate peer discovery. A discovery process involves scanning for available Wi-Fi peers for the purpose of establishing a connection.</para> <para>The function call immediately returns after sending a discovery request to the framework. The application is notified of a success or failure to initiate discovery through listener callbacks ActionListener#onSuccess or ActionListener#onFailure.</para> <para>The discovery remains active until a connection is initiated or a p2p group is formed. Register for WIFI_P2P_PEERS_CHANGED_ACTION intent to determine when the framework notifies of a change as peers are discovered.</para> <para>Upon receiving a WIFI_P2P_PEERS_CHANGED_ACTION intent, an application can request for the list of peers using requestPeers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// discoverPeers
				/// </java-name>
				[Dot42.DexImport("discoverPeers", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ActionListener;)V", AccessFlags = 1)]
				public virtual void DiscoverPeers(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel c, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start a p2p connection to a device with the specified configuration.</para> <para>The function call immediately returns after sending a connection request to the framework. The application is notified of a success or failure to initiate connect through listener callbacks ActionListener#onSuccess or ActionListener#onFailure.</para> <para>Register for WIFI_P2P_CONNECTION_CHANGED_ACTION intent to determine when the framework notifies of a change in connectivity.</para> <para>If the current device is not part of a p2p group, a connect request initiates a group negotiation with the peer.</para> <para>If the current device is part of an existing p2p group or has created a p2p group with createGroup, an invitation to join the group is sent to the peer device.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pConfig" +
    ";Landroid/net/wifi/p2p/WifiP2pManager$ActionListener;)V", AccessFlags = 1)]
				public virtual void Connect(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel c, global::Android.Net.Wifi.P2p.WifiP2pConfig config, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancel any ongoing p2p group negotiation</para> <para>The function call immediately returns after sending a connection cancellation request to the framework. The application is notified of a success or failure to initiate cancellation through listener callbacks ActionListener#onSuccess or ActionListener#onFailure.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cancelConnect
				/// </java-name>
				[Dot42.DexImport("cancelConnect", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ActionListener;)V", AccessFlags = 1)]
				public virtual void CancelConnect(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel c, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a p2p group with the current device as the group owner. This essentially creates an access point that can accept connections from legacy clients as well as other p2p devices.</para> <para> <b>Note:</b> This function would normally not be used unless the current device needs to form a p2p connection with a legacy client</para> <para>The function call immediately returns after sending a group creation request to the framework. The application is notified of a success or failure to initiate group creation through listener callbacks ActionListener#onSuccess or ActionListener#onFailure.</para> <para>Application can request for the group details with requestGroupInfo.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createGroup
				/// </java-name>
				[Dot42.DexImport("createGroup", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ActionListener;)V", AccessFlags = 1)]
				public virtual void CreateGroup(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel c, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove the current p2p group.</para> <para>The function call immediately returns after sending a group removal request to the framework. The application is notified of a success or failure to initiate group removal through listener callbacks ActionListener#onSuccess or ActionListener#onFailure.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeGroup
				/// </java-name>
				[Dot42.DexImport("removeGroup", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ActionListener;)V", AccessFlags = 1)]
				public virtual void RemoveGroup(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel c, global::Android.Net.Wifi.P2p.WifiP2pManager.IActionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request the current list of peers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestPeers
				/// </java-name>
				[Dot42.DexImport("requestPeers", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$PeerListListener;)V", AccessFlags = 1)]
				public virtual void RequestPeers(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel c, global::Android.Net.Wifi.P2p.WifiP2pManager.IPeerListListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request device connection info.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestConnectionInfo
				/// </java-name>
				[Dot42.DexImport("requestConnectionInfo", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$ConnectionInfoListener;)V", AccessFlags = 1)]
				public virtual void RequestConnectionInfo(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel c, global::Android.Net.Wifi.P2p.WifiP2pManager.IConnectionInfoListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request p2p group info.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestGroupInfo
				/// </java-name>
				[Dot42.DexImport("requestGroupInfo", "(Landroid/net/wifi/p2p/WifiP2pManager$Channel;Landroid/net/wifi/p2p/WifiP2pManage" +
    "r$GroupInfoListener;)V", AccessFlags = 1)]
				public virtual void RequestGroupInfo(global::Android.Net.Wifi.P2p.WifiP2pManager.Channel c, global::Android.Net.Wifi.P2p.WifiP2pManager.IGroupInfoListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>A channel that connects the application to the Wifi p2p framework. Most p2p operations require a Channel as an argument. An instance of Channel is obtained by doing a call on initialize </para>    
				/// </summary>
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

				/// <summary>
				///  <para>Interface for callback invocation when group info is available </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$GroupInfoListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$GroupInfoListener", AccessFlags = 1545)]
				public partial interface IGroupInfoListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The requested p2p group info is available </para>        
						/// </summary>
						/// <java-name>
						/// onGroupInfoAvailable
						/// </java-name>
						[Dot42.DexImport("onGroupInfoAvailable", "(Landroid/net/wifi/p2p/WifiP2pGroup;)V", AccessFlags = 1025)]
						void OnGroupInfoAvailable(global::Android.Net.Wifi.P2p.WifiP2pGroup group) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface for callback invocation when connection info is available </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$ConnectionInfoListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$ConnectionInfoListener", AccessFlags = 1545)]
				public partial interface IConnectionInfoListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The requested connection info is available </para>        
						/// </summary>
						/// <java-name>
						/// onConnectionInfoAvailable
						/// </java-name>
						[Dot42.DexImport("onConnectionInfoAvailable", "(Landroid/net/wifi/p2p/WifiP2pInfo;)V", AccessFlags = 1025)]
						void OnConnectionInfoAvailable(global::Android.Net.Wifi.P2p.WifiP2pInfo info) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface for callback invocation when peer list is available </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$PeerListListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$PeerListListener", AccessFlags = 1545)]
				public partial interface IPeerListListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The requested peer list is available </para>        
						/// </summary>
						/// <java-name>
						/// onPeersAvailable
						/// </java-name>
						[Dot42.DexImport("onPeersAvailable", "(Landroid/net/wifi/p2p/WifiP2pDeviceList;)V", AccessFlags = 1025)]
						void OnPeersAvailable(global::Android.Net.Wifi.P2p.WifiP2pDeviceList peers) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface for callback invocation on an application action </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$ActionListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$ActionListener", AccessFlags = 1545)]
				public partial interface IActionListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The operation succeeded </para>        
						/// </summary>
						/// <java-name>
						/// onSuccess
						/// </java-name>
						[Dot42.DexImport("onSuccess", "()V", AccessFlags = 1025)]
						void OnSuccess() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>The operation failed </para>        
						/// </summary>
						/// <java-name>
						/// onFailure
						/// </java-name>
						[Dot42.DexImport("onFailure", "(I)V", AccessFlags = 1025)]
						void OnFailure(int reason) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface for callback invocation when framework channel is lost </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/p2p/WifiP2pManager$ChannelListener
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/p2p/WifiP2pManager$ChannelListener", AccessFlags = 1545)]
				public partial interface IChannelListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The channel to the framework has been disconnected. Application could try re-initializing using initialize </para>        
						/// </summary>
						/// <java-name>
						/// onChannelDisconnected
						/// </java-name>
						[Dot42.DexImport("onChannelDisconnected", "()V", AccessFlags = 1025)]
						void OnChannelDisconnected() /* MethodBuilder.Create */ ;

				}

		}

}

