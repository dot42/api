// Copyright (C) 2014 dot42
//
// Original filename: Javax.Crypto.Spec.cs
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
namespace Javax.Crypto.Spec
{
		/// <summary>
		/// <para>The algorithm parameter specification for a <b>password based encryption</b> algorithm. </para><para>Password based encryption is described in . </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/PBEParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/PBEParameterSpec", AccessFlags = 33)]
		public partial class PBEParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>PBEParameterSpec</code> with the specified salt and iteration count.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public PBEParameterSpec(sbyte[] salt, int iterationCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>PBEParameterSpec</code> with the specified salt and iteration count.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PBEParameterSpec(byte[] salt, int iterationCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy to the salt.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy to the salt. </para>
				/// </returns>
				/// <java-name>
				/// getSalt
				/// </java-name>
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetSalt() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy to the salt.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy to the salt. </para>
				/// </returns>
				/// <java-name>
				/// getSalt
				/// </java-name>
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetSalt() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the iteration count.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the iteration count. </para>
				/// </returns>
				/// <java-name>
				/// getIterationCount
				/// </java-name>
				[Dot42.DexImport("getIterationCount", "()I", AccessFlags = 1)]
				public virtual int GetIterationCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PBEParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy to the salt.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy to the salt. </para>
				/// </returns>
				/// <java-name>
				/// getSalt
				/// </java-name>
				public byte[] Salt
				{
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetSalt(); }
				}

				/// <summary>
				/// <para>Returns the iteration count.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the iteration count. </para>
				/// </returns>
				/// <java-name>
				/// getIterationCount
				/// </java-name>
				public int IterationCount
				{
				[Dot42.DexImport("getIterationCount", "()I", AccessFlags = 1)]
						get{ return GetIterationCount(); }
				}

		}

		/// <summary>
		/// <para>The algorithm parameter specification for generating Diffie-Hellman parameters used in Diffie-Hellman key agreement. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/DHGenParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DHGenParameterSpec", AccessFlags = 33)]
		public partial class DHGenParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>DHGenParameterSpec</code> instance with the specified parameters.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public DHGenParameterSpec(int primeSize, int exponentSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the size of the <b>prime modulus</b> in bits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the prime modulus in bits. </para>
				/// </returns>
				/// <java-name>
				/// getPrimeSize
				/// </java-name>
				[Dot42.DexImport("getPrimeSize", "()I", AccessFlags = 1)]
				public virtual int GetPrimeSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the size of the <b>random exponent</b> in bits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the random exponent in bits. </para>
				/// </returns>
				/// <java-name>
				/// getExponentSize
				/// </java-name>
				[Dot42.DexImport("getExponentSize", "()I", AccessFlags = 1)]
				public virtual int GetExponentSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DHGenParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the size of the <b>prime modulus</b> in bits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the prime modulus in bits. </para>
				/// </returns>
				/// <java-name>
				/// getPrimeSize
				/// </java-name>
				public int PrimeSize
				{
				[Dot42.DexImport("getPrimeSize", "()I", AccessFlags = 1)]
						get{ return GetPrimeSize(); }
				}

				/// <summary>
				/// <para>Returns the size of the <b>random exponent</b> in bits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of the random exponent in bits. </para>
				/// </returns>
				/// <java-name>
				/// getExponentSize
				/// </java-name>
				public int ExponentSize
				{
				[Dot42.DexImport("getExponentSize", "()I", AccessFlags = 1)]
						get{ return GetExponentSize(); }
				}

		}

