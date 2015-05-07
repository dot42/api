#pragma warning disable 1717
namespace Org.Apache.Http.Auth.Params
{
		/// <java-name>
		/// org/apache/http/auth/params/AuthParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/params/AuthParamBean", AccessFlags = 33)]
		public partial class AuthParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public AuthParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCredentialCharset
				/// </java-name>
				[Dot42.DexImport("setCredentialCharset", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCredentialCharset(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AuthParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/auth/params/AuthParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/params/AuthParams", AccessFlags = 49)]
		public sealed partial class AuthParams
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AuthParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCredentialCharset
				/// </java-name>
				[Dot42.DexImport("getCredentialCharset", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCredentialCharset(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setCredentialCharset
				/// </java-name>
				[Dot42.DexImport("setCredentialCharset", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetCredentialCharset(global::Org.Apache.Http.Params.IHttpParams httpParams, string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/auth/params/AuthPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/params/AuthPNames", AccessFlags = 1537)]
		public partial interface IAuthPNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/auth/params/AuthPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/params/AuthPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IAuthPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREDENTIAL_CHARSET
				/// </java-name>
				[Dot42.DexImport("CREDENTIAL_CHARSET", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CREDENTIAL_CHARSET = "http.auth.credential-charset";
		}

}

