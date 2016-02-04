#pragma warning disable 1717
namespace Android.Transition
{
		/// <summary>
		///  <para>Utility class for creating a default transition that automatically fades, moves, and resizes views during a scene change.</para> <para>An AutoTransition can be described in a resource file by using the tag  <code>autoTransition</code>, along with the other standard attributes of android.R.styleable#Transition.</para>    
		/// </summary>
		/// <java-name>
		/// android/transition/AutoTransition
		/// </java-name>
		[Dot42.DexImport("android/transition/AutoTransition", AccessFlags = 33)]
		public partial class AutoTransition : global::Android.Transition.TransitionSet
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs an AutoTransition object, which is a TransitionSet which first fades out disappearing targets, then moves and resizes existing targets, and finally fades in appearing targets. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AutoTransition() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>This transition captures the layout bounds of target views before and after the scene change and animates those changes during the transition.</para> <para>A ChangeBounds transition can be described in a resource file by using the tag  <code>changeBounds</code>, along with the other standard attributes of android.R.styleable#Transition.</para>    
		/// </summary>
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
				/// setResizeClip
				/// </java-name>
				[Dot42.DexImport("setResizeClip", "(Z)V", AccessFlags = 1)]
				public virtual void SetResizeClip(bool resizeClip) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Setting this flag tells ChangeBounds to track the before/after parent of every view using this transition. The flag is not enabled by default because it requires the parent instances to be the same in the two scenes or else all parents must use ids to allow the transition to determine which parents are the same.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setReparent
				/// </java-name>
				[Dot42.DexImport("setReparent", "(Z)V", AccessFlags = 1)]
				public virtual void SetReparent(bool reparent) /* MethodBuilder.Create */ 
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
				public override global::Android.Animation.Animator CreateAnimator(global::Android.Views.ViewGroup sceneRoot, global::Android.Transition.TransitionValues startValues, global::Android.Transition.TransitionValues endValues) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// getTransitionProperties
				/// </java-name>
				public override string[] TransitionProperties
				{
						[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

		}

		/// <summary>
		///  <para>This transition tracks changes to the visibility of target views in the start and end scenes and fades views in or out when they become visible or non-visible. Visibility is determined by both the View#setVisibility(int) state of the view as well as whether it is parented in the current view hierarchy.</para> <para>The ability of this transition to fade out a particular view, and the way that that fading operation takes place, is based on the situation of the view in the view hierarchy. For example, if a view was simply removed from its parent, then the view will be added into a android.view.ViewGroupOverlay while fading. If a visible view is changed to be View#GONE or View#INVISIBLE, then the visibility will be changed to View#VISIBLE for the duration of the animation. However, if a view is in a hierarchy which is also altering its visibility, the situation can be more complicated. In general, if a view that is no longer in the hierarchy in the end scene still has a parent (so its parent hierarchy was removed, but it was not removed from its parent), then it will be left alone to avoid side-effects from improperly removing it from its parent. The only exception to this is if the previous Scene was created from a layout resource file, then it is considered safe to un-parent the starting scene view in order to fade it out.</para> <para>A Fade transition can be described in a resource file by using the tag  <code>fade</code>, along with the standard attributes of android.R.styleable#Fade and android.R.styleable#Transition.</para>    
		/// </summary>
		/// <java-name>
		/// android/transition/Fade
		/// </java-name>
		[Dot42.DexImport("android/transition/Fade", AccessFlags = 33)]
		public partial class Fade : global::Android.Transition.Visibility
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Fading mode used in Fade(int) to make the transition operate on targets that are appearing. Maybe be combined with OUT to fade both in and out. </para>        
				/// </summary>
				/// <java-name>
				/// IN
				/// </java-name>
				[Dot42.DexImport("IN", "I", AccessFlags = 25)]
				public const int IN = 1;
				/// <summary>
				///  <para>Fading mode used in Fade(int) to make the transition operate on targets that are disappearing. Maybe be combined with IN to fade both in and out. </para>        
				/// </summary>
				/// <java-name>
				/// OUT
				/// </java-name>
				[Dot42.DexImport("OUT", "I", AccessFlags = 25)]
				public const int OUT = 2;
				/// <summary>
				///  <para>Constructs a Fade transition that will fade targets in and out. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Fade() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a Fade transition that will fade targets in and/or out, according to the value of fadingMode.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public Fade(int fadingMode) /* MethodBuilder.Create */ 
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
				public override global::Android.Animation.Animator OnAppear(global::Android.Views.ViewGroup sceneRoot, global::Android.Transition.TransitionValues startValues, int startVisibility, global::Android.Transition.TransitionValues endValues, int endVisibility) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// onDisappear
				/// </java-name>
				[Dot42.DexImport("onDisappear", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;ILandroid/transitio" +
    "n/TransitionValues;I)Landroid/animation/Animator;", AccessFlags = 1)]
				public override global::Android.Animation.Animator OnDisappear(global::Android.Views.ViewGroup sceneRoot, global::Android.Transition.TransitionValues startValues, int startVisibility, global::Android.Transition.TransitionValues endValues, int endVisibility) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

		}

