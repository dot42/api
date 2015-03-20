#pragma warning disable 1717
namespace Java.Security
{
		/// <java-name>
		/// java/security/Guard
		/// </java-name>
		[Dot42.DexImport("java/security/Guard", AccessFlags = 1537)]
		public partial interface IGuard
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// checkGuard
				/// </java-name>
				[Dot42.DexImport("checkGuard", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void CheckGuard(object @object) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/PolicySpi
		/// </java-name>
		[Dot42.DexImport("java/security/PolicySpi", AccessFlags = 1057)]
		public abstract partial class PolicySpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PolicySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineImplies
				/// </java-name>
				[Dot42.DexImport("engineImplies", "(Ljava/security/ProtectionDomain;Ljava/security/Permission;)Z", AccessFlags = 1028)]
				protected internal abstract bool EngineImplies(global::Java.Security.ProtectionDomain protectionDomain, global::Java.Security.Permission permission) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineRefresh
				/// </java-name>
				[Dot42.DexImport("engineRefresh", "()V", AccessFlags = 4)]
				protected internal virtual void EngineRefresh() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGetPermissions
				/// </java-name>
				[Dot42.DexImport("engineGetPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.PermissionCollection EngineGetPermissions(global::Java.Security.CodeSource codeSource) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// engineGetPermissions
				/// </java-name>
				[Dot42.DexImport("engineGetPermissions", "(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.PermissionCollection EngineGetPermissions(global::Java.Security.ProtectionDomain protectionDomain) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

		}

		/// <java-name>
		/// java/security/UnrecoverableEntryException
		/// </java-name>
		[Dot42.DexImport("java/security/UnrecoverableEntryException", AccessFlags = 33)]
		public partial class UnrecoverableEntryException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnrecoverableEntryException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnrecoverableEntryException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/CodeSource
		/// </java-name>
		[Dot42.DexImport("java/security/CodeSource", AccessFlags = 33)]
		public partial class CodeSource : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V", AccessFlags = 1)]
				public CodeSource(global::Java.Net.URL uRL, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V", AccessFlags = 1)]
				public CodeSource(global::Java.Net.URL uRL, global::Java.Security.CodeSigner[] codeSigner) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCertificates
				/// </java-name>
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 17)]
				public global::Java.Security.Cert.Certificate[] GetCertificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <java-name>
				/// getCodeSigners
				/// </java-name>
				[Dot42.DexImport("getCodeSigners", "()[Ljava/security/CodeSigner;", AccessFlags = 17)]
				public global::Java.Security.CodeSigner[] GetCodeSigners() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.CodeSigner[]);
				}

				/// <java-name>
				/// getLocation
				/// </java-name>
				[Dot42.DexImport("getLocation", "()Ljava/net/URL;", AccessFlags = 17)]
				public global::Java.Net.URL GetLocation() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/CodeSource;)Z", AccessFlags = 1)]
				public virtual bool Implies(global::Java.Security.CodeSource codeSource) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CodeSource() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCertificates
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] Certificates
				{
				[Dot42.DexImport("getCertificates", "()[Ljava/security/cert/Certificate;", AccessFlags = 17)]
						get{ return GetCertificates(); }
				}

				/// <java-name>
				/// getCodeSigners
				/// </java-name>
				public global::Java.Security.CodeSigner[] CodeSigners
				{
				[Dot42.DexImport("getCodeSigners", "()[Ljava/security/CodeSigner;", AccessFlags = 17)]
						get{ return GetCodeSigners(); }
				}

