#pragma warning disable 1717
namespace Org.Apache.Http.Auth
{
		/// <java-name>
		/// org/apache/http/auth/AUTH
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AUTH", AccessFlags = 49)]
		public sealed partial class AUTH
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// WWW_AUTH
				/// </java-name>
				[Dot42.DexImport("WWW_AUTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WWW_AUTH = "WWW-Authenticate";
				/// <java-name>
				/// WWW_AUTH_RESP
				/// </java-name>
				[Dot42.DexImport("WWW_AUTH_RESP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WWW_AUTH_RESP = "Authorization";
				/// <java-name>
				/// PROXY_AUTH
				/// </java-name>
				[Dot42.DexImport("PROXY_AUTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROXY_AUTH = "Proxy-Authenticate";
				/// <java-name>
				/// PROXY_AUTH_RESP
				/// </java-name>
				[Dot42.DexImport("PROXY_AUTH_RESP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROXY_AUTH_RESP = "Proxy-Authorization";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AUTH() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/auth/AuthenticationException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthenticationException", AccessFlags = 33)]
		public partial class AuthenticationException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AuthenticationException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthenticationException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AuthenticationException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/auth/AuthSchemeRegistry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthSchemeRegistry", AccessFlags = 49)]
		public sealed partial class AuthSchemeRegistry
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AuthSchemeRegistry() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/lang/String;Lorg/apache/http/auth/AuthSchemeFactory;)V", AccessFlags = 33)]
				public void Register(string @string, global::Org.Apache.Http.Auth.IAuthSchemeFactory authSchemeFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public void Unregister(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAuthScheme
				/// </java-name>
				[Dot42.DexImport("getAuthScheme", "(Ljava/lang/String;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/Auth" +
    "Scheme;", AccessFlags = 33)]
				public global::Org.Apache.Http.Auth.IAuthScheme GetAuthScheme(string @string, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

				/// <java-name>
				/// setItems
				/// </java-name>
				[Dot42.DexImport("setItems", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/auth/AuthSchemeFactory;>;)V")]
				public void SetItems(global::Java.Util.IMap<string, global::Org.Apache.Http.Auth.IAuthSchemeFactory> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSchemeNames
				/// </java-name>
				public global::Java.Util.IList<string> SchemeNames
				{
						[Dot42.DexImport("getSchemeNames", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IList<string>); }
				}

		}

		/// <java-name>
		/// org/apache/http/auth/AuthScope
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthScope", AccessFlags = 33)]
		public partial class AuthScope
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ANY_HOST
				/// </java-name>
				[Dot42.DexImport("ANY_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string ANY_HOST;
				/// <java-name>
				/// ANY_PORT
				/// </java-name>
				[Dot42.DexImport("ANY_PORT", "I", AccessFlags = 25)]
				public const int ANY_PORT = -1;
				/// <java-name>
				/// ANY_REALM
				/// </java-name>
				[Dot42.DexImport("ANY_REALM", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string ANY_REALM;
				/// <java-name>
				/// ANY_SCHEME
				/// </java-name>
				[Dot42.DexImport("ANY_SCHEME", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string ANY_SCHEME;
				/// <java-name>
				/// ANY
				/// </java-name>
				[Dot42.DexImport("ANY", "Lorg/apache/http/auth/AuthScope;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Auth.AuthScope ANY;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthScope(string @string, int int32, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public AuthScope(string @string, int int32, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public AuthScope(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/auth/AuthScope;)V", AccessFlags = 1)]
				public AuthScope(global::Org.Apache.Http.Auth.AuthScope authScope) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/auth/AuthScope;)I", AccessFlags = 1)]
				public virtual int Match(global::Org.Apache.Http.Auth.AuthScope authScope) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AuthScope() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				public virtual string Host
				{
						[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public virtual int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRealm
				/// </java-name>
				public virtual string Realm
				{
						[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getScheme
				/// </java-name>
				public virtual string Scheme
				{
						[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// org/apache/http/auth/AuthState
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthState", AccessFlags = 33)]
		public partial class AuthState
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AuthState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "()V", AccessFlags = 1)]
				public virtual void Invalidate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isValid
				/// </java-name>
				public virtual bool IsValid
				{
						[Dot42.DexImport("isValid", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getAuthScheme
				/// </java-name>
				public virtual global::Org.Apache.Http.Auth.IAuthScheme AuthScheme
				{
						[Dot42.DexImport("getAuthScheme", "()Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.Auth.IAuthScheme); }
						[Dot42.DexImport("setAuthScheme", "(Lorg/apache/http/auth/AuthScheme;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCredentials
				/// </java-name>
				public virtual global::Org.Apache.Http.Auth.ICredentials Credentials
				{
						[Dot42.DexImport("getCredentials", "()Lorg/apache/http/auth/Credentials;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.Auth.ICredentials); }
						[Dot42.DexImport("setCredentials", "(Lorg/apache/http/auth/Credentials;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAuthScope
				/// </java-name>
				public virtual global::Org.Apache.Http.Auth.AuthScope AuthScope
				{
						[Dot42.DexImport("getAuthScope", "()Lorg/apache/http/auth/AuthScope;", AccessFlags = 1)]
						get{ return default(global::Org.Apache.Http.Auth.AuthScope); }
						[Dot42.DexImport("setAuthScope", "(Lorg/apache/http/auth/AuthScope;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// org/apache/http/auth/BasicUserPrincipal
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/BasicUserPrincipal", AccessFlags = 49)]
		public sealed partial class BasicUserPrincipal : global::Java.Security.IPrincipal
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicUserPrincipal(string @string) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicUserPrincipal() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// org/apache/http/auth/AuthScheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthScheme", AccessFlags = 1537)]
		public partial interface IAuthScheme
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// processChallenge
				/// </java-name>
				[Dot42.DexImport("processChallenge", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void ProcessChallenge(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetParameter(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSchemeName
				/// </java-name>
				string SchemeName
				{
						[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRealm
				/// </java-name>
				string Realm
				{
						[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isConnectionBased
				/// </java-name>
				bool IsConnectionBased
				{
						[Dot42.DexImport("isConnectionBased", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isComplete
				/// </java-name>
				bool IsComplete
				{
						[Dot42.DexImport("isComplete", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/auth/AuthSchemeFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthSchemeFactory", AccessFlags = 1537)]
		public partial interface IAuthSchemeFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1025)]
				global::Org.Apache.Http.Auth.IAuthScheme NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/auth/Credentials
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/Credentials", AccessFlags = 1537)]
		public partial interface ICredentials
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getUserPrincipal
				/// </java-name>
				global::Java.Security.IPrincipal UserPrincipal
				{
						[Dot42.DexImport("getUserPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				string Password
				{
						[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/auth/InvalidCredentialsException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/InvalidCredentialsException", AccessFlags = 33)]
		public partial class InvalidCredentialsException : global::Org.Apache.Http.Auth.AuthenticationException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidCredentialsException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidCredentialsException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidCredentialsException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/auth/MalformedChallengeException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/MalformedChallengeException", AccessFlags = 33)]
		public partial class MalformedChallengeException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedChallengeException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedChallengeException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public MalformedChallengeException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/auth/NTCredentials
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/NTCredentials", AccessFlags = 33)]
		public partial class NTCredentials : global::Org.Apache.Http.Auth.ICredentials
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NTCredentials(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public NTCredentials(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NTCredentials() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getUserPrincipal
				/// </java-name>
				public virtual global::Java.Security.IPrincipal UserPrincipal
				{
						[Dot42.DexImport("getUserPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPrincipal); }
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				public virtual string UserName
				{
						[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				public virtual string Password
				{
						[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDomain
				/// </java-name>
				public virtual string Domain
				{
						[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getWorkstation
				/// </java-name>
				public virtual string Workstation
				{
						[Dot42.DexImport("getWorkstation", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// org/apache/http/auth/NTUserPrincipal
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/NTUserPrincipal", AccessFlags = 33)]
		public partial class NTUserPrincipal : global::Java.Security.IPrincipal
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public NTUserPrincipal(string @string, string string1) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NTUserPrincipal() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getDomain
				/// </java-name>
				public virtual string Domain
				{
						[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getUsername
				/// </java-name>
				public virtual string Username
				{
						[Dot42.DexImport("getUsername", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// org/apache/http/auth/UsernamePasswordCredentials
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/UsernamePasswordCredentials", AccessFlags = 33)]
		public partial class UsernamePasswordCredentials : global::Org.Apache.Http.Auth.ICredentials
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UsernamePasswordCredentials(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public UsernamePasswordCredentials(string @string, string string1) /* MethodBuilder.Create */ 
				{
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal UsernamePasswordCredentials() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getUserPrincipal
				/// </java-name>
				public virtual global::Java.Security.IPrincipal UserPrincipal
				{
						[Dot42.DexImport("getUserPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPrincipal); }
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				public virtual string UserName
				{
						[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				public virtual string Password
				{
						[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

