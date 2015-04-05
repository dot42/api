#pragma warning disable 1717
namespace Javax.Security.Cert
{
		/// <java-name>
		/// javax/security/cert/Certificate
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/Certificate", AccessFlags = 1057)]
		public abstract partial class Certificate
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Certificate() /* MethodBuilder.Create */ 
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey publicKey, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getPublicKey
				/// </java-name>
				public abstract global::Java.Security.IPublicKey PublicKey
				{
						[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// javax/security/cert/CertificateEncodingException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateEncodingException", AccessFlags = 33)]
		public partial class CertificateEncodingException : global::Javax.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateEncodingException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateEncodingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/security/cert/CertificateException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateException", AccessFlags = 33)]
		public partial class CertificateException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/security/cert/CertificateExpiredException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateExpiredException", AccessFlags = 33)]
		public partial class CertificateExpiredException : global::Javax.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateExpiredException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateExpiredException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/security/cert/CertificateNotYetValidException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateNotYetValidException", AccessFlags = 33)]
		public partial class CertificateNotYetValidException : global::Javax.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateNotYetValidException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateNotYetValidException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/security/cert/CertificateParsingException
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/CertificateParsingException", AccessFlags = 33)]
		public partial class CertificateParsingException : global::Javax.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateParsingException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateParsingException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// javax/security/cert/X509Certificate
		/// </java-name>
		[Dot42.DexImport("javax/security/cert/X509Certificate", AccessFlags = 1057)]
		public abstract partial class X509Certificate : global::Javax.Security.Cert.Certificate
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public X509Certificate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/io/InputStream;)Ljavax/security/cert/X509Certificate;", AccessFlags = 25)]
				public static global::Javax.Security.Cert.X509Certificate GetInstance(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Cert.X509Certificate);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "([B)Ljavax/security/cert/X509Certificate;", AccessFlags = 25)]
				public static global::Javax.Security.Cert.X509Certificate GetInstance(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Cert.X509Certificate);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "([B)Ljavax/security/cert/X509Certificate;", AccessFlags = 25, IgnoreFromJava = true)]
				public static global::Javax.Security.Cert.X509Certificate GetInstance(byte[] @byte) /* MethodBuilder.Create */ 
				{
						return default(global::Javax.Security.Cert.X509Certificate);
				}

				/// <java-name>
				/// checkValidity
				/// </java-name>
				[Dot42.DexImport("checkValidity", "()V", AccessFlags = 1025)]
				public abstract void CheckValidity() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkValidity
				/// </java-name>
				[Dot42.DexImport("checkValidity", "(Ljava/util/Date;)V", AccessFlags = 1025)]
				public abstract void CheckValidity(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetSigAlgParams() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getVersion
				/// </java-name>
				public abstract int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public abstract global::Java.Math.BigInteger SerialNumber
				{
						[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getIssuerDN
				/// </java-name>
				public abstract global::Java.Security.IPrincipal IssuerDN
				{
						[Dot42.DexImport("getIssuerDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSubjectDN
				/// </java-name>
				public abstract global::Java.Security.IPrincipal SubjectDN
				{
						[Dot42.DexImport("getSubjectDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNotBefore
				/// </java-name>
				public abstract global::Java.Util.Date NotBefore
				{
						[Dot42.DexImport("getNotBefore", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNotAfter
				/// </java-name>
				public abstract global::Java.Util.Date NotAfter
				{
						[Dot42.DexImport("getNotAfter", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSigAlgName
				/// </java-name>
				public abstract string SigAlgName
				{
						[Dot42.DexImport("getSigAlgName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSigAlgOID
				/// </java-name>
				public abstract string SigAlgOID
				{
						[Dot42.DexImport("getSigAlgOID", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				public abstract byte[] SigAlgParams
				{
						[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

		}

}

