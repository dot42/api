#pragma warning disable 1717
namespace Android.Text
{
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

				/// <java-name>
				/// make
				/// </java-name>
				[Dot42.DexImport("make", "(Ljava/lang/CharSequence;[CII)Landroid/text/AlteredCharSequence;", AccessFlags = 9)]
				public static global::Android.Text.AlteredCharSequence Make(global::Java.Lang.ICharSequence charSequence, char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.AlteredCharSequence);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public virtual char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public virtual void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
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
				/// length
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
						get{ return GetLength(); }
				}

		}

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

				/// <java-name>
				/// getDirectionalities
				/// </java-name>
				[Dot42.DexImport("getDirectionalities", "([C[BI)V", AccessFlags = 265)]
				public static void GetDirectionalities(char[] @char, sbyte[] sByte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDirectionalities
				/// </java-name>
				[Dot42.DexImport("getDirectionalities", "([C[BI)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GetDirectionalities(char[] @char, byte[] @byte, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEastAsianWidth
				/// </java-name>
				[Dot42.DexImport("getEastAsianWidth", "(C)I", AccessFlags = 265)]
				public static int GetEastAsianWidth(char @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEastAsianWidths
				/// </java-name>
				[Dot42.DexImport("getEastAsianWidths", "([CII[B)V", AccessFlags = 265)]
				public static void GetEastAsianWidths(char[] @char, int int32, int int321, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEastAsianWidths
				/// </java-name>
				[Dot42.DexImport("getEastAsianWidths", "([CII[B)V", AccessFlags = 265, IgnoreFromJava = true)]
				public static void GetEastAsianWidths(char[] @char, int int32, int int321, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mirror
				/// </java-name>
				[Dot42.DexImport("mirror", "([CII)Z", AccessFlags = 265)]
				public static bool Mirror(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMirror
				/// </java-name>
				[Dot42.DexImport("getMirror", "(C)C", AccessFlags = 265)]
				public static char GetMirror(char @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

		}

		/// <java-name>
		/// android/text/Annotation
		/// </java-name>
		[Dot42.DexImport("android/text/Annotation", AccessFlags = 33)]
		public partial class Annotation : global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public Annotation(string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public Annotation(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
				public virtual int GetSpanTypeId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetKey() /* MethodBuilder.Create */ 
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Annotation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public int SpanTypeId
				{
				[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return GetSpanTypeId(); }
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				public string Key
				{
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetKey(); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				}

		}

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

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Ljava/lang/CharSequence;IILandroid/view/View;)Ljava/lang/String;", AccessFlags = 9)]
				public static string Get(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "(Landroid/view/View;)I", AccessFlags = 9)]
				public static int GetSize(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/text/BoringLayout
		/// </java-name>
		[Dot42.DexImport("android/text/BoringLayout", AccessFlags = 33)]
		public partial class BoringLayout : global::Android.Text.Layout, global::Android.Text.TextUtils.IEllipsizeCallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;Z)V", AccessFlags = 1)]
				public BoringLayout(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, global::Android.Text.BoringLayout.Metrics metrics, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)V", AccessFlags = 1)]
				public BoringLayout(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, global::Android.Text.BoringLayout.Metrics metrics, bool boolean, global::Android.Text.TextUtils.TruncateAt truncateAt, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// make
				/// </java-name>
				[Dot42.DexImport("make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;", AccessFlags = 9)]
				public static global::Android.Text.BoringLayout Make(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, global::Android.Text.BoringLayout.Metrics metrics, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout);
				}

				/// <java-name>
				/// make
				/// </java-name>
				[Dot42.DexImport("make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landr" +
    "oid/text/BoringLayout;", AccessFlags = 9)]
				public static global::Android.Text.BoringLayout Make(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, global::Android.Text.BoringLayout.Metrics metrics, bool boolean, global::Android.Text.TextUtils.TruncateAt truncateAt, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout);
				}

				/// <java-name>
				/// replaceOrMake
				/// </java-name>
				[Dot42.DexImport("replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;", AccessFlags = 1)]
				public virtual global::Android.Text.BoringLayout ReplaceOrMake(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, global::Android.Text.BoringLayout.Metrics metrics, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout);
				}

				/// <java-name>
				/// replaceOrMake
				/// </java-name>
				[Dot42.DexImport("replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landr" +
    "oid/text/BoringLayout;", AccessFlags = 1)]
				public virtual global::Android.Text.BoringLayout ReplaceOrMake(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, global::Android.Text.BoringLayout.Metrics metrics, bool boolean, global::Android.Text.TextUtils.TruncateAt truncateAt, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.BoringLayout);
				}

				/// <java-name>
				/// isBoring
				/// </java-name>
				[Dot42.DexImport("isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)Landroid/text/BoringLayout$Metr" +
    "ics;", AccessFlags = 9)]
				public static global::Android.Text.BoringLayout.Metrics IsBoring(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
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
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
				public override int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
				public override int GetLineCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineTop
				/// </java-name>
				[Dot42.DexImport("getLineTop", "(I)I", AccessFlags = 1)]
				public override int GetLineTop(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineDescent
				/// </java-name>
				[Dot42.DexImport("getLineDescent", "(I)I", AccessFlags = 1)]
				public override int GetLineDescent(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineStart
				/// </java-name>
				[Dot42.DexImport("getLineStart", "(I)I", AccessFlags = 1)]
				public override int GetLineStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getParagraphDirection
				/// </java-name>
				[Dot42.DexImport("getParagraphDirection", "(I)I", AccessFlags = 1)]
				public override int GetParagraphDirection(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineContainsTab
				/// </java-name>
				[Dot42.DexImport("getLineContainsTab", "(I)Z", AccessFlags = 1)]
				public override bool GetLineContainsTab(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLineMax
				/// </java-name>
				[Dot42.DexImport("getLineMax", "(I)F", AccessFlags = 1)]
				public override float GetLineMax(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLineDirections
				/// </java-name>
				[Dot42.DexImport("getLineDirections", "(I)Landroid/text/Layout$Directions;", AccessFlags = 17)]
				public override global::Android.Text.Layout.Directions GetLineDirections(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Directions);
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
				public override int GetTopPadding() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
				public override int GetBottomPadding() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisCount
				/// </java-name>
				[Dot42.DexImport("getEllipsisCount", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisCount(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisStart
				/// </java-name>
				[Dot42.DexImport("getEllipsisStart", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
				public override int GetEllipsizedWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Path path, global::Android.Graphics.Paint paint, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ellipsized
				/// </java-name>
				[Dot42.DexImport("ellipsized", "(II)V", AccessFlags = 1)]
				public virtual void Ellipsized(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BoringLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return GetHeight(); }
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				public int LineCount
				{
				[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
						get{ return GetLineCount(); }
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				public int TopPadding
				{
				[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
						get{ return GetTopPadding(); }
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				public int BottomPadding
				{
				[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
						get{ return GetBottomPadding(); }
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				public int EllipsizedWidth
				{
				[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
						get{ return GetEllipsizedWidth(); }
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

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
				public abstract global::Java.Lang.ICharSequence GetText() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
				public abstract void SetText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasText
				/// </java-name>
				[Dot42.DexImport("hasText", "()Z", AccessFlags = 1025)]
				public abstract bool HasText() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Lang.ICharSequence Text
				{
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
						get{ return GetText(); }
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
						set{ SetText(value); }
				}

		}

		/// <java-name>
		/// android/text/DynamicLayout
		/// </java-name>
		[Dot42.DexImport("android/text/DynamicLayout", AccessFlags = 33)]
		public partial class DynamicLayout : global::Android.Text.Layout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFZ)V", AccessFlags = 1)]
				public DynamicLayout(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroi" +
    "d/text/Layout$Alignment;FFZ)V", AccessFlags = 1)]
				public DynamicLayout(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroi" +
    "d/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V", AccessFlags = 1)]
				public DynamicLayout(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, bool boolean, global::Android.Text.TextUtils.TruncateAt truncateAt, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
				public override int GetLineCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineTop
				/// </java-name>
				[Dot42.DexImport("getLineTop", "(I)I", AccessFlags = 1)]
				public override int GetLineTop(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineDescent
				/// </java-name>
				[Dot42.DexImport("getLineDescent", "(I)I", AccessFlags = 1)]
				public override int GetLineDescent(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineStart
				/// </java-name>
				[Dot42.DexImport("getLineStart", "(I)I", AccessFlags = 1)]
				public override int GetLineStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineContainsTab
				/// </java-name>
				[Dot42.DexImport("getLineContainsTab", "(I)Z", AccessFlags = 1)]
				public override bool GetLineContainsTab(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getParagraphDirection
				/// </java-name>
				[Dot42.DexImport("getParagraphDirection", "(I)I", AccessFlags = 1)]
				public override int GetParagraphDirection(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineDirections
				/// </java-name>
				[Dot42.DexImport("getLineDirections", "(I)Landroid/text/Layout$Directions;", AccessFlags = 17)]
				public override global::Android.Text.Layout.Directions GetLineDirections(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Directions);
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
				public override int GetTopPadding() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
				public override int GetBottomPadding() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
				public override int GetEllipsizedWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisStart
				/// </java-name>
				[Dot42.DexImport("getEllipsisStart", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisCount
				/// </java-name>
				[Dot42.DexImport("getEllipsisCount", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisCount(int int32) /* MethodBuilder.Create */ 
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
				public int LineCount
				{
				[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
						get{ return GetLineCount(); }
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				public int TopPadding
				{
				[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
						get{ return GetTopPadding(); }
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				public int BottomPadding
				{
				[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
						get{ return GetBottomPadding(); }
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				public int EllipsizedWidth
				{
				[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
						get{ return GetEllipsizedWidth(); }
				}

		}

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

				/// <java-name>
				/// fromHtml
				/// </java-name>
				[Dot42.DexImport("fromHtml", "(Ljava/lang/String;)Landroid/text/Spanned;", AccessFlags = 9)]
				public static global::Android.Text.ISpanned FromHtml(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.ISpanned);
				}

				/// <java-name>
				/// fromHtml
				/// </java-name>
				[Dot42.DexImport("fromHtml", "(Ljava/lang/String;Landroid/text/Html$ImageGetter;Landroid/text/Html$TagHandler;)" +
    "Landroid/text/Spanned;", AccessFlags = 9)]
				public static global::Android.Text.ISpanned FromHtml(string @string, global::Android.Text.Html.IImageGetter imageGetter, global::Android.Text.Html.ITagHandler tagHandler) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.ISpanned);
				}

				/// <java-name>
				/// toHtml
				/// </java-name>
				[Dot42.DexImport("toHtml", "(Landroid/text/Spanned;)Ljava/lang/String;", AccessFlags = 9)]
				public static string ToHtml(global::Android.Text.ISpanned spanned) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// android/text/Html$TagHandler
				/// </java-name>
				[Dot42.DexImport("android/text/Html$TagHandler", AccessFlags = 1545)]
				public partial interface ITagHandler
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// handleTag
						/// </java-name>
						[Dot42.DexImport("handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V", AccessFlags = 1025)]
						void HandleTag(bool boolean, string @string, global::Android.Text.IEditable editable, global::Org.Xml.Sax.IXMLReader xMLReader) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/text/Html$ImageGetter
				/// </java-name>
				[Dot42.DexImport("android/text/Html$ImageGetter", AccessFlags = 1545)]
				public partial interface IImageGetter
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// getDrawable
						/// </java-name>
						[Dot42.DexImport("getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						global::Android.Graphics.Drawable.Drawable GetDrawable(string @string) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/text/Editable
		/// </java-name>
		[Dot42.DexImport("android/text/Editable", AccessFlags = 1537)]
		public partial interface IEditable : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars, global::Android.Text.ISpannable, global::Java.Lang.IAppendable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Replace(int int32, int int321, global::Java.Lang.ICharSequence charSequence, int int322, int int323) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Replace(int int32, int int321, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Insert(int int32, global::Java.Lang.ICharSequence charSequence, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Insert(int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Delete(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(C)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable Append(char @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearSpans
				/// </java-name>
				[Dot42.DexImport("clearSpans", "()V", AccessFlags = 1025)]
				void ClearSpans() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFilters
				/// </java-name>
				[Dot42.DexImport("setFilters", "([Landroid/text/InputFilter;)V", AccessFlags = 1025)]
				void SetFilters(global::Android.Text.IInputFilter[] inputFilter) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getFilters
				/// </java-name>
				[Dot42.DexImport("getFilters", "()[Landroid/text/InputFilter;", AccessFlags = 1025)]
				global::Android.Text.IInputFilter[] GetFilters() /* MethodBuilder.Create */ ;

		}

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

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/Editable$Factory;", AccessFlags = 9)]
				public static global::Android.Text.IEditable_Factory GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.IEditable_Factory);
				}

				/// <java-name>
				/// newEditable
				/// </java-name>
				[Dot42.DexImport("newEditable", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1)]
				public virtual global::Android.Text.IEditable NewEditable(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.IEditable);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.IEditable_Factory Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/Editable$Factory;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <java-name>
		/// android/text/GetChars
		/// </java-name>
		[Dot42.DexImport("android/text/GetChars", AccessFlags = 1537)]
		public partial interface IGetChars : global::Java.Lang.ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1025)]
				void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/InputFilter
		/// </java-name>
		[Dot42.DexImport("android/text/InputFilter", AccessFlags = 1537)]
		public partial interface IInputFilter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.ISpanned spanned, int int322, int int323) /* MethodBuilder.Create */ ;

		}

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

				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.ISpanned spanned, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

		}

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

				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.ISpanned spanned, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IInputFilter_LengthFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/text/InputType
		/// </java-name>
		[Dot42.DexImport("android/text/InputType", AccessFlags = 1537)]
		public partial interface IInputType
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/text/InputType
		/// </java-name>
		[Dot42.DexImport("android/text/InputType", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IInputTypeConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_MASK_CLASS
				/// </java-name>
				[Dot42.DexImport("TYPE_MASK_CLASS", "I", AccessFlags = 25)]
				public const int TYPE_MASK_CLASS = 15;
				/// <java-name>
				/// TYPE_MASK_VARIATION
				/// </java-name>
				[Dot42.DexImport("TYPE_MASK_VARIATION", "I", AccessFlags = 25)]
				public const int TYPE_MASK_VARIATION = 4080;
				/// <java-name>
				/// TYPE_MASK_FLAGS
				/// </java-name>
				[Dot42.DexImport("TYPE_MASK_FLAGS", "I", AccessFlags = 25)]
				public const int TYPE_MASK_FLAGS = 16773120;
				/// <java-name>
				/// TYPE_NULL
				/// </java-name>
				[Dot42.DexImport("TYPE_NULL", "I", AccessFlags = 25)]
				public const int TYPE_NULL = 0;
				/// <java-name>
				/// TYPE_CLASS_TEXT
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASS_TEXT", "I", AccessFlags = 25)]
				public const int TYPE_CLASS_TEXT = 1;
				/// <java-name>
				/// TYPE_TEXT_FLAG_CAP_CHARACTERS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_CAP_CHARACTERS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_CAP_CHARACTERS = 4096;
				/// <java-name>
				/// TYPE_TEXT_FLAG_CAP_WORDS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_CAP_WORDS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_CAP_WORDS = 8192;
				/// <java-name>
				/// TYPE_TEXT_FLAG_CAP_SENTENCES
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_CAP_SENTENCES", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_CAP_SENTENCES = 16384;
				/// <java-name>
				/// TYPE_TEXT_FLAG_AUTO_CORRECT
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_AUTO_CORRECT", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_AUTO_CORRECT = 32768;
				/// <java-name>
				/// TYPE_TEXT_FLAG_AUTO_COMPLETE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_AUTO_COMPLETE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_AUTO_COMPLETE = 65536;
				/// <java-name>
				/// TYPE_TEXT_FLAG_MULTI_LINE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_MULTI_LINE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_MULTI_LINE = 131072;
				/// <java-name>
				/// TYPE_TEXT_FLAG_IME_MULTI_LINE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_IME_MULTI_LINE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_IME_MULTI_LINE = 262144;
				/// <java-name>
				/// TYPE_TEXT_FLAG_NO_SUGGESTIONS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_FLAG_NO_SUGGESTIONS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_FLAG_NO_SUGGESTIONS = 524288;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_NORMAL
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_NORMAL", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_NORMAL = 0;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_URI
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_URI", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_URI = 16;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_EMAIL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_EMAIL_ADDRESS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_EMAIL_ADDRESS = 32;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_EMAIL_SUBJECT
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_EMAIL_SUBJECT", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_EMAIL_SUBJECT = 48;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_SHORT_MESSAGE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_SHORT_MESSAGE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_SHORT_MESSAGE = 64;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_LONG_MESSAGE
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_LONG_MESSAGE", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_LONG_MESSAGE = 80;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_PERSON_NAME
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_PERSON_NAME", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_PERSON_NAME = 96;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_POSTAL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_POSTAL_ADDRESS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_POSTAL_ADDRESS = 112;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_PASSWORD
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_PASSWORD", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_PASSWORD = 128;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_VISIBLE_PASSWORD
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_VISIBLE_PASSWORD", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_VISIBLE_PASSWORD = 144;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_WEB_EDIT_TEXT
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_WEB_EDIT_TEXT", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_WEB_EDIT_TEXT = 160;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_FILTER
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_FILTER", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_FILTER = 176;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_PHONETIC
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_PHONETIC", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_PHONETIC = 192;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_WEB_EMAIL_ADDRESS = 208;
				/// <java-name>
				/// TYPE_TEXT_VARIATION_WEB_PASSWORD
				/// </java-name>
				[Dot42.DexImport("TYPE_TEXT_VARIATION_WEB_PASSWORD", "I", AccessFlags = 25)]
				public const int TYPE_TEXT_VARIATION_WEB_PASSWORD = 224;
				/// <java-name>
				/// TYPE_CLASS_NUMBER
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASS_NUMBER", "I", AccessFlags = 25)]
				public const int TYPE_CLASS_NUMBER = 2;
				/// <java-name>
				/// TYPE_NUMBER_FLAG_SIGNED
				/// </java-name>
				[Dot42.DexImport("TYPE_NUMBER_FLAG_SIGNED", "I", AccessFlags = 25)]
				public const int TYPE_NUMBER_FLAG_SIGNED = 4096;
				/// <java-name>
				/// TYPE_NUMBER_FLAG_DECIMAL
				/// </java-name>
				[Dot42.DexImport("TYPE_NUMBER_FLAG_DECIMAL", "I", AccessFlags = 25)]
				public const int TYPE_NUMBER_FLAG_DECIMAL = 8192;
				/// <java-name>
				/// TYPE_NUMBER_VARIATION_NORMAL
				/// </java-name>
				[Dot42.DexImport("TYPE_NUMBER_VARIATION_NORMAL", "I", AccessFlags = 25)]
				public const int TYPE_NUMBER_VARIATION_NORMAL = 0;
				/// <java-name>
				/// TYPE_NUMBER_VARIATION_PASSWORD
				/// </java-name>
				[Dot42.DexImport("TYPE_NUMBER_VARIATION_PASSWORD", "I", AccessFlags = 25)]
				public const int TYPE_NUMBER_VARIATION_PASSWORD = 16;
				/// <java-name>
				/// TYPE_CLASS_PHONE
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASS_PHONE", "I", AccessFlags = 25)]
				public const int TYPE_CLASS_PHONE = 3;
				/// <java-name>
				/// TYPE_CLASS_DATETIME
				/// </java-name>
				[Dot42.DexImport("TYPE_CLASS_DATETIME", "I", AccessFlags = 25)]
				public const int TYPE_CLASS_DATETIME = 4;
				/// <java-name>
				/// TYPE_DATETIME_VARIATION_NORMAL
				/// </java-name>
				[Dot42.DexImport("TYPE_DATETIME_VARIATION_NORMAL", "I", AccessFlags = 25)]
				public const int TYPE_DATETIME_VARIATION_NORMAL = 0;
				/// <java-name>
				/// TYPE_DATETIME_VARIATION_DATE
				/// </java-name>
				[Dot42.DexImport("TYPE_DATETIME_VARIATION_DATE", "I", AccessFlags = 25)]
				public const int TYPE_DATETIME_VARIATION_DATE = 16;
				/// <java-name>
				/// TYPE_DATETIME_VARIATION_TIME
				/// </java-name>
				[Dot42.DexImport("TYPE_DATETIME_VARIATION_TIME", "I", AccessFlags = 25)]
				public const int TYPE_DATETIME_VARIATION_TIME = 32;
		}

		/// <java-name>
		/// android/text/NoCopySpan
		/// </java-name>
		[Dot42.DexImport("android/text/NoCopySpan", AccessFlags = 1537)]
		public partial interface INoCopySpan
 /* scope: __dot42__ */ 
		{
		}

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

		/// <java-name>
		/// android/text/ParcelableSpan
		/// </java-name>
		[Dot42.DexImport("android/text/ParcelableSpan", AccessFlags = 1537)]
		public partial interface IParcelableSpan : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1025)]
				int GetSpanTypeId() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/Spannable
		/// </java-name>
		[Dot42.DexImport("android/text/Spannable", AccessFlags = 1537)]
		public partial interface ISpannable : global::Android.Text.ISpanned
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setSpan
				/// </java-name>
				[Dot42.DexImport("setSpan", "(Ljava/lang/Object;III)V", AccessFlags = 1025)]
				void SetSpan(object @object, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeSpan
				/// </java-name>
				[Dot42.DexImport("removeSpan", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				void RemoveSpan(object @object) /* MethodBuilder.Create */ ;

		}

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

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/Spannable$Factory;", AccessFlags = 9)]
				public static global::Android.Text.ISpannable_Factory GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.ISpannable_Factory);
				}

				/// <java-name>
				/// newSpannable
				/// </java-name>
				[Dot42.DexImport("newSpannable", "(Ljava/lang/CharSequence;)Landroid/text/Spannable;", AccessFlags = 1)]
				public virtual global::Android.Text.ISpannable NewSpannable(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.ISpannable);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.ISpannable_Factory Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/Spannable$Factory;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <java-name>
		/// android/text/Spanned
		/// </java-name>
		[Dot42.DexImport("android/text/Spanned", AccessFlags = 1537)]
		public partial interface ISpanned : global::Java.Lang.ICharSequence
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getSpans
				/// </java-name>
				[Dot42.DexImport("getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", AccessFlags = 1025, Signature = "<T:Ljava/lang/Object;>(IILjava/lang/Class<TT;>;)[TT;")]
				T[] GetSpans<T>(int int32, int int321, global::System.Type type) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSpanStart
				/// </java-name>
				[Dot42.DexImport("getSpanStart", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int GetSpanStart(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSpanEnd
				/// </java-name>
				[Dot42.DexImport("getSpanEnd", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int GetSpanEnd(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSpanFlags
				/// </java-name>
				[Dot42.DexImport("getSpanFlags", "(Ljava/lang/Object;)I", AccessFlags = 1025)]
				int GetSpanFlags(object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// nextSpanTransition
				/// </java-name>
				[Dot42.DexImport("nextSpanTransition", "(IILjava/lang/Class;)I", AccessFlags = 1025)]
				int NextSpanTransition(int int32, int int321, global::System.Type type) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/Spanned
		/// </java-name>
		[Dot42.DexImport("android/text/Spanned", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISpannedConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SPAN_POINT_MARK_MASK
				/// </java-name>
				[Dot42.DexImport("SPAN_POINT_MARK_MASK", "I", AccessFlags = 25)]
				public const int SPAN_POINT_MARK_MASK = 51;
				/// <java-name>
				/// SPAN_MARK_MARK
				/// </java-name>
				[Dot42.DexImport("SPAN_MARK_MARK", "I", AccessFlags = 25)]
				public const int SPAN_MARK_MARK = 17;
				/// <java-name>
				/// SPAN_MARK_POINT
				/// </java-name>
				[Dot42.DexImport("SPAN_MARK_POINT", "I", AccessFlags = 25)]
				public const int SPAN_MARK_POINT = 18;
				/// <java-name>
				/// SPAN_POINT_MARK
				/// </java-name>
				[Dot42.DexImport("SPAN_POINT_MARK", "I", AccessFlags = 25)]
				public const int SPAN_POINT_MARK = 33;
				/// <java-name>
				/// SPAN_POINT_POINT
				/// </java-name>
				[Dot42.DexImport("SPAN_POINT_POINT", "I", AccessFlags = 25)]
				public const int SPAN_POINT_POINT = 34;
				/// <java-name>
				/// SPAN_PARAGRAPH
				/// </java-name>
				[Dot42.DexImport("SPAN_PARAGRAPH", "I", AccessFlags = 25)]
				public const int SPAN_PARAGRAPH = 51;
				/// <java-name>
				/// SPAN_INCLUSIVE_EXCLUSIVE
				/// </java-name>
				[Dot42.DexImport("SPAN_INCLUSIVE_EXCLUSIVE", "I", AccessFlags = 25)]
				public const int SPAN_INCLUSIVE_EXCLUSIVE = 17;
				/// <java-name>
				/// SPAN_INCLUSIVE_INCLUSIVE
				/// </java-name>
				[Dot42.DexImport("SPAN_INCLUSIVE_INCLUSIVE", "I", AccessFlags = 25)]
				public const int SPAN_INCLUSIVE_INCLUSIVE = 18;
				/// <java-name>
				/// SPAN_EXCLUSIVE_EXCLUSIVE
				/// </java-name>
				[Dot42.DexImport("SPAN_EXCLUSIVE_EXCLUSIVE", "I", AccessFlags = 25)]
				public const int SPAN_EXCLUSIVE_EXCLUSIVE = 33;
				/// <java-name>
				/// SPAN_EXCLUSIVE_INCLUSIVE
				/// </java-name>
				[Dot42.DexImport("SPAN_EXCLUSIVE_INCLUSIVE", "I", AccessFlags = 25)]
				public const int SPAN_EXCLUSIVE_INCLUSIVE = 34;
				/// <java-name>
				/// SPAN_COMPOSING
				/// </java-name>
				[Dot42.DexImport("SPAN_COMPOSING", "I", AccessFlags = 25)]
				public const int SPAN_COMPOSING = 256;
				/// <java-name>
				/// SPAN_INTERMEDIATE
				/// </java-name>
				[Dot42.DexImport("SPAN_INTERMEDIATE", "I", AccessFlags = 25)]
				public const int SPAN_INTERMEDIATE = 512;
				/// <java-name>
				/// SPAN_USER_SHIFT
				/// </java-name>
				[Dot42.DexImport("SPAN_USER_SHIFT", "I", AccessFlags = 25)]
				public const int SPAN_USER_SHIFT = 24;
				/// <java-name>
				/// SPAN_USER
				/// </java-name>
				[Dot42.DexImport("SPAN_USER", "I", AccessFlags = 25)]
				public const int SPAN_USER = -16777216;
				/// <java-name>
				/// SPAN_PRIORITY_SHIFT
				/// </java-name>
				[Dot42.DexImport("SPAN_PRIORITY_SHIFT", "I", AccessFlags = 25)]
				public const int SPAN_PRIORITY_SHIFT = 16;
				/// <java-name>
				/// SPAN_PRIORITY
				/// </java-name>
				[Dot42.DexImport("SPAN_PRIORITY", "I", AccessFlags = 25)]
				public const int SPAN_PRIORITY = 16711680;
		}

		/// <java-name>
		/// android/text/SpanWatcher
		/// </java-name>
		[Dot42.DexImport("android/text/SpanWatcher", AccessFlags = 1537)]
		public partial interface ISpanWatcher : global::Android.Text.INoCopySpan
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onSpanAdded
				/// </java-name>
				[Dot42.DexImport("onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1025)]
				void OnSpanAdded(global::Android.Text.ISpannable spannable, object @object, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onSpanRemoved
				/// </java-name>
				[Dot42.DexImport("onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1025)]
				void OnSpanRemoved(global::Android.Text.ISpannable spannable, object @object, int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onSpanChanged
				/// </java-name>
				[Dot42.DexImport("onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V", AccessFlags = 1025)]
				void OnSpanChanged(global::Android.Text.ISpannable spannable, object @object, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/TextWatcher
		/// </java-name>
		[Dot42.DexImport("android/text/TextWatcher", AccessFlags = 1537)]
		public partial interface ITextWatcher : global::Android.Text.INoCopySpan
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// beforeTextChanged
				/// </java-name>
				[Dot42.DexImport("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1025)]
				void BeforeTextChanged(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1025)]
				void OnTextChanged(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// afterTextChanged
				/// </java-name>
				[Dot42.DexImport("afterTextChanged", "(Landroid/text/Editable;)V", AccessFlags = 1025)]
				void AfterTextChanged(global::Android.Text.IEditable editable) /* MethodBuilder.Create */ ;

		}

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
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FF)V", AccessFlags = 4)]
				protected internal Layout(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDesiredWidth
				/// </java-name>
				[Dot42.DexImport("getDesiredWidth", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)F", AccessFlags = 9)]
				public static float GetDesiredWidth(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getDesiredWidth
				/// </java-name>
				[Dot42.DexImport("getDesiredWidth", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;)F", AccessFlags = 9)]
				public static float GetDesiredWidth(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Path path, global::Android.Graphics.Paint paint, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 17)]
				public global::Java.Lang.ICharSequence GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				[Dot42.DexImport("getPaint", "()Landroid/text/TextPaint;", AccessFlags = 17)]
				public global::Android.Text.TextPaint GetPaint() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.TextPaint);
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 17)]
				public int GetWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
				public virtual int GetEllipsizedWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// increaseWidthTo
				/// </java-name>
				[Dot42.DexImport("increaseWidthTo", "(I)V", AccessFlags = 17)]
				public void IncreaseWidthTo(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
				public virtual int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAlignment
				/// </java-name>
				[Dot42.DexImport("getAlignment", "()Landroid/text/Layout$Alignment;", AccessFlags = 17)]
				public global::Android.Text.Layout.Alignment GetAlignment() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Alignment);
				}

				/// <java-name>
				/// getSpacingMultiplier
				/// </java-name>
				[Dot42.DexImport("getSpacingMultiplier", "()F", AccessFlags = 17)]
				public float GetSpacingMultiplier() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getSpacingAdd
				/// </java-name>
				[Dot42.DexImport("getSpacingAdd", "()F", AccessFlags = 17)]
				public float GetSpacingAdd() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1025)]
				public abstract int GetLineCount() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLineBounds
				/// </java-name>
				[Dot42.DexImport("getLineBounds", "(ILandroid/graphics/Rect;)I", AccessFlags = 1)]
				public virtual int GetLineBounds(int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineTop
				/// </java-name>
				[Dot42.DexImport("getLineTop", "(I)I", AccessFlags = 1025)]
				public abstract int GetLineTop(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLineDescent
				/// </java-name>
				[Dot42.DexImport("getLineDescent", "(I)I", AccessFlags = 1025)]
				public abstract int GetLineDescent(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLineStart
				/// </java-name>
				[Dot42.DexImport("getLineStart", "(I)I", AccessFlags = 1025)]
				public abstract int GetLineStart(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getParagraphDirection
				/// </java-name>
				[Dot42.DexImport("getParagraphDirection", "(I)I", AccessFlags = 1025)]
				public abstract int GetParagraphDirection(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLineContainsTab
				/// </java-name>
				[Dot42.DexImport("getLineContainsTab", "(I)Z", AccessFlags = 1025)]
				public abstract bool GetLineContainsTab(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getLineDirections
				/// </java-name>
				[Dot42.DexImport("getLineDirections", "(I)Landroid/text/Layout$Directions;", AccessFlags = 1025)]
				public abstract global::Android.Text.Layout.Directions GetLineDirections(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1025)]
				public abstract int GetTopPadding() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1025)]
				public abstract int GetBottomPadding() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isRtlCharAt
				/// </java-name>
				[Dot42.DexImport("isRtlCharAt", "(I)Z", AccessFlags = 1)]
				public virtual bool IsRtlCharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPrimaryHorizontal
				/// </java-name>
				[Dot42.DexImport("getPrimaryHorizontal", "(I)F", AccessFlags = 1)]
				public virtual float GetPrimaryHorizontal(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getSecondaryHorizontal
				/// </java-name>
				[Dot42.DexImport("getSecondaryHorizontal", "(I)F", AccessFlags = 1)]
				public virtual float GetSecondaryHorizontal(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLineLeft
				/// </java-name>
				[Dot42.DexImport("getLineLeft", "(I)F", AccessFlags = 1)]
				public virtual float GetLineLeft(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLineRight
				/// </java-name>
				[Dot42.DexImport("getLineRight", "(I)F", AccessFlags = 1)]
				public virtual float GetLineRight(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLineMax
				/// </java-name>
				[Dot42.DexImport("getLineMax", "(I)F", AccessFlags = 1)]
				public virtual float GetLineMax(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLineWidth
				/// </java-name>
				[Dot42.DexImport("getLineWidth", "(I)F", AccessFlags = 1)]
				public virtual float GetLineWidth(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getLineForVertical
				/// </java-name>
				[Dot42.DexImport("getLineForVertical", "(I)I", AccessFlags = 1)]
				public virtual int GetLineForVertical(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineForOffset
				/// </java-name>
				[Dot42.DexImport("getLineForOffset", "(I)I", AccessFlags = 1)]
				public virtual int GetLineForOffset(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffsetForHorizontal
				/// </java-name>
				[Dot42.DexImport("getOffsetForHorizontal", "(IF)I", AccessFlags = 1)]
				public virtual int GetOffsetForHorizontal(int int32, float single) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineEnd
				/// </java-name>
				[Dot42.DexImport("getLineEnd", "(I)I", AccessFlags = 17)]
				public int GetLineEnd(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineVisibleEnd
				/// </java-name>
				[Dot42.DexImport("getLineVisibleEnd", "(I)I", AccessFlags = 1)]
				public virtual int GetLineVisibleEnd(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineBottom
				/// </java-name>
				[Dot42.DexImport("getLineBottom", "(I)I", AccessFlags = 17)]
				public int GetLineBottom(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineBaseline
				/// </java-name>
				[Dot42.DexImport("getLineBaseline", "(I)I", AccessFlags = 17)]
				public int GetLineBaseline(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineAscent
				/// </java-name>
				[Dot42.DexImport("getLineAscent", "(I)I", AccessFlags = 17)]
				public int GetLineAscent(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffsetToLeftOf
				/// </java-name>
				[Dot42.DexImport("getOffsetToLeftOf", "(I)I", AccessFlags = 1)]
				public virtual int GetOffsetToLeftOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffsetToRightOf
				/// </java-name>
				[Dot42.DexImport("getOffsetToRightOf", "(I)I", AccessFlags = 1)]
				public virtual int GetOffsetToRightOf(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCursorPath
				/// </java-name>
				[Dot42.DexImport("getCursorPath", "(ILandroid/graphics/Path;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void GetCursorPath(int int32, global::Android.Graphics.Path path, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSelectionPath
				/// </java-name>
				[Dot42.DexImport("getSelectionPath", "(IILandroid/graphics/Path;)V", AccessFlags = 1)]
				public virtual void GetSelectionPath(int int32, int int321, global::Android.Graphics.Path path) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getParagraphAlignment
				/// </java-name>
				[Dot42.DexImport("getParagraphAlignment", "(I)Landroid/text/Layout$Alignment;", AccessFlags = 17)]
				public global::Android.Text.Layout.Alignment GetParagraphAlignment(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Alignment);
				}

				/// <java-name>
				/// getParagraphLeft
				/// </java-name>
				[Dot42.DexImport("getParagraphLeft", "(I)I", AccessFlags = 17)]
				public int GetParagraphLeft(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getParagraphRight
				/// </java-name>
				[Dot42.DexImport("getParagraphRight", "(I)I", AccessFlags = 17)]
				public int GetParagraphRight(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isSpanned
				/// </java-name>
				[Dot42.DexImport("isSpanned", "()Z", AccessFlags = 20)]
				protected internal bool IsSpanned() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getEllipsisStart
				/// </java-name>
				[Dot42.DexImport("getEllipsisStart", "(I)I", AccessFlags = 1025)]
				public abstract int GetEllipsisStart(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEllipsisCount
				/// </java-name>
				[Dot42.DexImport("getEllipsisCount", "(I)I", AccessFlags = 1025)]
				public abstract int GetEllipsisCount(int int32) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Layout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Lang.ICharSequence Text
				{
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 17)]
						get{ return GetText(); }
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				public global::Android.Text.TextPaint Paint
				{
				[Dot42.DexImport("getPaint", "()Landroid/text/TextPaint;", AccessFlags = 17)]
						get{ return GetPaint(); }
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
				[Dot42.DexImport("getWidth", "()I", AccessFlags = 17)]
						get{ return GetWidth(); }
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				public int EllipsizedWidth
				{
				[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
						get{ return GetEllipsizedWidth(); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return GetHeight(); }
				}

				/// <java-name>
				/// getSpacingMultiplier
				/// </java-name>
				public float SpacingMultiplier
				{
				[Dot42.DexImport("getSpacingMultiplier", "()F", AccessFlags = 17)]
						get{ return GetSpacingMultiplier(); }
				}

				/// <java-name>
				/// getSpacingAdd
				/// </java-name>
				public float SpacingAdd
				{
				[Dot42.DexImport("getSpacingAdd", "()F", AccessFlags = 17)]
						get{ return GetSpacingAdd(); }
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				public int LineCount
				{
				[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1025)]
						get{ return GetLineCount(); }
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				public int TopPadding
				{
				[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1025)]
						get{ return GetTopPadding(); }
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				public int BottomPadding
				{
				[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1025)]
						get{ return GetBottomPadding(); }
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

		/// <java-name>
		/// android/text/LoginFilter
		/// </java-name>
		[Dot42.DexImport("android/text/LoginFilter", AccessFlags = 1057)]
		public abstract partial class LoginFilter : global::Android.Text.IInputFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal LoginFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.ISpanned spanned, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public virtual void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInvalidCharacter
				/// </java-name>
				[Dot42.DexImport("onInvalidCharacter", "(C)V", AccessFlags = 1)]
				public virtual void OnInvalidCharacter(char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1)]
				public virtual void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isAllowed
				/// </java-name>
				[Dot42.DexImport("isAllowed", "(C)Z", AccessFlags = 1025)]
				public abstract bool IsAllowed(char @char) /* MethodBuilder.Create */ ;

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
						public override bool IsAllowed(char @char) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

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
						public override bool IsAllowed(char @char) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

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
						public override bool IsAllowed(char @char) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

		}

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

				/// <java-name>
				/// getSelectionStart
				/// </java-name>
				[Dot42.DexImport("getSelectionStart", "(Ljava/lang/CharSequence;)I", AccessFlags = 25)]
				public static int GetSelectionStart(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSelectionEnd
				/// </java-name>
				[Dot42.DexImport("getSelectionEnd", "(Ljava/lang/CharSequence;)I", AccessFlags = 25)]
				public static int GetSelectionEnd(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(Landroid/text/Spannable;II)V", AccessFlags = 9)]
				public static void SetSelection(global::Android.Text.ISpannable spannable, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(Landroid/text/Spannable;I)V", AccessFlags = 25)]
				public static void SetSelection(global::Android.Text.ISpannable spannable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// selectAll
				/// </java-name>
				[Dot42.DexImport("selectAll", "(Landroid/text/Spannable;)V", AccessFlags = 25)]
				public static void SelectAll(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// extendSelection
				/// </java-name>
				[Dot42.DexImport("extendSelection", "(Landroid/text/Spannable;I)V", AccessFlags = 25)]
				public static void ExtendSelection(global::Android.Text.ISpannable spannable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeSelection
				/// </java-name>
				[Dot42.DexImport("removeSelection", "(Landroid/text/Spannable;)V", AccessFlags = 25)]
				public static void RemoveSelection(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// moveUp
				/// </java-name>
				[Dot42.DexImport("moveUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveUp(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveDown
				/// </java-name>
				[Dot42.DexImport("moveDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveDown(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveLeft
				/// </java-name>
				[Dot42.DexImport("moveLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveLeft(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveRight
				/// </java-name>
				[Dot42.DexImport("moveRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveRight(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// extendUp
				/// </java-name>
				[Dot42.DexImport("extendUp", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendUp(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// extendDown
				/// </java-name>
				[Dot42.DexImport("extendDown", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendDown(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// extendLeft
				/// </java-name>
				[Dot42.DexImport("extendLeft", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendLeft(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// extendRight
				/// </java-name>
				[Dot42.DexImport("extendRight", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendRight(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// extendToLeftEdge
				/// </java-name>
				[Dot42.DexImport("extendToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendToLeftEdge(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// extendToRightEdge
				/// </java-name>
				[Dot42.DexImport("extendToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool ExtendToRightEdge(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToLeftEdge
				/// </java-name>
				[Dot42.DexImport("moveToLeftEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveToLeftEdge(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveToRightEdge
				/// </java-name>
				[Dot42.DexImport("moveToRightEdge", "(Landroid/text/Spannable;Landroid/text/Layout;)Z", AccessFlags = 9)]
				public static bool MoveToRightEdge(global::Android.Text.ISpannable spannable, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// android/text/SpannableString
		/// </java-name>
		[Dot42.DexImport("android/text/SpannableString", AccessFlags = 33)]
		public partial class SpannableString : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars, global::Android.Text.ISpannable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public SpannableString(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableString;", AccessFlags = 9)]
				public static global::Android.Text.SpannableString ValueOf(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableString);
				}

				/// <java-name>
				/// setSpan
				/// </java-name>
				[Dot42.DexImport("setSpan", "(Ljava/lang/Object;III)V", AccessFlags = 1)]
				public virtual void SetSpan(object @object, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeSpan
				/// </java-name>
				[Dot42.DexImport("removeSpan", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void RemoveSpan(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 17)]
				public global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int GetLength() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// length
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
						get{ return GetLength(); }
				}

		}

		/// <java-name>
		/// android/text/SpannableStringBuilder
		/// </java-name>
		[Dot42.DexImport("android/text/SpannableStringBuilder", AccessFlags = 33)]
		public partial class SpannableStringBuilder : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars, global::Android.Text.ISpannable, global::Android.Text.IEditable, global::Java.Lang.IAppendable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SpannableStringBuilder() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public SpannableStringBuilder(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;II)V", AccessFlags = 1)]
				public SpannableStringBuilder(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", AccessFlags = 9)]
				public static global::Android.Text.SpannableStringBuilder ValueOf(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <java-name>
				/// charAt
				/// </java-name>
				[Dot42.DexImport("charAt", "(I)C", AccessFlags = 1)]
				public virtual char CharAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int GetLength() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Insert(int int32, global::Java.Lang.ICharSequence charSequence, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(ILjava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Insert(int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <java-name>
				/// delete
				/// </java-name>
				[Dot42.DexImport("delete", "(II)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Delete(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/CharSequence;)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Replace(int int32, int int321, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(IILjava/lang/CharSequence;II)Landroid/text/SpannableStringBuilder;", AccessFlags = 1)]
				public virtual global::Android.Text.SpannableStringBuilder Replace(int int32, int int321, global::Java.Lang.ICharSequence charSequence, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannableStringBuilder);
				}

				/// <java-name>
				/// setSpan
				/// </java-name>
				[Dot42.DexImport("setSpan", "(Ljava/lang/Object;III)V", AccessFlags = 1)]
				public virtual void SetSpan(object @object, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeSpan
				/// </java-name>
				[Dot42.DexImport("removeSpan", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void RemoveSpan(object @object) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// subSequence
				/// </java-name>
				[Dot42.DexImport("subSequence", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence SubSequence(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getChars
				/// </java-name>
				[Dot42.DexImport("getChars", "(II[CI)V", AccessFlags = 1)]
				public virtual void GetChars(int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
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
				/// getTextRunCursor
				/// </java-name>
				[Dot42.DexImport("getTextRunCursor", "(IIIIILandroid/graphics/Paint;)I", AccessFlags = 1)]
				public virtual int GetTextRunCursor(int int32, int int321, int int322, int int323, int int324, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setFilters
				/// </java-name>
				[Dot42.DexImport("setFilters", "([Landroid/text/InputFilter;)V", AccessFlags = 1)]
				public virtual void SetFilters(global::Android.Text.IInputFilter[] inputFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFilters
				/// </java-name>
				[Dot42.DexImport("getFilters", "()[Landroid/text/InputFilter;", AccessFlags = 1)]
				public virtual global::Android.Text.IInputFilter[] GetFilters() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.IInputFilter[]);
				}

				[Dot42.DexImport("android/text/Editable", "replace", "(IILjava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Replace(int int32, int int321, global::Java.Lang.ICharSequence charSequence, int int322, int int323) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "replace", "(IILjava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Replace(int int32, int int321, global::Java.Lang.ICharSequence charSequence) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "insert", "(ILjava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Insert(int int32, global::Java.Lang.ICharSequence charSequence, int int321, int int322) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "insert", "(ILjava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Insert(int int32, global::Java.Lang.ICharSequence charSequence) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "delete", "(II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Delete(int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "append", "(Ljava/lang/CharSequence;)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Append(global::Java.Lang.ICharSequence charSequence) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "append", "(Ljava/lang/CharSequence;II)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("android/text/Editable", "append", "(C)Landroid/text/Editable;", AccessFlags = 1025)]
				global::Android.Text.IEditable global::Android.Text.IEditable.Append(char @char) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Text.IEditable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(C)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(char @char) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence charSequence) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				[Dot42.DexImport("java/lang/Appendable", "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", AccessFlags = 1025)]
				global::Java.Lang.IAppendable global::Java.Lang.IAppendable.JavaAppend(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.IAppendable);
				}

				/// <java-name>
				/// length
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
						get{ return GetLength(); }
				}

				/// <java-name>
				/// getFilters
				/// </java-name>
				public global::Android.Text.IInputFilter[] Filters
				{
				[Dot42.DexImport("getFilters", "()[Landroid/text/InputFilter;", AccessFlags = 1)]
						get{ return GetFilters(); }
				[Dot42.DexImport("setFilters", "([Landroid/text/InputFilter;)V", AccessFlags = 1)]
						set{ SetFilters(value); }
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

		}

		/// <java-name>
		/// android/text/SpannedString
		/// </java-name>
		[Dot42.DexImport("android/text/SpannedString", AccessFlags = 49)]
		public sealed partial class SpannedString : global::Java.Lang.ICharSequence, global::Android.Text.IGetChars, global::Android.Text.ISpanned
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public SpannedString(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
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
				/// valueOf
				/// </java-name>
				[Dot42.DexImport("valueOf", "(Ljava/lang/CharSequence;)Landroid/text/SpannedString;", AccessFlags = 9)]
				public static global::Android.Text.SpannedString ValueOf(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.SpannedString);
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
				public int GetLength() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// length
				/// </java-name>
				public int Length
				{
				[Dot42.DexImport("length", "()I", AccessFlags = 17)]
						get{ return GetLength(); }
				}

		}

		/// <java-name>
		/// android/text/StaticLayout
		/// </java-name>
		[Dot42.DexImport("android/text/StaticLayout", AccessFlags = 33)]
		public partial class StaticLayout : global::Android.Text.Layout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;" +
    "FFZ)V", AccessFlags = 1)]
				public StaticLayout(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, int int32, global::Android.Text.Layout.Alignment alignment, float single, float single1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignmen" +
    "t;FFZ)V", AccessFlags = 1)]
				public StaticLayout(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.TextPaint textPaint, int int322, global::Android.Text.Layout.Alignment alignment, float single, float single1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignmen" +
    "t;FFZLandroid/text/TextUtils$TruncateAt;I)V", AccessFlags = 1)]
				public StaticLayout(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.TextPaint textPaint, int int322, global::Android.Text.Layout.Alignment alignment, float single, float single1, bool boolean, global::Android.Text.TextUtils.TruncateAt truncateAt, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLineForVertical
				/// </java-name>
				[Dot42.DexImport("getLineForVertical", "(I)I", AccessFlags = 1)]
				public override int GetLineForVertical(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
				public override int GetLineCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineTop
				/// </java-name>
				[Dot42.DexImport("getLineTop", "(I)I", AccessFlags = 1)]
				public override int GetLineTop(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineDescent
				/// </java-name>
				[Dot42.DexImport("getLineDescent", "(I)I", AccessFlags = 1)]
				public override int GetLineDescent(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineStart
				/// </java-name>
				[Dot42.DexImport("getLineStart", "(I)I", AccessFlags = 1)]
				public override int GetLineStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getParagraphDirection
				/// </java-name>
				[Dot42.DexImport("getParagraphDirection", "(I)I", AccessFlags = 1)]
				public override int GetParagraphDirection(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLineContainsTab
				/// </java-name>
				[Dot42.DexImport("getLineContainsTab", "(I)Z", AccessFlags = 1)]
				public override bool GetLineContainsTab(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLineDirections
				/// </java-name>
				[Dot42.DexImport("getLineDirections", "(I)Landroid/text/Layout$Directions;", AccessFlags = 17)]
				public override global::Android.Text.Layout.Directions GetLineDirections(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Layout.Directions);
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
				public override int GetTopPadding() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
				public override int GetBottomPadding() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisCount
				/// </java-name>
				[Dot42.DexImport("getEllipsisCount", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisCount(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsisStart
				/// </java-name>
				[Dot42.DexImport("getEllipsisStart", "(I)I", AccessFlags = 1)]
				public override int GetEllipsisStart(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
				public override int GetEllipsizedWidth() /* MethodBuilder.Create */ 
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
				public int LineCount
				{
				[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
						get{ return GetLineCount(); }
				}

				/// <java-name>
				/// getTopPadding
				/// </java-name>
				public int TopPadding
				{
				[Dot42.DexImport("getTopPadding", "()I", AccessFlags = 1)]
						get{ return GetTopPadding(); }
				}

				/// <java-name>
				/// getBottomPadding
				/// </java-name>
				public int BottomPadding
				{
				[Dot42.DexImport("getBottomPadding", "()I", AccessFlags = 1)]
						get{ return GetBottomPadding(); }
				}

				/// <java-name>
				/// getEllipsizedWidth
				/// </java-name>
				public int EllipsizedWidth
				{
				[Dot42.DexImport("getEllipsizedWidth", "()I", AccessFlags = 1)]
						get{ return GetEllipsizedWidth(); }
				}

		}

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
				public TextPaint(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Paint;)V", AccessFlags = 1)]
				public TextPaint(global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
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
				/// <java-name>
				/// CAP_MODE_CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CAP_MODE_CHARACTERS", "I", AccessFlags = 25)]
				public const int CAP_MODE_CHARACTERS = 4096;
				/// <java-name>
				/// CAP_MODE_WORDS
				/// </java-name>
				[Dot42.DexImport("CAP_MODE_WORDS", "I", AccessFlags = 25)]
				public const int CAP_MODE_WORDS = 8192;
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
				public static void GetChars(global::Java.Lang.ICharSequence charSequence, int int32, int int321, char[] @char, int int322) /* MethodBuilder.Create */ 
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
				public static int LastIndexOf(global::Java.Lang.ICharSequence charSequence, char @char) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/CharSequence;CI)I", AccessFlags = 9)]
				public static int LastIndexOf(global::Java.Lang.ICharSequence charSequence, char @char, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lastIndexOf
				/// </java-name>
				[Dot42.DexImport("lastIndexOf", "(Ljava/lang/CharSequence;CII)I", AccessFlags = 9)]
				public static int LastIndexOf(global::Java.Lang.ICharSequence charSequence, char @char, int int32, int int321) /* MethodBuilder.Create */ 
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
				public static bool RegionMatches(global::Java.Lang.ICharSequence charSequence, int int32, global::Java.Lang.ICharSequence charSequence1, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// substring
				/// </java-name>
				[Dot42.DexImport("substring", "(Ljava/lang/CharSequence;II)Ljava/lang/String;", AccessFlags = 9)]
				public static string Substring(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
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
				public static global::Java.Lang.ICharSequence StringOrSpannedString(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				[Dot42.DexImport("isEmpty", "(Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool IsEmpty(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTrimmedLength
				/// </java-name>
				[Dot42.DexImport("getTrimmedLength", "(Ljava/lang/CharSequence;)I", AccessFlags = 9)]
				public static int GetTrimmedLength(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool Equals(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getReverse
				/// </java-name>
				[Dot42.DexImport("getReverse", "(Ljava/lang/CharSequence;II)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence GetReverse(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Ljava/lang/CharSequence;Landroid/os/Parcel;I)V", AccessFlags = 9)]
				public static void WriteToParcel(global::Java.Lang.ICharSequence charSequence, global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpSpans
				/// </java-name>
				[Dot42.DexImport("dumpSpans", "(Ljava/lang/CharSequence;Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 9)]
				public static void DumpSpans(global::Java.Lang.ICharSequence charSequence, global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// replace
				/// </java-name>
				[Dot42.DexImport("replace", "(Ljava/lang/CharSequence;[Ljava/lang/String;[Ljava/lang/CharSequence;)Ljava/lang/" +
    "CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Replace(global::Java.Lang.ICharSequence charSequence, string[] @string, global::Java.Lang.ICharSequence[] charSequence1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// expandTemplate
				/// </java-name>
				[Dot42.DexImport("expandTemplate", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 137)]
				public static global::Java.Lang.ICharSequence ExpandTemplate(global::Java.Lang.ICharSequence charSequence, params global::Java.Lang.ICharSequence[] charSequence1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getOffsetBefore
				/// </java-name>
				[Dot42.DexImport("getOffsetBefore", "(Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int GetOffsetBefore(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOffsetAfter
				/// </java-name>
				[Dot42.DexImport("getOffsetAfter", "(Ljava/lang/CharSequence;I)I", AccessFlags = 9)]
				public static int GetOffsetAfter(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// copySpansFrom
				/// </java-name>
				[Dot42.DexImport("copySpansFrom", "(Landroid/text/Spanned;IILjava/lang/Class;Landroid/text/Spannable;I)V", AccessFlags = 9)]
				public static void CopySpansFrom(global::Android.Text.ISpanned spanned, int int32, int int321, global::System.Type type, global::Android.Text.ISpannable spannable, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ellipsize
				/// </java-name>
				[Dot42.DexImport("ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$Truncat" +
    "eAt;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Ellipsize(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, float single, global::Android.Text.TextUtils.TruncateAt truncateAt) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// ellipsize
				/// </java-name>
				[Dot42.DexImport("ellipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLandroid/text/TextUtils$Truncat" +
    "eAt;ZLandroid/text/TextUtils$EllipsizeCallback;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence Ellipsize(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, float single, global::Android.Text.TextUtils.TruncateAt truncateAt, bool boolean, global::Android.Text.TextUtils.IEllipsizeCallback ellipsizeCallback) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// commaEllipsize
				/// </java-name>
				[Dot42.DexImport("commaEllipsize", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;FLjava/lang/String;Ljava/lang/St" +
    "ring;)Ljava/lang/CharSequence;", AccessFlags = 9)]
				public static global::Java.Lang.ICharSequence CommaEllipsize(global::Java.Lang.ICharSequence charSequence, global::Android.Text.TextPaint textPaint, float single, string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// htmlEncode
				/// </java-name>
				[Dot42.DexImport("htmlEncode", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 9)]
				public static string HtmlEncode(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// concat
				/// </java-name>
				[Dot42.DexImport("concat", "([Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 137)]
				public static global::Java.Lang.ICharSequence Concat(params global::Java.Lang.ICharSequence[] charSequence) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// isDigitsOnly
				/// </java-name>
				[Dot42.DexImport("isDigitsOnly", "(Ljava/lang/CharSequence;)Z", AccessFlags = 9)]
				public static bool IsDigitsOnly(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCapsMode
				/// </java-name>
				[Dot42.DexImport("getCapsMode", "(Ljava/lang/CharSequence;II)I", AccessFlags = 9)]
				public static int GetCapsMode(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
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
						/// <java-name>
						/// ellipsized
						/// </java-name>
						[Dot42.DexImport("ellipsized", "(II)V", AccessFlags = 1025)]
						void Ellipsized(int int32, int int321) /* MethodBuilder.Create */ ;

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

						/// <java-name>
						/// hasNext
						/// </java-name>
						[Dot42.DexImport("hasNext", "()Z", AccessFlags = 1)]
						public virtual bool HasNext() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// next
						/// </java-name>
						[Dot42.DexImport("next", "()Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Next() /* MethodBuilder.Create */ 
						{
								return default(string);
						}

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

				}

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

