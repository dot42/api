﻿#pragma warning disable 1717
namespace Android.Preferences
{
		/// <java-name>
		/// android/preference/CheckBoxPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/CheckBoxPreference", AccessFlags = 33)]
		public partial class CheckBoxPreference : global::Android.Preferences.TwoStatePreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CheckBoxPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CheckBoxPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CheckBoxPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBindView
				/// </java-name>
				[Dot42.DexImport("onBindView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal override void OnBindView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CheckBoxPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/preference/DialogPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/DialogPreference", AccessFlags = 1057)]
		public abstract partial class DialogPreference : global::Android.Preferences.Preference, global::Android.Content.IDialogInterface_IOnClickListener, global::Android.Content.IDialogInterface_IOnDismissListener, global::Android.Preferences.PreferenceManager.IOnActivityDestroyListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public DialogPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DialogPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDialogTitle
				/// </java-name>
				[Dot42.DexImport("setDialogTitle", "(I)V", AccessFlags = 1)]
				public virtual void SetDialogTitle(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDialogMessage
				/// </java-name>
				[Dot42.DexImport("setDialogMessage", "(I)V", AccessFlags = 1)]
				public virtual void SetDialogMessage(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDialogIcon
				/// </java-name>
				[Dot42.DexImport("setDialogIcon", "(I)V", AccessFlags = 1)]
				public virtual void SetDialogIcon(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPositiveButtonText
				/// </java-name>
				[Dot42.DexImport("setPositiveButtonText", "(I)V", AccessFlags = 1)]
				public virtual void SetPositiveButtonText(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNegativeButtonText
				/// </java-name>
				[Dot42.DexImport("setNegativeButtonText", "(I)V", AccessFlags = 1)]
				public virtual void SetNegativeButtonText(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPrepareDialogBuilder
				/// </java-name>
				[Dot42.DexImport("onPrepareDialogBuilder", "(Landroid/app/AlertDialog$Builder;)V", AccessFlags = 4)]
				protected internal virtual void OnPrepareDialogBuilder(global::Android.App.AlertDialog.Builder builder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal override void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showDialog
				/// </java-name>
				[Dot42.DexImport("showDialog", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void ShowDialog(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDialogView
				/// </java-name>
				[Dot42.DexImport("onCreateDialogView", "()Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View OnCreateDialogView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onBindDialogView
				/// </java-name>
				[Dot42.DexImport("onBindDialogView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void OnBindDialogView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Content.IDialogInterface dialogInterface, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public virtual void OnDismiss(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDialogClosed
				/// </java-name>
				[Dot42.DexImport("onDialogClosed", "(Z)V", AccessFlags = 4)]
				protected internal virtual void OnDialogClosed(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActivityDestroy
				/// </java-name>
				[Dot42.DexImport("onActivityDestroy", "()V", AccessFlags = 1)]
				public virtual void OnActivityDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DialogPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDialogTitle
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence DialogTitle
				{
						[Dot42.DexImport("getDialogTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setDialogTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDialogMessage
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence DialogMessage
				{
						[Dot42.DexImport("getDialogMessage", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setDialogMessage", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDialogIcon
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable DialogIcon
				{
						[Dot42.DexImport("getDialogIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setDialogIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPositiveButtonText
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence PositiveButtonText
				{
						[Dot42.DexImport("getPositiveButtonText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setPositiveButtonText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNegativeButtonText
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence NegativeButtonText
				{
						[Dot42.DexImport("getNegativeButtonText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setNegativeButtonText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDialogLayoutResource
				/// </java-name>
				public virtual int DialogLayoutResource
				{
						[Dot42.DexImport("getDialogLayoutResource", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDialogLayoutResource", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDialog
				/// </java-name>
				public virtual global::Android.App.Dialog Dialog
				{
						[Dot42.DexImport("getDialog", "()Landroid/app/Dialog;", AccessFlags = 1)]
						get{ return default(global::Android.App.Dialog); }
				}

		}

		/// <java-name>
		/// android/preference/EditTextPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/EditTextPreference", AccessFlags = 33)]
		public partial class EditTextPreference : global::Android.Preferences.DialogPreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public EditTextPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public EditTextPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public EditTextPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBindDialogView
				/// </java-name>
				[Dot42.DexImport("onBindDialogView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal override void OnBindDialogView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAddEditTextToDialogView
				/// </java-name>
				[Dot42.DexImport("onAddEditTextToDialogView", "(Landroid/view/View;Landroid/widget/EditText;)V", AccessFlags = 4)]
				protected internal virtual void OnAddEditTextToDialogView(global::Android.Views.View view, global::Android.Widget.EditText editText) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDialogClosed
				/// </java-name>
				[Dot42.DexImport("onDialogClosed", "(Z)V", AccessFlags = 4)]
				protected internal override void OnDialogClosed(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray typedArray, int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool boolean, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldDisableDependents
				/// </java-name>
				[Dot42.DexImport("shouldDisableDependents", "()Z", AccessFlags = 1)]
				public override bool ShouldDisableDependents() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EditTextPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				public virtual string Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setText", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getEditText
				/// </java-name>
				public virtual global::Android.Widget.EditText EditText
				{
						[Dot42.DexImport("getEditText", "()Landroid/widget/EditText;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.EditText); }
				}

		}

		/// <java-name>
		/// android/preference/ListPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/ListPreference", AccessFlags = 33)]
		public partial class ListPreference : global::Android.Preferences.DialogPreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ListPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ListPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEntries
				/// </java-name>
				[Dot42.DexImport("setEntries", "(I)V", AccessFlags = 1)]
				public virtual void SetEntries(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEntryValues
				/// </java-name>
				[Dot42.DexImport("setEntryValues", "(I)V", AccessFlags = 1)]
				public virtual void SetEntryValues(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setValueIndex
				/// </java-name>
				[Dot42.DexImport("setValueIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetValueIndex(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findIndexOfValue
				/// </java-name>
				[Dot42.DexImport("findIndexOfValue", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int FindIndexOfValue(string @string) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// onDialogClosed
				/// </java-name>
				[Dot42.DexImport("onDialogClosed", "(Z)V", AccessFlags = 4)]
				protected internal override void OnDialogClosed(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray typedArray, int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool boolean, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ListPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEntries
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence[] Entries
				{
						[Dot42.DexImport("getEntries", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence[]); }
						[Dot42.DexImport("setEntries", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getEntryValues
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence[] EntryValues
				{
						[Dot42.DexImport("getEntryValues", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence[]); }
						[Dot42.DexImport("setEntryValues", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSummary
				/// </java-name>
				public override global::Java.Lang.ICharSequence Summary
				{
						[Dot42.DexImport("getSummary", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setSummary", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public virtual string Value
				{
						[Dot42.DexImport("getValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setValue", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getEntry
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Entry
				{
						[Dot42.DexImport("getEntry", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

		}

		/// <java-name>
		/// android/preference/MultiSelectListPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/MultiSelectListPreference", AccessFlags = 33)]
		public partial class MultiSelectListPreference : global::Android.Preferences.DialogPreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public MultiSelectListPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MultiSelectListPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEntries
				/// </java-name>
				[Dot42.DexImport("setEntries", "(I)V", AccessFlags = 1)]
				public virtual void SetEntries(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEntryValues
				/// </java-name>
				[Dot42.DexImport("setEntryValues", "(I)V", AccessFlags = 1)]
				public virtual void SetEntryValues(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findIndexOfValue
				/// </java-name>
				[Dot42.DexImport("findIndexOfValue", "(Ljava/lang/String;)I", AccessFlags = 1)]
				public virtual int FindIndexOfValue(string @string) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// onDialogClosed
				/// </java-name>
				[Dot42.DexImport("onDialogClosed", "(Z)V", AccessFlags = 4)]
				protected internal override void OnDialogClosed(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray typedArray, int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool boolean, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MultiSelectListPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEntries
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence[] Entries
				{
						[Dot42.DexImport("getEntries", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence[]); }
						[Dot42.DexImport("setEntries", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getEntryValues
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence[] EntryValues
				{
						[Dot42.DexImport("getEntryValues", "()[Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence[]); }
						[Dot42.DexImport("setEntryValues", "([Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getValues
				/// </java-name>
				public virtual global::Java.Util.ISet<string> Values
				{
						[Dot42.DexImport("getValues", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
						[Dot42.DexImport("setValues", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
						set{ }
				}

		}

		/// <java-name>
		/// android/preference/Preference
		/// </java-name>
		[Dot42.DexImport("android/preference/Preference", AccessFlags = 33, Signature = "Ljava/lang/Object;Ljava/lang/Comparable<Landroid/preference/Preference;>;")]
		public partial class Preference : global::System.IComparable<global::Android.Preferences.Preference>
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_ORDER
				/// </java-name>
				[Dot42.DexImport("DEFAULT_ORDER", "I", AccessFlags = 25)]
				public const int DEFAULT_ORDER = 2147483647;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Preference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Preference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Preference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object OnGetDefaultValue(global::Android.Content.Res.TypedArray typedArray, int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// peekExtras
				/// </java-name>
				[Dot42.DexImport("peekExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle PeekExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(Landroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetView(global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View OnCreateView(global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onBindView
				/// </java-name>
				[Dot42.DexImport("onBindView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void OnBindView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1)]
				public virtual void SetTitle(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)V", AccessFlags = 1)]
				public virtual void SetIcon(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSummary
				/// </java-name>
				[Dot42.DexImport("setSummary", "(I)V", AccessFlags = 1)]
				public virtual void SetSummary(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal virtual void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldPersist
				/// </java-name>
				[Dot42.DexImport("shouldPersist", "()Z", AccessFlags = 4)]
				protected internal virtual bool ShouldPersist() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// callChangeListener
				/// </java-name>
				[Dot42.DexImport("callChangeListener", "(Ljava/lang/Object;)Z", AccessFlags = 4)]
				protected internal virtual bool CallChangeListener(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// shouldCommit
				/// </java-name>
				[Dot42.DexImport("shouldCommit", "()Z", AccessFlags = 1)]
				public virtual bool ShouldCommit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// compareTo
				/// </java-name>
				[Dot42.DexImport("compareTo", "(Landroid/preference/Preference;)I", AccessFlags = 1)]
				public virtual int CompareTo(global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// notifyChanged
				/// </java-name>
				[Dot42.DexImport("notifyChanged", "()V", AccessFlags = 4)]
				protected internal virtual void NotifyChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyHierarchyChanged
				/// </java-name>
				[Dot42.DexImport("notifyHierarchyChanged", "()V", AccessFlags = 4)]
				protected internal virtual void NotifyHierarchyChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToHierarchy
				/// </java-name>
				[Dot42.DexImport("onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V", AccessFlags = 4)]
				protected internal virtual void OnAttachedToHierarchy(global::Android.Preferences.PreferenceManager preferenceManager) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToActivity
				/// </java-name>
				[Dot42.DexImport("onAttachedToActivity", "()V", AccessFlags = 4)]
				protected internal virtual void OnAttachedToActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findPreferenceInHierarchy
				/// </java-name>
				[Dot42.DexImport("findPreferenceInHierarchy", "(Ljava/lang/String;)Landroid/preference/Preference;", AccessFlags = 4)]
				protected internal virtual global::Android.Preferences.Preference FindPreferenceInHierarchy(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.Preference);
				}

				/// <java-name>
				/// notifyDependencyChange
				/// </java-name>
				[Dot42.DexImport("notifyDependencyChange", "(Z)V", AccessFlags = 1)]
				public virtual void NotifyDependencyChange(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDependencyChanged
				/// </java-name>
				[Dot42.DexImport("onDependencyChanged", "(Landroid/preference/Preference;Z)V", AccessFlags = 1)]
				public virtual void OnDependencyChanged(global::Android.Preferences.Preference preference, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldDisableDependents
				/// </java-name>
				[Dot42.DexImport("shouldDisableDependents", "()Z", AccessFlags = 1)]
				public virtual bool ShouldDisableDependents() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPrepareForRemoval
				/// </java-name>
				[Dot42.DexImport("onPrepareForRemoval", "()V", AccessFlags = 4)]
				protected internal virtual void OnPrepareForRemoval() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultValue
				/// </java-name>
				[Dot42.DexImport("setDefaultValue", "(Ljava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetDefaultValue(object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal virtual void OnSetInitialValue(bool boolean, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// persistString
				/// </java-name>
				[Dot42.DexImport("persistString", "(Ljava/lang/String;)Z", AccessFlags = 4)]
				protected internal virtual bool PersistString(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPersistedString
				/// </java-name>
				[Dot42.DexImport("getPersistedString", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 4)]
				protected internal virtual string GetPersistedString(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// persistInt
				/// </java-name>
				[Dot42.DexImport("persistInt", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool PersistInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPersistedInt
				/// </java-name>
				[Dot42.DexImport("getPersistedInt", "(I)I", AccessFlags = 4)]
				protected internal virtual int GetPersistedInt(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// persistFloat
				/// </java-name>
				[Dot42.DexImport("persistFloat", "(F)Z", AccessFlags = 4)]
				protected internal virtual bool PersistFloat(float single) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPersistedFloat
				/// </java-name>
				[Dot42.DexImport("getPersistedFloat", "(F)F", AccessFlags = 4)]
				protected internal virtual float GetPersistedFloat(float single) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// persistLong
				/// </java-name>
				[Dot42.DexImport("persistLong", "(J)Z", AccessFlags = 4)]
				protected internal virtual bool PersistLong(long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPersistedLong
				/// </java-name>
				[Dot42.DexImport("getPersistedLong", "(J)J", AccessFlags = 4)]
				protected internal virtual long GetPersistedLong(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// persistBoolean
				/// </java-name>
				[Dot42.DexImport("persistBoolean", "(Z)Z", AccessFlags = 4)]
				protected internal virtual bool PersistBoolean(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPersistedBoolean
				/// </java-name>
				[Dot42.DexImport("getPersistedBoolean", "(Z)Z", AccessFlags = 4)]
				protected internal virtual bool GetPersistedBoolean(bool boolean) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// saveHierarchyState
				/// </java-name>
				[Dot42.DexImport("saveHierarchyState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SaveHierarchyState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// restoreHierarchyState
				/// </java-name>
				[Dot42.DexImport("restoreHierarchyState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void RestoreHierarchyState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal virtual void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Preference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getIntent
				/// </java-name>
				public virtual global::Android.Content.Intent Intent
				{
						[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Intent); }
						[Dot42.DexImport("setIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFragment
				/// </java-name>
				public virtual string Fragment
				{
						[Dot42.DexImport("getFragment", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setFragment", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public virtual global::Android.OS.Bundle Extras
				{
						[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Bundle); }
				}

				/// <java-name>
				/// getLayoutResource
				/// </java-name>
				public virtual int LayoutResource
				{
						[Dot42.DexImport("getLayoutResource", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setLayoutResource", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getWidgetLayoutResource
				/// </java-name>
				public virtual int WidgetLayoutResource
				{
						[Dot42.DexImport("getWidgetLayoutResource", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setWidgetLayoutResource", "(I)V", AccessFlags = 1)]
						set{ }
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
				/// getTitleRes
				/// </java-name>
				public virtual int TitleRes
				{
						[Dot42.DexImport("getTitleRes", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Title
				{
						[Dot42.DexImport("getTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getIcon
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Icon
				{
						[Dot42.DexImport("getIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSummary
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Summary
				{
						[Dot42.DexImport("getSummary", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setSummary", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public virtual bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSelectable
				/// </java-name>
				public virtual bool IsSelectable
				{
						[Dot42.DexImport("isSelectable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSelectable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getShouldDisableView
				/// </java-name>
				public virtual bool IsShouldDisableView
				{
						[Dot42.DexImport("getShouldDisableView", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setShouldDisableView", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getKey
				/// </java-name>
				public virtual string Key
				{
						[Dot42.DexImport("getKey", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setKey", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasKey
				/// </java-name>
				public virtual bool HasKey
				{
						[Dot42.DexImport("hasKey", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isPersistent
				/// </java-name>
				public virtual bool IsPersistent
				{
						[Dot42.DexImport("isPersistent", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPersistent", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOnPreferenceChangeListener
				/// </java-name>
				public virtual global::Android.Preferences.Preference.IOnPreferenceChangeListener OnPreferenceChangeListener
				{
						[Dot42.DexImport("getOnPreferenceChangeListener", "()Landroid/preference/Preference$OnPreferenceChangeListener;", AccessFlags = 1)]
						get{ return default(global::Android.Preferences.Preference.IOnPreferenceChangeListener); }
						[Dot42.DexImport("setOnPreferenceChangeListener", "(Landroid/preference/Preference$OnPreferenceChangeListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOnPreferenceClickListener
				/// </java-name>
				public virtual global::Android.Preferences.Preference.IOnPreferenceClickListener OnPreferenceClickListener
				{
						[Dot42.DexImport("getOnPreferenceClickListener", "()Landroid/preference/Preference$OnPreferenceClickListener;", AccessFlags = 1)]
						get{ return default(global::Android.Preferences.Preference.IOnPreferenceClickListener); }
						[Dot42.DexImport("setOnPreferenceClickListener", "(Landroid/preference/Preference$OnPreferenceClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public virtual global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				public virtual global::Android.Content.ISharedPreferences SharedPreferences
				{
						[Dot42.DexImport("getSharedPreferences", "()Landroid/content/SharedPreferences;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ISharedPreferences); }
				}

				/// <java-name>
				/// getEditor
				/// </java-name>
				public virtual global::Android.Content.ISharedPreferences_IEditor Editor
				{
						[Dot42.DexImport("getEditor", "()Landroid/content/SharedPreferences$Editor;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ISharedPreferences_IEditor); }
				}

				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				public virtual global::Android.Preferences.PreferenceManager PreferenceManager
				{
						[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
						get{ return default(global::Android.Preferences.PreferenceManager); }
				}

				/// <java-name>
				/// getDependency
				/// </java-name>
				public virtual string Dependency
				{
						[Dot42.DexImport("getDependency", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setDependency", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/preference/Preference$BaseSavedState
				/// </java-name>
				[Dot42.DexImport("android/preference/Preference$BaseSavedState", AccessFlags = 9)]
				public partial class BaseSavedState : global::Android.Views.AbsSavedState
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<BaseSavedState> CREATOR;
						[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public BaseSavedState(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
						public BaseSavedState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal BaseSavedState() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/preference/Preference$OnPreferenceClickListener
				/// </java-name>
				[Dot42.DexImport("android/preference/Preference$OnPreferenceClickListener", AccessFlags = 1545)]
				public partial interface IOnPreferenceClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPreferenceClick
						/// </java-name>
						[Dot42.DexImport("onPreferenceClick", "(Landroid/preference/Preference;)Z", AccessFlags = 1025)]
						bool OnPreferenceClick(global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/preference/Preference$OnPreferenceChangeListener
				/// </java-name>
				[Dot42.DexImport("android/preference/Preference$OnPreferenceChangeListener", AccessFlags = 1545)]
				public partial interface IOnPreferenceChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPreferenceChange
						/// </java-name>
						[Dot42.DexImport("onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z", AccessFlags = 1025)]
						bool OnPreferenceChange(global::Android.Preferences.Preference preference, object @object) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/preference/PreferenceActivity
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceActivity", AccessFlags = 1057)]
		public abstract partial class PreferenceActivity : global::Android.App.ListActivity, global::Android.Preferences.PreferenceFragment.IOnPreferenceStartFragmentCallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EXTRA_SHOW_FRAGMENT
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_FRAGMENT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_FRAGMENT = ":android:show_fragment";
				/// <java-name>
				/// EXTRA_SHOW_FRAGMENT_ARGUMENTS
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_FRAGMENT_ARGUMENTS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_FRAGMENT_ARGUMENTS = ":android:show_fragment_args";
				/// <java-name>
				/// EXTRA_SHOW_FRAGMENT_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_FRAGMENT_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_FRAGMENT_TITLE = ":android:show_fragment_title";
				/// <java-name>
				/// EXTRA_SHOW_FRAGMENT_SHORT_TITLE
				/// </java-name>
				[Dot42.DexImport("EXTRA_SHOW_FRAGMENT_SHORT_TITLE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_SHOW_FRAGMENT_SHORT_TITLE = ":android:show_fragment_short_title";
				/// <java-name>
				/// EXTRA_NO_HEADERS
				/// </java-name>
				[Dot42.DexImport("EXTRA_NO_HEADERS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_NO_HEADERS = ":android:no_headers";
				/// <java-name>
				/// HEADER_ID_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("HEADER_ID_UNDEFINED", "J", AccessFlags = 25)]
				public const long HEADER_ID_UNDEFINED = -1;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PreferenceActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onIsMultiPane
				/// </java-name>
				[Dot42.DexImport("onIsMultiPane", "()Z", AccessFlags = 1)]
				public virtual bool OnIsMultiPane() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onIsHidingHeaders
				/// </java-name>
				[Dot42.DexImport("onIsHidingHeaders", "()Z", AccessFlags = 1)]
				public virtual bool OnIsHidingHeaders() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGetInitialHeader
				/// </java-name>
				[Dot42.DexImport("onGetInitialHeader", "()Landroid/preference/PreferenceActivity$Header;", AccessFlags = 1)]
				public virtual global::Android.Preferences.PreferenceActivity.Header OnGetInitialHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.PreferenceActivity.Header);
				}

				/// <java-name>
				/// onGetNewHeader
				/// </java-name>
				[Dot42.DexImport("onGetNewHeader", "()Landroid/preference/PreferenceActivity$Header;", AccessFlags = 1)]
				public virtual global::Android.Preferences.PreferenceActivity.Header OnGetNewHeader() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.PreferenceActivity.Header);
				}

				/// <java-name>
				/// onBuildHeaders
				/// </java-name>
				[Dot42.DexImport("onBuildHeaders", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/preference/PreferenceActivity$Header;>;)V")]
				public virtual void OnBuildHeaders(global::Java.Util.IList<global::Android.Preferences.PreferenceActivity.Header> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateHeaders
				/// </java-name>
				[Dot42.DexImport("invalidateHeaders", "()V", AccessFlags = 1)]
				public virtual void InvalidateHeaders() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// loadHeadersFromResource
				/// </java-name>
				[Dot42.DexImport("loadHeadersFromResource", "(ILjava/util/List;)V", AccessFlags = 1, Signature = "(ILjava/util/List<Landroid/preference/PreferenceActivity$Header;>;)V")]
				public virtual void LoadHeadersFromResource(int int32, global::Java.Util.IList<global::Android.Preferences.PreferenceActivity.Header> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setListFooter
				/// </java-name>
				[Dot42.DexImport("setListFooter", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetListFooter(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 4)]
				protected internal override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 4)]
				protected internal override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)V", AccessFlags = 4)]
				protected internal override void OnActivityResult(int int32, int int321, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public override void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onListItemClick
				/// </java-name>
				[Dot42.DexImport("onListItemClick", "(Landroid/widget/ListView;Landroid/view/View;IJ)V", AccessFlags = 4)]
				protected internal override void OnListItemClick(global::Android.Widget.ListView listView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onHeaderClick
				/// </java-name>
				[Dot42.DexImport("onHeaderClick", "(Landroid/preference/PreferenceActivity$Header;I)V", AccessFlags = 1)]
				public virtual void OnHeaderClick(global::Android.Preferences.PreferenceActivity.Header header, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBuildStartFragmentIntent
				/// </java-name>
				[Dot42.DexImport("onBuildStartFragmentIntent", "(Ljava/lang/String;Landroid/os/Bundle;II)Landroid/content/Intent;", AccessFlags = 1)]
				public virtual global::Android.Content.Intent OnBuildStartFragmentIntent(string @string, global::Android.OS.Bundle bundle, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Intent);
				}

				/// <java-name>
				/// startWithFragment
				/// </java-name>
				[Dot42.DexImport("startWithFragment", "(Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Fragment;I)V", AccessFlags = 1)]
				public virtual void StartWithFragment(string @string, global::Android.OS.Bundle bundle, global::Android.App.Fragment fragment, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startWithFragment
				/// </java-name>
				[Dot42.DexImport("startWithFragment", "(Ljava/lang/String;Landroid/os/Bundle;Landroid/app/Fragment;III)V", AccessFlags = 1)]
				public virtual void StartWithFragment(string @string, global::Android.OS.Bundle bundle, global::Android.App.Fragment fragment, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showBreadCrumbs
				/// </java-name>
				[Dot42.DexImport("showBreadCrumbs", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void ShowBreadCrumbs(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setParentTitle
				/// </java-name>
				[Dot42.DexImport("setParentTitle", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/view/View$OnClickListen" +
    "er;)V", AccessFlags = 1)]
				public virtual void SetParentTitle(global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1, global::Android.Views.View.IOnClickListener onClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// switchToHeader
				/// </java-name>
				[Dot42.DexImport("switchToHeader", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SwitchToHeader(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// switchToHeader
				/// </java-name>
				[Dot42.DexImport("switchToHeader", "(Landroid/preference/PreferenceActivity$Header;)V", AccessFlags = 1)]
				public virtual void SwitchToHeader(global::Android.Preferences.PreferenceActivity.Header header) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPreferenceFragment
				/// </java-name>
				[Dot42.DexImport("startPreferenceFragment", "(Landroid/app/Fragment;Z)V", AccessFlags = 1)]
				public virtual void StartPreferenceFragment(global::Android.App.Fragment fragment, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startPreferencePanel
				/// </java-name>
				[Dot42.DexImport("startPreferencePanel", "(Ljava/lang/String;Landroid/os/Bundle;ILjava/lang/CharSequence;Landroid/app/Fragm" +
    "ent;I)V", AccessFlags = 1)]
				public virtual void StartPreferencePanel(string @string, global::Android.OS.Bundle bundle, int int32, global::Java.Lang.ICharSequence charSequence, global::Android.App.Fragment fragment, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finishPreferencePanel
				/// </java-name>
				[Dot42.DexImport("finishPreferencePanel", "(Landroid/app/Fragment;ILandroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void FinishPreferencePanel(global::Android.App.Fragment fragment, int int32, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPreferenceStartFragment
				/// </java-name>
				[Dot42.DexImport("onPreferenceStartFragment", "(Landroid/preference/PreferenceFragment;Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool OnPreferenceStartFragment(global::Android.Preferences.PreferenceFragment preferenceFragment, global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addPreferencesFromIntent
				/// </java-name>
				[Dot42.DexImport("addPreferencesFromIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void AddPreferencesFromIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPreferencesFromResource
				/// </java-name>
				[Dot42.DexImport("addPreferencesFromResource", "(I)V", AccessFlags = 1)]
				public virtual void AddPreferencesFromResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPreferenceTreeClick
				/// </java-name>
				[Dot42.DexImport("onPreferenceTreeClick", "(Landroid/preference/PreferenceScreen;Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool OnPreferenceTreeClick(global::Android.Preferences.PreferenceScreen preferenceScreen, global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// findPreference
				/// </java-name>
				[Dot42.DexImport("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preferences.Preference FindPreference(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.Preference);
				}

				/// <java-name>
				/// onNewIntent
				/// </java-name>
				[Dot42.DexImport("onNewIntent", "(Landroid/content/Intent;)V", AccessFlags = 4)]
				protected internal override void OnNewIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hasHeaders
				/// </java-name>
				public virtual bool HasHeaders
				{
						[Dot42.DexImport("hasHeaders", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMultiPane
				/// </java-name>
				public virtual bool IsMultiPane
				{
						[Dot42.DexImport("isMultiPane", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				public virtual global::Android.Preferences.PreferenceManager PreferenceManager
				{
						[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
						get{ return default(global::Android.Preferences.PreferenceManager); }
				}

				/// <java-name>
				/// getPreferenceScreen
				/// </java-name>
				public virtual global::Android.Preferences.PreferenceScreen PreferenceScreen
				{
						[Dot42.DexImport("getPreferenceScreen", "()Landroid/preference/PreferenceScreen;", AccessFlags = 1)]
						get{ return default(global::Android.Preferences.PreferenceScreen); }
						[Dot42.DexImport("setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/preference/PreferenceActivity$Header
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceActivity$Header", AccessFlags = 25)]
				public sealed partial class Header : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "J", AccessFlags = 1)]
						public long Id;
						/// <java-name>
						/// titleRes
						/// </java-name>
						[Dot42.DexImport("titleRes", "I", AccessFlags = 1)]
						public int TitleRes;
						/// <java-name>
						/// title
						/// </java-name>
						[Dot42.DexImport("title", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Title;
						/// <java-name>
						/// summaryRes
						/// </java-name>
						[Dot42.DexImport("summaryRes", "I", AccessFlags = 1)]
						public int SummaryRes;
						/// <java-name>
						/// summary
						/// </java-name>
						[Dot42.DexImport("summary", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Summary;
						/// <java-name>
						/// breadCrumbTitleRes
						/// </java-name>
						[Dot42.DexImport("breadCrumbTitleRes", "I", AccessFlags = 1)]
						public int BreadCrumbTitleRes;
						/// <java-name>
						/// breadCrumbTitle
						/// </java-name>
						[Dot42.DexImport("breadCrumbTitle", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence BreadCrumbTitle;
						/// <java-name>
						/// breadCrumbShortTitleRes
						/// </java-name>
						[Dot42.DexImport("breadCrumbShortTitleRes", "I", AccessFlags = 1)]
						public int BreadCrumbShortTitleRes;
						/// <java-name>
						/// breadCrumbShortTitle
						/// </java-name>
						[Dot42.DexImport("breadCrumbShortTitle", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence BreadCrumbShortTitle;
						/// <java-name>
						/// iconRes
						/// </java-name>
						[Dot42.DexImport("iconRes", "I", AccessFlags = 1)]
						public int IconRes;
						/// <java-name>
						/// fragment
						/// </java-name>
						[Dot42.DexImport("fragment", "Ljava/lang/String;", AccessFlags = 1)]
						public string Fragment;
						/// <java-name>
						/// fragmentArguments
						/// </java-name>
						[Dot42.DexImport("fragmentArguments", "Landroid/os/Bundle;", AccessFlags = 1)]
						public global::Android.OS.Bundle FragmentArguments;
						/// <java-name>
						/// intent
						/// </java-name>
						[Dot42.DexImport("intent", "Landroid/content/Intent;", AccessFlags = 1)]
						public global::Android.Content.Intent Intent;
						/// <java-name>
						/// extras
						/// </java-name>
						[Dot42.DexImport("extras", "Landroid/os/Bundle;", AccessFlags = 1)]
						public global::Android.OS.Bundle Extras;
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<Header> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Header() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getTitle
						/// </java-name>
						[Dot42.DexImport("getTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence GetTitle(global::Android.Content.Res.Resources resources) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <java-name>
						/// getSummary
						/// </java-name>
						[Dot42.DexImport("getSummary", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence GetSummary(global::Android.Content.Res.Resources resources) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <java-name>
						/// getBreadCrumbTitle
						/// </java-name>
						[Dot42.DexImport("getBreadCrumbTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence GetBreadCrumbTitle(global::Android.Content.Res.Resources resources) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <java-name>
						/// getBreadCrumbShortTitle
						/// </java-name>
						[Dot42.DexImport("getBreadCrumbShortTitle", "(Landroid/content/res/Resources;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence GetBreadCrumbShortTitle(global::Android.Content.Res.Resources resources) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

						/// <java-name>
						/// describeContents
						/// </java-name>
						[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
						public int DescribeContents() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readFromParcel
						/// </java-name>
						[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
						public void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/preference/PreferenceCategory
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceCategory", AccessFlags = 33)]
		public partial class PreferenceCategory : global::Android.Preferences.PreferenceGroup
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public PreferenceCategory(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public PreferenceCategory(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public PreferenceCategory(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPrepareAddPreference
				/// </java-name>
				[Dot42.DexImport("onPrepareAddPreference", "(Landroid/preference/Preference;)Z", AccessFlags = 4)]
				protected internal override bool OnPrepareAddPreference(global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PreferenceCategory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

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

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnCreate(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroi" +
    "d/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View OnCreateView(global::Android.Views.LayoutInflater layoutInflater, global::Android.Views.ViewGroup viewGroup, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onActivityCreated
				/// </java-name>
				[Dot42.DexImport("onActivityCreated", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnActivityCreated(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStart
				/// </java-name>
				[Dot42.DexImport("onStart", "()V", AccessFlags = 1)]
				public override void OnStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStop
				/// </java-name>
				[Dot42.DexImport("onStop", "()V", AccessFlags = 1)]
				public override void OnStop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroyView
				/// </java-name>
				[Dot42.DexImport("onDestroyView", "()V", AccessFlags = 1)]
				public override void OnDestroyView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public override void OnSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)V", AccessFlags = 1)]
				public override void OnActivityResult(int int32, int int321, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPreferencesFromIntent
				/// </java-name>
				[Dot42.DexImport("addPreferencesFromIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void AddPreferencesFromIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPreferencesFromResource
				/// </java-name>
				[Dot42.DexImport("addPreferencesFromResource", "(I)V", AccessFlags = 1)]
				public virtual void AddPreferencesFromResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPreferenceTreeClick
				/// </java-name>
				[Dot42.DexImport("onPreferenceTreeClick", "(Landroid/preference/PreferenceScreen;Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool OnPreferenceTreeClick(global::Android.Preferences.PreferenceScreen preferenceScreen, global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// findPreference
				/// </java-name>
				[Dot42.DexImport("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preferences.Preference FindPreference(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.Preference);
				}

				/// <java-name>
				/// getPreferenceManager
				/// </java-name>
				public virtual global::Android.Preferences.PreferenceManager PreferenceManager
				{
						[Dot42.DexImport("getPreferenceManager", "()Landroid/preference/PreferenceManager;", AccessFlags = 1)]
						get{ return default(global::Android.Preferences.PreferenceManager); }
				}

				/// <java-name>
				/// getPreferenceScreen
				/// </java-name>
				public virtual global::Android.Preferences.PreferenceScreen PreferenceScreen
				{
						[Dot42.DexImport("getPreferenceScreen", "()Landroid/preference/PreferenceScreen;", AccessFlags = 1)]
						get{ return default(global::Android.Preferences.PreferenceScreen); }
						[Dot42.DexImport("setPreferenceScreen", "(Landroid/preference/PreferenceScreen;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/preference/PreferenceFragment$OnPreferenceStartFragmentCallback
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceFragment$OnPreferenceStartFragmentCallback", AccessFlags = 1545)]
				public partial interface IOnPreferenceStartFragmentCallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPreferenceStartFragment
						/// </java-name>
						[Dot42.DexImport("onPreferenceStartFragment", "(Landroid/preference/PreferenceFragment;Landroid/preference/Preference;)Z", AccessFlags = 1025)]
						bool OnPreferenceStartFragment(global::Android.Preferences.PreferenceFragment preferenceFragment, global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/preference/PreferenceGroup
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceGroup", AccessFlags = 1057)]
		public abstract partial class PreferenceGroup : global::Android.Preferences.Preference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public PreferenceGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public PreferenceGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addItemFromInflater
				/// </java-name>
				[Dot42.DexImport("addItemFromInflater", "(Landroid/preference/Preference;)V", AccessFlags = 1)]
				public virtual void AddItemFromInflater(global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPreference
				/// </java-name>
				[Dot42.DexImport("getPreference", "(I)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preferences.Preference GetPreference(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.Preference);
				}

				/// <java-name>
				/// addPreference
				/// </java-name>
				[Dot42.DexImport("addPreference", "(Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool AddPreference(global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removePreference
				/// </java-name>
				[Dot42.DexImport("removePreference", "(Landroid/preference/Preference;)Z", AccessFlags = 1)]
				public virtual bool RemovePreference(global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAll
				/// </java-name>
				[Dot42.DexImport("removeAll", "()V", AccessFlags = 1)]
				public virtual void RemoveAll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPrepareAddPreference
				/// </java-name>
				[Dot42.DexImport("onPrepareAddPreference", "(Landroid/preference/Preference;)Z", AccessFlags = 4)]
				protected internal virtual bool OnPrepareAddPreference(global::Android.Preferences.Preference preference) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// findPreference
				/// </java-name>
				[Dot42.DexImport("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preferences.Preference FindPreference(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.Preference);
				}

				/// <java-name>
				/// onAttachedToActivity
				/// </java-name>
				[Dot42.DexImport("onAttachedToActivity", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToActivity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPrepareForRemoval
				/// </java-name>
				[Dot42.DexImport("onPrepareForRemoval", "()V", AccessFlags = 4)]
				protected internal override void OnPrepareForRemoval() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchSaveInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void DispatchSaveInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal virtual void DispatchRestoreInstanceState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PreferenceGroup() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isOrderingAsAdded
				/// </java-name>
				public virtual bool IsOrderingAsAdded
				{
						[Dot42.DexImport("isOrderingAsAdded", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setOrderingAsAdded", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPreferenceCount
				/// </java-name>
				public virtual int PreferenceCount
				{
						[Dot42.DexImport("getPreferenceCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isOnSameScreenAsChildren
				/// </java-name>
				protected internal virtual bool IsOnSameScreenAsChildren
				{
						[Dot42.DexImport("isOnSameScreenAsChildren", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/preference/PreferenceManager
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceManager", AccessFlags = 33)]
		public partial class PreferenceManager
 /* scope: __dot42__ */ 
		{
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
				public virtual global::Android.Preferences.PreferenceScreen CreatePreferenceScreen(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.PreferenceScreen);
				}

				/// <java-name>
				/// getDefaultSharedPreferences
				/// </java-name>
				[Dot42.DexImport("getDefaultSharedPreferences", "(Landroid/content/Context;)Landroid/content/SharedPreferences;", AccessFlags = 9)]
				public static global::Android.Content.ISharedPreferences GetDefaultSharedPreferences(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ISharedPreferences);
				}

				/// <java-name>
				/// findPreference
				/// </java-name>
				[Dot42.DexImport("findPreference", "(Ljava/lang/CharSequence;)Landroid/preference/Preference;", AccessFlags = 1)]
				public virtual global::Android.Preferences.Preference FindPreference(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Preferences.Preference);
				}

				/// <java-name>
				/// setDefaultValues
				/// </java-name>
				[Dot42.DexImport("setDefaultValues", "(Landroid/content/Context;IZ)V", AccessFlags = 9)]
				public static void SetDefaultValues(global::Android.Content.Context context, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDefaultValues
				/// </java-name>
				[Dot42.DexImport("setDefaultValues", "(Landroid/content/Context;Ljava/lang/String;IIZ)V", AccessFlags = 9)]
				public static void SetDefaultValues(global::Android.Content.Context context, string @string, int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSharedPreferencesName
				/// </java-name>
				public virtual string SharedPreferencesName
				{
						[Dot42.DexImport("getSharedPreferencesName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSharedPreferencesName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSharedPreferencesMode
				/// </java-name>
				public virtual int SharedPreferencesMode
				{
						[Dot42.DexImport("getSharedPreferencesMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSharedPreferencesMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSharedPreferences
				/// </java-name>
				public virtual global::Android.Content.ISharedPreferences SharedPreferences
				{
						[Dot42.DexImport("getSharedPreferences", "()Landroid/content/SharedPreferences;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ISharedPreferences); }
				}

				/// <java-name>
				/// android/preference/PreferenceManager$OnActivityDestroyListener
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceManager$OnActivityDestroyListener", AccessFlags = 1545)]
				public partial interface IOnActivityDestroyListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onActivityDestroy
						/// </java-name>
						[Dot42.DexImport("onActivityDestroy", "()V", AccessFlags = 1025)]
						void OnActivityDestroy() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/preference/PreferenceManager$OnActivityStopListener
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceManager$OnActivityStopListener", AccessFlags = 1545)]
				public partial interface IOnActivityStopListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onActivityStop
						/// </java-name>
						[Dot42.DexImport("onActivityStop", "()V", AccessFlags = 1025)]
						void OnActivityStop() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/preference/PreferenceManager$OnActivityResultListener
				/// </java-name>
				[Dot42.DexImport("android/preference/PreferenceManager$OnActivityResultListener", AccessFlags = 1545)]
				public partial interface IOnActivityResultListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onActivityResult
						/// </java-name>
						[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)Z", AccessFlags = 1025)]
						bool OnActivityResult(int int32, int int321, global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/preference/PreferenceScreen
		/// </java-name>
		[Dot42.DexImport("android/preference/PreferenceScreen", AccessFlags = 49)]
		public sealed partial class PreferenceScreen : global::Android.Preferences.PreferenceGroup, global::Android.Widget.AdapterView<object>.IOnItemClickListener, global::Android.Content.IDialogInterface_IOnDismissListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal PreferenceScreen() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateRootAdapter
				/// </java-name>
				[Dot42.DexImport("onCreateRootAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 4)]
				internal global::Android.Widget.IListAdapter OnCreateRootAdapter() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.IListAdapter);
				}

				/// <java-name>
				/// bind
				/// </java-name>
				[Dot42.DexImport("bind", "(Landroid/widget/ListView;)V", AccessFlags = 1)]
				public void Bind(global::Android.Widget.ListView listView) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal override void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDismiss
				/// </java-name>
				[Dot42.DexImport("onDismiss", "(Landroid/content/DialogInterface;)V", AccessFlags = 1)]
				public void OnDismiss(global::Android.Content.IDialogInterface dialogInterface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onItemClick
				/// </java-name>
				[Dot42.DexImport("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", AccessFlags = 1)]
				public void OnItemClick(global::Android.Widget.AdapterView<object> adapterView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRootAdapter
				/// </java-name>
				public global::Android.Widget.IListAdapter RootAdapter
				{
						[Dot42.DexImport("getRootAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
				}

				/// <java-name>
				/// getDialog
				/// </java-name>
				public global::Android.App.Dialog Dialog
				{
						[Dot42.DexImport("getDialog", "()Landroid/app/Dialog;", AccessFlags = 1)]
						get{ return default(global::Android.App.Dialog); }
				}

				/// <java-name>
				/// isOnSameScreenAsChildren
				/// </java-name>
				protected internal override bool IsOnSameScreenAsChildren
				{
						[Dot42.DexImport("isOnSameScreenAsChildren", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/preference/RingtonePreference
		/// </java-name>
		[Dot42.DexImport("android/preference/RingtonePreference", AccessFlags = 33)]
		public partial class RingtonePreference : global::Android.Preferences.Preference, global::Android.Preferences.PreferenceManager.IOnActivityResultListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public RingtonePreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RingtonePreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RingtonePreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal override void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPrepareRingtonePickerIntent
				/// </java-name>
				[Dot42.DexImport("onPrepareRingtonePickerIntent", "(Landroid/content/Intent;)V", AccessFlags = 4)]
				protected internal virtual void OnPrepareRingtonePickerIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveRingtone
				/// </java-name>
				[Dot42.DexImport("onSaveRingtone", "(Landroid/net/Uri;)V", AccessFlags = 4)]
				protected internal virtual void OnSaveRingtone(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreRingtone
				/// </java-name>
				[Dot42.DexImport("onRestoreRingtone", "()Landroid/net/Uri;", AccessFlags = 4)]
				protected internal virtual global::Android.Net.Uri OnRestoreRingtone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Net.Uri);
				}

				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray typedArray, int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool boolean, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToHierarchy
				/// </java-name>
				[Dot42.DexImport("onAttachedToHierarchy", "(Landroid/preference/PreferenceManager;)V", AccessFlags = 4)]
				protected internal override void OnAttachedToHierarchy(global::Android.Preferences.PreferenceManager preferenceManager) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActivityResult
				/// </java-name>
				[Dot42.DexImport("onActivityResult", "(IILandroid/content/Intent;)Z", AccessFlags = 1)]
				public virtual bool OnActivityResult(int int32, int int321, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RingtonePreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getRingtoneType
				/// </java-name>
				public virtual int RingtoneType
				{
						[Dot42.DexImport("getRingtoneType", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRingtoneType", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getShowDefault
				/// </java-name>
				public virtual bool IsShowDefault
				{
						[Dot42.DexImport("getShowDefault", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setShowDefault", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getShowSilent
				/// </java-name>
				public virtual bool IsShowSilent
				{
						[Dot42.DexImport("getShowSilent", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setShowSilent", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/preference/SwitchPreference
		/// </java-name>
		[Dot42.DexImport("android/preference/SwitchPreference", AccessFlags = 33)]
		public partial class SwitchPreference : global::Android.Preferences.TwoStatePreference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public SwitchPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public SwitchPreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public SwitchPreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBindView
				/// </java-name>
				[Dot42.DexImport("onBindView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal override void OnBindView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSwitchTextOn
				/// </java-name>
				[Dot42.DexImport("setSwitchTextOn", "(I)V", AccessFlags = 1)]
				public virtual void SetSwitchTextOn(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSwitchTextOff
				/// </java-name>
				[Dot42.DexImport("setSwitchTextOff", "(I)V", AccessFlags = 1)]
				public virtual void SetSwitchTextOff(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SwitchPreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSwitchTextOn
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence SwitchTextOn
				{
						[Dot42.DexImport("getSwitchTextOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setSwitchTextOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSwitchTextOff
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence SwitchTextOff
				{
						[Dot42.DexImport("getSwitchTextOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setSwitchTextOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/preference/TwoStatePreference
		/// </java-name>
		[Dot42.DexImport("android/preference/TwoStatePreference", AccessFlags = 1057)]
		public abstract partial class TwoStatePreference : global::Android.Preferences.Preference
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TwoStatePreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TwoStatePreference(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TwoStatePreference(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "()V", AccessFlags = 4)]
				protected internal override void OnClick() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldDisableDependents
				/// </java-name>
				[Dot42.DexImport("shouldDisableDependents", "()Z", AccessFlags = 1)]
				public override bool ShouldDisableDependents() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSummaryOn
				/// </java-name>
				[Dot42.DexImport("setSummaryOn", "(I)V", AccessFlags = 1)]
				public virtual void SetSummaryOn(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSummaryOff
				/// </java-name>
				[Dot42.DexImport("setSummaryOff", "(I)V", AccessFlags = 1)]
				public virtual void SetSummaryOff(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGetDefaultValue
				/// </java-name>
				[Dot42.DexImport("onGetDefaultValue", "(Landroid/content/res/TypedArray;I)Ljava/lang/Object;", AccessFlags = 4)]
				protected internal override object OnGetDefaultValue(global::Android.Content.Res.TypedArray typedArray, int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// onSetInitialValue
				/// </java-name>
				[Dot42.DexImport("onSetInitialValue", "(ZLjava/lang/Object;)V", AccessFlags = 4)]
				protected internal override void OnSetInitialValue(bool boolean, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal override void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TwoStatePreference() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isChecked
				/// </java-name>
				public virtual bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSummaryOn
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence SummaryOn
				{
						[Dot42.DexImport("getSummaryOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setSummaryOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSummaryOff
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence SummaryOff
				{
						[Dot42.DexImport("getSummaryOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setSummaryOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDisableDependentsState
				/// </java-name>
				public virtual bool IsDisableDependentsState
				{
						[Dot42.DexImport("getDisableDependentsState", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setDisableDependentsState", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

}
