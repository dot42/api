// Copyright (C) 2014 dot42
//
// Original filename: Javax.Security.Auth.cs
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
namespace Javax.Security.Auth
{
		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
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
				/// getSubject
				/// </java-name>
				[Dot42.DexImport("getSubject", "()Ljavax/security/auth/Subject;", AccessFlags = 1)]
				public virtual global::Javax.Security.Auth.Subject GetSubject() /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Auth.Subject);
				}

				/// <summary>
				/// <para>Returns a combination of the two provided <c> ProtectionDomain </c> arrays. Implementers can simply merge the two arrays into one, remove duplicates and perform other optimizations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a single <c> ProtectionDomain </c> array computed from the two provided arrays. </para>
				/// </returns>
				/// <java-name>
				/// combine
				/// </java-name>
				[Dot42.DexImport("combine", "([Ljava/security/ProtectionDomain;[Ljava/security/ProtectionDomain;)[Ljava/securi" +
    "ty/ProtectionDomain;", AccessFlags = 1)]
				public virtual global::Java.Security.ProtectionDomain[] Combine(global::Java.Security.ProtectionDomain[] current, global::Java.Security.ProtectionDomain[] assigned) /* MethodBuilder.Create */ 
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
				public global::Javax.Security.Auth.Subject Subject
				{
				[Dot42.DexImport("getSubject", "()Ljavax/security/auth/Subject;", AccessFlags = 1)]
						get{ return GetSubject(); }
				}

		}

		/// <summary>
		/// <para>The central class of the <c> javax.security.auth </c> package representing an authenticated user or entity (both referred to as "subject"). IT defines also the static methods that allow code to be run, and do modifications according to the subject's permissions. </para><para>A subject has the following features: <ul><li><para>A set of <c> Principal </c> objects specifying the identities bound to a <c> Subject </c> that distinguish it. </para></li><li><para>Credentials (public and private) such as certificates, keys, or authentication proofs such as tickets </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/Subject
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/Subject", AccessFlags = 49)]
		public sealed partial class Subject : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The default constructor initializing the sets of public and private credentials and principals with the empty set. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Subject() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The constructor for the subject, setting its public and private credentials and principals according to the arguments.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;)V", AccessFlags = 1, Signature = "(ZLjava/util/Set<+Ljava/security/Principal;>;Ljava/util/Set<*>;Ljava/util/Set<*>;" +
    ")V")]
				public Subject(bool readOnly, global::Java.Util.ISet<global::Java.Security.IPrincipal> subjPrincipals, global::Java.Util.ISet<object> pubCredentials, global::Java.Util.ISet<object> privCredentials) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// doAs
				/// </java-name>
				[Dot42.DexImport("doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;)Ljava/lang/Object;" +
    "", AccessFlags = 9)]
				public static object DoAs(global::Javax.Security.Auth.Subject subject, global::Java.Security.IPrivilegedAction<object> privilegedAction) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// doAsPrivileged
				/// </java-name>
				[Dot42.DexImport("doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;Ljava/security/Acce" +
    "ssControlContext;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object DoAsPrivileged(global::Javax.Security.Auth.Subject subject, global::Java.Security.IPrivilegedAction<object> privilegedAction, global::Java.Security.AccessControlContext accessControlContext) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// doAs
				/// </java-name>
				[Dot42.DexImport("doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;)Ljava/lan" +
    "g/Object;", AccessFlags = 9)]
				public static object DoAs(global::Javax.Security.Auth.Subject subject, global::Java.Security.IPrivilegedExceptionAction<object> privilegedExceptionAction) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// doAsPrivileged
				/// </java-name>
				[Dot42.DexImport("doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;Ljava/secu" +
    "rity/AccessControlContext;)Ljava/lang/Object;", AccessFlags = 9)]
				public static object DoAsPrivileged(global::Javax.Security.Auth.Subject subject, global::Java.Security.IPrivilegedExceptionAction<object> privilegedExceptionAction, global::Java.Security.AccessControlContext accessControlContext) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Checks two Subjects for equality. More specifically if the principals, public and private credentials are equal, equality for two <c>       Subjects </c> is implied.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified <c> Subject </c> is equal to this one. </para>
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
				/// <para>Returns this <c> Subject </c> 's Principal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Subject </c> 's Principal. </para>
				/// </returns>
				/// <java-name>
				/// getPrincipals
				/// </java-name>
				[Dot42.DexImport("getPrincipals", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/security/Principal;>;")]
				public global::Java.Util.ISet<global::Java.Security.IPrincipal> GetPrincipals() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<global::Java.Security.IPrincipal>);
				}

				/// <summary>
				/// <para>Returns this <c> Subject </c> 's Principal which is a subclass of the <c> Class </c> provided.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Subject </c> 's Principal. Modifications to the returned set of <c> Principal </c> s do not affect this <c>               Subject </c> 's set. </para>
				/// </returns>
				/// <java-name>
				/// getPrincipals
				/// </java-name>
				[Dot42.DexImport("getPrincipals", "(Ljava/lang/Class;)Ljava/util/Set;", AccessFlags = 1, Signature = "<T::Ljava/security/Principal;>(Ljava/lang/Class<TT;>;)Ljava/util/Set<TT;>;")]
				public global::Java.Util.ISet<T> GetPrincipals<T>(global::System.Type c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<T>);
				}

				/// <summary>
				/// <para>Returns the private credentials associated with this <c> Subject </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private credentials associated with this <c> Subject </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrivateCredentials
				/// </java-name>
				[Dot42.DexImport("getPrivateCredentials", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
				public global::Java.Util.ISet<object> GetPrivateCredentials() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<object>);
				}

				/// <summary>
				/// <para>Returns this <c> Subject </c> 's private credentials which are a subclass of the <c> Class </c> provided.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Subject </c> 's private credentials. Modifications to the returned set of credentials do not affect this <c> Subject </c> 's credentials. </para>
				/// </returns>
				/// <java-name>
				/// getPrivateCredentials
				/// </java-name>
				[Dot42.DexImport("getPrivateCredentials", "(Ljava/lang/Class;)Ljava/util/Set;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Ljava/util/Set<TT;>;")]
				public global::Java.Util.ISet<T> GetPrivateCredentials<T>(global::System.Type c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<T>);
				}

				/// <summary>
				/// <para>Returns the public credentials associated with this <c> Subject </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public credentials associated with this <c> Subject </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicCredentials
				/// </java-name>
				[Dot42.DexImport("getPublicCredentials", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
				public global::Java.Util.ISet<object> GetPublicCredentials() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<object>);
				}

				/// <summary>
				/// <para>Returns this <c> Subject </c> 's public credentials which are a subclass of the <c> Class </c> provided.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Subject </c> 's public credentials. Modifications to the returned set of credentials do not affect this <c> Subject </c> 's credentials. </para>
				/// </returns>
				/// <java-name>
				/// getPublicCredentials
				/// </java-name>
				[Dot42.DexImport("getPublicCredentials", "(Ljava/lang/Class;)Ljava/util/Set;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Ljava/util/Set<TT;>;")]
				public global::Java.Util.ISet<T> GetPublicCredentials<T>(global::System.Type c) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<T>);
				}

				/// <summary>
				/// <para>Returns a hash code of this <c> Subject </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a hash code of this <c> Subject </c> . </para>
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
				/// <para>Prevents from modifications being done to the credentials and Principal sets. After setting it to read-only this <c> Subject </c> can not be made writable again. The destroy method on the credentials still works though. </para>        
				/// </summary>
				/// <java-name>
				/// setReadOnly
				/// </java-name>
				[Dot42.DexImport("setReadOnly", "()V", AccessFlags = 1)]
				public void SetReadOnly() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether this <c> Subject </c> is read-only or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether this <c> Subject </c> is read-only or not. </para>
				/// </returns>
				/// <java-name>
				/// isReadOnly
				/// </java-name>
				[Dot42.DexImport("isReadOnly", "()Z", AccessFlags = 1)]
				public bool IsReadOnly() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a <c> String </c> representation of this <c> Subject </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a <c> String </c> representation of this <c> Subject </c> . </para>
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
				/// <para>Returns the <c> Subject </c> that was last associated with the <c>       context </c> provided as argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> Subject </c> that was last associated with the <c>               context </c> provided as argument. </para>
				/// </returns>
				/// <java-name>
				/// getSubject
				/// </java-name>
				[Dot42.DexImport("getSubject", "(Ljava/security/AccessControlContext;)Ljavax/security/auth/Subject;", AccessFlags = 9)]
				public static global::Javax.Security.Auth.Subject GetSubject(global::Java.Security.AccessControlContext context) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Auth.Subject);
				}

				/// <summary>
				/// <para>Returns this <c> Subject </c> 's Principal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>this <c> Subject </c> 's Principal. </para>
				/// </returns>
				/// <java-name>
				/// getPrincipals
				/// </java-name>
				public global::Java.Util.ISet<global::Java.Security.IPrincipal> Principals
				{
				[Dot42.DexImport("getPrincipals", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/security/Principal;>;")]
						get{ return GetPrincipals(); }
				}

				/// <summary>
				/// <para>Returns the private credentials associated with this <c> Subject </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the private credentials associated with this <c> Subject </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPrivateCredentials
				/// </java-name>
				public global::Java.Util.ISet<object> PrivateCredentials
				{
				[Dot42.DexImport("getPrivateCredentials", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
						get{ return GetPrivateCredentials(); }
				}

				/// <summary>
				/// <para>Returns the public credentials associated with this <c> Subject </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public credentials associated with this <c> Subject </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPublicCredentials
				/// </java-name>
				public global::Java.Util.ISet<object> PublicCredentials
				{
				[Dot42.DexImport("getPublicCredentials", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/Object;>;")]
						get{ return GetPublicCredentials(); }
				}

		}

		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/AuthPermission
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/AuthPermission", AccessFlags = 49)]
		public sealed partial class AuthPermission : global::Java.Security.BasicPermission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthPermission(string name) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthPermission(string name, string actions) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AuthPermission() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Signals that the Destroyable#destroy() method failed. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/DestroyFailedException
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/DestroyFailedException", AccessFlags = 33)]
		public partial class DestroyFailedException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates an exception of type <c> DestroyFailedException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DestroyFailedException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates an exception of type <c> DestroyFailedException </c> .</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DestroyFailedException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Allows for special treatment of sensitive information, when it comes to destroying or clearing of the data. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/Destroyable
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/Destroyable", AccessFlags = 1537)]
		public partial interface IDestroyable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Erases the sensitive information. Once an object is destroyed any calls to its methods will throw an <c> IllegalStateException </c> . If it does not succeed a DestroyFailedException is thrown.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// destroy
				/// </java-name>
				[Dot42.DexImport("destroy", "()V", AccessFlags = 1025)]
				void Destroy() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns <c> true </c> once an object has been safely destroyed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the object has been safely destroyed. </para>
				/// </returns>
				/// <java-name>
				/// isDestroyed
				/// </java-name>
				[Dot42.DexImport("isDestroyed", "()Z", AccessFlags = 1025)]
				bool IsDestroyed() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/PrivateCredentialPermission
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/PrivateCredentialPermission", AccessFlags = 49)]
		public sealed partial class PrivateCredentialPermission : global::Java.Security.Permission
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public PrivateCredentialPermission(string name, string action) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPrincipals
				/// </java-name>
				[Dot42.DexImport("getPrincipals", "()[[Ljava/lang/String;", AccessFlags = 1)]
				public string[][] GetPrincipals() /* MethodBuilder.Create */ 
				{
						return default(string[][]);
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
				/// getCredentialClass
				/// </java-name>
				[Dot42.DexImport("getCredentialClass", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCredentialClass() /* MethodBuilder.Create */ 
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// newPermissionCollection
				/// </java-name>
				[Dot42.DexImport("newPermissionCollection", "()Ljava/security/PermissionCollection;", AccessFlags = 1)]
				public override global::Java.Security.PermissionCollection NewPermissionCollection() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.PermissionCollection);
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
						get{ return GetPrincipals(); }
				}

				/// <java-name>
				/// getActions
				/// </java-name>
				public string Actions
				{
				[Dot42.DexImport("getActions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetActions(); }
				}

				/// <java-name>
				/// getCredentialClass
				/// </java-name>
				public string CredentialClass
				{
				[Dot42.DexImport("getCredentialClass", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCredentialClass(); }
				}

		}

}


