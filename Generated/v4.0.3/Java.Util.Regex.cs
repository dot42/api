#pragma warning disable 1717
namespace Java.Util.Regex
{
		/// <java-name>
		/// java/util/regex/MatchResult
		/// </java-name>
		[Dot42.DexImport("java/util/regex/MatchResult", AccessFlags = 1537)]
		public partial interface IMatchResult
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()I", AccessFlags = 1025)]
				int End() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(I)I", AccessFlags = 1025)]
				int End(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "()Ljava/lang/String;", AccessFlags = 1025)]
				string Group() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "(I)Ljava/lang/String;", AccessFlags = 1025)]
				string Group(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// groupCount
				/// </java-name>
				[Dot42.DexImport("groupCount", "()I", AccessFlags = 1025)]
				int GroupCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()I", AccessFlags = 1025)]
				int Start() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(I)I", AccessFlags = 1025)]
				int Start(int int32) /* MethodBuilder.Create */ ;

		}

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

				/// <java-name>
				/// appendReplacement
				/// </java-name>
				[Dot42.DexImport("appendReplacement", "(Ljava/lang/StringBuffer;Ljava/lang/String;)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher AppendReplacement(global::Java.Lang.StringBuffer stringBuffer, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher Reset() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher Reset(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <java-name>
				/// usePattern
				/// </java-name>
				[Dot42.DexImport("usePattern", "(Ljava/util/regex/Pattern;)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher UsePattern(global::Java.Util.Regex.Pattern pattern) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <java-name>
				/// region
				/// </java-name>
				[Dot42.DexImport("region", "(II)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher Region(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <java-name>
				/// appendTail
				/// </java-name>
				[Dot42.DexImport("appendTail", "(Ljava/lang/StringBuffer;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public global::Java.Lang.StringBuffer AppendTail(global::Java.Lang.StringBuffer stringBuffer) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// replaceFirst
				/// </java-name>
				[Dot42.DexImport("replaceFirst", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string ReplaceFirst(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// replaceAll
				/// </java-name>
				[Dot42.DexImport("replaceAll", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string ReplaceAll(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// pattern
				/// </java-name>
				[Dot42.DexImport("pattern", "()Ljava/util/regex/Pattern;", AccessFlags = 1)]
				public global::Java.Util.Regex.Pattern Pattern() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Pattern);
				}

				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "(I)Ljava/lang/String;", AccessFlags = 1)]
				public string Group(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// group
				/// </java-name>
				[Dot42.DexImport("group", "()Ljava/lang/String;", AccessFlags = 1)]
				public string Group() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// find
				/// </java-name>
				[Dot42.DexImport("find", "(I)Z", AccessFlags = 1)]
				public bool Find(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// find
				/// </java-name>
				[Dot42.DexImport("find", "()Z", AccessFlags = 1)]
				public bool Find() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lookingAt
				/// </java-name>
				[Dot42.DexImport("lookingAt", "()Z", AccessFlags = 1)]
				public bool LookingAt() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// matches
				/// </java-name>
				[Dot42.DexImport("matches", "()Z", AccessFlags = 1)]
				public bool Matches() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "(I)I", AccessFlags = 1)]
				public int Start(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(I)I", AccessFlags = 1)]
				public int End(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// quoteReplacement
				/// </java-name>
				[Dot42.DexImport("quoteReplacement", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string QuoteReplacement(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()I", AccessFlags = 1)]
				public int Start() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// groupCount
				/// </java-name>
				[Dot42.DexImport("groupCount", "()I", AccessFlags = 1)]
				public int GroupCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()I", AccessFlags = 1)]
				public int End() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toMatchResult
				/// </java-name>
				[Dot42.DexImport("toMatchResult", "()Ljava/util/regex/MatchResult;", AccessFlags = 1)]
				public global::Java.Util.Regex.IMatchResult ToMatchResult() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.IMatchResult);
				}

				/// <java-name>
				/// useAnchoringBounds
				/// </java-name>
				[Dot42.DexImport("useAnchoringBounds", "(Z)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher UseAnchoringBounds(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <java-name>
				/// hasAnchoringBounds
				/// </java-name>
				[Dot42.DexImport("hasAnchoringBounds", "()Z", AccessFlags = 1)]
				public bool HasAnchoringBounds() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// useTransparentBounds
				/// </java-name>
				[Dot42.DexImport("useTransparentBounds", "(Z)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher UseTransparentBounds(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <java-name>
				/// hasTransparentBounds
				/// </java-name>
				[Dot42.DexImport("hasTransparentBounds", "()Z", AccessFlags = 1)]
				public bool HasTransparentBounds() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// regionStart
				/// </java-name>
				[Dot42.DexImport("regionStart", "()I", AccessFlags = 1)]
				public int RegionStart() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// regionEnd
				/// </java-name>
				[Dot42.DexImport("regionEnd", "()I", AccessFlags = 1)]
				public int RegionEnd() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// requireEnd
				/// </java-name>
				[Dot42.DexImport("requireEnd", "()Z", AccessFlags = 1)]
				public bool RequireEnd() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hitEnd
				/// </java-name>
				[Dot42.DexImport("hitEnd", "()Z", AccessFlags = 1)]
				public bool HitEnd() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Matcher() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/regex/Pattern
		/// </java-name>
		[Dot42.DexImport("java/util/regex/Pattern", AccessFlags = 49)]
		public sealed partial class Pattern : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// UNIX_LINES
				/// </java-name>
				[Dot42.DexImport("UNIX_LINES", "I", AccessFlags = 25)]
				public const int UNIX_LINES = 1;
				/// <java-name>
				/// CASE_INSENSITIVE
				/// </java-name>
				[Dot42.DexImport("CASE_INSENSITIVE", "I", AccessFlags = 25)]
				public const int CASE_INSENSITIVE = 2;
				/// <java-name>
				/// COMMENTS
				/// </java-name>
				[Dot42.DexImport("COMMENTS", "I", AccessFlags = 25)]
				public const int COMMENTS = 4;
				/// <java-name>
				/// MULTILINE
				/// </java-name>
				[Dot42.DexImport("MULTILINE", "I", AccessFlags = 25)]
				public const int MULTILINE = 8;
				/// <java-name>
				/// LITERAL
				/// </java-name>
				[Dot42.DexImport("LITERAL", "I", AccessFlags = 25)]
				public const int LITERAL = 16;
				/// <java-name>
				/// DOTALL
				/// </java-name>
				[Dot42.DexImport("DOTALL", "I", AccessFlags = 25)]
				public const int DOTALL = 32;
				/// <java-name>
				/// UNICODE_CASE
				/// </java-name>
				[Dot42.DexImport("UNICODE_CASE", "I", AccessFlags = 25)]
				public const int UNICODE_CASE = 64;
				/// <java-name>
				/// CANON_EQ
				/// </java-name>
				[Dot42.DexImport("CANON_EQ", "I", AccessFlags = 25)]
				public const int CANON_EQ = 128;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Pattern() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// matcher
				/// </java-name>
				[Dot42.DexImport("matcher", "(Ljava/lang/CharSequence;)Ljava/util/regex/Matcher;", AccessFlags = 1)]
				public global::Java.Util.Regex.Matcher Matcher(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Matcher);
				}

				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/CharSequence;I)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Split(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/CharSequence;)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Split(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// pattern
				/// </java-name>
				[Dot42.DexImport("pattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public string JavaPattern() /* MethodBuilder.Create */ 
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
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "()I", AccessFlags = 1)]
				public int Flags() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compile
				/// </java-name>
				[Dot42.DexImport("compile", "(Ljava/lang/String;I)Ljava/util/regex/Pattern;", AccessFlags = 9)]
				public static global::Java.Util.Regex.Pattern Compile(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Pattern);
				}

				/// <java-name>
				/// compile
				/// </java-name>
				[Dot42.DexImport("compile", "(Ljava/lang/String;)Ljava/util/regex/Pattern;", AccessFlags = 9)]
				public static global::Java.Util.Regex.Pattern Compile(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Regex.Pattern);
				}

				/// <java-name>
				/// matches
				/// </java-name>
				[Dot42.DexImport("matches", "(Ljava/lang/String;Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool Matches(string @string, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// quote
				/// </java-name>
				[Dot42.DexImport("quote", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Quote(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Pattern() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/util/regex/PatternSyntaxException
		/// </java-name>
		[Dot42.DexImport("java/util/regex/PatternSyntaxException", AccessFlags = 33)]
		public partial class PatternSyntaxException : global::System.ArgumentException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", AccessFlags = 1)]
				public PatternSyntaxException(string @string, string string1, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPattern
				/// </java-name>
				[Dot42.DexImport("getPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDescription() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
				public virtual int GetIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PatternSyntaxException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPattern
				/// </java-name>
				public string Pattern
				{
				[Dot42.DexImport("getPattern", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPattern(); }
				}

				/// <java-name>
				/// getDescription
				/// </java-name>
				public string Description
				{
				[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDescription(); }
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				public int Index
				{
				[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return GetIndex(); }
				}

		}

}

