#pragma warning disable 1717
namespace Java.Security.Cert
{
		/// <summary>
		///  <para>Abstract class to represent identity certificates. It represents a way to verify the binding of a Principal and its public key. Examples are X.509, PGP, and SDSI. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/Certificate
		/// </java-name>
		[Dot42.DexImport("java/security/cert/Certificate", AccessFlags = 1057)]
		public abstract partial class Certificate : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>Certificate </c> with the specified type.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Certificate(string type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compares the argument to the certificate, and returns <c>true </c> if they represent the  <b>same</b> object using a class specific comparison. The implementation in Object returns <c>true </c> only if the argument is the exact same object as the callee (==).</para> <para> <para>hashCode </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the object is the same as this object, <c>false </c> if it is different from this object. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns an integer hash code for the certificate. Any two objects which return <c>true </c> when passed to <c>equals </c> must return the same value for this method.</para> <para> <para>equals </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate's hash </para>
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
				///  <para>Verifies that this certificate was signed with the given public key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey key) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Verifies that this certificate was signed with the given public key. It Uses the signature algorithm given by the provider.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey key, string sigProvider) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns a string containing a concise, human-readable description of the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a printable representation for the certificate. </para>
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
				///  <para>Returns an alternate object to be serialized.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the object to serialize. </para>
				/// </returns>
				/// <java-name>
				/// writeReplace
				/// </java-name>
				[Dot42.DexImport("writeReplace", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object WriteReplace() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Certificate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the certificate type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate type. </para>
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
				///  <para>Returns the encoded representation for this certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded representation for this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the public key corresponding to this certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the public key corresponding to this certificate. </para>
				/// </returns>
				/// <java-name>
				/// getPublicKey
				/// </java-name>
				public abstract global::Java.Security.IPublicKey PublicKey
				{
						[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>The alternate <c>Serializable </c> class to be used for serialization and deserialization of <c>Certificate </c> objects. </para>    
				/// </summary>
				/// <java-name>
				/// java/security/cert/Certificate$CertificateRep
				/// </java-name>
				[Dot42.DexImport("java/security/cert/Certificate$CertificateRep", AccessFlags = 12)]
				protected internal partial class CertificateRep : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 4, IgnoreFromJava = true)]
						protected internal CertificateRep(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 4)]
						protected internal CertificateRep(string @string, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Deserializes a <c>Certificate </c> from a serialized <c>CertificateRep </c> object.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the deserialized <c>Certificate </c> . </para>
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
						protected internal CertificateRep() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>The exception that is thrown when an error occurs while a <c>Certificate </c> is being encoded. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertificateEncodingException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateEncodingException", AccessFlags = 33)]
		public partial class CertificateEncodingException : global::Java.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateEncodingException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateEncodingException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateEncodingException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateEncodingException </c> with the specified message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateEncodingException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateEncodingException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The base class for all <c>Certificate </c> related exceptions. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertificateException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateException", AccessFlags = 33)]
		public partial class CertificateException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateException </c> with the specified message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The exception that is thrown when a <c>Certificate </c> has expired. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertificateExpiredException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateExpiredException", AccessFlags = 33)]
		public partial class CertificateExpiredException : global::Java.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertificateExpiredException </c> with the specified message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateExpiredException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateExpiredException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateExpiredException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This class implements the functionality of a certificate factory algorithm, relying on parsing a stream of bytes. </para> <para>It defines methods for parsing certificate chains (certificate paths) and  <b>Certificate Revocation Lists</b> (CRLs). </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertificateFactory
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateFactory", AccessFlags = 33)]
		public partial class CertificateFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertificateFactory </c> instance.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertificateFactorySpi;Ljava/security/Provider;Ljava/lang/Str" +
    "ing;)V", AccessFlags = 4)]
				protected internal CertificateFactory(global::Java.Security.Cert.CertificateFactorySpi certFacSpi, global::Java.Security.Provider provider, string type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateFactory </c> instance that provides the requested certificate type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>CertificateFactory </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;", AccessFlags = 25)]
				public static global::Java.Security.Cert.CertificateFactory GetInstance(string type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertificateFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertificateFactory;", AccessFlags = 25)]
				public static global::Java.Security.Cert.CertificateFactory GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertificateFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertificateFactor" +
    "y;", AccessFlags = 25)]
				public static global::Java.Security.Cert.CertificateFactory GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertificateFactory);
				}

				/// <summary>
				///  <para>Generates and initializes a <c>Certificate </c> from the provided input stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an initialized Certificate. </para>
				/// </returns>
				/// <java-name>
				/// generateCertificate
				/// </java-name>
				[Dot42.DexImport("generateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", AccessFlags = 17)]
				public global::Java.Security.Cert.Certificate GenerateCertificate(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate);
				}

				/// <summary>
				///  <para>Generates a <c>CertPath </c> (a certificate chain) from the provided  <c>InputStream </c> . The default encoding scheme is applied.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>CertPath </c> initialized from the provided data. </para>
				/// </returns>
				/// <java-name>
				/// generateCertPath
				/// </java-name>
				[Dot42.DexImport("generateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", AccessFlags = 17)]
				public global::Java.Security.Cert.CertPath GenerateCertPath(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <summary>
				///  <para>Generates a <c>CertPath </c> (a certificate chain) from the given  <c>inputStream </c> , assuming the given <c>encoding </c> from getCertPathEncodings().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// generateCertPath
				/// </java-name>
				[Dot42.DexImport("generateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;", AccessFlags = 17)]
				public global::Java.Security.Cert.CertPath GenerateCertPath(global::Java.IO.InputStream inputStream, string encoding) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <summary>
				///  <para>Generates a <c>CertPath </c> (a certificate chain) from the provided  <c>InputStream </c> . The default encoding scheme is applied.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>CertPath </c> initialized from the provided data. </para>
				/// </returns>
				/// <java-name>
				/// generateCertPath
				/// </java-name>
				[Dot42.DexImport("generateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", AccessFlags = 17, Signature = "(Ljava/util/List<+Ljava/security/cert/Certificate;>;)Ljava/security/cert/CertPath" +
    ";")]
				public global::Java.Security.Cert.CertPath GenerateCertPath(global::Java.Util.IList<global::Java.Security.Cert.Certificate> inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <summary>
				///  <para>Generates and initializes a collection of (unrelated) certificates from the provided input stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an initialized collection of certificates. </para>
				/// </returns>
				/// <java-name>
				/// generateCertificates
				/// </java-name>
				[Dot42.DexImport("generateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", AccessFlags = 17, Signature = "(Ljava/io/InputStream;)Ljava/util/Collection<+Ljava/security/cert/Certificate;>;")]
				public global::Java.Util.ICollection<global::Java.Security.Cert.Certificate> GenerateCertificates(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Java.Security.Cert.Certificate>);
				}

				/// <summary>
				///  <para>Generates and initializes a  <b>Certificate Revocation List</b> (CRL) from the provided input stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an initialized CRL. </para>
				/// </returns>
				/// <java-name>
				/// generateCRL
				/// </java-name>
				[Dot42.DexImport("generateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", AccessFlags = 17)]
				public global::Java.Security.Cert.CRL GenerateCRL(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CRL);
				}

				/// <summary>
				///  <para>Generates and initializes a collection of  <b>Certificate Revocation List</b> (CRL) from the provided input stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an initialized collection of CRLs. </para>
				/// </returns>
				/// <java-name>
				/// generateCRLs
				/// </java-name>
				[Dot42.DexImport("generateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", AccessFlags = 17, Signature = "(Ljava/io/InputStream;)Ljava/util/Collection<+Ljava/security/cert/CRL;>;")]
				public global::Java.Util.ICollection<global::Java.Security.Cert.CRL> GenerateCRLs(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Java.Security.Cert.CRL>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CertificateFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the <c>Provider </c> of the certificate factory represented by the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider of this certificate factory. </para>
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
				///  <para>Returns the Certificate type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>type of certificate being used. </para>
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
				///  <para>Returns an <c>Iterator </c> over the supported <c>CertPath </c> encodings (as Strings). The first element is the default encoding scheme to apply.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over supported CertPath encodings (as Strings). </para>
				/// </returns>
				/// <java-name>
				/// getCertPathEncodings
				/// </java-name>
				public global::Java.Util.IIterator<string> CertPathEncodings
				{
						[Dot42.DexImport("getCertPathEncodings", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IIterator<string>); }
				}

		}

		/// <summary>
		///  <para>This class defines the  <b>Service Provider Interface</b> ( <b>SPI</b>) for the  <c>CertificateFactory </c> class. This SPI must be implemented for each certificate type a security provider wishes to support. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertificateFactorySpi
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateFactorySpi", AccessFlags = 1057)]
		public abstract partial class CertificateFactorySpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a new instance of this class. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generates and initializes a <c>Certificate </c> from the provided input stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an initialized certificate. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateCertificate
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate EngineGenerateCertificate(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and initializes a collection of certificates from the provided input stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a collection of certificates. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateCertificates
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", AccessFlags = 1025, Signature = "(Ljava/io/InputStream;)Ljava/util/Collection<+Ljava/security/cert/Certificate;>;")]
				public abstract global::Java.Util.ICollection<global::Java.Security.Cert.Certificate> EngineGenerateCertificates(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and initializes a  <b>Certificate Revocation List</b> (CRL) from the provided input stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an CRL instance. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateCRL
				/// </java-name>
				[Dot42.DexImport("engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.CRL EngineGenerateCRL(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates and initializes a collection of  <b>Certificate Revocation List</b> (CRL) from the provided input stream.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a collection of CRLs. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateCRLs
				/// </java-name>
				[Dot42.DexImport("engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", AccessFlags = 1025, Signature = "(Ljava/io/InputStream;)Ljava/util/Collection<+Ljava/security/cert/CRL;>;")]
				public abstract global::Java.Util.ICollection<global::Java.Security.Cert.CRL> EngineGenerateCRLs(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Generates a <c>CertPath </c> from the provided <c>InputStream </c> . The default encoding scheme is applied.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>CertPath </c> initialized from the provided data. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateCertPath
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.CertPath EngineGenerateCertPath(global::Java.IO.InputStream inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <summary>
				///  <para>Generates a <c>CertPath </c> (a certificate chain) from the given  <c>inputStream </c> , assuming the given <c>encoding </c> from engineGetCertPathEncodings().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// engineGenerateCertPath
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.CertPath EngineGenerateCertPath(global::Java.IO.InputStream inStream, string encoding) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <summary>
				///  <para>Generates a <c>CertPath </c> from the provided <c>InputStream </c> . The default encoding scheme is applied.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a <c>CertPath </c> initialized from the provided data. </para>
				/// </returns>
				/// <java-name>
				/// engineGenerateCertPath
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", AccessFlags = 1, Signature = "(Ljava/util/List<+Ljava/security/cert/Certificate;>;)Ljava/security/cert/CertPath" +
    ";")]
				public virtual global::Java.Security.Cert.CertPath EngineGenerateCertPath(global::Java.Util.IList<global::Java.Security.Cert.Certificate> inStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <summary>
				///  <para>Returns an <c>Iterator </c> over the supported <c>CertPath </c> encodings (as Strings). The first element is the default encoding.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an iterator over supported <c>CertPath </c> encodings (as Strings). </para>
				/// </returns>
				/// <java-name>
				/// engineGetCertPathEncodings
				/// </java-name>
				[Dot42.DexImport("engineGetCertPathEncodings", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IIterator<string> EngineGetCertPathEncodings() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

		}

		/// <summary>
		///  <para>The exception that is thrown when a <c>Certificate </c> is not yet valid or will not yet be valid on a specified date. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertificateNotYetValidException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateNotYetValidException", AccessFlags = 33)]
		public partial class CertificateNotYetValidException : global::Java.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertificateNotYetValidException </c> with the specified message.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateNotYetValidException(string msg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateNotYetValidException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateNotYetValidException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The exception that is thrown when a <c>Certificate </c> can not be parsed. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertificateParsingException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateParsingException", AccessFlags = 33)]
		public partial class CertificateParsingException : global::Java.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateParsingException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateParsingException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateParsingException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertificateParsingException </c> with the specified message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateParsingException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateParsingException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>An immutable certificate path that can be validated. All certificates in the path are of the same type (i.e., X509). </para> <para>A <c>CertPath </c> can be represented as a byte array in at least one supported encoding scheme (i.e. PkiPath or PKCS7) when serialized. </para> <para>When a <c>List </c> of the certificates is obtained it must be immutable. </para> <para>A <c>CertPath </c> must be thread-safe without requiring coordinated access.</para> <para> <para>Certificate </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPath
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPath", AccessFlags = 1057)]
		public abstract partial class CertPath : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertPath </c> instance for the specified certificate type.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal CertPath(string type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns <c>true </c> if <c>Certificate </c> s in the list are the same type and the lists are equal (and by implication the certificates contained within are the same).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the object are equal, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Overrides <c>Object.hashCode() </c> . The function is defined as follows:  <pre>
				///  hashCode = 31 * path.getType().hashCode() +
				/// 
				/// path.getCertificates().hashCode(); 
				/// 
				///  
				/// </pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hash code for this instance. </para>
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
				///  <para>Returns a <c>String </c> representation of this <c>CertPath </c> instance. It is the result of calling <c>toString </c> on all <c>Certificate </c> s in the <c>List </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this instance. </para>
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
				///  <para>Returns an encoding of this <c>CertPath </c> using the given  <c>encoding </c> from getEncodings().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "(Ljava/lang/String;)[B", AccessFlags = 1025)]
				public abstract byte[] GetEncoded(string encoding) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns an alternate object to be serialized.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an alternate object to be serialized. </para>
				/// </returns>
				/// <java-name>
				/// writeReplace
				/// </java-name>
				[Dot42.DexImport("writeReplace", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object WriteReplace() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CertPath() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the type of <c>Certificate </c> in this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate type. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public virtual string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns an immutable List of the <c>Certificate </c> s contained in the <c>CertPath </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a list of <c>Certificate </c> s in the <c>CertPath </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCertificates
				/// </java-name>
				public abstract global::Java.Util.IList<global::Java.Security.Cert.Certificate> Certificates
				{
						[Dot42.DexImport("getCertificates", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<+Ljava/security/cert/Certificate;>;")]
						get;
				}

				/// <summary>
				///  <para>Returns an encoding of the <c>CertPath </c> using the default encoding.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>default encoding of the <c>CertPath </c> . </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns an <c>Iterator </c> over the supported encodings for a representation of the certificate path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>Iterator </c> over supported encodings (as <c>String </c> s). </para>
				/// </returns>
				/// <java-name>
				/// getEncodings
				/// </java-name>
				public abstract global::Java.Util.IIterator<string> Encodings
				{
						[Dot42.DexImport("getEncodings", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						get;
				}

				/// <summary>
				///  <para>The alternate <c>Serializable </c> class to be used for serialization and deserialization on <c>CertPath </c> objects. </para>    
				/// </summary>
				/// <java-name>
				/// java/security/cert/CertPath$CertPathRep
				/// </java-name>
				[Dot42.DexImport("java/security/cert/CertPath$CertPathRep", AccessFlags = 12)]
				protected internal partial class CertPathRep : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 4, IgnoreFromJava = true)]
						protected internal CertPathRep(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 4)]
						protected internal CertPathRep(string @string, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Deserializes a <c>CertPath </c> from a serialized <c>CertPathRep </c> object.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the deserialized <c>CertPath </c> . </para>
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
						protected internal CertPathRep() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>This class implements the functionality of a builder for an unverified  <b>Certification Path</b>s from a specified certificate to a trust anchor. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathBuilder
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathBuilder", AccessFlags = 33)]
		public partial class CertPathBuilder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertPathBuilder </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPathBuilderSpi;Ljava/security/Provider;Ljava/lang/String" +
    ";)V", AccessFlags = 4)]
				protected internal CertPathBuilder(global::Java.Security.Cert.CertPathBuilderSpi builderSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertPathBuilder </c> instance with the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a builder for the requested algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertPathBuilder;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathBuilder GetInstance(string algorithm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathBuilder);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertPathBuilder;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathBuilder GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathBuilder);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertPathBuilder;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathBuilder GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathBuilder);
				}

				/// <summary>
				///  <para>Builds a certification path with the specified algorithm parameters.</para> <para> <para>CertPathBuilderResult </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the built certification path. </para>
				/// </returns>
				/// <java-name>
				/// build
				/// </java-name>
				[Dot42.DexImport("build", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResul" +
    "t;", AccessFlags = 17)]
				public global::Java.Security.Cert.ICertPathBuilderResult Build(global::Java.Security.Cert.ICertPathParameters @params) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.ICertPathBuilderResult);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CertPathBuilder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the algorithm name of this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the algorithm name of this instance. </para>
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
				///  <para>Returns the provider of this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider of this instance. </para>
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
				///  <para>Returns the default <c>CertPathBuilder </c> type from the  <b>Security Properties</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default <c>CertPathBuilder </c> type from the  <b>Security Properties</b>, or the string "@code PKIX @endcode " if it cannot be determined. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultType
				/// </java-name>
				public static string DefaultType
				{
						[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>The exception that is thrown when a <c>CertPathBuilder </c> method fails. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathBuilderException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathBuilderException", AccessFlags = 33)]
		public partial class CertPathBuilderException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertPathBuilderException </c> with the specified message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertPathBuilderException(string msg, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertPathBuilderException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertPathBuilderException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertPathBuilderException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertPathBuilderException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The  <b>Service Provider Interface</b> ( <b>SPI</b>) for the <c>CertPathBuilder </c> class to be implemented by security providers. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathBuilderSpi
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathBuilderSpi", AccessFlags = 1057)]
		public abstract partial class CertPathBuilderSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertPathBuilderSpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertPathBuilderSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Builds a certification path with the specified algorithm parameters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a result of the build. </para>
				/// </returns>
				/// <java-name>
				/// engineBuild
				/// </java-name>
				[Dot42.DexImport("engineBuild", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResul" +
    "t;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.ICertPathBuilderResult EngineBuild(global::Java.Security.Cert.ICertPathParameters @params) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>This class provides the functionality for validating certification paths (certificate chains) establishing a trust chain from a certificate to a trust anchor. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathValidator
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathValidator", AccessFlags = 33)]
		public partial class CertPathValidator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertPathValidator </c> instance.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPathValidatorSpi;Ljava/security/Provider;Ljava/lang/Stri" +
    "ng;)V", AccessFlags = 4)]
				protected internal CertPathValidator(global::Java.Security.Cert.CertPathValidatorSpi validatorSpi, global::Java.Security.Provider provider, string algorithm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new certification path validator for the specified algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a certification path validator for the requested algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertPathValidator;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathValidator GetInstance(string algorithm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathValidator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertPathValidator;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathValidator GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathValidator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertPathValidator" +
    ";", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathValidator GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathValidator);
				}

				/// <summary>
				///  <para>Validates the <c>CertPath </c> with the algorithm of this <c>CertPathValidator </c> using the specified algorithm parameters.</para> <para> <para>CertPathValidatorResult </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the validation result. </para>
				/// </returns>
				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/secur" +
    "ity/cert/CertPathValidatorResult;", AccessFlags = 17)]
				public global::Java.Security.Cert.ICertPathValidatorResult Validate(global::Java.Security.Cert.CertPath certPath, global::Java.Security.Cert.ICertPathParameters @params) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.ICertPathValidatorResult);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CertPathValidator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the certification path algorithm name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certification path algorithm name. </para>
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
				///  <para>Returns the security provider.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the provider. </para>
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
				///  <para>Returns the default <c>CertPathValidator </c> type from the  <b>Security Properties</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default <c>CertPathValidator </c> type from the  <b>Security Properties</b>, or the string <c>"PKIX" </c> if it cannot be determined. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultType
				/// </java-name>
				public static string DefaultType
				{
						[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>The exception that is thrown when a certification path (or certificate chain) cannot be validated. </para> <para>A <c>CertPathValidatorException </c> may optionally include the certification path instance that failed the validation and the index of the failed certificate. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathValidatorException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathValidatorException", AccessFlags = 33)]
		public partial class CertPathValidatorException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertPathValidatorException </c> with the specified message , cause, certification path and certificate index in the certification path.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/security/cert/CertPath;I)V", AccessFlags = 1)]
				public CertPathValidatorException(string msg, global::System.Exception cause, global::Java.Security.Cert.CertPath certPath, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertPathValidatorException </c> with the specified message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertPathValidatorException(string msg, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertPathValidatorException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertPathValidatorException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertPathValidatorException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertPathValidatorException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the certification path that failed validation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certification path that failed validation, or <c>null </c> if none was specified. </para>
				/// </returns>
				/// <java-name>
				/// getCertPath
				/// </java-name>
				public virtual global::Java.Security.Cert.CertPath CertPath
				{
						[Dot42.DexImport("getCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.CertPath); }
				}

				/// <summary>
				///  <para>Returns the index of the failed certificate in the certification path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index of the failed certificate in the certification path, or  <c>-1 </c> if none was specified. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				public virtual int Index
				{
						[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>The  <b>Service Provider Interface</b> ( <b>SPI</b>) for the <c>CertPathValidator </c> class to be implemented by security providers. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathValidatorSpi
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathValidatorSpi", AccessFlags = 1057)]
		public abstract partial class CertPathValidatorSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertPathValidatorSpi </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertPathValidatorSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Validates the <c>CertPath </c> with the algorithm of this <c>CertPathValidator </c> using the specified algorithm parameters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the validation result. </para>
				/// </returns>
				/// <java-name>
				/// engineValidate
				/// </java-name>
				[Dot42.DexImport("engineValidate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/secur" +
    "ity/cert/CertPathValidatorResult;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.ICertPathValidatorResult EngineValidate(global::Java.Security.Cert.CertPath certPath, global::Java.Security.Cert.ICertPathParameters @params) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>This class provides the functionality to retrieve <c>Certificate </c> s and  <c>CRL </c> s from a read-only repository. This repository may be very large and may store trusted as well as untrusted certificates. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertStore
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertStore", AccessFlags = 33)]
		public partial class CertStore
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertStore </c> instance.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertStoreSpi;Ljava/security/Provider;Ljava/lang/String;Ljava" +
    "/security/cert/CertStoreParameters;)V", AccessFlags = 4)]
				protected internal CertStore(global::Java.Security.Cert.CertStoreSpi storeSpi, global::Java.Security.Provider provider, string type, global::Java.Security.Cert.ICertStoreParameters @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertStore </c> instance with the specified type and initialized with the specified parameters.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new certificate store instance. </para>
				/// </returns>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;)Ljava/security/cert/C" +
    "ertStore;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertStore GetInstance(string type, global::Java.Security.Cert.ICertStoreParameters @params) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertStore);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;Ljava/lang/String;)Lja" +
    "va/security/cert/CertStore;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertStore GetInstance(string @string, global::Java.Security.Cert.ICertStoreParameters certStoreParameters, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertStore);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;Ljava/security/Provide" +
    "r;)Ljava/security/cert/CertStore;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertStore GetInstance(string @string, global::Java.Security.Cert.ICertStoreParameters certStoreParameters, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertStore);
				}

				/// <summary>
				///  <para>Returns the list of <c>Certificate </c> s for the specified <c>CertSelector </c> from this certificate store.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of <c>Certificate </c> s that match the criteria of the specified selector. </para>
				/// </returns>
				/// <java-name>
				/// getCertificates
				/// </java-name>
				[Dot42.DexImport("getCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", AccessFlags = 17, Signature = "(Ljava/security/cert/CertSelector;)Ljava/util/Collection<+Ljava/security/cert/Cer" +
    "tificate;>;")]
				public global::Java.Util.ICollection<global::Java.Security.Cert.Certificate> GetCertificates(global::Java.Security.Cert.ICertSelector selector) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Java.Security.Cert.Certificate>);
				}

				/// <summary>
				///  <para>Returns the list of <c>CRL </c> s for the specified <c>CRLSelector </c> from this certificate store.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of <c>CRL </c> s that match the criteria of the specified selector </para>
				/// </returns>
				/// <java-name>
				/// getCRLs
				/// </java-name>
				[Dot42.DexImport("getCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", AccessFlags = 17, Signature = "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection<+Ljava/security/cert/CRL;" +
    ">;")]
				public global::Java.Util.ICollection<global::Java.Security.Cert.CRL> GetCRLs(global::Java.Security.Cert.ICRLSelector selector) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Java.Security.Cert.CRL>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CertStore() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the certificate store type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate store type. </para>
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
				///  <para>Returns the security provider.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the security provider. </para>
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
				///  <para>Returns a copy of the certificate store parameters that were used to initialize this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a copy of the certificate store parameters or <c>null </c> if none were specified. </para>
				/// </returns>
				/// <java-name>
				/// getCertStoreParameters
				/// </java-name>
				public global::Java.Security.Cert.ICertStoreParameters CertStoreParameters
				{
						[Dot42.DexImport("getCertStoreParameters", "()Ljava/security/cert/CertStoreParameters;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Cert.ICertStoreParameters); }
				}

				/// <summary>
				///  <para>Returns the default <c>CertStore </c> type from the  <b>Security Properties</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the default <c>CertStore </c> type from the  <b>Security Properties</b>, or the string <c>"LDAP" </c> if it cannot be determined. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultType
				/// </java-name>
				public static string DefaultType
				{
						[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>The exception that is thrown when an access to a <c>CertStore </c> fails. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertStoreException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertStoreException", AccessFlags = 33)]
		public partial class CertStoreException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertStoreException </c> with the specified message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertStoreException(string msg, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertStoreException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertStoreException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CertStoreException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertStoreException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The  <b>Service Provider Interface</b> ( <b>SPI</b>) definition for the <c>CertStore </c> class to be implemented by security providers. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertStoreSpi
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertStoreSpi", AccessFlags = 1057)]
		public abstract partial class CertStoreSpi
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CertStoreSpi </c> .</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertStoreParameters;)V", AccessFlags = 1)]
				public CertStoreSpi(global::Java.Security.Cert.ICertStoreParameters @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the list of <c>Certificate </c> s for the specified <c>CertSelector </c> from this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of <c>Certificate </c> s that match the criteria of the specified selector. </para>
				/// </returns>
				/// <java-name>
				/// engineGetCertificates
				/// </java-name>
				[Dot42.DexImport("engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", AccessFlags = 1025, Signature = "(Ljava/security/cert/CertSelector;)Ljava/util/Collection<+Ljava/security/cert/Cer" +
    "tificate;>;")]
				public abstract global::Java.Util.ICollection<global::Java.Security.Cert.Certificate> EngineGetCertificates(global::Java.Security.Cert.ICertSelector selector) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the list of <c>CRL </c> s for the specified <c>CRLSelector </c> from this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of <c>CRL </c> s that match the criteria of the specified selector </para>
				/// </returns>
				/// <java-name>
				/// engineGetCRLs
				/// </java-name>
				[Dot42.DexImport("engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", AccessFlags = 1025, Signature = "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection<+Ljava/security/cert/CRL;" +
    ">;")]
				public abstract global::Java.Util.ICollection<global::Java.Security.Cert.CRL> EngineGetCRLs(global::Java.Security.Cert.ICRLSelector selector) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CertStoreSpi() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>The parameters to initialize a  <b>Collection</b> type <c>CertStore </c> instance. </para> <para>It is used to specify the <c>Collection </c> where the <c>CertStore </c> will retrieve the certificates and CRLs from. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CollectionCertStoreParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CollectionCertStoreParameters", AccessFlags = 33)]
		public partial class CollectionCertStoreParameters : global::Java.Security.Cert.ICertStoreParameters
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>CollectionCertStoreParameters </c> without a collection. </para> <para>The default collection is an empty and unmodifiable <c>Collection </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CollectionCertStoreParameters() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CollectionCertStoreParameters </c> with the specified collection. </para> <para>The specified collection is not copied and therefore may be modified at any time.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)V")]
				public CollectionCertStoreParameters(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clones this <c>CollectionCertStoreParameters </c> instance, but not the underlying collection.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the string representation of this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string representation of this instance. </para>
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
				///  <para>Returns the collection where the <c>Certificate </c> s and <c>CRL </c> s are retrieved from.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the collection where the <c>Certificate </c> s and <c>CRL </c> s will be retrieved from. </para>
				/// </returns>
				/// <java-name>
				/// getCollection
				/// </java-name>
				public virtual global::Java.Util.ICollection<object> Collection
				{
						[Dot42.DexImport("getCollection", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<*>;")]
						get{ return default(global::Java.Util.ICollection<object>); }
				}

		}

		/// <summary>
		///  <para>This class represents Certificate Revocation Lists (CRLs) maintained by a certificate authority. They are used to indicate that a given Certificate has expired and consequently has become invalid.</para> <para> <para>CertificateFactory </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CRL
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CRL", AccessFlags = 1057)]
		public abstract partial class CRL
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new certificate revocation list of the specified type.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal CRL(string type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the specified certificate is revoked by this CRL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the certificate is revoked by this CRL, otherwise  <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isRevoked
				/// </java-name>
				[Dot42.DexImport("isRevoked", "(Ljava/security/cert/Certificate;)Z", AccessFlags = 1025)]
				public abstract bool IsRevoked(global::Java.Security.Cert.Certificate cert) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the string representation of this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string representation of this instance. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CRL() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the type of this CRL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the type of this CRL. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>The exception that is thrown if errors occur during handling of <c>CRL </c> s. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CRLException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CRLException", AccessFlags = 33)]
		public partial class CRLException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CRLException(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CRLException </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CRLException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>CRLException </c> with the specified message and cause.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CRLException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CRLException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>The interface for results generated by CertPathBuilder#build(CertPathParameters). </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathBuilderResult
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathBuilderResult", AccessFlags = 1537)]
		public partial interface ICertPathBuilderResult : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Clones this <c>CertPathBuilderResult </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the copy of this instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the built <c>CertPath </c> instance. Never returns <c>null </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the built certificate path instance. </para>
				/// </returns>
				/// <java-name>
				/// getCertPath
				/// </java-name>
				global::Java.Security.Cert.CertPath CertPath
				{
						[Dot42.DexImport("getCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The interface specification for certification path algorithm parameters. </para> <para>This interface is for grouping purposes of <c>CertPath </c> parameter implementations. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathParameters", AccessFlags = 1537)]
		public partial interface ICertPathParameters : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Clones this <c>CertPathParameters </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The interface specification for certification path validation results. </para> <para>This interface is for grouping purposes of validation result implementations. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertPathValidatorResult
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathValidatorResult", AccessFlags = 1537)]
		public partial interface ICertPathValidatorResult : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Clones this <c>CertPathValidatorResult </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The interface specification to determine whether a <c>Certificate </c> meets some criteria. </para> <para>The implementations of this interface are typically used to define the criteria for selecting <c>Certificate </c> s from a <c>CertStore </c> .</para> <para> <para>CertStore </para> <para>Certificate </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertSelector
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertSelector", AccessFlags = 1537)]
		public partial interface ICertSelector : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Clones this <c>CertSelector </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Checks whether the defined criteria of this instance match the specified certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the certificate matches the criteria, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/security/cert/Certificate;)Z", AccessFlags = 1025)]
				bool Match(global::Java.Security.Cert.Certificate cert) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The marker interface specifying the parameters used to initialize a <c>CertStore </c> instance. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CertStoreParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertStoreParameters", AccessFlags = 1537)]
		public partial interface ICertStoreParameters : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Clones this <c>CertStoreParameters </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The interface specification for determining whether a CRL meets some criteria to select CRL objects among a set of <c>CRL </c> s. </para> <para>The implementations of this interface are typically used to define the criteria for selecting <c>CRL </c> s from a <c>CertStore </c> .</para> <para> <para>CertStore </para> <para>CRL </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/CRLSelector
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CRLSelector", AccessFlags = 1537)]
		public partial interface ICRLSelector : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Clones this <c>CRLSelector </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Checks whether the defined criteria of this instance match the specified CRL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the CRL matches the criteria, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/security/cert/CRL;)Z", AccessFlags = 1025)]
				bool Match(global::Java.Security.Cert.CRL crl) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The interface to a valid policy tree node for the PKIX certification path validation algorithm. </para> <para>Instances of this class are one of the outputs of the PKIX certification path validation algorithm. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/PolicyNode
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PolicyNode", AccessFlags = 1537)]
		public partial interface IPolicyNode
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the list of children of this node as an <c>Iterator </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of children of this node as an <c>Iterator </c> . </para>
				/// </returns>
				/// <java-name>
				/// getChildren
				/// </java-name>
				global::Java.Util.IIterator<global::Java.Security.Cert.IPolicyNode> Children
				{
						[Dot42.DexImport("getChildren", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<+Ljava/security/cert/PolicyNode;>;")]
						get;
				}

				/// <summary>
				///  <para>Returns the depth of this node in the policy tree. </para> <para>the depth is zero based.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the depth of this node in the policy tree. </para>
				/// </returns>
				/// <java-name>
				/// getDepth
				/// </java-name>
				int Depth
				{
						[Dot42.DexImport("getDepth", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the expected policies for the next certificate to be valid.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the expected policies. </para>
				/// </returns>
				/// <java-name>
				/// getExpectedPolicies
				/// </java-name>
				global::Java.Util.ISet<string> ExpectedPolicies
				{
						[Dot42.DexImport("getExpectedPolicies", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get;
				}

				/// <summary>
				///  <para>Returns the parent policy node.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parent policy node. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				global::Java.Security.Cert.IPolicyNode Parent
				{
						[Dot42.DexImport("getParent", "()Ljava/security/cert/PolicyNode;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the policy qualifiers associated with the policy of this node.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the policy qualifiers associated with the policy of this node. </para>
				/// </returns>
				/// <java-name>
				/// getPolicyQualifiers
				/// </java-name>
				global::Java.Util.ISet<global::Java.Security.Cert.PolicyQualifierInfo> PolicyQualifiers
				{
						[Dot42.DexImport("getPolicyQualifiers", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<+Ljava/security/cert/PolicyQualifierInfo;>;")]
						get;
				}

				/// <summary>
				///  <para>Returns the valid policy of this node.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the valid policy of this node. </para>
				/// </returns>
				/// <java-name>
				/// getValidPolicy
				/// </java-name>
				string ValidPolicy
				{
						[Dot42.DexImport("getValidPolicy", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether the certificate policy extension of the most recently processed certificate is marked as critical.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the extension is marked as critical, otherwise  <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isCritical
				/// </java-name>
				bool IsCritical
				{
						[Dot42.DexImport("isCritical", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The interface specifying an X.509 Certificate or CRL extension. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/X509Extension
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509Extension", AccessFlags = 1537)]
		public partial interface IX509Extension
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the extension value as DER-encoded OCTET string for the specified OID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the extension value as DER-encoded OCTET string, or <c>null </c> if no extension for the specified OID can be found. </para>
				/// </returns>
				/// <java-name>
				/// getExtensionValue
				/// </java-name>
				[Dot42.DexImport("getExtensionValue", "(Ljava/lang/String;)[B", AccessFlags = 1025)]
				byte[] GetExtensionValue(string oid) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the set of OIDs of the extension(s) marked as CRITICAL, that this implementation manages.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the set of extension OIDs marked as CRITIAL, an empty set if none are marked as CRITICAL, or <c>null </c> if no extensions are present. </para>
				/// </returns>
				/// <java-name>
				/// getCriticalExtensionOIDs
				/// </java-name>
				global::Java.Util.ISet<string> CriticalExtensionOIDs
				{
						[Dot42.DexImport("getCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get;
				}

				/// <summary>
				///  <para>Returns the set of OIDs of the extension(s) marked as NON-CRITICAL, that this implementation manages.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the set of extension OIDs marked as NON-CRITIAL, an empty set if none are marked as NON-.CRITICAL, or <c>null </c> if no extensions are present. </para>
				/// </returns>
				/// <java-name>
				/// getNonCriticalExtensionOIDs
				/// </java-name>
				global::Java.Util.ISet<string> NonCriticalExtensionOIDs
				{
						[Dot42.DexImport("getNonCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get;
				}

				/// <summary>
				///  <para>Returns whether this instance has an extension marked as CRITICAL that it cannot support.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if an unsupported CRITICAL extension is present,  <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasUnsupportedCriticalExtension
				/// </java-name>
				bool HasUnsupportedCriticalExtension
				{
						[Dot42.DexImport("hasUnsupportedCriticalExtension", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The parameters to initialize a LDAP <c>CertStore </c> instance. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/LDAPCertStoreParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/LDAPCertStoreParameters", AccessFlags = 33)]
		public partial class LDAPCertStoreParameters : global::Java.Security.Cert.ICertStoreParameters
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>LDAPCertStoreParameters </c> instance with the specified server name and port.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public LDAPCertStoreParameters(string serverName, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>LDAPCertStoreParameters </c> instance with default parameters. </para> <para>The default parameters are server name "localhost" and port 389. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LDAPCertStoreParameters() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>LDAPCertStoreParameters </c> instance with the specified server name and default port 389.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LDAPCertStoreParameters(string serverName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clones this <c>LDAPCertStoreParameters </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the string representation of this <c>LDAPCertStoreParameters </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the string representation of this <c>LDAPCertStoreParameters </c> instance. </para>
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
				///  <para>Returns the LDAP server port.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the LDAP server port. </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				public virtual int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the LDAP server name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the LDAP server name. </para>
				/// </returns>
				/// <java-name>
				/// getServerName
				/// </java-name>
				public virtual string ServerName
				{
						[Dot42.DexImport("getServerName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>The parameter specification for a PKIX <c>CertPathBuilder </c> algorithm used to build certificate chains validated with the PKIX certification path validation. </para> <para>The parameters must be created with  <b>trusted</b> certificate authorities and constraints for the target certificates.</para> <para> <para>CertPathBuilder </para> <para>CertPathParameters </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/PKIXBuilderParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXBuilderParameters", AccessFlags = 33)]
		public partial class PKIXBuilderParameters : global::Java.Security.Cert.PKIXParameters
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>PKIXBuilderParameters </c> instance with the specified set of <c>TrustAnchor </c> and certificate constraints.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Set;Ljava/security/cert/CertSelector;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/security/cert/TrustAnchor;>;Ljava/security/cert/CertSelecto" +
    "r;)V")]
				public PKIXBuilderParameters(global::Java.Util.ISet<global::Java.Security.Cert.TrustAnchor> trustAnchors, global::Java.Security.Cert.ICertSelector targetConstraints) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>PKIXBuilderParameters </c> instance with the specified set of <c>TrustAnchor </c> and certificate constraints.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;Ljava/security/cert/CertSelector;)V", AccessFlags = 1)]
				public PKIXBuilderParameters(global::Java.Security.KeyStore trustAnchors, global::Java.Security.Cert.ICertSelector targetConstraints) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string representation of this <c>PKIXBuilderParameters </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this <c>PKIXBuilderParameters </c> instance. </para>
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
				protected internal PKIXBuilderParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the maximum length of a certification path. </para> <para>This is the maximum number of non-self-signed certificates in a certification path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum length of a certification path, or <c>-1 </c> if it is unlimited. </para>
				/// </returns>
				/// <java-name>
				/// getMaxPathLength
				/// </java-name>
				public virtual int MaxPathLength
				{
						[Dot42.DexImport("getMaxPathLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMaxPathLength", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>The result of the PKIX certification path builder, returned by CertPathBuilder#build(CertPathParameters). </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/PKIXCertPathBuilderResult
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXCertPathBuilderResult", AccessFlags = 33)]
		public partial class PKIXCertPathBuilderResult : global::Java.Security.Cert.PKIXCertPathValidatorResult, global::Java.Security.Cert.ICertPathBuilderResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>PKIXCertPathBuilderResult </c> instance with the specified validated certification path, the trust anchor of the certification path, the policy tree and the public key of the subject.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPath;Ljava/security/cert/TrustAnchor;Ljava/security/cert" +
    "/PolicyNode;Ljava/security/PublicKey;)V", AccessFlags = 1)]
				public PKIXCertPathBuilderResult(global::Java.Security.Cert.CertPath certPath, global::Java.Security.Cert.TrustAnchor trustAnchor, global::Java.Security.Cert.IPolicyNode policyTree, global::Java.Security.IPublicKey subjectPublicKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string representation of this <c>PKIXCertPathBuilderResult </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this <c>PKIXCertPathBuilderResult </c> instance. </para>
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
				protected internal PKIXCertPathBuilderResult() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/security/cert/CertPathBuilderResult", "clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public override object Clone() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the validated certification path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the validated certification path. </para>
				/// </returns>
				/// <java-name>
				/// getCertPath
				/// </java-name>
				public virtual global::Java.Security.Cert.CertPath CertPath
				{
						[Dot42.DexImport("getCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.CertPath); }
				}

		}

		/// <summary>
		///  <para>The class specifying the interface to extend the certification path validation algorithm by checks to perform on an <c>X509Certificate </c> . </para> <para>The checks are added to a certification path validation using the setCertPathCheckers or addCertPathChecker of the <c>PKIXParameters </c> and <c>PKIXBuilderParameters </c> class respectively. The check method will be called for each certificate processed by a <c>CertPathBuilder </c> of <c>CertPathValidator </c> . </para> <para>A <c>PKIXCertPathChecker </c> implementation &lt;u&gt;must&lt;/u&gt; support reverse checking (from trusted CA to target) and &lt;u&gt;may&lt;/u&gt; support forward checking (from target to trusted CA). The return value of <c>isForwardCheckingSupported </c> indicates whether forward checking is supported. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/PKIXCertPathChecker
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXCertPathChecker", AccessFlags = 1057)]
		public abstract partial class PKIXCertPathChecker : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>PKIXCertPathChecker </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal PKIXCertPathChecker() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clones this <c>PKIXCertPathChecker </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Initializes this <c>PKIXCertPathChecker </c> instance for specified  <b>checking direction</b>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Z)V", AccessFlags = 1025)]
				public abstract void Init(bool forward) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Checks the specified certificate and removes the processed critical extensions from the specified list of X.509 extension  <b>OID</b>s.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// check
				/// </java-name>
				[Dot42.DexImport("check", "(Ljava/security/cert/Certificate;Ljava/util/Collection;)V", AccessFlags = 1025, Signature = "(Ljava/security/cert/Certificate;Ljava/util/Collection<Ljava/lang/String;>;)V")]
				public abstract void Check(global::Java.Security.Cert.Certificate cert, global::Java.Util.ICollection<string> unresolvedCritExts) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether this <c>PKIXCertPathChecker </c> instance supports  <b>forward checking</b>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this <c>PKIXCertPathChecker </c> instance supports forward checking, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isForwardCheckingSupported
				/// </java-name>
				public abstract bool IsForwardCheckingSupported
				{
						[Dot42.DexImport("isForwardCheckingSupported", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the list of extensions of X.509 certificates that this <c>PKIXCertPathChecker </c> is able to process.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of extensions of X.509 certificates that this <c>PKIXCertPathChecker </c> is able to process, or <c>null </c> if there are none. </para>
				/// </returns>
				/// <java-name>
				/// getSupportedExtensions
				/// </java-name>
				public abstract global::Java.Util.ISet<string> SupportedExtensions
				{
						[Dot42.DexImport("getSupportedExtensions", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get;
				}

		}

		/// <summary>
		///  <para>The implementation of the result of the PKIX certification path validation.</para> <para> <para>CertPathValidator </para> <para>CertPathValidator::validate(CertPath, CertPathParameters) </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/PKIXCertPathValidatorResult
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXCertPathValidatorResult", AccessFlags = 33)]
		public partial class PKIXCertPathValidatorResult : global::Java.Security.Cert.ICertPathValidatorResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>PKIXCertPathValidatorResult </c> with the specified trust anchor, the valid policy tree and the subject public key.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/TrustAnchor;Ljava/security/cert/PolicyNode;Ljava/security/Pu" +
    "blicKey;)V", AccessFlags = 1)]
				public PKIXCertPathValidatorResult(global::Java.Security.Cert.TrustAnchor trustAnchor, global::Java.Security.Cert.IPolicyNode policyTree, global::Java.Security.IPublicKey subjectPublicKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clones this <c>PKIXCertPathValidatorResult </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns a string representation for this <c>PKIXCertPathValidatorResult </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation for this <c>PKIXCertPathValidatorResult </c> instance. </para>
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
				protected internal PKIXCertPathValidatorResult() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the valid policy tree from the validation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the valid policy tree from the validation. </para>
				/// </returns>
				/// <java-name>
				/// getPolicyTree
				/// </java-name>
				public virtual global::Java.Security.Cert.IPolicyNode PolicyTree
				{
						[Dot42.DexImport("getPolicyTree", "()Ljava/security/cert/PolicyNode;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.IPolicyNode); }
				}

				/// <summary>
				///  <para>Returns the subject public key from the validation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject public key from the validation. </para>
				/// </returns>
				/// <java-name>
				/// getPublicKey
				/// </java-name>
				public virtual global::Java.Security.IPublicKey PublicKey
				{
						[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPublicKey); }
				}

				/// <summary>
				///  <para>Returns the trust anchor describing the certification authority (CA) that served as trust anchor for this certification path.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the trust anchor. </para>
				/// </returns>
				/// <java-name>
				/// getTrustAnchor
				/// </java-name>
				public virtual global::Java.Security.Cert.TrustAnchor TrustAnchor
				{
						[Dot42.DexImport("getTrustAnchor", "()Ljava/security/cert/TrustAnchor;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.TrustAnchor); }
				}

		}

		/// <summary>
		///  <para>This class implements the parameters for the <c>PKIX CertPathValidator </c> . </para> <para>The parameters must be created with  <b>trusted</b> certificate authorities (trust anchors).</para> <para> <para>CertPathValidator </para> <para>CertPathParameters </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/PKIXParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXParameters", AccessFlags = 33)]
		public partial class PKIXParameters : global::Java.Security.Cert.ICertPathParameters
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>PKIXParameters </c> instance with the specified set of  <b>trusted</b> certificate authorities.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/security/cert/TrustAnchor;>;)V")]
				public PKIXParameters(global::Java.Util.ISet<global::Java.Security.Cert.TrustAnchor> trustAnchors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>PKIXParameters </c> instance with the specified set of  <b>trusted</b> certificate authorities.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;)V", AccessFlags = 1)]
				public PKIXParameters(global::Java.Security.KeyStore trustAnchors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds the specified <c>PKIXCertPathChecker </c> to the list of certification path checkers.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addCertPathChecker
				/// </java-name>
				[Dot42.DexImport("addCertPathChecker", "(Ljava/security/cert/PKIXCertPathChecker;)V", AccessFlags = 1)]
				public virtual void AddCertPathChecker(global::Java.Security.Cert.PKIXCertPathChecker checker) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a certificate store to the list of certificate stores that are used to find certificates and CRLs.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addCertStore
				/// </java-name>
				[Dot42.DexImport("addCertStore", "(Ljava/security/cert/CertStore;)V", AccessFlags = 1)]
				public virtual void AddCertStore(global::Java.Security.Cert.CertStore store) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clones this <c>PKIXParameters </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns a string representation of this <c>PKIXParameters </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this <c>PKIXParameters </c> instance. </para>
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
				protected internal PKIXParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns a unmodifiable set of the  <b>trusted</b> certificate authorities.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a unmodifiable set of the  <b>trusted</b> certificate authorities. </para>
				/// </returns>
				/// <java-name>
				/// getTrustAnchors
				/// </java-name>
				public virtual global::Java.Util.ISet<global::Java.Security.Cert.TrustAnchor> TrustAnchors
				{
						[Dot42.DexImport("getTrustAnchors", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/security/cert/TrustAnchor;>;")]
						get{ return default(global::Java.Util.ISet<global::Java.Security.Cert.TrustAnchor>); }
						[Dot42.DexImport("setTrustAnchors", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/security/cert/TrustAnchor;>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns whether the  <b>any policy OID</b> will be inhibited if it's included in a certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the  <b>any policy OID</b> will be inhibited, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isAnyPolicyInhibited
				/// </java-name>
				public virtual bool IsAnyPolicyInhibited
				{
						[Dot42.DexImport("isAnyPolicyInhibited", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAnyPolicyInhibited", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the list of checkers for the certification path. </para> <para>The list is unmodifiable and the entries in the list are cloned.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of checkers for the certification path. </para>
				/// </returns>
				/// <java-name>
				/// getCertPathCheckers
				/// </java-name>
				public virtual global::Java.Util.IList<global::Java.Security.Cert.PKIXCertPathChecker> CertPathCheckers
				{
						[Dot42.DexImport("getCertPathCheckers", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/security/cert/PKIXCertPathChecker;>;")]
						get{ return default(global::Java.Util.IList<global::Java.Security.Cert.PKIXCertPathChecker>); }
						[Dot42.DexImport("setCertPathCheckers", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/security/cert/PKIXCertPathChecker;>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns the list of certificate stores that are used to find certificates and CRLs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an immutable list of certificate stores. </para>
				/// </returns>
				/// <java-name>
				/// getCertStores
				/// </java-name>
				public virtual global::Java.Util.IList<global::Java.Security.Cert.CertStore> CertStores
				{
						[Dot42.DexImport("getCertStores", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/security/cert/CertStore;>;")]
						get{ return default(global::Java.Util.IList<global::Java.Security.Cert.CertStore>); }
						[Dot42.DexImport("setCertStores", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/security/cert/CertStore;>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns the time for which the validation of the certification path should be evaluated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the time for the validation, or <c>null </c> for the current time. </para>
				/// </returns>
				/// <java-name>
				/// getDate
				/// </java-name>
				public virtual global::Java.Util.Date Date
				{
						[Dot42.DexImport("getDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setDate", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns whether an acceptable policy needs to be explicit identified in every certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if an explicit policy is required, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isExplicitPolicyRequired
				/// </java-name>
				public virtual bool IsExplicitPolicyRequired
				{
						[Dot42.DexImport("isExplicitPolicyRequired", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setExplicitPolicyRequired", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the list of policies (as OID strings) that would be acceptable for the purpose of certification path processing.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the unmodifiable list of policies, or an empty set if any policy is acceptable. </para>
				/// </returns>
				/// <java-name>
				/// getInitialPolicies
				/// </java-name>
				public virtual global::Java.Util.ISet<string> InitialPolicies
				{
						[Dot42.DexImport("getInitialPolicies", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
						[Dot42.DexImport("setInitialPolicies", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns whether policy mapping is inhibited.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if policy mapping is inhibited, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isPolicyMappingInhibited
				/// </java-name>
				public virtual bool IsPolicyMappingInhibited
				{
						[Dot42.DexImport("isPolicyMappingInhibited", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPolicyMappingInhibited", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns whether certificates are rejected that include policy qualifiers in a certificate policy extension that is marked as critical.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the certificates should be rejected, otherwise  <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// getPolicyQualifiersRejected
				/// </java-name>
				public virtual bool PolicyQualifiersRejected
				{
						[Dot42.DexImport("getPolicyQualifiersRejected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPolicyQualifiersRejected", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns whether the default revocation checking mechanism of the underlying service provider is used.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the default revocation checking mechanism is used, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// isRevocationEnabled
				/// </java-name>
				public virtual bool IsRevocationEnabled
				{
						[Dot42.DexImport("isRevocationEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setRevocationEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the name of the signature provider.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the signature provider, or <c>null </c> if none is set. </para>
				/// </returns>
				/// <java-name>
				/// getSigProvider
				/// </java-name>
				public virtual string SigProvider
				{
						[Dot42.DexImport("getSigProvider", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSigProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the constraints that are required for the target certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the constraints for the target certificate, or <c>null </c> if none are set. </para>
				/// </returns>
				/// <java-name>
				/// getTargetCertConstraints
				/// </java-name>
				public virtual global::Java.Security.Cert.ICertSelector TargetCertConstraints
				{
						[Dot42.DexImport("getTargetCertConstraints", "()Ljava/security/cert/CertSelector;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.ICertSelector); }
						[Dot42.DexImport("setTargetCertConstraints", "(Ljava/security/cert/CertSelector;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>This class implements a policy qualifier as defined by the ASN.1  <c>PolicyQualifierInfo </c> structure. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/PolicyQualifierInfo
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PolicyQualifierInfo", AccessFlags = 33)]
		public partial class PolicyQualifierInfo
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>PolicyQualifierInfo </c> from the specified encoded form.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PolicyQualifierInfo(sbyte[] encoded) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>PolicyQualifierInfo </c> from the specified encoded form.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public PolicyQualifierInfo(byte[] encoded) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a ASN.1 DER encoded copy of policy qualifier info.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ASN.1 DER encoded copy of policy qualifier info. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns a ASN.1 DER encoded copy of the qualifier of this policy qualifier info.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ASN.1 DER encoded copy of the qualifier of this policy qualifier info. </para>
				/// </returns>
				/// <java-name>
				/// getPolicyQualifier
				/// </java-name>
				[Dot42.DexImport("getPolicyQualifier", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public sbyte[] JavaGetPolicyQualifier() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns a string representation of this <c>PolicyQualifierInfo </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this <c>PolicyQualifierInfo </c> instance. </para>
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
				protected internal PolicyQualifierInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns a ASN.1 DER encoded copy of policy qualifier info.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ASN.1 DER encoded copy of policy qualifier info. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the identifier (an OID) of this policy qualifier info.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the identifier of this policy qualifier info. </para>
				/// </returns>
				/// <java-name>
				/// getPolicyQualifierId
				/// </java-name>
				public string PolicyQualifierId
				{
						[Dot42.DexImport("getPolicyQualifierId", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns a ASN.1 DER encoded copy of the qualifier of this policy qualifier info.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ASN.1 DER encoded copy of the qualifier of this policy qualifier info. </para>
				/// </returns>
				/// <java-name>
				/// getPolicyQualifier
				/// </java-name>
				public byte[] PolicyQualifier
				{
						[Dot42.DexImport("getPolicyQualifier", "()[B", AccessFlags = 17)]
						get{ return default(byte[]); }
				}

		}

		/// <summary>
		///  <para>This class represents a trust anchor for validation of X.509 certification path. </para> <para>It is a  <b>trusted</b> certificate authority (CA) and includes the public key of the CA, the CA's name and the constraints for the validation of certification paths. The constructor also allows to specify a binary representation of a so called "Name Constraints" extension as a byte array. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/TrustAnchor
		/// </java-name>
		[Dot42.DexImport("java/security/cert/TrustAnchor", AccessFlags = 33)]
		public partial class TrustAnchor
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>TrustAnchor </c> with the specified certificate and name constraints. </para> <para>The name constraints will be used as additional constraints during the validation of certification paths.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/X509Certificate;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public TrustAnchor(global::Java.Security.Cert.X509Certificate trustedCert, sbyte[] nameConstraints) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new <c>TrustAnchor </c> with the specified certificate and name constraints. </para> <para>The name constraints will be used as additional constraints during the validation of certification paths.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/X509Certificate;[B)V", AccessFlags = 1)]
				public TrustAnchor(global::Java.Security.Cert.X509Certificate trustedCert, byte[] nameConstraints) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/PublicKey;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public TrustAnchor(string @string, global::Java.Security.IPublicKey publicKey, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/PublicKey;[B)V", AccessFlags = 1)]
				public TrustAnchor(string @string, global::Java.Security.IPublicKey publicKey, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljavax/security/auth/x500/X500Principal;Ljava/security/PublicKey;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public TrustAnchor(global::Javax.Security.Auth.X500.X500Principal x500Principal, global::Java.Security.IPublicKey publicKey, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljavax/security/auth/x500/X500Principal;Ljava/security/PublicKey;[B)V", AccessFlags = 1)]
				public TrustAnchor(global::Javax.Security.Auth.X500.X500Principal x500Principal, global::Java.Security.IPublicKey publicKey, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a copy of the name constraints in ASN.1 DER encoded form.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a copy of the name constraints in ASN.1 DER encoded form. </para>
				/// </returns>
				/// <java-name>
				/// getNameConstraints
				/// </java-name>
				[Dot42.DexImport("getNameConstraints", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
				public sbyte[] JavaGetNameConstraints() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Returns a string representation of this <c>TrustAnchor </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this <c>TrustAnchor </c> instance. </para>
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
				protected internal TrustAnchor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns a copy of the name constraints in ASN.1 DER encoded form.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a copy of the name constraints in ASN.1 DER encoded form. </para>
				/// </returns>
				/// <java-name>
				/// getNameConstraints
				/// </java-name>
				public byte[] NameConstraints
				{
						[Dot42.DexImport("getNameConstraints", "()[B", AccessFlags = 17)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the certificate of this  <b>trusted</b> certificate authority.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate of this CA or <c>null </c> , if the trust anchor of this instance was not created with a certificate. </para>
				/// </returns>
				/// <java-name>
				/// getTrustedCert
				/// </java-name>
				public global::Java.Security.Cert.X509Certificate TrustedCert
				{
						[Dot42.DexImport("getTrustedCert", "()Ljava/security/cert/X509Certificate;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Cert.X509Certificate); }
				}

				/// <summary>
				///  <para>Returns the name of the certificate authority as <c>X500Principal </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the certificate authority or <c>null </c> if the trust anchor of this instance was not created with a <c>X500Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getCA
				/// </java-name>
				public global::Javax.Security.Auth.X500.X500Principal CA
				{
						[Dot42.DexImport("getCA", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 17)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <summary>
				///  <para>Returns the name of the certificate authority as <c>String </c> in RFC 2253 format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the certificate authority as <c>String </c> in RFC 2253 format or <c>null </c> if the trust anchor of this instance was not created with a CA name. </para>
				/// </returns>
				/// <java-name>
				/// getCAName
				/// </java-name>
				public string CAName
				{
						[Dot42.DexImport("getCAName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the public key of the certificate authority.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the public key of the certificate authority or <c>null </c> if the trust anchor if this instance was not created with a public key. </para>
				/// </returns>
				/// <java-name>
				/// getCAPublicKey
				/// </java-name>
				public global::Java.Security.IPublicKey CAPublicKey
				{
						[Dot42.DexImport("getCAPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 17)]
						get{ return default(global::Java.Security.IPublicKey); }
				}

		}

		/// <summary>
		///  <para>Abstract base class for X.509 certificates. </para> <para>This represents a standard way for accessing the attributes of X.509 certificates. </para> <para>The basic X.509 v3 format described in ASN.1:</para> <para> <pre>
		/// Certificate  ::=  SEQUENCE  {
		///     tbsCertificate       TBSCertificate,
		///     signatureAlgorithm   AlgorithmIdentifier,
		///     signature            BIT STRING  }</pre></para> <para> <pre>TBSCertificate  ::=  SEQUENCE  {
		///      version         [0]  EXPLICIT Version DEFAULT v1,
		///      serialNumber         CertificateSerialNumber,
		///      signature            AlgorithmIdentifier,
		///      issuer               Name,
		///      validity             Validity,
		///      subject              Name,
		///      subjectPublicKeyInfo SubjectPublicKeyInfo,
		///      issuerUniqueID  [1]  IMPLICIT UniqueIdentifier OPTIONAL,
		///                           -- If present, version must be v2 or v3
		///      subjectUniqueID [2]  IMPLICIT UniqueIdentifier OPTIONAL,
		///                           -- If present, version must be v2 or v3
		///      extensions      [3]  EXPLICIT Extensions OPTIONAL
		///                           -- If present, version must be v3
		///      }
		/// </pre> </para> <para>For more information consult RFC 2459 "Internet X.509 Public Key Infrastructure Certificate and CRL Profile" at  . </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/X509Certificate
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509Certificate", AccessFlags = 1057)]
		public abstract partial class X509Certificate : global::Java.Security.Cert.Certificate, global::Java.Security.Cert.IX509Extension
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>X509Certificate </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal X509Certificate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Checks whether the certificate is currently valid. </para> <para>The validity defined in ASN.1:</para> <para> <pre>
				/// validity             Validity</pre></para> <para> <pre>Validity ::= SEQUENCE {
				///      notBefore       CertificateValidityDate,
				///      notAfter        CertificateValidityDate }</pre></para> <para> <pre>CertificateValidityDate ::= CHOICE {
				///      utcTime         UTCTime,
				///      generalTime     GeneralizedTime }
				/// </pre></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// checkValidity
				/// </java-name>
				[Dot42.DexImport("checkValidity", "()V", AccessFlags = 1025)]
				public abstract void CheckValidity() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Checks whether the certificate is valid at the specified date.</para> <para> <para>checkValidity() </para></para>        
				/// </summary>
				/// <java-name>
				/// checkValidity
				/// </java-name>
				[Dot42.DexImport("checkValidity", "(Ljava/util/Date;)V", AccessFlags = 1025)]
				public abstract void CheckValidity(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				[Dot42.DexImport("java/security/cert/X509Extension", "getExtensionValue", "(Ljava/lang/String;)[B", AccessFlags = 1025)]
				public virtual byte[] GetExtensionValue(string oid) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns the certificates <c>version </c> (version number). </para> <para>The version defined is ASN.1:</para> <para> <pre>
				/// Version ::=  INTEGER  {  v1(0), v2(1), v3(2)  }
				/// </pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the version number. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public abstract int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>serialNumber </c> of the certificate. </para> <para>The ASN.1 definition of <c>serialNumber </c> :</para> <para> <pre>
				/// CertificateSerialNumber  ::=  INTEGER
				/// </pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the serial number. </para>
				/// </returns>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public abstract global::Java.Math.BigInteger SerialNumber
				{
						[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>issuer </c> (issuer distinguished name) as an implementation specific <c>Principal </c> object. </para> <para>The ASN.1 definition of <c>issuer </c> :</para> <para> <pre>
				///  issuer      Name</pre></para> <para> <pre> Name ::= CHOICE {
				///      RDNSequence }</pre></para> <para> <pre>   RDNSequence ::= SEQUENCE OF RelativeDistinguishedName</pre></para> <para> <pre>   RelativeDistinguishedName ::= SET OF AttributeTypeAndValue</pre></para> <para> <pre>   AttributeTypeAndValue ::= SEQUENCE {
				///      type     AttributeType,
				///      value    AttributeValue }</pre></para> <para> <pre>   AttributeType ::= OBJECT IDENTIFIER</pre></para> <para> <pre>   AttributeValue ::= ANY DEFINED BY AttributeType
				/// </pre></para> <para> <b>replaced by:</b> getIssuerX500Principal().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>issuer </c> as an implementation specific <c>Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getIssuerDN
				/// </java-name>
				public abstract global::Java.Security.IPrincipal IssuerDN
				{
						[Dot42.DexImport("getIssuerDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>issuer </c> (issuer distinguished name) as an <c>X500Principal </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>issuer </c> (issuer distinguished name). </para>
				/// </returns>
				/// <java-name>
				/// getIssuerX500Principal
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal IssuerX500Principal
				{
						[Dot42.DexImport("getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <summary>
				///  <para>Returns the <c>subject </c> (subject distinguished name) as an implementation specific <c>Principal </c> object. </para> <para>The ASN.1 definition of <c>subject </c> :</para> <para> <pre>
				/// subject      Name</pre></para> <para> <pre> Name ::= CHOICE {
				///      RDNSequence }</pre></para> <para> <pre>   RDNSequence ::= SEQUENCE OF RelativeDistinguishedName</pre></para> <para> <pre>   RelativeDistinguishedName ::= SET OF AttributeTypeAndValue</pre></para> <para> <pre>   AttributeTypeAndValue ::= SEQUENCE {
				///      type     AttributeType,
				///      value    AttributeValue }</pre></para> <para> <pre>   AttributeType ::= OBJECT IDENTIFIER</pre></para> <para> <pre>   AttributeValue ::= ANY DEFINED BY AttributeType
				/// </pre></para> <para> <b>replaced by:</b> getSubjectX500Principal().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>subject </c> (subject distinguished name). </para>
				/// </returns>
				/// <java-name>
				/// getSubjectDN
				/// </java-name>
				public abstract global::Java.Security.IPrincipal SubjectDN
				{
						[Dot42.DexImport("getSubjectDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>subject </c> (subject distinguished name) as an <c>X500Principal </c> .</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>subject </c> (subject distinguished name) </para>
				/// </returns>
				/// <java-name>
				/// getSubjectX500Principal
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal SubjectX500Principal
				{
						[Dot42.DexImport("getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <summary>
				///  <para>Returns the <c>notBefore </c> date from the validity period of the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the start of the validity period. </para>
				/// </returns>
				/// <java-name>
				/// getNotBefore
				/// </java-name>
				public abstract global::Java.Util.Date NotBefore
				{
						[Dot42.DexImport("getNotBefore", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>notAfter </c> date of the validity period of the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the end of the validity period. </para>
				/// </returns>
				/// <java-name>
				/// getNotAfter
				/// </java-name>
				public abstract global::Java.Util.Date NotAfter
				{
						[Dot42.DexImport("getNotAfter", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>tbsCertificate </c> information from this certificate in DER-encoded format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the DER-encoded certificate information. </para>
				/// </returns>
				/// <java-name>
				/// getTBSCertificate
				/// </java-name>
				public abstract byte[] TBSCertificate
				{
						[Dot42.DexImport("getTBSCertificate", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the raw signature bits from the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the raw signature bits from the certificate. </para>
				/// </returns>
				/// <java-name>
				/// getSignature
				/// </java-name>
				public abstract byte[] Signature
				{
						[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the name of the algorithm for the certificate signature.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature algorithm name. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgName
				/// </java-name>
				public abstract string SigAlgName
				{
						[Dot42.DexImport("getSigAlgName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the OID of the signature algorithm from the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the OID of the signature algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgOID
				/// </java-name>
				public abstract string SigAlgOID
				{
						[Dot42.DexImport("getSigAlgOID", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the parameters of the signature algorithm in DER-encoded format.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameters of the signature algorithm, or <c>null </c> if none are used. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				public abstract byte[] SigAlgParams
				{
						[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>issuerUniqueID </c> from the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>issuerUniqueID </c> or <c>null </c> if there's none in the certificate. </para>
				/// </returns>
				/// <java-name>
				/// getIssuerUniqueID
				/// </java-name>
				public abstract bool[] IssuerUniqueID
				{
						[Dot42.DexImport("getIssuerUniqueID", "()[Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>subjectUniqueID </c> from the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>subjectUniqueID </c> or null if there's none in the certificate. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectUniqueID
				/// </java-name>
				public abstract bool[] SubjectUniqueID
				{
						[Dot42.DexImport("getSubjectUniqueID", "()[Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>KeyUsage </c> extension as a <c>boolean </c> array. </para> <para>The ASN.1 definition of <c>KeyUsage </c> :</para> <para> <pre>
				/// KeyUsage ::= BIT STRING {
				///      digitalSignature        (0),
				///      nonRepudiation          (1),
				///      keyEncipherment         (2),
				///      dataEncipherment        (3),
				///      keyAgreement            (4),
				///      keyCertSign             (5),
				///      cRLSign                 (6),
				///      encipherOnly            (7),
				///      decipherOnly            (8) }</pre></para> <para> <pre></pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>KeyUsage </c> extension or <c>null </c> if there's none in the certificate. </para>
				/// </returns>
				/// <java-name>
				/// getKeyUsage
				/// </java-name>
				public abstract bool[] KeyUsage
				{
						[Dot42.DexImport("getKeyUsage", "()[Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a read-only list of OID strings representing the <c>ExtKeyUsageSyntax </c> field of the extended key usage extension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the extended key usage extension, or <c>null </c> if there's none in the certificate. </para>
				/// </returns>
				/// <java-name>
				/// getExtendedKeyUsage
				/// </java-name>
				public virtual global::Java.Util.IList<string> ExtendedKeyUsage
				{
						[Dot42.DexImport("getExtendedKeyUsage", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IList<string>); }
				}

				/// <summary>
				///  <para>Returns the path length of the certificate constraints from the <c>BasicContraints </c> extension.</para> <para>If the certificate has no basic constraints or is not a certificate authority, <c>-1 </c> is returned. If the certificate is a certificate authority without a path length,  <c>Integer.MAX_VALUE </c> is returned. Otherwise, the certificate authority's path length is returned. </para>        
				/// </summary>
				/// <java-name>
				/// getBasicConstraints
				/// </java-name>
				public abstract int BasicConstraints
				{
						[Dot42.DexImport("getBasicConstraints", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns a read-only list of the subject alternative names from the  <c>SubjectAltName </c> extension. </para> <para>The ASN.1 definition of <c>SubjectAltName </c> :</para> <para> <pre>
				/// SubjectAltName ::= GeneralNames</pre></para> <para> <pre>GeneralNames ::= SEQUENCE SIZE (1..MAX) OF GeneralName</pre></para> <para> <pre>GeneralName ::= CHOICE {
				///      otherName                       [0]     AnotherName,
				///      rfc822Name                      [1]     IA5String,
				///      dNSName                         [2]     IA5String,
				///      x400Address                     [3]     ORAddress,
				///      directoryName                   [4]     Name,
				///      ediPartyName                    [5]     EDIPartyName,
				///      uniformResourceIdentifier       [6]     IA5String,
				///      iPAddress                       [7]     OCTET STRING,
				///      registeredID                    [8]     OBJECT IDENTIFIER }</pre></para> <para> <pre></pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject alternative names or <c>null </c> if there are none in the certificate. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectAlternativeNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Java.Util.IList<object>> SubjectAlternativeNames
				{
						[Dot42.DexImport("getSubjectAlternativeNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/util/List<*>;>;")]
						get{ return default(global::Java.Util.ICollection<global::Java.Util.IList<object>>); }
				}

				/// <summary>
				///  <para>Returns a read-only list of the issuer alternative names from the <c>IssuerAltName </c> extension. </para> <para>The ASN.1 definition of <c>IssuerAltName </c> :</para> <para> <pre>
				/// IssuerAltName ::= GeneralNames</pre></para> <para> <pre>GeneralNames ::= SEQUENCE SIZE (1..MAX) OF GeneralName</pre></para> <para> <pre>GeneralName ::= CHOICE {
				///      otherName                       [0]     AnotherName,
				///      rfc822Name                      [1]     IA5String,
				///      dNSName                         [2]     IA5String,
				///      x400Address                     [3]     ORAddress,
				///      directoryName                   [4]     Name,
				///      ediPartyName                    [5]     EDIPartyName,
				///      uniformResourceIdentifier       [6]     IA5String,
				///      iPAddress                       [7]     OCTET STRING,
				///      registeredID                    [8]     OBJECT IDENTIFIER }</pre></para> <para> <pre></pre></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the issuer alternative names of <c>null </c> if there are none in the certificate. </para>
				/// </returns>
				/// <java-name>
				/// getIssuerAlternativeNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Java.Util.IList<object>> IssuerAlternativeNames
				{
						[Dot42.DexImport("getIssuerAlternativeNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/util/List<*>;>;")]
						get{ return default(global::Java.Util.ICollection<global::Java.Util.IList<object>>); }
				}

				public virtual global::Java.Util.ISet<string> CriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual global::Java.Util.ISet<string> NonCriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual bool HasUnsupportedCriticalExtension
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "hasUnsupportedCriticalExtension", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A certificate selector ( <c>CertSelector </c> for selecting <c>X509Certificate </c> s that match the specified criteria. </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/X509CertSelector
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509CertSelector", AccessFlags = 33)]
		public partial class X509CertSelector : global::Java.Security.Cert.ICertSelector
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>X509CertSelector </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public X509CertSelector() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the issuer that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setIssuer
				/// </java-name>
				[Dot42.DexImport("setIssuer", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetIssuer(string issuer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the issuer that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setIssuer
				/// </java-name>
				[Dot42.DexImport("setIssuer", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetIssuer(sbyte[] issuer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the issuer that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setIssuer
				/// </java-name>
				[Dot42.DexImport("setIssuer", "([B)V", AccessFlags = 1)]
				public virtual void SetIssuer(byte[] issuer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the issuer that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the distinguished issuer name in ASN.1 DER encoded format, or  <c>null </c> if the issuer is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getIssuerAsBytes
				/// </java-name>
				[Dot42.DexImport("getIssuerAsBytes", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetIssuerAsBytes() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Set the subject that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSubject
				/// </java-name>
				[Dot42.DexImport("setSubject", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSubject(string subject) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the subject that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSubject
				/// </java-name>
				[Dot42.DexImport("setSubject", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetSubject(sbyte[] subject) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the subject that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSubject
				/// </java-name>
				[Dot42.DexImport("setSubject", "([B)V", AccessFlags = 1)]
				public virtual void SetSubject(byte[] subject) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the subject that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject distinguished name in ASN.1 DER format, or <c>null </c> if the subject is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectAsBytes
				/// </java-name>
				[Dot42.DexImport("getSubjectAsBytes", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetSubjectAsBytes() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Sets the criterion for the { SubjectKeyIdentifier} extension. </para> <para>The <c>subjectKeyIdentifier </c> should be a single DER encoded value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSubjectKeyIdentifier
				/// </java-name>
				[Dot42.DexImport("setSubjectKeyIdentifier", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetSubjectKeyIdentifier(sbyte[] subjectKeyIdentifier) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the criterion for the { SubjectKeyIdentifier} extension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject key identifier or <c>null </c> if it is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectKeyIdentifier
				/// </java-name>
				[Dot42.DexImport("getSubjectKeyIdentifier", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetSubjectKeyIdentifier() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Sets the criterion for the { AuthorityKeyIdentifier} extension.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setAuthorityKeyIdentifier
				/// </java-name>
				[Dot42.DexImport("setAuthorityKeyIdentifier", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetAuthorityKeyIdentifier(sbyte[] authorityKeyIdentifier) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the criterion for the { AuthorityKeyIdentifier} extension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the authority key identifier, or <c>null </c> if it is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getAuthorityKeyIdentifier
				/// </java-name>
				[Dot42.DexImport("getAuthorityKeyIdentifier", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetAuthorityKeyIdentifier() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <summary>
				///  <para>Sets the criterion for the subject public key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSubjectPublicKey
				/// </java-name>
				[Dot42.DexImport("setSubjectPublicKey", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetSubjectPublicKey(sbyte[] key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the criterion for the subject public key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setSubjectPublicKey
				/// </java-name>
				[Dot42.DexImport("setSubjectPublicKey", "([B)V", AccessFlags = 1)]
				public virtual void SetSubjectPublicKey(byte[] key) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSubjectAlternativeName
				/// </java-name>
				[Dot42.DexImport("addSubjectAlternativeName", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddSubjectAlternativeName(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSubjectAlternativeName
				/// </java-name>
				[Dot42.DexImport("addSubjectAlternativeName", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddSubjectAlternativeName(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSubjectAlternativeName
				/// </java-name>
				[Dot42.DexImport("addSubjectAlternativeName", "(I[B)V", AccessFlags = 1)]
				public virtual void AddSubjectAlternativeName(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the criterion for the name constraints. </para> <para>The certificate must constraint subject and subject alternative names that match the specified name constraints. </para> <para>The name constraints in ASN.1:</para> <para> <pre>
				/// NameConstraints ::= SEQUENCE {
				///        permittedSubtrees       [0]     GeneralSubtrees OPTIONAL,
				///        excludedSubtrees        [1]     GeneralSubtrees OPTIONAL }</pre></para> <para> <pre>GeneralSubtrees ::= SEQUENCE SIZE (1..MAX) OF GeneralSubtree</pre></para> <para> <pre>GeneralSubtree ::= SEQUENCE {
				///        base                    GeneralName,
				///        minimum         [0]     BaseDistance DEFAULT 0,
				///        maximum         [1]     BaseDistance OPTIONAL }</pre></para> <para> <pre>BaseDistance ::= INTEGER (0..MAX)</pre></para> <para> <pre>GeneralName ::= CHOICE {
				///        otherName                       [0]     OtherName,
				///        rfc822Name                      [1]     IA5String,
				///        dNSName                         [2]     IA5String,
				///        x400Address                     [3]     ORAddress,
				///        directoryName                   [4]     Name,
				///        ediPartyName                    [5]     EDIPartyName,
				///        uniformResourceIdentifier       [6]     IA5String,
				///        iPAddress                       [7]     OCTET STRING,
				///        registeredID                    [8]     OBJECT IDENTIFIER}</pre></para> <para> <pre></pre></para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setNameConstraints
				/// </java-name>
				[Dot42.DexImport("setNameConstraints", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetNameConstraints(sbyte[] bytes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the criterion for the name constraints.</para> <para> <para>setNameConstraints </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name constraints or <c>null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getNameConstraints
				/// </java-name>
				[Dot42.DexImport("getNameConstraints", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual sbyte[] JavaGetNameConstraints() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// addPathToName
				/// </java-name>
				[Dot42.DexImport("addPathToName", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddPathToName(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPathToName
				/// </java-name>
				[Dot42.DexImport("addPathToName", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddPathToName(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPathToName
				/// </java-name>
				[Dot42.DexImport("addPathToName", "(I[B)V", AccessFlags = 1)]
				public virtual void AddPathToName(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string representation of this <c>X509CertSelector </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this <c>X509CertSelector </c> instance. </para>
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
				///  <para>Returns whether the specified certificate matches all the criteria collected in this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the certificate matches all the criteria, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/security/cert/Certificate;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Clones this <c>X509CertSelector </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the certificate that a matching certificate must be equal to.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate to match, or null if this criteria is not checked. </para>
				/// </returns>
				/// <java-name>
				/// getCertificate
				/// </java-name>
				public virtual global::Java.Security.Cert.X509Certificate Certificate
				{
						[Dot42.DexImport("getCertificate", "()Ljava/security/cert/X509Certificate;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.X509Certificate); }
						[Dot42.DexImport("setCertificate", "(Ljava/security/cert/X509Certificate;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the serial number that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the serial number to match, or <c>null </c> if the serial number is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public virtual global::Java.Math.BigInteger SerialNumber
				{
						[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
						[Dot42.DexImport("setSerialNumber", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the issuer that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the issuer that a certificate must match, or <c>null </c> if the issuer is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getIssuer
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal Issuer
				{
						[Dot42.DexImport("getIssuer", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
						[Dot42.DexImport("setIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <b>Do not use</b>, use getIssuer() or getIssuerAsBytes() instead. Returns the issuer that a certificate must match in a RFC 2253 format string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the issuer in a RFC 2253 format string, or <c>null </c> if the issuer is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getIssuerAsString
				/// </java-name>
				public virtual string IssuerAsString
				{
						[Dot42.DexImport("getIssuerAsString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the issuer that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the distinguished issuer name in ASN.1 DER encoded format, or  <c>null </c> if the issuer is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getIssuerAsBytes
				/// </java-name>
				public virtual byte[] IssuerAsBytes
				{
						[Dot42.DexImport("getIssuerAsBytes", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the subject that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject distinguished name, or null if the subject is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSubject
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal Subject
				{
						[Dot42.DexImport("getSubject", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
						[Dot42.DexImport("setSubject", "(Ljavax/security/auth/x500/X500Principal;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para> <b>Do not use</b>, use getSubject() or getSubjectAsBytes() instead. Returns the subject that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject distinguished name in RFC 2253 format, or <c>null </c> if the subject is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectAsString
				/// </java-name>
				public virtual string SubjectAsString
				{
						[Dot42.DexImport("getSubjectAsString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the subject that a certificate must match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject distinguished name in ASN.1 DER format, or <c>null </c> if the subject is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectAsBytes
				/// </java-name>
				public virtual byte[] SubjectAsBytes
				{
						[Dot42.DexImport("getSubjectAsBytes", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
				}

				/// <summary>
				///  <para>Returns the criterion for the { SubjectKeyIdentifier} extension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject key identifier or <c>null </c> if it is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectKeyIdentifier
				/// </java-name>
				public virtual byte[] SubjectKeyIdentifier
				{
						[Dot42.DexImport("getSubjectKeyIdentifier", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
						[Dot42.DexImport("setSubjectKeyIdentifier", "([B)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the { AuthorityKeyIdentifier} extension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the authority key identifier, or <c>null </c> if it is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getAuthorityKeyIdentifier
				/// </java-name>
				public virtual byte[] AuthorityKeyIdentifier
				{
						[Dot42.DexImport("getAuthorityKeyIdentifier", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
						[Dot42.DexImport("setAuthorityKeyIdentifier", "([B)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the validity date of the certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the validity date or <c>null </c> if the date is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getCertificateValid
				/// </java-name>
				public virtual global::Java.Util.Date CertificateValid
				{
						[Dot42.DexImport("getCertificateValid", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setCertificateValid", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the validity date of the private key. </para> <para>The private key must be valid at the specified date.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the validity date or <c>null </c> if the date is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getPrivateKeyValid
				/// </java-name>
				public virtual global::Java.Util.Date PrivateKeyValid
				{
						[Dot42.DexImport("getPrivateKeyValid", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setPrivateKeyValid", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the subject public key signature algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the OID (object identifier) or the signature algorithm or <c>null </c> if it's not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectPublicKeyAlgID
				/// </java-name>
				public virtual string SubjectPublicKeyAlgID
				{
						[Dot42.DexImport("getSubjectPublicKeyAlgID", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSubjectPublicKeyAlgID", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the subject public key.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the subject public key or <c>null </c> if the key is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectPublicKey
				/// </java-name>
				public virtual global::Java.Security.IPublicKey SubjectPublicKey
				{
						[Dot42.DexImport("getSubjectPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPublicKey); }
						[Dot42.DexImport("setSubjectPublicKey", "(Ljava/security/PublicKey;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the { KeyUsage} extension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the boolean array in the format as returned by X509Certificate#getKeyUsage(), or <c>null </c> if the key usage is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getKeyUsage
				/// </java-name>
				public virtual bool[] KeyUsage
				{
						[Dot42.DexImport("getKeyUsage", "()[Z", AccessFlags = 1)]
						get{ return default(bool[]); }
						[Dot42.DexImport("setKeyUsage", "([Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the { ExtendedKeyUsage} extension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the set of key usage OIDs, or <c>null </c> if it's not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getExtendedKeyUsage
				/// </java-name>
				public virtual global::Java.Util.ISet<string> ExtendedKeyUsage
				{
						[Dot42.DexImport("getExtendedKeyUsage", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
						[Dot42.DexImport("setExtendedKeyUsage", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns the flag for the matching behavior for subject alternative names. </para> <para>The flag indicates whether a certificate must contain all or at least one of the subject alternative names specified by setSubjectAlternativeNames or addSubjectAlternativeName.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if a certificate must contain all of the specified subject alternative names, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// getMatchAllSubjectAltNames
				/// </java-name>
				public virtual bool MatchAllSubjectAltNames
				{
						[Dot42.DexImport("getMatchAllSubjectAltNames", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setMatchAllSubjectAltNames", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for subject alternative names. </para> <para>the certificate must contain all or at least one of the specified subject alternative names. The behavior is specified by getMatchAllSubjectAltNames. </para> <para>The subject alternative names is a collection with an entry for each name included in the criterion. The name is specified as a <c>List </c> , the first entry is an <c>Integer </c> specifying the name type (0-8), the second entry is byte array specifying the name in ASN.1 DER encoded form)</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the names collection or <c>null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getSubjectAlternativeNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Java.Util.IList<object>> SubjectAlternativeNames
				{
						[Dot42.DexImport("getSubjectAlternativeNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/util/List<*>;>;")]
						get{ return default(global::Java.Util.ICollection<global::Java.Util.IList<object>>); }
						[Dot42.DexImport("setSubjectAlternativeNames", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Ljava/util/List<*>;>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the name constraints.</para> <para> <para>setNameConstraints </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name constraints or <c>null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getNameConstraints
				/// </java-name>
				public virtual byte[] NameConstraints
				{
						[Dot42.DexImport("getNameConstraints", "()[B", AccessFlags = 1)]
						get{ return default(byte[]); }
						[Dot42.DexImport("setNameConstraints", "([B)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the basic constraints extension. </para> <para>A value greater than or equal to zero indicates that a certificate must include a basic constraints extension with a path length of a least that value. A value of <c>-2 </c> indicates that only end-entity certificates are accepted. A value of <c>-1 </c> indicates that no check is done.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the value of the criterion. </para>
				/// </returns>
				/// <java-name>
				/// getBasicConstraints
				/// </java-name>
				public virtual int BasicConstraints
				{
						[Dot42.DexImport("getBasicConstraints", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setBasicConstraints", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the policy constraint. </para> <para>The certificate must have at least one of the certificate policy extensions. For an empty set the certificate must have at least some policies in its policy extension.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate policy OIDs, an empty set, or <c>null </c> if not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getPolicy
				/// </java-name>
				public virtual global::Java.Util.ISet<string> Policy
				{
						[Dot42.DexImport("getPolicy", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
						[Dot42.DexImport("setPolicy", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the pathToNames constraint. </para> <para>The constraint is a collection with an entry for each name to be included in the criterion. The name is specified as a <c>List </c> , the first entry is an <c>Integer </c> specifying the name type (0-8), the second entry is a byte array specifying the name in ASN.1 DER encoded form.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the pathToNames constraint or <c>null </c> if none specified. </para>
				/// </returns>
				/// <java-name>
				/// getPathToNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Java.Util.IList<object>> PathToNames
				{
						[Dot42.DexImport("getPathToNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/util/List<*>;>;")]
						get{ return default(global::Java.Util.ICollection<global::Java.Util.IList<object>>); }
						[Dot42.DexImport("setPathToNames", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Ljava/util/List<*>;>;)V")]
						set{ }
				}

		}

		/// <summary>
		///  <para>Abstract base class for X.509 certificate revocation lists (CRL). </para> <para>More information regarding CRL can be found in RFC 2459, "Internet X.509 Public Key Infrastructure Certificate and CRL Profile" at . </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/X509CRL
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509CRL", AccessFlags = 1057)]
		public abstract partial class X509CRL : global::Java.Security.Cert.CRL, global::Java.Security.Cert.IX509Extension
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>X509CRL </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal X509CRL() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the specified object equals to this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object is equal to this, otherwise  <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the hashcode of this CRL instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hashcode. </para>
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
				///  <para>Verifies this CRL by verifying that this CRL was signed with the corresponding private key to the specified public key.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey key) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Verifies this CRL by verifying that this CRL was signed with the corresponding private key to the specified public key. The signature verification engine of the specified provider will be used.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey key, string sigProvider) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the CRL entry with the specified certificate serial number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the entry for the specified certificate serial number, or <c>null </c> if not found. </para>
				/// </returns>
				/// <java-name>
				/// getRevokedCertificate
				/// </java-name>
				[Dot42.DexImport("getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.X509CRLEntry GetRevokedCertificate(global::Java.Math.BigInteger serialNumber) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the CRL entry with the specified certificate serial number.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the entry for the specified certificate serial number, or <c>null </c> if not found. </para>
				/// </returns>
				/// <java-name>
				/// getRevokedCertificate
				/// </java-name>
				[Dot42.DexImport("getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.X509CRLEntry GetRevokedCertificate(global::Java.Security.Cert.X509Certificate serialNumber) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.X509CRLEntry);
				}

				[Dot42.DexImport("java/security/cert/X509Extension", "getExtensionValue", "(Ljava/lang/String;)[B", AccessFlags = 1025)]
				public virtual byte[] GetExtensionValue(string oid) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns this CRL in ASN.1 DER encoded form.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>this CRL in ASN.1 DER encoded form. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the version number of this CRL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the version number of this CRL. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public abstract int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para> <b>Do not use</b>, use getIssuerX500Principal() instead. Returns the issuer as an implementation specific Principal object.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the issuer distinguished name. </para>
				/// </returns>
				/// <java-name>
				/// getIssuerDN
				/// </java-name>
				public abstract global::Java.Security.IPrincipal IssuerDN
				{
						[Dot42.DexImport("getIssuerDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the issuer distinguished name of this CRL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the issuer distinguished name of this CRL. </para>
				/// </returns>
				/// <java-name>
				/// getIssuerX500Principal
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal IssuerX500Principal
				{
						[Dot42.DexImport("getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <summary>
				///  <para>Returns the <c>thisUpdate </c> value of this CRL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>thisUpdate </c> value of this CRL. </para>
				/// </returns>
				/// <java-name>
				/// getThisUpdate
				/// </java-name>
				public abstract global::Java.Util.Date ThisUpdate
				{
						[Dot42.DexImport("getThisUpdate", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>nextUpdate </c> value of this CRL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>nextUpdate </c> value of this CRL, or <c>null </c> if none is present. </para>
				/// </returns>
				/// <java-name>
				/// getNextUpdate
				/// </java-name>
				public abstract global::Java.Util.Date NextUpdate
				{
						[Dot42.DexImport("getNextUpdate", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the set of revoked certificates.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the set of revoked certificates, or <c>null </c> if no revoked certificates are in this CRL. </para>
				/// </returns>
				/// <java-name>
				/// getRevokedCertificates
				/// </java-name>
				public abstract global::Java.Util.ISet<global::Java.Security.Cert.X509CRLEntry> RevokedCertificates
				{
						[Dot42.DexImport("getRevokedCertificates", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<+Ljava/security/cert/X509CRLEntry;>;")]
						get;
				}

				/// <summary>
				///  <para>Returns the <c>tbsCertList </c> information of this CRL in DER encoded form.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the CRL information in DER encoded form. </para>
				/// </returns>
				/// <java-name>
				/// getTBSCertList
				/// </java-name>
				public abstract byte[] TBSCertList
				{
						[Dot42.DexImport("getTBSCertList", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the signature bytes of this CRL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the signature bytes of this CRL. </para>
				/// </returns>
				/// <java-name>
				/// getSignature
				/// </java-name>
				public abstract byte[] Signature
				{
						[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the name of the signature algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the name of the signature algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgName
				/// </java-name>
				public abstract string SigAlgName
				{
						[Dot42.DexImport("getSigAlgName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the OID of the signature algorithm.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the OID of the signature algorithm. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgOID
				/// </java-name>
				public abstract string SigAlgOID
				{
						[Dot42.DexImport("getSigAlgOID", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the parameters of the signature algorithm in DER encoded form.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parameters of the signature algorithm in DER encoded form, or  <c>null </c> if not present. </para>
				/// </returns>
				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				public abstract byte[] SigAlgParams
				{
						[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025)]
						get;
				}

				public virtual global::Java.Util.ISet<string> CriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual global::Java.Util.ISet<string> NonCriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual bool HasUnsupportedCriticalExtension
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "hasUnsupportedCriticalExtension", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Abstract base class for entries in a certificate revocation list (CRL).</para> <para> <para>X509CRL </para></para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/X509CRLEntry
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509CRLEntry", AccessFlags = 1057)]
		public abstract partial class X509CRLEntry : global::Java.Security.Cert.IX509Extension
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>X509CRLEntry </c> instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public X509CRLEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether the specified object equals to this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the specified object equals to this instance, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object other) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the hashcode of this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the hashcode of this instance. </para>
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
				///  <para>Returns a string representation of this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this instance. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[Dot42.DexImport("java/security/cert/X509Extension", "getExtensionValue", "(Ljava/lang/String;)[B", AccessFlags = 1025)]
				public virtual byte[] GetExtensionValue(string oid) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(byte[]);
				}

				/// <summary>
				///  <para>Returns this entry in ASN.1 DER encoded form.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded form of this entry. </para>
				/// </returns>
				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the serial number of the revoked certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the serial number of the revoked certificate. </para>
				/// </returns>
				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public abstract global::Java.Math.BigInteger SerialNumber
				{
						[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the issuer of the revoked certificate.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the issuer of the revoked certificate, or <c>null </c> if the issuer is equal to the CRL issuer. </para>
				/// </returns>
				/// <java-name>
				/// getCertificateIssuer
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal CertificateIssuer
				{
						[Dot42.DexImport("getCertificateIssuer", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <summary>
				///  <para>Returns the date when the certificate is revoked.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the date when the certificate is revoked. </para>
				/// </returns>
				/// <java-name>
				/// getRevocationDate
				/// </java-name>
				public abstract global::Java.Util.Date RevocationDate
				{
						[Dot42.DexImport("getRevocationDate", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns whether this CRL entry has extensions.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> is this CRL entry has extensions, otherwise <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// hasExtensions
				/// </java-name>
				public abstract bool HasExtensions
				{
						[Dot42.DexImport("hasExtensions", "()Z", AccessFlags = 1025)]
						get;
				}

				public virtual global::Java.Util.ISet<string> CriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual global::Java.Util.ISet<string> NonCriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual bool HasUnsupportedCriticalExtension
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "hasUnsupportedCriticalExtension", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>A CRL selector ( <c>CRLSelector </c> for selecting <c>X509CRL </c> s that match the specified criteria. </para> <para>When constructed, all criteria are set to default values that will match any  <c>X509CRL </c> . </para>    
		/// </summary>
		/// <java-name>
		/// java/security/cert/X509CRLSelector
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509CRLSelector", AccessFlags = 33)]
		public partial class X509CRLSelector : global::Java.Security.Cert.ICRLSelector
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new <c>X509CertSelector </c> . </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public X509CRLSelector() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds an issuer to the criterion for the issuer distinguished names. </para> <para>The CRL issuer must match at least one of the specified distinguished names.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addIssuer
				/// </java-name>
				[Dot42.DexImport("addIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", AccessFlags = 1)]
				public virtual void AddIssuer(global::Javax.Security.Auth.X500.X500Principal issuer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addIssuerName
				/// </java-name>
				[Dot42.DexImport("addIssuerName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddIssuerName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addIssuerName
				/// </java-name>
				[Dot42.DexImport("addIssuerName", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddIssuerName(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addIssuerName
				/// </java-name>
				[Dot42.DexImport("addIssuerName", "([B)V", AccessFlags = 1)]
				public virtual void AddIssuerName(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the criterion for the minimum CRL number. </para> <para>The CRL must have a number extension with a value greater than or equal to the specified parameter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMinCRLNumber
				/// </java-name>
				[Dot42.DexImport("setMinCRLNumber", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public virtual void SetMinCRLNumber(global::Java.Math.BigInteger minCRL) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the criterion for the maximum CRL number. </para> <para>The CRL must have a number extension with a value less than or equal to the specified parameter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxCRLNumber
				/// </java-name>
				[Dot42.DexImport("setMaxCRLNumber", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public virtual void SetMaxCRLNumber(global::Java.Math.BigInteger maxCRL) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a string representation of this <c>X509CRLSelector </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a string representation of this <c>X509CRLSelector </c> instance. </para>
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
				///  <para>Returns whether the specified CRL matches all the criteria collected in this instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if the CRL matches all the criteria, otherwise  <c>false </c> . </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/security/cert/CRL;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Java.Security.Cert.CRL crl) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Clones this <c>X509CRL </c> instance.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the cloned instance. </para>
				/// </returns>
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Returns the criterion for the issuer distinguished names. </para> <para>The CRL issuer must match at least one of the distinguished names.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the unmodifiable list of issuer distinguished names to match, or  <c>null </c> if any issuer distinguished name will do. </para>
				/// </returns>
				/// <java-name>
				/// getIssuers
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Javax.Security.Auth.X500.X500Principal> Issuers
				{
						[Dot42.DexImport("getIssuers", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljavax/security/auth/x500/X500Principal;>;")]
						get{ return default(global::Java.Util.ICollection<global::Javax.Security.Auth.X500.X500Principal>); }
						[Dot42.DexImport("setIssuers", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Ljavax/security/auth/x500/X500Principal;>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the issuer distinguished names. </para> <para>The CRL issuer must match at least one of the distinguished names.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a copy of the list of issuer distinguished names to match, or <c>null </c> if any issuer distinguished name will do. The elements may be strings or ASN.1 DER encoded byte arrays. </para>
				/// </returns>
				/// <java-name>
				/// getIssuerNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<object> IssuerNames
				{
						[Dot42.DexImport("getIssuerNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/lang/Object;>;")]
						get{ return default(global::Java.Util.ICollection<object>); }
						[Dot42.DexImport("setIssuerNames", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)V")]
						set{ }
				}

				/// <summary>
				///  <para>Returns the criterion for the minimum CRL number. </para> <para>The CRL must have a number extension with a value greater than or equal to the returned value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the minimum CRL number or <c>null </c> if the minimum CRL number is not to be checked. </para>
				/// </returns>
				/// <java-name>
				/// getMinCRL
				/// </java-name>
				public virtual global::Java.Math.BigInteger MinCRL
				{
						[Dot42.DexImport("getMinCRL", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <summary>
				///  <para>Returns the criterion for the maximum CRL number. </para> <para>The CRL must have a number extension with a value less than or equal to the returned value.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum CRL number or null if the maximum CRL number is not checked. </para>
				/// </returns>
				/// <java-name>
				/// getMaxCRL
				/// </java-name>
				public virtual global::Java.Math.BigInteger MaxCRL
				{
						[Dot42.DexImport("getMaxCRL", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <summary>
				///  <para>Returns the criterion for the CRL update period. </para> <para>The CRL's <c>thisUpdate </c> value must be equal or before the returned date and the <c>nextUpdate </c> value must be after the returned date.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the date to search for valid CRL's or <c>null </c> if the date is not checked. </para>
				/// </returns>
				/// <java-name>
				/// getDateAndTime
				/// </java-name>
				public virtual global::Java.Util.Date DateAndTime
				{
						[Dot42.DexImport("getDateAndTime", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setDateAndTime", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns the certificate hint to find CRLs. It's not a criterion but may help finding relevant CRLs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the certificate hint or <c>null </c> if none set. </para>
				/// </returns>
				/// <java-name>
				/// getCertificateChecking
				/// </java-name>
				public virtual global::Java.Security.Cert.X509Certificate CertificateChecking
				{
						[Dot42.DexImport("getCertificateChecking", "()Ljava/security/cert/X509Certificate;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.X509Certificate); }
						[Dot42.DexImport("setCertificateChecking", "(Ljava/security/cert/X509Certificate;)V", AccessFlags = 1)]
						set{ }
				}

		}

}

