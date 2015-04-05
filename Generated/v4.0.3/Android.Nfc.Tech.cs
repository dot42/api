#pragma warning disable 1717
namespace Android.Nfc.Tech
{
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

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/IsoDep;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.IsoDep Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.IsoDep);
				}

				/// <java-name>
				/// getHistoricalBytes
				/// </java-name>
				[Dot42.DexImport("getHistoricalBytes", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetHistoricalBytes() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getHiLayerResponse
				/// </java-name>
				[Dot42.DexImport("getHiLayerResponse", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetHiLayerResponse() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public sbyte[] Transceive(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] Transceive(byte[] @byte) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getTimeout
				/// </java-name>
				public int Timeout
				{
						[Dot42.DexImport("getTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setTimeout", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getHistoricalBytes
				/// </java-name>
				public byte[] HistoricalBytes
				{
						[Dot42.DexImport("getHistoricalBytes", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getHiLayerResponse
				/// </java-name>
				public byte[] HiLayerResponse
				{
						[Dot42.DexImport("getHiLayerResponse", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getMaxTransceiveLength
				/// </java-name>
				public int MaxTransceiveLength
				{
						[Dot42.DexImport("getMaxTransceiveLength", "()I", AccessFlags = 1)]
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

		/// <java-name>
		/// android/nfc/tech/TagTechnology
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/TagTechnology", AccessFlags = 1537)]
		public partial interface ITagTechnology : global::Java.Io.ICloseable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// connect
				/// </java-name>
				[Dot42.DexImport("connect", "()V", AccessFlags = 1025)]
				void Connect() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTag
				/// </java-name>
				global::Android.Nfc.Tag Tag
				{
						[Dot42.DexImport("getTag", "()Landroid/nfc/Tag;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isConnected
				/// </java-name>
				bool IsConnected
				{
						[Dot42.DexImport("isConnected", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/nfc/tech/MifareClassic
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/MifareClassic", AccessFlags = 49)]
		public sealed partial class MifareClassic : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// KEY_DEFAULT
				/// </java-name>
				[Dot42.DexImport("KEY_DEFAULT", "[B", AccessFlags = 25)]
				public static readonly sbyte[] KEY_DEFAULT;
				/// <java-name>
				/// KEY_MIFARE_APPLICATION_DIRECTORY
				/// </java-name>
				[Dot42.DexImport("KEY_MIFARE_APPLICATION_DIRECTORY", "[B", AccessFlags = 25)]
				public static readonly sbyte[] KEY_MIFARE_APPLICATION_DIRECTORY;
				/// <java-name>
				/// KEY_NFC_FORUM
				/// </java-name>
				[Dot42.DexImport("KEY_NFC_FORUM", "[B", AccessFlags = 25)]
				public static readonly sbyte[] KEY_NFC_FORUM;
				/// <java-name>
				/// TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int TYPE_UNKNOWN = -1;
				/// <java-name>
				/// TYPE_CLASSIC
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASSIC", "I", AccessFlags = 25)]
				public const int TYPE_CLASSIC = 0;
				/// <java-name>
				/// TYPE_PLUS
				/// </java-name>
				[Dot42.DexImport("TYPE_PLUS", "I", AccessFlags = 25)]
				public const int TYPE_PLUS = 1;
				/// <java-name>
				/// TYPE_PRO
				/// </java-name>
				[Dot42.DexImport("TYPE_PRO", "I", AccessFlags = 25)]
				public const int TYPE_PRO = 2;
				/// <java-name>
				/// SIZE_1K
				/// </java-name>
				[Dot42.DexImport("SIZE_1K", "I", AccessFlags = 25)]
				public const int SIZE_1K = 1024;
				/// <java-name>
				/// SIZE_2K
				/// </java-name>
				[Dot42.DexImport("SIZE_2K", "I", AccessFlags = 25)]
				public const int SIZE_2K = 2048;
				/// <java-name>
				/// SIZE_4K
				/// </java-name>
				[Dot42.DexImport("SIZE_4K", "I", AccessFlags = 25)]
				public const int SIZE_4K = 4096;
				/// <java-name>
				/// SIZE_MINI
				/// </java-name>
				[Dot42.DexImport("SIZE_MINI", "I", AccessFlags = 25)]
				public const int SIZE_MINI = 320;
				/// <java-name>
				/// BLOCK_SIZE
				/// </java-name>
				[Dot42.DexImport("BLOCK_SIZE", "I", AccessFlags = 25)]
				public const int BLOCK_SIZE = 16;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MifareClassic() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/MifareClassic;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.MifareClassic Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.MifareClassic);
				}

				/// <java-name>
				/// getBlockCountInSector
				/// </java-name>
				[Dot42.DexImport("getBlockCountInSector", "(I)I", AccessFlags = 1)]
				public int GetBlockCountInSector(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// blockToSector
				/// </java-name>
				[Dot42.DexImport("blockToSector", "(I)I", AccessFlags = 1)]
				public int BlockToSector(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// sectorToBlock
				/// </java-name>
				[Dot42.DexImport("sectorToBlock", "(I)I", AccessFlags = 1)]
				public int SectorToBlock(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// authenticateSectorWithKeyA
				/// </java-name>
				[Dot42.DexImport("authenticateSectorWithKeyA", "(I[B)Z", AccessFlags = 1)]
				public bool AuthenticateSectorWithKeyA(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// authenticateSectorWithKeyA
				/// </java-name>
				[Dot42.DexImport("authenticateSectorWithKeyA", "(I[B)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public bool AuthenticateSectorWithKeyA(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// authenticateSectorWithKeyB
				/// </java-name>
				[Dot42.DexImport("authenticateSectorWithKeyB", "(I[B)Z", AccessFlags = 1)]
				public bool AuthenticateSectorWithKeyB(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// authenticateSectorWithKeyB
				/// </java-name>
				[Dot42.DexImport("authenticateSectorWithKeyB", "(I[B)Z", AccessFlags = 1, IgnoreFromJava = true)]
				public bool AuthenticateSectorWithKeyB(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// readBlock
				/// </java-name>
				[Dot42.DexImport("readBlock", "(I)[B", AccessFlags = 1)]
				public sbyte[] JavaReadBlock(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// readBlock
				/// </java-name>
				[Dot42.DexImport("readBlock", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] ReadBlock(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// writeBlock
				/// </java-name>
				[Dot42.DexImport("writeBlock", "(I[B)V", AccessFlags = 1)]
				public void WriteBlock(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeBlock
				/// </java-name>
				[Dot42.DexImport("writeBlock", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void WriteBlock(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// increment
				/// </java-name>
				[Dot42.DexImport("increment", "(II)V", AccessFlags = 1)]
				public void Increment(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// decrement
				/// </java-name>
				[Dot42.DexImport("decrement", "(II)V", AccessFlags = 1)]
				public void Decrement(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transfer
				/// </java-name>
				[Dot42.DexImport("transfer", "(I)V", AccessFlags = 1)]
				public void Transfer(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restore
				/// </java-name>
				[Dot42.DexImport("restore", "(I)V", AccessFlags = 1)]
				public void Restore(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public sbyte[] Transceive(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] Transceive(byte[] @byte) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				public int Size
				{
						[Dot42.DexImport("getSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSectorCount
				/// </java-name>
				public int SectorCount
				{
						[Dot42.DexImport("getSectorCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBlockCount
				/// </java-name>
				public int BlockCount
				{
						[Dot42.DexImport("getBlockCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMaxTransceiveLength
				/// </java-name>
				public int MaxTransceiveLength
				{
						[Dot42.DexImport("getMaxTransceiveLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTimeout
				/// </java-name>
				public int Timeout
				{
						[Dot42.DexImport("getTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setTimeout", "(I)V", AccessFlags = 1)]
						set{ }
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

		/// <java-name>
		/// android/nfc/tech/MifareUltralight
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/MifareUltralight", AccessFlags = 49)]
		public sealed partial class MifareUltralight : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int TYPE_UNKNOWN = -1;
				/// <java-name>
				/// TYPE_ULTRALIGHT
				/// </java-name>
				[Dot42.DexImport("TYPE_ULTRALIGHT", "I", AccessFlags = 25)]
				public const int TYPE_ULTRALIGHT = 1;
				/// <java-name>
				/// TYPE_ULTRALIGHT_C
				/// </java-name>
				[Dot42.DexImport("TYPE_ULTRALIGHT_C", "I", AccessFlags = 25)]
				public const int TYPE_ULTRALIGHT_C = 2;
				/// <java-name>
				/// PAGE_SIZE
				/// </java-name>
				[Dot42.DexImport("PAGE_SIZE", "I", AccessFlags = 25)]
				public const int PAGE_SIZE = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MifareUltralight() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/MifareUltralight;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.MifareUltralight Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.MifareUltralight);
				}

				/// <java-name>
				/// readPages
				/// </java-name>
				[Dot42.DexImport("readPages", "(I)[B", AccessFlags = 1)]
				public sbyte[] JavaReadPages(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// readPages
				/// </java-name>
				[Dot42.DexImport("readPages", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] ReadPages(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// writePage
				/// </java-name>
				[Dot42.DexImport("writePage", "(I[B)V", AccessFlags = 1)]
				public void WritePage(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writePage
				/// </java-name>
				[Dot42.DexImport("writePage", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void WritePage(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public sbyte[] Transceive(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] Transceive(byte[] @byte) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getType
				/// </java-name>
				public int Type
				{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMaxTransceiveLength
				/// </java-name>
				public int MaxTransceiveLength
				{
						[Dot42.DexImport("getMaxTransceiveLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTimeout
				/// </java-name>
				public int Timeout
				{
						[Dot42.DexImport("getTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setTimeout", "(I)V", AccessFlags = 1)]
						set{ }
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

		/// <java-name>
		/// android/nfc/tech/Ndef
		/// </java-name>
		[Dot42.DexImport("android/nfc/tech/Ndef", AccessFlags = 49)]
		public sealed partial class Ndef : global::Android.Nfc.Tech.ITagTechnology
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NFC_FORUM_TYPE_1
				/// </java-name>
				[Dot42.DexImport("NFC_FORUM_TYPE_1", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_FORUM_TYPE_1 = "org.nfcforum.ndef.type1";
				/// <java-name>
				/// NFC_FORUM_TYPE_2
				/// </java-name>
				[Dot42.DexImport("NFC_FORUM_TYPE_2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_FORUM_TYPE_2 = "org.nfcforum.ndef.type2";
				/// <java-name>
				/// NFC_FORUM_TYPE_3
				/// </java-name>
				[Dot42.DexImport("NFC_FORUM_TYPE_3", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_FORUM_TYPE_3 = "org.nfcforum.ndef.type3";
				/// <java-name>
				/// NFC_FORUM_TYPE_4
				/// </java-name>
				[Dot42.DexImport("NFC_FORUM_TYPE_4", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NFC_FORUM_TYPE_4 = "org.nfcforum.ndef.type4";
				/// <java-name>
				/// MIFARE_CLASSIC
				/// </java-name>
				[Dot42.DexImport("MIFARE_CLASSIC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MIFARE_CLASSIC = "com.nxp.ndef.mifareclassic";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Ndef() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/Ndef;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.Ndef Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.Ndef);
				}

				/// <java-name>
				/// writeNdefMessage
				/// </java-name>
				[Dot42.DexImport("writeNdefMessage", "(Landroid/nfc/NdefMessage;)V", AccessFlags = 1)]
				public void WriteNdefMessage(global::Android.Nfc.NdefMessage ndefMessage) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getCachedNdefMessage
				/// </java-name>
				public global::Android.Nfc.NdefMessage CachedNdefMessage
				{
						[Dot42.DexImport("getCachedNdefMessage", "()Landroid/nfc/NdefMessage;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.NdefMessage); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getMaxSize
				/// </java-name>
				public int MaxSize
				{
						[Dot42.DexImport("getMaxSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isWritable
				/// </java-name>
				public bool IsWritable
				{
						[Dot42.DexImport("isWritable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getNdefMessage
				/// </java-name>
				public global::Android.Nfc.NdefMessage NdefMessage
				{
						[Dot42.DexImport("getNdefMessage", "()Landroid/nfc/NdefMessage;", AccessFlags = 1)]
						get{ return default(global::Android.Nfc.NdefMessage); }
				}

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

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NdefFormatable;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NdefFormatable Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NdefFormatable);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Landroid/nfc/NdefMessage;)V", AccessFlags = 1)]
				public void Format(global::Android.Nfc.NdefMessage ndefMessage) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatReadOnly
				/// </java-name>
				[Dot42.DexImport("formatReadOnly", "(Landroid/nfc/NdefMessage;)V", AccessFlags = 1)]
				public void FormatReadOnly(global::Android.Nfc.NdefMessage ndefMessage) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcA;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NfcA Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NfcA);
				}

				/// <java-name>
				/// getAtqa
				/// </java-name>
				[Dot42.DexImport("getAtqa", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetAtqa() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public sbyte[] Transceive(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] Transceive(byte[] @byte) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getAtqa
				/// </java-name>
				public byte[] Atqa
				{
						[Dot42.DexImport("getAtqa", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getSak
				/// </java-name>
				public short Sak
				{
						[Dot42.DexImport("getSak", "()S", AccessFlags = 1)]
						get{ return default(short); }
				}

				/// <java-name>
				/// getMaxTransceiveLength
				/// </java-name>
				public int MaxTransceiveLength
				{
						[Dot42.DexImport("getMaxTransceiveLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTimeout
				/// </java-name>
				public int Timeout
				{
						[Dot42.DexImport("getTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setTimeout", "(I)V", AccessFlags = 1)]
						set{ }
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

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcB;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NfcB Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NfcB);
				}

				/// <java-name>
				/// getApplicationData
				/// </java-name>
				[Dot42.DexImport("getApplicationData", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetApplicationData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getProtocolInfo
				/// </java-name>
				[Dot42.DexImport("getProtocolInfo", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetProtocolInfo() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public sbyte[] Transceive(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] Transceive(byte[] @byte) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getApplicationData
				/// </java-name>
				public byte[] ApplicationData
				{
						[Dot42.DexImport("getApplicationData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getProtocolInfo
				/// </java-name>
				public byte[] ProtocolInfo
				{
						[Dot42.DexImport("getProtocolInfo", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getMaxTransceiveLength
				/// </java-name>
				public int MaxTransceiveLength
				{
						[Dot42.DexImport("getMaxTransceiveLength", "()I", AccessFlags = 1)]
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

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcF;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NfcF Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NfcF);
				}

				/// <java-name>
				/// getSystemCode
				/// </java-name>
				[Dot42.DexImport("getSystemCode", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetSystemCode() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getManufacturer
				/// </java-name>
				[Dot42.DexImport("getManufacturer", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetManufacturer() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public sbyte[] Transceive(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] Transceive(byte[] @byte) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getSystemCode
				/// </java-name>
				public byte[] SystemCode
				{
						[Dot42.DexImport("getSystemCode", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getManufacturer
				/// </java-name>
				public byte[] Manufacturer
				{
						[Dot42.DexImport("getManufacturer", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getMaxTransceiveLength
				/// </java-name>
				public int MaxTransceiveLength
				{
						[Dot42.DexImport("getMaxTransceiveLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTimeout
				/// </java-name>
				public int Timeout
				{
						[Dot42.DexImport("getTimeout", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setTimeout", "(I)V", AccessFlags = 1)]
						set{ }
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

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/NfcV;", AccessFlags = 9)]
				public static global::Android.Nfc.Tech.NfcV Get(global::Android.Nfc.Tag tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Nfc.Tech.NfcV);
				}

				/// <java-name>
				/// getResponseFlags
				/// </java-name>
				[Dot42.DexImport("getResponseFlags", "()B", AccessFlags = 1)]
				public sbyte JavaGetResponseFlags() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// getDsfId
				/// </java-name>
				[Dot42.DexImport("getDsfId", "()B", AccessFlags = 1)]
				public sbyte JavaGetDsfId() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1)]
				public sbyte[] Transceive(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// transceive
				/// </java-name>
				[Dot42.DexImport("transceive", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] Transceive(byte[] @byte) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getResponseFlags
				/// </java-name>
				public byte ResponseFlags
				{
						[Dot42.DexImport("getResponseFlags", "()B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte); }
				}

				/// <java-name>
				/// getDsfId
				/// </java-name>
				public byte DsfId
				{
						[Dot42.DexImport("getDsfId", "()B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte); }
				}

				/// <java-name>
				/// getMaxTransceiveLength
				/// </java-name>
				public int MaxTransceiveLength
				{
						[Dot42.DexImport("getMaxTransceiveLength", "()I", AccessFlags = 1)]
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

}

