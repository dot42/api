#pragma warning disable 1717
namespace Org.Apache.Http.Impl.Auth
{
		/// <java-name>
		/// org/apache/http/impl/auth/AuthSchemeBase
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/AuthSchemeBase", AccessFlags = 1057)]
		public abstract partial class AuthSchemeBase : global::Org.Apache.Http.Auth.IAuthScheme
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AuthSchemeBase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// processChallenge
				/// </java-name>
				[Dot42.DexImport("processChallenge", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void ProcessChallenge(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseChallenge
				/// </java-name>
				[Dot42.DexImport("parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 1028)]
				protected internal abstract void ParseChallenge(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, int int32, int int321) /* MethodBuilder.Create */ ;

				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "getParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string GetParameter(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest httpRequest) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// isProxy
				/// </java-name>
				public virtual bool IsProxy
				{
						[Dot42.DexImport("isProxy", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				public virtual string SchemeName
				{
						[Dot42.DexImport("org/apache/http/auth/AuthScheme", "getSchemeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return default(string); }
				}

				public virtual string Realm
				{
						[Dot42.DexImport("org/apache/http/auth/AuthScheme", "getRealm", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return default(string); }
				}

				public virtual bool IsConnectionBased
				{
						[Dot42.DexImport("org/apache/http/auth/AuthScheme", "isConnectionBased", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public virtual bool IsComplete
				{
						[Dot42.DexImport("org/apache/http/auth/AuthScheme", "isComplete", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/auth/BasicScheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/BasicScheme", AccessFlags = 33)]
		public partial class BasicScheme : global::Org.Apache.Http.Impl.Auth.RFC2617Scheme
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicScheme() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// processChallenge
				/// </java-name>
				[Dot42.DexImport("processChallenge", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public override void ProcessChallenge(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Ljava/lang/String;Z)Lorg/apache/http/Header;", AccessFlags = 9)]
				public static global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getSchemeName
				/// </java-name>
				public override string SchemeName
				{
						[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isComplete
				/// </java-name>
				public override bool IsComplete
				{
						[Dot42.DexImport("isComplete", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isConnectionBased
				/// </java-name>
				public override bool IsConnectionBased
				{
						[Dot42.DexImport("isConnectionBased", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/auth/BasicSchemeFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/BasicSchemeFactory", AccessFlags = 33)]
		public partial class BasicSchemeFactory : global::Org.Apache.Http.Auth.IAuthSchemeFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicSchemeFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Auth.IAuthScheme NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/auth/DigestScheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/DigestScheme", AccessFlags = 33)]
		public partial class DigestScheme : global::Org.Apache.Http.Impl.Auth.RFC2617Scheme
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DigestScheme() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// processChallenge
				/// </java-name>
				[Dot42.DexImport("processChallenge", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public override void ProcessChallenge(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// overrideParamter
				/// </java-name>
				[Dot42.DexImport("overrideParamter", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OverrideParamter(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// createCnonce
				/// </java-name>
				[Dot42.DexImport("createCnonce", "()Ljava/lang/String;", AccessFlags = 9)]
				public static string CreateCnonce() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isComplete
				/// </java-name>
				public override bool IsComplete
				{
						[Dot42.DexImport("isComplete", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getSchemeName
				/// </java-name>
				public override string SchemeName
				{
						[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isConnectionBased
				/// </java-name>
				public override bool IsConnectionBased
				{
						[Dot42.DexImport("isConnectionBased", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/auth/DigestSchemeFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/DigestSchemeFactory", AccessFlags = 33)]
		public partial class DigestSchemeFactory : global::Org.Apache.Http.Auth.IAuthSchemeFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DigestSchemeFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Auth.IAuthScheme NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/auth/NTLMEngine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/NTLMEngine", AccessFlags = 1537)]
		public partial interface INTLMEngine
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// generateType1Msg
				/// </java-name>
				[Dot42.DexImport("generateType1Msg", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GenerateType1Msg(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// generateType3Msg
				/// </java-name>
				[Dot42.DexImport("generateType3Msg", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GenerateType3Msg(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/impl/auth/NTLMEngineException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/NTLMEngineException", AccessFlags = 33)]
		public partial class NTLMEngineException : global::Org.Apache.Http.Auth.AuthenticationException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NTLMEngineException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NTLMEngineException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NTLMEngineException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/auth/NTLMScheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/NTLMScheme", AccessFlags = 33)]
		public partial class NTLMScheme : global::Org.Apache.Http.Impl.Auth.AuthSchemeBase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Lorg/apache/http/impl/auth/NTLMEngine;)V", AccessFlags = 1)]
				public NTLMScheme(global::Org.Apache.Http.Impl.Auth.INTLMEngine nTLMEngine) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// parseChallenge
				/// </java-name>
				[Dot42.DexImport("parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 4)]
				protected internal override void ParseChallenge(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest httpRequest) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NTLMScheme() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSchemeName
				/// </java-name>
				public override string SchemeName
				{
						[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRealm
				/// </java-name>
				public override string Realm
				{
						[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isConnectionBased
				/// </java-name>
				public override bool IsConnectionBased
				{
						[Dot42.DexImport("isConnectionBased", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isComplete
				/// </java-name>
				public override bool IsComplete
				{
						[Dot42.DexImport("isComplete", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/auth/RFC2617Scheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/RFC2617Scheme", AccessFlags = 1057)]
		public abstract partial class RFC2617Scheme : global::Org.Apache.Http.Impl.Auth.AuthSchemeBase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2617Scheme() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseChallenge
				/// </java-name>
				[Dot42.DexImport("parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 4)]
				protected internal override void ParseChallenge(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetParameter(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getParameters
				/// </java-name>
				protected internal virtual global::Java.Util.IMap<string, string> Parameters
				{
						[Dot42.DexImport("getParameters", "()Ljava/util/Map;", AccessFlags = 4, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IMap<string, string>); }
				}

				/// <java-name>
				/// getRealm
				/// </java-name>
				public override string Realm
				{
						[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/auth/UnsupportedDigestAlgorithmException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/UnsupportedDigestAlgorithmException", AccessFlags = 33)]
		public partial class UnsupportedDigestAlgorithmException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedDigestAlgorithmException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedDigestAlgorithmException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UnsupportedDigestAlgorithmException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

}

