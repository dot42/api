#pragma warning disable 1717
namespace Android.Nfc
{
		/// <java-name>
		/// android/nfc/FormatException
		/// </java-name>
		[Dot42.DexImport("android/nfc/FormatException", AccessFlags = 33)]
		public partial class FormatException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FormatException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public FormatException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/nfc/NdefMessage
		/// </java-name>
		[Dot42.DexImport("android/nfc/NdefMessage", AccessFlags = 49)]
		public sealed partial class NdefMessage : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Nfc.NdefMessage> CREATOR;
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public NdefMessage(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NdefMessage(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Landroid/nfc/NdefRecord;)V", AccessFlags = 1)]
				public NdefMessage(global::Android.Nfc.NdefRecord[] ndefRecord) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRecords
				/// </java-name>
				[Dot42.DexImport("getRecords", "()[Landroid/nfc/NdefRecord;", AccessFlags = 1)]
				public global::Android.Nfc.NdefRecord[] GetRecords() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NdefMessage() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRecords
				/// </java-name>
				public global::Android.Nfc.NdefRecord[] Records
				{
				[Dot42.DexImport("getRecords", "()[Landroid/nfc/NdefRecord;", AccessFlags = 1)]
						get{ return GetRecords(); }
				}

		}

		/// <java-name>
		/// android/nfc/NdefRecord
		/// </java-name>
		[Dot42.DexImport("android/nfc/NdefRecord", AccessFlags = 49)]
		public sealed partial class NdefRecord : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TNF_EMPTY
				/// </java-name>
				[Dot42.DexImport("TNF_EMPTY", "S", AccessFlags = 25)]
				public const short TNF_EMPTY = 0;
				/// <java-name>
				/// TNF_WELL_KNOWN
				/// </java-name>
				[Dot42.DexImport("TNF_WELL_KNOWN", "S", AccessFlags = 25)]
				public const short TNF_WELL_KNOWN = 1;
				/// <java-name>
				/// TNF_MIME_MEDIA
				/// </java-name>
				[Dot42.DexImport("TNF_MIME_MEDIA", "S", AccessFlags = 25)]
				public const short TNF_MIME_MEDIA = 2;
				/// <java-name>
				/// TNF_ABSOLUTE_URI
				/// </java-name>
				[Dot42.DexImport("TNF_ABSOLUTE_URI", "S", AccessFlags = 25)]
				public const short TNF_ABSOLUTE_URI = 3;
				/// <java-name>
				/// TNF_EXTERNAL_TYPE
				/// </java-name>
				[Dot42.DexImport("TNF_EXTERNAL_TYPE", "S", AccessFlags = 25)]
				public const short TNF_EXTERNAL_TYPE = 4;
				/// <java-name>
				/// TNF_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("TNF_UNKNOWN", "S", AccessFlags = 25)]
				public const short TNF_UNKNOWN = 5;
				/// <java-name>
				/// TNF_UNCHANGED
				/// </java-name>
				[Dot42.DexImport("TNF_UNCHANGED", "S", AccessFlags = 25)]
				public const short TNF_UNCHANGED = 6;
				/// <java-name>
				/// RTD_TEXT
				/// </java-name>
				[Dot42.DexImport("RTD_TEXT", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_TEXT;
				/// <java-name>
				/// RTD_URI
				/// </java-name>
				[Dot42.DexImport("RTD_URI", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_URI;
				/// <java-name>
				/// RTD_SMART_POSTER
				/// </java-name>
				[Dot42.DexImport("RTD_SMART_POSTER", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_SMART_POSTER;
				/// <java-name>
				/// RTD_ALTERNATIVE_CARRIER
				/// </java-name>
				[Dot42.DexImport("RTD_ALTERNATIVE_CARRIER", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_ALTERNATIVE_CARRIER;
				/// <java-name>
				/// RTD_HANDOVER_CARRIER
				/// </java-name>
				[Dot42.DexImport("RTD_HANDOVER_CARRIER", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_HANDOVER_CARRIER;
				/// <java-name>
				/// RTD_HANDOVER_REQUEST
				/// </java-name>
				[Dot42.DexImport("RTD_HANDOVER_REQUEST", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_HANDOVER_REQUEST;
				/// <java-name>
				/// RTD_HANDOVER_SELECT
				/// </java-name>
				[Dot42.DexImport("RTD_HANDOVER_SELECT", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_HANDOVER_SELECT;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Nfc.NdefRecord> CREATOR;
				[Dot42.DexImport("<init>", "(S[B[B[B)V", AccessFlags = 1)]
				public NdefRecord(short int16, sbyte[] sByte, sbyte[] sByte1, sbyte[] sByte2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(S[B[B[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NdefRecord(short int16, byte[] @byte, byte[] byte1, byte[] byte2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public NdefRecord(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NdefRecord(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTnf
				/// </java-name>
				[Dot42.DexImport("getTnf", "()S", AccessFlags = 1)]
				public short GetTnf() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetType() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetTypeJava() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetId() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetId() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getPayload
				/// </java-name>
				[Dot42.DexImport("getPayload", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetPayload() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getPayload
				/// </java-name>
				[Dot42.DexImport("getPayload", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetPayload() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// createApplicationRecord
				/// </java-name>
				[Dot42.DexImport("createApplicationRecord", "(Ljava/lang/String;)Landroid/nfc/NdefRecord;", AccessFlags = 9)]
				public static global::Android.Nfc.NdefRecord CreateApplicationRecord(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <java-name>
				/// createUri
				/// </java-name>
				[Dot42.DexImport("createUri", "(Landroid/net/Uri;)Landroid/nfc/NdefRecord;", AccessFlags = 9)]
				public static global::Android.Nfc.NdefRecord CreateUri(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <java-name>
				/// createUri
				/// </java-name>
				[Dot42.DexImport("createUri", "(Ljava/lang/String;)Landroid/nfc/NdefRecord;", AccessFlags = 9)]
				public static global::Android.Nfc.NdefRecord CreateUri(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NdefRecord() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTnf
				/// </java-name>
				public short Tnf
				{
				[Dot42.DexImport("getTnf", "()S", AccessFlags = 1)]
						get{ return GetTnf(); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public byte[] Type
				{
				[Dot42.DexImport("getType", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetTypeJava(); }
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public byte[] Id
				{
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getPayload
				/// </java-name>
				public byte[] Payload
				{
				[Dot42.DexImport("getPayload", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetPayload(); }
				}

		}

		/// <java-name>
		/// android/nfc/NfcAdapter
		/// </java-name>
		[Dot42.DexImport("android/nfc/NfcAdapter", AccessFlags = 49)]
		public sealed partial class NfcAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_NDEF_DISCOVERED
				/// </java-name>
				[Dot42.DexImport("ACTION_NDEF_DISCOVERED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NDEF_DISCOVERED = "android.nfc.action.NDEF_DISCOVERED";
				/// <java-name>
				/// ACTION_TECH_DISCOVERED
				/// </java-name>
				[Dot42.DexImport("ACTION_TECH_DISCOVERED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TECH_DISCOVERED = "android.nfc.action.TECH_DISCOVERED";
				/// <java-name>
				/// ACTION_TAG_DISCOVERED
				/// </java-name>
				[Dot42.DexImport("ACTION_TAG_DISCOVERED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TAG_DISCOVERED = "android.nfc.action.TAG_DISCOVERED";
				/// <java-name>
				/// EXTRA_TAG
				/// </java-name>
				[Dot42.DexImport("EXTRA_TAG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TAG = "android.nfc.extra.TAG";
				/// <java-name>
				/// EXTRA_NDEF_MESSAGES
				/// </java-name>
				[Dot42.DexImport("EXTRA_NDEF_MESSAGES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NDEF_MESSAGES = "android.nfc.extra.NDEF_MESSAGES";
				/// <java-name>
				/// EXTRA_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ID = "android.nfc.extra.ID";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NfcAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				[Dot42.DexImport("getDefaultAdapter", "(Landroid/content/Context;)Landroid/nfc/NfcAdapter;", AccessFlags = 9)]
				public static global::Android.Nfc.NfcAdapter GetDefaultAdapter(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NfcAdapter);
				}

				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				[Dot42.DexImport("getDefaultAdapter", "()Landroid/nfc/NfcAdapter;", AccessFlags = 9)]
				public static global::Android.Nfc.NfcAdapter GetDefaultAdapter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NfcAdapter);
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setNdefPushMessage
				/// </java-name>
				[Dot42.DexImport("setNdefPushMessage", "(Landroid/nfc/NdefMessage;Landroid/app/Activity;[Landroid/app/Activity;)V", AccessFlags = 129)]
				public void SetNdefPushMessage(global::Android.Nfc.NdefMessage ndefMessage, global::Android.App.Activity activity, params global::Android.App.Activity[] activity1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNdefPushMessageCallback
				/// </java-name>
				[Dot42.DexImport("setNdefPushMessageCallback", "(Landroid/nfc/NfcAdapter$CreateNdefMessageCallback;Landroid/app/Activity;[Landroi" +
    "d/app/Activity;)V", AccessFlags = 129)]
				public void SetNdefPushMessageCallback(global::Android.Nfc.NfcAdapter.ICreateNdefMessageCallback createNdefMessageCallback, global::Android.App.Activity activity, params global::Android.App.Activity[] activity1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnNdefPushCompleteCallback
				/// </java-name>
				[Dot42.DexImport("setOnNdefPushCompleteCallback", "(Landroid/nfc/NfcAdapter$OnNdefPushCompleteCallback;Landroid/app/Activity;[Landro" +
    "id/app/Activity;)V", AccessFlags = 129)]
				public void SetOnNdefPushCompleteCallback(global::Android.Nfc.NfcAdapter.IOnNdefPushCompleteCallback onNdefPushCompleteCallback, global::Android.App.Activity activity, params global::Android.App.Activity[] activity1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableForegroundDispatch
				/// </java-name>
				[Dot42.DexImport("enableForegroundDispatch", "(Landroid/app/Activity;Landroid/app/PendingIntent;[Landroid/content/IntentFilter;" +
    "[[Ljava/lang/String;)V", AccessFlags = 1)]
				public void EnableForegroundDispatch(global::Android.App.Activity activity, global::Android.App.PendingIntent pendingIntent, global::Android.Content.IntentFilter[] intentFilter, string[][] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disableForegroundDispatch
				/// </java-name>
				[Dot42.DexImport("disableForegroundDispatch", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public void DisableForegroundDispatch(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enableForegroundNdefPush
				/// </java-name>
				[Dot42.DexImport("enableForegroundNdefPush", "(Landroid/app/Activity;Landroid/nfc/NdefMessage;)V", AccessFlags = 1)]
				public void EnableForegroundNdefPush(global::Android.App.Activity activity, global::Android.Nfc.NdefMessage ndefMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disableForegroundNdefPush
				/// </java-name>
				[Dot42.DexImport("disableForegroundNdefPush", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public void DisableForegroundNdefPush(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				public static global::Android.Nfc.NfcAdapter DefaultAdapter
				{
				[Dot42.DexImport("getDefaultAdapter", "()Landroid/nfc/NfcAdapter;", AccessFlags = 9)]
						get{ return GetDefaultAdapter(); }
				}

				/// <java-name>
				/// android/nfc/NfcAdapter$CreateNdefMessageCallback
				/// </java-name>
				[Dot42.DexImport("android/nfc/NfcAdapter$CreateNdefMessageCallback", AccessFlags = 1545)]
				public partial interface ICreateNdefMessageCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// createNdefMessage
						/// </java-name>
						[Dot42.DexImport("createNdefMessage", "(Landroid/nfc/NfcEvent;)Landroid/nfc/NdefMessage;", AccessFlags = 1025)]
						global::Android.Nfc.NdefMessage CreateNdefMessage(global::Android.Nfc.NfcEvent nfcEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/nfc/NfcAdapter$OnNdefPushCompleteCallback
				/// </java-name>
				[Dot42.DexImport("android/nfc/NfcAdapter$OnNdefPushCompleteCallback", AccessFlags = 1545)]
				public partial interface IOnNdefPushCompleteCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onNdefPushComplete
						/// </java-name>
						[Dot42.DexImport("onNdefPushComplete", "(Landroid/nfc/NfcEvent;)V", AccessFlags = 1025)]
						void OnNdefPushComplete(global::Android.Nfc.NfcEvent nfcEvent) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/nfc/NfcEvent
		/// </java-name>
		[Dot42.DexImport("android/nfc/NfcEvent", AccessFlags = 49)]
		public sealed partial class NfcEvent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// nfcAdapter
				/// </java-name>
				[Dot42.DexImport("nfcAdapter", "Landroid/nfc/NfcAdapter;", AccessFlags = 17)]
				public readonly global::Android.Nfc.NfcAdapter NfcAdapter;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NfcEvent() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/nfc/NfcManager
		/// </java-name>
		[Dot42.DexImport("android/nfc/NfcManager", AccessFlags = 49)]
		public sealed partial class NfcManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NfcManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				[Dot42.DexImport("getDefaultAdapter", "()Landroid/nfc/NfcAdapter;", AccessFlags = 1)]
				public global::Android.Nfc.NfcAdapter GetDefaultAdapter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NfcAdapter);
				}

				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				public global::Android.Nfc.NfcAdapter DefaultAdapter
				{
				[Dot42.DexImport("getDefaultAdapter", "()Landroid/nfc/NfcAdapter;", AccessFlags = 1)]
						get{ return GetDefaultAdapter(); }
				}

		}

		/// <java-name>
		/// android/nfc/Tag
		/// </java-name>
		[Dot42.DexImport("android/nfc/Tag", AccessFlags = 49)]
		public sealed partial class Tag : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Nfc.Tag> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Tag() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetId() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetId() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getTechList
				/// </java-name>
				[Dot42.DexImport("getTechList", "()[Ljava/lang/String;", AccessFlags = 1)]
				public string[] GetTechList() /* MethodBuilder.Create */ 
				{
						return default(string[]);
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
				/// getId
				/// </java-name>
				public byte[] Id
				{
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getTechList
				/// </java-name>
				public string[] TechList
				{
				[Dot42.DexImport("getTechList", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTechList(); }
				}

		}

		/// <java-name>
		/// android/nfc/TagLostException
		/// </java-name>
		[Dot42.DexImport("android/nfc/TagLostException", AccessFlags = 33)]
		public partial class TagLostException : global::System.IO.IOException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TagLostException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TagLostException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

}

