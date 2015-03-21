#pragma warning disable 1717
namespace Android.Inputmethodservice
{
		/// <java-name>
		/// android/inputmethodservice/AbstractInputMethodService
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/AbstractInputMethodService", AccessFlags = 1057)]
		public abstract partial class AbstractInputMethodService : global::Android.App.Service, global::Android.View.KeyEvent.ICallback
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AbstractInputMethodService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeyDispatcherState
				/// </java-name>
				[Dot42.DexImport("getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", AccessFlags = 1)]
				public virtual global::Android.View.KeyEvent.DispatcherState GetKeyDispatcherState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.KeyEvent.DispatcherState);
				}

				/// <java-name>
				/// onCreateInputMethodInterface
				/// </java-name>
				[Dot42.DexImport("onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;" +
    "", AccessFlags = 1025)]
				public abstract global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl OnCreateInputMethodInterface() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onCreateInputMethodSessionInterface
				/// </java-name>
				[Dot42.DexImport("onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessi" +
    "onImpl;", AccessFlags = 1025)]
				public abstract global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl OnCreateInputMethodSessionInterface() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void Dump(global::Java.Io.FileDescriptor fileDescriptor, global::Java.Io.PrintWriter printWriter, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTrackballEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/view/KeyEvent$Callback", "onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public virtual bool OnKeyDown(int int32, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/view/KeyEvent$Callback", "onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public virtual bool OnKeyLongPress(int int32, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/view/KeyEvent$Callback", "onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public virtual bool OnKeyUp(int int32, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				[Dot42.DexImport("android/view/KeyEvent$Callback", "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public virtual bool OnKeyMultiple(int int32, int int321, global::Android.View.KeyEvent keyEvent) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getKeyDispatcherState
				/// </java-name>
				public global::Android.View.KeyEvent.DispatcherState KeyDispatcherState
				{
				[Dot42.DexImport("getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", AccessFlags = 1)]
						get{ return GetKeyDispatcherState(); }
				}

				/// <java-name>
				/// android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionImpl
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessionI" +
    "mpl", AccessFlags = 1025)]
				public abstract partial class AbstractInputMethodSessionImpl : global::Android.View.Inputmethod.IInputMethodSession
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/inputmethodservice/AbstractInputMethodService;", AccessFlags = 4112)]
						internal readonly global::Android.Inputmethodservice.AbstractInputMethodService This_0;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V", AccessFlags = 1)]
						public AbstractInputMethodSessionImpl(global::Android.Inputmethodservice.AbstractInputMethodService abstractInputMethodService) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isEnabled
						/// </java-name>
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						public virtual bool IsEnabled() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// isRevoked
						/// </java-name>
						[Dot42.DexImport("isRevoked", "()Z", AccessFlags = 1)]
						public virtual bool IsRevoked() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// setEnabled
						/// </java-name>
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						public virtual void SetEnabled(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// revokeSelf
						/// </java-name>
						[Dot42.DexImport("revokeSelf", "()V", AccessFlags = 1)]
						public virtual void RevokeSelf() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dispatchKeyEvent
						/// </java-name>
						[Dot42.DexImport("dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallba" +
    "ck;)V", AccessFlags = 1)]
						public virtual void DispatchKeyEvent(int int32, global::Android.View.KeyEvent keyEvent, global::Android.View.Inputmethod.IInputMethodSession_IEventCallback inputMethodSession_IEventCallback) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dispatchTrackballEvent
						/// </java-name>
						[Dot42.DexImport("dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCal" +
    "lback;)V", AccessFlags = 1)]
						public virtual void DispatchTrackballEvent(int int32, global::Android.View.MotionEvent motionEvent, global::Android.View.Inputmethod.IInputMethodSession_IEventCallback inputMethodSession_IEventCallback) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AbstractInputMethodSessionImpl() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "finishInput", "()V", AccessFlags = 1025)]
						public virtual void FinishInput() /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "updateSelection", "(IIIIII)V", AccessFlags = 1025)]
						public virtual void UpdateSelection(int int32, int int321, int int322, int int323, int int324, int int325) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "viewClicked", "(Z)V", AccessFlags = 1025)]
						public virtual void ViewClicked(bool boolean) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "updateCursor", "(Landroid/graphics/Rect;)V", AccessFlags = 1025)]
						public virtual void UpdateCursor(global::Android.Graphics.Rect rect) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1025)]
						public virtual void DisplayCompletions(global::Android.View.Inputmethod.CompletionInfo[] completionInfo) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1025)]
						public virtual void UpdateExtractedText(int int32, global::Android.View.Inputmethod.ExtractedText extractedText) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1025)]
						public virtual void AppPrivateCommand(string @string, global::Android.Os.Bundle bundle) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethodSession", "toggleSoftInput", "(II)V", AccessFlags = 1025)]
						public virtual void ToggleSoftInput(int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

				}

				/// <java-name>
				/// android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl", AccessFlags = 1025)]
				public abstract partial class AbstractInputMethodImpl : global::Android.View.Inputmethod.IInputMethod
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/inputmethodservice/AbstractInputMethodService;", AccessFlags = 4112)]
						internal readonly global::Android.Inputmethodservice.AbstractInputMethodService This_0;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/AbstractInputMethodService;)V", AccessFlags = 1)]
						public AbstractInputMethodImpl(global::Android.Inputmethodservice.AbstractInputMethodService abstractInputMethodService) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// createSession
						/// </java-name>
						[Dot42.DexImport("createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", AccessFlags = 1)]
						public virtual void CreateSession(global::Android.View.Inputmethod.IInputMethod_ISessionCallback inputMethod_ISessionCallback) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setSessionEnabled
						/// </java-name>
						[Dot42.DexImport("setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V", AccessFlags = 1)]
						public virtual void SetSessionEnabled(global::Android.View.Inputmethod.IInputMethodSession inputMethodSession, bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// revokeSession
						/// </java-name>
						[Dot42.DexImport("revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", AccessFlags = 1)]
						public virtual void RevokeSession(global::Android.View.Inputmethod.IInputMethodSession inputMethodSession) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AbstractInputMethodImpl() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "attachToken", "(Landroid/os/IBinder;)V", AccessFlags = 1025)]
						public virtual void AttachToken(global::Android.Os.IBinder binder) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "bindInput", "(Landroid/view/inputmethod/InputBinding;)V", AccessFlags = 1025)]
						public virtual void BindInput(global::Android.View.Inputmethod.InputBinding inputBinding) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "unbindInput", "()V", AccessFlags = 1025)]
						public virtual void UnbindInput() /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1025)]
						public virtual void StartInput(global::Android.View.Inputmethod.IInputConnection inputConnection, global::Android.View.Inputmethod.EditorInfo editorInfo) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1025)]
						public virtual void RestartInput(global::Android.View.Inputmethod.IInputConnection inputConnection, global::Android.View.Inputmethod.EditorInfo editorInfo) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "showSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1025)]
						public virtual void ShowSoftInput(int int32, global::Android.Os.ResultReceiver resultReceiver) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "hideSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1025)]
						public virtual void HideSoftInput(int int32, global::Android.Os.ResultReceiver resultReceiver) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

						[Dot42.DexImport("android/view/inputmethod/InputMethod", "changeInputMethodSubtype", "(Landroid/view/inputmethod/InputMethodSubtype;)V", AccessFlags = 1025)]
						public virtual void ChangeInputMethodSubtype(global::Android.View.Inputmethod.InputMethodSubtype inputMethodSubtype) /* TypeBuilder.AddAbstractInterfaceMethods */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/inputmethodservice/ExtractEditText
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/ExtractEditText", AccessFlags = 33)]
		public partial class ExtractEditText : global::Android.Widget.EditText
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ExtractEditText(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ExtractEditText(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ExtractEditText(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startInternalChanges
				/// </java-name>
				[Dot42.DexImport("startInternalChanges", "()V", AccessFlags = 1)]
				public virtual void StartInternalChanges() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finishInternalChanges
				/// </java-name>
				[Dot42.DexImport("finishInternalChanges", "()V", AccessFlags = 1)]
				public virtual void FinishInternalChanges() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExtractedText
				/// </java-name>
				[Dot42.DexImport("setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
				public override void SetExtractedText(global::Android.View.Inputmethod.ExtractedText extractedText) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSelectionChanged
				/// </java-name>
				[Dot42.DexImport("onSelectionChanged", "(II)V", AccessFlags = 4)]
				protected internal override void OnSelectionChanged(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performClick
				/// </java-name>
				[Dot42.DexImport("performClick", "()Z", AccessFlags = 1)]
				public override bool PerformClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTextContextMenuItem
				/// </java-name>
				[Dot42.DexImport("onTextContextMenuItem", "(I)Z", AccessFlags = 1)]
				public override bool OnTextContextMenuItem(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isInputMethodTarget
				/// </java-name>
				[Dot42.DexImport("isInputMethodTarget", "()Z", AccessFlags = 1)]
				public override bool IsInputMethodTarget() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasVerticalScrollBar
				/// </java-name>
				[Dot42.DexImport("hasVerticalScrollBar", "()Z", AccessFlags = 1)]
				public virtual bool HasVerticalScrollBar() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasWindowFocus
				/// </java-name>
				[Dot42.DexImport("hasWindowFocus", "()Z", AccessFlags = 1)]
				public override bool HasWindowFocus() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isFocused
				/// </java-name>
				[Dot42.DexImport("isFocused", "()Z", AccessFlags = 1)]
				public override bool IsFocused() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasFocus
				/// </java-name>
				[Dot42.DexImport("hasFocus", "()Z", AccessFlags = 1)]
				public override bool HasFocus() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ExtractEditText() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/inputmethodservice/InputMethodService
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/InputMethodService", AccessFlags = 33)]
		public partial class InputMethodService : global::Android.Inputmethodservice.AbstractInputMethodService
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BACK_DISPOSITION_DEFAULT
				/// </java-name>
				[Dot42.DexImport("BACK_DISPOSITION_DEFAULT", "I", AccessFlags = 25)]
				public const int BACK_DISPOSITION_DEFAULT = 0;
				/// <java-name>
				/// BACK_DISPOSITION_WILL_NOT_DISMISS
				/// </java-name>
				[Dot42.DexImport("BACK_DISPOSITION_WILL_NOT_DISMISS", "I", AccessFlags = 25)]
				public const int BACK_DISPOSITION_WILL_NOT_DISMISS = 1;
				/// <java-name>
				/// BACK_DISPOSITION_WILL_DISMISS
				/// </java-name>
				[Dot42.DexImport("BACK_DISPOSITION_WILL_DISMISS", "I", AccessFlags = 25)]
				public const int BACK_DISPOSITION_WILL_DISMISS = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InputMethodService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1)]
				public override void SetTheme(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeInterface
				/// </java-name>
				[Dot42.DexImport("onInitializeInterface", "()V", AccessFlags = 1)]
				public virtual void OnInitializeInterface() /* MethodBuilder.Create */ 
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
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public override void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateInputMethodInterface
				/// </java-name>
				[Dot42.DexImport("onCreateInputMethodInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodImpl;" +
    "", AccessFlags = 1)]
				public override global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl OnCreateInputMethodInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl);
				}

				/// <java-name>
				/// onCreateInputMethodSessionInterface
				/// </java-name>
				[Dot42.DexImport("onCreateInputMethodSessionInterface", "()Landroid/inputmethodservice/AbstractInputMethodService$AbstractInputMethodSessi" +
    "onImpl;", AccessFlags = 1)]
				public override global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl OnCreateInputMethodSessionInterface() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl);
				}

				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1)]
				public virtual global::Android.View.LayoutInflater GetLayoutInflater() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.LayoutInflater);
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				[Dot42.DexImport("getWindow", "()Landroid/app/Dialog;", AccessFlags = 1)]
				public virtual global::Android.App.Dialog GetWindow() /* MethodBuilder.Create */ 
				{
						return default(global::Android.App.Dialog);
				}

				/// <java-name>
				/// setBackDisposition
				/// </java-name>
				[Dot42.DexImport("setBackDisposition", "(I)V", AccessFlags = 1)]
				public virtual void SetBackDisposition(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBackDisposition
				/// </java-name>
				[Dot42.DexImport("getBackDisposition", "()I", AccessFlags = 1)]
				public virtual int GetBackDisposition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMaxWidth
				/// </java-name>
				[Dot42.DexImport("getMaxWidth", "()I", AccessFlags = 1)]
				public virtual int GetMaxWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getCurrentInputBinding
				/// </java-name>
				[Dot42.DexImport("getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;", AccessFlags = 1)]
				public virtual global::Android.View.Inputmethod.InputBinding GetCurrentInputBinding() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.InputBinding);
				}

				/// <java-name>
				/// getCurrentInputConnection
				/// </java-name>
				[Dot42.DexImport("getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;", AccessFlags = 1)]
				public virtual global::Android.View.Inputmethod.IInputConnection GetCurrentInputConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.IInputConnection);
				}

				/// <java-name>
				/// getCurrentInputStarted
				/// </java-name>
				[Dot42.DexImport("getCurrentInputStarted", "()Z", AccessFlags = 1)]
				public virtual bool GetCurrentInputStarted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCurrentInputEditorInfo
				/// </java-name>
				[Dot42.DexImport("getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Inputmethod.EditorInfo GetCurrentInputEditorInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Inputmethod.EditorInfo);
				}

				/// <java-name>
				/// updateFullscreenMode
				/// </java-name>
				[Dot42.DexImport("updateFullscreenMode", "()V", AccessFlags = 1)]
				public virtual void UpdateFullscreenMode() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigureWindow
				/// </java-name>
				[Dot42.DexImport("onConfigureWindow", "(Landroid/view/Window;ZZ)V", AccessFlags = 1)]
				public virtual void OnConfigureWindow(global::Android.View.Window window, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFullscreenMode
				/// </java-name>
				[Dot42.DexImport("isFullscreenMode", "()Z", AccessFlags = 1)]
				public virtual bool IsFullscreenMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onEvaluateFullscreenMode
				/// </java-name>
				[Dot42.DexImport("onEvaluateFullscreenMode", "()Z", AccessFlags = 1)]
				public virtual bool OnEvaluateFullscreenMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setExtractViewShown
				/// </java-name>
				[Dot42.DexImport("setExtractViewShown", "(Z)V", AccessFlags = 1)]
				public virtual void SetExtractViewShown(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isExtractViewShown
				/// </java-name>
				[Dot42.DexImport("isExtractViewShown", "()Z", AccessFlags = 1)]
				public virtual bool IsExtractViewShown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onComputeInsets
				/// </java-name>
				[Dot42.DexImport("onComputeInsets", "(Landroid/inputmethodservice/InputMethodService$Insets;)V", AccessFlags = 1)]
				public virtual void OnComputeInsets(global::Android.Inputmethodservice.InputMethodService.Insets insets) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateInputViewShown
				/// </java-name>
				[Dot42.DexImport("updateInputViewShown", "()V", AccessFlags = 1)]
				public virtual void UpdateInputViewShown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isShowInputRequested
				/// </java-name>
				[Dot42.DexImport("isShowInputRequested", "()Z", AccessFlags = 1)]
				public virtual bool IsShowInputRequested() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isInputViewShown
				/// </java-name>
				[Dot42.DexImport("isInputViewShown", "()Z", AccessFlags = 1)]
				public virtual bool IsInputViewShown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onEvaluateInputViewShown
				/// </java-name>
				[Dot42.DexImport("onEvaluateInputViewShown", "()Z", AccessFlags = 1)]
				public virtual bool OnEvaluateInputViewShown() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setCandidatesViewShown
				/// </java-name>
				[Dot42.DexImport("setCandidatesViewShown", "(Z)V", AccessFlags = 1)]
				public virtual void SetCandidatesViewShown(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCandidatesHiddenVisibility
				/// </java-name>
				[Dot42.DexImport("getCandidatesHiddenVisibility", "()I", AccessFlags = 1)]
				public virtual int GetCandidatesHiddenVisibility() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// showStatusIcon
				/// </java-name>
				[Dot42.DexImport("showStatusIcon", "(I)V", AccessFlags = 1)]
				public virtual void ShowStatusIcon(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hideStatusIcon
				/// </java-name>
				[Dot42.DexImport("hideStatusIcon", "()V", AccessFlags = 1)]
				public virtual void HideStatusIcon() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// switchInputMethod
				/// </java-name>
				[Dot42.DexImport("switchInputMethod", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SwitchInputMethod(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExtractView
				/// </java-name>
				[Dot42.DexImport("setExtractView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetExtractView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCandidatesView
				/// </java-name>
				[Dot42.DexImport("setCandidatesView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetCandidatesView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInputView
				/// </java-name>
				[Dot42.DexImport("setInputView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetInputView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateExtractTextView
				/// </java-name>
				[Dot42.DexImport("onCreateExtractTextView", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View OnCreateExtractTextView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <java-name>
				/// onCreateCandidatesView
				/// </java-name>
				[Dot42.DexImport("onCreateCandidatesView", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View OnCreateCandidatesView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <java-name>
				/// onCreateInputView
				/// </java-name>
				[Dot42.DexImport("onCreateInputView", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View OnCreateInputView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <java-name>
				/// onStartInputView
				/// </java-name>
				[Dot42.DexImport("onStartInputView", "(Landroid/view/inputmethod/EditorInfo;Z)V", AccessFlags = 1)]
				public virtual void OnStartInputView(global::Android.View.Inputmethod.EditorInfo editorInfo, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInputView
				/// </java-name>
				[Dot42.DexImport("onFinishInputView", "(Z)V", AccessFlags = 1)]
				public virtual void OnFinishInputView(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartCandidatesView
				/// </java-name>
				[Dot42.DexImport("onStartCandidatesView", "(Landroid/view/inputmethod/EditorInfo;Z)V", AccessFlags = 1)]
				public virtual void OnStartCandidatesView(global::Android.View.Inputmethod.EditorInfo editorInfo, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishCandidatesView
				/// </java-name>
				[Dot42.DexImport("onFinishCandidatesView", "(Z)V", AccessFlags = 1)]
				public virtual void OnFinishCandidatesView(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onShowInputRequested
				/// </java-name>
				[Dot42.DexImport("onShowInputRequested", "(IZ)Z", AccessFlags = 1)]
				public virtual bool OnShowInputRequested(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// showWindow
				/// </java-name>
				[Dot42.DexImport("showWindow", "(Z)V", AccessFlags = 1)]
				public virtual void ShowWindow(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hideWindow
				/// </java-name>
				[Dot42.DexImport("hideWindow", "()V", AccessFlags = 1)]
				public virtual void HideWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowShown
				/// </java-name>
				[Dot42.DexImport("onWindowShown", "()V", AccessFlags = 1)]
				public virtual void OnWindowShown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowHidden
				/// </java-name>
				[Dot42.DexImport("onWindowHidden", "()V", AccessFlags = 1)]
				public virtual void OnWindowHidden() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBindInput
				/// </java-name>
				[Dot42.DexImport("onBindInput", "()V", AccessFlags = 1)]
				public virtual void OnBindInput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUnbindInput
				/// </java-name>
				[Dot42.DexImport("onUnbindInput", "()V", AccessFlags = 1)]
				public virtual void OnUnbindInput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartInput
				/// </java-name>
				[Dot42.DexImport("onStartInput", "(Landroid/view/inputmethod/EditorInfo;Z)V", AccessFlags = 1)]
				public virtual void OnStartInput(global::Android.View.Inputmethod.EditorInfo editorInfo, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInput
				/// </java-name>
				[Dot42.DexImport("onFinishInput", "()V", AccessFlags = 1)]
				public virtual void OnFinishInput() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisplayCompletions
				/// </java-name>
				[Dot42.DexImport("onDisplayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
				public virtual void OnDisplayCompletions(global::Android.View.Inputmethod.CompletionInfo[] completionInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUpdateExtractedText
				/// </java-name>
				[Dot42.DexImport("onUpdateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
				public virtual void OnUpdateExtractedText(int int32, global::Android.View.Inputmethod.ExtractedText extractedText) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUpdateSelection
				/// </java-name>
				[Dot42.DexImport("onUpdateSelection", "(IIIIII)V", AccessFlags = 1)]
				public virtual void OnUpdateSelection(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onViewClicked
				/// </java-name>
				[Dot42.DexImport("onViewClicked", "(Z)V", AccessFlags = 1)]
				public virtual void OnViewClicked(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUpdateCursor
				/// </java-name>
				[Dot42.DexImport("onUpdateCursor", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void OnUpdateCursor(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestHideSelf
				/// </java-name>
				[Dot42.DexImport("requestHideSelf", "(I)V", AccessFlags = 1)]
				public virtual void RequestHideSelf(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyLongPress
				/// </java-name>
				[Dot42.DexImport("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyLongPress(int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int int32, int int321, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.View.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onAppPrivateCommand
				/// </java-name>
				[Dot42.DexImport("onAppPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void OnAppPrivateCommand(string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendDownUpKeyEvents
				/// </java-name>
				[Dot42.DexImport("sendDownUpKeyEvents", "(I)V", AccessFlags = 1)]
				public virtual void SendDownUpKeyEvents(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendDefaultEditorAction
				/// </java-name>
				[Dot42.DexImport("sendDefaultEditorAction", "(Z)Z", AccessFlags = 1)]
				public virtual bool SendDefaultEditorAction(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendKeyChar
				/// </java-name>
				[Dot42.DexImport("sendKeyChar", "(C)V", AccessFlags = 1)]
				public virtual void SendKeyChar(char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onExtractedSelectionChanged
				/// </java-name>
				[Dot42.DexImport("onExtractedSelectionChanged", "(II)V", AccessFlags = 1)]
				public virtual void OnExtractedSelectionChanged(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onExtractedTextClicked
				/// </java-name>
				[Dot42.DexImport("onExtractedTextClicked", "()V", AccessFlags = 1)]
				public virtual void OnExtractedTextClicked() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onExtractedCursorMovement
				/// </java-name>
				[Dot42.DexImport("onExtractedCursorMovement", "(II)V", AccessFlags = 1)]
				public virtual void OnExtractedCursorMovement(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onExtractTextContextMenuItem
				/// </java-name>
				[Dot42.DexImport("onExtractTextContextMenuItem", "(I)Z", AccessFlags = 1)]
				public virtual bool OnExtractTextContextMenuItem(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getTextForImeAction
				/// </java-name>
				[Dot42.DexImport("getTextForImeAction", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextForImeAction(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// onUpdateExtractingVisibility
				/// </java-name>
				[Dot42.DexImport("onUpdateExtractingVisibility", "(Landroid/view/inputmethod/EditorInfo;)V", AccessFlags = 1)]
				public virtual void OnUpdateExtractingVisibility(global::Android.View.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUpdateExtractingViews
				/// </java-name>
				[Dot42.DexImport("onUpdateExtractingViews", "(Landroid/view/inputmethod/EditorInfo;)V", AccessFlags = 1)]
				public virtual void OnUpdateExtractingViews(global::Android.View.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onExtractingInputChanged
				/// </java-name>
				[Dot42.DexImport("onExtractingInputChanged", "(Landroid/view/inputmethod/EditorInfo;)V", AccessFlags = 1)]
				public virtual void OnExtractingInputChanged(global::Android.View.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCurrentInputMethodSubtypeChanged
				/// </java-name>
				[Dot42.DexImport("onCurrentInputMethodSubtypeChanged", "(Landroid/view/inputmethod/InputMethodSubtype;)V", AccessFlags = 4)]
				protected internal virtual void OnCurrentInputMethodSubtypeChanged(global::Android.View.Inputmethod.InputMethodSubtype inputMethodSubtype) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void Dump(global::Java.Io.FileDescriptor fileDescriptor, global::Java.Io.PrintWriter printWriter, string[] @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				public global::Android.View.LayoutInflater LayoutInflater
				{
				[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1)]
						get{ return GetLayoutInflater(); }
				}

				/// <java-name>
				/// getWindow
				/// </java-name>
				public global::Android.App.Dialog Window
				{
				[Dot42.DexImport("getWindow", "()Landroid/app/Dialog;", AccessFlags = 1)]
						get{ return GetWindow(); }
				}

				/// <java-name>
				/// getBackDisposition
				/// </java-name>
				public int BackDisposition
				{
				[Dot42.DexImport("getBackDisposition", "()I", AccessFlags = 1)]
						get{ return GetBackDisposition(); }
				[Dot42.DexImport("setBackDisposition", "(I)V", AccessFlags = 1)]
						set{ SetBackDisposition(value); }
				}

				/// <java-name>
				/// getMaxWidth
				/// </java-name>
				public int MaxWidth
				{
				[Dot42.DexImport("getMaxWidth", "()I", AccessFlags = 1)]
						get{ return GetMaxWidth(); }
				}

				/// <java-name>
				/// getCurrentInputBinding
				/// </java-name>
				public global::Android.View.Inputmethod.InputBinding CurrentInputBinding
				{
				[Dot42.DexImport("getCurrentInputBinding", "()Landroid/view/inputmethod/InputBinding;", AccessFlags = 1)]
						get{ return GetCurrentInputBinding(); }
				}

				/// <java-name>
				/// getCurrentInputConnection
				/// </java-name>
				public global::Android.View.Inputmethod.IInputConnection CurrentInputConnection
				{
				[Dot42.DexImport("getCurrentInputConnection", "()Landroid/view/inputmethod/InputConnection;", AccessFlags = 1)]
						get{ return GetCurrentInputConnection(); }
				}

				/// <java-name>
				/// getCurrentInputStarted
				/// </java-name>
				public bool IsCurrentInputStarted
				{
				[Dot42.DexImport("getCurrentInputStarted", "()Z", AccessFlags = 1)]
						get{ return GetCurrentInputStarted(); }
				}

				/// <java-name>
				/// getCurrentInputEditorInfo
				/// </java-name>
				public global::Android.View.Inputmethod.EditorInfo CurrentInputEditorInfo
				{
				[Dot42.DexImport("getCurrentInputEditorInfo", "()Landroid/view/inputmethod/EditorInfo;", AccessFlags = 1)]
						get{ return GetCurrentInputEditorInfo(); }
				}

				/// <java-name>
				/// getCandidatesHiddenVisibility
				/// </java-name>
				public int CandidatesHiddenVisibility
				{
				[Dot42.DexImport("getCandidatesHiddenVisibility", "()I", AccessFlags = 1)]
						get{ return GetCandidatesHiddenVisibility(); }
				}

				/// <java-name>
				/// android/inputmethodservice/InputMethodService$Insets
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/InputMethodService$Insets", AccessFlags = 25)]
				public sealed partial class Insets
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// contentTopInsets
						/// </java-name>
						[Dot42.DexImport("contentTopInsets", "I", AccessFlags = 1)]
						public int ContentTopInsets;
						/// <java-name>
						/// visibleTopInsets
						/// </java-name>
						[Dot42.DexImport("visibleTopInsets", "I", AccessFlags = 1)]
						public int VisibleTopInsets;
						/// <java-name>
						/// touchableRegion
						/// </java-name>
						[Dot42.DexImport("touchableRegion", "Landroid/graphics/Region;", AccessFlags = 17)]
						public readonly global::Android.Graphics.Region TouchableRegion;
						/// <java-name>
						/// TOUCHABLE_INSETS_FRAME
						/// </java-name>
						[Dot42.DexImport("TOUCHABLE_INSETS_FRAME", "I", AccessFlags = 25)]
						public const int TOUCHABLE_INSETS_FRAME = 0;
						/// <java-name>
						/// TOUCHABLE_INSETS_CONTENT
						/// </java-name>
						[Dot42.DexImport("TOUCHABLE_INSETS_CONTENT", "I", AccessFlags = 25)]
						public const int TOUCHABLE_INSETS_CONTENT = 1;
						/// <java-name>
						/// TOUCHABLE_INSETS_VISIBLE
						/// </java-name>
						[Dot42.DexImport("TOUCHABLE_INSETS_VISIBLE", "I", AccessFlags = 25)]
						public const int TOUCHABLE_INSETS_VISIBLE = 2;
						/// <java-name>
						/// TOUCHABLE_INSETS_REGION
						/// </java-name>
						[Dot42.DexImport("TOUCHABLE_INSETS_REGION", "I", AccessFlags = 25)]
						public const int TOUCHABLE_INSETS_REGION = 3;
						/// <java-name>
						/// touchableInsets
						/// </java-name>
						[Dot42.DexImport("touchableInsets", "I", AccessFlags = 1)]
						public int TouchableInsets;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Insets() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/inputmethodservice/InputMethodService$InputMethodSessionImpl
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/InputMethodService$InputMethodSessionImpl", AccessFlags = 1)]
				public partial class InputMethodSessionImpl : global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodSessionImpl
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/inputmethodservice/InputMethodService;", AccessFlags = 4112)]
						internal readonly global::Android.Inputmethodservice.InputMethodService This_0;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/InputMethodService;)V", AccessFlags = 1)]
						public InputMethodSessionImpl(global::Android.Inputmethodservice.InputMethodService inputMethodService) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// finishInput
						/// </java-name>
						[Dot42.DexImport("finishInput", "()V", AccessFlags = 1)]
						public override void FinishInput() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// displayCompletions
						/// </java-name>
						[Dot42.DexImport("displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
						public override void DisplayCompletions(global::Android.View.Inputmethod.CompletionInfo[] completionInfo) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// updateExtractedText
						/// </java-name>
						[Dot42.DexImport("updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
						public override void UpdateExtractedText(int int32, global::Android.View.Inputmethod.ExtractedText extractedText) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// updateSelection
						/// </java-name>
						[Dot42.DexImport("updateSelection", "(IIIIII)V", AccessFlags = 1)]
						public override void UpdateSelection(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// viewClicked
						/// </java-name>
						[Dot42.DexImport("viewClicked", "(Z)V", AccessFlags = 1)]
						public override void ViewClicked(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// updateCursor
						/// </java-name>
						[Dot42.DexImport("updateCursor", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
						public override void UpdateCursor(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// appPrivateCommand
						/// </java-name>
						[Dot42.DexImport("appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
						public override void AppPrivateCommand(string @string, global::Android.Os.Bundle bundle) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// toggleSoftInput
						/// </java-name>
						[Dot42.DexImport("toggleSoftInput", "(II)V", AccessFlags = 1)]
						public override void ToggleSoftInput(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal InputMethodSessionImpl() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/inputmethodservice/InputMethodService$InputMethodImpl
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/InputMethodService$InputMethodImpl", AccessFlags = 1)]
				public partial class InputMethodImpl : global::Android.Inputmethodservice.AbstractInputMethodService.AbstractInputMethodImpl
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/inputmethodservice/InputMethodService;", AccessFlags = 4112)]
						internal readonly global::Android.Inputmethodservice.InputMethodService This_0;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/InputMethodService;)V", AccessFlags = 1)]
						public InputMethodImpl(global::Android.Inputmethodservice.InputMethodService inputMethodService) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// attachToken
						/// </java-name>
						[Dot42.DexImport("attachToken", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
						public override void AttachToken(global::Android.Os.IBinder binder) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// bindInput
						/// </java-name>
						[Dot42.DexImport("bindInput", "(Landroid/view/inputmethod/InputBinding;)V", AccessFlags = 1)]
						public override void BindInput(global::Android.View.Inputmethod.InputBinding inputBinding) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// unbindInput
						/// </java-name>
						[Dot42.DexImport("unbindInput", "()V", AccessFlags = 1)]
						public override void UnbindInput() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// startInput
						/// </java-name>
						[Dot42.DexImport("startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1)]
						public override void StartInput(global::Android.View.Inputmethod.IInputConnection inputConnection, global::Android.View.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// restartInput
						/// </java-name>
						[Dot42.DexImport("restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1)]
						public override void RestartInput(global::Android.View.Inputmethod.IInputConnection inputConnection, global::Android.View.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// hideSoftInput
						/// </java-name>
						[Dot42.DexImport("hideSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1)]
						public override void HideSoftInput(int int32, global::Android.Os.ResultReceiver resultReceiver) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// showSoftInput
						/// </java-name>
						[Dot42.DexImport("showSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1)]
						public override void ShowSoftInput(int int32, global::Android.Os.ResultReceiver resultReceiver) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// changeInputMethodSubtype
						/// </java-name>
						[Dot42.DexImport("changeInputMethodSubtype", "(Landroid/view/inputmethod/InputMethodSubtype;)V", AccessFlags = 1)]
						public override void ChangeInputMethodSubtype(global::Android.View.Inputmethod.InputMethodSubtype inputMethodSubtype) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal InputMethodImpl() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/inputmethodservice/Keyboard
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/Keyboard", AccessFlags = 33)]
		public partial class Keyboard
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EDGE_LEFT
				/// </java-name>
				[Dot42.DexImport("EDGE_LEFT", "I", AccessFlags = 25)]
				public const int EDGE_LEFT = 1;
				/// <java-name>
				/// EDGE_RIGHT
				/// </java-name>
				[Dot42.DexImport("EDGE_RIGHT", "I", AccessFlags = 25)]
				public const int EDGE_RIGHT = 2;
				/// <java-name>
				/// EDGE_TOP
				/// </java-name>
				[Dot42.DexImport("EDGE_TOP", "I", AccessFlags = 25)]
				public const int EDGE_TOP = 4;
				/// <java-name>
				/// EDGE_BOTTOM
				/// </java-name>
				[Dot42.DexImport("EDGE_BOTTOM", "I", AccessFlags = 25)]
				public const int EDGE_BOTTOM = 8;
				/// <java-name>
				/// KEYCODE_SHIFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SHIFT", "I", AccessFlags = 25)]
				public const int KEYCODE_SHIFT = -1;
				/// <java-name>
				/// KEYCODE_MODE_CHANGE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MODE_CHANGE", "I", AccessFlags = 25)]
				public const int KEYCODE_MODE_CHANGE = -2;
				/// <java-name>
				/// KEYCODE_CANCEL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CANCEL", "I", AccessFlags = 25)]
				public const int KEYCODE_CANCEL = -3;
				/// <java-name>
				/// KEYCODE_DONE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DONE", "I", AccessFlags = 25)]
				public const int KEYCODE_DONE = -4;
				/// <java-name>
				/// KEYCODE_DELETE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DELETE", "I", AccessFlags = 25)]
				public const int KEYCODE_DELETE = -5;
				/// <java-name>
				/// KEYCODE_ALT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ALT", "I", AccessFlags = 25)]
				public const int KEYCODE_ALT = -6;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public Keyboard(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;IIII)V", AccessFlags = 1)]
				public Keyboard(global::Android.Content.Context context, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public Keyboard(global::Android.Content.Context context, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILjava/lang/CharSequence;II)V", AccessFlags = 1)]
				public Keyboard(global::Android.Content.Context context, int int32, global::Java.Lang.ICharSequence charSequence, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeys
				/// </java-name>
				[Dot42.DexImport("getKeys", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/inputmethodservice/Keyboard$Key;>;")]
				public virtual global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key> GetKeys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key>);
				}

				/// <java-name>
				/// getModifierKeys
				/// </java-name>
				[Dot42.DexImport("getModifierKeys", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/inputmethodservice/Keyboard$Key;>;")]
				public virtual global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key> GetModifierKeys() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key>);
				}

				/// <java-name>
				/// getHorizontalGap
				/// </java-name>
				[Dot42.DexImport("getHorizontalGap", "()I", AccessFlags = 4)]
				protected internal virtual int GetHorizontalGap() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setHorizontalGap
				/// </java-name>
				[Dot42.DexImport("setHorizontalGap", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetHorizontalGap(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVerticalGap
				/// </java-name>
				[Dot42.DexImport("getVerticalGap", "()I", AccessFlags = 4)]
				protected internal virtual int GetVerticalGap() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVerticalGap
				/// </java-name>
				[Dot42.DexImport("setVerticalGap", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetVerticalGap(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeyHeight
				/// </java-name>
				[Dot42.DexImport("getKeyHeight", "()I", AccessFlags = 4)]
				protected internal virtual int GetKeyHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setKeyHeight
				/// </java-name>
				[Dot42.DexImport("setKeyHeight", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetKeyHeight(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeyWidth
				/// </java-name>
				[Dot42.DexImport("getKeyWidth", "()I", AccessFlags = 4)]
				protected internal virtual int GetKeyWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setKeyWidth
				/// </java-name>
				[Dot42.DexImport("setKeyWidth", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetKeyWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
				public virtual int GetHeight() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMinWidth
				/// </java-name>
				[Dot42.DexImport("getMinWidth", "()I", AccessFlags = 1)]
				public virtual int GetMinWidth() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setShifted
				/// </java-name>
				[Dot42.DexImport("setShifted", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetShifted(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isShifted
				/// </java-name>
				[Dot42.DexImport("isShifted", "()Z", AccessFlags = 1)]
				public virtual bool IsShifted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getShiftKeyIndex
				/// </java-name>
				[Dot42.DexImport("getShiftKeyIndex", "()I", AccessFlags = 1)]
				public virtual int GetShiftKeyIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNearestKeys
				/// </java-name>
				[Dot42.DexImport("getNearestKeys", "(II)[I", AccessFlags = 1)]
				public virtual int[] GetNearestKeys(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// createRowFromXml
				/// </java-name>
				[Dot42.DexImport("createRowFromXml", "(Landroid/content/res/Resources;Landroid/content/res/XmlResourceParser;)Landroid/" +
    "inputmethodservice/Keyboard$Row;", AccessFlags = 4)]
				protected internal virtual global::Android.Inputmethodservice.Keyboard.Row CreateRowFromXml(global::Android.Content.Res.Resources resources, global::Android.Content.Res.IXmlResourceParser xmlResourceParser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.Keyboard.Row);
				}

				/// <java-name>
				/// createKeyFromXml
				/// </java-name>
				[Dot42.DexImport("createKeyFromXml", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandro" +
    "id/content/res/XmlResourceParser;)Landroid/inputmethodservice/Keyboard$Key;", AccessFlags = 4)]
				protected internal virtual global::Android.Inputmethodservice.Keyboard.Key CreateKeyFromXml(global::Android.Content.Res.Resources resources, global::Android.Inputmethodservice.Keyboard.Row row, int int32, int int321, global::Android.Content.Res.IXmlResourceParser xmlResourceParser) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.Keyboard.Key);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Keyboard() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getKeys
				/// </java-name>
				public global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key> Keys
				{
				[Dot42.DexImport("getKeys", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/inputmethodservice/Keyboard$Key;>;")]
						get{ return GetKeys(); }
				}

				/// <java-name>
				/// getModifierKeys
				/// </java-name>
				public global::Java.Util.IList<global::Android.Inputmethodservice.Keyboard.Key> ModifierKeys
				{
				[Dot42.DexImport("getModifierKeys", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/inputmethodservice/Keyboard$Key;>;")]
						get{ return GetModifierKeys(); }
				}

				/// <java-name>
				/// getHorizontalGap
				/// </java-name>
				protected internal int HorizontalGap
				{
				[Dot42.DexImport("getHorizontalGap", "()I", AccessFlags = 4)]
						get{ return GetHorizontalGap(); }
				[Dot42.DexImport("setHorizontalGap", "(I)V", AccessFlags = 4)]
						set{ SetHorizontalGap(value); }
				}

				/// <java-name>
				/// getVerticalGap
				/// </java-name>
				protected internal int VerticalGap
				{
				[Dot42.DexImport("getVerticalGap", "()I", AccessFlags = 4)]
						get{ return GetVerticalGap(); }
				[Dot42.DexImport("setVerticalGap", "(I)V", AccessFlags = 4)]
						set{ SetVerticalGap(value); }
				}

				/// <java-name>
				/// getKeyHeight
				/// </java-name>
				protected internal int KeyHeight
				{
				[Dot42.DexImport("getKeyHeight", "()I", AccessFlags = 4)]
						get{ return GetKeyHeight(); }
				[Dot42.DexImport("setKeyHeight", "(I)V", AccessFlags = 4)]
						set{ SetKeyHeight(value); }
				}

				/// <java-name>
				/// getKeyWidth
				/// </java-name>
				protected internal int KeyWidth
				{
				[Dot42.DexImport("getKeyWidth", "()I", AccessFlags = 4)]
						get{ return GetKeyWidth(); }
				[Dot42.DexImport("setKeyWidth", "(I)V", AccessFlags = 4)]
						set{ SetKeyWidth(value); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
				[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return GetHeight(); }
				}

				/// <java-name>
				/// getMinWidth
				/// </java-name>
				public int MinWidth
				{
				[Dot42.DexImport("getMinWidth", "()I", AccessFlags = 1)]
						get{ return GetMinWidth(); }
				}

				/// <java-name>
				/// getShiftKeyIndex
				/// </java-name>
				public int ShiftKeyIndex
				{
				[Dot42.DexImport("getShiftKeyIndex", "()I", AccessFlags = 1)]
						get{ return GetShiftKeyIndex(); }
				}

				/// <java-name>
				/// android/inputmethodservice/Keyboard$Key
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/Keyboard$Key", AccessFlags = 9)]
				public partial class Key
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// codes
						/// </java-name>
						[Dot42.DexImport("codes", "[I", AccessFlags = 1)]
						public int[] Codes;
						/// <java-name>
						/// label
						/// </java-name>
						[Dot42.DexImport("label", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Label;
						/// <java-name>
						/// icon
						/// </java-name>
						[Dot42.DexImport("icon", "Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public global::Android.Graphics.Drawable.Drawable Icon;
						/// <java-name>
						/// iconPreview
						/// </java-name>
						[Dot42.DexImport("iconPreview", "Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						public global::Android.Graphics.Drawable.Drawable IconPreview;
						/// <java-name>
						/// width
						/// </java-name>
						[Dot42.DexImport("width", "I", AccessFlags = 1)]
						public int Width;
						/// <java-name>
						/// height
						/// </java-name>
						[Dot42.DexImport("height", "I", AccessFlags = 1)]
						public int Height;
						/// <java-name>
						/// gap
						/// </java-name>
						[Dot42.DexImport("gap", "I", AccessFlags = 1)]
						public int Gap;
						/// <java-name>
						/// sticky
						/// </java-name>
						[Dot42.DexImport("sticky", "Z", AccessFlags = 1)]
						public bool Sticky;
						/// <java-name>
						/// x
						/// </java-name>
						[Dot42.DexImport("x", "I", AccessFlags = 1)]
						public int X;
						/// <java-name>
						/// y
						/// </java-name>
						[Dot42.DexImport("y", "I", AccessFlags = 1)]
						public int Y;
						/// <java-name>
						/// pressed
						/// </java-name>
						[Dot42.DexImport("pressed", "Z", AccessFlags = 1)]
						public bool Pressed;
						/// <java-name>
						/// on
						/// </java-name>
						[Dot42.DexImport("on", "Z", AccessFlags = 1)]
						public bool On;
						/// <java-name>
						/// text
						/// </java-name>
						[Dot42.DexImport("text", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence Text;
						/// <java-name>
						/// popupCharacters
						/// </java-name>
						[Dot42.DexImport("popupCharacters", "Ljava/lang/CharSequence;", AccessFlags = 1)]
						public global::Java.Lang.ICharSequence PopupCharacters;
						/// <java-name>
						/// edgeFlags
						/// </java-name>
						[Dot42.DexImport("edgeFlags", "I", AccessFlags = 1)]
						public int EdgeFlags;
						/// <java-name>
						/// modifier
						/// </java-name>
						[Dot42.DexImport("modifier", "Z", AccessFlags = 1)]
						public bool Modifier;
						/// <java-name>
						/// popupResId
						/// </java-name>
						[Dot42.DexImport("popupResId", "I", AccessFlags = 1)]
						public int PopupResId;
						/// <java-name>
						/// repeatable
						/// </java-name>
						[Dot42.DexImport("repeatable", "Z", AccessFlags = 1)]
						public bool Repeatable;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/Keyboard$Row;)V", AccessFlags = 1)]
						public Key(global::Android.Inputmethodservice.Keyboard.Row row) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard$Row;IILandro" +
    "id/content/res/XmlResourceParser;)V", AccessFlags = 1)]
						public Key(global::Android.Content.Res.Resources resources, global::Android.Inputmethodservice.Keyboard.Row row, int int32, int int321, global::Android.Content.Res.IXmlResourceParser xmlResourceParser) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onPressed
						/// </java-name>
						[Dot42.DexImport("onPressed", "()V", AccessFlags = 1)]
						public virtual void OnPressed() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onReleased
						/// </java-name>
						[Dot42.DexImport("onReleased", "(Z)V", AccessFlags = 1)]
						public virtual void OnReleased(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isInside
						/// </java-name>
						[Dot42.DexImport("isInside", "(II)Z", AccessFlags = 1)]
						public virtual bool IsInside(int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// squaredDistanceFrom
						/// </java-name>
						[Dot42.DexImport("squaredDistanceFrom", "(II)I", AccessFlags = 1)]
						public virtual int SquaredDistanceFrom(int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getCurrentDrawableState
						/// </java-name>
						[Dot42.DexImport("getCurrentDrawableState", "()[I", AccessFlags = 1)]
						public virtual int[] GetCurrentDrawableState() /* MethodBuilder.Create */ 
						{
								return default(int[]);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Key() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getCurrentDrawableState
						/// </java-name>
						public int[] CurrentDrawableState
						{
						[Dot42.DexImport("getCurrentDrawableState", "()[I", AccessFlags = 1)]
								get{ return GetCurrentDrawableState(); }
						}

				}

				/// <java-name>
				/// android/inputmethodservice/Keyboard$Row
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/Keyboard$Row", AccessFlags = 9)]
				public partial class Row
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// defaultWidth
						/// </java-name>
						[Dot42.DexImport("defaultWidth", "I", AccessFlags = 1)]
						public int DefaultWidth;
						/// <java-name>
						/// defaultHeight
						/// </java-name>
						[Dot42.DexImport("defaultHeight", "I", AccessFlags = 1)]
						public int DefaultHeight;
						/// <java-name>
						/// defaultHorizontalGap
						/// </java-name>
						[Dot42.DexImport("defaultHorizontalGap", "I", AccessFlags = 1)]
						public int DefaultHorizontalGap;
						/// <java-name>
						/// verticalGap
						/// </java-name>
						[Dot42.DexImport("verticalGap", "I", AccessFlags = 1)]
						public int VerticalGap;
						/// <java-name>
						/// rowEdgeFlags
						/// </java-name>
						[Dot42.DexImport("rowEdgeFlags", "I", AccessFlags = 1)]
						public int RowEdgeFlags;
						/// <java-name>
						/// mode
						/// </java-name>
						[Dot42.DexImport("mode", "I", AccessFlags = 1)]
						public int Mode;
						[Dot42.DexImport("<init>", "(Landroid/inputmethodservice/Keyboard;)V", AccessFlags = 1)]
						public Row(global::Android.Inputmethodservice.Keyboard keyboard) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/res/Resources;Landroid/inputmethodservice/Keyboard;Landroid/con" +
    "tent/res/XmlResourceParser;)V", AccessFlags = 1)]
						public Row(global::Android.Content.Res.Resources resources, global::Android.Inputmethodservice.Keyboard keyboard, global::Android.Content.Res.IXmlResourceParser xmlResourceParser) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal Row() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/inputmethodservice/KeyboardView
		/// </java-name>
		[Dot42.DexImport("android/inputmethodservice/KeyboardView", AccessFlags = 33)]
		public partial class KeyboardView : global::Android.View.View, global::Android.View.View.IOnClickListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public KeyboardView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public KeyboardView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnKeyboardActionListener
				/// </java-name>
				[Dot42.DexImport("setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V", AccessFlags = 1)]
				public virtual void SetOnKeyboardActionListener(global::Android.Inputmethodservice.KeyboardView.IOnKeyboardActionListener onKeyboardActionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOnKeyboardActionListener
				/// </java-name>
				[Dot42.DexImport("getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;", AccessFlags = 4)]
				protected internal virtual global::Android.Inputmethodservice.KeyboardView.IOnKeyboardActionListener GetOnKeyboardActionListener() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.KeyboardView.IOnKeyboardActionListener);
				}

				/// <java-name>
				/// setKeyboard
				/// </java-name>
				[Dot42.DexImport("setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V", AccessFlags = 1)]
				public virtual void SetKeyboard(global::Android.Inputmethodservice.Keyboard keyboard) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getKeyboard
				/// </java-name>
				[Dot42.DexImport("getKeyboard", "()Landroid/inputmethodservice/Keyboard;", AccessFlags = 1)]
				public virtual global::Android.Inputmethodservice.Keyboard GetKeyboard() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Inputmethodservice.Keyboard);
				}

				/// <java-name>
				/// setShifted
				/// </java-name>
				[Dot42.DexImport("setShifted", "(Z)Z", AccessFlags = 1)]
				public virtual bool SetShifted(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isShifted
				/// </java-name>
				[Dot42.DexImport("isShifted", "()Z", AccessFlags = 1)]
				public virtual bool IsShifted() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPreviewEnabled
				/// </java-name>
				[Dot42.DexImport("setPreviewEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetPreviewEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isPreviewEnabled
				/// </java-name>
				[Dot42.DexImport("isPreviewEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsPreviewEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setVerticalCorrection
				/// </java-name>
				[Dot42.DexImport("setVerticalCorrection", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalCorrection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPopupParent
				/// </java-name>
				[Dot42.DexImport("setPopupParent", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetPopupParent(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPopupOffset
				/// </java-name>
				[Dot42.DexImport("setPopupOffset", "(II)V", AccessFlags = 1)]
				public virtual void SetPopupOffset(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProximityCorrectionEnabled
				/// </java-name>
				[Dot42.DexImport("setProximityCorrectionEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetProximityCorrectionEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isProximityCorrectionEnabled
				/// </java-name>
				[Dot42.DexImport("isProximityCorrectionEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsProximityCorrectionEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 1)]
				public new virtual void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 1)]
				public new virtual void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public new virtual void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateAllKeys
				/// </java-name>
				[Dot42.DexImport("invalidateAllKeys", "()V", AccessFlags = 1)]
				public virtual void InvalidateAllKeys() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateKey
				/// </java-name>
				[Dot42.DexImport("invalidateKey", "(I)V", AccessFlags = 1)]
				public virtual void InvalidateKey(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLongPress
				/// </java-name>
				[Dot42.DexImport("onLongPress", "(Landroid/inputmethodservice/Keyboard$Key;)Z", AccessFlags = 4)]
				protected internal virtual bool OnLongPress(global::Android.Inputmethodservice.Keyboard.Key key) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onHoverEvent
				/// </java-name>
				[Dot42.DexImport("onHoverEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnHoverEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.View.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// swipeRight
				/// </java-name>
				[Dot42.DexImport("swipeRight", "()V", AccessFlags = 4)]
				protected internal virtual void SwipeRight() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// swipeLeft
				/// </java-name>
				[Dot42.DexImport("swipeLeft", "()V", AccessFlags = 4)]
				protected internal virtual void SwipeLeft() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// swipeUp
				/// </java-name>
				[Dot42.DexImport("swipeUp", "()V", AccessFlags = 4)]
				protected internal virtual void SwipeUp() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// swipeDown
				/// </java-name>
				[Dot42.DexImport("swipeDown", "()V", AccessFlags = 4)]
				protected internal virtual void SwipeDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// closing
				/// </java-name>
				[Dot42.DexImport("closing", "()V", AccessFlags = 1)]
				public virtual void Closing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1)]
				public new virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleBack
				/// </java-name>
				[Dot42.DexImport("handleBack", "()Z", AccessFlags = 1)]
				public virtual bool HandleBack() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyboardView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getOnKeyboardActionListener
				/// </java-name>
				protected internal global::Android.Inputmethodservice.KeyboardView.IOnKeyboardActionListener OnKeyboardActionListener
				{
				[Dot42.DexImport("getOnKeyboardActionListener", "()Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;", AccessFlags = 4)]
						get{ return GetOnKeyboardActionListener(); }
				[Dot42.DexImport("setOnKeyboardActionListener", "(Landroid/inputmethodservice/KeyboardView$OnKeyboardActionListener;)V", AccessFlags = 1)]
						set{ SetOnKeyboardActionListener(value); }
				}

				/// <java-name>
				/// getKeyboard
				/// </java-name>
				public global::Android.Inputmethodservice.Keyboard Keyboard
				{
				[Dot42.DexImport("getKeyboard", "()Landroid/inputmethodservice/Keyboard;", AccessFlags = 1)]
						get{ return GetKeyboard(); }
				[Dot42.DexImport("setKeyboard", "(Landroid/inputmethodservice/Keyboard;)V", AccessFlags = 1)]
						set{ SetKeyboard(value); }
				}

				/// <java-name>
				/// android/inputmethodservice/KeyboardView$OnKeyboardActionListener
				/// </java-name>
				[Dot42.DexImport("android/inputmethodservice/KeyboardView$OnKeyboardActionListener", AccessFlags = 1545)]
				public partial interface IOnKeyboardActionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPress
						/// </java-name>
						[Dot42.DexImport("onPress", "(I)V", AccessFlags = 1025)]
						void OnPress(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onRelease
						/// </java-name>
						[Dot42.DexImport("onRelease", "(I)V", AccessFlags = 1025)]
						void OnRelease(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onKey
						/// </java-name>
						[Dot42.DexImport("onKey", "(I[I)V", AccessFlags = 1025)]
						void OnKey(int int32, int[] int321) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onText
						/// </java-name>
						[Dot42.DexImport("onText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
						void OnText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// swipeLeft
						/// </java-name>
						[Dot42.DexImport("swipeLeft", "()V", AccessFlags = 1025)]
						void SwipeLeft() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// swipeRight
						/// </java-name>
						[Dot42.DexImport("swipeRight", "()V", AccessFlags = 1025)]
						void SwipeRight() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// swipeDown
						/// </java-name>
						[Dot42.DexImport("swipeDown", "()V", AccessFlags = 1025)]
						void SwipeDown() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// swipeUp
						/// </java-name>
						[Dot42.DexImport("swipeUp", "()V", AccessFlags = 1025)]
						void SwipeUp() /* MethodBuilder.Create */ ;

				}

		}

}

