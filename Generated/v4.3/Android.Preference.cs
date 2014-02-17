// Copyright (C) 2014 dot42
//
// Original filename: Android.Preference.cs
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
namespace Android.Preference
{
		/// <summary>
		/// <para>Common base class for preferences that have two selectable states, persist a boolean value in SharedPreferences, and may have dependent preferences that are enabled/disabled based on the current state. </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/TwoStatePreference
		/// </java-name>
		[Dot42.DexImport("android/preference/TwoStatePreference", AccessFlags = 1057)]
		public abstract partial class TwoStatePreference : global::Android.Preference.Preference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TwoStatePreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TwoStatePreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TwoStatePreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Processes a click on the preference. This includes saving the value to the SharedPreferences. However, the overridden method should call callChangeListener(Object) to make sure the client wants to update the preference's state with the new value. </para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal override void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the checked state and saves it to the SharedPreferences.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChecked(bool @checked) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the checked state.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The checked state. </para>
				/// </returns>
				/// <java-name>
				/// isChecked
				/// </java-name>
				[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
				public virtual bool IsChecked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether this preference's dependents should currently be disabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the dependents should be disabled, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// shouldDisableDependents
				/// </java-name>
				[Dot42.DexImport("shouldDisableDependents", "()Z", AccessFlags = 1)]
				public override bool ShouldDisableDependents() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>setSummaryOn(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSummaryOn
				/// </java-name>
				[Dot42.DexImport("setSummaryOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetSummaryOn(global::Java.Lang.ICharSequence summaryResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setSummaryOn(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSummaryOn
				/// </java-name>
				[Dot42.DexImport("setSummaryOn", "(I)V", AccessFlags = 1)]
				public virtual void SetSummaryOn(int summaryResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the summary to be shown when checked. </para>        
				/// </summary>
				/// <returns>
				/// <para>The summary. </para>
				/// </returns>
				/// <java-name>
				/// getSummaryOn
				/// </java-name>
				[Dot42.DexImport("getSummaryOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetSummaryOn() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para><para>setSummaryOff(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSummaryOff
				/// </java-name>
				[Dot42.DexImport("setSummaryOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetSummaryOff(global::Java.Lang.ICharSequence summaryResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setSummaryOff(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSummaryOff
				/// </java-name>
				[Dot42.DexImport("setSummaryOff", "(I)V", AccessFlags = 1)]
				public virtual void SetSummaryOff(int summaryResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the summary to be shown when unchecked. </para>        
				/// </summary>
				/// <returns>
				/// <para>The summary. </para>
				/// </returns>
				/// <java-name>
				/// getSummaryOff
				/// </java-name>
				[Dot42.DexImport("getSummaryOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetSummaryOff() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Returns whether dependents are disabled when this preference is on (<c> true </c> ) or when this preference is off (<c> false </c> ).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether dependents are disabled when this preference is on (<c> true </c> ) or when this preference is off (<c> false </c> ). </para>
				/// </returns>
				/// <java-name>
				/// getDisableDependentsState
				/// </java-name>
				[Dot42.DexImport("getDisableDependentsState", "()Z", AccessFlags = 1)]
				public virtual bool GetDisableDependentsState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether dependents are disabled when this preference is on (<c> true </c> ) or when this preference is off (<c> false </c> ).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDisableDependentsState
				/// </java-name>
				[Dot42.DexImport("setDisableDependentsState", "(Z)V", AccessFlags = 1)]
				public virtual void SetDisableDependentsState(bool disableDependentsState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when a Preference is being inflated and the default value attribute needs to be read. Since different Preference types have different value types, the subclass should get and return the default value which will be its value type. </para><para>For example, if the value type is String, the body of the method would proxy to TypedArray#getString(int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The default value of this preference type. </para>
				/// </returns>
				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray a, int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Implement this to set the initial value of the Preference. </para><para>If <b>restorePersistedValue</b> is true, you should restore the Preference value from the android.content.SharedPreferences. If <b>restorePersistedValue</b> is false, you should set the Preference value to defaultValue that is given (and possibly store to SharedPreferences if shouldPersist() is true). </para><para>This may not always be called. One example is if it should not persist but there is no default value given.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool restorePersistedValue, object defaultValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Hook allowing a Preference to generate a representation of its internal state that can later be used to create a new instance with that same state. This state should only contain information that is not persistent or can be reconstructed later.</para><para><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>saveHierarchyState </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Parcelable object containing the current dynamic state of this Preference, or null if there is nothing interesting to save. The default implementation returns null. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.Os.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				/// <summary>
				/// <para>Hook allowing a Preference to re-apply a representation of its internal state that had previously been generated by onSaveInstanceState. This function will never be called with a null state.</para><para><para>onSaveInstanceState </para><simplesectsep></simplesectsep><para>restoreHierarchyState </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.Os.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TwoStatePreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the summary to be shown when checked. </para>        
				/// </summary>
				/// <returns>
				/// <para>The summary. </para>
				/// </returns>
				/// <java-name>
				/// getSummaryOn
				/// </java-name>
				public global::Java.Lang.ICharSequence SummaryOn
				{
				[Dot42.DexImport("getSummaryOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetSummaryOn(); }
				[Dot42.DexImport("setSummaryOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetSummaryOn(value); }
				}

				/// <summary>
				/// <para>Returns the summary to be shown when unchecked. </para>        
				/// </summary>
				/// <returns>
				/// <para>The summary. </para>
				/// </returns>
				/// <java-name>
				/// getSummaryOff
				/// </java-name>
				public global::Java.Lang.ICharSequence SummaryOff
				{
				[Dot42.DexImport("getSummaryOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetSummaryOff(); }
				[Dot42.DexImport("setSummaryOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetSummaryOff(value); }
				}

				/// <summary>
				/// <para>Returns whether dependents are disabled when this preference is on (<c> true </c> ) or when this preference is off (<c> false </c> ).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether dependents are disabled when this preference is on (<c> true </c> ) or when this preference is off (<c> false </c> ). </para>
				/// </returns>
				/// <java-name>
				/// getDisableDependentsState
				/// </java-name>
				public bool IsDisableDependentsState
				{
				[Dot42.DexImport("getDisableDependentsState", "()Z", AccessFlags = 1)]
						get{ return GetDisableDependentsState(); }
				[Dot42.DexImport("setDisableDependentsState", "(Z)V", AccessFlags = 1)]
						set{ SetDisableDependentsState(value); }
				}

		}

		/// <summary>
		/// <para>A Preference that allows for string input. </para><para>It is a subclass of DialogPreference and shows the EditText in a dialog. This EditText can be modified either programmatically via getEditText(), or through XML by setting any EditText attributes on the EditTextPreference. </para><para>This preference will store a string into the SharedPreferences. </para><para>See EditText Attributes. </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/EditTextPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/EditTextPreference", AccessFlags = 33)]
		public partial class EditTextPreference : global::Android.Preference.DialogPreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public EditTextPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public EditTextPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public EditTextPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Saves the text to the SharedPreferences.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetText(string text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the text from the SharedPreferences.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current preference value. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetText() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Binds views in the content View of the dialog to data. </para><para>Make sure to call through to the superclass implementation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onBindDialogView
				/// </java-name>
				[Dot42.DexImport("onBindDialogView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal override void OnBindDialogView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds the EditText widget of this preference to the dialog's view.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onAddEditTextToDialogView
				/// </java-name>
				[Dot42.DexImport("onAddEditTextToDialogView", "(Landroid/view/View;Landroid/widget/EditText;)V", AccessFlags = 4)]
				protected internal virtual void OnAddEditTextToDialogView(global::Android.View.View dialogView, global::Android.Widget.EditText editText) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the dialog is dismissed and should be used to save data to the SharedPreferences.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDialogClosed
				/// </java-name>
				[Dot42.DexImport("onDialogClosed", "(Z)V", AccessFlags = 4)]
				protected internal override void OnDialogClosed(bool positiveResult) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when a Preference is being inflated and the default value attribute needs to be read. Since different Preference types have different value types, the subclass should get and return the default value which will be its value type. </para><para>For example, if the value type is String, the body of the method would proxy to TypedArray#getString(int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The default value of this preference type. </para>
				/// </returns>
				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray a, int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Implement this to set the initial value of the Preference. </para><para>If <b>restorePersistedValue</b> is true, you should restore the Preference value from the android.content.SharedPreferences. If <b>restorePersistedValue</b> is false, you should set the Preference value to defaultValue that is given (and possibly store to SharedPreferences if shouldPersist() is true). </para><para>This may not always be called. One example is if it should not persist but there is no default value given.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool restorePersistedValue, object defaultValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether this preference's dependents should currently be disabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the dependents should be disabled, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// shouldDisableDependents
				/// </java-name>
				[Dot42.DexImport("shouldDisableDependents", "()Z", AccessFlags = 1)]
				public override bool ShouldDisableDependents() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the EditText widget that will be shown in the dialog.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The EditText widget that will be shown in the dialog. </para>
				/// </returns>
				/// <java-name>
				/// getEditText
				/// </java-name>
				[Dot42.DexImport("getEditText", "()Landroid/widget/EditText;", AccessFlags = 1)]
				public virtual global::Android.Widget.EditText GetEditText() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.EditText);
				}

				/// <summary>
				/// <para>Hook allowing a Preference to generate a representation of its internal state that can later be used to create a new instance with that same state. This state should only contain information that is not persistent or can be reconstructed later.</para><para><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>saveHierarchyState </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Parcelable object containing the current dynamic state of this Preference, or null if there is nothing interesting to save. The default implementation returns null. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.Os.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				/// <summary>
				/// <para>Hook allowing a Preference to re-apply a representation of its internal state that had previously been generated by onSaveInstanceState. This function will never be called with a null state.</para><para><para>onSaveInstanceState </para><simplesectsep></simplesectsep><para>restoreHierarchyState </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.Os.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EditTextPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Gets the text from the SharedPreferences.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current preference value. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				public string Text
				{
				[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetText(); }
				[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetText(value); }
				}

				/// <summary>
				/// <para>Returns the EditText widget that will be shown in the dialog.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The EditText widget that will be shown in the dialog. </para>
				/// </returns>
				/// <java-name>
				/// getEditText
				/// </java-name>
				public global::Android.Widget.EditText EditText
				{
				[Dot42.DexImport("getEditText", "()Landroid/widget/EditText;", AccessFlags = 1)]
						get{ return GetEditText(); }
				}

		}

		/// <summary>
		/// <para>Shows a hierarchy of Preference objects as lists. These preferences will automatically save to SharedPreferences as the user interacts with them. To retrieve an instance of SharedPreferences that the preference hierarchy in this fragment will use, call PreferenceManager#getDefaultSharedPreferences(android.content.Context) with a context in the same package as this fragment. </para><para>Furthermore, the preferences shown will follow the visual style of system preferences. It is easy to create a hierarchy of preferences (that can be shown on multiple screens) via XML. For these reasons, it is recommended to use this fragment (as a superclass) to deal with preferences in applications. </para><para>A PreferenceScreen object should be at the top of the preference hierarchy. Furthermore, subsequent PreferenceScreen in the hierarchy denote a screen breakthat is the preferences contained within subsequent PreferenceScreen should be shown on another screen. The preference framework handles showing these other screens from the preference hierarchy. </para><para>The preference hierarchy can be formed in multiple ways:  From an XML file specifying the hierarchy  From different Activities that each specify its own preferences in an XML file via Activity meta-data  From an object hierarchy rooted with PreferenceScreen </para><para>To inflate from XML, use the addPreferencesFromResource(int). The root element should be a PreferenceScreen. Subsequent elements can point to actual Preference subclasses. As mentioned above, subsequent PreferenceScreen in the hierarchy will result in the screen break. </para><para>To specify an Intent to query Activities that each have preferences, use addPreferencesFromIntent. Each Activity can specify meta-data in the manifest (via the key PreferenceManager#METADATA_KEY_PREFERENCES) that points to an XML resource. These XML resources will be inflated into a single preference hierarchy and shown by this fragment. </para><para>To specify an object hierarchy rooted with PreferenceScreen, use setPreferenceScreen(PreferenceScreen). </para><para>As a convenience, this fragment implements a click listener for any preference in the current hierarchy, see onPreferenceTreeClick(PreferenceScreen, Preference).</para><para> <h3>Developer Guides</h3></para><para> </para><para>For information about using <c> PreferenceFragment </c> , read the  guide.</para><para> </para><para> <h3>Sample Code</h3></para><para>The following sample code shows a simple preference fragment that is populated from a resource. The resource it loads is:</para><para>{ development/samples/ApiDemos/res/xml/preferences.xml preferences}</para><para>The fragment implementation itself simply populates the preferences when created. Note that the preferences framework takes care of loading the current values out of the app preferences and writing them when changed:</para><para>{ development/samples/ApiDemos/src/com/example/android/apis/preference/FragmentPreferences.java fragment}</para><para><para>Preference </para><simplesectsep></simplesectsep><para>PreferenceScreen </para></para>    
		/// </summary>
		/// <java-name>
		/// android/preference/PreferenceFragment
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceFragment", AccessFlags = 1057)]
		public abstract partial class PreferenceFragment : global::Android.App.Fragment
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PreferenceFragment() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called to do initial creation of a fragment. This is called after onAttach(Activity) and before onCreateView(LayoutInflater, ViewGroup, Bundle).</para><para>Note that this can be called while the fragment's activity is still in the process of being created. As such, you can not rely on things like the activity's content view hierarchy being initialized at this point. If you want to do work once the activity itself is created, see onActivityCreated(Bundle).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnCreate(global::Android.Os.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called to have the fragment instantiate its user interface view. This is optional, and non-graphical fragments can return null (which is the default implementation). This will be called between onCreate(Bundle) and onActivityCreated(Bundle).</para><para>If you return a View from here, you will later be called in onDestroyView when the view is being released.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Return the View for the fragment's UI, or null. </para>
				/// </returns>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroi" +
    "d/view/View;", AccessFlags = 1)]
				public override global::Android.View.View OnCreateView(global::Android.View.LayoutInflater inflater, global::Android.View.ViewGroup container, global::Android.Os.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Called when the fragment's activity has been created and this fragment's view hierarchy instantiated. It can be used to do final initialization once these pieces are in place, such as retrieving views or restoring state. It is also useful for fragments that use setRetainInstance(boolean) to retain their instance, as this callback tells the fragment when it is fully associated with the new activity instance. This is called after onCreateView and before onViewStateRestored(Bundle).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onActivityCreated
				/// </java-name>
				[Dot42.DexImport("onActivityCreated", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnActivityCreated(global::Android.Os.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the Fragment is visible to the user. This is generally tied to Activity.onStart of the containing Activity's lifecycle. </para>        
				/// </summary>
				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public override void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the Fragment is no longer started. This is generally tied to Activity.onStop of the containing Activity's lifecycle. </para>        
				/// </summary>
				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1)]
				public override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the view previously created by onCreateView has been detached from the fragment. The next time the fragment needs to be displayed, a new view will be created. This is called after onStop() and before onDestroy(). It is called <b>regardless</b> of whether onCreateView returned a non-null view. Internally it is called after the view's state has been saved but before it has been removed from its parent. </para>        
				/// </summary>
				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public override void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the fragment is no longer in use. This is called after onStop() and before onDetach(). </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called to ask the fragment to save its current dynamic state, so it can later be reconstructed in a new instance of its process is restarted. If a new instance of the fragment later needs to be created, the data you place in the Bundle here will be available in the Bundle given to onCreate(Bundle), onCreateView(LayoutInflater, ViewGroup, Bundle), and onActivityCreated(Bundle).</para><para>This corresponds to Activity.onSaveInstanceState(Bundle) and most of the discussion there applies here as well. Note however: <b>this method may be called at any time before onDestroy()</b>. There are many situations where a fragment may be mostly torn down (such as when placed on the back stack with no UI showing), but its state will not be saved until its owning activity actually needs to save its state.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnSaveInstanceState(global::Android.Os.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Receive the result from a previous call to startActivityForResult(Intent, int). This follows the related Activity API as described there in Activity#onActivityResult(int, int, Intent).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)V", AccessFlags = 1)]
				public override void OnActivityResult(int requestCode, int resultCode, global::Android.Content.Intent data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the PreferenceManager used by this fragment. </para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceManager. </para>
				/// </returns>
				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
				public virtual global::Android.Preference.PreferenceManager GetPreferenceManager() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.PreferenceManager);
				}

				/// <summary>
				/// <para>Sets the root of the preference hierarchy that this fragment is showing.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPreferenceScreen
				/// </java-name>
				[Dot42.DexImport("setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", AccessFlags = 1)]
				public virtual void SetPreferenceScreen(global::Android.Preference.PreferenceScreen preferenceScreen) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the root of the preference hierarchy that this fragment is showing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceScreen that is the root of the preference hierarchy. </para>
				/// </returns>
				/// <java-name>
				/// getPreferenceScreen
				/// </java-name>
				[Dot42.DexImport("getPreferenceScreen", "()Landroid/preference/PreferenceScreen;", AccessFlags = 1)]
				public virtual global::Android.Preference.PreferenceScreen GetPreferenceScreen() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.PreferenceScreen);
				}

				/// <summary>
				/// <para>Adds preferences from activities that match the given Intent.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addPreferencesFromIntent
				/// </java-name>
				[Dot42.DexImport("addPreferencesFromIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void AddPreferencesFromIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflates the given XML resource and adds the preference hierarchy to the current preference hierarchy.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addPreferencesFromResource
				/// </java-name>
				[Dot42.DexImport("addPreferencesFromResource", "(I)V", AccessFlags = 1)]
				public virtual void AddPreferencesFromResource(int preferencesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPreferenceTreeClick
				/// </java-name>
				[Dot42.DexImport("onPreferenceTreeClick", "(Landroid/preference/PreferenceScreen;Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool OnPreferenceTreeClick(global::Android.Preference.PreferenceScreen preferenceScreen, global::Android.Preference.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Finds a Preference based on its key.</para><para><para>PreferenceGroup::findPreference(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Preference with the key, or null. </para>
				/// </returns>
				/// <java-name>
				/// findPreference
				/// </java-name>
				[Dot42.DexImport("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preference.Preference FindPreference(global::Java.Lang.ICharSequence key) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.Preference);
				}

				/// <summary>
				/// <para>Returns the PreferenceManager used by this fragment. </para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceManager. </para>
				/// </returns>
				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				public global::Android.Preference.PreferenceManager PreferenceManager
				{
				[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
						get{ return GetPreferenceManager(); }
				}

				/// <summary>
				/// <para>Gets the root of the preference hierarchy that this fragment is showing.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceScreen that is the root of the preference hierarchy. </para>
				/// </returns>
				/// <java-name>
				/// getPreferenceScreen
				/// </java-name>
				public global::Android.Preference.PreferenceScreen PreferenceScreen
				{
				[Dot42.DexImport("getPreferenceScreen", "()Landroid/preference/PreferenceScreen;", AccessFlags = 1)]
						get{ return GetPreferenceScreen(); }
				[Dot42.DexImport("setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", AccessFlags = 1)]
						set{ SetPreferenceScreen(value); }
				}

				/// <summary>
				/// <para>Interface that PreferenceFragment's containing activity should implement to be able to process preference items that wish to switch to a new fragment. </para>    
				/// </summary>
				/// <java-name>
				/// android/preference/PreferenceFragment$OnPreferenceStartFragmentCallback
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceFragment$OnPreferenceStartFragmentCallback", AccessFlags = 1545)]
				public partial interface IOnPreferenceStartFragmentCallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when the user has clicked on a Preference that has a fragment class name associated with it. The implementation to should instantiate and switch to an instance of the given fragment. </para>        
						/// </summary>
						/// <java-name>
						/// onPreferenceStartFragment
						/// </java-name>
						[Dot42.DexImport("onPreferenceStartFragment", "(Landroid/preference/PreferenceFragment;Landroid/preference/Preference;)Z", AccessFlags = 1025)]
						bool OnPreferenceStartFragment(global::Android.Preference.PreferenceFragment caller, global::Android.Preference.Preference pref) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>Used to help create Preference hierarchies from activities or XML. </para><para>In most cases, clients should use PreferenceActivity#addPreferencesFromIntent or PreferenceActivity#addPreferencesFromResource(int).</para><para><para>PreferenceActivity </para></para>    
		/// </summary>
		/// <java-name>
		/// android/preference/PreferenceManager
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceManager", AccessFlags = 33)]
		public partial class PreferenceManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The Activity meta-data key for its XML preference hierarchy. </para>        
				/// </summary>
				/// <java-name>
				/// METADATA_KEY_PREFERENCES
				/// </java-name>
				[Dot42.DexImport("METADATA_KEY_PREFERENCES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string METADATA_KEY_PREFERENCES = "android.preference";
				/// <java-name>
				/// KEY_HAS_SET_DEFAULT_VALUES
				/// </java-name>
				[Dot42.DexImport("KEY_HAS_SET_DEFAULT_VALUES", "Ljava/lang/String;", AccessFlags = 25)]
				public const string KEY_HAS_SET_DEFAULT_VALUES = "_has_set_default_values";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PreferenceManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createPreferenceScreen
				/// </java-name>
				[Dot42.DexImport("createPreferenceScreen", "(Landroid/content/Context;)Landroid/preference/PreferenceScreen;", AccessFlags = 1)]
				public virtual global::Android.Preference.PreferenceScreen CreatePreferenceScreen(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.PreferenceScreen);
				}

				/// <summary>
				/// <para>Returns the current name of the SharedPreferences file that preferences managed by this will use.</para><para><para>Context::getSharedPreferences(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The name that can be passed to Context#getSharedPreferences(String, int). </para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferencesName
				/// </java-name>
				[Dot42.DexImport("getSharedPreferencesName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetSharedPreferencesName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Sets the name of the SharedPreferences file that preferences managed by this will use.</para><para><para>Context::getSharedPreferences(String, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSharedPreferencesName
				/// </java-name>
				[Dot42.DexImport("setSharedPreferencesName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSharedPreferencesName(string sharedPreferencesName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current mode of the SharedPreferences file that preferences managed by this will use.</para><para><para>Context::getSharedPreferences(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The mode that can be passed to Context#getSharedPreferences(String, int). </para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferencesMode
				/// </java-name>
				[Dot42.DexImport("getSharedPreferencesMode", "()I", AccessFlags = 1)]
				public virtual int GetSharedPreferencesMode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the mode of the SharedPreferences file that preferences managed by this will use.</para><para><para>Context::getSharedPreferences(String, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSharedPreferencesMode
				/// </java-name>
				[Dot42.DexImport("setSharedPreferencesMode", "(I)V", AccessFlags = 1)]
				public virtual void SetSharedPreferencesMode(int sharedPreferencesMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets a SharedPreferences instance that preferences managed by this will use.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A SharedPreferences instance pointing to the file that contains the values of preferences that are managed by this. </para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "()Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public virtual global::Android.Content.ISharedPreferences GetSharedPreferences() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <summary>
				/// <para>Gets a SharedPreferences instance that points to the default file that is used by the preference framework in the given context.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A SharedPreferences instance that can be used to retrieve and listen to values of the preferences. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getDefaultSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;", AccessFlags = 9)]
				public static global::Android.Content.ISharedPreferences GetDefaultSharedPreferences(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <summary>
				/// <para>Finds a Preference based on its key.</para><para><para>PreferenceGroup::findPreference(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Preference with the key, or null. </para>
				/// </returns>
				/// <java-name>
				/// findPreference
				/// </java-name>
				[Dot42.DexImport("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preference.Preference FindPreference(global::Java.Lang.ICharSequence key) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.Preference);
				}

				/// <summary>
				/// <para>Sets the default values from an XML preference file by reading the values defined by each Preference item's <c> android:defaultValue </c> attribute. This should be called by the application's main activity. </para><para>Note: this will NOT reset preferences back to their default values. For that functionality, use PreferenceManager#getDefaultSharedPreferences(Context) and clear it followed by a call to this method with this parameter set to true. </para>        
				/// </summary>
				/// <java-name>
				/// setDefaultValues
				/// </java-name>
				[Dot42.DexImport("setDefaultValues", "(Landroid/content/Context;IZ)V", AccessFlags = 9)]
				public static void SetDefaultValues(global::Android.Content.Context context, int resId, bool readAgain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Similar to setDefaultValues(Context, int, boolean) but allows the client to provide the filename and mode of the shared preferences file.</para><para>Note: this will NOT reset preferences back to their default values. For that functionality, use PreferenceManager#getDefaultSharedPreferences(Context) and clear it followed by a call to this method with this parameter set to true.</para><para><para>setDefaultValues(Context, int, boolean) </para><simplesectsep></simplesectsep><para>setSharedPreferencesName(String) </para><simplesectsep></simplesectsep><para>setSharedPreferencesMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultValues
				/// </java-name>
				[Dot42.DexImport("setDefaultValues", "(Landroid/content/Context;Ljava/lang/String;IIZ)V", AccessFlags = 9)]
				public static void SetDefaultValues(global::Android.Content.Context context, string sharedPreferencesName, int sharedPreferencesMode, int resId, bool readAgain) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the current name of the SharedPreferences file that preferences managed by this will use.</para><para><para>Context::getSharedPreferences(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The name that can be passed to Context#getSharedPreferences(String, int). </para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferencesName
				/// </java-name>
				public string SharedPreferencesName
				{
				[Dot42.DexImport("getSharedPreferencesName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSharedPreferencesName(); }
				[Dot42.DexImport("setSharedPreferencesName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetSharedPreferencesName(value); }
				}

				/// <summary>
				/// <para>Returns the current mode of the SharedPreferences file that preferences managed by this will use.</para><para><para>Context::getSharedPreferences(String, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The mode that can be passed to Context#getSharedPreferences(String, int). </para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferencesMode
				/// </java-name>
				public int SharedPreferencesMode
				{
				[Dot42.DexImport("getSharedPreferencesMode", "()I", AccessFlags = 1)]
						get{ return GetSharedPreferencesMode(); }
				[Dot42.DexImport("setSharedPreferencesMode", "(I)V", AccessFlags = 1)]
						set{ SetSharedPreferencesMode(value); }
				}

				/// <summary>
				/// <para>Gets a SharedPreferences instance that preferences managed by this will use.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A SharedPreferences instance pointing to the file that contains the values of preferences that are managed by this. </para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				public global::Android.Content.ISharedPreferences SharedPreferences
				{
				[Dot42.DexImport("getSharedPreferences", "()Landroid/content/SharedPreferences;", AccessFlags = 1)]
						get{ return GetSharedPreferences(); }
				}

				/// <summary>
				/// <para>Interface definition for a class that will be called when the container's activity is destroyed. </para>    
				/// </summary>
				/// <java-name>
				/// android/preference/PreferenceManager$OnActivityDestroyListener
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceManager$OnActivityDestroyListener", AccessFlags = 1545)]
				public partial interface IOnActivityDestroyListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>See Activity's onDestroy. </para>        
						/// </summary>
						/// <java-name>
						/// onActivityDestroy
						/// </java-name>
						[Dot42.DexImport("onActivityDestroy", "()V", AccessFlags = 1025)]
						void OnActivityDestroy() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Interface definition for a class that will be called when the container's activity is stopped. </para>    
				/// </summary>
				/// <java-name>
				/// android/preference/PreferenceManager$OnActivityStopListener
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceManager$OnActivityStopListener", AccessFlags = 1545)]
				public partial interface IOnActivityStopListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>See Activity's onStop. </para>        
						/// </summary>
						/// <java-name>
						/// onActivityStop
						/// </java-name>
						[Dot42.DexImport("onActivityStop", "()V", AccessFlags = 1025)]
						void OnActivityStop() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Interface definition for a class that will be called when the container's activity receives an activity result. </para>    
				/// </summary>
				/// <java-name>
				/// android/preference/PreferenceManager$OnActivityResultListener
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceManager$OnActivityResultListener", AccessFlags = 1545)]
				public partial interface IOnActivityResultListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>See Activity's onActivityResult.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>Whether the request code was handled (in which case subsequent listeners will not be called. </para>
						/// </returns>
						/// <java-name>
						/// onActivityResult
						/// </java-name>
						[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)Z", AccessFlags = 1025)]
						bool OnActivityResult(int requestCode, int resultCode, global::Android.Content.Intent data) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>Represents a top-level Preference that is the root of a Preference hierarchy. A PreferenceActivity points to an instance of this class to show the preferences. To instantiate this class, use PreferenceManager#createPreferenceScreen(Context). <ul><li></li></ul>class can appear in two places:  When a PreferenceActivity points to this, it is used as the root and is not shown (only the contained preferences are shown).  When it appears inside another preference hierarchy, it is shown and serves as the gateway to another screen of preferences (either by showing another screen of preferences as a Dialog or via a Context#startActivity(android.content.Intent) from the Preference#getIntent()). The children of this PreferenceScreen are NOT shown in the screen that this PreferenceScreen is shown in. Instead, a separate screen will be shown when this preference is clicked.  </para><para>Here's an example XML layout of a PreferenceScreen:</para><para><pre>
		/// &lt;PreferenceScreen
		///         xmlns:android="http://schemas.android.com/apk/res/android"
		///         android:key="first_preferencescreen"&gt;
		///     &lt;CheckBoxPreference
		///             android:key="wifi enabled"
		///             android:title="WiFi" /&gt;
		///     &lt;PreferenceScreen
		///             android:key="second_preferencescreen"
		///             android:title="WiFi settings"&gt;
		///         &lt;CheckBoxPreference
		///                 android:key="prefer wifi"
		///                 android:title="Prefer WiFi" /&gt;
		///         ... other preferences here ...
		///     &lt;/PreferenceScreen&gt;
		/// &lt;/PreferenceScreen&gt; </pre> </para><para>In this example, the "first_preferencescreen" will be used as the root of the hierarchy and given to a PreferenceActivity. The first screen will show preferences "WiFi" (which can be used to quickly enable/disable WiFi) and "WiFi settings". The "WiFi settings" is the "second_preferencescreen" and when clicked will show another screen of preferences such as "Prefer WiFi" (and the other preferences that are children of the "second_preferencescreen" tag).</para><para> <h3>Developer Guides</h3></para><para> </para><para>For information about building a settings UI with Preferences, read the  guide.</para><para> </para><para><para>PreferenceCategory </para></para>    
		/// </summary>
		/// <java-name>
		/// android/preference/PreferenceScreen
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceScreen", AccessFlags = 49)]
		public sealed partial class PreferenceScreen : global::Android.Preference.PreferenceGroup, global::Android.Widget.AdapterView<object>.IOnItemClickListener, global::Android.Content.IDialogInterface_IOnDismissListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PreferenceScreen() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an adapter that can be attached to a PreferenceActivity or PreferenceFragment to show the preferences contained in this PreferenceScreen. </para><para>This PreferenceScreen will NOT appear in the returned adapter, instead it appears in the hierarchy above this PreferenceScreen. </para><para>This adapter's Adapter#getItem(int) should always return a subclass of Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An adapter that provides the Preference contained in this PreferenceScreen. </para>
				/// </returns>
				/// <java-name>
				/// getRootAdapter
				/// </java-name>
				[Dot42.DexImport("getRootAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
				public global::Android.Widget.IListAdapter GetRootAdapter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.IListAdapter);
				}

				/// <summary>
				/// <para>Creates the root adapter.</para><para><para>getRootAdapter() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An adapter that contains the preferences contained in this PreferenceScreen. </para>
				/// </returns>
				/// <java-name>
				/// onCreateRootAdapter
				/// </java-name>
				[Dot42.DexImport("onCreateRootAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 4)]
				internal global::Android.Widget.IListAdapter OnCreateRootAdapter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.IListAdapter);
				}

				/// <summary>
				/// <para>Binds a ListView to the preferences contained in this PreferenceScreen via getRootAdapter(). It also handles passing list item clicks to the corresponding Preference contained by this PreferenceScreen.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Landroid/widget/ListView;)V", AccessFlags = 1)]
				public void Bind(global::Android.Widget.ListView listView) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Processes a click on the preference. This includes saving the value to the SharedPreferences. However, the overridden method should call callChangeListener(Object) to make sure the client wants to update the preference's state with the new value. </para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal override void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method will be invoked when the dialog is dismissed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public void OnDismiss(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Used to get a handle to the dialog. This is useful for cases where we want to manipulate the dialog as we would with any other activity or view. </para>        
				/// </summary>
				/// <java-name>
				/// getDialog
				/// </java-name>
				[Dot42.DexImport("getDialog", "()Landroid/app/Dialog;", AccessFlags = 1)]
				public global::Android.App.Dialog GetDialog() /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <java-name>
				/// onItemClick
				/// </java-name>
				[Dot42.DexImport("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", AccessFlags = 1)]
				public void OnItemClick(global::Android.Widget.AdapterView<object> parent, global::Android.View.View view, int position, long id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Whether this preference group should be shown on the same screen as its contained preferences.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the contained preferences should be shown on the same screen as this preference. </para>
				/// </returns>
				/// <java-name>
				/// isOnSameScreenAsChildren
				/// </java-name>
				[Dot42.DexImport("isOnSameScreenAsChildren", "()Z", AccessFlags = 4)]
				protected internal override bool IsOnSameScreenAsChildren() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Hook allowing a Preference to generate a representation of its internal state that can later be used to create a new instance with that same state. This state should only contain information that is not persistent or can be reconstructed later.</para><para><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>saveHierarchyState </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Parcelable object containing the current dynamic state of this Preference, or null if there is nothing interesting to save. The default implementation returns null. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.Os.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				/// <summary>
				/// <para>Hook allowing a Preference to re-apply a representation of its internal state that had previously been generated by onSaveInstanceState. This function will never be called with a null state.</para><para><para>onSaveInstanceState </para><simplesectsep></simplesectsep><para>restoreHierarchyState </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.Os.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an adapter that can be attached to a PreferenceActivity or PreferenceFragment to show the preferences contained in this PreferenceScreen. </para><para>This PreferenceScreen will NOT appear in the returned adapter, instead it appears in the hierarchy above this PreferenceScreen. </para><para>This adapter's Adapter#getItem(int) should always return a subclass of Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An adapter that provides the Preference contained in this PreferenceScreen. </para>
				/// </returns>
				/// <java-name>
				/// getRootAdapter
				/// </java-name>
				public global::Android.Widget.IListAdapter RootAdapter
				{
				[Dot42.DexImport("getRootAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return GetRootAdapter(); }
				}

				/// <summary>
				/// <para>Used to get a handle to the dialog. This is useful for cases where we want to manipulate the dialog as we would with any other activity or view. </para>        
				/// </summary>
				/// <java-name>
				/// getDialog
				/// </java-name>
				public global::Android.App.Dialog Dialog
				{
				[Dot42.DexImport("getDialog", "()Landroid/app/Dialog;", AccessFlags = 1)]
						get{ return GetDialog(); }
				}

		}

		/// <summary>
		/// <para>Used to group Preference objects and provide a disabled title above the group.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For information about building a settings UI with Preferences, read the  guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/PreferenceCategory
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceCategory", AccessFlags = 33)]
		public partial class PreferenceCategory : global::Android.Preference.PreferenceGroup
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public PreferenceCategory(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public PreferenceCategory(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public PreferenceCategory(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Prepares a Preference to be added to the group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether to allow adding the preference (true), or not (false). </para>
				/// </returns>
				/// <java-name>
				/// onPrepareAddPreference
				/// </java-name>
				[Dot42.DexImport("onPrepareAddPreference", "(Landroid/preference/Preference;)Z", AccessFlags = 4)]
				protected internal override bool OnPrepareAddPreference(global::Android.Preference.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether this Preference should be enabled in the list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this Preference is enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public override bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PreferenceCategory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>This is the base class for an activity to show a hierarchy of preferences to the user. Prior to android.os.Build.VERSION_CODES#HONEYCOMB this class only allowed the display of a single set of preference; this functionality should now be found in the new PreferenceFragment class. If you are using PreferenceActivity in its old mode, the documentation there applies to the deprecated APIs here.</para><para>This activity shows one or more headers of preferences, each of which is associated with a PreferenceFragment to display the preferences of that header. The actual layout and display of these associations can however vary; currently there are two major approaches it may take:</para><para><ul><li><para>On a small screen it may display only the headers as a single list when first launched. Selecting one of the header items will re-launch the activity with it only showing the PreferenceFragment of that header. </para></li><li><para>On a large screen in may display both the headers and current PreferenceFragment together as panes. Selecting a header item switches to showing the correct PreferenceFragment for that item. </para></li></ul></para><para>Subclasses of PreferenceActivity should implement onBuildHeaders to populate the header list with the desired items. Doing this implicitly switches the class into its new "headers   + fragments" mode rather than the old style of just showing a single preferences list.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For information about using <c> PreferenceActivity </c> , read the  guide.</para><para> </para><para> <h3>Sample Code</h3></para><para>The following sample code shows a simple preference activity that has two different sets of preferences. The implementation, consisting of the activity itself as well as its two preference fragments is:</para><para>{ development/samples/ApiDemos/src/com/example/android/apis/preference/PreferenceWithHeaders.java activity}</para><para>The preference_headers resource describes the headers to be displayed and the fragments associated with them. It is:</para><para>{ development/samples/ApiDemos/res/xml/preference_headers.xml headers}</para><para>The first header is shown by Prefs1Fragment, which populates itself from the following XML resource:</para><para>{ development/samples/ApiDemos/res/xml/fragmented_preferences.xml preferences}</para><para>Note that this XML resource contains a preference screen holding another fragment, the Prefs1FragmentInner implemented here. This allows the user to traverse down a hierarchy of preferences; pressing back will pop each fragment off the stack to return to the previous preferences.</para><para>See PreferenceFragment for information on implementing the fragments themselves. </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/PreferenceActivity
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceActivity", AccessFlags = 1057)]
		public abstract partial class PreferenceActivity : global::Android.App.ListActivity, global::Android.Preference.PreferenceFragment.IOnPreferenceStartFragmentCallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>When starting this activity, the invoking Intent can contain this extra string to specify which fragment should be initially displayed. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHOW_FRAGMENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_FRAGMENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_FRAGMENT = ":android:show_fragment";
				/// <summary>
				/// <para>When starting this activity and using EXTRA_SHOW_FRAGMENT, this extra can also be specified to supply a Bundle of arguments to pass to that fragment when it is instantiated during the initial creation of PreferenceActivity. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHOW_FRAGMENT_ARGUMENTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_FRAGMENT_ARGUMENTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_FRAGMENT_ARGUMENTS = ":android:show_fragment_args";
				/// <summary>
				/// <para>When starting this activity and using EXTRA_SHOW_FRAGMENT, this extra can also be specify to supply the title to be shown for that fragment. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHOW_FRAGMENT_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_FRAGMENT_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_FRAGMENT_TITLE = ":android:show_fragment_title";
				/// <summary>
				/// <para>When starting this activity and using EXTRA_SHOW_FRAGMENT, this extra can also be specify to supply the short title to be shown for that fragment. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_SHOW_FRAGMENT_SHORT_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_FRAGMENT_SHORT_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_FRAGMENT_SHORT_TITLE = ":android:show_fragment_short_title";
				/// <summary>
				/// <para>When starting this activity, the invoking Intent can contain this extra boolean that the header list should not be displayed. This is most often used in conjunction with EXTRA_SHOW_FRAGMENT to launch the activity to display a specific fragment that the user has navigated to. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_NO_HEADERS
				/// </java-name>
				[Dot42.DexImport("EXTRA_NO_HEADERS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NO_HEADERS = ":android:no_headers";
				/// <summary>
				/// <para>Default value for Header.id indicating that no identifier value is set. All other values (including those below -1) are valid. </para>        
				/// </summary>
				/// <java-name>
				/// HEADER_ID_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("HEADER_ID_UNDEFINED", "J", AccessFlags = 25)]
				public const long HEADER_ID_UNDEFINED = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PreferenceActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the activity is starting. This is where most initialization should go: calling setContentView(int) to inflate the activity's UI, using findViewById to programmatically interact with widgets in the UI, calling managedQuery(android.net.Uri , String[], String, String[], String) to retrieve cursors for data being displayed, etc.</para><para>You can call finish from within this function, in which case onDestroy() will be immediately called without any of the rest of the activity lifecycle (onStart, onResume, onPause, etc) executing.</para><para><b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para><para><para>onStart </para><simplesectsep></simplesectsep><para>onSaveInstanceState </para><simplesectsep></simplesectsep><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>onPostCreate </para></para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.Os.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if this activity is currently showing the header list. </para>        
				/// </summary>
				/// <java-name>
				/// hasHeaders
				/// </java-name>
				[Dot42.DexImport("hasHeaders", "()Z", AccessFlags = 1)]
				public virtual bool HasHeaders() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this activity is showing multiple panes  the headers and a preference fragment. </para>        
				/// </summary>
				/// <java-name>
				/// isMultiPane
				/// </java-name>
				[Dot42.DexImport("isMultiPane", "()Z", AccessFlags = 1)]
				public virtual bool IsMultiPane() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called to determine if the activity should run in multi-pane mode. The default implementation returns true if the screen is large enough. </para>        
				/// </summary>
				/// <java-name>
				/// onIsMultiPane
				/// </java-name>
				[Dot42.DexImport("onIsMultiPane", "()Z", AccessFlags = 1)]
				public virtual bool OnIsMultiPane() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called to determine whether the header list should be hidden. The default implementation returns the value given in EXTRA_NO_HEADERS or false if it is not supplied. This is set to false, for example, when the activity is being re-launched to show a particular preference activity. </para>        
				/// </summary>
				/// <java-name>
				/// onIsHidingHeaders
				/// </java-name>
				[Dot42.DexImport("onIsHidingHeaders", "()Z", AccessFlags = 1)]
				public virtual bool OnIsHidingHeaders() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called to determine the initial header to be shown. The default implementation simply returns the fragment of the first header. Note that the returned Header object does not actually need to exist in your header list  whatever its fragment is will simply be used to show for the initial UI. </para>        
				/// </summary>
				/// <java-name>
				/// onGetInitialHeader
				/// </java-name>
				[Dot42.DexImport("onGetInitialHeader", "()Landroid/preference/PreferenceActivity$Header;", AccessFlags = 1)]
				public virtual global::Android.Preference.PreferenceActivity.Header OnGetInitialHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.PreferenceActivity.Header);
				}

				/// <summary>
				/// <para>Called after the header list has been updated (onBuildHeaders has been called and returned due to invalidateHeaders()) to specify the header that should now be selected. The default implementation returns null to keep whatever header is currently selected. </para>        
				/// </summary>
				/// <java-name>
				/// onGetNewHeader
				/// </java-name>
				[Dot42.DexImport("onGetNewHeader", "()Landroid/preference/PreferenceActivity$Header;", AccessFlags = 1)]
				public virtual global::Android.Preference.PreferenceActivity.Header OnGetNewHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.PreferenceActivity.Header);
				}

				/// <summary>
				/// <para>Called when the activity needs its list of headers build. By implementing this and adding at least one item to the list, you will cause the activity to run in its modern fragment mode. Note that this function may not always be called; for example, if the activity has been asked to display a particular fragment without the header list, there is no need to build the headers.</para><para>Typical implementations will use loadHeadersFromResource to fill in the list from a resource.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onBuildHeaders
				/// </java-name>
				[Dot42.DexImport("onBuildHeaders", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/preference/PreferenceActivity$Header;>;)V")]
				public virtual void OnBuildHeaders(global::Java.Util.IList<global::Android.Preference.PreferenceActivity.Header> target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Call when you need to change the headers being displayed. Will result in onBuildHeaders() later being called to retrieve the new list. </para>        
				/// </summary>
				/// <java-name>
				/// invalidateHeaders
				/// </java-name>
				[Dot42.DexImport("invalidateHeaders", "()V", AccessFlags = 1)]
				public virtual void InvalidateHeaders() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Parse the given XML file as a header description, adding each parsed Header into the target list.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadHeadersFromResource
				/// </java-name>
				[Dot42.DexImport("loadHeadersFromResource", "(ILjava/util/List;)V", AccessFlags = 1, Signature = "(ILjava/util/List<Landroid/preference/PreferenceActivity$Header;>;)V")]
				public virtual void LoadHeadersFromResource(int resid, global::Java.Util.IList<global::Android.Preference.PreferenceActivity.Header> target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set a footer that should be shown at the bottom of the header list. </para>        
				/// </summary>
				/// <java-name>
				/// setListFooter
				/// </java-name>
				[Dot42.DexImport("setListFooter", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetListFooter(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when you are no longer visible to the user. You will next receive either onRestart, onDestroy, or nothing, depending on later user activity.</para><para>Note that this method may never be called, in low memory situations where the system does not have enough memory to keep your activity's process running after its onPause method is called.</para><para><b>Derived classes must call through to the super class's implementation of this method. If they do not, an exception will be thrown.</b></para><para><para>onRestart </para><simplesectsep></simplesectsep><para>onResume </para><simplesectsep></simplesectsep><para>onSaveInstanceState </para><simplesectsep></simplesectsep><para>onDestroy </para></para>        
				/// </summary>
				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Activity::onDestroy() </para></para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 4)]
				protected internal override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called to retrieve per-instance state from an activity before being killed so that the state can be restored in onCreate or onRestoreInstanceState (the Bundle populated by this method will be passed to both).</para><para>This method is called before an activity may be killed so that when it comes back some time in the future it can restore its state. For example, if activity B is launched in front of activity A, and at some point activity A is killed to reclaim resources, activity A will have a chance to save the current state of its user interface via this method so that when the user returns to activity A, the state of the user interface can be restored via onCreate or onRestoreInstanceState.</para><para>Do not confuse this method with activity lifecycle callbacks such as onPause, which is always called when an activity is being placed in the background or on its way to destruction, or onStop which is called before destruction. One example of when onPause and onStop is called and not this method is when a user navigates back from activity B to activity A: there is no need to call onSaveInstanceState on B because that particular instance will never be restored, so the system avoids calling it. An example when onPause is called and not onSaveInstanceState is when activity B is launched in front of activity A: the system may avoid calling onSaveInstanceState on activity A if it isn't killed during the lifetime of B since the state of the user interface of A will stay intact.</para><para>The default implementation takes care of most of the UI per-instance state for you by calling android.view.View#onSaveInstanceState() on each view in the hierarchy that has an id, and by saving the id of the currently focused view (all of which is restored by the default implementation of onRestoreInstanceState). If you override this method to save additional information not captured by each individual view, you will likely want to call through to the default implementation, otherwise be prepared to save all of the state of each view yourself.</para><para>If called, this method will occur before onStop. There are no guarantees about whether it will occur before or after onPause.</para><para><para>onCreate </para><simplesectsep></simplesectsep><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>onPause </para></para>        
				/// </summary>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnSaveInstanceState(global::Android.Os.Bundle outState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Ensures the list view has been created before Activity restores all of the view states.</para><para><para>Activity::onRestoreInstanceState(Bundle) </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.Os.Bundle state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when an activity you launched exits, giving you the requestCode you started it with, the resultCode it returned, and any additional data from it. The <b>resultCode</b> will be RESULT_CANCELED if the activity explicitly returned that, didn't return any result, or crashed during its operation.</para><para>You will receive this call immediately before onResume() when your activity is re-starting.</para><para><para>startActivityForResult </para><simplesectsep></simplesectsep><para>createPendingResult </para><simplesectsep></simplesectsep><para>setResult(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)V", AccessFlags = 4)]
				protected internal override void OnActivityResult(int requestCode, int resultCode, global::Android.Content.Intent data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Updates the screen state (current list and other views) when the content changes.</para><para><para>Activity::onContentChanged() </para></para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public override void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method will be called when an item in the list is selected. Subclasses should override. Subclasses can call getListView().getItemAtPosition(position) if they need to access the data associated with the selected item.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onListItemClick
				/// </java-name>
				[Dot42.DexImport("onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", AccessFlags = 4)]
				protected internal override void OnListItemClick(global::Android.Widget.ListView l, global::Android.View.View v, int position, long id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the user selects an item in the header list. The default implementation will call either startWithFragment(String, Bundle, Fragment, int, int, int) or switchToHeader(Header) as appropriate.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onHeaderClick
				/// </java-name>
				[Dot42.DexImport("onHeaderClick", "(Landroid/preference/PreferenceActivity$Header;I)V", AccessFlags = 1)]
				public virtual void OnHeaderClick(global::Android.Preference.PreferenceActivity.Header header, int position) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by startWithFragment(String, Bundle, Fragment, int, int, int) when in single-pane mode, to build an Intent to launch a new activity showing the selected fragment. The default implementation constructs an Intent that re-launches the current activity with the appropriate arguments to display the fragment.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns an Intent that can be launched to display the given fragment. </para>
				/// </returns>
				/// <java-name>
				/// onBuildStartFragmentIntent
				/// </java-name>
				[Dot42.DexImport("onBuildStartFragmentIntent", "(Ljava/lang/String;Landroid/os/Bundle;II)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent OnBuildStartFragmentIntent(string fragmentName, global::Android.Os.Bundle args, int titleRes, int shortTitleRes) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				/// <para>Like startWithFragment(String, Bundle, Fragment, int, int, int) but uses a 0 titleRes. </para>        
				/// </summary>
				/// <java-name>
				/// startWithFragment
				/// </java-name>
				[Dot42.DexImport("startWithFragment", "(Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Fragment;I)V", AccessFlags = 1)]
				public virtual void StartWithFragment(string fragmentName, global::Android.Os.Bundle args, global::Android.App.Fragment resultTo, int resultRequestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Start a new instance of this activity, showing only the given preference fragment. When launched in this mode, the header list will be hidden and the given preference fragment will be instantiated and fill the entire activity.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startWithFragment
				/// </java-name>
				[Dot42.DexImport("startWithFragment", "(Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Fragment;III)V", AccessFlags = 1)]
				public virtual void StartWithFragment(string fragmentName, global::Android.Os.Bundle args, global::Android.App.Fragment resultTo, int resultRequestCode, int titleRes, int shortTitleRes) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Change the base title of the bread crumbs for the current preferences. This will normally be called for you. See android.app.FragmentBreadCrumbs for more information. </para>        
				/// </summary>
				/// <java-name>
				/// showBreadCrumbs
				/// </java-name>
				[Dot42.DexImport("showBreadCrumbs", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void ShowBreadCrumbs(global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence shortTitle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Should be called after onCreate to ensure that the breadcrumbs, if any, were created. This prepends a title to the fragment breadcrumbs and attaches a listener to any clicks on the parent entry. </para>        
				/// </summary>
				/// <java-name>
				/// setParentTitle
				/// </java-name>
				[Dot42.DexImport("setParentTitle", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/view/View$OnClickListen" +
    "er;)V", AccessFlags = 1)]
				public virtual void SetParentTitle(global::Java.Lang.ICharSequence title, global::Java.Lang.ICharSequence shortTitle, global::Android.View.View.IOnClickListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>When in two-pane mode, switch the fragment pane to show the given preference fragment.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// switchToHeader
				/// </java-name>
				[Dot42.DexImport("switchToHeader", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SwitchToHeader(string fragmentName, global::Android.Os.Bundle args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>When in two-pane mode, switch to the fragment pane to show the given preference fragment.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// switchToHeader
				/// </java-name>
				[Dot42.DexImport("switchToHeader", "(Landroid/preference/PreferenceActivity$Header;)V", AccessFlags = 1)]
				public virtual void SwitchToHeader(global::Android.Preference.PreferenceActivity.Header header) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Start a new fragment.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startPreferenceFragment
				/// </java-name>
				[Dot42.DexImport("startPreferenceFragment", "(Landroid/app/Fragment;Z)V", AccessFlags = 1)]
				public virtual void StartPreferenceFragment(global::Android.App.Fragment fragment, bool push) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Start a new fragment containing a preference panel. If the prefences are being displayed in multi-pane mode, the given fragment class will be instantiated and placed in the appropriate pane. If running in single-pane mode, a new activity will be launched in which to show the fragment.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// startPreferencePanel
				/// </java-name>
				[Dot42.DexImport("startPreferencePanel", "(Ljava/lang/String;Landroid/os/Bundle;ILjava/lang/CharSequence;Landroid/app/Fragm" +
    "ent;I)V", AccessFlags = 1)]
				public virtual void StartPreferencePanel(string fragmentClass, global::Android.Os.Bundle args, int titleRes, global::Java.Lang.ICharSequence titleText, global::Android.App.Fragment resultTo, int resultRequestCode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by a preference panel fragment to finish itself.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// finishPreferencePanel
				/// </java-name>
				[Dot42.DexImport("finishPreferencePanel", "(Landroid/app/Fragment;ILandroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void FinishPreferencePanel(global::Android.App.Fragment caller, int resultCode, global::Android.Content.Intent resultData) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the user has clicked on a Preference that has a fragment class name associated with it. The implementation to should instantiate and switch to an instance of the given fragment. </para>        
				/// </summary>
				/// <java-name>
				/// onPreferenceStartFragment
				/// </java-name>
				[Dot42.DexImport("onPreferenceStartFragment", "(Landroid/preference/PreferenceFragment;Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool OnPreferenceStartFragment(global::Android.Preference.PreferenceFragment caller, global::Android.Preference.Preference pref) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the PreferenceManager used by this activity. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceManager.</para>
				/// </returns>
				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
				public virtual global::Android.Preference.PreferenceManager GetPreferenceManager() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.PreferenceManager);
				}

				/// <summary>
				/// <para>Sets the root of the preference hierarchy that this activity is showing.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setPreferenceScreen
				/// </java-name>
				[Dot42.DexImport("setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", AccessFlags = 1)]
				public virtual void SetPreferenceScreen(global::Android.Preference.PreferenceScreen preferenceScreen) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the root of the preference hierarchy that this activity is showing.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceScreen that is the root of the preference hierarchy.</para>
				/// </returns>
				/// <java-name>
				/// getPreferenceScreen
				/// </java-name>
				[Dot42.DexImport("getPreferenceScreen", "()Landroid/preference/PreferenceScreen;", AccessFlags = 1)]
				public virtual global::Android.Preference.PreferenceScreen GetPreferenceScreen() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.PreferenceScreen);
				}

				/// <summary>
				/// <para>Adds preferences from activities that match the given Intent.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// addPreferencesFromIntent
				/// </java-name>
				[Dot42.DexImport("addPreferencesFromIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void AddPreferencesFromIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflates the given XML resource and adds the preference hierarchy to the current preference hierarchy.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// addPreferencesFromResource
				/// </java-name>
				[Dot42.DexImport("addPreferencesFromResource", "(I)V", AccessFlags = 1)]
				public virtual void AddPreferencesFromResource(int preferencesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// onPreferenceTreeClick
				/// </java-name>
				[Dot42.DexImport("onPreferenceTreeClick", "(Landroid/preference/PreferenceScreen;Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool OnPreferenceTreeClick(global::Android.Preference.PreferenceScreen preferenceScreen, global::Android.Preference.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Finds a Preference based on its key.</para><para><para>PreferenceGroup::findPreference(CharSequence)</para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>The Preference with the key, or null. </para>
				/// </returns>
				/// <java-name>
				/// findPreference
				/// </java-name>
				[Dot42.DexImport("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preference.Preference FindPreference(global::Java.Lang.ICharSequence key) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.Preference);
				}

				/// <summary>
				/// <para>This is called for activities that set launchMode to "singleTop" in their package, or if a client used the Intent#FLAG_ACTIVITY_SINGLE_TOP flag when calling startActivity. In either case, when the activity is re-launched while at the top of the activity stack instead of a new instance of the activity being started, onNewIntent() will be called on the existing instance with the Intent that was used to re-launch it.</para><para>An activity will always be paused before receiving a new intent, so you can count on onResume being called after this method.</para><para>Note that getIntent still returns the original Intent. You can use setIntent to update it to this new Intent.</para><para><para>getIntent </para><simplesectsep></simplesectsep><para>setIntent </para><simplesectsep></simplesectsep><para>onResume </para></para>        
				/// </summary>
				/// <java-name>
				/// onNewIntent
				/// </java-name>
				[Dot42.DexImport("onNewIntent", "(Landroid/content/Intent;)V", AccessFlags = 4)]
				protected internal override void OnNewIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the PreferenceManager used by this activity. <xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceManager.</para>
				/// </returns>
				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				public global::Android.Preference.PreferenceManager PreferenceManager
				{
				[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
						get{ return GetPreferenceManager(); }
				}

				/// <summary>
				/// <para>Gets the root of the preference hierarchy that this activity is showing.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>This function is not relevant for a modern fragment-based PreferenceActivity. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceScreen that is the root of the preference hierarchy.</para>
				/// </returns>
				/// <java-name>
				/// getPreferenceScreen
				/// </java-name>
				public global::Android.Preference.PreferenceScreen PreferenceScreen
				{
				[Dot42.DexImport("getPreferenceScreen", "()Landroid/preference/PreferenceScreen;", AccessFlags = 1)]
						get{ return GetPreferenceScreen(); }
				[Dot42.DexImport("setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", AccessFlags = 1)]
						set{ SetPreferenceScreen(value); }
				}

				/// <summary>
				/// <para>Description of a single Header item that the user can select. </para>    
				/// </summary>
				/// <java-name>
				/// android/preference/PreferenceActivity$Header
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceActivity$Header", AccessFlags = 25)]
				public sealed partial class Header : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Identifier for this header, to correlate with a new list when it is updated. The default value is PreferenceActivity#HEADER_ID_UNDEFINED, meaning no id.  ref android.R.styleable::PreferenceHeader_id </para>        
						/// </summary>
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "J", AccessFlags = 1)]
						public long Id;
						/// <summary>
						/// <para>Resource ID of title of the header that is shown to the user.  ref android.R.styleable::PreferenceHeader_title </para>        
						/// </summary>
						/// <java-name>
						/// titleRes
						/// </java-name>
						[Dot42.DexImport("titleRes", "I", AccessFlags = 1)]
						public int TitleRes;
						/// <summary>
						/// <para>Title of the header that is shown to the user.  ref android.R.styleable::PreferenceHeader_title </para>        
						/// </summary>
						/// <java-name>
						/// title
						/// </java-name>
						[Dot42.DexImport("title", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Title;
						/// <summary>
						/// <para>Resource ID of optional summary describing what this header controls.  ref android.R.styleable::PreferenceHeader_summary </para>        
						/// </summary>
						/// <java-name>
						/// summaryRes
						/// </java-name>
						[Dot42.DexImport("summaryRes", "I", AccessFlags = 1)]
						public int SummaryRes;
						/// <summary>
						/// <para>Optional summary describing what this header controls.  ref android.R.styleable::PreferenceHeader_summary </para>        
						/// </summary>
						/// <java-name>
						/// summary
						/// </java-name>
						[Dot42.DexImport("summary", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Summary;
						/// <summary>
						/// <para>Resource ID of optional text to show as the title in the bread crumb.  ref android.R.styleable::PreferenceHeader_breadCrumbTitle </para>        
						/// </summary>
						/// <java-name>
						/// breadCrumbTitleRes
						/// </java-name>
						[Dot42.DexImport("breadCrumbTitleRes", "I", AccessFlags = 1)]
						public int BreadCrumbTitleRes;
						/// <summary>
						/// <para>Optional text to show as the title in the bread crumb.  ref android.R.styleable::PreferenceHeader_breadCrumbTitle </para>        
						/// </summary>
						/// <java-name>
						/// breadCrumbTitle
						/// </java-name>
						[Dot42.DexImport("breadCrumbTitle", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence BreadCrumbTitle;
						/// <summary>
						/// <para>Resource ID of optional text to show as the short title in the bread crumb.  ref android.R.styleable::PreferenceHeader_breadCrumbShortTitle </para>        
						/// </summary>
						/// <java-name>
						/// breadCrumbShortTitleRes
						/// </java-name>
						[Dot42.DexImport("breadCrumbShortTitleRes", "I", AccessFlags = 1)]
						public int BreadCrumbShortTitleRes;
						/// <summary>
						/// <para>Optional text to show as the short title in the bread crumb.  ref android.R.styleable::PreferenceHeader_breadCrumbShortTitle </para>        
						/// </summary>
						/// <java-name>
						/// breadCrumbShortTitle
						/// </java-name>
						[Dot42.DexImport("breadCrumbShortTitle", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence BreadCrumbShortTitle;
						/// <summary>
						/// <para>Optional icon resource to show for this header.  ref android.R.styleable::PreferenceHeader_icon </para>        
						/// </summary>
						/// <java-name>
						/// iconRes
						/// </java-name>
						[Dot42.DexImport("iconRes", "I", AccessFlags = 1)]
						public int IconRes;
						/// <summary>
						/// <para>Full class name of the fragment to display when this header is selected.  ref android.R.styleable::PreferenceHeader_fragment </para>        
						/// </summary>
						/// <java-name>
						/// fragment
						/// </java-name>
						[Dot42.DexImport("fragment", "Ljava/lang/String;", AccessFlags = 1)]
						public string Fragment;
						/// <summary>
						/// <para>Optional arguments to supply to the fragment when it is instantiated. </para>        
						/// </summary>
						/// <java-name>
						/// fragmentArguments
						/// </java-name>
						[Dot42.DexImport("fragmentArguments", "Landroid/os/Bundle;", AccessFlags = 1)]
						public global::Android.Os.Bundle FragmentArguments;
						/// <summary>
						/// <para>Intent to launch when the preference is selected. </para>        
						/// </summary>
						/// <java-name>
						/// intent
						/// </java-name>
						[Dot42.DexImport("intent", "Landroid/content/Intent;", AccessFlags = 1)]
						public global::Android.Content.Intent Intent;
						/// <summary>
						/// <para>Optional additional data for use by subclasses of PreferenceActivity. </para>        
						/// </summary>
						/// <java-name>
						/// extras
						/// </java-name>
						[Dot42.DexImport("extras", "Landroid/os/Bundle;", AccessFlags = 1)]
						public global::Android.Os.Bundle Extras;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.Os.IParcelable_ICreator<Header> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Header() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						/// <para>Return the currently set title. If titleRes is set, this resource is loaded from <b>res</b> and returned. Otherwise title is returned. </para>        
						/// </summary>
						/// <java-name>
						/// getTitle
						/// </java-name>
						[Dot42.DexImport("getTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence GetTitle(global::Android.Content.Res.Resources res) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <summary>
						/// <para>Return the currently set summary. If summaryRes is set, this resource is loaded from <b>res</b> and returned. Otherwise summary is returned. </para>        
						/// </summary>
						/// <java-name>
						/// getSummary
						/// </java-name>
						[Dot42.DexImport("getSummary", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence GetSummary(global::Android.Content.Res.Resources res) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <summary>
						/// <para>Return the currently set bread crumb title. If breadCrumbTitleRes is set, this resource is loaded from <b>res</b> and returned. Otherwise breadCrumbTitle is returned. </para>        
						/// </summary>
						/// <java-name>
						/// getBreadCrumbTitle
						/// </java-name>
						[Dot42.DexImport("getBreadCrumbTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence GetBreadCrumbTitle(global::Android.Content.Res.Resources res) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <summary>
						/// <para>Return the currently set bread crumb short title. If breadCrumbShortTitleRes is set, this resource is loaded from <b>res</b> and returned. Otherwise breadCrumbShortTitle is returned. </para>        
						/// </summary>
						/// <java-name>
						/// getBreadCrumbShortTitle
						/// </java-name>
						[Dot42.DexImport("getBreadCrumbShortTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence GetBreadCrumbShortTitle(global::Android.Content.Res.Resources res) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <summary>
						/// <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
						/// </returns>
						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						/// <para>Flatten this object in to a Parcel.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public void ReadFromParcel(global::Android.Os.Parcel @in) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		/// <para>A Preference that displays a list of entries as a dialog. </para><para>This preference will store a string into the SharedPreferences. This string will be the value from the setEntryValues(CharSequence[]) array.</para><para>ref android.R.styleable::ListPreference_entries  ref android.R.styleable::ListPreference_entryValues </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/ListPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/ListPreference", AccessFlags = 33)]
		public partial class ListPreference : global::Android.Preference.DialogPreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ListPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ListPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setEntries(CharSequence[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntries
				/// </java-name>
				[Dot42.DexImport("setEntries", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetEntries(global::Java.Lang.ICharSequence[] entriesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setEntries(CharSequence[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntries
				/// </java-name>
				[Dot42.DexImport("setEntries", "(I)V", AccessFlags = 1)]
				public virtual void SetEntries(int entriesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The list of entries to be shown in the list in subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The list as an array. </para>
				/// </returns>
				/// <java-name>
				/// getEntries
				/// </java-name>
				[Dot42.DexImport("getEntries", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetEntries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				/// <para><para>setEntryValues(CharSequence[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntryValues
				/// </java-name>
				[Dot42.DexImport("setEntryValues", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetEntryValues(global::Java.Lang.ICharSequence[] entryValuesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setEntryValues(CharSequence[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntryValues
				/// </java-name>
				[Dot42.DexImport("setEntryValues", "(I)V", AccessFlags = 1)]
				public virtual void SetEntryValues(int entryValuesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the array of values to be saved for the preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The array of values. </para>
				/// </returns>
				/// <java-name>
				/// getEntryValues
				/// </java-name>
				[Dot42.DexImport("getEntryValues", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetEntryValues() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				/// <para>Sets the value of the key. This should be one of the entries in getEntryValues().</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValue
				/// </java-name>
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetValue(string value) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the summary of this ListPreference. If the summary has a  java.lang.String::format String formatting} marker in it (i.e. "%s" or "%1$s"), then the current entry value will be substituted in its place.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the summary with appropriate string substitution </para>
				/// </returns>
				/// <java-name>
				/// getSummary
				/// </java-name>
				[Dot42.DexImport("getSummary", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence GetSummary() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the summary for this Preference with a CharSequence. If the summary has a  java.lang.String::format String formatting} marker in it (i.e. "%s" or "%1$s"), then the current entry value will be substituted in its place when it's retrieved.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSummary
				/// </java-name>
				[Dot42.DexImport("setSummary", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public override void SetSummary(global::Java.Lang.ICharSequence summary) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the value to the given index from the entry values.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValueIndex
				/// </java-name>
				[Dot42.DexImport("setValueIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetValueIndex(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the value of the key. This should be one of the entries in getEntryValues().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of the key. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Returns the entry corresponding to the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The entry corresponding to the current value, or null. </para>
				/// </returns>
				/// <java-name>
				/// getEntry
				/// </java-name>
				[Dot42.DexImport("getEntry", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetEntry() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Returns the index of the given value (in the entry values array).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The index of the value, or -1 if not found. </para>
				/// </returns>
				/// <java-name>
				/// findIndexOfValue
				/// </java-name>
				[Dot42.DexImport("findIndexOfValue", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int FindIndexOfValue(string value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onPrepareDialogBuilder
				/// </java-name>
				[Dot42.DexImport("onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V", AccessFlags = 4)]
				protected internal override void OnPrepareDialogBuilder(global::Android.App.AlertDialog.Builder builder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the dialog is dismissed and should be used to save data to the SharedPreferences.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDialogClosed
				/// </java-name>
				[Dot42.DexImport("onDialogClosed", "(Z)V", AccessFlags = 4)]
				protected internal override void OnDialogClosed(bool positiveResult) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when a Preference is being inflated and the default value attribute needs to be read. Since different Preference types have different value types, the subclass should get and return the default value which will be its value type. </para><para>For example, if the value type is String, the body of the method would proxy to TypedArray#getString(int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The default value of this preference type. </para>
				/// </returns>
				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray a, int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Implement this to set the initial value of the Preference. </para><para>If <b>restorePersistedValue</b> is true, you should restore the Preference value from the android.content.SharedPreferences. If <b>restorePersistedValue</b> is false, you should set the Preference value to defaultValue that is given (and possibly store to SharedPreferences if shouldPersist() is true). </para><para>This may not always be called. One example is if it should not persist but there is no default value given.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool restorePersistedValue, object defaultValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Hook allowing a Preference to generate a representation of its internal state that can later be used to create a new instance with that same state. This state should only contain information that is not persistent or can be reconstructed later.</para><para><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>saveHierarchyState </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Parcelable object containing the current dynamic state of this Preference, or null if there is nothing interesting to save. The default implementation returns null. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.Os.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				/// <summary>
				/// <para>Hook allowing a Preference to re-apply a representation of its internal state that had previously been generated by onSaveInstanceState. This function will never be called with a null state.</para><para><para>onSaveInstanceState </para><simplesectsep></simplesectsep><para>restoreHierarchyState </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.Os.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ListPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>The list of entries to be shown in the list in subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The list as an array. </para>
				/// </returns>
				/// <java-name>
				/// getEntries
				/// </java-name>
				public global::Java.Lang.ICharSequence[] Entries
				{
				[Dot42.DexImport("getEntries", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetEntries(); }
				[Dot42.DexImport("setEntries", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetEntries(value); }
				}

				/// <summary>
				/// <para>Returns the array of values to be saved for the preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The array of values. </para>
				/// </returns>
				/// <java-name>
				/// getEntryValues
				/// </java-name>
				public global::Java.Lang.ICharSequence[] EntryValues
				{
				[Dot42.DexImport("getEntryValues", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetEntryValues(); }
				[Dot42.DexImport("setEntryValues", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetEntryValues(value); }
				}

				/// <summary>
				/// <para>Returns the summary of this ListPreference. If the summary has a  java.lang.String::format String formatting} marker in it (i.e. "%s" or "%1$s"), then the current entry value will be substituted in its place.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the summary with appropriate string substitution </para>
				/// </returns>
				/// <java-name>
				/// getSummary
				/// </java-name>
				public global::Java.Lang.ICharSequence Summary
				{
				[Dot42.DexImport("getSummary", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetSummary(); }
				[Dot42.DexImport("setSummary", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetSummary(value); }
				}

				/// <summary>
				/// <para>Returns the value of the key. This should be one of the entries in getEntryValues().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value of the key. </para>
				/// </returns>
				/// <java-name>
				/// getValue
				/// </java-name>
				public string Value
				{
				[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetValue(); }
				[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetValue(value); }
				}

				/// <summary>
				/// <para>Returns the entry corresponding to the current value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The entry corresponding to the current value, or null. </para>
				/// </returns>
				/// <java-name>
				/// getEntry
				/// </java-name>
				public global::Java.Lang.ICharSequence Entry
				{
				[Dot42.DexImport("getEntry", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetEntry(); }
				}

		}

		/// <summary>
		/// <para>A Preference that provides checkbox widget functionality. </para><para>This preference will store a boolean into the SharedPreferences.</para><para>ref android.R.styleable::CheckBoxPreference_summaryOff  ref android.R.styleable::CheckBoxPreference_summaryOn  ref android.R.styleable::CheckBoxPreference_disableDependentsState </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/CheckBoxPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/CheckBoxPreference", AccessFlags = 33)]
		public partial class CheckBoxPreference : global::Android.Preference.TwoStatePreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CheckBoxPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CheckBoxPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CheckBoxPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Binds the created View to the data for this Preference. </para><para>This is a good place to grab references to custom Views in the layout and set properties on them. </para><para>Make sure to call through to the superclass's implementation.</para><para><para>onCreateView(ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// onBindView
				/// </java-name>
				[Dot42.DexImport("onBindView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal override void OnBindView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CheckBoxPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>A Preference that allows the user to choose a ringtone from those on the device. The chosen ringtone's URI will be persisted as a string. </para><para>If the user chooses the "Default" item, the saved string will be one of System#DEFAULT_RINGTONE_URI, System#DEFAULT_NOTIFICATION_URI, or System#DEFAULT_ALARM_ALERT_URI. If the user chooses the "Silent" item, the saved string will be an empty string.</para><para>ref android.R.styleable::RingtonePreference_ringtoneType  ref android.R.styleable::RingtonePreference_showDefault  ref android.R.styleable::RingtonePreference_showSilent </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/RingtonePreference
		/// </java-name>
		[Dot42.DexImport("android/preference/RingtonePreference", AccessFlags = 33)]
		public partial class RingtonePreference : global::Android.Preference.Preference, global::Android.Preference.PreferenceManager.IOnActivityResultListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public RingtonePreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RingtonePreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RingtonePreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the sound type(s) that are shown in the picker.</para><para><para>setRingtoneType(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The sound type(s) that are shown in the picker. </para>
				/// </returns>
				/// <java-name>
				/// getRingtoneType
				/// </java-name>
				[Dot42.DexImport("getRingtoneType", "()I", AccessFlags = 1)]
				public virtual int GetRingtoneType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the sound type(s) that are shown in the picker.</para><para><para>RingtoneManager::EXTRA_RINGTONE_TYPE </para></para>        
				/// </summary>
				/// <java-name>
				/// setRingtoneType
				/// </java-name>
				[Dot42.DexImport("setRingtoneType", "(I)V", AccessFlags = 1)]
				public virtual void SetRingtoneType(int type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether to a show an item for the default sound/ringtone.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether to show an item for the default sound/ringtone. </para>
				/// </returns>
				/// <java-name>
				/// getShowDefault
				/// </java-name>
				[Dot42.DexImport("getShowDefault", "()Z", AccessFlags = 1)]
				public virtual bool GetShowDefault() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether to show an item for the default sound/ringtone. The default to use will be deduced from the sound type(s) being shown.</para><para><para>RingtoneManager::EXTRA_RINGTONE_SHOW_DEFAULT </para></para>        
				/// </summary>
				/// <java-name>
				/// setShowDefault
				/// </java-name>
				[Dot42.DexImport("setShowDefault", "(Z)V", AccessFlags = 1)]
				public virtual void SetShowDefault(bool showDefault) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether to a show an item for 'Silent'.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether to show an item for 'Silent'. </para>
				/// </returns>
				/// <java-name>
				/// getShowSilent
				/// </java-name>
				[Dot42.DexImport("getShowSilent", "()Z", AccessFlags = 1)]
				public virtual bool GetShowSilent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether to show an item for 'Silent'.</para><para><para>RingtoneManager::EXTRA_RINGTONE_SHOW_SILENT </para></para>        
				/// </summary>
				/// <java-name>
				/// setShowSilent
				/// </java-name>
				[Dot42.DexImport("setShowSilent", "(Z)V", AccessFlags = 1)]
				public virtual void SetShowSilent(bool showSilent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Processes a click on the preference. This includes saving the value to the SharedPreferences. However, the overridden method should call callChangeListener(Object) to make sure the client wants to update the preference's state with the new value. </para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal override void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Prepares the intent to launch the ringtone picker. This can be modified to adjust the parameters of the ringtone picker.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onPrepareRingtonePickerIntent
				/// </java-name>
				[Dot42.DexImport("onPrepareRingtonePickerIntent", "(Landroid/content/Intent;)V", AccessFlags = 4)]
				protected internal virtual void OnPrepareRingtonePickerIntent(global::Android.Content.Intent ringtonePickerIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when a ringtone is chosen. </para><para>By default, this saves the ringtone URI to the persistent storage as a string.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSaveRingtone
				/// </java-name>
				[Dot42.DexImport("onSaveRingtone", "(Landroid/net/Uri;)V", AccessFlags = 4)]
				protected internal virtual void OnSaveRingtone(global::Android.Net.Uri ringtoneUri) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the chooser is about to be shown and the current ringtone should be marked. Can return null to not mark any ringtone. </para><para>By default, this restores the previous ringtone URI from the persistent storage.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The ringtone to be marked as the current ringtone. </para>
				/// </returns>
				/// <java-name>
				/// onRestoreRingtone
				/// </java-name>
				[Dot42.DexImport("onRestoreRingtone", "()Landroid/net/Uri;", AccessFlags = 4)]
				protected internal virtual global::Android.Net.Uri OnRestoreRingtone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <summary>
				/// <para>Called when a Preference is being inflated and the default value attribute needs to be read. Since different Preference types have different value types, the subclass should get and return the default value which will be its value type. </para><para>For example, if the value type is String, the body of the method would proxy to TypedArray#getString(int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The default value of this preference type. </para>
				/// </returns>
				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray a, int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Implement this to set the initial value of the Preference. </para><para>If <b>restorePersistedValue</b> is true, you should restore the Preference value from the android.content.SharedPreferences. If <b>restorePersistedValue</b> is false, you should set the Preference value to defaultValue that is given (and possibly store to SharedPreferences if shouldPersist() is true). </para><para>This may not always be called. One example is if it should not persist but there is no default value given.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool restorePersistedValue, object defaultValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when this Preference has been attached to a Preference hierarchy. Make sure to call the super implementation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToHierarchy
				/// </java-name>
				[Dot42.DexImport("onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V", AccessFlags = 4)]
				protected internal override void OnAttachedToHierarchy(global::Android.Preference.PreferenceManager preferenceManager) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>See Activity's onActivityResult.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the request code was handled (in which case subsequent listeners will not be called. </para>
				/// </returns>
				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool OnActivityResult(int requestCode, int resultCode, global::Android.Content.Intent data) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RingtonePreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the sound type(s) that are shown in the picker.</para><para><para>setRingtoneType(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The sound type(s) that are shown in the picker. </para>
				/// </returns>
				/// <java-name>
				/// getRingtoneType
				/// </java-name>
				public int RingtoneType
				{
				[Dot42.DexImport("getRingtoneType", "()I", AccessFlags = 1)]
						get{ return GetRingtoneType(); }
				[Dot42.DexImport("setRingtoneType", "(I)V", AccessFlags = 1)]
						set{ SetRingtoneType(value); }
				}

				/// <summary>
				/// <para>Returns whether to a show an item for the default sound/ringtone.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether to show an item for the default sound/ringtone. </para>
				/// </returns>
				/// <java-name>
				/// getShowDefault
				/// </java-name>
				public bool IsShowDefault
				{
				[Dot42.DexImport("getShowDefault", "()Z", AccessFlags = 1)]
						get{ return GetShowDefault(); }
				[Dot42.DexImport("setShowDefault", "(Z)V", AccessFlags = 1)]
						set{ SetShowDefault(value); }
				}

				/// <summary>
				/// <para>Returns whether to a show an item for 'Silent'.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether to show an item for 'Silent'. </para>
				/// </returns>
				/// <java-name>
				/// getShowSilent
				/// </java-name>
				public bool IsShowSilent
				{
				[Dot42.DexImport("getShowSilent", "()Z", AccessFlags = 1)]
						get{ return GetShowSilent(); }
				[Dot42.DexImport("setShowSilent", "(Z)V", AccessFlags = 1)]
						set{ SetShowSilent(value); }
				}

		}

		/// <summary>
		/// <para>A Preference that displays a list of entries as a dialog. </para><para>This preference will store a set of strings into the SharedPreferences. This set will contain one or more values from the setEntryValues(CharSequence[]) array.</para><para>ref android.R.styleable::MultiSelectListPreference_entries  ref android.R.styleable::MultiSelectListPreference_entryValues </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/MultiSelectListPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/MultiSelectListPreference", AccessFlags = 33)]
		public partial class MultiSelectListPreference : global::Android.Preference.DialogPreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public MultiSelectListPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MultiSelectListPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setEntries(CharSequence[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntries
				/// </java-name>
				[Dot42.DexImport("setEntries", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetEntries(global::Java.Lang.ICharSequence[] entriesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setEntries(CharSequence[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntries
				/// </java-name>
				[Dot42.DexImport("setEntries", "(I)V", AccessFlags = 1)]
				public virtual void SetEntries(int entriesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The list of entries to be shown in the list in subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The list as an array. </para>
				/// </returns>
				/// <java-name>
				/// getEntries
				/// </java-name>
				[Dot42.DexImport("getEntries", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetEntries() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				/// <para><para>setEntryValues(CharSequence[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntryValues
				/// </java-name>
				[Dot42.DexImport("setEntryValues", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetEntryValues(global::Java.Lang.ICharSequence[] entryValuesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setEntryValues(CharSequence[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// setEntryValues
				/// </java-name>
				[Dot42.DexImport("setEntryValues", "(I)V", AccessFlags = 1)]
				public virtual void SetEntryValues(int entryValuesResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the array of values to be saved for the preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The array of values. </para>
				/// </returns>
				/// <java-name>
				/// getEntryValues
				/// </java-name>
				[Dot42.DexImport("getEntryValues", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence[] GetEntryValues() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence[]);
				}

				/// <summary>
				/// <para>Sets the value of the key. This should contain entries in getEntryValues().</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setValues
				/// </java-name>
				[Dot42.DexImport("setValues", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
				public virtual void SetValues(global::Java.Util.ISet<string> values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retrieves the current value of the key. </para>        
				/// </summary>
				/// <java-name>
				/// getValues
				/// </java-name>
				[Dot42.DexImport("getValues", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
				public virtual global::Java.Util.ISet<string> GetValues() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ISet<string>);
				}

				/// <summary>
				/// <para>Returns the index of the given value (in the entry values array).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The index of the value, or -1 if not found. </para>
				/// </returns>
				/// <java-name>
				/// findIndexOfValue
				/// </java-name>
				[Dot42.DexImport("findIndexOfValue", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int FindIndexOfValue(string value) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onPrepareDialogBuilder
				/// </java-name>
				[Dot42.DexImport("onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V", AccessFlags = 4)]
				protected internal override void OnPrepareDialogBuilder(global::Android.App.AlertDialog.Builder builder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the dialog is dismissed and should be used to save data to the SharedPreferences.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDialogClosed
				/// </java-name>
				[Dot42.DexImport("onDialogClosed", "(Z)V", AccessFlags = 4)]
				protected internal override void OnDialogClosed(bool positiveResult) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when a Preference is being inflated and the default value attribute needs to be read. Since different Preference types have different value types, the subclass should get and return the default value which will be its value type. </para><para>For example, if the value type is String, the body of the method would proxy to TypedArray#getString(int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The default value of this preference type. </para>
				/// </returns>
				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray a, int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Implement this to set the initial value of the Preference. </para><para>If <b>restorePersistedValue</b> is true, you should restore the Preference value from the android.content.SharedPreferences. If <b>restorePersistedValue</b> is false, you should set the Preference value to defaultValue that is given (and possibly store to SharedPreferences if shouldPersist() is true). </para><para>This may not always be called. One example is if it should not persist but there is no default value given.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool restorePersistedValue, object defaultValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Hook allowing a Preference to generate a representation of its internal state that can later be used to create a new instance with that same state. This state should only contain information that is not persistent or can be reconstructed later.</para><para><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>saveHierarchyState </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Parcelable object containing the current dynamic state of this Preference, or null if there is nothing interesting to save. The default implementation returns null. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.Os.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MultiSelectListPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>The list of entries to be shown in the list in subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The list as an array. </para>
				/// </returns>
				/// <java-name>
				/// getEntries
				/// </java-name>
				public global::Java.Lang.ICharSequence[] Entries
				{
				[Dot42.DexImport("getEntries", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetEntries(); }
				[Dot42.DexImport("setEntries", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetEntries(value); }
				}

				/// <summary>
				/// <para>Returns the array of values to be saved for the preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The array of values. </para>
				/// </returns>
				/// <java-name>
				/// getEntryValues
				/// </java-name>
				public global::Java.Lang.ICharSequence[] EntryValues
				{
				[Dot42.DexImport("getEntryValues", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetEntryValues(); }
				[Dot42.DexImport("setEntryValues", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetEntryValues(value); }
				}

				/// <summary>
				/// <para>Retrieves the current value of the key. </para>        
				/// </summary>
				/// <java-name>
				/// getValues
				/// </java-name>
				public global::Java.Util.ISet<string> Values
				{
				[Dot42.DexImport("getValues", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return GetValues(); }
				[Dot42.DexImport("setValues", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
						set{ SetValues(value); }
				}

		}

		/// <summary>
		/// <para>A Preference that provides a two-state toggleable option. </para><para>This preference will store a boolean into the SharedPreferences.</para><para>ref android.R.styleable::SwitchPreference_summaryOff  ref android.R.styleable::SwitchPreference_summaryOn  ref android.R.styleable::SwitchPreference_switchTextOff  ref android.R.styleable::SwitchPreference_switchTextOn  ref android.R.styleable::SwitchPreference_disableDependentsState </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/SwitchPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/SwitchPreference", AccessFlags = 33)]
		public partial class SwitchPreference : global::Android.Preference.TwoStatePreference
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Construct a new SwitchPreference with the given style options.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public SwitchPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a new SwitchPreference with the given style options.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public SwitchPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Construct a new SwitchPreference with default style options.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public SwitchPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Binds the created View to the data for this Preference. </para><para>This is a good place to grab references to custom Views in the layout and set properties on them. </para><para>Make sure to call through to the superclass's implementation.</para><para><para>onCreateView(ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// onBindView
				/// </java-name>
				[Dot42.DexImport("onBindView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal override void OnBindView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the text displayed on the switch widget in the on state. This should be a very short string; one word if possible.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSwitchTextOn
				/// </java-name>
				[Dot42.DexImport("setSwitchTextOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetSwitchTextOn(global::Java.Lang.ICharSequence resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the text displayed on the switch widget in the off state. This should be a very short string; one word if possible.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSwitchTextOff
				/// </java-name>
				[Dot42.DexImport("setSwitchTextOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetSwitchTextOff(global::Java.Lang.ICharSequence resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the text displayed on the switch widget in the on state. This should be a very short string; one word if possible.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSwitchTextOn
				/// </java-name>
				[Dot42.DexImport("setSwitchTextOn", "(I)V", AccessFlags = 1)]
				public virtual void SetSwitchTextOn(int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the text displayed on the switch widget in the off state. This should be a very short string; one word if possible.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSwitchTextOff
				/// </java-name>
				[Dot42.DexImport("setSwitchTextOff", "(I)V", AccessFlags = 1)]
				public virtual void SetSwitchTextOff(int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text that will be displayed on the switch widget in the on state </para>
				/// </returns>
				/// <java-name>
				/// getSwitchTextOn
				/// </java-name>
				[Dot42.DexImport("getSwitchTextOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetSwitchTextOn() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text that will be displayed on the switch widget in the off state </para>
				/// </returns>
				/// <java-name>
				/// getSwitchTextOff
				/// </java-name>
				[Dot42.DexImport("getSwitchTextOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetSwitchTextOff() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SwitchPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text that will be displayed on the switch widget in the on state </para>
				/// </returns>
				/// <java-name>
				/// getSwitchTextOn
				/// </java-name>
				public global::Java.Lang.ICharSequence SwitchTextOn
				{
				[Dot42.DexImport("getSwitchTextOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetSwitchTextOn(); }
				[Dot42.DexImport("setSwitchTextOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetSwitchTextOn(value); }
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text that will be displayed on the switch widget in the off state </para>
				/// </returns>
				/// <java-name>
				/// getSwitchTextOff
				/// </java-name>
				public global::Java.Lang.ICharSequence SwitchTextOff
				{
				[Dot42.DexImport("getSwitchTextOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetSwitchTextOff(); }
				[Dot42.DexImport("setSwitchTextOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetSwitchTextOff(value); }
				}

		}

		/// <summary>
		/// <para>A base class for Preference objects that are dialog-based. These preferences will, when clicked, open a dialog showing the actual preference controls.</para><para>ref android.R.styleable::DialogPreference_dialogTitle  ref android.R.styleable::DialogPreference_dialogMessage  ref android.R.styleable::DialogPreference_dialogIcon  ref android.R.styleable::DialogPreference_dialogLayout  ref android.R.styleable::DialogPreference_positiveButtonText  ref android.R.styleable::DialogPreference_negativeButtonText </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/DialogPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/DialogPreference", AccessFlags = 1057)]
		public abstract partial class DialogPreference : global::Android.Preference.Preference, global::Android.Content.IDialogInterface_IOnClickListener, global::Android.Content.IDialogInterface_IOnDismissListener, global::Android.Preference.PreferenceManager.IOnActivityDestroyListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public DialogPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DialogPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setDialogTitle(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDialogTitle
				/// </java-name>
				[Dot42.DexImport("setDialogTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetDialogTitle(global::Java.Lang.ICharSequence dialogTitleResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setDialogTitle(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDialogTitle
				/// </java-name>
				[Dot42.DexImport("setDialogTitle", "(I)V", AccessFlags = 1)]
				public virtual void SetDialogTitle(int dialogTitleResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the title to be shown on subsequent dialogs. </para>        
				/// </summary>
				/// <returns>
				/// <para>The title. </para>
				/// </returns>
				/// <java-name>
				/// getDialogTitle
				/// </java-name>
				[Dot42.DexImport("getDialogTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetDialogTitle() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para><para>setDialogMessage(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDialogMessage
				/// </java-name>
				[Dot42.DexImport("setDialogMessage", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetDialogMessage(global::Java.Lang.ICharSequence dialogMessageResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setDialogMessage(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDialogMessage
				/// </java-name>
				[Dot42.DexImport("setDialogMessage", "(I)V", AccessFlags = 1)]
				public virtual void SetDialogMessage(int dialogMessageResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the message to be shown on subsequent dialogs. </para>        
				/// </summary>
				/// <returns>
				/// <para>The message. </para>
				/// </returns>
				/// <java-name>
				/// getDialogMessage
				/// </java-name>
				[Dot42.DexImport("getDialogMessage", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetDialogMessage() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the icon of the dialog. This will be shown on subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDialogIcon
				/// </java-name>
				[Dot42.DexImport("setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetDialogIcon(global::Android.Graphics.Drawable.Drawable dialogIcon) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the icon of the dialog. This will be shown on subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDialogIcon
				/// </java-name>
				[Dot42.DexImport("setDialogIcon", "(I)V", AccessFlags = 1)]
				public virtual void SetDialogIcon(int dialogIcon) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the icon to be shown on subsequent dialogs. </para>        
				/// </summary>
				/// <returns>
				/// <para>The icon, as a Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getDialogIcon
				/// </java-name>
				[Dot42.DexImport("getDialogIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetDialogIcon() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para><para>setPositiveButtonText(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setPositiveButtonText
				/// </java-name>
				[Dot42.DexImport("setPositiveButtonText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetPositiveButtonText(global::Java.Lang.ICharSequence positiveButtonTextResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setPositiveButtonText(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setPositiveButtonText
				/// </java-name>
				[Dot42.DexImport("setPositiveButtonText", "(I)V", AccessFlags = 1)]
				public virtual void SetPositiveButtonText(int positiveButtonTextResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the text of the positive button to be shown on subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text of the positive button. </para>
				/// </returns>
				/// <java-name>
				/// getPositiveButtonText
				/// </java-name>
				[Dot42.DexImport("getPositiveButtonText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetPositiveButtonText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para><para>setNegativeButtonText(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setNegativeButtonText
				/// </java-name>
				[Dot42.DexImport("setNegativeButtonText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetNegativeButtonText(global::Java.Lang.ICharSequence negativeButtonTextResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>setNegativeButtonText(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setNegativeButtonText
				/// </java-name>
				[Dot42.DexImport("setNegativeButtonText", "(I)V", AccessFlags = 1)]
				public virtual void SetNegativeButtonText(int negativeButtonTextResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the text of the negative button to be shown on subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text of the negative button. </para>
				/// </returns>
				/// <java-name>
				/// getNegativeButtonText
				/// </java-name>
				[Dot42.DexImport("getNegativeButtonText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetNegativeButtonText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the layout resource that is inflated as the View to be shown as the content View of subsequent dialogs.</para><para><para>setDialogMessage(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setDialogLayoutResource
				/// </java-name>
				[Dot42.DexImport("setDialogLayoutResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDialogLayoutResource(int dialogLayoutResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the layout resource that is used as the content View for subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The layout resource. </para>
				/// </returns>
				/// <java-name>
				/// getDialogLayoutResource
				/// </java-name>
				[Dot42.DexImport("getDialogLayoutResource", "()I", AccessFlags = 1)]
				public virtual int GetDialogLayoutResource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Prepares the dialog builder to be shown when the preference is clicked. Use this to set custom properties on the dialog. </para><para>Do not AlertDialog.Builder#create() or AlertDialog.Builder#show(). </para>        
				/// </summary>
				/// <java-name>
				/// onPrepareDialogBuilder
				/// </java-name>
				[Dot42.DexImport("onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V", AccessFlags = 4)]
				protected internal virtual void OnPrepareDialogBuilder(global::Android.App.AlertDialog.Builder builder) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Processes a click on the preference. This includes saving the value to the SharedPreferences. However, the overridden method should call callChangeListener(Object) to make sure the client wants to update the preference's state with the new value. </para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal override void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Shows the dialog associated with this Preference. This is normally initiated automatically on clicking on the preference. Call this method if you need to show the dialog on some other event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// showDialog
				/// </java-name>
				[Dot42.DexImport("showDialog", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void ShowDialog(global::Android.Os.Bundle state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates the content view for the dialog (if a custom content view is required). By default, it inflates the dialog layout resource if it is set.</para><para><para>setLayoutResource(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The content View for the dialog. </para>
				/// </returns>
				/// <java-name>
				/// onCreateDialogView
				/// </java-name>
				[Dot42.DexImport("onCreateDialogView", "()Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.View.View OnCreateDialogView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Binds views in the content View of the dialog to data. </para><para>Make sure to call through to the superclass implementation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onBindDialogView
				/// </java-name>
				[Dot42.DexImport("onBindDialogView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void OnBindDialogView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method will be invoked when a button in the dialog is clicked.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Content.IDialogInterface dialog, int which) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method will be invoked when the dialog is dismissed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnDismiss(global::Android.Content.IDialogInterface dialog) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the dialog is dismissed and should be used to save data to the SharedPreferences.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDialogClosed
				/// </java-name>
				[Dot42.DexImport("onDialogClosed", "(Z)V", AccessFlags = 4)]
				protected internal virtual void OnDialogClosed(bool positiveResult) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the dialog that is shown by this preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The dialog, or null if a dialog is not being shown. </para>
				/// </returns>
				/// <java-name>
				/// getDialog
				/// </java-name>
				[Dot42.DexImport("getDialog", "()Landroid/app/Dialog;", AccessFlags = 1)]
				public virtual global::Android.App.Dialog GetDialog() /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <summary>
				/// <para><para>See Activity's onDestroy.</para> </para>        
				/// </summary>
				/// <java-name>
				/// onActivityDestroy
				/// </java-name>
				[Dot42.DexImport("onActivityDestroy", "()V", AccessFlags = 1)]
				public virtual void OnActivityDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Hook allowing a Preference to generate a representation of its internal state that can later be used to create a new instance with that same state. This state should only contain information that is not persistent or can be reconstructed later.</para><para><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>saveHierarchyState </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Parcelable object containing the current dynamic state of this Preference, or null if there is nothing interesting to save. The default implementation returns null. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.Os.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				/// <summary>
				/// <para>Hook allowing a Preference to re-apply a representation of its internal state that had previously been generated by onSaveInstanceState. This function will never be called with a null state.</para><para><para>onSaveInstanceState </para><simplesectsep></simplesectsep><para>restoreHierarchyState </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.Os.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DialogPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the title to be shown on subsequent dialogs. </para>        
				/// </summary>
				/// <returns>
				/// <para>The title. </para>
				/// </returns>
				/// <java-name>
				/// getDialogTitle
				/// </java-name>
				public global::Java.Lang.ICharSequence DialogTitle
				{
				[Dot42.DexImport("getDialogTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetDialogTitle(); }
				[Dot42.DexImport("setDialogTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetDialogTitle(value); }
				}

				/// <summary>
				/// <para>Returns the message to be shown on subsequent dialogs. </para>        
				/// </summary>
				/// <returns>
				/// <para>The message. </para>
				/// </returns>
				/// <java-name>
				/// getDialogMessage
				/// </java-name>
				public global::Java.Lang.ICharSequence DialogMessage
				{
				[Dot42.DexImport("getDialogMessage", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetDialogMessage(); }
				[Dot42.DexImport("setDialogMessage", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetDialogMessage(value); }
				}

				/// <summary>
				/// <para>Returns the icon to be shown on subsequent dialogs. </para>        
				/// </summary>
				/// <returns>
				/// <para>The icon, as a Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getDialogIcon
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable DialogIcon
				{
				[Dot42.DexImport("getDialogIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetDialogIcon(); }
				[Dot42.DexImport("setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ SetDialogIcon(value); }
				}

				/// <summary>
				/// <para>Returns the text of the positive button to be shown on subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text of the positive button. </para>
				/// </returns>
				/// <java-name>
				/// getPositiveButtonText
				/// </java-name>
				public global::Java.Lang.ICharSequence PositiveButtonText
				{
				[Dot42.DexImport("getPositiveButtonText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetPositiveButtonText(); }
				[Dot42.DexImport("setPositiveButtonText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetPositiveButtonText(value); }
				}

				/// <summary>
				/// <para>Returns the text of the negative button to be shown on subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text of the negative button. </para>
				/// </returns>
				/// <java-name>
				/// getNegativeButtonText
				/// </java-name>
				public global::Java.Lang.ICharSequence NegativeButtonText
				{
				[Dot42.DexImport("getNegativeButtonText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetNegativeButtonText(); }
				[Dot42.DexImport("setNegativeButtonText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetNegativeButtonText(value); }
				}

				/// <summary>
				/// <para>Returns the layout resource that is used as the content View for subsequent dialogs.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The layout resource. </para>
				/// </returns>
				/// <java-name>
				/// getDialogLayoutResource
				/// </java-name>
				public int DialogLayoutResource
				{
				[Dot42.DexImport("getDialogLayoutResource", "()I", AccessFlags = 1)]
						get{ return GetDialogLayoutResource(); }
				[Dot42.DexImport("setDialogLayoutResource", "(I)V", AccessFlags = 1)]
						set{ SetDialogLayoutResource(value); }
				}

				/// <summary>
				/// <para>Gets the dialog that is shown by this preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The dialog, or null if a dialog is not being shown. </para>
				/// </returns>
				/// <java-name>
				/// getDialog
				/// </java-name>
				public global::Android.App.Dialog Dialog
				{
				[Dot42.DexImport("getDialog", "()Landroid/app/Dialog;", AccessFlags = 1)]
						get{ return GetDialog(); }
				}

		}

		/// <summary>
		/// <para>Represents the basic Preference UI building block displayed by a PreferenceActivity in the form of a ListView. This class provides the View to be displayed in the activity and associates with a SharedPreferences to store/retrieve the preference data. </para><para>When specifying a preference hierarchy in XML, each element can point to a subclass of Preference, similar to the view hierarchy and layouts. </para><para>This class contains a <c> key </c> that will be used as the key into the SharedPreferences. It is up to the subclass to decide how to store the value.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For information about building a settings UI with Preferences, read the  guide.</para><para> </para><para>ref android.R.styleable::Preference_icon  ref android.R.styleable::Preference_key  ref android.R.styleable::Preference_title  ref android.R.styleable::Preference_summary  ref android.R.styleable::Preference_order  ref android.R.styleable::Preference_fragment  ref android.R.styleable::Preference_layout  ref android.R.styleable::Preference_widgetLayout  ref android.R.styleable::Preference_enabled  ref android.R.styleable::Preference_selectable  ref android.R.styleable::Preference_dependency  ref android.R.styleable::Preference_persistent  ref android.R.styleable::Preference_defaultValue  ref android.R.styleable::Preference_shouldDisableView </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/Preference
		/// </java-name>
		[Dot42.DexImport("android/preference/Preference", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Landroid/preference/Preference;>;")]
		public partial class Preference : global::System.IComparable<global::Android.Preference.Preference>
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Specify for setOrder(int) if a specific order is not required. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_ORDER
				/// </java-name>
				[Dot42.DexImport("DEFAULT_ORDER", "I", AccessFlags = 25)]
				public const int DEFAULT_ORDER = 2147483647;
				/// <summary>
				/// <para>Perform inflation from XML and apply a class-specific base style. This constructor of Preference allows subclasses to use their own base style when they are inflating. For example, a CheckBoxPreference constructor calls this version of the super class constructor and supplies <c> android.R.attr.checkBoxPreferenceStyle </c> for <b>defStyle</b>. This allows the theme's checkbox preference style to modify all of the base preference attributes as well as the CheckBoxPreference class's attributes.</para><para><para>Preference(Context, AttributeSet) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Preference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor that is called when inflating a Preference from XML. This is called when a Preference is being constructed from an XML file, supplying attributes that were specified in the XML file. This version uses a default style of 0, so the only attribute values applied are those in the Context's Theme and the given AttributeSet.</para><para><para>Preference(Context, AttributeSet, int) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Preference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor to create a Preference.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Preference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when a Preference is being inflated and the default value attribute needs to be read. Since different Preference types have different value types, the subclass should get and return the default value which will be its value type. </para><para>For example, if the value type is String, the body of the method would proxy to TypedArray#getString(int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The default value of this preference type. </para>
				/// </returns>
				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object OnGetDefaultValue(global::Android.Content.Res.TypedArray a, int index) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				/// <para>Sets an Intent to be used for Context#startActivity(Intent) when this Preference is clicked.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIntent
				/// </java-name>
				[Dot42.DexImport("setIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the Intent associated with this Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Intent last set via setIntent(Intent) or XML. </para>
				/// </returns>
				/// <java-name>
				/// getIntent
				/// </java-name>
				[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent GetIntent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <summary>
				/// <para>Sets the class name of a fragment to be shown when this Preference is clicked.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFragment
				/// </java-name>
				[Dot42.DexImport("setFragment", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetFragment(string fragment) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the fragment class name associated with this Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The fragment class name last set via setFragment or XML. </para>
				/// </returns>
				/// <java-name>
				/// getFragment
				/// </java-name>
				[Dot42.DexImport("getFragment", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetFragment() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the extras Bundle object associated with this preference, creating a new Bundle if there currently isn't one. You can use this to get and set individual extra key/value pairs. </para>        
				/// </summary>
				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <summary>
				/// <para>Return the extras Bundle object associated with this preference, returning null if there is not currently one. </para>        
				/// </summary>
				/// <java-name>
				/// peekExtras
				/// </java-name>
				[Dot42.DexImport("peekExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle PeekExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <summary>
				/// <para>Sets the layout resource that is inflated as the View to be shown for this Preference. In most cases, the default layout is sufficient for custom Preference objects and only the widget layout needs to be changed. </para><para>This layout should contain a ViewGroup with ID android.R.id#widget_frame to be the parent of the specific widget for this Preference. It should similarly contain android.R.id#title and android.R.id#summary.</para><para><para>setWidgetLayoutResource(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setLayoutResource
				/// </java-name>
				[Dot42.DexImport("setLayoutResource", "(I)V", AccessFlags = 1)]
				public virtual void SetLayoutResource(int layoutResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the layout resource that will be shown as the View for this Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The layout resource ID. </para>
				/// </returns>
				/// <java-name>
				/// getLayoutResource
				/// </java-name>
				[Dot42.DexImport("getLayoutResource", "()I", AccessFlags = 1)]
				public virtual int GetLayoutResource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets The layout for the controllable widget portion of this Preference. This is inflated into the main layout. For example, a CheckBoxPreference would specify a custom layout (consisting of just the CheckBox) here, instead of creating its own main layout.</para><para><para>setLayoutResource(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setWidgetLayoutResource
				/// </java-name>
				[Dot42.DexImport("setWidgetLayoutResource", "(I)V", AccessFlags = 1)]
				public virtual void SetWidgetLayoutResource(int widgetLayoutResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the layout resource for the controllable widget portion of this Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The layout resource ID. </para>
				/// </returns>
				/// <java-name>
				/// getWidgetLayoutResource
				/// </java-name>
				[Dot42.DexImport("getWidgetLayoutResource", "()I", AccessFlags = 1)]
				public virtual int GetWidgetLayoutResource() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the View that will be shown in the PreferenceActivity.</para><para><para>onCreateView(ViewGroup) </para><simplesectsep></simplesectsep><para>onBindView(View) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Returns the same Preference object, for chaining multiple calls into a single statement. </para>
				/// </returns>
				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View GetView(global::Android.View.View convertView, global::Android.View.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Creates the View to be shown for this Preference in the PreferenceActivity. The default behavior is to inflate the main layout of this Preference (see setLayoutResource(int). If changing this behavior, please specify a ViewGroup with ID android.R.id#widget_frame. </para><para>Make sure to call through to the superclass's implementation.</para><para><para>onBindView(View) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The View that displays this Preference. </para>
				/// </returns>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.View.View OnCreateView(global::Android.View.ViewGroup parent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Binds the created View to the data for this Preference. </para><para>This is a good place to grab references to custom Views in the layout and set properties on them. </para><para>Make sure to call through to the superclass's implementation.</para><para><para>onCreateView(ViewGroup) </para></para>        
				/// </summary>
				/// <java-name>
				/// onBindView
				/// </java-name>
				[Dot42.DexImport("onBindView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void OnBindView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the order of this Preference with respect to other Preference objects on the same level. If this is not specified, the default behavior is to sort alphabetically. The PreferenceGroup#setOrderingAsAdded(boolean) can be used to order Preference objects based on the order they appear in the XML.</para><para><para>PreferenceGroup::setOrderingAsAdded(boolean) </para><simplesectsep></simplesectsep><para>DEFAULT_ORDER </para></para>        
				/// </summary>
				/// <java-name>
				/// setOrder
				/// </java-name>
				[Dot42.DexImport("setOrder", "(I)V", AccessFlags = 1)]
				public virtual void SetOrder(int order) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the order of this Preference with respect to other Preference objects on the same level.</para><para><para>setOrder(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The order of this Preference. </para>
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
				/// <para>Sets the title for this Preference with a resource ID.</para><para><para>setTitle(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTitle(global::Java.Lang.ICharSequence titleResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the title for this Preference with a resource ID.</para><para><para>setTitle(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1)]
				public virtual void SetTitle(int titleResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the title resource ID of this Preference. If the title did not come from a resource, 0 is returned.</para><para><para>setTitle(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The title resource. </para>
				/// </returns>
				/// <java-name>
				/// getTitleRes
				/// </java-name>
				[Dot42.DexImport("getTitleRes", "()I", AccessFlags = 1)]
				public virtual int GetTitleRes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the title of this Preference.</para><para><para>setTitle(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The title. </para>
				/// </returns>
				/// <java-name>
				/// getTitle
				/// </java-name>
				[Dot42.DexImport("getTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTitle() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the icon for this Preference with a Drawable. This icon will be placed into the ID android.R.id#icon within the View created by onCreateView(ViewGroup).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetIcon(global::Android.Graphics.Drawable.Drawable icon) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the icon for this Preference with a Drawable. This icon will be placed into the ID android.R.id#icon within the View created by onCreateView(ViewGroup).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)V", AccessFlags = 1)]
				public virtual void SetIcon(int icon) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the icon of this Preference.</para><para><para>setIcon(Drawable) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The icon. </para>
				/// </returns>
				/// <java-name>
				/// getIcon
				/// </java-name>
				[Dot42.DexImport("getIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Drawable.Drawable GetIcon() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Returns the summary of this Preference.</para><para><para>setSummary(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The summary. </para>
				/// </returns>
				/// <java-name>
				/// getSummary
				/// </java-name>
				[Dot42.DexImport("getSummary", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetSummary() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the summary for this Preference with a resource ID.</para><para><para>setSummary(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSummary
				/// </java-name>
				[Dot42.DexImport("setSummary", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetSummary(global::Java.Lang.ICharSequence summaryResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the summary for this Preference with a resource ID.</para><para><para>setSummary(CharSequence) </para></para>        
				/// </summary>
				/// <java-name>
				/// setSummary
				/// </java-name>
				[Dot42.DexImport("setSummary", "(I)V", AccessFlags = 1)]
				public virtual void SetSummary(int summaryResId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether this Preference is enabled. If disabled, it will not handle clicks.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether this Preference should be enabled in the list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this Preference is enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this Preference is selectable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSelectable
				/// </java-name>
				[Dot42.DexImport("setSelectable", "(Z)V", AccessFlags = 1)]
				public virtual void SetSelectable(bool selectable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether this Preference should be selectable in the list.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if it is selectable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isSelectable
				/// </java-name>
				[Dot42.DexImport("isSelectable", "()Z", AccessFlags = 1)]
				public virtual bool IsSelectable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this Preference should disable its view when it gets disabled. </para><para>For example, set this and setEnabled(boolean) to false for preferences that are only displaying information and 1) should not be clickable 2) should not have the view set to the disabled state.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setShouldDisableView
				/// </java-name>
				[Dot42.DexImport("setShouldDisableView", "(Z)V", AccessFlags = 1)]
				public virtual void SetShouldDisableView(bool shouldDisableView) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether this Preference should disable its view when it's action is disabled. <para>setShouldDisableView(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if it should disable the view. </para>
				/// </returns>
				/// <java-name>
				/// getShouldDisableView
				/// </java-name>
				[Dot42.DexImport("getShouldDisableView", "()Z", AccessFlags = 1)]
				public virtual bool GetShouldDisableView() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Processes a click on the preference. This includes saving the value to the SharedPreferences. However, the overridden method should call callChangeListener(Object) to make sure the client wants to update the preference's state with the new value. </para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal virtual void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the key for this Preference, which is used as a key to the SharedPreferences. This should be unique for the package.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setKey
				/// </java-name>
				[Dot42.DexImport("setKey", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetKey(string key) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the key for this Preference, which is also the key used for storing values into SharedPreferences.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetKey() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Checks whether this Preference has a valid key.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the key exists and is not a blank string, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasKey
				/// </java-name>
				[Dot42.DexImport("hasKey", "()Z", AccessFlags = 1)]
				public virtual bool HasKey() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether this Preference is persistent. If it is, it stores its value(s) into the persistent SharedPreferences storage.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if it is persistent. </para>
				/// </returns>
				/// <java-name>
				/// isPersistent
				/// </java-name>
				[Dot42.DexImport("isPersistent", "()Z", AccessFlags = 1)]
				public virtual bool IsPersistent() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Checks whether, at the given time this method is called, this Preference should store/restore its value(s) into the SharedPreferences. This, at minimum, checks whether this Preference is persistent and it currently has a key. Before you save/restore from the SharedPreferences, check this first.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if it should persist the value. </para>
				/// </returns>
				/// <java-name>
				/// shouldPersist
				/// </java-name>
				[Dot42.DexImport("shouldPersist", "()Z", AccessFlags = 4)]
				protected internal virtual bool ShouldPersist() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this Preference is persistent. When persistent, it stores its value(s) into the persistent SharedPreferences storage.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPersistent
				/// </java-name>
				[Dot42.DexImport("setPersistent", "(Z)V", AccessFlags = 1)]
				public virtual void SetPersistent(bool persistent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Call this method after the user changes the preference, but before the internal state is set. This allows the client to ignore the user value.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the user value should be set as the preference value (and persisted). </para>
				/// </returns>
				/// <java-name>
				/// callChangeListener
				/// </java-name>
				[Dot42.DexImport("callChangeListener", "(Ljava/lang/Object;)Z", AccessFlags = 4)]
				protected internal virtual bool CallChangeListener(object newValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the callback to be invoked when this Preference is changed by the user (but before the internal state has been updated).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setOnPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnPreferenceChangeListener(global::Android.Preference.Preference.IOnPreferenceChangeListener onPreferenceChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the callback to be invoked when this Preference is changed by the user (but before the internal state has been updated).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The callback to be invoked. </para>
				/// </returns>
				/// <java-name>
				/// getOnPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;", AccessFlags = 1)]
				public virtual global::Android.Preference.Preference.IOnPreferenceChangeListener GetOnPreferenceChangeListener() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.Preference.IOnPreferenceChangeListener);
				}

				/// <summary>
				/// <para>Sets the callback to be invoked when this Preference is clicked.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setOnPreferenceClickListener
				/// </java-name>
				[Dot42.DexImport("setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnPreferenceClickListener(global::Android.Preference.Preference.IOnPreferenceClickListener onPreferenceClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the callback to be invoked when this Preference is clicked.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The callback to be invoked. </para>
				/// </returns>
				/// <java-name>
				/// getOnPreferenceClickListener
				/// </java-name>
				[Dot42.DexImport("getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;", AccessFlags = 1)]
				public virtual global::Android.Preference.Preference.IOnPreferenceClickListener GetOnPreferenceClickListener() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.Preference.IOnPreferenceClickListener);
				}

				/// <summary>
				/// <para>Returns the android.content.Context of this Preference. Each Preference in a Preference hierarchy can be from different Context (for example, if multiple activities provide preferences into a single PreferenceActivity). This Context will be used to save the Preference values.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Context of this Preference. </para>
				/// </returns>
				/// <java-name>
				/// getContext
				/// </java-name>
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
				public virtual global::Android.Content.Context GetContext() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Context);
				}

				/// <summary>
				/// <para>Returns the SharedPreferences where this Preference can read its value(s). Usually, it's easier to use one of the helper read methods: getPersistedBoolean(boolean), getPersistedFloat(float), getPersistedInt(int), getPersistedLong(long), getPersistedString(String). To save values, see getEditor(). </para><para>In some cases, writes to the getEditor() will not be committed right away and hence not show up in the returned SharedPreferences, this is intended behavior to improve performance.</para><para><para>getEditor() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The SharedPreferences where this Preference reads its value(s), or null if it isn't attached to a Preference hierarchy. </para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getSharedPreferences", "()Landroid/content/SharedPreferences;", AccessFlags = 1)]
				public virtual global::Android.Content.ISharedPreferences GetSharedPreferences() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <summary>
				/// <para>Returns an SharedPreferences.Editor where this Preference can save its value(s). Usually it's easier to use one of the helper save methods: persistBoolean(boolean), persistFloat(float), persistInt(int), persistLong(long), persistString(String). To read values, see getSharedPreferences(). If shouldCommit() returns true, it is this Preference's responsibility to commit. </para><para>In some cases, writes to this will not be committed right away and hence not show up in the SharedPreferences, this is intended behavior to improve performance.</para><para><para>shouldCommit() </para><simplesectsep></simplesectsep><para>getSharedPreferences() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A SharedPreferences.Editor where this preference saves its value(s), or null if it isn't attached to a Preference hierarchy. </para>
				/// </returns>
				/// <java-name>
				/// getEditor
				/// </java-name>
				[Dot42.DexImport("getEditor", "()Landroid/content/SharedPreferences$Editor;", AccessFlags = 1)]
				public virtual global::Android.Content.ISharedPreferences_IEditor GetEditor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences_IEditor);
				}

				/// <summary>
				/// <para>Returns whether the Preference should commit its saved value(s) in getEditor(). This may return false in situations where batch committing is being done (by the manager) to improve performance.</para><para><para>getEditor() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the Preference should commit its saved value(s). </para>
				/// </returns>
				/// <java-name>
				/// shouldCommit
				/// </java-name>
				[Dot42.DexImport("shouldCommit", "()Z", AccessFlags = 1)]
				public virtual bool ShouldCommit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Compares Preference objects based on order (if set), otherwise alphabetically on the titles.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>0 if the same; less than 0 if this Preference sorts ahead of <b>another</b>; greater than 0 if this Preference sorts after <b>another</b>. </para>
				/// </returns>
				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Landroid/preference/Preference;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Android.Preference.Preference another) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Should be called when the data of this Preference has changed. </para>        
				/// </summary>
				/// <java-name>
				/// notifyChanged
				/// </java-name>
				[Dot42.DexImport("notifyChanged", "()V", AccessFlags = 4)]
				protected internal virtual void NotifyChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Should be called when a Preference has been added/removed from this group, or the ordering should be re-evaluated. </para>        
				/// </summary>
				/// <java-name>
				/// notifyHierarchyChanged
				/// </java-name>
				[Dot42.DexImport("notifyHierarchyChanged", "()V", AccessFlags = 4)]
				protected internal virtual void NotifyHierarchyChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the PreferenceManager that manages this Preference object's tree.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceManager. </para>
				/// </returns>
				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
				public virtual global::Android.Preference.PreferenceManager GetPreferenceManager() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.PreferenceManager);
				}

				/// <summary>
				/// <para>Called when this Preference has been attached to a Preference hierarchy. Make sure to call the super implementation.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToHierarchy
				/// </java-name>
				[Dot42.DexImport("onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V", AccessFlags = 4)]
				protected internal virtual void OnAttachedToHierarchy(global::Android.Preference.PreferenceManager preferenceManager) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the Preference hierarchy has been attached to the PreferenceActivity. This can also be called when this Preference has been attached to a group that was already attached to the PreferenceActivity. </para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToActivity
				/// </java-name>
				[Dot42.DexImport("onAttachedToActivity", "()V", AccessFlags = 4)]
				protected internal virtual void OnAttachedToActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finds a Preference in this hierarchy (the whole thing, even above/below your PreferenceScreen screen break) with the given key. </para><para>This only functions after we have been attached to a hierarchy.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Preference that uses the given key. </para>
				/// </returns>
				/// <java-name>
				/// findPreferenceInHierarchy
				/// </java-name>
				[Dot42.DexImport("findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;", AccessFlags = 4)]
				protected internal virtual global::Android.Preference.Preference FindPreferenceInHierarchy(string key) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.Preference);
				}

				/// <summary>
				/// <para>Notifies any listening dependents of a change that affects the dependency.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// notifyDependencyChange
				/// </java-name>
				[Dot42.DexImport("notifyDependencyChange", "(Z)V", AccessFlags = 1)]
				public virtual void NotifyDependencyChange(bool disableDependents) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the dependency changes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onDependencyChanged
				/// </java-name>
				[Dot42.DexImport("onDependencyChanged", "(Landroid/preference/Preference;Z)V", AccessFlags = 1)]
				public virtual void OnDependencyChanged(global::Android.Preference.Preference dependency, bool disableDependent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Checks whether this preference's dependents should currently be disabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the dependents should be disabled, otherwise false. </para>
				/// </returns>
				/// <java-name>
				/// shouldDisableDependents
				/// </java-name>
				[Dot42.DexImport("shouldDisableDependents", "()Z", AccessFlags = 1)]
				public virtual bool ShouldDisableDependents() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets the key of a Preference that this Preference will depend on. If that Preference is not set or is off, this Preference will be disabled.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDependency
				/// </java-name>
				[Dot42.DexImport("setDependency", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetDependency(string dependencyKey) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the key of the dependency on this Preference.</para><para><para>setDependency(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The key of the dependency. </para>
				/// </returns>
				/// <java-name>
				/// getDependency
				/// </java-name>
				[Dot42.DexImport("getDependency", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetDependency() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Called when this Preference is being removed from the hierarchy. You should remove any references to this Preference that you know about. Make sure to call through to the superclass implementation. </para>        
				/// </summary>
				/// <java-name>
				/// onPrepareForRemoval
				/// </java-name>
				[Dot42.DexImport("onPrepareForRemoval", "()V", AccessFlags = 4)]
				protected internal virtual void OnPrepareForRemoval() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the default value for this Preference, which will be set either if persistence is off or persistence is on and the preference is not found in the persistent storage.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultValue
				/// </java-name>
				[Dot42.DexImport("setDefaultValue", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetDefaultValue(object defaultValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Implement this to set the initial value of the Preference. </para><para>If <b>restorePersistedValue</b> is true, you should restore the Preference value from the android.content.SharedPreferences. If <b>restorePersistedValue</b> is false, you should set the Preference value to defaultValue that is given (and possibly store to SharedPreferences if shouldPersist() is true). </para><para>This may not always be called. One example is if it should not persist but there is no default value given.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal virtual void OnSetInitialValue(bool restorePersistedValue, object defaultValue) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Attempts to persist a String to the android.content.SharedPreferences. </para><para>This will check if this Preference is persistent, get an editor from the PreferenceManager, put in the string, and check if we should commit (and commit if so).</para><para><para>getPersistedString(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the Preference is persistent. (This is not whether the value was persisted, since we may not necessarily commit if there will be a batch commit later.) </para>
				/// </returns>
				/// <java-name>
				/// persistString
				/// </java-name>
				[Dot42.DexImport("persistString", "(Ljava/lang/String;)Z", AccessFlags = 4)]
				protected internal virtual bool PersistString(string value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to get a persisted String from the android.content.SharedPreferences. </para><para>This will check if this Preference is persistent, get the SharedPreferences from the PreferenceManager, and get the value.</para><para><para>persistString(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value from the SharedPreferences or the default return value. </para>
				/// </returns>
				/// <java-name>
				/// getPersistedString
				/// </java-name>
				[Dot42.DexImport("getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetPersistedString(string defaultReturnValue) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Attempts to persist an int to the android.content.SharedPreferences.</para><para><para>persistString(String) </para><simplesectsep></simplesectsep><para>getPersistedInt(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the Preference is persistent. (This is not whether the value was persisted, since we may not necessarily commit if there will be a batch commit later.) </para>
				/// </returns>
				/// <java-name>
				/// persistInt
				/// </java-name>
				[Dot42.DexImport("persistInt", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool PersistInt(int value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to get a persisted int from the android.content.SharedPreferences.</para><para><para>getPersistedString(String) </para><simplesectsep></simplesectsep><para>persistInt(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value from the SharedPreferences or the default return value. </para>
				/// </returns>
				/// <java-name>
				/// getPersistedInt
				/// </java-name>
				[Dot42.DexImport("getPersistedInt", "(I)I", AccessFlags = 4)]
				protected internal virtual int GetPersistedInt(int defaultReturnValue) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Attempts to persist a float to the android.content.SharedPreferences.</para><para><para>persistString(String) </para><simplesectsep></simplesectsep><para>getPersistedFloat(float) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this Preference is persistent. (This is not whether the value was persisted, since we may not necessarily commit if there will be a batch commit later.) </para>
				/// </returns>
				/// <java-name>
				/// persistFloat
				/// </java-name>
				[Dot42.DexImport("persistFloat", "(F)Z", AccessFlags = 4)]
				protected internal virtual bool PersistFloat(float value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to get a persisted float from the android.content.SharedPreferences.</para><para><para>getPersistedString(String) </para><simplesectsep></simplesectsep><para>persistFloat(float) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value from the SharedPreferences or the default return value. </para>
				/// </returns>
				/// <java-name>
				/// getPersistedFloat
				/// </java-name>
				[Dot42.DexImport("getPersistedFloat", "(F)F", AccessFlags = 4)]
				protected internal virtual float GetPersistedFloat(float defaultReturnValue) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				/// <para>Attempts to persist a long to the android.content.SharedPreferences.</para><para><para>persistString(String) </para><simplesectsep></simplesectsep><para>getPersistedLong(long) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this Preference is persistent. (This is not whether the value was persisted, since we may not necessarily commit if there will be a batch commit later.) </para>
				/// </returns>
				/// <java-name>
				/// persistLong
				/// </java-name>
				[Dot42.DexImport("persistLong", "(J)Z", AccessFlags = 4)]
				protected internal virtual bool PersistLong(long value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to get a persisted long from the android.content.SharedPreferences.</para><para><para>getPersistedString(String) </para><simplesectsep></simplesectsep><para>persistLong(long) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value from the SharedPreferences or the default return value. </para>
				/// </returns>
				/// <java-name>
				/// getPersistedLong
				/// </java-name>
				[Dot42.DexImport("getPersistedLong", "(J)J", AccessFlags = 4)]
				protected internal virtual long GetPersistedLong(long defaultReturnValue) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Attempts to persist a boolean to the android.content.SharedPreferences.</para><para><para>persistString(String) </para><simplesectsep></simplesectsep><para>getPersistedBoolean(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if this Preference is persistent. (This is not whether the value was persisted, since we may not necessarily commit if there will be a batch commit later.) </para>
				/// </returns>
				/// <java-name>
				/// persistBoolean
				/// </java-name>
				[Dot42.DexImport("persistBoolean", "(Z)Z", AccessFlags = 4)]
				protected internal virtual bool PersistBoolean(bool value) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Attempts to get a persisted boolean from the android.content.SharedPreferences.</para><para><para>getPersistedString(String) </para><simplesectsep></simplesectsep><para>persistBoolean(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The value from the SharedPreferences or the default return value. </para>
				/// </returns>
				/// <java-name>
				/// getPersistedBoolean
				/// </java-name>
				[Dot42.DexImport("getPersistedBoolean", "(Z)Z", AccessFlags = 4)]
				protected internal virtual bool GetPersistedBoolean(bool defaultReturnValue) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				/// <para>Store this Preference hierarchy's frozen state into the given container.</para><para><para>restoreHierarchyState </para><simplesectsep></simplesectsep><para>onSaveInstanceState </para></para>        
				/// </summary>
				/// <java-name>
				/// saveHierarchyState
				/// </java-name>
				[Dot42.DexImport("saveHierarchyState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SaveHierarchyState(global::Android.Os.Bundle container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Hook allowing a Preference to generate a representation of its internal state that can later be used to create a new instance with that same state. This state should only contain information that is not persistent or can be reconstructed later.</para><para><para>onRestoreInstanceState </para><simplesectsep></simplesectsep><para>saveHierarchyState </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A Parcelable object containing the current dynamic state of this Preference, or null if there is nothing interesting to save. The default implementation returns null. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal virtual global::Android.Os.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				/// <summary>
				/// <para>Restore this Preference hierarchy's previously saved state from the given container.</para><para><para>saveHierarchyState </para><simplesectsep></simplesectsep><para>onRestoreInstanceState </para></para>        
				/// </summary>
				/// <java-name>
				/// restoreHierarchyState
				/// </java-name>
				[Dot42.DexImport("restoreHierarchyState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void RestoreHierarchyState(global::Android.Os.Bundle container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Hook allowing a Preference to re-apply a representation of its internal state that had previously been generated by onSaveInstanceState. This function will never be called with a null state.</para><para><para>onSaveInstanceState </para><simplesectsep></simplesectsep><para>restoreHierarchyState </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal virtual void OnRestoreInstanceState(global::Android.Os.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Preference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return the Intent associated with this Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Intent last set via setIntent(Intent) or XML. </para>
				/// </returns>
				/// <java-name>
				/// getIntent
				/// </java-name>
				public global::Android.Content.Intent Intent
				{
				[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
						get{ return GetIntent(); }
				[Dot42.DexImport("setIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
						set{ SetIntent(value); }
				}

				/// <summary>
				/// <para>Return the fragment class name associated with this Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The fragment class name last set via setFragment or XML. </para>
				/// </returns>
				/// <java-name>
				/// getFragment
				/// </java-name>
				public string Fragment
				{
				[Dot42.DexImport("getFragment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetFragment(); }
				[Dot42.DexImport("setFragment", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetFragment(value); }
				}

				/// <summary>
				/// <para>Return the extras Bundle object associated with this preference, creating a new Bundle if there currently isn't one. You can use this to get and set individual extra key/value pairs. </para>        
				/// </summary>
				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.Os.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				}

				/// <summary>
				/// <para>Gets the layout resource that will be shown as the View for this Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The layout resource ID. </para>
				/// </returns>
				/// <java-name>
				/// getLayoutResource
				/// </java-name>
				public int LayoutResource
				{
				[Dot42.DexImport("getLayoutResource", "()I", AccessFlags = 1)]
						get{ return GetLayoutResource(); }
				[Dot42.DexImport("setLayoutResource", "(I)V", AccessFlags = 1)]
						set{ SetLayoutResource(value); }
				}

				/// <summary>
				/// <para>Gets the layout resource for the controllable widget portion of this Preference.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The layout resource ID. </para>
				/// </returns>
				/// <java-name>
				/// getWidgetLayoutResource
				/// </java-name>
				public int WidgetLayoutResource
				{
				[Dot42.DexImport("getWidgetLayoutResource", "()I", AccessFlags = 1)]
						get{ return GetWidgetLayoutResource(); }
				[Dot42.DexImport("setWidgetLayoutResource", "(I)V", AccessFlags = 1)]
						set{ SetWidgetLayoutResource(value); }
				}

				/// <summary>
				/// <para>Gets the order of this Preference with respect to other Preference objects on the same level.</para><para><para>setOrder(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The order of this Preference. </para>
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
				/// <para>Returns the title resource ID of this Preference. If the title did not come from a resource, 0 is returned.</para><para><para>setTitle(int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The title resource. </para>
				/// </returns>
				/// <java-name>
				/// getTitleRes
				/// </java-name>
				public int TitleRes
				{
				[Dot42.DexImport("getTitleRes", "()I", AccessFlags = 1)]
						get{ return GetTitleRes(); }
				}

				/// <summary>
				/// <para>Returns the title of this Preference.</para><para><para>setTitle(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The title. </para>
				/// </returns>
				/// <java-name>
				/// getTitle
				/// </java-name>
				public global::Java.Lang.ICharSequence Title
				{
				[Dot42.DexImport("getTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetTitle(); }
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetTitle(value); }
				}

				/// <summary>
				/// <para>Returns the icon of this Preference.</para><para><para>setIcon(Drawable) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The icon. </para>
				/// </returns>
				/// <java-name>
				/// getIcon
				/// </java-name>
				public global::Android.Graphics.Drawable.Drawable Icon
				{
				[Dot42.DexImport("getIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return GetIcon(); }
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ SetIcon(value); }
				}

				/// <summary>
				/// <para>Returns the summary of this Preference.</para><para><para>setSummary(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The summary. </para>
				/// </returns>
				/// <java-name>
				/// getSummary
				/// </java-name>
				public global::Java.Lang.ICharSequence Summary
				{
				[Dot42.DexImport("getSummary", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetSummary(); }
				[Dot42.DexImport("setSummary", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetSummary(value); }
				}

				/// <summary>
				/// <para>Checks whether this Preference should disable its view when it's action is disabled. <para>setShouldDisableView(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if it should disable the view. </para>
				/// </returns>
				/// <java-name>
				/// getShouldDisableView
				/// </java-name>
				public bool IsShouldDisableView
				{
				[Dot42.DexImport("getShouldDisableView", "()Z", AccessFlags = 1)]
						get{ return GetShouldDisableView(); }
				[Dot42.DexImport("setShouldDisableView", "(Z)V", AccessFlags = 1)]
						set{ SetShouldDisableView(value); }
				}

				/// <summary>
				/// <para>Gets the key for this Preference, which is also the key used for storing values into SharedPreferences.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The key. </para>
				/// </returns>
				/// <java-name>
				/// getKey
				/// </java-name>
				public string Key
				{
				[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetKey(); }
				[Dot42.DexImport("setKey", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetKey(value); }
				}

				/// <summary>
				/// <para>Returns the callback to be invoked when this Preference is changed by the user (but before the internal state has been updated).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The callback to be invoked. </para>
				/// </returns>
				/// <java-name>
				/// getOnPreferenceChangeListener
				/// </java-name>
				public global::Android.Preference.Preference.IOnPreferenceChangeListener OnPreferenceChangeListener
				{
				[Dot42.DexImport("getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;", AccessFlags = 1)]
						get{ return GetOnPreferenceChangeListener(); }
				[Dot42.DexImport("setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V", AccessFlags = 1)]
						set{ SetOnPreferenceChangeListener(value); }
				}

				/// <summary>
				/// <para>Returns the callback to be invoked when this Preference is clicked.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The callback to be invoked. </para>
				/// </returns>
				/// <java-name>
				/// getOnPreferenceClickListener
				/// </java-name>
				public global::Android.Preference.Preference.IOnPreferenceClickListener OnPreferenceClickListener
				{
				[Dot42.DexImport("getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;", AccessFlags = 1)]
						get{ return GetOnPreferenceClickListener(); }
				[Dot42.DexImport("setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V", AccessFlags = 1)]
						set{ SetOnPreferenceClickListener(value); }
				}

				/// <summary>
				/// <para>Returns the android.content.Context of this Preference. Each Preference in a Preference hierarchy can be from different Context (for example, if multiple activities provide preferences into a single PreferenceActivity). This Context will be used to save the Preference values.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Context of this Preference. </para>
				/// </returns>
				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
				[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return GetContext(); }
				}

				/// <summary>
				/// <para>Returns the SharedPreferences where this Preference can read its value(s). Usually, it's easier to use one of the helper read methods: getPersistedBoolean(boolean), getPersistedFloat(float), getPersistedInt(int), getPersistedLong(long), getPersistedString(String). To save values, see getEditor(). </para><para>In some cases, writes to the getEditor() will not be committed right away and hence not show up in the returned SharedPreferences, this is intended behavior to improve performance.</para><para><para>getEditor() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The SharedPreferences where this Preference reads its value(s), or null if it isn't attached to a Preference hierarchy. </para>
				/// </returns>
				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				public global::Android.Content.ISharedPreferences SharedPreferences
				{
				[Dot42.DexImport("getSharedPreferences", "()Landroid/content/SharedPreferences;", AccessFlags = 1)]
						get{ return GetSharedPreferences(); }
				}

				/// <summary>
				/// <para>Returns an SharedPreferences.Editor where this Preference can save its value(s). Usually it's easier to use one of the helper save methods: persistBoolean(boolean), persistFloat(float), persistInt(int), persistLong(long), persistString(String). To read values, see getSharedPreferences(). If shouldCommit() returns true, it is this Preference's responsibility to commit. </para><para>In some cases, writes to this will not be committed right away and hence not show up in the SharedPreferences, this is intended behavior to improve performance.</para><para><para>shouldCommit() </para><simplesectsep></simplesectsep><para>getSharedPreferences() </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A SharedPreferences.Editor where this preference saves its value(s), or null if it isn't attached to a Preference hierarchy. </para>
				/// </returns>
				/// <java-name>
				/// getEditor
				/// </java-name>
				public global::Android.Content.ISharedPreferences_IEditor Editor
				{
				[Dot42.DexImport("getEditor", "()Landroid/content/SharedPreferences$Editor;", AccessFlags = 1)]
						get{ return GetEditor(); }
				}

				/// <summary>
				/// <para>Gets the PreferenceManager that manages this Preference object's tree.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The PreferenceManager. </para>
				/// </returns>
				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				public global::Android.Preference.PreferenceManager PreferenceManager
				{
				[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
						get{ return GetPreferenceManager(); }
				}

				/// <summary>
				/// <para>Returns the key of the dependency on this Preference.</para><para><para>setDependency(String) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The key of the dependency. </para>
				/// </returns>
				/// <java-name>
				/// getDependency
				/// </java-name>
				public string Dependency
				{
				[Dot42.DexImport("getDependency", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetDependency(); }
				[Dot42.DexImport("setDependency", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetDependency(value); }
				}

				/// <summary>
				/// <para>A base class for managing the instance state of a Preference. </para>    
				/// </summary>
				/// <java-name>
				/// android/preference/Preference$BaseSavedState
				/// </java-name>
				[Dot42.DexImport("android/preference/Preference$BaseSavedState", AccessFlags = 9)]
				public partial class BaseSavedState : global::Android.View.AbsSavedState
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.Os.IParcelable_ICreator<BaseSavedState> CREATOR;
						[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public BaseSavedState(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
						public BaseSavedState(global::Android.Os.IParcelable parcelable) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal BaseSavedState() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				/// <para>Interface definition for a callback to be invoked when a Preference is clicked. </para>    
				/// </summary>
				/// <java-name>
				/// android/preference/Preference$OnPreferenceClickListener
				/// </java-name>
				[Dot42.DexImport("android/preference/Preference$OnPreferenceClickListener", AccessFlags = 1545)]
				public partial interface IOnPreferenceClickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when a Preference has been clicked.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>True if the click was handled. </para>
						/// </returns>
						/// <java-name>
						/// onPreferenceClick
						/// </java-name>
						[Dot42.DexImport("onPreferenceClick", "(Landroid/preference/Preference;)Z", AccessFlags = 1025)]
						bool OnPreferenceClick(global::Android.Preference.Preference preference) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Interface definition for a callback to be invoked when the value of this Preference has been changed by the user and is about to be set and/or persisted. This gives the client a chance to prevent setting and/or persisting the value. </para>    
				/// </summary>
				/// <java-name>
				/// android/preference/Preference$OnPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("android/preference/Preference$OnPreferenceChangeListener", AccessFlags = 1545)]
				public partial interface IOnPreferenceChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called when a Preference has been changed by the user. This is called before the state of the Preference is about to be updated and before the state is persisted.</para><para></para>        
						/// </summary>
						/// <returns>
						/// <para>True to update the state of the Preference with the new value. </para>
						/// </returns>
						/// <java-name>
						/// onPreferenceChange
						/// </java-name>
						[Dot42.DexImport("onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z", AccessFlags = 1025)]
						bool OnPreferenceChange(global::Android.Preference.Preference preference, object newValue) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		/// <para>A container for multiple Preference objects. It is a base class for Preference objects that are parents, such as PreferenceCategory and PreferenceScreen.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For information about building a settings UI with Preferences, read the  guide.</para><para> </para><para>ref android.R.styleable::PreferenceGroup_orderingFromXml </para>    
		/// </summary>
		/// <java-name>
		/// android/preference/PreferenceGroup
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceGroup", AccessFlags = 1057)]
		public abstract partial class PreferenceGroup : global::Android.Preference.Preference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public PreferenceGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public PreferenceGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Whether to order the Preference children of this group as they are added. If this is false, the ordering will follow each Preference order and default to alphabetic for those without an order. </para><para>If this is called after preferences are added, they will not be re-ordered in the order they were added, hence call this method early on.</para><para><para>Preference::setOrder(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setOrderingAsAdded
				/// </java-name>
				[Dot42.DexImport("setOrderingAsAdded", "(Z)V", AccessFlags = 1)]
				public virtual void SetOrderingAsAdded(bool orderingAsAdded) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Whether this group is ordering preferences in the order they are added.</para><para><para>setOrderingAsAdded(boolean) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether this group orders based on the order the children are added. </para>
				/// </returns>
				/// <java-name>
				/// isOrderingAsAdded
				/// </java-name>
				[Dot42.DexImport("isOrderingAsAdded", "()Z", AccessFlags = 1)]
				public virtual bool IsOrderingAsAdded() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called by the inflater to add an item to this group. </para>        
				/// </summary>
				/// <java-name>
				/// addItemFromInflater
				/// </java-name>
				[Dot42.DexImport("addItemFromInflater", "(Landroid/preference/Preference;)V", AccessFlags = 1)]
				public virtual void AddItemFromInflater(global::Android.Preference.Preference preference) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of children Preferences. </para>        
				/// </summary>
				/// <returns>
				/// <para>The number of preference children in this group. </para>
				/// </returns>
				/// <java-name>
				/// getPreferenceCount
				/// </java-name>
				[Dot42.DexImport("getPreferenceCount", "()I", AccessFlags = 1)]
				public virtual int GetPreferenceCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns the Preference at a particular index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Preference. </para>
				/// </returns>
				/// <java-name>
				/// getPreference
				/// </java-name>
				[Dot42.DexImport("getPreference", "(I)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preference.Preference GetPreference(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.Preference);
				}

				/// <summary>
				/// <para>Adds a Preference at the correct position based on the preference's order.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the preference is now in this group. </para>
				/// </returns>
				/// <java-name>
				/// addPreference
				/// </java-name>
				[Dot42.DexImport("addPreference", "(Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool AddPreference(global::Android.Preference.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes a Preference from this group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the preference was found and removed. </para>
				/// </returns>
				/// <java-name>
				/// removePreference
				/// </java-name>
				[Dot42.DexImport("removePreference", "(Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool RemovePreference(global::Android.Preference.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Removes all Preferences from this group. </para>        
				/// </summary>
				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "()V", AccessFlags = 1)]
				public virtual void RemoveAll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Prepares a Preference to be added to the group.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether to allow adding the preference (true), or not (false). </para>
				/// </returns>
				/// <java-name>
				/// onPrepareAddPreference
				/// </java-name>
				[Dot42.DexImport("onPrepareAddPreference", "(Landroid/preference/Preference;)Z", AccessFlags = 4)]
				protected internal virtual bool OnPrepareAddPreference(global::Android.Preference.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Finds a Preference based on its key. If two Preference share the same key (not recommended), the first to appear will be returned (to retrieve the other preference with the same key, call this method on the first preference). If this preference has the key, it will not be returned. </para><para>This will recursively search for the preference into children that are also PreferenceGroups.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The Preference with the key, or null. </para>
				/// </returns>
				/// <java-name>
				/// findPreference
				/// </java-name>
				[Dot42.DexImport("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preference.Preference FindPreference(global::Java.Lang.ICharSequence key) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preference.Preference);
				}

				/// <summary>
				/// <para>Whether this preference group should be shown on the same screen as its contained preferences.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the contained preferences should be shown on the same screen as this preference. </para>
				/// </returns>
				/// <java-name>
				/// isOnSameScreenAsChildren
				/// </java-name>
				[Dot42.DexImport("isOnSameScreenAsChildren", "()Z", AccessFlags = 4)]
				protected internal virtual bool IsOnSameScreenAsChildren() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called when the Preference hierarchy has been attached to the PreferenceActivity. This can also be called when this Preference has been attached to a group that was already attached to the PreferenceActivity. </para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToActivity
				/// </java-name>
				[Dot42.DexImport("onAttachedToActivity", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when this Preference is being removed from the hierarchy. You should remove any references to this Preference that you know about. Make sure to call through to the superclass implementation. </para>        
				/// </summary>
				/// <java-name>
				/// onPrepareForRemoval
				/// </java-name>
				[Dot42.DexImport("onPrepareForRemoval", "()V", AccessFlags = 4)]
				protected internal override void OnPrepareForRemoval() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether this Preference is enabled. If disabled, it will not handle clicks.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
				public override void SetEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by saveHierarchyState to store the instance for this Preference and its children. May be overridden to modify how the save happens for children. For example, some Preference objects may want to not store an instance for their children.</para><para><para>saveHierarchyState </para><simplesectsep></simplesectsep><para>onSaveInstanceState </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void DispatchSaveInstanceState(global::Android.Os.Bundle container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called by restoreHierarchyState to retrieve the saved state for this Preference and its children. May be overridden to modify how restoring happens to the children of a Preference. For example, some Preference objects may not want to save state for their children.</para><para><para>restoreHierarchyState </para><simplesectsep></simplesectsep><para>onRestoreInstanceState </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void DispatchRestoreInstanceState(global::Android.Os.Bundle container) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PreferenceGroup() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns the number of children Preferences. </para>        
				/// </summary>
				/// <returns>
				/// <para>The number of preference children in this group. </para>
				/// </returns>
				/// <java-name>
				/// getPreferenceCount
				/// </java-name>
				public int PreferenceCount
				{
				[Dot42.DexImport("getPreferenceCount", "()I", AccessFlags = 1)]
						get{ return GetPreferenceCount(); }
				}

		}

}


