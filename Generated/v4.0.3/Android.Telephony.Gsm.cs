#pragma warning disable 1717
namespace Android.Telephony.Gsm
{
		/// <summary>
		///  <para>Represents the cell location on a GSM phone. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/gsm/GsmCellLocation
		/// </java-name>
		[Dot42.DexImport("android/telephony/gsm/GsmCellLocation", AccessFlags = 33)]
		public partial class GsmCellLocation : global::Android.Telephony.CellLocation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Empty constructor. Initializes the LAC and CID to -1. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GsmCellLocation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initialize the object from a bundle. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public GsmCellLocation(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invalidate this object. The location area code and the cell id are set to -1. </para>        
				/// </summary>
				/// <java-name>
				/// setStateInvalid
				/// </java-name>
				[Dot42.DexImport("setStateInvalid", "()V", AccessFlags = 1)]
				public virtual void SetStateInvalid() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the location area code and the cell id. </para>        
				/// </summary>
				/// <java-name>
				/// setLacAndCid
				/// </java-name>
				[Dot42.DexImport("setLacAndCid", "(II)V", AccessFlags = 1)]
				public virtual void SetLacAndCid(int lac, int cid) /* MethodBuilder.Create */ 
				{
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
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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
				///  <para>Set intent notifier Bundle based on service state</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// fillInNotifierBundle
				/// </java-name>
				[Dot42.DexImport("fillInNotifierBundle", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void FillInNotifierBundle(global::Android.OS.Bundle m) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>gsm location area code, -1 if unknown, 0xffff max legal value </para>
				/// </returns>
				/// <java-name>
				/// getLac
				/// </java-name>
				public virtual int Lac
				{
						[Dot42.DexImport("getLac", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>gsm cell id, -1 if unknown, 0xffff max legal value </para>
				/// </returns>
				/// <java-name>
				/// getCid
				/// </java-name>
				public virtual int Cid
				{
						[Dot42.DexImport("getCid", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>On a UMTS network, returns the primary scrambling code of the serving cell.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>primary scrambling code for UMTS, -1 if unknown or GSM </para>
				/// </returns>
				/// <java-name>
				/// getPsc
				/// </java-name>
				public virtual int Psc
				{
						[Dot42.DexImport("getPsc", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Manages SMS operations such as sending data, text, and pdu SMS messages. Get this object by calling the static method SmsManager.getDefault().  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Replaced by android.telephony.SmsManager that supports both GSM and CDMA. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/gsm/SmsManager
		/// </java-name>
		[Dot42.DexImport("android/telephony/gsm/SmsManager", AccessFlags = 49)]
		public sealed partial class SmsManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Free space (TS 51.011 10.5.3).  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_SIM_FREE
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_FREE", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_FREE = 0;
				/// <summary>
				///  <para>Received and read (TS 51.011 10.5.3).  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_SIM_READ
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_READ", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_READ = 1;
				/// <summary>
				///  <para>Received and unread (TS 51.011 10.5.3).  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_SIM_UNREAD
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_UNREAD", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_UNREAD = 3;
				/// <summary>
				///  <para>Stored and sent (TS 51.011 10.5.3).  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_SIM_SENT
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_SENT", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_SENT = 5;
				/// <summary>
				///  <para>Stored and unsent (TS 51.011 10.5.3).  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// STATUS_ON_SIM_UNSENT
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_UNSENT", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_UNSENT = 7;
				/// <summary>
				///  <para>Generic failure cause  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ERROR_GENERIC_FAILURE
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_GENERIC_FAILURE", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_GENERIC_FAILURE = 1;
				/// <summary>
				///  <para>Failed because radio was explicitly turned off  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ERROR_RADIO_OFF
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_RADIO_OFF", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_RADIO_OFF = 2;
				/// <summary>
				///  <para>Failed because no pdu provided  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ERROR_NULL_PDU
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_NULL_PDU", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_NULL_PDU = 3;
				/// <summary>
				///  <para>Failed because service is currently unavailable  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// RESULT_ERROR_NO_SERVICE
				/// </java-name>
				[Dot42.DexImport("RESULT_ERROR_NO_SERVICE", "I", AccessFlags = 25)]
				public const int RESULT_ERROR_NO_SERVICE = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SmsManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a text based SMS.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para> <code>Use android.telephony.SmsManager. </code></para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// sendTextMessage
				/// </java-name>
				[Dot42.DexImport("sendTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/app/PendingIntent" +
    ";Landroid/app/PendingIntent;)V", AccessFlags = 17)]
				public void SendTextMessage(string destinationAddress, string scAddress, string text, global::Android.App.PendingIntent sentIntent, global::Android.App.PendingIntent deliveryIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Divide a text message into several messages, none bigger than the maximum SMS message size.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>an  <code>ArrayList</code> of strings that, in order, comprise the original message </para>
				/// </returns>
				/// <java-name>
				/// divideMessage
				/// </java-name>
				[Dot42.DexImport("divideMessage", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 17, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public global::Java.Util.ArrayList<string> DivideMessage(string text) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <summary>
				///  <para>Send a multi-part text based SMS. The callee should have already divided the message into correctly sized parts by calling  <code>divideMessage</code>.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para> <code>Use android.telephony.SmsManager. </code></para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// sendMultipartTextMessage
				/// </java-name>
				[Dot42.DexImport("sendMultipartTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lj" +
    "ava/util/ArrayList;)V", AccessFlags = 17, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/String;>;Lja" +
    "va/util/ArrayList<Landroid/app/PendingIntent;>;Ljava/util/ArrayList<Landroid/app" +
    "/PendingIntent;>;)V")]
				public void SendMultipartTextMessage(string destinationAddress, string scAddress, global::Java.Util.ArrayList<string> parts, global::Java.Util.ArrayList<global::Android.App.PendingIntent> sentIntents, global::Java.Util.ArrayList<global::Android.App.PendingIntent> deliveryIntents) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a data based SMS to a specific application port.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para> <code>Use android.telephony.SmsManager. </code></para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// sendDataMessage
				/// </java-name>
				[Dot42.DexImport("sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/P" +
    "endingIntent;)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void SendDataMessage(string destinationAddress, string scAddress, short destinationPort, sbyte[] data, global::Android.App.PendingIntent sentIntent, global::Android.App.PendingIntent deliveryIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send a data based SMS to a specific application port.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para> <code>Use android.telephony.SmsManager. </code></para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// sendDataMessage
				/// </java-name>
				[Dot42.DexImport("sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/P" +
    "endingIntent;)V", AccessFlags = 17)]
				public void SendDataMessage(string destinationAddress, string scAddress, short destinationPort, byte[] data, global::Android.App.PendingIntent sentIntent, global::Android.App.PendingIntent deliveryIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the default instance of the SmsManager</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsManager. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the default instance of the SmsManager </para>
				/// </returns>
				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Android.Telephony.Gsm.SmsManager Default
				{
						[Dot42.DexImport("getDefault", "()Landroid/telephony/gsm/SmsManager;", AccessFlags = 25)]
						get{ return default(global::Android.Telephony.Gsm.SmsManager); }
				}

		}

		/// <summary>
		///  <para>A Short Message Service message.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Replaced by android.telephony.SmsMessage that supports both GSM and CDMA. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/gsm/SmsMessage
		/// </java-name>
		[Dot42.DexImport("android/telephony/gsm/SmsMessage", AccessFlags = 33)]
		public partial class SmsMessage
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Unknown encoding scheme (see TS 23.038)  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ENCODING_UNKNOWN", "I", AccessFlags = 25)]
				public const int ENCODING_UNKNOWN = 0;
				/// <summary>
				///  <para>7-bit encoding scheme (see TS 23.038)  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_7BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_7BIT", "I", AccessFlags = 25)]
				public const int ENCODING_7BIT = 1;
				/// <summary>
				///  <para>8-bit encoding scheme (see TS 23.038)  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_8BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_8BIT", "I", AccessFlags = 25)]
				public const int ENCODING_8BIT = 2;
				/// <summary>
				///  <para>16-bit encoding scheme (see TS 23.038)  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ENCODING_16BIT
				/// </java-name>
				[Dot42.DexImport("ENCODING_16BIT", "I", AccessFlags = 25)]
				public const int ENCODING_16BIT = 3;
				/// <summary>
				///  <para>The maximum number of payload bytes per message  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MAX_USER_DATA_BYTES
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_BYTES", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_BYTES = 140;
				/// <summary>
				///  <para>The maximum number of payload septets per message  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MAX_USER_DATA_SEPTETS
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_SEPTETS", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_SEPTETS = 160;
				/// <summary>
				///  <para>The maximum number of payload septets per message if a user data header is present. This assumes the header only contains the CONCATENATED_8_BIT_REFERENCE element.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MAX_USER_DATA_SEPTETS_WITH_HEADER
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_SEPTETS_WITH_HEADER", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_SEPTETS_WITH_HEADER = 153;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SmsMessage() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create an SmsMessage from a raw PDU.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// createFromPdu
				/// </java-name>
				[Dot42.DexImport("createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Telephony.Gsm.SmsMessage CreateFromPdu(sbyte[] pdu) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage);
				}

				/// <summary>
				///  <para>Create an SmsMessage from a raw PDU.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// createFromPdu
				/// </java-name>
				[Dot42.DexImport("createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;", AccessFlags = 9)]
				public static global::Android.Telephony.Gsm.SmsMessage CreateFromPdu(byte[] pdu) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage);
				}

				/// <summary>
				///  <para>Get the TP-Layer-Length for the given SMS-SUBMIT PDU Basically, the length in bytes (not hex chars) less the SMSC header  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getTPLayerLengthForPDU
				/// </java-name>
				[Dot42.DexImport("getTPLayerLengthForPDU", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int GetTPLayerLengthForPDU(string pdu) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Get an SMS-SUBMIT PDU for a destination address and a message</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>a  <code>SubmitPdu</code> containing the encoded SC address, if applicable, and the encoded message. Returns null on encode error. </para>
				/// </returns>
				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/S" +
    "msMessage$SubmitPdu;", AccessFlags = 9)]
				public static global::Android.Telephony.Gsm.SmsMessage.SubmitPdu GetSubmitPdu(string scAddress, string destinationAddress, string message, bool statusReportRequested) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage.SubmitPdu);
				}

				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$Submi" +
    "tPdu;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Telephony.Gsm.SmsMessage.SubmitPdu GetSubmitPdu(string @string, string string1, short int16, sbyte[] sByte, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage.SubmitPdu);
				}

				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$Submi" +
    "tPdu;", AccessFlags = 9)]
				public static global::Android.Telephony.Gsm.SmsMessage.SubmitPdu GetSubmitPdu(string @string, string string1, short int16, byte[] @byte, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage.SubmitPdu);
				}

				/// <summary>
				///  <para>Returns the class of this message.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getMessageClass
				/// </java-name>
				[Dot42.DexImport("getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 1)]
				public virtual global::Android.Telephony.Gsm.SmsMessage.MessageClass GetMessageClass() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage.MessageClass);
				}

				/// <summary>
				///  <para>returns the user data section minus the user data header if one was present.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUserData
				/// </java-name>
				[Dot42.DexImport("getUserData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetUserData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the raw PDU for the message.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the raw PDU for the message. </para>
				/// </returns>
				/// <java-name>
				/// getPdu
				/// </java-name>
				[Dot42.DexImport("getPdu", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetPdu() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the address of the SMS service center that relayed this message or null if there is none.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getServiceCenterAddress
				/// </java-name>
				public virtual string ServiceCenterAddress
				{
						[Dot42.DexImport("getServiceCenterAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the originating address (sender) of this SMS message in String form or null if unavailable  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getOriginatingAddress
				/// </java-name>
				public virtual string OriginatingAddress
				{
						[Dot42.DexImport("getOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the originating address, or email from address if this message was from an email gateway. Returns null if originating address unavailable.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getDisplayOriginatingAddress
				/// </java-name>
				public virtual string DisplayOriginatingAddress
				{
						[Dot42.DexImport("getDisplayOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the message body as a String, if it exists and is text based.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>message body is there is one, otherwise null </para>
				/// </returns>
				/// <java-name>
				/// getMessageBody
				/// </java-name>
				public virtual string MessageBody
				{
						[Dot42.DexImport("getMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the message body, or email message body if this message was from an email gateway. Returns null if message body unavailable.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getDisplayMessageBody
				/// </java-name>
				public virtual string DisplayMessageBody
				{
						[Dot42.DexImport("getDisplayMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Unofficial convention of a subject line enclosed in parens empty string if not present  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getPseudoSubject
				/// </java-name>
				public virtual string PseudoSubject
				{
						[Dot42.DexImport("getPseudoSubject", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the service centre timestamp in currentTimeMillis() format  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getTimestampMillis
				/// </java-name>
				public virtual long TimestampMillis
				{
						[Dot42.DexImport("getTimestampMillis", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns true if message is an email.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this message came through an email gateway and email sender / subject / parsed body are available </para>
				/// </returns>
				/// <java-name>
				/// isEmail
				/// </java-name>
				public virtual bool IsEmail
				{
						[Dot42.DexImport("isEmail", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>if isEmail() is true, body of the email sent through the gateway. null otherwise </para>
				/// </returns>
				/// <java-name>
				/// getEmailBody
				/// </java-name>
				public virtual string EmailBody
				{
						[Dot42.DexImport("getEmailBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>if isEmail() is true, email from address of email sent through the gateway. null otherwise </para>
				/// </returns>
				/// <java-name>
				/// getEmailFrom
				/// </java-name>
				public virtual string EmailFrom
				{
						[Dot42.DexImport("getEmailFrom", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Get protocol identifier.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getProtocolIdentifier
				/// </java-name>
				public virtual int ProtocolIdentifier
				{
						[Dot42.DexImport("getProtocolIdentifier", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>See TS 23.040 9.2.3.9 returns true if this is a "replace short message" SMS  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isReplace
				/// </java-name>
				public virtual bool IsReplace
				{
						[Dot42.DexImport("isReplace", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true for CPHS MWI toggle message.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this is a CPHS MWI toggle message See CPHS 4.2 section B.4.2 </para>
				/// </returns>
				/// <java-name>
				/// isCphsMwiMessage
				/// </java-name>
				public virtual bool IsCphsMwiMessage
				{
						[Dot42.DexImport("isCphsMwiMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>returns true if this message is a CPHS voicemail / message waiting indicator (MWI) clear message  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isMWIClearMessage
				/// </java-name>
				public virtual bool IsMWIClearMessage
				{
						[Dot42.DexImport("isMWIClearMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>returns true if this message is a CPHS voicemail / message waiting indicator (MWI) set message  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isMWISetMessage
				/// </java-name>
				public virtual bool IsMWISetMessage
				{
						[Dot42.DexImport("isMWISetMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>returns true if this message is a "Message Waiting Indication Group:Discard Message" notification and should not be stored.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isMwiDontStore
				/// </java-name>
				public virtual bool IsMwiDontStore
				{
						[Dot42.DexImport("isMwiDontStore", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>returns the user data section minus the user data header if one was present.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getUserData
				/// </java-name>
				public virtual byte[] UserData
				{
						[Dot42.DexImport("getUserData", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the raw PDU for the message.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the raw PDU for the message. </para>
				/// </returns>
				/// <java-name>
				/// getPdu
				/// </java-name>
				public virtual byte[] Pdu
				{
						[Dot42.DexImport("getPdu", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the status of the message on the SIM (read, unread, sent, unsent).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage and getStatusOnIcc instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the status of the message on the SIM. These are: SmsManager.STATUS_ON_SIM_FREE SmsManager.STATUS_ON_SIM_READ SmsManager.STATUS_ON_SIM_UNREAD SmsManager.STATUS_ON_SIM_SEND SmsManager.STATUS_ON_SIM_UNSENT </para>
				/// </returns>
				/// <java-name>
				/// getStatusOnSim
				/// </java-name>
				public virtual int StatusOnSim
				{
						[Dot42.DexImport("getStatusOnSim", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the record index of the message on the SIM (1-based index).  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage and getIndexOnIcc instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the record index of the message on the SIM, or -1 if this SmsMessage was not created from a SIM SMS EF record. </para>
				/// </returns>
				/// <java-name>
				/// getIndexOnSim
				/// </java-name>
				public virtual int IndexOnSim
				{
						[Dot42.DexImport("getIndexOnSim", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>GSM: For an SMS-STATUS-REPORT message, this returns the status field from the status report. This field indicates the status of a previously submitted SMS, if requested. See TS 23.040, 9.2.3.15 TP-Status for a description of values. CDMA: For not interfering with status codes from GSM, the value is shifted to the bits 31-16. The value is composed of an error class (bits 25-24) and a status code (bits 23-16). Possible codes are described in C.S0015-B, v2.0, 4.5.21.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>0 indicates the previously sent message was received. See TS 23.040, 9.9.2.3.15 and C.S0015-B, v2.0, 4.5.21 for a description of other possible values. </para>
				/// </returns>
				/// <java-name>
				/// getStatus
				/// </java-name>
				public virtual int Status
				{
						[Dot42.DexImport("getStatus", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return true iff the message is a SMS-STATUS-REPORT message.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isStatusReportMessage
				/// </java-name>
				public virtual bool IsStatusReportMessage
				{
						[Dot42.DexImport("isStatusReportMessage", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true iff the  <code>TP-Reply-Path</code> bit is set in this message.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// isReplyPathPresent
				/// </java-name>
				public virtual bool IsReplyPathPresent
				{
						[Dot42.DexImport("isReplyPathPresent", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>    
				/// </summary>
				/// <java-name>
				/// android/telephony/gsm/SmsMessage$SubmitPdu
				/// </java-name>
				[Dot42.DexImport("android/telephony/gsm/SmsMessage$SubmitPdu", AccessFlags = 9)]
				public partial class SubmitPdu
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// encodedScAddress
						/// </java-name>
						[Dot42.DexImport("encodedScAddress", "[B", AccessFlags = 1)]
						public sbyte[] EncodedScAddress;
						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
						/// </summary>
						/// <java-name>
						/// encodedMessage
						/// </java-name>
						[Dot42.DexImport("encodedMessage", "[B", AccessFlags = 1)]
						public sbyte[] EncodedMessage;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public SubmitPdu() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.telephony.SmsMessage. </para></xrefdescription></xrefsect></para>        
						/// </summary>
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
				/// android/telephony/gsm/SmsMessage$MessageClass
				/// </java-name>
				[Dot42.DexImport("android/telephony/gsm/SmsMessage$MessageClass", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/telephony/gsm/SmsMessage$MessageClass;>;")]
				public sealed class MessageClass
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CLASS_0
						/// </java-name>
						[Dot42.DexImport("CLASS_0", "Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_0;
						/// <java-name>
						/// CLASS_1
						/// </java-name>
						[Dot42.DexImport("CLASS_1", "Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_1;
						/// <java-name>
						/// CLASS_2
						/// </java-name>
						[Dot42.DexImport("CLASS_2", "Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_2;
						/// <java-name>
						/// CLASS_3
						/// </java-name>
						[Dot42.DexImport("CLASS_3", "Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass CLASS_3;
						/// <java-name>
						/// UNKNOWN
						/// </java-name>
						[Dot42.DexImport("UNKNOWN", "Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 16409)]
						public static readonly MessageClass UNKNOWN;
						private MessageClass() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 9)]
						public static MessageClass[] Values() /* MethodBuilder.Create */ 
						{
								return default(MessageClass[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 9)]
						public static MessageClass ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(MessageClass);
						}

				}

		}

}

