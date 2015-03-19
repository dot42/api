#pragma warning disable 1717
namespace Org.Apache.Http.Cookie.Params
{
		/// <java-name>
		/// org/apache/http/cookie/params/CookieSpecParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/params/CookieSpecParamBean", AccessFlags = 33)]
		public partial class CookieSpecParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public CookieSpecParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDatePatterns
				/// </java-name>
				[Dot42.DexImport("setDatePatterns", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Ljava/lang/String;>;)V")]
				public virtual void SetDatePatterns(global::Java.Util.ICollection<string> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSingleHeader
				/// </java-name>
				[Dot42.DexImport("setSingleHeader", "(Z)V", AccessFlags = 1)]
				public virtual void SetSingleHeader(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CookieSpecParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/cookie/params/CookieSpecPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/params/CookieSpecPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICookieSpecPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DATE_PATTERNS
				/// </java-name>
				[Dot42.DexImport("DATE_PATTERNS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DATE_PATTERNS = "http.protocol.cookie-datepatterns";
				/// <java-name>
				/// SINGLE_COOKIE_HEADER
				/// </java-name>
				[Dot42.DexImport("SINGLE_COOKIE_HEADER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SINGLE_COOKIE_HEADER = "http.protocol.single-cookie-header";
		}

		/// <java-name>
		/// org/apache/http/cookie/params/CookieSpecPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/params/CookieSpecPNames", AccessFlags = 1537)]
		public partial interface ICookieSpecPNames
 /* scope: __dot42__ */ 
		{
		}

}

