#pragma warning disable 1717
namespace Java.Text
{
		/// <java-name>
		/// java/text/Annotation
		/// </java-name>
		[Dot42.DexImport("java/text/Annotation", AccessFlags = 33)]
		public partial class Annotation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public Annotation(object @object) /* MethodBuilder.Create */ 
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
				internal Annotation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public virtual object Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

		}

		/// <java-name>
		/// java/text/AttributedString
		/// </java-name>
		[Dot42.DexImport("java/text/AttributedString", AccessFlags = 33)]
		public partial class AttributedString
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/text/AttributedCharacterIterator;)V", AccessFlags = 1)]
				public AttributedString(global::Java.Text.IAttributedCharacterIterator attributedCharacterIterator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/text/AttributedCharacterIterator;II)V", AccessFlags = 1)]
				public AttributedString(global::Java.Text.IAttributedCharacterIterator attributedCharacterIterator, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/text/AttributedCharacterIterator;II[Ljava/text/AttributedCharacterIterator" +
    "$Attribute;)V", AccessFlags = 1)]
				public AttributedString(global::Java.Text.IAttributedCharacterIterator attributedCharacterIterator, int int32, int int321, global::Java.Text.IAttributedCharacterIterator_Attribute[] iAttributedCharacterIterator_Attribute) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public AttributedString(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Map;)V", AccessFlags = 1, Signature = "(Ljava/lang/String;Ljava/util/Map<+Ljava/text/AttributedCharacterIterator$Attribu" +
    "te;*>;)V")]
				public AttributedString(string @string, global::Java.Util.IMap<global::Java.Text.IAttributedCharacterIterator_Attribute, object> map) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void AddAttribute(global::Java.Text.IAttributedCharacterIterator_Attribute iAttributedCharacterIterator_Attribute, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAttribute
				/// </java-name>
				[Dot42.DexImport("addAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void AddAttribute(global::Java.Text.IAttributedCharacterIterator_Attribute iAttributedCharacterIterator_Attribute, object @object, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAttributes
				/// </java-name>
				[Dot42.DexImport("addAttributes", "(Ljava/util/Map;II)V", AccessFlags = 1, Signature = "(Ljava/util/Map<+Ljava/text/AttributedCharacterIterator$Attribute;*>;II)V")]
				public virtual void AddAttributes(global::Java.Util.IMap<global::Java.Text.IAttributedCharacterIterator_Attribute, object> map, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIterator
				/// </java-name>
				[Dot42.DexImport("getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacte" +
    "rIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.IAttributedCharacterIterator GetIterator(global::Java.Text.IAttributedCharacterIterator_Attribute[] iAttributedCharacterIterator_Attribute) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <java-name>
				/// getIterator
				/// </java-name>
				[Dot42.DexImport("getIterator", "([Ljava/text/AttributedCharacterIterator$Attribute;II)Ljava/text/AttributedCharac" +
    "terIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.IAttributedCharacterIterator GetIterator(global::Java.Text.IAttributedCharacterIterator_Attribute[] iAttributedCharacterIterator_Attribute, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AttributedString() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getIterator
				/// </java-name>
				public virtual global::Java.Text.IAttributedCharacterIterator Iterator
				{
						[Dot42.DexImport("getIterator", "()Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
						get{ return default(global::Java.Text.IAttributedCharacterIterator); }
				}

		}

		/// <java-name>
		/// java/text/Bidi
		/// </java-name>
		[Dot42.DexImport("java/text/Bidi", AccessFlags = 49)]
		public sealed partial class Bidi
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DIRECTION_DEFAULT_LEFT_TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_DEFAULT_LEFT_TO_RIGHT", "I", AccessFlags = 25)]
				public const int DIRECTION_DEFAULT_LEFT_TO_RIGHT = -2;
				/// <java-name>
				/// DIRECTION_DEFAULT_RIGHT_TO_LEFT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_DEFAULT_RIGHT_TO_LEFT", "I", AccessFlags = 25)]
				public const int DIRECTION_DEFAULT_RIGHT_TO_LEFT = -1;
				/// <java-name>
				/// DIRECTION_LEFT_TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_LEFT_TO_RIGHT", "I", AccessFlags = 25)]
				public const int DIRECTION_LEFT_TO_RIGHT = 0;
				/// <java-name>
				/// DIRECTION_RIGHT_TO_LEFT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_RIGHT_TO_LEFT", "I", AccessFlags = 25)]
				public const int DIRECTION_RIGHT_TO_LEFT = 1;
				[Dot42.DexImport("<init>", "(Ljava/text/AttributedCharacterIterator;)V", AccessFlags = 1)]
				public Bidi(global::Java.Text.IAttributedCharacterIterator attributedCharacterIterator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([CI[BIII)V", AccessFlags = 1)]
				public Bidi(char[] @char, int int32, sbyte[] sByte, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([CI[BIII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public Bidi(char[] @char, int int32, byte[] @byte, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public Bidi(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// baseIsLeftToRight
				/// </java-name>
				[Dot42.DexImport("baseIsLeftToRight", "()Z", AccessFlags = 1)]
				public bool BaseIsLeftToRight() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createLineBidi
				/// </java-name>
				[Dot42.DexImport("createLineBidi", "(II)Ljava/text/Bidi;", AccessFlags = 1)]
				public global::Java.Text.Bidi CreateLineBidi(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.Bidi);
				}

				/// <java-name>
				/// getLevelAt
				/// </java-name>
				[Dot42.DexImport("getLevelAt", "(I)I", AccessFlags = 1)]
				public int GetLevelAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRunLevel
				/// </java-name>
				[Dot42.DexImport("getRunLevel", "(I)I", AccessFlags = 1)]
				public int GetRunLevel(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRunLimit
				/// </java-name>
				[Dot42.DexImport("getRunLimit", "(I)I", AccessFlags = 1)]
				public int GetRunLimit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getRunStart
				/// </java-name>
				[Dot42.DexImport("getRunStart", "(I)I", AccessFlags = 1)]
				public int GetRunStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reorderVisually
				/// </java-name>
				[Dot42.DexImport("reorderVisually", "([BI[Ljava/lang/Object;II)V", AccessFlags = 9)]
				public static void ReorderVisually(sbyte[] sByte, int int32, object[] @object, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reorderVisually
				/// </java-name>
				[Dot42.DexImport("reorderVisually", "([BI[Ljava/lang/Object;II)V", AccessFlags = 9, IgnoreFromJava = true)]
				public static void ReorderVisually(byte[] @byte, int int32, object[] @object, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requiresBidi
				/// </java-name>
				[Dot42.DexImport("requiresBidi", "([CII)Z", AccessFlags = 9)]
				public static bool RequiresBidi(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
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
				internal Bidi() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBaseLevel
				/// </java-name>
				public int BaseLevel
				{
						[Dot42.DexImport("getBaseLevel", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLength
				/// </java-name>
				public int Length
				{
						[Dot42.DexImport("getLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRunCount
				/// </java-name>
				public int RunCount
				{
						[Dot42.DexImport("getRunCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isLeftToRight
				/// </java-name>
				public bool IsLeftToRight
				{
						[Dot42.DexImport("isLeftToRight", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMixed
				/// </java-name>
				public bool IsMixed
				{
						[Dot42.DexImport("isMixed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isRightToLeft
				/// </java-name>
				public bool IsRightToLeft
				{
						[Dot42.DexImport("isRightToLeft", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/text/BreakIterator
		/// </java-name>
		[Dot42.DexImport("java/text/BreakIterator", AccessFlags = 1057)]
		public abstract partial class BreakIterator : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DONE
				/// </java-name>
				[Dot42.DexImport("DONE", "I", AccessFlags = 25)]
				public const int DONE = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal BreakIterator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCharacterInstance
				/// </java-name>
				[Dot42.DexImport("getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetCharacterInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <java-name>
				/// getLineInstance
				/// </java-name>
				[Dot42.DexImport("getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetLineInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <java-name>
				/// getSentenceInstance
				/// </java-name>
				[Dot42.DexImport("getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetSentenceInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <java-name>
				/// getWordInstance
				/// </java-name>
				[Dot42.DexImport("getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", AccessFlags = 9)]
				public static global::Java.Text.BreakIterator GetWordInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.BreakIterator);
				}

				/// <java-name>
				/// isBoundary
				/// </java-name>
				[Dot42.DexImport("isBoundary", "(I)Z", AccessFlags = 1)]
				public virtual bool IsBoundary(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// preceding
				/// </java-name>
				[Dot42.DexImport("preceding", "(I)I", AccessFlags = 1)]
				public virtual int Preceding(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetText(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// current
				/// </java-name>
				[Dot42.DexImport("current", "()I", AccessFlags = 1025)]
				public abstract int Current() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()I", AccessFlags = 1025)]
				public abstract int First() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// following
				/// </java-name>
				[Dot42.DexImport("following", "(I)I", AccessFlags = 1025)]
				public abstract int Following(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()I", AccessFlags = 1025)]
				public abstract int Last() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()I", AccessFlags = 1025)]
				public abstract int Next() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(I)I", AccessFlags = 1025)]
				public abstract int Next(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()I", AccessFlags = 1025)]
				public abstract int Previous() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
						[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Locale[]); }
				}

				/// <java-name>
				/// getCharacterInstance
				/// </java-name>
				public static global::Java.Text.BreakIterator CharacterInstance
				{
						[Dot42.DexImport("getCharacterInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
						get{ return default(global::Java.Text.BreakIterator); }
				}

				/// <java-name>
				/// getLineInstance
				/// </java-name>
				public static global::Java.Text.BreakIterator LineInstance
				{
						[Dot42.DexImport("getLineInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
						get{ return default(global::Java.Text.BreakIterator); }
				}

				/// <java-name>
				/// getSentenceInstance
				/// </java-name>
				public static global::Java.Text.BreakIterator SentenceInstance
				{
						[Dot42.DexImport("getSentenceInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
						get{ return default(global::Java.Text.BreakIterator); }
				}

				/// <java-name>
				/// getWordInstance
				/// </java-name>
				public static global::Java.Text.BreakIterator WordInstance
				{
						[Dot42.DexImport("getWordInstance", "()Ljava/text/BreakIterator;", AccessFlags = 9)]
						get{ return default(global::Java.Text.BreakIterator); }
				}

				/// <java-name>
				/// getText
				/// </java-name>
				public abstract global::Java.Text.ICharacterIterator Text
				{
						[Dot42.DexImport("getText", "()Ljava/text/CharacterIterator;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setText", "(Ljava/text/CharacterIterator;)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// java/text/ChoiceFormat
		/// </java-name>
		[Dot42.DexImport("java/text/ChoiceFormat", AccessFlags = 33)]
		public partial class ChoiceFormat : global::Java.Text.NumberFormat
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([D[Ljava/lang/String;)V", AccessFlags = 1)]
				public ChoiceFormat(double[] @double, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ChoiceFormat(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyPattern
				/// </java-name>
				[Dot42.DexImport("applyPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyPattern(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(double @double, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(long int64, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
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
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "(D)D", AccessFlags = 25)]
				public static double NextDouble(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "(DZ)D", AccessFlags = 9)]
				public static double NextDouble(double @double, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", AccessFlags = 1)]
				public override global::Java.Lang.Number Parse(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Number);
				}

				/// <java-name>
				/// previousDouble
				/// </java-name>
				[Dot42.DexImport("previousDouble", "(D)D", AccessFlags = 25)]
				public static double PreviousDouble(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// setChoices
				/// </java-name>
				[Dot42.DexImport("setChoices", "([D[Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetChoices(double[] @double, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toPattern
				/// </java-name>
				[Dot42.DexImport("toPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ChoiceFormat() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFormats
				/// </java-name>
				public virtual object[] Formats
				{
						[Dot42.DexImport("getFormats", "()[Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object[]); }
				}

				/// <java-name>
				/// getLimits
				/// </java-name>
				public virtual double[] Limits
				{
						[Dot42.DexImport("getLimits", "()[D", AccessFlags = 1)]
						get{ return default(double[]); }
				}

		}

		/// <java-name>
		/// java/text/CollationElementIterator
		/// </java-name>
		[Dot42.DexImport("java/text/CollationElementIterator", AccessFlags = 49)]
		public sealed partial class CollationElementIterator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NULLORDER
				/// </java-name>
				[Dot42.DexImport("NULLORDER", "I", AccessFlags = 25)]
				public const int NULLORDER = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CollationElementIterator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxExpansion
				/// </java-name>
				[Dot42.DexImport("getMaxExpansion", "(I)I", AccessFlags = 1)]
				public int GetMaxExpansion(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()I", AccessFlags = 1)]
				public int Next() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()I", AccessFlags = 1)]
				public int Previous() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// primaryOrder
				/// </java-name>
				[Dot42.DexImport("primaryOrder", "(I)I", AccessFlags = 25)]
				public static int PrimaryOrder(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// secondaryOrder
				/// </java-name>
				[Dot42.DexImport("secondaryOrder", "(I)S", AccessFlags = 25)]
				public static short SecondaryOrder(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/text/CharacterIterator;)V", AccessFlags = 1)]
				public void SetText(global::Java.Text.ICharacterIterator characterIterator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetText(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// tertiaryOrder
				/// </java-name>
				[Dot42.DexImport("tertiaryOrder", "(I)S", AccessFlags = 25)]
				public static short TertiaryOrder(int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				public int Offset
				{
						[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/text/CollationKey
		/// </java-name>
		[Dot42.DexImport("java/text/CollationKey", AccessFlags = 1057, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/text/CollationKey;>;")]
		public abstract partial class CollationKey : global::System.IComparable<global::Java.Text.CollationKey>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal CollationKey(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/text/CollationKey;)I", AccessFlags = 1025)]
				public virtual int CompareTo(global::Java.Text.CollationKey collationKey) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaToByteArray() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toByteArray
				/// </java-name>
				[Dot42.DexImport("toByteArray", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] ToByteArray() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Object;)I", AccessFlags = 4161)]
				public virtual int CompareTo(object @object) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CollationKey() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSourceString
				/// </java-name>
				public virtual string SourceString
				{
						[Dot42.DexImport("getSourceString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/text/Collator
		/// </java-name>
		[Dot42.DexImport("java/text/Collator", AccessFlags = 1057, Signature = "Ljava/lang/Object;Ljava/util/Comparator<Ljava/lang/Object;>;Ljava/lang/Cloneable;" +
    "")]
		public abstract partial class Collator : global::Java.Util.IComparator<object>, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_DECOMPOSITION
				/// </java-name>
				[Dot42.DexImport("NO_DECOMPOSITION", "I", AccessFlags = 25)]
				public const int NO_DECOMPOSITION = 0;
				/// <java-name>
				/// CANONICAL_DECOMPOSITION
				/// </java-name>
				[Dot42.DexImport("CANONICAL_DECOMPOSITION", "I", AccessFlags = 25)]
				public const int CANONICAL_DECOMPOSITION = 1;
				/// <java-name>
				/// FULL_DECOMPOSITION
				/// </java-name>
				[Dot42.DexImport("FULL_DECOMPOSITION", "I", AccessFlags = 25)]
				public const int FULL_DECOMPOSITION = 2;
				/// <java-name>
				/// PRIMARY
				/// </java-name>
				[Dot42.DexImport("PRIMARY", "I", AccessFlags = 25)]
				public const int PRIMARY = 0;
				/// <java-name>
				/// SECONDARY
				/// </java-name>
				[Dot42.DexImport("SECONDARY", "I", AccessFlags = 25)]
				public const int SECONDARY = 1;
				/// <java-name>
				/// TERTIARY
				/// </java-name>
				[Dot42.DexImport("TERTIARY", "I", AccessFlags = 25)]
				public const int TERTIARY = 2;
				/// <java-name>
				/// IDENTICAL
				/// </java-name>
				[Dot42.DexImport("IDENTICAL", "I", AccessFlags = 25)]
				public const int IDENTICAL = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Collator() /* MethodBuilder.Create */ 
				{
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
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", AccessFlags = 1)]
				public virtual int Compare(object @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1025)]
				public abstract int Compare(string @string, string string1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/String;Ljava/lang/String;)Z", AccessFlags = 1)]
				public virtual bool Equals(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCollationKey
				/// </java-name>
				[Dot42.DexImport("getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;", AccessFlags = 1025)]
				public abstract global::Java.Text.CollationKey GetCollationKey(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/text/Collator;", AccessFlags = 9)]
				public static global::Java.Text.Collator GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.Collator);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1025)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
						[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Locale[]); }
				}

				/// <java-name>
				/// getDecomposition
				/// </java-name>
				public virtual int Decomposition
				{
						[Dot42.DexImport("getDecomposition", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDecomposition", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.Collator Instance
				{
						[Dot42.DexImport("getInstance", "()Ljava/text/Collator;", AccessFlags = 9)]
						get{ return default(global::Java.Text.Collator); }
				}

				/// <java-name>
				/// getStrength
				/// </java-name>
				public virtual int Strength
				{
						[Dot42.DexImport("getStrength", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setStrength", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/text/DateFormat
		/// </java-name>
		[Dot42.DexImport("java/text/DateFormat", AccessFlags = 1057)]
		public abstract partial class DateFormat : global::Java.Text.Format
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// calendar
				/// </java-name>
				[Dot42.DexImport("calendar", "Ljava/util/Calendar;", AccessFlags = 4)]
				protected internal global::Java.Util.Calendar @calendar;
				/// <java-name>
				/// numberFormat
				/// </java-name>
				[Dot42.DexImport("numberFormat", "Ljava/text/NumberFormat;", AccessFlags = 4)]
				protected internal global::Java.Text.NumberFormat @numberformat;
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
				public const int DEFAULT = 2;
				/// <java-name>
				/// FULL
				/// </java-name>
				[Dot42.DexImport("FULL", "I", AccessFlags = 25)]
				public const int FULL = 0;
				/// <java-name>
				/// LONG
				/// </java-name>
				[Dot42.DexImport("LONG", "I", AccessFlags = 25)]
				public const int LONG = 1;
				/// <java-name>
				/// MEDIUM
				/// </java-name>
				[Dot42.DexImport("MEDIUM", "I", AccessFlags = 25)]
				public const int MEDIUM = 2;
				/// <java-name>
				/// SHORT
				/// </java-name>
				[Dot42.DexImport("SHORT", "I", AccessFlags = 25)]
				public const int SHORT = 3;
				/// <java-name>
				/// ERA_FIELD
				/// </java-name>
				[Dot42.DexImport("ERA_FIELD", "I", AccessFlags = 25)]
				public const int ERA_FIELD = 0;
				/// <java-name>
				/// YEAR_FIELD
				/// </java-name>
				[Dot42.DexImport("YEAR_FIELD", "I", AccessFlags = 25)]
				public const int YEAR_FIELD = 1;
				/// <java-name>
				/// MONTH_FIELD
				/// </java-name>
				[Dot42.DexImport("MONTH_FIELD", "I", AccessFlags = 25)]
				public const int MONTH_FIELD = 2;
				/// <java-name>
				/// DATE_FIELD
				/// </java-name>
				[Dot42.DexImport("DATE_FIELD", "I", AccessFlags = 25)]
				public const int DATE_FIELD = 3;
				/// <java-name>
				/// HOUR_OF_DAY1_FIELD
				/// </java-name>
				[Dot42.DexImport("HOUR_OF_DAY1_FIELD", "I", AccessFlags = 25)]
				public const int HOUR_OF_DAY1_FIELD = 4;
				/// <java-name>
				/// HOUR_OF_DAY0_FIELD
				/// </java-name>
				[Dot42.DexImport("HOUR_OF_DAY0_FIELD", "I", AccessFlags = 25)]
				public const int HOUR_OF_DAY0_FIELD = 5;
				/// <java-name>
				/// MINUTE_FIELD
				/// </java-name>
				[Dot42.DexImport("MINUTE_FIELD", "I", AccessFlags = 25)]
				public const int MINUTE_FIELD = 6;
				/// <java-name>
				/// SECOND_FIELD
				/// </java-name>
				[Dot42.DexImport("SECOND_FIELD", "I", AccessFlags = 25)]
				public const int SECOND_FIELD = 7;
				/// <java-name>
				/// MILLISECOND_FIELD
				/// </java-name>
				[Dot42.DexImport("MILLISECOND_FIELD", "I", AccessFlags = 25)]
				public const int MILLISECOND_FIELD = 8;
				/// <java-name>
				/// DAY_OF_WEEK_FIELD
				/// </java-name>
				[Dot42.DexImport("DAY_OF_WEEK_FIELD", "I", AccessFlags = 25)]
				public const int DAY_OF_WEEK_FIELD = 9;
				/// <java-name>
				/// DAY_OF_YEAR_FIELD
				/// </java-name>
				[Dot42.DexImport("DAY_OF_YEAR_FIELD", "I", AccessFlags = 25)]
				public const int DAY_OF_YEAR_FIELD = 10;
				/// <java-name>
				/// DAY_OF_WEEK_IN_MONTH_FIELD
				/// </java-name>
				[Dot42.DexImport("DAY_OF_WEEK_IN_MONTH_FIELD", "I", AccessFlags = 25)]
				public const int DAY_OF_WEEK_IN_MONTH_FIELD = 11;
				/// <java-name>
				/// WEEK_OF_YEAR_FIELD
				/// </java-name>
				[Dot42.DexImport("WEEK_OF_YEAR_FIELD", "I", AccessFlags = 25)]
				public const int WEEK_OF_YEAR_FIELD = 12;
				/// <java-name>
				/// WEEK_OF_MONTH_FIELD
				/// </java-name>
				[Dot42.DexImport("WEEK_OF_MONTH_FIELD", "I", AccessFlags = 25)]
				public const int WEEK_OF_MONTH_FIELD = 13;
				/// <java-name>
				/// AM_PM_FIELD
				/// </java-name>
				[Dot42.DexImport("AM_PM_FIELD", "I", AccessFlags = 25)]
				public const int AM_PM_FIELD = 14;
				/// <java-name>
				/// HOUR1_FIELD
				/// </java-name>
				[Dot42.DexImport("HOUR1_FIELD", "I", AccessFlags = 25)]
				public const int HOUR1_FIELD = 15;
				/// <java-name>
				/// HOUR0_FIELD
				/// </java-name>
				[Dot42.DexImport("HOUR0_FIELD", "I", AccessFlags = 25)]
				public const int HOUR0_FIELD = 16;
				/// <java-name>
				/// TIMEZONE_FIELD
				/// </java-name>
				[Dot42.DexImport("TIMEZONE_FIELD", "I", AccessFlags = 25)]
				public const int TIMEZONE_FIELD = 17;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal DateFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 17)]
				public override global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Date;)Ljava/lang/String;", AccessFlags = 17)]
				public string Format(global::Java.Util.Date date) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/Str" +
    "ingBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Lang.StringBuffer Format(global::Java.Util.Date date, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDateInstance
				/// </java-name>
				[Dot42.DexImport("getDateInstance", "(I)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateInstance(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getDateInstance
				/// </java-name>
				[Dot42.DexImport("getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateInstance(int int32, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getDateTimeInstance
				/// </java-name>
				[Dot42.DexImport("getDateTimeInstance", "(II)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateTimeInstance(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getDateTimeInstance
				/// </java-name>
				[Dot42.DexImport("getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetDateTimeInstance(int int32, int int321, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getTimeInstance
				/// </java-name>
				[Dot42.DexImport("getTimeInstance", "(I)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetTimeInstance(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
				}

				/// <java-name>
				/// getTimeInstance
				/// </java-name>
				[Dot42.DexImport("getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;", AccessFlags = 25)]
				public static global::Java.Text.DateFormat GetTimeInstance(int int32, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormat);
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Ljava/util/Date;", AccessFlags = 1)]
				public virtual global::Java.Util.Date Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", AccessFlags = 1025)]
				public abstract global::Java.Util.Date Parse(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object ParseObject(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
						[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Locale[]); }
				}

				/// <java-name>
				/// getCalendar
				/// </java-name>
				public virtual global::Java.Util.Calendar Calendar
				{
						[Dot42.DexImport("getCalendar", "()Ljava/util/Calendar;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Calendar); }
						[Dot42.DexImport("setCalendar", "(Ljava/util/Calendar;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDateInstance
				/// </java-name>
				public static global::Java.Text.DateFormat DateInstance
				{
						[Dot42.DexImport("getDateInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.DateFormat); }
				}

				/// <java-name>
				/// getDateTimeInstance
				/// </java-name>
				public static global::Java.Text.DateFormat DateTimeInstance
				{
						[Dot42.DexImport("getDateTimeInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.DateFormat); }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.DateFormat Instance
				{
						[Dot42.DexImport("getInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.DateFormat); }
				}

				/// <java-name>
				/// getNumberFormat
				/// </java-name>
				public virtual global::Java.Text.NumberFormat NumberFormat
				{
						[Dot42.DexImport("getNumberFormat", "()Ljava/text/NumberFormat;", AccessFlags = 1)]
						get{ return default(global::Java.Text.NumberFormat); }
						[Dot42.DexImport("setNumberFormat", "(Ljava/text/NumberFormat;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTimeInstance
				/// </java-name>
				public static global::Java.Text.DateFormat TimeInstance
				{
						[Dot42.DexImport("getTimeInstance", "()Ljava/text/DateFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.DateFormat); }
				}

				/// <java-name>
				/// getTimeZone
				/// </java-name>
				public virtual global::Java.Util.TimeZone TimeZone
				{
						[Dot42.DexImport("getTimeZone", "()Ljava/util/TimeZone;", AccessFlags = 1)]
						get{ return default(global::Java.Util.TimeZone); }
						[Dot42.DexImport("setTimeZone", "(Ljava/util/TimeZone;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isLenient
				/// </java-name>
				public virtual bool IsLenient
				{
						[Dot42.DexImport("isLenient", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setLenient", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// java/text/DateFormat$Field
				/// </java-name>
				[Dot42.DexImport("java/text/DateFormat$Field", AccessFlags = 9)]
				public partial class Field : global::Java.Text.Format.Field
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ERA
						/// </java-name>
						[Dot42.DexImport("ERA", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field ERA;
						/// <java-name>
						/// YEAR
						/// </java-name>
						[Dot42.DexImport("YEAR", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field YEAR;
						/// <java-name>
						/// MONTH
						/// </java-name>
						[Dot42.DexImport("MONTH", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field MONTH;
						/// <java-name>
						/// HOUR_OF_DAY0
						/// </java-name>
						[Dot42.DexImport("HOUR_OF_DAY0", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field HOUR_OF_DAY0;
						/// <java-name>
						/// HOUR_OF_DAY1
						/// </java-name>
						[Dot42.DexImport("HOUR_OF_DAY1", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field HOUR_OF_DAY1;
						/// <java-name>
						/// MINUTE
						/// </java-name>
						[Dot42.DexImport("MINUTE", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field MINUTE;
						/// <java-name>
						/// SECOND
						/// </java-name>
						[Dot42.DexImport("SECOND", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field SECOND;
						/// <java-name>
						/// MILLISECOND
						/// </java-name>
						[Dot42.DexImport("MILLISECOND", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field MILLISECOND;
						/// <java-name>
						/// DAY_OF_WEEK
						/// </java-name>
						[Dot42.DexImport("DAY_OF_WEEK", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field DAY_OF_WEEK;
						/// <java-name>
						/// DAY_OF_MONTH
						/// </java-name>
						[Dot42.DexImport("DAY_OF_MONTH", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field DAY_OF_MONTH;
						/// <java-name>
						/// DAY_OF_YEAR
						/// </java-name>
						[Dot42.DexImport("DAY_OF_YEAR", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field DAY_OF_YEAR;
						/// <java-name>
						/// DAY_OF_WEEK_IN_MONTH
						/// </java-name>
						[Dot42.DexImport("DAY_OF_WEEK_IN_MONTH", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field DAY_OF_WEEK_IN_MONTH;
						/// <java-name>
						/// WEEK_OF_YEAR
						/// </java-name>
						[Dot42.DexImport("WEEK_OF_YEAR", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field WEEK_OF_YEAR;
						/// <java-name>
						/// WEEK_OF_MONTH
						/// </java-name>
						[Dot42.DexImport("WEEK_OF_MONTH", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field WEEK_OF_MONTH;
						/// <java-name>
						/// AM_PM
						/// </java-name>
						[Dot42.DexImport("AM_PM", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field AM_PM;
						/// <java-name>
						/// HOUR0
						/// </java-name>
						[Dot42.DexImport("HOUR0", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field HOUR0;
						/// <java-name>
						/// HOUR1
						/// </java-name>
						[Dot42.DexImport("HOUR1", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field HOUR1;
						/// <java-name>
						/// TIME_ZONE
						/// </java-name>
						[Dot42.DexImport("TIME_ZONE", "Ljava/text/DateFormat$Field;", AccessFlags = 25)]
						public static readonly Field TIME_ZONE;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 4)]
						protected internal Field(string @string, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// ofCalendarField
						/// </java-name>
						[Dot42.DexImport("ofCalendarField", "(I)Ljava/text/DateFormat$Field;", AccessFlags = 9)]
						public static Field OfCalendarField(int int32) /* MethodBuilder.Create */ 
						{
								return default(Field);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Field() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getCalendarField
						/// </java-name>
						public virtual int CalendarField
						{
								[Dot42.DexImport("getCalendarField", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

				}

		}

		/// <java-name>
		/// java/text/DateFormatSymbols
		/// </java-name>
		[Dot42.DexImport("java/text/DateFormatSymbols", AccessFlags = 33)]
		public partial class DateFormatSymbols : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateFormatSymbols() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public DateFormatSymbols(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/text/DateFormatSymbols;", AccessFlags = 25)]
				public static global::Java.Text.DateFormatSymbols GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DateFormatSymbols);
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.DateFormatSymbols Instance
				{
						[Dot42.DexImport("getInstance", "()Ljava/text/DateFormatSymbols;", AccessFlags = 25)]
						get{ return default(global::Java.Text.DateFormatSymbols); }
				}

				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
						[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Locale[]); }
				}

				/// <java-name>
				/// getAmPmStrings
				/// </java-name>
				public virtual string[] AmPmStrings
				{
						[Dot42.DexImport("getAmPmStrings", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setAmPmStrings", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getEras
				/// </java-name>
				public virtual string[] Eras
				{
						[Dot42.DexImport("getEras", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setEras", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLocalPatternChars
				/// </java-name>
				public virtual string LocalPatternChars
				{
						[Dot42.DexImport("getLocalPatternChars", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setLocalPatternChars", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMonths
				/// </java-name>
				public virtual string[] Months
				{
						[Dot42.DexImport("getMonths", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setMonths", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getShortMonths
				/// </java-name>
				public virtual string[] ShortMonths
				{
						[Dot42.DexImport("getShortMonths", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setShortMonths", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getShortWeekdays
				/// </java-name>
				public virtual string[] ShortWeekdays
				{
						[Dot42.DexImport("getShortWeekdays", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setShortWeekdays", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getWeekdays
				/// </java-name>
				public virtual string[] Weekdays
				{
						[Dot42.DexImport("getWeekdays", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setWeekdays", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getZoneStrings
				/// </java-name>
				public virtual string[][] ZoneStrings
				{
						[Dot42.DexImport("getZoneStrings", "()[[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[][]); }
						[Dot42.DexImport("setZoneStrings", "([[Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/text/DecimalFormat
		/// </java-name>
		[Dot42.DexImport("java/text/DecimalFormat", AccessFlags = 33)]
		public partial class DecimalFormat : global::Java.Text.NumberFormat
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DecimalFormat() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public DecimalFormat(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/text/DecimalFormatSymbols;)V", AccessFlags = 1)]
				public DecimalFormat(string @string, global::Java.Text.DecimalFormatSymbols decimalFormatSymbols) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyLocalizedPattern
				/// </java-name>
				[Dot42.DexImport("applyLocalizedPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyLocalizedPattern(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyPattern
				/// </java-name>
				[Dot42.DexImport("applyPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyPattern(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// formatToCharacterIterator
				/// </java-name>
				[Dot42.DexImport("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public override global::Java.Text.IAttributedCharacterIterator FormatToCharacterIterator(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(double @double, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(long int64, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 17)]
				public override global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", AccessFlags = 1)]
				public override global::Java.Lang.Number Parse(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Number);
				}

				/// <java-name>
				/// toLocalizedPattern
				/// </java-name>
				[Dot42.DexImport("toLocalizedPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToLocalizedPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toPattern
				/// </java-name>
				[Dot42.DexImport("toPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDecimalFormatSymbols
				/// </java-name>
				public virtual global::Java.Text.DecimalFormatSymbols DecimalFormatSymbols
				{
						[Dot42.DexImport("getDecimalFormatSymbols", "()Ljava/text/DecimalFormatSymbols;", AccessFlags = 1)]
						get{ return default(global::Java.Text.DecimalFormatSymbols); }
						[Dot42.DexImport("setDecimalFormatSymbols", "(Ljava/text/DecimalFormatSymbols;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrency
				/// </java-name>
				public override global::Java.Util.Currency Currency
				{
						[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Currency); }
						[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getGroupingSize
				/// </java-name>
				public virtual int GroupingSize
				{
						[Dot42.DexImport("getGroupingSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setGroupingSize", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMultiplier
				/// </java-name>
				public virtual int Multiplier
				{
						[Dot42.DexImport("getMultiplier", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMultiplier", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNegativePrefix
				/// </java-name>
				public virtual string NegativePrefix
				{
						[Dot42.DexImport("getNegativePrefix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setNegativePrefix", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNegativeSuffix
				/// </java-name>
				public virtual string NegativeSuffix
				{
						[Dot42.DexImport("getNegativeSuffix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setNegativeSuffix", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPositivePrefix
				/// </java-name>
				public virtual string PositivePrefix
				{
						[Dot42.DexImport("getPositivePrefix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPositivePrefix", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPositiveSuffix
				/// </java-name>
				public virtual string PositiveSuffix
				{
						[Dot42.DexImport("getPositiveSuffix", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPositiveSuffix", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isDecimalSeparatorAlwaysShown
				/// </java-name>
				public virtual bool IsDecimalSeparatorAlwaysShown
				{
						[Dot42.DexImport("isDecimalSeparatorAlwaysShown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setDecimalSeparatorAlwaysShown", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isParseBigDecimal
				/// </java-name>
				public virtual bool IsParseBigDecimal
				{
						[Dot42.DexImport("isParseBigDecimal", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setParseBigDecimal", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isParseIntegerOnly
				/// </java-name>
				public override bool IsParseIntegerOnly
				{
						[Dot42.DexImport("isParseIntegerOnly", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setParseIntegerOnly", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isGroupingUsed
				/// </java-name>
				public override bool IsGroupingUsed
				{
						[Dot42.DexImport("isGroupingUsed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setGroupingUsed", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				public override global::Java.Math.RoundingMode RoundingMode
				{
						[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
						get{ return default(global::Java.Math.RoundingMode); }
						[Dot42.DexImport("setRoundingMode", "(Ljava/math/RoundingMode;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMaximumFractionDigits
				/// </java-name>
				public override int MaximumFractionDigits
				{
						[Dot42.DexImport("setMaximumFractionDigits", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMaximumIntegerDigits
				/// </java-name>
				public override int MaximumIntegerDigits
				{
						[Dot42.DexImport("setMaximumIntegerDigits", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMinimumFractionDigits
				/// </java-name>
				public override int MinimumFractionDigits
				{
						[Dot42.DexImport("setMinimumFractionDigits", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMinimumIntegerDigits
				/// </java-name>
				public override int MinimumIntegerDigits
				{
						[Dot42.DexImport("setMinimumIntegerDigits", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/text/DecimalFormatSymbols
		/// </java-name>
		[Dot42.DexImport("java/text/DecimalFormatSymbols", AccessFlags = 33)]
		public partial class DecimalFormatSymbols : global::Java.Lang.ICloneable, global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DecimalFormatSymbols() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public DecimalFormatSymbols(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;", AccessFlags = 9)]
				public static global::Java.Text.DecimalFormatSymbols GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.DecimalFormatSymbols);
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.DecimalFormatSymbols Instance
				{
						[Dot42.DexImport("getInstance", "()Ljava/text/DecimalFormatSymbols;", AccessFlags = 9)]
						get{ return default(global::Java.Text.DecimalFormatSymbols); }
				}

				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
						[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Locale[]); }
				}

				/// <java-name>
				/// getCurrency
				/// </java-name>
				public virtual global::Java.Util.Currency Currency
				{
						[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Currency); }
						[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInternationalCurrencySymbol
				/// </java-name>
				public virtual string InternationalCurrencySymbol
				{
						[Dot42.DexImport("getInternationalCurrencySymbol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setInternationalCurrencySymbol", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrencySymbol
				/// </java-name>
				public virtual string CurrencySymbol
				{
						[Dot42.DexImport("getCurrencySymbol", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setCurrencySymbol", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDecimalSeparator
				/// </java-name>
				public virtual char DecimalSeparator
				{
						[Dot42.DexImport("getDecimalSeparator", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setDecimalSeparator", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDigit
				/// </java-name>
				public virtual char Digit
				{
						[Dot42.DexImport("getDigit", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setDigit", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getGroupingSeparator
				/// </java-name>
				public virtual char GroupingSeparator
				{
						[Dot42.DexImport("getGroupingSeparator", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setGroupingSeparator", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInfinity
				/// </java-name>
				public virtual string Infinity
				{
						[Dot42.DexImport("getInfinity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setInfinity", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMinusSign
				/// </java-name>
				public virtual char MinusSign
				{
						[Dot42.DexImport("getMinusSign", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setMinusSign", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMonetaryDecimalSeparator
				/// </java-name>
				public virtual char MonetaryDecimalSeparator
				{
						[Dot42.DexImport("getMonetaryDecimalSeparator", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setMonetaryDecimalSeparator", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNaN
				/// </java-name>
				public virtual string NaN
				{
						[Dot42.DexImport("getNaN", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setNaN", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPatternSeparator
				/// </java-name>
				public virtual char PatternSeparator
				{
						[Dot42.DexImport("getPatternSeparator", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setPatternSeparator", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPercent
				/// </java-name>
				public virtual char Percent
				{
						[Dot42.DexImport("getPercent", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setPercent", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPerMill
				/// </java-name>
				public virtual char PerMill
				{
						[Dot42.DexImport("getPerMill", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setPerMill", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getZeroDigit
				/// </java-name>
				public virtual char ZeroDigit
				{
						[Dot42.DexImport("getZeroDigit", "()C", AccessFlags = 1)]
						get{ return default(char); }
						[Dot42.DexImport("setZeroDigit", "(C)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getExponentSeparator
				/// </java-name>
				public virtual string ExponentSeparator
				{
						[Dot42.DexImport("getExponentSeparator", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setExponentSeparator", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/text/FieldPosition
		/// </java-name>
		[Dot42.DexImport("java/text/FieldPosition", AccessFlags = 33)]
		public partial class FieldPosition
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public FieldPosition(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/text/Format$Field;)V", AccessFlags = 1)]
				public FieldPosition(global::Java.Text.Format.Field field) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/text/Format$Field;I)V", AccessFlags = 1)]
				public FieldPosition(global::Java.Text.Format.Field field, int int32) /* MethodBuilder.Create */ 
				{
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FieldPosition() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBeginIndex
				/// </java-name>
				public virtual int BeginIndex
				{
						[Dot42.DexImport("getBeginIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setBeginIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getEndIndex
				/// </java-name>
				public virtual int EndIndex
				{
						[Dot42.DexImport("getEndIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setEndIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getField
				/// </java-name>
				public virtual int Field
				{
						[Dot42.DexImport("getField", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFieldAttribute
				/// </java-name>
				public virtual global::Java.Text.Format.Field FieldAttribute
				{
						[Dot42.DexImport("getFieldAttribute", "()Ljava/text/Format$Field;", AccessFlags = 1)]
						get{ return default(global::Java.Text.Format.Field); }
				}

		}

		/// <java-name>
		/// java/text/Format
		/// </java-name>
		[Dot42.DexImport("java/text/Format", AccessFlags = 1057)]
		public abstract partial class Format : global::Java.Io.ISerializable, global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal Format() /* MethodBuilder.Create */ 
				{
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
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 17)]
				public string JavaFormat(object @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// formatToCharacterIterator
				/// </java-name>
				[Dot42.DexImport("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.IAttributedCharacterIterator FormatToCharacterIterator(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object ParseObject(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object ParseObject(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// java/text/Format$Field
				/// </java-name>
				[Dot42.DexImport("java/text/Format$Field", AccessFlags = 9)]
				public partial class Field : global::Java.Text.IAttributedCharacterIterator_Attribute
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
						protected internal Field(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Field() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// java/text/AttributedCharacterIterator
		/// </java-name>
		[Dot42.DexImport("java/text/AttributedCharacterIterator", AccessFlags = 1537)]
		public partial interface IAttributedCharacterIterator : global::Java.Text.ICharacterIterator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAttribute
				/// </java-name>
				[Dot42.DexImport("getAttribute", "(Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetAttribute(global::Java.Text.IAttributedCharacterIterator_Attribute iAttributedCharacterIterator_Attribute) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRunLimit
				/// </java-name>
				[Dot42.DexImport("getRunLimit", "(Ljava/text/AttributedCharacterIterator$Attribute;)I", AccessFlags = 1025)]
				int GetRunLimit(global::Java.Text.IAttributedCharacterIterator_Attribute iAttributedCharacterIterator_Attribute) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRunLimit
				/// </java-name>
				[Dot42.DexImport("getRunLimit", "(Ljava/util/Set;)I", AccessFlags = 1025, Signature = "(Ljava/util/Set<+Ljava/text/AttributedCharacterIterator$Attribute;>;)I")]
				int GetRunLimit(global::Java.Util.ISet<global::Java.Text.IAttributedCharacterIterator_Attribute> set) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRunStart
				/// </java-name>
				[Dot42.DexImport("getRunStart", "(Ljava/text/AttributedCharacterIterator$Attribute;)I", AccessFlags = 1025)]
				int GetRunStart(global::Java.Text.IAttributedCharacterIterator_Attribute iAttributedCharacterIterator_Attribute) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRunStart
				/// </java-name>
				[Dot42.DexImport("getRunStart", "(Ljava/util/Set;)I", AccessFlags = 1025, Signature = "(Ljava/util/Set<+Ljava/text/AttributedCharacterIterator$Attribute;>;)I")]
				int GetRunStart(global::Java.Util.ISet<global::Java.Text.IAttributedCharacterIterator_Attribute> set) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getAllAttributeKeys
				/// </java-name>
				global::Java.Util.ISet<global::Java.Text.IAttributedCharacterIterator_Attribute> AllAttributeKeys
				{
						[Dot42.DexImport("getAllAttributeKeys", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/text/AttributedCharacterIterator$Attribute;>;")]
						get;
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				global::Java.Util.IMap<global::Java.Text.IAttributedCharacterIterator_Attribute, object> Attributes
				{
						[Dot42.DexImport("getAttributes", "()Ljava/util/Map;", AccessFlags = 1025, Signature = "()Ljava/util/Map<Ljava/text/AttributedCharacterIterator$Attribute;Ljava/lang/Obje" +
    "ct;>;")]
						get;
				}

				/// <java-name>
				/// getRunLimit
				/// </java-name>
				int RunLimit
				{
						[Dot42.DexImport("getRunLimit", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRunStart
				/// </java-name>
				int RunStart
				{
						[Dot42.DexImport("getRunStart", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/text/AttributedCharacterIterator$Attribute
		/// </java-name>
		[Dot42.DexImport("java/text/AttributedCharacterIterator$Attribute", AccessFlags = 9)]
		public partial class IAttributedCharacterIterator_Attribute : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// INPUT_METHOD_SEGMENT
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_SEGMENT", "Ljava/text/AttributedCharacterIterator$Attribute;", AccessFlags = 25)]
				public static readonly global::Java.Text.IAttributedCharacterIterator_Attribute INPUT_METHOD_SEGMENT;
				/// <java-name>
				/// LANGUAGE
				/// </java-name>
				[Dot42.DexImport("LANGUAGE", "Ljava/text/AttributedCharacterIterator$Attribute;", AccessFlags = 25)]
				public static readonly global::Java.Text.IAttributedCharacterIterator_Attribute LANGUAGE;
				/// <java-name>
				/// READING
				/// </java-name>
				[Dot42.DexImport("READING", "Ljava/text/AttributedCharacterIterator$Attribute;", AccessFlags = 25)]
				public static readonly global::Java.Text.IAttributedCharacterIterator_Attribute READING;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal IAttributedCharacterIterator_Attribute(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 17)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 17)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readResolve
				/// </java-name>
				[Dot42.DexImport("readResolve", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object ReadResolve() /* MethodBuilder.Create */ 
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
				internal IAttributedCharacterIterator_Attribute() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getName
				/// </java-name>
				protected internal virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 4)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/text/CharacterIterator
		/// </java-name>
		[Dot42.DexImport("java/text/CharacterIterator", AccessFlags = 1537)]
		public partial interface ICharacterIterator : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// current
				/// </java-name>
				[Dot42.DexImport("current", "()C", AccessFlags = 1025)]
				char Current() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()C", AccessFlags = 1025)]
				char First() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()C", AccessFlags = 1025)]
				char Last() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()C", AccessFlags = 1025)]
				char Next() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()C", AccessFlags = 1025)]
				char Previous() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIndex
				/// </java-name>
				[Dot42.DexImport("setIndex", "(I)C", AccessFlags = 1025)]
				char SetIndex(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBeginIndex
				/// </java-name>
				int BeginIndex
				{
						[Dot42.DexImport("getBeginIndex", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getEndIndex
				/// </java-name>
				int EndIndex
				{
						[Dot42.DexImport("getEndIndex", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				int Index
				{
						[Dot42.DexImport("getIndex", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/text/CharacterIterator
		/// </java-name>
		[Dot42.DexImport("java/text/CharacterIterator", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ICharacterIteratorConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DONE
				/// </java-name>
				[Dot42.DexImport("DONE", "C", AccessFlags = 25)]
				public const char DONE = '￿';
		}

		/// <java-name>
		/// java/text/MessageFormat
		/// </java-name>
		[Dot42.DexImport("java/text/MessageFormat", AccessFlags = 33)]
		public partial class MessageFormat : global::Java.Text.Format
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Locale;)V", AccessFlags = 1)]
				public MessageFormat(string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MessageFormat(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyPattern
				/// </java-name>
				[Dot42.DexImport("applyPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyPattern(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// formatToCharacterIterator
				/// </java-name>
				[Dot42.DexImport("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public override global::Java.Text.IAttributedCharacterIterator FormatToCharacterIterator(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/" +
    "StringBuffer;", AccessFlags = 17)]
				public global::Java.Lang.StringBuffer Format(object[] @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 17)]
				public override global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 137)]
				public static string Format(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// setFormatByArgumentIndex
				/// </java-name>
				[Dot42.DexImport("setFormatByArgumentIndex", "(ILjava/text/Format;)V", AccessFlags = 1)]
				public virtual void SetFormatByArgumentIndex(int int32, global::Java.Text.Format format) /* MethodBuilder.Create */ 
				{
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)[Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object[] Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object[] Parse(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object ParseObject(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setFormat
				/// </java-name>
				[Dot42.DexImport("setFormat", "(ILjava/text/Format;)V", AccessFlags = 1)]
				public virtual void SetFormat(int int32, global::Java.Text.Format format) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toPattern
				/// </java-name>
				[Dot42.DexImport("toPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MessageFormat() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getFormats
				/// </java-name>
				public virtual global::Java.Text.Format[] Formats
				{
						[Dot42.DexImport("getFormats", "()[Ljava/text/Format;", AccessFlags = 1)]
						get{ return default(global::Java.Text.Format[]); }
						[Dot42.DexImport("setFormats", "([Ljava/text/Format;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFormatsByArgumentIndex
				/// </java-name>
				public virtual global::Java.Text.Format[] FormatsByArgumentIndex
				{
						[Dot42.DexImport("getFormatsByArgumentIndex", "()[Ljava/text/Format;", AccessFlags = 1)]
						get{ return default(global::Java.Text.Format[]); }
						[Dot42.DexImport("setFormatsByArgumentIndex", "([Ljava/text/Format;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				public virtual global::Java.Util.Locale Locale
				{
						[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Locale); }
						[Dot42.DexImport("setLocale", "(Ljava/util/Locale;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// java/text/MessageFormat$Field
				/// </java-name>
				[Dot42.DexImport("java/text/MessageFormat$Field", AccessFlags = 9)]
				public partial class Field : global::Java.Text.Format.Field
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ARGUMENT
						/// </java-name>
						[Dot42.DexImport("ARGUMENT", "Ljava/text/MessageFormat$Field;", AccessFlags = 25)]
						public static readonly Field ARGUMENT;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
						protected internal Field(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Field() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// java/text/Normalizer
		/// </java-name>
		[Dot42.DexImport("java/text/Normalizer", AccessFlags = 49)]
		public sealed partial class Normalizer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Normalizer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isNormalized
				/// </java-name>
				[Dot42.DexImport("isNormalized", "(Ljava/lang/CharSequence;Ljava/text/Normalizer$Form;)Z", AccessFlags = 9)]
				public static bool IsNormalized(global::Java.Lang.ICharSequence charSequence, global::Java.Text.Normalizer.Form form) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "(Ljava/lang/CharSequence;Ljava/text/Normalizer$Form;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Normalize(global::Java.Lang.ICharSequence charSequence, global::Java.Text.Normalizer.Form form) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// java/text/Normalizer$Form
				/// </java-name>
				[Dot42.DexImport("java/text/Normalizer$Form", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Ljava/text/Normalizer$Form;>;")]
				public sealed class Form
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// NFC
						/// </java-name>
						[Dot42.DexImport("NFC", "Ljava/text/Normalizer$Form;", AccessFlags = 16409)]
						public static readonly Form NFC;
						/// <java-name>
						/// NFD
						/// </java-name>
						[Dot42.DexImport("NFD", "Ljava/text/Normalizer$Form;", AccessFlags = 16409)]
						public static readonly Form NFD;
						/// <java-name>
						/// NFKC
						/// </java-name>
						[Dot42.DexImport("NFKC", "Ljava/text/Normalizer$Form;", AccessFlags = 16409)]
						public static readonly Form NFKC;
						/// <java-name>
						/// NFKD
						/// </java-name>
						[Dot42.DexImport("NFKD", "Ljava/text/Normalizer$Form;", AccessFlags = 16409)]
						public static readonly Form NFKD;
						private Form() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Ljava/text/Normalizer$Form;", AccessFlags = 9)]
						public static Form[] Values() /* MethodBuilder.Create */ 
						{
								return default(Form[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/text/Normalizer$Form;", AccessFlags = 9)]
						public static Form ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Form);
						}

				}

		}

		/// <java-name>
		/// java/text/NumberFormat
		/// </java-name>
		[Dot42.DexImport("java/text/NumberFormat", AccessFlags = 1057)]
		public abstract partial class NumberFormat : global::Java.Text.Format
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// INTEGER_FIELD
				/// </java-name>
				[Dot42.DexImport("INTEGER_FIELD", "I", AccessFlags = 25)]
				public const int INTEGER_FIELD = 0;
				/// <java-name>
				/// FRACTION_FIELD
				/// </java-name>
				[Dot42.DexImport("FRACTION_FIELD", "I", AccessFlags = 25)]
				public const int FRACTION_FIELD = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal NumberFormat() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(D)Ljava/lang/String;", AccessFlags = 17)]
				public string Format(double @double) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(DLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Lang.StringBuffer Format(double @double, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(J)Ljava/lang/String;", AccessFlags = 17)]
				public string Format(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(JLjava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", AccessFlags = 1025)]
				public abstract global::Java.Lang.StringBuffer Format(long int64, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/S" +
    "tringBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer JavaFormat(object @object, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
				}

				/// <java-name>
				/// getCurrencyInstance
				/// </java-name>
				[Dot42.DexImport("getCurrencyInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetCurrencyInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <java-name>
				/// getIntegerInstance
				/// </java-name>
				[Dot42.DexImport("getIntegerInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetIntegerInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <java-name>
				/// getNumberInstance
				/// </java-name>
				[Dot42.DexImport("getNumberInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetNumberInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
				}

				/// <java-name>
				/// getPercentInstance
				/// </java-name>
				[Dot42.DexImport("getPercentInstance", "(Ljava/util/Locale;)Ljava/text/NumberFormat;", AccessFlags = 9)]
				public static global::Java.Text.NumberFormat GetPercentInstance(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.NumberFormat);
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;)Ljava/lang/Number;", AccessFlags = 1)]
				public virtual global::Java.Lang.Number Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Number);
				}

				/// <java-name>
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Number;", AccessFlags = 1025)]
				public abstract global::Java.Lang.Number Parse(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// parseObject
				/// </java-name>
				[Dot42.DexImport("parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", AccessFlags = 17)]
				public override object ParseObject(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getAvailableLocales
				/// </java-name>
				public static global::Java.Util.Locale[] AvailableLocales
				{
						[Dot42.DexImport("getAvailableLocales", "()[Ljava/util/Locale;", AccessFlags = 9)]
						get{ return default(global::Java.Util.Locale[]); }
				}

				/// <java-name>
				/// getCurrency
				/// </java-name>
				public virtual global::Java.Util.Currency Currency
				{
						[Dot42.DexImport("getCurrency", "()Ljava/util/Currency;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Currency); }
						[Dot42.DexImport("setCurrency", "(Ljava/util/Currency;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrencyInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat CurrencyInstance
				{
						[Dot42.DexImport("getCurrencyInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.NumberFormat); }
				}

				/// <java-name>
				/// getIntegerInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat IntegerInstance
				{
						[Dot42.DexImport("getIntegerInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.NumberFormat); }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat Instance
				{
						[Dot42.DexImport("getInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.NumberFormat); }
				}

				/// <java-name>
				/// getMaximumFractionDigits
				/// </java-name>
				public virtual int MaximumFractionDigits
				{
						[Dot42.DexImport("getMaximumFractionDigits", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMaximumFractionDigits", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMaximumIntegerDigits
				/// </java-name>
				public virtual int MaximumIntegerDigits
				{
						[Dot42.DexImport("getMaximumIntegerDigits", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMaximumIntegerDigits", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMinimumFractionDigits
				/// </java-name>
				public virtual int MinimumFractionDigits
				{
						[Dot42.DexImport("getMinimumFractionDigits", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMinimumFractionDigits", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMinimumIntegerDigits
				/// </java-name>
				public virtual int MinimumIntegerDigits
				{
						[Dot42.DexImport("getMinimumIntegerDigits", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMinimumIntegerDigits", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNumberInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat NumberInstance
				{
						[Dot42.DexImport("getNumberInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.NumberFormat); }
				}

				/// <java-name>
				/// getPercentInstance
				/// </java-name>
				public static global::Java.Text.NumberFormat PercentInstance
				{
						[Dot42.DexImport("getPercentInstance", "()Ljava/text/NumberFormat;", AccessFlags = 25)]
						get{ return default(global::Java.Text.NumberFormat); }
				}

				/// <java-name>
				/// isGroupingUsed
				/// </java-name>
				public virtual bool IsGroupingUsed
				{
						[Dot42.DexImport("isGroupingUsed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setGroupingUsed", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isParseIntegerOnly
				/// </java-name>
				public virtual bool IsParseIntegerOnly
				{
						[Dot42.DexImport("isParseIntegerOnly", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setParseIntegerOnly", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRoundingMode
				/// </java-name>
				public virtual global::Java.Math.RoundingMode RoundingMode
				{
						[Dot42.DexImport("getRoundingMode", "()Ljava/math/RoundingMode;", AccessFlags = 1)]
						get{ return default(global::Java.Math.RoundingMode); }
						[Dot42.DexImport("setRoundingMode", "(Ljava/math/RoundingMode;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// java/text/NumberFormat$Field
				/// </java-name>
				[Dot42.DexImport("java/text/NumberFormat$Field", AccessFlags = 9)]
				public partial class Field : global::Java.Text.Format.Field
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SIGN
						/// </java-name>
						[Dot42.DexImport("SIGN", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field SIGN;
						/// <java-name>
						/// INTEGER
						/// </java-name>
						[Dot42.DexImport("INTEGER", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field INTEGER;
						/// <java-name>
						/// FRACTION
						/// </java-name>
						[Dot42.DexImport("FRACTION", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field FRACTION;
						/// <java-name>
						/// EXPONENT
						/// </java-name>
						[Dot42.DexImport("EXPONENT", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field EXPONENT;
						/// <java-name>
						/// EXPONENT_SIGN
						/// </java-name>
						[Dot42.DexImport("EXPONENT_SIGN", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field EXPONENT_SIGN;
						/// <java-name>
						/// EXPONENT_SYMBOL
						/// </java-name>
						[Dot42.DexImport("EXPONENT_SYMBOL", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field EXPONENT_SYMBOL;
						/// <java-name>
						/// DECIMAL_SEPARATOR
						/// </java-name>
						[Dot42.DexImport("DECIMAL_SEPARATOR", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field DECIMAL_SEPARATOR;
						/// <java-name>
						/// GROUPING_SEPARATOR
						/// </java-name>
						[Dot42.DexImport("GROUPING_SEPARATOR", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field GROUPING_SEPARATOR;
						/// <java-name>
						/// PERCENT
						/// </java-name>
						[Dot42.DexImport("PERCENT", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field PERCENT;
						/// <java-name>
						/// PERMILLE
						/// </java-name>
						[Dot42.DexImport("PERMILLE", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field PERMILLE;
						/// <java-name>
						/// CURRENCY
						/// </java-name>
						[Dot42.DexImport("CURRENCY", "Ljava/text/NumberFormat$Field;", AccessFlags = 25)]
						public static readonly Field CURRENCY;
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
						protected internal Field(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Field() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// java/text/ParseException
		/// </java-name>
		[Dot42.DexImport("java/text/ParseException", AccessFlags = 33)]
		public partial class ParseException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public ParseException(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ParseException() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getErrorOffset
				/// </java-name>
				public virtual int ErrorOffset
				{
						[Dot42.DexImport("getErrorOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/text/ParsePosition
		/// </java-name>
		[Dot42.DexImport("java/text/ParsePosition", AccessFlags = 33)]
		public partial class ParsePosition
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ParsePosition(int int32) /* MethodBuilder.Create */ 
				{
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ParsePosition() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getErrorIndex
				/// </java-name>
				public virtual int ErrorIndex
				{
						[Dot42.DexImport("getErrorIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setErrorIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				public virtual int Index
				{
						[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/text/RuleBasedCollator
		/// </java-name>
		[Dot42.DexImport("java/text/RuleBasedCollator", AccessFlags = 33)]
		public partial class RuleBasedCollator : global::Java.Text.Collator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public RuleBasedCollator(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCollationElementIterator
				/// </java-name>
				[Dot42.DexImport("getCollationElementIterator", "(Ljava/text/CharacterIterator;)Ljava/text/CollationElementIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.CollationElementIterator GetCollationElementIterator(global::Java.Text.ICharacterIterator characterIterator) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.CollationElementIterator);
				}

				/// <java-name>
				/// getCollationElementIterator
				/// </java-name>
				[Dot42.DexImport("getCollationElementIterator", "(Ljava/lang/String;)Ljava/text/CollationElementIterator;", AccessFlags = 1)]
				public virtual global::Java.Text.CollationElementIterator GetCollationElementIterator(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.CollationElementIterator);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 1)]
				public override int Compare(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCollationKey
				/// </java-name>
				[Dot42.DexImport("getCollationKey", "(Ljava/lang/String;)Ljava/text/CollationKey;", AccessFlags = 1)]
				public override global::Java.Text.CollationKey GetCollationKey(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.CollationKey);
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
				internal RuleBasedCollator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRules
				/// </java-name>
				public virtual string Rules
				{
						[Dot42.DexImport("getRules", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/text/SimpleDateFormat
		/// </java-name>
		[Dot42.DexImport("java/text/SimpleDateFormat", AccessFlags = 33)]
		public partial class SimpleDateFormat : global::Java.Text.DateFormat
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SimpleDateFormat() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SimpleDateFormat(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/text/DateFormatSymbols;)V", AccessFlags = 1)]
				public SimpleDateFormat(string @string, global::Java.Text.DateFormatSymbols dateFormatSymbols) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/util/Locale;)V", AccessFlags = 1)]
				public SimpleDateFormat(string @string, global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyLocalizedPattern
				/// </java-name>
				[Dot42.DexImport("applyLocalizedPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyLocalizedPattern(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyPattern
				/// </java-name>
				[Dot42.DexImport("applyPattern", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void ApplyPattern(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public override object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
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
				/// formatToCharacterIterator
				/// </java-name>
				[Dot42.DexImport("formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;", AccessFlags = 1)]
				public override global::Java.Text.IAttributedCharacterIterator FormatToCharacterIterator(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Text.IAttributedCharacterIterator);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Date;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/Str" +
    "ingBuffer;", AccessFlags = 1)]
				public override global::Java.Lang.StringBuffer Format(global::Java.Util.Date date, global::Java.Lang.StringBuffer stringBuffer, global::Java.Text.FieldPosition fieldPosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.StringBuffer);
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
				/// parse
				/// </java-name>
				[Dot42.DexImport("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/util/Date;", AccessFlags = 1)]
				public override global::Java.Util.Date Parse(string @string, global::Java.Text.ParsePosition parsePosition) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Date);
				}

				/// <java-name>
				/// toLocalizedPattern
				/// </java-name>
				[Dot42.DexImport("toLocalizedPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToLocalizedPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toPattern
				/// </java-name>
				[Dot42.DexImport("toPattern", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToPattern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// get2DigitYearStart
				/// </java-name>
				public virtual global::Java.Util.Date _2DigitYearStart
				{
						[Dot42.DexImport("get2DigitYearStart", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("set2DigitYearStart", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDateFormatSymbols
				/// </java-name>
				public virtual global::Java.Text.DateFormatSymbols DateFormatSymbols
				{
						[Dot42.DexImport("getDateFormatSymbols", "()Ljava/text/DateFormatSymbols;", AccessFlags = 1)]
						get{ return default(global::Java.Text.DateFormatSymbols); }
						[Dot42.DexImport("setDateFormatSymbols", "(Ljava/text/DateFormatSymbols;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/text/StringCharacterIterator
		/// </java-name>
		[Dot42.DexImport("java/text/StringCharacterIterator", AccessFlags = 49)]
		public sealed partial class StringCharacterIterator : global::Java.Text.ICharacterIterator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StringCharacterIterator(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public StringCharacterIterator(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;III)V", AccessFlags = 1)]
				public StringCharacterIterator(string @string, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// current
				/// </java-name>
				[Dot42.DexImport("current", "()C", AccessFlags = 1)]
				public char Current() /* MethodBuilder.Create */ 
				{
						return default(char);
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
				/// first
				/// </java-name>
				[Dot42.DexImport("first", "()C", AccessFlags = 1)]
				public char First() /* MethodBuilder.Create */ 
				{
						return default(char);
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
				/// last
				/// </java-name>
				[Dot42.DexImport("last", "()C", AccessFlags = 1)]
				public char Last() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "()C", AccessFlags = 1)]
				public char Next() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// previous
				/// </java-name>
				[Dot42.DexImport("previous", "()C", AccessFlags = 1)]
				public char Previous() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// setIndex
				/// </java-name>
				[Dot42.DexImport("setIndex", "(I)C", AccessFlags = 1)]
				public char SetIndex(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetText(string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StringCharacterIterator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBeginIndex
				/// </java-name>
				public int BeginIndex
				{
						[Dot42.DexImport("getBeginIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEndIndex
				/// </java-name>
				public int EndIndex
				{
						[Dot42.DexImport("getEndIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				public int Index
				{
						[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

}

