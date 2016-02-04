#pragma warning disable 1717
namespace Android.Net
{
		/// <summary>
		///  <para>Class that answers queries about the state of network connectivity. It also notifies applications when network connectivity changes. Get an instance of this class by calling Context.getSystemService(Context.CONNECTIVITY_SERVICE). </para> <para>The primary responsibilities of this class are to:  <ol> <li> <para>Monitor network connections (Wi-Fi, GPRS, UMTS, etc.) </para></li> <li> <para>Send broadcast intents when network connectivity changes </para></li> <li> <para>Attempt to "fail over" to another network when connectivity to a network is lost </para></li> <li> <para>Provide an API that allows applications to query the coarse-grained or fine-grained state of the available networks </para></li></ol></para>    
		/// </summary>
		/// <java-name>
		/// android/net/ConnectivityManager
		/// </java-name>
		[Dot42.DexImport("android/net/ConnectivityManager", AccessFlags = 33)]
		public partial class ConnectivityManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A change in network connectivity has occurred. A connection has either been established or lost. The NetworkInfo for the affected network is sent as an extra; it should be consulted to see what kind of connectivity event occurred. </para> <para>If this is a connection that was the result of failing over from a disconnected network, then the FAILOVER_CONNECTION boolean extra is set to true. </para> <para>For a loss of connectivity, if the connectivity manager is attempting to connect (or has already connected) to another network, the NetworkInfo for the new network is also passed as an extra. This lets any receivers of the broadcast know that they should not necessarily tell the user that no data traffic will be possible. Instead, the receiver should expect another broadcast soon, indicating either that the failover attempt succeeded (and so there is still overall data connectivity), or that the failover attempt failed, meaning that all connectivity has been lost. </para> <para>For a disconnect event, the boolean extra EXTRA_NO_CONNECTIVITY is set to <c>true </c> if there are no connected networks at all. </para>        
				/// </summary>
				/// <java-name>
				/// CONNECTIVITY_ACTION
				/// </java-name>
				[Dot42.DexImport("CONNECTIVITY_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTIVITY_ACTION = "android.net.conn.CONNECTIVITY_CHANGE";
				/// <summary>
				///  <para>The lookup key for a NetworkInfo object. Retrieve with android.content.Intent#getParcelableExtra(String).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Since NetworkInfo can vary based on UID, applications should always obtain network information through getActiveNetworkInfo() or getAllNetworkInfo().  <para>EXTRA_NETWORK_TYPE </para></para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NETWORK_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_NETWORK_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NETWORK_INFO = "networkInfo";
				/// <summary>
				///  <para>The lookup key for a boolean that indicates whether a connect event is for a network to which the connectivity manager was failing over following a disconnect on another network. Retrieve it with android.content.Intent#getBooleanExtra(String,boolean). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_IS_FAILOVER
				/// </java-name>
				[Dot42.DexImport("EXTRA_IS_FAILOVER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_IS_FAILOVER = "isFailover";
				/// <summary>
				///  <para>The lookup key for a NetworkInfo object. This is supplied when there is another network that it may be possible to connect to. Retrieve with android.content.Intent#getParcelableExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_OTHER_NETWORK_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_OTHER_NETWORK_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_OTHER_NETWORK_INFO = "otherNetwork";
				/// <summary>
				///  <para>The lookup key for a boolean that indicates whether there is a complete lack of connectivity, i.e., no network is available. Retrieve it with android.content.Intent#getBooleanExtra(String,boolean). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NO_CONNECTIVITY
				/// </java-name>
				[Dot42.DexImport("EXTRA_NO_CONNECTIVITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NO_CONNECTIVITY = "noConnectivity";
				/// <summary>
				///  <para>The lookup key for a string that indicates why an attempt to connect to a network failed. The string has no particular structure. It is intended to be used in notifications presented to users. Retrieve it with android.content.Intent#getStringExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_REASON
				/// </java-name>
				[Dot42.DexImport("EXTRA_REASON", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_REASON = "reason";
				/// <summary>
				///  <para>The lookup key for a string that provides optionally supplied extra information about the network state. The information may be passed up from the lower networking layers, and its meaning may be specific to a particular network type. Retrieve it with android.content.Intent#getStringExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_EXTRA_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_EXTRA_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_EXTRA_INFO = "extraInfo";
				/// <summary>
				///  <para>Broadcast Action: The setting for background data usage has changed values. Use getBackgroundDataSetting() to get the current value. </para> <para>If an application uses the network in the background, it should listen for this broadcast and stop using the background data if the value is  <c>false </c> . </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>As of VERSION_CODES#ICE_CREAM_SANDWICH, availability of background data depends on several combined factors, and this broadcast is no longer sent. Instead, when background data is unavailable, getActiveNetworkInfo() will now appear disconnected. During first boot after a platform upgrade, this broadcast will be sent once if getBackgroundDataSetting() was <c>false </c> before the upgrade. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_BACKGROUND_DATA_SETTING_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_BACKGROUND_DATA_SETTING_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BACKGROUND_DATA_SETTING_CHANGED = "android.net.conn.BACKGROUND_DATA_SETTING_CHANGED";
				/// <summary>
				///  <para>The Mobile data connection. When active, all data traffic will use this network type's interface by default (it has a default route) </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MOBILE
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE = 0;
				/// <summary>
				///  <para>The WIFI data connection. When active, all data traffic will use this network type's interface by default (it has a default route). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_WIFI
				/// </java-name>
				[Dot42.DexImport("TYPE_WIFI", "I", AccessFlags = 25)]
				public const int TYPE_WIFI = 1;
				/// <summary>
				///  <para>An MMS-specific Mobile data connection. This network type may use the same network interface as TYPE_MOBILE or it may use a different one. This is used by applications needing to talk to the carrier's Multimedia Messaging Service servers. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MOBILE_MMS
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE_MMS", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE_MMS = 2;
				/// <summary>
				///  <para>A SUPL-specific Mobile data connection. This network type may use the same network interface as TYPE_MOBILE or it may use a different one. This is used by applications needing to talk to the carrier's Secure User Plane Location servers for help locating the device. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MOBILE_SUPL
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE_SUPL", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE_SUPL = 3;
				/// <summary>
				///  <para>A DUN-specific Mobile data connection. This network type may use the same network interface as TYPE_MOBILE or it may use a different one. This is sometimes by the system when setting up an upstream connection for tethering so that the carrier is aware of DUN traffic. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MOBILE_DUN
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE_DUN", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE_DUN = 4;
				/// <summary>
				///  <para>A High Priority Mobile data connection. This network type uses the same network interface as TYPE_MOBILE but the routing setup is different. Only requesting processes will have access to the Mobile DNS servers and only IP's explicitly requested via requestRouteToHost will route over this interface if no default route exists. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MOBILE_HIPRI
				/// </java-name>
				[Dot42.DexImport("TYPE_MOBILE_HIPRI", "I", AccessFlags = 25)]
				public const int TYPE_MOBILE_HIPRI = 5;
				/// <summary>
				///  <para>The WiMAX data connection. When active, all data traffic will use this network type's interface by default (it has a default route). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_WIMAX
				/// </java-name>
				[Dot42.DexImport("TYPE_WIMAX", "I", AccessFlags = 25)]
				public const int TYPE_WIMAX = 6;
				/// <summary>
				///  <para>If you want to set the default network preference,you can directly change the networkAttributes array in framework's config.xml.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Since we support so many more networks now, the single network default network preference can't really express the hierarchy. Instead, the default is defined by the networkAttributes in config.xml. You can determine the current value by calling getNetworkPreference() from an App. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_NETWORK_PREFERENCE
				/// </java-name>
				[Dot42.DexImport("DEFAULT_NETWORK_PREFERENCE", "I", AccessFlags = 25)]
				public const int DEFAULT_NETWORK_PREFERENCE = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ConnectivityManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Tests if a given integer represents a valid network type. </para>        
				/// </summary>
				/// <returns>
				///  <para>a boolean. <c>true </c> if the type is valid, else <c>false </c> </para>
				/// </returns>
				/// <java-name>
				/// isNetworkTypeValid
				/// </java-name>
				[Dot42.DexImport("isNetworkTypeValid", "(I)Z", AccessFlags = 9)]
				public static bool IsNetworkTypeValid(int networkType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns connection status information about a particular network type.</para> <para></para> <para>This method requires the call to hold the permission android.Manifest.permission#ACCESS_NETWORK_STATE. </para>        
				/// </summary>
				/// <returns>
				///  <para>a NetworkInfo object for the requested network type or <c>null </c> if the type is not supported by the device.</para>
				/// </returns>
				/// <java-name>
				/// getNetworkInfo
				/// </java-name>
				[Dot42.DexImport("getNetworkInfo", "(I)Landroid/net/NetworkInfo;", AccessFlags = 1)]
				public virtual global::Android.Net.NetworkInfo GetNetworkInfo(int networkType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.NetworkInfo);
				}

				/// <java-name>
				/// startUsingNetworkFeature
				/// </java-name>
				[Dot42.DexImport("startUsingNetworkFeature", "(ILjava/lang/String;)I", AccessFlags = 1)]
				public virtual int StartUsingNetworkFeature(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// stopUsingNetworkFeature
				/// </java-name>
				[Dot42.DexImport("stopUsingNetworkFeature", "(ILjava/lang/String;)I", AccessFlags = 1)]
				public virtual int StopUsingNetworkFeature(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// requestRouteToHost
				/// </java-name>
				[Dot42.DexImport("requestRouteToHost", "(II)Z", AccessFlags = 1)]
				public virtual bool RequestRouteToHost(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Retrieves the current preferred network type. Note that this made sense when we only had 2 network types, but with more and more default networks we need an array to list their ordering. This will be deprecated soon.</para> <para></para> <para>This method requires the caller to hold the permission android.Manifest.permission#ACCESS_NETWORK_STATE. </para>        
				/// </summary>
				/// <returns>
				///  <para>an integer representing the preferred network type</para>
				/// </returns>
				/// <java-name>
				/// getNetworkPreference
				/// </java-name>
				public virtual int NetworkPreference
				{
						[Dot42.DexImport("getNetworkPreference", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNetworkPreference", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns details about the currently active default data network. When connected, this network is the default route for outgoing connections. You should always check NetworkInfo#isConnected() before initiating network traffic. This may return <c>null </c> when there is no default network.</para> <para></para> <para>This method requires the call to hold the permission android.Manifest.permission#ACCESS_NETWORK_STATE. </para>        
				/// </summary>
				/// <returns>
				///  <para>a NetworkInfo object for the current default network or <c>null </c> if no network default network is currently active</para>
				/// </returns>
				/// <java-name>
				/// getActiveNetworkInfo
				/// </java-name>
				public virtual global::Android.Net.NetworkInfo ActiveNetworkInfo
				{
						[Dot42.DexImport("getActiveNetworkInfo", "()Landroid/net/NetworkInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Net.NetworkInfo); }
				}

				/// <summary>
				///  <para>Returns connection status information about all network types supported by the device.</para> <para></para> <para>This method requires the call to hold the permission android.Manifest.permission#ACCESS_NETWORK_STATE. </para>        
				/// </summary>
				/// <returns>
				///  <para>an array of NetworkInfo objects. Check each NetworkInfo#getType for which type each applies.</para>
				/// </returns>
				/// <java-name>
				/// getAllNetworkInfo
				/// </java-name>
				public virtual global::Android.Net.NetworkInfo[] AllNetworkInfo
				{
						[Dot42.DexImport("getAllNetworkInfo", "()[Landroid/net/NetworkInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Net.NetworkInfo[]); }
				}

				/// <java-name>
				/// getBackgroundDataSetting
				/// </java-name>
				public virtual bool BackgroundDataSetting
				{
						[Dot42.DexImport("getBackgroundDataSetting", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A class for representing UNIX credentials passed via ancillary data on UNIX domain sockets. See "man 7 unix" on a desktop linux distro. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/Credentials
		/// </java-name>
		[Dot42.DexImport("android/net/Credentials", AccessFlags = 33)]
		public partial class Credentials
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public Credentials(int pid, int uid, int gid) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Credentials() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPid
				/// </java-name>
				public virtual int Pid
				{
						[Dot42.DexImport("getPid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getUid
				/// </java-name>
				public virtual int Uid
				{
						[Dot42.DexImport("getUid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGid
				/// </java-name>
				public virtual int Gid
				{
						[Dot42.DexImport("getGid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>A simple object for retrieving the results of a DHCP request. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/DhcpInfo
		/// </java-name>
		[Dot42.DexImport("android/net/DhcpInfo", AccessFlags = 33)]
		public partial class DhcpInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ipAddress
				/// </java-name>
				[Dot42.DexImport("ipAddress", "I", AccessFlags = 1)]
				public int IpAddress;
				/// <java-name>
				/// gateway
				/// </java-name>
				[Dot42.DexImport("gateway", "I", AccessFlags = 1)]
				public int Gateway;
				/// <java-name>
				/// netmask
				/// </java-name>
				[Dot42.DexImport("netmask", "I", AccessFlags = 1)]
				public int Netmask;
				/// <java-name>
				/// dns1
				/// </java-name>
				[Dot42.DexImport("dns1", "I", AccessFlags = 1)]
				public int Dns1;
				/// <java-name>
				/// dns2
				/// </java-name>
				[Dot42.DexImport("dns2", "I", AccessFlags = 1)]
				public int Dns2;
				/// <java-name>
				/// serverAddress
				/// </java-name>
				[Dot42.DexImport("serverAddress", "I", AccessFlags = 1)]
				public int ServerAddress;
				/// <java-name>
				/// leaseDuration
				/// </java-name>
				[Dot42.DexImport("leaseDuration", "I", AccessFlags = 1)]
				public int LeaseDuration;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DhcpInfo() /* MethodBuilder.Create */ 
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
				///  <para>Implement the Parcelable interface {} </para>        
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
				///  <para>Implement the Parcelable interface {} </para>        
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
		///  <para>non-standard class for creating inbound UNIX-domain socket on the Android platform, this is created in the Linux non-filesystem namespace.</para> <para>On simulator platforms, this may be created in a temporary directory on the filesystem </para>    
		/// </summary>
		/// <java-name>
		/// android/net/LocalServerSocket
		/// </java-name>
		[Dot42.DexImport("android/net/LocalServerSocket", AccessFlags = 33)]
		public partial class LocalServerSocket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a LocalServerSocket from a file descriptor that's already been created and bound. listen() will be called immediately on it. Used for cases where file descriptors are passed in via environment variables</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LocalServerSocket(string fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a LocalServerSocket from a file descriptor that's already been created and bound. listen() will be called immediately on it. Used for cases where file descriptors are passed in via environment variables</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public LocalServerSocket(global::Java.IO.FileDescriptor fd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Accepts a new connection to the socket. Blocks until a new connection arrives.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a socket representing the new connection. </para>
				/// </returns>
				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "()Landroid/net/LocalSocket;", AccessFlags = 1)]
				public virtual global::Android.Net.LocalSocket Accept() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.LocalSocket);
				}

				/// <summary>
				///  <para>Closes server socket.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal LocalServerSocket() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Obtains the socket's local address</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>local address </para>
				/// </returns>
				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public virtual global::Android.Net.LocalSocketAddress LocalSocketAddress
				{
						[Dot42.DexImport("getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;", AccessFlags = 1)]
						get{ return default(global::Android.Net.LocalSocketAddress); }
				}

				/// <summary>
				///  <para>Returns file descriptor or null if not yet open/already closed</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>fd or null </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public virtual global::Java.IO.FileDescriptor FileDescriptor
				{
						[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

		}

		/// <summary>
		///  <para>Creates a (non-server) socket in the UNIX-domain namespace. The interface here is not entirely unlike that of java.net.Socket </para>    
		/// </summary>
		/// <java-name>
		/// android/net/LocalSocket
		/// </java-name>
		[Dot42.DexImport("android/net/LocalSocket", AccessFlags = 33)]
		public partial class LocalSocket
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a AF_LOCAL/UNIX domain stream socket. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LocalSocket() /* MethodBuilder.Create */ 
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
				///  <para>Connects this socket to an endpoint. May only be called on an instance that has not yet been connected.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Landroid/net/LocalSocketAddress;)V", AccessFlags = 1)]
				public virtual void Connect(global::Android.Net.LocalSocketAddress endpoint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Binds this socket to an endpoint name. May only be called on an instance that has not yet been bound.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Landroid/net/LocalSocketAddress;)V", AccessFlags = 1)]
				public virtual void Bind(global::Android.Net.LocalSocketAddress bindpoint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Closes the socket.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Shuts down the input side of the socket.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// shutdownInput
				/// </java-name>
				[Dot42.DexImport("shutdownInput", "()V", AccessFlags = 1)]
				public virtual void ShutdownInput() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Shuts down the output side of the socket.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// shutdownOutput
				/// </java-name>
				[Dot42.DexImport("shutdownOutput", "()V", AccessFlags = 1)]
				public virtual void ShutdownOutput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "(Landroid/net/LocalSocketAddress;I)V", AccessFlags = 1)]
				public virtual void Connect(global::Android.Net.LocalSocketAddress endpoint, int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enqueues a set of file descriptors to send to the peer. The queue is one deep. The file descriptors will be sent with the next write of normal data, and will be delivered in a single ancillary message. See "man 7 unix" SCM_RIGHTS on a desktop Linux machine.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFileDescriptorsForSend
				/// </java-name>
				[Dot42.DexImport("setFileDescriptorsForSend", "([Ljava/io/FileDescriptor;)V", AccessFlags = 1)]
				public virtual void SetFileDescriptorsForSend(global::Java.IO.FileDescriptor[] fds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the name that this socket is bound to, if any.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Local address or null if anonymous </para>
				/// </returns>
				/// <java-name>
				/// getLocalSocketAddress
				/// </java-name>
				public virtual global::Android.Net.LocalSocketAddress LocalSocketAddress
				{
						[Dot42.DexImport("getLocalSocketAddress", "()Landroid/net/LocalSocketAddress;", AccessFlags = 1)]
						get{ return default(global::Android.Net.LocalSocketAddress); }
				}

				/// <summary>
				///  <para>Retrieves the input stream for this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>input stream </para>
				/// </returns>
				/// <java-name>
				/// getInputStream
				/// </java-name>
				public virtual global::Java.IO.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.InputStream); }
				}

				/// <summary>
				///  <para>Retrieves the output stream for this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>output stream </para>
				/// </returns>
				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public virtual global::Java.IO.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return default(global::Java.IO.OutputStream); }
				}

				/// <java-name>
				/// getReceiveBufferSize
				/// </java-name>
				public virtual int ReceiveBufferSize
				{
						[Dot42.DexImport("getReceiveBufferSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setReceiveBufferSize", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSoTimeout
				/// </java-name>
				public virtual int SoTimeout
				{
						[Dot42.DexImport("getSoTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSoTimeout", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSendBufferSize
				/// </java-name>
				public virtual int SendBufferSize
				{
						[Dot42.DexImport("getSendBufferSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSendBufferSize", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRemoteSocketAddress
				/// </java-name>
				public virtual global::Android.Net.LocalSocketAddress RemoteSocketAddress
				{
						[Dot42.DexImport("getRemoteSocketAddress", "()Landroid/net/LocalSocketAddress;", AccessFlags = 1)]
						get{ return default(global::Android.Net.LocalSocketAddress); }
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				public virtual bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isClosed
				/// </java-name>
				public virtual bool IsClosed
				{
						[Dot42.DexImport("isClosed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isBound
				/// </java-name>
				public virtual bool IsBound
				{
						[Dot42.DexImport("isBound", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isOutputShutdown
				/// </java-name>
				public virtual bool IsOutputShutdown
				{
						[Dot42.DexImport("isOutputShutdown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isInputShutdown
				/// </java-name>
				public virtual bool IsInputShutdown
				{
						[Dot42.DexImport("isInputShutdown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Retrieves a set of file descriptors that a peer has sent through an ancillary message. This method retrieves the most recent set sent, and then returns null until a new set arrives. File descriptors may only be passed along with regular data, so this method can only return a non-null after a read operation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>null or file descriptor array </para>
				/// </returns>
				/// <java-name>
				/// getAncillaryFileDescriptors
				/// </java-name>
				public virtual global::Java.IO.FileDescriptor[] AncillaryFileDescriptors
				{
						[Dot42.DexImport("getAncillaryFileDescriptors", "()[Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.IO.FileDescriptor[]); }
				}

				/// <summary>
				///  <para>Retrieves the credentials of this socket's peer. Only valid on connected sockets.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>non-null; peer credentials </para>
				/// </returns>
				/// <java-name>
				/// getPeerCredentials
				/// </java-name>
				public virtual global::Android.Net.Credentials PeerCredentials
				{
						[Dot42.DexImport("getPeerCredentials", "()Landroid/net/Credentials;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Credentials); }
				}

				/// <summary>
				///  <para>Returns file descriptor or null if not yet open/already closed</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>fd or null </para>
				/// </returns>
				/// <java-name>
				/// getFileDescriptor
				/// </java-name>
				public virtual global::Java.IO.FileDescriptor FileDescriptor
				{
						[Dot42.DexImport("getFileDescriptor", "()Ljava/io/FileDescriptor;", AccessFlags = 1)]
						get{ return default(global::Java.IO.FileDescriptor); }
				}

		}

		/// <summary>
		///  <para>A UNIX-domain (AF_LOCAL) socket address. For use with android.net.LocalSocket and android.net.LocalServerSocket.</para> <para>On the Android system, these names refer to names in the Linux abstract (non-filesystem) UNIX domain namespace. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/LocalSocketAddress
		/// </java-name>
		[Dot42.DexImport("android/net/LocalSocketAddress", AccessFlags = 33)]
		public partial class LocalSocketAddress
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates an instance with a given name.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Landroid/net/LocalSocketAddress$Namespace;)V", AccessFlags = 1)]
				public LocalSocketAddress(string name, global::Android.Net.LocalSocketAddress.Namespace @namespace) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates an instance with a given name in the Namespace#ABSTRACT namespace</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LocalSocketAddress(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the namespace used by this address.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>non-null a namespace </para>
				/// </returns>
				/// <java-name>
				/// getNamespace
				/// </java-name>
				[Dot42.DexImport("getNamespace", "()Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 1)]
				public virtual global::Android.Net.LocalSocketAddress.Namespace GetNamespace() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.LocalSocketAddress.Namespace);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal LocalSocketAddress() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Retrieves the string name of this address </para>        
				/// </summary>
				/// <returns>
				///  <para>string name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// android/net/LocalSocketAddress$Namespace
				/// </java-name>
				[Dot42.DexImport("android/net/LocalSocketAddress$Namespace", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/net/LocalSocketAddress$Namespace;>;")]
				public sealed class Namespace
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ABSTRACT
						/// </java-name>
						[Dot42.DexImport("ABSTRACT", "Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 16409)]
						public static readonly Namespace ABSTRACT;
						/// <java-name>
						/// FILESYSTEM
						/// </java-name>
						[Dot42.DexImport("FILESYSTEM", "Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 16409)]
						public static readonly Namespace FILESYSTEM;
						/// <java-name>
						/// RESERVED
						/// </java-name>
						[Dot42.DexImport("RESERVED", "Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 16409)]
						public static readonly Namespace RESERVED;
						private Namespace() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 25)]
						public static Namespace[] Values() /* MethodBuilder.Create */ 
						{
								return default(Namespace[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/net/LocalSocketAddress$Namespace;", AccessFlags = 9)]
						public static Namespace ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Namespace);
						}

				}

		}

		/// <summary>
		///  <para>MailTo URL parser</para> <para>This class parses a mailto scheme URL and then can be queried for the parsed parameters. This implements RFC 2368. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/MailTo
		/// </java-name>
		[Dot42.DexImport("android/net/MailTo", AccessFlags = 33)]
		public partial class MailTo
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAILTO_SCHEME
				/// </java-name>
				[Dot42.DexImport("MAILTO_SCHEME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAILTO_SCHEME = "mailto:";
				/// <summary>
				///  <para>Private constructor. The only way to build a Mailto object is through the parse() method. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MailTo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Test to see if the given string is a mailto URL </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the string is a mailto URL </para>
				/// </returns>
				/// <java-name>
				/// isMailTo
				/// </java-name>
				[Dot42.DexImport("isMailTo", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsMailTo(string url) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Parse and decode a mailto scheme string. This parser implements RFC 2368. The returned object can be queried for the parsed parameters. </para>        
				/// </summary>
				/// <returns>
				///  <para>MailTo object </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Landroid/net/MailTo;", AccessFlags = 9)]
				public static global::Android.Net.MailTo Parse(string url) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.MailTo);
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
				///  <para>Retrieve the To address line from the parsed mailto URL. This could be several email address that are comma-space delimited. If no To line was specified, then null is return </para>        
				/// </summary>
				/// <returns>
				///  <para>comma delimited email addresses or null </para>
				/// </returns>
				/// <java-name>
				/// getTo
				/// </java-name>
				public virtual string To
				{
						[Dot42.DexImport("getTo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieve the CC address line from the parsed mailto URL. This could be several email address that are comma-space delimited. If no CC line was specified, then null is return </para>        
				/// </summary>
				/// <returns>
				///  <para>comma delimited email addresses or null </para>
				/// </returns>
				/// <java-name>
				/// getCc
				/// </java-name>
				public virtual string Cc
				{
						[Dot42.DexImport("getCc", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieve the subject line from the parsed mailto URL. If no subject line was specified, then null is return </para>        
				/// </summary>
				/// <returns>
				///  <para>subject or null </para>
				/// </returns>
				/// <java-name>
				/// getSubject
				/// </java-name>
				public virtual string Subject
				{
						[Dot42.DexImport("getSubject", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieve the body line from the parsed mailto URL. If no body line was specified, then null is return </para>        
				/// </summary>
				/// <returns>
				///  <para>body or null </para>
				/// </returns>
				/// <java-name>
				/// getBody
				/// </java-name>
				public virtual string Body
				{
						[Dot42.DexImport("getBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieve all the parsed email headers from the mailto URL </para>        
				/// </summary>
				/// <returns>
				///  <para>map containing all parsed values </para>
				/// </returns>
				/// <java-name>
				/// getHeaders
				/// </java-name>
				public virtual global::Java.Util.IMap<string, string> Headers
				{
						[Dot42.DexImport("getHeaders", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IMap<string, string>); }
				}

		}

		/// <summary>
		///  <para>Describes the status of a network interface. </para> <para>Use ConnectivityManager#getActiveNetworkInfo() to get an instance that represents the current network connection. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/NetworkInfo
		/// </java-name>
		[Dot42.DexImport("android/net/NetworkInfo", AccessFlags = 33)]
		public partial class NetworkInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NetworkInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reports the current coarse-grained state of the network. </para>        
				/// </summary>
				/// <returns>
				///  <para>the coarse-grained state </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()Landroid/net/NetworkInfo$State;", AccessFlags = 1)]
				public virtual global::Android.Net.NetworkInfo.State GetState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.NetworkInfo.State);
				}

				/// <summary>
				///  <para>Reports the current fine-grained state of the network. </para>        
				/// </summary>
				/// <returns>
				///  <para>the fine-grained state </para>
				/// </returns>
				/// <java-name>
				/// getDetailedState
				/// </java-name>
				[Dot42.DexImport("getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 1)]
				public virtual global::Android.Net.NetworkInfo.DetailedState GetDetailedState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.NetworkInfo.DetailedState);
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
				///  <para>Implement the Parcelable interface  </para>        
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
				///  <para>Implement the Parcelable interface.  </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reports the type of network to which the info in this <c>NetworkInfo </c> pertains. </para>        
				/// </summary>
				/// <returns>
				///  <para>one of ConnectivityManager#TYPE_MOBILE, ConnectivityManager#TYPE_WIFI, ConnectivityManager#TYPE_WIMAX, ConnectivityManager#TYPE_ETHERNET, ConnectivityManager#TYPE_BLUETOOTH, or other types defined by ConnectivityManager </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public virtual int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return a network-type-specific integer describing the subtype of the network. </para>        
				/// </summary>
				/// <returns>
				///  <para>the network subtype </para>
				/// </returns>
				/// <java-name>
				/// getSubtype
				/// </java-name>
				public virtual int Subtype
				{
						[Dot42.DexImport("getSubtype", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return a human-readable name describe the type of the network, for example "WIFI" or "MOBILE". </para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the network type </para>
				/// </returns>
				/// <java-name>
				/// getTypeName
				/// </java-name>
				public virtual string TypeName
				{
						[Dot42.DexImport("getTypeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return a human-readable name describing the subtype of the network. </para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the network subtype </para>
				/// </returns>
				/// <java-name>
				/// getSubtypeName
				/// </java-name>
				public virtual string SubtypeName
				{
						[Dot42.DexImport("getSubtypeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Indicates whether network connectivity exists or is in the process of being established. This is good for applications that need to do anything related to the network other than read or write data. For the latter, call isConnected() instead, which guarantees that the network is fully usable. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if network connectivity exists or is in the process of being established, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isConnectedOrConnecting
				/// </java-name>
				public virtual bool IsConnectedOrConnecting
				{
						[Dot42.DexImport("isConnectedOrConnecting", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether network connectivity exists and it is possible to establish connections and pass data. </para> <para>Always call this before attempting to perform data transactions. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if network connectivity exists, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isConnected
				/// </java-name>
				public virtual bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether network connectivity is possible. A network is unavailable when a persistent or semi-persistent condition prevents the possibility of connecting to that network. Examples include  <ul> <li> <para>The device is out of the coverage area for any network of this type. </para></li> <li> <para>The device is on a network other than the home network (i.e., roaming), and data roaming has been disabled. </para></li> <li> <para>The device's radio is turned off, e.g., because airplane mode is enabled. </para></li></ul></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the network is available, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isAvailable
				/// </java-name>
				public virtual bool IsAvailable
				{
						[Dot42.DexImport("isAvailable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether the current attempt to connect to the network resulted from the ConnectivityManager trying to fail over to this network following a disconnect from another network. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this is a failover attempt, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isFailover
				/// </java-name>
				public virtual bool IsFailover
				{
						[Dot42.DexImport("isFailover", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Indicates whether the device is currently roaming on this network. When <c>true </c> , it suggests that use of data on this network may incur extra costs. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if roaming is in effect, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRoaming
				/// </java-name>
				public virtual bool IsRoaming
				{
						[Dot42.DexImport("isRoaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Report the reason an attempt to establish connectivity failed, if one is available. </para>        
				/// </summary>
				/// <returns>
				///  <para>the reason for failure, or null if not available </para>
				/// </returns>
				/// <java-name>
				/// getReason
				/// </java-name>
				public virtual string Reason
				{
						[Dot42.DexImport("getReason", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Report the extra information about the network state, if any was provided by the lower networking layers., if one is available. </para>        
				/// </summary>
				/// <returns>
				///  <para>the extra information, or null if not available </para>
				/// </returns>
				/// <java-name>
				/// getExtraInfo
				/// </java-name>
				public virtual string ExtraInfo
				{
						[Dot42.DexImport("getExtraInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// android/net/NetworkInfo$DetailedState
				/// </java-name>
				[Dot42.DexImport("android/net/NetworkInfo$DetailedState", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/net/NetworkInfo$DetailedState;>;")]
				public sealed class DetailedState
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// AUTHENTICATING
						/// </java-name>
						[Dot42.DexImport("AUTHENTICATING", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState AUTHENTICATING;
						/// <java-name>
						/// CONNECTED
						/// </java-name>
						[Dot42.DexImport("CONNECTED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState CONNECTED;
						/// <java-name>
						/// CONNECTING
						/// </java-name>
						[Dot42.DexImport("CONNECTING", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState CONNECTING;
						/// <java-name>
						/// DISCONNECTED
						/// </java-name>
						[Dot42.DexImport("DISCONNECTED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState DISCONNECTED;
						/// <java-name>
						/// DISCONNECTING
						/// </java-name>
						[Dot42.DexImport("DISCONNECTING", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState DISCONNECTING;
						/// <java-name>
						/// FAILED
						/// </java-name>
						[Dot42.DexImport("FAILED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState FAILED;
						/// <java-name>
						/// IDLE
						/// </java-name>
						[Dot42.DexImport("IDLE", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState IDLE;
						/// <java-name>
						/// OBTAINING_IPADDR
						/// </java-name>
						[Dot42.DexImport("OBTAINING_IPADDR", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState OBTAINING_IPADDR;
						/// <java-name>
						/// SCANNING
						/// </java-name>
						[Dot42.DexImport("SCANNING", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState SCANNING;
						/// <java-name>
						/// SUSPENDED
						/// </java-name>
						[Dot42.DexImport("SUSPENDED", "Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 16409)]
						public static readonly DetailedState SUSPENDED;
						private DetailedState() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 25)]
						public static DetailedState[] Values() /* MethodBuilder.Create */ 
						{
								return default(DetailedState[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 9)]
						public static DetailedState ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(DetailedState);
						}

				}

				/// <java-name>
				/// android/net/NetworkInfo$State
				/// </java-name>
				[Dot42.DexImport("android/net/NetworkInfo$State", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/net/NetworkInfo$State;>;")]
				public sealed class State
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CONNECTED
						/// </java-name>
						[Dot42.DexImport("CONNECTED", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State CONNECTED;
						/// <java-name>
						/// CONNECTING
						/// </java-name>
						[Dot42.DexImport("CONNECTING", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State CONNECTING;
						/// <java-name>
						/// DISCONNECTED
						/// </java-name>
						[Dot42.DexImport("DISCONNECTED", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State DISCONNECTED;
						/// <java-name>
						/// DISCONNECTING
						/// </java-name>
						[Dot42.DexImport("DISCONNECTING", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State DISCONNECTING;
						/// <java-name>
						/// SUSPENDED
						/// </java-name>
						[Dot42.DexImport("SUSPENDED", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State SUSPENDED;
						/// <java-name>
						/// UNKNOWN
						/// </java-name>
						[Dot42.DexImport("UNKNOWN", "Landroid/net/NetworkInfo$State;", AccessFlags = 16409)]
						public static readonly State UNKNOWN;
						private State() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/net/NetworkInfo$State;", AccessFlags = 25)]
						public static State[] Values() /* MethodBuilder.Create */ 
						{
								return default(State[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;", AccessFlags = 9)]
						public static State ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(State);
						}

				}

		}

		/// <summary>
		///  <para>Thrown when parsing a URL fails. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/ParseException
		/// </java-name>
		[Dot42.DexImport("android/net/ParseException", AccessFlags = 33)]
		public partial class ParseException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// response
				/// </java-name>
				[Dot42.DexImport("response", "Ljava/lang/String;", AccessFlags = 1)]
				public string Response;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ParseException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A convenience class for accessing the user and default proxy settings. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/Proxy
		/// </java-name>
		[Dot42.DexImport("android/net/Proxy", AccessFlags = 49)]
		public sealed partial class Proxy
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Used to notify an app that's caching the default connection proxy that either the default connection or its proxy has changed. The intent will have the following extra value:</para> <para> <ul> <li> <para> <b>EXTRA_PROXY_INFO</b> - The ProxyProperties for the proxy. Non-null, though if the proxy is undefined the host string will be empty. </para></li></ul></para> <para>This is a protected intent that can only be sent by the system </para>        
				/// </summary>
				/// <java-name>
				/// PROXY_CHANGE_ACTION
				/// </java-name>
				[Dot42.DexImport("PROXY_CHANGE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROXY_CHANGE_ACTION = "android.intent.action.PROXY_CHANGE";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Proxy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the proxy host set by the user.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use standard java vm proxy values to find the host, port and exclusion list. This call ignores the exclusion list. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>String containing the host name. If the user did not set a host name it returns the default host. A null value means that no host is to be used. </para>
				/// </returns>
				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "(Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 25)]
				public static string GetHost(global::Android.Content.Context ctx) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Return the proxy port set by the user.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use standard java vm proxy values to find the host, port and exclusion list. This call ignores the exclusion list. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>The port number to use or -1 if no proxy is to be used. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "(Landroid/content/Context;)I", AccessFlags = 25)]
				public static int GetPort(global::Android.Content.Context ctx) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the default proxy host specified by the carrier.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use standard java vm proxy values to find the host, port and exclusion list. This call ignores the exclusion list and no longer reports only mobile-data apn-based proxy values. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>String containing the host name or null if there is no proxy for this carrier. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultHost
				/// </java-name>
				public static string DefaultHost
				{
						[Dot42.DexImport("getDefaultHost", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the default proxy port specified by the carrier.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use standard java vm proxy values to find the host, port and exclusion list. This call ignores the exclusion list and no longer reports only mobile-data apn-based proxy values. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>The port number to be used with the proxy host or -1 if there is no proxy for this carrier. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultPort
				/// </java-name>
				public static int DefaultPort
				{
						[Dot42.DexImport("getDefaultPort", "()I", AccessFlags = 25)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>SSLSocketFactory implementation with several extra features:</para> <para> <ul> <li> <para>Timeout specification for SSL handshake operations </para></li> <li> <para>Hostname verification in most cases (see WARNINGs below) </para></li> <li> <para>Optional SSL session caching with SSLSessionCache </para></li> <li> <para>Optionally bypass all SSL certificate checks </para></li></ul></para> <para>The handshake timeout does not apply to actual TCP socket connection. If you want a connection timeout as well, use createSocket() and Socket#connect(SocketAddress, int), after which you must verify the identity of the server you are connected to.</para> <para> <b>Most SSLSocketFactory implementations do not verify the server's identity, allowing man-in-the-middle attacks.</b> This implementation does check the server's certificate hostname, but only for createSocket variants that specify a hostname. When using methods that use InetAddress or which return an unconnected socket, you MUST verify the server's identity yourself to ensure a secure connection.</para> <para>One way to verify the server's identity is to use HttpsURLConnection#getDefaultHostnameVerifier() to get a HostnameVerifier to verify the certificate hostname.</para> <para>On development devices, "setprop socket.relaxsslcheck yes" bypasses all SSL certificate and hostname checks for testing purposes. This setting requires root access. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/SSLCertificateSocketFactory
		/// </java-name>
		[Dot42.DexImport("android/net/SSLCertificateSocketFactory", AccessFlags = 33)]
		public partial class SSLCertificateSocketFactory : global::Javax.Net.Ssl.SSLSocketFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getDefault(int) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public SSLCertificateSocketFactory(int handshakeTimeoutMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new socket factory instance with an optional handshake timeout.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new SSLSocketFactory with the specified parameters </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "(I)Ljavax/net/SocketFactory;", AccessFlags = 9)]
				public static global::Javax.Net.SocketFactory GetDefault(int handshakeTimeoutMillis) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.SocketFactory);
				}

				/// <summary>
				///  <para>Returns a new socket factory instance with an optional handshake timeout and SSL session cache.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new SSLSocketFactory with the specified parameters </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLSocketFactory GetDefault(int handshakeTimeoutMillis, global::Android.Net.SSLSessionCache cache) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				/// <summary>
				///  <para>Returns a new instance of a socket factory with all SSL security checks disabled, using an optional handshake timeout and SSL session cache.</para> <para> <b>Warning:</b> Sockets created using this factory are vulnerable to man-in-the-middle attacks!</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an insecure SSLSocketFactory with the specified parameters </para>
				/// </returns>
				/// <java-name>
				/// getInsecure
				/// </java-name>
				[Dot42.DexImport("getInsecure", "(ILandroid/net/SSLSessionCache;)Ljavax/net/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Javax.Net.Ssl.SSLSocketFactory GetInsecure(int handshakeTimeoutMillis, global::Android.Net.SSLSessionCache cache) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Net.Ssl.SSLSocketFactory);
				}

				/// <summary>
				///  <para>Returns a socket factory (also named SSLSocketFactory, but in a different namespace) for use with the Apache HTTP stack.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new SocketFactory with the specified parameters </para>
				/// </returns>
				/// <java-name>
				/// getHttpSocketFactory
				/// </java-name>
				[Dot42.DexImport("getHttpSocketFactory", "(ILandroid/net/SSLSessionCache;)Lorg/apache/http/conn/ssl/SSLSocketFactory;", AccessFlags = 9)]
				public static global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory GetHttpSocketFactory(int handshakeTimeoutMillis, global::Android.Net.SSLSessionCache cache) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory);
				}

				/// <summary>
				///  <para> <b>Warning:</b> Hostname verification is not performed with this method. You MUST verify the server's identity after connecting the socket to avoid man-in-the-middle attacks.</para>        
				/// </summary>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(global::Java.Net.Socket addr, string port, int localAddr, bool localPort) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				///  <para>Creates a new socket which is not connected to any remote host. You must use Socket#connect to connect the socket.</para> <para> <b>Warning:</b> Hostname verification is not performed with this method. You MUST verify the server's identity after connecting the socket to avoid man-in-the-middle attacks.</para>        
				/// </summary>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "()Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				///  <para> <b>Warning:</b> Hostname verification is not performed with this method. You MUST verify the server's identity after connecting the socket to avoid man-in-the-middle attacks.</para>        
				/// </summary>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(global::Java.Net.InetAddress addr, int port, global::Java.Net.InetAddress localAddr, int localPort) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				///  <para> <b>Warning:</b> Hostname verification is not performed with this method. You MUST verify the server's identity after connecting the socket to avoid man-in-the-middle attacks.</para>        
				/// </summary>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(global::Java.Net.InetAddress addr, int port) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				///  <para> <b>Warning:</b> Hostname verification is not performed with this method. You MUST verify the server's identity after connecting the socket to avoid man-in-the-middle attacks.</para>        
				/// </summary>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(string addr, int port, global::Java.Net.InetAddress localAddr, int localPort) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				/// <summary>
				///  <para> <b>Warning:</b> Hostname verification is not performed with this method. You MUST verify the server's identity after connecting the socket to avoid man-in-the-middle attacks.</para>        
				/// </summary>
				/// <java-name>
				/// createSocket
				/// </java-name>
				[Dot42.DexImport("createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", AccessFlags = 1)]
				public override global::Java.Net.Socket CreateSocket(string addr, int port) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.Socket);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SSLCertificateSocketFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultCipherSuites
				/// </java-name>
				public override string[] DefaultCipherSuites
				{
						[Dot42.DexImport("getDefaultCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// getSupportedCipherSuites
				/// </java-name>
				public override string[] SupportedCipherSuites
				{
						[Dot42.DexImport("getSupportedCipherSuites", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

		}

		/// <summary>
		///  <para>File-based cache of established SSL sessions. When re-establishing a connection to the same server, using an SSL session cache can save some time, power, and bandwidth by skipping directly to an encrypted stream. This is a persistent cache which can span executions of the application.</para> <para> <para>SSLCertificateSocketFactory </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/SSLSessionCache
		/// </java-name>
		[Dot42.DexImport("android/net/SSLSessionCache", AccessFlags = 49)]
		public sealed partial class SSLSessionCache
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a session cache using the specified directory. Individual session entries will be files within the directory. Multiple instances for the same directory share data internally.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/File;)V", AccessFlags = 1)]
				public SSLSessionCache(global::Java.IO.File dir) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a session cache using the specified directory. Individual session entries will be files within the directory. Multiple instances for the same directory share data internally.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public SSLSessionCache(global::Android.Content.Context dir) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal SSLSessionCache() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Class that provides network traffic statistics. These statistics include bytes transmitted and received and network packets transmitted and received, over all interfaces, over the mobile interface, and on a per-UID basis. </para> <para>These statistics may not be available on all platforms. If the statistics are not supported by this device, UNSUPPORTED will be returned. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/TrafficStats
		/// </java-name>
		[Dot42.DexImport("android/net/TrafficStats", AccessFlags = 33)]
		public partial class TrafficStats
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The return value to indicate that the device does not support the statistic. </para>        
				/// </summary>
				/// <java-name>
				/// UNSUPPORTED
				/// </java-name>
				[Dot42.DexImport("UNSUPPORTED", "I", AccessFlags = 25)]
				public const int UNSUPPORTED = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TrafficStats() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return number of bytes transmitted by the given UID since device boot. Counts packets across all network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available.</para> <para> <para>android.os.Process::myUid() </para> <para>android.content.pm.ApplicationInfo::uid </para></para>        
				/// </summary>
				/// <java-name>
				/// getUidTxBytes
				/// </java-name>
				[Dot42.DexImport("getUidTxBytes", "(I)J", AccessFlags = 265)]
				public static long GetUidTxBytes(int uid) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Return number of bytes received by the given UID since device boot. Counts packets across all network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available.</para> <para> <para>android.os.Process::myUid() </para> <para>android.content.pm.ApplicationInfo::uid </para></para>        
				/// </summary>
				/// <java-name>
				/// getUidRxBytes
				/// </java-name>
				[Dot42.DexImport("getUidRxBytes", "(I)J", AccessFlags = 265)]
				public static long GetUidRxBytes(int uid) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>Return number of packets transmitted across mobile networks since device boot. Counts packets across all mobile network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available. </para>        
				/// </summary>
				/// <java-name>
				/// getMobileTxPackets
				/// </java-name>
				public static long MobileTxPackets
				{
						[Dot42.DexImport("getMobileTxPackets", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return number of packets received across mobile networks since device boot. Counts packets across all mobile network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available. </para>        
				/// </summary>
				/// <java-name>
				/// getMobileRxPackets
				/// </java-name>
				public static long MobileRxPackets
				{
						[Dot42.DexImport("getMobileRxPackets", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return number of bytes transmitted across mobile networks since device boot. Counts packets across all mobile network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available. </para>        
				/// </summary>
				/// <java-name>
				/// getMobileTxBytes
				/// </java-name>
				public static long MobileTxBytes
				{
						[Dot42.DexImport("getMobileTxBytes", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return number of bytes received across mobile networks since device boot. Counts packets across all mobile network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available. </para>        
				/// </summary>
				/// <java-name>
				/// getMobileRxBytes
				/// </java-name>
				public static long MobileRxBytes
				{
						[Dot42.DexImport("getMobileRxBytes", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return number of packets transmitted since device boot. Counts packets across all network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalTxPackets
				/// </java-name>
				public static long TotalTxPackets
				{
						[Dot42.DexImport("getTotalTxPackets", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return number of packets received since device boot. Counts packets across all network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalRxPackets
				/// </java-name>
				public static long TotalRxPackets
				{
						[Dot42.DexImport("getTotalRxPackets", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return number of bytes transmitted since device boot. Counts packets across all network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalTxBytes
				/// </java-name>
				public static long TotalTxBytes
				{
						[Dot42.DexImport("getTotalTxBytes", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return number of bytes received since device boot. Counts packets across all network interfaces, and always increases monotonically since device boot. Statistics are measured at the network layer, so they include both TCP and UDP usage. </para> <para>Before android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, this may return UNSUPPORTED on devices where statistics aren't available. </para>        
				/// </summary>
				/// <java-name>
				/// getTotalRxBytes
				/// </java-name>
				public static long TotalRxBytes
				{
						[Dot42.DexImport("getTotalRxBytes", "()J", AccessFlags = 265)]
						get{ return default(long); }
				}

		}

		/// <summary>
		///  <para>Immutable URI reference. A URI reference includes a URI and a fragment, the component of the URI following a '#'. Builds and parses URI references which conform to .</para> <para>In the interest of performance, this class performs little to no validation. Behavior is undefined for invalid input. This class is very forgivingin the face of invalid input, it will return garbage rather than throw an exception unless otherwise specified. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/Uri
		/// </java-name>
		[Dot42.DexImport("android/net/Uri", AccessFlags = 1057, Signature = "Ljava/lang/Object;Landroid/os/Parcelable;Ljava/lang/Comparable<Landroid/net/Uri;>" +
    ";")]
		public abstract partial class Uri : global::Android.OS.IParcelable, global::System.IComparable<global::Android.Net.Uri>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The empty URI, equivalent to "". </para>        
				/// </summary>
				/// <java-name>
				/// EMPTY
				/// </java-name>
				[Dot42.DexImport("EMPTY", "Landroid/net/Uri;", AccessFlags = 25)]
				public static readonly global::Android.Net.Uri EMPTY;
				/// <summary>
				///  <para>Reads Uris from Parcels. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Uri> CREATOR;
				/// <summary>
				///  <para>Prevents external subclassing. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Uri() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compares this Uri to another object for equality. Returns true if the encoded string representations of this Uri and the given Uri are equal. Case counts. Paths are not normalized. If one Uri specifies a default port explicitly and the other leaves it implicit, they will not be considered equal. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Hashes the encoded string represention of this Uri consistently with equals(Object). </para>        
				/// </summary>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compares the string representation of this Uri with that of another. </para>        
				/// </summary>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Landroid/net/Uri;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Android.Net.Uri other) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the encoded string representation of this URI. Example: "http://google.com/" </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Constructs a new builder, copying the attributes from this Uri. </para>        
				/// </summary>
				/// <java-name>
				/// buildUpon
				/// </java-name>
				[Dot42.DexImport("buildUpon", "()Landroid/net/Uri$Builder;", AccessFlags = 1025)]
				public abstract global::Android.Net.Uri.Builder BuildUpon() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Creates a Uri which parses the given encoded URI string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Uri for this given uri string </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri Parse(string uriString) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Creates a Uri from a file. The URI has the form "file://&lt;absolute path&gt;". Encodes path characters with the exception of '/'.</para> <para>Example: "file:///tmp/android.txt"</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a Uri for the given file </para>
				/// </returns>
				/// <java-name>
				/// fromFile
				/// </java-name>
				[Dot42.DexImport("fromFile", "(Ljava/io/File;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri FromFile(global::Java.IO.File file) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Creates an opaque Uri from the given components. Encodes the ssp which means this method cannot be used to create hierarchical URIs.</para> <para> <para>Builder if you don't want the ssp and fragment to be encoded </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Uri composed of the given scheme, ssp, and fragment</para>
				/// </returns>
				/// <java-name>
				/// fromParts
				/// </java-name>
				[Dot42.DexImport("fromParts", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri FromParts(string scheme, string ssp, string fragment) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Searches the query string for parameter values with the given key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of decoded values </para>
				/// </returns>
				/// <java-name>
				/// getQueryParameters
				/// </java-name>
				[Dot42.DexImport("getQueryParameters", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/List<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IList<string> GetQueryParameters(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <summary>
				///  <para>Searches the query string for the first value with the given key.</para> <para> <b>Warning:</b> Prior to Ice Cream Sandwich, this decoded the '+' character as '+' rather than ' '.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded value or null if no parameter is found </para>
				/// </returns>
				/// <java-name>
				/// getQueryParameter
				/// </java-name>
				[Dot42.DexImport("getQueryParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetQueryParameter(string key) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Writes a Uri to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;Landroid/net/Uri;)V", AccessFlags = 9)]
				public static void WriteToParcel(global::Android.OS.Parcel @out, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Encodes characters in the given string as ''-escaped octets using the UTF-8 scheme. Leaves letters ("A-Z", "a-z"), numbers ("0-9"), and unreserved characters ("_-!.~'()*") intact. Encodes all other characters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an encoded version of s suitable for use as a URI component, or null if s is null </para>
				/// </returns>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Encode(string s) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Encodes characters in the given string as ''-escaped octets using the UTF-8 scheme. Leaves letters ("A-Z", "a-z"), numbers ("0-9"), and unreserved characters ("_-!.~'()*") intact. Encodes all other characters with the exception of those specified in the allow argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an encoded version of s suitable for use as a URI component, or null if s is null </para>
				/// </returns>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Encode(string s, string allow) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Decodes ''-escaped octets in the given string using the UTF-8 scheme. Replaces invalid octets with the unicode replacement character ("\\uFFFD").</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the given string with escaped octets decoded, or null if s is null </para>
				/// </returns>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Decode(string s) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Creates a new Uri by appending an already-encoded path segment to a base Uri.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new Uri based on baseUri with the given segment appended to the path </para>
				/// </returns>
				/// <java-name>
				/// withAppendedPath
				/// </java-name>
				[Dot42.DexImport("withAppendedPath", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/net/Uri;", AccessFlags = 9)]
				public static global::Android.Net.Uri WithAppendedPath(global::Android.Net.Uri baseUri, string pathSegment) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				[Dot42.DexImport("android/os/Parcelable", "describeContents", "()I", AccessFlags = 1025)]
				public virtual int DescribeContents() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/os/Parcelable", "writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1025)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				///  <para>Returns true if this URI is hierarchical like "http://google.com". Absolute URIs are hierarchical if the scheme-specific part starts with a '/'. Relative URIs are always hierarchical. </para>        
				/// </summary>
				/// <java-name>
				/// isHierarchical
				/// </java-name>
				public abstract bool IsHierarchical
				{
						[Dot42.DexImport("isHierarchical", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns true if this URI is opaque like "mailto:nobody@google.com". The scheme-specific part of an opaque URI cannot start with a '/'. </para>        
				/// </summary>
				/// <java-name>
				/// isOpaque
				/// </java-name>
				public virtual bool IsOpaque
				{
						[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if this URI is relative, i.e. if it doesn't contain an explicit scheme.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this URI is relative, false if it's absolute </para>
				/// </returns>
				/// <java-name>
				/// isRelative
				/// </java-name>
				public abstract bool IsRelative
				{
						[Dot42.DexImport("isRelative", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns true if this URI is absolute, i.e. if it contains an explicit scheme.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this URI is absolute, false if it's relative </para>
				/// </returns>
				/// <java-name>
				/// isAbsolute
				/// </java-name>
				public virtual bool IsAbsolute
				{
						[Dot42.DexImport("isAbsolute", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the scheme of this URI. Example: "http"</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the scheme or null if this is a relative URI </para>
				/// </returns>
				/// <java-name>
				/// getScheme
				/// </java-name>
				public abstract string Scheme
				{
						[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the scheme-specific part of this URI, i.e. everything between the scheme separator ':' and the fragment separator '#'. If this is a relative URI, this method returns the entire URI. Decodes escaped octets.</para> <para>Example: "//www.google.com/search?q=android"</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded scheme-specific-part </para>
				/// </returns>
				/// <java-name>
				/// getSchemeSpecificPart
				/// </java-name>
				public abstract string SchemeSpecificPart
				{
						[Dot42.DexImport("getSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the scheme-specific part of this URI, i.e. everything between the scheme separator ':' and the fragment separator '#'. If this is a relative URI, this method returns the entire URI. Leaves escaped octets intact.</para> <para>Example: "//www.google.com/search?q=android"</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded scheme-specific-part </para>
				/// </returns>
				/// <java-name>
				/// getEncodedSchemeSpecificPart
				/// </java-name>
				public abstract string EncodedSchemeSpecificPart
				{
						[Dot42.DexImport("getEncodedSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the decoded authority part of this URI. For server addresses, the authority is structured as follows:  <c>[ userinfo '@' ] host [ ':' port ] </c></para> <para>Examples: "google.com", "bob@google.com:80"</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the authority for this URI or null if not present </para>
				/// </returns>
				/// <java-name>
				/// getAuthority
				/// </java-name>
				public abstract string Authority
				{
						[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the encoded authority part of this URI. For server addresses, the authority is structured as follows:  <c>[ userinfo '@' ] host [ ':' port ] </c></para> <para>Examples: "google.com", "bob@google.com:80"</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the authority for this URI or null if not present </para>
				/// </returns>
				/// <java-name>
				/// getEncodedAuthority
				/// </java-name>
				public abstract string EncodedAuthority
				{
						[Dot42.DexImport("getEncodedAuthority", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the decoded user information from the authority. For example, if the authority is "nobody@google.com", this method will return "nobody".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the user info for this URI or null if not present </para>
				/// </returns>
				/// <java-name>
				/// getUserInfo
				/// </java-name>
				public abstract string UserInfo
				{
						[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the encoded user information from the authority. For example, if the authority is "nobody@google.com", this method will return "nobody".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the user info for this URI or null if not present </para>
				/// </returns>
				/// <java-name>
				/// getEncodedUserInfo
				/// </java-name>
				public abstract string EncodedUserInfo
				{
						[Dot42.DexImport("getEncodedUserInfo", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the encoded host from the authority for this URI. For example, if the authority is "bob@google.com", this method will return "google.com".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the host for this URI or null if not present </para>
				/// </returns>
				/// <java-name>
				/// getHost
				/// </java-name>
				public abstract string Host
				{
						[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the port from the authority for this URI. For example, if the authority is "google.com:80", this method will return 80.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the port for this URI or -1 if invalid or not present </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				public abstract int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the decoded path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded path, or null if this is not a hierarchical URI (like "mailto:nobody@google.com") or the URI is invalid </para>
				/// </returns>
				/// <java-name>
				/// getPath
				/// </java-name>
				public abstract string Path
				{
						[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the encoded path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded path, or null if this is not a hierarchical URI (like "mailto:nobody@google.com") or the URI is invalid </para>
				/// </returns>
				/// <java-name>
				/// getEncodedPath
				/// </java-name>
				public abstract string EncodedPath
				{
						[Dot42.DexImport("getEncodedPath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the decoded query component from this URI. The query comes after the query separator ('?') and before the fragment separator ('#'). This method would return "q=android" for "http://www.google.com/search?q=android".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded query or null if there isn't one </para>
				/// </returns>
				/// <java-name>
				/// getQuery
				/// </java-name>
				public abstract string Query
				{
						[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the encoded query component from this URI. The query comes after the query separator ('?') and before the fragment separator ('#'). This method would return "q=android" for "http://www.google.com/search?q=android".</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded query or null if there isn't one </para>
				/// </returns>
				/// <java-name>
				/// getEncodedQuery
				/// </java-name>
				public abstract string EncodedQuery
				{
						[Dot42.DexImport("getEncodedQuery", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the decoded fragment part of this URI, everything after the '#'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded fragment or null if there isn't one </para>
				/// </returns>
				/// <java-name>
				/// getFragment
				/// </java-name>
				public abstract string Fragment
				{
						[Dot42.DexImport("getFragment", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the encoded fragment part of this URI, everything after the '#'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded fragment or null if there isn't one </para>
				/// </returns>
				/// <java-name>
				/// getEncodedFragment
				/// </java-name>
				public abstract string EncodedFragment
				{
						[Dot42.DexImport("getEncodedFragment", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the decoded path segments.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>decoded path segments, each without a leading or trailing '/' </para>
				/// </returns>
				/// <java-name>
				/// getPathSegments
				/// </java-name>
				public abstract global::Java.Util.IList<string> PathSegments
				{
						[Dot42.DexImport("getPathSegments", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get;
				}

				/// <summary>
				///  <para>Gets the decoded last segment in the path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the decoded last segment or null if the path is empty </para>
				/// </returns>
				/// <java-name>
				/// getLastPathSegment
				/// </java-name>
				public abstract string LastPathSegment
				{
						[Dot42.DexImport("getLastPathSegment", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Helper class for building or manipulating URI references. Not safe for concurrent use.</para> <para>An absolute hierarchical URI reference follows the pattern:  <c>&lt;scheme&gt;://&lt;authority&gt;&lt;absolute path&gt;?&lt;query&gt;#&lt;fragment&gt; </c></para> <para>Relative URI references (which are always hierarchical) follow one of two patterns: <c>&lt;relative or absolute path&gt;?&lt;query&gt;#&lt;fragment&gt; </c> or <c>//&lt;authority&gt;&lt;absolute path&gt;?&lt;query&gt;#&lt;fragment&gt; </c></para> <para>An opaque URI follows this pattern:  <c>&lt;scheme&gt;:&lt;opaque part&gt;#&lt;fragment&gt; </c></para> <para>Use Uri#buildUpon() to obtain a builder representing an existing URI. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/Uri$Builder
				/// </java-name>
				[Dot42.DexImport("android/net/Uri$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Builder() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the scheme.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// scheme
						/// </java-name>
						[Dot42.DexImport("scheme", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Scheme(string scheme) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// opaquePart
						/// </java-name>
						[Dot42.DexImport("opaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder OpaquePart(string opaquePart) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the previously encoded opaque scheme-specific-part.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// encodedOpaquePart
						/// </java-name>
						[Dot42.DexImport("encodedOpaquePart", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedOpaquePart(string opaquePart) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// authority
						/// </java-name>
						[Dot42.DexImport("authority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Authority(string authority) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the previously encoded authority. </para>        
						/// </summary>
						/// <java-name>
						/// encodedAuthority
						/// </java-name>
						[Dot42.DexImport("encodedAuthority", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedAuthority(string authority) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// path
						/// </java-name>
						[Dot42.DexImport("path", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Path(string path) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the previously encoded path.</para> <para>If the path is not null and doesn't start with a '/', and if you specify a scheme and/or authority, the builder will prepend the given path with a '/'. </para>        
						/// </summary>
						/// <java-name>
						/// encodedPath
						/// </java-name>
						[Dot42.DexImport("encodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedPath(string path) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Encodes the given segment and appends it to the path. </para>        
						/// </summary>
						/// <java-name>
						/// appendPath
						/// </java-name>
						[Dot42.DexImport("appendPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder AppendPath(string newSegment) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Appends the given segment to the path. </para>        
						/// </summary>
						/// <java-name>
						/// appendEncodedPath
						/// </java-name>
						[Dot42.DexImport("appendEncodedPath", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder AppendEncodedPath(string newSegment) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// query
						/// </java-name>
						[Dot42.DexImport("query", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Query(string query) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the previously encoded query. </para>        
						/// </summary>
						/// <java-name>
						/// encodedQuery
						/// </java-name>
						[Dot42.DexImport("encodedQuery", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedQuery(string query) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// fragment
						/// </java-name>
						[Dot42.DexImport("fragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder Fragment(string fragment) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Sets the previously encoded fragment. </para>        
						/// </summary>
						/// <java-name>
						/// encodedFragment
						/// </java-name>
						[Dot42.DexImport("encodedFragment", "(Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder EncodedFragment(string fragment) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Encodes the key and value and then appends the parameter to the query string.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// appendQueryParameter
						/// </java-name>
						[Dot42.DexImport("appendQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/Uri$Builder;", AccessFlags = 1)]
						public Builder AppendQueryParameter(string key, string value) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Constructs a Uri with the current attributes.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/net/Uri;", AccessFlags = 1)]
						public global::Android.Net.Uri Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Net.Uri);
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

		/// <summary>
		///  <para>Sanitizes the Query portion of a URL. Simple example:  <code> UrlQuerySanitizer sanitizer = new UrlQuerySanitizer(); sanitizer.setAllowUnregisteredParamaters(true); sanitizer.parseUrl("http://example.com/?name=Joe+User"); String name = sanitizer.getValue("name")); // name now contains "Joe_User" </code></para> <para>Register ValueSanitizers to customize the way individual parameters are sanitized:  <code> UrlQuerySanitizer sanitizer = new UrlQuerySanitizer(); sanitizer.registerParamater("name", UrlQuerySanitizer.createSpaceLegal()); sanitizer.parseUrl("http://example.com/?name=Joe+User"); String name = sanitizer.getValue("name")); // name now contains "Joe User". (The string is first decoded, which // converts the '+' to a ' '. Then the string is sanitized, which // converts the ' ' to an '_'. (The ' ' is converted because the default unregistered parameter sanitizer does not allow any special characters, and ' ' is a special character.) </code></para> <para>There are several ways to create ValueSanitizers. In order of increasing sophistication:  <ol> <li> <para>Call one of the UrlQuerySanitizer.createXXX() methods. </para></li> <li> <para>Construct your own instance of UrlQuerySanitizer.IllegalCharacterValueSanitizer. </para></li> <li> <para>Subclass UrlQuerySanitizer.ValueSanitizer to define your own value sanitizer. </para></li></ol></para>    
		/// </summary>
		/// <java-name>
		/// android/net/UrlQuerySanitizer
		/// </java-name>
		[Dot42.DexImport("android/net/UrlQuerySanitizer", AccessFlags = 33)]
		public partial class UrlQuerySanitizer
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a UrlQuerySanitizer. </para> <para>Defaults:  <ul> <li> <para>unregistered parameters are not allowed. </para></li> <li> <para>the last instance of a repeated parameter is preferred. </para></li> <li> <para>The default value sanitizer is an AllIllegal value sanitizer.  <ul> <li></li></ul></para></li></ul></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UrlQuerySanitizer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a UrlQuerySanitizer and parse a URL. This constructor is provided for convenience when the default parsing behavior is acceptable. </para> <para>Because the URL is parsed before the constructor returns, there isn't a chance to configure the sanitizer to change the parsing behavior. </para> <para> <code> UrlQuerySanitizer sanitizer = new UrlQuerySanitizer(myUrl); String name = sanitizer.getValue("name"); </code> </para> <para>Defaults:  <ul> <li> <para>unregistered parameters  <b>are</b> allowed. </para></li> <li> <para>the last instance of a repeated parameter is preferred. </para></li> <li> <para>The default value sanitizer is an AllIllegal value sanitizer.  <ul> <li></li></ul></para></li></ul></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UrlQuerySanitizer(string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parse the query parameters out of an encoded URL. Works by extracting the query portion from the URL and then calling parseQuery(). If there is no query portion it is treated as if the query portion is an empty string. </para>        
				/// </summary>
				/// <java-name>
				/// parseUrl
				/// </java-name>
				[Dot42.DexImport("parseUrl", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ParseUrl(string url) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parse a query. A query string is any number of parameter-value clauses separated by any non-zero number of ampersands. A parameter-value clause is a parameter followed by an equal sign, followed by a value. If the equal sign is missing, the value is assumed to be the empty string. </para>        
				/// </summary>
				/// <java-name>
				/// parseQuery
				/// </java-name>
				[Dot42.DexImport("parseQuery", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ParseQuery(string query) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Check if a parameter exists in the current sanitized query. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the paramater exists in the current sanitized queary. </para>
				/// </returns>
				/// <java-name>
				/// hasParameter
				/// </java-name>
				[Dot42.DexImport("hasParameter", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool HasParameter(string parameter) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get the value for a parameter in the current sanitized query. Returns null if the parameter does not exit. </para>        
				/// </summary>
				/// <returns>
				///  <para>the sanitized unencoded value of the parameter, or null if the parameter does not exist. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue(string parameter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Register a value sanitizer for a particular parameter. Can also be used to replace or remove an already-set value sanitizer. </para> <para>Registering a non-null value sanitizer for a particular parameter makes that parameter a registered parameter.  <para>getAllowUnregisteredParamaters() </para></para>        
				/// </summary>
				/// <java-name>
				/// registerParameter
				/// </java-name>
				[Dot42.DexImport("registerParameter", "(Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", AccessFlags = 1)]
				public virtual void RegisterParameter(string parameter, global::Android.Net.UrlQuerySanitizer.IValueSanitizer valueSanitizer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a value sanitizer for an array of parameters.  <para>registerParameter </para></para>        
				/// </summary>
				/// <java-name>
				/// registerParameters
				/// </java-name>
				[Dot42.DexImport("registerParameters", "([Ljava/lang/String;Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", AccessFlags = 1)]
				public virtual void RegisterParameters(string[] parameters, global::Android.Net.UrlQuerySanitizer.IValueSanitizer valueSanitizer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Parse an escaped parameter-value pair. The default implementation unescapes both the parameter and the value, then looks up the effective value sanitizer for the parameter and uses it to sanitize the value. If all goes well then addSanitizedValue is called with the unescaped parameter and the sanitized unescaped value. </para>        
				/// </summary>
				/// <java-name>
				/// parseEntry
				/// </java-name>
				[Dot42.DexImport("parseEntry", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void ParseEntry(string parameter, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Record a sanitized parameter-value pair. Override if you want to do additional filtering or validation. </para>        
				/// </summary>
				/// <java-name>
				/// addSanitizedEntry
				/// </java-name>
				[Dot42.DexImport("addSanitizedEntry", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void AddSanitizedEntry(string parameter, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the value sanitizer for a parameter. Returns null if there is no value sanitizer registered for the parameter.  <para>registerParameter(String, android.net.UrlQuerySanitizer.ValueSanitizer) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the currently registered value sanitizer for this parameter. </para>
				/// </returns>
				/// <java-name>
				/// getValueSanitizer
				/// </java-name>
				[Dot42.DexImport("getValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 1)]
				public virtual global::Android.Net.UrlQuerySanitizer.IValueSanitizer GetValueSanitizer(string parameter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer);
				}

				/// <summary>
				///  <para>Get the effective value sanitizer for a parameter. Like getValueSanitizer, except if there is no value sanitizer registered for a parameter, and unregistered paramaters are allowed, then the default value sanitizer is returned. </para>        
				/// </summary>
				/// <returns>
				///  <para>the effective value sanitizer for a parameter. </para>
				/// </returns>
				/// <java-name>
				/// getEffectiveValueSanitizer
				/// </java-name>
				[Dot42.DexImport("getEffectiveValueSanitizer", "(Ljava/lang/String;)Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 1)]
				public virtual global::Android.Net.UrlQuerySanitizer.IValueSanitizer GetEffectiveValueSanitizer(string parameter) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer);
				}

				/// <summary>
				///  <para>Unescape an escaped string.  <ul> <li> <para>'+' characters are replaced by ' ' characters. </para></li> <li> <para>Valid "%xx" escape sequences are replaced by the corresponding unescaped character. </para></li> <li> <para>Invalid escape sequences such as %1z", are passed through unchanged.  <ol> <li></li></ol>string the escaped string </para></li></ul></para>        
				/// </summary>
				/// <returns>
				///  <para>the unescaped string. </para>
				/// </returns>
				/// <java-name>
				/// unescape
				/// </java-name>
				[Dot42.DexImport("unescape", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Unescape(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Test if a character is a hexidecimal digit. Both upper case and lower case hex digits are allowed. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if c is a hex digit. </para>
				/// </returns>
				/// <java-name>
				/// isHexDigit
				/// </java-name>
				[Dot42.DexImport("isHexDigit", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsHexDigit(char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Convert a character that represents a hexidecimal digit into an integer. If the character is not a hexidecimal digit, then -1 is returned. Both upper case and lower case hex digits are allowed. </para>        
				/// </summary>
				/// <returns>
				///  <para>the integer value of the hexidecimal digit. </para>
				/// </returns>
				/// <java-name>
				/// decodeHexDigit
				/// </java-name>
				[Dot42.DexImport("decodeHexDigit", "(C)I", AccessFlags = 4)]
				protected internal virtual int DecodeHexDigit(char c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Clear the existing entries. Called to get ready to parse a new query string. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 4)]
				protected internal virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the current value sanitizer used when processing unregistered parameter values. </para> <para> <b>Note:</b> The default unregistered parameter value sanitizer is one that doesn't allow any special characters, similar to what is returned by calling createAllIllegal.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current ValueSanitizer used to sanitize unregistered parameter values. </para>
				/// </returns>
				/// <java-name>
				/// getUnregisteredParameterValueSanitizer
				/// </java-name>
				public virtual global::Android.Net.UrlQuerySanitizer.IValueSanitizer UnregisteredParameterValueSanitizer
				{
						[Dot42.DexImport("getUnregisteredParameterValueSanitizer", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 1)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
						[Dot42.DexImport("setUnregisteredParameterValueSanitizer", "(Landroid/net/UrlQuerySanitizer$ValueSanitizer;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Return a value sanitizer that does not allow any special characters, and also does not allow script URLs. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getAllIllegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AllIllegal
				{
						[Dot42.DexImport("getAllIllegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Return a value sanitizer that allows everything except Nul ('\0') characters. Script URLs are allowed. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getAllButNulLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AllButNulLegal
				{
						[Dot42.DexImport("getAllButNulLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Return a value sanitizer that allows everything except Nul ('\0') characters, space (' '), and other whitespace characters. Script URLs are allowed. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getAllButWhitespaceLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AllButWhitespaceLegal
				{
						[Dot42.DexImport("getAllButWhitespaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Return a value sanitizer that allows all the characters used by encoded URLs. Does not allow script URLs. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getUrlLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer UrlLegal
				{
						[Dot42.DexImport("getUrlLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Return a value sanitizer that allows all the characters used by encoded URLs and allows spaces, which are not technically legal in encoded URLs, but commonly appear anyway. Does not allow script URLs. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getUrlAndSpaceLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer UrlAndSpaceLegal
				{
						[Dot42.DexImport("getUrlAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Return a value sanitizer that does not allow any special characters except ampersand ('&amp;'). Does not allow script URLs. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getAmpLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AmpLegal
				{
						[Dot42.DexImport("getAmpLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Return a value sanitizer that does not allow any special characters except ampersand ('&amp;') and space (' '). Does not allow script URLs. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getAmpAndSpaceLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AmpAndSpaceLegal
				{
						[Dot42.DexImport("getAmpAndSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Return a value sanitizer that does not allow any special characters except space (' '). Does not allow script URLs. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getSpaceLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer SpaceLegal
				{
						[Dot42.DexImport("getSpaceLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Return a value sanitizer that allows any special characters except angle brackets ('&lt;' and '&gt;') and Nul ('\0'). Allows script URLs. </para>        
				/// </summary>
				/// <returns>
				///  <para>a value sanitizer </para>
				/// </returns>
				/// <java-name>
				/// getAllButNulAndAngleBracketsLegal
				/// </java-name>
				public static global::Android.Net.UrlQuerySanitizer.IValueSanitizer AllButNulAndAngleBracketsLegal
				{
						[Dot42.DexImport("getAllButNulAndAngleBracketsLegal", "()Landroid/net/UrlQuerySanitizer$ValueSanitizer;", AccessFlags = 25)]
						get{ return default(global::Android.Net.UrlQuerySanitizer.IValueSanitizer); }
				}

				/// <summary>
				///  <para>Get a set of all of the parameters found in the sanitized query. </para> <para>Note: Do not modify this set. Treat it as a read-only set. </para>        
				/// </summary>
				/// <returns>
				///  <para>all the parameters found in the current query. </para>
				/// </returns>
				/// <java-name>
				/// getParameterSet
				/// </java-name>
				public virtual global::Java.Util.ISet<string> ParameterSet
				{
						[Dot42.DexImport("getParameterSet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				/// <summary>
				///  <para>An array list of all of the parameter value pairs in the sanitized query, in the order they appeared in the query. May contain duplicate parameters. </para> <para> <b>Note:</b> Do not modify this list. Treat it as a read-only list.</para>        
				/// </summary>
				/// <java-name>
				/// getParameterList
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Net.UrlQuerySanitizer.ParameterValuePair> ParameterList
				{
						[Dot42.DexImport("getParameterList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/net/UrlQuerySanitizer$ParameterValuePair;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Net.UrlQuerySanitizer.ParameterValuePair>); }
				}

				/// <summary>
				///  <para>Get whether or not unregistered parameters are allowed. If not allowed, they will be dropped when a query is parsed.  <para>setAllowUnregisteredParamaters(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if unregistered parameters are allowed. </para>
				/// </returns>
				/// <java-name>
				/// getAllowUnregisteredParamaters
				/// </java-name>
				public virtual bool AllowUnregisteredParamaters
				{
						[Dot42.DexImport("getAllowUnregisteredParamaters", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAllowUnregisteredParamaters", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get whether or not the first occurrence of a repeated parameter is preferred.  <para>setPreferFirstRepeatedParameter(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the first occurrence of a repeated parameter is preferred. </para>
				/// </returns>
				/// <java-name>
				/// getPreferFirstRepeatedParameter
				/// </java-name>
				public virtual bool PreferFirstRepeatedParameter
				{
						[Dot42.DexImport("getPreferFirstRepeatedParameter", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPreferFirstRepeatedParameter", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Sanitize values based on which characters they contain. Illegal characters are replaced with either space or '_', depending upon whether space is a legal character or not. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/UrlQuerySanitizer$IllegalCharacterValueSanitizer
				/// </java-name>
				[Dot42.DexImport("android/net/UrlQuerySanitizer$IllegalCharacterValueSanitizer", AccessFlags = 9)]
				public partial class IllegalCharacterValueSanitizer : global::Android.Net.UrlQuerySanitizer.IValueSanitizer
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Allow space (' ') characters. </para>        
						/// </summary>
						/// <java-name>
						/// SPACE_OK
						/// </java-name>
						[Dot42.DexImport("SPACE_OK", "I", AccessFlags = 25)]
						public const int SPACE_OK = 1;
						/// <summary>
						///  <para>Allow whitespace characters other than space. The other whitespace characters are '' '' ' <br></br>' '' and '\0x000b' (vertical tab) </para>        
						/// </summary>
						/// <java-name>
						/// OTHER_WHITESPACE_OK
						/// </java-name>
						[Dot42.DexImport("OTHER_WHITESPACE_OK", "I", AccessFlags = 25)]
						public const int OTHER_WHITESPACE_OK = 2;
						/// <summary>
						///  <para>Allow characters with character codes 128 to 255. </para>        
						/// </summary>
						/// <java-name>
						/// NON_7_BIT_ASCII_OK
						/// </java-name>
						[Dot42.DexImport("NON_7_BIT_ASCII_OK", "I", AccessFlags = 25)]
						public const int NON_7_BIT_ASCII_OK = 4;
						/// <summary>
						///  <para>Allow double quote characters. ('"') </para>        
						/// </summary>
						/// <java-name>
						/// DQUOTE_OK
						/// </java-name>
						[Dot42.DexImport("DQUOTE_OK", "I", AccessFlags = 25)]
						public const int DQUOTE_OK = 8;
						/// <summary>
						///  <para>Allow single quote characters. ('\'') </para>        
						/// </summary>
						/// <java-name>
						/// SQUOTE_OK
						/// </java-name>
						[Dot42.DexImport("SQUOTE_OK", "I", AccessFlags = 25)]
						public const int SQUOTE_OK = 16;
						/// <summary>
						///  <para>Allow less-than characters. ('&lt;') </para>        
						/// </summary>
						/// <java-name>
						/// LT_OK
						/// </java-name>
						[Dot42.DexImport("LT_OK", "I", AccessFlags = 25)]
						public const int LT_OK = 32;
						/// <summary>
						///  <para>Allow greater-than characters. ('&gt;') </para>        
						/// </summary>
						/// <java-name>
						/// GT_OK
						/// </java-name>
						[Dot42.DexImport("GT_OK", "I", AccessFlags = 25)]
						public const int GT_OK = 64;
						/// <summary>
						///  <para>Allow ampersand characters ('&amp;') </para>        
						/// </summary>
						/// <java-name>
						/// AMP_OK
						/// </java-name>
						[Dot42.DexImport("AMP_OK", "I", AccessFlags = 25)]
						public const int AMP_OK = 128;
						/// <summary>
						///  <para>Allow percent-sign characters ('') </para>        
						/// </summary>
						/// <java-name>
						/// PCT_OK
						/// </java-name>
						[Dot42.DexImport("PCT_OK", "I", AccessFlags = 25)]
						public const int PCT_OK = 256;
						/// <summary>
						///  <para>Allow nul characters ('\0') </para>        
						/// </summary>
						/// <java-name>
						/// NUL_OK
						/// </java-name>
						[Dot42.DexImport("NUL_OK", "I", AccessFlags = 25)]
						public const int NUL_OK = 512;
						/// <summary>
						///  <para>Allow text to start with a script URL such as "javascript:" or "vbscript:" </para>        
						/// </summary>
						/// <java-name>
						/// SCRIPT_URL_OK
						/// </java-name>
						[Dot42.DexImport("SCRIPT_URL_OK", "I", AccessFlags = 25)]
						public const int SCRIPT_URL_OK = 1024;
						/// <summary>
						///  <para>Mask with all fields set to OK </para>        
						/// </summary>
						/// <java-name>
						/// ALL_OK
						/// </java-name>
						[Dot42.DexImport("ALL_OK", "I", AccessFlags = 25)]
						public const int ALL_OK = 2047;
						/// <summary>
						///  <para>Mask with both regular space and other whitespace OK </para>        
						/// </summary>
						/// <java-name>
						/// ALL_WHITESPACE_OK
						/// </java-name>
						[Dot42.DexImport("ALL_WHITESPACE_OK", "I", AccessFlags = 25)]
						public const int ALL_WHITESPACE_OK = 3;
						/// <summary>
						///  <para> <ul> <li> <para>Deny all special characters. </para></li> <li> <para>Deny script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// ALL_ILLEGAL
						/// </java-name>
						[Dot42.DexImport("ALL_ILLEGAL", "I", AccessFlags = 25)]
						public const int ALL_ILLEGAL = 0;
						/// <summary>
						///  <para> <ul> <li> <para>Allow all special characters except Nul. ('\0'). </para></li> <li> <para>Allow script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// ALL_BUT_NUL_LEGAL
						/// </java-name>
						[Dot42.DexImport("ALL_BUT_NUL_LEGAL", "I", AccessFlags = 25)]
						public const int ALL_BUT_NUL_LEGAL = 1535;
						/// <summary>
						///  <para> <ul> <li> <para>Allow all special characters except for:  <ul> <li> <para>whitespace characters </para></li> <li> <para>Nul ('\0') </para></li></ul></para></li> <li> <para>Allow script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// ALL_BUT_WHITESPACE_LEGAL
						/// </java-name>
						[Dot42.DexImport("ALL_BUT_WHITESPACE_LEGAL", "I", AccessFlags = 25)]
						public const int ALL_BUT_WHITESPACE_LEGAL = 1532;
						/// <summary>
						///  <para> <ul> <li> <para>Allow characters used by encoded URLs. </para></li> <li> <para>Deny script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// URL_LEGAL
						/// </java-name>
						[Dot42.DexImport("URL_LEGAL", "I", AccessFlags = 25)]
						public const int URL_LEGAL = 404;
						/// <summary>
						///  <para> <ul> <li> <para>Allow characters used by encoded URLs. </para></li> <li> <para>Allow spaces. </para></li> <li> <para>Deny script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// URL_AND_SPACE_LEGAL
						/// </java-name>
						[Dot42.DexImport("URL_AND_SPACE_LEGAL", "I", AccessFlags = 25)]
						public const int URL_AND_SPACE_LEGAL = 405;
						/// <summary>
						///  <para> <ul> <li> <para>Allow ampersand. </para></li> <li> <para>Deny script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// AMP_LEGAL
						/// </java-name>
						[Dot42.DexImport("AMP_LEGAL", "I", AccessFlags = 25)]
						public const int AMP_LEGAL = 128;
						/// <summary>
						///  <para> <ul> <li> <para>Allow ampersand. </para></li> <li> <para>Allow space. </para></li> <li> <para>Deny script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// AMP_AND_SPACE_LEGAL
						/// </java-name>
						[Dot42.DexImport("AMP_AND_SPACE_LEGAL", "I", AccessFlags = 25)]
						public const int AMP_AND_SPACE_LEGAL = 129;
						/// <summary>
						///  <para> <ul> <li> <para>Allow space. </para></li> <li> <para>Deny script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// SPACE_LEGAL
						/// </java-name>
						[Dot42.DexImport("SPACE_LEGAL", "I", AccessFlags = 25)]
						public const int SPACE_LEGAL = 1;
						/// <summary>
						///  <para> <ul> <li> <para>Allow all but.  <ul> <li> <para>Nul ('\0') </para></li> <li> <para>Angle brackets ('&lt;', '&gt;') </para></li></ul></para></li> <li> <para>Deny script URLs. </para></li></ul></para>        
						/// </summary>
						/// <java-name>
						/// ALL_BUT_NUL_AND_ANGLE_BRACKETS_LEGAL
						/// </java-name>
						[Dot42.DexImport("ALL_BUT_NUL_AND_ANGLE_BRACKETS_LEGAL", "I", AccessFlags = 25)]
						public const int ALL_BUT_NUL_AND_ANGLE_BRACKETS_LEGAL = 1439;
						[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
						public IllegalCharacterValueSanitizer(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sanitize a value.  <ol> <li> <para>If script URLs are not OK, the will be removed. </para></li> <li> <para>If neither spaces nor other white space is OK, then white space will be trimmed from the beginning and end of the URL. (Just the actual white space characters are trimmed, not other control codes.) </para></li> <li> <para>Illegal characters will be replaced with either ' ' or '_', depending on whether a space is itself a legal character. </para></li></ol></para>        
						/// </summary>
						/// <returns>
						///  <para>the sanitized value </para>
						/// </returns>
						/// <java-name>
						/// sanitize
						/// </java-name>
						[Dot42.DexImport("sanitize", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Sanitize(string value) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal IllegalCharacterValueSanitizer() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>A functor used to sanitize a single query value. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/UrlQuerySanitizer$ValueSanitizer
				/// </java-name>
				[Dot42.DexImport("android/net/UrlQuerySanitizer$ValueSanitizer", AccessFlags = 1545)]
				public partial interface IValueSanitizer
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Sanitize an unencoded value. </para>        
						/// </summary>
						/// <returns>
						///  <para>the sanitized unencoded value </para>
						/// </returns>
						/// <java-name>
						/// sanitize
						/// </java-name>
						[Dot42.DexImport("sanitize", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
						string Sanitize(string value) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>A simple tuple that holds parameter-value pairs. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/UrlQuerySanitizer$ParameterValuePair
				/// </java-name>
				[Dot42.DexImport("android/net/UrlQuerySanitizer$ParameterValuePair", AccessFlags = 1)]
				public partial class ParameterValuePair
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The unencoded parameter </para>        
						/// </summary>
						/// <java-name>
						/// mParameter
						/// </java-name>
						[Dot42.DexImport("mParameter", "Ljava/lang/String;", AccessFlags = 1)]
						public string MParameter;
						/// <summary>
						///  <para>The unencoded value </para>        
						/// </summary>
						/// <java-name>
						/// mValue
						/// </java-name>
						[Dot42.DexImport("mValue", "Ljava/lang/String;", AccessFlags = 1)]
						public string MValue;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/net/UrlQuerySanitizer;", AccessFlags = 4112)]
						internal readonly global::Android.Net.UrlQuerySanitizer This_0;
						[Dot42.DexImport("<init>", "(Landroid/net/UrlQuerySanitizer;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
						public ParameterValuePair(global::Android.Net.UrlQuerySanitizer urlQuerySanitizer, string @string, string string1) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal ParameterValuePair() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

}

