#pragma warning disable 1717
namespace Javax.Crypto.Spec
{
		/// <java-name>
		/// javax/crypto/spec/DESedeKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DESedeKeySpec", AccessFlags = 33)]
		public partial class DESedeKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DES_EDE_KEY_LEN
				/// </java-name>
				[Dot42.DexImport("DES_EDE_KEY_LEN", "I", AccessFlags = 25)]
				public const int DES_EDE_KEY_LEN = 24;
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public DESedeKeySpec(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DESedeKeySpec(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public DESedeKeySpec(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DESedeKeySpec(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetKey() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// isParityAdjusted
				/// </java-name>
				[Dot42.DexImport("isParityAdjusted", "([BI)Z", AccessFlags = 9)]
				public static bool IsParityAdjusted(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isParityAdjusted
				/// </java-name>
				[Dot42.DexImport("isParityAdjusted", "([BI)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool IsParityAdjusted(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DESedeKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				public virtual byte[] Key
				{
						[Dot42.DexImport("getKey", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/DESKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DESKeySpec", AccessFlags = 33)]
		public partial class DESKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DES_KEY_LEN
				/// </java-name>
				[Dot42.DexImport("DES_KEY_LEN", "I", AccessFlags = 25)]
				public const int DES_KEY_LEN = 8;
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public DESKeySpec(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DESKeySpec(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public DESKeySpec(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DESKeySpec(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetKey() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// isParityAdjusted
				/// </java-name>
				[Dot42.DexImport("isParityAdjusted", "([BI)Z", AccessFlags = 9)]
				public static bool IsParityAdjusted(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isParityAdjusted
				/// </java-name>
				[Dot42.DexImport("isParityAdjusted", "([BI)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool IsParityAdjusted(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isWeak
				/// </java-name>
				[Dot42.DexImport("isWeak", "([BI)Z", AccessFlags = 9)]
				public static bool IsWeak(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isWeak
				/// </java-name>
				[Dot42.DexImport("isWeak", "([BI)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool IsWeak(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DESKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				public virtual byte[] Key
				{
						[Dot42.DexImport("getKey", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/DHGenParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DHGenParameterSpec", AccessFlags = 33)]
		public partial class DHGenParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public DHGenParameterSpec(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DHGenParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPrimeSize
				/// </java-name>
				public virtual int PrimeSize
				{
						[Dot42.DexImport("getPrimeSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getExponentSize
				/// </java-name>
				public virtual int ExponentSize
				{
						[Dot42.DexImport("getExponentSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/DHParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DHParameterSpec", AccessFlags = 33)]
		public partial class DHParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public DHParameterSpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;I)V", AccessFlags = 1)]
				public DHParameterSpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DHParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getP
				/// </java-name>
				public virtual global::Java.Math.BigInteger P
				{
						[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <java-name>
				/// getG
				/// </java-name>
				public virtual global::Java.Math.BigInteger G
				{
						[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <java-name>
				/// getL
				/// </java-name>
				public virtual int L
				{
						[Dot42.DexImport("getL", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/DHPrivateKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DHPrivateKeySpec", AccessFlags = 33)]
		public partial class DHPrivateKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public DHPrivateKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DHPrivateKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getX
				/// </java-name>
				public virtual global::Java.Math.BigInteger X
				{
						[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <java-name>
				/// getP
				/// </java-name>
				public virtual global::Java.Math.BigInteger P
				{
						[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <java-name>
				/// getG
				/// </java-name>
				public virtual global::Java.Math.BigInteger G
				{
						[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/DHPublicKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DHPublicKeySpec", AccessFlags = 33)]
		public partial class DHPublicKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public DHPublicKeySpec(global::Java.Math.BigInteger bigInteger, global::Java.Math.BigInteger bigInteger1, global::Java.Math.BigInteger bigInteger2) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DHPublicKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getY
				/// </java-name>
				public virtual global::Java.Math.BigInteger Y
				{
						[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <java-name>
				/// getP
				/// </java-name>
				public virtual global::Java.Math.BigInteger P
				{
						[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <java-name>
				/// getG
				/// </java-name>
				public virtual global::Java.Math.BigInteger G
				{
						[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/IvParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/IvParameterSpec", AccessFlags = 33)]
		public partial class IvParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public IvParameterSpec(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public IvParameterSpec(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1)]
				public IvParameterSpec(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public IvParameterSpec(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetIV() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IvParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getIV
				/// </java-name>
				public virtual byte[] IV
				{
						[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/OAEPParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/OAEPParameterSpec", AccessFlags = 33)]
		public partial class OAEPParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Ljavax/crypto/spec/OAEPParameterSpec;", AccessFlags = 25)]
				public static readonly global::Javax.Crypto.Spec.OAEPParameterSpec DEFAULT;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;L" +
    "javax/crypto/spec/PSource;)V", AccessFlags = 1)]
				public OAEPParameterSpec(string @string, string string1, global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Javax.Crypto.Spec.PSource pSource) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal OAEPParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				public virtual string DigestAlgorithm
				{
						[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getMGFAlgorithm
				/// </java-name>
				public virtual string MGFAlgorithm
				{
						[Dot42.DexImport("getMGFAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getMGFParameters
				/// </java-name>
				public virtual global::Java.Security.Spec.IAlgorithmParameterSpec MGFParameters
				{
						[Dot42.DexImport("getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Spec.IAlgorithmParameterSpec); }
				}

				/// <java-name>
				/// getPSource
				/// </java-name>
				public virtual global::Javax.Crypto.Spec.PSource PSource
				{
						[Dot42.DexImport("getPSource", "()Ljavax/crypto/spec/PSource;", AccessFlags = 1)]
						get{ return default(global::Javax.Crypto.Spec.PSource); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/PBEKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/PBEKeySpec", AccessFlags = 33)]
		public partial class PBEKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public PBEKeySpec(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([C[BII)V", AccessFlags = 1)]
				public PBEKeySpec(char[] @char, sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([C[BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PBEKeySpec(char[] @char, byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([C[BI)V", AccessFlags = 1)]
				public PBEKeySpec(char[] @char, sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([C[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PBEKeySpec(char[] @char, byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearPassword
				/// </java-name>
				[Dot42.DexImport("clearPassword", "()V", AccessFlags = 17)]
				public void ClearPassword() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSalt
				/// </java-name>
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetSalt() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PBEKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				public char[] Password
				{
						[Dot42.DexImport("getPassword", "()[C", AccessFlags = 17)]
						get{ return default(char[]); }
				}

				/// <java-name>
				/// getSalt
				/// </java-name>
				public byte[] Salt
				{
						[Dot42.DexImport("getSalt", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getIterationCount
				/// </java-name>
				public int IterationCount
				{
						[Dot42.DexImport("getIterationCount", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getKeyLength
				/// </java-name>
				public int KeyLength
				{
						[Dot42.DexImport("getKeyLength", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/PBEParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/PBEParameterSpec", AccessFlags = 33)]
		public partial class PBEParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public PBEParameterSpec(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PBEParameterSpec(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSalt
				/// </java-name>
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetSalt() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PBEParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSalt
				/// </java-name>
				public virtual byte[] Salt
				{
						[Dot42.DexImport("getSalt", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getIterationCount
				/// </java-name>
				public virtual int IterationCount
				{
						[Dot42.DexImport("getIterationCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/PSource
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/PSource", AccessFlags = 33)]
		public partial class PSource
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal PSource(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PSource() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public virtual string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// javax/crypto/spec/PSource$PSpecified
				/// </java-name>
				[Dot42.DexImport("javax/crypto/spec/PSource$PSpecified", AccessFlags = 25)]
				public sealed partial class PSpecified : global::Javax.Crypto.Spec.PSource
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// DEFAULT
						/// </java-name>
						[Dot42.DexImport("DEFAULT", "Ljavax/crypto/spec/PSource$PSpecified;", AccessFlags = 25)]
						public static readonly PSpecified DEFAULT;
						[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
						public PSpecified(sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						public PSpecified(byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getValue
						/// </java-name>
						[Dot42.DexImport("getValue", "()[B", AccessFlags = 1)]
						public sbyte[] JavaGetValue() /* MethodBuilder.Create */ 
						{
								return default(sbyte[]);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal PSpecified() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getValue
						/// </java-name>
						public byte[] Value
						{
								[Dot42.DexImport("getValue", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
								get{ return default(byte[]); }
						}

				}

		}

		/// <java-name>
		/// javax/crypto/spec/RC2ParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/RC2ParameterSpec", AccessFlags = 33)]
		public partial class RC2ParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public RC2ParameterSpec(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1)]
				public RC2ParameterSpec(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public RC2ParameterSpec(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[BI)V", AccessFlags = 1)]
				public RC2ParameterSpec(int int32, sbyte[] sByte, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public RC2ParameterSpec(int int32, byte[] @byte, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetIV() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RC2ParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEffectiveKeyBits
				/// </java-name>
				public virtual int EffectiveKeyBits
				{
						[Dot42.DexImport("getEffectiveKeyBits", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getIV
				/// </java-name>
				public virtual byte[] IV
				{
						[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/RC5ParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/RC5ParameterSpec", AccessFlags = 33)]
		public partial class RC5ParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public RC5ParameterSpec(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(III[B)V", AccessFlags = 1)]
				public RC5ParameterSpec(int int32, int int321, int int322, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(III[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public RC5ParameterSpec(int int32, int int321, int int322, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(III[BI)V", AccessFlags = 1)]
				public RC5ParameterSpec(int int32, int int321, int int322, sbyte[] sByte, int int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(III[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public RC5ParameterSpec(int int32, int int321, int int322, byte[] @byte, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetIV() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RC5ParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public virtual int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRounds
				/// </java-name>
				public virtual int Rounds
				{
						[Dot42.DexImport("getRounds", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getWordSize
				/// </java-name>
				public virtual int WordSize
				{
						[Dot42.DexImport("getWordSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getIV
				/// </java-name>
				public virtual byte[] IV
				{
						[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <java-name>
		/// javax/crypto/spec/SecretKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/SecretKeySpec", AccessFlags = 33)]
		public partial class SecretKeySpec : global::Javax.Crypto.ISecretKey, global::Java.Security.Spec.IKeySpec, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([BLjava/lang/String;)V", AccessFlags = 1)]
				public SecretKeySpec(sbyte[] sByte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BLjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public SecretKeySpec(byte[] @byte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/lang/String;)V", AccessFlags = 1)]
				public SecretKeySpec(sbyte[] sByte, int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public SecretKeySpec(byte[] @byte, int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SecretKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public virtual string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getFormat
				/// </java-name>
				public virtual string Format
				{
						[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
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

}

