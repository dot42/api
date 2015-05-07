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
				public FormatException(string message) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public FormatException(string message, global::System.Exception e) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Represents an immutable NDEF Message. </para> <para>NDEF (NFC Data Exchange Format) is a light-weight binary format, used to encapsulate typed data. It is specified by the NFC Forum, for transmission and storage with NFC, however it is transport agnostic. </para> <para>NDEF defines messages and records. An NDEF Record contains typed data, such as MIME-type media, a URI, or a custom application payload. An NDEF Message is a container for one or more NDEF Records. </para> <para>When an Android device receives an NDEF Message (for example by reading an NFC tag) it processes it through a dispatch mechanism to determine an activity to launch. The type of the  <b>first</b> record in the message has special importance for message dispatch, so design this record carefully. </para> <para>Use NdefMessage(byte[]) to construct an NDEF Message from binary data, or NdefMessage(NdefRecord[]) to construct from one or more NdefRecords. </para> <para>NdefMessage and NdefRecord implementations are always available, even on Android devices that do not have NFC hardware. </para> <para>NdefRecords are intended to be immutable (and thread-safe), however they may contain mutable fields. So take care not to modify mutable fields passed into constructors, or modify mutable fields obtained by getter methods, unless such modification is explicitly marked as safe.</para> <para> <para>NfcAdapter::ACTION_NDEF_DISCOVERED </para> <para>NdefRecord </para></para>    
		/// </summary>
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
				/// <summary>
				///  <para>Construct an NDEF Message from one or more NDEF Records.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public NdefMessage(sbyte[] records) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct an NDEF Message from one or more NDEF Records.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NdefMessage(byte[] records) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct an NDEF Message from one or more NDEF Records.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/nfc/NdefRecord;[Landroid/nfc/NdefRecord;)V", AccessFlags = 129)]
				public NdefMessage(global::Android.Nfc.NdefRecord record, params global::Android.Nfc.NdefRecord[] records) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct an NDEF Message from one or more NDEF Records.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Landroid/nfc/NdefRecord;)V", AccessFlags = 1)]
				public NdefMessage(global::Android.Nfc.NdefRecord[] records) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return this NDEF Message as raw bytes.</para> <para>The NDEF Message is formatted as per the NDEF 1.0 specification, and the byte array is suitable for network transmission or storage in an NFC Forum NDEF compatible tag.</para> <para>This method will not chunk any records, and will always use the short record (SR) format and omit the identifier field when possible.</para> <para> <para>getByteArrayLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>NDEF Message in binary format </para>
				/// </returns>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Return this NDEF Message as raw bytes.</para> <para>The NDEF Message is formatted as per the NDEF 1.0 specification, and the byte array is suitable for network transmission or storage in an NFC Forum NDEF compatible tag.</para> <para>This method will not chunk any records, and will always use the short record (SR) format and omit the identifier field when possible.</para> <para> <para>getByteArrayLength </para></para>        
				/// </summary>
				/// <returns>
				///  <para>NDEF Message in binary format </para>
				/// </returns>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns true if the specified NDEF Message contains identical NDEF Records. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NdefMessage() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Get the NDEF Records inside this NDEF Message.</para> <para>An NdefMessage always has one or more NDEF Records: so the following code to retrieve the first record is always safe (no need to check for null or array length &gt;= 1):  <pre>
				/// NdefRecord firstRecord = ndefMessage.getRecords()[0];
				/// </pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>array of one or more NDEF records. </para>
				/// </returns>
				/// <java-name>
				/// getRecords
				/// </java-name>
				public global::Android.Nfc.NdefRecord[] Records
				{
						[Dot42.DexImport("getRecords", "()[Landroid/nfc/NdefRecord;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.NdefRecord[]); }
				}

				/// <summary>
				///  <para>Return the length of this NDEF Message if it is written to a byte array with toByteArray.</para> <para>An NDEF Message can be formatted to bytes in different ways depending on chunking, SR, and ID flags, so the length returned by this method may not be equal to the length of the original byte array used to construct this NDEF Message. However it will always be equal to the length of the byte array produced by toByteArray.</para> <para> <para>toByteArray </para></para>        
				/// </summary>
				/// <returns>
				///  <para>length of this NDEF Message when written to bytes with toByteArray </para>
				/// </returns>
				/// <java-name>
				/// getByteArrayLength
				/// </java-name>
				public int ByteArrayLength
				{
						[Dot42.DexImport("getByteArrayLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Represents an immutable NDEF Record. </para> <para>NDEF (NFC Data Exchange Format) is a light-weight binary format, used to encapsulate typed data. It is specified by the NFC Forum, for transmission and storage with NFC, however it is transport agnostic. </para> <para>NDEF defines messages and records. An NDEF Record contains typed data, such as MIME-type media, a URI, or a custom application payload. An NDEF Message is a container for one or more NDEF Records. </para> <para>This class represents logical (complete) NDEF Records, and can not be used to represent chunked (partial) NDEF Records. However NdefMessage#NdefMessage(byte[]) can be used to parse a message containing chunked records, and will return a message with unchunked (complete) records. </para> <para>A logical NDEF Record always contains a 3-bit TNF (Type Name Field) that provides high level typing for the rest of the record. The remaining fields are variable length and not always present:  <ul> <li> <para> <b>type</b>: detailed typing for the payload </para></li> <li> <para> <b>id</b>: identifier meta-data, not commonly used </para></li> <li> <para> <b>payload</b>: the actual payload </para></li></ul></para> <para>Helpers such as NdefRecord#createUri, NdefRecord#createMime and NdefRecord#createExternal are included to create well-formatted NDEF Records with correctly set tnf, type, id and payload fields, please use these helpers whenever possible. </para> <para>Use the constructor NdefRecord(short, byte[], byte[], byte[]) if you know what you are doing and what to set the fields individually. Only basic validation is performed with this constructor, so it is possible to create records that do not confirm to the strict NFC Forum specifications. </para> <para>The binary representation of an NDEF Record includes additional flags to indicate location with an NDEF message, provide support for chunking of NDEF records, and to pack optional fields. This class does not expose those details. To write an NDEF Record as binary you must first put it into an NdefMessage, then call NdefMessage#toByteArray(). </para> <para>NdefMessage and NdefRecord implementations are always available, even on Android devices that do not have NFC hardware. </para> <para>NdefRecords are intended to be immutable (and thread-safe), however they may contain mutable fields. So take care not to modify mutable fields passed into constructors, or modify mutable fields obtained by getter methods, unless such modification is explicitly marked as safe.</para> <para> <para>NfcAdapter::ACTION_NDEF_DISCOVERED </para> <para>NdefMessage </para></para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/NdefRecord
		/// </java-name>
		[Dot42.DexImport("android/nfc/NdefRecord", AccessFlags = 49)]
		public sealed partial class NdefRecord : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Indicates the record is empty.</para> <para>Type, id and payload fields are empty in a { TNF_EMPTY} record. </para>        
				/// </summary>
				/// <java-name>
				/// TNF_EMPTY
				/// </java-name>
				[Dot42.DexImport("TNF_EMPTY", "S", AccessFlags = 25)]
				public const short TNF_EMPTY = 0;
				/// <summary>
				///  <para>Indicates the type field contains a well-known RTD type name.</para> <para>Use this tnf with RTD types such as RTD_TEXT, RTD_URI. </para> <para>The RTD type name format is specified in NFCForum-TS-RTD_1.0.</para> <para> <para>RTD_URI </para> <para>RTD_TEXT </para> <para>RTD_SMART_POSTER </para> <para>createUri </para></para>        
				/// </summary>
				/// <java-name>
				/// TNF_WELL_KNOWN
				/// </java-name>
				[Dot42.DexImport("TNF_WELL_KNOWN", "S", AccessFlags = 25)]
				public const short TNF_WELL_KNOWN = 1;
				/// <summary>
				///  <para>Indicates the type field contains a media-type BNF construct, defined by RFC 2046.</para> <para>Use this with MIME type names such as { "image/jpeg"}, or using the helper createMime.</para> <para> <para>createMime </para></para>        
				/// </summary>
				/// <java-name>
				/// TNF_MIME_MEDIA
				/// </java-name>
				[Dot42.DexImport("TNF_MIME_MEDIA", "S", AccessFlags = 25)]
				public const short TNF_MIME_MEDIA = 2;
				/// <summary>
				///  <para>Indicates the type field contains an absolute-URI BNF construct defined by RFC 3986.</para> <para>When creating new records prefer createUri, since it offers more compact URI encoding ({ RTD_URI} allows compression of common URI prefixes).</para> <para> <para>createUri </para></para>        
				/// </summary>
				/// <java-name>
				/// TNF_ABSOLUTE_URI
				/// </java-name>
				[Dot42.DexImport("TNF_ABSOLUTE_URI", "S", AccessFlags = 25)]
				public const short TNF_ABSOLUTE_URI = 3;
				/// <summary>
				///  <para>Indicates the type field contains an external type name.</para> <para>Used to encode custom payloads. When creating new records use the helper createExternal.</para> <para>The external-type RTD format is specified in NFCForum-TS-RTD_1.0.</para> <para>Note this TNF should not be used with RTD_TEXT or RTD_URI constants. Those are well known RTD constants, not external RTD constants.</para> <para> <para>createExternal </para></para>        
				/// </summary>
				/// <java-name>
				/// TNF_EXTERNAL_TYPE
				/// </java-name>
				[Dot42.DexImport("TNF_EXTERNAL_TYPE", "S", AccessFlags = 25)]
				public const short TNF_EXTERNAL_TYPE = 4;
				/// <summary>
				///  <para>Indicates the payload type is unknown.</para> <para>NFC Forum explains this should be treated similarly to the "application/octet-stream" MIME type. The payload type is not explicitly encoded within the record. </para> <para>The type field is empty in an { TNF_UNKNOWN} record. </para>        
				/// </summary>
				/// <java-name>
				/// TNF_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("TNF_UNKNOWN", "S", AccessFlags = 25)]
				public const short TNF_UNKNOWN = 5;
				/// <summary>
				///  <para>Indicates the payload is an intermediate or final chunk of a chunked NDEF Record.</para> <para>{ TNF_UNCHANGED} can not be used with this class since all NdefRecords are already unchunked, however they may appear in the binary format. </para>        
				/// </summary>
				/// <java-name>
				/// TNF_UNCHANGED
				/// </java-name>
				[Dot42.DexImport("TNF_UNCHANGED", "S", AccessFlags = 25)]
				public const short TNF_UNCHANGED = 6;
				/// <summary>
				///  <para>RTD Text type. For use with { TNF_WELL_KNOWN}.  <para>TNF_WELL_KNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// RTD_TEXT
				/// </java-name>
				[Dot42.DexImport("RTD_TEXT", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_TEXT;
				/// <summary>
				///  <para>RTD URI type. For use with { TNF_WELL_KNOWN}.  <para>TNF_WELL_KNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// RTD_URI
				/// </java-name>
				[Dot42.DexImport("RTD_URI", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_URI;
				/// <summary>
				///  <para>RTD Smart Poster type. For use with { TNF_WELL_KNOWN}.  <para>TNF_WELL_KNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// RTD_SMART_POSTER
				/// </java-name>
				[Dot42.DexImport("RTD_SMART_POSTER", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_SMART_POSTER;
				/// <summary>
				///  <para>RTD Alternative Carrier type. For use with { TNF_WELL_KNOWN}.  <para>TNF_WELL_KNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// RTD_ALTERNATIVE_CARRIER
				/// </java-name>
				[Dot42.DexImport("RTD_ALTERNATIVE_CARRIER", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_ALTERNATIVE_CARRIER;
				/// <summary>
				///  <para>RTD Handover Carrier type. For use with { TNF_WELL_KNOWN}.  <para>TNF_WELL_KNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// RTD_HANDOVER_CARRIER
				/// </java-name>
				[Dot42.DexImport("RTD_HANDOVER_CARRIER", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_HANDOVER_CARRIER;
				/// <summary>
				///  <para>RTD Handover Request type. For use with { TNF_WELL_KNOWN}.  <para>TNF_WELL_KNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// RTD_HANDOVER_REQUEST
				/// </java-name>
				[Dot42.DexImport("RTD_HANDOVER_REQUEST", "[B", AccessFlags = 25)]
				public static readonly sbyte[] RTD_HANDOVER_REQUEST;
				/// <summary>
				///  <para>RTD Handover Select type. For use with { TNF_WELL_KNOWN}.  <para>TNF_WELL_KNOWN </para></para>        
				/// </summary>
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
				/// <summary>
				///  <para>Construct an NDEF Record from its component fields.</para> <para>Recommend to use helpers such as {createUri} or {createExternal where possible, since they perform stricter validation that the record is correctly formatted as per NDEF specifications. However if you know what you are doing then this constructor offers the most flexibility.</para> <para>An NdefRecord represents a logical (complete) record, and cannot represent NDEF Record chunks.</para> <para>Basic validation of the tnf, type, id and payload is performed as per the following rules:  <ul> <li> <para>The tnf paramter must be a 3-bit value. </para></li> <li> <para>Records with a tnf of TNF_EMPTY cannot have a type, id or payload. </para></li> <li> <para>Records with a tnf of TNF_UNKNOWN or { 0x07} cannot have a type. </para></li> <li> <para>Records with a tnf of TNF_UNCHANGED are not allowed since this class only represents complete (unchunked) records. </para></li></ul>This minimal validation is specified by NFCForum-TS-NDEF_1.0 section 3.2.6 (Type Name Format).</para> <para>If any of the above validation steps fail then IllegalArgumentException is thrown.</para> <para>Deep inspection of the type, id and payload fields is not performed, so it is possible to create NDEF Records that conform to section 3.2.6 but fail other more strict NDEF specification requirements. For example, the payload may be invalid given the tnf and type. </para> <para>To omit a type, id or payload field, set the parameter to an empty byte array or null.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(S[B[B[B)V", AccessFlags = 1)]
				public NdefRecord(short tnf, sbyte[] type, sbyte[] id, sbyte[] payload) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct an NDEF Record from its component fields.</para> <para>Recommend to use helpers such as {createUri} or {createExternal where possible, since they perform stricter validation that the record is correctly formatted as per NDEF specifications. However if you know what you are doing then this constructor offers the most flexibility.</para> <para>An NdefRecord represents a logical (complete) record, and cannot represent NDEF Record chunks.</para> <para>Basic validation of the tnf, type, id and payload is performed as per the following rules:  <ul> <li> <para>The tnf paramter must be a 3-bit value. </para></li> <li> <para>Records with a tnf of TNF_EMPTY cannot have a type, id or payload. </para></li> <li> <para>Records with a tnf of TNF_UNKNOWN or { 0x07} cannot have a type. </para></li> <li> <para>Records with a tnf of TNF_UNCHANGED are not allowed since this class only represents complete (unchunked) records. </para></li></ul>This minimal validation is specified by NFCForum-TS-NDEF_1.0 section 3.2.6 (Type Name Format).</para> <para>If any of the above validation steps fail then IllegalArgumentException is thrown.</para> <para>Deep inspection of the type, id and payload fields is not performed, so it is possible to create NDEF Records that conform to section 3.2.6 but fail other more strict NDEF specification requirements. For example, the payload may be invalid given the tnf and type. </para> <para>To omit a type, id or payload field, set the parameter to an empty byte array or null.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(S[B[B[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NdefRecord(short tnf, byte[] type, byte[] id, byte[] payload) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct an NDEF Record from raw bytes.</para> <para>This method is deprecated, use NdefMessage#NdefMessage(byte[]) instead. This is because it does not make sense to parse a record: the NDEF binary format is only defined for a message, and the record flags MB and ME do not make sense outside of the context of an entire message.</para> <para>This implementation will attempt to parse a single record by ignoring the MB and ME flags, and otherwise following the rules of NdefMessage#NdefMessage(byte[]).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use NdefMessage#NdefMessage(byte[]) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public NdefRecord(sbyte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Construct an NDEF Record from raw bytes.</para> <para>This method is deprecated, use NdefMessage#NdefMessage(byte[]) instead. This is because it does not make sense to parse a record: the NDEF binary format is only defined for a message, and the record flags MB and ME do not make sense outside of the context of an entire message.</para> <para>This implementation will attempt to parse a single record by ignoring the MB and ME flags, and otherwise following the rules of NdefMessage#NdefMessage(byte[]).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use NdefMessage#NdefMessage(byte[]) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NdefRecord(byte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new Android Application Record (AAR). </para> <para>This record indicates to other Android devices the package that should be used to handle the entire NDEF message. You can embed this record anywhere into your message to ensure that the intended package receives the message. </para> <para>When an Android device dispatches an NdefMessage containing one or more Android application records, the applications contained in those records will be the preferred target for the NfcAdapter#ACTION_NDEF_DISCOVERED intent, in the order in which they appear in the message. This dispatch behavior was first added to Android in Ice Cream Sandwich. </para> <para>If none of the applications have a are installed on the device, a Market link will be opened to the first application. </para> <para>Note that Android application records do not overrule applications that have called NfcAdapter#enableForegroundDispatch.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Android application NDEF record </para>
				/// </returns>
				/// <java-name>
				/// createApplicationRecord
				/// </java-name>
				[Dot42.DexImport("createApplicationRecord", "(Ljava/lang/String;)Landroid/nfc/NdefRecord;", AccessFlags = 9)]
				public static global::Android.Nfc.NdefRecord CreateApplicationRecord(string packageName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <summary>
				///  <para>Create a new NDEF Record containing a URI.</para> <para>Use this method to encode a URI (or URL) into an NDEF Record.</para> <para>Uses the well known URI type representation: TNF_WELL_KNOWN and RTD_URI. This is the most efficient encoding of a URI into NDEF.</para> <para>The uri parameter will be normalized with Uri#normalizeScheme to set the scheme to lower case to follow Android best practices for intent filtering. However the unchecked exception IllegalArgumentException may be thrown if the uri parameter has serious problems, for example if it is empty, so always catch this exception if you are passing user-generated data into this method.</para> <para>Reference specification: NFCForum-TS-RTD_URI_1.0</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an NDEF Record containing the URI </para>
				/// </returns>
				/// <java-name>
				/// createUri
				/// </java-name>
				[Dot42.DexImport("createUri", "(Landroid/net/Uri;)Landroid/nfc/NdefRecord;", AccessFlags = 9)]
				public static global::Android.Nfc.NdefRecord CreateUri(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <summary>
				///  <para>Create a new NDEF Record containing a URI.</para> <para>Use this method to encode a URI (or URL) into an NDEF Record.</para> <para>Uses the well known URI type representation: TNF_WELL_KNOWN and RTD_URI. This is the most efficient encoding of a URI into NDEF.</para> <para>The uri parameter will be normalized with Uri#normalizeScheme to set the scheme to lower case to follow Android best practices for intent filtering. However the unchecked exception IllegalArgumentException may be thrown if the uri parameter has serious problems, for example if it is empty, so always catch this exception if you are passing user-generated data into this method.</para> <para>Reference specification: NFCForum-TS-RTD_URI_1.0</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an NDEF Record containing the URI </para>
				/// </returns>
				/// <java-name>
				/// createUri
				/// </java-name>
				[Dot42.DexImport("createUri", "(Ljava/lang/String;)Landroid/nfc/NdefRecord;", AccessFlags = 9)]
				public static global::Android.Nfc.NdefRecord CreateUri(string uri) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <summary>
				///  <para>Create a new NDEF Record containing MIME data.</para> <para>Use this method to encode MIME-typed data into an NDEF Record, such as "text/plain", or "image/jpeg".</para> <para>The mimeType parameter will be normalized with Intent#normalizeMimeType to follow Android best practices for intent filtering, for example to force lower-case. However the unchecked exception IllegalArgumentException may be thrown if the mimeType parameter has serious problems, for example if it is empty, so always catch this exception if you are passing user-generated data into this method. </para> <para>For efficiency, This method might not make an internal copy of the mimeData byte array, so take care not to modify the mimeData byte array while still using the returned NdefRecord.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an NDEF Record containing the MIME-typed data </para>
				/// </returns>
				/// <java-name>
				/// createMime
				/// </java-name>
				[Dot42.DexImport("createMime", "(Ljava/lang/String;[B)Landroid/nfc/NdefRecord;", AccessFlags = 9)]
				public static global::Android.Nfc.NdefRecord CreateMime(string mimeType, sbyte[] mimeData) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <summary>
				///  <para>Create a new NDEF Record containing MIME data.</para> <para>Use this method to encode MIME-typed data into an NDEF Record, such as "text/plain", or "image/jpeg".</para> <para>The mimeType parameter will be normalized with Intent#normalizeMimeType to follow Android best practices for intent filtering, for example to force lower-case. However the unchecked exception IllegalArgumentException may be thrown if the mimeType parameter has serious problems, for example if it is empty, so always catch this exception if you are passing user-generated data into this method. </para> <para>For efficiency, This method might not make an internal copy of the mimeData byte array, so take care not to modify the mimeData byte array while still using the returned NdefRecord.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an NDEF Record containing the MIME-typed data </para>
				/// </returns>
				/// <java-name>
				/// createMime
				/// </java-name>
				[Dot42.DexImport("createMime", "(Ljava/lang/String;[B)Landroid/nfc/NdefRecord;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Nfc.NdefRecord CreateMime(string mimeType, byte[] mimeData) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <summary>
				///  <para>Create a new NDEF Record containing external (application-specific) data.</para> <para>Use this method to encode application specific data into an NDEF Record. The data is typed by a domain name (usually your Android package name) and a domain-specific type. This data is packaged into a "NFC Forum ExternalType" NDEF Record.</para> <para>NFC Forum requires that the domain and type used in an external record are treated as case insensitive, however Android intent filtering is always case sensitive. So this method will force the domain and type to lower-case before creating the NDEF Record.</para> <para>The unchecked exception IllegalArgumentException will be thrown if the domain and type have serious problems, for example if either field is empty, so always catch this exception if you are passing user-generated data into this method.</para> <para>There are no such restrictions on the payload data.</para> <para>For efficiency, This method might not make an internal copy of the data byte array, so take care not to modify the data byte array while still using the returned NdefRecord.</para> <para>Reference specification: NFCForum-TS-RTD_1.0 </para>        
				/// </summary>
				/// <java-name>
				/// createExternal
				/// </java-name>
				[Dot42.DexImport("createExternal", "(Ljava/lang/String;Ljava/lang/String;[B)Landroid/nfc/NdefRecord;", AccessFlags = 9)]
				public static global::Android.Nfc.NdefRecord CreateExternal(string domain, string type, sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <summary>
				///  <para>Create a new NDEF Record containing external (application-specific) data.</para> <para>Use this method to encode application specific data into an NDEF Record. The data is typed by a domain name (usually your Android package name) and a domain-specific type. This data is packaged into a "NFC Forum ExternalType" NDEF Record.</para> <para>NFC Forum requires that the domain and type used in an external record are treated as case insensitive, however Android intent filtering is always case sensitive. So this method will force the domain and type to lower-case before creating the NDEF Record.</para> <para>The unchecked exception IllegalArgumentException will be thrown if the domain and type have serious problems, for example if either field is empty, so always catch this exception if you are passing user-generated data into this method.</para> <para>There are no such restrictions on the payload data.</para> <para>For efficiency, This method might not make an internal copy of the data byte array, so take care not to modify the data byte array while still using the returned NdefRecord.</para> <para>Reference specification: NFCForum-TS-RTD_1.0 </para>        
				/// </summary>
				/// <java-name>
				/// createExternal
				/// </java-name>
				[Dot42.DexImport("createExternal", "(Ljava/lang/String;Ljava/lang/String;[B)Landroid/nfc/NdefRecord;", AccessFlags = 9, IgnoreFromJava = true)]
				public static global::Android.Nfc.NdefRecord CreateExternal(string domain, string type, byte[] data) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NdefRecord);
				}

				/// <summary>
				///  <para>Returns the variable length Type field. </para> <para>This should be used in conjunction with the TNF field to determine the payload format. </para> <para>Returns an empty byte array if this record does not have a type field. </para>        
				/// </summary>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetType() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the variable length ID. </para> <para>Returns an empty byte array if this record does not have an id field. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetId() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns the variable length payload. </para> <para>Returns an empty byte array if this record does not have a payload field. </para>        
				/// </summary>
				/// <java-name>
				/// getPayload
				/// </java-name>
				[Dot42.DexImport("getPayload", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetPayload() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Return this NDEF Record as a byte array.</para> <para>This method is deprecated, use NdefMessage#toByteArray instead. This is because the NDEF binary format is not defined for a record outside of the context of a message: the MB and ME flags cannot be set without knowing the location inside a message.</para> <para>This implementation will attempt to serialize a single record by always setting the MB and ME flags (in other words, assume this is a single-record NDEF Message).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use NdefMessage#toByteArray() instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1)]
				public sbyte[] JavaToByteArray() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Return this NDEF Record as a byte array.</para> <para>This method is deprecated, use NdefMessage#toByteArray instead. This is because the NDEF binary format is not defined for a record outside of the context of a message: the MB and ME flags cannot be set without knowing the location inside a message.</para> <para>This implementation will attempt to serialize a single record by always setting the MB and ME flags (in other words, assume this is a single-record NDEF Message).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use NdefMessage#toByteArray() instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] ToByteArray() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Map this record to a MIME type, or return null if it cannot be mapped.</para> <para>Currently this method considers all TNF_MIME_MEDIA records to be MIME records, as well as some TNF_WELL_KNOWN records such as RTD_TEXT. If this is a MIME record then the MIME type as string is returned, otherwise null is returned.</para> <para>This method does not perform validation that the MIME type is actually valid. It always attempts to return a string containing the type if this is a MIME record.</para> <para>The returned MIME type will by normalized to lower-case using Intent#normalizeMimeType.</para> <para>The MIME payload can be obtained using getPayload.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>MIME type as a string, or null if this is not a MIME record </para>
				/// </returns>
				/// <java-name>
				/// toMimeType
				/// </java-name>
				[Dot42.DexImport("toMimeType", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToMimeType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Map this record to a URI, or return null if it cannot be mapped.</para> <para>Currently this method considers the following to be URI records:  <ul> <li> <para>TNF_ABSOLUTE_URI records. </para></li> <li> <para>TNF_WELL_KNOWN with a type of RTD_URI. </para></li> <li> <para>TNF_WELL_KNOWN with a type of RTD_SMART_POSTER and containing a URI record in the NDEF message nested in the payload.  </para></li> <li> <para>TNF_EXTERNAL_TYPE records. </para></li></ul>If this is not a URI record by the above rules, then null is returned.</para> <para>This method does not perform validation that the URI is actually valid: it always attempts to create and return a URI if this record appears to be a URI record by the above rules.</para> <para>The returned URI will be normalized to have a lower case scheme using Uri#normalizeScheme.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>URI, or null if this is not a URI record </para>
				/// </returns>
				/// <java-name>
				/// toUri
				/// </java-name>
				[Dot42.DexImport("toUri", "()Landroid/net/Uri;", AccessFlags = 1)]
				public global::Android.Net.Uri ToUri() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns true if the specified NDEF Record contains identical tnf, type, id and payload fields. </para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NdefRecord() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the 3-bit TNF. </para> <para>TNF is the top-level type. </para>        
				/// </summary>
				/// <java-name>
				/// getTnf
				/// </java-name>
				public short Tnf
				{
						[Dot42.DexImport("getTnf", "()S", AccessFlags = 1)]
						get{ return default(short); }
				}

				/// <summary>
				///  <para>Returns the variable length Type field. </para> <para>This should be used in conjunction with the TNF field to determine the payload format. </para> <para>Returns an empty byte array if this record does not have a type field. </para>        
				/// </summary>
				/// <java-name>
				/// getType
				/// </java-name>
				public byte[] Type
				{
						[Dot42.DexImport("getType", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the variable length ID. </para> <para>Returns an empty byte array if this record does not have an id field. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				public byte[] Id
				{
						[Dot42.DexImport("getId", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the variable length payload. </para> <para>Returns an empty byte array if this record does not have a payload field. </para>        
				/// </summary>
				/// <java-name>
				/// getPayload
				/// </java-name>
				public byte[] Payload
				{
						[Dot42.DexImport("getPayload", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <summary>
		///  <para>Represents the local NFC adapter. </para> <para>Use the helper getDefaultAdapter(Context) to get the default NFC adapter for this Android device.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using NFC, read the  developer guide.</para> <para> </para> <para>To perform basic file sharing between devices, read .  </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/NfcAdapter
		/// </java-name>
		[Dot42.DexImport("android/nfc/NfcAdapter", AccessFlags = 49)]
		public sealed partial class NfcAdapter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Intent to start an activity when a tag with NDEF payload is discovered.</para> <para>The system inspects the first NdefRecord in the first NdefMessage and looks for a URI, SmartPoster, or MIME record. If a URI or SmartPoster record is found the intent will contain the URI in its data field. If a MIME record is found the intent will contain the MIME type in its type field. This allows activities to register IntentFilters targeting specific content on tags. Activities should register the most specific intent filters possible to avoid the activity chooser dialog, which can disrupt the interaction with the tag as the user interacts with the screen.</para> <para>If the tag has an NDEF payload this intent is started before ACTION_TECH_DISCOVERED. If any activities respond to this intent neither ACTION_TECH_DISCOVERED or ACTION_TAG_DISCOVERED will be started.</para> <para>The MIME type or data URI of this intent are normalized before dispatch - so that MIME, URI scheme and URI host are always lower-case. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NDEF_DISCOVERED
				/// </java-name>
				[Dot42.DexImport("ACTION_NDEF_DISCOVERED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_NDEF_DISCOVERED = "android.nfc.action.NDEF_DISCOVERED";
				/// <summary>
				///  <para>Intent to start an activity when a tag is discovered and activities are registered for the specific technologies on the tag.</para> <para>To receive this intent an activity must include an intent filter for this action and specify the desired tech types in a manifest  <code>meta-data</code> entry. Here is an example manfiest entry:  <pre>
				/// &lt;activity android:name=".nfc.TechFilter" android:label="NFC/TechFilter"&gt;
				///     &lt;!-- Add a technology filter --&gt;
				///     &lt;intent-filter&gt;
				///         &lt;action android:name="android.nfc.action.TECH_DISCOVERED" /&gt;
				///     &lt;/intent-filter&gt;</pre></para> <para> <pre>    &lt;meta-data android:name="android.nfc.action.TECH_DISCOVERED"
				///         android:resource="@xml/filter_nfc"
				///     /&gt;
				/// &lt;/activity&gt;</pre></para> <para>The meta-data XML file should contain one or more  <code>tech-list</code> entries each consisting or one or more  <code>tech</code> entries. The  <code>tech</code> entries refer to the qualified class name implementing the technology, for example "android.nfc.tech.NfcA".</para> <para>A tag matches if any of the  <code>tech-list</code> sets is a subset of Tag.getTechList(). Each of the  <code>tech-list</code>s is considered independently and the activity is considered a match is any single  <code>tech-list</code> matches the tag that was discovered. This provides AND and OR semantics for filtering desired techs. Here is an example that will match any tag using NfcF or any tag using NfcA, MifareClassic, and Ndef:</para> <para> <pre>
				/// &lt;resources xmlns:xliff="urn:oasis:names:tc:xliff:document:1.2"&gt;
				///     &lt;!-- capture anything using NfcF --&gt;
				///     &lt;tech-list&gt;
				///         &lt;tech&gt;android.nfc.tech.NfcF&lt;/tech&gt;
				///     &lt;/tech-list&gt;</pre></para> <para> <pre>    &lt;!-- OR --&gt;</pre></para> <para> <pre>    &lt;!-- capture all MIFARE Classics with NDEF payloads --&gt;
				///     &lt;tech-list&gt;
				///         &lt;tech&gt;android.nfc.tech.NfcA&lt;/tech&gt;
				///         &lt;tech&gt;android.nfc.tech.MifareClassic&lt;/tech&gt;
				///         &lt;tech&gt;android.nfc.tech.Ndef&lt;/tech&gt;
				///     &lt;/tech-list&gt;
				/// &lt;/resources&gt;</pre></para> <para>This intent is started after ACTION_NDEF_DISCOVERED and before ACTION_TAG_DISCOVERED. If any activities respond to ACTION_NDEF_DISCOVERED this intent will not be started. If any activities respond to this intent ACTION_TAG_DISCOVERED will not be started. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_TECH_DISCOVERED
				/// </java-name>
				[Dot42.DexImport("ACTION_TECH_DISCOVERED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TECH_DISCOVERED = "android.nfc.action.TECH_DISCOVERED";
				/// <summary>
				///  <para>Intent to start an activity when a tag is discovered.</para> <para>This intent will not be started when a tag is discovered if any activities respond to ACTION_NDEF_DISCOVERED or ACTION_TECH_DISCOVERED for the current tag. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_TAG_DISCOVERED
				/// </java-name>
				[Dot42.DexImport("ACTION_TAG_DISCOVERED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_TAG_DISCOVERED = "android.nfc.action.TAG_DISCOVERED";
				/// <summary>
				///  <para>Mandatory extra containing the Tag that was discovered for the ACTION_NDEF_DISCOVERED, ACTION_TECH_DISCOVERED, and ACTION_TAG_DISCOVERED intents. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_TAG
				/// </java-name>
				[Dot42.DexImport("EXTRA_TAG", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_TAG = "android.nfc.extra.TAG";
				/// <summary>
				///  <para>Extra containing an array of NdefMessage present on the discovered tag.</para> <para>This extra is mandatory for ACTION_NDEF_DISCOVERED intents, and optional for ACTION_TECH_DISCOVERED, and ACTION_TAG_DISCOVERED intents.</para> <para>When this extra is present there will always be at least one NdefMessage element. Most NDEF tags have only one NDEF message, but we use an array for future compatibility. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NDEF_MESSAGES
				/// </java-name>
				[Dot42.DexImport("EXTRA_NDEF_MESSAGES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NDEF_MESSAGES = "android.nfc.extra.NDEF_MESSAGES";
				/// <summary>
				///  <para>Optional extra containing a byte array containing the ID of the discovered tag for the ACTION_NDEF_DISCOVERED, ACTION_TECH_DISCOVERED, and ACTION_TAG_DISCOVERED intents. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_ID = "android.nfc.extra.ID";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NfcAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Helper to get the default NFC Adapter. </para> <para>Most Android devices will only have one NFC Adapter (NFC Controller). </para> <para>This helper is the equivalent of:  <pre>
				/// NfcManager manager = (NfcManager) context.getSystemService(Context.NFC_SERVICE);
				/// NfcAdapter adapter = manager.getDefaultAdapter();</pre> </para>        
				/// </summary>
				/// <returns>
				///  <para>the default NFC adapter, or null if no NFC adapter exists </para>
				/// </returns>
				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				[Dot42.DexImport("getDefaultAdapter", "(Landroid/content/Context;)Landroid/nfc/NfcAdapter;", AccessFlags = 9)]
				public static global::Android.Nfc.NfcAdapter GetDefaultAdapter(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.NfcAdapter);
				}

				/// <summary>
				///  <para>Set one or more Uris to send using Android Beam (TM). Every Uri you provide must have either scheme 'file' or scheme 'content'.</para> <para>For the data provided through this method, Android Beam tries to switch to alternate transports such as Bluetooth to achieve a fast transfer speed. Hence this method is very suitable for transferring large files such as pictures or songs.</para> <para>The receiving side will store the content of each Uri in a file and present a notification to the user to open the file with a android.content.Intent with action android.content.Intent#ACTION_VIEW. If multiple URIs are sent, the android.content.Intent will refer to the first of the stored files.</para> <para>This method may be called at any time before Activity#onDestroy, but the URI(s) are only made available for Android Beam when the specified activity(s) are in resumed (foreground) state. The recommended approach is to call this method during your Activity's Activity#onCreate - see sample code below. This method does not immediately perform any I/O or blocking work, so is safe to call on your main thread.</para> <para>setBeamPushUris and setBeamPushUrisCallback have priority over both setNdefPushMessage and setNdefPushMessageCallback.</para> <para>If setBeamPushUris is called with a null Uri array, and/or setBeamPushUrisCallback is called with a null callback, then the Uri push will be completely disabled for the specified activity(s).</para> <para>Code example:  <pre>
				/// protected void onCreate(Bundle savedInstanceState) {
				///     super.onCreate(savedInstanceState);
				///     NfcAdapter nfcAdapter = NfcAdapter.getDefaultAdapter(this);
				///     if (nfcAdapter == null) return;  // NFC not available on this device
				///     nfcAdapter.setBeamPushUris(new Uri[] {uri1, uri2}, this);
				/// }</pre> And that is it. Only one call per activity is necessary. The Android OS will automatically release its references to the Uri(s) and the Activity object when it is destroyed if you follow this pattern.</para> <para>If your Activity wants to dynamically supply Uri(s), then set a callback using setBeamPushUrisCallback instead of using this method.</para> <para>Do not pass in an Activity that has already been through Activity#onDestroy. This is guaranteed if you call this API during Activity#onCreate.</para> <para>If this device does not support alternate transports such as Bluetooth or WiFI, calling this method does nothing.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBeamPushUris
				/// </java-name>
				[Dot42.DexImport("setBeamPushUris", "([Landroid/net/Uri;Landroid/app/Activity;)V", AccessFlags = 1)]
				public void SetBeamPushUris(global::Android.Net.Uri[] uris, global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a callback that will dynamically generate one or more Uris to send using Android Beam (TM). Every Uri the callback provides must have either scheme 'file' or scheme 'content'.</para> <para>For the data provided through this callback, Android Beam tries to switch to alternate transports such as Bluetooth to achieve a fast transfer speed. Hence this method is very suitable for transferring large files such as pictures or songs.</para> <para>The receiving side will store the content of each Uri in a file and present a notification to the user to open the file with a android.content.Intent with action android.content.Intent#ACTION_VIEW. If multiple URIs are sent, the android.content.Intent will refer to the first of the stored files.</para> <para>This method may be called at any time before Activity#onDestroy, but the URI(s) are only made available for Android Beam when the specified activity(s) are in resumed (foreground) state. The recommended approach is to call this method during your Activity's Activity#onCreate - see sample code below. This method does not immediately perform any I/O or blocking work, so is safe to call on your main thread.</para> <para>setBeamPushUris and setBeamPushUrisCallback have priority over both setNdefPushMessage and setNdefPushMessageCallback.</para> <para>If setBeamPushUris is called with a null Uri array, and/or setBeamPushUrisCallback is called with a null callback, then the Uri push will be completely disabled for the specified activity(s).</para> <para>Code example:  <pre>
				/// protected void onCreate(Bundle savedInstanceState) {
				///     super.onCreate(savedInstanceState);
				///     NfcAdapter nfcAdapter = NfcAdapter.getDefaultAdapter(this);
				///     if (nfcAdapter == null) return;  // NFC not available on this device
				///     nfcAdapter.setBeamPushUrisCallback(callback, this);
				/// }</pre> And that is it. Only one call per activity is necessary. The Android OS will automatically release its references to the Uri(s) and the Activity object when it is destroyed if you follow this pattern.</para> <para>Do not pass in an Activity that has already been through Activity#onDestroy. This is guaranteed if you call this API during Activity#onCreate.</para> <para>If this device does not support alternate transports such as Bluetooth or WiFI, calling this method does nothing.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBeamPushUrisCallback
				/// </java-name>
				[Dot42.DexImport("setBeamPushUrisCallback", "(Landroid/nfc/NfcAdapter$CreateBeamUrisCallback;Landroid/app/Activity;)V", AccessFlags = 1)]
				public void SetBeamPushUrisCallback(global::Android.Nfc.NfcAdapter.ICreateBeamUrisCallback callback, global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNdefPushMessage
				/// </java-name>
				[Dot42.DexImport("setNdefPushMessage", "(Landroid/nfc/NdefMessage;Landroid/app/Activity;[Landroid/app/Activity;)V", AccessFlags = 129)]
				public void SetNdefPushMessage(global::Android.Nfc.NdefMessage message, global::Android.App.Activity activity, params global::Android.App.Activity[] flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNdefPushMessageCallback
				/// </java-name>
				[Dot42.DexImport("setNdefPushMessageCallback", "(Landroid/nfc/NfcAdapter$CreateNdefMessageCallback;Landroid/app/Activity;[Landroi" +
    "d/app/Activity;)V", AccessFlags = 129)]
				public void SetNdefPushMessageCallback(global::Android.Nfc.NfcAdapter.ICreateNdefMessageCallback callback, global::Android.App.Activity activity, params global::Android.App.Activity[] flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set a callback on successful Android Beam (TM).</para> <para>This method may be called at any time before Activity#onDestroy, but the callback can only occur when the specified activity(s) are in resumed (foreground) state. The recommended approach is to call this method during your Activity's Activity#onCreate - see sample code below. This method does not immediately perform any I/O or blocking work, so is safe to call on your main thread.</para> <para>The API allows for multiple activities to be specified at a time, but it is strongly recommended to just register one at a time, and to do so during the activity's Activity#onCreate. For example:  <pre>
				/// protected void onCreate(Bundle savedInstanceState) {
				///     super.onCreate(savedInstanceState);
				///     NfcAdapter nfcAdapter = NfcAdapter.getDefaultAdapter(this);
				///     if (nfcAdapter == null) return;  // NFC not available on this device
				///     nfcAdapter.setOnNdefPushCompleteCallback(callback, this);
				/// }</pre> And that is it. Only one call per activity is necessary. The Android OS will automatically release its references to the callback and the Activity object when it is destroyed if you follow this pattern.</para> <para>Do not pass in an Activity that has already been through Activity#onDestroy. This is guaranteed if you call this API during Activity#onCreate.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnNdefPushCompleteCallback
				/// </java-name>
				[Dot42.DexImport("setOnNdefPushCompleteCallback", "(Landroid/nfc/NfcAdapter$OnNdefPushCompleteCallback;Landroid/app/Activity;[Landro" +
    "id/app/Activity;)V", AccessFlags = 129)]
				public void SetOnNdefPushCompleteCallback(global::Android.Nfc.NfcAdapter.IOnNdefPushCompleteCallback callback, global::Android.App.Activity activity, params global::Android.App.Activity[] activities) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enable foreground dispatch to the given Activity.</para> <para>This will give give priority to the foreground activity when dispatching a discovered Tag to an application.</para> <para>If any IntentFilters are provided to this method they are used to match dispatch Intents for both the NfcAdapter#ACTION_NDEF_DISCOVERED and NfcAdapter#ACTION_TAG_DISCOVERED. Since NfcAdapter#ACTION_TECH_DISCOVERED relies on meta data outside of the IntentFilter matching for that dispatch Intent is handled by passing in the tech lists separately. Each first level entry in the tech list represents an array of technologies that must all be present to match. If any of the first level sets match then the dispatch is routed through the given PendingIntent. In other words, the second level is ANDed together and the first level entries are ORed together.</para> <para>If you pass <c>null </c> for both the <c>filters </c> and <c>techLists </c> parameters that acts a wild card and will cause the foreground activity to receive all tags via the NfcAdapter#ACTION_TAG_DISCOVERED intent.</para> <para>This method must be called from the main thread, and only when the activity is in the foreground (resumed). Also, activities must call disableForegroundDispatch before the completion of their Activity#onPause callback to disable foreground dispatch after it has been enabled.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// enableForegroundDispatch
				/// </java-name>
				[Dot42.DexImport("enableForegroundDispatch", "(Landroid/app/Activity;Landroid/app/PendingIntent;[Landroid/content/IntentFilter;" +
    "[[Ljava/lang/String;)V", AccessFlags = 1)]
				public void EnableForegroundDispatch(global::Android.App.Activity activity, global::Android.App.PendingIntent intent, global::Android.Content.IntentFilter[] filters, string[][] techLists) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Disable foreground dispatch to the given activity.</para> <para>After calling enableForegroundDispatch, an activity must call this method before its Activity#onPause callback completes.</para> <para>This method must be called from the main thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// disableForegroundDispatch
				/// </java-name>
				[Dot42.DexImport("disableForegroundDispatch", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public void DisableForegroundDispatch(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enable NDEF message push over NFC while this Activity is in the foreground.</para> <para>You must explicitly call this method every time the activity is resumed, and you must call disableForegroundNdefPush before your activity completes Activity#onPause.</para> <para>Strongly recommend to use the new setNdefPushMessage instead: it automatically hooks into your activity life-cycle, so you do not need to call enable/disable in your onResume/onPause.</para> <para>For NDEF push to function properly the other NFC device must support either NFC Forum's SNEP (Simple Ndef Exchange Protocol), or Android's "com.android.npp" (Ndef Push Protocol). This was optional on Gingerbread level Android NFC devices, but SNEP is mandatory on Ice-Cream-Sandwich and beyond.</para> <para>This method must be called from the main thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use setNdefPushMessage instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// enableForegroundNdefPush
				/// </java-name>
				[Dot42.DexImport("enableForegroundNdefPush", "(Landroid/app/Activity;Landroid/nfc/NdefMessage;)V", AccessFlags = 1)]
				public void EnableForegroundNdefPush(global::Android.App.Activity activity, global::Android.Nfc.NdefMessage message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Disable NDEF message push over P2P.</para> <para>After calling enableForegroundNdefPush, an activity must call this method before its Activity#onPause callback completes.</para> <para>Strongly recommend to use the new setNdefPushMessage instead: it automatically hooks into your activity life-cycle, so you do not need to call enable/disable in your onResume/onPause.</para> <para>This method must be called from the main thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use setNdefPushMessage instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// disableForegroundNdefPush
				/// </java-name>
				[Dot42.DexImport("disableForegroundNdefPush", "(Landroid/app/Activity;)V", AccessFlags = 1)]
				public void DisableForegroundNdefPush(global::Android.App.Activity activity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return true if this NFC Adapter has any features enabled.</para> <para>If this method returns false, the NFC hardware is guaranteed not to generate or respond to any NFC communication over its NFC radio. </para> <para>Applications can use this to check if NFC is enabled. Applications can request Settings UI allowing the user to toggle NFC using: </para> <para> <pre>startActivity(new Intent(Settings.ACTION_NFC_SETTINGS))</pre></para> <para> <para>android.provider.Settings::ACTION_NFC_SETTINGS </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this NFC Adapter has any features enabled </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				public bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Return true if the NDEF Push (Android Beam) feature is enabled. </para> <para>This function will return true only if both NFC is enabled, and the NDEF Push feature is enabled. </para> <para>Note that if NFC is enabled but NDEF Push is disabled then this device can still  <b>receive</b> NDEF messages, it just cannot send them. </para> <para>Applications cannot directly toggle the NDEF Push feature, but they can request Settings UI allowing the user to toggle NDEF Push using  <code>startActivity(new Intent(Settings.ACTION_NFCSHARING_SETTINGS))</code> </para> <para>Example usage in an Activity that requires NDEF Push: </para> <para> <pre>
				/// protected void onResume() {
				///     super.onResume();
				///     if (!nfcAdapter.isEnabled()) {
				///         startActivity(new Intent(Settings.ACTION_NFC_SETTINGS));
				///     } else if (!nfcAdapter.isNdefPushEnabled()) {
				///         startActivity(new Intent(Settings.ACTION_NFCSHARING_SETTINGS));
				///     }
				/// }</pre></para> <para> <para>android.provider.Settings::ACTION_NFCSHARING_SETTINGS </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if NDEF Push feature is enabled </para>
				/// </returns>
				/// <java-name>
				/// isNdefPushEnabled
				/// </java-name>
				public bool IsNdefPushEnabled
				{
						[Dot42.DexImport("isNdefPushEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/nfc/NfcAdapter$CreateBeamUrisCallback
				/// </java-name>
				[Dot42.DexImport("android/nfc/NfcAdapter$CreateBeamUrisCallback", AccessFlags = 1545)]
				public partial interface ICreateBeamUrisCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// createBeamUris
						/// </java-name>
						[Dot42.DexImport("createBeamUris", "(Landroid/nfc/NfcEvent;)[Landroid/net/Uri;", AccessFlags = 1025)]
						global::Android.Net.Uri[] CreateBeamUris(global::Android.Nfc.NfcEvent @event) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>A callback to be invoked when another NFC device capable of NDEF push (Android Beam) is within range. </para> <para>Implement this interface and pass it to setNdefPushMessageCallback() in order to create an NdefMessage at the moment that another device is within range for NFC. Using this callback allows you to create a message with data that might vary based on the content currently visible to the user. Alternatively, you can call setNdefPushMessage() if the NdefMessage always contains the same data. </para>    
				/// </summary>
				/// <java-name>
				/// android/nfc/NfcAdapter$CreateNdefMessageCallback
				/// </java-name>
				[Dot42.DexImport("android/nfc/NfcAdapter$CreateNdefMessageCallback", AccessFlags = 1545)]
				public partial interface ICreateNdefMessageCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to provide a NdefMessage to push.</para> <para>This callback is usually made on a binder thread (not the UI thread).</para> <para>Called when this device is in range of another device that might support NDEF push. It allows the application to create the NDEF message only when it is required.</para> <para>NDEF push cannot occur until this method returns, so do not block for too long.</para> <para>The Android operating system will usually show a system UI on top of your activity during this time, so do not try to request input from the user to complete the callback, or provide custom NDEF push UI. The user probably will not see it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>NDEF message to push, or null to not provide a message </para>
						/// </returns>
						/// <java-name>
						/// createNdefMessage
						/// </java-name>
						[Dot42.DexImport("createNdefMessage", "(Landroid/nfc/NfcEvent;)Landroid/nfc/NdefMessage;", AccessFlags = 1025)]
						global::Android.Nfc.NdefMessage CreateNdefMessage(global::Android.Nfc.NfcEvent @event) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>A callback to be invoked when the system successfully delivers your NdefMessage to another device.  <para>setOnNdefPushCompleteCallback </para></para>    
				/// </summary>
				/// <java-name>
				/// android/nfc/NfcAdapter$OnNdefPushCompleteCallback
				/// </java-name>
				[Dot42.DexImport("android/nfc/NfcAdapter$OnNdefPushCompleteCallback", AccessFlags = 1545)]
				public partial interface IOnNdefPushCompleteCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called on successful NDEF push.</para> <para>This callback is usually made on a binder thread (not the UI thread).</para> <para> <para>setNdefPushMessageCallback </para></para>        
						/// </summary>
						/// <java-name>
						/// onNdefPushComplete
						/// </java-name>
						[Dot42.DexImport("onNdefPushComplete", "(Landroid/nfc/NfcEvent;)V", AccessFlags = 1025)]
						void OnNdefPushComplete(global::Android.Nfc.NfcEvent @event) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Wraps information associated with any NFC event.</para> <para>Immutable object, with direct access to the (final) fields.</para> <para>An NfcEvent object is usually included in callbacks from NfcAdapter. Check the documentation of the callback to see which fields may be set.</para> <para>This wrapper object is used (instead of parameters in the callback) because it allows new fields to be added without breaking API compatibility.</para> <para> <para>NfcAdapter.OnNdefPushCompleteCallback::onNdefPushComplete </para> <para>NfcAdapter.CreateNdefMessageCallback::createNdefMessage </para></para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/NfcEvent
		/// </java-name>
		[Dot42.DexImport("android/nfc/NfcEvent", AccessFlags = 49)]
		public sealed partial class NfcEvent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The NfcAdapter associated with the NFC event. </para>        
				/// </summary>
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

		/// <summary>
		///  <para>High level manager used to obtain an instance of an NfcAdapter. </para> <para>Use android.content.Context#getSystemService(java.lang.String) with Context#NFC_SERVICE to create an NfcManager, then call getDefaultAdapter to obtain the NfcAdapter. </para> <para>Alternately, you can just call the static helper NfcAdapter#getDefaultAdapter(android.content.Context).</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about using NFC, read the  developer guide.</para> <para> </para> <para> <para>Context::getSystemService </para> <para>NfcAdapter::getDefaultAdapter(android.content.Context) </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Get the default NFC Adapter for this device.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default NFC Adapter </para>
				/// </returns>
				/// <java-name>
				/// getDefaultAdapter
				/// </java-name>
				public global::Android.Nfc.NfcAdapter DefaultAdapter
				{
						[Dot42.DexImport("getDefaultAdapter", "()Landroid/nfc/NfcAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.NfcAdapter); }
				}

		}

		/// <summary>
		///  <para>Represents an NFC tag that has been discovered. </para> <para>Tag is an immutable object that represents the state of a NFC tag at the time of discovery. It can be used as a handle to TagTechnology classes to perform advanced operations, or directly queried for its ID via getId and the set of technologies it contains via getTechList. Arrays passed to and returned by this class are  <b>not</b> cloned, so be careful not to modify them. </para> <para>A new tag object is created every time a tag is discovered (comes into range), even if it is the same physical tag. If a tag is removed and then returned into range, then only the most recent tag object can be successfully used to create a TagTechnology.</para> <para> <h3>Tag Dispatch</h3></para> <para>When a tag is discovered, a Tag object is created and passed to a single activity via the NfcAdapter#EXTRA_TAG extra in an android.content.Intent via Context#startActivity. A four stage dispatch is used to select the most appropriate activity to handle the tag. The Android OS executes each stage in order, and completes dispatch as soon as a single matching activity is found. If there are multiple matching activities found at any one stage then the Android activity chooser dialog is shown to allow the user to select the activity to receive the tag.</para> <para>The Tag dispatch mechanism was designed to give a high probability of dispatching a tag to the correct activity without showing the user an activity chooser dialog. This is important for NFC interactions because they are very transient  if a user has to move the Android device to choose an application then the connection will likely be broken.</para> <para> <h4>1. Foreground activity dispatch</h4></para> <para>A foreground activity that has called NfcAdapter.enableForegroundDispatch() is given priority. See the documentation on NfcAdapter.enableForegroundDispatch() for its usage.  <h4>2. NDEF data dispatch</h4></para> <para>If the tag contains NDEF data the system inspects the first NdefRecord in the first NdefMessage. If the record is a URI, SmartPoster, or MIME data Context#startActivity is called with NfcAdapter#ACTION_NDEF_DISCOVERED. For URI and SmartPoster records the URI is put into the intent's data field. For MIME records the MIME type is put in the intent's type field. This allows activities to register to be launched only when data they know how to handle is present on a tag. This is the preferred method of handling data on a tag since NDEF data can be stored on many types of tags and doesn't depend on a specific tag technology. See NfcAdapter#ACTION_NDEF_DISCOVERED for more detail. If the tag does not contain NDEF data, or if no activity is registered for NfcAdapter#ACTION_NDEF_DISCOVERED with a matching data URI or MIME type then dispatch moves to stage 3.  <h4>3. Tag Technology dispatch</h4></para> <para>Context#startActivity is called with NfcAdapter#ACTION_TECH_DISCOVERED to dispatch the tag to an activity that can handle the technologies present on the tag. Technologies are defined as sub-classes of TagTechnology, see the package android.nfc.tech. The Android OS looks for an activity that can handle one or more technologies in the tag. See NfcAdapter#ACTION_TECH_DISCOVERED for more detail.  <h4>4. Fall-back dispatch</h4></para> <para>If no activity has been matched then Context#startActivity is called with NfcAdapter#ACTION_TAG_DISCOVERED. This is intended as a fall-back mechanism. See NfcAdapter#ACTION_TAG_DISCOVERED.</para> <para> <h3>NFC Tag Background</h3></para> <para>An NFC tag is a passive NFC device, powered by the NFC field of this Android device while it is in range. Tag's can come in many forms, such as stickers, cards, key fobs, or even embedded in a more sophisticated device. </para> <para>Tags can have a wide range of capabilities. Simple tags just offer read/write semantics, and contain some one time programmable areas to make read-only. More complex tags offer math operations and per-sector access control and authentication. The most sophisticated tags contain operating environments allowing complex interactions with the code executing on the tag. Use TagTechnology classes to access a broad range of capabilities available in NFC tags. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Get the Tag Identifier (if it has one). </para> <para>The tag identifier is a low level serial number, used for anti-collision and identification. </para> <para>Most tags have a stable unique identifier (UID), but some tags will generate a random ID every time they are discovered (RID), and there are some tags with no ID at all (the byte array will be zero-sized). </para> <para>The size and format of an ID is specific to the RF technology used by the tag. </para> <para>This function retrieves the ID as determined at discovery time, and does not perform any further RF communication or block. </para>        
				/// </summary>
				/// <returns>
				///  <para>ID as byte array, never null </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetId() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Human-readable description of the tag, for debugging. </para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the Tag Identifier (if it has one). </para> <para>The tag identifier is a low level serial number, used for anti-collision and identification. </para> <para>Most tags have a stable unique identifier (UID), but some tags will generate a random ID every time they are discovered (RID), and there are some tags with no ID at all (the byte array will be zero-sized). </para> <para>The size and format of an ID is specific to the RF technology used by the tag. </para> <para>This function retrieves the ID as determined at discovery time, and does not perform any further RF communication or block. </para>        
				/// </summary>
				/// <returns>
				///  <para>ID as byte array, never null </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public byte[] Id
				{
						[Dot42.DexImport("getId", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Get the technologies available in this tag, as fully qualified class names. </para> <para>A technology is an implementation of the TagTechnology interface, and can be instantiated by calling the static  <code>get(Tag)</code> method on the implementation with this Tag. The TagTechnology object can then be used to perform advanced, technology-specific operations on a tag. </para> <para>Android defines a mandatory set of technologies that must be correctly enumerated by all Android NFC devices, and an optional set of proprietary technologies. See TagTechnology for more details. </para> <para>The ordering of the returned array is undefined and should not be relied upon. </para>        
				/// </summary>
				/// <returns>
				///  <para>an array of fully-qualified TagTechnology class-names. </para>
				/// </returns>
				/// <java-name>
				/// getTechList
				/// </java-name>
				public string[] TechList
				{
						[Dot42.DexImport("getTechList", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
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
				public TagLostException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

}

