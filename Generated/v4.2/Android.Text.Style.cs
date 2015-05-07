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
				/// <summary>
				///  <para>Set the text size to  <code>size</code> physical pixels. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public AbsoluteSizeSpan(int size) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the text size to  <code>size</code> physical pixels, or to  <code>size</code> device-independent pixels if  <code>dip</code> is true. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IZ)V", AccessFlags = 1)]
				public AbsoluteSizeSpan(int size, bool dip) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the text size to  <code>size</code> physical pixels. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public AbsoluteSizeSpan(global::Android.OS.Parcel size) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbsoluteSizeSpan() /* TypeBuilder.AddDefaultConstructor */ 
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
				public virtual bool Dip
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
				public BackgroundColorSpan(int color) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public BackgroundColorSpan(global::Android.OS.Parcel color) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BackgroundColorSpan() /* TypeBuilder.AddDefaultConstructor */ 
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
				public BulletSpan(int gapWidth) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public BulletSpan(int gapWidth, int color) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public BulletSpan(global::Android.OS.Parcel gapWidth) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the amount by which to adjust the leading margin. Positive values move away from the leading edge of the paragraph, negative values move towards it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset for the margin. </para>
				/// </returns>
				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool first) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Renders the leading margin. This is called before the margin has been adjusted by the value returned by getLeadingMargin(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas c, global::Android.Graphics.Paint p, int x, int dir, int top, int baseline, int bottom, global::Java.Lang.ICharSequence text, int start, int end, bool first, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
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

		}

		/// <summary>
		///  <para>The classes that affect character-level text formatting extend this class. Most extend its subclass MetricAffectingSpan, but simple ones may just implement UpdateAppearance. </para>    
		/// </summary>
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
				public abstract void UpdateDrawState(global::Android.Text.TextPaint tp) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>A given CharacterStyle can only applied to a single region of a given Spanned. If you need to attach the same CharacterStyle to multiple regions, you can use this method to wrap it with a new object that will have the same effect but be a distinct object so that it can also be attached without conflict. </para>        
				/// </summary>
				/// <java-name>
				/// wrap
				/// </java-name>
				[Dot42.DexImport("wrap", "(Landroid/text/style/CharacterStyle;)Landroid/text/style/CharacterStyle;", AccessFlags = 9)]
				public static global::Android.Text.Style.CharacterStyle Wrap(global::Android.Text.Style.CharacterStyle cs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Style.CharacterStyle);
				}

				/// <summary>
				///  <para>Returns "this" for most CharacterStyles, but for CharacterStyles that were generated by wrap, returns the underlying CharacterStyle. </para>        
				/// </summary>
				/// <java-name>
				/// getUnderlying
				/// </java-name>
				public virtual global::Android.Text.Style.CharacterStyle Underlying
				{
						[Dot42.DexImport("getUnderlying", "()Landroid/text/style/CharacterStyle;", AccessFlags = 1)]
						get{ return default(global::Android.Text.Style.CharacterStyle); }
				}

		}

		/// <summary>
		///  <para>If an object of this type is attached to the text of a TextView with a movement method of LinkMovementMethod, the affected spans of text can be selected. If clicked, the onClick method will be called. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Performs the click action associated with this span. </para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1025)]
				public abstract void OnClick(global::Android.Views.View widget) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Makes the text underlined and in the link color. </para>        
				/// </summary>
				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
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
				public DrawableMarginSpan(global::Android.Graphics.Drawables.Drawable b) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;I)V", AccessFlags = 1)]
				public DrawableMarginSpan(global::Android.Graphics.Drawables.Drawable b, int pad) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the amount by which to adjust the leading margin. Positive values move away from the leading edge of the paragraph, negative values move towards it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset for the margin. </para>
				/// </returns>
				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool first) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Renders the leading margin. This is called before the margin has been adjusted by the value returned by getLeadingMargin(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas c, global::Android.Graphics.Paint p, int x, int dir, int top, int baseline, int bottom, global::Java.Lang.ICharSequence text, int start, int end, bool first, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// chooseHeight
				/// </java-name>
				[Dot42.DexImport("chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V", AccessFlags = 1)]
				public virtual void ChooseHeight(global::Java.Lang.ICharSequence text, int start, int end, int istartv, int v, global::Android.Graphics.Paint.FontMetricsInt fm) /* MethodBuilder.Create */ 
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
				/// <summary>
				///  <para>A constant indicating that the bottom of this span should be aligned with the bottom of the surrounding text, i.e., at the same level as the lowest descender in the text. </para>        
				/// </summary>
				/// <java-name>
				/// ALIGN_BOTTOM
				/// </java-name>
				[Dot42.DexImport("ALIGN_BOTTOM", "I", AccessFlags = 25)]
				public const int ALIGN_BOTTOM = 0;
				/// <summary>
				///  <para>A constant indicating that the bottom of this span should be aligned with the baseline of the surrounding text. </para>        
				/// </summary>
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

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 4)]
				protected internal DynamicDrawableSpan(int verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMe" +
    "tricsInt;)I", AccessFlags = 1)]
				public override int GetSize(global::Android.Graphics.Paint paint, global::Java.Lang.ICharSequence text, int start, int end, global::Android.Graphics.Paint.FontMetricsInt fm) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)" +
    "V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas, global::Java.Lang.ICharSequence text, int start, int end, float x, int top, int y, int bottom, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the vertical alignment of this span, one of ALIGN_BOTTOM or ALIGN_BASELINE. </para>        
				/// </summary>
				/// <java-name>
				/// getVerticalAlignment
				/// </java-name>
				public virtual int VerticalAlignment
				{
						[Dot42.DexImport("getVerticalAlignment", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Your subclass must implement this method to provide the bitmap to be drawn. The dimensions of the bitmap must be the same from each call to the next. </para>        
				/// </summary>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				public abstract global::Android.Graphics.Drawables.Drawable Drawable
				{
						[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Provides an easy way to edit a portion of text. </para> <para>The TextView uses this span to allow the user to delete a chuck of text in one click. </para> <para>TextView removes the span when the user deletes the whole text or modifies it. </para> <para>This span can be also used to receive notification when the user deletes or modifies the text; </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/EasyEditSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/EasyEditSpan", AccessFlags = 33)]
		public partial class EasyEditSpan : global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates the span. No intent is sent when the wrapped text is modified or deleted. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EasyEditSpan() /* MethodBuilder.Create */ 
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

		}

		/// <java-name>
		/// android/text/style/ForegroundColorSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/ForegroundColorSpan", AccessFlags = 33)]
		public partial class ForegroundColorSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ForegroundColorSpan(int color) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ForegroundColorSpan(global::Android.OS.Parcel color) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ForegroundColorSpan() /* TypeBuilder.AddDefaultConstructor */ 
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
				internal IAlignmentSpan_Standard() /* TypeBuilder.AddDefaultConstructor */ 
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
				public IconMarginSpan(global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;I)V", AccessFlags = 1)]
				public IconMarginSpan(global::Android.Graphics.Bitmap b, int pad) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the amount by which to adjust the leading margin. Positive values move away from the leading edge of the paragraph, negative values move towards it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset for the margin. </para>
				/// </returns>
				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool first) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Renders the leading margin. This is called before the margin has been adjusted by the value returned by getLeadingMargin(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas c, global::Android.Graphics.Paint p, int x, int dir, int top, int baseline, int bottom, global::Java.Lang.ICharSequence text, int start, int end, bool first, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// chooseHeight
				/// </java-name>
				[Dot42.DexImport("chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V", AccessFlags = 1)]
				public virtual void ChooseHeight(global::Java.Lang.ICharSequence text, int start, int end, int istartv, int v, global::Android.Graphics.Paint.FontMetricsInt fm) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal IconMarginSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>A paragraph style affecting the leading margin. There can be multiple leading margin spans on a single paragraph; they will be rendered in order, each adding its margin to the ones before it. The leading margin is on the right for lines in a right-to-left paragraph. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/LeadingMarginSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/LeadingMarginSpan", AccessFlags = 1537)]
		public partial interface ILeadingMarginSpan : global::Android.Text.Style.IParagraphStyle
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the amount by which to adjust the leading margin. Positive values move away from the leading edge of the paragraph, negative values move towards it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset for the margin. </para>
				/// </returns>
				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1025)]
				int GetLeadingMargin(bool first) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Renders the leading margin. This is called before the margin has been adjusted by the value returned by getLeadingMargin(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1025)]
				void DrawLeadingMargin(global::Android.Graphics.Canvas c, global::Android.Graphics.Paint p, int x, int dir, int top, int baseline, int bottom, global::Java.Lang.ICharSequence text, int start, int end, bool first, global::Android.Text.Layout layout) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>An extended version of LeadingMarginSpan, which allows the implementor to specify the number of lines of text to which this object is attached that the "first line of paragraph" margin width will be applied to. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/LeadingMarginSpan$LeadingMarginSpan2
		/// </java-name>
		[Dot42.DexImport("android/text/style/LeadingMarginSpan$LeadingMarginSpan2", AccessFlags = 1545)]
		public partial interface ILeadingMarginSpan_ILeadingMarginSpan2 : global::Android.Text.Style.ILeadingMarginSpan, global::Android.Text.Style.IWrapTogetherSpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the number of lines of text to which this object is attached that the "first line" margin will apply to. Note that if this returns N, the first N lines of the region, not the first N lines of each paragraph, will be given the special margin width. </para>        
				/// </summary>
				/// <java-name>
				/// getLeadingMarginLineCount
				/// </java-name>
				int LeadingMarginLineCount
				{
						[Dot42.DexImport("getLeadingMarginLineCount", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The standard implementation of LeadingMarginSpan, which adjusts the margin but does not do any rendering. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Returns the amount by which to adjust the leading margin. Positive values move away from the leading edge of the paragraph, negative values move towards it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset for the margin. </para>
				/// </returns>
				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool first) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Renders the leading margin. This is called before the margin has been adjusted by the value returned by getLeadingMargin(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas c, global::Android.Graphics.Paint p, int x, int dir, int top, int baseline, int bottom, global::Java.Lang.ICharSequence text, int start, int end, bool first, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ILeadingMarginSpan_Standard() /* TypeBuilder.AddDefaultConstructor */ 
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
				void DrawBackground(global::Android.Graphics.Canvas c, global::Android.Graphics.Paint p, int left, int right, int top, int baseline, int bottom, global::Java.Lang.ICharSequence text, int start, int end, int lnum) /* MethodBuilder.Create */ ;

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
				void ChooseHeight(global::Java.Lang.ICharSequence text, int start, int end, int spanstartv, int v, global::Android.Graphics.Paint.FontMetricsInt fm) /* MethodBuilder.Create */ ;

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
				void ChooseHeight(global::Java.Lang.ICharSequence text, int start, int end, int spanstartv, int v, global::Android.Graphics.Paint.FontMetricsInt fm, global::Android.Text.TextPaint paint) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/style/ImageSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/ImageSpan", AccessFlags = 33)]
		public partial class ImageSpan : global::Android.Text.Style.DynamicDrawableSpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ImageSpan(Context, Bitmap) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Bitmap b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Bitmap b, int verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context b, global::Android.Graphics.Bitmap verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, global::Android.Graphics.Bitmap b, int verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ImageSpan(Context, Bitmap) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Drawables.Drawable b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Drawables.Drawable b, int verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Drawables.Drawable b, string verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;Ljava/lang/String;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Graphics.Drawables.Drawable context, string b, int verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/net/Uri;)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context b, global::Android.Net.Uri verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/net/Uri;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, global::Android.Net.Uri b, int verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context b, int verticalAlignment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public ImageSpan(global::Android.Content.Context context, int b, int verticalAlignment) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the source string that was saved during construction. </para>        
				/// </summary>
				/// <java-name>
				/// getSource
				/// </java-name>
				public virtual string Source
				{
						[Dot42.DexImport("getSource", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <summary>
		///  <para>The classes that affect paragraph-level text formatting implement this interface. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/ParagraphStyle
		/// </java-name>
		[Dot42.DexImport("android/text/style/ParagraphStyle", AccessFlags = 1537)]
		public partial interface IParagraphStyle
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Represents a single tab stop on a line. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/TabStopSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/TabStopSpan", AccessFlags = 1537)]
		public partial interface ITabStopSpan : global::Android.Text.Style.IParagraphStyle
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returns the offset of the tab stop from the leading margin of the line. </para>        
				/// </summary>
				/// <returns>
				///  <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// getTabStop
				/// </java-name>
				int TabStop
				{
						[Dot42.DexImport("getTabStop", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The default implementation of TabStopSpan. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Returns the offset of the tab stop from the leading margin of the line. </para>        
				/// </summary>
				/// <returns>
				///  <para>the offset </para>
				/// </returns>
				/// <java-name>
				/// getTabStop
				/// </java-name>
				public virtual int TabStop
				{
						[Dot42.DexImport("getTabStop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>The classes that affect character-level text in a way that modifies their appearance when one is added or removed must implement this interface. Note that if the class also impacts size or other metrics, it should instead implement UpdateLayout. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/UpdateAppearance
		/// </java-name>
		[Dot42.DexImport("android/text/style/UpdateAppearance", AccessFlags = 1537)]
		public partial interface IUpdateAppearance
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>The classes that affect character-level text formatting in a way that triggers a text layout update when one is added or removed must implement this interface. This interface also includes UpdateAppearance since such a change implicitly also impacts the appearance. </para>    
		/// </summary>
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

		/// <summary>
		///  <para>Changes the Locale of the text to which the span is attached. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/LocaleSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/LocaleSpan", AccessFlags = 33)]
		public partial class LocaleSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a LocaleSpan. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/util/Locale;)V", AccessFlags = 1)]
				public LocaleSpan(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a LocaleSpan. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public LocaleSpan(global::Android.OS.Parcel locale) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint paint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LocaleSpan() /* TypeBuilder.AddDefaultConstructor */ 
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

				/// <summary>
				///  <para>Returns the Locale.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Locale for this span. </para>
				/// </returns>
				/// <java-name>
				/// getLocale
				/// </java-name>
				public virtual global::Java.Util.Locale Locale
				{
						[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Locale); }
				}

		}

		/// <java-name>
		/// android/text/style/MaskFilterSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/MaskFilterSpan", AccessFlags = 33)]
		public partial class MaskFilterSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/MaskFilter;)V", AccessFlags = 1)]
				public MaskFilterSpan(global::Android.Graphics.MaskFilter filter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>The classes that affect character-level text formatting in a way that changes the width or height of characters extend this class. </para>    
		/// </summary>
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
				public abstract void UpdateMeasureState(global::Android.Text.TextPaint p) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns "this" for most MetricAffectingSpans, but for MetricAffectingSpans that were generated by wrap, returns the underlying MetricAffectingSpan. </para>        
				/// </summary>
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
				public QuoteSpan(int color) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public QuoteSpan(global::Android.OS.Parcel color) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the amount by which to adjust the leading margin. Positive values move away from the leading edge of the paragraph, negative values move towards it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset for the margin. </para>
				/// </returns>
				/// <java-name>
				/// getLeadingMargin
				/// </java-name>
				[Dot42.DexImport("getLeadingMargin", "(Z)I", AccessFlags = 1)]
				public virtual int GetLeadingMargin(bool first) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Renders the leading margin. This is called before the margin has been adjusted by the value returned by getLeadingMargin(boolean).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// drawLeadingMargin
				/// </java-name>
				[Dot42.DexImport("drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;II" +
    "ZLandroid/text/Layout;)V", AccessFlags = 1)]
				public virtual void DrawLeadingMargin(global::Android.Graphics.Canvas c, global::Android.Graphics.Paint p, int x, int dir, int top, int baseline, int bottom, global::Java.Lang.ICharSequence text, int start, int end, bool first, global::Android.Text.Layout layout) /* MethodBuilder.Create */ 
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
				public RasterizerSpan(global::Android.Graphics.Rasterizer r) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
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
				public RelativeSizeSpan(float src) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public RelativeSizeSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RelativeSizeSpan() /* TypeBuilder.AddDefaultConstructor */ 
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
				public abstract int GetSize(global::Android.Graphics.Paint paint, global::Java.Lang.ICharSequence text, int start, int end, global::Android.Graphics.Paint.FontMetricsInt fm) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)" +
    "V", AccessFlags = 1025)]
				public abstract void Draw(global::Android.Graphics.Canvas canvas, global::Java.Lang.ICharSequence text, int start, int end, float x, int top, int y, int bottom, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method does nothing, since ReplacementSpans are measured explicitly instead of affecting Paint properties. </para>        
				/// </summary>
				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint p) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method does nothing, since ReplacementSpans are drawn explicitly instead of affecting Paint properties. </para>        
				/// </summary>
				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
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
				public ScaleXSpan(float src) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public ScaleXSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScaleXSpan() /* TypeBuilder.AddDefaultConstructor */ 
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
				public StrikethroughSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
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

		}

		/// <summary>
		///  <para>Describes a style in a span. Note that styles are cumulative  if both bold and italic are set in separate spans, or if the base style is bold and a span calls for italic, you get bold italic. You can't turn off a style from the base style. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/StyleSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/StyleSpan", AccessFlags = 33)]
		public partial class StyleSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public StyleSpan(int style) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public StyleSpan(global::Android.OS.Parcel style) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint paint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StyleSpan() /* TypeBuilder.AddDefaultConstructor */ 
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

				/// <summary>
				///  <para>Returns the style constant defined in android.graphics.Typeface. </para>        
				/// </summary>
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
				public SubscriptSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint tp) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint tp) /* MethodBuilder.Create */ 
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

		}

		/// <summary>
		///  <para>Holds suggestion candidates for the text enclosed in this span.</para> <para>When such a span is edited in an EditText, double tapping on the text enclosed in this span will display a popup dialog listing suggestion replacement for that text. The user can then replace the original text by one of the suggestions.</para> <para>These spans should typically be created by the input method to provide correction and alternates for the text.</para> <para> <para>TextView::isSuggestionsEnabled() </para></para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/SuggestionSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/SuggestionSpan", AccessFlags = 33)]
		public partial class SuggestionSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Sets this flag if the suggestions should be easily accessible with few interactions. This flag should be set for every suggestions that the user is likely to use. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_EASY_CORRECT
				/// </java-name>
				[Dot42.DexImport("FLAG_EASY_CORRECT", "I", AccessFlags = 25)]
				public const int FLAG_EASY_CORRECT = 1;
				/// <summary>
				///  <para>Sets this flag if the suggestions apply to a misspelled word/text. This type of suggestion is rendered differently to highlight the error. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_MISSPELLED
				/// </java-name>
				[Dot42.DexImport("FLAG_MISSPELLED", "I", AccessFlags = 25)]
				public const int FLAG_MISSPELLED = 2;
				/// <summary>
				///  <para>Sets this flag if the auto correction is about to be applied to a word/text that the user is typing/composing. This type of suggestion is rendered differently to indicate the auto correction is happening. </para>        
				/// </summary>
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

				/// <summary>
				///  <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/Locale;[Ljava/lang/String;ILjava/lang/Class;" +
    ")V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/Locale;[Ljava/lang/String;ILjava/lang/Class<" +
    "*>;)V")]
				public SuggestionSpan(global::Android.Content.Context context, global::Java.Util.Locale locale, string[] suggestions, int flags, global::System.Type notificationTargetClass) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public SuggestionSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
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
				public override void UpdateDrawState(global::Android.Text.TextPaint tp) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SuggestionSpan() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an array of suggestion texts for this span </para>
				/// </returns>
				/// <java-name>
				/// getSuggestions
				/// </java-name>
				public virtual string[] Suggestions
				{
						[Dot42.DexImport("getSuggestions", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the locale of the suggestions </para>
				/// </returns>
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
				public SuperscriptSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint tp) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint tp) /* MethodBuilder.Create */ 
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

		}

		/// <summary>
		///  <para>Sets the text color, size, style, and typeface to match a TextAppearance resource. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/TextAppearanceSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/TextAppearanceSpan", AccessFlags = 33)]
		public partial class TextAppearanceSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Uses the specified TextAppearance resource to determine the text appearance. The  <code>appearance</code> should be, for example,  <code>android.R.style.TextAppearance_Small</code>. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public TextAppearanceSpan(global::Android.Content.Context context, int appearance) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Uses the specified TextAppearance resource to determine the text appearance, and the specified text color resource to determine the color. The  <code>appearance</code> should be, for example,  <code>android.R.style.TextAppearance_Small</code>, and the  <code>colorList</code> should be, for example,  <code>android.R.styleable.Theme_textColorPrimary</code>. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public TextAppearanceSpan(global::Android.Content.Context context, int appearance, int colorList) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Makes text be drawn with the specified typeface, size, style, and colors. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;IILandroid/content/res/ColorStateList;Landroid/content/res/Col" +
    "orStateList;)V", AccessFlags = 1)]
				public TextAppearanceSpan(string family, int style, int size, global::Android.Content.Res.ColorStateList color, global::Android.Content.Res.ColorStateList linkColor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public TextAppearanceSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextAppearanceSpan() /* TypeBuilder.AddDefaultConstructor */ 
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

				/// <summary>
				///  <para>Returns the typeface family specified by this span, or  <code>null</code> if it does not specify one. </para>        
				/// </summary>
				/// <java-name>
				/// getFamily
				/// </java-name>
				public virtual string Family
				{
						[Dot42.DexImport("getFamily", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Returns the text color specified by this span, or  <code>null</code> if it does not specify one. </para>        
				/// </summary>
				/// <java-name>
				/// getTextColor
				/// </java-name>
				public virtual global::Android.Content.Res.ColorStateList TextColor
				{
						[Dot42.DexImport("getTextColor", "()Landroid/content/res/ColorStateList;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <summary>
				///  <para>Returns the link color specified by this span, or  <code>null</code> if it does not specify one. </para>        
				/// </summary>
				/// <java-name>
				/// getLinkTextColor
				/// </java-name>
				public virtual global::Android.Content.Res.ColorStateList LinkTextColor
				{
						[Dot42.DexImport("getLinkTextColor", "()Landroid/content/res/ColorStateList;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <summary>
				///  <para>Returns the text size specified by this span, or  <code>-1</code> if it does not specify one. </para>        
				/// </summary>
				/// <java-name>
				/// getTextSize
				/// </java-name>
				public virtual int TextSize
				{
						[Dot42.DexImport("getTextSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the text style specified by this span, or  <code>0</code> if it does not specify one. </para>        
				/// </summary>
				/// <java-name>
				/// getTextStyle
				/// </java-name>
				public virtual int TextStyle
				{
						[Dot42.DexImport("getTextStyle", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Changes the typeface family of the text to which the span is attached. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/style/TypefaceSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/TypefaceSpan", AccessFlags = 33)]
		public partial class TypefaceSpan : global::Android.Text.Style.MetricAffectingSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public TypefaceSpan(string src) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public TypefaceSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateMeasureState
				/// </java-name>
				[Dot42.DexImport("updateMeasureState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateMeasureState(global::Android.Text.TextPaint paint) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TypefaceSpan() /* TypeBuilder.AddDefaultConstructor */ 
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

				/// <summary>
				///  <para>Returns the font family name. </para>        
				/// </summary>
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
				public UnderlineSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// updateDrawState
				/// </java-name>
				[Dot42.DexImport("updateDrawState", "(Landroid/text/TextPaint;)V", AccessFlags = 1)]
				public override void UpdateDrawState(global::Android.Text.TextPaint ds) /* MethodBuilder.Create */ 
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

		}

		/// <java-name>
		/// android/text/style/URLSpan
		/// </java-name>
		[Dot42.DexImport("android/text/style/URLSpan", AccessFlags = 33)]
		public partial class URLSpan : global::Android.Text.Style.ClickableSpan, global::Android.Text.IParcelableSpan
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public URLSpan(string src) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public URLSpan(global::Android.OS.Parcel src) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void OnClick(global::Android.Views.View widget) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal URLSpan() /* TypeBuilder.AddDefaultConstructor */ 
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
				/// getURL
				/// </java-name>
				public virtual string URL
				{
						[Dot42.DexImport("getURL", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

