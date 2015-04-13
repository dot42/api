#pragma warning disable 1717
namespace Javax.Security.Auth
{
		/// <java-name>
		/// javax/security/auth/AuthPermission
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/AuthPermission", AccessFlags = 49)]
		public sealed partial class AuthPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthPermission(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthPermission(string @string, string string1) /* MethodBuilder.Create */ 
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
				internal AuthPermission() /* TypeBuilder.AddDefaultConstructor */ 
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

		/// <java-name>
		/// javax/security/auth/DestroyFailedException
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/DestroyFailedException", AccessFlags = 33)]
		public partial class DestroyFailedException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DestroyFailedException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DestroyFailedException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/security/auth/Destroyable
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/Destroyable", AccessFlags = 1537)]
		public partial interface IDestroyable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1025)]
				void Destroy() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isDestroyed
				/// </java-name>
				bool IsDestroyed
				{
						[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/security/auth/PrivateCredentialPermission
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/PrivateCredentialPermission", AccessFlags = 49)]
		public sealed partial class PrivateCredentialPermission : global::Java.Security.Permission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrivateCredentialPermission(string @string, string string1) /* MethodBuilder.Create */ 
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
				internal PrivateCredentialPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPrincipals
				/// </java-name>
				public string[][] Principals
				{
						[Dot42.DexImport("getPrincipals", "()[[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[][]); }
				}

				/// <java-name>
				/// getCredentialClass
				/// </java-name>
				public string CredentialClass
				{
						[Dot42.DexImport("getCredentialClass", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
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

		/// <java-name>
		/// javax/security/auth/Subject
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/Subject", AccessFlags = 49)]
		public sealed partial class Subject : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Subject() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;)V", AccessFlags = 1, Signature = "(ZLjava/util/Set<+Ljava/security/Principal;>;Ljava/util/Set<*>;Ljava/util/Set<*>;" +
    ")V")]
				public Subject(bool boolean, global::Java.Util.ISet<global::Java.Security.IPrincipal> set, global::Java.Util.ISet<object> set1, global::Java.Util.ISet<object> set2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doAs
				/// </java-name>
				[Dot42.DexImport("doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;)Ljava/lang/Object;" +
    "", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljavax/security/auth/Subject;Ljava/security/PrivilegedActi" +
    "on<TT;>;)TT;")]
				public static T DoAs<T>(global::Javax.Security.Auth.Subject subject, global::Java.Security.IPrivilegedAction<T> privilegedAction) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// doAsPrivileged
				/// </java-name>
				[Dot42.DexImport("doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;Ljava/security/Acce" +
    "ssControlContext;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljavax/security/auth/Subject;Ljava/security/PrivilegedActi" +
    "on<TT;>;Ljava/security/AccessControlContext;)TT;")]
				public static T DoAsPrivileged<T>(global::Javax.Security.Auth.Subject subject, global::Java.Security.IPrivilegedAction<T> privilegedAction, global::Java.Security.AccessControlContext accessControlContext) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// doAs
				/// </java-name>
				[Dot42.DexImport("doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;)Ljava/lan" +
    "g/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExce" +
    "ptionAction<TT;>;)TT;")]
				public static T DoAs<T>(global::Javax.Security.Auth.Subject subject, global::Java.Security.IPrivilegedExceptionAction<T> privilegedExceptionAction) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// doAsPrivileged
				/// </java-name>
				[Dot42.DexImport("doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;Ljava/secu" +
    "rity/AccessControlContext;)Ljava/lang/Object;", AccessFlags = 9, Signature = "<T:Ljava/lang/Object;>(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExce" +
    "ptionAction<TT;>;Ljava/security/AccessControlContext;)TT;")]
				public static T DoAsPrivileged<T>(global::Javax.Security.Auth.Subject subject, global::Java.Security.IPrivilegedExceptionAction<T> privilegedExceptionAction, global::Java.Security.AccessControlContext accessControlContext) /* MethodBuilder.Create */ 
				{
						return default(T);
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
				/// getPrincipals
				/// </java-name>
				[Dot42.DexImport("getPrincipals", "(Ljava/lang/Class;)Ljava/util/Set;", AccessFlags = 1, Signature = "<T::Ljava/security/Principal;>(Ljava/lang/Class<TT;>;)Ljava/util/Set<TT;>;")]
				public global::Java.Util.ISet<T> GetPrincipals<T>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<T>);
				}

				/// <java-name>
				/// getPrivateCredentials
				/// </java-name>
				[Dot42.DexImport("getPrivateCredentials", "(Ljava/lang/Class;)Ljava/util/Set;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Ljava/util/Set<TT;>;")]
				public global::Java.Util.ISet<T> GetPrivateCredentials<T>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<T>);
				}

				/// <java-name>
				/// getPublicCredentials
				/// </java-name>
				[Dot42.DexImport("getPublicCredentials", "(Ljava/lang/Class;)Ljava/util/Set;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Ljava/util/Set<TT;>;")]
				public global::Java.Util.ISet<T> GetPublicCredentials<T>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<T>);
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
				/// setReadOnly
				/// </java-name>
				[Dot42.DexImport("setReadOnly", "()V", AccessFlags = 1)]
				public void SetReadOnly() /* MethodBuilder.Create */ 
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
				/// getSubject
				/// </java-name>
				[Dot42.DexImport("getSubject", "(Ljava/security/AccessControlContext;)Ljavax/security/auth/Subject;", AccessFlags = 9)]
				public static global::Javax.Security.Auth.Subject GetSubject(global::Java.Security.AccessControlContext accessControlContext) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Auth.Subject);
				}

				/// <java-name>
				/// getPrincipals
				/// </java-name>
				public global::Java.Util.ISet<global::Java.Security.IPrincipal> Principals
				{
						[Dot42.DexImport("getPrincipals", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/security/Principal;>;")]
						get{ return default(global::Java.Util.ISet<global::Java.Security.IPrincipal>); }
				}

				/// <java-name>
				/// getPrivateCredentials
				/// </java-name>
				public global::Java.Util.ISet<object> PrivateCredentials
				{
						[Dot42.DexImport("getPrivateCredentials", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
						get{ return default(global::Java.Util.ISet<object>); }
				}

				/// <java-name>
				/// getPublicCredentials
				/// </java-name>
				public global::Java.Util.ISet<object> PublicCredentials
				{
						[Dot42.DexImport("getPublicCredentials", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
						get{ return default(global::Java.Util.ISet<object>); }
				}

				/// <java-name>
				/// isReadOnly
				/// </java-name>
				public bool IsReadOnly
				{
						[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// javax/security/auth/SubjectDomainCombiner
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/SubjectDomainCombiner", AccessFlags = 33)]
		public partial class SubjectDomainCombiner : global::Java.Security.IDomainCombiner
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljavax/security/auth/Subject;)V", AccessFlags = 1)]
				public SubjectDomainCombiner(global::Javax.Security.Auth.Subject subject) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// combine
				/// </java-name>
				[Dot42.DexImport("combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/securi" +
    "ty/ProtectionDomain;", AccessFlags = 1)]
				public virtual global::Java.Security.ProtectionDomain[] Combine(global::Java.Security.ProtectionDomain[] protectionDomain, global::Java.Security.ProtectionDomain[] protectionDomain1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.ProtectionDomain[]);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SubjectDomainCombiner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSubject
				/// </java-name>
				public virtual global::Javax.Security.Auth.Subject Subject
				{
						[Dot42.DexImport("getSubject", "()Ljavax/security/auth/Subject;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.Subject); }
				}

		}

}

