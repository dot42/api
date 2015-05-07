#pragma warning disable 1717
namespace Android.Net.Wifi
{
		/// <summary>
		///  <para>Describes information about a detected access point. In addition to the attributes described here, the supplicant keeps track of  <c>quality </c> , <c>noise </c> , and <c>maxbitrate </c> attributes, but does not currently report them to external clients. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/ScanResult
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/ScanResult", AccessFlags = 33)]
		public partial class ScanResult : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The network name. </para>        
				/// </summary>
				/// <java-name>
				/// SSID
				/// </java-name>
				[Dot42.DexImport("SSID", "Ljava/lang/String;", AccessFlags = 1)]
				public string SSID;
				/// <summary>
				///  <para>The address of the access point. </para>        
				/// </summary>
				/// <java-name>
				/// BSSID
				/// </java-name>
				[Dot42.DexImport("BSSID", "Ljava/lang/String;", AccessFlags = 1)]
				public string BSSID;
				/// <summary>
				///  <para>Describes the authentication, key management, and encryption schemes supported by the access point. </para>        
				/// </summary>
				/// <java-name>
				/// capabilities
				/// </java-name>
				[Dot42.DexImport("capabilities", "Ljava/lang/String;", AccessFlags = 1)]
				public string Capabilities;
				/// <summary>
				///  <para>The detected signal level in dBm. At least those are the units used by the TI driver. </para>        
				/// </summary>
				/// <java-name>
				/// level
				/// </java-name>
				[Dot42.DexImport("level", "I", AccessFlags = 1)]
				public int Level;
				/// <summary>
				///  <para>The frequency in MHz of the channel over which the client is communicating with the access point. </para>        
				/// </summary>
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
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A class representing a configured Wi-Fi network, including the security configuration. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/WifiConfiguration
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/WifiConfiguration", AccessFlags = 33)]
		public partial class WifiConfiguration : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The ID number that the supplicant uses to identify this network configuration entry. This must be passed as an argument to most calls into the supplicant. </para>        
				/// </summary>
				/// <java-name>
				/// networkId
				/// </java-name>
				[Dot42.DexImport("networkId", "I", AccessFlags = 1)]
				public int NetworkId;
				/// <summary>
				///  <para>The current status of this network configuration entry.  <para>Status </para></para>        
				/// </summary>
				/// <java-name>
				/// status
				/// </java-name>
				[Dot42.DexImport("status", "I", AccessFlags = 1)]
				public int Status0;
				/// <summary>
				///  <para>The network's SSID. Can either be an ASCII string, which must be enclosed in double quotation marks (e.g., <c>"MyNetwork" </c> , or a string of hex digits,which are not enclosed in quotes (e.g., <c>01a243f405 </c> ). </para>        
				/// </summary>
				/// <java-name>
				/// SSID
				/// </java-name>
				[Dot42.DexImport("SSID", "Ljava/lang/String;", AccessFlags = 1)]
				public string SSID;
				/// <summary>
				///  <para>When set, this network configuration entry should only be used when associating with the AP having the specified BSSID. The value is a string in the format of an Ethernet MAC address, e.g.,  <code>XX:XX:XX:XX:XX:XX</code> where each  <code>X</code> is a hex digit. </para>        
				/// </summary>
				/// <java-name>
				/// BSSID
				/// </java-name>
				[Dot42.DexImport("BSSID", "Ljava/lang/String;", AccessFlags = 1)]
				public string BSSID;
				/// <summary>
				///  <para>Pre-shared key for use with WPA-PSK. </para> <para>When the value of this key is read, the actual key is not returned, just a "*" if the key has a value, or the null string otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// preSharedKey
				/// </java-name>
				[Dot42.DexImport("preSharedKey", "Ljava/lang/String;", AccessFlags = 1)]
				public string PreSharedKey;
				/// <summary>
				///  <para>Up to four WEP keys. Either an ASCII string enclosed in double quotation marks (e.g., <c>"abcdef" </c> or a string of hex digits (e.g., <c>0102030405 </c> ). </para> <para>When the value of one of these keys is read, the actual key is not returned, just a "*" if the key has a value, or the null string otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// wepKeys
				/// </java-name>
				[Dot42.DexImport("wepKeys", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] WepKeys;
				/// <summary>
				///  <para>Default WEP key index, ranging from 0 to 3. </para>        
				/// </summary>
				/// <java-name>
				/// wepTxKeyIndex
				/// </java-name>
				[Dot42.DexImport("wepTxKeyIndex", "I", AccessFlags = 1)]
				public int WepTxKeyIndex;
				/// <summary>
				///  <para>Priority determines the preference given to a network by <c>wpa_supplicant </c> when choosing an access point with which to associate. </para>        
				/// </summary>
				/// <java-name>
				/// priority
				/// </java-name>
				[Dot42.DexImport("priority", "I", AccessFlags = 1)]
				public int Priority;
				/// <summary>
				///  <para>This is a network that does not broadcast its SSID, so an SSID-specific probe request must be used for scans. </para>        
				/// </summary>
				/// <java-name>
				/// hiddenSSID
				/// </java-name>
				[Dot42.DexImport("hiddenSSID", "Z", AccessFlags = 1)]
				public bool HiddenSSID;
				/// <summary>
				///  <para>The set of key management protocols supported by this configuration. See KeyMgmt for descriptions of the values. Defaults to WPA-PSK WPA-EAP. </para>        
				/// </summary>
				/// <java-name>
				/// allowedKeyManagement
				/// </java-name>
				[Dot42.DexImport("allowedKeyManagement", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedKeyManagement;
				/// <summary>
				///  <para>The set of security protocols supported by this configuration. See Protocol for descriptions of the values. Defaults to WPA RSN. </para>        
				/// </summary>
				/// <java-name>
				/// allowedProtocols
				/// </java-name>
				[Dot42.DexImport("allowedProtocols", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedProtocols;
				/// <summary>
				///  <para>The set of authentication protocols supported by this configuration. See AuthAlgorithm for descriptions of the values. Defaults to automatic selection. </para>        
				/// </summary>
				/// <java-name>
				/// allowedAuthAlgorithms
				/// </java-name>
				[Dot42.DexImport("allowedAuthAlgorithms", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedAuthAlgorithms;
				/// <summary>
				///  <para>The set of pairwise ciphers for WPA supported by this configuration. See PairwiseCipher for descriptions of the values. Defaults to CCMP TKIP. </para>        
				/// </summary>
				/// <java-name>
				/// allowedPairwiseCiphers
				/// </java-name>
				[Dot42.DexImport("allowedPairwiseCiphers", "Ljava/util/BitSet;", AccessFlags = 1)]
				public global::Java.Util.BitSet AllowedPairwiseCiphers;
				/// <summary>
				///  <para>The set of group ciphers supported by this configuration. See GroupCipher for descriptions of the values. Defaults to CCMP TKIP WEP104 WEP40. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Possible status of a network configuration. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/WifiConfiguration$Status
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$Status", AccessFlags = 9)]
				public partial class Status
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>this is the network we are currently connected to </para>        
						/// </summary>
						/// <java-name>
						/// CURRENT
						/// </java-name>
						[Dot42.DexImport("CURRENT", "I", AccessFlags = 25)]
						public const int CURRENT = 0;
						/// <summary>
						///  <para>supplicant will not attempt to use this network </para>        
						/// </summary>
						/// <java-name>
						/// DISABLED
						/// </java-name>
						[Dot42.DexImport("DISABLED", "I", AccessFlags = 25)]
						public const int DISABLED = 1;
						/// <summary>
						///  <para>supplicant will consider this network available for association </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Recognized group ciphers.  <pre>
				/// CCMP = AES in Counter mode with CBC-MAC [RFC 3610, IEEE 802.11i/D7.0]
				/// TKIP = Temporal Key Integrity Protocol [IEEE 802.11i/D7.0]
				/// WEP104 = WEP (Wired Equivalent Privacy) with 104-bit key
				/// WEP40 = WEP (Wired Equivalent Privacy) with 40-bit key (original 802.11)
				/// </pre> </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/WifiConfiguration$GroupCipher
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$GroupCipher", AccessFlags = 9)]
				public partial class GroupCipher
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>WEP40 = WEP (Wired Equivalent Privacy) with 40-bit key (original 802.11) </para>        
						/// </summary>
						/// <java-name>
						/// WEP40
						/// </java-name>
						[Dot42.DexImport("WEP40", "I", AccessFlags = 25)]
						public const int WEP40 = 0;
						/// <summary>
						///  <para>WEP104 = WEP (Wired Equivalent Privacy) with 104-bit key </para>        
						/// </summary>
						/// <java-name>
						/// WEP104
						/// </java-name>
						[Dot42.DexImport("WEP104", "I", AccessFlags = 25)]
						public const int WEP104 = 1;
						/// <summary>
						///  <para>Temporal Key Integrity Protocol [IEEE 802.11i/D7.0] </para>        
						/// </summary>
						/// <java-name>
						/// TKIP
						/// </java-name>
						[Dot42.DexImport("TKIP", "I", AccessFlags = 25)]
						public const int TKIP = 2;
						/// <summary>
						///  <para>AES in Counter mode with CBC-MAC [RFC 3610, IEEE 802.11i/D7.0] </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Recognized pairwise ciphers for WPA. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/WifiConfiguration$PairwiseCipher
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$PairwiseCipher", AccessFlags = 9)]
				public partial class PairwiseCipher
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Use only Group keys (deprecated) </para>        
						/// </summary>
						/// <java-name>
						/// NONE
						/// </java-name>
						[Dot42.DexImport("NONE", "I", AccessFlags = 25)]
						public const int NONE = 0;
						/// <summary>
						///  <para>Temporal Key Integrity Protocol [IEEE 802.11i/D7.0] </para>        
						/// </summary>
						/// <java-name>
						/// TKIP
						/// </java-name>
						[Dot42.DexImport("TKIP", "I", AccessFlags = 25)]
						public const int TKIP = 1;
						/// <summary>
						///  <para>AES in Counter mode with CBC-MAC [RFC 3610, IEEE 802.11i/D7.0] </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Recognized IEEE 802.11 authentication algorithms. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/WifiConfiguration$AuthAlgorithm
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$AuthAlgorithm", AccessFlags = 9)]
				public partial class AuthAlgorithm
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Open System authentication (required for WPA/WPA2) </para>        
						/// </summary>
						/// <java-name>
						/// OPEN
						/// </java-name>
						[Dot42.DexImport("OPEN", "I", AccessFlags = 25)]
						public const int OPEN = 0;
						/// <summary>
						///  <para>Shared Key authentication (requires static WEP keys) </para>        
						/// </summary>
						/// <java-name>
						/// SHARED
						/// </java-name>
						[Dot42.DexImport("SHARED", "I", AccessFlags = 25)]
						public const int SHARED = 1;
						/// <summary>
						///  <para>LEAP/Network EAP (only used with LEAP) </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Recognized security protocols. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/WifiConfiguration$Protocol
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$Protocol", AccessFlags = 9)]
				public partial class Protocol
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>WPA/IEEE 802.11i/D3.0 </para>        
						/// </summary>
						/// <java-name>
						/// WPA
						/// </java-name>
						[Dot42.DexImport("WPA", "I", AccessFlags = 25)]
						public const int WPA = 0;
						/// <summary>
						///  <para>WPA2/IEEE 802.11i </para>        
						/// </summary>
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

				/// <summary>
				///  <para>Recognized key management schemes. </para>    
				/// </summary>
				/// <java-name>
				/// android/net/wifi/WifiConfiguration$KeyMgmt
				/// </java-name>
				[Dot42.DexImport("android/net/wifi/WifiConfiguration$KeyMgmt", AccessFlags = 9)]
				public partial class KeyMgmt
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>WPA is not used; plaintext or static WEP could be used. </para>        
						/// </summary>
						/// <java-name>
						/// NONE
						/// </java-name>
						[Dot42.DexImport("NONE", "I", AccessFlags = 25)]
						public const int NONE = 0;
						/// <summary>
						///  <para>WPA pre-shared key (requires <c>preSharedKey </c> to be specified). </para>        
						/// </summary>
						/// <java-name>
						/// WPA_PSK
						/// </java-name>
						[Dot42.DexImport("WPA_PSK", "I", AccessFlags = 25)]
						public const int WPA_PSK = 1;
						/// <summary>
						///  <para>WPA using EAP authentication. Generally used with an external authentication server. </para>        
						/// </summary>
						/// <java-name>
						/// WPA_EAP
						/// </java-name>
						[Dot42.DexImport("WPA_EAP", "I", AccessFlags = 25)]
						public const int WPA_EAP = 2;
						/// <summary>
						///  <para>IEEE 802.1X using EAP authentication and (optionally) dynamically generated WEP keys. </para>        
						/// </summary>
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

		/// <summary>
		///  <para>Describes the state of any Wifi connection that is active or is in the process of being set up. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/WifiInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/WifiInfo", AccessFlags = 33)]
		public partial class WifiInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Link speed in Mbps </para>        
				/// </summary>
				/// <java-name>
				/// LINK_SPEED_UNITS
				/// </java-name>
				[Dot42.DexImport("LINK_SPEED_UNITS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string LINK_SPEED_UNITS = "Mbps";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Map a supplicant state into a fine-grained network connectivity state. </para>        
				/// </summary>
				/// <returns>
				///  <para>the corresponding DetailedState </para>
				/// </returns>
				/// <java-name>
				/// getDetailedStateOf
				/// </java-name>
				[Dot42.DexImport("getDetailedStateOf", "(Landroid/net/wifi/SupplicantState;)Landroid/net/NetworkInfo$DetailedState;", AccessFlags = 9)]
				public static global::Android.Net.NetworkInfo.DetailedState GetDetailedStateOf(global::Android.Net.Wifi.SupplicantState suppState) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the service set identifier (SSID) of the current 802.11 network. If the SSID can be decoded as UTF-8, it will be returned surrounded by double quotation marks. Otherwise, it is returned as a string of hex digits. The SSID may be <c>null </c> if there is no network currently connected. </para>        
				/// </summary>
				/// <returns>
				///  <para>the SSID </para>
				/// </returns>
				/// <java-name>
				/// getSSID
				/// </java-name>
				public virtual string SSID
				{
						[Dot42.DexImport("getSSID", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Return the basic service set identifier (BSSID) of the current access point. The BSSID may be <c>null </c> if there is no network currently connected. </para>        
				/// </summary>
				/// <returns>
				///  <para>the BSSID, in the form of a six-byte MAC address: <c>XX:XX:XX:XX:XX:XX </c> </para>
				/// </returns>
				/// <java-name>
				/// getBSSID
				/// </java-name>
				public virtual string BSSID
				{
						[Dot42.DexImport("getBSSID", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the received signal strength indicator of the current 802.11 network. </para> <para> <b>This is not normalized, but should be!</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the RSSI, in the range ??? to ??? </para>
				/// </returns>
				/// <java-name>
				/// getRssi
				/// </java-name>
				public virtual int Rssi
				{
						[Dot42.DexImport("getRssi", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the current link speed in LINK_SPEED_UNITS.  <para>LINK_SPEED_UNITS </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the link speed. </para>
				/// </returns>
				/// <java-name>
				/// getLinkSpeed
				/// </java-name>
				public virtual int LinkSpeed
				{
						[Dot42.DexImport("getLinkSpeed", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMacAddress
				/// </java-name>
				public virtual string MacAddress
				{
						[Dot42.DexImport("getMacAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Each configured network has a unique small integer ID, used to identify the network when performing operations on the supplicant. This method returns the ID for the currently connected network. </para>        
				/// </summary>
				/// <returns>
				///  <para>the network ID, or -1 if there is no currently connected network </para>
				/// </returns>
				/// <java-name>
				/// getNetworkId
				/// </java-name>
				public virtual int NetworkId
				{
						[Dot42.DexImport("getNetworkId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the detailed state of the supplicant's negotiation with an access point, in the form of a SupplicantState object. </para>        
				/// </summary>
				/// <returns>
				///  <para>the current SupplicantState </para>
				/// </returns>
				/// <java-name>
				/// getSupplicantState
				/// </java-name>
				public virtual global::Android.Net.Wifi.SupplicantState SupplicantState
				{
						[Dot42.DexImport("getSupplicantState", "()Landroid/net/wifi/SupplicantState;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Wifi.SupplicantState); }
				}

				/// <java-name>
				/// getIpAddress
				/// </java-name>
				public virtual int IpAddress
				{
						[Dot42.DexImport("getIpAddress", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this network does not broadcast its SSID, so an SSID-specific probe request must be used for scans. </para>
				/// </returns>
				/// <java-name>
				/// getHiddenSSID
				/// </java-name>
				public virtual bool HiddenSSID
				{
						[Dot42.DexImport("getHiddenSSID", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>This class provides the primary API for managing all aspects of Wi-Fi connectivity. Get an instance of this class by calling Context.getSystemService(Context.WIFI_SERVICE).</para> <para>It deals with several categories of items:  <ul> <li> <para>The list of configured networks. The list can be viewed and updated, and attributes of individual entries can be modified. </para></li> <li> <para>The currently active Wi-Fi network, if any. Connectivity can be established or torn down, and dynamic information about the state of the network can be queried. </para></li> <li> <para>Results of access point scans, containing enough information to make decisions about what access point to connect to. </para></li> <li> <para>It defines the names of various Intent actions that are broadcast upon any sort of change in Wi-Fi state. </para></li></ul>This is the API to use when performing Wi-Fi specific operations. To perform operations that pertain to network connectivity at an abstract level, use android.net.ConnectivityManager. </para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/WifiManager
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/WifiManager", AccessFlags = 33)]
		public partial class WifiManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The error code if there was a problem authenticating. </para>        
				/// </summary>
				/// <java-name>
				/// ERROR_AUTHENTICATING
				/// </java-name>
				[Dot42.DexImport("ERROR_AUTHENTICATING", "I", AccessFlags = 25)]
				public const int ERROR_AUTHENTICATING = 1;
				/// <summary>
				///  <para>Broadcast intent action indicating that Wi-Fi has been enabled, disabled, enabling, disabling, or unknown. One extra provides this state as an int. Another extra provides the previous state, if available.</para> <para> <para>EXTRA_WIFI_STATE </para> <para>EXTRA_PREVIOUS_WIFI_STATE </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_STATE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WIFI_STATE_CHANGED_ACTION = "android.net.wifi.WIFI_STATE_CHANGED";
				/// <summary>
				///  <para>The lookup key for an int that indicates whether Wi-Fi is enabled, disabled, enabling, disabling, or unknown. Retrieve it with android.content.Intent#getIntExtra(String,int).</para> <para> <para>WIFI_STATE_DISABLED </para> <para>WIFI_STATE_DISABLING </para> <para>WIFI_STATE_ENABLED </para> <para>WIFI_STATE_ENABLING </para> <para>WIFI_STATE_UNKNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_WIFI_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_STATE = "wifi_state";
				/// <summary>
				///  <para>The previous Wi-Fi state.</para> <para> <para>EXTRA_WIFI_STATE </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PREVIOUS_WIFI_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_WIFI_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_WIFI_STATE = "previous_wifi_state";
				/// <summary>
				///  <para>Wi-Fi is currently being disabled. The state will change to WIFI_STATE_DISABLED if it finishes successfully.</para> <para> <para>WIFI_STATE_CHANGED_ACTION </para> <para>getWifiState() </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_STATE_DISABLING
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_DISABLING", "I", AccessFlags = 25)]
				public const int WIFI_STATE_DISABLING = 0;
				/// <summary>
				///  <para>Wi-Fi is disabled.</para> <para> <para>WIFI_STATE_CHANGED_ACTION </para> <para>getWifiState() </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_STATE_DISABLED
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_DISABLED", "I", AccessFlags = 25)]
				public const int WIFI_STATE_DISABLED = 1;
				/// <summary>
				///  <para>Wi-Fi is currently being enabled. The state will change to WIFI_STATE_ENABLED if it finishes successfully.</para> <para> <para>WIFI_STATE_CHANGED_ACTION </para> <para>getWifiState() </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_STATE_ENABLING
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_ENABLING", "I", AccessFlags = 25)]
				public const int WIFI_STATE_ENABLING = 2;
				/// <summary>
				///  <para>Wi-Fi is enabled.</para> <para> <para>WIFI_STATE_CHANGED_ACTION </para> <para>getWifiState() </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_STATE_ENABLED
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_ENABLED", "I", AccessFlags = 25)]
				public const int WIFI_STATE_ENABLED = 3;
				/// <summary>
				///  <para>Wi-Fi is in an unknown state. This state will occur when an error happens while enabling or disabling.</para> <para> <para>WIFI_STATE_CHANGED_ACTION </para> <para>getWifiState() </para></para>        
				/// </summary>
				/// <java-name>
				/// WIFI_STATE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("WIFI_STATE_UNKNOWN", "I", AccessFlags = 25)]
				public const int WIFI_STATE_UNKNOWN = 4;
				/// <summary>
				///  <para>Broadcast intent action indicating that a connection to the supplicant has been established (and it is now possible to perform Wi-Fi operations) or the connection to the supplicant has been lost. One extra provides the connection state as a boolean, where <c>true </c> means CONNECTED.  <para>EXTRA_SUPPLICANT_CONNECTED </para></para>        
				/// </summary>
				/// <java-name>
				/// SUPPLICANT_CONNECTION_CHANGE_ACTION
				/// </java-name>
				[Dot42.DexImport("SUPPLICANT_CONNECTION_CHANGE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUPPLICANT_CONNECTION_CHANGE_ACTION = "android.net.wifi.supplicant.CONNECTION_CHANGE";
				/// <summary>
				///  <para>The lookup key for a boolean that indicates whether a connection to the supplicant daemon has been gained or lost. <c>true </c> means a connection now exists. Retrieve it with android.content.Intent#getBooleanExtra(String,boolean). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SUPPLICANT_CONNECTED
				/// </java-name>
				[Dot42.DexImport("EXTRA_SUPPLICANT_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SUPPLICANT_CONNECTED = "connected";
				/// <summary>
				///  <para>Broadcast intent action indicating that the state of Wi-Fi connectivity has changed. One extra provides the new state in the form of a android.net.NetworkInfo object. If the new state is CONNECTED, additional extras may provide the BSSID and WifiInfo of the access point. as a <c>String </c> .  <para>EXTRA_NETWORK_INFO </para> <para>EXTRA_BSSID </para> <para>EXTRA_WIFI_INFO </para></para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_STATE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("NETWORK_STATE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NETWORK_STATE_CHANGED_ACTION = "android.net.wifi.STATE_CHANGE";
				/// <summary>
				///  <para>The lookup key for a android.net.NetworkInfo object associated with the Wi-Fi network. Retrieve with android.content.Intent#getParcelableExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NETWORK_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_NETWORK_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NETWORK_INFO = "networkInfo";
				/// <summary>
				///  <para>The lookup key for a String giving the BSSID of the access point to which we are connected. Only present when the new state is CONNECTED. Retrieve with android.content.Intent#getStringExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_BSSID
				/// </java-name>
				[Dot42.DexImport("EXTRA_BSSID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_BSSID = "bssid";
				/// <summary>
				///  <para>The lookup key for a android.net.wifi.WifiInfo object giving the information about the access point to which we are connected. Only present when the new state is CONNECTED. Retrieve with android.content.Intent#getParcelableExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_WIFI_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_WIFI_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_WIFI_INFO = "wifiInfo";
				/// <summary>
				///  <para>Broadcast intent action indicating that the state of establishing a connection to an access point has changed.One extra provides the new SupplicantState. Note that the supplicant state is Wi-Fi specific, and is not generally the most useful thing to look at if you are just interested in the overall state of connectivity.  <para>EXTRA_NEW_STATE </para> <para>EXTRA_SUPPLICANT_ERROR </para></para>        
				/// </summary>
				/// <java-name>
				/// SUPPLICANT_STATE_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("SUPPLICANT_STATE_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUPPLICANT_STATE_CHANGED_ACTION = "android.net.wifi.supplicant.STATE_CHANGE";
				/// <summary>
				///  <para>The lookup key for a SupplicantState describing the new state Retrieve with android.content.Intent#getParcelableExtra(String). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NEW_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_NEW_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NEW_STATE = "newState";
				/// <summary>
				///  <para>The lookup key for a SupplicantState describing the supplicant error code if any Retrieve with android.content.Intent#getIntExtra(String, int).  <para>ERROR_AUTHENTICATING </para></para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SUPPLICANT_ERROR
				/// </java-name>
				[Dot42.DexImport("EXTRA_SUPPLICANT_ERROR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SUPPLICANT_ERROR = "supplicantError";
				/// <summary>
				///  <para>An access point scan has completed, and results are available from the supplicant. Call getScanResults() to obtain the results. </para>        
				/// </summary>
				/// <java-name>
				/// SCAN_RESULTS_AVAILABLE_ACTION
				/// </java-name>
				[Dot42.DexImport("SCAN_RESULTS_AVAILABLE_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SCAN_RESULTS_AVAILABLE_ACTION = "android.net.wifi.SCAN_RESULTS";
				/// <summary>
				///  <para>The RSSI (signal strength) has changed.  <para>EXTRA_NEW_RSSI </para></para>        
				/// </summary>
				/// <java-name>
				/// RSSI_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("RSSI_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RSSI_CHANGED_ACTION = "android.net.wifi.RSSI_CHANGED";
				/// <summary>
				///  <para>The lookup key for an <c>int </c> giving the new RSSI in dBm. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NEW_RSSI
				/// </java-name>
				[Dot42.DexImport("EXTRA_NEW_RSSI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NEW_RSSI = "newRssi";
				/// <summary>
				///  <para>The network IDs of the configured networks could have changed. </para>        
				/// </summary>
				/// <java-name>
				/// NETWORK_IDS_CHANGED_ACTION
				/// </java-name>
				[Dot42.DexImport("NETWORK_IDS_CHANGED_ACTION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NETWORK_IDS_CHANGED_ACTION = "android.net.wifi.NETWORK_IDS_CHANGED";
				/// <summary>
				///  <para>Activity Action: Pick a Wi-Fi network to connect to. </para> <para>Input: Nothing. </para> <para>Output: Nothing. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PICK_WIFI_NETWORK
				/// </java-name>
				[Dot42.DexImport("ACTION_PICK_WIFI_NETWORK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PICK_WIFI_NETWORK = "android.net.wifi.PICK_WIFI_NETWORK";
				/// <summary>
				///  <para>In this Wi-Fi lock mode, Wi-Fi will be kept active, and will behave normally, i.e., it will attempt to automatically establish a connection to a remembered access point that is within range, and will do periodic scans if there are remembered access points but none are in range. </para>        
				/// </summary>
				/// <java-name>
				/// WIFI_MODE_FULL
				/// </java-name>
				[Dot42.DexImport("WIFI_MODE_FULL", "I", AccessFlags = 25)]
				public const int WIFI_MODE_FULL = 1;
				/// <summary>
				///  <para>In this Wi-Fi lock mode, Wi-Fi will be kept active, but the only operation that will be supported is initiation of scans, and the subsequent reporting of scan results. No attempts will be made to automatically connect to remembered access points, nor will periodic scans be automatically performed looking for remembered access points. Scans must be explicitly requested by an application in this mode. </para>        
				/// </summary>
				/// <java-name>
				/// WIFI_MODE_SCAN_ONLY
				/// </java-name>
				[Dot42.DexImport("WIFI_MODE_SCAN_ONLY", "I", AccessFlags = 25)]
				public const int WIFI_MODE_SCAN_ONLY = 2;
				/// <summary>
				///  <para>In this Wi-Fi lock mode, Wi-Fi will be kept active as in mode WIFI_MODE_FULL but it operates at high performance with minimum packet loss and low packet latency even when the device screen is off. This mode will consume more power and hence should be used only when there is a need for such an active connection. </para> <para>An example use case is when a voice connection needs to be kept active even after the device screen goes off. Holding the regular WIFI_MODE_FULL lock will keep the wifi connection active, but the connection can be lossy. Holding a WIFI_MODE_FULL_HIGH_PERF lock for the duration of the voice call will improve the call quality. </para> <para>When there is no support from the hardware, this lock mode will have the same behavior as WIFI_MODE_FULL </para>        
				/// </summary>
				/// <java-name>
				/// WIFI_MODE_FULL_HIGH_PERF
				/// </java-name>
				[Dot42.DexImport("WIFI_MODE_FULL_HIGH_PERF", "I", AccessFlags = 25)]
				public const int WIFI_MODE_FULL_HIGH_PERF = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal WifiManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a new network description to the set of configured networks. The <c>networkId </c> field of the supplied configuration object is ignored. </para> <para>The new network will be marked DISABLED by default. To enable it, called enableNetwork.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the ID of the newly created network description. This is used in other operations to specified the network to be acted upon. Returns <c>-1 </c> on failure. </para>
				/// </returns>
				/// <java-name>
				/// addNetwork
				/// </java-name>
				[Dot42.DexImport("addNetwork", "(Landroid/net/wifi/WifiConfiguration;)I", AccessFlags = 1)]
				public virtual int AddNetwork(global::Android.Net.Wifi.WifiConfiguration config) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Update the network description of an existing configured network.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the <c>networkId </c> of the supplied  <c>WifiConfiguration </c> on success.  <br></br> Returns <c>-1 </c> on failure, including when the <c>networkId </c> field of the <c>WifiConfiguration </c> does not refer to an existing network. </para>
				/// </returns>
				/// <java-name>
				/// updateNetwork
				/// </java-name>
				[Dot42.DexImport("updateNetwork", "(Landroid/net/wifi/WifiConfiguration;)I", AccessFlags = 1)]
				public virtual int UpdateNetwork(global::Android.Net.Wifi.WifiConfiguration config) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Remove the specified network from the list of configured networks. This may result in the asynchronous delivery of state change events. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation succeeded </para>
				/// </returns>
				/// <java-name>
				/// removeNetwork
				/// </java-name>
				[Dot42.DexImport("removeNetwork", "(I)Z", AccessFlags = 1)]
				public virtual bool RemoveNetwork(int netId) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Allow a previously configured network to be associated with. If  <code>disableOthers</code> is true, then all other configured networks are disabled, and an attempt to connect to the selected network is initiated. This may result in the asynchronous delivery of state change events. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation succeeded </para>
				/// </returns>
				/// <java-name>
				/// enableNetwork
				/// </java-name>
				[Dot42.DexImport("enableNetwork", "(IZ)Z", AccessFlags = 1)]
				public virtual bool EnableNetwork(int netId, bool disableOthers) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Disable a configured network. The specified network will not be a candidate for associating. This may result in the asynchronous delivery of state change events. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation succeeded </para>
				/// </returns>
				/// <java-name>
				/// disableNetwork
				/// </java-name>
				[Dot42.DexImport("disableNetwork", "(I)Z", AccessFlags = 1)]
				public virtual bool DisableNetwork(int netId) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Disassociate from the currently active access point. This may result in the asynchronous delivery of state change events. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation succeeded </para>
				/// </returns>
				/// <java-name>
				/// disconnect
				/// </java-name>
				[Dot42.DexImport("disconnect", "()Z", AccessFlags = 1)]
				public virtual bool Disconnect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reconnect to the currently active access point, if we are currently disconnected. This may result in the asynchronous delivery of state change events. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation succeeded </para>
				/// </returns>
				/// <java-name>
				/// reconnect
				/// </java-name>
				[Dot42.DexImport("reconnect", "()Z", AccessFlags = 1)]
				public virtual bool Reconnect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Reconnect to the currently active access point, even if we are already connected. This may result in the asynchronous delivery of state change events. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation succeeded </para>
				/// </returns>
				/// <java-name>
				/// reassociate
				/// </java-name>
				[Dot42.DexImport("reassociate", "()Z", AccessFlags = 1)]
				public virtual bool Reassociate() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Check that the supplicant daemon is responding to requests. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if we were able to communicate with the supplicant and it returned the expected response to the PING message. </para>
				/// </returns>
				/// <java-name>
				/// pingSupplicant
				/// </java-name>
				[Dot42.DexImport("pingSupplicant", "()Z", AccessFlags = 1)]
				public virtual bool PingSupplicant() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Request a scan for access points. Returns immediately. The availability of the results is made known later by means of an asynchronous event sent on completion of the scan. </para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation succeeded, i.e., the scan was initiated </para>
				/// </returns>
				/// <java-name>
				/// startScan
				/// </java-name>
				[Dot42.DexImport("startScan", "()Z", AccessFlags = 1)]
				public virtual bool StartScan() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Tell the supplicant to persist the current list of configured networks. </para> <para>Note: It is possible for this method to change the network IDs of existing networks. You should assume the network IDs can be different after calling this method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the operation succeeded </para>
				/// </returns>
				/// <java-name>
				/// saveConfiguration
				/// </java-name>
				[Dot42.DexImport("saveConfiguration", "()Z", AccessFlags = 1)]
				public virtual bool SaveConfiguration() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Enable or disable Wi-Fi. </para>        
				/// </summary>
				/// <java-name>
				/// setWifiEnabled
				/// </java-name>
				[Dot42.DexImport("setWifiEnabled", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetWifiEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Calculates the level of the signal. This should be used any time a signal is being shown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A level of the signal, given in the range of 0 to numLevels-1 (both inclusive). </para>
				/// </returns>
				/// <java-name>
				/// calculateSignalLevel
				/// </java-name>
				[Dot42.DexImport("calculateSignalLevel", "(II)I", AccessFlags = 9)]
				public static int CalculateSignalLevel(int rssi, int numLevels) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compares two signal strengths.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns &lt;0 if the first signal is weaker than the second signal, 0 if the two signals have the same strength, and &gt;0 if the first signal is stronger than the second signal. </para>
				/// </returns>
				/// <java-name>
				/// compareSignalLevel
				/// </java-name>
				[Dot42.DexImport("compareSignalLevel", "(II)I", AccessFlags = 9)]
				public static int CompareSignalLevel(int rssiA, int rssiB) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Creates a new WifiLock.</para> <para> <para>WifiLock </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new, unacquired WifiLock with the given tag.</para>
				/// </returns>
				/// <java-name>
				/// createWifiLock
				/// </java-name>
				[Dot42.DexImport("createWifiLock", "(ILjava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.WifiManager.WifiLock CreateWifiLock(int lockType, string tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.WifiManager.WifiLock);
				}

				/// <summary>
				///  <para>Creates a new WifiLock.</para> <para> <para>WifiLock </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new, unacquired WifiLock with the given tag.</para>
				/// </returns>
				/// <java-name>
				/// createWifiLock
				/// </java-name>
				[Dot42.DexImport("createWifiLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$WifiLock;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.WifiManager.WifiLock CreateWifiLock(string tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.WifiManager.WifiLock);
				}

				/// <summary>
				///  <para>Create a new MulticastLock</para> <para> <para>MulticastLock </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new, unacquired MulticastLock with the given tag.</para>
				/// </returns>
				/// <java-name>
				/// createMulticastLock
				/// </java-name>
				[Dot42.DexImport("createMulticastLock", "(Ljava/lang/String;)Landroid/net/wifi/WifiManager$MulticastLock;", AccessFlags = 1)]
				public virtual global::Android.Net.Wifi.WifiManager.MulticastLock CreateMulticastLock(string tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Wifi.WifiManager.MulticastLock);
				}

				/// <summary>
				///  <para>Return a list of all the networks configured in the supplicant. Not all fields of WifiConfiguration are returned. Only the following fields are filled in:  <ul> <li> <para>networkId </para></li> <li> <para>SSID </para></li> <li> <para>BSSID </para></li> <li> <para>priority </para></li> <li> <para>allowedProtocols </para></li> <li> <para>allowedKeyManagement </para></li> <li> <para>allowedAuthAlgorithms </para></li> <li> <para>allowedPairwiseCiphers </para></li> <li> <para>allowedGroupCiphers </para></li></ul></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of network configurations in the form of a list of WifiConfiguration objects. Upon failure to fetch or when when Wi-Fi is turned off, it can be null. </para>
				/// </returns>
				/// <java-name>
				/// getConfiguredNetworks
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Net.Wifi.WifiConfiguration> ConfiguredNetworks
				{
						[Dot42.DexImport("getConfiguredNetworks", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/net/wifi/WifiConfiguration;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Net.Wifi.WifiConfiguration>); }
				}

				/// <summary>
				///  <para>Return dynamic information about the current Wi-Fi connection, if any is active. </para>        
				/// </summary>
				/// <returns>
				///  <para>the Wi-Fi information, contained in WifiInfo. </para>
				/// </returns>
				/// <java-name>
				/// getConnectionInfo
				/// </java-name>
				public virtual global::Android.Net.Wifi.WifiInfo ConnectionInfo
				{
						[Dot42.DexImport("getConnectionInfo", "()Landroid/net/wifi/WifiInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Wifi.WifiInfo); }
				}

				/// <summary>
				///  <para>Return the results of the latest access point scan. </para>        
				/// </summary>
				/// <returns>
				///  <para>the list of access points found in the most recent scan. </para>
				/// </returns>
				/// <java-name>
				/// getScanResults
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Net.Wifi.ScanResult> ScanResults
				{
						[Dot42.DexImport("getScanResults", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/net/wifi/ScanResult;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Net.Wifi.ScanResult>); }
				}

				/// <summary>
				///  <para>Return the DHCP-assigned addresses from the last successful DHCP request, if any. </para>        
				/// </summary>
				/// <returns>
				///  <para>the DHCP information </para>
				/// </returns>
				/// <java-name>
				/// getDhcpInfo
				/// </java-name>
				public virtual global::Android.Net.DhcpInfo DhcpInfo
				{
						[Dot42.DexImport("getDhcpInfo", "()Landroid/net/DhcpInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Net.DhcpInfo); }
				}

				/// <summary>
				///  <para>Gets the Wi-Fi enabled state.  <para>isWifiEnabled() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>One of WIFI_STATE_DISABLED, WIFI_STATE_DISABLING, WIFI_STATE_ENABLED, WIFI_STATE_ENABLING, WIFI_STATE_UNKNOWN </para>
				/// </returns>
				/// <java-name>
				/// getWifiState
				/// </java-name>
				public virtual int WifiState
				{
						[Dot42.DexImport("getWifiState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return whether Wi-Fi is enabled or disabled.  <para>getWifiState() </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if Wi-Fi is enabled </para>
				/// </returns>
				/// <java-name>
				/// isWifiEnabled
				/// </java-name>
				public virtual bool IsWifiEnabled
				{
						[Dot42.DexImport("isWifiEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Allows an application to receive Wifi Multicast packets. Normally the Wifi stack filters out packets not explicitly addressed to this device. Acquring a MulticastLock will cause the stack to receive packets addressed to multicast addresses. Processing these extra packets can cause a noticable battery drain and should be disabled when not needed. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Locks Wifi Multicast on until release is called.</para> <para>If this MulticastLock is reference-counted each call to  <c>acquire </c> will increment the reference count, and the wifi interface will receive multicast packets as long as the reference count is above zero.</para> <para>If this MulticastLock is not reference-counted, the first call to  <c>acquire </c> will turn on the multicast packets, but subsequent calls will be ignored. Only one call to release will be required, regardless of the number of times that <c>acquire </c> is called.</para> <para>Note that other applications may also lock Wifi Multicast on. Only they can relinquish their lock.</para> <para>Also note that applications cannot leave Multicast locked on. When an app exits or crashes, any Multicast locks will be released. </para>        
						/// </summary>
						/// <java-name>
						/// acquire
						/// </java-name>
						[Dot42.DexImport("acquire", "()V", AccessFlags = 1)]
						public virtual void Acquire() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Unlocks Wifi Multicast, restoring the filter of packets not addressed specifically to this device and saving power.</para> <para>If this MulticastLock is reference-counted, each call to  <c>release </c> will decrement the reference count, and the multicast packets will only stop being received when the reference count reaches zero. If the reference count goes below zero (that is, if <c>release </c> is called a greater number of times than acquire), an exception is thrown.</para> <para>If this MulticastLock is not reference-counted, the first call to  <c>release </c> (after the radio was multicast locked using acquire) will unlock the multicast, and subsequent calls will be ignored.</para> <para>Note that if any other Wifi Multicast Locks are still outstanding this <c>release </c> call will not have an immediate effect. Only when all applications have released all their Multicast Locks will the Multicast filter be turned back on.</para> <para>Also note that when an app exits or crashes all of its Multicast Locks will be automatically released. </para>        
						/// </summary>
						/// <java-name>
						/// release
						/// </java-name>
						[Dot42.DexImport("release", "()V", AccessFlags = 1)]
						public virtual void Release() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Controls whether this is a reference-counted or non-reference- counted MulticastLock.</para> <para>Reference-counted MulticastLocks keep track of the number of calls to acquire and release, and only stop the reception of multicast packets when every call to acquire has been balanced with a call to release. Non-reference- counted MulticastLocks allow the reception of multicast packets whenever acquire is called and stop accepting multicast packets whenever release is called.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setReferenceCounted
						/// </java-name>
						[Dot42.DexImport("setReferenceCounted", "(Z)V", AccessFlags = 1)]
						public virtual void SetReferenceCounted(bool refCounted) /* MethodBuilder.Create */ 
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
						extern ~MulticastLock() /* MethodBuilder.Create */ ;

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal MulticastLock() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Checks whether this MulticastLock is currently held.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if this MulticastLock is held, false otherwise </para>
						/// </returns>
						/// <java-name>
						/// isHeld
						/// </java-name>
						public virtual bool IsHeld
						{
								[Dot42.DexImport("isHeld", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

				}

				/// <summary>
				///  <para>Allows an application to keep the Wi-Fi radio awake. Normally the Wi-Fi radio may turn off when the user has not used the device in a while. Acquiring a WifiLock will keep the radio on until the lock is released. Multiple applications may hold WifiLocks, and the radio will only be allowed to turn off when no WifiLocks are held in any application. </para> <para>Before using a WifiLock, consider carefully if your application requires Wi-Fi access, or could function over a mobile network, if available. A program that needs to download large files should hold a WifiLock to ensure that the download will complete, but a program whose network usage is occasional or low-bandwidth should not hold a WifiLock to avoid adversely affecting battery life. </para> <para>Note that WifiLocks cannot override the user-level "Wi-Fi Enabled" setting, nor Airplane Mode. They simply keep the radio from turning off when Wi-Fi is already on but the device is idle. </para> <para>Any application using a WifiLock must request the <c>android.permission.WAKE_LOCK </c> permission in an <c>&amp;lt;uses-permission&amp;gt; </c> element of the application's manifest. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Locks the Wi-Fi radio on until release is called.</para> <para>If this WifiLock is reference-counted, each call to <c>acquire </c> will increment the reference count, and the radio will remain locked as long as the reference count is above zero.</para> <para>If this WifiLock is not reference-counted, the first call to <c>acquire </c> will lock the radio, but subsequent calls will be ignored. Only one call to release will be required, regardless of the number of times that <c>acquire </c> is called. </para>        
						/// </summary>
						/// <java-name>
						/// acquire
						/// </java-name>
						[Dot42.DexImport("acquire", "()V", AccessFlags = 1)]
						public virtual void Acquire() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Unlocks the Wi-Fi radio, allowing it to turn off when the device is idle.</para> <para>If this WifiLock is reference-counted, each call to <c>release </c> will decrement the reference count, and the radio will be unlocked only when the reference count reaches zero. If the reference count goes below zero (that is, if <c>release </c> is called a greater number of times than acquire), an exception is thrown.</para> <para>If this WifiLock is not reference-counted, the first call to <c>release </c> (after the radio was locked using acquire) will unlock the radio, and subsequent calls will be ignored. </para>        
						/// </summary>
						/// <java-name>
						/// release
						/// </java-name>
						[Dot42.DexImport("release", "()V", AccessFlags = 1)]
						public virtual void Release() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Controls whether this is a reference-counted or non-reference-counted WifiLock.</para> <para>Reference-counted WifiLocks keep track of the number of calls to acquire and release, and only allow the radio to sleep when every call to acquire has been balanced with a call to release. Non-reference-counted WifiLocks lock the radio whenever acquire is called and it is unlocked, and unlock the radio whenever release is called and it is locked.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setReferenceCounted
						/// </java-name>
						[Dot42.DexImport("setReferenceCounted", "(Z)V", AccessFlags = 1)]
						public virtual void SetReferenceCounted(bool refCounted) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setWorkSource
						/// </java-name>
						[Dot42.DexImport("setWorkSource", "(Landroid/os/WorkSource;)V", AccessFlags = 1)]
						public virtual void SetWorkSource(global::Android.OS.WorkSource ws) /* MethodBuilder.Create */ 
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

						/// <summary>
						///  <para>Checks whether this WifiLock is currently held.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if this WifiLock is held, false otherwise </para>
						/// </returns>
						/// <java-name>
						/// isHeld
						/// </java-name>
						public virtual bool IsHeld
						{
								[Dot42.DexImport("isHeld", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

				}

		}

		/// <summary>
		///  <para>A class representing Wi-Fi Protected Setup</para> <para>{ <para>WifiP2pConfig} </para></para>    
		/// </summary>
		/// <java-name>
		/// android/net/wifi/WpsInfo
		/// </java-name>
		[Dot42.DexImport("android/net/wifi/WpsInfo", AccessFlags = 33)]
		public partial class WpsInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Push button configuration </para>        
				/// </summary>
				/// <java-name>
				/// PBC
				/// </java-name>
				[Dot42.DexImport("PBC", "I", AccessFlags = 25)]
				public const int PBC = 0;
				/// <summary>
				///  <para>Display pin method configuration - pin is generated and displayed on device </para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY
				/// </java-name>
				[Dot42.DexImport("DISPLAY", "I", AccessFlags = 25)]
				public const int DISPLAY = 1;
				/// <summary>
				///  <para>Keypad pin method configuration - pin is entered on device </para>        
				/// </summary>
				/// <java-name>
				/// KEYPAD
				/// </java-name>
				[Dot42.DexImport("KEYPAD", "I", AccessFlags = 25)]
				public const int KEYPAD = 2;
				/// <summary>
				///  <para>Label pin method configuration - pin is labelled on device </para>        
				/// </summary>
				/// <java-name>
				/// LABEL
				/// </java-name>
				[Dot42.DexImport("LABEL", "I", AccessFlags = 25)]
				public const int LABEL = 3;
				/// <summary>
				///  <para>Invalid configuration </para>        
				/// </summary>
				/// <java-name>
				/// INVALID
				/// </java-name>
				[Dot42.DexImport("INVALID", "I", AccessFlags = 25)]
				public const int INVALID = 4;
				/// <summary>
				///  <para>Wi-Fi Protected Setup. www.wi-fi.org/wifi-protected-setup has details </para>        
				/// </summary>
				/// <java-name>
				/// setup
				/// </java-name>
				[Dot42.DexImport("setup", "I", AccessFlags = 1)]
				public int Setup;
				/// <summary>
				///  <para>Passed with pin method configuration </para>        
				/// </summary>
				/// <java-name>
				/// pin
				/// </java-name>
				[Dot42.DexImport("pin", "Ljava/lang/String;", AccessFlags = 1)]
				public string Pin;
				/// <summary>
				///  <para>Implement the Parcelable interface </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Net.Wifi.WpsInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public WpsInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/net/wifi/WpsInfo;)V", AccessFlags = 1)]
				public WpsInfo(global::Android.Net.Wifi.WpsInfo source) /* MethodBuilder.Create */ 
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

}

