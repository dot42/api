#pragma warning disable 1717
namespace Android.Net.Wifi
{
		/// <java-name>
		/// android/net/wifi/SupplicantState
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/SupplicantState", AccessFlags = 16433, Signature = "Ljava/lang/Enum<Landroid/net/wifi/SupplicantState;>;Landroid/os/Parcelable;")]
		public sealed class SupplicantState
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ASSOCIATED
				/// </java-name>
				[Dot42.DexImport("ASSOCIATED", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState ASSOCIATED;
				/// <java-name>
				/// ASSOCIATING
				/// </java-name>
				[Dot42.DexImport("ASSOCIATING", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState ASSOCIATING;
				/// <java-name>
				/// AUTHENTICATING
				/// </java-name>
				[Dot42.DexImport("AUTHENTICATING", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState AUTHENTICATING;
				/// <java-name>
				/// COMPLETED
				/// </java-name>
				[Dot42.DexImport("COMPLETED", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState COMPLETED;
				/// <java-name>
				/// DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("DISCONNECTED", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState DISCONNECTED;
				/// <java-name>
				/// DORMANT
				/// </java-name>
				[Dot42.DexImport("DORMANT", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState DORMANT;
				/// <java-name>
				/// FOUR_WAY_HANDSHAKE
				/// </java-name>
				[Dot42.DexImport("FOUR_WAY_HANDSHAKE", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState FOUR_WAY_HANDSHAKE;
				/// <java-name>
				/// GROUP_HANDSHAKE
				/// </java-name>
				[Dot42.DexImport("GROUP_HANDSHAKE", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState GROUP_HANDSHAKE;
				/// <java-name>
				/// INACTIVE
				/// </java-name>
				[Dot42.DexImport("INACTIVE", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState INACTIVE;
				/// <java-name>
				/// INTERFACE_DISABLED
				/// </java-name>
				[Dot42.DexImport("INTERFACE_DISABLED", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState INTERFACE_DISABLED;
				/// <java-name>
				/// INVALID
				/// </java-name>
				[Dot42.DexImport("INVALID", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState INVALID;
				/// <java-name>
				/// SCANNING
				/// </java-name>
				[Dot42.DexImport("SCANNING", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState SCANNING;
				/// <java-name>
				/// UNINITIALIZED
				/// </java-name>
				[Dot42.DexImport("UNINITIALIZED", "Landroid/net/wifi/SupplicantState;", AccessFlags = 16409)]
				public static readonly global::Android.Net.Wifi.SupplicantState UNINITIALIZED;
				private SupplicantState() /* TypeBuilder.AddPrivateDefaultCtor */ 
				{
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()[Landroid/net/wifi/SupplicantState;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.SupplicantState[] Values() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.SupplicantState[]);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/net/wifi/SupplicantState;", AccessFlags = 9)]
				public static global::Android.Net.Wifi.SupplicantState ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.SupplicantState);
				}

				/// <java-name>
				/// isValidState
				/// </java-name>
				[Dot42.DexImport("isValidState", "(Landroid/net/wifi/SupplicantState;)Z", AccessFlags = 9)]
				public static bool IsValidState(global::Android.Net.Wifi.SupplicantState supplicantState) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/wifi/WifiInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/WifiInfo", AccessFlags = 33)]
		public partial class WifiInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LINK_SPEED_UNITS
				/// </java-name>
				[Dot42.DexImport("LINK_SPEED_UNITS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LINK_SPEED_UNITS = "Mbps";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSSID
				/// </java-name>
				[Dot42.DexImport("getSSID", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSSID() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getBSSID
				/// </java-name>
				[Dot42.DexImport("getBSSID", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetBSSID() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getRssi
				/// </java-name>
				[Dot42.DexImport("getRssi", "()I", AccessFlags = 1)]
				public virtual int GetRssi() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLinkSpeed
				/// </java-name>
				[Dot42.DexImport("getLinkSpeed", "()I", AccessFlags = 1)]
				public virtual int GetLinkSpeed() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMacAddress
				/// </java-name>
				[Dot42.DexImport("getMacAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMacAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getNetworkId
				/// </java-name>
				[Dot42.DexImport("getNetworkId", "()I", AccessFlags = 1)]
				public virtual int GetNetworkId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSupplicantState
				/// </java-name>
				[Dot42.DexImport("getSupplicantState", "()Landroid/net/wifi/SupplicantState;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.SupplicantState GetSupplicantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.SupplicantState);
				}

				/// <java-name>
				/// getIpAddress
				/// </java-name>
				[Dot42.DexImport("getIpAddress", "()I", AccessFlags = 1)]
				public virtual int GetIpAddress() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getHiddenSSID
				/// </java-name>
				[Dot42.DexImport("getHiddenSSID", "()Z", AccessFlags = 1)]
				public virtual bool GetHiddenSSID() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDetailedStateOf
				/// </java-name>
				[Dot42.DexImport("getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 9)]
				public static global::Android.Net.NetworkInfo.DetailedState GetDetailedStateOf(global::Android.Net.Wifi.SupplicantState supplicantState) /* MethodBuilder.Create */ 
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
				/// getSSID
				/// </java-name>
				public string SSID
				{
				[Dot42.DexImport("getSSID", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSSID(); }
				}

				/// <java-name>
				/// getBSSID
				/// </java-name>
				public string BSSID
				{
				[Dot42.DexImport("getBSSID", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetBSSID(); }
				}

				/// <java-name>
				/// getRssi
				/// </java-name>
				public int Rssi
				{
				[Dot42.DexImport("getRssi", "()I", AccessFlags = 1)]
						get{ return GetRssi(); }
				}

				/// <java-name>
				/// getLinkSpeed
				/// </java-name>
				public int LinkSpeed
				{
				[Dot42.DexImport("getLinkSpeed", "()I", AccessFlags = 1)]
						get{ return GetLinkSpeed(); }
				}

				/// <java-name>
				/// getMacAddress
				/// </java-name>
				public string MacAddress
				{
				[Dot42.DexImport("getMacAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMacAddress(); }
				}

				/// <java-name>
				/// getNetworkId
				/// </java-name>
				public int NetworkId
				{
				[Dot42.DexImport("getNetworkId", "()I", AccessFlags = 1)]
						get{ return GetNetworkId(); }
				}

				/// <java-name>
				/// getSupplicantState
				/// </java-name>
				public global::Android.Net.Wifi.SupplicantState SupplicantState
				{
				[Dot42.DexImport("getSupplicantState", "()Landroid/net/wifi/SupplicantState;", AccessFlags = 1)]
						get{ return GetSupplicantState(); }
				}

				/// <java-name>
				/// getIpAddress
				/// </java-name>
				public int IpAddress
				{
				[Dot42.DexImport("getIpAddress", "()I", AccessFlags = 1)]
						get{ return GetIpAddress(); }
				}

				/// <java-name>
				/// getHiddenSSID
				/// </java-name>
				public bool IsHiddenSSID
				{
				[Dot42.DexImport("getHiddenSSID", "()Z", AccessFlags = 1)]
						get{ return GetHiddenSSID(); }
				}

		}

		/// <java-name>
		/// android/net/wifi/WpsInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/WpsInfo", AccessFlags = 33)]
		public partial class WpsInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PBC
				/// </java-name>
				[Dot42.DexImport("PBC", "I", AccessFlags = 25)]
				public const int PBC = 0;
				/// <java-name>
				/// DISPLAY
				/// </java-name>
				[Dot42.DexImport("DISPLAY", "I", AccessFlags = 25)]
				public const int DISPLAY = 1;
				/// <java-name>
				/// KEYPAD
				/// </java-name>
				[Dot42.DexImport("KEYPAD", "I", AccessFlags = 25)]
				public const int KEYPAD = 2;
				/// <java-name>
				/// LABEL
				/// </java-name>
				[Dot42.DexImport("LABEL", "I", AccessFlags = 25)]
				public const int LABEL = 3;
				/// <java-name>
				/// INVALID
				/// </java-name>
				[Dot42.DexImport("INVALID", "I", AccessFlags = 25)]
				public const int INVALID = 4;
				/// <java-name>
				/// setup
				/// </java-name>
				[Dot42.DexImport("setup", "I", AccessFlags = 1)]
				public int Setup;
				/// <java-name>
				/// pin
				/// </java-name>
				[Dot42.DexImport("pin", "Ljava/lang/String;", AccessFlags = 1)]
				public string Pin;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Net.Wifi.WpsInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WpsInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/net/wifi/WpsInfo;)V", AccessFlags = 1)]
				public WpsInfo(global::Android.Net.Wifi.WpsInfo wpsInfo) /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/wifi/WifiConfiguration
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/WifiConfiguration", AccessFlags = 33)]
		public partial class WifiConfiguration : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// networkId
				/// </java-name>
				[Dot42.DexImport("networkId", "I", AccessFlags = 1)]
				public int NetworkId;
				/// <java-name>
				/// status
				/// </java-name>
				[Dot42.DexImport("status", "I", AccessFlags = 1)]
				public int Status0;
				/// <java-name>
				/// SSID
				/// </java-name>
				[Dot42.DexImport("SSID", "Ljava/lang/String;", AccessFlags = 1)]
				public string SSID;
				/// <java-name>
				/// BSSID
				/// </java-name>
				[Dot42.DexImport("BSSID", "Ljava/lang/String;", AccessFlags = 1)]
				public string BSSID;
				/// <java-name>
				/// preSharedKey
				/// </java-name>
				[Dot42.DexImport("preSharedKey", "Ljava/lang/String;", AccessFlags = 1)]
				public string PreSharedKey;
				/// <java-name>
				/// wepKeys
				/// </java-name>
				[Dot42.DexImport("wepKeys", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] WepKeys;
				/// <java-name>
				/// wepTxKeyIndex
				/// </java-name>
				[Dot42.DexImport("wepTxKeyIndex", "I", AccessFlags = 1)]
				public int WepTxKeyIndex;
				/// <java-name>
				/// priority
				/// </java-name>
				[Dot42.DexImport("priority", "I", AccessFlags = 1)]
				public int Priority;
				/// <java-name>
				/// hiddenSSID
				/// </java-name>
				[Dot42.DexImport("hiddenSSID", "Z", AccessFlags = 1)]
				public bool HiddenSSID;
				/// <java-name>
				/// allowedKeyManagement
				/// </java-name>
				[Dot42.DexImport("allowedKeyManagement", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedKeyManagement;
				/// <java-name>
				/// allowedProtocols
				/// </java-name>
				[Dot42.DexImport("allowedProtocols", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedProtocols;
				/// <java-name>
				/// allowedAuthAlgorithms
				/// </java-name>
				[Dot42.DexImport("allowedAuthAlgorithms", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedAuthAlgorithms;
				/// <java-name>
				/// allowedPairwiseCiphers
				/// </java-name>
				[Dot42.DexImport("allowedPairwiseCiphers", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedPairwiseCiphers;
				/// <java-name>
				/// allowedGroupCiphers
				/// </java-name>
				[Dot42.DexImport("allowedGroupCiphers", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedGroupCiphers;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WifiConfiguration() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/net/wifi/WifiConfiguration$Status
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$Status", AccessFlags = 9)]
				public partial class Status
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CURRENT
						/// </java-name>
						[Dot42.DexImport("CURRENT", "I", AccessFlags = 25)]
						public const int CURRENT = 0;
						/// <java-name>
						/// DISABLED
						/// </java-name>
						[Dot42.DexImport("DISABLED", "I", AccessFlags = 25)]
						public const int DISABLED = 1;
						/// <java-name>
						/// ENABLED
						/// </java-name>
						[Dot42.DexImport("ENABLED", "I", AccessFlags = 25)]
						public const int ENABLED = 2;
						/// <java-name>
						/// strings
						/// </java-name>
						[Dot42.DexImport("strings", "[Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string[] Strings;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Status() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/net/wifi/WifiConfiguration$GroupCipher
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$GroupCipher", AccessFlags = 9)]
				public partial class GroupCipher
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// WEP40
						/// </java-name>
						[Dot42.DexImport("WEP40", "I", AccessFlags = 25)]
						public const int WEP40 = 0;
						/// <java-name>
						/// WEP104
						/// </java-name>
						[Dot42.DexImport("WEP104", "I", AccessFlags = 25)]
						public const int WEP104 = 1;
						/// <java-name>
						/// TKIP
						/// </java-name>
						[Dot42.DexImport("TKIP", "I", AccessFlags = 25)]
						public const int TKIP = 2;
						/// <java-name>
						/// CCMP
						/// </java-name>
						[Dot42.DexImport("CCMP", "I", AccessFlags = 25)]
						public const int CCMP = 3;
						/// <java-name>
						/// varName
						/// </java-name>
						[Dot42.DexImport("varName", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VarName = "group";
						/// <java-name>
						/// strings
						/// </java-name>
						[Dot42.DexImport("strings", "[Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string[] Strings;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal GroupCipher() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/net/wifi/WifiConfiguration$PairwiseCipher
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$PairwiseCipher", AccessFlags = 9)]
				public partial class PairwiseCipher
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NONE
						/// </java-name>
						[Dot42.DexImport("NONE", "I", AccessFlags = 25)]
						public const int NONE = 0;
						/// <java-name>
						/// TKIP
						/// </java-name>
						[Dot42.DexImport("TKIP", "I", AccessFlags = 25)]
						public const int TKIP = 1;
						/// <java-name>
						/// CCMP
						/// </java-name>
						[Dot42.DexImport("CCMP", "I", AccessFlags = 25)]
						public const int CCMP = 2;
						/// <java-name>
						/// varName
						/// </java-name>
						[Dot42.DexImport("varName", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VarName = "pairwise";
						/// <java-name>
						/// strings
						/// </java-name>
						[Dot42.DexImport("strings", "[Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string[] Strings;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal PairwiseCipher() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/net/wifi/WifiConfiguration$AuthAlgorithm
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$AuthAlgorithm", AccessFlags = 9)]
				public partial class AuthAlgorithm
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// OPEN
						/// </java-name>
						[Dot42.DexImport("OPEN", "I", AccessFlags = 25)]
						public const int OPEN = 0;
						/// <java-name>
						/// SHARED
						/// </java-name>
						[Dot42.DexImport("SHARED", "I", AccessFlags = 25)]
						public const int SHARED = 1;
						/// <java-name>
						/// LEAP
						/// </java-name>
						[Dot42.DexImport("LEAP", "I", AccessFlags = 25)]
						public const int LEAP = 2;
						/// <java-name>
						/// varName
						/// </java-name>
						[Dot42.DexImport("varName", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VarName = "auth_alg";
						/// <java-name>
						/// strings
						/// </java-name>
						[Dot42.DexImport("strings", "[Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string[] Strings;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal AuthAlgorithm() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/net/wifi/WifiConfiguration$Protocol
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$Protocol", AccessFlags = 9)]
				public partial class Protocol
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// WPA
						/// </java-name>
						[Dot42.DexImport("WPA", "I", AccessFlags = 25)]
						public const int WPA = 0;
						/// <java-name>
						/// RSN
						/// </java-name>
						[Dot42.DexImport("RSN", "I", AccessFlags = 25)]
						public const int RSN = 1;
						/// <java-name>
						/// varName
						/// </java-name>
						[Dot42.DexImport("varName", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VarName = "proto";
						/// <java-name>
						/// strings
						/// </java-name>
						[Dot42.DexImport("strings", "[Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string[] Strings;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Protocol() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/net/wifi/WifiConfiguration$KeyMgmt
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$KeyMgmt", AccessFlags = 9)]
				public partial class KeyMgmt
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NONE
						/// </java-name>
						[Dot42.DexImport("NONE", "I", AccessFlags = 25)]
						public const int NONE = 0;
						/// <java-name>
						/// WPA_PSK
						/// </java-name>
						[Dot42.DexImport("WPA_PSK", "I", AccessFlags = 25)]
						public const int WPA_PSK = 1;
						/// <java-name>
						/// WPA_EAP
						/// </java-name>
						[Dot42.DexImport("WPA_EAP", "I", AccessFlags = 25)]
						public const int WPA_EAP = 2;
						/// <java-name>
						/// IEEE8021X
						/// </java-name>
						[Dot42.DexImport("IEEE8021X", "I", AccessFlags = 25)]
						public const int IEEE8021X = 3;
						/// <java-name>
						/// varName
						/// </java-name>
						[Dot42.DexImport("varName", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VarName = "key_mgmt";
						/// <java-name>
						/// strings
						/// </java-name>
						[Dot42.DexImport("strings", "[Ljava/lang/String;", AccessFlags = 25)]
						public static readonly string[] Strings;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal KeyMgmt() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/net/wifi/ScanResult
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/ScanResult", AccessFlags = 33)]
		public partial class ScanResult : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SSID
				/// </java-name>
				[Dot42.DexImport("SSID", "Ljava/lang/String;", AccessFlags = 1)]
				public string SSID;
				/// <java-name>
				/// BSSID
				/// </java-name>
				[Dot42.DexImport("BSSID", "Ljava/lang/String;", AccessFlags = 1)]
				public string BSSID;
				/// <java-name>
				/// capabilities
				/// </java-name>
				[Dot42.DexImport("capabilities", "Ljava/lang/String;", AccessFlags = 1)]
				public string Capabilities;
				/// <java-name>
				/// level
				/// </java-name>
				[Dot42.DexImport("level", "I", AccessFlags = 1)]
				public int Level;
				/// <java-name>
				/// frequency
				/// </java-name>
				[Dot42.DexImport("frequency", "I", AccessFlags = 1)]
				public int Frequency;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ScanResult() /* MethodBuilder.Create */ 
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
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/net/wifi/WifiManager
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/WifiManager", AccessFlags = 33)]
		public partial class WifiManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ERROR_AUTHENTICATING
				/// </java-name>
				[Dot42.DexImport("ERROR_AUTHENTICATING", "I", AccessFlags = 25)]
				public const int ERROR_AUTHENTICATING = 1;
				/// <java-name>
				/// WIFI_STATE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_STATE_CHANGED_ACTION = "android.net.wifi.WIFI_STATE_CHANGED";
				/// <java-name>
				/// EXTRA_WIFI_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_STATE = "wifi_state";
				/// <java-name>
				/// EXTRA_PREVIOUS_WIFI_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_WIFI_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_WIFI_STATE = "previous_wifi_state";
				/// <java-name>
				/// WIFI_STATE_DISABLING
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_DISABLING", "I", AccessFlags = 25)]
				public const int WIFI_STATE_DISABLING = 0;
				/// <java-name>
				/// WIFI_STATE_DISABLED
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_DISABLED", "I", AccessFlags = 25)]
				public const int WIFI_STATE_DISABLED = 1;
				/// <java-name>
				/// WIFI_STATE_ENABLING
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_ENABLING", "I", AccessFlags = 25)]
				public const int WIFI_STATE_ENABLING = 2;
				/// <java-name>
				/// WIFI_STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_ENABLED", "I", AccessFlags = 25)]
				public const int WIFI_STATE_ENABLED = 3;
				/// <java-name>
				/// WIFI_STATE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_UNKNOWN", "I", AccessFlags = 25)]
				public const int WIFI_STATE_UNKNOWN = 4;
				/// <java-name>
				/// SUPPLICANT_CONNECTION_CHANGE_ACTION
				/// </java-name>
				[Dot42.DexImport("SUPPLICANT_CONNECTION_CHANGE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUPPLICANT_CONNECTION_CHANGE_ACTION = "android.net.wifi.supplicant.CONNECTION_CHANGE";
				/// <java-name>
				/// EXTRA_SUPPLICANT_CONNECTED
				/// </java-name>
				[Dot42.DexImport("EXTRA_SUPPLICANT_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SUPPLICANT_CONNECTED = "connected";
				/// <java-name>
				/// NETWORK_STATE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("NETWORK_STATE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NETWORK_STATE_CHANGED_ACTION = "android.net.wifi.STATE_CHANGE";
				/// <java-name>
				/// EXTRA_NETWORK_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_NETWORK_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NETWORK_INFO = "networkInfo";
				/// <java-name>
				/// EXTRA_BSSID
				/// </java-name>
				[Dot42.DexImport("EXTRA_BSSID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_BSSID = "bssid";
				/// <java-name>
				/// EXTRA_WIFI_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_INFO = "wifiInfo";
				/// <java-name>
				/// SUPPLICANT_STATE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("SUPPLICANT_STATE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUPPLICANT_STATE_CHANGED_ACTION = "android.net.wifi.supplicant.STATE_CHANGE";
				/// <java-name>
				/// EXTRA_NEW_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_NEW_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NEW_STATE = "newState";
				/// <java-name>
				/// EXTRA_SUPPLICANT_ERROR
				/// </java-name>
				[Dot42.DexImport("EXTRA_SUPPLICANT_ERROR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SUPPLICANT_ERROR = "supplicantError";
				/// <java-name>
				/// SCAN_RESULTS_AVAILABLE_ACTION
				/// </java-name>
				[Dot42.DexImport("SCAN_RESULTS_AVAILABLE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCAN_RESULTS_AVAILABLE_ACTION = "android.net.wifi.SCAN_RESULTS";
				/// <java-name>
				/// RSSI_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("RSSI_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RSSI_CHANGED_ACTION = "android.net.wifi.RSSI_CHANGED";
				/// <java-name>
				/// EXTRA_NEW_RSSI
				/// </java-name>
				[Dot42.DexImport("EXTRA_NEW_RSSI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NEW_RSSI = "newRssi";
				/// <java-name>
				/// NETWORK_IDS_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("NETWORK_IDS_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NETWORK_IDS_CHANGED_ACTION = "android.net.wifi.NETWORK_IDS_CHANGED";
				/// <java-name>
				/// ACTION_PICK_WIFI_NETWORK
				/// </java-name>
				[Dot42.DexImport("ACTION_PICK_WIFI_NETWORK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PICK_WIFI_NETWORK = "android.net.wifi.PICK_WIFI_NETWORK";
				/// <java-name>
				/// WIFI_MODE_FULL
				/// </java-name>
				[Dot42.DexImport("WIFI_MODE_FULL", "I", AccessFlags = 25)]
				public const int WIFI_MODE_FULL = 1;
				/// <java-name>
				/// WIFI_MODE_SCAN_ONLY
				/// </java-name>
				[Dot42.DexImport("WIFI_MODE_SCAN_ONLY", "I", AccessFlags = 25)]
				public const int WIFI_MODE_SCAN_ONLY = 2;
				/// <java-name>
				/// WIFI_MODE_FULL_HIGH_PERF
				/// </java-name>
				[Dot42.DexImport("WIFI_MODE_FULL_HIGH_PERF", "I", AccessFlags = 25)]
				public const int WIFI_MODE_FULL_HIGH_PERF = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConfiguredNetworks
				/// </java-name>
				[Dot42.DexImport("getConfiguredNetworks", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/net/wifi/WifiConfiguration;>;")]
				public virtual global::Java.Util.IList<global::Android.Net.Wifi.WifiConfiguration> GetConfiguredNetworks() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Net.Wifi.WifiConfiguration>);
				}

				/// <java-name>
				/// addNetwork
				/// </java-name>
				[Dot42.DexImport("addNetwork", "(Landroid/net/wifi/WifiConfiguration;)I", AccessFlags = 1)]
				public virtual int AddNetwork(global::Android.Net.Wifi.WifiConfiguration wifiConfiguration) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// updateNetwork
				/// </java-name>
				[Dot42.DexImport("updateNetwork", "(Landroid/net/wifi/WifiConfiguration;)I", AccessFlags = 1)]
				public virtual int UpdateNetwork(global::Android.Net.Wifi.WifiConfiguration wifiConfiguration) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// removeNetwork
				/// </java-name>
				[Dot42.DexImport("removeNetwork", "(I)Z", AccessFlags = 1)]
				public virtual bool RemoveNetwork(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// enableNetwork
				/// </java-name>
				[Dot42.DexImport("enableNetwork", "(IZ)Z", AccessFlags = 1)]
				public virtual bool EnableNetwork(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// disableNetwork
				/// </java-name>
				[Dot42.DexImport("disableNetwork", "(I)Z", AccessFlags = 1)]
				public virtual bool DisableNetwork(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()Z", AccessFlags = 1)]
				public virtual bool Disconnect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reconnect
				/// </java-name>
				[Dot42.DexImport("reconnect", "()Z", AccessFlags = 1)]
				public virtual bool Reconnect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reassociate
				/// </java-name>
				[Dot42.DexImport("reassociate", "()Z", AccessFlags = 1)]
				public virtual bool Reassociate() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pingSupplicant
				/// </java-name>
				[Dot42.DexImport("pingSupplicant", "()Z", AccessFlags = 1)]
				public virtual bool PingSupplicant() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startScan
				/// </java-name>
				[Dot42.DexImport("startScan", "()Z", AccessFlags = 1)]
				public virtual bool StartScan() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getConnectionInfo
				/// </java-name>
				[Dot42.DexImport("getConnectionInfo", "()Landroid/net/wifi/WifiInfo;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.WifiInfo GetConnectionInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.WifiInfo);
				}

				/// <java-name>
				/// getScanResults
				/// </java-name>
				[Dot42.DexImport("getScanResults", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/net/wifi/ScanResult;>;")]
				public virtual global::Java.Util.IList<global::Android.Net.Wifi.ScanResult> GetScanResults() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Net.Wifi.ScanResult>);
				}

				/// <java-name>
				/// saveConfiguration
				/// </java-name>
				[Dot42.DexImport("saveConfiguration", "()Z", AccessFlags = 1)]
				public virtual bool SaveConfiguration() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDhcpInfo
				/// </java-name>
				[Dot42.DexImport("getDhcpInfo", "()Landroid/net/DhcpInfo;", AccessFlags = 1)]
				public virtual global::Android.Net.DhcpInfo GetDhcpInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.DhcpInfo);
				}

				/// <java-name>
				/// setWifiEnabled
				/// </java-name>
				[Dot42.DexImport("setWifiEnabled", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetWifiEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getWifiState
				/// </java-name>
				[Dot42.DexImport("getWifiState", "()I", AccessFlags = 1)]
				public virtual int GetWifiState() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isWifiEnabled
				/// </java-name>
				[Dot42.DexImport("isWifiEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsWifiEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// calculateSignalLevel
				/// </java-name>
				[Dot42.DexImport("calculateSignalLevel", "(II)I", AccessFlags = 9)]
				public static int CalculateSignalLevel(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compareSignalLevel
				/// </java-name>
				[Dot42.DexImport("compareSignalLevel", "(II)I", AccessFlags = 9)]
				public static int CompareSignalLevel(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// createWifiLock
				/// </java-name>
				[Dot42.DexImport("createWifiLock", "(ILjava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.WifiManager.WifiLock CreateWifiLock(int int32, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.WifiManager.WifiLock);
				}

				/// <java-name>
				/// createWifiLock
				/// </java-name>
				[Dot42.DexImport("createWifiLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.WifiManager.WifiLock CreateWifiLock(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.WifiManager.WifiLock);
				}

				/// <java-name>
				/// createMulticastLock
				/// </java-name>
				[Dot42.DexImport("createMulticastLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$MulticastLock;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.WifiManager.MulticastLock CreateMulticastLock(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.WifiManager.MulticastLock);
				}

				/// <java-name>
				/// getConfiguredNetworks
				/// </java-name>
				public global::Java.Util.IList<global::Android.Net.Wifi.WifiConfiguration> ConfiguredNetworks
				{
				[Dot42.DexImport("getConfiguredNetworks", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/net/wifi/WifiConfiguration;>;")]
						get{ return GetConfiguredNetworks(); }
				}

				/// <java-name>
				/// getConnectionInfo
				/// </java-name>
				public global::Android.Net.Wifi.WifiInfo ConnectionInfo
				{
				[Dot42.DexImport("getConnectionInfo", "()Landroid/net/wifi/WifiInfo;", AccessFlags = 1)]
						get{ return GetConnectionInfo(); }
				}

				/// <java-name>
				/// getScanResults
				/// </java-name>
				public global::Java.Util.IList<global::Android.Net.Wifi.ScanResult> ScanResults
				{
				[Dot42.DexImport("getScanResults", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/net/wifi/ScanResult;>;")]
						get{ return GetScanResults(); }
				}

				/// <java-name>
				/// getDhcpInfo
				/// </java-name>
				public global::Android.Net.DhcpInfo DhcpInfo
				{
				[Dot42.DexImport("getDhcpInfo", "()Landroid/net/DhcpInfo;", AccessFlags = 1)]
						get{ return GetDhcpInfo(); }
				}

				/// <java-name>
				/// getWifiState
				/// </java-name>
				public int WifiState
				{
				[Dot42.DexImport("getWifiState", "()I", AccessFlags = 1)]
						get{ return GetWifiState(); }
				}

				/// <java-name>
				/// android/net/wifi/WifiManager$MulticastLock
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiManager$MulticastLock", AccessFlags = 1)]
				public partial class MulticastLock
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/net/wifi/WifiManager;", AccessFlags = 4112)]
						internal readonly global::Android.Net.Wifi.WifiManager This_0;
						[Dot42.DexImport("<init>", "(Landroid/net/wifi/WifiManager;)V", AccessFlags = 0)]
						internal MulticastLock(global::Android.Net.Wifi.WifiManager wifiManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// acquire
						/// </java-name>
						[Dot42.DexImport("acquire", "()V", AccessFlags = 1)]
						public virtual void Acquire() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// release
						/// </java-name>
						[Dot42.DexImport("release", "()V", AccessFlags = 1)]
						public virtual void Release() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setReferenceCounted
						/// </java-name>
						[Dot42.DexImport("setReferenceCounted", "(Z)V", AccessFlags = 1)]
						public virtual void SetReferenceCounted(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isHeld
						/// </java-name>
						[Dot42.DexImport("isHeld", "()Z", AccessFlags = 1)]
						public virtual bool IsHeld() /* MethodBuilder.Create */ 
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
						/// finalize
						/// </java-name>
						[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
						extern ~MulticastLock() /* MethodBuilder.Create */ ;

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal MulticastLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/net/wifi/WifiManager$WifiLock
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiManager$WifiLock", AccessFlags = 1)]
				public partial class WifiLock
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/net/wifi/WifiManager;", AccessFlags = 4112)]
						internal readonly global::Android.Net.Wifi.WifiManager This_0;
						[Dot42.DexImport("<init>", "(Landroid/net/wifi/WifiManager;)V", AccessFlags = 0)]
						internal WifiLock(global::Android.Net.Wifi.WifiManager wifiManager) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// acquire
						/// </java-name>
						[Dot42.DexImport("acquire", "()V", AccessFlags = 1)]
						public virtual void Acquire() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// release
						/// </java-name>
						[Dot42.DexImport("release", "()V", AccessFlags = 1)]
						public virtual void Release() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setReferenceCounted
						/// </java-name>
						[Dot42.DexImport("setReferenceCounted", "(Z)V", AccessFlags = 1)]
						public virtual void SetReferenceCounted(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isHeld
						/// </java-name>
						[Dot42.DexImport("isHeld", "()Z", AccessFlags = 1)]
						public virtual bool IsHeld() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// setWorkSource
						/// </java-name>
						[Dot42.DexImport("setWorkSource", "(Landroid/os/WorkSource;)V", AccessFlags = 1)]
						public virtual void SetWorkSource(global::Android.Os.WorkSource workSource) /* MethodBuilder.Create */ 
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
						/// finalize
						/// </java-name>
						[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
						extern ~WifiLock() /* MethodBuilder.Create */ ;

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal WifiLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

}

