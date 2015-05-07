#pragma warning disable 1717
namespace Android.Text
{
		/// <summary>
		///  <para>An AlteredCharSequence is a CharSequence that is largely mirrored from another CharSequence, except that a specified range of characters are mirrored from a different char array instead. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/AlteredCharSequence
		/// </java-name>
		[Dot42.DexImport("android/text/AlteredCharSequence", AccessFlags = 33)]
		public partial class AlteredCharSequence : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AlteredCharSequence() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create an AlteredCharSequence whose text (and possibly spans) are mirrored from  <code>source</code>, except that the range of offsets  <code>substart</code> inclusive to  <code>subend</code> exclusive are mirrored instead from  <code>sub</code>, beginning at offset 0. </para>        
				/// </summary>
				/// <java-name>
				/// make
				/// </java-name>
				[Dot42.DexImport("make", "(Ljava/lang/CharSequence;[CII)Landroid/text/AlteredCharSequence;", AccessFlags = 9)]
				public static global::Android.Text.AlteredCharSequence Make(global::Java.Lang.ICharSequence source, char[] sub, int substart, int subend) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.AlteredCharSequence);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public virtual char CharAt(int off) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Exactly like String.getChars(): copy chars  <code>start</code> through  <code>end - 1</code> from this CharSequence into  <code>dest</code> beginning at offset  <code>destoff</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public virtual void GetChars(int start, int end, char[] dest, int destoff) /* MethodBuilder.Create */ 
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

		}

		/// <summary>
		///  <para>AndroidCharacter exposes some character properties that are not easily accessed from java.lang.Character. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/AndroidCharacter
		/// </java-name>
		[Dot42.DexImport("android/text/AndroidCharacter", AccessFlags = 33)]
		public partial class AndroidCharacter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EAST_ASIAN_WIDTH_NEUTRAL
				/// </java-name>
				[Dot42.DexImport("EAST_ASIAN_WIDTH_NEUTRAL", "I", AccessFlags = 25)]
				public const int EAST_ASIAN_WIDTH_NEUTRAL = 0;
				/// <java-name>
				/// EAST_ASIAN_WIDTH_AMBIGUOUS
				/// </java-name>
				[Dot42.DexImport("EAST_ASIAN_WIDTH_AMBIGUOUS", "I", AccessFlags = 25)]
				public const int EAST_ASIAN_WIDTH_AMBIGUOUS = 1;
				/// <java-name>
				/// EAST_ASIAN_WIDTH_HALF_WIDTH
				/// </java-name>
				[Dot42.DexImport("EAST_ASIAN_WIDTH_HALF_WIDTH", "I", AccessFlags = 25)]
				public const int EAST_ASIAN_WIDTH_HALF_WIDTH = 2;
				/// <java-name>
				/// EAST_ASIAN_WIDTH_FULL_WIDTH
				/// </java-name>
				[Dot42.DexImport("EAST_ASIAN_WIDTH_FULL_WIDTH", "I", AccessFlags = 25)]
				public const int EAST_ASIAN_WIDTH_FULL_WIDTH = 3;
				/// <java-name>
				/// EAST_ASIAN_WIDTH_NARROW
				/// </java-name>
				[Dot42.DexImport("EAST_ASIAN_WIDTH_NARROW", "I", AccessFlags = 25)]
				public const int EAST_ASIAN_WIDTH_NARROW = 4;
				/// <java-name>
				/// EAST_ASIAN_WIDTH_WIDE
				/// </java-name>
				[Dot42.DexImport("EAST_ASIAN_WIDTH_WIDE", "I", AccessFlags = 25)]
				public const int EAST_ASIAN_WIDTH_WIDE = 5;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AndroidCharacter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fill in the first  <code>count</code> bytes of  <code>dest</code> with the directionalities from the first  <code>count</code> chars of  <code>src</code>. This is just like Character.getDirectionality() except it is a batch operation. </para>        
				/// </summary>
				/// <java-name>
				/// getDirectionalities
				/// </java-name>
				[Dot42.DexImport("getDirectionalities", "([C[BI)V", AccessFlags = 265)]
				public static void GetDirectionalities(char[] src, sbyte[] dest, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fill in the first  <code>count</code> bytes of  <code>dest</code> with the directionalities from the first  <code>count</code> chars of  <code>src</code>. This is just like Character.getDirectionality() except it is a batch operation. </para>        
				/// </summary>
				/// <java-name>
				/// getDirectionalities
				/// </java-name>
				[Dot42.DexImport("getDirectionalities", "([C[BI)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GetDirectionalities(char[] src, byte[] dest, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calculate the East Asian Width of a character according to . The return will be one of EAST_ASIAN_WIDTH_NEUTRAL, EAST_ASIAN_WIDTH_AMBIGUOUS, EAST_ASIAN_WIDTH_HALF_WIDTH, EAST_ASIAN_WIDTH_FULL_WIDTH, EAST_ASIAN_WIDTH_NARROW, or EAST_ASIAN_WIDTH_WIDE.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the East Asian Width for input </para>
				/// </returns>
				/// <java-name>
				/// getEastAsianWidth
				/// </java-name>
				[Dot42.DexImport("getEastAsianWidth", "(C)I", AccessFlags = 265)]
				public static int GetEastAsianWidth(char input) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Fill the first  <code>count</code> bytes of  <code>dest</code> with the East Asian Width from  <code>count</code> chars of  <code>src</code> starting at  <code>start</code>. East Asian Width is calculated based on . Each entry in  <code>dest</code> will be one of EAST_ASIAN_WIDTH_NEUTRAL, EAST_ASIAN_WIDTH_AMBIGUOUS, EAST_ASIAN_WIDTH_HALF_WIDTH, EAST_ASIAN_WIDTH_FULL_WIDTH, EAST_ASIAN_WIDTH_NARROW, or EAST_ASIAN_WIDTH_WIDE.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getEastAsianWidths
				/// </java-name>
				[Dot42.DexImport("getEastAsianWidths", "([CII[B)V", AccessFlags = 265)]
				public static void GetEastAsianWidths(char[] src, int start, int count, sbyte[] dest) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fill the first  <code>count</code> bytes of  <code>dest</code> with the East Asian Width from  <code>count</code> chars of  <code>src</code> starting at  <code>start</code>. East Asian Width is calculated based on . Each entry in  <code>dest</code> will be one of EAST_ASIAN_WIDTH_NEUTRAL, EAST_ASIAN_WIDTH_AMBIGUOUS, EAST_ASIAN_WIDTH_HALF_WIDTH, EAST_ASIAN_WIDTH_FULL_WIDTH, EAST_ASIAN_WIDTH_NARROW, or EAST_ASIAN_WIDTH_WIDE.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getEastAsianWidths
				/// </java-name>
				[Dot42.DexImport("getEastAsianWidths", "([CII[B)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GetEastAsianWidths(char[] src, int start, int count, byte[] dest) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Replace the specified slice of  <code>text</code> with the chars' right-to-left mirrors (if any), returning true if any replacements were made.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if replacements were made </para>
				/// </returns>
				/// <java-name>
				/// mirror
				/// </java-name>
				[Dot42.DexImport("mirror", "([CII)Z", AccessFlags = 265)]
				public static bool Mirror(char[] text, int start, int count) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Return the right-to-left mirror (or the original char if none) of the specified char. </para>        
				/// </summary>
				/// <java-name>
				/// getMirror
				/// </java-name>
				[Dot42.DexImport("getMirror", "(C)C", AccessFlags = 265)]
				public static char GetMirror(char ch) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

		}

		/// <summary>
		///  <para>Annotations are simple key-value pairs that are preserved across TextView save/restore cycles and can be used to keep application-specific data that needs to be maintained for regions of text. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Annotation
		/// </java-name>
		[Dot42.DexImport("android/text/Annotation", AccessFlags = 33)]
		public partial class Annotation : global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Annotation(string key, string value) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public Annotation(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Annotation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return a special type identifier for this span class. </para>        
				/// </summary>
				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				public virtual string Key
				{
						[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public virtual string Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>This class accesses a dictionary of corrections to frequent misspellings. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/AutoText
		/// </java-name>
		[Dot42.DexImport("android/text/AutoText", AccessFlags = 33)]
		public partial class AutoText
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AutoText() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieves a possible spelling correction for the specified range of text. Returns null if no correction can be found. The View is used to get the current Locale and Resources. </para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/CharSequence;IILandroid/view/View;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Get(global::Java.Lang.ICharSequence src, int start, int end, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the size of the auto text dictionary. The return value can be zero if there is no auto correction data available for the current locale. </para>        
				/// </summary>
				/// <returns>
				///  <para>the number of entries in the auto text dictionary </para>
				/// </returns>
				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "(Landroid/view/View;)I", AccessFlags = 9)]
				public static int GetSize(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>Utility class for formatting text for display in a potentially opposite-directionality context without garbling. The directionality of the context is set at formatter creation and the directionality of the text can be either estimated or passed in when known.</para> <para>To support versions lower than android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, you can use the support library's android.support.v4.text.BidiFormatter class.</para> <para>These APIs provides the following functionality: </para> <para>1. Bidi Wrapping When text in one language is mixed into a document in another, opposite-directionality language, e.g. when an English business name is embedded in some Hebrew text, both the inserted string and the text surrounding it may be displayed incorrectly unless the inserted string is explicitly separated from the surrounding text in a "wrapper" that: </para> <para> <ul> <li> <para>Declares its directionality so that the string is displayed correctly. This can be done in Unicode bidi formatting codes by unicodeWrap and similar methods. </para></li></ul></para> <para> <ul> <li> <para>Isolates the string's directionality, so it does not unduly affect the surrounding content. Currently, this can only be done using invisible Unicode characters of the same direction as the context (LRM or RLM) in addition to the directionality declaration above, thus "resetting" the directionality to that of the context. The "reset" may need to be done at both ends of the string. Without "reset" after the string, the string will "stick" to a number or logically separate opposite-direction text that happens to follow it in-line (even if separated by neutral content like spaces and punctuation). Without "reset" before the string, the same can happen there, but only with more opposite-direction text, not a number. One approach is to "reset" the direction only after each string, on the theory that if the preceding opposite- direction text is itself bidi-wrapped, the "reset" after it will prevent the sticking. (Doing the "reset" only before each string definitely does not work because we do not want to require bidi-wrapping numbers, and a bidi-wrapped opposite-direction string could be followed by a number.) Still, the safest policy is to do the "reset" on both ends of each string, since RTL message translations often contain untranslated Latin-script brand names and technical terms, and one of these can be followed by a bidi-wrapped inserted value. On the other hand, when one has such a message, it is best to do the "reset" manually in the message translation itself, since the message's opposite-direction text could be followed by an inserted number, which we would not bidi-wrap anyway. Thus, "reset" only after the string is the current default. In an alternative to "reset", recent additions to the HTML, CSS, and Unicode standards allow the isolation to be part of the directionality declaration. This form of isolation is better than "reset" because it takes less space, does not require knowing the context directionality, has a gentler effect than "reset", and protects both ends of the string. However, we do not yet allow using it because required platforms do not yet support it. </para></li></ul></para> <para>Providing these wrapping services is the basic purpose of the bidi formatter. </para> <para>2. Directionality estimation How does one know whether a string about to be inserted into surrounding text has the same directionality? Well, in many cases, one knows that this must be the case when writing the code doing the insertion, e.g. when a localized message is inserted into a localized page. In such cases there is no need to involve the bidi formatter at all. In some other cases, it need not be the same as the context, but is either constant (e.g. urls are always LTR) or otherwise known. In the remaining cases, e.g. when the string is user-entered or comes from a database, the language of the string (and thus its directionality) is not known a priori, and must be estimated at run-time. The bidi formatter can do this automatically using the default first-strong estimation algorithm. It can also be configured to use a custom directionality estimation object. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/BidiFormatter
		/// </java-name>
		[Dot42.DexImport("android/text/BidiFormatter", AccessFlags = 49)]
		public sealed partial class BidiFormatter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal BidiFormatter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Factory for creating an instance of BidiFormatter given the context locale.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Z)Landroid/text/BidiFormatter;", AccessFlags = 9)]
				public static global::Android.Text.BidiFormatter GetInstance(bool locale) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BidiFormatter);
				}

				/// <summary>
				///  <para>Factory for creating an instance of BidiFormatter given the context locale.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Landroid/text/BidiFormatter;", AccessFlags = 9)]
				public static global::Android.Text.BidiFormatter GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BidiFormatter);
				}

				/// <summary>
				///  <para>Estimates the directionality of a string using the default text direction heuristic.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if <c>str </c> 's estimated overall directionality is RTL. Otherwise returns false. </para>
				/// </returns>
				/// <java-name>
				/// isRtl
				/// </java-name>
				[Dot42.DexImport("isRtl", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool IsRtl(string str) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Formats a string of given directionality for use in plain-text output of the context directionality, so an opposite-directionality string is neither garbled nor garbles its surroundings. This makes use of Unicode bidi formatting characters. </para> <para>The algorithm: In case the given directionality doesn't match the context directionality, wraps the string with Unicode bidi formatting characters: RLE+ <c>str </c> +PDF for RTL text, or LRE+ <c>str </c> +PDF for LTR text. </para> <para>If <c>isolate </c> , directionally isolates the string so that it does not garble its surroundings. Currently, this is done by "resetting" the directionality after the string by appending a trailing Unicode bidi mark matching the context directionality (LRM or RLM) when either the overall directionality or the exit directionality of the string is opposite to that of the context. If the formatter was built using Builder#stereoReset(boolean) and passing "true" as an argument, also prepends a Unicode bidi mark matching the context directionality when either the overall directionality or the entry directionality of the string is opposite to that of the context. Note that as opposed to the overall directionality, the entry and exit directionalities are determined from the string itself. </para> <para>Does *not* do HTML-escaping.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Input string after applying the above processing. </para>
				/// </returns>
				/// <java-name>
				/// unicodeWrap
				/// </java-name>
				[Dot42.DexImport("unicodeWrap", "(Ljava/lang/String;Landroid/text/TextDirectionHeuristic;Z)Ljava/lang/String;", AccessFlags = 1)]
				public string UnicodeWrap(string str, global::Android.Text.ITextDirectionHeuristic heuristic, bool isolate) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// unicodeWrap
				/// </java-name>
				[Dot42.DexImport("unicodeWrap", "(Ljava/lang/String;Landroid/text/TextDirectionHeuristic;)Ljava/lang/String;", AccessFlags = 1)]
				public string UnicodeWrap(string @string, global::Android.Text.ITextDirectionHeuristic textDirectionHeuristic) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// unicodeWrap
				/// </java-name>
				[Dot42.DexImport("unicodeWrap", "(Ljava/lang/String;Z)Ljava/lang/String;", AccessFlags = 1)]
				public string UnicodeWrap(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Operates like unicodeWrap(String, TextDirectionHeuristic, boolean), but uses the formatter's default direction estimation algorithm and assumes <c>isolate </c> is true.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Input string after applying the above processing. </para>
				/// </returns>
				/// <java-name>
				/// unicodeWrap
				/// </java-name>
				[Dot42.DexImport("unicodeWrap", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string UnicodeWrap(string str) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Factory for creating an instance of BidiFormatter for the default locale directionality. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.BidiFormatter Instance
				{
						[Dot42.DexImport("getInstance", "()Landroid/text/BidiFormatter;", AccessFlags = 9)]
						get{ return default(global::Android.Text.BidiFormatter); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the context directionality is RTL </para>
				/// </returns>
				/// <java-name>
				/// isRtlContext
				/// </java-name>
				public bool IsRtlContext
				{
						[Dot42.DexImport("isRtlContext", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether directionality "reset" should also be done before a string being bidi-wrapped, not just after it. </para>
				/// </returns>
				/// <java-name>
				/// getStereoReset
				/// </java-name>
				public bool StereoReset
				{
						[Dot42.DexImport("getStereoReset", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>A class for building a BidiFormatter with non-default options. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/BidiFormatter$Builder
				/// </java-name>
				[Dot42.DexImport("android/text/BidiFormatter$Builder", AccessFlags = 25)]
				public sealed partial class Builder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Builder() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
						public Builder(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
						public Builder(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Specifies whether the BidiFormatter to be built should also "reset" directionality before a string being bidi-wrapped, not just after it. The default is false. </para>        
						/// </summary>
						/// <java-name>
						/// stereoReset
						/// </java-name>
						[Dot42.DexImport("stereoReset", "(Z)Landroid/text/BidiFormatter$Builder;", AccessFlags = 1)]
						public Builder StereoReset(bool stereoReset) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para>Specifies the default directionality estimation algorithm to be used by the BidiFormatter. By default, uses the first-strong heuristic.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the builder itself. </para>
						/// </returns>
						/// <java-name>
						/// setTextDirectionHeuristic
						/// </java-name>
						[Dot42.DexImport("setTextDirectionHeuristic", "(Landroid/text/TextDirectionHeuristic;)Landroid/text/BidiFormatter$Builder;", AccessFlags = 1)]
						public Builder SetTextDirectionHeuristic(global::Android.Text.ITextDirectionHeuristic heuristic) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						///  <para></para>        
						/// </summary>
						/// <returns>
						///  <para>A BidiFormatter with the specified options. </para>
						/// </returns>
						/// <java-name>
						/// build
						/// </java-name>
						[Dot42.DexImport("build", "()Landroid/text/BidiFormatter;", AccessFlags = 1)]
						public global::Android.Text.BidiFormatter Build() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Text.BidiFormatter);
						}

				}

		}

		/// <summary>
		///  <para>A BoringLayout is a very simple Layout implementation for text that fits on a single line and is all left-to-right characters. You will probably never want to make one of these yourself; if you do, be sure to call isBoring first to make sure the text meets the criteria. </para> <para>This class is used by widgets to control text layout. You should not need to use this class directly unless you are implementing your own widget or custom display object, in which case you are encouraged to use a Layout instead of calling Canvas.drawText() directly.</para>    
		/// </summary>
		/// <java-name>
		/// android/text/BoringLayout
		/// </java-name>
		[Dot42.DexImport("android/text/BoringLayout", AccessFlags = 33)]
		public partial class BoringLayout : global::Android.Text.Layout, global::Android.Text.TextUtils.IEllipsizeCallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;Z)V", AccessFlags = 1)]
				public BoringLayout(global::Java.Lang.ICharSequence source, global::Android.Text.TextPaint paint, int outerwidth, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, global::Android.Text.BoringLayout.Metrics metrics, bool includepad) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)V", AccessFlags = 1)]
				public BoringLayout(global::Java.Lang.ICharSequence source, global::Android.Text.TextPaint paint, int outerwidth, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, global::Android.Text.BoringLayout.Metrics metrics, bool includepad, global::Android.Text.TextUtils.TruncateAt ellipsize, int ellipsizedWidth) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// make
				/// </java-name>
				[Dot42.DexImport("make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;", AccessFlags = 9)]
				public static global::Android.Text.BoringLayout Make(global::Java.Lang.ICharSequence source, global::Android.Text.TextPaint paint, int outerwidth, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, global::Android.Text.BoringLayout.Metrics metrics, bool includepad) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout);
				}

				/// <java-name>
				/// make
				/// </java-name>
				[Dot42.DexImport("make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landr" +
    "oid/text/BoringLayout;", AccessFlags = 9)]
				public static global::Android.Text.BoringLayout Make(global::Java.Lang.ICharSequence source, global::Android.Text.TextPaint paint, int outerwidth, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, global::Android.Text.BoringLayout.Metrics metrics, bool includepad, global::Android.Text.TextUtils.TruncateAt ellipsize, int ellipsizedWidth) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout);
				}

				/// <summary>
				///  <para>Returns a BoringLayout for the specified text, potentially reusing this one if it is already suitable. The caller must make sure that no one is still using this Layout. </para>        
				/// </summary>
				/// <java-name>
				/// replaceOrMake
				/// </java-name>
				[Dot42.DexImport("replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;", AccessFlags = 1)]
				public virtual global::Android.Text.BoringLayout ReplaceOrMake(global::Java.Lang.ICharSequence source, global::Android.Text.TextPaint paint, int outerwidth, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, global::Android.Text.BoringLayout.Metrics metrics, bool includepad) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout);
				}

				/// <summary>
				///  <para>Returns a BoringLayout for the specified text, potentially reusing this one if it is already suitable. The caller must make sure that no one is still using this Layout. </para>        
				/// </summary>
				/// <java-name>
				/// replaceOrMake
				/// </java-name>
				[Dot42.DexImport("replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landr" +
    "oid/text/BoringLayout;", AccessFlags = 1)]
				public virtual global::Android.Text.BoringLayout ReplaceOrMake(global::Java.Lang.ICharSequence source, global::Android.Text.TextPaint paint, int outerwidth, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, global::Android.Text.BoringLayout.Metrics metrics, bool includepad, global::Android.Text.TextUtils.TruncateAt ellipsize, int ellipsizedWidth) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout);
				}

				/// <summary>
				///  <para>Returns null if not boring; the width, ascent, and descent if boring. </para>        
				/// </summary>
				/// <java-name>
				/// isBoring
				/// </java-name>
				[Dot42.DexImport("isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)Landroid/text/BoringLayout$Metr" +
    "ics;", AccessFlags = 9)]
				public static global::Android.Text.BoringLayout.Metrics IsBoring(global::Java.Lang.ICharSequence text, global::Android.Text.TextPaint paint) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout.Metrics);
				}

				/// <java-name>
				/// isBoring
				/// </java-name>
				[Dot42.DexImport("isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;Landroid/text/BoringLayout$Metri" +
    "cs;)Landroid/text/BoringLayout$Metrics;", AccessFlags = 9)]
				public static global::Android.Text.BoringLayout.Metrics IsBoring(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, global::Android.Text.BoringLayout.Metrics metrics) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout.Metrics);
				}

				/// <java-name>
				/// getLineTop
				/// </java-name>
				[Dot42.DexImport("getLineTop", "(I)I", AccessFlags = 1)]
				public override int GetLineTop(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineDescent
				/// </java-name>
				[Dot42.DexImport("getLineDescent", "(I)I", AccessFlags = 1)]
				public override int GetLineDescent(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineStart
				/// </java-name>
				[Dot42.DexImport("getLineStart", "(I)I", AccessFlags = 1)]
				public override int GetLineStart(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getParagraphDirection
				/// </java-name>
				[Dot42.DexImport("getParagraphDirection", "(I)I", AccessFlags = 1)]
				public override int GetParagraphDirection(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineContainsTab
				/// </java-name>
				[Dot42.DexImport("getLineContainsTab", "(I)Z", AccessFlags = 1)]
				public override bool GetLineContainsTab(int line) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLineMax
				/// </java-name>
				[Dot42.DexImport("getLineMax", "(I)F", AccessFlags = 1)]
				public override float GetLineMax(int line) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLineDirections
				/// </java-name>
				[Dot42.DexImport("getLineDirections", "(I)Landroid/text/Layout$Directions;", AccessFlags = 17)]
				public override global::Android.Text.Layout.Directions GetLineDirections(int line) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Directions);
				}

				/// <java-name>
				/// getEllipsisCount
				/// </java-name>
				[Dot42.DexImport("getEllipsisCount", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisCount(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisStart
				/// </java-name>
				[Dot42.DexImport("getEllipsisStart", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisStart(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas c, global::Android.Graphics.Path highlight, global::Android.Graphics.Paint highlightpaint, int cursorOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback for the ellipsizer to report what region it ellipsized. </para>        
				/// </summary>
				/// <java-name>
				/// ellipsized
				/// </java-name>
				[Dot42.DexImport("ellipsized", "(II)V", AccessFlags = 1)]
				public virtual void Ellipsized(int start, int end) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BoringLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public override int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				public override int LineCount
				{
						[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				public override int TopPadding
				{
						[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				public override int BottomPadding
				{
						[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				public override int EllipsizedWidth
				{
						[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/text/BoringLayout$Metrics
				/// </java-name>
				[Dot42.DexImport("android/text/BoringLayout$Metrics", AccessFlags = 9)]
				public partial class Metrics : global::Android.Graphics.Paint.FontMetricsInt
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// width
						/// </java-name>
						[Dot42.DexImport("width", "I", AccessFlags = 1)]
						public int Width;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Metrics() /* MethodBuilder.Create */ 
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

				}

		}

		/// <summary>
		///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Old text-only interface to the clipboard. See android.content.ClipboardManager for the modern API. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/text/ClipboardManager
		/// </java-name>
		[Dot42.DexImport("android/text/ClipboardManager", AccessFlags = 1057)]
		public abstract partial class ClipboardManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClipboardManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the text on the clipboard. It will eventually be possible to store types other than text too, in which case this will return null if the type cannot be coerced to text. </para>        
				/// </summary>
				/// <java-name>
				/// getText
				/// </java-name>
				public abstract global::Java.Lang.ICharSequence Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
						set;
				}

				/// <summary>
				///  <para>Returns true if the clipboard contains text; false otherwise. </para>        
				/// </summary>
				/// <java-name>
				/// hasText
				/// </java-name>
				public abstract bool HasText
				{
						[Dot42.DexImport("hasText", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>DynamicLayout is a text layout that updates itself as the text is edited. </para> <para>This is used by widgets to control text layout. You should not need to use this class directly unless you are implementing your own widget or custom display object, or need to call Canvas.drawText() directly.</para>    
		/// </summary>
		/// <java-name>
		/// android/text/DynamicLayout
		/// </java-name>
		[Dot42.DexImport("android/text/DynamicLayout", AccessFlags = 33)]
		public partial class DynamicLayout : global::Android.Text.Layout
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Make a layout for the specified text that will be updated as the text is changed. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFZ)V", AccessFlags = 1)]
				public DynamicLayout(global::Java.Lang.ICharSequence @base, global::Android.Text.TextPaint paint, int width, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, bool includepad) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Make a layout for the transformed text (password transformation being the primary example of a transformation) that will be updated as the base text is changed. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroi" +
    "d/text/Layout$Alignment;FFZ)V", AccessFlags = 1)]
				public DynamicLayout(global::Java.Lang.ICharSequence @base, global::Java.Lang.ICharSequence display, global::Android.Text.TextPaint paint, int width, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, bool includepad) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Make a layout for the transformed text (password transformation being the primary example of a transformation) that will be updated as the base text is changed. If ellipsize is non-null, the Layout will ellipsize the text down to ellipsizedWidth. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroi" +
    "d/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V", AccessFlags = 1)]
				public DynamicLayout(global::Java.Lang.ICharSequence @base, global::Java.Lang.ICharSequence display, global::Android.Text.TextPaint paint, int width, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, bool includepad, global::Android.Text.TextUtils.TruncateAt ellipsize, int ellipsizedWidth) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLineTop
				/// </java-name>
				[Dot42.DexImport("getLineTop", "(I)I", AccessFlags = 1)]
				public override int GetLineTop(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineDescent
				/// </java-name>
				[Dot42.DexImport("getLineDescent", "(I)I", AccessFlags = 1)]
				public override int GetLineDescent(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineStart
				/// </java-name>
				[Dot42.DexImport("getLineStart", "(I)I", AccessFlags = 1)]
				public override int GetLineStart(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineContainsTab
				/// </java-name>
				[Dot42.DexImport("getLineContainsTab", "(I)Z", AccessFlags = 1)]
				public override bool GetLineContainsTab(int line) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getParagraphDirection
				/// </java-name>
				[Dot42.DexImport("getParagraphDirection", "(I)I", AccessFlags = 1)]
				public override int GetParagraphDirection(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineDirections
				/// </java-name>
				[Dot42.DexImport("getLineDirections", "(I)Landroid/text/Layout$Directions;", AccessFlags = 17)]
				public override global::Android.Text.Layout.Directions GetLineDirections(int line) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Directions);
				}

				/// <java-name>
				/// getEllipsisStart
				/// </java-name>
				[Dot42.DexImport("getEllipsisStart", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisStart(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisCount
				/// </java-name>
				[Dot42.DexImport("getEllipsisCount", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisCount(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DynamicLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				public override int LineCount
				{
						[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				public override int TopPadding
				{
						[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				public override int BottomPadding
				{
						[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				public override int EllipsizedWidth
				{
						[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>This class processes HTML strings into displayable styled text. Not all HTML tags are supported. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Html
		/// </java-name>
		[Dot42.DexImport("android/text/Html", AccessFlags = 33)]
		public partial class Html
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Html() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns displayable styled text from the provided HTML string. Any &lt;img&gt; tags in the HTML will display as a generic replacement image which your program can then go through and replace with real images.</para> <para>This uses TagSoup to handle real HTML, including all of the brokenness found in the wild. </para>        
				/// </summary>
				/// <java-name>
				/// fromHtml
				/// </java-name>
				[Dot42.DexImport("fromHtml", "(Ljava/lang/String;)Landroid/text/Spanned;", AccessFlags = 9)]
				public static global::Android.Text.ISpanned FromHtml(string source) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.ISpanned);
				}

				/// <summary>
				///  <para>Returns displayable styled text from the provided HTML string. Any &lt;img&gt; tags in the HTML will use the specified ImageGetter to request a representation of the image (use null if you don't want this) and the specified TagHandler to handle unknown tags (specify null if you don't want this).</para> <para>This uses TagSoup to handle real HTML, including all of the brokenness found in the wild. </para>        
				/// </summary>
				/// <java-name>
				/// fromHtml
				/// </java-name>
				[Dot42.DexImport("fromHtml", "(Ljava/lang/String;Landroid/text/Html$ImageGetter;Landroid/text/Html$TagHandler;)" +
    "Landroid/text/Spanned;", AccessFlags = 9)]
				public static global::Android.Text.ISpanned FromHtml(string source, global::Android.Text.Html.IImageGetter imageGetter, global::Android.Text.Html.ITagHandler tagHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.ISpanned);
				}

				/// <summary>
				///  <para>Returns an HTML representation of the provided Spanned text. </para>        
				/// </summary>
				/// <java-name>
				/// toHtml
				/// </java-name>
				[Dot42.DexImport("toHtml", "(Landroid/text/Spanned;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHtml(global::Android.Text.ISpanned text) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns an HTML escaped representation of the given plain text. </para>        
				/// </summary>
				/// <java-name>
				/// escapeHtml
				/// </java-name>
				[Dot42.DexImport("escapeHtml", "(Ljava/lang/CharSequence;)Ljava/lang/String;", AccessFlags = 9)]
				public static string EscapeHtml(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Is notified when HTML tags are encountered that the parser does not know how to interpret. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/Html$TagHandler
				/// </java-name>
				[Dot42.DexImport("android/text/Html$TagHandler", AccessFlags = 1545)]
				public partial interface ITagHandler
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This method will be called whenn the HTML parser encounters a tag that it does not know how to interpret. </para>        
						/// </summary>
						/// <java-name>
						/// handleTag
						/// </java-name>
						[Dot42.DexImport("handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V", AccessFlags = 1025)]
						void HandleTag(bool opening, string tag, global::Android.Text.IEditable output, global::Org.Xml.Sax.IXMLReader xmlReader) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Retrieves images for HTML &lt;img&gt; tags. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/Html$ImageGetter
				/// </java-name>
				[Dot42.DexImport("android/text/Html$ImageGetter", AccessFlags = 1545)]
				public partial interface IImageGetter
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This methos is called when the HTML parser encounters an &lt;img&gt; tag. The  <code>source</code> argument is the string from the "src" attribute; the return value should be a Drawable representation of the image or  <code>null</code> for a generic replacement image. Make sure you call setBounds() on your Drawable if it doesn't already have its bounds set. </para>        
						/// </summary>
						/// <java-name>
						/// getDrawable
						/// </java-name>
						[Dot42.DexImport("getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						global::Android.Graphics.Drawables.Drawable GetDrawable(string source) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>This is the interface for text whose content and markup can be changed (as opposed to immutable text like Strings). If you make a DynamicLayout of an Editable, the layout will be reflowed as the text is changed. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Editable
		/// </java-name>
		[Dot42.DexImport("android/text/Editable", AccessFlags = 1537)]
		public partial interface IEditable : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars, global::Android.Text.ISpannable, global::Java.Lang.IAppendable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Replaces the specified range ( <code>st <hellip></hellip>en</code>) of text in this Editable with a copy of the slice  <code>start <hellip></hellip>end</code> from  <code>source</code>. The destination slice may be empty, in which case the operation is an insertion, or the source slice may be empty, in which case the operation is a deletion. </para> <para>Before the change is committed, each filter that was set with setFilters is given the opportunity to modify the  <code>source</code> text. </para> <para>If  <code>source</code> is Spanned, the spans from it are preserved into the Editable. Existing spans within the Editable that entirely cover the replaced range are retained, but any that were strictly within the range that was replaced are removed. As a special case, the cursor position is preserved even when the entire range where it is located is replaced. </para>        
				/// </summary>
				/// <returns>
				///  <para>a reference to this object. </para>
				/// </returns>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Replace(int st, int en, global::Java.Lang.ICharSequence source, int start, int end) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Convenience for replace(st, en, text, 0, text.length())  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Replace(int st, int en, global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Convenience for replace(where, where, text, start, end)  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Insert(int where, global::Java.Lang.ICharSequence text, int start, int end) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Convenience for replace(where, where, text, 0, text.length());  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Insert(int where, global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Convenience for replace(st, en, "", 0, 0)  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Delete(int st, int en) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Convenience for replace(length(), length(), text, start, end)  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable JavaAppend(global::Java.Lang.ICharSequence text, int start, int end) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Append(char @char) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Convenience for replace(0, length(), "", 0, 0)  <para>replace(int, int, CharSequence, int, int) Note that this clears the text, not the spans; use clearSpans if you need that. </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes all spans from the Editable, as if by calling removeSpan on each of them. </para>        
				/// </summary>
				/// <java-name>
				/// clearSpans
				/// </java-name>
				[Dot42.DexImport("clearSpans", "()V", AccessFlags = 1025)]
				void ClearSpans() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the array of input filters that are currently applied to changes to this Editable. </para>        
				/// </summary>
				/// <java-name>
				/// getFilters
				/// </java-name>
				global::Android.Text.IInputFilter[] Filters
				{
						[Dot42.DexImport("getFilters", "()[Landroid/text/InputFilter;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setFilters", "([Landroid/text/InputFilter;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <summary>
		///  <para>Factory used by TextView to create new Editables. You can subclass it to provide something other than SpannableStringBuilder. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Editable$Factory
		/// </java-name>
		[Dot42.DexImport("android/text/Editable$Factory", AccessFlags = 9)]
		public partial class IEditable_Factory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IEditable_Factory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new SpannedStringBuilder from the specified CharSequence. You can override this to provide a different kind of Spanned. </para>        
				/// </summary>
				/// <java-name>
				/// newEditable
				/// </java-name>
				[Dot42.DexImport("newEditable", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1)]
				public virtual global::Android.Text.IEditable NewEditable(global::Java.Lang.ICharSequence source) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.IEditable);
				}

				/// <summary>
				///  <para>Returns the standard Editable Factory. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.IEditable_Factory Instance
				{
						[Dot42.DexImport("getInstance", "()Landroid/text/Editable$Factory;", AccessFlags = 9)]
						get{ return default(global::Android.Text.IEditable_Factory); }
				}

		}

		/// <summary>
		///  <para>Please implement this interface if your CharSequence has a getChars() method like the one in String that is faster than calling charAt() multiple times. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/GetChars
		/// </java-name>
		[Dot42.DexImport("android/text/GetChars", AccessFlags = 1537)]
		public partial interface IGetChars : global::Java.Lang.ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Exactly like String.getChars(): copy chars  <code>start</code> through  <code>end - 1</code> from this CharSequence into  <code>dest</code> beginning at offset  <code>destoff</code>. </para>        
				/// </summary>
				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1025)]
				void GetChars(int start, int end, char[] dest, int destoff) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>InputFilters can be attached to Editables to constrain the changes that can be made to them. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/InputFilter
		/// </java-name>
		[Dot42.DexImport("android/text/InputFilter", AccessFlags = 1537)]
		public partial interface IInputFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method is called when the buffer is going to replace the range  <code>dstart  <hellip></hellip> dend</code> of  <code>dest</code> with the new text from the range  <code>start  <hellip></hellip> end</code> of  <code>source</code>. Return the CharSequence that you would like to have placed there instead, including an empty string if appropriate, or  <code>null</code> to accept the original replacement. Be careful to not to reject 0-length replacements, as this is what happens when you delete text. Also beware that you should not attempt to make any changes to  <code>dest</code> from this method; you may only examine it for context.</para> <para>Note: If  <b>source</b> is an instance of Spanned or Spannable, the span objects in the  <b>source</b> should be copied into the filtered result (i.e. the non-null return value). TextUtils#copySpansFrom can be used for convenience. </para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence source, int start, int end, global::Android.Text.ISpanned dest, int dstart, int dend) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>This filter will capitalize all the lower case letters that are added through edits. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/InputFilter$AllCaps
		/// </java-name>
		[Dot42.DexImport("android/text/InputFilter$AllCaps", AccessFlags = 9)]
		public partial class IInputFilter_AllCaps : global::Android.Text.IInputFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IInputFilter_AllCaps() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called when the buffer is going to replace the range  <code>dstart  <hellip></hellip> dend</code> of  <code>dest</code> with the new text from the range  <code>start  <hellip></hellip> end</code> of  <code>source</code>. Return the CharSequence that you would like to have placed there instead, including an empty string if appropriate, or  <code>null</code> to accept the original replacement. Be careful to not to reject 0-length replacements, as this is what happens when you delete text. Also beware that you should not attempt to make any changes to  <code>dest</code> from this method; you may only examine it for context.</para> <para>Note: If  <b>source</b> is an instance of Spanned or Spannable, the span objects in the  <b>source</b> should be copied into the filtered result (i.e. the non-null return value). TextUtils#copySpansFrom can be used for convenience. </para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence source, int start, int end, global::Android.Text.ISpanned dest, int dstart, int dend) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

		}

		/// <summary>
		///  <para>This filter will constrain edits not to make the length of the text greater than the specified length. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/InputFilter$LengthFilter
		/// </java-name>
		[Dot42.DexImport("android/text/InputFilter$LengthFilter", AccessFlags = 9)]
		public partial class IInputFilter_LengthFilter : global::Android.Text.IInputFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IInputFilter_LengthFilter(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called when the buffer is going to replace the range  <code>dstart  <hellip></hellip> dend</code> of  <code>dest</code> with the new text from the range  <code>start  <hellip></hellip> end</code> of  <code>source</code>. Return the CharSequence that you would like to have placed there instead, including an empty string if appropriate, or  <code>null</code> to accept the original replacement. Be careful to not to reject 0-length replacements, as this is what happens when you delete text. Also beware that you should not attempt to make any changes to  <code>dest</code> from this method; you may only examine it for context.</para> <para>Note: If  <b>source</b> is an instance of Spanned or Spannable, the span objects in the  <b>source</b> should be copied into the filtered result (i.e. the non-null return value). TextUtils#copySpansFrom can be used for convenience. </para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence source, int start, int end, global::Android.Text.ISpanned dest, int dstart, int dend) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IInputFilter_LengthFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Bit definitions for an integer defining the basic content type of text held in an Editable object. Supported classes may be combined with variations and flags to indicate desired behaviors.</para> <para> <h3>Examples</h3></para> <para></para>    
		/// </summary>
		/// <java-name>
		/// android/text/InputType
		/// </java-name>
		[Dot42.DexImport("android/text/InputType", AccessFlags = 1537)]
		public partial interface IInputType
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Bit definitions for an integer defining the basic content type of text held in an Editable object. Supported classes may be combined with variations and flags to indicate desired behaviors.</para> <para> <h3>Examples</h3></para> <para></para>    
		/// </summary>
		/// <java-name>
		/// android/text/InputType
		/// </java-name>
		[Dot42.DexImport("android/text/InputType", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IInputTypeConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Mask of bits that determine the overall class of text being given. Currently supported classes are: TYPE_CLASS_TEXT, TYPE_CLASS_NUMBER, TYPE_CLASS_PHONE, TYPE_CLASS_DATETIME. </para> <para>IME authors: If the class is not one you understand, assume TYPE_CLASS_TEXT with NO variation or flags.</para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MASK_CLASS
				/// </java-name>
				[Dot42.DexImport("TYPE_MASK_CLASS", "I", AccessFlags = 25)]
				public const int TYPE_MASK_CLASS = 15;
				/// <summary>
				///  <para>Mask of bits that determine the variation of the base content class. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MASK_VARIATION
				/// </java-name>
				[Dot42.DexImport("TYPE_MASK_VARIATION", "I", AccessFlags = 25)]
				public const int TYPE_MASK_VARIATION = 4080;
				/// <summary>
				///  <para>Mask of bits that provide addition bit flags of options. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MASK_FLAGS
				/// </java-name>
				[Dot42.DexImport("TYPE_MASK_FLAGS", "I", AccessFlags = 25)]
				public const int TYPE_MASK_FLAGS = 16773120;
				/// <summary>
				///  <para>Special content type for when no explicit type has been specified. This should be interpreted to mean that the target input connection is not rich, it can not process and show things like candidate text nor retrieve the current text, so the input method will need to run in a limited "generate key events" mode, if it supports it. Note that some input methods may not support it, for example a voice-based input method will likely not be able to generate key events even if this flag is set. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NULL
				/// </java-name>
				[Dot42.DexImport("TYPE_NULL", "I", AccessFlags = 25)]
				public const int TYPE_NULL = 0;
				/// <summary>
				///  <para>Class for normal text. This class supports the following flags (only one of which should be set): TYPE_TEXT_FLAG_CAP_CHARACTERS, TYPE_TEXT_FLAG_CAP_WORDS, and. TYPE_TEXT_FLAG_CAP_SENTENCES. It also supports the following variations: TYPE_TEXT_VARIATION_NORMAL, and TYPE_TEXT_VARIATION_URI. If you do not recognize the variation, normal should be assumed. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_CLASS_TEXT
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASS_TEXT", "I", AccessFlags = 25)]
				public const int TYPE_CLASS_TEXT = 1;
				/// <summary>
				///  <para>Flag for TYPE_CLASS_TEXT: capitalize all characters. Overrides TYPE_TEXT_FLAG_CAP_WORDS and TYPE_TEXT_FLAG_CAP_SENTENCES. This value is explicitly defined to be the same as TextUtils#CAP_MODE_CHARACTERS. Of course, this only affects languages where there are upper-case and lower-case letters. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_FLAG_CAP_CHARACTERS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_CAP_CHARACTERS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_CAP_CHARACTERS = 4096;
				/// <summary>
				///  <para>Flag for TYPE_CLASS_TEXT: capitalize the first character of every word. Overrides TYPE_TEXT_FLAG_CAP_SENTENCES. This value is explicitly defined to be the same as TextUtils#CAP_MODE_WORDS. Of course, this only affects languages where there are upper-case and lower-case letters. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_FLAG_CAP_WORDS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_CAP_WORDS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_CAP_WORDS = 8192;
				/// <summary>
				///  <para>Flag for TYPE_CLASS_TEXT: capitalize the first character of each sentence. This value is explicitly defined to be the same as TextUtils#CAP_MODE_SENTENCES. For example in English it means to capitalize after a period and a space (note that other languages may have different characters for period, or not use spaces, or use different grammatical rules). Of course, this only affects languages where there are upper-case and lower-case letters. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_FLAG_CAP_SENTENCES
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_CAP_SENTENCES", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_CAP_SENTENCES = 16384;
				/// <summary>
				///  <para>Flag for TYPE_CLASS_TEXT: the user is entering free-form text that should have auto-correction applied to it. Without this flag, the IME will not try to correct typos. You should always set this flag unless you really expect users to type non-words in this field, for example to choose a name for a character in a game. Contrast this with TYPE_TEXT_FLAG_AUTO_COMPLETE and TYPE_TEXT_FLAG_NO_SUGGESTIONS:  <c>TYPE_TEXT_FLAG_AUTO_CORRECT </c> means that the IME will try to auto-correct typos as the user is typing, but does not define whether the IME offers an interface to show suggestions. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_FLAG_AUTO_CORRECT
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_AUTO_CORRECT", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_AUTO_CORRECT = 32768;
				/// <summary>
				///  <para>Flag for TYPE_CLASS_TEXT: the text editor (which means the application) is performing auto-completion of the text being entered based on its own semantics, which it will present to the user as they type. This generally means that the input method should not be showing candidates itself, but can expect the editor to supply its own completions/candidates from InputMethodSession.displayCompletions() as a result of the editor calling InputMethodManager.displayCompletions(). Note the contrast with TYPE_TEXT_FLAG_AUTO_CORRECT and TYPE_TEXT_FLAG_NO_SUGGESTIONS:  <c>TYPE_TEXT_FLAG_AUTO_COMPLETE </c> means the editor should show an interface for displaying suggestions, but instead of supplying its own it will rely on the Editor to pass completions/corrections. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_FLAG_AUTO_COMPLETE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_AUTO_COMPLETE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_AUTO_COMPLETE = 65536;
				/// <summary>
				///  <para>Flag for TYPE_CLASS_TEXT: multiple lines of text can be entered into the field. If this flag is not set, the text field will be constrained to a single line. The IME may also choose not to display an enter key when this flag is not set, as there should be no need to create new lines. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_FLAG_MULTI_LINE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_MULTI_LINE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_MULTI_LINE = 131072;
				/// <summary>
				///  <para>Flag for TYPE_CLASS_TEXT: the regular text view associated with this should not be multi-line, but when a fullscreen input method is providing text it should use multiple lines if it can. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_FLAG_IME_MULTI_LINE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_IME_MULTI_LINE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_IME_MULTI_LINE = 262144;
				/// <summary>
				///  <para>Flag for TYPE_CLASS_TEXT: the input method does not need to display any dictionary-based candidates. This is useful for text views that do not contain words from the language and do not benefit from any dictionary-based completions or corrections. It overrides the TYPE_TEXT_FLAG_AUTO_CORRECT value when set. Please avoid using this unless you are certain this is what you want. Many input methods need suggestions to work well, for example the ones based on gesture typing. Consider clearing TYPE_TEXT_FLAG_AUTO_CORRECT instead if you just do not want the IME to correct typos. Note the contrast with TYPE_TEXT_FLAG_AUTO_CORRECT and TYPE_TEXT_FLAG_AUTO_COMPLETE:  <c>TYPE_TEXT_FLAG_NO_SUGGESTIONS </c> means the IME should never show an interface to display suggestions. Most IMEs will also take this to mean they should not try to auto-correct what the user is typing. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_FLAG_NO_SUGGESTIONS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_NO_SUGGESTIONS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_NO_SUGGESTIONS = 524288;
				/// <summary>
				///  <para>Default variation of TYPE_CLASS_TEXT: plain old normal text. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_NORMAL
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_NORMAL", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_NORMAL = 0;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering a URI. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_URI
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_URI", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_URI = 16;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering an e-mail address. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_EMAIL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_EMAIL_ADDRESS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_EMAIL_ADDRESS = 32;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering the subject line of an e-mail. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_EMAIL_SUBJECT
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_EMAIL_SUBJECT", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_EMAIL_SUBJECT = 48;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering a short, possibly informal message such as an instant message or a text message. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_SHORT_MESSAGE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_SHORT_MESSAGE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_SHORT_MESSAGE = 64;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering the content of a long, possibly formal message such as the body of an e-mail. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_LONG_MESSAGE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_LONG_MESSAGE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_LONG_MESSAGE = 80;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering the name of a person. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_PERSON_NAME
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_PERSON_NAME", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_PERSON_NAME = 96;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering a postal mailing address. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_POSTAL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_POSTAL_ADDRESS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_POSTAL_ADDRESS = 112;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering a password. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_PASSWORD
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_PASSWORD", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_PASSWORD = 128;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering a password, which should be visible to the user. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_VISIBLE_PASSWORD
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_VISIBLE_PASSWORD", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_VISIBLE_PASSWORD = 144;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering text inside of a web form. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_WEB_EDIT_TEXT
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_WEB_EDIT_TEXT", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_WEB_EDIT_TEXT = 160;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering text to filter contents of a list etc. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_FILTER
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_FILTER", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_FILTER = 176;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering text for phonetic pronunciation, such as a phonetic name field in contacts. This is mostly useful for languages where one spelling may have several phonetic readings, like Japanese. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_PHONETIC
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_PHONETIC", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_PHONETIC = 192;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering e-mail address inside of a web form. This was added in android.os.Build.VERSION_CODES#HONEYCOMB. An IME must target this API version or later to see this input type; if it doesn't, a request for this type will be seen as TYPE_TEXT_VARIATION_EMAIL_ADDRESS when passed through EditorInfo.makeCompatible(int). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS = 208;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_TEXT: entering password inside of a web form. This was added in android.os.Build.VERSION_CODES#HONEYCOMB. An IME must target this API version or later to see this input type; if it doesn't, a request for this type will be seen as TYPE_TEXT_VARIATION_PASSWORD when passed through EditorInfo.makeCompatible(int). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TEXT_VARIATION_WEB_PASSWORD
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_WEB_PASSWORD", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_WEB_PASSWORD = 224;
				/// <summary>
				///  <para>Class for numeric text. This class supports the following flags: TYPE_NUMBER_FLAG_SIGNED and TYPE_NUMBER_FLAG_DECIMAL. It also supports the following variations: TYPE_NUMBER_VARIATION_NORMAL and TYPE_NUMBER_VARIATION_PASSWORD. </para> <para>IME authors: If you do not recognize the variation, normal should be assumed.</para>        
				/// </summary>
				/// <java-name>
				/// TYPE_CLASS_NUMBER
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASS_NUMBER", "I", AccessFlags = 25)]
				public const int TYPE_CLASS_NUMBER = 2;
				/// <summary>
				///  <para>Flag of TYPE_CLASS_NUMBER: the number is signed, allowing a positive or negative sign at the start. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NUMBER_FLAG_SIGNED
				/// </java-name>
				[Dot42.DexImport("TYPE_NUMBER_FLAG_SIGNED", "I", AccessFlags = 25)]
				public const int TYPE_NUMBER_FLAG_SIGNED = 4096;
				/// <summary>
				///  <para>Flag of TYPE_CLASS_NUMBER: the number is decimal, allowing a decimal point to provide fractional values. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NUMBER_FLAG_DECIMAL
				/// </java-name>
				[Dot42.DexImport("TYPE_NUMBER_FLAG_DECIMAL", "I", AccessFlags = 25)]
				public const int TYPE_NUMBER_FLAG_DECIMAL = 8192;
				/// <summary>
				///  <para>Default variation of TYPE_CLASS_NUMBER: plain normal numeric text. This was added in android.os.Build.VERSION_CODES#HONEYCOMB. An IME must target this API version or later to see this input type; if it doesn't, a request for this type will be dropped when passed through EditorInfo.makeCompatible(int). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NUMBER_VARIATION_NORMAL
				/// </java-name>
				[Dot42.DexImport("TYPE_NUMBER_VARIATION_NORMAL", "I", AccessFlags = 25)]
				public const int TYPE_NUMBER_VARIATION_NORMAL = 0;
				/// <summary>
				///  <para>Variation of TYPE_CLASS_NUMBER: entering a numeric password. This was added in android.os.Build.VERSION_CODES#HONEYCOMB. An IME must target this API version or later to see this input type; if it doesn't, a request for this type will be dropped when passed through EditorInfo.makeCompatible(int). </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NUMBER_VARIATION_PASSWORD
				/// </java-name>
				[Dot42.DexImport("TYPE_NUMBER_VARIATION_PASSWORD", "I", AccessFlags = 25)]
				public const int TYPE_NUMBER_VARIATION_PASSWORD = 16;
				/// <summary>
				///  <para>Class for a phone number. This class currently supports no variations or flags. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_CLASS_PHONE
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASS_PHONE", "I", AccessFlags = 25)]
				public const int TYPE_CLASS_PHONE = 3;
				/// <summary>
				///  <para>Class for dates and times. It supports the following variations: TYPE_DATETIME_VARIATION_NORMAL TYPE_DATETIME_VARIATION_DATE, and TYPE_DATETIME_VARIATION_TIME. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_CLASS_DATETIME
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASS_DATETIME", "I", AccessFlags = 25)]
				public const int TYPE_CLASS_DATETIME = 4;
				/// <summary>
				///  <para>Default variation of TYPE_CLASS_DATETIME: allows entering both a date and time. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_DATETIME_VARIATION_NORMAL
				/// </java-name>
				[Dot42.DexImport("TYPE_DATETIME_VARIATION_NORMAL", "I", AccessFlags = 25)]
				public const int TYPE_DATETIME_VARIATION_NORMAL = 0;
				/// <summary>
				///  <para>Default variation of TYPE_CLASS_DATETIME: allows entering only a date. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_DATETIME_VARIATION_DATE
				/// </java-name>
				[Dot42.DexImport("TYPE_DATETIME_VARIATION_DATE", "I", AccessFlags = 25)]
				public const int TYPE_DATETIME_VARIATION_DATE = 16;
				/// <summary>
				///  <para>Default variation of TYPE_CLASS_DATETIME: allows entering only a time. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_DATETIME_VARIATION_TIME
				/// </java-name>
				[Dot42.DexImport("TYPE_DATETIME_VARIATION_TIME", "I", AccessFlags = 25)]
				public const int TYPE_DATETIME_VARIATION_TIME = 32;
		}

		/// <summary>
		///  <para>This interface should be added to a span object that should not be copied into a new Spenned when performing a slice or copy operation on the original Spanned it was placed in. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/NoCopySpan
		/// </java-name>
		[Dot42.DexImport("android/text/NoCopySpan", AccessFlags = 1537)]
		public partial interface INoCopySpan
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Convenience equivalent for when you would just want a new Object() for a span but want it to be no-copy. Use this instead. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/NoCopySpan$Concrete
		/// </java-name>
		[Dot42.DexImport("android/text/NoCopySpan$Concrete", AccessFlags = 9)]
		public partial class INoCopySpan_Concrete : global::Android.Text.INoCopySpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public INoCopySpan_Concrete() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A special kind of Parcelable for objects that will serve as text spans. This can only be used by code in the framework; it is not intended for applications to implement their own Parcelable spans. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/ParcelableSpan
		/// </java-name>
		[Dot42.DexImport("android/text/ParcelableSpan", AccessFlags = 1537)]
		public partial interface IParcelableSpan : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Return a special type identifier for this span class. </para>        
				/// </summary>
				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>This is the interface for text to which markup objects can be attached and detached. Not all Spannable classes have mutable text; see Editable for that. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Spannable
		/// </java-name>
		[Dot42.DexImport("android/text/Spannable", AccessFlags = 1537)]
		public partial interface ISpannable : global::Android.Text.ISpanned
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Attach the specified markup object to the range  <code>start <hellip></hellip>end</code> of the text, or move the object to that range if it was already attached elsewhere. See Spanned for an explanation of what the flags mean. The object can be one that has meaning only within your application, or it can be one that the text system will use to affect text display or behavior. Some noteworthy ones are the subclasses of android.text.style.CharacterStyle and android.text.style.ParagraphStyle, and android.text.TextWatcher and android.text.SpanWatcher. </para>        
				/// </summary>
				/// <java-name>
				/// setSpan
				/// </java-name>
				[Dot42.DexImport("setSpan", "(Ljava/lang/Object;III)V", AccessFlags = 1025)]
				void SetSpan(object what, int start, int end, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove the specified object from the range of text to which it was attached, if any. It is OK to remove an object that was never attached in the first place. </para>        
				/// </summary>
				/// <java-name>
				/// removeSpan
				/// </java-name>
				[Dot42.DexImport("removeSpan", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void RemoveSpan(object what) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Factory used by TextView to create new Spannables. You can subclass it to provide something other than SpannableString. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Spannable$Factory
		/// </java-name>
		[Dot42.DexImport("android/text/Spannable$Factory", AccessFlags = 9)]
		public partial class ISpannable_Factory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ISpannable_Factory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new SpannableString from the specified CharSequence. You can override this to provide a different kind of Spannable. </para>        
				/// </summary>
				/// <java-name>
				/// newSpannable
				/// </java-name>
				[Dot42.DexImport("newSpannable", "(Ljava/lang/CharSequence;)Landroid/text/Spannable;", AccessFlags = 1)]
				public virtual global::Android.Text.ISpannable NewSpannable(global::Java.Lang.ICharSequence source) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.ISpannable);
				}

				/// <summary>
				///  <para>Returns the standard Spannable Factory. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.ISpannable_Factory Instance
				{
						[Dot42.DexImport("getInstance", "()Landroid/text/Spannable$Factory;", AccessFlags = 9)]
						get{ return default(global::Android.Text.ISpannable_Factory); }
				}

		}

		/// <summary>
		///  <para>This is the interface for text that has markup objects attached to ranges of it. Not all text classes have mutable markup or text; see Spannable for mutable markup and Editable for mutable text. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Spanned
		/// </java-name>
		[Dot42.DexImport("android/text/Spanned", AccessFlags = 1537)]
		public partial interface ISpanned : global::Java.Lang.ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Return an array of the markup objects attached to the specified slice of this CharSequence and whose type is the specified type or a subclass of it. Specify Object.class for the type if you want all the objects regardless of type. </para>        
				/// </summary>
				/// <java-name>
				/// getSpans
				/// </java-name>
				[Dot42.DexImport("getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(IILjava/lang/Class<TT;>;)[TT;")]
				T[] GetSpans<T>(int start, int end, global::System.Type type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the beginning of the range of text to which the specified markup object is attached, or -1 if the object is not attached. </para>        
				/// </summary>
				/// <java-name>
				/// getSpanStart
				/// </java-name>
				[Dot42.DexImport("getSpanStart", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int GetSpanStart(object tag) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the end of the range of text to which the specified markup object is attached, or -1 if the object is not attached. </para>        
				/// </summary>
				/// <java-name>
				/// getSpanEnd
				/// </java-name>
				[Dot42.DexImport("getSpanEnd", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int GetSpanEnd(object tag) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the flags that were specified when Spannable#setSpan was used to attach the specified markup object, or 0 if the specified object has not been attached. </para>        
				/// </summary>
				/// <java-name>
				/// getSpanFlags
				/// </java-name>
				[Dot42.DexImport("getSpanFlags", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int GetSpanFlags(object tag) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the first offset greater than or equal to  <code>start</code> where a markup object of class  <code>type</code> begins or ends, or  <code>limit</code> if there are no starts or ends greater than or equal to  <code>start</code> but less than  <code>limit</code>. Specify  <code>null</code> or Object.class for the type if you want every transition regardless of type. </para>        
				/// </summary>
				/// <java-name>
				/// nextSpanTransition
				/// </java-name>
				[Dot42.DexImport("nextSpanTransition", "(IILjava/lang/Class;)I", AccessFlags = 1025)]
				int NextSpanTransition(int start, int limit, global::System.Type type) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>This is the interface for text that has markup objects attached to ranges of it. Not all text classes have mutable markup or text; see Spannable for mutable markup and Editable for mutable text. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Spanned
		/// </java-name>
		[Dot42.DexImport("android/text/Spanned", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISpannedConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Bitmask of bits that are relevent for controlling point/mark behavior of spans.</para> <para>MARK and POINT are conceptually located  <b>between</b> two adjacent characters. A MARK is "attached" to the character before, while a POINT will stick to the character after. The insertion cursor is conceptually located between the MARK and the POINT.</para> <para>As a result, inserting a new character between a MARK and a POINT will leave the MARK unchanged, while the POINT will be shifted, now located after the inserted character and still glued to the same character after it.</para> <para>Depending on whether the insertion happens at the beginning or the end of a span, the span will hence be expanded to  <b>include</b> the new character (when the span is using a MARK at its beginning or a POINT at its end) or it will be  <b>excluded</b>.</para> <para>Note that  <b>before</b> and  <b>after</b> here refer to offsets in the String, which are independent from the visual representation of the text (left-to-right or right-to-left). </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_POINT_MARK_MASK
				/// </java-name>
				[Dot42.DexImport("SPAN_POINT_MARK_MASK", "I", AccessFlags = 25)]
				public const int SPAN_POINT_MARK_MASK = 51;
				/// <summary>
				///  <para>0-length spans with type SPAN_MARK_MARK behave like text marks: they remain at their original offset when text is inserted at that offset. Conceptually, the text is added after the mark. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_MARK_MARK
				/// </java-name>
				[Dot42.DexImport("SPAN_MARK_MARK", "I", AccessFlags = 25)]
				public const int SPAN_MARK_MARK = 17;
				/// <summary>
				///  <para>SPAN_MARK_POINT is a synonym for SPAN_INCLUSIVE_INCLUSIVE. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_MARK_POINT
				/// </java-name>
				[Dot42.DexImport("SPAN_MARK_POINT", "I", AccessFlags = 25)]
				public const int SPAN_MARK_POINT = 18;
				/// <summary>
				///  <para>SPAN_POINT_MARK is a synonym for SPAN_EXCLUSIVE_EXCLUSIVE. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_POINT_MARK
				/// </java-name>
				[Dot42.DexImport("SPAN_POINT_MARK", "I", AccessFlags = 25)]
				public const int SPAN_POINT_MARK = 33;
				/// <summary>
				///  <para>0-length spans with type SPAN_POINT_POINT behave like cursors: they are pushed forward by the length of the insertion when text is inserted at their offset. The text is conceptually inserted before the point. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_POINT_POINT
				/// </java-name>
				[Dot42.DexImport("SPAN_POINT_POINT", "I", AccessFlags = 25)]
				public const int SPAN_POINT_POINT = 34;
				/// <summary>
				///  <para>SPAN_PARAGRAPH behaves like SPAN_INCLUSIVE_EXCLUSIVE (SPAN_MARK_MARK), except that if either end of the span is at the end of the buffer, that end behaves like _POINT instead (so SPAN_INCLUSIVE_INCLUSIVE if it starts in the middle and ends at the end, or SPAN_EXCLUSIVE_INCLUSIVE if it both starts and ends at the end). </para> <para>Its endpoints must be the start or end of the buffer or immediately after a  <br></br> character, and if the  <br></br>that anchors it is deleted, the endpoint is pulled to the next  <br></br> that follows in the buffer (or to the end of the buffer). </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_PARAGRAPH
				/// </java-name>
				[Dot42.DexImport("SPAN_PARAGRAPH", "I", AccessFlags = 25)]
				public const int SPAN_PARAGRAPH = 51;
				/// <summary>
				///  <para>Non-0-length spans of type SPAN_INCLUSIVE_EXCLUSIVE expand to include text inserted at their starting point but not at their ending point. When 0-length, they behave like marks. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_INCLUSIVE_EXCLUSIVE
				/// </java-name>
				[Dot42.DexImport("SPAN_INCLUSIVE_EXCLUSIVE", "I", AccessFlags = 25)]
				public const int SPAN_INCLUSIVE_EXCLUSIVE = 17;
				/// <summary>
				///  <para>Spans of type SPAN_INCLUSIVE_INCLUSIVE expand to include text inserted at either their starting or ending point. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_INCLUSIVE_INCLUSIVE
				/// </java-name>
				[Dot42.DexImport("SPAN_INCLUSIVE_INCLUSIVE", "I", AccessFlags = 25)]
				public const int SPAN_INCLUSIVE_INCLUSIVE = 18;
				/// <summary>
				///  <para>Spans of type SPAN_EXCLUSIVE_EXCLUSIVE do not expand to include text inserted at either their starting or ending point. They can never have a length of 0 and are automatically removed from the buffer if all the text they cover is removed. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_EXCLUSIVE_EXCLUSIVE
				/// </java-name>
				[Dot42.DexImport("SPAN_EXCLUSIVE_EXCLUSIVE", "I", AccessFlags = 25)]
				public const int SPAN_EXCLUSIVE_EXCLUSIVE = 33;
				/// <summary>
				///  <para>Non-0-length spans of type SPAN_EXCLUSIVE_INCLUSIVE expand to include text inserted at their ending point but not at their starting point. When 0-length, they behave like points. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_EXCLUSIVE_INCLUSIVE
				/// </java-name>
				[Dot42.DexImport("SPAN_EXCLUSIVE_INCLUSIVE", "I", AccessFlags = 25)]
				public const int SPAN_EXCLUSIVE_INCLUSIVE = 34;
				/// <summary>
				///  <para>This flag is set on spans that are being used to apply temporary styling information on the composing text of an input method, so that they can be found and removed when the composing text is being replaced. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_COMPOSING
				/// </java-name>
				[Dot42.DexImport("SPAN_COMPOSING", "I", AccessFlags = 25)]
				public const int SPAN_COMPOSING = 256;
				/// <summary>
				///  <para>This flag will be set for intermediate span changes, meaning there is guaranteed to be another change following it. Typically it is used for Selection which automatically uses this with the first offset it sets when updating the selection. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_INTERMEDIATE
				/// </java-name>
				[Dot42.DexImport("SPAN_INTERMEDIATE", "I", AccessFlags = 25)]
				public const int SPAN_INTERMEDIATE = 512;
				/// <summary>
				///  <para>The bits numbered SPAN_USER_SHIFT and above are available for callers to use to store scalar data associated with their span object. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_USER_SHIFT
				/// </java-name>
				[Dot42.DexImport("SPAN_USER_SHIFT", "I", AccessFlags = 25)]
				public const int SPAN_USER_SHIFT = 24;
				/// <summary>
				///  <para>The bits specified by the SPAN_USER bitfield are available for callers to use to store scalar data associated with their span object. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_USER
				/// </java-name>
				[Dot42.DexImport("SPAN_USER", "I", AccessFlags = 25)]
				public const int SPAN_USER = -16777216;
				/// <summary>
				///  <para>The bits numbered just above SPAN_PRIORITY_SHIFT determine the order of change notifications  higher numbers go first. You probably don't need to set this; it is used so that when text changes, the text layout gets the chance to update itself before any other callbacks can inquire about the layout of the text. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_PRIORITY_SHIFT
				/// </java-name>
				[Dot42.DexImport("SPAN_PRIORITY_SHIFT", "I", AccessFlags = 25)]
				public const int SPAN_PRIORITY_SHIFT = 16;
				/// <summary>
				///  <para>The bits specified by the SPAN_PRIORITY bitmap determine the order of change notifications  higher numbers go first. You probably don't need to set this; it is used so that when text changes, the text layout gets the chance to update itself before any other callbacks can inquire about the layout of the text. </para>        
				/// </summary>
				/// <java-name>
				/// SPAN_PRIORITY
				/// </java-name>
				[Dot42.DexImport("SPAN_PRIORITY", "I", AccessFlags = 25)]
				public const int SPAN_PRIORITY = 16711680;
		}

		/// <summary>
		///  <para>When an object of this type is attached to a Spannable, its methods will be called to notify it that other markup objects have been added, changed, or removed. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/SpanWatcher
		/// </java-name>
		[Dot42.DexImport("android/text/SpanWatcher", AccessFlags = 1537)]
		public partial interface ISpanWatcher : global::Android.Text.INoCopySpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method is called to notify you that the specified object has been attached to the specified range of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanAdded
				/// </java-name>
				[Dot42.DexImport("onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1025)]
				void OnSpanAdded(global::Android.Text.ISpannable text, object what, int start, int end) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method is called to notify you that the specified object has been detached from the specified range of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanRemoved
				/// </java-name>
				[Dot42.DexImport("onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1025)]
				void OnSpanRemoved(global::Android.Text.ISpannable text, object what, int start, int end) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method is called to notify you that the specified object has been relocated from the range  <code>ostart <hellip></hellip>oend</code> to the new range  <code>nstart <hellip></hellip>nend</code> of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanChanged
				/// </java-name>
				[Dot42.DexImport("onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V", AccessFlags = 1025)]
				void OnSpanChanged(global::Android.Text.ISpannable text, object what, int ostart, int oend, int nstart, int nend) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Interface for objects that use a heuristic for guessing at the paragraph direction by examining text. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/TextDirectionHeuristic
		/// </java-name>
		[Dot42.DexImport("android/text/TextDirectionHeuristic", AccessFlags = 1537)]
		public partial interface ITextDirectionHeuristic
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// isRtl
				/// </java-name>
				[Dot42.DexImport("isRtl", "([CII)Z", AccessFlags = 1025)]
				bool IsRtl(char[] @char, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isRtl
				/// </java-name>
				[Dot42.DexImport("isRtl", "(Ljava/lang/CharSequence;II)Z", AccessFlags = 1025)]
				bool IsRtl(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>When an object of a type is attached to an Editable, its methods will be called when the text is changed. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/TextWatcher
		/// </java-name>
		[Dot42.DexImport("android/text/TextWatcher", AccessFlags = 1537)]
		public partial interface ITextWatcher : global::Android.Text.INoCopySpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This method is called to notify you that, within  <code>s</code>, the  <code>count</code> characters beginning at  <code>start</code> are about to be replaced by new text with length  <code>after</code>. It is an error to attempt to make changes to  <code>s</code> from this callback. </para>        
				/// </summary>
				/// <java-name>
				/// beforeTextChanged
				/// </java-name>
				[Dot42.DexImport("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1025)]
				void BeforeTextChanged(global::Java.Lang.ICharSequence s, int start, int count, int after) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method is called to notify you that, within  <code>s</code>, the  <code>count</code> characters beginning at  <code>start</code> have just replaced old text that had length  <code>before</code>. It is an error to attempt to make changes to  <code>s</code> from this callback. </para>        
				/// </summary>
				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1025)]
				void OnTextChanged(global::Java.Lang.ICharSequence s, int start, int before, int count) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method is called to notify you that, somewhere within  <code>s</code>, the text has been changed. It is legitimate to make further changes to  <code>s</code> from this callback, but be careful not to get yourself into an infinite loop, because any changes you make will cause this method to be called again recursively. (You are not told where the change took place because other afterTextChanged() methods may already have made other changes and invalidated the offsets. But if you need to know here, you can use Spannable#setSpan in onTextChanged to mark your place and then look up from here where the span ended up. </para>        
				/// </summary>
				/// <java-name>
				/// afterTextChanged
				/// </java-name>
				[Dot42.DexImport("afterTextChanged", "(Landroid/text/Editable;)V", AccessFlags = 1025)]
				void AfterTextChanged(global::Android.Text.IEditable s) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>A base class that manages text layout in visual elements on the screen. </para> <para>For text that will be edited, use a DynamicLayout, which will be updated as the text changes. For text that will not change, use a StaticLayout. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Layout
		/// </java-name>
		[Dot42.DexImport("android/text/Layout", AccessFlags = 1057)]
		public abstract partial class Layout
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DIR_LEFT_TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("DIR_LEFT_TO_RIGHT", "I", AccessFlags = 25)]
				public const int DIR_LEFT_TO_RIGHT = 1;
				/// <java-name>
				/// DIR_RIGHT_TO_LEFT
				/// </java-name>
				[Dot42.DexImport("DIR_RIGHT_TO_LEFT", "I", AccessFlags = 25)]
				public const int DIR_RIGHT_TO_LEFT = -1;
				/// <summary>
				///  <para>Subclasses of Layout use this constructor to set the display text, width, and other standard properties. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FF)V", AccessFlags = 4)]
				protected internal Layout(global::Java.Lang.ICharSequence text, global::Android.Text.TextPaint paint, int width, global::Android.Text.Layout.Alignment align, float spacingMult, float spacingAdd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return how wide a layout must be in order to display the specified text with one line per paragraph. </para>        
				/// </summary>
				/// <java-name>
				/// getDesiredWidth
				/// </java-name>
				[Dot42.DexImport("getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F", AccessFlags = 9)]
				public static float GetDesiredWidth(global::Java.Lang.ICharSequence source, global::Android.Text.TextPaint paint) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Return how wide a layout must be in order to display the specified text slice with one line per paragraph. </para>        
				/// </summary>
				/// <java-name>
				/// getDesiredWidth
				/// </java-name>
				[Dot42.DexImport("getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F", AccessFlags = 9)]
				public static float GetDesiredWidth(global::Java.Lang.ICharSequence source, int start, int end, global::Android.Text.TextPaint paint) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Draw this Layout on the specified Canvas. </para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Draw this Layout on the specified canvas, with the highlight path drawn between the background and the text.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Path highlight, global::Android.Graphics.Paint highlightPaint, int cursorOffsetVertical) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Increase the width of this layout to the specified width. Be careful to use this only when you know it is appropriate it does not cause the text to reflow to use the full new width. </para>        
				/// </summary>
				/// <java-name>
				/// increaseWidthTo
				/// </java-name>
				[Dot42.DexImport("increaseWidthTo", "(I)V", AccessFlags = 17)]
				public void IncreaseWidthTo(int wid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the base alignment of this layout. </para>        
				/// </summary>
				/// <java-name>
				/// getAlignment
				/// </java-name>
				[Dot42.DexImport("getAlignment", "()Landroid/text/Layout$Alignment;", AccessFlags = 17)]
				public global::Android.Text.Layout.Alignment GetAlignment() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Alignment);
				}

				/// <summary>
				///  <para>Return the baseline for the specified line (0 <hellip></hellip>getLineCount() - 1) If bounds is not null, return the top, left, right, bottom extents of the specified line in it. </para>        
				/// </summary>
				/// <returns>
				///  <para>the Y-coordinate of the baseline </para>
				/// </returns>
				/// <java-name>
				/// getLineBounds
				/// </java-name>
				[Dot42.DexImport("getLineBounds", "(ILandroid/graphics/Rect;)I", AccessFlags = 1)]
				public virtual int GetLineBounds(int line, global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the vertical position of the top of the specified line (0 <hellip></hellip>getLineCount()). If the specified line is equal to the line count, returns the bottom of the last line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineTop
				/// </java-name>
				[Dot42.DexImport("getLineTop", "(I)I", AccessFlags = 1025)]
				public abstract int GetLineTop(int line) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the descent of the specified line(0 <hellip></hellip>getLineCount() - 1). </para>        
				/// </summary>
				/// <java-name>
				/// getLineDescent
				/// </java-name>
				[Dot42.DexImport("getLineDescent", "(I)I", AccessFlags = 1025)]
				public abstract int GetLineDescent(int line) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the text offset of the beginning of the specified line ( 0 <hellip></hellip>getLineCount()). If the specified line is equal to the line count, returns the length of the text. </para>        
				/// </summary>
				/// <java-name>
				/// getLineStart
				/// </java-name>
				[Dot42.DexImport("getLineStart", "(I)I", AccessFlags = 1025)]
				public abstract int GetLineStart(int line) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the primary directionality of the paragraph containing the specified line, either 1 for left-to-right lines, or -1 for right-to-left lines (see DIR_LEFT_TO_RIGHT, DIR_RIGHT_TO_LEFT). </para>        
				/// </summary>
				/// <java-name>
				/// getParagraphDirection
				/// </java-name>
				[Dot42.DexImport("getParagraphDirection", "(I)I", AccessFlags = 1025)]
				public abstract int GetParagraphDirection(int line) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns whether the specified line contains one or more characters that need to be handled specially, like tabs or emoji. </para>        
				/// </summary>
				/// <java-name>
				/// getLineContainsTab
				/// </java-name>
				[Dot42.DexImport("getLineContainsTab", "(I)Z", AccessFlags = 1025)]
				public abstract bool GetLineContainsTab(int line) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the directional run information for the specified line. The array alternates counts of characters in left-to-right and right-to-left segments of the line.</para> <para>NOTE: this is inadequate to support bidirectional text, and will change. </para>        
				/// </summary>
				/// <java-name>
				/// getLineDirections
				/// </java-name>
				[Dot42.DexImport("getLineDirections", "(I)Landroid/text/Layout$Directions;", AccessFlags = 1025)]
				public abstract global::Android.Text.Layout.Directions GetLineDirections(int line) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns true if the character at offset is right to left (RTL). </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the character is RTL, false if it is LTR </para>
				/// </returns>
				/// <java-name>
				/// isRtlCharAt
				/// </java-name>
				[Dot42.DexImport("isRtlCharAt", "(I)Z", AccessFlags = 1)]
				public virtual bool IsRtlCharAt(int offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get the primary horizontal position for the specified text offset. This is the location where a new character would be inserted in the paragraph's primary direction. </para>        
				/// </summary>
				/// <java-name>
				/// getPrimaryHorizontal
				/// </java-name>
				[Dot42.DexImport("getPrimaryHorizontal", "(I)F", AccessFlags = 1)]
				public virtual float GetPrimaryHorizontal(int offset) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Get the secondary horizontal position for the specified text offset. This is the location where a new character would be inserted in the direction other than the paragraph's primary direction. </para>        
				/// </summary>
				/// <java-name>
				/// getSecondaryHorizontal
				/// </java-name>
				[Dot42.DexImport("getSecondaryHorizontal", "(I)F", AccessFlags = 1)]
				public virtual float GetSecondaryHorizontal(int offset) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Get the leftmost position that should be exposed for horizontal scrolling on the specified line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineLeft
				/// </java-name>
				[Dot42.DexImport("getLineLeft", "(I)F", AccessFlags = 1)]
				public virtual float GetLineLeft(int line) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Get the rightmost position that should be exposed for horizontal scrolling on the specified line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineRight
				/// </java-name>
				[Dot42.DexImport("getLineRight", "(I)F", AccessFlags = 1)]
				public virtual float GetLineRight(int line) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Gets the unsigned horizontal extent of the specified line, including leading margin indent, but excluding trailing whitespace. </para>        
				/// </summary>
				/// <java-name>
				/// getLineMax
				/// </java-name>
				[Dot42.DexImport("getLineMax", "(I)F", AccessFlags = 1)]
				public virtual float GetLineMax(int line) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Gets the unsigned horizontal extent of the specified line, including leading margin indent and trailing whitespace. </para>        
				/// </summary>
				/// <java-name>
				/// getLineWidth
				/// </java-name>
				[Dot42.DexImport("getLineWidth", "(I)F", AccessFlags = 1)]
				public virtual float GetLineWidth(int line) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Get the line number corresponding to the specified vertical position. If you ask for a position above 0, you get 0; if you ask for a position below the bottom of the text, you get the last line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineForVertical
				/// </java-name>
				[Dot42.DexImport("getLineForVertical", "(I)I", AccessFlags = 1)]
				public virtual int GetLineForVertical(int vertical) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get the line number on which the specified text offset appears. If you ask for a position before 0, you get 0; if you ask for a position beyond the end of the text, you get the last line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineForOffset
				/// </java-name>
				[Dot42.DexImport("getLineForOffset", "(I)I", AccessFlags = 1)]
				public virtual int GetLineForOffset(int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get the character offset on the specified line whose position is closest to the specified horizontal position. </para>        
				/// </summary>
				/// <java-name>
				/// getOffsetForHorizontal
				/// </java-name>
				[Dot42.DexImport("getOffsetForHorizontal", "(IF)I", AccessFlags = 1)]
				public virtual int GetOffsetForHorizontal(int line, float horiz) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the text offset after the last character on the specified line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineEnd
				/// </java-name>
				[Dot42.DexImport("getLineEnd", "(I)I", AccessFlags = 17)]
				public int GetLineEnd(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the text offset after the last visible character (so whitespace is not counted) on the specified line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineVisibleEnd
				/// </java-name>
				[Dot42.DexImport("getLineVisibleEnd", "(I)I", AccessFlags = 1)]
				public virtual int GetLineVisibleEnd(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the vertical position of the bottom of the specified line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineBottom
				/// </java-name>
				[Dot42.DexImport("getLineBottom", "(I)I", AccessFlags = 17)]
				public int GetLineBottom(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the vertical position of the baseline of the specified line. </para>        
				/// </summary>
				/// <java-name>
				/// getLineBaseline
				/// </java-name>
				[Dot42.DexImport("getLineBaseline", "(I)I", AccessFlags = 17)]
				public int GetLineBaseline(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get the ascent of the text on the specified line. The return value is negative to match the Paint.ascent() convention. </para>        
				/// </summary>
				/// <java-name>
				/// getLineAscent
				/// </java-name>
				[Dot42.DexImport("getLineAscent", "(I)I", AccessFlags = 17)]
				public int GetLineAscent(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffsetToLeftOf
				/// </java-name>
				[Dot42.DexImport("getOffsetToLeftOf", "(I)I", AccessFlags = 1)]
				public virtual int GetOffsetToLeftOf(int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffsetToRightOf
				/// </java-name>
				[Dot42.DexImport("getOffsetToRightOf", "(I)I", AccessFlags = 1)]
				public virtual int GetOffsetToRightOf(int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Fills in the specified Path with a representation of a cursor at the specified offset. This will often be a vertical line but can be multiple discontinuous lines in text with multiple directionalities. </para>        
				/// </summary>
				/// <java-name>
				/// getCursorPath
				/// </java-name>
				[Dot42.DexImport("getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void GetCursorPath(int point, global::Android.Graphics.Path dest, global::Java.Lang.ICharSequence editingBuffer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Fills in the specified Path with a representation of a highlight between the specified offsets. This will often be a rectangle or a potentially discontinuous set of rectangles. If the start and end are the same, the returned path is empty. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectionPath
				/// </java-name>
				[Dot42.DexImport("getSelectionPath", "(IILandroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void GetSelectionPath(int start, int end, global::Android.Graphics.Path dest) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the alignment of the specified paragraph, taking into account markup attached to it. </para>        
				/// </summary>
				/// <java-name>
				/// getParagraphAlignment
				/// </java-name>
				[Dot42.DexImport("getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;", AccessFlags = 17)]
				public global::Android.Text.Layout.Alignment GetParagraphAlignment(int line) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Alignment);
				}

				/// <summary>
				///  <para>Get the left edge of the specified paragraph, inset by left margins. </para>        
				/// </summary>
				/// <java-name>
				/// getParagraphLeft
				/// </java-name>
				[Dot42.DexImport("getParagraphLeft", "(I)I", AccessFlags = 17)]
				public int GetParagraphLeft(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get the right edge of the specified paragraph, inset by right margins. </para>        
				/// </summary>
				/// <java-name>
				/// getParagraphRight
				/// </java-name>
				[Dot42.DexImport("getParagraphRight", "(I)I", AccessFlags = 17)]
				public int GetParagraphRight(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the offset of the first character to be ellipsized away, relative to the start of the line. (So 0 if the beginning of the line is ellipsized, not getLineStart().) </para>        
				/// </summary>
				/// <java-name>
				/// getEllipsisStart
				/// </java-name>
				[Dot42.DexImport("getEllipsisStart", "(I)I", AccessFlags = 1025)]
				public abstract int GetEllipsisStart(int line) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the number of characters to be ellipsized away, or 0 if no ellipsis is to take place. </para>        
				/// </summary>
				/// <java-name>
				/// getEllipsisCount
				/// </java-name>
				[Dot42.DexImport("getEllipsisCount", "(I)I", AccessFlags = 1025)]
				public abstract int GetEllipsisCount(int line) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Layout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the text that is displayed by this Layout. </para>        
				/// </summary>
				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Lang.ICharSequence Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 17)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <summary>
				///  <para>Return the base Paint properties for this layout. Do NOT change the paint, which may result in funny drawing for this layout. </para>        
				/// </summary>
				/// <java-name>
				/// getPaint
				/// </java-name>
				public global::Android.Text.TextPaint Paint
				{
						[Dot42.DexImport("getPaint", "()Landroid/text/TextPaint;", AccessFlags = 17)]
						get{ return default(global::Android.Text.TextPaint); }
				}

				/// <summary>
				///  <para>Return the width of this layout. </para>        
				/// </summary>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the width to which this Layout is ellipsizing, or getWidth if it is not doing anything special. </para>        
				/// </summary>
				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				public virtual int EllipsizedWidth
				{
						[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the total height of this layout. </para>        
				/// </summary>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return what the text height is multiplied by to get the line height. </para>        
				/// </summary>
				/// <java-name>
				/// getSpacingMultiplier
				/// </java-name>
				public float SpacingMultiplier
				{
						[Dot42.DexImport("getSpacingMultiplier", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the number of units of leading that are added to each line. </para>        
				/// </summary>
				/// <java-name>
				/// getSpacingAdd
				/// </java-name>
				public float SpacingAdd
				{
						[Dot42.DexImport("getSpacingAdd", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the number of lines of text in this layout. </para>        
				/// </summary>
				/// <java-name>
				/// getLineCount
				/// </java-name>
				public abstract int LineCount
				{
						[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the (negative) number of extra pixels of ascent padding in the top line of the Layout. </para>        
				/// </summary>
				/// <java-name>
				/// getTopPadding
				/// </java-name>
				public abstract int TopPadding
				{
						[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the number of extra pixels of descent padding in the bottom line of the Layout. </para>        
				/// </summary>
				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				public abstract int BottomPadding
				{
						[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isSpanned
				/// </java-name>
				protected internal bool IsSpanned
				{
						[Dot42.DexImport("isSpanned", "()Z", AccessFlags = 20)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/text/Layout$Alignment
				/// </java-name>
				[Dot42.DexImport("android/text/Layout$Alignment", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/text/Layout$Alignment;>;")]
				public sealed class Alignment
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ALIGN_CENTER
						/// </java-name>
						[Dot42.DexImport("ALIGN_CENTER", "Landroid/text/Layout$Alignment;", AccessFlags = 16409)]
						public static readonly Alignment ALIGN_CENTER;
						/// <java-name>
						/// ALIGN_NORMAL
						/// </java-name>
						[Dot42.DexImport("ALIGN_NORMAL", "Landroid/text/Layout$Alignment;", AccessFlags = 16409)]
						public static readonly Alignment ALIGN_NORMAL;
						/// <java-name>
						/// ALIGN_OPPOSITE
						/// </java-name>
						[Dot42.DexImport("ALIGN_OPPOSITE", "Landroid/text/Layout$Alignment;", AccessFlags = 16409)]
						public static readonly Alignment ALIGN_OPPOSITE;
						private Alignment() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/text/Layout$Alignment;", AccessFlags = 9)]
						public static Alignment[] Values() /* MethodBuilder.Create */ 
						{
								return default(Alignment[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/text/Layout$Alignment;", AccessFlags = 9)]
						public static Alignment ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Alignment);
						}

				}

				/// <summary>
				///  <para>Stores information about bidirectional (left-to-right or right-to-left) text within the layout of a line. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/Layout$Directions
				/// </java-name>
				[Dot42.DexImport("android/text/Layout$Directions", AccessFlags = 9)]
				public partial class Directions
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Directions() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Abstract class for filtering login-related text (user names and passwords) </para>    
		/// </summary>
		/// <java-name>
		/// android/text/LoginFilter
		/// </java-name>
		[Dot42.DexImport("android/text/LoginFilter", AccessFlags = 1057)]
		public abstract partial class LoginFilter : global::Android.Text.IInputFilter
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Default constructor for LoginFilter doesn't append invalid characters. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LoginFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method is called when the buffer is going to replace the range  <code>dstart  <hellip></hellip> dend</code> of  <code>dest</code> with the new text from the range  <code>start  <hellip></hellip> end</code> of  <code>source</code>. Returns the CharSequence that we want placed there instead, including an empty string if appropriate, or  <code>null</code> to accept the original replacement. Be careful to not to reject 0-length replacements, as this is what happens when you delete text. </para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence source, int start, int end, global::Android.Text.ISpanned dest, int dstart, int dend) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Called when we start processing filter. </para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called whenever we encounter an invalid character. </para>        
				/// </summary>
				/// <java-name>
				/// onInvalidCharacter
				/// </java-name>
				[Dot42.DexImport("onInvalidCharacter", "(C)V", AccessFlags = 1)]
				public virtual void OnInvalidCharacter(char c) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when we're done processing filter </para>        
				/// </summary>
				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1)]
				public virtual void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether or not we allow character c. Subclasses must override this method. </para>        
				/// </summary>
				/// <java-name>
				/// isAllowed
				/// </java-name>
				[Dot42.DexImport("isAllowed", "(C)Z", AccessFlags = 1025)]
				public abstract bool IsAllowed(char c) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This filter is compatible with GMail passwords which restricts characters to the Latin-1 (ISO8859-1) char set. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/LoginFilter$PasswordFilterGMail
				/// </java-name>
				[Dot42.DexImport("android/text/LoginFilter$PasswordFilterGMail", AccessFlags = 9)]
				public partial class PasswordFilterGMail : global::Android.Text.LoginFilter
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public PasswordFilterGMail() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
						public PasswordFilterGMail(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isAllowed
						/// </java-name>
						[Dot42.DexImport("isAllowed", "(C)Z", AccessFlags = 1)]
						public override bool IsAllowed(char c) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

				/// <summary>
				///  <para>This filter rejects characters in the user name that are not compatible with Google login. It is slightly less restrictive than the above filter in that it allows [a-zA-Z0-9._-+]. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/LoginFilter$UsernameFilterGeneric
				/// </java-name>
				[Dot42.DexImport("android/text/LoginFilter$UsernameFilterGeneric", AccessFlags = 9)]
				public partial class UsernameFilterGeneric : global::Android.Text.LoginFilter
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public UsernameFilterGeneric() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
						public UsernameFilterGeneric(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isAllowed
						/// </java-name>
						[Dot42.DexImport("isAllowed", "(C)Z", AccessFlags = 1)]
						public override bool IsAllowed(char c) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

				/// <summary>
				///  <para>This filter rejects characters in the user name that are not compatible with GMail account creation. It prevents the user from entering user names with characters other than [a-zA-Z0-9.]. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/LoginFilter$UsernameFilterGMail
				/// </java-name>
				[Dot42.DexImport("android/text/LoginFilter$UsernameFilterGMail", AccessFlags = 9)]
				public partial class UsernameFilterGMail : global::Android.Text.LoginFilter
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public UsernameFilterGMail() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
						public UsernameFilterGMail(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isAllowed
						/// </java-name>
						[Dot42.DexImport("isAllowed", "(C)Z", AccessFlags = 1)]
						public override bool IsAllowed(char c) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

		}

		/// <summary>
		///  <para>Utility class for manipulating cursors and selections in CharSequences. A cursor is a selection where the start and end are at the same offset. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/Selection
		/// </java-name>
		[Dot42.DexImport("android/text/Selection", AccessFlags = 33)]
		public partial class Selection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SELECTION_START
				/// </java-name>
				[Dot42.DexImport("SELECTION_START", "Ljava/lang/Object;", AccessFlags = 25)]
				public static readonly object SELECTION_START;
				/// <java-name>
				/// SELECTION_END
				/// </java-name>
				[Dot42.DexImport("SELECTION_END", "Ljava/lang/Object;", AccessFlags = 25)]
				public static readonly object SELECTION_END;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Selection() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the offset of the selection anchor or cursor, or -1 if there is no selection or cursor. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectionStart
				/// </java-name>
				[Dot42.DexImport("getSelectionStart", "(Ljava/lang/CharSequence;)I", AccessFlags = 25)]
				public static int GetSelectionStart(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the offset of the selection edge or cursor, or -1 if there is no selection or cursor. </para>        
				/// </summary>
				/// <java-name>
				/// getSelectionEnd
				/// </java-name>
				[Dot42.DexImport("getSelectionEnd", "(Ljava/lang/CharSequence;)I", AccessFlags = 25)]
				public static int GetSelectionEnd(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Set the selection anchor to  <code>start</code> and the selection edge to  <code>stop</code>. </para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(Landroid/text/Spannable;II)V", AccessFlags = 9)]
				public static void SetSelection(global::Android.Text.ISpannable text, int start, int stop) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the cursor to offset  <code>index</code>. </para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(Landroid/text/Spannable;I)V", AccessFlags = 25)]
				public static void SetSelection(global::Android.Text.ISpannable text, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Select the entire text. </para>        
				/// </summary>
				/// <java-name>
				/// selectAll
				/// </java-name>
				[Dot42.DexImport("selectAll", "(Landroid/text/Spannable;)V", AccessFlags = 25)]
				public static void SelectAll(global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the selection edge to offset  <code>index</code>. </para>        
				/// </summary>
				/// <java-name>
				/// extendSelection
				/// </java-name>
				[Dot42.DexImport("extendSelection", "(Landroid/text/Spannable;I)V", AccessFlags = 25)]
				public static void ExtendSelection(global::Android.Text.ISpannable text, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove the selection or cursor, if any, from the text. </para>        
				/// </summary>
				/// <java-name>
				/// removeSelection
				/// </java-name>
				[Dot42.DexImport("removeSelection", "(Landroid/text/Spannable;)V", AccessFlags = 25)]
				public static void RemoveSelection(global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the cursor to the buffer offset physically above the current offset, or return false if the cursor is already on the top line. </para>        
				/// </summary>
				/// <java-name>
				/// moveUp
				/// </java-name>
				[Dot42.DexImport("moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveUp(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the buffer offset physically below the current offset, or return false if the cursor is already on the bottom line. </para>        
				/// </summary>
				/// <java-name>
				/// moveDown
				/// </java-name>
				[Dot42.DexImport("moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveDown(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the buffer offset physically to the left of the current offset, or return false if the cursor is already at the left edge of the line and there is not another line to move it to. </para>        
				/// </summary>
				/// <java-name>
				/// moveLeft
				/// </java-name>
				[Dot42.DexImport("moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveLeft(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the cursor to the buffer offset physically to the right of the current offset, or return false if the cursor is already at at the right edge of the line and there is not another line to move it to. </para>        
				/// </summary>
				/// <java-name>
				/// moveRight
				/// </java-name>
				[Dot42.DexImport("moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveRight(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the selection end to the buffer offset physically above the current selection end. </para>        
				/// </summary>
				/// <java-name>
				/// extendUp
				/// </java-name>
				[Dot42.DexImport("extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendUp(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the selection end to the buffer offset physically below the current selection end. </para>        
				/// </summary>
				/// <java-name>
				/// extendDown
				/// </java-name>
				[Dot42.DexImport("extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendDown(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the selection end to the buffer offset physically to the left of the current selection end. </para>        
				/// </summary>
				/// <java-name>
				/// extendLeft
				/// </java-name>
				[Dot42.DexImport("extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendLeft(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Move the selection end to the buffer offset physically to the right of the current selection end. </para>        
				/// </summary>
				/// <java-name>
				/// extendRight
				/// </java-name>
				[Dot42.DexImport("extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendRight(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// extendToLeftEdge
				/// </java-name>
				[Dot42.DexImport("extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendToLeftEdge(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// extendToRightEdge
				/// </java-name>
				[Dot42.DexImport("extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendToRightEdge(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToLeftEdge
				/// </java-name>
				[Dot42.DexImport("moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveToLeftEdge(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToRightEdge
				/// </java-name>
				[Dot42.DexImport("moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveToRightEdge(global::Android.Text.ISpannable text, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		///  <para>This is the class for text whose content is immutable but to which markup objects can be attached and detached. For mutable text, see SpannableStringBuilder. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/SpannableString
		/// </java-name>
		[Dot42.DexImport("android/text/SpannableString", AccessFlags = 33)]
		public partial class SpannableString : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars, global::Android.Text.ISpannable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public SpannableString(global::Java.Lang.ICharSequence source) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableString;", AccessFlags = 9)]
				public static global::Android.Text.SpannableString ValueOf(global::Java.Lang.ICharSequence source) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableString);
				}

				/// <summary>
				///  <para>Attach the specified markup object to the range  <code>start <hellip></hellip>end</code> of the text, or move the object to that range if it was already attached elsewhere. See Spanned for an explanation of what the flags mean. The object can be one that has meaning only within your application, or it can be one that the text system will use to affect text display or behavior. Some noteworthy ones are the subclasses of android.text.style.CharacterStyle and android.text.style.ParagraphStyle, and android.text.TextWatcher and android.text.SpanWatcher. </para>        
				/// </summary>
				/// <java-name>
				/// setSpan
				/// </java-name>
				[Dot42.DexImport("setSpan", "(Ljava/lang/Object;III)V", AccessFlags = 1)]
				public virtual void SetSpan(object what, int start, int end, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove the specified object from the range of text to which it was attached, if any. It is OK to remove an object that was never attached in the first place. </para>        
				/// </summary>
				/// <java-name>
				/// removeSpan
				/// </java-name>
				[Dot42.DexImport("removeSpan", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void RemoveSpan(object what) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 17)]
				public global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 17)]
				public char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 17)]
				public void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanStart
				/// </java-name>
				[Dot42.DexImport("getSpanStart", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanStart(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpanEnd
				/// </java-name>
				[Dot42.DexImport("getSpanEnd", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanEnd(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpanFlags
				/// </java-name>
				[Dot42.DexImport("getSpanFlags", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanFlags(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpans
				/// </java-name>
				[Dot42.DexImport("getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(IILjava/lang/Class<TT;>;)[TT;")]
				public virtual T[] GetSpans<T>(int int32, int int321, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// nextSpanTransition
				/// </java-name>
				[Dot42.DexImport("nextSpanTransition", "(IILjava/lang/Class;)I", AccessFlags = 1)]
				public virtual int NextSpanTransition(int int32, int int321, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SpannableString() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>This is the class for text whose content and markup can both be changed. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/SpannableStringBuilder
		/// </java-name>
		[Dot42.DexImport("android/text/SpannableStringBuilder", AccessFlags = 33)]
		public partial class SpannableStringBuilder : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars, global::Android.Text.ISpannable, global::Android.Text.IEditable, global::Java.Lang.IAppendable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new SpannableStringBuilder with empty contents </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SpannableStringBuilder() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new SpannableStringBuilder containing a copy of the specified text, including its spans if any. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public SpannableStringBuilder(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new SpannableStringBuilder containing a copy of the specified slice of the specified text, including its spans if any. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;II)V", AccessFlags = 1)]
				public SpannableStringBuilder(global::Java.Lang.ICharSequence text, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", AccessFlags = 9)]
				public static global::Android.Text.SpannableStringBuilder ValueOf(global::Java.Lang.ICharSequence source) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <summary>
				///  <para>Return the char at the specified offset within the buffer. </para>        
				/// </summary>
				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public virtual char CharAt(int where) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Return the number of chars in the buffer. </para>        
				/// </summary>
				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Convenience for replace(where, where, text, start, end)  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Insert(int where, global::Java.Lang.ICharSequence text, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <summary>
				///  <para>Convenience for replace(where, where, text, 0, text.length());  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Insert(int where, global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <summary>
				///  <para>Convenience for replace(st, en, "", 0, 0)  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(II)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Delete(int st, int en) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <summary>
				///  <para>Convenience for replace(0, length(), "", 0, 0)  <para>replace(int, int, CharSequence, int, int) Note that this clears the text, not the spans; use clearSpans if you need that. </para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes all spans from the Editable, as if by calling removeSpan on each of them. </para>        
				/// </summary>
				/// <java-name>
				/// clearSpans
				/// </java-name>
				[Dot42.DexImport("clearSpans", "()V", AccessFlags = 1)]
				public virtual void ClearSpans() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <summary>
				///  <para>Convenience for replace(length(), length(), text, start, end)  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder JavaAppend(global::Java.Lang.ICharSequence text, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Append(char @char) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <summary>
				///  <para>Convenience for replace(st, en, text, 0, text.length())  <para>replace(int, int, CharSequence, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Replace(int st, int en, global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Replace(int start, int end, global::Java.Lang.ICharSequence tb, int tbstart, int tbend) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <summary>
				///  <para>Mark the specified range of text with the specified object. The flags determine how the span will behave when text is inserted at the start or end of the span's range. </para>        
				/// </summary>
				/// <java-name>
				/// setSpan
				/// </java-name>
				[Dot42.DexImport("setSpan", "(Ljava/lang/Object;III)V", AccessFlags = 1)]
				public virtual void SetSpan(object what, int start, int end, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeSpan
				/// </java-name>
				[Dot42.DexImport("removeSpan", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void RemoveSpan(object i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the buffer offset of the beginning of the specified markup object, or -1 if it is not attached to this buffer. </para>        
				/// </summary>
				/// <java-name>
				/// getSpanStart
				/// </java-name>
				[Dot42.DexImport("getSpanStart", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanStart(object what) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the buffer offset of the end of the specified markup object, or -1 if it is not attached to this buffer. </para>        
				/// </summary>
				/// <java-name>
				/// getSpanEnd
				/// </java-name>
				[Dot42.DexImport("getSpanEnd", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanEnd(object what) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the flags of the end of the specified markup object, or 0 if it is not attached to this buffer. </para>        
				/// </summary>
				/// <java-name>
				/// getSpanFlags
				/// </java-name>
				[Dot42.DexImport("getSpanFlags", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanFlags(object what) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return an array of the spans of the specified type that overlap the specified range of the buffer. The kind may be Object.class to get a list of all the spans regardless of type. </para>        
				/// </summary>
				/// <java-name>
				/// getSpans
				/// </java-name>
				[Dot42.DexImport("getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(IILjava/lang/Class<TT;>;)[TT;")]
				public virtual T[] GetSpans<T>(int queryStart, int queryEnd, global::System.Type kind) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <summary>
				///  <para>Return the next offset after  <code>start</code> but less than or equal to  <code>limit</code> where a span of the specified type begins or ends. </para>        
				/// </summary>
				/// <java-name>
				/// nextSpanTransition
				/// </java-name>
				[Dot42.DexImport("nextSpanTransition", "(IILjava/lang/Class;)I", AccessFlags = 1)]
				public virtual int NextSpanTransition(int start, int limit, global::System.Type kind) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return a new CharSequence containing a copy of the specified range of this buffer, including the overlapping spans. </para>        
				/// </summary>
				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Copy the specified range of chars from this buffer into the specified array, beginning at the specified offset. </para>        
				/// </summary>
				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public virtual void GetChars(int start, int end, char[] dest, int destoff) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a String containing a copy of the chars in this buffer. </para>        
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
				///  <para>Returns the next cursor position in the run. This avoids placing the cursor between surrogates, between characters that form conjuncts, between base characters and combining marks, or within a reordering cluster.</para> <para>The context is the shaping context for cursor movement, generally the bounds of the metric span enclosing the cursor in the direction of movement.  <code>contextStart</code>,  <code>contextEnd</code> and  <code>offset</code> are relative to the start of the string.</para> <para>If cursorOpt is CURSOR_AT and the offset is not a valid cursor position, this returns -1. Otherwise this will never return a value before contextStart or after contextEnd.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This is an internal method, refrain from using it in your code </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset of the next position, or -1 </para>
				/// </returns>
				/// <java-name>
				/// getTextRunCursor
				/// </java-name>
				[Dot42.DexImport("getTextRunCursor", "(IIIIILandroid/graphics/Paint;)I", AccessFlags = 1)]
				public virtual int GetTextRunCursor(int contextStart, int contextEnd, int flags, int offset, int cursorOpt, global::Android.Graphics.Paint p) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/text/Editable", "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Replace(int st, int en, global::Java.Lang.ICharSequence source, int start, int end) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Replace(int st, int en, global::Java.Lang.ICharSequence text) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Insert(int where, global::Java.Lang.ICharSequence text, int start, int end) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Insert(int where, global::Java.Lang.ICharSequence text) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "delete", "(II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Delete(int st, int en) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Append(global::Java.Lang.ICharSequence charSequence) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.JavaAppend(global::Java.Lang.ICharSequence text, int start, int end) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "append", "(C)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Append(char @char) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(char c) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence c) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.JavaAppend(global::Java.Lang.ICharSequence csq, int start, int end) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				/// <summary>
				///  <para>Returns the array of input filters that are currently applied to changes to this Editable. </para>        
				/// </summary>
				/// <java-name>
				/// getFilters
				/// </java-name>
				public virtual global::Android.Text.IInputFilter[] Filters
				{
						[Dot42.DexImport("getFilters", "()[Landroid/text/InputFilter;", AccessFlags = 1)]
						get{ return default(global::Android.Text.IInputFilter[]); }
						[Dot42.DexImport("setFilters", "([Landroid/text/InputFilter;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/text/SpannableStringInternal
		/// </java-name>
		[Dot42.DexImport("android/text/SpannableStringInternal", AccessFlags = 1056)]
		internal abstract partial class SpannableStringInternal
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SpannableStringInternal() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 17)]
				public char CharAt(int i) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 17)]
				public void GetChars(int start, int end, char[] dest, int off) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanStart
				/// </java-name>
				[Dot42.DexImport("getSpanStart", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanStart(object what) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpanEnd
				/// </java-name>
				[Dot42.DexImport("getSpanEnd", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanEnd(object what) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpanFlags
				/// </java-name>
				[Dot42.DexImport("getSpanFlags", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int GetSpanFlags(object what) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpans
				/// </java-name>
				[Dot42.DexImport("getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(IILjava/lang/Class<TT;>;)[TT;")]
				public virtual T[] GetSpans<T>(int queryStart, int queryEnd, global::System.Type kind) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// nextSpanTransition
				/// </java-name>
				[Dot42.DexImport("nextSpanTransition", "(IILjava/lang/Class;)I", AccessFlags = 1)]
				public virtual int NextSpanTransition(int start, int limit, global::System.Type kind) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>This is the class for text whose content and markup are immutable. For mutable markup, see SpannableString; for mutable text, see SpannableStringBuilder. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/SpannedString
		/// </java-name>
		[Dot42.DexImport("android/text/SpannedString", AccessFlags = 49)]
		public sealed partial class SpannedString : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars, global::Android.Text.ISpanned
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public SpannedString(global::Java.Lang.ICharSequence source) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence SubSequence(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannedString;", AccessFlags = 9)]
				public static global::Android.Text.SpannedString ValueOf(global::Java.Lang.ICharSequence source) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannedString);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 17)]
				public char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 17)]
				public void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanStart
				/// </java-name>
				[Dot42.DexImport("getSpanStart", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public int GetSpanStart(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpanEnd
				/// </java-name>
				[Dot42.DexImport("getSpanEnd", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public int GetSpanEnd(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpanFlags
				/// </java-name>
				[Dot42.DexImport("getSpanFlags", "(Ljava/lang/Object;)I", AccessFlags = 1)]
				public int GetSpanFlags(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSpans
				/// </java-name>
				[Dot42.DexImport("getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 1, Signature = "<T:Ljava/lang/Object;>(IILjava/lang/Class<TT;>;)[TT;")]
				public T[] GetSpans<T>(int int32, int int321, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(T[]);
				}

				/// <java-name>
				/// nextSpanTransition
				/// </java-name>
				[Dot42.DexImport("nextSpanTransition", "(IILjava/lang/Class;)I", AccessFlags = 1)]
				public int NextSpanTransition(int int32, int int321, global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SpannedString() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>StaticLayout is a Layout for text that will not be edited after it is laid out. Use DynamicLayout for text that may change. </para> <para>This is used by widgets to control text layout. You should not need to use this class directly unless you are implementing your own widget or custom display object, or would be tempted to call int, int, float, float, android.graphics.Paint) Canvas.drawText() directly.</para>    
		/// </summary>
		/// <java-name>
		/// android/text/StaticLayout
		/// </java-name>
		[Dot42.DexImport("android/text/StaticLayout", AccessFlags = 33)]
		public partial class StaticLayout : global::Android.Text.Layout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFZ)V", AccessFlags = 1)]
				public StaticLayout(global::Java.Lang.ICharSequence source, global::Android.Text.TextPaint paint, int width, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, bool includepad) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignmen" +
    "t;FFZ)V", AccessFlags = 1)]
				public StaticLayout(global::Java.Lang.ICharSequence source, int bufstart, int bufend, global::Android.Text.TextPaint paint, int outerwidth, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, bool includepad) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignmen" +
    "t;FFZLandroid/text/TextUtils$TruncateAt;I)V", AccessFlags = 1)]
				public StaticLayout(global::Java.Lang.ICharSequence source, int bufstart, int bufend, global::Android.Text.TextPaint paint, int outerwidth, global::Android.Text.Layout.Alignment align, float spacingmult, float spacingadd, bool includepad, global::Android.Text.TextUtils.TruncateAt ellipsize, int ellipsizedWidth) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLineForVertical
				/// </java-name>
				[Dot42.DexImport("getLineForVertical", "(I)I", AccessFlags = 1)]
				public override int GetLineForVertical(int vertical) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineTop
				/// </java-name>
				[Dot42.DexImport("getLineTop", "(I)I", AccessFlags = 1)]
				public override int GetLineTop(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineDescent
				/// </java-name>
				[Dot42.DexImport("getLineDescent", "(I)I", AccessFlags = 1)]
				public override int GetLineDescent(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineStart
				/// </java-name>
				[Dot42.DexImport("getLineStart", "(I)I", AccessFlags = 1)]
				public override int GetLineStart(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getParagraphDirection
				/// </java-name>
				[Dot42.DexImport("getParagraphDirection", "(I)I", AccessFlags = 1)]
				public override int GetParagraphDirection(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineContainsTab
				/// </java-name>
				[Dot42.DexImport("getLineContainsTab", "(I)Z", AccessFlags = 1)]
				public override bool GetLineContainsTab(int line) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLineDirections
				/// </java-name>
				[Dot42.DexImport("getLineDirections", "(I)Landroid/text/Layout$Directions;", AccessFlags = 17)]
				public override global::Android.Text.Layout.Directions GetLineDirections(int line) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Directions);
				}

				/// <java-name>
				/// getEllipsisCount
				/// </java-name>
				[Dot42.DexImport("getEllipsisCount", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisCount(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisStart
				/// </java-name>
				[Dot42.DexImport("getEllipsisStart", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisStart(int line) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StaticLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				public override int LineCount
				{
						[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				public override int TopPadding
				{
						[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				public override int BottomPadding
				{
						[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				public override int EllipsizedWidth
				{
						[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Some objects that implement TextDirectionHeuristic. Use these with the unicodeWrap() methods in BidiFormatter. Also notice that these direction heuristics correspond to the same types of constants provided in the android.view.View class for setTextDirection(), such as android.view.View#TEXT_DIRECTION_RTL. </para> <para>To support versions lower than android.os.Build.VERSION_CODES#JELLY_BEAN_MR2, you can use the support library's android.support.v4.text.TextDirectionHeuristicsCompat class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/TextDirectionHeuristics
		/// </java-name>
		[Dot42.DexImport("android/text/TextDirectionHeuristics", AccessFlags = 33)]
		public partial class TextDirectionHeuristics
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Always decides that the direction is left to right. </para>        
				/// </summary>
				/// <java-name>
				/// LTR
				/// </java-name>
				[Dot42.DexImport("LTR", "Landroid/text/TextDirectionHeuristic;", AccessFlags = 25)]
				public static readonly global::Android.Text.ITextDirectionHeuristic LTR;
				/// <summary>
				///  <para>Always decides that the direction is right to left. </para>        
				/// </summary>
				/// <java-name>
				/// RTL
				/// </java-name>
				[Dot42.DexImport("RTL", "Landroid/text/TextDirectionHeuristic;", AccessFlags = 25)]
				public static readonly global::Android.Text.ITextDirectionHeuristic RTL;
				/// <summary>
				///  <para>Determines the direction based on the first strong directional character, including bidi format chars, falling back to left to right if it finds none. This is the default behavior of the Unicode Bidirectional Algorithm. </para>        
				/// </summary>
				/// <java-name>
				/// FIRSTSTRONG_LTR
				/// </java-name>
				[Dot42.DexImport("FIRSTSTRONG_LTR", "Landroid/text/TextDirectionHeuristic;", AccessFlags = 25)]
				public static readonly global::Android.Text.ITextDirectionHeuristic FIRSTSTRONG_LTR;
				/// <summary>
				///  <para>Determines the direction based on the first strong directional character, including bidi format chars, falling back to right to left if it finds none. This is similar to the default behavior of the Unicode Bidirectional Algorithm, just with different fallback behavior. </para>        
				/// </summary>
				/// <java-name>
				/// FIRSTSTRONG_RTL
				/// </java-name>
				[Dot42.DexImport("FIRSTSTRONG_RTL", "Landroid/text/TextDirectionHeuristic;", AccessFlags = 25)]
				public static readonly global::Android.Text.ITextDirectionHeuristic FIRSTSTRONG_RTL;
				/// <summary>
				///  <para>If the text contains any strong right to left non-format character, determines that the direction is right to left, falling back to left to right if it finds none. </para>        
				/// </summary>
				/// <java-name>
				/// ANYRTL_LTR
				/// </java-name>
				[Dot42.DexImport("ANYRTL_LTR", "Landroid/text/TextDirectionHeuristic;", AccessFlags = 25)]
				public static readonly global::Android.Text.ITextDirectionHeuristic ANYRTL_LTR;
				/// <summary>
				///  <para>Force the paragraph direction to the Locale direction. Falls back to left to right. </para>        
				/// </summary>
				/// <java-name>
				/// LOCALE
				/// </java-name>
				[Dot42.DexImport("LOCALE", "Landroid/text/TextDirectionHeuristic;", AccessFlags = 25)]
				public static readonly global::Android.Text.ITextDirectionHeuristic LOCALE;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TextDirectionHeuristics() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>TextPaint is an extension of Paint that leaves room for some extra data used during text measuring and drawing. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/TextPaint
		/// </java-name>
		[Dot42.DexImport("android/text/TextPaint", AccessFlags = 33)]
		public partial class TextPaint : global::Android.Graphics.Paint
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// bgColor
				/// </java-name>
				[Dot42.DexImport("bgColor", "I", AccessFlags = 1)]
				public int BgColor;
				/// <java-name>
				/// baselineShift
				/// </java-name>
				[Dot42.DexImport("baselineShift", "I", AccessFlags = 1)]
				public int BaselineShift;
				/// <java-name>
				/// linkColor
				/// </java-name>
				[Dot42.DexImport("linkColor", "I", AccessFlags = 1)]
				public int LinkColor;
				/// <java-name>
				/// drawableState
				/// </java-name>
				[Dot42.DexImport("drawableState", "[I", AccessFlags = 1)]
				public int[] DrawableState;
				/// <java-name>
				/// density
				/// </java-name>
				[Dot42.DexImport("density", "F", AccessFlags = 1)]
				public float Density;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TextPaint() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public TextPaint(int flags) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public TextPaint(global::Android.Graphics.Paint flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy the fields from tp into this TextPaint, including the fields inherited from Paint. </para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Text.TextPaint tp) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/text/TextUtils
		/// </java-name>
		[Dot42.DexImport("android/text/TextUtils", AccessFlags = 33)]
		public partial class TextUtils
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CHAR_SEQUENCE_CREATOR
				/// </java-name>
				[Dot42.DexImport("CHAR_SEQUENCE_CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Java.Lang.ICharSequence> CHAR_SEQUENCE_CREATOR;
				/// <summary>
				///  <para>Capitalization mode for getCapsMode: capitalize all characters. This value is explicitly defined to be the same as InputType#TYPE_TEXT_FLAG_CAP_CHARACTERS. </para>        
				/// </summary>
				/// <java-name>
				/// CAP_MODE_CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CAP_MODE_CHARACTERS", "I", AccessFlags = 25)]
				public const int CAP_MODE_CHARACTERS = 4096;
				/// <summary>
				///  <para>Capitalization mode for getCapsMode: capitalize the first character of all words. This value is explicitly defined to be the same as InputType#TYPE_TEXT_FLAG_CAP_WORDS. </para>        
				/// </summary>
				/// <java-name>
				/// CAP_MODE_WORDS
				/// </java-name>
				[Dot42.DexImport("CAP_MODE_WORDS", "I", AccessFlags = 25)]
				public const int CAP_MODE_WORDS = 8192;
				/// <summary>
				///  <para>Capitalization mode for getCapsMode: capitalize the first character of each sentence. This value is explicitly defined to be the same as InputType#TYPE_TEXT_FLAG_CAP_SENTENCES. </para>        
				/// </summary>
				/// <java-name>
				/// CAP_MODE_SENTENCES
				/// </java-name>
				[Dot42.DexImport("CAP_MODE_SENTENCES", "I", AccessFlags = 25)]
				public const int CAP_MODE_SENTENCES = 16384;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TextUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(Ljava/lang/CharSequence;II[CI)V", AccessFlags = 9)]
				public static void GetChars(global::Java.Lang.ICharSequence s, int start, int end, char[] dest, int destoff) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/CharSequence;C)I", AccessFlags = 9)]
				public static int IndexOf(global::Java.Lang.ICharSequence charSequence, char @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/CharSequence;CI)I", AccessFlags = 9)]
				public static int IndexOf(global::Java.Lang.ICharSequence charSequence, char @char, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/CharSequence;CII)I", AccessFlags = 9)]
				public static int IndexOf(global::Java.Lang.ICharSequence charSequence, char @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/CharSequence;C)I", AccessFlags = 9)]
				public static int LastIndexOf(global::Java.Lang.ICharSequence s, char ch) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/CharSequence;CI)I", AccessFlags = 9)]
				public static int LastIndexOf(global::Java.Lang.ICharSequence s, char ch, int last) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/CharSequence;CII)I", AccessFlags = 9)]
				public static int LastIndexOf(global::Java.Lang.ICharSequence s, char ch, int start, int last) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", AccessFlags = 9)]
				public static int IndexOf(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int IndexOf(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;II)I", AccessFlags = 9)]
				public static int IndexOf(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// regionMatches
				/// </java-name>
				[Dot42.DexImport("regionMatches", "(Ljava/lang/CharSequence;ILjava/lang/CharSequence;II)Z", AccessFlags = 9)]
				public static bool RegionMatches(global::Java.Lang.ICharSequence one, int toffset, global::Java.Lang.ICharSequence two, int ooffset, int len) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Create a new String object containing the given range of characters from the source string. This is different than simply calling CharSequence.subSequence in that it does not preserve any style runs in the source sequence, allowing a more efficient implementation. </para>        
				/// </summary>
				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(Ljava/lang/CharSequence;II)Ljava/lang/String;", AccessFlags = 9)]
				public static string Substring(global::Java.Lang.ICharSequence source, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(Ljava/lang/CharSequence;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Join(global::Java.Lang.ICharSequence charSequence, object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// join
				/// </java-name>
				[Dot42.DexImport("join", "(Ljava/lang/CharSequence;Ljava/lang/Iterable;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Join(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.IIterable<object> iterable) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] Split(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/String;Ljava/util/regex/Pattern;)[Ljava/lang/String;", AccessFlags = 9)]
				public static string[] Split(string @string, global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// stringOrSpannedString
				/// </java-name>
				[Dot42.DexImport("stringOrSpannedString", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence StringOrSpannedString(global::Java.Lang.ICharSequence source) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Returns true if the string is null or 0-length. </para>        
				/// </summary>
				/// <returns>
				///  <para>true if str is null or zero length </para>
				/// </returns>
				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "(Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool IsEmpty(global::Java.Lang.ICharSequence str) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the length that the specified CharSequence would have if spaces and control characters were trimmed from the start and end, as by String#trim. </para>        
				/// </summary>
				/// <java-name>
				/// getTrimmedLength
				/// </java-name>
				[Dot42.DexImport("getTrimmedLength", "(Ljava/lang/CharSequence;)I", AccessFlags = 9)]
				public static int GetTrimmedLength(global::Java.Lang.ICharSequence s) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns true if a and b are equal, including if they are both null. </para> <para> <b>Note: In platform versions 1.1 and earlier, this method only worked well if both the arguments were instances of String.</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if a and b are equal </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool Equals(global::Java.Lang.ICharSequence a, global::Java.Lang.ICharSequence b) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getReverse
				/// </java-name>
				[Dot42.DexImport("getReverse", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetReverse(global::Java.Lang.ICharSequence source, int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Flatten a CharSequence and whatever styles can be copied across processes into the parcel. </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Ljava/lang/CharSequence;Landroid/os/Parcel;I)V", AccessFlags = 9)]
				public static void WriteToParcel(global::Java.Lang.ICharSequence cs, global::Android.OS.Parcel p, int parcelableFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Debugging tool to print the spans in a CharSequence. The output will be printed one span per line. If the CharSequence is not a Spanned, then the entire string will be printed on a single line. </para>        
				/// </summary>
				/// <java-name>
				/// dumpSpans
				/// </java-name>
				[Dot42.DexImport("dumpSpans", "(Ljava/lang/CharSequence;Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void DumpSpans(global::Java.Lang.ICharSequence cs, global::Android.Util.IPrinter printer, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return a new CharSequence in which each of the source strings is replaced by the corresponding element of the destinations. </para>        
				/// </summary>
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/CharSequence;[Ljava/lang/String;[Ljava/lang/CharSequence;)Ljava/lang/" +
    "CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Replace(global::Java.Lang.ICharSequence template, string[] sources, global::Java.Lang.ICharSequence[] destinations) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Replace instances of "^1", "^2", etc. in the  <code>template</code> CharSequence with the corresponding  <code>values</code>. "^^" is used to produce a single caret in the output. Only up to 9 replacement values are supported, "^10" will be produce the first replacement value followed by a '0'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new CharSequence produced by doing the replacement</para>
				/// </returns>
				/// <java-name>
				/// expandTemplate
				/// </java-name>
				[Dot42.DexImport("expandTemplate", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 137)]
				public static global::Java.Lang.ICharSequence ExpandTemplate(global::Java.Lang.ICharSequence template, params global::Java.Lang.ICharSequence[] values) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getOffsetBefore
				/// </java-name>
				[Dot42.DexImport("getOffsetBefore", "(Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int GetOffsetBefore(global::Java.Lang.ICharSequence text, int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffsetAfter
				/// </java-name>
				[Dot42.DexImport("getOffsetAfter", "(Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int GetOffsetAfter(global::Java.Lang.ICharSequence text, int offset) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Copies the spans from the region  <code>start...end</code> in  <code>source</code> to the region  <code>destoff...destoff+end-start</code> in  <code>dest</code>. Spans in  <code>source</code> that begin before  <code>start</code> or end after  <code>end</code> but overlap this range are trimmed as if they began at  <code>start</code> or ended at  <code>end</code>.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// copySpansFrom
				/// </java-name>
				[Dot42.DexImport("copySpansFrom", "(Landroid/text/Spanned;IILjava/lang/Class;Landroid/text/Spannable;I)V", AccessFlags = 9)]
				public static void CopySpansFrom(global::Android.Text.ISpanned source, int start, int end, global::System.Type kind, global::Android.Text.ISpannable dest, int destoff) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the original text if it fits in the specified width given the properties of the specified Paint, or, if it does not fit, a truncated copy with ellipsis character added at the specified edge or center. </para>        
				/// </summary>
				/// <java-name>
				/// ellipsize
				/// </java-name>
				[Dot42.DexImport("ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$Truncat" +
    "eAt;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Ellipsize(global::Java.Lang.ICharSequence text, global::Android.Text.TextPaint p, float avail, global::Android.Text.TextUtils.TruncateAt where) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Returns the original text if it fits in the specified width given the properties of the specified Paint, or, if it does not fit, a copy with ellipsis character added at the specified edge or center. If  <code>preserveLength</code> is specified, the returned copy will be padded with zero-width spaces to preserve the original length and offsets instead of truncating. If  <code>callback</code> is non-null, it will be called to report the start and end of the ellipsized range. TextDirection is determined by the first strong directional character. </para>        
				/// </summary>
				/// <java-name>
				/// ellipsize
				/// </java-name>
				[Dot42.DexImport("ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$Truncat" +
    "eAt;ZLandroid/text/TextUtils$EllipsizeCallback;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Ellipsize(global::Java.Lang.ICharSequence text, global::Android.Text.TextPaint paint, float avail, global::Android.Text.TextUtils.TruncateAt where, bool preserveLength, global::Android.Text.TextUtils.IEllipsizeCallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Converts a CharSequence of the comma-separated form "Andy, Bob,Charles, David" that is too wide to fit into the specified width into one like "Andy, Bob, 2 more".</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// commaEllipsize
				/// </java-name>
				[Dot42.DexImport("commaEllipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLjava/lang/String;Ljava/lang/St" +
    "ring;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence CommaEllipsize(global::Java.Lang.ICharSequence text, global::Android.Text.TextPaint p, float avail, string oneMore, string more) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				///  <para>Html-encode the string. </para>        
				/// </summary>
				/// <returns>
				///  <para>the encoded string </para>
				/// </returns>
				/// <java-name>
				/// htmlEncode
				/// </java-name>
				[Dot42.DexImport("htmlEncode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string HtmlEncode(string s) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a CharSequence concatenating the specified CharSequences, retaining their spans if any. </para>        
				/// </summary>
				/// <java-name>
				/// concat
				/// </java-name>
				[Dot42.DexImport("concat", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 137)]
				public static global::Java.Lang.ICharSequence Concat(params global::Java.Lang.ICharSequence[] text) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// isGraphic
				/// </java-name>
				[Dot42.DexImport("isGraphic", "(Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool IsGraphic(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isGraphic
				/// </java-name>
				[Dot42.DexImport("isGraphic", "(C)Z", AccessFlags = 9)]
				public static bool IsGraphic(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns whether the given CharSequence contains only digits. </para>        
				/// </summary>
				/// <java-name>
				/// isDigitsOnly
				/// </java-name>
				[Dot42.DexImport("isDigitsOnly", "(Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool IsDigitsOnly(global::Java.Lang.ICharSequence str) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Determine what caps mode should be in effect at the current offset in the text. Only the mode bits set in  <b>reqModes</b> will be checked. Note that the caps mode flags here are explicitly defined to match those in InputType.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the actual capitalization modes that can be in effect at the current position, which is any combination of CAP_MODE_CHARACTERS, CAP_MODE_WORDS, and CAP_MODE_SENTENCES. </para>
				/// </returns>
				/// <java-name>
				/// getCapsMode
				/// </java-name>
				[Dot42.DexImport("getCapsMode", "(Ljava/lang/CharSequence;II)I", AccessFlags = 9)]
				public static int GetCapsMode(global::Java.Lang.ICharSequence cs, int off, int reqModes) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the layout direction for a given Locale</para> <para>Be careful: this code will need to be updated when vertical scripts will be supported </para>        
				/// </summary>
				/// <returns>
				///  <para>the layout direction. This may be one of: android.view.View#LAYOUT_DIRECTION_LTR or android.view.View#LAYOUT_DIRECTION_RTL.</para>
				/// </returns>
				/// <java-name>
				/// getLayoutDirectionFromLocale
				/// </java-name>
				[Dot42.DexImport("getLayoutDirectionFromLocale", "(Ljava/util/Locale;)I", AccessFlags = 9)]
				public static int GetLayoutDirectionFromLocale(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// android/text/TextUtils$EllipsizeCallback
				/// </java-name>
				[Dot42.DexImport("android/text/TextUtils$EllipsizeCallback", AccessFlags = 1545)]
				public partial interface IEllipsizeCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>This method is called to report that the specified region of text was ellipsized away by a call to ellipsize. </para>        
						/// </summary>
						/// <java-name>
						/// ellipsized
						/// </java-name>
						[Dot42.DexImport("ellipsized", "(II)V", AccessFlags = 1025)]
						void Ellipsized(int start, int end) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/text/TextUtils$TruncateAt
				/// </java-name>
				[Dot42.DexImport("android/text/TextUtils$TruncateAt", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/text/TextUtils$TruncateAt;>;")]
				public sealed class TruncateAt
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// END
						/// </java-name>
						[Dot42.DexImport("END", "Landroid/text/TextUtils$TruncateAt;", AccessFlags = 16409)]
						public static readonly TruncateAt END;
						/// <java-name>
						/// MARQUEE
						/// </java-name>
						[Dot42.DexImport("MARQUEE", "Landroid/text/TextUtils$TruncateAt;", AccessFlags = 16409)]
						public static readonly TruncateAt MARQUEE;
						/// <java-name>
						/// MIDDLE
						/// </java-name>
						[Dot42.DexImport("MIDDLE", "Landroid/text/TextUtils$TruncateAt;", AccessFlags = 16409)]
						public static readonly TruncateAt MIDDLE;
						/// <java-name>
						/// START
						/// </java-name>
						[Dot42.DexImport("START", "Landroid/text/TextUtils$TruncateAt;", AccessFlags = 16409)]
						public static readonly TruncateAt START;
						private TruncateAt() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/text/TextUtils$TruncateAt;", AccessFlags = 9)]
						public static TruncateAt[] Values() /* MethodBuilder.Create */ 
						{
								return default(TruncateAt[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/text/TextUtils$TruncateAt;", AccessFlags = 9)]
						public static TruncateAt ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(TruncateAt);
						}

				}

				/// <summary>
				///  <para>A simple string splitter.</para> <para>If the final character in the string to split is the delimiter then no empty string will be returned for the empty string after that delimeter. That is, splitting  <code>"a,b,"</code> on comma will return  <code>"a", "b"</code>, not  <code>"a", "b", ""</code>. </para>    
				/// </summary>
				/// <java-name>
				/// android/text/TextUtils$SimpleStringSplitter
				/// </java-name>
				[Dot42.DexImport("android/text/TextUtils$SimpleStringSplitter", AccessFlags = 9, Signature = "Ljava/lang/Object;Landroid/text/TextUtils$StringSplitter;Ljava/util/Iterator<Ljav" +
    "a/lang/String;>;")]
				public partial class SimpleStringSplitter : global::Android.Text.TextUtils.IStringSplitter, global::Java.Util.IIterator<string>
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(C)V", AccessFlags = 1)]
						public SimpleStringSplitter(char @char) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Sets the string to split </para>        
						/// </summary>
						/// <java-name>
						/// setString
						/// </java-name>
						[Dot42.DexImport("setString", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public virtual void SetString(string @string) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// iterator
						/// </java-name>
						[Dot42.DexImport("iterator", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						public virtual global::Java.Util.IIterator<string> Iterator() /* MethodBuilder.Create */ 
						{
								return default(global::Java.Util.IIterator<string>);
						}

						/// <summary>
						///  <para>Returns the next object and advances the iterator.</para> <para> <para>hasNext </para></para>        
						/// </summary>
						/// <returns>
						///  <para>the next object. </para>
						/// </returns>
						/// <java-name>
						/// next
						/// </java-name>
						[Dot42.DexImport("next", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Next() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <summary>
						///  <para>Removes the last object returned by <c>next </c> from the collection. This method can only be called once between each call to <c>next </c> .</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// remove
						/// </java-name>
						[Dot42.DexImport("remove", "()V", AccessFlags = 1)]
						public virtual void Remove() /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal SimpleStringSplitter() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <summary>
						///  <para>Returns true if there is at least one more element, false otherwise.  <para>next </para></para>        
						/// </summary>
						/// <java-name>
						/// hasNext
						/// </java-name>
						public virtual bool HasNext
						{
								[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
								get{ return default(bool); }
						}

				}

				/// <summary>
				///  <para>An interface for splitting strings according to rules that are opaque to the user of this interface. This also has less overhead than split, which uses regular expressions and allocates an array to hold the results.</para> <para>The most efficient way to use this class is:</para> <para> <pre>
				/// // Once
				/// TextUtils.StringSplitter splitter = new TextUtils.SimpleStringSplitter(delimiter);</pre></para> <para> <pre>// Once per string to split
				/// splitter.setString(string);
				/// for (String s : splitter) {
				///     ...
				/// }
				/// </pre> </para>    
				/// </summary>
				/// <java-name>
				/// android/text/TextUtils$StringSplitter
				/// </java-name>
				[Dot42.DexImport("android/text/TextUtils$StringSplitter", AccessFlags = 1545, Signature = "Ljava/lang/Object;Ljava/lang/Iterable<Ljava/lang/String;>;")]
				public partial interface IStringSplitter : global::Java.Lang.IIterable<string>
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// setString
						/// </java-name>
						[Dot42.DexImport("setString", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						void SetString(string @string) /* MethodBuilder.Create */ ;

				}

		}

}

