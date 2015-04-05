#pragma warning disable 1717
namespace Javax.Crypto
{
		/// <java-name>
		/// javax/crypto/BadPaddingException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/BadPaddingException", AccessFlags = 33)]
		public partial class BadPaddingException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BadPaddingException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BadPaddingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/crypto/Cipher
		/// </java-name>
		[Dot42.DexImport("javax/crypto/Cipher", AccessFlags = 33)]
		public partial class Cipher
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DECRYPT_MODE
				/// </java-name>
				[Dot42.DexImport("DECRYPT_MODE", "I", AccessFlags = 25)]
				public const int DECRYPT_MODE = 2;
				/// <java-name>
				/// ENCRYPT_MODE
				/// </java-name>
				[Dot42.DexImport("ENCRYPT_MODE", "I", AccessFlags = 25)]
				public const int ENCRYPT_MODE = 1;
				/// <java-name>
				/// PRIVATE_KEY
				/// </java-name>
				[Dot42.DexImport("PRIVATE_KEY", "I", AccessFlags = 25)]
				public const int PRIVATE_KEY = 2;
				/// <java-name>
				/// PUBLIC_KEY
				/// </java-name>
				[Dot42.DexImport("PUBLIC_KEY", "I", AccessFlags = 25)]
				public const int PUBLIC_KEY = 1;
				/// <java-name>
				/// SECRET_KEY
				/// </java-name>
				[Dot42.DexImport("SECRET_KEY", "I", AccessFlags = 25)]
				public const int SECRET_KEY = 3;
				/// <java-name>
				/// UNWRAP_MODE
				/// </java-name>
				[Dot42.DexImport("UNWRAP_MODE", "I", AccessFlags = 25)]
				public const int UNWRAP_MODE = 4;
				/// <java-name>
				/// WRAP_MODE
				/// </java-name>
				[Dot42.DexImport("WRAP_MODE", "I", AccessFlags = 25)]
				public const int WRAP_MODE = 3;
				[Dot42.DexImport("<init>", "(Ljavax/crypto/CipherSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Cipher(global::Javax.Crypto.CipherSpi cipherSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/Cipher;", AccessFlags = 25)]
				public static global::Javax.Crypto.Cipher GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.Cipher);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Cipher;", AccessFlags = 25)]
				public static global::Javax.Crypto.Cipher GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.Cipher);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Cipher;", AccessFlags = 25)]
				public static global::Javax.Crypto.Cipher GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.Cipher);
				}

				/// <java-name>
				/// getOutputSize
				/// </java-name>
				[Dot42.DexImport("getOutputSize", "(I)I", AccessFlags = 17)]
				public int GetOutputSize(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetIV() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.IKey key, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/Se" +
    "cureRandom;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters algorithmParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRand" +
    "om;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters algorithmParameters, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/cert/Certificate;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.Cert.Certificate certificate, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)[B", AccessFlags = 17)]
				public sbyte[] Update(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Update(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)[B", AccessFlags = 17)]
				public sbyte[] Update(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Update(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII[B)I", AccessFlags = 17)]
				public int Update(sbyte[] sByte, int int32, int int321, sbyte[] sByte1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII[B)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int Update(byte[] @byte, int int32, int int321, byte[] byte1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII[BI)I", AccessFlags = 17)]
				public int Update(sbyte[] sByte, int int32, int int321, sbyte[] sByte1, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII[BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int Update(byte[] @byte, int int32, int int321, byte[] byte1, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", AccessFlags = 17)]
				public int Update(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.ByteBuffer byteBuffer1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "()[B", AccessFlags = 17)]
				public sbyte[] JavaDoFinal() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BI)I", AccessFlags = 17)]
				public int DoFinal(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int DoFinal(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([B)[B", AccessFlags = 17)]
				public sbyte[] DoFinal(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([B)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII)[B", AccessFlags = 17)]
				public sbyte[] DoFinal(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII[B)I", AccessFlags = 17)]
				public int DoFinal(sbyte[] sByte, int int32, int int321, sbyte[] sByte1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII[B)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int DoFinal(byte[] @byte, int int32, int int321, byte[] byte1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII[BI)I", AccessFlags = 17)]
				public int DoFinal(sbyte[] sByte, int int32, int int321, sbyte[] sByte1, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII[BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int DoFinal(byte[] @byte, int int32, int int321, byte[] byte1, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", AccessFlags = 17)]
				public int DoFinal(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.ByteBuffer byteBuffer1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/security/Key;)[B", AccessFlags = 17)]
				public sbyte[] JavaWrap(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/security/Key;)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Wrap(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "([BLjava/lang/String;I)Ljava/security/Key;", AccessFlags = 17)]
				public global::Java.Security.IKey Unwrap(sbyte[] sByte, string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "([BLjava/lang/String;I)Ljava/security/Key;", AccessFlags = 17, IgnoreFromJava = true)]
				public global::Java.Security.IKey Unwrap(byte[] @byte, string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <java-name>
				/// getMaxAllowedKeyLength
				/// </java-name>
				[Dot42.DexImport("getMaxAllowedKeyLength", "(Ljava/lang/String;)I", AccessFlags = 25)]
				public static int GetMaxAllowedKeyLength(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMaxAllowedParameterSpec
				/// </java-name>
				[Dot42.DexImport("getMaxAllowedParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 25)]
				public static global::Java.Security.Spec.IAlgorithmParameterSpec GetMaxAllowedParameterSpec(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IAlgorithmParameterSpec);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Cipher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getBlockSize
				/// </java-name>
				public int BlockSize
				{
						[Dot42.DexImport("getBlockSize", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getIV
				/// </java-name>
				public byte[] IV
				{
						[Dot42.DexImport("getIV", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Security.AlgorithmParameters Parameters
				{
						[Dot42.DexImport("getParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 17)]
						get{ return default(global::Java.Security.AlgorithmParameters); }
				}

				/// <java-name>
				/// getExemptionMechanism
				/// </java-name>
				public global::Javax.Crypto.ExemptionMechanism ExemptionMechanism
				{
						[Dot42.DexImport("getExemptionMechanism", "()Ljavax/crypto/ExemptionMechanism;", AccessFlags = 17)]
						get{ return default(global::Javax.Crypto.ExemptionMechanism); }
				}

		}

		/// <java-name>
		/// javax/crypto/CipherInputStream
		/// </java-name>
		[Dot42.DexImport("javax/crypto/CipherInputStream", AccessFlags = 33)]
		public partial class CipherInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljavax/crypto/Cipher;)V", AccessFlags = 1)]
				public CipherInputStream(global::Java.Io.InputStream inputStream, global::Javax.Crypto.Cipher cipher) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 4)]
				protected internal CipherInputStream(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// markSupported
				/// </java-name>
				[Dot42.DexImport("markSupported", "()Z", AccessFlags = 1)]
				public override bool MarkSupported() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CipherInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// javax/crypto/CipherOutputStream
		/// </java-name>
		[Dot42.DexImport("javax/crypto/CipherOutputStream", AccessFlags = 33)]
		public partial class CipherOutputStream : global::Java.Io.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljavax/crypto/Cipher;)V", AccessFlags = 1)]
				public CipherOutputStream(global::Java.Io.OutputStream outputStream, global::Javax.Crypto.Cipher cipher) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 4)]
				protected internal CipherOutputStream(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CipherOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// javax/crypto/CipherSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/CipherSpi", AccessFlags = 1057)]
		public abstract partial class CipherSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CipherSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineSetMode
				/// </java-name>
				[Dot42.DexImport("engineSetMode", "(Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void EngineSetMode(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSetPadding
				/// </java-name>
				[Dot42.DexImport("engineSetPadding", "(Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void EngineSetPadding(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetBlockSize
				/// </java-name>
				[Dot42.DexImport("engineGetBlockSize", "()I", AccessFlags = 1028)]
				protected internal abstract int EngineGetBlockSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetOutputSize
				/// </java-name>
				[Dot42.DexImport("engineGetOutputSize", "(I)I", AccessFlags = 1028)]
				protected internal abstract int EngineGetOutputSize(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetIV
				/// </java-name>
				[Dot42.DexImport("engineGetIV", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGetIV() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetIV
				/// </java-name>
				[Dot42.DexImport("engineGetIV", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGetIV() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetParameters
				/// </java-name>
				[Dot42.DexImport("engineGetParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.AlgorithmParameters EngineGetParameters() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int int32, global::Java.Security.IKey key, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/Se" +
    "cureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int int32, global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRand" +
    "om;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int int32, global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters algorithmParameters, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] EngineUpdate(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineUpdate(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII[BI)I", AccessFlags = 1028)]
				protected internal abstract int EngineUpdate(sbyte[] sByte, int int32, int int321, sbyte[] sByte1, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII[BI)I", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract int EngineUpdate(byte[] @byte, int int32, int int321, byte[] byte1, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", AccessFlags = 4)]
				protected internal virtual int EngineUpdate(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.ByteBuffer byteBuffer1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "([BII)[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] EngineDoFinal(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "([BII)[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineDoFinal(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "([BII[BI)I", AccessFlags = 1028)]
				protected internal abstract int EngineDoFinal(sbyte[] sByte, int int32, int int321, sbyte[] sByte1, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "([BII[BI)I", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract int EngineDoFinal(byte[] @byte, int int32, int int321, byte[] byte1, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", AccessFlags = 4)]
				protected internal virtual int EngineDoFinal(global::Java.Nio.ByteBuffer byteBuffer, global::Java.Nio.ByteBuffer byteBuffer1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// engineWrap
				/// </java-name>
				[Dot42.DexImport("engineWrap", "(Ljava/security/Key;)[B", AccessFlags = 4)]
				protected internal virtual sbyte[] JavaEngineWrap(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// engineWrap
				/// </java-name>
				[Dot42.DexImport("engineWrap", "(Ljava/security/Key;)[B", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual byte[] EngineWrap(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// engineUnwrap
				/// </java-name>
				[Dot42.DexImport("engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.IKey EngineUnwrap(sbyte[] sByte, string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <java-name>
				/// engineUnwrap
				/// </java-name>
				[Dot42.DexImport("engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual global::Java.Security.IKey EngineUnwrap(byte[] @byte, string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <java-name>
				/// engineGetKeySize
				/// </java-name>
				[Dot42.DexImport("engineGetKeySize", "(Ljava/security/Key;)I", AccessFlags = 4)]
				protected internal virtual int EngineGetKeySize(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// javax/crypto/EncryptedPrivateKeyInfo
		/// </java-name>
		[Dot42.DexImport("javax/crypto/EncryptedPrivateKeyInfo", AccessFlags = 33)]
		public partial class EncryptedPrivateKeyInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public EncryptedPrivateKeyInfo(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public EncryptedPrivateKeyInfo(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 1)]
				public EncryptedPrivateKeyInfo(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public EncryptedPrivateKeyInfo(string @string, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/AlgorithmParameters;[B)V", AccessFlags = 1)]
				public EncryptedPrivateKeyInfo(global::Java.Security.AlgorithmParameters algorithmParameters, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/AlgorithmParameters;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public EncryptedPrivateKeyInfo(global::Java.Security.AlgorithmParameters algorithmParameters, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncryptedData
				/// </java-name>
				[Dot42.DexImport("getEncryptedData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetEncryptedData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljavax/crypto/Cipher;)Ljava/security/spec/PKCS8EncodedKeySpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(global::Javax.Crypto.Cipher cipher) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.PKCS8EncodedKeySpec);
				}

				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljava/security/Key;)Ljava/security/spec/PKCS8EncodedKeySpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.PKCS8EncodedKeySpec);
				}

				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljava/security/Key;Ljava/lang/String;)Ljava/security/spec/PKCS8EncodedKeySpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(global::Java.Security.IKey key, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.PKCS8EncodedKeySpec);
				}

				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeyS" +
    "pec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(global::Java.Security.IKey key, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.PKCS8EncodedKeySpec);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EncryptedPrivateKeyInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgName
				/// </java-name>
				public virtual string AlgName
				{
						[Dot42.DexImport("getAlgName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getAlgParameters
				/// </java-name>
				public virtual global::Java.Security.AlgorithmParameters AlgParameters
				{
						[Dot42.DexImport("getAlgParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 1)]
						get{ return default(global::Java.Security.AlgorithmParameters); }
				}

				/// <java-name>
				/// getEncryptedData
				/// </java-name>
				public virtual byte[] EncryptedData
				{
						[Dot42.DexImport("getEncryptedData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public virtual byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <java-name>
		/// javax/crypto/ExemptionMechanism
		/// </java-name>
		[Dot42.DexImport("javax/crypto/ExemptionMechanism", AccessFlags = 33)]
		public partial class ExemptionMechanism
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/crypto/ExemptionMechanismSpi;Ljava/security/Provider;Ljava/lang/String;)V" +
    "", AccessFlags = 4)]
				protected internal ExemptionMechanism(global::Javax.Crypto.ExemptionMechanismSpi exemptionMechanismSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;", AccessFlags = 25)]
				public static global::Javax.Crypto.ExemptionMechanism GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ExemptionMechanism);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;", AccessFlags = 25)]
				public static global::Javax.Crypto.ExemptionMechanism GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ExemptionMechanism);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/ExemptionMechanism;", AccessFlags = 25)]
				public static global::Javax.Crypto.ExemptionMechanism GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ExemptionMechanism);
				}

				/// <java-name>
				/// isCryptoAllowed
				/// </java-name>
				[Dot42.DexImport("isCryptoAllowed", "(Ljava/security/Key;)Z", AccessFlags = 17)]
				public bool IsCryptoAllowed(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getOutputSize
				/// </java-name>
				[Dot42.DexImport("getOutputSize", "(I)I", AccessFlags = 17)]
				public int GetOutputSize(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters algorithmParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGenExemptionBlob() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GenExemptionBlob() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "([B)I", AccessFlags = 17)]
				public int GenExemptionBlob(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "([B)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int GenExemptionBlob(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "([BI)I", AccessFlags = 17)]
				public int GenExemptionBlob(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "([BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int GenExemptionBlob(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ExemptionMechanism() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ExemptionMechanism() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

		}

		/// <java-name>
		/// javax/crypto/ExemptionMechanismException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/ExemptionMechanismException", AccessFlags = 33)]
		public partial class ExemptionMechanismException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ExemptionMechanismException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExemptionMechanismException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/crypto/ExemptionMechanismSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/ExemptionMechanismSpi", AccessFlags = 1057)]
		public abstract partial class ExemptionMechanismSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExemptionMechanismSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGenExemptionBlob
				/// </java-name>
				[Dot42.DexImport("engineGenExemptionBlob", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGenExemptionBlob() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenExemptionBlob
				/// </java-name>
				[Dot42.DexImport("engineGenExemptionBlob", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGenExemptionBlob() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenExemptionBlob
				/// </java-name>
				[Dot42.DexImport("engineGenExemptionBlob", "([BI)I", AccessFlags = 1028)]
				protected internal abstract int EngineGenExemptionBlob(sbyte[] sByte, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenExemptionBlob
				/// </java-name>
				[Dot42.DexImport("engineGenExemptionBlob", "([BI)I", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract int EngineGenExemptionBlob(byte[] @byte, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetOutputSize
				/// </java-name>
				[Dot42.DexImport("engineGetOutputSize", "(I)I", AccessFlags = 1028)]
				protected internal abstract int EngineGetOutputSize(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters algorithmParameters) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/crypto/IllegalBlockSizeException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/IllegalBlockSizeException", AccessFlags = 33)]
		public partial class IllegalBlockSizeException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalBlockSizeException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalBlockSizeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/crypto/SecretKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SecretKey", AccessFlags = 1537)]
		public partial interface ISecretKey : global::Java.Security.IKey
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// javax/crypto/SecretKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SecretKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISecretKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -4795878709595146952;
		}

		/// <java-name>
		/// javax/crypto/KeyAgreement
		/// </java-name>
		[Dot42.DexImport("javax/crypto/KeyAgreement", AccessFlags = 33)]
		public partial class KeyAgreement
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/crypto/KeyAgreementSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyAgreement(global::Javax.Crypto.KeyAgreementSpi keyAgreementSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyAgreement;", AccessFlags = 25)]
				public static global::Javax.Crypto.KeyAgreement GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.KeyAgreement);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyAgreement;", AccessFlags = 25)]
				public static global::Javax.Crypto.KeyAgreement GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.KeyAgreement);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyAgreement;", AccessFlags = 25)]
				public static global::Javax.Crypto.KeyAgreement GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.KeyAgreement);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/Sec" +
    "ureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doPhase
				/// </java-name>
				[Dot42.DexImport("doPhase", "(Ljava/security/Key;Z)Ljava/security/Key;", AccessFlags = 17)]
				public global::Java.Security.IKey DoPhase(global::Java.Security.IKey key, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGenerateSecret() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GenerateSecret() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "([BI)I", AccessFlags = 17)]
				public int GenerateSecret(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "([BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int GenerateSecret(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", AccessFlags = 17)]
				public global::Javax.Crypto.ISecretKey GenerateSecret(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ISecretKey);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyAgreement() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

		}

		/// <java-name>
		/// javax/crypto/KeyAgreementSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/KeyAgreementSpi", AccessFlags = 1057)]
		public abstract partial class KeyAgreementSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyAgreementSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineDoPhase
				/// </java-name>
				[Dot42.DexImport("engineDoPhase", "(Ljava/security/Key;Z)Ljava/security/Key;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.IKey EngineDoPhase(global::Java.Security.IKey key, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGenerateSecret() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGenerateSecret() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "([BI)I", AccessFlags = 1028)]
				protected internal abstract int EngineGenerateSecret(sbyte[] sByte, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "([BI)I", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract int EngineGenerateSecret(byte[] @byte, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Crypto.ISecretKey EngineGenerateSecret(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/Sec" +
    "ureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/crypto/KeyGenerator
		/// </java-name>
		[Dot42.DexImport("javax/crypto/KeyGenerator", AccessFlags = 33)]
		public partial class KeyGenerator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/crypto/KeyGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyGenerator(global::Javax.Crypto.KeyGeneratorSpi keyGeneratorSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyGenerator;", AccessFlags = 25)]
				public static global::Javax.Crypto.KeyGenerator GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.KeyGenerator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/KeyGenerator;", AccessFlags = 25)]
				public static global::Javax.Crypto.KeyGenerator GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.KeyGenerator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/KeyGenerator;", AccessFlags = 25)]
				public static global::Javax.Crypto.KeyGenerator GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.KeyGenerator);
				}

				/// <java-name>
				/// generateKey
				/// </java-name>
				[Dot42.DexImport("generateKey", "()Ljavax/crypto/SecretKey;", AccessFlags = 17)]
				public global::Javax.Crypto.ISecretKey GenerateKey() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ISecretKey);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(I)V", AccessFlags = 17)]
				public void Init(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyGenerator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

		}

		/// <java-name>
		/// javax/crypto/KeyGeneratorSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/KeyGeneratorSpi", AccessFlags = 1057)]
		public abstract partial class KeyGeneratorSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyGeneratorSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGenerateKey
				/// </java-name>
				[Dot42.DexImport("engineGenerateKey", "()Ljavax/crypto/SecretKey;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Crypto.ISecretKey EngineGenerateKey() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int int32, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/crypto/Mac
		/// </java-name>
		[Dot42.DexImport("javax/crypto/Mac", AccessFlags = 33)]
		public partial class Mac : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/crypto/MacSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Mac(global::Javax.Crypto.MacSpi macSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/Mac;", AccessFlags = 25)]
				public static global::Javax.Crypto.Mac GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.Mac);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/Mac;", AccessFlags = 25)]
				public static global::Javax.Crypto.Mac GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.Mac);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/Mac;", AccessFlags = 25)]
				public static global::Javax.Crypto.Mac GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.Mac);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 17)]
				public void Update(sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 17)]
				public void Update(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 17)]
				public void Update(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 17)]
				public void Update(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "()[B", AccessFlags = 17)]
				public sbyte[] JavaDoFinal() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BI)V", AccessFlags = 17)]
				public void DoFinal(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BI)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void DoFinal(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([B)[B", AccessFlags = 17)]
				public sbyte[] DoFinal(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([B)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 17)]
				public void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Mac() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <java-name>
				/// getMacLength
				/// </java-name>
				public int MacLength
				{
						[Dot42.DexImport("getMacLength", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// javax/crypto/MacSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/MacSpi", AccessFlags = 1057)]
		public abstract partial class MacSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MacSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGetMacLength
				/// </java-name>
				[Dot42.DexImport("engineGetMacLength", "()I", AccessFlags = 1028)]
				protected internal abstract int EngineGetMacLength() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 4)]
				protected internal virtual void EngineUpdate(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineDoFinal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineDoFinal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineReset
				/// </java-name>
				[Dot42.DexImport("engineReset", "()V", AccessFlags = 1028)]
				protected internal abstract void EngineReset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <java-name>
		/// javax/crypto/NoSuchPaddingException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/NoSuchPaddingException", AccessFlags = 33)]
		public partial class NoSuchPaddingException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchPaddingException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchPaddingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/crypto/NullCipher
		/// </java-name>
		[Dot42.DexImport("javax/crypto/NullCipher", AccessFlags = 33)]
		public partial class NullCipher : global::Javax.Crypto.Cipher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NullCipher() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/crypto/SealedObject
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SealedObject", AccessFlags = 33)]
		public partial class SealedObject : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// encodedParams
				/// </java-name>
				[Dot42.DexImport("encodedParams", "[B", AccessFlags = 4)]
				protected internal sbyte[] EncodedParams;
				[Dot42.DexImport("<init>", "(Ljava/io/Serializable;Ljavax/crypto/Cipher;)V", AccessFlags = 1)]
				public SealedObject(global::Java.Io.ISerializable serializable, global::Javax.Crypto.Cipher cipher) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljavax/crypto/SealedObject;)V", AccessFlags = 4)]
				protected internal SealedObject(global::Javax.Crypto.SealedObject sealedObject) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/security/Key;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetObject(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljavax/crypto/Cipher;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetObject(global::Javax.Crypto.Cipher cipher) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/security/Key;Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetObject(global::Java.Security.IKey key, string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SealedObject() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// javax/crypto/SecretKeyFactory
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SecretKeyFactory", AccessFlags = 33)]
		public partial class SecretKeyFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/crypto/SecretKeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal SecretKeyFactory(global::Javax.Crypto.SecretKeyFactorySpi secretKeyFactorySpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;", AccessFlags = 25)]
				public static global::Javax.Crypto.SecretKeyFactory GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.SecretKeyFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;", AccessFlags = 25)]
				public static global::Javax.Crypto.SecretKeyFactory GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.SecretKeyFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljavax/crypto/SecretKeyFactory;", AccessFlags = 25)]
				public static global::Javax.Crypto.SecretKeyFactory GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.SecretKeyFactory);
				}

				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", AccessFlags = 17)]
				public global::Javax.Crypto.ISecretKey GenerateSecret(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ISecretKey);
				}

				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", AccessFlags = 17)]
				public global::Java.Security.Spec.IKeySpec GetKeySpec(global::Javax.Crypto.ISecretKey secretKey, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IKeySpec);
				}

				/// <java-name>
				/// translateKey
				/// </java-name>
				[Dot42.DexImport("translateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", AccessFlags = 17)]
				public global::Javax.Crypto.ISecretKey TranslateKey(global::Javax.Crypto.ISecretKey secretKey) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ISecretKey);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SecretKeyFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

		}

		/// <java-name>
		/// javax/crypto/SecretKeyFactorySpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SecretKeyFactorySpi", AccessFlags = 1057)]
		public abstract partial class SecretKeyFactorySpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecretKeyFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Crypto.ISecretKey EngineGenerateSecret(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetKeySpec
				/// </java-name>
				[Dot42.DexImport("engineGetKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.Spec.IKeySpec EngineGetKeySpec(global::Javax.Crypto.ISecretKey secretKey, global::System.Type type) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineTranslateKey
				/// </java-name>
				[Dot42.DexImport("engineTranslateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Crypto.ISecretKey EngineTranslateKey(global::Javax.Crypto.ISecretKey secretKey) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// javax/crypto/ShortBufferException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/ShortBufferException", AccessFlags = 33)]
		public partial class ShortBufferException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ShortBufferException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ShortBufferException() /* MethodBuilder.Create */ 
				{
				}

		}

}

