#pragma warning disable 1717
namespace Android.Telephony
{
		/// <java-name>
		/// android/telephony/CellLocation
		/// </java-name>
		[Dot42.DexImport("android/telephony/CellLocation", AccessFlags = 1057)]
		public abstract partial class CellLocation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CellLocation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLocationUpdate
				/// </java-name>
				[Dot42.DexImport("requestLocationUpdate", "()V", AccessFlags = 9)]
				public static void RequestLocationUpdate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEmpty
				/// </java-name>
				public static global::Android.Telephony.CellLocation Empty
				{
						[Dot42.DexImport("getEmpty", "()Landroid/telephony/CellLocation;", AccessFlags = 9)]
						get{ return default(global::Android.Telephony.CellLocation); }
				}

		}

		/// <java-name>
		/// android/telephony/NeighboringCellInfo
		/// </java-name>
		[Dot42.DexImport("android/telephony/NeighboringCellInfo", AccessFlags = 33)]
		public partial class NeighboringCellInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNKNOWN_RSSI
				/// </java-name>
				[Dot42.DexImport("UNKNOWN_RSSI", "I", AccessFlags = 25)]
				public const int UNKNOWN_RSSI = 99;
				/// <java-name>
				/// UNKNOWN_CID
				/// </java-name>
				[Dot42.DexImport("UNKNOWN_CID", "I", AccessFlags = 25)]
				public const int UNKNOWN_CID = -1;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.NeighboringCellInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NeighboringCellInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public NeighboringCellInfo(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ILjava/lang/String;I)V", AccessFlags = 1)]
				public NeighboringCellInfo(int int32, string @string, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public NeighboringCellInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getRssi
				/// </java-name>
				public virtual int Rssi
				{
						[Dot42.DexImport("getRssi", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRssi", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLac
				/// </java-name>
				public virtual int Lac
				{
						[Dot42.DexImport("getLac", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCid
				/// </java-name>
				public virtual int Cid
				{
						[Dot42.DexImport("getCid", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCid", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPsc
				/// </java-name>
				public virtual int Psc
				{
						[Dot42.DexImport("getPsc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getNetworkType
				/// </java-name>
				public virtual int NetworkType
				{
						[Dot42.DexImport("getNetworkType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/telephony/PhoneNumberFormattingTextWatcher
		/// </java-name>
		[Dot42.DexImport("android/telephony/PhoneNumberFormattingTextWatcher", AccessFlags = 33)]
		public partial class PhoneNumberFormattingTextWatcher : global::Android.Text.ITextWatcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PhoneNumberFormattingTextWatcher() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beforeTextChanged
				/// </java-name>
				[Dot42.DexImport("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void BeforeTextChanged(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void OnTextChanged(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// afterTextChanged
				/// </java-name>
				[Dot42.DexImport("afterTextChanged", "(Landroid/text/Editable;)V", AccessFlags = 33)]
				public virtual void AfterTextChanged(global::Android.Text.IEditable editable) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/telephony/PhoneNumberUtils
		/// </java-name>
		[Dot42.DexImport("android/telephony/PhoneNumberUtils", AccessFlags = 33)]
		public partial class PhoneNumberUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PAUSE
				/// </java-name>
				[Dot42.DexImport("PAUSE", "C", AccessFlags = 25)]
				public const char PAUSE = ',';
				/// <java-name>
				/// WAIT
				/// </java-name>
				[Dot42.DexImport("WAIT", "C", AccessFlags = 25)]
				public const char WAIT = ';';
				/// <java-name>
				/// WILD
				/// </java-name>
				[Dot42.DexImport("WILD", "C", AccessFlags = 25)]
				public const char WILD = 'N';
				/// <java-name>
				/// TOA_International
				/// </java-name>
				[Dot42.DexImport("TOA_International", "I", AccessFlags = 25)]
				public const int TOA_International = 145;
				/// <java-name>
				/// TOA_Unknown
				/// </java-name>
				[Dot42.DexImport("TOA_Unknown", "I", AccessFlags = 25)]
				public const int TOA_Unknown = 129;
				/// <java-name>
				/// FORMAT_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("FORMAT_UNKNOWN", "I", AccessFlags = 25)]
				public const int FORMAT_UNKNOWN = 0;
				/// <java-name>
				/// FORMAT_NANP
				/// </java-name>
				[Dot42.DexImport("FORMAT_NANP", "I", AccessFlags = 25)]
				public const int FORMAT_NANP = 1;
				/// <java-name>
				/// FORMAT_JAPAN
				/// </java-name>
				[Dot42.DexImport("FORMAT_JAPAN", "I", AccessFlags = 25)]
				public const int FORMAT_JAPAN = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PhoneNumberUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isISODigit
				/// </java-name>
				[Dot42.DexImport("isISODigit", "(C)Z", AccessFlags = 9)]
				public static bool IsISODigit(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// is12Key
				/// </java-name>
				[Dot42.DexImport("is12Key", "(C)Z", AccessFlags = 25)]
				public static bool Is12Key(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDialable
				/// </java-name>
				[Dot42.DexImport("isDialable", "(C)Z", AccessFlags = 25)]
				public static bool IsDialable(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isReallyDialable
				/// </java-name>
				[Dot42.DexImport("isReallyDialable", "(C)Z", AccessFlags = 25)]
				public static bool IsReallyDialable(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNonSeparator
				/// </java-name>
				[Dot42.DexImport("isNonSeparator", "(C)Z", AccessFlags = 25)]
				public static bool IsNonSeparator(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isStartsPostDial
				/// </java-name>
				[Dot42.DexImport("isStartsPostDial", "(C)Z", AccessFlags = 25)]
				public static bool IsStartsPostDial(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getNumberFromIntent
				/// </java-name>
				[Dot42.DexImport("getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetNumberFromIntent(global::Android.Content.Intent intent, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// extractNetworkPortion
				/// </java-name>
				[Dot42.DexImport("extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ExtractNetworkPortion(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// stripSeparators
				/// </java-name>
				[Dot42.DexImport("stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string StripSeparators(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// extractPostDialPortion
				/// </java-name>
				[Dot42.DexImport("extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ExtractPostDialPortion(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool Compare(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool Compare(global::Android.Content.Context context, string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toCallerIDMinMatch
				/// </java-name>
				[Dot42.DexImport("toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToCallerIDMinMatch(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getStrippedReversed
				/// </java-name>
				[Dot42.DexImport("getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetStrippedReversed(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// stringFromStringAndTOA
				/// </java-name>
				[Dot42.DexImport("stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;", AccessFlags = 9)]
				public static string StringFromStringAndTOA(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toaFromString
				/// </java-name>
				[Dot42.DexImport("toaFromString", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int ToaFromString(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// calledPartyBCDToString
				/// </java-name>
				[Dot42.DexImport("calledPartyBCDToString", "([BII)Ljava/lang/String;", AccessFlags = 9)]
				public static string CalledPartyBCDToString(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// calledPartyBCDToString
				/// </java-name>
				[Dot42.DexImport("calledPartyBCDToString", "([BII)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string CalledPartyBCDToString(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// calledPartyBCDFragmentToString
				/// </java-name>
				[Dot42.DexImport("calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;", AccessFlags = 9)]
				public static string CalledPartyBCDFragmentToString(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// calledPartyBCDFragmentToString
				/// </java-name>
				[Dot42.DexImport("calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;", AccessFlags = 9, IgnoreFromJava = true)]
				public static string CalledPartyBCDFragmentToString(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isWellFormedSmsAddress
				/// </java-name>
				[Dot42.DexImport("isWellFormedSmsAddress", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsWellFormedSmsAddress(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isGlobalPhoneNumber
				/// </java-name>
				[Dot42.DexImport("isGlobalPhoneNumber", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsGlobalPhoneNumber(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// networkPortionToCalledPartyBCD
				/// </java-name>
				[Dot42.DexImport("networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaNetworkPortionToCalledPartyBCD(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// networkPortionToCalledPartyBCD
				/// </java-name>
				[Dot42.DexImport("networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] NetworkPortionToCalledPartyBCD(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// networkPortionToCalledPartyBCDWithLength
				/// </java-name>
				[Dot42.DexImport("networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaNetworkPortionToCalledPartyBCDWithLength(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// networkPortionToCalledPartyBCDWithLength
				/// </java-name>
				[Dot42.DexImport("networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] NetworkPortionToCalledPartyBCDWithLength(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// numberToCalledPartyBCD
				/// </java-name>
				[Dot42.DexImport("numberToCalledPartyBCD", "(Ljava/lang/String;)[B", AccessFlags = 9)]
				public static sbyte[] JavaNumberToCalledPartyBCD(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// numberToCalledPartyBCD
				/// </java-name>
				[Dot42.DexImport("numberToCalledPartyBCD", "(Ljava/lang/String;)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] NumberToCalledPartyBCD(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// formatNumber
				/// </java-name>
				[Dot42.DexImport("formatNumber", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatNumber(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getFormatTypeForLocale
				/// </java-name>
				[Dot42.DexImport("getFormatTypeForLocale", "(Ljava/util/Locale;)I", AccessFlags = 9)]
				public static int GetFormatTypeForLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// formatNumber
				/// </java-name>
				[Dot42.DexImport("formatNumber", "(Landroid/text/Editable;I)V", AccessFlags = 9)]
				public static void FormatNumber(global::Android.Text.IEditable editable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatNanpNumber
				/// </java-name>
				[Dot42.DexImport("formatNanpNumber", "(Landroid/text/Editable;)V", AccessFlags = 9)]
				public static void FormatNanpNumber(global::Android.Text.IEditable editable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatJapaneseNumber
				/// </java-name>
				[Dot42.DexImport("formatJapaneseNumber", "(Landroid/text/Editable;)V", AccessFlags = 9)]
				public static void FormatJapaneseNumber(global::Android.Text.IEditable editable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEmergencyNumber
				/// </java-name>
				[Dot42.DexImport("isEmergencyNumber", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsEmergencyNumber(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// convertKeypadLettersToDigits
				/// </java-name>
				[Dot42.DexImport("convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ConvertKeypadLettersToDigits(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/telephony/PhoneStateListener
		/// </java-name>
		[Dot42.DexImport("android/telephony/PhoneStateListener", AccessFlags = 33)]
		public partial class PhoneStateListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LISTEN_NONE
				/// </java-name>
				[Dot42.DexImport("LISTEN_NONE", "I", AccessFlags = 25)]
				public const int LISTEN_NONE = 0;
				/// <java-name>
				/// LISTEN_SERVICE_STATE
				/// </java-name>
				[Dot42.DexImport("LISTEN_SERVICE_STATE", "I", AccessFlags = 25)]
				public const int LISTEN_SERVICE_STATE = 1;
				/// <java-name>
				/// LISTEN_SIGNAL_STRENGTH
				/// </java-name>
				[Dot42.DexImport("LISTEN_SIGNAL_STRENGTH", "I", AccessFlags = 25)]
				public const int LISTEN_SIGNAL_STRENGTH = 2;
				/// <java-name>
				/// LISTEN_MESSAGE_WAITING_INDICATOR
				/// </java-name>
				[Dot42.DexImport("LISTEN_MESSAGE_WAITING_INDICATOR", "I", AccessFlags = 25)]
				public const int LISTEN_MESSAGE_WAITING_INDICATOR = 4;
				/// <java-name>
				/// LISTEN_CALL_FORWARDING_INDICATOR
				/// </java-name>
				[Dot42.DexImport("LISTEN_CALL_FORWARDING_INDICATOR", "I", AccessFlags = 25)]
				public const int LISTEN_CALL_FORWARDING_INDICATOR = 8;
				/// <java-name>
				/// LISTEN_CELL_LOCATION
				/// </java-name>
				[Dot42.DexImport("LISTEN_CELL_LOCATION", "I", AccessFlags = 25)]
				public const int LISTEN_CELL_LOCATION = 16;
				/// <java-name>
				/// LISTEN_CALL_STATE
				/// </java-name>
				[Dot42.DexImport("LISTEN_CALL_STATE", "I", AccessFlags = 25)]
				public const int LISTEN_CALL_STATE = 32;
				/// <java-name>
				/// LISTEN_DATA_CONNECTION_STATE
				/// </java-name>
				[Dot42.DexImport("LISTEN_DATA_CONNECTION_STATE", "I", AccessFlags = 25)]
				public const int LISTEN_DATA_CONNECTION_STATE = 64;
				/// <java-name>
				/// LISTEN_DATA_ACTIVITY
				/// </java-name>
				[Dot42.DexImport("LISTEN_DATA_ACTIVITY", "I", AccessFlags = 25)]
				public const int LISTEN_DATA_ACTIVITY = 128;
				/// <java-name>
				/// LISTEN_SIGNAL_STRENGTHS
				/// </java-name>
				[Dot42.DexImport("LISTEN_SIGNAL_STRENGTHS", "I", AccessFlags = 25)]
				public const int LISTEN_SIGNAL_STRENGTHS = 256;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PhoneStateListener() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onServiceStateChanged
				/// </java-name>
				[Dot42.DexImport("onServiceStateChanged", "(Landroid/telephony/ServiceState;)V", AccessFlags = 1)]
				public virtual void OnServiceStateChanged(global::Android.Telephony.ServiceState serviceState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSignalStrengthChanged
				/// </java-name>
				[Dot42.DexImport("onSignalStrengthChanged", "(I)V", AccessFlags = 1)]
				public virtual void OnSignalStrengthChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMessageWaitingIndicatorChanged
				/// </java-name>
				[Dot42.DexImport("onMessageWaitingIndicatorChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnMessageWaitingIndicatorChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCallForwardingIndicatorChanged
				/// </java-name>
				[Dot42.DexImport("onCallForwardingIndicatorChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnCallForwardingIndicatorChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCellLocationChanged
				/// </java-name>
				[Dot42.DexImport("onCellLocationChanged", "(Landroid/telephony/CellLocation;)V", AccessFlags = 1)]
				public virtual void OnCellLocationChanged(global::Android.Telephony.CellLocation cellLocation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCallStateChanged
				/// </java-name>
				[Dot42.DexImport("onCallStateChanged", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void OnCallStateChanged(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDataConnectionStateChanged
				/// </java-name>
				[Dot42.DexImport("onDataConnectionStateChanged", "(I)V", AccessFlags = 1)]
				public virtual void OnDataConnectionStateChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDataConnectionStateChanged
				/// </java-name>
				[Dot42.DexImport("onDataConnectionStateChanged", "(II)V", AccessFlags = 1)]
				public virtual void OnDataConnectionStateChanged(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDataActivity
				/// </java-name>
				[Dot42.DexImport("onDataActivity", "(I)V", AccessFlags = 1)]
				public virtual void OnDataActivity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSignalStrengthsChanged
				/// </java-name>
				[Dot42.DexImport("onSignalStrengthsChanged", "(Landroid/telephony/SignalStrength;)V", AccessFlags = 1)]
				public virtual void OnSignalStrengthsChanged(global::Android.Telephony.SignalStrength signalStrength) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/telephony/ServiceState
		/// </java-name>
		[Dot42.DexImport("android/telephony/ServiceState", AccessFlags = 33)]
		public partial class ServiceState : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATE_IN_SERVICE
				/// </java-name>
				[Dot42.DexImport("STATE_IN_SERVICE", "I", AccessFlags = 25)]
				public const int STATE_IN_SERVICE = 0;
				/// <java-name>
				/// STATE_OUT_OF_SERVICE
				/// </java-name>
				[Dot42.DexImport("STATE_OUT_OF_SERVICE", "I", AccessFlags = 25)]
				public const int STATE_OUT_OF_SERVICE = 1;
				/// <java-name>
				/// STATE_EMERGENCY_ONLY
				/// </java-name>
				[Dot42.DexImport("STATE_EMERGENCY_ONLY", "I", AccessFlags = 25)]
				public const int STATE_EMERGENCY_ONLY = 2;
				/// <java-name>
				/// STATE_POWER_OFF
				/// </java-name>
				[Dot42.DexImport("STATE_POWER_OFF", "I", AccessFlags = 25)]
				public const int STATE_POWER_OFF = 3;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Telephony.ServiceState> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ServiceState() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/telephony/ServiceState;)V", AccessFlags = 1)]
				public ServiceState(global::Android.Telephony.ServiceState serviceState) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ServiceState(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/telephony/ServiceState;)V", AccessFlags = 4)]
				protected internal virtual void CopyFrom(global::Android.Telephony.ServiceState serviceState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// setStateOutOfService
				/// </java-name>
				[Dot42.DexImport("setStateOutOfService", "()V", AccessFlags = 1)]
				public virtual void SetStateOutOfService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStateOff
				/// </java-name>
				[Dot42.DexImport("setStateOff", "()V", AccessFlags = 1)]
				public virtual void SetStateOff() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOperatorName
				/// </java-name>
				[Dot42.DexImport("setOperatorName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetOperatorName(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getState
				/// </java-name>
				public virtual int State
				{
						[Dot42.DexImport("getState", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setState", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRoaming
				/// </java-name>
				public virtual bool IsRoaming
				{
						[Dot42.DexImport("getRoaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setRoaming", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOperatorAlphaLong
				/// </java-name>
				public virtual string OperatorAlphaLong
				{
						[Dot42.DexImport("getOperatorAlphaLong", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getOperatorAlphaShort
				/// </java-name>
				public virtual string OperatorAlphaShort
				{
						[Dot42.DexImport("getOperatorAlphaShort", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getOperatorNumeric
				/// </java-name>
				public virtual string OperatorNumeric
				{
						[Dot42.DexImport("getOperatorNumeric", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getIsManualSelection
				/// </java-name>
				public virtual bool IsManualSelection
				{
						[Dot42.DexImport("getIsManualSelection", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setIsManualSelection", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/telephony/SignalStrength
		/// </java-name>
		[Dot42.DexImport("android/telephony/SignalStrength", AccessFlags = 33)]
		public partial class SignalStrength : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SignalStrength() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// getGsmSignalStrength
				/// </java-name>
				public virtual int GsmSignalStrength
				{
						[Dot42.DexImport("getGsmSignalStrength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGsmBitErrorRate
				/// </java-name>
				public virtual int GsmBitErrorRate
				{
						[Dot42.DexImport("getGsmBitErrorRate", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCdmaDbm
				/// </java-name>
				public virtual int CdmaDbm
				{
						[Dot42.DexImport("getCdmaDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCdmaEcio
				/// </java-name>
				public virtual int CdmaEcio
				{
						[Dot42.DexImport("getCdmaEcio", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEvdoDbm
				/// </java-name>
				public virtual int EvdoDbm
				{
						[Dot42.DexImport("getEvdoDbm", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEvdoEcio
				/// </java-name>
				public virtual int EvdoEcio
				{
						[Dot42.DexImport("getEvdoEcio", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEvdoSnr
				/// </java-name>
				public virtual int EvdoSnr
				{
						[Dot42.DexImport("getEvdoSnr", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isGsm
				/// </java-name>
				public virtual bool IsGsm
				{
						[Dot42.DexImport("isGsm", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/telephony/SmsManager
		/// </java-name>
		[Dot42.DexImport("android/telephony/SmsManager", AccessFlags = 49)]
		public sealed partial class SmsManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATUS_ON_ICC_FREE
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_FREE", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_FREE = 0;
				/// <java-name>
				/// STATUS_ON_ICC_READ
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_READ", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_READ = 1;
				/// <java-name>
				/// STATUS_ON_ICC_UNREAD
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_UNREAD", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_UNREAD = 3;
				/// <java-name>
				/// STATUS_ON_ICC_SENT
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_SENT", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_SENT = 5;
				/// <java-name>
				/// STATUS_ON_ICC_UNSENT
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_ICC_UNSENT", "I", AccessFlags = 25)]
				public const int STATUS_ON_ICC_UNSENT = 7;
				/// <java-name>
				/// RESULT_ERROR_GENERIC_FAILURE
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_GENERIC_FAILURE", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_GENERIC_FAILURE = 1;
				/// <java-name>
				/// RESULT_ERROR_RADIO_OFF
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_RADIO_OFF", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_RADIO_OFF = 2;
				/// <java-name>
				/// RESULT_ERROR_NULL_PDU
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_NULL_PDU", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_NULL_PDU = 3;
				/// <java-name>
				/// RESULT_ERROR_NO_SERVICE
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_NO_SERVICE", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_NO_SERVICE = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SmsManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendTextMessage
				/// </java-name>
				[Dot42.DexImport("sendTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/app/PendingIntent" +
    ";Landroid/app/PendingIntent;)V", AccessFlags = 1)]
				public void SendTextMessage(string @string, string string1, string string2, global::Android.App.PendingIntent pendingIntent, global::Android.App.PendingIntent pendingIntent1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// divideMessage
				/// </java-name>
				[Dot42.DexImport("divideMessage", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public global::Java.Util.ArrayList<string> DivideMessage(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <java-name>
				/// sendMultipartTextMessage
				/// </java-name>
				[Dot42.DexImport("sendMultipartTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lj" +
    "ava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/String;>;Lja" +
    "va/util/ArrayList<Landroid/app/PendingIntent;>;Ljava/util/ArrayList<Landroid/app" +
    "/PendingIntent;>;)V")]
				public void SendMultipartTextMessage(string @string, string string1, global::Java.Util.ArrayList<string> arrayList, global::Java.Util.ArrayList<global::Android.App.PendingIntent> arrayList1, global::Java.Util.ArrayList<global::Android.App.PendingIntent> arrayList2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendDataMessage
				/// </java-name>
				[Dot42.DexImport("sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/P" +
    "endingIntent;)V", AccessFlags = 1)]
				public void SendDataMessage(string @string, string string1, short int16, sbyte[] sByte, global::Android.App.PendingIntent pendingIntent, global::Android.App.PendingIntent pendingIntent1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendDataMessage
				/// </java-name>
				[Dot42.DexImport("sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/P" +
    "endingIntent;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void SendDataMessage(string @string, string string1, short int16, byte[] @byte, global::Android.App.PendingIntent pendingIntent, global::Android.App.PendingIntent pendingIntent1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Android.Telephony.SmsManager Default
				{
						[Dot42.DexImport("getDefault", "()Landroid/telephony/SmsManager;", AccessFlags = 9)]
						get{ return default(global::Android.Telephony.SmsManager); }
				}

		}

		/// <java-name>
		/// android/telephony/SmsMessage
		/// </java-name>
		[Dot42.DexImport("android/telephony/SmsMessage", AccessFlags = 33)]
		public partial class SmsMessage
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ENCODING_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ENCODING_UNKNOWN", "I", AccessFlags = 25)]
				public const int ENCODING_UNKNOWN = 0;
				/// <java-name>
				/// ENCODING_7BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_7BIT", "I", AccessFlags = 25)]
				public const int ENCODING_7BIT = 1;
				/// <java-name>
				/// ENCODING_8BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_8BIT", "I", AccessFlags = 25)]
				public const int ENCODING_8BIT = 2;
				/// <java-name>
				/// ENCODING_16BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_16BIT", "I", AccessFlags = 25)]
				public const int ENCODING_16BIT = 3;
				/// <java-name>
				/// MAX_USER_DATA_BYTES
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_BYTES", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_BYTES = 140;
				/// <java-name>
				/// MAX_USER_DATA_BYTES_WITH_HEADER
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_BYTES_WITH_HEADER", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_BYTES_WITH_HEADER = 134;
				/// <java-name>
				/// MAX_USER_DATA_SEPTETS
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_SEPTETS", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_SEPTETS = 160;
				/// <java-name>
				/// MAX_USER_DATA_SEPTETS_WITH_HEADER
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_SEPTETS_WITH_HEADER", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_SEPTETS_WITH_HEADER = 153;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SmsMessage() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createFromPdu
				/// </java-name>
				[Dot42.DexImport("createFromPdu", "([B)Landroid/telephony/SmsMessage;", AccessFlags = 9)]
				public static global::Android.Telephony.SmsMessage CreateFromPdu(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage);
				}

				/// <java-name>
				/// createFromPdu
				/// </java-name>
				[Dot42.DexImport("createFromPdu", "([B)Landroid/telephony/SmsMessage;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Telephony.SmsMessage CreateFromPdu(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage);
				}

				/// <java-name>
				/// getTPLayerLengthForPDU
				/// </java-name>
				[Dot42.DexImport("getTPLayerLengthForPDU", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetTPLayerLengthForPDU(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// calculateLength
				/// </java-name>
				[Dot42.DexImport("calculateLength", "(Ljava/lang/CharSequence;Z)[I", AccessFlags = 9)]
				public static int[] CalculateLength(global::Java.Lang.ICharSequence charSequence, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// calculateLength
				/// </java-name>
				[Dot42.DexImport("calculateLength", "(Ljava/lang/String;Z)[I", AccessFlags = 9)]
				public static int[] CalculateLength(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/SmsMe" +
    "ssage$SubmitPdu;", AccessFlags = 9)]
				public static global::Android.Telephony.SmsMessage.SubmitPdu GetSubmitPdu(string @string, string string1, string string2, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage.SubmitPdu);
				}

				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu" +
    ";", AccessFlags = 9)]
				public static global::Android.Telephony.SmsMessage.SubmitPdu GetSubmitPdu(string @string, string string1, short int16, sbyte[] sByte, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage.SubmitPdu);
				}

				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/SmsMessage$SubmitPdu" +
    ";", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Telephony.SmsMessage.SubmitPdu GetSubmitPdu(string @string, string string1, short int16, byte[] @byte, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage.SubmitPdu);
				}

				/// <java-name>
				/// getMessageClass
				/// </java-name>
				[Dot42.DexImport("getMessageClass", "()Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 1)]
				public virtual global::Android.Telephony.SmsMessage.MessageClass GetMessageClass() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.SmsMessage.MessageClass);
				}

				/// <java-name>
				/// getUserData
				/// </java-name>
				[Dot42.DexImport("getUserData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetUserData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getPdu
				/// </java-name>
				[Dot42.DexImport("getPdu", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetPdu() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getServiceCenterAddress
				/// </java-name>
				public virtual string ServiceCenterAddress
				{
						[Dot42.DexImport("getServiceCenterAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getOriginatingAddress
				/// </java-name>
				public virtual string OriginatingAddress
				{
						[Dot42.DexImport("getOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDisplayOriginatingAddress
				/// </java-name>
				public virtual string DisplayOriginatingAddress
				{
						[Dot42.DexImport("getDisplayOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getMessageBody
				/// </java-name>
				public virtual string MessageBody
				{
						[Dot42.DexImport("getMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDisplayMessageBody
				/// </java-name>
				public virtual string DisplayMessageBody
				{
						[Dot42.DexImport("getDisplayMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPseudoSubject
				/// </java-name>
				public virtual string PseudoSubject
				{
						[Dot42.DexImport("getPseudoSubject", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getTimestampMillis
				/// </java-name>
				public virtual long TimestampMillis
				{
						[Dot42.DexImport("getTimestampMillis", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// isEmail
				/// </java-name>
				public virtual bool IsEmail
				{
						[Dot42.DexImport("isEmail", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getEmailBody
				/// </java-name>
				public virtual string EmailBody
				{
						[Dot42.DexImport("getEmailBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getEmailFrom
				/// </java-name>
				public virtual string EmailFrom
				{
						[Dot42.DexImport("getEmailFrom", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProtocolIdentifier
				/// </java-name>
				public virtual int ProtocolIdentifier
				{
						[Dot42.DexImport("getProtocolIdentifier", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isReplace
				/// </java-name>
				public virtual bool IsReplace
				{
						[Dot42.DexImport("isReplace", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isCphsMwiMessage
				/// </java-name>
				public virtual bool IsCphsMwiMessage
				{
						[Dot42.DexImport("isCphsMwiMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMWIClearMessage
				/// </java-name>
				public virtual bool IsMWIClearMessage
				{
						[Dot42.DexImport("isMWIClearMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMWISetMessage
				/// </java-name>
				public virtual bool IsMWISetMessage
				{
						[Dot42.DexImport("isMWISetMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMwiDontStore
				/// </java-name>
				public virtual bool IsMwiDontStore
				{
						[Dot42.DexImport("isMwiDontStore", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getUserData
				/// </java-name>
				public virtual byte[] UserData
				{
						[Dot42.DexImport("getUserData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getPdu
				/// </java-name>
				public virtual byte[] Pdu
				{
						[Dot42.DexImport("getPdu", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getStatusOnSim
				/// </java-name>
				public virtual int StatusOnSim
				{
						[Dot42.DexImport("getStatusOnSim", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getStatusOnIcc
				/// </java-name>
				public virtual int StatusOnIcc
				{
						[Dot42.DexImport("getStatusOnIcc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getIndexOnSim
				/// </java-name>
				public virtual int IndexOnSim
				{
						[Dot42.DexImport("getIndexOnSim", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getIndexOnIcc
				/// </java-name>
				public virtual int IndexOnIcc
				{
						[Dot42.DexImport("getIndexOnIcc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getStatus
				/// </java-name>
				public virtual int Status
				{
						[Dot42.DexImport("getStatus", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isStatusReportMessage
				/// </java-name>
				public virtual bool IsStatusReportMessage
				{
						[Dot42.DexImport("isStatusReportMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isReplyPathPresent
				/// </java-name>
				public virtual bool IsReplyPathPresent
				{
						[Dot42.DexImport("isReplyPathPresent", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/telephony/SmsMessage$SubmitPdu
				/// </java-name>
				[Dot42.DexImport("android/telephony/SmsMessage$SubmitPdu", AccessFlags = 9)]
				public partial class SubmitPdu
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// encodedScAddress
						/// </java-name>
						[Dot42.DexImport("encodedScAddress", "[B", AccessFlags = 1)]
						public sbyte[] EncodedScAddress;
						/// <java-name>
						/// encodedMessage
						/// </java-name>
						[Dot42.DexImport("encodedMessage", "[B", AccessFlags = 1)]
						public sbyte[] EncodedMessage;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal SubmitPdu() /* MethodBuilder.Create */ 
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

				}

				/// <java-name>
				/// android/telephony/SmsMessage$MessageClass
				/// </java-name>
				[Dot42.DexImport("android/telephony/SmsMessage$MessageClass", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/telephony/SmsMessage$MessageClass;>;")]
				public sealed class MessageClass
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLASS_0
						/// </java-name>
						[Dot42.DexImport("CLASS_0", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_0;
						/// <java-name>
						/// CLASS_1
						/// </java-name>
						[Dot42.DexImport("CLASS_1", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_1;
						/// <java-name>
						/// CLASS_2
						/// </java-name>
						[Dot42.DexImport("CLASS_2", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_2;
						/// <java-name>
						/// CLASS_3
						/// </java-name>
						[Dot42.DexImport("CLASS_3", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_3;
						/// <java-name>
						/// UNKNOWN
						/// </java-name>
						[Dot42.DexImport("UNKNOWN", "Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass UNKNOWN;
						private MessageClass() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 9)]
						public static MessageClass[] Values() /* MethodBuilder.Create */ 
						{
								return default(MessageClass[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/telephony/SmsMessage$MessageClass;", AccessFlags = 9)]
						public static MessageClass ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(MessageClass);
						}

				}

		}

		/// <java-name>
		/// android/telephony/TelephonyManager
		/// </java-name>
		[Dot42.DexImport("android/telephony/TelephonyManager", AccessFlags = 33)]
		public partial class TelephonyManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_PHONE_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_PHONE_STATE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_PHONE_STATE_CHANGED = "android.intent.action.PHONE_STATE";
				/// <java-name>
				/// EXTRA_STATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_STATE = "state";
				/// <java-name>
				/// EXTRA_STATE_IDLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE_IDLE", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string EXTRA_STATE_IDLE;
				/// <java-name>
				/// EXTRA_STATE_RINGING
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE_RINGING", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string EXTRA_STATE_RINGING;
				/// <java-name>
				/// EXTRA_STATE_OFFHOOK
				/// </java-name>
				[Dot42.DexImport("EXTRA_STATE_OFFHOOK", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string EXTRA_STATE_OFFHOOK;
				/// <java-name>
				/// EXTRA_INCOMING_NUMBER
				/// </java-name>
				[Dot42.DexImport("EXTRA_INCOMING_NUMBER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_INCOMING_NUMBER = "incoming_number";
				/// <java-name>
				/// PHONE_TYPE_NONE
				/// </java-name>
				[Dot42.DexImport("PHONE_TYPE_NONE", "I", AccessFlags = 25)]
				public const int PHONE_TYPE_NONE = 0;
				/// <java-name>
				/// PHONE_TYPE_GSM
				/// </java-name>
				[Dot42.DexImport("PHONE_TYPE_GSM", "I", AccessFlags = 25)]
				public const int PHONE_TYPE_GSM = 1;
				/// <java-name>
				/// PHONE_TYPE_CDMA
				/// </java-name>
				[Dot42.DexImport("PHONE_TYPE_CDMA", "I", AccessFlags = 25)]
				public const int PHONE_TYPE_CDMA = 2;
				/// <java-name>
				/// PHONE_TYPE_SIP
				/// </java-name>
				[Dot42.DexImport("PHONE_TYPE_SIP", "I", AccessFlags = 25)]
				public const int PHONE_TYPE_SIP = 3;
				/// <java-name>
				/// NETWORK_TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_UNKNOWN = 0;
				/// <java-name>
				/// NETWORK_TYPE_GPRS
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_GPRS", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_GPRS = 1;
				/// <java-name>
				/// NETWORK_TYPE_EDGE
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EDGE", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EDGE = 2;
				/// <java-name>
				/// NETWORK_TYPE_UMTS
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_UMTS", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_UMTS = 3;
				/// <java-name>
				/// NETWORK_TYPE_CDMA
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_CDMA", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_CDMA = 4;
				/// <java-name>
				/// NETWORK_TYPE_EVDO_0
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EVDO_0", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EVDO_0 = 5;
				/// <java-name>
				/// NETWORK_TYPE_EVDO_A
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EVDO_A", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EVDO_A = 6;
				/// <java-name>
				/// NETWORK_TYPE_1xRTT
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_1xRTT", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_1xRTT = 7;
				/// <java-name>
				/// NETWORK_TYPE_HSDPA
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_HSDPA", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_HSDPA = 8;
				/// <java-name>
				/// NETWORK_TYPE_HSUPA
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_HSUPA", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_HSUPA = 9;
				/// <java-name>
				/// NETWORK_TYPE_HSPA
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_HSPA", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_HSPA = 10;
				/// <java-name>
				/// NETWORK_TYPE_IDEN
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_IDEN", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_IDEN = 11;
				/// <java-name>
				/// NETWORK_TYPE_EVDO_B
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EVDO_B", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EVDO_B = 12;
				/// <java-name>
				/// NETWORK_TYPE_LTE
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_LTE", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_LTE = 13;
				/// <java-name>
				/// NETWORK_TYPE_EHRPD
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_EHRPD", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_EHRPD = 14;
				/// <java-name>
				/// NETWORK_TYPE_HSPAP
				/// </java-name>
				[Dot42.DexImport("NETWORK_TYPE_HSPAP", "I", AccessFlags = 25)]
				public const int NETWORK_TYPE_HSPAP = 15;
				/// <java-name>
				/// SIM_STATE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_UNKNOWN", "I", AccessFlags = 25)]
				public const int SIM_STATE_UNKNOWN = 0;
				/// <java-name>
				/// SIM_STATE_ABSENT
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_ABSENT", "I", AccessFlags = 25)]
				public const int SIM_STATE_ABSENT = 1;
				/// <java-name>
				/// SIM_STATE_PIN_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_PIN_REQUIRED", "I", AccessFlags = 25)]
				public const int SIM_STATE_PIN_REQUIRED = 2;
				/// <java-name>
				/// SIM_STATE_PUK_REQUIRED
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_PUK_REQUIRED", "I", AccessFlags = 25)]
				public const int SIM_STATE_PUK_REQUIRED = 3;
				/// <java-name>
				/// SIM_STATE_NETWORK_LOCKED
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_NETWORK_LOCKED", "I", AccessFlags = 25)]
				public const int SIM_STATE_NETWORK_LOCKED = 4;
				/// <java-name>
				/// SIM_STATE_READY
				/// </java-name>
				[Dot42.DexImport("SIM_STATE_READY", "I", AccessFlags = 25)]
				public const int SIM_STATE_READY = 5;
				/// <java-name>
				/// CALL_STATE_IDLE
				/// </java-name>
				[Dot42.DexImport("CALL_STATE_IDLE", "I", AccessFlags = 25)]
				public const int CALL_STATE_IDLE = 0;
				/// <java-name>
				/// CALL_STATE_RINGING
				/// </java-name>
				[Dot42.DexImport("CALL_STATE_RINGING", "I", AccessFlags = 25)]
				public const int CALL_STATE_RINGING = 1;
				/// <java-name>
				/// CALL_STATE_OFFHOOK
				/// </java-name>
				[Dot42.DexImport("CALL_STATE_OFFHOOK", "I", AccessFlags = 25)]
				public const int CALL_STATE_OFFHOOK = 2;
				/// <java-name>
				/// DATA_ACTIVITY_NONE
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_NONE", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_NONE = 0;
				/// <java-name>
				/// DATA_ACTIVITY_IN
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_IN", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_IN = 1;
				/// <java-name>
				/// DATA_ACTIVITY_OUT
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_OUT", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_OUT = 2;
				/// <java-name>
				/// DATA_ACTIVITY_INOUT
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_INOUT", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_INOUT = 3;
				/// <java-name>
				/// DATA_ACTIVITY_DORMANT
				/// </java-name>
				[Dot42.DexImport("DATA_ACTIVITY_DORMANT", "I", AccessFlags = 25)]
				public const int DATA_ACTIVITY_DORMANT = 4;
				/// <java-name>
				/// DATA_DISCONNECTED
				/// </java-name>
				[Dot42.DexImport("DATA_DISCONNECTED", "I", AccessFlags = 25)]
				public const int DATA_DISCONNECTED = 0;
				/// <java-name>
				/// DATA_CONNECTING
				/// </java-name>
				[Dot42.DexImport("DATA_CONNECTING", "I", AccessFlags = 25)]
				public const int DATA_CONNECTING = 1;
				/// <java-name>
				/// DATA_CONNECTED
				/// </java-name>
				[Dot42.DexImport("DATA_CONNECTED", "I", AccessFlags = 25)]
				public const int DATA_CONNECTED = 2;
				/// <java-name>
				/// DATA_SUSPENDED
				/// </java-name>
				[Dot42.DexImport("DATA_SUSPENDED", "I", AccessFlags = 25)]
				public const int DATA_SUSPENDED = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TelephonyManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// listen
				/// </java-name>
				[Dot42.DexImport("listen", "(Landroid/telephony/PhoneStateListener;I)V", AccessFlags = 1)]
				public virtual void Listen(global::Android.Telephony.PhoneStateListener phoneStateListener, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDeviceSoftwareVersion
				/// </java-name>
				public virtual string DeviceSoftwareVersion
				{
						[Dot42.DexImport("getDeviceSoftwareVersion", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDeviceId
				/// </java-name>
				public virtual string DeviceId
				{
						[Dot42.DexImport("getDeviceId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCellLocation
				/// </java-name>
				public virtual global::Android.Telephony.CellLocation CellLocation
				{
						[Dot42.DexImport("getCellLocation", "()Landroid/telephony/CellLocation;", AccessFlags = 1)]
						get{ return default(global::Android.Telephony.CellLocation); }
				}

				/// <java-name>
				/// getNeighboringCellInfo
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Telephony.NeighboringCellInfo> NeighboringCellInfo
				{
						[Dot42.DexImport("getNeighboringCellInfo", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/telephony/NeighboringCellInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Telephony.NeighboringCellInfo>); }
				}

				/// <java-name>
				/// getPhoneType
				/// </java-name>
				public virtual int PhoneType
				{
						[Dot42.DexImport("getPhoneType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getNetworkOperatorName
				/// </java-name>
				public virtual string NetworkOperatorName
				{
						[Dot42.DexImport("getNetworkOperatorName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getNetworkOperator
				/// </java-name>
				public virtual string NetworkOperator
				{
						[Dot42.DexImport("getNetworkOperator", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isNetworkRoaming
				/// </java-name>
				public virtual bool IsNetworkRoaming
				{
						[Dot42.DexImport("isNetworkRoaming", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getNetworkCountryIso
				/// </java-name>
				public virtual string NetworkCountryIso
				{
						[Dot42.DexImport("getNetworkCountryIso", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getNetworkType
				/// </java-name>
				public virtual int NetworkType
				{
						[Dot42.DexImport("getNetworkType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// hasIccCard
				/// </java-name>
				public virtual bool HasIccCard
				{
						[Dot42.DexImport("hasIccCard", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getSimState
				/// </java-name>
				public virtual int SimState
				{
						[Dot42.DexImport("getSimState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSimOperator
				/// </java-name>
				public virtual string SimOperator
				{
						[Dot42.DexImport("getSimOperator", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSimOperatorName
				/// </java-name>
				public virtual string SimOperatorName
				{
						[Dot42.DexImport("getSimOperatorName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSimCountryIso
				/// </java-name>
				public virtual string SimCountryIso
				{
						[Dot42.DexImport("getSimCountryIso", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSimSerialNumber
				/// </java-name>
				public virtual string SimSerialNumber
				{
						[Dot42.DexImport("getSimSerialNumber", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSubscriberId
				/// </java-name>
				public virtual string SubscriberId
				{
						[Dot42.DexImport("getSubscriberId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getLine1Number
				/// </java-name>
				public virtual string Line1Number
				{
						[Dot42.DexImport("getLine1Number", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getVoiceMailNumber
				/// </java-name>
				public virtual string VoiceMailNumber
				{
						[Dot42.DexImport("getVoiceMailNumber", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getVoiceMailAlphaTag
				/// </java-name>
				public virtual string VoiceMailAlphaTag
				{
						[Dot42.DexImport("getVoiceMailAlphaTag", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCallState
				/// </java-name>
				public virtual int CallState
				{
						[Dot42.DexImport("getCallState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDataActivity
				/// </java-name>
				public virtual int DataActivity
				{
						[Dot42.DexImport("getDataActivity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDataState
				/// </java-name>
				public virtual int DataState
				{
						[Dot42.DexImport("getDataState", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

