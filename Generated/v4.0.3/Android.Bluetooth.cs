#pragma warning disable 1717
namespace Android.Bluetooth
{
		/// <java-name>
		/// android/bluetooth/BluetoothA2dp
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothA2dp", AccessFlags = 49)]
		public sealed partial class BluetoothA2dp : global::Android.Bluetooth.IBluetoothProfile
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_CONNECTION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CONNECTION_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CONNECTION_STATE_CHANGED = "android.bluetooth.a2dp.profile.action.CONNECTION_STATE_CHANGED";
				/// <java-name>
				/// ACTION_PLAYING_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PLAYING_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PLAYING_STATE_CHANGED = "android.bluetooth.a2dp.profile.action.PLAYING_STATE_CHANGED";
				/// <java-name>
				/// STATE_PLAYING
				/// </java-name>
				[Dot42.DexImport("STATE_PLAYING", "I", AccessFlags = 25)]
				public const int STATE_PLAYING = 10;
				/// <java-name>
				/// STATE_NOT_PLAYING
				/// </java-name>
				[Dot42.DexImport("STATE_NOT_PLAYING", "I", AccessFlags = 25)]
				public const int STATE_NOT_PLAYING = 11;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothA2dp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDevicesMatchingConnectionStates
				/// </java-name>
				[Dot42.DexImport("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", AccessFlags = 1, Signature = "([I)Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>);
				}

				/// <java-name>
				/// getConnectionState
				/// </java-name>
				[Dot42.DexImport("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", AccessFlags = 1)]
				public int GetConnectionState(global::Android.Bluetooth.BluetoothDevice bluetoothDevice) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isA2dpPlaying
				/// </java-name>
				[Dot42.DexImport("isA2dpPlaying", "(Landroid/bluetooth/BluetoothDevice;)Z", AccessFlags = 1)]
				public bool IsA2dpPlaying(global::Android.Bluetooth.BluetoothDevice bluetoothDevice) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> ConnectedDevices
				{
						[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>); }
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothAdapter
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothAdapter", AccessFlags = 49)]
		public sealed partial class BluetoothAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -2147483648;
				/// <java-name>
				/// ACTION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_STATE_CHANGED = "android.bluetooth.adapter.action.STATE_CHANGED";
				/// <java-name>
				/// EXTRA_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STATE = "android.bluetooth.adapter.extra.STATE";
				/// <java-name>
				/// EXTRA_PREVIOUS_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_STATE = "android.bluetooth.adapter.extra.PREVIOUS_STATE";
				/// <java-name>
				/// STATE_OFF
				/// </java-name>
				[Dot42.DexImport("STATE_OFF", "I", AccessFlags = 25)]
				public const int STATE_OFF = 10;
				/// <java-name>
				/// STATE_TURNING_ON
				/// </java-name>
				[Dot42.DexImport("STATE_TURNING_ON", "I", AccessFlags = 25)]
				public const int STATE_TURNING_ON = 11;
				/// <java-name>
				/// STATE_ON
				/// </java-name>
				[Dot42.DexImport("STATE_ON", "I", AccessFlags = 25)]
				public const int STATE_ON = 12;
				/// <java-name>
				/// STATE_TURNING_OFF
				/// </java-name>
				[Dot42.DexImport("STATE_TURNING_OFF", "I", AccessFlags = 25)]
				public const int STATE_TURNING_OFF = 13;
				/// <java-name>
				/// ACTION_REQUEST_DISCOVERABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_REQUEST_DISCOVERABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_REQUEST_DISCOVERABLE = "android.bluetooth.adapter.action.REQUEST_DISCOVERABLE";
				/// <java-name>
				/// EXTRA_DISCOVERABLE_DURATION
				/// </java-name>
				[Dot42.DexImport("EXTRA_DISCOVERABLE_DURATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DISCOVERABLE_DURATION = "android.bluetooth.adapter.extra.DISCOVERABLE_DURATION";
				/// <java-name>
				/// ACTION_REQUEST_ENABLE
				/// </java-name>
				[Dot42.DexImport("ACTION_REQUEST_ENABLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_REQUEST_ENABLE = "android.bluetooth.adapter.action.REQUEST_ENABLE";
				/// <java-name>
				/// ACTION_SCAN_MODE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_SCAN_MODE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SCAN_MODE_CHANGED = "android.bluetooth.adapter.action.SCAN_MODE_CHANGED";
				/// <java-name>
				/// EXTRA_SCAN_MODE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SCAN_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SCAN_MODE = "android.bluetooth.adapter.extra.SCAN_MODE";
				/// <java-name>
				/// EXTRA_PREVIOUS_SCAN_MODE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_SCAN_MODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_SCAN_MODE = "android.bluetooth.adapter.extra.PREVIOUS_SCAN_MODE";
				/// <java-name>
				/// SCAN_MODE_NONE
				/// </java-name>
				[Dot42.DexImport("SCAN_MODE_NONE", "I", AccessFlags = 25)]
				public const int SCAN_MODE_NONE = 20;
				/// <java-name>
				/// SCAN_MODE_CONNECTABLE
				/// </java-name>
				[Dot42.DexImport("SCAN_MODE_CONNECTABLE", "I", AccessFlags = 25)]
				public const int SCAN_MODE_CONNECTABLE = 21;
				/// <java-name>
				/// SCAN_MODE_CONNECTABLE_DISCOVERABLE
				/// </java-name>
				[Dot42.DexImport("SCAN_MODE_CONNECTABLE_DISCOVERABLE", "I", AccessFlags = 25)]
				public const int SCAN_MODE_CONNECTABLE_DISCOVERABLE = 23;
				/// <java-name>
				/// ACTION_DISCOVERY_STARTED
				/// </java-name>
				[Dot42.DexImport("ACTION_DISCOVERY_STARTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DISCOVERY_STARTED = "android.bluetooth.adapter.action.DISCOVERY_STARTED";
				/// <java-name>
				/// ACTION_DISCOVERY_FINISHED
				/// </java-name>
				[Dot42.DexImport("ACTION_DISCOVERY_FINISHED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_DISCOVERY_FINISHED = "android.bluetooth.adapter.action.DISCOVERY_FINISHED";
				/// <java-name>
				/// ACTION_LOCAL_NAME_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_LOCAL_NAME_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_LOCAL_NAME_CHANGED = "android.bluetooth.adapter.action.LOCAL_NAME_CHANGED";
				/// <java-name>
				/// EXTRA_LOCAL_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_LOCAL_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_LOCAL_NAME = "android.bluetooth.adapter.extra.LOCAL_NAME";
				/// <java-name>
				/// ACTION_CONNECTION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CONNECTION_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CONNECTION_STATE_CHANGED = "android.bluetooth.adapter.action.CONNECTION_STATE_CHANGED";
				/// <java-name>
				/// EXTRA_CONNECTION_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CONNECTION_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CONNECTION_STATE = "android.bluetooth.adapter.extra.CONNECTION_STATE";
				/// <java-name>
				/// EXTRA_PREVIOUS_CONNECTION_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_CONNECTION_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_CONNECTION_STATE = "android.bluetooth.adapter.extra.PREVIOUS_CONNECTION_STATE";
				/// <java-name>
				/// STATE_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_DISCONNECTED", "I", AccessFlags = 25)]
				public const int STATE_DISCONNECTED = 0;
				/// <java-name>
				/// STATE_CONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_CONNECTING", "I", AccessFlags = 25)]
				public const int STATE_CONNECTING = 1;
				/// <java-name>
				/// STATE_CONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_CONNECTED", "I", AccessFlags = 25)]
				public const int STATE_CONNECTED = 2;
				/// <java-name>
				/// STATE_DISCONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_DISCONNECTING", "I", AccessFlags = 25)]
				public const int STATE_DISCONNECTING = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRemoteDevice
				/// </java-name>
				[Dot42.DexImport("getRemoteDevice", "(Ljava/lang/String;)Landroid/bluetooth/BluetoothDevice;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothDevice GetRemoteDevice(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothDevice);
				}

				/// <java-name>
				/// enable
				/// </java-name>
				[Dot42.DexImport("enable", "()Z", AccessFlags = 1)]
				public bool Enable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// disable
				/// </java-name>
				[Dot42.DexImport("disable", "()Z", AccessFlags = 1)]
				public bool Disable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool SetName(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startDiscovery
				/// </java-name>
				[Dot42.DexImport("startDiscovery", "()Z", AccessFlags = 1)]
				public bool StartDiscovery() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getProfileConnectionState
				/// </java-name>
				[Dot42.DexImport("getProfileConnectionState", "(I)I", AccessFlags = 1)]
				public int GetProfileConnectionState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// listenUsingRfcommWithServiceRecord
				/// </java-name>
				[Dot42.DexImport("listenUsingRfcommWithServiceRecord", "(Ljava/lang/String;Ljava/util/UUID;)Landroid/bluetooth/BluetoothServerSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothServerSocket ListenUsingRfcommWithServiceRecord(string @string, global::Java.Util.UUID uUID) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothServerSocket);
				}

				/// <java-name>
				/// listenUsingInsecureRfcommWithServiceRecord
				/// </java-name>
				[Dot42.DexImport("listenUsingInsecureRfcommWithServiceRecord", "(Ljava/lang/String;Ljava/util/UUID;)Landroid/bluetooth/BluetoothServerSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothServerSocket ListenUsingInsecureRfcommWithServiceRecord(string @string, global::Java.Util.UUID uUID) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothServerSocket);
				}

				/// <java-name>
				/// getProfileProxy
				/// </java-name>
				[Dot42.DexImport("getProfileProxy", "(Landroid/content/Context;Landroid/bluetooth/BluetoothProfile$ServiceListener;I)Z" +
    "", AccessFlags = 1)]
				public bool GetProfileProxy(global::Android.Content.Context context, global::Android.Bluetooth.IBluetoothProfile_IServiceListener bluetoothProfile_IServiceListener, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// closeProfileProxy
				/// </java-name>
				[Dot42.DexImport("closeProfileProxy", "(ILandroid/bluetooth/BluetoothProfile;)V", AccessFlags = 1)]
				public void CloseProfileProxy(int int32, global::Android.Bluetooth.IBluetoothProfile bluetoothProfile) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkBluetoothAddress
				/// </java-name>
				[Dot42.DexImport("checkBluetoothAddress", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool CheckBluetoothAddress(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				public static global::Android.Bluetooth.BluetoothAdapter DefaultAdapter
				{
						[Dot42.DexImport("getDefaultAdapter", "()Landroid/bluetooth/BluetoothAdapter;", AccessFlags = 41)]
						get{ return default(global::Android.Bluetooth.BluetoothAdapter); }
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getState
				/// </java-name>
				public int State
				{
						[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				public string Address
				{
						[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getScanMode
				/// </java-name>
				public int ScanMode
				{
						[Dot42.DexImport("getScanMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// cancelDiscovery
				/// </java-name>
				public bool CancelDiscovery
				{
						[Dot42.DexImport("cancelDiscovery", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isDiscovering
				/// </java-name>
				public bool IsDiscovering
				{
						[Dot42.DexImport("isDiscovering", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getBondedDevices
				/// </java-name>
				public global::Java.Util.ISet<global::Android.Bluetooth.BluetoothDevice> BondedDevices
				{
						[Dot42.DexImport("getBondedDevices", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Landroid/bluetooth/BluetoothDevice;>;")]
						get{ return default(global::Java.Util.ISet<global::Android.Bluetooth.BluetoothDevice>); }
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothAssignedNumbers
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothAssignedNumbers", AccessFlags = 33)]
		public partial class BluetoothAssignedNumbers
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ERICSSON_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("ERICSSON_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int ERICSSON_TECHNOLOGY = 0;
				/// <java-name>
				/// NOKIA_MOBILE_PHONES
				/// </java-name>
				[Dot42.DexImport("NOKIA_MOBILE_PHONES", "I", AccessFlags = 25)]
				public const int NOKIA_MOBILE_PHONES = 1;
				/// <java-name>
				/// INTEL
				/// </java-name>
				[Dot42.DexImport("INTEL", "I", AccessFlags = 25)]
				public const int INTEL = 2;
				/// <java-name>
				/// IBM
				/// </java-name>
				[Dot42.DexImport("IBM", "I", AccessFlags = 25)]
				public const int IBM = 3;
				/// <java-name>
				/// TOSHIBA
				/// </java-name>
				[Dot42.DexImport("TOSHIBA", "I", AccessFlags = 25)]
				public const int TOSHIBA = 4;
				/// <java-name>
				/// THREECOM
				/// </java-name>
				[Dot42.DexImport("THREECOM", "I", AccessFlags = 25)]
				public const int THREECOM = 5;
				/// <java-name>
				/// MICROSOFT
				/// </java-name>
				[Dot42.DexImport("MICROSOFT", "I", AccessFlags = 25)]
				public const int MICROSOFT = 6;
				/// <java-name>
				/// LUCENT
				/// </java-name>
				[Dot42.DexImport("LUCENT", "I", AccessFlags = 25)]
				public const int LUCENT = 7;
				/// <java-name>
				/// MOTOROLA
				/// </java-name>
				[Dot42.DexImport("MOTOROLA", "I", AccessFlags = 25)]
				public const int MOTOROLA = 8;
				/// <java-name>
				/// INFINEON_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("INFINEON_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int INFINEON_TECHNOLOGIES = 9;
				/// <java-name>
				/// CAMBRIDGE_SILICON_RADIO
				/// </java-name>
				[Dot42.DexImport("CAMBRIDGE_SILICON_RADIO", "I", AccessFlags = 25)]
				public const int CAMBRIDGE_SILICON_RADIO = 10;
				/// <java-name>
				/// SILICON_WAVE
				/// </java-name>
				[Dot42.DexImport("SILICON_WAVE", "I", AccessFlags = 25)]
				public const int SILICON_WAVE = 11;
				/// <java-name>
				/// DIGIANSWER
				/// </java-name>
				[Dot42.DexImport("DIGIANSWER", "I", AccessFlags = 25)]
				public const int DIGIANSWER = 12;
				/// <java-name>
				/// TEXAS_INSTRUMENTS
				/// </java-name>
				[Dot42.DexImport("TEXAS_INSTRUMENTS", "I", AccessFlags = 25)]
				public const int TEXAS_INSTRUMENTS = 13;
				/// <java-name>
				/// PARTHUS_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("PARTHUS_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int PARTHUS_TECHNOLOGIES = 14;
				/// <java-name>
				/// BROADCOM
				/// </java-name>
				[Dot42.DexImport("BROADCOM", "I", AccessFlags = 25)]
				public const int BROADCOM = 15;
				/// <java-name>
				/// MITEL_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("MITEL_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int MITEL_SEMICONDUCTOR = 16;
				/// <java-name>
				/// WIDCOMM
				/// </java-name>
				[Dot42.DexImport("WIDCOMM", "I", AccessFlags = 25)]
				public const int WIDCOMM = 17;
				/// <java-name>
				/// ZEEVO
				/// </java-name>
				[Dot42.DexImport("ZEEVO", "I", AccessFlags = 25)]
				public const int ZEEVO = 18;
				/// <java-name>
				/// ATMEL
				/// </java-name>
				[Dot42.DexImport("ATMEL", "I", AccessFlags = 25)]
				public const int ATMEL = 19;
				/// <java-name>
				/// MITSUBISHI_ELECTRIC
				/// </java-name>
				[Dot42.DexImport("MITSUBISHI_ELECTRIC", "I", AccessFlags = 25)]
				public const int MITSUBISHI_ELECTRIC = 20;
				/// <java-name>
				/// RTX_TELECOM
				/// </java-name>
				[Dot42.DexImport("RTX_TELECOM", "I", AccessFlags = 25)]
				public const int RTX_TELECOM = 21;
				/// <java-name>
				/// KC_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("KC_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int KC_TECHNOLOGY = 22;
				/// <java-name>
				/// NEWLOGIC
				/// </java-name>
				[Dot42.DexImport("NEWLOGIC", "I", AccessFlags = 25)]
				public const int NEWLOGIC = 23;
				/// <java-name>
				/// TRANSILICA
				/// </java-name>
				[Dot42.DexImport("TRANSILICA", "I", AccessFlags = 25)]
				public const int TRANSILICA = 24;
				/// <java-name>
				/// ROHDE_AND_SCHWARZ
				/// </java-name>
				[Dot42.DexImport("ROHDE_AND_SCHWARZ", "I", AccessFlags = 25)]
				public const int ROHDE_AND_SCHWARZ = 25;
				/// <java-name>
				/// TTPCOM
				/// </java-name>
				[Dot42.DexImport("TTPCOM", "I", AccessFlags = 25)]
				public const int TTPCOM = 26;
				/// <java-name>
				/// SIGNIA_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("SIGNIA_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int SIGNIA_TECHNOLOGIES = 27;
				/// <java-name>
				/// CONEXANT_SYSTEMS
				/// </java-name>
				[Dot42.DexImport("CONEXANT_SYSTEMS", "I", AccessFlags = 25)]
				public const int CONEXANT_SYSTEMS = 28;
				/// <java-name>
				/// QUALCOMM
				/// </java-name>
				[Dot42.DexImport("QUALCOMM", "I", AccessFlags = 25)]
				public const int QUALCOMM = 29;
				/// <java-name>
				/// INVENTEL
				/// </java-name>
				[Dot42.DexImport("INVENTEL", "I", AccessFlags = 25)]
				public const int INVENTEL = 30;
				/// <java-name>
				/// AVM_BERLIN
				/// </java-name>
				[Dot42.DexImport("AVM_BERLIN", "I", AccessFlags = 25)]
				public const int AVM_BERLIN = 31;
				/// <java-name>
				/// BANDSPEED
				/// </java-name>
				[Dot42.DexImport("BANDSPEED", "I", AccessFlags = 25)]
				public const int BANDSPEED = 32;
				/// <java-name>
				/// MANSELLA
				/// </java-name>
				[Dot42.DexImport("MANSELLA", "I", AccessFlags = 25)]
				public const int MANSELLA = 33;
				/// <java-name>
				/// NEC
				/// </java-name>
				[Dot42.DexImport("NEC", "I", AccessFlags = 25)]
				public const int NEC = 34;
				/// <java-name>
				/// WAVEPLUS_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("WAVEPLUS_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int WAVEPLUS_TECHNOLOGY = 35;
				/// <java-name>
				/// ALCATEL
				/// </java-name>
				[Dot42.DexImport("ALCATEL", "I", AccessFlags = 25)]
				public const int ALCATEL = 36;
				/// <java-name>
				/// PHILIPS_SEMICONDUCTORS
				/// </java-name>
				[Dot42.DexImport("PHILIPS_SEMICONDUCTORS", "I", AccessFlags = 25)]
				public const int PHILIPS_SEMICONDUCTORS = 37;
				/// <java-name>
				/// C_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("C_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int C_TECHNOLOGIES = 38;
				/// <java-name>
				/// OPEN_INTERFACE
				/// </java-name>
				[Dot42.DexImport("OPEN_INTERFACE", "I", AccessFlags = 25)]
				public const int OPEN_INTERFACE = 39;
				/// <java-name>
				/// RF_MICRO_DEVICES
				/// </java-name>
				[Dot42.DexImport("RF_MICRO_DEVICES", "I", AccessFlags = 25)]
				public const int RF_MICRO_DEVICES = 40;
				/// <java-name>
				/// HITACHI
				/// </java-name>
				[Dot42.DexImport("HITACHI", "I", AccessFlags = 25)]
				public const int HITACHI = 41;
				/// <java-name>
				/// SYMBOL_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("SYMBOL_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int SYMBOL_TECHNOLOGIES = 42;
				/// <java-name>
				/// TENOVIS
				/// </java-name>
				[Dot42.DexImport("TENOVIS", "I", AccessFlags = 25)]
				public const int TENOVIS = 43;
				/// <java-name>
				/// MACRONIX
				/// </java-name>
				[Dot42.DexImport("MACRONIX", "I", AccessFlags = 25)]
				public const int MACRONIX = 44;
				/// <java-name>
				/// GCT_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("GCT_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int GCT_SEMICONDUCTOR = 45;
				/// <java-name>
				/// NORWOOD_SYSTEMS
				/// </java-name>
				[Dot42.DexImport("NORWOOD_SYSTEMS", "I", AccessFlags = 25)]
				public const int NORWOOD_SYSTEMS = 46;
				/// <java-name>
				/// MEWTEL_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("MEWTEL_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int MEWTEL_TECHNOLOGY = 47;
				/// <java-name>
				/// ST_MICROELECTRONICS
				/// </java-name>
				[Dot42.DexImport("ST_MICROELECTRONICS", "I", AccessFlags = 25)]
				public const int ST_MICROELECTRONICS = 48;
				/// <java-name>
				/// SYNOPSYS
				/// </java-name>
				[Dot42.DexImport("SYNOPSYS", "I", AccessFlags = 25)]
				public const int SYNOPSYS = 49;
				/// <java-name>
				/// RED_M
				/// </java-name>
				[Dot42.DexImport("RED_M", "I", AccessFlags = 25)]
				public const int RED_M = 50;
				/// <java-name>
				/// COMMIL
				/// </java-name>
				[Dot42.DexImport("COMMIL", "I", AccessFlags = 25)]
				public const int COMMIL = 51;
				/// <java-name>
				/// CATC
				/// </java-name>
				[Dot42.DexImport("CATC", "I", AccessFlags = 25)]
				public const int CATC = 52;
				/// <java-name>
				/// ECLIPSE
				/// </java-name>
				[Dot42.DexImport("ECLIPSE", "I", AccessFlags = 25)]
				public const int ECLIPSE = 53;
				/// <java-name>
				/// RENESAS_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("RENESAS_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int RENESAS_TECHNOLOGY = 54;
				/// <java-name>
				/// MOBILIAN_CORPORATION
				/// </java-name>
				[Dot42.DexImport("MOBILIAN_CORPORATION", "I", AccessFlags = 25)]
				public const int MOBILIAN_CORPORATION = 55;
				/// <java-name>
				/// TERAX
				/// </java-name>
				[Dot42.DexImport("TERAX", "I", AccessFlags = 25)]
				public const int TERAX = 56;
				/// <java-name>
				/// INTEGRATED_SYSTEM_SOLUTION
				/// </java-name>
				[Dot42.DexImport("INTEGRATED_SYSTEM_SOLUTION", "I", AccessFlags = 25)]
				public const int INTEGRATED_SYSTEM_SOLUTION = 57;
				/// <java-name>
				/// MATSUSHITA_ELECTRIC
				/// </java-name>
				[Dot42.DexImport("MATSUSHITA_ELECTRIC", "I", AccessFlags = 25)]
				public const int MATSUSHITA_ELECTRIC = 58;
				/// <java-name>
				/// GENNUM
				/// </java-name>
				[Dot42.DexImport("GENNUM", "I", AccessFlags = 25)]
				public const int GENNUM = 59;
				/// <java-name>
				/// RESEARCH_IN_MOTION
				/// </java-name>
				[Dot42.DexImport("RESEARCH_IN_MOTION", "I", AccessFlags = 25)]
				public const int RESEARCH_IN_MOTION = 60;
				/// <java-name>
				/// IPEXTREME
				/// </java-name>
				[Dot42.DexImport("IPEXTREME", "I", AccessFlags = 25)]
				public const int IPEXTREME = 61;
				/// <java-name>
				/// SYSTEMS_AND_CHIPS
				/// </java-name>
				[Dot42.DexImport("SYSTEMS_AND_CHIPS", "I", AccessFlags = 25)]
				public const int SYSTEMS_AND_CHIPS = 62;
				/// <java-name>
				/// BLUETOOTH_SIG
				/// </java-name>
				[Dot42.DexImport("BLUETOOTH_SIG", "I", AccessFlags = 25)]
				public const int BLUETOOTH_SIG = 63;
				/// <java-name>
				/// SEIKO_EPSON
				/// </java-name>
				[Dot42.DexImport("SEIKO_EPSON", "I", AccessFlags = 25)]
				public const int SEIKO_EPSON = 64;
				/// <java-name>
				/// INTEGRATED_SILICON_SOLUTION
				/// </java-name>
				[Dot42.DexImport("INTEGRATED_SILICON_SOLUTION", "I", AccessFlags = 25)]
				public const int INTEGRATED_SILICON_SOLUTION = 65;
				/// <java-name>
				/// CONWISE_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("CONWISE_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int CONWISE_TECHNOLOGY = 66;
				/// <java-name>
				/// PARROT
				/// </java-name>
				[Dot42.DexImport("PARROT", "I", AccessFlags = 25)]
				public const int PARROT = 67;
				/// <java-name>
				/// SOCKET_MOBILE
				/// </java-name>
				[Dot42.DexImport("SOCKET_MOBILE", "I", AccessFlags = 25)]
				public const int SOCKET_MOBILE = 68;
				/// <java-name>
				/// ATHEROS_COMMUNICATIONS
				/// </java-name>
				[Dot42.DexImport("ATHEROS_COMMUNICATIONS", "I", AccessFlags = 25)]
				public const int ATHEROS_COMMUNICATIONS = 69;
				/// <java-name>
				/// MEDIATEK
				/// </java-name>
				[Dot42.DexImport("MEDIATEK", "I", AccessFlags = 25)]
				public const int MEDIATEK = 70;
				/// <java-name>
				/// BLUEGIGA
				/// </java-name>
				[Dot42.DexImport("BLUEGIGA", "I", AccessFlags = 25)]
				public const int BLUEGIGA = 71;
				/// <java-name>
				/// MARVELL
				/// </java-name>
				[Dot42.DexImport("MARVELL", "I", AccessFlags = 25)]
				public const int MARVELL = 72;
				/// <java-name>
				/// THREE_DSP
				/// </java-name>
				[Dot42.DexImport("THREE_DSP", "I", AccessFlags = 25)]
				public const int THREE_DSP = 73;
				/// <java-name>
				/// ACCEL_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("ACCEL_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int ACCEL_SEMICONDUCTOR = 74;
				/// <java-name>
				/// CONTINENTAL_AUTOMOTIVE
				/// </java-name>
				[Dot42.DexImport("CONTINENTAL_AUTOMOTIVE", "I", AccessFlags = 25)]
				public const int CONTINENTAL_AUTOMOTIVE = 75;
				/// <java-name>
				/// APPLE
				/// </java-name>
				[Dot42.DexImport("APPLE", "I", AccessFlags = 25)]
				public const int APPLE = 76;
				/// <java-name>
				/// STACCATO_COMMUNICATIONS
				/// </java-name>
				[Dot42.DexImport("STACCATO_COMMUNICATIONS", "I", AccessFlags = 25)]
				public const int STACCATO_COMMUNICATIONS = 77;
				/// <java-name>
				/// AVAGO
				/// </java-name>
				[Dot42.DexImport("AVAGO", "I", AccessFlags = 25)]
				public const int AVAGO = 78;
				/// <java-name>
				/// APT_LICENSING
				/// </java-name>
				[Dot42.DexImport("APT_LICENSING", "I", AccessFlags = 25)]
				public const int APT_LICENSING = 79;
				/// <java-name>
				/// SIRF_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("SIRF_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int SIRF_TECHNOLOGY = 80;
				/// <java-name>
				/// TZERO_TECHNOLOGIES
				/// </java-name>
				[Dot42.DexImport("TZERO_TECHNOLOGIES", "I", AccessFlags = 25)]
				public const int TZERO_TECHNOLOGIES = 81;
				/// <java-name>
				/// J_AND_M
				/// </java-name>
				[Dot42.DexImport("J_AND_M", "I", AccessFlags = 25)]
				public const int J_AND_M = 82;
				/// <java-name>
				/// FREE2MOVE
				/// </java-name>
				[Dot42.DexImport("FREE2MOVE", "I", AccessFlags = 25)]
				public const int FREE2MOVE = 83;
				/// <java-name>
				/// THREE_DIJOY
				/// </java-name>
				[Dot42.DexImport("THREE_DIJOY", "I", AccessFlags = 25)]
				public const int THREE_DIJOY = 84;
				/// <java-name>
				/// PLANTRONICS
				/// </java-name>
				[Dot42.DexImport("PLANTRONICS", "I", AccessFlags = 25)]
				public const int PLANTRONICS = 85;
				/// <java-name>
				/// SONY_ERICSSON
				/// </java-name>
				[Dot42.DexImport("SONY_ERICSSON", "I", AccessFlags = 25)]
				public const int SONY_ERICSSON = 86;
				/// <java-name>
				/// HARMAN_INTERNATIONAL
				/// </java-name>
				[Dot42.DexImport("HARMAN_INTERNATIONAL", "I", AccessFlags = 25)]
				public const int HARMAN_INTERNATIONAL = 87;
				/// <java-name>
				/// VIZIO
				/// </java-name>
				[Dot42.DexImport("VIZIO", "I", AccessFlags = 25)]
				public const int VIZIO = 88;
				/// <java-name>
				/// NORDIC_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("NORDIC_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int NORDIC_SEMICONDUCTOR = 89;
				/// <java-name>
				/// EM_MICROELECTRONIC_MARIN
				/// </java-name>
				[Dot42.DexImport("EM_MICROELECTRONIC_MARIN", "I", AccessFlags = 25)]
				public const int EM_MICROELECTRONIC_MARIN = 90;
				/// <java-name>
				/// RALINK_TECHNOLOGY
				/// </java-name>
				[Dot42.DexImport("RALINK_TECHNOLOGY", "I", AccessFlags = 25)]
				public const int RALINK_TECHNOLOGY = 91;
				/// <java-name>
				/// BELKIN_INTERNATIONAL
				/// </java-name>
				[Dot42.DexImport("BELKIN_INTERNATIONAL", "I", AccessFlags = 25)]
				public const int BELKIN_INTERNATIONAL = 92;
				/// <java-name>
				/// REALTEK_SEMICONDUCTOR
				/// </java-name>
				[Dot42.DexImport("REALTEK_SEMICONDUCTOR", "I", AccessFlags = 25)]
				public const int REALTEK_SEMICONDUCTOR = 93;
				/// <java-name>
				/// STONESTREET_ONE
				/// </java-name>
				[Dot42.DexImport("STONESTREET_ONE", "I", AccessFlags = 25)]
				public const int STONESTREET_ONE = 94;
				/// <java-name>
				/// WICENTRIC
				/// </java-name>
				[Dot42.DexImport("WICENTRIC", "I", AccessFlags = 25)]
				public const int WICENTRIC = 95;
				/// <java-name>
				/// RIVIERAWAVES
				/// </java-name>
				[Dot42.DexImport("RIVIERAWAVES", "I", AccessFlags = 25)]
				public const int RIVIERAWAVES = 96;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothAssignedNumbers() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothClass
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothClass", AccessFlags = 49)]
		public sealed partial class BluetoothClass : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Bluetooth.BluetoothClass> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothClass() /* MethodBuilder.Create */ 
				{
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

				/// <java-name>
				/// hasService
				/// </java-name>
				[Dot42.DexImport("hasService", "(I)Z", AccessFlags = 1)]
				public bool HasService(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMajorDeviceClass
				/// </java-name>
				public int MajorDeviceClass
				{
						[Dot42.DexImport("getMajorDeviceClass", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDeviceClass
				/// </java-name>
				public int DeviceClass
				{
						[Dot42.DexImport("getDeviceClass", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/bluetooth/BluetoothClass$Device
				/// </java-name>
				[Dot42.DexImport("android/bluetooth/BluetoothClass$Device", AccessFlags = 9)]
				public partial class Device
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// COMPUTER_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("COMPUTER_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int COMPUTER_UNCATEGORIZED = 256;
						/// <java-name>
						/// COMPUTER_DESKTOP
						/// </java-name>
						[Dot42.DexImport("COMPUTER_DESKTOP", "I", AccessFlags = 25)]
						public const int COMPUTER_DESKTOP = 260;
						/// <java-name>
						/// COMPUTER_SERVER
						/// </java-name>
						[Dot42.DexImport("COMPUTER_SERVER", "I", AccessFlags = 25)]
						public const int COMPUTER_SERVER = 264;
						/// <java-name>
						/// COMPUTER_LAPTOP
						/// </java-name>
						[Dot42.DexImport("COMPUTER_LAPTOP", "I", AccessFlags = 25)]
						public const int COMPUTER_LAPTOP = 268;
						/// <java-name>
						/// COMPUTER_HANDHELD_PC_PDA
						/// </java-name>
						[Dot42.DexImport("COMPUTER_HANDHELD_PC_PDA", "I", AccessFlags = 25)]
						public const int COMPUTER_HANDHELD_PC_PDA = 272;
						/// <java-name>
						/// COMPUTER_PALM_SIZE_PC_PDA
						/// </java-name>
						[Dot42.DexImport("COMPUTER_PALM_SIZE_PC_PDA", "I", AccessFlags = 25)]
						public const int COMPUTER_PALM_SIZE_PC_PDA = 276;
						/// <java-name>
						/// COMPUTER_WEARABLE
						/// </java-name>
						[Dot42.DexImport("COMPUTER_WEARABLE", "I", AccessFlags = 25)]
						public const int COMPUTER_WEARABLE = 280;
						/// <java-name>
						/// PHONE_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("PHONE_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int PHONE_UNCATEGORIZED = 512;
						/// <java-name>
						/// PHONE_CELLULAR
						/// </java-name>
						[Dot42.DexImport("PHONE_CELLULAR", "I", AccessFlags = 25)]
						public const int PHONE_CELLULAR = 516;
						/// <java-name>
						/// PHONE_CORDLESS
						/// </java-name>
						[Dot42.DexImport("PHONE_CORDLESS", "I", AccessFlags = 25)]
						public const int PHONE_CORDLESS = 520;
						/// <java-name>
						/// PHONE_SMART
						/// </java-name>
						[Dot42.DexImport("PHONE_SMART", "I", AccessFlags = 25)]
						public const int PHONE_SMART = 524;
						/// <java-name>
						/// PHONE_MODEM_OR_GATEWAY
						/// </java-name>
						[Dot42.DexImport("PHONE_MODEM_OR_GATEWAY", "I", AccessFlags = 25)]
						public const int PHONE_MODEM_OR_GATEWAY = 528;
						/// <java-name>
						/// PHONE_ISDN
						/// </java-name>
						[Dot42.DexImport("PHONE_ISDN", "I", AccessFlags = 25)]
						public const int PHONE_ISDN = 532;
						/// <java-name>
						/// AUDIO_VIDEO_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_UNCATEGORIZED = 1024;
						/// <java-name>
						/// AUDIO_VIDEO_WEARABLE_HEADSET
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_WEARABLE_HEADSET", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_WEARABLE_HEADSET = 1028;
						/// <java-name>
						/// AUDIO_VIDEO_HANDSFREE
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_HANDSFREE", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_HANDSFREE = 1032;
						/// <java-name>
						/// AUDIO_VIDEO_MICROPHONE
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_MICROPHONE", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_MICROPHONE = 1040;
						/// <java-name>
						/// AUDIO_VIDEO_LOUDSPEAKER
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_LOUDSPEAKER", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_LOUDSPEAKER = 1044;
						/// <java-name>
						/// AUDIO_VIDEO_HEADPHONES
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_HEADPHONES", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_HEADPHONES = 1048;
						/// <java-name>
						/// AUDIO_VIDEO_PORTABLE_AUDIO
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_PORTABLE_AUDIO", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_PORTABLE_AUDIO = 1052;
						/// <java-name>
						/// AUDIO_VIDEO_CAR_AUDIO
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_CAR_AUDIO", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_CAR_AUDIO = 1056;
						/// <java-name>
						/// AUDIO_VIDEO_SET_TOP_BOX
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_SET_TOP_BOX", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_SET_TOP_BOX = 1060;
						/// <java-name>
						/// AUDIO_VIDEO_HIFI_AUDIO
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_HIFI_AUDIO", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_HIFI_AUDIO = 1064;
						/// <java-name>
						/// AUDIO_VIDEO_VCR
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VCR", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VCR = 1068;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_CAMERA
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_CAMERA", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_CAMERA = 1072;
						/// <java-name>
						/// AUDIO_VIDEO_CAMCORDER
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_CAMCORDER", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_CAMCORDER = 1076;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_MONITOR
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_MONITOR", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_MONITOR = 1080;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_DISPLAY_AND_LOUDSPEAKER
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_DISPLAY_AND_LOUDSPEAKER", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_DISPLAY_AND_LOUDSPEAKER = 1084;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_CONFERENCING
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_CONFERENCING", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_CONFERENCING = 1088;
						/// <java-name>
						/// AUDIO_VIDEO_VIDEO_GAMING_TOY
						/// </java-name>
						[Dot42.DexImport("AUDIO_VIDEO_VIDEO_GAMING_TOY", "I", AccessFlags = 25)]
						public const int AUDIO_VIDEO_VIDEO_GAMING_TOY = 1096;
						/// <java-name>
						/// WEARABLE_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("WEARABLE_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int WEARABLE_UNCATEGORIZED = 1792;
						/// <java-name>
						/// WEARABLE_WRIST_WATCH
						/// </java-name>
						[Dot42.DexImport("WEARABLE_WRIST_WATCH", "I", AccessFlags = 25)]
						public const int WEARABLE_WRIST_WATCH = 1796;
						/// <java-name>
						/// WEARABLE_PAGER
						/// </java-name>
						[Dot42.DexImport("WEARABLE_PAGER", "I", AccessFlags = 25)]
						public const int WEARABLE_PAGER = 1800;
						/// <java-name>
						/// WEARABLE_JACKET
						/// </java-name>
						[Dot42.DexImport("WEARABLE_JACKET", "I", AccessFlags = 25)]
						public const int WEARABLE_JACKET = 1804;
						/// <java-name>
						/// WEARABLE_HELMET
						/// </java-name>
						[Dot42.DexImport("WEARABLE_HELMET", "I", AccessFlags = 25)]
						public const int WEARABLE_HELMET = 1808;
						/// <java-name>
						/// WEARABLE_GLASSES
						/// </java-name>
						[Dot42.DexImport("WEARABLE_GLASSES", "I", AccessFlags = 25)]
						public const int WEARABLE_GLASSES = 1812;
						/// <java-name>
						/// TOY_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("TOY_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int TOY_UNCATEGORIZED = 2048;
						/// <java-name>
						/// TOY_ROBOT
						/// </java-name>
						[Dot42.DexImport("TOY_ROBOT", "I", AccessFlags = 25)]
						public const int TOY_ROBOT = 2052;
						/// <java-name>
						/// TOY_VEHICLE
						/// </java-name>
						[Dot42.DexImport("TOY_VEHICLE", "I", AccessFlags = 25)]
						public const int TOY_VEHICLE = 2056;
						/// <java-name>
						/// TOY_DOLL_ACTION_FIGURE
						/// </java-name>
						[Dot42.DexImport("TOY_DOLL_ACTION_FIGURE", "I", AccessFlags = 25)]
						public const int TOY_DOLL_ACTION_FIGURE = 2060;
						/// <java-name>
						/// TOY_CONTROLLER
						/// </java-name>
						[Dot42.DexImport("TOY_CONTROLLER", "I", AccessFlags = 25)]
						public const int TOY_CONTROLLER = 2064;
						/// <java-name>
						/// TOY_GAME
						/// </java-name>
						[Dot42.DexImport("TOY_GAME", "I", AccessFlags = 25)]
						public const int TOY_GAME = 2068;
						/// <java-name>
						/// HEALTH_UNCATEGORIZED
						/// </java-name>
						[Dot42.DexImport("HEALTH_UNCATEGORIZED", "I", AccessFlags = 25)]
						public const int HEALTH_UNCATEGORIZED = 2304;
						/// <java-name>
						/// HEALTH_BLOOD_PRESSURE
						/// </java-name>
						[Dot42.DexImport("HEALTH_BLOOD_PRESSURE", "I", AccessFlags = 25)]
						public const int HEALTH_BLOOD_PRESSURE = 2308;
						/// <java-name>
						/// HEALTH_THERMOMETER
						/// </java-name>
						[Dot42.DexImport("HEALTH_THERMOMETER", "I", AccessFlags = 25)]
						public const int HEALTH_THERMOMETER = 2312;
						/// <java-name>
						/// HEALTH_WEIGHING
						/// </java-name>
						[Dot42.DexImport("HEALTH_WEIGHING", "I", AccessFlags = 25)]
						public const int HEALTH_WEIGHING = 2316;
						/// <java-name>
						/// HEALTH_GLUCOSE
						/// </java-name>
						[Dot42.DexImport("HEALTH_GLUCOSE", "I", AccessFlags = 25)]
						public const int HEALTH_GLUCOSE = 2320;
						/// <java-name>
						/// HEALTH_PULSE_OXIMETER
						/// </java-name>
						[Dot42.DexImport("HEALTH_PULSE_OXIMETER", "I", AccessFlags = 25)]
						public const int HEALTH_PULSE_OXIMETER = 2324;
						/// <java-name>
						/// HEALTH_PULSE_RATE
						/// </java-name>
						[Dot42.DexImport("HEALTH_PULSE_RATE", "I", AccessFlags = 25)]
						public const int HEALTH_PULSE_RATE = 2328;
						/// <java-name>
						/// HEALTH_DATA_DISPLAY
						/// </java-name>
						[Dot42.DexImport("HEALTH_DATA_DISPLAY", "I", AccessFlags = 25)]
						public const int HEALTH_DATA_DISPLAY = 2332;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Device() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// android/bluetooth/BluetoothClass$Device$Major
						/// </java-name>
						[Dot42.DexImport("android/bluetooth/BluetoothClass$Device$Major", AccessFlags = 9)]
						public partial class Major
 /* scope: __dot42__ */ 
						{
								/// <java-name>
								/// MISC
								/// </java-name>
								[Dot42.DexImport("MISC", "I", AccessFlags = 25)]
								public const int MISC = 0;
								/// <java-name>
								/// COMPUTER
								/// </java-name>
								[Dot42.DexImport("COMPUTER", "I", AccessFlags = 25)]
								public const int COMPUTER = 256;
								/// <java-name>
								/// PHONE
								/// </java-name>
								[Dot42.DexImport("PHONE", "I", AccessFlags = 25)]
								public const int PHONE = 512;
								/// <java-name>
								/// NETWORKING
								/// </java-name>
								[Dot42.DexImport("NETWORKING", "I", AccessFlags = 25)]
								public const int NETWORKING = 768;
								/// <java-name>
								/// AUDIO_VIDEO
								/// </java-name>
								[Dot42.DexImport("AUDIO_VIDEO", "I", AccessFlags = 25)]
								public const int AUDIO_VIDEO = 1024;
								/// <java-name>
								/// PERIPHERAL
								/// </java-name>
								[Dot42.DexImport("PERIPHERAL", "I", AccessFlags = 25)]
								public const int PERIPHERAL = 1280;
								/// <java-name>
								/// IMAGING
								/// </java-name>
								[Dot42.DexImport("IMAGING", "I", AccessFlags = 25)]
								public const int IMAGING = 1536;
								/// <java-name>
								/// WEARABLE
								/// </java-name>
								[Dot42.DexImport("WEARABLE", "I", AccessFlags = 25)]
								public const int WEARABLE = 1792;
								/// <java-name>
								/// TOY
								/// </java-name>
								[Dot42.DexImport("TOY", "I", AccessFlags = 25)]
								public const int TOY = 2048;
								/// <java-name>
								/// HEALTH
								/// </java-name>
								[Dot42.DexImport("HEALTH", "I", AccessFlags = 25)]
								public const int HEALTH = 2304;
								/// <java-name>
								/// UNCATEGORIZED
								/// </java-name>
								[Dot42.DexImport("UNCATEGORIZED", "I", AccessFlags = 25)]
								public const int UNCATEGORIZED = 7936;
								[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
								public Major() /* MethodBuilder.Create */ 
								{
								}

						}

				}

				/// <java-name>
				/// android/bluetooth/BluetoothClass$Service
				/// </java-name>
				[Dot42.DexImport("android/bluetooth/BluetoothClass$Service", AccessFlags = 25)]
				public sealed partial class Service
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// LIMITED_DISCOVERABILITY
						/// </java-name>
						[Dot42.DexImport("LIMITED_DISCOVERABILITY", "I", AccessFlags = 25)]
						public const int LIMITED_DISCOVERABILITY = 8192;
						/// <java-name>
						/// POSITIONING
						/// </java-name>
						[Dot42.DexImport("POSITIONING", "I", AccessFlags = 25)]
						public const int POSITIONING = 65536;
						/// <java-name>
						/// NETWORKING
						/// </java-name>
						[Dot42.DexImport("NETWORKING", "I", AccessFlags = 25)]
						public const int NETWORKING = 131072;
						/// <java-name>
						/// RENDER
						/// </java-name>
						[Dot42.DexImport("RENDER", "I", AccessFlags = 25)]
						public const int RENDER = 262144;
						/// <java-name>
						/// CAPTURE
						/// </java-name>
						[Dot42.DexImport("CAPTURE", "I", AccessFlags = 25)]
						public const int CAPTURE = 524288;
						/// <java-name>
						/// OBJECT_TRANSFER
						/// </java-name>
						[Dot42.DexImport("OBJECT_TRANSFER", "I", AccessFlags = 25)]
						public const int OBJECT_TRANSFER = 1048576;
						/// <java-name>
						/// AUDIO
						/// </java-name>
						[Dot42.DexImport("AUDIO", "I", AccessFlags = 25)]
						public const int AUDIO = 2097152;
						/// <java-name>
						/// TELEPHONY
						/// </java-name>
						[Dot42.DexImport("TELEPHONY", "I", AccessFlags = 25)]
						public const int TELEPHONY = 4194304;
						/// <java-name>
						/// INFORMATION
						/// </java-name>
						[Dot42.DexImport("INFORMATION", "I", AccessFlags = 25)]
						public const int INFORMATION = 8388608;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Service() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothDevice
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothDevice", AccessFlags = 49)]
		public sealed partial class BluetoothDevice : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ERROR
				/// </java-name>
				[Dot42.DexImport("ERROR", "I", AccessFlags = 25)]
				public const int ERROR = -2147483648;
				/// <java-name>
				/// ACTION_FOUND
				/// </java-name>
				[Dot42.DexImport("ACTION_FOUND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_FOUND = "android.bluetooth.device.action.FOUND";
				/// <java-name>
				/// ACTION_CLASS_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CLASS_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CLASS_CHANGED = "android.bluetooth.device.action.CLASS_CHANGED";
				/// <java-name>
				/// ACTION_ACL_CONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_ACL_CONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ACL_CONNECTED = "android.bluetooth.device.action.ACL_CONNECTED";
				/// <java-name>
				/// ACTION_ACL_DISCONNECT_REQUESTED
				/// </java-name>
				[Dot42.DexImport("ACTION_ACL_DISCONNECT_REQUESTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ACL_DISCONNECT_REQUESTED = "android.bluetooth.device.action.ACL_DISCONNECT_REQUESTED";
				/// <java-name>
				/// ACTION_ACL_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("ACTION_ACL_DISCONNECTED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ACL_DISCONNECTED = "android.bluetooth.device.action.ACL_DISCONNECTED";
				/// <java-name>
				/// ACTION_NAME_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_NAME_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NAME_CHANGED = "android.bluetooth.device.action.NAME_CHANGED";
				/// <java-name>
				/// ACTION_BOND_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_BOND_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_BOND_STATE_CHANGED = "android.bluetooth.device.action.BOND_STATE_CHANGED";
				/// <java-name>
				/// EXTRA_DEVICE
				/// </java-name>
				[Dot42.DexImport("EXTRA_DEVICE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_DEVICE = "android.bluetooth.device.extra.DEVICE";
				/// <java-name>
				/// EXTRA_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NAME = "android.bluetooth.device.extra.NAME";
				/// <java-name>
				/// EXTRA_RSSI
				/// </java-name>
				[Dot42.DexImport("EXTRA_RSSI", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_RSSI = "android.bluetooth.device.extra.RSSI";
				/// <java-name>
				/// EXTRA_CLASS
				/// </java-name>
				[Dot42.DexImport("EXTRA_CLASS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CLASS = "android.bluetooth.device.extra.CLASS";
				/// <java-name>
				/// EXTRA_BOND_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_BOND_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_BOND_STATE = "android.bluetooth.device.extra.BOND_STATE";
				/// <java-name>
				/// EXTRA_PREVIOUS_BOND_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_BOND_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_BOND_STATE = "android.bluetooth.device.extra.PREVIOUS_BOND_STATE";
				/// <java-name>
				/// BOND_NONE
				/// </java-name>
				[Dot42.DexImport("BOND_NONE", "I", AccessFlags = 25)]
				public const int BOND_NONE = 10;
				/// <java-name>
				/// BOND_BONDING
				/// </java-name>
				[Dot42.DexImport("BOND_BONDING", "I", AccessFlags = 25)]
				public const int BOND_BONDING = 11;
				/// <java-name>
				/// BOND_BONDED
				/// </java-name>
				[Dot42.DexImport("BOND_BONDED", "I", AccessFlags = 25)]
				public const int BOND_BONDED = 12;
				/// <java-name>
				/// ACTION_UUID
				/// </java-name>
				[Dot42.DexImport("ACTION_UUID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_UUID = "android.bluetooth.device.action.UUID";
				/// <java-name>
				/// EXTRA_UUID
				/// </java-name>
				[Dot42.DexImport("EXTRA_UUID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_UUID = "android.bluetooth.device.extra.UUID";
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Bluetooth.BluetoothDevice> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothDevice() /* MethodBuilder.Create */ 
				{
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

				/// <java-name>
				/// fetchUuidsWithSdp
				/// </java-name>
				[Dot42.DexImport("fetchUuidsWithSdp", "()Z", AccessFlags = 1)]
				public bool FetchUuidsWithSdp() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createRfcommSocketToServiceRecord
				/// </java-name>
				[Dot42.DexImport("createRfcommSocketToServiceRecord", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothSocket CreateRfcommSocketToServiceRecord(global::Java.Util.UUID uUID) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothSocket);
				}

				/// <java-name>
				/// createInsecureRfcommSocketToServiceRecord
				/// </java-name>
				[Dot42.DexImport("createInsecureRfcommSocketToServiceRecord", "(Ljava/util/UUID;)Landroid/bluetooth/BluetoothSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothSocket CreateInsecureRfcommSocketToServiceRecord(global::Java.Util.UUID uUID) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothSocket);
				}

				/// <java-name>
				/// getAddress
				/// </java-name>
				public string Address
				{
						[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getBondState
				/// </java-name>
				public int BondState
				{
						[Dot42.DexImport("getBondState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBluetoothClass
				/// </java-name>
				public global::Android.Bluetooth.BluetoothClass BluetoothClass
				{
						[Dot42.DexImport("getBluetoothClass", "()Landroid/bluetooth/BluetoothClass;", AccessFlags = 1)]
						get{ return default(global::Android.Bluetooth.BluetoothClass); }
				}

				/// <java-name>
				/// getUuids
				/// </java-name>
				public global::Android.OS.ParcelUuid[] Uuids
				{
						[Dot42.DexImport("getUuids", "()[Landroid/os/ParcelUuid;", AccessFlags = 1)]
						get{ return default(global::Android.OS.ParcelUuid[]); }
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothHeadset
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothHeadset", AccessFlags = 49)]
		public sealed partial class BluetoothHeadset : global::Android.Bluetooth.IBluetoothProfile
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_CONNECTION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_CONNECTION_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_CONNECTION_STATE_CHANGED = "android.bluetooth.headset.profile.action.CONNECTION_STATE_CHANGED";
				/// <java-name>
				/// ACTION_AUDIO_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_AUDIO_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_AUDIO_STATE_CHANGED = "android.bluetooth.headset.profile.action.AUDIO_STATE_CHANGED";
				/// <java-name>
				/// ACTION_VENDOR_SPECIFIC_HEADSET_EVENT
				/// </java-name>
				[Dot42.DexImport("ACTION_VENDOR_SPECIFIC_HEADSET_EVENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_VENDOR_SPECIFIC_HEADSET_EVENT = "android.bluetooth.headset.action.VENDOR_SPECIFIC_HEADSET_EVENT";
				/// <java-name>
				/// EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD
				/// </java-name>
				[Dot42.DexImport("EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD = "android.bluetooth.headset.extra.VENDOR_SPECIFIC_HEADSET_EVENT_CMD";
				/// <java-name>
				/// EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE
				/// </java-name>
				[Dot42.DexImport("EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE = "android.bluetooth.headset.extra.VENDOR_SPECIFIC_HEADSET_EVENT_CMD_TYPE";
				/// <java-name>
				/// AT_CMD_TYPE_READ
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_READ", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_READ = 0;
				/// <java-name>
				/// AT_CMD_TYPE_TEST
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_TEST", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_TEST = 1;
				/// <java-name>
				/// AT_CMD_TYPE_SET
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_SET", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_SET = 2;
				/// <java-name>
				/// AT_CMD_TYPE_BASIC
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_BASIC", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_BASIC = 3;
				/// <java-name>
				/// AT_CMD_TYPE_ACTION
				/// </java-name>
				[Dot42.DexImport("AT_CMD_TYPE_ACTION", "I", AccessFlags = 25)]
				public const int AT_CMD_TYPE_ACTION = 4;
				/// <java-name>
				/// EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS
				/// </java-name>
				[Dot42.DexImport("EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_VENDOR_SPECIFIC_HEADSET_EVENT_ARGS = "android.bluetooth.headset.extra.VENDOR_SPECIFIC_HEADSET_EVENT_ARGS";
				/// <java-name>
				/// VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY
				/// </java-name>
				[Dot42.DexImport("VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VENDOR_SPECIFIC_HEADSET_EVENT_COMPANY_ID_CATEGORY = "android.bluetooth.headset.intent.category.companyid";
				/// <java-name>
				/// STATE_AUDIO_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_AUDIO_DISCONNECTED", "I", AccessFlags = 25)]
				public const int STATE_AUDIO_DISCONNECTED = 10;
				/// <java-name>
				/// STATE_AUDIO_CONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_AUDIO_CONNECTING", "I", AccessFlags = 25)]
				public const int STATE_AUDIO_CONNECTING = 11;
				/// <java-name>
				/// STATE_AUDIO_CONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_AUDIO_CONNECTED", "I", AccessFlags = 25)]
				public const int STATE_AUDIO_CONNECTED = 12;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothHeadset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDevicesMatchingConnectionStates
				/// </java-name>
				[Dot42.DexImport("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", AccessFlags = 1, Signature = "([I)Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>);
				}

				/// <java-name>
				/// getConnectionState
				/// </java-name>
				[Dot42.DexImport("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", AccessFlags = 1)]
				public int GetConnectionState(global::Android.Bluetooth.BluetoothDevice bluetoothDevice) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// startVoiceRecognition
				/// </java-name>
				[Dot42.DexImport("startVoiceRecognition", "(Landroid/bluetooth/BluetoothDevice;)Z", AccessFlags = 1)]
				public bool StartVoiceRecognition(global::Android.Bluetooth.BluetoothDevice bluetoothDevice) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// stopVoiceRecognition
				/// </java-name>
				[Dot42.DexImport("stopVoiceRecognition", "(Landroid/bluetooth/BluetoothDevice;)Z", AccessFlags = 1)]
				public bool StopVoiceRecognition(global::Android.Bluetooth.BluetoothDevice bluetoothDevice) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isAudioConnected
				/// </java-name>
				[Dot42.DexImport("isAudioConnected", "(Landroid/bluetooth/BluetoothDevice;)Z", AccessFlags = 1)]
				public bool IsAudioConnected(global::Android.Bluetooth.BluetoothDevice bluetoothDevice) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> ConnectedDevices
				{
						[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>); }
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothHealth
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothHealth", AccessFlags = 49)]
		public sealed partial class BluetoothHealth : global::Android.Bluetooth.IBluetoothProfile
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SOURCE_ROLE
				/// </java-name>
				[Dot42.DexImport("SOURCE_ROLE", "I", AccessFlags = 25)]
				public const int SOURCE_ROLE = 1;
				/// <java-name>
				/// SINK_ROLE
				/// </java-name>
				[Dot42.DexImport("SINK_ROLE", "I", AccessFlags = 25)]
				public const int SINK_ROLE = 2;
				/// <java-name>
				/// CHANNEL_TYPE_RELIABLE
				/// </java-name>
				[Dot42.DexImport("CHANNEL_TYPE_RELIABLE", "I", AccessFlags = 25)]
				public const int CHANNEL_TYPE_RELIABLE = 10;
				/// <java-name>
				/// CHANNEL_TYPE_STREAMING
				/// </java-name>
				[Dot42.DexImport("CHANNEL_TYPE_STREAMING", "I", AccessFlags = 25)]
				public const int CHANNEL_TYPE_STREAMING = 11;
				/// <java-name>
				/// STATE_CHANNEL_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_CHANNEL_DISCONNECTED", "I", AccessFlags = 25)]
				public const int STATE_CHANNEL_DISCONNECTED = 0;
				/// <java-name>
				/// STATE_CHANNEL_CONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_CHANNEL_CONNECTING", "I", AccessFlags = 25)]
				public const int STATE_CHANNEL_CONNECTING = 1;
				/// <java-name>
				/// STATE_CHANNEL_CONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_CHANNEL_CONNECTED", "I", AccessFlags = 25)]
				public const int STATE_CHANNEL_CONNECTED = 2;
				/// <java-name>
				/// STATE_CHANNEL_DISCONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_CHANNEL_DISCONNECTING", "I", AccessFlags = 25)]
				public const int STATE_CHANNEL_DISCONNECTING = 3;
				/// <java-name>
				/// APP_CONFIG_REGISTRATION_SUCCESS
				/// </java-name>
				[Dot42.DexImport("APP_CONFIG_REGISTRATION_SUCCESS", "I", AccessFlags = 25)]
				public const int APP_CONFIG_REGISTRATION_SUCCESS = 0;
				/// <java-name>
				/// APP_CONFIG_REGISTRATION_FAILURE
				/// </java-name>
				[Dot42.DexImport("APP_CONFIG_REGISTRATION_FAILURE", "I", AccessFlags = 25)]
				public const int APP_CONFIG_REGISTRATION_FAILURE = 1;
				/// <java-name>
				/// APP_CONFIG_UNREGISTRATION_SUCCESS
				/// </java-name>
				[Dot42.DexImport("APP_CONFIG_UNREGISTRATION_SUCCESS", "I", AccessFlags = 25)]
				public const int APP_CONFIG_UNREGISTRATION_SUCCESS = 2;
				/// <java-name>
				/// APP_CONFIG_UNREGISTRATION_FAILURE
				/// </java-name>
				[Dot42.DexImport("APP_CONFIG_UNREGISTRATION_FAILURE", "I", AccessFlags = 25)]
				public const int APP_CONFIG_UNREGISTRATION_FAILURE = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothHealth() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerSinkAppConfiguration
				/// </java-name>
				[Dot42.DexImport("registerSinkAppConfiguration", "(Ljava/lang/String;ILandroid/bluetooth/BluetoothHealthCallback;)Z", AccessFlags = 1)]
				public bool RegisterSinkAppConfiguration(string @string, int int32, global::Android.Bluetooth.BluetoothHealthCallback bluetoothHealthCallback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// unregisterAppConfiguration
				/// </java-name>
				[Dot42.DexImport("unregisterAppConfiguration", "(Landroid/bluetooth/BluetoothHealthAppConfiguration;)Z", AccessFlags = 1)]
				public bool UnregisterAppConfiguration(global::Android.Bluetooth.BluetoothHealthAppConfiguration bluetoothHealthAppConfiguration) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// connectChannelToSource
				/// </java-name>
				[Dot42.DexImport("connectChannelToSource", "(Landroid/bluetooth/BluetoothDevice;Landroid/bluetooth/BluetoothHealthAppConfigur" +
    "ation;)Z", AccessFlags = 1)]
				public bool ConnectChannelToSource(global::Android.Bluetooth.BluetoothDevice bluetoothDevice, global::Android.Bluetooth.BluetoothHealthAppConfiguration bluetoothHealthAppConfiguration) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// disconnectChannel
				/// </java-name>
				[Dot42.DexImport("disconnectChannel", "(Landroid/bluetooth/BluetoothDevice;Landroid/bluetooth/BluetoothHealthAppConfigur" +
    "ation;I)Z", AccessFlags = 1)]
				public bool DisconnectChannel(global::Android.Bluetooth.BluetoothDevice bluetoothDevice, global::Android.Bluetooth.BluetoothHealthAppConfiguration bluetoothHealthAppConfiguration, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMainChannelFd
				/// </java-name>
				[Dot42.DexImport("getMainChannelFd", "(Landroid/bluetooth/BluetoothDevice;Landroid/bluetooth/BluetoothHealthAppConfigur" +
    "ation;)Landroid/os/ParcelFileDescriptor;", AccessFlags = 1)]
				public global::Android.OS.ParcelFileDescriptor GetMainChannelFd(global::Android.Bluetooth.BluetoothDevice bluetoothDevice, global::Android.Bluetooth.BluetoothHealthAppConfiguration bluetoothHealthAppConfiguration) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.ParcelFileDescriptor);
				}

				/// <java-name>
				/// getConnectionState
				/// </java-name>
				[Dot42.DexImport("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", AccessFlags = 1)]
				public int GetConnectionState(global::Android.Bluetooth.BluetoothDevice bluetoothDevice) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDevicesMatchingConnectionStates
				/// </java-name>
				[Dot42.DexImport("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", AccessFlags = 1, Signature = "([I)Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>);
				}

				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				public global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> ConnectedDevices
				{
						[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice>); }
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothHealthAppConfiguration
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothHealthAppConfiguration", AccessFlags = 49)]
		public sealed partial class BluetoothHealthAppConfiguration : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Bluetooth.BluetoothHealthAppConfiguration> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothHealthAppConfiguration() /* MethodBuilder.Create */ 
				{
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

				/// <java-name>
				/// getDataType
				/// </java-name>
				public int DataType
				{
						[Dot42.DexImport("getDataType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRole
				/// </java-name>
				public int Role
				{
						[Dot42.DexImport("getRole", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothHealthCallback
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothHealthCallback", AccessFlags = 1057)]
		public abstract partial class BluetoothHealthCallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BluetoothHealthCallback() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onHealthAppConfigurationStatusChange
				/// </java-name>
				[Dot42.DexImport("onHealthAppConfigurationStatusChange", "(Landroid/bluetooth/BluetoothHealthAppConfiguration;I)V", AccessFlags = 1)]
				public virtual void OnHealthAppConfigurationStatusChange(global::Android.Bluetooth.BluetoothHealthAppConfiguration bluetoothHealthAppConfiguration, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onHealthChannelStateChange
				/// </java-name>
				[Dot42.DexImport("onHealthChannelStateChange", "(Landroid/bluetooth/BluetoothHealthAppConfiguration;Landroid/bluetooth/BluetoothD" +
    "evice;IILandroid/os/ParcelFileDescriptor;I)V", AccessFlags = 1)]
				public virtual void OnHealthChannelStateChange(global::Android.Bluetooth.BluetoothHealthAppConfiguration bluetoothHealthAppConfiguration, global::Android.Bluetooth.BluetoothDevice bluetoothDevice, int int32, int int321, global::Android.OS.ParcelFileDescriptor parcelFileDescriptor, int int322) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothServerSocket
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothServerSocket", AccessFlags = 49)]
		public sealed partial class BluetoothServerSocket : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothServerSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "()Landroid/bluetooth/BluetoothSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothSocket Accept() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothSocket);
				}

				/// <java-name>
				/// accept
				/// </java-name>
				[Dot42.DexImport("accept", "(I)Landroid/bluetooth/BluetoothSocket;", AccessFlags = 1)]
				public global::Android.Bluetooth.BluetoothSocket Accept(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Bluetooth.BluetoothSocket);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothSocket
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothSocket", AccessFlags = 49)]
		public sealed partial class BluetoothSocket : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BluetoothSocket() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1)]
				public void Connect() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRemoteDevice
				/// </java-name>
				public global::Android.Bluetooth.BluetoothDevice RemoteDevice
				{
						[Dot42.DexImport("getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;", AccessFlags = 1)]
						get{ return default(global::Android.Bluetooth.BluetoothDevice); }
				}

				/// <java-name>
				/// getInputStream
				/// </java-name>
				public global::Java.Io.InputStream InputStream
				{
						[Dot42.DexImport("getInputStream", "()Ljava/io/InputStream;", AccessFlags = 1)]
						get{ return default(global::Java.Io.InputStream); }
				}

				/// <java-name>
				/// getOutputStream
				/// </java-name>
				public global::Java.Io.OutputStream OutputStream
				{
						[Dot42.DexImport("getOutputStream", "()Ljava/io/OutputStream;", AccessFlags = 1)]
						get{ return default(global::Java.Io.OutputStream); }
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				public bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothProfile
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothProfile", AccessFlags = 1537)]
		public partial interface IBluetoothProfile
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getDevicesMatchingConnectionStates
				/// </java-name>
				[Dot42.DexImport("getDevicesMatchingConnectionStates", "([I)Ljava/util/List;", AccessFlags = 1025, Signature = "([I)Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
				global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> GetDevicesMatchingConnectionStates(int[] int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConnectionState
				/// </java-name>
				[Dot42.DexImport("getConnectionState", "(Landroid/bluetooth/BluetoothDevice;)I", AccessFlags = 1025)]
				int GetConnectionState(global::Android.Bluetooth.BluetoothDevice bluetoothDevice) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getConnectedDevices
				/// </java-name>
				global::Java.Util.IList<global::Android.Bluetooth.BluetoothDevice> ConnectedDevices
				{
						[Dot42.DexImport("getConnectedDevices", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<Landroid/bluetooth/BluetoothDevice;>;")]
						get;
				}

		}

		/// <java-name>
		/// android/bluetooth/BluetoothProfile$ServiceListener
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothProfile$ServiceListener", AccessFlags = 1545)]
		public partial interface IBluetoothProfile_IServiceListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onServiceConnected
				/// </java-name>
				[Dot42.DexImport("onServiceConnected", "(ILandroid/bluetooth/BluetoothProfile;)V", AccessFlags = 1025)]
				void OnServiceConnected(int int32, global::Android.Bluetooth.IBluetoothProfile bluetoothProfile) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onServiceDisconnected
				/// </java-name>
				[Dot42.DexImport("onServiceDisconnected", "(I)V", AccessFlags = 1025)]
				void OnServiceDisconnected(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/bluetooth/BluetoothProfile
		/// </java-name>
		[Dot42.DexImport("android/bluetooth/BluetoothProfile", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IBluetoothProfileConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EXTRA_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STATE = "android.bluetooth.profile.extra.STATE";
				/// <java-name>
				/// EXTRA_PREVIOUS_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_PREVIOUS_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PREVIOUS_STATE = "android.bluetooth.profile.extra.PREVIOUS_STATE";
				/// <java-name>
				/// STATE_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_DISCONNECTED", "I", AccessFlags = 25)]
				public const int STATE_DISCONNECTED = 0;
				/// <java-name>
				/// STATE_CONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_CONNECTING", "I", AccessFlags = 25)]
				public const int STATE_CONNECTING = 1;
				/// <java-name>
				/// STATE_CONNECTED
				/// </java-name>
				[Dot42.DexImport("STATE_CONNECTED", "I", AccessFlags = 25)]
				public const int STATE_CONNECTED = 2;
				/// <java-name>
				/// STATE_DISCONNECTING
				/// </java-name>
				[Dot42.DexImport("STATE_DISCONNECTING", "I", AccessFlags = 25)]
				public const int STATE_DISCONNECTING = 3;
				/// <java-name>
				/// HEADSET
				/// </java-name>
				[Dot42.DexImport("HEADSET", "I", AccessFlags = 25)]
				public const int HEADSET = 1;
				/// <java-name>
				/// A2DP
				/// </java-name>
				[Dot42.DexImport("A2DP", "I", AccessFlags = 25)]
				public const int A2DP = 2;
				/// <java-name>
				/// HEALTH
				/// </java-name>
				[Dot42.DexImport("HEALTH", "I", AccessFlags = 25)]
				public const int HEALTH = 3;
		}

}

