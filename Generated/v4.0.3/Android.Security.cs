#pragma warning disable 1717
namespace Android.Security
{
		/// <java-name>
		/// android/security/KeyChainException
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChainException", AccessFlags = 33)]
		public partial class KeyChainException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyChainException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public KeyChainException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyChainException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyChainException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/security/KeyChain
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChain", AccessFlags = 49)]
		public sealed partial class KeyChain
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EXTRA_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NAME = "name";
				/// <java-name>
				/// EXTRA_CERTIFICATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CERTIFICATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CERTIFICATE = "CERT";
				/// <java-name>
				/// EXTRA_PKCS12
				/// </java-name>
				[Dot42.DexImport("EXTRA_PKCS12", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PKCS12 = "PKCS12";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyChain() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createInstallIntent
				/// </java-name>
				[Dot42.DexImport("createInstallIntent", "()Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent CreateInstallIntent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// choosePrivateKeyAlias
				/// </java-name>
				[Dot42.DexImport("choosePrivateKeyAlias", "(Landroid/app/Activity;Landroid/security/KeyChainAliasCallback;[Ljava/lang/String" +
    ";[Ljava/security/Principal;Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 9)]
				public static void ChoosePrivateKeyAlias(global::Android.App.Activity activity, global::Android.Security.IKeyChainAliasCallback keyChainAliasCallback, string[] @string, global::Java.Security.IPrincipal[] principal, string string1, int int32, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrivateKey
				/// </java-name>
				[Dot42.DexImport("getPrivateKey", "(Landroid/content/Context;Ljava/lang/String;)Ljava/security/PrivateKey;", AccessFlags = 9)]
				public static global::Java.Security.IPrivateKey GetPrivateKey(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrivateKey);
				}

				/// <java-name>
				/// getCertificateChain
				/// </java-name>
				[Dot42.DexImport("getCertificateChain", "(Landroid/content/Context;Ljava/lang/String;)[Ljava/security/cert/X509Certificate" +
    ";", AccessFlags = 9)]
				public static global::Java.Security.Cert.X509Certificate[] GetCertificateChain(global::Android.Content.Context context, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.X509Certificate[]);
				}

		}

		/// <java-name>
		/// android/security/KeyChainAliasCallback
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChainAliasCallback", AccessFlags = 1537)]
		public partial interface IKeyChainAliasCallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// alias
				/// </java-name>
				[Dot42.DexImport("alias", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Alias(string @string) /* MethodBuilder.Create */ ;

		}

}

