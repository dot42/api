#pragma warning disable 1717
namespace Java.Security
{
		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/AccessControlContext
		/// </java-name>
		[Dot42.DexImport("java/security/AccessControlContext", AccessFlags = 49)]
		public sealed partial class AccessControlContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/AccessControlContext;Ljava/security/DomainCombiner;)V", AccessFlags = 1)]
				public AccessControlContext(global::Java.Security.AccessControlContext acc, global::Java.Security.IDomainCombiner combiner) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/security/ProtectionDomain;)V", AccessFlags = 1)]
				public AccessControlContext(global::Java.Security.ProtectionDomain[] context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/Permission;)V", AccessFlags = 1)]
				public void CheckPermission(global::Java.Security.Permission perm) /* MethodBuilder.Create */ 
				{
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
						get{ return default(global::Java.Security.IDomainCombiner); }
				}

		}

		/// <summary>
		///  <para> <c>AccessControlException </c> is thrown if the access control infrastructure denies protected access due to missing permissions. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/AccessControlException
		/// </java-name>
		[Dot42.DexImport("java/security/AccessControlException", AccessFlags = 33)]
		public partial class AccessControlException : global::Java.Lang.SecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>AccessControlException </c> with the given message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AccessControlException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>AccessControlException </c> with the given message and the requested <c>Permission </c> which was not granted.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/Permission;)V", AccessFlags = 1)]
				public AccessControlException(string message, global::Java.Security.Permission perm) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AccessControlException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the requested permission that caused this Exception or <c>null </c> if there is no corresponding <c>Permission </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the requested permission that caused this Exception, maybe <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPermission
				/// </java-name>
				public virtual global::Java.Security.Permission Permission
				{
						[Dot42.DexImport("getPermission", "()Ljava/security/Permission;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Permission); }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Calls <c>action.run() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// doPrivileged
				/// </java-name>
				[Dot42.DexImport("doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedAction<TT;>;)TT;")]
				public static T DoPrivileged<T>(global::Java.Security.IPrivilegedAction<T> action) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Calls <c>action.run() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// doPrivileged
				/// </java-name>
				[Dot42.DexImport("doPrivileged", "(Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/" +
    "Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedAction<TT;>;Ljava/security/Access" +
    "ControlContext;)TT;")]
				public static T DoPrivileged<T>(global::Java.Security.IPrivilegedAction<T> action, global::Java.Security.AccessControlContext context) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Calls <c>action.run() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// doPrivileged
				/// </java-name>
				[Dot42.DexImport("doPrivileged", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedExceptionAction<TT;>;)TT;")]
				public static T DoPrivileged<T>(global::Java.Security.IPrivilegedExceptionAction<T> action) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Calls <c>action.run() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// doPrivileged
				/// </java-name>
				[Dot42.DexImport("doPrivileged", "(Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Lj" +
    "ava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedExceptionAction<TT;>;Ljava/securi" +
    "ty/AccessControlContext;)TT;")]
				public static T DoPrivileged<T>(global::Java.Security.IPrivilegedExceptionAction<T> action, global::Java.Security.AccessControlContext context) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Calls <c>action.run() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// doPrivilegedWithCombiner
				/// </java-name>
				[Dot42.DexImport("doPrivilegedWithCombiner", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedAction<TT;>;)TT;")]
				public static T DoPrivilegedWithCombiner<T>(global::Java.Security.IPrivilegedAction<T> action) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Calls <c>action.run() </c> . </para>        
				/// </summary>
				/// <java-name>
				/// doPrivilegedWithCombiner
				/// </java-name>
				[Dot42.DexImport("doPrivilegedWithCombiner", "(Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljava/security/PrivilegedExceptionAction<TT;>;)TT;")]
				public static T DoPrivilegedWithCombiner<T>(global::Java.Security.IPrivilegedExceptionAction<T> action) /* MethodBuilder.Create */ 
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
				public static global::Java.Security.AccessControlContext Context
				{
						[Dot42.DexImport("getContext", "()Ljava/security/AccessControlContext;", AccessFlags = 9)]
						get{ return default(global::Java.Security.AccessControlContext); }
				}

		}

		/// <summary>
		///  <para> <c>AlgorithmParameterGenerator </c> is an engine class which is capable of generating parameters for the algorithm it was initialized with. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/AlgorithmParameterGenerator
		/// </java-name>
		[Dot42.DexImport("java/security/AlgorithmParameterGenerator", AccessFlags = 33)]
		public partial class AlgorithmParameterGenerator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>AlgorithmParameterGenerator </c> with the given arguments.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/AlgorithmParameterGeneratorSpi;Ljava/security/Provider;Ljava/lang" +
    "/String;)V", AccessFlags = 4)]
				protected internal AlgorithmParameterGenerator(global::Java.Security.AlgorithmParameterGeneratorSpi paramGenSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new instance of <c>AlgorithmParameterGenerator </c> for the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>AlgorithmParameterGenerator </c> for the specified algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;", AccessFlags = 9)]
				public static global::Java.Security.AlgorithmParameterGenerator GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameterGenerator </c> with the given size. The default parameter set and a default <c>SecureRandom </c> instance will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(I)V", AccessFlags = 17)]
				public void Init(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameterGenerator </c> with the given size and the given <c>SecureRandom </c> . The default parameter set will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(ILjava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(int size, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameterGenerator </c> with the given size. The default parameter set and a default <c>SecureRandom </c> instance will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameterGenerator </c> with the given size and the given <c>SecureRandom </c> . The default parameter set will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec size, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes and returns <c>AlgorithmParameters </c> for this generator's algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>AlgorithmParameters </c> for this generator's algorithm. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the name of the algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the provider associated with this <c>AlgorithmParameterGenerator </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider associated with this <c>AlgorithmParameterGenerator </c> . </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

		}

		/// <summary>
		///  <para> <c>AlgorithmParameterGeneratorSpi </c> is the Service Provider Interface (SPI) definition for <c>AlgorithmParameterGenerator </c> .</para> <para> <para>AlgorithmParameterGenerator </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/AlgorithmParameterGeneratorSpi
		/// </java-name>
		[Dot42.DexImport("java/security/AlgorithmParameterGeneratorSpi", AccessFlags = 1057)]
		public abstract partial class AlgorithmParameterGeneratorSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>AlgorithmParameterGeneratorSpi </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AlgorithmParameterGeneratorSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameterGeneratorSpi </c> with the given size and the given <c>SecureRandom </c> . The default parameter set will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(ILjava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(int size, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameterGeneratorSpi </c> with the given size and the given <c>SecureRandom </c> . The default parameter set will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.Spec.IAlgorithmParameterSpec size, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Computes and returns <c>AlgorithmParameters </c> for this generator's algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>AlgorithmParameters </c> for this generator's algorithm. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateParameters
				/// </java-name>
				[Dot42.DexImport("engineGenerateParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.AlgorithmParameters EngineGenerateParameters() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <c>AlgorithmParameters </c> is an engine class which provides algorithm parameters. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/AlgorithmParameters
		/// </java-name>
		[Dot42.DexImport("java/security/AlgorithmParameters", AccessFlags = 33)]
		public partial class AlgorithmParameters
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>AlgorithmParameters </c> with the given arguments.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/AlgorithmParametersSpi;Ljava/security/Provider;Ljava/lang/String;" +
    ")V", AccessFlags = 4)]
				protected internal AlgorithmParameters(global::Java.Security.AlgorithmParametersSpi algPramSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new instance of <c>AlgorithmParameters </c> for the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>AlgorithmParameters </c> for the specified algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameters;", AccessFlags = 9)]
				public static global::Java.Security.AlgorithmParameters GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameters </c> with the specified <c>AlgorithmParameterSpec </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void Init(global::Java.Security.Spec.IAlgorithmParameterSpec paramSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameters </c> with the specified <c>AlgorithmParameterSpec </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([B)V", AccessFlags = 17)]
				public void Init(sbyte[] paramSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameters </c> with the specified <c>AlgorithmParameterSpec </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Init(byte[] paramSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameters </c> with the specified <c>byte[] </c> using the specified decoding format.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([BLjava/lang/String;)V", AccessFlags = 17)]
				public void Init(sbyte[] @params, string format) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParameters </c> with the specified <c>byte[] </c> using the specified decoding format.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "([BLjava/lang/String;)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Init(byte[] @params, string format) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>AlgorithmParameterSpec </c> for this <c>AlgorithmParameters </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>AlgorithmParameterSpec </c> for this <c>AlgorithmParameters </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParameterSpec
				/// </java-name>
				[Dot42.DexImport("getParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 17, Signature = "<T::Ljava/security/spec/AlgorithmParameterSpec;>(Ljava/lang/Class<TT;>;)TT;")]
				public T GetParameterSpec<T>(global::System.Type paramSpec) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Returns this <c>AlgorithmParameters </c> in their default encoding format. The default encoding format is ASN.1.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded parameters. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns this <c>AlgorithmParameters </c> in the specified encoding format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded parameters. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "(Ljava/lang/String;)[B", AccessFlags = 17)]
				public sbyte[] JavaGetEncoded(string format) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns this <c>AlgorithmParameters </c> in the specified encoding format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded parameters. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "(Ljava/lang/String;)[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] GetEncoded(string format) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this  <c>AlgorithmParameters </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>AlgorithmParameters </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the provider associated with this <c>AlgorithmParameters </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider associated with this <c>AlgorithmParameters </c> . </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <summary>
				///  <para>Returns the name of the algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns this <c>AlgorithmParameters </c> in their default encoding format. The default encoding format is ASN.1.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded parameters. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <summary>
		///  <para> <c>AlgorithmParametersSpi </c> is the Service Provider Interface (SPI) definition for <c>AlgorithmParameters </c> .</para> <para> <para>AlgorithmParameters </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParametersSpi </c> with the specified  <c>AlgorithmParameterSpec </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(global::Java.Security.Spec.IAlgorithmParameterSpec paramSpec) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParametersSpi </c> with the specified  <c>AlgorithmParameterSpec </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([B)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(sbyte[] paramSpec) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParametersSpi </c> with the specified  <c>AlgorithmParameterSpec </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineInit(byte[] paramSpec) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParametersSpi </c> with the specified  <c>byte[] </c> using the specified decoding format.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([BLjava/lang/String;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInit(sbyte[] @params, string format) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>AlgorithmParametersSpi </c> with the specified  <c>byte[] </c> using the specified decoding format.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInit
				/// </java-name>
				[Dot42.DexImport("engineInit", "([BLjava/lang/String;)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineInit(byte[] @params, string format) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the <c>AlgorithmParameterSpec </c> for this <c>AlgorithmParametersSpi </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>AlgorithmParameterSpec </c> for this <c>AlgorithmParametersSpi </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineGetParameterSpec
				/// </java-name>
				[Dot42.DexImport("engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", AccessFlags = 1028, Signature = "<T::Ljava/security/spec/AlgorithmParameterSpec;>(Ljava/lang/Class<TT;>;)TT;")]
				protected internal abstract T EngineGetParameterSpec<T>(global::System.Type paramSpec) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the parameters in their default encoding format. The default encoding format is ASN.1.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded parameters. </para>
				/// </returns>
				/// <java-name>
				/// engineGetEncoded
				/// </java-name>
				[Dot42.DexImport("engineGetEncoded", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGetEncoded() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the parameters in their default encoding format. The default encoding format is ASN.1.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded parameters. </para>
				/// </returns>
				/// <java-name>
				/// engineGetEncoded
				/// </java-name>
				[Dot42.DexImport("engineGetEncoded", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGetEncoded() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the parameters in the specified encoding format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded parameters. </para>
				/// </returns>
				/// <java-name>
				/// engineGetEncoded
				/// </java-name>
				[Dot42.DexImport("engineGetEncoded", "(Ljava/lang/String;)[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGetEncoded(string format) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the parameters in the specified encoding format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded parameters. </para>
				/// </returns>
				/// <java-name>
				/// engineGetEncoded
				/// </java-name>
				[Dot42.DexImport("engineGetEncoded", "(Ljava/lang/String;)[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGetEncoded(string format) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this  <c>AlgorithmParametersSpi </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>AlgorithmParametersSpi </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineToString
				/// </java-name>
				[Dot42.DexImport("engineToString", "()Ljava/lang/String;", AccessFlags = 1028)]
				protected internal abstract string EngineToString() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/AllPermission
		/// </java-name>
		[Dot42.DexImport("java/security/AllPermission", AccessFlags = 49)]
		public sealed partial class AllPermission : global::Java.Security.Permission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public AllPermission(string name, string actions) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AllPermission() /* MethodBuilder.Create */ 
				{
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
				public override string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/AuthProvider
		/// </java-name>
		[Dot42.DexImport("java/security/AuthProvider", AccessFlags = 1057)]
		public abstract partial class AuthProvider : global::Java.Security.Provider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;DLjava/lang/String;)V", AccessFlags = 4)]
				protected internal AuthProvider(string name, double version, string info) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// login
				/// </java-name>
				[Dot42.DexImport("login", "(Ljavax/security/auth/Subject;Ljavax/security/auth/callback/CallbackHandler;)V", AccessFlags = 1025)]
				public abstract void Login(global::Javax.Security.Auth.Subject subject, global::Javax.Security.Auth.Callback.ICallbackHandler handler) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// logout
				/// </java-name>
				[Dot42.DexImport("logout", "()V", AccessFlags = 1025)]
				public abstract void Logout() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCallbackHandler
				/// </java-name>
				[Dot42.DexImport("setCallbackHandler", "(Ljavax/security/auth/callback/CallbackHandler;)V", AccessFlags = 1025)]
				public abstract void SetCallbackHandler(global::Javax.Security.Auth.Callback.ICallbackHandler handler) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AuthProvider() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/BasicPermission
		/// </java-name>
		[Dot42.DexImport("java/security/BasicPermission", AccessFlags = 1057)]
		public abstract partial class BasicPermission : global::Java.Security.Permission, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicPermission(string name) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicPermission(string name, string action) /* MethodBuilder.Create */ 
				{
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
				public override string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para> <c>CodeSigner </c> represents a signer of code. Instances are immutable. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/CodeSigner
		/// </java-name>
		[Dot42.DexImport("java/security/CodeSigner", AccessFlags = 49)]
		public sealed partial class CodeSigner : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>CodeSigner </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPath;Ljava/security/Timestamp;)V", AccessFlags = 1)]
				public CodeSigner(global::Java.Security.Cert.CertPath signerCertPath, global::Java.Security.Timestamp timestamp) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compares the specified object with this <c>CodeSigner </c> for equality. Returns <c>true </c> if the specified object is also an instance of  <c>CodeSigner </c> , the two <c>CodeSigner </c> encapsulate the same certificate path and the same time stamp, if present in both.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this <c>CodeSigner </c> , otherwise <c>false </c> . </para>
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
				///  <para>Returns the hash code value for this <c>CodeSigner </c> . Returns the same hash code for <c>CodeSigner </c> s that are equal to each other as required by the general contract of Object#hashCode.</para> <para> <para>Object::equals(Object) </para> <para>CodeSigner::equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code value for this <c>CodeSigner </c> . </para>
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
				///  <para>Returns a string containing a concise, human-readable description of the this <c>CodeSigner </c> including its first certificate and its time stamp, if present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>CodeSigner </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the certificate path associated with this <c>CodeSigner </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate path associated with this <c>CodeSigner </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSignerCertPath
				/// </java-name>
				public global::Java.Security.Cert.CertPath SignerCertPath
				{
						[Dot42.DexImport("getSignerCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.CertPath); }
				}

				/// <summary>
				///  <para>Returns the time stamp associated with this <c>CodeSigner </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the time stamp associated with this <c>CodeSigner </c> , maybe  <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTimestamp
				/// </java-name>
				public global::Java.Security.Timestamp Timestamp
				{
						[Dot42.DexImport("getTimestamp", "()Ljava/security/Timestamp;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Timestamp); }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/CodeSource
		/// </java-name>
		[Dot42.DexImport("java/security/CodeSource", AccessFlags = 33)]
		public partial class CodeSource : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/net/URL;[Ljava/security/cert/Certificate;)V", AccessFlags = 1)]
				public CodeSource(global::Java.Net.URL location, global::Java.Security.Cert.Certificate[] certs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/net/URL;[Ljava/security/CodeSigner;)V", AccessFlags = 1)]
				public CodeSource(global::Java.Net.URL location, global::Java.Security.CodeSigner[] certs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/CodeSource;)Z", AccessFlags = 1)]
				public virtual bool Implies(global::Java.Security.CodeSource cs) /* MethodBuilder.Create */ 
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
						get{ return default(global::Java.Security.Cert.Certificate[]); }
				}

				/// <java-name>
				/// getCodeSigners
				/// </java-name>
				public global::Java.Security.CodeSigner[] CodeSigners
				{
						[Dot42.DexImport("getCodeSigners", "()[Ljava/security/CodeSigner;", AccessFlags = 17)]
						get{ return default(global::Java.Security.CodeSigner[]); }
				}

				/// <java-name>
				/// getLocation
				/// </java-name>
				public global::Java.Net.URL Location
				{
						[Dot42.DexImport("getLocation", "()Ljava/net/URL;", AccessFlags = 17)]
						get{ return default(global::Java.Net.URL); }
				}

		}

		/// <summary>
		///  <para> <c>DigestException </c> is a general message digest exception. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>DigestException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DigestException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>DigestException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public DigestException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public DigestException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>DigestInputStream </c> is a <c>FilterInputStream </c> which maintains an associated message digest. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/DigestInputStream
		/// </java-name>
		[Dot42.DexImport("java/security/DigestInputStream", AccessFlags = 33)]
		public partial class DigestInputStream : global::Java.IO.FilterInputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The message digest for this stream. </para>        
				/// </summary>
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "Ljava/security/MessageDigest;", AccessFlags = 4)]
				protected internal global::Java.Security.MessageDigest Digest;
				/// <summary>
				///  <para>Constructs a new instance of this <c>DigestInputStream </c> , using the given <c>stream </c> and the <c>digest </c> .</para> <para> <b>Warning:</b> passing a null source creates an invalid  <c>DigestInputStream </c> . All operations on such a stream will fail.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;Ljava/security/MessageDigest;)V", AccessFlags = 1)]
				public DigestInputStream(global::Java.IO.InputStream stream, global::Java.Security.MessageDigest digest) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reads the next byte and returns it as an <c>int </c> . Updates the digest for the byte if this function is on(boolean). </para> <para>This operation is blocking.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the byte which was read or -1 at end of stream. </para>
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
				///  <para>Reads up to <c>byteCount </c> bytes into <c>buffer </c> , starting at  <c>byteOffset </c> . Updates the digest if this function is on(boolean).</para> <para>This operation is blocking.</para> <para>Returns the number of bytes actually read or -1 if the end of the filtered stream has been reached while reading.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1)]
				public override int Read(sbyte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Reads up to <c>byteCount </c> bytes into <c>buffer </c> , starting at  <c>byteOffset </c> . Updates the digest if this function is on(boolean).</para> <para>This operation is blocking.</para> <para>Returns the number of bytes actually read or -1 if the end of the filtered stream has been reached while reading.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// read
				/// </java-name>
				[Dot42.DexImport("read", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public override int Read(byte[] buffer, int byteOffset, int byteCount) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Enables or disables the digest function (default is on).</para> <para> <para>MessageDigest </para></para>        
				/// </summary>
				/// <java-name>
				/// on
				/// </java-name>
				[Dot42.DexImport("on", "(Z)V", AccessFlags = 1)]
				public virtual void On(bool on) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this  <c>DigestInputStream </c> including the digest.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>DigestInputStream </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the message digest for this stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the message digest for this stream. </para>
				/// </returns>
				/// <java-name>
				/// getMessageDigest
				/// </java-name>
				public virtual global::Java.Security.MessageDigest MessageDigest
				{
						[Dot42.DexImport("getMessageDigest", "()Ljava/security/MessageDigest;", AccessFlags = 1)]
						get{ return default(global::Java.Security.MessageDigest); }
						[Dot42.DexImport("setMessageDigest", "(Ljava/security/MessageDigest;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para> <c>DigestOutputStream </c> is a <c>FilterOutputStream </c> which maintains an associated message digest. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/DigestOutputStream
		/// </java-name>
		[Dot42.DexImport("java/security/DigestOutputStream", AccessFlags = 33)]
		public partial class DigestOutputStream : global::Java.IO.FilterOutputStream
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The message digest for this stream. </para>        
				/// </summary>
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "Ljava/security/MessageDigest;", AccessFlags = 4)]
				protected internal global::Java.Security.MessageDigest Digest;
				/// <summary>
				///  <para>Constructs a new instance of this <c>DigestOutputStream </c> , using the given <c>stream </c> and the <c>digest </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/OutputStream;Ljava/security/MessageDigest;)V", AccessFlags = 1)]
				public DigestOutputStream(global::Java.IO.OutputStream stream, global::Java.Security.MessageDigest digest) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes the specified <c>int </c> to the stream. Updates the digest if this function is on(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "(I)V", AccessFlags = 1)]
				public override void Write(int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>len </c> bytes into the stream, starting from the specified offset. Updates the digest if this function is on(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1)]
				public override void Write(sbyte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Writes <c>len </c> bytes into the stream, starting from the specified offset. Updates the digest if this function is on(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// write
				/// </java-name>
				[Dot42.DexImport("write", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public override void Write(byte[] b, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables or disables the digest function (default is on).</para> <para> <para>MessageDigest </para></para>        
				/// </summary>
				/// <java-name>
				/// on
				/// </java-name>
				[Dot42.DexImport("on", "(Z)V", AccessFlags = 1)]
				public virtual void On(bool on) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this  <c>DigestOutputStream </c> including the digest.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>DigestOutputStream </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the message digest for this stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the message digest for this stream. </para>
				/// </returns>
				/// <java-name>
				/// getMessageDigest
				/// </java-name>
				public virtual global::Java.Security.MessageDigest MessageDigest
				{
						[Dot42.DexImport("getMessageDigest", "()Ljava/security/MessageDigest;", AccessFlags = 1)]
						get{ return default(global::Java.Security.MessageDigest); }
						[Dot42.DexImport("setMessageDigest", "(Ljava/security/MessageDigest;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para> <c>GeneralSecurityException </c> is a general security exception and the superclass for all security specific exceptions. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>GeneralSecurityException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GeneralSecurityException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>GeneralSecurityException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public GeneralSecurityException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public GeneralSecurityException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>GuardedObject </c> controls access to an object, by checking all requests for the object with a <c>Guard </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/security/GuardedObject
		/// </java-name>
		[Dot42.DexImport("java/security/GuardedObject", AccessFlags = 33)]
		public partial class GuardedObject : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>GuardedObject </c> which protects access to the specified <c>Object </c> using the specified <c>Guard </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;Ljava/security/Guard;)V", AccessFlags = 1)]
				public GuardedObject(object @object, global::Java.Security.IGuard guard) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GuardedObject() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the guarded <c>Object </c> if the associated <c>Guard </c> permits access. If access is not granted, then a <c>SecurityException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the guarded object. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				public virtual object Object
				{
						[Dot42.DexImport("getObject", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

		}

		/// <summary>
		///  <para> <c>Certificate </c> represents an identity certificate, such as X.509 or PGP. Note: A <c>Certificate </c> instances does not make any statement about the validity of itself. It's in the responsibility of the application to verify the validity of its certificates.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use java.security.cert.Certificate instead.  <para>java.security.cert.Certificate </para></para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// java/security/Certificate
		/// </java-name>
		[Dot42.DexImport("java/security/Certificate", AccessFlags = 1537)]
		public partial interface ICertificate
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Decodes a certificate from the given <c>InputStream </c> . The format of the data to encode must be that identified by getFormat() and encoded by encode(OutputStream).</para> <para> <para>#encode(OutputStream) </para> <para>#getFormat() </para></para>        
				/// </summary>
				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/io/InputStream;)V", AccessFlags = 1025)]
				void Decode(global::Java.IO.InputStream stream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Encodes this certificate to an output stream. The decode(InputStream) method must be able to decode the format written by this method.</para> <para> <para>#decode(InputStream) </para></para>        
				/// </summary>
				/// <java-name>
				/// encode
				/// </java-name>
				[Dot42.DexImport("encode", "(Ljava/io/OutputStream;)V", AccessFlags = 1025)]
				void Encode(global::Java.IO.OutputStream stream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of the this <c>Certificate </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this certificate. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Z)Ljava/lang/String;", AccessFlags = 1025)]
				string ToString(bool detailed) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string identifying the format of this certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string identifying the format of this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				string Format
				{
						[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the guarantor of this certificate. That guarantor guarantees, that the public key of this certificate is from the principal returned by getPrincipal().</para> <para> <para>#getPrincipal() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the guarantor of this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getGuarantor
				/// </java-name>
				global::Java.Security.IPrincipal Guarantor
				{
						[Dot42.DexImport("getGuarantor", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the principal of this certificate. The principal is guaranteed by the guarantor returned by getGuarantor().</para> <para> <para>#getGuarantor() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the principal of this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getPrincipal
				/// </java-name>
				global::Java.Security.IPrincipal Principal
				{
						[Dot42.DexImport("getPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the public key of this certificate. The public key is guaranteed by the guarantor to belong to the principal.</para> <para> <para>#getGuarantor() </para> <para>Certificate::getPrincipal() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the public key of this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getPublicKey
				/// </java-name>
				global::Java.Security.IPublicKey PublicKey
				{
						[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para> <c>Identity </c> represents an identity like a person or a company.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Principal, KeyStore and the <c>java.security.cert </c> package instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// java/security/Identity
		/// </java-name>
		[Dot42.DexImport("java/security/Identity", AccessFlags = 1057)]
		public abstract partial class Identity : global::Java.Security.IPrincipal, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>Identity </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Identity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new instance of <c>Identity </c> with the specified name.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Identity(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new instance of <c>Identity </c> with the specified name and the scope of this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V", AccessFlags = 1)]
				public Identity(string name, global::Java.Security.IdentityScope scope) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a <c>Certificate </c> to this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addCertificate
				/// </java-name>
				[Dot42.DexImport("addCertificate", "(Ljava/security/Certificate;)V", AccessFlags = 1)]
				public virtual void AddCertificate(global::Java.Security.ICertificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the specified <c>Certificate </c> from this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeCertificate
				/// </java-name>
				[Dot42.DexImport("removeCertificate", "(Ljava/security/Certificate;)V", AccessFlags = 1)]
				public virtual void RemoveCertificate(global::Java.Security.ICertificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the certificates for this <c>Identity </c> . External modifications of the returned array has no impact on this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Certificates </c> for this <c>Identity </c> </para>
				/// </returns>
				/// <java-name>
				/// certificates
				/// </java-name>
				[Dot42.DexImport("certificates", "()[Ljava/security/Certificate;", AccessFlags = 1)]
				public virtual global::Java.Security.ICertificate[] Certificates() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.ICertificate[]);
				}

				/// <summary>
				///  <para>Compares the specified <c>Identity </c> with this <c>Identity </c> for equality and returns <c>true </c> if the specified object is equal,  <c>false </c> otherwise. </para> <para>To be equal, two <c>Identity </c> objects need to have the same name and the same public keys.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the <c>Identity </c> objects are equal, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// identityEquals
				/// </java-name>
				[Dot42.DexImport("identityEquals", "(Ljava/security/Identity;)Z", AccessFlags = 4)]
				protected internal virtual bool IdentityEquals(global::Java.Security.Identity identity) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of the this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>Permission </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Z)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString(bool detailed) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Compares the specified object with this <c>Identity </c> for equality and returns <c>true </c> if the specified object is equal, <c>false </c> otherwise. <c>Identity </c> objects are considered equal, if they have the same name and are in the same scope.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this <c>Identity </c> , otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the hash code value for this <c>Identity </c> . Returns the same hash code for <c>Identity </c> s that are equal to each other as required by the general contract of Object#hashCode.</para> <para> <para>Object::equals(Object) </para> <para>Identity::equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code value for this <c>Identity </c> . </para>
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
				///  <para>Returns a string containing a concise, human-readable description of the this <c>Identity </c> including its name and its scope.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>Identity </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the <c>IdentityScope </c> of this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>IdentityScope </c> of this <c>Identity </c> . </para>
				/// </returns>
				/// <java-name>
				/// getScope
				/// </java-name>
				public global::Java.Security.IdentityScope Scope
				{
						[Dot42.DexImport("getScope", "()Ljava/security/IdentityScope;", AccessFlags = 17)]
						get{ return default(global::Java.Security.IdentityScope); }
				}

				/// <summary>
				///  <para>Returns the <c>PublicKey </c> associated with this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>PublicKey </c> associated with this <c>Identity </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicKey
				/// </java-name>
				public virtual global::Java.Security.IPublicKey PublicKey
				{
						[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPublicKey); }
						[Dot42.DexImport("setPublicKey", "(Ljava/security/PublicKey;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the information string of this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the information string of this <c>Identity </c> . </para>
				/// </returns>
				/// <java-name>
				/// getInfo
				/// </java-name>
				public virtual string Info
				{
						[Dot42.DexImport("getInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setInfo", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the name of this <c>Identity </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this <c>Identity </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para> <c>IdentityScope </c> represents a scope for Identity objects.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use Principal, KeyStore and the <c>java.security.cert </c> package instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// java/security/IdentityScope
		/// </java-name>
		[Dot42.DexImport("java/security/IdentityScope", AccessFlags = 1057)]
		public abstract partial class IdentityScope : global::Java.Security.Identity
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>IdentityScope </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal IdentityScope() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>IdentityScope </c> with the specified name.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IdentityScope(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>IdentityScope </c> with the specified name and the specified scope.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V", AccessFlags = 1)]
				public IdentityScope(string name, global::Java.Security.IdentityScope scope) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the number of <c>Identity </c> objects in this scope.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of <c>Identity </c> objects in this scope. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				public abstract int Size() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the <c>Identity </c> with the name of the specified principal or  <c>null </c> if no <c>Identity </c> with the name of the specified principal is present in this scope.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Identity </c> with the specified name or <c>null </c> if not present. </para>
				/// </returns>
				/// <java-name>
				/// getIdentity
				/// </java-name>
				[Dot42.DexImport("getIdentity", "(Ljava/lang/String;)Ljava/security/Identity;", AccessFlags = 1025)]
				public abstract global::Java.Security.Identity GetIdentity(string principal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the <c>Identity </c> with the name of the specified principal or  <c>null </c> if no <c>Identity </c> with the name of the specified principal is present in this scope.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Identity </c> with the specified name or <c>null </c> if not present. </para>
				/// </returns>
				/// <java-name>
				/// getIdentity
				/// </java-name>
				[Dot42.DexImport("getIdentity", "(Ljava/security/Principal;)Ljava/security/Identity;", AccessFlags = 1)]
				public virtual global::Java.Security.Identity GetIdentity(global::Java.Security.IPrincipal principal) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Identity);
				}

				/// <summary>
				///  <para>Returns the <c>Identity </c> with the name of the specified principal or  <c>null </c> if no <c>Identity </c> with the name of the specified principal is present in this scope.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Identity </c> with the specified name or <c>null </c> if not present. </para>
				/// </returns>
				/// <java-name>
				/// getIdentity
				/// </java-name>
				[Dot42.DexImport("getIdentity", "(Ljava/security/PublicKey;)Ljava/security/Identity;", AccessFlags = 1025)]
				public abstract global::Java.Security.Identity GetIdentity(global::Java.Security.IPublicKey principal) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds an <c>Identity </c> to this <c>IdentityScope </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addIdentity
				/// </java-name>
				[Dot42.DexImport("addIdentity", "(Ljava/security/Identity;)V", AccessFlags = 1025)]
				public abstract void AddIdentity(global::Java.Security.Identity identity) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes an <c>Identity </c> from this <c>IdentityScope </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeIdentity
				/// </java-name>
				[Dot42.DexImport("removeIdentity", "(Ljava/security/Identity;)V", AccessFlags = 1025)]
				public abstract void RemoveIdentity(global::Java.Security.Identity identity) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an <c>Enumeration </c> over the <c>Identity </c> objects in this  <c>IdentityScope </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an <c>Enumeration </c> over the <c>Identity </c> objects in this  <c>IdentityScope </c> . </para>
				/// </returns>
				/// <java-name>
				/// identities
				/// </java-name>
				[Dot42.DexImport("identities", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/security/Identity;>;")]
				public abstract global::Java.Util.IEnumeration<global::Java.Security.Identity> Identities() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this  <c>IdentityScope </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>IdentityScope </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the system's scope.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the system's scope. </para>
				/// </returns>
				/// <java-name>
				/// getSystemScope
				/// </java-name>
				public static global::Java.Security.IdentityScope SystemScope
				{
						[Dot42.DexImport("getSystemScope", "()Ljava/security/IdentityScope;", AccessFlags = 9)]
						get{ return default(global::Java.Security.IdentityScope); }
						[Dot42.DexImport("setSystemScope", "(Ljava/security/IdentityScope;)V", AccessFlags = 12)]
						set{ }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/DomainCombiner
		/// </java-name>
		[Dot42.DexImport("java/security/DomainCombiner", AccessFlags = 1537)]
		public partial interface IDomainCombiner
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns a combination of the two provided <c>ProtectionDomain </c> arrays. Implementers can simply merge the two arrays into one, remove duplicates and perform other optimizations.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a single <c>ProtectionDomain </c> array computed from the two provided arrays. </para>
				/// </returns>
				/// <java-name>
				/// combine
				/// </java-name>
				[Dot42.DexImport("combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/securi" +
    "ty/ProtectionDomain;", AccessFlags = 1025)]
				global::Java.Security.ProtectionDomain[] Combine(global::Java.Security.ProtectionDomain[] current, global::Java.Security.ProtectionDomain[] assigned) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <c>Guard </c> implementors protect access to other objects. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/Guard
		/// </java-name>
		[Dot42.DexImport("java/security/Guard", AccessFlags = 1537)]
		public partial interface IGuard
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Checks whether access to the specified <c>Object </c> should be granted. This method returns silently if access is granted, otherwise a <c>SecurityException </c> is thrown.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// checkGuard
				/// </java-name>
				[Dot42.DexImport("checkGuard", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void CheckGuard(object @object) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <c>Key </c> is the common interface for all keys.</para> <para> <para>PublicKey </para> <para>PrivateKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/Key
		/// </java-name>
		[Dot42.DexImport("java/security/Key", AccessFlags = 1537)]
		public partial interface IKey : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the name of the algorithm of this key. If the algorithm is unknown, <c>null </c> is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm of this key or <c>null </c> if the algorithm is unknown. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the name of the format used to encode this key, or <c>null </c> if it can not be encoded.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the format used to encode this key, or <c>null </c> if it can not be encoded. </para>
				/// </returns>
				/// <java-name>
				/// getFormat
				/// </java-name>
				string Format
				{
						[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the encoded form of this key, or <c>null </c> if encoding is not supported by this key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded form of this key, or <c>null </c> if encoding is not supported by this key. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

		}

		/// <summary>
		///  <para> <c>Key </c> is the common interface for all keys.</para> <para> <para>PublicKey </para> <para>PrivateKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/Key
		/// </java-name>
		[Dot42.DexImport("java/security/Key", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The <c>serialVersionUID </c> to be compatible with JDK1.1. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 6603384152749567654;
		}

		/// <summary>
		///  <para> <c>InvalidAlgorithmParameterException </c> indicates the occurrence of invalid algorithm parameters. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>InvalidAlgorithmParameterException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidAlgorithmParameterException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>InvalidAlgorithmParameterException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidAlgorithmParameterException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidAlgorithmParameterException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>InvalidKeyException </c> indicates exceptional conditions, caused by an invalid key. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>InvalidKeyException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidKeyException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>InvalidKeyException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidKeyException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidKeyException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>InvalidParameterException </c> indicates exceptional conditions, caused by invalid parameters. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/InvalidParameterException
		/// </java-name>
		[Dot42.DexImport("java/security/InvalidParameterException", AccessFlags = 33)]
		public partial class InvalidParameterException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>InvalidParameterException </c> with the given message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidParameterException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>InvalidParameterException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidParameterException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>Principal </c> s are objects which have identities. These can be individuals, groups, corporations, unique program executions, etc. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/Principal
		/// </java-name>
		[Dot42.DexImport("java/security/Principal", AccessFlags = 1537)]
		public partial interface IPrincipal
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Compares the specified object with this <c>Principal </c> for equality and returns <c>true </c> if the specified object is equal, <c>false </c> otherwise.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this <c>Principal </c> , otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object obj) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the hash code value for this <c>Principal </c> . Returns the same hash code for <c>Principal </c> s that are equal to each other as required by the general contract of Object#hashCode.</para> <para> <para>Object::equals(Object) </para> <para>Principal::equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code value for this <c>Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				int GetHashCode() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this <c>Principal </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the name of this <c>Principal </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this <c>Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para> <c>PrivateKey </c> is the common interface for private keys.</para> <para> <para>PublicKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/PrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/PrivateKey", AccessFlags = 1537)]
		public partial interface IPrivateKey : global::Java.Security.IKey
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para> <c>PrivateKey </c> is the common interface for private keys.</para> <para> <para>PublicKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/PrivateKey
		/// </java-name>
		[Dot42.DexImport("java/security/PrivateKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IPrivateKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The <c>serialVersionUID </c> to be compatible with JDK1.1. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 6034044314589513430;
		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
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

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
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

		/// <summary>
		///  <para> <c>PublicKey </c> is the common interface for public keys.</para> <para> <para>PrivateKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/PublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/PublicKey", AccessFlags = 1537)]
		public partial interface IPublicKey : global::Java.Security.IKey
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para> <c>PublicKey </c> is the common interface for public keys.</para> <para> <para>PrivateKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/PublicKey
		/// </java-name>
		[Dot42.DexImport("java/security/PublicKey", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IPublicKeyConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The <c>serialVersionUID </c> to be compatible with JDK1.1. </para>        
				/// </summary>
				/// <java-name>
				/// serialVersionUID
				/// </java-name>
				[Dot42.DexImport("serialVersionUID", "J", AccessFlags = 25)]
				public const long SerialVersionUID = 7187392471159151072;
		}

		/// <summary>
		///  <para> <c>KeyException </c> is the common superclass of all key related exceptions. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>KeyException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>KeyException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>KeyFactory </c> is an engine class that can be used to translate between public and private key objects and convert keys between their external representation, that can be easily transported and their internal representation. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/KeyFactory
		/// </java-name>
		[Dot42.DexImport("java/security/KeyFactory", AccessFlags = 33)]
		public partial class KeyFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>KeyFactory </c> with the specified arguments.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/KeyFactorySpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyFactory(global::Java.Security.KeyFactorySpi keyFacSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new instance of <c>KeyFactory </c> that utilizes the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>KeyFactory </c> that utilizes the specified algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/KeyFactory;", AccessFlags = 9)]
				public static global::Java.Security.KeyFactory GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Generates a instance of <c>PublicKey </c> from the given key specification.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the public key </para>
				/// </returns>
				/// <java-name>
				/// generatePublic
				/// </java-name>
				[Dot42.DexImport("generatePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", AccessFlags = 17)]
				public global::Java.Security.IPublicKey GeneratePublic(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPublicKey);
				}

				/// <summary>
				///  <para>Generates a instance of <c>PrivateKey </c> from the given key specification.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the private key. </para>
				/// </returns>
				/// <java-name>
				/// generatePrivate
				/// </java-name>
				[Dot42.DexImport("generatePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", AccessFlags = 17)]
				public global::Java.Security.IPrivateKey GeneratePrivate(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrivateKey);
				}

				/// <summary>
				///  <para>Returns the key specification for the specified key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the key specification for the specified key. </para>
				/// </returns>
				/// <java-name>
				/// getKeySpec
				/// </java-name>
				[Dot42.DexImport("getKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", AccessFlags = 17, Signature = "<T::Ljava/security/spec/KeySpec;>(Ljava/security/Key;Ljava/lang/Class<TT;>;)TT;")]
				public T GetKeySpec<T>(global::Java.Security.IKey key, global::System.Type keySpec) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <summary>
				///  <para>Translates the given key into a key from this key factory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the translated key. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the provider associated with this <c>KeyFactory </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider associated with this <c>KeyFactory </c> . </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <summary>
				///  <para>Returns the name of the algorithm associated with this <c>KeyFactory </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm associated with this <c>KeyFactory </c> . </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para> <c>KeyFactorySpi </c> is the Service Provider Interface (SPI) definition for KeyFactory.</para> <para> <para>KeyFactory </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Generates a instance of <c>PublicKey </c> from the given key specification.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the public key. </para>
				/// </returns>
				/// <java-name>
				/// engineGeneratePublic
				/// </java-name>
				[Dot42.DexImport("engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.IPublicKey EngineGeneratePublic(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates a instance of <c>PrivateKey </c> from the given key specification.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the private key. </para>
				/// </returns>
				/// <java-name>
				/// engineGeneratePrivate
				/// </java-name>
				[Dot42.DexImport("engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.IPrivateKey EngineGeneratePrivate(global::Java.Security.Spec.IKeySpec keySpec) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the key specification for the specified key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the key specification for the specified key. </para>
				/// </returns>
				/// <java-name>
				/// engineGetKeySpec
				/// </java-name>
				[Dot42.DexImport("engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", AccessFlags = 1028, Signature = "<T::Ljava/security/spec/KeySpec;>(Ljava/security/Key;Ljava/lang/Class<TT;>;)TT;")]
				protected internal abstract T EngineGetKeySpec<T>(global::Java.Security.IKey key, global::System.Type keySpec) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Translates the given key into a key from this key factory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the translated key. </para>
				/// </returns>
				/// <java-name>
				/// engineTranslateKey
				/// </java-name>
				[Dot42.DexImport("engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;", AccessFlags = 1028)]
				protected internal abstract global::Java.Security.IKey EngineTranslateKey(global::Java.Security.IKey key) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <c>KeyManagementException </c> is a general exception, thrown to indicate an exception during processing an operation concerning key management. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>KeyManagementException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyManagementException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>KeyManagementException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyManagementException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyManagementException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>KeyPair </c> is a container for a public key and a private key. Since the private key can be accessed, instances must be treated like a private key.</para> <para> <para>PrivateKey </para> <para>PublicKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/KeyPair
		/// </java-name>
		[Dot42.DexImport("java/security/KeyPair", AccessFlags = 49)]
		public sealed partial class KeyPair : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>KeyPair </c> with a public key and the corresponding private key.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/PublicKey;Ljava/security/PrivateKey;)V", AccessFlags = 1)]
				public KeyPair(global::Java.Security.IPublicKey publicKey, global::Java.Security.IPrivateKey privateKey) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyPair() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the private key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the private key. </para>
				/// </returns>
				/// <java-name>
				/// getPrivate
				/// </java-name>
				public global::Java.Security.IPrivateKey Private
				{
						[Dot42.DexImport("getPrivate", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPrivateKey); }
				}

				/// <summary>
				///  <para>Returns the public key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the public key. </para>
				/// </returns>
				/// <java-name>
				/// getPublic
				/// </java-name>
				public global::Java.Security.IPublicKey Public
				{
						[Dot42.DexImport("getPublic", "()Ljava/security/PublicKey;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPublicKey); }
				}

		}

		/// <summary>
		///  <para> <c>KeyPairGenerator </c> is an engine class which is capable of generating a private key and its related public key utilizing the algorithm it was initialized with.</para> <para> <para>KeyPairGeneratorSpi </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/KeyPairGenerator
		/// </java-name>
		[Dot42.DexImport("java/security/KeyPairGenerator", AccessFlags = 1057)]
		public abstract partial class KeyPairGenerator : global::Java.Security.KeyPairGeneratorSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>KeyPairGenerator </c> with the name of the algorithm to use.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyPairGenerator(string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new instance of <c>KeyPairGenerator </c> that utilizes the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>KeyPairGenerator </c> that utilizes the specified algorithm </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/KeyPairGenerator;", AccessFlags = 9)]
				public static global::Java.Security.KeyPairGenerator GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Initializes this <c>KeyPairGenerator </c> with the given key size. The default parameter set and a default <c>SecureRandom </c> instance will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(I)V", AccessFlags = 1)]
				public virtual void Initialize(int keysize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>KeyPairGenerator </c> with the given key size. The default parameter set and a default <c>SecureRandom </c> instance will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 1)]
				public virtual void Initialize(global::Java.Security.Spec.IAlgorithmParameterSpec keysize) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes and returns a new unique <c>KeyPair </c> each time this method is called. </para> <para>This does exactly the same as generateKeyPair().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new unique <c>KeyPair </c> each time this method is called </para>
				/// </returns>
				/// <java-name>
				/// genKeyPair
				/// </java-name>
				[Dot42.DexImport("genKeyPair", "()Ljava/security/KeyPair;", AccessFlags = 17)]
				public global::Java.Security.KeyPair GenKeyPair() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyPair);
				}

				/// <summary>
				///  <para>Computes and returns a new unique <c>KeyPair </c> each time this method is called. </para> <para>This does exactly the same as genKeyPair().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new unique <c>KeyPair </c> each time this method is called </para>
				/// </returns>
				/// <java-name>
				/// generateKeyPair
				/// </java-name>
				[Dot42.DexImport("generateKeyPair", "()Ljava/security/KeyPair;", AccessFlags = 1)]
				public override global::Java.Security.KeyPair GenerateKeyPair() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyPair);
				}

				/// <summary>
				///  <para>Initializes this <c>KeyPairGenerator </c> with the given key size and the given <c>SecureRandom </c> . The default parameter set will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(ILjava/security/SecureRandom;)V", AccessFlags = 1)]
				public override void Initialize(int keysize, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>KeyPairGenerator </c> with the given key size and the given <c>SecureRandom </c> . The default parameter set will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 1)]
				public override void Initialize(global::Java.Security.Spec.IAlgorithmParameterSpec keysize, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyPairGenerator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the name of the algorithm of this <c>KeyPairGenerator </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm of this <c>KeyPairGenerator </c> </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public virtual string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the provider associated with this <c>KeyPairGenerator </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider associated with this <c>KeyPairGenerator </c> </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

		}

		/// <summary>
		///  <para> <c>KeyPairGeneratorSpi </c> is the Service Provider Interface (SPI) definition for KeyPairGenerator.</para> <para> <para>KeyPairGenerator </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/KeyPairGeneratorSpi
		/// </java-name>
		[Dot42.DexImport("java/security/KeyPairGeneratorSpi", AccessFlags = 1057)]
		public abstract partial class KeyPairGeneratorSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>KeyPairGeneratorSpi </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyPairGeneratorSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes and returns a new unique <c>KeyPair </c> each time this method is called.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new unique <c>KeyPair </c> each time this method is called. </para>
				/// </returns>
				/// <java-name>
				/// generateKeyPair
				/// </java-name>
				[Dot42.DexImport("generateKeyPair", "()Ljava/security/KeyPair;", AccessFlags = 1025)]
				public abstract global::Java.Security.KeyPair GenerateKeyPair() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>KeyPairGeneratorSpi </c> with the given key size and the given <c>SecureRandom </c> . The default parameter set will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(ILjava/security/SecureRandom;)V", AccessFlags = 1025)]
				public abstract void Initialize(int keysize, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>KeyPairGeneratorSpi </c> with the given key size and the given <c>SecureRandom </c> . The default parameter set will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", AccessFlags = 1)]
				public virtual void Initialize(global::Java.Security.Spec.IAlgorithmParameterSpec keysize, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>KeyRep </c> is a standardized representation for serialized Key objects. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/KeyRep
		/// </java-name>
		[Dot42.DexImport("java/security/KeyRep", AccessFlags = 33)]
		public partial class KeyRep : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>KeyRep </c> with the specified arguments. The arguments should be obtained from the <c>Key </c> object that has to be serialized.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/KeyRep$Type;Ljava/lang/String;Ljava/lang/String;[B)V", AccessFlags = 1)]
				public KeyRep(global::Java.Security.KeyRep.Type type, string algorithm, string format, sbyte[] encoded) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>KeyRep </c> with the specified arguments. The arguments should be obtained from the <c>Key </c> object that has to be serialized.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/KeyRep$Type;Ljava/lang/String;Ljava/lang/String;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public KeyRep(global::Java.Security.KeyRep.Type type, string algorithm, string format, byte[] encoded) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resolves and returns the <c>Key </c> object. Three Type|format combinations are supported:  <ul> <li> <para> <c>Type.PRIVATE </c> | "PKCS#8" : returns a PrivateKey instance, generated from a key factory (suitable for the algorithm) that is initialized with a PKCS8EncodedKeySpec using the encoded key bytes. </para></li> <li> <para> <c>Type.SECRET </c> | "RAW" : returns a SecretKeySpec instance, created with the encoded key bytes and the algorithm. </para></li> <li> <para> <c>Type.PUBLIC </c> | "X.509": returns a PublicKey instance, generated from a key factory (suitable for the algorithm) that is initialized with a X509EncodedKeySpec using the encoded key bytes. </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the resolved <c>Key </c> object. </para>
				/// </returns>
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

		/// <summary>
		///  <para> <c>KeyStore </c> is responsible for maintaining cryptographic keys and their owners. </para> <para>The type of the system key store can be changed by setting the <c>'keystore.type' </c> property in the file named <c>JAVA_HOME/lib/security/java.security </c> .</para> <para> <para>Certificate </para> <para>PrivateKey </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/KeyStore
		/// </java-name>
		[Dot42.DexImport("java/security/KeyStore", AccessFlags = 33)]
		public partial class KeyStore
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>KeyStore </c> with the given arguments.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/KeyStoreSpi;Ljava/security/Provider;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal KeyStore(global::Java.Security.KeyStoreSpi keyStoreSpi, global::Java.Security.Provider provider, string type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new instance of <c>KeyStore </c> with the specified type.</para> <para> <para>getDefaultType </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>KeyStore </c> with the specified type. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/KeyStore;", AccessFlags = 9)]
				public static global::Java.Security.KeyStore GetInstance(string type) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the key with the given alias, using the password to recover the key from the store.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the key with the specified alias, or <c>null </c> if the specified alias is not bound to an entry. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "(Ljava/lang/String;[C)Ljava/security/Key;", AccessFlags = 17)]
				public global::Java.Security.IKey GetKey(string alias, char[] password) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IKey);
				}

				/// <summary>
				///  <para>Returns the certificate chain for the entry with the given alias.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate chain for the entry with the given alias, or  <c>null </c> if the specified alias is not bound to an entry. </para>
				/// </returns>
				/// <java-name>
				/// getCertificateChain
				/// </java-name>
				[Dot42.DexImport("getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;", AccessFlags = 17)]
				public global::Java.Security.Cert.Certificate[] GetCertificateChain(string alias) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate[]);
				}

				/// <summary>
				///  <para>Returns the trusted certificate for the entry with the given alias.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the trusted certificate for the entry with the given alias, or  <c>null </c> if the specified alias is not bound to an entry. </para>
				/// </returns>
				/// <java-name>
				/// getCertificate
				/// </java-name>
				[Dot42.DexImport("getCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;", AccessFlags = 17)]
				public global::Java.Security.Cert.Certificate GetCertificate(string alias) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate);
				}

				/// <summary>
				///  <para>Returns the creation date of the entry with the given alias.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the creation date, or <c>null </c> if the specified alias is not bound to an entry. </para>
				/// </returns>
				/// <java-name>
				/// getCreationDate
				/// </java-name>
				[Dot42.DexImport("getCreationDate", "(Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 17)]
				public global::Java.Util.Date GetCreationDate(string alias) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				///  <para>Associates the given alias with the key, password and certificate chain. </para> <para>If the specified alias already exists, it will be reassigned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setKeyEntry
				/// </java-name>
				[Dot42.DexImport("setKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void SetKeyEntry(string alias, global::Java.Security.IKey key, char[] password, global::Java.Security.Cert.Certificate[] chain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Associates the given alias with a key and a certificate chain. </para> <para>If the specified alias already exists, it will be reassigned. </para> <para>If this <c>KeyStore </c> is of type <c>"jks" </c> , <c>key </c> must be encoded conform to the PKS#8 standard as an javax.crypto.EncryptedPrivateKeyInfo.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setKeyEntry
				/// </java-name>
				[Dot42.DexImport("setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void SetKeyEntry(string alias, sbyte[] key, global::Java.Security.Cert.Certificate[] chain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Associates the given alias with a key and a certificate chain. </para> <para>If the specified alias already exists, it will be reassigned. </para> <para>If this <c>KeyStore </c> is of type <c>"jks" </c> , <c>key </c> must be encoded conform to the PKS#8 standard as an javax.crypto.EncryptedPrivateKeyInfo.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setKeyEntry
				/// </java-name>
				[Dot42.DexImport("setKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void SetKeyEntry(string alias, byte[] key, global::Java.Security.Cert.Certificate[] chain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Associates the given alias with a certificate. </para> <para>If the specified alias already exists, it will be reassigned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setCertificateEntry
				/// </java-name>
				[Dot42.DexImport("setCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void SetCertificateEntry(string alias, global::Java.Security.Cert.Certificate cert) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Deletes the entry identified with the given alias from this <c>KeyStore </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// deleteEntry
				/// </java-name>
				[Dot42.DexImport("deleteEntry", "(Ljava/lang/String;)V", AccessFlags = 17)]
				public void DeleteEntry(string alias) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns an <c>Enumeration </c> over all alias names stored in this  <c>KeyStore </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an <c>Enumeration </c> over all alias names stored in this  <c>KeyStore </c> . </para>
				/// </returns>
				/// <java-name>
				/// aliases
				/// </java-name>
				[Dot42.DexImport("aliases", "()Ljava/util/Enumeration;", AccessFlags = 17, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public global::Java.Util.IEnumeration<string> Aliases() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IEnumeration<string>);
				}

				/// <summary>
				///  <para>Indicates whether the given alias is present in this <c>KeyStore </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the alias exists, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// containsAlias
				/// </java-name>
				[Dot42.DexImport("containsAlias", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool ContainsAlias(string alias) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the number of entries stored in this <c>KeyStore </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of entries stored in this <c>KeyStore </c> . </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 17)]
				public int Size() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether the specified alias is associated with either a PrivateKeyEntry or a SecretKeyEntry.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the given alias is associated with a key entry. </para>
				/// </returns>
				/// <java-name>
				/// isKeyEntry
				/// </java-name>
				[Dot42.DexImport("isKeyEntry", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool IsKeyEntry(string alias) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether the specified alias is associated with a TrustedCertificateEntry.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the given alias is associated with a certificate entry. </para>
				/// </returns>
				/// <java-name>
				/// isCertificateEntry
				/// </java-name>
				[Dot42.DexImport("isCertificateEntry", "(Ljava/lang/String;)Z", AccessFlags = 17)]
				public bool IsCertificateEntry(string alias) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the alias associated with the first entry whose certificate matches the specified certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the alias or <c>null </c> if no entry with the specified certificate can be found. </para>
				/// </returns>
				/// <java-name>
				/// getCertificateAlias
				/// </java-name>
				[Dot42.DexImport("getCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", AccessFlags = 17)]
				public string GetCertificateAlias(global::Java.Security.Cert.Certificate cert) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Writes this <c>KeyStore </c> to the specified <c>OutputStream </c> . The data written to the <c>OutputStream </c> is protected by the specified password.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// store
				/// </java-name>
				[Dot42.DexImport("store", "(Ljava/io/OutputStream;[C)V", AccessFlags = 17)]
				public void Store(global::Java.IO.OutputStream stream, char[] password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stores this <c>KeyStore </c> using the specified <c>LoadStoreParameter </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// store
				/// </java-name>
				[Dot42.DexImport("store", "(Ljava/security/KeyStore$LoadStoreParameter;)V", AccessFlags = 17)]
				public void Store(global::Java.Security.KeyStore.ILoadStoreParameter param) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>KeyStore </c> from the provided <c>InputStream </c> . Pass <c>null </c> as the <c>stream </c> argument to initialize an empty  <c>KeyStore </c> or to initialize a <c>KeyStore </c> which does not rely on an <c>InputStream </c> . This <c>KeyStore </c> utilizes the given password to verify the stored data.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/io/InputStream;[C)V", AccessFlags = 17)]
				public void Load(global::Java.IO.InputStream stream, char[] password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Loads this <c>KeyStore </c> using the specified <c>LoadStoreParameter </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(Ljava/security/KeyStore$LoadStoreParameter;)V", AccessFlags = 17)]
				public void Load(global::Java.Security.KeyStore.ILoadStoreParameter param) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>Entry </c> with the given alias, using the specified  <c>ProtectionParameter </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>he <c>Entry </c> with the given alias, using the specified  <c>ProtectionParameter </c> . </para>
				/// </returns>
				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/Ke" +
    "yStore$Entry;", AccessFlags = 17)]
				public global::Java.Security.KeyStore.IEntry GetEntry(string alias, global::Java.Security.KeyStore.IProtectionParameter param) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyStore.IEntry);
				}

				/// <summary>
				///  <para>Stores the given <c>Entry </c> in this <c>KeyStore </c> and associates the entry with the given <c>alias </c> . The entry is protected by the specified <c>ProtectionParameter </c> . </para> <para>If the specified alias already exists, it will be reassigned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setEntry
				/// </java-name>
				[Dot42.DexImport("setEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$Protecti" +
    "onParameter;)V", AccessFlags = 17)]
				public void SetEntry(string alias, global::Java.Security.KeyStore.IEntry entry, global::Java.Security.KeyStore.IProtectionParameter param) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether the entry for the given alias is assignable to the provided <c>Class </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the <c>Entry </c> for the alias is assignable to the specified <c>entryClass </c> . </para>
				/// </returns>
				/// <java-name>
				/// entryInstanceOf
				/// </java-name>
				[Dot42.DexImport("entryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z", AccessFlags = 17, Signature = "(Ljava/lang/String;Ljava/lang/Class<+Ljava/security/KeyStore$Entry;>;)Z")]
				public bool EntryInstanceOf(string alias, global::System.Type entryClass) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyStore() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the default type for <c>KeyStore </c> instances.</para> <para>The default is specified in the <c>'keystore.type' </c> property in the file named <c>java.security </c> properties file. If this property is not set, <c>"jks" </c> will be used.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default type for <c>KeyStore </c> instances </para>
				/// </returns>
				/// <java-name>
				/// getDefaultType
				/// </java-name>
				public static string DefaultType
				{
						[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the provider associated with this <c>KeyStore </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider associated with this <c>KeyStore </c> . </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <summary>
				///  <para>Returns the type of this <c>KeyStore </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the type of this <c>KeyStore </c> . </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para> <c>TrustedCertificateEntry </c> represents a <c>KeyStore </c> entry that holds a trusted certificate. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Returns a string containing a concise, human-readable description of this <c>TrustedCertificateEntry </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a printable representation for this <c>TrustedCertificateEntry </c> . </para>
						/// </returns>
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

						/// <summary>
						///  <para>Returns the trusted certificate.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the trusted certificate. </para>
						/// </returns>
						/// <java-name>
						/// getTrustedCertificate
						/// </java-name>
						public global::Java.Security.Cert.Certificate TrustedCertificate
						{
								[Dot42.DexImport("getTrustedCertificate", "()Ljava/security/cert/Certificate;", AccessFlags = 1)]
								get{ return default(global::Java.Security.Cert.Certificate); }
						}

				}

				/// <summary>
				///  <para> <c>SecretKeyEntry </c> represents a <c>KeyStore </c> entry that holds a secret key. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Returns a string containing a concise, human-readable description of this <c>SecretKeyEntry </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a printable representation for this <c>SecretKeyEntry </c> . </para>
						/// </returns>
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

						/// <summary>
						///  <para>Returns the secret key.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the secret key. </para>
						/// </returns>
						/// <java-name>
						/// getSecretKey
						/// </java-name>
						public global::Javax.Crypto.ISecretKey SecretKey
						{
								[Dot42.DexImport("getSecretKey", "()Ljavax/crypto/SecretKey;", AccessFlags = 1)]
								get{ return default(global::Javax.Crypto.ISecretKey); }
						}

				}

				/// <summary>
				///  <para> <c>PrivateKeyEntry </c> represents a <c>KeyStore </c> entry that holds a private key. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Returns a string containing a concise, human-readable description of this <c>PrivateKeyEntry </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a printable representation for this <c>PrivateKeyEntry </c> . </para>
						/// </returns>
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

						/// <summary>
						///  <para>Returns the private key.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the private key. </para>
						/// </returns>
						/// <java-name>
						/// getPrivateKey
						/// </java-name>
						public global::Java.Security.IPrivateKey PrivateKey
						{
								[Dot42.DexImport("getPrivateKey", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
								get{ return default(global::Java.Security.IPrivateKey); }
						}

						/// <summary>
						///  <para>Returns the certificate chain.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the certificate chain. </para>
						/// </returns>
						/// <java-name>
						/// getCertificateChain
						/// </java-name>
						public global::Java.Security.Cert.Certificate[] CertificateChain
						{
								[Dot42.DexImport("getCertificateChain", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
								get{ return default(global::Java.Security.Cert.Certificate[]); }
						}

						/// <summary>
						///  <para>Returns the certificate corresponding to the private key.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the certificate corresponding to the private key. </para>
						/// </returns>
						/// <java-name>
						/// getCertificate
						/// </java-name>
						public global::Java.Security.Cert.Certificate Certificate
						{
								[Dot42.DexImport("getCertificate", "()Ljava/security/cert/Certificate;", AccessFlags = 1)]
								get{ return default(global::Java.Security.Cert.Certificate); }
						}

				}

				/// <summary>
				///  <para> <c>ProtectionParameter </c> is a marker interface for protection parameters. A protection parameter is used to protect the content of a  <c>KeyStore </c> . </para>    
				/// </summary>
				/// <java-name>
				/// java/security/KeyStore$ProtectionParameter
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$ProtectionParameter", AccessFlags = 1545)]
				public partial interface IProtectionParameter
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para> <c>PasswordProtection </c> is a <c>ProtectionParameter </c> that protects a <c>KeyStore </c> using a password. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Destroys / invalidates the password.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// destroy
						/// </java-name>
						[Dot42.DexImport("destroy", "()V", AccessFlags = 33)]
						public virtual void Destroy() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal PasswordProtection() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Returns the password.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the password. </para>
						/// </returns>
						/// <java-name>
						/// getPassword
						/// </java-name>
						public virtual char[] Password
						{
								[Dot42.DexImport("getPassword", "()[C", AccessFlags = 33)]
								get{ return default(char[]); }
						}

						/// <summary>
						///  <para>Indicates whether the password is invalidated.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para> <c>true </c> if the password is invalidated, <c>false </c> otherwise. </para>
						/// </returns>
						/// <java-name>
						/// isDestroyed
						/// </java-name>
						public virtual bool IsDestroyed
						{
								[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 33)]
								get{ return default(bool); }
						}

				}

				/// <summary>
				///  <para> <c>LoadStoreParameter </c> represents a parameter that specifies how a  <c>KeyStore </c> can be loaded and stored.</para> <para> <para>KeyStore::load(LoadStoreParameter) </para> <para>KeyStore::store(LoadStoreParameter) </para></para>    
				/// </summary>
				/// <java-name>
				/// java/security/KeyStore$LoadStoreParameter
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$LoadStoreParameter", AccessFlags = 1545)]
				public partial interface ILoadStoreParameter
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Returns the <c>ProtectionParameter </c> which is used to protect data in the <c>KeyStore </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the <c>ProtectionParameter </c> which is used to protect data in the <c>KeyStore </c> , maybe <c>null </c> . </para>
						/// </returns>
						/// <java-name>
						/// getProtectionParameter
						/// </java-name>
						global::Java.Security.KeyStore.IProtectionParameter ProtectionParameter
						{
								[Dot42.DexImport("getProtectionParameter", "()Ljava/security/KeyStore$ProtectionParameter;", AccessFlags = 1025)]
								get;
						}

				}

				/// <summary>
				///  <para> <c>Entry </c> is the common marker interface for a <c>KeyStore </c> entry. </para>    
				/// </summary>
				/// <java-name>
				/// java/security/KeyStore$Entry
				/// </java-name>
				[Dot42.DexImport("java/security/KeyStore$Entry", AccessFlags = 1545)]
				public partial interface IEntry
 /* scope: __dot42__ */ 
				{
				}

				/// <summary>
				///  <para> <c>CallbackHandlerProtection </c> is a <c>ProtectionParameter </c> that encapsulates a CallbackHandler. </para>    
				/// </summary>
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

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal CallbackHandlerProtection() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Returns the <c>CallbackHandler </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the <c>CallbackHandler </c> . </para>
						/// </returns>
						/// <java-name>
						/// getCallbackHandler
						/// </java-name>
						public virtual global::Javax.Security.Auth.Callback.ICallbackHandler CallbackHandler
						{
								[Dot42.DexImport("getCallbackHandler", "()Ljavax/security/auth/callback/CallbackHandler;", AccessFlags = 1)]
								get{ return default(global::Javax.Security.Auth.Callback.ICallbackHandler); }
						}

				}

				/// <summary>
				///  <para> <c>Builder </c> is used to construct new instances of <c>KeyStore </c> . </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Returns the <c>ProtectionParameter </c> to be used when a <c>Entry </c> with the specified alias is requested. Before this method is invoked, getKeyStore() must be called.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the <c>ProtectionParameter </c> to be used when a <c>Entry </c> with the specified alias is requested. </para>
						/// </returns>
						/// <java-name>
						/// getProtectionParameter
						/// </java-name>
						[Dot42.DexImport("getProtectionParameter", "(Ljava/lang/String;)Ljava/security/KeyStore$ProtectionParameter;", AccessFlags = 1025)]
						public abstract global::Java.Security.KeyStore.IProtectionParameter GetProtectionParameter(string alias) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Returns a new <c>Builder </c> that holds the given <c>KeyStore </c> and the given <c>ProtectionParameter </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a new instance of <c>Builder </c> that holds the specified  <c>KeyStore </c> and the specified <c>ProtectionParameter </c> . </para>
						/// </returns>
						/// <java-name>
						/// newInstance
						/// </java-name>
						[Dot42.DexImport("newInstance", "(Ljava/security/KeyStore;Ljava/security/KeyStore$ProtectionParameter;)Ljava/secur" +
    "ity/KeyStore$Builder;", AccessFlags = 9)]
						public static Builder NewInstance(global::Java.Security.KeyStore keyStore, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Returns a new <c>Builder </c> that creates a new <c>KeyStore </c> based on the provided arguments. </para> <para>If <c>provider </c> is <c>null </c> , all installed providers are searched, otherwise the key store from the specified provider is used.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a new <c>Builder </c> that creates a new <c>KeyStore </c> based on the provided arguments. </para>
						/// </returns>
						/// <java-name>
						/// newInstance
						/// </java-name>
						[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/io/File;Ljava/security/KeyStore$" +
    "ProtectionParameter;)Ljava/security/KeyStore$Builder;", AccessFlags = 9)]
						public static Builder NewInstance(string type, global::Java.Security.Provider provider, global::Java.IO.File file, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Returns a new <c>Builder </c> that creates a new <c>KeyStore </c> based on the provided arguments. </para> <para>If <c>provider </c> is <c>null </c> , all installed providers are searched, otherwise the key store from the specified provider is used.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a new <c>Builder </c> that creates a new <c>KeyStore </c> based on the provided arguments. </para>
						/// </returns>
						/// <java-name>
						/// newInstance
						/// </java-name>
						[Dot42.DexImport("newInstance", "(Ljava/lang/String;Ljava/security/Provider;Ljava/security/KeyStore$ProtectionPara" +
    "meter;)Ljava/security/KeyStore$Builder;", AccessFlags = 9)]
						public static Builder NewInstance(string type, global::Java.Security.Provider provider, global::Java.Security.KeyStore.IProtectionParameter protectionParameter) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Returns the <c>KeyStore </c> created by this <c>Builder </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the <c>KeyStore </c> created by this <c>Builder </c> . </para>
						/// </returns>
						/// <java-name>
						/// getKeyStore
						/// </java-name>
						public abstract global::Java.Security.KeyStore KeyStore
						{
								[Dot42.DexImport("getKeyStore", "()Ljava/security/KeyStore;", AccessFlags = 1025)]
								get;
						}

				}

		}

		/// <summary>
		///  <para> <c>KeyStoreException </c> is a general <c>KeyStore </c> exception.</para> <para> <para>KeyStore </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>KeyStoreException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public KeyStoreException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>KeyStoreException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyStoreException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public KeyStoreException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>KeyStoreSpi </c> is the Service Provider Interface (SPI) definition for KeyStore.</para> <para> <para>KeyStore </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Returns the key with the given alias, using the password to recover the key from the store.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the key with the specified alias, or <c>null </c> if the specified alias is not bound to an entry. </para>
				/// </returns>
				/// <java-name>
				/// engineGetKey
				/// </java-name>
				[Dot42.DexImport("engineGetKey", "(Ljava/lang/String;[C)Ljava/security/Key;", AccessFlags = 1025)]
				public abstract global::Java.Security.IKey EngineGetKey(string alias, char[] password) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the certificate chain for the entry with the given alias.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate chain for the entry with the given alias, or  <c>null </c> if the specified alias is not bound to an entry. </para>
				/// </returns>
				/// <java-name>
				/// engineGetCertificateChain
				/// </java-name>
				[Dot42.DexImport("engineGetCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate[] EngineGetCertificateChain(string alias) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the trusted certificate for the entry with the given alias.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the trusted certificate for the entry with the given alias, or  <c>null </c> if the specified alias is not bound to an entry. </para>
				/// </returns>
				/// <java-name>
				/// engineGetCertificate
				/// </java-name>
				[Dot42.DexImport("engineGetCertificate", "(Ljava/lang/String;)Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate EngineGetCertificate(string alias) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the creation date of the entry with the given alias.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the creation date, or <c>null </c> if the specified alias is not bound to an entry. </para>
				/// </returns>
				/// <java-name>
				/// engineGetCreationDate
				/// </java-name>
				[Dot42.DexImport("engineGetCreationDate", "(Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 1025)]
				public abstract global::Java.Util.Date EngineGetCreationDate(string alias) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Associates the given alias with the key, password and certificate chain. </para> <para>If the specified alias already exists, it will be reassigned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetKeyEntry
				/// </java-name>
				[Dot42.DexImport("engineSetKeyEntry", "(Ljava/lang/String;Ljava/security/Key;[C[Ljava/security/cert/Certificate;)V", AccessFlags = 1025)]
				public abstract void EngineSetKeyEntry(string alias, global::Java.Security.IKey key, char[] password, global::Java.Security.Cert.Certificate[] chain) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Associates the given alias with a key and a certificate chain. </para> <para>If the specified alias already exists, it will be reassigned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetKeyEntry
				/// </java-name>
				[Dot42.DexImport("engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", AccessFlags = 1025)]
				public abstract void EngineSetKeyEntry(string alias, sbyte[] key, global::Java.Security.Cert.Certificate[] chain) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Associates the given alias with a key and a certificate chain. </para> <para>If the specified alias already exists, it will be reassigned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetKeyEntry
				/// </java-name>
				[Dot42.DexImport("engineSetKeyEntry", "(Ljava/lang/String;[B[Ljava/security/cert/Certificate;)V", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract void EngineSetKeyEntry(string alias, byte[] key, global::Java.Security.Cert.Certificate[] chain) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Associates the given alias with a certificate. </para> <para>If the specified alias already exists, it will be reassigned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetCertificateEntry
				/// </java-name>
				[Dot42.DexImport("engineSetCertificateEntry", "(Ljava/lang/String;Ljava/security/cert/Certificate;)V", AccessFlags = 1025)]
				public abstract void EngineSetCertificateEntry(string alias, global::Java.Security.Cert.Certificate cert) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Deletes the entry identified with the given alias from this <c>KeyStoreSpi </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineDeleteEntry
				/// </java-name>
				[Dot42.DexImport("engineDeleteEntry", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void EngineDeleteEntry(string alias) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an <c>Enumeration </c> over all alias names stored in this  <c>KeyStoreSpi </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an <c>Enumeration </c> over all alias names stored in this  <c>KeyStoreSpi </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineAliases
				/// </java-name>
				[Dot42.DexImport("engineAliases", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/lang/String;>;")]
				public abstract global::Java.Util.IEnumeration<string> EngineAliases() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates whether the given alias is present in this <c>KeyStoreSpi </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the alias exists, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// engineContainsAlias
				/// </java-name>
				[Dot42.DexImport("engineContainsAlias", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool EngineContainsAlias(string alias) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the number of entries stored in this <c>KeyStoreSpi </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of entries stored in this <c>KeyStoreSpi </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineSize
				/// </java-name>
				[Dot42.DexImport("engineSize", "()I", AccessFlags = 1025)]
				public abstract int EngineSize() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates whether the specified alias is associated with either a KeyStore.PrivateKeyEntry or a KeyStore.SecretKeyEntry.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the given alias is associated with a key entry. </para>
				/// </returns>
				/// <java-name>
				/// engineIsKeyEntry
				/// </java-name>
				[Dot42.DexImport("engineIsKeyEntry", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool EngineIsKeyEntry(string alias) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates whether the specified alias is associated with a KeyStore.TrustedCertificateEntry.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the given alias is associated with a certificate entry. </para>
				/// </returns>
				/// <java-name>
				/// engineIsCertificateEntry
				/// </java-name>
				[Dot42.DexImport("engineIsCertificateEntry", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public abstract bool EngineIsCertificateEntry(string alias) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the alias associated with the first entry whose certificate matches the specified certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the alias or <c>null </c> if no entry with the specified certificate can be found. </para>
				/// </returns>
				/// <java-name>
				/// engineGetCertificateAlias
				/// </java-name>
				[Dot42.DexImport("engineGetCertificateAlias", "(Ljava/security/cert/Certificate;)Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string EngineGetCertificateAlias(global::Java.Security.Cert.Certificate cert) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Writes this <c>KeyStoreSpi </c> to the specified <c>OutputStream </c> . The data written to the <c>OutputStream </c> is protected by the specified password.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineStore
				/// </java-name>
				[Dot42.DexImport("engineStore", "(Ljava/io/OutputStream;[C)V", AccessFlags = 1025)]
				public abstract void EngineStore(global::Java.IO.OutputStream stream, char[] password) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Stores this <c>KeyStoreSpi </c> using the specified <c>LoadStoreParameter </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineStore
				/// </java-name>
				[Dot42.DexImport("engineStore", "(Ljava/security/KeyStore$LoadStoreParameter;)V", AccessFlags = 1)]
				public virtual void EngineStore(global::Java.Security.KeyStore.ILoadStoreParameter param) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Loads this <c>KeyStoreSpi </c> from the given <c>InputStream </c> . Utilizes the given password to verify the stored data.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineLoad
				/// </java-name>
				[Dot42.DexImport("engineLoad", "(Ljava/io/InputStream;[C)V", AccessFlags = 1025)]
				public abstract void EngineLoad(global::Java.IO.InputStream stream, char[] password) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Loads this <c>KeyStoreSpi </c> using the specified <c>LoadStoreParameter </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineLoad
				/// </java-name>
				[Dot42.DexImport("engineLoad", "(Ljava/security/KeyStore$LoadStoreParameter;)V", AccessFlags = 1)]
				public virtual void EngineLoad(global::Java.Security.KeyStore.ILoadStoreParameter param) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>Entry </c> with the given alias, using the specified  <c>ProtectionParameter </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>he <c>Entry </c> with the given alias, using the specified  <c>ProtectionParameter </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineGetEntry
				/// </java-name>
				[Dot42.DexImport("engineGetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$ProtectionParameter;)Ljava/security/Ke" +
    "yStore$Entry;", AccessFlags = 1)]
				public virtual global::Java.Security.KeyStore.IEntry EngineGetEntry(string alias, global::Java.Security.KeyStore.IProtectionParameter protParam) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.KeyStore.IEntry);
				}

				/// <summary>
				///  <para>Stores the given <c>Entry </c> in this <c>KeyStoreSpi </c> and associates the entry with the given <c>alias </c> . The entry is protected by the specified <c>ProtectionParameter </c> . </para> <para>If the specified alias already exists, it will be reassigned.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetEntry
				/// </java-name>
				[Dot42.DexImport("engineSetEntry", "(Ljava/lang/String;Ljava/security/KeyStore$Entry;Ljava/security/KeyStore$Protecti" +
    "onParameter;)V", AccessFlags = 1)]
				public virtual void EngineSetEntry(string alias, global::Java.Security.KeyStore.IEntry entry, global::Java.Security.KeyStore.IProtectionParameter protParam) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicates whether the entry for the given alias is assignable to the provided <c>Class </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the <c>Entry </c> for the alias is assignable to the specified <c>entryClass </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineEntryInstanceOf
				/// </java-name>
				[Dot42.DexImport("engineEntryInstanceOf", "(Ljava/lang/String;Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/lang/Class<+Ljava/security/KeyStore$Entry;>;)Z")]
				public virtual bool EngineEntryInstanceOf(string alias, global::System.Type entryClass) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		///  <para>Uses a one-way hash function to turn an arbitrary number of bytes into a fixed-length byte sequence. The original arbitrary-length sequence is the  <b>message</b>, and the fixed-length byte sequence is the  <b>digest</b> or  <b>message digest</b>.</para> <para> <h4>Sample Code</h4></para> <para>The basic pattern to digest an java.io.InputStream looks like this:  <pre>
		///  MessageDigest digester = MessageDigest.getInstance("MD5");
		///  byte[] bytes = new byte[8192];
		///  int byteCount;
		///  while ((byteCount = in.read(bytes)) &gt; 0) {
		///    digester.update(bytes, 0, byteCount);
		///  }
		///  byte[] digest = digester.digest();
		/// </pre></para> <para>That is, after creating or resetting a <c>MessageDigest </c> you should call update(byte[],int,int) for each block of input data, and then call digest to get the final digest. Note that calling <c>digest </c> resets the <c>MessageDigest </c> . Advanced users who want partial digests should clone their <c>MessageDigest </c> before calling <c>digest </c> .</para> <para>This class is not thread-safe.</para> <para> <para>MessageDigestSpi </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/MessageDigest
		/// </java-name>
		[Dot42.DexImport("java/security/MessageDigest", AccessFlags = 1057)]
		public abstract partial class MessageDigest : global::Java.Security.MessageDigestSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>MessageDigest </c> with the name of the algorithm to use.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal MessageDigest(string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new instance of <c>MessageDigest </c> that utilizes the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>MessageDigest </c> that utilizes the specified algorithm </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/MessageDigest;", AccessFlags = 9)]
				public static global::Java.Security.MessageDigest GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Puts this <c>MessageDigest </c> back in an initial state, such that it is ready to compute a one way hash value. </para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this <c>MessageDigest </c> using the given <c>input </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 1)]
				public virtual void Update(sbyte input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this <c>MessageDigest </c> using the given <c>input </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this <c>MessageDigest </c> using the given <c>byte[] </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1)]
				public virtual void Update(sbyte[] input, int offset, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this <c>MessageDigest </c> using the given <c>byte[] </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte[] input, int offset, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this <c>MessageDigest </c> using the given <c>input </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1)]
				public virtual void Update(sbyte[] input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates this <c>MessageDigest </c> using the given <c>input </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void Update(byte[] input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes and returns the final hash value for this MessageDigest. After the digest is computed the receiver is reset.</para> <para> <para>reset </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the computed one way hash value </para>
				/// </returns>
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaDigest() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Computes and returns the final hash value for this MessageDigest. After the digest is computed the receiver is reset.</para> <para> <para>reset </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the computed one way hash value </para>
				/// </returns>
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] Digest() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Computes and stores the final hash value for this MessageDigest. After the digest is computed the receiver is reset.</para> <para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes written to <c>buf </c> </para>
				/// </returns>
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "([BII)I", AccessFlags = 1)]
				public virtual int Digest(sbyte[] buf, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Computes and stores the final hash value for this MessageDigest. After the digest is computed the receiver is reset.</para> <para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes written to <c>buf </c> </para>
				/// </returns>
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "([BII)I", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual int Digest(byte[] buf, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Performs the final update and then computes and returns the final hash value for this MessageDigest. After the digest is computed the receiver is reset.</para> <para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the computed one way hash value </para>
				/// </returns>
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "([B)[B", AccessFlags = 1)]
				public virtual sbyte[] Digest(sbyte[] input) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Performs the final update and then computes and returns the final hash value for this MessageDigest. After the digest is computed the receiver is reset.</para> <para> <para>reset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the computed one way hash value </para>
				/// </returns>
				/// <java-name>
				/// digest
				/// </java-name>
				[Dot42.DexImport("digest", "([B)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] Digest(byte[] input) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this  <c>MessageDigest </c> including the name of its algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>MessageDigest </c> </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Indicates whether to digest are equal by performing a simply byte-per-byte compare of the two digests.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the two hashes are equal, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isEqual
				/// </java-name>
				[Dot42.DexImport("isEqual", "([B[B)Z", AccessFlags = 9)]
				public static bool IsEqual(sbyte[] digesta, sbyte[] digestb) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether to digest are equal by performing a simply byte-per-byte compare of the two digests.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the two hashes are equal, <c>false </c> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isEqual
				/// </java-name>
				[Dot42.DexImport("isEqual", "([B[B)Z", AccessFlags = 9, IgnoreFromJava = true)]
				public static bool IsEqual(byte[] digesta, byte[] digestb) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Updates this <c>MessageDigest </c> using the given <c>input </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 17)]
				public void Update(global::Java.Nio.ByteBuffer input) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MessageDigest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the name of the algorithm of this <c>MessageDigest </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm of this <c>MessageDigest </c> </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the provider associated with this <c>MessageDigest </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider associated with this <c>MessageDigest </c> </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <summary>
				///  <para>Returns the engine digest length in bytes. If the implementation does not implement this function or is not an instance of <c>Cloneable </c> ,  <c>0 </c> is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the digest length in bytes, or <c>0 </c> </para>
				/// </returns>
				/// <java-name>
				/// getDigestLength
				/// </java-name>
				public int DigestLength
				{
						[Dot42.DexImport("getDigestLength", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para> <c>MessageDigestSpi </c> is the Service Provider Interface (SPI) definition for MessageDigest. Examples of digest algorithms are MD5 and SHA. A digest is a secure one way hash function for a stream of bytes. It acts like a fingerprint for a stream of bytes.</para> <para> <para>MessageDigest </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Returns the engine digest length in bytes. If the implementation does not implement this function <c>0 </c> is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the digest length in bytes, or <c>0 </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineGetDigestLength
				/// </java-name>
				[Dot42.DexImport("engineGetDigestLength", "()I", AccessFlags = 4)]
				protected internal virtual int EngineGetDigestLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Updates this <c>MessageDigestSpi </c> using the given <c>input </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte input) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates this <c>MessageDigestSpi </c> using the given <c>input </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte input) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates this <c>MessageDigestSpi </c> using the given <c>byte[] </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte[] input, int offset, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates this <c>MessageDigestSpi </c> using the given <c>byte[] </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte[] input, int offset, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates this <c>MessageDigestSpi </c> using the given <c>input </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 4)]
				protected internal virtual void EngineUpdate(global::Java.Nio.ByteBuffer input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes and returns the final hash value for this MessageDigestSpi. After the digest is computed the receiver is reset.</para> <para> <para>engineReset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the computed one way hash value. </para>
				/// </returns>
				/// <java-name>
				/// engineDigest
				/// </java-name>
				[Dot42.DexImport("engineDigest", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineDigest() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Computes and returns the final hash value for this MessageDigestSpi. After the digest is computed the receiver is reset.</para> <para> <para>engineReset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the computed one way hash value. </para>
				/// </returns>
				/// <java-name>
				/// engineDigest
				/// </java-name>
				[Dot42.DexImport("engineDigest", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineDigest() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Computes and stores the final hash value for this MessageDigestSpi. After the digest is computed the receiver is reset.</para> <para> <para>engineReset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes written to <c>buf </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineDigest
				/// </java-name>
				[Dot42.DexImport("engineDigest", "([BII)I", AccessFlags = 4)]
				protected internal virtual int EngineDigest(sbyte[] buf, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Computes and stores the final hash value for this MessageDigestSpi. After the digest is computed the receiver is reset.</para> <para> <para>engineReset() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes written to <c>buf </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineDigest
				/// </java-name>
				[Dot42.DexImport("engineDigest", "([BII)I", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual int EngineDigest(byte[] buf, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Puts this <c>MessageDigestSpi </c> back in an initial state, such that it is ready to compute a one way hash value. </para>        
				/// </summary>
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

		/// <summary>
		///  <para> <c>NoSuchAlgorithmException </c> indicates that a requested algorithm could not be found. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>NoSuchAlgorithmException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchAlgorithmException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>NoSuchAlgorithmException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NoSuchAlgorithmException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NoSuchAlgorithmException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>NoSuchProviderException </c> indicates that a requested security provider could not be found. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/NoSuchProviderException
		/// </java-name>
		[Dot42.DexImport("java/security/NoSuchProviderException", AccessFlags = 33)]
		public partial class NoSuchProviderException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>NoSuchProviderException </c> with the given message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NoSuchProviderException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>NoSuchProviderException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NoSuchProviderException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/Permission
		/// </java-name>
		[Dot42.DexImport("java/security/Permission", AccessFlags = 1057)]
		public abstract partial class Permission : global::Java.Security.IGuard, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Permission(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Checks whether access to the specified <c>Object </c> should be granted. This method returns silently if access is granted, otherwise a <c>SecurityException </c> is thrown.</para> <para></para>        
				/// </summary>
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
						get{ return default(string); }
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public abstract string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/PermissionCollection
		/// </java-name>
		[Dot42.DexImport("java/security/PermissionCollection", AccessFlags = 1057)]
		public abstract partial class PermissionCollection : global::Java.IO.ISerializable
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
				/// setReadOnly
				/// </java-name>
				[Dot42.DexImport("setReadOnly", "()V", AccessFlags = 1)]
				public virtual void SetReadOnly() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				public virtual bool IsReadOnly
				{
						[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/Permissions
		/// </java-name>
		[Dot42.DexImport("java/security/Permissions", AccessFlags = 49)]
		public sealed partial class Permissions : global::Java.Security.PermissionCollection, global::Java.IO.ISerializable
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

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
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
				public static global::Java.Security.Policy GetInstance(string type, global::Java.Security.Policy.IParameters @params) /* MethodBuilder.Create */ 
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
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", AccessFlags = 1)]
				public virtual global::Java.Security.PermissionCollection GetPermissions(global::Java.Security.CodeSource cs) /* MethodBuilder.Create */ 
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
				public virtual global::Java.Security.PermissionCollection GetPermissions(global::Java.Security.ProtectionDomain cs) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <java-name>
				/// implies
				/// </java-name>
				[Dot42.DexImport("implies", "(Ljava/security/ProtectionDomain;Ljava/security/Permission;)Z", AccessFlags = 1)]
				public virtual bool Implies(global::Java.Security.ProtectionDomain domain, global::Java.Security.Permission permission) /* MethodBuilder.Create */ 
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
				public virtual global::Java.Security.Policy.IParameters Parameters
				{
						[Dot42.DexImport("getParameters", "()Ljava/security/Policy$Parameters;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Policy.IParameters); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public virtual global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public virtual string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Legacy security code; do not use. </para>    
				/// </summary>
				/// <java-name>
				/// java/security/Policy$Parameters
				/// </java-name>
				[Dot42.DexImport("java/security/Policy$Parameters", AccessFlags = 1545)]
				public partial interface IParameters
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <summary>
		///  <para>Represents the Service Provider Interface (SPI) for java.security.Policy class.</para> <para>If there is any class that wants to provide a Policy implementation, all abstract methods in this SPI should be implemented.</para> <para>The detailed implementations should offer a public constructor, in which a Policy.Paramters implementation acts as an input parameter.If the Policy.Paramters input cannot by understood by the constructor, an IllegalArgumentException will be thrown. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Answers if the policy has granted a Permission to a ProtectionDomain.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>- true if the permission is granted to the domain. </para>
				/// </returns>
				/// <java-name>
				/// engineImplies
				/// </java-name>
				[Dot42.DexImport("engineImplies", "(Ljava/security/ProtectionDomain;Ljava/security/Permission;)Z", AccessFlags = 1028)]
				protected internal abstract bool EngineImplies(global::Java.Security.ProtectionDomain domain, global::Java.Security.Permission permission) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Refreshes/reloads the policy configuration. The behavior of this method depends on the implementation. For example, calling refresh on a file-based policy will cause the file to be re-read.</para> <para>The default implementation of this method does nothing. This method should be overridden if a refresh operation is supported by the policy implementation. </para>        
				/// </summary>
				/// <java-name>
				/// engineRefresh
				/// </java-name>
				[Dot42.DexImport("engineRefresh", "()V", AccessFlags = 4)]
				protected internal virtual void EngineRefresh() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Answers a PermissionCollection object containing the set of permissions granted to the specified CodeSource.</para> <para>The default implementation of this method returns Policy.UNSUPPORTED_EMPTY_COLLECTION object. This method can be overridden if the policy implementation can return a set of permissions granted to a CodeSource.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a set of permissions granted to the specified CodeSource. If this operation is supported, the returned set of permissions must be a new mutable instance and it must support heterogeneous Permission types. If this operation is not supported, Policy.UNSUPPORTED_EMPTY_COLLECTION is returned. </para>
				/// </returns>
				/// <java-name>
				/// engineGetPermissions
				/// </java-name>
				[Dot42.DexImport("engineGetPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.PermissionCollection EngineGetPermissions(global::Java.Security.CodeSource codesource) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <summary>
				///  <para>Answers a PermissionCollection object containing the set of permissions granted to the specified CodeSource.</para> <para>The default implementation of this method returns Policy.UNSUPPORTED_EMPTY_COLLECTION object. This method can be overridden if the policy implementation can return a set of permissions granted to a CodeSource.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a set of permissions granted to the specified CodeSource. If this operation is supported, the returned set of permissions must be a new mutable instance and it must support heterogeneous Permission types. If this operation is not supported, Policy.UNSUPPORTED_EMPTY_COLLECTION is returned. </para>
				/// </returns>
				/// <java-name>
				/// engineGetPermissions
				/// </java-name>
				[Dot42.DexImport("engineGetPermissions", "(Ljava/security/ProtectionDomain;)Ljava/security/PermissionCollection;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.PermissionCollection EngineGetPermissions(global::Java.Security.ProtectionDomain codesource) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/PrivilegedActionException
		/// </java-name>
		[Dot42.DexImport("java/security/PrivilegedActionException", AccessFlags = 33)]
		public partial class PrivilegedActionException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
				public PrivilegedActionException(global::System.Exception ex) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PrivilegedActionException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getException
				/// </java-name>
				public virtual global::System.Exception Exception
				{
						[Dot42.DexImport("getException", "()Ljava/lang/Exception;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/ProtectionDomain
		/// </java-name>
		[Dot42.DexImport("java/security/ProtectionDomain", AccessFlags = 33)]
		public partial class ProtectionDomain
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;)V", AccessFlags = 1)]
				public ProtectionDomain(global::Java.Security.CodeSource cs, global::Java.Security.PermissionCollection permissions) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/CodeSource;Ljava/security/PermissionCollection;Ljava/lang/ClassLo" +
    "ader;[Ljava/security/Principal;)V", AccessFlags = 1)]
				public ProtectionDomain(global::Java.Security.CodeSource cs, global::Java.Security.PermissionCollection permissions, global::Java.Lang.ClassLoader cl, global::Java.Security.IPrincipal[] principals) /* MethodBuilder.Create */ 
				{
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
						get{ return default(global::Java.Lang.ClassLoader); }
				}

				/// <java-name>
				/// getCodeSource
				/// </java-name>
				public global::Java.Security.CodeSource CodeSource
				{
						[Dot42.DexImport("getCodeSource", "()Ljava/security/CodeSource;", AccessFlags = 17)]
						get{ return default(global::Java.Security.CodeSource); }
				}

				/// <java-name>
				/// getPermissions
				/// </java-name>
				public global::Java.Security.PermissionCollection Permissions
				{
						[Dot42.DexImport("getPermissions", "()Ljava/security/PermissionCollection;", AccessFlags = 17)]
						get{ return default(global::Java.Security.PermissionCollection); }
				}

				/// <java-name>
				/// getPrincipals
				/// </java-name>
				public global::Java.Security.IPrincipal[] Principals
				{
						[Dot42.DexImport("getPrincipals", "()[Ljava/security/Principal;", AccessFlags = 17)]
						get{ return default(global::Java.Security.IPrincipal[]); }
				}

		}

		/// <summary>
		///  <para> <c>Provider </c> is the abstract superclass for all security providers in the Java security infrastructure. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/Provider
		/// </java-name>
		[Dot42.DexImport("java/security/Provider", AccessFlags = 1057)]
		public abstract partial class Provider : global::Java.Util.Properties
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>Provider </c> with its name, version and description.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;DLjava/lang/String;)V", AccessFlags = 4)]
				protected internal Provider(string name, double version, string info) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this <c>Provider </c> including its name and its version.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>Provider </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Clears all properties used to look up services implemented by this  <c>Provider </c> . </para>        
				/// </summary>
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
				public override void Load(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copies all from the provided map to this <c>Provider </c> . </para>        
				/// </summary>
				/// <java-name>
				/// putAll
				/// </java-name>
				[Dot42.DexImport("putAll", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<**>;)V")]
				public override void PutAll(global::Java.Util.IMap<object, object> t) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Maps the specified <c>key </c> property name to the specified <c>value </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value that was previously mapped to the specified <c>key </c> ,or <c>null </c> if it did not have one. </para>
				/// </returns>
				/// <java-name>
				/// put
				/// </java-name>
				[Dot42.DexImport("put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33)]
				public override object Put(object key, object value) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Removes the specified <c>key </c> and its associated value from this  <c>Provider </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value that was mapped to the specified <c>key </c> ,or  <c>null </c> if no mapping was present </para>
				/// </returns>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 33)]
				public override object Remove(object key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the service with the specified <c>type </c> implementing the specified <c>algorithm </c> , or <c>null </c> if no such implementation exists. </para> <para>If two services match the requested type and algorithm, the one added with the putService(Service) is returned (as opposed to the one added via put(Object, Object).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the requested service, or <c>null </c> if no such implementation exists </para>
				/// </returns>
				/// <java-name>
				/// getService
				/// </java-name>
				[Dot42.DexImport("getService", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Provider$Service;", AccessFlags = 33)]
				public virtual global::Java.Security.Provider.Service GetService(string type, string algorithm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider.Service);
				}

				/// <summary>
				///  <para>Adds a <c>Service </c> to this <c>Provider </c> . If a service with the same name was registered via this method, it is replace.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// putService
				/// </java-name>
				[Dot42.DexImport("putService", "(Ljava/security/Provider$Service;)V", AccessFlags = 36)]
				protected internal virtual void PutService(global::Java.Security.Provider.Service s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes a previously registered <c>Service </c> from this <c>Provider </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeService
				/// </java-name>
				[Dot42.DexImport("removeService", "(Ljava/security/Provider$Service;)V", AccessFlags = 36)]
				protected internal virtual void RemoveService(global::Java.Security.Provider.Service s) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Provider() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the name of this provider.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of this provider. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the version number for the services being provided.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the version number for the services being provided. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public virtual double Version
				{
						[Dot42.DexImport("getVersion", "()D", AccessFlags = 1)]
						get{ return default(double); }
				}

				/// <summary>
				///  <para>Returns a description of the services being provided.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a description of the services being provided. </para>
				/// </returns>
				/// <java-name>
				/// getInfo
				/// </java-name>
				public virtual string Info
				{
						[Dot42.DexImport("getInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns an unmodifiable <c>Set </c> of all services registered by this provider.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an unmodifiable <c>Set </c> of all services registered by this provider </para>
				/// </returns>
				/// <java-name>
				/// getServices
				/// </java-name>
				public virtual global::Java.Util.ISet<global::Java.Security.Provider.Service> Services
				{
						[Dot42.DexImport("getServices", "()Ljava/util/Set;", AccessFlags = 33, Signature = "()Ljava/util/Set<Ljava/security/Provider$Service;>;")]
						get{ return default(global::Java.Util.ISet<global::Java.Security.Provider.Service>); }
				}

				/// <summary>
				///  <para> <c>Service </c> represents a service in the Java Security infrastructure. Each service describes its type, the algorithm it implements, to which provider it belongs and other properties. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Returns the value of the attribute with the specified <c>name </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the value of the attribute, or <c>null </c> if no attribute with the given name is set. </para>
						/// </returns>
						/// <java-name>
						/// getAttribute
						/// </java-name>
						[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 17)]
						public string GetAttribute(string name) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Creates and returns a new instance of the implementation described by this <c>Service </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a new instance of the implementation described by this  <c>Service </c> . </para>
						/// </returns>
						/// <java-name>
						/// newInstance
						/// </java-name>
						[Dot42.DexImport("newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
						public virtual object NewInstance(object constructorParameter) /* MethodBuilder.Create */ 
						{
								return default(object);
						}

						/// <summary>
						///  <para>Indicates whether this <c>Service </c> supports the specified constructor parameter.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para> <c>true </c> if this <c>Service </c> supports the specified constructor parameter, <c>false </c> otherwise. </para>
						/// </returns>
						/// <java-name>
						/// supportsParameter
						/// </java-name>
						[Dot42.DexImport("supportsParameter", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
						public virtual bool SupportsParameter(object parameter) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Returns a string containing a concise, human-readable description of this <c>Service </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a printable representation for this <c>Service </c> . </para>
						/// </returns>
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

						/// <summary>
						///  <para>Returns the type of this <c>Service </c> . For example <c>KeyPairGenerator </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the type of this <c>Service </c> . </para>
						/// </returns>
						/// <java-name>
						/// getType
						/// </java-name>
						public string Type
						{
								[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para>Returns the name of the algorithm implemented by this <c>Service </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the name of the algorithm implemented by this <c>Service </c> . </para>
						/// </returns>
						/// <java-name>
						/// getAlgorithm
						/// </java-name>
						public string Algorithm
						{
								[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para>Returns the <c>Provider </c> this <c>Service </c> belongs to.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the <c>Provider </c> this <c>Service </c> belongs to. </para>
						/// </returns>
						/// <java-name>
						/// getProvider
						/// </java-name>
						public global::Java.Security.Provider Provider
						{
								[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
								get{ return default(global::Java.Security.Provider); }
						}

						/// <summary>
						///  <para>Returns the name of the class implementing this <c>Service </c> .</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the name of the class implementing this <c>Service </c> . </para>
						/// </returns>
						/// <java-name>
						/// getClassName
						/// </java-name>
						public string ClassName
						{
								[Dot42.DexImport("getClassName", "()Ljava/lang/String;", AccessFlags = 17)]
								get{ return default(string); }
						}

				}

		}

		/// <summary>
		///  <para> <c>ProviderException </c> is a general exception, thrown by security <c>Providers </c> .</para> <para> <para>Provider </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>ProviderException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ProviderException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>ProviderException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ProviderException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ProviderException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>SecureClassLoader </c> represents a <c>ClassLoader </c> which associates the classes it loads with a code source and provide mechanisms to allow the relevant permissions to be retrieved. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/SecureClassLoader
		/// </java-name>
		[Dot42.DexImport("java/security/SecureClassLoader", AccessFlags = 33)]
		public partial class SecureClassLoader : global::Java.Lang.ClassLoader
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>SecureClassLoader </c> . The default parent <c>ClassLoader </c> is used. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal SecureClassLoader() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>SecureClassLoader </c> with the specified parent <c>ClassLoader </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/ClassLoader;)V", AccessFlags = 4)]
				protected internal SecureClassLoader(global::Java.Lang.ClassLoader parent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>PermissionCollection </c> for the specified <c>CodeSource </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>PermissionCollection </c> for the specified <c>CodeSource </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.PermissionCollection GetPermissions(global::Java.Security.CodeSource codesource) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format with an optional <c>CodeSource </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new class. </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class;", AccessFlags = 20, Signature = "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string name, sbyte[] b, int off, int len, global::Java.Security.CodeSource cs) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format with an optional <c>CodeSource </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new class. </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class;", AccessFlags = 20, IgnoreFromJava = true, Signature = "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class<*>;")]
				protected internal global::System.Type DefineClass(string name, byte[] b, int off, int len, global::Java.Security.CodeSource cs) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <summary>
				///  <para>Constructs a new class from an array of bytes containing a class definition in class file format with an optional <c>CodeSource </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new class. </para>
				/// </returns>
				/// <java-name>
				/// defineClass
				/// </java-name>
				[Dot42.DexImport("defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/CodeSource;)Ljava/lang/Cla" +
    "ss;", AccessFlags = 20, Signature = "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/CodeSource;)Ljava/lang/Cla" +
    "ss<*>;")]
				protected internal global::System.Type DefineClass(string name, global::Java.Nio.ByteBuffer b, global::Java.Security.CodeSource cs) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

		}

		/// <summary>
		///  <para>This class generates cryptographically secure pseudo-random numbers.</para> <para>It is best to invoke <c>SecureRandom </c> using the default constructor. This will provide an instance of the most cryptographically strong provider available:</para> <para> <pre>SecureRandom sr = new SecureRandom();
		/// byte[] output = new byte[16];
		/// sr.nextBytes(output);</pre></para> <para>The default algorithm is defined by the first <c>SecureRandomSpi </c> provider found in the installed security providers. Use Security to install custom SecureRandomSpi providers.</para> <para>Note that the output of a <c>SecureRandom </c> instance should never be relied upon to be deterministic. For deterministic output from a given input, see MessageDigest which provides one-way hash functions. For deriving keys from passwords, see javax.crypto.SecretKeyFactory.</para> <para> <h3>Seeding SecureRandom  may be insecure</h3></para> <para>A seed is an array of bytes used to bootstrap random number generation. To produce cryptographically secure random numbers, both the seed and the algorithm must be secure.</para> <para>By default, instances of this class will generate an initial seed using an internal entropy source, such as <c>/dev/urandom </c> . This seed is unpredictable and appropriate for secure use.</para> <para>Using the seeded constructor or calling setSeed may completely replace the cryptographically strong default seed causing the instance to return a predictable sequence of numbers unfit for secure use. Due to variations between implementations it is not recommended to use <c>setSeed </c> at all. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/SecureRandom
		/// </java-name>
		[Dot42.DexImport("java/security/SecureRandom", AccessFlags = 33)]
		public partial class SecureRandom : global::System.Random
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new <c>SecureRandom </c> that uses the default algorithm. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecureRandom() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new seeded <c>SecureRandom </c> that uses the default algorithm. . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public SecureRandom(sbyte[] seed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new seeded <c>SecureRandom </c> that uses the default algorithm. . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public SecureRandom(byte[] seed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>SecureRandom </c> using the given implementation from the specified provider.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/SecureRandomSpi;Ljava/security/Provider;)V", AccessFlags = 4)]
				protected internal SecureRandom(global::Java.Security.SecureRandomSpi secureRandomSpi, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new instance of <c>SecureRandom </c> that utilizes the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>SecureRandom </c> that utilizes the specified algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/SecureRandom;", AccessFlags = 9)]
				public static global::Java.Security.SecureRandom GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Generates and stores random bytes in the given <c>byte[] </c> for each array element.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// nextBytes
				/// </java-name>
				[Dot42.DexImport("nextBytes", "([B)V", AccessFlags = 33)]
				public override void NextBytes(sbyte[] bytes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generates and stores random bytes in the given <c>byte[] </c> for each array element.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// nextBytes
				/// </java-name>
				[Dot42.DexImport("nextBytes", "([B)V", AccessFlags = 33, IgnoreFromJava = true)]
				public override void NextBytes(byte[] bytes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generates and returns an <c>int </c> containing the specified number of random bits (right justified, with leading zeros).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an <c>int </c> containing the specified number of random bits. </para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(I)I", AccessFlags = 20)]
				protected internal override int JavaNext(int numBits) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Generates and returns the specified number of seed bytes, computed using the seed generation algorithm used by this <c>SecureRandom </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the seed bytes </para>
				/// </returns>
				/// <java-name>
				/// getSeed
				/// </java-name>
				[Dot42.DexImport("getSeed", "(I)[B", AccessFlags = 9)]
				public static sbyte[] JavaGetSeed(int numBytes) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Generates and returns the specified number of seed bytes, computed using the seed generation algorithm used by this <c>SecureRandom </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the seed bytes </para>
				/// </returns>
				/// <java-name>
				/// getSeed
				/// </java-name>
				[Dot42.DexImport("getSeed", "(I)[B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte[] GetSeed(int numBytes) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Generates and returns the specified number of seed bytes, computed using the seed generation algorithm used by this <c>SecureRandom </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the seed bytes. </para>
				/// </returns>
				/// <java-name>
				/// generateSeed
				/// </java-name>
				[Dot42.DexImport("generateSeed", "(I)[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGenerateSeed(int numBytes) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Generates and returns the specified number of seed bytes, computed using the seed generation algorithm used by this <c>SecureRandom </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the seed bytes. </para>
				/// </returns>
				/// <java-name>
				/// generateSeed
				/// </java-name>
				[Dot42.DexImport("generateSeed", "(I)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual byte[] GenerateSeed(int numBytes) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns the provider associated with this <c>SecureRandom </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider associated with this <c>SecureRandom </c> . </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <summary>
				///  <para>Returns the name of the algorithm of this <c>SecureRandom </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm of this <c>SecureRandom </c> . </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public virtual string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para> <c>SecureRandomSpi </c> is the  <b>Service Provider Interface</b> ( <b>SPI</b>) definition for SecureRandom.</para> <para> <para>SecureRandom </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/SecureRandomSpi
		/// </java-name>
		[Dot42.DexImport("java/security/SecureRandomSpi", AccessFlags = 1057)]
		public abstract partial class SecureRandomSpi : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SecureRandomSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reseeds this <c>SecureRandomSpi </c> instance with the specified <c>seed </c> . The seed of this <c>SecureRandomSpi </c> instance is supplemented, not replaced.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetSeed
				/// </java-name>
				[Dot42.DexImport("engineSetSeed", "([B)V", AccessFlags = 1028)]
				protected internal abstract void EngineSetSeed(sbyte[] seed) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Reseeds this <c>SecureRandomSpi </c> instance with the specified <c>seed </c> . The seed of this <c>SecureRandomSpi </c> instance is supplemented, not replaced.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetSeed
				/// </java-name>
				[Dot42.DexImport("engineSetSeed", "([B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineSetSeed(byte[] seed) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and stores random bytes in the given <c>byte[] </c> for each array element.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineNextBytes
				/// </java-name>
				[Dot42.DexImport("engineNextBytes", "([B)V", AccessFlags = 1028)]
				protected internal abstract void EngineNextBytes(sbyte[] bytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and stores random bytes in the given <c>byte[] </c> for each array element.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineNextBytes
				/// </java-name>
				[Dot42.DexImport("engineNextBytes", "([B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineNextBytes(byte[] bytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and returns the specified number of seed bytes, computed using the seed generation algorithm used by this <c>SecureRandomSpi </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the seed bytes </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateSeed
				/// </java-name>
				[Dot42.DexImport("engineGenerateSeed", "(I)[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineGenerateSeed(int numBytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and returns the specified number of seed bytes, computed using the seed generation algorithm used by this <c>SecureRandomSpi </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the seed bytes </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateSeed
				/// </java-name>
				[Dot42.DexImport("engineGenerateSeed", "(I)[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineGenerateSeed(int numBytes) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para> <c>Security </c> is the central class in the Java Security API. It manages the list of security <c>Provider </c> that have been installed into this runtime environment. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/Security
		/// </java-name>
		[Dot42.DexImport("java/security/Security", AccessFlags = 49)]
		public sealed partial class Security
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This class can't be instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Security() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns value for the specified algorithm with the specified name.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use AlgorithmParameters and KeyFactory instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>value of the property. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithmProperty
				/// </java-name>
				[Dot42.DexImport("getAlgorithmProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetAlgorithmProperty(string algName, string propName) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Insert the given <c>Provider </c> at the specified <c>position </c> . The positions define the preference order in which providers are searched for requested algorithms.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the actual position or <c>-1 </c> if the given <c>provider </c> was already in the list. The actual position may be different from the desired position. </para>
				/// </returns>
				/// <java-name>
				/// insertProviderAt
				/// </java-name>
				[Dot42.DexImport("insertProviderAt", "(Ljava/security/Provider;I)I", AccessFlags = 41)]
				public static int InsertProviderAt(global::Java.Security.Provider provider, int position) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Adds the given <c>provider </c> to the collection of providers at the next available position.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the actual position or <c>-1 </c> if the given <c>provider </c> was already in the list. </para>
				/// </returns>
				/// <java-name>
				/// addProvider
				/// </java-name>
				[Dot42.DexImport("addProvider", "(Ljava/security/Provider;)I", AccessFlags = 9)]
				public static int AddProvider(global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes the <c>Provider </c> with the specified name form the collection of providers. If the the <c>Provider </c> with the specified name is removed, all provider at a greater position are shifted down one position.</para> <para>Returns silently if <c>name </c> is <c>null </c> or no provider with the specified name is installed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeProvider
				/// </java-name>
				[Dot42.DexImport("removeProvider", "(Ljava/lang/String;)V", AccessFlags = 41)]
				public static void RemoveProvider(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>Provider </c> with the specified name. Returns <c>null </c> if name is <c>null </c> or no provider with the specified name is installed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider with the specified name, maybe <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				[Dot42.DexImport("getProvider", "(Ljava/lang/String;)Ljava/security/Provider;", AccessFlags = 41)]
				public static global::Java.Security.Provider GetProvider(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider);
				}

				/// <summary>
				///  <para>Returns the array of providers which meet the user supplied set of filters. The filter must be supplied in one of two formats: &lt;nl&gt;  CRYPTO_SERVICE_NAME.ALGORITHM_OR_TYPE </para> <para>for example: "MessageDigest.SHA" The value associated with the key must be an empty string.  CRYPTO_SERVICE_NAME.ALGORITHM_OR_TYPE ATTR_NAME:ATTR_VALUE </para> <para>for example: "Signature.MD2withRSA KeySize:512" where "KeySize:512" is the value of the filter map entry. &lt;/nl&gt;</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the providers which meet the user supplied string filter <c>filter </c> . A <c>null </c> value signifies that none of the installed providers meets the filter specification. </para>
				/// </returns>
				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "(Ljava/lang/String;)[Ljava/security/Provider;", AccessFlags = 9)]
				public static global::Java.Security.Provider[] GetProviders(string filter) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider[]);
				}

				/// <summary>
				///  <para>Returns the array of providers which meet the user supplied set of filters. The filter must be supplied in one of two formats: &lt;nl&gt;  CRYPTO_SERVICE_NAME.ALGORITHM_OR_TYPE </para> <para>for example: "MessageDigest.SHA" The value associated with the key must be an empty string.  CRYPTO_SERVICE_NAME.ALGORITHM_OR_TYPE ATTR_NAME:ATTR_VALUE </para> <para>for example: "Signature.MD2withRSA KeySize:512" where "KeySize:512" is the value of the filter map entry. &lt;/nl&gt;</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the providers which meet the user supplied string filter <c>filter </c> . A <c>null </c> value signifies that none of the installed providers meets the filter specification. </para>
				/// </returns>
				/// <java-name>
				/// getProviders
				/// </java-name>
				[Dot42.DexImport("getProviders", "(Ljava/util/Map;)[Ljava/security/Provider;", AccessFlags = 41, Signature = "(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)[Ljava/security/Provider;")]
				public static global::Java.Security.Provider[] GetProviders(global::Java.Util.IMap<string, string> filter) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Provider[]);
				}

				/// <summary>
				///  <para>Returns the value of the security property named by the argument.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of the security property. </para>
				/// </returns>
				/// <java-name>
				/// getProperty
				/// </java-name>
				[Dot42.DexImport("getProperty", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetProperty(string key) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Sets the value of the specified security property. </para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetProperty(string key, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a <c>Set </c> of all registered algorithms for the specified cryptographic service. <c>"Signature" </c> , <c>"Cipher" </c> and <c>"KeyStore" </c> are examples for such kind of services.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>Set </c> of all registered algorithms for the specified cryptographic service, or an empty <c>Set </c> if <c>serviceName </c> is <c>null </c> or if no registered provider provides the requested service. </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithms
				/// </java-name>
				[Dot42.DexImport("getAlgorithms", "(Ljava/lang/String;)Ljava/util/Set;", AccessFlags = 9, Signature = "(Ljava/lang/String;)Ljava/util/Set<Ljava/lang/String;>;")]
				public static global::Java.Util.ISet<string> GetAlgorithms(string serviceName) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <summary>
				///  <para>Returns an array containing all installed providers. The providers are ordered according their preference order.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array containing all installed providers. </para>
				/// </returns>
				/// <java-name>
				/// getProviders
				/// </java-name>
				public static global::Java.Security.Provider[] Providers
				{
						[Dot42.DexImport("getProviders", "()[Ljava/security/Provider;", AccessFlags = 41)]
						get{ return default(global::Java.Security.Provider[]); }
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/SecurityPermission
		/// </java-name>
		[Dot42.DexImport("java/security/SecurityPermission", AccessFlags = 49)]
		public sealed partial class SecurityPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SecurityPermission(string name) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SecurityPermission(string name, string action) /* MethodBuilder.Create */ 
				{
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
				public override string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para> <c>Signature </c> is an engine class which is capable of creating and verifying digital signatures, using different algorithms that have been registered with the Security class.</para> <para> <para>SignatureSpi </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/Signature
		/// </java-name>
		[Dot42.DexImport("java/security/Signature", AccessFlags = 1057)]
		public abstract partial class Signature : global::Java.Security.SignatureSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constant that indicates that this <c>Signature </c> instance has not yet been initialized. </para>        
				/// </summary>
				/// <java-name>
				/// UNINITIALIZED
				/// </java-name>
				[Dot42.DexImport("UNINITIALIZED", "I", AccessFlags = 28)]
				protected internal const int UNINITIALIZED = 0;
				/// <summary>
				///  <para>Constant that indicates that this <c>Signature </c> instance has been initialized for signing. </para>        
				/// </summary>
				/// <java-name>
				/// SIGN
				/// </java-name>
				[Dot42.DexImport("SIGN", "I", AccessFlags = 28)]
				protected internal const int SIGN = 2;
				/// <summary>
				///  <para>Constant that indicates that this <c>Signature </c> instance has been initialized for verification. </para>        
				/// </summary>
				/// <java-name>
				/// VERIFY
				/// </java-name>
				[Dot42.DexImport("VERIFY", "I", AccessFlags = 28)]
				protected internal const int VERIFY = 3;
				/// <summary>
				///  <para>Represents the current state of this <c>Signature </c> . The three possible states are UNINITIALIZED, SIGN or VERIFY. </para>        
				/// </summary>
				/// <java-name>
				/// state
				/// </java-name>
				[Dot42.DexImport("state", "I", AccessFlags = 4)]
				protected internal int State;
				/// <summary>
				///  <para>Constructs a new instance of <c>Signature </c> with the name of the algorithm to use.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Signature(string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new instance of <c>Signature </c> that utilizes the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a new instance of <c>Signature </c> that utilizes the specified algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/Signature;", AccessFlags = 9)]
				public static global::Java.Security.Signature GetInstance(string algorithm) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Initializes this <c>Signature </c> instance for signature verification, using the public key of the identity whose signature is going to be verified.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initVerify
				/// </java-name>
				[Dot42.DexImport("initVerify", "(Ljava/security/PublicKey;)V", AccessFlags = 17)]
				public void InitVerify(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>Signature </c> instance for signature verification, using the public key of the identity whose signature is going to be verified.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initVerify
				/// </java-name>
				[Dot42.DexImport("initVerify", "(Ljava/security/cert/Certificate;)V", AccessFlags = 17)]
				public void InitVerify(global::Java.Security.Cert.Certificate publicKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>Signature </c> instance for signing, using the private key of the identity whose signature is going to be generated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initSign
				/// </java-name>
				[Dot42.DexImport("initSign", "(Ljava/security/PrivateKey;)V", AccessFlags = 17)]
				public void InitSign(global::Java.Security.IPrivateKey privateKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>Signature </c> instance for signing, using the private key of the identity whose signature is going to be generated and the specified source of randomness.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initSign
				/// </java-name>
				[Dot42.DexImport("initSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V", AccessFlags = 17)]
				public void InitSign(global::Java.Security.IPrivateKey privateKey, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generates and returns the signature of all updated data. </para> <para>This <c>Signature </c> instance is reset to the state of its last initialization for signing and thus can be used for another signature from the same identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature of all updated data. </para>
				/// </returns>
				/// <java-name>
				/// sign
				/// </java-name>
				[Dot42.DexImport("sign", "()[B", AccessFlags = 17)]
				public sbyte[] JavaSign() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Generates and returns the signature of all updated data. </para> <para>This <c>Signature </c> instance is reset to the state of its last initialization for signing and thus can be used for another signature from the same identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature of all updated data. </para>
				/// </returns>
				/// <java-name>
				/// sign
				/// </java-name>
				[Dot42.DexImport("sign", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public byte[] Sign() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Generates and stores the signature of all updated data in the provided  <c>byte[] </c> at the specified position with the specified length. </para> <para>This <c>Signature </c> instance is reset to the state of its last initialization for signing and thus can be used for another signature from the same identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes stored in <c>outbuf </c> . </para>
				/// </returns>
				/// <java-name>
				/// sign
				/// </java-name>
				[Dot42.DexImport("sign", "([BII)I", AccessFlags = 17)]
				public int Sign(sbyte[] outbuf, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Generates and stores the signature of all updated data in the provided  <c>byte[] </c> at the specified position with the specified length. </para> <para>This <c>Signature </c> instance is reset to the state of its last initialization for signing and thus can be used for another signature from the same identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes stored in <c>outbuf </c> . </para>
				/// </returns>
				/// <java-name>
				/// sign
				/// </java-name>
				[Dot42.DexImport("sign", "([BII)I", AccessFlags = 17, IgnoreFromJava = true)]
				public int Sign(byte[] outbuf, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether the given <c>signature </c> can be verified using the public key or a certificate of the signer. </para> <para>This <c>Signature </c> instance is reset to the state of its last initialization for verifying and thus can be used to verify another signature of the same signer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the signature was verified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "([B)Z", AccessFlags = 17)]
				public bool Verify(sbyte[] signature) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether the given <c>signature </c> can be verified using the public key or a certificate of the signer. </para> <para>This <c>Signature </c> instance is reset to the state of its last initialization for verifying and thus can be used to verify another signature of the same signer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the signature was verified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "([B)Z", AccessFlags = 17, IgnoreFromJava = true)]
				public bool Verify(byte[] signature) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether the given <c>signature </c> starting at index <c>offset </c> with <c>length </c> bytes can be verified using the public key or a certificate of the signer. </para> <para>This <c>Signature </c> instance is reset to the state of its last initialization for verifying and thus can be used to verify another signature of the same signer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the signature was verified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "([BII)Z", AccessFlags = 17)]
				public bool Verify(sbyte[] signature, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether the given <c>signature </c> starting at index <c>offset </c> with <c>length </c> bytes can be verified using the public key or a certificate of the signer. </para> <para>This <c>Signature </c> instance is reset to the state of its last initialization for verifying and thus can be used to verify another signature of the same signer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the signature was verified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "([BII)Z", AccessFlags = 17, IgnoreFromJava = true)]
				public bool Verify(byte[] signature, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the specified  <c>ByteBuffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 17)]
				public void Update(sbyte data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the specified  <c>ByteBuffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the specified  <c>ByteBuffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 17)]
				public void Update(sbyte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the specified  <c>ByteBuffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([B)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte[] data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the given <c>byte[] </c> , starting form the specified index for the specified length.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 17)]
				public void Update(sbyte[] data, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the given <c>byte[] </c> , starting form the specified index for the specified length.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "([BII)V", AccessFlags = 17, IgnoreFromJava = true)]
				public void Update(byte[] data, int off, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the specified  <c>ByteBuffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 17)]
				public void Update(global::Java.Nio.ByteBuffer data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this  <c>Signature </c> including its algorithm and its state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>Signature </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Sets the specified parameter to the given value.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use setParameter(AlgorithmParameterSpec) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 17)]
				public void SetParameter(string param, object value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the specified <c>AlgorithmParameterSpec </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 17)]
				public void SetParameter(global::Java.Security.Spec.IAlgorithmParameterSpec @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the value of the parameter with the specified name.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>There is no generally accepted parameter naming convention. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of the parameter with the specified name, maybe <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 17)]
				public object GetParameter(string param) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the provider associated with this <c>Signature </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider associated with this <c>Signature </c> . </para>
				/// </returns>
				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <summary>
				///  <para>Returns the name of the algorithm of this <c>Signature </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm of this <c>Signature </c> . </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the <c>AlgorithmParameters </c> of this Signature instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>AlgorithmParameters </c> of this Signature instance, maybe <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Java.Security.AlgorithmParameters Parameters
				{
						[Dot42.DexImport("getParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 17)]
						get{ return default(global::Java.Security.AlgorithmParameters); }
				}

		}

		/// <summary>
		///  <para> <c>SignatureException </c> is a general <c>Signature </c> exception.</para> <para> <para>Signature </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Constructs a new instance of <c>SignatureException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SignatureException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>SignatureException </c> with the given message and the cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SignatureException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SignatureException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>SignatureSpi </c> is the  <b>Service Provider Interface</b> ( <b>SPI</b>) definition for Signature.</para> <para> <para>Signature </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/SignatureSpi
		/// </java-name>
		[Dot42.DexImport("java/security/SignatureSpi", AccessFlags = 1057)]
		public abstract partial class SignatureSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Implementation specific source of randomness. </para>        
				/// </summary>
				/// <java-name>
				/// appRandom
				/// </java-name>
				[Dot42.DexImport("appRandom", "Ljava/security/SecureRandom;", AccessFlags = 4)]
				protected internal global::Java.Security.SecureRandom AppRandom;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SignatureSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes this <c>SignatureSpi </c> instance for signature verification, using the public key of the identity whose signature is going to be verified.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInitVerify
				/// </java-name>
				[Dot42.DexImport("engineInitVerify", "(Ljava/security/PublicKey;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInitVerify(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>SignatureSpi </c> instance for signing, using the private key of the identity whose signature is going to be generated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInitSign
				/// </java-name>
				[Dot42.DexImport("engineInitSign", "(Ljava/security/PrivateKey;)V", AccessFlags = 1028)]
				protected internal abstract void EngineInitSign(global::Java.Security.IPrivateKey privateKey) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Initializes this <c>SignatureSpi </c> instance for signing, using the private key of the identity whose signature is going to be generated and the specified source of randomness.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineInitSign
				/// </java-name>
				[Dot42.DexImport("engineInitSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V", AccessFlags = 4)]
				protected internal virtual void EngineInitSign(global::Java.Security.IPrivateKey privateKey, global::Java.Security.SecureRandom random) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the specified  <c>ByteBuffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte input) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the specified  <c>ByteBuffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(B)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte input) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the given <c>byte[] </c> , starting form the specified index for the specified length.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028)]
				protected internal abstract void EngineUpdate(sbyte[] b, int off, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the given <c>byte[] </c> , starting form the specified index for the specified length.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "([BII)V", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract void EngineUpdate(byte[] b, int off, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Updates the data to be verified or to be signed, using the specified  <c>ByteBuffer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineUpdate
				/// </java-name>
				[Dot42.DexImport("engineUpdate", "(Ljava/nio/ByteBuffer;)V", AccessFlags = 4)]
				protected internal virtual void EngineUpdate(global::Java.Nio.ByteBuffer input) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generates and returns the signature of all updated data. </para> <para>This <c>SignatureSpi </c> instance is reset to the state of its last initialization for signing and thus can be used for another signature from the same identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature of all updated data. </para>
				/// </returns>
				/// <java-name>
				/// engineSign
				/// </java-name>
				[Dot42.DexImport("engineSign", "()[B", AccessFlags = 1028)]
				protected internal abstract sbyte[] JavaEngineSign() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and returns the signature of all updated data. </para> <para>This <c>SignatureSpi </c> instance is reset to the state of its last initialization for signing and thus can be used for another signature from the same identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature of all updated data. </para>
				/// </returns>
				/// <java-name>
				/// engineSign
				/// </java-name>
				[Dot42.DexImport("engineSign", "()[B", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract byte[] EngineSign() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and stores the signature of all updated data in the provided  <c>byte[] </c> at the specified position with the specified length. </para> <para>This <c>SignatureSpi </c> instance is reset to the state of its last initialization for signing and thus can be used for another signature from the same identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes stored in <c>outbuf </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineSign
				/// </java-name>
				[Dot42.DexImport("engineSign", "([BII)I", AccessFlags = 4)]
				protected internal virtual int EngineSign(sbyte[] outbuf, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Generates and stores the signature of all updated data in the provided  <c>byte[] </c> at the specified position with the specified length. </para> <para>This <c>SignatureSpi </c> instance is reset to the state of its last initialization for signing and thus can be used for another signature from the same identity.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of bytes stored in <c>outbuf </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineSign
				/// </java-name>
				[Dot42.DexImport("engineSign", "([BII)I", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual int EngineSign(byte[] outbuf, int offset, int len) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Indicates whether the given <c>sigBytes </c> can be verified using the public key or a certificate of the signer. </para> <para>This <c>SignatureSpi </c> instance is reset to the state of its last initialization for verifying and thus can be used to verify another signature of the same signer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the signature was verified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// engineVerify
				/// </java-name>
				[Dot42.DexImport("engineVerify", "([B)Z", AccessFlags = 1028)]
				protected internal abstract bool EngineVerify(sbyte[] sigBytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates whether the given <c>sigBytes </c> can be verified using the public key or a certificate of the signer. </para> <para>This <c>SignatureSpi </c> instance is reset to the state of its last initialization for verifying and thus can be used to verify another signature of the same signer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the signature was verified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// engineVerify
				/// </java-name>
				[Dot42.DexImport("engineVerify", "([B)Z", AccessFlags = 1028, IgnoreFromJava = true)]
				protected internal abstract bool EngineVerify(byte[] sigBytes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates whether the given <c>sigBytes </c> starting at index <c>offset </c> with <c>length </c> bytes can be verified using the public key or a certificate of the signer. </para> <para>This <c>SignatureSpi </c> instance is reset to the state of its last initialization for verifying and thus can be used to verify another signature of the same signer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the signature was verified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// engineVerify
				/// </java-name>
				[Dot42.DexImport("engineVerify", "([BII)Z", AccessFlags = 4)]
				protected internal virtual bool EngineVerify(sbyte[] sigBytes, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether the given <c>sigBytes </c> starting at index <c>offset </c> with <c>length </c> bytes can be verified using the public key or a certificate of the signer. </para> <para>This <c>SignatureSpi </c> instance is reset to the state of its last initialization for verifying and thus can be used to verify another signature of the same signer.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the signature was verified, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// engineVerify
				/// </java-name>
				[Dot42.DexImport("engineVerify", "([BII)Z", AccessFlags = 4, IgnoreFromJava = true)]
				protected internal virtual bool EngineVerify(byte[] sigBytes, int offset, int length) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Sets the specified parameter to the given value.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use engineSetParameter(AlgorithmParameterSpec) </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// engineSetParameter
				/// </java-name>
				[Dot42.DexImport("engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1028)]
				protected internal abstract void EngineSetParameter(string param, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the specified <c>AlgorithmParameterSpec </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineSetParameter
				/// </java-name>
				[Dot42.DexImport("engineSetParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V", AccessFlags = 4)]
				protected internal virtual void EngineSetParameter(global::Java.Security.Spec.IAlgorithmParameterSpec @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>AlgorithmParameters </c> of this SignatureSpi instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>AlgorithmParameters </c> of this SignatureSpi instance, maybe <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineGetParameters
				/// </java-name>
				[Dot42.DexImport("engineGetParameters", "()Ljava/security/AlgorithmParameters;", AccessFlags = 4)]
				protected internal virtual global::Java.Security.AlgorithmParameters EngineGetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.AlgorithmParameters);
				}

				/// <summary>
				///  <para>Returns the value of the parameter with the specified name.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>There is no generally accepted parameter naming convention. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of the parameter with the specified name, maybe <c>null </c> . </para>
				/// </returns>
				/// <java-name>
				/// engineGetParameter
				/// </java-name>
				[Dot42.DexImport("engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1028)]
				protected internal abstract object EngineGetParameter(string param) /* MethodBuilder.Create */ ;

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
		///  <para>A <c>SignedObject </c> instance acts as a container for another object. The  <c>SignedObject </c> contains the target in serialized form along with a digital signature of the serialized data. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/SignedObject
		/// </java-name>
		[Dot42.DexImport("java/security/SignedObject", AccessFlags = 49)]
		public sealed partial class SignedObject : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>SignedObject </c> with the target object, the private key and the engine to compute the signature. The given  <c>object </c> is signed with the specified key and engine.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/Serializable;Ljava/security/PrivateKey;Ljava/security/Signature;)V", AccessFlags = 1)]
				public SignedObject(global::Java.IO.ISerializable @object, global::Java.Security.IPrivateKey signingKey, global::Java.Security.Signature signingEngine) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the signature data of the encapsulated serialized object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature data of the encapsulated serialized object. </para>
				/// </returns>
				/// <java-name>
				/// getSignature
				/// </java-name>
				[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetSignature() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Indicates whether the contained signature for the encapsulated object is valid.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the contained signature for the encapsulated object is valid, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;Ljava/security/Signature;)Z", AccessFlags = 1)]
				public bool Verify(global::Java.Security.IPublicKey verificationKey, global::Java.Security.Signature verificationEngine) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SignedObject() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the encapsulated object. Each time this method is invoked, the encapsulated object is deserialized before it is returned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encapsulated object. </para>
				/// </returns>
				/// <java-name>
				/// getObject
				/// </java-name>
				public object Object
				{
						[Dot42.DexImport("getObject", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <summary>
				///  <para>Returns the signature data of the encapsulated serialized object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature data of the encapsulated serialized object. </para>
				/// </returns>
				/// <java-name>
				/// getSignature
				/// </java-name>
				public byte[] Signature
				{
						[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the name of the algorithm of this <c>SignedObject </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the algorithm of this <c>SignedObject </c> . </para>
				/// </returns>
				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>Signer represents an identity (individual or corporation) that owns a private key and the corresponding public key.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use the java.security.cert package and java.security.Principal instead. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// java/security/Signer
		/// </java-name>
		[Dot42.DexImport("java/security/Signer", AccessFlags = 1057)]
		public abstract partial class Signer : global::Java.Security.Identity
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>Signer </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Signer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>Signer </c> with the given name.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Signer(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>Signer </c> with the given name in the given scope.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/IdentityScope;)V", AccessFlags = 1)]
				public Signer(string name, global::Java.Security.IdentityScope scope) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Associates the specified key pair with this <c>Signer </c> .</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setKeyPair
				/// </java-name>
				[Dot42.DexImport("setKeyPair", "(Ljava/security/KeyPair;)V", AccessFlags = 17)]
				public void SetKeyPair(global::Java.Security.KeyPair pair) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of this  <c>Signer </c> including its name and its scope if present.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>Signer </c> . </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the private key of this <c>Signer </c> . </para>        
				/// </summary>
				/// <java-name>
				/// getPrivateKey
				/// </java-name>
				public virtual global::Java.Security.IPrivateKey PrivateKey
				{
						[Dot42.DexImport("getPrivateKey", "()Ljava/security/PrivateKey;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPrivateKey); }
				}

		}

		/// <summary>
		///  <para> <c>Timestamp </c> represents a signed time stamp. <c>Timestamp </c> is immutable. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/Timestamp
		/// </java-name>
		[Dot42.DexImport("java/security/Timestamp", AccessFlags = 49)]
		public sealed partial class Timestamp : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>Timestamp </c> with the specified <c>timestamp </c> and the given certificate path.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Date;Ljava/security/cert/CertPath;)V", AccessFlags = 1)]
				public Timestamp(global::Java.Util.Date timestamp, global::Java.Security.Cert.CertPath signerCertPath) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compares the specified object with this <c>Timestamp </c> for equality and returns <c>true </c> if the specified object is equal, <c>false </c> otherwise. The given object is equal to this <c>Timestamp </c> , if it is an instance of <c>Timestamp </c> , the two timestamps have an equal date and time and their certificate paths are equal.</para> <para> <para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this <c>Timestamp </c> , otherwise <c>false </c> . </para>
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
				///  <para>Returns the date and time of this <c>Timestamp </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the date and time of this <c>Timestamp </c> . </para>
				/// </returns>
				/// <java-name>
				/// getTimestamp
				/// </java-name>
				[Dot42.DexImport("getTimestamp", "()Ljava/util/Date;", AccessFlags = 1)]
				public global::Java.Util.Date GetTimestamp() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				///  <para>Returns the hash code value for this <c>Timestamp </c> . Returns the same hash code for <c>Timestamp </c> s that are equal to each other as required by the general contract of Object#hashCode.</para> <para> <para>Object::equals(Object) </para> <para>Timestamp::equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code value for this <c>Timestamp </c> . </para>
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
				///  <para>Returns a string containing a concise, human-readable description of this  <c>Timestamp </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for this <c>Timestamp </c> . </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the certificate path of this <c>Timestamp </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate path of this <c>Timestamp </c> . </para>
				/// </returns>
				/// <java-name>
				/// getSignerCertPath
				/// </java-name>
				public global::Java.Security.Cert.CertPath SignerCertPath
				{
						[Dot42.DexImport("getSignerCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.CertPath); }
				}

		}

		/// <summary>
		///  <para> <c>UnrecoverableEntryException </c> indicates, that a <c>KeyStore.Entry </c> cannot be recovered from a <c>KeyStore </c> .</para> <para> <para>KeyStore </para> <para>KeyStore.Entry </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/UnrecoverableEntryException
		/// </java-name>
		[Dot42.DexImport("java/security/UnrecoverableEntryException", AccessFlags = 33)]
		public partial class UnrecoverableEntryException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>UnrecoverableEntryException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnrecoverableEntryException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>UnrecoverableEntryException </c> with the given message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnrecoverableEntryException(string msg) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para> <c>UnrecoverableKeyException </c> indicates, that a key cannot be recovered from a <c>KeyStore </c> .</para> <para> <para>KeyStore </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/UnrecoverableKeyException
		/// </java-name>
		[Dot42.DexImport("java/security/UnrecoverableKeyException", AccessFlags = 33)]
		public partial class UnrecoverableKeyException : global::Java.Security.UnrecoverableEntryException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of <c>UnrecoverableKeyException </c> with the given message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnrecoverableKeyException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a new instance of <c>UnrecoverableKeyException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnrecoverableKeyException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/UnresolvedPermission
		/// </java-name>
		[Dot42.DexImport("java/security/UnresolvedPermission", AccessFlags = 49)]
		public sealed partial class UnresolvedPermission : global::Java.Security.Permission, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/security/cert/Certi" +
    "ficate;)V", AccessFlags = 1)]
				public UnresolvedPermission(string type, string name, string actions, global::Java.Security.Cert.Certificate[] certs) /* MethodBuilder.Create */ 
				{
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
						get{ return default(string); }
				}

				/// <java-name>
				/// getUnresolvedActions
				/// </java-name>
				public string UnresolvedActions
				{
						[Dot42.DexImport("getUnresolvedActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getUnresolvedType
				/// </java-name>
				public string UnresolvedType
				{
						[Dot42.DexImport("getUnresolvedType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getUnresolvedCerts
				/// </java-name>
				public global::Java.Security.Cert.Certificate[] UnresolvedCerts
				{
						[Dot42.DexImport("getUnresolvedCerts", "()[Ljava/security/cert/Certificate;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.Certificate[]); }
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public override string Actions
				{
						[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

