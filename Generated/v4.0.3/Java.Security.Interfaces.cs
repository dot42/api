#pragma warning disable 1717
namespace Java.Security.Interfaces
{
		/// <java-name>
		/// java/security/interfaces/DSAKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAKey", AccessFlags = 1537)]
		public partial interface IDSAKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getParams
				/// </java-name>
				global::Java.Security.Interfaces.IDSAParams Params
				{
						[Dot42.DexImport("getParams", "()Ljava/security/interfaces/DSAParams;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/DSAKeyPairGenerator
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAKeyPairGenerator", AccessFlags = 1537)]
		public partial interface IDSAKeyPairGenerator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Ljava/security/interfaces/DSAParams;Ljava/security/SecureRandom;)V", AccessFlags = 1025)]
				void Initialize(global::Java.Security.Interfaces.IDSAParams dSAParams, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IZLjava/security/SecureRandom;)V", AccessFlags = 1025)]
				void Initialize(int int32, bool boolean, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/interfaces/DSAParams
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAParams", AccessFlags = 1537)]
		public partial interface IDSAParams
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getG
				/// </java-name>
				global::Java.Math.BigInteger G
				{
						[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getP
				/// </java-name>
				global::Java.Math.BigInteger P
				{
						[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getQ
				/// </java-name>
				global::Java.Math.BigInteger Q
				{
						[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/DSAPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAPrivateKey", AccessFlags = 1537)]
		public partial interface IDSAPrivateKey : global::Java.Security.Interfaces.IDSAKey, global::Java.Security.IPrivateKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getX
				/// </java-name>
				global::Java.Math.BigInteger X
				{
						[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/DSAPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAPrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDSAPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 7776497482533790279;
		}

		/// <java-name>
		/// java/security/interfaces/DSAPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAPublicKey", AccessFlags = 1537)]
		public partial interface IDSAPublicKey : global::Java.Security.Interfaces.IDSAKey, global::Java.Security.IPublicKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getY
				/// </java-name>
				global::Java.Math.BigInteger Y
				{
						[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/DSAPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAPublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDSAPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 1234526332779022332;
		}

		/// <java-name>
		/// java/security/interfaces/ECKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECKey", AccessFlags = 1537)]
		public partial interface IECKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getParams
				/// </java-name>
				global::Java.Security.Spec.ECParameterSpec Params
				{
						[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/ECPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECPrivateKey", AccessFlags = 1537)]
		public partial interface IECPrivateKey : global::Java.Security.IPrivateKey, global::Java.Security.Interfaces.IECKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getS
				/// </java-name>
				global::Java.Math.BigInteger S
				{
						[Dot42.DexImport("getS", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/ECPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECPrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IECPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -7896394956925609184;
		}

		/// <java-name>
		/// java/security/interfaces/ECPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECPublicKey", AccessFlags = 1537)]
		public partial interface IECPublicKey : global::Java.Security.IPublicKey, global::Java.Security.Interfaces.IECKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getW
				/// </java-name>
				global::Java.Security.Spec.ECPoint W
				{
						[Dot42.DexImport("getW", "()Ljava/security/spec/ECPoint;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/ECPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECPublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IECPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -3314988629879632826;
		}

		/// <java-name>
		/// java/security/interfaces/RSAKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAKey", AccessFlags = 1537)]
		public partial interface IRSAKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getModulus
				/// </java-name>
				global::Java.Math.BigInteger Modulus
				{
						[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/RSAMultiPrimePrivateCrtKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAMultiPrimePrivateCrtKey", AccessFlags = 1537)]
		public partial interface IRSAMultiPrimePrivateCrtKey : global::Java.Security.Interfaces.IRSAPrivateKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				global::Java.Math.BigInteger CrtCoefficient
				{
						[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getOtherPrimeInfo
				/// </java-name>
				global::Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo
				{
						[Dot42.DexImport("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrimeP
				/// </java-name>
				global::Java.Math.BigInteger PrimeP
				{
						[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				global::Java.Math.BigInteger PrimeQ
				{
						[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				global::Java.Math.BigInteger PrimeExponentP
				{
						[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				global::Java.Math.BigInteger PrimeExponentQ
				{
						[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				global::Java.Math.BigInteger PublicExponent
				{
						[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/RSAMultiPrimePrivateCrtKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAMultiPrimePrivateCrtKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IRSAMultiPrimePrivateCrtKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 618058533534628008;
		}

		/// <java-name>
		/// java/security/interfaces/RSAPrivateCrtKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPrivateCrtKey", AccessFlags = 1537)]
		public partial interface IRSAPrivateCrtKey : global::Java.Security.Interfaces.IRSAPrivateKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				global::Java.Math.BigInteger CrtCoefficient
				{
						[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrimeP
				/// </java-name>
				global::Java.Math.BigInteger PrimeP
				{
						[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				global::Java.Math.BigInteger PrimeQ
				{
						[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				global::Java.Math.BigInteger PrimeExponentP
				{
						[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				global::Java.Math.BigInteger PrimeExponentQ
				{
						[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				global::Java.Math.BigInteger PublicExponent
				{
						[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/RSAPrivateCrtKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPrivateCrtKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IRSAPrivateCrtKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -5682214253527700368;
		}

		/// <java-name>
		/// java/security/interfaces/RSAPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPrivateKey", AccessFlags = 1537)]
		public partial interface IRSAPrivateKey : global::Java.Security.IPrivateKey, global::Java.Security.Interfaces.IRSAKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPrivateExponent
				/// </java-name>
				global::Java.Math.BigInteger PrivateExponent
				{
						[Dot42.DexImport("getPrivateExponent", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/RSAPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IRSAPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 5187144804936595022;
		}

		/// <java-name>
		/// java/security/interfaces/RSAPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPublicKey", AccessFlags = 1537)]
		public partial interface IRSAPublicKey : global::Java.Security.IPublicKey, global::Java.Security.Interfaces.IRSAKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				global::Java.Math.BigInteger PublicExponent
				{
						[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/interfaces/RSAPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IRSAPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -8727434096241101194;
		}

}

