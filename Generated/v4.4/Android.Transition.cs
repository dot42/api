// Copyright (C) 2014 dot42
//
// Original filename: Android.Transition.cs
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
namespace Android.Transition
{
		/// <java-name>
		/// android/transition/ChangeBounds
		/// </java-name>
		[Dot42.DexImport("android/transition/ChangeBounds", AccessFlags = 33)]
		public partial class ChangeBounds : global::Android.Transition.Transition
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ChangeBounds() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTransitionProperties
				/// </java-name>
				[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetTransitionProperties() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// setResizeClip
				/// </java-name>
				[Dot42.DexImport("setResizeClip", "(Z)V", AccessFlags = 1)]
				public virtual void SetResizeClip(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setReparent
				/// </java-name>
				[Dot42.DexImport("setReparent", "(Z)V", AccessFlags = 1)]
				public virtual void SetReparent(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// captureStartValues
				/// </java-name>
				[Dot42.DexImport("captureStartValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1)]
				public override void CaptureStartValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// captureEndValues
				/// </java-name>
				[Dot42.DexImport("captureEndValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1)]
				public override void CaptureEndValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createAnimator
				/// </java-name>
				[Dot42.DexImport("createAnimator", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;Landroid/transition" +
    "/TransitionValues;)Landroid/animation/Animator;", AccessFlags = 1)]
				public override global::Android.Animation.Animator CreateAnimator(global::Android.View.ViewGroup viewGroup, global::Android.Transition.TransitionValues transitionValues, global::Android.Transition.TransitionValues transitionValues1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// getTransitionProperties
				/// </java-name>
				public string[] TransitionProperties
				{
				[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTransitionProperties(); }
				}

		}

		/// <java-name>
		/// android/transition/Visibility
		/// </java-name>
		[Dot42.DexImport("android/transition/Visibility", AccessFlags = 1057)]
		public abstract partial class Visibility : global::Android.Transition.Transition
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Visibility() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTransitionProperties
				/// </java-name>
				[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
				public override string[] GetTransitionProperties() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// captureStartValues
				/// </java-name>
				[Dot42.DexImport("captureStartValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1)]
				public override void CaptureStartValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// captureEndValues
				/// </java-name>
				[Dot42.DexImport("captureEndValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1)]
				public override void CaptureEndValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isVisible
				/// </java-name>
				[Dot42.DexImport("isVisible", "(Landroid/transition/TransitionValues;)Z", AccessFlags = 1)]
				public virtual bool IsVisible(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createAnimator
				/// </java-name>
				[Dot42.DexImport("createAnimator", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;Landroid/transition" +
    "/TransitionValues;)Landroid/animation/Animator;", AccessFlags = 1)]
				public override global::Android.Animation.Animator CreateAnimator(global::Android.View.ViewGroup viewGroup, global::Android.Transition.TransitionValues transitionValues, global::Android.Transition.TransitionValues transitionValues1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// onAppear
				/// </java-name>
				[Dot42.DexImport("onAppear", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;ILandroid/transitio" +
    "n/TransitionValues;I)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator OnAppear(global::Android.View.ViewGroup viewGroup, global::Android.Transition.TransitionValues transitionValues, int int32, global::Android.Transition.TransitionValues transitionValues1, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// onDisappear
				/// </java-name>
				[Dot42.DexImport("onDisappear", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;ILandroid/transitio" +
    "n/TransitionValues;I)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator OnDisappear(global::Android.View.ViewGroup viewGroup, global::Android.Transition.TransitionValues transitionValues, int int32, global::Android.Transition.TransitionValues transitionValues1, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// getTransitionProperties
				/// </java-name>
				public string[] TransitionProperties
				{
				[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTransitionProperties(); }
				}

		}

		/// <java-name>
		/// android/transition/TransitionSet
		/// </java-name>
		[Dot42.DexImport("android/transition/TransitionSet", AccessFlags = 33)]
		public partial class TransitionSet : global::Android.Transition.Transition
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ORDERING_TOGETHER
				/// </java-name>
				[Dot42.DexImport("ORDERING_TOGETHER", "I", AccessFlags = 25)]
				public const int ORDERING_TOGETHER = 0;
				/// <java-name>
				/// ORDERING_SEQUENTIAL
				/// </java-name>
				[Dot42.DexImport("ORDERING_SEQUENTIAL", "I", AccessFlags = 25)]
				public const int ORDERING_SEQUENTIAL = 1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TransitionSet() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOrdering
				/// </java-name>
				[Dot42.DexImport("setOrdering", "(I)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionSet SetOrdering(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// getOrdering
				/// </java-name>
				[Dot42.DexImport("getOrdering", "()I", AccessFlags = 1)]
				public virtual int GetOrdering() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// addTransition
				/// </java-name>
				[Dot42.DexImport("addTransition", "(Landroid/transition/Transition;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionSet AddTransition(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet SetDuration(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(J)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet SetStartDelay(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet SetInterpolator(global::Android.Animation.ITimeInterpolator timeInterpolator) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// addTarget
				/// </java-name>
				[Dot42.DexImport("addTarget", "(Landroid/view/View;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet AddTarget(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// addTarget
				/// </java-name>
				[Dot42.DexImport("addTarget", "(I)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet AddTarget(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// addListener
				/// </java-name>
				[Dot42.DexImport("addListener", "(Landroid/transition/Transition$TransitionListener;)Landroid/transition/Transitio" +
    "nSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet AddListener(global::Android.Transition.Transition.ITransitionListener transitionListener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// removeTarget
				/// </java-name>
				[Dot42.DexImport("removeTarget", "(I)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet RemoveTarget(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// removeTarget
				/// </java-name>
				[Dot42.DexImport("removeTarget", "(Landroid/view/View;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet RemoveTarget(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// removeListener
				/// </java-name>
				[Dot42.DexImport("removeListener", "(Landroid/transition/Transition$TransitionListener;)Landroid/transition/Transitio" +
    "nSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet RemoveListener(global::Android.Transition.Transition.ITransitionListener transitionListener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// removeTransition
				/// </java-name>
				[Dot42.DexImport("removeTransition", "(Landroid/transition/Transition;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionSet RemoveTransition(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// captureStartValues
				/// </java-name>
				[Dot42.DexImport("captureStartValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1)]
				public override void CaptureStartValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// captureEndValues
				/// </java-name>
				[Dot42.DexImport("captureEndValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1)]
				public override void CaptureEndValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// getOrdering
				/// </java-name>
				public int Ordering
				{
				[Dot42.DexImport("getOrdering", "()I", AccessFlags = 1)]
						get{ return GetOrdering(); }
				}

		}

		/// <java-name>
		/// android/transition/TransitionInflater
		/// </java-name>
		[Dot42.DexImport("android/transition/TransitionInflater", AccessFlags = 33)]
		public partial class TransitionInflater
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal TransitionInflater() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// from
				/// </java-name>
				[Dot42.DexImport("from", "(Landroid/content/Context;)Landroid/transition/TransitionInflater;", AccessFlags = 9)]
				public static global::Android.Transition.TransitionInflater From(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionInflater);
				}

				/// <java-name>
				/// inflateTransition
				/// </java-name>
				[Dot42.DexImport("inflateTransition", "(I)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition InflateTransition(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// inflateTransitionManager
				/// </java-name>
				[Dot42.DexImport("inflateTransitionManager", "(ILandroid/view/ViewGroup;)Landroid/transition/TransitionManager;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionManager InflateTransitionManager(int int32, global::Android.View.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionManager);
				}

		}

		/// <java-name>
		/// android/transition/AutoTransition
		/// </java-name>
		[Dot42.DexImport("android/transition/AutoTransition", AccessFlags = 33)]
		public partial class AutoTransition : global::Android.Transition.TransitionSet
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AutoTransition() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/transition/TransitionManager
		/// </java-name>
		[Dot42.DexImport("android/transition/TransitionManager", AccessFlags = 33)]
		public partial class TransitionManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TransitionManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTransition
				/// </java-name>
				[Dot42.DexImport("setTransition", "(Landroid/transition/Scene;Landroid/transition/Transition;)V", AccessFlags = 1)]
				public virtual void SetTransition(global::Android.Transition.Scene scene, global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTransition
				/// </java-name>
				[Dot42.DexImport("setTransition", "(Landroid/transition/Scene;Landroid/transition/Scene;Landroid/transition/Transiti" +
    "on;)V", AccessFlags = 1)]
				public virtual void SetTransition(global::Android.Transition.Scene scene, global::Android.Transition.Scene scene1, global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transitionTo
				/// </java-name>
				[Dot42.DexImport("transitionTo", "(Landroid/transition/Scene;)V", AccessFlags = 1)]
				public virtual void TransitionTo(global::Android.Transition.Scene scene) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// go
				/// </java-name>
				[Dot42.DexImport("go", "(Landroid/transition/Scene;)V", AccessFlags = 9)]
				public static void Go(global::Android.Transition.Scene scene) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// go
				/// </java-name>
				[Dot42.DexImport("go", "(Landroid/transition/Scene;Landroid/transition/Transition;)V", AccessFlags = 9)]
				public static void Go(global::Android.Transition.Scene scene, global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginDelayedTransition
				/// </java-name>
				[Dot42.DexImport("beginDelayedTransition", "(Landroid/view/ViewGroup;)V", AccessFlags = 9)]
				public static void BeginDelayedTransition(global::Android.View.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginDelayedTransition
				/// </java-name>
				[Dot42.DexImport("beginDelayedTransition", "(Landroid/view/ViewGroup;Landroid/transition/Transition;)V", AccessFlags = 9)]
				public static void BeginDelayedTransition(global::Android.View.ViewGroup viewGroup, global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/transition/Fade
		/// </java-name>
		[Dot42.DexImport("android/transition/Fade", AccessFlags = 33)]
		public partial class Fade : global::Android.Transition.Visibility
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// IN
				/// </java-name>
				[Dot42.DexImport("IN", "I", AccessFlags = 25)]
				public const int IN = 1;
				/// <java-name>
				/// OUT
				/// </java-name>
				[Dot42.DexImport("OUT", "I", AccessFlags = 25)]
				public const int OUT = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Fade() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Fade(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// captureStartValues
				/// </java-name>
				[Dot42.DexImport("captureStartValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1)]
				public override void CaptureStartValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAppear
				/// </java-name>
				[Dot42.DexImport("onAppear", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;ILandroid/transitio" +
    "n/TransitionValues;I)Landroid/animation/Animator;", AccessFlags = 1)]
				public override global::Android.Animation.Animator OnAppear(global::Android.View.ViewGroup viewGroup, global::Android.Transition.TransitionValues transitionValues, int int32, global::Android.Transition.TransitionValues transitionValues1, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// onDisappear
				/// </java-name>
				[Dot42.DexImport("onDisappear", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;ILandroid/transitio" +
    "n/TransitionValues;I)Landroid/animation/Animator;", AccessFlags = 1)]
				public override global::Android.Animation.Animator OnDisappear(global::Android.View.ViewGroup viewGroup, global::Android.Transition.TransitionValues transitionValues, int int32, global::Android.Transition.TransitionValues transitionValues1, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

		}

		/// <java-name>
		/// android/transition/Scene
		/// </java-name>
		[Dot42.DexImport("android/transition/Scene", AccessFlags = 49)]
		public sealed partial class Scene
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup;)V", AccessFlags = 1)]
				public Scene(global::Android.View.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup;Landroid/view/ViewGroup;)V", AccessFlags = 1)]
				public Scene(global::Android.View.ViewGroup viewGroup, global::Android.View.ViewGroup viewGroup1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSceneForLayout
				/// </java-name>
				[Dot42.DexImport("getSceneForLayout", "(Landroid/view/ViewGroup;ILandroid/content/Context;)Landroid/transition/Scene;", AccessFlags = 9)]
				public static global::Android.Transition.Scene GetSceneForLayout(global::Android.View.ViewGroup viewGroup, int int32, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Scene);
				}

				/// <java-name>
				/// getSceneRoot
				/// </java-name>
				[Dot42.DexImport("getSceneRoot", "()Landroid/view/ViewGroup;", AccessFlags = 1)]
				public global::Android.View.ViewGroup GetSceneRoot() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.ViewGroup);
				}

				/// <java-name>
				/// exit
				/// </java-name>
				[Dot42.DexImport("exit", "()V", AccessFlags = 1)]
				public void Exit() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enter
				/// </java-name>
				[Dot42.DexImport("enter", "()V", AccessFlags = 1)]
				public void Enter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEnterAction
				/// </java-name>
				[Dot42.DexImport("setEnterAction", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public void SetEnterAction(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExitAction
				/// </java-name>
				[Dot42.DexImport("setExitAction", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public void SetExitAction(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Scene() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSceneRoot
				/// </java-name>
				public global::Android.View.ViewGroup SceneRoot
				{
				[Dot42.DexImport("getSceneRoot", "()Landroid/view/ViewGroup;", AccessFlags = 1)]
						get{ return GetSceneRoot(); }
				}

		}

		/// <java-name>
		/// android/transition/TransitionValues
		/// </java-name>
		[Dot42.DexImport("android/transition/TransitionValues", AccessFlags = 33)]
		public partial class TransitionValues
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// view
				/// </java-name>
				[Dot42.DexImport("view", "Landroid/view/View;", AccessFlags = 1)]
				public global::Android.View.View View;
				/// <java-name>
				/// values
				/// </java-name>
				[Dot42.DexImport("values", "Ljava/util/Map;", AccessFlags = 17)]
				public readonly global::Java.Util.IMap<string, object> Values;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TransitionValues() /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <java-name>
		/// android/transition/Transition
		/// </java-name>
		[Dot42.DexImport("android/transition/Transition", AccessFlags = 1057)]
		public abstract partial class Transition : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Transition() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition SetDuration(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
				public virtual long GetDuration() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(J)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition SetStartDelay(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// getStartDelay
				/// </java-name>
				[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
				public virtual long GetStartDelay() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition SetInterpolator(global::Android.Animation.ITimeInterpolator timeInterpolator) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
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
				/// getTransitionProperties
				/// </java-name>
				[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
				public virtual string[] GetTransitionProperties() /* MethodBuilder.Create */ 
				{
						return default(string[]);
				}

				/// <java-name>
				/// createAnimator
				/// </java-name>
				[Dot42.DexImport("createAnimator", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;Landroid/transition" +
    "/TransitionValues;)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator CreateAnimator(global::Android.View.ViewGroup viewGroup, global::Android.Transition.TransitionValues transitionValues, global::Android.Transition.TransitionValues transitionValues1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// captureStartValues
				/// </java-name>
				[Dot42.DexImport("captureStartValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1025)]
				public abstract void CaptureStartValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// captureEndValues
				/// </java-name>
				[Dot42.DexImport("captureEndValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1025)]
				public abstract void CaptureEndValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addTarget
				/// </java-name>
				[Dot42.DexImport("addTarget", "(I)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition AddTarget(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// removeTarget
				/// </java-name>
				[Dot42.DexImport("removeTarget", "(I)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition RemoveTarget(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// excludeTarget
				/// </java-name>
				[Dot42.DexImport("excludeTarget", "(IZ)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition ExcludeTarget(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// excludeChildren
				/// </java-name>
				[Dot42.DexImport("excludeChildren", "(IZ)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition ExcludeChildren(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// excludeTarget
				/// </java-name>
				[Dot42.DexImport("excludeTarget", "(Landroid/view/View;Z)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition ExcludeTarget(global::Android.View.View view, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// excludeChildren
				/// </java-name>
				[Dot42.DexImport("excludeChildren", "(Landroid/view/View;Z)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition ExcludeChildren(global::Android.View.View view, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// excludeTarget
				/// </java-name>
				[Dot42.DexImport("excludeTarget", "(Ljava/lang/Class;Z)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition ExcludeTarget(global::System.Type type, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// excludeChildren
				/// </java-name>
				[Dot42.DexImport("excludeChildren", "(Ljava/lang/Class;Z)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition ExcludeChildren(global::System.Type type, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// addTarget
				/// </java-name>
				[Dot42.DexImport("addTarget", "(Landroid/view/View;)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition AddTarget(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// removeTarget
				/// </java-name>
				[Dot42.DexImport("removeTarget", "(Landroid/view/View;)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition RemoveTarget(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// getTargetIds
				/// </java-name>
				[Dot42.DexImport("getTargetIds", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
				public virtual global::Java.Util.IList<int?> GetTargetIds() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<int?>);
				}

				/// <java-name>
				/// getTargets
				/// </java-name>
				[Dot42.DexImport("getTargets", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/View;>;")]
				public virtual global::Java.Util.IList<global::Android.View.View> GetTargets() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.View.View>);
				}

				/// <java-name>
				/// getTransitionValues
				/// </java-name>
				[Dot42.DexImport("getTransitionValues", "(Landroid/view/View;Z)Landroid/transition/TransitionValues;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionValues GetTransitionValues(global::Android.View.View view, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionValues);
				}

				/// <java-name>
				/// addListener
				/// </java-name>
				[Dot42.DexImport("addListener", "(Landroid/transition/Transition$TransitionListener;)Landroid/transition/Transitio" +
    "n;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition AddListener(global::Android.Transition.Transition.ITransitionListener transitionListener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// removeListener
				/// </java-name>
				[Dot42.DexImport("removeListener", "(Landroid/transition/Transition$TransitionListener;)Landroid/transition/Transitio" +
    "n;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition RemoveListener(global::Android.Transition.Transition.ITransitionListener transitionListener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
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
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// getName
				/// </java-name>
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public long Duration
				{
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return GetDuration(); }
				}

				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public long StartDelay
				{
				[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
						get{ return GetStartDelay(); }
				}

				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public global::Android.Animation.ITimeInterpolator Interpolator
				{
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
						get{ return GetInterpolator(); }
				}

				/// <java-name>
				/// getTransitionProperties
				/// </java-name>
				public string[] TransitionProperties
				{
				[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetTransitionProperties(); }
				}

				/// <java-name>
				/// getTargetIds
				/// </java-name>
				public global::Java.Util.IList<int?> TargetIds
				{
				[Dot42.DexImport("getTargetIds", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						get{ return GetTargetIds(); }
				}

				/// <java-name>
				/// getTargets
				/// </java-name>
				public global::Java.Util.IList<global::Android.View.View> Targets
				{
				[Dot42.DexImport("getTargets", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/View;>;")]
						get{ return GetTargets(); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
				[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetName(); }
				}

				/// <java-name>
				/// android/transition/Transition$TransitionListener
				/// </java-name>
				[Dot42.DexImport("android/transition/Transition$TransitionListener", AccessFlags = 1545)]
				public partial interface ITransitionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTransitionStart
						/// </java-name>
						[Dot42.DexImport("onTransitionStart", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionStart(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onTransitionEnd
						/// </java-name>
						[Dot42.DexImport("onTransitionEnd", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionEnd(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onTransitionCancel
						/// </java-name>
						[Dot42.DexImport("onTransitionCancel", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionCancel(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onTransitionPause
						/// </java-name>
						[Dot42.DexImport("onTransitionPause", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionPause(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onTransitionResume
						/// </java-name>
						[Dot42.DexImport("onTransitionResume", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionResume(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

				}

		}

}


