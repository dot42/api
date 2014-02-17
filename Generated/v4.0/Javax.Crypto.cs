// Copyright (C) 2014 dot42
//
// Original filename: Javax.Crypto.cs
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
namespace Javax.Crypto
{
		/// <summary>
		/// <para>The <b>Service-Provider Interface</b> (<b>SPI</b>) definition for the <c>   Mac </c> class.</para><para><para>Mac </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/MacSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/MacSpi", AccessFlags = 1057)]
		public abstract partial class MacSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> MacSpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MacSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the length of this MAC (in bytes).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of this MAC (in bytes). </para>
				/// </returns>
				/// <java-name>
				/// engineGetMacLength
				/// </java-name>
				[Dot42.DexImport("engineGetMacLength", "()I", AccessFlags = 1028)]
				protected internal abstract int EngineGetMacLength() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> MacSpi </c> instance with the specified key and algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates this <c> MacSpi </c> instance with the data from the specified buffer, starting at ByteBuffer#position(), including the next ByteBuffer#remaining() bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte input) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates this <c> MacSpi </c> instance with the data from the specified buffer, starting at ByteBuffer#position(), including the next ByteBuffer#remaining() bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte input) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates this <c> MacSpi </c> instance with the data from the specified buffer <c> input </c> from the specified <c> offset </c> and length <c>       len </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte[] input, int offset, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates this <c> MacSpi </c> instance with the data from the specified buffer <c> input </c> from the specified <c> offset </c> and length <c>       len </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte[] input, int offset, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Updates this <c> MacSpi </c> instance with the data from the specified buffer, starting at ByteBuffer#position(), including the next ByteBuffer#remaining() bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 4)]
				protected internal virtual void EngineUpdate(global::Java.Nio.ByteBuffer input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Computes the digest of this MAC based on the data previously specified in engineUpdate calls. </para><para>This <c> MacSpi </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated digest. </para>
				/// </returns>
				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineDoFinal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Computes the digest of this MAC based on the data previously specified in engineUpdate calls. </para><para>This <c> MacSpi </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated digest. </para>
				/// </returns>
				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineDoFinal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Resets this <c> MacSpi </c> instance to its initial state. </para><para>This <c> MacSpi </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters. </para>        
				/// </summary>
				/// <java-name>
				/// engineReset
				/// </java-name>
				[Dot42.DexImport("engineReset", "()V", AccessFlags = 1028)]
				protected internal abstract void EngineReset() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Clones this <c> MacSpi </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <summary>
		/// <para>The <b>Service Provider Interface</b> (<b>SPI</b>) definition for the <c>   ExemptionMechanism </c> class. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/ExemptionMechanismSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/ExemptionMechanismSpi", AccessFlags = 1057)]
		public abstract partial class ExemptionMechanismSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> ExemptionMechanismSpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExemptionMechanismSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result key blob for this exemption mechanism. </para>
				/// </returns>
				/// <java-name>
				/// engineGenExemptionBlob
				/// </java-name>
				[Dot42.DexImport("engineGenExemptionBlob", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGenExemptionBlob() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result key blob for this exemption mechanism. </para>
				/// </returns>
				/// <java-name>
				/// engineGenExemptionBlob
				/// </java-name>
				[Dot42.DexImport("engineGenExemptionBlob", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGenExemptionBlob() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism and stores it into the <c> output </c> buffer at offset <c> outputOffset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written to the <c> output </c> buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineGenExemptionBlob
				/// </java-name>
				[Dot42.DexImport("engineGenExemptionBlob", "([BI)I", AccessFlags = 1028)]
				protected internal abstract int EngineGenExemptionBlob(sbyte[] output, int outputOffset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism and stores it into the <c> output </c> buffer at offset <c> outputOffset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written to the <c> output </c> buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineGenExemptionBlob
				/// </java-name>
				[Dot42.DexImport("engineGenExemptionBlob", "([BI)I", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract int EngineGenExemptionBlob(byte[] output, int outputOffset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the size in bytes for the output buffer needed to hold the output of the next engineGenExemptionBlob call, given the specified <c> inputLen </c> (in bytes).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size in bytes for the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineGetOutputSize
				/// </java-name>
				[Dot42.DexImport("engineGetOutputSize", "(I)I", AccessFlags = 1028)]
				protected internal abstract int EngineGetOutputSize(int inputLen) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> ExemptionMechanism </c> instance with the specified key.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> ExemptionMechanism </c> instance with the specified key and algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters @params) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> ExemptionMechanism </c> instance with the specified key and algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec @params) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The exception that is thrown when a padding mechanism is expected for the input data, but the input data does not have the proper padding bytes. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/BadPaddingException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/BadPaddingException", AccessFlags = 33)]
		public partial class BadPaddingException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new instance of <c> BadPaddingException </c> with a message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BadPaddingException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new instance of <c> BadPaddingException </c> with no message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BadPaddingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The exception, that is thrown when the data length provided to a block cipher does not match the block size of the cipher. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/IllegalBlockSizeException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/IllegalBlockSizeException", AccessFlags = 33)]
		public partial class IllegalBlockSizeException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> IllegalBlockSizeException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IllegalBlockSizeException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> IllegalBlockSizeException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IllegalBlockSizeException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides access to implementations of cryptographic ciphers for encryption and decryption. Cipher classes can not be instantiated directly, one has to call the Cipher's <c> getInstance </c> method with the name of a requested transformation, optionally with a provider. A transformation specifies an operation (or a set of operations) as a string in the form: <ul><li><para><b>"algorithm/mode/padding"</b> or </para></li><li><para><b>"algorithm"</b> </para></li></ul><b>algorithm</b> is the name of a cryptographic algorithm, <b>mode</b> is the name of a feedback mode and <b>padding</b> is the name of a padding scheme. If <b>mode</b> and/or <b>padding</b> values are omitted, provider specific default values will be used. </para><para>A valid transformation would be: <ul><li></li></ul>Cipher c = Cipher.getInstance("AES/CBC/PKCS5Padding");   When a block cipher is requested in in stream cipher mode, the number of bits to be processed at a time can be optionally specified by appending it to the mode name. e.g. <b>"AES/CFB8/NoPadding"</b>. If no number is specified, a provider specific default value is used. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/Cipher
		/// </java-name>
		[Dot42.DexImport("javax/crypto/Cipher", AccessFlags = 33)]
		public partial class Cipher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constant for decryption operation mode. </para>        
				/// </summary>
				/// <java-name>
				/// DECRYPT_MODE
				/// </java-name>
				[Dot42.DexImport("DECRYPT_MODE", "I", AccessFlags = 25)]
				public const int DECRYPT_MODE = 2;
				/// <summary>
				/// <para>Constant for encryption operation mode. </para>        
				/// </summary>
				/// <java-name>
				/// ENCRYPT_MODE
				/// </java-name>
				[Dot42.DexImport("ENCRYPT_MODE", "I", AccessFlags = 25)]
				public const int ENCRYPT_MODE = 1;
				/// <summary>
				/// <para>Constant indicating that the key to be unwrapped is a private key. </para>        
				/// </summary>
				/// <java-name>
				/// PRIVATE_KEY
				/// </java-name>
				[Dot42.DexImport("PRIVATE_KEY", "I", AccessFlags = 25)]
				public const int PRIVATE_KEY = 2;
				/// <summary>
				/// <para>Constant indicating that the key to be unwrapped is a public key. </para>        
				/// </summary>
				/// <java-name>
				/// PUBLIC_KEY
				/// </java-name>
				[Dot42.DexImport("PUBLIC_KEY", "I", AccessFlags = 25)]
				public const int PUBLIC_KEY = 1;
				/// <summary>
				/// <para>Constant indicating that the key to be unwrapped is a secret key. </para>        
				/// </summary>
				/// <java-name>
				/// SECRET_KEY
				/// </java-name>
				[Dot42.DexImport("SECRET_KEY", "I", AccessFlags = 25)]
				public const int SECRET_KEY = 3;
				/// <summary>
				/// <para>Constant for key unwrapping operation mode. </para>        
				/// </summary>
				/// <java-name>
				/// UNWRAP_MODE
				/// </java-name>
				[Dot42.DexImport("UNWRAP_MODE", "I", AccessFlags = 25)]
				public const int UNWRAP_MODE = 4;
				/// <summary>
				/// <para>Constant for key wrapping operation mode. </para>        
				/// </summary>
				/// <java-name>
				/// WRAP_MODE
				/// </java-name>
				[Dot42.DexImport("WRAP_MODE", "I", AccessFlags = 25)]
				public const int WRAP_MODE = 3;
				/// <summary>
				/// <para>Creates a new Cipher instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/crypto/CipherSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Cipher(global::Javax.Crypto.CipherSpi cipherSpi, global::Java.Security.Provider provider, string transformation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new Cipher for the specified transformation. The installed providers are searched in order for an implementation of the specified transformation. The first found provider providing the transformation is used to create the cipher. If no provider is found an exception is thrown.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a cipher for the requested transformation. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/Cipher;", AccessFlags = 25)]
				public static global::Javax.Crypto.Cipher GetInstance(string transformation) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the provider of this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this cipher instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Returns the name of the algorithm of this cipher instance. </para><para>This is the name of the <b>transformation</b> argument used in the <c> getInstance </c> call creating this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the algorithm of this cipher instance. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns this ciphers block size (in bytes).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this ciphers block size. </para>
				/// </returns>
				/// <java-name>
				/// getBlockSize
				/// </java-name>
				[Dot42.DexImport("getBlockSize", "()I", AccessFlags = 17)]
				public int GetBlockSize() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the length in bytes an output buffer needs to be when this cipher is updated with <c> inputLen </c> bytes.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the output buffer length for the input length. </para>
				/// </returns>
				/// <java-name>
				/// getOutputSize
				/// </java-name>
				[Dot42.DexImport("getOutputSize", "(I)I", AccessFlags = 17)]
				public int GetOutputSize(int inputLen) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the <b>initialization vector</b> for this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <b>initialization vector</b> for this cipher instance. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetIV() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the <b>initialization vector</b> for this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <b>initialization vector</b> for this cipher instance. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GetIV() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the parameters that where used to create this cipher instance. </para><para>These may be a the same parameters that were used to create this cipher instance, or may be a combination of default and random parameters, depending on the underlying cipher implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters that where used to create this cipher instance, or <c> null </c> if this cipher instance does not have any parameters. </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 17)]
				public global::Java.Security.AlgorithmParameters GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				/// <summary>
				/// <para>Returns the exemption mechanism associated with this cipher.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>currently <c> null </c> </para>
				/// </returns>
				/// <java-name>
				/// getExemptionMechanism
				/// </java-name>
				[Dot42.DexImport("getExemptionMechanism", "()Ljavax/crypto/ExemptionMechanism;", AccessFlags = 17)]
				public global::Javax.Crypto.ExemptionMechanism GetExemptionMechanism() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ExemptionMechanism);
				}

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key. </para><para>The cipher is initialized for the specified operational mode (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters or random values that the specified key can not provide, the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, meaning that it is equivalent to creating a new instance and calling its <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;)V", AccessFlags = 17)]
				public void Init(int opmode, global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key and a source of randomness. </para><para>The cipher is initialized for the specified operational mode (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters or random values that the specified key can not provide, the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values are generated using <c>       random </c> ; </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, means it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(int opmode, global::Java.Security.IKey key, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key and a source of randomness. </para><para>The cipher is initialized for the specified operational mode (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters or random values that the specified key can not provide, the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values are generated using <c>       random </c> ; </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, means it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(int opmode, global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key, algorithm parameters and a source of randomness. </para><para>The cipher is initialized for the specified operational mode (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters and <c> params </c> is <c> null </c> , the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values are generated using <c> random </c> ; </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, meaning that it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/Se" +
    "cureRandom;)V", AccessFlags = 17)]
				public void Init(int opmode, global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key and a source of randomness. </para><para>The cipher is initialized for the specified operational mode (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters or random values that the specified key can not provide, the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values are generated using <c>       random </c> ; </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, means it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;)V", AccessFlags = 17)]
				public void Init(int opmode, global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key, algorithm parameters and a source of randomness. </para><para>The cipher is initialized for the specified operational mode (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters and <c> params </c> is <c> null </c> , the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values are generated using <c> random </c> ; </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, meaning that it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRand" +
    "om;)V", AccessFlags = 17)]
				public void Init(int opmode, global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key. </para><para>The cipher is initialized for the specified operational mode (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters or random values that the specified key can not provide, the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, meaning that it is equivalent to creating a new instance and calling its <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void Init(int opmode, global::Java.Security.Cert.Certificate key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key and a source of randomness. </para><para>The cipher is initialized for the specified operational mode (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters or random values that the specified key can not provide, the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values are generated using <c>       random </c> ; </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, means it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/cert/Certificate;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(int opmode, global::Java.Security.Cert.Certificate key, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the transformed bytes in a new buffer, or <c> null </c> if the input has zero length. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)[B", AccessFlags = 17)]
				public sbyte[] Update(sbyte[] input) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the transformed bytes in a new buffer, or <c> null </c> if the input has zero length. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Update(byte[] input) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the transformed bytes in a new buffer, or <c> null </c> if the input has zero length. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)[B", AccessFlags = 17)]
				public sbyte[] Update(sbyte[] input, int inputOffset, int inputLen) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the transformed bytes in a new buffer, or <c> null </c> if the input has zero length. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Update(byte[] input, int inputOffset, int inputLen) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are stored in the <c> output </c> buffer. </para><para>If the size of the <c> output </c> buffer is too small to hold the result, a <c> ShortBufferException </c> is thrown. Use getOutputSize to check for the size of the output buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in output. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII[B)I", AccessFlags = 17)]
				public int Update(sbyte[] input, int inputOffset, int inputLen, sbyte[] output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are stored in the <c> output </c> buffer. </para><para>If the size of the <c> output </c> buffer is too small to hold the result, a <c> ShortBufferException </c> is thrown. Use getOutputSize to check for the size of the output buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in output. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII[B)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int Update(byte[] input, int inputOffset, int inputLen, byte[] output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are stored in the <c> output </c> buffer. </para><para>If the size of the <c> output </c> buffer is too small to hold the result, a <c> ShortBufferException </c> is thrown. Use getOutputSize to check for the size of the output buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in output. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII[BI)I", AccessFlags = 17)]
				public int Update(sbyte[] input, int inputOffset, int inputLen, sbyte[] output, int outputOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are stored in the <c> output </c> buffer. </para><para>If the size of the <c> output </c> buffer is too small to hold the result, a <c> ShortBufferException </c> is thrown. Use getOutputSize to check for the size of the output buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in output. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII[BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int Update(byte[] input, int inputOffset, int inputLen, byte[] output, int outputOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The <c> input.remaining() </c> bytes starting at <c> input.position() </c> are transformed and stored in the <c> output </c> buffer. </para><para>If the <c> output.remaining() </c> is too small to hold the transformed bytes a <c> ShortBufferException </c> is thrown. Use getOutputSize to check for the size of the output buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes stored in the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", AccessFlags = 17)]
				public int Update(global::Java.Nio.ByteBuffer input, global::Java.Nio.ByteBuffer output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes any bytes that may have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final bytes from the transformation. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "()[B", AccessFlags = 17)]
				public sbyte[] JavaDoFinal() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes any bytes that may have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final bytes from the transformation. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> input.remaining() </c> bytes in <c> input </c> buffer at <c> input.position() </c> , and any bytes that have been buffered in previous <c> update </c> calls. The transformed bytes are placed into <c> output </c> buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed into the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BI)I", AccessFlags = 17)]
				public int DoFinal(sbyte[] input, int output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> input.remaining() </c> bytes in <c> input </c> buffer at <c> input.position() </c> , and any bytes that have been buffered in previous <c> update </c> calls. The transformed bytes are placed into <c> output </c> buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed into the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int DoFinal(byte[] input, int output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the bytes in <c> input </c> buffer, and any bytes that have been buffered in previous <c> update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final bytes from the transformation. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([B)[B", AccessFlags = 17)]
				public sbyte[] DoFinal(sbyte[] input) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the bytes in <c> input </c> buffer, and any bytes that have been buffered in previous <c> update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final bytes from the transformation. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([B)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal(byte[] input) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c>       inputOffset </c> , and any bytes that have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final bytes from the transformation. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII)[B", AccessFlags = 17)]
				public sbyte[] DoFinal(sbyte[] input, int inputOffset, int inputLen) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c>       inputOffset </c> , and any bytes that have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final bytes from the transformation. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal(byte[] input, int inputOffset, int inputLen) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c>       inputOffset </c> , and any bytes that have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII[B)I", AccessFlags = 17)]
				public int DoFinal(sbyte[] input, int inputOffset, int inputLen, sbyte[] output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c>       inputOffset </c> , and any bytes that have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII[B)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int DoFinal(byte[] input, int inputOffset, int inputLen, byte[] output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c>       inputOffset </c> , and any bytes that have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII[BI)I", AccessFlags = 17)]
				public int DoFinal(sbyte[] input, int inputOffset, int inputLen, sbyte[] output, int outputOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c>       inputOffset </c> , and any bytes that have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BII[BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int DoFinal(byte[] input, int inputOffset, int inputLen, byte[] output, int outputOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> input.remaining() </c> bytes in <c> input </c> buffer at <c> input.position() </c> , and any bytes that have been buffered in previous <c> update </c> calls. The transformed bytes are placed into <c> output </c> buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed into the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", AccessFlags = 17)]
				public int DoFinal(global::Java.Nio.ByteBuffer input, global::Java.Nio.ByteBuffer output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Wraps a key using this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the wrapped key. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/security/Key;)[B", AccessFlags = 17)]
				public sbyte[] JavaWrap(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Wraps a key using this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the wrapped key. </para>
				/// </returns>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Ljava/security/Key;)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Wrap(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Unwraps a key using this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unwrapped key </para>
				/// </returns>
				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "([BLjava/lang/String;I)Ljava/security/Key;", AccessFlags = 17)]
				public global::Java.Security.IKey Unwrap(sbyte[] wrappedKey, string wrappedKeyAlgorithm, int wrappedKeyType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <summary>
				/// <para>Unwraps a key using this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unwrapped key </para>
				/// </returns>
				/// <java-name>
				/// unwrap
				/// </java-name>
				[Dot42.DexImport("unwrap", "([BLjava/lang/String;I)Ljava/security/Key;", AccessFlags = 17, IgnoreFromJava = true)]
				public global::Java.Security.IKey Unwrap(byte[] wrappedKey, string wrappedKeyAlgorithm, int wrappedKeyType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <summary>
				/// <para>Returns the maximum key length for the specified transformation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the maximum key length, currently <c> Integer.MAX_VALUE </c> . </para>
				/// </returns>
				/// <java-name>
				/// getMaxAllowedKeyLength
				/// </java-name>
				[Dot42.DexImport("getMaxAllowedKeyLength", "(Ljava/lang/String;)I", AccessFlags = 25)]
				public static int GetMaxAllowedKeyLength(string transformation) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the maximum cipher parameter value for the specified transformation. If there is no maximum limit, <c> null </c> is returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a parameter spec holding the maximum value or <c> null </c> . Currently <c> null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getMaxAllowedParameterSpec
				/// </java-name>
				[Dot42.DexImport("getMaxAllowedParameterSpec", "(Ljava/lang/String;)Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 25)]
				public static global::Java.Security.Spec.IAlgorithmParameterSpec GetMaxAllowedParameterSpec(string transformation) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IAlgorithmParameterSpec);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Cipher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the provider of this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this cipher instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <summary>
				/// <para>Returns the name of the algorithm of this cipher instance. </para><para>This is the name of the <b>transformation</b> argument used in the <c> getInstance </c> call creating this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the algorithm of this cipher instance. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns this ciphers block size (in bytes).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this ciphers block size. </para>
				/// </returns>
				/// <java-name>
				/// getBlockSize
				/// </java-name>
				public int BlockSize
				{
				[Dot42.DexImport("getBlockSize", "()I", AccessFlags = 17)]
						get{ return GetBlockSize(); }
				}

				/// <summary>
				/// <para>Returns the <b>initialization vector</b> for this cipher instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <b>initialization vector</b> for this cipher instance. </para>
				/// </returns>
				/// <java-name>
				/// getIV
				/// </java-name>
				public byte[] IV
				{
				[Dot42.DexImport("getIV", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return GetIV(); }
				}

				/// <summary>
				/// <para>Returns the parameters that where used to create this cipher instance. </para><para>These may be a the same parameters that were used to create this cipher instance, or may be a combination of default and random parameters, depending on the underlying cipher implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters that where used to create this cipher instance, or <c> null </c> if this cipher instance does not have any parameters. </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Security.AlgorithmParameters Parameters
				{
				[Dot42.DexImport("getParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 17)]
						get{ return GetParameters(); }
				}

				/// <summary>
				/// <para>Returns the exemption mechanism associated with this cipher.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>currently <c> null </c> </para>
				/// </returns>
				/// <java-name>
				/// getExemptionMechanism
				/// </java-name>
				public global::Javax.Crypto.ExemptionMechanism ExemptionMechanism
				{
				[Dot42.DexImport("getExemptionMechanism", "()Ljavax/crypto/ExemptionMechanism;", AccessFlags = 17)]
						get{ return GetExemptionMechanism(); }
				}

		}

		/// <summary>
		/// <para>This class provides an identity cipher that does not transform the input data in any way. The <b>encrypted</b> data is identical to the <b>plain text</b>. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/NullCipher
		/// </java-name>
		[Dot42.DexImport("javax/crypto/NullCipher", AccessFlags = 33)]
		public partial class NullCipher : global::Javax.Crypto.Cipher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> NullCipher </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NullCipher() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The <b>Service Provider Interface</b> (<b>SPI</b>) definition for the <c>   SecretKeyFactory </c> class. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/SecretKeyFactorySpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SecretKeyFactorySpi", AccessFlags = 1057)]
		public abstract partial class SecretKeyFactorySpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SecretKeyFactorySpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecretKeyFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Generate a secret key from the specified key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a secret key. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Crypto.ISecretKey EngineGenerateSecret(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the key specification of the specified secret key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of the specified key specification class. </para>
				/// </returns>
				/// <java-name>
				/// engineGetKeySpec
				/// </java-name>
				[Dot42.DexImport("engineGetKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.Spec.IKeySpec EngineGetKeySpec(global::Javax.Crypto.ISecretKey key, global::System.Type keySpec) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Translates the specified secret key into an instance of the corresponding key from the provider of this key factory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the corresponding translated key. </para>
				/// </returns>
				/// <java-name>
				/// engineTranslateKey
				/// </java-name>
				[Dot42.DexImport("engineTranslateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Crypto.ISecretKey EngineTranslateKey(global::Javax.Crypto.ISecretKey key) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <c> SealedObject </c> is a wrapper around a <c> serializable </c> object instance and encrypts it using a cryptographic cipher.</para><para>Since a <c> SealedObject </c> instance is serializable it can either be stored or transmitted over an insecure channel.</para><para>The wrapped object can later be decrypted (unsealed) using the corresponding key and then be deserialized to retrieve the original object. The sealed object itself keeps track of the cipher and corresponding parameters. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/SealedObject
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SealedObject", AccessFlags = 33)]
		public partial class SealedObject : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The cipher's AlgorithmParameters in encoded format. Equivalent to <c> cipher.getParameters().getEncoded() </c> , or null if the cipher did not use any parameters. </para>        
				/// </summary>
				/// <java-name>
				/// encodedParams
				/// </java-name>
				[Dot42.DexImport("encodedParams", "[B", AccessFlags = 4)]
				protected internal sbyte[] EncodedParams;
				/// <summary>
				/// <para>Creates a new <c> SealedObject </c> instance wrapping the specified object and sealing it using the specified cipher. </para><para>The cipher must be fully initialized.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Serializable;Ljavax/crypto/Cipher;)V", AccessFlags = 1)]
				public SealedObject(global::Java.Io.ISerializable @object, global::Javax.Crypto.Cipher c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> SealedObject </c> instance by copying the data from the specified object.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/crypto/SealedObject;)V", AccessFlags = 4)]
				protected internal SealedObject(global::Javax.Crypto.SealedObject so) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the algorithm this object was sealed with.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm this object was sealed with. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the wrapped object, decrypting it using the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encapsulated object. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/security/Key;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetObject(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the wrapped object, decrypting it using the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encapsulated object. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljavax/crypto/Cipher;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetObject(global::Javax.Crypto.Cipher key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Returns the wrapped object, decrypting it using the specified key. The specified provider is used to retrieve the cipher algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encapsulated object. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "(Ljava/security/Key;Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetObject(global::Java.Security.IKey key, string provider) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SealedObject() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the algorithm this object was sealed with.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the algorithm this object was sealed with. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

		}

		/// <summary>
		/// <para>This class implements the functionality of an exemption mechanism such as <b>key recovery</b>, <b>key weakening</b>, or <b>key escrow</b>. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/ExemptionMechanism
		/// </java-name>
		[Dot42.DexImport("javax/crypto/ExemptionMechanism", AccessFlags = 33)]
		public partial class ExemptionMechanism
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a <c> ExemptionMechanism </c> instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/crypto/ExemptionMechanismSpi;Ljava/security/Provider;Ljava/lang/String;)V" +
    "", AccessFlags = 4)]
				protected internal ExemptionMechanism(global::Javax.Crypto.ExemptionMechanismSpi exmechSpi, global::Java.Security.Provider provider, string mechanism) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this <c> ExemptionMechanism </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <c> ExemptionMechanism </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a new <c> ExemptionMechanism </c> instance that provides the specified exemption mechanism algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new <c> ExemptionMechanism </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/ExemptionMechanism;", AccessFlags = 25)]
				public static global::Javax.Crypto.ExemptionMechanism GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the provider of this <c> ExemptionMechanism </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this <c> ExemptionMechanism </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Returns whether the result blob for this <c> ExemptionMechanism </c> instance has been generated successfully and that the specified key is the same as the one that was used to initialize and generate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the result blob for this <c> ExemptionMechanism </c> instance has been generated successfully. </para>
				/// </returns>
				/// <java-name>
				/// isCryptoAllowed
				/// </java-name>
				[Dot42.DexImport("isCryptoAllowed", "(Ljava/security/Key;)Z", AccessFlags = 17)]
				public bool IsCryptoAllowed(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the size in bytes for the output buffer needed to hold the output of the next genExemptionBlob call, given the specified <c>       inputLen </c> (in bytes).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size in bytes for the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// getOutputSize
				/// </java-name>
				[Dot42.DexImport("getOutputSize", "(I)I", AccessFlags = 17)]
				public int GetOutputSize(int inputLen) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Initializes this <c> ExemptionMechanism </c> instance with the specified key.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> ExemptionMechanism </c> instance with the specified key and algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters param) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> ExemptionMechanism </c> instance with the specified key and algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec param) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result key blob for this exemption mechanism. </para>
				/// </returns>
				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGenExemptionBlob() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the result key blob for this exemption mechanism. </para>
				/// </returns>
				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GenExemptionBlob() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism and stores it into the <c> output </c> buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written to the <c> output </c> buffer. </para>
				/// </returns>
				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "([B)I", AccessFlags = 17)]
				public int GenExemptionBlob(sbyte[] output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism and stores it into the <c> output </c> buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written to the <c> output </c> buffer. </para>
				/// </returns>
				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "([B)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int GenExemptionBlob(byte[] output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism and stores it into the <c> output </c> buffer at offset <c> outputOffset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written to the <c> output </c> buffer. </para>
				/// </returns>
				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "([BI)I", AccessFlags = 17)]
				public int GenExemptionBlob(sbyte[] output, int outputOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Generates the result key blob for this exemption mechanism and stores it into the <c> output </c> buffer at offset <c> outputOffset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes written to the <c> output </c> buffer. </para>
				/// </returns>
				/// <java-name>
				/// genExemptionBlob
				/// </java-name>
				[Dot42.DexImport("genExemptionBlob", "([BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int GenExemptionBlob(byte[] output, int outputOffset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Override to clear any key state in the instance. </para>        
				/// </summary>
				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~ExemptionMechanism() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ExemptionMechanism() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this <c> ExemptionMechanism </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <c> ExemptionMechanism </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Returns the provider of this <c> ExemptionMechanism </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this <c> ExemptionMechanism </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

		}

		/// <summary>
		/// <para>The <b>Service Provider Interface</b> (<b>SPI</b>) definition for the <c> KeyAgreement </c> class. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/KeyAgreementSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/KeyAgreementSpi", AccessFlags = 1057)]
		public abstract partial class KeyAgreementSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> KeyAgreementSpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyAgreementSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Does the next (or the last) phase of the key agreement, using the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the intermediate key from this phase or null if there is no intermediate key for this phase. </para>
				/// </returns>
				/// <java-name>
				/// engineDoPhase
				/// </java-name>
				[Dot42.DexImport("engineDoPhase", "(Ljava/security/Key;Z)Ljava/security/Key;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.IKey EngineDoPhase(global::Java.Security.IKey key, bool lastPhase) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates the shared secret.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated shared secret. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGenerateSecret() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates the shared secret.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated shared secret. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGenerateSecret() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates the shared secret and stores it into the buffer <c>       sharedSecred </c> at <c> offset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes stored in the buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "([BI)I", AccessFlags = 1028)]
				protected internal abstract int EngineGenerateSecret(sbyte[] sharedSecret, int offset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates the shared secret and stores it into the buffer <c>       sharedSecred </c> at <c> offset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes stored in the buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "([BI)I", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract int EngineGenerateSecret(byte[] sharedSecret, int offset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates the shared secret.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the shared secret as a <c> SecretKey </c> of the specified algorithm. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateSecret
				/// </java-name>
				[Dot42.DexImport("engineGenerateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Crypto.ISecretKey EngineGenerateSecret(string algorithm) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> KeyAgreementSpi </c> with the specified key and the specified randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> KeyAgreementSpi </c> with the specified key, algorithm parameters and randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/Sec" +
    "ureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class provides the public API for generating symmetric cryptographic keys. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/KeyGenerator
		/// </java-name>
		[Dot42.DexImport("javax/crypto/KeyGenerator", AccessFlags = 33)]
		public partial class KeyGenerator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> KeyGenerator </c> instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/crypto/KeyGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyGenerator(global::Javax.Crypto.KeyGeneratorSpi keyGenSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the key generation algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the key generation algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the provider of this <c> KeyGenerator </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this <c> KeyGenerator </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Creates a new <c> KeyGenerator </c> instance that provides the specified key algorithm,</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new <c> KeyGenerator </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyGenerator;", AccessFlags = 25)]
				public static global::Javax.Crypto.KeyGenerator GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Generates a secret key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated secret key. </para>
				/// </returns>
				/// <java-name>
				/// generateKey
				/// </java-name>
				[Dot42.DexImport("generateKey", "()Ljavax/crypto/SecretKey;", AccessFlags = 17)]
				public global::Javax.Crypto.ISecretKey GenerateKey() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ISecretKey);
				}

				/// <summary>
				/// <para>Initializes this <c> KeyGenerator </c> instance with the specified algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> KeyGenerator </c> instance with the specified algorithm parameters and randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> KeyGenerator </c> instance with the specified algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(I)V", AccessFlags = 17)]
				public void Init(int @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> KeyGenerator </c> instance with the specified algorithm parameters and randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(int @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> KeyGenerator </c> instance with the specified algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.SecureRandom @params) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyGenerator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the key generation algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the key generation algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the provider of this <c> KeyGenerator </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this <c> KeyGenerator </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when the requested padding mechanism is not supported. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/NoSuchPaddingException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/NoSuchPaddingException", AccessFlags = 33)]
		public partial class NoSuchPaddingException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> NoSuchPaddingException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchPaddingException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> NoSuchPaddingException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchPaddingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class defines the <b>Service Provider Interface</b> (<b>SPI</b>) for cryptographic ciphers. </para><para>Implementers of cryptographic ciphers must implement all the abstract methods for every cipher they implement. <c> CipherSpi </c> instances are created along with ciphers when the Cipher#getInstance method is called. A <c> Cipher </c> is referenced by a <b>transformation</b>, which is a string that describes the operation (or set of operations), always consisting of the cipher's name and optionally followed by a mode and a padding, in the form: <ul><li><para>"algorithm"or </para></li><li><para>"algorithm/mode/padding" </para></li></ul>The following behavior should be implemented for obtaining <c> Cipher </c> instances. </para><para>When one of the Cipher#getInstance factory methods is called with a <b>transformation</b> that is only an <b>algorithm</b>, check if the provider defines a <c> CipherSpi </c> for "algorithm", if so: return it, otherwise throw a NoSuchAlgorithmException. </para><para>The following rules apply when a <b>transformation</b> is of the form "algorithm/mode/padding": <ul><li></li></ul>The Provider has a <c> CipherSpi </c> subclass registered for "algorithm/mode/padding": return it, otherwise go to step 2.  <ul><li></li></ul>The Provider has a <c> CipherSpi </c> subclass registered for "algorithm/mode": instantiate it, call engineSetPadding(String) for the padding name and return it, otherwise go to step 3.  <ul><li></li></ul>The Provider has a <c> CipherSpi </c> subclass registered for "algorithm//padding": instantiate it, call engineSetMode(String) for the mode name and return it, otherwise go to step 4.  <ul><li></li></ul>The Provider has a <c> CipherSpi </c> subclass registered for "algorithm": instantiate it, call engineSetMode(String) for the mode name , call engineSetPadding(String) for the padding name and return it, otherwise throw a NoSuchAlgorithmException. </para><para><para>Cipher </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/CipherSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/CipherSpi", AccessFlags = 1057)]
		public abstract partial class CipherSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CipherSpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CipherSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the mode for this cipher.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetMode
				/// </java-name>
				[Dot42.DexImport("engineSetMode", "(Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void EngineSetMode(string mode) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the padding method for this cipher.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetPadding
				/// </java-name>
				[Dot42.DexImport("engineSetPadding", "(Ljava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void EngineSetPadding(string padding) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the block size of this cipher (in bytes)</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the block size of this cipher, or zero if this cipher is not a block cipher. </para>
				/// </returns>
				/// <java-name>
				/// engineGetBlockSize
				/// </java-name>
				[Dot42.DexImport("engineGetBlockSize", "()I", AccessFlags = 1028)]
				protected internal abstract int EngineGetBlockSize() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the size for a buffer (in bytes), that the next call to <c>       update </c> of <c> doFinal </c> would return, taking into account any buffered data from previous <c> update </c> calls and padding. </para><para>The actual output length of the next call to <c> update </c> or <c>       doFinal </c> may be smaller than the length returned by this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size for a buffer (in bytes). </para>
				/// </returns>
				/// <java-name>
				/// engineGetOutputSize
				/// </java-name>
				[Dot42.DexImport("engineGetOutputSize", "(I)I", AccessFlags = 1028)]
				protected internal abstract int EngineGetOutputSize(int inputLen) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the Initialization Vector (IV) that was used to initialize this cipher or <c> null </c> if none was used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Initialization Vector (IV), or <c> null </c> if none was used. </para>
				/// </returns>
				/// <java-name>
				/// engineGetIV
				/// </java-name>
				[Dot42.DexImport("engineGetIV", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGetIV() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the Initialization Vector (IV) that was used to initialize this cipher or <c> null </c> if none was used.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Initialization Vector (IV), or <c> null </c> if none was used. </para>
				/// </returns>
				/// <java-name>
				/// engineGetIV
				/// </java-name>
				[Dot42.DexImport("engineGetIV", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGetIV() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the parameters that where used to create this cipher instance. </para><para>These may be a the same parameters that were used to create this cipher instance, or may be a combination of default and random parameters, depending on the underlying cipher implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters that where used to create this cipher instance, or <c> null </c> if this cipher instance does not have any parameters at all. </para>
				/// </returns>
				/// <java-name>
				/// engineGetParameters
				/// </java-name>
				[Dot42.DexImport("engineGetParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.AlgorithmParameters EngineGetParameters() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key and a source of randomness. </para><para>The cipher will be initialized for the specified operation (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters or random values that the specified key cannot provide, the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values will be generated using <c>       random </c> ; </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, means it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int opmode, global::Java.Security.IKey key, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key, algorithm parameters and a source of randomness. </para><para>The cipher will be initialized for the specified operation (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters and <c> params </c> is <c> null </c> , the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values are generated using <c> random </c> . </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, means it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/Se" +
    "cureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int opmode, global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this cipher instance with the specified key, algorithm parameters and a source of randomness. </para><para>The cipher will be initialized for the specified operation (one of: encryption, decryption, key wrapping or key unwrapping) depending on <c> opmode </c> . </para><para>If this cipher instance needs any algorithm parameters and <c> params </c> is <c> null </c> , the underlying implementation of this cipher is supposed to generate the required parameters (using its provider or random values). Random values are generated using <c> random </c> . </para><para>When a cipher instance is initialized by a call to any of the <c>       init </c> methods, the state of the instance is overridden, means it is equivalent to creating a new instance and calling it <c> init </c> method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRand" +
    "om;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int opmode, global::Java.Security.IKey key, global::Java.Security.AlgorithmParameters @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the transformed bytes in a new buffer, or <c> null </c> if the input has zero length. </para>
				/// </returns>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] EngineUpdate(sbyte[] input, int inputOffset, int inputLen) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are returned.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the transformed bytes in a new buffer, or <c> null </c> if the input has zero length. </para>
				/// </returns>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineUpdate(byte[] input, int inputOffset, int inputLen) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are stored in the <c> output </c> buffer. </para><para>If the size of the <c> output </c> buffer is too small to hold the result, a <c> ShortBufferException </c> is thrown. Use getOutputSize to check for the size of the output buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in output. </para>
				/// </returns>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII[BI)I", AccessFlags = 1028)]
				protected internal abstract int EngineUpdate(sbyte[] input, int inputOffset, int inputLen, sbyte[] output, int outputOffset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The transformed bytes are stored in the <c> output </c> buffer. </para><para>If the size of the <c> output </c> buffer is too small to hold the result, a <c> ShortBufferException </c> is thrown. Use getOutputSize to check for the size of the output buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in output. </para>
				/// </returns>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII[BI)I", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract int EngineUpdate(byte[] input, int inputOffset, int inputLen, byte[] output, int outputOffset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Continues a multi-part transformation (encryption or decryption). The <c> input.remaining() </c> bytes starting at <c> input.position() </c> are transformed and stored in the <c> output </c> buffer. </para><para>If the <c> output.remaining() </c> is too small to hold the transformed bytes a <c> ShortBufferException </c> is thrown. Use getOutputSize to check for the size of the output buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes stored in the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", AccessFlags = 4)]
				protected internal virtual int EngineUpdate(global::Java.Nio.ByteBuffer input, global::Java.Nio.ByteBuffer output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c>       inputOffset </c> , and any bytes that have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final bytes from the transformation. </para>
				/// </returns>
				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "([BII)[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] EngineDoFinal(sbyte[] input, int inputOffset, int inputLen) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c>       inputOffset </c> , and any bytes that have been buffered in previous <c>       update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the final bytes from the transformation. </para>
				/// </returns>
				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "([BII)[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineDoFinal(byte[] input, int inputOffset, int inputLen) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c> inputOffset </c> , and any bytes that have been buffered in previous <c> update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "([BII[BI)I", AccessFlags = 1028)]
				protected internal abstract int EngineDoFinal(sbyte[] input, int inputOffset, int inputLen, sbyte[] output, int outputOffset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> inputLen </c> bytes in <c> input </c> buffer at <c> inputOffset </c> , and any bytes that have been buffered in previous <c> update </c> calls.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed in the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "([BII[BI)I", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract int EngineDoFinal(byte[] input, int inputOffset, int inputLen, byte[] output, int outputOffset) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Finishes a multi-part transformation (encryption or decryption). </para><para>Processes the <c> input.remaining() </c> bytes in <c> input </c> buffer at <c> input.position() </c> , and any bytes that have been buffered in previous <c> update </c> calls. The transformed bytes are placed into <c> output </c> buffer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes placed into the output buffer. </para>
				/// </returns>
				/// <java-name>
				/// engineDoFinal
				/// </java-name>
				[Dot42.DexImport("engineDoFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", AccessFlags = 4)]
				protected internal virtual int EngineDoFinal(global::Java.Nio.ByteBuffer input, global::Java.Nio.ByteBuffer output) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Wraps a key using this cipher instance. This method has been added to this class (for backwards compatibility, it cannot be abstract). If this method is not overridden, it throws an <c>       UnsupportedOperationException </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the wrapped key </para>
				/// </returns>
				/// <java-name>
				/// engineWrap
				/// </java-name>
				[Dot42.DexImport("engineWrap", "(Ljava/security/Key;)[B", AccessFlags = 4)]
				protected internal virtual sbyte[] JavaEngineWrap(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Wraps a key using this cipher instance. This method has been added to this class (for backwards compatibility, it cannot be abstract). If this method is not overridden, it throws an <c>       UnsupportedOperationException </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the wrapped key </para>
				/// </returns>
				/// <java-name>
				/// engineWrap
				/// </java-name>
				[Dot42.DexImport("engineWrap", "(Ljava/security/Key;)[B", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual byte[] EngineWrap(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Unwraps a key using this cipher instance. </para><para>This method has been added to this class (for backwards compatibility, it cannot be abstract). If this method is not overridden, it throws an <c> UnsupportedOperationException </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unwrapped key. </para>
				/// </returns>
				/// <java-name>
				/// engineUnwrap
				/// </java-name>
				[Dot42.DexImport("engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.IKey EngineUnwrap(sbyte[] wrappedKey, string wrappedKeyAlgorithm, int wrappedKeyType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <summary>
				/// <para>Unwraps a key using this cipher instance. </para><para>This method has been added to this class (for backwards compatibility, it cannot be abstract). If this method is not overridden, it throws an <c> UnsupportedOperationException </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the unwrapped key. </para>
				/// </returns>
				/// <java-name>
				/// engineUnwrap
				/// </java-name>
				[Dot42.DexImport("engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual global::Java.Security.IKey EngineUnwrap(byte[] wrappedKey, string wrappedKeyAlgorithm, int wrappedKeyType) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <summary>
				/// <para>Returns the size of a specified key object in bits. This method has been added to this class (for backwards compatibility, it cannot be abstract). If this method is not overridden, it throws an <c>       UnsupportedOperationException </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the size of a specified key object in bits. </para>
				/// </returns>
				/// <java-name>
				/// engineGetKeySize
				/// </java-name>
				[Dot42.DexImport("engineGetKeySize", "(Ljava/security/Key;)I", AccessFlags = 4)]
				protected internal virtual int EngineGetKeySize(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>This is the base class for <c> ExemptionMechanismException </c> . </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/ExemptionMechanismException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/ExemptionMechanismException", AccessFlags = 33)]
		public partial class ExemptionMechanismException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> ExemptionMechanismException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ExemptionMechanismException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> ExemptionMechanismException </c> with no message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExemptionMechanismException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides the functionality for a key exchange protocol. This enables two or more parties to agree on a secret key for symmetric cryptography. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/KeyAgreement
		/// </java-name>
		[Dot42.DexImport("javax/crypto/KeyAgreement", AccessFlags = 33)]
		public partial class KeyAgreement
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> KeyAgreement </c> instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/crypto/KeyAgreementSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyAgreement(global::Javax.Crypto.KeyAgreementSpi keyAgreeSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the key agreement algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the key agreement algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the provider for this <c> KeyAgreement </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider for this <c> KeyAgreement </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Creates a new <c> KeyAgreement </c> for the specified algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a key agreement for the specified algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/KeyAgreement;", AccessFlags = 25)]
				public static global::Javax.Crypto.KeyAgreement GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Initializes this <c> KeyAgreement </c> with the specified key.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> KeyAgreement </c> with the specified key and the specified randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> KeyAgreement </c> with the specified key and the specified randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> KeyAgreement </c> with the specified key, algorithm parameters and randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/Sec" +
    "ureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Does the next (or the last) phase of the key agreement, using the specified key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the intermediate key from this phase or <c> null </c> if there is no intermediate key for this phase. </para>
				/// </returns>
				/// <java-name>
				/// doPhase
				/// </java-name>
				[Dot42.DexImport("doPhase", "(Ljava/security/Key;Z)Ljava/security/Key;", AccessFlags = 17)]
				public global::Java.Security.IKey DoPhase(global::Java.Security.IKey key, bool lastPhase) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <summary>
				/// <para>Generates the shared secret.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated shared secret. </para>
				/// </returns>
				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGenerateSecret() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Generates the shared secret.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated shared secret. </para>
				/// </returns>
				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GenerateSecret() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Generates the shared secret and stores it into the buffer <c>       sharedSecred </c> at <c> offset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes stored in the buffer. </para>
				/// </returns>
				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "([BI)I", AccessFlags = 17)]
				public int GenerateSecret(sbyte[] sharedSecret, int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Generates the shared secret and stores it into the buffer <c>       sharedSecred </c> at <c> offset </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes stored in the buffer. </para>
				/// </returns>
				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "([BI)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int GenerateSecret(byte[] sharedSecret, int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Generates the shared secret.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the shared secret as a <c> SecretKey </c> of the specified algorithm. </para>
				/// </returns>
				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", AccessFlags = 17)]
				public global::Javax.Crypto.ISecretKey GenerateSecret(string algorithm) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ISecretKey);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyAgreement() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the key agreement algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the key agreement algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the provider for this <c> KeyAgreement </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider for this <c> KeyAgreement </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

		}

		/// <summary>
		/// <para>The public API for <c> SecretKeyFactory </c> implementations. </para><para>Secret key factories provide the following functionality: <ul><li><para>convert SecretKey objects to and from KeySpec objects </para></li><li><para>translate SecretKey objects from one provider implementation to another </para></li></ul>Which key specifications are supported by the generateSecret and getKeySpec is provider dependent. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/SecretKeyFactory
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SecretKeyFactory", AccessFlags = 33)]
		public partial class SecretKeyFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> SecretKeyFactory </c></para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/crypto/SecretKeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal SecretKeyFactory(global::Javax.Crypto.SecretKeyFactorySpi keyFacSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the secret key algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the secret key algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the provider for this <c> SecretKeyFactory </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider for this <c> SecretKeyFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Creates a new <c> SecretKeyFactory </c> instance for the specified key algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a secret key factory for the specified key algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/SecretKeyFactory;", AccessFlags = 25)]
				public static global::Javax.Crypto.SecretKeyFactory GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Generate a secret key from the specified key specification.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a secret key. </para>
				/// </returns>
				/// <java-name>
				/// generateSecret
				/// </java-name>
				[Dot42.DexImport("generateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", AccessFlags = 17)]
				public global::Javax.Crypto.ISecretKey GenerateSecret(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ISecretKey);
				}

				/// <summary>
				/// <para>Returns the key specification of the specified secret key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of the specified key specification class. </para>
				/// </returns>
				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", AccessFlags = 17)]
				public global::Java.Security.Spec.IKeySpec GetKeySpec(global::Javax.Crypto.ISecretKey key, global::System.Type keySpec) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.IKeySpec);
				}

				/// <summary>
				/// <para>Translates the specified secret key into an instance of the corresponding key from the provider of this key factory.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the corresponding translated key. </para>
				/// </returns>
				/// <java-name>
				/// translateKey
				/// </java-name>
				[Dot42.DexImport("translateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", AccessFlags = 17)]
				public global::Javax.Crypto.ISecretKey TranslateKey(global::Javax.Crypto.ISecretKey key) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Crypto.ISecretKey);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SecretKeyFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the secret key algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the secret key algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the provider for this <c> SecretKeyFactory </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider for this <c> SecretKeyFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

		}

		/// <summary>
		/// <para>This class wraps an <c> InputStream </c> and a cipher so that <c> read() </c> methods return data that are read from the underlying <c> InputStream </c> and processed by the cipher. </para><para>The cipher must be initialized for the requested operation before being used by a <c> CipherInputStream </c> . For example, if a cipher initialized for decryption is used with a <c> CipherInputStream </c> , the <c>   CipherInputStream </c> tries to read the data an decrypt them before returning. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/CipherInputStream
		/// </java-name>
		[Dot42.DexImport("javax/crypto/CipherInputStream", AccessFlags = 33)]
		public partial class CipherInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CipherInputStream </c> instance for an <c>       InputStream </c> and a cipher.</para><para><b>Warning:</b> passing a null source creates an invalid <c> CipherInputStream </c> . All read operations on such a stream will fail.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljavax/crypto/Cipher;)V", AccessFlags = 1)]
				public CipherInputStream(global::Java.Io.InputStream @is, global::Javax.Crypto.Cipher c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> CipherInputStream </c> instance for an <c>       InputStream </c> without a cipher. </para><para>A <c> NullCipher </c> is created and used to process the data.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 4)]
				protected internal CipherInputStream(global::Java.Io.InputStream @is) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reads the next byte from this cipher input stream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next byte, or <c> -1 </c> if the end of the stream is reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reads the next <c> len </c> bytes from this input stream into buffer <c> buf </c> starting at offset <c> off </c> . </para><para>if <c> buf </c> is <c> null </c> , the next <c> len </c> bytes are read and discarded.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes filled into buffer <c> buf </c> , or <c> -1 </c> of the of the stream is reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buf, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Reads the next <c> len </c> bytes from this input stream into buffer <c> buf </c> starting at offset <c> off </c> . </para><para>if <c> buf </c> is <c> null </c> , the next <c> len </c> bytes are read and discarded.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes filled into buffer <c> buf </c> , or <c> -1 </c> of the of the stream is reached. </para>
				/// </returns>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buf, int off, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Skips <c> byteCount </c> bytes in this stream. Subsequent calls to <c> read </c> will not return these bytes unless <c> reset </c> is used. This implementation skips <c> byteCount </c> bytes in the filtered stream.</para><para><para>mark(int) </para><simplesectsep></simplesectsep><para>reset() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of bytes actually skipped. </para>
				/// </returns>
				/// <java-name>
				/// skip
				/// </java-name>
				[Dot42.DexImport("skip", "(J)J", AccessFlags = 1)]
				public override long Skip(long byteCount) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Returns an estimated number of bytes that can be read or skipped without blocking for more input.</para><para>Note that this method provides such a weak guarantee that it is not very useful in practice.</para><para>Firstly, the guarantee is "without blocking for more input" rather than "without       blocking": a read may still block waiting for I/O to complete  the guarantee is merely that it won't have to wait indefinitely for data to be written. The result of this method should not be used as a license to do I/O on a thread that shouldn't be blocked.</para><para>Secondly, the result is a conservative estimate and may be significantly smaller than the actual number of bytes available. In particular, an implementation that always returns 0 would be correct. In general, callers should only use this method if they'd be satisfied with treating the result as a boolean yes or no answer to the question "is there definitely       data ready?".</para><para>Thirdly, the fact that a given number of bytes is "available" does not guarantee that a read or skip will actually read or skip that many bytes: they may read or skip fewer.</para><para>It is particularly important to realize that you <b>must not</b> use this method to size a container and assume that you can read the entirety of the stream without needing to resize the container. Such callers should probably write everything they read to a ByteArrayOutputStream and convert that to a byte array. Alternatively, if you're reading from a file, File#length returns the current length of the file (though assuming the file's length can't change may be incorrect, reading a file is inherently racy).</para><para>The default implementation of this method in <c> InputStream </c> always returns 0. Subclasses should override this method if they are able to indicate the number of bytes available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated number of bytes available </para>
				/// </returns>
				/// <java-name>
				/// available
				/// </java-name>
				[Dot42.DexImport("available", "()I", AccessFlags = 1)]
				public override int Available() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Closes this <c> CipherInputStream </c> , also closes the underlying input stream and call <c> doFinal </c> on the cipher object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public override void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether this input stream supports <c> mark </c> and <c> reset </c> , which it does not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>false, since this input stream does not support <c> mark </c> and <c> reset </c> . </para>
				/// </returns>
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

		/// <summary>
		/// <para>The exception that is thrown when the result of an operation is attempted to store in a user provided buffer that is too small. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/ShortBufferException
		/// </java-name>
		[Dot42.DexImport("javax/crypto/ShortBufferException", AccessFlags = 33)]
		public partial class ShortBufferException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new instance of <c> ShortBufferException </c> with the specified message</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ShortBufferException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new instance of <c> ShortBufferException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ShortBufferException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides the public API for <b>Message Authentication Code</b> (MAC) algorithms. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/Mac
		/// </java-name>
		[Dot42.DexImport("javax/crypto/Mac", AccessFlags = 33)]
		public partial class Mac : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> Mac </c> instance.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljavax/crypto/MacSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Mac(global::Javax.Crypto.MacSpi macSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the MAC algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the MAC algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the provider of this <c> Mac </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this <c> Mac </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				/// <para>Creates a new <c> Mac </c> instance that provides the specified MAC algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the new <c> Mac </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljavax/crypto/Mac;", AccessFlags = 25)]
				public static global::Javax.Crypto.Mac GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the length of this MAC (in bytes).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of this MAC (in bytes). </para>
				/// </returns>
				/// <java-name>
				/// getMacLength
				/// </java-name>
				[Dot42.DexImport("getMacLength", "()I", AccessFlags = 17)]
				public int GetMacLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Initializes this <c> Mac </c> instance with the specified key and algorithm parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key, global::Java.Security.Spec.IAlgorithmParameterSpec @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initializes this <c> Mac </c> instance with the specified key.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/Key;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates this <c> Mac </c> instance with the data from the specified buffer, starting at ByteBuffer#position(), including the next ByteBuffer#remaining() bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 17)]
				public void Update(sbyte input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates this <c> Mac </c> instance with the data from the specified buffer, starting at ByteBuffer#position(), including the next ByteBuffer#remaining() bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates this <c> Mac </c> instance with the data from the specified buffer <c> input </c> from the specified <c> offset </c> and length <c> len </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 17)]
				public void Update(sbyte[] input, int offset, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates this <c> Mac </c> instance with the data from the specified buffer <c> input </c> from the specified <c> offset </c> and length <c> len </c> .</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte[] input, int offset, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates this <c> Mac </c> instance with the data from the specified buffer, starting at ByteBuffer#position(), including the next ByteBuffer#remaining() bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 17)]
				public void Update(sbyte[] input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates this <c> Mac </c> instance with the data from the specified buffer, starting at ByteBuffer#position(), including the next ByteBuffer#remaining() bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte[] input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates this <c> Mac </c> instance with the data from the specified buffer, starting at ByteBuffer#position(), including the next ByteBuffer#remaining() bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 17)]
				public void Update(global::Java.Nio.ByteBuffer input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Computes the digest of this MAC based on the data previously specified in update calls. </para><para>This <c> Mac </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated digest. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "()[B", AccessFlags = 17)]
				public sbyte[] JavaDoFinal() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Computes the digest of this MAC based on the data previously specified in update calls. </para><para>This <c> Mac </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated digest. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Computes the digest of this MAC based on the data previously specified in update calls and stores the digest in the specified <c>       output </c> buffer at offset <c> outOffset </c> . </para><para>This <c> Mac </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BI)V", AccessFlags = 17)]
				public void DoFinal(sbyte[] output, int outOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Computes the digest of this MAC based on the data previously specified in update calls and stores the digest in the specified <c>       output </c> buffer at offset <c> outOffset </c> . </para><para>This <c> Mac </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([BI)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void DoFinal(byte[] output, int outOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Computes the digest of this MAC based on the data previously specified on update calls and on the final bytes specified by <c> input </c> (or based on those bytes only). </para><para>This <c> Mac </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated digest. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([B)[B", AccessFlags = 17)]
				public sbyte[] DoFinal(sbyte[] input) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Computes the digest of this MAC based on the data previously specified on update calls and on the final bytes specified by <c> input </c> (or based on those bytes only). </para><para>This <c> Mac </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated digest. </para>
				/// </returns>
				/// <java-name>
				/// doFinal
				/// </java-name>
				[Dot42.DexImport("doFinal", "([B)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] DoFinal(byte[] input) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Resets this <c> Mac </c> instance to its initial state. </para><para>This <c> Mac </c> instance is reverted to its initial state and can be used to start the next MAC computation with the same parameters or initialized with different parameters. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 17)]
				public void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clones this <c> Mac </c> instance and the underlying implementation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cloned instance. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns the name of the MAC algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the MAC algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <summary>
				/// <para>Returns the provider of this <c> Mac </c> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the provider of this <c> Mac </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <summary>
				/// <para>Returns the length of this MAC (in bytes).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the length of this MAC (in bytes). </para>
				/// </returns>
				/// <java-name>
				/// getMacLength
				/// </java-name>
				public int MacLength
				{
				[Dot42.DexImport("getMacLength", "()I", AccessFlags = 17)]
						get{ return GetMacLength(); }
				}

		}

		/// <summary>
		/// <para>A cryptographic secret (symmetric) key. </para><para>This interface is a <b>marker interface</b> to group secret keys and to provide type safety for. </para><para>Implementations of this interface have to overwrite the equals and hashCode from java.lang.Object so comparison is done using the actual key data and not the object reference. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/SecretKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SecretKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISecretKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serialization version identifier.</para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -4795878709595146952;
		}

		/// <summary>
		/// <para>A cryptographic secret (symmetric) key. </para><para>This interface is a <b>marker interface</b> to group secret keys and to provide type safety for. </para><para>Implementations of this interface have to overwrite the equals and hashCode from java.lang.Object so comparison is done using the actual key data and not the object reference. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/SecretKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/SecretKey", AccessFlags = 1537)]
		public partial interface ISecretKey : global::Java.Security.IKey
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>This class implements the <c> EncryptedPrivateKeyInfo </c> ASN.1 type as specified in . </para><para>The definition of ASN.1 is as follows: ::= SEQUENCE { encryptionAlgorithm AlgorithmIdentifier, encryptedData OCTET STRING } </para><para>::= SEQUENCE { algorithm OBJECT IDENTIFIER, parameters ANY DEFINED BY algorithm OPTIONAL } </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/EncryptedPrivateKeyInfo
		/// </java-name>
		[Dot42.DexImport("javax/crypto/EncryptedPrivateKeyInfo", AccessFlags = 33)]
		public partial class EncryptedPrivateKeyInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates an <c> EncryptedPrivateKeyInfo </c> instance from its encoded representation by parsing it.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public EncryptedPrivateKeyInfo(sbyte[] encoded) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an <c> EncryptedPrivateKeyInfo </c> instance from its encoded representation by parsing it.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public EncryptedPrivateKeyInfo(byte[] encoded) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the name of the encryption algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the encryption algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgName
				/// </java-name>
				[Dot42.DexImport("getAlgName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAlgName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the parameters used by the encryption algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters used by the encryption algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgParameters
				/// </java-name>
				[Dot42.DexImport("getAlgParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 1)]
				public virtual global::Java.Security.AlgorithmParameters GetAlgParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				/// <summary>
				/// <para>Returns the encrypted data of this key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encrypted data of this key, each time this method is called a new array is returned. </para>
				/// </returns>
				/// <java-name>
				/// getEncryptedData
				/// </java-name>
				[Dot42.DexImport("getEncryptedData", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetEncryptedData() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns the encrypted data of this key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encrypted data of this key, each time this method is called a new array is returned. </para>
				/// </returns>
				/// <java-name>
				/// getEncryptedData
				/// </java-name>
				[Dot42.DexImport("getEncryptedData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetEncryptedData() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns the <c> PKCS8EncodedKeySpec </c> object extracted from the encrypted data. </para><para>The cipher must be initialize in either <c> Cipher.DECRYPT_MODE </c> or <c> Cipher.UNWRAP_MODE </c> with the same parameters and key used for encrypting this.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the extracted <c> PKCS8EncodedKeySpec </c> . </para>
				/// </returns>
				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljavax/crypto/Cipher;)Ljava/security/spec/PKCS8EncodedKeySpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(global::Javax.Crypto.Cipher cipher) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.PKCS8EncodedKeySpec);
				}

				/// <summary>
				/// <para>Returns the <c> PKCS8EncodedKeySpec </c> object extracted from the encrypted data. </para><para>The cipher must be initialize in either <c> Cipher.DECRYPT_MODE </c> or <c> Cipher.UNWRAP_MODE </c> with the same parameters and key used for encrypting this.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the extracted <c> PKCS8EncodedKeySpec </c> . </para>
				/// </returns>
				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljava/security/Key;)Ljava/security/spec/PKCS8EncodedKeySpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(global::Java.Security.IKey cipher) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.PKCS8EncodedKeySpec);
				}

				/// <summary>
				/// <para>Returns the <c> PKCS8EncodedKeySpec </c> object extracted from the encrypted data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the extracted <c> PKCS8EncodedKeySpec </c> . </para>
				/// </returns>
				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljava/security/Key;Ljava/lang/String;)Ljava/security/spec/PKCS8EncodedKeySpec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(global::Java.Security.IKey decryptKey, string provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.PKCS8EncodedKeySpec);
				}

				/// <summary>
				/// <para>Returns the <c> PKCS8EncodedKeySpec </c> object extracted from the encrypted data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the extracted <c> PKCS8EncodedKeySpec </c> . </para>
				/// </returns>
				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljava/security/Key;Ljava/security/Provider;)Ljava/security/spec/PKCS8EncodedKeyS" +
    "pec;", AccessFlags = 1)]
				public virtual global::Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(global::Java.Security.IKey decryptKey, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Spec.PKCS8EncodedKeySpec);
				}

				/// <summary>
				/// <para>Returns the ASN.1 encoded representation of this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ASN.1 encoded representation of this object. </para>
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
				/// <para>Returns the ASN.1 encoded representation of this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ASN.1 encoded representation of this object. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EncryptedPrivateKeyInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of the encryption algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the encryption algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgName
				/// </java-name>
				public string AlgName
				{
				[Dot42.DexImport("getAlgName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAlgName(); }
				}

				/// <summary>
				/// <para>Returns the parameters used by the encryption algorithm.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters used by the encryption algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgParameters
				/// </java-name>
				public global::Java.Security.AlgorithmParameters AlgParameters
				{
				[Dot42.DexImport("getAlgParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 1)]
						get{ return GetAlgParameters(); }
				}

				/// <summary>
				/// <para>Returns the encrypted data of this key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encrypted data of this key, each time this method is called a new array is returned. </para>
				/// </returns>
				/// <java-name>
				/// getEncryptedData
				/// </java-name>
				public byte[] EncryptedData
				{
				[Dot42.DexImport("getEncryptedData", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncryptedData(); }
				}

				/// <summary>
				/// <para>Returns the ASN.1 encoded representation of this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ASN.1 encoded representation of this object. </para>
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
		/// <para>The <b>Service Provider Interface</b> (<b>SPI</b>) definition for the <c> KeyGenerator </c> class.</para><para><para>KeyGenerator </para></para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/KeyGeneratorSpi
		/// </java-name>
		[Dot42.DexImport("javax/crypto/KeyGeneratorSpi", AccessFlags = 1057)]
		public abstract partial class KeyGeneratorSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> KeyGeneratorSpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyGeneratorSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Generates a secret key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the generated secret key. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateKey
				/// </java-name>
				[Dot42.DexImport("engineGenerateKey", "()Ljavax/crypto/SecretKey;", AccessFlags = 1028)]
				protected internal abstract global::Javax.Crypto.ISecretKey EngineGenerateKey() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> KeyGeneratorSpi </c> instance with the specified algorithm parameters and randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.Spec.IAlgorithmParameterSpec @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> KeyGeneratorSpi </c> instance with the specified algorithm parameters and randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int @params, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Initializes this <c> KeyGenerator </c> with the specified randomness source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class wraps an output stream and a cipher so that <c> write </c> methods send the data through the cipher before writing them to the underlying output stream. </para><para>The cipher must be initialized for the requested operation before being used by a <c> CipherOutputStream </c> . For example, if a cipher initialized for encryption is used with a <c> CipherOutputStream </c> , the <c>   CipherOutputStream </c> tries to encrypt the data writing it out. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/CipherOutputStream
		/// </java-name>
		[Dot42.DexImport("javax/crypto/CipherOutputStream", AccessFlags = 33)]
		public partial class CipherOutputStream : global::Java.Io.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CipherOutputStream </c> instance for an <c>       OutputStream </c> and a <c> Cipher </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljavax/crypto/Cipher;)V", AccessFlags = 1)]
				public CipherOutputStream(global::Java.Io.OutputStream os, global::Javax.Crypto.Cipher c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> CipherOutputStream </c> instance for an <c>       OutputStream </c> without a cipher. </para><para>A <c> NullCipher </c> is created to process the data.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;)V", AccessFlags = 4)]
				protected internal CipherOutputStream(global::Java.Io.OutputStream os) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes the single byte to this cipher output stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes the <c> len </c> bytes from buffer <c> b </c> starting at offset <c> off </c> to this cipher output stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Writes the <c> len </c> bytes from buffer <c> b </c> starting at offset <c> off </c> to this cipher output stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Flushes this cipher output stream.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// flush
				/// </java-name>
				[Dot42.DexImport("flush", "()V", AccessFlags = 1)]
				public override void Flush() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Close this cipher output stream. </para><para>On the underlying cipher <c> doFinal </c> will be invoked, and any buffered bytes from the cipher are also written out, and the cipher is reset to its initial state. The underlying output stream is also closed.</para><para></para>        
				/// </summary>
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

}