		/// <summary>
		///  <para>A scene represents the collection of values that various properties in the View hierarchy will have when the scene is applied. A Scene can be configured to automatically run a Transition when it is applied, which will animate the various property changes that take place during the scene change. </para>    
		/// </summary>
		/// <java-name>
		/// android/transition/Scene
		/// </java-name>
		[Dot42.DexImport("android/transition/Scene", AccessFlags = 49)]
		public sealed partial class Scene
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a Scene with no information about how values will change when this scene is applied. This constructor might be used when a Scene is created with the intention of being dynamically configured, through setting setEnterAction(Runnable) and possibly setExitAction(Runnable).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup;)V", AccessFlags = 1)]
				public Scene(global::Android.Views.ViewGroup sceneRoot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructs a Scene which, when entered, will remove any children from the sceneRoot container and add the layout object as a new child of that container.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup;Landroid/view/ViewGroup;)V", AccessFlags = 1)]
				public Scene(global::Android.Views.ViewGroup sceneRoot, global::Android.Views.ViewGroup layout) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a Scene described by the resource file associated with the given  <code>layoutId</code> parameter. If such a Scene has already been created for the given  <code>sceneRoot</code>, that same Scene will be returned. This caching of layoutId-based scenes enables sharing of common scenes between those created in code and those referenced by TransitionManager XML resource files.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The scene for the given root and layout id </para>
				/// </returns>
				/// <java-name>
				/// getSceneForLayout
				/// </java-name>
				[Dot42.DexImport("getSceneForLayout", "(Landroid/view/ViewGroup;ILandroid/content/Context;)Landroid/transition/Scene;", AccessFlags = 9)]
				public static global::Android.Transition.Scene GetSceneForLayout(global::Android.Views.ViewGroup sceneRoot, int layoutId, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Scene);
				}

				/// <summary>
				///  <para>Exits this scene, if it is the current scene on the scene's scene root. The current scene is set when entering a scene. Exiting a scene runs the exit action if there is one. </para>        
				/// </summary>
				/// <java-name>
				/// exit
				/// </java-name>
				[Dot42.DexImport("exit", "()V", AccessFlags = 1)]
				public void Exit() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enters this scene, which entails changing all values that are specified by this scene. These may be values associated with a layout view group or layout resource file which will now be added to the scene root, or it may be values changed by an setEnterAction(Runnable) enter action}, or a combination of the these. No transition will be run when the scene is entered. To get transition behavior in scene changes, use one of the methods in TransitionManager instead. </para>        
				/// </summary>
				/// <java-name>
				/// enter
				/// </java-name>
				[Dot42.DexImport("enter", "()V", AccessFlags = 1)]
				public void Enter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Scenes that are not defined with layout resources or hierarchies, or which need to perform additional steps after those hierarchies are changed to, should set an enter action, and possibly an exit action as well. An enter action will cause Scene to call back into application code to do anything else the application needs after transitions have captured pre-change values and after any other scene changes have been applied, such as the layout (if any) being added to the view hierarchy. After this method is called, Transitions will be played.</para> <para> <para>setExitAction(Runnable) </para> <para>Scene::Scene(ViewGroup, int, Context) </para> <para>Scene::Scene(ViewGroup, ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEnterAction
				/// </java-name>
				[Dot42.DexImport("setEnterAction", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public void SetEnterAction(global::Java.Lang.IRunnable action) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Scenes that are not defined with layout resources or hierarchies, or which need to perform additional steps after those hierarchies are changed to, should set an enter action, and possibly an exit action as well. An exit action will cause Scene to call back into application code to do anything the application needs to do after applicable transitions have captured pre-change values, but before any other scene changes have been applied, such as the new layout (if any) being added to the view hierarchy. After this method is called, the next scene will be entered, including a call to setEnterAction(Runnable) if an enter action is set.</para> <para> <para>setEnterAction(Runnable) </para> <para>Scene::Scene(ViewGroup, int, Context) </para> <para>Scene::Scene(ViewGroup, ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// setExitAction
				/// </java-name>
				[Dot42.DexImport("setExitAction", "(Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public void SetExitAction(global::Java.Lang.IRunnable action) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal Scene() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Gets the root of the scene, which is the root of the view hierarchy affected by changes due to this scene, and which will be animated when this scene is entered.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The root of the view hierarchy affected by this scene. </para>
				/// </returns>
				/// <java-name>
				/// getSceneRoot
				/// </java-name>
				public global::Android.Views.ViewGroup SceneRoot
				{
						[Dot42.DexImport("getSceneRoot", "()Landroid/view/ViewGroup;", AccessFlags = 1)]
						get{ return default(global::Android.Views.ViewGroup); }
				}

		}

		/// <summary>
		///  <para>A Transition holds information about animations that will be run on its targets during a scene change. Subclasses of this abstract class may choreograph several child transitions (TransitionSet or they may perform custom animations themselves. Any Transition has two main jobs: (1) capture property values, and (2) play animations based on changes to captured property values. A custom transition knows what property values on View objects are of interest to it, and also knows how to animate changes to those values. For example, the Fade transition tracks changes to visibility-related properties and is able to construct and run animations that fade items in or out based on changes to those properties.</para> <para>Note: Transitions may not work correctly with either SurfaceView or TextureView, due to the way that these views are displayed on the screen. For SurfaceView, the problem is that the view is updated from a non-UI thread, so changes to the view due to transitions (such as moving and resizing the view) may be out of sync with the display inside those bounds. TextureView is more compatible with transitions in general, but some specific transitions (such as Fade) may not be compatible with TextureView because they rely on ViewOverlay functionality, which does not currently work with TextureView.</para> <para>Transitions can be declared in XML resource files inside the  <code>res/transition</code> directory. Transition resources consist of a tag name for one of the Transition subclasses along with attributes to define some of the attributes of that transition. For example, here is a minimal resource file that declares a ChangeBounds transition:</para> <para>{ development/samples/ApiDemos/res/transition/changebounds.xml ChangeBounds}</para> <para>Note that attributes for the transition are not required, just as they are optional when declared in code; Transitions created from XML resources will use the same defaults as their code-created equivalents. Here is a slightly more elaborate example which declares a TransitionSet transition with ChangeBounds and Fade child transitions:</para> <para>{ development/samples/ApiDemos/res/transition/changebounds_fadeout_sequential.xml TransitionSet}</para> <para>In this example, the transitionOrdering attribute is used on the TransitionSet object to change from the default TransitionSet#ORDERING_TOGETHER behavior to be TransitionSet#ORDERING_SEQUENTIAL instead. Also, the Fade transition uses a fadingMode of Fade#OUT instead of the default out-in behavior. Finally, note the use of the  <code>targets</code> sub-tag, which takes a set of target tags, each of which lists a specific  <code>targetId</code> which this transition acts upon. Use of targets is optional, but can be used to either limit the time spent checking attributes on unchanging views, or limiting the types of animations run on specific views. In this case, we know that only the  <code>grayscaleContainer</code> will be disappearing, so we choose to limit the Fade transition to only that view.</para> <para>Further information on XML resource descriptions for transitions can be found for android.R.styleable#Transition, android.R.styleable#TransitionSet, android.R.styleable#TransitionTarget, and android.R.styleable#Fade. </para>    
		/// </summary>
		/// <java-name>
		/// android/transition/Transition
		/// </java-name>
		[Dot42.DexImport("android/transition/Transition", AccessFlags = 1057)]
		public abstract partial class Transition : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a Transition object with no target objects. A transition with no targets defaults to running on all target objects in the scene hierarchy (if the transition is not contained in a TransitionSet), or all target objects passed down from its parent (if it is in a TransitionSet). </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Transition() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the duration of this transition. By default, there is no duration (indicated by a negative number), which means that the Animator created by the transition will have its own specified duration. If the duration of a Transition is set, that duration will override the Animator duration.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transition object.  ref android.R.styleable::Transition_duration </para>
				/// </returns>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition SetDuration(long duration) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <summary>
				///  <para>Sets the startDelay of this transition. By default, there is no delay (indicated by a negative number), which means that the Animator created by the transition will have its own specified startDelay. If the delay of a Transition is set, that delay will override the Animator delay.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transition object.  ref android.R.styleable::Transition_startDelay </para>
				/// </returns>
				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(J)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition SetStartDelay(long startDelay) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <summary>
				///  <para>Sets the interpolator of this transition. By default, the interpolator is null, which means that the Animator created by the transition will have its own specified interpolator. If the interpolator of a Transition is set, that interpolator will override the Animator interpolator.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transition object.  ref android.R.styleable::Transition_interpolator </para>
				/// </returns>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition SetInterpolator(global::Android.Animation.ITimeInterpolator interpolator) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <summary>
				///  <para>This method creates an animation that will be run for this transition given the information in the startValues and endValues structures captured earlier for the start and end scenes. Subclasses of Transition should override this method. The method should only be called by the transition system; it is not intended to be called from external classes.</para> <para>This method is called by the transition's parent (all the way up to the topmost Transition in the hierarchy) with the sceneRoot and start/end values that the transition may need to set up initial target values and construct an appropriate animation. For example, if an overall Transition is a TransitionSet consisting of several child transitions in sequence, then some of the child transitions may want to set initial values on target views prior to the overall Transition commencing, to put them in an appropriate state for the delay between that start and the child Transition start time. For example, a transition that fades an item in may wish to set the starting alpha value to 0, to avoid it blinking in prior to the transition actually starting the animation. This is necessary because the scene change that triggers the Transition will automatically set the end-scene on all target views, so a Transition that wants to animate from a different value should set that value prior to returning from this method.</para> <para>Additionally, a Transition can perform logic to determine whether the transition needs to run on the given target and start/end values. For example, a transition that resizes objects on the screen may wish to avoid running for views which are not present in either the start or end scenes.</para> <para>If there is an animator created and returned from this method, the transition mechanism will apply any applicable duration, startDelay, and interpolator to that animation and start it. A return value of  <code>null</code> indicates that no animation should run. The default implementation returns null.</para> <para>The method is called for every applicable target object, which is stored in the TransitionValues#view field.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A Animator to be started at the appropriate time in the overall transition for this scene change. A null value means no animation should be run. </para>
				/// </returns>
				/// <java-name>
				/// createAnimator
				/// </java-name>
				[Dot42.DexImport("createAnimator", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;Landroid/transition" +
    "/TransitionValues;)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator CreateAnimator(global::Android.Views.ViewGroup sceneRoot, global::Android.Transition.TransitionValues startValues, global::Android.Transition.TransitionValues endValues) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <summary>
				///  <para>Captures the values in the start scene for the properties that this transition monitors. These values are then passed as the startValues structure in a later call to createAnimator(ViewGroup, TransitionValues, TransitionValues). The main concern for an implementation is what the properties are that the transition cares about and what the values are for all of those properties. The start and end values will be compared later during the createAnimator(android.view.ViewGroup, TransitionValues, TransitionValues) method to determine what, if any, animations, should be run.</para> <para>Subclasses must implement this method. The method should only be called by the transition system; it is not intended to be called from external classes.</para> <para> <para>captureEndValues(TransitionValues) </para> <para>createAnimator(ViewGroup, TransitionValues, TransitionValues) </para></para>        
				/// </summary>
				/// <java-name>
				/// captureStartValues
				/// </java-name>
				[Dot42.DexImport("captureStartValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1025)]
				public abstract void CaptureStartValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Captures the values in the end scene for the properties that this transition monitors. These values are then passed as the endValues structure in a later call to createAnimator(ViewGroup, TransitionValues, TransitionValues). The main concern for an implementation is what the properties are that the transition cares about and what the values are for all of those properties. The start and end values will be compared later during the createAnimator(android.view.ViewGroup, TransitionValues, TransitionValues) method to determine what, if any, animations, should be run.</para> <para>Subclasses must implement this method. The method should only be called by the transition system; it is not intended to be called from external classes.</para> <para> <para>captureStartValues(TransitionValues) </para> <para>createAnimator(ViewGroup, TransitionValues, TransitionValues) </para></para>        
				/// </summary>
				/// <java-name>
				/// captureEndValues
				/// </java-name>
				[Dot42.DexImport("captureEndValues", "(Landroid/transition/TransitionValues;)V", AccessFlags = 1025)]
				public abstract void CaptureEndValues(global::Android.Transition.TransitionValues transitionValues) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Adds the id of a target view that this Transition is interested in animating. By default, there are no targetIds, and a Transition will listen for changes on every view in the hierarchy below the sceneRoot of the Scene being transitioned into. Setting targetIds constrains the Transition to only listen for, and act on, views with these IDs. Views with different IDs, or no IDs whatsoever, will be ignored.</para> <para>Note that using ids to specify targets implies that ids should be unique within the view hierarchy underneat the scene root.</para> <para> <para>View::getId() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Transition to which the targetId is added. Returning the same object makes it easier to chain calls during construction, such as  <code>transitionSet.addTransitions(new Fade()).addTarget(someId);</code> </para>
				/// </returns>
				/// <java-name>
				/// addTarget
				/// </java-name>
				[Dot42.DexImport("addTarget", "(I)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition AddTarget(int targetId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <summary>
				///  <para>Removes the given targetId from the list of ids that this Transition is interested in animating.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Transition from which the targetId is removed. Returning the same object makes it easier to chain calls during construction, such as  <code>transitionSet.addTransitions(new Fade()).removeTargetId(someId);</code> </para>
				/// </returns>
				/// <java-name>
				/// removeTarget
				/// </java-name>
				[Dot42.DexImport("removeTarget", "(I)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition RemoveTarget(int targetId) /* MethodBuilder.Create */ 
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
				public virtual global::Android.Transition.Transition ExcludeTarget(global::Android.Views.View view, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <java-name>
				/// excludeChildren
				/// </java-name>
				[Dot42.DexImport("excludeChildren", "(Landroid/view/View;Z)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition ExcludeChildren(global::Android.Views.View view, bool boolean) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Adds the id of a target view that this Transition is interested in animating. By default, there are no targetIds, and a Transition will listen for changes on every view in the hierarchy below the sceneRoot of the Scene being transitioned into. Setting targetIds constrains the Transition to only listen for, and act on, views with these IDs. Views with different IDs, or no IDs whatsoever, will be ignored.</para> <para>Note that using ids to specify targets implies that ids should be unique within the view hierarchy underneat the scene root.</para> <para> <para>View::getId() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Transition to which the targetId is added. Returning the same object makes it easier to chain calls during construction, such as  <code>transitionSet.addTransitions(new Fade()).addTarget(someId);</code> </para>
				/// </returns>
				/// <java-name>
				/// addTarget
				/// </java-name>
				[Dot42.DexImport("addTarget", "(Landroid/view/View;)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition AddTarget(global::Android.Views.View targetId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <summary>
				///  <para>Removes the given targetId from the list of ids that this Transition is interested in animating.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Transition from which the targetId is removed. Returning the same object makes it easier to chain calls during construction, such as  <code>transitionSet.addTransitions(new Fade()).removeTargetId(someId);</code> </para>
				/// </returns>
				/// <java-name>
				/// removeTarget
				/// </java-name>
				[Dot42.DexImport("removeTarget", "(Landroid/view/View;)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition RemoveTarget(global::Android.Views.View targetId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <summary>
				///  <para>This method can be called by transitions to get the TransitionValues for any particular view during the transition-playing process. This might be necessary, for example, to query the before/after state of related views for a given transition. </para>        
				/// </summary>
				/// <java-name>
				/// getTransitionValues
				/// </java-name>
				[Dot42.DexImport("getTransitionValues", "(Landroid/view/View;Z)Landroid/transition/TransitionValues;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionValues GetTransitionValues(global::Android.Views.View view, bool start) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionValues);
				}

				/// <summary>
				///  <para>Adds a listener to the set of listeners that are sent events through the life of an animation, such as start, repeat, and end.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transition object. </para>
				/// </returns>
				/// <java-name>
				/// addListener
				/// </java-name>
				[Dot42.DexImport("addListener", "(Landroid/transition/Transition$TransitionListener;)Landroid/transition/Transitio" +
    "n;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition AddListener(global::Android.Transition.Transition.ITransitionListener listener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <summary>
				///  <para>Removes a listener from the set listening to this animation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transition object. </para>
				/// </returns>
				/// <java-name>
				/// removeListener
				/// </java-name>
				[Dot42.DexImport("removeListener", "(Landroid/transition/Transition$TransitionListener;)Landroid/transition/Transitio" +
    "n;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition RemoveListener(global::Android.Transition.Transition.ITransitionListener listener) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the duration set on this transition. If no duration has been set, the returned value will be negative, indicating that resulting animators will retain their own durations.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The duration set on this transition, in milliseconds, if one has been set, otherwise returns a negative number. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public virtual long Duration
				{
						[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the startDelay set on this transition. If no startDelay has been set, the returned value will be negative, indicating that resulting animators will retain their own startDelays.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The startDelay set on this transition, in milliseconds, if one has been set, otherwise returns a negative number. </para>
				/// </returns>
				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public virtual long StartDelay
				{
						[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Returns the interpolator set on this transition. If no interpolator has been set, the returned value will be null, indicating that resulting animators will retain their own interpolators.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The interpolator set on this transition, if one has been set, otherwise returns null. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public virtual global::Android.Animation.ITimeInterpolator Interpolator
				{
						[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
						get{ return default(global::Android.Animation.ITimeInterpolator); }
				}

				/// <summary>
				///  <para>Returns the set of property names used stored in the TransitionValues object passed into captureStartValues(TransitionValues) that this transition cares about for the purposes of canceling overlapping animations. When any transition is started on a given scene root, all transitions currently running on that same scene root are checked to see whether the properties on which they based their animations agree with the end values of the same properties in the new transition. If the end values are not equal, then the old animation is canceled since the new transition will start a new animation to these new values. If the values are equal, the old animation is allowed to continue and no new animation is started for that transition.</para> <para>A transition does not need to override this method. However, not doing so will mean that the cancellation logic outlined in the previous paragraph will be skipped for that transition, possibly leading to artifacts as old transitions and new transitions on the same targets run in parallel, animating views toward potentially different end values.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array of property names as described in the class documentation for TransitionValues. The default implementation returns  <code>null</code>. </para>
				/// </returns>
				/// <java-name>
				/// getTransitionProperties
				/// </java-name>
				public virtual string[] TransitionProperties
				{
						[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

				/// <summary>
				///  <para>Returns the array of target IDs that this transition limits itself to tracking and animating. If the array is null for both this method and getTargets(), then this transition is not limited to specific views, and will handle changes to any views in the hierarchy of a scene change.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of target IDs </para>
				/// </returns>
				/// <java-name>
				/// getTargetIds
				/// </java-name>
				public virtual global::Java.Util.IList<int?> TargetIds
				{
						[Dot42.DexImport("getTargetIds", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/Integer;>;")]
						get{ return default(global::Java.Util.IList<int?>); }
				}

				/// <summary>
				///  <para>Returns the array of target views that this transition limits itself to tracking and animating. If the array is null for both this method and getTargetIds(), then this transition is not limited to specific views, and will handle changes to any views in the hierarchy of a scene change.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the list of target views </para>
				/// </returns>
				/// <java-name>
				/// getTargets
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Views.View> Targets
				{
						[Dot42.DexImport("getTargets", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/View;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Views.View>); }
				}

				/// <summary>
				///  <para>Returns the name of this Transition. This name is used internally to distinguish between different transitions to determine when interrupting transitions overlap. For example, a ChangeBounds running on the same target view as another ChangeBounds should determine whether the old transition is animating to different end values and should be canceled in favor of the new transition.</para> <para>By default, a Transition's name is simply the value of Class#getName(), but subclasses are free to override and return something different.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The name of this transition. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public virtual string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>A transition listener receives notifications from a transition. Notifications indicate transition lifecycle events. </para>    
				/// </summary>
				/// <java-name>
				/// android/transition/Transition$TransitionListener
				/// </java-name>
				[Dot42.DexImport("android/transition/Transition$TransitionListener", AccessFlags = 1545)]
				public partial interface ITransitionListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Notification about the start of the transition.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTransitionStart
						/// </java-name>
						[Dot42.DexImport("onTransitionStart", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionStart(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notification about the end of the transition. Canceled transitions will always notify listeners of both the cancellation and end events. That is, onTransitionEnd(Transition) is always called, regardless of whether the transition was canceled or played through to completion.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTransitionEnd
						/// </java-name>
						[Dot42.DexImport("onTransitionEnd", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionEnd(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notification about the cancellation of the transition. Note that cancel may be called by a parent TransitionSet on a child transition which has not yet started. This allows the child transition to restore state on target objects which was set at createAnimator() time.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTransitionCancel
						/// </java-name>
						[Dot42.DexImport("onTransitionCancel", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionCancel(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notification when a transition is paused. Note that createAnimator() may be called by a parent TransitionSet on a child transition which has not yet started. This allows the child transition to restore state on target objects which was set at createAnimator() time.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTransitionPause
						/// </java-name>
						[Dot42.DexImport("onTransitionPause", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionPause(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notification when a transition is resumed. Note that resume() may be called by a parent TransitionSet on a child transition which has not yet started. This allows the child transition to restore state which may have changed in an earlier call to onTransitionPause(Transition).</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTransitionResume
						/// </java-name>
						[Dot42.DexImport("onTransitionResume", "(Landroid/transition/Transition;)V", AccessFlags = 1025)]
						void OnTransitionResume(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>This class inflates scenes and transitions from resource files.</para> <para>Information on XML resource descriptions for transitions can be found for android.R.styleable#Transition, android.R.styleable#TransitionSet, android.R.styleable#TransitionTarget, android.R.styleable#Fade, and android.R.styleable#TransitionManager. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Obtains the TransitionInflater from the given context. </para>        
				/// </summary>
				/// <java-name>
				/// from
				/// </java-name>
				[Dot42.DexImport("from", "(Landroid/content/Context;)Landroid/transition/TransitionInflater;", AccessFlags = 9)]
				public static global::Android.Transition.TransitionInflater From(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionInflater);
				}

				/// <summary>
				///  <para>Loads a Transition object from a resource</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The loaded Transition object </para>
				/// </returns>
				/// <java-name>
				/// inflateTransition
				/// </java-name>
				[Dot42.DexImport("inflateTransition", "(I)Landroid/transition/Transition;", AccessFlags = 1)]
				public virtual global::Android.Transition.Transition InflateTransition(int resource) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.Transition);
				}

				/// <summary>
				///  <para>Loads a TransitionManager object from a resource</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The loaded TransitionManager object </para>
				/// </returns>
				/// <java-name>
				/// inflateTransitionManager
				/// </java-name>
				[Dot42.DexImport("inflateTransitionManager", "(ILandroid/view/ViewGroup;)Landroid/transition/TransitionManager;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionManager InflateTransitionManager(int resource, global::Android.Views.ViewGroup sceneRoot) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionManager);
				}

		}

		/// <summary>
		///  <para>This class manages the set of transitions that fire when there is a change of Scene. To use the manager, add scenes along with transition objects with calls to setTransition(Scene, Transition) or setTransition(Scene, Scene, Transition). Setting specific transitions for scene changes is not required; by default, a Scene change will use AutoTransition to do something reasonable for most situations. Specifying other transitions for particular scene changes is only necessary if the application wants different transition behavior in these situations.</para> <para>TransitionManagers can be declared in XML resource files inside the  <code>res/transition</code> directory. TransitionManager resources consist of the  <code>transitionManager</code>tag name, containing one or more  <code>transition</code> tags, each of which describe the relationship of that transition to the from/to scene information in that tag. For example, here is a resource file that declares several scene transitions:</para> <para>{ development/samples/ApiDemos/res/transition/transitions_mgr.xml TransitionManager}</para> <para>For each of the  <code>fromScene</code> and  <code>toScene</code> attributes, there is a reference to a standard XML layout file. This is equivalent to creating a scene from a layout in code by calling Scene#getSceneForLayout(ViewGroup, int, Context). For the  <code>transition</code> attribute, there is a reference to a resource file in the  <code>res/transition</code> directory which describes that transition.</para> <para>Information on XML resource descriptions for transitions can be found for android.R.styleable#Transition, android.R.styleable#TransitionSet, android.R.styleable#TransitionTarget, android.R.styleable#Fade, and android.R.styleable#TransitionManager. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Sets a specific transition to occur when the given scene is entered.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTransition
				/// </java-name>
				[Dot42.DexImport("setTransition", "(Landroid/transition/Scene;Landroid/transition/Transition;)V", AccessFlags = 1)]
				public virtual void SetTransition(global::Android.Transition.Scene scene, global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets a specific transition to occur when the given pair of scenes is exited/entered.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setTransition
				/// </java-name>
				[Dot42.DexImport("setTransition", "(Landroid/transition/Scene;Landroid/transition/Scene;Landroid/transition/Transiti" +
    "on;)V", AccessFlags = 1)]
				public virtual void SetTransition(global::Android.Transition.Scene fromScene, global::Android.Transition.Scene toScene, global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change to the given scene, using the appropriate transition for this particular scene change (as specified to the TransitionManager, or the default if no such transition exists).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// transitionTo
				/// </java-name>
				[Dot42.DexImport("transitionTo", "(Landroid/transition/Scene;)V", AccessFlags = 1)]
				public virtual void TransitionTo(global::Android.Transition.Scene scene) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method to simply change to the given scene using the default transition for TransitionManager.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// go
				/// </java-name>
				[Dot42.DexImport("go", "(Landroid/transition/Scene;)V", AccessFlags = 9)]
				public static void Go(global::Android.Transition.Scene scene) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method to simply change to the given scene using the given transition.</para> <para>Passing in  <code>null</code> for the transition parameter will result in the scene changing without any transition running, and is equivalent to calling Scene#exit() on the scene root's current scene, followed by Scene#enter() on the scene specified by the  <code>scene</code> parameter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// go
				/// </java-name>
				[Dot42.DexImport("go", "(Landroid/transition/Scene;Landroid/transition/Transition;)V", AccessFlags = 9)]
				public static void Go(global::Android.Transition.Scene scene, global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method to animate, using the default transition, to a new scene defined by all changes within the given scene root between calling this method and the next rendering frame. Equivalent to calling beginDelayedTransition(ViewGroup, Transition) with a value of  <code>null</code> for the  <code>transition</code> parameter.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// beginDelayedTransition
				/// </java-name>
				[Dot42.DexImport("beginDelayedTransition", "(Landroid/view/ViewGroup;)V", AccessFlags = 9)]
				public static void BeginDelayedTransition(global::Android.Views.ViewGroup sceneRoot) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience method to animate to a new scene defined by all changes within the given scene root between calling this method and the next rendering frame. Calling this method causes TransitionManager to capture current values in the scene root and then post a request to run a transition on the next frame. At that time, the new values in the scene root will be captured and changes will be animated. There is no need to create a Scene; it is implied by changes which take place between calling this method and the next frame when the transition begins.</para> <para>Calling this method several times before the next frame (for example, if unrelated code also wants to make dynamic changes and run a transition on the same scene root), only the first call will trigger capturing values and exiting the current scene. Subsequent calls to the method with the same scene root during the same frame will be ignored.</para> <para>Passing in  <code>null</code> for the transition parameter will cause the TransitionManager to use its default transition.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// beginDelayedTransition
				/// </java-name>
				[Dot42.DexImport("beginDelayedTransition", "(Landroid/view/ViewGroup;Landroid/transition/Transition;)V", AccessFlags = 9)]
				public static void BeginDelayedTransition(global::Android.Views.ViewGroup sceneRoot, global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>A TransitionSet is a parent of child transitions (including other TransitionSets). Using TransitionSets enables more complex choreography of transitions, where some sets play ORDERING_TOGETHER and others play ORDERING_SEQUENTIAL. For example, AutoTransition uses a TransitionSet to sequentially play a Fade(Fade.OUT), followed by a ChangeBounds, followed by a Fade(Fade.OUT) transition.</para> <para>A TransitionSet can be described in a resource file by using the tag  <code>transitionSet</code>, along with the standard attributes of android.R.styleable#TransitionSet and android.R.styleable#Transition. Child transitions of the TransitionSet object can be loaded by adding those child tags inside the enclosing  <code>transitionSet</code> tag. For example, the following xml describes a TransitionSet that plays a Fade and then a ChangeBounds transition on the affected view targets:</para> <para> <pre>
		///     &lt;transitionSet xmlns:android="http://schemas.android.com/apk/res/android"
		///             android:ordering="sequential"&gt;
		///         &lt;fade/&gt;
		///         &lt;changeBounds/&gt;
		///     &lt;/transitionSet&gt;
		/// </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/transition/TransitionSet
		/// </java-name>
		[Dot42.DexImport("android/transition/TransitionSet", AccessFlags = 33)]
		public partial class TransitionSet : global::Android.Transition.Transition
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A flag used to indicate that the child transitions of this set should all start at the same time. </para>        
				/// </summary>
				/// <java-name>
				/// ORDERING_TOGETHER
				/// </java-name>
				[Dot42.DexImport("ORDERING_TOGETHER", "I", AccessFlags = 25)]
				public const int ORDERING_TOGETHER = 0;
				/// <summary>
				///  <para>A flag used to indicate that the child transitions of this set should play in sequence; when one child transition ends, the next child transition begins. Note that a transition does not end until all instances of it (which are playing on all applicable targets of the transition) end. </para>        
				/// </summary>
				/// <java-name>
				/// ORDERING_SEQUENTIAL
				/// </java-name>
				[Dot42.DexImport("ORDERING_SEQUENTIAL", "I", AccessFlags = 25)]
				public const int ORDERING_SEQUENTIAL = 1;
				/// <summary>
				///  <para>Constructs an empty transition set. Add child transitions to the set by calling addTransition(Transition) )}. By default, child transitions will play together. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TransitionSet() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the play order of this set's child transitions.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transitionSet object. </para>
				/// </returns>
				/// <java-name>
				/// setOrdering
				/// </java-name>
				[Dot42.DexImport("setOrdering", "(I)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionSet SetOrdering(int ordering) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <summary>
				///  <para>Adds child transition to this set. The order in which this child transition is added relative to other child transitions that are added, in addition to the ordering property, determines the order in which the transitions are started.</para> <para>If this transitionSet has a duration set on it, the child transition will inherit that duration. Transitions are assumed to have a maximum of one transitionSet parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transitionSet object. </para>
				/// </returns>
				/// <java-name>
				/// addTransition
				/// </java-name>
				[Dot42.DexImport("addTransition", "(Landroid/transition/Transition;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public virtual global::Android.Transition.TransitionSet AddTransition(global::Android.Transition.Transition transition) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <summary>
				///  <para>Setting a non-negative duration on a TransitionSet causes all of the child transitions (current and future) to inherit this duration.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transitionSet object. </para>
				/// </returns>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet SetDuration(long duration) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(J)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet SetStartDelay(long startDelay) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet SetInterpolator(global::Android.Animation.ITimeInterpolator interpolator) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// addTarget
				/// </java-name>
				[Dot42.DexImport("addTarget", "(Landroid/view/View;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet AddTarget(global::Android.Views.View target) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// addTarget
				/// </java-name>
				[Dot42.DexImport("addTarget", "(I)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet AddTarget(int target) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// addListener
				/// </java-name>
				[Dot42.DexImport("addListener", "(Landroid/transition/Transition$TransitionListener;)Landroid/transition/Transitio" +
    "nSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet AddListener(global::Android.Transition.Transition.ITransitionListener listener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// removeTarget
				/// </java-name>
				[Dot42.DexImport("removeTarget", "(I)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet RemoveTarget(int targetId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// removeTarget
				/// </java-name>
				[Dot42.DexImport("removeTarget", "(Landroid/view/View;)Landroid/transition/TransitionSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet RemoveTarget(global::Android.Views.View targetId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <java-name>
				/// removeListener
				/// </java-name>
				[Dot42.DexImport("removeListener", "(Landroid/transition/Transition$TransitionListener;)Landroid/transition/Transitio" +
    "nSet;", AccessFlags = 1)]
				public new virtual global::Android.Transition.TransitionSet RemoveListener(global::Android.Transition.Transition.ITransitionListener listener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Transition.TransitionSet);
				}

				/// <summary>
				///  <para>Removes the specified child transition from this set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This transitionSet object. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the ordering of this TransitionSet. By default, the value is ORDERING_TOGETHER.</para> <para> <para>setOrdering(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>ORDERING_TOGETHER if child transitions will play at the same time, ORDERING_SEQUENTIAL if they will play in sequence.</para>
				/// </returns>
				/// <java-name>
				/// getOrdering
				/// </java-name>
				public virtual int Ordering
				{
						[Dot42.DexImport("getOrdering", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>Data structure which holds cached values for the transition. The view field is the target which all of the values pertain to. The values field is a map which holds information for fields according to names selected by the transitions. These names should be unique to avoid clobbering values stored by other transitions, such as the convention project:transition_name:property_name. For example, the platform might store a property "alpha" in a transition "Fader" as "android:fader:alpha".</para> <para>These values are cached during the Transition#captureStartValues(TransitionValues) capture} phases of a scene change, once when the start values are captured and again when the end values are captured. These start/end values are then passed into the transitions via the for Transition#createAnimator(ViewGroup, TransitionValues, TransitionValues) method.</para>    
		/// </summary>
		/// <java-name>
		/// android/transition/TransitionValues
		/// </java-name>
		[Dot42.DexImport("android/transition/TransitionValues", AccessFlags = 33)]
		public partial class TransitionValues
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The View with these values </para>        
				/// </summary>
				/// <java-name>
				/// view
				/// </java-name>
				[Dot42.DexImport("view", "Landroid/view/View;", AccessFlags = 1)]
				public global::Android.Views.View View;
				/// <summary>
				///  <para>The set of values tracked by transitions for this scene </para>        
				/// </summary>
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
				public override bool Equals(object other) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>This transition tracks changes to the visibility of target views in the start and end scenes. Visibility is determined not just by the View#setVisibility(int) state of views, but also whether views exist in the current view hierarchy. The class is intended to be a utility for subclasses such as Fade, which use this visibility information to determine the specific animations to run when visibility changes occur. Subclasses should implement one or both of the methods onAppear(ViewGroup, TransitionValues, int, TransitionValues, int), onDisappear(ViewGroup, TransitionValues, int, TransitionValues, int), </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Returns whether the view is 'visible' according to the given values object. This is determined by testing the same properties in the values object that are used to determine whether the object is appearing or disappearing in the Transition#createAnimator(ViewGroup, TransitionValues, TransitionValues) method. This method can be called by, for example, subclasses that want to know whether the object is visible in the same way that Visibility determines it for the actual animation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the view reference by  <code>values</code> is visible, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isVisible
				/// </java-name>
				[Dot42.DexImport("isVisible", "(Landroid/transition/TransitionValues;)Z", AccessFlags = 1)]
				public virtual bool IsVisible(global::Android.Transition.TransitionValues values) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createAnimator
				/// </java-name>
				[Dot42.DexImport("createAnimator", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;Landroid/transition" +
    "/TransitionValues;)Landroid/animation/Animator;", AccessFlags = 1)]
				public override global::Android.Animation.Animator CreateAnimator(global::Android.Views.ViewGroup sceneRoot, global::Android.Transition.TransitionValues startValues, global::Android.Transition.TransitionValues endValues) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <summary>
				///  <para>The default implementation of this method does nothing. Subclasses should override if they need to create an Animator when targets appear. The method should only be called by the Visibility class; it is not intended to be called from external classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An Animator to be started at the appropriate time in the overall transition for this scene change. A null value means no animation should be run. </para>
				/// </returns>
				/// <java-name>
				/// onAppear
				/// </java-name>
				[Dot42.DexImport("onAppear", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;ILandroid/transitio" +
    "n/TransitionValues;I)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator OnAppear(global::Android.Views.ViewGroup sceneRoot, global::Android.Transition.TransitionValues startValues, int startVisibility, global::Android.Transition.TransitionValues endValues, int endVisibility) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <summary>
				///  <para>The default implementation of this method does nothing. Subclasses should override if they need to create an Animator when targets disappear. The method should only be called by the Visibility class; it is not intended to be called from external classes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An Animator to be started at the appropriate time in the overall transition for this scene change. A null value means no animation should be run. </para>
				/// </returns>
				/// <java-name>
				/// onDisappear
				/// </java-name>
				[Dot42.DexImport("onDisappear", "(Landroid/view/ViewGroup;Landroid/transition/TransitionValues;ILandroid/transitio" +
    "n/TransitionValues;I)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator OnDisappear(global::Android.Views.ViewGroup sceneRoot, global::Android.Transition.TransitionValues startValues, int startVisibility, global::Android.Transition.TransitionValues endValues, int endVisibility) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <java-name>
				/// getTransitionProperties
				/// </java-name>
				public override string[] TransitionProperties
				{
						[Dot42.DexImport("getTransitionProperties", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
				}

		}

}

