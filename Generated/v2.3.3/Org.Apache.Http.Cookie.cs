#pragma warning disable 1717
namespace Org.Apache.Http.Cookie
{
		/// <java-name>
		/// org/apache/http/cookie/CookieIdentityComparator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieIdentityComparator", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/util/Comparator<Lorg/apache/http/co" +
    "okie/Cookie;>;")]
		public partial class CookieIdentityComparator : global::Java.IO.ISerializable, global::Java.Util.IComparator<global::Org.Apache.Http.Cookie.ICookie>
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
				public virtual int Compare(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.ICookie cookie1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Comparator", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/cookie/CookieOrigin
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieOrigin", AccessFlags = 49)]
		public sealed partial class CookieOrigin
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;ILjava/lang/String;Z)V", AccessFlags = 1)]
				public CookieOrigin(string @string, int int32, string string1, bool boolean) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal CookieOrigin() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHost
				/// </java-name>
				public string Host
				{
						[Dot42.DexImport("getHost", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
						[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				public bool IsSecure
				{
						[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// org/apache/http/cookie/CookiePathComparator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookiePathComparator", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/util/Comparator<Lorg/apache/http/co" +
    "okie/Cookie;>;")]
		public partial class CookiePathComparator : global::Java.IO.ISerializable, global::Java.Util.IComparator<global::Org.Apache.Http.Cookie.ICookie>
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
				public virtual int Compare(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.ICookie cookie1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("java/util/Comparator", "equals", "(Ljava/lang/Object;)Z", AccessFlags = 1025)]
				public override bool Equals(object @object) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

		}

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

				/// <java-name>
				/// register
				/// </java-name>
				[Dot42.DexImport("register", "(Ljava/lang/String;Lorg/apache/http/cookie/CookieSpecFactory;)V", AccessFlags = 33)]
				public void Register(string @string, global::Org.Apache.Http.Cookie.ICookieSpecFactory cookieSpecFactory) /* MethodBuilder.Create */ 
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
				/// getCookieSpec
				/// </java-name>
				[Dot42.DexImport("getCookieSpec", "(Ljava/lang/String;Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/Co" +
    "okieSpec;", AccessFlags = 33)]
				public global::Org.Apache.Http.Cookie.ICookieSpec GetCookieSpec(string @string, global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

				/// <java-name>
				/// getCookieSpec
				/// </java-name>
				[Dot42.DexImport("getCookieSpec", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieSpec;", AccessFlags = 33)]
				public global::Org.Apache.Http.Cookie.ICookieSpec GetCookieSpec(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

				/// <java-name>
				/// setItems
				/// </java-name>
				[Dot42.DexImport("setItems", "(Ljava/util/Map;)V", AccessFlags = 33, Signature = "(Ljava/util/Map<Ljava/lang/String;Lorg/apache/http/cookie/CookieSpecFactory;>;)V")]
				public void SetItems(global::Java.Util.IMap<string, global::Org.Apache.Http.Cookie.ICookieSpecFactory> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpecNames
				/// </java-name>
				public global::Java.Util.IList<string> SpecNames
				{
						[Dot42.DexImport("getSpecNames", "()Ljava/util/List;", AccessFlags = 33, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IList<string>); }
				}

		}

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
				string GetAttribute(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// containsAttribute
				/// </java-name>
				[Dot42.DexImport("containsAttribute", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				bool ContainsAttribute(string @string) /* MethodBuilder.Create */ ;

		}

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

		/// <java-name>
		/// org/apache/http/cookie/Cookie
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/Cookie", AccessFlags = 1537)]
		public partial interface ICookie
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isExpired
				/// </java-name>
				[Dot42.DexImport("isExpired", "(Ljava/util/Date;)Z", AccessFlags = 1025)]
				bool IsExpired(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				string Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getComment
				/// </java-name>
				string Comment
				{
						[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getCommentURL
				/// </java-name>
				string CommentURL
				{
						[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getExpiryDate
				/// </java-name>
				global::Java.Util.Date ExpiryDate
				{
						[Dot42.DexImport("getExpiryDate", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isPersistent
				/// </java-name>
				bool IsPersistent
				{
						[Dot42.DexImport("isPersistent", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getDomain
				/// </java-name>
				string Domain
				{
						[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				string Path
				{
						[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPorts
				/// </java-name>
				int[] Ports
				{
						[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				bool IsSecure
				{
						[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// org/apache/http/cookie/CookieAttributeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieAttributeHandler", AccessFlags = 1537)]
		public partial interface ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1025)]
				void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1025)]
				void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1025)]
				bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/cookie/CookieSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/CookieSpec", AccessFlags = 1537)]
		public partial interface ICookieSpec
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1025)]
				void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1025)]
				bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> list) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getVersion
				/// </java-name>
				int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				global::Org.Apache.Http.IHeader VersionHeader
				{
						[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
						get;
				}

		}

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
				global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ ;

		}

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
				void SetValue(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetComment(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setExpiryDate
				/// </java-name>
				[Dot42.DexImport("setExpiryDate", "(Ljava/util/Date;)V", AccessFlags = 1025)]
				void SetExpiryDate(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDomain
				/// </java-name>
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetDomain(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetPath(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSecure
				/// </java-name>
				[Dot42.DexImport("setSecure", "(Z)V", AccessFlags = 1025)]
				void SetSecure(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1025)]
				void SetVersion(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/cookie/SetCookie2
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/SetCookie2", AccessFlags = 1537)]
		public partial interface ISetCookie2 : global::Org.Apache.Http.Cookie.ISetCookie
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setCommentURL
				/// </java-name>
				[Dot42.DexImport("setCommentURL", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				void SetCommentURL(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setPorts
				/// </java-name>
				[Dot42.DexImport("setPorts", "([I)V", AccessFlags = 1025)]
				void SetPorts(int[] int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setDiscard
				/// </java-name>
				[Dot42.DexImport("setDiscard", "(Z)V", AccessFlags = 1025)]
				void SetDiscard(bool boolean) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// org/apache/http/cookie/SM
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/SM", AccessFlags = 1537)]
		public partial interface ISM
 /* scope: __dot42__ */ 
		{
		}

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

		/// <java-name>
		/// org/apache/http/cookie/MalformedCookieException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/cookie/MalformedCookieException", AccessFlags = 33)]
		public partial class MalformedCookieException : global::Org.Apache.Http.ProtocolException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MalformedCookieException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MalformedCookieException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public MalformedCookieException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

}

