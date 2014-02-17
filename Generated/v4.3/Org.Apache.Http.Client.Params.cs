// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Client.Params.cs
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
namespace Org.Apache.Http.Client.Params
{
		/// <summary>
		/// <para>An adaptor for accessing HTTP client parameters in HttpParams.</para><para><para></para><para></para><title>Revision:</title><para>659595 </para></para><para><para>4.0 </para></para>    
		/// </summary>
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
				public static bool IsRedirecting(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setRedirecting
				/// </java-name>
				[Dot42.DexImport("setRedirecting", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetRedirecting(global::Org.Apache.Http.Params.IHttpParams @params, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAuthenticating
				/// </java-name>
				[Dot42.DexImport("isAuthenticating", "(Lorg/apache/http/params/HttpParams;)Z", AccessFlags = 9)]
				public static bool IsAuthenticating(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAuthenticating
				/// </java-name>
				[Dot42.DexImport("setAuthenticating", "(Lorg/apache/http/params/HttpParams;Z)V", AccessFlags = 9)]
				public static void SetAuthenticating(global::Org.Apache.Http.Params.IHttpParams @params, bool value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCookiePolicy
				/// </java-name>
				[Dot42.DexImport("getCookiePolicy", "(Lorg/apache/http/params/HttpParams;)Ljava/lang/String;", AccessFlags = 9)]
				public static string GetCookiePolicy(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setCookiePolicy
				/// </java-name>
				[Dot42.DexImport("setCookiePolicy", "(Lorg/apache/http/params/HttpParams;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void SetCookiePolicy(global::Org.Apache.Http.Params.IHttpParams @params, string cookiePolicy) /* MethodBuilder.Create */ 
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
				/// <summary>
				/// <para>The NTLM scheme is a proprietary Microsoft Windows Authentication protocol (considered to be the most secure among currently supported authentication schemes). </para>        
				/// </summary>
				/// <java-name>
				/// NTLM
				/// </java-name>
				[Dot42.DexImport("NTLM", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NTLM = "NTLM";
				/// <summary>
				/// <para>Digest authentication scheme as defined in RFC2617. </para>        
				/// </summary>
				/// <java-name>
				/// DIGEST
				/// </java-name>
				[Dot42.DexImport("DIGEST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DIGEST = "Digest";
				/// <summary>
				/// <para>Basic authentication scheme as defined in RFC2617 (considered inherently insecure, but most widely supported) </para>        
				/// </summary>
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

		/// <summary>
		/// <para>Parameter names for the HttpClient module. This does not include parameters for informational units HttpAuth, HttpCookie, or HttpConn.</para><para><para></para><title>Revision:</title><para>659595 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/params/ClientPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/ClientPNames", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IClientPNamesConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Defines the class name of the default org.apache.http.conn.ClientConnectionManager </para><para>This parameter expects a value of type String. </para>        
				/// </summary>
				/// <java-name>
				/// CONNECTION_MANAGER_FACTORY_CLASS_NAME
				/// </java-name>
				[Dot42.DexImport("CONNECTION_MANAGER_FACTORY_CLASS_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTION_MANAGER_FACTORY_CLASS_NAME = "http.connection-manager.factory-class-name";
				/// <summary>
				/// <para>Defines the factory to create a default org.apache.http.conn.ClientConnectionManager. </para><para>This parameters expects a value of type org.apache.http.conn.ClientConnectionManagerFactory. </para>        
				/// </summary>
				/// <java-name>
				/// CONNECTION_MANAGER_FACTORY
				/// </java-name>
				[Dot42.DexImport("CONNECTION_MANAGER_FACTORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string CONNECTION_MANAGER_FACTORY = "http.connection-manager.factory-object";
				/// <summary>
				/// <para>Defines whether redirects should be handled automatically </para><para>This parameter expects a value of type Boolean. </para>        
				/// </summary>
				/// <java-name>
				/// HANDLE_REDIRECTS
				/// </java-name>
				[Dot42.DexImport("HANDLE_REDIRECTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HANDLE_REDIRECTS = "http.protocol.handle-redirects";
				/// <summary>
				/// <para>Defines whether relative redirects should be rejected. </para><para>This parameter expects a value of type Boolean. </para>        
				/// </summary>
				/// <java-name>
				/// REJECT_RELATIVE_REDIRECT
				/// </java-name>
				[Dot42.DexImport("REJECT_RELATIVE_REDIRECT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string REJECT_RELATIVE_REDIRECT = "http.protocol.reject-relative-redirect";
				/// <summary>
				/// <para>Defines the maximum number of redirects to be followed. The limit on number of redirects is intended to prevent infinite loops. </para><para>This parameter expects a value of type Integer. </para>        
				/// </summary>
				/// <java-name>
				/// MAX_REDIRECTS
				/// </java-name>
				[Dot42.DexImport("MAX_REDIRECTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_REDIRECTS = "http.protocol.max-redirects";
				/// <summary>
				/// <para>Defines whether circular redirects (redirects to the same location) should be allowed. The HTTP spec is not sufficiently clear whether circular redirects are permitted, therefore optionally they can be enabled </para><para>This parameter expects a value of type Boolean. </para>        
				/// </summary>
				/// <java-name>
				/// ALLOW_CIRCULAR_REDIRECTS
				/// </java-name>
				[Dot42.DexImport("ALLOW_CIRCULAR_REDIRECTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ALLOW_CIRCULAR_REDIRECTS = "http.protocol.allow-circular-redirects";
				/// <summary>
				/// <para>Defines whether authentication should be handled automatically. </para><para>This parameter expects a value of type Boolean. </para>        
				/// </summary>
				/// <java-name>
				/// HANDLE_AUTHENTICATION
				/// </java-name>
				[Dot42.DexImport("HANDLE_AUTHENTICATION", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HANDLE_AUTHENTICATION = "http.protocol.handle-authentication";
				/// <summary>
				/// <para>Defines the name of the cookie specification to be used for HTTP state management. </para><para>This parameter expects a value of type String. </para>        
				/// </summary>
				/// <java-name>
				/// COOKIE_POLICY
				/// </java-name>
				[Dot42.DexImport("COOKIE_POLICY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COOKIE_POLICY = "http.protocol.cookie-policy";
				/// <summary>
				/// <para>Defines the virtual host name. </para><para>This parameter expects a value of type org.apache.http.HttpHost. </para>        
				/// </summary>
				/// <java-name>
				/// VIRTUAL_HOST
				/// </java-name>
				[Dot42.DexImport("VIRTUAL_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VIRTUAL_HOST = "http.virtual-host";
				/// <summary>
				/// <para>Defines the request headers to be sent per default with each request. </para><para>This parameter expects a value of type java.util.Collection. The collection is expected to contain org.apache.http.Headers. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_HEADERS
				/// </java-name>
				[Dot42.DexImport("DEFAULT_HEADERS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_HEADERS = "http.default-headers";
				/// <summary>
				/// <para>Defines the default host. The default value will be used if the target host is not explicitly specified in the request URI. </para><para>This parameter expects a value of type org.apache.http.HttpHost. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_HOST
				/// </java-name>
				[Dot42.DexImport("DEFAULT_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_HOST = "http.default-host";
		}

		/// <summary>
		/// <para>Parameter names for the HttpClient module. This does not include parameters for informational units HttpAuth, HttpCookie, or HttpConn.</para><para><para></para><title>Revision:</title><para>659595 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/params/ClientPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/ClientPNames", AccessFlags = 1537)]
		public partial interface IClientPNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/client/params/CookiePolicy
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/CookiePolicy", AccessFlags = 49)]
		public sealed partial class CookiePolicy
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The policy that provides high degree of compatibilty with common cookie management of popular HTTP agents. </para>        
				/// </summary>
				/// <java-name>
				/// BROWSER_COMPATIBILITY
				/// </java-name>
				[Dot42.DexImport("BROWSER_COMPATIBILITY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string BROWSER_COMPATIBILITY = "compatibility";
				/// <summary>
				/// <para>The Netscape cookie draft compliant policy. </para>        
				/// </summary>
				/// <java-name>
				/// NETSCAPE
				/// </java-name>
				[Dot42.DexImport("NETSCAPE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string NETSCAPE = "netscape";
				/// <summary>
				/// <para>The RFC 2109 compliant policy. </para>        
				/// </summary>
				/// <java-name>
				/// RFC_2109
				/// </java-name>
				[Dot42.DexImport("RFC_2109", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RFC_2109 = "rfc2109";
				/// <summary>
				/// <para>The RFC 2965 compliant policy. </para>        
				/// </summary>
				/// <java-name>
				/// RFC_2965
				/// </java-name>
				[Dot42.DexImport("RFC_2965", "Ljava/lang/String;", AccessFlags = 25)]
				public const string RFC_2965 = "rfc2965";
				/// <summary>
				/// <para>The default 'best match' policy. </para>        
				/// </summary>
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

		/// <summary>
		/// <para>Collected parameter names for the HttpClient module. This interface combines the parameter definitions of the HttpClient module and all dependency modules or informational units. It does not define additional parameter names, but references other interfaces defining parameter names. <br></br> This interface is meant as a navigation aid for developers. When referring to parameter names, you should use the interfaces in which the respective constants are actually defined.</para><para><para></para><title>Revision:</title><para>576078 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/client/params/AllClientPNames
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/AllClientPNames", AccessFlags = 1537)]
		public partial interface IAllClientPNames : global::Org.Apache.Http.Params.ICoreConnectionPNames, global::Org.Apache.Http.Params.ICoreProtocolPNames, global::Org.Apache.Http.Client.Params.IClientPNames, global::Org.Apache.Http.Auth.Params.IAuthPNames, global::Org.Apache.Http.Cookie.Params.ICookieSpecPNames, global::Org.Apache.Http.Conn.Params.IConnConnectionPNames, global::Org.Apache.Http.Conn.Params.IConnManagerPNames, global::Org.Apache.Http.Conn.Params.IConnRoutePNames
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// org/apache/http/client/params/ClientParamBean
		/// </java-name>
		[Dot42.DexImport("org/apache/http/client/params/ClientParamBean", AccessFlags = 33)]
		public partial class ClientParamBean : global::Org.Apache.Http.Params.HttpAbstractParamBean
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public ClientParamBean(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectionManagerFactoryClassName
				/// </java-name>
				[Dot42.DexImport("setConnectionManagerFactoryClassName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetConnectionManagerFactoryClassName(string factory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setConnectionManagerFactory
				/// </java-name>
				[Dot42.DexImport("setConnectionManagerFactory", "(Lorg/apache/http/conn/ClientConnectionManagerFactory;)V", AccessFlags = 1)]
				public virtual void SetConnectionManagerFactory(global::Org.Apache.Http.Conn.IClientConnectionManagerFactory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHandleRedirects
				/// </java-name>
				[Dot42.DexImport("setHandleRedirects", "(Z)V", AccessFlags = 1)]
				public virtual void SetHandleRedirects(bool handle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRejectRelativeRedirect
				/// </java-name>
				[Dot42.DexImport("setRejectRelativeRedirect", "(Z)V", AccessFlags = 1)]
				public virtual void SetRejectRelativeRedirect(bool reject) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxRedirects
				/// </java-name>
				[Dot42.DexImport("setMaxRedirects", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxRedirects(int maxRedirects) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAllowCircularRedirects
				/// </java-name>
				[Dot42.DexImport("setAllowCircularRedirects", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllowCircularRedirects(bool allow) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHandleAuthentication
				/// </java-name>
				[Dot42.DexImport("setHandleAuthentication", "(Z)V", AccessFlags = 1)]
				public virtual void SetHandleAuthentication(bool handle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCookiePolicy
				/// </java-name>
				[Dot42.DexImport("setCookiePolicy", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCookiePolicy(string policy) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVirtualHost
				/// </java-name>
				[Dot42.DexImport("setVirtualHost", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public virtual void SetVirtualHost(global::Org.Apache.Http.HttpHost host) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultHeaders
				/// </java-name>
				[Dot42.DexImport("setDefaultHeaders", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Lorg/apache/http/Header;>;)V")]
				public virtual void SetDefaultHeaders(global::Java.Util.ICollection<global::Org.Apache.Http.IHeader> headers) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultHost
				/// </java-name>
				[Dot42.DexImport("setDefaultHost", "(Lorg/apache/http/HttpHost;)V", AccessFlags = 1)]
				public virtual void SetDefaultHost(global::Org.Apache.Http.HttpHost host) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ClientParamBean() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}


