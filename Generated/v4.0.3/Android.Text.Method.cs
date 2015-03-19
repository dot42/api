#pragma warning disable 1717
namespace Android.Text.Method
{
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

				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTransformation(global::Java.Lang.ICharSequence charSequence, global::Android.View.View view) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// beforeTextChanged
				/// </java-name>
				[Dot42.DexImport("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void BeforeTextChanged(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 1)]
				public virtual void OnTextChanged(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// afterTextChanged
				/// </java-name>
				[Dot42.DexImport("afterTextChanged", "(Landroid/text/Editable;)V", AccessFlags = 1)]
				public virtual void AfterTextChanged(global::Android.Text.IEditable editable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void OnFocusChanged(global::Android.View.View view, global::Java.Lang.ICharSequence charSequence, bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
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

		/// <java-name>
		/// android/text/method/DateKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/DateKeyListener", AccessFlags = 33)]
		public partial class DateKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CHARACTERS", "[C", AccessFlags = 25)]
				public static readonly char[] CHARACTERS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

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
		/// android/text/method/DigitsKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/DigitsKeyListener", AccessFlags = 33)]
		public partial class DigitsKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DigitsKeyListener() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(ZZ)V", AccessFlags = 1)]
				public DigitsKeyListener(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

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
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DigitsKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DigitsKeyListener GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DigitsKeyListener);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(ZZ)Landroid/text/method/DigitsKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DigitsKeyListener GetInstance(bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DigitsKeyListener);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Landroid/text/method/DigitsKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.DigitsKeyListener GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.DigitsKeyListener);
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.ISpanned spanned, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

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
				public static global::Android.Text.Method.DigitsKeyListener Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/DigitsKeyListener;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

		}

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

				/// <java-name>
				/// getOriginal
				/// </java-name>
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 1028)]
				protected internal abstract char[] GetOriginal() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getReplacement
				/// </java-name>
				[Dot42.DexImport("getReplacement", "()[C", AccessFlags = 1028)]
				protected internal abstract char[] GetReplacement() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTransformation(global::Java.Lang.ICharSequence charSequence, global::Android.View.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void OnFocusChanged(global::Android.View.View view, global::Java.Lang.ICharSequence charSequence, bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOriginal
				/// </java-name>
				protected internal char[] Original
				{
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 1028)]
						get{ return GetOriginal(); }
				}

				/// <java-name>
				/// getReplacement
				/// </java-name>
				protected internal char[] Replacement
				{
				[Dot42.DexImport("getReplacement", "()[C", AccessFlags = 1028)]
						get{ return GetReplacement(); }
				}

		}

		/// <java-name>
		/// android/text/method/ArrowKeyMovementMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/ArrowKeyMovementMethod", AccessFlags = 33)]
		public partial class ArrowKeyMovementMethod : global::Android.Text.Method.BaseMovementMethod, global::Android.Text.Method.IMovementMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ArrowKeyMovementMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleMovementKey
				/// </java-name>
				[Dot42.DexImport("handleMovementKey", "(Landroid/widget/TextView;Landroid/text/Spannable;IILandroid/view/KeyEvent;)Z", AccessFlags = 4)]
				protected internal override bool HandleMovementKey(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, int int321, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// left
				/// </java-name>
				[Dot42.DexImport("left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Left(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// right
				/// </java-name>
				[Dot42.DexImport("right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Right(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// up
				/// </java-name>
				[Dot42.DexImport("up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Up(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// down
				/// </java-name>
				[Dot42.DexImport("down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Down(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pageUp
				/// </java-name>
				[Dot42.DexImport("pageUp", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool PageUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pageDown
				/// </java-name>
				[Dot42.DexImport("pageDown", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool PageDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// top
				/// </java-name>
				[Dot42.DexImport("top", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Top(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// bottom
				/// </java-name>
				[Dot42.DexImport("bottom", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Bottom(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lineStart
				/// </java-name>
				[Dot42.DexImport("lineStart", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool LineStart(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lineEnd
				/// </java-name>
				[Dot42.DexImport("lineEnd", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool LineEnd(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// home
				/// </java-name>
				[Dot42.DexImport("home", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Home(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool End(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// canSelectArbitrarily
				/// </java-name>
				[Dot42.DexImport("canSelectArbitrarily", "()Z", AccessFlags = 1)]
				public override bool CanSelectArbitrarily() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", AccessFlags = 1)]
				public override void Initialize(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1)]
				public override void OnTakeFocus(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("android/text/method/MovementMethod", "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public override bool OnKeyDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public override bool OnKeyUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public override bool OnKeyOther(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public override bool OnTrackballEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onGenericMotionEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public override bool OnGenericMotionEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
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

				/// <java-name>
				/// backspace
				/// </java-name>
				[Dot42.DexImport("backspace", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool Backspace(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// forwardDelete
				/// </java-name>
				[Dot42.DexImport("forwardDelete", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool ForwardDelete(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyOther(global::Android.View.View view, global::Android.Text.IEditable editable, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/KeyListener", "getInputType", "()I", AccessFlags = 1025)]
				public virtual int GetInputType() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/text/method/KeyListener", "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public override bool OnKeyUp(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/KeyListener", "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", AccessFlags = 1025)]
				public override void ClearMetaKeyState(global::Android.View.View view, global::Android.Text.IEditable editable, int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				public int InputType
				{
				[Dot42.DexImport("android/text/method/KeyListener", "getInputType", "()I", AccessFlags = 1025)]
						get{ return GetInputType(); }
				}

		}

		/// <java-name>
		/// android/text/method/DateTimeKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/DateTimeKeyListener", AccessFlags = 33)]
		public partial class DateTimeKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CHARACTERS", "[C", AccessFlags = 25)]
				public static readonly char[] CHARACTERS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DateTimeKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

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

		/// <java-name>
		/// android/text/method/QwertyKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/QwertyKeyListener", AccessFlags = 33)]
		public partial class QwertyKeyListener : global::Android.Text.Method.BaseKeyListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V", AccessFlags = 1)]
				public QwertyKeyListener(global::Android.Text.Method.TextKeyListener.Capitalize capitalize, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/QwertyKey" +
    "Listener;", AccessFlags = 9)]
				public static global::Android.Text.Method.QwertyKeyListener GetInstance(bool boolean, global::Android.Text.Method.TextKeyListener.Capitalize capitalize) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.QwertyKeyListener);
				}

				/// <java-name>
				/// getInstanceForFullKeyboard
				/// </java-name>
				[Dot42.DexImport("getInstanceForFullKeyboard", "()Landroid/text/method/QwertyKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.QwertyKeyListener GetInstanceForFullKeyboard() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.QwertyKeyListener);
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// markAsReplaced
				/// </java-name>
				[Dot42.DexImport("markAsReplaced", "(Landroid/text/Spannable;IILjava/lang/String;)V", AccessFlags = 9)]
				public static void MarkAsReplaced(global::Android.Text.ISpannable spannable, int int32, int int321, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal QwertyKeyListener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getInstanceForFullKeyboard
				/// </java-name>
				public static global::Android.Text.Method.QwertyKeyListener InstanceForFullKeyboard
				{
				[Dot42.DexImport("getInstanceForFullKeyboard", "()Landroid/text/method/QwertyKeyListener;", AccessFlags = 9)]
						get{ return GetInstanceForFullKeyboard(); }
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

		}

		/// <java-name>
		/// android/text/method/MultiTapKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/MultiTapKeyListener", AccessFlags = 33)]
		public partial class MultiTapKeyListener : global::Android.Text.Method.BaseKeyListener, global::Android.Text.ISpanWatcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V", AccessFlags = 1)]
				public MultiTapKeyListener(global::Android.Text.Method.TextKeyListener.Capitalize capitalize, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/MultiTapK" +
    "eyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.MultiTapKeyListener GetInstance(bool boolean, global::Android.Text.Method.TextKeyListener.Capitalize capitalize) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.MultiTapKeyListener);
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onSpanChanged
				/// </java-name>
				[Dot42.DexImport("onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V", AccessFlags = 1)]
				public virtual void OnSpanChanged(global::Android.Text.ISpannable spannable, object @object, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSpanAdded
				/// </java-name>
				[Dot42.DexImport("onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void OnSpanAdded(global::Android.Text.ISpannable spannable, object @object, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSpanRemoved
				/// </java-name>
				[Dot42.DexImport("onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void OnSpanRemoved(global::Android.Text.ISpannable spannable, object @object, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MultiTapKeyListener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

		}

		/// <java-name>
		/// android/text/method/ScrollingMovementMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/ScrollingMovementMethod", AccessFlags = 33)]
		public partial class ScrollingMovementMethod : global::Android.Text.Method.BaseMovementMethod, global::Android.Text.Method.IMovementMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ScrollingMovementMethod() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// left
				/// </java-name>
				[Dot42.DexImport("left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Left(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// right
				/// </java-name>
				[Dot42.DexImport("right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Right(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// up
				/// </java-name>
				[Dot42.DexImport("up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Up(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// down
				/// </java-name>
				[Dot42.DexImport("down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Down(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pageUp
				/// </java-name>
				[Dot42.DexImport("pageUp", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool PageUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pageDown
				/// </java-name>
				[Dot42.DexImport("pageDown", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool PageDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// top
				/// </java-name>
				[Dot42.DexImport("top", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Top(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// bottom
				/// </java-name>
				[Dot42.DexImport("bottom", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Bottom(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lineStart
				/// </java-name>
				[Dot42.DexImport("lineStart", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool LineStart(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lineEnd
				/// </java-name>
				[Dot42.DexImport("lineEnd", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool LineEnd(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// home
				/// </java-name>
				[Dot42.DexImport("home", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Home(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool End(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1)]
				public override void OnTakeFocus(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32) /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("android/text/method/MovementMethod", "initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", AccessFlags = 1025)]
				public override void Initialize(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public override bool OnKeyDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public override bool OnKeyUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public override bool OnKeyOther(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public override bool OnTrackballEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "onGenericMotionEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public override bool OnGenericMotionEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/text/method/MovementMethod", "canSelectArbitrarily", "()Z", AccessFlags = 1025)]
				public override bool CanSelectArbitrarily() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
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

		/// <java-name>
		/// android/text/method/MetaKeyKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/MetaKeyKeyListener", AccessFlags = 1057)]
		public abstract partial class MetaKeyKeyListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// META_SHIFT_ON
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_ON", "I", AccessFlags = 25)]
				public const int META_SHIFT_ON = 1;
				/// <java-name>
				/// META_ALT_ON
				/// </java-name>
				[Dot42.DexImport("META_ALT_ON", "I", AccessFlags = 25)]
				public const int META_ALT_ON = 2;
				/// <java-name>
				/// META_SYM_ON
				/// </java-name>
				[Dot42.DexImport("META_SYM_ON", "I", AccessFlags = 25)]
				public const int META_SYM_ON = 4;
				/// <java-name>
				/// META_CAP_LOCKED
				/// </java-name>
				[Dot42.DexImport("META_CAP_LOCKED", "I", AccessFlags = 25)]
				public const int META_CAP_LOCKED = 256;
				/// <java-name>
				/// META_ALT_LOCKED
				/// </java-name>
				[Dot42.DexImport("META_ALT_LOCKED", "I", AccessFlags = 25)]
				public const int META_ALT_LOCKED = 512;
				/// <java-name>
				/// META_SYM_LOCKED
				/// </java-name>
				[Dot42.DexImport("META_SYM_LOCKED", "I", AccessFlags = 25)]
				public const int META_SYM_LOCKED = 1024;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public MetaKeyKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetMetaState
				/// </java-name>
				[Dot42.DexImport("resetMetaState", "(Landroid/text/Spannable;)V", AccessFlags = 9)]
				public static void ResetMetaState(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// adjustMetaAfterKeypress
				/// </java-name>
				[Dot42.DexImport("adjustMetaAfterKeypress", "(Landroid/text/Spannable;)V", AccessFlags = 9)]
				public static void AdjustMetaAfterKeypress(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isMetaTracker
				/// </java-name>
				[Dot42.DexImport("isMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool IsMetaTracker(global::Java.Lang.ICharSequence charSequence, object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isSelectingMetaTracker
				/// </java-name>
				[Dot42.DexImport("isSelectingMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z", AccessFlags = 9)]
				public static bool IsSelectingMetaTracker(global::Java.Lang.ICharSequence charSequence, object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// resetLockedMeta
				/// </java-name>
				[Dot42.DexImport("resetLockedMeta", "(Landroid/text/Spannable;)V", AccessFlags = 12)]
				protected internal static void ResetLockedMeta(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearMetaKeyState
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", AccessFlags = 1)]
				public virtual void ClearMetaKeyState(global::Android.View.View view, global::Android.Text.IEditable editable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearMetaKeyState
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyState", "(Landroid/text/Editable;I)V", AccessFlags = 9)]
				public static void ClearMetaKeyState(global::Android.Text.IEditable editable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetLockedMeta
				/// </java-name>
				[Dot42.DexImport("resetLockedMeta", "(J)J", AccessFlags = 9)]
				public static long ResetLockedMeta(long int64) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// adjustMetaAfterKeypress
				/// </java-name>
				[Dot42.DexImport("adjustMetaAfterKeypress", "(J)J", AccessFlags = 9)]
				public static long AdjustMetaAfterKeypress(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// handleKeyDown
				/// </java-name>
				[Dot42.DexImport("handleKeyDown", "(JILandroid/view/KeyEvent;)J", AccessFlags = 9)]
				public static long HandleKeyDown(long int64, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// handleKeyUp
				/// </java-name>
				[Dot42.DexImport("handleKeyUp", "(JILandroid/view/KeyEvent;)J", AccessFlags = 9)]
				public static long HandleKeyUp(long int64, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// clearMetaKeyState
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyState", "(JI)J", AccessFlags = 1)]
				public virtual long ClearMetaKeyState(long int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

		}

		/// <java-name>
		/// android/text/method/KeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/KeyListener", AccessFlags = 1537)]
		public partial interface IKeyListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1025)]
				int GetInputType() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyUp(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyOther(global::Android.View.View view, global::Android.Text.IEditable editable, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearMetaKeyState
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", AccessFlags = 1025)]
				void ClearMetaKeyState(global::Android.View.View view, global::Android.Text.IEditable editable, int int32) /* MethodBuilder.Create */ ;

		}

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

				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 1028)]
				protected internal abstract char[] GetAcceptedChars() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I", AccessFlags = 4)]
				protected internal virtual int Lookup(global::Android.View.KeyEvent keyEvent, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence Filter(global::Java.Lang.ICharSequence charSequence, int int32, int int321, global::Android.Text.ISpanned spanned, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// ok
				/// </java-name>
				[Dot42.DexImport("ok", "([CC)Z", AccessFlags = 12)]
				protected internal static bool Ok(char[] @char, char char1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAcceptedChars
				/// </java-name>
				protected internal char[] AcceptedChars
				{
				[Dot42.DexImport("getAcceptedChars", "()[C", AccessFlags = 1028)]
						get{ return GetAcceptedChars(); }
				}

		}

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
				void Initialize(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/widget/TextView;Landroid/text/Spannable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool OnKeyOther(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1025)]
				void OnTakeFocus(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				bool OnTrackballEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				bool OnTouchEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				bool OnGenericMotionEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// canSelectArbitrarily
				/// </java-name>
				[Dot42.DexImport("canSelectArbitrarily", "()Z", AccessFlags = 1025)]
				bool CanSelectArbitrarily() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/text/method/BaseMovementMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/BaseMovementMethod", AccessFlags = 33)]
		public partial class BaseMovementMethod : global::Android.Text.Method.IMovementMethod
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BaseMovementMethod() /* MethodBuilder.Create */ 
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
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", AccessFlags = 1)]
				public virtual void Initialize(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
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
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyOther(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
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
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1)]
				public virtual void OnTakeFocus(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
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
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnGenericMotionEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMovementMetaState
				/// </java-name>
				[Dot42.DexImport("getMovementMetaState", "(Landroid/text/Spannable;Landroid/view/KeyEvent;)I", AccessFlags = 4)]
				protected internal virtual int GetMovementMetaState(global::Android.Text.ISpannable spannable, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// handleMovementKey
				/// </java-name>
				[Dot42.DexImport("handleMovementKey", "(Landroid/widget/TextView;Landroid/text/Spannable;IILandroid/view/KeyEvent;)Z", AccessFlags = 4)]
				protected internal virtual bool HandleMovementKey(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, int int321, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// left
				/// </java-name>
				[Dot42.DexImport("left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Left(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// right
				/// </java-name>
				[Dot42.DexImport("right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Right(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// up
				/// </java-name>
				[Dot42.DexImport("up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Up(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// down
				/// </java-name>
				[Dot42.DexImport("down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Down(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pageUp
				/// </java-name>
				[Dot42.DexImport("pageUp", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool PageUp(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// pageDown
				/// </java-name>
				[Dot42.DexImport("pageDown", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool PageDown(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// top
				/// </java-name>
				[Dot42.DexImport("top", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Top(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// bottom
				/// </java-name>
				[Dot42.DexImport("bottom", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Bottom(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lineStart
				/// </java-name>
				[Dot42.DexImport("lineStart", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool LineStart(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// lineEnd
				/// </java-name>
				[Dot42.DexImport("lineEnd", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool LineEnd(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// home
				/// </java-name>
				[Dot42.DexImport("home", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool Home(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// end
				/// </java-name>
				[Dot42.DexImport("end", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal virtual bool End(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <java-name>
		/// android/text/method/CharacterPickerDialog
		/// </java-name>
		[Dot42.DexImport("android/text/method/CharacterPickerDialog", AccessFlags = 33)]
		public partial class CharacterPickerDialog : global::Android.App.Dialog, global::Android.Widget.AdapterView<object>.IOnItemClickListener, global::Android.View.View.IOnClickListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/View;Landroid/text/Editable;Ljava/lang/St" +
    "ring;Z)V", AccessFlags = 1)]
				public CharacterPickerDialog(global::Android.Content.Context context, global::Android.View.View view, global::Android.Text.IEditable editable, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "(Landroid/os/Bundle;)V", AccessFlags = 4)]
				protected internal override void OnCreate(global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onItemClick
				/// </java-name>
				[Dot42.DexImport("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", AccessFlags = 1)]
				public virtual void OnItemClick(global::Android.Widget.AdapterView<object> adapterView, global::Android.View.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CharacterPickerDialog() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

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
				/// handleMovementKey
				/// </java-name>
				[Dot42.DexImport("handleMovementKey", "(Landroid/widget/TextView;Landroid/text/Spannable;IILandroid/view/KeyEvent;)Z", AccessFlags = 4)]
				protected internal override bool HandleMovementKey(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32, int int321, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// up
				/// </java-name>
				[Dot42.DexImport("up", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Up(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// down
				/// </java-name>
				[Dot42.DexImport("down", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Down(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// left
				/// </java-name>
				[Dot42.DexImport("left", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Left(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// right
				/// </java-name>
				[Dot42.DexImport("right", "(Landroid/widget/TextView;Landroid/text/Spannable;)Z", AccessFlags = 4)]
				protected internal override bool Right(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// initialize
				/// </java-name>
				[Dot42.DexImport("initialize", "(Landroid/widget/TextView;Landroid/text/Spannable;)V", AccessFlags = 1)]
				public override void Initialize(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTakeFocus
				/// </java-name>
				[Dot42.DexImport("onTakeFocus", "(Landroid/widget/TextView;Landroid/text/Spannable;I)V", AccessFlags = 1)]
				public override void OnTakeFocus(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, int int32) /* MethodBuilder.Create */ 
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

		/// <java-name>
		/// android/text/method/TimeKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/TimeKeyListener", AccessFlags = 33)]
		public partial class TimeKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CHARACTERS", "[C", AccessFlags = 25)]
				public static readonly char[] CHARACTERS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public TimeKeyListener() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

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

		/// <java-name>
		/// android/text/method/TextKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/TextKeyListener", AccessFlags = 33)]
		public partial class TextKeyListener : global::Android.Text.Method.BaseKeyListener, global::Android.Text.ISpanWatcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V", AccessFlags = 1)]
				public TextKeyListener(global::Android.Text.Method.TextKeyListener.Capitalize capitalize, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/TextKeyLi" +
    "stener;", AccessFlags = 9)]
				public static global::Android.Text.Method.TextKeyListener GetInstance(bool boolean, global::Android.Text.Method.TextKeyListener.Capitalize capitalize) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.TextKeyListener);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "()Landroid/text/method/TextKeyListener;", AccessFlags = 9)]
				public static global::Android.Text.Method.TextKeyListener GetInstance() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.Method.TextKeyListener);
				}

				/// <java-name>
				/// shouldCap
				/// </java-name>
				[Dot42.DexImport("shouldCap", "(Landroid/text/method/TextKeyListener$Capitalize;Ljava/lang/CharSequence;I)Z", AccessFlags = 9)]
				public static bool ShouldCap(global::Android.Text.Method.TextKeyListener.Capitalize capitalize, global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(global::Android.View.View view, global::Android.Text.IEditable editable, int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyOther
				/// </java-name>
				[Dot42.DexImport("onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyOther(global::Android.View.View view, global::Android.Text.IEditable editable, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "(Landroid/text/Editable;)V", AccessFlags = 9)]
				public static void Clear(global::Android.Text.IEditable editable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSpanAdded
				/// </java-name>
				[Dot42.DexImport("onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void OnSpanAdded(global::Android.Text.ISpannable spannable, object @object, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSpanRemoved
				/// </java-name>
				[Dot42.DexImport("onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V", AccessFlags = 1)]
				public virtual void OnSpanRemoved(global::Android.Text.ISpannable spannable, object @object, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSpanChanged
				/// </java-name>
				[Dot42.DexImport("onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V", AccessFlags = 1)]
				public virtual void OnSpanChanged(global::Android.Text.ISpannable spannable, object @object, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Text.Method.TextKeyListener Instance
				{
				[Dot42.DexImport("getInstance", "()Landroid/text/method/TextKeyListener;", AccessFlags = 9)]
						get{ return GetInstance(); }
				}

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

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/text/method/TextKeyListener$Capitalize;", AccessFlags = 9)]
						public static Capitalize[] Values() /* MethodBuilder.Create */ 
						{
								return default(Capitalize[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/text/method/TextKeyListener$Capitalize;", AccessFlags = 9)]
						public static Capitalize ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(Capitalize);
						}

				}

		}

		/// <java-name>
		/// android/text/method/DialerKeyListener
		/// </java-name>
		[Dot42.DexImport("android/text/method/DialerKeyListener", AccessFlags = 33)]
		public partial class DialerKeyListener : global::Android.Text.Method.NumberKeyListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CHARACTERS
				/// </java-name>
				[Dot42.DexImport("CHARACTERS", "[C", AccessFlags = 25)]
				public static readonly char[] CHARACTERS;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DialerKeyListener() /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public override int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// lookup
				/// </java-name>
				[Dot42.DexImport("lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I", AccessFlags = 4)]
				protected internal override int Lookup(global::Android.View.KeyEvent keyEvent, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				}

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

				/// <java-name>
				/// scrollTo
				/// </java-name>
				[Dot42.DexImport("scrollTo", "(Landroid/widget/TextView;Landroid/text/Layout;II)V", AccessFlags = 9)]
				public static void ScrollTo(global::Android.Widget.TextView textView, global::Android.Text.Layout layout, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", AccessFlags = 9)]
				public static bool OnTouchEvent(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getInitialScrollX
				/// </java-name>
				[Dot42.DexImport("getInitialScrollX", "(Landroid/widget/TextView;Landroid/text/Spannable;)I", AccessFlags = 9)]
				public static int GetInitialScrollX(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getInitialScrollY
				/// </java-name>
				[Dot42.DexImport("getInitialScrollY", "(Landroid/widget/TextView;Landroid/text/Spannable;)I", AccessFlags = 9)]
				public static int GetInitialScrollY(global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

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

				/// <java-name>
				/// getOriginal
				/// </java-name>
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 4)]
				protected internal override char[] GetOriginal() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

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

				/// <java-name>
				/// getOriginal
				/// </java-name>
				protected internal char[] Original
				{
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 4)]
						get{ return GetOriginal(); }
				}

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

				/// <java-name>
				/// getOriginal
				/// </java-name>
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 4)]
				protected internal override char[] GetOriginal() /* MethodBuilder.Create */ 
				{
						return default(char[]);
				}

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

				/// <java-name>
				/// getOriginal
				/// </java-name>
				protected internal char[] Original
				{
				[Dot42.DexImport("getOriginal", "()[C", AccessFlags = 4)]
						get{ return GetOriginal(); }
				}

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

		/// <java-name>
		/// android/text/method/TransformationMethod
		/// </java-name>
		[Dot42.DexImport("android/text/method/TransformationMethod", AccessFlags = 1537)]
		public partial interface ITransformationMethod
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getTransformation
				/// </java-name>
				[Dot42.DexImport("getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence GetTransformation(global::Java.Lang.ICharSequence charSequence, global::Android.View.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", AccessFlags = 1025)]
				void OnFocusChanged(global::Android.View.View view, global::Java.Lang.ICharSequence charSequence, bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ ;

		}

}

