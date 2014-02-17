// Copyright (C) 2014 dot42
//
// Original filename: Android.Security.cs
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
namespace Android.Security
{
		/// <summary>
		/// <para>This provides the optional parameters that can be specified for <c> KeyStore </c> entries that work with . The Android KeyStore facility is accessed through a java.security.KeyStore API using the <c> AndroidKeyStore </c> provider. The <c> context </c> passed in may be used to pop up some UI to ask the user to unlock or initialize the Android KeyStore facility. </para><para>Any entries placed in the <c> KeyStore </c> may be retrieved later. Note that there is only one logical instance of the <c> KeyStore </c> per application UID so apps using the <c> sharedUid </c> facility will also share a <c> KeyStore </c> . </para><para>Keys may be generated using the KeyPairGenerator facility with a KeyPairGeneratorSpec to specify the entry's <c> alias </c> . A self-signed X.509 certificate will be attached to generated entries, but that may be replaced at a later time by a certificate signed by a real Certificate Authority. </para>    
		/// </summary>
		/// <java-name>
		/// android/security/KeyStoreParameter
		/// </java-name>
		[Dot42.DexImport("android/security/KeyStoreParameter", AccessFlags = 49)]
		public sealed partial class KeyStoreParameter : global::Java.Security.KeyStore.IProtectionParameter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal KeyStoreParameter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns <c> true </c> if this parameter requires entries to be encrypted on the disk. </para>        
				/// </summary>
				/// <java-name>
				/// isEncryptionRequired
				/// </java-name>
				[Dot42.DexImport("isEncryptionRequired", "()Z", AccessFlags = 1)]
				public bool IsEncryptionRequired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Builder class for KeyStoreParameter objects. </para><para>This will build protection parameters for use with the . </para><para>This can be used to require that KeyStore entries be stored encrypted. </para><para>Example:</para><para><pre>
				///        KeyStoreParameter params = new KeyStoreParameter.Builder(mContext)
				///                .setEncryptionRequired()
				///                .build();
				///        </pre> </para>    
				/// </summary>
				/// <java-name>
				/// android/security/KeyStoreParameter$Builder
				/// </java-name>
				[Dot42.DexImport("android/security/KeyStoreParameter$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
						public Builder(global::Android.Content.Context context) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Indicates that this key must be encrypted at rest on storage. Note that enabling this will require that the user enable a strong lock screen (e.g., PIN, password) before creating or using the generated key is successful. </para>        
						/// </summary>
						/// <java-name>
						/// setEncryptionRequired
						/// </java-name>
						[Dot42.DexImport("setEncryptionRequired", "(Z)Landroid/security/KeyStoreParameter$Builder;", AccessFlags = 1)]
						public Builder SetEncryptionRequired(bool required) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Builds the instance of the <c> KeyPairGeneratorSpec </c> .</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>built instance of <c> KeyPairGeneratorSpec </c> </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/security/KeyStoreParameter;", AccessFlags = 1)]
						public global::Android.Security.KeyStoreParameter Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Security.KeyStoreParameter);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>This provides the required parameters needed for initializing the <c> KeyPairGenerator </c> that works with . The Android KeyStore facility is accessed through a java.security.KeyPairGenerator API using the <c> AndroidKeyStore </c> provider. The <c> context </c> passed in may be used to pop up some UI to ask the user to unlock or initialize the Android KeyStore facility. </para><para>After generation, the <c> keyStoreAlias </c> is used with the java.security.KeyStore#getEntry(String, java.security.KeyStore.ProtectionParameter) interface to retrieve the PrivateKey and its associated Certificate chain. </para><para>The KeyPair generator will create a self-signed certificate with the subject as its X.509v3 Subject Distinguished Name and as its X.509v3 Issuer Distinguished Name along with the other parameters specified with the Builder. </para><para>The self-signed X.509 certificate may be replaced at a later time by a certificate signed by a real Certificate Authority. </para>    
		/// </summary>
		/// <java-name>
		/// android/security/KeyPairGeneratorSpec
		/// </java-name>
		[Dot42.DexImport("android/security/KeyPairGeneratorSpec", AccessFlags = 49)]
		public sealed partial class KeyPairGeneratorSpec : global::Java.Security.Spec.IAlgorithmParameterSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal KeyPairGeneratorSpec() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the alias that will be used in the <c> java.security.KeyStore </c> in conjunction with the <c> AndroidKeyStore </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getKeystoreAlias
				/// </java-name>
				[Dot42.DexImport("getKeystoreAlias", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetKeystoreAlias() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the Android context used for operations with this instance. </para>        
				/// </summary>
				/// <java-name>
				/// getContext
				/// </java-name>
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
				public global::Android.Content.Context GetContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <summary>
				/// <para>Gets the subject distinguished name to be used on the X.509 certificate that will be put in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// getSubjectDN
				/// </java-name>
				[Dot42.DexImport("getSubjectDN", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
				public global::Javax.Security.Auth.X500.X500Principal GetSubjectDN() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Auth.X500.X500Principal);
				}

				/// <summary>
				/// <para>Gets the serial number to be used on the X.509 certificate that will be put in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1)]
				public global::Java.Math.BigInteger GetSerialNumber() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Math.BigInteger);
				}

				/// <summary>
				/// <para>Gets the start date to be used on the X.509 certificate that will be put in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// getStartDate
				/// </java-name>
				[Dot42.DexImport("getStartDate", "()Ljava/util/Date;", AccessFlags = 1)]
				public global::Java.Util.Date GetStartDate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Gets the end date to be used on the X.509 certificate that will be put in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// getEndDate
				/// </java-name>
				[Dot42.DexImport("getEndDate", "()Ljava/util/Date;", AccessFlags = 1)]
				public global::Java.Util.Date GetEndDate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if this parameter will require generated keys to be encrypted in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// isEncryptionRequired
				/// </java-name>
				[Dot42.DexImport("isEncryptionRequired", "()Z", AccessFlags = 1)]
				public bool IsEncryptionRequired() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the alias that will be used in the <c> java.security.KeyStore </c> in conjunction with the <c> AndroidKeyStore </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getKeystoreAlias
				/// </java-name>
				public string KeystoreAlias
				{
				[Dot42.DexImport("getKeystoreAlias", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetKeystoreAlias(); }
				}

				/// <summary>
				/// <para>Gets the Android context used for operations with this instance. </para>        
				/// </summary>
				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return GetContext(); }
				}

