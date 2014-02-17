// Copyright (C) 2014 dot42
//
// Original filename: Android.Graphics.Drawable.cs
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
namespace Android.Graphics.Drawable
{
		/// <summary>
		/// <para>A Drawable that wraps a bitmap and can be tiled, stretched, or aligned. You can create a BitmapDrawable from a file path, an input stream, through XML inflation, or from a android.graphics.Bitmap object. </para><para>It can be defined in an XML file with the <code>&lt;bitmap&gt;</code> element. For more information, see the guide to .</para><para>Also see the android.graphics.Bitmap class, which handles the management and transformation of raw bitmap graphics, and should be used when drawing to a android.graphics.Canvas. </para><para>ref android.R.styleable::BitmapDrawable_src  ref android.R.styleable::BitmapDrawable_antialias  ref android.R.styleable::BitmapDrawable_filter  ref android.R.styleable::BitmapDrawable_dither  ref android.R.styleable::BitmapDrawable_gravity  ref android.R.styleable::BitmapDrawable_mipMap  ref android.R.styleable::BitmapDrawable_tileMode </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/BitmapDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/BitmapDrawable", AccessFlags = 33)]
		public partial class BitmapDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create an empty drawable, not dealing with density. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use BitmapDrawable(android.content.res.Resources, android.graphics.Bitmap) instead to specify a bitmap to draw with and ensure the correct density is set. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BitmapDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create an empty drawable, setting initial target density based on the display metrics of the resources. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use BitmapDrawable(android.content.res.Resources, android.graphics.Bitmap) instead to specify a bitmap to draw with. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Content.Res.Resources res) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create an empty drawable, setting initial target density based on the display metrics of the resources. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use BitmapDrawable(android.content.res.Resources, android.graphics.Bitmap) instead to specify a bitmap to draw with. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Graphics.Bitmap res) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create drawable from a bitmap, setting initial target density based on the display metrics of the resources. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Content.Res.Resources res, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create an empty drawable, setting initial target density based on the display metrics of the resources. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use BitmapDrawable(android.content.res.Resources, android.graphics.Bitmap) instead to specify a bitmap to draw with. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public BitmapDrawable(string res) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create drawable from a bitmap, setting initial target density based on the display metrics of the resources. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Ljava/lang/String;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Content.Res.Resources res, string bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create an empty drawable, setting initial target density based on the display metrics of the resources. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use BitmapDrawable(android.content.res.Resources, android.graphics.Bitmap) instead to specify a bitmap to draw with. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/io/InputStream;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Java.Io.InputStream res) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create drawable from a bitmap, setting initial target density based on the display metrics of the resources. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Ljava/io/InputStream;)V", AccessFlags = 1)]
				public BitmapDrawable(global::Android.Content.Res.Resources res, global::Java.Io.InputStream bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the paint used to render this drawable. </para>        
				/// </summary>
				/// <java-name>
				/// getPaint
				/// </java-name>
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 17)]
				public global::Android.Graphics.Paint GetPaint() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint);
				}

				/// <summary>
				/// <para>Returns the bitmap used by this drawable to render. May be null. </para>        
				/// </summary>
				/// <java-name>
				/// getBitmap
				/// </java-name>
				[Dot42.DexImport("getBitmap", "()Landroid/graphics/Bitmap;", AccessFlags = 17)]
				public global::Android.Graphics.Bitmap GetBitmap() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				/// <para>Set the density scale at which this drawable will be rendered. This method assumes the drawable will be rendered at the same density as the specified canvas.</para><para><para>android.graphics.Bitmap::setDensity(int) </para><simplesectsep></simplesectsep><para>android.graphics.Bitmap::getDensity() </para></para>        
				/// </summary>
				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the density scale at which this drawable will be rendered. This method assumes the drawable will be rendered at the same density as the specified canvas.</para><para><para>android.graphics.Bitmap::setDensity(int) </para><simplesectsep></simplesectsep><para>android.graphics.Bitmap::getDensity() </para></para>        
				/// </summary>
				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(global::Android.Util.DisplayMetrics canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the density scale at which this drawable will be rendered. This method assumes the drawable will be rendered at the same density as the specified canvas.</para><para><para>android.graphics.Bitmap::setDensity(int) </para><simplesectsep></simplesectsep><para>android.graphics.Bitmap::getDensity() </para></para>        
				/// </summary>
				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(I)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(int canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the gravity used to position/stretch the bitmap within its bounds. See android.view.Gravity </para>        
				/// </summary>
				/// <returns>
				/// <para>the gravity applied to the bitmap </para>
				/// </returns>
				/// <java-name>
				/// getGravity
				/// </java-name>
				[Dot42.DexImport("getGravity", "()I", AccessFlags = 1)]
				public virtual int GetGravity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Set the gravity used to position/stretch the bitmap within its bounds. See android.view.Gravity </para>        
				/// </summary>
				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int gravity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Enables or disables anti-aliasing for this drawable. Anti-aliasing affects the edges of the bitmap only so it applies only when the drawable is rotated.</para><para><para>hasAntiAlias() </para></para>        
				/// </summary>
				/// <java-name>
				/// setAntiAlias
				/// </java-name>
				[Dot42.DexImport("setAntiAlias", "(Z)V", AccessFlags = 1)]
				public virtual void SetAntiAlias(bool aa) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set to true to have the drawable filter its bitmap when scaled or rotated (for drawables that use bitmaps). If the drawable does not use bitmaps, this call is ignored. This can improve the look when scaled or rotated, but also slows down the drawing. </para>        
				/// </summary>
				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 1)]
				public override void SetFilterBitmap(bool filter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set to true to have the drawable dither its colors when drawn to a device with fewer than 8-bits per color component. This can improve the look on those devices, but can also slow down the drawing a little. </para>        
				/// </summary>
				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool dither) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates the repeat behavior of this drawable on the X axis.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Shader.TileMode#CLAMP if the bitmap does not repeat, Shader.TileMode#REPEAT or Shader.TileMode#MIRROR otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getTileModeX
				/// </java-name>
				[Dot42.DexImport("getTileModeX", "()Landroid/graphics/Shader$TileMode;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Shader.TileMode GetTileModeX() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Shader.TileMode);
				}

				/// <summary>
				/// <para>Indicates the repeat behavior of this drawable on the Y axis.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Shader.TileMode#CLAMP if the bitmap does not repeat, Shader.TileMode#REPEAT or Shader.TileMode#MIRROR otherwise. </para>
				/// </returns>
				/// <java-name>
				/// getTileModeY
				/// </java-name>
				[Dot42.DexImport("getTileModeY", "()Landroid/graphics/Shader$TileMode;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Shader.TileMode GetTileModeY() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Shader.TileMode);
				}

				/// <summary>
				/// <para>Sets the repeat behavior of this drawable on the X axis. By default, the drawable does not repeat its bitmap. Using Shader.TileMode#REPEAT or Shader.TileMode#MIRROR the bitmap can be repeated (or tiled) if the bitmap is smaller than this drawable.</para><para><para>setTileModeY(android.graphics.Shader.TileMode) </para><simplesectsep></simplesectsep><para>setTileModeXY(android.graphics.Shader.TileMode, android.graphics.Shader.TileMode) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTileModeX
				/// </java-name>
				[Dot42.DexImport("setTileModeX", "(Landroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
				public virtual void SetTileModeX(global::Android.Graphics.Shader.TileMode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the repeat behavior of this drawable on the Y axis. By default, the drawable does not repeat its bitmap. Using Shader.TileMode#REPEAT or Shader.TileMode#MIRROR the bitmap can be repeated (or tiled) if the bitmap is smaller than this drawable.</para><para><para>setTileModeX(android.graphics.Shader.TileMode) </para><simplesectsep></simplesectsep><para>setTileModeXY(android.graphics.Shader.TileMode, android.graphics.Shader.TileMode) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTileModeY
				/// </java-name>
				[Dot42.DexImport("setTileModeY", "(Landroid/graphics/Shader$TileMode;)V", AccessFlags = 17)]
				public void SetTileModeY(global::Android.Graphics.Shader.TileMode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the repeat behavior of this drawable on both axis. By default, the drawable does not repeat its bitmap. Using Shader.TileMode#REPEAT or Shader.TileMode#MIRROR the bitmap can be repeated (or tiled) if the bitmap is smaller than this drawable.</para><para><para>setTileModeX(android.graphics.Shader.TileMode) </para><simplesectsep></simplesectsep><para>setTileModeY(android.graphics.Shader.TileMode) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTileModeXY
				/// </java-name>
				[Dot42.DexImport("setTileModeXY", "(Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V", AccessFlags = 1)]
				public virtual void SetTileModeXY(global::Android.Graphics.Shader.TileMode xmode, global::Android.Graphics.Shader.TileMode ymode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A mutable BitmapDrawable still shares its Bitmap with any other Drawable that comes from the same resource.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 17)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Returns the paint used to render this drawable. </para>        
				/// </summary>
				/// <java-name>
				/// getPaint
				/// </java-name>
				public global::Android.Graphics.Paint Paint
				{
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 17)]
						get{ return GetPaint(); }
				}

				/// <summary>
				/// <para>Returns the bitmap used by this drawable to render. May be null. </para>        
				/// </summary>
				/// <java-name>
				/// getBitmap
				/// </java-name>
				public global::Android.Graphics.Bitmap Bitmap
				{
				[Dot42.DexImport("getBitmap", "()Landroid/graphics/Bitmap;", AccessFlags = 17)]
						get{ return GetBitmap(); }
				}

				/// <summary>
				/// <para>Get the gravity used to position/stretch the bitmap within its bounds. See android.view.Gravity </para>        
				/// </summary>
				/// <returns>
				/// <para>the gravity applied to the bitmap </para>
				/// </returns>
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

				/// <summary>
				/// <para>Indicates the repeat behavior of this drawable on the X axis.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Shader.TileMode#CLAMP if the bitmap does not repeat, Shader.TileMode#REPEAT or Shader.TileMode#MIRROR otherwise. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Indicates the repeat behavior of this drawable on the Y axis.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Shader.TileMode#CLAMP if the bitmap does not repeat, Shader.TileMode#REPEAT or Shader.TileMode#MIRROR otherwise. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

		}

		/// <summary>
		/// <para>A Drawable that insets another Drawable by a specified distance. This is used when a View needs a background that is smaller than the View's actual bounds.</para><para>It can be defined in an XML file with the <code>&lt;inset&gt;</code> element. For more information, see the guide to .</para><para>ref android.R.styleable::InsetDrawable_visible  ref android.R.styleable::InsetDrawable_drawable  ref android.R.styleable::InsetDrawable_insetLeft  ref android.R.styleable::InsetDrawable_insetRight  ref android.R.styleable::InsetDrawable_insetTop  ref android.R.styleable::InsetDrawable_insetBottom </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/InsetDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/InsetDrawable", AccessFlags = 33)]
		public partial class InsetDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;I)V", AccessFlags = 1)]
				public InsetDrawable(global::Android.Graphics.Drawable.Drawable drawable, int inset) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;IIII)V", AccessFlags = 1)]
				public InsetDrawable(global::Android.Graphics.Drawable.Drawable drawable, int insetLeft, int insetTop, int insetRight, int insetBottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to schedule the next frame of its animation. An implementation can generally simply call android.os.Handler#postAtTime(Runnable, Object, long) with the parameters <b>(what, who, when)</b> to perform the scheduling.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to unschedule an action previously scheduled with scheduleDrawable. An implementation can generally simply call android.os.Handler#removeCallbacks(Runnable, Object) with the parameters <b>(what, who)</b> to unschedule the drawable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set whether this Drawable is visible. This generally does not impact the Drawable's behavior, but is a hint that can be used by some Drawables, for example, to decide whether run animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Returns true if the new visibility is different than its previous state. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool visible, bool restart) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether this view will change its appearance based on state. Clients can use this to determine whether it is necessary to calculate their state and call setState.</para><para><para>#setState(int[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this view changes its appearance based on state, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the state change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last state. </para>
				/// </returns>
				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] state) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <summary>
		/// <para>A Drawable that clips another Drawable based on this Drawable's current level value. You can control how much the child Drawable gets clipped in width and height based on the level, as well as a gravity to control where it is placed in its overall container. Most often used to implement things like progress bars, by increasing the drawable's level with setLevel(). </para><para><b>Note:</b> The drawable is clipped completely and not visible when the level is 0 and fully revealed when the level is 10,000.</para><para>It can be defined in an XML file with the <code>&lt;clip&gt;</code> element. For more information, see the guide to .</para><para>ref android.R.styleable::ClipDrawable_clipOrientation  ref android.R.styleable::ClipDrawable_gravity  ref android.R.styleable::ClipDrawable_drawable </para>    
		/// </summary>
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
				/// <summary>
				/// <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;II)V", AccessFlags = 1)]
				public ClipDrawable(global::Android.Graphics.Drawable.Drawable drawable, int gravity, int orientation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to schedule the next frame of its animation. An implementation can generally simply call android.os.Handler#postAtTime(Runnable, Object, long) with the parameters <b>(what, who, when)</b> to perform the scheduling.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to unschedule an action previously scheduled with scheduleDrawable. An implementation can generally simply call android.os.Handler#removeCallbacks(Runnable, Object) with the parameters <b>(what, who)</b> to unschedule the drawable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set whether this Drawable is visible. This generally does not impact the Drawable's behavior, but is a hint that can be used by some Drawables, for example, to decide whether run animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Returns true if the new visibility is different than its previous state. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool visible, bool restart) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether this view will change its appearance based on state. Clients can use this to determine whether it is necessary to calculate their state and call setState.</para><para><para>#setState(int[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this view changes its appearance based on state, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the state change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last state. </para>
				/// </returns>
				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] state) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you vary based on level. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the level change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last level. </para>
				/// </returns>
				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <summary>
		/// <para>Lets you assign a number of graphic images to a single Drawable and swap out the visible item by a string ID value. </para><para>It can be defined in an XML file with the <code>&lt;selector&gt;</code> element. Each state Drawable is defined in a nested <code>&lt;item&gt;</code> element. For more information, see the guide to .</para><para>ref android.R.styleable::StateListDrawable_visible  ref android.R.styleable::StateListDrawable_variablePadding  ref android.R.styleable::StateListDrawable_constantSize  ref android.R.styleable::DrawableStates_state_focused  ref android.R.styleable::DrawableStates_state_window_focused  ref android.R.styleable::DrawableStates_state_enabled  ref android.R.styleable::DrawableStates_state_checkable  ref android.R.styleable::DrawableStates_state_checked  ref android.R.styleable::DrawableStates_state_selected  ref android.R.styleable::DrawableStates_state_activated  ref android.R.styleable::DrawableStates_state_active  ref android.R.styleable::DrawableStates_state_single  ref android.R.styleable::DrawableStates_state_first  ref android.R.styleable::DrawableStates_state_middle  ref android.R.styleable::DrawableStates_state_last  ref android.R.styleable::DrawableStates_state_pressed </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Add a new image/string ID to the set of images.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addState
				/// </java-name>
				[Dot42.DexImport("addState", "([ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void AddState(int[] stateSet, global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether this view will change its appearance based on state. Clients can use this to determine whether it is necessary to calculate their state and call setState.</para><para><para>#setState(int[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this view changes its appearance based on state, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the state change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last state. </para>
				/// </returns>
				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] state) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

		}

		/// <summary>
		/// <para>An object used to create frame-by-frame animations, defined by a series of Drawable objects, which can be used as a View object's background. </para><para>The simplest way to create a frame-by-frame animation is to define the animation in an XML file, placed in the res/drawable/ folder, and set it as the background to a View object. Then, call start() to run the animation. </para><para>An AnimationDrawable defined in XML consists of a single <code>&lt;animation-list&gt;</code> element, and a series of nested <code>&lt;item&gt;</code> tags. Each item defines a frame of the animation. See the example below. </para><para>spin_animation.xml file in res/drawable/ folder:</para><para><pre>&lt;! Animation frames are wheel0.png  wheel5.png files inside the
		///    res/drawable/ folder &gt;
		///    &lt;animation-list android:id="@+id/selected" android:oneshot="false"&gt;
		///       &lt;item android:drawable="/wheel0" android:duration="50" /&gt;
		///       &lt;item android:drawable="/wheel1" android:duration="50" /&gt;
		///       &lt;item android:drawable="/wheel2" android:duration="50" /&gt;
		///       &lt;item android:drawable="/wheel3" android:duration="50" /&gt;
		///       &lt;item android:drawable="/wheel4" android:duration="50" /&gt;
		///       &lt;item android:drawable="/wheel5" android:duration="50" /&gt;
		///    &lt;/animation-list&gt;</pre></para><para>Here is the code to load and play this animation.</para><para><pre>
		///    // Load the ImageView that will host the animation and
		///    // set its background to our AnimationDrawable XML resource.
		///    ImageView img = (ImageView)findViewById(R.id.spinning_wheel_image);
		///    img.setBackgroundResource(R.drawable.spin_animation);
		/// 
		///    // Get the background, which has been compiled to an AnimationDrawable object.
		///    AnimationDrawable frameAnimation = (AnimationDrawable) img.getBackground();
		/// 
		///    // Start the animation (looped playback by default).
		///    frameAnimation.start();
		///    </pre></para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about animating with <c> AnimationDrawable </c> , read the  developer guide.</para><para> </para><para>ref android.R.styleable::AnimationDrawable_visible  ref android.R.styleable::AnimationDrawable_variablePadding  ref android.R.styleable::AnimationDrawable_oneshot  ref android.R.styleable::AnimationDrawableItem_duration  ref android.R.styleable::AnimationDrawableItem_drawable </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Set whether this Drawable is visible. This generally does not impact the Drawable's behavior, but is a hint that can be used by some Drawables, for example, to decide whether run animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Returns true if the new visibility is different than its previous state. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool visible, bool restart) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Starts the animation, looping if necessary. This method has no effect if the animation is running. Do not call this in the android.app.Activity#onCreate method of your activity, because the android.graphics.drawable.AnimationDrawable is not yet fully attached to the window. If you want to play the animation immediately, without requiring interaction, then you might want to call it from the android.app.Activity#onWindowFocusChanged method in your activity, which will get called when Android brings your window into focus.</para><para><para>isRunning() </para><simplesectsep></simplesectsep><para>stop() </para></para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stops the animation. This method has no effect if the animation is not running.</para><para><para>isRunning() </para><simplesectsep></simplesectsep><para>start() </para></para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether the animation is currently running or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the animation is running, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isRunning
				/// </java-name>
				[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1)]
				public virtual bool IsRunning() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>This method exists for implementation purpose only and should not be called directly. Invoke start() instead.</para><para><para>start() </para></para>        
				/// </summary>
				/// <java-name>
				/// run
				/// </java-name>
				[Dot42.DexImport("run", "()V", AccessFlags = 1)]
				public virtual void Run() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Use the current Callback implementation to have this Drawable unscheduled. Does nothing if there is no Callback attached to the Drawable.</para><para><para>Callback::unscheduleDrawable </para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleSelf
				/// </java-name>
				[Dot42.DexImport("unscheduleSelf", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public override void UnscheduleSelf(global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of frames in the animation </para>
				/// </returns>
				/// <java-name>
				/// getNumberOfFrames
				/// </java-name>
				[Dot42.DexImport("getNumberOfFrames", "()I", AccessFlags = 1)]
				public virtual int GetNumberOfFrames() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Drawable at the specified frame index </para>
				/// </returns>
				/// <java-name>
				/// getFrame
				/// </java-name>
				[Dot42.DexImport("getFrame", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetFrame(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The duration in milliseconds of the frame at the specified index </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "(I)I", AccessFlags = 1)]
				public virtual int GetDuration(int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>True of the animation will play once, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isOneShot
				/// </java-name>
				[Dot42.DexImport("isOneShot", "()Z", AccessFlags = 1)]
				public virtual bool IsOneShot() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether the animation should play once or repeat.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setOneShot
				/// </java-name>
				[Dot42.DexImport("setOneShot", "(Z)V", AccessFlags = 1)]
				public virtual void SetOneShot(bool oneShot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Add a frame to the animation</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addFrame
				/// </java-name>
				[Dot42.DexImport("addFrame", "(Landroid/graphics/drawable/Drawable;I)V", AccessFlags = 1)]
				public virtual void AddFrame(global::Android.Graphics.Drawable.Drawable frame, int duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of frames in the animation </para>
				/// </returns>
				/// <java-name>
				/// getNumberOfFrames
				/// </java-name>
				public int NumberOfFrames
				{
				[Dot42.DexImport("getNumberOfFrames", "()I", AccessFlags = 1)]
						get{ return GetNumberOfFrames(); }
				}

		}

		/// <summary>
		/// <para>A helper class that contains several Drawables and selects which one to use.</para><para>You can subclass it to create your own DrawableContainers or directly use one its child classes. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set to true to have the drawable dither its colors when drawn to a device with fewer than 8-bits per color component. This can improve the look on those devices, but can also slow down the drawing a little. </para>        
				/// </summary>
				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool dither) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Change the global fade duration when a new drawable is entering the scene. </para>        
				/// </summary>
				/// <java-name>
				/// setEnterFadeDuration
				/// </java-name>
				[Dot42.DexImport("setEnterFadeDuration", "(I)V", AccessFlags = 1)]
				public virtual void SetEnterFadeDuration(int ms) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Change the global fade duration when a new drawable is leaving the scene. </para>        
				/// </summary>
				/// <java-name>
				/// setExitFadeDuration
				/// </java-name>
				[Dot42.DexImport("setExitFadeDuration", "(I)V", AccessFlags = 1)]
				public virtual void SetExitFadeDuration(int ms) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether this view will change its appearance based on state. Clients can use this to determine whether it is necessary to calculate their state and call setState.</para><para><para>#setState(int[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this view changes its appearance based on state, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>If this Drawable does transition animations between states, ask that it immediately jump to the current state and skip any active animations. </para>        
				/// </summary>
				/// <java-name>
				/// jumpToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the state change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last state. </para>
				/// </returns>
				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] state) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you vary based on level. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the level change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last level. </para>
				/// </returns>
				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum width suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its width. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum width suggested by this Drawable. If this Drawable doesn't have a suggested minimum width, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
				public override int GetMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum height suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its height. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum height suggested by this Drawable. If this Drawable doesn't have a suggested minimum height, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
				public override int GetMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to schedule the next frame of its animation. An implementation can generally simply call android.os.Handler#postAtTime(Runnable, Object, long) with the parameters <b>(what, who, when)</b> to perform the scheduling.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to unschedule an action previously scheduled with scheduleDrawable. An implementation can generally simply call android.os.Handler#removeCallbacks(Runnable, Object) with the parameters <b>(what, who)</b> to unschedule the drawable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set whether this Drawable is visible. This generally does not impact the Drawable's behavior, but is a hint that can be used by some Drawables, for example, to decide whether run animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Returns true if the new visibility is different than its previous state. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool visible, bool restart) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
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
				public virtual bool SelectDrawable(int idx) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current drawable that will be used by this drawable. For simple drawables, this is just the drawable itself. For drawables that change state like StateListDrawable and LevelListDrawable this will be the child drawable currently in use. </para>
				/// </returns>
				/// <java-name>
				/// getCurrent
				/// </java-name>
				[Dot42.DexImport("getCurrent", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable GetCurrent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
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
				protected internal virtual void SetConstantState(global::Android.Graphics.Drawable.DrawableContainer.DrawableContainerState state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <summary>
				/// <para>Returns the minimum width suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its width. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum width suggested by this Drawable. If this Drawable doesn't have a suggested minimum width, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				public int MinimumWidth
				{
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetMinimumWidth(); }
				}

				/// <summary>
				/// <para>Returns the minimum height suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its height. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum height suggested by this Drawable. If this Drawable doesn't have a suggested minimum height, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				public int MinimumHeight
				{
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetMinimumHeight(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current drawable that will be used by this drawable. For simple drawables, this is just the drawable itself. For drawables that change state like StateListDrawable and LevelListDrawable this will be the child drawable currently in use. </para>
				/// </returns>
				/// <java-name>
				/// getCurrent
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Current
				{
				[Dot42.DexImport("getCurrent", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetCurrent(); }
				}

				/// <summary>
				/// <para>A ConstantState that can contain several Drawables.</para><para>This class was made public to enable testing, and its visibility may change in a future release. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>Return a bit mask of configuration changes that will impact this drawable (and thus require completely reloading it). </para>        
						/// </summary>
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
						public int AddChild(global::Android.Graphics.Drawable.Drawable dr) /* MethodBuilder.Create */ 
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

						/// <summary>
						/// <para>A boolean value indicating whether to use the maximum padding value of all frames in the set (false), or to use the padding value of the frame being shown (true). Default value is false. </para>        
						/// </summary>
						/// <java-name>
						/// setVariablePadding
						/// </java-name>
						[Dot42.DexImport("setVariablePadding", "(Z)V", AccessFlags = 17)]
						public void SetVariablePadding(bool variable) /* MethodBuilder.Create */ 
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
						public void SetConstantSize(bool constant) /* MethodBuilder.Create */ 
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
						public void SetEnterFadeDuration(int duration) /* MethodBuilder.Create */ 
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
						public void SetExitFadeDuration(int duration) /* MethodBuilder.Create */ 
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
						public virtual void GrowArray(int oldSize, int newSize) /* MethodBuilder.Create */ 
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

						/// <summary>
						/// <para>Return a bit mask of configuration changes that will impact this drawable (and thus require completely reloading it). </para>        
						/// </summary>
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

		/// <summary>
		/// <para>Drawable that draws its bounds in the given paint, with optional rounded corners. </para>    
		/// </summary>
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
				public PaintDrawable(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify radius for the corners of the rectangle. If this is &gt; 0, then the drawable is drawn in a round-rectangle, rather than a rectangle. </para>        
				/// </summary>
				/// <java-name>
				/// setCornerRadius
				/// </java-name>
				[Dot42.DexImport("setCornerRadius", "(F)V", AccessFlags = 1)]
				public virtual void SetCornerRadius(float radius) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify radii for each of the 4 corners. For each corner, the array contains 2 values, [X_radius, Y_radius]. The corners are ordered top-left, top-right, bottom-right, bottom-left </para>        
				/// </summary>
				/// <java-name>
				/// setCornerRadii
				/// </java-name>
				[Dot42.DexImport("setCornerRadii", "([F)V", AccessFlags = 1)]
				public virtual void SetCornerRadii(float[] radii) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Subclasses override this to parse custom subelements. If you handle it, return true, else return <b>super.inflateTag(...)</b>. </para>        
				/// </summary>
				/// <java-name>
				/// inflateTag
				/// </java-name>
				[Dot42.DexImport("inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;L" +
    "android/util/AttributeSet;)Z", AccessFlags = 4)]
				protected internal override bool InflateTag(string name, global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		/// <para>A resource that manages a number of alternate Drawables, each assigned a maximum numerical value. Setting the level value of the object with setLevel(int) will load the image with the next greater or equal value assigned to its max attribute. A good example use of a LevelListDrawable would be a battery level indicator icon, with different images to indicate the current battery level. </para><para>It can be defined in an XML file with the <code>&lt;level-list&gt;</code> element. Each Drawable level is defined in a nested <code>&lt;item&gt;</code>. For example: </para><para><pre>
		///    &lt;level-list xmlns:android="http://schemas.android.com/apk/res/android"&gt;
		///     &lt;item android:maxLevel="0" android:drawable="@drawable/ic_wifi_signal_1" /&gt;
		///     &lt;item android:maxLevel="1" android:drawable="@drawable/ic_wifi_signal_2" /&gt;
		///     &lt;item android:maxLevel="2" android:drawable="@drawable/ic_wifi_signal_3" /&gt;
		///     &lt;item android:maxLevel="3" android:drawable="@drawable/ic_wifi_signal_4" /&gt;
		///    &lt;/level-list&gt;
		///   </pre> </para><para>With this XML saved into the res/drawable/ folder of the project, it can be referenced as the drawable for an android.widget.ImageView. The default image is the first in the list. It can then be changed to one of the other levels with android.widget.ImageView#setImageLevel(int). For more information, see the guide to .</para><para>ref android.R.styleable::LevelListDrawableItem_minLevel  ref android.R.styleable::LevelListDrawableItem_maxLevel  ref android.R.styleable::LevelListDrawableItem_drawable </para>    
		/// </summary>
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
				public virtual void AddLevel(int low, int high, global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you vary based on level. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the level change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last level. </para>
				/// </returns>
				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

		}

		/// <summary>
		/// <para>A Drawable with a color gradient for buttons, backgrounds, etc.</para><para>It can be defined in an XML file with the <code>&lt;shape&gt;</code> element. For more information, see the guide to .</para><para>ref android.R.styleable::GradientDrawable_visible  ref android.R.styleable::GradientDrawable_shape  ref android.R.styleable::GradientDrawable_innerRadiusRatio  ref android.R.styleable::GradientDrawable_innerRadius  ref android.R.styleable::GradientDrawable_thicknessRatio  ref android.R.styleable::GradientDrawable_thickness  ref android.R.styleable::GradientDrawable_useLevel  ref android.R.styleable::GradientDrawableSize_width  ref android.R.styleable::GradientDrawableSize_height  ref android.R.styleable::GradientDrawableGradient_startColor  ref android.R.styleable::GradientDrawableGradient_centerColor  ref android.R.styleable::GradientDrawableGradient_endColor  ref android.R.styleable::GradientDrawableGradient_useLevel  ref android.R.styleable::GradientDrawableGradient_angle  ref android.R.styleable::GradientDrawableGradient_type  ref android.R.styleable::GradientDrawableGradient_centerX  ref android.R.styleable::GradientDrawableGradient_centerY  ref android.R.styleable::GradientDrawableGradient_gradientRadius  ref android.R.styleable::GradientDrawableSolid_color  ref android.R.styleable::GradientDrawableStroke_width  ref android.R.styleable::GradientDrawableStroke_color  ref android.R.styleable::GradientDrawableStroke_dashWidth  ref android.R.styleable::GradientDrawableStroke_dashGap  ref android.R.styleable::GradientDrawablePadding_left  ref android.R.styleable::GradientDrawablePadding_top  ref android.R.styleable::GradientDrawablePadding_right  ref android.R.styleable::GradientDrawablePadding_bottom </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/GradientDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/GradientDrawable", AccessFlags = 33)]
		public partial class GradientDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Shape is a rectangle, possibly with rounded corners </para>        
				/// </summary>
				/// <java-name>
				/// RECTANGLE
				/// </java-name>
				[Dot42.DexImport("RECTANGLE", "I", AccessFlags = 25)]
				public const int RECTANGLE = 0;
				/// <summary>
				/// <para>Shape is an ellipse </para>        
				/// </summary>
				/// <java-name>
				/// OVAL
				/// </java-name>
				[Dot42.DexImport("OVAL", "I", AccessFlags = 25)]
				public const int OVAL = 1;
				/// <summary>
				/// <para>Shape is a line </para>        
				/// </summary>
				/// <java-name>
				/// LINE
				/// </java-name>
				[Dot42.DexImport("LINE", "I", AccessFlags = 25)]
				public const int LINE = 2;
				/// <summary>
				/// <para>Shape is a ring. </para>        
				/// </summary>
				/// <java-name>
				/// RING
				/// </java-name>
				[Dot42.DexImport("RING", "I", AccessFlags = 25)]
				public const int RING = 3;
				/// <summary>
				/// <para>Gradient is linear (default.) </para>        
				/// </summary>
				/// <java-name>
				/// LINEAR_GRADIENT
				/// </java-name>
				[Dot42.DexImport("LINEAR_GRADIENT", "I", AccessFlags = 25)]
				public const int LINEAR_GRADIENT = 0;
				/// <summary>
				/// <para>Gradient is circular. </para>        
				/// </summary>
				/// <java-name>
				/// RADIAL_GRADIENT
				/// </java-name>
				[Dot42.DexImport("RADIAL_GRADIENT", "I", AccessFlags = 25)]
				public const int RADIAL_GRADIENT = 1;
				/// <summary>
				/// <para>Gradient is a sweep. </para>        
				/// </summary>
				/// <java-name>
				/// SWEEP_GRADIENT
				/// </java-name>
				[Dot42.DexImport("SWEEP_GRADIENT", "I", AccessFlags = 25)]
				public const int SWEEP_GRADIENT = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public GradientDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a new gradient drawable given an orientation and an array of colors for the gradient. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/GradientDrawable$Orientation;[I)V", AccessFlags = 1)]
				public GradientDrawable(global::Android.Graphics.Drawable.GradientDrawable.Orientation orientation, int[] colors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specify radii for each of the 4 corners. For each corner, the array contains 2 values, <code>[X_radius, Y_radius]</code>. The corners are ordered top-left, top-right, bottom-right, bottom-left. This property is honored only when the shape is of type RECTANGLE.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setCornerRadii(float[]) </para><simplesectsep></simplesectsep><para>setShape(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setCornerRadii
				/// </java-name>
				[Dot42.DexImport("setCornerRadii", "([F)V", AccessFlags = 1)]
				public virtual void SetCornerRadii(float[] radii) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify radius for the corners of the gradient. If this is &gt; 0, then the drawable is drawn in a round-rectangle, rather than a rectangle. This property is honored only when the shape is of type RECTANGLE.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setCornerRadii(float[]) </para><simplesectsep></simplesectsep><para>setShape(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setCornerRadius
				/// </java-name>
				[Dot42.DexImport("setCornerRadius", "(F)V", AccessFlags = 1)]
				public virtual void SetCornerRadius(float radius) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the stroke width and color for the drawable. If width is zero, then no stroke is drawn.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setStroke(int, int, float, float) </para></para>        
				/// </summary>
				/// <java-name>
				/// setStroke
				/// </java-name>
				[Dot42.DexImport("setStroke", "(II)V", AccessFlags = 1)]
				public virtual void SetStroke(int width, int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the stroke width and color for the drawable. If width is zero, then no stroke is drawn. This method can also be used to dash the stroke.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setStroke(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setStroke
				/// </java-name>
				[Dot42.DexImport("setStroke", "(IIFF)V", AccessFlags = 1)]
				public virtual void SetStroke(int width, int color, float dashWidth, float dashGap) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the size of the shape drawn by this drawable.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setGradientType(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSize
				/// </java-name>
				[Dot42.DexImport("setSize", "(II)V", AccessFlags = 1)]
				public virtual void SetSize(int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the type of shape used to draw the gradient.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para></para>        
				/// </summary>
				/// <java-name>
				/// setShape
				/// </java-name>
				[Dot42.DexImport("setShape", "(I)V", AccessFlags = 1)]
				public virtual void SetShape(int shape) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the type of gradient used by this drawable..</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para></para>        
				/// </summary>
				/// <java-name>
				/// setGradientType
				/// </java-name>
				[Dot42.DexImport("setGradientType", "(I)V", AccessFlags = 1)]
				public virtual void SetGradientType(int gradient) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the center location of the gradient. The radius is honored only when the gradient type is set to RADIAL_GRADIENT or SWEEP_GRADIENT.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setGradientType(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setGradientCenter
				/// </java-name>
				[Dot42.DexImport("setGradientCenter", "(FF)V", AccessFlags = 1)]
				public virtual void SetGradientCenter(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the radius of the gradient. The radius is honored only when the gradient type is set to RADIAL_GRADIENT.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setGradientType(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setGradientRadius
				/// </java-name>
				[Dot42.DexImport("setGradientRadius", "(F)V", AccessFlags = 1)]
				public virtual void SetGradientRadius(float gradientRadius) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether or not this drawable will honor its <code>level</code> property.</para><para><b>Note</b>: changing this property will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing this property.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setLevel(int) </para><simplesectsep></simplesectsep><para>getLevel() </para></para>        
				/// </summary>
				/// <java-name>
				/// setUseLevel
				/// </java-name>
				[Dot42.DexImport("setUseLevel", "(Z)V", AccessFlags = 1)]
				public virtual void SetUseLevel(bool useLevel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the orientation of the gradient defined in this drawable. </para>        
				/// </summary>
				/// <java-name>
				/// getOrientation
				/// </java-name>
				[Dot42.DexImport("getOrientation", "()Landroid/graphics/drawable/GradientDrawable$Orientation;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.GradientDrawable.Orientation GetOrientation() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.GradientDrawable.Orientation);
				}

				/// <summary>
				/// <para>Changes the orientation of the gradient defined in this drawable.</para><para><b>Note</b>: changing orientation will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing the orientation.</para><para><para>mutate() </para></para>        
				/// </summary>
				/// <java-name>
				/// setOrientation
				/// </java-name>
				[Dot42.DexImport("setOrientation", "(Landroid/graphics/drawable/GradientDrawable$Orientation;)V", AccessFlags = 1)]
				public virtual void SetOrientation(global::Android.Graphics.Drawable.GradientDrawable.Orientation orientation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the colors used to draw the gradient. Each color is specified as an ARGB integer and the array must contain at least 2 colors.</para><para><b>Note</b>: changing orientation will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing the orientation.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setColor(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setColors
				/// </java-name>
				[Dot42.DexImport("setColors", "([I)V", AccessFlags = 1)]
				public virtual void SetColors(int[] colors) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes this drawbale to use a single color instead of a gradient.</para><para><b>Note</b>: changing color will affect all instances of a drawable loaded from a resource. It is recommended to invoke mutate() before changing the color.</para><para><para>mutate() </para><simplesectsep></simplesectsep><para>setColors(int[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setColor
				/// </java-name>
				[Dot42.DexImport("setColor", "(I)V", AccessFlags = 1)]
				public virtual void SetColor(int argb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set to true to have the drawable dither its colors when drawn to a device with fewer than 8-bits per color component. This can improve the look on those devices, but can also slow down the drawing a little. </para>        
				/// </summary>
				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool dither) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you vary based on level. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the level change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last level. </para>
				/// </returns>
				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
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

				}

		}

		/// <summary>
		/// <para>A specialized Drawable that fills the Canvas with a specified color. Note that a ColorDrawable ignores the ColorFilter.</para><para>It can be defined in an XML file with the <code>&lt;color&gt;</code> element.</para><para>ref android.R.styleable::ColorDrawable_color </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/ColorDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/ColorDrawable", AccessFlags = 33)]
		public partial class ColorDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new black ColorDrawable. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ColorDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new ColorDrawable with the specified color.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public ColorDrawable(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the drawable's color value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The color to draw. </para>
				/// </returns>
				/// <java-name>
				/// getColor
				/// </java-name>
				[Dot42.DexImport("getColor", "()I", AccessFlags = 1)]
				public virtual int GetColor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the drawable's color value. This action will clobber the results of prior calls to setAlpha(int) on this object, which side-affected the underlying color.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColor
				/// </java-name>
				[Dot42.DexImport("setColor", "(I)V", AccessFlags = 1)]
				public virtual void SetColor(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the alpha value of this drawable's color.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A value between 0 and 255. </para>
				/// </returns>
				/// <java-name>
				/// getAlpha
				/// </java-name>
				[Dot42.DexImport("getAlpha", "()I", AccessFlags = 1)]
				public virtual int GetAlpha() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the color's alpha value.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Setting a color filter on a ColorDrawable has no effect.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Gets the drawable's color value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The color to draw. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns the alpha value of this drawable's color.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A value between 0 and 255. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

		}

		/// <summary>
		/// <para>Interface that drawables suporting animations should implement. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/Animatable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/Animatable", AccessFlags = 1537)]
		public partial interface IAnimatable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Starts the drawable's animation. </para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1025)]
				void Start() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Stops the drawable's animation. </para>        
				/// </summary>
				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1025)]
				void Stop() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Indicates whether the animation is running.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the animation is running, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isRunning
				/// </java-name>
				[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1025)]
				bool IsRunning() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A resizeable bitmap, with stretchable areas that you define. This type of image is defined in a .png file with a special format.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about how to use a NinePatchDrawable, read the  developer guide. For information about creating a NinePatch image file using the draw9patch tool, see the  tool guide.</para><para> </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/NinePatchDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/NinePatchDrawable", AccessFlags = 33)]
		public partial class NinePatchDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create drawable from raw nine-patch data, not dealing with density. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use NinePatchDrawable(Resources, Bitmap, byte[], Rect, String) to ensure that the drawable has correctly set its target density. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V", AccessFlags = 1)]
				public NinePatchDrawable(global::Android.Graphics.Bitmap bitmap, sbyte[] chunk, global::Android.Graphics.Rect padding, string srcName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create drawable from raw nine-patch data, not dealing with density. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use NinePatchDrawable(Resources, Bitmap, byte[], Rect, String) to ensure that the drawable has correctly set its target density. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NinePatchDrawable(global::Android.Graphics.Bitmap bitmap, byte[] chunk, global::Android.Graphics.Rect padding, string srcName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create drawable from raw nine-patch data, setting initial target density based on the display metrics of the resources. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;[BLandroid/graphics/Rect" +
    ";Ljava/lang/String;)V", AccessFlags = 1)]
				public NinePatchDrawable(global::Android.Content.Res.Resources res, global::Android.Graphics.Bitmap bitmap, sbyte[] chunk, global::Android.Graphics.Rect padding, string srcName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create drawable from raw nine-patch data, setting initial target density based on the display metrics of the resources. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;[BLandroid/graphics/Rect" +
    ";Ljava/lang/String;)V", AccessFlags = 1, IgnoreFromJava = true)]
				public NinePatchDrawable(global::Android.Content.Res.Resources res, global::Android.Graphics.Bitmap bitmap, byte[] chunk, global::Android.Graphics.Rect padding, string srcName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create drawable from existing nine-patch, not dealing with density. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use NinePatchDrawable(Resources, NinePatch) to ensure that the drawable has correctly set its target density. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/NinePatch;)V", AccessFlags = 1)]
				public NinePatchDrawable(global::Android.Graphics.NinePatch patch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create drawable from existing nine-patch, setting initial target density based on the display metrics of the resources. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/graphics/NinePatch;)V", AccessFlags = 1)]
				public NinePatchDrawable(global::Android.Content.Res.Resources res, global::Android.Graphics.NinePatch patch) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the density scale at which this drawable will be rendered. This method assumes the drawable will be rendered at the same density as the specified canvas.</para><para><para>android.graphics.Bitmap::setDensity(int) </para><simplesectsep></simplesectsep><para>android.graphics.Bitmap::getDensity() </para></para>        
				/// </summary>
				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the density scale at which this drawable will be rendered. This method assumes the drawable will be rendered at the same density as the specified canvas.</para><para><para>android.graphics.Bitmap::setDensity(int) </para><simplesectsep></simplesectsep><para>android.graphics.Bitmap::getDensity() </para></para>        
				/// </summary>
				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(global::Android.Util.DisplayMetrics canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the density scale at which this drawable will be rendered. This method assumes the drawable will be rendered at the same density as the specified canvas.</para><para><para>android.graphics.Bitmap::setDensity(int) </para><simplesectsep></simplesectsep><para>android.graphics.Bitmap::getDensity() </para></para>        
				/// </summary>
				/// <java-name>
				/// setTargetDensity
				/// </java-name>
				[Dot42.DexImport("setTargetDensity", "(I)V", AccessFlags = 1)]
				public virtual void SetTargetDensity(int canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set to true to have the drawable dither its colors when drawn to a device with fewer than 8-bits per color component. This can improve the look on those devices, but can also slow down the drawing a little. </para>        
				/// </summary>
				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool dither) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set to true to have the drawable filter its bitmap when scaled or rotated (for drawables that use bitmaps). If the drawable does not use bitmaps, this call is ignored. This can improve the look when scaled or rotated, but also slows down the drawing. </para>        
				/// </summary>
				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 1)]
				public override void SetFilterBitmap(bool filter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Retrieves the width of the source .png file (before resizing). </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Retrieves the height of the source .png file (before resizing). </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum width suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its width. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum width suggested by this Drawable. If this Drawable doesn't have a suggested minimum width, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
				public override int GetMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum height suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its height. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum height suggested by this Drawable. If this Drawable doesn't have a suggested minimum height, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
				public override int GetMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a graphics.PixelFormat value of OPAQUE or TRANSLUCENT. </para>        
				/// </summary>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a Region representing the part of the Drawable that is completely transparent. This can be used to perform drawing operations, identifying which parts of the target will not change when rendering the Drawable. The default implementation returns null, indicating no transparent region; subclasses can optionally override this to return an actual Region if they want to supply this optimization information, but it is not required that they do so.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns null if the Drawables has no transparent region to report, else a Region holding the parts of the Drawable's bounds that are transparent. </para>
				/// </returns>
				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				[Dot42.DexImport("getTransparentRegion", "()Landroid/graphics/Region;", AccessFlags = 1)]
				public override global::Android.Graphics.Region GetTransparentRegion() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Region);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
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

				/// <summary>
				/// <para>Retrieves the width of the source .png file (before resizing). </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Retrieves the height of the source .png file (before resizing). </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <summary>
				/// <para>Returns the minimum width suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its width. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum width suggested by this Drawable. If this Drawable doesn't have a suggested minimum width, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				public int MinimumWidth
				{
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetMinimumWidth(); }
				}

				/// <summary>
				/// <para>Returns the minimum height suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its height. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum height suggested by this Drawable. If this Drawable doesn't have a suggested minimum height, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				public int MinimumHeight
				{
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetMinimumHeight(); }
				}

				/// <summary>
				/// <para>Returns a graphics.PixelFormat value of OPAQUE or TRANSLUCENT. </para>        
				/// </summary>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Returns a Region representing the part of the Drawable that is completely transparent. This can be used to perform drawing operations, identifying which parts of the target will not change when rendering the Drawable. The default implementation returns null, indicating no transparent region; subclasses can optionally override this to return an actual Region if they want to supply this optimization information, but it is not required that they do so.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns null if the Drawables has no transparent region to report, else a Region holding the parts of the Drawable's bounds that are transparent. </para>
				/// </returns>
				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				public global::Android.Graphics.Region TransparentRegion
				{
				[Dot42.DexImport("getTransparentRegion", "()Landroid/graphics/Region;", AccessFlags = 1)]
						get{ return GetTransparentRegion(); }
				}

		}

		/// <summary>
		/// <para>A Drawable object that draws primitive shapes. A ShapeDrawable takes a android.graphics.drawable.shapes.Shape object and manages its presence on the screen. If no Shape is given, then the ShapeDrawable will default to a android.graphics.drawable.shapes.RectShape.</para><para>This object can be defined in an XML file with the <code>&lt;shape&gt;</code> element.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about how to use ShapeDrawable, read the  document. For more information about defining a ShapeDrawable in XML, read the  document.</para><para></para><para>ref android.R.styleable::ShapeDrawablePadding_left  ref android.R.styleable::ShapeDrawablePadding_top  ref android.R.styleable::ShapeDrawablePadding_right  ref android.R.styleable::ShapeDrawablePadding_bottom  ref android.R.styleable::ShapeDrawable_color  ref android.R.styleable::ShapeDrawable_width  ref android.R.styleable::ShapeDrawable_height </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/ShapeDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/ShapeDrawable", AccessFlags = 33)]
		public partial class ShapeDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>ShapeDrawable constructor. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ShapeDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a ShapeDrawable with a specified Shape.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/shapes/Shape;)V", AccessFlags = 1)]
				public ShapeDrawable(global::Android.Graphics.Drawable.Shapes.Shape s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the Shape of this ShapeDrawable. </para>        
				/// </summary>
				/// <java-name>
				/// getShape
				/// </java-name>
				[Dot42.DexImport("getShape", "()Landroid/graphics/drawable/shapes/Shape;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Shapes.Shape GetShape() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Shapes.Shape);
				}

				/// <summary>
				/// <para>Sets the Shape of this ShapeDrawable. </para>        
				/// </summary>
				/// <java-name>
				/// setShape
				/// </java-name>
				[Dot42.DexImport("setShape", "(Landroid/graphics/drawable/shapes/Shape;)V", AccessFlags = 1)]
				public virtual void SetShape(global::Android.Graphics.Drawable.Shapes.Shape s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a ShaderFactory to which requests for a android.graphics.Shader object will be made.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setShaderFactory
				/// </java-name>
				[Dot42.DexImport("setShaderFactory", "(Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;)V", AccessFlags = 1)]
				public virtual void SetShaderFactory(global::Android.Graphics.Drawable.ShapeDrawable.ShaderFactory fact) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the ShaderFactory used by this ShapeDrawable for requesting a android.graphics.Shader. </para>        
				/// </summary>
				/// <java-name>
				/// getShaderFactory
				/// </java-name>
				[Dot42.DexImport("getShaderFactory", "()Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.ShapeDrawable.ShaderFactory GetShaderFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.ShapeDrawable.ShaderFactory);
				}

				/// <summary>
				/// <para>Returns the Paint used to draw the shape. </para>        
				/// </summary>
				/// <java-name>
				/// getPaint
				/// </java-name>
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Paint GetPaint() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Paint);
				}

				/// <summary>
				/// <para>Sets padding for the shape.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public virtual void SetPadding(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets padding for this shape, defined by a Rect object. Define the padding in the Rect object as: left, top, right, bottom. </para>        
				/// </summary>
				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the intrinsic (default) width for this shape.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("setIntrinsicWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetIntrinsicWidth(int width) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the intrinsic (default) height for this shape.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("setIntrinsicHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetIntrinsicHeight(int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called from the drawable's draw() method after the canvas has been set to draw the shape at (0,0). Subclasses can override for special effects such as multiple layers, stroking, etc. </para>        
				/// </summary>
				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/drawable/shapes/Shape;Landroid/graphics/Canvas;Landroid/graphi" +
    "cs/Paint;)V", AccessFlags = 4)]
				protected internal virtual void OnDraw(global::Android.Graphics.Drawable.Shapes.Shape shape, global::Android.Graphics.Canvas canvas, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Set the alpha level for this drawable [0..255]. Note that this drawable also has a color in its paint, which has an alpha as well. These two values are automatically combined during drawing. Thus if the color's alpha is 75% (i.e. 192) and the drawable's alpha is 50% (i.e. 128), then the combined alpha that will be used during drawing will be 37.5% (i.e. 96). </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Set to true to have the drawable dither its colors when drawn to a device with fewer than 8-bits per color component. This can improve the look on those devices, but can also slow down the drawing a little. </para>        
				/// </summary>
				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool dither) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Subclasses override this to parse custom subelements. If you handle it, return true, else return <b>super.inflateTag(...)</b>. </para>        
				/// </summary>
				/// <java-name>
				/// inflateTag
				/// </java-name>
				[Dot42.DexImport("inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;L" +
    "android/util/AttributeSet;)Z", AccessFlags = 4)]
				protected internal virtual bool InflateTag(string name, global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Returns the Shape of this ShapeDrawable. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Returns the Paint used to draw the shape. </para>        
				/// </summary>
				/// <java-name>
				/// getPaint
				/// </java-name>
				public global::Android.Graphics.Paint Paint
				{
				[Dot42.DexImport("getPaint", "()Landroid/graphics/Paint;", AccessFlags = 1)]
						get{ return GetPaint(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Base class defines a factory object that is called each time the drawable is resized (has a new width or height). Its resize() method returns a corresponding shader, or null. Implement this class if you'd like your ShapeDrawable to use a special android.graphics.Shader, such as a android.graphics.LinearGradient. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>Returns the Shader to be drawn when a Drawable is drawn. The dimensions of the Drawable are passed because they may be needed to adjust how the Shader is configured for drawing. This is called by ShapeDrawable.setShape().</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>the Shader to be drawn </para>
						/// </returns>
						/// <java-name>
						/// resize
						/// </java-name>
						[Dot42.DexImport("resize", "(II)Landroid/graphics/Shader;", AccessFlags = 1025)]
						public abstract global::Android.Graphics.Shader Resize(int width, int height) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>Drawable subclass that wraps a Picture, allowing the picture to be used whereever a Drawable is supported. </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/PictureDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/PictureDrawable", AccessFlags = 33)]
		public partial class PictureDrawable : global::Android.Graphics.Drawable.Drawable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a new drawable referencing the specified picture. The picture may be null.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
				public PictureDrawable(global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the picture associated with the drawable. May be null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the picture associated with the drawable, or null. </para>
				/// </returns>
				/// <java-name>
				/// getPicture
				/// </java-name>
				[Dot42.DexImport("getPicture", "()Landroid/graphics/Picture;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Picture GetPicture() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Picture);
				}

				/// <summary>
				/// <para>Associate a picture with this drawable. The picture may be null.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPicture
				/// </java-name>
				[Dot42.DexImport("setPicture", "(Landroid/graphics/Picture;)V", AccessFlags = 1)]
				public virtual void SetPicture(global::Android.Graphics.Picture picture) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Set to true to have the drawable filter its bitmap when scaled or rotated (for drawables that use bitmaps). If the drawable does not use bitmaps, this call is ignored. This can improve the look when scaled or rotated, but also slows down the drawing. </para>        
				/// </summary>
				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 1)]
				public override void SetFilterBitmap(bool filter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set to true to have the drawable dither its colors when drawn to a device with fewer than 8-bits per color component. This can improve the look on those devices, but can also slow down the drawing a little. </para>        
				/// </summary>
				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool dither) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PictureDrawable() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return the picture associated with the drawable. May be null.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the picture associated with the drawable, or null. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

		}

		/// <summary>
		/// <para>An extension of LayerDrawables that is intended to cross-fade between the first and second layer. To start the transition, call startTransition(int). To display just the first layer, call resetTransition(). </para><para>It can be defined in an XML file with the <code>&lt;transition&gt;</code> element. Each Drawable in the transition is defined in a nested <code>&lt;item&gt;</code>. For more information, see the guide to .</para><para>ref android.R.styleable::LayerDrawableItem_left  ref android.R.styleable::LayerDrawableItem_top  ref android.R.styleable::LayerDrawableItem_right  ref android.R.styleable::LayerDrawableItem_bottom  ref android.R.styleable::LayerDrawableItem_drawable  ref android.R.styleable::LayerDrawableItem_id </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/TransitionDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/TransitionDrawable", AccessFlags = 33)]
		public partial class TransitionDrawable : global::Android.Graphics.Drawable.LayerDrawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new transition drawable with the specified list of layers. At least 2 layers are required for this drawable to work properly. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public TransitionDrawable(global::Android.Graphics.Drawable.Drawable[] layers) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Begin the second layer on top of the first layer.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startTransition
				/// </java-name>
				[Dot42.DexImport("startTransition", "(I)V", AccessFlags = 1)]
				public virtual void StartTransition(int durationMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Show only the first layer. </para>        
				/// </summary>
				/// <java-name>
				/// resetTransition
				/// </java-name>
				[Dot42.DexImport("resetTransition", "()V", AccessFlags = 1)]
				public virtual void ResetTransition() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reverses the transition, picking up where the transition currently is. If the transition is not currently running, this will start the transition with the specified duration. If the transition is already running, the last known duration will be used.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// reverseTransition
				/// </java-name>
				[Dot42.DexImport("reverseTransition", "(I)V", AccessFlags = 1)]
				public virtual void ReverseTransition(int duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Enables or disables the cross fade of the drawables. When cross fade is disabled, the first drawable is always drawn opaque. With cross fade enabled, the first drawable is drawn with the opposite alpha of the second drawable. Cross fade is disabled by default.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCrossFadeEnabled
				/// </java-name>
				[Dot42.DexImport("setCrossFadeEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetCrossFadeEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether the cross fade is enabled for this transition.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if cross fading is enabled, false otherwise. </para>
				/// </returns>
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
				public override void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable who) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/graphics/drawable/Drawable$Callback", "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1025)]
				public override void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what, long when) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/graphics/drawable/Drawable$Callback", "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1025)]
				public override void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

		}

		/// <summary>
		/// <para>A Drawable that changes the size of another Drawable based on its current level value. You can control how much the child Drawable changes in width and height based on the level, as well as a gravity to control where it is placed in its overall container. Most often used to implement things like progress bars.</para><para>It can be defined in an XML file with the <code>&lt;scale&gt;</code> element. For more information, see the guide to .</para><para>ref android.R.styleable::ScaleDrawable_scaleWidth  ref android.R.styleable::ScaleDrawable_scaleHeight  ref android.R.styleable::ScaleDrawable_scaleGravity  ref android.R.styleable::ScaleDrawable_drawable </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/ScaleDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/ScaleDrawable", AccessFlags = 33)]
		public partial class ScaleDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/graphics/drawable/Drawable;IFF)V", AccessFlags = 1)]
				public ScaleDrawable(global::Android.Graphics.Drawable.Drawable drawable, int gravity, float scaleWidth, float scaleHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the drawable scaled by this ScaleDrawable. </para>        
				/// </summary>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to schedule the next frame of its animation. An implementation can generally simply call android.os.Handler#postAtTime(Runnable, Object, long) with the parameters <b>(what, who, when)</b> to perform the scheduling.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to unschedule an action previously scheduled with scheduleDrawable. An implementation can generally simply call android.os.Handler#removeCallbacks(Runnable, Object) with the parameters <b>(what, who)</b> to unschedule the drawable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set whether this Drawable is visible. This generally does not impact the Drawable's behavior, but is a hint that can be used by some Drawables, for example, to decide whether run animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Returns true if the new visibility is different than its previous state. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool visible, bool restart) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether this view will change its appearance based on state. Clients can use this to determine whether it is necessary to calculate their state and call setState.</para><para><para>#setState(int[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this view changes its appearance based on state, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the state change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last state. </para>
				/// </returns>
				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] state) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you vary based on level. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the level change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last level. </para>
				/// </returns>
				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns the drawable scaled by this ScaleDrawable. </para>        
				/// </summary>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Drawable
				{
				[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetDrawable(); }
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <summary>
		/// <para>A Drawable is a general abstraction for "something that can be drawn." Most often you will deal with Drawable as the type of resource retrieved for drawing things to the screen; the Drawable class provides a generic API for dealing with an underlying visual resource that may take a variety of forms. Unlike a android.view.View, a Drawable does not have any facility to receive events or otherwise interact with the user.</para><para>In addition to simple drawing, Drawable provides a number of generic mechanisms for its client to interact with what is being drawn:</para><para><ul><li><para>The setBounds method <b>must</b> be called to tell the Drawable where it is drawn and how large it should be. All Drawables should respect the requested size, often simply by scaling their imagery. A client can find the preferred size for some Drawables with the getIntrinsicHeight and getIntrinsicWidth methods.</para><para></para></li><li><para>The getPadding method can return from some Drawables information about how to frame content that is placed inside of them. For example, a Drawable that is intended to be the frame for a button widget would need to return padding that correctly places the label inside of itself.</para><para></para></li><li><para>The setState method allows the client to tell the Drawable in which state it is to be drawn, such as "focused", "selected", etc. Some drawables may modify their imagery based on the selected state.</para><para></para></li><li><para>The setLevel method allows the client to supply a single continuous controller that can modify the Drawable is displayed, such as a battery level or progress level. Some drawables may modify their imagery based on the current level.</para><para></para></li><li><para>A Drawable can perform animations by calling back to its client through the Callback interface. All clients should support this interface (via setCallback) so that animations will work. A simple way to do this is through the system facilities such as android.view.View#setBackgroundDrawable(Drawable) and android.widget.ImageView. </para></li></ul></para><para>Though usually not visible to the application, Drawables may take a variety of forms:</para><para><ul><li><para><b>Bitmap</b>: the simplest Drawable, a PNG or JPEG image. </para></li><li><para><b>Nine Patch</b>: an extension to the PNG format allows it to specify information about how to stretch it and place things inside of it. </para></li><li><para><b>Shape</b>: contains simple drawing commands instead of a raw bitmap, allowing it to resize better in some cases. </para></li><li><para><b>Layers</b>: a compound drawable, which draws multiple underlying drawables on top of each other. </para></li><li><para><b>States</b>: a compound drawable that selects one of a set of drawables based on its state. </para></li><li><para><b>Levels</b>: a compound drawable that selects one of a set of drawables based on its level. </para></li><li><para><b>Scale</b>: a compound drawable with a single child drawable, whose overall size is modified based on the current level. </para></li></ul></para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about how to use drawables, read the  developer guide. For information and examples of creating drawable resources (XML or bitmap files that can be loaded in code), read the  document.</para><para> </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1025)]
				public abstract void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specify a bounding rectangle for the Drawable. This is where the drawable will draw when its draw() method is called. </para>        
				/// </summary>
				/// <java-name>
				/// setBounds
				/// </java-name>
				[Dot42.DexImport("setBounds", "(IIII)V", AccessFlags = 1)]
				public virtual void SetBounds(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify a bounding rectangle for the Drawable. This is where the drawable will draw when its draw() method is called. </para>        
				/// </summary>
				/// <java-name>
				/// setBounds
				/// </java-name>
				[Dot42.DexImport("setBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetBounds(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a copy of the drawable's bounds in the specified Rect (allocated by the caller). The bounds specify where this will draw when its draw() method is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// copyBounds
				/// </java-name>
				[Dot42.DexImport("copyBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 17)]
				public void CopyBounds(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a copy of the drawable's bounds in a new Rect. This returns the same values as getBounds(), but the returned object is guaranteed to not be changed later by the drawable (i.e. it retains no reference to this rect). If the caller already has a Rect allocated, call copyBounds(rect).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A copy of the drawable's bounds </para>
				/// </returns>
				/// <java-name>
				/// copyBounds
				/// </java-name>
				[Dot42.DexImport("copyBounds", "()Landroid/graphics/Rect;", AccessFlags = 17)]
				public global::Android.Graphics.Rect CopyBounds() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <summary>
				/// <para>Return the drawable's bounds Rect. Note: for efficiency, the returned object may be the same object stored in the drawable (though this is not guaranteed), so if a persistent copy of the bounds is needed, call copyBounds(rect) instead. You should also not change the object returned by this method as it may be the same object stored in the drawable.</para><para><para>copyBounds() </para><simplesectsep></simplesectsep><para>copyBounds(android.graphics.Rect) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The bounds of the drawable (which may change later, so caller beware). DO NOT ALTER the returned object as it may change the stored bounds of this drawable.</para>
				/// </returns>
				/// <java-name>
				/// getBounds
				/// </java-name>
				[Dot42.DexImport("getBounds", "()Landroid/graphics/Rect;", AccessFlags = 17)]
				public global::Android.Graphics.Rect GetBounds() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <summary>
				/// <para>Set a mask of the configuration parameters for which this drawable may change, requiring that it be re-created.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <java-name>
				/// setChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("setChangingConfigurations", "(I)V", AccessFlags = 1)]
				public virtual void SetChangingConfigurations(int configs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public virtual int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Set to true to have the drawable dither its colors when drawn to a device with fewer than 8-bits per color component. This can improve the look on those devices, but can also slow down the drawing a little. </para>        
				/// </summary>
				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public virtual void SetDither(bool dither) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set to true to have the drawable filter its bitmap when scaled or rotated (for drawables that use bitmaps). If the drawable does not use bitmaps, this call is ignored. This can improve the look when scaled or rotated, but also slows down the drawing. </para>        
				/// </summary>
				/// <java-name>
				/// setFilterBitmap
				/// </java-name>
				[Dot42.DexImport("setFilterBitmap", "(Z)V", AccessFlags = 1)]
				public virtual void SetFilterBitmap(bool filter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Bind a Callback object to this Drawable. Required for clients that want to support animated drawables.</para><para><para>getCallback() </para></para>        
				/// </summary>
				/// <java-name>
				/// setCallback
				/// </java-name>
				[Dot42.DexImport("setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V", AccessFlags = 17)]
				public void SetCallback(global::Android.Graphics.Drawable.Drawable.ICallback cb) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the current Callback implementation attached to this Drawable.</para><para><para>setCallback(android.graphics.drawable.Drawable.Callback) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Callback instance or null if no callback was set.</para>
				/// </returns>
				/// <java-name>
				/// getCallback
				/// </java-name>
				[Dot42.DexImport("getCallback", "()Landroid/graphics/drawable/Drawable$Callback;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable.ICallback GetCallback() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ICallback);
				}

				/// <summary>
				/// <para>Use the current Callback implementation to have this Drawable redrawn. Does nothing if there is no Callback attached to the Drawable.</para><para><para>Callback::invalidateDrawable </para><simplesectsep></simplesectsep><para>getCallback() </para><simplesectsep></simplesectsep><para>setCallback(android.graphics.drawable.Drawable.Callback) </para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateSelf
				/// </java-name>
				[Dot42.DexImport("invalidateSelf", "()V", AccessFlags = 1)]
				public virtual void InvalidateSelf() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Use the current Callback implementation to have this Drawable scheduled. Does nothing if there is no Callback attached to the Drawable.</para><para><para>Callback::scheduleDrawable </para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleSelf
				/// </java-name>
				[Dot42.DexImport("scheduleSelf", "(Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleSelf(global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Use the current Callback implementation to have this Drawable unscheduled. Does nothing if there is no Callback attached to the Drawable.</para><para><para>Callback::unscheduleDrawable </para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleSelf
				/// </java-name>
				[Dot42.DexImport("unscheduleSelf", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleSelf(global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1025)]
				public abstract void SetAlpha(int alpha) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1025)]
				public abstract void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Specify a color and porterduff mode to be the colorfilter for this drawable. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V", AccessFlags = 1)]
				public virtual void SetColorFilter(int color, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearColorFilter
				/// </java-name>
				[Dot42.DexImport("clearColorFilter", "()V", AccessFlags = 1)]
				public virtual void ClearColorFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether this view will change its appearance based on state. Clients can use this to determine whether it is necessary to calculate their state and call setState.</para><para><para>#setState(int[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this view changes its appearance based on state, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public virtual bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specify a set of states for the drawable. These are use-case specific, so see the relevant documentation. As an example, the background for widgets like Button understand the following states: [android.R.attr#state_focused, android.R.attr#state_pressed].</para><para>If the new state you are supplying causes the appearance of the Drawable to change, then it is responsible for calling invalidateSelf in order to have itself redrawn, <b>and</b> true will be returned from this function.</para><para>Note: The Drawable holds a reference on to <b>stateSet</b> until a new state array is given to it, so you must not modify this array during that time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if this change in state has caused the appearance of the Drawable to change (hence requiring an invalidate), otherwise returns false. </para>
				/// </returns>
				/// <java-name>
				/// setState
				/// </java-name>
				[Dot42.DexImport("setState", "([I)Z", AccessFlags = 1)]
				public virtual bool SetState(int[] stateSet) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Describes the current state, as a union of primitve states, such as android.R.attr#state_focused, android.R.attr#state_selected, etc. Some drawables may modify their imagery based on the selected state. </para>        
				/// </summary>
				/// <returns>
				/// <para>An array of resource Ids describing the current state. </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				[Dot42.DexImport("getState", "()[I", AccessFlags = 1)]
				public virtual int[] GetState() /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				/// <para>If this Drawable does transition animations between states, ask that it immediately jump to the current state and skip any active animations. </para>        
				/// </summary>
				/// <java-name>
				/// jumpToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpToCurrentState", "()V", AccessFlags = 1)]
				public virtual void JumpToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current drawable that will be used by this drawable. For simple drawables, this is just the drawable itself. For drawables that change state like StateListDrawable and LevelListDrawable this will be the child drawable currently in use. </para>
				/// </returns>
				/// <java-name>
				/// getCurrent
				/// </java-name>
				[Dot42.DexImport("getCurrent", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetCurrent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Specify the level for the drawable. This allows a drawable to vary its imagery based on a continuous controller, for example to show progress or volume level.</para><para>If the new level you are supplying causes the appearance of the Drawable to change, then it is responsible for calling invalidateSelf in order to have itself redrawn, <b>and</b> true will be returned from this function.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if this change in level has caused the appearance of the Drawable to change (hence requiring an invalidate), otherwise returns false. </para>
				/// </returns>
				/// <java-name>
				/// setLevel
				/// </java-name>
				[Dot42.DexImport("setLevel", "(I)Z", AccessFlags = 17)]
				public bool SetLevel(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Retrieve the current level.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int Current level, from 0 (minimum) to 10000 (maximum). </para>
				/// </returns>
				/// <java-name>
				/// getLevel
				/// </java-name>
				[Dot42.DexImport("getLevel", "()I", AccessFlags = 17)]
				public int GetLevel() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Set whether this Drawable is visible. This generally does not impact the Drawable's behavior, but is a hint that can be used by some Drawables, for example, to decide whether run animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Returns true if the new visibility is different than its previous state. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public virtual bool SetVisible(bool visible, bool restart) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1025)]
				public abstract int GetOpacity() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Return the appropriate opacity value for two source opacities. If either is UNKNOWN, that is returned; else, if either is TRANSLUCENT, that is returned; else, if either is TRANSPARENT, that is returned; else, OPAQUE is returned.</para><para>This is to help in implementing getOpacity.</para><para><para>getOpacity </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The combined opacity value.</para>
				/// </returns>
				/// <java-name>
				/// resolveOpacity
				/// </java-name>
				[Dot42.DexImport("resolveOpacity", "(II)I", AccessFlags = 9)]
				public static int ResolveOpacity(int op1, int op2) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a Region representing the part of the Drawable that is completely transparent. This can be used to perform drawing operations, identifying which parts of the target will not change when rendering the Drawable. The default implementation returns null, indicating no transparent region; subclasses can optionally override this to return an actual Region if they want to supply this optimization information, but it is not required that they do so.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns null if the Drawables has no transparent region to report, else a Region holding the parts of the Drawable's bounds that are transparent. </para>
				/// </returns>
				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				[Dot42.DexImport("getTransparentRegion", "()Landroid/graphics/Region;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Region GetTransparentRegion() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Region);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the state change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last state. </para>
				/// </returns>
				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal virtual bool OnStateChange(int[] state) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you vary based on level. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the level change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last level. </para>
				/// </returns>
				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool OnLevelChange(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal virtual void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public virtual int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public virtual int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum width suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its width. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum width suggested by this Drawable. If this Drawable doesn't have a suggested minimum width, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
				public virtual int GetMinimumWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the minimum height suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its height. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum height suggested by this Drawable. If this Drawable doesn't have a suggested minimum height, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
				public virtual int GetMinimumHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Create a drawable from an inputstream </para>        
				/// </summary>
				/// <java-name>
				/// createFromStream
				/// </java-name>
				[Dot42.DexImport("createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromStream(global::Java.Io.InputStream @is, string srcName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Create a drawable from an inputstream, using the given resources and value to determine density information. </para>        
				/// </summary>
				/// <java-name>
				/// createFromResourceStream
				/// </java-name>
				[Dot42.DexImport("createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Lja" +
    "va/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromResourceStream(global::Android.Content.Res.Resources res, global::Android.Util.TypedValue value, global::Java.Io.InputStream @is, string srcName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Create a drawable from an inputstream, using the given resources and value to determine density information. </para>        
				/// </summary>
				/// <java-name>
				/// createFromResourceStream
				/// </java-name>
				[Dot42.DexImport("createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Lja" +
    "va/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawab" +
    "le/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromResourceStream(global::Android.Content.Res.Resources res, global::Android.Util.TypedValue value, global::Java.Io.InputStream @is, string srcName, global::Android.Graphics.BitmapFactory.Options opts) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Create a drawable from an XML document. For more information on how to create resources in XML, see . </para>        
				/// </summary>
				/// <java-name>
				/// createFromXml
				/// </java-name>
				[Dot42.DexImport("createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/" +
    "drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromXml(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Create from inside an XML document. Called on a parser positioned at a tag in an XML document, tries to create a Drawable from that tag. Returns null if the tag is not a valid drawable. </para>        
				/// </summary>
				/// <java-name>
				/// createFromXmlInner
				/// </java-name>
				[Dot42.DexImport("createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)Landroid/graphics/drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromXmlInner(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Create a drawable from file path name. </para>        
				/// </summary>
				/// <java-name>
				/// createFromPath
				/// </java-name>
				[Dot42.DexImport("createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", AccessFlags = 9)]
				public static global::Android.Graphics.Drawable.Drawable CreateFromPath(string pathName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public virtual void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Return the drawable's bounds Rect. Note: for efficiency, the returned object may be the same object stored in the drawable (though this is not guaranteed), so if a persistent copy of the bounds is needed, call copyBounds(rect) instead. You should also not change the object returned by this method as it may be the same object stored in the drawable.</para><para><para>copyBounds() </para><simplesectsep></simplesectsep><para>copyBounds(android.graphics.Rect) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The bounds of the drawable (which may change later, so caller beware). DO NOT ALTER the returned object as it may change the stored bounds of this drawable.</para>
				/// </returns>
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

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
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

				/// <summary>
				/// <para>Return the current Callback implementation attached to this Drawable.</para><para><para>setCallback(android.graphics.drawable.Drawable.Callback) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Callback instance or null if no callback was set.</para>
				/// </returns>
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

				/// <summary>
				/// <para>Describes the current state, as a union of primitve states, such as android.R.attr#state_focused, android.R.attr#state_selected, etc. Some drawables may modify their imagery based on the selected state. </para>        
				/// </summary>
				/// <returns>
				/// <para>An array of resource Ids describing the current state. </para>
				/// </returns>
				/// <java-name>
				/// getState
				/// </java-name>
				public int[] State
				{
				[Dot42.DexImport("getState", "()[I", AccessFlags = 1)]
						get{ return GetState(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current drawable that will be used by this drawable. For simple drawables, this is just the drawable itself. For drawables that change state like StateListDrawable and LevelListDrawable this will be the child drawable currently in use. </para>
				/// </returns>
				/// <java-name>
				/// getCurrent
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Current
				{
				[Dot42.DexImport("getCurrent", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetCurrent(); }
				}

				/// <summary>
				/// <para>Retrieve the current level.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>int Current level, from 0 (minimum) to 10000 (maximum). </para>
				/// </returns>
				/// <java-name>
				/// getLevel
				/// </java-name>
				public int Level
				{
				[Dot42.DexImport("getLevel", "()I", AccessFlags = 17)]
						get{ return GetLevel(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1025)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Returns a Region representing the part of the Drawable that is completely transparent. This can be used to perform drawing operations, identifying which parts of the target will not change when rendering the Drawable. The default implementation returns null, indicating no transparent region; subclasses can optionally override this to return an actual Region if they want to supply this optimization information, but it is not required that they do so.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns null if the Drawables has no transparent region to report, else a Region holding the parts of the Drawable's bounds that are transparent. </para>
				/// </returns>
				/// <java-name>
				/// getTransparentRegion
				/// </java-name>
				public global::Android.Graphics.Region TransparentRegion
				{
				[Dot42.DexImport("getTransparentRegion", "()Landroid/graphics/Region;", AccessFlags = 1)]
						get{ return GetTransparentRegion(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

				/// <summary>
				/// <para>Returns the minimum width suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its width. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum width suggested by this Drawable. If this Drawable doesn't have a suggested minimum width, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumWidth
				/// </java-name>
				public int MinimumWidth
				{
				[Dot42.DexImport("getMinimumWidth", "()I", AccessFlags = 1)]
						get{ return GetMinimumWidth(); }
				}

				/// <summary>
				/// <para>Returns the minimum height suggested by this Drawable. If a View uses this Drawable as a background, it is suggested that the View use at least this value for its height. (There will be some scenarios where this will not be possible.) This value should INCLUDE any padding.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The minimum height suggested by this Drawable. If this Drawable doesn't have a suggested minimum height, 0 is returned. </para>
				/// </returns>
				/// <java-name>
				/// getMinimumHeight
				/// </java-name>
				public int MinimumHeight
				{
				[Dot42.DexImport("getMinimumHeight", "()I", AccessFlags = 1)]
						get{ return GetMinimumHeight(); }
				}

				/// <summary>
				/// <para>This abstract class is used by Drawables to store shared constant state and data between Drawables. BitmapDrawables created from the same resource will for instance share a unique bitmap stored in their ConstantState.</para><para>newDrawable(Resources) can be used as a factory to create new Drawable instances from this ConstantState. </para><para>Use Drawable#getConstantState() to retrieve the ConstantState of a Drawable. Calling Drawable#mutate() on a Drawable should typically create a new ConstantState for that Drawable. </para>    
				/// </summary>
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

						/// <summary>
						/// <para>Create a new drawable without supplying resources the caller is running in. Note that using this means the density-dependent drawables (like bitmaps) will not be able to update their target density correctly. One should use newDrawable(Resources) instead to provide a resource. </para>        
						/// </summary>
						/// <java-name>
						/// newDrawable
						/// </java-name>
						[Dot42.DexImport("newDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						public abstract global::Android.Graphics.Drawable.Drawable NewDrawable() /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Create a new Drawable instance from its constant state. This must be implemented for drawables that change based on the target density of their caller (that is depending on whether it is in compatibility mode). </para>        
						/// </summary>
						/// <java-name>
						/// newDrawable
						/// </java-name>
						[Dot42.DexImport("newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public virtual global::Android.Graphics.Drawable.Drawable NewDrawable(global::Android.Content.Res.Resources res) /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Drawable.Drawable);
						}

						/// <summary>
						/// <para>Return a bit mask of configuration changes that will impact this drawable (and thus require completely reloading it). </para>        
						/// </summary>
						/// <java-name>
						/// getChangingConfigurations
						/// </java-name>
						[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1025)]
						public abstract int GetChangingConfigurations() /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Return a bit mask of configuration changes that will impact this drawable (and thus require completely reloading it). </para>        
						/// </summary>
						/// <java-name>
						/// getChangingConfigurations
						/// </java-name>
						public int ChangingConfigurations
						{
						[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1025)]
								get{ return GetChangingConfigurations(); }
						}

				}

				/// <summary>
				/// <para>Implement this interface if you want to create an animated drawable that extends Drawable. Upon retrieving a drawable, use Drawable#setCallback(android.graphics.drawable.Drawable.Callback) to supply your implementation of the interface to the drawable; it uses this interface to schedule and execute animation changes. </para>    
				/// </summary>
				/// <java-name>
				/// android/graphics/drawable/Drawable$Callback
				/// </java-name>
				[Dot42.DexImport("android/graphics/drawable/Drawable$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para><para></para>        
						/// </summary>
						/// <java-name>
						/// invalidateDrawable
						/// </java-name>
						[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
						void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable who) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>A Drawable can call this to schedule the next frame of its animation. An implementation can generally simply call android.os.Handler#postAtTime(Runnable, Object, long) with the parameters <b>(what, who, when)</b> to perform the scheduling.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// scheduleDrawable
						/// </java-name>
						[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1025)]
						void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>A Drawable can call this to unschedule an action previously scheduled with scheduleDrawable. An implementation can generally simply call android.os.Handler#removeCallbacks(Runnable, Object) with the parameters <b>(what, who)</b> to unschedule the drawable.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// unscheduleDrawable
						/// </java-name>
						[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1025)]
						void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>A Drawable that manages an array of other Drawables. These are drawn in array order, so the element with the largest index will be drawn on top. </para><para>It can be defined in an XML file with the <code>&lt;layer-list&gt;</code> element. Each Drawable in the layer is defined in a nested <code>&lt;item&gt;</code>. For more information, see the guide to .</para><para>ref android.R.styleable::LayerDrawableItem_left  ref android.R.styleable::LayerDrawableItem_top  ref android.R.styleable::LayerDrawableItem_right  ref android.R.styleable::LayerDrawableItem_bottom  ref android.R.styleable::LayerDrawableItem_drawable  ref android.R.styleable::LayerDrawableItem_id </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/LayerDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/LayerDrawable", AccessFlags = 33)]
		public partial class LayerDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new layer drawable with the list of specified layers.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "([Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public LayerDrawable(global::Android.Graphics.Drawable.Drawable[] layers) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Look for a layer with the given id, and returns its Drawable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Drawable of the layer that has the given id in the hierarchy or null. </para>
				/// </returns>
				/// <java-name>
				/// findDrawableByLayerId
				/// </java-name>
				[Dot42.DexImport("findDrawableByLayerId", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable FindDrawableByLayerId(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Sets the ID of a layer.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setId
				/// </java-name>
				[Dot42.DexImport("setId", "(II)V", AccessFlags = 1)]
				public virtual void SetId(int index, int id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of layers contained within this. </para>        
				/// </summary>
				/// <returns>
				/// <para>The number of layers. </para>
				/// </returns>
				/// <java-name>
				/// getNumberOfLayers
				/// </java-name>
				[Dot42.DexImport("getNumberOfLayers", "()I", AccessFlags = 1)]
				public virtual int GetNumberOfLayers() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the drawable at the specified layer index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The android.graphics.drawable.Drawable at the specified layer index. </para>
				/// </returns>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawable(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Returns the id of the specified layer.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The id of the layer or android.view.View#NO_ID if the layer has no id. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "(I)I", AccessFlags = 1)]
				public virtual int GetId(int index) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets (or replaces) the Drawable for the layer with the given id.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the Drawable was replaced (could return false if the id was not found). </para>
				/// </returns>
				/// <java-name>
				/// setDrawableByLayerId
				/// </java-name>
				[Dot42.DexImport("setDrawableByLayerId", "(ILandroid/graphics/drawable/Drawable;)Z", AccessFlags = 1)]
				public virtual bool SetDrawableByLayerId(int id, global::Android.Graphics.Drawable.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Specify modifiers to the bounds for the drawable[index]. left += l top += t; right -= r; bottom -= b; </para>        
				/// </summary>
				/// <java-name>
				/// setLayerInset
				/// </java-name>
				[Dot42.DexImport("setLayerInset", "(IIIII)V", AccessFlags = 1)]
				public virtual void SetLayerInset(int index, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to schedule the next frame of its animation. An implementation can generally simply call android.os.Handler#postAtTime(Runnable, Object, long) with the parameters <b>(what, who, when)</b> to perform the scheduling.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to unschedule an action previously scheduled with scheduleDrawable. An implementation can generally simply call android.os.Handler#removeCallbacks(Runnable, Object) with the parameters <b>(what, who)</b> to unschedule the drawable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set whether this Drawable is visible. This generally does not impact the Drawable's behavior, but is a hint that can be used by some Drawables, for example, to decide whether run animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Returns true if the new visibility is different than its previous state. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool visible, bool restart) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set to true to have the drawable dither its colors when drawn to a device with fewer than 8-bits per color component. This can improve the look on those devices, but can also slow down the drawing a little. </para>        
				/// </summary>
				/// <java-name>
				/// setDither
				/// </java-name>
				[Dot42.DexImport("setDither", "(Z)V", AccessFlags = 1)]
				public override void SetDither(bool dither) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the opacity of this drawable directly, instead of collecting the states from the layers</para><para><para>PixelFormat::UNKNOWN </para><simplesectsep></simplesectsep><para>PixelFormat::TRANSLUCENT </para><simplesectsep></simplesectsep><para>PixelFormat::TRANSPARENT </para><simplesectsep></simplesectsep><para>PixelFormat::OPAQUE </para></para>        
				/// </summary>
				/// <java-name>
				/// setOpacity
				/// </java-name>
				[Dot42.DexImport("setOpacity", "(I)V", AccessFlags = 1)]
				public virtual void SetOpacity(int opacity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Indicates whether this view will change its appearance based on state. Clients can use this to determine whether it is necessary to calculate their state and call setState.</para><para><para>#setState(int[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this view changes its appearance based on state, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the state change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last state. </para>
				/// </returns>
				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] state) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you vary based on level. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the level change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last level. </para>
				/// </returns>
				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
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

				/// <summary>
				/// <para>Returns the number of layers contained within this. </para>        
				/// </summary>
				/// <returns>
				/// <para>The number of layers. </para>
				/// </returns>
				/// <java-name>
				/// getNumberOfLayers
				/// </java-name>
				public int NumberOfLayers
				{
				[Dot42.DexImport("getNumberOfLayers", "()I", AccessFlags = 1)]
						get{ return GetNumberOfLayers(); }
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

		/// <summary>
		/// <para>A Drawable that can rotate another Drawable based on the current level value. The start and end angles of rotation can be controlled to map any circular arc to the level values range.</para><para>It can be defined in an XML file with the <code>&lt;rotate&gt;</code> element. For more information, see the guide to .</para><para>ref android.R.styleable::RotateDrawable_visible  ref android.R.styleable::RotateDrawable_fromDegrees  ref android.R.styleable::RotateDrawable_toDegrees  ref android.R.styleable::RotateDrawable_pivotX  ref android.R.styleable::RotateDrawable_pivotY  ref android.R.styleable::RotateDrawable_drawable </para>    
		/// </summary>
		/// <java-name>
		/// android/graphics/drawable/RotateDrawable
		/// </java-name>
		[Dot42.DexImport("android/graphics/drawable/RotateDrawable", AccessFlags = 33)]
		public partial class RotateDrawable : global::Android.Graphics.Drawable.Drawable, global::Android.Graphics.Drawable.Drawable.ICallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a new rotating drawable with an empty state.</para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RotateDrawable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw in its bounds (set via setBounds) respecting optional effects such as alpha (set via setAlpha) and color filter (set via setColorFilter).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the drawable rotated by this RotateDrawable. </para>        
				/// </summary>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDrawable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
				public override int GetChangingConfigurations() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Specify an alpha value for the drawable. 0 means fully transparent, and 255 means fully opaque. </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public override void SetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Specify an optional colorFilter for the drawable. Pass null to remove any filters. </para>        
				/// </summary>
				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public override void SetColorFilter(global::Android.Graphics.ColorFilter cf) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
				public override int GetOpacity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Called when the drawable needs to be redrawn. A view at this point should invalidate itself (or at least the part of itself where the drawable appears).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawable.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to schedule the next frame of its animation. An implementation can generally simply call android.os.Handler#postAtTime(Runnable, Object, long) with the parameters <b>(what, who, when)</b> to perform the scheduling.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>A Drawable can call this to unschedule an action previously scheduled with scheduleDrawable. An implementation can generally simply call android.os.Handler#removeCallbacks(Runnable, Object) with the parameters <b>(what, who)</b> to unschedule the drawable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawable.Drawable who, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return in padding the insets suggested by this Drawable for placing content inside the drawable's bounds. Positive values move toward the center of the Drawable (set Rect.inset). Returns true if this drawable actually has a padding, else false. When false is returned, the padding is always set to 0. </para>        
				/// </summary>
				/// <java-name>
				/// getPadding
				/// </java-name>
				[Dot42.DexImport("getPadding", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool GetPadding(global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set whether this Drawable is visible. This generally does not impact the Drawable's behavior, but is a hint that can be used by some Drawables, for example, to decide whether run animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Returns true if the new visibility is different than its previous state. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(ZZ)Z", AccessFlags = 1)]
				public override bool SetVisible(bool visible, bool restart) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this view will change its appearance based on state. Clients can use this to determine whether it is necessary to calculate their state and call setState.</para><para><para>#setState(int[]) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this view changes its appearance based on state, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isStateful
				/// </java-name>
				[Dot42.DexImport("isStateful", "()Z", AccessFlags = 1)]
				public override bool IsStateful() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the state change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last state. </para>
				/// </returns>
				/// <java-name>
				/// onStateChange
				/// </java-name>
				[Dot42.DexImport("onStateChange", "([I)Z", AccessFlags = 4)]
				protected internal override bool OnStateChange(int[] state) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you vary based on level. </para>        
				/// </summary>
				/// <returns>
				/// <para>Returns true if the level change has caused the appearance of the Drawable to change (that is, it needs to be drawn), else false if it looks the same and there is no need to redraw it since its last level. </para>
				/// </returns>
				/// <java-name>
				/// onLevelChange
				/// </java-name>
				[Dot42.DexImport("onLevelChange", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnLevelChange(int level) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Override this in your subclass to change appearance if you recognize the specified state. </para>        
				/// </summary>
				/// <java-name>
				/// onBoundsChange
				/// </java-name>
				[Dot42.DexImport("onBoundsChange", "(Landroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnBoundsChange(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
				public override int GetIntrinsicWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
				public override int GetIntrinsicHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return a ConstantState instance that holds the shared state of this Drawable. *q <para>ConstantState </para><simplesectsep></simplesectsep><para>Drawable::mutate() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ConstantState associated to that Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getConstantState
				/// </java-name>
				[Dot42.DexImport("getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable.ConstantState GetConstantState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable.ConstantState);
				}

				/// <summary>
				/// <para>Inflate this Drawable from an XML resource. </para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/Attri" +
    "buteSet;)V", AccessFlags = 1)]
				public override void Inflate(global::Android.Content.Res.Resources r, global::Org.Xmlpull.V1.IXmlPullParser parser, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Make this drawable mutable. This operation cannot be reversed. A mutable drawable is guaranteed to not share its state with any other drawable. This is especially useful when you need to modify properties of drawables loaded from resources. By default, all drawables instances loaded from the same resource share a common state; if you modify the state of one instance, all the other instances will receive the same modification.</para><para>Calling this method on a mutable Drawable will have no effect.</para><para><para>ConstantState </para><simplesectsep></simplesectsep><para>getConstantState() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>This drawable. </para>
				/// </returns>
				/// <java-name>
				/// mutate
				/// </java-name>
				[Dot42.DexImport("mutate", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public override global::Android.Graphics.Drawable.Drawable Mutate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Returns the drawable rotated by this RotateDrawable. </para>        
				/// </summary>
				/// <java-name>
				/// getDrawable
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Drawable
				{
				[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetDrawable(); }
				}

				/// <summary>
				/// <para>Return a mask of the configuration parameters for which this drawable may change, requiring that it be re-created. The default implementation returns whatever was provided through setChangingConfigurations(int) or 0 by default. Subclasses may extend this to or in the changing configurations of any other drawables they hold.</para><para><para>android.content.res.Configuration </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns a mask of the changing configuration parameters, as defined by android.content.res.Configuration.</para>
				/// </returns>
				/// <java-name>
				/// getChangingConfigurations
				/// </java-name>
				public int ChangingConfigurations
				{
				[Dot42.DexImport("getChangingConfigurations", "()I", AccessFlags = 1)]
						get{ return GetChangingConfigurations(); }
				}

				/// <summary>
				/// <para>Return the opacity/transparency of this Drawable. The returned value is one of the abstract format constants in android.graphics.PixelFormat: android.graphics.PixelFormat#UNKNOWN, android.graphics.PixelFormat#TRANSLUCENT, android.graphics.PixelFormat#TRANSPARENT, or android.graphics.PixelFormat#OPAQUE.</para><para>Generally a Drawable should be as conservative as possible with the value it returns. For example, if it contains multiple child drawables and only shows one of them at a time, if only one of the children is TRANSLUCENT and the others are OPAQUE then TRANSLUCENT should be returned. You can use the method resolveOpacity to perform a standard reduction of two opacities to the appropriate single output.</para><para>Note that the returned value does <b>not</b> take into account a custom alpha or color filter that has been applied by the client through the setAlpha or setColorFilter methods.</para><para><para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <returns>
				/// <para>int The opacity class of the Drawable.</para>
				/// </returns>
				/// <java-name>
				/// getOpacity
				/// </java-name>
				public int Opacity
				{
				[Dot42.DexImport("getOpacity", "()I", AccessFlags = 1)]
						get{ return GetOpacity(); }
				}

				/// <summary>
				/// <para>Return the intrinsic width of the underlying drawable object. Returns -1 if it has no intrinsic width, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicWidth
				/// </java-name>
				public int IntrinsicWidth
				{
				[Dot42.DexImport("getIntrinsicWidth", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicWidth(); }
				}

				/// <summary>
				/// <para>Return the intrinsic height of the underlying drawable object. Returns -1 if it has no intrinsic height, such as with a solid color. </para>        
				/// </summary>
				/// <java-name>
				/// getIntrinsicHeight
				/// </java-name>
				public int IntrinsicHeight
				{
				[Dot42.DexImport("getIntrinsicHeight", "()I", AccessFlags = 1)]
						get{ return GetIntrinsicHeight(); }
				}

		}

}


