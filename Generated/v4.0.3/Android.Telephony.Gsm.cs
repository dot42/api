// Copyright (C) 2014 dot42
//
// Original filename: Android.Telephony.Gsm.cs
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
namespace Android.Telephony.Gsm
{
		/// <summary>
		/// <para>Represents the cell location on a GSM phone. </para>    
		/// </summary>
		/// <java-name>
		/// android/telephony/gsm/GsmCellLocation
		/// </java-name>
		[Dot42.DexImport("android/telephony/gsm/GsmCellLocation", AccessFlags = 33)]
		public partial class GsmCellLocation : global::Android.Telephony.CellLocation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Empty constructor. Initializes the LAC and CID to -1. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GsmCellLocation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initialize the object from a bundle. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public GsmCellLocation(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>gsm location area code, -1 if unknown, 0xffff max legal value </para>
				/// </returns>
				/// <java-name>
				/// getLac
				/// </java-name>
				[Dot42.DexImport("getLac", "()I", AccessFlags = 1)]
				public virtual int GetLac() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>gsm cell id, -1 if unknown, 0xffff max legal value </para>
				/// </returns>
				/// <java-name>
				/// getCid
				/// </java-name>
				[Dot42.DexImport("getCid", "()I", AccessFlags = 1)]
				public virtual int GetCid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>On a UMTS network, returns the primary scrambling code of the serving cell.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>primary scrambling code for UMTS, -1 if unknown or GSM </para>
				/// </returns>
				/// <java-name>
				/// getPsc
				/// </java-name>
				[Dot42.DexImport("getPsc", "()I", AccessFlags = 1)]
				public virtual int GetPsc() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Invalidate this object. The location area code and the cell id are set to -1. </para>        
				/// </summary>
				/// <java-name>
				/// setStateInvalid
				/// </java-name>
				[Dot42.DexImport("setStateInvalid", "()V", AccessFlags = 1)]
				public virtual void SetStateInvalid() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the location area code and the cell id. </para>        
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
				/// <para>Set intent notifier Bundle based on service state</para><para></para>        
				/// </summary>
				/// <java-name>
				/// fillInNotifierBundle
				/// </java-name>
				[Dot42.DexImport("fillInNotifierBundle", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void FillInNotifierBundle(global::Android.Os.Bundle m) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>gsm location area code, -1 if unknown, 0xffff max legal value </para>
				/// </returns>
				/// <java-name>
				/// getLac
				/// </java-name>
				public int Lac
				{
				[Dot42.DexImport("getLac", "()I", AccessFlags = 1)]
						get{ return GetLac(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>gsm cell id, -1 if unknown, 0xffff max legal value </para>
				/// </returns>
				/// <java-name>
				/// getCid
				/// </java-name>
				public int Cid
				{
				[Dot42.DexImport("getCid", "()I", AccessFlags = 1)]
						get{ return GetCid(); }
				}

				/// <summary>
				/// <para>On a UMTS network, returns the primary scrambling code of the serving cell.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>primary scrambling code for UMTS, -1 if unknown or GSM </para>
				/// </returns>
				/// <java-name>
				/// getPsc
				/// </java-name>
				public int Psc
				{
				[Dot42.DexImport("getPsc", "()I", AccessFlags = 1)]
						get{ return GetPsc(); }
				}

		}

		/// <java-name>
		/// android/telephony/gsm/SmsManager
		/// </java-name>
		[Dot42.DexImport("android/telephony/gsm/SmsManager", AccessFlags = 49)]
		public sealed partial class SmsManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STATUS_ON_SIM_FREE
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_FREE", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_FREE = 0;
				/// <java-name>
				/// STATUS_ON_SIM_READ
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_READ", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_READ = 1;
				/// <java-name>
				/// STATUS_ON_SIM_UNREAD
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_UNREAD", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_UNREAD = 3;
				/// <java-name>
				/// STATUS_ON_SIM_SENT
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_SENT", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_SENT = 5;
				/// <java-name>
				/// STATUS_ON_SIM_UNSENT
				/// </java-name>
				[Dot42.DexImport("STATUS_ON_SIM_UNSENT", "I", AccessFlags = 25)]
				public const int STATUS_ON_SIM_UNSENT = 7;
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
				/// getDefault
				/// </java-name>
				[Dot42.DexImport("getDefault", "()Landroid/telephony/gsm/SmsManager;", AccessFlags = 25)]
				public static global::Android.Telephony.Gsm.SmsManager GetDefault() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsManager);
				}

				/// <java-name>
				/// sendTextMessage
				/// </java-name>
				[Dot42.DexImport("sendTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/app/PendingIntent" +
    ";Landroid/app/PendingIntent;)V", AccessFlags = 17)]
				public void SendTextMessage(string @string, string string1, string string2, global::Android.App.PendingIntent pendingIntent, global::Android.App.PendingIntent pendingIntent1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// divideMessage
				/// </java-name>
				[Dot42.DexImport("divideMessage", "(Ljava/lang/String;)Ljava/util/ArrayList;", AccessFlags = 17, Signature = "(Ljava/lang/String;)Ljava/util/ArrayList<Ljava/lang/String;>;")]
				public global::Java.Util.ArrayList<string> DivideMessage(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<string>);
				}

				/// <java-name>
				/// sendMultipartTextMessage
				/// </java-name>
				[Dot42.DexImport("sendMultipartTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Lj" +
    "ava/util/ArrayList;)V", AccessFlags = 17, Signature = "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList<Ljava/lang/String;>;Lja" +
    "va/util/ArrayList<Landroid/app/PendingIntent;>;Ljava/util/ArrayList<Landroid/app" +
    "/PendingIntent;>;)V")]
				public void SendMultipartTextMessage(string @string, string string1, global::Java.Util.ArrayList<string> arrayList, global::Java.Util.ArrayList<global::Android.App.PendingIntent> arrayList1, global::Java.Util.ArrayList<global::Android.App.PendingIntent> arrayList2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendDataMessage
				/// </java-name>
				[Dot42.DexImport("sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/P" +
    "endingIntent;)V", AccessFlags = 17)]
				public void SendDataMessage(string @string, string string1, short int16, sbyte[] sByte, global::Android.App.PendingIntent pendingIntent, global::Android.App.PendingIntent pendingIntent1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendDataMessage
				/// </java-name>
				[Dot42.DexImport("sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/P" +
    "endingIntent;)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void SendDataMessage(string @string, string string1, short int16, byte[] @byte, global::Android.App.PendingIntent pendingIntent, global::Android.App.PendingIntent pendingIntent1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefault
				/// </java-name>
				public static global::Android.Telephony.Gsm.SmsManager Default
				{
				[Dot42.DexImport("getDefault", "()Landroid/telephony/gsm/SmsManager;", AccessFlags = 25)]
						get{ return GetDefault(); }
				}

		}

		/// <java-name>
		/// android/telephony/gsm/SmsMessage
		/// </java-name>
		[Dot42.DexImport("android/telephony/gsm/SmsMessage", AccessFlags = 33)]
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
				/// MAX_USER_DATA_SEPTETS
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_SEPTETS", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_SEPTETS = 160;
				/// <java-name>
				/// MAX_USER_DATA_SEPTETS_WITH_HEADER
				/// </java-name>
				[Dot42.DexImport("MAX_USER_DATA_SEPTETS_WITH_HEADER", "I", AccessFlags = 25)]
				public const int MAX_USER_DATA_SEPTETS_WITH_HEADER = 153;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SmsMessage() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createFromPdu
				/// </java-name>
				[Dot42.DexImport("createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;", AccessFlags = 9)]
				public static global::Android.Telephony.Gsm.SmsMessage CreateFromPdu(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage);
				}

				/// <java-name>
				/// createFromPdu
				/// </java-name>
				[Dot42.DexImport("createFromPdu", "([B)Landroid/telephony/gsm/SmsMessage;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Telephony.Gsm.SmsMessage CreateFromPdu(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage);
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
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Landroid/telephony/gsm/S" +
    "msMessage$SubmitPdu;", AccessFlags = 9)]
				public static global::Android.Telephony.Gsm.SmsMessage.SubmitPdu GetSubmitPdu(string @string, string string1, string string2, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage.SubmitPdu);
				}

				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$Submi" +
    "tPdu;", AccessFlags = 9)]
				public static global::Android.Telephony.Gsm.SmsMessage.SubmitPdu GetSubmitPdu(string @string, string string1, short int16, sbyte[] sByte, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage.SubmitPdu);
				}

				/// <java-name>
				/// getSubmitPdu
				/// </java-name>
				[Dot42.DexImport("getSubmitPdu", "(Ljava/lang/String;Ljava/lang/String;S[BZ)Landroid/telephony/gsm/SmsMessage$Submi" +
    "tPdu;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Telephony.Gsm.SmsMessage.SubmitPdu GetSubmitPdu(string @string, string string1, short int16, byte[] @byte, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage.SubmitPdu);
				}

				/// <java-name>
				/// getServiceCenterAddress
				/// </java-name>
				[Dot42.DexImport("getServiceCenterAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetServiceCenterAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getOriginatingAddress
				/// </java-name>
				[Dot42.DexImport("getOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetOriginatingAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDisplayOriginatingAddress
				/// </java-name>
				[Dot42.DexImport("getDisplayOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDisplayOriginatingAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMessageBody
				/// </java-name>
				[Dot42.DexImport("getMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMessageBody() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMessageClass
				/// </java-name>
				[Dot42.DexImport("getMessageClass", "()Landroid/telephony/gsm/SmsMessage$MessageClass;", AccessFlags = 1)]
				public virtual global::Android.Telephony.Gsm.SmsMessage.MessageClass GetMessageClass() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Telephony.Gsm.SmsMessage.MessageClass);
				}

				/// <java-name>
				/// getDisplayMessageBody
				/// </java-name>
				[Dot42.DexImport("getDisplayMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDisplayMessageBody() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPseudoSubject
				/// </java-name>
				[Dot42.DexImport("getPseudoSubject", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPseudoSubject() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTimestampMillis
				/// </java-name>
				[Dot42.DexImport("getTimestampMillis", "()J", AccessFlags = 1)]
				public virtual long GetTimestampMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// isEmail
				/// </java-name>
				[Dot42.DexImport("isEmail", "()Z", AccessFlags = 1)]
				public virtual bool IsEmail() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getEmailBody
				/// </java-name>
				[Dot42.DexImport("getEmailBody", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEmailBody() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getEmailFrom
				/// </java-name>
				[Dot42.DexImport("getEmailFrom", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetEmailFrom() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProtocolIdentifier
				/// </java-name>
				[Dot42.DexImport("getProtocolIdentifier", "()I", AccessFlags = 1)]
				public virtual int GetProtocolIdentifier() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isReplace
				/// </java-name>
				[Dot42.DexImport("isReplace", "()Z", AccessFlags = 1)]
				public virtual bool IsReplace() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isCphsMwiMessage
				/// </java-name>
				[Dot42.DexImport("isCphsMwiMessage", "()Z", AccessFlags = 1)]
				public virtual bool IsCphsMwiMessage() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMWIClearMessage
				/// </java-name>
				[Dot42.DexImport("isMWIClearMessage", "()Z", AccessFlags = 1)]
				public virtual bool IsMWIClearMessage() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMWISetMessage
				/// </java-name>
				[Dot42.DexImport("isMWISetMessage", "()Z", AccessFlags = 1)]
				public virtual bool IsMWISetMessage() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMwiDontStore
				/// </java-name>
				[Dot42.DexImport("isMwiDontStore", "()Z", AccessFlags = 1)]
				public virtual bool IsMwiDontStore() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// getUserData
				/// </java-name>
				[Dot42.DexImport("getUserData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetUserData() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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
				/// getPdu
				/// </java-name>
				[Dot42.DexImport("getPdu", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetPdu() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getStatusOnSim
				/// </java-name>
				[Dot42.DexImport("getStatusOnSim", "()I", AccessFlags = 1)]
				public virtual int GetStatusOnSim() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIndexOnSim
				/// </java-name>
				[Dot42.DexImport("getIndexOnSim", "()I", AccessFlags = 1)]
				public virtual int GetIndexOnSim() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getStatus
				/// </java-name>
				[Dot42.DexImport("getStatus", "()I", AccessFlags = 1)]
				public virtual int GetStatus() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isStatusReportMessage
				/// </java-name>
				[Dot42.DexImport("isStatusReportMessage", "()Z", AccessFlags = 1)]
				public virtual bool IsStatusReportMessage() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isReplyPathPresent
				/// </java-name>
				[Dot42.DexImport("isReplyPathPresent", "()Z", AccessFlags = 1)]
				public virtual bool IsReplyPathPresent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getServiceCenterAddress
				/// </java-name>
				public string ServiceCenterAddress
				{
				[Dot42.DexImport("getServiceCenterAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetServiceCenterAddress(); }
				}

				/// <java-name>
				/// getOriginatingAddress
				/// </java-name>
				public string OriginatingAddress
				{
				[Dot42.DexImport("getOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetOriginatingAddress(); }
				}

				/// <java-name>
				/// getDisplayOriginatingAddress
				/// </java-name>
				public string DisplayOriginatingAddress
				{
				[Dot42.DexImport("getDisplayOriginatingAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDisplayOriginatingAddress(); }
				}

				/// <java-name>
				/// getMessageBody
				/// </java-name>
				public string MessageBody
				{
				[Dot42.DexImport("getMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMessageBody(); }
				}

				/// <java-name>
				/// getDisplayMessageBody
				/// </java-name>
				public string DisplayMessageBody
				{
				[Dot42.DexImport("getDisplayMessageBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDisplayMessageBody(); }
				}

				/// <java-name>
				/// getPseudoSubject
				/// </java-name>
				public string PseudoSubject
				{
				[Dot42.DexImport("getPseudoSubject", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPseudoSubject(); }
				}

				/// <java-name>
				/// getTimestampMillis
				/// </java-name>
				public long TimestampMillis
				{
				[Dot42.DexImport("getTimestampMillis", "()J", AccessFlags = 1)]
						get{ return GetTimestampMillis(); }
				}

				/// <java-name>
				/// getEmailBody
				/// </java-name>
				public string EmailBody
				{
				[Dot42.DexImport("getEmailBody", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEmailBody(); }
				}

				/// <java-name>
				/// getEmailFrom
				/// </java-name>
				public string EmailFrom
				{
				[Dot42.DexImport("getEmailFrom", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetEmailFrom(); }
				}

				/// <java-name>
				/// getProtocolIdentifier
				/// </java-name>
				public int ProtocolIdentifier
				{
				[Dot42.DexImport("getProtocolIdentifier", "()I", AccessFlags = 1)]
						get{ return GetProtocolIdentifier(); }
				}

				/// <java-name>
				/// getUserData
				/// </java-name>
				public byte[] UserData
				{
				[Dot42.DexImport("getUserData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetUserData(); }
				}

				/// <java-name>
				/// getPdu
				/// </java-name>
				public byte[] Pdu
				{
				[Dot42.DexImport("getPdu", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetPdu(); }
				}

				/// <java-name>
				/// getStatusOnSim
				/// </java-name>
				public int StatusOnSim
				{
				[Dot42.DexImport("getStatusOnSim", "()I", AccessFlags = 1)]
						get{ return GetStatusOnSim(); }
				}

				/// <java-name>
				/// getIndexOnSim
				/// </java-name>
				public int IndexOnSim
				{
				[Dot42.DexImport("getIndexOnSim", "()I", AccessFlags = 1)]
						get{ return GetIndexOnSim(); }
				}

				/// <java-name>
				/// getStatus
				/// </java-name>
				public int Status
				{
				[Dot42.DexImport("getStatus", "()I", AccessFlags = 1)]
						get{ return GetStatus(); }
				}

				/// <java-name>
				/// android/telephony/gsm/SmsMessage$SubmitPdu
				/// </java-name>
				[Dot42.DexImport("android/telephony/gsm/SmsMessage$SubmitPdu", AccessFlags = 9)]
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
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public SubmitPdu() /* MethodBuilder.Create */ 
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

				}

		}

}


