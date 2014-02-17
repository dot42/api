// Copyright (C) 2014 dot42
//
// Original filename: Javax.Security.Auth.X500.cs
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
namespace Javax.Security.Auth.X500
{
		/// <summary>
		/// <para>Represents an X.500 principal, which holds the distinguished name of some network entity. An example of a distinguished name is <c> "O=SomeOrg,   OU=SomeOrgUnit, C=US" </c> . The class can be instantiated from a byte representation of an object identifier (OID), an ASN.1 DER-encoded version, or a simple string holding the distinguished name. The representations must follow either RFC 2253, RFC 1779, or RFC2459. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/auth/x500/X500Principal
		/// </java-name>
		[Dot42.DexImport("javax/security/auth/x500/X500Principal", AccessFlags = 49)]
		public sealed partial class X500Principal : global::Java.Io.ISerializable, global::Java.Security.IPrincipal
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Defines a constant for the canonical string format of distinguished names. </para>        
				/// </summary>
				/// <java-name>
				/// CANONICAL
				/// </java-name>
				[Dot42.DexImport("CANONICAL", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CANONICAL = "CANONICAL";
				/// <summary>
				/// <para>Defines a constant for the RFC 1779 string format of distinguished names. </para>        
				/// </summary>
				/// <java-name>
				/// RFC1779
				/// </java-name>
				[Dot42.DexImport("RFC1779", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RFC1779 = "RFC1779";
				/// <summary>
				/// <para>Defines a constant for the RFC 2253 string format of distinguished names. </para>        
				/// </summary>
				/// <java-name>
				/// RFC2253
				/// </java-name>
				[Dot42.DexImport("RFC2253", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RFC2253 = "RFC2253";
				/// <summary>
				/// <para>Creates a new X500Principal from a given ASN.1 DER encoding of a distinguished name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public X500Principal(sbyte[] @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new X500Principal from a given ASN.1 DER encoding of a distinguished name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public X500Principal(byte[] @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new X500Principal from a given ASN.1 DER encoding of a distinguished name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public X500Principal(global::Java.Io.InputStream @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new X500Principal from a given ASN.1 DER encoding of a distinguished name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public X500Principal(string @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares the specified object with this <c> Principal </c> for equality and returns <c> true </c> if the specified object is equal, <c> false </c> otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c>               Principal </c> , otherwise <c> false </c> . </para>
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
				/// <para>Returns an ASN.1 DER-encoded representation of the distinguished name contained in this X.500 principal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ASN.1 DER-encoded representation </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				/// <para>Returns an ASN.1 DER-encoded representation of the distinguished name contained in this X.500 principal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ASN.1 DER-encoded representation </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetEncoded() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <summary>
				/// <para>Returns a human-readable string representation of the distinguished name contained in this X.500 principal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns a string representation of the distinguished name contained in this X.500 principal. The format of the representation can be chosen. Valid arguments are RFC1779, RFC2253, and CANONICAL. The representations are specified in RFC 1779 and RFC 2253, respectively. The canonical form is based on RFC 2253, but adds some canonicalizing operations like removing leading and trailing whitespace, lower-casing the whole name, and bringing it into a normalized Unicode representation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation</para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetName(string format) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the hash code value for this <c> Principal </c> . Returns the same hash code for <c> Principal </c> s that are equal to each other as required by the general contract of Object#hashCode.</para><para><para>Object::equals(Object) </para><simplesectsep></simplesectsep><para>Principal::equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code value for this <c> Principal </c> . </para>
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
				/// <para>Returns a string containing a concise, human-readable description of this <c> Principal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation for this <c> Principal </c> . </para>
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
				internal X500Principal() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns an ASN.1 DER-encoded representation of the distinguished name contained in this X.500 principal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the ASN.1 DER-encoded representation </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

				/// <summary>
				/// <para>Returns a human-readable string representation of the distinguished name contained in this X.500 principal.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the string representation </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

		}

}


