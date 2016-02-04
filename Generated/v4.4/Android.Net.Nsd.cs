#pragma warning disable 1717
namespace Android.Net.Nsd
{
		/// <summary>
		///  <para>The Network Service Discovery Manager class provides the API to discover services on a network. As an example, if device A and device B are connected over a Wi-Fi network, a game registered on device A can be discovered by a game on device B. Another example use case is an application discovering printers on the network.</para> <para>The API currently supports DNS based service discovery and discovery is currently limited to a local network over Multicast DNS. DNS service discovery is described at </para> <para>The API is asynchronous and responses to requests from an application are on listener callbacks on a seperate thread.</para> <para>There are three main operations the API supports - registration, discovery and resolution.  <pre>
		///                          Application start
		///                                 |
		///                                 |
		///                                 |                  onServiceRegistered()
		///                     Register any local services  /
		///                      to be advertised with       \
		///                       registerService()            onRegistrationFailed()
		///                                 |
		///                                 |
		///                          discoverServices()
		///                                 |
		///                      Maintain a list to track
		///                        discovered services
		///                                 |
		///                                 |---------&gt;
		///                                 |          |
		///                                 |      onServiceFound()
		///                                 |          |
		///                                 |     add service to list
		///                                 |          |
		///                                 |&lt;----------
		///                                 |
		///                                 |---------&gt;
		///                                 |          |
		///                                 |      onServiceLost()
		///                                 |          |
		///                                 |   remove service from list
		///                                 |          |
		///                                 |&lt;----------
		///                                 |
		///                                 |
		///                                 | Connect to a service
		///                                 | from list ?
		///                                 |
		///                          resolveService()
		///                                 |
		///                         onServiceResolved()
		///                                 |
		///                     Establish connection to service
		///                     with the host and port information</pre></para> <para> <pre></pre> An application that needs to advertise itself over a network for other applications to discover it can do so with a call to registerService. If Example is a http based application that can provide HTML data to peer services, it can register a name "Example" with service type "_http._tcp". A successful registration is notified with a callback to RegistrationListener#onServiceRegistered and a failure to register is notified over RegistrationListener#onRegistrationFailed</para> <para>A peer application looking for http services can initiate a discovery for "_http._tcp" with a call to discoverServices. A service found is notified with a callback to DiscoveryListener#onServiceFound and a service lost is notified on DiscoveryListener#onServiceLost.</para> <para>Once the peer application discovers the "Example" http srevice, and needs to receive data from the "Example" application, it can initiate a resolve with resolveService to resolve the host and port details for the purpose of establishing a connection. A successful resolve is notified on ResolveListener#onServiceResolved and a failure is notified on ResolveListener#onResolveFailed.</para> <para>Applications can reserve for a service type at . Existing services can be found at </para> <para>Get an instance of this class by calling Context.getSystemService(Context.NSD_SERVICE).</para> <para>{ <para>NsdServiceInfo} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/nsd/NsdManager
		/// </java-name>
		[Dot42.DexImport("android/net/nsd/NsdManager", AccessFlags = 49)]
		public sealed partial class NsdManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Broadcast intent action to indicate whether network service discovery is enabled or disabled. An extra EXTRA_NSD_STATE provides the state information as int.</para> <para> <para>EXTRA_NSD_STATE </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NSD_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_NSD_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NSD_STATE_CHANGED = "android.net.nsd.STATE_CHANGED";
				/// <summary>
				///  <para>The lookup key for an int that indicates whether network service discovery is enabled or disabled. Retrieve it with android.content.Intent#getIntExtra(String,int).</para> <para> <para>NSD_STATE_DISABLED </para> <para>NSD_STATE_ENABLED </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NSD_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_NSD_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NSD_STATE = "nsd_state";
				/// <summary>
				///  <para>Network service discovery is disabled</para> <para> <para>ACTION_NSD_STATE_CHANGED </para></para>        
				/// </summary>
				/// <java-name>
				/// NSD_STATE_DISABLED
				/// </java-name>
				[Dot42.DexImport("NSD_STATE_DISABLED", "I", AccessFlags = 25)]
				public const int NSD_STATE_DISABLED = 1;
				/// <summary>
				///  <para>Network service discovery is enabled</para> <para> <para>ACTION_NSD_STATE_CHANGED </para></para>        
				/// </summary>
				/// <java-name>
				/// NSD_STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("NSD_STATE_ENABLED", "I", AccessFlags = 25)]
				public const int NSD_STATE_ENABLED = 2;
				/// <summary>
				///  <para>Dns based service discovery protocol </para>        
				/// </summary>
				/// <java-name>
				/// PROTOCOL_DNS_SD
				/// </java-name>
				[Dot42.DexImport("PROTOCOL_DNS_SD", "I", AccessFlags = 25)]
				public const int PROTOCOL_DNS_SD = 1;
				/// <summary>
				///  <para>Failures are passed with RegistrationListener#onRegistrationFailed, RegistrationListener#onUnregistrationFailed, DiscoveryListener#onStartDiscoveryFailed, DiscoveryListener#onStopDiscoveryFailed or ResolveListener#onResolveFailed.</para> <para>Indicates that the operation failed due to an internal error. </para>        
				/// </summary>
				/// <java-name>
				/// FAILURE_INTERNAL_ERROR
				/// </java-name>
				[Dot42.DexImport("FAILURE_INTERNAL_ERROR", "I", AccessFlags = 25)]
				public const int FAILURE_INTERNAL_ERROR = 0;
				/// <summary>
				///  <para>Indicates that the operation failed because it is already active. </para>        
				/// </summary>
				/// <java-name>
				/// FAILURE_ALREADY_ACTIVE
				/// </java-name>
				[Dot42.DexImport("FAILURE_ALREADY_ACTIVE", "I", AccessFlags = 25)]
				public const int FAILURE_ALREADY_ACTIVE = 3;
				/// <summary>
				///  <para>Indicates that the operation failed because the maximum outstanding requests from the applications have reached. </para>        
				/// </summary>
				/// <java-name>
				/// FAILURE_MAX_LIMIT
				/// </java-name>
				[Dot42.DexImport("FAILURE_MAX_LIMIT", "I", AccessFlags = 25)]
				public const int FAILURE_MAX_LIMIT = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NsdManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a service to be discovered by other services.</para> <para>The function call immediately returns after sending a request to register service to the framework. The application is notified of a success to initiate discovery through the callback RegistrationListener#onServiceRegistered or a failure through RegistrationListener#onRegistrationFailed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// registerService
				/// </java-name>
				[Dot42.DexImport("registerService", "(Landroid/net/nsd/NsdServiceInfo;ILandroid/net/nsd/NsdManager$RegistrationListene" +
    "r;)V", AccessFlags = 1)]
				public void RegisterService(global::Android.Net.Nsd.NsdServiceInfo serviceInfo, int protocolType, global::Android.Net.Nsd.NsdManager.IRegistrationListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unregister a service registered through registerService. A successful unregister is notified to the application with a call to RegistrationListener#onServiceUnregistered.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unregisterService
				/// </java-name>
				[Dot42.DexImport("unregisterService", "(Landroid/net/nsd/NsdManager$RegistrationListener;)V", AccessFlags = 1)]
				public void UnregisterService(global::Android.Net.Nsd.NsdManager.IRegistrationListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initiate service discovery to browse for instances of a service type. Service discovery consumes network bandwidth and will continue until the application calls stopServiceDiscovery.</para> <para>The function call immediately returns after sending a request to start service discovery to the framework. The application is notified of a success to initiate discovery through the callback DiscoveryListener#onDiscoveryStarted or a failure through DiscoveryListener#onStartDiscoveryFailed.</para> <para>Upon successful start, application is notified when a service is found with DiscoveryListener#onServiceFound or when a service is lost with DiscoveryListener#onServiceLost.</para> <para>Upon failure to start, service discovery is not active and application does not need to invoke stopServiceDiscovery</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// discoverServices
				/// </java-name>
				[Dot42.DexImport("discoverServices", "(Ljava/lang/String;ILandroid/net/nsd/NsdManager$DiscoveryListener;)V", AccessFlags = 1)]
				public void DiscoverServices(string serviceType, int protocolType, global::Android.Net.Nsd.NsdManager.IDiscoveryListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop service discovery initiated with discoverServices. An active service discovery is notified to the application with DiscoveryListener#onDiscoveryStarted and it stays active until the application invokes a stop service discovery. A successful stop is notified to with a call to DiscoveryListener#onDiscoveryStopped.</para> <para>Upon failure to stop service discovery, application is notified through DiscoveryListener#onStopDiscoveryFailed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// stopServiceDiscovery
				/// </java-name>
				[Dot42.DexImport("stopServiceDiscovery", "(Landroid/net/nsd/NsdManager$DiscoveryListener;)V", AccessFlags = 1)]
				public void StopServiceDiscovery(global::Android.Net.Nsd.NsdManager.IDiscoveryListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resolve a discovered service. An application can resolve a service right before establishing a connection to fetch the IP and port details on which to setup the connection.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// resolveService
				/// </java-name>
				[Dot42.DexImport("resolveService", "(Landroid/net/nsd/NsdServiceInfo;Landroid/net/nsd/NsdManager$ResolveListener;)V", AccessFlags = 1)]
				public void ResolveService(global::Android.Net.Nsd.NsdServiceInfo serviceInfo, global::Android.Net.Nsd.NsdManager.IResolveListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Interface for callback invocation for service resolution </para>    
				/// </summary>
				/// <java-name>
				/// android/net/nsd/NsdManager$ResolveListener
				/// </java-name>
				[Dot42.DexImport("android/net/nsd/NsdManager$ResolveListener", AccessFlags = 1545)]
				public partial interface IResolveListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onResolveFailed
						/// </java-name>
						[Dot42.DexImport("onResolveFailed", "(Landroid/net/nsd/NsdServiceInfo;I)V", AccessFlags = 1025)]
						void OnResolveFailed(global::Android.Net.Nsd.NsdServiceInfo serviceInfo, int errorCode) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onServiceResolved
						/// </java-name>
						[Dot42.DexImport("onServiceResolved", "(Landroid/net/nsd/NsdServiceInfo;)V", AccessFlags = 1025)]
						void OnServiceResolved(global::Android.Net.Nsd.NsdServiceInfo serviceInfo) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface for callback invocation for service registration </para>    
				/// </summary>
				/// <java-name>
				/// android/net/nsd/NsdManager$RegistrationListener
				/// </java-name>
				[Dot42.DexImport("android/net/nsd/NsdManager$RegistrationListener", AccessFlags = 1545)]
				public partial interface IRegistrationListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onRegistrationFailed
						/// </java-name>
						[Dot42.DexImport("onRegistrationFailed", "(Landroid/net/nsd/NsdServiceInfo;I)V", AccessFlags = 1025)]
						void OnRegistrationFailed(global::Android.Net.Nsd.NsdServiceInfo serviceInfo, int errorCode) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onUnregistrationFailed
						/// </java-name>
						[Dot42.DexImport("onUnregistrationFailed", "(Landroid/net/nsd/NsdServiceInfo;I)V", AccessFlags = 1025)]
						void OnUnregistrationFailed(global::Android.Net.Nsd.NsdServiceInfo serviceInfo, int errorCode) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onServiceRegistered
						/// </java-name>
						[Dot42.DexImport("onServiceRegistered", "(Landroid/net/nsd/NsdServiceInfo;)V", AccessFlags = 1025)]
						void OnServiceRegistered(global::Android.Net.Nsd.NsdServiceInfo serviceInfo) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onServiceUnregistered
						/// </java-name>
						[Dot42.DexImport("onServiceUnregistered", "(Landroid/net/nsd/NsdServiceInfo;)V", AccessFlags = 1025)]
						void OnServiceUnregistered(global::Android.Net.Nsd.NsdServiceInfo serviceInfo) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface for callback invocation for service discovery </para>    
				/// </summary>
				/// <java-name>
				/// android/net/nsd/NsdManager$DiscoveryListener
				/// </java-name>
				[Dot42.DexImport("android/net/nsd/NsdManager$DiscoveryListener", AccessFlags = 1545)]
				public partial interface IDiscoveryListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onStartDiscoveryFailed
						/// </java-name>
						[Dot42.DexImport("onStartDiscoveryFailed", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
						void OnStartDiscoveryFailed(string serviceType, int errorCode) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onStopDiscoveryFailed
						/// </java-name>
						[Dot42.DexImport("onStopDiscoveryFailed", "(Ljava/lang/String;I)V", AccessFlags = 1025)]
						void OnStopDiscoveryFailed(string serviceType, int errorCode) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDiscoveryStarted
						/// </java-name>
						[Dot42.DexImport("onDiscoveryStarted", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						void OnDiscoveryStarted(string serviceType) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDiscoveryStopped
						/// </java-name>
						[Dot42.DexImport("onDiscoveryStopped", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						void OnDiscoveryStopped(string serviceType) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onServiceFound
						/// </java-name>
						[Dot42.DexImport("onServiceFound", "(Landroid/net/nsd/NsdServiceInfo;)V", AccessFlags = 1025)]
						void OnServiceFound(global::Android.Net.Nsd.NsdServiceInfo serviceInfo) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onServiceLost
						/// </java-name>
						[Dot42.DexImport("onServiceLost", "(Landroid/net/nsd/NsdServiceInfo;)V", AccessFlags = 1025)]
						void OnServiceLost(global::Android.Net.Nsd.NsdServiceInfo serviceInfo) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A class representing service information for network service discovery { <para>NsdManager} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/nsd/NsdServiceInfo
		/// </java-name>
		[Dot42.DexImport("android/net/nsd/NsdServiceInfo", AccessFlags = 49)]
		public sealed partial class NsdServiceInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Nsd.NsdServiceInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NsdServiceInfo() /* MethodBuilder.Create */ 
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
				public int DescribeContents() /* MethodBuilder.Create */ 
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
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the service name </para>        
				/// </summary>
				/// <java-name>
				/// getServiceName
				/// </java-name>
				public string ServiceName
				{
						[Dot42.DexImport("getServiceName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setServiceName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the service type </para>        
				/// </summary>
				/// <java-name>
				/// getServiceType
				/// </java-name>
				public string ServiceType
				{
						[Dot42.DexImport("getServiceType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setServiceType", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get the host address. The host address is valid for a resolved service. </para>        
				/// </summary>
				/// <java-name>
				/// getHost
				/// </java-name>
				public global::Java.Net.InetAddress Host
				{
						[Dot42.DexImport("getHost", "()Ljava/net/InetAddress;", AccessFlags = 1)]
						get{ return default(global::Java.Net.InetAddress); }
						[Dot42.DexImport("setHost", "(Ljava/net/InetAddress;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Get port number. The port number is valid for a resolved service. </para>        
				/// </summary>
				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setPort", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

}

