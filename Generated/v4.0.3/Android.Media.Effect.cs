#pragma warning disable 1717
namespace Android.Media.Effect
{
		/// <java-name>
		/// android/media/effect/EffectUpdateListener
		/// </java-name>
		[Dot42.DexImport("android/media/effect/EffectUpdateListener", AccessFlags = 1537)]
		public partial interface IEffectUpdateListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onEffectUpdated
				/// </java-name>
				[Dot42.DexImport("onEffectUpdated", "(Landroid/media/effect/Effect;Ljava/lang/Object;)V", AccessFlags = 1025)]
				void OnEffectUpdated(global::Android.Media.Effect.Effect effect, object @object) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/media/effect/EffectFactory
		/// </java-name>
		[Dot42.DexImport("android/media/effect/EffectFactory", AccessFlags = 33)]
		public partial class EffectFactory
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EFFECT_BRIGHTNESS
				/// </java-name>
				[Dot42.DexImport("EFFECT_BRIGHTNESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_BRIGHTNESS = "android.media.effect.effects.BrightnessEffect";
				/// <java-name>
				/// EFFECT_CONTRAST
				/// </java-name>
				[Dot42.DexImport("EFFECT_CONTRAST", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_CONTRAST = "android.media.effect.effects.ContrastEffect";
				/// <java-name>
				/// EFFECT_FISHEYE
				/// </java-name>
				[Dot42.DexImport("EFFECT_FISHEYE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_FISHEYE = "android.media.effect.effects.FisheyeEffect";
				/// <java-name>
				/// EFFECT_BACKDROPPER
				/// </java-name>
				[Dot42.DexImport("EFFECT_BACKDROPPER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_BACKDROPPER = "android.media.effect.effects.BackDropperEffect";
				/// <java-name>
				/// EFFECT_AUTOFIX
				/// </java-name>
				[Dot42.DexImport("EFFECT_AUTOFIX", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_AUTOFIX = "android.media.effect.effects.AutoFixEffect";
				/// <java-name>
				/// EFFECT_BLACKWHITE
				/// </java-name>
				[Dot42.DexImport("EFFECT_BLACKWHITE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_BLACKWHITE = "android.media.effect.effects.BlackWhiteEffect";
				/// <java-name>
				/// EFFECT_CROP
				/// </java-name>
				[Dot42.DexImport("EFFECT_CROP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_CROP = "android.media.effect.effects.CropEffect";
				/// <java-name>
				/// EFFECT_CROSSPROCESS
				/// </java-name>
				[Dot42.DexImport("EFFECT_CROSSPROCESS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_CROSSPROCESS = "android.media.effect.effects.CrossProcessEffect";
				/// <java-name>
				/// EFFECT_DOCUMENTARY
				/// </java-name>
				[Dot42.DexImport("EFFECT_DOCUMENTARY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_DOCUMENTARY = "android.media.effect.effects.DocumentaryEffect";
				/// <java-name>
				/// EFFECT_BITMAPOVERLAY
				/// </java-name>
				[Dot42.DexImport("EFFECT_BITMAPOVERLAY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_BITMAPOVERLAY = "android.media.effect.effects.BitmapOverlayEffect";
				/// <java-name>
				/// EFFECT_DUOTONE
				/// </java-name>
				[Dot42.DexImport("EFFECT_DUOTONE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_DUOTONE = "android.media.effect.effects.DuotoneEffect";
				/// <java-name>
				/// EFFECT_FILLLIGHT
				/// </java-name>
				[Dot42.DexImport("EFFECT_FILLLIGHT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_FILLLIGHT = "android.media.effect.effects.FillLightEffect";
				/// <java-name>
				/// EFFECT_FLIP
				/// </java-name>
				[Dot42.DexImport("EFFECT_FLIP", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_FLIP = "android.media.effect.effects.FlipEffect";
				/// <java-name>
				/// EFFECT_GRAIN
				/// </java-name>
				[Dot42.DexImport("EFFECT_GRAIN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_GRAIN = "android.media.effect.effects.GrainEffect";
				/// <java-name>
				/// EFFECT_GRAYSCALE
				/// </java-name>
				[Dot42.DexImport("EFFECT_GRAYSCALE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_GRAYSCALE = "android.media.effect.effects.GrayscaleEffect";
				/// <java-name>
				/// EFFECT_LOMOISH
				/// </java-name>
				[Dot42.DexImport("EFFECT_LOMOISH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_LOMOISH = "android.media.effect.effects.LomoishEffect";
				/// <java-name>
				/// EFFECT_NEGATIVE
				/// </java-name>
				[Dot42.DexImport("EFFECT_NEGATIVE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_NEGATIVE = "android.media.effect.effects.NegativeEffect";
				/// <java-name>
				/// EFFECT_POSTERIZE
				/// </java-name>
				[Dot42.DexImport("EFFECT_POSTERIZE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_POSTERIZE = "android.media.effect.effects.PosterizeEffect";
				/// <java-name>
				/// EFFECT_REDEYE
				/// </java-name>
				[Dot42.DexImport("EFFECT_REDEYE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_REDEYE = "android.media.effect.effects.RedEyeEffect";
				/// <java-name>
				/// EFFECT_ROTATE
				/// </java-name>
				[Dot42.DexImport("EFFECT_ROTATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_ROTATE = "android.media.effect.effects.RotateEffect";
				/// <java-name>
				/// EFFECT_SATURATE
				/// </java-name>
				[Dot42.DexImport("EFFECT_SATURATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_SATURATE = "android.media.effect.effects.SaturateEffect";
				/// <java-name>
				/// EFFECT_SEPIA
				/// </java-name>
				[Dot42.DexImport("EFFECT_SEPIA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_SEPIA = "android.media.effect.effects.SepiaEffect";
				/// <java-name>
				/// EFFECT_SHARPEN
				/// </java-name>
				[Dot42.DexImport("EFFECT_SHARPEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_SHARPEN = "android.media.effect.effects.SharpenEffect";
				/// <java-name>
				/// EFFECT_STRAIGHTEN
				/// </java-name>
				[Dot42.DexImport("EFFECT_STRAIGHTEN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_STRAIGHTEN = "android.media.effect.effects.StraightenEffect";
				/// <java-name>
				/// EFFECT_TEMPERATURE
				/// </java-name>
				[Dot42.DexImport("EFFECT_TEMPERATURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_TEMPERATURE = "android.media.effect.effects.ColorTemperatureEffect";
				/// <java-name>
				/// EFFECT_TINT
				/// </java-name>
				[Dot42.DexImport("EFFECT_TINT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_TINT = "android.media.effect.effects.TintEffect";
				/// <java-name>
				/// EFFECT_VIGNETTE
				/// </java-name>
				[Dot42.DexImport("EFFECT_VIGNETTE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EFFECT_VIGNETTE = "android.media.effect.effects.VignetteEffect";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal EffectFactory() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createEffect
				/// </java-name>
				[Dot42.DexImport("createEffect", "(Ljava/lang/String;)Landroid/media/effect/Effect;", AccessFlags = 1)]
				public virtual global::Android.Media.Effect.Effect CreateEffect(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Effect.Effect);
				}

				/// <java-name>
				/// isEffectSupported
				/// </java-name>
				[Dot42.DexImport("isEffectSupported", "(Ljava/lang/String;)Z", AccessFlags = 9)]
				public static bool IsEffectSupported(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

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

				/// <java-name>
				/// createWithCurrentGlContext
				/// </java-name>
				[Dot42.DexImport("createWithCurrentGlContext", "()Landroid/media/effect/EffectContext;", AccessFlags = 9)]
				public static global::Android.Media.Effect.EffectContext CreateWithCurrentGlContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Effect.EffectContext);
				}

				/// <java-name>
				/// getFactory
				/// </java-name>
				[Dot42.DexImport("getFactory", "()Landroid/media/effect/EffectFactory;", AccessFlags = 1)]
				public virtual global::Android.Media.Effect.EffectFactory GetFactory() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Media.Effect.EffectFactory);
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFactory
				/// </java-name>
				public global::Android.Media.Effect.EffectFactory Factory
				{
				[Dot42.DexImport("getFactory", "()Landroid/media/effect/EffectFactory;", AccessFlags = 1)]
						get{ return GetFactory(); }
				}

		}

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

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
				public abstract string GetName() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(IIII)V", AccessFlags = 1025)]
				public abstract void Apply(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setParameter
				/// </java-name>
				[Dot42.DexImport("setParameter", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetParameter(string @string, object @object) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setUpdateListener
				/// </java-name>
				[Dot42.DexImport("setUpdateListener", "(Landroid/media/effect/EffectUpdateListener;)V", AccessFlags = 1)]
				public virtual void SetUpdateListener(global::Android.Media.Effect.IEffectUpdateListener effectUpdateListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1025)]
				public abstract void Release() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get{ return GetName(); }
				}

		}

}

