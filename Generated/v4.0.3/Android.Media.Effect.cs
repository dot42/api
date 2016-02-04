#pragma warning disable 1717
namespace Android.Media.Effect
{
		/// <summary>
		///  <para>Effects are high-performance transformations that can be applied to image frames. These are passed in the form of OpenGL ES 2.0 texture names. Typical frames could be images loaded from disk, or frames from the camera or other video streams.</para> <para>To create an Effect you must first create an EffectContext. You can obtain an instance of the context's EffectFactory by calling getFactory(). The EffectFactory allows you to instantiate specific Effects.</para> <para>The application is responsible for creating an EGL context, and making it current before applying an effect. An effect is bound to a single EffectContext, which in turn is bound to a single EGL context. If your EGL context is destroyed, the EffectContext becomes invalid and any effects bound to this context can no longer be used.</para>    
		/// </summary>
		/// <java-name>
		/// android/media/effect/Effect
		/// </java-name>
		[Dot42.DexImport("android/media/effect/Effect", AccessFlags = 1057)]
		public abstract partial class Effect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Effect() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply an effect to GL textures.</para> <para>Apply the Effect on the specified input GL texture, and write the result into the output GL texture. The texture names passed must be valid in the current GL context.</para> <para>The input texture must be a valid texture name with the given width and height and must be bound to a GL_TEXTURE_2D texture image (usually done by calling the glTexImage2D() function). Multiple mipmap levels may be provided.</para> <para>If the output texture has not been bound to a texture image, it will be automatically bound by the effect as a GL_TEXTURE_2D. It will contain one mipmap level (0), which will have the same size as the input. No other mipmap levels are defined. If the output texture was bound already, and its size does not match the input texture size, the result may be clipped or only partially fill the texture.</para> <para>Note, that regardless of whether a texture image was originally provided or not, both the input and output textures are owned by the caller. That is, the caller is responsible for calling glDeleteTextures() to deallocate the input and output textures.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(IIII)V", AccessFlags = 1025)]
				public abstract void Apply(int inputTexId, int width, int height, int outputTexId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a filter parameter.</para> <para>Consult the effect documentation for a list of supported parameter keys for each effect.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetParameter(string parameterKey, object value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set an effect listener.</para> <para>Some effects may report state changes back to the host, if a listener is set. Consult the individual effect documentation for more details.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setUpdateListener
				/// </java-name>
				[Dot42.DexImport("setUpdateListener", "(Landroid/media/effect/EffectUpdateListener;)V", AccessFlags = 1)]
				public virtual void SetUpdateListener(global::Android.Media.Effect.IEffectUpdateListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Release an effect.</para> <para>Releases the effect and any resources associated with it. You may call this if you need to make sure acquired resources are no longer held by the effect. Releasing an effect makes it invalid for reuse.</para> <para>Note that this method must be called with the EffectContext and EGL context current, as the effect may release internal GL resources.</para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1025)]
				public abstract void Release() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the effect name.</para> <para>Returns the unique name of the effect, which matches the name used for instantiating this effect by the EffectFactory.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The name of the effect. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public abstract string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>An EffectContext keeps all necessary state information to run Effects within a Open GL ES 2.0 context.</para> <para>Every EffectContext is bound to one GL context. The application is responsible for creating this EGL context, and making it current before applying any effect. If your EGL context is destroyed, the EffectContext becomes invalid and any effects bound to this context can no longer be used. If you switch to another EGL context, you must create a new EffectContext. Each Effect is bound to a single EffectContext, and can only be executed in that context.</para>    
		/// </summary>
		/// <java-name>
		/// android/media/effect/EffectContext
		/// </java-name>
		[Dot42.DexImport("android/media/effect/EffectContext", AccessFlags = 33)]
		public partial class EffectContext
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EffectContext() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a context within the current GL context.</para> <para>Binds the EffectContext to the current OpenGL context. All subsequent calls to the EffectContext must be made in the GL context that was active during creation. When you have finished using a context, you must call release(). to dispose of all resources associated with this context.</para>        
				/// </summary>
				/// <java-name>
				/// createWithCurrentGlContext
				/// </java-name>
				[Dot42.DexImport("createWithCurrentGlContext", "()Landroid/media/effect/EffectContext;", AccessFlags = 9)]
				public static global::Android.Media.Effect.EffectContext CreateWithCurrentGlContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Effect.EffectContext);
				}

				/// <summary>
				///  <para>Releases the context.</para> <para>Releases all the resources and effects associated with the EffectContext. This renders the context and all the effects bound to this context invalid. You must no longer use the context or any of its bound effects after calling release().</para> <para>Note that this method must be called with the proper EGL context made current, as the EffectContext and its effects may release internal GL resources.</para>        
				/// </summary>
				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the EffectFactory for this context.</para> <para>The EffectFactory returned from this method allows instantiating new effects within this context.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The EffectFactory instance for this context. </para>
				/// </returns>
				/// <java-name>
				/// getFactory
				/// </java-name>
				public virtual global::Android.Media.Effect.EffectFactory Factory
				{
						[Dot42.DexImport("getFactory", "()Landroid/media/effect/EffectFactory;", AccessFlags = 1)]
						get{ return default(global::Android.Media.Effect.EffectFactory); }
				}

		}

		/// <summary>
		///  <para>The EffectFactory class defines the list of available Effects, and provides functionality to inspect and instantiate them. Some effects may not be available on all platforms, so before creating a certain effect, the application should confirm that the effect is supported on this platform by calling isEffectSupported(String).</para>    
		/// </summary>
		/// <java-name>
		/// android/media/effect/EffectFactory
		/// </java-name>
		[Dot42.DexImport("android/media/effect/EffectFactory", AccessFlags = 33)]
		public partial class EffectFactory
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Adjusts the brightness of the image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>brightness</code> </para></entry> <entry> <para>The brightness multiplier. </para></entry> <entry> <para>Positive float. 1.0 means no change; larger values will increase brightness.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_BRIGHTNESS
				/// </java-name>
				[Dot42.DexImport("EFFECT_BRIGHTNESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_BRIGHTNESS = "android.media.effect.effects.BrightnessEffect";
				/// <summary>
				///  <para>Adjusts the contrast of the image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>contrast</code> </para></entry> <entry> <para>The contrast multiplier. </para></entry> <entry> <para>Float. 1.0 means no change; larger values will increase contrast.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_CONTRAST
				/// </java-name>
				[Dot42.DexImport("EFFECT_CONTRAST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_CONTRAST = "android.media.effect.effects.ContrastEffect";
				/// <summary>
				///  <para>Applies a fisheye lens distortion to the image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>scale</code> </para></entry> <entry> <para>The scale of the distortion. </para></entry> <entry> <para>Float, between 0 and 1. Zero means no distortion.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_FISHEYE
				/// </java-name>
				[Dot42.DexImport("EFFECT_FISHEYE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_FISHEYE = "android.media.effect.effects.FisheyeEffect";
				/// <summary>
				///  <para>Replaces the background of the input frames with frames from a selected video. Requires an initial learning period with only the background visible before the effect becomes active. The effect will wait until it does not see any motion in the scene before learning the background and starting the effect.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>source</code> </para></entry> <entry> <para>A URI for the background video to use. This parameter must be supplied before calling apply() for the first time. </para></entry> <entry> <para>String, such as from Uri.toString()  </para></entry></row></table></para> <para>If the update listener is set for this effect using Effect#setUpdateListener, it will be called when the effect has finished learning the background, with a null value for the info parameter.</para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_BACKDROPPER
				/// </java-name>
				[Dot42.DexImport("EFFECT_BACKDROPPER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_BACKDROPPER = "android.media.effect.effects.BackDropperEffect";
				/// <summary>
				///  <para>Attempts to auto-fix the image based on histogram equalization.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>scale</code> </para></entry> <entry> <para>The scale of the adjustment. </para></entry> <entry> <para>Float, between 0 and 1. Zero means no adjustment, while 1 indicates the maximum amount of adjustment.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_AUTOFIX
				/// </java-name>
				[Dot42.DexImport("EFFECT_AUTOFIX", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_AUTOFIX = "android.media.effect.effects.AutoFixEffect";
				/// <summary>
				///  <para>Adjusts the range of minimal and maximal color pixel intensities.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>black</code> </para></entry> <entry> <para>The value of the minimal pixel. </para></entry> <entry> <para>Float, between 0 and 1.  </para></entry></row> <row> <entry> <para> <code>white</code> </para></entry> <entry> <para>The value of the maximal pixel. </para></entry> <entry> <para>Float, between 0 and 1.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_BLACKWHITE
				/// </java-name>
				[Dot42.DexImport("EFFECT_BLACKWHITE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_BLACKWHITE = "android.media.effect.effects.BlackWhiteEffect";
				/// <summary>
				///  <para>Crops an upright rectangular area from the image. If the crop region falls outside of the image bounds, the results are undefined.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>xorigin</code> </para></entry> <entry> <para>The origin's x-value. </para></entry> <entry> <para>Integer, between 0 and width of the image.  </para></entry></row> <row> <entry> <para> <code>yorigin</code> </para></entry> <entry> <para>The origin's y-value. </para></entry> <entry> <para>Integer, between 0 and height of the image.  </para></entry></row> <row> <entry> <para> <code>width</code> </para></entry> <entry> <para>The width of the cropped image. </para></entry> <entry> <para>Integer, between 1 and the width of the image minus xorigin.  </para></entry></row> <row> <entry> <para> <code>height</code> </para></entry> <entry> <para>The height of the cropped image. </para></entry> <entry> <para>Integer, between 1 and the height of the image minus yorigin.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_CROP
				/// </java-name>
				[Dot42.DexImport("EFFECT_CROP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_CROP = "android.media.effect.effects.CropEffect";
				/// <summary>
				///  <para>Applies a cross process effect on image, in which the red and green channels are enhanced while the blue channel is restricted.</para> <para>Available parameters: None</para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_CROSSPROCESS
				/// </java-name>
				[Dot42.DexImport("EFFECT_CROSSPROCESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_CROSSPROCESS = "android.media.effect.effects.CrossProcessEffect";
				/// <summary>
				///  <para>Applies black and white documentary style effect on image..</para> <para>Available parameters: None</para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_DOCUMENTARY
				/// </java-name>
				[Dot42.DexImport("EFFECT_DOCUMENTARY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_DOCUMENTARY = "android.media.effect.effects.DocumentaryEffect";
				/// <summary>
				///  <para>Overlays a bitmap (with premultiplied alpha channel) onto the input image. The bitmap is stretched to fit the input image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>bitmap</code> </para></entry> <entry> <para>The overlay bitmap. </para></entry> <entry> <para>A non-null Bitmap instance.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_BITMAPOVERLAY
				/// </java-name>
				[Dot42.DexImport("EFFECT_BITMAPOVERLAY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_BITMAPOVERLAY = "android.media.effect.effects.BitmapOverlayEffect";
				/// <summary>
				///  <para>Representation of photo using only two color tones.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>first_color</code> </para></entry> <entry> <para>The first color tone. </para></entry> <entry> <para>Integer, representing an ARGB color with 8 bits per channel. May be created using Color class.  </para></entry></row> <row> <entry> <para> <code>second_color</code> </para></entry> <entry> <para>The second color tone. </para></entry> <entry> <para>Integer, representing an ARGB color with 8 bits per channel. May be created using Color class.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_DUOTONE
				/// </java-name>
				[Dot42.DexImport("EFFECT_DUOTONE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_DUOTONE = "android.media.effect.effects.DuotoneEffect";
				/// <summary>
				///  <para>Applies back-light filling to the image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>strength</code> </para></entry> <entry> <para>The strength of the backlight. </para></entry> <entry> <para>Float, between 0 and 1. Zero means no change.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_FILLLIGHT
				/// </java-name>
				[Dot42.DexImport("EFFECT_FILLLIGHT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_FILLLIGHT = "android.media.effect.effects.FillLightEffect";
				/// <summary>
				///  <para>Flips image vertically and/or horizontally.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>vertical</code> </para></entry> <entry> <para>Whether to flip image vertically. </para></entry> <entry> <para>Boolean  </para></entry></row> <row> <entry> <para> <code>horizontal</code> </para></entry> <entry> <para>Whether to flip image horizontally. </para></entry> <entry> <para>Boolean  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_FLIP
				/// </java-name>
				[Dot42.DexImport("EFFECT_FLIP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_FLIP = "android.media.effect.effects.FlipEffect";
				/// <summary>
				///  <para>Applies film grain effect to image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>strength</code> </para></entry> <entry> <para>The strength of the grain effect. </para></entry> <entry> <para>Float, between 0 and 1. Zero means no change.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_GRAIN
				/// </java-name>
				[Dot42.DexImport("EFFECT_GRAIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_GRAIN = "android.media.effect.effects.GrainEffect";
				/// <summary>
				///  <para>Converts image to grayscale.</para> <para>Available parameters: None</para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_GRAYSCALE
				/// </java-name>
				[Dot42.DexImport("EFFECT_GRAYSCALE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_GRAYSCALE = "android.media.effect.effects.GrayscaleEffect";
				/// <summary>
				///  <para>Applies lomo-camera style effect to image.</para> <para>Available parameters: None</para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_LOMOISH
				/// </java-name>
				[Dot42.DexImport("EFFECT_LOMOISH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_LOMOISH = "android.media.effect.effects.LomoishEffect";
				/// <summary>
				///  <para>Inverts the image colors.</para> <para>Available parameters: None</para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_NEGATIVE
				/// </java-name>
				[Dot42.DexImport("EFFECT_NEGATIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_NEGATIVE = "android.media.effect.effects.NegativeEffect";
				/// <summary>
				///  <para>Applies posterization effect to image.</para> <para>Available parameters: None</para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_POSTERIZE
				/// </java-name>
				[Dot42.DexImport("EFFECT_POSTERIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_POSTERIZE = "android.media.effect.effects.PosterizeEffect";
				/// <summary>
				///  <para>Removes red eyes on specified region.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>centers</code> </para></entry> <entry> <para>Multiple center points (x, y) of the red eye regions. </para></entry> <entry> <para>An array of floats, where (f[2*i], f[2*i+1]) specifies the center of the i'th eye. Coordinate values are expected to be normalized between 0 and 1.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_REDEYE
				/// </java-name>
				[Dot42.DexImport("EFFECT_REDEYE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_REDEYE = "android.media.effect.effects.RedEyeEffect";
				/// <summary>
				///  <para>Rotates the image. The output frame size must be able to fit the rotated version of the input image. Note that the rotation snaps to a the closest multiple of 90 degrees.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>angle</code> </para></entry> <entry> <para>The angle of rotation in degrees. </para></entry> <entry> <para>Integer value. This will be rounded to the nearest multiple of 90.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_ROTATE
				/// </java-name>
				[Dot42.DexImport("EFFECT_ROTATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_ROTATE = "android.media.effect.effects.RotateEffect";
				/// <summary>
				///  <para>Adjusts color saturation of image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>scale</code> </para></entry> <entry> <para>The scale of color saturation. </para></entry> <entry> <para>Float, between -1 and 1. 0 means no change, while -1 indicates full desaturation, i.e. grayscale.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_SATURATE
				/// </java-name>
				[Dot42.DexImport("EFFECT_SATURATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_SATURATE = "android.media.effect.effects.SaturateEffect";
				/// <summary>
				///  <para>Converts image to sepia tone.</para> <para>Available parameters: None</para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_SEPIA
				/// </java-name>
				[Dot42.DexImport("EFFECT_SEPIA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_SEPIA = "android.media.effect.effects.SepiaEffect";
				/// <summary>
				///  <para>Sharpens the image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>scale</code> </para></entry> <entry> <para>The degree of sharpening. </para></entry> <entry> <para>Float, between 0 and 1. 0 means no change.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_SHARPEN
				/// </java-name>
				[Dot42.DexImport("EFFECT_SHARPEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_SHARPEN = "android.media.effect.effects.SharpenEffect";
				/// <summary>
				///  <para>Rotates the image according to the specified angle, and crops the image so that no non-image portions are visible.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>angle</code> </para></entry> <entry> <para>The angle of rotation. </para></entry> <entry> <para>Float, between -45 and +45.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_STRAIGHTEN
				/// </java-name>
				[Dot42.DexImport("EFFECT_STRAIGHTEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_STRAIGHTEN = "android.media.effect.effects.StraightenEffect";
				/// <summary>
				///  <para>Adjusts color temperature of the image.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>scale</code> </para></entry> <entry> <para>The value of color temperature. </para></entry> <entry> <para>Float, between 0 and 1, with 0 indicating cool, and 1 indicating warm. A value of of 0.5 indicates no change.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("EFFECT_TEMPERATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_TEMPERATURE = "android.media.effect.effects.ColorTemperatureEffect";
				/// <summary>
				///  <para>Tints the photo with specified color.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>tint</code> </para></entry> <entry> <para>The color of the tint. </para></entry> <entry> <para>Integer, representing an ARGB color with 8 bits per channel. May be created using Color class.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_TINT
				/// </java-name>
				[Dot42.DexImport("EFFECT_TINT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_TINT = "android.media.effect.effects.TintEffect";
				/// <summary>
				///  <para>Adds a vignette effect to image, i.e. fades away the outer image edges.</para> <para>Available parameters:</para> <para> <table> <row> <entry> <para>Parameter name</para></entry> <entry> <para>Meaning</para></entry> <entry> <para>Valid values </para></entry></row> <row> <entry> <para> <code>scale</code> </para></entry> <entry> <para>The scale of vignetting. </para></entry> <entry> <para>Float, between 0 and 1. 0 means no change.  </para></entry></row></table></para>        
				/// </summary>
				/// <java-name>
				/// EFFECT_VIGNETTE
				/// </java-name>
				[Dot42.DexImport("EFFECT_VIGNETTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_VIGNETTE = "android.media.effect.effects.VignetteEffect";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EffectFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Instantiate a new effect with the given effect name.</para> <para>The effect's parameters will be set to their default values.</para> <para>Note that the EGL context associated with the current EffectContext need not be made current when creating an effect. This allows the host application to instantiate effects before any EGL context has become current.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new Effect instance. </para>
				/// </returns>
				/// <java-name>
				/// createEffect
				/// </java-name>
				[Dot42.DexImport("createEffect", "(Ljava/lang/String;)Landroid/media/effect/Effect;", AccessFlags = 1)]
				public virtual global::Android.Media.Effect.Effect CreateEffect(string effectName) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Effect.Effect);
				}

				/// <summary>
				///  <para>Check if an effect is supported on this platform.</para> <para>Some effects may only be available on certain platforms. Use this method before instantiating an effect to make sure it is supported.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true, if the effect is supported on this platform. </para>
				/// </returns>
				/// <java-name>
				/// isEffectSupported
				/// </java-name>
				[Dot42.DexImport("isEffectSupported", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsEffectSupported(string effectName) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		///  <para>Some effects may issue callbacks to inform the host of changes to the effect state. This is the listener interface for receiving those callbacks. </para>    
		/// </summary>
		/// <java-name>
		/// android/media/effect/EffectUpdateListener
		/// </java-name>
		[Dot42.DexImport("android/media/effect/EffectUpdateListener", AccessFlags = 1537)]
		public partial interface IEffectUpdateListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called when the effect state is updated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onEffectUpdated
				/// </java-name>
				[Dot42.DexImport("onEffectUpdated", "(Landroid/media/effect/Effect;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void OnEffectUpdated(global::Android.Media.Effect.Effect effect, object info) /* MethodBuilder.Create */ ;

		}

}

