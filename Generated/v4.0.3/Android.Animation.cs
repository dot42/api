#pragma warning disable 1717
namespace Android.Animation
{
		/// <java-name>
		/// android/animation/Animator
		/// </java-name>
		[Dot42.DexImport("android/animation/Animator", AccessFlags = 1057)]
		public abstract partial class Animator : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Animator() /* MethodBuilder.Create */ 
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
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 1)]
				public virtual void End() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/animation/Animator;", AccessFlags = 1025)]
				public abstract global::Android.Animation.Animator SetDuration(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1025)]
				public abstract void SetInterpolator(global::Android.Animation.ITimeInterpolator timeInterpolator) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addListener
				/// </java-name>
				[Dot42.DexImport("addListener", "(Landroid/animation/Animator$AnimatorListener;)V", AccessFlags = 1)]
				public virtual void AddListener(global::Android.Animation.Animator.IAnimatorListener animatorListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeListener
				/// </java-name>
				[Dot42.DexImport("removeListener", "(Landroid/animation/Animator$AnimatorListener;)V", AccessFlags = 1)]
				public virtual void RemoveListener(global::Android.Animation.Animator.IAnimatorListener animatorListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllListeners
				/// </java-name>
				[Dot42.DexImport("removeAllListeners", "()V", AccessFlags = 1)]
				public virtual void RemoveAllListeners() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// setupStartValues
				/// </java-name>
				[Dot42.DexImport("setupStartValues", "()V", AccessFlags = 1)]
				public virtual void SetupStartValues() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setupEndValues
				/// </java-name>
				[Dot42.DexImport("setupEndValues", "()V", AccessFlags = 1)]
				public virtual void SetupEndValues() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTarget
				/// </java-name>
				[Dot42.DexImport("setTarget", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetTarget(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public abstract long StartDelay
				{
						[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public abstract long Duration
				{
						[Dot42.DexImport("getDuration", "()J", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isRunning
				/// </java-name>
				public abstract bool IsRunning
				{
						[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isStarted
				/// </java-name>
				public virtual bool IsStarted
				{
						[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getListeners
				/// </java-name>
				public virtual global::Java.Util.ArrayList<global::Android.Animation.Animator.IAnimatorListener> Listeners
				{
						[Dot42.DexImport("getListeners", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/animation/Animator$AnimatorListener;>;")]
						get{ return default(global::Java.Util.ArrayList<global::Android.Animation.Animator.IAnimatorListener>); }
				}

				/// <java-name>
				/// android/animation/Animator$AnimatorListener
				/// </java-name>
				[Dot42.DexImport("android/animation/Animator$AnimatorListener", AccessFlags = 1545)]
				public partial interface IAnimatorListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onAnimationStart
						/// </java-name>
						[Dot42.DexImport("onAnimationStart", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationStart(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onAnimationEnd
						/// </java-name>
						[Dot42.DexImport("onAnimationEnd", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationEnd(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onAnimationCancel
						/// </java-name>
						[Dot42.DexImport("onAnimationCancel", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationCancel(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onAnimationRepeat
						/// </java-name>
						[Dot42.DexImport("onAnimationRepeat", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationRepeat(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/animation/AnimatorInflater
		/// </java-name>
		[Dot42.DexImport("android/animation/AnimatorInflater", AccessFlags = 33)]
		public partial class AnimatorInflater
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnimatorInflater() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadAnimator
				/// </java-name>
				[Dot42.DexImport("loadAnimator", "(Landroid/content/Context;I)Landroid/animation/Animator;", AccessFlags = 9)]
				public static global::Android.Animation.Animator LoadAnimator(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

		}

		/// <java-name>
		/// android/animation/AnimatorListenerAdapter
		/// </java-name>
		[Dot42.DexImport("android/animation/AnimatorListenerAdapter", AccessFlags = 1057)]
		public abstract partial class AnimatorListenerAdapter : global::Android.Animation.Animator.IAnimatorListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnimatorListenerAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationCancel
				/// </java-name>
				[Dot42.DexImport("onAnimationCancel", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationCancel(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationEnd
				/// </java-name>
				[Dot42.DexImport("onAnimationEnd", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationEnd(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationRepeat
				/// </java-name>
				[Dot42.DexImport("onAnimationRepeat", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationRepeat(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationStart
				/// </java-name>
				[Dot42.DexImport("onAnimationStart", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationStart(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/animation/AnimatorSet
		/// </java-name>
		[Dot42.DexImport("android/animation/AnimatorSet", AccessFlags = 49)]
		public sealed partial class AnimatorSet : global::Android.Animation.Animator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnimatorSet() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// playTogether
				/// </java-name>
				[Dot42.DexImport("playTogether", "([Landroid/animation/Animator;)V", AccessFlags = 129)]
				public void PlayTogether(params global::Android.Animation.Animator[] animator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// playTogether
				/// </java-name>
				[Dot42.DexImport("playTogether", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Landroid/animation/Animator;>;)V")]
				public void PlayTogether(global::Java.Util.ICollection<global::Android.Animation.Animator> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// playSequentially
				/// </java-name>
				[Dot42.DexImport("playSequentially", "([Landroid/animation/Animator;)V", AccessFlags = 129)]
				public void PlaySequentially(params global::Android.Animation.Animator[] animator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// playSequentially
				/// </java-name>
				[Dot42.DexImport("playSequentially", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/animation/Animator;>;)V")]
				public void PlaySequentially(global::Java.Util.IList<global::Android.Animation.Animator> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTarget
				/// </java-name>
				[Dot42.DexImport("setTarget", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public override void SetTarget(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
				public override void SetInterpolator(global::Android.Animation.ITimeInterpolator timeInterpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
				public global::Android.Animation.AnimatorSet.Builder Play(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.AnimatorSet.Builder);
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public override void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 1)]
				public override void End() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/animation/AnimatorSet;", AccessFlags = 1)]
				public override global::Android.Animation.Animator SetDuration(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// setupStartValues
				/// </java-name>
				[Dot42.DexImport("setupStartValues", "()V", AccessFlags = 1)]
				public override void SetupStartValues() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setupEndValues
				/// </java-name>
				[Dot42.DexImport("setupEndValues", "()V", AccessFlags = 1)]
				public override void SetupEndValues() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public override void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/animation/AnimatorSet;", AccessFlags = 1)]
				public new global::Android.Animation.AnimatorSet Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.AnimatorSet);
				}

				/// <java-name>
				/// getChildAnimations
				/// </java-name>
				public global::Java.Util.ArrayList<global::Android.Animation.Animator> ChildAnimations
				{
						[Dot42.DexImport("getChildAnimations", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/animation/Animator;>;")]
						get{ return default(global::Java.Util.ArrayList<global::Android.Animation.Animator>); }
				}

				/// <java-name>
				/// isRunning
				/// </java-name>
				public override bool IsRunning
				{
						[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isStarted
				/// </java-name>
				public override bool IsStarted
				{
						[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public override long StartDelay
				{
						[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public override long Duration
				{
						[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// android/animation/AnimatorSet$Builder
				/// </java-name>
				[Dot42.DexImport("android/animation/AnimatorSet$Builder", AccessFlags = 1)]
				public partial class Builder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/animation/AnimatorSet;", AccessFlags = 4112)]
						internal readonly global::Android.Animation.AnimatorSet This_0;
						[Dot42.DexImport("<init>", "(Landroid/animation/AnimatorSet;)V", AccessFlags = 0)]
						internal Builder(global::Android.Animation.AnimatorSet animatorSet) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// with
						/// </java-name>
						[Dot42.DexImport("with", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
						public virtual Builder With(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// before
						/// </java-name>
						[Dot42.DexImport("before", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
						public virtual Builder Before(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// after
						/// </java-name>
						[Dot42.DexImport("after", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
						public virtual Builder After(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <java-name>
						/// after
						/// </java-name>
						[Dot42.DexImport("after", "(J)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
						public virtual Builder After(long int64) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/animation/ArgbEvaluator
		/// </java-name>
		[Dot42.DexImport("android/animation/ArgbEvaluator", AccessFlags = 33)]
		public partial class ArgbEvaluator : global::Android.Animation.ITypeEvaluator<object>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArgbEvaluator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Evaluate(float single, object @object, object object1) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <java-name>
		/// android/animation/FloatEvaluator
		/// </java-name>
		[Dot42.DexImport("android/animation/FloatEvaluator", AccessFlags = 33, Signature = "Ljava/lang/Object;Landroid/animation/TypeEvaluator<Ljava/lang/Number;>;")]
		public partial class FloatEvaluator : global::Android.Animation.ITypeEvaluator<global::Java.Lang.Number>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public FloatEvaluator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLjava/lang/Number;Ljava/lang/Number;)Ljava/lang/Float;", AccessFlags = 1)]
				public virtual float? Evaluate(float single, global::Java.Lang.Number number, global::Java.Lang.Number number1) /* MethodBuilder.Create */ 
				{
						return default(float?);
				}

				[Dot42.DexImport("android/animation/TypeEvaluator", "evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(FTT;TT;)TT;")]
				global::Java.Lang.Number global::Android.Animation.ITypeEvaluator<global::Java.Lang.Number>.Evaluate(float single, global::Java.Lang.Number t, global::Java.Lang.Number t1) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.Number);
				}

		}

		/// <java-name>
		/// android/animation/IntEvaluator
		/// </java-name>
		[Dot42.DexImport("android/animation/IntEvaluator", AccessFlags = 33, Signature = "Ljava/lang/Object;Landroid/animation/TypeEvaluator<Ljava/lang/Integer;>;")]
		public partial class IntEvaluator : global::Android.Animation.ITypeEvaluator<int?>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IntEvaluator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLjava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Integer;", AccessFlags = 1)]
				public virtual int? Evaluate(float single, int? int32, int? int321) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

		}

		/// <java-name>
		/// android/animation/TimeInterpolator
		/// </java-name>
		[Dot42.DexImport("android/animation/TimeInterpolator", AccessFlags = 1537)]
		public partial interface ITimeInterpolator
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1025)]
				float GetInterpolation(float single) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/animation/TypeEvaluator
		/// </java-name>
		[Dot42.DexImport("android/animation/TypeEvaluator", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface ITypeEvaluator<T>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(FTT;TT;)TT;")]
				T Evaluate(float single, T t, T t1) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/animation/Keyframe
		/// </java-name>
		[Dot42.DexImport("android/animation/Keyframe", AccessFlags = 1057)]
		public abstract partial class Keyframe : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Keyframe() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "(FI)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfInt(float single, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "(F)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfInt(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "(FF)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfFloat(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "(F)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfFloat(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(FLjava/lang/Object;)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfObject(float single, object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(F)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfObject(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/animation/Keyframe;", AccessFlags = 1025)]
				public abstract global::Android.Animation.Keyframe Clone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasValue
				/// </java-name>
				public virtual bool HasValue
				{
						[Dot42.DexImport("hasValue", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public abstract object Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setValue", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getFraction
				/// </java-name>
				public virtual float Fraction
				{
						[Dot42.DexImport("getFraction", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setFraction", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public virtual global::Android.Animation.ITimeInterpolator Interpolator
				{
						[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
						get{ return default(global::Android.Animation.ITimeInterpolator); }
						[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public virtual global::System.Type Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1)]
						get{ return default(global::System.Type); }
				}

		}

		/// <java-name>
		/// android/animation/LayoutTransition
		/// </java-name>
		[Dot42.DexImport("android/animation/LayoutTransition", AccessFlags = 33)]
		public partial class LayoutTransition
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CHANGE_APPEARING
				/// </java-name>
				[Dot42.DexImport("CHANGE_APPEARING", "I", AccessFlags = 25)]
				public const int CHANGE_APPEARING = 0;
				/// <java-name>
				/// CHANGE_DISAPPEARING
				/// </java-name>
				[Dot42.DexImport("CHANGE_DISAPPEARING", "I", AccessFlags = 25)]
				public const int CHANGE_DISAPPEARING = 1;
				/// <java-name>
				/// APPEARING
				/// </java-name>
				[Dot42.DexImport("APPEARING", "I", AccessFlags = 25)]
				public const int APPEARING = 2;
				/// <java-name>
				/// DISAPPEARING
				/// </java-name>
				[Dot42.DexImport("DISAPPEARING", "I", AccessFlags = 25)]
				public const int DISAPPEARING = 3;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LayoutTransition() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)V", AccessFlags = 1)]
				public virtual void SetDuration(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(IJ)V", AccessFlags = 1)]
				public virtual void SetStartDelay(int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStartDelay
				/// </java-name>
				[Dot42.DexImport("getStartDelay", "(I)J", AccessFlags = 1)]
				public virtual long GetStartDelay(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(IJ)V", AccessFlags = 1)]
				public virtual void SetDuration(int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "(I)J", AccessFlags = 1)]
				public virtual long GetDuration(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setStagger
				/// </java-name>
				[Dot42.DexImport("setStagger", "(IJ)V", AccessFlags = 1)]
				public virtual void SetStagger(int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getStagger
				/// </java-name>
				[Dot42.DexImport("getStagger", "(I)J", AccessFlags = 1)]
				public virtual long GetStagger(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(ILandroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
				public virtual void SetInterpolator(int int32, global::Android.Animation.ITimeInterpolator timeInterpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "(I)Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
				public virtual global::Android.Animation.ITimeInterpolator GetInterpolator(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ITimeInterpolator);
				}

				/// <java-name>
				/// setAnimator
				/// </java-name>
				[Dot42.DexImport("setAnimator", "(ILandroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void SetAnimator(int int32, global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAnimator
				/// </java-name>
				[Dot42.DexImport("getAnimator", "(I)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator GetAnimator(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// setAnimateParentHierarchy
				/// </java-name>
				[Dot42.DexImport("setAnimateParentHierarchy", "(Z)V", AccessFlags = 1)]
				public virtual void SetAnimateParentHierarchy(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addChild
				/// </java-name>
				[Dot42.DexImport("addChild", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddChild(global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showChild
				/// </java-name>
				[Dot42.DexImport("showChild", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void ShowChild(global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeChild
				/// </java-name>
				[Dot42.DexImport("removeChild", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RemoveChild(global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hideChild
				/// </java-name>
				[Dot42.DexImport("hideChild", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void HideChild(global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addTransitionListener
				/// </java-name>
				[Dot42.DexImport("addTransitionListener", "(Landroid/animation/LayoutTransition$TransitionListener;)V", AccessFlags = 1)]
				public virtual void AddTransitionListener(global::Android.Animation.LayoutTransition.ITransitionListener transitionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeTransitionListener
				/// </java-name>
				[Dot42.DexImport("removeTransitionListener", "(Landroid/animation/LayoutTransition$TransitionListener;)V", AccessFlags = 1)]
				public virtual void RemoveTransitionListener(global::Android.Animation.LayoutTransition.ITransitionListener transitionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isChangingLayout
				/// </java-name>
				public virtual bool IsChangingLayout
				{
						[Dot42.DexImport("isChangingLayout", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isRunning
				/// </java-name>
				public virtual bool IsRunning
				{
						[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getTransitionListeners
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Animation.LayoutTransition.ITransitionListener> TransitionListeners
				{
						[Dot42.DexImport("getTransitionListeners", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/animation/LayoutTransition$TransitionListener;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Animation.LayoutTransition.ITransitionListener>); }
				}

				/// <java-name>
				/// android/animation/LayoutTransition$TransitionListener
				/// </java-name>
				[Dot42.DexImport("android/animation/LayoutTransition$TransitionListener", AccessFlags = 1545)]
				public partial interface ITransitionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// startTransition
						/// </java-name>
						[Dot42.DexImport("startTransition", "(Landroid/animation/LayoutTransition;Landroid/view/ViewGroup;Landroid/view/View;I" +
    ")V", AccessFlags = 1025)]
						void StartTransition(global::Android.Animation.LayoutTransition layoutTransition, global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// endTransition
						/// </java-name>
						[Dot42.DexImport("endTransition", "(Landroid/animation/LayoutTransition;Landroid/view/ViewGroup;Landroid/view/View;I" +
    ")V", AccessFlags = 1025)]
						void EndTransition(global::Android.Animation.LayoutTransition layoutTransition, global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view, int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/animation/ObjectAnimator
		/// </java-name>
		[Dot42.DexImport("android/animation/ObjectAnimator", AccessFlags = 49)]
		public sealed partial class ObjectAnimator : global::Android.Animation.ValueAnimator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ObjectAnimator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Landroid/util/Property;)V", AccessFlags = 1)]
				public void SetProperty(global::Android.Util.Property<object, object> property) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "(Ljava/lang/Object;Ljava/lang/String;[I)Landroid/animation/ObjectAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ObjectAnimator OfInt(object @object, string @string, params int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "(Ljava/lang/Object;Landroid/util/Property;[I)Landroid/animation/ObjectAnimator;", AccessFlags = 137, Signature = "<T:Ljava/lang/Object;>(TT;Landroid/util/Property<TT;Ljava/lang/Integer;>;[I)Landr" +
    "oid/animation/ObjectAnimator;")]
				public static global::Android.Animation.ObjectAnimator OfInt<T>(T t, global::Android.Util.Property<T, int?> property, params int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "(Ljava/lang/Object;Ljava/lang/String;[F)Landroid/animation/ObjectAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ObjectAnimator OfFloat(object @object, string @string, params float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "(Ljava/lang/Object;Landroid/util/Property;[F)Landroid/animation/ObjectAnimator;", AccessFlags = 137, Signature = "<T:Ljava/lang/Object;>(TT;Landroid/util/Property<TT;Ljava/lang/Float;>;[F)Landroi" +
    "d/animation/ObjectAnimator;")]
				public static global::Android.Animation.ObjectAnimator OfFloat<T>(T t, global::Android.Util.Property<T, float?> property, params float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(Ljava/lang/Object;Ljava/lang/String;Landroid/animation/TypeEvaluator;[Ljava/lang" +
    "/Object;)Landroid/animation/ObjectAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ObjectAnimator OfObject(object @object, string @string, global::Android.Animation.ITypeEvaluator<object> typeEvaluator, params object[] object1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(Ljava/lang/Object;Landroid/util/Property;Landroid/animation/TypeEvaluator;[Ljava" +
    "/lang/Object;)Landroid/animation/ObjectAnimator;", AccessFlags = 137, Signature = "<T:Ljava/lang/Object;V:Ljava/lang/Object;>(TT;Landroid/util/Property<TT;TV;>;Land" +
    "roid/animation/TypeEvaluator<TV;>;[TV;)Landroid/animation/ObjectAnimator;")]
				public static global::Android.Animation.ObjectAnimator OfObject<T, V>(T t, global::Android.Util.Property<T, V> property, global::Android.Animation.ITypeEvaluator<V> typeEvaluator, params V[] p) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <java-name>
				/// ofPropertyValuesHolder
				/// </java-name>
				[Dot42.DexImport("ofPropertyValuesHolder", "(Ljava/lang/Object;[Landroid/animation/PropertyValuesHolder;)Landroid/animation/O" +
    "bjectAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ObjectAnimator OfPropertyValuesHolder(object @object, params global::Android.Animation.PropertyValuesHolder[] propertyValuesHolder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <java-name>
				/// setIntValues
				/// </java-name>
				[Dot42.DexImport("setIntValues", "([I)V", AccessFlags = 129)]
				public override void SetIntValues(params int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFloatValues
				/// </java-name>
				[Dot42.DexImport("setFloatValues", "([F)V", AccessFlags = 129)]
				public override void SetFloatValues(params float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setObjectValues
				/// </java-name>
				[Dot42.DexImport("setObjectValues", "([Ljava/lang/Object;)V", AccessFlags = 129)]
				public override void SetObjectValues(params object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public override void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/animation/ObjectAnimator;", AccessFlags = 1)]
				public new global::Android.Animation.ObjectAnimator SetDuration(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <java-name>
				/// getTarget
				/// </java-name>
				[Dot42.DexImport("getTarget", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object GetTarget() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setTarget
				/// </java-name>
				[Dot42.DexImport("setTarget", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public override void SetTarget(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setupStartValues
				/// </java-name>
				[Dot42.DexImport("setupStartValues", "()V", AccessFlags = 1)]
				public override void SetupStartValues() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setupEndValues
				/// </java-name>
				[Dot42.DexImport("setupEndValues", "()V", AccessFlags = 1)]
				public override void SetupEndValues() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/animation/ObjectAnimator;", AccessFlags = 1)]
				public new global::Android.Animation.ObjectAnimator Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
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
				/// getPropertyName
				/// </java-name>
				public string PropertyName
				{
						[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPropertyName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/animation/PropertyValuesHolder
		/// </java-name>
		[Dot42.DexImport("android/animation/PropertyValuesHolder", AccessFlags = 33)]
		public partial class PropertyValuesHolder : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PropertyValuesHolder() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "(Ljava/lang/String;[I)Landroid/animation/PropertyValuesHolder;", AccessFlags = 137)]
				public static global::Android.Animation.PropertyValuesHolder OfInt(string @string, params int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "(Landroid/util/Property;[I)Landroid/animation/PropertyValuesHolder;", AccessFlags = 137, Signature = "(Landroid/util/Property<*Ljava/lang/Integer;>;[I)Landroid/animation/PropertyValue" +
    "sHolder;")]
				public static global::Android.Animation.PropertyValuesHolder OfInt(global::Android.Util.Property<object, int?> property, params int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "(Ljava/lang/String;[F)Landroid/animation/PropertyValuesHolder;", AccessFlags = 137)]
				public static global::Android.Animation.PropertyValuesHolder OfFloat(string @string, params float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "(Landroid/util/Property;[F)Landroid/animation/PropertyValuesHolder;", AccessFlags = 137, Signature = "(Landroid/util/Property<*Ljava/lang/Float;>;[F)Landroid/animation/PropertyValuesH" +
    "older;")]
				public static global::Android.Animation.PropertyValuesHolder OfFloat(global::Android.Util.Property<object, float?> property, params float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(Ljava/lang/String;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/" +
    "animation/PropertyValuesHolder;", AccessFlags = 137)]
				public static global::Android.Animation.PropertyValuesHolder OfObject(string @string, global::Android.Animation.ITypeEvaluator<object> typeEvaluator, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(Landroid/util/Property;Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Land" +
    "roid/animation/PropertyValuesHolder;", AccessFlags = 137, Signature = "<V:Ljava/lang/Object;>(Landroid/util/Property;Landroid/animation/TypeEvaluator<TV" +
    ";>;[TV;)Landroid/animation/PropertyValuesHolder;")]
				public static global::Android.Animation.PropertyValuesHolder OfObject<V>(global::Android.Util.Property<object, object> property, global::Android.Animation.ITypeEvaluator<V> typeEvaluator, params V[] p) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// ofKeyframe
				/// </java-name>
				[Dot42.DexImport("ofKeyframe", "(Ljava/lang/String;[Landroid/animation/Keyframe;)Landroid/animation/PropertyValue" +
    "sHolder;", AccessFlags = 137)]
				public static global::Android.Animation.PropertyValuesHolder OfKeyframe(string @string, params global::Android.Animation.Keyframe[] keyframe) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// ofKeyframe
				/// </java-name>
				[Dot42.DexImport("ofKeyframe", "(Landroid/util/Property;[Landroid/animation/Keyframe;)Landroid/animation/Property" +
    "ValuesHolder;", AccessFlags = 137)]
				public static global::Android.Animation.PropertyValuesHolder OfKeyframe(global::Android.Util.Property<object, object> property, params global::Android.Animation.Keyframe[] keyframe) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// setIntValues
				/// </java-name>
				[Dot42.DexImport("setIntValues", "([I)V", AccessFlags = 129)]
				public virtual void SetIntValues(params int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFloatValues
				/// </java-name>
				[Dot42.DexImport("setFloatValues", "([F)V", AccessFlags = 129)]
				public virtual void SetFloatValues(params float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setKeyframes
				/// </java-name>
				[Dot42.DexImport("setKeyframes", "([Landroid/animation/Keyframe;)V", AccessFlags = 129)]
				public virtual void SetKeyframes(params global::Android.Animation.Keyframe[] keyframe) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setObjectValues
				/// </java-name>
				[Dot42.DexImport("setObjectValues", "([Ljava/lang/Object;)V", AccessFlags = 129)]
				public virtual void SetObjectValues(params object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/animation/PropertyValuesHolder;", AccessFlags = 1)]
				public virtual global::Android.Animation.PropertyValuesHolder Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder);
				}

				/// <java-name>
				/// setEvaluator
				/// </java-name>
				[Dot42.DexImport("setEvaluator", "(Landroid/animation/TypeEvaluator;)V", AccessFlags = 1)]
				public virtual void SetEvaluator(global::Android.Animation.ITypeEvaluator<object> typeEvaluator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Landroid/util/Property;)V", AccessFlags = 1)]
				public virtual void SetProperty(global::Android.Util.Property<object, object> property) /* MethodBuilder.Create */ 
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
				/// getPropertyName
				/// </java-name>
				public virtual string PropertyName
				{
						[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPropertyName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/animation/ValueAnimator
		/// </java-name>
		[Dot42.DexImport("android/animation/ValueAnimator", AccessFlags = 33)]
		public partial class ValueAnimator : global::Android.Animation.Animator
 /* scope: __dot42__ */ 
		{
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
				/// INFINITE
				/// </java-name>
				[Dot42.DexImport("INFINITE", "I", AccessFlags = 25)]
				public const int INFINITE = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ValueAnimator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "([I)Landroid/animation/ValueAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ValueAnimator OfInt(params int[] int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
				}

				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "([F)Landroid/animation/ValueAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ValueAnimator OfFloat(params float[] single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
				}

				/// <java-name>
				/// ofPropertyValuesHolder
				/// </java-name>
				[Dot42.DexImport("ofPropertyValuesHolder", "([Landroid/animation/PropertyValuesHolder;)Landroid/animation/ValueAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ValueAnimator OfPropertyValuesHolder(params global::Android.Animation.PropertyValuesHolder[] propertyValuesHolder) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
				}

				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ValueAni" +
    "mator;", AccessFlags = 137)]
				public static global::Android.Animation.ValueAnimator OfObject(global::Android.Animation.ITypeEvaluator<object> typeEvaluator, params object[] @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
				}

				/// <java-name>
				/// setIntValues
				/// </java-name>
				[Dot42.DexImport("setIntValues", "([I)V", AccessFlags = 129)]
				public virtual void SetIntValues(params int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFloatValues
				/// </java-name>
				[Dot42.DexImport("setFloatValues", "([F)V", AccessFlags = 129)]
				public virtual void SetFloatValues(params float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setObjectValues
				/// </java-name>
				[Dot42.DexImport("setObjectValues", "([Ljava/lang/Object;)V", AccessFlags = 129)]
				public virtual void SetObjectValues(params object[] @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/animation/ValueAnimator;", AccessFlags = 1)]
				public override global::Android.Animation.Animator SetDuration(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// getAnimatedValue
				/// </java-name>
				[Dot42.DexImport("getAnimatedValue", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetAnimatedValue(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// addUpdateListener
				/// </java-name>
				[Dot42.DexImport("addUpdateListener", "(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V", AccessFlags = 1)]
				public virtual void AddUpdateListener(global::Android.Animation.ValueAnimator.IAnimatorUpdateListener animatorUpdateListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllUpdateListeners
				/// </java-name>
				[Dot42.DexImport("removeAllUpdateListeners", "()V", AccessFlags = 1)]
				public virtual void RemoveAllUpdateListeners() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeUpdateListener
				/// </java-name>
				[Dot42.DexImport("removeUpdateListener", "(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V", AccessFlags = 1)]
				public virtual void RemoveUpdateListener(global::Android.Animation.ValueAnimator.IAnimatorUpdateListener animatorUpdateListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
				public override void SetInterpolator(global::Android.Animation.ITimeInterpolator timeInterpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
				public virtual global::Android.Animation.ITimeInterpolator GetInterpolator() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ITimeInterpolator);
				}

				/// <java-name>
				/// setEvaluator
				/// </java-name>
				[Dot42.DexImport("setEvaluator", "(Landroid/animation/TypeEvaluator;)V", AccessFlags = 1)]
				public virtual void SetEvaluator(global::Android.Animation.ITypeEvaluator<object> typeEvaluator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public override void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public override void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 1)]
				public override void End() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "()V", AccessFlags = 1)]
				public virtual void Reverse() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/animation/ValueAnimator;", AccessFlags = 1)]
				public new virtual global::Android.Animation.ValueAnimator Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
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
				/// getValues
				/// </java-name>
				public virtual global::Android.Animation.PropertyValuesHolder[] Values
				{
						[Dot42.DexImport("getValues", "()[Landroid/animation/PropertyValuesHolder;", AccessFlags = 1)]
						get{ return default(global::Android.Animation.PropertyValuesHolder[]); }
						[Dot42.DexImport("setValues", "([Landroid/animation/PropertyValuesHolder;)V", AccessFlags = 129)]
						set{ }
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public override long Duration
				{
						[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getCurrentPlayTime
				/// </java-name>
				public virtual long CurrentPlayTime
				{
						[Dot42.DexImport("getCurrentPlayTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setCurrentPlayTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public override long StartDelay
				{
						[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFrameDelay
				/// </java-name>
				public static long FrameDelay
				{
						[Dot42.DexImport("getFrameDelay", "()J", AccessFlags = 9)]
						get{ return default(long); }
						[Dot42.DexImport("setFrameDelay", "(J)V", AccessFlags = 9)]
						set{ }
				}

				/// <java-name>
				/// getAnimatedValue
				/// </java-name>
				public virtual object AnimatedValue
				{
						[Dot42.DexImport("getAnimatedValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
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
				/// isRunning
				/// </java-name>
				public override bool IsRunning
				{
						[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isStarted
				/// </java-name>
				public override bool IsStarted
				{
						[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getAnimatedFraction
				/// </java-name>
				public virtual float AnimatedFraction
				{
						[Dot42.DexImport("getAnimatedFraction", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// android/animation/ValueAnimator$AnimatorUpdateListener
				/// </java-name>
				[Dot42.DexImport("android/animation/ValueAnimator$AnimatorUpdateListener", AccessFlags = 1545)]
				public partial interface IAnimatorUpdateListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onAnimationUpdate
						/// </java-name>
						[Dot42.DexImport("onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V", AccessFlags = 1025)]
						void OnAnimationUpdate(global::Android.Animation.ValueAnimator valueAnimator) /* MethodBuilder.Create */ ;

				}

		}

}

