// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Auth.cs
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
namespace Org.Apache.Http.Auth
{
		/// <summary>
		/// <para>The class represents an authentication scope consisting of a host name, a port number, a realm name and an authentication scheme name which Credentials apply to.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/AuthScope
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthScope", AccessFlags = 33)]
		public partial class AuthScope
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The <code>null</code> value represents any host. In the future versions of HttpClient the use of this parameter will be discontinued. </para>        
				/// </summary>
				/// <java-name>
				/// ANY_HOST
				/// </java-name>
				[Dot42.DexImport("ANY_HOST", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string ANY_HOST;
				/// <summary>
				/// <para>The <code>-1</code> value represents any port. </para>        
				/// </summary>
				/// <java-name>
				/// ANY_PORT
				/// </java-name>
				[Dot42.DexImport("ANY_PORT", "I", AccessFlags = 25)]
				public const int ANY_PORT = -1;
				/// <summary>
				/// <para>The <code>null</code> value represents any realm. </para>        
				/// </summary>
				/// <java-name>
				/// ANY_REALM
				/// </java-name>
				[Dot42.DexImport("ANY_REALM", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string ANY_REALM;
				/// <summary>
				/// <para>The <code>null</code> value represents any authentication scheme. </para>        
				/// </summary>
				/// <java-name>
				/// ANY_SCHEME
				/// </java-name>
				[Dot42.DexImport("ANY_SCHEME", "Ljava/lang/String;", AccessFlags = 25)]
				public static readonly string ANY_SCHEME;
				/// <summary>
				/// <para>Default scope matching any host, port, realm and authentication scheme. In the future versions of HttpClient the use of this parameter will be discontinued. </para>        
				/// </summary>
				/// <java-name>
				/// ANY
				/// </java-name>
				[Dot42.DexImport("ANY", "Lorg/apache/http/auth/AuthScope;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Auth.AuthScope ANY;
				/// <summary>
				/// <para>Creates a new credentials scope for the given <code>host</code>, <code>port</code>, <code>realm</code>, and <code>authentication scheme</code>.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthScope(string host, int port, string realm, string scheme) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new credentials scope for the given <code>host</code>, <code>port</code>, <code>realm</code>, and any authentication scheme.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;)V", AccessFlags = 1)]
				public AuthScope(string host, int port, string realm) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new credentials scope for the given <code>host</code>, <code>port</code>, any realm name, and any authentication scheme.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public AuthScope(string host, int port) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a copy of the given credentials scope. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/auth/AuthScope;)V", AccessFlags = 1)]
				public AuthScope(global::Org.Apache.Http.Auth.AuthScope authscope) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host </para>
				/// </returns>
				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the port </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public virtual int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the realm name </para>
				/// </returns>
				/// <java-name>
				/// getRealm
				/// </java-name>
				[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetRealm() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme type </para>
				/// </returns>
				/// <java-name>
				/// getScheme
				/// </java-name>
				[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetScheme() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Tests if the authentication scopes match.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the match factor. Negative value signifies no match. Non-negative signifies a match. The greater the returned value the closer the match. </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/auth/AuthScope;)I", AccessFlags = 1)]
				public virtual int Match(global::Org.Apache.Http.Auth.AuthScope that) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para><para>java.lang.Object::equals(Object) </para></para>        
				/// </summary>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>java.lang.Object::toString() </para></para>        
				/// </summary>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para><para>java.lang.Object::hashCode() </para></para>        
				/// </summary>
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

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the host </para>
				/// </returns>
				/// <java-name>
				/// getHost
				/// </java-name>
				public string Host
				{
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHost(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the port </para>
				/// </returns>
				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the realm name </para>
				/// </returns>
				/// <java-name>
				/// getRealm
				/// </java-name>
				public string Realm
				{
				[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetRealm(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the scheme type </para>
				/// </returns>
				/// <java-name>
				/// getScheme
				/// </java-name>
				public string Scheme
				{
				[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetScheme(); }
				}

		}

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				global::Org.Apache.Http.Auth.IAuthScheme NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Authentication scheme registry that can be used to obtain the corresponding authentication scheme implementation for a given type of authorization challenge.</para><para><para></para><para></para><title>Revision:</title><para>652950 </para><para>4.0 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Registers a AuthSchemeFactory with the given identifier. If a factory with the given name already exists it will be overridden. This name is the same one used to retrieve the authentication scheme from getAuthScheme.</para><para>Please note that custom authentication preferences, if used, need to be updated accordingly for the new authentication scheme to take effect. </para><para><para>getAuthScheme </para></para>        
				/// </summary>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/lang/String;Lorg/apache/http/auth/AuthSchemeFactory;)V", AccessFlags = 33)]
				public void Register(string name, global::Org.Apache.Http.Auth.IAuthSchemeFactory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters the class implementing an authentication scheme with the given name.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public void Unregister(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the authentication scheme with the given name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>authentication scheme</para>
				/// </returns>
				/// <java-name>
				/// getAuthScheme
				/// </java-name>
				[Dot42.DexImport("getAuthScheme", "(Ljava/lang/String;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/auth/Auth" +
    "Scheme;", AccessFlags = 33)]
				public global::Org.Apache.Http.Auth.IAuthScheme GetAuthScheme(string name, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

				/// <summary>
				/// <para>Obtains a list containing names of all registered authentication schemes in their default order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of registered scheme names </para>
				/// </returns>
				/// <java-name>
				/// getSchemeNames
				/// </java-name>
				[Dot42.DexImport("getSchemeNames", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				public global::Java.Util.IList<string> GetSchemeNames() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <summary>
				/// <para>Populates the internal collection of registered authentication schemes with the content of the map passed as a parameter.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setItems
				/// </java-name>
				[Dot42.DexImport("setItems", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/auth/AuthSchemeFactory;>;)V")]
				public void SetItems(global::Java.Util.IMap<string, global::Org.Apache.Http.Auth.IAuthSchemeFactory> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains a list containing names of all registered authentication schemes in their default order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of registered scheme names </para>
				/// </returns>
				/// <java-name>
				/// getSchemeNames
				/// </java-name>
				public global::Java.Util.IList<string> SchemeNames
				{
				[Dot42.DexImport("getSchemeNames", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return GetSchemeNames(); }
				}

		}

		/// <summary>
		/// <para>Signals a failure in authentication process</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/AuthenticationException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthenticationException", AccessFlags = 33)]
		public partial class AuthenticationException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new AuthenticationException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AuthenticationException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new AuthenticationException with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AuthenticationException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new AuthenticationException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public AuthenticationException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Credentials specific to the Windows platform.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para>2.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/NTCredentials
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/NTCredentials", AccessFlags = 33)]
		public partial class NTCredentials : global::Org.Apache.Http.Auth.ICredentials
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The constructor with the fully qualified username and password combined string argument.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NTCredentials(string usernamePassword) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public NTCredentials(string userName, string password, string workstation, string domain) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUserPrincipal
				/// </java-name>
				[Dot42.DexImport("getUserPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetUserPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUserName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPassword() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Retrieves the name to authenticate with.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String the domain these credentials are intended to authenticate with. </para>
				/// </returns>
				/// <java-name>
				/// getDomain
				/// </java-name>
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDomain() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Retrieves the workstation name of the computer originating the request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String the workstation the user is logged into. </para>
				/// </returns>
				/// <java-name>
				/// getWorkstation
				/// </java-name>
				[Dot42.DexImport("getWorkstation", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetWorkstation() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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
				public global::Java.Security.IPrincipal UserPrincipal
				{
				[Dot42.DexImport("getUserPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetUserPrincipal(); }
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				public string UserName
				{
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUserName(); }
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				public string Password
				{
				[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPassword(); }
				}

				/// <summary>
				/// <para>Retrieves the name to authenticate with.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String the domain these credentials are intended to authenticate with. </para>
				/// </returns>
				/// <java-name>
				/// getDomain
				/// </java-name>
				public string Domain
				{
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDomain(); }
				}

				/// <summary>
				/// <para>Retrieves the workstation name of the computer originating the request.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String the workstation the user is logged into. </para>
				/// </returns>
				/// <java-name>
				/// getWorkstation
				/// </java-name>
				public string Workstation
				{
				[Dot42.DexImport("getWorkstation", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetWorkstation(); }
				}

		}

		/// <summary>
		/// <para>Basic user principal used for HTTP authentication</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/BasicUserPrincipal
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/BasicUserPrincipal", AccessFlags = 49)]
		public sealed partial class BasicUserPrincipal : global::Java.Security.IPrincipal
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicUserPrincipal(string username) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this <c> Principal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <c> Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the hash code value for this <c> Principal </c> . Returns the same hash code for <c> Principal </c> s that are equal to each other as required by the general contract of Object#hashCode.</para><para><para>Object::equals(Object) </para><simplesectsep></simplesectsep><para>Principal::equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code value for this <c> Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the specified object with this <c> Principal </c> for equality and returns <c> true </c> if the specified object is equal, <c> false </c> otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c>               Principal </c> , otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of this <c> Principal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation for this <c> Principal </c> . </para>
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
				internal BasicUserPrincipal() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this <c> Principal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <c> Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

		}

		/// <summary>
		/// <para>Constants and static helpers related to the HTTP authentication.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/AUTH
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AUTH", AccessFlags = 49)]
		public sealed partial class AUTH
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The www authenticate challange header. </para>        
				/// </summary>
				/// <java-name>
				/// WWW_AUTH
				/// </java-name>
				[Dot42.DexImport("WWW_AUTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WWW_AUTH = "WWW-Authenticate";
				/// <summary>
				/// <para>The www authenticate response header. </para>        
				/// </summary>
				/// <java-name>
				/// WWW_AUTH_RESP
				/// </java-name>
				[Dot42.DexImport("WWW_AUTH_RESP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string WWW_AUTH_RESP = "Authorization";
				/// <summary>
				/// <para>The proxy authenticate challange header. </para>        
				/// </summary>
				/// <java-name>
				/// PROXY_AUTH
				/// </java-name>
				[Dot42.DexImport("PROXY_AUTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PROXY_AUTH = "Proxy-Authenticate";
				/// <summary>
				/// <para>The proxy authenticate response header. </para>        
				/// </summary>
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

		/// <summary>
		/// <para>This interface represents an abstract challenge-response oriented authentication scheme. </para><para>An authentication scheme should be able to support the following functions: <ul><li><para>Parse and process the challenge sent by the targer server in response to request for a protected resource </para></li><li><para>Provide its textual designation </para></li><li><para>Provide its parameters, if available </para></li><li><para>Provide the realm this authentication scheme is applicable to, if available </para></li><li><para>Generate authorization string for the given set of credentials, request method and URI as specificed in the HTTP request line in response to the actual authorization challenge </para></li></ul></para><para>Authentication schemes may ignore method name and URI parameters if they are not relevant for the given authentication mechanism </para><para>Authentication schemes may be stateful involving a series of challenge-response exchanges </para><para><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/AuthScheme
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthScheme", AccessFlags = 1537)]
		public partial interface IAuthScheme
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Processes the given challenge token. Some authentication schemes may involve multiple challenge-response exchanges. Such schemes must be able to maintain the state information when dealing with sequential challenges</para><para></para>        
				/// </summary>
				/// <java-name>
				/// processChallenge
				/// </java-name>
				[Dot42.DexImport("processChallenge", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				void ProcessChallenge(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns textual designation of the given authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of the given authentication scheme </para>
				/// </returns>
				/// <java-name>
				/// getSchemeName
				/// </java-name>
				[Dot42.DexImport("getSchemeName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetSchemeName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns authentication parameter with the given name, if available.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter with the given name </para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetParameter(string name) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns authentication realm. If the concept of an authentication realm is not applicable to the given authentication scheme, returns <code>null</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the authentication realm </para>
				/// </returns>
				/// <java-name>
				/// getRealm
				/// </java-name>
				[Dot42.DexImport("getRealm", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetRealm() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tests if the authentication scheme is provides authorization on a per connection basis instead of usual per request basis</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the scheme is connection based, <code>false</code> if the scheme is request based. </para>
				/// </returns>
				/// <java-name>
				/// isConnectionBased
				/// </java-name>
				[Dot42.DexImport("isConnectionBased", "()Z", AccessFlags = 1025)]
				bool IsConnectionBased() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Authentication process may involve a series of challenge-response exchanges. This method tests if the authorization process has been completed, either successfully or unsuccessfully, that is, all the required authorization challenges have been processed in their entirety.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the authentication process has been completed, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isComplete
				/// </java-name>
				[Dot42.DexImport("isComplete", "()Z", AccessFlags = 1025)]
				bool IsComplete() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Produces an authorization string for the given set of Credentials.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the authorization string </para>
				/// </returns>
				/// <java-name>
				/// authenticate
				/// </java-name>
				[Dot42.DexImport("authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http" +
    "/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader Authenticate(global::Org.Apache.Http.Auth.ICredentials credentials, global::Org.Apache.Http.IHttpRequest request) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>User name and password based authentication credentials.</para><para><para>Unascribed </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>658430 </para><title>Date:</title><para>2008-05-20 14:04:27 -0700 (Tue, 20 May 2008) </para></para>    
		/// </summary>
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
				[Dot42.DexImport("getUserPrincipal", "()Ljava/security/Principal;", AccessFlags = 1025)]
				global::Java.Security.IPrincipal GetUserPrincipal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPassword() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Username and password Credentials</para><para><para> </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>658430 </para><title>Date:</title><para>2008-05-20 14:04:27 -0700 (Tue, 20 May 2008) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/UsernamePasswordCredentials
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/UsernamePasswordCredentials", AccessFlags = 33)]
		public partial class UsernamePasswordCredentials : global::Org.Apache.Http.Auth.ICredentials
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The constructor with the username and password combined string argument.</para><para><para>#toString </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public UsernamePasswordCredentials(string usernamePassword) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The constructor with the username and password arguments.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public UsernamePasswordCredentials(string userName, string password) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUserPrincipal
				/// </java-name>
				[Dot42.DexImport("getUserPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
				public virtual global::Java.Security.IPrincipal GetUserPrincipal() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.IPrincipal);
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUserName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPassword() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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
				public global::Java.Security.IPrincipal UserPrincipal
				{
				[Dot42.DexImport("getUserPrincipal", "()Ljava/security/Principal;", AccessFlags = 1)]
						get{ return GetUserPrincipal(); }
				}

				/// <java-name>
				/// getUserName
				/// </java-name>
				public string UserName
				{
				[Dot42.DexImport("getUserName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUserName(); }
				}

				/// <java-name>
				/// getPassword
				/// </java-name>
				public string Password
				{
				[Dot42.DexImport("getPassword", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPassword(); }
				}

		}

		/// <summary>
		/// <para>NT (MS Windows specific) user principal used for HTTP authentication</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/NTUserPrincipal
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/NTUserPrincipal", AccessFlags = 33)]
		public partial class NTUserPrincipal : global::Java.Security.IPrincipal
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public NTUserPrincipal(string domain, string username) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this <c> Principal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <c> Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDomain
				/// </java-name>
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDomain() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getUsername
				/// </java-name>
				[Dot42.DexImport("getUsername", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUsername() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the hash code value for this <c> Principal </c> . Returns the same hash code for <c> Principal </c> s that are equal to each other as required by the general contract of Object#hashCode.</para><para><para>Object::equals(Object) </para><simplesectsep></simplesectsep><para>Principal::equals(Object) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the hash code value for this <c> Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Compares the specified object with this <c> Principal </c> for equality and returns <c> true </c> if the specified object is equal, <c> false </c> otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><c> true </c> if the specified object is equal to this <c>               Principal </c> , otherwise <c> false </c> . </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns a string containing a concise, human-readable description of this <c> Principal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a printable representation for this <c> Principal </c> . </para>
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
				internal NTUserPrincipal() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name of this <c> Principal </c> .</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name of this <c> Principal </c> . </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getDomain
				/// </java-name>
				public string Domain
				{
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDomain(); }
				}

				/// <java-name>
				/// getUsername
				/// </java-name>
				public string Username
				{
				[Dot42.DexImport("getUsername", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUsername(); }
				}

		}

		/// <summary>
		/// <para>Authentication credentials required to respond to a authentication challenge are invalid</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/InvalidCredentialsException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/InvalidCredentialsException", AccessFlags = 33)]
		public partial class InvalidCredentialsException : global::Org.Apache.Http.Auth.AuthenticationException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new InvalidCredentialsException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidCredentialsException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new InvalidCredentialsException with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidCredentialsException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new InvalidCredentialsException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InvalidCredentialsException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Signals that authentication challenge is in some way invalid or illegal in the given context</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/MalformedChallengeException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/MalformedChallengeException", AccessFlags = 33)]
		public partial class MalformedChallengeException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new MalformedChallengeException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedChallengeException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new MalformedChallengeException with the specified message.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedChallengeException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new MalformedChallengeException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public MalformedChallengeException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class provides detailed information about the state of the authentication process.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/auth/AuthState
		/// </java-name>
		[Dot42.DexImport("org/apache/http/auth/AuthState", AccessFlags = 33)]
		public partial class AuthState
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AuthState() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Invalidates the authentication state by resetting its parameters. </para>        
				/// </summary>
				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "()V", AccessFlags = 1)]
				public virtual void Invalidate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isValid
				/// </java-name>
				[Dot42.DexImport("isValid", "()Z", AccessFlags = 1)]
				public virtual bool IsValid() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Assigns the given authentication scheme.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAuthScheme
				/// </java-name>
				[Dot42.DexImport("setAuthScheme", "(Lorg/apache/http/auth/AuthScheme;)V", AccessFlags = 1)]
				public virtual void SetAuthScheme(global::Org.Apache.Http.Auth.IAuthScheme authScheme) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>authentication scheme </para>
				/// </returns>
				/// <java-name>
				/// getAuthScheme
				/// </java-name>
				[Dot42.DexImport("getAuthScheme", "()Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Auth.IAuthScheme GetAuthScheme() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.IAuthScheme);
				}

				/// <summary>
				/// <para>Returns user Credentials selected for authentication if available</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>user credentials if available, <code>null&lt;/code otherwise </code></para>
				/// </returns>
				/// <java-name>
				/// getCredentials
				/// </java-name>
				[Dot42.DexImport("getCredentials", "()Lorg/apache/http/auth/Credentials;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Auth.ICredentials GetCredentials() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.ICredentials);
				}

				/// <summary>
				/// <para>Sets user Credentials to be used for authentication</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCredentials
				/// </java-name>
				[Dot42.DexImport("setCredentials", "(Lorg/apache/http/auth/Credentials;)V", AccessFlags = 1)]
				public virtual void SetCredentials(global::Org.Apache.Http.Auth.ICredentials credentials) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns actual AuthScope if available</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>actual authentication scope if available, <code>null&lt;/code otherwise </code></para>
				/// </returns>
				/// <java-name>
				/// getAuthScope
				/// </java-name>
				[Dot42.DexImport("getAuthScope", "()Lorg/apache/http/auth/AuthScope;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Auth.AuthScope GetAuthScope() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Auth.AuthScope);
				}

				/// <summary>
				/// <para>Sets actual AuthScope.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAuthScope
				/// </java-name>
				[Dot42.DexImport("setAuthScope", "(Lorg/apache/http/auth/AuthScope;)V", AccessFlags = 1)]
				public virtual void SetAuthScope(global::Org.Apache.Http.Auth.AuthScope authScope) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the authentication scheme.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>authentication scheme </para>
				/// </returns>
				/// <java-name>
				/// getAuthScheme
				/// </java-name>
				public global::Org.Apache.Http.Auth.IAuthScheme AuthScheme
				{
				[Dot42.DexImport("getAuthScheme", "()Lorg/apache/http/auth/AuthScheme;", AccessFlags = 1)]
						get{ return GetAuthScheme(); }
				[Dot42.DexImport("setAuthScheme", "(Lorg/apache/http/auth/AuthScheme;)V", AccessFlags = 1)]
						set{ SetAuthScheme(value); }
				}

				/// <summary>
				/// <para>Returns user Credentials selected for authentication if available</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>user credentials if available, <code>null&lt;/code otherwise </code></para>
				/// </returns>
				/// <java-name>
				/// getCredentials
				/// </java-name>
				public global::Org.Apache.Http.Auth.ICredentials Credentials
				{
				[Dot42.DexImport("getCredentials", "()Lorg/apache/http/auth/Credentials;", AccessFlags = 1)]
						get{ return GetCredentials(); }
				[Dot42.DexImport("setCredentials", "(Lorg/apache/http/auth/Credentials;)V", AccessFlags = 1)]
						set{ SetCredentials(value); }
				}

				/// <summary>
				/// <para>Returns actual AuthScope if available</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>actual authentication scope if available, <code>null&lt;/code otherwise </code></para>
				/// </returns>
				/// <java-name>
				/// getAuthScope
				/// </java-name>
				public global::Org.Apache.Http.Auth.AuthScope AuthScope
				{
				[Dot42.DexImport("getAuthScope", "()Lorg/apache/http/auth/AuthScope;", AccessFlags = 1)]
						get{ return GetAuthScope(); }
				[Dot42.DexImport("setAuthScope", "(Lorg/apache/http/auth/AuthScope;)V", AccessFlags = 1)]
						set{ SetAuthScope(value); }
				}

		}

}


