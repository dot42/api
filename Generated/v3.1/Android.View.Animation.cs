// Copyright (C) 2014 dot42
//
// Original filename: Android.View.Animation.cs
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
namespace Android.View.Animation
{
		/// <summary>
		/// <para>An animation that controls the rotation of an object. This rotation takes place in the X-Y plane. You can specify the point to use for the center of the rotation, where (0,0) is the top left point. If not specified, (0,0) is the default rotation point. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/RotateAnimation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/RotateAnimation", AccessFlags = 33)]
		public partial class RotateAnimation : global::Android.View.Animation.Animation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor used when a RotateAnimation is loaded from a resource.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RotateAnimation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor used when a RotateAnimation is loaded from a resource.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public RotateAnimation(float context, float attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to use when building a RotateAnimation from code</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public RotateAnimation(float fromDegrees, float toDegrees, float pivotX, float pivotY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to use when building a RotateAnimation from code</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFIFIF)V", AccessFlags = 1)]
				public RotateAnimation(float fromDegrees, float toDegrees, int pivotXType, float pivotXValue, int pivotYType, float pivotYValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Helper for getTransformation. Subclasses should implement this to apply their transforms given an interpolation value. Implementations of this method should always replace the specified Transformation or document they are doing otherwise.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal override void ApplyTransformation(float interpolatedTime, global::Android.View.Animation.Transformation t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initialize this animation with the dimensions of the object being animated as well as the objects parents. (This is to support animation sizes being specified relative to these dimensions.)</para><para>Objects that interpret Animations should call this method when the sizes of the object being animated and its parent are known, and before calling getTransformation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public override void Initialize(int width, int height, int parentWidth, int parentHeight) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RotateAnimation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An interpolator where the rate of change starts out quickly and and then decelerates. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/DecelerateInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/DecelerateInterpolator", AccessFlags = 33)]
		public partial class DecelerateInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DecelerateInterpolator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public DecelerateInterpolator(float factor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DecelerateInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>An animation that controls the alpha level of an object. Useful for fading things in and out. This animation ends up changing the alpha property of a Transformation </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/AlphaAnimation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AlphaAnimation", AccessFlags = 33)]
		public partial class AlphaAnimation : global::Android.View.Animation.Animation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor used when an AlphaAnimation is loaded from a resource.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AlphaAnimation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor used when an AlphaAnimation is loaded from a resource.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public AlphaAnimation(float context, float attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Changes the alpha property of the supplied Transformation </para>        
				/// </summary>
				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal override void ApplyTransformation(float interpolatedTime, global::Android.View.Animation.Transformation t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether or not this animation will affect the transformation matrix. For instance, a fade animation will not affect the matrix whereas a scale animation will.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this animation will change the transformation matrix </para>
				/// </returns>
				/// <java-name>
				/// willChangeTransformationMatrix
				/// </java-name>
				[Dot42.DexImport("willChangeTransformationMatrix", "()Z", AccessFlags = 1)]
				public override bool WillChangeTransformationMatrix() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not this animation will affect the bounds of the animated view. For instance, a fade animation will not affect the bounds whereas a 200% scale animation will.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this animation will change the view's bounds </para>
				/// </returns>
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

		/// <summary>
		/// <para>An interpolator where the change flings forward and overshoots the last value then comes back. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/OvershootInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/OvershootInterpolator", AccessFlags = 33)]
		public partial class OvershootInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public OvershootInterpolator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public OvershootInterpolator(float tension) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public OvershootInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>An interpolator where the rate of change starts and ends slowly but accelerates through the middle. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/AccelerateDecelerateInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AccelerateDecelerateInterpolator", AccessFlags = 33)]
		public partial class AccelerateDecelerateInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccelerateDecelerateInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AccelerateDecelerateInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>Abstraction for an Animation that can be applied to Views, Surfaces, or other objects. See the animation package description file. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/Animation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/Animation", AccessFlags = 1057)]
		public abstract partial class Animation : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Repeat the animation indefinitely. </para>        
				/// </summary>
				/// <java-name>
				/// INFINITE
				/// </java-name>
				[Dot42.DexImport("INFINITE", "I", AccessFlags = 25)]
				public const int INFINITE = -1;
				/// <summary>
				/// <para>When the animation reaches the end and the repeat count is INFINTE_REPEAT or a positive value, the animation restarts from the beginning. </para>        
				/// </summary>
				/// <java-name>
				/// RESTART
				/// </java-name>
				[Dot42.DexImport("RESTART", "I", AccessFlags = 25)]
				public const int RESTART = 1;
				/// <summary>
				/// <para>When the animation reaches the end and the repeat count is INFINTE_REPEAT or a positive value, the animation plays backward (and then forward again). </para>        
				/// </summary>
				/// <java-name>
				/// REVERSE
				/// </java-name>
				[Dot42.DexImport("REVERSE", "I", AccessFlags = 25)]
				public const int REVERSE = 2;
				/// <summary>
				/// <para>Can be used as the start time to indicate the start time should be the current time when getTransformation(long, Transformation) is invoked for the first animation frame. This can is useful for short animations. </para>        
				/// </summary>
				/// <java-name>
				/// START_ON_FIRST_FRAME
				/// </java-name>
				[Dot42.DexImport("START_ON_FIRST_FRAME", "I", AccessFlags = 25)]
				public const int START_ON_FIRST_FRAME = -1;
				/// <summary>
				/// <para>The specified dimension is an absolute number of pixels. </para>        
				/// </summary>
				/// <java-name>
				/// ABSOLUTE
				/// </java-name>
				[Dot42.DexImport("ABSOLUTE", "I", AccessFlags = 25)]
				public const int ABSOLUTE = 0;
				/// <summary>
				/// <para>The specified dimension holds a float and should be multiplied by the height or width of the object being animated. </para>        
				/// </summary>
				/// <java-name>
				/// RELATIVE_TO_SELF
				/// </java-name>
				[Dot42.DexImport("RELATIVE_TO_SELF", "I", AccessFlags = 25)]
				public const int RELATIVE_TO_SELF = 1;
				/// <summary>
				/// <para>The specified dimension holds a float and should be multiplied by the height or width of the parent of the object being animated. </para>        
				/// </summary>
				/// <java-name>
				/// RELATIVE_TO_PARENT
				/// </java-name>
				[Dot42.DexImport("RELATIVE_TO_PARENT", "I", AccessFlags = 25)]
				public const int RELATIVE_TO_PARENT = 2;
				/// <summary>
				/// <para>Requests that the content being animated be kept in its current Z order. </para>        
				/// </summary>
				/// <java-name>
				/// ZORDER_NORMAL
				/// </java-name>
				[Dot42.DexImport("ZORDER_NORMAL", "I", AccessFlags = 25)]
				public const int ZORDER_NORMAL = 0;
				/// <summary>
				/// <para>Requests that the content being animated be forced on top of all other content for the duration of the animation. </para>        
				/// </summary>
				/// <java-name>
				/// ZORDER_TOP
				/// </java-name>
				[Dot42.DexImport("ZORDER_TOP", "I", AccessFlags = 25)]
				public const int ZORDER_TOP = 1;
				/// <summary>
				/// <para>Requests that the content being animated be forced under all other content for the duration of the animation. </para>        
				/// </summary>
				/// <java-name>
				/// ZORDER_BOTTOM
				/// </java-name>
				[Dot42.DexImport("ZORDER_BOTTOM", "I", AccessFlags = 25)]
				public const int ZORDER_BOTTOM = -1;
				/// <summary>
				/// <para>Creates a new animation with a duration of 0ms, the default interpolator, with fillBefore set to true and fillAfter set to false </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Animation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new animation whose parameters come from the specified context and attributes set.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Animation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/view/animation/Animation;", AccessFlags = 4)]
				protected internal virtual global::Android.View.Animation.Animation Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.Animation);
				}

				/// <summary>
				/// <para>Reset the initialization state of this animation.</para><para><para>initialize(int, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancel the animation. Cancelling an animation invokes the animation listener, if set, to notify the end of the animation.</para><para>If you cancel an animation manually, you must call reset() before starting the animation again.</para><para><para>reset() </para><simplesectsep></simplesectsep><para>start() </para><simplesectsep></simplesectsep><para>startNow() </para></para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Whether or not the animation has been initialized.</para><para><para>initialize(int, int, int, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Has this animation been initialized. </para>
				/// </returns>
				/// <java-name>
				/// isInitialized
				/// </java-name>
				[Dot42.DexImport("isInitialized", "()Z", AccessFlags = 1)]
				public virtual bool IsInitialized() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Initialize this animation with the dimensions of the object being animated as well as the objects parents. (This is to support animation sizes being specified relative to these dimensions.)</para><para>Objects that interpret Animations should call this method when the sizes of the object being animated and its parent are known, and before calling getTransformation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public virtual void Initialize(int width, int height, int parentWidth, int parentHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the acceleration curve for this animation. The interpolator is loaded as a resource from the specified context.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.Content.Context context, int resID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the acceleration curve for this animation. Defaults to a linear interpolation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.View.Animation.IInterpolator i) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>When this animation should start relative to the start time. This is most useful when composing complex animations using an AnimationSet where some of the animations components start at different times.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartOffset
				/// </java-name>
				[Dot42.DexImport("setStartOffset", "(J)V", AccessFlags = 1)]
				public virtual void SetStartOffset(long startOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>How long this animation should last. The duration cannot be negative.</para><para>ref android.R.styleable::Animation_duration </para>        
				/// </summary>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)V", AccessFlags = 1)]
				public virtual void SetDuration(long durationMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Ensure that the duration that this animation will run is not longer than <b>durationMillis</b>. In addition to adjusting the duration itself, this ensures that the repeat count also will not make it run longer than the given time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// restrictDuration
				/// </java-name>
				[Dot42.DexImport("restrictDuration", "(J)V", AccessFlags = 1)]
				public virtual void RestrictDuration(long durationMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>How much to scale the duration by.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// scaleCurrentDuration
				/// </java-name>
				[Dot42.DexImport("scaleCurrentDuration", "(F)V", AccessFlags = 1)]
				public virtual void ScaleCurrentDuration(float scale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>When this animation should start. When the start time is set to START_ON_FIRST_FRAME, the animation will start the first time getTransformation(long, Transformation) is invoked. The time passed to this method should be obtained by calling AnimationUtils#currentAnimationTimeMillis() instead of System#currentTimeMillis().</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartTime
				/// </java-name>
				[Dot42.DexImport("setStartTime", "(J)V", AccessFlags = 1)]
				public virtual void SetStartTime(long startTimeMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Convenience method to start the animation the first time getTransformation(long, Transformation) is invoked. </para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Convenience method to start the animation at the current time in milliseconds. </para>        
				/// </summary>
				/// <java-name>
				/// startNow
				/// </java-name>
				[Dot42.DexImport("startNow", "()V", AccessFlags = 1)]
				public virtual void StartNow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Defines what this animation should do when it reaches the end. This setting is applied only when the repeat count is either greater than 0 or INFINITE. Defaults to RESTART.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRepeatMode
				/// </java-name>
				[Dot42.DexImport("setRepeatMode", "(I)V", AccessFlags = 1)]
				public virtual void SetRepeatMode(int repeatMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets how many times the animation should be repeated. If the repeat count is 0, the animation is never repeated. If the repeat count is greater than 0 or INFINITE, the repeat mode will be taken into account. The repeat count is 0 by default.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRepeatCount
				/// </java-name>
				[Dot42.DexImport("setRepeatCount", "(I)V", AccessFlags = 1)]
				public virtual void SetRepeatCount(int repeatCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If fillEnabled is true, this animation will apply the value of fillBefore.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the animation will take fillBefore into account  ref android.R.styleable::Animation_fillEnabled </para>
				/// </returns>
				/// <java-name>
				/// isFillEnabled
				/// </java-name>
				[Dot42.DexImport("isFillEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsFillEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>If fillEnabled is true, the animation will apply the value of fillBefore. Otherwise, fillBefore is ignored and the animation transformation is always applied until the animation ends.</para><para><para>setFillBefore(boolean) </para><simplesectsep></simplesectsep><para>setFillAfter(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFillEnabled
				/// </java-name>
				[Dot42.DexImport("setFillEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetFillEnabled(bool fillEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If fillBefore is true, this animation will apply its transformation before the start time of the animation. Defaults to true if setFillEnabled(boolean) is not set to true. Note that this applies when using an AnimationSet to chain animations. The transformation is not applied before the AnimationSet itself starts.</para><para><para>setFillEnabled(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFillBefore
				/// </java-name>
				[Dot42.DexImport("setFillBefore", "(Z)V", AccessFlags = 1)]
				public virtual void SetFillBefore(bool fillBefore) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If fillAfter is true, the transformation that this animation performed will persist when it is finished. Defaults to false if not set. Note that this applies to individual animations and when using an AnimationSet to chain animations.</para><para><para>setFillEnabled(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFillAfter
				/// </java-name>
				[Dot42.DexImport("setFillAfter", "(Z)V", AccessFlags = 1)]
				public virtual void SetFillAfter(bool fillAfter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the Z ordering mode to use while running the animation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setZAdjustment
				/// </java-name>
				[Dot42.DexImport("setZAdjustment", "(I)V", AccessFlags = 1)]
				public virtual void SetZAdjustment(int zAdjustment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set background behind animation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundColor
				/// </java-name>
				[Dot42.DexImport("setBackgroundColor", "(I)V", AccessFlags = 1)]
				public virtual void SetBackgroundColor(int bg) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The scale factor is set by the call to <code>getTransformation</code>. Overrides of getTransformation(long, Transformation, float) will get this value directly. Overrides of applyTransformation(float, Transformation) can call this method to get the value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>float The scale factor that should be applied to pre-scaled values in an Animation such as the pivot points in ScaleAnimation and RotateAnimation. </para>
				/// </returns>
				/// <java-name>
				/// getScaleFactor
				/// </java-name>
				[Dot42.DexImport("getScaleFactor", "()F", AccessFlags = 4)]
				protected internal virtual float GetScaleFactor() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>If detachWallpaper is true, and this is a window animation of a window that has a wallpaper background, then the window will be detached from the wallpaper while it runs. That is, the animation will only be applied to the window, and the wallpaper behind it will remain static.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDetachWallpaper
				/// </java-name>
				[Dot42.DexImport("setDetachWallpaper", "(Z)V", AccessFlags = 1)]
				public virtual void SetDetachWallpaper(bool detachWallpaper) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the acceleration curve type for this animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Interpolator associated to this animation  ref android.R.styleable::Animation_interpolator </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "()Landroid/view/animation/Interpolator;", AccessFlags = 1)]
				public virtual global::Android.View.Animation.IInterpolator GetInterpolator() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.IInterpolator);
				}

				/// <summary>
				/// <para>When this animation should start. If the animation has not startet yet, this method might return START_ON_FIRST_FRAME.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time in milliseconds when the animation should start or START_ON_FIRST_FRAME </para>
				/// </returns>
				/// <java-name>
				/// getStartTime
				/// </java-name>
				[Dot42.DexImport("getStartTime", "()J", AccessFlags = 1)]
				public virtual long GetStartTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>How long this animation should last</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the duration in milliseconds of the animation  ref android.R.styleable::Animation_duration </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
				public virtual long GetDuration() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>When this animation should start, relative to StartTime</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the start offset in milliseconds  ref android.R.styleable::Animation_startOffset </para>
				/// </returns>
				/// <java-name>
				/// getStartOffset
				/// </java-name>
				[Dot42.DexImport("getStartOffset", "()J", AccessFlags = 1)]
				public virtual long GetStartOffset() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Defines what this animation should do when it reaches the end.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>either one of REVERSE or RESTART  ref android.R.styleable::Animation_repeatMode </para>
				/// </returns>
				/// <java-name>
				/// getRepeatMode
				/// </java-name>
				[Dot42.DexImport("getRepeatMode", "()I", AccessFlags = 1)]
				public virtual int GetRepeatMode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Defines how many times the animation should repeat. The default value is 0.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of times the animation should repeat, or INFINITE  ref android.R.styleable::Animation_repeatCount </para>
				/// </returns>
				/// <java-name>
				/// getRepeatCount
				/// </java-name>
				[Dot42.DexImport("getRepeatCount", "()I", AccessFlags = 1)]
				public virtual int GetRepeatCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>If fillBefore is true, this animation will apply its transformation before the start time of the animation. If fillBefore is false and fillEnabled is true, the transformation will not be applied until the start time of the animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the animation applies its transformation before it starts  ref android.R.styleable::Animation_fillBefore </para>
				/// </returns>
				/// <java-name>
				/// getFillBefore
				/// </java-name>
				[Dot42.DexImport("getFillBefore", "()Z", AccessFlags = 1)]
				public virtual bool GetFillBefore() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>If fillAfter is true, this animation will apply its transformation after the end time of the animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the animation applies its transformation after it ends  ref android.R.styleable::Animation_fillAfter </para>
				/// </returns>
				/// <java-name>
				/// getFillAfter
				/// </java-name>
				[Dot42.DexImport("getFillAfter", "()Z", AccessFlags = 1)]
				public virtual bool GetFillAfter() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the Z ordering mode to use while running the animation as previously set by setZAdjustment.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns one of ZORDER_NORMAL, ZORDER_TOP, or ZORDER_BOTTOM.  ref android.R.styleable::Animation_zAdjustment </para>
				/// </returns>
				/// <java-name>
				/// getZAdjustment
				/// </java-name>
				[Dot42.DexImport("getZAdjustment", "()I", AccessFlags = 1)]
				public virtual int GetZAdjustment() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the background color behind the animation. </para>        
				/// </summary>
				/// <java-name>
				/// getBackgroundColor
				/// </java-name>
				[Dot42.DexImport("getBackgroundColor", "()I", AccessFlags = 1)]
				public virtual int GetBackgroundColor() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return value of setDetachWallpaper(boolean).  ref android.R.styleable::Animation_detachWallpaper </para>        
				/// </summary>
				/// <java-name>
				/// getDetachWallpaper
				/// </java-name>
				[Dot42.DexImport("getDetachWallpaper", "()Z", AccessFlags = 1)]
				public virtual bool GetDetachWallpaper() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not this animation will affect the transformation matrix. For instance, a fade animation will not affect the matrix whereas a scale animation will.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this animation will change the transformation matrix </para>
				/// </returns>
				/// <java-name>
				/// willChangeTransformationMatrix
				/// </java-name>
				[Dot42.DexImport("willChangeTransformationMatrix", "()Z", AccessFlags = 1)]
				public virtual bool WillChangeTransformationMatrix() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not this animation will affect the bounds of the animated view. For instance, a fade animation will not affect the bounds whereas a 200% scale animation will.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this animation will change the view's bounds </para>
				/// </returns>
				/// <java-name>
				/// willChangeBounds
				/// </java-name>
				[Dot42.DexImport("willChangeBounds", "()Z", AccessFlags = 1)]
				public virtual bool WillChangeBounds() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Binds an animation listener to this animation. The animation listener is notified of animation events such as the end of the animation or the repetition of the animation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAnimationListener
				/// </java-name>
				[Dot42.DexImport("setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V", AccessFlags = 1)]
				public virtual void SetAnimationListener(global::Android.View.Animation.Animation.IAnimationListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gurantees that this animation has an interpolator. Will use a AccelerateDecelerateInterpolator is nothing else was specified. </para>        
				/// </summary>
				/// <java-name>
				/// ensureInterpolator
				/// </java-name>
				[Dot42.DexImport("ensureInterpolator", "()V", AccessFlags = 4)]
				protected internal virtual void EnsureInterpolator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Compute a hint at how long the entire animation may last, in milliseconds. Animations can be written to cause themselves to run for a different duration than what is computed here, but generally this should be accurate. </para>        
				/// </summary>
				/// <java-name>
				/// computeDurationHint
				/// </java-name>
				[Dot42.DexImport("computeDurationHint", "()J", AccessFlags = 1)]
				public virtual long ComputeDurationHint() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Gets the transformation to apply at a specified point in time. Implementations of this method should always replace the specified Transformation or document they are doing otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the animation is still running </para>
				/// </returns>
				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(JLandroid/view/animation/Transformation;)Z", AccessFlags = 1)]
				public virtual bool GetTransformation(long currentTime, global::Android.View.Animation.Transformation outTransformation) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the transformation to apply at a specified point in time. Implementations of this method should always replace the specified Transformation or document they are doing otherwise.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the animation is still running </para>
				/// </returns>
				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(JLandroid/view/animation/Transformation;F)Z", AccessFlags = 1)]
				public virtual bool GetTransformation(long currentTime, global::Android.View.Animation.Transformation outTransformation, float scale) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this animation has started or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the animation has started, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasStarted
				/// </java-name>
				[Dot42.DexImport("hasStarted", "()Z", AccessFlags = 1)]
				public virtual bool HasStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether this animation has ended or not.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the animation has ended, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// hasEnded
				/// </java-name>
				[Dot42.DexImport("hasEnded", "()Z", AccessFlags = 1)]
				public virtual bool HasEnded() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Helper for getTransformation. Subclasses should implement this to apply their transforms given an interpolation value. Implementations of this method should always replace the specified Transformation or document they are doing otherwise.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal virtual void ApplyTransformation(float interpolatedTime, global::Android.View.Animation.Transformation t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Convert the information in the description of a size to an actual dimension</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The dimension to use for the animation </para>
				/// </returns>
				/// <java-name>
				/// resolveSize
				/// </java-name>
				[Dot42.DexImport("resolveSize", "(IFII)F", AccessFlags = 4)]
				protected internal virtual float ResolveSize(int type, float value, int size, int parentSize) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Animation() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The scale factor is set by the call to <code>getTransformation</code>. Overrides of getTransformation(long, Transformation, float) will get this value directly. Overrides of applyTransformation(float, Transformation) can call this method to get the value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>float The scale factor that should be applied to pre-scaled values in an Animation such as the pivot points in ScaleAnimation and RotateAnimation. </para>
				/// </returns>
				/// <java-name>
				/// getScaleFactor
				/// </java-name>
				protected internal float ScaleFactor
				{
				[Dot42.DexImport("getScaleFactor", "()F", AccessFlags = 4)]
						get{ return GetScaleFactor(); }
				}

				/// <summary>
				/// <para>Gets the acceleration curve type for this animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the Interpolator associated to this animation  ref android.R.styleable::Animation_interpolator </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public global::Android.View.Animation.IInterpolator Interpolator
				{
				[Dot42.DexImport("getInterpolator", "()Landroid/view/animation/Interpolator;", AccessFlags = 1)]
						get{ return GetInterpolator(); }
				[Dot42.DexImport("setInterpolator", "(Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
						set{ SetInterpolator(value); }
				}

				/// <summary>
				/// <para>When this animation should start. If the animation has not startet yet, this method might return START_ON_FIRST_FRAME.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time in milliseconds when the animation should start or START_ON_FIRST_FRAME </para>
				/// </returns>
				/// <java-name>
				/// getStartTime
				/// </java-name>
				public long StartTime
				{
				[Dot42.DexImport("getStartTime", "()J", AccessFlags = 1)]
						get{ return GetStartTime(); }
				[Dot42.DexImport("setStartTime", "(J)V", AccessFlags = 1)]
						set{ SetStartTime(value); }
				}

				/// <summary>
				/// <para>How long this animation should last</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the duration in milliseconds of the animation  ref android.R.styleable::Animation_duration </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public long Duration
				{
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return GetDuration(); }
				[Dot42.DexImport("setDuration", "(J)V", AccessFlags = 1)]
						set{ SetDuration(value); }
				}

				/// <summary>
				/// <para>When this animation should start, relative to StartTime</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the start offset in milliseconds  ref android.R.styleable::Animation_startOffset </para>
				/// </returns>
				/// <java-name>
				/// getStartOffset
				/// </java-name>
				public long StartOffset
				{
				[Dot42.DexImport("getStartOffset", "()J", AccessFlags = 1)]
						get{ return GetStartOffset(); }
				[Dot42.DexImport("setStartOffset", "(J)V", AccessFlags = 1)]
						set{ SetStartOffset(value); }
				}

				/// <summary>
				/// <para>Defines what this animation should do when it reaches the end.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>either one of REVERSE or RESTART  ref android.R.styleable::Animation_repeatMode </para>
				/// </returns>
				/// <java-name>
				/// getRepeatMode
				/// </java-name>
				public int RepeatMode
				{
				[Dot42.DexImport("getRepeatMode", "()I", AccessFlags = 1)]
						get{ return GetRepeatMode(); }
				[Dot42.DexImport("setRepeatMode", "(I)V", AccessFlags = 1)]
						set{ SetRepeatMode(value); }
				}

				/// <summary>
				/// <para>Defines how many times the animation should repeat. The default value is 0.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of times the animation should repeat, or INFINITE  ref android.R.styleable::Animation_repeatCount </para>
				/// </returns>
				/// <java-name>
				/// getRepeatCount
				/// </java-name>
				public int RepeatCount
				{
				[Dot42.DexImport("getRepeatCount", "()I", AccessFlags = 1)]
						get{ return GetRepeatCount(); }
				[Dot42.DexImport("setRepeatCount", "(I)V", AccessFlags = 1)]
						set{ SetRepeatCount(value); }
				}

				/// <summary>
				/// <para>If fillBefore is true, this animation will apply its transformation before the start time of the animation. If fillBefore is false and fillEnabled is true, the transformation will not be applied until the start time of the animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the animation applies its transformation before it starts  ref android.R.styleable::Animation_fillBefore </para>
				/// </returns>
				/// <java-name>
				/// getFillBefore
				/// </java-name>
				public bool IsFillBefore
				{
				[Dot42.DexImport("getFillBefore", "()Z", AccessFlags = 1)]
						get{ return GetFillBefore(); }
				[Dot42.DexImport("setFillBefore", "(Z)V", AccessFlags = 1)]
						set{ SetFillBefore(value); }
				}

				/// <summary>
				/// <para>If fillAfter is true, this animation will apply its transformation after the end time of the animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the animation applies its transformation after it ends  ref android.R.styleable::Animation_fillAfter </para>
				/// </returns>
				/// <java-name>
				/// getFillAfter
				/// </java-name>
				public bool IsFillAfter
				{
				[Dot42.DexImport("getFillAfter", "()Z", AccessFlags = 1)]
						get{ return GetFillAfter(); }
				[Dot42.DexImport("setFillAfter", "(Z)V", AccessFlags = 1)]
						set{ SetFillAfter(value); }
				}

				/// <summary>
				/// <para>Returns the Z ordering mode to use while running the animation as previously set by setZAdjustment.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns one of ZORDER_NORMAL, ZORDER_TOP, or ZORDER_BOTTOM.  ref android.R.styleable::Animation_zAdjustment </para>
				/// </returns>
				/// <java-name>
				/// getZAdjustment
				/// </java-name>
				public int ZAdjustment
				{
				[Dot42.DexImport("getZAdjustment", "()I", AccessFlags = 1)]
						get{ return GetZAdjustment(); }
				[Dot42.DexImport("setZAdjustment", "(I)V", AccessFlags = 1)]
						set{ SetZAdjustment(value); }
				}

				/// <summary>
				/// <para>Returns the background color behind the animation. </para>        
				/// </summary>
				/// <java-name>
				/// getBackgroundColor
				/// </java-name>
				public int BackgroundColor
				{
				[Dot42.DexImport("getBackgroundColor", "()I", AccessFlags = 1)]
						get{ return GetBackgroundColor(); }
				[Dot42.DexImport("setBackgroundColor", "(I)V", AccessFlags = 1)]
						set{ SetBackgroundColor(value); }
				}

				/// <summary>
				/// <para>Return value of setDetachWallpaper(boolean).  ref android.R.styleable::Animation_detachWallpaper </para>        
				/// </summary>
				/// <java-name>
				/// getDetachWallpaper
				/// </java-name>
				public bool IsDetachWallpaper
				{
				[Dot42.DexImport("getDetachWallpaper", "()Z", AccessFlags = 1)]
						get{ return GetDetachWallpaper(); }
				[Dot42.DexImport("setDetachWallpaper", "(Z)V", AccessFlags = 1)]
						set{ SetDetachWallpaper(value); }
				}

				/// <summary>
				/// <para>An animation listener receives notifications from an animation. Notifications indicate animation related events, such as the end or the repetition of the animation.</para>    
				/// </summary>
				/// <java-name>
				/// android/view/animation/Animation$AnimationListener
				/// </java-name>
				[Dot42.DexImport("android/view/animation/Animation$AnimationListener", AccessFlags = 1545)]
				public partial interface IAnimationListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Notifies the start of the animation.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAnimationStart
						/// </java-name>
						[Dot42.DexImport("onAnimationStart", "(Landroid/view/animation/Animation;)V", AccessFlags = 1025)]
						void OnAnimationStart(global::Android.View.Animation.Animation animation) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Notifies the end of the animation. This callback is not invoked for animations with repeat count set to INFINITE.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAnimationEnd
						/// </java-name>
						[Dot42.DexImport("onAnimationEnd", "(Landroid/view/animation/Animation;)V", AccessFlags = 1025)]
						void OnAnimationEnd(global::Android.View.Animation.Animation animation) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Notifies the repetition of the animation.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAnimationRepeat
						/// </java-name>
						[Dot42.DexImport("onAnimationRepeat", "(Landroid/view/animation/Animation;)V", AccessFlags = 1025)]
						void OnAnimationRepeat(global::Android.View.Animation.Animation animation) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Utility class to parse a string description of a size. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/animation/Animation$Description
				/// </java-name>
				[Dot42.DexImport("android/view/animation/Animation$Description", AccessFlags = 12)]
				protected internal partial class Description
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>One of Animation.ABSOLUTE, Animation.RELATIVE_TO_SELF, or Animation.RELATIVE_TO_PARENT. </para>        
						/// </summary>
						/// <java-name>
						/// type
						/// </java-name>
						[Dot42.DexImport("type", "I", AccessFlags = 1)]
						public int Type;
						/// <summary>
						/// <para>The absolute or relative dimension for this Description. </para>        
						/// </summary>
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

		/// <summary>
		/// <para>Defines common utilities for working with animations. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Returns the current animation time in milliseconds. This time should be used when invoking Animation#setStartTime(long). Refer to android.os.SystemClock for more information about the different available clocks. The clock used by this method is <b>not</b> the "wall" clock (it is not System#currentTimeMillis).</para><para><para>android.os.SystemClock </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the current animation time in milliseconds</para>
				/// </returns>
				/// <java-name>
				/// currentAnimationTimeMillis
				/// </java-name>
				[Dot42.DexImport("currentAnimationTimeMillis", "()J", AccessFlags = 9)]
				public static long CurrentAnimationTimeMillis() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Loads an Animation object from a resource</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The animation object reference by the specified id </para>
				/// </returns>
				/// <java-name>
				/// loadAnimation
				/// </java-name>
				[Dot42.DexImport("loadAnimation", "(Landroid/content/Context;I)Landroid/view/animation/Animation;", AccessFlags = 9)]
				public static global::Android.View.Animation.Animation LoadAnimation(global::Android.Content.Context context, int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.Animation);
				}

				/// <summary>
				/// <para>Loads a LayoutAnimationController object from a resource</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The animation object reference by the specified id </para>
				/// </returns>
				/// <java-name>
				/// loadLayoutAnimation
				/// </java-name>
				[Dot42.DexImport("loadLayoutAnimation", "(Landroid/content/Context;I)Landroid/view/animation/LayoutAnimationController;", AccessFlags = 9)]
				public static global::Android.View.Animation.LayoutAnimationController LoadLayoutAnimation(global::Android.Content.Context context, int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.LayoutAnimationController);
				}

				/// <summary>
				/// <para>Make an animation for objects becoming visible. Uses a slide and fade effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The new animation </para>
				/// </returns>
				/// <java-name>
				/// makeInAnimation
				/// </java-name>
				[Dot42.DexImport("makeInAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;", AccessFlags = 9)]
				public static global::Android.View.Animation.Animation MakeInAnimation(global::Android.Content.Context c, bool fromLeft) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.Animation);
				}

				/// <summary>
				/// <para>Make an animation for objects becoming invisible. Uses a slide and fade effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The new animation </para>
				/// </returns>
				/// <java-name>
				/// makeOutAnimation
				/// </java-name>
				[Dot42.DexImport("makeOutAnimation", "(Landroid/content/Context;Z)Landroid/view/animation/Animation;", AccessFlags = 9)]
				public static global::Android.View.Animation.Animation MakeOutAnimation(global::Android.Content.Context c, bool toRight) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.Animation);
				}

				/// <summary>
				/// <para>Make an animation for objects becoming visible. Uses a slide up and fade effect.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The new animation </para>
				/// </returns>
				/// <java-name>
				/// makeInChildBottomAnimation
				/// </java-name>
				[Dot42.DexImport("makeInChildBottomAnimation", "(Landroid/content/Context;)Landroid/view/animation/Animation;", AccessFlags = 9)]
				public static global::Android.View.Animation.Animation MakeInChildBottomAnimation(global::Android.Content.Context c) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.Animation);
				}

				/// <summary>
				/// <para>Loads an Interpolator object from a resource</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The animation object reference by the specified id </para>
				/// </returns>
				/// <java-name>
				/// loadInterpolator
				/// </java-name>
				[Dot42.DexImport("loadInterpolator", "(Landroid/content/Context;I)Landroid/view/animation/Interpolator;", AccessFlags = 9)]
				public static global::Android.View.Animation.IInterpolator LoadInterpolator(global::Android.Content.Context context, int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.IInterpolator);
				}

		}

		/// <summary>
		/// <para>An interpolator where the change bounces at the end. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/BounceInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/BounceInterpolator", AccessFlags = 33)]
		public partial class BounceInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BounceInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public BounceInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>An interpolator where the rate of change is constant </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/LinearInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/LinearInterpolator", AccessFlags = 33)]
		public partial class LinearInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinearInterpolator() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public LinearInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>An animation that controls the scale of an object. You can specify the point to use for the center of scaling. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/ScaleAnimation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/ScaleAnimation", AccessFlags = 33)]
		public partial class ScaleAnimation : global::Android.View.Animation.Animation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor used when a ScaleAnimation is loaded from a resource.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ScaleAnimation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to use when building a ScaleAnimation from code</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public ScaleAnimation(float fromX, float toX, float fromY, float toY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to use when building a ScaleAnimation from code</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFFFFF)V", AccessFlags = 1)]
				public ScaleAnimation(float fromX, float toX, float fromY, float toY, float pivotX, float pivotY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to use when building a ScaleAnimation from code</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFFFIFIF)V", AccessFlags = 1)]
				public ScaleAnimation(float fromX, float toX, float fromY, float toY, int pivotXType, float pivotXValue, int pivotYType, float pivotYValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Helper for getTransformation. Subclasses should implement this to apply their transforms given an interpolation value. Implementations of this method should always replace the specified Transformation or document they are doing otherwise.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal override void ApplyTransformation(float interpolatedTime, global::Android.View.Animation.Transformation t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initialize this animation with the dimensions of the object being animated as well as the objects parents. (This is to support animation sizes being specified relative to these dimensions.)</para><para>Objects that interpret Animations should call this method when the sizes of the object being animated and its parent are known, and before calling getTransformation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public override void Initialize(int width, int height, int parentWidth, int parentHeight) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScaleAnimation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An interpolator defines the rate of change of an animation. This allows the basic animation effects (alpha, scale, translate, rotate) to be accelerated, decelerated, repeated, etc. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/Interpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/Interpolator", AccessFlags = 1537)]
		public partial interface IInterpolator : global::Android.Animation.ITimeInterpolator
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		/// <para>A layout animation controller is used to animated a layout's, or a view group's, children. Each child uses the same animation but for every one of them, the animation starts at a different time. A layout animation controller is used by android.view.ViewGroup to compute the delay by which each child's animation start must be offset. The delay is computed by using characteristics of each child, like its index in the view group.</para><para>This standard implementation computes the delay by multiplying a fixed amount of miliseconds by the index of the child in its parent view group. Subclasses are supposed to override getDelayForView(android.view.View) to implement a different way of computing the delay. For instance, a android.view.animation.GridLayoutAnimationController will compute the delay based on the column and row indices of the child in its parent view group.</para><para>Information used to compute the animation delay of each child are stored in an instance of android.view.animation.LayoutAnimationController.AnimationParameters, itself stored in the android.view.ViewGroup.LayoutParams of the view.</para><para>ref android.R.styleable::LayoutAnimation_delay  ref android.R.styleable::LayoutAnimation_animationOrder  ref android.R.styleable::LayoutAnimation_interpolator  ref android.R.styleable::LayoutAnimation_animation </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/LayoutAnimationController
		/// </java-name>
		[Dot42.DexImport("android/view/animation/LayoutAnimationController", AccessFlags = 33)]
		public partial class LayoutAnimationController
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Distributes the animation delays in the order in which view were added to their view group. </para>        
				/// </summary>
				/// <java-name>
				/// ORDER_NORMAL
				/// </java-name>
				[Dot42.DexImport("ORDER_NORMAL", "I", AccessFlags = 25)]
				public const int ORDER_NORMAL = 0;
				/// <summary>
				/// <para>Distributes the animation delays in the reverse order in which view were added to their view group. </para>        
				/// </summary>
				/// <java-name>
				/// ORDER_REVERSE
				/// </java-name>
				[Dot42.DexImport("ORDER_REVERSE", "I", AccessFlags = 25)]
				public const int ORDER_REVERSE = 1;
				/// <summary>
				/// <para>Randomly distributes the animation delays. </para>        
				/// </summary>
				/// <java-name>
				/// ORDER_RANDOM
				/// </java-name>
				[Dot42.DexImport("ORDER_RANDOM", "I", AccessFlags = 25)]
				public const int ORDER_RANDOM = 2;
				/// <summary>
				/// <para>The animation applied on each child of the view group on which this layout animation controller is set. </para>        
				/// </summary>
				/// <java-name>
				/// mAnimation
				/// </java-name>
				[Dot42.DexImport("mAnimation", "Landroid/view/animation/Animation;", AccessFlags = 4)]
				protected internal global::Android.View.Animation.Animation MAnimation;
				/// <summary>
				/// <para>The randomizer used when the order is set to random. Subclasses should use this object to avoid creating their own. </para>        
				/// </summary>
				/// <java-name>
				/// mRandomizer
				/// </java-name>
				[Dot42.DexImport("mRandomizer", "Ljava/util/Random;", AccessFlags = 4)]
				protected internal global::System.Random MRandomizer;
				/// <summary>
				/// <para>The interpolator used to interpolate the delays. </para>        
				/// </summary>
				/// <java-name>
				/// mInterpolator
				/// </java-name>
				[Dot42.DexImport("mInterpolator", "Landroid/view/animation/Interpolator;", AccessFlags = 4)]
				protected internal global::Android.View.Animation.IInterpolator MInterpolator;
				/// <summary>
				/// <para>Creates a new layout animation controller from external resources.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public LayoutAnimationController(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new layout animation controller with a delay of 50% and the specified animation.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public LayoutAnimationController(global::Android.View.Animation.Animation animation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new layout animation controller from external resources.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/animation/Animation;F)V", AccessFlags = 1)]
				public LayoutAnimationController(global::Android.View.Animation.Animation context, float attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the order used to compute the delay of each child's animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of ORDER_NORMAL, ORDER_REVERSE or ref android.R.styleable#LayoutAnimation_animationOrder </para>
				/// </returns>
				/// <java-name>
				/// getOrder
				/// </java-name>
				[Dot42.DexImport("getOrder", "()I", AccessFlags = 1)]
				public virtual int GetOrder() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the order used to compute the delay of each child's animation.</para><para>ref android.R.styleable::LayoutAnimation_animationOrder </para>        
				/// </summary>
				/// <java-name>
				/// setOrder
				/// </java-name>
				[Dot42.DexImport("setOrder", "(I)V", AccessFlags = 1)]
				public virtual void SetOrder(int order) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the animation to be run on each child of the view group on which this layout animation controller is .</para><para><para>setAnimation(Animation) </para><simplesectsep></simplesectsep><para>getAnimation()</para>ref android.R.styleable::LayoutAnimation_animation </para>        
				/// </summary>
				/// <java-name>
				/// setAnimation
				/// </java-name>
				[Dot42.DexImport("setAnimation", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetAnimation(global::Android.Content.Context context, int resourceID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the animation to be run on each child of the view group on which this layout animation controller is .</para><para><para>setAnimation(android.content.Context, int) </para><simplesectsep></simplesectsep><para>getAnimation()</para>ref android.R.styleable::LayoutAnimation_animation </para>        
				/// </summary>
				/// <java-name>
				/// setAnimation
				/// </java-name>
				[Dot42.DexImport("setAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public virtual void SetAnimation(global::Android.View.Animation.Animation animation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the animation applied to each child of the view group on which this controller is set.</para><para><para>setAnimation(android.content.Context, int) </para><simplesectsep></simplesectsep><para>setAnimation(Animation) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an android.view.animation.Animation instance</para>
				/// </returns>
				/// <java-name>
				/// getAnimation
				/// </java-name>
				[Dot42.DexImport("getAnimation", "()Landroid/view/animation/Animation;", AccessFlags = 1)]
				public virtual global::Android.View.Animation.Animation GetAnimation() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.Animation);
				}

				/// <summary>
				/// <para>Sets the interpolator used to interpolate the delays between the children.</para><para><para>getInterpolator() </para><simplesectsep></simplesectsep><para>setInterpolator(Interpolator)</para>ref android.R.styleable::LayoutAnimation_interpolator </para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.Content.Context context, int resourceID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the interpolator used to interpolate the delays between the children.</para><para><para>getInterpolator() </para><simplesectsep></simplesectsep><para>setInterpolator(Interpolator)</para>ref android.R.styleable::LayoutAnimation_interpolator </para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.View.Animation.IInterpolator interpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the interpolator used to interpolate the delays between the children.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an android.view.animation.Interpolator </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "()Landroid/view/animation/Interpolator;", AccessFlags = 1)]
				public virtual global::Android.View.Animation.IInterpolator GetInterpolator() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.IInterpolator);
				}

				/// <summary>
				/// <para>Returns the delay by which the children's animation are offset. The delay is expressed as a fraction of the animation duration.</para><para><para>setDelay(float) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a fraction of the animation duration</para>
				/// </returns>
				/// <java-name>
				/// getDelay
				/// </java-name>
				[Dot42.DexImport("getDelay", "()F", AccessFlags = 1)]
				public virtual float GetDelay() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Sets the delay, as a fraction of the animation duration, by which the children's animations are offset. The general formula is:</para><para><pre>
				///        child animation delay = child index * delay * animation duration
				///        </pre></para><para><para>getDelay() </para></para>        
				/// </summary>
				/// <java-name>
				/// setDelay
				/// </java-name>
				[Dot42.DexImport("setDelay", "(F)V", AccessFlags = 1)]
				public virtual void SetDelay(float delay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates whether two children's animations will overlap. Animations overlap when the delay is lower than 100% (or 1.0).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if animations will overlap, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// willOverlap
				/// </java-name>
				[Dot42.DexImport("willOverlap", "()Z", AccessFlags = 1)]
				public virtual bool WillOverlap() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Starts the animation. </para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the animation to be applied to the specified view. The returned animation is delayed by an offset computed according to the information provided by android.view.animation.LayoutAnimationController.AnimationParameters. This method is called by view groups to obtain the animation to set on a specific child.</para><para><para>getDelay() </para><simplesectsep></simplesectsep><para>setDelay(float) </para><simplesectsep></simplesectsep><para>getDelayForView(android.view.View) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an animation delayed by the number of milliseconds returned by getDelayForView(android.view.View)</para>
				/// </returns>
				/// <java-name>
				/// getAnimationForView
				/// </java-name>
				[Dot42.DexImport("getAnimationForView", "(Landroid/view/View;)Landroid/view/animation/Animation;", AccessFlags = 17)]
				public global::Android.View.Animation.Animation GetAnimationForView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.Animation);
				}

				/// <summary>
				/// <para>Indicates whether the layout animation is over or not. A layout animation is considered done when the animation with the longest delay is done.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if all of the children's animations are over, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isDone
				/// </java-name>
				[Dot42.DexImport("isDone", "()Z", AccessFlags = 1)]
				public virtual bool IsDone() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the amount of milliseconds by which the specified view's animation must be delayed or offset. Subclasses should override this method to return a suitable value.</para><para>This implementation returns <code>child animation delay</code> milliseconds where:</para><para><pre>
				///        child animation delay = child index * delay
				///        </pre></para><para>The index is retrieved from the android.view.animation.LayoutAnimationController.AnimationParameters found in the view's android.view.ViewGroup.LayoutParams.</para><para><para>getAnimationForView(android.view.View) </para><simplesectsep></simplesectsep><para>getDelay() </para><simplesectsep></simplesectsep><para>getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters) </para><simplesectsep></simplesectsep><para>android.view.ViewGroup.LayoutParams </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a delay in milliseconds</para>
				/// </returns>
				/// <java-name>
				/// getDelayForView
				/// </java-name>
				[Dot42.DexImport("getDelayForView", "(Landroid/view/View;)J", AccessFlags = 4)]
				protected internal virtual long GetDelayForView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Transforms the index stored in android.view.animation.LayoutAnimationController.AnimationParameters by the order returned by getOrder(). Subclasses should override this method to provide additional support for other types of ordering. This method should be invoked by getDelayForView(android.view.View) prior to any computation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a transformed index </para>
				/// </returns>
				/// <java-name>
				/// getTransformedIndex
				/// </java-name>
				[Dot42.DexImport("getTransformedIndex", "(Landroid/view/animation/LayoutAnimationController$AnimationParameters;)I", AccessFlags = 4)]
				protected internal virtual int GetTransformedIndex(global::Android.View.Animation.LayoutAnimationController.AnimationParameters @params) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LayoutAnimationController() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the order used to compute the delay of each child's animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>one of ORDER_NORMAL, ORDER_REVERSE or ref android.R.styleable#LayoutAnimation_animationOrder </para>
				/// </returns>
				/// <java-name>
				/// getOrder
				/// </java-name>
				public int Order
				{
				[Dot42.DexImport("getOrder", "()I", AccessFlags = 1)]
						get{ return GetOrder(); }
				[Dot42.DexImport("setOrder", "(I)V", AccessFlags = 1)]
						set{ SetOrder(value); }
				}

				/// <summary>
				/// <para>Returns the animation applied to each child of the view group on which this controller is set.</para><para><para>setAnimation(android.content.Context, int) </para><simplesectsep></simplesectsep><para>setAnimation(Animation) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>an android.view.animation.Animation instance</para>
				/// </returns>
				/// <java-name>
				/// getAnimation
				/// </java-name>
				public global::Android.View.Animation.Animation Animation
				{
				[Dot42.DexImport("getAnimation", "()Landroid/view/animation/Animation;", AccessFlags = 1)]
						get{ return GetAnimation(); }
				[Dot42.DexImport("setAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
						set{ SetAnimation(value); }
				}

				/// <summary>
				/// <para>Returns the interpolator used to interpolate the delays between the children.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an android.view.animation.Interpolator </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public global::Android.View.Animation.IInterpolator Interpolator
				{
				[Dot42.DexImport("getInterpolator", "()Landroid/view/animation/Interpolator;", AccessFlags = 1)]
						get{ return GetInterpolator(); }
				[Dot42.DexImport("setInterpolator", "(Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
						set{ SetInterpolator(value); }
				}

				/// <summary>
				/// <para>Returns the delay by which the children's animation are offset. The delay is expressed as a fraction of the animation duration.</para><para><para>setDelay(float) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a fraction of the animation duration</para>
				/// </returns>
				/// <java-name>
				/// getDelay
				/// </java-name>
				public float Delay
				{
				[Dot42.DexImport("getDelay", "()F", AccessFlags = 1)]
						get{ return GetDelay(); }
				[Dot42.DexImport("setDelay", "(F)V", AccessFlags = 1)]
						set{ SetDelay(value); }
				}

				/// <summary>
				/// <para>The set of parameters that has to be attached to each view contained in the view group animated by the layout animation controller. These parameters are used to compute the start time of each individual view's animation. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/animation/LayoutAnimationController$AnimationParameters
				/// </java-name>
				[Dot42.DexImport("android/view/animation/LayoutAnimationController$AnimationParameters", AccessFlags = 9)]
				public partial class AnimationParameters
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>The number of children in the view group containing the view to which these parameters are attached. </para>        
						/// </summary>
						/// <java-name>
						/// count
						/// </java-name>
						[Dot42.DexImport("count", "I", AccessFlags = 1)]
						public int Count;
						/// <summary>
						/// <para>The index of the view to which these parameters are attached in its containing view group. </para>        
						/// </summary>
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

		/// <summary>
		/// <para>Represents a group of Animations that should be played together. The transformation of each individual animation are composed together into a single transform. If AnimationSet sets any properties that its children also set (for example, duration or fillBefore), the values of AnimationSet override the child values.</para><para>The way that AnimationSet inherits behavior from Animation is important to understand. Some of the Animation attributes applied to AnimationSet affect the AnimationSet itself, some are pushed down to the children, and some are ignored, as follows: <ul><li><para>duration, repeatMode, fillBefore, fillAfter: These properties, when set on an AnimationSet object, will be pushed down to all child animations. </para></li><li><para>repeatCount, fillEnabled: These properties are ignored for AnimationSet. </para></li><li><para>startOffset, shareInterpolator: These properties apply to the AnimationSet itself. </para></li></ul>Starting with android.os.Build.VERSION_CODES#ICE_CREAM_SANDWICH, the behavior of these properties is the same in XML resources and at runtime (prior to that release, the values set in XML were ignored for AnimationSet). That is, calling <code>setDuration(500)</code> on an AnimationSet has the same effect as declaring <code>android:duration="500"</code> in an XML resource for an AnimationSet object.</para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/AnimationSet
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AnimationSet", AccessFlags = 33)]
		public partial class AnimationSet : global::Android.View.Animation.Animation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor used when an AnimationSet is loaded from a resource.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AnimationSet(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to use when building an AnimationSet from code</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Z)V", AccessFlags = 1)]
				public AnimationSet(bool shareInterpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/view/animation/AnimationSet;", AccessFlags = 4)]
				protected internal new virtual global::Android.View.Animation.AnimationSet Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Animation.AnimationSet);
				}

				/// <summary>
				/// <para>If fillAfter is true, the transformation that this animation performed will persist when it is finished. Defaults to false if not set. Note that this applies to individual animations and when using an AnimationSet to chain animations.</para><para><para>setFillEnabled(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFillAfter
				/// </java-name>
				[Dot42.DexImport("setFillAfter", "(Z)V", AccessFlags = 1)]
				public override void SetFillAfter(bool fillAfter) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If fillBefore is true, this animation will apply its transformation before the start time of the animation. Defaults to true if setFillEnabled(boolean) is not set to true. Note that this applies when using an AnimationSet to chain animations. The transformation is not applied before the AnimationSet itself starts.</para><para><para>setFillEnabled(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setFillBefore
				/// </java-name>
				[Dot42.DexImport("setFillBefore", "(Z)V", AccessFlags = 1)]
				public override void SetFillBefore(bool fillBefore) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Defines what this animation should do when it reaches the end. This setting is applied only when the repeat count is either greater than 0 or INFINITE. Defaults to RESTART.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRepeatMode
				/// </java-name>
				[Dot42.DexImport("setRepeatMode", "(I)V", AccessFlags = 1)]
				public override void SetRepeatMode(int repeatMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>When this animation should start relative to the start time. This is most useful when composing complex animations using an AnimationSet where some of the animations components start at different times.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartOffset
				/// </java-name>
				[Dot42.DexImport("setStartOffset", "(J)V", AccessFlags = 1)]
				public override void SetStartOffset(long startOffset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the duration of every child animation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)V", AccessFlags = 1)]
				public override void SetDuration(long durationMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Add a child animation to this animation set. The transforms of the child animations are applied in the order that they were added </para>        
				/// </summary>
				/// <java-name>
				/// addAnimation
				/// </java-name>
				[Dot42.DexImport("addAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public virtual void AddAnimation(global::Android.View.Animation.Animation a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the start time of this animation and all child animations</para><para><para>android.view.animation.Animation::setStartTime(long) </para></para>        
				/// </summary>
				/// <java-name>
				/// setStartTime
				/// </java-name>
				[Dot42.DexImport("setStartTime", "(J)V", AccessFlags = 1)]
				public override void SetStartTime(long startTimeMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>When this animation should start. If the animation has not startet yet, this method might return START_ON_FIRST_FRAME.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time in milliseconds when the animation should start or START_ON_FIRST_FRAME </para>
				/// </returns>
				/// <java-name>
				/// getStartTime
				/// </java-name>
				[Dot42.DexImport("getStartTime", "()J", AccessFlags = 1)]
				public override long GetStartTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Ensure that the duration that this animation will run is not longer than <b>durationMillis</b>. In addition to adjusting the duration itself, this ensures that the repeat count also will not make it run longer than the given time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// restrictDuration
				/// </java-name>
				[Dot42.DexImport("restrictDuration", "(J)V", AccessFlags = 1)]
				public override void RestrictDuration(long durationMillis) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The duration of an AnimationSet is defined to be the duration of the longest child animation.</para><para><para>android.view.animation.Animation::getDuration() </para></para>        
				/// </summary>
				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
				public override long GetDuration() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The duration hint of an animation set is the maximum of the duration hints of all of its component animations.</para><para><para>android.view.animation.Animation::computeDurationHint </para></para>        
				/// </summary>
				/// <java-name>
				/// computeDurationHint
				/// </java-name>
				[Dot42.DexImport("computeDurationHint", "()J", AccessFlags = 1)]
				public override long ComputeDurationHint() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The transformation of an animation set is the concatenation of all of its component animations.</para><para><para>android.view.animation.Animation::getTransformation </para></para>        
				/// </summary>
				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(JLandroid/view/animation/Transformation;)Z", AccessFlags = 1)]
				public override bool GetTransformation(long currentTime, global::Android.View.Animation.Transformation t) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>android.view.animation.Animation::scaleCurrentDuration(float) </para></para>        
				/// </summary>
				/// <java-name>
				/// scaleCurrentDuration
				/// </java-name>
				[Dot42.DexImport("scaleCurrentDuration", "(F)V", AccessFlags = 1)]
				public override void ScaleCurrentDuration(float scale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>android.view.animation.Animation::initialize(int, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public override void Initialize(int width, int height, int parentWidth, int parentHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reset the initialization state of this animation.</para><para><para>initialize(int, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public override void Reset() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>All the child animations in this AnimationSet. Note that this may include other AnimationSets, which are not expanded. </para>
				/// </returns>
				/// <java-name>
				/// getAnimations
				/// </java-name>
				[Dot42.DexImport("getAnimations", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/animation/Animation;>;")]
				public virtual global::Java.Util.IList<global::Android.View.Animation.Animation> GetAnimations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.View.Animation.Animation>);
				}

				/// <summary>
				/// <para>Indicates whether or not this animation will affect the transformation matrix. For instance, a fade animation will not affect the matrix whereas a scale animation will.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this animation will change the transformation matrix </para>
				/// </returns>
				/// <java-name>
				/// willChangeTransformationMatrix
				/// </java-name>
				[Dot42.DexImport("willChangeTransformationMatrix", "()Z", AccessFlags = 1)]
				public override bool WillChangeTransformationMatrix() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Indicates whether or not this animation will affect the bounds of the animated view. For instance, a fade animation will not affect the bounds whereas a 200% scale animation will.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if this animation will change the view's bounds </para>
				/// </returns>
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

				/// <summary>
				/// <para>When this animation should start. If the animation has not startet yet, this method might return START_ON_FIRST_FRAME.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the time in milliseconds when the animation should start or START_ON_FIRST_FRAME </para>
				/// </returns>
				/// <java-name>
				/// getStartTime
				/// </java-name>
				public long StartTime
				{
				[Dot42.DexImport("getStartTime", "()J", AccessFlags = 1)]
						get{ return GetStartTime(); }
				[Dot42.DexImport("setStartTime", "(J)V", AccessFlags = 1)]
						set{ SetStartTime(value); }
				}

				/// <summary>
				/// <para>The duration of an AnimationSet is defined to be the duration of the longest child animation.</para><para><para>android.view.animation.Animation::getDuration() </para></para>        
				/// </summary>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public long Duration
				{
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return GetDuration(); }
				[Dot42.DexImport("setDuration", "(J)V", AccessFlags = 1)]
						set{ SetDuration(value); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>All the child animations in this AnimationSet. Note that this may include other AnimationSets, which are not expanded. </para>
				/// </returns>
				/// <java-name>
				/// getAnimations
				/// </java-name>
				public global::Java.Util.IList<global::Android.View.Animation.Animation> Animations
				{
				[Dot42.DexImport("getAnimations", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/animation/Animation;>;")]
						get{ return GetAnimations(); }
				}

		}

		/// <summary>
		/// <para>An interpolator where the change starts backward then flings forward. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/AnticipateInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AnticipateInterpolator", AccessFlags = 33)]
		public partial class AnticipateInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnticipateInterpolator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public AnticipateInterpolator(float tension) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AnticipateInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>An interpolator where the rate of change starts out slowly and and then accelerates. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/AccelerateInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AccelerateInterpolator", AccessFlags = 33)]
		public partial class AccelerateInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccelerateInterpolator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public AccelerateInterpolator(float factor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AccelerateInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>Repeats the animation for a specified number of cycles. The rate of change follows a sinusoidal pattern. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/CycleInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/CycleInterpolator", AccessFlags = 33)]
		public partial class CycleInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public CycleInterpolator(float cycles) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CycleInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CycleInterpolator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>An interpolator where the change starts backward then flings forward and overshoots the target value and finally goes back to the final value. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/AnticipateOvershootInterpolator
		/// </java-name>
		[Dot42.DexImport("android/view/animation/AnticipateOvershootInterpolator", AccessFlags = 33)]
		public partial class AnticipateOvershootInterpolator : global::Android.View.Animation.IInterpolator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnticipateOvershootInterpolator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(F)V", AccessFlags = 1)]
				public AnticipateOvershootInterpolator(float tension) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(FF)V", AccessFlags = 1)]
				public AnticipateOvershootInterpolator(float context, float attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AnticipateOvershootInterpolator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1)]
				public virtual float GetInterpolation(float input) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

		}

		/// <summary>
		/// <para>A layout animation controller is used to animated a grid layout's children.</para><para>While LayoutAnimationController relies only on the index of the child in the view group to compute the animation delay, this class uses both the X and Y coordinates of the child within a grid.</para><para>In addition, the animation direction can be controlled. The default direction is <code>DIRECTION_LEFT_TO_RIGHT | DIRECTION_TOP_TO_BOTTOM</code>. You can also set the animation priority to columns or rows. The default priority is none.</para><para>Information used to compute the animation delay of each child are stored in an instance of android.view.animation.GridLayoutAnimationController.AnimationParameters, itself stored in the android.view.ViewGroup.LayoutParams of the view.</para><para><para>LayoutAnimationController </para><simplesectsep></simplesectsep><para>android.widget.GridView</para>ref android.R.styleable::GridLayoutAnimation_columnDelay  ref android.R.styleable::GridLayoutAnimation_rowDelay  ref android.R.styleable::GridLayoutAnimation_direction  ref android.R.styleable::GridLayoutAnimation_directionPriority </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/GridLayoutAnimationController
		/// </java-name>
		[Dot42.DexImport("android/view/animation/GridLayoutAnimationController", AccessFlags = 33)]
		public partial class GridLayoutAnimationController : global::Android.View.Animation.LayoutAnimationController
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Animates the children starting from the left of the grid to the right. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_LEFT_TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_LEFT_TO_RIGHT", "I", AccessFlags = 25)]
				public const int DIRECTION_LEFT_TO_RIGHT = 0;
				/// <summary>
				/// <para>Animates the children starting from the right of the grid to the left. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_RIGHT_TO_LEFT
				/// </java-name>
				[Dot42.DexImport("DIRECTION_RIGHT_TO_LEFT", "I", AccessFlags = 25)]
				public const int DIRECTION_RIGHT_TO_LEFT = 1;
				/// <summary>
				/// <para>Animates the children starting from the top of the grid to the bottom. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_TOP_TO_BOTTOM
				/// </java-name>
				[Dot42.DexImport("DIRECTION_TOP_TO_BOTTOM", "I", AccessFlags = 25)]
				public const int DIRECTION_TOP_TO_BOTTOM = 0;
				/// <summary>
				/// <para>Animates the children starting from the bottom of the grid to the top. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_BOTTOM_TO_TOP
				/// </java-name>
				[Dot42.DexImport("DIRECTION_BOTTOM_TO_TOP", "I", AccessFlags = 25)]
				public const int DIRECTION_BOTTOM_TO_TOP = 2;
				/// <summary>
				/// <para>Bitmask used to retrieve the horizontal component of the direction. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_HORIZONTAL_MASK
				/// </java-name>
				[Dot42.DexImport("DIRECTION_HORIZONTAL_MASK", "I", AccessFlags = 25)]
				public const int DIRECTION_HORIZONTAL_MASK = 1;
				/// <summary>
				/// <para>Bitmask used to retrieve the vertical component of the direction. </para>        
				/// </summary>
				/// <java-name>
				/// DIRECTION_VERTICAL_MASK
				/// </java-name>
				[Dot42.DexImport("DIRECTION_VERTICAL_MASK", "I", AccessFlags = 25)]
				public const int DIRECTION_VERTICAL_MASK = 2;
				/// <summary>
				/// <para>Rows and columns are animated at the same time. </para>        
				/// </summary>
				/// <java-name>
				/// PRIORITY_NONE
				/// </java-name>
				[Dot42.DexImport("PRIORITY_NONE", "I", AccessFlags = 25)]
				public const int PRIORITY_NONE = 0;
				/// <summary>
				/// <para>Columns are animated first. </para>        
				/// </summary>
				/// <java-name>
				/// PRIORITY_COLUMN
				/// </java-name>
				[Dot42.DexImport("PRIORITY_COLUMN", "I", AccessFlags = 25)]
				public const int PRIORITY_COLUMN = 1;
				/// <summary>
				/// <para>Rows are animated first. </para>        
				/// </summary>
				/// <java-name>
				/// PRIORITY_ROW
				/// </java-name>
				[Dot42.DexImport("PRIORITY_ROW", "I", AccessFlags = 25)]
				public const int PRIORITY_ROW = 2;
				/// <summary>
				/// <para>Creates a new grid layout animation controller from external resources.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public GridLayoutAnimationController(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new layout animation controller with a delay of 50% for both rows and columns and the specified animation.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public GridLayoutAnimationController(global::Android.View.Animation.Animation animation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new layout animation controller with the specified delays and the specified animation.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/animation/Animation;FF)V", AccessFlags = 1)]
				public GridLayoutAnimationController(global::Android.View.Animation.Animation animation, float columnDelay, float rowDelay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the delay by which the children's animation are offset from one column to the other. The delay is expressed as a fraction of the animation duration.</para><para><para>setColumnDelay(float) </para><simplesectsep></simplesectsep><para>getRowDelay() </para><simplesectsep></simplesectsep><para>setRowDelay(float) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a fraction of the animation duration</para>
				/// </returns>
				/// <java-name>
				/// getColumnDelay
				/// </java-name>
				[Dot42.DexImport("getColumnDelay", "()F", AccessFlags = 1)]
				public virtual float GetColumnDelay() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Sets the delay, as a fraction of the animation duration, by which the children's animations are offset from one column to the other.</para><para><para>getColumnDelay() </para><simplesectsep></simplesectsep><para>getRowDelay() </para><simplesectsep></simplesectsep><para>setRowDelay(float) </para></para>        
				/// </summary>
				/// <java-name>
				/// setColumnDelay
				/// </java-name>
				[Dot42.DexImport("setColumnDelay", "(F)V", AccessFlags = 1)]
				public virtual void SetColumnDelay(float columnDelay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the delay by which the children's animation are offset from one row to the other. The delay is expressed as a fraction of the animation duration.</para><para><para>setRowDelay(float) </para><simplesectsep></simplesectsep><para>getColumnDelay() </para><simplesectsep></simplesectsep><para>setColumnDelay(float) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a fraction of the animation duration</para>
				/// </returns>
				/// <java-name>
				/// getRowDelay
				/// </java-name>
				[Dot42.DexImport("getRowDelay", "()F", AccessFlags = 1)]
				public virtual float GetRowDelay() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Sets the delay, as a fraction of the animation duration, by which the children's animations are offset from one row to the other.</para><para><para>getRowDelay() </para><simplesectsep></simplesectsep><para>getColumnDelay() </para><simplesectsep></simplesectsep><para>setColumnDelay(float) </para></para>        
				/// </summary>
				/// <java-name>
				/// setRowDelay
				/// </java-name>
				[Dot42.DexImport("setRowDelay", "(F)V", AccessFlags = 1)]
				public virtual void SetRowDelay(float rowDelay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the direction of the animation. DIRECTION_HORIZONTAL_MASK and DIRECTION_VERTICAL_MASK can be used to retrieve the horizontal and vertical components of the direction.</para><para><para>setDirection(int) </para><simplesectsep></simplesectsep><para>DIRECTION_BOTTOM_TO_TOP </para><simplesectsep></simplesectsep><para>DIRECTION_TOP_TO_BOTTOM </para><simplesectsep></simplesectsep><para>DIRECTION_LEFT_TO_RIGHT </para><simplesectsep></simplesectsep><para>DIRECTION_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_HORIZONTAL_MASK </para><simplesectsep></simplesectsep><para>DIRECTION_VERTICAL_MASK </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the direction of the animation</para>
				/// </returns>
				/// <java-name>
				/// getDirection
				/// </java-name>
				[Dot42.DexImport("getDirection", "()I", AccessFlags = 1)]
				public virtual int GetDirection() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the direction of the animation. The direction is expressed as an integer containing a horizontal and vertical component. For instance, <code>DIRECTION_BOTTOM_TO_TOP | DIRECTION_RIGHT_TO_LEFT</code>.</para><para><para>getDirection() </para><simplesectsep></simplesectsep><para>DIRECTION_BOTTOM_TO_TOP </para><simplesectsep></simplesectsep><para>DIRECTION_TOP_TO_BOTTOM </para><simplesectsep></simplesectsep><para>DIRECTION_LEFT_TO_RIGHT </para><simplesectsep></simplesectsep><para>DIRECTION_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_HORIZONTAL_MASK </para><simplesectsep></simplesectsep><para>DIRECTION_VERTICAL_MASK </para></para>        
				/// </summary>
				/// <java-name>
				/// setDirection
				/// </java-name>
				[Dot42.DexImport("setDirection", "(I)V", AccessFlags = 1)]
				public virtual void SetDirection(int direction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the direction priority for the animation. The priority can be either PRIORITY_NONE, PRIORITY_COLUMN or PRIORITY_ROW.</para><para><para>setDirectionPriority(int) </para><simplesectsep></simplesectsep><para>PRIORITY_COLUMN </para><simplesectsep></simplesectsep><para>PRIORITY_NONE </para><simplesectsep></simplesectsep><para>PRIORITY_ROW </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the priority of the animation direction</para>
				/// </returns>
				/// <java-name>
				/// getDirectionPriority
				/// </java-name>
				[Dot42.DexImport("getDirectionPriority", "()I", AccessFlags = 1)]
				public virtual int GetDirectionPriority() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Specifies the direction priority of the animation. For instance, PRIORITY_COLUMN will give priority to columns: the animation will first play on the column, then on the rows.Z</para><para><para>getDirectionPriority() </para><simplesectsep></simplesectsep><para>PRIORITY_COLUMN </para><simplesectsep></simplesectsep><para>PRIORITY_NONE </para><simplesectsep></simplesectsep><para>PRIORITY_ROW </para></para>        
				/// </summary>
				/// <java-name>
				/// setDirectionPriority
				/// </java-name>
				[Dot42.DexImport("setDirectionPriority", "(I)V", AccessFlags = 1)]
				public virtual void SetDirectionPriority(int directionPriority) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Indicates whether two children's animations will overlap. Animations overlap when the delay is lower than 100% (or 1.0).</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>true if animations will overlap, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// willOverlap
				/// </java-name>
				[Dot42.DexImport("willOverlap", "()Z", AccessFlags = 1)]
				public override bool WillOverlap() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Returns the amount of milliseconds by which the specified view's animation must be delayed or offset. Subclasses should override this method to return a suitable value.</para><para>This implementation returns <code>child animation delay</code> milliseconds where:</para><para><pre>
				///        child animation delay = child index * delay
				///        </pre></para><para>The index is retrieved from the android.view.animation.LayoutAnimationController.AnimationParameters found in the view's android.view.ViewGroup.LayoutParams.</para><para><para>getAnimationForView(android.view.View) </para><simplesectsep></simplesectsep><para>getDelay() </para><simplesectsep></simplesectsep><para>getTransformedIndex(android.view.animation.LayoutAnimationController.AnimationParameters) </para><simplesectsep></simplesectsep><para>android.view.ViewGroup.LayoutParams</para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>a delay in milliseconds</para>
				/// </returns>
				/// <java-name>
				/// getDelayForView
				/// </java-name>
				[Dot42.DexImport("getDelayForView", "(Landroid/view/View;)J", AccessFlags = 4)]
				protected internal override long GetDelayForView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GridLayoutAnimationController() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the delay by which the children's animation are offset from one column to the other. The delay is expressed as a fraction of the animation duration.</para><para><para>setColumnDelay(float) </para><simplesectsep></simplesectsep><para>getRowDelay() </para><simplesectsep></simplesectsep><para>setRowDelay(float) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a fraction of the animation duration</para>
				/// </returns>
				/// <java-name>
				/// getColumnDelay
				/// </java-name>
				public float ColumnDelay
				{
				[Dot42.DexImport("getColumnDelay", "()F", AccessFlags = 1)]
						get{ return GetColumnDelay(); }
				[Dot42.DexImport("setColumnDelay", "(F)V", AccessFlags = 1)]
						set{ SetColumnDelay(value); }
				}

				/// <summary>
				/// <para>Returns the delay by which the children's animation are offset from one row to the other. The delay is expressed as a fraction of the animation duration.</para><para><para>setRowDelay(float) </para><simplesectsep></simplesectsep><para>getColumnDelay() </para><simplesectsep></simplesectsep><para>setColumnDelay(float) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>a fraction of the animation duration</para>
				/// </returns>
				/// <java-name>
				/// getRowDelay
				/// </java-name>
				public float RowDelay
				{
				[Dot42.DexImport("getRowDelay", "()F", AccessFlags = 1)]
						get{ return GetRowDelay(); }
				[Dot42.DexImport("setRowDelay", "(F)V", AccessFlags = 1)]
						set{ SetRowDelay(value); }
				}

				/// <summary>
				/// <para>Returns the direction of the animation. DIRECTION_HORIZONTAL_MASK and DIRECTION_VERTICAL_MASK can be used to retrieve the horizontal and vertical components of the direction.</para><para><para>setDirection(int) </para><simplesectsep></simplesectsep><para>DIRECTION_BOTTOM_TO_TOP </para><simplesectsep></simplesectsep><para>DIRECTION_TOP_TO_BOTTOM </para><simplesectsep></simplesectsep><para>DIRECTION_LEFT_TO_RIGHT </para><simplesectsep></simplesectsep><para>DIRECTION_RIGHT_TO_LEFT </para><simplesectsep></simplesectsep><para>DIRECTION_HORIZONTAL_MASK </para><simplesectsep></simplesectsep><para>DIRECTION_VERTICAL_MASK </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the direction of the animation</para>
				/// </returns>
				/// <java-name>
				/// getDirection
				/// </java-name>
				public int Direction
				{
				[Dot42.DexImport("getDirection", "()I", AccessFlags = 1)]
						get{ return GetDirection(); }
				[Dot42.DexImport("setDirection", "(I)V", AccessFlags = 1)]
						set{ SetDirection(value); }
				}

				/// <summary>
				/// <para>Returns the direction priority for the animation. The priority can be either PRIORITY_NONE, PRIORITY_COLUMN or PRIORITY_ROW.</para><para><para>setDirectionPriority(int) </para><simplesectsep></simplesectsep><para>PRIORITY_COLUMN </para><simplesectsep></simplesectsep><para>PRIORITY_NONE </para><simplesectsep></simplesectsep><para>PRIORITY_ROW </para></para>        
				/// </summary>
				/// <returns>
				/// <para>the priority of the animation direction</para>
				/// </returns>
				/// <java-name>
				/// getDirectionPriority
				/// </java-name>
				public int DirectionPriority
				{
				[Dot42.DexImport("getDirectionPriority", "()I", AccessFlags = 1)]
						get{ return GetDirectionPriority(); }
				[Dot42.DexImport("setDirectionPriority", "(I)V", AccessFlags = 1)]
						set{ SetDirectionPriority(value); }
				}

				/// <summary>
				/// <para>The set of parameters that has to be attached to each view contained in the view group animated by the grid layout animation controller. These parameters are used to compute the start time of each individual view's animation. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/animation/GridLayoutAnimationController$AnimationParameters
				/// </java-name>
				[Dot42.DexImport("android/view/animation/GridLayoutAnimationController$AnimationParameters", AccessFlags = 9)]
				public partial class AnimationParameters : global::Android.View.Animation.LayoutAnimationController.AnimationParameters
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>The view group's column to which the view belongs. </para>        
						/// </summary>
						/// <java-name>
						/// column
						/// </java-name>
						[Dot42.DexImport("column", "I", AccessFlags = 1)]
						public int Column;
						/// <summary>
						/// <para>The view group's row to which the view belongs. </para>        
						/// </summary>
						/// <java-name>
						/// row
						/// </java-name>
						[Dot42.DexImport("row", "I", AccessFlags = 1)]
						public int Row;
						/// <summary>
						/// <para>The number of columns in the view's enclosing grid layout. </para>        
						/// </summary>
						/// <java-name>
						/// columnsCount
						/// </java-name>
						[Dot42.DexImport("columnsCount", "I", AccessFlags = 1)]
						public int ColumnsCount;
						/// <summary>
						/// <para>The number of rows in the view's enclosing grid layout. </para>        
						/// </summary>
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

		/// <summary>
		/// <para>An animation that controls the position of an object. See the full package description for details and sample code. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/TranslateAnimation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/TranslateAnimation", AccessFlags = 33)]
		public partial class TranslateAnimation : global::Android.View.Animation.Animation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor used when a TranslateAnimation is loaded from a resource.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TranslateAnimation(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to use when building a TranslateAnimation from code</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(FFFF)V", AccessFlags = 1)]
				public TranslateAnimation(float fromXDelta, float toXDelta, float fromYDelta, float toYDelta) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to use when building a TranslateAnimation from code</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(IFIFIFIF)V", AccessFlags = 1)]
				public TranslateAnimation(int fromXType, float fromXValue, int toXType, float toXValue, int fromYType, float fromYValue, int toYType, float toYValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Helper for getTransformation. Subclasses should implement this to apply their transforms given an interpolation value. Implementations of this method should always replace the specified Transformation or document they are doing otherwise.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// applyTransformation
				/// </java-name>
				[Dot42.DexImport("applyTransformation", "(FLandroid/view/animation/Transformation;)V", AccessFlags = 4)]
				protected internal override void ApplyTransformation(float interpolatedTime, global::Android.View.Animation.Transformation t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Initialize this animation with the dimensions of the object being animated as well as the objects parents. (This is to support animation sizes being specified relative to these dimensions.)</para><para>Objects that interpret Animations should call this method when the sizes of the object being animated and its parent are known, and before calling getTransformation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(IIII)V", AccessFlags = 1)]
				public override void Initialize(int width, int height, int parentWidth, int parentHeight) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TranslateAnimation() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Defines the transformation to be applied at one point in time of an Animation. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/animation/Transformation
		/// </java-name>
		[Dot42.DexImport("android/view/animation/Transformation", AccessFlags = 33)]
		public partial class Transformation
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Indicates a transformation that has no effect (alpha = 1 and identity matrix.) </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_IDENTITY
				/// </java-name>
				[Dot42.DexImport("TYPE_IDENTITY", "I", AccessFlags = 9)]
				public static int TYPE_IDENTITY;
				/// <summary>
				/// <para>Indicates a transformation that applies an alpha only (uses an identity matrix.) </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ALPHA
				/// </java-name>
				[Dot42.DexImport("TYPE_ALPHA", "I", AccessFlags = 9)]
				public static int TYPE_ALPHA;
				/// <summary>
				/// <para>Indicates a transformation that applies a matrix only (alpha = 1.) </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_MATRIX
				/// </java-name>
				[Dot42.DexImport("TYPE_MATRIX", "I", AccessFlags = 9)]
				public static int TYPE_MATRIX;
				/// <summary>
				/// <para>Indicates a transformation that applies an alpha and a matrix. </para>        
				/// </summary>
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
				/// <summary>
				/// <para>Creates a new transformation with alpha = 1 and the identity matrix. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Transformation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Reset the transformation to a state that leaves the object being animated in an unmodified state. The transformation type is TYPE_BOTH by default. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Indicates the nature of this transformation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>TYPE_ALPHA, TYPE_MATRIX, TYPE_BOTH or TYPE_IDENTITY. </para>
				/// </returns>
				/// <java-name>
				/// getTransformationType
				/// </java-name>
				[Dot42.DexImport("getTransformationType", "()I", AccessFlags = 1)]
				public virtual int GetTransformationType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the transformation type.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTransformationType
				/// </java-name>
				[Dot42.DexImport("setTransformationType", "(I)V", AccessFlags = 1)]
				public virtual void SetTransformationType(int transformationType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clones the specified transformation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// set
				/// </java-name>
				[Dot42.DexImport("set", "(Landroid/view/animation/Transformation;)V", AccessFlags = 1)]
				public virtual void Set(global::Android.View.Animation.Transformation t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Apply this Transformation to an existing Transformation, e.g. apply a scale effect to something that has already been rotated. </para>        
				/// </summary>
				/// <java-name>
				/// compose
				/// </java-name>
				[Dot42.DexImport("compose", "(Landroid/view/animation/Transformation;)V", AccessFlags = 1)]
				public virtual void Compose(global::Android.View.Animation.Transformation t) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The 3x3 Matrix representing the trnasformation to apply to the coordinates of the object being animated </para>
				/// </returns>
				/// <java-name>
				/// getMatrix
				/// </java-name>
				[Dot42.DexImport("getMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Matrix GetMatrix() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Matrix);
				}

				/// <summary>
				/// <para>Sets the degree of transparency </para>        
				/// </summary>
				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(F)V", AccessFlags = 1)]
				public virtual void SetAlpha(float alpha) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The degree of transparency </para>
				/// </returns>
				/// <java-name>
				/// getAlpha
				/// </java-name>
				[Dot42.DexImport("getAlpha", "()F", AccessFlags = 1)]
				public virtual float GetAlpha() /* MethodBuilder.Create */ 
				{
						return default(float);
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
				/// <para>Return a string representation of the transformation in a compact form. </para>        
				/// </summary>
				/// <java-name>
				/// toShortString
				/// </java-name>
				[Dot42.DexImport("toShortString", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ToShortString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Indicates the nature of this transformation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>TYPE_ALPHA, TYPE_MATRIX, TYPE_BOTH or TYPE_IDENTITY. </para>
				/// </returns>
				/// <java-name>
				/// getTransformationType
				/// </java-name>
				public int TransformationType
				{
				[Dot42.DexImport("getTransformationType", "()I", AccessFlags = 1)]
						get{ return GetTransformationType(); }
				[Dot42.DexImport("setTransformationType", "(I)V", AccessFlags = 1)]
						set{ SetTransformationType(value); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The 3x3 Matrix representing the trnasformation to apply to the coordinates of the object being animated </para>
				/// </returns>
				/// <java-name>
				/// getMatrix
				/// </java-name>
				public global::Android.Graphics.Matrix Matrix
				{
				[Dot42.DexImport("getMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 1)]
						get{ return GetMatrix(); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The degree of transparency </para>
				/// </returns>
				/// <java-name>
				/// getAlpha
				/// </java-name>
				public float Alpha
				{
				[Dot42.DexImport("getAlpha", "()F", AccessFlags = 1)]
						get{ return GetAlpha(); }
				[Dot42.DexImport("setAlpha", "(F)V", AccessFlags = 1)]
						set{ SetAlpha(value); }
				}

		}

}


