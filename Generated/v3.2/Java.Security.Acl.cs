// Copyright (C) 2014 dot42
//
// Original filename: Java.Security.Acl.cs
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
namespace Java.Security.Acl
{
		/// <summary>
		/// <para>The <b>Access Control List Entry</b> interface definition. </para><para>An <c> AclEntry </c> is a list of the Permissions that are granted (<b>positive</b>) or denied (<b>negative</b>) to a Principal. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/acl/AclEntry
		/// </java-name>
		[Dot42.DexImport("java/security/acl/AclEntry", AccessFlags = 1537)]
		public partial interface IAclEntry : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Set the principal for this ACL entry. </para><para>The principal for an ACL entry can only be set once.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> on success, <c> false </c> if there is a principal already set for this entry. </para>
				/// </returns>
				/// <java-name>
				/// setPrincipal
				/// </java-name>
				[Dot42.DexImport("setPrincipal", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool SetPrincipal(global::Java.Security.IPrincipal user) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the principal of this ACL entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the principal of this ACL entry, or null if none is set. </para>
				/// </returns>
				/// <java-name>
				/// getPrincipal
				/// </java-name>
				[Dot42.DexImport("getPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				global::Java.Security.IPrincipal GetPrincipal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets this ACL entry to be <b>negative</b>. </para><para>The permissions in this ACL entry will be denied to the principal associated with this entry. </para><para>Note: An ACL entry is <b>positive</b> by default and can only become <b>negative</b> by calling this method. </para>        
				/// </summary>
				/// <java-name>
				/// setNegativePermissions
				/// </java-name>
				[Dot42.DexImport("setNegativePermissions", "()V", AccessFlags = 1025)]
				void SetNegativePermissions() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this ACL entry is <b>negative</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if this ACL entry is negative, <c> false </c> if it's positive. </para>
				/// </returns>
				/// <java-name>
				/// isNegative
				/// </java-name>
				[Dot42.DexImport("isNegative", "()Z", AccessFlags = 1025)]
				bool IsNegative() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds the specified permission to this ACL entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified permission is added, <c> false </c> if the permission was already in this entry. </para>
				/// </returns>
				/// <java-name>
				/// addPermission
				/// </java-name>
				[Dot42.DexImport("addPermission", "(Ljava/security/acl/Permission;)Z", AccessFlags = 1025)]
				bool AddPermission(global::Java.Security.Acl.IPermission permission) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes the specified permission from this ACL entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the permission is removed, <c> false </c> if the permission was not in this entry. </para>
				/// </returns>
				/// <java-name>
				/// removePermission
				/// </java-name>
				[Dot42.DexImport("removePermission", "(Ljava/security/acl/Permission;)Z", AccessFlags = 1025)]
				bool RemovePermission(global::Java.Security.Acl.IPermission permission) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether the specified permission is in this ACL entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the permission is in this entry, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/acl/Permission;)Z", AccessFlags = 1025)]
				bool CheckPermission(global::Java.Security.Acl.IPermission permission) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the list of permissions of this ACL entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the list of permissions of this ACL entry, </para>
				/// </returns>
				/// <java-name>
				/// permissions
				/// </java-name>
				[Dot42.DexImport("permissions", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/security/acl/Permission;>;")]
				global::Java.Util.IEnumeration<global::Java.Security.Acl.IPermission> Permissions() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the string representation of this ACL entry.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this ACL entry. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Clones this ACL entry instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a copy of this entry. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A <c> Principal </c> that represents a group of principals.</para><para><para>Principal </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/acl/Group
		/// </java-name>
		[Dot42.DexImport("java/security/acl/Group", AccessFlags = 1537)]
		public partial interface IGroup : global::Java.Security.IPrincipal
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Adds a member to this group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the member was added, <c> false </c> if it was already a member. </para>
				/// </returns>
				/// <java-name>
				/// addMember
				/// </java-name>
				[Dot42.DexImport("addMember", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool AddMember(global::Java.Security.IPrincipal user) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes a member from this group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the member was removed, <c> false </c> if it was not a member. </para>
				/// </returns>
				/// <java-name>
				/// removeMember
				/// </java-name>
				[Dot42.DexImport("removeMember", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool RemoveMember(global::Java.Security.IPrincipal user) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether the specified principal is a member of this group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the principal is a member, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isMember
				/// </java-name>
				[Dot42.DexImport("isMember", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool IsMember(global::Java.Security.IPrincipal member) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the members of this group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the members of this group. </para>
				/// </returns>
				/// <java-name>
				/// members
				/// </java-name>
				[Dot42.DexImport("members", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<+Ljava/security/Principal;>;")]
				global::Java.Util.IEnumeration<global::Java.Security.IPrincipal> Members() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The exception that is thrown when an attempt is made to remove the the last <c> Owner </c> from an <c> Owner </c> .</para><para><para>Owner </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/acl/LastOwnerException
		/// </java-name>
		[Dot42.DexImport("java/security/acl/LastOwnerException", AccessFlags = 33)]
		public partial class LastOwnerException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> LastOwnerException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LastOwnerException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Legacy security code; do not use. </para>    
		/// </summary>
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
				bool Equals(object another) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The interface to manage owners of objects that require ownership.</para><para><para>Acl </para><simplesectsep></simplesectsep><para>Principal </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/acl/Owner
		/// </java-name>
		[Dot42.DexImport("java/security/acl/Owner", AccessFlags = 1537)]
		public partial interface IOwner
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Adds a principal to the list of owners.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the owner was added, <c> false </c> if it was already an owner. </para>
				/// </returns>
				/// <java-name>
				/// addOwner
				/// </java-name>
				[Dot42.DexImport("addOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool AddOwner(global::Java.Security.IPrincipal caller, global::Java.Security.IPrincipal owner) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes a principal from the list of owners.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the owner was removed, <c> false </c> if it was not an owner. </para>
				/// </returns>
				/// <java-name>
				/// deleteOwner
				/// </java-name>
				[Dot42.DexImport("deleteOwner", "(Ljava/security/Principal;Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool DeleteOwner(global::Java.Security.IPrincipal caller, global::Java.Security.IPrincipal owner) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether the specified principal is an owner of this object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified principal is an owner, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isOwner
				/// </java-name>
				[Dot42.DexImport("isOwner", "(Ljava/security/Principal;)Z", AccessFlags = 1025)]
				bool IsOwner(global::Java.Security.IPrincipal owner) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The exception, that is thrown when a reference to a non-existent <b>Access Control List</b> (ACL) is made. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/acl/AclNotFoundException
		/// </java-name>
		[Dot42.DexImport("java/security/acl/AclNotFoundException", AccessFlags = 33)]
		public partial class AclNotFoundException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> AclNotFoundException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AclNotFoundException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when an action that requires ownership is attempted by a principal that is not an owner of the object for which ownership is required.</para><para><para>Acl </para><simplesectsep></simplesectsep><para>Owner </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/acl/NotOwnerException
		/// </java-name>
		[Dot42.DexImport("java/security/acl/NotOwnerException", AccessFlags = 33)]
		public partial class NotOwnerException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> NotOwnerException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NotOwnerException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The <b>Access Control List</b> (<b>ACL</b>) interface definition. </para><para>An ACL is a set of AclEntry objects. </para><para>An <c> AclEntry </c> is a list of Permissions that are granted (<b>positive</b>) or denied (<b>negative</b>) to a Principal. </para><para>An <c> Acl </c> has a list of owners (Owner) which are principals as well <c> Principal </c> . Only those principals which are the <c> Acl </c> 's owners are allowed to modify the <c>   Acl </c> . </para><para>The <b>ACL</b> has to conform to the following rules: <ul><li><para>For each <c> Principal </c> there can be only one <b>positive</b> and one <b>negative</b> <c> AclEntry </c> . </para></li><li><para>If the two <c> AclEntry </c> 's (<b>positive</b> and <b>negative</b>) for a specific <c> Principal </c> grant and deny the same <c> Permission </c> to that <c> Principal </c> , then that <c> Permission </c> is treated as neither granted nor denied to that <c> Principal </c> . </para></li><li><para>Permissions associated with an individual <c> Principal </c> always override permissions of the group(s) to which the individual belongs. </para></li><li><para>If there is no <c> AclEntry </c> associated with a specific <c>   Principal </c> , then it is interpreted as an empty list of permissions. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/security/acl/Acl
		/// </java-name>
		[Dot42.DexImport("java/security/acl/Acl", AccessFlags = 1537)]
		public partial interface IAcl : global::Java.Security.Acl.IOwner
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Sets the name of this <b>ACL</b> instance.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/security/Principal;Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetName(global::Java.Security.IPrincipal caller, string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of this <b>ACL</b> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <b>ACL</b> instance. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Adds an <c> AclEntry </c> to this <b>ACL</b> instance. </para><para>If the <b>ACL</b> already has an <c> AclEntry </c> of the same type (<b> positive</b> or <b>negative</b>) and principal, then the new entry is not added.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the entry is added, <c> false </c> if there is already an entry of the same type for the same principal </para>
				/// </returns>
				/// <java-name>
				/// addEntry
				/// </java-name>
				[Dot42.DexImport("addEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z", AccessFlags = 1025)]
				bool AddEntry(global::Java.Security.IPrincipal caller, global::Java.Security.Acl.IAclEntry entry) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Removes an <c> AclEntry </c> from this <b>ACL</b> instance.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the entry is removed, <c> false </c> if the entry is not in this <b>ACL</b>. </para>
				/// </returns>
				/// <java-name>
				/// removeEntry
				/// </java-name>
				[Dot42.DexImport("removeEntry", "(Ljava/security/Principal;Ljava/security/acl/AclEntry;)Z", AccessFlags = 1025)]
				bool RemoveEntry(global::Java.Security.IPrincipal caller, global::Java.Security.Acl.IAclEntry entry) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the set of allowed permissions for the specified <c>       Principal </c> . </para><para>If the specified principal has no entry in this ACL, an empty set is returned. </para><para>The allowed permissions are collected according to the following rules: <ul><li><para>The two permission lists (<b>positive</b> and <b>negative</b>) of the principal's groups (Group) are collected. The positive (granted) permissions are the union of all group's positive permissions that the principal belongs to, the negative (denied) permissions are the union of all group's negative permissions that the principal belongs to. If a specific permission is in both the positive and the negative list, it is removed from both lists. </para></li><li><para>The individual permissions (<b>positive</b> and <b>negative</b>) of the principal override the group permissions. The positive individual permissions override the group's negative permissions and the negative individual permissions override the grpup's positive permissions. </para></li></ul></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the set of allowed permissions for the specified principal. </para>
				/// </returns>
				/// <java-name>
				/// getPermissions
				/// </java-name>
				[Dot42.DexImport("getPermissions", "(Ljava/security/Principal;)Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "(Ljava/security/Principal;)Ljava/util/Enumeration<Ljava/security/acl/Permission;>" +
    ";")]
				global::Java.Util.IEnumeration<global::Java.Security.Acl.IPermission> GetPermissions(global::Java.Security.IPrincipal user) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns an <c> Enumeration </c> of the <c> AclEntry </c> of this <b>ACL</b>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an <c> Enumeration </c> of the <c> AclEntry </c> of this <b>ACL</b>. </para>
				/// </returns>
				/// <java-name>
				/// entries
				/// </java-name>
				[Dot42.DexImport("entries", "()Ljava/util/Enumeration;", AccessFlags = 1025, Signature = "()Ljava/util/Enumeration<Ljava/security/acl/AclEntry;>;")]
				global::Java.Util.IEnumeration<global::Java.Security.Acl.IAclEntry> Entries() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether the specified principal is granted the specified permission. </para><para>The list of granted permissions is determined according to the rules specified by <c> getPermissions </c> .</para><para><para>getPermissions(Principal) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the principal is granted the permission, otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// checkPermission
				/// </java-name>
				[Dot42.DexImport("checkPermission", "(Ljava/security/Principal;Ljava/security/acl/Permission;)Z", AccessFlags = 1025)]
				bool CheckPermission(global::Java.Security.IPrincipal principal, global::Java.Security.Acl.IPermission permission) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the string representation of this ACL.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation of this ACL. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				string ToString() /* MethodBuilder.Create */ ;

		}

}


