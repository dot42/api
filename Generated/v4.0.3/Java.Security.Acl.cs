#pragma warning disable 1717
namespace Java.Security.Acl
{
		/// <java-name>
		/// java/security/acl/AclNotFoundException
		/// </java-name>
		[Dot42.DexImport("java/security/acl/AclNotFoundException", AccessFlags = 33)]
		public partial class AclNotFoundException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AclNotFoundException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/acl/Acl
		/// </java-name>
		[Dot42.DexImport("java/security/acl/Acl", AccessFlags = 1537)]
		public partial interface IAcl : global::Java.Security.Acl.IOwner
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/security/Principal;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetName(global::Java.Security.IPrincipal principal, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addEntry
				/// </java-name>
				[Dot42.DexImport("addEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z", AccessFlags = 1025)]
				bool AddEntry(global::Java.Security.IPrincipal principal, global::Java.Security.Acl.IAclEntry aclEntry) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeEntry
				/// </java-name>
				[Dot42.DexImport("removeEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z", AccessFlags = 1025)]
				bool RemoveEntry(global::Java.Security.IPrincipal principal, global::Java.Security.Acl.IAclEntry aclEntry) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/Principal;)Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "(Ljava/security/Principal;)Ljava/util/Enumeration<Ljava/security/acl/Permission;>" +
    ";")]
				global::Java.Util.IEnumeration<global::Java.Security.Acl.IPermission> GetPermissions(global::Java.Security.IPrincipal principal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// entries
				/// </java-name>
				[Dot42.DexImport("entries", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/security/acl/AclEntry;>;")]
				global::Java.Util.IEnumeration<global::Java.Security.Acl.IAclEntry> Entries() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/Principal;Ljava/security/acl/Permission;)Z", AccessFlags = 1025)]
				bool CheckPermission(global::Java.Security.IPrincipal principal, global::Java.Security.Acl.IPermission permission) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/acl/AclEntry
		/// </java-name>
		[Dot42.DexImport("java/security/acl/AclEntry", AccessFlags = 1537)]
		public partial interface IAclEntry : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setPrincipal
				/// </java-name>
				[Dot42.DexImport("setPrincipal", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool SetPrincipal(global::Java.Security.IPrincipal principal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNegativePermissions
				/// </java-name>
				[Dot42.DexImport("setNegativePermissions", "()V", AccessFlags = 1025)]
				void SetNegativePermissions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addPermission
				/// </java-name>
				[Dot42.DexImport("addPermission", "(Ljava/security/acl/Permission;)Z", AccessFlags = 1025)]
				bool AddPermission(global::Java.Security.Acl.IPermission permission) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removePermission
				/// </java-name>
				[Dot42.DexImport("removePermission", "(Ljava/security/acl/Permission;)Z", AccessFlags = 1025)]
				bool RemovePermission(global::Java.Security.Acl.IPermission permission) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/acl/Permission;)Z", AccessFlags = 1025)]
				bool CheckPermission(global::Java.Security.Acl.IPermission permission) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// permissions
				/// </java-name>
				[Dot42.DexImport("permissions", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/security/acl/Permission;>;")]
				global::Java.Util.IEnumeration<global::Java.Security.Acl.IPermission> Permissions() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPrincipal
				/// </java-name>
				global::Java.Security.IPrincipal Principal
				{
						[Dot42.DexImport("getPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isNegative
				/// </java-name>
				bool IsNegative
				{
						[Dot42.DexImport("isNegative", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/acl/Group
		/// </java-name>
		[Dot42.DexImport("java/security/acl/Group", AccessFlags = 1537)]
		public partial interface IGroup : global::Java.Security.IPrincipal
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addMember
				/// </java-name>
				[Dot42.DexImport("addMember", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool AddMember(global::Java.Security.IPrincipal principal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeMember
				/// </java-name>
				[Dot42.DexImport("removeMember", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool RemoveMember(global::Java.Security.IPrincipal principal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isMember
				/// </java-name>
				[Dot42.DexImport("isMember", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool IsMember(global::Java.Security.IPrincipal principal) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// members
				/// </java-name>
				[Dot42.DexImport("members", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<+Ljava/security/Principal;>;")]
				global::Java.Util.IEnumeration<global::Java.Security.IPrincipal> Members() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/acl/Owner
		/// </java-name>
		[Dot42.DexImport("java/security/acl/Owner", AccessFlags = 1537)]
		public partial interface IOwner
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addOwner
				/// </java-name>
				[Dot42.DexImport("addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool AddOwner(global::Java.Security.IPrincipal principal, global::Java.Security.IPrincipal principal1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deleteOwner
				/// </java-name>
				[Dot42.DexImport("deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool DeleteOwner(global::Java.Security.IPrincipal principal, global::Java.Security.IPrincipal principal1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isOwner
				/// </java-name>
				[Dot42.DexImport("isOwner", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool IsOwner(global::Java.Security.IPrincipal principal) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/acl/Permission
		/// </java-name>
		[Dot42.DexImport("java/security/acl/Permission", AccessFlags = 1537)]
		public partial interface IPermission
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				bool Equals(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/acl/LastOwnerException
		/// </java-name>
		[Dot42.DexImport("java/security/acl/LastOwnerException", AccessFlags = 33)]
		public partial class LastOwnerException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LastOwnerException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/acl/NotOwnerException
		/// </java-name>
		[Dot42.DexImport("java/security/acl/NotOwnerException", AccessFlags = 33)]
		public partial class NotOwnerException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotOwnerException() /* MethodBuilder.Create */ 
				{
				}

		}

}

