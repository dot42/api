#pragma warning disable 1717
namespace Java.Util.Regex
{
		/// <summary>
		///  <para>Holds the results of a successful match of a Pattern against a given string. The result is divided into groups, with one group for each pair of parentheses in the regular expression and an additional group for the whole regular expression. The start, end, and contents of each group can be queried.</para> <para> <para>Matcher </para> <para>Matcher::toMatchResult() </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/regex/MatchResult
		/// </java-name>
		[Dot42.DexImport("java/util/regex/MatchResult", AccessFlags = 1537)]
		public partial interface IMatchResult
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the index of the first character following the text that matched the whole regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character index. </para>
				/// </returns>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()I", AccessFlags = 1025)]
				int End() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the index of the first character following the text that matched a given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character index. </para>
				/// </returns>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(I)I", AccessFlags = 1025)]
				int End(int group) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the text that matched the whole regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the text. </para>
				/// </returns>
				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "()Ljava/lang/String;", AccessFlags = 1025)]
				string Group() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the text that matched a given group of the regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the text that matched the group. </para>
				/// </returns>
				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string Group(int group) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the number of groups in the result, which is always equal to the number of groups in the original regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of groups. </para>
				/// </returns>
				/// <java-name>
				/// groupCount
				/// </java-name>
				[Dot42.DexImport("groupCount", "()I", AccessFlags = 1025)]
				int GroupCount() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the index of the first character of the text that matched the whole regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character index. </para>
				/// </returns>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()I", AccessFlags = 1025)]
				int Start() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the index of the first character of the text that matched a given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character index. </para>
				/// </returns>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(I)I", AccessFlags = 1025)]
				int Start(int group) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>The result of applying a <c>Pattern </c> to a given input. See Pattern for example uses. </para>    
		/// </summary>
		/// <java-name>
		/// java/util/regex/Matcher
		/// </java-name>
		[Dot42.DexImport("java/util/regex/Matcher", AccessFlags = 49)]
		public sealed partial class Matcher : global::Java.Util.Regex.IMatchResult
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Matcher() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Resets the <c>Matcher </c> . This results in the region being set to the whole input. Results of a previous find get lost. The next attempt to find an occurrence of the Pattern in the string will start at the beginning of the input.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Matcher </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <summary>
				///  <para>Provides a new input and resets the <c>Matcher </c> . This results in the region being set to the whole input. Results of a previous find get lost. The next attempt to find an occurrence of the Pattern in the string will start at the beginning of the input.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Matcher </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher Reset(global::Java.Lang.ICharSequence input) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <summary>
				///  <para>Sets a new pattern for the <c>Matcher </c> . Results of a previous find get lost. The next attempt to find an occurrence of the Pattern in the string will start at the beginning of the input.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Matcher </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// usePattern
				/// </java-name>
				[Dot42.DexImport("usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher UsePattern(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <summary>
				///  <para>Returns the Pattern instance used inside this matcher.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Pattern </c> instance. </para>
				/// </returns>
				/// <java-name>
				/// pattern
				/// </java-name>
				[Dot42.DexImport("pattern", "()Ljava/util/regex/Pattern;", AccessFlags = 1)]
				public global::Java.Util.Regex.Pattern Pattern() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Pattern);
				}

				/// <summary>
				///  <para>Returns the number of groups in the results, which is always equal to the number of groups in the original regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the number of groups. </para>
				/// </returns>
				/// <java-name>
				/// groupCount
				/// </java-name>
				[Dot42.DexImport("groupCount", "()I", AccessFlags = 1)]
				public int GroupCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Resets this matcher and sets a region. Only characters inside the region are considered for a match.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Matcher </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// region
				/// </java-name>
				[Dot42.DexImport("region", "(II)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher Region(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <summary>
				///  <para>Returns this matcher's region start, that is, the index of the first character that is considered for a match. </para>        
				/// </summary>
				/// <java-name>
				/// regionStart
				/// </java-name>
				[Dot42.DexImport("regionStart", "()I", AccessFlags = 1)]
				public int RegionStart() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns this matcher's region end, that is, the index of the first character that is not considered for a match. </para>        
				/// </summary>
				/// <java-name>
				/// regionEnd
				/// </java-name>
				[Dot42.DexImport("regionEnd", "()I", AccessFlags = 1)]
				public int RegionEnd() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Determines whether this matcher has anchoring bounds enabled or not. When anchoring bounds are enabled, the start and end of the input match the '^' and '$' meta-characters, otherwise not. Anchoring bounds are enabled by default.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Matcher </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// useAnchoringBounds
				/// </java-name>
				[Dot42.DexImport("useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher UseAnchoringBounds(bool value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <summary>
				///  <para>Determines whether this matcher has transparent bounds enabled or not. When transparent bounds are enabled, the parts of the input outside the region are subject to lookahead and lookbehind, otherwise they are not. Transparent bounds are disabled by default.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Matcher </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// useTransparentBounds
				/// </java-name>
				[Dot42.DexImport("useTransparentBounds", "(Z)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher UseTransparentBounds(bool value) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <summary>
				///  <para>Returns the next occurrence of the Pattern in the input. If a previous match was successful, the method continues the search from the first character following that match in the input. Otherwise it searches either from the region start (if one has been set), or from position 0.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if (and only if) a match has been found. </para>
				/// </returns>
				/// <java-name>
				/// find
				/// </java-name>
				[Dot42.DexImport("find", "()Z", AccessFlags = 1)]
				public bool Find() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if there is another match in the input, starting from the given position. The region is ignored.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// find
				/// </java-name>
				[Dot42.DexImport("find", "(I)Z", AccessFlags = 1)]
				public bool Find(int start) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Tries to match the Pattern against the entire region (or the entire input, if no region has been set).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if (and only if) the <c>Pattern </c> matches the entire region. </para>
				/// </returns>
				/// <java-name>
				/// matches
				/// </java-name>
				[Dot42.DexImport("matches", "()Z", AccessFlags = 1)]
				public bool Matches() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Tries to match the Pattern, starting from the beginning of the region (or the beginning of the input, if no region has been set). Doesn't require the <c>Pattern </c> to match against the whole region.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if (and only if) the <c>Pattern </c> matches. </para>
				/// </returns>
				/// <java-name>
				/// lookingAt
				/// </java-name>
				[Dot42.DexImport("lookingAt", "()Z", AccessFlags = 1)]
				public bool LookingAt() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns the index of the first character of the text that matched the whole regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character index. </para>
				/// </returns>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()I", AccessFlags = 1)]
				public int Start() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the index of the first character of the text that matched a given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character index. </para>
				/// </returns>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(I)I", AccessFlags = 1)]
				public int Start(int group) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the index of the first character following the text that matched the whole regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character index. </para>
				/// </returns>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()I", AccessFlags = 1)]
				public int End() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the index of the first character following the text that matched a given group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the character index. </para>
				/// </returns>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(I)I", AccessFlags = 1)]
				public int End(int group) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the text that matched the whole regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the text. </para>
				/// </returns>
				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "()Ljava/lang/String;", AccessFlags = 1)]
				public string Group() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the text that matched a given group of the regular expression. Explicit capturing groups in the pattern are numbered left to right in order of their  <b>opening</b> parenthesis, starting at 1. The special group 0 represents the entire match (as if the entire pattern is surrounded by an implicit capturing group). For example, "a((b)c)" matching "abc" would give the following groups:  <pre>
				/// 0 "abc"
				/// 1 "bc"
				/// 2 "b"
				/// </pre></para> <para>An optional capturing group that failed to match as part of an overall successful match (for example, "a(b)?c" matching "ac") returns null. A capturing group that matched the empty string (for example, "a(b?)c" matching "ac") returns the empty string.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public string Group(int group) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns true if the most recent matching operation attempted to access additional text beyond the available input, meaning that additional input could change the results of the match. </para>        
				/// </summary>
				/// <java-name>
				/// hitEnd
				/// </java-name>
				[Dot42.DexImport("hitEnd", "()Z", AccessFlags = 1)]
				public bool HitEnd() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Returns true if the most recent match succeeded and additional input could cause it to fail. If this method returns false and a match was found, then more input might change the match but the match won't be lost. If a match was not found, then requireEnd has no meaning. </para>        
				/// </summary>
				/// <java-name>
				/// requireEnd
				/// </java-name>
				[Dot42.DexImport("requireEnd", "()Z", AccessFlags = 1)]
				public bool RequireEnd() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Converts the current match into a separate MatchResult instance that is independent from this matcher. The new object is unaffected when the state of this matcher changes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the new <c>MatchResult </c> . </para>
				/// </returns>
				/// <java-name>
				/// toMatchResult
				/// </java-name>
				[Dot42.DexImport("toMatchResult", "()Ljava/util/regex/MatchResult;", AccessFlags = 1)]
				public global::Java.Util.Regex.IMatchResult ToMatchResult() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <summary>
				///  <para>Appends a literal part of the input plus a replacement for the current match to a given StringBuffer. The literal part is exactly the part of the input between the previous match and the current match. The method can be used in conjunction with find() and appendTail(StringBuffer) to walk through the input and replace all occurrences of the <c>Pattern </c> with something else.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>Matcher </c> itself. </para>
				/// </returns>
				/// <java-name>
				/// appendReplacement
				/// </java-name>
				[Dot42.DexImport("appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher AppendReplacement(global::Java.Lang.StringBuffer buffer, string replacement) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <summary>
				///  <para>Appends the (unmatched) remainder of the input to the given StringBuffer. The method can be used in conjunction with find() and appendReplacement(StringBuffer, String) to walk through the input and replace all matches of the <c>Pattern </c> with something else.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the <c>StringBuffer </c> . </para>
				/// </returns>
				/// <java-name>
				/// appendTail
				/// </java-name>
				[Dot42.DexImport("appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer AppendTail(global::Java.Lang.StringBuffer buffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <summary>
				///  <para>Replaces all occurrences of this matcher's pattern in the input with a given string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the modified input string. </para>
				/// </returns>
				/// <java-name>
				/// replaceAll
				/// </java-name>
				[Dot42.DexImport("replaceAll", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string ReplaceAll(string replacement) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Replaces the first occurrence of this matcher's pattern in the input with a given string.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the modified input string. </para>
				/// </returns>
				/// <java-name>
				/// replaceFirst
				/// </java-name>
				[Dot42.DexImport("replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string ReplaceFirst(string replacement) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns a replacement string for the given one that has all backslashes and dollar signs escaped.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the input string, with all backslashes and dollar signs having been escaped. </para>
				/// </returns>
				/// <java-name>
				/// quoteReplacement
				/// </java-name>
				[Dot42.DexImport("quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string QuoteReplacement(string s) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Matcher() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns true if this matcher has anchoring bounds enabled. When anchoring bounds are enabled, the start and end of the input match the '^' and '$' meta-characters, otherwise not. Anchoring bounds are enabled by default. </para>        
				/// </summary>
				/// <java-name>
				/// hasAnchoringBounds
				/// </java-name>
				public bool HasAnchoringBounds
				{
						[Dot42.DexImport("hasAnchoringBounds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if this matcher has transparent bounds enabled. When transparent bounds are enabled, the parts of the input outside the region are subject to lookahead and lookbehind, otherwise they are not. Transparent bounds are disabled by default. </para>        
				/// </summary>
				/// <java-name>
				/// hasTransparentBounds
				/// </java-name>
				public bool HasTransparentBounds
				{
						[Dot42.DexImport("hasTransparentBounds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <summary>
		///  <para>Patterns are compiled regular expressions. In many cases, convenience methods such as String.matches, String.replaceAll and String.split will be preferable, but if you need to do a lot of work with the same regular expression, it may be more efficient to compile it once and reuse it. The <c>Pattern </c> class and its companion, Matcher, also offer more functionality than the small amount exposed by <c>String </c> .</para> <para> <pre>
		/// // String convenience methods:
		/// boolean sawFailures = s.matches("Failures: \\d+");
		/// String farewell = s.replaceAll("Hello, (\\S+)", "Goodbye, $1");
		/// String[] fields = s.split(":");</pre></para> <para> <pre>// Direct use of Pattern:
		/// Pattern p = Pattern.compile("Hello, (\\S+)");
		/// Matcher m = p.matcher(inputString);
		/// while (m.find()) { // Find each match in turn; String can't do this.
		///     String name = m.group(1); // Access a submatch group; String can't do this.
		/// }
		/// </pre></para> <para> <h3>Regular expression syntax</h3></para> <para> &lt;style type="text/css"&gt; .datatable td { padding-right: 20px; } &lt;/style&gt;</para> <para></para> <para>Java supports a subset of Perl 5 regular expression syntax. An important gotcha is that Java has no regular expression literals, and uses plain old string literals instead. This means that you need an extra level of escaping. For example, the regular expression <c>\s+ </c> has to be represented as the string <c>"\\s+" </c> .</para> <para> <h3>Escape sequences</h3></para> <para> </para> <para> <table> <row> <entry> <para>\  </para></entry> <entry> <para>Quote the following metacharacter (so <c>\. </c> matches a literal <c>. </c> ).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>Quote all following metacharacters until <c>\E </c> .  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>Stop quoting metacharacters (started by <c>\Q </c> ).  </para></entry></row> <row> <entry> <para>\  </para></entry> <entry> <para>A literal backslash.  </para></entry></row> <row> <entry> <para>&amp;#x005c;u <b>hhhh</b>  </para></entry> <entry> <para>The Unicode character U+hhhh (in hex).  </para></entry></row> <row> <entry> <para>&amp;#x005c;x <b>hh</b>  </para></entry> <entry> <para>The Unicode character U+00hh (in hex).  </para></entry></row> <row> <entry> <para> <code></code>  <b>x</b>  </para></entry> <entry> <para>The ASCII control character ^x (so <c>\cH </c> would be ^H, U+0008). </para> <para></para></entry></row> <row> <entry> <para> <b></b>  </para></entry> <entry> <para>The ASCII bell character (U+0007).  </para></entry></row> <row> <entry> <para> <b></b>  </para></entry> <entry> <para>The ASCII ESC character (U+001b).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>The ASCII form feed character (U+000c).  </para></entry></row> <row> <entry> <para> <br></br>  </para></entry> <entry> <para>The ASCII newline character (U+000a).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>The ASCII carriage return character (U+000d).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>The ASCII tab character (U+0009).  </para></entry></row></table></para> <para> <h3>Character classes</h3></para> <para> </para> <para>It's possible to construct arbitrary character classes using set operations:  <table> <row> <entry> <para>[abc]  </para></entry> <entry> <para>Any one of <c>a </c> , <c>b </c> , or <c>c </c> . (Enumeration.)  </para></entry></row> <row> <entry> <para>[a-c]  </para></entry> <entry> <para>Any one of <c>a </c> , <c>b </c> , or <c>c </c> . (Range.)  </para></entry></row> <row> <entry> <para>[^abc]  </para></entry> <entry> <para>Any character  <b>except</b> <c>a </c> , <c>b </c> , or <c>c </c> . (Negation.)  </para></entry></row> <row> <entry> <para>[[a-f][0-9]]  </para></entry> <entry> <para>Any character in either range. (Union.)  </para></entry></row> <row> <entry> <para>[[a-z]&amp;&amp;[jkl]]  </para></entry> <entry> <para>Any character in both ranges. (Intersection.)  </para></entry></row></table></para> <para>Most of the time, the built-in character classes are more useful:  <table> <row> <entry> <para></para></entry> <entry> <para>Any digit character (see note below).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>Any non-digit character (see note below).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>Any whitespace character (see note below).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>Any non-whitespace character (see note below).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>Any word character (see note below).  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>Any non-word character (see note below).  </para></entry></row> <row> <entry> <para> <code></code>{ <b>NAME</b>}  </para></entry> <entry> <para>Any character in the class with the given  <b>NAME</b>.   </para></entry></row> <row> <entry> <para>{ <b>NAME</b>}  </para></entry> <entry> <para>Any character  <b>not</b> in the named class.   </para></entry></row></table></para> <para>Note that these built-in classes don't just cover the traditional ASCII range. For example,  <code></code> is equivalent to the character class  <code>[ <code></code>{Ll} <code></code>{Lu} <code></code>{Lt} <code></code>{Lo} <code></code>{Nd}]</code>. For more details see , and bear in mind that the set of characters in each class can vary between Unicode releases. If you actually want to match only ASCII characters, specify the explicit characters you want; if you mean 0-9 use  <code>[0-9]</code> rather than  <code></code>, which would also include Gurmukhi digits and so forth. </para> <para>There are also a variety of named classes:  <ul> <li> <para>, prefixed by <c>Is </c> . For example <c>\p{IsLu} </c> for all uppercase letters. </para></li> <li> <para>POSIX class names. These are 'Alnum', 'Alpha', 'ASCII', 'Blank', 'Cntrl', 'Digit', 'Graph', 'Lower', 'Print', 'Punct', 'Upper', 'XDigit'. </para></li> <li> <para>Unicode block names, as accepted as input to java.lang.Character.UnicodeBlock#forName, prefixed by <c>In </c> . For example <c>\p{InHebrew} </c> for all characters in the Hebrew block. </para></li> <li> <para>Character method names. These are all non-deprecated methods from java.lang.Character whose name starts with <c>is </c> , but with the <c>is </c> replaced by <c>java </c> . For example, <c>\p{javaLowerCase} </c> . </para></li></ul></para> <para> <h3>Quantifiers</h3></para> <para> </para> <para>Quantifiers match some number of instances of the preceding regular expression.  <table> <row> <entry> <para>*  </para></entry> <entry> <para>Zero or more.  </para></entry></row> <row> <entry> <para>?  </para></entry> <entry> <para>Zero or one.  </para></entry></row> <row> <entry> <para>+  </para></entry> <entry> <para>One or more.  </para></entry></row> <row> <entry> <para>{ <b>n</b>}  </para></entry> <entry> <para>Exactly  <b>n</b>.  </para></entry></row> <row> <entry> <para>{ <b>n,</b>}  </para></entry> <entry> <para>At least  <b>n</b>.  </para></entry></row> <row> <entry> <para>{ <b>n</b>, <b>m</b>}  </para></entry> <entry> <para>At least  <b>n</b> but not more than  <b>m</b>.  </para></entry></row></table></para> <para>Quantifiers are "greedy" by default, meaning that they will match the longest possible input sequence. There are also non-greedy quantifiers that match the shortest possible input sequence. They're same as the greedy ones but with a trailing <c>? </c> :  <table> <row> <entry> <para>*?  </para></entry> <entry> <para>Zero or more (non-greedy).  </para></entry></row> <row> <entry> <para>??  </para></entry> <entry> <para>Zero or one (non-greedy).  </para></entry></row> <row> <entry> <para>+?  </para></entry> <entry> <para>One or more (non-greedy).  </para></entry></row> <row> <entry> <para>{ <b>n</b>}?  </para></entry> <entry> <para>Exactly  <b>n</b> (non-greedy).  </para></entry></row> <row> <entry> <para>{ <b>n,</b>}?  </para></entry> <entry> <para>At least  <b>n</b> (non-greedy).  </para></entry></row> <row> <entry> <para>{ <b>n</b>, <b>m</b>}?  </para></entry> <entry> <para>At least  <b>n</b> but not more than  <b>m</b> (non-greedy).  </para></entry></row></table></para> <para>Quantifiers allow backtracking by default. There are also possessive quantifiers to prevent backtracking. They're same as the greedy ones but with a trailing <c>+ </c> :  <table> <row> <entry> <para>*+  </para></entry> <entry> <para>Zero or more (possessive).  </para></entry></row> <row> <entry> <para>?+  </para></entry> <entry> <para>Zero or one (possessive).  </para></entry></row> <row> <entry> <para>++  </para></entry> <entry> <para>One or more (possessive).  </para></entry></row> <row> <entry> <para>{ <b>n</b>}+  </para></entry> <entry> <para>Exactly  <b>n</b> (possessive).  </para></entry></row> <row> <entry> <para>{ <b>n,</b>}+  </para></entry> <entry> <para>At least  <b>n</b> (possessive).  </para></entry></row> <row> <entry> <para>{ <b>n</b>, <b>m</b>}+  </para></entry> <entry> <para>At least  <b>n</b> but not more than  <b>m</b> (possessive).  </para></entry></row></table></para> <para> <h3>Zero-width assertions</h3></para> <para> </para> <para> <table> <row> <entry> <para>^  </para></entry> <entry> <para>At beginning of line.  </para></entry></row> <row> <entry> <para>$  </para></entry> <entry> <para>At end of line.  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>At beginning of input.  </para></entry></row> <row> <entry> <para> <b></b>  </para></entry> <entry> <para>At word boundary.  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>At non-word boundary.  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>At end of previous match.  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>At end of input.  </para></entry></row> <row> <entry> <para></para></entry> <entry> <para>At end of input, or before newline at end.  </para></entry></row></table></para> <para> <h3>Look-around assertions</h3></para> <para> </para> <para>Look-around assertions assert that the subpattern does (positive) or doesn't (negative) match after (look-ahead) or before (look-behind) the current position, without including the matched text in the containing match. The maximum length of possible matches for look-behind patterns must not be unbounded. </para> <para> <table> <row> <entry> <para>(?= <b>a</b>)  </para></entry> <entry> <para>Zero-width positive look-ahead.  </para></entry></row> <row> <entry> <para>(?! <b>a</b>)  </para></entry> <entry> <para>Zero-width negative look-ahead.  </para></entry></row> <row> <entry> <para>(?&lt;= <b>a</b>)  </para></entry> <entry> <para>Zero-width positive look-behind.  </para></entry></row> <row> <entry> <para>(?&lt;! <b>a</b>)  </para></entry> <entry> <para>Zero-width negative look-behind.  </para></entry></row></table></para> <para> <h3>Groups</h3></para> <para></para> <para></para> <para> <table> <row> <entry> <para>( <b>a</b>)  </para></entry> <entry> <para>A capturing group.  </para></entry></row> <row> <entry> <para>(?: <b>a</b>)  </para></entry> <entry> <para>A non-capturing group.  </para></entry></row> <row> <entry> <para>(?&gt; <b>a</b>)  </para></entry> <entry> <para>An independent non-capturing group. (The first match of the subgroup is the only match tried.)  </para></entry></row> <row> <entry> <para>&lt;i&gt;n  </para></entry> <entry> <para>The text already matched by capturing group  <b>n</b>.  </para></entry></row></table></para> <para>See Matcher#group for details of how capturing groups are numbered and accessed.</para> <para> <h3>Operators</h3></para> <para> </para> <para> <table> <row> <entry> <para> <b>ab</b>  </para></entry> <entry> <para>Expression  <b>a</b> followed by expression  <b>b</b>.  </para></entry></row> <row> <entry> <para> <b>a</b>| <b>b</b>  </para></entry> <entry> <para>Either expression  <b>a</b> or expression  <b>b</b>.  </para></entry></row></table></para> <para> <h3>Flags</h3></para> <para> </para> <para> <table> <row> <entry> <para>(?dimsux-dimsux: <b>a</b>)  </para></entry> <entry> <para>Evaluates the expression  <b>a</b> with the given flags enabled/disabled.  </para></entry></row> <row> <entry> <para>(?dimsux-dimsux)  </para></entry> <entry> <para>Evaluates the rest of the pattern with the given flags enabled/disabled.  </para></entry></row></table></para> <para></para> <para>The flags are:  <table> <row> <entry> <para> <c>i </c>  </para></entry> <entry> <para>CASE_INSENSITIVE </para></entry> <entry> <para>case insensitive matching </para></entry></row> <row> <entry> <para> <c>d </c>  </para></entry> <entry> <para>UNIX_LINES </para></entry> <entry> <para>only accept <c>'\n' </c> as a line terminator </para></entry></row> <row> <entry> <para> <c>m </c>  </para></entry> <entry> <para>MULTILINE </para></entry> <entry> <para>allow <c>^ </c> and <c>$ </c> to match beginning/end of any line </para></entry></row> <row> <entry> <para> <c>s </c>  </para></entry> <entry> <para>DOTALL </para></entry> <entry> <para>allow <c>. </c> to match <c>'\n' </c> ("s" for "single line") </para></entry></row> <row> <entry> <para> <c>u </c>  </para></entry> <entry> <para>UNICODE_CASE </para></entry> <entry> <para>enable Unicode case folding </para></entry></row> <row> <entry> <para> <c>x </c>  </para></entry> <entry> <para>COMMENTS </para></entry> <entry> <para>allow whitespace and comments </para></entry></row></table></para> <para>Either set of flags may be empty. For example, <c>(?i-m) </c> would turn on case-insensitivity and turn off multiline mode, <c>(?i) </c> would just turn on case-insensitivity, and <c>(?-m) </c> would just turn off multiline mode. </para> <para>Note that on Android, <c>UNICODE_CASE </c> is always on: case-insensitive matching will always be Unicode-aware. </para> <para>There are two other flags not settable via this mechanism: CANON_EQ and LITERAL. Attempts to use CANON_EQ on Android will throw an exception. </para> <para> <h3>Implementation notes</h3></para> <para>The regular expression implementation used in Android is provided by . The notation for the regular expressions is mostly a superset of those used in other Java language implementations. This means that existing applications will normally work as expected, but in rare cases Android may accept a regular expression that is not accepted by other implementations.</para> <para>In some cases, Android will recognize that a regular expression is a simple special case that can be handled more efficiently. This is true of both the convenience methods in <c>String </c> and the methods in <c>Pattern </c> .</para> <para> <para>Matcher </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/regex/Pattern
		/// </java-name>
		[Dot42.DexImport("java/util/regex/Pattern", AccessFlags = 49)]
		public sealed partial class Pattern : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This constant specifies that a pattern matches Unix line endings (' <br></br>') only against the '.', '^', and '$' meta characters. Corresponds to <c>(?d) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// UNIX_LINES
				/// </java-name>
				[Dot42.DexImport("UNIX_LINES", "I", AccessFlags = 25)]
				public const int UNIX_LINES = 1;
				/// <summary>
				///  <para>This constant specifies that a <c>Pattern </c> is matched case-insensitively. That is, the patterns "a+" and "A+" would both match the string "aAaAaA". See UNICODE_CASE. Corresponds to <c>(?i) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// CASE_INSENSITIVE
				/// </java-name>
				[Dot42.DexImport("CASE_INSENSITIVE", "I", AccessFlags = 25)]
				public const int CASE_INSENSITIVE = 2;
				/// <summary>
				///  <para>This constant specifies that a <c>Pattern </c> may contain whitespace or comments. Otherwise comments and whitespace are taken as literal characters. Corresponds to <c>(?x) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// COMMENTS
				/// </java-name>
				[Dot42.DexImport("COMMENTS", "I", AccessFlags = 25)]
				public const int COMMENTS = 4;
				/// <summary>
				///  <para>This constant specifies that the meta characters '^' and '$' match only the beginning and end of an input line, respectively. Normally, they match the beginning and the end of the complete input. Corresponds to <c>(?m) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// MULTILINE
				/// </java-name>
				[Dot42.DexImport("MULTILINE", "I", AccessFlags = 25)]
				public const int MULTILINE = 8;
				/// <summary>
				///  <para>This constant specifies that the whole <c>Pattern </c> is to be taken literally, that is, all meta characters lose their meanings. </para>        
				/// </summary>
				/// <java-name>
				/// LITERAL
				/// </java-name>
				[Dot42.DexImport("LITERAL", "I", AccessFlags = 25)]
				public const int LITERAL = 16;
				/// <summary>
				///  <para>This constant specifies that the '.' meta character matches arbitrary characters, including line endings, which is normally not the case. Corresponds to <c>(?s) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// DOTALL
				/// </java-name>
				[Dot42.DexImport("DOTALL", "I", AccessFlags = 25)]
				public const int DOTALL = 32;
				/// <summary>
				///  <para>This constant specifies that a <c>Pattern </c> that uses case-insensitive matching will use Unicode case folding. On Android, <c>UNICODE_CASE </c> is always on: case-insensitive matching will always be Unicode-aware. If your code is intended to be portable and uses case-insensitive matching on non-ASCII characters, you should use this flag. Corresponds to <c>(?u) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// UNICODE_CASE
				/// </java-name>
				[Dot42.DexImport("UNICODE_CASE", "I", AccessFlags = 25)]
				public const int UNICODE_CASE = 64;
				/// <summary>
				///  <para>This constant specifies that a character in a <c>Pattern </c> and a character in the input string only match if they are canonically equivalent. It is (currently) not supported in Android. </para>        
				/// </summary>
				/// <java-name>
				/// CANON_EQ
				/// </java-name>
				[Dot42.DexImport("CANON_EQ", "I", AccessFlags = 25)]
				public const int CANON_EQ = 128;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Pattern() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to <c>Pattern.compile(pattern, 0) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// compile
				/// </java-name>
				[Dot42.DexImport("compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;", AccessFlags = 9)]
				public static global::Java.Util.Regex.Pattern Compile(string pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Pattern);
				}

				/// <summary>
				///  <para>Returns a compiled form of the given <c>regularExpression </c> , as modified by the given <c>flags </c> . See the  for more on flags.</para> <para> <para>CANON_EQ </para> <para>CASE_INSENSITIVE </para> <para>COMMENTS </para> <para>DOTALL </para> <para>LITERAL </para> <para>MULTILINE </para> <para>UNICODE_CASE </para> <para>UNIX_LINES </para></para>        
				/// </summary>
				/// <java-name>
				/// compile
				/// </java-name>
				[Dot42.DexImport("compile", "(Ljava/lang/String;I)Ljava/util/regex/Pattern;", AccessFlags = 9)]
				public static global::Java.Util.Regex.Pattern Compile(string regularExpression, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Pattern);
				}

				/// <summary>
				///  <para>Returns the regular expression supplied to <c>compile </c> . </para>        
				/// </summary>
				/// <java-name>
				/// pattern
				/// </java-name>
				[Dot42.DexImport("pattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public string JavaPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the flags supplied to <c>compile </c> . </para>        
				/// </summary>
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "()I", AccessFlags = 1)]
				public int Flags() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns a Matcher for this pattern applied to the given <c>input </c> . The <c>Matcher </c> can be used to match the <c>Pattern </c> against the whole input, find occurrences of the <c>Pattern </c> in the input, or replace parts of the input. </para>        
				/// </summary>
				/// <java-name>
				/// matcher
				/// </java-name>
				[Dot42.DexImport("matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher Matcher(global::Java.Lang.ICharSequence input) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <summary>
				///  <para>Tests whether the given <c>regularExpression </c> matches the given <c>input </c> . Equivalent to <c>Pattern.compile(regularExpression).matcher(input).matches() </c> . If the same regular expression is to be used for multiple operations, it may be more efficient to reuse a compiled <c>Pattern </c> .</para> <para> <para>Pattern::compile(java.lang.String, int) </para> <para>Matcher::matches() </para></para>        
				/// </summary>
				/// <java-name>
				/// matches
				/// </java-name>
				[Dot42.DexImport("matches", "(Ljava/lang/String;Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool Matches(string regularExpression, global::Java.Lang.ICharSequence input) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Equivalent to <c>split(input, 0) </c> . </para>        
				/// </summary>
				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Split(global::Java.Lang.ICharSequence input) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Splits the given <c>input </c> at occurrences of this pattern.</para> <para>If this pattern does not occur in the input, the result is an array containing the input (converted from a <c>CharSequence </c> to a <c>String </c> ).</para> <para>Otherwise, the <c>limit </c> parameter controls the contents of the returned array as described below.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/CharSequence;I)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Split(global::Java.Lang.ICharSequence input, int limit) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <summary>
				///  <para>Quotes the given <c>string </c> using "\Q" and "\E", so that all meta-characters lose their special meaning. This method correctly escapes embedded instances of "\Q" or "\E". If the entire result is to be passed verbatim to compile, it's usually clearer to use the LITERAL flag instead. </para>        
				/// </summary>
				/// <java-name>
				/// quote
				/// </java-name>
				[Dot42.DexImport("quote", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Quote(string @string) /* MethodBuilder.Create */ 
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
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Pattern() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Encapsulates a syntax error that occurred during the compilation of a Pattern. Might include a detailed description, the original regular expression, and the index at which the error occurred.</para> <para> <para>Pattern::compile(String) </para> <para>Pattern::compile(java.lang.String,int) </para></para>    
		/// </summary>
		/// <java-name>
		/// java/util/regex/PatternSyntaxException
		/// </java-name>
		[Dot42.DexImport("java/util/regex/PatternSyntaxException", AccessFlags = 33)]
		public partial class PatternSyntaxException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new PatternSyntaxException for a given message, pattern, and error index.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public PatternSyntaxException(string description, string pattern, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a detailed error message for the exception. The message is potentially multi-line, and it might include a detailed description, the original regular expression, and the index at which the error occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the error message. </para>
				/// </returns>
				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PatternSyntaxException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the syntactically incorrect regular expression.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the regular expression. </para>
				/// </returns>
				/// <java-name>
				/// getPattern
				/// </java-name>
				public virtual string Pattern
				{
						[Dot42.DexImport("getPattern", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the description of the syntax error, or <c>null </c> if the description is not known.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the description. </para>
				/// </returns>
				/// <java-name>
				/// getDescription
				/// </java-name>
				public virtual string Description
				{
						[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the character index around which the error occurred, or -1 if the index is not known.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the index. </para>
				/// </returns>
				/// <java-name>
				/// getIndex
				/// </java-name>
				public virtual int Index
				{
						[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

