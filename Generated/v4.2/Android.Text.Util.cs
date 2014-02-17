// Copyright (C) 2014 dot42
//
// Original filename: Android.Text.Util.cs
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
namespace Android.Text.Util
{
		/// <summary>
		/// <para>This class works as a Tokenizer for MultiAutoCompleteTextView for address list fields, and also provides a method for converting a string of addresses (such as might be typed into such a field) into a series of Rfc822Tokens. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/util/Rfc822Tokenizer
		/// </java-name>
		[Dot42.DexImport("android/text/util/Rfc822Tokenizer", AccessFlags = 33)]
		public partial class Rfc822Tokenizer : global::Android.Widget.MultiAutoCompleteTextView.ITokenizer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Rfc822Tokenizer() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This constructor will try to take a string like "Foo Bar (something) &amp;lt;foo\@google.com&amp;gt;,       blah\@google.com (something)" and convert it into one or more Rfc822Tokens, output into the supplied collection.</para><para>It does <b>not</b> decode MIME encoded-words; charset conversion must already have taken place if necessary. It will try to be tolerant of broken syntax instead of returning an error. </para>        
				/// </summary>
				/// <java-name>
				/// tokenize
				/// </java-name>
				[Dot42.DexImport("tokenize", "(Ljava/lang/CharSequence;Ljava/util/Collection;)V", AccessFlags = 9, Signature = "(Ljava/lang/CharSequence;Ljava/util/Collection<Landroid/text/util/Rfc822Token;>;)" +
    "V")]
				public static void Tokenize(global::Java.Lang.ICharSequence text, global::Java.Util.ICollection<global::Android.Text.Util.Rfc822Token> @out) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method will try to take a string like "Foo Bar (something) &amp;lt;foo\@google.com&amp;gt;,       blah\@google.com (something)" and convert it into one or more Rfc822Tokens. It does <b>not</b> decode MIME encoded-words; charset conversion must already have taken place if necessary. It will try to be tolerant of broken syntax instead of returning an error. </para>        
				/// </summary>
				/// <java-name>
				/// tokenize
				/// </java-name>
				[Dot42.DexImport("tokenize", "(Ljava/lang/CharSequence;)[Landroid/text/util/Rfc822Token;", AccessFlags = 9)]
				public static global::Android.Text.Util.Rfc822Token[] Tokenize(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Util.Rfc822Token[]);
				}

				/// <summary>
				/// <para><para>Returns the start of the token that ends at offset <code>cursor</code> within <code>text</code>.</para> </para>        
				/// </summary>
				/// <java-name>
				/// findTokenStart
				/// </java-name>
				[Dot42.DexImport("findTokenStart", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1)]
				public virtual int FindTokenStart(global::Java.Lang.ICharSequence text, int cursor) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para><para>Returns the end of the token (minus trailing punctuation) that begins at offset <code>cursor</code> within <code>text</code>.</para> </para>        
				/// </summary>
				/// <java-name>
				/// findTokenEnd
				/// </java-name>
				[Dot42.DexImport("findTokenEnd", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1)]
				public virtual int FindTokenEnd(global::Java.Lang.ICharSequence text, int cursor) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Terminates the specified address with a comma and space. This assumes that the specified text already has valid syntax. The Adapter subclass's convertToString() method must make that guarantee. </para>        
				/// </summary>
				/// <java-name>
				/// terminateToken
				/// </java-name>
				[Dot42.DexImport("terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence TerminateToken(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

		}

		/// <summary>
		/// <para>This class stores an RFC 822-like name, address, and comment, and provides methods to convert them to quoted strings. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/util/Rfc822Token
		/// </java-name>
		[Dot42.DexImport("android/text/util/Rfc822Token", AccessFlags = 33)]
		public partial class Rfc822Token
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new Rfc822Token with the specified name, address, and comment. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Rfc822Token(string name, string address, string comment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name part. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the address part. </para>        
				/// </summary>
				/// <java-name>
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the comment part. </para>        
				/// </summary>
				/// <java-name>
				/// getComment
				/// </java-name>
				[Dot42.DexImport("getComment", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetComment() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Changes the name to the specified name. </para>        
				/// </summary>
				/// <java-name>
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetName(string name) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the address to the specified address. </para>        
				/// </summary>
				/// <java-name>
				/// setAddress
				/// </java-name>
				[Dot42.DexImport("setAddress", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAddress(string address) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the comment to the specified comment. </para>        
				/// </summary>
				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetComment(string comment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the name (with quoting added if necessary), the comment (in parentheses), and the address (in angle brackets). This should be suitable for inclusion in an RFC 822 address list. </para>        
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
				/// <para>Returns the name, conservatively quoting it if there are any characters that are likely to cause trouble outside of a quoted string, or returning it literally if it seems safe. </para>        
				/// </summary>
				/// <java-name>
				/// quoteNameIfNecessary
				/// </java-name>
				[Dot42.DexImport("quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string QuoteNameIfNecessary(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the name, with internal backslashes and quotation marks preceded by backslashes. The outer quote marks themselves are not added by this method. </para>        
				/// </summary>
				/// <java-name>
				/// quoteName
				/// </java-name>
				[Dot42.DexImport("quoteName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string QuoteName(string name) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the comment, with internal backslashes and parentheses preceded by backslashes. The outer parentheses themselves are not added by this method. </para>        
				/// </summary>
				/// <java-name>
				/// quoteComment
				/// </java-name>
				[Dot42.DexImport("quoteComment", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string QuoteComment(string comment) /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Rfc822Token() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the name part. </para>        
				/// </summary>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetName(value); }
				}

				/// <summary>
				/// <para>Returns the address part. </para>        
				/// </summary>
				/// <java-name>
				/// getAddress
				/// </java-name>
				public string Address
				{
				[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetAddress(); }
				[Dot42.DexImport("setAddress", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetAddress(value); }
				}

				/// <summary>
				/// <para>Returns the comment part. </para>        
				/// </summary>
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

		}

		/// <summary>
		/// <para>Linkify take a piece of text and a regular expression and turns all of the regex matches in the text into clickable links. This is particularly useful for matching things like email addresses, web urls, etc. and making them actionable.</para><para>Alone with the pattern that is to be matched, a url scheme prefix is also required. Any pattern match that does not begin with the supplied scheme will have the scheme prepended to the matched text when the clickable url is created. For instance, if you are matching web urls you would supply the scheme <code></code>. If the pattern matches example.com, which does not have a url scheme prefix, the supplied scheme will be prepended to create <code></code> when the clickable url link is created. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/util/Linkify
		/// </java-name>
		[Dot42.DexImport("android/text/util/Linkify", AccessFlags = 33)]
		public partial class Linkify
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Bit field indicating that web URLs should be matched in methods that take an options mask </para>        
				/// </summary>
				/// <java-name>
				/// WEB_URLS
				/// </java-name>
				[Dot42.DexImport("WEB_URLS", "I", AccessFlags = 25)]
				public const int WEB_URLS = 1;
				/// <summary>
				/// <para>Bit field indicating that email addresses should be matched in methods that take an options mask </para>        
				/// </summary>
				/// <java-name>
				/// EMAIL_ADDRESSES
				/// </java-name>
				[Dot42.DexImport("EMAIL_ADDRESSES", "I", AccessFlags = 25)]
				public const int EMAIL_ADDRESSES = 2;
				/// <summary>
				/// <para>Bit field indicating that phone numbers should be matched in methods that take an options mask </para>        
				/// </summary>
				/// <java-name>
				/// PHONE_NUMBERS
				/// </java-name>
				[Dot42.DexImport("PHONE_NUMBERS", "I", AccessFlags = 25)]
				public const int PHONE_NUMBERS = 4;
				/// <summary>
				/// <para>Bit field indicating that street addresses should be matched in methods that take an options mask </para>        
				/// </summary>
				/// <java-name>
				/// MAP_ADDRESSES
				/// </java-name>
				[Dot42.DexImport("MAP_ADDRESSES", "I", AccessFlags = 25)]
				public const int MAP_ADDRESSES = 8;
				/// <summary>
				/// <para>Bit mask indicating that all available patterns should be matched in methods that take an options mask </para>        
				/// </summary>
				/// <java-name>
				/// ALL
				/// </java-name>
				[Dot42.DexImport("ALL", "I", AccessFlags = 25)]
				public const int ALL = 15;
				/// <summary>
				/// <para>Filters out web URL matches that occur after an at-sign (@). This is to prevent turning the domain name in an email address into a web link. </para>        
				/// </summary>
				/// <java-name>
				/// sUrlMatchFilter
				/// </java-name>
				[Dot42.DexImport("sUrlMatchFilter", "Landroid/text/util/Linkify$MatchFilter;", AccessFlags = 25)]
				public static readonly global::Android.Text.Util.Linkify.IMatchFilter SUrlMatchFilter;
				/// <summary>
				/// <para>Filters out URL matches that don't have enough digits to be a phone number. </para>        
				/// </summary>
				/// <java-name>
				/// sPhoneNumberMatchFilter
				/// </java-name>
				[Dot42.DexImport("sPhoneNumberMatchFilter", "Landroid/text/util/Linkify$MatchFilter;", AccessFlags = 25)]
				public static readonly global::Android.Text.Util.Linkify.IMatchFilter SPhoneNumberMatchFilter;
				/// <summary>
				/// <para>Transforms matched phone number text into something suitable to be used in a tel: URL. It does this by removing everything but the digits and plus signs. For instance: '+1 (919) 555-1212' becomes '+19195551212' </para>        
				/// </summary>
				/// <java-name>
				/// sPhoneNumberTransformFilter
				/// </java-name>
				[Dot42.DexImport("sPhoneNumberTransformFilter", "Landroid/text/util/Linkify$TransformFilter;", AccessFlags = 25)]
				public static readonly global::Android.Text.Util.Linkify.ITransformFilter SPhoneNumberTransformFilter;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Linkify() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Scans the text of the provided Spannable and turns all occurrences of the link types indicated in the mask into clickable links. If the mask is nonzero, it also removes any existing URLSpans attached to the Spannable, to avoid problems if you call it repeatedly on the same text. </para>        
				/// </summary>
				/// <java-name>
				/// addLinks
				/// </java-name>
				[Dot42.DexImport("addLinks", "(Landroid/text/Spannable;I)Z", AccessFlags = 25)]
				public static bool AddLinks(global::Android.Text.ISpannable text, int mask) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Scans the text of the provided Spannable and turns all occurrences of the link types indicated in the mask into clickable links. If the mask is nonzero, it also removes any existing URLSpans attached to the Spannable, to avoid problems if you call it repeatedly on the same text. </para>        
				/// </summary>
				/// <java-name>
				/// addLinks
				/// </java-name>
				[Dot42.DexImport("addLinks", "(Landroid/widget/TextView;I)Z", AccessFlags = 25)]
				public static bool AddLinks(global::Android.Widget.TextView text, int mask) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addLinks
				/// </java-name>
				[Dot42.DexImport("addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;)V", AccessFlags = 25)]
				public static void AddLinks(global::Android.Widget.TextView textView, global::Java.Util.Regex.Pattern pattern, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addLinks
				/// </java-name>
				[Dot42.DexImport("addLinks", "(Landroid/widget/TextView;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/tex" +
    "t/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)V", AccessFlags = 25)]
				public static void AddLinks(global::Android.Widget.TextView textView, global::Java.Util.Regex.Pattern pattern, string @string, global::Android.Text.Util.Linkify.IMatchFilter matchFilter, global::Android.Text.Util.Linkify.ITransformFilter transformFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addLinks
				/// </java-name>
				[Dot42.DexImport("addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;)Z", AccessFlags = 25)]
				public static bool AddLinks(global::Android.Text.ISpannable spannable, global::Java.Util.Regex.Pattern pattern, string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addLinks
				/// </java-name>
				[Dot42.DexImport("addLinks", "(Landroid/text/Spannable;Ljava/util/regex/Pattern;Ljava/lang/String;Landroid/text" +
    "/util/Linkify$MatchFilter;Landroid/text/util/Linkify$TransformFilter;)Z", AccessFlags = 25)]
				public static bool AddLinks(global::Android.Text.ISpannable spannable, global::Java.Util.Regex.Pattern pattern, string @string, global::Android.Text.Util.Linkify.IMatchFilter matchFilter, global::Android.Text.Util.Linkify.ITransformFilter transformFilter) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>TransformFilter enables client code to have more control over how matched patterns are represented as URLs.</para><para>For example: when converting a phone number such as (919) 555-1212 into a tel: URL the parentheses, white space, and hyphen need to be removed to produce tel:9195551212. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/util/Linkify$TransformFilter
				/// </java-name>
				[Dot42.DexImport("android/text/util/Linkify$TransformFilter", AccessFlags = 1545)]
				public partial interface ITransformFilter
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Examines the matched text and either passes it through or uses the data in the Matcher state to produce a replacement.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>The transformed form of the URL </para>
						/// </returns>
						/// <java-name>
						/// transformUrl
						/// </java-name>
						[Dot42.DexImport("transformUrl", "(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
						string TransformUrl(global::Java.Util.Regex.Matcher match, string url) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>MatchFilter enables client code to have more control over what is allowed to match and become a link, and what is not.</para><para>For example: when matching web urls you would like things like  to match, as well as just example.com itelf. However, you would not want to match against the domain in . So, when matching against a web url pattern you might also include a MatchFilter that disallows the match if it is immediately preceded by an at-sign (@). </para>    
				/// </summary>
				/// <java-name>
				/// android/text/util/Linkify$MatchFilter
				/// </java-name>
				[Dot42.DexImport("android/text/util/Linkify$MatchFilter", AccessFlags = 1545)]
				public partial interface IMatchFilter
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Examines the character span matched by the pattern and determines if the match should be turned into an actionable link.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>Whether this match should be turned into a link </para>
						/// </returns>
						/// <java-name>
						/// acceptMatch
						/// </java-name>
						[Dot42.DexImport("acceptMatch", "(Ljava/lang/CharSequence;II)Z", AccessFlags = 1025)]
						bool AcceptMatch(global::Java.Lang.ICharSequence s, int start, int end) /* MethodBuilder.Create */ ;

				}

		}

}


