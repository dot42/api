// Copyright (C) 2014 dot42
//
// Original filename: Java.Awt.Font.cs
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
namespace Java.Awt.Font
{
		/// <summary>
		/// <para>The TextAttribute class defines attribute keys and attribute values for text rendering. Each TextAttributes should have the following information: <ul><li><para>key name; </para></li><li><para>valid values; </para></li><li><para>relevant constants; </para></li><li><para>default action if the attribute is absent; </para></li><li><para>default action's description. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// java/awt/font/TextAttribute
		/// </java-name>
		[Dot42.DexImport("java/awt/font/TextAttribute", AccessFlags = 49)]
		public sealed partial class TextAttribute : global::Java.Text.IAttributedCharacterIterator_Attribute
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The BACKGROUND text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// BACKGROUND
				/// </java-name>
				[Dot42.DexImport("BACKGROUND", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute BACKGROUND;
				/// <summary>
				/// <para>The BIDI_EMBEDDING text attribute key. </para>        
				/// </summary>
				/// <java-name>
				/// BIDI_EMBEDDING
				/// </java-name>
				[Dot42.DexImport("BIDI_EMBEDDING", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute BIDI_EMBEDDING;
				/// <summary>
				/// <para>The CHAR_REPLACEMENT text attribute key. </para>        
				/// </summary>
				/// <java-name>
				/// CHAR_REPLACEMENT
				/// </java-name>
				[Dot42.DexImport("CHAR_REPLACEMENT", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute CHAR_REPLACEMENT;
				/// <summary>
				/// <para>The FAMILY text attribute key. </para>        
				/// </summary>
				/// <java-name>
				/// FAMILY
				/// </java-name>
				[Dot42.DexImport("FAMILY", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute FAMILY;
				/// <summary>
				/// <para>The FONT text attribute key. </para>        
				/// </summary>
				/// <java-name>
				/// FONT
				/// </java-name>
				[Dot42.DexImport("FONT", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute FONT;
				/// <summary>
				/// <para>The FOREGROUND text attribute key. </para>        
				/// </summary>
				/// <java-name>
				/// FOREGROUND
				/// </java-name>
				[Dot42.DexImport("FOREGROUND", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute FOREGROUND;
				/// <summary>
				/// <para>The INPUT_METHOD_HIGHLIGHT text attribute key. </para>        
				/// </summary>
				/// <java-name>
				/// INPUT_METHOD_HIGHLIGHT
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_HIGHLIGHT", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute INPUT_METHOD_HIGHLIGHT;
				/// <summary>
				/// <para>The INPUT_METHOD_UNDERLINE text attribute key. </para>        
				/// </summary>
				/// <java-name>
				/// INPUT_METHOD_UNDERLINE
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_UNDERLINE", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute INPUT_METHOD_UNDERLINE;
				/// <summary>
				/// <para>The JUSTIFICATION text attribute key. </para>        
				/// </summary>
				/// <java-name>
				/// JUSTIFICATION
				/// </java-name>
				[Dot42.DexImport("JUSTIFICATION", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute JUSTIFICATION;
				/// <summary>
				/// <para>The Constant JUSTIFICATION_indicates the full requested width. </para>        
				/// </summary>
				/// <java-name>
				/// JUSTIFICATION_FULL
				/// </java-name>
				[Dot42.DexImport("JUSTIFICATION_FULL", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? JUSTIFICATION_FULL;
				/// <summary>
				/// <para>The Constant JUSTIFICATION_NONE indicates that line is not allowed for justification. </para>        
				/// </summary>
				/// <java-name>
				/// JUSTIFICATION_NONE
				/// </java-name>
				[Dot42.DexImport("JUSTIFICATION_NONE", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? JUSTIFICATION_NONE;
				/// <summary>
				/// <para>The KERNING text attribute key.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// KERNING
				/// </java-name>
				[Dot42.DexImport("KERNING", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute KERNING;
				/// <summary>
				/// <para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// KERNING_ON
				/// </java-name>
				[Dot42.DexImport("KERNING_ON", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? KERNING_ON;
				/// <summary>
				/// <para>The LIGATURES text attribute key.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// LIGATURES
				/// </java-name>
				[Dot42.DexImport("LIGATURES", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute LIGATURES;
				/// <summary>
				/// <para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// LIGATURES_ON
				/// </java-name>
				[Dot42.DexImport("LIGATURES_ON", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? LIGATURES_ON;
				/// <summary>
				/// <para>The NUMERIC_SHAPING text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// NUMERIC_SHAPING
				/// </java-name>
				[Dot42.DexImport("NUMERIC_SHAPING", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute NUMERIC_SHAPING;
				/// <summary>
				/// <para>The POSTURE text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// POSTURE
				/// </java-name>
				[Dot42.DexImport("POSTURE", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute POSTURE;
				/// <summary>
				/// <para>The Constant POSTURE_REGULAR indicates regular posture. </para>        
				/// </summary>
				/// <java-name>
				/// POSTURE_REGULAR
				/// </java-name>
				[Dot42.DexImport("POSTURE_REGULAR", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? POSTURE_REGULAR;
				/// <summary>
				/// <para>The Constant POSTURE_OBLIQUE indicates italic posture. </para>        
				/// </summary>
				/// <java-name>
				/// POSTURE_OBLIQUE
				/// </java-name>
				[Dot42.DexImport("POSTURE_OBLIQUE", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? POSTURE_OBLIQUE;
				/// <summary>
				/// <para>The RUN_DIRECTION text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// RUN_DIRECTION
				/// </java-name>
				[Dot42.DexImport("RUN_DIRECTION", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute RUN_DIRECTION;
				/// <summary>
				/// <para>The Constant RUN_DIRECTION_LTR indicates left-to-right run direction. </para>        
				/// </summary>
				/// <java-name>
				/// RUN_DIRECTION_LTR
				/// </java-name>
				[Dot42.DexImport("RUN_DIRECTION_LTR", "Ljava/lang/Boolean;", AccessFlags = 25)]
				public static readonly bool? RUN_DIRECTION_LTR;
				/// <summary>
				/// <para>The Constant RUN_DIRECTION_RTL indicates right-to-left run direction. </para>        
				/// </summary>
				/// <java-name>
				/// RUN_DIRECTION_RTL
				/// </java-name>
				[Dot42.DexImport("RUN_DIRECTION_RTL", "Ljava/lang/Boolean;", AccessFlags = 25)]
				public static readonly bool? RUN_DIRECTION_RTL;
				/// <summary>
				/// <para>The SIZE text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SIZE
				/// </java-name>
				[Dot42.DexImport("SIZE", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute SIZE;
				/// <summary>
				/// <para>The STRIKETHROUGH text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// STRIKETHROUGH
				/// </java-name>
				[Dot42.DexImport("STRIKETHROUGH", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute STRIKETHROUGH;
				/// <summary>
				/// <para>The Constant STRIKETHROUGH_ON indicates a single strikethrough. </para>        
				/// </summary>
				/// <java-name>
				/// STRIKETHROUGH_ON
				/// </java-name>
				[Dot42.DexImport("STRIKETHROUGH_ON", "Ljava/lang/Boolean;", AccessFlags = 25)]
				public static readonly bool? STRIKETHROUGH_ON;
				/// <summary>
				/// <para>The SUPERSCRIPT text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SUPERSCRIPT
				/// </java-name>
				[Dot42.DexImport("SUPERSCRIPT", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute SUPERSCRIPT;
				/// <summary>
				/// <para>The Constant SUPERSCRIPT_SUB indicates a standard subscript. </para>        
				/// </summary>
				/// <java-name>
				/// SUPERSCRIPT_SUB
				/// </java-name>
				[Dot42.DexImport("SUPERSCRIPT_SUB", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? SUPERSCRIPT_SUB;
				/// <summary>
				/// <para>The Constant SUPERSCRIPT_SUPER indicates a standard superscript. </para>        
				/// </summary>
				/// <java-name>
				/// SUPERSCRIPT_SUPER
				/// </java-name>
				[Dot42.DexImport("SUPERSCRIPT_SUPER", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? SUPERSCRIPT_SUPER;
				/// <summary>
				/// <para>The SWAP_COLORS text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// SWAP_COLORS
				/// </java-name>
				[Dot42.DexImport("SWAP_COLORS", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute SWAP_COLORS;
				/// <summary>
				/// <para>The Constant SWAP_COLORS_ON indicates a swap of foreground and background. </para>        
				/// </summary>
				/// <java-name>
				/// SWAP_COLORS_ON
				/// </java-name>
				[Dot42.DexImport("SWAP_COLORS_ON", "Ljava/lang/Boolean;", AccessFlags = 25)]
				public static readonly bool? SWAP_COLORS_ON;
				/// <summary>
				/// <para>The TRACKING text attribute key.</para><para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// TRACKING
				/// </java-name>
				[Dot42.DexImport("TRACKING", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute TRACKING;
				/// <summary>
				/// <para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// TRACKING_LOOSE
				/// </java-name>
				[Dot42.DexImport("TRACKING_LOOSE", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? TRACKING_LOOSE;
				/// <summary>
				/// <para><para>1.6 </para></para>        
				/// </summary>
				/// <java-name>
				/// TRACKING_TIGHT
				/// </java-name>
				[Dot42.DexImport("TRACKING_TIGHT", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? TRACKING_TIGHT;
				/// <summary>
				/// <para>The TRANSFORM text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// TRANSFORM
				/// </java-name>
				[Dot42.DexImport("TRANSFORM", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute TRANSFORM;
				/// <summary>
				/// <para>The Constant UNDERLINE text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// UNDERLINE
				/// </java-name>
				[Dot42.DexImport("UNDERLINE", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute UNDERLINE;
				/// <summary>
				/// <para>The Constant UNDERLINE_ON indicates a standard underline at the roman baseline for roman text. </para>        
				/// </summary>
				/// <java-name>
				/// UNDERLINE_ON
				/// </java-name>
				[Dot42.DexImport("UNDERLINE_ON", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? UNDERLINE_ON;
				/// <summary>
				/// <para>The Constant UNDERLINE_LOW_ONE_PIXEL indicates a single pixel solid low underline. </para>        
				/// </summary>
				/// <java-name>
				/// UNDERLINE_LOW_ONE_PIXEL
				/// </java-name>
				[Dot42.DexImport("UNDERLINE_LOW_ONE_PIXEL", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? UNDERLINE_LOW_ONE_PIXEL;
				/// <summary>
				/// <para>The Constant UNDERLINE_LOW_TWO_PIXEL indicates a double pixel solid low underline. </para>        
				/// </summary>
				/// <java-name>
				/// UNDERLINE_LOW_TWO_PIXEL
				/// </java-name>
				[Dot42.DexImport("UNDERLINE_LOW_TWO_PIXEL", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? UNDERLINE_LOW_TWO_PIXEL;
				/// <summary>
				/// <para>The Constant UNDERLINE_LOW_DOTTED indicates a single pixel dotted low underline. </para>        
				/// </summary>
				/// <java-name>
				/// UNDERLINE_LOW_DOTTED
				/// </java-name>
				[Dot42.DexImport("UNDERLINE_LOW_DOTTED", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? UNDERLINE_LOW_DOTTED;
				/// <summary>
				/// <para>The Constant UNDERLINE_LOW_GRAY indicates double pixel gray low underline. </para>        
				/// </summary>
				/// <java-name>
				/// UNDERLINE_LOW_GRAY
				/// </java-name>
				[Dot42.DexImport("UNDERLINE_LOW_GRAY", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? UNDERLINE_LOW_GRAY;
				/// <summary>
				/// <para>The Constant UNDERLINE_LOW_DASHED indicates single pixel dashed low underline. </para>        
				/// </summary>
				/// <java-name>
				/// UNDERLINE_LOW_DASHED
				/// </java-name>
				[Dot42.DexImport("UNDERLINE_LOW_DASHED", "Ljava/lang/Integer;", AccessFlags = 25)]
				public static readonly int? UNDERLINE_LOW_DASHED;
				/// <summary>
				/// <para>The WEIGHT text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT
				/// </java-name>
				[Dot42.DexImport("WEIGHT", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute WEIGHT;
				/// <summary>
				/// <para>The Constant WEIGHT_EXTRA_LIGHT indicates the lightest predefined weight. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_EXTRA_LIGHT
				/// </java-name>
				[Dot42.DexImport("WEIGHT_EXTRA_LIGHT", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_EXTRA_LIGHT;
				/// <summary>
				/// <para>The Constant WEIGHT_LIGHT indicates the standard light weight. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_LIGHT
				/// </java-name>
				[Dot42.DexImport("WEIGHT_LIGHT", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_LIGHT;
				/// <summary>
				/// <para>The Constant WEIGHT_DEMILIGHT indicates an intermediate weight between LIGHT and STANDARD. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_DEMILIGHT
				/// </java-name>
				[Dot42.DexImport("WEIGHT_DEMILIGHT", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_DEMILIGHT;
				/// <summary>
				/// <para>The Constant WEIGHT_REGULAR indicates the standart weight. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_REGULAR
				/// </java-name>
				[Dot42.DexImport("WEIGHT_REGULAR", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_REGULAR;
				/// <summary>
				/// <para>The Constant WEIGHT_SEMIBOLD indicates a semi weight of REGULAR. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_SEMIBOLD
				/// </java-name>
				[Dot42.DexImport("WEIGHT_SEMIBOLD", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_SEMIBOLD;
				/// <summary>
				/// <para>The Constant WEIGHT_MEDIUM indicates average weight between the REGULAR and BOLD. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_MEDIUM
				/// </java-name>
				[Dot42.DexImport("WEIGHT_MEDIUM", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_MEDIUM;
				/// <summary>
				/// <para>The Constant WEIGHT_DEMIBOLD indicates a lighter weight than BOLD. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_DEMIBOLD
				/// </java-name>
				[Dot42.DexImport("WEIGHT_DEMIBOLD", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_DEMIBOLD;
				/// <summary>
				/// <para>The Constant WEIGHT_BOLD indicates the standard bold weight. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_BOLD
				/// </java-name>
				[Dot42.DexImport("WEIGHT_BOLD", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_BOLD;
				/// <summary>
				/// <para>The Constant WEIGHT_HEAVY indicates a heavier weight than BOLD. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_HEAVY
				/// </java-name>
				[Dot42.DexImport("WEIGHT_HEAVY", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_HEAVY;
				/// <summary>
				/// <para>The Constant WEIGHT_EXTRABOLD indicates an extra heavy weight. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_EXTRABOLD
				/// </java-name>
				[Dot42.DexImport("WEIGHT_EXTRABOLD", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_EXTRABOLD;
				/// <summary>
				/// <para>The Constant WEIGHT_ULTRABOLD indicates the heaviest predefined weight. </para>        
				/// </summary>
				/// <java-name>
				/// WEIGHT_ULTRABOLD
				/// </java-name>
				[Dot42.DexImport("WEIGHT_ULTRABOLD", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WEIGHT_ULTRABOLD;
				/// <summary>
				/// <para>The WIDTH text attribute. </para>        
				/// </summary>
				/// <java-name>
				/// WIDTH
				/// </java-name>
				[Dot42.DexImport("WIDTH", "Ljava/awt/font/TextAttribute;", AccessFlags = 25)]
				public static readonly global::Java.Awt.Font.TextAttribute WIDTH;
				/// <summary>
				/// <para>The Constant WIDTH_CONDENSED indicates the most condensed predefined width. </para>        
				/// </summary>
				/// <java-name>
				/// WIDTH_CONDENSED
				/// </java-name>
				[Dot42.DexImport("WIDTH_CONDENSED", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WIDTH_CONDENSED;
				/// <summary>
				/// <para>The Constant WIDTH_SEMI_CONDENSED indicates a semi condensed width. </para>        
				/// </summary>
				/// <java-name>
				/// WIDTH_SEMI_CONDENSED
				/// </java-name>
				[Dot42.DexImport("WIDTH_SEMI_CONDENSED", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WIDTH_SEMI_CONDENSED;
				/// <summary>
				/// <para>The Constant WIDTH_REGULAR indicates the standard width. </para>        
				/// </summary>
				/// <java-name>
				/// WIDTH_REGULAR
				/// </java-name>
				[Dot42.DexImport("WIDTH_REGULAR", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WIDTH_REGULAR;
				/// <summary>
				/// <para>The Constant WIDTH_SEMI_EXTENDED indicates semi extended width. </para>        
				/// </summary>
				/// <java-name>
				/// WIDTH_SEMI_EXTENDED
				/// </java-name>
				[Dot42.DexImport("WIDTH_SEMI_EXTENDED", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WIDTH_SEMI_EXTENDED;
				/// <summary>
				/// <para>The Constant WIDTH_EXTENDED indicates extended width. </para>        
				/// </summary>
				/// <java-name>
				/// WIDTH_EXTENDED
				/// </java-name>
				[Dot42.DexImport("WIDTH_EXTENDED", "Ljava/lang/Float;", AccessFlags = 25)]
				public static readonly float? WIDTH_EXTENDED;
				/// <summary>
				/// <para>Instantiates a new TextAttribute with the specified name.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				internal TextAttribute(string name) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextAttribute() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>The Class NumericShaper provides methods to convert latin character codes to unicode character codes. For tables of the character codes used, see . </para>    
		/// </summary>
		/// <java-name>
		/// java/awt/font/NumericShaper
		/// </java-name>
		[Dot42.DexImport("java/awt/font/NumericShaper", AccessFlags = 49)]
		public sealed partial class NumericShaper : global::Java.Io.ISerializable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The Constant EUROPEAN indicates the latin and extended range, and latin decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// EUROPEAN
				/// </java-name>
				[Dot42.DexImport("EUROPEAN", "I", AccessFlags = 25)]
				public const int EUROPEAN = 1;
				/// <summary>
				/// <para>The Constant ARABIC indicates the ARABIC range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// ARABIC
				/// </java-name>
				[Dot42.DexImport("ARABIC", "I", AccessFlags = 25)]
				public const int ARABIC = 2;
				/// <summary>
				/// <para>The Constant EASTERN_ARABIC indicates the ARABIC range and ARABIC_EXTENDED decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// EASTERN_ARABIC
				/// </java-name>
				[Dot42.DexImport("EASTERN_ARABIC", "I", AccessFlags = 25)]
				public const int EASTERN_ARABIC = 4;
				/// <summary>
				/// <para>The Constant DEVANAGARI indicates the DEVANAGARI range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// DEVANAGARI
				/// </java-name>
				[Dot42.DexImport("DEVANAGARI", "I", AccessFlags = 25)]
				public const int DEVANAGARI = 8;
				/// <summary>
				/// <para>The Constant BENGALI indicates the BENGALI range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// BENGALI
				/// </java-name>
				[Dot42.DexImport("BENGALI", "I", AccessFlags = 25)]
				public const int BENGALI = 16;
				/// <summary>
				/// <para>The Constant GURMUKHI indicates the GURMUKHI range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// GURMUKHI
				/// </java-name>
				[Dot42.DexImport("GURMUKHI", "I", AccessFlags = 25)]
				public const int GURMUKHI = 32;
				/// <summary>
				/// <para>The Constant GUJARATI indicates the GUJARATI range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// GUJARATI
				/// </java-name>
				[Dot42.DexImport("GUJARATI", "I", AccessFlags = 25)]
				public const int GUJARATI = 64;
				/// <summary>
				/// <para>The Constant ORIYA indicates the ORIYA range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// ORIYA
				/// </java-name>
				[Dot42.DexImport("ORIYA", "I", AccessFlags = 25)]
				public const int ORIYA = 128;
				/// <summary>
				/// <para>The Constant TAMIL indicates the TAMIL range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// TAMIL
				/// </java-name>
				[Dot42.DexImport("TAMIL", "I", AccessFlags = 25)]
				public const int TAMIL = 256;
				/// <summary>
				/// <para>The Constant TELUGU indicates the TELUGU range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// TELUGU
				/// </java-name>
				[Dot42.DexImport("TELUGU", "I", AccessFlags = 25)]
				public const int TELUGU = 512;
				/// <summary>
				/// <para>The Constant KANNADA indicates the KANNADA range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// KANNADA
				/// </java-name>
				[Dot42.DexImport("KANNADA", "I", AccessFlags = 25)]
				public const int KANNADA = 1024;
				/// <summary>
				/// <para>The Constant MALAYALAM indicates the MALAYALAM range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// MALAYALAM
				/// </java-name>
				[Dot42.DexImport("MALAYALAM", "I", AccessFlags = 25)]
				public const int MALAYALAM = 2048;
				/// <summary>
				/// <para>The Constant THAI indicates the THAI range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// THAI
				/// </java-name>
				[Dot42.DexImport("THAI", "I", AccessFlags = 25)]
				public const int THAI = 4096;
				/// <summary>
				/// <para>The Constant LAO indicates the LAO range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// LAO
				/// </java-name>
				[Dot42.DexImport("LAO", "I", AccessFlags = 25)]
				public const int LAO = 8192;
				/// <summary>
				/// <para>The Constant TIBETAN indicates the TIBETAN range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// TIBETAN
				/// </java-name>
				[Dot42.DexImport("TIBETAN", "I", AccessFlags = 25)]
				public const int TIBETAN = 16384;
				/// <summary>
				/// <para>The Constant MYANMAR indicates the MYANMAR range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// MYANMAR
				/// </java-name>
				[Dot42.DexImport("MYANMAR", "I", AccessFlags = 25)]
				public const int MYANMAR = 32768;
				/// <summary>
				/// <para>The Constant ETHIOPIC indicates the ETHIOPIC range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// ETHIOPIC
				/// </java-name>
				[Dot42.DexImport("ETHIOPIC", "I", AccessFlags = 25)]
				public const int ETHIOPIC = 65536;
				/// <summary>
				/// <para>The Constant KHMER indicates the KHMER range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// KHMER
				/// </java-name>
				[Dot42.DexImport("KHMER", "I", AccessFlags = 25)]
				public const int KHMER = 131072;
				/// <summary>
				/// <para>The Constant MONGOLIAN indicates the MONGOLIAN range and decimal base. </para>        
				/// </summary>
				/// <java-name>
				/// MONGOLIAN
				/// </java-name>
				[Dot42.DexImport("MONGOLIAN", "I", AccessFlags = 25)]
				public const int MONGOLIAN = 262144;
				/// <summary>
				/// <para>The Constant ALL_RANGES indicates all ranges. </para>        
				/// </summary>
				/// <java-name>
				/// ALL_RANGES
				/// </java-name>
				[Dot42.DexImport("ALL_RANGES", "I", AccessFlags = 25)]
				public const int ALL_RANGES = 524287;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal NumericShaper() /* MethodBuilder.Create */ 
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object obj) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Gets the NumericShaper for the specified unicode ranges and default unicode range. The defaultContext parameter is used as the starting context (which indicates the language/script being used). The OR logical operation should be used for multiple ranges: NumericShaper.DEVANAGARI | NumericShaper.BENGALI. The NumericShaper returned by this method is contextual in that it supports multiple character ranges, depending on the context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the NumericShaper for the specified ranges. </para>
				/// </returns>
				/// <java-name>
				/// getContextualShaper
				/// </java-name>
				[Dot42.DexImport("getContextualShaper", "(II)Ljava/awt/font/NumericShaper;", AccessFlags = 9)]
				public static global::Java.Awt.Font.NumericShaper GetContextualShaper(int ranges, int defaultContext) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Awt.Font.NumericShaper);
				}

				/// <summary>
				/// <para>Gets the NumericShaper for the specified unicode ranges. The OR logical operation should be used for multiple ranges: NumericShaper.DEVANAGARI | NumericShaper.BENGALI. The NumericShaper returned by this method is contextual in that it supports multiple character ranges, depending on the context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the NumericShaper for the specified ranges. </para>
				/// </returns>
				/// <java-name>
				/// getContextualShaper
				/// </java-name>
				[Dot42.DexImport("getContextualShaper", "(I)Ljava/awt/font/NumericShaper;", AccessFlags = 9)]
				public static global::Java.Awt.Font.NumericShaper GetContextualShaper(int ranges) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Awt.Font.NumericShaper);
				}

				/// <summary>
				/// <para>Gets the masks for all of the ranges supported by this NumericShaper, packed into an int value using the logical OR logical operation for multiple ranges: NumericShaper.DEVANAGARI | NumericShaper.BENGALI.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>all ranges of this NumericShaper. </para>
				/// </returns>
				/// <java-name>
				/// getRanges
				/// </java-name>
				[Dot42.DexImport("getRanges", "()I", AccessFlags = 1)]
				public int GetRanges() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets a NumericShaper for the specified unicode range. The NumericShaper supports only a single range and hence is not contextual.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the NumericShaper for the specified unicode range. </para>
				/// </returns>
				/// <java-name>
				/// getShaper
				/// </java-name>
				[Dot42.DexImport("getShaper", "(I)Ljava/awt/font/NumericShaper;", AccessFlags = 9)]
				public static global::Java.Awt.Font.NumericShaper GetShaper(int singleRange) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Awt.Font.NumericShaper);
				}

				/// <summary>
				/// <para>Checks if this NumericShaper is contextual (supporting multiple script ranges) or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true, if this NumericShaper is contextual, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isContextual
				/// </java-name>
				[Dot42.DexImport("isContextual", "()Z", AccessFlags = 1)]
				public bool IsContextual() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Transforms the encoding of the text, starting from the character at index start and transforming count characters, using the specified context.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shape
				/// </java-name>
				[Dot42.DexImport("shape", "([CIII)V", AccessFlags = 1)]
				public void Shape(char[] text, int start, int count, int context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Transforms the encoding of the text, starting from the character at index start and transforming count characters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// shape
				/// </java-name>
				[Dot42.DexImport("shape", "([CII)V", AccessFlags = 1)]
				public void Shape(char[] text, int start, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the masks for all of the ranges supported by this NumericShaper, packed into an int value using the logical OR logical operation for multiple ranges: NumericShaper.DEVANAGARI | NumericShaper.BENGALI.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>all ranges of this NumericShaper. </para>
				/// </returns>
				/// <java-name>
				/// getRanges
				/// </java-name>
				public int Ranges
				{
				[Dot42.DexImport("getRanges", "()I", AccessFlags = 1)]
						get{ return GetRanges(); }
				}

		}

}


