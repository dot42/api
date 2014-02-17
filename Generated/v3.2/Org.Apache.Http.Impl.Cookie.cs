// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Impl.Cookie.cs
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
namespace Org.Apache.Http.Impl.Cookie
{
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
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
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
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
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
				public virtual global::Org.Apache.Http.IHeaderElement ParseHeader(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

		}

		/// <summary>
		/// <para>RFC 2965 specific cookie management functions.</para><para><para> (Samit Jain) </para><simplesectsep></simplesectsep><para></para><para>3.1 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2965Spec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2965Spec", AccessFlags = 33)]
		public partial class RFC2965Spec : global::Org.Apache.Http.Impl.Cookie.RFC2109Spec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2965Spec() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([Ljava/lang/String;Z)V", AccessFlags = 1)]
				public RFC2965Spec(string[] datepatterns, bool oneHeader) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public override bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds valid Port attribute value, e.g. "8000,8001,8002" </para>        
				/// </summary>
				/// <java-name>
				/// formatCookieAsVer
				/// </java-name>
				[Dot42.DexImport("formatCookieAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/cookie/Cookie;I)V", AccessFlags = 4)]
				protected internal override void FormatCookieAsVer(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Cookie.ICookie cookie, int version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public override int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <summary>
		/// <para><code>"Port"</code> cookie attribute handler for RFC 2965 cookie spec. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Parse cookie port attribute. </para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string portValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Validate cookie port attribute. If the Port attribute was specified in header, the request port must be in cookie's port list. </para>        
				/// </summary>
				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Match cookie port attribute. If the Port attribute is not specified in header, the cookie can be sent to any port. Otherwise, the request port must be in the cookie's port list. </para>        
				/// </summary>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

		}

		/// <summary>
		/// <para>RFC 2109 compliant cookie policy</para><para><para>B.C. Holmes </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Rod Waldhoff </para><simplesectsep></simplesectsep><para>dIon Gillard </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Marc A. Saegesser </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/cookie/RFC2109Spec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/RFC2109Spec", AccessFlags = 33)]
		public partial class RFC2109Spec : global::Org.Apache.Http.Impl.Cookie.CookieSpecBase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/String;Z)V", AccessFlags = 1)]
				public RFC2109Spec(string[] datepatterns, bool oneHeader) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RFC2109Spec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create <code>"Cookie"</code> headers for an array of Cookies.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a Header for the given Cookies. </para>
				/// </returns>
				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> cookies) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				/// <summary>
				/// <para>Return a name/value string suitable for sending in a <code>"Cookie"</code> header as defined in RFC 2109 for backward compatibility with cookie version 0 </para>        
				/// </summary>
				/// <java-name>
				/// formatParamAsVer
				/// </java-name>
				[Dot42.DexImport("formatParamAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 4)]
				protected internal virtual void FormatParamAsVer(global::Org.Apache.Http.Util.CharArrayBuffer buffer, string name, string value, int version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a string suitable for sending in a <code>"Cookie"</code> header as defined in RFC 2109 for backward compatibility with cookie version 0 </para>        
				/// </summary>
				/// <java-name>
				/// formatCookieAsVer
				/// </java-name>
				[Dot42.DexImport("formatCookieAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/cookie/Cookie;I)V", AccessFlags = 4)]
				protected internal virtual void FormatCookieAsVer(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Cookie.ICookie cookie, int version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public override int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
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
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Matches the given value (property of the destination host where request is being submitted) with the corresponding cookie attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the match is successful; <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public override bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>'Meta' cookie specification that selects a cookie policy depending on the format of the cookie(s)</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/cookie/BestMatchSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BestMatchSpec", AccessFlags = 33)]
		public partial class BestMatchSpec : global::Org.Apache.Http.Cookie.ICookieSpec
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Ljava/lang/String;Z)V", AccessFlags = 1)]
				public BestMatchSpec(string[] datepatterns, bool oneHeader) /* MethodBuilder.Create */ 
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
				public virtual global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public virtual global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> cookies) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public virtual int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <summary>
		/// <para>HTTP "magic-cookie" represents a piece of state information that the HTTP agent and the target server can exchange to maintain a session.</para><para><para>B.C. Holmes </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Rod Waldhoff </para><simplesectsep></simplesectsep><para>dIon Gillard </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Marc A. Saegesser </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>659191 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/cookie/BasicClientCookie
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicClientCookie", AccessFlags = 33)]
		public partial class BasicClientCookie : global::Org.Apache.Http.Cookie.ISetCookie, global::Org.Apache.Http.Cookie.IClientCookie, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default Constructor taking a name and a value. The value may be null.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicClientCookie(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String name The name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String value The current value. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the value</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetValue(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the comment describing the purpose of this cookie, or <code>null</code> if no such comment has been defined.</para><para><para>setComment(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>comment</para>
				/// </returns>
				/// <java-name>
				/// getComment
				/// </java-name>
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetComment() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>If a user agent (web browser) presents this cookie to a user, the cookie's purpose will be described using this comment.</para><para><para>getComment() </para></para>        
				/// </summary>
				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetComment(string comment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns null. Cookies prior to RFC2965 do not set this attribute </para>        
				/// </summary>
				/// <java-name>
				/// getCommentURL
				/// </java-name>
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetCommentURL() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the expiration Date of the cookie, or <code>null</code> if none exists. </para><para><b>Note:</b> the object returned by this method is considered immutable. Changing it (e.g. using setTime()) could result in undefined behaviour. Do so at your peril. </para><para><para>setExpiryDate(java.util.Date) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Expiration Date, or <code>null</code>.</para>
				/// </returns>
				/// <java-name>
				/// getExpiryDate
				/// </java-name>
				[Dot42.DexImport("getExpiryDate", "()Ljava/util/Date;", AccessFlags = 1)]
				public virtual global::Java.Util.Date GetExpiryDate() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Sets expiration date. </para><para><b>Note:</b> the object returned by this method is considered immutable. Changing it (e.g. using setTime()) could result in undefined behaviour. Do so at your peril.</para><para><para>getExpiryDate </para></para>        
				/// </summary>
				/// <java-name>
				/// setExpiryDate
				/// </java-name>
				[Dot42.DexImport("setExpiryDate", "(Ljava/util/Date;)V", AccessFlags = 1)]
				public virtual void SetExpiryDate(global::Java.Util.Date expiryDate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns <code>false</code> if the cookie should be discarded at the end of the "session"; <code>true</code> otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> if the cookie should be discarded at the end of the "session"; <code>true</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isPersistent
				/// </java-name>
				[Dot42.DexImport("isPersistent", "()Z", AccessFlags = 1)]
				public virtual bool IsPersistent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns domain attribute of the cookie.</para><para><para>setDomain(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the domain attribute</para>
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
				/// <para>Sets the domain attribute.</para><para><para>getDomain </para></para>        
				/// </summary>
				/// <java-name>
				/// setDomain
				/// </java-name>
				[Dot42.DexImport("setDomain", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetDomain(string domain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the path attribute of the cookie</para><para><para>setPath(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of the path attribute.</para>
				/// </returns>
				/// <java-name>
				/// getPath
				/// </java-name>
				[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPath() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the path attribute.</para><para><para>getPath </para></para>        
				/// </summary>
				/// <java-name>
				/// setPath
				/// </java-name>
				[Dot42.DexImport("setPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPath(string path) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setSecure(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if this cookie should only be sent over secure connections. </para>
				/// </returns>
				/// <java-name>
				/// isSecure
				/// </java-name>
				[Dot42.DexImport("isSecure", "()Z", AccessFlags = 1)]
				public virtual bool IsSecure() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the secure attribute of the cookie. </para><para>When <code>true</code> the cookie should only be sent using a secure protocol (https). This should only be set when the cookie's originating server used a secure protocol to set the cookie's value.</para><para><para>isSecure() </para></para>        
				/// </summary>
				/// <java-name>
				/// setSecure
				/// </java-name>
				[Dot42.DexImport("setSecure", "(Z)V", AccessFlags = 1)]
				public virtual void SetSecure(bool secure) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns null. Cookies prior to RFC2965 do not set this attribute </para>        
				/// </summary>
				/// <java-name>
				/// getPorts
				/// </java-name>
				[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1)]
				public virtual int[] GetPorts() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				/// <para>Returns the version of the cookie specification to which this cookie conforms.</para><para><para>setVersion(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the version of the cookie.</para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public virtual int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the version of the cookie specification to which this cookie conforms.</para><para><para>getVersion </para></para>        
				/// </summary>
				/// <java-name>
				/// setVersion
				/// </java-name>
				[Dot42.DexImport("setVersion", "(I)V", AccessFlags = 1)]
				public virtual void SetVersion(int version) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if this cookie has expired. </para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the cookie has expired. </para>
				/// </returns>
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
				public virtual void SetAttribute(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAttribute(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// containsAttribute
				/// </java-name>
				[Dot42.DexImport("containsAttribute", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ContainsAttribute(string name) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Returns the name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String name The name </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <summary>
				/// <para>Returns the value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>String value The current value. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns the comment describing the purpose of this cookie, or <code>null</code> if no such comment has been defined.</para><para><para>setComment(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>comment</para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns null. Cookies prior to RFC2965 do not set this attribute </para>        
				/// </summary>
				/// <java-name>
				/// getCommentURL
				/// </java-name>
				public string CommentURL
				{
				[Dot42.DexImport("getCommentURL", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetCommentURL(); }
				}

				/// <summary>
				/// <para>Returns the expiration Date of the cookie, or <code>null</code> if none exists. </para><para><b>Note:</b> the object returned by this method is considered immutable. Changing it (e.g. using setTime()) could result in undefined behaviour. Do so at your peril. </para><para><para>setExpiryDate(java.util.Date) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Expiration Date, or <code>null</code>.</para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns domain attribute of the cookie.</para><para><para>setDomain(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the value of the domain attribute</para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns the path attribute of the cookie</para><para><para>setPath(java.lang.String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of the path attribute.</para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns null. Cookies prior to RFC2965 do not set this attribute </para>        
				/// </summary>
				/// <java-name>
				/// getPorts
				/// </java-name>
				public int[] Ports
				{
				[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1)]
						get{ return GetPorts(); }
				}

				/// <summary>
				/// <para>Returns the version of the cookie specification to which this cookie conforms.</para><para><para>setVersion(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the version of the cookie.</para>
				/// </returns>
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
		/// org/apache/http/impl/cookie/BasicExpiresHandler
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicExpiresHandler", AccessFlags = 33)]
		public partial class BasicExpiresHandler : global::Org.Apache.Http.Impl.Cookie.AbstractCookieAttributeHandler
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicExpiresHandler(string[] datepatterns) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicExpiresHandler() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para><code>"CommantURL"</code> cookie attribute handler for RFC 2965 cookie spec. </para>    
		/// </summary>
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
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string commenturl) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

		}

		/// <summary>
		/// <para>A utility class for parsing and formatting HTTP dates as used in cookies and other headers. This class handles dates as defined by RFC 2616 section 3.3.1 as well as some other common non-standard formats.</para><para><para>Christopher Brown </para><simplesectsep></simplesectsep><para>Michael Becke </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/cookie/DateUtils
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/DateUtils", AccessFlags = 49)]
		public sealed partial class DateUtils
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Date format pattern used to parse HTTP date headers in RFC 1123 format. </para>        
				/// </summary>
				/// <java-name>
				/// PATTERN_RFC1123
				/// </java-name>
				[Dot42.DexImport("PATTERN_RFC1123", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PATTERN_RFC1123 = "EEE, dd MMM yyyy HH:mm:ss zzz";
				/// <summary>
				/// <para>Date format pattern used to parse HTTP date headers in RFC 1036 format. </para>        
				/// </summary>
				/// <java-name>
				/// PATTERN_RFC1036
				/// </java-name>
				[Dot42.DexImport("PATTERN_RFC1036", "Ljava/lang/String;", AccessFlags = 25)]
				public const string PATTERN_RFC1036 = "EEEE, dd-MMM-yy HH:mm:ss zzz";
				/// <summary>
				/// <para>Date format pattern used to parse HTTP date headers in ANSI C <code>asctime()</code> format. </para>        
				/// </summary>
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
				/// <summary>
				/// <para>This class should not be instantiated. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DateUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parses a date value. The formats used for parsing the date value are retrieved from the default http params.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed date</para>
				/// </returns>
				/// <java-name>
				/// parseDate
				/// </java-name>
				[Dot42.DexImport("parseDate", "(Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 9)]
				public static global::Java.Util.Date ParseDate(string dateValue) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Parses the date value using the given date formats.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed date</para>
				/// </returns>
				/// <java-name>
				/// parseDate
				/// </java-name>
				[Dot42.DexImport("parseDate", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 9)]
				public static global::Java.Util.Date ParseDate(string dateValue, string[] dateFormats) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Parses the date value using the given date formats.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed date</para>
				/// </returns>
				/// <java-name>
				/// parseDate
				/// </java-name>
				[Dot42.DexImport("parseDate", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Date;)Ljava/util/Date;", AccessFlags = 9)]
				public static global::Java.Util.Date ParseDate(string dateValue, string[] dateFormats, global::Java.Util.Date startDate) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <summary>
				/// <para>Formats the given date according to the RFC 1123 pattern.</para><para><para>PATTERN_RFC1123 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An RFC 1123 formatted date string.</para>
				/// </returns>
				/// <java-name>
				/// formatDate
				/// </java-name>
				[Dot42.DexImport("formatDate", "(Ljava/util/Date;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatDate(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Formats the given date according to the specified pattern. The pattern must conform to that used by the simple date format class.</para><para><para>SimpleDateFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A formatted date string.</para>
				/// </returns>
				/// <java-name>
				/// formatDate
				/// </java-name>
				[Dot42.DexImport("formatDate", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string FormatDate(global::Java.Util.Date date, string pattern) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para><code>"Discard"</code> cookie attribute handler for RFC 2965 cookie spec. </para>    
		/// </summary>
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
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string commenturl) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieAttributeHandler", "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1025)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <summary>
		/// <para><code>"Version"</code> cookie attribute handler for RFC 2965 cookie spec. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Parse cookie version attribute. </para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>validate cookie version attribute. Version attribute is REQUIRED. </para>        
				/// </summary>
				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para><code>"Domain"</code> cookie attribute handler for RFC 2965 cookie spec.</para><para><para> (Samit Jain)</para><para>3.1 </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Parse cookie domain attribute. </para>        
				/// </summary>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string domain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Performs domain-match as defined by the RFC2965. </para><para>Host A's name domain-matches host B's if <ol><li></li></ol><ul><li></li></ul>host name strings string-compare equal; or <ul><li></li></ul>is a HDN string and has the form NB, where N is a non-empty name string, B has the form .B', and B' is a HDN string. (So, x.y.com domain-matches .Y.com but not Y.com.) </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the specified host matches the given domain. </para>
				/// </returns>
				/// <java-name>
				/// domainMatch
				/// </java-name>
				[Dot42.DexImport("domainMatch", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool DomainMatch(string host, string domain) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Validate cookie domain attribute. </para>        
				/// </summary>
				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Match cookie domain attribute. </para>        
				/// </summary>
				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
				}

		}

		/// <summary>
		/// <para>Netscape cookie draft compliant cookie policy</para><para><para>B.C. Holmes </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Rod Waldhoff </para><simplesectsep></simplesectsep><para>dIon Gillard </para><simplesectsep></simplesectsep><para>Sean C. Sullivan </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>Marc A. Saegesser </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para>4.0 </para></para>    
		/// </summary>
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
				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public NetscapeDraftSpec(string[] datepatterns) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NetscapeDraftSpec() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parses the Set-Cookie value into an array of <code>Cookie</code>s.</para><para>Syntax of the Set-Cookie HTTP Response Header:</para><para>This is the format a CGI script would use to add to the HTTP headers a new piece of data which is to be stored by the client for later retrieval.</para><para><pre>
				///          Set-Cookie: NAME=VALUE; expires=DATE; path=PATH; domain=DOMAIN_NAME; secure
				///         </pre></para><para>Please note that Netscape draft specification does not fully conform to the HTTP header format. Netscape draft does not specify whether multiple cookies may be sent in one header. Hence, comma character may be present in unquoted cookie value or unquoted parameter value.</para><para><para></para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of <code>Cookie</code>s parsed from the Set-Cookie value </para>
				/// </returns>
				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> cookies) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public override int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				public global::Org.Apache.Http.IHeader VersionHeader
				{
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetVersionHeader(); }
				}

		}

		/// <summary>
		/// <para>HTTP "magic-cookie" represents a piece of state information that the HTTP agent and the target server can exchange to maintain a session as specified by RFC2965.</para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/cookie/BasicClientCookie2
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BasicClientCookie2", AccessFlags = 33)]
		public partial class BasicClientCookie2 : global::Org.Apache.Http.Impl.Cookie.BasicClientCookie, global::Org.Apache.Http.Cookie.ISetCookie2
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default Constructor taking a name and a value. The value may be null.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicClientCookie2(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns null. Cookies prior to RFC2965 do not set this attribute </para>        
				/// </summary>
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
				public virtual void SetPorts(int[] ports) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns null. Cookies prior to RFC2965 do not set this attribute </para>        
				/// </summary>
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
				public virtual void SetCommentURL(string commentURL) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the Discard attribute.</para><para>Note: <code>Discard</code> attribute overrides <code>Max-age</code>.</para><para><para>isPersistent() </para></para>        
				/// </summary>
				/// <java-name>
				/// setDiscard
				/// </java-name>
				[Dot42.DexImport("setDiscard", "(Z)V", AccessFlags = 1)]
				public virtual void SetDiscard(bool discard) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns <code>false</code> if the cookie should be discarded at the end of the "session"; <code>true</code> otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>false</code> if the cookie should be discarded at the end of the "session"; <code>true</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isPersistent
				/// </java-name>
				[Dot42.DexImport("isPersistent", "()Z", AccessFlags = 1)]
				public override bool IsPersistent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this cookie has expired. </para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the cookie has expired. </para>
				/// </returns>
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
				public override void SetValue(string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setComment", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetComment(string comment) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setExpiryDate", "(Ljava/util/Date;)V", AccessFlags = 1025)]
				public override void SetExpiryDate(global::Java.Util.Date expiryDate) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setDomain", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetDomain(string domain) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setPath", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetPath(string path) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setSecure", "(Z)V", AccessFlags = 1025)]
				public override void SetSecure(bool secure) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/SetCookie", "setVersion", "(I)V", AccessFlags = 1025)]
				public override void SetVersion(int version) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

				/// <summary>
				/// <para>Returns null. Cookies prior to RFC2965 do not set this attribute </para>        
				/// </summary>
				/// <java-name>
				/// getPorts
				/// </java-name>
				public int[] Ports
				{
				[Dot42.DexImport("getPorts", "()[I", AccessFlags = 1)]
						get{ return GetPorts(); }
				}

				/// <summary>
				/// <para>Returns null. Cookies prior to RFC2965 do not set this attribute </para>        
				/// </summary>
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

		/// <summary>
		/// <para>Cookie specification that strives to closely mimic (mis)behavior of common web browser applications such as Microsoft Internet Explorer and Mozilla FireFox.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/cookie/BrowserCompatSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/BrowserCompatSpec", AccessFlags = 33)]
		public partial class BrowserCompatSpec : global::Org.Apache.Http.Impl.Cookie.CookieSpecBase
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Valid date patterns used per default </para>        
				/// </summary>
				/// <java-name>
				/// DATE_PATTERNS
				/// </java-name>
				[Dot42.DexImport("DATE_PATTERNS", "[Ljava/lang/String;", AccessFlags = 28)]
				protected internal static readonly string[] DATE_PATTERNS;
				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public BrowserCompatSpec(string[] datepatterns) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BrowserCompatSpec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", AccessFlags = 1, Signature = "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List<Lo" +
    "rg/apache/http/cookie/Cookie;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// formatCookies
				/// </java-name>
				[Dot42.DexImport("formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public override global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> cookies) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.IHeader>);
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
				public override int GetVersion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
				/// <java-name>
				/// getVersionHeader
				/// </java-name>
				[Dot42.DexImport("getVersionHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public override global::Org.Apache.Http.IHeader GetVersionHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns version of the state management this cookie specification conforms to.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>version of the state management specification </para>
				/// </returns>
				/// <java-name>
				/// getVersion
				/// </java-name>
				public int Version
				{
				[Dot42.DexImport("getVersion", "()I", AccessFlags = 1)]
						get{ return GetVersion(); }
				}

				/// <summary>
				/// <para>Returns a request header identifying what version of the state management specification is understood. May be <code>null</code> if the cookie specification does not support <code>Cookie2</code> header. </para>        
				/// </summary>
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
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Abstract cookie specification which can delegate the job of parsing, validation or matching cookie attributes to a number of arbitrary CookieAttributeHandlers.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/impl/cookie/AbstractCookieSpec
		/// </java-name>
		[Dot42.DexImport("org/apache/http/impl/cookie/AbstractCookieSpec", AccessFlags = 1057)]
		public abstract partial class AbstractCookieSpec : global::Org.Apache.Http.Cookie.ICookieSpec
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default constructor </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractCookieSpec() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerAttribHandler
				/// </java-name>
				[Dot42.DexImport("registerAttribHandler", "(Ljava/lang/String;Lorg/apache/http/cookie/CookieAttributeHandler;)V", AccessFlags = 1)]
				public virtual void RegisterAttribHandler(string name, global::Org.Apache.Http.Cookie.ICookieAttributeHandler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finds an attribute handler CookieAttributeHandler for the given attribute. Returns <code>null</code> if no attribute handler is found for the specified attribute.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an attribute handler or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// findAttribHandler
				/// </java-name>
				[Dot42.DexImport("findAttribHandler", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieAttributeHandler;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Cookie.ICookieAttributeHandler FindAttribHandler(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieAttributeHandler);
				}

				/// <summary>
				/// <para>Gets attribute handler CookieAttributeHandler for the given attribute.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getAttribHandler
				/// </java-name>
				[Dot42.DexImport("getAttribHandler", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieAttributeHandler;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Cookie.ICookieAttributeHandler GetAttribHandler(string name) /* MethodBuilder.Create */ 
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
				public virtual global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1025)]
				public virtual void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1025)]
				public virtual bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/cookie/CookieSpec", "formatCookies", "(Ljava/util/List;)Ljava/util/List;", AccessFlags = 1025, Signature = "(Ljava/util/List<Lorg/apache/http/cookie/Cookie;>;)Ljava/util/List<Lorg/apache/ht" +
    "tp/Header;>;")]
				public virtual global::Java.Util.IList<global::Org.Apache.Http.IHeader> FormatCookies(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> cookies) /* TypeBuilder.AddAbstractInterfaceMethods */ 
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

		/// <summary>
		/// <para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				public virtual global::Org.Apache.Http.Cookie.ICookieSpec NewInstance(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Cookie.ICookieSpec);
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
				public override void Parse(global::Org.Apache.Http.Cookie.ISetCookie cookie, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public override bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>Cookie management functions shared by all specification.</para><para><para></para><para>4.0 </para></para>    
		/// </summary>
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
				protected internal static string GetDefaultPath(global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDefaultDomain
				/// </java-name>
				[Dot42.DexImport("getDefaultDomain", "(Lorg/apache/http/cookie/CookieOrigin;)Ljava/lang/String;", AccessFlags = 12)]
				protected internal static string GetDefaultDomain(global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "([Lorg/apache/http/HeaderElement;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util" +
    "/List;", AccessFlags = 4, Signature = "([Lorg/apache/http/HeaderElement;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util" +
    "/List<Lorg/apache/http/cookie/Cookie;>;")]
				protected internal virtual global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie> Parse(global::Org.Apache.Http.IHeaderElement[] elems, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Org.Apache.Http.Cookie.ICookie>);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", AccessFlags = 1)]
				public override void Validate(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z", AccessFlags = 1)]
				public override bool Match(global::Org.Apache.Http.Cookie.ICookie cookie, global::Org.Apache.Http.Cookie.CookieOrigin origin) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>An exception to indicate an error parsing a date string.</para><para><para>DateUtils</para><para>Michael Becke </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DateParseException(string message) /* MethodBuilder.Create */ 
				{
				}

		}

}