		/// <summary>
		/// <para>The key specification for a Diffie-Hellman public key. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/DHPublicKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DHPublicKeySpec", AccessFlags = 33)]
		public partial class DHPublicKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>DHPublicKeySpec</code> instance with the specified <b>public value</b> <code>y</code>, the <b>prime modulus</b> <code>p</code> and the <b>base generator</b> <code>g</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public DHPublicKeySpec(global::Java.Math.BigInteger y, global::Java.Math.BigInteger p, global::Java.Math.BigInteger g) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <b>public value</b> <code>y</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public value <code>y</code>. </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetY() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the <b>prime modulus</b> <code>p</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime modulus <code>p</code>. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the <b>base generator</b> <code>g</code>;</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base generator <code>g</code>; </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DHPublicKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <b>public value</b> <code>y</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public value <code>y</code>. </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				public global::Java.Math.BigInteger Y
				{
				[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetY(); }
				}

				/// <summary>
				/// <para>Returns the <b>prime modulus</b> <code>p</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime modulus <code>p</code>. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <summary>
				/// <para>Returns the <b>base generator</b> <code>g</code>;</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base generator <code>g</code>; </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

		}

		/// <summary>
		/// <para>The key specification for a DES key. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/DESKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DESKeySpec", AccessFlags = 33)]
		public partial class DESKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The length of a DES key in bytes. </para>        
				/// </summary>
				/// <java-name>
				/// DES_KEY_LEN
				/// </java-name>
				[Dot42.DexImport("DES_KEY_LEN", "I", AccessFlags = 25)]
				public const int DES_KEY_LEN = 8;
				/// <summary>
				/// <para>Creates a new <code>DESKeySpec</code> from the first 8 bytes of the specified key data.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public DESKeySpec(sbyte[] key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>DESKeySpec</code> from the first 8 bytes of the specified key data.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DESKeySpec(byte[] key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>DESKeySpec</code> from the first 8 bytes of the specified key data starting at <code>offset</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public DESKeySpec(sbyte[] key, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>DESKeySpec</code> from the first 8 bytes of the specified key data starting at <code>offset</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DESKeySpec(byte[] key, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetKey() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy of the key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetKey() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns whether the specified key data starting at <code>offset</code> is <b>parity-adjusted</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified key data is parity-adjusted, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isParityAdjusted
				/// </java-name>
				[Dot42.DexImport("isParityAdjusted", "([BI)Z", AccessFlags = 9)]
				public static bool IsParityAdjusted(sbyte[] key, int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the specified key data starting at <code>offset</code> is <b>parity-adjusted</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified key data is parity-adjusted, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isParityAdjusted
				/// </java-name>
				[Dot42.DexImport("isParityAdjusted", "([BI)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool IsParityAdjusted(byte[] key, int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the specified key data starting at <code>offset</code> is weak or semi-weak.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified key data is weak or semi-weak. </para>
				/// </returns>
				/// <java-name>
				/// isWeak
				/// </java-name>
				[Dot42.DexImport("isWeak", "([BI)Z", AccessFlags = 9)]
				public static bool IsWeak(sbyte[] key, int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the specified key data starting at <code>offset</code> is weak or semi-weak.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified key data is weak or semi-weak. </para>
				/// </returns>
				/// <java-name>
				/// isWeak
				/// </java-name>
				[Dot42.DexImport("isWeak", "([BI)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool IsWeak(byte[] key, int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DESKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				public byte[] Key
				{
				[Dot42.DexImport("getKey", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetKey(); }
				}

		}

		/// <summary>
		/// <para>The algorithm parameter specification for the <b>OAEP Padding</b> algorithm. </para><para>This padding algorithm is defined in the  standard. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/OAEPParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/OAEPParameterSpec", AccessFlags = 33)]
		public partial class OAEPParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The algorithm parameter instance with default values. </para><para>It uses the following parameters: <ul><li><para>message digest : <code>"SHA-1"</code> </para></li><li><para>mask generation function (<b>mgf</b>) : <code>"MGF1"</code> </para></li><li><para>parameters for the <b>mgf</b> : "SHA-1" MGF1ParameterSpec#SHA1 </para></li><li><para>the source of the label <code>L</code>: PSource.PSpecified#DEFAULT </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Ljavax/crypto/spec/OAEPParameterSpec;", AccessFlags = 25)]
				public static readonly global::Javax.Crypto.Spec.OAEPParameterSpec DEFAULT;
				/// <summary>
				/// <para>Creates a new <code>OAEPParameterSpec</code> instance with the specified <b>message digest</b> algorithm name, <b>mask generation function</b> (<b>mgf</b>) algorithm name, <b>parameters</b> for the <b>mgf</b> algorithm and the <b>source of the label <code>L</code></b>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;L" +
    "javax/crypto/spec/PSource;)V", AccessFlags = 1)]
				public OAEPParameterSpec(string mdName, string mgfName, global::Java.Security.Spec.IAlgorithmParameterSpec mgfSpec, global::Javax.Crypto.Spec.PSource pSrc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the algorithm name of the <b>message digest</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm name of the message digest. </para>
				/// </returns>
				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDigestAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the algorithm name of the <b>mask generation function</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm name of the mask generation function. </para>
				/// </returns>
				/// <java-name>
				/// getMGFAlgorithm
				/// </java-name>
				[Dot42.DexImport("getMGFAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMGFAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the algorithm parameter specification for the mask generation function algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm parameter specification for the mask generation function algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getMGFParameters
				/// </java-name>
				[Dot42.DexImport("getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.IAlgorithmParameterSpec GetMGFParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IAlgorithmParameterSpec);
				}

				/// <summary>
				/// <para>Returns the source of the label <code>L</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the source of the label <code>L</code>. </para>
				/// </returns>
				/// <java-name>
				/// getPSource
				/// </java-name>
				[Dot42.DexImport("getPSource", "()Ljavax/crypto/spec/PSource;", AccessFlags = 1)]
				public virtual global::Javax.Crypto.Spec.PSource GetPSource() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.Spec.PSource);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal OAEPParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the algorithm name of the <b>message digest</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm name of the message digest. </para>
				/// </returns>
				/// <java-name>
				/// getDigestAlgorithm
				/// </java-name>
				public string DigestAlgorithm
				{
				[Dot42.DexImport("getDigestAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDigestAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the algorithm name of the <b>mask generation function</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm name of the mask generation function. </para>
				/// </returns>
				/// <java-name>
				/// getMGFAlgorithm
				/// </java-name>
				public string MGFAlgorithm
				{
				[Dot42.DexImport("getMGFAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMGFAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the algorithm parameter specification for the mask generation function algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm parameter specification for the mask generation function algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getMGFParameters
				/// </java-name>
				public global::Java.Security.Spec.IAlgorithmParameterSpec MGFParameters
				{
				[Dot42.DexImport("getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1)]
						get{ return GetMGFParameters(); }
				}

				/// <summary>
				/// <para>Returns the source of the label <code>L</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the source of the label <code>L</code>. </para>
				/// </returns>
				/// <java-name>
				/// getPSource
				/// </java-name>
				public global::Javax.Crypto.Spec.PSource PSource
				{
				[Dot42.DexImport("getPSource", "()Ljavax/crypto/spec/PSource;", AccessFlags = 1)]
						get{ return GetPSource(); }
				}

		}

		/// <summary>
		/// <para>The key specification for a Diffie-Hellman private key. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/DHPrivateKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DHPrivateKeySpec", AccessFlags = 33)]
		public partial class DHPrivateKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>DHPrivateKeySpec</code> with the specified <b>private value</b> <code>x</code>. <b>prime modulus</b> <code>p</code> and <b>base generator</b> <code>g</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public DHPrivateKeySpec(global::Java.Math.BigInteger x, global::Java.Math.BigInteger p, global::Java.Math.BigInteger g) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <b>private value</b> <code>x</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private value <code>x</code>. </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetX() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the <b>prime modulus</b> <code>p</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime modulus <code>p</code>. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the <b>base generator</b> <code>g</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base generator <code>g</code>. </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DHPrivateKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <b>private value</b> <code>x</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private value <code>x</code>. </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				public global::Java.Math.BigInteger X
				{
				[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetX(); }
				}

				/// <summary>
				/// <para>Returns the <b>prime modulus</b> <code>p</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime modulus <code>p</code>. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <summary>
				/// <para>Returns the <b>base generator</b> <code>g</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base generator <code>g</code>. </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

		}

		/// <summary>
		/// <para>A key specification for a <code>SecretKey</code> and also a secret key implementation that is provider-independent. It can be used for raw secret keys that can be specified as <code>byte[]</code>. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/SecretKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/SecretKeySpec", AccessFlags = 33)]
		public partial class SecretKeySpec : global::Javax.Crypto.ISecretKey, global::Java.Security.Spec.IKeySpec, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>SecretKeySpec</code> for the specified key data and algorithm name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BLjava/lang/String;)V", AccessFlags = 1)]
				public SecretKeySpec(sbyte[] key, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>SecretKeySpec</code> for the specified key data and algorithm name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BLjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public SecretKeySpec(byte[] key, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>SecretKeySpec</code> for the key data from the specified buffer <code>key</code> starting at <code>offset</code> with length <code>len</code> and the specified <code>algorithm</code> name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIILjava/lang/String;)V", AccessFlags = 1)]
				public SecretKeySpec(sbyte[] key, int offset, int len, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>SecretKeySpec</code> for the key data from the specified buffer <code>key</code> starting at <code>offset</code> with length <code>len</code> and the specified <code>algorithm</code> name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BIILjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public SecretKeySpec(byte[] key, int offset, int len, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the algorithm name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the name of the format used to encode the key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the format name "RAW". </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFormat() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the encoded form of this secret key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded form of this secret key. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the encoded form of this secret key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded form of this secret key. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the hash code of this <code>SecretKeySpec</code> object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code. </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the specified object with this <code>SecretKeySpec</code> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the algorithm name and key of both object are equal, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SecretKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the algorithm name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the name of the format used to encode the key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the format name "RAW". </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				public string Format
				{
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFormat(); }
				}

				/// <summary>
				/// <para>Returns the encoded form of this secret key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded form of this secret key. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

		}

		/// <summary>
		/// <para>The key specification for a triple-DES (DES-EDE) key. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/DESedeKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DESedeKeySpec", AccessFlags = 33)]
		public partial class DESedeKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The length of a DES-EDE key in bytes. </para>        
				/// </summary>
				/// <java-name>
				/// DES_EDE_KEY_LEN
				/// </java-name>
				[Dot42.DexImport("DES_EDE_KEY_LEN", "I", AccessFlags = 25)]
				public const int DES_EDE_KEY_LEN = 24;
				/// <summary>
				/// <para>Creates a new <code>DESedeKeySpec</code> instance from the first 24 ( DES_EDE_KEY_LEN) bytes of the specified key data.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public DESedeKeySpec(sbyte[] key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>DESedeKeySpec</code> instance from the first 24 ( DES_EDE_KEY_LEN) bytes of the specified key data.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DESedeKeySpec(byte[] key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>DESedeKeySpec</code> instance from the first 24 ( DES_EDE_KEY_LEN ) bytes of the specified key data starting at <code>offset</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public DESedeKeySpec(sbyte[] key, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>DESedeKeySpec</code> instance from the first 24 ( DES_EDE_KEY_LEN ) bytes of the specified key data starting at <code>offset</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public DESedeKeySpec(byte[] key, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetKey() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy of the key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetKey() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns whether the specified key data starting at <code>offset</code> is <b>parity-adjusted</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified key data is parity-adjusted, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isParityAdjusted
				/// </java-name>
				[Dot42.DexImport("isParityAdjusted", "([BI)Z", AccessFlags = 9)]
				public static bool IsParityAdjusted(sbyte[] key, int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether the specified key data starting at <code>offset</code> is <b>parity-adjusted</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified key data is parity-adjusted, <c> false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isParityAdjusted
				/// </java-name>
				[Dot42.DexImport("isParityAdjusted", "([BI)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool IsParityAdjusted(byte[] key, int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DESedeKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				public byte[] Key
				{
				[Dot42.DexImport("getKey", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetKey(); }
				}

		}

		/// <summary>
		/// <para>The source of the label <code>L</code> as specified in . </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/PSource
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/PSource", AccessFlags = 33)]
		public partial class PSource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>PSource</code> instance with the specified source algorithm identifier.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal PSource(string pSrcName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the source algorithm identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the source algorithm identifier. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PSource() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the source algorithm identifier.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the source algorithm identifier. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>The explicit specification of the parameter <code>P</code> used in the source algorithm. </para>    
				/// </summary>
				/// <java-name>
				/// javax/crypto/spec/PSource$PSpecified
				/// </java-name>
				[Dot42.DexImport("javax/crypto/spec/PSource$PSpecified", AccessFlags = 25)]
				public sealed partial class PSpecified : global::Javax.Crypto.Spec.PSource
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>The instance of <code>PSpecified</code> with the default value <code>byte[0]</code> for <code>P</code> </para>        
						/// </summary>
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

						/// <summary>
						/// <para>Returns a copy of the value of the parameter <code>P</code>.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a copy of the value of the parameter <code>P</code> </para>
						/// </returns>
						/// <java-name>
						/// getValue
						/// </java-name>
						[Dot42.DexImport("getValue", "()[B", AccessFlags = 1)]
						public sbyte[] JavaGetValue() /* MethodBuilder.Create */ 
						{
								return default(sbyte[]);
						}

						/// <summary>
						/// <para>Returns a copy of the value of the parameter <code>P</code>.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a copy of the value of the parameter <code>P</code> </para>
						/// </returns>
						/// <java-name>
						/// getValue
						/// </java-name>
						[Dot42.DexImport("getValue", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						public byte[] GetValue() /* MethodBuilder.Create */ 
						{
								return default(byte[]);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal PSpecified() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						/// <para>Returns a copy of the value of the parameter <code>P</code>.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a copy of the value of the parameter <code>P</code> </para>
						/// </returns>
						/// <java-name>
						/// getValue
						/// </java-name>
						public byte[] Value
						{
						[Dot42.DexImport("getValue", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
								get{ return GetValue(); }
						}

				}

		}

		/// <summary>
		/// <para>The key specification for a <b>password based encryption</b> key. </para><para>Password based encryption is described in . </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/PBEKeySpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/PBEKeySpec", AccessFlags = 33)]
		public partial class PBEKeySpec : global::Java.Security.Spec.IKeySpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>PBEKeySpec</code> with the specified password.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public PBEKeySpec(char[] password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>PBEKeySpec</code> with the specified password, salt, iteration count and the desired length of the derived key.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([C[BII)V", AccessFlags = 1)]
				public PBEKeySpec(char[] password, sbyte[] salt, int iterationCount, int keyLength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>PBEKeySpec</code> with the specified password, salt, iteration count and the desired length of the derived key.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([C[BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PBEKeySpec(char[] password, byte[] salt, int iterationCount, int keyLength) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>PBEKeySpec</code> with the specified password, salt and iteration count.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([C[BI)V", AccessFlags = 1)]
				public PBEKeySpec(char[] password, sbyte[] salt, int iterationCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>PBEKeySpec</code> with the specified password, salt and iteration count.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([C[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PBEKeySpec(char[] password, byte[] salt, int iterationCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clears the password by overwriting it. </para>        
				/// </summary>
				/// <java-name>
				/// clearPassword
				/// </java-name>
				[Dot42.DexImport("clearPassword", "()V", AccessFlags = 17)]
				public void ClearPassword() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the password of this key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the password of this key specification. </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 17)]
				public char[] GetPassword() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				/// <para>Returns a copy of the salt of this key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the salt of this key specification or null if none is specified. </para>
				/// </returns>
				/// <java-name>
				/// getSalt
				/// </java-name>
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetSalt() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy of the salt of this key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the salt of this key specification or null if none is specified. </para>
				/// </returns>
				/// <java-name>
				/// getSalt
				/// </java-name>
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GetSalt() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the iteration count of this key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the iteration count of this key specification. </para>
				/// </returns>
				/// <java-name>
				/// getIterationCount
				/// </java-name>
				[Dot42.DexImport("getIterationCount", "()I", AccessFlags = 17)]
				public int GetIterationCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the desired key length of the derived key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the desired key length of the derived key. </para>
				/// </returns>
				/// <java-name>
				/// getKeyLength
				/// </java-name>
				[Dot42.DexImport("getKeyLength", "()I", AccessFlags = 17)]
				public int GetKeyLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PBEKeySpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the password of this key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the password of this key specification. </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				public char[] Password
				{
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 17)]
						get{ return GetPassword(); }
				}

				/// <summary>
				/// <para>Returns a copy of the salt of this key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the salt of this key specification or null if none is specified. </para>
				/// </returns>
				/// <java-name>
				/// getSalt
				/// </java-name>
				public byte[] Salt
				{
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return GetSalt(); }
				}

				/// <summary>
				/// <para>Returns the iteration count of this key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the iteration count of this key specification. </para>
				/// </returns>
				/// <java-name>
				/// getIterationCount
				/// </java-name>
				public int IterationCount
				{
				[Dot42.DexImport("getIterationCount", "()I", AccessFlags = 17)]
						get{ return GetIterationCount(); }
				}

				/// <summary>
				/// <para>Returns the desired key length of the derived key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the desired key length of the derived key. </para>
				/// </returns>
				/// <java-name>
				/// getKeyLength
				/// </java-name>
				public int KeyLength
				{
				[Dot42.DexImport("getKeyLength", "()I", AccessFlags = 17)]
						get{ return GetKeyLength(); }
				}

		}

		/// <summary>
		/// <para>The algorithm parameter specification for an <b>initialization vector</b>. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/IvParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/IvParameterSpec", AccessFlags = 33)]
		public partial class IvParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>IvParameterSpec</code> instance with the bytes from the specified buffer <b>iv</b> used as <b>initialization vector</b>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public IvParameterSpec(sbyte[] iv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>IvParameterSpec</code> instance with the bytes from the specified buffer <b>iv</b> used as <b>initialization vector</b>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public IvParameterSpec(byte[] iv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>IvParameterSpec</code> instance with <code>byteCount</code> bytes from the specified buffer <code>iv</code> starting at <code>offset</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1)]
				public IvParameterSpec(sbyte[] iv, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>IvParameterSpec</code> instance with <code>byteCount</code> bytes from the specified buffer <code>iv</code> starting at <code>offset</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public IvParameterSpec(byte[] iv, int offset, int byteCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the <b>initialization vector</b> data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector data. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetIV() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy of the <b>initialization vector</b> data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector data. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetIV() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IvParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a copy of the <b>initialization vector</b> data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector data. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				public byte[] IV
				{
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetIV(); }
				}

		}

		/// <summary>
		/// <para>The algorithm parameter specification for the  algorithm. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/RC2ParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/RC2ParameterSpec", AccessFlags = 33)]
		public partial class RC2ParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>RC2ParameterSpec</code> instance with the specified effective key length (in bits),</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public RC2ParameterSpec(int effectiveKeyBits) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>RC2ParameterSpec</code> instance with the specified effective key length (in bits) and <b>initialization vector</b>. </para><para>The size of the <b>initialization vector</b> must be at least 8 bytes which are copied to protect them against modification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1)]
				public RC2ParameterSpec(int effectiveKeyBits, sbyte[] iv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>RC2ParameterSpec</code> instance with the specified effective key length (in bits) and <b>initialization vector</b>. </para><para>The size of the <b>initialization vector</b> must be at least 8 bytes which are copied to protect them against modification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public RC2ParameterSpec(int effectiveKeyBits, byte[] iv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>RC2ParameterSpec</code> instance with the specified effective key length (in bits) and <b>initialization vector<b>. </b></b></para><para><b><b> The size of the <b>initialization vector</b> starting at <code>offset</code> must be at least 8 bytes which are copied to protect them against modification.</b></b></para><para><b><b> </b></b></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[BI)V", AccessFlags = 1)]
				public RC2ParameterSpec(int effectiveKeyBits, sbyte[] iv, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>RC2ParameterSpec</code> instance with the specified effective key length (in bits) and <b>initialization vector<b>. </b></b></para><para><b><b> The size of the <b>initialization vector</b> starting at <code>offset</code> must be at least 8 bytes which are copied to protect them against modification.</b></b></para><para><b><b> </b></b></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public RC2ParameterSpec(int effectiveKeyBits, byte[] iv, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the effective key length (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the effective key length (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getEffectiveKeyBits
				/// </java-name>
				[Dot42.DexImport("getEffectiveKeyBits", "()I", AccessFlags = 1)]
				public virtual int GetEffectiveKeyBits() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a copy of the initialization vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector, or null if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetIV() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy of the initialization vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector, or null if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetIV() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Compares the specified object to this <code>RC2ParameterSpec</code> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the effective key length and the initialization vector of both objects are equal, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hash code of this <code>RC2ParameterSpec</code> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns the effective key length (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the effective key length (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getEffectiveKeyBits
				/// </java-name>
				public int EffectiveKeyBits
				{
				[Dot42.DexImport("getEffectiveKeyBits", "()I", AccessFlags = 1)]
						get{ return GetEffectiveKeyBits(); }
				}

				/// <summary>
				/// <para>Returns a copy of the initialization vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector, or null if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				public byte[] IV
				{
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetIV(); }
				}

		}

		/// <summary>
		/// <para>The algorithm parameter specification for the Diffie-Hellman algorithm. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/DHParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/DHParameterSpec", AccessFlags = 33)]
		public partial class DHParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>DHParameterSpec</code> instance with the specified <b>prime modulus</b> and <b>base generator</b>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public DHParameterSpec(global::Java.Math.BigInteger p, global::Java.Math.BigInteger g) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>DHParameterSpec</code> instance with the specified <b>prime modulus</b>, <b>base generator</b> and size (in bits) of the <b>random exponent</b>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/math/BigInteger;Ljava/math/BigInteger;I)V", AccessFlags = 1)]
				public DHParameterSpec(global::Java.Math.BigInteger p, global::Java.Math.BigInteger g, int l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the <b>prime modulus</b> of this parameter specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime modulus. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetP() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the <b>base generator</b> of this parameter specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base generator. </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public virtual global::Java.Math.BigInteger GetG() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Returns the size (in bits) of the <b>random exponent</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size (in bits) of the random exponent. </para>
				/// </returns>
				/// <java-name>
				/// getL
				/// </java-name>
				[Dot42.DexImport("getL", "()I", AccessFlags = 1)]
				public virtual int GetL() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DHParameterSpec() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the <b>prime modulus</b> of this parameter specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the prime modulus. </para>
				/// </returns>
				/// <java-name>
				/// getP
				/// </java-name>
				public global::Java.Math.BigInteger P
				{
				[Dot42.DexImport("getP", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetP(); }
				}

				/// <summary>
				/// <para>Returns the <b>base generator</b> of this parameter specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the base generator. </para>
				/// </returns>
				/// <java-name>
				/// getG
				/// </java-name>
				public global::Java.Math.BigInteger G
				{
				[Dot42.DexImport("getG", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetG(); }
				}

				/// <summary>
				/// <para>Returns the size (in bits) of the <b>random exponent</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size (in bits) of the random exponent. </para>
				/// </returns>
				/// <java-name>
				/// getL
				/// </java-name>
				public int L
				{
				[Dot42.DexImport("getL", "()I", AccessFlags = 1)]
						get{ return GetL(); }
				}

		}

		/// <summary>
		/// <para>The algorithm parameter specification for the  algorithm. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/spec/RC5ParameterSpec
		/// </java-name>
		[Dot42.DexImport("javax/crypto/spec/RC5ParameterSpec", AccessFlags = 33)]
		public partial class RC5ParameterSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <code>RC5ParameterSpec</code> instance with the specified version, round count an word size (in bits).</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public RC5ParameterSpec(int version, int rounds, int wordSize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>RC5ParameterSpec</code> instance with the specified version, round count, word size (in bits) and an <b>initialization vector</b>. </para><para>The size of the <b>initialization vector</b> must be at least <code>2 * (wordSize / 8)</code> bytes which are copied to protect them against modification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III[B)V", AccessFlags = 1)]
				public RC5ParameterSpec(int version, int rounds, int wordSize, sbyte[] iv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>RC5ParameterSpec</code> instance with the specified version, round count, word size (in bits) and an <b>initialization vector</b>. </para><para>The size of the <b>initialization vector</b> must be at least <code>2 * (wordSize / 8)</code> bytes which are copied to protect them against modification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public RC5ParameterSpec(int version, int rounds, int wordSize, byte[] iv) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>RC5ParameterSpec</code> instance with the specified version, round count, wordSize (in bits), an <b>initialization vector</b> and an offset. </para><para>The size of the <b>initialization vector</b> must be at least <code>offset + (2 * (wordSize / 8))</code> bytes. The bytes starting at <code>offset</code> are copied to protect them against modification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III[BI)V", AccessFlags = 1)]
				public RC5ParameterSpec(int version, int rounds, int wordSize, sbyte[] iv, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <code>RC5ParameterSpec</code> instance with the specified version, round count, wordSize (in bits), an <b>initialization vector</b> and an offset. </para><para>The size of the <b>initialization vector</b> must be at least <code>offset + (2 * (wordSize / 8))</code> bytes. The bytes starting at <code>offset</code> are copied to protect them against modification.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(III[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public RC5ParameterSpec(int version, int rounds, int wordSize, byte[] iv, int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the version.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the version. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public virtual int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the round count.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the round count. </para>
				/// </returns>
				/// <java-name>
				/// getRounds
				/// </java-name>
				[Dot42.DexImport("getRounds", "()I", AccessFlags = 1)]
				public virtual int GetRounds() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the word size (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the word size (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getWordSize
				/// </java-name>
				[Dot42.DexImport("getWordSize", "()I", AccessFlags = 1)]
				public virtual int GetWordSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a copy of the initialization vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector, or null if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetIV() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns a copy of the initialization vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector, or null if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetIV() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Compares the specified object with this <code>RC5ParameterSpec</code> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if version, round count, word size and initializaion vector of both objects are equal, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the hash code of this <code>RC5ParameterSpec</code> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns the version.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the version. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns the round count.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the round count. </para>
				/// </returns>
				/// <java-name>
				/// getRounds
				/// </java-name>
				public int Rounds
				{
				[Dot42.DexImport("getRounds", "()I", AccessFlags = 1)]
						get{ return GetRounds(); }
				}

				/// <summary>
				/// <para>Returns the word size (in bits).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the word size (in bits). </para>
				/// </returns>
				/// <java-name>
				/// getWordSize
				/// </java-name>
				public int WordSize
				{
				[Dot42.DexImport("getWordSize", "()I", AccessFlags = 1)]
						get{ return GetWordSize(); }
				}

				/// <summary>
				/// <para>Returns a copy of the initialization vector.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the initialization vector, or null if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				public byte[] IV
				{
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetIV(); }
				}

		}

}


