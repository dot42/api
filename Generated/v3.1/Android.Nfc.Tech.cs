#pragma warning disable 1717
namespace Android.Nfc.Tech
{
		/// <summary>
		///  <para>A base class for tag technologies that are built on top of transceive(). </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/BasicTagTechnology
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/BasicTagTechnology", AccessFlags = 1056)]
		internal abstract partial class BasicTagTechnology : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BasicTagTechnology() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1)]
				public virtual void Connect() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public virtual global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				public virtual bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Provides access to ISO-DEP (ISO 14443-4) properties and I/O operations on a Tag.</para> <para>Acquire an IsoDep object using get. </para> <para>The primary ISO-DEP I/O operation is transceive. Applications must implement their own protocol stack on top of transceive. </para> <para>Tags that enumerate the IsoDep technology in Tag#getTechList will also enumerate NfcA or NfcB (since IsoDep builds on top of either of these).</para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/IsoDep
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/IsoDep", AccessFlags = 49)]
		public sealed partial class IsoDep : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal IsoDep() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of IsoDep for the given tag. </para> <para>Does not cause any RF activity and does not block. </para> <para>Returns null if IsoDep was not enumerated in Tag#getTechList. This indicates the tag does not support ISO-DEP.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ISO-DEP object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/IsoDep;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.IsoDep Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.IsoDep);
				}

				/// <summary>
				///  <para>Set the timeout of transceive in milliseconds. </para> <para>The timeout only applies to ISO-DEP transceive, and is reset to a default value when close is called. </para> <para>Setting a longer timeout may be useful when performing transactions that require a long processing time on the tag such as key generation.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTimeout
				/// </java-name>
				[Dot42.DexImport("setTimeout", "(I)V", AccessFlags = 1)]
				public void SetTimeout(int timeout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the ISO-DEP historical bytes for NfcA tags. </para> <para>Does not cause any RF activity and does not block. </para> <para>The historical bytes can be used to help identify a tag. They are present only on IsoDep tags that are based on NfcA RF technology. If this tag is not NfcA then null is returned. </para> <para>In ISO 14443-4 terminology, the historical bytes are a subset of the RATS response.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ISO-DEP historical bytes, or null if this is not a NfcA tag </para>
				/// </returns>
				/// <java-name>
				/// getHistoricalBytes
				/// </java-name>
				[Dot42.DexImport("getHistoricalBytes", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetHistoricalBytes() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Return the higher layer response bytes for NfcB tags. </para> <para>Does not cause any RF activity and does not block. </para> <para>The higher layer response bytes can be used to help identify a tag. They are present only on IsoDep tags that are based on NfcB RF technology. If this tag is not NfcB then null is returned. </para> <para>In ISO 14443-4 terminology, the higher layer bytes are a subset of the ATTRIB response.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ISO-DEP historical bytes, or null if this is not a NfcB tag </para>
				/// </returns>
				/// <java-name>
				/// getHiLayerResponse
				/// </java-name>
				[Dot42.DexImport("getHiLayerResponse", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetHiLayerResponse() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw ISO-DEP data to the tag and receive the response.</para> <para>Applications must only send the INF payload, and not the start of frame and end of frame indicators. Applications do not need to fragment the payload, it will be automatically fragmented and defragmented by transceive if it exceeds FSD/FSC limits.</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>response bytes received, will not be null </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] Transceive(sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw ISO-DEP data to the tag and receive the response.</para> <para>Applications must only send the INF payload, and not the start of frame and end of frame indicators. Applications do not need to fragment the payload, it will be automatically fragmented and defragmented by transceive if it exceeds FSD/FSC limits.</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>response bytes received, will not be null </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public byte[] Transceive(byte[] data) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1)]
				public void Connect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the ISO-DEP historical bytes for NfcA tags. </para> <para>Does not cause any RF activity and does not block. </para> <para>The historical bytes can be used to help identify a tag. They are present only on IsoDep tags that are based on NfcA RF technology. If this tag is not NfcA then null is returned. </para> <para>In ISO 14443-4 terminology, the historical bytes are a subset of the RATS response.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ISO-DEP historical bytes, or null if this is not a NfcA tag </para>
				/// </returns>
				/// <java-name>
				/// getHistoricalBytes
				/// </java-name>
				public byte[] HistoricalBytes
				{
						[Dot42.DexImport("getHistoricalBytes", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Return the higher layer response bytes for NfcB tags. </para> <para>Does not cause any RF activity and does not block. </para> <para>The higher layer response bytes can be used to help identify a tag. They are present only on IsoDep tags that are based on NfcB RF technology. If this tag is not NfcB then null is returned. </para> <para>In ISO 14443-4 terminology, the higher layer bytes are a subset of the ATTRIB response.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ISO-DEP historical bytes, or null if this is not a NfcB tag </para>
				/// </returns>
				/// <java-name>
				/// getHiLayerResponse
				/// </java-name>
				public byte[] HiLayerResponse
				{
						[Dot42.DexImport("getHiLayerResponse", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

		/// <summary>
		///  <para>TagTechnology is an interface to a technology in a Tag. </para> <para>Obtain a TagTechnology implementation by calling the static method  <code>get()</code> on the implementation class. </para> <para>NFC tags are based on a number of independently developed technologies and offer a wide range of capabilities. The TagTechnology implementations provide access to these different technologies and capabilities. Some sub-classes map to technology specification (for example NfcA, IsoDep, others map to pseudo-technologies or capabilities (for example Ndef, NdefFormatable). </para> <para>It is mandatory for all Android NFC devices to provide the following TagTechnology implementations.  <ul> <li> <para>NfcA (also known as ISO 14443-3A) </para></li> <li> <para>NfcB (also known as ISO 14443-3B) </para></li> <li> <para>NfcF (also known as JIS 6319-4) </para></li> <li> <para>NfcV (also known as ISO 15693) </para></li> <li> <para>IsoDep </para></li> <li> <para>Ndef on NFC Forum Type 1, Type 2, Type 3 or Type 4 compliant tags </para></li></ul>It is optional for Android NFC devices to provide the following TagTechnology implementations. If it is not provided, the Android device will never enumerate that class via Tag#getTechList.  <ul> <li> <para>MifareClassic </para></li> <li> <para>MifareUltralight </para></li> <li> <para>NfcBarcode </para></li> <li> <para>NdefFormatable must only be enumerated on tags for which this Android device is capable of formatting. Proprietary knowledge is often required to format a tag to make it NDEF compatible. </para></li></ul></para> <para>TagTechnology implementations provide methods that fall into two classes:  <b>cached getters</b> and  <b>I/O operations</b>.  <h4>Cached getters</h4></para> <para>These methods (usually prefixed by  <code>get</code> or  <code>is</code>) return properties of the tag, as determined at discovery time. These methods will never block or cause RF activity, and do not require connect to have been called. They also never update, for example if a property is changed by an I/O operation with a tag then the cached getter will still return the result from tag discovery time.  <h4>I/O operations</h4></para> <para>I/O operations may require RF activity, and may block. They have the following semantics.  <ul> <li> <para>connect must be called before using any other I/O operation. </para></li> <li> <para>close must be called after completing I/O operations with a TagTechnology, and it will cancel all other blocked I/O operations on other threads (including connect with IOException. </para></li> <li> <para>Only one TagTechnology can be connected at a time. Other calls to connect will return IOException. </para></li> <li> <para>I/O operations may block, and should never be called on the main application thread. </para></li></ul></para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/TagTechnology
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/TagTechnology", AccessFlags = 1537)]
		public partial interface ITagTechnology : global::Java.IO.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Enable I/O operations to the tag from this TagTechnology object. </para> <para>May cause RF activity and may block. Must not be called from the main application thread. A blocked call will be canceled with IOException by calling close from another thread. </para> <para>Only one TagTechnology object can be connected to a Tag at a time. </para> <para>Applications must call close when I/O operations are complete.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para> <para>close() </para></para>        
				/// </summary>
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1025)]
				void Connect() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Disable I/O operations to the tag from this TagTechnology object, and release resources. </para> <para>Also causes all blocked I/O operations on other thread to be canceled and return with IOException.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para> <para>connect() </para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the Tag object backing this TagTechnology object. </para>        
				/// </summary>
				/// <returns>
				///  <para>the Tag backing this TagTechnology object. </para>
				/// </returns>
				/// <java-name>
				/// getTag
				/// </java-name>
				global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Helper to indicate if I/O operations should be possible.</para> <para>Returns true if connect has completed, and close has not been called, and the Tag is not known to be out of range. </para> <para>Does not cause RF activity, and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if I/O operations should be possible </para>
				/// </returns>
				/// <java-name>
				/// isConnected
				/// </java-name>
				bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Provides access to MIFARE Classic properties and I/O operations on a Tag.</para> <para>Acquire a MifareClassic object using get.</para> <para>MIFARE Classic is also known as MIFARE Standard. </para> <para>MIFARE Classic tags are divided into sectors, and each sector is sub-divided into blocks. Block size is always 16 bytes (BLOCK_SIZE. Sector size varies.  <ul> <li> <para>MIFARE Classic Mini are 320 bytes (SIZE_MINI), with 5 sectors each of 4 blocks. </para></li> <li> <para>MIFARE Classic 1k are 1024 bytes (SIZE_1K), with 16 sectors each of 4 blocks. </para></li> <li> <para>MIFARE Classic 2k are 2048 bytes (SIZE_2K), with 32 sectors each of 4 blocks. </para></li> <li> <para>MIFARE Classic 4k} are 4096 bytes (SIZE_4K). The first 32 sectors contain 4 blocks and the last 8 sectors contain 16 blocks. </para></li></ul></para> <para>MIFARE Classic tags require authentication on a per-sector basis before any other I/O operations on that sector can be performed. There are two keys per sector, and ACL bits determine what I/O operations are allowed on that sector after authenticating with a key. { <para>authenticateSectorWithKeyA} and {</para> <para>authenticateSectorWithKeyB}.</para></para> <para>Three well-known authentication keys are defined in this class: KEY_DEFAULT, KEY_MIFARE_APPLICATION_DIRECTORY, KEY_NFC_FORUM.  <ul> <li> <para>KEY_DEFAULT is the default factory key for MIFARE Classic. </para></li> <li> <para>KEY_MIFARE_APPLICATION_DIRECTORY is the well-known key for MIFARE Classic cards that have been formatted according to the MIFARE Application Directory (MAD) specification. </para></li> <li> <para>KEY_NFC_FORUM is the well-known key for MIFARE Classic cards that have been formatted according to the NXP specification for NDEF on MIFARE Classic.</para> <para></para> <para>Implementation of this class on a Android NFC device is optional. If it is not implemented, then MifareClassic will never be enumerated in Tag#getTechList. If it is enumerated, then all MifareClassic I/O operations will be supported, and Ndef#MIFARE_CLASSIC NDEF tags will also be supported. In either case, NfcA will also be enumerated on the tag, because all MIFARE Classic tags are also NfcA.</para> <para></para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/MifareClassic
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/MifareClassic", AccessFlags = 49)]
		public sealed partial class MifareClassic : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The default factory key. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("KEY_DEFAULT", "[B", AccessFlags = 25)]
				public static readonly sbyte[] KEY_DEFAULT;
				/// <summary>
				///  <para>The well-known key for tags formatted according to the MIFARE Application Directory (MAD) specification. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_MIFARE_APPLICATION_DIRECTORY
				/// </java-name>
				[Dot42.DexImport("KEY_MIFARE_APPLICATION_DIRECTORY", "[B", AccessFlags = 25)]
				public static readonly sbyte[] KEY_MIFARE_APPLICATION_DIRECTORY;
				/// <summary>
				///  <para>The well-known key for tags formatted according to the NDEF on MIFARE Classic specification. </para>        
				/// </summary>
				/// <java-name>
				/// KEY_NFC_FORUM
				/// </java-name>
				[Dot42.DexImport("KEY_NFC_FORUM", "[B", AccessFlags = 25)]
				public static readonly sbyte[] KEY_NFC_FORUM;
				/// <summary>
				///  <para>A MIFARE Classic compatible card of unknown type </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int TYPE_UNKNOWN = -1;
				/// <summary>
				///  <para>A MIFARE Classic tag </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_CLASSIC
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASSIC", "I", AccessFlags = 25)]
				public const int TYPE_CLASSIC = 0;
				/// <summary>
				///  <para>A MIFARE Plus tag </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PLUS
				/// </java-name>
				[Dot42.DexImport("TYPE_PLUS", "I", AccessFlags = 25)]
				public const int TYPE_PLUS = 1;
				/// <summary>
				///  <para>A MIFARE Pro tag </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PRO
				/// </java-name>
				[Dot42.DexImport("TYPE_PRO", "I", AccessFlags = 25)]
				public const int TYPE_PRO = 2;
				/// <summary>
				///  <para>Tag contains 16 sectors, each with 4 blocks. </para>        
				/// </summary>
				/// <java-name>
				/// SIZE_1K
				/// </java-name>
				[Dot42.DexImport("SIZE_1K", "I", AccessFlags = 25)]
				public const int SIZE_1K = 1024;
				/// <summary>
				///  <para>Tag contains 32 sectors, each with 4 blocks. </para>        
				/// </summary>
				/// <java-name>
				/// SIZE_2K
				/// </java-name>
				[Dot42.DexImport("SIZE_2K", "I", AccessFlags = 25)]
				public const int SIZE_2K = 2048;
				/// <summary>
				///  <para>Tag contains 40 sectors. The first 32 sectors contain 4 blocks and the last 8 sectors contain 16 blocks. </para>        
				/// </summary>
				/// <java-name>
				/// SIZE_4K
				/// </java-name>
				[Dot42.DexImport("SIZE_4K", "I", AccessFlags = 25)]
				public const int SIZE_4K = 4096;
				/// <summary>
				///  <para>Tag contains 5 sectors, each with 4 blocks. </para>        
				/// </summary>
				/// <java-name>
				/// SIZE_MINI
				/// </java-name>
				[Dot42.DexImport("SIZE_MINI", "I", AccessFlags = 25)]
				public const int SIZE_MINI = 320;
				/// <summary>
				///  <para>Size of a MIFARE Classic block (in bytes) </para>        
				/// </summary>
				/// <java-name>
				/// BLOCK_SIZE
				/// </java-name>
				[Dot42.DexImport("BLOCK_SIZE", "I", AccessFlags = 25)]
				public const int BLOCK_SIZE = 16;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MifareClassic() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of MifareClassic for the given tag. </para> <para>Does not cause any RF activity and does not block. </para> <para>Returns null if MifareClassic was not enumerated in Tag#getTechList. This indicates the tag is not MIFARE Classic compatible, or this Android device does not support MIFARE Classic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>MIFARE Classic object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/MifareClassic;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.MifareClassic Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.MifareClassic);
				}

				/// <summary>
				///  <para>Return the number of blocks in the given sector. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>number of blocks in the sector </para>
				/// </returns>
				/// <java-name>
				/// getBlockCountInSector
				/// </java-name>
				[Dot42.DexImport("getBlockCountInSector", "(I)I", AccessFlags = 1)]
				public int GetBlockCountInSector(int sectorIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the sector that contains a given block. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>sector index that contains the block </para>
				/// </returns>
				/// <java-name>
				/// blockToSector
				/// </java-name>
				[Dot42.DexImport("blockToSector", "(I)I", AccessFlags = 1)]
				public int BlockToSector(int blockIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the first block of a given sector. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>block index of first block in sector </para>
				/// </returns>
				/// <java-name>
				/// sectorToBlock
				/// </java-name>
				[Dot42.DexImport("sectorToBlock", "(I)I", AccessFlags = 1)]
				public int SectorToBlock(int sectorIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Authenticate a sector with key A.</para> <para>Successful authentication of a sector with key A enables other I/O operations on that sector. The set of operations granted by key A key depends on the ACL bits set in that sector. For more information see the MIFARE Classic specification on { <para>}.</para></para> <para>A failed authentication attempt causes an implicit reconnection to the tag, so authentication to other sectors will be lost.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true on success, false on authentication failure </para>
				/// </returns>
				/// <java-name>
				/// authenticateSectorWithKeyA
				/// </java-name>
				[Dot42.DexImport("authenticateSectorWithKeyA", "(I[B)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public bool AuthenticateSectorWithKeyA(int sectorIndex, sbyte[] key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Authenticate a sector with key A.</para> <para>Successful authentication of a sector with key A enables other I/O operations on that sector. The set of operations granted by key A key depends on the ACL bits set in that sector. For more information see the MIFARE Classic specification on { <para>}.</para></para> <para>A failed authentication attempt causes an implicit reconnection to the tag, so authentication to other sectors will be lost.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true on success, false on authentication failure </para>
				/// </returns>
				/// <java-name>
				/// authenticateSectorWithKeyA
				/// </java-name>
				[Dot42.DexImport("authenticateSectorWithKeyA", "(I[B)Z", AccessFlags = 1)]
				public bool AuthenticateSectorWithKeyA(int sectorIndex, byte[] key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Authenticate a sector with key B.</para> <para>Successful authentication of a sector with key B enables other I/O operations on that sector. The set of operations granted by key B depends on the ACL bits set in that sector. For more information see the MIFARE Classic specification on { <para>}.</para></para> <para>A failed authentication attempt causes an implicit reconnection to the tag, so authentication to other sectors will be lost.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true on success, false on authentication failure </para>
				/// </returns>
				/// <java-name>
				/// authenticateSectorWithKeyB
				/// </java-name>
				[Dot42.DexImport("authenticateSectorWithKeyB", "(I[B)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public bool AuthenticateSectorWithKeyB(int sectorIndex, sbyte[] key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Authenticate a sector with key B.</para> <para>Successful authentication of a sector with key B enables other I/O operations on that sector. The set of operations granted by key B depends on the ACL bits set in that sector. For more information see the MIFARE Classic specification on { <para>}.</para></para> <para>A failed authentication attempt causes an implicit reconnection to the tag, so authentication to other sectors will be lost.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true on success, false on authentication failure </para>
				/// </returns>
				/// <java-name>
				/// authenticateSectorWithKeyB
				/// </java-name>
				[Dot42.DexImport("authenticateSectorWithKeyB", "(I[B)Z", AccessFlags = 1)]
				public bool AuthenticateSectorWithKeyB(int sectorIndex, byte[] key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Read 16-byte block.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>16 byte block </para>
				/// </returns>
				/// <java-name>
				/// readBlock
				/// </java-name>
				[Dot42.DexImport("readBlock", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaReadBlock(int blockIndex) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Read 16-byte block.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>16 byte block </para>
				/// </returns>
				/// <java-name>
				/// readBlock
				/// </java-name>
				[Dot42.DexImport("readBlock", "(I)[B", AccessFlags = 1)]
				public byte[] ReadBlock(int blockIndex) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Write 16-byte block.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBlock
				/// </java-name>
				[Dot42.DexImport("writeBlock", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void WriteBlock(int blockIndex, sbyte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write 16-byte block.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeBlock
				/// </java-name>
				[Dot42.DexImport("writeBlock", "(I[B)V", AccessFlags = 1)]
				public void WriteBlock(int blockIndex, byte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Increment a value block, storing the result in the temporary block on the tag.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// increment
				/// </java-name>
				[Dot42.DexImport("increment", "(II)V", AccessFlags = 1)]
				public void Increment(int blockIndex, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Decrement a value block, storing the result in the temporary block on the tag.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// decrement
				/// </java-name>
				[Dot42.DexImport("decrement", "(II)V", AccessFlags = 1)]
				public void Decrement(int blockIndex, int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy from the temporary block to a value block.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// transfer
				/// </java-name>
				[Dot42.DexImport("transfer", "(I)V", AccessFlags = 1)]
				public void Transfer(int blockIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy from a value block to the temporary block.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// restore
				/// </java-name>
				[Dot42.DexImport("restore", "(I)V", AccessFlags = 1)]
				public void Restore(int blockIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send raw NfcA data to a tag and receive the response.</para> <para>This is equivalent to connecting to this tag via NfcA and calling NfcA#transceive. Note that all MIFARE Classic tags are based on NfcA technology.</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para> <para>NfcA::transceive </para></para>        
				/// </summary>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] Transceive(sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NfcA data to a tag and receive the response.</para> <para>This is equivalent to connecting to this tag via NfcA and calling NfcA#transceive. Note that all MIFARE Classic tags are based on NfcA technology.</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para> <para>NfcA::transceive </para></para>        
				/// </summary>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public byte[] Transceive(byte[] data) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				/// <summary>
				///  <para>Return the type of this MIFARE Classic compatible tag. </para> <para>One of TYPE_UNKNOWN, TYPE_CLASSIC, TYPE_PLUS or TYPE_PRO. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the size of the tag in bytes </para> <para>One of SIZE_MINI, SIZE_1K, SIZE_2K, SIZE_4K. These constants are equal to their respective size in bytes. </para> <para>Does not cause any RF activity and does not block. </para>        
				/// </summary>
				/// <returns>
				///  <para>size in bytes </para>
				/// </returns>
				/// <java-name>
				/// getSize
				/// </java-name>
				public int Size
				{
						[Dot42.DexImport("getSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the number of MIFARE Classic sectors. </para> <para>Does not cause any RF activity and does not block. </para>        
				/// </summary>
				/// <returns>
				///  <para>number of sectors </para>
				/// </returns>
				/// <java-name>
				/// getSectorCount
				/// </java-name>
				public int SectorCount
				{
						[Dot42.DexImport("getSectorCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the total number of MIFARE Classic blocks. </para> <para>Does not cause any RF activity and does not block. </para>        
				/// </summary>
				/// <returns>
				///  <para>total number of blocks </para>
				/// </returns>
				/// <java-name>
				/// getBlockCount
				/// </java-name>
				public int BlockCount
				{
						[Dot42.DexImport("getBlockCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

		/// <summary>
		///  <para>Provides access to MIFARE Ultralight properties and I/O operations on a Tag.</para> <para>Acquire a MifareUltralight object using get.</para> <para>MIFARE Ultralight compatible tags have 4 byte pages PAGE_SIZE. The primary operations on an Ultralight tag are readPages and writePage.</para> <para>The original MIFARE Ultralight consists of a 64 byte EEPROM. The first 4 pages are for the OTP area, manufacturer data, and locking bits. They are readable and some bits are writable. The final 12 pages are the user read/write area. For more information see the NXP data sheet MF0ICU1.</para> <para>The MIFARE Ultralight C consists of a 192 byte EEPROM. The first 4 pages are for OTP, manufacturer data, and locking bits. The next 36 pages are the user read/write area. The next 4 pages are additional locking bits, counters and authentication configuration and are readable. The final 4 pages are for the authentication key and are not readable. For more information see the NXP data sheet MF0ICU2.</para> <para>Implementation of this class on a Android NFC device is optional. If it is not implemented, then MifareUltralight will never be enumerated in Tag#getTechList. If it is enumerated, then all MifareUltralight I/O operations will be supported. In either case, NfcA will also be enumerated on the tag, because all MIFARE Ultralight tags are also NfcA tags.</para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/MifareUltralight
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/MifareUltralight", AccessFlags = 49)]
		public sealed partial class MifareUltralight : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A MIFARE Ultralight compatible tag of unknown type </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int TYPE_UNKNOWN = -1;
				/// <summary>
				///  <para>A MIFARE Ultralight tag </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ULTRALIGHT
				/// </java-name>
				[Dot42.DexImport("TYPE_ULTRALIGHT", "I", AccessFlags = 25)]
				public const int TYPE_ULTRALIGHT = 1;
				/// <summary>
				///  <para>A MIFARE Ultralight C tag </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ULTRALIGHT_C
				/// </java-name>
				[Dot42.DexImport("TYPE_ULTRALIGHT_C", "I", AccessFlags = 25)]
				public const int TYPE_ULTRALIGHT_C = 2;
				/// <summary>
				///  <para>Size of a MIFARE Ultralight page in bytes </para>        
				/// </summary>
				/// <java-name>
				/// PAGE_SIZE
				/// </java-name>
				[Dot42.DexImport("PAGE_SIZE", "I", AccessFlags = 25)]
				public const int PAGE_SIZE = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MifareUltralight() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of MifareUltralight for the given tag. </para> <para>Returns null if MifareUltralight was not enumerated in Tag#getTechList - this indicates the tag is not MIFARE Ultralight compatible, or that this Android device does not implement MIFARE Ultralight. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>MIFARE Ultralight object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/MifareUltralight;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.MifareUltralight Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.MifareUltralight);
				}

				/// <summary>
				///  <para>Read 4 pages (16 bytes).</para> <para>The MIFARE Ultralight protocol always reads 4 pages at a time, to reduce the number of commands required to read an entire tag. </para> <para>If a read spans past the last readable block, then the tag will return pages that have been wrapped back to the first blocks. MIFARE Ultralight tags have readable blocks 0x00 through 0x0F. So a read to block offset 0x0E would return blocks 0x0E, 0x0F, 0x00, 0x01. MIFARE Ultralight C tags have readable blocks 0x00 through 0x2B. So a read to block 0x2A would return blocks 0x2A, 0x2B, 0x00, 0x01.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>4 pages (16 bytes) </para>
				/// </returns>
				/// <java-name>
				/// readPages
				/// </java-name>
				[Dot42.DexImport("readPages", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaReadPages(int pageOffset) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Read 4 pages (16 bytes).</para> <para>The MIFARE Ultralight protocol always reads 4 pages at a time, to reduce the number of commands required to read an entire tag. </para> <para>If a read spans past the last readable block, then the tag will return pages that have been wrapped back to the first blocks. MIFARE Ultralight tags have readable blocks 0x00 through 0x0F. So a read to block offset 0x0E would return blocks 0x0E, 0x0F, 0x00, 0x01. MIFARE Ultralight C tags have readable blocks 0x00 through 0x2B. So a read to block 0x2A would return blocks 0x2A, 0x2B, 0x00, 0x01.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>4 pages (16 bytes) </para>
				/// </returns>
				/// <java-name>
				/// readPages
				/// </java-name>
				[Dot42.DexImport("readPages", "(I)[B", AccessFlags = 1)]
				public byte[] ReadPages(int pageOffset) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Write 1 page (4 bytes).</para> <para>The MIFARE Ultralight protocol always writes 1 page at a time, to minimize EEPROM write cycles.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writePage
				/// </java-name>
				[Dot42.DexImport("writePage", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void WritePage(int pageOffset, sbyte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Write 1 page (4 bytes).</para> <para>The MIFARE Ultralight protocol always writes 1 page at a time, to minimize EEPROM write cycles.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writePage
				/// </java-name>
				[Dot42.DexImport("writePage", "(I[B)V", AccessFlags = 1)]
				public void WritePage(int pageOffset, byte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Send raw NfcA data to a tag and receive the response.</para> <para>This is equivalent to connecting to this tag via NfcA and calling NfcA#transceive. Note that all MIFARE Classic tags are based on NfcA technology.</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para> <para>NfcA::transceive </para></para>        
				/// </summary>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] Transceive(sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NfcA data to a tag and receive the response.</para> <para>This is equivalent to connecting to this tag via NfcA and calling NfcA#transceive. Note that all MIFARE Classic tags are based on NfcA technology.</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para> <para>NfcA::transceive </para></para>        
				/// </summary>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public byte[] Transceive(byte[] data) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				/// <summary>
				///  <para>Return the MIFARE Ultralight type of the tag. </para> <para>One of TYPE_ULTRALIGHT or TYPE_ULTRALIGHT_C or TYPE_UNKNOWN. </para> <para>Depending on how the tag has been formatted, it can be impossible to accurately classify between original MIFARE Ultralight and Ultralight C. So treat this method as a hint. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

		/// <summary>
		///  <para>Provides access to NDEF content and operations on a Tag.</para> <para>Acquire a Ndef object using get.</para> <para>NDEF is an NFC Forum data format. The data formats are implemented in android.nfc.NdefMessage and android.nfc.NdefRecord. This class provides methods to retrieve and modify the android.nfc.NdefMessage on a tag.</para> <para>There are currently four NFC Forum standardized tag types that can be formatted to contain NDEF data.  <ul> <li> <para>NFC Forum Type 1 Tag (NFC_FORUM_TYPE_1), such as the Innovision Topaz </para></li> <li> <para>NFC Forum Type 2 Tag (NFC_FORUM_TYPE_2), such as the NXP MIFARE Ultralight </para></li> <li> <para>NFC Forum Type 3 Tag (NFC_FORUM_TYPE_3), such as Sony Felica </para></li> <li> <para>NFC Forum Type 4 Tag (NFC_FORUM_TYPE_4), such as NXP MIFARE Desfire </para></li></ul>It is mandatory for all Android devices with NFC to correctly enumerate Ndef on NFC Forum Tag Types 1-4, and implement all NDEF operations as defined in this class.</para> <para>Some vendors have there own well defined specifications for storing NDEF data on tags that do not fall into the above categories. Android devices with NFC should enumerate and implement Ndef under these vendor specifications where possible, but it is not mandatory. getType returns a String describing this specification, for example MIFARE_CLASSIC is  <code>com.nxp.ndef.mifareclassic</code>.</para> <para>Android devices that support MIFARE Classic must also correctly implement Ndef on MIFARE Classic tags formatted to NDEF.</para> <para>For guaranteed compatibility across all Android devices with NFC, it is recommended to use NFC Forum Types 1-4 in new deployments of NFC tags with NDEF payload. Vendor NDEF formats will not work on all Android devices.</para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/Ndef
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/Ndef", AccessFlags = 49)]
		public sealed partial class Ndef : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>NFC Forum Tag Type 1 </para>        
				/// </summary>
				/// <java-name>
				/// NFC_FORUM_TYPE_1
				/// </java-name>
				[Dot42.DexImport("NFC_FORUM_TYPE_1", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_FORUM_TYPE_1 = "org.nfcforum.ndef.type1";
				/// <summary>
				///  <para>NFC Forum Tag Type 2 </para>        
				/// </summary>
				/// <java-name>
				/// NFC_FORUM_TYPE_2
				/// </java-name>
				[Dot42.DexImport("NFC_FORUM_TYPE_2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_FORUM_TYPE_2 = "org.nfcforum.ndef.type2";
				/// <summary>
				///  <para>NFC Forum Tag Type 4 </para>        
				/// </summary>
				/// <java-name>
				/// NFC_FORUM_TYPE_3
				/// </java-name>
				[Dot42.DexImport("NFC_FORUM_TYPE_3", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_FORUM_TYPE_3 = "org.nfcforum.ndef.type3";
				/// <summary>
				///  <para>NFC Forum Tag Type 4 </para>        
				/// </summary>
				/// <java-name>
				/// NFC_FORUM_TYPE_4
				/// </java-name>
				[Dot42.DexImport("NFC_FORUM_TYPE_4", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_FORUM_TYPE_4 = "org.nfcforum.ndef.type4";
				/// <summary>
				///  <para>NDEF on MIFARE Classic </para>        
				/// </summary>
				/// <java-name>
				/// MIFARE_CLASSIC
				/// </java-name>
				[Dot42.DexImport("MIFARE_CLASSIC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MIFARE_CLASSIC = "com.nxp.ndef.mifareclassic";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Ndef() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of Ndef for the given tag.</para> <para>Returns null if Ndef was not enumerated in Tag#getTechList. This indicates the tag is not NDEF formatted, or that this tag is NDEF formatted but under a vendor specification that this Android device does not implement.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Ndef object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/Ndef;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.Ndef Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.Ndef);
				}

				/// <summary>
				///  <para>Overwrite the NdefMessage on this tag.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeNdefMessage
				/// </java-name>
				[Dot42.DexImport("writeNdefMessage", "(Landroid/nfc/NdefMessage;)V", AccessFlags = 1)]
				public void WriteNdefMessage(global::Android.Nfc.NdefMessage msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Make a tag read-only.</para> <para>This sets the CC field to indicate the tag is read-only, and where possible permanently sets the lock bits to prevent any further modification of the memory. </para> <para>This is a one-way process and cannot be reverted!</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true on success, false if it is not possible to make this tag read-only </para>
				/// </returns>
				/// <java-name>
				/// makeReadOnly
				/// </java-name>
				[Dot42.DexImport("makeReadOnly", "()Z", AccessFlags = 1)]
				public bool MakeReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
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

				/// <summary>
				///  <para>Get the NdefMessage that was read from the tag at discovery time.</para> <para>If the NDEF Message is modified by an I/O operation then it will not be updated here, this function only returns what was discovered when the tag entered the field. </para> <para>Note that this method may return null if the tag was in the INITIALIZED state as defined by NFC Forum, as in this state the tag is formatted to support NDEF but does not contain a message yet. </para> <para>Does not cause any RF activity and does not block. </para>        
				/// </summary>
				/// <returns>
				///  <para>NDEF Message read from the tag at discovery time, can be null </para>
				/// </returns>
				/// <java-name>
				/// getCachedNdefMessage
				/// </java-name>
				public global::Android.Nfc.NdefMessage CachedNdefMessage
				{
						[Dot42.DexImport("getCachedNdefMessage", "()Landroid/nfc/NdefMessage;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.NdefMessage); }
				}

				/// <summary>
				///  <para>Get the NDEF tag type.</para> <para>Returns one of NFC_FORUM_TYPE_1, NFC_FORUM_TYPE_2, NFC_FORUM_TYPE_3, NFC_FORUM_TYPE_4, MIFARE_CLASSIC or another NDEF tag type that has not yet been formalized in this Android API.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representing the NDEF tag type </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Get the maximum NDEF message size in bytes.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>size in bytes </para>
				/// </returns>
				/// <java-name>
				/// getMaxSize
				/// </java-name>
				public int MaxSize
				{
						[Dot42.DexImport("getMaxSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Determine if the tag is writable.</para> <para>NFC Forum tags can be in read-only or read-write states.</para> <para>Does not cause any RF activity and does not block.</para> <para>Requires android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the tag is writable </para>
				/// </returns>
				/// <java-name>
				/// isWritable
				/// </java-name>
				public bool IsWritable
				{
						[Dot42.DexImport("isWritable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Read the current android.nfc.NdefMessage on this tag.</para> <para>This always reads the current NDEF Message stored on the tag.</para> <para>Note that this method may return null if the tag was in the INITIALIZED state as defined by NFC Forum, as in that state the tag is formatted to support NDEF but does not contain a message yet.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the NDEF Message, can be null </para>
				/// </returns>
				/// <java-name>
				/// getNdefMessage
				/// </java-name>
				public global::Android.Nfc.NdefMessage NdefMessage
				{
						[Dot42.DexImport("getNdefMessage", "()Landroid/nfc/NdefMessage;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.NdefMessage); }
				}

				/// <summary>
				///  <para>Indicates whether a tag can be made read-only with makeReadOnly().</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if it is possible to make this tag read-only </para>
				/// </returns>
				/// <java-name>
				/// canMakeReadOnly
				/// </java-name>
				public bool CanMakeReadOnly
				{
						[Dot42.DexImport("canMakeReadOnly", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

		/// <summary>
		///  <para>Provide access to NDEF format operations on a Tag.</para> <para>Acquire a NdefFormatable object using get.</para> <para>Android devices with NFC must only enumerate and implement this class for tags for which it can format to NDEF.</para> <para>Unfortunately the procedures to convert unformated tags to NDEF formatted tags are not specified by NFC Forum, and are not generally well-known. So there is no mandatory set of tags for which all Android devices with NFC must support NdefFormatable.</para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/NdefFormatable
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/NdefFormatable", AccessFlags = 49)]
		public sealed partial class NdefFormatable : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NdefFormatable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of NdefFormatable for the given tag. </para> <para>Does not cause any RF activity and does not block. </para> <para>Returns null if NdefFormatable was not enumerated in Tag#getTechList. This indicates the tag is not NDEF formatable by this Android device.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>NDEF formatable object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NdefFormatable;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NdefFormatable Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NdefFormatable);
				}

				/// <summary>
				///  <para>Format a tag as NDEF, and write a NdefMessage.</para> <para>This is a multi-step process, an IOException is thrown if any one step fails. </para> <para>The card is left in a read-write state after this operation.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Landroid/nfc/NdefMessage;)V", AccessFlags = 1)]
				public void Format(global::Android.Nfc.NdefMessage firstMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Formats a tag as NDEF, write a NdefMessage, and make read-only.</para> <para>This is a multi-step process, an IOException is thrown if any one step fails. </para> <para>The card is left in a read-only state if this method returns successfully.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// formatReadOnly
				/// </java-name>
				[Dot42.DexImport("formatReadOnly", "(Landroid/nfc/NdefMessage;)V", AccessFlags = 1)]
				public void FormatReadOnly(global::Android.Nfc.NdefMessage firstMessage) /* MethodBuilder.Create */ 
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
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

		/// <summary>
		///  <para>Provides access to NFC-A (ISO 14443-3A) properties and I/O operations on a Tag.</para> <para>Acquire a NfcA object using get. </para> <para>The primary NFC-A I/O operation is transceive. Applications must implement their own protocol stack on top of transceive.</para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/NfcA
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/NfcA", AccessFlags = 49)]
		public sealed partial class NfcA : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NfcA() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of NfcA for the given tag. </para> <para>Returns null if NfcA was not enumerated in Tag#getTechList. This indicates the tag does not support NFC-A. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>NFC-A object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcA;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NfcA Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NfcA);
				}

				/// <summary>
				///  <para>Return the ATQA/SENS_RES bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ATQA/SENS_RES bytes </para>
				/// </returns>
				/// <java-name>
				/// getAtqa
				/// </java-name>
				[Dot42.DexImport("getAtqa", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetAtqa() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NFC-A commands to the tag and receive the response.</para> <para>Applications must not append the EoD (CRC) to the payload, it will be automatically calculated. </para> <para>Applications must only send commands that are complete bytes, for example a SENS_REQ is not possible (these are used to manage tag polling and initialization).</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>bytes received in response </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] Transceive(sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NFC-A commands to the tag and receive the response.</para> <para>Applications must not append the EoD (CRC) to the payload, it will be automatically calculated. </para> <para>Applications must only send commands that are complete bytes, for example a SENS_REQ is not possible (these are used to manage tag polling and initialization).</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>bytes received in response </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public byte[] Transceive(byte[] data) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				/// <summary>
				///  <para>Return the ATQA/SENS_RES bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>ATQA/SENS_RES bytes </para>
				/// </returns>
				/// <java-name>
				/// getAtqa
				/// </java-name>
				public byte[] Atqa
				{
						[Dot42.DexImport("getAtqa", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Return the SAK/SEL_RES bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>SAK bytes </para>
				/// </returns>
				/// <java-name>
				/// getSak
				/// </java-name>
				public short Sak
				{
						[Dot42.DexImport("getSak", "()S", AccessFlags = 1)]
						get{ return default(short); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

		/// <summary>
		///  <para>Provides access to NFC-B (ISO 14443-3B) properties and I/O operations on a Tag.</para> <para>Acquire a NfcB object using get. </para> <para>The primary NFC-B I/O operation is transceive. Applications must implement their own protocol stack on top of transceive.</para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/NfcB
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/NfcB", AccessFlags = 49)]
		public sealed partial class NfcB : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NfcB() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of NfcB for the given tag. </para> <para>Returns null if NfcB was not enumerated in Tag#getTechList. This indicates the tag does not support NFC-B. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>NFC-B object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcB;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NfcB Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NfcB);
				}

				/// <summary>
				///  <para>Return the Application Data bytes from ATQB/SENSB_RES at tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Application Data bytes from ATQB/SENSB_RES bytes </para>
				/// </returns>
				/// <java-name>
				/// getApplicationData
				/// </java-name>
				[Dot42.DexImport("getApplicationData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetApplicationData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Return the Protocol Info bytes from ATQB/SENSB_RES at tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Protocol Info bytes from ATQB/SENSB_RES bytes </para>
				/// </returns>
				/// <java-name>
				/// getProtocolInfo
				/// </java-name>
				[Dot42.DexImport("getProtocolInfo", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetProtocolInfo() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NFC-B commands to the tag and receive the response.</para> <para>Applications must not append the EoD (CRC) to the payload, it will be automatically calculated. </para> <para>Applications must not send commands that manage the polling loop and initialization (SENSB_REQ, SLOT_MARKER etc).</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>bytes received in response </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] Transceive(sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NFC-B commands to the tag and receive the response.</para> <para>Applications must not append the EoD (CRC) to the payload, it will be automatically calculated. </para> <para>Applications must not send commands that manage the polling loop and initialization (SENSB_REQ, SLOT_MARKER etc).</para> <para>Use getMaxTransceiveLength to retrieve the maximum number of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>bytes received in response </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public byte[] Transceive(byte[] data) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				/// <summary>
				///  <para>Return the Application Data bytes from ATQB/SENSB_RES at tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Application Data bytes from ATQB/SENSB_RES bytes </para>
				/// </returns>
				/// <java-name>
				/// getApplicationData
				/// </java-name>
				public byte[] ApplicationData
				{
						[Dot42.DexImport("getApplicationData", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Return the Protocol Info bytes from ATQB/SENSB_RES at tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Protocol Info bytes from ATQB/SENSB_RES bytes </para>
				/// </returns>
				/// <java-name>
				/// getProtocolInfo
				/// </java-name>
				public byte[] ProtocolInfo
				{
						[Dot42.DexImport("getProtocolInfo", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

		/// <summary>
		///  <para>Provides access to NFC-F (JIS 6319-4) properties and I/O operations on a Tag.</para> <para>Acquire a NfcF object using get. </para> <para>The primary NFC-F I/O operation is transceive. Applications must implement their own protocol stack on top of transceive.</para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/NfcF
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/NfcF", AccessFlags = 49)]
		public sealed partial class NfcF : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NfcF() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of NfcF for the given tag. </para> <para>Returns null if NfcF was not enumerated in Tag#getTechList. This indicates the tag does not support NFC-F. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>NFC-F object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcF;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NfcF Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NfcF);
				}

				/// <summary>
				///  <para>Return the System Code bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>System Code bytes </para>
				/// </returns>
				/// <java-name>
				/// getSystemCode
				/// </java-name>
				[Dot42.DexImport("getSystemCode", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetSystemCode() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Return the Manufacturer bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Manufacturer bytes </para>
				/// </returns>
				/// <java-name>
				/// getManufacturer
				/// </java-name>
				[Dot42.DexImport("getManufacturer", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] JavaGetManufacturer() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NFC-F commands to the tag and receive the response.</para> <para>Applications must not append the SoD (length) or EoD (CRC) to the payload, it will be automatically calculated.</para> <para>Use getMaxTransceiveLength to retrieve the maximum amount of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>bytes received in response </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] Transceive(sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NFC-F commands to the tag and receive the response.</para> <para>Applications must not append the SoD (length) or EoD (CRC) to the payload, it will be automatically calculated.</para> <para>Use getMaxTransceiveLength to retrieve the maximum amount of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>bytes received in response </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public byte[] Transceive(byte[] data) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				/// <summary>
				///  <para>Return the System Code bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>System Code bytes </para>
				/// </returns>
				/// <java-name>
				/// getSystemCode
				/// </java-name>
				public byte[] SystemCode
				{
						[Dot42.DexImport("getSystemCode", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Return the Manufacturer bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Manufacturer bytes </para>
				/// </returns>
				/// <java-name>
				/// getManufacturer
				/// </java-name>
				public byte[] Manufacturer
				{
						[Dot42.DexImport("getManufacturer", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

		/// <summary>
		///  <para>Provides access to NFC-V (ISO 15693) properties and I/O operations on a Tag.</para> <para>Acquire a NfcV object using get. </para> <para>The primary NFC-V I/O operation is transceive. Applications must implement their own protocol stack on top of transceive.</para> <para> <b>Note:</b> Methods that perform I/O operations require the android.Manifest.permission#NFC permission. </para>    
		/// </summary>
		/// <java-name>
		/// android/nfc/tech/NfcV
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/NfcV", AccessFlags = 49)]
		public sealed partial class NfcV : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NfcV() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get an instance of NfcV for the given tag. </para> <para>Returns null if NfcV was not enumerated in Tag#getTechList. This indicates the tag does not support NFC-V. </para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>NFC-V object </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcV;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NfcV Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NfcV);
				}

				/// <summary>
				///  <para>Return the Response Flag bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Response Flag bytes </para>
				/// </returns>
				/// <java-name>
				/// getResponseFlags
				/// </java-name>
				[Dot42.DexImport("getResponseFlags", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte JavaGetResponseFlags() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Return the DSF ID bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>DSF ID bytes </para>
				/// </returns>
				/// <java-name>
				/// getDsfId
				/// </java-name>
				[Dot42.DexImport("getDsfId", "()B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte JavaGetDsfId() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <summary>
				///  <para>Send raw NFC-V commands to the tag and receive the response.</para> <para>Applications must not append the CRC to the payload, it will be automatically calculated. The application does provide FLAGS, CMD and PARAMETER bytes.</para> <para>Use getMaxTransceiveLength to retrieve the maximum amount of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>bytes received in response </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public sbyte[] Transceive(sbyte[] data) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Send raw NFC-V commands to the tag and receive the response.</para> <para>Applications must not append the CRC to the payload, it will be automatically calculated. The application does provide FLAGS, CMD and PARAMETER bytes.</para> <para>Use getMaxTransceiveLength to retrieve the maximum amount of bytes that can be sent with transceive.</para> <para>This is an I/O operation and will block until complete. It must not be called from the main application thread. A blocked call will be canceled with IOException if close is called from another thread.</para> <para>Requires the android.Manifest.permission#NFC permission.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>bytes received in response </para>
				/// </returns>
				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public byte[] Transceive(byte[] data) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
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

				/// <summary>
				///  <para>Return the Response Flag bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Response Flag bytes </para>
				/// </returns>
				/// <java-name>
				/// getResponseFlags
				/// </java-name>
				public byte ResponseFlags
				{
						[Dot42.DexImport("getResponseFlags", "()B", AccessFlags = 1)]
						get{ return default(byte); }
				}

				/// <summary>
				///  <para>Return the DSF ID bytes from tag discovery.</para> <para>Does not cause any RF activity and does not block.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>DSF ID bytes </para>
				/// </returns>
				/// <java-name>
				/// getDsfId
				/// </java-name>
				public byte DsfId
				{
						[Dot42.DexImport("getDsfId", "()B", AccessFlags = 1)]
						get{ return default(byte); }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.Tag); }
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

}

