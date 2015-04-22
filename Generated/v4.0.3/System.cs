#pragma warning disable 1717
namespace System
{
		/// <java-name>
		/// java/lang/IllegalArgumentException
		/// </java-name>
		[Dot42.DexImport("java/lang/IllegalArgumentException", AccessFlags = 33)]
		public partial class ArgumentException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArgumentException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ArgumentException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ArgumentException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public ArgumentException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/ArithmeticException
		/// </java-name>
		[Dot42.DexImport("java/lang/ArithmeticException", AccessFlags = 33)]
		public partial class ArithmeticException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArithmeticException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ArithmeticException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/ArrayStoreException
		/// </java-name>
		[Dot42.DexImport("java/lang/ArrayStoreException", AccessFlags = 33)]
		public partial class ArrayTypeMismatchException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrayTypeMismatchException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ArrayTypeMismatchException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Boolean
		/// </java-name>
		[Dot42.DexImport("java/lang/Boolean", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/lang/Boolean;" +
    ">;")]
		public partial struct Boolean : global::Java.IO.ISerializable, global::System.IComparable<bool?>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <java-name>
				/// TRUE
				/// </java-name>
				[Dot42.DexImport("TRUE", "Ljava/lang/Boolean;", AccessFlags = 25)]
				public static readonly bool? TRUE;
				/// <java-name>
				/// FALSE
				/// </java-name>
				[Dot42.DexImport("FALSE", "Ljava/lang/Boolean;", AccessFlags = 25)]
				public static readonly bool? FALSE;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Boolean(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public Boolean(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// booleanValue
				/// </java-name>
				[Dot42.DexImport("booleanValue", "()Z", AccessFlags = 1)]
				public bool BooleanValue() /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Boolean;)I", AccessFlags = 1)]
				public int CompareTo(bool? boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// getBoolean
				/// </java-name>
				[Dot42.DexImport("getBoolean", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool GetBoolean(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// parseBoolean
				/// </java-name>
				[Dot42.DexImport("parseBoolean", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool JavaParse(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(Z)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;", AccessFlags = 9)]
				public static bool? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool?);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Z)Ljava/lang/Boolean;", AccessFlags = 9)]
				public static bool? ValueOf(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool?);
				}

		}

		public partial struct Byte
 /* scope: __custom__ */ 
		{
		}

		/// <java-name>
		/// java/lang/Character
		/// </java-name>
		[Dot42.DexImport("java/lang/Character", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/lang/Characte" +
    "r;>;")]
		public partial struct Char : global::Java.IO.ISerializable, global::System.IComparable<char?>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "C", AccessFlags = 25)]
				public const char MinValue = '\0';
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "C", AccessFlags = 25)]
				public const char MaxValue = '￿';
				/// <java-name>
				/// MIN_RADIX
				/// </java-name>
				[Dot42.DexImport("MIN_RADIX", "I", AccessFlags = 25)]
				public const int MIN_RADIX = 2;
				/// <java-name>
				/// MAX_RADIX
				/// </java-name>
				[Dot42.DexImport("MAX_RADIX", "I", AccessFlags = 25)]
				public const int MAX_RADIX = 36;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <java-name>
				/// UNASSIGNED
				/// </java-name>
				[Dot42.DexImport("UNASSIGNED", "B", AccessFlags = 25)]
				public const sbyte UNASSIGNED = 0;
				/// <java-name>
				/// UPPERCASE_LETTER
				/// </java-name>
				[Dot42.DexImport("UPPERCASE_LETTER", "B", AccessFlags = 25)]
				public const sbyte UPPERCASE_LETTER = 1;
				/// <java-name>
				/// LOWERCASE_LETTER
				/// </java-name>
				[Dot42.DexImport("LOWERCASE_LETTER", "B", AccessFlags = 25)]
				public const sbyte LOWERCASE_LETTER = 2;
				/// <java-name>
				/// TITLECASE_LETTER
				/// </java-name>
				[Dot42.DexImport("TITLECASE_LETTER", "B", AccessFlags = 25)]
				public const sbyte TITLECASE_LETTER = 3;
				/// <java-name>
				/// MODIFIER_LETTER
				/// </java-name>
				[Dot42.DexImport("MODIFIER_LETTER", "B", AccessFlags = 25)]
				public const sbyte MODIFIER_LETTER = 4;
				/// <java-name>
				/// OTHER_LETTER
				/// </java-name>
				[Dot42.DexImport("OTHER_LETTER", "B", AccessFlags = 25)]
				public const sbyte OTHER_LETTER = 5;
				/// <java-name>
				/// NON_SPACING_MARK
				/// </java-name>
				[Dot42.DexImport("NON_SPACING_MARK", "B", AccessFlags = 25)]
				public const sbyte NON_SPACING_MARK = 6;
				/// <java-name>
				/// ENCLOSING_MARK
				/// </java-name>
				[Dot42.DexImport("ENCLOSING_MARK", "B", AccessFlags = 25)]
				public const sbyte ENCLOSING_MARK = 7;
				/// <java-name>
				/// COMBINING_SPACING_MARK
				/// </java-name>
				[Dot42.DexImport("COMBINING_SPACING_MARK", "B", AccessFlags = 25)]
				public const sbyte COMBINING_SPACING_MARK = 8;
				/// <java-name>
				/// DECIMAL_DIGIT_NUMBER
				/// </java-name>
				[Dot42.DexImport("DECIMAL_DIGIT_NUMBER", "B", AccessFlags = 25)]
				public const sbyte DECIMAL_DIGIT_NUMBER = 9;
				/// <java-name>
				/// LETTER_NUMBER
				/// </java-name>
				[Dot42.DexImport("LETTER_NUMBER", "B", AccessFlags = 25)]
				public const sbyte LETTER_NUMBER = 10;
				/// <java-name>
				/// OTHER_NUMBER
				/// </java-name>
				[Dot42.DexImport("OTHER_NUMBER", "B", AccessFlags = 25)]
				public const sbyte OTHER_NUMBER = 11;
				/// <java-name>
				/// SPACE_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("SPACE_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte SPACE_SEPARATOR = 12;
				/// <java-name>
				/// LINE_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("LINE_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte LINE_SEPARATOR = 13;
				/// <java-name>
				/// PARAGRAPH_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("PARAGRAPH_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte PARAGRAPH_SEPARATOR = 14;
				/// <java-name>
				/// CONTROL
				/// </java-name>
				[Dot42.DexImport("CONTROL", "B", AccessFlags = 25)]
				public const sbyte CONTROL = 15;
				/// <java-name>
				/// FORMAT
				/// </java-name>
				[Dot42.DexImport("FORMAT", "B", AccessFlags = 25)]
				public const sbyte FORMAT = 16;
				/// <java-name>
				/// PRIVATE_USE
				/// </java-name>
				[Dot42.DexImport("PRIVATE_USE", "B", AccessFlags = 25)]
				public const sbyte PRIVATE_USE = 18;
				/// <java-name>
				/// SURROGATE
				/// </java-name>
				[Dot42.DexImport("SURROGATE", "B", AccessFlags = 25)]
				public const sbyte SURROGATE = 19;
				/// <java-name>
				/// DASH_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("DASH_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte DASH_PUNCTUATION = 20;
				/// <java-name>
				/// START_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("START_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte START_PUNCTUATION = 21;
				/// <java-name>
				/// END_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("END_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte END_PUNCTUATION = 22;
				/// <java-name>
				/// CONNECTOR_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("CONNECTOR_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte CONNECTOR_PUNCTUATION = 23;
				/// <java-name>
				/// OTHER_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("OTHER_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte OTHER_PUNCTUATION = 24;
				/// <java-name>
				/// MATH_SYMBOL
				/// </java-name>
				[Dot42.DexImport("MATH_SYMBOL", "B", AccessFlags = 25)]
				public const sbyte MATH_SYMBOL = 25;
				/// <java-name>
				/// CURRENCY_SYMBOL
				/// </java-name>
				[Dot42.DexImport("CURRENCY_SYMBOL", "B", AccessFlags = 25)]
				public const sbyte CURRENCY_SYMBOL = 26;
				/// <java-name>
				/// MODIFIER_SYMBOL
				/// </java-name>
				[Dot42.DexImport("MODIFIER_SYMBOL", "B", AccessFlags = 25)]
				public const sbyte MODIFIER_SYMBOL = 27;
				/// <java-name>
				/// OTHER_SYMBOL
				/// </java-name>
				[Dot42.DexImport("OTHER_SYMBOL", "B", AccessFlags = 25)]
				public const sbyte OTHER_SYMBOL = 28;
				/// <java-name>
				/// INITIAL_QUOTE_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("INITIAL_QUOTE_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte INITIAL_QUOTE_PUNCTUATION = 29;
				/// <java-name>
				/// FINAL_QUOTE_PUNCTUATION
				/// </java-name>
				[Dot42.DexImport("FINAL_QUOTE_PUNCTUATION", "B", AccessFlags = 25)]
				public const sbyte FINAL_QUOTE_PUNCTUATION = 30;
				/// <java-name>
				/// DIRECTIONALITY_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_UNDEFINED", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_UNDEFINED = -1;
				/// <java-name>
				/// DIRECTIONALITY_LEFT_TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_LEFT_TO_RIGHT", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_LEFT_TO_RIGHT = 0;
				/// <java-name>
				/// DIRECTIONALITY_RIGHT_TO_LEFT
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_RIGHT_TO_LEFT", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_RIGHT_TO_LEFT = 1;
				/// <java-name>
				/// DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_RIGHT_TO_LEFT_ARABIC = 2;
				/// <java-name>
				/// DIRECTIONALITY_EUROPEAN_NUMBER
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_EUROPEAN_NUMBER", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_EUROPEAN_NUMBER = 3;
				/// <java-name>
				/// DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_EUROPEAN_NUMBER_SEPARATOR = 4;
				/// <java-name>
				/// DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_EUROPEAN_NUMBER_TERMINATOR = 5;
				/// <java-name>
				/// DIRECTIONALITY_ARABIC_NUMBER
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_ARABIC_NUMBER", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_ARABIC_NUMBER = 6;
				/// <java-name>
				/// DIRECTIONALITY_COMMON_NUMBER_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_COMMON_NUMBER_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_COMMON_NUMBER_SEPARATOR = 7;
				/// <java-name>
				/// DIRECTIONALITY_NONSPACING_MARK
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_NONSPACING_MARK", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_NONSPACING_MARK = 8;
				/// <java-name>
				/// DIRECTIONALITY_BOUNDARY_NEUTRAL
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_BOUNDARY_NEUTRAL", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_BOUNDARY_NEUTRAL = 9;
				/// <java-name>
				/// DIRECTIONALITY_PARAGRAPH_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_PARAGRAPH_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_PARAGRAPH_SEPARATOR = 10;
				/// <java-name>
				/// DIRECTIONALITY_SEGMENT_SEPARATOR
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_SEGMENT_SEPARATOR", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_SEGMENT_SEPARATOR = 11;
				/// <java-name>
				/// DIRECTIONALITY_WHITESPACE
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_WHITESPACE", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_WHITESPACE = 12;
				/// <java-name>
				/// DIRECTIONALITY_OTHER_NEUTRALS
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_OTHER_NEUTRALS", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_OTHER_NEUTRALS = 13;
				/// <java-name>
				/// DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_LEFT_TO_RIGHT_EMBEDDING = 14;
				/// <java-name>
				/// DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_LEFT_TO_RIGHT_OVERRIDE = 15;
				/// <java-name>
				/// DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_RIGHT_TO_LEFT_EMBEDDING = 16;
				/// <java-name>
				/// DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_RIGHT_TO_LEFT_OVERRIDE = 17;
				/// <java-name>
				/// DIRECTIONALITY_POP_DIRECTIONAL_FORMAT
				/// </java-name>
				[Dot42.DexImport("DIRECTIONALITY_POP_DIRECTIONAL_FORMAT", "B", AccessFlags = 25)]
				public const sbyte DIRECTIONALITY_POP_DIRECTIONAL_FORMAT = 18;
				/// <java-name>
				/// MIN_HIGH_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MIN_HIGH_SURROGATE", "C", AccessFlags = 25)]
				public const char MIN_HIGH_SURROGATE = '\uD800';
				/// <java-name>
				/// MAX_HIGH_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MAX_HIGH_SURROGATE", "C", AccessFlags = 25)]
				public const char MAX_HIGH_SURROGATE = '\uDBFF';
				/// <java-name>
				/// MIN_LOW_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MIN_LOW_SURROGATE", "C", AccessFlags = 25)]
				public const char MIN_LOW_SURROGATE = '\uDC00';
				/// <java-name>
				/// MAX_LOW_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MAX_LOW_SURROGATE", "C", AccessFlags = 25)]
				public const char MAX_LOW_SURROGATE = '\uDFFF';
				/// <java-name>
				/// MIN_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MIN_SURROGATE", "C", AccessFlags = 25)]
				public const char MIN_SURROGATE = '\uD800';
				/// <java-name>
				/// MAX_SURROGATE
				/// </java-name>
				[Dot42.DexImport("MAX_SURROGATE", "C", AccessFlags = 25)]
				public const char MAX_SURROGATE = '\uDFFF';
				/// <java-name>
				/// MIN_SUPPLEMENTARY_CODE_POINT
				/// </java-name>
				[Dot42.DexImport("MIN_SUPPLEMENTARY_CODE_POINT", "I", AccessFlags = 25)]
				public const int MIN_SUPPLEMENTARY_CODE_POINT = 65536;
				/// <java-name>
				/// MIN_CODE_POINT
				/// </java-name>
				[Dot42.DexImport("MIN_CODE_POINT", "I", AccessFlags = 25)]
				public const int MIN_CODE_POINT = 0;
				/// <java-name>
				/// MAX_CODE_POINT
				/// </java-name>
				[Dot42.DexImport("MAX_CODE_POINT", "I", AccessFlags = 25)]
				public const int MAX_CODE_POINT = 1114111;
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 16;
				[Dot42.DexImport("<init>", "(C)V", AccessFlags = 1)]
				public Char(char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// charValue
				/// </java-name>
				[Dot42.DexImport("charValue", "()C", AccessFlags = 1)]
				public char CharValue() /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Character;)I", AccessFlags = 1)]
				public int CompareTo(char? @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(C)Ljava/lang/Character;", AccessFlags = 9)]
				public static char? ValueOf(char @char) /* MethodBuilder.Create */ 
				{
						return default(char?);
				}

				/// <java-name>
				/// isValidCodePoint
				/// </java-name>
				[Dot42.DexImport("isValidCodePoint", "(I)Z", AccessFlags = 9)]
				public static bool IsValidCodePoint(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSupplementaryCodePoint
				/// </java-name>
				[Dot42.DexImport("isSupplementaryCodePoint", "(I)Z", AccessFlags = 9)]
				public static bool IsSupplementaryCodePoint(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isHighSurrogate
				/// </java-name>
				[Dot42.DexImport("isHighSurrogate", "(C)Z", AccessFlags = 9)]
				public static bool IsHighSurrogate(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLowSurrogate
				/// </java-name>
				[Dot42.DexImport("isLowSurrogate", "(C)Z", AccessFlags = 9)]
				public static bool IsLowSurrogate(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSurrogatePair
				/// </java-name>
				[Dot42.DexImport("isSurrogatePair", "(CC)Z", AccessFlags = 9)]
				public static bool IsSurrogatePair(char @char, char char1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// charCount
				/// </java-name>
				[Dot42.DexImport("charCount", "(I)I", AccessFlags = 9)]
				public static int CharCount(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toCodePoint
				/// </java-name>
				[Dot42.DexImport("toCodePoint", "(CC)I", AccessFlags = 9)]
				public static int ToCodePoint(char @char, char char1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int CodePointAt(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "([CI)I", AccessFlags = 9)]
				public static int CodePointAt(char[] @char, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "([CII)I", AccessFlags = 9)]
				public static int CodePointAt(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int CodePointBefore(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "([CI)I", AccessFlags = 9)]
				public static int CodePointBefore(char[] @char, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "([CII)I", AccessFlags = 9)]
				public static int CodePointBefore(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toChars
				/// </java-name>
				[Dot42.DexImport("toChars", "(I[CI)I", AccessFlags = 9)]
				public static int ToChars(int int32, char[] @char, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toChars
				/// </java-name>
				[Dot42.DexImport("toChars", "(I)[C", AccessFlags = 9)]
				public static char[] ToChars(int int32) /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(Ljava/lang/CharSequence;II)I", AccessFlags = 9)]
				public static int CodePointCount(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "([CII)I", AccessFlags = 9)]
				public static int CodePointCount(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(Ljava/lang/CharSequence;II)I", AccessFlags = 9)]
				public static int OffsetByCodePoints(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "([CIIII)I", AccessFlags = 9)]
				public static int OffsetByCodePoints(char[] @char, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// digit
				/// </java-name>
				[Dot42.DexImport("digit", "(CI)I", AccessFlags = 9)]
				public static int Digit(char @char, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// digit
				/// </java-name>
				[Dot42.DexImport("digit", "(II)I", AccessFlags = 9)]
				public static int Digit(int int32, int int321) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// forDigit
				/// </java-name>
				[Dot42.DexImport("forDigit", "(II)C", AccessFlags = 9)]
				public static char ForDigit(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getNumericValue
				/// </java-name>
				[Dot42.DexImport("getNumericValue", "(C)I", AccessFlags = 9)]
				public static int GetNumericValue(char @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNumericValue
				/// </java-name>
				[Dot42.DexImport("getNumericValue", "(I)I", AccessFlags = 9)]
				public static int GetNumericValue(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(C)I", AccessFlags = 9)]
				public static int GetType(char @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "(I)I", AccessFlags = 9)]
				public static int GetType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDirectionality
				/// </java-name>
				[Dot42.DexImport("getDirectionality", "(C)B", AccessFlags = 9)]
				public static sbyte JavaGetDirectionality(char @char) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// getDirectionality
				/// </java-name>
				[Dot42.DexImport("getDirectionality", "(C)B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte GetDirectionality(char @char) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// getDirectionality
				/// </java-name>
				[Dot42.DexImport("getDirectionality", "(I)B", AccessFlags = 9)]
				public static sbyte JavaGetDirectionality(int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// getDirectionality
				/// </java-name>
				[Dot42.DexImport("getDirectionality", "(I)B", AccessFlags = 9, IgnoreFromJava = true)]
				public static byte GetDirectionality(int int32) /* MethodBuilder.Create */ 
				{
						return default(byte);
				}

				/// <java-name>
				/// isMirrored
				/// </java-name>
				[Dot42.DexImport("isMirrored", "(C)Z", AccessFlags = 9)]
				public static bool IsMirrored(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isMirrored
				/// </java-name>
				[Dot42.DexImport("isMirrored", "(I)Z", AccessFlags = 9)]
				public static bool IsMirrored(int int32) /* MethodBuilder.Create */ 
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
				/// isDefined
				/// </java-name>
				[Dot42.DexImport("isDefined", "(C)Z", AccessFlags = 9)]
				public static bool IsDefined(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDefined
				/// </java-name>
				[Dot42.DexImport("isDefined", "(I)Z", AccessFlags = 9)]
				public static bool IsDefined(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDigit
				/// </java-name>
				[Dot42.DexImport("isDigit", "(C)Z", AccessFlags = 9)]
				public static bool IsDigit(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isDigit
				/// </java-name>
				[Dot42.DexImport("isDigit", "(I)Z", AccessFlags = 9)]
				public static bool IsDigit(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isIdentifierIgnorable
				/// </java-name>
				[Dot42.DexImport("isIdentifierIgnorable", "(C)Z", AccessFlags = 9)]
				public static bool IsIdentifierIgnorable(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isIdentifierIgnorable
				/// </java-name>
				[Dot42.DexImport("isIdentifierIgnorable", "(I)Z", AccessFlags = 9)]
				public static bool IsIdentifierIgnorable(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isISOControl
				/// </java-name>
				[Dot42.DexImport("isISOControl", "(C)Z", AccessFlags = 9)]
				public static bool IsISOControl(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isISOControl
				/// </java-name>
				[Dot42.DexImport("isISOControl", "(I)Z", AccessFlags = 9)]
				public static bool IsISOControl(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isJavaIdentifierPart
				/// </java-name>
				[Dot42.DexImport("isJavaIdentifierPart", "(C)Z", AccessFlags = 9)]
				public static bool IsJavaIdentifierPart(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isJavaIdentifierPart
				/// </java-name>
				[Dot42.DexImport("isJavaIdentifierPart", "(I)Z", AccessFlags = 9)]
				public static bool IsJavaIdentifierPart(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isJavaIdentifierStart
				/// </java-name>
				[Dot42.DexImport("isJavaIdentifierStart", "(C)Z", AccessFlags = 9)]
				public static bool IsJavaIdentifierStart(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isJavaIdentifierStart
				/// </java-name>
				[Dot42.DexImport("isJavaIdentifierStart", "(I)Z", AccessFlags = 9)]
				public static bool IsJavaIdentifierStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isJavaLetter
				/// </java-name>
				[Dot42.DexImport("isJavaLetter", "(C)Z", AccessFlags = 9)]
				public static bool IsJavaLetter(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isJavaLetterOrDigit
				/// </java-name>
				[Dot42.DexImport("isJavaLetterOrDigit", "(C)Z", AccessFlags = 9)]
				public static bool IsJavaLetterOrDigit(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLetter
				/// </java-name>
				[Dot42.DexImport("isLetter", "(C)Z", AccessFlags = 9)]
				public static bool IsLetter(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLetter
				/// </java-name>
				[Dot42.DexImport("isLetter", "(I)Z", AccessFlags = 9)]
				public static bool IsLetter(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLetterOrDigit
				/// </java-name>
				[Dot42.DexImport("isLetterOrDigit", "(C)Z", AccessFlags = 9)]
				public static bool IsLetterOrDigit(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLetterOrDigit
				/// </java-name>
				[Dot42.DexImport("isLetterOrDigit", "(I)Z", AccessFlags = 9)]
				public static bool IsLetterOrDigit(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLowerCase
				/// </java-name>
				[Dot42.DexImport("isLowerCase", "(C)Z", AccessFlags = 9)]
				public static bool IsLower(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isLowerCase
				/// </java-name>
				[Dot42.DexImport("isLowerCase", "(I)Z", AccessFlags = 9)]
				public static bool IsLower(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSpace
				/// </java-name>
				[Dot42.DexImport("isSpace", "(C)Z", AccessFlags = 9)]
				public static bool IsSpace(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSpaceChar
				/// </java-name>
				[Dot42.DexImport("isSpaceChar", "(C)Z", AccessFlags = 9)]
				public static bool IsSpaceChar(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSpaceChar
				/// </java-name>
				[Dot42.DexImport("isSpaceChar", "(I)Z", AccessFlags = 9)]
				public static bool IsSpaceChar(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isTitleCase
				/// </java-name>
				[Dot42.DexImport("isTitleCase", "(C)Z", AccessFlags = 9)]
				public static bool IsTitleCase(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isTitleCase
				/// </java-name>
				[Dot42.DexImport("isTitleCase", "(I)Z", AccessFlags = 9)]
				public static bool IsTitleCase(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isUnicodeIdentifierPart
				/// </java-name>
				[Dot42.DexImport("isUnicodeIdentifierPart", "(C)Z", AccessFlags = 9)]
				public static bool IsUnicodeIdentifierPart(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isUnicodeIdentifierPart
				/// </java-name>
				[Dot42.DexImport("isUnicodeIdentifierPart", "(I)Z", AccessFlags = 9)]
				public static bool IsUnicodeIdentifierPart(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isUnicodeIdentifierStart
				/// </java-name>
				[Dot42.DexImport("isUnicodeIdentifierStart", "(C)Z", AccessFlags = 9)]
				public static bool IsUnicodeIdentifierStart(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isUnicodeIdentifierStart
				/// </java-name>
				[Dot42.DexImport("isUnicodeIdentifierStart", "(I)Z", AccessFlags = 9)]
				public static bool IsUnicodeIdentifierStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isUpperCase
				/// </java-name>
				[Dot42.DexImport("isUpperCase", "(C)Z", AccessFlags = 9)]
				public static bool IsUpper(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isUpperCase
				/// </java-name>
				[Dot42.DexImport("isUpperCase", "(I)Z", AccessFlags = 9)]
				public static bool IsUpper(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isWhitespace
				/// </java-name>
				[Dot42.DexImport("isWhitespace", "(C)Z", AccessFlags = 9)]
				public static bool IsWhitespace(char @char) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isWhitespace
				/// </java-name>
				[Dot42.DexImport("isWhitespace", "(I)Z", AccessFlags = 9)]
				public static bool IsWhitespace(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reverseBytes
				/// </java-name>
				[Dot42.DexImport("reverseBytes", "(C)C", AccessFlags = 9)]
				public static char ReverseBytes(char @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// toLowerCase
				/// </java-name>
				[Dot42.DexImport("toLowerCase", "(C)C", AccessFlags = 9)]
				public static char ToLowerCase(char @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// toLowerCase
				/// </java-name>
				[Dot42.DexImport("toLowerCase", "(I)I", AccessFlags = 9)]
				public static int ToLowerCase(int int32) /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(C)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(char @char) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toTitleCase
				/// </java-name>
				[Dot42.DexImport("toTitleCase", "(C)C", AccessFlags = 9)]
				public static char ToTitleCase(char @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// toTitleCase
				/// </java-name>
				[Dot42.DexImport("toTitleCase", "(I)I", AccessFlags = 9)]
				public static int ToTitleCase(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toUpperCase
				/// </java-name>
				[Dot42.DexImport("toUpperCase", "(C)C", AccessFlags = 9)]
				public static char ToUpperCase(char @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// toUpperCase
				/// </java-name>
				[Dot42.DexImport("toUpperCase", "(I)I", AccessFlags = 9)]
				public static int ToUpperCase(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// java/lang/Character$UnicodeBlock
				/// </java-name>
				[Dot42.DexImport("java/lang/Character$UnicodeBlock", AccessFlags = 25)]
				public sealed partial class UnicodeBlock : global::System.Char.Subset
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SURROGATES_AREA
						/// </java-name>
						[Dot42.DexImport("SURROGATES_AREA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SURROGATES_AREA;
						/// <java-name>
						/// BASIC_LATIN
						/// </java-name>
						[Dot42.DexImport("BASIC_LATIN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BASIC_LATIN;
						/// <java-name>
						/// LATIN_1_SUPPLEMENT
						/// </java-name>
						[Dot42.DexImport("LATIN_1_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LATIN_1_SUPPLEMENT;
						/// <java-name>
						/// LATIN_EXTENDED_A
						/// </java-name>
						[Dot42.DexImport("LATIN_EXTENDED_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LATIN_EXTENDED_A;
						/// <java-name>
						/// LATIN_EXTENDED_B
						/// </java-name>
						[Dot42.DexImport("LATIN_EXTENDED_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LATIN_EXTENDED_B;
						/// <java-name>
						/// IPA_EXTENSIONS
						/// </java-name>
						[Dot42.DexImport("IPA_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock IPA_EXTENSIONS;
						/// <java-name>
						/// SPACING_MODIFIER_LETTERS
						/// </java-name>
						[Dot42.DexImport("SPACING_MODIFIER_LETTERS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SPACING_MODIFIER_LETTERS;
						/// <java-name>
						/// COMBINING_DIACRITICAL_MARKS
						/// </java-name>
						[Dot42.DexImport("COMBINING_DIACRITICAL_MARKS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock COMBINING_DIACRITICAL_MARKS;
						/// <java-name>
						/// GREEK
						/// </java-name>
						[Dot42.DexImport("GREEK", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GREEK;
						/// <java-name>
						/// CYRILLIC
						/// </java-name>
						[Dot42.DexImport("CYRILLIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CYRILLIC;
						/// <java-name>
						/// CYRILLIC_SUPPLEMENTARY
						/// </java-name>
						[Dot42.DexImport("CYRILLIC_SUPPLEMENTARY", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CYRILLIC_SUPPLEMENTARY;
						/// <java-name>
						/// ARMENIAN
						/// </java-name>
						[Dot42.DexImport("ARMENIAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARMENIAN;
						/// <java-name>
						/// HEBREW
						/// </java-name>
						[Dot42.DexImport("HEBREW", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HEBREW;
						/// <java-name>
						/// ARABIC
						/// </java-name>
						[Dot42.DexImport("ARABIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARABIC;
						/// <java-name>
						/// SYRIAC
						/// </java-name>
						[Dot42.DexImport("SYRIAC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SYRIAC;
						/// <java-name>
						/// THAANA
						/// </java-name>
						[Dot42.DexImport("THAANA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock THAANA;
						/// <java-name>
						/// DEVANAGARI
						/// </java-name>
						[Dot42.DexImport("DEVANAGARI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock DEVANAGARI;
						/// <java-name>
						/// BENGALI
						/// </java-name>
						[Dot42.DexImport("BENGALI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BENGALI;
						/// <java-name>
						/// GURMUKHI
						/// </java-name>
						[Dot42.DexImport("GURMUKHI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GURMUKHI;
						/// <java-name>
						/// GUJARATI
						/// </java-name>
						[Dot42.DexImport("GUJARATI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GUJARATI;
						/// <java-name>
						/// ORIYA
						/// </java-name>
						[Dot42.DexImport("ORIYA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ORIYA;
						/// <java-name>
						/// TAMIL
						/// </java-name>
						[Dot42.DexImport("TAMIL", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAMIL;
						/// <java-name>
						/// TELUGU
						/// </java-name>
						[Dot42.DexImport("TELUGU", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TELUGU;
						/// <java-name>
						/// KANNADA
						/// </java-name>
						[Dot42.DexImport("KANNADA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KANNADA;
						/// <java-name>
						/// MALAYALAM
						/// </java-name>
						[Dot42.DexImport("MALAYALAM", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MALAYALAM;
						/// <java-name>
						/// SINHALA
						/// </java-name>
						[Dot42.DexImport("SINHALA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SINHALA;
						/// <java-name>
						/// THAI
						/// </java-name>
						[Dot42.DexImport("THAI", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock THAI;
						/// <java-name>
						/// LAO
						/// </java-name>
						[Dot42.DexImport("LAO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LAO;
						/// <java-name>
						/// TIBETAN
						/// </java-name>
						[Dot42.DexImport("TIBETAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TIBETAN;
						/// <java-name>
						/// MYANMAR
						/// </java-name>
						[Dot42.DexImport("MYANMAR", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MYANMAR;
						/// <java-name>
						/// GEORGIAN
						/// </java-name>
						[Dot42.DexImport("GEORGIAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GEORGIAN;
						/// <java-name>
						/// HANGUL_JAMO
						/// </java-name>
						[Dot42.DexImport("HANGUL_JAMO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HANGUL_JAMO;
						/// <java-name>
						/// ETHIOPIC
						/// </java-name>
						[Dot42.DexImport("ETHIOPIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ETHIOPIC;
						/// <java-name>
						/// CHEROKEE
						/// </java-name>
						[Dot42.DexImport("CHEROKEE", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CHEROKEE;
						/// <java-name>
						/// UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS
						/// </java-name>
						[Dot42.DexImport("UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock UNIFIED_CANADIAN_ABORIGINAL_SYLLABICS;
						/// <java-name>
						/// OGHAM
						/// </java-name>
						[Dot42.DexImport("OGHAM", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock OGHAM;
						/// <java-name>
						/// RUNIC
						/// </java-name>
						[Dot42.DexImport("RUNIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock RUNIC;
						/// <java-name>
						/// TAGALOG
						/// </java-name>
						[Dot42.DexImport("TAGALOG", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAGALOG;
						/// <java-name>
						/// HANUNOO
						/// </java-name>
						[Dot42.DexImport("HANUNOO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HANUNOO;
						/// <java-name>
						/// BUHID
						/// </java-name>
						[Dot42.DexImport("BUHID", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BUHID;
						/// <java-name>
						/// TAGBANWA
						/// </java-name>
						[Dot42.DexImport("TAGBANWA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAGBANWA;
						/// <java-name>
						/// KHMER
						/// </java-name>
						[Dot42.DexImport("KHMER", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KHMER;
						/// <java-name>
						/// MONGOLIAN
						/// </java-name>
						[Dot42.DexImport("MONGOLIAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MONGOLIAN;
						/// <java-name>
						/// LIMBU
						/// </java-name>
						[Dot42.DexImport("LIMBU", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LIMBU;
						/// <java-name>
						/// TAI_LE
						/// </java-name>
						[Dot42.DexImport("TAI_LE", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAI_LE;
						/// <java-name>
						/// KHMER_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("KHMER_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KHMER_SYMBOLS;
						/// <java-name>
						/// PHONETIC_EXTENSIONS
						/// </java-name>
						[Dot42.DexImport("PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock PHONETIC_EXTENSIONS;
						/// <java-name>
						/// LATIN_EXTENDED_ADDITIONAL
						/// </java-name>
						[Dot42.DexImport("LATIN_EXTENDED_ADDITIONAL", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LATIN_EXTENDED_ADDITIONAL;
						/// <java-name>
						/// GREEK_EXTENDED
						/// </java-name>
						[Dot42.DexImport("GREEK_EXTENDED", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GREEK_EXTENDED;
						/// <java-name>
						/// GENERAL_PUNCTUATION
						/// </java-name>
						[Dot42.DexImport("GENERAL_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GENERAL_PUNCTUATION;
						/// <java-name>
						/// SUPERSCRIPTS_AND_SUBSCRIPTS
						/// </java-name>
						[Dot42.DexImport("SUPERSCRIPTS_AND_SUBSCRIPTS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPERSCRIPTS_AND_SUBSCRIPTS;
						/// <java-name>
						/// CURRENCY_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("CURRENCY_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CURRENCY_SYMBOLS;
						/// <java-name>
						/// COMBINING_MARKS_FOR_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("COMBINING_MARKS_FOR_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock COMBINING_MARKS_FOR_SYMBOLS;
						/// <java-name>
						/// LETTERLIKE_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("LETTERLIKE_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LETTERLIKE_SYMBOLS;
						/// <java-name>
						/// NUMBER_FORMS
						/// </java-name>
						[Dot42.DexImport("NUMBER_FORMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock NUMBER_FORMS;
						/// <java-name>
						/// ARROWS
						/// </java-name>
						[Dot42.DexImport("ARROWS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARROWS;
						/// <java-name>
						/// MATHEMATICAL_OPERATORS
						/// </java-name>
						[Dot42.DexImport("MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MATHEMATICAL_OPERATORS;
						/// <java-name>
						/// MISCELLANEOUS_TECHNICAL
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_TECHNICAL", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_TECHNICAL;
						/// <java-name>
						/// CONTROL_PICTURES
						/// </java-name>
						[Dot42.DexImport("CONTROL_PICTURES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CONTROL_PICTURES;
						/// <java-name>
						/// OPTICAL_CHARACTER_RECOGNITION
						/// </java-name>
						[Dot42.DexImport("OPTICAL_CHARACTER_RECOGNITION", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock OPTICAL_CHARACTER_RECOGNITION;
						/// <java-name>
						/// ENCLOSED_ALPHANUMERICS
						/// </java-name>
						[Dot42.DexImport("ENCLOSED_ALPHANUMERICS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ENCLOSED_ALPHANUMERICS;
						/// <java-name>
						/// BOX_DRAWING
						/// </java-name>
						[Dot42.DexImport("BOX_DRAWING", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BOX_DRAWING;
						/// <java-name>
						/// BLOCK_ELEMENTS
						/// </java-name>
						[Dot42.DexImport("BLOCK_ELEMENTS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BLOCK_ELEMENTS;
						/// <java-name>
						/// GEOMETRIC_SHAPES
						/// </java-name>
						[Dot42.DexImport("GEOMETRIC_SHAPES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GEOMETRIC_SHAPES;
						/// <java-name>
						/// MISCELLANEOUS_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_SYMBOLS;
						/// <java-name>
						/// DINGBATS
						/// </java-name>
						[Dot42.DexImport("DINGBATS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock DINGBATS;
						/// <java-name>
						/// MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_A;
						/// <java-name>
						/// SUPPLEMENTAL_ARROWS_A
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTAL_ARROWS_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTAL_ARROWS_A;
						/// <java-name>
						/// BRAILLE_PATTERNS
						/// </java-name>
						[Dot42.DexImport("BRAILLE_PATTERNS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BRAILLE_PATTERNS;
						/// <java-name>
						/// SUPPLEMENTAL_ARROWS_B
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTAL_ARROWS_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTAL_ARROWS_B;
						/// <java-name>
						/// MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_MATHEMATICAL_SYMBOLS_B;
						/// <java-name>
						/// SUPPLEMENTAL_MATHEMATICAL_OPERATORS
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTAL_MATHEMATICAL_OPERATORS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTAL_MATHEMATICAL_OPERATORS;
						/// <java-name>
						/// MISCELLANEOUS_SYMBOLS_AND_ARROWS
						/// </java-name>
						[Dot42.DexImport("MISCELLANEOUS_SYMBOLS_AND_ARROWS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MISCELLANEOUS_SYMBOLS_AND_ARROWS;
						/// <java-name>
						/// CJK_RADICALS_SUPPLEMENT
						/// </java-name>
						[Dot42.DexImport("CJK_RADICALS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_RADICALS_SUPPLEMENT;
						/// <java-name>
						/// KANGXI_RADICALS
						/// </java-name>
						[Dot42.DexImport("KANGXI_RADICALS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KANGXI_RADICALS;
						/// <java-name>
						/// IDEOGRAPHIC_DESCRIPTION_CHARACTERS
						/// </java-name>
						[Dot42.DexImport("IDEOGRAPHIC_DESCRIPTION_CHARACTERS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock IDEOGRAPHIC_DESCRIPTION_CHARACTERS;
						/// <java-name>
						/// CJK_SYMBOLS_AND_PUNCTUATION
						/// </java-name>
						[Dot42.DexImport("CJK_SYMBOLS_AND_PUNCTUATION", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_SYMBOLS_AND_PUNCTUATION;
						/// <java-name>
						/// HIRAGANA
						/// </java-name>
						[Dot42.DexImport("HIRAGANA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HIRAGANA;
						/// <java-name>
						/// KATAKANA
						/// </java-name>
						[Dot42.DexImport("KATAKANA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KATAKANA;
						/// <java-name>
						/// BOPOMOFO
						/// </java-name>
						[Dot42.DexImport("BOPOMOFO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BOPOMOFO;
						/// <java-name>
						/// HANGUL_COMPATIBILITY_JAMO
						/// </java-name>
						[Dot42.DexImport("HANGUL_COMPATIBILITY_JAMO", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HANGUL_COMPATIBILITY_JAMO;
						/// <java-name>
						/// KANBUN
						/// </java-name>
						[Dot42.DexImport("KANBUN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KANBUN;
						/// <java-name>
						/// BOPOMOFO_EXTENDED
						/// </java-name>
						[Dot42.DexImport("BOPOMOFO_EXTENDED", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BOPOMOFO_EXTENDED;
						/// <java-name>
						/// KATAKANA_PHONETIC_EXTENSIONS
						/// </java-name>
						[Dot42.DexImport("KATAKANA_PHONETIC_EXTENSIONS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock KATAKANA_PHONETIC_EXTENSIONS;
						/// <java-name>
						/// ENCLOSED_CJK_LETTERS_AND_MONTHS
						/// </java-name>
						[Dot42.DexImport("ENCLOSED_CJK_LETTERS_AND_MONTHS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ENCLOSED_CJK_LETTERS_AND_MONTHS;
						/// <java-name>
						/// CJK_COMPATIBILITY
						/// </java-name>
						[Dot42.DexImport("CJK_COMPATIBILITY", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_COMPATIBILITY;
						/// <java-name>
						/// CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A
						/// </java-name>
						[Dot42.DexImport("CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_A;
						/// <java-name>
						/// YIJING_HEXAGRAM_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("YIJING_HEXAGRAM_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock YIJING_HEXAGRAM_SYMBOLS;
						/// <java-name>
						/// CJK_UNIFIED_IDEOGRAPHS
						/// </java-name>
						[Dot42.DexImport("CJK_UNIFIED_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_UNIFIED_IDEOGRAPHS;
						/// <java-name>
						/// YI_SYLLABLES
						/// </java-name>
						[Dot42.DexImport("YI_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock YI_SYLLABLES;
						/// <java-name>
						/// YI_RADICALS
						/// </java-name>
						[Dot42.DexImport("YI_RADICALS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock YI_RADICALS;
						/// <java-name>
						/// HANGUL_SYLLABLES
						/// </java-name>
						[Dot42.DexImport("HANGUL_SYLLABLES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HANGUL_SYLLABLES;
						/// <java-name>
						/// HIGH_SURROGATES
						/// </java-name>
						[Dot42.DexImport("HIGH_SURROGATES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HIGH_SURROGATES;
						/// <java-name>
						/// HIGH_PRIVATE_USE_SURROGATES
						/// </java-name>
						[Dot42.DexImport("HIGH_PRIVATE_USE_SURROGATES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HIGH_PRIVATE_USE_SURROGATES;
						/// <java-name>
						/// LOW_SURROGATES
						/// </java-name>
						[Dot42.DexImport("LOW_SURROGATES", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LOW_SURROGATES;
						/// <java-name>
						/// PRIVATE_USE_AREA
						/// </java-name>
						[Dot42.DexImport("PRIVATE_USE_AREA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock PRIVATE_USE_AREA;
						/// <java-name>
						/// CJK_COMPATIBILITY_IDEOGRAPHS
						/// </java-name>
						[Dot42.DexImport("CJK_COMPATIBILITY_IDEOGRAPHS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS;
						/// <java-name>
						/// ALPHABETIC_PRESENTATION_FORMS
						/// </java-name>
						[Dot42.DexImport("ALPHABETIC_PRESENTATION_FORMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ALPHABETIC_PRESENTATION_FORMS;
						/// <java-name>
						/// ARABIC_PRESENTATION_FORMS_A
						/// </java-name>
						[Dot42.DexImport("ARABIC_PRESENTATION_FORMS_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARABIC_PRESENTATION_FORMS_A;
						/// <java-name>
						/// VARIATION_SELECTORS
						/// </java-name>
						[Dot42.DexImport("VARIATION_SELECTORS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock VARIATION_SELECTORS;
						/// <java-name>
						/// COMBINING_HALF_MARKS
						/// </java-name>
						[Dot42.DexImport("COMBINING_HALF_MARKS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock COMBINING_HALF_MARKS;
						/// <java-name>
						/// CJK_COMPATIBILITY_FORMS
						/// </java-name>
						[Dot42.DexImport("CJK_COMPATIBILITY_FORMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_COMPATIBILITY_FORMS;
						/// <java-name>
						/// SMALL_FORM_VARIANTS
						/// </java-name>
						[Dot42.DexImport("SMALL_FORM_VARIANTS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SMALL_FORM_VARIANTS;
						/// <java-name>
						/// ARABIC_PRESENTATION_FORMS_B
						/// </java-name>
						[Dot42.DexImport("ARABIC_PRESENTATION_FORMS_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock ARABIC_PRESENTATION_FORMS_B;
						/// <java-name>
						/// HALFWIDTH_AND_FULLWIDTH_FORMS
						/// </java-name>
						[Dot42.DexImport("HALFWIDTH_AND_FULLWIDTH_FORMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock HALFWIDTH_AND_FULLWIDTH_FORMS;
						/// <java-name>
						/// SPECIALS
						/// </java-name>
						[Dot42.DexImport("SPECIALS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SPECIALS;
						/// <java-name>
						/// LINEAR_B_SYLLABARY
						/// </java-name>
						[Dot42.DexImport("LINEAR_B_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LINEAR_B_SYLLABARY;
						/// <java-name>
						/// LINEAR_B_IDEOGRAMS
						/// </java-name>
						[Dot42.DexImport("LINEAR_B_IDEOGRAMS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock LINEAR_B_IDEOGRAMS;
						/// <java-name>
						/// AEGEAN_NUMBERS
						/// </java-name>
						[Dot42.DexImport("AEGEAN_NUMBERS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock AEGEAN_NUMBERS;
						/// <java-name>
						/// OLD_ITALIC
						/// </java-name>
						[Dot42.DexImport("OLD_ITALIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock OLD_ITALIC;
						/// <java-name>
						/// GOTHIC
						/// </java-name>
						[Dot42.DexImport("GOTHIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock GOTHIC;
						/// <java-name>
						/// UGARITIC
						/// </java-name>
						[Dot42.DexImport("UGARITIC", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock UGARITIC;
						/// <java-name>
						/// DESERET
						/// </java-name>
						[Dot42.DexImport("DESERET", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock DESERET;
						/// <java-name>
						/// SHAVIAN
						/// </java-name>
						[Dot42.DexImport("SHAVIAN", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SHAVIAN;
						/// <java-name>
						/// OSMANYA
						/// </java-name>
						[Dot42.DexImport("OSMANYA", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock OSMANYA;
						/// <java-name>
						/// CYPRIOT_SYLLABARY
						/// </java-name>
						[Dot42.DexImport("CYPRIOT_SYLLABARY", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CYPRIOT_SYLLABARY;
						/// <java-name>
						/// BYZANTINE_MUSICAL_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("BYZANTINE_MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock BYZANTINE_MUSICAL_SYMBOLS;
						/// <java-name>
						/// MUSICAL_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("MUSICAL_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MUSICAL_SYMBOLS;
						/// <java-name>
						/// TAI_XUAN_JING_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("TAI_XUAN_JING_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAI_XUAN_JING_SYMBOLS;
						/// <java-name>
						/// MATHEMATICAL_ALPHANUMERIC_SYMBOLS
						/// </java-name>
						[Dot42.DexImport("MATHEMATICAL_ALPHANUMERIC_SYMBOLS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock MATHEMATICAL_ALPHANUMERIC_SYMBOLS;
						/// <java-name>
						/// CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B
						/// </java-name>
						[Dot42.DexImport("CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_UNIFIED_IDEOGRAPHS_EXTENSION_B;
						/// <java-name>
						/// CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT
						/// </java-name>
						[Dot42.DexImport("CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock CJK_COMPATIBILITY_IDEOGRAPHS_SUPPLEMENT;
						/// <java-name>
						/// TAGS
						/// </java-name>
						[Dot42.DexImport("TAGS", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock TAGS;
						/// <java-name>
						/// VARIATION_SELECTORS_SUPPLEMENT
						/// </java-name>
						[Dot42.DexImport("VARIATION_SELECTORS_SUPPLEMENT", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock VARIATION_SELECTORS_SUPPLEMENT;
						/// <java-name>
						/// SUPPLEMENTARY_PRIVATE_USE_AREA_A
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTARY_PRIVATE_USE_AREA_A", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_A;
						/// <java-name>
						/// SUPPLEMENTARY_PRIVATE_USE_AREA_B
						/// </java-name>
						[Dot42.DexImport("SUPPLEMENTARY_PRIVATE_USE_AREA_B", "Ljava/lang/Character$UnicodeBlock;", AccessFlags = 25)]
						public static readonly UnicodeBlock SUPPLEMENTARY_PRIVATE_USE_AREA_B;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal UnicodeBlock() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// forName
						/// </java-name>
						[Dot42.DexImport("forName", "(Ljava/lang/String;)Ljava/lang/Character$UnicodeBlock;", AccessFlags = 9)]
						public static UnicodeBlock ForName(string @string) /* MethodBuilder.Create */ 
						{
								return default(UnicodeBlock);
						}

						/// <java-name>
						/// of
						/// </java-name>
						[Dot42.DexImport("of", "(C)Ljava/lang/Character$UnicodeBlock;", AccessFlags = 9)]
						public static UnicodeBlock Of(char @char) /* MethodBuilder.Create */ 
						{
								return default(UnicodeBlock);
						}

						/// <java-name>
						/// of
						/// </java-name>
						[Dot42.DexImport("of", "(I)Ljava/lang/Character$UnicodeBlock;", AccessFlags = 9)]
						public static UnicodeBlock Of(int int32) /* MethodBuilder.Create */ 
						{
								return default(UnicodeBlock);
						}

				}

				/// <java-name>
				/// java/lang/Character$Subset
				/// </java-name>
				[Dot42.DexImport("java/lang/Character$Subset", AccessFlags = 9)]
				public partial class Subset
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
						protected internal Subset(string @string) /* MethodBuilder.Create */ 
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
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 17)]
						public override string ToString() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Subset() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		public partial class Delegate
 /* scope: __custom__ */ 
		{
		}

		/// <java-name>
		/// java/lang/Double
		/// </java-name>
		[Dot42.DexImport("java/lang/Double", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Double;>;")]
		public partial struct Double : global::System.IComparable<double?>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "D", AccessFlags = 25)]
				public const double MaxValue = 1.7976931348623157E+308D;
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "D", AccessFlags = 25)]
				public const double Epsilon = 4.94065645841247E-324D;
				/// <java-name>
				/// NaN
				/// </java-name>
				[Dot42.DexImport("NaN", "D", AccessFlags = 25)]
				public const double NaN = 0.0d / 0.0d;
				/// <java-name>
				/// POSITIVE_INFINITY
				/// </java-name>
				[Dot42.DexImport("POSITIVE_INFINITY", "D", AccessFlags = 25)]
				public static readonly double PositiveInfinity;
				/// <java-name>
				/// NEGATIVE_INFINITY
				/// </java-name>
				[Dot42.DexImport("NEGATIVE_INFINITY", "D", AccessFlags = 25)]
				public static readonly double NegativeInfinity;
				/// <java-name>
				/// MIN_NORMAL
				/// </java-name>
				[Dot42.DexImport("MIN_NORMAL", "D", AccessFlags = 25)]
				public const double MIN_NORMAL = 2.2250738585072014E-308D;
				/// <java-name>
				/// MAX_EXPONENT
				/// </java-name>
				[Dot42.DexImport("MAX_EXPONENT", "I", AccessFlags = 25)]
				public const int MAX_EXPONENT = 1023;
				/// <java-name>
				/// MIN_EXPONENT
				/// </java-name>
				[Dot42.DexImport("MIN_EXPONENT", "I", AccessFlags = 25)]
				public const int MIN_EXPONENT = -1022;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 64;
				[Dot42.DexImport("<init>", "(D)V", AccessFlags = 1)]
				public Double(double @double) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Double(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Double;)I", AccessFlags = 1)]
				public int CompareTo(double? @double) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// doubleToLongBits
				/// </java-name>
				[Dot42.DexImport("doubleToLongBits", "(D)J", AccessFlags = 265)]
				public static long DoubleToLongBits(double @double) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// doubleToRawLongBits
				/// </java-name>
				[Dot42.DexImport("doubleToRawLongBits", "(D)J", AccessFlags = 265)]
				public static long DoubleToRawLongBits(double @double) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isInfinite
				/// </java-name>
				[Dot42.DexImport("isInfinite", "(D)Z", AccessFlags = 9)]
				public static bool IsInfinity(double @double) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNaN
				/// </java-name>
				[Dot42.DexImport("isNaN", "()Z", AccessFlags = 1)]
				public bool IsNaN() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNaN
				/// </java-name>
				[Dot42.DexImport("isNaN", "(D)Z", AccessFlags = 9)]
				public static bool IsNaN(double @double) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// longBitsToDouble
				/// </java-name>
				[Dot42.DexImport("longBitsToDouble", "(J)D", AccessFlags = 265)]
				public static double LongBitsToDouble(long int64) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// parseDouble
				/// </java-name>
				[Dot42.DexImport("parseDouble", "(Ljava/lang/String;)D", AccessFlags = 9)]
				public static double Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(D)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(double @double) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Double;", AccessFlags = 9)]
				public static double? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(double?);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(DD)I", AccessFlags = 9)]
				public static int Compare(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(D)Ljava/lang/Double;", AccessFlags = 9)]
				public static double? ValueOf(double @double) /* MethodBuilder.Create */ 
				{
						return default(double?);
				}

				/// <java-name>
				/// toHexString
				/// </java-name>
				[Dot42.DexImport("toHexString", "(D)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHexString(double @double) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isInfinite
				/// </java-name>
				public bool IsInfinite
				{
						[Dot42.DexImport("isInfinite", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		public abstract partial class Enum
 /* scope: __custom__ */ 
		{
		}

		/// <java-name>
		/// java/lang/Throwable
		/// </java-name>
		[Dot42.DexImport("java/lang/Throwable", AccessFlags = 33)]
		public partial class Exception : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Exception() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Exception(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Exception(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public Exception(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fillInStackTrace
				/// </java-name>
				[Dot42.DexImport("fillInStackTrace", "()Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception FillInStackTrace() /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <java-name>
				/// getMessage
				/// </java-name>
				[Dot42.DexImport("getMessage", "()Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public virtual string GetMessage() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "()V", AccessFlags = 1)]
				public virtual void PrintStackTrace() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintStream;)V", AccessFlags = 1)]
				public virtual void PrintStackTrace(global::Java.IO.PrintStream printStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// printStackTrace
				/// </java-name>
				[Dot42.DexImport("printStackTrace", "(Ljava/io/PrintWriter;)V", AccessFlags = 1)]
				public virtual void PrintStackTrace(global::Java.IO.PrintWriter printWriter) /* MethodBuilder.Create */ 
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
				/// initCause
				/// </java-name>
				[Dot42.DexImport("initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", AccessFlags = 1)]
				public virtual global::System.Exception InitCause(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
						return default(global::System.Exception);
				}

				/// <java-name>
				/// getLocalizedMessage
				/// </java-name>
				public virtual string LocalizedMessage
				{
						[Dot42.DexImport("getLocalizedMessage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getStackTrace
				/// </java-name>
				public virtual global::Java.Lang.StackTraceElement[] JavaStackTrace
				{
						[Dot42.DexImport("getStackTrace", "()[Ljava/lang/StackTraceElement;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.StackTraceElement[]); }
						[Dot42.DexImport("setStackTrace", "([Ljava/lang/StackTraceElement;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCause
				/// </java-name>
				public virtual global::System.Exception Cause
				{
						[Dot42.DexImport("getCause", "()Ljava/lang/Throwable;", AccessFlags = 1)]
						get{ return default(global::System.Exception); }
				}

		}

		/// <java-name>
		/// java/lang/Comparable
		/// </java-name>
		[Dot42.DexImport("java/lang/Comparable", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface IComparable<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Object;)I", AccessFlags = 1025, Signature = "(TT;)I")]
				int CompareTo(T t) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/lang/IndexOutOfBoundsException
		/// </java-name>
		[Dot42.DexImport("java/lang/IndexOutOfBoundsException", AccessFlags = 33)]
		public partial class IndexOutOfRangeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IndexOutOfRangeException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IndexOutOfRangeException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Short
		/// </java-name>
		[Dot42.DexImport("java/lang/Short", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Short;>;")]
		public partial struct Int16 : global::System.IComparable<short?>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "S", AccessFlags = 25)]
				public const short MaxValue = 32767;
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "S", AccessFlags = 25)]
				public const short MinValue = -32768;
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 16;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Int16(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(S)V", AccessFlags = 1)]
				public Int16(short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Short;)I", AccessFlags = 1)]
				public int CompareTo(short? int16) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/Short;", AccessFlags = 9)]
				public static short? Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// parseShort
				/// </java-name>
				[Dot42.DexImport("parseShort", "(Ljava/lang/String;)S", AccessFlags = 9)]
				public static short Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// parseShort
				/// </java-name>
				[Dot42.DexImport("parseShort", "(Ljava/lang/String;I)S", AccessFlags = 9)]
				public static short Parse(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(S)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(short int16) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Short;", AccessFlags = 9)]
				public static short? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;", AccessFlags = 9)]
				public static short? ValueOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

				/// <java-name>
				/// reverseBytes
				/// </java-name>
				[Dot42.DexImport("reverseBytes", "(S)S", AccessFlags = 9)]
				public static short ReverseBytes(short int16) /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(S)Ljava/lang/Short;", AccessFlags = 9)]
				public static short? ValueOf(short int16) /* MethodBuilder.Create */ 
				{
						return default(short?);
				}

		}

		/// <java-name>
		/// java/lang/Integer
		/// </java-name>
		[Dot42.DexImport("java/lang/Integer", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Integer;>;")]
		public partial struct Int32 : global::System.IComparable<int?>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "I", AccessFlags = 25)]
				public const int MaxValue = 2147483647;
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "I", AccessFlags = 25)]
				public const int MinValue = -2147483648;
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 32;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Int32(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Int32(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Integer;)I", AccessFlags = 1)]
				public int CompareTo(int? int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(Ljava/lang/String;)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? GetInteger(string @string) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <java-name>
				/// getInteger
				/// </java-name>
				[Dot42.DexImport("getInteger", "(Ljava/lang/String;I)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? GetInteger(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// parseInt
				/// </java-name>
				[Dot42.DexImport("parseInt", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int JavaParse(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// parseInt
				/// </java-name>
				[Dot42.DexImport("parseInt", "(Ljava/lang/String;I)I", AccessFlags = 9)]
				public static int JavaParse(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toBinaryString
				/// </java-name>
				[Dot42.DexImport("toBinaryString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToBinaryString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toHexString
				/// </java-name>
				[Dot42.DexImport("toHexString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHexString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toOctalString
				/// </java-name>
				[Dot42.DexImport("toOctalString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToOctalString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(II)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;I)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? ValueOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

				/// <java-name>
				/// highestOneBit
				/// </java-name>
				[Dot42.DexImport("highestOneBit", "(I)I", AccessFlags = 9)]
				public static int HighestOneBit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lowestOneBit
				/// </java-name>
				[Dot42.DexImport("lowestOneBit", "(I)I", AccessFlags = 9)]
				public static int LowestOneBit(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// numberOfLeadingZeros
				/// </java-name>
				[Dot42.DexImport("numberOfLeadingZeros", "(I)I", AccessFlags = 9)]
				public static int NumberOfLeadingZeros(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// numberOfTrailingZeros
				/// </java-name>
				[Dot42.DexImport("numberOfTrailingZeros", "(I)I", AccessFlags = 9)]
				public static int NumberOfTrailingZeros(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// bitCount
				/// </java-name>
				[Dot42.DexImport("bitCount", "(I)I", AccessFlags = 9)]
				public static int BitCount(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// rotateLeft
				/// </java-name>
				[Dot42.DexImport("rotateLeft", "(II)I", AccessFlags = 9)]
				public static int RotateLeft(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// rotateRight
				/// </java-name>
				[Dot42.DexImport("rotateRight", "(II)I", AccessFlags = 9)]
				public static int RotateRight(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reverseBytes
				/// </java-name>
				[Dot42.DexImport("reverseBytes", "(I)I", AccessFlags = 9)]
				public static int ReverseBytes(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "(I)I", AccessFlags = 9)]
				public static int Reverse(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(I)I", AccessFlags = 9)]
				public static int Signum(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(I)Ljava/lang/Integer;", AccessFlags = 9)]
				public static int? ValueOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

		}

		/// <java-name>
		/// java/lang/Long
		/// </java-name>
		[Dot42.DexImport("java/lang/Long", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Long;>;")]
		public partial struct Int64 : global::System.IComparable<long?>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "J", AccessFlags = 25)]
				public const long MaxValue = 9223372036854775807;
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "J", AccessFlags = 25)]
				public const long MinValue = -9223372036854775808;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 64;
				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Int64(long int64) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Int64(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Long;)I", AccessFlags = 1)]
				public int CompareTo(long? int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? GetLong(string @string) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// getLong
				/// </java-name>
				[Dot42.DexImport("getLong", "(Ljava/lang/String;J)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? GetLong(string @string, long int64) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// parseLong
				/// </java-name>
				[Dot42.DexImport("parseLong", "(Ljava/lang/String;)J", AccessFlags = 9)]
				public static long Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// parseLong
				/// </java-name>
				[Dot42.DexImport("parseLong", "(Ljava/lang/String;I)J", AccessFlags = 9)]
				public static long Parse(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toBinaryString
				/// </java-name>
				[Dot42.DexImport("toBinaryString", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToBinaryString(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toHexString
				/// </java-name>
				[Dot42.DexImport("toHexString", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHexString(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toOctalString
				/// </java-name>
				[Dot42.DexImport("toOctalString", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToOctalString(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(JI)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(long int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? ValueOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

				/// <java-name>
				/// highestOneBit
				/// </java-name>
				[Dot42.DexImport("highestOneBit", "(J)J", AccessFlags = 9)]
				public static long HighestOneBit(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// lowestOneBit
				/// </java-name>
				[Dot42.DexImport("lowestOneBit", "(J)J", AccessFlags = 9)]
				public static long LowestOneBit(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// numberOfLeadingZeros
				/// </java-name>
				[Dot42.DexImport("numberOfLeadingZeros", "(J)I", AccessFlags = 9)]
				public static int NumberOfLeadingZeros(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// numberOfTrailingZeros
				/// </java-name>
				[Dot42.DexImport("numberOfTrailingZeros", "(J)I", AccessFlags = 9)]
				public static int NumberOfTrailingZeros(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// bitCount
				/// </java-name>
				[Dot42.DexImport("bitCount", "(J)I", AccessFlags = 9)]
				public static int BitCount(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// rotateLeft
				/// </java-name>
				[Dot42.DexImport("rotateLeft", "(JI)J", AccessFlags = 9)]
				public static long RotateLeft(long int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// rotateRight
				/// </java-name>
				[Dot42.DexImport("rotateRight", "(JI)J", AccessFlags = 9)]
				public static long RotateRight(long int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// reverseBytes
				/// </java-name>
				[Dot42.DexImport("reverseBytes", "(J)J", AccessFlags = 9)]
				public static long ReverseBytes(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "(J)J", AccessFlags = 9)]
				public static long Reverse(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(J)I", AccessFlags = 9)]
				public static int Signum(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(J)Ljava/lang/Long;", AccessFlags = 9)]
				public static long? ValueOf(long int64) /* MethodBuilder.Create */ 
				{
						return default(long?);
				}

		}

		public partial struct IntPtr
 /* scope: __custom__ */ 
		{
		}

		/// <java-name>
		/// java/lang/ClassCastException
		/// </java-name>
		[Dot42.DexImport("java/lang/ClassCastException", AccessFlags = 33)]
		public partial class InvalidCastException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InvalidCastException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InvalidCastException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Math
		/// </java-name>
		[Dot42.DexImport("java/lang/Math", AccessFlags = 49)]
		public sealed partial class Math
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// E
				/// </java-name>
				[Dot42.DexImport("E", "D", AccessFlags = 25)]
				public const double E = 2.7182818284590451D;
				/// <java-name>
				/// PI
				/// </java-name>
				[Dot42.DexImport("PI", "D", AccessFlags = 25)]
				public const double PI = 3.1415926535897931D;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Math() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(D)D", AccessFlags = 265)]
				public static double Abs(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(F)F", AccessFlags = 265)]
				public static float Abs(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(I)I", AccessFlags = 265)]
				public static int Abs(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// abs
				/// </java-name>
				[Dot42.DexImport("abs", "(J)J", AccessFlags = 265)]
				public static long Abs(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// acos
				/// </java-name>
				[Dot42.DexImport("acos", "(D)D", AccessFlags = 265)]
				public static double Acos(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// asin
				/// </java-name>
				[Dot42.DexImport("asin", "(D)D", AccessFlags = 265)]
				public static double Asin(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// atan
				/// </java-name>
				[Dot42.DexImport("atan", "(D)D", AccessFlags = 265)]
				public static double Atan(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// atan2
				/// </java-name>
				[Dot42.DexImport("atan2", "(DD)D", AccessFlags = 265)]
				public static double Atan2(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// cbrt
				/// </java-name>
				[Dot42.DexImport("cbrt", "(D)D", AccessFlags = 265)]
				public static double Cbrt(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// ceil
				/// </java-name>
				[Dot42.DexImport("ceil", "(D)D", AccessFlags = 265)]
				public static double Ceiling(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// cos
				/// </java-name>
				[Dot42.DexImport("cos", "(D)D", AccessFlags = 265)]
				public static double Cos(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// cosh
				/// </java-name>
				[Dot42.DexImport("cosh", "(D)D", AccessFlags = 265)]
				public static double Cosh(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// exp
				/// </java-name>
				[Dot42.DexImport("exp", "(D)D", AccessFlags = 265)]
				public static double Exp(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// expm1
				/// </java-name>
				[Dot42.DexImport("expm1", "(D)D", AccessFlags = 265)]
				public static double Expm1(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// floor
				/// </java-name>
				[Dot42.DexImport("floor", "(D)D", AccessFlags = 265)]
				public static double Floor(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// hypot
				/// </java-name>
				[Dot42.DexImport("hypot", "(DD)D", AccessFlags = 265)]
				public static double Hypot(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// IEEEremainder
				/// </java-name>
				[Dot42.DexImport("IEEEremainder", "(DD)D", AccessFlags = 265)]
				public static double IEEEremainder(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// log
				/// </java-name>
				[Dot42.DexImport("log", "(D)D", AccessFlags = 265)]
				public static double Log(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// log10
				/// </java-name>
				[Dot42.DexImport("log10", "(D)D", AccessFlags = 265)]
				public static double Log10(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// log1p
				/// </java-name>
				[Dot42.DexImport("log1p", "(D)D", AccessFlags = 265)]
				public static double Log1p(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(DD)D", AccessFlags = 9)]
				public static double Max(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(FF)F", AccessFlags = 9)]
				public static float Max(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(II)I", AccessFlags = 265)]
				public static int Max(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// max
				/// </java-name>
				[Dot42.DexImport("max", "(JJ)J", AccessFlags = 9)]
				public static long Max(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(DD)D", AccessFlags = 9)]
				public static double Min(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(FF)F", AccessFlags = 9)]
				public static float Min(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(II)I", AccessFlags = 265)]
				public static int Min(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// min
				/// </java-name>
				[Dot42.DexImport("min", "(JJ)J", AccessFlags = 9)]
				public static long Min(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// pow
				/// </java-name>
				[Dot42.DexImport("pow", "(DD)D", AccessFlags = 265)]
				public static double Pow(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// rint
				/// </java-name>
				[Dot42.DexImport("rint", "(D)D", AccessFlags = 265)]
				public static double Rint(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(D)J", AccessFlags = 9)]
				public static long Round(double @double) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// round
				/// </java-name>
				[Dot42.DexImport("round", "(F)I", AccessFlags = 9)]
				public static int Round(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(D)D", AccessFlags = 9)]
				public static double Signum(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// signum
				/// </java-name>
				[Dot42.DexImport("signum", "(F)F", AccessFlags = 9)]
				public static float Signum(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// sin
				/// </java-name>
				[Dot42.DexImport("sin", "(D)D", AccessFlags = 265)]
				public static double Sin(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// sinh
				/// </java-name>
				[Dot42.DexImport("sinh", "(D)D", AccessFlags = 265)]
				public static double Sinh(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// sqrt
				/// </java-name>
				[Dot42.DexImport("sqrt", "(D)D", AccessFlags = 265)]
				public static double Sqrt(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// tan
				/// </java-name>
				[Dot42.DexImport("tan", "(D)D", AccessFlags = 265)]
				public static double Tan(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// tanh
				/// </java-name>
				[Dot42.DexImport("tanh", "(D)D", AccessFlags = 265)]
				public static double Tanh(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// random
				/// </java-name>
				[Dot42.DexImport("random", "()D", AccessFlags = 41)]
				public static double Random() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// toRadians
				/// </java-name>
				[Dot42.DexImport("toRadians", "(D)D", AccessFlags = 9)]
				public static double ToRadians(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// toDegrees
				/// </java-name>
				[Dot42.DexImport("toDegrees", "(D)D", AccessFlags = 9)]
				public static double ToDegrees(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// ulp
				/// </java-name>
				[Dot42.DexImport("ulp", "(D)D", AccessFlags = 9)]
				public static double Ulp(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// ulp
				/// </java-name>
				[Dot42.DexImport("ulp", "(F)F", AccessFlags = 9)]
				public static float Ulp(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// copySign
				/// </java-name>
				[Dot42.DexImport("copySign", "(DD)D", AccessFlags = 9)]
				public static double CopySign(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// copySign
				/// </java-name>
				[Dot42.DexImport("copySign", "(FF)F", AccessFlags = 9)]
				public static float CopySign(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getExponent
				/// </java-name>
				[Dot42.DexImport("getExponent", "(F)I", AccessFlags = 9)]
				public static int GetExponent(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getExponent
				/// </java-name>
				[Dot42.DexImport("getExponent", "(D)I", AccessFlags = 9)]
				public static int GetExponent(double @double) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextAfter
				/// </java-name>
				[Dot42.DexImport("nextAfter", "(DD)D", AccessFlags = 9)]
				public static double NextAfter(double @double, double double1) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextAfter
				/// </java-name>
				[Dot42.DexImport("nextAfter", "(FD)F", AccessFlags = 9)]
				public static float NextAfter(float single, double @double) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// nextUp
				/// </java-name>
				[Dot42.DexImport("nextUp", "(D)D", AccessFlags = 9)]
				public static double NextUp(double @double) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextUp
				/// </java-name>
				[Dot42.DexImport("nextUp", "(F)F", AccessFlags = 9)]
				public static float NextUp(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// scalb
				/// </java-name>
				[Dot42.DexImport("scalb", "(DI)D", AccessFlags = 9)]
				public static double Scalb(double @double, int int32) /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// scalb
				/// </java-name>
				[Dot42.DexImport("scalb", "(FI)F", AccessFlags = 9)]
				public static float Scalb(float single, int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// java/lang/NoSuchFieldError
		/// </java-name>
		[Dot42.DexImport("java/lang/NoSuchFieldError", AccessFlags = 33)]
		public partial class MissingFieldException : global::Java.Lang.IncompatibleClassChangeError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MissingFieldException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingFieldException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/NoSuchMethodError
		/// </java-name>
		[Dot42.DexImport("java/lang/NoSuchMethodError", AccessFlags = 33)]
		public partial class MissingMethodException : global::Java.Lang.IncompatibleClassChangeError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MissingMethodException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public MissingMethodException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		public partial class MulticastDelegate : global::System.Delegate
 /* scope: __custom__ */ 
		{
		}

		/// <java-name>
		/// java/lang/NullPointerException
		/// </java-name>
		[Dot42.DexImport("java/lang/NullPointerException", AccessFlags = 33)]
		public partial class NullReferenceException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NullReferenceException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public NullReferenceException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Object
		/// </java-name>
		[Dot42.DexImport("java/lang/Object", AccessFlags = 33)]
		public partial class Object
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Object() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public virtual bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Object() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getClass
				/// </java-name>
				[Dot42.DexImport("getClass", "()Ljava/lang/Class;", AccessFlags = 273, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type JavaGetClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 257)]
				public virtual int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// notify
				/// </java-name>
				[Dot42.DexImport("notify", "()V", AccessFlags = 273)]
				public void JavaNotify() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyAll
				/// </java-name>
				[Dot42.DexImport("notifyAll", "()V", AccessFlags = 273)]
				public void JavaNotifyAll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// wait
				/// </java-name>
				[Dot42.DexImport("wait", "()V", AccessFlags = 17)]
				public void JavaWait() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// wait
				/// </java-name>
				[Dot42.DexImport("wait", "(J)V", AccessFlags = 17)]
				public void JavaWait(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// wait
				/// </java-name>
				[Dot42.DexImport("wait", "(JI)V", AccessFlags = 273)]
				public void JavaWait(long int64, int int32) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/OutOfMemoryError
		/// </java-name>
		[Dot42.DexImport("java/lang/OutOfMemoryError", AccessFlags = 33)]
		public partial class OutOfMemoryException : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OutOfMemoryException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public OutOfMemoryException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/util/Random
		/// </java-name>
		[Dot42.DexImport("java/util/Random", AccessFlags = 33)]
		public partial class Random : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Random() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(J)V", AccessFlags = 1)]
				public Random(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// next
				/// </java-name>
				[Dot42.DexImport("next", "(I)I", AccessFlags = 36)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal virtual int JavaNext(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextBoolean
				/// </java-name>
				[Dot42.DexImport("nextBoolean", "()Z", AccessFlags = 1)]
				public virtual bool NextBoolean() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// nextBytes
				/// </java-name>
				[Dot42.DexImport("nextBytes", "([B)V", AccessFlags = 1)]
				public virtual void NextBytes(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nextBytes
				/// </java-name>
				[Dot42.DexImport("nextBytes", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void NextBytes(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// nextDouble
				/// </java-name>
				[Dot42.DexImport("nextDouble", "()D", AccessFlags = 1)]
				public virtual double NextDouble() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextFloat
				/// </java-name>
				[Dot42.DexImport("nextFloat", "()F", AccessFlags = 1)]
				public virtual float NextFloat() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// nextGaussian
				/// </java-name>
				[Dot42.DexImport("nextGaussian", "()D", AccessFlags = 33)]
				public virtual double NextGaussian() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "()I", AccessFlags = 1)]
				public virtual int NextInt() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextInt
				/// </java-name>
				[Dot42.DexImport("nextInt", "(I)I", AccessFlags = 1)]
				public virtual int NextInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// nextLong
				/// </java-name>
				[Dot42.DexImport("nextLong", "()J", AccessFlags = 1)]
				public virtual long NextLong() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setSeed
				/// </java-name>
				[Dot42.DexImport("setSeed", "(J)V", AccessFlags = 33)]
				public virtual void SetSeed(long int64) /* MethodBuilder.Create */ 
				{
				}

		}

		public partial struct RuntimeArgumentHandle
 /* scope: __custom__ */ 
		{
		}

		public partial struct RuntimeFieldHandle
 /* scope: __custom__ */ 
		{
		}

		public partial struct RuntimeMethodHandle
 /* scope: __custom__ */ 
		{
		}

		public partial struct RuntimeTypeHandle
 /* scope: __custom__ */ 
		{
		}

		/// <java-name>
		/// java/lang/Byte
		/// </java-name>
		[Dot42.DexImport("java/lang/Byte", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Byte;>;")]
		public partial struct SByte : global::System.IComparable<sbyte?>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "B", AccessFlags = 25)]
				public const sbyte MaxValue = 127;
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "B", AccessFlags = 25)]
				public const sbyte MinValue = -128;
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 8;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				[Dot42.DexImport("<init>", "(B)V", AccessFlags = 1)]
				public SByte(sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SByte(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Byte;)I", AccessFlags = 1)]
				public int CompareTo(sbyte? sByte) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// decode
				/// </java-name>
				[Dot42.DexImport("decode", "(Ljava/lang/String;)Ljava/lang/Byte;", AccessFlags = 9)]
				public static sbyte? Decode(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// parseByte
				/// </java-name>
				[Dot42.DexImport("parseByte", "(Ljava/lang/String;)B", AccessFlags = 9)]
				public static sbyte Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// parseByte
				/// </java-name>
				[Dot42.DexImport("parseByte", "(Ljava/lang/String;I)B", AccessFlags = 9)]
				public static sbyte Parse(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(B)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(sbyte sByte) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Byte;", AccessFlags = 9)]
				public static sbyte? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;I)Ljava/lang/Byte;", AccessFlags = 9)]
				public static sbyte? ValueOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(B)Ljava/lang/Byte;", AccessFlags = 9)]
				public static sbyte? ValueOf(sbyte sByte) /* MethodBuilder.Create */ 
				{
						return default(sbyte?);
				}

		}

		/// <java-name>
		/// java/lang/Float
		/// </java-name>
		[Dot42.DexImport("java/lang/Float", AccessFlags = 49, Signature = "Ljava/lang/Number;Ljava/lang/Comparable<Ljava/lang/Float;>;")]
		public partial struct Single : global::System.IComparable<float?>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MAX_VALUE
				/// </java-name>
				[Dot42.DexImport("MAX_VALUE", "F", AccessFlags = 25)]
				public const float MaxValue = 3.402823E+38F;
				/// <java-name>
				/// MIN_VALUE
				/// </java-name>
				[Dot42.DexImport("MIN_VALUE", "F", AccessFlags = 25)]
				public const float Epsilon = 1.401298E-45F;
				/// <java-name>
				/// NaN
				/// </java-name>
				[Dot42.DexImport("NaN", "F", AccessFlags = 25)]
				public const float NaN = 0.0f / 0.0f;
				/// <java-name>
				/// POSITIVE_INFINITY
				/// </java-name>
				[Dot42.DexImport("POSITIVE_INFINITY", "F", AccessFlags = 25)]
				public static readonly float PositiveInfinity;
				/// <java-name>
				/// NEGATIVE_INFINITY
				/// </java-name>
				[Dot42.DexImport("NEGATIVE_INFINITY", "F", AccessFlags = 25)]
				public static readonly float NegativeInfinity;
				/// <java-name>
				/// MIN_NORMAL
				/// </java-name>
				[Dot42.DexImport("MIN_NORMAL", "F", AccessFlags = 25)]
				public const float MIN_NORMAL = 1.175494E-38F;
				/// <java-name>
				/// MAX_EXPONENT
				/// </java-name>
				[Dot42.DexImport("MAX_EXPONENT", "I", AccessFlags = 25)]
				public const int MAX_EXPONENT = 127;
				/// <java-name>
				/// MIN_EXPONENT
				/// </java-name>
				[Dot42.DexImport("MIN_EXPONENT", "I", AccessFlags = 25)]
				public const int MIN_EXPONENT = -126;
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "I", AccessFlags = 25)]
				public const int SIZE = 32;
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public Single(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(D)V", AccessFlags = 1)]
				public Single(double @double) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Single(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/Float;)I", AccessFlags = 1)]
				public int CompareTo(float? single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// byteValue
				/// </java-name>
				[Dot42.DexImport("byteValue", "()B", AccessFlags = 1)]
				public sbyte ByteValue() /* MethodBuilder.Create */ 
				{
						return default(sbyte);
				}

				/// <java-name>
				/// doubleValue
				/// </java-name>
				[Dot42.DexImport("doubleValue", "()D", AccessFlags = 1)]
				public double DoubleValue() /* MethodBuilder.Create */ 
				{
						return default(double);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// floatToIntBits
				/// </java-name>
				[Dot42.DexImport("floatToIntBits", "(F)I", AccessFlags = 265)]
				public static int FloatToIntBits(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// floatToRawIntBits
				/// </java-name>
				[Dot42.DexImport("floatToRawIntBits", "(F)I", AccessFlags = 265)]
				public static int FloatToRawIntBits(float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// floatValue
				/// </java-name>
				[Dot42.DexImport("floatValue", "()F", AccessFlags = 1)]
				public float FloatValue() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// intBitsToFloat
				/// </java-name>
				[Dot42.DexImport("intBitsToFloat", "(I)F", AccessFlags = 265)]
				public static float IntBitsToFloat(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// intValue
				/// </java-name>
				[Dot42.DexImport("intValue", "()I", AccessFlags = 1)]
				public int IntValue() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isInfinite
				/// </java-name>
				[Dot42.DexImport("isInfinite", "(F)Z", AccessFlags = 9)]
				public static bool IsInfinity(float single) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNaN
				/// </java-name>
				[Dot42.DexImport("isNaN", "()Z", AccessFlags = 1)]
				public bool IsNaN() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isNaN
				/// </java-name>
				[Dot42.DexImport("isNaN", "(F)Z", AccessFlags = 9)]
				public static bool IsNaN(float single) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// longValue
				/// </java-name>
				[Dot42.DexImport("longValue", "()J", AccessFlags = 1)]
				public long LongValue() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// parseFloat
				/// </java-name>
				[Dot42.DexImport("parseFloat", "(Ljava/lang/String;)F", AccessFlags = 9)]
				public static float Parse(string @string) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// shortValue
				/// </java-name>
				[Dot42.DexImport("shortValue", "()S", AccessFlags = 1)]
				public short ShortValue() /* MethodBuilder.Create */ 
				{
						return default(short);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "(F)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToString(float single) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Ljava/lang/Float;", AccessFlags = 9)]
				public static float? ValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(float?);
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(FF)I", AccessFlags = 9)]
				public static int Compare(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(F)Ljava/lang/Float;", AccessFlags = 9)]
				public static float? ValueOf(float single) /* MethodBuilder.Create */ 
				{
						return default(float?);
				}

				/// <java-name>
				/// toHexString
				/// </java-name>
				[Dot42.DexImport("toHexString", "(F)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHexString(float single) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isInfinite
				/// </java-name>
				public bool IsInfinite
				{
						[Dot42.DexImport("isInfinite", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/lang/StackOverflowError
		/// </java-name>
		[Dot42.DexImport("java/lang/StackOverflowError", AccessFlags = 33)]
		public partial class StackOverflowException : global::Java.Lang.VirtualMachineError
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StackOverflowException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public StackOverflowException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/String
		/// </java-name>
		[Dot42.DexImport("java/lang/String", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/Comparable<Ljava/lang/String;>" +
    ";Ljava/lang/CharSequence;")]
		public sealed partial class String : global::Java.IO.ISerializable, global::System.IComparable<string>, global::Java.Lang.ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CASE_INSENSITIVE_ORDER
				/// </java-name>
				[Dot42.DexImport("CASE_INSENSITIVE_ORDER", "Ljava/util/Comparator;", AccessFlags = 25)]
				public static readonly global::Java.Util.IComparator<string> CASE_INSENSITIVE_ORDER;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public String() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public String(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1)]
				public String(sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1)]
				public String(sbyte[] sByte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] @byte, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIII)V", AccessFlags = 1)]
				public String(sbyte[] sByte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIII)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] @byte, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/lang/String;)V", AccessFlags = 1)]
				public String(sbyte[] sByte, int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] @byte, int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BLjava/lang/String;)V", AccessFlags = 1)]
				public String(sbyte[] sByte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BLjava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] @byte, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/nio/charset/Charset;)V", AccessFlags = 1)]
				public String(sbyte[] sByte, int int32, int int321, global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BIILjava/nio/charset/Charset;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] @byte, int int32, int int321, global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BLjava/nio/charset/Charset;)V", AccessFlags = 1)]
				public String(sbyte[] sByte, global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([BLjava/nio/charset/Charset;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public String(byte[] @byte, global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([C)V", AccessFlags = 1)]
				public String(char[] @char) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([CII)V", AccessFlags = 1)]
				public String(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public String(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/StringBuffer;)V", AccessFlags = 1)]
				public String(global::Java.Lang.StringBuffer stringBuffer) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([III)V", AccessFlags = 1)]
				public String(int[] int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/StringBuilder;)V", AccessFlags = 1)]
				public String(global::System.Text.StringBuilder stringBuilder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 257)]
				char global::Java.Lang.ICharSequence.CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/lang/String;)I", AccessFlags = 257)]
				public int CompareTo(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// compareToIgnoreCase
				/// </java-name>
				[Dot42.DexImport("compareToIgnoreCase", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int CompareToIgnoreCase(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// concat
				/// </java-name>
				[Dot42.DexImport("concat", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string Concat(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// copyValueOf
				/// </java-name>
				[Dot42.DexImport("copyValueOf", "([C)Ljava/lang/String;", AccessFlags = 9)]
				public static string CopyValueOf(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// copyValueOf
				/// </java-name>
				[Dot42.DexImport("copyValueOf", "([CII)Ljava/lang/String;", AccessFlags = 9)]
				public static string CopyValueOf(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// endsWith
				/// </java-name>
				[Dot42.DexImport("endsWith", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool EndsWith(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 257)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// equalsIgnoreCase
				/// </java-name>
				[Dot42.DexImport("equalsIgnoreCase", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool EqualsIgnoreCase(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(II[BI)V", AccessFlags = 1)]
				public void GetBytes(int int32, int int321, sbyte[] sByte, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(II[BI)V", AccessFlags = 1, IgnoreFromJava = true)]
				public void GetBytes(int int32, int int321, byte[] @byte, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "()[B", AccessFlags = 1)]
				public sbyte[] JavaGetBytes() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetBytes() /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;)[B", AccessFlags = 1)]
				public sbyte[] JavaGetBytes(string @string) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/lang/String;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetBytes(string @string) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/nio/charset/Charset;)[B", AccessFlags = 1)]
				public sbyte[] JavaGetBytes(global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getBytes
				/// </java-name>
				[Dot42.DexImport("getBytes", "(Ljava/nio/charset/Charset;)[B", AccessFlags = 1, IgnoreFromJava = true)]
				public byte[] GetBytes(global::Java.Nio.Charset.Charset charset) /* MethodBuilder.Create */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
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
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(I)I", AccessFlags = 1)]
				public int IndexOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(II)I", AccessFlags = 1)]
				public int IndexOf(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int IndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// indexOf
				/// </java-name>
				[Dot42.DexImport("indexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public int IndexOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// intern
				/// </java-name>
				[Dot42.DexImport("intern", "()Ljava/lang/String;", AccessFlags = 257)]
				public string Intern() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(I)I", AccessFlags = 1)]
				public int LastIndexOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(II)I", AccessFlags = 1)]
				public int LastIndexOf(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public int LastIndexOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/String;I)I", AccessFlags = 1)]
				public int LastIndexOf(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 257)]
				int global::Java.Lang.ICharSequence.Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// regionMatches
				/// </java-name>
				[Dot42.DexImport("regionMatches", "(ILjava/lang/String;II)Z", AccessFlags = 1)]
				public bool RegionMatches(int int32, string @string, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// regionMatches
				/// </java-name>
				[Dot42.DexImport("regionMatches", "(ZILjava/lang/String;II)Z", AccessFlags = 1)]
				public bool RegionMatches(bool boolean, int int32, string @string, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(CC)Ljava/lang/String;", AccessFlags = 1)]
				public string Replace(char @char, char char1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Ljava/lang/String;", AccessFlags = 1)]
				public string Replace(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// startsWith
				/// </java-name>
				[Dot42.DexImport("startsWith", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool StartsWith(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startsWith
				/// </java-name>
				[Dot42.DexImport("startsWith", "(Ljava/lang/String;I)Z", AccessFlags = 1)]
				public bool StartsWith(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(I)Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public string JavaSubstring(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(II)Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public string JavaSubstring(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toCharArray
				/// </java-name>
				[Dot42.DexImport("toCharArray", "()[C", AccessFlags = 1)]
				public char[] ToCharArray() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// toLowerCase
				/// </java-name>
				[Dot42.DexImport("toLowerCase", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToLower() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toLowerCase
				/// </java-name>
				[Dot42.DexImport("toLowerCase", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string ToLower(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
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
				/// toUpperCase
				/// </java-name>
				[Dot42.DexImport("toUpperCase", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToUpper() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// toUpperCase
				/// </java-name>
				[Dot42.DexImport("toUpperCase", "(Ljava/util/Locale;)Ljava/lang/String;", AccessFlags = 1)]
				public string ToUpper(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// trim
				/// </java-name>
				[Dot42.DexImport("trim", "()Ljava/lang/String;", AccessFlags = 1)]
				public string Trim() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "([C)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "([CII)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(C)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(char @char) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(D)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(double @double) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(F)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(float single) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(J)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(long int64) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(object @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Z)Ljava/lang/String;", AccessFlags = 9)]
				public static string ValueOf(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// contentEquals
				/// </java-name>
				[Dot42.DexImport("contentEquals", "(Ljava/lang/StringBuffer;)Z", AccessFlags = 1)]
				public bool ContentEquals(global::Java.Lang.StringBuffer stringBuffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// contentEquals
				/// </java-name>
				[Dot42.DexImport("contentEquals", "(Ljava/lang/CharSequence;)Z", AccessFlags = 1)]
				public bool ContentEquals(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// matches
				/// </java-name>
				[Dot42.DexImport("matches", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool Matches(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// replaceAll
				/// </java-name>
				[Dot42.DexImport("replaceAll", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string ReplaceAll(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// replaceFirst
				/// </java-name>
				[Dot42.DexImport("replaceFirst", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string ReplaceFirst(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/String;)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Split(string @string) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// split
				/// </java-name>
				[Dot42.DexImport("split", "(Ljava/lang/String;I)[Ljava/lang/String;", AccessFlags = 1)]
				public string[] Split(string @string, int int32) /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// codePointAt
				/// </java-name>
				[Dot42.DexImport("codePointAt", "(I)I", AccessFlags = 1)]
				public int CodePointAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointBefore
				/// </java-name>
				[Dot42.DexImport("codePointBefore", "(I)I", AccessFlags = 1)]
				public int CodePointBefore(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// codePointCount
				/// </java-name>
				[Dot42.DexImport("codePointCount", "(II)I", AccessFlags = 1)]
				public int CodePointCount(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// contains
				/// </java-name>
				[Dot42.DexImport("contains", "(Ljava/lang/CharSequence;)Z", AccessFlags = 1)]
				public bool Contains(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offsetByCodePoints
				/// </java-name>
				[Dot42.DexImport("offsetByCodePoints", "(II)I", AccessFlags = 1)]
				public int OffsetByCodePoints(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 137)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public static string JavaFormat(string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", AccessFlags = 137)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
				public static string JavaFormat(global::Java.Util.Locale locale, string @string, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/lang/RuntimeException
		/// </java-name>
		[Dot42.DexImport("java/lang/RuntimeException", AccessFlags = 33)]
		public partial class SystemException : global::System.Exception
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SystemException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public SystemException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SystemException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public SystemException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/lang/Class
		/// </java-name>
		[Dot42.DexImport("java/lang/Class", AccessFlags = 49, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;Ljava/lang/reflect/" +
    "AnnotatedElement;Ljava/lang/reflect/GenericDeclaration;Ljava/lang/reflect/Type;")]
		public sealed partial class Type : global::Java.IO.ISerializable, global::Java.Lang.Reflect.IAnnotatedElement, global::Java.Lang.Reflect.IGenericDeclaration, global::Java.Lang.Reflect.IType
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Type() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forName
				/// </java-name>
				[Dot42.DexImport("forName", "(Ljava/lang/String;)Ljava/lang/Class;", AccessFlags = 9, Signature = "(Ljava/lang/String;)Ljava/lang/Class<*>;")]
				public static global::System.Type ForName(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// forName
				/// </java-name>
				[Dot42.DexImport("forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;", AccessFlags = 9, Signature = "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
				public static global::System.Type ForName(string @string, bool boolean, global::Java.Lang.ClassLoader classLoader) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getClasses
				/// </java-name>
				[Dot42.DexImport("getClasses", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetClasses() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <java-name>
				/// getAnnotation
				/// </java-name>
				[Dot42.DexImport("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1, Signature = "<A::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TA;>;)TA;")]
				public A GetAnnotation<A>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(A);
				}

				/// <java-name>
				/// getAnnotations
				/// </java-name>
				[Dot42.DexImport("getAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 1)]
				public global::Java.Lang.Annotation.IAnnotation[] GetAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// getCanonicalName
				/// </java-name>
				[Dot42.DexImport("getCanonicalName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetCanonicalName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getClassLoader
				/// </java-name>
				[Dot42.DexImport("getClassLoader", "()Ljava/lang/ClassLoader;", AccessFlags = 1)]
				public global::Java.Lang.ClassLoader GetClassLoader() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ClassLoader);
				}

				/// <java-name>
				/// getComponentType
				/// </java-name>
				[Dot42.DexImport("getComponentType", "()Ljava/lang/Class;", AccessFlags = 257, Signature = "()Ljava/lang/Class<*>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Type JavaGetComponentType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getConstructor
				/// </java-name>
				[Dot42.DexImport("getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", AccessFlags = 129, Signature = "([Ljava/lang/Class<*>;)Ljava/lang/reflect/Constructor<TT;>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Constructor JavaGetConstructor(params global::System.Type[] type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Constructor);
				}

				/// <java-name>
				/// getConstructors
				/// </java-name>
				[Dot42.DexImport("getConstructors", "()[Ljava/lang/reflect/Constructor;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/Constructor<*>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Constructor[] JavaGetConstructors() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Constructor[]);
				}

				/// <java-name>
				/// getDeclaredAnnotations
				/// </java-name>
				[Dot42.DexImport("getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", AccessFlags = 257)]
				public global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Annotation.IAnnotation[]);
				}

				/// <java-name>
				/// getDeclaredClasses
				/// </java-name>
				[Dot42.DexImport("getDeclaredClasses", "()[Ljava/lang/Class;", AccessFlags = 1, Signature = "()[Ljava/lang/Class<*>;")]
				public global::System.Type[] GetDeclaredClasses() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <java-name>
				/// getDeclaredConstructor
				/// </java-name>
				[Dot42.DexImport("getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", AccessFlags = 129, Signature = "([Ljava/lang/Class<*>;)Ljava/lang/reflect/Constructor<TT;>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Constructor JavaGetDeclaredConstructor(params global::System.Type[] type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Constructor);
				}

				/// <java-name>
				/// getDeclaredConstructors
				/// </java-name>
				[Dot42.DexImport("getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;", AccessFlags = 1, Signature = "()[Ljava/lang/reflect/Constructor<*>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Constructor[] JavaGetDeclaredConstructors() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Constructor[]);
				}

				/// <java-name>
				/// getDeclaredField
				/// </java-name>
				[Dot42.DexImport("getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Field JavaGetDeclaredField(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Field);
				}

				/// <java-name>
				/// getDeclaredFields
				/// </java-name>
				[Dot42.DexImport("getDeclaredFields", "()[Ljava/lang/reflect/Field;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Field[] JavaGetDeclaredFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Field[]);
				}

				/// <java-name>
				/// getDeclaredMethod
				/// </java-name>
				[Dot42.DexImport("getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", AccessFlags = 129, Signature = "(Ljava/lang/String;[Ljava/lang/Class<*>;)Ljava/lang/reflect/Method;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Method JavaGetDeclaredMethod(string @string, params global::System.Type[] type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Method);
				}

				/// <java-name>
				/// getDeclaredMethods
				/// </java-name>
				[Dot42.DexImport("getDeclaredMethods", "()[Ljava/lang/reflect/Method;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Method[] JavaGetDeclaredMethods() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Method[]);
				}

				/// <java-name>
				/// getDeclaringClass
				/// </java-name>
				[Dot42.DexImport("getDeclaringClass", "()Ljava/lang/Class;", AccessFlags = 257, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetDeclaringClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getEnclosingClass
				/// </java-name>
				[Dot42.DexImport("getEnclosingClass", "()Ljava/lang/Class;", AccessFlags = 257, Signature = "()Ljava/lang/Class<*>;")]
				public global::System.Type GetEnclosingClass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getEnclosingConstructor
				/// </java-name>
				[Dot42.DexImport("getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;", AccessFlags = 257, Signature = "()Ljava/lang/reflect/Constructor<*>;")]
				public global::Java.Lang.Reflect.Constructor GetEnclosingConstructor() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Constructor);
				}

				/// <java-name>
				/// getEnclosingMethod
				/// </java-name>
				[Dot42.DexImport("getEnclosingMethod", "()Ljava/lang/reflect/Method;", AccessFlags = 257)]
				public global::Java.Lang.Reflect.Method GetEnclosingMethod() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Method);
				}

				/// <java-name>
				/// getEnumConstants
				/// </java-name>
				[Dot42.DexImport("getEnumConstants", "()[Ljava/lang/Object;", AccessFlags = 1, Signature = "()[TT;")]
				public object[] GetEnumConstants() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// getField
				/// </java-name>
				[Dot42.DexImport("getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Field JavaGetField(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Field);
				}

				/// <java-name>
				/// getFields
				/// </java-name>
				[Dot42.DexImport("getFields", "()[Ljava/lang/reflect/Field;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Field[] JavaGetFields() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Field[]);
				}

				/// <java-name>
				/// getGenericInterfaces
				/// </java-name>
				[Dot42.DexImport("getGenericInterfaces", "()[Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType[] GetGenericInterfaces() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType[]);
				}

				/// <java-name>
				/// getGenericSuperclass
				/// </java-name>
				[Dot42.DexImport("getGenericSuperclass", "()Ljava/lang/reflect/Type;", AccessFlags = 1)]
				public global::Java.Lang.Reflect.IType GetGenericSuperclass() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.IType);
				}

				/// <java-name>
				/// getInterfaces
				/// </java-name>
				[Dot42.DexImport("getInterfaces", "()[Ljava/lang/Class;", AccessFlags = 257, Signature = "()[Ljava/lang/Class<*>;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::System.Type[] JavaGetInterfaces() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type[]);
				}

				/// <java-name>
				/// getMethod
				/// </java-name>
				[Dot42.DexImport("getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", AccessFlags = 129, Signature = "(Ljava/lang/String;[Ljava/lang/Class<*>;)Ljava/lang/reflect/Method;")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Method JavaGetMethod(string @string, params global::System.Type[] type) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Method);
				}

				/// <java-name>
				/// getMethods
				/// </java-name>
				[Dot42.DexImport("getMethods", "()[Ljava/lang/reflect/Method;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public global::Java.Lang.Reflect.Method[] JavaGetMethods() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.Method[]);
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				[Dot42.DexImport("getModifiers", "()I", AccessFlags = 1)]
				public int GetModifiers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public string JavaGetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSimpleName
				/// </java-name>
				[Dot42.DexImport("getSimpleName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetSimpleName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getProtectionDomain
				/// </java-name>
				[Dot42.DexImport("getProtectionDomain", "()Ljava/security/ProtectionDomain;", AccessFlags = 1)]
				public global::Java.Security.ProtectionDomain GetProtectionDomain() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.ProtectionDomain);
				}

				/// <java-name>
				/// getResource
				/// </java-name>
				[Dot42.DexImport("getResource", "(Ljava/lang/String;)Ljava/net/URL;", AccessFlags = 1)]
				public global::Java.Net.URL GetResource(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				/// <java-name>
				/// getResourceAsStream
				/// </java-name>
				[Dot42.DexImport("getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", AccessFlags = 1)]
				public global::Java.IO.InputStream GetResourceAsStream(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.IO.InputStream);
				}

				/// <java-name>
				/// getSigners
				/// </java-name>
				[Dot42.DexImport("getSigners", "()[Ljava/lang/Object;", AccessFlags = 1)]
				public object[] GetSigners() /* MethodBuilder.Create */ 
				{
						return default(object[]);
				}

				/// <java-name>
				/// getSuperclass
				/// </java-name>
				[Dot42.DexImport("getSuperclass", "()Ljava/lang/Class;", AccessFlags = 257, Signature = "()Ljava/lang/Class<-TT;>;")]
				public global::System.Type GetSuperclass() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// getTypeParameters
				/// </java-name>
				[Dot42.DexImport("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", AccessFlags = 33, Signature = "()[Ljava/lang/reflect/TypeVariable<Ljava/lang/Class<TT;>;>;")]
				public global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Reflect.ITypeVariable[]);
				}

				/// <java-name>
				/// isAnnotationPresent
				/// </java-name>
				[Dot42.DexImport("isAnnotationPresent", "(Ljava/lang/Class;)Z", AccessFlags = 1, Signature = "(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
				public bool IsAnnotationPresent(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isAssignableFrom
				/// </java-name>
				[Dot42.DexImport("isAssignableFrom", "(Ljava/lang/Class;)Z", AccessFlags = 257, Signature = "(Ljava/lang/Class<*>;)Z")]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public bool JavaIsAssignableFrom(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isEnum
				/// </java-name>
				[Dot42.DexImport("isEnum", "()Z", AccessFlags = 1)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public bool JavaGetIsEnum() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isInstance
				/// </java-name>
				[Dot42.DexImport("isInstance", "(Ljava/lang/Object;)Z", AccessFlags = 257)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public bool JavaIsInstance(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isInterface
				/// </java-name>
				[Dot42.DexImport("isInterface", "()Z", AccessFlags = 257)]
				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				public bool JavaIsInterface() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// newInstance
				/// </java-name>
				[Dot42.DexImport("newInstance", "()Ljava/lang/Object;", AccessFlags = 1, Signature = "()TT;")]
				public object NewInstance() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getPackage
				/// </java-name>
				[Dot42.DexImport("getPackage", "()Ljava/lang/Package;", AccessFlags = 1)]
				public global::Java.Lang.Package GetPackage() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.Package);
				}

				/// <java-name>
				/// desiredAssertionStatus
				/// </java-name>
				[Dot42.DexImport("desiredAssertionStatus", "()Z", AccessFlags = 257)]
				public bool DesiredAssertionStatus() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// asSubclass
				/// </java-name>
				[Dot42.DexImport("asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;", AccessFlags = 1, Signature = "<U:Ljava/lang/Object;>(Ljava/lang/Class<TU;>;)Ljava/lang/Class<+TU;>;")]
				public global::System.Type AsSubclass<U>(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// cast
				/// </java-name>
				[Dot42.DexImport("cast", "(Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1, Signature = "(Ljava/lang/Object;)TT;")]
				public object Cast(object @object) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[Dot42.DexImport("java/lang/reflect/AnnotatedElement", "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", AccessFlags = 1025, Signature = "<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
				T global::Java.Lang.Reflect.IAnnotatedElement.GetAnnotation<T>(global::System.Type type) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(T);
				}

				/// <java-name>
				/// isAnnotation
				/// </java-name>
				public bool IsAnnotation
				{
						[Dot42.DexImport("isAnnotation", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isAnonymousClass
				/// </java-name>
				public bool IsAnonymousClass
				{
						[Dot42.DexImport("isAnonymousClass", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isArray
				/// </java-name>
				public bool IsArray
				{
						[Dot42.DexImport("isArray", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isLocalClass
				/// </java-name>
				public bool IsLocalClass
				{
						[Dot42.DexImport("isLocalClass", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMemberClass
				/// </java-name>
				public bool IsMemberClass
				{
						[Dot42.DexImport("isMemberClass", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isPrimitive
				/// </java-name>
				public bool IsPrimitive
				{
						[Dot42.DexImport("isPrimitive", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isSynthetic
				/// </java-name>
				public bool IsSynthetic
				{
						[Dot42.DexImport("isSynthetic", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		public partial struct UInt16
 /* scope: __custom__ */ 
		{
		}

		public partial struct UInt32
 /* scope: __custom__ */ 
		{
		}

		public partial struct UInt64
 /* scope: __custom__ */ 
		{
		}

		public partial struct UIntPtr
 /* scope: __custom__ */ 
		{
		}

		/// <java-name>
		/// java/net/URI
		/// </java-name>
		[Dot42.DexImport("java/net/URI", AccessFlags = 49, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Ljava/net/URI;>;Ljava/io/Serializable;")]
		public sealed partial class Uri : global::System.IComparable<global::System.Uri>, global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public Uri(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Uri(string @string, string string1, string string2) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/l" +
    "ang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Uri(string @string, string string1, string string2, int int32, string string3, string string4, string string5) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Uri(string @string, string string1, string string2, string string3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/la" +
    "ng/String;)V", AccessFlags = 1)]
				public Uri(string @string, string string1, string string2, string string3, string string4) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Ljava/net/URI;)I", AccessFlags = 1)]
				public int CompareTo(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// create
				/// </java-name>
				[Dot42.DexImport("create", "(Ljava/lang/String;)Ljava/net/URI;", AccessFlags = 9)]
				public static global::System.Uri Create(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
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
				/// normalize
				/// </java-name>
				[Dot42.DexImport("normalize", "()Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri Normalize() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// parseServerAuthority
				/// </java-name>
				[Dot42.DexImport("parseServerAuthority", "()Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri ParseServerAuthority() /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// relativize
				/// </java-name>
				[Dot42.DexImport("relativize", "(Ljava/net/URI;)Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri Relativize(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/net/URI;)Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri Resolve(global::System.Uri uri) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// resolve
				/// </java-name>
				[Dot42.DexImport("resolve", "(Ljava/lang/String;)Ljava/net/URI;", AccessFlags = 1)]
				public global::System.Uri Resolve(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::System.Uri);
				}

				/// <java-name>
				/// toASCIIString
				/// </java-name>
				[Dot42.DexImport("toASCIIString", "()Ljava/lang/String;", AccessFlags = 1)]
				public string ToASCIIString() /* MethodBuilder.Create */ 
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
				/// toURL
				/// </java-name>
				[Dot42.DexImport("toURL", "()Ljava/net/URL;", AccessFlags = 1)]
				public global::Java.Net.URL ToURL() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Net.URL);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Uri() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getScheme
				/// </java-name>
				public string Scheme
				{
						[Dot42.DexImport("getScheme", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSchemeSpecificPart
				/// </java-name>
				public string SchemeSpecificPart
				{
						[Dot42.DexImport("getSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRawSchemeSpecificPart
				/// </java-name>
				public string RawSchemeSpecificPart
				{
						[Dot42.DexImport("getRawSchemeSpecificPart", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getAuthority
				/// </java-name>
				public string Authority
				{
						[Dot42.DexImport("getAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRawAuthority
				/// </java-name>
				public string RawAuthority
				{
						[Dot42.DexImport("getRawAuthority", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getUserInfo
				/// </java-name>
				public string UserInfo
				{
						[Dot42.DexImport("getUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRawUserInfo
				/// </java-name>
				public string RawUserInfo
				{
						[Dot42.DexImport("getRawUserInfo", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
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
				/// getPort
				/// </java-name>
				public int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPath
				/// </java-name>
				public string AbsolutePath
				{
						[Dot42.DexImport("getPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRawPath
				/// </java-name>
				public string RawPath
				{
						[Dot42.DexImport("getRawPath", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getQuery
				/// </java-name>
				public string Query
				{
						[Dot42.DexImport("getQuery", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRawQuery
				/// </java-name>
				public string RawQuery
				{
						[Dot42.DexImport("getRawQuery", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getFragment
				/// </java-name>
				public string Fragment
				{
						[Dot42.DexImport("getFragment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getRawFragment
				/// </java-name>
				public string RawFragment
				{
						[Dot42.DexImport("getRawFragment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// isAbsolute
				/// </java-name>
				public bool IsAbsolute
				{
						[Dot42.DexImport("isAbsolute", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isOpaque
				/// </java-name>
				public bool IsOpaque
				{
						[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		public partial class ValueType
 /* scope: __custom__ */ 
		{
		}

		/// <java-name>
		/// java/lang/Void
		/// </java-name>
		[Dot42.DexImport("java/lang/Void", AccessFlags = 49)]
		public partial struct Void
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE
				/// </java-name>
				[Dot42.DexImport("TYPE", "Ljava/lang/Class;", AccessFlags = 25)]
				public static readonly global::System.Type TYPE;
		}

}

