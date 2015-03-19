#pragma warning disable 1717
namespace Android.Graphics.Drawable
{
		/// <java-name>
		/// android/graphics/drawable/ShapeDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/ShapeDrawable", AccessFlags = 33)]
		public partial class ShapeDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ShapeDrawable() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/shapes/Shape;)V", AccessFlags = 1)]
				public ShapeDrawable(global::Android.Graphics.Drawable.Shapes.Shape shape) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getShape
				/// </java-name>
				[Dot42.DexImport("getShape", "()Landroid/graphics/drawable/shapes/Shape;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Shapes.Shape GetShape() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Shapes.Shape);
				}

				/// <java-name>
				/// setShape
				/// </java-name>
				[Dot42.DexImport("setShape", "(Landroid/graphics/drawable/shapes/Shape;)V", AccessFlags = 1)]
				public virtual void SetShape(global::Android.Graphics.Drawable.Shapes.Shape shape) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setShaderFactory
				/// </java-name>
				[Dot42.DexImport("setShaderFactory", "(Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;)V", AccessFlags = 1)]
				public virtual void SetShaderFactory(global::Android.Graphics.Drawable.ShapeDrawable.ShaderFactory shaderFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getShaderFactory
				/// </java-name>
				[Dot42.DexImport("getShaderFactory", "()Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.ShapeDrawable.ShaderFactory GetShaderFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.ShapeDrawable.ShaderFactory);
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint GetPaint() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint);
				}

				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public virtual void SetPadding(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("setIntrinsicWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetIntrinsicWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("setIntrinsicHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetIntrinsicHeight(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/drawable/shapes/Shape;Landroid/graphics/Canvas;Landroid/graphi" +
    "cs/Paint;)V", AccessFlags = 4)]
				protected internal virtual void OnDraw(global::Android.Graphics.Drawable.Shapes.Shape shape, global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflateTag
				/// </java-name>
				[Dot42.DexImport("inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;L" +
    "android/util/AttributeSet;)Z", AccessFlags = 4)]
				protected internal virtual bool InflateTag(string @string, global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getShape
				/// </java-name>
				public global::Android.Graphics.Drawable.Shapes.Shape Shape
				{
				[Dot42.DexImport("getShape", "()Landroid/graphics/drawable/shapes/Shape;", AccessFlags = 1)]
						get{ return GetShape(); }
				[Dot42.DexImport("setShape", "(Landroid/graphics/drawable/shapes/Shape;)V", AccessFlags = 1)]
						set{ SetShape(value); }
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				public global::Android.Graphics.Paint Paint
				{
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 1)]
						get{ return GetPaint(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// android/graphics/drawable/ShapeDrawable$ShaderFactory
				/// </java-name>
				[Dot42.DexImport("android/graphics/drawable/ShapeDrawable$ShaderFactory", AccessFlags = 1033)]
				public abstract partial class ShaderFactory
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public ShaderFactory() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// resize
						/// </java-name>
						[Dot42.DexImport("resize", "(II)Landroid/graphics/Shader;", AccessFlags = 1025)]
						public abstract global::Android.Graphics.Shader Resize(int int32, int int321) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/graphics/drawable/Drawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/Drawable", AccessFlags = 1057)]
		public abstract partial class Drawable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Drawable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1025)]
				public abstract void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBounds
				/// </java-name>
				[Dot42.DexImport("setBounds", "(IIII)V", AccessFlags = 1)]
				public virtual void SetBounds(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBounds
				/// </java-name>
				[Dot42.DexImport("setBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetBounds(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyBounds
				/// </java-name>
				[Dot42.DexImport("copyBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 17)]
				public void CopyBounds(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyBounds
				/// </java-name>
				[Dot42.DexImport("copyBounds", "()Landroid/graphics/Rect;", AccessFlags = 17)]
				public global::Android.Graphics.Rect CopyBounds() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <java-name>
				/// getBounds
				/// </java-name>
				[Dot42.DexImport("getBounds", "()Landroid/graphics/Rect;", AccessFlags = 17)]
				public global::Android.Graphics.Rect GetBounds() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <java-name>
				/// setChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("setChangingConfigurations", "(I)V", AccessFlags = 1)]
				public virtual void SetChangingConfigurations(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public virtual int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public virtual void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 1)]
				public virtual void SetFilterBitmap(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCallback
				/// </java-name>
				[Dot42.DexImport("setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V", AccessFlags = 17)]
				public void SetCallback(global::Android.Graphics.Drawable.Drawable.ICallback callback) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCallback
				/// </java-name>
				[Dot42.DexImport("getCallback", "()Landroid/graphics/drawable/Drawable$Callback;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable.ICallback GetCallback() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ICallback);
				}

				/// <java-name>
				/// invalidateSelf
				/// </java-name>
				[Dot42.DexImport("invalidateSelf", "()V", AccessFlags = 1)]
				public virtual void InvalidateSelf() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleSelf
				/// </java-name>
				[Dot42.DexImport("scheduleSelf", "(Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleSelf(global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleSelf
				/// </java-name>
				[Dot42.DexImport("unscheduleSelf", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleSelf(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1025)]
				public abstract void SetAlpha(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1025)]
				public abstract void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V", AccessFlags = 1)]
				public virtual void SetColorFilter(int int32, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearColorFilter
				/// </java-name>
				[Dot42.DexImport("clearColorFilter", "()V", AccessFlags = 1)]
				public virtual void ClearColorFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public virtual bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "([I)Z", AccessFlags = 1)]
				public virtual bool SetState(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()[I", AccessFlags = 1)]
				public virtual int[] GetState() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// jumpToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpToCurrentState", "()V", AccessFlags = 1)]
				public virtual void JumpToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrent
				/// </java-name>
				[Dot42.DexImport("getCurrent", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetCurrent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// setLevel
				/// </java-name>
				[Dot42.DexImport("setLevel", "(I)Z", AccessFlags = 17)]
				public bool SetLevel(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLevel
				/// </java-name>
				[Dot42.DexImport("getLevel", "()I", AccessFlags = 17)]
				public int GetLevel() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool SetVisible(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isVisible
				/// </java-name>
				[Dot42.DexImport("isVisible", "()Z", AccessFlags = 17)]
				public bool IsVisible() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1025)]
				public abstract int GetOpacity() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// resolveOpacity
				/// </java-name>
				[Dot42.DexImport("resolveOpacity", "(II)I", AccessFlags = 9)]
				public static int ResolveOpacity(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				[Dot42.DexImport("getTransparentRegion", "()Landroid/graphics/Region;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Region GetTransparentRegion() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Region);
				}

				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal virtual bool OnStateChange(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool OnLevelChange(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal virtual void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public virtual int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public virtual int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
				public virtual int GetMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
				public virtual int GetMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// createFromStream
				/// </java-name>
				[Dot42.DexImport("createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromStream(global::Java.Io.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// createFromResourceStream
				/// </java-name>
				[Dot42.DexImport("createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Lja" +
    "va/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromResourceStream(global::Android.Content.Res.Resources resources, global::Android.Util.TypedValue typedValue, global::Java.Io.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// createFromResourceStream
				/// </java-name>
				[Dot42.DexImport("createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Lja" +
    "va/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawab" +
    "le/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromResourceStream(global::Android.Content.Res.Resources resources, global::Android.Util.TypedValue typedValue, global::Java.Io.InputStream inputStream, string @string, global::Android.Graphics.BitmapFactory.Options options) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// createFromXml
				/// </java-name>
				[Dot42.DexImport("createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/" +
    "drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromXml(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// createFromXmlInner
				/// </java-name>
				[Dot42.DexImport("createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)Landroid/graphics/drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromXmlInner(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// createFromPath
				/// </java-name>
				[Dot42.DexImport("createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromPath(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public virtual void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// getBounds
				/// </java-name>
				public global::Android.Graphics.Rect Bounds
				{
				[Dot42.DexImport("getBounds", "()Landroid/graphics/Rect;", AccessFlags = 17)]
						get{ return GetBounds(); }
				[Dot42.DexImport("setBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
						set{ SetBounds(value); }
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				[Dot42.DexImport("setChangingConfigurations", "(I)V", AccessFlags = 1)]
						set{ SetChangingConfigurations(value); }
				}

				/// <java-name>
				/// getCallback
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable.ICallback Callback
				{
				[Dot42.DexImport("getCallback", "()Landroid/graphics/drawable/Drawable$Callback;", AccessFlags = 1)]
						get{ return GetCallback(); }
				[Dot42.DexImport("setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V", AccessFlags = 17)]
						set{ SetCallback(value); }
				}

				/// <java-name>
				/// getState
				/// </java-name>
				public int[] State
				{
				[Dot42.DexImport("getState", "()[I", AccessFlags = 1)]
						get{ return GetState(); }
				}

				/// <java-name>
				/// getCurrent
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Current
				{
				[Dot42.DexImport("getCurrent", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetCurrent(); }
				}

				/// <java-name>
				/// getLevel
				/// </java-name>
				public int Level
				{
				[Dot42.DexImport("getLevel", "()I", AccessFlags = 17)]
						get{ return GetLevel(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1025)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				public global::Android.Graphics.Region TransparentRegion
				{
				[Dot42.DexImport("getTransparentRegion", "()Landroid/graphics/Region;", AccessFlags = 1)]
						get{ return GetTransparentRegion(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				public int MinimumWidth
				{
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetMinimumWidth(); }
				}

				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				public int MinimumHeight
				{
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetMinimumHeight(); }
				}

				/// <java-name>
				/// android/graphics/drawable/Drawable$ConstantState
				/// </java-name>
				[Dot42.DexImport("android/graphics/drawable/Drawable$ConstantState", AccessFlags = 1033)]
				public abstract partial class ConstantState
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public ConstantState() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// newDrawable
						/// </java-name>
						[Dot42.DexImport("newDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						public abstract global::Android.Graphics.Drawable.Drawable NewDrawable() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// newDrawable
						/// </java-name>
						[Dot42.DexImport("newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public virtual global::Android.Graphics.Drawable.Drawable NewDrawable(global::Android.Content.Res.Resources resources) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Drawable.Drawable);
						}

						/// <java-name>
						/// getChangingConfigurations
						/// </java-name>
						[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1025)]
						public abstract int GetChangingConfigurations() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// getChangingConfigurations
						/// </java-name>
						public int ChangingConfigurations
						{
						[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1025)]
								get{ return GetChangingConfigurations(); }
						}

				}

				/// <java-name>
				/// android/graphics/drawable/Drawable$Callback
				/// </java-name>
				[Dot42.DexImport("android/graphics/drawable/Drawable$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// invalidateDrawable
						/// </java-name>
						[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
						void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// scheduleDrawable
						/// </java-name>
						[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1025)]
						void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// unscheduleDrawable
						/// </java-name>
						[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1025)]
						void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/graphics/drawable/LayerDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/LayerDrawable", AccessFlags = 33)]
		public partial class LayerDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public LayerDrawable(global::Android.Graphics.Drawable.Drawable[] drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findDrawableByLayerId
				/// </java-name>
				[Dot42.DexImport("findDrawableByLayerId", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable FindDrawableByLayerId(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// setId
				/// </java-name>
				[Dot42.DexImport("setId", "(II)V", AccessFlags = 1)]
				public virtual void SetId(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNumberOfLayers
				/// </java-name>
				[Dot42.DexImport("getNumberOfLayers", "()I", AccessFlags = 1)]
				public virtual int GetNumberOfLayers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawable(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "(I)I", AccessFlags = 1)]
				public virtual int GetId(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setDrawableByLayerId
				/// </java-name>
				[Dot42.DexImport("setDrawableByLayerId", "(ILandroid/graphics/drawable/Drawable;)Z", AccessFlags = 1)]
				public virtual bool SetDrawableByLayerId(int int32, global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setLayerInset
				/// </java-name>
				[Dot42.DexImport("setLayerInset", "(IIIII)V", AccessFlags = 1)]
				public virtual void SetLayerInset(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOpacity
				/// </java-name>
				[Dot42.DexImport("setOpacity", "(I)V", AccessFlags = 1)]
				public virtual void SetOpacity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LayerDrawable() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNumberOfLayers
				/// </java-name>
				public int NumberOfLayers
				{
				[Dot42.DexImport("getNumberOfLayers", "()I", AccessFlags = 1)]
						get{ return GetNumberOfLayers(); }
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/DrawableContainer
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/DrawableContainer", AccessFlags = 33)]
		public partial class DrawableContainer : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DrawableContainer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEnterFadeDuration
				/// </java-name>
				[Dot42.DexImport("setEnterFadeDuration", "(I)V", AccessFlags = 1)]
				public virtual void SetEnterFadeDuration(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExitFadeDuration
				/// </java-name>
				[Dot42.DexImport("setExitFadeDuration", "(I)V", AccessFlags = 1)]
				public virtual void SetExitFadeDuration(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
				public override int GetMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
				public override int GetMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// selectDrawable
				/// </java-name>
				[Dot42.DexImport("selectDrawable", "(I)Z", AccessFlags = 1)]
				public virtual bool SelectDrawable(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCurrent
				/// </java-name>
				[Dot42.DexImport("getCurrent", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetCurrent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// setConstantState
				/// </java-name>
				[Dot42.DexImport("setConstantState", "(Landroid/graphics/drawable/DrawableContainer$DrawableContainerState;)V", AccessFlags = 4)]
				protected internal virtual void SetConstantState(global::Android.Graphics.Drawable.DrawableContainer.DrawableContainerState drawableContainerState) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				public int MinimumWidth
				{
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetMinimumWidth(); }
				}

				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				public int MinimumHeight
				{
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetMinimumHeight(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getCurrent
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Current
				{
				[Dot42.DexImport("getCurrent", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetCurrent(); }
				}

				/// <java-name>
				/// android/graphics/drawable/DrawableContainer$DrawableContainerState
				/// </java-name>
				[Dot42.DexImport("android/graphics/drawable/DrawableContainer$DrawableContainerState", AccessFlags = 1033)]
				public abstract partial class DrawableContainerState : global::Android.Graphics.Drawable.Drawable.ConstantState
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal DrawableContainerState() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getChangingConfigurations
						/// </java-name>
						[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// addChild
						/// </java-name>
						[Dot42.DexImport("addChild", "(Landroid/graphics/drawable/Drawable;)I", AccessFlags = 17)]
						public int AddChild(global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getChildCount
						/// </java-name>
						[Dot42.DexImport("getChildCount", "()I", AccessFlags = 17)]
						public int GetChildCount() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getChildren
						/// </java-name>
						[Dot42.DexImport("getChildren", "()[Landroid/graphics/drawable/Drawable;", AccessFlags = 17)]
						public global::Android.Graphics.Drawable.Drawable[] GetChildren() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Drawable.Drawable[]);
						}

						/// <java-name>
						/// setVariablePadding
						/// </java-name>
						[Dot42.DexImport("setVariablePadding", "(Z)V", AccessFlags = 17)]
						public void SetVariablePadding(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getConstantPadding
						/// </java-name>
						[Dot42.DexImport("getConstantPadding", "()Landroid/graphics/Rect;", AccessFlags = 17)]
						public global::Android.Graphics.Rect GetConstantPadding() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Rect);
						}

						/// <java-name>
						/// setConstantSize
						/// </java-name>
						[Dot42.DexImport("setConstantSize", "(Z)V", AccessFlags = 17)]
						public void SetConstantSize(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isConstantSize
						/// </java-name>
						[Dot42.DexImport("isConstantSize", "()Z", AccessFlags = 17)]
						public bool IsConstantSize() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getConstantWidth
						/// </java-name>
						[Dot42.DexImport("getConstantWidth", "()I", AccessFlags = 17)]
						public int GetConstantWidth() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getConstantHeight
						/// </java-name>
						[Dot42.DexImport("getConstantHeight", "()I", AccessFlags = 17)]
						public int GetConstantHeight() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getConstantMinimumWidth
						/// </java-name>
						[Dot42.DexImport("getConstantMinimumWidth", "()I", AccessFlags = 17)]
						public int GetConstantMinimumWidth() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getConstantMinimumHeight
						/// </java-name>
						[Dot42.DexImport("getConstantMinimumHeight", "()I", AccessFlags = 17)]
						public int GetConstantMinimumHeight() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// computeConstantSize
						/// </java-name>
						[Dot42.DexImport("computeConstantSize", "()V", AccessFlags = 4)]
						protected internal virtual void ComputeConstantSize() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setEnterFadeDuration
						/// </java-name>
						[Dot42.DexImport("setEnterFadeDuration", "(I)V", AccessFlags = 17)]
						public void SetEnterFadeDuration(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getEnterFadeDuration
						/// </java-name>
						[Dot42.DexImport("getEnterFadeDuration", "()I", AccessFlags = 17)]
						public int GetEnterFadeDuration() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// setExitFadeDuration
						/// </java-name>
						[Dot42.DexImport("setExitFadeDuration", "(I)V", AccessFlags = 17)]
						public void SetExitFadeDuration(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getExitFadeDuration
						/// </java-name>
						[Dot42.DexImport("getExitFadeDuration", "()I", AccessFlags = 17)]
						public int GetExitFadeDuration() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getOpacity
						/// </java-name>
						[Dot42.DexImport("getOpacity", "()I", AccessFlags = 17)]
						public int GetOpacity() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// isStateful
						/// </java-name>
						[Dot42.DexImport("isStateful", "()Z", AccessFlags = 17)]
						public bool IsStateful() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// growArray
						/// </java-name>
						[Dot42.DexImport("growArray", "(II)V", AccessFlags = 1)]
						public virtual void GrowArray(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// canConstantState
						/// </java-name>
						[Dot42.DexImport("canConstantState", "()Z", AccessFlags = 33)]
						public virtual bool CanConstantState() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getChangingConfigurations
						/// </java-name>
						public int ChangingConfigurations
						{
						[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
								get{ return GetChangingConfigurations(); }
						}

						/// <java-name>
						/// getChildCount
						/// </java-name>
						public int ChildCount
						{
						[Dot42.DexImport("getChildCount", "()I", AccessFlags = 17)]
								get{ return GetChildCount(); }
						}

						/// <java-name>
						/// getChildren
						/// </java-name>
						public global::Android.Graphics.Drawable.Drawable[] Children
						{
						[Dot42.DexImport("getChildren", "()[Landroid/graphics/drawable/Drawable;", AccessFlags = 17)]
								get{ return GetChildren(); }
						}

						/// <java-name>
						/// getConstantPadding
						/// </java-name>
						public global::Android.Graphics.Rect ConstantPadding
						{
						[Dot42.DexImport("getConstantPadding", "()Landroid/graphics/Rect;", AccessFlags = 17)]
								get{ return GetConstantPadding(); }
						}

						/// <java-name>
						/// getConstantWidth
						/// </java-name>
						public int ConstantWidth
						{
						[Dot42.DexImport("getConstantWidth", "()I", AccessFlags = 17)]
								get{ return GetConstantWidth(); }
						}

						/// <java-name>
						/// getConstantHeight
						/// </java-name>
						public int ConstantHeight
						{
						[Dot42.DexImport("getConstantHeight", "()I", AccessFlags = 17)]
								get{ return GetConstantHeight(); }
						}

						/// <java-name>
						/// getConstantMinimumWidth
						/// </java-name>
						public int ConstantMinimumWidth
						{
						[Dot42.DexImport("getConstantMinimumWidth", "()I", AccessFlags = 17)]
								get{ return GetConstantMinimumWidth(); }
						}

						/// <java-name>
						/// getConstantMinimumHeight
						/// </java-name>
						public int ConstantMinimumHeight
						{
						[Dot42.DexImport("getConstantMinimumHeight", "()I", AccessFlags = 17)]
								get{ return GetConstantMinimumHeight(); }
						}

						/// <java-name>
						/// getEnterFadeDuration
						/// </java-name>
						public int EnterFadeDuration
						{
						[Dot42.DexImport("getEnterFadeDuration", "()I", AccessFlags = 17)]
								get{ return GetEnterFadeDuration(); }
						[Dot42.DexImport("setEnterFadeDuration", "(I)V", AccessFlags = 17)]
								set{ SetEnterFadeDuration(value); }
						}

						/// <java-name>
						/// getExitFadeDuration
						/// </java-name>
						public int ExitFadeDuration
						{
						[Dot42.DexImport("getExitFadeDuration", "()I", AccessFlags = 17)]
								get{ return GetExitFadeDuration(); }
						[Dot42.DexImport("setExitFadeDuration", "(I)V", AccessFlags = 17)]
								set{ SetExitFadeDuration(value); }
						}

						/// <java-name>
						/// getOpacity
						/// </java-name>
						public int Opacity
						{
						[Dot42.DexImport("getOpacity", "()I", AccessFlags = 17)]
								get{ return GetOpacity(); }
						}

				}

		}

		/// <java-name>
		/// android/graphics/drawable/RotateDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/RotateDrawable", AccessFlags = 33)]
		public partial class RotateDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RotateDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Drawable
				{
				[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetDrawable(); }
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/NinePatchDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/NinePatchDrawable", AccessFlags = 33)]
		public partial class NinePatchDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V", AccessFlags = 1)]
				public NinePatchDrawable(global::Android.Graphics.Bitmap bitmap, sbyte[] sByte, global::Android.Graphics.Rect rect, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NinePatchDrawable(global::Android.Graphics.Bitmap bitmap, byte[] @byte, global::Android.Graphics.Rect rect, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;[BLandroid/graphics/Rect" +
    ";Ljava/lang/String;)V", AccessFlags = 1)]
				public NinePatchDrawable(global::Android.Content.Res.Resources resources, global::Android.Graphics.Bitmap bitmap, sbyte[] sByte, global::Android.Graphics.Rect rect, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;[BLandroid/graphics/Rect" +
    ";Ljava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NinePatchDrawable(global::Android.Content.Res.Resources resources, global::Android.Graphics.Bitmap bitmap, byte[] @byte, global::Android.Graphics.Rect rect, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/NinePatch;)V", AccessFlags = 1)]
				public NinePatchDrawable(global::Android.Graphics.NinePatch ninePatch) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/graphics/NinePatch;)V", AccessFlags = 1)]
				public NinePatchDrawable(global::Android.Content.Res.Resources resources, global::Android.Graphics.NinePatch ninePatch) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(I)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 1)]
				public override void SetFilterBitmap(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint GetPaint() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint);
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
				public override int GetMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
				public override int GetMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				[Dot42.DexImport("getTransparentRegion", "()Landroid/graphics/Region;", AccessFlags = 1)]
				public override global::Android.Graphics.Region GetTransparentRegion() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Region);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NinePatchDrawable() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				public global::Android.Graphics.Paint Paint
				{
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 1)]
						get{ return GetPaint(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				public int MinimumWidth
				{
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetMinimumWidth(); }
				}

				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				public int MinimumHeight
				{
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetMinimumHeight(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				public global::Android.Graphics.Region TransparentRegion
				{
				[Dot42.DexImport("getTransparentRegion", "()Landroid/graphics/Region;", AccessFlags = 1)]
						get{ return GetTransparentRegion(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/StateListDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/StateListDrawable", AccessFlags = 33)]
		public partial class StateListDrawable : global::Android.Graphics.Drawable.DrawableContainer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public StateListDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addState
				/// </java-name>
				[Dot42.DexImport("addState", "([ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void AddState(int[] int32, global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

		}

		/// <java-name>
		/// android/graphics/drawable/ColorDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/ColorDrawable", AccessFlags = 33)]
		public partial class ColorDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ColorDrawable() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ColorDrawable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "()I", AccessFlags = 1)]
				public virtual int GetColor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setColor
				/// </java-name>
				[Dot42.DexImport("setColor", "(I)V", AccessFlags = 1)]
				public virtual void SetColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAlpha
				/// </java-name>
				[Dot42.DexImport("getAlpha", "()I", AccessFlags = 1)]
				public virtual int GetAlpha() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getColor
				/// </java-name>
				public int Color
				{
				[Dot42.DexImport("getColor", "()I", AccessFlags = 1)]
						get{ return GetColor(); }
				[Dot42.DexImport("setColor", "(I)V", AccessFlags = 1)]
						set{ SetColor(value); }
				}

				/// <java-name>
				/// getAlpha
				/// </java-name>
				public int Alpha
				{
				[Dot42.DexImport("getAlpha", "()I", AccessFlags = 1)]
						get{ return GetAlpha(); }
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
						set{ SetAlpha(value); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/PictureDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/PictureDrawable", AccessFlags = 33)]
		public partial class PictureDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
				public PictureDrawable(global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPicture
				/// </java-name>
				[Dot42.DexImport("getPicture", "()Landroid/graphics/Picture;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Picture GetPicture() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Picture);
				}

				/// <java-name>
				/// setPicture
				/// </java-name>
				[Dot42.DexImport("setPicture", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
				public virtual void SetPicture(global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 1)]
				public override void SetFilterBitmap(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PictureDrawable() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPicture
				/// </java-name>
				public global::Android.Graphics.Picture Picture
				{
				[Dot42.DexImport("getPicture", "()Landroid/graphics/Picture;", AccessFlags = 1)]
						get{ return GetPicture(); }
				[Dot42.DexImport("setPicture", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
						set{ SetPicture(value); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/ClipDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/ClipDrawable", AccessFlags = 33)]
		public partial class ClipDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("HORIZONTAL", "I", AccessFlags = 25)]
				public const int HORIZONTAL = 1;
				/// <java-name>
				/// VERTICAL
				/// </java-name>
				[Dot42.DexImport("VERTICAL", "I", AccessFlags = 25)]
				public const int VERTICAL = 2;
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;II)V", AccessFlags = 1)]
				public ClipDrawable(global::Android.Graphics.Drawable.Drawable drawable, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ClipDrawable() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/Animatable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/Animatable", AccessFlags = 1537)]
		public partial interface IAnimatable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1025)]
				void Start() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1025)]
				void Stop() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isRunning
				/// </java-name>
				[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1025)]
				bool IsRunning() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/graphics/drawable/GradientDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/GradientDrawable", AccessFlags = 33)]
		public partial class GradientDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// RECTANGLE
				/// </java-name>
				[Dot42.DexImport("RECTANGLE", "I", AccessFlags = 25)]
				public const int RECTANGLE = 0;
				/// <java-name>
				/// OVAL
				/// </java-name>
				[Dot42.DexImport("OVAL", "I", AccessFlags = 25)]
				public const int OVAL = 1;
				/// <java-name>
				/// LINE
				/// </java-name>
				[Dot42.DexImport("LINE", "I", AccessFlags = 25)]
				public const int LINE = 2;
				/// <java-name>
				/// RING
				/// </java-name>
				[Dot42.DexImport("RING", "I", AccessFlags = 25)]
				public const int RING = 3;
				/// <java-name>
				/// LINEAR_GRADIENT
				/// </java-name>
				[Dot42.DexImport("LINEAR_GRADIENT", "I", AccessFlags = 25)]
				public const int LINEAR_GRADIENT = 0;
				/// <java-name>
				/// RADIAL_GRADIENT
				/// </java-name>
				[Dot42.DexImport("RADIAL_GRADIENT", "I", AccessFlags = 25)]
				public const int RADIAL_GRADIENT = 1;
				/// <java-name>
				/// SWEEP_GRADIENT
				/// </java-name>
				[Dot42.DexImport("SWEEP_GRADIENT", "I", AccessFlags = 25)]
				public const int SWEEP_GRADIENT = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GradientDrawable() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/GradientDrawable$Orientation;[I)V", AccessFlags = 1)]
				public GradientDrawable(global::Android.Graphics.Drawable.GradientDrawable.Orientation orientation, int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setCornerRadii
				/// </java-name>
				[Dot42.DexImport("setCornerRadii", "([F)V", AccessFlags = 1)]
				public virtual void SetCornerRadii(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCornerRadius
				/// </java-name>
				[Dot42.DexImport("setCornerRadius", "(F)V", AccessFlags = 1)]
				public virtual void SetCornerRadius(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStroke
				/// </java-name>
				[Dot42.DexImport("setStroke", "(II)V", AccessFlags = 1)]
				public virtual void SetStroke(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStroke
				/// </java-name>
				[Dot42.DexImport("setStroke", "(IIFF)V", AccessFlags = 1)]
				public virtual void SetStroke(int int32, int int321, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSize
				/// </java-name>
				[Dot42.DexImport("setSize", "(II)V", AccessFlags = 1)]
				public virtual void SetSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setShape
				/// </java-name>
				[Dot42.DexImport("setShape", "(I)V", AccessFlags = 1)]
				public virtual void SetShape(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGradientType
				/// </java-name>
				[Dot42.DexImport("setGradientType", "(I)V", AccessFlags = 1)]
				public virtual void SetGradientType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGradientCenter
				/// </java-name>
				[Dot42.DexImport("setGradientCenter", "(FF)V", AccessFlags = 1)]
				public virtual void SetGradientCenter(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGradientRadius
				/// </java-name>
				[Dot42.DexImport("setGradientRadius", "(F)V", AccessFlags = 1)]
				public virtual void SetGradientRadius(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUseLevel
				/// </java-name>
				[Dot42.DexImport("setUseLevel", "(Z)V", AccessFlags = 1)]
				public virtual void SetUseLevel(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColor
				/// </java-name>
				[Dot42.DexImport("setColor", "(I)V", AccessFlags = 1)]
				public virtual void SetColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <java-name>
				/// android/graphics/drawable/GradientDrawable$Orientation
				/// </java-name>
				[Dot42.DexImport("android/graphics/drawable/GradientDrawable$Orientation", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/graphics/drawable/GradientDrawable$Orientation;>;")]
				public sealed class Orientation
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BL_TR
						/// </java-name>
						[Dot42.DexImport("BL_TR", "Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 16409)]
						public static readonly Orientation BL_TR;
						/// <java-name>
						/// BOTTOM_TOP
						/// </java-name>
						[Dot42.DexImport("BOTTOM_TOP", "Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 16409)]
						public static readonly Orientation BOTTOM_TOP;
						/// <java-name>
						/// BR_TL
						/// </java-name>
						[Dot42.DexImport("BR_TL", "Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 16409)]
						public static readonly Orientation BR_TL;
						/// <java-name>
						/// LEFT_RIGHT
						/// </java-name>
						[Dot42.DexImport("LEFT_RIGHT", "Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 16409)]
						public static readonly Orientation LEFT_RIGHT;
						/// <java-name>
						/// RIGHT_LEFT
						/// </java-name>
						[Dot42.DexImport("RIGHT_LEFT", "Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 16409)]
						public static readonly Orientation RIGHT_LEFT;
						/// <java-name>
						/// TL_BR
						/// </java-name>
						[Dot42.DexImport("TL_BR", "Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 16409)]
						public static readonly Orientation TL_BR;
						/// <java-name>
						/// TOP_BOTTOM
						/// </java-name>
						[Dot42.DexImport("TOP_BOTTOM", "Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 16409)]
						public static readonly Orientation TOP_BOTTOM;
						/// <java-name>
						/// TR_BL
						/// </java-name>
						[Dot42.DexImport("TR_BL", "Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 16409)]
						public static readonly Orientation TR_BL;
						private Orientation() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 9)]
						public static Orientation[] Values() /* MethodBuilder.Create */ 
						{
								return default(Orientation[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 9)]
						public static Orientation ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Orientation);
						}

				}

		}

		/// <java-name>
		/// android/graphics/drawable/BitmapDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/BitmapDrawable", AccessFlags = 33)]
		public partial class BitmapDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BitmapDrawable() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Content.Res.Resources resources) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Content.Res.Resources resources, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BitmapDrawable(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Ljava/lang/String;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Content.Res.Resources resources, string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Ljava/io/InputStream;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Content.Res.Resources resources, global::Java.Io.InputStream inputStream) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 17)]
				public global::Android.Graphics.Paint GetPaint() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint);
				}

				/// <java-name>
				/// getBitmap
				/// </java-name>
				[Dot42.DexImport("getBitmap", "()Landroid/graphics/Bitmap;", AccessFlags = 17)]
				public global::Android.Graphics.Bitmap GetBitmap() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(I)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGravity
				/// </java-name>
				[Dot42.DexImport("getGravity", "()I", AccessFlags = 1)]
				public virtual int GetGravity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAntiAlias
				/// </java-name>
				[Dot42.DexImport("setAntiAlias", "(Z)V", AccessFlags = 1)]
				public virtual void SetAntiAlias(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 1)]
				public override void SetFilterBitmap(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTileModeX
				/// </java-name>
				[Dot42.DexImport("getTileModeX", "()Landroid/graphics/Shader$TileMode;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Shader.TileMode GetTileModeX() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Shader.TileMode);
				}

				/// <java-name>
				/// getTileModeY
				/// </java-name>
				[Dot42.DexImport("getTileModeY", "()Landroid/graphics/Shader$TileMode;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Shader.TileMode GetTileModeY() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Shader.TileMode);
				}

				/// <java-name>
				/// setTileModeX
				/// </java-name>
				[Dot42.DexImport("setTileModeX", "(Landroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
				public virtual void SetTileModeX(global::Android.Graphics.Shader.TileMode tileMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTileModeY
				/// </java-name>
				[Dot42.DexImport("setTileModeY", "(Landroid/graphics/Shader$TileMode;)V", AccessFlags = 17)]
				public void SetTileModeY(global::Android.Graphics.Shader.TileMode tileMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTileModeXY
				/// </java-name>
				[Dot42.DexImport("setTileModeXY", "(Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
				public virtual void SetTileModeXY(global::Android.Graphics.Shader.TileMode tileMode, global::Android.Graphics.Shader.TileMode tileMode1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 17)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				public global::Android.Graphics.Paint Paint
				{
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 17)]
						get{ return GetPaint(); }
				}

				/// <java-name>
				/// getBitmap
				/// </java-name>
				public global::Android.Graphics.Bitmap Bitmap
				{
				[Dot42.DexImport("getBitmap", "()Landroid/graphics/Bitmap;", AccessFlags = 17)]
						get{ return GetBitmap(); }
				}

				/// <java-name>
				/// getGravity
				/// </java-name>
				public int Gravity
				{
				[Dot42.DexImport("getGravity", "()I", AccessFlags = 1)]
						get{ return GetGravity(); }
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
						set{ SetGravity(value); }
				}

				/// <java-name>
				/// getTileModeX
				/// </java-name>
				public global::Android.Graphics.Shader.TileMode TileModeX
				{
				[Dot42.DexImport("getTileModeX", "()Landroid/graphics/Shader$TileMode;", AccessFlags = 1)]
						get{ return GetTileModeX(); }
				[Dot42.DexImport("setTileModeX", "(Landroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
						set{ SetTileModeX(value); }
				}

				/// <java-name>
				/// getTileModeY
				/// </java-name>
				public global::Android.Graphics.Shader.TileMode TileModeY
				{
				[Dot42.DexImport("getTileModeY", "()Landroid/graphics/Shader$TileMode;", AccessFlags = 1)]
						get{ return GetTileModeY(); }
				[Dot42.DexImport("setTileModeY", "(Landroid/graphics/Shader$TileMode;)V", AccessFlags = 17)]
						set{ SetTileModeY(value); }
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/ScaleDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/ScaleDrawable", AccessFlags = 33)]
		public partial class ScaleDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;IFF)V", AccessFlags = 1)]
				public ScaleDrawable(global::Android.Graphics.Drawable.Drawable drawable, int int32, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScaleDrawable() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Drawable
				{
				[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetDrawable(); }
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/PaintDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/PaintDrawable", AccessFlags = 33)]
		public partial class PaintDrawable : global::Android.Graphics.Drawable.ShapeDrawable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PaintDrawable() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public PaintDrawable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCornerRadius
				/// </java-name>
				[Dot42.DexImport("setCornerRadius", "(F)V", AccessFlags = 1)]
				public virtual void SetCornerRadius(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCornerRadii
				/// </java-name>
				[Dot42.DexImport("setCornerRadii", "([F)V", AccessFlags = 1)]
				public virtual void SetCornerRadii(float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflateTag
				/// </java-name>
				[Dot42.DexImport("inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;L" +
    "android/util/AttributeSet;)Z", AccessFlags = 4)]
				protected internal override bool InflateTag(string @string, global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// android/graphics/drawable/InsetDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/InsetDrawable", AccessFlags = 33)]
		public partial class InsetDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;I)V", AccessFlags = 1)]
				public InsetDrawable(global::Android.Graphics.Drawable.Drawable drawable, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;IIII)V", AccessFlags = 1)]
				public InsetDrawable(global::Android.Graphics.Drawable.Drawable drawable, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InsetDrawable() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/TransitionDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/TransitionDrawable", AccessFlags = 33)]
		public partial class TransitionDrawable : global::Android.Graphics.Drawable.LayerDrawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public TransitionDrawable(global::Android.Graphics.Drawable.Drawable[] drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startTransition
				/// </java-name>
				[Dot42.DexImport("startTransition", "(I)V", AccessFlags = 1)]
				public virtual void StartTransition(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetTransition
				/// </java-name>
				[Dot42.DexImport("resetTransition", "()V", AccessFlags = 1)]
				public virtual void ResetTransition() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reverseTransition
				/// </java-name>
				[Dot42.DexImport("reverseTransition", "(I)V", AccessFlags = 1)]
				public virtual void ReverseTransition(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCrossFadeEnabled
				/// </java-name>
				[Dot42.DexImport("setCrossFadeEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetCrossFadeEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isCrossFadeEnabled
				/// </java-name>
				[Dot42.DexImport("isCrossFadeEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsCrossFadeEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TransitionDrawable() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("android/graphics/drawable/Drawable$Callback", "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public override void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable drawable) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/graphics/drawable/Drawable$Callback", "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1025)]
				public override void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/graphics/drawable/Drawable$Callback", "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1025)]
				public override void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable drawable, global::Java.Lang.IRunnable runnable) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <java-name>
		/// android/graphics/drawable/AnimationDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/AnimationDrawable", AccessFlags = 33)]
		public partial class AnimationDrawable : global::Android.Graphics.Drawable.DrawableContainer, global::Java.Lang.IRunnable, global::Android.Graphics.Drawable.IAnimatable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnimationDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isRunning
				/// </java-name>
				[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1)]
				public virtual bool IsRunning() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleSelf
				/// </java-name>
				[Dot42.DexImport("unscheduleSelf", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public override void UnscheduleSelf(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNumberOfFrames
				/// </java-name>
				[Dot42.DexImport("getNumberOfFrames", "()I", AccessFlags = 1)]
				public virtual int GetNumberOfFrames() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getFrame
				/// </java-name>
				[Dot42.DexImport("getFrame", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetFrame(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "(I)I", AccessFlags = 1)]
				public virtual int GetDuration(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// isOneShot
				/// </java-name>
				[Dot42.DexImport("isOneShot", "()Z", AccessFlags = 1)]
				public virtual bool IsOneShot() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOneShot
				/// </java-name>
				[Dot42.DexImport("setOneShot", "(Z)V", AccessFlags = 1)]
				public virtual void SetOneShot(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFrame
				/// </java-name>
				[Dot42.DexImport("addFrame", "(Landroid/graphics/drawable/Drawable;I)V", AccessFlags = 1)]
				public virtual void AddFrame(global::Android.Graphics.Drawable.Drawable drawable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getNumberOfFrames
				/// </java-name>
				public int NumberOfFrames
				{
				[Dot42.DexImport("getNumberOfFrames", "()I", AccessFlags = 1)]
						get{ return GetNumberOfFrames(); }
				}

		}

		/// <java-name>
		/// android/graphics/drawable/LevelListDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/LevelListDrawable", AccessFlags = 33)]
		public partial class LevelListDrawable : global::Android.Graphics.Drawable.DrawableContainer
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LevelListDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addLevel
				/// </java-name>
				[Dot42.DexImport("addLevel", "(IILandroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void AddLevel(int int32, int int321, global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources resources, global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

		}

}