				/// <java-name>
				/// getLocation
				/// </java-name>
				public global::Java.Net.URL Location
				{
				[Dot42.DexImport("getLocation", "()Ljava/net/URL;", AccessFlags = 17)]
						get{ return GetLocation(); }
				}

		}

		/// <java-name>
		/// java/security/KeyStoreException
		/// </java-name>
		[Dot42.DexImport("java/security/KeyStoreException", AccessFlags = 33)]
		public partial class KeyStoreException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public KeyStoreException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyStoreException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyStoreException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyStoreException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/AlgorithmParameterGenerator
		/// </java-name>
		[Dot42.DexImport("java/security/AlgorithmParameterGenerator", AccessFlags = 33)]
		public partial class AlgorithmParameterGenerator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/AlgorithmParameterGeneratorSpi;Ljava/security/Provider;Ljava/lang" +
    "/String;)V", AccessFlags = 4)]
				protected internal AlgorithmParameterGenerator(global::Java.Security.AlgorithmParameterGeneratorSpi algorithmParameterGeneratorSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;", AccessFlags = 9)]
				public static global::Java.Security.AlgorithmParameterGenerator GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameterGenerator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;" +
    "", AccessFlags = 9)]
				public static global::Java.Security.AlgorithmParameterGenerator GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameterGenerator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameterGene" +
    "rator;", AccessFlags = 9)]
				public static global::Java.Security.AlgorithmParameterGenerator GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameterGenerator);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(I)V", AccessFlags = 17)]
				public void Init(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(int int32, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateParameters
				/// </java-name>
				[Dot42.DexImport("generateParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 17)]
				public global::Java.Security.AlgorithmParameters GenerateParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AlgorithmParameterGenerator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

		}

		/// <java-name>
		/// java/security/SignedObject
		/// </java-name>
		[Dot42.DexImport("java/security/SignedObject", AccessFlags = 49)]
		public sealed partial class SignedObject : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/io/Serializable;Ljava/security/PrivateKey;Ljava/security/Signature;)V", AccessFlags = 1)]
				public SignedObject(global::Java.Io.ISerializable serializable, global::Java.Security.IPrivateKey privateKey, global::Java.Security.Signature signature) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object GetObject() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getSignature
				/// </java-name>
				[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetSignature() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getSignature
				/// </java-name>
				[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetSignature() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;Ljava/security/Signature;)Z", AccessFlags = 1)]
				public bool Verify(global::Java.Security.IPublicKey publicKey, global::Java.Security.Signature signature) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SignedObject() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getObject
				/// </java-name>
				public object Object
				{
				[Dot42.DexImport("getObject", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetObject(); }
				}

				/// <java-name>
				/// getSignature
				/// </java-name>
				public byte[] Signature
				{
				[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetSignature(); }
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAlgorithm(); }
				}

		}

		/// <java-name>
		/// java/security/ProtectionDomain
		/// </java-name>
		[Dot42.DexImport("java/security/ProtectionDomain", AccessFlags = 33)]
		public partial class ProtectionDomain
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V", AccessFlags = 1)]
				public ProtectionDomain(global::Java.Security.CodeSource codeSource, global::Java.Security.PermissionCollection permissionCollection) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLo" +
    "ader;[Ljava/security/Principal;)V", AccessFlags = 1)]
				public ProtectionDomain(global::Java.Security.CodeSource codeSource, global::Java.Security.PermissionCollection permissionCollection, global::Java.Lang.ClassLoader classLoader, global::Java.Security.IPrincipal[] principal) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 17)]
				public global::Java.Lang.ClassLoader GetClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <java-name>
				/// getCodeSource
				/// </java-name>
				[Dot42.DexImport("getCodeSource", "()Ljava/security/CodeSource;", AccessFlags = 17)]
				public global::Java.Security.CodeSource GetCodeSource() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.CodeSource);
				}

				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "()Ljava/security/PermissionCollection;", AccessFlags = 17)]
				public global::Java.Security.PermissionCollection GetPermissions() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// getPrincipals
				/// </java-name>
				[Dot42.DexImport("getPrincipals", "()[Ljava/security/Principal;", AccessFlags = 17)]
				public global::Java.Security.IPrincipal[] GetPrincipals() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal[]);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public virtual bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProtectionDomain() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				public global::Java.Lang.ClassLoader ClassLoader
				{
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 17)]
						get{ return GetClassLoader(); }
				}

				/// <java-name>
				/// getCodeSource
				/// </java-name>
				public global::Java.Security.CodeSource CodeSource
				{
				[Dot42.DexImport("getCodeSource", "()Ljava/security/CodeSource;", AccessFlags = 17)]
						get{ return GetCodeSource(); }
				}

				/// <java-name>
				/// getPermissions
				/// </java-name>
				public global::Java.Security.PermissionCollection Permissions
				{
				[Dot42.DexImport("getPermissions", "()Ljava/security/PermissionCollection;", AccessFlags = 17)]
						get{ return GetPermissions(); }
				}

				/// <java-name>
				/// getPrincipals
				/// </java-name>
				public global::Java.Security.IPrincipal[] Principals
				{
				[Dot42.DexImport("getPrincipals", "()[Ljava/security/Principal;", AccessFlags = 17)]
						get{ return GetPrincipals(); }
				}

		}

		/// <java-name>
		/// java/security/AccessController
		/// </java-name>
		[Dot42.DexImport("java/security/AccessController", AccessFlags = 49)]
		public sealed partial class AccessController
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessController() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doPrivileged
				/// </java-name>
				[Dot42.DexImport("doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedAction<TT;>;)TT;")]
				public static T DoPrivileged<T>(global::Java.Security.IPrivilegedAction<T> privilegedAction) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// doPrivileged
				/// </java-name>
				[Dot42.DexImport("doPrivileged", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/" +
    "Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedAction<TT;>;Ljava/security/Access" +
    "ControlContext;)TT;")]
				public static T DoPrivileged<T>(global::Java.Security.IPrivilegedAction<T> privilegedAction, global::Java.Security.AccessControlContext accessControlContext) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// doPrivileged
				/// </java-name>
				[Dot42.DexImport("doPrivileged", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedExceptionAction<TT;>;)TT;")]
				public static T DoPrivileged<T>(global::Java.Security.IPrivilegedExceptionAction<T> privilegedExceptionAction) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// doPrivileged
				/// </java-name>
				[Dot42.DexImport("doPrivileged", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Lj" +
    "ava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedExceptionAction<TT;>;Ljava/securi" +
    "ty/AccessControlContext;)TT;")]
				public static T DoPrivileged<T>(global::Java.Security.IPrivilegedExceptionAction<T> privilegedExceptionAction, global::Java.Security.AccessControlContext accessControlContext) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// doPrivilegedWithCombiner
				/// </java-name>
				[Dot42.DexImport("doPrivilegedWithCombiner", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedAction<TT;>;)TT;")]
				public static T DoPrivilegedWithCombiner<T>(global::Java.Security.IPrivilegedAction<T> privilegedAction) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// doPrivilegedWithCombiner
				/// </java-name>
				[Dot42.DexImport("doPrivilegedWithCombiner", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedExceptionAction<TT;>;)TT;")]
				public static T DoPrivilegedWithCombiner<T>(global::Java.Security.IPrivilegedExceptionAction<T> privilegedExceptionAction) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/Permission;)V", AccessFlags = 9)]
				public static void CheckPermission(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				[Dot42.DexImport("getContext", "()Ljava/security/AccessControlContext;", AccessFlags = 9)]
				public static global::Java.Security.AccessControlContext GetContext() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AccessControlContext);
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public static global::Java.Security.AccessControlContext Context
				{
				[Dot42.DexImport("getContext", "()Ljava/security/AccessControlContext;", AccessFlags = 9)]
						get{ return GetContext(); }
				}

		}

		/// <java-name>
		/// java/security/PrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/PrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 6034044314589513430;
		}

		/// <java-name>
		/// java/security/PrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/PrivateKey", AccessFlags = 1537)]
		public partial interface IPrivateKey : global::Java.Security.IKey
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/security/AlgorithmParameterGeneratorSpi
		/// </java-name>
		[Dot42.DexImport("java/security/AlgorithmParameterGeneratorSpi", AccessFlags = 1057)]
		public abstract partial class AlgorithmParameterGeneratorSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AlgorithmParameterGeneratorSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int int32, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateParameters
				/// </java-name>
				[Dot42.DexImport("engineGenerateParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.AlgorithmParameters EngineGenerateParameters() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/KeyPair
		/// </java-name>
		[Dot42.DexImport("java/security/KeyPair", AccessFlags = 49)]
		public sealed partial class KeyPair : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/PublicKey;Ljava/security/PrivateKey;)V", AccessFlags = 1)]
				public KeyPair(global::Java.Security.IPublicKey publicKey, global::Java.Security.IPrivateKey privateKey) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrivate
				/// </java-name>
				[Dot42.DexImport("getPrivate", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
				public global::Java.Security.IPrivateKey GetPrivate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrivateKey);
				}

				/// <java-name>
				/// getPublic
				/// </java-name>
				[Dot42.DexImport("getPublic", "()Ljava/security/PublicKey;", AccessFlags = 1)]
				public global::Java.Security.IPublicKey GetPublic() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPublicKey);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyPair() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPrivate
				/// </java-name>
				public global::Java.Security.IPrivateKey Private
				{
				[Dot42.DexImport("getPrivate", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
						get{ return GetPrivate(); }
				}

				/// <java-name>
				/// getPublic
				/// </java-name>
				public global::Java.Security.IPublicKey Public
				{
				[Dot42.DexImport("getPublic", "()Ljava/security/PublicKey;", AccessFlags = 1)]
						get{ return GetPublic(); }
				}

		}

		/// <java-name>
		/// java/security/Signature
		/// </java-name>
		[Dot42.DexImport("java/security/Signature", AccessFlags = 1057)]
		public abstract partial class Signature : global::Java.Security.SignatureSpi
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNINITIALIZED
				/// </java-name>
				[Dot42.DexImport("UNINITIALIZED", "I", AccessFlags = 28)]
				protected internal const int UNINITIALIZED = 0;
				/// <java-name>
				/// SIGN
				/// </java-name>
				[Dot42.DexImport("SIGN", "I", AccessFlags = 28)]
				protected internal const int SIGN = 2;
				/// <java-name>
				/// VERIFY
				/// </java-name>
				[Dot42.DexImport("VERIFY", "I", AccessFlags = 28)]
				protected internal const int VERIFY = 3;
				/// <java-name>
				/// state
				/// </java-name>
				[Dot42.DexImport("state", "I", AccessFlags = 4)]
				protected internal int State;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Signature(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/Signature;", AccessFlags = 9)]
				public static global::Java.Security.Signature GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Signature);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Signature;", AccessFlags = 9)]
				public static global::Java.Security.Signature GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Signature);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/Signature;", AccessFlags = 9)]
				public static global::Java.Security.Signature GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Signature);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// initVerify
				/// </java-name>
				[Dot42.DexImport("initVerify", "(Ljava/security/PublicKey;)V", AccessFlags = 17)]
				public void InitVerify(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initVerify
				/// </java-name>
				[Dot42.DexImport("initVerify", "(Ljava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void InitVerify(global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initSign
				/// </java-name>
				[Dot42.DexImport("initSign", "(Ljava/security/PrivateKey;)V", AccessFlags = 17)]
				public void InitSign(global::Java.Security.IPrivateKey privateKey) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initSign
				/// </java-name>
				[Dot42.DexImport("initSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void InitSign(global::Java.Security.IPrivateKey privateKey, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sign
				/// </java-name>
				[Dot42.DexImport("sign", "()[B", AccessFlags = 17)]
				public sbyte[] JavaSign() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// sign
				/// </java-name>
				[Dot42.DexImport("sign", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Sign() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// sign
				/// </java-name>
				[Dot42.DexImport("sign", "([BII)I", AccessFlags = 17)]
				public int Sign(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// sign
				/// </java-name>
				[Dot42.DexImport("sign", "([BII)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int Sign(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "([B)Z", AccessFlags = 17)]
				public bool Verify(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "([B)Z", AccessFlags = 17, IgnoreFromJava = true)]
				public bool Verify(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "([BII)Z", AccessFlags = 17)]
				public bool Verify(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "([BII)Z", AccessFlags = 17, IgnoreFromJava = true)]
				public bool Verify(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 17)]
				public void Update(sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 17)]
				public void Update(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 17)]
				public void Update(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 17)]
				public void Update(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 17)]
				public void SetParameter(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void SetParameter(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 17)]
				public global::Java.Security.AlgorithmParameters GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Signature() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Security.AlgorithmParameters Parameters
				{
				[Dot42.DexImport("getParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 17)]
						get{ return GetParameters(); }
				}

		}

		/// <java-name>
		/// java/security/KeyManagementException
		/// </java-name>
		[Dot42.DexImport("java/security/KeyManagementException", AccessFlags = 33)]
		public partial class KeyManagementException : global::Java.Security.KeyException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public KeyManagementException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyManagementException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyManagementException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyManagementException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/KeyRep
		/// </java-name>
		[Dot42.DexImport("java/security/KeyRep", AccessFlags = 33)]
		public partial class KeyRep : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/KeyRep$Type;Ljava/lang/String;Ljava/lang/String;[B)V", AccessFlags = 1)]
				public KeyRep(global::Java.Security.KeyRep.Type type, string @string, string string1, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyRep$Type;Ljava/lang/String;Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public KeyRep(global::Java.Security.KeyRep.Type type, string @string, string string1, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// readResolve
				/// </java-name>
				[Dot42.DexImport("readResolve", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ReadResolve() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyRep() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// java/security/KeyRep$Type
				/// </java-name>
				[Dot42.DexImport("java/security/KeyRep$Type", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/security/KeyRep$Type;>;")]
				public sealed class Type
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// PRIVATE
						/// </java-name>
						[Dot42.DexImport("PRIVATE", "Ljava/security/KeyRep$Type;", AccessFlags = 16409)]
						public static readonly Type PRIVATE;
						/// <java-name>
						/// PUBLIC
						/// </java-name>
						[Dot42.DexImport("PUBLIC", "Ljava/security/KeyRep$Type;", AccessFlags = 16409)]
						public static readonly Type PUBLIC;
						/// <java-name>
						/// SECRET
						/// </java-name>
						[Dot42.DexImport("SECRET", "Ljava/security/KeyRep$Type;", AccessFlags = 16409)]
						public static readonly Type SECRET;
						private Type() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Ljava/security/KeyRep$Type;", AccessFlags = 9)]
						public static Type[] Values() /* MethodBuilder.Create */ 
						{
								return default(Type[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/security/KeyRep$Type;", AccessFlags = 9)]
						public static Type ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Type);
						}

				}

		}

		/// <java-name>
		/// java/security/SignatureSpi
		/// </java-name>
		[Dot42.DexImport("java/security/SignatureSpi", AccessFlags = 1057)]
		public abstract partial class SignatureSpi
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// appRandom
				/// </java-name>
				[Dot42.DexImport("appRandom", "Ljava/security/SecureRandom;", AccessFlags = 4)]
				protected internal global::Java.Security.SecureRandom AppRandom;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SignatureSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineInitVerify
				/// </java-name>
				[Dot42.DexImport("engineInitVerify", "(Ljava/security/PublicKey;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInitVerify(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInitSign
				/// </java-name>
				[Dot42.DexImport("engineInitSign", "(Ljava/security/PrivateKey;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInitSign(global::Java.Security.IPrivateKey privateKey) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInitSign
				/// </java-name>
				[Dot42.DexImport("engineInitSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V", AccessFlags = 4)]
				protected internal virtual void EngineInitSign(global::Java.Security.IPrivateKey privateKey, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 4)]
				protected internal virtual void EngineUpdate(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineSign
				/// </java-name>
				[Dot42.DexImport("engineSign", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineSign() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSign
				/// </java-name>
				[Dot42.DexImport("engineSign", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineSign() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSign
				/// </java-name>
				[Dot42.DexImport("engineSign", "([BII)I", AccessFlags = 4)]
				protected internal virtual int EngineSign(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// engineSign
				/// </java-name>
				[Dot42.DexImport("engineSign", "([BII)I", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual int EngineSign(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// engineVerify
				/// </java-name>
				[Dot42.DexImport("engineVerify", "([B)Z", AccessFlags = 1028)]
				protected internal abstract bool EngineVerify(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineVerify
				/// </java-name>
				[Dot42.DexImport("engineVerify", "([B)Z", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract bool EngineVerify(byte[] @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineVerify
				/// </java-name>
				[Dot42.DexImport("engineVerify", "([BII)Z", AccessFlags = 4)]
				protected internal virtual bool EngineVerify(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// engineVerify
				/// </java-name>
				[Dot42.DexImport("engineVerify", "([BII)Z", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual bool EngineVerify(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// engineSetParameter
				/// </java-name>
				[Dot42.DexImport("engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1028)]
				protected internal abstract void EngineSetParameter(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSetParameter
				/// </java-name>
				[Dot42.DexImport("engineSetParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 4)]
				protected internal virtual void EngineSetParameter(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGetParameters
				/// </java-name>
				[Dot42.DexImport("engineGetParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.AlgorithmParameters EngineGetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				/// <java-name>
				/// engineGetParameter
				/// </java-name>
				[Dot42.DexImport("engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1028)]
				protected internal abstract object EngineGetParameter(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <java-name>
		/// java/security/AlgorithmParametersSpi
		/// </java-name>
		[Dot42.DexImport("java/security/AlgorithmParametersSpi", AccessFlags = 1057)]
		public abstract partial class AlgorithmParametersSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AlgorithmParametersSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([B)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineInit(byte[] @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([BLjava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(sbyte[] sByte, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([BLjava/lang/String;)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineInit(byte[] @byte, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetParameterSpec
				/// </java-name>
				[Dot42.DexImport("engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1028, Signature = "<T::Ljava/security/spec/AlgorithmParameterSpec;>(Ljava/lang/Class<TT;>;)TT;")]
				protected internal abstract T EngineGetParameterSpec<T>(global::System.Type type) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetEncoded
				/// </java-name>
				[Dot42.DexImport("engineGetEncoded", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGetEncoded() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetEncoded
				/// </java-name>
				[Dot42.DexImport("engineGetEncoded", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGetEncoded() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetEncoded
				/// </java-name>
				[Dot42.DexImport("engineGetEncoded", "(Ljava/lang/String;)[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGetEncoded(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetEncoded
				/// </java-name>
				[Dot42.DexImport("engineGetEncoded", "(Ljava/lang/String;)[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGetEncoded(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineToString
				/// </java-name>
				[Dot42.DexImport("engineToString", "()Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string EngineToString() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/Signer
		/// </java-name>
		[Dot42.DexImport("java/security/Signer", AccessFlags = 1057)]
		public abstract partial class Signer : global::Java.Security.Identity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Signer() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Signer(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V", AccessFlags = 1)]
				public Signer(string @string, global::Java.Security.IdentityScope identityScope) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrivateKey
				/// </java-name>
				[Dot42.DexImport("getPrivateKey", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrivateKey GetPrivateKey() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrivateKey);
				}

				/// <java-name>
				/// setKeyPair
				/// </java-name>
				[Dot42.DexImport("setKeyPair", "(Ljava/security/KeyPair;)V", AccessFlags = 17)]
				public void SetKeyPair(global::Java.Security.KeyPair keyPair) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPrivateKey
				/// </java-name>
				public global::Java.Security.IPrivateKey PrivateKey
				{
				[Dot42.DexImport("getPrivateKey", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
						get{ return GetPrivateKey(); }
				}

		}

		/// <java-name>
		/// java/security/Permission
		/// </java-name>
		[Dot42.DexImport("java/security/Permission", AccessFlags = 1057)]
		public abstract partial class Permission : global::Java.Security.IGuard, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Permission(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// checkGuard
				/// </java-name>
				[Dot42.DexImport("checkGuard", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void CheckGuard(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newPermissionCollection
				/// </java-name>
				[Dot42.DexImport("newPermissionCollection", "()Ljava/security/PermissionCollection;", AccessFlags = 1)]
				public virtual global::Java.Security.PermissionCollection NewPermissionCollection() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetActions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1025)]
				public abstract bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Permission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/security/BasicPermission
		/// </java-name>
		[Dot42.DexImport("java/security/BasicPermission", AccessFlags = 1057)]
		public abstract partial class BasicPermission : global::Java.Security.Permission, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicPermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/security/Provider
		/// </java-name>
		[Dot42.DexImport("java/security/Provider", AccessFlags = 1057)]
		public abstract partial class Provider : global::Java.Util.Properties
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;DLjava/lang/String;)V", AccessFlags = 4)]
				protected internal Provider(string @string, double @double, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()D", AccessFlags = 1)]
				public virtual double GetVersion() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				[Dot42.DexImport("getInfo", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetInfo() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 33)]
				public override void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/InputStream;)V", AccessFlags = 33)]
				public override void Load(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<**>;)V")]
				public override void PutAll(global::Java.Util.IMap<object, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// entrySet
				/// </java-name>
				[Dot42.DexImport("entrySet", "()Ljava/util/Set;", AccessFlags = 33, Signature = "()Ljava/util/Set<Ljava/util/Map$Entry<Ljava/lang/Object;Ljava/lang/Object;>;>;")]
				public override global::Java.Util.ISet<global::Java.Util.IMap_IEntry<object, object>> EntrySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Util.IMap_IEntry<object, object>>);
				}

				/// <java-name>
				/// keySet
				/// </java-name>
				[Dot42.DexImport("keySet", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
				public override global::Java.Util.ISet<object> KeySet() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<object>);
				}

				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/lang/Object;>;")]
				public override global::Java.Util.ICollection<object> Values() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<object>);
				}

				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33)]
				public override object Put(object @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33)]
				public override object Remove(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getService
				/// </java-name>
				[Dot42.DexImport("getService", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Provider$Service;", AccessFlags = 33)]
				public virtual global::Java.Security.Provider.Service GetService(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider.Service);
				}

				/// <java-name>
				/// getServices
				/// </java-name>
				[Dot42.DexImport("getServices", "()Ljava/util/Set;", AccessFlags = 33, Signature = "()Ljava/util/Set<Ljava/security/Provider$Service;>;")]
				public virtual global::Java.Util.ISet<global::Java.Security.Provider.Service> GetServices() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Security.Provider.Service>);
				}

				/// <java-name>
				/// putService
				/// </java-name>
				[Dot42.DexImport("putService", "(Ljava/security/Provider$Service;)V", AccessFlags = 36)]
				protected internal virtual void PutService(global::Java.Security.Provider.Service service) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeService
				/// </java-name>
				[Dot42.DexImport("removeService", "(Ljava/security/Provider$Service;)V", AccessFlags = 36)]
				protected internal virtual void RemoveService(global::Java.Security.Provider.Service service) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Provider() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public double Version
				{
				[Dot42.DexImport("getVersion", "()D", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				public string Info
				{
				[Dot42.DexImport("getInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetInfo(); }
				}

				/// <java-name>
				/// getServices
				/// </java-name>
				public global::Java.Util.ISet<global::Java.Security.Provider.Service> Services
				{
				[Dot42.DexImport("getServices", "()Ljava/util/Set;", AccessFlags = 33, Signature = "()Ljava/util/Set<Ljava/security/Provider$Service;>;")]
						get{ return GetServices(); }
				}

				/// <java-name>
				/// java/security/Provider$Service
				/// </java-name>
				[Dot42.DexImport("java/security/Provider$Service", AccessFlags = 9)]
				public partial class Service
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lj" +
    "ava/util/List;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lj" +
    "ava/util/List<Ljava/lang/String;>;Ljava/util/Map<Ljava/lang/String;Ljava/lang/St" +
    "ring;>;)V")]
						public Service(global::Java.Security.Provider provider, string @string, string string1, string string2, global::Java.Util.IList<string> list, global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getType
						/// </java-name>
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
						public string GetType() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getAlgorithm
						/// </java-name>
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						public string GetAlgorithm() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getProvider
						/// </java-name>
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Security.Provider);
						}

						/// <java-name>
						/// getClassName
						/// </java-name>
						[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 17)]
						public string GetClassName() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// getAttribute
						/// </java-name>
						[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 17)]
						public string GetAttribute(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// newInstance
						/// </java-name>
						[Dot42.DexImport("newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
						public virtual object NewInstance(object @object) /* MethodBuilder.Create */ 
						{
								return default(object);
						}

						/// <java-name>
						/// supportsParameter
						/// </java-name>
						[Dot42.DexImport("supportsParameter", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
						public virtual bool SupportsParameter(object @object) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Service() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getType
						/// </java-name>
						public string Type
						{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
								get{ return GetType(); }
						}

						/// <java-name>
						/// getAlgorithm
						/// </java-name>
						public string Algorithm
						{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
								get{ return GetAlgorithm(); }
						}

						/// <java-name>
						/// getProvider
						/// </java-name>
						public global::Java.Security.Provider Provider
						{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
								get{ return GetProvider(); }
						}

						/// <java-name>
						/// getClassName
						/// </java-name>
						public string ClassName
						{
						[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 17)]
								get{ return GetClassName(); }
						}

				}

		}

		/// <java-name>
		/// java/security/SignatureException
		/// </java-name>
		[Dot42.DexImport("java/security/SignatureException", AccessFlags = 33)]
		public partial class SignatureException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SignatureException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SignatureException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SignatureException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SignatureException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/InvalidAlgorithmParameterException
		/// </java-name>
		[Dot42.DexImport("java/security/InvalidAlgorithmParameterException", AccessFlags = 33)]
		public partial class InvalidAlgorithmParameterException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidAlgorithmParameterException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidAlgorithmParameterException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidAlgorithmParameterException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidAlgorithmParameterException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/AuthProvider
		/// </java-name>
		[Dot42.DexImport("java/security/AuthProvider", AccessFlags = 1057)]
		public abstract partial class AuthProvider : global::Java.Security.Provider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;DLjava/lang/String;)V", AccessFlags = 4)]
				protected internal AuthProvider(string @string, double @double, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// login
				/// </java-name>
				[Dot42.DexImport("login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V", AccessFlags = 1025)]
				public abstract void Login(global::Javax.Security.Auth.Subject subject, global::Javax.Security.Auth.Callback.ICallbackHandler callbackHandler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// logout
				/// </java-name>
				[Dot42.DexImport("logout", "()V", AccessFlags = 1025)]
				public abstract void Logout() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCallbackHandler
				/// </java-name>
				[Dot42.DexImport("setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V", AccessFlags = 1025)]
				public abstract void SetCallbackHandler(global::Javax.Security.Auth.Callback.ICallbackHandler callbackHandler) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AuthProvider() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/security/KeyFactory
		/// </java-name>
		[Dot42.DexImport("java/security/KeyFactory", AccessFlags = 33)]
		public partial class KeyFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/KeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyFactory(global::Java.Security.KeyFactorySpi keyFactorySpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/KeyFactory;", AccessFlags = 9)]
				public static global::Java.Security.KeyFactory GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyFactory;", AccessFlags = 9)]
				public static global::Java.Security.KeyFactory GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyFactory;", AccessFlags = 9)]
				public static global::Java.Security.KeyFactory GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyFactory);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// generatePublic
				/// </java-name>
				[Dot42.DexImport("generatePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", AccessFlags = 17)]
				public global::Java.Security.IPublicKey GeneratePublic(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPublicKey);
				}

				/// <java-name>
				/// generatePrivate
				/// </java-name>
				[Dot42.DexImport("generatePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", AccessFlags = 17)]
				public global::Java.Security.IPrivateKey GeneratePrivate(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrivateKey);
				}

				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", AccessFlags = 17, Signature = "<T::Ljava/security/spec/KeySpec;>(Ljava/security/Key;Ljava/lang/Class<TT;>;)TT;")]
				public T GetKeySpec<T>(global::Java.Security.IKey key, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// translateKey
				/// </java-name>
				[Dot42.DexImport("translateKey", "(Ljava/security/Key;)Ljava/security/Key;", AccessFlags = 17)]
				public global::Java.Security.IKey TranslateKey(global::Java.Security.IKey key) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

		}

		/// <java-name>
		/// java/security/ProviderException
		/// </java-name>
		[Dot42.DexImport("java/security/ProviderException", AccessFlags = 33)]
		public partial class ProviderException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ProviderException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProviderException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ProviderException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ProviderException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/SecureRandomSpi
		/// </java-name>
		[Dot42.DexImport("java/security/SecureRandomSpi", AccessFlags = 1057)]
		public abstract partial class SecureRandomSpi : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecureRandomSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineSetSeed
				/// </java-name>
				[Dot42.DexImport("engineSetSeed", "([B)V", AccessFlags = 1028)]
				protected internal abstract void EngineSetSeed(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSetSeed
				/// </java-name>
				[Dot42.DexImport("engineSetSeed", "([B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineSetSeed(byte[] @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineNextBytes
				/// </java-name>
				[Dot42.DexImport("engineNextBytes", "([B)V", AccessFlags = 1028)]
				protected internal abstract void EngineNextBytes(sbyte[] sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineNextBytes
				/// </java-name>
				[Dot42.DexImport("engineNextBytes", "([B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineNextBytes(byte[] @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateSeed
				/// </java-name>
				[Dot42.DexImport("engineGenerateSeed", "(I)[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGenerateSeed(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateSeed
				/// </java-name>
				[Dot42.DexImport("engineGenerateSeed", "(I)[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGenerateSeed(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/Security
		/// </java-name>
		[Dot42.DexImport("java/security/Security", AccessFlags = 49)]
		public sealed partial class Security
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Security() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAlgorithmProperty
				/// </java-name>
				[Dot42.DexImport("getAlgorithmProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetAlgorithmProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// insertProviderAt
				/// </java-name>
				[Dot42.DexImport("insertProviderAt", "(Ljava/security/Provider;I)I", AccessFlags = 41)]
				public static int InsertProviderAt(global::Java.Security.Provider provider, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addProvider
				/// </java-name>
				[Dot42.DexImport("addProvider", "(Ljava/security/Provider;)I", AccessFlags = 9)]
				public static int AddProvider(global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// removeProvider
				/// </java-name>
				[Dot42.DexImport("removeProvider", "(Ljava/lang/String;)V", AccessFlags = 41)]
				public static void RemoveProvider(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "()[Ljava/security/Provider;", AccessFlags = 41)]
				public static global::Java.Security.Provider[] GetProviders() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider[]);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "(Ljava/lang/String;)Ljava/security/Provider;", AccessFlags = 41)]
				public static global::Java.Security.Provider GetProvider(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "(Ljava/lang/String;)[Ljava/security/Provider;", AccessFlags = 9)]
				public static global::Java.Security.Provider[] GetProviders(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider[]);
				}

				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "(Ljava/util/Map;)[Ljava/security/Provider;", AccessFlags = 41, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)[Ljava/security/Provider;")]
				public static global::Java.Security.Provider[] GetProviders(global::Java.Util.IMap<string, string> map) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider[]);
				}

				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetProperty(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetProperty(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAlgorithms
				/// </java-name>
				[Dot42.DexImport("getAlgorithms", "(Ljava/lang/String;)Ljava/util/Set;", AccessFlags = 9, Signature = "(Ljava/lang/String;)Ljava/util/Set<Ljava/lang/String;>;")]
				public static global::Java.Util.ISet<string> GetAlgorithms(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <java-name>
				/// getProviders
				/// </java-name>
				public static global::Java.Security.Provider[] Providers
				{
				[Dot42.DexImport("getProviders", "()[Ljava/security/Provider;", AccessFlags = 41)]
						get{ return GetProviders(); }
				}

		}

		/// <java-name>
		/// java/security/DigestOutputStream
		/// </java-name>
		[Dot42.DexImport("java/security/DigestOutputStream", AccessFlags = 33)]
		public partial class DigestOutputStream : global::Java.Io.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "Ljava/security/MessageDigest;", AccessFlags = 4)]
				protected internal global::Java.Security.MessageDigest Digest;
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/security/MessageDigest;)V", AccessFlags = 1)]
				public DigestOutputStream(global::Java.Io.OutputStream outputStream, global::Java.Security.MessageDigest messageDigest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessageDigest
				/// </java-name>
				[Dot42.DexImport("getMessageDigest", "()Ljava/security/MessageDigest;", AccessFlags = 1)]
				public virtual global::Java.Security.MessageDigest GetMessageDigest() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.MessageDigest);
				}

				/// <java-name>
				/// setMessageDigest
				/// </java-name>
				[Dot42.DexImport("setMessageDigest", "(Ljava/security/MessageDigest;)V", AccessFlags = 1)]
				public virtual void SetMessageDigest(global::Java.Security.MessageDigest messageDigest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// on
				/// </java-name>
				[Dot42.DexImport("on", "(Z)V", AccessFlags = 1)]
				public virtual void On(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DigestOutputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMessageDigest
				/// </java-name>
				public global::Java.Security.MessageDigest MessageDigest
				{
				[Dot42.DexImport("getMessageDigest", "()Ljava/security/MessageDigest;", AccessFlags = 1)]
						get{ return GetMessageDigest(); }
				[Dot42.DexImport("setMessageDigest", "(Ljava/security/MessageDigest;)V", AccessFlags = 1)]
						set{ SetMessageDigest(value); }
				}

		}

		/// <java-name>
		/// java/security/KeyStore
		/// </java-name>
		[Dot42.DexImport("java/security/KeyStore", AccessFlags = 33)]
		public partial class KeyStore
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/KeyStoreSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyStore(global::Java.Security.KeyStoreSpi keyStoreSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/KeyStore;", AccessFlags = 9)]
				public static global::Java.Security.KeyStore GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyStore);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyStore;", AccessFlags = 9)]
				public static global::Java.Security.KeyStore GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyStore);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyStore;", AccessFlags = 9)]
				public static global::Java.Security.KeyStore GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyStore);
				}

				/// <java-name>
				/// getDefaultType
				/// </java-name>
				[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
				public static string GetDefaultType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "(Ljava/lang/String;[C)Ljava/security/Key;", AccessFlags = 17)]
				public global::Java.Security.IKey GetKey(string @string, char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <java-name>
				/// getCertificateChain
				/// </java-name>
				[Dot42.DexImport("getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;", AccessFlags = 17)]
				public global::Java.Security.Cert.Certificate[] GetCertificateChain(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <java-name>
				/// getCertificate
				/// </java-name>
				[Dot42.DexImport("getCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;", AccessFlags = 17)]
				public global::Java.Security.Cert.Certificate GetCertificate(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate);
				}

				/// <java-name>
				/// getCreationDate
				/// </java-name>
				[Dot42.DexImport("getCreationDate", "(Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 17)]
				public global::Java.Util.Date GetCreationDate(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// setKeyEntry
				/// </java-name>
				[Dot42.DexImport("setKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void SetKeyEntry(string @string, global::Java.Security.IKey key, char[] @char, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setKeyEntry
				/// </java-name>
				[Dot42.DexImport("setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void SetKeyEntry(string @string, sbyte[] sByte, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setKeyEntry
				/// </java-name>
				[Dot42.DexImport("setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void SetKeyEntry(string @string, byte[] @byte, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCertificateEntry
				/// </java-name>
				[Dot42.DexImport("setCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void SetCertificateEntry(string @string, global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteEntry
				/// </java-name>
				[Dot42.DexImport("deleteEntry", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void DeleteEntry(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// aliases
				/// </java-name>
				[Dot42.DexImport("aliases", "()Ljava/util/Enumeration;", AccessFlags = 17, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public global::Java.Util.IEnumeration<string> Aliases() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<string>);
				}

				/// <java-name>
				/// containsAlias
				/// </java-name>
				[Dot42.DexImport("containsAlias", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool ContainsAlias(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 17)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isKeyEntry
				/// </java-name>
				[Dot42.DexImport("isKeyEntry", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool IsKeyEntry(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isCertificateEntry
				/// </java-name>
				[Dot42.DexImport("isCertificateEntry", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool IsCertificateEntry(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCertificateAlias
				/// </java-name>
				[Dot42.DexImport("getCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", AccessFlags = 17)]
				public string GetCertificateAlias(global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// store
				/// </java-name>
				[Dot42.DexImport("store", "(Ljava/io/OutputStream;[C)V", AccessFlags = 17)]
				public void Store(global::Java.Io.OutputStream outputStream, char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// store
				/// </java-name>
				[Dot42.DexImport("store", "(Ljava/security/KeyStore$LoadStoreParameter;)V", AccessFlags = 17)]
				public void Store(global::Java.Security.KeyStore.ILoadStoreParameter loadStoreParameter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/InputStream;[C)V", AccessFlags = 17)]
				public void Load(global::Java.Io.InputStream inputStream, char[] @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/security/KeyStore$LoadStoreParameter;)V", AccessFlags = 17)]
				public void Load(global::Java.Security.KeyStore.ILoadStoreParameter loadStoreParameter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/Ke" +
    "yStore$Entry;", AccessFlags = 17)]
				public global::Java.Security.KeyStore.IEntry GetEntry(string @string, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyStore.IEntry);
				}

				/// <java-name>
				/// setEntry
				/// </java-name>
				[Dot42.DexImport("setEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$Protecti" +
    "onParameter;)V", AccessFlags = 17)]
				public void SetEntry(string @string, global::Java.Security.KeyStore.IEntry entry, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// entryInstanceOf
				/// </java-name>
				[Dot42.DexImport("entryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z", AccessFlags = 17, Signature = "(Ljava/lang/String;Ljava/lang/Class<+Ljava/security/KeyStore$Entry;>;)Z")]
				public bool EntryInstanceOf(string @string, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyStore() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultType
				/// </java-name>
				public static string DefaultType
				{
				[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return GetDefaultType(); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
				[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetType(); }
				}

				/// <java-name>
				/// java/security/KeyStore$TrustedCertificateEntry
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$TrustedCertificateEntry", AccessFlags = 25)]
				public sealed partial class TrustedCertificateEntry : global::Java.Security.KeyStore.IEntry
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/security/cert/Certificate;)V", AccessFlags = 1)]
						public TrustedCertificateEntry(global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getTrustedCertificate
						/// </java-name>
						[Dot42.DexImport("getTrustedCertificate", "()Ljava/security/cert/Certificate;", AccessFlags = 1)]
						public global::Java.Security.Cert.Certificate GetTrustedCertificate() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Security.Cert.Certificate);
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal TrustedCertificateEntry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getTrustedCertificate
						/// </java-name>
						public global::Java.Security.Cert.Certificate TrustedCertificate
						{
						[Dot42.DexImport("getTrustedCertificate", "()Ljava/security/cert/Certificate;", AccessFlags = 1)]
								get{ return GetTrustedCertificate(); }
						}

				}

				/// <java-name>
				/// java/security/KeyStore$SecretKeyEntry
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$SecretKeyEntry", AccessFlags = 25)]
				public sealed partial class SecretKeyEntry : global::Java.Security.KeyStore.IEntry
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljavax/crypto/SecretKey;)V", AccessFlags = 1)]
						public SecretKeyEntry(global::Javax.Crypto.ISecretKey secretKey) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getSecretKey
						/// </java-name>
						[Dot42.DexImport("getSecretKey", "()Ljavax/crypto/SecretKey;", AccessFlags = 1)]
						public global::Javax.Crypto.ISecretKey GetSecretKey() /* MethodBuilder.Create */ 
						{
								return default(global::Javax.Crypto.ISecretKey);
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SecretKeyEntry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getSecretKey
						/// </java-name>
						public global::Javax.Crypto.ISecretKey SecretKey
						{
						[Dot42.DexImport("getSecretKey", "()Ljavax/crypto/SecretKey;", AccessFlags = 1)]
								get{ return GetSecretKey(); }
						}

				}

				/// <java-name>
				/// java/security/KeyStore$PrivateKeyEntry
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$PrivateKeyEntry", AccessFlags = 25)]
				public sealed partial class PrivateKeyEntry : global::Java.Security.KeyStore.IEntry
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/security/PrivateKey;[Ljava/security/cert/Certificate;)V", AccessFlags = 1)]
						public PrivateKeyEntry(global::Java.Security.IPrivateKey privateKey, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getPrivateKey
						/// </java-name>
						[Dot42.DexImport("getPrivateKey", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
						public global::Java.Security.IPrivateKey GetPrivateKey() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Security.IPrivateKey);
						}

						/// <java-name>
						/// getCertificateChain
						/// </java-name>
						[Dot42.DexImport("getCertificateChain", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						public global::Java.Security.Cert.Certificate[] GetCertificateChain() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Security.Cert.Certificate[]);
						}

						/// <java-name>
						/// getCertificate
						/// </java-name>
						[Dot42.DexImport("getCertificate", "()Ljava/security/cert/Certificate;", AccessFlags = 1)]
						public global::Java.Security.Cert.Certificate GetCertificate() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Security.Cert.Certificate);
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal PrivateKeyEntry() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getPrivateKey
						/// </java-name>
						public global::Java.Security.IPrivateKey PrivateKey
						{
						[Dot42.DexImport("getPrivateKey", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
								get{ return GetPrivateKey(); }
						}

						/// <java-name>
						/// getCertificateChain
						/// </java-name>
						public global::Java.Security.Cert.Certificate[] CertificateChain
						{
						[Dot42.DexImport("getCertificateChain", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
								get{ return GetCertificateChain(); }
						}

						/// <java-name>
						/// getCertificate
						/// </java-name>
						public global::Java.Security.Cert.Certificate Certificate
						{
						[Dot42.DexImport("getCertificate", "()Ljava/security/cert/Certificate;", AccessFlags = 1)]
								get{ return GetCertificate(); }
						}

				}

				/// <java-name>
				/// java/security/KeyStore$ProtectionParameter
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$ProtectionParameter", AccessFlags = 1545)]
				public partial interface IProtectionParameter
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// java/security/KeyStore$PasswordProtection
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$PasswordProtection", AccessFlags = 9)]
				public partial class PasswordProtection : global::Java.Security.KeyStore.IProtectionParameter, global::Javax.Security.Auth.IDestroyable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
						public PasswordProtection(char[] @char) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getPassword
						/// </java-name>
						[Dot42.DexImport("getPassword", "()[C", AccessFlags = 33)]
						public virtual char[] GetPassword() /* MethodBuilder.Create */ 
						{
								return default(char[]);
						}

						/// <java-name>
						/// destroy
						/// </java-name>
						[Dot42.DexImport("destroy", "()V", AccessFlags = 33)]
						public virtual void Destroy() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isDestroyed
						/// </java-name>
						[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 33)]
						public virtual bool IsDestroyed() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal PasswordProtection() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getPassword
						/// </java-name>
						public char[] Password
						{
						[Dot42.DexImport("getPassword", "()[C", AccessFlags = 33)]
								get{ return GetPassword(); }
						}

				}

				/// <java-name>
				/// java/security/KeyStore$LoadStoreParameter
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$LoadStoreParameter", AccessFlags = 1545)]
				public partial interface ILoadStoreParameter
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// getProtectionParameter
						/// </java-name>
						[Dot42.DexImport("getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;", AccessFlags = 1025)]
						global::Java.Security.KeyStore.IProtectionParameter GetProtectionParameter() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// java/security/KeyStore$Entry
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$Entry", AccessFlags = 1545)]
				public partial interface IEntry
 /* scope: __dot42__ */ 
				{
				}

				/// <java-name>
				/// java/security/KeyStore$CallbackHandlerProtection
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$CallbackHandlerProtection", AccessFlags = 9)]
				public partial class CallbackHandlerProtection : global::Java.Security.KeyStore.IProtectionParameter
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljavax/security/auth/callback/CallbackHandler;)V", AccessFlags = 1)]
						public CallbackHandlerProtection(global::Javax.Security.Auth.Callback.ICallbackHandler callbackHandler) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getCallbackHandler
						/// </java-name>
						[Dot42.DexImport("getCallbackHandler", "()Ljavax/security/auth/callback/CallbackHandler;", AccessFlags = 1)]
						public virtual global::Javax.Security.Auth.Callback.ICallbackHandler GetCallbackHandler() /* MethodBuilder.Create */ 
						{
								return default(global::Javax.Security.Auth.Callback.ICallbackHandler);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal CallbackHandlerProtection() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getCallbackHandler
						/// </java-name>
						public global::Javax.Security.Auth.Callback.ICallbackHandler CallbackHandler
						{
						[Dot42.DexImport("getCallbackHandler", "()Ljavax/security/auth/callback/CallbackHandler;", AccessFlags = 1)]
								get{ return GetCallbackHandler(); }
						}

				}

				/// <java-name>
				/// java/security/KeyStore$Builder
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$Builder", AccessFlags = 1033)]
				public abstract partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
						protected internal Builder() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getKeyStore
						/// </java-name>
						[Dot42.DexImport("getKeyStore", "()Ljava/security/KeyStore;", AccessFlags = 1025)]
						public abstract global::Java.Security.KeyStore GetKeyStore() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// getProtectionParameter
						/// </java-name>
						[Dot42.DexImport("getProtectionParameter", "(Ljava/lang/String;)Ljava/security/KeyStore$ProtectionParameter;", AccessFlags = 1025)]
						public abstract global::Java.Security.KeyStore.IProtectionParameter GetProtectionParameter(string @string) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// newInstance
						/// </java-name>
						[Dot42.DexImport("newInstance", "(Ljava/security/KeyStore;Ljava/security/KeyStore$ProtectionParameter;)Ljava/secur" +
    "ity/KeyStore$Builder;", AccessFlags = 9)]
						public static Builder NewInstance(global::Java.Security.KeyStore keyStore, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// newInstance
						/// </java-name>
						[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/io/File;Ljava/security/KeyStore$" +
    "ProtectionParameter;)Ljava/security/KeyStore$Builder;", AccessFlags = 9)]
						public static Builder NewInstance(string @string, global::Java.Security.Provider provider, global::Java.Io.File file, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// newInstance
						/// </java-name>
						[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/security/KeyStore$ProtectionPara" +
    "meter;)Ljava/security/KeyStore$Builder;", AccessFlags = 9)]
						public static Builder NewInstance(string @string, global::Java.Security.Provider provider, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// getKeyStore
						/// </java-name>
						public global::Java.Security.KeyStore KeyStore
						{
						[Dot42.DexImport("getKeyStore", "()Ljava/security/KeyStore;", AccessFlags = 1025)]
								get{ return GetKeyStore(); }
						}

				}

		}

		/// <java-name>
		/// java/security/CodeSigner
		/// </java-name>
		[Dot42.DexImport("java/security/CodeSigner", AccessFlags = 49)]
		public sealed partial class CodeSigner : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPath;Ljava/security/Timestamp;)V", AccessFlags = 1)]
				public CodeSigner(global::Java.Security.Cert.CertPath certPath, global::Java.Security.Timestamp timestamp) /* MethodBuilder.Create */ 
				{
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
				/// getSignerCertPath
				/// </java-name>
				[Dot42.DexImport("getSignerCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
				public global::Java.Security.Cert.CertPath GetSignerCertPath() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "()Ljava/security/Timestamp;", AccessFlags = 1)]
				public global::Java.Security.Timestamp GetTimestamp() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Timestamp);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CodeSigner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSignerCertPath
				/// </java-name>
				public global::Java.Security.Cert.CertPath SignerCertPath
				{
				[Dot42.DexImport("getSignerCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
						get{ return GetSignerCertPath(); }
				}

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				public global::Java.Security.Timestamp Timestamp
				{
				[Dot42.DexImport("getTimestamp", "()Ljava/security/Timestamp;", AccessFlags = 1)]
						get{ return GetTimestamp(); }
				}

		}

		/// <java-name>
		/// java/security/Key
		/// </java-name>
		[Dot42.DexImport("java/security/Key", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 6603384152749567654;
		}

		/// <java-name>
		/// java/security/Key
		/// </java-name>
		[Dot42.DexImport("java/security/Key", AccessFlags = 1537)]
		public partial interface IKey : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetAlgorithm() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFormat
				/// </java-name>
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetFormat() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetEncoded() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/UnrecoverableKeyException
		/// </java-name>
		[Dot42.DexImport("java/security/UnrecoverableKeyException", AccessFlags = 33)]
		public partial class UnrecoverableKeyException : global::Java.Security.UnrecoverableEntryException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnrecoverableKeyException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnrecoverableKeyException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/KeyPairGeneratorSpi
		/// </java-name>
		[Dot42.DexImport("java/security/KeyPairGeneratorSpi", AccessFlags = 1057)]
		public abstract partial class KeyPairGeneratorSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyPairGeneratorSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateKeyPair
				/// </java-name>
				[Dot42.DexImport("generateKeyPair", "()Ljava/security/KeyPair;", AccessFlags = 1025)]
				public abstract global::Java.Security.KeyPair GenerateKeyPair() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(ILjava/security/SecureRandom;)V", AccessFlags = 1025)]
				public abstract void Initialize(int int32, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 1)]
				public virtual void Initialize(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/InvalidParameterException
		/// </java-name>
		[Dot42.DexImport("java/security/InvalidParameterException", AccessFlags = 33)]
		public partial class InvalidParameterException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidParameterException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidParameterException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/AllPermission
		/// </java-name>
		[Dot42.DexImport("java/security/AllPermission", AccessFlags = 49)]
		public sealed partial class AllPermission : global::Java.Security.Permission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public AllPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AllPermission() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/security/DomainCombiner
		/// </java-name>
		[Dot42.DexImport("java/security/DomainCombiner", AccessFlags = 1537)]
		public partial interface IDomainCombiner
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// combine
				/// </java-name>
				[Dot42.DexImport("combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/securi" +
    "ty/ProtectionDomain;", AccessFlags = 1025)]
				global::Java.Security.ProtectionDomain[] Combine(global::Java.Security.ProtectionDomain[] protectionDomain, global::Java.Security.ProtectionDomain[] protectionDomain1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/UnresolvedPermission
		/// </java-name>
		[Dot42.DexImport("java/security/UnresolvedPermission", AccessFlags = 49)]
		public sealed partial class UnresolvedPermission : global::Java.Security.Permission, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/security/cert/Certi" +
    "ficate;)V", AccessFlags = 1)]
				public UnresolvedPermission(string @string, string string1, string string2, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUnresolvedName
				/// </java-name>
				[Dot42.DexImport("getUnresolvedName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetUnresolvedName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getUnresolvedActions
				/// </java-name>
				[Dot42.DexImport("getUnresolvedActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetUnresolvedActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getUnresolvedType
				/// </java-name>
				[Dot42.DexImport("getUnresolvedType", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetUnresolvedType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getUnresolvedCerts
				/// </java-name>
				[Dot42.DexImport("getUnresolvedCerts", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
				public global::Java.Security.Cert.Certificate[] GetUnresolvedCerts() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UnresolvedPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getUnresolvedName
				/// </java-name>
				public string UnresolvedName
				{
				[Dot42.DexImport("getUnresolvedName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUnresolvedName(); }
				}

				/// <java-name>
				/// getUnresolvedActions
				/// </java-name>
				public string UnresolvedActions
				{
				[Dot42.DexImport("getUnresolvedActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUnresolvedActions(); }
				}

				/// <java-name>
				/// getUnresolvedType
				/// </java-name>
				public string UnresolvedType
				{
				[Dot42.DexImport("getUnresolvedType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUnresolvedType(); }
				}

				/// <java-name>
				/// getUnresolvedCerts
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] UnresolvedCerts
				{
				[Dot42.DexImport("getUnresolvedCerts", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return GetUnresolvedCerts(); }
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/security/Identity
		/// </java-name>
		[Dot42.DexImport("java/security/Identity", AccessFlags = 1057)]
		public abstract partial class Identity : global::Java.Security.IPrincipal, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Identity() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Identity(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V", AccessFlags = 1)]
				public Identity(string @string, global::Java.Security.IdentityScope identityScope) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addCertificate
				/// </java-name>
				[Dot42.DexImport("addCertificate", "(Ljava/security/Certificate;)V", AccessFlags = 1)]
				public virtual void AddCertificate(global::Java.Security.ICertificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeCertificate
				/// </java-name>
				[Dot42.DexImport("removeCertificate", "(Ljava/security/Certificate;)V", AccessFlags = 1)]
				public virtual void RemoveCertificate(global::Java.Security.ICertificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// certificates
				/// </java-name>
				[Dot42.DexImport("certificates", "()[Ljava/security/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.ICertificate[] Certificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.ICertificate[]);
				}

				/// <java-name>
				/// identityEquals
				/// </java-name>
				[Dot42.DexImport("identityEquals", "(Ljava/security/Identity;)Z", AccessFlags = 4)]
				protected internal virtual bool IdentityEquals(global::Java.Security.Identity identity) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Z)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getScope
				/// </java-name>
				[Dot42.DexImport("getScope", "()Ljava/security/IdentityScope;", AccessFlags = 17)]
				public global::Java.Security.IdentityScope GetScope() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IdentityScope);
				}

				/// <java-name>
				/// setPublicKey
				/// </java-name>
				[Dot42.DexImport("setPublicKey", "(Ljava/security/PublicKey;)V", AccessFlags = 1)]
				public virtual void SetPublicKey(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPublicKey
				/// </java-name>
				[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1)]
				public virtual global::Java.Security.IPublicKey GetPublicKey() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPublicKey);
				}

				/// <java-name>
				/// setInfo
				/// </java-name>
				[Dot42.DexImport("setInfo", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetInfo(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				[Dot42.DexImport("getInfo", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetInfo() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getScope
				/// </java-name>
				public global::Java.Security.IdentityScope Scope
				{
				[Dot42.DexImport("getScope", "()Ljava/security/IdentityScope;", AccessFlags = 17)]
						get{ return GetScope(); }
				}

				/// <java-name>
				/// getPublicKey
				/// </java-name>
				public global::Java.Security.IPublicKey PublicKey
				{
				[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1)]
						get{ return GetPublicKey(); }
				[Dot42.DexImport("setPublicKey", "(Ljava/security/PublicKey;)V", AccessFlags = 1)]
						set{ SetPublicKey(value); }
				}

				/// <java-name>
				/// getInfo
				/// </java-name>
				public string Info
				{
				[Dot42.DexImport("getInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetInfo(); }
				[Dot42.DexImport("setInfo", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetInfo(value); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetName(); }
				}

		}

		/// <java-name>
		/// java/security/GeneralSecurityException
		/// </java-name>
		[Dot42.DexImport("java/security/GeneralSecurityException", AccessFlags = 33)]
		public partial class GeneralSecurityException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public GeneralSecurityException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GeneralSecurityException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public GeneralSecurityException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public GeneralSecurityException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/SecurityPermission
		/// </java-name>
		[Dot42.DexImport("java/security/SecurityPermission", AccessFlags = 49)]
		public sealed partial class SecurityPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SecurityPermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SecurityPermission(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetActions() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SecurityPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

		}

		/// <java-name>
		/// java/security/Policy
		/// </java-name>
		[Dot42.DexImport("java/security/Policy", AccessFlags = 1057)]
		public abstract partial class Policy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNSUPPORTED_EMPTY_COLLECTION
				/// </java-name>
				[Dot42.DexImport("UNSUPPORTED_EMPTY_COLLECTION", "Ljava/security/PermissionCollection;", AccessFlags = 25)]
				public static readonly global::Java.Security.PermissionCollection UNSUPPORTED_EMPTY_COLLECTION;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Policy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Policy$Parameters;)Ljava/security/Policy;", AccessFlags = 9)]
				public static global::Java.Security.Policy GetInstance(string @string, global::Java.Security.Policy.IParameters parameters) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Policy);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Policy$Parameters;Ljava/lang/String;)Ljava/secu" +
    "rity/Policy;", AccessFlags = 9)]
				public static global::Java.Security.Policy GetInstance(string @string, global::Java.Security.Policy.IParameters parameters, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Policy);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Policy$Parameters;Ljava/security/Provider;)Ljav" +
    "a/security/Policy;", AccessFlags = 9)]
				public static global::Java.Security.Policy GetInstance(string @string, global::Java.Security.Policy.IParameters parameters, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Policy);
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Ljava/security/Policy$Parameters;", AccessFlags = 1)]
				public virtual global::Java.Security.Policy.IParameters GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Policy.IParameters);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 1)]
				public virtual global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetType() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", AccessFlags = 1)]
				public virtual global::Java.Security.PermissionCollection GetPermissions(global::Java.Security.CodeSource codeSource) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// refresh
				/// </java-name>
				[Dot42.DexImport("refresh", "()V", AccessFlags = 1)]
				public virtual void Refresh() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;", AccessFlags = 1)]
				public virtual global::Java.Security.PermissionCollection GetPermissions(global::Java.Security.ProtectionDomain protectionDomain) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/ProtectionDomain;Ljava/security/Permission;)Z", AccessFlags = 1)]
				public virtual bool Implies(global::Java.Security.ProtectionDomain protectionDomain, global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPolicy
				/// </java-name>
				[Dot42.DexImport("getPolicy", "()Ljava/security/Policy;", AccessFlags = 9)]
				public static global::Java.Security.Policy GetPolicy() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Policy);
				}

				/// <java-name>
				/// setPolicy
				/// </java-name>
				[Dot42.DexImport("setPolicy", "(Ljava/security/Policy;)V", AccessFlags = 9)]
				public static void SetPolicy(global::Java.Security.Policy policy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Security.Policy.IParameters Parameters
				{
				[Dot42.DexImport("getParameters", "()Ljava/security/Policy$Parameters;", AccessFlags = 1)]
						get{ return GetParameters(); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 1)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
				[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetType(); }
				}

				/// <java-name>
				/// java/security/Policy$Parameters
				/// </java-name>
				[Dot42.DexImport("java/security/Policy$Parameters", AccessFlags = 1545)]
				public partial interface IParameters
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <java-name>
		/// java/security/MessageDigest
		/// </java-name>
		[Dot42.DexImport("java/security/MessageDigest", AccessFlags = 1057)]
		public abstract partial class MessageDigest : global::Java.Security.MessageDigestSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal MessageDigest(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/MessageDigest;", AccessFlags = 9)]
				public static global::Java.Security.MessageDigest GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.MessageDigest);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/MessageDigest;", AccessFlags = 9)]
				public static global::Java.Security.MessageDigest GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.MessageDigest);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/MessageDigest;", AccessFlags = 9)]
				public static global::Java.Security.MessageDigest GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.MessageDigest);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 1)]
				public virtual void Update(sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1)]
				public virtual void Update(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1)]
				public virtual void Update(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaDigest() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] Digest() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "([BII)I", AccessFlags = 1)]
				public virtual int Digest(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Digest(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "([B)[B", AccessFlags = 1)]
				public virtual sbyte[] Digest(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] Digest(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isEqual
				/// </java-name>
				[Dot42.DexImport("isEqual", "([B[B)Z", AccessFlags = 9)]
				public static bool IsEqual(sbyte[] sByte, sbyte[] sByte1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isEqual
				/// </java-name>
				[Dot42.DexImport("isEqual", "([B[B)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool IsEqual(byte[] @byte, byte[] byte1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// getDigestLength
				/// </java-name>
				[Dot42.DexImport("getDigestLength", "()I", AccessFlags = 17)]
				public int GetDigestLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 17)]
				public void Update(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MessageDigest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getDigestLength
				/// </java-name>
				public int DigestLength
				{
				[Dot42.DexImport("getDigestLength", "()I", AccessFlags = 17)]
						get{ return GetDigestLength(); }
				}

		}

		/// <java-name>
		/// java/security/AccessControlException
		/// </java-name>
		[Dot42.DexImport("java/security/AccessControlException", AccessFlags = 33)]
		public partial class AccessControlException : global::Java.Lang.SecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AccessControlException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/Permission;)V", AccessFlags = 1)]
				public AccessControlException(string @string, global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPermission
				/// </java-name>
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
				public virtual global::Java.Security.Permission GetPermission() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Permission);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AccessControlException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPermission
				/// </java-name>
				public global::Java.Security.Permission Permission
				{
				[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
						get{ return GetPermission(); }
				}

		}

		/// <java-name>
		/// java/security/PermissionCollection
		/// </java-name>
		[Dot42.DexImport("java/security/PermissionCollection", AccessFlags = 1057)]
		public abstract partial class PermissionCollection : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PermissionCollection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/security/Permission;)V", AccessFlags = 1025)]
				public abstract void Add(global::Java.Security.Permission permission) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/security/Permission;>;")]
				public abstract global::Java.Util.IEnumeration<global::Java.Security.Permission> Elements() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1025)]
				public abstract bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1)]
				public virtual bool IsReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setReadOnly
				/// </java-name>
				[Dot42.DexImport("setReadOnly", "()V", AccessFlags = 1)]
				public virtual void SetReadOnly() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/Certificate
		/// </java-name>
		[Dot42.DexImport("java/security/Certificate", AccessFlags = 1537)]
		public partial interface ICertificate
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void Decode(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				void Encode(global::Java.Io.OutputStream outputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFormat
				/// </java-name>
				[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetFormat() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getGuarantor
				/// </java-name>
				[Dot42.DexImport("getGuarantor", "()Ljava/security/Principal;", AccessFlags = 1025)]
				global::Java.Security.IPrincipal GetGuarantor() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrincipal
				/// </java-name>
				[Dot42.DexImport("getPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				global::Java.Security.IPrincipal GetPrincipal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPublicKey
				/// </java-name>
				[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1025)]
				global::Java.Security.IPublicKey GetPublicKey() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Z)Ljava/lang/String;", AccessFlags = 1025)]
				string ToString(bool boolean) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/IdentityScope
		/// </java-name>
		[Dot42.DexImport("java/security/IdentityScope", AccessFlags = 1057)]
		public abstract partial class IdentityScope : global::Java.Security.Identity
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal IdentityScope() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IdentityScope(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V", AccessFlags = 1)]
				public IdentityScope(string @string, global::Java.Security.IdentityScope identityScope) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSystemScope
				/// </java-name>
				[Dot42.DexImport("getSystemScope", "()Ljava/security/IdentityScope;", AccessFlags = 9)]
				public static global::Java.Security.IdentityScope GetSystemScope() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IdentityScope);
				}

				/// <java-name>
				/// setSystemScope
				/// </java-name>
				[Dot42.DexImport("setSystemScope", "(Ljava/security/IdentityScope;)V", AccessFlags = 12)]
				protected internal static void SetSystemScope(global::Java.Security.IdentityScope identityScope) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				public abstract int Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIdentity
				/// </java-name>
				[Dot42.DexImport("getIdentity", "(Ljava/lang/String;)Ljava/security/Identity;", AccessFlags = 1025)]
				public abstract global::Java.Security.Identity GetIdentity(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getIdentity
				/// </java-name>
				[Dot42.DexImport("getIdentity", "(Ljava/security/Principal;)Ljava/security/Identity;", AccessFlags = 1)]
				public virtual global::Java.Security.Identity GetIdentity(global::Java.Security.IPrincipal principal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Identity);
				}

				/// <java-name>
				/// getIdentity
				/// </java-name>
				[Dot42.DexImport("getIdentity", "(Ljava/security/PublicKey;)Ljava/security/Identity;", AccessFlags = 1025)]
				public abstract global::Java.Security.Identity GetIdentity(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addIdentity
				/// </java-name>
				[Dot42.DexImport("addIdentity", "(Ljava/security/Identity;)V", AccessFlags = 1025)]
				public abstract void AddIdentity(global::Java.Security.Identity identity) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeIdentity
				/// </java-name>
				[Dot42.DexImport("removeIdentity", "(Ljava/security/Identity;)V", AccessFlags = 1025)]
				public abstract void RemoveIdentity(global::Java.Security.Identity identity) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// identities
				/// </java-name>
				[Dot42.DexImport("identities", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/security/Identity;>;")]
				public abstract global::Java.Util.IEnumeration<global::Java.Security.Identity> Identities() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSystemScope
				/// </java-name>
				public static global::Java.Security.IdentityScope SystemScope
				{
				[Dot42.DexImport("getSystemScope", "()Ljava/security/IdentityScope;", AccessFlags = 9)]
						get{ return GetSystemScope(); }
				[Dot42.DexImport("setSystemScope", "(Ljava/security/IdentityScope;)V", AccessFlags = 12)]
						set{ SetSystemScope(value); }
				}

		}

		/// <java-name>
		/// java/security/NoSuchAlgorithmException
		/// </java-name>
		[Dot42.DexImport("java/security/NoSuchAlgorithmException", AccessFlags = 33)]
		public partial class NoSuchAlgorithmException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchAlgorithmException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchAlgorithmException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NoSuchAlgorithmException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NoSuchAlgorithmException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/KeyFactorySpi
		/// </java-name>
		[Dot42.DexImport("java/security/KeyFactorySpi", AccessFlags = 1057)]
		public abstract partial class KeyFactorySpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGeneratePublic
				/// </java-name>
				[Dot42.DexImport("engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.IPublicKey EngineGeneratePublic(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGeneratePrivate
				/// </java-name>
				[Dot42.DexImport("engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.IPrivateKey EngineGeneratePrivate(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetKeySpec
				/// </java-name>
				[Dot42.DexImport("engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", AccessFlags = 1028, Signature = "<T::Ljava/security/spec/KeySpec;>(Ljava/security/Key;Ljava/lang/Class<TT;>;)TT;")]
				protected internal abstract T EngineGetKeySpec<T>(global::Java.Security.IKey key, global::System.Type type) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineTranslateKey
				/// </java-name>
				[Dot42.DexImport("engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.IKey EngineTranslateKey(global::Java.Security.IKey key) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/Timestamp
		/// </java-name>
		[Dot42.DexImport("java/security/Timestamp", AccessFlags = 49)]
		public sealed partial class Timestamp : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/Date;Ljava/security/cert/CertPath;)V", AccessFlags = 1)]
				public Timestamp(global::Java.Util.Date date, global::Java.Security.Cert.CertPath certPath) /* MethodBuilder.Create */ 
				{
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
				/// getSignerCertPath
				/// </java-name>
				[Dot42.DexImport("getSignerCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
				public global::Java.Security.Cert.CertPath GetSignerCertPath() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "()Ljava/util/Date;", AccessFlags = 1)]
				public global::Java.Util.Date GetTimestamp() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Timestamp() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSignerCertPath
				/// </java-name>
				public global::Java.Security.Cert.CertPath SignerCertPath
				{
				[Dot42.DexImport("getSignerCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
						get{ return GetSignerCertPath(); }
				}

		}

		/// <java-name>
		/// java/security/PublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/PublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 7187392471159151072;
		}

		/// <java-name>
		/// java/security/PublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/PublicKey", AccessFlags = 1537)]
		public partial interface IPublicKey : global::Java.Security.IKey
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// java/security/Principal
		/// </java-name>
		[Dot42.DexImport("java/security/Principal", AccessFlags = 1537)]
		public partial interface IPrincipal
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/MessageDigestSpi
		/// </java-name>
		[Dot42.DexImport("java/security/MessageDigestSpi", AccessFlags = 1057)]
		public abstract partial class MessageDigestSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MessageDigestSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGetDigestLength
				/// </java-name>
				[Dot42.DexImport("engineGetDigestLength", "()I", AccessFlags = 4)]
				protected internal virtual int EngineGetDigestLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte sByte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte @byte) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 4)]
				protected internal virtual void EngineUpdate(global::Java.Nio.ByteBuffer byteBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineDigest
				/// </java-name>
				[Dot42.DexImport("engineDigest", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineDigest() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineDigest
				/// </java-name>
				[Dot42.DexImport("engineDigest", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineDigest() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineDigest
				/// </java-name>
				[Dot42.DexImport("engineDigest", "([BII)I", AccessFlags = 4)]
				protected internal virtual int EngineDigest(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// engineDigest
				/// </java-name>
				[Dot42.DexImport("engineDigest", "([BII)I", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual int EngineDigest(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// engineReset
				/// </java-name>
				[Dot42.DexImport("engineReset", "()V", AccessFlags = 1028)]
				protected internal abstract void EngineReset() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <java-name>
		/// java/security/KeyException
		/// </java-name>
		[Dot42.DexImport("java/security/KeyException", AccessFlags = 33)]
		public partial class KeyException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public KeyException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/PrivilegedActionException
		/// </java-name>
		[Dot42.DexImport("java/security/PrivilegedActionException", AccessFlags = 33)]
		public partial class PrivilegedActionException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public PrivilegedActionException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getException
				/// </java-name>
				[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
				public virtual global::System.Exception GetException() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrivilegedActionException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getException
				/// </java-name>
				public global::System.Exception Exception
				{
				[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
						get{ return GetException(); }
				}

		}

		/// <java-name>
		/// java/security/KeyStoreSpi
		/// </java-name>
		[Dot42.DexImport("java/security/KeyStoreSpi", AccessFlags = 1057)]
		public abstract partial class KeyStoreSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyStoreSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGetKey
				/// </java-name>
				[Dot42.DexImport("engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;", AccessFlags = 1025)]
				public abstract global::Java.Security.IKey EngineGetKey(string @string, char[] @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetCertificateChain
				/// </java-name>
				[Dot42.DexImport("engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate[] EngineGetCertificateChain(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetCertificate
				/// </java-name>
				[Dot42.DexImport("engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate EngineGetCertificate(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetCreationDate
				/// </java-name>
				[Dot42.DexImport("engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 1025)]
				public abstract global::Java.Util.Date EngineGetCreationDate(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSetKeyEntry
				/// </java-name>
				[Dot42.DexImport("engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V", AccessFlags = 1025)]
				public abstract void EngineSetKeyEntry(string @string, global::Java.Security.IKey key, char[] @char, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSetKeyEntry
				/// </java-name>
				[Dot42.DexImport("engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", AccessFlags = 1025)]
				public abstract void EngineSetKeyEntry(string @string, sbyte[] sByte, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSetKeyEntry
				/// </java-name>
				[Dot42.DexImport("engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract void EngineSetKeyEntry(string @string, byte[] @byte, global::Java.Security.Cert.Certificate[] certificate) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSetCertificateEntry
				/// </java-name>
				[Dot42.DexImport("engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V", AccessFlags = 1025)]
				public abstract void EngineSetCertificateEntry(string @string, global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineDeleteEntry
				/// </java-name>
				[Dot42.DexImport("engineDeleteEntry", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EngineDeleteEntry(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineAliases
				/// </java-name>
				[Dot42.DexImport("engineAliases", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public abstract global::Java.Util.IEnumeration<string> EngineAliases() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineContainsAlias
				/// </java-name>
				[Dot42.DexImport("engineContainsAlias", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool EngineContainsAlias(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineSize
				/// </java-name>
				[Dot42.DexImport("engineSize", "()I", AccessFlags = 1025)]
				public abstract int EngineSize() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineIsKeyEntry
				/// </java-name>
				[Dot42.DexImport("engineIsKeyEntry", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool EngineIsKeyEntry(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineIsCertificateEntry
				/// </java-name>
				[Dot42.DexImport("engineIsCertificateEntry", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool EngineIsCertificateEntry(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetCertificateAlias
				/// </java-name>
				[Dot42.DexImport("engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string EngineGetCertificateAlias(global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineStore
				/// </java-name>
				[Dot42.DexImport("engineStore", "(Ljava/io/OutputStream;[C)V", AccessFlags = 1025)]
				public abstract void EngineStore(global::Java.Io.OutputStream outputStream, char[] @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineStore
				/// </java-name>
				[Dot42.DexImport("engineStore", "(Ljava/security/KeyStore$LoadStoreParameter;)V", AccessFlags = 1)]
				public virtual void EngineStore(global::Java.Security.KeyStore.ILoadStoreParameter loadStoreParameter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineLoad
				/// </java-name>
				[Dot42.DexImport("engineLoad", "(Ljava/io/InputStream;[C)V", AccessFlags = 1025)]
				public abstract void EngineLoad(global::Java.Io.InputStream inputStream, char[] @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineLoad
				/// </java-name>
				[Dot42.DexImport("engineLoad", "(Ljava/security/KeyStore$LoadStoreParameter;)V", AccessFlags = 1)]
				public virtual void EngineLoad(global::Java.Security.KeyStore.ILoadStoreParameter loadStoreParameter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGetEntry
				/// </java-name>
				[Dot42.DexImport("engineGetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/Ke" +
    "yStore$Entry;", AccessFlags = 1)]
				public virtual global::Java.Security.KeyStore.IEntry EngineGetEntry(string @string, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyStore.IEntry);
				}

				/// <java-name>
				/// engineSetEntry
				/// </java-name>
				[Dot42.DexImport("engineSetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$Protecti" +
    "onParameter;)V", AccessFlags = 1)]
				public virtual void EngineSetEntry(string @string, global::Java.Security.KeyStore.IEntry entry, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineEntryInstanceOf
				/// </java-name>
				[Dot42.DexImport("engineEntryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<+Ljava/security/KeyStore$Entry;>;)Z")]
				public virtual bool EngineEntryInstanceOf(string @string, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/security/NoSuchProviderException
		/// </java-name>
		[Dot42.DexImport("java/security/NoSuchProviderException", AccessFlags = 33)]
		public partial class NoSuchProviderException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchProviderException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchProviderException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/DigestInputStream
		/// </java-name>
		[Dot42.DexImport("java/security/DigestInputStream", AccessFlags = 33)]
		public partial class DigestInputStream : global::Java.Io.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "Ljava/security/MessageDigest;", AccessFlags = 4)]
				protected internal global::Java.Security.MessageDigest Digest;
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/security/MessageDigest;)V", AccessFlags = 1)]
				public DigestInputStream(global::Java.Io.InputStream inputStream, global::Java.Security.MessageDigest messageDigest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMessageDigest
				/// </java-name>
				[Dot42.DexImport("getMessageDigest", "()Ljava/security/MessageDigest;", AccessFlags = 1)]
				public virtual global::Java.Security.MessageDigest GetMessageDigest() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.MessageDigest);
				}

				/// <java-name>
				/// setMessageDigest
				/// </java-name>
				[Dot42.DexImport("setMessageDigest", "(Ljava/security/MessageDigest;)V", AccessFlags = 1)]
				public virtual void SetMessageDigest(global::Java.Security.MessageDigest messageDigest) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "()I", AccessFlags = 1)]
				public override int Read() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// on
				/// </java-name>
				[Dot42.DexImport("on", "(Z)V", AccessFlags = 1)]
				public virtual void On(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DigestInputStream() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMessageDigest
				/// </java-name>
				public global::Java.Security.MessageDigest MessageDigest
				{
				[Dot42.DexImport("getMessageDigest", "()Ljava/security/MessageDigest;", AccessFlags = 1)]
						get{ return GetMessageDigest(); }
				[Dot42.DexImport("setMessageDigest", "(Ljava/security/MessageDigest;)V", AccessFlags = 1)]
						set{ SetMessageDigest(value); }
				}

		}

		/// <java-name>
		/// java/security/PrivilegedAction
		/// </java-name>
		[Dot42.DexImport("java/security/PrivilegedAction", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IPrivilegedAction<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TT;")]
				T Run() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/GuardedObject
		/// </java-name>
		[Dot42.DexImport("java/security/GuardedObject", AccessFlags = 33)]
		public partial class GuardedObject : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/security/Guard;)V", AccessFlags = 1)]
				public GuardedObject(object @object, global::Java.Security.IGuard guard) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getObject
				/// </java-name>
				[Dot42.DexImport("getObject", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetObject() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GuardedObject() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getObject
				/// </java-name>
				public object Object
				{
				[Dot42.DexImport("getObject", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetObject(); }
				}

		}

		/// <java-name>
		/// java/security/AccessControlContext
		/// </java-name>
		[Dot42.DexImport("java/security/AccessControlContext", AccessFlags = 49)]
		public sealed partial class AccessControlContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/AccessControlContext;Ljava/security/DomainCombiner;)V", AccessFlags = 1)]
				public AccessControlContext(global::Java.Security.AccessControlContext accessControlContext, global::Java.Security.IDomainCombiner domainCombiner) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/security/ProtectionDomain;)V", AccessFlags = 1)]
				public AccessControlContext(global::Java.Security.ProtectionDomain[] protectionDomain) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/Permission;)V", AccessFlags = 1)]
				public void CheckPermission(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDomainCombiner
				/// </java-name>
				[Dot42.DexImport("getDomainCombiner", "()Ljava/security/DomainCombiner;", AccessFlags = 1)]
				public global::Java.Security.IDomainCombiner GetDomainCombiner() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IDomainCombiner);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AccessControlContext() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDomainCombiner
				/// </java-name>
				public global::Java.Security.IDomainCombiner DomainCombiner
				{
				[Dot42.DexImport("getDomainCombiner", "()Ljava/security/DomainCombiner;", AccessFlags = 1)]
						get{ return GetDomainCombiner(); }
				}

		}

		/// <java-name>
		/// java/security/KeyPairGenerator
		/// </java-name>
		[Dot42.DexImport("java/security/KeyPairGenerator", AccessFlags = 1057)]
		public abstract partial class KeyPairGenerator : global::Java.Security.KeyPairGeneratorSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyPairGenerator(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/KeyPairGenerator;", AccessFlags = 9)]
				public static global::Java.Security.KeyPairGenerator GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyPairGenerator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyPairGenerator;", AccessFlags = 9)]
				public static global::Java.Security.KeyPairGenerator GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyPairGenerator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyPairGenerator;", AccessFlags = 9)]
				public static global::Java.Security.KeyPairGenerator GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyPairGenerator);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(I)V", AccessFlags = 1)]
				public virtual void Initialize(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 1)]
				public virtual void Initialize(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// genKeyPair
				/// </java-name>
				[Dot42.DexImport("genKeyPair", "()Ljava/security/KeyPair;", AccessFlags = 17)]
				public global::Java.Security.KeyPair GenKeyPair() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyPair);
				}

				/// <java-name>
				/// generateKeyPair
				/// </java-name>
				[Dot42.DexImport("generateKeyPair", "()Ljava/security/KeyPair;", AccessFlags = 1)]
				public override global::Java.Security.KeyPair GenerateKeyPair() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyPair);
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(ILjava/security/SecureRandom;)V", AccessFlags = 1)]
				public override void Initialize(int int32, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 1)]
				public override void Initialize(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec, global::Java.Security.SecureRandom secureRandom) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyPairGenerator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAlgorithm(); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

		}

		/// <java-name>
		/// java/security/InvalidKeyException
		/// </java-name>
		[Dot42.DexImport("java/security/InvalidKeyException", AccessFlags = 33)]
		public partial class InvalidKeyException : global::Java.Security.KeyException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidKeyException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidKeyException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidKeyException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidKeyException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/SecureClassLoader
		/// </java-name>
		[Dot42.DexImport("java/security/SecureClassLoader", AccessFlags = 33)]
		public partial class SecureClassLoader : global::Java.Lang.ClassLoader
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SecureClassLoader() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/ClassLoader;)V", AccessFlags = 4)]
				protected internal SecureClassLoader(global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.PermissionCollection GetPermissions(global::Java.Security.CodeSource codeSource) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string @string, sbyte[] sByte, int int32, int int321, global::Java.Security.CodeSource codeSource) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class;", AccessFlags = 20, IgnoreFromJava = true, Signature = "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string @string, byte[] @byte, int int32, int int321, global::Java.Security.CodeSource codeSource) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/CodeSource;)Ljava/lang/Cla" +
    "ss;", AccessFlags = 20, Signature = "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/CodeSource;)Ljava/lang/Cla" +
    "ss<*>;")]
				protected internal global::System.Type DefineClass(string @string, global::Java.Nio.ByteBuffer byteBuffer, global::Java.Security.CodeSource codeSource) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

		}

		/// <java-name>
		/// java/security/Permissions
		/// </java-name>
		[Dot42.DexImport("java/security/Permissions", AccessFlags = 49)]
		public sealed partial class Permissions : global::Java.Security.PermissionCollection, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Permissions() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/security/Permission;)V", AccessFlags = 1)]
				public override void Add(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// elements
				/// </java-name>
				[Dot42.DexImport("elements", "()Ljava/util/Enumeration;", AccessFlags = 1, Signature = "()Ljava/util/Enumeration<Ljava/security/Permission;>;")]
				public override global::Java.Util.IEnumeration<global::Java.Security.Permission> Elements() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<global::Java.Security.Permission>);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/Permission;)Z", AccessFlags = 1)]
				public override bool Implies(global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// java/security/PrivilegedExceptionAction
		/// </java-name>
		[Dot42.DexImport("java/security/PrivilegedExceptionAction", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IPrivilegedExceptionAction<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()Ljava/lang/Object;", AccessFlags = 1025, Signature = "()TT;")]
				T Run() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/SecureRandom
		/// </java-name>
		[Dot42.DexImport("java/security/SecureRandom", AccessFlags = 33)]
		public partial class SecureRandom : global::System.Random
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecureRandom() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public SecureRandom(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public SecureRandom(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/SecureRandomSpi;Ljava/security/Provider;)V", AccessFlags = 4)]
				protected internal SecureRandom(global::Java.Security.SecureRandomSpi secureRandomSpi, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/SecureRandom;", AccessFlags = 9)]
				public static global::Java.Security.SecureRandom GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.SecureRandom);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/SecureRandom;", AccessFlags = 9)]
				public static global::Java.Security.SecureRandom GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.SecureRandom);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/SecureRandom;", AccessFlags = 9)]
				public static global::Java.Security.SecureRandom GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.SecureRandom);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setSeed
				/// </java-name>
				[Dot42.DexImport("setSeed", "([B)V", AccessFlags = 33)]
				public virtual void SetSeed(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSeed
				/// </java-name>
				[Dot42.DexImport("setSeed", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public virtual void SetSeed(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSeed
				/// </java-name>
				[Dot42.DexImport("setSeed", "(J)V", AccessFlags = 1)]
				public override void SetSeed(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nextBytes
				/// </java-name>
				[Dot42.DexImport("nextBytes", "([B)V", AccessFlags = 33)]
				public override void NextBytes(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nextBytes
				/// </java-name>
				[Dot42.DexImport("nextBytes", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public override void NextBytes(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(I)I", AccessFlags = 20)]
				protected internal override int JavaNext(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSeed
				/// </java-name>
				[Dot42.DexImport("getSeed", "(I)[B", AccessFlags = 9)]
				public static sbyte[] JavaGetSeed(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getSeed
				/// </java-name>
				[Dot42.DexImport("getSeed", "(I)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] GetSeed(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// generateSeed
				/// </java-name>
				[Dot42.DexImport("generateSeed", "(I)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGenerateSeed(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// generateSeed
				/// </java-name>
				[Dot42.DexImport("generateSeed", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GenerateSeed(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAlgorithm(); }
				}

		}

		/// <java-name>
		/// java/security/DigestException
		/// </java-name>
		[Dot42.DexImport("java/security/DigestException", AccessFlags = 33)]
		public partial class DigestException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DigestException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DigestException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public DigestException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public DigestException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/AlgorithmParameters
		/// </java-name>
		[Dot42.DexImport("java/security/AlgorithmParameters", AccessFlags = 33)]
		public partial class AlgorithmParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/AlgorithmParametersSpi;Ljava/security/Provider;Ljava/lang/String;" +
    ")V", AccessFlags = 4)]
				protected internal AlgorithmParameters(global::Java.Security.AlgorithmParametersSpi algorithmParametersSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameters;", AccessFlags = 9)]
				public static global::Java.Security.AlgorithmParameters GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameters;", AccessFlags = 9)]
				public static global::Java.Security.AlgorithmParameters GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameters;", AccessFlags = 9)]
				public static global::Java.Security.AlgorithmParameters GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
				public global::Java.Security.Provider GetProvider() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
				public string GetAlgorithm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec algorithmParameterSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([B)V", AccessFlags = 17)]
				public void Init(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Init(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([BLjava/lang/String;)V", AccessFlags = 17)]
				public void Init(sbyte[] sByte, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([BLjava/lang/String;)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Init(byte[] @byte, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameterSpec
				/// </java-name>
				[Dot42.DexImport("getParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 17, Signature = "<T::Ljava/security/spec/AlgorithmParameterSpec;>(Ljava/lang/Class<TT;>;)TT;")]
				public T GetParameterSpec<T>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "(Ljava/lang/String;)[B", AccessFlags = 17)]
				public sbyte[] JavaGetEncoded(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "(Ljava/lang/String;)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GetEncoded(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AlgorithmParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
				[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return GetProvider(); }
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
				[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return GetAlgorithm(); }
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

		}

}

