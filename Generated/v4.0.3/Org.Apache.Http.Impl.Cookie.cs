#pragma warning disable 1717
namespace Org.Apache.Http.Impl.Cookie
{
		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2965DiscardAttributeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2965DiscardAttributeHandler", AccessFlags = 33)]
		public partial class RFC2965DiscardAttributeHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2965DiscardAttributeHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2965DomainAttributeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2965DomainAttributeHandler", AccessFlags = 33)]
		public partial class RFC2965DomainAttributeHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2965DomainAttributeHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// domainMatch
				/// </java-name>
				[Dot42.DexImport("domainMatch", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool DomainMatch(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/NetscapeDraftHeaderParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/NetscapeDraftHeaderParser", AccessFlags = 33)]
		public partial class NetscapeDraftHeaderParser
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/impl/cookie/NetscapeDraftHeaderParser;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Impl.Cookie.NetscapeDraftHeaderParser DEFAULT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NetscapeDraftHeaderParser() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseHeader
				/// </java-name>
				[Dot42.DexImport("parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement ParseHeader(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Message.ParserCursor parserCursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BestMatchSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BestMatchSpec", AccessFlags = 33)]
		public partial class BestMatchSpec : global::Org.Apache.Http.Cookie.ICookieSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Ljava/lang/String;Z)V", AccessFlags = 1)]
				public BestMatchSpec(string[] @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BestMatchSpec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public virtual global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public virtual global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public virtual int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BasicPathHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicPathHandler", AccessFlags = 33)]
		public partial class BasicPathHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicPathHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/DateUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/DateUtils", AccessFlags = 49)]
		public sealed partial class DateUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PATTERN_RFC1123
				/// </java-name>
				[Dot42.DexImport("PATTERN_RFC1123", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PATTERN_RFC1123 = "EEE, dd MMM yyyy HH:mm:ss zzz";
				/// <java-name>
				/// PATTERN_RFC1036
				/// </java-name>
				[Dot42.DexImport("PATTERN_RFC1036", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PATTERN_RFC1036 = "EEEE, dd-MMM-yy HH:mm:ss zzz";
				/// <java-name>
				/// PATTERN_ASCTIME
				/// </java-name>
				[Dot42.DexImport("PATTERN_ASCTIME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PATTERN_ASCTIME = "EEE MMM d HH:mm:ss yyyy";
				/// <java-name>
				/// GMT
				/// </java-name>
				[Dot42.DexImport("GMT", "Ljava/util/TimeZone;", AccessFlags = 25)]
				public static readonly global::Java.Util.TimeZone GMT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DateUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseDate
				/// </java-name>
				[Dot42.DexImport("parseDate", "(Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 9)]
				public static global::Java.Util.Date ParseDate(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// parseDate
				/// </java-name>
				[Dot42.DexImport("parseDate", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 9)]
				public static global::Java.Util.Date ParseDate(string @string, string[] string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// parseDate
				/// </java-name>
				[Dot42.DexImport("parseDate", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Date;)Ljava/util/Date;", AccessFlags = 9)]
				public static global::Java.Util.Date ParseDate(string @string, string[] string1, global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// formatDate
				/// </java-name>
				[Dot42.DexImport("formatDate", "(Ljava/util/Date;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatDate(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatDate
				/// </java-name>
				[Dot42.DexImport("formatDate", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatDate(global::Java.Util.Date date, string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2109Spec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2109Spec", AccessFlags = 33)]
		public partial class RFC2109Spec : global::Org.Apache.Http.Impl.Cookie.CookieSpecBase
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Ljava/lang/String;Z)V", AccessFlags = 1)]
				public RFC2109Spec(string[] @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2109Spec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				/// <java-name>
				/// formatParamAsVer
				/// </java-name>
				[Dot42.DexImport("formatParamAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal virtual void FormatParamAsVer(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatCookieAsVer
				/// </java-name>
				[Dot42.DexImport("formatCookieAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/cookie/Cookie;I)V", AccessFlags = 4)]
				protected internal virtual void FormatCookieAsVer(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Cookie.ICookie cookie, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public override int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BasicCommentHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicCommentHandler", AccessFlags = 33)]
		public partial class BasicCommentHandler : global::Org.Apache.Http.Impl.Cookie.AbstractCookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicCommentHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BasicMaxAgeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicMaxAgeHandler", AccessFlags = 33)]
		public partial class BasicMaxAgeHandler : global::Org.Apache.Http.Impl.Cookie.AbstractCookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicMaxAgeHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2965VersionAttributeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2965VersionAttributeHandler", AccessFlags = 33)]
		public partial class RFC2965VersionAttributeHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2965VersionAttributeHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2965SpecFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2965SpecFactory", AccessFlags = 33)]
		public partial class RFC2965SpecFactory : global::Org.Apache.Http.Cookie.ICookieSpecFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2965SpecFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BasicClientCookie
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicClientCookie", AccessFlags = 33)]
		public partial class BasicClientCookie : global::Org.Apache.Http.Cookie.ISetCookie, global::Org.Apache.Http.Cookie.IClientCookie, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicClientCookie(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetValue(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getComment
				/// </java-name>
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetComment() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetComment(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCommentURL
				/// </java-name>
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCommentURL() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getExpiryDate
				/// </java-name>
				[Dot42.DexImport("getExpiryDate", "()Ljava/util/Date;", AccessFlags = 1)]
				public virtual global::Java.Util.Date GetExpiryDate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// setExpiryDate
				/// </java-name>
				[Dot42.DexImport("setExpiryDate", "(Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void SetExpiryDate(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPersistent
				/// </java-name>
				[Dot42.DexImport("isPersistent", "()Z", AccessFlags = 1)]
				public virtual bool IsPersistent() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// setDomain
				/// </java-name>
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetDomain(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPath(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1)]
				public virtual bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSecure
				/// </java-name>
				[Dot42.DexImport("setSecure", "(Z)V", AccessFlags = 1)]
				public virtual void SetSecure(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPorts
				/// </java-name>
				[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1)]
				public virtual int[] GetPorts() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public virtual int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
				public virtual void SetVersion(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isExpired
				/// </java-name>
				[Dot42.DexImport("isExpired", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public virtual bool IsExpired(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAttribute
				/// </java-name>
				[Dot42.DexImport("setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAttribute(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAttribute(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// containsAttribute
				/// </java-name>
				[Dot42.DexImport("containsAttribute", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ContainsAttribute(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				internal BasicClientCookie() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetValue(value); }
				}

				/// <java-name>
				/// getComment
				/// </java-name>
				public string Comment
				{
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetComment(); }
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetComment(value); }
				}

				/// <java-name>
				/// getCommentURL
				/// </java-name>
				public string CommentURL
				{
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCommentURL(); }
				}

				/// <java-name>
				/// getExpiryDate
				/// </java-name>
				public global::Java.Util.Date ExpiryDate
				{
				[Dot42.DexImport("getExpiryDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return GetExpiryDate(); }
				[Dot42.DexImport("setExpiryDate", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ SetExpiryDate(value); }
				}

				/// <java-name>
				/// getDomain
				/// </java-name>
				public string Domain
				{
				[Dot42.DexImport("getDomain", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDomain(); }
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetDomain(value); }
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public string Path
				{
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPath(); }
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPath(value); }
				}

				/// <java-name>
				/// getPorts
				/// </java-name>
				public int[] Ports
				{
				[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1)]
						get{ return GetPorts(); }
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
						set{ SetVersion(value); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BasicClientCookie2
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicClientCookie2", AccessFlags = 33)]
		public partial class BasicClientCookie2 : global::Org.Apache.Http.Impl.Cookie.BasicClientCookie, global::Org.Apache.Http.Cookie.ISetCookie2
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicClientCookie2(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPorts
				/// </java-name>
				[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1)]
				public override int[] GetPorts() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// setPorts
				/// </java-name>
				[Dot42.DexImport("setPorts", "([I)V", AccessFlags = 1)]
				public virtual void SetPorts(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCommentURL
				/// </java-name>
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetCommentURL() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setCommentURL
				/// </java-name>
				[Dot42.DexImport("setCommentURL", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCommentURL(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDiscard
				/// </java-name>
				[Dot42.DexImport("setDiscard", "(Z)V", AccessFlags = 1)]
				public virtual void SetDiscard(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPersistent
				/// </java-name>
				[Dot42.DexImport("isPersistent", "()Z", AccessFlags = 1)]
				public override bool IsPersistent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isExpired
				/// </java-name>
				[Dot42.DexImport("isExpired", "(Ljava/util/Date;)Z", AccessFlags = 1)]
				public override bool IsExpired(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicClientCookie2() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setValue", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetValue(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setComment", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetComment(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setExpiryDate", "(Ljava/util/Date;)V", AccessFlags = 1025)]
				public override void SetExpiryDate(global::Java.Util.Date date) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setDomain", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetDomain(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setPath", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetPath(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setSecure", "(Z)V", AccessFlags = 1025)]
				public override void SetSecure(bool boolean) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setVersion", "(I)V", AccessFlags = 1025)]
				public override void SetVersion(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetName() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetValue() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getComment", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetComment() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getExpiryDate", "()Ljava/util/Date;", AccessFlags = 1025)]
				public override global::Java.Util.Date GetExpiryDate() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.Date);
				}

				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getDomain", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetDomain() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getPath", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string GetPath() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(string);
				}

				[Dot42.DexImport("org/apache/http/cookie/Cookie", "isSecure", "()Z", AccessFlags = 1025)]
				public override bool IsSecure() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getVersion", "()I", AccessFlags = 1025)]
				public override int GetVersion() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPorts
				/// </java-name>
				public int[] Ports
				{
				[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1)]
						get{ return GetPorts(); }
				}

				/// <java-name>
				/// getCommentURL
				/// </java-name>
				public string CommentURL
				{
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCommentURL(); }
				}

				public string Name
				{
				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetName(); }
				}

				public string Value
				{
				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getValue", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetValue(); }
				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setValue", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetValue(value); }
				}

				public string Comment
				{
				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getComment", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetComment(); }
				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setComment", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetComment(value); }
				}

				public global::Java.Util.Date ExpiryDate
				{
				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getExpiryDate", "()Ljava/util/Date;", AccessFlags = 1025)]
						get{ return GetExpiryDate(); }
				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setExpiryDate", "(Ljava/util/Date;)V", AccessFlags = 1025)]
						set{ SetExpiryDate(value); }
				}

				public string Domain
				{
				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getDomain", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetDomain(); }
				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setDomain", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetDomain(value); }
				}

				public string Path
				{
				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getPath", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetPath(); }
				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setPath", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						set{ SetPath(value); }
				}

				public int Version
				{
				[Dot42.DexImport("org/apache/http/cookie/Cookie", "getVersion", "()I", AccessFlags = 1025)]
						get{ return GetVersion(); }
				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setVersion", "(I)V", AccessFlags = 1025)]
						set{ SetVersion(value); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2109VersionHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2109VersionHandler", AccessFlags = 33)]
		public partial class RFC2109VersionHandler : global::Org.Apache.Http.Impl.Cookie.AbstractCookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2109VersionHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2965PortAttributeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2965PortAttributeHandler", AccessFlags = 33)]
		public partial class RFC2965PortAttributeHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2965PortAttributeHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BestMatchSpecFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BestMatchSpecFactory", AccessFlags = 33)]
		public partial class BestMatchSpecFactory : global::Org.Apache.Http.Cookie.ICookieSpecFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BestMatchSpecFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2109DomainHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2109DomainHandler", AccessFlags = 33)]
		public partial class RFC2109DomainHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2109DomainHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/NetscapeDraftSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/NetscapeDraftSpec", AccessFlags = 33)]
		public partial class NetscapeDraftSpec : global::Org.Apache.Http.Impl.Cookie.CookieSpecBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EXPIRES_PATTERN
				/// </java-name>
				[Dot42.DexImport("EXPIRES_PATTERN", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string EXPIRES_PATTERN = "EEE, dd-MMM-yyyy HH:mm:ss z";
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public NetscapeDraftSpec(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NetscapeDraftSpec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public override int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BasicSecureHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicSecureHandler", AccessFlags = 33)]
		public partial class BasicSecureHandler : global::Org.Apache.Http.Impl.Cookie.AbstractCookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicSecureHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public override bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2965CommentUrlAttributeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2965CommentUrlAttributeHandler", AccessFlags = 33)]
		public partial class RFC2965CommentUrlAttributeHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2965CommentUrlAttributeHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/CookieSpecBase
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/CookieSpecBase", AccessFlags = 1057)]
		public abstract partial class CookieSpecBase : global::Org.Apache.Http.Impl.Cookie.AbstractCookieSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CookieSpecBase() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultPath
				/// </java-name>
				[Dot42.DexImport("getDefaultPath", "(Lorg/apache/http/cookie/CookieOrigin;)Ljava/lang/String;", AccessFlags = 12)]
				protected internal static string GetDefaultPath(global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDefaultDomain
				/// </java-name>
				[Dot42.DexImport("getDefaultDomain", "(Lorg/apache/http/cookie/CookieOrigin;)Ljava/lang/String;", AccessFlags = 12)]
				protected internal static string GetDefaultDomain(global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "([Lorg/apache/http/HeaderElement;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util" +
    "/List;", AccessFlags = 4, Signature = "([Lorg/apache/http/HeaderElement;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util" +
    "/List<Lorg/apache/http/cookie/Cookie;>;")]
				protected internal virtual global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeaderElement[] headerElement, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public override bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2965Spec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2965Spec", AccessFlags = 33)]
		public partial class RFC2965Spec : global::Org.Apache.Http.Impl.Cookie.RFC2109Spec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2965Spec() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/String;Z)V", AccessFlags = 1)]
				public RFC2965Spec(string[] @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public override bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// formatCookieAsVer
				/// </java-name>
				[Dot42.DexImport("formatCookieAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/cookie/Cookie;I)V", AccessFlags = 4)]
				protected internal override void FormatCookieAsVer(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.Cookie.ICookie cookie, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public override int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BasicExpiresHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicExpiresHandler", AccessFlags = 33)]
		public partial class BasicExpiresHandler : global::Org.Apache.Http.Impl.Cookie.AbstractCookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicExpiresHandler(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicExpiresHandler() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2109SpecFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2109SpecFactory", AccessFlags = 33)]
		public partial class RFC2109SpecFactory : global::Org.Apache.Http.Cookie.ICookieSpecFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2109SpecFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/NetscapeDomainHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/NetscapeDomainHandler", AccessFlags = 33)]
		public partial class NetscapeDomainHandler : global::Org.Apache.Http.Impl.Cookie.BasicDomainHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NetscapeDomainHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public override bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BrowserCompatSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BrowserCompatSpec", AccessFlags = 33)]
		public partial class BrowserCompatSpec : global::Org.Apache.Http.Impl.Cookie.CookieSpecBase
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DATE_PATTERNS
				/// </java-name>
				[Dot42.DexImport("DATE_PATTERNS", "[Ljava/lang/String;", AccessFlags = 28)]
				protected internal static readonly string[] DATE_PATTERNS;
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public BrowserCompatSpec(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BrowserCompatSpec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public override int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/AbstractCookieSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/AbstractCookieSpec", AccessFlags = 1057)]
		public abstract partial class AbstractCookieSpec : global::Org.Apache.Http.Cookie.ICookieSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractCookieSpec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerAttribHandler
				/// </java-name>
				[Dot42.DexImport("registerAttribHandler", "(Ljava/lang/String;Lorg/apache/http/cookie/CookieAttributeHandler;)V", AccessFlags = 1)]
				public virtual void RegisterAttribHandler(string @string, global::Org.Apache.Http.Cookie.ICookieAttributeHandler cookieAttributeHandler) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findAttribHandler
				/// </java-name>
				[Dot42.DexImport("findAttribHandler", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieAttributeHandler;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Cookie.ICookieAttributeHandler FindAttribHandler(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieAttributeHandler);
				}

				/// <java-name>
				/// getAttribHandler
				/// </java-name>
				[Dot42.DexImport("getAttribHandler", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieAttributeHandler;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Cookie.ICookieAttributeHandler GetAttribHandler(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieAttributeHandler);
				}

				/// <java-name>
				/// getAttribHandlers
				/// </java-name>
				[Dot42.DexImport("getAttribHandlers", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Lorg/apache/http/cookie/CookieAttributeHandler;>;")]
				protected internal virtual global::Java.Util.ICollection<global::Org.Apache.Http.Cookie.ICookieAttributeHandler> GetAttribHandlers() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Org.Apache.Http.Cookie.ICookieAttributeHandler>);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "getVersion", "()I", AccessFlags = 1025)]
				public virtual int GetVersion() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public virtual global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1025)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1025)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public virtual global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> list) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.IHeader GetVersionHeader() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getAttribHandlers
				/// </java-name>
				protected internal global::Java.Util.ICollection<global::Org.Apache.Http.Cookie.ICookieAttributeHandler> AttribHandlers
				{
				[Dot42.DexImport("getAttribHandlers", "()Ljava/util/Collection;", AccessFlags = 4, Signature = "()Ljava/util/Collection<Lorg/apache/http/cookie/CookieAttributeHandler;>;")]
						get{ return GetAttribHandlers(); }
				}

				public int Version
				{
				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "getVersion", "()I", AccessFlags = 1025)]
						get{ return GetVersion(); }
				}

				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BasicDomainHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicDomainHandler", AccessFlags = 33)]
		public partial class BasicDomainHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicDomainHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/BrowserCompatSpecFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BrowserCompatSpecFactory", AccessFlags = 33)]
		public partial class BrowserCompatSpecFactory : global::Org.Apache.Http.Cookie.ICookieSpecFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BrowserCompatSpecFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/DateParseException
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/DateParseException", AccessFlags = 33)]
		public partial class DateParseException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateParseException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DateParseException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/AbstractCookieAttributeHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/AbstractCookieAttributeHandler", AccessFlags = 1057)]
		public abstract partial class AbstractCookieAttributeHandler : global::Org.Apache.Http.Cookie.ICookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractCookieAttributeHandler() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin cookieOrigin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieAttributeHandler", "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie setCookie, string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <java-name>
		/// org/apache/http/impl/cookie/NetscapeDraftSpecFactory
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/NetscapeDraftSpecFactory", AccessFlags = 33)]
		public partial class NetscapeDraftSpecFactory : global::Org.Apache.Http.Cookie.ICookieSpecFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NetscapeDraftSpecFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams httpParams) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

		}

}

