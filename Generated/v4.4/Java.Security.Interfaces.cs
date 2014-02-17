// Copyright (C) 2014 dot42
//
// Original filename: Java.Security.Interfaces.cs
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
namespace Java.Security.Interfaces
{
		/// <summary>
		/// <para>The interface for an Elliptic Curve (EC) private key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/ECPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECPrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IECPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -7896394956925609184;
		}

		/// <summary>
		/// <para>The interface for an Elliptic Curve (EC) private key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/ECPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECPrivateKey", AccessFlags = 1537)]
		public partial interface IECPrivateKey : global::Java.Security.IPrivateKey, global::Java.Security.Interfaces.IECKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the private value <c> S </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private value <c> S </c> . </para>
				/// </returns>
				/// <java-name>
				/// getS
				/// </java-name>
				[Dot42.DexImport("getS", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetS() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The base interface for Elliptic Curve (EC) public or private keys. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/ECKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECKey", AccessFlags = 1537)]
		public partial interface IECKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the EC key parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the EC key parameters. </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Ljava/security/spec/ECParameterSpec;", AccessFlags = 1025)]
				global::Java.Security.Spec.ECParameterSpec GetParams() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for a PKCS#1 RSA private key using CRT information values. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAPrivateCrtKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPrivateCrtKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IRSAPrivateCrtKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -5682214253527700368;
		}

		/// <summary>
		/// <para>The interface for a PKCS#1 RSA private key using CRT information values. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAPrivateCrtKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPrivateCrtKey", AccessFlags = 1537)]
		public partial interface IRSAPrivateCrtKey : global::Java.Security.Interfaces.IRSAPrivateKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the CRT coefficient, <c> q^-1 mod p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT coefficient. </para>
				/// </returns>
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetCrtCoefficient() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the prime factor <c> p </c> of <c> n </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> p </c> of <c> n </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeP
				/// </java-name>
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrimeP() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the prime factor <c> q </c> of <c> n </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> q </c> of <c> n </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrimeQ() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the CRT exponent of the primet <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT exponent of the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrimeExponentP() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the CRT exponent of the prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT exponent of the prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrimeExponentQ() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the public exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPublicExponent() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for Digital Signature Algorithm (DSA) specific parameters. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/DSAParams
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAParams", AccessFlags = 1537)]
		public partial interface IDSAParams
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the base (<c> g </c> ) value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base (<c> g </c> ) value. </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the prime (<c> p </c> ) value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime (<c> p </c> ) value. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the subprime (<c> q </c> value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the subprime (<c> q </c> value. </para>
				/// </returns>
				/// <java-name>
				/// getQ
				/// </java-name>
				[Dot42.DexImport("getQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetQ() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The base interface for PKCS#1 RSA public and private keys. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAKey", AccessFlags = 1537)]
		public partial interface IRSAKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the modulus.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the modulus. </para>
				/// </returns>
				/// <java-name>
				/// getModulus
				/// </java-name>
				[Dot42.DexImport("getModulus", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetModulus() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for a PKCS#1 RSA public key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IRSAPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -8727434096241101194;
		}

		/// <summary>
		/// <para>The interface for a PKCS#1 RSA public key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPublicKey", AccessFlags = 1537)]
		public partial interface IRSAPublicKey : global::Java.Security.IPublicKey, global::Java.Security.Interfaces.IRSAKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the public exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPublicExponent() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for key generators that can generate DSA key pairs. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/DSAKeyPairGenerator
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAKeyPairGenerator", AccessFlags = 1537)]
		public partial interface IDSAKeyPairGenerator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Initializes this generator with the prime (<c> p </c> ), subprime (<c>       q </c> ), and base (<c> g </c> ) values from the specified parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Ljava/security/interfaces/DSAParams;Ljava/security/SecureRandom;)V", AccessFlags = 1025)]
				void Initialize(global::Java.Security.Interfaces.IDSAParams @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this generator for the specified modulus length. Valid values for the modulus length are the multiples of 8 between 512 and 1024. </para><para>The parameter <c> genParams </c> specifies whether this method should generate new prime (<c> p </c> ), subprime (<c> q </c> ), and base (<c> g </c> ) values or whether it will use the pre-calculated values for the specified modulus length. Default parameters are available for modulus lengths of 512 and 1024 bits.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IZLjava/security/SecureRandom;)V", AccessFlags = 1025)]
				void Initialize(int modlen, bool genParams, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for a Digital Signature Algorithm (DSA) private key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/DSAPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAPrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDSAPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 7776497482533790279;
		}

		/// <summary>
		/// <para>The interface for a Digital Signature Algorithm (DSA) private key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/DSAPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAPrivateKey", AccessFlags = 1537)]
		public partial interface IDSAPrivateKey : global::Java.Security.Interfaces.IDSAKey, global::Java.Security.IPrivateKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the private key value <c> x </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private key value <c> x </c> . </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetX() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The base interface for Digital Signature Algorithm (DSA) public or private keys. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/DSAKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAKey", AccessFlags = 1537)]
		public partial interface IDSAKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the DSA key parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the DSA key parameters. </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Ljava/security/interfaces/DSAParams;", AccessFlags = 1025)]
				global::Java.Security.Interfaces.IDSAParams GetParams() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for a Multi-Prime RSA private key. Specified by . </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAMultiPrimePrivateCrtKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAMultiPrimePrivateCrtKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IRSAMultiPrimePrivateCrtKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>the serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 618058533534628008;
		}

		/// <summary>
		/// <para>The interface for a Multi-Prime RSA private key. Specified by . </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAMultiPrimePrivateCrtKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAMultiPrimePrivateCrtKey", AccessFlags = 1537)]
		public partial interface IRSAMultiPrimePrivateCrtKey : global::Java.Security.Interfaces.IRSAPrivateKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the CRT coefficient, <c> q^-1 mod p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT coefficient. </para>
				/// </returns>
				/// <java-name>
				/// getCrtCoefficient
				/// </java-name>
				[Dot42.DexImport("getCrtCoefficient", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetCrtCoefficient() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the information for the additional primes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the information for the additional primes, or <c> null </c> if there are only the two primes (<c> p, q </c> ), </para>
				/// </returns>
				/// <java-name>
				/// getOtherPrimeInfo
				/// </java-name>
				[Dot42.DexImport("getOtherPrimeInfo", "()[Ljava/security/spec/RSAOtherPrimeInfo;", AccessFlags = 1025)]
				global::Java.Security.Spec.RSAOtherPrimeInfo[] GetOtherPrimeInfo() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the prime factor <c> p </c> of <c> n </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> p </c> of <c> n </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeP
				/// </java-name>
				[Dot42.DexImport("getPrimeP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrimeP() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the prime factor <c> q </c> of <c> n </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime factor <c> q </c> of <c> n </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeQ
				/// </java-name>
				[Dot42.DexImport("getPrimeQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrimeQ() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the CRT exponent of the prime <c> p </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT exponent of the prime <c> p </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentP
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentP", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrimeExponentP() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the CRT exponent of the prime <c> q </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the CRT exponent of the prime <c> q </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrimeExponentQ
				/// </java-name>
				[Dot42.DexImport("getPrimeExponentQ", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrimeExponentQ() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the public exponent <c> e </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public exponent <c> e </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicExponent
				/// </java-name>
				[Dot42.DexImport("getPublicExponent", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPublicExponent() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for a Digital Signature Algorithm (DSA) public key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/DSAPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAPublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDSAPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 1234526332779022332;
		}

		/// <summary>
		/// <para>The interface for a Digital Signature Algorithm (DSA) public key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/DSAPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/DSAPublicKey", AccessFlags = 1537)]
		public partial interface IDSAPublicKey : global::Java.Security.Interfaces.IDSAKey, global::Java.Security.IPublicKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the public key value <c> y </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public key value <c> y </c> . </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetY() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for an Elliptic Curve (EC) public key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/ECPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECPublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IECPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -3314988629879632826;
		}

		/// <summary>
		/// <para>The interface for an Elliptic Curve (EC) public key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/ECPublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/ECPublicKey", AccessFlags = 1537)]
		public partial interface IECPublicKey : global::Java.Security.IPublicKey, global::Java.Security.Interfaces.IECKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the public point <c> W </c> on an elliptic curve (EC).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public point <c> W </c> on an elliptic curve (EC). </para>
				/// </returns>
				/// <java-name>
				/// getW
				/// </java-name>
				[Dot42.DexImport("getW", "()Ljava/security/spec/ECPoint;", AccessFlags = 1025)]
				global::Java.Security.Spec.ECPoint GetW() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for an PKCS#1 RSA private key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IRSAPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 5187144804936595022;
		}

		/// <summary>
		/// <para>The interface for an PKCS#1 RSA private key. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/interfaces/RSAPrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/interfaces/RSAPrivateKey", AccessFlags = 1537)]
		public partial interface IRSAPrivateKey : global::Java.Security.IPrivateKey, global::Java.Security.Interfaces.IRSAKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the private exponent <c> d </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private exponent <c> d </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrivateExponent
				/// </java-name>
				[Dot42.DexImport("getPrivateExponent", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetPrivateExponent() /* MethodBuilder.Create */ ;

		}

}


