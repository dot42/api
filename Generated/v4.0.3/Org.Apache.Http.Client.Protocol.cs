#pragma warning disable 1717
namespace Org.Apache.Http.Client.Protocol
{
		/// <java-name>
		/// org/apache/http/client/protocol/RequestDefaultHeaders
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/protocol/RequestDefaultHeaders", AccessFlags = 33)]
		public partial class RequestDefaultHeaders : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestDefaultHeaders() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/protocol/ResponseProcessCookies
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/protocol/ResponseProcessCookies", AccessFlags = 33)]
		public partial class ResponseProcessCookies : global::Org.Apache.Http.IHttpResponseInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ResponseProcessCookies() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpResponse httpResponse, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/protocol/RequestProxyAuthentication
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/protocol/RequestProxyAuthentication", AccessFlags = 33)]
		public partial class RequestProxyAuthentication : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestProxyAuthentication() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/protocol/RequestTargetAuthentication
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/protocol/RequestTargetAuthentication", AccessFlags = 33)]
		public partial class RequestTargetAuthentication : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestTargetAuthentication() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/protocol/RequestAddCookies
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/protocol/RequestAddCookies", AccessFlags = 33)]
		public partial class RequestAddCookies : global::Org.Apache.Http.IHttpRequestInterceptor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RequestAddCookies() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// process
				/// </java-name>
				[Dot42.DexImport("process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public virtual void Process(global::Org.Apache.Http.IHttpRequest httpRequest, global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/protocol/ClientContextConfigurer
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/protocol/ClientContextConfigurer", AccessFlags = 33)]
		public partial class ClientContextConfigurer : global::Org.Apache.Http.Client.Protocol.IClientContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/protocol/HttpContext;)V", AccessFlags = 1)]
				public ClientContextConfigurer(global::Org.Apache.Http.Protocol.IHttpContext httpContext) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCookieSpecRegistry
				/// </java-name>
				[Dot42.DexImport("setCookieSpecRegistry", "(Lorg/apache/http/cookie/CookieSpecRegistry;)V", AccessFlags = 1)]
				public virtual void SetCookieSpecRegistry(global::Org.Apache.Http.Cookie.CookieSpecRegistry cookieSpecRegistry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAuthSchemeRegistry
				/// </java-name>
				[Dot42.DexImport("setAuthSchemeRegistry", "(Lorg/apache/http/auth/AuthSchemeRegistry;)V", AccessFlags = 1)]
				public virtual void SetAuthSchemeRegistry(global::Org.Apache.Http.Auth.AuthSchemeRegistry authSchemeRegistry) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCookieStore
				/// </java-name>
				[Dot42.DexImport("setCookieStore", "(Lorg/apache/http/client/CookieStore;)V", AccessFlags = 1)]
				public virtual void SetCookieStore(global::Org.Apache.Http.Client.ICookieStore cookieStore) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCredentialsProvider
				/// </java-name>
				[Dot42.DexImport("setCredentialsProvider", "(Lorg/apache/http/client/CredentialsProvider;)V", AccessFlags = 1)]
				public virtual void SetCredentialsProvider(global::Org.Apache.Http.Client.ICredentialsProvider credentialsProvider) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAuthSchemePref
				/// </java-name>
				[Dot42.DexImport("setAuthSchemePref", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/lang/String;>;)V")]
				public virtual void SetAuthSchemePref(global::Java.Util.IList<string> list) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ClientContextConfigurer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/protocol/ClientContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/protocol/ClientContext", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IClientContextConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// COOKIESPEC_REGISTRY
				/// </java-name>
				[Dot42.DexImport("COOKIESPEC_REGISTRY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COOKIESPEC_REGISTRY = "http.cookiespec-registry";
				/// <java-name>
				/// AUTHSCHEME_REGISTRY
				/// </java-name>
				[Dot42.DexImport("AUTHSCHEME_REGISTRY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTHSCHEME_REGISTRY = "http.authscheme-registry";
				/// <java-name>
				/// COOKIE_STORE
				/// </java-name>
				[Dot42.DexImport("COOKIE_STORE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COOKIE_STORE = "http.cookie-store";
				/// <java-name>
				/// COOKIE_SPEC
				/// </java-name>
				[Dot42.DexImport("COOKIE_SPEC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COOKIE_SPEC = "http.cookie-spec";
				/// <java-name>
				/// COOKIE_ORIGIN
				/// </java-name>
				[Dot42.DexImport("COOKIE_ORIGIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COOKIE_ORIGIN = "http.cookie-origin";
				/// <java-name>
				/// CREDS_PROVIDER
				/// </java-name>
				[Dot42.DexImport("CREDS_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CREDS_PROVIDER = "http.auth.credentials-provider";
				/// <java-name>
				/// TARGET_AUTH_STATE
				/// </java-name>
				[Dot42.DexImport("TARGET_AUTH_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string TARGET_AUTH_STATE = "http.auth.target-scope";
				/// <java-name>
				/// PROXY_AUTH_STATE
				/// </java-name>
				[Dot42.DexImport("PROXY_AUTH_STATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROXY_AUTH_STATE = "http.auth.proxy-scope";
				/// <java-name>
				/// AUTH_SCHEME_PREF
				/// </java-name>
				[Dot42.DexImport("AUTH_SCHEME_PREF", "Ljava/lang/String;", AccessFlags = 25)]
				public const string AUTH_SCHEME_PREF = "http.auth.scheme-pref";
				/// <java-name>
				/// USER_TOKEN
				/// </java-name>
				[Dot42.DexImport("USER_TOKEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string USER_TOKEN = "http.user-token";
		}

		/// <java-name>
		/// org/apache/http/client/protocol/ClientContext
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/protocol/ClientContext", AccessFlags = 1537)]
		public partial interface IClientContext
 /* scope: __dot42__ */ 
		{
		}

}

