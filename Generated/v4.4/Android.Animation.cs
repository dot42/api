// Copyright (C) 2014 dot42
//
// Original filename: Android.Animation.cs
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
namespace Android.Animation
{
		/// <summary>
		/// <para>This class holds a time/value pair for an animation. The Keyframe class is used by ValueAnimator to define the values that the animation target will have over the course of the animation. As the time proceeds from one keyframe to the other, the value of the target object will animate between the value at the previous keyframe and the value at the next keyframe. Each keyframe also holds an optional TimeInterpolator object, which defines the time interpolation over the intervalue preceding the keyframe.</para><para>The Keyframe class itself is abstract. The type-specific factory methods will return a subclass of Keyframe specific to the type of value being stored. This is done to improve performance when dealing with the most common cases (e.g., <code>float</code> and <code>int</code> values). Other types will fall into a more general Keyframe class that treats its values as Objects. Unless your animation requires dealing with a custom type or a data structure that needs to be animated directly (and evaluated using an implementation of TypeEvaluator), you should stick to using float and int as animations using those types have lower runtime overhead than other types.</para>    
		/// </summary>
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

				/// <summary>
				/// <para>Constructs a Keyframe object with the given time and value. The time defines the time, as a proportion of an overall animation's duration, at which the value will hold true for the animation. The value for the animation between keyframes will be calculated as an interpolation between the values at those keyframes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "(FI)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfInt(float fraction, int value) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <summary>
				/// <para>Constructs a Keyframe object with the given time. The value at this time will be derived from the target object when the animation first starts (note that this implies that keyframes with no initial value must be used as part of an ObjectAnimator). The time defines the time, as a proportion of an overall animation's duration, at which the value will hold true for the animation. The value for the animation between keyframes will be calculated as an interpolation between the values at those keyframes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "(F)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfInt(float fraction) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <summary>
				/// <para>Constructs a Keyframe object with the given time and value. The time defines the time, as a proportion of an overall animation's duration, at which the value will hold true for the animation. The value for the animation between keyframes will be calculated as an interpolation between the values at those keyframes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "(FF)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfFloat(float fraction, float value) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <summary>
				/// <para>Constructs a Keyframe object with the given time. The value at this time will be derived from the target object when the animation first starts (note that this implies that keyframes with no initial value must be used as part of an ObjectAnimator). The time defines the time, as a proportion of an overall animation's duration, at which the value will hold true for the animation. The value for the animation between keyframes will be calculated as an interpolation between the values at those keyframes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "(F)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfFloat(float fraction) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <summary>
				/// <para>Constructs a Keyframe object with the given time and value. The time defines the time, as a proportion of an overall animation's duration, at which the value will hold true for the animation. The value for the animation between keyframes will be calculated as an interpolation between the values at those keyframes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(FLjava/lang/Object;)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfObject(float fraction, object value) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <summary>
				/// <para>Constructs a Keyframe object with the given time. The value at this time will be derived from the target object when the animation first starts (note that this implies that keyframes with no initial value must be used as part of an ObjectAnimator). The time defines the time, as a proportion of an overall animation's duration, at which the value will hold true for the animation. The value for the animation between keyframes will be calculated as an interpolation between the values at those keyframes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(F)Landroid/animation/Keyframe;", AccessFlags = 9)]
				public static global::Android.Animation.Keyframe OfObject(float fraction) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Keyframe);
				}

				/// <summary>
				/// <para>Indicates whether this keyframe has a valid value. This method is called internally when an ObjectAnimator first starts; keyframes without values are assigned values at that time by deriving the value for the property from the target object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Whether this object has a value assigned. </para>
				/// </returns>
				/// <java-name>
				/// hasValue
				/// </java-name>
				[Dot42.DexImport("hasValue", "()Z", AccessFlags = 1)]
				public virtual bool HasValue() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the value for this Keyframe.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value for this Keyframe. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public abstract object GetValue() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the value for this Keyframe.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
				public abstract void SetValue(object value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the time for this keyframe, as a fraction of the overall animation duration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The time associated with this keyframe, as a fraction of the overall animation duration. This should be a value between 0 and 1. </para>
				/// </returns>
				/// <java-name>
				/// getFraction
				/// </java-name>
				[Dot42.DexImport("getFraction", "()F", AccessFlags = 1)]
				public virtual float GetFraction() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Sets the time for this keyframe, as a fraction of the overall animation duration.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFraction
				/// </java-name>
				[Dot42.DexImport("setFraction", "(F)V", AccessFlags = 1)]
				public virtual void SetFraction(float fraction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the optional interpolator for this Keyframe. A value of <code>null</code> indicates that there is no interpolation, which is the same as linear interpolation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The optional interpolator for this Keyframe. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
				public virtual global::Android.Animation.ITimeInterpolator GetInterpolator() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ITimeInterpolator);
				}

				/// <summary>
				/// <para>Sets the optional interpolator for this Keyframe. A value of <code>null</code> indicates that there is no interpolation, which is the same as linear interpolation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The optional interpolator for this Keyframe. </para>
				/// </returns>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.Animation.ITimeInterpolator interpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the type of keyframe. This information is used by ValueAnimator to determine the type of TypeEvaluator to use when calculating values between keyframes. The type is based on the type of Keyframe created.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The type of the value stored in the Keyframe. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1)]
				public new virtual global::System.Type GetType() /* MethodBuilder.Create */ 
				{
						return default(global::System.Type);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/animation/Keyframe;", AccessFlags = 1025)]
				public abstract global::Android.Animation.Keyframe Clone() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the value for this Keyframe.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value for this Keyframe. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				public object Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/Object;", AccessFlags = 1025)]
						get{ return GetValue(); }
				[Dot42.DexImport("setValue", "(Ljava/lang/Object;)V", AccessFlags = 1025)]
						set{ SetValue(value); }
				}

				/// <summary>
				/// <para>Gets the time for this keyframe, as a fraction of the overall animation duration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The time associated with this keyframe, as a fraction of the overall animation duration. This should be a value between 0 and 1. </para>
				/// </returns>
				/// <java-name>
				/// getFraction
				/// </java-name>
				public float Fraction
				{
				[Dot42.DexImport("getFraction", "()F", AccessFlags = 1)]
						get{ return GetFraction(); }
				[Dot42.DexImport("setFraction", "(F)V", AccessFlags = 1)]
						set{ SetFraction(value); }
				}

				/// <summary>
				/// <para>Gets the optional interpolator for this Keyframe. A value of <code>null</code> indicates that there is no interpolation, which is the same as linear interpolation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The optional interpolator for this Keyframe. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public global::Android.Animation.ITimeInterpolator Interpolator
				{
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
						get{ return GetInterpolator(); }
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
						set{ SetInterpolator(value); }
				}

				/// <summary>
				/// <para>Gets the type of keyframe. This information is used by ValueAnimator to determine the type of TypeEvaluator to use when calculating values between keyframes. The type is based on the type of Keyframe created.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The type of the value stored in the Keyframe. </para>
				/// </returns>
				/// <java-name>
				/// getType
				/// </java-name>
				public global::System.Type Type
				{
				[Dot42.DexImport("getType", "()Ljava/lang/Class;", AccessFlags = 1)]
						get{ return GetType(); }
				}

		}

		/// <summary>
		/// <para>This class holds information about a property and the values that that property should take on during an animation. PropertyValuesHolder objects can be used to create animations with ValueAnimator or ObjectAnimator that operate on several different properties in parallel. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Set the animated values for this object to this set of ints. If there is only one value, it is assumed to be the end value of an animation, and an initial value will be derived, if possible, by calling a getter function on the object. Also, if any value is null, the value will be filled in when the animation starts in the same way. This mechanism of automatically getting null values only works if the PropertyValuesHolder object is used in conjunction ObjectAnimator, and with a getter function derived automatically from <code>propertyName</code>, since otherwise PropertyValuesHolder has no way of determining what the value should be.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIntValues
				/// </java-name>
				[Dot42.DexImport("setIntValues", "([I)V", AccessFlags = 129)]
				public virtual void SetIntValues(params int[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the animated values for this object to this set of floats. If there is only one value, it is assumed to be the end value of an animation, and an initial value will be derived, if possible, by calling a getter function on the object. Also, if any value is null, the value will be filled in when the animation starts in the same way. This mechanism of automatically getting null values only works if the PropertyValuesHolder object is used in conjunction ObjectAnimator, and with a getter function derived automatically from <code>propertyName</code>, since otherwise PropertyValuesHolder has no way of determining what the value should be.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFloatValues
				/// </java-name>
				[Dot42.DexImport("setFloatValues", "([F)V", AccessFlags = 129)]
				public virtual void SetFloatValues(params float[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the animated values for this object to this set of Keyframes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setKeyframes
				/// </java-name>
				[Dot42.DexImport("setKeyframes", "([Landroid/animation/Keyframe;)V", AccessFlags = 129)]
				public virtual void SetKeyframes(params global::Android.Animation.Keyframe[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the animated values for this object to this set of Objects. If there is only one value, it is assumed to be the end value of an animation, and an initial value will be derived, if possible, by calling a getter function on the object. Also, if any value is null, the value will be filled in when the animation starts in the same way. This mechanism of automatically getting null values only works if the PropertyValuesHolder object is used in conjunction ObjectAnimator, and with a getter function derived automatically from <code>propertyName</code>, since otherwise PropertyValuesHolder has no way of determining what the value should be.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setObjectValues
				/// </java-name>
				[Dot42.DexImport("setObjectValues", "([Ljava/lang/Object;)V", AccessFlags = 129)]
				public virtual void SetObjectValues(params object[] values) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>The TypeEvaluator will the automatically determined based on the type of values supplied to PropertyValuesHolder. The evaluator can be manually set, however, if so desired. This may be important in cases where either the type of the values supplied do not match the way that they should be interpolated between, or if the values are of a custom type or one not currently understood by the animation system. Currently, only values of type float and int (and their Object equivalents: Float and Integer) are correctly interpolated; all other types require setting a TypeEvaluator. </para>        
				/// </summary>
				/// <java-name>
				/// setEvaluator
				/// </java-name>
				[Dot42.DexImport("setEvaluator", "(Landroid/animation/TypeEvaluator;)V", AccessFlags = 1)]
				public virtual void SetEvaluator(global::Android.Animation.ITypeEvaluator<object> evaluator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the name of the property that will be animated. This name is used to derive a setter function that will be called to set animated values. For example, a property name of <code>foo</code> will result in a call to the function <code>setFoo()</code> on the target object. If either <code>valueFrom</code> or <code>valueTo</code> is null, then a getter function will also be derived and called.</para><para>Note that the setter function derived from this property name must take the same parameter type as the <code>valueFrom</code> and <code>valueTo</code> properties, otherwise the call to the setter function will fail.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPropertyName
				/// </java-name>
				[Dot42.DexImport("setPropertyName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetPropertyName(string propertyName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the property that will be animated.</para><para>Note that if this PropertyValuesHolder object is used with ObjectAnimator, the property must exist on the target object specified in that ObjectAnimator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Landroid/util/Property;)V", AccessFlags = 1)]
				public virtual void SetProperty(global::Android.Util.Property<object, object> property) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the name of the property that will be animated. This name will be used to derive a setter function that will be called to set animated values. For example, a property name of <code>foo</code> will result in a call to the function <code>setFoo()</code> on the target object. If either <code>valueFrom</code> or <code>valueTo</code> is null, then a getter function will also be derived and called. </para>        
				/// </summary>
				/// <java-name>
				/// getPropertyName
				/// </java-name>
				[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetPropertyName() /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// <para>Gets the name of the property that will be animated. This name will be used to derive a setter function that will be called to set animated values. For example, a property name of <code>foo</code> will result in a call to the function <code>setFoo()</code> on the target object. If either <code>valueFrom</code> or <code>valueTo</code> is null, then a getter function will also be derived and called. </para>        
				/// </summary>
				/// <java-name>
				/// getPropertyName
				/// </java-name>
				public string PropertyName
				{
				[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPropertyName(); }
				[Dot42.DexImport("setPropertyName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPropertyName(value); }
				}

		}

		/// <summary>
		/// <para>This class enables automatic animations on layout changes in ViewGroup objects. To enable transitions for a layout container, create a LayoutTransition object and set it on any ViewGroup by calling ViewGroup#setLayoutTransition(LayoutTransition). This will cause default animations to run whenever items are added to or removed from that container. To specify custom animations, use the setAnimator() method.</para><para>One of the core concepts of these transition animations is that there are two types of changes that cause the transition and four different animations that run because of those changes. The changes that trigger the transition are items being added to a container (referred to as an "appearing" transition) or removed from a container (also known as "disappearing"). Setting the visibility of views (between GONE and VISIBLE) will trigger the same add/remove logic. The animations that run due to those events are one that animates items being added, one that animates items being removed, and two that animate the other items in the container that change due to the add/remove occurrence. Users of the transition may want different animations for the changing items depending on whether they are changing due to an appearing or disappearing event, so there is one animation for each of these variations of the changing event. Most of the API of this class is concerned with setting up the basic properties of the animations used in these four situations, or with setting up custom animations for any or all of the four.</para><para>By default, the DISAPPEARING animation begins immediately, as does the CHANGE_APPEARING animation. The other animations begin after a delay that is set to the default duration of the animations. This behavior facilitates a sequence of animations in transitions as follows: when an item is being added to a layout, the other children of that container will move first (thus creating space for the new item), then the appearing animation will run to animate the item being added. Conversely, when an item is removed from a container, the animation to remove it will run first, then the animations of the other children in the layout will run (closing the gap created in the layout when the item was removed). If this default choreography behavior is not desired, the setDuration(int, long) and setStartDelay(int, long) of any or all of the animations can be changed as appropriate.</para><para>The animations specified for the transition, both the defaults and any custom animations set on the transition object, are templates only. That is, these animations exist to hold the basic animation properties, such as the duration, start delay, and properties being animated. But the actual target object, as well as the start and end values for those properties, are set automatically in the process of setting up the transition each time it runs. Each of the animations is cloned from the original copy and the clone is then populated with the dynamic values of the target being animated (such as one of the items in a layout container that is moving as a result of the layout event) as well as the values that are changing (such as the position and size of that object). The actual values that are pushed to each animation depends on what properties are specified for the animation. For example, the default CHANGE_APPEARING animation animates the <code>left</code>, <code>top</code>, <code>right</code>, <code>bottom</code>, <code>scrollX</code>, and <code>scrollY</code> properties. Values for these properties are updated with the pre- and post-layout values when the transition begins. Custom animations will be similarly populated with the target and values being animated, assuming they use ObjectAnimator objects with property names that are known on the target object.</para><para>This class, and the associated XML flag for containers, animateLayoutChanges="true", provides a simple utility meant for automating changes in straightforward situations. Using LayoutTransition at multiple levels of a nested view hierarchy may not work due to the interrelationship of the various levels of layout. Also, a container that is being scrolled at the same time as items are being added or removed is probably not a good candidate for this utility, because the before/after locations calculated by LayoutTransition may not match the actual locations when the animations finish due to the container being scrolled as the animations are running. You can work around that particular issue by disabling the 'changing' animations by setting the CHANGE_APPEARING and CHANGE_DISAPPEARING animations to null, and setting the startDelay of the other animations appropriately.</para>    
		/// </summary>
		/// <java-name>
		/// android/animation/LayoutTransition
		/// </java-name>
		[Dot42.DexImport("android/animation/LayoutTransition", AccessFlags = 33)]
		public partial class LayoutTransition
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>A flag indicating the animation that runs on those items that are changing due to a new item appearing in the container. </para>        
				/// </summary>
				/// <java-name>
				/// CHANGE_APPEARING
				/// </java-name>
				[Dot42.DexImport("CHANGE_APPEARING", "I", AccessFlags = 25)]
				public const int CHANGE_APPEARING = 0;
				/// <summary>
				/// <para>A flag indicating the animation that runs on those items that are changing due to an item disappearing from the container. </para>        
				/// </summary>
				/// <java-name>
				/// CHANGE_DISAPPEARING
				/// </java-name>
				[Dot42.DexImport("CHANGE_DISAPPEARING", "I", AccessFlags = 25)]
				public const int CHANGE_DISAPPEARING = 1;
				/// <summary>
				/// <para>A flag indicating the animation that runs on those items that are appearing in the container. </para>        
				/// </summary>
				/// <java-name>
				/// APPEARING
				/// </java-name>
				[Dot42.DexImport("APPEARING", "I", AccessFlags = 25)]
				public const int APPEARING = 2;
				/// <summary>
				/// <para>A flag indicating the animation that runs on those items that are disappearing from the container. </para>        
				/// </summary>
				/// <java-name>
				/// DISAPPEARING
				/// </java-name>
				[Dot42.DexImport("DISAPPEARING", "I", AccessFlags = 25)]
				public const int DISAPPEARING = 3;
				/// <summary>
				/// <para>A flag indicating the animation that runs on those items that are changing due to a layout change not caused by items being added to or removed from the container. This transition type is not enabled by default; it can be enabled via enableTransitionType(int). </para>        
				/// </summary>
				/// <java-name>
				/// CHANGING
				/// </java-name>
				[Dot42.DexImport("CHANGING", "I", AccessFlags = 25)]
				public const int CHANGING = 4;
				/// <summary>
				/// <para>Constructs a LayoutTransition object. By default, the object will listen to layout events on any ViewGroup that it is set on and will run default animations for each type of layout event. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LayoutTransition() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the duration to be used by all animations of this transition object. If you want to set the duration of just one of the animations in particular, use the setDuration(int, long) method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)V", AccessFlags = 1)]
				public virtual void SetDuration(long duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Enables the specified transitionType for this LayoutTransition object. By default, a LayoutTransition listens for changes in children being added/remove/hidden/shown in the container, and runs the animations associated with those events. That is, all transition types besides CHANGING are enabled by default. You can also enable CHANGING animations by calling this method with the CHANGING transitionType.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// enableTransitionType
				/// </java-name>
				[Dot42.DexImport("enableTransitionType", "(I)V", AccessFlags = 1)]
				public virtual void EnableTransitionType(int transitionType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Disables the specified transitionType for this LayoutTransition object. By default, all transition types except CHANGING are enabled.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// disableTransitionType
				/// </java-name>
				[Dot42.DexImport("disableTransitionType", "(I)V", AccessFlags = 1)]
				public virtual void DisableTransitionType(int transitionType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether the specified transitionType is enabled for this LayoutTransition object. By default, all transition types except CHANGING are enabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the specified transitionType is currently enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isTransitionTypeEnabled
				/// </java-name>
				[Dot42.DexImport("isTransitionTypeEnabled", "(I)Z", AccessFlags = 1)]
				public virtual bool IsTransitionTypeEnabled(int transitionType) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the start delay on one of the animation objects used by this transition. The <code>transitionType</code> parameter determines the animation whose start delay is being set.</para><para><para>Animator::setStartDelay(long) </para></para>        
				/// </summary>
				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(IJ)V", AccessFlags = 1)]
				public virtual void SetStartDelay(int transitionType, long delay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the start delay on one of the animation objects used by this transition. The <code>transitionType</code> parameter determines the animation whose start delay is returned.</para><para><para>Animator::getStartDelay() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>long The start delay of the specified animation. </para>
				/// </returns>
				/// <java-name>
				/// getStartDelay
				/// </java-name>
				[Dot42.DexImport("getStartDelay", "(I)J", AccessFlags = 1)]
				public virtual long GetStartDelay(int transitionType) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the duration on one of the animation objects used by this transition. The <code>transitionType</code> parameter determines the animation whose duration is being set.</para><para><para>Animator::setDuration(long) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(IJ)V", AccessFlags = 1)]
				public virtual void SetDuration(int transitionType, long duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the duration on one of the animation objects used by this transition. The <code>transitionType</code> parameter determines the animation whose duration is returned.</para><para><para>Animator::getDuration() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>long The duration of the specified animation. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "(I)J", AccessFlags = 1)]
				public virtual long GetDuration(int transitionType) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the length of time to delay between starting each animation during one of the change animations.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStagger
				/// </java-name>
				[Dot42.DexImport("setStagger", "(IJ)V", AccessFlags = 1)]
				public virtual void SetStagger(int transitionType, long duration) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the length of time to delay between starting each animation during one of the change animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>long The length of time, in milliseconds, to delay before launching the next animation in the sequence. </para>
				/// </returns>
				/// <java-name>
				/// getStagger
				/// </java-name>
				[Dot42.DexImport("getStagger", "(I)J", AccessFlags = 1)]
				public virtual long GetStagger(int transitionType) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the interpolator on one of the animation objects used by this transition. The <code>transitionType</code> parameter determines the animation whose interpolator is being set.</para><para><para>Animator::setInterpolator(TimeInterpolator) </para></para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(ILandroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
				public virtual void SetInterpolator(int transitionType, global::Android.Animation.ITimeInterpolator interpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the interpolator on one of the animation objects used by this transition. The <code>transitionType</code> parameter determines the animation whose interpolator is returned.</para><para><para>Animator::setInterpolator(TimeInterpolator) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>TimeInterpolator The interpolator that the specified animation uses. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "(I)Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
				public virtual global::Android.Animation.ITimeInterpolator GetInterpolator(int transitionType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ITimeInterpolator);
				}

				/// <summary>
				/// <para>Sets the animation used during one of the transition types that may run. Any Animator object can be used, but to be most useful in the context of layout transitions, the animation should either be a ObjectAnimator or a AnimatorSet of animations including PropertyAnimators. Also, these ObjectAnimator objects should be able to get and set values on their target objects automatically. For example, a ObjectAnimator that animates the property "left" is able to set and get the <code>left</code> property from the View objects being animated by the layout transition. The transition works by setting target objects and properties dynamically, according to the pre- and post-layoout values of those objects, so having animations that can handle those properties appropriately will work best for custom animation. The dynamic setting of values is only the case for the CHANGE animations; the APPEARING and DISAPPEARING animations are simply run with the values they have.</para><para>It is also worth noting that any and all animations (and their underlying PropertyValuesHolder objects) will have their start and end values set according to the pre- and post-layout values. So, for example, a custom animation on "alpha" as the CHANGE_APPEARING animation will inherit the real value of alpha on the target object (presumably 1) as its starting and ending value when the animation begins. Animations which need to use values at the beginning and end that may not match the values queried when the transition begins may need to use a different mechanism than a standard ObjectAnimator object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAnimator
				/// </java-name>
				[Dot42.DexImport("setAnimator", "(ILandroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void SetAnimator(int transitionType, global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the animation used during one of the transition types that may run.</para><para><para>setAnimator(int, Animator) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Animator The animation being used for the given transition type. </para>
				/// </returns>
				/// <java-name>
				/// getAnimator
				/// </java-name>
				[Dot42.DexImport("getAnimator", "(I)Landroid/animation/Animator;", AccessFlags = 1)]
				public virtual global::Android.Animation.Animator GetAnimator(int transitionType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <summary>
				/// <para>This flag controls whether CHANGE_APPEARING or CHANGE_DISAPPEARING animations will cause the default changing animation to be run on the parent hierarchy as well. This allows containers of transitioning views to also transition, which may be necessary in situations where the containers bounds change between the before/after states and may clip their children during the transition animations. For example, layouts with wrap_content will adjust their bounds according to the dimensions of their children.</para><para>The default changing transitions animate the bounds and scroll positions of the target views. These are the animations that will run on the parent hierarchy, not the custom animations that happen to be set on the transition. This allows custom behavior for the children of the transitioning container, but uses standard behavior of resizing/rescrolling on any changing parents.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAnimateParentHierarchy
				/// </java-name>
				[Dot42.DexImport("setAnimateParentHierarchy", "(Z)V", AccessFlags = 1)]
				public virtual void SetAnimateParentHierarchy(bool animateParentHierarchy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if animations are running which animate layout-related properties. This essentially means that either CHANGE_APPEARING or CHANGE_DISAPPEARING animations are running, since these animations operate on layout-related properties.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if CHANGE_APPEARING or CHANGE_DISAPPEARING animations are currently running. </para>
				/// </returns>
				/// <java-name>
				/// isChangingLayout
				/// </java-name>
				[Dot42.DexImport("isChangingLayout", "()Z", AccessFlags = 1)]
				public virtual bool IsChangingLayout() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if any of the animations in this transition are currently running.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if any animations in the transition are running. </para>
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
				/// <para>This method is called by ViewGroup when a child view is about to be added to the container. This callback starts the process of a transition; we grab the starting values, listen for changes to all of the children of the container, and start appropriate animations.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addChild
				/// </java-name>
				[Dot42.DexImport("addChild", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddChild(global::Android.View.ViewGroup parent, global::Android.View.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use showChild(android.view.ViewGroup, android.view.View, int). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// showChild
				/// </java-name>
				[Dot42.DexImport("showChild", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void ShowChild(global::Android.View.ViewGroup parent, global::Android.View.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called by ViewGroup when a child view is about to be made visible in the container. This callback starts the process of a transition; we grab the starting values, listen for changes to all of the children of the container, and start appropriate animations.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// showChild
				/// </java-name>
				[Dot42.DexImport("showChild", "(Landroid/view/ViewGroup;Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void ShowChild(global::Android.View.ViewGroup parent, global::Android.View.View child, int oldVisibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called by ViewGroup when a child view is about to be removed from the container. This callback starts the process of a transition; we grab the starting values, listen for changes to all of the children of the container, and start appropriate animations.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeChild
				/// </java-name>
				[Dot42.DexImport("removeChild", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RemoveChild(global::Android.View.ViewGroup parent, global::Android.View.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use hideChild(android.view.ViewGroup, android.view.View, int). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// hideChild
				/// </java-name>
				[Dot42.DexImport("hideChild", "(Landroid/view/ViewGroup;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void HideChild(global::Android.View.ViewGroup parent, global::Android.View.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called by ViewGroup when a child view is about to be hidden in container. This callback starts the process of a transition; we grab the starting values, listen for changes to all of the children of the container, and start appropriate animations.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// hideChild
				/// </java-name>
				[Dot42.DexImport("hideChild", "(Landroid/view/ViewGroup;Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void HideChild(global::Android.View.ViewGroup parent, global::Android.View.View child, int newVisibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Add a listener that will be called when the bounds of the view change due to layout processing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addTransitionListener
				/// </java-name>
				[Dot42.DexImport("addTransitionListener", "(Landroid/animation/LayoutTransition$TransitionListener;)V", AccessFlags = 1)]
				public virtual void AddTransitionListener(global::Android.Animation.LayoutTransition.ITransitionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove a listener for layout changes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeTransitionListener
				/// </java-name>
				[Dot42.DexImport("removeTransitionListener", "(Landroid/animation/LayoutTransition$TransitionListener;)V", AccessFlags = 1)]
				public virtual void RemoveTransitionListener(global::Android.Animation.LayoutTransition.ITransitionListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the current list of listeners for layout changes. </para>        
				/// </summary>
				/// <returns>
				/// <para></para>
				/// </returns>
				/// <java-name>
				/// getTransitionListeners
				/// </java-name>
				[Dot42.DexImport("getTransitionListeners", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/animation/LayoutTransition$TransitionListener;>;")]
				public virtual global::Java.Util.IList<global::Android.Animation.LayoutTransition.ITransitionListener> GetTransitionListeners() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Animation.LayoutTransition.ITransitionListener>);
				}

				/// <summary>
				/// <para>Gets the current list of listeners for layout changes. </para>        
				/// </summary>
				/// <returns>
				/// <para></para>
				/// </returns>
				/// <java-name>
				/// getTransitionListeners
				/// </java-name>
				public global::Java.Util.IList<global::Android.Animation.LayoutTransition.ITransitionListener> TransitionListeners
				{
				[Dot42.DexImport("getTransitionListeners", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/animation/LayoutTransition$TransitionListener;>;")]
						get{ return GetTransitionListeners(); }
				}

				/// <summary>
				/// <para>This interface is used for listening to starting and ending events for transitions. </para>    
				/// </summary>
				/// <java-name>
				/// android/animation/LayoutTransition$TransitionListener
				/// </java-name>
				[Dot42.DexImport("android/animation/LayoutTransition$TransitionListener", AccessFlags = 1545)]
				public partial interface ITransitionListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>This event is sent to listeners when any type of transition animation begins.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// startTransition
						/// </java-name>
						[Dot42.DexImport("startTransition", "(Landroid/animation/LayoutTransition;Landroid/view/ViewGroup;Landroid/view/View;I" +
    ")V", AccessFlags = 1025)]
						void StartTransition(global::Android.Animation.LayoutTransition transition, global::Android.View.ViewGroup container, global::Android.View.View view, int transitionType) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>This event is sent to listeners when any type of transition animation ends.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// endTransition
						/// </java-name>
						[Dot42.DexImport("endTransition", "(Landroid/animation/LayoutTransition;Landroid/view/ViewGroup;Landroid/view/View;I" +
    ")V", AccessFlags = 1025)]
						void EndTransition(global::Android.Animation.LayoutTransition transition, global::Android.View.ViewGroup container, global::Android.View.View view, int transitionType) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>This subclass of ValueAnimator provides support for animating properties on target objects. The constructors of this class take parameters to define the target object that will be animated as well as the name of the property that will be animated. Appropriate set/get functions are then determined internally and the animation will call these functions as necessary to animate the property.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about animating with <c> ObjectAnimator </c> , read the  developer guide.</para><para> </para><para><para>setPropertyName(String) </para></para>    
		/// </summary>
		/// <java-name>
		/// android/animation/ObjectAnimator
		/// </java-name>
		[Dot42.DexImport("android/animation/ObjectAnimator", AccessFlags = 49)]
		public sealed partial class ObjectAnimator : global::Android.Animation.ValueAnimator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new ObjectAnimator object. This default constructor is primarily for use internally; the other constructors which take parameters are more generally useful. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ObjectAnimator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the name of the property that will be animated. This name is used to derive a setter function that will be called to set animated values. For example, a property name of <code>foo</code> will result in a call to the function <code>setFoo()</code> on the target object. If either <code>valueFrom</code> or <code>valueTo</code> is null, then a getter function will also be derived and called.</para><para>For best performance of the mechanism that calls the setter function determined by the name of the property being animated, use <code>float</code> or <code>int</code> typed values, and make the setter function for those properties have a <code>void</code> return value. This will cause the code to take an optimized path for these constrained circumstances. Other property types and return types will work, but will have more overhead in processing the requests due to normal reflection mechanisms.</para><para>Note that the setter function derived from this property name must take the same parameter type as the <code>valueFrom</code> and <code>valueTo</code> properties, otherwise the call to the setter function will fail.</para><para>If this ObjectAnimator has been set up to animate several properties together, using more than one PropertyValuesHolder objects, then setting the propertyName simply sets the propertyName in the first of those PropertyValuesHolder objects.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPropertyName
				/// </java-name>
				[Dot42.DexImport("setPropertyName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetPropertyName(string propertyName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the property that will be animated. Property objects will take precedence over properties specified by the setPropertyName(String) method. Animations should be set up to use one or the other, not both.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setProperty
				/// </java-name>
				[Dot42.DexImport("setProperty", "(Landroid/util/Property;)V", AccessFlags = 1)]
				public void SetProperty(global::Android.Util.Property<object, object> property) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the name of the property that will be animated. This name will be used to derive a setter function that will be called to set animated values. For example, a property name of <code>foo</code> will result in a call to the function <code>setFoo()</code> on the target object. If either <code>valueFrom</code> or <code>valueTo</code> is null, then a getter function will also be derived and called. </para>        
				/// </summary>
				/// <java-name>
				/// getPropertyName
				/// </java-name>
				[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPropertyName() /* MethodBuilder.Create */ 
				{
						return default(string);
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

				/// <summary>
				/// <para>Constructs and returns an ObjectAnimator that animates between the sets of values specified in <code>PropertyValueHolder</code> objects. This variant should be used when animating several properties at once with the same ObjectAnimator, since PropertyValuesHolder allows you to associate a set of animation values with a property name.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An ObjectAnimator object that is set up to animate between the given values. </para>
				/// </returns>
				/// <java-name>
				/// ofPropertyValuesHolder
				/// </java-name>
				[Dot42.DexImport("ofPropertyValuesHolder", "(Ljava/lang/Object;[Landroid/animation/PropertyValuesHolder;)Landroid/animation/O" +
    "bjectAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ObjectAnimator OfPropertyValuesHolder(object target, params global::Android.Animation.PropertyValuesHolder[] values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <summary>
				/// <para>Sets int values that will be animated between. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para>If there are already multiple sets of values defined for this ValueAnimator via more than one PropertyValuesHolder object, this method will set the values for the first of those objects.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIntValues
				/// </java-name>
				[Dot42.DexImport("setIntValues", "([I)V", AccessFlags = 129)]
				public override void SetIntValues(params int[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets float values that will be animated between. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para>If there are already multiple sets of values defined for this ValueAnimator via more than one PropertyValuesHolder object, this method will set the values for the first of those objects.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFloatValues
				/// </java-name>
				[Dot42.DexImport("setFloatValues", "([F)V", AccessFlags = 129)]
				public override void SetFloatValues(params float[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the values to animate between for this animation. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para>If there are already multiple sets of values defined for this ValueAnimator via more than one PropertyValuesHolder object, this method will set the values for the first of those objects.</para><para>There should be a TypeEvaluator set on the ValueAnimator that knows how to interpolate between these value objects. ValueAnimator only knows how to interpolate between the primitive types specified in the other setValues() methods.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setObjectValues
				/// </java-name>
				[Dot42.DexImport("setObjectValues", "([Ljava/lang/Object;)V", AccessFlags = 129)]
				public override void SetObjectValues(params object[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>autoCancel controls whether an ObjectAnimator will be canceled automatically when any other ObjectAnimator with the same target and properties is started. Setting this flag may make it easier to run different animators on the same target object without having to keep track of whether there are conflicting animators that need to be manually canceled. Canceling animators must have the same exact set of target properties, in the same order.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAutoCancel
				/// </java-name>
				[Dot42.DexImport("setAutoCancel", "(Z)V", AccessFlags = 1)]
				public void SetAutoCancel(bool cancel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts this animation. If the animation has a nonzero startDelay, the animation will start running after that delay elapses. A non-delayed animation will have its initial value(s) set immediately, followed by calls to AnimatorListener#onAnimationStart(Animator) for any listeners of this animator.</para><para>The animation started by calling this method will be run on the thread that called this method. This thread should have a Looper on it (a runtime exception will be thrown if this is not the case). Also, if the animation will animate properties of objects in the view hierarchy, then the calling thread should be the UI thread for that view hierarchy.</para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public override void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the length of the animation. The default duration is 300 milliseconds.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ObjectAnimator The object called with setDuration(). This return value makes it easier to compose statements together that construct and then set the duration, as in <code>ObjectAnimator.ofInt(target, propertyName, 0, 10).setDuration(500).start()</code>. </para>
				/// </returns>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/animation/ObjectAnimator;", AccessFlags = 1)]
				public new global::Android.Animation.ObjectAnimator SetDuration(long duration) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ObjectAnimator);
				}

				/// <summary>
				/// <para>The target object whose property will be animated by this animation</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The object being animated </para>
				/// </returns>
				/// <java-name>
				/// getTarget
				/// </java-name>
				[Dot42.DexImport("getTarget", "()Ljava/lang/Object;", AccessFlags = 1)]
				public object GetTarget() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Sets the target object whose property will be animated by this animation</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTarget
				/// </java-name>
				[Dot42.DexImport("setTarget", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public override void SetTarget(object target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method tells the object to use appropriate information to extract starting values for the animation. For example, a AnimatorSet object will pass this call to its child objects to tell them to set up the values. A ObjectAnimator object will use the information it has about its target object and PropertyValuesHolder objects to get the start values for its properties. A ValueAnimator object will ignore the request since it does not have enough information (such as a target object) to gather these values. </para>        
				/// </summary>
				/// <java-name>
				/// setupStartValues
				/// </java-name>
				[Dot42.DexImport("setupStartValues", "()V", AccessFlags = 1)]
				public override void SetupStartValues() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method tells the object to use appropriate information to extract ending values for the animation. For example, a AnimatorSet object will pass this call to its child objects to tell them to set up the values. A ObjectAnimator object will use the information it has about its target object and PropertyValuesHolder objects to get the start values for its properties. A ValueAnimator object will ignore the request since it does not have enough information (such as a target object) to gather these values. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Gets the name of the property that will be animated. This name will be used to derive a setter function that will be called to set animated values. For example, a property name of <code>foo</code> will result in a call to the function <code>setFoo()</code> on the target object. If either <code>valueFrom</code> or <code>valueTo</code> is null, then a getter function will also be derived and called. </para>        
				/// </summary>
				/// <java-name>
				/// getPropertyName
				/// </java-name>
				public string PropertyName
				{
				[Dot42.DexImport("getPropertyName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPropertyName(); }
				[Dot42.DexImport("setPropertyName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetPropertyName(value); }
				}

				/// <summary>
				/// <para>The target object whose property will be animated by this animation</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The object being animated </para>
				/// </returns>
				/// <java-name>
				/// getTarget
				/// </java-name>
				public object Target
				{
				[Dot42.DexImport("getTarget", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetTarget(); }
				[Dot42.DexImport("setTarget", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						set{ SetTarget(value); }
				}

		}

		/// <summary>
		/// <para>Interface for use with the ValueAnimator#setEvaluator(TypeEvaluator) function. Evaluators allow developers to create animations on arbitrary property types, by allowing them to supply custom evaulators for types that are not automatically understood and used by the animation system.</para><para><para>ValueAnimator::setEvaluator(TypeEvaluator) </para></para>    
		/// </summary>
		/// <java-name>
		/// android/animation/TypeEvaluator
		/// </java-name>
		[Dot42.DexImport("android/animation/TypeEvaluator", AccessFlags = 1537, Signature = "<T:Ljava/lang/Object;>Ljava/lang/Object;")]
		public partial interface ITypeEvaluator<T>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This function returns the result of linearly interpolating the start and end values, with <code>fraction</code> representing the proportion between the start and end values. The calculation is a simple parametric calculation: <code>result = x0 + t * (v1 - v0)</code>, where <code>x0</code> is <code>startValue</code>, <code>x1</code> is <code>endValue</code>, and <code>t</code> is <code>fraction</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A linear interpolation between the start and end values, given the <code>fraction</code> parameter. </para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(FTT;TT;)TT;")]
				T Evaluate(float fraction, T startValue, T endValue) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class provides a simple timing engine for running animations which calculate animated values and set them on target objects.</para><para>There is a single timing pulse that all animations use. It runs in a custom handler to ensure that property changes happen on the UI thread.</para><para>By default, ValueAnimator uses non-linear time interpolation, via the AccelerateDecelerateInterpolator class, which accelerates into and decelerates out of an animation. This behavior can be changed by calling ValueAnimator#setInterpolator(TimeInterpolator).</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about animating with <c> ValueAnimator </c> , read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/animation/ValueAnimator
		/// </java-name>
		[Dot42.DexImport("android/animation/ValueAnimator", AccessFlags = 33)]
		public partial class ValueAnimator : global::Android.Animation.Animator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Public constants When the animation reaches the end and <code>repeatCount</code> is INFINITE or a positive value, the animation restarts from the beginning. </para>        
				/// </summary>
				/// <java-name>
				/// RESTART
				/// </java-name>
				[Dot42.DexImport("RESTART", "I", AccessFlags = 25)]
				public const int RESTART = 1;
				/// <summary>
				/// <para>When the animation reaches the end and <code>repeatCount</code> is INFINITE or a positive value, the animation reverses direction on every iteration. </para>        
				/// </summary>
				/// <java-name>
				/// REVERSE
				/// </java-name>
				[Dot42.DexImport("REVERSE", "I", AccessFlags = 25)]
				public const int REVERSE = 2;
				/// <summary>
				/// <para>This value used used with the setRepeatCount(int) property to repeat the animation indefinitely. </para>        
				/// </summary>
				/// <java-name>
				/// INFINITE
				/// </java-name>
				[Dot42.DexImport("INFINITE", "I", AccessFlags = 25)]
				public const int INFINITE = -1;
				/// <summary>
				/// <para>Creates a new ValueAnimator object. This default constructor is primarily for use internally; the factory methods which take parameters are more generally useful. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ValueAnimator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructs and returns a ValueAnimator that animates between int values. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A ValueAnimator object that is set up to animate between the given values. </para>
				/// </returns>
				/// <java-name>
				/// ofInt
				/// </java-name>
				[Dot42.DexImport("ofInt", "([I)Landroid/animation/ValueAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ValueAnimator OfInt(params int[] values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
				}

				/// <summary>
				/// <para>Constructs and returns a ValueAnimator that animates between float values. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A ValueAnimator object that is set up to animate between the given values. </para>
				/// </returns>
				/// <java-name>
				/// ofFloat
				/// </java-name>
				[Dot42.DexImport("ofFloat", "([F)Landroid/animation/ValueAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ValueAnimator OfFloat(params float[] values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
				}

				/// <summary>
				/// <para>Constructs and returns a ValueAnimator that animates between the values specified in the PropertyValuesHolder objects.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A ValueAnimator object that is set up to animate between the given values. </para>
				/// </returns>
				/// <java-name>
				/// ofPropertyValuesHolder
				/// </java-name>
				[Dot42.DexImport("ofPropertyValuesHolder", "([Landroid/animation/PropertyValuesHolder;)Landroid/animation/ValueAnimator;", AccessFlags = 137)]
				public static global::Android.Animation.ValueAnimator OfPropertyValuesHolder(params global::Android.Animation.PropertyValuesHolder[] values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
				}

				/// <summary>
				/// <para>Constructs and returns a ValueAnimator that animates between Object values. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para>Since ValueAnimator does not know how to animate between arbitrary Objects, this factory method also takes a TypeEvaluator object that the ValueAnimator will use to perform that interpolation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A ValueAnimator object that is set up to animate between the given values. </para>
				/// </returns>
				/// <java-name>
				/// ofObject
				/// </java-name>
				[Dot42.DexImport("ofObject", "(Landroid/animation/TypeEvaluator;[Ljava/lang/Object;)Landroid/animation/ValueAni" +
    "mator;", AccessFlags = 137)]
				public static global::Android.Animation.ValueAnimator OfObject(global::Android.Animation.ITypeEvaluator<object> evaluator, params object[] values) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ValueAnimator);
				}

				/// <summary>
				/// <para>Sets int values that will be animated between. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para>If there are already multiple sets of values defined for this ValueAnimator via more than one PropertyValuesHolder object, this method will set the values for the first of those objects.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIntValues
				/// </java-name>
				[Dot42.DexImport("setIntValues", "([I)V", AccessFlags = 129)]
				public virtual void SetIntValues(params int[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets float values that will be animated between. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para>If there are already multiple sets of values defined for this ValueAnimator via more than one PropertyValuesHolder object, this method will set the values for the first of those objects.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFloatValues
				/// </java-name>
				[Dot42.DexImport("setFloatValues", "([F)V", AccessFlags = 129)]
				public virtual void SetFloatValues(params float[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the values to animate between for this animation. A single value implies that that value is the one being animated to. However, this is not typically useful in a ValueAnimator object because there is no way for the object to determine the starting value for the animation (unlike ObjectAnimator, which can derive that value from the target object and property being animated). Therefore, there should typically be two or more values.</para><para>If there are already multiple sets of values defined for this ValueAnimator via more than one PropertyValuesHolder object, this method will set the values for the first of those objects.</para><para>There should be a TypeEvaluator set on the ValueAnimator that knows how to interpolate between these value objects. ValueAnimator only knows how to interpolate between the primitive types specified in the other setValues() methods.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setObjectValues
				/// </java-name>
				[Dot42.DexImport("setObjectValues", "([Ljava/lang/Object;)V", AccessFlags = 129)]
				public virtual void SetObjectValues(params object[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the values, per property, being animated between. This function is called internally by the constructors of ValueAnimator that take a list of values. But a ValueAnimator can be constructed without values and this method can be called to set the values manually instead.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValues
				/// </java-name>
				[Dot42.DexImport("setValues", "([Landroid/animation/PropertyValuesHolder;)V", AccessFlags = 129)]
				public virtual void SetValues(params global::Android.Animation.PropertyValuesHolder[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the values that this ValueAnimator animates between. These values are stored in PropertyValuesHolder objects, even if the ValueAnimator was created with a simple list of value objects instead.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>PropertyValuesHolder[] An array of PropertyValuesHolder objects which hold the values, per property, that define the animation. </para>
				/// </returns>
				/// <java-name>
				/// getValues
				/// </java-name>
				[Dot42.DexImport("getValues", "()[Landroid/animation/PropertyValuesHolder;", AccessFlags = 1)]
				public virtual global::Android.Animation.PropertyValuesHolder[] GetValues() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.PropertyValuesHolder[]);
				}

				/// <summary>
				/// <para>Sets the length of the animation. The default duration is 300 milliseconds.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ValueAnimator The object called with setDuration(). This return value makes it easier to compose statements together that construct and then set the duration, as in <code>ValueAnimator.ofInt(0, 10).setDuration(500).start()</code>. </para>
				/// </returns>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/animation/ValueAnimator;", AccessFlags = 1)]
				public override global::Android.Animation.Animator SetDuration(long duration) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <summary>
				/// <para>Gets the length of the animation. The default duration is 300 milliseconds.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The length of the animation, in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
				public override long GetDuration() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the position of the animation to the specified point in time. This time should be between 0 and the total duration of the animation, including any repetition. If the animation has not yet been started, then it will not advance forward after it is set to this time; it will simply set the time to this value and perform any appropriate actions based on that time. If the animation is already running, then setCurrentPlayTime() will set the current playing time to this value and continue playing from that point.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrentPlayTime
				/// </java-name>
				[Dot42.DexImport("setCurrentPlayTime", "(J)V", AccessFlags = 1)]
				public virtual void SetCurrentPlayTime(long playTime) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the current position of the animation in time, which is equal to the current time minus the time that the animation started. An animation that is not yet started will return a value of zero.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current position in time of the animation. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentPlayTime
				/// </java-name>
				[Dot42.DexImport("getCurrentPlayTime", "()J", AccessFlags = 1)]
				public virtual long GetCurrentPlayTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay starting the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of milliseconds to delay running the animation </para>
				/// </returns>
				/// <java-name>
				/// getStartDelay
				/// </java-name>
				[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
				public override long GetStartDelay() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay starting the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1)]
				public override void SetStartDelay(long startDelay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, between each frame of the animation. This is a requested time that the animation will attempt to honor, but the actual delay between frames may be different, depending on system load and capabilities. This is a static function because the same delay will be applied to all animations, since they are all run off of a single timing loop.</para><para>The frame delay may be ignored when the animation system uses an external timing source, such as the display refresh rate (vsync), to govern animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested time between frames, in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getFrameDelay
				/// </java-name>
				[Dot42.DexImport("getFrameDelay", "()J", AccessFlags = 9)]
				public static long GetFrameDelay() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, between each frame of the animation. This is a requested time that the animation will attempt to honor, but the actual delay between frames may be different, depending on system load and capabilities. This is a static function because the same delay will be applied to all animations, since they are all run off of a single timing loop.</para><para>The frame delay may be ignored when the animation system uses an external timing source, such as the display refresh rate (vsync), to govern animations.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFrameDelay
				/// </java-name>
				[Dot42.DexImport("setFrameDelay", "(J)V", AccessFlags = 9)]
				public static void SetFrameDelay(long frameDelay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The most recent value calculated by this <code>ValueAnimator</code> when there is just one property being animated. This value is only sensible while the animation is running. The main purpose for this read-only property is to retrieve the value from the <code>ValueAnimator</code> during a call to AnimatorUpdateListener#onAnimationUpdate(ValueAnimator), which is called during each animation frame, immediately after the value is calculated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>animatedValue The value most recently calculated by this <code>ValueAnimator</code> for the single property being animated. If there are several properties being animated (specified by several PropertyValuesHolder objects in the constructor), this function returns the animated value for the first of those objects. </para>
				/// </returns>
				/// <java-name>
				/// getAnimatedValue
				/// </java-name>
				[Dot42.DexImport("getAnimatedValue", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetAnimatedValue() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>The most recent value calculated by this <code>ValueAnimator</code> for <code>propertyName</code>. The main purpose for this read-only property is to retrieve the value from the <code>ValueAnimator</code> during a call to AnimatorUpdateListener#onAnimationUpdate(ValueAnimator), which is called during each animation frame, immediately after the value is calculated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>animatedValue The value most recently calculated for the named property by this <code>ValueAnimator</code>. </para>
				/// </returns>
				/// <java-name>
				/// getAnimatedValue
				/// </java-name>
				[Dot42.DexImport("getAnimatedValue", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetAnimatedValue(string propertyName) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Sets how many times the animation should be repeated. If the repeat count is 0, the animation is never repeated. If the repeat count is greater than 0 or INFINITE, the repeat mode will be taken into account. The repeat count is 0 by default.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRepeatCount
				/// </java-name>
				[Dot42.DexImport("setRepeatCount", "(I)V", AccessFlags = 1)]
				public virtual void SetRepeatCount(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Defines how many times the animation should repeat. The default value is 0.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of times the animation should repeat, or INFINITE </para>
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
				/// <para>Defines what this animation should do when it reaches the end. This setting is applied only when the repeat count is either greater than 0 or INFINITE. Defaults to RESTART.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRepeatMode
				/// </java-name>
				[Dot42.DexImport("setRepeatMode", "(I)V", AccessFlags = 1)]
				public virtual void SetRepeatMode(int value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Defines what this animation should do when it reaches the end.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>either one of REVERSE or RESTART </para>
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
				/// <para>Adds a listener to the set of listeners that are sent update events through the life of an animation. This method is called on all listeners for every frame of the animation, after the values for the animation have been calculated.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addUpdateListener
				/// </java-name>
				[Dot42.DexImport("addUpdateListener", "(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V", AccessFlags = 1)]
				public virtual void AddUpdateListener(global::Android.Animation.ValueAnimator.IAnimatorUpdateListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all listeners from the set listening to frame updates for this animation. </para>        
				/// </summary>
				/// <java-name>
				/// removeAllUpdateListeners
				/// </java-name>
				[Dot42.DexImport("removeAllUpdateListeners", "()V", AccessFlags = 1)]
				public virtual void RemoveAllUpdateListeners() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes a listener from the set listening to frame updates for this animation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeUpdateListener
				/// </java-name>
				[Dot42.DexImport("removeUpdateListener", "(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V", AccessFlags = 1)]
				public virtual void RemoveUpdateListener(global::Android.Animation.ValueAnimator.IAnimatorUpdateListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The time interpolator used in calculating the elapsed fraction of this animation. The interpolator determines whether the animation runs with linear or non-linear motion, such as acceleration and deceleration. The default value is android.view.animation.AccelerateDecelerateInterpolator</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
				public override void SetInterpolator(global::Android.Animation.ITimeInterpolator value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the timing interpolator that this ValueAnimator uses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The timing interpolator for this ValueAnimator. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
				public override global::Android.Animation.ITimeInterpolator GetInterpolator() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ITimeInterpolator);
				}

				/// <summary>
				/// <para>The type evaluator to be used when calculating the animated values of this animation. The system will automatically assign a float or int evaluator based on the type of <code>startValue</code> and <code>endValue</code> in the constructor. But if these values are not one of these primitive types, or if different evaluation is desired (such as is necessary with int values that represent colors), a custom evaluator needs to be assigned. For example, when running an animation on color values, the ArgbEvaluator should be used to get correct RGB color interpolation.</para><para>If this ValueAnimator has only one set of values being animated between, this evaluator will be used for that set. If there are several sets of values being animated, which is the case if PropertyValuesHOlder objects were set on the ValueAnimator, then the evaluator is assigned just to the first PropertyValuesHolder object.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEvaluator
				/// </java-name>
				[Dot42.DexImport("setEvaluator", "(Landroid/animation/TypeEvaluator;)V", AccessFlags = 1)]
				public virtual void SetEvaluator(global::Android.Animation.ITypeEvaluator<object> value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts this animation. If the animation has a nonzero startDelay, the animation will start running after that delay elapses. A non-delayed animation will have its initial value(s) set immediately, followed by calls to AnimatorListener#onAnimationStart(Animator) for any listeners of this animator.</para><para>The animation started by calling this method will be run on the thread that called this method. This thread should have a Looper on it (a runtime exception will be thrown if this is not the case). Also, if the animation will animate properties of objects in the view hierarchy, then the calling thread should be the UI thread for that view hierarchy.</para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public override void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancels the animation. Unlike end(), <code>cancel()</code> causes the animation to stop in its tracks, sending an android.animation.Animator.AnimatorListener#onAnimationCancel(Animator) to its listeners, followed by an android.animation.Animator.AnimatorListener#onAnimationEnd(Animator) message.</para><para>This method must be called on the thread that is running the animation.</para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public override void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Ends the animation. This causes the animation to assign the end value of the property being animated, then calling the android.animation.Animator.AnimatorListener#onAnimationEnd(Animator) method on its listeners.</para><para>This method must be called on the thread that is running the animation.</para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 1)]
				public override void End() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public override void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public override void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether this Animator is currently running (having been started and gone past any initial startDelay period and not yet ended).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the Animator is running. </para>
				/// </returns>
				/// <java-name>
				/// isRunning
				/// </java-name>
				[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1)]
				public override bool IsRunning() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this Animator has been started and not yet ended. This state is a superset of the state of isRunning(), because an Animator with a nonzero startDelay will return true for isStarted() during the delay phase, whereas isRunning() will return true only after the delay phase is complete.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the Animator has been started and not yet ended. </para>
				/// </returns>
				/// <java-name>
				/// isStarted
				/// </java-name>
				[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
				public override bool IsStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Plays the ValueAnimator in reverse. If the animation is already running, it will stop itself and play backwards from the point reached when reverse was called. If the animation is not currently running, then it will start from the end and play backwards. This behavior is only set for the current animation; future playing of the animation will use the default behavior of playing forward. </para>        
				/// </summary>
				/// <java-name>
				/// reverse
				/// </java-name>
				[Dot42.DexImport("reverse", "()V", AccessFlags = 1)]
				public virtual void Reverse() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current animation fraction, which is the elapsed/interpolated fraction used in the most recent frame update on the animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Elapsed/interpolated fraction of the animation. </para>
				/// </returns>
				/// <java-name>
				/// getAnimatedFraction
				/// </java-name>
				[Dot42.DexImport("getAnimatedFraction", "()F", AccessFlags = 1)]
				public virtual float GetAnimatedFraction() /* MethodBuilder.Create */ 
				{
						return default(float);
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

				/// <summary>
				/// <para>Returns the values that this ValueAnimator animates between. These values are stored in PropertyValuesHolder objects, even if the ValueAnimator was created with a simple list of value objects instead.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>PropertyValuesHolder[] An array of PropertyValuesHolder objects which hold the values, per property, that define the animation. </para>
				/// </returns>
				/// <java-name>
				/// getValues
				/// </java-name>
				public global::Android.Animation.PropertyValuesHolder[] Values
				{
				[Dot42.DexImport("getValues", "()[Landroid/animation/PropertyValuesHolder;", AccessFlags = 1)]
						get{ return GetValues(); }
				[Dot42.DexImport("setValues", "([Landroid/animation/PropertyValuesHolder;)V", AccessFlags = 129)]
						set{ SetValues(value); }
				}

				/// <summary>
				/// <para>Gets the length of the animation. The default duration is 300 milliseconds.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The length of the animation, in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public long Duration
				{
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return GetDuration(); }
				}

				/// <summary>
				/// <para>Gets the current position of the animation in time, which is equal to the current time minus the time that the animation started. An animation that is not yet started will return a value of zero.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current position in time of the animation. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentPlayTime
				/// </java-name>
				public long CurrentPlayTime
				{
				[Dot42.DexImport("getCurrentPlayTime", "()J", AccessFlags = 1)]
						get{ return GetCurrentPlayTime(); }
				[Dot42.DexImport("setCurrentPlayTime", "(J)V", AccessFlags = 1)]
						set{ SetCurrentPlayTime(value); }
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay starting the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of milliseconds to delay running the animation </para>
				/// </returns>
				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public long StartDelay
				{
				[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
						get{ return GetStartDelay(); }
				[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1)]
						set{ SetStartDelay(value); }
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, between each frame of the animation. This is a requested time that the animation will attempt to honor, but the actual delay between frames may be different, depending on system load and capabilities. This is a static function because the same delay will be applied to all animations, since they are all run off of a single timing loop.</para><para>The frame delay may be ignored when the animation system uses an external timing source, such as the display refresh rate (vsync), to govern animations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the requested time between frames, in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getFrameDelay
				/// </java-name>
				public static long FrameDelay
				{
				[Dot42.DexImport("getFrameDelay", "()J", AccessFlags = 9)]
						get{ return GetFrameDelay(); }
				[Dot42.DexImport("setFrameDelay", "(J)V", AccessFlags = 9)]
						set{ SetFrameDelay(value); }
				}

				/// <summary>
				/// <para>The most recent value calculated by this <code>ValueAnimator</code> when there is just one property being animated. This value is only sensible while the animation is running. The main purpose for this read-only property is to retrieve the value from the <code>ValueAnimator</code> during a call to AnimatorUpdateListener#onAnimationUpdate(ValueAnimator), which is called during each animation frame, immediately after the value is calculated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>animatedValue The value most recently calculated by this <code>ValueAnimator</code> for the single property being animated. If there are several properties being animated (specified by several PropertyValuesHolder objects in the constructor), this function returns the animated value for the first of those objects. </para>
				/// </returns>
				/// <java-name>
				/// getAnimatedValue
				/// </java-name>
				public object AnimatedValue
				{
				[Dot42.DexImport("getAnimatedValue", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return GetAnimatedValue(); }
				}

				/// <summary>
				/// <para>Defines how many times the animation should repeat. The default value is 0.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of times the animation should repeat, or INFINITE </para>
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
				/// <para>Defines what this animation should do when it reaches the end.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>either one of REVERSE or RESTART </para>
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
				/// <para>Returns the timing interpolator that this ValueAnimator uses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The timing interpolator for this ValueAnimator. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public global::Android.Animation.ITimeInterpolator Interpolator
				{
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
						get{ return GetInterpolator(); }
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
						set{ SetInterpolator(value); }
				}

				/// <summary>
				/// <para>Returns the current animation fraction, which is the elapsed/interpolated fraction used in the most recent frame update on the animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Elapsed/interpolated fraction of the animation. </para>
				/// </returns>
				/// <java-name>
				/// getAnimatedFraction
				/// </java-name>
				public float AnimatedFraction
				{
				[Dot42.DexImport("getAnimatedFraction", "()F", AccessFlags = 1)]
						get{ return GetAnimatedFraction(); }
				}

				/// <summary>
				/// <para>Implementors of this interface can add themselves as update listeners to an <code>ValueAnimator</code> instance to receive callbacks on every animation frame, after the current frame's values have been calculated for that <code>ValueAnimator</code>. </para>    
				/// </summary>
				/// <java-name>
				/// android/animation/ValueAnimator$AnimatorUpdateListener
				/// </java-name>
				[Dot42.DexImport("android/animation/ValueAnimator$AnimatorUpdateListener", AccessFlags = 1545)]
				public partial interface IAnimatorUpdateListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Notifies the occurrence of another frame of the animation.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAnimationUpdate
						/// </java-name>
						[Dot42.DexImport("onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V", AccessFlags = 1025)]
						void OnAnimationUpdate(global::Android.Animation.ValueAnimator animation) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>This evaluator can be used to perform type interpolation between <code>int</code> values. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>This function returns the result of linearly interpolating the start and end values, with <code>fraction</code> representing the proportion between the start and end values. The calculation is a simple parametric calculation: <code>result = x0 + t * (v1 - v0)</code>, where <code>x0</code> is <code>startValue</code>, <code>x1</code> is <code>endValue</code>, and <code>t</code> is <code>fraction</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A linear interpolation between the start and end values, given the <code>fraction</code> parameter. </para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLjava/lang/Integer;Ljava/lang/Integer;)Ljava/lang/Integer;", AccessFlags = 1)]
				public virtual int? Evaluate(float fraction, int? startValue, int? endValue) /* MethodBuilder.Create */ 
				{
						return default(int?);
				}

		}

		/// <summary>
		/// <para>This class provides a simple callback mechanism to listeners that is synchronized with all other animators in the system. There is no duration, interpolation, or object value-setting with this Animator. Instead, it is simply started, after which it proceeds to send out events on every animation frame to its TimeListener (if set), with information about this animator, the total elapsed time, and the elapsed time since the previous animation frame. </para>    
		/// </summary>
		/// <java-name>
		/// android/animation/TimeAnimator
		/// </java-name>
		[Dot42.DexImport("android/animation/TimeAnimator", AccessFlags = 33)]
		public partial class TimeAnimator : global::Android.Animation.ValueAnimator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TimeAnimator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Starts this animation. If the animation has a nonzero startDelay, the animation will start running after that delay elapses. A non-delayed animation will have its initial value(s) set immediately, followed by calls to AnimatorListener#onAnimationStart(Animator) for any listeners of this animator.</para><para>The animation started by calling this method will be run on the thread that called this method. This thread should have a Looper on it (a runtime exception will be thrown if this is not the case). Also, if the animation will animate properties of objects in the view hierarchy, then the calling thread should be the UI thread for that view hierarchy.</para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public override void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a listener that is sent update events throughout the life of an animation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTimeListener
				/// </java-name>
				[Dot42.DexImport("setTimeListener", "(Landroid/animation/TimeAnimator$TimeListener;)V", AccessFlags = 1)]
				public virtual void SetTimeListener(global::Android.Animation.TimeAnimator.ITimeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Implementors of this interface can set themselves as update listeners to a <code>TimeAnimator</code> instance to receive callbacks on every animation frame to receive the total time since the animator started and the delta time since the last frame. The first time the listener is called, deltaTime will be zero. The same is true for totalTime, unless the animator was set to a specific currentPlayTime prior to starting. </para>    
				/// </summary>
				/// <java-name>
				/// android/animation/TimeAnimator$TimeListener
				/// </java-name>
				[Dot42.DexImport("android/animation/TimeAnimator$TimeListener", AccessFlags = 1545)]
				public partial interface ITimeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Notifies listeners of the occurrence of another frame of the animation, along with information about the elapsed time.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onTimeUpdate
						/// </java-name>
						[Dot42.DexImport("onTimeUpdate", "(Landroid/animation/TimeAnimator;JJ)V", AccessFlags = 1025)]
						void OnTimeUpdate(global::Android.Animation.TimeAnimator animation, long totalTime, long deltaTime) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>This evaluator can be used to perform type interpolation between integer values that represent ARGB colors. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>This function returns the calculated in-between value for a color given integers that represent the start and end values in the four bytes of the 32-bit int. Each channel is separately linearly interpolated and the resulting calculated values are recombined into the return value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A value that is calculated to be the linearly interpolated result, derived by separating the start and end values into separate color channels and interpolating each one separately, recombining the resulting values in the same way. </para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Evaluate(float fraction, object startValue, object endValue) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

		}

		/// <summary>
		/// <para>This evaluator can be used to perform type interpolation between <code>float</code> values. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>This function returns the result of linearly interpolating the start and end values, with <code>fraction</code> representing the proportion between the start and end values. The calculation is a simple parametric calculation: <code>result = x0 + t * (v1 - v0)</code>, where <code>x0</code> is <code>startValue</code>, <code>x1</code> is <code>endValue</code>, and <code>t</code> is <code>fraction</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A linear interpolation between the start and end values, given the <code>fraction</code> parameter. </para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLjava/lang/Number;Ljava/lang/Number;)Ljava/lang/Float;", AccessFlags = 1)]
				public virtual float? Evaluate(float fraction, global::Java.Lang.Number startValue, global::Java.Lang.Number endValue) /* MethodBuilder.Create */ 
				{
						return default(float?);
				}

				[Dot42.DexImport("android/animation/TypeEvaluator", "evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", AccessFlags = 1025, Signature = "(FTT;TT;)TT;")]
				global::Java.Lang.Number global::Android.Animation.ITypeEvaluator<global::Java.Lang.Number>.Evaluate(float fraction, global::Java.Lang.Number startValue, global::Java.Lang.Number endValue) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Java.Lang.Number);
				}

		}

		/// <summary>
		/// <para>This adapter class provides empty implementations of the methods from android.animation.Animator.AnimatorListener. Any custom listener that cares only about a subset of the methods of this listener can simply subclass this adapter class instead of implementing the interface directly. </para>    
		/// </summary>
		/// <java-name>
		/// android/animation/AnimatorListenerAdapter
		/// </java-name>
		[Dot42.DexImport("android/animation/AnimatorListenerAdapter", AccessFlags = 1057)]
		public abstract partial class AnimatorListenerAdapter : global::Android.Animation.Animator.IAnimatorListener, global::Android.Animation.Animator.IAnimatorPauseListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AnimatorListenerAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Notifies the cancellation of the animation. This callback is not invoked for animations with repeat count set to INFINITE.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onAnimationCancel
				/// </java-name>
				[Dot42.DexImport("onAnimationCancel", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationCancel(global::Android.Animation.Animator animation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Notifies the end of the animation. This callback is not invoked for animations with repeat count set to INFINITE.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onAnimationEnd
				/// </java-name>
				[Dot42.DexImport("onAnimationEnd", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationEnd(global::Android.Animation.Animator animation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Notifies the repetition of the animation.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onAnimationRepeat
				/// </java-name>
				[Dot42.DexImport("onAnimationRepeat", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationRepeat(global::Android.Animation.Animator animation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Notifies the start of the animation.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onAnimationStart
				/// </java-name>
				[Dot42.DexImport("onAnimationStart", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationStart(global::Android.Animation.Animator animation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationPause
				/// </java-name>
				[Dot42.DexImport("onAnimationPause", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationPause(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationResume
				/// </java-name>
				[Dot42.DexImport("onAnimationResume", "(Landroid/animation/Animator;)V", AccessFlags = 1)]
				public virtual void OnAnimationResume(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		/// <para>This class plays a set of Animator objects in the specified order. Animations can be set up to play together, in sequence, or after a specified delay.</para><para>There are two different approaches to adding animations to a <code>AnimatorSet</code>: either the playTogether() or playSequentially() methods can be called to add a set of animations all at once, or the AnimatorSet#play(Animator) can be used in conjunction with methods in the Builder class to add animations one by one.</para><para>It is possible to set up a <code>AnimatorSet</code> with circular dependencies between its animations. For example, an animation a1 could be set up to start before animation a2, a2 before a3, and a3 before a1. The results of this configuration are undefined, but will typically result in none of the affected animations being played. Because of this (and because circular dependencies do not make logical sense anyway), circular dependencies should be avoided, and the dependency flow of animations should only be in one direction.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about animating with <c> AnimatorSet </c> , read the  developer guide.</para><para>  </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Sets up this AnimatorSet to play all of the supplied animations at the same time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// playTogether
				/// </java-name>
				[Dot42.DexImport("playTogether", "([Landroid/animation/Animator;)V", AccessFlags = 129)]
				public void PlayTogether(params global::Android.Animation.Animator[] items) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets up this AnimatorSet to play all of the supplied animations at the same time.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// playTogether
				/// </java-name>
				[Dot42.DexImport("playTogether", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Landroid/animation/Animator;>;)V")]
				public void PlayTogether(global::Java.Util.ICollection<global::Android.Animation.Animator> items) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets up this AnimatorSet to play each of the supplied animations when the previous animation ends.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// playSequentially
				/// </java-name>
				[Dot42.DexImport("playSequentially", "([Landroid/animation/Animator;)V", AccessFlags = 129)]
				public void PlaySequentially(params global::Android.Animation.Animator[] items) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets up this AnimatorSet to play each of the supplied animations when the previous animation ends.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// playSequentially
				/// </java-name>
				[Dot42.DexImport("playSequentially", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/animation/Animator;>;)V")]
				public void PlaySequentially(global::Java.Util.IList<global::Android.Animation.Animator> items) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current list of child Animator objects controlled by this AnimatorSet. This is a copy of the internal list; modifications to the returned list will not affect the AnimatorSet, although changes to the underlying Animator objects will affect those objects being managed by the AnimatorSet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ArrayList&lt;Animator&gt; The list of child animations of this AnimatorSet. </para>
				/// </returns>
				/// <java-name>
				/// getChildAnimations
				/// </java-name>
				[Dot42.DexImport("getChildAnimations", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/animation/Animator;>;")]
				public global::Java.Util.ArrayList<global::Android.Animation.Animator> GetChildAnimations() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Animation.Animator>);
				}

				/// <summary>
				/// <para>Sets the target object for all current child animations of this AnimatorSet that take targets (ObjectAnimator and AnimatorSet).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTarget
				/// </java-name>
				[Dot42.DexImport("setTarget", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public override void SetTarget(object target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the TimeInterpolator for all current child animations of this AnimatorSet. The default value is null, which means that no interpolator is set on this AnimatorSet. Setting the interpolator to any non-null value will cause that interpolator to be set on the child animations when the set is started.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
				public override void SetInterpolator(global::Android.Animation.ITimeInterpolator interpolator) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the timing interpolator that this animation uses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The timing interpolator for this animation. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
				public override global::Android.Animation.ITimeInterpolator GetInterpolator() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ITimeInterpolator);
				}

				/// <summary>
				/// <para>This method creates a <code>Builder</code> object, which is used to set up playing constraints. This initial <code>play()</code> method tells the <code>Builder</code> the animation that is the dependency for the succeeding commands to the <code>Builder</code>. For example, calling <code>play(a1).with(a2)</code> sets up the AnimatorSet to play <code>a1</code> and <code>a2</code> at the same time, <code>play(a1).before(a2)</code> sets up the AnimatorSet to play <code>a1</code> first, followed by <code>a2</code>, and <code>play(a1).after(a2)</code> sets up the AnimatorSet to play <code>a2</code> first, followed by <code>a1</code>.</para><para>Note that <code>play()</code> is the only way to tell the <code>Builder</code> the animation upon which the dependency is created, so successive calls to the various functions in <code>Builder</code> will all refer to the initial parameter supplied in <code>play()</code> as the dependency of the other animations. For example, calling <code>play(a1).before(a2).before(a3)</code> will play both <code>a2</code> and <code>a3</code> when a1 ends; it does not set up a dependency between <code>a2</code> and <code>a3</code>.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Builder The object that constructs the AnimatorSet based on the dependencies outlined in the calls to <code>play</code> and the other methods in the <code>Builder&lt;/code object. </code></para>
				/// </returns>
				/// <java-name>
				/// play
				/// </java-name>
				[Dot42.DexImport("play", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
				public global::Android.Animation.AnimatorSet.Builder Play(global::Android.Animation.Animator anim) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.AnimatorSet.Builder);
				}

				/// <summary>
				/// <para><para>Cancels the animation. Unlike end(), <code>cancel()</code> causes the animation to stop in its tracks, sending an android.animation.Animator.AnimatorListener#onAnimationCancel(Animator) to its listeners, followed by an android.animation.Animator.AnimatorListener#onAnimationEnd(Animator) message.</para><para>This method must be called on the thread that is running the animation.</para></para><para>Note that canceling a <code>AnimatorSet</code> also cancels all of the animations that it is responsible for.</para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public override void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Ends the animation. This causes the animation to assign the end value of the property being animated, then calling the android.animation.Animator.AnimatorListener#onAnimationEnd(Animator) method on its listeners.</para><para>This method must be called on the thread that is running the animation.</para></para><para>Note that ending a <code>AnimatorSet</code> also ends all of the animations that it is responsible for.</para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 1)]
				public override void End() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if any of the child animations of this AnimatorSet have been started and have not yet ended. </para>        
				/// </summary>
				/// <returns>
				/// <para>Whether this AnimatorSet has been started and has not yet ended. </para>
				/// </returns>
				/// <java-name>
				/// isRunning
				/// </java-name>
				[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1)]
				public override bool IsRunning() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns whether this Animator has been started and not yet ended. This state is a superset of the state of isRunning(), because an Animator with a nonzero startDelay will return true for isStarted() during the delay phase, whereas isRunning() will return true only after the delay phase is complete.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the Animator has been started and not yet ended. </para>
				/// </returns>
				/// <java-name>
				/// isStarted
				/// </java-name>
				[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
				public override bool IsStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay starting the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of milliseconds to delay running the animation </para>
				/// </returns>
				/// <java-name>
				/// getStartDelay
				/// </java-name>
				[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
				public override long GetStartDelay() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay starting the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1)]
				public override void SetStartDelay(long startDelay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the length of each of the child animations of this AnimatorSet. This value may be less than 0, which indicates that no duration has been set on this AnimatorSet and each of the child animations will use their own duration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The length of the animation, in milliseconds, of each of the child animations of this AnimatorSet. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
				public override long GetDuration() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the length of each of the current child animations of this AnimatorSet. By default, each child animation will use its own duration. If the duration is set on the AnimatorSet, then each child animation inherits this duration.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/animation/AnimatorSet;", AccessFlags = 1)]
				public override global::Android.Animation.Animator SetDuration(long duration) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

				/// <summary>
				/// <para>This method tells the object to use appropriate information to extract starting values for the animation. For example, a AnimatorSet object will pass this call to its child objects to tell them to set up the values. A ObjectAnimator object will use the information it has about its target object and PropertyValuesHolder objects to get the start values for its properties. A ValueAnimator object will ignore the request since it does not have enough information (such as a target object) to gather these values. </para>        
				/// </summary>
				/// <java-name>
				/// setupStartValues
				/// </java-name>
				[Dot42.DexImport("setupStartValues", "()V", AccessFlags = 1)]
				public override void SetupStartValues() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method tells the object to use appropriate information to extract ending values for the animation. For example, a AnimatorSet object will pass this call to its child objects to tell them to set up the values. A ObjectAnimator object will use the information it has about its target object and PropertyValuesHolder objects to get the start values for its properties. A ValueAnimator object will ignore the request since it does not have enough information (such as a target object) to gather these values. </para>        
				/// </summary>
				/// <java-name>
				/// setupEndValues
				/// </java-name>
				[Dot42.DexImport("setupEndValues", "()V", AccessFlags = 1)]
				public override void SetupEndValues() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public override void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public override void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Starts this animation. If the animation has a nonzero startDelay, the animation will start running after that delay elapses. A non-delayed animation will have its initial value(s) set immediately, followed by calls to AnimatorListener#onAnimationStart(Animator) for any listeners of this animator.</para><para>The animation started by calling this method will be run on the thread that called this method. This thread should have a Looper on it (a runtime exception will be thrown if this is not the case). Also, if the animation will animate properties of objects in the view hierarchy, then the calling thread should be the UI thread for that view hierarchy.</para></para><para>Starting this <code>AnimatorSet</code> will, in turn, start the animations for which it is responsible. The details of when exactly those animations are started depends on the dependency relationships that have been set up between the animations. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>Returns the current list of child Animator objects controlled by this AnimatorSet. This is a copy of the internal list; modifications to the returned list will not affect the AnimatorSet, although changes to the underlying Animator objects will affect those objects being managed by the AnimatorSet.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ArrayList&lt;Animator&gt; The list of child animations of this AnimatorSet. </para>
				/// </returns>
				/// <java-name>
				/// getChildAnimations
				/// </java-name>
				public global::Java.Util.ArrayList<global::Android.Animation.Animator> ChildAnimations
				{
				[Dot42.DexImport("getChildAnimations", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/animation/Animator;>;")]
						get{ return GetChildAnimations(); }
				}

				/// <summary>
				/// <para>Returns the timing interpolator that this animation uses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The timing interpolator for this animation. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public global::Android.Animation.ITimeInterpolator Interpolator
				{
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
						get{ return GetInterpolator(); }
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1)]
						set{ SetInterpolator(value); }
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay starting the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of milliseconds to delay running the animation </para>
				/// </returns>
				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public long StartDelay
				{
				[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
						get{ return GetStartDelay(); }
				[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1)]
						set{ SetStartDelay(value); }
				}

				/// <summary>
				/// <para>Gets the length of each of the child animations of this AnimatorSet. This value may be less than 0, which indicates that no duration has been set on this AnimatorSet and each of the child animations will use their own duration.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The length of the animation, in milliseconds, of each of the child animations of this AnimatorSet. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public long Duration
				{
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return GetDuration(); }
				}

				/// <summary>
				/// <para>The <code>Builder</code> object is a utility class to facilitate adding animations to a <code>AnimatorSet</code> along with the relationships between the various animations. The intention of the <code>Builder</code> methods, along with the play() method of <code>AnimatorSet</code> is to make it possible to express the dependency relationships of animations in a natural way. Developers can also use the playTogether() and playSequentially() methods if these suit the need, but it might be easier in some situations to express the AnimatorSet of animations in pairs. </para><para>The <code>Builder</code> object cannot be constructed directly, but is rather constructed internally via a call to AnimatorSet#play(Animator).</para><para>For example, this sets up a AnimatorSet to play anim1 and anim2 at the same time, anim3 to play when anim2 finishes, and anim4 to play when anim3 finishes:</para><para><pre>
				///            AnimatorSet s = new AnimatorSet();
				///            s.play(anim1).with(anim2);
				///            s.play(anim2).before(anim3);
				///            s.play(anim4).after(anim3);
				///        </pre> </para><para>Note in the example that both Builder#before(Animator) and Builder#after(Animator) are used. These are just different ways of expressing the same relationship and are provided to make it easier to say things in a way that is more natural, depending on the situation.</para><para>It is possible to make several calls into the same <code>Builder</code> object to express multiple relationships. However, note that it is only the animation passed into the initial AnimatorSet#play(Animator) method that is the dependency in any of the successive calls to the <code>Builder</code> object. For example, the following code starts both anim2 and anim3 when anim1 ends; there is no direct dependency relationship between anim2 and anim3: <pre>
				///          AnimatorSet s = new AnimatorSet();
				///          s.play(anim1).before(anim2).before(anim3);
				///        </pre> If the desired result is to play anim1 then anim2 then anim3, this code expresses the relationship correctly:</para><para><pre>
				///          AnimatorSet s = new AnimatorSet();
				///          s.play(anim1).before(anim2);
				///          s.play(anim2).before(anim3);
				///        </pre> </para><para>Note that it is possible to express relationships that cannot be resolved and will not result in sensible results. For example, <code>play(anim1).after(anim1)</code> makes no sense. In general, circular dependencies like this one (or more indirect ones where a depends on b, which depends on c, which depends on a) should be avoided. Only create AnimatorSets that can boil down to a simple, one-way relationship of animations starting with, before, and after other, different, animations.</para>    
				/// </summary>
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

						/// <summary>
						/// <para>Sets up the given animation to play at the same time as the animation supplied in the AnimatorSet#play(Animator) call that created this <code>Builder</code> object.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// with
						/// </java-name>
						[Dot42.DexImport("with", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
						public virtual Builder With(global::Android.Animation.Animator anim) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Sets up the given animation to play when the animation supplied in the AnimatorSet#play(Animator) call that created this <code>Builder</code> object ends.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// before
						/// </java-name>
						[Dot42.DexImport("before", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
						public virtual Builder Before(global::Android.Animation.Animator anim) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Sets up the given animation to play when the animation supplied in the AnimatorSet#play(Animator) call that created this <code>Builder</code> object to start when the animation supplied in this method call ends.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// after
						/// </java-name>
						[Dot42.DexImport("after", "(Landroid/animation/Animator;)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
						public virtual Builder After(global::Android.Animation.Animator anim) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						/// <summary>
						/// <para>Sets up the given animation to play when the animation supplied in the AnimatorSet#play(Animator) call that created this <code>Builder</code> object to start when the animation supplied in this method call ends.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// after
						/// </java-name>
						[Dot42.DexImport("after", "(J)Landroid/animation/AnimatorSet$Builder;", AccessFlags = 1)]
						public virtual Builder After(long anim) /* MethodBuilder.Create */ 
						{
								return default(Builder);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Builder() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>A time interpolator defines the rate of change of an animation. This allows animations to have non-linear motion, such as acceleration and deceleration. </para>    
		/// </summary>
		/// <java-name>
		/// android/animation/TimeInterpolator
		/// </java-name>
		[Dot42.DexImport("android/animation/TimeInterpolator", AccessFlags = 1537)]
		public partial interface ITimeInterpolator
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Maps a value representing the elapsed fraction of an animation to a value that represents the interpolated fraction. This interpolated value is then multiplied by the change in value of an animation to derive the animated value at the current elapsed animation time.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The interpolation value. This value can be more than 1.0 for interpolators which overshoot their targets, or less than 0 for interpolators that undershoot their targets. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolation
				/// </java-name>
				[Dot42.DexImport("getInterpolation", "(F)F", AccessFlags = 1025)]
				float GetInterpolation(float input) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This evaluator can be used to perform type interpolation between <code>Rect</code> values. </para>    
		/// </summary>
		/// <java-name>
		/// android/animation/RectEvaluator
		/// </java-name>
		[Dot42.DexImport("android/animation/RectEvaluator", AccessFlags = 33, Signature = "Ljava/lang/Object;Landroid/animation/TypeEvaluator<Landroid/graphics/Rect;>;")]
		public partial class RectEvaluator : global::Android.Animation.ITypeEvaluator<global::Android.Graphics.Rect>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RectEvaluator() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This function returns the result of linearly interpolating the start and end Rect values, with <code>fraction</code> representing the proportion between the start and end values. The calculation is a simple parametric calculation on each of the separate components in the Rect objects (left, top, right, and bottom).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A linear interpolation between the start and end values, given the <code>fraction</code> parameter. </para>
				/// </returns>
				/// <java-name>
				/// evaluate
				/// </java-name>
				[Dot42.DexImport("evaluate", "(FLandroid/graphics/Rect;Landroid/graphics/Rect;)Landroid/graphics/Rect;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Rect Evaluate(float fraction, global::Android.Graphics.Rect startValue, global::Android.Graphics.Rect endValue) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

		}

		/// <summary>
		/// <para>This class is used to instantiate animator XML files into Animator objects. </para><para>For performance reasons, inflation relies heavily on pre-processing of XML files that is done at build time. Therefore, it is not currently possible to use this inflater with an XmlPullParser over a plain XML file at runtime; it only works with an XmlPullParser returned from a compiled resource (R. <b>something</b> file.) </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Loads an Animator object from a resource</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The animator object reference by the specified id </para>
				/// </returns>
				/// <java-name>
				/// loadAnimator
				/// </java-name>
				[Dot42.DexImport("loadAnimator", "(Landroid/content/Context;I)Landroid/animation/Animator;", AccessFlags = 9)]
				public static global::Android.Animation.Animator LoadAnimator(global::Android.Content.Context context, int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.Animator);
				}

		}

		/// <summary>
		/// <para>This is the superclass for classes which provide basic support for animations which can be started, ended, and have <code>AnimatorListeners</code> added to them. </para>    
		/// </summary>
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

				/// <summary>
				/// <para>Starts this animation. If the animation has a nonzero startDelay, the animation will start running after that delay elapses. A non-delayed animation will have its initial value(s) set immediately, followed by calls to AnimatorListener#onAnimationStart(Animator) for any listeners of this animator.</para><para>The animation started by calling this method will be run on the thread that called this method. This thread should have a Looper on it (a runtime exception will be thrown if this is not the case). Also, if the animation will animate properties of objects in the view hierarchy, then the calling thread should be the UI thread for that view hierarchy.</para>        
				/// </summary>
				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Cancels the animation. Unlike end(), <code>cancel()</code> causes the animation to stop in its tracks, sending an android.animation.Animator.AnimatorListener#onAnimationCancel(Animator) to its listeners, followed by an android.animation.Animator.AnimatorListener#onAnimationEnd(Animator) message.</para><para>This method must be called on the thread that is running the animation.</para>        
				/// </summary>
				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Ends the animation. This causes the animation to assign the end value of the property being animated, then calling the android.animation.Animator.AnimatorListener#onAnimationEnd(Animator) method on its listeners.</para><para>This method must be called on the thread that is running the animation.</para>        
				/// </summary>
				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "()V", AccessFlags = 1)]
				public virtual void End() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pause
				/// </java-name>
				[Dot42.DexImport("pause", "()V", AccessFlags = 1)]
				public virtual void Pause() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resume
				/// </java-name>
				[Dot42.DexImport("resume", "()V", AccessFlags = 1)]
				public virtual void Resume() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPaused
				/// </java-name>
				[Dot42.DexImport("isPaused", "()Z", AccessFlags = 1)]
				public virtual bool IsPaused() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay processing the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of milliseconds to delay running the animation </para>
				/// </returns>
				/// <java-name>
				/// getStartDelay
				/// </java-name>
				[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1025)]
				public abstract long GetStartDelay() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay processing the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1025)]
				public abstract void SetStartDelay(long startDelay) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Sets the duration of the animation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/animation/Animator;", AccessFlags = 1025)]
				public abstract global::Android.Animation.Animator SetDuration(long duration) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Gets the duration of the animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The length of the animation, in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1025)]
				public abstract long GetDuration() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>The time interpolator used in calculating the elapsed fraction of the animation. The interpolator determines whether the animation runs with linear or non-linear motion, such as acceleration and deceleration. The default value is android.view.animation.AccelerateDecelerateInterpolator.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1025)]
				public abstract void SetInterpolator(global::Android.Animation.ITimeInterpolator value) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns the timing interpolator that this animation uses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The timing interpolator for this animation. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
				public virtual global::Android.Animation.ITimeInterpolator GetInterpolator() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Animation.ITimeInterpolator);
				}

				/// <summary>
				/// <para>Returns whether this Animator is currently running (having been started and gone past any initial startDelay period and not yet ended).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the Animator is running. </para>
				/// </returns>
				/// <java-name>
				/// isRunning
				/// </java-name>
				[Dot42.DexImport("isRunning", "()Z", AccessFlags = 1025)]
				public abstract bool IsRunning() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns whether this Animator has been started and not yet ended. This state is a superset of the state of isRunning(), because an Animator with a nonzero startDelay will return true for isStarted() during the delay phase, whereas isRunning() will return true only after the delay phase is complete.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the Animator has been started and not yet ended. </para>
				/// </returns>
				/// <java-name>
				/// isStarted
				/// </java-name>
				[Dot42.DexImport("isStarted", "()Z", AccessFlags = 1)]
				public virtual bool IsStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Adds a listener to the set of listeners that are sent events through the life of an animation, such as start, repeat, and end.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addListener
				/// </java-name>
				[Dot42.DexImport("addListener", "(Landroid/animation/Animator$AnimatorListener;)V", AccessFlags = 1)]
				public virtual void AddListener(global::Android.Animation.Animator.IAnimatorListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes a listener from the set listening to this animation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// removeListener
				/// </java-name>
				[Dot42.DexImport("removeListener", "(Landroid/animation/Animator$AnimatorListener;)V", AccessFlags = 1)]
				public virtual void RemoveListener(global::Android.Animation.Animator.IAnimatorListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the set of android.animation.Animator.AnimatorListener objects that are currently listening for events on this <code>Animator</code> object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ArrayList&lt;AnimatorListener&gt; The set of listeners. </para>
				/// </returns>
				/// <java-name>
				/// getListeners
				/// </java-name>
				[Dot42.DexImport("getListeners", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/animation/Animator$AnimatorListener;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Animation.Animator.IAnimatorListener> GetListeners() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Animation.Animator.IAnimatorListener>);
				}

				/// <java-name>
				/// addPauseListener
				/// </java-name>
				[Dot42.DexImport("addPauseListener", "(Landroid/animation/Animator$AnimatorPauseListener;)V", AccessFlags = 1)]
				public virtual void AddPauseListener(global::Android.Animation.Animator.IAnimatorPauseListener animatorPauseListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removePauseListener
				/// </java-name>
				[Dot42.DexImport("removePauseListener", "(Landroid/animation/Animator$AnimatorPauseListener;)V", AccessFlags = 1)]
				public virtual void RemovePauseListener(global::Android.Animation.Animator.IAnimatorPauseListener animatorPauseListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Removes all listeners from this object. This is equivalent to calling <code>getListeners()</code> followed by calling <code>clear()</code> on the returned list of listeners. </para>        
				/// </summary>
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

				/// <summary>
				/// <para>This method tells the object to use appropriate information to extract starting values for the animation. For example, a AnimatorSet object will pass this call to its child objects to tell them to set up the values. A ObjectAnimator object will use the information it has about its target object and PropertyValuesHolder objects to get the start values for its properties. A ValueAnimator object will ignore the request since it does not have enough information (such as a target object) to gather these values. </para>        
				/// </summary>
				/// <java-name>
				/// setupStartValues
				/// </java-name>
				[Dot42.DexImport("setupStartValues", "()V", AccessFlags = 1)]
				public virtual void SetupStartValues() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method tells the object to use appropriate information to extract ending values for the animation. For example, a AnimatorSet object will pass this call to its child objects to tell them to set up the values. A ObjectAnimator object will use the information it has about its target object and PropertyValuesHolder objects to get the start values for its properties. A ValueAnimator object will ignore the request since it does not have enough information (such as a target object) to gather these values. </para>        
				/// </summary>
				/// <java-name>
				/// setupEndValues
				/// </java-name>
				[Dot42.DexImport("setupEndValues", "()V", AccessFlags = 1)]
				public virtual void SetupEndValues() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the target object whose property will be animated by this animation. Not all subclasses operate on target objects (for example, ValueAnimator, but this method is on the superclass for the convenience of dealing generically with those subclasses that do handle targets.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTarget
				/// </java-name>
				[Dot42.DexImport("setTarget", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetTarget(object target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The amount of time, in milliseconds, to delay processing the animation after start() is called.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the number of milliseconds to delay running the animation </para>
				/// </returns>
				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public long StartDelay
				{
				[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1025)]
						get{ return GetStartDelay(); }
				[Dot42.DexImport("setStartDelay", "(J)V", AccessFlags = 1025)]
						set{ SetStartDelay(value); }
				}

				/// <summary>
				/// <para>Gets the duration of the animation.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The length of the animation, in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getDuration
				/// </java-name>
				public long Duration
				{
				[Dot42.DexImport("getDuration", "()J", AccessFlags = 1025)]
						get{ return GetDuration(); }
				}

				/// <summary>
				/// <para>Returns the timing interpolator that this animation uses.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The timing interpolator for this animation. </para>
				/// </returns>
				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public global::Android.Animation.ITimeInterpolator Interpolator
				{
				[Dot42.DexImport("getInterpolator", "()Landroid/animation/TimeInterpolator;", AccessFlags = 1)]
						get{ return GetInterpolator(); }
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)V", AccessFlags = 1025)]
						set{ SetInterpolator(value); }
				}

				/// <summary>
				/// <para>Gets the set of android.animation.Animator.AnimatorListener objects that are currently listening for events on this <code>Animator</code> object.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>ArrayList&lt;AnimatorListener&gt; The set of listeners. </para>
				/// </returns>
				/// <java-name>
				/// getListeners
				/// </java-name>
				public global::Java.Util.ArrayList<global::Android.Animation.Animator.IAnimatorListener> Listeners
				{
				[Dot42.DexImport("getListeners", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/animation/Animator$AnimatorListener;>;")]
						get{ return GetListeners(); }
				}

				/// <java-name>
				/// android/animation/Animator$AnimatorPauseListener
				/// </java-name>
				[Dot42.DexImport("android/animation/Animator$AnimatorPauseListener", AccessFlags = 1545)]
				public partial interface IAnimatorPauseListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onAnimationPause
						/// </java-name>
						[Dot42.DexImport("onAnimationPause", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationPause(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onAnimationResume
						/// </java-name>
						[Dot42.DexImport("onAnimationResume", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationResume(global::Android.Animation.Animator animator) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>An animation listener receives notifications from an animation. Notifications indicate animation related events, such as the end or the repetition of the animation.</para>    
				/// </summary>
				/// <java-name>
				/// android/animation/Animator$AnimatorListener
				/// </java-name>
				[Dot42.DexImport("android/animation/Animator$AnimatorListener", AccessFlags = 1545)]
				public partial interface IAnimatorListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Notifies the start of the animation.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAnimationStart
						/// </java-name>
						[Dot42.DexImport("onAnimationStart", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationStart(global::Android.Animation.Animator animation) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Notifies the end of the animation. This callback is not invoked for animations with repeat count set to INFINITE.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAnimationEnd
						/// </java-name>
						[Dot42.DexImport("onAnimationEnd", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationEnd(global::Android.Animation.Animator animation) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Notifies the cancellation of the animation. This callback is not invoked for animations with repeat count set to INFINITE.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAnimationCancel
						/// </java-name>
						[Dot42.DexImport("onAnimationCancel", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationCancel(global::Android.Animation.Animator animation) /* MethodBuilder.Create */ ;

						/// <summary>
						/// <para>Notifies the repetition of the animation.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAnimationRepeat
						/// </java-name>
						[Dot42.DexImport("onAnimationRepeat", "(Landroid/animation/Animator;)V", AccessFlags = 1025)]
						void OnAnimationRepeat(global::Android.Animation.Animator animation) /* MethodBuilder.Create */ ;

				}

		}

}