				/// <summary>
				/// <para>Gets the subject distinguished name to be used on the X.509 certificate that will be put in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// getSubjectDN
				/// </java-name>
				public global::Javax.Security.Auth.X500.X500Principal SubjectDN
				{
				[Dot42.DexImport("getSubjectDN", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return GetSubjectDN(); }
				}

				/// <summary>
				/// <para>Gets the serial number to be used on the X.509 certificate that will be put in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public global::Java.Math.BigInteger SerialNumber
				{
				[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return GetSerialNumber(); }
				}

				/// <summary>
				/// <para>Gets the start date to be used on the X.509 certificate that will be put in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// getStartDate
				/// </java-name>
				public global::Java.Util.Date StartDate
				{
				[Dot42.DexImport("getStartDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return GetStartDate(); }
				}

				/// <summary>
				/// <para>Gets the end date to be used on the X.509 certificate that will be put in the java.security.KeyStore. </para>        
				/// </summary>
				/// <java-name>
				/// getEndDate
				/// </java-name>
				public global::Java.Util.Date EndDate
				{
				[Dot42.DexImport("getEndDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return GetEndDate(); }
				}

				/// <summary>
				/// <para>Builder class for KeyPairGeneratorSpec objects. </para><para>This will build a parameter spec for use with the . </para><para>The required fields must be filled in with the builder. </para><para>Example:</para><para><pre>
				///        Calendar start = new Calendar();
				///        Calendar end = new Calendar();
				///        end.add(1, Calendar.YEAR);
				/// 
				///        KeyPairGeneratorSpec spec =
				///                new KeyPairGeneratorSpec.Builder(mContext).setAlias("myKey")
				///                        .setSubject(new X500Principal("CN=myKey")).setSerial(BigInteger.valueOf(1337))
				///                        .setStartDate(start.getTime()).setEndDate(end.getTime()).build();
				///        </pre> </para>    
				/// </summary>
				/// <java-name>
				/// android/security/KeyPairGeneratorSpec$Builder
				/// </java-name>
				[Dot42.DexImport("android/security/KeyPairGeneratorSpec$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
						public Builder(global::Android.Content.Context context) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Sets the alias to be used to retrieve the key later from a java.security.KeyStore instance using the <c> AndroidKeyStore </c> provider. </para>        
						/// </summary>
						/// <java-name>
						/// setAlias
						/// </java-name>
						[Dot42.DexImport("setAlias", "(Ljava/lang/String;)Landroid/security/KeyPairGeneratorSpec$Builder;", AccessFlags = 1)]
						public Builder SetAlias(string alias) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Sets the subject used for the self-signed certificate of the generated key pair. </para>        
						/// </summary>
						/// <java-name>
						/// setSubject
						/// </java-name>
						[Dot42.DexImport("setSubject", "(Ljavax/security/auth/x500/X500Principal;)Landroid/security/KeyPairGeneratorSpec$" +
    "Builder;", AccessFlags = 1)]
						public Builder SetSubject(global::Javax.Security.Auth.X500.X500Principal subject) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Sets the serial number used for the self-signed certificate of the generated key pair. </para>        
						/// </summary>
						/// <java-name>
						/// setSerialNumber
						/// </java-name>
						[Dot42.DexImport("setSerialNumber", "(Ljava/math/BigInteger;)Landroid/security/KeyPairGeneratorSpec$Builder;", AccessFlags = 1)]
						public Builder SetSerialNumber(global::Java.Math.BigInteger serialNumber) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Sets the start of the validity period for the self-signed certificate of the generated key pair. </para>        
						/// </summary>
						/// <java-name>
						/// setStartDate
						/// </java-name>
						[Dot42.DexImport("setStartDate", "(Ljava/util/Date;)Landroid/security/KeyPairGeneratorSpec$Builder;", AccessFlags = 1)]
						public Builder SetStartDate(global::Java.Util.Date startDate) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Sets the end of the validity period for the self-signed certificate of the generated key pair. </para>        
						/// </summary>
						/// <java-name>
						/// setEndDate
						/// </java-name>
						[Dot42.DexImport("setEndDate", "(Ljava/util/Date;)Landroid/security/KeyPairGeneratorSpec$Builder;", AccessFlags = 1)]
						public Builder SetEndDate(global::Java.Util.Date endDate) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Indicates that this key must be encrypted at rest on storage. Note that enabling this will require that the user enable a strong lock screen (e.g., PIN, password) before creating or using the generated key is successful. </para>        
						/// </summary>
						/// <java-name>
						/// setEncryptionRequired
						/// </java-name>
						[Dot42.DexImport("setEncryptionRequired", "()Landroid/security/KeyPairGeneratorSpec$Builder;", AccessFlags = 1)]
						public Builder SetEncryptionRequired() /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Builds the instance of the <c> KeyPairGeneratorSpec </c> .</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>built instance of <c> KeyPairGeneratorSpec </c> </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/security/KeyPairGeneratorSpec;", AccessFlags = 1)]
						public global::Android.Security.KeyPairGeneratorSpec Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Security.KeyPairGeneratorSpec);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>Thrown on problems accessing the KeyChain. </para>    
		/// </summary>
		/// <java-name>
		/// android/security/KeyChainException
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChainException", AccessFlags = 33)]
		public partial class KeyChainException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructs a new <c> KeyChainException </c> that includes the current stack trace. </para>        
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
				/// <para>Constructs a new <c> KeyChainException </c> with the current stack trace, the specified detail message and the specified cause.</para><para></para>        
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

		/// <summary>
		/// <para>The <c> KeyChain </c> class provides access to private keys and their corresponding certificate chains in credential storage.</para><para>Applications accessing the <c> KeyChain </c> normally go through these steps:</para><para><ol><li><para>Receive a callback from an X509KeyManager that a private key is requested.</para><para></para></li><li><para>Call choosePrivateKeyAlias to allow the user to select from a list of currently available private keys and corresponding certificate chains. The chosen alias will be returned by the callback KeyChainAliasCallback#alias, or null if no private key is available or the user cancels the request.</para><para></para></li><li><para>Call getPrivateKey and getCertificateChain to retrieve the credentials to return to the corresponding javax.net.ssl.X509KeyManager callbacks.</para><para></para></li></ol></para><para>An application may remember the value of a selected alias to avoid prompting the user with choosePrivateKeyAlias on subsequent connections. If the alias is no longer valid, null will be returned on lookups using that value</para><para>An application can request the installation of private keys and certificates via the <c> Intent </c> provided by createInstallIntent. Private keys installed via this <c>   Intent </c> will be accessible via choosePrivateKeyAlias while Certificate Authority (CA) certificates will be trusted by all applications through the default <c> X509TrustManager </c> . </para>    
		/// </summary>
		/// <java-name>
		/// android/security/KeyChain
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChain", AccessFlags = 49)]
		public sealed partial class KeyChain
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Optional extra to specify a <c> String </c> credential name on the <c> Intent </c> returned by createInstallIntent. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NAME
				/// </java-name>
				[Dot42.DexImport("EXTRA_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NAME = "name";
				/// <summary>
				/// <para>Optional extra to specify an X.509 certificate to install on the <c> Intent </c> returned by createInstallIntent. The extra value should be a PEM or ASN.1 DER encoded <c>       byte[] </c> . An X509Certificate can be converted to DER encoded bytes with X509Certificate#getEncoded.</para><para>EXTRA_NAME may be used to provide a default alias name for the installed certificate. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CERTIFICATE
				/// </java-name>
				[Dot42.DexImport("EXTRA_CERTIFICATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CERTIFICATE = "CERT";
				/// <summary>
				/// <para>Optional extra for use with the <c> Intent </c> returned by createInstallIntent to specify a PKCS#12 key store to install. The extra value should be a <c> byte[] </c> . The bytes may come from an external source or be generated with java.security.KeyStore#store on a "PKCS12" instance.</para><para>The user will be prompted for the password to load the key store.</para><para>The key store will be scanned for java.security.KeyStore.PrivateKeyEntry entries and both the private key and associated certificate chain will be installed.</para><para>EXTRA_NAME may be used to provide a default alias name for the installed credentials. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_PKCS12
				/// </java-name>
				[Dot42.DexImport("EXTRA_PKCS12", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_PKCS12 = "PKCS12";
				/// <summary>
				/// <para>Broadcast Action: Indicates the trusted storage has changed. Sent when one of this happens:</para><para><ul><li><para>a new CA is added, </para></li><li><para>an existing CA is removed or disabled, </para></li><li><para>a disabled CA is enabled, </para></li><li><para>trusted storage is reset (all user certs are cleared), </para></li><li><para>when permission to access a private key is changed. </para></li></ul></para>        
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
				/// <para>Returns an <c> Intent </c> that can be used for credential installation. The intent may be used without any extras, in which case the user will be able to install credentials from their own source.</para><para>Alternatively, EXTRA_CERTIFICATE or EXTRA_PKCS12 maybe used to specify the bytes of an X.509 certificate or a PKCS#12 key store for installation. These extras may be combined with EXTRA_NAME to provide a default alias name for credentials being installed.</para><para>When used with Activity#startActivityForResult, Activity#RESULT_OK will be returned if a credential was successfully installed, otherwise Activity#RESULT_CANCELED will be returned. </para>        
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
				/// <para>Launches an <c> Activity </c> for the user to select the alias for a private key and certificate pair for authentication. The selected alias or null will be returned via the KeyChainAliasCallback callback.</para><para><c> keyTypes </c> and <c> issuers </c> may be used to highlight suggested choices to the user, although to cope with sometimes erroneous values provided by servers, the user may be able to override these suggestions.</para><para><c> host </c> and <c> port </c> may be used to give the user more context about the server requesting the credentials.</para><para><c> alias </c> allows the chooser to preselect an existing alias which will still be subject to user confirmation.</para><para></para>        
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
				/// <para>Returns the <c> PrivateKey </c> for the requested alias, or null if no there is no result.</para><para></para>        
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
				/// <para>Returns the <c> X509Certificate </c> chain for the requested alias, or null if no there is no result.</para><para></para>        
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

				/// <summary>
				/// <para>Returns <c> true </c> if the current device's <c> KeyChain </c> supports a specific <c> PrivateKey </c> type indicated by <c> algorithm </c> (e.g., "RSA"). </para>        
				/// </summary>
				/// <java-name>
				/// isKeyAlgorithmSupported
				/// </java-name>
				[Dot42.DexImport("isKeyAlgorithmSupported", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsKeyAlgorithmSupported(string algorithm) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns <c> true </c> if the current device's <c> KeyChain </c> binds any <c> PrivateKey </c> of the given <c> algorithm </c> to the device once imported or generated. This can be used to tell if there is special hardware support that can be used to bind keys to the device in a way that makes it non-exportable. </para>        
				/// </summary>
				/// <java-name>
				/// isBoundKeyAlgorithm
				/// </java-name>
				[Dot42.DexImport("isBoundKeyAlgorithm", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsBoundKeyAlgorithm(string algorithm) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>The KeyChainAliasCallback is the callback for KeyChain#choosePrivateKeyAlias. </para>    
		/// </summary>
		/// <java-name>
		/// android/security/KeyChainAliasCallback
		/// </java-name>
		[Dot42.DexImport("android/security/KeyChainAliasCallback", AccessFlags = 1537)]
		public partial interface IKeyChainAliasCallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called with the alias of the certificate chosen by the user, or null if no value was chosen. </para>        
				/// </summary>
				/// <java-name>
				/// alias
				/// </java-name>
				[Dot42.DexImport("alias", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void Alias(string alias) /* MethodBuilder.Create */ ;

		}

}


