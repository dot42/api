#pragma warning disable 1717
namespace Android.Security
{
		/// <summary>
		///  <para>The KeyChainAliasCallback is the callback for KeyChain#choosePrivateKeyAlias. </para>    
		/// </summary>
		/// <java-name>
		/// android/security/KeyChainAliasCallback
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChainAliasCallback", AccessFlags = 1537)]
		public partial interface IKeyChainAliasCallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called with the alias of the certificate chosen by the user, or null if no value was chosen. </para>        
				/// </summary>
				/// <java-name>
				/// alias
				/// </java-name>
				[Dot42.DexImport("alias", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Alias(string alias) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The <c>KeyChain </c> class provides access to private keys and their corresponding certificate chains in credential storage.</para> <para>Applications accessing the <c>KeyChain </c> normally go through these steps:</para> <para> <ol> <li> <para>Receive a callback from an X509KeyManager that a private key is requested.</para> <para></para></li> <li> <para>Call choosePrivateKeyAlias to allow the user to select from a list of currently available private keys and corresponding certificate chains. The chosen alias will be returned by the callback KeyChainAliasCallback#alias, or null if no private key is available or the user cancels the request.</para> <para></para></li> <li> <para>Call getPrivateKey and getCertificateChain to retrieve the credentials to return to the corresponding javax.net.ssl.X509KeyManager callbacks.</para> <para></para></li></ol></para> <para>An application may remember the value of a selected alias to avoid prompting the user with choosePrivateKeyAlias on subsequent connections. If the alias is no longer valid, null will be returned on lookups using that value</para> <para>An application can request the installation of private keys and certificates via the <c>Intent </c> provided by createInstallIntent. Private keys installed via this <c>Intent </c> will be accessible via choosePrivateKeyAlias while Certificate Authority (CA) certificates will be trusted by all applications through the default <c>X509TrustManager </c> . </para>    
		/// </summary>
		/// <java-name>
		/// android/security/KeyChain
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChain", AccessFlags = 49)]
		public sealed partial class KeyChain
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Optional extra to specify a <c>String </c> credential name on the <c>Intent </c> returned by createInstallIntent. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NAME = "name";
				/// <summary>
				///  <para>Optional extra to specify an X.509 certificate to install on the <c>Intent </c> returned by createInstallIntent. The extra value should be a PEM or ASN.1 DER encoded <c>byte[] </c> . An X509Certificate can be converted to DER encoded bytes with X509Certificate#getEncoded.</para> <para>EXTRA_NAME may be used to provide a default alias name for the installed certificate. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CERTIFICATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CERTIFICATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CERTIFICATE = "CERT";
				/// <summary>
				///  <para>Optional extra for use with the <c>Intent </c> returned by createInstallIntent to specify a PKCS#12 key store to install. The extra value should be a <c>byte[] </c> . The bytes may come from an external source or be generated with java.security.KeyStore#store on a "PKCS12" instance.</para> <para>The user will be prompted for the password to load the key store.</para> <para>The key store will be scanned for java.security.KeyStore.PrivateKeyEntry entries and both the private key and associated certificate chain will be installed.</para> <para>EXTRA_NAME may be used to provide a default alias name for the installed credentials. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PKCS12
				/// </java-name>
				[Dot42.DexImport("EXTRA_PKCS12", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PKCS12 = "PKCS12";
				/// <summary>
				///  <para>Broadcast Action: Indicates the trusted storage has changed. Sent when one of this happens:</para> <para> <ul> <li> <para>a new CA is added, </para></li> <li> <para>an existing CA is removed or disabled, </para></li> <li> <para>a disabled CA is enabled, </para></li> <li> <para>trusted storage is reset (all user certs are cleared), </para></li> <li> <para>when permission to access a private key is changed. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_STORAGE_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_STORAGE_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_STORAGE_CHANGED = "android.security.STORAGE_CHANGED";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyChain() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns an <c>Intent </c> that can be used for credential installation. The intent may be used without any extras, in which case the user will be able to install credentials from their own source.</para> <para>Alternatively, EXTRA_CERTIFICATE or EXTRA_PKCS12 maybe used to specify the bytes of an X.509 certificate or a PKCS#12 key store for installation. These extras may be combined with EXTRA_NAME to provide a default alias name for credentials being installed.</para> <para>When used with Activity#startActivityForResult, Activity#RESULT_OK will be returned if a credential was successfully installed, otherwise Activity#RESULT_CANCELED will be returned. </para>        
				/// </summary>
				/// <java-name>
				/// createInstallIntent
				/// </java-name>
				[Dot42.DexImport("createInstallIntent", "()Landroid/content/Intent;", AccessFlags = 9)]
				public static global::Android.Content.Intent CreateInstallIntent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				///  <para>Launches an <c>Activity </c> for the user to select the alias for a private key and certificate pair for authentication. The selected alias or null will be returned via the KeyChainAliasCallback callback.</para> <para> <c>keyTypes </c> and <c>issuers </c> may be used to highlight suggested choices to the user, although to cope with sometimes erroneous values provided by servers, the user may be able to override these suggestions.</para> <para> <c>host </c> and <c>port </c> may be used to give the user more context about the server requesting the credentials.</para> <para> <c>alias </c> allows the chooser to preselect an existing alias which will still be subject to user confirmation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// choosePrivateKeyAlias
				/// </java-name>
				[Dot42.DexImport("choosePrivateKeyAlias", "(Landroid/app/Activity;Landroid/security/KeyChainAliasCallback;[Ljava/lang/String" +
    ";[Ljava/security/Principal;Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 9)]
				public static void ChoosePrivateKeyAlias(global::Android.App.Activity activity, global::Android.Security.IKeyChainAliasCallback response, string[] keyTypes, global::Java.Security.IPrincipal[] issuers, string host, int port, string alias) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>PrivateKey </c> for the requested alias, or null if no there is no result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getPrivateKey
				/// </java-name>
				[Dot42.DexImport("getPrivateKey", "(Landroid/content/Context;Ljava/lang/String;)Ljava/security/PrivateKey;", AccessFlags = 9)]
				public static global::Java.Security.IPrivateKey GetPrivateKey(global::Android.Content.Context context, string alias) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrivateKey);
				}

				/// <summary>
				///  <para>Returns the <c>X509Certificate </c> chain for the requested alias, or null if no there is no result.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getCertificateChain
				/// </java-name>
				[Dot42.DexImport("getCertificateChain", "(Landroid/content/Context;Ljava/lang/String;)[Ljava/security/cert/X509Certificate" +
    ";", AccessFlags = 9)]
				public static global::Java.Security.Cert.X509Certificate[] GetCertificateChain(global::Android.Content.Context context, string alias) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.X509Certificate[]);
				}

		}

		/// <summary>
		///  <para>Thrown on problems accessing the KeyChain. </para>    
		/// </summary>
		/// <java-name>
		/// android/security/KeyChainException
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChainException", AccessFlags = 33)]
		public partial class KeyChainException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>KeyChainException </c> that includes the current stack trace. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyChainException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public KeyChainException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new <c>KeyChainException </c> with the current stack trace, the specified detail message and the specified cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyChainException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyChainException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

}

