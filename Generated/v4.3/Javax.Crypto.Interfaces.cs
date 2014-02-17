// Copyright (C) 2014 dot42
//
// Original filename: Javax.Crypto.Interfaces.cs
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
namespace Javax.Crypto.Interfaces
{
		/// <summary>
		/// <para>The interface to a <b>password-based-encryption</b> key. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/interfaces/PBEKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/PBEKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IPBEKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -1430015993304333921;
		}

		/// <summary>
		/// <para>The interface to a <b>password-based-encryption</b> key. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/interfaces/PBEKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/PBEKey", AccessFlags = 1537)]
		public partial interface IPBEKey : global::Javax.Crypto.ISecretKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the iteration count, 0 if not specified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the iteration count, 0 if not specified. </para>
				/// </returns>
				/// <java-name>
				/// getIterationCount
				/// </java-name>
				[Dot42.DexImport("getIterationCount", "()I", AccessFlags = 1025)]
				int GetIterationCount() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a copy of the salt data or null if not specified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of the salt data or null if not specified. </para>
				/// </returns>
				/// <java-name>
				/// getSalt
				/// </java-name>
				[Dot42.DexImport("getSalt", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetSalt() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a copy to the password.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy to the password. </para>
				/// </returns>
				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1025)]
				char[] GetPassword() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for a Diffie-Hellman key. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/interfaces/DHKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHKey", AccessFlags = 1537)]
		public partial interface IDHKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the parameters for this key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters for this key. </para>
				/// </returns>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Ljavax/crypto/spec/DHParameterSpec;", AccessFlags = 1025)]
				global::Javax.Crypto.Spec.DHParameterSpec GetParams() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for a public key in the Diffie-Hellman key exchange protocol. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/interfaces/DHPublicKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHPublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDHPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serial version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -6628103563352519193;
		}

		/// <summary>
		/// <para>The interface for a public key in the Diffie-Hellman key exchange protocol. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/interfaces/DHPublicKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHPublicKey", AccessFlags = 1537)]
		public partial interface IDHPublicKey : global::Javax.Crypto.Interfaces.IDHKey, global::Java.Security.IPublicKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns this key's public value Y. </para>        
				/// </summary>
				/// <returns>
				/// <para>this key's public value Y. </para>
				/// </returns>
				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetY() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface for a private key in the Diffie-Hellman key exchange protocol. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/interfaces/DHPrivateKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHPrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDHPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The serialization version identifier. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 2211791113380396553;
		}

		/// <summary>
		/// <para>The interface for a private key in the Diffie-Hellman key exchange protocol. </para>    
		/// </summary>
		/// <java-name>
		/// javax/crypto/interfaces/DHPrivateKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHPrivateKey", AccessFlags = 1537)]
		public partial interface IDHPrivateKey : global::Javax.Crypto.Interfaces.IDHKey, global::Java.Security.IPrivateKey
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns this key's private value x. </para>        
				/// </summary>
				/// <returns>
				/// <para>this key's private value x. </para>
				/// </returns>
				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				global::Java.Math.BigInteger GetX() /* MethodBuilder.Create */ ;

		}

}


