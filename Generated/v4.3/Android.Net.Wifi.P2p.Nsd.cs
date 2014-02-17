// Copyright (C) 2014 dot42
//
// Original filename: Android.Net.Wifi.P2p.Nsd.cs
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
namespace Android.Net.Wifi.P2p.Nsd
{
		/// <summary>
		/// <para>A class for creating a service discovery request for use with WifiP2pManager#addServiceRequest and WifiP2pManager#removeServiceRequest</para><para>This class is used to create service discovery request for custom vendor specific service discovery protocol WifiP2pServiceInfo#SERVICE_TYPE_VENDOR_SPECIFIC or to search all service protocols WifiP2pServiceInfo#SERVICE_TYPE_ALL.</para><para>For the purpose of creating a UPnP or Bonjour service request, use WifiP2pUpnpServiceRequest or WifiP2pDnsSdServiceRequest respectively.</para><para>{<para>WifiP2pManager} {</para><simplesectsep></simplesectsep><para>WifiP2pUpnpServiceRequest} {</para><simplesectsep></simplesectsep><para>WifiP2pDnsSdServiceRequest} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/nsd/WifiP2pServiceRequest
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/nsd/WifiP2pServiceRequest", AccessFlags = 33)]
		public partial class WifiP2pServiceRequest : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiP2pServiceRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a service discovery request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>service discovery request. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(ILjava/lang/String;)Landroid/net/wifi/p2p/nsd/WifiP2pServiceRequest;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pServiceRequest NewInstance(int protocolType, string queryData) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pServiceRequest);
				}

				/// <summary>
				/// <para>Create a service discovery request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>service discovery request. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(I)Landroid/net/wifi/p2p/nsd/WifiP2pServiceRequest;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pServiceRequest NewInstance(int protocolType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pServiceRequest);
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

				/// <summary>
				/// <para>Implement the Parcelable interface {} </para>        
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
				/// <para>Implement the Parcelable interface {} </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A class for creating a Upnp service discovery request for use with WifiP2pManager#addServiceRequest and WifiP2pManager#removeServiceRequest</para><para>{<para>WifiP2pManager} {</para><simplesectsep></simplesectsep><para>WifiP2pServiceRequest} {</para><simplesectsep></simplesectsep><para>WifiP2pDnsSdServiceRequest} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/nsd/WifiP2pUpnpServiceRequest
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/nsd/WifiP2pUpnpServiceRequest", AccessFlags = 33)]
		public partial class WifiP2pUpnpServiceRequest : global::Android.Net.Wifi.P2p.Nsd.WifiP2pServiceRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This constructor is only used in newInstance().  </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiP2pUpnpServiceRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a service discovery request to search all UPnP services.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>service request for UPnP. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Landroid/net/wifi/p2p/nsd/WifiP2pUpnpServiceRequest;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pUpnpServiceRequest NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pUpnpServiceRequest);
				}

				/// <summary>
				/// <para>Create a service discovery request to search specified UPnP services.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>service request for UPnP. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;)Landroid/net/wifi/p2p/nsd/WifiP2pUpnpServiceRequest;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pUpnpServiceRequest NewInstance(string st) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pUpnpServiceRequest);
				}

		}

		/// <summary>
		/// <para>A class for storing Upnp service information that is advertised over a Wi-Fi peer-to-peer setup.</para><para>{<para>android.net.wifi.p2p.WifiP2pManager::addLocalService} {</para><simplesectsep></simplesectsep><para>android.net.wifi.p2p.WifiP2pManager::removeLocalService} {</para><simplesectsep></simplesectsep><para>WifiP2pServiceInfo} {</para><simplesectsep></simplesectsep><para>WifiP2pDnsSdServiceInfo} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/nsd/WifiP2pUpnpServiceInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/nsd/WifiP2pUpnpServiceInfo", AccessFlags = 33)]
		public partial class WifiP2pUpnpServiceInfo : global::Android.Net.Wifi.P2p.Nsd.WifiP2pServiceInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiP2pUpnpServiceInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create UPnP service information object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>UPnP service information object. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Landroid/net/wifi/p2p/nsd/W" +
    "ifiP2pUpnpServiceInfo;", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List<Ljava/lang/String;>;)Landroi" +
    "d/net/wifi/p2p/nsd/WifiP2pUpnpServiceInfo;")]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pUpnpServiceInfo NewInstance(string uuid, string device, global::Java.Util.IList<string> services) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pUpnpServiceInfo);
				}

		}

		/// <summary>
		/// <para>A class for storing Bonjour service information that is advertised over a Wi-Fi peer-to-peer setup.</para><para>{<para>android.net.wifi.p2p.WifiP2pManager::addLocalService} {</para><simplesectsep></simplesectsep><para>android.net.wifi.p2p.WifiP2pManager::removeLocalService} {</para><simplesectsep></simplesectsep><para>WifiP2pServiceInfo} {</para><simplesectsep></simplesectsep><para>WifiP2pUpnpServiceInfo} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/nsd/WifiP2pDnsSdServiceInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/nsd/WifiP2pDnsSdServiceInfo", AccessFlags = 33)]
		public partial class WifiP2pDnsSdServiceInfo : global::Android.Net.Wifi.P2p.Nsd.WifiP2pServiceInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiP2pDnsSdServiceInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a Bonjour service information object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Bonjour service information object </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Landroid/net/wifi/p2p/nsd/Wi" +
    "fiP2pDnsSdServiceInfo;", AccessFlags = 9, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/" +
    "String;>;)Landroid/net/wifi/p2p/nsd/WifiP2pDnsSdServiceInfo;")]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pDnsSdServiceInfo NewInstance(string instanceName, string serviceType, global::Java.Util.IMap<string, string> txtMap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pDnsSdServiceInfo);
				}

		}

		/// <summary>
		/// <para>A class for storing service information that is advertised over a Wi-Fi peer-to-peer setup</para><para><para>WifiP2pUpnpServiceInfo </para><simplesectsep></simplesectsep><para>WifiP2pDnsSdServiceInfo </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/nsd/WifiP2pServiceInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/nsd/WifiP2pServiceInfo", AccessFlags = 33)]
		public partial class WifiP2pServiceInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>All service protocol types. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_TYPE_ALL
				/// </java-name>
				[Dot42.DexImport("SERVICE_TYPE_ALL", "I", AccessFlags = 25)]
				public const int SERVICE_TYPE_ALL = 0;
				/// <summary>
				/// <para>DNS based service discovery protocol. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_TYPE_BONJOUR
				/// </java-name>
				[Dot42.DexImport("SERVICE_TYPE_BONJOUR", "I", AccessFlags = 25)]
				public const int SERVICE_TYPE_BONJOUR = 1;
				/// <summary>
				/// <para>UPnP protocol. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_TYPE_UPNP
				/// </java-name>
				[Dot42.DexImport("SERVICE_TYPE_UPNP", "I", AccessFlags = 25)]
				public const int SERVICE_TYPE_UPNP = 2;
				/// <summary>
				/// <para>Vendor Specific protocol </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_TYPE_VENDOR_SPECIFIC
				/// </java-name>
				[Dot42.DexImport("SERVICE_TYPE_VENDOR_SPECIFIC", "I", AccessFlags = 25)]
				public const int SERVICE_TYPE_VENDOR_SPECIFIC = 255;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiP2pServiceInfo() /* MethodBuilder.Create */ 
				{
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

				/// <summary>
				/// <para>Implement the Parcelable interface {} </para>        
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
				/// <para>Implement the Parcelable interface {} </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>A class for creating a Bonjour service discovery request for use with WifiP2pManager#addServiceRequest and WifiP2pManager#removeServiceRequest</para><para>{<para>WifiP2pManager} {</para><simplesectsep></simplesectsep><para>WifiP2pServiceRequest} {</para><simplesectsep></simplesectsep><para>WifiP2pUpnpServiceRequest} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/p2p/nsd/WifiP2pDnsSdServiceRequest
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/p2p/nsd/WifiP2pDnsSdServiceRequest", AccessFlags = 33)]
		public partial class WifiP2pDnsSdServiceRequest : global::Android.Net.Wifi.P2p.Nsd.WifiP2pServiceRequest
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This constructor is only used in newInstance().  </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiP2pDnsSdServiceRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a service discovery request to search all Bonjour services.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>service request for Bonjour. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Landroid/net/wifi/p2p/nsd/WifiP2pDnsSdServiceRequest;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pDnsSdServiceRequest NewInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pDnsSdServiceRequest);
				}

				/// <summary>
				/// <para>Create a service discovery to search for Bonjour services with the specified service type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>service request for DnsSd. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;)Landroid/net/wifi/p2p/nsd/WifiP2pDnsSdServiceRequest;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pDnsSdServiceRequest NewInstance(string serviceType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pDnsSdServiceRequest);
				}

				/// <summary>
				/// <para>Create a service discovery request to get the TXT data from the specified Bonjour service.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>service request for Bonjour. </para>
				/// </returns>
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/lang/String;)Landroid/net/wifi/p2p/nsd/WifiP2pDnsSdServi" +
    "ceRequest;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.P2p.Nsd.WifiP2pDnsSdServiceRequest NewInstance(string instanceName, string serviceType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.P2p.Nsd.WifiP2pDnsSdServiceRequest);
				}

		}

}


