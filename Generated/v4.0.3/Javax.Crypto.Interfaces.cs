#pragma warning disable 1717
namespace Javax.Crypto.Interfaces
{
		/// <java-name>
		/// javax/crypto/interfaces/DHKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHKey", AccessFlags = 1537)]
		public partial interface IDHKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getParams
				/// </java-name>
				global::Javax.Crypto.Spec.DHParameterSpec Params
				{
						[Dot42.DexImport("getParams", "()Ljavax/crypto/spec/DHParameterSpec;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/crypto/interfaces/DHPrivateKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHPrivateKey", AccessFlags = 1537)]
		public partial interface IDHPrivateKey : global::Javax.Crypto.Interfaces.IDHKey, global::Java.Security.IPrivateKey
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
		/// javax/crypto/interfaces/DHPrivateKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHPrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDHPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 2211791113380396553;
		}

		/// <java-name>
		/// javax/crypto/interfaces/DHPublicKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHPublicKey", AccessFlags = 1537)]
		public partial interface IDHPublicKey : global::Javax.Crypto.Interfaces.IDHKey, global::Java.Security.IPublicKey
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
		/// javax/crypto/interfaces/DHPublicKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/DHPublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IDHPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -6628103563352519193;
		}

		/// <java-name>
		/// javax/crypto/interfaces/PBEKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/PBEKey", AccessFlags = 1537)]
		public partial interface IPBEKey : global::Javax.Crypto.ISecretKey
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getIterationCount
				/// </java-name>
				int IterationCount
				{
						[Dot42.DexImport("getIterationCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSalt
				/// </java-name>
				byte[] Salt
				{
						[Dot42.DexImport("getSalt", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				char[] Password
				{
						[Dot42.DexImport("getPassword", "()[C", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/crypto/interfaces/PBEKey
		/// </java-name>
		[Dot42.DexImport("javax/crypto/interfaces/PBEKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IPBEKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = -1430015993304333921;
		}

}

