#pragma warning disable 1717
namespace Android.Views.Animations
{
		/// <java-name>
		/// android/view/animation/AccelerateDecelerateInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AccelerateDecelerateInterpolator", AccessFlags = 33)]
		public partial class AccelerateDecelerateInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccelerateDecelerateInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AccelerateDecelerateInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/view/animation/AccelerateInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AccelerateInterpolator", AccessFlags = 33)]
		public partial class AccelerateInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccelerateInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public AccelerateInterpolator(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AccelerateInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/view/animation/AlphaAnimation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AlphaAnimation", AccessFlags = 33)]
		public partial class AlphaAnimation : global::Android.Views.Animations.Animation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AlphaAnimation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public AlphaAnimation(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal override void ApplyTransformation(float single, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// willChangeTransformationMatrix
				/// </java-name>
				[Dot42.DexImport("willChangeTransformationMatrix", "()Z", AccessFlags = 1)]
				public override bool WillChangeTransformationMatrix() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// willChangeBounds
				/// </java-name>
				[Dot42.DexImport("willChangeBounds", "()Z", AccessFlags = 1)]
				public override bool WillChangeBounds() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AlphaAnimation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/view/animation/Animation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/Animation", AccessFlags = 1057)]
		public abstract partial class Animation : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// INFINITE
				/// </java-name>
				[Dot42.DexImport("INFINITE", "I", AccessFlags = 25)]
				public const int INFINITE = -1;
				/// <java-name>
				/// RESTART
				/// </java-name>
				[Dot42.DexImport("RESTART", "I", AccessFlags = 25)]
				public const int RESTART = 1;
				/// <java-name>
				/// REVERSE
				/// </java-name>
				[Dot42.DexImport("REVERSE", "I", AccessFlags = 25)]
				public const int REVERSE = 2;
				/// <java-name>
				/// START_ON_FIRST_FRAME
				/// </java-name>
				[Dot42.DexImport("START_ON_FIRST_FRAME", "I", AccessFlags = 25)]
				public const int START_ON_FIRST_FRAME = -1;
				/// <java-name>
				/// ABSOLUTE
				/// </java-name>
				[Dot42.DexImport("ABSOLUTE", "I", AccessFlags = 25)]
				public const int ABSOLUTE = 0;
				/// <java-name>
				/// RELATIVE_TO_SELF
				/// </java-name>
				[Dot42.DexImport("RELATIVE_TO_SELF", "I", AccessFlags = 25)]
				public const int RELATIVE_TO_SELF = 1;
				/// <java-name>
				/// RELATIVE_TO_PARENT
				/// </java-name>
				[Dot42.DexImport("RELATIVE_TO_PARENT", "I", AccessFlags = 25)]
				public const int RELATIVE_TO_PARENT = 2;
				/// <java-name>
				/// ZORDER_NORMAL
				/// </java-name>
				[Dot42.DexImport("ZORDER_NORMAL", "I", AccessFlags = 25)]
				public const int ZORDER_NORMAL = 0;
				/// <java-name>
				/// ZORDER_TOP
				/// </java-name>
				[Dot42.DexImport("ZORDER_TOP", "I", AccessFlags = 25)]
				public const int ZORDER_TOP = 1;
				/// <java-name>
				/// ZORDER_BOTTOM
				/// </java-name>
				[Dot42.DexImport("ZORDER_BOTTOM", "I", AccessFlags = 25)]
				public const int ZORDER_BOTTOM = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Animation() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Animation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/view/animation/Animation;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.Animations.Animation Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.Animation);
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public virtual void Initialize(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restrictDuration
				/// </java-name>
				[Dot42.DexImport("restrictDuration", "(J)V", AccessFlags = 1)]
				public virtual void RestrictDuration(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scaleCurrentDuration
				/// </java-name>
				[Dot42.DexImport("scaleCurrentDuration", "(F)V", AccessFlags = 1)]
				public virtual void ScaleCurrentDuration(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startNow
				/// </java-name>
				[Dot42.DexImport("startNow", "()V", AccessFlags = 1)]
				public virtual void StartNow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// willChangeTransformationMatrix
				/// </java-name>
				[Dot42.DexImport("willChangeTransformationMatrix", "()Z", AccessFlags = 1)]
				public virtual bool WillChangeTransformationMatrix() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// willChangeBounds
				/// </java-name>
				[Dot42.DexImport("willChangeBounds", "()Z", AccessFlags = 1)]
				public virtual bool WillChangeBounds() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAnimationListener
				/// </java-name>
				[Dot42.DexImport("setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V", AccessFlags = 1)]
				public virtual void SetAnimationListener(global::Android.Views.Animations.Animation.IAnimationListener animationListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ensureInterpolator
				/// </java-name>
				[Dot42.DexImport("ensureInterpolator", "()V", AccessFlags = 4)]
				protected internal virtual void EnsureInterpolator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeDurationHint
				/// </java-name>
				[Dot42.DexImport("computeDurationHint", "()J", AccessFlags = 1)]
				public virtual long ComputeDurationHint() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(JLandroid/view/animation/Transformation;)Z", AccessFlags = 1)]
				public virtual bool GetTransformation(long int64, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(JLandroid/view/animation/Transformation;F)Z", AccessFlags = 1)]
				public virtual bool GetTransformation(long int64, global::Android.Views.Animations.Transformation transformation, float single) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal virtual void ApplyTransformation(float single, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resolveSize
				/// </java-name>
				[Dot42.DexImport("resolveSize", "(IFII)F", AccessFlags = 4)]
				protected internal virtual float ResolveSize(int int32, float single, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Animation() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isInitialized
				/// </java-name>
				public virtual bool IsInitialized
				{
						[Dot42.DexImport("isInitialized", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isFillEnabled
				/// </java-name>
				public virtual bool IsFillEnabled
				{
						[Dot42.DexImport("isFillEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFillEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getScaleFactor
				/// </java-name>
				protected internal virtual float ScaleFactor
				{
						[Dot42.DexImport("getScaleFactor", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public virtual global::Android.Views.Animations.IInterpolator Interpolator
				{
						[Dot42.DexImport("getInterpolator", "()Landroid/view/animation/Interpolator;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.IInterpolator); }
						[Dot42.DexImport("setInterpolator", "(Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getStartTime
				/// </java-name>
				public virtual long StartTime
				{
						[Dot42.DexImport("getStartTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setStartTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public virtual long Duration
				{
						[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setDuration", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getStartOffset
				/// </java-name>
				public virtual long StartOffset
				{
						[Dot42.DexImport("getStartOffset", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setStartOffset", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRepeatMode
				/// </java-name>
				public virtual int RepeatMode
				{
						[Dot42.DexImport("getRepeatMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRepeatMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRepeatCount
				/// </java-name>
				public virtual int RepeatCount
				{
						[Dot42.DexImport("getRepeatCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRepeatCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFillBefore
				/// </java-name>
				public virtual bool IsFillBefore
				{
						[Dot42.DexImport("getFillBefore", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFillBefore", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFillAfter
				/// </java-name>
				public virtual bool IsFillAfter
				{
						[Dot42.DexImport("getFillAfter", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFillAfter", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getZAdjustment
				/// </java-name>
				public virtual int ZAdjustment
				{
						[Dot42.DexImport("getZAdjustment", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setZAdjustment", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBackgroundColor
				/// </java-name>
				public virtual int BackgroundColor
				{
						[Dot42.DexImport("getBackgroundColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setBackgroundColor", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDetachWallpaper
				/// </java-name>
				public virtual bool IsDetachWallpaper
				{
						[Dot42.DexImport("getDetachWallpaper", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setDetachWallpaper", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasStarted
				/// </java-name>
				public virtual bool HasStarted
				{
						[Dot42.DexImport("hasStarted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasEnded
				/// </java-name>
				public virtual bool HasEnded
				{
						[Dot42.DexImport("hasEnded", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/view/animation/Animation$AnimationListener
				/// </java-name>
				[Dot42.DexImport("android/view/animation/Animation$AnimationListener", AccessFlags = 1545)]
				public partial interface IAnimationListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onAnimationStart
						/// </java-name>
						[Dot42.DexImport("onAnimationStart", "(Landroid/view/animation/Animation;)V", AccessFlags = 1025)]
						void OnAnimationStart(global::Android.Views.Animations.Animation animation) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onAnimationEnd
						/// </java-name>
						[Dot42.DexImport("onAnimationEnd", "(Landroid/view/animation/Animation;)V", AccessFlags = 1025)]
						void OnAnimationEnd(global::Android.Views.Animations.Animation animation) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onAnimationRepeat
						/// </java-name>
						[Dot42.DexImport("onAnimationRepeat", "(Landroid/view/animation/Animation;)V", AccessFlags = 1025)]
						void OnAnimationRepeat(global::Android.Views.Animations.Animation animation) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/animation/Animation$Description
				/// </java-name>
				[Dot42.DexImport("android/view/animation/Animation$Description", AccessFlags = 12)]
				protected internal partial class Description
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// type
						/// </java-name>
						[Dot42.DexImport("type", "I", AccessFlags = 1)]
						public int Type;
						/// <java-name>
						/// value
						/// </java-name>
						[Dot42.DexImport("value", "F", AccessFlags = 1)]
						public float Value;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
						protected internal Description() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/view/animation/AnimationSet
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AnimationSet", AccessFlags = 33)]
		public partial class AnimationSet : global::Android.Views.Animations.Animation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AnimationSet(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public AnimationSet(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/view/animation/AnimationSet;", AccessFlags = 4)]
				protected internal new virtual global::Android.Views.Animations.AnimationSet Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.AnimationSet);
				}

				/// <java-name>
				/// addAnimation
				/// </java-name>
				[Dot42.DexImport("addAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public virtual void AddAnimation(global::Android.Views.Animations.Animation animation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restrictDuration
				/// </java-name>
				[Dot42.DexImport("restrictDuration", "(J)V", AccessFlags = 1)]
				public override void RestrictDuration(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeDurationHint
				/// </java-name>
				[Dot42.DexImport("computeDurationHint", "()J", AccessFlags = 1)]
				public override long ComputeDurationHint() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(JLandroid/view/animation/Transformation;)Z", AccessFlags = 1)]
				public override bool GetTransformation(long int64, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// scaleCurrentDuration
				/// </java-name>
				[Dot42.DexImport("scaleCurrentDuration", "(F)V", AccessFlags = 1)]
				public override void ScaleCurrentDuration(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public override void Initialize(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// willChangeTransformationMatrix
				/// </java-name>
				[Dot42.DexImport("willChangeTransformationMatrix", "()Z", AccessFlags = 1)]
				public override bool WillChangeTransformationMatrix() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// willChangeBounds
				/// </java-name>
				[Dot42.DexImport("willChangeBounds", "()Z", AccessFlags = 1)]
				public override bool WillChangeBounds() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AnimationSet() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getStartTime
				/// </java-name>
				public override long StartTime
				{
						[Dot42.DexImport("getStartTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setStartTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public override long Duration
				{
						[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setDuration", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAnimations
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Views.Animations.Animation> Animations
				{
						[Dot42.DexImport("getAnimations", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/animation/Animation;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Views.Animations.Animation>); }
				}

				/// <java-name>
				/// setFillAfter
				/// </java-name>
				public override bool IsFillAfter
				{
						[Dot42.DexImport("setFillAfter", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setFillBefore
				/// </java-name>
				public override bool IsFillBefore
				{
						[Dot42.DexImport("setFillBefore", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setRepeatMode
				/// </java-name>
				public override int RepeatMode
				{
						[Dot42.DexImport("setRepeatMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setStartOffset
				/// </java-name>
				public override long StartOffset
				{
						[Dot42.DexImport("setStartOffset", "(J)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/view/animation/AnimationUtils
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AnimationUtils", AccessFlags = 33)]
		public partial class AnimationUtils
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnimationUtils() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// currentAnimationTimeMillis
				/// </java-name>
				[Dot42.DexImport("currentAnimationTimeMillis", "()J", AccessFlags = 9)]
				public static long CurrentAnimationTimeMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// loadAnimation
				/// </java-name>
				[Dot42.DexImport("loadAnimation", "(Landroid/content/Context;I)Landroid/view/animation/Animation;", AccessFlags = 9)]
				public static global::Android.Views.Animations.Animation LoadAnimation(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.Animation);
				}

				/// <java-name>
				/// loadLayoutAnimation
				/// </java-name>
				[Dot42.DexImport("loadLayoutAnimation", "(Landroid/content/Context;I)Landroid/view/animation/LayoutAnimationController;", AccessFlags = 9)]
				public static global::Android.Views.Animations.LayoutAnimationController LoadLayoutAnimation(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.LayoutAnimationController);
				}

				/// <java-name>
				/// makeInAnimation
				/// </java-name>
				[Dot42.DexImport("makeInAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;", AccessFlags = 9)]
				public static global::Android.Views.Animations.Animation MakeInAnimation(global::Android.Content.Context context, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.Animation);
				}

				/// <java-name>
				/// makeOutAnimation
				/// </java-name>
				[Dot42.DexImport("makeOutAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;", AccessFlags = 9)]
				public static global::Android.Views.Animations.Animation MakeOutAnimation(global::Android.Content.Context context, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.Animation);
				}

				/// <java-name>
				/// makeInChildBottomAnimation
				/// </java-name>
				[Dot42.DexImport("makeInChildBottomAnimation", "(Landroid/content/Context;)Landroid/view/animation/Animation;", AccessFlags = 9)]
				public static global::Android.Views.Animations.Animation MakeInChildBottomAnimation(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.Animation);
				}

				/// <java-name>
				/// loadInterpolator
				/// </java-name>
				[Dot42.DexImport("loadInterpolator", "(Landroid/content/Context;I)Landroid/view/animation/Interpolator;", AccessFlags = 9)]
				public static global::Android.Views.Animations.IInterpolator LoadInterpolator(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.IInterpolator);
				}

		}

		/// <java-name>
		/// android/view/animation/AnticipateInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AnticipateInterpolator", AccessFlags = 33)]
		public partial class AnticipateInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnticipateInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public AnticipateInterpolator(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AnticipateInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/view/animation/AnticipateOvershootInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AnticipateOvershootInterpolator", AccessFlags = 33)]
		public partial class AnticipateOvershootInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnticipateOvershootInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public AnticipateOvershootInterpolator(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public AnticipateOvershootInterpolator(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AnticipateOvershootInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/view/animation/BounceInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/BounceInterpolator", AccessFlags = 33)]
		public partial class BounceInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BounceInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public BounceInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/view/animation/CycleInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/CycleInterpolator", AccessFlags = 33)]
		public partial class CycleInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public CycleInterpolator(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CycleInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CycleInterpolator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/view/animation/DecelerateInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/DecelerateInterpolator", AccessFlags = 33)]
		public partial class DecelerateInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DecelerateInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public DecelerateInterpolator(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DecelerateInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/view/animation/GridLayoutAnimationController
		/// </java-name>
		[Dot42.DexImport("android/view/animation/GridLayoutAnimationController", AccessFlags = 33)]
		public partial class GridLayoutAnimationController : global::Android.Views.Animations.LayoutAnimationController
 /* scope: __dot42__ */ 
		{
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
				/// <java-name>
				/// DIRECTION_TOP_TO_BOTTOM
				/// </java-name>
				[Dot42.DexImport("DIRECTION_TOP_TO_BOTTOM", "I", AccessFlags = 25)]
				public const int DIRECTION_TOP_TO_BOTTOM = 0;
				/// <java-name>
				/// DIRECTION_BOTTOM_TO_TOP
				/// </java-name>
				[Dot42.DexImport("DIRECTION_BOTTOM_TO_TOP", "I", AccessFlags = 25)]
				public const int DIRECTION_BOTTOM_TO_TOP = 2;
				/// <java-name>
				/// DIRECTION_HORIZONTAL_MASK
				/// </java-name>
				[Dot42.DexImport("DIRECTION_HORIZONTAL_MASK", "I", AccessFlags = 25)]
				public const int DIRECTION_HORIZONTAL_MASK = 1;
				/// <java-name>
				/// DIRECTION_VERTICAL_MASK
				/// </java-name>
				[Dot42.DexImport("DIRECTION_VERTICAL_MASK", "I", AccessFlags = 25)]
				public const int DIRECTION_VERTICAL_MASK = 2;
				/// <java-name>
				/// PRIORITY_NONE
				/// </java-name>
				[Dot42.DexImport("PRIORITY_NONE", "I", AccessFlags = 25)]
				public const int PRIORITY_NONE = 0;
				/// <java-name>
				/// PRIORITY_COLUMN
				/// </java-name>
				[Dot42.DexImport("PRIORITY_COLUMN", "I", AccessFlags = 25)]
				public const int PRIORITY_COLUMN = 1;
				/// <java-name>
				/// PRIORITY_ROW
				/// </java-name>
				[Dot42.DexImport("PRIORITY_ROW", "I", AccessFlags = 25)]
				public const int PRIORITY_ROW = 2;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public GridLayoutAnimationController(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public GridLayoutAnimationController(global::Android.Views.Animations.Animation animation) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/animation/Animation;FF)V", AccessFlags = 1)]
				public GridLayoutAnimationController(global::Android.Views.Animations.Animation animation, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// willOverlap
				/// </java-name>
				[Dot42.DexImport("willOverlap", "()Z", AccessFlags = 1)]
				public override bool WillOverlap() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDelayForView
				/// </java-name>
				[Dot42.DexImport("getDelayForView", "(Landroid/view/View;)J", AccessFlags = 4)]
				protected internal override long GetDelayForView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GridLayoutAnimationController() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getColumnDelay
				/// </java-name>
				public virtual float ColumnDelay
				{
						[Dot42.DexImport("getColumnDelay", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setColumnDelay", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRowDelay
				/// </java-name>
				public virtual float RowDelay
				{
						[Dot42.DexImport("getRowDelay", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setRowDelay", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDirection
				/// </java-name>
				public virtual int Direction
				{
						[Dot42.DexImport("getDirection", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDirection", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDirectionPriority
				/// </java-name>
				public virtual int DirectionPriority
				{
						[Dot42.DexImport("getDirectionPriority", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDirectionPriority", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/view/animation/GridLayoutAnimationController$AnimationParameters
				/// </java-name>
				[Dot42.DexImport("android/view/animation/GridLayoutAnimationController$AnimationParameters", AccessFlags = 9)]
				public partial class AnimationParameters : global::Android.Views.Animations.LayoutAnimationController.AnimationParameters
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// column
						/// </java-name>
						[Dot42.DexImport("column", "I", AccessFlags = 1)]
						public int Column;
						/// <java-name>
						/// row
						/// </java-name>
						[Dot42.DexImport("row", "I", AccessFlags = 1)]
						public int Row;
						/// <java-name>
						/// columnsCount
						/// </java-name>
						[Dot42.DexImport("columnsCount", "I", AccessFlags = 1)]
						public int ColumnsCount;
						/// <java-name>
						/// rowsCount
						/// </java-name>
						[Dot42.DexImport("rowsCount", "I", AccessFlags = 1)]
						public int RowsCount;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public AnimationParameters() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/view/animation/Interpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/Interpolator", AccessFlags = 1537)]
		public partial interface IInterpolator : global::Android.Animation.ITimeInterpolator
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/view/animation/LayoutAnimationController
		/// </java-name>
		[Dot42.DexImport("android/view/animation/LayoutAnimationController", AccessFlags = 33)]
		public partial class LayoutAnimationController
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ORDER_NORMAL
				/// </java-name>
				[Dot42.DexImport("ORDER_NORMAL", "I", AccessFlags = 25)]
				public const int ORDER_NORMAL = 0;
				/// <java-name>
				/// ORDER_REVERSE
				/// </java-name>
				[Dot42.DexImport("ORDER_REVERSE", "I", AccessFlags = 25)]
				public const int ORDER_REVERSE = 1;
				/// <java-name>
				/// ORDER_RANDOM
				/// </java-name>
				[Dot42.DexImport("ORDER_RANDOM", "I", AccessFlags = 25)]
				public const int ORDER_RANDOM = 2;
				/// <java-name>
				/// mAnimation
				/// </java-name>
				[Dot42.DexImport("mAnimation", "Landroid/view/animation/Animation;", AccessFlags = 4)]
				protected internal global::Android.Views.Animations.Animation MAnimation;
				/// <java-name>
				/// mRandomizer
				/// </java-name>
				[Dot42.DexImport("mRandomizer", "Ljava/util/Random;", AccessFlags = 4)]
				protected internal global::System.Random MRandomizer;
				/// <java-name>
				/// mInterpolator
				/// </java-name>
				[Dot42.DexImport("mInterpolator", "Landroid/view/animation/Interpolator;", AccessFlags = 4)]
				protected internal global::Android.Views.Animations.IInterpolator MInterpolator;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public LayoutAnimationController(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public LayoutAnimationController(global::Android.Views.Animations.Animation animation) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/animation/Animation;F)V", AccessFlags = 1)]
				public LayoutAnimationController(global::Android.Views.Animations.Animation animation, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAnimation
				/// </java-name>
				[Dot42.DexImport("setAnimation", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetAnimation(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// willOverlap
				/// </java-name>
				[Dot42.DexImport("willOverlap", "()Z", AccessFlags = 1)]
				public virtual bool WillOverlap() /* MethodBuilder.Create */ 
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
				/// getAnimationForView
				/// </java-name>
				[Dot42.DexImport("getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;", AccessFlags = 17)]
				public global::Android.Views.Animations.Animation GetAnimationForView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Animations.Animation);
				}

				/// <java-name>
				/// getDelayForView
				/// </java-name>
				[Dot42.DexImport("getDelayForView", "(Landroid/view/View;)J", AccessFlags = 4)]
				protected internal virtual long GetDelayForView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getTransformedIndex
				/// </java-name>
				[Dot42.DexImport("getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I", AccessFlags = 4)]
				protected internal virtual int GetTransformedIndex(global::Android.Views.Animations.LayoutAnimationController.AnimationParameters animationParameters) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LayoutAnimationController() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getOrder
				/// </java-name>
				public virtual int Order
				{
						[Dot42.DexImport("getOrder", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setOrder", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAnimation
				/// </java-name>
				public virtual global::Android.Views.Animations.Animation Animation
				{
						[Dot42.DexImport("getAnimation", "()Landroid/view/animation/Animation;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.Animation); }
						[Dot42.DexImport("setAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public virtual global::Android.Views.Animations.IInterpolator Interpolator
				{
						[Dot42.DexImport("getInterpolator", "()Landroid/view/animation/Interpolator;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.IInterpolator); }
						[Dot42.DexImport("setInterpolator", "(Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDelay
				/// </java-name>
				public virtual float Delay
				{
						[Dot42.DexImport("getDelay", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setDelay", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isDone
				/// </java-name>
				public virtual bool IsDone
				{
						[Dot42.DexImport("isDone", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/view/animation/LayoutAnimationController$AnimationParameters
				/// </java-name>
				[Dot42.DexImport("android/view/animation/LayoutAnimationController$AnimationParameters", AccessFlags = 9)]
				public partial class AnimationParameters
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// count
						/// </java-name>
						[Dot42.DexImport("count", "I", AccessFlags = 1)]
						public int Count;
						/// <java-name>
						/// index
						/// </java-name>
						[Dot42.DexImport("index", "I", AccessFlags = 1)]
						public int Index;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public AnimationParameters() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/view/animation/LinearInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/LinearInterpolator", AccessFlags = 33)]
		public partial class LinearInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinearInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public LinearInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/view/animation/OvershootInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/OvershootInterpolator", AccessFlags = 33)]
		public partial class OvershootInterpolator : global::Android.Views.Animations.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OvershootInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public OvershootInterpolator(float single) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public OvershootInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <java-name>
		/// android/view/animation/RotateAnimation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/RotateAnimation", AccessFlags = 33)]
		public partial class RotateAnimation : global::Android.Views.Animations.Animation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RotateAnimation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public RotateAnimation(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public RotateAnimation(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFIFIF)V", AccessFlags = 1)]
				public RotateAnimation(float single, float single1, int int32, float single2, int int321, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal override void ApplyTransformation(float single, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public override void Initialize(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RotateAnimation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/view/animation/ScaleAnimation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/ScaleAnimation", AccessFlags = 33)]
		public partial class ScaleAnimation : global::Android.Views.Animations.Animation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ScaleAnimation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public ScaleAnimation(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFFFF)V", AccessFlags = 1)]
				public ScaleAnimation(float single, float single1, float single2, float single3, float single4, float single5) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFFIFIF)V", AccessFlags = 1)]
				public ScaleAnimation(float single, float single1, float single2, float single3, int int32, float single4, int int321, float single5) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal override void ApplyTransformation(float single, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public override void Initialize(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScaleAnimation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/view/animation/Transformation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/Transformation", AccessFlags = 33)]
		public partial class Transformation
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TYPE_IDENTITY
				/// </java-name>
				[Dot42.DexImport("TYPE_IDENTITY", "I", AccessFlags = 9)]
				public static int TYPE_IDENTITY;
				/// <java-name>
				/// TYPE_ALPHA
				/// </java-name>
				[Dot42.DexImport("TYPE_ALPHA", "I", AccessFlags = 9)]
				public static int TYPE_ALPHA;
				/// <java-name>
				/// TYPE_MATRIX
				/// </java-name>
				[Dot42.DexImport("TYPE_MATRIX", "I", AccessFlags = 9)]
				public static int TYPE_MATRIX;
				/// <java-name>
				/// TYPE_BOTH
				/// </java-name>
				[Dot42.DexImport("TYPE_BOTH", "I", AccessFlags = 9)]
				public static int TYPE_BOTH;
				/// <java-name>
				/// mMatrix
				/// </java-name>
				[Dot42.DexImport("mMatrix", "Landroid/graphics/Matrix;", AccessFlags = 4)]
				protected internal global::Android.Graphics.Matrix MMatrix;
				/// <java-name>
				/// mAlpha
				/// </java-name>
				[Dot42.DexImport("mAlpha", "F", AccessFlags = 4)]
				protected internal float MAlpha;
				/// <java-name>
				/// mTransformationType
				/// </java-name>
				[Dot42.DexImport("mTransformationType", "I", AccessFlags = 4)]
				protected internal int MTransformationType;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Transformation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/view/animation/Transformation;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compose
				/// </java-name>
				[Dot42.DexImport("compose", "(Landroid/view/animation/Transformation;)V", AccessFlags = 1)]
				public virtual void Compose(global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
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
				/// toShortString
				/// </java-name>
				[Dot42.DexImport("toShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTransformationType
				/// </java-name>
				public virtual int TransformationType
				{
						[Dot42.DexImport("getTransformationType", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setTransformationType", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMatrix
				/// </java-name>
				public virtual global::Android.Graphics.Matrix Matrix
				{
						[Dot42.DexImport("getMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Matrix); }
				}

				/// <java-name>
				/// getAlpha
				/// </java-name>
				public virtual float Alpha
				{
						[Dot42.DexImport("getAlpha", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setAlpha", "(F)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/view/animation/TranslateAnimation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/TranslateAnimation", AccessFlags = 33)]
		public partial class TranslateAnimation : global::Android.Views.Animations.Animation
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TranslateAnimation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public TranslateAnimation(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IFIFIFIF)V", AccessFlags = 1)]
				public TranslateAnimation(int int32, float single, int int321, float single1, int int322, float single2, int int323, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal override void ApplyTransformation(float single, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public override void Initialize(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TranslateAnimation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

}

