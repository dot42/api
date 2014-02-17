// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Impl.Auth.cs
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
namespace Org.Apache.Http.Impl.Auth
{
		/// <summary>
		/// <para>Authentication credentials required to respond to a authentication challenge are invalid</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/auth/UnsupportedDigestAlgorithmException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/UnsupportedDigestAlgorithmException", AccessFlags = 33)]
		public partial class UnsupportedDigestAlgorithmException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new UnsupportedAuthAlgoritmException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnsupportedDigestAlgorithmException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new UnsupportedAuthAlgoritmException with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UnsupportedDigestAlgorithmException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new UnsupportedAuthAlgoritmException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public UnsupportedDigestAlgorithmException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
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
				public NTLMScheme(global::Org.Apache.Http.Impl.Auth.INTLMEngine engine) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns textual designation of the given authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the given authentication scheme </para>
				/// </returns>
				/// <java-name>
				/// getSchemeName
				/// </java-name>
				[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetSchemeName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetParameter(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns authentication realm. If the concept of an authentication realm is not applicable to the given authentication scheme, returns <code>null</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the authentication realm </para>
				/// </returns>
				/// <java-name>
				/// getRealm
				/// </java-name>
				[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetRealm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Tests if the authentication scheme is provides authorization on a per connection basis instead of usual per request basis</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the scheme is connection based, <code>false</code> if the scheme is request based. </para>
				/// </returns>
				/// <java-name>
				/// isConnectionBased
				/// </java-name>
				[Dot42.DexImport("isConnectionBased", "()Z", AccessFlags = 1)]
				public override bool IsConnectionBased() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parseChallenge
				/// </java-name>
				[Dot42.DexImport("parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 4)]
				protected internal override void ParseChallenge(global::Org.Apache.Http.Util.CharArrayBuffer buffer, int pos, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Authentication process may involve a series of challenge-response exchanges. This method tests if the authorization process has been completed, either successfully or unsuccessfully, that is, all the required authorization challenges have been processed in their entirety.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the authentication process has been completed, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isComplete
				/// </java-name>
				[Dot42.DexImport("isComplete", "()Z", AccessFlags = 1)]
				public override bool IsComplete() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NTLMScheme() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns textual designation of the given authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the given authentication scheme </para>
				/// </returns>
				/// <java-name>
				/// getSchemeName
				/// </java-name>
				public string SchemeName
				{
				[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSchemeName(); }
				}

				/// <summary>
				/// <para>Returns authentication realm. If the concept of an authentication realm is not applicable to the given authentication scheme, returns <code>null</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the authentication realm </para>
				/// </returns>
				/// <java-name>
				/// getRealm
				/// </java-name>
				public string Realm
				{
				[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRealm(); }
				}

		}

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual global::Org.Apache.Http.Auth.IAuthScheme NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

		}

		/// <summary>
		/// <para>Signals NTLM protocol failure.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Creates a new NTLMEngineException with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NTLMEngineException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new NTLMEngineException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public NTLMEngineException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual global::Org.Apache.Http.Auth.IAuthScheme NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

		}

		/// <summary>
		/// <para>Basic authentication scheme as defined in RFC 2617. </para><para><para> </para><simplesectsep></simplesectsep><para>Rodney Waldhoff </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Ortwin Glueck </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/auth/BasicScheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/BasicScheme", AccessFlags = 33)]
		public partial class BasicScheme : global::Org.Apache.Http.Impl.Auth.RFC2617Scheme
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor for the basic authetication scheme. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicScheme() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns textual designation of the basic authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>basic</code> </para>
				/// </returns>
				/// <java-name>
				/// getSchemeName
				/// </java-name>
				[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetSchemeName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Processes the Basic challenge.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// processChallenge
				/// </java-name>
				[Dot42.DexImport("processChallenge", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public override void ProcessChallenge(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tests if the Basic authentication process has been completed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if Basic authorization has been processed, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isComplete
				/// </java-name>
				[Dot42.DexImport("isComplete", "()Z", AccessFlags = 1)]
				public override bool IsComplete() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns <code>false</code>. Basic authentication scheme is request based.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code>. </para>
				/// </returns>
				/// <java-name>
				/// isConnectionBased
				/// </java-name>
				[Dot42.DexImport("isConnectionBased", "()Z", AccessFlags = 1)]
				public override bool IsConnectionBased() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Produces basic authorization header for the given set of Credentials.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a basic authorization string </para>
				/// </returns>
				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns a basic <code>Authorization</code> header value for the given Credentials and charset.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a basic authorization header </para>
				/// </returns>
				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Ljava/lang/String;Z)Lorg/apache/http/Header;", AccessFlags = 9)]
				public static global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, string charset, bool proxy) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns textual designation of the basic authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>basic</code> </para>
				/// </returns>
				/// <java-name>
				/// getSchemeName
				/// </java-name>
				public string SchemeName
				{
				[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSchemeName(); }
				}

		}

		/// <summary>
		/// <para>Abstract NTLM authentication engine. The engine can be used to generate Type1 messages and Type3 messages in response to a Type2 challenge. </para><para>For details see </para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/auth/NTLMEngine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/NTLMEngine", AccessFlags = 1537)]
		public partial interface INTLMEngine
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Generates a Type1 message given the domain and workstation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Type1 message </para>
				/// </returns>
				/// <java-name>
				/// generateType1Msg
				/// </java-name>
				[Dot42.DexImport("generateType1Msg", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GenerateType1Msg(string domain, string workstation) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Generates a Type3 message given the user credentials and the authentication challenge.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Type3 response. </para>
				/// </returns>
				/// <java-name>
				/// generateType3Msg
				/// </java-name>
				[Dot42.DexImport("generateType3Msg", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GenerateType3Msg(string username, string password, string domain, string workstation, string challenge) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Abstract authentication scheme class that serves as a basis for all authentication schemes supported by HttpClient. This class defines the generic way of parsing an authentication challenge. It does not make any assumptions regarding the format of the challenge nor does it impose any specific way of responding to that challenge.</para><para><para> </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Processes the given challenge token. Some authentication schemes may involve multiple challenge-response exchanges. Such schemes must be able to maintain the state information when dealing with sequential challenges</para><para></para>        
				/// </summary>
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
				protected internal abstract void ParseChallenge(global::Org.Apache.Http.Util.CharArrayBuffer buffer, int pos, int len) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns <code>true</code> if authenticating against a proxy, <code>false</code> otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if authenticating against a proxy, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isProxy
				/// </java-name>
				[Dot42.DexImport("isProxy", "()Z", AccessFlags = 1)]
				public virtual bool IsProxy() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "getSchemeName", "()Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string GetSchemeName() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "getParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string GetParameter(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "getRealm", "()Ljava/lang/String;", AccessFlags = 1025)]
				public virtual string GetRealm() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "isConnectionBased", "()Z", AccessFlags = 1025)]
				public virtual bool IsConnectionBased() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "isComplete", "()Z", AccessFlags = 1025)]
				public virtual bool IsComplete() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest request) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				public string SchemeName
				{
				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "getSchemeName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetSchemeName(); }
				}

				public string Realm
				{
				[Dot42.DexImport("org/apache/http/auth/AuthScheme", "getRealm", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetRealm(); }
				}

		}

		/// <summary>
		/// <para>Digest authentication scheme as defined in RFC 2617. Both MD5 (default) and MD5-sess are supported. Currently only qop=auth or no qop is supported. qop=auth-int is unsupported. If auth and auth-int are provided, auth is used. </para><para>Credential charset is configured via the credential charset parameter. Since the digest username is included as clear text in the generated Authentication header, the charset of the username must be compatible with the http element charset. </para><para><para> </para><simplesectsep></simplesectsep><para>Rodney Waldhoff </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Ortwin Glueck </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/auth/DigestScheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/DigestScheme", AccessFlags = 33)]
		public partial class DigestScheme : global::Org.Apache.Http.Impl.Auth.RFC2617Scheme
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor for the digest authetication scheme. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DigestScheme() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Processes the Digest challenge.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// processChallenge
				/// </java-name>
				[Dot42.DexImport("processChallenge", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public override void ProcessChallenge(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tests if the Digest authentication process has been completed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if Digest authorization has been processed, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isComplete
				/// </java-name>
				[Dot42.DexImport("isComplete", "()Z", AccessFlags = 1)]
				public override bool IsComplete() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns textual designation of the digest authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>digest</code> </para>
				/// </returns>
				/// <java-name>
				/// getSchemeName
				/// </java-name>
				[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetSchemeName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns <code>false</code>. Digest authentication scheme is request based.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code>. </para>
				/// </returns>
				/// <java-name>
				/// isConnectionBased
				/// </java-name>
				[Dot42.DexImport("isConnectionBased", "()Z", AccessFlags = 1)]
				public override bool IsConnectionBased() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// overrideParamter
				/// </java-name>
				[Dot42.DexImport("overrideParamter", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void OverrideParamter(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Produces a digest authorization string for the given set of Credentials, method name and URI.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a digest authorization string </para>
				/// </returns>
				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Creates a random cnonce value based on the current time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The cnonce value as String. </para>
				/// </returns>
				/// <java-name>
				/// createCnonce
				/// </java-name>
				[Dot42.DexImport("createCnonce", "()Ljava/lang/String;", AccessFlags = 9)]
				public static string CreateCnonce() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns textual designation of the digest authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>digest</code> </para>
				/// </returns>
				/// <java-name>
				/// getSchemeName
				/// </java-name>
				public string SchemeName
				{
				[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSchemeName(); }
				}

		}

		/// <summary>
		/// <para>Abstract authentication scheme class that lays foundation for all RFC 2617 compliant authetication schemes and provides capabilities common to all authentication schemes defined in RFC 2617.</para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/auth/RFC2617Scheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/auth/RFC2617Scheme", AccessFlags = 1057)]
		public abstract partial class RFC2617Scheme : global::Org.Apache.Http.Impl.Auth.AuthSchemeBase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor for RFC2617 compliant authetication schemes. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2617Scheme() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseChallenge
				/// </java-name>
				[Dot42.DexImport("parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", AccessFlags = 4)]
				protected internal override void ParseChallenge(global::Org.Apache.Http.Util.CharArrayBuffer buffer, int pos, int len) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns authentication parameters map. Keys in the map are lower-cased.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the map of authentication parameters </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()Ljava/util/Map;", AccessFlags = 4, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
				protected internal virtual global::Java.Util.IMap<string, string> GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<string, string>);
				}

				/// <summary>
				/// <para>Returns authentication parameter with the given name, if available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter with the given name </para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public override string GetParameter(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns authentication realm. The realm may not be null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the authentication realm </para>
				/// </returns>
				/// <java-name>
				/// getRealm
				/// </java-name>
				[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetRealm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns authentication parameters map. Keys in the map are lower-cased.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the map of authentication parameters </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				protected internal global::Java.Util.IMap<string, string> Parameters
				{
				[Dot42.DexImport("getParameters", "()Ljava/util/Map;", AccessFlags = 4, Signature = "()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
						get{ return GetParameters(); }
				}

				/// <summary>
				/// <para>Returns authentication realm. The realm may not be null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the authentication realm </para>
				/// </returns>
				/// <java-name>
				/// getRealm
				/// </java-name>
				public string Realm
				{
				[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRealm(); }
				}

		}

}


