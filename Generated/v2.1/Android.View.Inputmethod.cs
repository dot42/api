// Copyright (C) 2014 dot42
//
// Original filename: Android.View.Inputmethod.cs
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
namespace Android.View.Inputmethod
{
		/// <summary>
		/// <para>Information about text that has been extracted for use by an input method.</para><para>This contains information about a portion of the currently edited text, that the IME should display into its own interface while in extracted mode. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/ExtractedText
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/ExtractedText", AccessFlags = 33)]
		public partial class ExtractedText : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The text that has been extracted. </para>        
				/// </summary>
				/// <java-name>
				/// text
				/// </java-name>
				[Dot42.DexImport("text", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence Text;
				/// <summary>
				/// <para>The offset in the overall text at which the extracted text starts. </para>        
				/// </summary>
				/// <java-name>
				/// startOffset
				/// </java-name>
				[Dot42.DexImport("startOffset", "I", AccessFlags = 1)]
				public int StartOffset;
				/// <summary>
				/// <para>If the content is a report of a partial text change, this is the offset where the change starts and it runs until partialEndOffset. If the content is the full text, this field is -1. </para>        
				/// </summary>
				/// <java-name>
				/// partialStartOffset
				/// </java-name>
				[Dot42.DexImport("partialStartOffset", "I", AccessFlags = 1)]
				public int PartialStartOffset;
				/// <summary>
				/// <para>If the content is a report of a partial text change, this is the offset where the change ends. Note that the actual text may be larger or smaller than the difference between this and partialStartOffset, meaning a reduction or increase, respectively, in the total text. </para>        
				/// </summary>
				/// <java-name>
				/// partialEndOffset
				/// </java-name>
				[Dot42.DexImport("partialEndOffset", "I", AccessFlags = 1)]
				public int PartialEndOffset;
				/// <summary>
				/// <para>The offset where the selection currently starts within the extracted text. The real selection start position is at <b>startOffset</b>+<b>selectionStart</b>. </para>        
				/// </summary>
				/// <java-name>
				/// selectionStart
				/// </java-name>
				[Dot42.DexImport("selectionStart", "I", AccessFlags = 1)]
				public int SelectionStart;
				/// <summary>
				/// <para>The offset where the selection currently ends within the extracted text. The real selection end position is at <b>startOffset</b>+<b>selectionEnd</b>. </para>        
				/// </summary>
				/// <java-name>
				/// selectionEnd
				/// </java-name>
				[Dot42.DexImport("selectionEnd", "I", AccessFlags = 1)]
				public int SelectionEnd;
				/// <summary>
				/// <para>Bit for flags: set if the text being edited can only be on a single line. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SINGLE_LINE
				/// </java-name>
				[Dot42.DexImport("FLAG_SINGLE_LINE", "I", AccessFlags = 25)]
				public const int FLAG_SINGLE_LINE = 1;
				/// <summary>
				/// <para>Bit for flags: set if the editor is currently in selection mode.</para><para>This happens when a hardware keyboard with latched keys is attached and the shift key is currently latched. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SELECTING
				/// </java-name>
				[Dot42.DexImport("FLAG_SELECTING", "I", AccessFlags = 25)]
				public const int FLAG_SELECTING = 2;
				/// <summary>
				/// <para>Additional bit flags of information about the edited text. </para>        
				/// </summary>
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Inputmethod.ExtractedText> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExtractedText() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>This class is used to specify meta information of an input method. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputMethodInfo
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethodInfo", AccessFlags = 49)]
		public sealed partial class InputMethodInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Inputmethod.InputMethodInfo> CREATOR;
				/// <summary>
				/// <para>Constructor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V", AccessFlags = 1)]
				public InputMethodInfo(global::Android.Content.Context context, global::Android.Content.Pm.ResolveInfo service) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Temporary API for creating a built-in input method for test. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;)V" +
    "", AccessFlags = 1)]
				public InputMethodInfo(string packageName, string className, global::Java.Lang.ICharSequence label, string settingsActivity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a unique ID for this input method. The ID is generated from the package and class name implementing the method. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the .apk package that implements this input method. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the class name of the service component that implements this input method. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceName
				/// </java-name>
				[Dot42.DexImport("getServiceName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetServiceName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the raw information about the Service implementing this input method. Do not modify the returned object. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ServiceInfo GetServiceInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ServiceInfo);
				}

				/// <summary>
				/// <para>Return the component of the service that implements this input method. </para>        
				/// </summary>
				/// <java-name>
				/// getComponent
				/// </java-name>
				[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName GetComponent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <summary>
				/// <para>Load the user-displayed label for this input method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.Pm.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Load the user-displayed icon for this input method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawable.Drawable LoadIcon(global::Android.Content.Pm.PackageManager pm) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <summary>
				/// <para>Return the class name of an activity that provides a settings UI for the input method. You can launch this activity be starting it with an android.content.Intent whose action is MAIN and with an explicit android.content.ComponentName composed of getPackageName and the class name returned here.</para><para>A null will be returned if there is no settings activity associated with the input method. </para>        
				/// </summary>
				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetSettingsActivity() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Return the resource identifier of a resource inside of this input method's .apk that determines whether it should be considered a default input method for the system. </para>        
				/// </summary>
				/// <java-name>
				/// getIsDefaultResourceId
				/// </java-name>
				[Dot42.DexImport("getIsDefaultResourceId", "()I", AccessFlags = 1)]
				public int GetIsDefaultResourceId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Used to test whether the given parameter object is an InputMethodInfo and its Id is the same to this one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the given parameter object is an InputMethodInfo and its Id is the same to this one. </para>
				/// </returns>
				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object o) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InputMethodInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return a unique ID for this input method. The ID is generated from the package and class name implementing the method. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				public string Id
				{
				[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <summary>
				/// <para>Return the .apk package that implements this input method. </para>        
				/// </summary>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				}

				/// <summary>
				/// <para>Return the class name of the service component that implements this input method. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceName
				/// </java-name>
				public string ServiceName
				{
				[Dot42.DexImport("getServiceName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetServiceName(); }
				}

				/// <summary>
				/// <para>Return the raw information about the Service implementing this input method. Do not modify the returned object. </para>        
				/// </summary>
				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				public global::Android.Content.Pm.ServiceInfo ServiceInfo
				{
				[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
						get{ return GetServiceInfo(); }
				}

				/// <summary>
				/// <para>Return the component of the service that implements this input method. </para>        
				/// </summary>
				/// <java-name>
				/// getComponent
				/// </java-name>
				public global::Android.Content.ComponentName Component
				{
				[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return GetComponent(); }
				}

				/// <summary>
				/// <para>Return the class name of an activity that provides a settings UI for the input method. You can launch this activity be starting it with an android.content.Intent whose action is MAIN and with an explicit android.content.ComponentName composed of getPackageName and the class name returned here.</para><para>A null will be returned if there is no settings activity associated with the input method. </para>        
				/// </summary>
				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				public string SettingsActivity
				{
				[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSettingsActivity(); }
				}

				/// <summary>
				/// <para>Return the resource identifier of a resource inside of this input method's .apk that determines whether it should be considered a default input method for the system. </para>        
				/// </summary>
				/// <java-name>
				/// getIsDefaultResourceId
				/// </java-name>
				public int IsDefaultResourceId
				{
				[Dot42.DexImport("getIsDefaultResourceId", "()I", AccessFlags = 1)]
						get{ return GetIsDefaultResourceId(); }
				}

		}

		/// <summary>
		/// <para>The InputMethodSession interface provides the per-client functionality of InputMethod that is safe to expose to applications.</para><para>Applications will not normally use this interface themselves, instead relying on the standard interaction provided by android.widget.TextView and android.widget.EditText. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputMethodSession
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethodSession", AccessFlags = 1537)]
		public partial interface IInputMethodSession
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This method is called when the application would like to stop receiving text input. </para>        
				/// </summary>
				/// <java-name>
				/// finishInput
				/// </java-name>
				[Dot42.DexImport("finishInput", "()V", AccessFlags = 1025)]
				void FinishInput() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method is called when the selection or cursor in the current target input field has changed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateSelection
				/// </java-name>
				[Dot42.DexImport("updateSelection", "(IIIIII)V", AccessFlags = 1025)]
				void UpdateSelection(int oldSelStart, int oldSelEnd, int newSelStart, int newSelEnd, int candidatesStart, int candidatesEnd) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method is called when cursor location of the target input field has changed within its window. This is not normally called, but will only be reported if requested by the input method.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateCursor
				/// </java-name>
				[Dot42.DexImport("updateCursor", "(Landroid/graphics/Rect;)V", AccessFlags = 1025)]
				void UpdateCursor(global::Android.Graphics.Rect newCursor) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by a text editor that performs auto completion, to tell the input method about the completions it has available. This can be used by the input method to display them to the user to select the text to be inserted.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// displayCompletions
				/// </java-name>
				[Dot42.DexImport("displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1025)]
				void DisplayCompletions(global::Android.View.Inputmethod.CompletionInfo[] completions) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by a text editor to report its new extracted text when its contents change. This will only be called if the input method calls InputConnection.getExtractedText() with the option to report updates.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateExtractedText
				/// </java-name>
				[Dot42.DexImport("updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1025)]
				void UpdateExtractedText(int token, global::Android.View.Inputmethod.ExtractedText text) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method is called when a key is pressed. When done with the event, the implementation must call back on <b>callback</b> with its result.</para><para>If the input method wants to handle this event, return true, otherwise return false and the caller (i.e. the application) will handle the event.</para><para><para>#dispatchKeyUp </para><simplesectsep></simplesectsep><para>android.view.KeyEvent </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the input method wants to handle this event.</para>
				/// </returns>
				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallba" +
    "ck;)V", AccessFlags = 1025)]
				void DispatchKeyEvent(int seq, global::Android.View.KeyEvent @event, global::Android.View.Inputmethod.IInputMethodSession_IEventCallback callback) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method is called when there is a track ball event.</para><para>If the input method wants to handle this event, return true, otherwise return false and the caller (i.e. the application) will handle the event.</para><para><para>android.view.MotionEvent </para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the input method wants to handle this event.</para>
				/// </returns>
				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCal" +
    "lback;)V", AccessFlags = 1025)]
				void DispatchTrackballEvent(int seq, global::Android.View.MotionEvent @event, global::Android.View.Inputmethod.IInputMethodSession_IEventCallback callback) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Process a private command sent from the application to the input method. This can be used to provide domain-specific features that are only known between certain input methods and their clients.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// appPrivateCommand
				/// </java-name>
				[Dot42.DexImport("appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1025)]
				void AppPrivateCommand(string action, global::Android.Os.Bundle data) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Toggle the soft input window. Applications can toggle the state of the soft input window. </para>        
				/// </summary>
				/// <java-name>
				/// toggleSoftInput
				/// </java-name>
				[Dot42.DexImport("toggleSoftInput", "(II)V", AccessFlags = 1025)]
				void ToggleSoftInput(int showFlags, int hideFlags) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/inputmethod/InputMethodSession$EventCallback
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethodSession$EventCallback", AccessFlags = 1545)]
		public partial interface IInputMethodSession_IEventCallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// finishedEvent
				/// </java-name>
				[Dot42.DexImport("finishedEvent", "(IZ)V", AccessFlags = 1025)]
				void FinishedEvent(int seq, bool handled) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Wrapper class for proxying calls to another InputConnection. Subclass and have fun! </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputConnectionWrapper
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputConnectionWrapper", AccessFlags = 33)]
		public partial class InputConnectionWrapper : global::Android.View.Inputmethod.IInputConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/view/inputmethod/InputConnection;Z)V", AccessFlags = 1)]
				public InputConnectionWrapper(global::Android.View.Inputmethod.IInputConnection target, bool mutable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Change the target of the input connection. </para>        
				/// </summary>
				/// <java-name>
				/// setTarget
				/// </java-name>
				[Dot42.DexImport("setTarget", "(Landroid/view/inputmethod/InputConnection;)V", AccessFlags = 1)]
				public virtual void SetTarget(global::Android.View.Inputmethod.IInputConnection target) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get <b>n</b> characters of text before the current cursor position.</para><para>This method may fail either if the input connection has become invalid (such as its process crashing) or the editor is taking too long to respond with the text (it is given a couple seconds to return). In either case, null is returned. This method does not affect the text in the editor in any way, nor does it affect the selection or composing spans.</para><para>If GET_TEXT_WITH_STYLES is supplied as flags, the editor should return a android.text.SpannableString with all the spans set on the text.</para><para><b>IME authors:</b> please consider this will trigger an IPC round-trip that will take some time. Assume this method consumes a lot of time. Also, please keep in mind the Editor may choose to return less characters than requested even if they are available for performance reasons.</para><para><b>Editor authors:</b> please be careful of race conditions in implementing this call. An IME can make a change to the text and use this method right away; you need to make sure the returned value is consistent with the result of the latest edits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the text before the cursor position; the length of the returned text might be less than <b>n</b>. </para>
				/// </returns>
				/// <java-name>
				/// getTextBeforeCursor
				/// </java-name>
				[Dot42.DexImport("getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextBeforeCursor(int n, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Get <b>n</b> characters of text after the current cursor position.</para><para>This method may fail either if the input connection has become invalid (such as its process crashing) or the client is taking too long to respond with the text (it is given a couple seconds to return). In either case, null is returned.</para><para>This method does not affect the text in the editor in any way, nor does it affect the selection or composing spans.</para><para>If GET_TEXT_WITH_STYLES is supplied as flags, the editor should return a android.text.SpannableString with all the spans set on the text.</para><para><b>IME authors:</b> please consider this will trigger an IPC round-trip that will take some time. Assume this method consumes a lot of time.</para><para><b>Editor authors:</b> please be careful of race conditions in implementing this call. An IME can make a change to the text and use this method right away; you need to make sure the returned value is consistent with the result of the latest edits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the text after the cursor position; the length of the returned text might be less than <b>n</b>. </para>
				/// </returns>
				/// <java-name>
				/// getTextAfterCursor
				/// </java-name>
				[Dot42.DexImport("getTextAfterCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextAfterCursor(int n, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Retrieve the current capitalization mode in effect at the current cursor position in the text. See TextUtils.getCapsMode for more information.</para><para>This method may fail either if the input connection has become invalid (such as its process crashing) or the client is taking too long to respond with the text (it is given a couple seconds to return). In either case, 0 is returned.</para><para>This method does not affect the text in the editor in any way, nor does it affect the selection or composing spans.</para><para><b>Editor authors:</b> please be careful of race conditions in implementing this call. An IME can change the cursor position and use this method right away; you need to make sure the returned value is consistent with the results of the latest edits and changes to the cursor position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the caps mode flags that are in effect at the current cursor position. See TYPE_TEXT_FLAG_CAPS_* in android.text.InputType. </para>
				/// </returns>
				/// <java-name>
				/// getCursorCapsMode
				/// </java-name>
				[Dot42.DexImport("getCursorCapsMode", "(I)I", AccessFlags = 1)]
				public virtual int GetCursorCapsMode(int reqModes) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Retrieve the current text in the input connection's editor, and monitor for any changes to it. This function returns with the current text, and optionally the input connection can send updates to the input method when its text changes.</para><para>This method may fail either if the input connection has become invalid (such as its process crashing) or the client is taking too long to respond with the text (it is given a couple seconds to return). In either case, null is returned.</para><para>Editor authors: as a general rule, try to comply with the fields in <code>request</code> for how many chars to return, but if performance or convenience dictates otherwise, please feel free to do what is most appropriate for your case. Also, if the GET_EXTRACTED_TEXT_MONITOR flag is set, you should be calling InputMethodManager#updateExtractedText(View, int, ExtractedText) whenever you call InputMethodManager#updateSelection(View, int, int, int, int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an android.view.inputmethod.ExtractedText object describing the state of the text view and containing the extracted text itself, or null if the input connection is no longer valid of the editor can't comply with the request for some reason. </para>
				/// </returns>
				/// <java-name>
				/// getExtractedText
				/// </java-name>
				[Dot42.DexImport("getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/Extra" +
    "ctedText;", AccessFlags = 1)]
				public virtual global::Android.View.Inputmethod.ExtractedText GetExtractedText(global::Android.View.Inputmethod.ExtractedTextRequest request, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.ExtractedText);
				}

				/// <summary>
				/// <para>Delete <b>beforeLength</b> characters of text before the current cursor position, and delete <b>afterLength</b> characters of text after the current cursor position, excluding the selection. Before and after refer to the order of the characters in the string, not to their visual representation: this means you don't have to figure out the direction of the text and can just use the indices as-is.</para><para>The lengths are supplied in Java chars, not in code points or in glyphs.</para><para>Since this method only operates on text before and after the selection, it can't affect the contents of the selection. This may affect the composing span if the span includes characters that are to be deleted, but otherwise will not change it. If some characters in the composing span are deleted, the composing span will persist but get shortened by however many chars inside it have been removed.</para><para><b>IME authors:</b> please be careful not to delete only half of a surrogate pair. Also take care not to delete more characters than are in the editor, as that may have ill effects on the application. Calling this method will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on your service after the batch input is over.</para><para><b>Editor authors:</b> please be careful of race conditions in implementing this call. An IME can make a change to the text or change the selection position and use this method right away; you need to make sure the effects are consistent with the results of the latest edits. Also, although the IME should not send lengths bigger than the contents of the string, you should check the values for overflows and trim the indices to the size of the contents to avoid crashes. Since this changes the contents of the editor, you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// deleteSurroundingText
				/// </java-name>
				[Dot42.DexImport("deleteSurroundingText", "(II)Z", AccessFlags = 1)]
				public virtual bool DeleteSurroundingText(int beforeLength, int afterLength) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set composing text around the current cursor position with the given text, and set the new cursor position. Any composing text set previously will be removed automatically.</para><para>If there is any composing span currently active, all characters that it comprises are removed. The passed text is added in its place, and a composing span is added to this text. Finally, the cursor is moved to the location specified by <code>newCursorPosition</code>.</para><para>This is usually called by IMEs to add or remove or change characters in the composing span. Calling this method will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on the current IME after the batch input is over.</para><para><b>Editor authors:</b> please keep in mind the text may be very similar or completely different than what was in the composing span at call time, or there may not be a composing span at all. Please note that although it's not typical use, the string may be empty. Treat this normally, replacing the currently composing text with an empty string. Also, be careful with the cursor position. IMEs rely on this working exactly as described above. Since this changes the contents of the editor, you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress. Note that this method can set the cursor position on either edge of the composing text or entirely outside it, but the IME may also go on to move the cursor position to within the composing text in a subsequent call so you should make no assumption at all: the composing text and the selection are entirely independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// setComposingText
				/// </java-name>
				[Dot42.DexImport("setComposingText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1)]
				public virtual bool SetComposingText(global::Java.Lang.ICharSequence text, int newCursorPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Have the text editor finish whatever composing text is currently active. This simply leaves the text as-is, removing any special composing styling or other state that was around it. The cursor position remains unchanged.</para><para><b>IME authors:</b> be aware that this call may be expensive with some editors.</para><para><b>Editor authors:</b> please note that the cursor may be anywhere in the contents when this is called, including in the middle of the composing span or in a completely unrelated place. It must not move.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// finishComposingText
				/// </java-name>
				[Dot42.DexImport("finishComposingText", "()Z", AccessFlags = 1)]
				public virtual bool FinishComposingText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Commit text to the text box and set the new cursor position.</para><para>This method removes the contents of the currently composing text and replaces it with the passed CharSequence, and then moves the cursor according to <c> newCursorPosition </c> . This behaves like calling setComposingText(text, newCursorPosition) then finishComposingText().</para><para>Calling this method will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on the current IME after the batch input is over. <b>Editor authors</b>, for this to happen you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// commitText
				/// </java-name>
				[Dot42.DexImport("commitText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1)]
				public virtual bool CommitText(global::Java.Lang.ICharSequence text, int newCursorPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Commit a completion the user has selected from the possible ones previously reported to InputMethodSession#displayCompletions(CompletionInfo[]) or InputMethodManager#displayCompletions(View, CompletionInfo[]). This will result in the same behavior as if the user had selected the completion from the actual UI. In all other respects, this behaves like commitText(CharSequence, int).</para><para><b>IME authors:</b> please take care to send the same object that you received through android.inputmethodservice.InputMethodService#onDisplayCompletions(CompletionInfo[]). </para><para><b>Editor authors:</b> if you never call InputMethodSession#displayCompletions(CompletionInfo[]) or InputMethodManager#displayCompletions(View, CompletionInfo[]) then a well-behaved IME should never call this on your input connection, but be ready to deal with misbehaving IMEs without crashing.</para><para>Calling this method (with a valid CompletionInfo object) will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on the current IME after the batch input is over. <b>Editor authors</b>, for this to happen you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// commitCompletion
				/// </java-name>
				[Dot42.DexImport("commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", AccessFlags = 1)]
				public virtual bool CommitCompletion(global::Android.View.Inputmethod.CompletionInfo text) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Set the selection of the text editor. To set the cursor position, start and end should have the same value.</para><para>Since this moves the cursor, calling this method will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on the current IME after the batch input is over. <b>Editor authors</b>, for this to happen you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress.</para><para>This has no effect on the composing region which must stay unchanged. The order of start and end is not important. In effect, the region from start to end and the region from end to start is the same. Editor authors, be ready to accept a start that is greater than end.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(II)Z", AccessFlags = 1)]
				public virtual bool SetSelection(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Have the editor perform an action it has said it can do.</para><para>This is typically used by IMEs when the user presses the key associated with the action.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// performEditorAction
				/// </java-name>
				[Dot42.DexImport("performEditorAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformEditorAction(int editorAction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Perform a context menu action on the field. The given id may be one of: android.R.id#selectAll, android.R.id#startSelectingText, android.R.id#stopSelectingText, android.R.id#cut, android.R.id#copy, android.R.id#paste, android.R.id#copyUrl, or android.R.id#switchInputMethod </para>        
				/// </summary>
				/// <java-name>
				/// performContextMenuAction
				/// </java-name>
				[Dot42.DexImport("performContextMenuAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformContextMenuAction(int id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tell the editor that you are starting a batch of editor operations. The editor will try to avoid sending you updates about its state until endBatchEdit is called. Batch edits nest.</para><para><b>IME authors:</b> use this to avoid getting calls to android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) corresponding to intermediate state. Also, use this to avoid flickers that may arise from displaying intermediate state. Be sure to call endBatchEdit for each call to this, or you may block updates in the editor.</para><para><b>Editor authors:</b> while a batch edit is in progress, take care not to send updates to the input method and not to update the display. IMEs use this intensively to this effect. Also please note that batch edits need to nest correctly.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if a batch edit is now in progress, false otherwise. Since this method starts a batch edit, that means it will always return true unless the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// beginBatchEdit
				/// </java-name>
				[Dot42.DexImport("beginBatchEdit", "()Z", AccessFlags = 1)]
				public virtual bool BeginBatchEdit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Tell the editor that you are done with a batch edit previously initiated with beginBatchEdit. This ends the latest batch only.</para><para><b>IME authors:</b> make sure you call this exactly once for each call to beginBatchEdit.</para><para><b>Editor authors:</b> please be careful about batch edit nesting. Updates still to be held back until the end of the last batch edit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if there is still a batch edit in progress after closing the latest one (in other words, if the nesting count is &gt; 0), false otherwise or if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// endBatchEdit
				/// </java-name>
				[Dot42.DexImport("endBatchEdit", "()Z", AccessFlags = 1)]
				public virtual bool EndBatchEdit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Send a key event to the process that is currently attached through this input connection. The event will be dispatched like a normal key event, to the currently focused view; this generally is the view that is providing this InputConnection, but due to the asynchronous nature of this protocol that can not be guaranteed and the focus may have changed by the time the event is received.</para><para>This method can be used to send key events to the application. For example, an on-screen keyboard may use this method to simulate a hardware keyboard. There are three types of standard keyboards, numeric (12-key), predictive (20-key) and ALPHA (QWERTY). You can specify the keyboard type by specify the device id of the key event.</para><para>You will usually want to set the flag KeyEvent.FLAG_SOFT_KEYBOARD on all key event objects you give to this API; the flag will not be set for you.</para><para>Note that it's discouraged to send such key events in normal operation; this is mainly for use with android.text.InputType#TYPE_NULL type text fields. Use the commitText family of methods to send text to the application instead.</para><para><para>KeyEvent </para><simplesectsep></simplesectsep><para>KeyCharacterMap::NUMERIC </para><simplesectsep></simplesectsep><para>KeyCharacterMap::PREDICTIVE </para><simplesectsep></simplesectsep><para>KeyCharacterMap::ALPHA </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid.</para>
				/// </returns>
				/// <java-name>
				/// sendKeyEvent
				/// </java-name>
				[Dot42.DexImport("sendKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool SendKeyEvent(global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Clear the given meta key pressed states in the given input connection.</para><para>This can be used by the IME to clear the meta key states set by a hardware keyboard with latched meta keys, if the editor keeps track of these.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// clearMetaKeyStates
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyStates", "(I)Z", AccessFlags = 1)]
				public virtual bool ClearMetaKeyStates(int states) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called by the IME to tell the client when it switches between fullscreen and normal modes. This will normally be called for you by the standard implementation of android.inputmethodservice.InputMethodService.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// reportFullscreenMode
				/// </java-name>
				[Dot42.DexImport("reportFullscreenMode", "(Z)Z", AccessFlags = 1)]
				public virtual bool ReportFullscreenMode(bool enabled) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>API to send private commands from an input method to its connected editor. This can be used to provide domain-specific features that are only known between certain input methods and their clients. Note that because the InputConnection protocol is asynchronous, you have no way to get a result back or know if the client understood the command; you can use the information in EditorInfo to determine if a client supports a particular command.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the command was sent (whether or not the associated editor understood it), false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// performPrivateCommand
				/// </java-name>
				[Dot42.DexImport("performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool PerformPrivateCommand(string action, global::Android.Os.Bundle data) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InputConnectionWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Information about a single text completion that an editor has reported to an input method.</para><para>This class encapsulates a completion offered by an application that wants it to be presented to the user by the IME. Usually, apps present their completions directly in a scrolling list for example (UI developers will usually use or extend {<para>android.widget.AutoCompleteTextView} to implement this). However, in some cases, the editor may not be visible, as in the case in extract mode where the IME has taken over the full screen. In this case, the editor can choose to send their completions to the IME for display.</para></para><para>Most applications who want to send completions to an IME should use android.widget.AutoCompleteTextView as this class makes this process easy. In this case, the application would not have to deal directly with this class.</para><para>An application who implements its own editor and wants direct control over this would create an array of CompletionInfo objects, and send it to the IME using InputMethodManager#displayCompletions(View, CompletionInfo[]). The IME would present the completions however they see fit, and call back to the editor through InputConnection#commitCompletion(CompletionInfo). The application can then pick up the commit event by overriding android.widget.TextView#onCommitCompletion(CompletionInfo). </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/CompletionInfo
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/CompletionInfo", AccessFlags = 49)]
		public sealed partial class CompletionInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Inputmethod.CompletionInfo> CREATOR;
				/// <summary>
				/// <para>Create a simple completion with just text, no label.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JILjava/lang/CharSequence;)V", AccessFlags = 1)]
				public CompletionInfo(long id, int index, global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a full completion with both text and label. The text is what will get inserted into the editor, while the label is what the IME should display. If they are the same, use the version of the constructor without a `label' argument.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JILjava/lang/CharSequence;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public CompletionInfo(long id, int index, global::Java.Lang.ICharSequence text, global::Java.Lang.ICharSequence label) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the abstract identifier for this completion, typically corresponding to the id associated with it in the original adapter. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()J", AccessFlags = 1)]
				public long GetId() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Return the original position of this completion, typically corresponding to its position in the original adapter. </para>        
				/// </summary>
				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
				public int GetPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the actual text associated with this completion. This is the real text that will be inserted into the editor if the user selects it. </para>        
				/// </summary>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Return the user-visible label for the completion, or null if the plain text should be shown. If non-null, this will be what the user sees as the completion option instead of the actual text. </para>        
				/// </summary>
				/// <java-name>
				/// getLabel
				/// </java-name>
				[Dot42.DexImport("getLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetLabel() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
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
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CompletionInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return the abstract identifier for this completion, typically corresponding to the id associated with it in the original adapter. </para>        
				/// </summary>
				/// <java-name>
				/// getId
				/// </java-name>
				public long Id
				{
				[Dot42.DexImport("getId", "()J", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <summary>
				/// <para>Return the original position of this completion, typically corresponding to its position in the original adapter. </para>        
				/// </summary>
				/// <java-name>
				/// getPosition
				/// </java-name>
				public int Position
				{
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
						get{ return GetPosition(); }
				}

				/// <summary>
				/// <para>Return the actual text associated with this completion. This is the real text that will be inserted into the editor if the user selects it. </para>        
				/// </summary>
				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Lang.ICharSequence Text
				{
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetText(); }
				}

				/// <summary>
				/// <para>Return the user-visible label for the completion, or null if the plain text should be shown. If non-null, this will be what the user sees as the completion option instead of the actual text. </para>        
				/// </summary>
				/// <java-name>
				/// getLabel
				/// </java-name>
				public global::Java.Lang.ICharSequence Label
				{
				[Dot42.DexImport("getLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetLabel(); }
				}

		}

		/// <summary>
		/// <para>The InputMethod interface represents an input method which can generate key events and text, such as digital, email addresses, CJK characters, other language characters, and etc., while handling various input events, and send the text back to the application that requests text input. See InputMethodManager for more general information about the architecture.</para><para>Applications will not normally use this interface themselves, instead relying on the standard interaction provided by android.widget.TextView and android.widget.EditText.</para><para>Those implementing input methods should normally do so by deriving from InputMethodService or one of its subclasses. When implementing an input method, the service component containing it must also supply a SERVICE_META_DATA meta-data field, referencing an XML resource providing details about the input method. All input methods also must require that clients hold the android.Manifest.permission#BIND_INPUT_METHOD in order to interact with the service; if this is not required, the system will not use that input method, because it can not trust that it is not compromised.</para><para>The InputMethod interface is actually split into two parts: the interface here is the top-level interface to the input method, providing all access to it, which only the system can access (due to the BIND_INPUT_METHOD permission requirement). In addition its method createSession(android.view.inputmethod.InputMethod.SessionCallback) can be called to instantate a secondary InputMethodSession interface which is what clients use to communicate with the input method. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputMethod
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethod", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IInputMethodConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>This is the interface name that a service implementing an input method should say that it supports  that is, this is the action it uses for its intent filter. To be supported, the service must also require the android.Manifest.permission#BIND_INPUT_METHOD permission so that other applications can not abuse it. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.view.InputMethod";
				/// <summary>
				/// <para>Name under which an InputMethod service component publishes information about itself. This meta-data must reference an XML resource containing an <code>&lt;input-method&gt;</code> tag. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.view.im";
				/// <summary>
				/// <para>Flag for showSoftInput: this show has been explicitly requested by the user. If not set, the system has decided it may be a good idea to show the input method based on a navigation operation in the UI. </para>        
				/// </summary>
				/// <java-name>
				/// SHOW_EXPLICIT
				/// </java-name>
				[Dot42.DexImport("SHOW_EXPLICIT", "I", AccessFlags = 25)]
				public const int SHOW_EXPLICIT = 1;
				/// <summary>
				/// <para>Flag for showSoftInput: this show has been forced to happen by the user. If set, the input method should remain visible until deliberated dismissed by the user in its UI. </para>        
				/// </summary>
				/// <java-name>
				/// SHOW_FORCED
				/// </java-name>
				[Dot42.DexImport("SHOW_FORCED", "I", AccessFlags = 25)]
				public const int SHOW_FORCED = 2;
		}

		/// <summary>
		/// <para>The InputMethod interface represents an input method which can generate key events and text, such as digital, email addresses, CJK characters, other language characters, and etc., while handling various input events, and send the text back to the application that requests text input. See InputMethodManager for more general information about the architecture.</para><para>Applications will not normally use this interface themselves, instead relying on the standard interaction provided by android.widget.TextView and android.widget.EditText.</para><para>Those implementing input methods should normally do so by deriving from InputMethodService or one of its subclasses. When implementing an input method, the service component containing it must also supply a SERVICE_META_DATA meta-data field, referencing an XML resource providing details about the input method. All input methods also must require that clients hold the android.Manifest.permission#BIND_INPUT_METHOD in order to interact with the service; if this is not required, the system will not use that input method, because it can not trust that it is not compromised.</para><para>The InputMethod interface is actually split into two parts: the interface here is the top-level interface to the input method, providing all access to it, which only the system can access (due to the BIND_INPUT_METHOD permission requirement). In addition its method createSession(android.view.inputmethod.InputMethod.SessionCallback) can be called to instantate a secondary InputMethodSession interface which is what clients use to communicate with the input method. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputMethod
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethod", AccessFlags = 1537)]
		public partial interface IInputMethod
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Called first thing after an input method is created, this supplies a unique token for the session it has with the system service. It is needed to identify itself with the service to validate its operations. This token <b>must not</b> be passed to applications, since it grants special priviledges that should not be given to applications.</para><para>Note: to protect yourself from malicious clients, you should only accept the first token given to you. Any after that may come from the client. </para>        
				/// </summary>
				/// <java-name>
				/// attachToken
				/// </java-name>
				[Dot42.DexImport("attachToken", "(Landroid/os/IBinder;)V", AccessFlags = 1025)]
				void AttachToken(global::Android.Os.IBinder token) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Bind a new application environment in to the input method, so that it can later start and stop input processing. Typically this method is called when this input method is enabled in an application for the first time.</para><para><para>InputBinding </para><simplesectsep></simplesectsep><para>unbindInput() </para></para>        
				/// </summary>
				/// <java-name>
				/// bindInput
				/// </java-name>
				[Dot42.DexImport("bindInput", "(Landroid/view/inputmethod/InputBinding;)V", AccessFlags = 1025)]
				void BindInput(global::Android.View.Inputmethod.InputBinding binding) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Unbind an application environment, called when the information previously set by bindInput is no longer valid for this input method.</para><para>Typically this method is called when the application changes to be non-foreground. </para>        
				/// </summary>
				/// <java-name>
				/// unbindInput
				/// </java-name>
				[Dot42.DexImport("unbindInput", "()V", AccessFlags = 1025)]
				void UnbindInput() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method is called when the application starts to receive text and it is ready for this input method to process received events and send result text back to the application.</para><para><para>EditorInfo </para></para>        
				/// </summary>
				/// <java-name>
				/// startInput
				/// </java-name>
				[Dot42.DexImport("startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1025)]
				void StartInput(global::Android.View.Inputmethod.IInputConnection inputConnection, global::Android.View.Inputmethod.EditorInfo info) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method is called when the state of this input method needs to be reset.</para><para>Typically, this method is called when the input focus is moved from one text box to another.</para><para><para>EditorInfo </para></para>        
				/// </summary>
				/// <java-name>
				/// restartInput
				/// </java-name>
				[Dot42.DexImport("restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1025)]
				void RestartInput(global::Android.View.Inputmethod.IInputConnection inputConnection, global::Android.View.Inputmethod.EditorInfo attribute) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Create a new InputMethodSession that can be handed to client applications for interacting with the input method. You can later use revokeSession(InputMethodSession) to destroy the session so that it can no longer be used by any clients.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// createSession
				/// </java-name>
				[Dot42.DexImport("createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", AccessFlags = 1025)]
				void CreateSession(global::Android.View.Inputmethod.IInputMethod_ISessionCallback callback) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Control whether a particular input method session is active.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSessionEnabled
				/// </java-name>
				[Dot42.DexImport("setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V", AccessFlags = 1025)]
				void SetSessionEnabled(global::Android.View.Inputmethod.IInputMethodSession session, bool enabled) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Disable and destroy a session that was previously created with createSession(android.view.inputmethod.InputMethod.SessionCallback). After this call, the given session interface is no longer active and calls on it will fail.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// revokeSession
				/// </java-name>
				[Dot42.DexImport("revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", AccessFlags = 1025)]
				void RevokeSession(global::Android.View.Inputmethod.IInputMethodSession session) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Request that any soft input part of the input method be shown to the user.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// showSoftInput
				/// </java-name>
				[Dot42.DexImport("showSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1025)]
				void ShowSoftInput(int flags, global::Android.Os.ResultReceiver resultReceiver) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Request that any soft input part of the input method be hidden from the user. </para>        
				/// </summary>
				/// <java-name>
				/// hideSoftInput
				/// </java-name>
				[Dot42.DexImport("hideSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1025)]
				void HideSoftInput(int flags, global::Android.Os.ResultReceiver resultReceiver) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/inputmethod/InputMethod$SessionCallback
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethod$SessionCallback", AccessFlags = 1545)]
		public partial interface IInputMethod_ISessionCallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// sessionCreated
				/// </java-name>
				[Dot42.DexImport("sessionCreated", "(Landroid/view/inputmethod/InputMethodSession;)V", AccessFlags = 1025)]
				void SessionCreated(global::Android.View.Inputmethod.IInputMethodSession session) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>The InputConnection interface is the communication channel from an InputMethod back to the application that is receiving its input. It is used to perform such things as reading text around the cursor, committing text to the text box, and sending raw key events to the application.</para><para>Applications should never directly implement this interface, but instead subclass from BaseInputConnection. This will ensure that the application does not break when new methods are added to the interface.</para><para><h3>Implementing an IME or an editor</h3></para><para>Text input is the result of the synergy of two essential components: an Input Method Engine (IME) and an editor. The IME can be a software keyboard, a handwriting interface, an emoji palette, a speech-to-text engine, and so on. There are typically several IMEs installed on any given Android device. In Android, IMEs extend android.inputmethodservice.InputMethodService. For more information about how to create an IME, see the  guide.</para><para>The editor is the component that receives text and displays it. Typically, this is an android.widget.EditText instance, but some applications may choose to implement their own editor for various reasons. This is a large and complicated task, and an application that does this needs to make sure the behavior is consistent with standard EditText behavior in Android. An editor needs to interact with the IME, receiving commands through this InputConnection interface, and sending commands through android.view.inputmethod.InputMethodManager. An editor should start by implementing android.view.View#onCreateInputConnection(EditorInfo) to return its own input connection.</para><para>If you are implementing your own IME, you will need to call the methods in this interface to interact with the application. Be sure to test your IME with a wide range of applications, including browsers and rich text editors, as some may have peculiarities you need to deal with. Remember your IME may not be the only source of changes on the text, and try to be as conservative as possible in the data you send and as liberal as possible in the data you receive.</para><para>If you are implementing your own editor, you will probably need to provide your own subclass of BaseInputConnection to answer to the commands from IMEs. Please be sure to test your editor with as many IMEs as you can as their behavior can vary a lot. Also be sure to test with various languages, including CJK languages and right-to-left languages like Arabic, as these may have different input requirements. When in doubt about the behavior you should adopt for a particular call, please mimic the default TextView implementation in the latest Android version, and if you decide to drift from it, please consider carefully that inconsistencies in text edition behavior is almost universally felt as a bad thing by users.</para><para><h3>Cursors, selections and compositions</h3></para><para>In Android, the cursor and the selection are one and the same thing. A "cursor" is just the special case of a zero-sized selection. As such, this documentation uses them interchangeably. Any method acting "before the cursor" would act before the start of the selection if there is one, and any method acting "after the cursor" would act after the end of the selection.</para><para>An editor needs to be able to keep track of a currently "composing" region, like the standard edition widgets do. The composition is marked in a specific style: see android.text.Spanned#SPAN_COMPOSING. IMEs use this to help the user keep track of what part of the text they are currently focusing on, and interact with the editor using InputConnection#setComposingText(CharSequence, int), InputConnection#setComposingRegion(int, int) and InputConnection#finishComposingText(). The composing region and the selection are completely independent of each other, and the IME may use them however they see fit.</para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputConnection
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputConnection", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IInputConnectionConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Flag for use with getTextAfterCursor and getTextBeforeCursor to have style information returned along with the text. If not set, getTextAfterCursor sends only the raw text, without style or other spans. If set, it may return a complex CharSequence of both text and style spans. <b>Editor authors</b>: you should strive to send text with styles if possible, but it is not required. </para>        
				/// </summary>
				/// <java-name>
				/// GET_TEXT_WITH_STYLES
				/// </java-name>
				[Dot42.DexImport("GET_TEXT_WITH_STYLES", "I", AccessFlags = 25)]
				public const int GET_TEXT_WITH_STYLES = 1;
				/// <summary>
				/// <para>Flag for use with getExtractedText to indicate you would like to receive updates when the extracted text changes. </para>        
				/// </summary>
				/// <java-name>
				/// GET_EXTRACTED_TEXT_MONITOR
				/// </java-name>
				[Dot42.DexImport("GET_EXTRACTED_TEXT_MONITOR", "I", AccessFlags = 25)]
				public const int GET_EXTRACTED_TEXT_MONITOR = 1;
		}

		/// <summary>
		/// <para>The InputConnection interface is the communication channel from an InputMethod back to the application that is receiving its input. It is used to perform such things as reading text around the cursor, committing text to the text box, and sending raw key events to the application.</para><para>Applications should never directly implement this interface, but instead subclass from BaseInputConnection. This will ensure that the application does not break when new methods are added to the interface.</para><para><h3>Implementing an IME or an editor</h3></para><para>Text input is the result of the synergy of two essential components: an Input Method Engine (IME) and an editor. The IME can be a software keyboard, a handwriting interface, an emoji palette, a speech-to-text engine, and so on. There are typically several IMEs installed on any given Android device. In Android, IMEs extend android.inputmethodservice.InputMethodService. For more information about how to create an IME, see the  guide.</para><para>The editor is the component that receives text and displays it. Typically, this is an android.widget.EditText instance, but some applications may choose to implement their own editor for various reasons. This is a large and complicated task, and an application that does this needs to make sure the behavior is consistent with standard EditText behavior in Android. An editor needs to interact with the IME, receiving commands through this InputConnection interface, and sending commands through android.view.inputmethod.InputMethodManager. An editor should start by implementing android.view.View#onCreateInputConnection(EditorInfo) to return its own input connection.</para><para>If you are implementing your own IME, you will need to call the methods in this interface to interact with the application. Be sure to test your IME with a wide range of applications, including browsers and rich text editors, as some may have peculiarities you need to deal with. Remember your IME may not be the only source of changes on the text, and try to be as conservative as possible in the data you send and as liberal as possible in the data you receive.</para><para>If you are implementing your own editor, you will probably need to provide your own subclass of BaseInputConnection to answer to the commands from IMEs. Please be sure to test your editor with as many IMEs as you can as their behavior can vary a lot. Also be sure to test with various languages, including CJK languages and right-to-left languages like Arabic, as these may have different input requirements. When in doubt about the behavior you should adopt for a particular call, please mimic the default TextView implementation in the latest Android version, and if you decide to drift from it, please consider carefully that inconsistencies in text edition behavior is almost universally felt as a bad thing by users.</para><para><h3>Cursors, selections and compositions</h3></para><para>In Android, the cursor and the selection are one and the same thing. A "cursor" is just the special case of a zero-sized selection. As such, this documentation uses them interchangeably. Any method acting "before the cursor" would act before the start of the selection if there is one, and any method acting "after the cursor" would act after the end of the selection.</para><para>An editor needs to be able to keep track of a currently "composing" region, like the standard edition widgets do. The composition is marked in a specific style: see android.text.Spanned#SPAN_COMPOSING. IMEs use this to help the user keep track of what part of the text they are currently focusing on, and interact with the editor using InputConnection#setComposingText(CharSequence, int), InputConnection#setComposingRegion(int, int) and InputConnection#finishComposingText(). The composing region and the selection are completely independent of each other, and the IME may use them however they see fit.</para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputConnection
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputConnection", AccessFlags = 1537)]
		public partial interface IInputConnection
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Get <b>n</b> characters of text before the current cursor position.</para><para>This method may fail either if the input connection has become invalid (such as its process crashing) or the editor is taking too long to respond with the text (it is given a couple seconds to return). In either case, null is returned. This method does not affect the text in the editor in any way, nor does it affect the selection or composing spans.</para><para>If GET_TEXT_WITH_STYLES is supplied as flags, the editor should return a android.text.SpannableString with all the spans set on the text.</para><para><b>IME authors:</b> please consider this will trigger an IPC round-trip that will take some time. Assume this method consumes a lot of time. Also, please keep in mind the Editor may choose to return less characters than requested even if they are available for performance reasons.</para><para><b>Editor authors:</b> please be careful of race conditions in implementing this call. An IME can make a change to the text and use this method right away; you need to make sure the returned value is consistent with the result of the latest edits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the text before the cursor position; the length of the returned text might be less than <b>n</b>. </para>
				/// </returns>
				/// <java-name>
				/// getTextBeforeCursor
				/// </java-name>
				[Dot42.DexImport("getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence GetTextBeforeCursor(int n, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Get <b>n</b> characters of text after the current cursor position.</para><para>This method may fail either if the input connection has become invalid (such as its process crashing) or the client is taking too long to respond with the text (it is given a couple seconds to return). In either case, null is returned.</para><para>This method does not affect the text in the editor in any way, nor does it affect the selection or composing spans.</para><para>If GET_TEXT_WITH_STYLES is supplied as flags, the editor should return a android.text.SpannableString with all the spans set on the text.</para><para><b>IME authors:</b> please consider this will trigger an IPC round-trip that will take some time. Assume this method consumes a lot of time.</para><para><b>Editor authors:</b> please be careful of race conditions in implementing this call. An IME can make a change to the text and use this method right away; you need to make sure the returned value is consistent with the result of the latest edits.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the text after the cursor position; the length of the returned text might be less than <b>n</b>. </para>
				/// </returns>
				/// <java-name>
				/// getTextAfterCursor
				/// </java-name>
				[Dot42.DexImport("getTextAfterCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence GetTextAfterCursor(int n, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieve the current capitalization mode in effect at the current cursor position in the text. See TextUtils.getCapsMode for more information.</para><para>This method may fail either if the input connection has become invalid (such as its process crashing) or the client is taking too long to respond with the text (it is given a couple seconds to return). In either case, 0 is returned.</para><para>This method does not affect the text in the editor in any way, nor does it affect the selection or composing spans.</para><para><b>Editor authors:</b> please be careful of race conditions in implementing this call. An IME can change the cursor position and use this method right away; you need to make sure the returned value is consistent with the results of the latest edits and changes to the cursor position.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>the caps mode flags that are in effect at the current cursor position. See TYPE_TEXT_FLAG_CAPS_* in android.text.InputType. </para>
				/// </returns>
				/// <java-name>
				/// getCursorCapsMode
				/// </java-name>
				[Dot42.DexImport("getCursorCapsMode", "(I)I", AccessFlags = 1025)]
				int GetCursorCapsMode(int reqModes) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Retrieve the current text in the input connection's editor, and monitor for any changes to it. This function returns with the current text, and optionally the input connection can send updates to the input method when its text changes.</para><para>This method may fail either if the input connection has become invalid (such as its process crashing) or the client is taking too long to respond with the text (it is given a couple seconds to return). In either case, null is returned.</para><para>Editor authors: as a general rule, try to comply with the fields in <code>request</code> for how many chars to return, but if performance or convenience dictates otherwise, please feel free to do what is most appropriate for your case. Also, if the GET_EXTRACTED_TEXT_MONITOR flag is set, you should be calling InputMethodManager#updateExtractedText(View, int, ExtractedText) whenever you call InputMethodManager#updateSelection(View, int, int, int, int).</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>an android.view.inputmethod.ExtractedText object describing the state of the text view and containing the extracted text itself, or null if the input connection is no longer valid of the editor can't comply with the request for some reason. </para>
				/// </returns>
				/// <java-name>
				/// getExtractedText
				/// </java-name>
				[Dot42.DexImport("getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/Extra" +
    "ctedText;", AccessFlags = 1025)]
				global::Android.View.Inputmethod.ExtractedText GetExtractedText(global::Android.View.Inputmethod.ExtractedTextRequest request, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Delete <b>beforeLength</b> characters of text before the current cursor position, and delete <b>afterLength</b> characters of text after the current cursor position, excluding the selection. Before and after refer to the order of the characters in the string, not to their visual representation: this means you don't have to figure out the direction of the text and can just use the indices as-is.</para><para>The lengths are supplied in Java chars, not in code points or in glyphs.</para><para>Since this method only operates on text before and after the selection, it can't affect the contents of the selection. This may affect the composing span if the span includes characters that are to be deleted, but otherwise will not change it. If some characters in the composing span are deleted, the composing span will persist but get shortened by however many chars inside it have been removed.</para><para><b>IME authors:</b> please be careful not to delete only half of a surrogate pair. Also take care not to delete more characters than are in the editor, as that may have ill effects on the application. Calling this method will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on your service after the batch input is over.</para><para><b>Editor authors:</b> please be careful of race conditions in implementing this call. An IME can make a change to the text or change the selection position and use this method right away; you need to make sure the effects are consistent with the results of the latest edits. Also, although the IME should not send lengths bigger than the contents of the string, you should check the values for overflows and trim the indices to the size of the contents to avoid crashes. Since this changes the contents of the editor, you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// deleteSurroundingText
				/// </java-name>
				[Dot42.DexImport("deleteSurroundingText", "(II)Z", AccessFlags = 1025)]
				bool DeleteSurroundingText(int beforeLength, int afterLength) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set composing text around the current cursor position with the given text, and set the new cursor position. Any composing text set previously will be removed automatically.</para><para>If there is any composing span currently active, all characters that it comprises are removed. The passed text is added in its place, and a composing span is added to this text. Finally, the cursor is moved to the location specified by <code>newCursorPosition</code>.</para><para>This is usually called by IMEs to add or remove or change characters in the composing span. Calling this method will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on the current IME after the batch input is over.</para><para><b>Editor authors:</b> please keep in mind the text may be very similar or completely different than what was in the composing span at call time, or there may not be a composing span at all. Please note that although it's not typical use, the string may be empty. Treat this normally, replacing the currently composing text with an empty string. Also, be careful with the cursor position. IMEs rely on this working exactly as described above. Since this changes the contents of the editor, you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress. Note that this method can set the cursor position on either edge of the composing text or entirely outside it, but the IME may also go on to move the cursor position to within the composing text in a subsequent call so you should make no assumption at all: the composing text and the selection are entirely independent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// setComposingText
				/// </java-name>
				[Dot42.DexImport("setComposingText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1025)]
				bool SetComposingText(global::Java.Lang.ICharSequence text, int newCursorPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Have the text editor finish whatever composing text is currently active. This simply leaves the text as-is, removing any special composing styling or other state that was around it. The cursor position remains unchanged.</para><para><b>IME authors:</b> be aware that this call may be expensive with some editors.</para><para><b>Editor authors:</b> please note that the cursor may be anywhere in the contents when this is called, including in the middle of the composing span or in a completely unrelated place. It must not move.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// finishComposingText
				/// </java-name>
				[Dot42.DexImport("finishComposingText", "()Z", AccessFlags = 1025)]
				bool FinishComposingText() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Commit text to the text box and set the new cursor position.</para><para>This method removes the contents of the currently composing text and replaces it with the passed CharSequence, and then moves the cursor according to <c> newCursorPosition </c> . This behaves like calling setComposingText(text, newCursorPosition) then finishComposingText().</para><para>Calling this method will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on the current IME after the batch input is over. <b>Editor authors</b>, for this to happen you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// commitText
				/// </java-name>
				[Dot42.DexImport("commitText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1025)]
				bool CommitText(global::Java.Lang.ICharSequence text, int newCursorPosition) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Commit a completion the user has selected from the possible ones previously reported to InputMethodSession#displayCompletions(CompletionInfo[]) or InputMethodManager#displayCompletions(View, CompletionInfo[]). This will result in the same behavior as if the user had selected the completion from the actual UI. In all other respects, this behaves like commitText(CharSequence, int).</para><para><b>IME authors:</b> please take care to send the same object that you received through android.inputmethodservice.InputMethodService#onDisplayCompletions(CompletionInfo[]). </para><para><b>Editor authors:</b> if you never call InputMethodSession#displayCompletions(CompletionInfo[]) or InputMethodManager#displayCompletions(View, CompletionInfo[]) then a well-behaved IME should never call this on your input connection, but be ready to deal with misbehaving IMEs without crashing.</para><para>Calling this method (with a valid CompletionInfo object) will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on the current IME after the batch input is over. <b>Editor authors</b>, for this to happen you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// commitCompletion
				/// </java-name>
				[Dot42.DexImport("commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", AccessFlags = 1025)]
				bool CommitCompletion(global::Android.View.Inputmethod.CompletionInfo text) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Set the selection of the text editor. To set the cursor position, start and end should have the same value.</para><para>Since this moves the cursor, calling this method will cause the editor to call android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) on the current IME after the batch input is over. <b>Editor authors</b>, for this to happen you need to make the changes known to the input method by calling InputMethodManager#updateSelection(View, int, int, int, int), but be careful to wait until the batch edit is over if one is in progress.</para><para>This has no effect on the composing region which must stay unchanged. The order of start and end is not important. In effect, the region from start to end and the region from end to start is the same. Editor authors, be ready to accept a start that is greater than end.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(II)Z", AccessFlags = 1025)]
				bool SetSelection(int start, int end) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Have the editor perform an action it has said it can do.</para><para>This is typically used by IMEs when the user presses the key associated with the action.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// performEditorAction
				/// </java-name>
				[Dot42.DexImport("performEditorAction", "(I)Z", AccessFlags = 1025)]
				bool PerformEditorAction(int editorAction) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Perform a context menu action on the field. The given id may be one of: android.R.id#selectAll, android.R.id#startSelectingText, android.R.id#stopSelectingText, android.R.id#cut, android.R.id#copy, android.R.id#paste, android.R.id#copyUrl, or android.R.id#switchInputMethod </para>        
				/// </summary>
				/// <java-name>
				/// performContextMenuAction
				/// </java-name>
				[Dot42.DexImport("performContextMenuAction", "(I)Z", AccessFlags = 1025)]
				bool PerformContextMenuAction(int id) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tell the editor that you are starting a batch of editor operations. The editor will try to avoid sending you updates about its state until endBatchEdit is called. Batch edits nest.</para><para><b>IME authors:</b> use this to avoid getting calls to android.inputmethodservice.InputMethodService#onUpdateSelection(int, int, int, int, int, int) corresponding to intermediate state. Also, use this to avoid flickers that may arise from displaying intermediate state. Be sure to call endBatchEdit for each call to this, or you may block updates in the editor.</para><para><b>Editor authors:</b> while a batch edit is in progress, take care not to send updates to the input method and not to update the display. IMEs use this intensively to this effect. Also please note that batch edits need to nest correctly.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if a batch edit is now in progress, false otherwise. Since this method starts a batch edit, that means it will always return true unless the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// beginBatchEdit
				/// </java-name>
				[Dot42.DexImport("beginBatchEdit", "()Z", AccessFlags = 1025)]
				bool BeginBatchEdit() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Tell the editor that you are done with a batch edit previously initiated with beginBatchEdit. This ends the latest batch only.</para><para><b>IME authors:</b> make sure you call this exactly once for each call to beginBatchEdit.</para><para><b>Editor authors:</b> please be careful about batch edit nesting. Updates still to be held back until the end of the last batch edit.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if there is still a batch edit in progress after closing the latest one (in other words, if the nesting count is &gt; 0), false otherwise or if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// endBatchEdit
				/// </java-name>
				[Dot42.DexImport("endBatchEdit", "()Z", AccessFlags = 1025)]
				bool EndBatchEdit() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Send a key event to the process that is currently attached through this input connection. The event will be dispatched like a normal key event, to the currently focused view; this generally is the view that is providing this InputConnection, but due to the asynchronous nature of this protocol that can not be guaranteed and the focus may have changed by the time the event is received.</para><para>This method can be used to send key events to the application. For example, an on-screen keyboard may use this method to simulate a hardware keyboard. There are three types of standard keyboards, numeric (12-key), predictive (20-key) and ALPHA (QWERTY). You can specify the keyboard type by specify the device id of the key event.</para><para>You will usually want to set the flag KeyEvent.FLAG_SOFT_KEYBOARD on all key event objects you give to this API; the flag will not be set for you.</para><para>Note that it's discouraged to send such key events in normal operation; this is mainly for use with android.text.InputType#TYPE_NULL type text fields. Use the commitText family of methods to send text to the application instead.</para><para><para>KeyEvent </para><simplesectsep></simplesectsep><para>KeyCharacterMap::NUMERIC </para><simplesectsep></simplesectsep><para>KeyCharacterMap::PREDICTIVE </para><simplesectsep></simplesectsep><para>KeyCharacterMap::ALPHA </para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid.</para>
				/// </returns>
				/// <java-name>
				/// sendKeyEvent
				/// </java-name>
				[Dot42.DexImport("sendKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool SendKeyEvent(global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Clear the given meta key pressed states in the given input connection.</para><para>This can be used by the IME to clear the meta key states set by a hardware keyboard with latched meta keys, if the editor keeps track of these.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// clearMetaKeyStates
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyStates", "(I)Z", AccessFlags = 1025)]
				bool ClearMetaKeyStates(int states) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Called by the IME to tell the client when it switches between fullscreen and normal modes. This will normally be called for you by the standard implementation of android.inputmethodservice.InputMethodService.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true on success, false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// reportFullscreenMode
				/// </java-name>
				[Dot42.DexImport("reportFullscreenMode", "(Z)Z", AccessFlags = 1025)]
				bool ReportFullscreenMode(bool enabled) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>API to send private commands from an input method to its connected editor. This can be used to provide domain-specific features that are only known between certain input methods and their clients. Note that because the InputConnection protocol is asynchronous, you have no way to get a result back or know if the client understood the command; you can use the information in EditorInfo to determine if a client supports a particular command.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if the command was sent (whether or not the associated editor understood it), false if the input connection is no longer valid. </para>
				/// </returns>
				/// <java-name>
				/// performPrivateCommand
				/// </java-name>
				[Dot42.DexImport("performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1025)]
				bool PerformPrivateCommand(string action, global::Android.Os.Bundle data) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>Central system API to the overall input method framework (IMF) architecture, which arbitrates interaction between applications and the current input method. You can retrieve an instance of this interface with Context.getSystemService().</para><para>Topics covered here: <ol><li><para> </para></li><li><para> </para></li><li><para> </para></li><li><para> </para></li></ol></para><para> <h3>Architecture Overview</h3></para><para>There are three primary parties involved in the input method framework (IMF) architecture:</para><para><ul><li><para>The <b>input method manager</b> as expressed by this class is the central point of the system that manages interaction between all other parts. It is expressed as the client-side API here which exists in each application context and communicates with a global system service that manages the interaction across all processes. </para></li><li><para>An <b>input method (IME)</b> implements a particular interaction model allowing the user to generate text. The system binds to the current input method that is use, causing it to be created and run, and tells it when to hide and show its UI. Only one IME is running at a time. </para></li><li><para>Multiple <b>client applications</b> arbitrate with the input method manager for input focus and control over the state of the IME. Only one such client is ever active (working with the IME) at a time. </para></li></ul></para><para> <h3>Applications</h3></para><para>In most cases, applications that are using the standard android.widget.TextView or its subclasses will have little they need to do to work well with soft input methods. The main things you need to be aware of are:</para><para><ul><li><para>Properly set the android.R.attr#inputType in your editable text views, so that the input method will have enough context to help the user in entering text into them. </para></li><li><para>Deal well with losing screen space when the input method is displayed. Ideally an application should handle its window being resized smaller, but it can rely on the system performing panning of the window if needed. You should set the android.R.attr#windowSoftInputMode attribute on your activity or the corresponding values on windows you create to help the system determine whether to pan or resize (it will try to determine this automatically but may get it wrong). </para></li><li><para>You can also control the preferred soft input state (open, closed, etc) for your window using the same android.R.attr#windowSoftInputMode attribute. </para></li></ul></para><para>More finer-grained control is available through the APIs here to directly interact with the IMF and its IME  either showing or hiding the input area, letting the user pick an input method, etc.</para><para>For the rare people amongst us writing their own text editors, you will need to implement android.view.View#onCreateInputConnection to return a new instance of your own InputConnection interface allowing the IME to interact with your editor.</para><para> <h3>Input Methods</h3></para><para>An input method (IME) is implemented as a android.app.Service, typically deriving from android.inputmethodservice.InputMethodService. It must provide the core InputMethod interface, though this is normally handled by android.inputmethodservice.InputMethodService and implementors will only need to deal with the higher-level API there.</para><para>See the android.inputmethodservice.InputMethodService class for more information on implementing IMEs.</para><para> <h3>Security</h3></para><para>There are a lot of security issues associated with input methods, since they essentially have freedom to completely drive the UI and monitor everything the user enters. The Android input method framework also allows arbitrary third party IMEs, so care must be taken to restrict their selection and interactions.</para><para>Here are some key points about the security architecture behind the IMF:</para><para><ul><li><para></para><para>Only the system is allowed to directly access an IME's InputMethod interface, via the android.Manifest.permission#BIND_INPUT_METHOD permission. This is enforced in the system by not binding to an input method service that does not require this permission, so the system can guarantee no other untrusted clients are accessing the current input method outside of its control.</para><para></para><para></para></li><li><para></para><para>There may be many client processes of the IMF, but only one may be active at a time. The inactive clients can not interact with key parts of the IMF through the mechanisms described below.</para><para></para><para></para></li><li><para></para><para>Clients of an input method are only given access to its InputMethodSession interface. One instance of this interface is created for each client, and only calls from the session associated with the active client will be processed by the current IME. This is enforced by android.inputmethodservice.AbstractInputMethodService for normal IMEs, but must be explicitly handled by an IME that is customizing the raw InputMethodSession implementation.</para><para></para><para></para></li><li><para></para><para>Only the active client's InputConnection will accept operations. The IMF tells each client process whether it is active, and the framework enforces that in inactive processes calls on to the current InputConnection will be ignored. This ensures that the current IME can only deliver events and text edits to the UI that the user sees as being in focus.</para><para></para><para></para></li><li><para></para><para>An IME can never interact with an InputConnection while the screen is off. This is enforced by making all clients inactive while the screen is off, and prevents bad IMEs from driving the UI when the user can not be aware of its behavior.</para><para></para><para></para></li><li><para></para><para>A client application can ask that the system let the user pick a new IME, but can not programmatically switch to one itself. This avoids malicious applications from switching the user to their own IME, which remains running when the user navigates away to another application. An IME, on the other hand, <b>is</b> allowed to programmatically switch the system to another IME, since it already has full control of user input.</para><para></para><para></para></li><li><para></para><para>The user must explicitly enable a new IME in settings before they can switch to it, to confirm with the system that they know about it and want to make it available for use.</para><para></para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputMethodManager
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethodManager", AccessFlags = 49)]
		public sealed partial class InputMethodManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Flag for showSoftInput to indicate that this is an implicit request to show the input window, not as the result of a direct request by the user. The window may not be shown in this case. </para>        
				/// </summary>
				/// <java-name>
				/// SHOW_IMPLICIT
				/// </java-name>
				[Dot42.DexImport("SHOW_IMPLICIT", "I", AccessFlags = 25)]
				public const int SHOW_IMPLICIT = 1;
				/// <summary>
				/// <para>Flag for showSoftInput to indicate that the user has forced the input method open (such as by long-pressing menu) so it should not be closed until they explicitly do so. </para>        
				/// </summary>
				/// <java-name>
				/// SHOW_FORCED
				/// </java-name>
				[Dot42.DexImport("SHOW_FORCED", "I", AccessFlags = 25)]
				public const int SHOW_FORCED = 2;
				/// <summary>
				/// <para>Flag for the ResultReceiver result code from showSoftInput(View, int, ResultReceiver) and hideSoftInputFromWindow(IBinder, int, ResultReceiver): the state of the soft input window was unchanged and remains shown. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_UNCHANGED_SHOWN
				/// </java-name>
				[Dot42.DexImport("RESULT_UNCHANGED_SHOWN", "I", AccessFlags = 25)]
				public const int RESULT_UNCHANGED_SHOWN = 0;
				/// <summary>
				/// <para>Flag for the ResultReceiver result code from showSoftInput(View, int, ResultReceiver) and hideSoftInputFromWindow(IBinder, int, ResultReceiver): the state of the soft input window was unchanged and remains hidden. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_UNCHANGED_HIDDEN
				/// </java-name>
				[Dot42.DexImport("RESULT_UNCHANGED_HIDDEN", "I", AccessFlags = 25)]
				public const int RESULT_UNCHANGED_HIDDEN = 1;
				/// <summary>
				/// <para>Flag for the ResultReceiver result code from showSoftInput(View, int, ResultReceiver) and hideSoftInputFromWindow(IBinder, int, ResultReceiver): the state of the soft input window changed from hidden to shown. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_SHOWN
				/// </java-name>
				[Dot42.DexImport("RESULT_SHOWN", "I", AccessFlags = 25)]
				public const int RESULT_SHOWN = 2;
				/// <summary>
				/// <para>Flag for the ResultReceiver result code from showSoftInput(View, int, ResultReceiver) and hideSoftInputFromWindow(IBinder, int, ResultReceiver): the state of the soft input window changed from shown to hidden. </para>        
				/// </summary>
				/// <java-name>
				/// RESULT_HIDDEN
				/// </java-name>
				[Dot42.DexImport("RESULT_HIDDEN", "I", AccessFlags = 25)]
				public const int RESULT_HIDDEN = 3;
				/// <summary>
				/// <para>Flag for hideSoftInputFromWindow to indicate that the soft input window should only be hidden if it was not explicitly shown by the user. </para>        
				/// </summary>
				/// <java-name>
				/// HIDE_IMPLICIT_ONLY
				/// </java-name>
				[Dot42.DexImport("HIDE_IMPLICIT_ONLY", "I", AccessFlags = 25)]
				public const int HIDE_IMPLICIT_ONLY = 1;
				/// <summary>
				/// <para>Flag for hideSoftInputFromWindow to indicate that the soft input window should normally be hidden, unless it was originally shown with SHOW_FORCED. </para>        
				/// </summary>
				/// <java-name>
				/// HIDE_NOT_ALWAYS
				/// </java-name>
				[Dot42.DexImport("HIDE_NOT_ALWAYS", "I", AccessFlags = 25)]
				public const int HIDE_NOT_ALWAYS = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InputMethodManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputMethodList
				/// </java-name>
				[Dot42.DexImport("getInputMethodList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/inputmethod/InputMethodInfo;>;")]
				public global::Java.Util.IList<global::Android.View.Inputmethod.InputMethodInfo> GetInputMethodList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.View.Inputmethod.InputMethodInfo>);
				}

				/// <java-name>
				/// getEnabledInputMethodList
				/// </java-name>
				[Dot42.DexImport("getEnabledInputMethodList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/inputmethod/InputMethodInfo;>;")]
				public global::Java.Util.IList<global::Android.View.Inputmethod.InputMethodInfo> GetEnabledInputMethodList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.View.Inputmethod.InputMethodInfo>);
				}

				/// <java-name>
				/// showStatusIcon
				/// </java-name>
				[Dot42.DexImport("showStatusIcon", "(Landroid/os/IBinder;Ljava/lang/String;I)V", AccessFlags = 1)]
				public void ShowStatusIcon(global::Android.Os.IBinder imeToken, string packageName, int iconId) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hideStatusIcon
				/// </java-name>
				[Dot42.DexImport("hideStatusIcon", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
				public void HideStatusIcon(global::Android.Os.IBinder imeToken) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Allows you to discover whether the attached input method is running in fullscreen mode. Return true if it is fullscreen, entirely covering your UI, else returns false. </para>        
				/// </summary>
				/// <java-name>
				/// isFullscreenMode
				/// </java-name>
				[Dot42.DexImport("isFullscreenMode", "()Z", AccessFlags = 1)]
				public bool IsFullscreenMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return true if the given view is the currently active view for the input method. </para>        
				/// </summary>
				/// <java-name>
				/// isActive
				/// </java-name>
				[Dot42.DexImport("isActive", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public bool IsActive(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return true if any view is currently active in the input method. </para>        
				/// </summary>
				/// <java-name>
				/// isActive
				/// </java-name>
				[Dot42.DexImport("isActive", "()Z", AccessFlags = 1)]
				public bool IsActive() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return true if the currently served view is accepting full text edits. If false, it has no input connection, so can only handle raw key events. </para>        
				/// </summary>
				/// <java-name>
				/// isAcceptingText
				/// </java-name>
				[Dot42.DexImport("isAcceptingText", "()Z", AccessFlags = 1)]
				public bool IsAcceptingText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// displayCompletions
				/// </java-name>
				[Dot42.DexImport("displayCompletions", "(Landroid/view/View;[Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
				public void DisplayCompletions(global::Android.View.View view, global::Android.View.Inputmethod.CompletionInfo[] completions) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateExtractedText
				/// </java-name>
				[Dot42.DexImport("updateExtractedText", "(Landroid/view/View;ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
				public void UpdateExtractedText(global::Android.View.View view, int token, global::Android.View.Inputmethod.ExtractedText text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Synonym for showSoftInput(View, int, ResultReceiver) without a result receiver: explicitly request that the current input method's soft input area be shown to the user, if needed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// showSoftInput
				/// </java-name>
				[Dot42.DexImport("showSoftInput", "(Landroid/view/View;I)Z", AccessFlags = 1)]
				public bool ShowSoftInput(global::Android.View.View view, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Explicitly request that the current input method's soft input area be shown to the user, if needed. Call this if the user interacts with your view in such a way that they have expressed they would like to start performing input into it.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// showSoftInput
				/// </java-name>
				[Dot42.DexImport("showSoftInput", "(Landroid/view/View;ILandroid/os/ResultReceiver;)Z", AccessFlags = 1)]
				public bool ShowSoftInput(global::Android.View.View view, int flags, global::Android.Os.ResultReceiver resultReceiver) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Synonym for hideSoftInputFromWindow(IBinder, int, ResultReceiver) without a result: request to hide the soft input window from the context of the window that is currently accepting input.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// hideSoftInputFromWindow
				/// </java-name>
				[Dot42.DexImport("hideSoftInputFromWindow", "(Landroid/os/IBinder;I)Z", AccessFlags = 1)]
				public bool HideSoftInputFromWindow(global::Android.Os.IBinder windowToken, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Request to hide the soft input window from the context of the window that is currently accepting input. This should be called as a result of the user doing some actually than fairly explicitly requests to have the input window hidden.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// hideSoftInputFromWindow
				/// </java-name>
				[Dot42.DexImport("hideSoftInputFromWindow", "(Landroid/os/IBinder;ILandroid/os/ResultReceiver;)Z", AccessFlags = 1)]
				public bool HideSoftInputFromWindow(global::Android.Os.IBinder windowToken, int flags, global::Android.Os.ResultReceiver resultReceiver) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>This method toggles the input method window display. If the input window is already displayed, it gets hidden. If not the input window will be displayed. </para>        
				/// </summary>
				/// <java-name>
				/// toggleSoftInputFromWindow
				/// </java-name>
				[Dot42.DexImport("toggleSoftInputFromWindow", "(Landroid/os/IBinder;II)V", AccessFlags = 1)]
				public void ToggleSoftInputFromWindow(global::Android.Os.IBinder windowToken, int showFlags, int hideFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toggleSoftInput
				/// </java-name>
				[Dot42.DexImport("toggleSoftInput", "(II)V", AccessFlags = 1)]
				public void ToggleSoftInput(int showFlags, int hideFlags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>If the input method is currently connected to the given view, restart it with its new contents. You should call this when the text within your view changes outside of the normal input method or key input flow, such as when an application calls TextView.setText().</para><para></para>        
				/// </summary>
				/// <java-name>
				/// restartInput
				/// </java-name>
				[Dot42.DexImport("restartInput", "(Landroid/view/View;)V", AccessFlags = 1)]
				public void RestartInput(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Report the current selection range. </para>        
				/// </summary>
				/// <java-name>
				/// updateSelection
				/// </java-name>
				[Dot42.DexImport("updateSelection", "(Landroid/view/View;IIII)V", AccessFlags = 1)]
				public void UpdateSelection(global::Android.View.View view, int selStart, int selEnd, int candidatesStart, int candidatesEnd) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if the current input method wants to watch the location of the input editor's cursor in its window. </para>        
				/// </summary>
				/// <java-name>
				/// isWatchingCursor
				/// </java-name>
				[Dot42.DexImport("isWatchingCursor", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public bool IsWatchingCursor(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Report the current cursor location in its window. </para>        
				/// </summary>
				/// <java-name>
				/// updateCursor
				/// </java-name>
				[Dot42.DexImport("updateCursor", "(Landroid/view/View;IIII)V", AccessFlags = 1)]
				public void UpdateCursor(global::Android.View.View view, int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Call InputMethodSession.appPrivateCommand() on the current Input Method. </para>        
				/// </summary>
				/// <java-name>
				/// sendAppPrivateCommand
				/// </java-name>
				[Dot42.DexImport("sendAppPrivateCommand", "(Landroid/view/View;Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public void SendAppPrivateCommand(global::Android.View.View view, string action, global::Android.Os.Bundle data) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Force switch to a new input method component. This can only be called from an application or a service which has a token of the currently active input method. </para>        
				/// </summary>
				/// <java-name>
				/// setInputMethod
				/// </java-name>
				[Dot42.DexImport("setInputMethod", "(Landroid/os/IBinder;Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetInputMethod(global::Android.Os.IBinder token, string id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Close/hide the input method's soft input area, so the user no longer sees it or can interact with it. This can only be called from the currently active input method, as validated by the given token.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// hideSoftInputFromInputMethod
				/// </java-name>
				[Dot42.DexImport("hideSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V", AccessFlags = 1)]
				public void HideSoftInputFromInputMethod(global::Android.Os.IBinder token, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Show the input method's soft input area, so the user sees the input method window and can interact with it. This can only be called from the currently active input method, as validated by the given token.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// showSoftInputFromInputMethod
				/// </java-name>
				[Dot42.DexImport("showSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V", AccessFlags = 1)]
				public void ShowSoftInputFromInputMethod(global::Android.Os.IBinder token, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showInputMethodPicker
				/// </java-name>
				[Dot42.DexImport("showInputMethodPicker", "()V", AccessFlags = 1)]
				public void ShowInputMethodPicker() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputMethodList
				/// </java-name>
				public global::Java.Util.IList<global::Android.View.Inputmethod.InputMethodInfo> InputMethodList
				{
				[Dot42.DexImport("getInputMethodList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/inputmethod/InputMethodInfo;>;")]
						get{ return GetInputMethodList(); }
				}

				/// <java-name>
				/// getEnabledInputMethodList
				/// </java-name>
				public global::Java.Util.IList<global::Android.View.Inputmethod.InputMethodInfo> EnabledInputMethodList
				{
				[Dot42.DexImport("getEnabledInputMethodList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/inputmethod/InputMethodInfo;>;")]
						get{ return GetEnabledInputMethodList(); }
				}

		}

		/// <summary>
		/// <para>Information given to an InputMethod about a client connecting to it. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/InputBinding
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputBinding", AccessFlags = 49)]
		public sealed partial class InputBinding : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Inputmethod.InputBinding> CREATOR;
				/// <summary>
				/// <para>Constructor.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/os/IBinder;II)V", AccessFlags = 1)]
				public InputBinding(global::Android.View.Inputmethod.IInputConnection conn, global::Android.Os.IBinder connToken, int uid, int pid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Constructor from an existing InputBinding taking a new local input connection interface.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/InputBinding" +
    ";)V", AccessFlags = 1)]
				public InputBinding(global::Android.View.Inputmethod.IInputConnection conn, global::Android.View.Inputmethod.InputBinding binding) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the connection for interacting back with the application. </para>        
				/// </summary>
				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "()Landroid/view/inputmethod/InputConnection;", AccessFlags = 1)]
				public global::Android.View.Inputmethod.IInputConnection GetConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.IInputConnection);
				}

				/// <summary>
				/// <para>Return the token for the connection back to the application. You can not use this directly, it must be converted to a InputConnection for you. </para>        
				/// </summary>
				/// <java-name>
				/// getConnectionToken
				/// </java-name>
				[Dot42.DexImport("getConnectionToken", "()Landroid/os/IBinder;", AccessFlags = 1)]
				public global::Android.Os.IBinder GetConnectionToken() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <summary>
				/// <para>Return the user id of the client associated with this binding. </para>        
				/// </summary>
				/// <java-name>
				/// getUid
				/// </java-name>
				[Dot42.DexImport("getUid", "()I", AccessFlags = 1)]
				public int GetUid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the process id where this binding came from. </para>        
				/// </summary>
				/// <java-name>
				/// getPid
				/// </java-name>
				[Dot42.DexImport("getPid", "()I", AccessFlags = 1)]
				public int GetPid() /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InputBinding() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return the connection for interacting back with the application. </para>        
				/// </summary>
				/// <java-name>
				/// getConnection
				/// </java-name>
				public global::Android.View.Inputmethod.IInputConnection Connection
				{
				[Dot42.DexImport("getConnection", "()Landroid/view/inputmethod/InputConnection;", AccessFlags = 1)]
						get{ return GetConnection(); }
				}

				/// <summary>
				/// <para>Return the token for the connection back to the application. You can not use this directly, it must be converted to a InputConnection for you. </para>        
				/// </summary>
				/// <java-name>
				/// getConnectionToken
				/// </java-name>
				public global::Android.Os.IBinder ConnectionToken
				{
				[Dot42.DexImport("getConnectionToken", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return GetConnectionToken(); }
				}

				/// <summary>
				/// <para>Return the user id of the client associated with this binding. </para>        
				/// </summary>
				/// <java-name>
				/// getUid
				/// </java-name>
				public int Uid
				{
				[Dot42.DexImport("getUid", "()I", AccessFlags = 1)]
						get{ return GetUid(); }
				}

				/// <summary>
				/// <para>Return the process id where this binding came from. </para>        
				/// </summary>
				/// <java-name>
				/// getPid
				/// </java-name>
				public int Pid
				{
				[Dot42.DexImport("getPid", "()I", AccessFlags = 1)]
						get{ return GetPid(); }
				}

		}

		/// <summary>
		/// <para>Description of what an input method would like from an application when extract text from its input editor. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/ExtractedTextRequest
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/ExtractedTextRequest", AccessFlags = 33)]
		public partial class ExtractedTextRequest : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Arbitrary integer that can be supplied in the request, which will be delivered back when reporting updates. </para>        
				/// </summary>
				/// <java-name>
				/// token
				/// </java-name>
				[Dot42.DexImport("token", "I", AccessFlags = 1)]
				public int Token;
				/// <summary>
				/// <para>Additional request flags, having the same possible values as the flags parameter of InputConnection.getTextBeforeCursor(). </para>        
				/// </summary>
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <summary>
				/// <para>Hint for the maximum number of lines to return. </para>        
				/// </summary>
				/// <java-name>
				/// hintMaxLines
				/// </java-name>
				[Dot42.DexImport("hintMaxLines", "I", AccessFlags = 1)]
				public int HintMaxLines;
				/// <summary>
				/// <para>Hint for the maximum number of characters to return. </para>        
				/// </summary>
				/// <java-name>
				/// hintMaxChars
				/// </java-name>
				[Dot42.DexImport("hintMaxChars", "I", AccessFlags = 1)]
				public int HintMaxChars;
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Inputmethod.ExtractedTextRequest> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExtractedTextRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>An EditorInfo describes several attributes of a text editing object that an input method is communicating with (typically an EditText), most importantly the type of text content it contains. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/EditorInfo
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/EditorInfo", AccessFlags = 33)]
		public partial class EditorInfo : global::Android.Text.IInputType, global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The content type of the text box, whose bits are defined by InputType.</para><para><para>InputType </para><simplesectsep></simplesectsep><para>TYPE_MASK_CLASS </para><simplesectsep></simplesectsep><para>TYPE_MASK_VARIATION </para><simplesectsep></simplesectsep><para>TYPE_MASK_FLAGS </para></para>        
				/// </summary>
				/// <java-name>
				/// inputType
				/// </java-name>
				[Dot42.DexImport("inputType", "I", AccessFlags = 1)]
				public int InputType;
				/// <summary>
				/// <para>Set of bits in imeOptions that provide alternative actions associated with the "enter" key. This both helps the IME provide better feedback about what the enter key will do, and also allows it to provide alternative mechanisms for providing that command. </para>        
				/// </summary>
				/// <java-name>
				/// IME_MASK_ACTION
				/// </java-name>
				[Dot42.DexImport("IME_MASK_ACTION", "I", AccessFlags = 25)]
				public const int IME_MASK_ACTION = 255;
				/// <summary>
				/// <para>Bits of IME_MASK_ACTION: no specific action has been associated with this editor, let the editor come up with its own if it can. </para>        
				/// </summary>
				/// <java-name>
				/// IME_ACTION_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int IME_ACTION_UNSPECIFIED = 0;
				/// <summary>
				/// <para>Bits of IME_MASK_ACTION: there is no available action. </para>        
				/// </summary>
				/// <java-name>
				/// IME_ACTION_NONE
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_NONE", "I", AccessFlags = 25)]
				public const int IME_ACTION_NONE = 1;
				/// <summary>
				/// <para>Bits of IME_MASK_ACTION: the action key performs a "go" operation to take the user to the target of the text they typed. Typically used, for example, when entering a URL. </para>        
				/// </summary>
				/// <java-name>
				/// IME_ACTION_GO
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_GO", "I", AccessFlags = 25)]
				public const int IME_ACTION_GO = 2;
				/// <summary>
				/// <para>Bits of IME_MASK_ACTION: the action key performs a "search" operation, taking the user to the results of searching for the text the have typed (in whatever context is appropriate). </para>        
				/// </summary>
				/// <java-name>
				/// IME_ACTION_SEARCH
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_SEARCH", "I", AccessFlags = 25)]
				public const int IME_ACTION_SEARCH = 3;
				/// <summary>
				/// <para>Bits of IME_MASK_ACTION: the action key performs a "send" operation, delivering the text to its target. This is typically used when composing a message. </para>        
				/// </summary>
				/// <java-name>
				/// IME_ACTION_SEND
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_SEND", "I", AccessFlags = 25)]
				public const int IME_ACTION_SEND = 4;
				/// <summary>
				/// <para>Bits of IME_MASK_ACTION: the action key performs a "next" operation, taking the user to the next field that will accept text. </para>        
				/// </summary>
				/// <java-name>
				/// IME_ACTION_NEXT
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_NEXT", "I", AccessFlags = 25)]
				public const int IME_ACTION_NEXT = 5;
				/// <summary>
				/// <para>Bits of IME_MASK_ACTION: the action key performs a "done" operation, typically meaning the IME will be closed. </para>        
				/// </summary>
				/// <java-name>
				/// IME_ACTION_DONE
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_DONE", "I", AccessFlags = 25)]
				public const int IME_ACTION_DONE = 6;
				/// <summary>
				/// <para>Flag of imeOptions: used to specify that the IME does not need to show its extracted text UI. For input methods that may be fullscreen, often when in landscape mode, this allows them to be smaller and let part of the application be shown behind. Though there will likely be limited access to the application available from the user, it can make the experience of a (mostly) fullscreen IME less jarring. Note that when this flag is specified the IME may <b>not</b> be set up to be able to display text, so it should only be used in situations where this is not needed. </para>        
				/// </summary>
				/// <java-name>
				/// IME_FLAG_NO_EXTRACT_UI
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NO_EXTRACT_UI", "I", AccessFlags = 25)]
				public const int IME_FLAG_NO_EXTRACT_UI = 268435456;
				/// <summary>
				/// <para>Flag of imeOptions: used in conjunction with IME_MASK_ACTION, this indicates that the action should not be available as an accessory button when the input method is full-screen. Note that by setting this flag, there can be cases where the action is simply never available to the user. Setting this generally means that you think showing text being edited is more important than the action you have supplied. </para>        
				/// </summary>
				/// <java-name>
				/// IME_FLAG_NO_ACCESSORY_ACTION
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NO_ACCESSORY_ACTION", "I", AccessFlags = 25)]
				public const int IME_FLAG_NO_ACCESSORY_ACTION = 536870912;
				/// <summary>
				/// <para>Flag of imeOptions: used in conjunction with IME_MASK_ACTION, this indicates that the action should not be available in-line as a replacement for "enter" key. Typically this is because the action has such a significant impact or is not recoverable enough that accidentally hitting it should be avoided, such as sending a message. Note that android.widget.TextView will automatically set this flag for you on multi-line text views. </para>        
				/// </summary>
				/// <java-name>
				/// IME_FLAG_NO_ENTER_ACTION
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NO_ENTER_ACTION", "I", AccessFlags = 25)]
				public const int IME_FLAG_NO_ENTER_ACTION = 1073741824;
				/// <summary>
				/// <para>Generic unspecified type for imeOptions. </para>        
				/// </summary>
				/// <java-name>
				/// IME_NULL
				/// </java-name>
				[Dot42.DexImport("IME_NULL", "I", AccessFlags = 25)]
				public const int IME_NULL = 0;
				/// <summary>
				/// <para>Extended type information for the editor, to help the IME better integrate with it. </para>        
				/// </summary>
				/// <java-name>
				/// imeOptions
				/// </java-name>
				[Dot42.DexImport("imeOptions", "I", AccessFlags = 1)]
				public int ImeOptions;
				/// <summary>
				/// <para>A string supplying additional information options that are private to a particular IME implementation. The string must be scoped to a package owned by the implementation, to ensure there are no conflicts between implementations, but other than that you can put whatever you want in it to communicate with the IME. For example, you could have a string that supplies an argument like <code>"com.example.myapp.SpecialMode=3"</code>. This field is can be filled in from the android.R.attr#privateImeOptions attribute of a TextView. </para>        
				/// </summary>
				/// <java-name>
				/// privateImeOptions
				/// </java-name>
				[Dot42.DexImport("privateImeOptions", "Ljava/lang/String;", AccessFlags = 1)]
				public string PrivateImeOptions;
				/// <summary>
				/// <para>In some cases an IME may be able to display an arbitrary label for a command the user can perform, which you can specify here. You can not count on this being used. </para>        
				/// </summary>
				/// <java-name>
				/// actionLabel
				/// </java-name>
				[Dot42.DexImport("actionLabel", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence ActionLabel;
				/// <summary>
				/// <para>If actionLabel has been given, this is the id for that command when the user presses its button that is delivered back with InputConnection.performEditorAction(). </para>        
				/// </summary>
				/// <java-name>
				/// actionId
				/// </java-name>
				[Dot42.DexImport("actionId", "I", AccessFlags = 1)]
				public int ActionId;
				/// <summary>
				/// <para>The text offset of the start of the selection at the time editing began; -1 if not known. </para>        
				/// </summary>
				/// <java-name>
				/// initialSelStart
				/// </java-name>
				[Dot42.DexImport("initialSelStart", "I", AccessFlags = 1)]
				public int InitialSelStart;
				/// <summary>
				/// <para>The text offset of the end of the selection at the time editing began; -1 if not known. </para>        
				/// </summary>
				/// <java-name>
				/// initialSelEnd
				/// </java-name>
				[Dot42.DexImport("initialSelEnd", "I", AccessFlags = 1)]
				public int InitialSelEnd;
				/// <summary>
				/// <para>The capitalization mode of the first character being edited in the text. Values may be any combination of TextUtils.CAP_MODE_CHARACTERS, TextUtils.CAP_MODE_WORDS, and TextUtils.CAP_MODE_SENTENCES, though you should generally just take a non-zero value to mean start out in caps mode. </para>        
				/// </summary>
				/// <java-name>
				/// initialCapsMode
				/// </java-name>
				[Dot42.DexImport("initialCapsMode", "I", AccessFlags = 1)]
				public int InitialCapsMode;
				/// <summary>
				/// <para>The "hint" text of the text view, typically shown in-line when the text is empty to tell the user what to enter. </para>        
				/// </summary>
				/// <java-name>
				/// hintText
				/// </java-name>
				[Dot42.DexImport("hintText", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence HintText;
				/// <summary>
				/// <para>A label to show to the user describing the text they are writing. </para>        
				/// </summary>
				/// <java-name>
				/// label
				/// </java-name>
				[Dot42.DexImport("label", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence Label;
				/// <summary>
				/// <para>Name of the package that owns this editor. </para>        
				/// </summary>
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <summary>
				/// <para>Identifier for the editor's field. This is optional, and may be 0. By default it is filled in with the result of View.getId() on the View that is being edited. </para>        
				/// </summary>
				/// <java-name>
				/// fieldId
				/// </java-name>
				[Dot42.DexImport("fieldId", "I", AccessFlags = 1)]
				public int FieldId;
				/// <summary>
				/// <para>Additional name for the editor's field. This can supply additional name information for the field. By default it is null. The actual contents have no meaning. </para>        
				/// </summary>
				/// <java-name>
				/// fieldName
				/// </java-name>
				[Dot42.DexImport("fieldName", "Ljava/lang/String;", AccessFlags = 1)]
				public string FieldName;
				/// <summary>
				/// <para>Any extra data to supply to the input method. This is for extended communication with specific input methods; the name fields in the bundle should be scoped (such as "com.mydomain.im.SOME_FIELD") so that they don't conflict with others. This field is can be filled in from the android.R.attr#editorExtras attribute of a TextView. </para>        
				/// </summary>
				/// <java-name>
				/// extras
				/// </java-name>
				[Dot42.DexImport("extras", "Landroid/os/Bundle;", AccessFlags = 1)]
				public global::Android.Os.Bundle Extras;
				/// <summary>
				/// <para>Used to make this class parcelable. </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Inputmethod.EditorInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EditorInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Write debug output of this object. </para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter pw, string prefix) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Used to package this object into a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
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
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>Base class for implementors of the InputConnection interface, taking care of most of the common behavior for providing a connection to an Editable. Implementors of this class will want to be sure to implement getEditable to provide access to their own editable object, and to refer to the documentation in InputConnection. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/inputmethod/BaseInputConnection
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/BaseInputConnection", AccessFlags = 33)]
		public partial class BaseInputConnection : global::Android.View.Inputmethod.IInputConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/view/View;Z)V", AccessFlags = 1)]
				public BaseInputConnection(global::Android.View.View view, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeComposingSpans
				/// </java-name>
				[Dot42.DexImport("removeComposingSpans", "(Landroid/text/Spannable;)V", AccessFlags = 25)]
				public static void RemoveComposingSpans(global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setComposingSpans
				/// </java-name>
				[Dot42.DexImport("setComposingSpans", "(Landroid/text/Spannable;)V", AccessFlags = 9)]
				public static void SetComposingSpans(global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getComposingSpanStart
				/// </java-name>
				[Dot42.DexImport("getComposingSpanStart", "(Landroid/text/Spannable;)I", AccessFlags = 9)]
				public static int GetComposingSpanStart(global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getComposingSpanEnd
				/// </java-name>
				[Dot42.DexImport("getComposingSpanEnd", "(Landroid/text/Spannable;)I", AccessFlags = 9)]
				public static int GetComposingSpanEnd(global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Return the target of edit operations. The default implementation returns its own fake editable that is just used for composing text; subclasses that are real text editors should override this and supply their own. </para>        
				/// </summary>
				/// <java-name>
				/// getEditable
				/// </java-name>
				[Dot42.DexImport("getEditable", "()Landroid/text/Editable;", AccessFlags = 1)]
				public virtual global::Android.Text.IEditable GetEditable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.IEditable);
				}

				/// <summary>
				/// <para>Default implementation does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// beginBatchEdit
				/// </java-name>
				[Dot42.DexImport("beginBatchEdit", "()Z", AccessFlags = 1)]
				public virtual bool BeginBatchEdit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Default implementation does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// endBatchEdit
				/// </java-name>
				[Dot42.DexImport("endBatchEdit", "()Z", AccessFlags = 1)]
				public virtual bool EndBatchEdit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Default implementation uses MetaKeyKeyListener.clearMetaKeyState(long, int) to clear the state. </para>        
				/// </summary>
				/// <java-name>
				/// clearMetaKeyStates
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyStates", "(I)Z", AccessFlags = 1)]
				public virtual bool ClearMetaKeyStates(int states) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Default implementation does nothing and returns false. </para>        
				/// </summary>
				/// <java-name>
				/// commitCompletion
				/// </java-name>
				[Dot42.DexImport("commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", AccessFlags = 1)]
				public virtual bool CommitCompletion(global::Android.View.Inputmethod.CompletionInfo text) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Default implementation replaces any existing composing text with the given text. In addition, only if dummy mode, a key event is sent for the new text and the current editable buffer cleared. </para>        
				/// </summary>
				/// <java-name>
				/// commitText
				/// </java-name>
				[Dot42.DexImport("commitText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1)]
				public virtual bool CommitText(global::Java.Lang.ICharSequence text, int newCursorPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The default implementation performs the deletion around the current selection position of the editable text. </para>        
				/// </summary>
				/// <java-name>
				/// deleteSurroundingText
				/// </java-name>
				[Dot42.DexImport("deleteSurroundingText", "(II)Z", AccessFlags = 1)]
				public virtual bool DeleteSurroundingText(int beforeLength, int afterLength) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The default implementation removes the composing state from the current editable text. In addition, only if dummy mode, a key event is sent for the new text and the current editable buffer cleared. </para>        
				/// </summary>
				/// <java-name>
				/// finishComposingText
				/// </java-name>
				[Dot42.DexImport("finishComposingText", "()Z", AccessFlags = 1)]
				public virtual bool FinishComposingText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The default implementation uses TextUtils.getCapsMode to get the cursor caps mode for the current selection position in the editable text, unless in dummy mode in which case 0 is always returned. </para>        
				/// </summary>
				/// <java-name>
				/// getCursorCapsMode
				/// </java-name>
				[Dot42.DexImport("getCursorCapsMode", "(I)I", AccessFlags = 1)]
				public virtual int GetCursorCapsMode(int reqModes) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>The default implementation always returns null. </para>        
				/// </summary>
				/// <java-name>
				/// getExtractedText
				/// </java-name>
				[Dot42.DexImport("getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/Extra" +
    "ctedText;", AccessFlags = 1)]
				public virtual global::Android.View.Inputmethod.ExtractedText GetExtractedText(global::Android.View.Inputmethod.ExtractedTextRequest request, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.ExtractedText);
				}

				/// <summary>
				/// <para>The default implementation returns the given amount of text from the current cursor position in the buffer. </para>        
				/// </summary>
				/// <java-name>
				/// getTextBeforeCursor
				/// </java-name>
				[Dot42.DexImport("getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextBeforeCursor(int length, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>The default implementation returns the given amount of text from the current cursor position in the buffer. </para>        
				/// </summary>
				/// <java-name>
				/// getTextAfterCursor
				/// </java-name>
				[Dot42.DexImport("getTextAfterCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextAfterCursor(int length, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>The default implementation turns this into the enter key. </para>        
				/// </summary>
				/// <java-name>
				/// performEditorAction
				/// </java-name>
				[Dot42.DexImport("performEditorAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformEditorAction(int actionCode) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The default implementation does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// performContextMenuAction
				/// </java-name>
				[Dot42.DexImport("performContextMenuAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformContextMenuAction(int id) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The default implementation does nothing. </para>        
				/// </summary>
				/// <java-name>
				/// performPrivateCommand
				/// </java-name>
				[Dot42.DexImport("performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool PerformPrivateCommand(string action, global::Android.Os.Bundle data) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The default implementation places the given text into the editable, replacing any existing composing text. The new text is marked as in a composing state with the composing style. </para>        
				/// </summary>
				/// <java-name>
				/// setComposingText
				/// </java-name>
				[Dot42.DexImport("setComposingText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1)]
				public virtual bool SetComposingText(global::Java.Lang.ICharSequence text, int newCursorPosition) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>The default implementation changes the selection position in the current editable text. </para>        
				/// </summary>
				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(II)Z", AccessFlags = 1)]
				public virtual bool SetSelection(int start, int end) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Provides standard implementation for sending a key event to the window attached to the input connection's view. </para>        
				/// </summary>
				/// <java-name>
				/// sendKeyEvent
				/// </java-name>
				[Dot42.DexImport("sendKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool SendKeyEvent(global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Updates InputMethodManager with the current fullscreen mode. </para>        
				/// </summary>
				/// <java-name>
				/// reportFullscreenMode
				/// </java-name>
				[Dot42.DexImport("reportFullscreenMode", "(Z)Z", AccessFlags = 1)]
				public virtual bool ReportFullscreenMode(bool enabled) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BaseInputConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return the target of edit operations. The default implementation returns its own fake editable that is just used for composing text; subclasses that are real text editors should override this and supply their own. </para>        
				/// </summary>
				/// <java-name>
				/// getEditable
				/// </java-name>
				public global::Android.Text.IEditable Editable
				{
				[Dot42.DexImport("getEditable", "()Landroid/text/Editable;", AccessFlags = 1)]
						get{ return GetEditable(); }
				}

		}

}


