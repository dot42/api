// Copyright (C) 2014 dot42
//
// Original filename: Javax.Security.Cert.cs
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
namespace Javax.Security.Cert
{
		/// <summary>
		/// <para>Abstract class to represent identity certificates. It represents a way to verify the binding of a Principal and its public key. Examples are X.509, PGP, and SDSI. </para><para>Note: This package is provided only for compatibility reasons. It contains a simplified version of the java.security.cert package that was previously used by JSSE (Java SSL package). All applications that do not have to be compatible with older versions of JSSE (that is before Java SDK 1.5) should only use java.security.cert. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/cert/Certificate
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/Certificate", AccessFlags = 1057)]
		public abstract partial class Certificate
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> Certificate </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Certificate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compares the argument to this Certificate. If both have the same bytes they are assumed to be equal.</para><para><para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if <c> obj </c> is the same as this <c> Certificate </c> , <code>false</code> otherwise </para>
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
				/// <para>Returns an integer hash code for the receiver. Any two objects which return <code>true</code> when passed to <code>equals</code> must answer the same value for this method.</para><para><para>equals </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the receiver's hash </para>
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
				/// <para>Returns the encoded representation for this certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded representation for this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the encoded representation for this certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded representation for this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] GetEncoded() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Verifies that this certificate was signed with the given public key.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey key) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Verifies that this certificate was signed with the given public key. Uses the signature algorithm given by the provider.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey key, string sigProvider) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of the receiver.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation for the receiver. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the public key corresponding to this certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public key corresponding to this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getPublicKey
				/// </java-name>
				[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1025)]
				public abstract global::Java.Security.IPublicKey GetPublicKey() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the encoded representation for this certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the encoded representation for this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get{ return GetEncoded(); }
				}

				/// <summary>
				/// <para>Returns the public key corresponding to this certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the public key corresponding to this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getPublicKey
				/// </java-name>
				public global::Java.Security.IPublicKey PublicKey
				{
				[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1025)]
						get{ return GetPublicKey(); }
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when a <c> Certificate </c> has expired. </para><para>Note: This package is provided only for compatibility reasons. It contains a simplified version of the java.security.cert package that was previously used by JSSE (Java SSL package). All applications that do not have to be compatible with older versions of JSSE (that is before Java SDK 1.5) should only use java.security.cert. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/cert/CertificateExpiredException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateExpiredException", AccessFlags = 33)]
		public partial class CertificateExpiredException : global::Javax.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CertificateExpiredException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateExpiredException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> CertificateExpiredException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateExpiredException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when a <c> Certificate </c> is not yet valid. </para><para>Note: This package is provided only for compatibility reasons. It contains a simplified version of the java.security.cert package that was previously used by JSSE (Java SSL package). All applications that do not have to be compatible with older versions of JSSE (that is before Java SDK 1.5) should only use java.security.cert. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/cert/CertificateNotYetValidException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateNotYetValidException", AccessFlags = 33)]
		public partial class CertificateNotYetValidException : global::Javax.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CertificateNotYetValidException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateNotYetValidException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> CertificateNotYetValidException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateNotYetValidException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when a <c> Certificate </c> can not be parsed. </para><para>Note: This package is provided only for compatibility reasons. It contains a simplified version of the java.security.cert package that was previously used by JSSE (Java SSL package). All applications that do not have to be compatible with older versions of JSSE (that is before Java SDK 1.5) should only use java.security.cert. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/cert/CertificateParsingException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateParsingException", AccessFlags = 33)]
		public partial class CertificateParsingException : global::Javax.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CertificateParsingException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateParsingException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> CertificateParsingException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateParsingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Abstract base class for X.509 certificates. </para><para>This represents a standard way for accessing the attributes of X.509 v1 certificates. </para><para>Note: This package is provided only for compatibility reasons. It contains a simplified version of the java.security.cert package that was previously used by JSSE (Java SSL package). All applications that do not have to be compatible with older versions of JSSE (that is before Java SDK 1.5) should only use java.security.cert. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/cert/X509Certificate
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/X509Certificate", AccessFlags = 1057)]
		public abstract partial class X509Certificate : global::Javax.Security.Cert.Certificate
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> X509Certificate </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public X509Certificate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> X509Certificate </c> and initializes it from the specified input stream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificate initialized from the specified input stream </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;", AccessFlags = 25)]
				public static global::Javax.Security.Cert.X509Certificate GetInstance(global::Java.Io.InputStream inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Cert.X509Certificate);
				}

				/// <summary>
				/// <para>Creates a new <c> X509Certificate </c> and initializes it from the specified input stream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificate initialized from the specified input stream </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "([B)Ljavax/security/cert/X509Certificate;", AccessFlags = 25)]
				public static global::Javax.Security.Cert.X509Certificate GetInstance(sbyte[] inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Cert.X509Certificate);
				}

				/// <summary>
				/// <para>Creates a new <c> X509Certificate </c> and initializes it from the specified input stream.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the certificate initialized from the specified input stream </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "([B)Ljavax/security/cert/X509Certificate;", AccessFlags = 25, IgnoreFromJava = true)]
				public static global::Javax.Security.Cert.X509Certificate GetInstance(byte[] inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Cert.X509Certificate);
				}

				/// <summary>
				/// <para>Checks whether the certificate is currently valid. </para><para>The validity defined in ASN.1:</para><para><pre>
				///        validity             Validity
				/// 
				///        Validity ::= SEQUENCE {
				///             notBefore       CertificateValidityDate,
				///             notAfter        CertificateValidityDate }
				/// 
				///        CertificateValidityDate ::= CHOICE {
				///             utcTime         UTCTime,
				///             generalTime     GeneralizedTime }
				///        </pre></para><para></para>        
				/// </summary>
				/// <java-name>
				/// checkValidity
				/// </java-name>
				[Dot42.DexImport("checkValidity", "()V", AccessFlags = 1025)]
				public abstract void CheckValidity() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether the certificate is valid at the specified date.</para><para><para>checkValidity() </para></para>        
				/// </summary>
				/// <java-name>
				/// checkValidity
				/// </java-name>
				[Dot42.DexImport("checkValidity", "(Ljava/util/Date;)V", AccessFlags = 1025)]
				public abstract void CheckValidity(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the certificates <c> version </c> (version number). </para><para>The version defined is ASN.1:</para><para><pre>
				///        Version ::=  INTEGER  {  v1(0), v2(1), v3(2)  }
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the version number. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
				public abstract int GetVersion() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the <c> serialNumber </c> of the certificate. </para><para>The ASN.1 definition of <c> serialNumber </c> :</para><para><pre>
				///        CertificateSerialNumber  ::=  INTEGER
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the serial number. </para>
				/// </returns>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
				public abstract global::Java.Math.BigInteger GetSerialNumber() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the <c> issuer </c> (issuer distinguished name) as an implementation specific <c> Principal </c> object. </para><para>The ASN.1 definition of <c> issuer </c> :</para><para><pre>
				///         issuer      Name
				/// 
				///         Name ::= CHOICE {
				///             RDNSequence }
				/// 
				///           RDNSequence ::= SEQUENCE OF RelativeDistinguishedName
				/// 
				///           RelativeDistinguishedName ::= SET OF AttributeTypeAndValue
				/// 
				///           AttributeTypeAndValue ::= SEQUENCE {
				///             type     AttributeType,
				///             value    AttributeValue }
				/// 
				///           AttributeType ::= OBJECT IDENTIFIER
				/// 
				///           AttributeValue ::= ANY DEFINED BY AttributeType
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> issuer </c> as an implementation specific <c>               Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getIssuerDN
				/// </java-name>
				[Dot42.DexImport("getIssuerDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
				public abstract global::Java.Security.IPrincipal GetIssuerDN() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the <c> subject </c> (subject distinguished name) as an implementation specific <c> Principal </c> object. </para><para>The ASN.1 definition of <c> subject </c> :</para><para><pre>
				///        subject      Name
				/// 
				///         Name ::= CHOICE {
				///             RDNSequence }
				/// 
				///           RDNSequence ::= SEQUENCE OF RelativeDistinguishedName
				/// 
				///           RelativeDistinguishedName ::= SET OF AttributeTypeAndValue
				/// 
				///           AttributeTypeAndValue ::= SEQUENCE {
				///             type     AttributeType,
				///             value    AttributeValue }
				/// 
				///           AttributeType ::= OBJECT IDENTIFIER
				/// 
				///           AttributeValue ::= ANY DEFINED BY AttributeType
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> subject </c> (subject distinguished name). </para>
				/// </returns>
				/// <java-name>
				/// getSubjectDN
				/// </java-name>
				[Dot42.DexImport("getSubjectDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
				public abstract global::Java.Security.IPrincipal GetSubjectDN() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the <c> notBefore </c> date from the validity period of the certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the start of the validity period. </para>
				/// </returns>
				/// <java-name>
				/// getNotBefore
				/// </java-name>
				[Dot42.DexImport("getNotBefore", "()Ljava/util/Date;", AccessFlags = 1025)]
				public abstract global::Java.Util.Date GetNotBefore() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the <c> notAfter </c> date of the validity period of the certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the end of the validity period. </para>
				/// </returns>
				/// <java-name>
				/// getNotAfter
				/// </java-name>
				[Dot42.DexImport("getNotAfter", "()Ljava/util/Date;", AccessFlags = 1025)]
				public abstract global::Java.Util.Date GetNotAfter() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the name of the algorithm for the certificate signature.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the signature algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgName
				/// </java-name>
				[Dot42.DexImport("getSigAlgName", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetSigAlgName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the OID of the signature algorithm from the certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the OID of the signature algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgOID
				/// </java-name>
				[Dot42.DexImport("getSigAlgOID", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetSigAlgOID() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the parameters of the signature algorithm in DER-encoded format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters of the signature algorithm, or null if none are used. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetSigAlgParams() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the parameters of the signature algorithm in DER-encoded format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters of the signature algorithm, or null if none are used. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] GetSigAlgParams() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the certificates <c> version </c> (version number). </para><para>The version defined is ASN.1:</para><para><pre>
				///        Version ::=  INTEGER  {  v1(0), v2(1), v3(2)  }
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the version number. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns the <c> serialNumber </c> of the certificate. </para><para>The ASN.1 definition of <c> serialNumber </c> :</para><para><pre>
				///        CertificateSerialNumber  ::=  INTEGER
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the serial number. </para>
				/// </returns>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public global::Java.Math.BigInteger SerialNumber
				{
				[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get{ return GetSerialNumber(); }
				}

				/// <summary>
				/// <para>Returns the <c> issuer </c> (issuer distinguished name) as an implementation specific <c> Principal </c> object. </para><para>The ASN.1 definition of <c> issuer </c> :</para><para><pre>
				///         issuer      Name
				/// 
				///         Name ::= CHOICE {
				///             RDNSequence }
				/// 
				///           RDNSequence ::= SEQUENCE OF RelativeDistinguishedName
				/// 
				///           RelativeDistinguishedName ::= SET OF AttributeTypeAndValue
				/// 
				///           AttributeTypeAndValue ::= SEQUENCE {
				///             type     AttributeType,
				///             value    AttributeValue }
				/// 
				///           AttributeType ::= OBJECT IDENTIFIER
				/// 
				///           AttributeValue ::= ANY DEFINED BY AttributeType
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> issuer </c> as an implementation specific <c>               Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getIssuerDN
				/// </java-name>
				public global::Java.Security.IPrincipal IssuerDN
				{
				[Dot42.DexImport("getIssuerDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get{ return GetIssuerDN(); }
				}

				/// <summary>
				/// <para>Returns the <c> subject </c> (subject distinguished name) as an implementation specific <c> Principal </c> object. </para><para>The ASN.1 definition of <c> subject </c> :</para><para><pre>
				///        subject      Name
				/// 
				///         Name ::= CHOICE {
				///             RDNSequence }
				/// 
				///           RDNSequence ::= SEQUENCE OF RelativeDistinguishedName
				/// 
				///           RelativeDistinguishedName ::= SET OF AttributeTypeAndValue
				/// 
				///           AttributeTypeAndValue ::= SEQUENCE {
				///             type     AttributeType,
				///             value    AttributeValue }
				/// 
				///           AttributeType ::= OBJECT IDENTIFIER
				/// 
				///           AttributeValue ::= ANY DEFINED BY AttributeType
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the <c> subject </c> (subject distinguished name). </para>
				/// </returns>
				/// <java-name>
				/// getSubjectDN
				/// </java-name>
				public global::Java.Security.IPrincipal SubjectDN
				{
				[Dot42.DexImport("getSubjectDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get{ return GetSubjectDN(); }
				}

				/// <summary>
				/// <para>Returns the <c> notBefore </c> date from the validity period of the certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the start of the validity period. </para>
				/// </returns>
				/// <java-name>
				/// getNotBefore
				/// </java-name>
				public global::Java.Util.Date NotBefore
				{
				[Dot42.DexImport("getNotBefore", "()Ljava/util/Date;", AccessFlags = 1025)]
						get{ return GetNotBefore(); }
				}

				/// <summary>
				/// <para>Returns the <c> notAfter </c> date of the validity period of the certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the end of the validity period. </para>
				/// </returns>
				/// <java-name>
				/// getNotAfter
				/// </java-name>
				public global::Java.Util.Date NotAfter
				{
				[Dot42.DexImport("getNotAfter", "()Ljava/util/Date;", AccessFlags = 1025)]
						get{ return GetNotAfter(); }
				}

				/// <summary>
				/// <para>Returns the name of the algorithm for the certificate signature.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the signature algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgName
				/// </java-name>
				public string SigAlgName
				{
				[Dot42.DexImport("getSigAlgName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSigAlgName(); }
				}

				/// <summary>
				/// <para>Returns the OID of the signature algorithm from the certificate.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the OID of the signature algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgOID
				/// </java-name>
				public string SigAlgOID
				{
				[Dot42.DexImport("getSigAlgOID", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSigAlgOID(); }
				}

				/// <summary>
				/// <para>Returns the parameters of the signature algorithm in DER-encoded format.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameters of the signature algorithm, or null if none are used. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				public byte[] SigAlgParams
				{
				[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get{ return GetSigAlgParams(); }
				}

		}

		/// <summary>
		/// <para>The base class for all <c> Certificate </c> related exceptions. </para><para>Note: This package is provided only for compatibility reasons. It contains a simplified version of the java.security.cert package that was previously used by JSSE (Java SSL package). All applications that do not have to be compatible with older versions of JSSE (that is before Java SDK 1.5) should only use java.security.cert. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/cert/CertificateException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateException", AccessFlags = 33)]
		public partial class CertificateException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CertificateException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> CertificateException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>The exception that is thrown when an error occurs while a <c> Certificate </c> is being encoded. </para><para>Note: This package is provided only for compatibility reasons. It contains a simplified version of the java.security.cert package that was previously used by JSSE (Java SSL package). All applications that do not have to be compatible with older versions of JSSE (that is before Java SDK 1.5) should only use java.security.cert. </para>    
		/// </summary>
		/// <java-name>
		/// javax/security/cert/CertificateEncodingException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateEncodingException", AccessFlags = 33)]
		public partial class CertificateEncodingException : global::Javax.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new <c> CertificateEncodingException </c> with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateEncodingException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new <c> CertificateEncodingException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateEncodingException() /* MethodBuilder.Create */ 
				{
				}

		}

}


