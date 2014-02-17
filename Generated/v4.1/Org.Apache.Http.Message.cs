// Copyright (C) 2014 dot42
//
// Original filename: Org.Apache.Http.Message.cs
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
namespace Org.Apache.Http.Message
{
		/// <summary>
		/// <para>Basic implementation for parsing header values into elements. Instances of this class are stateless and thread-safe. Derived classes are expected to maintain these properties.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>and others</para><para></para><title>Revision:</title><para>595670 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHeaderValueParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderValueParser", AccessFlags = 33)]
		public partial class BasicHeaderValueParser : global::Org.Apache.Http.Message.IHeaderValueParser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A default instance of this class, for use as default or fallback. Note that BasicHeaderValueParser is not a singleton, there can be many instances of the class itself and of derived classes. The instance here provides non-customized, default behavior. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/message/BasicHeaderValueParser;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Message.BasicHeaderValueParser DEFAULT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHeaderValueParser() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseElements
				/// </java-name>
				[Dot42.DexImport("parseElements", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/" +
    "HeaderElement;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IHeaderElement[] ParseElements(string buffer, global::Org.Apache.Http.Message.IHeaderValueParser cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement[]);
				}

				/// <java-name>
				/// parseElements
				/// </java-name>
				[Dot42.DexImport("parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lo" +
    "rg/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement[] ParseElements(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement[]);
				}

				/// <java-name>
				/// parseHeaderElement
				/// </java-name>
				[Dot42.DexImport("parseHeaderElement", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/H" +
    "eaderElement;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IHeaderElement ParseHeaderElement(string buffer, global::Org.Apache.Http.Message.IHeaderValueParser cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

				/// <java-name>
				/// parseHeaderElement
				/// </java-name>
				[Dot42.DexImport("parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement ParseHeaderElement(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

				/// <summary>
				/// <para>Creates a header element. Called from parseHeaderElement.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a header element representing the argument </para>
				/// </returns>
				/// <java-name>
				/// createHeaderElement
				/// </java-name>
				[Dot42.DexImport("createHeaderElement", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)Lorg/apache" +
    "/http/HeaderElement;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IHeaderElement CreateHeaderElement(string name, string value, global::Org.Apache.Http.INameValuePair[] @params) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

				/// <java-name>
				/// parseParameters
				/// </java-name>
				[Dot42.DexImport("parseParameters", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/" +
    "NameValuePair;", AccessFlags = 25)]
				public static global::Org.Apache.Http.INameValuePair[] ParseParameters(string buffer, global::Org.Apache.Http.Message.IHeaderValueParser cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair[]);
				}

				/// <java-name>
				/// parseParameters
				/// </java-name>
				[Dot42.DexImport("parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lo" +
    "rg/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair[] ParseParameters(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair[]);
				}

				/// <java-name>
				/// parseNameValuePair
				/// </java-name>
				[Dot42.DexImport("parseNameValuePair", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/N" +
    "ameValuePair;", AccessFlags = 25)]
				public static global::Org.Apache.Http.INameValuePair ParseNameValuePair(string buffer, global::Org.Apache.Http.Message.IHeaderValueParser cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <java-name>
				/// parseNameValuePair
				/// </java-name>
				[Dot42.DexImport("parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair ParseNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <java-name>
				/// parseNameValuePair
				/// </java-name>
				[Dot42.DexImport("parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;[C)L" +
    "org/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair ParseNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor, char[] delimiters) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <summary>
				/// <para>Creates a name-value pair. Called from parseNameValuePair.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a name-value pair representing the arguments </para>
				/// </returns>
				/// <java-name>
				/// createNameValuePair
				/// </java-name>
				[Dot42.DexImport("createNameValuePair", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/NameValuePair;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.INameValuePair CreateNameValuePair(string name, string value) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

		}

		/// <summary>
		/// <para>Implementation of a HeaderIterator based on a List. For use by HeaderGroup.</para><para><para></para><title>Revision:</title><para>584542 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicListHeaderIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicListHeaderIterator", AccessFlags = 33)]
		public partial class BasicListHeaderIterator : global::Org.Apache.Http.IHeaderIterator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A list of headers to iterate over. Not all elements of this array are necessarily part of the iteration. </para>        
				/// </summary>
				/// <java-name>
				/// allHeaders
				/// </java-name>
				[Dot42.DexImport("allHeaders", "Ljava/util/List;", AccessFlags = 20)]
				protected internal readonly global::Java.Util.IList<object> AllHeaders;
				/// <summary>
				/// <para>The position of the next header in allHeaders. Negative if the iteration is over. </para>        
				/// </summary>
				/// <java-name>
				/// currentIndex
				/// </java-name>
				[Dot42.DexImport("currentIndex", "I", AccessFlags = 4)]
				protected internal int CurrentIndex;
				/// <summary>
				/// <para>The position of the last returned header. Negative if none has been returned so far. </para>        
				/// </summary>
				/// <java-name>
				/// lastIndex
				/// </java-name>
				[Dot42.DexImport("lastIndex", "I", AccessFlags = 4)]
				protected internal int LastIndex;
				/// <summary>
				/// <para>The header name to filter by. <code>null</code> to iterate over all headers in the array. </para>        
				/// </summary>
				/// <java-name>
				/// headerName
				/// </java-name>
				[Dot42.DexImport("headerName", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string HeaderName;
				/// <summary>
				/// <para>Creates a new header iterator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/List;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicListHeaderIterator(global::Java.Util.IList<object> headers, string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Determines the index of the next header.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the next header that matches the filter name, or negative if there are no more headers </para>
				/// </returns>
				/// <java-name>
				/// findNext
				/// </java-name>
				[Dot42.DexImport("findNext", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindNext(int from) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Checks whether a header is part of the iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the header should be part of the iteration, <code>false</code> to skip </para>
				/// </returns>
				/// <java-name>
				/// filterHeader
				/// </java-name>
				[Dot42.DexImport("filterHeader", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool FilterHeader(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether there is another header in this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is another header, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public virtual bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the next header from this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next header in this iteration</para>
				/// </returns>
				/// <java-name>
				/// nextHeader
				/// </java-name>
				[Dot42.DexImport("nextHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader NextHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns the next header. Same as nextHeader, but not type-safe.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next header in this iteration</para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Next() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Removes the header that was returned last. </para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public virtual void Remove() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicListHeaderIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This class represents a context of a parsing operation: <ul><li><para>the current position the parsing operation is expected to start at </para></li><li><para>the bounds limiting the scope of the parsing operation </para></li></ul></para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/ParserCursor
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/ParserCursor", AccessFlags = 33)]
		public partial class ParserCursor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public ParserCursor(int lowerBound, int upperBound) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLowerBound
				/// </java-name>
				[Dot42.DexImport("getLowerBound", "()I", AccessFlags = 1)]
				public virtual int GetLowerBound() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getUpperBound
				/// </java-name>
				[Dot42.DexImport("getUpperBound", "()I", AccessFlags = 1)]
				public virtual int GetUpperBound() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPos
				/// </java-name>
				[Dot42.DexImport("getPos", "()I", AccessFlags = 1)]
				public virtual int GetPos() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// updatePos
				/// </java-name>
				[Dot42.DexImport("updatePos", "(I)V", AccessFlags = 1)]
				public virtual void UpdatePos(int pos) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// atEnd
				/// </java-name>
				[Dot42.DexImport("atEnd", "()Z", AccessFlags = 1)]
				public virtual bool AtEnd() /* MethodBuilder.Create */ 
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
				internal ParserCursor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLowerBound
				/// </java-name>
				public int LowerBound
				{
				[Dot42.DexImport("getLowerBound", "()I", AccessFlags = 1)]
						get{ return GetLowerBound(); }
				}

				/// <java-name>
				/// getUpperBound
				/// </java-name>
				public int UpperBound
				{
				[Dot42.DexImport("getUpperBound", "()I", AccessFlags = 1)]
						get{ return GetUpperBound(); }
				}

				/// <java-name>
				/// getPos
				/// </java-name>
				public int Pos
				{
				[Dot42.DexImport("getPos", "()I", AccessFlags = 1)]
						get{ return GetPos(); }
				}

		}

		/// <summary>
		/// <para>Interface for parsing header values into elements. Instances of this interface are expected to be stateless and thread-safe.</para><para><para></para><title>Revision:</title><para>589325 </para><title>Date:</title><para>2007-10-28 03:37:56 -0700 (Sun, 28 Oct 2007) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/HeaderValueParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/HeaderValueParser", AccessFlags = 1537)]
		public partial interface IHeaderValueParser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Parses a header value into elements. Parse errors are indicated as <code>RuntimeException</code>. </para><para>Some HTTP headers (such as the set-cookie header) have values that can be decomposed into multiple elements. In order to be processed by this parser, such headers must be in the following form: </para><para><pre>
				///        header  = [ element ] *( "," [ element ] )
				///        element = name [ "=" [ value ] ] *( ";" [ param ] )
				///        param   = name [ "=" [ value ] ]
				/// 
				///        name    = token
				///        value   = ( token | quoted-string )
				/// 
				///        token         = 1*&lt;any char except "=", ",", ";", &lt;"&gt; and
				///                              white space&gt;
				///        quoted-string = &lt;"&amp;gt; *( text | quoted-char ) &amp;lt;"&gt;
				///        text          = any char except &lt;"&amp;gt;
				///        quoted-char   = "" char
				///        </pre> </para><para>Any amount of white space is allowed between any part of the header, element or param and is ignored. A missing value in any element or param will be stored as the empty String; if the "=" is also missing <b>null</b> will be stored instead. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array holding all elements of the header value</para>
				/// </returns>
				/// <java-name>
				/// parseElements
				/// </java-name>
				[Dot42.DexImport("parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lo" +
    "rg/apache/http/HeaderElement;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderElement[] ParseElements(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parses a single header element. A header element consist of a semicolon-separate list of name=value definitions.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed element</para>
				/// </returns>
				/// <java-name>
				/// parseHeaderElement
				/// </java-name>
				[Dot42.DexImport("parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/HeaderElement;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeaderElement ParseHeaderElement(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parses a list of name-value pairs. These lists are used to specify parameters to a header element. Parse errors are indicated as <code>RuntimeException</code>. </para><para>This method comforms to the generic grammar and formatting rules outlined in the  and  of . </para><para>&lt;h&gt;2.2 Basic Rules&lt;/h&gt; </para><para>The following rules are used throughout this specification to describe basic parsing constructs. The US-ASCII coded character set is defined by ANSI X3.4-1986. </para><para><pre>
				///            OCTET          = &lt;any 8-bit sequence of data&gt;
				///            CHAR           = &lt;any US-ASCII character (octets 0 - 127)&gt;
				///            UPALPHA        = &lt;any US-ASCII uppercase letter "A".."Z"&gt;
				///            LOALPHA        = &lt;any US-ASCII lowercase letter "a".."z"&gt;
				///            ALPHA          = UPALPHA | LOALPHA
				///            DIGIT          = &lt;any US-ASCII digit "0".."9"&gt;
				///            CTL            = &lt;any US-ASCII control character
				///                             (octets 0 - 31) and DEL (127)&gt;
				///            CR             = &lt;US-ASCII CR, carriage return (13)&gt;
				///            LF             = &lt;US-ASCII LF, linefeed (10)&gt;
				///            SP             = &lt;US-ASCII SP, space (32)&gt;
				///            HT             = &lt;US-ASCII HT, horizontal-tab (9)&gt;
				///            &lt;"&gt;            = &lt;US-ASCII double-quote mark (34)&gt;
				///        </pre> </para><para>Many HTTP/1.1 header field values consist of words separated by LWS or special characters. These special characters MUST be in a quoted string to be used within a parameter value (as defined in section 3.6). </para><para><pre>
				///        token          = 1*&lt;any char="" except="" ctls="" or="" separators&gt;=""&gt;
				///        separators     = "(" | ")" | "&lt;" | "&gt;" | "@"
				///                       | "," | ";" | ":" | "\" | &lt;"&gt;
				///                       | "/" | "[" | "]" | "?" | "="
				///                       | "{" | "}" | SP | HT
				///        </pre> </para><para>A string of text is parsed as a single word if it is quoted using double-quote marks. </para><para><pre>
				///        quoted-string  = ( &lt;"&gt; *(qdtext | quoted-pair ) &lt;"&gt; )
				///        qdtext         = &lt;any TEXT except &lt;"&gt;&gt;
				///        </pre> </para><para>The backslash character ("\") MAY be used as a single-character quoting mechanism only within quoted-string and comment constructs. </para><para><pre>
				///        quoted-pair    = "\" CHAR
				///        </pre> &lt;h&gt;3.6 Transfer Codings&lt;/h&gt; </para><para>Parameters are in the form of attribute/value pairs. </para><para><pre>
				///        parameter               = attribute "=" value
				///        attribute               = token
				///        value                   = token | quoted-string
				///        </pre></para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array holding all items of the name-value list</para>
				/// </returns>
				/// <java-name>
				/// parseParameters
				/// </java-name>
				[Dot42.DexImport("parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lo" +
    "rg/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair[] ParseParameters(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parses a name=value specification, where the = and value are optional.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the name-value pair, where the value is <code>null</code> if no value is specified </para>
				/// </returns>
				/// <java-name>
				/// parseNameValuePair
				/// </java-name>
				[Dot42.DexImport("parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/NameValuePair;", AccessFlags = 1025)]
				global::Org.Apache.Http.INameValuePair ParseNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Basic implementation for formatting header value elements. Instances of this class are stateless and thread-safe. Derived classes are expected to maintain these properties.</para><para><para> </para><simplesectsep></simplesectsep><para>and others</para><para></para><title>Revision:</title><para>574185 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHeaderValueFormatter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderValueFormatter", AccessFlags = 33)]
		public partial class BasicHeaderValueFormatter : global::Org.Apache.Http.Message.IHeaderValueFormatter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A default instance of this class, for use as default or fallback. Note that BasicHeaderValueFormatter is not a singleton, there can be many instances of the class itself and of derived classes. The instance here provides non-customized, default behavior. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/message/BasicHeaderValueFormatter;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Message.BasicHeaderValueFormatter DEFAULT;
				/// <summary>
				/// <para>Special characters that can be used as separators in HTTP parameters. These special characters MUST be in a quoted string to be used within a parameter value . </para>        
				/// </summary>
				/// <java-name>
				/// SEPARATORS
				/// </java-name>
				[Dot42.DexImport("SEPARATORS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SEPARATORS = " ;,:@()<>\\\"/[]?={}\t";
				/// <summary>
				/// <para>Unsafe special characters that must be escaped using the backslash character </para>        
				/// </summary>
				/// <java-name>
				/// UNSAFE_CHARS
				/// </java-name>
				[Dot42.DexImport("UNSAFE_CHARS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string UNSAFE_CHARS = "\"\\";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicHeaderValueFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// formatElements
				/// </java-name>
				[Dot42.DexImport("formatElements", "([Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)" +
    "Ljava/lang/String;", AccessFlags = 25)]
				public static string FormatElements(global::Org.Apache.Http.IHeaderElement[] headerElement, bool boolean, global::Org.Apache.Http.Message.IHeaderValueFormatter headerValueFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatElements
				/// </java-name>
				[Dot42.DexImport("formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatElements(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeaderElement[] headerElement, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Estimates the length of formatted header elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a length estimate, in number of characters </para>
				/// </returns>
				/// <java-name>
				/// estimateElementsLen
				/// </java-name>
				[Dot42.DexImport("estimateElementsLen", "([Lorg/apache/http/HeaderElement;)I", AccessFlags = 4)]
				protected internal virtual int EstimateElementsLen(global::Org.Apache.Http.IHeaderElement[] elems) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// formatHeaderElement
				/// </java-name>
				[Dot42.DexImport("formatHeaderElement", "(Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)L" +
    "java/lang/String;", AccessFlags = 25)]
				public static string FormatHeaderElement(global::Org.Apache.Http.IHeaderElement headerElement, bool boolean, global::Org.Apache.Http.Message.IHeaderValueFormatter headerValueFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatHeaderElement
				/// </java-name>
				[Dot42.DexImport("formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apac" +
    "he/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatHeaderElement(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.IHeaderElement headerElement, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Estimates the length of a formatted header element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a length estimate, in number of characters </para>
				/// </returns>
				/// <java-name>
				/// estimateHeaderElementLen
				/// </java-name>
				[Dot42.DexImport("estimateHeaderElementLen", "(Lorg/apache/http/HeaderElement;)I", AccessFlags = 4)]
				protected internal virtual int EstimateHeaderElementLen(global::Org.Apache.Http.IHeaderElement elem) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// formatParameters
				/// </java-name>
				[Dot42.DexImport("formatParameters", "([Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)" +
    "Ljava/lang/String;", AccessFlags = 25)]
				public static string FormatParameters(global::Org.Apache.Http.INameValuePair[] nameValuePair, bool boolean, global::Org.Apache.Http.Message.IHeaderValueFormatter headerValueFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatParameters
				/// </java-name>
				[Dot42.DexImport("formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatParameters(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.INameValuePair[] nameValuePair, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Estimates the length of formatted parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a length estimate, in number of characters </para>
				/// </returns>
				/// <java-name>
				/// estimateParametersLen
				/// </java-name>
				[Dot42.DexImport("estimateParametersLen", "([Lorg/apache/http/NameValuePair;)I", AccessFlags = 4)]
				protected internal virtual int EstimateParametersLen(global::Org.Apache.Http.INameValuePair[] nvps) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// formatNameValuePair
				/// </java-name>
				[Dot42.DexImport("formatNameValuePair", "(Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)L" +
    "java/lang/String;", AccessFlags = 25)]
				public static string FormatNameValuePair(global::Org.Apache.Http.INameValuePair nameValuePair, bool boolean, global::Org.Apache.Http.Message.IHeaderValueFormatter headerValueFormatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// formatNameValuePair
				/// </java-name>
				[Dot42.DexImport("formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apac" +
    "he/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer charArrayBuffer, global::Org.Apache.Http.INameValuePair nameValuePair, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Estimates the length of a formatted name-value pair.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a length estimate, in number of characters </para>
				/// </returns>
				/// <java-name>
				/// estimateNameValuePairLen
				/// </java-name>
				[Dot42.DexImport("estimateNameValuePairLen", "(Lorg/apache/http/NameValuePair;)I", AccessFlags = 4)]
				protected internal virtual int EstimateNameValuePairLen(global::Org.Apache.Http.INameValuePair nvp) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Actually formats the value of a name-value pair. This does not include a leading = character. Called from formatNameValuePair.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// doFormatValue
				/// </java-name>
				[Dot42.DexImport("doFormatValue", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Z)V", AccessFlags = 4)]
				protected internal virtual void DoFormatValue(global::Org.Apache.Http.Util.CharArrayBuffer buffer, string value, bool quote) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether a character is a separator.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the character is a separator, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isSeparator
				/// </java-name>
				[Dot42.DexImport("isSeparator", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsSeparator(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether a character is unsafe.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the character is unsafe, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isUnsafe
				/// </java-name>
				[Dot42.DexImport("isUnsafe", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsUnsafe(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>A class for combining a set of headers. This class allows for multiple headers with the same name and keeps track of the order in which headers were added.</para><para><para>Michael Becke</para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/HeaderGroup
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/HeaderGroup", AccessFlags = 33)]
		public partial class HeaderGroup : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor for HeaderGroup. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HeaderGroup() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes any contained headers. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the given header to the group. The order in which this header was added is preserved.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void AddHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes the given header.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeHeader
				/// </java-name>
				[Dot42.DexImport("removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void RemoveHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Replaces the first occurence of the header with the same name. If no header with the same name is found the given header is added to the end of the list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateHeader
				/// </java-name>
				[Dot42.DexImport("updateHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void UpdateHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets all of the headers contained within this group overriding any existing headers. The headers are added in the order in which they appear in the array.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setHeaders
				/// </java-name>
				[Dot42.DexImport("setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetHeaders(global::Org.Apache.Http.IHeader[] headers) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets a header representing all of the header values with the given name. If more that one header with the given name exists the values will be combined with a "," as per RFC 2616.</para><para>Header name comparison is case insensitive.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a header with a condensed value or <code>null</code> if no headers by the given name are present </para>
				/// </returns>
				/// <java-name>
				/// getCondensedHeader
				/// </java-name>
				[Dot42.DexImport("getCondensedHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetCondensedHeader(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Gets all of the headers with the given name. The returned array maintains the relative order in which the headers were added.</para><para>Header name comparison is case insensitive.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of length &gt;= 0 </para>
				/// </returns>
				/// <java-name>
				/// getHeaders
				/// </java-name>
				[Dot42.DexImport("getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetHeaders(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <summary>
				/// <para>Gets the first header with the given name.</para><para>Header name comparison is case insensitive.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the first header or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getFirstHeader
				/// </java-name>
				[Dot42.DexImport("getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetFirstHeader(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Gets the last header with the given name.</para><para>Header name comparison is case insensitive.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the last header or <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLastHeader
				/// </java-name>
				[Dot42.DexImport("getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetLastHeader(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Gets all of the headers contained within this group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of length &gt;= 0 </para>
				/// </returns>
				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetAllHeaders() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <summary>
				/// <para>Tests if headers with the given name are contained within this group.</para><para>Header name comparison is case insensitive.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if at least one header with the name is contained, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// containsHeader
				/// </java-name>
				[Dot42.DexImport("containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ContainsHeader(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns an iterator over this group of headers.</para><para><para>4.0 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>iterator over this group of headers.</para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderIterator Iterator() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <summary>
				/// <para>Returns an iterator over the headers with a given name in this group.</para><para><para>4.0 </para></para>        
				/// </summary>
				/// <returns>
				/// <para>iterator over some headers in this group.</para>
				/// </returns>
				/// <java-name>
				/// iterator
				/// </java-name>
				[Dot42.DexImport("iterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderIterator Iterator(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <summary>
				/// <para>Returns a copy of this object</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>copy of this object </para>
				/// </returns>
				/// <java-name>
				/// copy
				/// </java-name>
				[Dot42.DexImport("copy", "()Lorg/apache/http/message/HeaderGroup;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Message.HeaderGroup Copy() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Message.HeaderGroup);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Gets all of the headers contained within this group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of length &gt;= 0 </para>
				/// </returns>
				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <summary>
		/// <para>Basic implementation of an HTTP response that can be modified. This implementation makes sure that there always is a status line.</para><para><para></para><para></para><title>Revision:</title><para>573864 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHttpResponse
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHttpResponse", AccessFlags = 33)]
		public partial class BasicHttpResponse : global::Org.Apache.Http.Message.AbstractHttpMessage, global::Org.Apache.Http.IHttpResponse
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new response. This is the constructor to which all others map.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/StatusLine;Lorg/apache/http/ReasonPhraseCatalog;Ljava/util/Loca" +
    "le;)V", AccessFlags = 1)]
				public BasicHttpResponse(global::Org.Apache.Http.IStatusLine statusline, global::Org.Apache.Http.IReasonPhraseCatalog catalog, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a response from a status line. The response will not have a reason phrase catalog and use the system default locale.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/StatusLine;)V", AccessFlags = 1)]
				public BasicHttpResponse(global::Org.Apache.Http.IStatusLine statusline) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new response. This is the constructor to which all others map.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", AccessFlags = 1)]
				public BasicHttpResponse(global::Org.Apache.Http.ProtocolVersion statusline, int catalog, string locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the protocol version this message is compatible with. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public override global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <summary>
				/// <para>Obtains the status line of this response. The status line can be set using one of the setStatusLine methods, or it can be initialized in a constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the status line, or <code>null</code> if not yet set </para>
				/// </returns>
				/// <java-name>
				/// getStatusLine
				/// </java-name>
				[Dot42.DexImport("getStatusLine", "()Lorg/apache/http/StatusLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IStatusLine GetStatusLine() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IStatusLine);
				}

				/// <summary>
				/// <para>Obtains the message entity of this response, if any. The entity is provided by calling setEntity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response entity, or <code>null</code> if there is none </para>
				/// </returns>
				/// <java-name>
				/// getEntity
				/// </java-name>
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpEntity GetEntity() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpEntity);
				}

				/// <summary>
				/// <para>Obtains the locale of this response. The locale is used to determine the reason phrase for the status code. It can be changed using setLocale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the locale of this response, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
				public virtual global::Java.Util.Locale GetLocale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/StatusLine;)V", AccessFlags = 1)]
				public virtual void SetStatusLine(global::Org.Apache.Http.IStatusLine statusline) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V", AccessFlags = 1)]
				public virtual void SetStatusLine(global::Org.Apache.Http.ProtocolVersion ver, int code) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStatusLine
				/// </java-name>
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetStatusLine(global::Org.Apache.Http.ProtocolVersion ver, int code, string reason) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates the status line of this response with a new status code. The status line can only be updated if it is available. It must have been set either explicitly or in a constructor. <br></br> The reason phrase will be updated according to the new status code, based on the current locale. It can be set explicitly using setReasonPhrase.</para><para><para>HttpStatus </para><simplesectsep></simplesectsep><para>setStatusLine(StatusLine) </para><simplesectsep></simplesectsep><para>setStatusLine(ProtocolVersion,int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setStatusCode
				/// </java-name>
				[Dot42.DexImport("setStatusCode", "(I)V", AccessFlags = 1)]
				public virtual void SetStatusCode(int code) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates the status line of this response with a new reason phrase. The status line can only be updated if it is available. It must have been set either explicitly or in a constructor.</para><para><para>setStatusLine(StatusLine) </para><simplesectsep></simplesectsep><para>setStatusLine(ProtocolVersion,int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setReasonPhrase
				/// </java-name>
				[Dot42.DexImport("setReasonPhrase", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetReasonPhrase(string reason) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEntity
				/// </java-name>
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public virtual void SetEntity(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the locale of this response. If there is a status line, it's reason phrase will be updated according to the status code and new locale.</para><para><para>getLocale getLocale </para><simplesectsep></simplesectsep><para>setStatusCode setStatusCode </para></para>        
				/// </summary>
				/// <java-name>
				/// setLocale
				/// </java-name>
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public virtual void SetLocale(global::Java.Util.Locale loc) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Looks up a reason phrase. This method evaluates the currently set catalog and locale. It also handles a missing catalog.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the reason phrase, or <code>null</code> if there is none </para>
				/// </returns>
				/// <java-name>
				/// getReason
				/// </java-name>
				[Dot42.DexImport("getReason", "(I)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetReason(int code) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHttpResponse() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetAllHeaders() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] headers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.Params.IHttpParams GetParams() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public override void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				/// <para>Returns the protocol version this message is compatible with. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <summary>
				/// <para>Obtains the status line of this response. The status line can be set using one of the setStatusLine methods, or it can be initialized in a constructor.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the status line, or <code>null</code> if not yet set </para>
				/// </returns>
				/// <java-name>
				/// getStatusLine
				/// </java-name>
				public global::Org.Apache.Http.IStatusLine StatusLine
				{
				[Dot42.DexImport("getStatusLine", "()Lorg/apache/http/StatusLine;", AccessFlags = 1)]
						get{ return GetStatusLine(); }
				[Dot42.DexImport("setStatusLine", "(Lorg/apache/http/StatusLine;)V", AccessFlags = 1)]
						set{ SetStatusLine(value); }
				}

				/// <summary>
				/// <para>Obtains the message entity of this response, if any. The entity is provided by calling setEntity.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the response entity, or <code>null</code> if there is none </para>
				/// </returns>
				/// <java-name>
				/// getEntity
				/// </java-name>
				public global::Org.Apache.Http.IHttpEntity Entity
				{
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
						get{ return GetEntity(); }
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
						set{ SetEntity(value); }
				}

				/// <summary>
				/// <para>Obtains the locale of this response. The locale is used to determine the reason phrase for the status code. It can be changed using setLocale.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the locale of this response, never <code>null</code> </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				public global::Java.Util.Locale Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return GetLocale(); }
				[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
						set{ SetLocale(value); }
				}

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <summary>
		/// <para>Basic implementation of a HeaderIterator.</para><para><para></para><title>Revision:</title><para>581981 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHeaderIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderIterator", AccessFlags = 33)]
		public partial class BasicHeaderIterator : global::Org.Apache.Http.IHeaderIterator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>An array of headers to iterate over. Not all elements of this array are necessarily part of the iteration. This array will never be modified by the iterator. Derived implementations are expected to adhere to this restriction. </para>        
				/// </summary>
				/// <java-name>
				/// allHeaders
				/// </java-name>
				[Dot42.DexImport("allHeaders", "[Lorg/apache/http/Header;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.IHeader[] AllHeaders;
				/// <summary>
				/// <para>The position of the next header in allHeaders. Negative if the iteration is over. </para>        
				/// </summary>
				/// <java-name>
				/// currentIndex
				/// </java-name>
				[Dot42.DexImport("currentIndex", "I", AccessFlags = 4)]
				protected internal int CurrentIndex;
				/// <summary>
				/// <para>The header name to filter by. <code>null</code> to iterate over all headers in the array. </para>        
				/// </summary>
				/// <java-name>
				/// headerName
				/// </java-name>
				[Dot42.DexImport("headerName", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string HeaderName;
				/// <summary>
				/// <para>Creates a new header iterator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Lorg/apache/http/Header;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHeaderIterator(global::Org.Apache.Http.IHeader[] headers, string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Determines the index of the next header.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the index of the next header that matches the filter name, or negative if there are no more headers </para>
				/// </returns>
				/// <java-name>
				/// findNext
				/// </java-name>
				[Dot42.DexImport("findNext", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindNext(int from) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Checks whether a header is part of the iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the header should be part of the iteration, <code>false</code> to skip </para>
				/// </returns>
				/// <java-name>
				/// filterHeader
				/// </java-name>
				[Dot42.DexImport("filterHeader", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool FilterHeader(int index) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether there is another header in this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is another header, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public virtual bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the next header from this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next header in this iteration</para>
				/// </returns>
				/// <java-name>
				/// nextHeader
				/// </java-name>
				[Dot42.DexImport("nextHeader", "()Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader NextHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns the next header. Same as nextHeader, but not type-safe.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next header in this iteration</para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Next() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Removing headers is not supported.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public virtual void Remove() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHeaderIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Basic implementation of a HeaderElementIterator.</para><para><para></para><title>Revision:</title><para>592088 </para></para><para><para>Andrea Selva &lt;selva.andre at gmail.com&gt; </para><simplesectsep></simplesectsep><para>Oleg Kalnichevski &lt;oleg at ural.ru&gt; </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHeaderElementIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderElementIterator", AccessFlags = 33)]
		public partial class BasicHeaderElementIterator : global::Org.Apache.Http.IHeaderElementIterator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new instance of BasicHeaderElementIterator </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HeaderIterator;Lorg/apache/http/message/HeaderValueParser;)V", AccessFlags = 1)]
				public BasicHeaderElementIterator(global::Org.Apache.Http.IHeaderIterator headerIterator, global::Org.Apache.Http.Message.IHeaderValueParser parser) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/HeaderIterator;)V", AccessFlags = 1)]
				public BasicHeaderElementIterator(global::Org.Apache.Http.IHeaderIterator headerIterator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether there is another header element in this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is another header element, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public virtual bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the next header element from this iteration. This method should only be called while hasNext is true.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next header element in this iteration </para>
				/// </returns>
				/// <java-name>
				/// nextElement
				/// </java-name>
				[Dot42.DexImport("nextElement", "()Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement NextElement() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Next() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
				public virtual void Remove() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHeaderElementIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This class represents a raw HTTP header whose content is parsed 'on demand' only when the header value needs to be consumed.</para><para><para></para><para></para><title>Revision:</title><para>604625 </para><title>Date:</title><para>2007-12-16 06:11:11 -0800 (Sun, 16 Dec 2007) </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BufferedHeader
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BufferedHeader", AccessFlags = 33)]
		public partial class BufferedHeader : global::Org.Apache.Http.IFormattedHeader, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new header from a buffer. The name of the header will be parsed immediately, the value only if it is accessed.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/util/CharArrayBuffer;)V", AccessFlags = 1)]
				public BufferedHeader(global::Org.Apache.Http.Util.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
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
				/// getElements
				/// </java-name>
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement[] GetElements() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement[]);
				}

				/// <summary>
				/// <para>Obtains the start of the header value in the buffer. By accessing the value in the buffer, creation of a temporary string can be avoided.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>index of the first character of the header value in the buffer returned by getBuffer. </para>
				/// </returns>
				/// <java-name>
				/// getValuePos
				/// </java-name>
				[Dot42.DexImport("getValuePos", "()I", AccessFlags = 1)]
				public virtual int GetValuePos() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the buffer with the formatted header. The returned buffer MUST NOT be modified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted header, in a buffer that must not be modified </para>
				/// </returns>
				/// <java-name>
				/// getBuffer
				/// </java-name>
				[Dot42.DexImport("getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer GetBuffer() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BufferedHeader() /* TypeBuilder.AddDefaultConstructor */ 
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
				}

				/// <java-name>
				/// getElements
				/// </java-name>
				public global::Org.Apache.Http.IHeaderElement[] Elements
				{
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
						get{ return GetElements(); }
				}

				/// <summary>
				/// <para>Obtains the start of the header value in the buffer. By accessing the value in the buffer, creation of a temporary string can be avoided.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>index of the first character of the header value in the buffer returned by getBuffer. </para>
				/// </returns>
				/// <java-name>
				/// getValuePos
				/// </java-name>
				public int ValuePos
				{
				[Dot42.DexImport("getValuePos", "()I", AccessFlags = 1)]
						get{ return GetValuePos(); }
				}

				/// <summary>
				/// <para>Obtains the buffer with the formatted header. The returned buffer MUST NOT be modified.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted header, in a buffer that must not be modified </para>
				/// </returns>
				/// <java-name>
				/// getBuffer
				/// </java-name>
				public global::Org.Apache.Http.Util.CharArrayBuffer Buffer
				{
				[Dot42.DexImport("getBuffer", "()Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 1)]
						get{ return GetBuffer(); }
				}

		}

		/// <summary>
		/// <para>Interface for formatting elements of a header value. This is the complement to HeaderValueParser. Instances of this interface are expected to be stateless and thread-safe.</para><para>All formatting methods accept an optional buffer argument. If a buffer is passed in, the formatted element will be appended and the modified buffer is returned. If no buffer is passed in, a new buffer will be created and filled with the formatted element. In both cases, the caller is allowed to modify the returned buffer. </para><para><para></para><title>Revision:</title><para>571954 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/HeaderValueFormatter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/HeaderValueFormatter", AccessFlags = 1537)]
		public partial interface IHeaderValueFormatter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Formats an array of header elements.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a buffer with the formatted header elements. If the <code>buffer</code> argument was not <code>null</code>, that buffer will be used and returned. </para>
				/// </returns>
				/// <java-name>
				/// formatElements
				/// </java-name>
				[Dot42.DexImport("formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatElements(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.IHeaderElement[] elems, bool quote) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Formats one header element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a buffer with the formatted header element. If the <code>buffer</code> argument was not <code>null</code>, that buffer will be used and returned. </para>
				/// </returns>
				/// <java-name>
				/// formatHeaderElement
				/// </java-name>
				[Dot42.DexImport("formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apac" +
    "he/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatHeaderElement(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.IHeaderElement elem, bool quote) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Formats the parameters of a header element. That's a list of name-value pairs, to be separated by semicolons. This method will <b>not</b> generate a leading semicolon.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a buffer with the formatted parameters. If the <code>buffer</code> argument was not <code>null</code>, that buffer will be used and returned. </para>
				/// </returns>
				/// <java-name>
				/// formatParameters
				/// </java-name>
				[Dot42.DexImport("formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatParameters(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.INameValuePair[] nvps, bool quote) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Formats one name-value pair, where the value is optional.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a buffer with the formatted name-value pair. If the <code>buffer</code> argument was not <code>null</code>, that buffer will be used and returned. </para>
				/// </returns>
				/// <java-name>
				/// formatNameValuePair
				/// </java-name>
				[Dot42.DexImport("formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apac" +
    "he/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatNameValuePair(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.INameValuePair nvp, bool quote) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Basic implementation of an HTTP message that can be modified.</para><para><para></para><para></para><title>Revision:</title><para>620287 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/AbstractHttpMessage
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/AbstractHttpMessage", AccessFlags = 1057)]
		public abstract partial class AbstractHttpMessage : global::Org.Apache.Http.IHttpMessage
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// headergroup
				/// </java-name>
				[Dot42.DexImport("headergroup", "Lorg/apache/http/message/HeaderGroup;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Message.HeaderGroup Headergroup;
				/// <java-name>
				/// params
				/// </java-name>
				[Dot42.DexImport("params", "Lorg/apache/http/params/HttpParams;", AccessFlags = 4)]
				protected internal global::Org.Apache.Http.Params.IHttpParams Params;
				[Dot42.DexImport("<init>", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 4)]
				protected internal AbstractHttpMessage(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal AbstractHttpMessage() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks if a certain header is present in this message. Header values are ignored.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if at least one header with this name is present. </para>
				/// </returns>
				/// <java-name>
				/// containsHeader
				/// </java-name>
				[Dot42.DexImport("containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool ContainsHeader(string name) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getHeaders
				/// </java-name>
				[Dot42.DexImport("getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetHeaders(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <java-name>
				/// getFirstHeader
				/// </java-name>
				[Dot42.DexImport("getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetFirstHeader(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <java-name>
				/// getLastHeader
				/// </java-name>
				[Dot42.DexImport("getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader GetLastHeader(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Returns all the headers of this message. Headers are orderd in the sequence they will be sent over a connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>all the headers of this message </para>
				/// </returns>
				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader[] GetAllHeaders() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void AddHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addHeader
				/// </java-name>
				[Dot42.DexImport("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddHeader(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHeader
				/// </java-name>
				[Dot42.DexImport("setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHeader
				/// </java-name>
				[Dot42.DexImport("setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetHeader(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHeaders
				/// </java-name>
				[Dot42.DexImport("setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void SetHeaders(global::Org.Apache.Http.IHeader[] headers) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHeader
				/// </java-name>
				[Dot42.DexImport("removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1)]
				public virtual void RemoveHeader(global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHeaders
				/// </java-name>
				[Dot42.DexImport("removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void RemoveHeaders(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an iterator of all the headers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Iterator that returns Header objects in the sequence they are sent over a connection. </para>
				/// </returns>
				/// <java-name>
				/// headerIterator
				/// </java-name>
				[Dot42.DexImport("headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <summary>
				/// <para>Returns an iterator of the headers with a given name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Iterator that returns Header objects with the argument name in the sequence they are sent over a connection. </para>
				/// </returns>
				/// <java-name>
				/// headerIterator
				/// </java-name>
				[Dot42.DexImport("headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderIterator HeaderIterator(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				/// <summary>
				/// <para>Returns the parameters effective for this message as set by setParams(HttpParams). </para>        
				/// </summary>
				/// <java-name>
				/// getParams
				/// </java-name>
				[Dot42.DexImport("getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Params.IHttpParams GetParams() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				/// <java-name>
				/// setParams
				/// </java-name>
				[Dot42.DexImport("setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1)]
				public virtual void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				public virtual global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <summary>
				/// <para>Returns all the headers of this message. Headers are orderd in the sequence they will be sent over a connection.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>all the headers of this message </para>
				/// </returns>
				/// <java-name>
				/// getAllHeaders
				/// </java-name>
				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1)]
						get{ return GetAllHeaders(); }
				}

				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get{ return GetProtocolVersion(); }
				}

		}

		/// <summary>
		/// <para>A simple class encapsulating an attribute/value pair. </para><para>This class comforms to the generic grammar and formatting rules outlined in the  and  of  </para><para>&lt;h&gt;2.2 Basic Rules&lt;/h&gt; </para><para>The following rules are used throughout this specification to describe basic parsing constructs. The US-ASCII coded character set is defined by ANSI X3.4-1986. </para><para><pre>
		///        OCTET          = &lt;any 8-bit sequence of data&gt;
		///        CHAR           = &lt;any US-ASCII character (octets 0 - 127)&gt;
		///        UPALPHA        = &lt;any US-ASCII uppercase letter "A".."Z"&gt;
		///        LOALPHA        = &lt;any US-ASCII lowercase letter "a".."z"&gt;
		///        ALPHA          = UPALPHA | LOALPHA
		///        DIGIT          = &lt;any US-ASCII digit "0".."9"&gt;
		///        CTL            = &lt;any US-ASCII control character
		///                         (octets 0 - 31) and DEL (127)&gt;
		///        CR             = &lt;US-ASCII CR, carriage return (13)&gt;
		///        LF             = &lt;US-ASCII LF, linefeed (10)&gt;
		///        SP             = &lt;US-ASCII SP, space (32)&gt;
		///        HT             = &lt;US-ASCII HT, horizontal-tab (9)&gt;
		///        &lt;"&gt;            = &lt;US-ASCII double-quote mark (34)&gt;
		///    </pre> </para><para>Many HTTP/1.1 header field values consist of words separated by LWS or special characters. These special characters MUST be in a quoted string to be used within a parameter value (as defined in section 3.6). </para><para><pre>
		///    token          = 1*&lt;any char="" except="" ctls="" or="" separators&gt;=""&gt;
		///    separators     = "(" | ")" | "&lt;" | "&gt;" | "@"
		///                   | "," | ";" | ":" | "\" | &lt;"&gt;
		///                   | "/" | "[" | "]" | "?" | "="
		///                   | "{" | "}" | SP | HT
		///    </pre> </para><para>A string of text is parsed as a single word if it is quoted using double-quote marks. </para><para><pre>
		///    quoted-string  = ( &lt;"&gt; *(qdtext | quoted-pair ) &lt;"&gt; )
		///    qdtext         = &lt;any TEXT except &lt;"&gt;&gt;
		///    </pre> </para><para>The backslash character ("\") MAY be used as a single-character quoting mechanism only within quoted-string and comment constructs. </para><para><pre>
		///    quoted-pair    = "\" CHAR
		///    </pre> &lt;h&gt;3.6 Transfer Codings&lt;/h&gt; </para><para>Parameters are in the form of attribute/value pairs. </para><para><pre>
		///    parameter               = attribute "=" value
		///    attribute               = token
		///    value                   = token | quoted-string
		///    </pre></para><para><para> </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicNameValuePair
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicNameValuePair", AccessFlags = 33)]
		public partial class BasicNameValuePair : global::Org.Apache.Http.INameValuePair, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Default Constructor taking a name and a value. The value may be null.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicNameValuePair(string name, string value) /* MethodBuilder.Create */ 
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
				/// <para>Get a string representation of this pair.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A string representation. </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicNameValuePair() /* TypeBuilder.AddDefaultConstructor */ 
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
				}

		}

		/// <summary>
		/// <para>Basic implementation of an HTTP request that can be modified.</para><para><para></para><para></para><title>Revision:</title><para>573864 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHttpRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHttpRequest", AccessFlags = 33)]
		public partial class BasicHttpRequest : global::Org.Apache.Http.Message.AbstractHttpMessage, global::Org.Apache.Http.IHttpRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHttpRequest(string method, string uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public BasicHttpRequest(string method, string uri, global::Org.Apache.Http.ProtocolVersion ver) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/RequestLine;)V", AccessFlags = 1)]
				public BasicHttpRequest(global::Org.Apache.Http.IRequestLine requestline) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the protocol version this message is compatible with. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public override global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <summary>
				/// <para>Returns the request line of this request. </para>        
				/// </summary>
				/// <returns>
				/// <para>the request line. </para>
				/// </returns>
				/// <java-name>
				/// getRequestLine
				/// </java-name>
				[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IRequestLine GetRequestLine() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHttpRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetAllHeaders() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] headers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.Params.IHttpParams GetParams() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public override void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				/// <para>Returns the protocol version this message is compatible with. </para>        
				/// </summary>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <summary>
				/// <para>Returns the request line of this request. </para>        
				/// </summary>
				/// <returns>
				/// <para>the request line. </para>
				/// </returns>
				/// <java-name>
				/// getRequestLine
				/// </java-name>
				public global::Org.Apache.Http.IRequestLine RequestLine
				{
				[Dot42.DexImport("getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1)]
						get{ return GetRequestLine(); }
				}

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <summary>
		/// <para>Basic implementation of a TokenIterator. This implementation parses <code>#token&lt;tt&gt; sequences as defined by RFC 2616, section 2. It extends that definition somewhat beyond US-ASCII.</code></para><para><code> <para></para><title>Revision:</title><para>602520 </para></code></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicTokenIterator
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicTokenIterator", AccessFlags = 33)]
		public partial class BasicTokenIterator : global::Org.Apache.Http.ITokenIterator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The HTTP separator characters. Defined in RFC 2616, section 2.2. </para>        
				/// </summary>
				/// <java-name>
				/// HTTP_SEPARATORS
				/// </java-name>
				[Dot42.DexImport("HTTP_SEPARATORS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string HTTP_SEPARATORS = " ,;=()<>@:\\\"/[]?{}\t";
				/// <summary>
				/// <para>The iterator from which to obtain the next header. </para>        
				/// </summary>
				/// <java-name>
				/// headerIt
				/// </java-name>
				[Dot42.DexImport("headerIt", "Lorg/apache/http/HeaderIterator;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.IHeaderIterator HeaderIt;
				/// <summary>
				/// <para>The value of the current header. This is the header value that includes currentToken. Undefined if the iteration is over. </para>        
				/// </summary>
				/// <java-name>
				/// currentHeader
				/// </java-name>
				[Dot42.DexImport("currentHeader", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string CurrentHeader;
				/// <summary>
				/// <para>The token to be returned by the next call to currentToken. <code>null</code> if the iteration is over. </para>        
				/// </summary>
				/// <java-name>
				/// currentToken
				/// </java-name>
				[Dot42.DexImport("currentToken", "Ljava/lang/String;", AccessFlags = 4)]
				protected internal string CurrentToken;
				/// <summary>
				/// <para>The position after currentToken in currentHeader. Undefined if the iteration is over. </para>        
				/// </summary>
				/// <java-name>
				/// searchPos
				/// </java-name>
				[Dot42.DexImport("searchPos", "I", AccessFlags = 4)]
				protected internal int SearchPos;
				/// <summary>
				/// <para>Creates a new instance of BasicTokenIterator.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/HeaderIterator;)V", AccessFlags = 1)]
				public BasicTokenIterator(global::Org.Apache.Http.IHeaderIterator headerIterator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether there is another token in this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is another token, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasNext
				/// </java-name>
				[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
				public virtual bool HasNext() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Obtains the next token from this iteration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token in this iteration</para>
				/// </returns>
				/// <java-name>
				/// nextToken
				/// </java-name>
				[Dot42.DexImport("nextToken", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string NextToken() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the next token. Same as nextToken, but with generic return type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the next token in this iteration</para>
				/// </returns>
				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()Ljava/lang/Object;", AccessFlags = 17)]
				public object Next() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Removing tokens is not supported.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "()V", AccessFlags = 17)]
				public void Remove() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Determines the next token. If found, the token is stored in currentToken. The return value indicates the position after the token in currentHeader. If necessary, the next header will be obtained from headerIt. If not found, currentToken is set to <code>null</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position after the found token in the current header, or negative if there was no next token</para>
				/// </returns>
				/// <java-name>
				/// findNext
				/// </java-name>
				[Dot42.DexImport("findNext", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindNext(int from) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Creates a new token to be returned. Called from findNext after the token is identified. The default implementation simply calls String.substring. <br></br> If header values are significantly longer than tokens, and some tokens are permanently referenced by the application, there can be problems with garbage collection. A substring will hold a reference to the full characters of the original string and therefore occupies more memory than might be expected. To avoid this, override this method and create a new string instead of a substring.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string representing the token identified by the arguments </para>
				/// </returns>
				/// <java-name>
				/// createToken
				/// </java-name>
				[Dot42.DexImport("createToken", "(Ljava/lang/String;II)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string CreateToken(string value, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Determines the starting position of the next token. This method will iterate over headers if necessary.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of the token start in the current header, negative if no token start could be found </para>
				/// </returns>
				/// <java-name>
				/// findTokenStart
				/// </java-name>
				[Dot42.DexImport("findTokenStart", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindTokenStart(int from) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the position of the next token separator. Because of multi-header joining rules, the end of a header value is a token separator. This method does therefore not need to iterate over headers.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position of a token separator in the current header, or at the end</para>
				/// </returns>
				/// <java-name>
				/// findTokenSeparator
				/// </java-name>
				[Dot42.DexImport("findTokenSeparator", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindTokenSeparator(int from) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Determines the ending position of the current token. This method will not leave the current header value, since the end of the header value is a token boundary.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the position after the last character of the token. The behavior is undefined if <code>from</code> does not point to a token character in the current header value. </para>
				/// </returns>
				/// <java-name>
				/// findTokenEnd
				/// </java-name>
				[Dot42.DexImport("findTokenEnd", "(I)I", AccessFlags = 4)]
				protected internal virtual int FindTokenEnd(int from) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Checks whether a character is a token separator. RFC 2616, section 2.1 defines comma as the separator for <code>#token</code> sequences. The end of a header value will also separate tokens, but that is not a character check.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the character is a token separator, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isTokenSeparator
				/// </java-name>
				[Dot42.DexImport("isTokenSeparator", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsTokenSeparator(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether a character is a whitespace character. RFC 2616, section 2.2 defines space and horizontal tab as whitespace. The optional preceeding line break is irrelevant, since header continuation is handled transparently when parsing messages.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the character is whitespace, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isWhitespace
				/// </java-name>
				[Dot42.DexImport("isWhitespace", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsWhitespace(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether a character is a valid token character. Whitespace, control characters, and HTTP separators are not valid token characters. The HTTP specification (RFC 2616, section 2.2) defines tokens only for the US-ASCII character set, this method extends the definition to other character sets.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the character is a valid token start, <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// isTokenChar
				/// </java-name>
				[Dot42.DexImport("isTokenChar", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsTokenChar(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether a character is an HTTP separator. The implementation in this class checks only for the HTTP separators defined in RFC 2616, section 2.2. If you need to detect other separators beyond the US-ASCII character set, override this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if the character is an HTTP separator </para>
				/// </returns>
				/// <java-name>
				/// isHttpSeparator
				/// </java-name>
				[Dot42.DexImport("isHttpSeparator", "(C)Z", AccessFlags = 4)]
				protected internal virtual bool IsHttpSeparator(char ch) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicTokenIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Represents a status line as returned from a HTTP server. See  section 6.1. This class is immutable and therefore inherently thread safe.</para><para><para>HttpStatus </para><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Id:</title><para>BasicStatusLine.java 604625 2007-12-16 14:11:11Z olegk </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicStatusLine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicStatusLine", AccessFlags = 33)]
		public partial class BasicStatusLine : global::Org.Apache.Http.IStatusLine, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new status line with the given version, status, and reason.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V", AccessFlags = 1)]
				public BasicStatusLine(global::Org.Apache.Http.ProtocolVersion version, int statusCode, string reasonPhrase) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Status-Code </para>
				/// </returns>
				/// <java-name>
				/// getStatusCode
				/// </java-name>
				[Dot42.DexImport("getStatusCode", "()I", AccessFlags = 1)]
				public virtual int GetStatusCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the HTTP-Version </para>
				/// </returns>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Reason-Phrase </para>
				/// </returns>
				/// <java-name>
				/// getReasonPhrase
				/// </java-name>
				[Dot42.DexImport("getReasonPhrase", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetReasonPhrase() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicStatusLine() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Status-Code </para>
				/// </returns>
				/// <java-name>
				/// getStatusCode
				/// </java-name>
				public int StatusCode
				{
				[Dot42.DexImport("getStatusCode", "()I", AccessFlags = 1)]
						get{ return GetStatusCode(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the HTTP-Version </para>
				/// </returns>
				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Reason-Phrase </para>
				/// </returns>
				/// <java-name>
				/// getReasonPhrase
				/// </java-name>
				public string ReasonPhrase
				{
				[Dot42.DexImport("getReasonPhrase", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetReasonPhrase(); }
				}

		}

		/// <summary>
		/// <para>Interface for formatting elements of the HEAD section of an HTTP message. This is the complement to LineParser. There are individual methods for formatting a request line, a status line, or a header line. The formatting does <b>not</b> include the trailing line break sequence CR-LF. Instances of this interface are expected to be stateless and thread-safe.</para><para>The formatted lines are returned in memory, the formatter does not depend on any specific IO mechanism. In order to avoid unnecessary creation of temporary objects, a buffer can be passed as argument to all formatting methods. The implementation may or may not actually use that buffer for formatting. If it is used, the buffer will first be cleared by the <code>formatXXX</code> methods. The argument buffer can always be re-used after the call. The buffer returned as the result, if it is different from the argument buffer, MUST NOT be modified. </para><para><para></para><para></para><title>Revision:</title><para>573864 </para><title>Date:</title><para>2007-09-08 08:53:25 -0700 (Sat, 08 Sep 2007) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/LineFormatter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/LineFormatter", AccessFlags = 1537)]
		public partial interface ILineFormatter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Formats a protocol version. This method does <b>not</b> follow the general contract for <code>buffer</code> arguments. It does <b>not</b> clear the argument buffer, but appends instead. The returned buffer can always be modified by the caller. Because of these differing conventions, it is not named <code>formatProtocolVersion</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a buffer with the formatted protocol version appended. The caller is allowed to modify the result buffer. If the <code>buffer</code> argument is not <code>null</code>, the returned buffer is the argument buffer. </para>
				/// </returns>
				/// <java-name>
				/// appendProtocolVersion
				/// </java-name>
				[Dot42.DexImport("appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer AppendProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.ProtocolVersion version) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Formats a request line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted request line </para>
				/// </returns>
				/// <java-name>
				/// formatRequestLine
				/// </java-name>
				[Dot42.DexImport("formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/" +
    "http/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.IRequestLine reqline) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Formats a status line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted status line</para>
				/// </returns>
				/// <java-name>
				/// formatStatusLine
				/// </java-name>
				[Dot42.DexImport("formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/h" +
    "ttp/util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.IStatusLine statline) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Formats a header. Due to header continuation, the result may be multiple lines. In order to generate well-formed HTTP, the lines in the result must be separated by the HTTP line break sequence CR-LF. There is <b>no</b> trailing CR-LF in the result. <br></br> See the class comment for details about the buffer argument.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a buffer holding the formatted header, never <code>null</code>. The returned buffer may be different from the argument buffer.</para>
				/// </returns>
				/// <java-name>
				/// formatHeader
				/// </java-name>
				[Dot42.DexImport("formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/" +
    "util/CharArrayBuffer;", AccessFlags = 1025)]
				global::Org.Apache.Http.Util.CharArrayBuffer FormatHeader(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Interface for formatting elements of the HEAD section of an HTTP message. This is the complement to LineParser. There are individual methods for formatting a request line, a status line, or a header line. The formatting does <b>not</b> include the trailing line break sequence CR-LF. The formatted lines are returned in memory, the formatter does not depend on any specific IO mechanism. Instances of this interface are expected to be stateless and thread-safe.</para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>and others</para><para></para><title>Revision:</title><para>574185 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicLineFormatter
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicLineFormatter", AccessFlags = 33)]
		public partial class BasicLineFormatter : global::Org.Apache.Http.Message.ILineFormatter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A default instance of this class, for use as default or fallback. Note that BasicLineFormatter is not a singleton, there can be many instances of the class itself and of derived classes. The instance here provides non-customized, default behavior. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/message/BasicLineFormatter;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Message.BasicLineFormatter DEFAULT;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicLineFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Obtains a buffer for formatting.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the cleared argument buffer if there is one, or a new empty buffer that can be used for formatting </para>
				/// </returns>
				/// <java-name>
				/// initBuffer
				/// </java-name>
				[Dot42.DexImport("initBuffer", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/util/CharArrayBuffer;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.Util.CharArrayBuffer InitBuffer(global::Org.Apache.Http.Util.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Formats a protocol version.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted protocol version </para>
				/// </returns>
				/// <java-name>
				/// formatProtocolVersion
				/// </java-name>
				[Dot42.DexImport("formatProtocolVersion", "(Lorg/apache/http/ProtocolVersion;Lorg/apache/http/message/LineFormatter;)Ljava/l" +
    "ang/String;", AccessFlags = 25)]
				public static string FormatProtocolVersion(global::Org.Apache.Http.ProtocolVersion version, global::Org.Apache.Http.Message.ILineFormatter formatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// appendProtocolVersion
				/// </java-name>
				[Dot42.DexImport("appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apa" +
    "che/http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer AppendProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.ProtocolVersion version) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Guesses the length of a formatted protocol version. Needed to guess the length of a formatted request or status line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the estimated length of the formatted protocol version, in characters </para>
				/// </returns>
				/// <java-name>
				/// estimateProtocolVersionLen
				/// </java-name>
				[Dot42.DexImport("estimateProtocolVersionLen", "(Lorg/apache/http/ProtocolVersion;)I", AccessFlags = 4)]
				protected internal virtual int EstimateProtocolVersionLen(global::Org.Apache.Http.ProtocolVersion version) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Formats a request line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted request line </para>
				/// </returns>
				/// <java-name>
				/// formatRequestLine
				/// </java-name>
				[Dot42.DexImport("formatRequestLine", "(Lorg/apache/http/RequestLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/" +
    "String;", AccessFlags = 25)]
				public static string FormatRequestLine(global::Org.Apache.Http.IRequestLine reqline, global::Org.Apache.Http.Message.ILineFormatter formatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Formats a request line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted request line </para>
				/// </returns>
				/// <java-name>
				/// formatRequestLine
				/// </java-name>
				[Dot42.DexImport("formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/" +
    "http/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer reqline, global::Org.Apache.Http.IRequestLine formatter) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Actually formats a request line. Called from formatRequestLine.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// doFormatRequestLine
				/// </java-name>
				[Dot42.DexImport("doFormatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)V", AccessFlags = 4)]
				protected internal virtual void DoFormatRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.IRequestLine reqline) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Formats a status line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted status line </para>
				/// </returns>
				/// <java-name>
				/// formatStatusLine
				/// </java-name>
				[Dot42.DexImport("formatStatusLine", "(Lorg/apache/http/StatusLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/S" +
    "tring;", AccessFlags = 25)]
				public static string FormatStatusLine(global::Org.Apache.Http.IStatusLine statline, global::Org.Apache.Http.Message.ILineFormatter formatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Formats a status line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted status line </para>
				/// </returns>
				/// <java-name>
				/// formatStatusLine
				/// </java-name>
				[Dot42.DexImport("formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/h" +
    "ttp/util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer statline, global::Org.Apache.Http.IStatusLine formatter) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Actually formats a status line. Called from formatStatusLine.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// doFormatStatusLine
				/// </java-name>
				[Dot42.DexImport("doFormatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)V", AccessFlags = 4)]
				protected internal virtual void DoFormatStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.IStatusLine statline) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Formats a header.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted header </para>
				/// </returns>
				/// <java-name>
				/// formatHeader
				/// </java-name>
				[Dot42.DexImport("formatHeader", "(Lorg/apache/http/Header;Lorg/apache/http/message/LineFormatter;)Ljava/lang/Strin" +
    "g;", AccessFlags = 25)]
				public static string FormatHeader(global::Org.Apache.Http.IHeader header, global::Org.Apache.Http.Message.ILineFormatter formatter) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Formats a header.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the formatted header </para>
				/// </returns>
				/// <java-name>
				/// formatHeader
				/// </java-name>
				[Dot42.DexImport("formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/" +
    "util/CharArrayBuffer;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.Util.CharArrayBuffer FormatHeader(global::Org.Apache.Http.Util.CharArrayBuffer header, global::Org.Apache.Http.IHeader formatter) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.Util.CharArrayBuffer);
				}

				/// <summary>
				/// <para>Actually formats a header. Called from formatHeader.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// doFormatHeader
				/// </java-name>
				[Dot42.DexImport("doFormatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)V", AccessFlags = 4)]
				protected internal virtual void DoFormatHeader(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.IHeader header) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>Interface for parsing lines in the HEAD section of an HTTP message. There are individual methods for parsing a request line, a status line, or a header line. The lines to parse are passed in memory, the parser does not depend on any specific IO mechanism. Instances of this interface are expected to be stateless and thread-safe.</para><para><para></para><para></para><title>Revision:</title><para>589374 </para><title>Date:</title><para>2007-10-28 09:25:07 -0700 (Sun, 28 Oct 2007) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/LineParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/LineParser", AccessFlags = 1537)]
		public partial interface ILineParser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Parses the textual representation of a protocol version. This is needed for parsing request lines (last element) as well as status lines (first element).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed protocol version</para>
				/// </returns>
				/// <java-name>
				/// parseProtocolVersion
				/// </java-name>
				[Dot42.DexImport("parseProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				global::Org.Apache.Http.ProtocolVersion ParseProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Checks whether there likely is a protocol version in a line. This method implements a <b>heuristic</b> to check for a likely protocol version specification. It does <b>not</b> guarantee that parseProtocolVersion would not detect a parse error. This can be used to detect garbage lines before a request or status line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para><code>true</code> if there is a protocol version at the argument index (possibly ignoring whitespace), <code>false</code> otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasProtocolVersion
				/// </java-name>
				[Dot42.DexImport("hasProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Z", AccessFlags = 1025)]
				bool HasProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parses a request line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed request line</para>
				/// </returns>
				/// <java-name>
				/// parseRequestLine
				/// </java-name>
				[Dot42.DexImport("parseRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/RequestLine;", AccessFlags = 1025)]
				global::Org.Apache.Http.IRequestLine ParseRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Parses a status line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed status line</para>
				/// </returns>
				/// <java-name>
				/// parseStatusLine
				/// </java-name>
				[Dot42.DexImport("parseStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/StatusLine;", AccessFlags = 1025)]
				global::Org.Apache.Http.IStatusLine ParseStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Creates a header from a line. The full header line is expected here. Header continuation lines must be joined by the caller before invoking this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the header in the argument buffer. The returned object MAY be a wrapper for the argument buffer. The argument buffer MUST NOT be re-used or changed afterwards.</para>
				/// </returns>
				/// <java-name>
				/// parseHeader
				/// </java-name>
				[Dot42.DexImport("parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				global::Org.Apache.Http.IHeader ParseHeader(global::Org.Apache.Http.Util.CharArrayBuffer buffer) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The first line of an HttpRequest. It contains the method, URI, and HTTP version of the request. For details, see RFC 2616.</para><para><para></para><para></para><title>Revision:</title><para>604625 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicRequestLine
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicRequestLine", AccessFlags = 33)]
		public partial class BasicRequestLine : global::Org.Apache.Http.IRequestLine, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public BasicRequestLine(string method, string uri, global::Org.Apache.Http.ProtocolVersion version) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetMethod() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetUri() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicRequestLine() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				public string Method
				{
				[Dot42.DexImport("getMethod", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMethod(); }
				}

				/// <java-name>
				/// getProtocolVersion
				/// </java-name>
				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1)]
						get{ return GetProtocolVersion(); }
				}

				/// <java-name>
				/// getUri
				/// </java-name>
				public string Uri
				{
				[Dot42.DexImport("getUri", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetUri(); }
				}

		}

		/// <summary>
		/// <para>Represents an HTTP header field.</para><para>The HTTP header fields follow the same generic format as that given in Section 3.1 of RFC 822. Each header field consists of a name followed by a colon (":") and the field value. Field names are case-insensitive. The field value MAY be preceded by any amount of LWS, though a single SP is preferred.</para><para><pre>
		///        message-header = field-name ":" [ field-value ]
		///        field-name     = token
		///        field-value    = *( field-content | LWS )
		///        field-content  = &lt;the OCTETs making up the field-value
		///                         and consisting of either *TEXT or combinations
		///                         of token, separators, and quoted-string&gt;
		///  *</pre></para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>652956 </para><title>Date:</title><para>2008-05-02 17:13:05 -0700 (Fri, 02 May 2008) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHeader
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeader", AccessFlags = 33)]
		public partial class BasicHeader : global::Org.Apache.Http.IHeader, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor with name and value</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHeader(string name, string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the header name.</para><para></para>        
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
				/// <para>Returns the header value.</para><para></para>        
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
				/// <para>Returns a String representation of the header.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a string </para>
				/// </returns>
				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns an array of HeaderElements constructed from my value.</para><para><para>BasicHeaderValueParser::parseElements(String, HeaderValueParser)</para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of header elements</para>
				/// </returns>
				/// <java-name>
				/// getElements
				/// </java-name>
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeaderElement[] GetElements() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeaderElement[]);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHeader() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the header name.</para><para></para>        
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
				/// <para>Returns the header value.</para><para></para>        
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
				}

				/// <summary>
				/// <para>Returns an array of HeaderElements constructed from my value.</para><para><para>BasicHeaderValueParser::parseElements(String, HeaderValueParser)</para></para>        
				/// </summary>
				/// <returns>
				/// <para>an array of header elements</para>
				/// </returns>
				/// <java-name>
				/// getElements
				/// </java-name>
				public global::Org.Apache.Http.IHeaderElement[] Elements
				{
				[Dot42.DexImport("getElements", "()[Lorg/apache/http/HeaderElement;", AccessFlags = 1)]
						get{ return GetElements(); }
				}

		}

		/// <summary>
		/// <para>One element of an HTTP header's value. </para><para>Some HTTP headers (such as the set-cookie header) have values that can be decomposed into multiple elements. Such headers must be in the following form: </para><para><pre>
		///    header  = [ element ] *( "," [ element ] )
		///    element = name [ "=" [ value ] ] *( ";" [ param ] )
		///    param   = name [ "=" [ value ] ]
		/// 
		///    name    = token
		///    value   = ( token | quoted-string )
		/// 
		///    token         = 1*&lt;any char except "=", ",", ";", &lt;"&gt; and
		///                          white space&gt;
		///    quoted-string = &lt;"&amp;gt; *( text | quoted-char ) &amp;lt;"&gt;
		///    text          = any char except &lt;"&amp;gt;
		///    quoted-char   = "" char
		///    </pre> </para><para>Any amount of white space is allowed between any part of the header, element or param and is ignored. A missing value in any element or param will be stored as the empty String; if the "=" is also missing <b>null</b> will be stored instead. </para><para>This class represents an individual header element, containing both a name/value pair (value may be <code>null</code>) and optionally a set of additional parameters. </para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para></para><para></para><title>Revision:</title><para>604625 </para><title>Date:</title><para>2007-12-16 06:11:11 -0800 (Sun, 16 Dec 2007) </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHeaderElement
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHeaderElement", AccessFlags = 33)]
		public partial class BasicHeaderElement : global::Org.Apache.Http.IHeaderElement, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor with name, value and parameters.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)V", AccessFlags = 1)]
				public BasicHeaderElement(string name, string value, global::Org.Apache.Http.INameValuePair[] parameters) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor with name and value.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHeaderElement(string name, string value) /* MethodBuilder.Create */ 
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
				/// <para>Get parameters, if any. The returned array is created for each invocation and can be modified by the caller without affecting this header element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>parameters as an array of NameValuePairs </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				[Dot42.DexImport("getParameters", "()[Lorg/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair[] GetParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair[]);
				}

				/// <summary>
				/// <para>Obtains the number of parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of parameters </para>
				/// </returns>
				/// <java-name>
				/// getParameterCount
				/// </java-name>
				[Dot42.DexImport("getParameterCount", "()I", AccessFlags = 1)]
				public virtual int GetParameterCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Obtains the parameter with the given index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parameter with the given index </para>
				/// </returns>
				/// <java-name>
				/// getParameter
				/// </java-name>
				[Dot42.DexImport("getParameter", "(I)Lorg/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair GetParameter(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
				}

				/// <summary>
				/// <para>Returns parameter with the given name, if found. Otherwise null is returned</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>NameValuePair parameter with the given name </para>
				/// </returns>
				/// <java-name>
				/// getParameterByName
				/// </java-name>
				[Dot42.DexImport("getParameterByName", "(Ljava/lang/String;)Lorg/apache/http/NameValuePair;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.INameValuePair GetParameterByName(string name) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.INameValuePair);
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
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHeaderElement() /* TypeBuilder.AddDefaultConstructor */ 
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
				}

				/// <summary>
				/// <para>Get parameters, if any. The returned array is created for each invocation and can be modified by the caller without affecting this header element.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>parameters as an array of NameValuePairs </para>
				/// </returns>
				/// <java-name>
				/// getParameters
				/// </java-name>
				public global::Org.Apache.Http.INameValuePair[] Parameters
				{
				[Dot42.DexImport("getParameters", "()[Lorg/apache/http/NameValuePair;", AccessFlags = 1)]
						get{ return GetParameters(); }
				}

				/// <summary>
				/// <para>Obtains the number of parameters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of parameters </para>
				/// </returns>
				/// <java-name>
				/// getParameterCount
				/// </java-name>
				public int ParameterCount
				{
				[Dot42.DexImport("getParameterCount", "()I", AccessFlags = 1)]
						get{ return GetParameterCount(); }
				}

		}

		/// <summary>
		/// <para>Basic implementation of a request with an entity that can be modified.</para><para><para></para><para></para><title>Revision:</title><para>618017 </para></para><para><para>4.0 </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicHttpEntityEnclosingRequest
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicHttpEntityEnclosingRequest", AccessFlags = 33)]
		public partial class BasicHttpEntityEnclosingRequest : global::Org.Apache.Http.Message.BasicHttpRequest, global::Org.Apache.Http.IHttpEntityEnclosingRequest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public BasicHttpEntityEnclosingRequest(string method, string uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public BasicHttpEntityEnclosingRequest(string method, string uri, global::Org.Apache.Http.ProtocolVersion ver) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Lorg/apache/http/RequestLine;)V", AccessFlags = 1)]
				public BasicHttpEntityEnclosingRequest(global::Org.Apache.Http.IRequestLine requestline) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHttpEntity GetEntity() /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHttpEntity);
				}

				/// <java-name>
				/// setEntity
				/// </java-name>
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
				public virtual void SetEntity(global::Org.Apache.Http.IHttpEntity entity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Tells if this request should use the expect-continue handshake. The expect continue handshake gives the server a chance to decide whether to accept the entity enclosing request before the possibly lengthy entity is sent across the wire. </para>        
				/// </summary>
				/// <returns>
				/// <para>true if the expect continue handshake should be used, false if not. </para>
				/// </returns>
				/// <java-name>
				/// expectContinue
				/// </java-name>
				[Dot42.DexImport("expectContinue", "()Z", AccessFlags = 1)]
				public virtual bool ExpectContinue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BasicHttpEntityEnclosingRequest() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpRequest", "getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IRequestLine GetRequestLine() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.ProtocolVersion GetProtocolVersion() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "containsHeader", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
				public override bool ContainsHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetFirstHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader GetLastHeader(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeader[] GetAllHeaders() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeader[]);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void AddHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void AddHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void SetHeader(string name, string value) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setHeaders", "([Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void SetHeaders(global::Org.Apache.Http.IHeader[] headers) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeader", "(Lorg/apache/http/Header;)V", AccessFlags = 1025)]
				public override void RemoveHeader(global::Org.Apache.Http.IHeader header) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "removeHeaders", "(Ljava/lang/String;)V", AccessFlags = 1025)]
				public override void RemoveHeaders(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "()Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.IHeaderIterator HeaderIterator(string name) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.IHeaderIterator);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "getParams", "()Lorg/apache/http/params/HttpParams;", AccessFlags = 1025)]
				public override global::Org.Apache.Http.Params.IHttpParams GetParams() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Org.Apache.Http.Params.IHttpParams);
				}

				[Dot42.DexImport("org/apache/http/HttpMessage", "setParams", "(Lorg/apache/http/params/HttpParams;)V", AccessFlags = 1025)]
				public override void SetParams(global::Org.Apache.Http.Params.IHttpParams @params) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getEntity
				/// </java-name>
				public global::Org.Apache.Http.IHttpEntity Entity
				{
				[Dot42.DexImport("getEntity", "()Lorg/apache/http/HttpEntity;", AccessFlags = 1)]
						get{ return GetEntity(); }
				[Dot42.DexImport("setEntity", "(Lorg/apache/http/HttpEntity;)V", AccessFlags = 1)]
						set{ SetEntity(value); }
				}

				public global::Org.Apache.Http.IRequestLine RequestLine
				{
				[Dot42.DexImport("org/apache/http/HttpRequest", "getRequestLine", "()Lorg/apache/http/RequestLine;", AccessFlags = 1025)]
						get{ return GetRequestLine(); }
				}

				public global::Org.Apache.Http.ProtocolVersion ProtocolVersion
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;", AccessFlags = 1025)]
						get{ return GetProtocolVersion(); }
				}

				public global::Org.Apache.Http.IHeader[] AllHeaders
				{
				[Dot42.DexImport("org/apache/http/HttpMessage", "getAllHeaders", "()[Lorg/apache/http/Header;", AccessFlags = 1025)]
						get{ return GetAllHeaders(); }
				}

		}

		/// <summary>
		/// <para>Basic parser for lines in the head section of an HTTP message. There are individual methods for parsing a request line, a status line, or a header line. The lines to parse are passed in memory, the parser does not depend on any specific IO mechanism. Instances of this class are stateless and thread-safe. Derived classes MUST maintain these properties.</para><para>Note: This class was created by refactoring parsing code located in various other classes. The author tags from those other classes have been replicated here, although the association with the parsing code taken from there has not been traced. </para><para><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para> </para><simplesectsep></simplesectsep><para>and others </para></para>    
		/// </summary>
		/// <java-name>
		/// org/apache/http/message/BasicLineParser
		/// </java-name>
		[Dot42.DexImport("org/apache/http/message/BasicLineParser", AccessFlags = 33)]
		public partial class BasicLineParser : global::Org.Apache.Http.Message.ILineParser
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A default instance of this class, for use as default or fallback. Note that BasicLineParser is not a singleton, there can be many instances of the class itself and of derived classes. The instance here provides non-customized, default behavior. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "Lorg/apache/http/message/BasicLineParser;", AccessFlags = 25)]
				public static readonly global::Org.Apache.Http.Message.BasicLineParser DEFAULT;
				/// <summary>
				/// <para>A version of the protocol to parse. The version is typically not relevant, but the protocol name. </para>        
				/// </summary>
				/// <java-name>
				/// protocol
				/// </java-name>
				[Dot42.DexImport("protocol", "Lorg/apache/http/ProtocolVersion;", AccessFlags = 20)]
				protected internal readonly global::Org.Apache.Http.ProtocolVersion Protocol;
				/// <summary>
				/// <para>Creates a new line parser for the given HTTP-like protocol.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Lorg/apache/http/ProtocolVersion;)V", AccessFlags = 1)]
				public BasicLineParser(global::Org.Apache.Http.ProtocolVersion proto) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new line parser for HTTP. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BasicLineParser() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// parseProtocolVersion
				/// </java-name>
				[Dot42.DexImport("parseProtocolVersion", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/Protocol" +
    "Version;", AccessFlags = 25)]
				public static global::Org.Apache.Http.ProtocolVersion ParseProtocolVersion(string buffer, global::Org.Apache.Http.Message.ILineParser cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// parseProtocolVersion
				/// </java-name>
				[Dot42.DexImport("parseProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/ProtocolVersion;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.ProtocolVersion ParseProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <summary>
				/// <para>Creates a protocol version. Called from parseProtocolVersion.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the protocol version </para>
				/// </returns>
				/// <java-name>
				/// createProtocolVersion
				/// </java-name>
				[Dot42.DexImport("createProtocolVersion", "(II)Lorg/apache/http/ProtocolVersion;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.ProtocolVersion CreateProtocolVersion(int major, int minor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.ProtocolVersion);
				}

				/// <java-name>
				/// hasProtocolVersion
				/// </java-name>
				[Dot42.DexImport("hasProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Z", AccessFlags = 1)]
				public virtual bool HasProtocolVersion(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Parses a request line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed request line</para>
				/// </returns>
				/// <java-name>
				/// parseRequestLine
				/// </java-name>
				[Dot42.DexImport("parseRequestLine", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/RequestL" +
    "ine;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IRequestLine ParseRequestLine(string buffer, global::Org.Apache.Http.Message.ILineParser cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				/// <summary>
				/// <para>Parses a request line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the parsed request line</para>
				/// </returns>
				/// <java-name>
				/// parseRequestLine
				/// </java-name>
				[Dot42.DexImport("parseRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/RequestLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IRequestLine ParseRequestLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				/// <summary>
				/// <para>Instantiates a new request line. Called from parseRequestLine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new status line with the given data </para>
				/// </returns>
				/// <java-name>
				/// createRequestLine
				/// </java-name>
				[Dot42.DexImport("createRequestLine", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)Lorg/apach" +
    "e/http/RequestLine;", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IRequestLine CreateRequestLine(string method, string uri, global::Org.Apache.Http.ProtocolVersion ver) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IRequestLine);
				}

				/// <java-name>
				/// parseStatusLine
				/// </java-name>
				[Dot42.DexImport("parseStatusLine", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/StatusLi" +
    "ne;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IStatusLine ParseStatusLine(string buffer, global::Org.Apache.Http.Message.ILineParser cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IStatusLine);
				}

				/// <java-name>
				/// parseStatusLine
				/// </java-name>
				[Dot42.DexImport("parseStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lor" +
    "g/apache/http/StatusLine;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IStatusLine ParseStatusLine(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IStatusLine);
				}

				/// <summary>
				/// <para>Instantiates a new status line. Called from parseStatusLine.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a new status line with the given data </para>
				/// </returns>
				/// <java-name>
				/// createStatusLine
				/// </java-name>
				[Dot42.DexImport("createStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)Lorg/apache/http/StatusLine" +
    ";", AccessFlags = 4)]
				protected internal virtual global::Org.Apache.Http.IStatusLine CreateStatusLine(global::Org.Apache.Http.ProtocolVersion ver, int status, string reason) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IStatusLine);
				}

				/// <java-name>
				/// parseHeader
				/// </java-name>
				[Dot42.DexImport("parseHeader", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/Header;", AccessFlags = 25)]
				public static global::Org.Apache.Http.IHeader ParseHeader(string value, global::Org.Apache.Http.Message.ILineParser parser) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Creates a header from a line. The full header line is expected here. Header continuation lines must be joined by the caller before invoking this method.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the header in the argument buffer. The returned object MAY be a wrapper for the argument buffer. The argument buffer MUST NOT be re-used or changed afterwards.</para>
				/// </returns>
				/// <java-name>
				/// parseHeader
				/// </java-name>
				[Dot42.DexImport("parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/Header;", AccessFlags = 1)]
				public virtual global::Org.Apache.Http.IHeader ParseHeader(global::Org.Apache.Http.Util.CharArrayBuffer buffer) /* MethodBuilder.Create */ 
				{
						return default(global::Org.Apache.Http.IHeader);
				}

				/// <summary>
				/// <para>Helper to skip whitespace. </para>        
				/// </summary>
				/// <java-name>
				/// skipWhitespace
				/// </java-name>
				[Dot42.DexImport("skipWhitespace", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)V", AccessFlags = 4)]
				protected internal virtual void SkipWhitespace(global::Org.Apache.Http.Util.CharArrayBuffer buffer, global::Org.Apache.Http.Message.ParserCursor cursor) /* MethodBuilder.Create */ 
				{
				}

		}

}


