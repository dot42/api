// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Cookie.cs
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
namespace Org.Apache.Http.Cookie
{
		/// <summary>
		/// <para>This cookie comparator ensures that multiple cookies satisfying a common criteria are ordered in the <code>Cookie</code> header such that those with more specific Path attributes precede those with less specific.</para><para>This comparator assumes that Path attributes of two cookies path-match a commmon request-URI. Otherwise, the result of the comparison is undefined. </para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/CookiePathComparator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookiePathComparator", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/util/Comparator<Lorg/apache/http/co" +
    "okie/Cookie;>;")]
		public partial class CookiePathComparator : global::Java.Io.ISerializable, global::Java.Util.IComparator<global::Org.Apache.Http.Cookie.ICookie>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CookiePathComparator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/Cookie;)I", AccessFlags = 1)]
				public virtual int Compare(global::Org.Apache.Http.Cookie.ICookie c1, global::Org.Apache.Http.Cookie.ICookie c2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Comparator", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>Defines the cookie management specification. </para><para>Cookie management specification must define <ul><li><para>rules of parsing "Set-Cookie" header </para></li><li><para>rules of validation of parsed cookies </para></li><li><para>formatting of "Cookie" header </para></li></ul>for a given host, port and path of origin</para><para><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/CookieSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieSpec", AccessFlags = 1537)]
		public partial interface ICookieSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
				int GetVersion() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parse the <code>"Set-Cookie"</code> Header into an array of Cookies.</para><para>This method will not perform the validation of the resultant Cookies</para><para><para>validate</para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of <code>Cookie</code>s parsed from the header </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Validate the cookie according to validation rules defined by the cookie specification.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1025)]
				void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Determines if a Cookie matches the target location.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the cookie should be submitted with a request with given attributes, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1025)]
				bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create <code>"Cookie"</code> headers for an array of Cookies.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Header for the given Cookies. </para>
				/// </returns>
				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> cookies) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Constants and static helpers related to the HTTP state management.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/SM
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/SM", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISMConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// COOKIE
				/// </java-name>
				[Dot42.DexImport("COOKIE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COOKIE = "Cookie";
				/// <java-name>
				/// COOKIE2
				/// </java-name>
				[Dot42.DexImport("COOKIE2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COOKIE2 = "Cookie2";
				/// <java-name>
				/// SET_COOKIE
				/// </java-name>
				[Dot42.DexImport("SET_COOKIE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SET_COOKIE = "Set-Cookie";
				/// <java-name>
				/// SET_COOKIE2
				/// </java-name>
				[Dot42.DexImport("SET_COOKIE2", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SET_COOKIE2 = "Set-Cookie2";
		}

		/// <summary>
		/// <para>Constants and static helpers related to the HTTP state management.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/SM
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/SM", AccessFlags = 1537)]
		public partial interface ISM
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>This interface represents a <code>SetCookie2</code> response header sent by the origin server to the HTTP agent in order to maintain a conversational state.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/SetCookie2
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/SetCookie2", AccessFlags = 1537)]
		public partial interface ISetCookie2 : global::Org.Apache.Http.Cookie.ISetCookie
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>If a user agent (web browser) presents this cookie to a user, the cookie's purpose will be described by the information at this URL. </para>        
				/// </summary>
				/// <java-name>
				/// setCommentURL
				/// </java-name>
				[Dot42.DexImport("setCommentURL", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetCommentURL(string commentURL) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the Port attribute. It restricts the ports to which a cookie may be returned in a Cookie request header. </para>        
				/// </summary>
				/// <java-name>
				/// setPorts
				/// </java-name>
				[Dot42.DexImport("setPorts", "([I)V", AccessFlags = 1025)]
				void SetPorts(int[] ports) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the Discard attribute.</para><para>Note: <code>Discard</code> attribute overrides <code>Max-age</code>.</para><para><para>isPersistent() </para></para>        
				/// </summary>
				/// <java-name>
				/// setDiscard
				/// </java-name>
				[Dot42.DexImport("setDiscard", "(Z)V", AccessFlags = 1025)]
				void SetDiscard(bool discard) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>HTTP "magic-cookie" represents a piece of state information that the HTTP agent and the target server can exchange to maintain a session.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/Cookie
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/Cookie", AccessFlags = 1537)]
		public partial interface ICookie
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns the name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String name The name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetName() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String value The current value. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetValue() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the comment describing the purpose of this cookie, or <code>null</code> if no such comment has been defined.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>comment </para>
				/// </returns>
				/// <java-name>
				/// getComment
				/// </java-name>
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetComment() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If a user agent (web browser) presents this cookie to a user, the cookie's purpose will be described by the information at this URL. </para>        
				/// </summary>
				/// <java-name>
				/// getCommentURL
				/// </java-name>
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetCommentURL() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the expiration Date of the cookie, or <code>null</code> if none exists. </para><para><b>Note:</b> the object returned by this method is considered immutable. Changing it (e.g. using setTime()) could result in undefined behaviour. Do so at your peril. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Expiration Date, or <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getExpiryDate
				/// </java-name>
				[Dot42.DexImport("getExpiryDate", "()Ljava/util/Date;", AccessFlags = 1025)]
				global::Java.Util.Date GetExpiryDate() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns <code>false</code> if the cookie should be discarded at the end of the "session"; <code>true</code> otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> if the cookie should be discarded at the end of the "session"; <code>true</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isPersistent
				/// </java-name>
				[Dot42.DexImport("isPersistent", "()Z", AccessFlags = 1025)]
				bool IsPersistent() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns domain attribute of the cookie.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the domain attribute </para>
				/// </returns>
				/// <java-name>
				/// getDomain
				/// </java-name>
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetDomain() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the path attribute of the cookie</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of the path attribute. </para>
				/// </returns>
				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1025)]
				string GetPath() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get the Port attribute. It restricts the ports to which a cookie may be returned in a Cookie request header. </para>        
				/// </summary>
				/// <java-name>
				/// getPorts
				/// </java-name>
				[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1025)]
				int[] GetPorts() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether this cookie requires a secure connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this cookie should only be sent over secure connections, <code>false</code> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1025)]
				bool IsSecure() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the version of the cookie specification to which this cookie conforms.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the version of the cookie. </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
				int GetVersion() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if this cookie has expired. </para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the cookie has expired. </para>
				/// </returns>
				/// <java-name>
				/// isExpired
				/// </java-name>
				[Dot42.DexImport("isExpired", "(Ljava/util/Date;)Z", AccessFlags = 1025)]
				bool IsExpired(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>CookieOrigin class incapsulates details of an origin server that are relevant when parsing, validating or matching HTTP cookies.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/CookieOrigin
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieOrigin", AccessFlags = 49)]
		public sealed partial class CookieOrigin
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;Z)V", AccessFlags = 1)]
				public CookieOrigin(string host, int port, string path, bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetHost() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
				public int GetPort() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1)]
				public bool IsSecure() /* MethodBuilder.Create */ 
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
				internal CookieOrigin() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				public string Host
				{
				[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetHost(); }
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPath(); }
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
				[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return GetPort(); }
				}

		}

		/// <summary>
		/// <para>This cookie comparator can be used to compare identity of cookies.</para><para>Cookies are considered identical if their names are equal and their domain attributes match ignoring case. </para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/CookieIdentityComparator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieIdentityComparator", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/util/Comparator<Lorg/apache/http/co" +
    "okie/Cookie;>;")]
		public partial class CookieIdentityComparator : global::Java.Io.ISerializable, global::Java.Util.IComparator<global::Org.Apache.Http.Cookie.ICookie>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CookieIdentityComparator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/Cookie;)I", AccessFlags = 1)]
				public virtual int Compare(global::Org.Apache.Http.Cookie.ICookie c1, global::Org.Apache.Http.Cookie.ICookie c2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Comparator", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>Signals that a cookie is in some way invalid or illegal in a given context</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/MalformedCookieException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/MalformedCookieException", AccessFlags = 33)]
		public partial class MalformedCookieException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new MalformedCookieException with a <code>null</code> detail message. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedCookieException() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new MalformedCookieException with a specified message string.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedCookieException(string message) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new MalformedCookieException with the specified detail message and cause.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public MalformedCookieException(string message, global::System.Exception cause) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Cookie specification registry that can be used to obtain the corresponding cookie specification implementation for a given type of type or version of cookie.</para><para><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/CookieSpecRegistry
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieSpecRegistry", AccessFlags = 49)]
		public sealed partial class CookieSpecRegistry
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CookieSpecRegistry() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Registers a CookieSpecFactory with the given identifier. If a specification with the given name already exists it will be overridden. This nameis the same one used to retrieve the CookieSpecFactory from getCookieSpec(String).</para><para><para>#getCookieSpec(String) </para></para>        
				/// </summary>
				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/lang/String;Lorg/apache/http/cookie/CookieSpecFactory;)V", AccessFlags = 33)]
				public void Register(string name, global::Org.Apache.Http.Cookie.ICookieSpecFactory factory) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unregisters the CookieSpecFactory with the given ID.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unregister
				/// </java-name>
				[Dot42.DexImport("unregister", "(Ljava/lang/String;)V", AccessFlags = 33)]
				public void Unregister(string id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the cookie specification with the given ID.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>cookie specification</para>
				/// </returns>
				/// <java-name>
				/// getCookieSpec
				/// </java-name>
				[Dot42.DexImport("getCookieSpec", "(Ljava/lang/String;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/Co" +
    "okieSpec;", AccessFlags = 33)]
				public global::Org.Apache.Http.Cookie.ICookieSpec GetCookieSpec(string name, global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

				/// <summary>
				/// <para>Gets the cookie specification with the given name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>cookie specification</para>
				/// </returns>
				/// <java-name>
				/// getCookieSpec
				/// </java-name>
				[Dot42.DexImport("getCookieSpec", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieSpec;", AccessFlags = 33)]
				public global::Org.Apache.Http.Cookie.ICookieSpec GetCookieSpec(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

				/// <summary>
				/// <para>Obtains a list containing names of all registered cookie specs in their default order.</para><para>Note that the DEFAULT policy (if present) is likely to be the same as one of the other policies, but does not have to be.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of registered cookie spec names </para>
				/// </returns>
				/// <java-name>
				/// getSpecNames
				/// </java-name>
				[Dot42.DexImport("getSpecNames", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
				public global::Java.Util.IList<string> GetSpecNames() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<string>);
				}

				/// <summary>
				/// <para>Populates the internal collection of registered cookie specs with the content of the map passed as a parameter.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setItems
				/// </java-name>
				[Dot42.DexImport("setItems", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/cookie/CookieSpecFactory;>;)V")]
				public void SetItems(global::Java.Util.IMap<string, global::Org.Apache.Http.Cookie.ICookieSpecFactory> map) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains a list containing names of all registered cookie specs in their default order.</para><para>Note that the DEFAULT policy (if present) is likely to be the same as one of the other policies, but does not have to be.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>list of registered cookie spec names </para>
				/// </returns>
				/// <java-name>
				/// getSpecNames
				/// </java-name>
				public global::Java.Util.IList<string> SpecNames
				{
				[Dot42.DexImport("getSpecNames", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return GetSpecNames(); }
				}

		}

		/// <summary>
		/// <para>This interface represents a <code>SetCookie</code> response header sent by the origin server to the HTTP agent in order to maintain a conversational state.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/SetCookie
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/SetCookie", AccessFlags = 1537)]
		public partial interface ISetCookie : global::Org.Apache.Http.Cookie.ICookie
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetValue(string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If a user agent (web browser) presents this cookie to a user, the cookie's purpose will be described using this comment.</para><para><para>getComment() </para></para>        
				/// </summary>
				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetComment(string comment) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets expiration date. </para><para><b>Note:</b> the object returned by this method is considered immutable. Changing it (e.g. using setTime()) could result in undefined behaviour. Do so at your peril.</para><para><para>Cookie::getExpiryDate </para></para>        
				/// </summary>
				/// <java-name>
				/// setExpiryDate
				/// </java-name>
				[Dot42.DexImport("setExpiryDate", "(Ljava/util/Date;)V", AccessFlags = 1025)]
				void SetExpiryDate(global::Java.Util.Date expiryDate) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the domain attribute.</para><para><para>Cookie::getDomain </para></para>        
				/// </summary>
				/// <java-name>
				/// setDomain
				/// </java-name>
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetDomain(string domain) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the path attribute.</para><para><para>Cookie::getPath </para></para>        
				/// </summary>
				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetPath(string path) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the secure attribute of the cookie. </para><para>When <code>true</code> the cookie should only be sent using a secure protocol (https). This should only be set when the cookie's originating server used a secure protocol to set the cookie's value.</para><para><para>isSecure() </para></para>        
				/// </summary>
				/// <java-name>
				/// setSecure
				/// </java-name>
				[Dot42.DexImport("setSecure", "(Z)V", AccessFlags = 1025)]
				void SetSecure(bool secure) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the version of the cookie specification to which this cookie conforms.</para><para><para>Cookie::getVersion </para></para>        
				/// </summary>
				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1025)]
				void SetVersion(int version) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>ClientCookie extends the standard Cookie interface with additional client specific functionality such ability to retrieve original cookie attributes exactly as they were specified by the origin server. This is important for generating the <code>Cookie</code> header because some cookie specifications require that the <code>Cookie</code> header should include certain attributes only if they were specified in the <code>Set-Cookie</code> header.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/ClientCookie
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/ClientCookie", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IClientCookieConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// VERSION_ATTR
				/// </java-name>
				[Dot42.DexImport("VERSION_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string VERSION_ATTR = "version";
				/// <java-name>
				/// PATH_ATTR
				/// </java-name>
				[Dot42.DexImport("PATH_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PATH_ATTR = "path";
				/// <java-name>
				/// DOMAIN_ATTR
				/// </java-name>
				[Dot42.DexImport("DOMAIN_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DOMAIN_ATTR = "domain";
				/// <java-name>
				/// MAX_AGE_ATTR
				/// </java-name>
				[Dot42.DexImport("MAX_AGE_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string MAX_AGE_ATTR = "max-age";
				/// <java-name>
				/// SECURE_ATTR
				/// </java-name>
				[Dot42.DexImport("SECURE_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SECURE_ATTR = "secure";
				/// <java-name>
				/// COMMENT_ATTR
				/// </java-name>
				[Dot42.DexImport("COMMENT_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COMMENT_ATTR = "comment";
				/// <java-name>
				/// EXPIRES_ATTR
				/// </java-name>
				[Dot42.DexImport("EXPIRES_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXPIRES_ATTR = "expires";
				/// <java-name>
				/// PORT_ATTR
				/// </java-name>
				[Dot42.DexImport("PORT_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PORT_ATTR = "port";
				/// <java-name>
				/// COMMENTURL_ATTR
				/// </java-name>
				[Dot42.DexImport("COMMENTURL_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string COMMENTURL_ATTR = "commenturl";
				/// <java-name>
				/// DISCARD_ATTR
				/// </java-name>
				[Dot42.DexImport("DISCARD_ATTR", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DISCARD_ATTR = "discard";
		}

		/// <summary>
		/// <para>ClientCookie extends the standard Cookie interface with additional client specific functionality such ability to retrieve original cookie attributes exactly as they were specified by the origin server. This is important for generating the <code>Cookie</code> header because some cookie specifications require that the <code>Cookie</code> header should include certain attributes only if they were specified in the <code>Set-Cookie</code> header.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/ClientCookie
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/ClientCookie", AccessFlags = 1537)]
		public partial interface IClientCookie : global::Org.Apache.Http.Cookie.ICookie
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
				string GetAttribute(string name) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// containsAttribute
				/// </java-name>
				[Dot42.DexImport("containsAttribute", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool ContainsAttribute(string name) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Ths interface represents a cookie attribute handler responsible for parsing, validating, and matching a specific cookie attribute, such as path, domain, port, etc.</para><para>Different cookie specifications can provide a specific implementation for this class based on their cookie handling rules.</para><para><para> (Samit Jain)</para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/CookieAttributeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieAttributeHandler", AccessFlags = 1537)]
		public partial interface ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Parse the given cookie attribute value and update the corresponding org.apache.http.cookie.Cookie property.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1025)]
				void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Peforms cookie validation for the given attribute value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1025)]
				void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Matches the given value (property of the destination host where request is being submitted) with the corresponding cookie attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the match is successful; <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1025)]
				bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/cookie/CookieSpecFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieSpecFactory", AccessFlags = 1537)]
		public partial interface ICookieSpecFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", AccessFlags = 1025)]
				global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ ;

		}

}


