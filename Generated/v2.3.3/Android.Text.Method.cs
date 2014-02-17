// Copyright (C) 2014 dot42
//
// Original filename: Android.Text.Method.cs
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
namespace Android.Text.Method
{
		/// <summary>
		/// <para>For numeric text entry </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/NumberKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/NumberKeyListener", AccessFlags = 1057)]
		public abstract partial class NumberKeyListener : global::Android.Text.Method.BaseKeyListener, global::Android.Text.IInputFilter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public NumberKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 1028)]
				protected internal abstract char[] GetAcceptedChars() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I", AccessFlags = 4)]
				protected internal virtual int Lookup(global::Android.View.KeyEvent @event, global::Android.Text.ISpannable content) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>This method is called when the buffer is going to replace the range <code>dstart  dend</code> of <code>dest</code> with the new text from the range <code>start  end</code> of <code>source</code>. Return the CharSequence that you would like to have placed there instead, including an empty string if appropriate, or <code>null</code> to accept the original replacement. Be careful to not to reject 0-length replacements, as this is what happens when you delete text. Also beware that you should not attempt to make any changes to <code>dest</code> from this method; you may only examine it for context.</para><para>Note: If <b>source</b> is an instance of Spanned or Spannable, the span objects in the <b>source</b> should be copied into the filtered result (i.e. the non-null return value). TextUtils#copySpansFrom can be used for convenience. </para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence source, int start, int end, global::Android.Text.ISpanned dest, int dstart, int dend) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// ok
				/// </java-name>
				[Dot42.DexImport("ok", "([CC)Z", AccessFlags = 12)]
				protected internal static bool Ok(char[] accept, char c) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>If the key listener wants to handle this key, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				protected internal char[] AcceptedChars
				{
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 1028)]
						get{ return GetAcceptedChars(); }
				}

		}

		/// <summary>
		/// <para>TextView uses TransformationMethods to do things like replacing the characters of passwords with dots, or keeping the newline characters from causing line breaks in single-line text fields. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/TransformationMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/TransformationMethod", AccessFlags = 1537)]
		public partial interface ITransformationMethod
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Returns a CharSequence that is a transformation of the source text  for example, replacing each character with a dot in a password field. Beware that the returned text must be exactly the same length as the source text, and that if the source text is Editable, the returned text must mirror it dynamically instead of doing a one-time copy. </para>        
				/// </summary>
				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence GetTransformation(global::Java.Lang.ICharSequence source, global::Android.View.View view) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>This method is called when the TextView that uses this TransformationMethod gains or loses focus. </para>        
				/// </summary>
				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", AccessFlags = 1025)]
				void OnFocusChanged(global::Android.View.View view, global::Java.Lang.ICharSequence sourceText, bool focused, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This is the standard key listener for alphabetic input on 12-key keyboards. You should generally not need to instantiate this yourself; TextKeyListener will do it for you. </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/MultiTapKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/MultiTapKeyListener", AccessFlags = 33)]
		public partial class MultiTapKeyListener : global::Android.Text.Method.BaseKeyListener, global::Android.Text.ISpanWatcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V", AccessFlags = 1)]
				public MultiTapKeyListener(global::Android.Text.Method.TextKeyListener.Capitalize cap, bool autotext) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new or existing instance with the specified capitalization and correction properties. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/MultiTapK" +
    "eyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.MultiTapKeyListener GetInstance(bool autotext, global::Android.Text.Method.TextKeyListener.Capitalize cap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.MultiTapKeyListener);
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>If the key listener wants to handle this key, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>This method is called to notify you that the specified object has been relocated from the range <code>ostartoend</code> to the new range <code>nstartnend</code> of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanChanged
				/// </java-name>
				[Dot42.DexImport("onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V", AccessFlags = 1)]
				public virtual void OnSpanChanged(global::Android.Text.ISpannable text, object what, int ostart, int oend, int nstart, int nend) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called to notify you that the specified object has been attached to the specified range of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanAdded
				/// </java-name>
				[Dot42.DexImport("onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void OnSpanAdded(global::Android.Text.ISpannable text, object what, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called to notify you that the specified object has been detached from the specified range of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanRemoved
				/// </java-name>
				[Dot42.DexImport("onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void OnSpanRemoved(global::Android.Text.ISpannable text, object what, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MultiTapKeyListener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

		}

		/// <summary>
		/// <para>For entering times in a text field. </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/TimeKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/TimeKeyListener", AccessFlags = 33)]
		public partial class TimeKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The characters that are used.</para><para><para>KeyEvent::getMatch </para><simplesectsep></simplesectsep><para>getAcceptedChars </para></para>        
				/// </summary>
				/// <java-name>
				/// CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CHARACTERS", "[C", AccessFlags = 25)]
				public static readonly char[] CHARACTERS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TimeKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
				protected internal override char[] GetAcceptedChars() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/TimeKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.TimeKeyListener GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.TimeKeyListener);
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				protected internal char[] AcceptedChars
				{
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
						get{ return GetAcceptedChars(); }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.TimeKeyListener Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/TimeKeyListener;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>A movement method that interprets movement keys by scrolling the text buffer. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/ScrollingMovementMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/ScrollingMovementMethod", AccessFlags = 33)]
		public partial class ScrollingMovementMethod : global::Android.Text.Method.IMovementMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ScrollingMovementMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Performs a left movement action. Moves the cursor or scrolls left by one character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled. </para>
				/// </returns>
				/// <java-name>
				/// left
				/// </java-name>
				[Dot42.DexImport("left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Left(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs a right movement action. Moves the cursor or scrolls right by one character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled. </para>
				/// </returns>
				/// <java-name>
				/// right
				/// </java-name>
				[Dot42.DexImport("right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Right(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs an up movement action. Moves the cursor or scrolls up by one line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled. </para>
				/// </returns>
				/// <java-name>
				/// up
				/// </java-name>
				[Dot42.DexImport("up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Up(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs a down movement action. Moves the cursor or scrolls down by one line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled. </para>
				/// </returns>
				/// <java-name>
				/// down
				/// </java-name>
				[Dot42.DexImport("down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Down(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyOther(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTrackballEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer, global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", AccessFlags = 1)]
				public virtual void Initialize(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// canSelectArbitrarily
				/// </java-name>
				[Dot42.DexImport("canSelectArbitrarily", "()Z", AccessFlags = 1)]
				public virtual bool CanSelectArbitrarily() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1)]
				public virtual void OnTakeFocus(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text, int dir) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/MovementMethod;", AccessFlags = 9)]
				public static global::Android.Text.Method.IMovementMethod GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.IMovementMethod);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.IMovementMethod Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/MovementMethod;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>Abstract base class for key listeners.</para><para>Provides a basic foundation for entering and editing text. Subclasses should override onKeyDown and onKeyUp to insert characters as keys are pressed. </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/BaseKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/BaseKeyListener", AccessFlags = 1057)]
		public abstract partial class BaseKeyListener : global::Android.Text.Method.MetaKeyKeyListener, global::Android.Text.Method.IKeyListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BaseKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Performs the action that happens when you press the KeyEvent#KEYCODE_DEL key in a TextView. If there is a selection, deletes the selection; otherwise, deletes the character before the cursor, if any; ALT+DEL deletes everything on the line the cursor is on.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>true if anything was deleted; false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// backspace
				/// </java-name>
				[Dot42.DexImport("backspace", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool Backspace(global::Android.View.View view, global::Android.Text.IEditable content, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>If the key listener wants to handle this key, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Base implementation handles ACTION_MULTIPLE KEYCODE_UNKNOWN by inserting the event's text into the content. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyOther(global::Android.View.View view, global::Android.Text.IEditable content, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/KeyListener", "getInputType", "()I", AccessFlags = 1025)]
				public virtual int GetInputType() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/text/method/KeyListener", "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public override bool OnKeyUp(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/KeyListener", "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", AccessFlags = 1025)]
				public override void ClearMetaKeyState(global::Android.View.View view, global::Android.Text.IEditable content, int states) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				public int InputType
				{
				[Dot42.DexImport("android/text/method/KeyListener", "getInputType", "()I", AccessFlags = 1025)]
						get{ return GetInputType(); }
				}

		}

		/// <summary>
		/// <para>This is the standard key listener for alphabetic input on qwerty keyboards. You should generally not need to instantiate this yourself; TextKeyListener will do it for you. </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/QwertyKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/QwertyKeyListener", AccessFlags = 33)]
		public partial class QwertyKeyListener : global::Android.Text.Method.BaseKeyListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V", AccessFlags = 1)]
				public QwertyKeyListener(global::Android.Text.Method.TextKeyListener.Capitalize cap, bool autoText) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new or existing instance with the specified capitalization and correction properties. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/QwertyKey" +
    "Listener;", AccessFlags = 9)]
				public static global::Android.Text.Method.QwertyKeyListener GetInstance(bool autoText, global::Android.Text.Method.TextKeyListener.Capitalize cap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.QwertyKeyListener);
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>If the key listener wants to handle this key, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Marks the specified region of <code>content</code> as having contained <code>original</code> prior to AutoText replacement. Call this method when you have done or are about to do an AutoText-style replacement on a region of text and want to let the same mechanism (the user pressing DEL immediately after the change) undo the replacement.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// markAsReplaced
				/// </java-name>
				[Dot42.DexImport("markAsReplaced", "(Landroid/text/Spannable;IILjava/lang/String;)V", AccessFlags = 9)]
				public static void MarkAsReplaced(global::Android.Text.ISpannable content, int start, int end, string original) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal QwertyKeyListener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

		}

		/// <summary>
		/// <para>For digits-only text entry </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/DigitsKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/DigitsKeyListener", AccessFlags = 33)]
		public partial class DigitsKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Allocates a DigitsKeyListener that accepts the digits 0 through 9. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DigitsKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Allocates a DigitsKeyListener that accepts the digits 0 through 9, plus the minus sign (only at the beginning) and/or decimal point (only one per field) if specified. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(ZZ)V", AccessFlags = 1)]
				public DigitsKeyListener(bool sign, bool @decimal) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
				protected internal override char[] GetAcceptedChars() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				/// <para>Returns a DigitsKeyListener that accepts the digits 0 through 9. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DigitsKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DigitsKeyListener GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DigitsKeyListener);
				}

				/// <summary>
				/// <para>Returns a DigitsKeyListener that accepts the digits 0 through 9, plus the minus sign (only at the beginning) and/or decimal point (only one per field) if specified. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(ZZ)Landroid/text/method/DigitsKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DigitsKeyListener GetInstance(bool sign, bool @decimal) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DigitsKeyListener);
				}

				/// <summary>
				/// <para>Returns a DigitsKeyListener that accepts only the characters that appear in the specified String. Note that not all characters may be available on every keyboard. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Landroid/text/method/DigitsKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DigitsKeyListener GetInstance(string accepted) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DigitsKeyListener);
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>This method is called when the buffer is going to replace the range <code>dstart  dend</code> of <code>dest</code> with the new text from the range <code>start  end</code> of <code>source</code>. Return the CharSequence that you would like to have placed there instead, including an empty string if appropriate, or <code>null</code> to accept the original replacement. Be careful to not to reject 0-length replacements, as this is what happens when you delete text. Also beware that you should not attempt to make any changes to <code>dest</code> from this method; you may only examine it for context.</para><para>Note: If <b>source</b> is an instance of Spanned or Spannable, the span objects in the <b>source</b> should be copied into the filtered result (i.e. the non-null return value). TextUtils#copySpansFrom can be used for convenience. </para>        
				/// </summary>
				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence source, int start, int end, global::Android.Text.ISpanned dest, int dstart, int dend) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				protected internal char[] AcceptedChars
				{
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
						get{ return GetAcceptedChars(); }
				}

				/// <summary>
				/// <para>Returns a DigitsKeyListener that accepts the digits 0 through 9. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.DigitsKeyListener Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DigitsKeyListener;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

		}

		/// <summary>
		/// <para>For entering dates in a text field. </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/DateKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/DateKeyListener", AccessFlags = 33)]
		public partial class DateKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The characters that are used.</para><para><para>KeyEvent::getMatch </para><simplesectsep></simplesectsep><para>getAcceptedChars </para></para>        
				/// </summary>
				/// <java-name>
				/// CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CHARACTERS", "[C", AccessFlags = 25)]
				public static readonly char[] CHARACTERS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
				protected internal override char[] GetAcceptedChars() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DateKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DateKeyListener GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DateKeyListener);
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				protected internal char[] AcceptedChars
				{
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
						get{ return GetAcceptedChars(); }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.DateKeyListener Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DateKeyListener;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <java-name>
		/// android/text/method/PasswordTransformationMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/PasswordTransformationMethod", AccessFlags = 33)]
		public partial class PasswordTransformationMethod : global::Android.Text.Method.ITransformationMethod, global::Android.Text.ITextWatcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PasswordTransformationMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a CharSequence that is a transformation of the source text  for example, replacing each character with a dot in a password field. Beware that the returned text must be exactly the same length as the source text, and that if the source text is Editable, the returned text must mirror it dynamically instead of doing a one-time copy. </para>        
				/// </summary>
				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTransformation(global::Java.Lang.ICharSequence source, global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/PasswordTransformationMethod;", AccessFlags = 9)]
				public static global::Android.Text.Method.PasswordTransformationMethod GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.PasswordTransformationMethod);
				}

				/// <summary>
				/// <para>This method is called to notify you that, within <code>s</code>, the <code>count</code> characters beginning at <code>start</code> are about to be replaced by new text with length <code>after</code>. It is an error to attempt to make changes to <code>s</code> from this callback. </para>        
				/// </summary>
				/// <java-name>
				/// beforeTextChanged
				/// </java-name>
				[Dot42.DexImport("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void BeforeTextChanged(global::Java.Lang.ICharSequence s, int start, int count, int after) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called to notify you that, within <code>s</code>, the <code>count</code> characters beginning at <code>start</code> have just replaced old text that had length <code>before</code>. It is an error to attempt to make changes to <code>s</code> from this callback. </para>        
				/// </summary>
				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void OnTextChanged(global::Java.Lang.ICharSequence s, int start, int before, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called to notify you that, somewhere within <code>s</code>, the text has been changed. It is legitimate to make further changes to <code>s</code> from this callback, but be careful not to get yourself into an infinite loop, because any changes you make will cause this method to be called again recursively. (You are not told where the change took place because other afterTextChanged() methods may already have made other changes and invalidated the offsets. But if you need to know here, you can use Spannable#setSpan in onTextChanged to mark your place and then look up from here where the span ended up. </para>        
				/// </summary>
				/// <java-name>
				/// afterTextChanged
				/// </java-name>
				[Dot42.DexImport("afterTextChanged", "(Landroid/text/Editable;)V", AccessFlags = 1)]
				public virtual void AfterTextChanged(global::Android.Text.IEditable s) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called when the TextView that uses this TransformationMethod gains or loses focus. </para>        
				/// </summary>
				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void OnFocusChanged(global::Android.View.View view, global::Java.Lang.ICharSequence sourceText, bool focused, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.PasswordTransformationMethod Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/PasswordTransformationMethod;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>Interface for converting text key events into edit operations on an Editable class. Note that for most cases this interface has been superceded by general soft input methods as defined by android.view.inputmethod.InputMethod; it should only be used for cases where an application has its own on-screen keypad and also wants to process hard keyboard events to match it. </para><para>Key presses on soft input methods are not required to trigger the methods in this listener, and are in fact discouraged to do so. The default android keyboard will not trigger these for any key to any application targetting Jelly Bean or later, and will only deliver it for some key presses to applications targetting Ice Cream Sandwich or earlier. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/KeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/KeyListener", AccessFlags = 1537)]
		public partial interface IKeyListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1025)]
				int GetInputType() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If the key listener wants to handle this key, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If the key listener wants to handle this key release, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyUp(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If the key listener wants to other kinds of key events, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyOther(global::Android.View.View view, global::Android.Text.IEditable text, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Remove the given shift states from the edited text. </para>        
				/// </summary>
				/// <java-name>
				/// clearMetaKeyState
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", AccessFlags = 1025)]
				void ClearMetaKeyState(global::Android.View.View view, global::Android.Text.IEditable content, int states) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/method/Touch
		/// </java-name>
		[Dot42.DexImport("android/text/method/Touch", AccessFlags = 33)]
		public partial class Touch
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Touch() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Scrolls the specified widget to the specified coordinates, except constrains the X scrolling position to the horizontal regions of the text that will be visible after scrolling to the specified Y position. </para>        
				/// </summary>
				/// <java-name>
				/// scrollTo
				/// </java-name>
				[Dot42.DexImport("scrollTo", "(Landroid/widget/TextView;Landroid/text/Layout;II)V", AccessFlags = 9)]
				public static void ScrollTo(global::Android.Widget.TextView widget, global::Android.Text.Layout layout, int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handles touch events for dragging. You may want to do other actions like moving the cursor on touch as well. </para>        
				/// </summary>
				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 9)]
				public static bool OnTouchEvent(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer, global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <java-name>
				/// getInitialScrollX
				/// </java-name>
				[Dot42.DexImport("getInitialScrollX", "(Landroid/widget/TextView;Landroid/text/Spannable;)I", AccessFlags = 9)]
				public static int GetInitialScrollX(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para></para>        
				/// </summary>
				/// <java-name>
				/// getInitialScrollY
				/// </java-name>
				[Dot42.DexImport("getInitialScrollY", "(Landroid/widget/TextView;Landroid/text/Spannable;)I", AccessFlags = 9)]
				public static int GetInitialScrollY(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		/// <para>Dialog for choosing accented characters related to a base character. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/CharacterPickerDialog
		/// </java-name>
		[Dot42.DexImport("android/text/method/CharacterPickerDialog", AccessFlags = 33)]
		public partial class CharacterPickerDialog : global::Android.App.Dialog, global::Android.Widget.AdapterView<object>.IOnItemClickListener, global::Android.View.View.IOnClickListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new CharacterPickerDialog that presents the specified <code>options</code> for insertion or replacement (depending on the sense of <code>insert</code>) into <code>text</code>. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/View;Landroid/text/Editable;Ljava/lang/St" +
    "ring;Z)V", AccessFlags = 1)]
				public CharacterPickerDialog(global::Android.Content.Context context, global::Android.View.View view, global::Android.Text.IEditable text, string options, bool insert) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Similar to Activity#onCreate, you should initialize your dialog in this method, including calling setContentView. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.Os.Bundle savedInstanceState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handles clicks on the character buttons. </para>        
				/// </summary>
				/// <java-name>
				/// onItemClick
				/// </java-name>
				[Dot42.DexImport("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", AccessFlags = 1)]
				public virtual void OnItemClick(global::Android.Widget.AdapterView<object> parent, global::Android.View.View view, int position, long id) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handles clicks on the Cancel button. </para>        
				/// </summary>
				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.View.View v) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharacterPickerDialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>For entering dates and times in the same text field. </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/DateTimeKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/DateTimeKeyListener", AccessFlags = 33)]
		public partial class DateTimeKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The characters that are used.</para><para><para>KeyEvent::getMatch </para><simplesectsep></simplesectsep><para>getAcceptedChars </para></para>        
				/// </summary>
				/// <java-name>
				/// CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CHARACTERS", "[C", AccessFlags = 25)]
				public static readonly char[] CHARACTERS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateTimeKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
				protected internal override char[] GetAcceptedChars() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DateTimeKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DateTimeKeyListener GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DateTimeKeyListener);
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				protected internal char[] AcceptedChars
				{
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
						get{ return GetAcceptedChars(); }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.DateTimeKeyListener Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DateTimeKeyListener;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>For dialing-only text entry </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/DialerKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/DialerKeyListener", AccessFlags = 33)]
		public partial class DialerKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The characters that are used.</para><para><para>KeyEvent::getMatch </para><simplesectsep></simplesectsep><para>getAcceptedChars </para></para>        
				/// </summary>
				/// <java-name>
				/// CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CHARACTERS", "[C", AccessFlags = 25)]
				public static readonly char[] CHARACTERS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DialerKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
				protected internal override char[] GetAcceptedChars() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DialerKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DialerKeyListener GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DialerKeyListener);
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Overrides the superclass's lookup method to prefer the number field from the KeyEvent. </para>        
				/// </summary>
				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I", AccessFlags = 4)]
				protected internal override int Lookup(global::Android.View.KeyEvent @event, global::Android.Text.ISpannable content) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>You can say which characters you can accept. </para>        
				/// </summary>
				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				protected internal char[] AcceptedChars
				{
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 4)]
						get{ return GetAcceptedChars(); }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.DialerKeyListener Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DialerKeyListener;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

		}

		/// <summary>
		/// <para>A movement method that provides cursor movement and selection. Supports displaying the context menu on DPad Center. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/ArrowKeyMovementMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/ArrowKeyMovementMethod", AccessFlags = 33)]
		public partial class ArrowKeyMovementMethod : global::Android.Text.Method.IMovementMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrowKeyMovementMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyOther(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTrackballEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer, global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this movement method allows arbitrary selection of any text; false if it has no selection (like a movement method that only scrolls) or a constrained selection (for example limited to links. The "Select All" menu item is disabled if arbitrary selection is not allowed. </para>        
				/// </summary>
				/// <java-name>
				/// canSelectArbitrarily
				/// </java-name>
				[Dot42.DexImport("canSelectArbitrarily", "()Z", AccessFlags = 1)]
				public virtual bool CanSelectArbitrarily() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", AccessFlags = 1)]
				public virtual void Initialize(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1)]
				public virtual void OnTakeFocus(global::Android.Widget.TextView view, global::Android.Text.ISpannable text, int dir) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/MovementMethod;", AccessFlags = 9)]
				public static global::Android.Text.Method.IMovementMethod GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.IMovementMethod);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.IMovementMethod Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/MovementMethod;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>This transformation method causes the characters in the getOriginal array to be replaced by the corresponding characters in the getReplacement array. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/ReplacementTransformationMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/ReplacementTransformationMethod", AccessFlags = 1057)]
		public abstract partial class ReplacementTransformationMethod : global::Android.Text.Method.ITransformationMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ReplacementTransformationMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the list of characters that are to be replaced by other characters when displayed. </para>        
				/// </summary>
				/// <java-name>
				/// getOriginal
				/// </java-name>
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 1028)]
				protected internal abstract char[] GetOriginal() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a parallel array of replacement characters for the ones that are to be replaced. </para>        
				/// </summary>
				/// <java-name>
				/// getReplacement
				/// </java-name>
				[Dot42.DexImport("getReplacement", "()[C", AccessFlags = 1028)]
				protected internal abstract char[] GetReplacement() /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns a CharSequence that will mirror the contents of the source CharSequence but with the characters in getOriginal replaced by ones from getReplacement. </para>        
				/// </summary>
				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTransformation(global::Java.Lang.ICharSequence source, global::Android.View.View v) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>This method is called when the TextView that uses this TransformationMethod gains or loses focus. </para>        
				/// </summary>
				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void OnFocusChanged(global::Android.View.View view, global::Java.Lang.ICharSequence sourceText, bool focused, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the list of characters that are to be replaced by other characters when displayed. </para>        
				/// </summary>
				/// <java-name>
				/// getOriginal
				/// </java-name>
				protected internal char[] Original
				{
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 1028)]
						get{ return GetOriginal(); }
				}

				/// <summary>
				/// <para>Returns a parallel array of replacement characters for the ones that are to be replaced. </para>        
				/// </summary>
				/// <java-name>
				/// getReplacement
				/// </java-name>
				protected internal char[] Replacement
				{
				[Dot42.DexImport("getReplacement", "()[C", AccessFlags = 1028)]
						get{ return GetReplacement(); }
				}

		}

		/// <summary>
		/// <para>This base class encapsulates the behavior for tracking the state of meta keys such as SHIFT, ALT and SYM as well as the pseudo-meta state of selecting text. </para><para>Key listeners that care about meta state should inherit from this class; you should not instantiate this class directly in a client. </para><para>This class provides two mechanisms for tracking meta state that can be used together or independently. </para><para><ul><li><para>Methods such as handleKeyDown(long, int, KeyEvent) and getMetaState(long) operate on a meta key state bit mask. </para></li><li><para>Methods such as onKeyDown(View, Editable, int, KeyEvent) and getMetaState(CharSequence, int) operate on meta key state flags stored as spans in an Editable text buffer. The spans only describe the current meta key state of the text editor; they do not carry any positional information. </para></li></ul></para><para>The behavior of this class varies according to the keyboard capabilities described by the KeyCharacterMap of the keyboard device such as the key modifier behavior. </para><para>MetaKeyKeyListener implements chorded and toggled key modifiers. When key modifiers are toggled into a latched or locked state, the state of the modifier is stored in the Editable text buffer or in a meta state integer managed by the client. These latched or locked modifiers should be considered to be held <b>in addition to</b> those that the keyboard already reported as being pressed in KeyEvent#getMetaState(). In other words, the MetaKeyKeyListener augments the meta state provided by the keyboard; it does not replace it. This distinction is important to ensure that meta keys not handled by MetaKeyKeyListener such as KeyEvent#KEYCODE_CAPS_LOCK or KeyEvent#KEYCODE_NUM_LOCK are taken into consideration. </para><para>To ensure correct meta key behavior, the following pattern should be used when mapping key codes to characters: </para><para><code> private char getUnicodeChar(TextKeyListener listener, KeyEvent event, Editable textBuffer) { // Use the combined meta states from the event and the key listener. int metaState = event.getMetaState() | listener.getMetaState(textBuffer); return event.getUnicodeChar(metaState); } </code> </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/MetaKeyKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/MetaKeyKeyListener", AccessFlags = 1057)]
		public abstract partial class MetaKeyKeyListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Flag that indicates that the SHIFT key is on. Value equals KeyEvent#META_SHIFT_ON. </para>        
				/// </summary>
				/// <java-name>
				/// META_SHIFT_ON
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_ON", "I", AccessFlags = 25)]
				public const int META_SHIFT_ON = 1;
				/// <summary>
				/// <para>Flag that indicates that the ALT key is on. Value equals KeyEvent#META_ALT_ON. </para>        
				/// </summary>
				/// <java-name>
				/// META_ALT_ON
				/// </java-name>
				[Dot42.DexImport("META_ALT_ON", "I", AccessFlags = 25)]
				public const int META_ALT_ON = 2;
				/// <summary>
				/// <para>Flag that indicates that the SYM key is on. Value equals KeyEvent#META_SYM_ON. </para>        
				/// </summary>
				/// <java-name>
				/// META_SYM_ON
				/// </java-name>
				[Dot42.DexImport("META_SYM_ON", "I", AccessFlags = 25)]
				public const int META_SYM_ON = 4;
				/// <summary>
				/// <para>Flag that indicates that the SHIFT key is locked in CAPS mode. </para>        
				/// </summary>
				/// <java-name>
				/// META_CAP_LOCKED
				/// </java-name>
				[Dot42.DexImport("META_CAP_LOCKED", "I", AccessFlags = 25)]
				public const int META_CAP_LOCKED = 256;
				/// <summary>
				/// <para>Flag that indicates that the ALT key is locked. </para>        
				/// </summary>
				/// <java-name>
				/// META_ALT_LOCKED
				/// </java-name>
				[Dot42.DexImport("META_ALT_LOCKED", "I", AccessFlags = 25)]
				public const int META_ALT_LOCKED = 512;
				/// <summary>
				/// <para>Flag that indicates that the SYM key is locked. </para>        
				/// </summary>
				/// <java-name>
				/// META_SYM_LOCKED
				/// </java-name>
				[Dot42.DexImport("META_SYM_LOCKED", "I", AccessFlags = 25)]
				public const int META_SYM_LOCKED = 1024;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MetaKeyKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Resets all meta state to inactive. </para>        
				/// </summary>
				/// <java-name>
				/// resetMetaState
				/// </java-name>
				[Dot42.DexImport("resetMetaState", "(Landroid/text/Spannable;)V", AccessFlags = 9)]
				public static void ResetMetaState(global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMetaState
				/// </java-name>
				[Dot42.DexImport("getMetaState", "(Ljava/lang/CharSequence;)I", AccessFlags = 25)]
				public static int GetMetaState(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMetaState
				/// </java-name>
				[Dot42.DexImport("getMetaState", "(Ljava/lang/CharSequence;I)I", AccessFlags = 25)]
				public static int GetMetaState(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Call this method after you handle a keypress so that the meta state will be reset to unshifted (if it is not still down) or primed to be reset to unshifted (once it is released). </para>        
				/// </summary>
				/// <java-name>
				/// adjustMetaAfterKeypress
				/// </java-name>
				[Dot42.DexImport("adjustMetaAfterKeypress", "(Landroid/text/Spannable;)V", AccessFlags = 9)]
				public static void AdjustMetaAfterKeypress(global::Android.Text.ISpannable content) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns true if this object is one that this class would use to keep track of any meta state in the specified text. </para>        
				/// </summary>
				/// <java-name>
				/// isMetaTracker
				/// </java-name>
				[Dot42.DexImport("isMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool IsMetaTracker(global::Java.Lang.ICharSequence text, object what) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns true if this object is one that this class would use to keep track of the selecting meta state in the specified text. </para>        
				/// </summary>
				/// <java-name>
				/// isSelectingMetaTracker
				/// </java-name>
				[Dot42.DexImport("isSelectingMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool IsSelectingMetaTracker(global::Java.Lang.ICharSequence text, object what) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Call this if you are a method that ignores the locked meta state (arrow keys, for example) and you handle a key. </para>        
				/// </summary>
				/// <java-name>
				/// resetLockedMeta
				/// </java-name>
				[Dot42.DexImport("resetLockedMeta", "(Landroid/text/Spannable;)V", AccessFlags = 12)]
				protected internal static void ResetLockedMeta(global::Android.Text.ISpannable content) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Handles presses of the meta keys. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable content, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Handles release of the meta keys. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(global::Android.View.View view, global::Android.Text.IEditable content, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearMetaKeyState
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", AccessFlags = 1)]
				public virtual void ClearMetaKeyState(global::Android.View.View view, global::Android.Text.IEditable content, int states) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearMetaKeyState
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyState", "(Landroid/text/Editable;I)V", AccessFlags = 9)]
				public static void ClearMetaKeyState(global::Android.Text.IEditable content, int states) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Call this if you are a method that ignores the locked meta state (arrow keys, for example) and you handle a key. </para>        
				/// </summary>
				/// <java-name>
				/// resetLockedMeta
				/// </java-name>
				[Dot42.DexImport("resetLockedMeta", "(J)J", AccessFlags = 9)]
				public static long ResetLockedMeta(long content) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getMetaState
				/// </java-name>
				[Dot42.DexImport("getMetaState", "(J)I", AccessFlags = 25)]
				public static int GetMetaState(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMetaState
				/// </java-name>
				[Dot42.DexImport("getMetaState", "(JI)I", AccessFlags = 25)]
				public static int GetMetaState(long int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Call this method after you handle a keypress so that the meta state will be reset to unshifted (if it is not still down) or primed to be reset to unshifted (once it is released). </para>        
				/// </summary>
				/// <java-name>
				/// adjustMetaAfterKeypress
				/// </java-name>
				[Dot42.DexImport("adjustMetaAfterKeypress", "(J)J", AccessFlags = 9)]
				public static long AdjustMetaAfterKeypress(long content) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Handles presses of the meta keys. </para>        
				/// </summary>
				/// <java-name>
				/// handleKeyDown
				/// </java-name>
				[Dot42.DexImport("handleKeyDown", "(JILandroid/view/KeyEvent;)J", AccessFlags = 9)]
				public static long HandleKeyDown(long state, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Handles release of the meta keys. </para>        
				/// </summary>
				/// <java-name>
				/// handleKeyUp
				/// </java-name>
				[Dot42.DexImport("handleKeyUp", "(JILandroid/view/KeyEvent;)J", AccessFlags = 9)]
				public static long HandleKeyUp(long state, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// clearMetaKeyState
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyState", "(JI)J", AccessFlags = 1)]
				public virtual long ClearMetaKeyState(long content, int states) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <summary>
		/// <para>This transformation method causes any carriage return characters () to be hidden by displaying them as zero-width non-breaking space characters (). </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/HideReturnsTransformationMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/HideReturnsTransformationMethod", AccessFlags = 33)]
		public partial class HideReturnsTransformationMethod : global::Android.Text.Method.ReplacementTransformationMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public HideReturnsTransformationMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The character to be replaced is . </para>        
				/// </summary>
				/// <java-name>
				/// getOriginal
				/// </java-name>
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 4)]
				protected internal override char[] GetOriginal() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				/// <para>The character that  is replaced with is . </para>        
				/// </summary>
				/// <java-name>
				/// getReplacement
				/// </java-name>
				[Dot42.DexImport("getReplacement", "()[C", AccessFlags = 4)]
				protected internal override char[] GetReplacement() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/HideReturnsTransformationMethod;", AccessFlags = 9)]
				public static global::Android.Text.Method.HideReturnsTransformationMethod GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.HideReturnsTransformationMethod);
				}

				/// <summary>
				/// <para>The character to be replaced is . </para>        
				/// </summary>
				/// <java-name>
				/// getOriginal
				/// </java-name>
				protected internal char[] Original
				{
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 4)]
						get{ return GetOriginal(); }
				}

				/// <summary>
				/// <para>The character that  is replaced with is . </para>        
				/// </summary>
				/// <java-name>
				/// getReplacement
				/// </java-name>
				protected internal char[] Replacement
				{
				[Dot42.DexImport("getReplacement", "()[C", AccessFlags = 4)]
						get{ return GetReplacement(); }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.HideReturnsTransformationMethod Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/HideReturnsTransformationMethod;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>Provides cursor positioning, scrolling and text selection functionality in a TextView. </para><para>The TextView delegates handling of key events, trackball motions and touches to the movement method for purposes of content navigation. The framework automatically selects an appropriate movement method based on the content of the TextView. </para><para>This interface is intended for use by the framework; it should not be implemented directly by applications. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/MovementMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/MovementMethod", AccessFlags = 1537)]
		public partial interface IMovementMethod
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", AccessFlags = 1025)]
				void Initialize(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyDown(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyUp(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>If the key listener wants to other kinds of key events, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyOther(global::Android.Widget.TextView view, global::Android.Text.ISpannable text, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1025)]
				void OnTakeFocus(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text, int direction) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				bool OnTrackballEvent(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text, global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				bool OnTouchEvent(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text, global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Returns true if this movement method allows arbitrary selection of any text; false if it has no selection (like a movement method that only scrolls) or a constrained selection (for example limited to links. The "Select All" menu item is disabled if arbitrary selection is not allowed. </para>        
				/// </summary>
				/// <java-name>
				/// canSelectArbitrarily
				/// </java-name>
				[Dot42.DexImport("canSelectArbitrarily", "()Z", AccessFlags = 1025)]
				bool CanSelectArbitrarily() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>A movement method that traverses links in the text buffer and scrolls if necessary. Supports clicking on links with DPad Center or Enter. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/LinkMovementMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/LinkMovementMethod", AccessFlags = 33)]
		public partial class LinkMovementMethod : global::Android.Text.Method.ScrollingMovementMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LinkMovementMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs an up movement action. Moves the cursor or scrolls up by one line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled. </para>
				/// </returns>
				/// <java-name>
				/// up
				/// </java-name>
				[Dot42.DexImport("up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Up(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs a down movement action. Moves the cursor or scrolls down by one line.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled. </para>
				/// </returns>
				/// <java-name>
				/// down
				/// </java-name>
				[Dot42.DexImport("down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Down(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs a left movement action. Moves the cursor or scrolls left by one character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled. </para>
				/// </returns>
				/// <java-name>
				/// left
				/// </java-name>
				[Dot42.DexImport("left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Left(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs a right movement action. Moves the cursor or scrolls right by one character.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the event was handled. </para>
				/// </returns>
				/// <java-name>
				/// right
				/// </java-name>
				[Dot42.DexImport("right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Right(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Widget.TextView widget, global::Android.Text.ISpannable buffer, global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", AccessFlags = 1)]
				public override void Initialize(global::Android.Widget.TextView widget, global::Android.Text.ISpannable text) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1)]
				public override void OnTakeFocus(global::Android.Widget.TextView view, global::Android.Text.ISpannable text, int dir) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/MovementMethod;", AccessFlags = 9)]
				public static global::Android.Text.Method.IMovementMethod GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.IMovementMethod);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.IMovementMethod Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/MovementMethod;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>This transformation method causes any newline characters (<br></br>) to be displayed as spaces instead of causing line breaks, and causes carriage return characters () to have no appearance. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/SingleLineTransformationMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/SingleLineTransformationMethod", AccessFlags = 33)]
		public partial class SingleLineTransformationMethod : global::Android.Text.Method.ReplacementTransformationMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public SingleLineTransformationMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>The characters to be replaced are <br></br> and . </para>        
				/// </summary>
				/// <java-name>
				/// getOriginal
				/// </java-name>
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 4)]
				protected internal override char[] GetOriginal() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <summary>
				/// <para>The character <br></br> is replaced with is space; the character  is replaced with is FEFF (zero width space). </para>        
				/// </summary>
				/// <java-name>
				/// getReplacement
				/// </java-name>
				[Dot42.DexImport("getReplacement", "()[C", AccessFlags = 4)]
				protected internal override char[] GetReplacement() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/SingleLineTransformationMethod;", AccessFlags = 9)]
				public static global::Android.Text.Method.SingleLineTransformationMethod GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.SingleLineTransformationMethod);
				}

				/// <summary>
				/// <para>The characters to be replaced are <br></br> and . </para>        
				/// </summary>
				/// <java-name>
				/// getOriginal
				/// </java-name>
				protected internal char[] Original
				{
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 4)]
						get{ return GetOriginal(); }
				}

				/// <summary>
				/// <para>The character <br></br> is replaced with is space; the character  is replaced with is FEFF (zero width space). </para>        
				/// </summary>
				/// <java-name>
				/// getReplacement
				/// </java-name>
				protected internal char[] Replacement
				{
				[Dot42.DexImport("getReplacement", "()[C", AccessFlags = 4)]
						get{ return GetReplacement(); }
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.SingleLineTransformationMethod Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/SingleLineTransformationMethod;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

		}

		/// <summary>
		/// <para>This is the key listener for typing normal text. It delegates to other key listeners appropriate to the current keyboard and language. </para><para>As for all implementations of KeyListener, this class is only concerned with hardware keyboards. Software input methods have no obligation to trigger the methods in this class. </para>    
		/// </summary>
		/// <java-name>
		/// android/text/method/TextKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/TextKeyListener", AccessFlags = 33)]
		public partial class TextKeyListener : global::Android.Text.Method.BaseKeyListener, global::Android.Text.ISpanWatcher
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Creates a new TextKeyListener with the specified capitalization and correction properties.</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V", AccessFlags = 1)]
				public TextKeyListener(global::Android.Text.Method.TextKeyListener.Capitalize cap, bool autotext) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a new or existing instance with the specified capitalization and correction properties.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/TextKeyLi" +
    "stener;", AccessFlags = 9)]
				public static global::Android.Text.Method.TextKeyListener GetInstance(bool autotext, global::Android.Text.Method.TextKeyListener.Capitalize cap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.TextKeyListener);
				}

				/// <summary>
				/// <para>Returns a new or existing instance with no automatic capitalization or correction. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/TextKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.TextKeyListener GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.TextKeyListener);
				}

				/// <summary>
				/// <para>Returns whether it makes sense to automatically capitalize at the specified position in the specified text, with the specified rules.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>whether the character being inserted should be capitalized. </para>
				/// </returns>
				/// <java-name>
				/// shouldCap
				/// </java-name>
				[Dot42.DexImport("shouldCap", "(Landroid/text/method/TextKeyListener$Capitalize;Ljava/lang/CharSequence;I)Z", AccessFlags = 9)]
				public static bool ShouldCap(global::Android.Text.Method.TextKeyListener.Capitalize cap, global::Java.Lang.ICharSequence cs, int off) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>If the key listener wants to handle this key, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>If the key listener wants to handle this key release, return true, otherwise return false and the caller (i.e. the widget host) will handle the key. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(global::Android.View.View view, global::Android.Text.IEditable text, int keyCode, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Base implementation handles ACTION_MULTIPLE KEYCODE_UNKNOWN by inserting the event's text into the content. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyOther(global::Android.View.View view, global::Android.Text.IEditable content, global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Clear all the input state (autotext, autocap, multitap, undo) from the specified Editable, going beyond Editable.clear(), which just clears the text but not the input state.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(Landroid/text/Editable;)V", AccessFlags = 9)]
				public static void Clear(global::Android.Text.IEditable e) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called to notify you that the specified object has been attached to the specified range of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanAdded
				/// </java-name>
				[Dot42.DexImport("onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void OnSpanAdded(global::Android.Text.ISpannable text, object what, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called to notify you that the specified object has been detached from the specified range of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanRemoved
				/// </java-name>
				[Dot42.DexImport("onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void OnSpanRemoved(global::Android.Text.ISpannable text, object what, int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>This method is called to notify you that the specified object has been relocated from the range <code>ostartoend</code> to the new range <code>nstartnend</code> of the text. </para>        
				/// </summary>
				/// <java-name>
				/// onSpanChanged
				/// </java-name>
				[Dot42.DexImport("onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V", AccessFlags = 1)]
				public virtual void OnSpanChanged(global::Android.Text.ISpannable text, object what, int ostart, int oend, int nstart, int nend) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 1)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextKeyListener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				/// <para>Returns a new or existing instance with no automatic capitalization or correction. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.TextKeyListener Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/TextKeyListener;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <summary>
				/// <para>Return the type of text that this key listener is manipulating, as per android.text.InputType. This is used to determine the mode of the soft keyboard that is shown for the editor.</para><para>If you return android.text.InputType#TYPE_NULL then <b>no</b> soft keyboard will provided. In other words, you must be providing your own key pad for on-screen input and the key listener will be used to handle input from a hard keyboard.</para><para>If you return any other value, a soft input method will be created when the user puts focus in the editor, which will provide a keypad and also consume hard key events. This means that the key listener will generally not be used, instead the soft input method will take care of managing key input as per the content type returned here. </para>        
				/// </summary>
				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

				/// <java-name>
				/// android/text/method/TextKeyListener$Capitalize
				/// </java-name>
				[Dot42.DexImport("android/text/method/TextKeyListener$Capitalize", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/text/method/TextKeyListener$Capitalize;>;")]
				public sealed class Capitalize
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CHARACTERS
						/// </java-name>
						[Dot42.DexImport("CHARACTERS", "Landroid/text/method/TextKeyListener$Capitalize;", AccessFlags = 16409)]
						public static readonly Capitalize CHARACTERS;
						/// <java-name>
						/// NONE
						/// </java-name>
						[Dot42.DexImport("NONE", "Landroid/text/method/TextKeyListener$Capitalize;", AccessFlags = 16409)]
						public static readonly Capitalize NONE;
						/// <java-name>
						/// SENTENCES
						/// </java-name>
						[Dot42.DexImport("SENTENCES", "Landroid/text/method/TextKeyListener$Capitalize;", AccessFlags = 16409)]
						public static readonly Capitalize SENTENCES;
						/// <java-name>
						/// WORDS
						/// </java-name>
						[Dot42.DexImport("WORDS", "Landroid/text/method/TextKeyListener$Capitalize;", AccessFlags = 16409)]
						public static readonly Capitalize WORDS;
						private Capitalize() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

				}

		}

}


