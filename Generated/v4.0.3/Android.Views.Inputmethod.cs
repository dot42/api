#pragma warning disable 1717
namespace Android.Views.Inputmethod
{
		/// <java-name>
		/// android/view/inputmethod/BaseInputConnection
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/BaseInputConnection", AccessFlags = 33)]
		public partial class BaseInputConnection : global::Android.Views.Inputmethod.IInputConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/view/View;Z)V", AccessFlags = 1)]
				public BaseInputConnection(global::Android.Views.View view, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeComposingSpans
				/// </java-name>
				[Dot42.DexImport("removeComposingSpans", "(Landroid/text/Spannable;)V", AccessFlags = 25)]
				public static void RemoveComposingSpans(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setComposingSpans
				/// </java-name>
				[Dot42.DexImport("setComposingSpans", "(Landroid/text/Spannable;)V", AccessFlags = 9)]
				public static void SetComposingSpans(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getComposingSpanStart
				/// </java-name>
				[Dot42.DexImport("getComposingSpanStart", "(Landroid/text/Spannable;)I", AccessFlags = 9)]
				public static int GetComposingSpanStart(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getComposingSpanEnd
				/// </java-name>
				[Dot42.DexImport("getComposingSpanEnd", "(Landroid/text/Spannable;)I", AccessFlags = 9)]
				public static int GetComposingSpanEnd(global::Android.Text.ISpannable spannable) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEditable
				/// </java-name>
				[Dot42.DexImport("getEditable", "()Landroid/text/Editable;", AccessFlags = 1)]
				public virtual global::Android.Text.IEditable GetEditable() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.IEditable);
				}

				/// <java-name>
				/// beginBatchEdit
				/// </java-name>
				[Dot42.DexImport("beginBatchEdit", "()Z", AccessFlags = 1)]
				public virtual bool BeginBatchEdit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// endBatchEdit
				/// </java-name>
				[Dot42.DexImport("endBatchEdit", "()Z", AccessFlags = 1)]
				public virtual bool EndBatchEdit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearMetaKeyStates
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyStates", "(I)Z", AccessFlags = 1)]
				public virtual bool ClearMetaKeyStates(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// commitCompletion
				/// </java-name>
				[Dot42.DexImport("commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", AccessFlags = 1)]
				public virtual bool CommitCompletion(global::Android.Views.Inputmethod.CompletionInfo completionInfo) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// commitCorrection
				/// </java-name>
				[Dot42.DexImport("commitCorrection", "(Landroid/view/inputmethod/CorrectionInfo;)Z", AccessFlags = 1)]
				public virtual bool CommitCorrection(global::Android.Views.Inputmethod.CorrectionInfo correctionInfo) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// commitText
				/// </java-name>
				[Dot42.DexImport("commitText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1)]
				public virtual bool CommitText(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// deleteSurroundingText
				/// </java-name>
				[Dot42.DexImport("deleteSurroundingText", "(II)Z", AccessFlags = 1)]
				public virtual bool DeleteSurroundingText(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finishComposingText
				/// </java-name>
				[Dot42.DexImport("finishComposingText", "()Z", AccessFlags = 1)]
				public virtual bool FinishComposingText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getCursorCapsMode
				/// </java-name>
				[Dot42.DexImport("getCursorCapsMode", "(I)I", AccessFlags = 1)]
				public virtual int GetCursorCapsMode(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getExtractedText
				/// </java-name>
				[Dot42.DexImport("getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/Extra" +
    "ctedText;", AccessFlags = 1)]
				public virtual global::Android.Views.Inputmethod.ExtractedText GetExtractedText(global::Android.Views.Inputmethod.ExtractedTextRequest extractedTextRequest, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.ExtractedText);
				}

				/// <java-name>
				/// getTextBeforeCursor
				/// </java-name>
				[Dot42.DexImport("getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextBeforeCursor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getSelectedText
				/// </java-name>
				[Dot42.DexImport("getSelectedText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetSelectedText(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getTextAfterCursor
				/// </java-name>
				[Dot42.DexImport("getTextAfterCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextAfterCursor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// performEditorAction
				/// </java-name>
				[Dot42.DexImport("performEditorAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformEditorAction(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performContextMenuAction
				/// </java-name>
				[Dot42.DexImport("performContextMenuAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformContextMenuAction(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performPrivateCommand
				/// </java-name>
				[Dot42.DexImport("performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool PerformPrivateCommand(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setComposingText
				/// </java-name>
				[Dot42.DexImport("setComposingText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1)]
				public virtual bool SetComposingText(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setComposingRegion
				/// </java-name>
				[Dot42.DexImport("setComposingRegion", "(II)Z", AccessFlags = 1)]
				public virtual bool SetComposingRegion(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(II)Z", AccessFlags = 1)]
				public virtual bool SetSelection(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendKeyEvent
				/// </java-name>
				[Dot42.DexImport("sendKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool SendKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reportFullscreenMode
				/// </java-name>
				[Dot42.DexImport("reportFullscreenMode", "(Z)Z", AccessFlags = 1)]
				public virtual bool ReportFullscreenMode(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal BaseInputConnection() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEditable
				/// </java-name>
				public global::Android.Text.IEditable Editable
				{
				[Dot42.DexImport("getEditable", "()Landroid/text/Editable;", AccessFlags = 1)]
						get{ return GetEditable(); }
				}

		}

		/// <java-name>
		/// android/view/inputmethod/CompletionInfo
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/CompletionInfo", AccessFlags = 49)]
		public sealed partial class CompletionInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Inputmethod.CompletionInfo> CREATOR;
				[Dot42.DexImport("<init>", "(JILjava/lang/CharSequence;)V", AccessFlags = 1)]
				public CompletionInfo(long int64, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JILjava/lang/CharSequence;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public CompletionInfo(long int64, int int32, global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()J", AccessFlags = 1)]
				public long GetId() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
				public int GetPosition() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

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

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getId
				/// </java-name>
				public long Id
				{
				[Dot42.DexImport("getId", "()J", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				public int Position
				{
				[Dot42.DexImport("getPosition", "()I", AccessFlags = 1)]
						get{ return GetPosition(); }
				}

				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Lang.ICharSequence Text
				{
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetText(); }
				}

				/// <java-name>
				/// getLabel
				/// </java-name>
				public global::Java.Lang.ICharSequence Label
				{
				[Dot42.DexImport("getLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetLabel(); }
				}

		}

		/// <java-name>
		/// android/view/inputmethod/CorrectionInfo
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/CorrectionInfo", AccessFlags = 49)]
		public sealed partial class CorrectionInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Inputmethod.CorrectionInfo> CREATOR;
				[Dot42.DexImport("<init>", "(ILjava/lang/CharSequence;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public CorrectionInfo(int int32, global::Java.Lang.ICharSequence charSequence, global::Java.Lang.ICharSequence charSequence1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
				public int GetOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getOldText
				/// </java-name>
				[Dot42.DexImport("getOldText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetOldText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getNewText
				/// </java-name>
				[Dot42.DexImport("getNewText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetNewText() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CorrectionInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getOffset
				/// </java-name>
				public int Offset
				{
				[Dot42.DexImport("getOffset", "()I", AccessFlags = 1)]
						get{ return GetOffset(); }
				}

				/// <java-name>
				/// getOldText
				/// </java-name>
				public global::Java.Lang.ICharSequence OldText
				{
				[Dot42.DexImport("getOldText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetOldText(); }
				}

				/// <java-name>
				/// getNewText
				/// </java-name>
				public global::Java.Lang.ICharSequence NewText
				{
				[Dot42.DexImport("getNewText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetNewText(); }
				}

		}

		/// <java-name>
		/// android/view/inputmethod/EditorInfo
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/EditorInfo", AccessFlags = 33)]
		public partial class EditorInfo : global::Android.Text.IInputType, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// inputType
				/// </java-name>
				[Dot42.DexImport("inputType", "I", AccessFlags = 1)]
				public int InputType;
				/// <java-name>
				/// IME_MASK_ACTION
				/// </java-name>
				[Dot42.DexImport("IME_MASK_ACTION", "I", AccessFlags = 25)]
				public const int IME_MASK_ACTION = 255;
				/// <java-name>
				/// IME_ACTION_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int IME_ACTION_UNSPECIFIED = 0;
				/// <java-name>
				/// IME_ACTION_NONE
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_NONE", "I", AccessFlags = 25)]
				public const int IME_ACTION_NONE = 1;
				/// <java-name>
				/// IME_ACTION_GO
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_GO", "I", AccessFlags = 25)]
				public const int IME_ACTION_GO = 2;
				/// <java-name>
				/// IME_ACTION_SEARCH
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_SEARCH", "I", AccessFlags = 25)]
				public const int IME_ACTION_SEARCH = 3;
				/// <java-name>
				/// IME_ACTION_SEND
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_SEND", "I", AccessFlags = 25)]
				public const int IME_ACTION_SEND = 4;
				/// <java-name>
				/// IME_ACTION_NEXT
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_NEXT", "I", AccessFlags = 25)]
				public const int IME_ACTION_NEXT = 5;
				/// <java-name>
				/// IME_ACTION_DONE
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_DONE", "I", AccessFlags = 25)]
				public const int IME_ACTION_DONE = 6;
				/// <java-name>
				/// IME_ACTION_PREVIOUS
				/// </java-name>
				[Dot42.DexImport("IME_ACTION_PREVIOUS", "I", AccessFlags = 25)]
				public const int IME_ACTION_PREVIOUS = 7;
				/// <java-name>
				/// IME_FLAG_NO_FULLSCREEN
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NO_FULLSCREEN", "I", AccessFlags = 25)]
				public const int IME_FLAG_NO_FULLSCREEN = 33554432;
				/// <java-name>
				/// IME_FLAG_NAVIGATE_PREVIOUS
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NAVIGATE_PREVIOUS", "I", AccessFlags = 25)]
				public const int IME_FLAG_NAVIGATE_PREVIOUS = 67108864;
				/// <java-name>
				/// IME_FLAG_NAVIGATE_NEXT
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NAVIGATE_NEXT", "I", AccessFlags = 25)]
				public const int IME_FLAG_NAVIGATE_NEXT = 134217728;
				/// <java-name>
				/// IME_FLAG_NO_EXTRACT_UI
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NO_EXTRACT_UI", "I", AccessFlags = 25)]
				public const int IME_FLAG_NO_EXTRACT_UI = 268435456;
				/// <java-name>
				/// IME_FLAG_NO_ACCESSORY_ACTION
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NO_ACCESSORY_ACTION", "I", AccessFlags = 25)]
				public const int IME_FLAG_NO_ACCESSORY_ACTION = 536870912;
				/// <java-name>
				/// IME_FLAG_NO_ENTER_ACTION
				/// </java-name>
				[Dot42.DexImport("IME_FLAG_NO_ENTER_ACTION", "I", AccessFlags = 25)]
				public const int IME_FLAG_NO_ENTER_ACTION = 1073741824;
				/// <java-name>
				/// IME_NULL
				/// </java-name>
				[Dot42.DexImport("IME_NULL", "I", AccessFlags = 25)]
				public const int IME_NULL = 0;
				/// <java-name>
				/// imeOptions
				/// </java-name>
				[Dot42.DexImport("imeOptions", "I", AccessFlags = 1)]
				public int ImeOptions;
				/// <java-name>
				/// privateImeOptions
				/// </java-name>
				[Dot42.DexImport("privateImeOptions", "Ljava/lang/String;", AccessFlags = 1)]
				public string PrivateImeOptions;
				/// <java-name>
				/// actionLabel
				/// </java-name>
				[Dot42.DexImport("actionLabel", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence ActionLabel;
				/// <java-name>
				/// actionId
				/// </java-name>
				[Dot42.DexImport("actionId", "I", AccessFlags = 1)]
				public int ActionId;
				/// <java-name>
				/// initialSelStart
				/// </java-name>
				[Dot42.DexImport("initialSelStart", "I", AccessFlags = 1)]
				public int InitialSelStart;
				/// <java-name>
				/// initialSelEnd
				/// </java-name>
				[Dot42.DexImport("initialSelEnd", "I", AccessFlags = 1)]
				public int InitialSelEnd;
				/// <java-name>
				/// initialCapsMode
				/// </java-name>
				[Dot42.DexImport("initialCapsMode", "I", AccessFlags = 1)]
				public int InitialCapsMode;
				/// <java-name>
				/// hintText
				/// </java-name>
				[Dot42.DexImport("hintText", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence HintText;
				/// <java-name>
				/// label
				/// </java-name>
				[Dot42.DexImport("label", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence Label;
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <java-name>
				/// fieldId
				/// </java-name>
				[Dot42.DexImport("fieldId", "I", AccessFlags = 1)]
				public int FieldId;
				/// <java-name>
				/// fieldName
				/// </java-name>
				[Dot42.DexImport("fieldName", "Ljava/lang/String;", AccessFlags = 1)]
				public string FieldName;
				/// <java-name>
				/// extras
				/// </java-name>
				[Dot42.DexImport("extras", "Landroid/os/Bundle;", AccessFlags = 1)]
				public global::Android.OS.Bundle Extras;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Inputmethod.EditorInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public EditorInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// makeCompatible
				/// </java-name>
				[Dot42.DexImport("makeCompatible", "(I)V", AccessFlags = 17)]
				public void MakeCompatible(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Landroid/util/Printer;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/view/inputmethod/ExtractedText
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/ExtractedText", AccessFlags = 33)]
		public partial class ExtractedText : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// text
				/// </java-name>
				[Dot42.DexImport("text", "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence Text;
				/// <java-name>
				/// startOffset
				/// </java-name>
				[Dot42.DexImport("startOffset", "I", AccessFlags = 1)]
				public int StartOffset;
				/// <java-name>
				/// partialStartOffset
				/// </java-name>
				[Dot42.DexImport("partialStartOffset", "I", AccessFlags = 1)]
				public int PartialStartOffset;
				/// <java-name>
				/// partialEndOffset
				/// </java-name>
				[Dot42.DexImport("partialEndOffset", "I", AccessFlags = 1)]
				public int PartialEndOffset;
				/// <java-name>
				/// selectionStart
				/// </java-name>
				[Dot42.DexImport("selectionStart", "I", AccessFlags = 1)]
				public int SelectionStart;
				/// <java-name>
				/// selectionEnd
				/// </java-name>
				[Dot42.DexImport("selectionEnd", "I", AccessFlags = 1)]
				public int SelectionEnd;
				/// <java-name>
				/// FLAG_SINGLE_LINE
				/// </java-name>
				[Dot42.DexImport("FLAG_SINGLE_LINE", "I", AccessFlags = 25)]
				public const int FLAG_SINGLE_LINE = 1;
				/// <java-name>
				/// FLAG_SELECTING
				/// </java-name>
				[Dot42.DexImport("FLAG_SELECTING", "I", AccessFlags = 25)]
				public const int FLAG_SELECTING = 2;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Inputmethod.ExtractedText> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExtractedText() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/view/inputmethod/ExtractedTextRequest
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/ExtractedTextRequest", AccessFlags = 33)]
		public partial class ExtractedTextRequest : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// token
				/// </java-name>
				[Dot42.DexImport("token", "I", AccessFlags = 1)]
				public int Token;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// hintMaxLines
				/// </java-name>
				[Dot42.DexImport("hintMaxLines", "I", AccessFlags = 1)]
				public int HintMaxLines;
				/// <java-name>
				/// hintMaxChars
				/// </java-name>
				[Dot42.DexImport("hintMaxChars", "I", AccessFlags = 1)]
				public int HintMaxChars;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Inputmethod.ExtractedTextRequest> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ExtractedTextRequest() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/view/inputmethod/InputConnection
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputConnection", AccessFlags = 1537)]
		public partial interface IInputConnection
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getTextBeforeCursor
				/// </java-name>
				[Dot42.DexImport("getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence GetTextBeforeCursor(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTextAfterCursor
				/// </java-name>
				[Dot42.DexImport("getTextAfterCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence GetTextAfterCursor(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSelectedText
				/// </java-name>
				[Dot42.DexImport("getSelectedText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1025)]
				global::Java.Lang.ICharSequence GetSelectedText(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCursorCapsMode
				/// </java-name>
				[Dot42.DexImport("getCursorCapsMode", "(I)I", AccessFlags = 1025)]
				int GetCursorCapsMode(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getExtractedText
				/// </java-name>
				[Dot42.DexImport("getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/Extra" +
    "ctedText;", AccessFlags = 1025)]
				global::Android.Views.Inputmethod.ExtractedText GetExtractedText(global::Android.Views.Inputmethod.ExtractedTextRequest extractedTextRequest, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// deleteSurroundingText
				/// </java-name>
				[Dot42.DexImport("deleteSurroundingText", "(II)Z", AccessFlags = 1025)]
				bool DeleteSurroundingText(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setComposingText
				/// </java-name>
				[Dot42.DexImport("setComposingText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1025)]
				bool SetComposingText(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setComposingRegion
				/// </java-name>
				[Dot42.DexImport("setComposingRegion", "(II)Z", AccessFlags = 1025)]
				bool SetComposingRegion(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// finishComposingText
				/// </java-name>
				[Dot42.DexImport("finishComposingText", "()Z", AccessFlags = 1025)]
				bool FinishComposingText() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// commitText
				/// </java-name>
				[Dot42.DexImport("commitText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1025)]
				bool CommitText(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// commitCompletion
				/// </java-name>
				[Dot42.DexImport("commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", AccessFlags = 1025)]
				bool CommitCompletion(global::Android.Views.Inputmethod.CompletionInfo completionInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// commitCorrection
				/// </java-name>
				[Dot42.DexImport("commitCorrection", "(Landroid/view/inputmethod/CorrectionInfo;)Z", AccessFlags = 1025)]
				bool CommitCorrection(global::Android.Views.Inputmethod.CorrectionInfo correctionInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(II)Z", AccessFlags = 1025)]
				bool SetSelection(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performEditorAction
				/// </java-name>
				[Dot42.DexImport("performEditorAction", "(I)Z", AccessFlags = 1025)]
				bool PerformEditorAction(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performContextMenuAction
				/// </java-name>
				[Dot42.DexImport("performContextMenuAction", "(I)Z", AccessFlags = 1025)]
				bool PerformContextMenuAction(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// beginBatchEdit
				/// </java-name>
				[Dot42.DexImport("beginBatchEdit", "()Z", AccessFlags = 1025)]
				bool BeginBatchEdit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// endBatchEdit
				/// </java-name>
				[Dot42.DexImport("endBatchEdit", "()Z", AccessFlags = 1025)]
				bool EndBatchEdit() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendKeyEvent
				/// </java-name>
				[Dot42.DexImport("sendKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool SendKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearMetaKeyStates
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyStates", "(I)Z", AccessFlags = 1025)]
				bool ClearMetaKeyStates(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// reportFullscreenMode
				/// </java-name>
				[Dot42.DexImport("reportFullscreenMode", "(Z)Z", AccessFlags = 1025)]
				bool ReportFullscreenMode(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performPrivateCommand
				/// </java-name>
				[Dot42.DexImport("performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1025)]
				bool PerformPrivateCommand(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/inputmethod/InputConnection
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputConnection", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IInputConnectionConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// GET_TEXT_WITH_STYLES
				/// </java-name>
				[Dot42.DexImport("GET_TEXT_WITH_STYLES", "I", AccessFlags = 25)]
				public const int GET_TEXT_WITH_STYLES = 1;
				/// <java-name>
				/// GET_EXTRACTED_TEXT_MONITOR
				/// </java-name>
				[Dot42.DexImport("GET_EXTRACTED_TEXT_MONITOR", "I", AccessFlags = 25)]
				public const int GET_EXTRACTED_TEXT_MONITOR = 1;
		}

		/// <java-name>
		/// android/view/inputmethod/InputMethod
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethod", AccessFlags = 1537)]
		public partial interface IInputMethod
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// attachToken
				/// </java-name>
				[Dot42.DexImport("attachToken", "(Landroid/os/IBinder;)V", AccessFlags = 1025)]
				void AttachToken(global::Android.OS.IBinder binder) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// bindInput
				/// </java-name>
				[Dot42.DexImport("bindInput", "(Landroid/view/inputmethod/InputBinding;)V", AccessFlags = 1025)]
				void BindInput(global::Android.Views.Inputmethod.InputBinding inputBinding) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unbindInput
				/// </java-name>
				[Dot42.DexImport("unbindInput", "()V", AccessFlags = 1025)]
				void UnbindInput() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startInput
				/// </java-name>
				[Dot42.DexImport("startInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1025)]
				void StartInput(global::Android.Views.Inputmethod.IInputConnection inputConnection, global::Android.Views.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// restartInput
				/// </java-name>
				[Dot42.DexImport("restartInput", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/EditorInfo;)" +
    "V", AccessFlags = 1025)]
				void RestartInput(global::Android.Views.Inputmethod.IInputConnection inputConnection, global::Android.Views.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createSession
				/// </java-name>
				[Dot42.DexImport("createSession", "(Landroid/view/inputmethod/InputMethod$SessionCallback;)V", AccessFlags = 1025)]
				void CreateSession(global::Android.Views.Inputmethod.IInputMethod_ISessionCallback inputMethod_ISessionCallback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSessionEnabled
				/// </java-name>
				[Dot42.DexImport("setSessionEnabled", "(Landroid/view/inputmethod/InputMethodSession;Z)V", AccessFlags = 1025)]
				void SetSessionEnabled(global::Android.Views.Inputmethod.IInputMethodSession inputMethodSession, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// revokeSession
				/// </java-name>
				[Dot42.DexImport("revokeSession", "(Landroid/view/inputmethod/InputMethodSession;)V", AccessFlags = 1025)]
				void RevokeSession(global::Android.Views.Inputmethod.IInputMethodSession inputMethodSession) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// showSoftInput
				/// </java-name>
				[Dot42.DexImport("showSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1025)]
				void ShowSoftInput(int int32, global::Android.OS.ResultReceiver resultReceiver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hideSoftInput
				/// </java-name>
				[Dot42.DexImport("hideSoftInput", "(ILandroid/os/ResultReceiver;)V", AccessFlags = 1025)]
				void HideSoftInput(int int32, global::Android.OS.ResultReceiver resultReceiver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// changeInputMethodSubtype
				/// </java-name>
				[Dot42.DexImport("changeInputMethodSubtype", "(Landroid/view/inputmethod/InputMethodSubtype;)V", AccessFlags = 1025)]
				void ChangeInputMethodSubtype(global::Android.Views.Inputmethod.InputMethodSubtype inputMethodSubtype) /* MethodBuilder.Create */ ;

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
				void SessionCreated(global::Android.Views.Inputmethod.IInputMethodSession inputMethodSession) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/inputmethod/InputMethod
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethod", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IInputMethodConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.view.InputMethod";
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.view.im";
				/// <java-name>
				/// SHOW_EXPLICIT
				/// </java-name>
				[Dot42.DexImport("SHOW_EXPLICIT", "I", AccessFlags = 25)]
				public const int SHOW_EXPLICIT = 1;
				/// <java-name>
				/// SHOW_FORCED
				/// </java-name>
				[Dot42.DexImport("SHOW_FORCED", "I", AccessFlags = 25)]
				public const int SHOW_FORCED = 2;
		}

		/// <java-name>
		/// android/view/inputmethod/InputMethodSession
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethodSession", AccessFlags = 1537)]
		public partial interface IInputMethodSession
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// finishInput
				/// </java-name>
				[Dot42.DexImport("finishInput", "()V", AccessFlags = 1025)]
				void FinishInput() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateSelection
				/// </java-name>
				[Dot42.DexImport("updateSelection", "(IIIIII)V", AccessFlags = 1025)]
				void UpdateSelection(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// viewClicked
				/// </java-name>
				[Dot42.DexImport("viewClicked", "(Z)V", AccessFlags = 1025)]
				void ViewClicked(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateCursor
				/// </java-name>
				[Dot42.DexImport("updateCursor", "(Landroid/graphics/Rect;)V", AccessFlags = 1025)]
				void UpdateCursor(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// displayCompletions
				/// </java-name>
				[Dot42.DexImport("displayCompletions", "([Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1025)]
				void DisplayCompletions(global::Android.Views.Inputmethod.CompletionInfo[] completionInfo) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateExtractedText
				/// </java-name>
				[Dot42.DexImport("updateExtractedText", "(ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1025)]
				void UpdateExtractedText(int int32, global::Android.Views.Inputmethod.ExtractedText extractedText) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(ILandroid/view/KeyEvent;Landroid/view/inputmethod/InputMethodSession$EventCallba" +
    "ck;)V", AccessFlags = 1025)]
				void DispatchKeyEvent(int int32, global::Android.Views.KeyEvent keyEvent, global::Android.Views.Inputmethod.IInputMethodSession_IEventCallback inputMethodSession_IEventCallback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(ILandroid/view/MotionEvent;Landroid/view/inputmethod/InputMethodSession$EventCal" +
    "lback;)V", AccessFlags = 1025)]
				void DispatchTrackballEvent(int int32, global::Android.Views.MotionEvent motionEvent, global::Android.Views.Inputmethod.IInputMethodSession_IEventCallback inputMethodSession_IEventCallback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// appPrivateCommand
				/// </java-name>
				[Dot42.DexImport("appPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1025)]
				void AppPrivateCommand(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toggleSoftInput
				/// </java-name>
				[Dot42.DexImport("toggleSoftInput", "(II)V", AccessFlags = 1025)]
				void ToggleSoftInput(int int32, int int321) /* MethodBuilder.Create */ ;

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
				void FinishedEvent(int int32, bool boolean) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/inputmethod/InputBinding
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputBinding", AccessFlags = 49)]
		public sealed partial class InputBinding : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Inputmethod.InputBinding> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/os/IBinder;II)V", AccessFlags = 1)]
				public InputBinding(global::Android.Views.Inputmethod.IInputConnection inputConnection, global::Android.OS.IBinder binder, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/inputmethod/InputConnection;Landroid/view/inputmethod/InputBinding" +
    ";)V", AccessFlags = 1)]
				public InputBinding(global::Android.Views.Inputmethod.IInputConnection inputConnection, global::Android.Views.Inputmethod.InputBinding inputBinding) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getConnection
				/// </java-name>
				[Dot42.DexImport("getConnection", "()Landroid/view/inputmethod/InputConnection;", AccessFlags = 1)]
				public global::Android.Views.Inputmethod.IInputConnection GetConnection() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.IInputConnection);
				}

				/// <java-name>
				/// getConnectionToken
				/// </java-name>
				[Dot42.DexImport("getConnectionToken", "()Landroid/os/IBinder;", AccessFlags = 1)]
				public global::Android.OS.IBinder GetConnectionToken() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <java-name>
				/// getUid
				/// </java-name>
				[Dot42.DexImport("getUid", "()I", AccessFlags = 1)]
				public int GetUid() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

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

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getConnection
				/// </java-name>
				public global::Android.Views.Inputmethod.IInputConnection Connection
				{
				[Dot42.DexImport("getConnection", "()Landroid/view/inputmethod/InputConnection;", AccessFlags = 1)]
						get{ return GetConnection(); }
				}

				/// <java-name>
				/// getConnectionToken
				/// </java-name>
				public global::Android.OS.IBinder ConnectionToken
				{
				[Dot42.DexImport("getConnectionToken", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return GetConnectionToken(); }
				}

				/// <java-name>
				/// getUid
				/// </java-name>
				public int Uid
				{
				[Dot42.DexImport("getUid", "()I", AccessFlags = 1)]
						get{ return GetUid(); }
				}

				/// <java-name>
				/// getPid
				/// </java-name>
				public int Pid
				{
				[Dot42.DexImport("getPid", "()I", AccessFlags = 1)]
						get{ return GetPid(); }
				}

		}

		/// <java-name>
		/// android/view/inputmethod/InputConnectionWrapper
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputConnectionWrapper", AccessFlags = 33)]
		public partial class InputConnectionWrapper : global::Android.Views.Inputmethod.IInputConnection
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/view/inputmethod/InputConnection;Z)V", AccessFlags = 1)]
				public InputConnectionWrapper(global::Android.Views.Inputmethod.IInputConnection inputConnection, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTarget
				/// </java-name>
				[Dot42.DexImport("setTarget", "(Landroid/view/inputmethod/InputConnection;)V", AccessFlags = 1)]
				public virtual void SetTarget(global::Android.Views.Inputmethod.IInputConnection inputConnection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextBeforeCursor
				/// </java-name>
				[Dot42.DexImport("getTextBeforeCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextBeforeCursor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getTextAfterCursor
				/// </java-name>
				[Dot42.DexImport("getTextAfterCursor", "(II)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetTextAfterCursor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getSelectedText
				/// </java-name>
				[Dot42.DexImport("getSelectedText", "(I)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetSelectedText(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// getCursorCapsMode
				/// </java-name>
				[Dot42.DexImport("getCursorCapsMode", "(I)I", AccessFlags = 1)]
				public virtual int GetCursorCapsMode(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getExtractedText
				/// </java-name>
				[Dot42.DexImport("getExtractedText", "(Landroid/view/inputmethod/ExtractedTextRequest;I)Landroid/view/inputmethod/Extra" +
    "ctedText;", AccessFlags = 1)]
				public virtual global::Android.Views.Inputmethod.ExtractedText GetExtractedText(global::Android.Views.Inputmethod.ExtractedTextRequest extractedTextRequest, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.ExtractedText);
				}

				/// <java-name>
				/// deleteSurroundingText
				/// </java-name>
				[Dot42.DexImport("deleteSurroundingText", "(II)Z", AccessFlags = 1)]
				public virtual bool DeleteSurroundingText(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setComposingText
				/// </java-name>
				[Dot42.DexImport("setComposingText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1)]
				public virtual bool SetComposingText(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setComposingRegion
				/// </java-name>
				[Dot42.DexImport("setComposingRegion", "(II)Z", AccessFlags = 1)]
				public virtual bool SetComposingRegion(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finishComposingText
				/// </java-name>
				[Dot42.DexImport("finishComposingText", "()Z", AccessFlags = 1)]
				public virtual bool FinishComposingText() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// commitText
				/// </java-name>
				[Dot42.DexImport("commitText", "(Ljava/lang/CharSequence;I)Z", AccessFlags = 1)]
				public virtual bool CommitText(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// commitCompletion
				/// </java-name>
				[Dot42.DexImport("commitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)Z", AccessFlags = 1)]
				public virtual bool CommitCompletion(global::Android.Views.Inputmethod.CompletionInfo completionInfo) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// commitCorrection
				/// </java-name>
				[Dot42.DexImport("commitCorrection", "(Landroid/view/inputmethod/CorrectionInfo;)Z", AccessFlags = 1)]
				public virtual bool CommitCorrection(global::Android.Views.Inputmethod.CorrectionInfo correctionInfo) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(II)Z", AccessFlags = 1)]
				public virtual bool SetSelection(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performEditorAction
				/// </java-name>
				[Dot42.DexImport("performEditorAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformEditorAction(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performContextMenuAction
				/// </java-name>
				[Dot42.DexImport("performContextMenuAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformContextMenuAction(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// beginBatchEdit
				/// </java-name>
				[Dot42.DexImport("beginBatchEdit", "()Z", AccessFlags = 1)]
				public virtual bool BeginBatchEdit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// endBatchEdit
				/// </java-name>
				[Dot42.DexImport("endBatchEdit", "()Z", AccessFlags = 1)]
				public virtual bool EndBatchEdit() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// sendKeyEvent
				/// </java-name>
				[Dot42.DexImport("sendKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool SendKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearMetaKeyStates
				/// </java-name>
				[Dot42.DexImport("clearMetaKeyStates", "(I)Z", AccessFlags = 1)]
				public virtual bool ClearMetaKeyStates(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reportFullscreenMode
				/// </java-name>
				[Dot42.DexImport("reportFullscreenMode", "(Z)Z", AccessFlags = 1)]
				public virtual bool ReportFullscreenMode(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performPrivateCommand
				/// </java-name>
				[Dot42.DexImport("performPrivateCommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool PerformPrivateCommand(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InputConnectionWrapper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/view/inputmethod/InputMethodInfo
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethodInfo", AccessFlags = 49)]
		public sealed partial class InputMethodInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Inputmethod.InputMethodInfo> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V", AccessFlags = 1)]
				public InputMethodInfo(global::Android.Content.Context context, global::Android.Content.Pm.ResolveInfo resolveInfo) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;)V" +
    "", AccessFlags = 1)]
				public InputMethodInfo(string @string, string string1, global::Java.Lang.ICharSequence charSequence, string string2) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getId
				/// </java-name>
				[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetId() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getServiceName
				/// </java-name>
				[Dot42.DexImport("getServiceName", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetServiceName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
				public global::Android.Content.Pm.ServiceInfo GetServiceInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Pm.ServiceInfo);
				}

				/// <java-name>
				/// getComponent
				/// </java-name>
				[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName GetComponent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.ComponentName);
				}

				/// <java-name>
				/// loadLabel
				/// </java-name>
				[Dot42.DexImport("loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence LoadLabel(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// loadIcon
				/// </java-name>
				[Dot42.DexImport("loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
				public global::Android.Graphics.Drawable.Drawable LoadIcon(global::Android.Content.Pm.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Drawable.Drawable);
				}

				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetSettingsActivity() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getSubtypeCount
				/// </java-name>
				[Dot42.DexImport("getSubtypeCount", "()I", AccessFlags = 1)]
				public int GetSubtypeCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSubtypeAt
				/// </java-name>
				[Dot42.DexImport("getSubtypeAt", "(I)Landroid/view/inputmethod/InputMethodSubtype;", AccessFlags = 1)]
				public global::Android.Views.Inputmethod.InputMethodSubtype GetSubtypeAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.InputMethodSubtype);
				}

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
				public void Dump(global::Android.Util.IPrinter printer, string @string) /* MethodBuilder.Create */ 
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
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

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

				/// <java-name>
				/// getId
				/// </java-name>
				public string Id
				{
				[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetId(); }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public string PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				}

				/// <java-name>
				/// getServiceName
				/// </java-name>
				public string ServiceName
				{
				[Dot42.DexImport("getServiceName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetServiceName(); }
				}

				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				public global::Android.Content.Pm.ServiceInfo ServiceInfo
				{
				[Dot42.DexImport("getServiceInfo", "()Landroid/content/pm/ServiceInfo;", AccessFlags = 1)]
						get{ return GetServiceInfo(); }
				}

				/// <java-name>
				/// getComponent
				/// </java-name>
				public global::Android.Content.ComponentName Component
				{
				[Dot42.DexImport("getComponent", "()Landroid/content/ComponentName;", AccessFlags = 1)]
						get{ return GetComponent(); }
				}

				/// <java-name>
				/// getSettingsActivity
				/// </java-name>
				public string SettingsActivity
				{
				[Dot42.DexImport("getSettingsActivity", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetSettingsActivity(); }
				}

				/// <java-name>
				/// getSubtypeCount
				/// </java-name>
				public int SubtypeCount
				{
				[Dot42.DexImport("getSubtypeCount", "()I", AccessFlags = 1)]
						get{ return GetSubtypeCount(); }
				}

				/// <java-name>
				/// getIsDefaultResourceId
				/// </java-name>
				public int IsDefaultResourceId
				{
				[Dot42.DexImport("getIsDefaultResourceId", "()I", AccessFlags = 1)]
						get{ return GetIsDefaultResourceId(); }
				}

		}

		/// <java-name>
		/// android/view/inputmethod/InputMethodManager
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethodManager", AccessFlags = 49)]
		public sealed partial class InputMethodManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SHOW_IMPLICIT
				/// </java-name>
				[Dot42.DexImport("SHOW_IMPLICIT", "I", AccessFlags = 25)]
				public const int SHOW_IMPLICIT = 1;
				/// <java-name>
				/// SHOW_FORCED
				/// </java-name>
				[Dot42.DexImport("SHOW_FORCED", "I", AccessFlags = 25)]
				public const int SHOW_FORCED = 2;
				/// <java-name>
				/// RESULT_UNCHANGED_SHOWN
				/// </java-name>
				[Dot42.DexImport("RESULT_UNCHANGED_SHOWN", "I", AccessFlags = 25)]
				public const int RESULT_UNCHANGED_SHOWN = 0;
				/// <java-name>
				/// RESULT_UNCHANGED_HIDDEN
				/// </java-name>
				[Dot42.DexImport("RESULT_UNCHANGED_HIDDEN", "I", AccessFlags = 25)]
				public const int RESULT_UNCHANGED_HIDDEN = 1;
				/// <java-name>
				/// RESULT_SHOWN
				/// </java-name>
				[Dot42.DexImport("RESULT_SHOWN", "I", AccessFlags = 25)]
				public const int RESULT_SHOWN = 2;
				/// <java-name>
				/// RESULT_HIDDEN
				/// </java-name>
				[Dot42.DexImport("RESULT_HIDDEN", "I", AccessFlags = 25)]
				public const int RESULT_HIDDEN = 3;
				/// <java-name>
				/// HIDE_IMPLICIT_ONLY
				/// </java-name>
				[Dot42.DexImport("HIDE_IMPLICIT_ONLY", "I", AccessFlags = 25)]
				public const int HIDE_IMPLICIT_ONLY = 1;
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
				public global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodInfo> GetInputMethodList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodInfo>);
				}

				/// <java-name>
				/// getEnabledInputMethodList
				/// </java-name>
				[Dot42.DexImport("getEnabledInputMethodList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/inputmethod/InputMethodInfo;>;")]
				public global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodInfo> GetEnabledInputMethodList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodInfo>);
				}

				/// <java-name>
				/// getEnabledInputMethodSubtypeList
				/// </java-name>
				[Dot42.DexImport("getEnabledInputMethodSubtypeList", "(Landroid/view/inputmethod/InputMethodInfo;Z)Ljava/util/List;", AccessFlags = 1, Signature = "(Landroid/view/inputmethod/InputMethodInfo;Z)Ljava/util/List<Landroid/view/inputm" +
    "ethod/InputMethodSubtype;>;")]
				public global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodSubtype> GetEnabledInputMethodSubtypeList(global::Android.Views.Inputmethod.InputMethodInfo inputMethodInfo, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodSubtype>);
				}

				/// <java-name>
				/// showStatusIcon
				/// </java-name>
				[Dot42.DexImport("showStatusIcon", "(Landroid/os/IBinder;Ljava/lang/String;I)V", AccessFlags = 1)]
				public void ShowStatusIcon(global::Android.OS.IBinder binder, string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hideStatusIcon
				/// </java-name>
				[Dot42.DexImport("hideStatusIcon", "(Landroid/os/IBinder;)V", AccessFlags = 1)]
				public void HideStatusIcon(global::Android.OS.IBinder binder) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isFullscreenMode
				/// </java-name>
				[Dot42.DexImport("isFullscreenMode", "()Z", AccessFlags = 1)]
				public bool IsFullscreenMode() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isActive
				/// </java-name>
				[Dot42.DexImport("isActive", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public bool IsActive(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isActive
				/// </java-name>
				[Dot42.DexImport("isActive", "()Z", AccessFlags = 1)]
				public bool IsActive() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

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
				public void DisplayCompletions(global::Android.Views.View view, global::Android.Views.Inputmethod.CompletionInfo[] completionInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateExtractedText
				/// </java-name>
				[Dot42.DexImport("updateExtractedText", "(Landroid/view/View;ILandroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
				public void UpdateExtractedText(global::Android.Views.View view, int int32, global::Android.Views.Inputmethod.ExtractedText extractedText) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showSoftInput
				/// </java-name>
				[Dot42.DexImport("showSoftInput", "(Landroid/view/View;I)Z", AccessFlags = 1)]
				public bool ShowSoftInput(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// showSoftInput
				/// </java-name>
				[Dot42.DexImport("showSoftInput", "(Landroid/view/View;ILandroid/os/ResultReceiver;)Z", AccessFlags = 1)]
				public bool ShowSoftInput(global::Android.Views.View view, int int32, global::Android.OS.ResultReceiver resultReceiver) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hideSoftInputFromWindow
				/// </java-name>
				[Dot42.DexImport("hideSoftInputFromWindow", "(Landroid/os/IBinder;I)Z", AccessFlags = 1)]
				public bool HideSoftInputFromWindow(global::Android.OS.IBinder binder, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hideSoftInputFromWindow
				/// </java-name>
				[Dot42.DexImport("hideSoftInputFromWindow", "(Landroid/os/IBinder;ILandroid/os/ResultReceiver;)Z", AccessFlags = 1)]
				public bool HideSoftInputFromWindow(global::Android.OS.IBinder binder, int int32, global::Android.OS.ResultReceiver resultReceiver) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toggleSoftInputFromWindow
				/// </java-name>
				[Dot42.DexImport("toggleSoftInputFromWindow", "(Landroid/os/IBinder;II)V", AccessFlags = 1)]
				public void ToggleSoftInputFromWindow(global::Android.OS.IBinder binder, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toggleSoftInput
				/// </java-name>
				[Dot42.DexImport("toggleSoftInput", "(II)V", AccessFlags = 1)]
				public void ToggleSoftInput(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// restartInput
				/// </java-name>
				[Dot42.DexImport("restartInput", "(Landroid/view/View;)V", AccessFlags = 1)]
				public void RestartInput(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateSelection
				/// </java-name>
				[Dot42.DexImport("updateSelection", "(Landroid/view/View;IIII)V", AccessFlags = 1)]
				public void UpdateSelection(global::Android.Views.View view, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// viewClicked
				/// </java-name>
				[Dot42.DexImport("viewClicked", "(Landroid/view/View;)V", AccessFlags = 1)]
				public void ViewClicked(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isWatchingCursor
				/// </java-name>
				[Dot42.DexImport("isWatchingCursor", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public bool IsWatchingCursor(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// updateCursor
				/// </java-name>
				[Dot42.DexImport("updateCursor", "(Landroid/view/View;IIII)V", AccessFlags = 1)]
				public void UpdateCursor(global::Android.Views.View view, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAppPrivateCommand
				/// </java-name>
				[Dot42.DexImport("sendAppPrivateCommand", "(Landroid/view/View;Ljava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public void SendAppPrivateCommand(global::Android.Views.View view, string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInputMethod
				/// </java-name>
				[Dot42.DexImport("setInputMethod", "(Landroid/os/IBinder;Ljava/lang/String;)V", AccessFlags = 1)]
				public void SetInputMethod(global::Android.OS.IBinder binder, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInputMethodAndSubtype
				/// </java-name>
				[Dot42.DexImport("setInputMethodAndSubtype", "(Landroid/os/IBinder;Ljava/lang/String;Landroid/view/inputmethod/InputMethodSubty" +
    "pe;)V", AccessFlags = 1)]
				public void SetInputMethodAndSubtype(global::Android.OS.IBinder binder, string @string, global::Android.Views.Inputmethod.InputMethodSubtype inputMethodSubtype) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hideSoftInputFromInputMethod
				/// </java-name>
				[Dot42.DexImport("hideSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V", AccessFlags = 1)]
				public void HideSoftInputFromInputMethod(global::Android.OS.IBinder binder, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showSoftInputFromInputMethod
				/// </java-name>
				[Dot42.DexImport("showSoftInputFromInputMethod", "(Landroid/os/IBinder;I)V", AccessFlags = 1)]
				public void ShowSoftInputFromInputMethod(global::Android.OS.IBinder binder, int int32) /* MethodBuilder.Create */ 
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
				/// showInputMethodAndSubtypeEnabler
				/// </java-name>
				[Dot42.DexImport("showInputMethodAndSubtypeEnabler", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public void ShowInputMethodAndSubtypeEnabler(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCurrentInputMethodSubtype
				/// </java-name>
				[Dot42.DexImport("getCurrentInputMethodSubtype", "()Landroid/view/inputmethod/InputMethodSubtype;", AccessFlags = 1)]
				public global::Android.Views.Inputmethod.InputMethodSubtype GetCurrentInputMethodSubtype() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.InputMethodSubtype);
				}

				/// <java-name>
				/// setCurrentInputMethodSubtype
				/// </java-name>
				[Dot42.DexImport("setCurrentInputMethodSubtype", "(Landroid/view/inputmethod/InputMethodSubtype;)Z", AccessFlags = 1)]
				public bool SetCurrentInputMethodSubtype(global::Android.Views.Inputmethod.InputMethodSubtype inputMethodSubtype) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getShortcutInputMethodsAndSubtypes
				/// </java-name>
				[Dot42.DexImport("getShortcutInputMethodsAndSubtypes", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Landroid/view/inputmethod/InputMethodInfo;Ljava/util/List<Landro" +
    "id/view/inputmethod/InputMethodSubtype;>;>;")]
				public global::Java.Util.IMap<global::Android.Views.Inputmethod.InputMethodInfo, global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodSubtype>> GetShortcutInputMethodsAndSubtypes() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IMap<global::Android.Views.Inputmethod.InputMethodInfo, global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodSubtype>>);
				}

				/// <java-name>
				/// switchToLastInputMethod
				/// </java-name>
				[Dot42.DexImport("switchToLastInputMethod", "(Landroid/os/IBinder;)Z", AccessFlags = 1)]
				public bool SwitchToLastInputMethod(global::Android.OS.IBinder binder) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setAdditionalInputMethodSubtypes
				/// </java-name>
				[Dot42.DexImport("setAdditionalInputMethodSubtypes", "(Ljava/lang/String;[Landroid/view/inputmethod/InputMethodSubtype;)V", AccessFlags = 1)]
				public void SetAdditionalInputMethodSubtypes(string @string, global::Android.Views.Inputmethod.InputMethodSubtype[] inputMethodSubtype) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLastInputMethodSubtype
				/// </java-name>
				[Dot42.DexImport("getLastInputMethodSubtype", "()Landroid/view/inputmethod/InputMethodSubtype;", AccessFlags = 1)]
				public global::Android.Views.Inputmethod.InputMethodSubtype GetLastInputMethodSubtype() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.InputMethodSubtype);
				}

				/// <java-name>
				/// getInputMethodList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodInfo> InputMethodList
				{
				[Dot42.DexImport("getInputMethodList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/inputmethod/InputMethodInfo;>;")]
						get{ return GetInputMethodList(); }
				}

				/// <java-name>
				/// getEnabledInputMethodList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodInfo> EnabledInputMethodList
				{
				[Dot42.DexImport("getEnabledInputMethodList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/inputmethod/InputMethodInfo;>;")]
						get{ return GetEnabledInputMethodList(); }
				}

				/// <java-name>
				/// getCurrentInputMethodSubtype
				/// </java-name>
				public global::Android.Views.Inputmethod.InputMethodSubtype CurrentInputMethodSubtype
				{
				[Dot42.DexImport("getCurrentInputMethodSubtype", "()Landroid/view/inputmethod/InputMethodSubtype;", AccessFlags = 1)]
						get{ return GetCurrentInputMethodSubtype(); }
				}

				/// <java-name>
				/// getShortcutInputMethodsAndSubtypes
				/// </java-name>
				public global::Java.Util.IMap<global::Android.Views.Inputmethod.InputMethodInfo, global::Java.Util.IList<global::Android.Views.Inputmethod.InputMethodSubtype>> ShortcutInputMethodsAndSubtypes
				{
				[Dot42.DexImport("getShortcutInputMethodsAndSubtypes", "()Ljava/util/Map;", AccessFlags = 1, Signature = "()Ljava/util/Map<Landroid/view/inputmethod/InputMethodInfo;Ljava/util/List<Landro" +
    "id/view/inputmethod/InputMethodSubtype;>;>;")]
						get{ return GetShortcutInputMethodsAndSubtypes(); }
				}

				/// <java-name>
				/// getLastInputMethodSubtype
				/// </java-name>
				public global::Android.Views.Inputmethod.InputMethodSubtype LastInputMethodSubtype
				{
				[Dot42.DexImport("getLastInputMethodSubtype", "()Landroid/view/inputmethod/InputMethodSubtype;", AccessFlags = 1)]
						get{ return GetLastInputMethodSubtype(); }
				}

		}

		/// <java-name>
		/// android/view/inputmethod/InputMethodSubtype
		/// </java-name>
		[Dot42.DexImport("android/view/inputmethod/InputMethodSubtype", AccessFlags = 49)]
		public sealed partial class InputMethodSubtype : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Inputmethod.InputMethodSubtype> CREATOR;
				[Dot42.DexImport("<init>", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)V", AccessFlags = 1)]
				public InputMethodSubtype(int int32, int int321, string @string, string string1, string string2, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNameResId
				/// </java-name>
				[Dot42.DexImport("getNameResId", "()I", AccessFlags = 1)]
				public int GetNameResId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getIconResId
				/// </java-name>
				[Dot42.DexImport("getIconResId", "()I", AccessFlags = 1)]
				public int GetIconResId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetLocale() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getMode
				/// </java-name>
				[Dot42.DexImport("getMode", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetMode() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getExtraValue
				/// </java-name>
				[Dot42.DexImport("getExtraValue", "()Ljava/lang/String;", AccessFlags = 1)]
				public string GetExtraValue() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// isAuxiliary
				/// </java-name>
				[Dot42.DexImport("isAuxiliary", "()Z", AccessFlags = 1)]
				public bool IsAuxiliary() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// overridesImplicitlyEnabledSubtype
				/// </java-name>
				[Dot42.DexImport("overridesImplicitlyEnabledSubtype", "()Z", AccessFlags = 1)]
				public bool OverridesImplicitlyEnabledSubtype() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDisplayName
				/// </java-name>
				[Dot42.DexImport("getDisplayName", "(Landroid/content/Context;Ljava/lang/String;Landroid/content/pm/ApplicationInfo;)" +
    "Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetDisplayName(global::Android.Content.Context context, string @string, global::Android.Content.Pm.ApplicationInfo applicationInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// containsExtraValueKey
				/// </java-name>
				[Dot42.DexImport("containsExtraValueKey", "(Ljava/lang/String;)Z", AccessFlags = 1)]
				public bool ContainsExtraValueKey(string @string) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getExtraValueOf
				/// </java-name>
				[Dot42.DexImport("getExtraValueOf", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public string GetExtraValueOf(string @string) /* MethodBuilder.Create */ 
				{
						return default(string);
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
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
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

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal InputMethodSubtype() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNameResId
				/// </java-name>
				public int NameResId
				{
				[Dot42.DexImport("getNameResId", "()I", AccessFlags = 1)]
						get{ return GetNameResId(); }
				}

				/// <java-name>
				/// getIconResId
				/// </java-name>
				public int IconResId
				{
				[Dot42.DexImport("getIconResId", "()I", AccessFlags = 1)]
						get{ return GetIconResId(); }
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				public string Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetLocale(); }
				}

				/// <java-name>
				/// getMode
				/// </java-name>
				public string Mode
				{
				[Dot42.DexImport("getMode", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetMode(); }
				}

				/// <java-name>
				/// getExtraValue
				/// </java-name>
				public string ExtraValue
				{
				[Dot42.DexImport("getExtraValue", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetExtraValue(); }
				}

		}

}

