#pragma warning disable 1717
namespace Android.Text.Style
{
		/// <java-name>
		/// android/text/style/AbsoluteSizeSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/AbsoluteSizeSpan", AccessFlags = 33)]
		public partial class AbsoluteSizeSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AbsoluteSizeSpan(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public AbsoluteSizeSpan(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public AbsoluteSizeSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbsoluteSizeSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				public virtual int Size
				{
						[Dot42.DexImport("getSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDip
				/// </java-name>
				public virtual bool IsDip
				{
						[Dot42.DexImport("getDip", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/text/style/BackgroundColorSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/BackgroundColorSpan", AccessFlags = 33)]
		public partial class BackgroundColorSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public BackgroundColorSpan(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public BackgroundColorSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BackgroundColorSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBackgroundColor
				/// </java-name>
				public virtual int BackgroundColor
				{
						[Dot42.DexImport("getBackgroundColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/BulletSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/BulletSpan", AccessFlags = 33)]
		public partial class BulletSpan : global::Android.Text.Style.ILeadingMarginSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// STANDARD_GAP_WIDTH
				/// </java-name>
				[Dot42.DexImport("STANDARD_GAP_WIDTH", "I", AccessFlags = 25)]
				public const int STANDARD_GAP_WIDTH = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BulletSpan() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public BulletSpan(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public BulletSpan(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public BulletSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint, int int32, int int321, int int322, int int323, int int324, global::Java.Lang.ICharSequence charSequence, int int325, int int326, bool boolean, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/CharacterStyle
		/// </java-name>
		[Dot42.DexImport("android/text/style/CharacterStyle", AccessFlags = 1057)]
		public abstract partial class CharacterStyle
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CharacterStyle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1025)]
				public abstract void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Landroid/text/style/CharacterStyle;)Landroid/text/style/CharacterStyle;", AccessFlags = 9)]
				public static global::Android.Text.Style.CharacterStyle Wrap(global::Android.Text.Style.CharacterStyle characterStyle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Style.CharacterStyle);
				}

				/// <java-name>
				/// getUnderlying
				/// </java-name>
				public virtual global::Android.Text.Style.CharacterStyle Underlying
				{
						[Dot42.DexImport("getUnderlying", "()Landroid/text/style/CharacterStyle;", AccessFlags = 1)]
						get{ return default(global::Android.Text.Style.CharacterStyle); }
				}

		}

		/// <java-name>
		/// android/text/style/ClickableSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/ClickableSpan", AccessFlags = 1057)]
		public abstract partial class ClickableSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ClickableSpan() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1025)]
				public abstract void OnClick(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/text/style/DrawableMarginSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/DrawableMarginSpan", AccessFlags = 33)]
		public partial class DrawableMarginSpan : global::Android.Text.Style.ILeadingMarginSpan, global::Android.Text.Style.ILineHeightSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public DrawableMarginSpan(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;I)V", AccessFlags = 1)]
				public DrawableMarginSpan(global::Android.Graphics.Drawables.Drawable drawable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint, int int32, int int321, int int322, int int323, int int324, global::Java.Lang.ICharSequence charSequence, int int325, int int326, bool boolean, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// chooseHeight
				/// </java-name>
				[Dot42.DexImport("chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V", AccessFlags = 1)]
				public virtual void ChooseHeight(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322, int int323, global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DrawableMarginSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/text/style/DynamicDrawableSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/DynamicDrawableSpan", AccessFlags = 1057)]
		public abstract partial class DynamicDrawableSpan : global::Android.Text.Style.ReplacementSpan
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ALIGN_BOTTOM
				/// </java-name>
				[Dot42.DexImport("ALIGN_BOTTOM", "I", AccessFlags = 25)]
				public const int ALIGN_BOTTOM = 0;
				/// <java-name>
				/// ALIGN_BASELINE
				/// </java-name>
				[Dot42.DexImport("ALIGN_BASELINE", "I", AccessFlags = 25)]
				public const int ALIGN_BASELINE = 1;
				/// <java-name>
				/// mVerticalAlignment
				/// </java-name>
				[Dot42.DexImport("mVerticalAlignment", "I", AccessFlags = 20)]
				protected internal readonly int MVerticalAlignment;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DynamicDrawableSpan() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 4)]
				protected internal DynamicDrawableSpan(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMe" +
    "tricsInt;)I", AccessFlags = 1)]
				public override int GetSize(global::Android.Graphics.Paint paint, global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)" +
    "V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Java.Lang.ICharSequence charSequence, int int32, int int321, float single, int int322, int int323, int int324, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVerticalAlignment
				/// </java-name>
				public virtual int VerticalAlignment
				{
						[Dot42.DexImport("getVerticalAlignment", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				public abstract global::Android.Graphics.Drawables.Drawable Drawable
				{
						[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/text/style/EasyEditSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/EasyEditSpan", AccessFlags = 33)]
		public partial class EasyEditSpan : global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EasyEditSpan() /* MethodBuilder.Create */ 
				{
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
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/ForegroundColorSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/ForegroundColorSpan", AccessFlags = 33)]
		public partial class ForegroundColorSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ForegroundColorSpan(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ForegroundColorSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ForegroundColorSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getForegroundColor
				/// </java-name>
				public virtual int ForegroundColor
				{
						[Dot42.DexImport("getForegroundColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/AlignmentSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/AlignmentSpan", AccessFlags = 1537)]
		public partial interface IAlignmentSpan : global::Android.Text.Style.IParagraphStyle
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getAlignment
				/// </java-name>
				global::Android.Text.Layout.Alignment Alignment
				{
						[Dot42.DexImport("getAlignment", "()Landroid/text/Layout$Alignment;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/text/style/AlignmentSpan$Standard
		/// </java-name>
		[Dot42.DexImport("android/text/style/AlignmentSpan$Standard", AccessFlags = 9)]
		public partial class IAlignmentSpan_Standard : global::Android.Text.Style.IAlignmentSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/text/Layout$Alignment;)V", AccessFlags = 1)]
				public IAlignmentSpan_Standard(global::Android.Text.Layout.Alignment alignment) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public IAlignmentSpan_Standard(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IAlignmentSpan_Standard() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getAlignment
				/// </java-name>
				public virtual global::Android.Text.Layout.Alignment Alignment
				{
						[Dot42.DexImport("getAlignment", "()Landroid/text/Layout$Alignment;", AccessFlags = 1)]
						get{ return default(global::Android.Text.Layout.Alignment); }
				}

		}

		/// <java-name>
		/// android/text/style/IconMarginSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/IconMarginSpan", AccessFlags = 33)]
		public partial class IconMarginSpan : global::Android.Text.Style.ILeadingMarginSpan, global::Android.Text.Style.ILineHeightSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public IconMarginSpan(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;I)V", AccessFlags = 1)]
				public IconMarginSpan(global::Android.Graphics.Bitmap bitmap, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint, int int32, int int321, int int322, int int323, int int324, global::Java.Lang.ICharSequence charSequence, int int325, int int326, bool boolean, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// chooseHeight
				/// </java-name>
				[Dot42.DexImport("chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V", AccessFlags = 1)]
				public virtual void ChooseHeight(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322, int int323, global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IconMarginSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/text/style/LeadingMarginSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/LeadingMarginSpan", AccessFlags = 1537)]
		public partial interface ILeadingMarginSpan : global::Android.Text.Style.IParagraphStyle
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1025)]
				int GetLeadingMargin(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1025)]
				void DrawLeadingMargin(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint, int int32, int int321, int int322, int int323, int int324, global::Java.Lang.ICharSequence charSequence, int int325, int int326, bool boolean, global::Android.Text.Layout layout) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/style/LeadingMarginSpan$LeadingMarginSpan2
		/// </java-name>
		[Dot42.DexImport("android/text/style/LeadingMarginSpan$LeadingMarginSpan2", AccessFlags = 1545)]
		public partial interface ILeadingMarginSpan_ILeadingMarginSpan2 : global::Android.Text.Style.ILeadingMarginSpan, global::Android.Text.Style.IWrapTogetherSpan
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getLeadingMarginLineCount
				/// </java-name>
				int LeadingMarginLineCount
				{
						[Dot42.DexImport("getLeadingMarginLineCount", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/text/style/LeadingMarginSpan$Standard
		/// </java-name>
		[Dot42.DexImport("android/text/style/LeadingMarginSpan$Standard", AccessFlags = 9)]
		public partial class ILeadingMarginSpan_Standard : global::Android.Text.Style.ILeadingMarginSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public ILeadingMarginSpan_Standard(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ILeadingMarginSpan_Standard(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ILeadingMarginSpan_Standard(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint, int int32, int int321, int int322, int int323, int int324, global::Java.Lang.ICharSequence charSequence, int int325, int int326, bool boolean, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ILeadingMarginSpan_Standard() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/LineBackgroundSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/LineBackgroundSpan", AccessFlags = 1537)]
		public partial interface ILineBackgroundSpan : global::Android.Text.Style.IParagraphStyle
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// drawBackground
				/// </java-name>
				[Dot42.DexImport("drawBackground", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "I)V", AccessFlags = 1025)]
				void DrawBackground(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint, int int32, int int321, int int322, int int323, int int324, global::Java.Lang.ICharSequence charSequence, int int325, int int326, int int327) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/style/LineHeightSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/LineHeightSpan", AccessFlags = 1537)]
		public partial interface ILineHeightSpan : global::Android.Text.Style.IParagraphStyle, global::Android.Text.Style.IWrapTogetherSpan
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// chooseHeight
				/// </java-name>
				[Dot42.DexImport("chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V", AccessFlags = 1025)]
				void ChooseHeight(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322, int int323, global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/style/LineHeightSpan$WithDensity
		/// </java-name>
		[Dot42.DexImport("android/text/style/LineHeightSpan$WithDensity", AccessFlags = 1545)]
		public partial interface ILineHeightSpan_IWithDensity : global::Android.Text.Style.ILineHeightSpan
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// chooseHeight
				/// </java-name>
				[Dot42.DexImport("chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;Landroid/text" +
    "/TextPaint;)V", AccessFlags = 1025)]
				void ChooseHeight(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322, int int323, global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt, global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/style/ImageSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/ImageSpan", AccessFlags = 33)]
		public partial class ImageSpan : global::Android.Text.Style.DynamicDrawableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Bitmap bitmap, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, global::Android.Graphics.Bitmap bitmap, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Drawables.Drawable drawable, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Drawables.Drawable drawable, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Drawables.Drawable drawable, string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/net/Uri;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/net/Uri;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, global::Android.Net.Uri uri, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ImageSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				public override global::Android.Graphics.Drawables.Drawable Drawable
				{
						[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getSource
				/// </java-name>
				public virtual string Source
				{
						[Dot42.DexImport("getSource", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// android/text/style/ParagraphStyle
		/// </java-name>
		[Dot42.DexImport("android/text/style/ParagraphStyle", AccessFlags = 1537)]
		public partial interface IParagraphStyle
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/text/style/TabStopSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/TabStopSpan", AccessFlags = 1537)]
		public partial interface ITabStopSpan : global::Android.Text.Style.IParagraphStyle
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getTabStop
				/// </java-name>
				int TabStop
				{
						[Dot42.DexImport("getTabStop", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/text/style/TabStopSpan$Standard
		/// </java-name>
		[Dot42.DexImport("android/text/style/TabStopSpan$Standard", AccessFlags = 9)]
		public partial class ITabStopSpan_Standard : global::Android.Text.Style.ITabStopSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ITabStopSpan_Standard(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ITabStopSpan_Standard() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTabStop
				/// </java-name>
				public virtual int TabStop
				{
						[Dot42.DexImport("getTabStop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/UpdateAppearance
		/// </java-name>
		[Dot42.DexImport("android/text/style/UpdateAppearance", AccessFlags = 1537)]
		public partial interface IUpdateAppearance
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/text/style/UpdateLayout
		/// </java-name>
		[Dot42.DexImport("android/text/style/UpdateLayout", AccessFlags = 1537)]
		public partial interface IUpdateLayout : global::Android.Text.Style.IUpdateAppearance
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/text/style/WrapTogetherSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/WrapTogetherSpan", AccessFlags = 1537)]
		public partial interface IWrapTogetherSpan : global::Android.Text.Style.IParagraphStyle
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/text/style/MaskFilterSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/MaskFilterSpan", AccessFlags = 33)]
		public partial class MaskFilterSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/MaskFilter;)V", AccessFlags = 1)]
				public MaskFilterSpan(global::Android.Graphics.MaskFilter maskFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MaskFilterSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMaskFilter
				/// </java-name>
				public virtual global::Android.Graphics.MaskFilter MaskFilter
				{
						[Dot42.DexImport("getMaskFilter", "()Landroid/graphics/MaskFilter;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.MaskFilter); }
				}

		}

		/// <java-name>
		/// android/text/style/MetricAffectingSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/MetricAffectingSpan", AccessFlags = 1057)]
		public abstract partial class MetricAffectingSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MetricAffectingSpan() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1025)]
				public abstract void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getUnderlying
				/// </java-name>
				[Dot42.DexImport("getUnderlying", "()Landroid/text/style/MetricAffectingSpan;", AccessFlags = 1)]
				public new virtual global::Android.Text.Style.MetricAffectingSpan GetUnderlying() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Style.MetricAffectingSpan);
				}

		}

		/// <java-name>
		/// android/text/style/QuoteSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/QuoteSpan", AccessFlags = 33)]
		public partial class QuoteSpan : global::Android.Text.Style.ILeadingMarginSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public QuoteSpan() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public QuoteSpan(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public QuoteSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint, int int32, int int321, int int322, int int323, int int324, global::Java.Lang.ICharSequence charSequence, int int325, int int326, bool boolean, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				public virtual int Color
				{
						[Dot42.DexImport("getColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/RasterizerSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/RasterizerSpan", AccessFlags = 33)]
		public partial class RasterizerSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Rasterizer;)V", AccessFlags = 1)]
				public RasterizerSpan(global::Android.Graphics.Rasterizer rasterizer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RasterizerSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRasterizer
				/// </java-name>
				public virtual global::Android.Graphics.Rasterizer Rasterizer
				{
						[Dot42.DexImport("getRasterizer", "()Landroid/graphics/Rasterizer;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Rasterizer); }
				}

		}

		/// <java-name>
		/// android/text/style/RelativeSizeSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/RelativeSizeSpan", AccessFlags = 33)]
		public partial class RelativeSizeSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public RelativeSizeSpan(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public RelativeSizeSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RelativeSizeSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSizeChange
				/// </java-name>
				public virtual float SizeChange
				{
						[Dot42.DexImport("getSizeChange", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

		}

		/// <java-name>
		/// android/text/style/ReplacementSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/ReplacementSpan", AccessFlags = 1057)]
		public abstract partial class ReplacementSpan : global::Android.Text.Style.MetricAffectingSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReplacementSpan() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMe" +
    "tricsInt;)I", AccessFlags = 1025)]
				public abstract int GetSize(global::Android.Graphics.Paint paint, global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Graphics.Paint.FontMetricsInt fontMetricsInt) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)" +
    "V", AccessFlags = 1025)]
				public abstract void Draw(global::Android.Graphics.Canvas canvas, global::Java.Lang.ICharSequence charSequence, int int32, int int321, float single, int int322, int int323, int int324, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/text/style/ScaleXSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/ScaleXSpan", AccessFlags = 33)]
		public partial class ScaleXSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public ScaleXSpan(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ScaleXSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScaleXSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaleX
				/// </java-name>
				public virtual float ScaleX
				{
						[Dot42.DexImport("getScaleX", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

		}

		/// <java-name>
		/// android/text/style/StrikethroughSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/StrikethroughSpan", AccessFlags = 33)]
		public partial class StrikethroughSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StrikethroughSpan() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public StrikethroughSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/StyleSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/StyleSpan", AccessFlags = 33)]
		public partial class StyleSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StyleSpan(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public StyleSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StyleSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getStyle
				/// </java-name>
				public virtual int Style
				{
						[Dot42.DexImport("getStyle", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/SubscriptSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/SubscriptSpan", AccessFlags = 33)]
		public partial class SubscriptSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SubscriptSpan() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SubscriptSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/SuggestionSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/SuggestionSpan", AccessFlags = 33)]
		public partial class SuggestionSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FLAG_EASY_CORRECT
				/// </java-name>
				[Dot42.DexImport("FLAG_EASY_CORRECT", "I", AccessFlags = 25)]
				public const int FLAG_EASY_CORRECT = 1;
				/// <java-name>
				/// FLAG_MISSPELLED
				/// </java-name>
				[Dot42.DexImport("FLAG_MISSPELLED", "I", AccessFlags = 25)]
				public const int FLAG_MISSPELLED = 2;
				/// <java-name>
				/// FLAG_AUTO_CORRECTION
				/// </java-name>
				[Dot42.DexImport("FLAG_AUTO_CORRECTION", "I", AccessFlags = 25)]
				public const int FLAG_AUTO_CORRECTION = 4;
				/// <java-name>
				/// ACTION_SUGGESTION_PICKED
				/// </java-name>
				[Dot42.DexImport("ACTION_SUGGESTION_PICKED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_SUGGESTION_PICKED = "android.text.style.SUGGESTION_PICKED";
				/// <java-name>
				/// SUGGESTION_SPAN_PICKED_AFTER
				/// </java-name>
				[Dot42.DexImport("SUGGESTION_SPAN_PICKED_AFTER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGESTION_SPAN_PICKED_AFTER = "after";
				/// <java-name>
				/// SUGGESTION_SPAN_PICKED_BEFORE
				/// </java-name>
				[Dot42.DexImport("SUGGESTION_SPAN_PICKED_BEFORE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGESTION_SPAN_PICKED_BEFORE = "before";
				/// <java-name>
				/// SUGGESTION_SPAN_PICKED_HASHCODE
				/// </java-name>
				[Dot42.DexImport("SUGGESTION_SPAN_PICKED_HASHCODE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SUGGESTION_SPAN_PICKED_HASHCODE = "hashcode";
				/// <java-name>
				/// SUGGESTIONS_MAX_SIZE
				/// </java-name>
				[Dot42.DexImport("SUGGESTIONS_MAX_SIZE", "I", AccessFlags = 25)]
				public const int SUGGESTIONS_MAX_SIZE = 5;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Text.Style.SuggestionSpan> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;[Ljava/lang/String;I)V", AccessFlags = 1)]
				public SuggestionSpan(global::Android.Content.Context context, string[] @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Locale;[Ljava/lang/String;I)V", AccessFlags = 1)]
				public SuggestionSpan(global::Java.Util.Locale locale, string[] @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/Locale;[Ljava/lang/String;ILjava/lang/Class;" +
    ")V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/Locale;[Ljava/lang/String;ILjava/lang/Class<" +
    "*>;)V")]
				public SuggestionSpan(global::Android.Content.Context context, global::Java.Util.Locale locale, string[] @string, int int32, global::System.Type type) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SuggestionSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SuggestionSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSuggestions
				/// </java-name>
				public virtual string[] Suggestions
				{
						[Dot42.DexImport("getSuggestions", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				public virtual string Locale
				{
						[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				public virtual int Flags
				{
						[Dot42.DexImport("getFlags", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setFlags", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/SuperscriptSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/SuperscriptSpan", AccessFlags = 33)]
		public partial class SuperscriptSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SuperscriptSpan() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SuperscriptSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/TextAppearanceSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/TextAppearanceSpan", AccessFlags = 33)]
		public partial class TextAppearanceSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public TextAppearanceSpan(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public TextAppearanceSpan(global::Android.Content.Context context, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;IILandroid/content/res/ColorStateList;Landroid/content/res/Col" +
    "orStateList;)V", AccessFlags = 1)]
				public TextAppearanceSpan(string @string, int int32, int int321, global::Android.Content.Res.ColorStateList colorStateList, global::Android.Content.Res.ColorStateList colorStateList1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public TextAppearanceSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextAppearanceSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFamily
				/// </java-name>
				public virtual string Family
				{
						[Dot42.DexImport("getFamily", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getTextColor
				/// </java-name>
				public virtual global::Android.Content.Res.ColorStateList TextColor
				{
						[Dot42.DexImport("getTextColor", "()Landroid/content/res/ColorStateList;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <java-name>
				/// getLinkTextColor
				/// </java-name>
				public virtual global::Android.Content.Res.ColorStateList LinkTextColor
				{
						[Dot42.DexImport("getLinkTextColor", "()Landroid/content/res/ColorStateList;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <java-name>
				/// getTextSize
				/// </java-name>
				public virtual int TextSize
				{
						[Dot42.DexImport("getTextSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTextStyle
				/// </java-name>
				public virtual int TextStyle
				{
						[Dot42.DexImport("getTextStyle", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/TypefaceSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/TypefaceSpan", AccessFlags = 33)]
		public partial class TypefaceSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TypefaceSpan(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public TypefaceSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TypefaceSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFamily
				/// </java-name>
				public virtual string Family
				{
						[Dot42.DexImport("getFamily", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// android/text/style/UnderlineSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/UnderlineSpan", AccessFlags = 33)]
		public partial class UnderlineSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public UnderlineSpan() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public UnderlineSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint textPaint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/text/style/URLSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/URLSpan", AccessFlags = 33)]
		public partial class URLSpan : global::Android.Text.Style.ClickableSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public URLSpan(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public URLSpan(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void OnClick(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URLSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSpanTypeId
				/// </java-name>
				public virtual int SpanTypeId
				{
						[Dot42.DexImport("getSpanTypeId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getURL
				/// </java-name>
				public virtual string URL
				{
						[Dot42.DexImport("getURL", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

