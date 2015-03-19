#pragma warning disable 1717
namespace Android.Text.Util
{
		/// <java-name>
		/// android/text/util/Rfc822Token
		/// </java-name>
		[Dot42.DexImport("android/text/util/Rfc822Token", AccessFlags = 33)]
		public partial class Rfc822Token
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Rfc822Token(string @string, string string1, string string2) /* MethodBuilder.Create */ 
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
				/// getAddress
				/// </java-name>
				[Dot42.DexImport("getAddress", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetAddress() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// setName
				/// </java-name>
				[Dot42.DexImport("setName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAddress
				/// </java-name>
				[Dot42.DexImport("setAddress", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetAddress(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setComment
				/// </java-name>
				[Dot42.DexImport("setComment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetComment(string @string) /* MethodBuilder.Create */ 
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
				/// quoteNameIfNecessary
				/// </java-name>
				[Dot42.DexImport("quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string QuoteNameIfNecessary(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// quoteName
				/// </java-name>
				[Dot42.DexImport("quoteName", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string QuoteName(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// quoteComment
				/// </java-name>
				[Dot42.DexImport("quoteComment", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string QuoteComment(string @string) /* MethodBuilder.Create */ 
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
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Rfc822Token() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

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

		/// <java-name>
		/// android/text/util/Linkify
		/// </java-name>
		[Dot42.DexImport("android/text/util/Linkify", AccessFlags = 33)]
		public partial class Linkify
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// WEB_URLS
				/// </java-name>
				[Dot42.DexImport("WEB_URLS", "I", AccessFlags = 25)]
				public const int WEB_URLS = 1;
				/// <java-name>
				/// EMAIL_ADDRESSES
				/// </java-name>
				[Dot42.DexImport("EMAIL_ADDRESSES", "I", AccessFlags = 25)]
				public const int EMAIL_ADDRESSES = 2;
				/// <java-name>
				/// PHONE_NUMBERS
				/// </java-name>
				[Dot42.DexImport("PHONE_NUMBERS", "I", AccessFlags = 25)]
				public const int PHONE_NUMBERS = 4;
				/// <java-name>
				/// MAP_ADDRESSES
				/// </java-name>
				[Dot42.DexImport("MAP_ADDRESSES", "I", AccessFlags = 25)]
				public const int MAP_ADDRESSES = 8;
				/// <java-name>
				/// ALL
				/// </java-name>
				[Dot42.DexImport("ALL", "I", AccessFlags = 25)]
				public const int ALL = 15;
				/// <java-name>
				/// sUrlMatchFilter
				/// </java-name>
				[Dot42.DexImport("sUrlMatchFilter", "Landroid/text/util/Linkify$MatchFilter;", AccessFlags = 25)]
				public static readonly global::Android.Text.Util.Linkify.IMatchFilter SUrlMatchFilter;
				/// <java-name>
				/// sPhoneNumberMatchFilter
				/// </java-name>
				[Dot42.DexImport("sPhoneNumberMatchFilter", "Landroid/text/util/Linkify$MatchFilter;", AccessFlags = 25)]
				public static readonly global::Android.Text.Util.Linkify.IMatchFilter SPhoneNumberMatchFilter;
				/// <java-name>
				/// sPhoneNumberTransformFilter
				/// </java-name>
				[Dot42.DexImport("sPhoneNumberTransformFilter", "Landroid/text/util/Linkify$TransformFilter;", AccessFlags = 25)]
				public static readonly global::Android.Text.Util.Linkify.ITransformFilter SPhoneNumberTransformFilter;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Linkify() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addLinks
				/// </java-name>
				[Dot42.DexImport("addLinks", "(Landroid/text/Spannable;I)Z", AccessFlags = 25)]
				public static bool AddLinks(global::Android.Text.ISpannable spannable, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addLinks
				/// </java-name>
				[Dot42.DexImport("addLinks", "(Landroid/widget/TextView;I)Z", AccessFlags = 25)]
				public static bool AddLinks(global::Android.Widget.TextView textView, int int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// android/text/util/Linkify$TransformFilter
				/// </java-name>
				[Dot42.DexImport("android/text/util/Linkify$TransformFilter", AccessFlags = 1545)]
				public partial interface ITransformFilter
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// transformUrl
						/// </java-name>
						[Dot42.DexImport("transformUrl", "(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1025)]
						string TransformUrl(global::Java.Util.Regex.Matcher matcher, string @string) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/text/util/Linkify$MatchFilter
				/// </java-name>
				[Dot42.DexImport("android/text/util/Linkify$MatchFilter", AccessFlags = 1545)]
				public partial interface IMatchFilter
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// acceptMatch
						/// </java-name>
						[Dot42.DexImport("acceptMatch", "(Ljava/lang/CharSequence;II)Z", AccessFlags = 1025)]
						bool AcceptMatch(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ ;

				}

		}

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

				/// <java-name>
				/// tokenize
				/// </java-name>
				[Dot42.DexImport("tokenize", "(Ljava/lang/CharSequence;Ljava/util/Collection;)V", AccessFlags = 9, Signature = "(Ljava/lang/CharSequence;Ljava/util/Collection<Landroid/text/util/Rfc822Token;>;)" +
    "V")]
				public static void Tokenize(global::Java.Lang.ICharSequence charSequence, global::Java.Util.ICollection<global::Android.Text.Util.Rfc822Token> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tokenize
				/// </java-name>
				[Dot42.DexImport("tokenize", "(Ljava/lang/CharSequence;)[Landroid/text/util/Rfc822Token;", AccessFlags = 9)]
				public static global::Android.Text.Util.Rfc822Token[] Tokenize(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Util.Rfc822Token[]);
				}

				/// <java-name>
				/// findTokenStart
				/// </java-name>
				[Dot42.DexImport("findTokenStart", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1)]
				public virtual int FindTokenStart(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// findTokenEnd
				/// </java-name>
				[Dot42.DexImport("findTokenEnd", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1)]
				public virtual int FindTokenEnd(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// terminateToken
				/// </java-name>
				[Dot42.DexImport("terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence TerminateToken(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

		}

}

