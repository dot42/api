#pragma warning disable 1717
namespace Org.Apache.Http.Client.Params
{
		/// <java-name>
		/// org/apache/http/client/params/HttpClientParams
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/HttpClientParams", AccessFlags = 33)]
		public partial class HttpClientParams
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HttpClientParams() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isRedirecting
				/// </java-name>
				[Dot42.DexImport("isRedirecting", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool IsRedirecting(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setRedirecting
				/// </java-name>
				[Dot42.DexImport("setRedirecting", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetRedirecting(global::Org.Apache.Http.Params.IHttpParams httpParams, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAuthenticating
				/// </java-name>
				[Dot42.DexImport("isAuthenticating", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool IsAuthenticating(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAuthenticating
				/// </java-name>
				[Dot42.DexImport("setAuthenticating", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetAuthenticating(global::Org.Apache.Http.Params.IHttpParams httpParams, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCookiePolicy
				/// </java-name>
				[Dot42.DexImport("getCookiePolicy", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCookiePolicy(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setCookiePolicy
				/// </java-name>
				[Dot42.DexImport("setCookiePolicy", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetCookiePolicy(global::Org.Apache.Http.Params.IHttpParams httpParams, string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/params/AuthPolicy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/AuthPolicy", AccessFlags = 49)]
		public sealed partial class AuthPolicy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NTLM
				/// </java-name>
				[Dot42.DexImport("NTLM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NTLM = "NTLM";
				/// <java-name>
				/// DIGEST
				/// </java-name>
				[Dot42.DexImport("DIGEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DIGEST = "Digest";
				/// <java-name>
				/// BASIC
				/// </java-name>
				[Dot42.DexImport("BASIC", "Ljava/lang/String;", AccessFlags = 25)]
				public const string BASIC = "Basic";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AuthPolicy() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/params/CookiePolicy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/CookiePolicy", AccessFlags = 49)]
		public sealed partial class CookiePolicy
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BROWSER_COMPATIBILITY
				/// </java-name>
				[Dot42.DexImport("BROWSER_COMPATIBILITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string BROWSER_COMPATIBILITY = "compatibility";
				/// <java-name>
				/// NETSCAPE
				/// </java-name>
				[Dot42.DexImport("NETSCAPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NETSCAPE = "netscape";
				/// <java-name>
				/// RFC_2109
				/// </java-name>
				[Dot42.DexImport("RFC_2109", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RFC_2109 = "rfc2109";
				/// <java-name>
				/// RFC_2965
				/// </java-name>
				[Dot42.DexImport("RFC_2965", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RFC_2965 = "rfc2965";
				/// <java-name>
				/// BEST_MATCH
				/// </java-name>
				[Dot42.DexImport("BEST_MATCH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string BEST_MATCH = "best-match";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CookiePolicy() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/params/ClientParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/ClientParamBean", AccessFlags = 33)]
		public partial class ClientParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ClientParamBean(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectionManagerFactoryClassName
				/// </java-name>
				[Dot42.DexImport("setConnectionManagerFactoryClassName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetConnectionManagerFactoryClassName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectionManagerFactory
				/// </java-name>
				[Dot42.DexImport("setConnectionManagerFactory", "(Lorg/apache/http/conn/ClientConnectionManagerFactory;)V", AccessFlags = 1)]
				public virtual void SetConnectionManagerFactory(global::Org.Apache.Http.Conn.IClientConnectionManagerFactory clientConnectionManagerFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHandleRedirects
				/// </java-name>
				[Dot42.DexImport("setHandleRedirects", "(Z)V", AccessFlags = 1)]
				public virtual void SetHandleRedirects(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRejectRelativeRedirect
				/// </java-name>
				[Dot42.DexImport("setRejectRelativeRedirect", "(Z)V", AccessFlags = 1)]
				public virtual void SetRejectRelativeRedirect(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxRedirects
				/// </java-name>
				[Dot42.DexImport("setMaxRedirects", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxRedirects(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAllowCircularRedirects
				/// </java-name>
				[Dot42.DexImport("setAllowCircularRedirects", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllowCircularRedirects(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHandleAuthentication
				/// </java-name>
				[Dot42.DexImport("setHandleAuthentication", "(Z)V", AccessFlags = 1)]
				public virtual void SetHandleAuthentication(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCookiePolicy
				/// </java-name>
				[Dot42.DexImport("setCookiePolicy", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCookiePolicy(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVirtualHost
				/// </java-name>
				[Dot42.DexImport("setVirtualHost", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public virtual void SetVirtualHost(global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultHeaders
				/// </java-name>
				[Dot42.DexImport("setDefaultHeaders", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Lorg/apache/http/Header;>;)V")]
				public virtual void SetDefaultHeaders(global::Java.Util.ICollection<global::Org.Apache.Http.IHeader> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultHost
				/// </java-name>
				[Dot42.DexImport("setDefaultHost", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public virtual void SetDefaultHost(global::Org.Apache.Http.HttpHost httpHost) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ClientParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/client/params/AllClientPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/AllClientPNames", AccessFlags = 1537)]
		public partial interface IAllClientPNames : global::Org.Apache.Http.Params.ICoreConnectionPNames, global::Org.Apache.Http.Params.ICoreProtocolPNames, global::Org.Apache.Http.Client.Params.IClientPNames, global::Org.Apache.Http.Auth.Params.IAuthPNames, global::Org.Apache.Http.Cookie.Params.ICookieSpecPNames, global::Org.Apache.Http.Conn.Params.IConnConnectionPNames, global::Org.Apache.Http.Conn.Params.IConnManagerPNames, global::Org.Apache.Http.Conn.Params.IConnRoutePNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/client/params/ClientPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/ClientPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IClientPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CONNECTION_MANAGER_FACTORY_CLASS_NAME
				/// </java-name>
				[Dot42.DexImport("CONNECTION_MANAGER_FACTORY_CLASS_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTION_MANAGER_FACTORY_CLASS_NAME = "http.connection-manager.factory-class-name";
				/// <java-name>
				/// CONNECTION_MANAGER_FACTORY
				/// </java-name>
				[Dot42.DexImport("CONNECTION_MANAGER_FACTORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTION_MANAGER_FACTORY = "http.connection-manager.factory-object";
				/// <java-name>
				/// HANDLE_REDIRECTS
				/// </java-name>
				[Dot42.DexImport("HANDLE_REDIRECTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HANDLE_REDIRECTS = "http.protocol.handle-redirects";
				/// <java-name>
				/// REJECT_RELATIVE_REDIRECT
				/// </java-name>
				[Dot42.DexImport("REJECT_RELATIVE_REDIRECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REJECT_RELATIVE_REDIRECT = "http.protocol.reject-relative-redirect";
				/// <java-name>
				/// MAX_REDIRECTS
				/// </java-name>
				[Dot42.DexImport("MAX_REDIRECTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_REDIRECTS = "http.protocol.max-redirects";
				/// <java-name>
				/// ALLOW_CIRCULAR_REDIRECTS
				/// </java-name>
				[Dot42.DexImport("ALLOW_CIRCULAR_REDIRECTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ALLOW_CIRCULAR_REDIRECTS = "http.protocol.allow-circular-redirects";
				/// <java-name>
				/// HANDLE_AUTHENTICATION
				/// </java-name>
				[Dot42.DexImport("HANDLE_AUTHENTICATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HANDLE_AUTHENTICATION = "http.protocol.handle-authentication";
				/// <java-name>
				/// COOKIE_POLICY
				/// </java-name>
				[Dot42.DexImport("COOKIE_POLICY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COOKIE_POLICY = "http.protocol.cookie-policy";
				/// <java-name>
				/// VIRTUAL_HOST
				/// </java-name>
				[Dot42.DexImport("VIRTUAL_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VIRTUAL_HOST = "http.virtual-host";
				/// <java-name>
				/// DEFAULT_HEADERS
				/// </java-name>
				[Dot42.DexImport("DEFAULT_HEADERS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_HEADERS = "http.default-headers";
				/// <java-name>
				/// DEFAULT_HOST
				/// </java-name>
				[Dot42.DexImport("DEFAULT_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_HOST = "http.default-host";
		}

		/// <java-name>
		/// org/apache/http/client/params/ClientPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/ClientPNames", AccessFlags = 1537)]
		public partial interface IClientPNames
 /* scope: __dot42__ */ 
		{
		}

}

