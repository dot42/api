#pragma warning disable 1717
namespace Android.Net.Http
{
		/// <summary>
		///  <para>SSL certificate info (certificate details) class </para>    
		/// </summary>
		/// <java-name>
		/// android/net/http/SslCertificate
		/// </java-name>
		[Dot42.DexImport("android/net/http/SslCertificate", AccessFlags = 33)]
		public partial class SslCertificate
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public SslCertificate(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new SSL certificate object from an X509 certificate </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/security/cert/X509Certificate;)V", AccessFlags = 1)]
				public SslCertificate(global::Java.Security.Cert.X509Certificate certificate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Saves the certificate state to a bundle </para>        
				/// </summary>
				/// <returns>
				///  <para>A bundle with the certificate stored in it or null if fails </para>
				/// </returns>
				/// <java-name>
				/// saveState
				/// </java-name>
				[Dot42.DexImport("saveState", "(Landroid/net/http/SslCertificate;)Landroid/os/Bundle;", AccessFlags = 9)]
				public static global::Android.OS.Bundle SaveState(global::Android.Net.Http.SslCertificate certificate) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Restores the certificate stored in the bundle </para>        
				/// </summary>
				/// <returns>
				///  <para>The SSL certificate stored in the bundle or null if fails </para>
				/// </returns>
				/// <java-name>
				/// restoreState
				/// </java-name>
				[Dot42.DexImport("restoreState", "(Landroid/os/Bundle;)Landroid/net/http/SslCertificate;", AccessFlags = 9)]
				public static global::Android.Net.Http.SslCertificate RestoreState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Http.SslCertificate);
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A string representation of this certificate for debugging </para>
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
				protected internal SslCertificate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getValidNotBeforeDate() </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Not-before date from the certificate validity period in ISO 8601 format or "" if none has been set</para>
				/// </returns>
				/// <java-name>
				/// getValidNotBefore
				/// </java-name>
				public virtual string ValidNotBefore
				{
						[Dot42.DexImport("getValidNotBefore", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getValidNotAfterDate() </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Not-after date from the certificate validity period in ISO 8601 format or "" if none has been set</para>
				/// </returns>
				/// <java-name>
				/// getValidNotAfter
				/// </java-name>
				public virtual string ValidNotAfter
				{
						[Dot42.DexImport("getValidNotAfter", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Issued-to distinguished name or null if none has been set </para>
				/// </returns>
				/// <java-name>
				/// getIssuedTo
				/// </java-name>
				public virtual global::Android.Net.Http.SslCertificate.DName IssuedTo
				{
						[Dot42.DexImport("getIssuedTo", "()Landroid/net/http/SslCertificate$DName;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Http.SslCertificate.DName); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Issued-by distinguished name or null if none has been set </para>
				/// </returns>
				/// <java-name>
				/// getIssuedBy
				/// </java-name>
				public virtual global::Android.Net.Http.SslCertificate.DName IssuedBy
				{
						[Dot42.DexImport("getIssuedBy", "()Landroid/net/http/SslCertificate$DName;", AccessFlags = 1)]
						get{ return default(global::Android.Net.Http.SslCertificate.DName); }
				}

				/// <summary>
				///  <para>A distinguished name helper class: a 3-tuple of:  <ul> <li> <para>the most specific common name (CN) </para></li> <li> <para>the most specific organization (O) </para></li> <li> <para>the most specific organizational unit (OU)  <ul> <li></li></ul></para></li></ul></para>    
				/// </summary>
				/// <java-name>
				/// android/net/http/SslCertificate$DName
				/// </java-name>
				[Dot42.DexImport("android/net/http/SslCertificate$DName", AccessFlags = 1)]
				public partial class DName
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/net/http/SslCertificate;", AccessFlags = 4112)]
						internal readonly global::Android.Net.Http.SslCertificate This_0;
						[Dot42.DexImport("<init>", "(Landroid/net/http/SslCertificate;Ljava/lang/String;)V", AccessFlags = 1)]
						public DName(global::Android.Net.Http.SslCertificate sslCertificate, string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The distinguished name (normally includes CN, O, and OU names) </para>
						/// </returns>
						/// <java-name>
						/// getDName
						/// </java-name>
						[Dot42.DexImport("getDName", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string GetDName() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						protected internal DName() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The most specific Common-name (CN) component of this name </para>
						/// </returns>
						/// <java-name>
						/// getCName
						/// </java-name>
						public virtual string CName
						{
								[Dot42.DexImport("getCName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The most specific Organization (O) component of this name </para>
						/// </returns>
						/// <java-name>
						/// getOName
						/// </java-name>
						public virtual string OName
						{
								[Dot42.DexImport("getOName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The most specific Organizational Unit (OU) component of this name </para>
						/// </returns>
						/// <java-name>
						/// getUName
						/// </java-name>
						public virtual string UName
						{
								[Dot42.DexImport("getUName", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

				}

		}

}

