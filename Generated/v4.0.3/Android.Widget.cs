#pragma warning disable 1717
namespace Android.Widget
{
		/// <java-name>
		/// android/widget/AbsListView
		/// </java-name>
		[Dot42.DexImport("android/widget/AbsListView", AccessFlags = 1057, Signature = "Landroid/widget/AdapterView<Landroid/widget/ListAdapter;>;Landroid/text/TextWatch" +
    "er;Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;Landroid/widget/Filter$" +
    "FilterListener;Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;")]
		public abstract partial class AbsListView : global::Android.Widget.AdapterView<global::Android.Widget.IListAdapter>, global::Android.Text.ITextWatcher, global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener, global::Android.Widget.Filter.IFilterListener, global::Android.Views.ViewTreeObserver.IOnTouchModeChangeListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TRANSCRIPT_MODE_DISABLED
				/// </java-name>
				[Dot42.DexImport("TRANSCRIPT_MODE_DISABLED", "I", AccessFlags = 25)]
				public const int TRANSCRIPT_MODE_DISABLED = 0;
				/// <java-name>
				/// TRANSCRIPT_MODE_NORMAL
				/// </java-name>
				[Dot42.DexImport("TRANSCRIPT_MODE_NORMAL", "I", AccessFlags = 25)]
				public const int TRANSCRIPT_MODE_NORMAL = 1;
				/// <java-name>
				/// TRANSCRIPT_MODE_ALWAYS_SCROLL
				/// </java-name>
				[Dot42.DexImport("TRANSCRIPT_MODE_ALWAYS_SCROLL", "I", AccessFlags = 25)]
				public const int TRANSCRIPT_MODE_ALWAYS_SCROLL = 2;
				/// <java-name>
				/// CHOICE_MODE_NONE
				/// </java-name>
				[Dot42.DexImport("CHOICE_MODE_NONE", "I", AccessFlags = 25)]
				public const int CHOICE_MODE_NONE = 0;
				/// <java-name>
				/// CHOICE_MODE_SINGLE
				/// </java-name>
				[Dot42.DexImport("CHOICE_MODE_SINGLE", "I", AccessFlags = 25)]
				public const int CHOICE_MODE_SINGLE = 1;
				/// <java-name>
				/// CHOICE_MODE_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("CHOICE_MODE_MULTIPLE", "I", AccessFlags = 25)]
				public const int CHOICE_MODE_MULTIPLE = 2;
				/// <java-name>
				/// CHOICE_MODE_MULTIPLE_MODAL
				/// </java-name>
				[Dot42.DexImport("CHOICE_MODE_MULTIPLE_MODAL", "I", AccessFlags = 25)]
				public const int CHOICE_MODE_MULTIPLE_MODAL = 3;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbsListView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AbsListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AbsListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isItemChecked
				/// </java-name>
				[Dot42.DexImport("isItemChecked", "(I)Z", AccessFlags = 1)]
				public virtual bool IsItemChecked(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearChoices
				/// </java-name>
				[Dot42.DexImport("clearChoices", "()V", AccessFlags = 1)]
				public virtual void ClearChoices() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setItemChecked
				/// </java-name>
				[Dot42.DexImport("setItemChecked", "(IZ)V", AccessFlags = 1)]
				public virtual void SetItemChecked(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performItemClick
				/// </java-name>
				[Dot42.DexImport("performItemClick", "(Landroid/view/View;IJ)Z", AccessFlags = 1)]
				public override bool PerformItemClick(global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMultiChoiceModeListener
				/// </java-name>
				[Dot42.DexImport("setMultiChoiceModeListener", "(Landroid/widget/AbsListView$MultiChoiceModeListener;)V", AccessFlags = 1)]
				public virtual void SetMultiChoiceModeListener(global::Android.Widget.AbsListView.IMultiChoiceModeListener multiChoiceModeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnScrollListener
				/// </java-name>
				[Dot42.DexImport("setOnScrollListener", "(Landroid/widget/AbsListView$OnScrollListener;)V", AccessFlags = 1)]
				public virtual void SetOnScrollListener(global::Android.Widget.AbsListView.IOnScrollListener onScrollListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1)]
				public override void SendAccessibilityEvent(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFocusedRect
				/// </java-name>
				[Dot42.DexImport("getFocusedRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public override void GetFocusedRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFilterText
				/// </java-name>
				[Dot42.DexImport("setFilterText", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetFilterText(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layoutChildren
				/// </java-name>
				[Dot42.DexImport("layoutChildren", "()V", AccessFlags = 4)]
				protected internal virtual void LayoutChildren() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDrawSelectorOnTop
				/// </java-name>
				[Dot42.DexImport("setDrawSelectorOnTop", "(Z)V", AccessFlags = 1)]
				public virtual void SetDrawSelectorOnTop(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelector
				/// </java-name>
				[Dot42.DexImport("setSelector", "(I)V", AccessFlags = 1)]
				public virtual void SetSelector(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScrollIndicators
				/// </java-name>
				[Dot42.DexImport("setScrollIndicators", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetScrollIndicators(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 1)]
				public new virtual bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showContextMenuForChild
				/// </java-name>
				[Dot42.DexImport("showContextMenuForChild", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public override bool ShowContextMenuForChild(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchSetPressed
				/// </java-name>
				[Dot42.DexImport("dispatchSetPressed", "(Z)V", AccessFlags = 4)]
				protected internal override void DispatchSetPressed(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pointToPosition
				/// </java-name>
				[Dot42.DexImport("pointToPosition", "(II)I", AccessFlags = 1)]
				public virtual int PointToPosition(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// pointToRowId
				/// </java-name>
				[Dot42.DexImport("pointToRowId", "(II)J", AccessFlags = 1)]
				public virtual long PointToRowId(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// onTouchModeChanged
				/// </java-name>
				[Dot42.DexImport("onTouchModeChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnTouchModeChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal override void OnOverScrolled(int int32, int int321, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestDisallowInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("requestDisallowInterceptTouchEvent", "(Z)V", AccessFlags = 1)]
				public override void RequestDisallowInterceptTouchEvent(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addTouchables
				/// </java-name>
				[Dot42.DexImport("addTouchables", "(Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;)V")]
				public override void AddTouchables(global::Java.Util.ArrayList<global::Android.Views.View> arrayList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFriction
				/// </java-name>
				[Dot42.DexImport("setFriction", "(F)V", AccessFlags = 1)]
				public virtual void SetFriction(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVelocityScale
				/// </java-name>
				[Dot42.DexImport("setVelocityScale", "(F)V", AccessFlags = 1)]
				public virtual void SetVelocityScale(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollToPosition
				/// </java-name>
				[Dot42.DexImport("smoothScrollToPosition", "(I)V", AccessFlags = 1)]
				public virtual void SmoothScrollToPosition(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollToPositionFromTop
				/// </java-name>
				[Dot42.DexImport("smoothScrollToPositionFromTop", "(III)V", AccessFlags = 1)]
				public virtual void SmoothScrollToPositionFromTop(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollToPositionFromTop
				/// </java-name>
				[Dot42.DexImport("smoothScrollToPositionFromTop", "(II)V", AccessFlags = 1)]
				public virtual void SmoothScrollToPositionFromTop(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollToPosition
				/// </java-name>
				[Dot42.DexImport("smoothScrollToPosition", "(II)V", AccessFlags = 1)]
				public virtual void SmoothScrollToPosition(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollBy
				/// </java-name>
				[Dot42.DexImport("smoothScrollBy", "(II)V", AccessFlags = 1)]
				public virtual void SmoothScrollBy(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateViews
				/// </java-name>
				[Dot42.DexImport("invalidateViews", "()V", AccessFlags = 1)]
				public virtual void InvalidateViews() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// handleDataChanged
				/// </java-name>
				[Dot42.DexImport("handleDataChanged", "()V", AccessFlags = 4)]
				protected internal virtual void HandleDataChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisplayHint
				/// </java-name>
				[Dot42.DexImport("onDisplayHint", "(I)V", AccessFlags = 4)]
				protected internal override void OnDisplayHint(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateInputConnection
				/// </java-name>
				[Dot42.DexImport("onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;" +
    "", AccessFlags = 1)]
				public override global::Android.Views.Inputmethod.IInputConnection OnCreateInputConnection(global::Android.Views.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.IInputConnection);
				}

				/// <java-name>
				/// checkInputConnectionProxy
				/// </java-name>
				[Dot42.DexImport("checkInputConnectionProxy", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public override bool CheckInputConnectionProxy(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearTextFilter
				/// </java-name>
				[Dot42.DexImport("clearTextFilter", "()V", AccessFlags = 1)]
				public virtual void ClearTextFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGlobalLayout
				/// </java-name>
				[Dot42.DexImport("onGlobalLayout", "()V", AccessFlags = 1)]
				public virtual void OnGlobalLayout() /* MethodBuilder.Create */ 
				{
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
				/// onFilterComplete
				/// </java-name>
				[Dot42.DexImport("onFilterComplete", "(I)V", AccessFlags = 1)]
				public virtual void OnFilterComplete(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/AbsListView$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.AbsListView.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.AbsListView.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// reclaimViews
				/// </java-name>
				[Dot42.DexImport("reclaimViews", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Landroid/view/View;>;)V")]
				public virtual void ReclaimViews(global::Java.Util.IList<global::Android.Views.View> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRemoteViewsAdapter
				/// </java-name>
				[Dot42.DexImport("setRemoteViewsAdapter", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetRemoteViewsAdapter(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deferNotifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("deferNotifyDataSetChanged", "()V", AccessFlags = 1)]
				public virtual void DeferNotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRemoteAdapterConnected
				/// </java-name>
				[Dot42.DexImport("onRemoteAdapterConnected", "()Z", AccessFlags = 1)]
				public virtual bool OnRemoteAdapterConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onRemoteAdapterDisconnected
				/// </java-name>
				[Dot42.DexImport("onRemoteAdapterDisconnected", "()V", AccessFlags = 1)]
				public virtual void OnRemoteAdapterDisconnected() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRecyclerListener
				/// </java-name>
				[Dot42.DexImport("setRecyclerListener", "(Landroid/widget/AbsListView$RecyclerListener;)V", AccessFlags = 1)]
				public virtual void SetRecyclerListener(global::Android.Widget.AbsListView.IRecyclerListener recyclerListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbsListView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCheckedItemCount
				/// </java-name>
				public virtual int CheckedItemCount
				{
						[Dot42.DexImport("getCheckedItemCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCheckedItemPosition
				/// </java-name>
				public virtual int CheckedItemPosition
				{
						[Dot42.DexImport("getCheckedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCheckedItemPositions
				/// </java-name>
				public virtual global::Android.Util.SparseBooleanArray CheckedItemPositions
				{
						[Dot42.DexImport("getCheckedItemPositions", "()Landroid/util/SparseBooleanArray;", AccessFlags = 1)]
						get{ return default(global::Android.Util.SparseBooleanArray); }
				}

				/// <java-name>
				/// getCheckedItemIds
				/// </java-name>
				public virtual long[] CheckedItemIds
				{
						[Dot42.DexImport("getCheckedItemIds", "()[J", AccessFlags = 1)]
						get{ return default(long[]); }
				}

				/// <java-name>
				/// getChoiceMode
				/// </java-name>
				public virtual int ChoiceMode
				{
						[Dot42.DexImport("getChoiceMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setChoiceMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isFastScrollAlwaysVisible
				/// </java-name>
				public virtual bool IsFastScrollAlwaysVisible
				{
						[Dot42.DexImport("isFastScrollAlwaysVisible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFastScrollAlwaysVisible", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getVerticalScrollbarWidth
				/// </java-name>
				public override int VerticalScrollbarWidth
				{
						[Dot42.DexImport("getVerticalScrollbarWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isFastScrollEnabled
				/// </java-name>
				public virtual bool IsFastScrollEnabled
				{
						[Dot42.DexImport("isFastScrollEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFastScrollEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSmoothScrollbarEnabled
				/// </java-name>
				public virtual bool IsSmoothScrollbarEnabled
				{
						[Dot42.DexImport("isSmoothScrollbarEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSmoothScrollbarEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isScrollingCacheEnabled
				/// </java-name>
				public virtual bool IsScrollingCacheEnabled
				{
						[Dot42.DexImport("isScrollingCacheEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setScrollingCacheEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isTextFilterEnabled
				/// </java-name>
				public virtual bool IsTextFilterEnabled
				{
						[Dot42.DexImport("isTextFilterEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setTextFilterEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isStackFromBottom
				/// </java-name>
				public virtual bool IsStackFromBottom
				{
						[Dot42.DexImport("isStackFromBottom", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setStackFromBottom", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTextFilter
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence TextFilter
				{
						[Dot42.DexImport("getTextFilter", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <java-name>
				/// getTopFadingEdgeStrength
				/// </java-name>
				protected internal override float TopFadingEdgeStrength
				{
						[Dot42.DexImport("getTopFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getBottomFadingEdgeStrength
				/// </java-name>
				protected internal override float BottomFadingEdgeStrength
				{
						[Dot42.DexImport("getBottomFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getSelectedView
				/// </java-name>
				public override global::Android.Views.View SelectedView
				{
						[Dot42.DexImport("getSelectedView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getListPaddingTop
				/// </java-name>
				public virtual int ListPaddingTop
				{
						[Dot42.DexImport("getListPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getListPaddingBottom
				/// </java-name>
				public virtual int ListPaddingBottom
				{
						[Dot42.DexImport("getListPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getListPaddingLeft
				/// </java-name>
				public virtual int ListPaddingLeft
				{
						[Dot42.DexImport("getListPaddingLeft", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getListPaddingRight
				/// </java-name>
				public virtual int ListPaddingRight
				{
						[Dot42.DexImport("getListPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isPaddingOffsetRequired
				/// </java-name>
				protected internal override bool IsPaddingOffsetRequired
				{
						[Dot42.DexImport("isPaddingOffsetRequired", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLeftPaddingOffset
				/// </java-name>
				protected internal override int LeftPaddingOffset
				{
						[Dot42.DexImport("getLeftPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTopPaddingOffset
				/// </java-name>
				protected internal override int TopPaddingOffset
				{
						[Dot42.DexImport("getTopPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRightPaddingOffset
				/// </java-name>
				protected internal override int RightPaddingOffset
				{
						[Dot42.DexImport("getRightPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBottomPaddingOffset
				/// </java-name>
				protected internal override int BottomPaddingOffset
				{
						[Dot42.DexImport("getBottomPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSelector
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Selector
				{
						[Dot42.DexImport("getSelector", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setSelector", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getContextMenuInfo
				/// </java-name>
				protected internal override global::Android.Views.IContextMenu_IContextMenuInfo ContextMenuInfo
				{
						[Dot42.DexImport("getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", AccessFlags = 4)]
						get{ return default(global::Android.Views.IContextMenu_IContextMenuInfo); }
				}

				/// <java-name>
				/// isInFilterMode
				/// </java-name>
				protected internal virtual bool IsInFilterMode
				{
						[Dot42.DexImport("isInFilterMode", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasTextFilter
				/// </java-name>
				public virtual bool HasTextFilter
				{
						[Dot42.DexImport("hasTextFilter", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getTranscriptMode
				/// </java-name>
				public virtual int TranscriptMode
				{
						[Dot42.DexImport("getTranscriptMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setTranscriptMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSolidColor
				/// </java-name>
				public override int SolidColor
				{
						[Dot42.DexImport("getSolidColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCacheColorHint
				/// </java-name>
				public virtual int CacheColorHint
				{
						[Dot42.DexImport("getCacheColorHint", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCacheColorHint", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setOverScrollMode
				/// </java-name>
				public override int OverScrollMode
				{
						[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setAdapter
				/// </java-name>
				public override global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setVerticalScrollbarPosition
				/// </java-name>
				public override int VerticalScrollbarPosition
				{
						[Dot42.DexImport("setVerticalScrollbarPosition", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/AbsListView$RecyclerListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$RecyclerListener", AccessFlags = 1545)]
				public partial interface IRecyclerListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onMovedToScrapHeap
						/// </java-name>
						[Dot42.DexImport("onMovedToScrapHeap", "(Landroid/view/View;)V", AccessFlags = 1025)]
						void OnMovedToScrapHeap(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/AbsListView$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/widget/AbsListView$MultiChoiceModeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$MultiChoiceModeListener", AccessFlags = 1545)]
				public partial interface IMultiChoiceModeListener : global::Android.Views.ActionMode.ICallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onItemCheckedStateChanged
						/// </java-name>
						[Dot42.DexImport("onItemCheckedStateChanged", "(Landroid/view/ActionMode;IJZ)V", AccessFlags = 1025)]
						void OnItemCheckedStateChanged(global::Android.Views.ActionMode actionMode, int int32, long int64, bool boolean) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/AbsListView$SelectionBoundsAdjuster
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$SelectionBoundsAdjuster", AccessFlags = 1545)]
				public partial interface ISelectionBoundsAdjuster
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// adjustListItemSelectionBounds
						/// </java-name>
						[Dot42.DexImport("adjustListItemSelectionBounds", "(Landroid/graphics/Rect;)V", AccessFlags = 1025)]
						void AdjustListItemSelectionBounds(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/AbsListView$OnScrollListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$OnScrollListener", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IOnScrollListenerConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SCROLL_STATE_IDLE
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_IDLE", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_IDLE = 0;
						/// <java-name>
						/// SCROLL_STATE_TOUCH_SCROLL
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_TOUCH_SCROLL", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_TOUCH_SCROLL = 1;
						/// <java-name>
						/// SCROLL_STATE_FLING
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_FLING", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_FLING = 2;
				}

				/// <java-name>
				/// android/widget/AbsListView$OnScrollListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsListView$OnScrollListener", AccessFlags = 1545)]
				public partial interface IOnScrollListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onScrollStateChanged
						/// </java-name>
						[Dot42.DexImport("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", AccessFlags = 1025)]
						void OnScrollStateChanged(global::Android.Widget.AbsListView absListView, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onScroll
						/// </java-name>
						[Dot42.DexImport("onScroll", "(Landroid/widget/AbsListView;III)V", AccessFlags = 1025)]
						void OnScroll(global::Android.Widget.AbsListView absListView, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/AbsoluteLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/AbsoluteLayout", AccessFlags = 33)]
		public partial class AbsoluteLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbsoluteLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AbsoluteLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AbsoluteLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 1)]
				public override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public override bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbsoluteLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/widget/AbsoluteLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/AbsoluteLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams
 /* scope: __dot42__ */ 
				{
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
						[Dot42.DexImport("<init>", "(IIII)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// debug
						/// </java-name>
						[Dot42.DexImport("debug", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Debug(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/AbsSeekBar
		/// </java-name>
		[Dot42.DexImport("android/widget/AbsSeekBar", AccessFlags = 1057)]
		public abstract partial class AbsSeekBar : global::Android.Widget.ProgressBar
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbsSeekBar(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AbsSeekBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AbsSeekBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setThumb
				/// </java-name>
				[Dot42.DexImport("setThumb", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetThumb(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 36)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 36)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbsSeekBar() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getThumbOffset
				/// </java-name>
				public virtual int ThumbOffset
				{
						[Dot42.DexImport("getThumbOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setThumbOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getKeyProgressIncrement
				/// </java-name>
				public virtual int KeyProgressIncrement
				{
						[Dot42.DexImport("getKeyProgressIncrement", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setKeyProgressIncrement", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMax
				/// </java-name>
				public override int Max
				{
						[Dot42.DexImport("setMax", "(I)V", AccessFlags = 33)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/AbsSpinner
		/// </java-name>
		[Dot42.DexImport("android/widget/AbsSpinner", AccessFlags = 1057, Signature = "Landroid/widget/AdapterView<Landroid/widget/SpinnerAdapter;>;")]
		public abstract partial class AbsSpinner : global::Android.Widget.AdapterView<global::Android.Widget.ISpinnerAdapter>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AbsSpinner(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AbsSpinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AbsSpinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(IZ)V", AccessFlags = 1)]
				public virtual void SetSelection(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public override void SetSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pointToPosition
				/// </java-name>
				[Dot42.DexImport("pointToPosition", "(II)I", AccessFlags = 1)]
				public virtual int PointToPosition(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbsSpinner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSelectedView
				/// </java-name>
				public override global::Android.Views.View SelectedView
				{
						[Dot42.DexImport("getSelectedView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.ISpinnerAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/SpinnerAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ISpinnerAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/SpinnerAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/widget/AdapterView
		/// </java-name>
		[Dot42.DexImport("android/widget/AdapterView", AccessFlags = 1057, Signature = "<T::Landroid/widget/Adapter;>Landroid/view/ViewGroup;")]
		public abstract partial class AdapterView<T> : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ITEM_VIEW_TYPE_IGNORE
				/// </java-name>
				[Dot42.DexImport("ITEM_VIEW_TYPE_IGNORE", "I", AccessFlags = 25)]
				public const int ITEM_VIEW_TYPE_IGNORE = -1;
				/// <java-name>
				/// ITEM_VIEW_TYPE_HEADER_OR_FOOTER
				/// </java-name>
				[Dot42.DexImport("ITEM_VIEW_TYPE_HEADER_OR_FOOTER", "I", AccessFlags = 25)]
				public const int ITEM_VIEW_TYPE_HEADER_OR_FOOTER = -2;
				/// <java-name>
				/// INVALID_POSITION
				/// </java-name>
				[Dot42.DexImport("INVALID_POSITION", "I", AccessFlags = 25)]
				public const int INVALID_POSITION = -1;
				/// <java-name>
				/// INVALID_ROW_ID
				/// </java-name>
				[Dot42.DexImport("INVALID_ROW_ID", "J", AccessFlags = 25)]
				public const long INVALID_ROW_ID = -9223372036854775808;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AdapterView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AdapterView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AdapterView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performItemClick
				/// </java-name>
				[Dot42.DexImport("performItemClick", "(Landroid/view/View;IJ)Z", AccessFlags = 1)]
				public virtual bool PerformItemClick(global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeView
				/// </java-name>
				[Dot42.DexImport("removeView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void RemoveView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewAt
				/// </java-name>
				[Dot42.DexImport("removeViewAt", "(I)V", AccessFlags = 1)]
				public override void RemoveViewAt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "()V", AccessFlags = 1)]
				public override void RemoveAllViews() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPositionForView
				/// </java-name>
				[Dot42.DexImport("getPositionForView", "(Landroid/view/View;)I", AccessFlags = 1)]
				public virtual int GetPositionForView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1025)]
				public abstract void SetSelection(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getItemAtPosition
				/// </java-name>
				[Dot42.DexImport("getItemAtPosition", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetItemAtPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getItemIdAtPosition
				/// </java-name>
				[Dot42.DexImport("getItemIdAtPosition", "(I)J", AccessFlags = 1)]
				public virtual long GetItemIdAtPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setOnClickListener
				/// </java-name>
				[Dot42.DexImport("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public override void SetOnClickListener(global::Android.Views.View.IOnClickListener onClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchSaveInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchRestoreInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onRequestSendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onRequestSendAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool OnRequestSendAccessibilityEvent(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AdapterView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getOnItemClickListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<T>.IOnItemClickListener OnItemClickListener
				{
						[Dot42.DexImport("getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", AccessFlags = 17)]
						get{ return default(global::Android.Widget.AdapterView<T>.IOnItemClickListener); }
						[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOnItemLongClickListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<T>.IOnItemLongClickListener OnItemLongClickListener
				{
						[Dot42.DexImport("getOnItemLongClickListener", "()Landroid/widget/AdapterView$OnItemLongClickListener;", AccessFlags = 17)]
						get{ return default(global::Android.Widget.AdapterView<T>.IOnItemLongClickListener); }
						[Dot42.DexImport("setOnItemLongClickListener", "(Landroid/widget/AdapterView$OnItemLongClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOnItemSelectedListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<T>.IOnItemSelectedListener OnItemSelectedListener
				{
						[Dot42.DexImport("getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", AccessFlags = 17)]
						get{ return default(global::Android.Widget.AdapterView<T>.IOnItemSelectedListener); }
						[Dot42.DexImport("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public abstract T Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/Adapter;", AccessFlags = 1025, Signature = "()TT;")]
						get;
						[Dot42.DexImport("setAdapter", "(Landroid/widget/Adapter;)V", AccessFlags = 1025, Signature = "(TT;)V")]
						set;
				}

				/// <java-name>
				/// getSelectedItemPosition
				/// </java-name>
				public virtual int SelectedItemPosition
				{
						[Dot42.DexImport("getSelectedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSelectedItemId
				/// </java-name>
				public virtual long SelectedItemId
				{
						[Dot42.DexImport("getSelectedItemId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getSelectedView
				/// </java-name>
				public abstract global::Android.Views.View SelectedView
				{
						[Dot42.DexImport("getSelectedView", "()Landroid/view/View;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSelectedItem
				/// </java-name>
				public virtual object SelectedItem
				{
						[Dot42.DexImport("getSelectedItem", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public virtual int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFirstVisiblePosition
				/// </java-name>
				public virtual int FirstVisiblePosition
				{
						[Dot42.DexImport("getFirstVisiblePosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLastVisiblePosition
				/// </java-name>
				public virtual int LastVisiblePosition
				{
						[Dot42.DexImport("getLastVisiblePosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEmptyView
				/// </java-name>
				public virtual global::Android.Views.View EmptyView
				{
						[Dot42.DexImport("getEmptyView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
						[Dot42.DexImport("setEmptyView", "(Landroid/view/View;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// canAnimate
				/// </java-name>
				protected internal override bool CanAnimate
				{
						[Dot42.DexImport("canAnimate", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// setFocusable
				/// </java-name>
				public override bool IsFocusable
				{
						[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setFocusableInTouchMode
				/// </java-name>
				public override bool IsFocusableInTouchMode
				{
						[Dot42.DexImport("setFocusableInTouchMode", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/AdapterView$AdapterContextMenuInfo
				/// </java-name>
				[Dot42.DexImport("android/widget/AdapterView$AdapterContextMenuInfo", AccessFlags = 9)]
				public partial class AdapterContextMenuInfo : global::Android.Views.IContextMenu_IContextMenuInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// targetView
						/// </java-name>
						[Dot42.DexImport("targetView", "Landroid/view/View;", AccessFlags = 1)]
						public global::Android.Views.View TargetView;
						/// <java-name>
						/// position
						/// </java-name>
						[Dot42.DexImport("position", "I", AccessFlags = 1)]
						public int Position;
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "J", AccessFlags = 1)]
						public long Id;
						[Dot42.DexImport("<init>", "(Landroid/view/View;IJ)V", AccessFlags = 1)]
						public AdapterContextMenuInfo(global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal AdapterContextMenuInfo() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/widget/AdapterView$OnItemSelectedListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AdapterView$OnItemSelectedListener", AccessFlags = 1545)]
				public partial interface IOnItemSelectedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onItemSelected
						/// </java-name>
						[Dot42.DexImport("onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", AccessFlags = 1025, Signature = "(Landroid/widget/AdapterView<*>;Landroid/view/View;IJ)V")]
						void OnItemSelected(global::Android.Widget.AdapterView<object> adapterView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onNothingSelected
						/// </java-name>
						[Dot42.DexImport("onNothingSelected", "(Landroid/widget/AdapterView;)V", AccessFlags = 1025, Signature = "(Landroid/widget/AdapterView<*>;)V")]
						void OnNothingSelected(global::Android.Widget.AdapterView<object> adapterView) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/AdapterView$OnItemLongClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AdapterView$OnItemLongClickListener", AccessFlags = 1545)]
				public partial interface IOnItemLongClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onItemLongClick
						/// </java-name>
						[Dot42.DexImport("onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z", AccessFlags = 1025, Signature = "(Landroid/widget/AdapterView<*>;Landroid/view/View;IJ)Z")]
						bool OnItemLongClick(global::Android.Widget.AdapterView<object> adapterView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/AdapterView$OnItemClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/AdapterView$OnItemClickListener", AccessFlags = 1545)]
				public partial interface IOnItemClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onItemClick
						/// </java-name>
						[Dot42.DexImport("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", AccessFlags = 1025, Signature = "(Landroid/widget/AdapterView<*>;Landroid/view/View;IJ)V")]
						void OnItemClick(global::Android.Widget.AdapterView<object> adapterView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/AdapterViewAnimator
		/// </java-name>
		[Dot42.DexImport("android/widget/AdapterViewAnimator", AccessFlags = 1057, Signature = "Landroid/widget/AdapterView<Landroid/widget/Adapter;>;")]
		public abstract partial class AdapterViewAnimator : global::Android.Widget.AdapterView<global::Android.Widget.IAdapter>
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AdapterViewAnimator(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AdapterViewAnimator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AdapterViewAnimator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showNext
				/// </java-name>
				[Dot42.DexImport("showNext", "()V", AccessFlags = 1)]
				public virtual void ShowNext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showPrevious
				/// </java-name>
				[Dot42.DexImport("showPrevious", "()V", AccessFlags = 1)]
				public virtual void ShowPrevious() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInAnimation
				/// </java-name>
				[Dot42.DexImport("setInAnimation", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInAnimation(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOutAnimation
				/// </java-name>
				[Dot42.DexImport("setOutAnimation", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetOutAnimation(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAnimateFirstView
				/// </java-name>
				[Dot42.DexImport("setAnimateFirstView", "(Z)V", AccessFlags = 1)]
				public virtual void SetAnimateFirstView(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRemoteViewsAdapter
				/// </java-name>
				[Dot42.DexImport("setRemoteViewsAdapter", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetRemoteViewsAdapter(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public override void SetSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deferNotifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("deferNotifyDataSetChanged", "()V", AccessFlags = 1)]
				public virtual void DeferNotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRemoteAdapterConnected
				/// </java-name>
				[Dot42.DexImport("onRemoteAdapterConnected", "()Z", AccessFlags = 1)]
				public virtual bool OnRemoteAdapterConnected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onRemoteAdapterDisconnected
				/// </java-name>
				[Dot42.DexImport("onRemoteAdapterDisconnected", "()V", AccessFlags = 1)]
				public virtual void OnRemoteAdapterDisconnected() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// advance
				/// </java-name>
				[Dot42.DexImport("advance", "()V", AccessFlags = 1)]
				public virtual void Advance() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fyiWillBeAdvancedByHostKThx
				/// </java-name>
				[Dot42.DexImport("fyiWillBeAdvancedByHostKThx", "()V", AccessFlags = 1)]
				public virtual void FyiWillBeAdvancedByHostKThx() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AdapterViewAnimator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDisplayedChild
				/// </java-name>
				public virtual int DisplayedChild
				{
						[Dot42.DexImport("getDisplayedChild", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDisplayedChild", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrentView
				/// </java-name>
				public virtual global::Android.Views.View CurrentView
				{
						[Dot42.DexImport("getCurrentView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getInAnimation
				/// </java-name>
				public virtual global::Android.Animation.ObjectAnimator InAnimation
				{
						[Dot42.DexImport("getInAnimation", "()Landroid/animation/ObjectAnimator;", AccessFlags = 1)]
						get{ return default(global::Android.Animation.ObjectAnimator); }
						[Dot42.DexImport("setInAnimation", "(Landroid/animation/ObjectAnimator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOutAnimation
				/// </java-name>
				public virtual global::Android.Animation.ObjectAnimator OutAnimation
				{
						[Dot42.DexImport("getOutAnimation", "()Landroid/animation/ObjectAnimator;", AccessFlags = 1)]
						get{ return default(global::Android.Animation.ObjectAnimator); }
						[Dot42.DexImport("setOutAnimation", "(Landroid/animation/ObjectAnimator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.IAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/Adapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/Adapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSelectedView
				/// </java-name>
				public override global::Android.Views.View SelectedView
				{
						[Dot42.DexImport("getSelectedView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

		}

		/// <java-name>
		/// android/widget/AdapterViewFlipper
		/// </java-name>
		[Dot42.DexImport("android/widget/AdapterViewFlipper", AccessFlags = 33)]
		public partial class AdapterViewFlipper : global::Android.Widget.AdapterViewAnimator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AdapterViewFlipper(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AdapterViewFlipper(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal override void OnWindowVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFlipInterval
				/// </java-name>
				[Dot42.DexImport("setFlipInterval", "(I)V", AccessFlags = 1)]
				public virtual void SetFlipInterval(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startFlipping
				/// </java-name>
				[Dot42.DexImport("startFlipping", "()V", AccessFlags = 1)]
				public virtual void StartFlipping() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopFlipping
				/// </java-name>
				[Dot42.DexImport("stopFlipping", "()V", AccessFlags = 1)]
				public virtual void StopFlipping() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showNext
				/// </java-name>
				[Dot42.DexImport("showNext", "()V", AccessFlags = 1)]
				public override void ShowNext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showPrevious
				/// </java-name>
				[Dot42.DexImport("showPrevious", "()V", AccessFlags = 1)]
				public override void ShowPrevious() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fyiWillBeAdvancedByHostKThx
				/// </java-name>
				[Dot42.DexImport("fyiWillBeAdvancedByHostKThx", "()V", AccessFlags = 1)]
				public override void FyiWillBeAdvancedByHostKThx() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AdapterViewFlipper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isFlipping
				/// </java-name>
				public virtual bool IsFlipping
				{
						[Dot42.DexImport("isFlipping", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isAutoStart
				/// </java-name>
				public virtual bool IsAutoStart
				{
						[Dot42.DexImport("isAutoStart", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAutoStart", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setAdapter
				/// </java-name>
				public override global::Android.Widget.IAdapter Adapter
				{
						[Dot42.DexImport("setAdapter", "(Landroid/widget/Adapter;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/AlphabetIndexer
		/// </java-name>
		[Dot42.DexImport("android/widget/AlphabetIndexer", AccessFlags = 33)]
		public partial class AlphabetIndexer : global::Android.Database.DataSetObserver, global::Android.Widget.ISectionIndexer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mDataCursor
				/// </java-name>
				[Dot42.DexImport("mDataCursor", "Landroid/database/Cursor;", AccessFlags = 4)]
				protected internal global::Android.Database.ICursor MDataCursor;
				/// <java-name>
				/// mColumnIndex
				/// </java-name>
				[Dot42.DexImport("mColumnIndex", "I", AccessFlags = 4)]
				protected internal int MColumnIndex;
				/// <java-name>
				/// mAlphabet
				/// </java-name>
				[Dot42.DexImport("mAlphabet", "Ljava/lang/CharSequence;", AccessFlags = 4)]
				protected internal global::Java.Lang.ICharSequence MAlphabet;
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;ILjava/lang/CharSequence;)V", AccessFlags = 1)]
				public AlphabetIndexer(global::Android.Database.ICursor cursor, int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCursor
				/// </java-name>
				[Dot42.DexImport("setCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void SetCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// compare
				/// </java-name>
				[Dot42.DexImport("compare", "(Ljava/lang/String;Ljava/lang/String;)I", AccessFlags = 4)]
				protected internal virtual int Compare(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPositionForSection
				/// </java-name>
				[Dot42.DexImport("getPositionForSection", "(I)I", AccessFlags = 1)]
				public virtual int GetPositionForSection(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getSectionForPosition
				/// </java-name>
				[Dot42.DexImport("getSectionForPosition", "(I)I", AccessFlags = 1)]
				public virtual int GetSectionForPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onChanged
				/// </java-name>
				[Dot42.DexImport("onChanged", "()V", AccessFlags = 1)]
				public override void OnChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInvalidated
				/// </java-name>
				[Dot42.DexImport("onInvalidated", "()V", AccessFlags = 1)]
				public override void OnInvalidated() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AlphabetIndexer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSections
				/// </java-name>
				public virtual object[] Sections
				{
						[Dot42.DexImport("getSections", "()[Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object[]); }
				}

		}

		/// <java-name>
		/// android/widget/AnalogClock
		/// </java-name>
		[Dot42.DexImport("android/widget/AnalogClock", AccessFlags = 33)]
		public partial class AnalogClock : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AnalogClock(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AnalogClock(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AnalogClock(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AnalogClock() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/ArrayAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ArrayAdapter", AccessFlags = 33, Signature = "<T:Ljava/lang/Object;>Landroid/widget/BaseAdapter;Landroid/widget/Filterable;")]
		public partial class ArrayAdapter<T> : global::Android.Widget.BaseAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public ArrayAdapter(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public ArrayAdapter(global::Android.Content.Context context, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;I[TT;)V")]
				public ArrayAdapter(global::Android.Content.Context context, int int32, T[] p) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;II[TT;)V")]
				public ArrayAdapter(global::Android.Content.Context context, int int32, int int321, T[] p) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILjava/util/List;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;ILjava/util/List<TT;>;)V")]
				public ArrayAdapter(global::Android.Content.Context context, int int32, global::Java.Util.IList<T> list) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;IILjava/util/List;)V", AccessFlags = 1, Signature = "(Landroid/content/Context;IILjava/util/List<TT;>;)V")]
				public ArrayAdapter(global::Android.Content.Context context, int int32, int int321, global::Java.Util.IList<T> list) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void Add(T t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<+TT;>;)V")]
				public virtual void AddAll(global::Java.Util.ICollection<T> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAll
				/// </java-name>
				[Dot42.DexImport("addAll", "([Ljava/lang/Object;)V", AccessFlags = 129, Signature = "([TT;)V")]
				public virtual void AddAll(params T[] p) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// insert
				/// </java-name>
				[Dot42.DexImport("insert", "(Ljava/lang/Object;I)V", AccessFlags = 1, Signature = "(TT;I)V")]
				public virtual void Insert(T t, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// remove
				/// </java-name>
				[Dot42.DexImport("remove", "(Ljava/lang/Object;)V", AccessFlags = 1, Signature = "(TT;)V")]
				public virtual void Remove(T t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public virtual void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sort
				/// </java-name>
				[Dot42.DexImport("sort", "(Ljava/util/Comparator;)V", AccessFlags = 1, Signature = "(Ljava/util/Comparator<-TT;>;)V")]
				public virtual void Sort(global::Java.Util.IComparator<T> comparator) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "()V", AccessFlags = 1)]
				public override void NotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNotifyOnChange
				/// </java-name>
				[Dot42.DexImport("setNotifyOnChange", "(Z)V", AccessFlags = 1)]
				public virtual void SetNotifyOnChange(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1, Signature = "(I)TT;")]
				public new virtual T GetItem(int int32) /* MethodBuilder.Create */ 
				{
						return default(T);
				}

				/// <java-name>
				/// getPosition
				/// </java-name>
				[Dot42.DexImport("getPosition", "(Ljava/lang/Object;)I", AccessFlags = 1, Signature = "(TT;)I")]
				public virtual int GetPosition(T t) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1)]
				public override long GetItemId(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setDropDownViewResource
				/// </java-name>
				[Dot42.DexImport("setDropDownViewResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDropDownViewResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetDropDownView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// createFromResource
				/// </java-name>
				[Dot42.DexImport("createFromResource", "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter;", AccessFlags = 9, Signature = "(Landroid/content/Context;II)Landroid/widget/ArrayAdapter<Ljava/lang/CharSequence" +
    ";>;")]
				public static global::Android.Widget.ArrayAdapter<global::Java.Lang.ICharSequence> CreateFromResource(global::Android.Content.Context context, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.ArrayAdapter<global::Java.Lang.ICharSequence>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ArrayAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

		}

		/// <java-name>
		/// android/widget/AutoCompleteTextView
		/// </java-name>
		[Dot42.DexImport("android/widget/AutoCompleteTextView", AccessFlags = 33)]
		public partial class AutoCompleteTextView : global::Android.Widget.EditText, global::Android.Widget.Filter.IFilterListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AutoCompleteTextView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public AutoCompleteTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public AutoCompleteTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnClickListener
				/// </java-name>
				[Dot42.DexImport("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public override void SetOnClickListener(global::Android.Views.View.IOnClickListener onClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCompletionHint
				/// </java-name>
				[Dot42.DexImport("setCompletionHint", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetCompletionHint(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDropDownBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setDropDownBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetDropDownBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDropDownBackgroundResource
				/// </java-name>
				[Dot42.DexImport("setDropDownBackgroundResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDropDownBackgroundResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAdapter
				/// </java-name>
				[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1, Signature = "<T::Landroid/widget/ListAdapter;:Landroid/widget/Filterable;>(TT;)V")]
				public virtual void SetAdapter<T>(T t) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyPreIme
				/// </java-name>
				[Dot42.DexImport("onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyPreIme(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// enoughToFilter
				/// </java-name>
				[Dot42.DexImport("enoughToFilter", "()Z", AccessFlags = 1)]
				public virtual bool EnoughToFilter() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// convertSelectionToString
				/// </java-name>
				[Dot42.DexImport("convertSelectionToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;", AccessFlags = 4)]
				protected internal virtual global::Java.Lang.ICharSequence ConvertSelectionToString(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// clearListSelection
				/// </java-name>
				[Dot42.DexImport("clearListSelection", "()V", AccessFlags = 1)]
				public virtual void ClearListSelection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performFiltering
				/// </java-name>
				[Dot42.DexImport("performFiltering", "(Ljava/lang/CharSequence;I)V", AccessFlags = 4)]
				protected internal virtual void PerformFiltering(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performCompletion
				/// </java-name>
				[Dot42.DexImport("performCompletion", "()V", AccessFlags = 1)]
				public virtual void PerformCompletion() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCommitCompletion
				/// </java-name>
				[Dot42.DexImport("onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
				public override void OnCommitCompletion(global::Android.Views.Inputmethod.CompletionInfo completionInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// replaceText
				/// </java-name>
				[Dot42.DexImport("replaceText", "(Ljava/lang/CharSequence;)V", AccessFlags = 4)]
				protected internal virtual void ReplaceText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFilterComplete
				/// </java-name>
				[Dot42.DexImport("onFilterComplete", "(I)V", AccessFlags = 1)]
				public virtual void OnFilterComplete(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisplayHint
				/// </java-name>
				[Dot42.DexImport("onDisplayHint", "(I)V", AccessFlags = 4)]
				protected internal override void OnDisplayHint(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dismissDropDown
				/// </java-name>
				[Dot42.DexImport("dismissDropDown", "()V", AccessFlags = 1)]
				public virtual void DismissDropDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFrame
				/// </java-name>
				[Dot42.DexImport("setFrame", "(IIII)Z", AccessFlags = 4)]
				protected internal override bool SetFrame(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// showDropDown
				/// </java-name>
				[Dot42.DexImport("showDropDown", "()V", AccessFlags = 1)]
				public virtual void ShowDropDown() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performValidation
				/// </java-name>
				[Dot42.DexImport("performValidation", "()V", AccessFlags = 1)]
				public virtual void PerformValidation() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AutoCompleteTextView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDropDownWidth
				/// </java-name>
				public virtual int DropDownWidth
				{
						[Dot42.DexImport("getDropDownWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownWidth", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDropDownHeight
				/// </java-name>
				public virtual int DropDownHeight
				{
						[Dot42.DexImport("getDropDownHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownHeight", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDropDownAnchor
				/// </java-name>
				public virtual int DropDownAnchor
				{
						[Dot42.DexImport("getDropDownAnchor", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownAnchor", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDropDownBackground
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable DropDownBackground
				{
						[Dot42.DexImport("getDropDownBackground", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getDropDownVerticalOffset
				/// </java-name>
				public virtual int DropDownVerticalOffset
				{
						[Dot42.DexImport("getDropDownVerticalOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownVerticalOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDropDownHorizontalOffset
				/// </java-name>
				public virtual int DropDownHorizontalOffset
				{
						[Dot42.DexImport("getDropDownHorizontalOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDropDownHorizontalOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getThreshold
				/// </java-name>
				public virtual int Threshold
				{
						[Dot42.DexImport("getThreshold", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setThreshold", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getItemClickListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<object>.IOnItemClickListener ItemClickListener
				{
						[Dot42.DexImport("getItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AdapterView<object>.IOnItemClickListener); }
				}

				/// <java-name>
				/// getItemSelectedListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<object>.IOnItemSelectedListener ItemSelectedListener
				{
						[Dot42.DexImport("getItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AdapterView<object>.IOnItemSelectedListener); }
				}

				/// <java-name>
				/// getOnItemClickListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<object>.IOnItemClickListener OnItemClickListener
				{
						[Dot42.DexImport("getOnItemClickListener", "()Landroid/widget/AdapterView$OnItemClickListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AdapterView<object>.IOnItemClickListener); }
						[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOnItemSelectedListener
				/// </java-name>
				public virtual global::Android.Widget.AdapterView<object>.IOnItemSelectedListener OnItemSelectedListener
				{
						[Dot42.DexImport("getOnItemSelectedListener", "()Landroid/widget/AdapterView$OnItemSelectedListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AdapterView<object>.IOnItemSelectedListener); }
						[Dot42.DexImport("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public virtual global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
				}

				/// <java-name>
				/// isPopupShowing
				/// </java-name>
				public virtual bool IsPopupShowing
				{
						[Dot42.DexImport("isPopupShowing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getListSelection
				/// </java-name>
				public virtual int ListSelection
				{
						[Dot42.DexImport("getListSelection", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setListSelection", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isPerformingCompletion
				/// </java-name>
				public virtual bool IsPerformingCompletion
				{
						[Dot42.DexImport("isPerformingCompletion", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getValidator
				/// </java-name>
				public virtual global::Android.Widget.AutoCompleteTextView.IValidator Validator
				{
						[Dot42.DexImport("getValidator", "()Landroid/widget/AutoCompleteTextView$Validator;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.AutoCompleteTextView.IValidator); }
						[Dot42.DexImport("setValidator", "(Landroid/widget/AutoCompleteTextView$Validator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFilter
				/// </java-name>
				protected internal virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 4)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <java-name>
				/// android/widget/AutoCompleteTextView$Validator
				/// </java-name>
				[Dot42.DexImport("android/widget/AutoCompleteTextView$Validator", AccessFlags = 1545)]
				public partial interface IValidator
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// isValid
						/// </java-name>
						[Dot42.DexImport("isValid", "(Ljava/lang/CharSequence;)Z", AccessFlags = 1025)]
						bool IsValid(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// fixText
						/// </java-name>
						[Dot42.DexImport("fixText", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
						global::Java.Lang.ICharSequence FixText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/BaseAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/BaseAdapter", AccessFlags = 1057)]
		public abstract partial class BaseAdapter : global::Android.Widget.IListAdapter, global::Android.Widget.ISpinnerAdapter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BaseAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "()V", AccessFlags = 1)]
				public virtual void NotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetInvalidated
				/// </java-name>
				[Dot42.DexImport("notifyDataSetInvalidated", "()V", AccessFlags = 1)]
				public virtual void NotifyDataSetInvalidated() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1)]
				public virtual bool AreAllItemsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "(I)Z", AccessFlags = 1)]
				public virtual bool IsEnabled(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetDropDownView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// getItemViewType
				/// </java-name>
				[Dot42.DexImport("getItemViewType", "(I)I", AccessFlags = 1)]
				public virtual int GetItemViewType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/widget/Adapter", "getItem", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetItem(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("android/widget/Adapter", "getItemId", "(I)J", AccessFlags = 1025)]
				public virtual long GetItemId(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("android/widget/Adapter", "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				public virtual global::Android.Views.View GetView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public virtual bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getViewTypeCount
				/// </java-name>
				public virtual int ViewTypeCount
				{
						[Dot42.DexImport("getViewTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				public virtual int Count
				{
						[Dot42.DexImport("android/widget/Adapter", "getCount", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/widget/BaseExpandableListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/BaseExpandableListAdapter", AccessFlags = 1057)]
		public abstract partial class BaseExpandableListAdapter : global::Android.Widget.IExpandableListAdapter, global::Android.Widget.IHeterogeneousExpandableList
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public BaseExpandableListAdapter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetInvalidated
				/// </java-name>
				[Dot42.DexImport("notifyDataSetInvalidated", "()V", AccessFlags = 1)]
				public virtual void NotifyDataSetInvalidated() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "()V", AccessFlags = 1)]
				public virtual void NotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1)]
				public virtual bool AreAllItemsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGroupCollapsed
				/// </java-name>
				[Dot42.DexImport("onGroupCollapsed", "(I)V", AccessFlags = 1)]
				public virtual void OnGroupCollapsed(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGroupExpanded
				/// </java-name>
				[Dot42.DexImport("onGroupExpanded", "(I)V", AccessFlags = 1)]
				public virtual void OnGroupExpanded(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCombinedChildId
				/// </java-name>
				[Dot42.DexImport("getCombinedChildId", "(JJ)J", AccessFlags = 1)]
				public virtual long GetCombinedChildId(long int64, long int641) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getCombinedGroupId
				/// </java-name>
				[Dot42.DexImport("getCombinedGroupId", "(J)J", AccessFlags = 1)]
				public virtual long GetCombinedGroupId(long int64) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getChildType
				/// </java-name>
				[Dot42.DexImport("getChildType", "(II)I", AccessFlags = 1)]
				public virtual int GetChildType(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGroupType
				/// </java-name>
				[Dot42.DexImport("getGroupType", "(I)I", AccessFlags = 1)]
				public virtual int GetGroupType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getChildrenCount", "(I)I", AccessFlags = 1025)]
				public virtual int GetChildrenCount(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getGroup", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetGroup(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getChild", "(II)Ljava/lang/Object;", AccessFlags = 1025)]
				public virtual object GetChild(int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getGroupId", "(I)J", AccessFlags = 1025)]
				public virtual long GetGroupId(int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getChildId", "(II)J", AccessFlags = 1025)]
				public virtual long GetChildId(int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(long);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				public virtual global::Android.Views.View GetGroupView(int int32, bool boolean, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Views.View);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				public virtual global::Android.Views.View GetChildView(int int32, int int321, bool boolean, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(global::Android.Views.View);
				}

				[Dot42.DexImport("android/widget/ExpandableListAdapter", "isChildSelectable", "(II)Z", AccessFlags = 1025)]
				public virtual bool IsChildSelectable(int int32, int int321) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getChildTypeCount
				/// </java-name>
				public virtual int ChildTypeCount
				{
						[Dot42.DexImport("getChildTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getGroupTypeCount
				/// </java-name>
				public virtual int GroupTypeCount
				{
						[Dot42.DexImport("getGroupTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				public virtual int GroupCount
				{
						[Dot42.DexImport("android/widget/ExpandableListAdapter", "getGroupCount", "()I", AccessFlags = 1025)]
						get{ return default(int); }
				}

				public virtual bool HasStableIds
				{
						[Dot42.DexImport("android/widget/ExpandableListAdapter", "hasStableIds", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/widget/Button
		/// </java-name>
		[Dot42.DexImport("android/widget/Button", AccessFlags = 33)]
		public partial class Button : global::Android.Widget.TextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Button(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Button(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Button(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Button() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/CalendarView
		/// </java-name>
		[Dot42.DexImport("android/widget/CalendarView", AccessFlags = 33)]
		public partial class CalendarView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CalendarView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CalendarView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CalendarView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 4)]
				protected internal override void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDateChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnDateChangeListener", "(Landroid/widget/CalendarView$OnDateChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnDateChangeListener(global::Android.Widget.CalendarView.IOnDateChangeListener onDateChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDate
				/// </java-name>
				[Dot42.DexImport("setDate", "(JZZ)V", AccessFlags = 1)]
				public virtual void SetDate(long int64, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CalendarView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMinDate
				/// </java-name>
				public virtual long MinDate
				{
						[Dot42.DexImport("getMinDate", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setMinDate", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMaxDate
				/// </java-name>
				public virtual long MaxDate
				{
						[Dot42.DexImport("getMaxDate", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setMaxDate", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getShowWeekNumber
				/// </java-name>
				public virtual bool IsShowWeekNumber
				{
						[Dot42.DexImport("getShowWeekNumber", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setShowWeekNumber", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFirstDayOfWeek
				/// </java-name>
				public virtual int FirstDayOfWeek
				{
						[Dot42.DexImport("getFirstDayOfWeek", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setFirstDayOfWeek", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDate
				/// </java-name>
				public virtual long Date
				{
						[Dot42.DexImport("getDate", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setDate", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/CalendarView$OnDateChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/CalendarView$OnDateChangeListener", AccessFlags = 1545)]
				public partial interface IOnDateChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSelectedDayChange
						/// </java-name>
						[Dot42.DexImport("onSelectedDayChange", "(Landroid/widget/CalendarView;III)V", AccessFlags = 1025)]
						void OnSelectedDayChange(global::Android.Widget.CalendarView calendarView, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/CheckBox
		/// </java-name>
		[Dot42.DexImport("android/widget/CheckBox", AccessFlags = 33)]
		public partial class CheckBox : global::Android.Widget.CompoundButton
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CheckBox(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CheckBox(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CheckBox(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CheckBox() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/CheckedTextView
		/// </java-name>
		[Dot42.DexImport("android/widget/CheckedTextView", AccessFlags = 33)]
		public partial class CheckedTextView : global::Android.Widget.TextView, global::Android.Widget.ICheckable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CheckedTextView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CheckedTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CheckedTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1)]
				public virtual void Toggle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCheckMarkDrawable
				/// </java-name>
				[Dot42.DexImport("setCheckMarkDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetCheckMarkDrawable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCheckMarkDrawable
				/// </java-name>
				[Dot42.DexImport("setCheckMarkDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetCheckMarkDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public override void SetPadding(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CheckedTextView() /* TypeBuilder.AddDefaultConstructor */ 
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

		}

		/// <java-name>
		/// android/widget/Chronometer
		/// </java-name>
		[Dot42.DexImport("android/widget/Chronometer", AccessFlags = 33)]
		public partial class Chronometer : global::Android.Widget.TextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Chronometer(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Chronometer(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Chronometer(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stop
				/// </java-name>
				[Dot42.DexImport("stop", "()V", AccessFlags = 1)]
				public virtual void Stop() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal override void OnWindowVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Chronometer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBase
				/// </java-name>
				public virtual long Base
				{
						[Dot42.DexImport("getBase", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setBase", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFormat
				/// </java-name>
				public virtual string Format
				{
						[Dot42.DexImport("getFormat", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setFormat", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOnChronometerTickListener
				/// </java-name>
				public virtual global::Android.Widget.Chronometer.IOnChronometerTickListener OnChronometerTickListener
				{
						[Dot42.DexImport("getOnChronometerTickListener", "()Landroid/widget/Chronometer$OnChronometerTickListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Chronometer.IOnChronometerTickListener); }
						[Dot42.DexImport("setOnChronometerTickListener", "(Landroid/widget/Chronometer$OnChronometerTickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/Chronometer$OnChronometerTickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/Chronometer$OnChronometerTickListener", AccessFlags = 1545)]
				public partial interface IOnChronometerTickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onChronometerTick
						/// </java-name>
						[Dot42.DexImport("onChronometerTick", "(Landroid/widget/Chronometer;)V", AccessFlags = 1025)]
						void OnChronometerTick(global::Android.Widget.Chronometer chronometer) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/CompoundButton
		/// </java-name>
		[Dot42.DexImport("android/widget/CompoundButton", AccessFlags = 1057)]
		public abstract partial class CompoundButton : global::Android.Widget.Button, global::Android.Widget.ICheckable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public CompoundButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public CompoundButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public CompoundButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1)]
				public virtual void Toggle() /* MethodBuilder.Create */ 
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
				/// setOnCheckedChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnCheckedChangeListener", "(Landroid/widget/CompoundButton$OnCheckedChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnCheckedChangeListener(global::Android.Widget.CompoundButton.IOnCheckedChangeListener onCheckedChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButtonDrawable
				/// </java-name>
				[Dot42.DexImport("setButtonDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetButtonDrawable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setButtonDrawable
				/// </java-name>
				[Dot42.DexImport("setButtonDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetButtonDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public override void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CompoundButton() /* TypeBuilder.AddDefaultConstructor */ 
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
				/// android/widget/CompoundButton$OnCheckedChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/CompoundButton$OnCheckedChangeListener", AccessFlags = 1545)]
				public partial interface IOnCheckedChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCheckedChanged
						/// </java-name>
						[Dot42.DexImport("onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V", AccessFlags = 1025)]
						void OnCheckedChanged(global::Android.Widget.CompoundButton compoundButton, bool boolean) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/CursorAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/CursorAdapter", AccessFlags = 1057)]
		public abstract partial class CursorAdapter : global::Android.Widget.BaseAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FLAG_AUTO_REQUERY
				/// </java-name>
				[Dot42.DexImport("FLAG_AUTO_REQUERY", "I", AccessFlags = 25)]
				public const int FLAG_AUTO_REQUERY = 1;
				/// <java-name>
				/// FLAG_REGISTER_CONTENT_OBSERVER
				/// </java-name>
				[Dot42.DexImport("FLAG_REGISTER_CONTENT_OBSERVER", "I", AccessFlags = 25)]
				public const int FLAG_REGISTER_CONTENT_OBSERVER = 2;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;)V", AccessFlags = 1)]
				public CursorAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 1)]
				public CursorAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;I)V", AccessFlags = 1)]
				public CursorAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 4)]
				protected internal virtual void Init(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetItem(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1)]
				public override long GetItemId(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetDropDownView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newView
				/// </java-name>
				[Dot42.DexImport("newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landr" +
    "oid/view/View;", AccessFlags = 1025)]
				public abstract global::Android.Views.View NewView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// newDropDownView
				/// </java-name>
				[Dot42.DexImport("newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landr" +
    "oid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View NewDropDownView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// bindView
				/// </java-name>
				[Dot42.DexImport("bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", AccessFlags = 1025)]
				public abstract void BindView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// changeCursor
				/// </java-name>
				[Dot42.DexImport("changeCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void ChangeCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// swapCursor
				/// </java-name>
				[Dot42.DexImport("swapCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor SwapCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// convertToString
				/// </java-name>
				[Dot42.DexImport("convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence ConvertToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// runQueryOnBackgroundThread
				/// </java-name>
				[Dot42.DexImport("runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor RunQueryOnBackgroundThread(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 4)]
				protected internal virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CursorAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCursor
				/// </java-name>
				public virtual global::Android.Database.ICursor Cursor
				{
						[Dot42.DexImport("getCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
						get{ return default(global::Android.Database.ICursor); }
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public override bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <java-name>
				/// getFilterQueryProvider
				/// </java-name>
				public virtual global::Android.Widget.IFilterQueryProvider FilterQueryProvider
				{
						[Dot42.DexImport("getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IFilterQueryProvider); }
						[Dot42.DexImport("setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/CursorTreeAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/CursorTreeAdapter", AccessFlags = 1057)]
		public abstract partial class CursorTreeAdapter : global::Android.Widget.BaseExpandableListAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;Landroid/content/Context;)V", AccessFlags = 1)]
				public CursorTreeAdapter(global::Android.Database.ICursor cursor, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/database/Cursor;Landroid/content/Context;Z)V", AccessFlags = 1)]
				public CursorTreeAdapter(global::Android.Database.ICursor cursor, global::Android.Content.Context context, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildrenCursor
				/// </java-name>
				[Dot42.DexImport("getChildrenCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", AccessFlags = 1028)]
				protected internal abstract global::Android.Database.ICursor GetChildrenCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setGroupCursor
				/// </java-name>
				[Dot42.DexImport("setGroupCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void SetGroupCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChildrenCursor
				/// </java-name>
				[Dot42.DexImport("setChildrenCursor", "(ILandroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void SetChildrenCursor(int int32, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(II)Landroid/database/Cursor;", AccessFlags = 1)]
				public new virtual global::Android.Database.ICursor GetChild(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// getChildId
				/// </java-name>
				[Dot42.DexImport("getChildId", "(II)J", AccessFlags = 1)]
				public override long GetChildId(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getChildrenCount
				/// </java-name>
				[Dot42.DexImport("getChildrenCount", "(I)I", AccessFlags = 1)]
				public override int GetChildrenCount(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGroup
				/// </java-name>
				[Dot42.DexImport("getGroup", "(I)Landroid/database/Cursor;", AccessFlags = 1)]
				public new virtual global::Android.Database.ICursor GetGroup(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// getGroupId
				/// </java-name>
				[Dot42.DexImport("getGroupId", "(I)J", AccessFlags = 1)]
				public override long GetGroupId(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getGroupView
				/// </java-name>
				[Dot42.DexImport("getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetGroupView(int int32, bool boolean, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newGroupView
				/// </java-name>
				[Dot42.DexImport("newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Land" +
    "roid/view/View;", AccessFlags = 1028)]
				protected internal abstract global::Android.Views.View NewGroupView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// bindGroupView
				/// </java-name>
				[Dot42.DexImport("bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 1028)]
				protected internal abstract void BindGroupView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChildView
				/// </java-name>
				[Dot42.DexImport("getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetChildView(int int32, int int321, bool boolean, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newChildView
				/// </java-name>
				[Dot42.DexImport("newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Land" +
    "roid/view/View;", AccessFlags = 1028)]
				protected internal abstract global::Android.Views.View NewChildView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// bindChildView
				/// </java-name>
				[Dot42.DexImport("bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 1028)]
				protected internal abstract void BindChildView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isChildSelectable
				/// </java-name>
				[Dot42.DexImport("isChildSelectable", "(II)Z", AccessFlags = 1)]
				public override bool IsChildSelectable(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "()V", AccessFlags = 1)]
				public override void NotifyDataSetChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetChanged
				/// </java-name>
				[Dot42.DexImport("notifyDataSetChanged", "(Z)V", AccessFlags = 1)]
				public virtual void NotifyDataSetChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyDataSetInvalidated
				/// </java-name>
				[Dot42.DexImport("notifyDataSetInvalidated", "()V", AccessFlags = 1)]
				public override void NotifyDataSetInvalidated() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGroupCollapsed
				/// </java-name>
				[Dot42.DexImport("onGroupCollapsed", "(I)V", AccessFlags = 1)]
				public override void OnGroupCollapsed(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// convertToString
				/// </java-name>
				[Dot42.DexImport("convertToString", "(Landroid/database/Cursor;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string ConvertToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// runQueryOnBackgroundThread
				/// </java-name>
				[Dot42.DexImport("runQueryOnBackgroundThread", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", AccessFlags = 1)]
				public virtual global::Android.Database.ICursor RunQueryOnBackgroundThread(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// changeCursor
				/// </java-name>
				[Dot42.DexImport("changeCursor", "(Landroid/database/Cursor;)V", AccessFlags = 1)]
				public virtual void ChangeCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CursorTreeAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getGroupCount
				/// </java-name>
				public override int GroupCount
				{
						[Dot42.DexImport("getGroupCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public override bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <java-name>
				/// getFilterQueryProvider
				/// </java-name>
				public virtual global::Android.Widget.IFilterQueryProvider FilterQueryProvider
				{
						[Dot42.DexImport("getFilterQueryProvider", "()Landroid/widget/FilterQueryProvider;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IFilterQueryProvider); }
						[Dot42.DexImport("setFilterQueryProvider", "(Landroid/widget/FilterQueryProvider;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCursor
				/// </java-name>
				public virtual global::Android.Database.ICursor Cursor
				{
						[Dot42.DexImport("getCursor", "()Landroid/database/Cursor;", AccessFlags = 1)]
						get{ return default(global::Android.Database.ICursor); }
				}

		}

		/// <java-name>
		/// android/widget/DatePicker
		/// </java-name>
		[Dot42.DexImport("android/widget/DatePicker", AccessFlags = 33)]
		public partial class DatePicker : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DatePicker(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DatePicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public DatePicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 4)]
				protected internal override void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateDate
				/// </java-name>
				[Dot42.DexImport("updateDate", "(III)V", AccessFlags = 1)]
				public virtual void UpdateDate(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchRestoreInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
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
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(IIILandroid/widget/DatePicker$OnDateChangedListener;)V", AccessFlags = 1)]
				public virtual void Init(int int32, int int321, int int322, global::Android.Widget.DatePicker.IOnDateChangedListener onDateChangedListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DatePicker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMinDate
				/// </java-name>
				public virtual long MinDate
				{
						[Dot42.DexImport("getMinDate", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setMinDate", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMaxDate
				/// </java-name>
				public virtual long MaxDate
				{
						[Dot42.DexImport("getMaxDate", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setMaxDate", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCalendarViewShown
				/// </java-name>
				public virtual bool IsCalendarViewShown
				{
						[Dot42.DexImport("getCalendarViewShown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setCalendarViewShown", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCalendarView
				/// </java-name>
				public virtual global::Android.Widget.CalendarView CalendarView
				{
						[Dot42.DexImport("getCalendarView", "()Landroid/widget/CalendarView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.CalendarView); }
				}

				/// <java-name>
				/// getSpinnersShown
				/// </java-name>
				public virtual bool IsSpinnersShown
				{
						[Dot42.DexImport("getSpinnersShown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSpinnersShown", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getYear
				/// </java-name>
				public virtual int Year
				{
						[Dot42.DexImport("getYear", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMonth
				/// </java-name>
				public virtual int Month
				{
						[Dot42.DexImport("getMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDayOfMonth
				/// </java-name>
				public virtual int DayOfMonth
				{
						[Dot42.DexImport("getDayOfMonth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/widget/DatePicker$OnDateChangedListener
				/// </java-name>
				[Dot42.DexImport("android/widget/DatePicker$OnDateChangedListener", AccessFlags = 1545)]
				public partial interface IOnDateChangedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDateChanged
						/// </java-name>
						[Dot42.DexImport("onDateChanged", "(Landroid/widget/DatePicker;III)V", AccessFlags = 1025)]
						void OnDateChanged(global::Android.Widget.DatePicker datePicker, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/DialerFilter
		/// </java-name>
		[Dot42.DexImport("android/widget/DialerFilter", AccessFlags = 33)]
		public partial class DialerFilter : global::Android.Widget.RelativeLayout
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DIGITS_AND_LETTERS
				/// </java-name>
				[Dot42.DexImport("DIGITS_AND_LETTERS", "I", AccessFlags = 25)]
				public const int DIGITS_AND_LETTERS = 1;
				/// <java-name>
				/// DIGITS_AND_LETTERS_NO_DIGITS
				/// </java-name>
				[Dot42.DexImport("DIGITS_AND_LETTERS_NO_DIGITS", "I", AccessFlags = 25)]
				public const int DIGITS_AND_LETTERS_NO_DIGITS = 2;
				/// <java-name>
				/// DIGITS_AND_LETTERS_NO_LETTERS
				/// </java-name>
				[Dot42.DexImport("DIGITS_AND_LETTERS_NO_LETTERS", "I", AccessFlags = 25)]
				public const int DIGITS_AND_LETTERS_NO_LETTERS = 3;
				/// <java-name>
				/// DIGITS_ONLY
				/// </java-name>
				[Dot42.DexImport("DIGITS_ONLY", "I", AccessFlags = 25)]
				public const int DIGITS_ONLY = 4;
				/// <java-name>
				/// LETTERS_ONLY
				/// </java-name>
				[Dot42.DexImport("LETTERS_ONLY", "I", AccessFlags = 25)]
				public const int LETTERS_ONLY = 5;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DialerFilter(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DialerFilter(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void Append(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearText
				/// </java-name>
				[Dot42.DexImport("clearText", "()V", AccessFlags = 1)]
				public virtual void ClearText() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLettersWatcher
				/// </java-name>
				[Dot42.DexImport("setLettersWatcher", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void SetLettersWatcher(global::Android.Text.ITextWatcher textWatcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDigitsWatcher
				/// </java-name>
				[Dot42.DexImport("setDigitsWatcher", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void SetDigitsWatcher(global::Android.Text.ITextWatcher textWatcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFilterWatcher
				/// </java-name>
				[Dot42.DexImport("setFilterWatcher", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void SetFilterWatcher(global::Android.Text.ITextWatcher textWatcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeFilterWatcher
				/// </java-name>
				[Dot42.DexImport("removeFilterWatcher", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void RemoveFilterWatcher(global::Android.Text.ITextWatcher textWatcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onModeChange
				/// </java-name>
				[Dot42.DexImport("onModeChange", "(II)V", AccessFlags = 4)]
				protected internal virtual void OnModeChange(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DialerFilter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isQwertyKeyboard
				/// </java-name>
				public virtual bool IsQwertyKeyboard
				{
						[Dot42.DexImport("isQwertyKeyboard", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getMode
				/// </java-name>
				public virtual int Mode
				{
						[Dot42.DexImport("getMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLetters
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Letters
				{
						[Dot42.DexImport("getLetters", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <java-name>
				/// getDigits
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Digits
				{
						[Dot42.DexImport("getDigits", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <java-name>
				/// getFilterText
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence FilterText
				{
						[Dot42.DexImport("getFilterText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

		}

		/// <java-name>
		/// android/widget/DigitalClock
		/// </java-name>
		[Dot42.DexImport("android/widget/DigitalClock", AccessFlags = 33)]
		public partial class DigitalClock : global::Android.Widget.TextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public DigitalClock(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public DigitalClock(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal DigitalClock() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/EdgeEffect
		/// </java-name>
		[Dot42.DexImport("android/widget/EdgeEffect", AccessFlags = 33)]
		public partial class EdgeEffect
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public EdgeEffect(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSize
				/// </java-name>
				[Dot42.DexImport("setSize", "(II)V", AccessFlags = 1)]
				public virtual void SetSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1)]
				public virtual void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPull
				/// </java-name>
				[Dot42.DexImport("onPull", "(F)V", AccessFlags = 1)]
				public virtual void OnPull(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRelease
				/// </java-name>
				[Dot42.DexImport("onRelease", "()V", AccessFlags = 1)]
				public virtual void OnRelease() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAbsorb
				/// </java-name>
				[Dot42.DexImport("onAbsorb", "(I)V", AccessFlags = 1)]
				public virtual void OnAbsorb(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)Z", AccessFlags = 1)]
				public virtual bool Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EdgeEffect() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isFinished
				/// </java-name>
				public virtual bool IsFinished
				{
						[Dot42.DexImport("isFinished", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/widget/EditText
		/// </java-name>
		[Dot42.DexImport("android/widget/EditText", AccessFlags = 33)]
		public partial class EditText : global::Android.Widget.TextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public EditText(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public EditText(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public EditText(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Landroid/text/Editable;", AccessFlags = 1)]
				public new virtual global::Android.Text.IEditable GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Text.IEditable);
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", AccessFlags = 1)]
				public override void SetText(global::Java.Lang.ICharSequence charSequence, global::Android.Widget.TextView.BufferType bufferType) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(II)V", AccessFlags = 1)]
				public virtual void SetSelection(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public virtual void SetSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// selectAll
				/// </java-name>
				[Dot42.DexImport("selectAll", "()V", AccessFlags = 1)]
				public virtual void SelectAll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// extendSelection
				/// </java-name>
				[Dot42.DexImport("extendSelection", "(I)V", AccessFlags = 1)]
				public virtual void ExtendSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal EditText() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultEditable
				/// </java-name>
				protected internal override bool IsDefaultEditable
				{
						[Dot42.DexImport("getDefaultEditable", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDefaultMovementMethod
				/// </java-name>
				protected internal override global::Android.Text.Method.IMovementMethod DefaultMovementMethod
				{
						[Dot42.DexImport("getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;", AccessFlags = 4)]
						get{ return default(global::Android.Text.Method.IMovementMethod); }
				}

				/// <java-name>
				/// setEllipsize
				/// </java-name>
				public override global::Android.Text.TextUtils.TruncateAt Ellipsize
				{
						[Dot42.DexImport("setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/ExpandableListView
		/// </java-name>
		[Dot42.DexImport("android/widget/ExpandableListView", AccessFlags = 33)]
		public partial class ExpandableListView : global::Android.Widget.ListView
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// PACKED_POSITION_TYPE_GROUP
				/// </java-name>
				[Dot42.DexImport("PACKED_POSITION_TYPE_GROUP", "I", AccessFlags = 25)]
				public const int PACKED_POSITION_TYPE_GROUP = 0;
				/// <java-name>
				/// PACKED_POSITION_TYPE_CHILD
				/// </java-name>
				[Dot42.DexImport("PACKED_POSITION_TYPE_CHILD", "I", AccessFlags = 25)]
				public const int PACKED_POSITION_TYPE_CHILD = 1;
				/// <java-name>
				/// PACKED_POSITION_TYPE_NULL
				/// </java-name>
				[Dot42.DexImport("PACKED_POSITION_TYPE_NULL", "I", AccessFlags = 25)]
				public const int PACKED_POSITION_TYPE_NULL = 2;
				/// <java-name>
				/// PACKED_POSITION_VALUE_NULL
				/// </java-name>
				[Dot42.DexImport("PACKED_POSITION_VALUE_NULL", "J", AccessFlags = 25)]
				public const long PACKED_POSITION_VALUE_NULL = 4294967295;
				/// <java-name>
				/// CHILD_INDICATOR_INHERIT
				/// </java-name>
				[Dot42.DexImport("CHILD_INDICATOR_INHERIT", "I", AccessFlags = 25)]
				public const int CHILD_INDICATOR_INHERIT = -1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ExpandableListView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ExpandableListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ExpandableListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChildDivider
				/// </java-name>
				[Dot42.DexImport("setChildDivider", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetChildDivider(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAdapter
				/// </java-name>
				[Dot42.DexImport("setAdapter", "(Landroid/widget/ExpandableListAdapter;)V", AccessFlags = 1)]
				public virtual void SetAdapter(global::Android.Widget.IExpandableListAdapter expandableListAdapter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performItemClick
				/// </java-name>
				[Dot42.DexImport("performItemClick", "(Landroid/view/View;IJ)Z", AccessFlags = 1)]
				public override bool PerformItemClick(global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// expandGroup
				/// </java-name>
				[Dot42.DexImport("expandGroup", "(I)Z", AccessFlags = 1)]
				public virtual bool ExpandGroup(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// expandGroup
				/// </java-name>
				[Dot42.DexImport("expandGroup", "(IZ)Z", AccessFlags = 1)]
				public virtual bool ExpandGroup(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// collapseGroup
				/// </java-name>
				[Dot42.DexImport("collapseGroup", "(I)Z", AccessFlags = 1)]
				public virtual bool CollapseGroup(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOnGroupCollapseListener
				/// </java-name>
				[Dot42.DexImport("setOnGroupCollapseListener", "(Landroid/widget/ExpandableListView$OnGroupCollapseListener;)V", AccessFlags = 1)]
				public virtual void SetOnGroupCollapseListener(global::Android.Widget.ExpandableListView.IOnGroupCollapseListener onGroupCollapseListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnGroupExpandListener
				/// </java-name>
				[Dot42.DexImport("setOnGroupExpandListener", "(Landroid/widget/ExpandableListView$OnGroupExpandListener;)V", AccessFlags = 1)]
				public virtual void SetOnGroupExpandListener(global::Android.Widget.ExpandableListView.IOnGroupExpandListener onGroupExpandListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnGroupClickListener
				/// </java-name>
				[Dot42.DexImport("setOnGroupClickListener", "(Landroid/widget/ExpandableListView$OnGroupClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnGroupClickListener(global::Android.Widget.ExpandableListView.IOnGroupClickListener onGroupClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnChildClickListener
				/// </java-name>
				[Dot42.DexImport("setOnChildClickListener", "(Landroid/widget/ExpandableListView$OnChildClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnChildClickListener(global::Android.Widget.ExpandableListView.IOnChildClickListener onChildClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExpandableListPosition
				/// </java-name>
				[Dot42.DexImport("getExpandableListPosition", "(I)J", AccessFlags = 1)]
				public virtual long GetExpandableListPosition(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getFlatListPosition
				/// </java-name>
				[Dot42.DexImport("getFlatListPosition", "(J)I", AccessFlags = 1)]
				public virtual int GetFlatListPosition(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setSelectedGroup
				/// </java-name>
				[Dot42.DexImport("setSelectedGroup", "(I)V", AccessFlags = 1)]
				public virtual void SetSelectedGroup(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelectedChild
				/// </java-name>
				[Dot42.DexImport("setSelectedChild", "(IIZ)Z", AccessFlags = 1)]
				public virtual bool SetSelectedChild(int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isGroupExpanded
				/// </java-name>
				[Dot42.DexImport("isGroupExpanded", "(I)Z", AccessFlags = 1)]
				public virtual bool IsGroupExpanded(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getPackedPositionType
				/// </java-name>
				[Dot42.DexImport("getPackedPositionType", "(J)I", AccessFlags = 9)]
				public static int GetPackedPositionType(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPackedPositionGroup
				/// </java-name>
				[Dot42.DexImport("getPackedPositionGroup", "(J)I", AccessFlags = 9)]
				public static int GetPackedPositionGroup(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPackedPositionChild
				/// </java-name>
				[Dot42.DexImport("getPackedPositionChild", "(J)I", AccessFlags = 9)]
				public static int GetPackedPositionChild(long int64) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getPackedPositionForChild
				/// </java-name>
				[Dot42.DexImport("getPackedPositionForChild", "(II)J", AccessFlags = 9)]
				public static long GetPackedPositionForChild(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getPackedPositionForGroup
				/// </java-name>
				[Dot42.DexImport("getPackedPositionForGroup", "(I)J", AccessFlags = 9)]
				public static long GetPackedPositionForGroup(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// setChildIndicator
				/// </java-name>
				[Dot42.DexImport("setChildIndicator", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetChildIndicator(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChildIndicatorBounds
				/// </java-name>
				[Dot42.DexImport("setChildIndicatorBounds", "(II)V", AccessFlags = 1)]
				public virtual void SetChildIndicatorBounds(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGroupIndicator
				/// </java-name>
				[Dot42.DexImport("setGroupIndicator", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetGroupIndicator(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIndicatorBounds
				/// </java-name>
				[Dot42.DexImport("setIndicatorBounds", "(II)V", AccessFlags = 1)]
				public virtual void SetIndicatorBounds(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public override global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public override void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ExpandableListView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getExpandableListAdapter
				/// </java-name>
				public virtual global::Android.Widget.IExpandableListAdapter ExpandableListAdapter
				{
						[Dot42.DexImport("getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IExpandableListAdapter); }
				}

				/// <java-name>
				/// getSelectedPosition
				/// </java-name>
				public virtual long SelectedPosition
				{
						[Dot42.DexImport("getSelectedPosition", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getSelectedId
				/// </java-name>
				public virtual long SelectedId
				{
						[Dot42.DexImport("getSelectedId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// setOnItemClickListener
				/// </java-name>
				public override global::Android.Widget.AdapterView<global::Android.Widget.IListAdapter>.IOnItemClickListener OnItemClickListener
				{
						[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/ExpandableListView$ExpandableListContextMenuInfo
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$ExpandableListContextMenuInfo", AccessFlags = 9)]
				public partial class ExpandableListContextMenuInfo : global::Android.Views.IContextMenu_IContextMenuInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// targetView
						/// </java-name>
						[Dot42.DexImport("targetView", "Landroid/view/View;", AccessFlags = 1)]
						public global::Android.Views.View TargetView;
						/// <java-name>
						/// packedPosition
						/// </java-name>
						[Dot42.DexImport("packedPosition", "J", AccessFlags = 1)]
						public long PackedPosition;
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "J", AccessFlags = 1)]
						public long Id;
						[Dot42.DexImport("<init>", "(Landroid/view/View;JJ)V", AccessFlags = 1)]
						public ExpandableListContextMenuInfo(global::Android.Views.View view, long int64, long int641) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ExpandableListContextMenuInfo() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/widget/ExpandableListView$OnChildClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$OnChildClickListener", AccessFlags = 1545)]
				public partial interface IOnChildClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onChildClick
						/// </java-name>
						[Dot42.DexImport("onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z", AccessFlags = 1025)]
						bool OnChildClick(global::Android.Widget.ExpandableListView expandableListView, global::Android.Views.View view, int int32, int int321, long int64) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/ExpandableListView$OnGroupClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$OnGroupClickListener", AccessFlags = 1545)]
				public partial interface IOnGroupClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGroupClick
						/// </java-name>
						[Dot42.DexImport("onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z", AccessFlags = 1025)]
						bool OnGroupClick(global::Android.Widget.ExpandableListView expandableListView, global::Android.Views.View view, int int32, long int64) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/ExpandableListView$OnGroupExpandListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$OnGroupExpandListener", AccessFlags = 1545)]
				public partial interface IOnGroupExpandListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGroupExpand
						/// </java-name>
						[Dot42.DexImport("onGroupExpand", "(I)V", AccessFlags = 1025)]
						void OnGroupExpand(int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/ExpandableListView$OnGroupCollapseListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ExpandableListView$OnGroupCollapseListener", AccessFlags = 1545)]
				public partial interface IOnGroupCollapseListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGroupCollapse
						/// </java-name>
						[Dot42.DexImport("onGroupCollapse", "(I)V", AccessFlags = 1025)]
						void OnGroupCollapse(int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/Filter
		/// </java-name>
		[Dot42.DexImport("android/widget/Filter", AccessFlags = 1057)]
		public abstract partial class Filter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Filter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
				public void JavaFilter(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// filter
				/// </java-name>
				[Dot42.DexImport("filter", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterListener;)V", AccessFlags = 17)]
				public void JavaFilter(global::Java.Lang.ICharSequence charSequence, global::Android.Widget.Filter.IFilterListener filterListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performFiltering
				/// </java-name>
				[Dot42.DexImport("performFiltering", "(Ljava/lang/CharSequence;)Landroid/widget/Filter$FilterResults;", AccessFlags = 1028)]
				protected internal abstract global::Android.Widget.Filter.FilterResults PerformFiltering(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// publishResults
				/// </java-name>
				[Dot42.DexImport("publishResults", "(Ljava/lang/CharSequence;Landroid/widget/Filter$FilterResults;)V", AccessFlags = 1028)]
				protected internal abstract void PublishResults(global::Java.Lang.ICharSequence charSequence, global::Android.Widget.Filter.FilterResults filterResults) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// convertResultToString
				/// </java-name>
				[Dot42.DexImport("convertResultToString", "(Ljava/lang/Object;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence ConvertResultToString(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// android/widget/Filter$FilterListener
				/// </java-name>
				[Dot42.DexImport("android/widget/Filter$FilterListener", AccessFlags = 1545)]
				public partial interface IFilterListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onFilterComplete
						/// </java-name>
						[Dot42.DexImport("onFilterComplete", "(I)V", AccessFlags = 1025)]
						void OnFilterComplete(int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/Filter$FilterResults
				/// </java-name>
				[Dot42.DexImport("android/widget/Filter$FilterResults", AccessFlags = 12)]
				public partial class FilterResults
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "Ljava/lang/Object;", AccessFlags = 1)]
						public object Values;
						/// <java-name>
						/// count
						/// </java-name>
						[Dot42.DexImport("count", "I", AccessFlags = 1)]
						public int Count;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public FilterResults() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/FrameLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/FrameLayout", AccessFlags = 33)]
		public partial class FrameLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public FrameLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public FrameLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public FrameLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setForegroundGravity
				/// </java-name>
				[Dot42.DexImport("setForegroundGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetForegroundGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;", AccessFlags = 4)]
				protected internal new virtual global::Android.Widget.FrameLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.FrameLayout.LayoutParams);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// gatherTransparentRegion
				/// </java-name>
				[Dot42.DexImport("gatherTransparentRegion", "(Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public override bool GatherTransparentRegion(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.FrameLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.FrameLayout.LayoutParams);
				}

				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public override bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal FrameLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getForeground
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Foreground
				{
						[Dot42.DexImport("getForeground", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setForeground", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getConsiderGoneChildrenWhenMeasuring
				/// </java-name>
				public virtual bool IsConsiderGoneChildrenWhenMeasuring
				{
						[Dot42.DexImport("getConsiderGoneChildrenWhenMeasuring", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getMeasureAllChildren
				/// </java-name>
				public virtual bool IsMeasureAllChildren
				{
						[Dot42.DexImport("getMeasureAllChildren", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setMeasureAllChildren", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/FrameLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/FrameLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// gravity
						/// </java-name>
						[Dot42.DexImport("gravity", "I", AccessFlags = 1)]
						public int Gravity;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, int int322) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/Gallery
		/// </java-name>
		[Dot42.DexImport("android/widget/Gallery", AccessFlags = 33)]
		public partial class Gallery : global::Android.Widget.AbsSpinner, global::Android.Views.GestureDetector.IOnGestureListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Gallery(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Gallery(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Gallery(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCallbackDuringFling
				/// </java-name>
				[Dot42.DexImport("setCallbackDuringFling", "(Z)V", AccessFlags = 1)]
				public virtual void SetCallbackDuringFling(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAnimationDuration
				/// </java-name>
				[Dot42.DexImport("setAnimationDuration", "(I)V", AccessFlags = 1)]
				public virtual void SetAnimationDuration(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSpacing
				/// </java-name>
				[Dot42.DexImport("setSpacing", "(I)V", AccessFlags = 1)]
				public virtual void SetSpacing(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUnselectedAlpha
				/// </java-name>
				[Dot42.DexImport("setUnselectedAlpha", "(F)V", AccessFlags = 1)]
				public virtual void SetUnselectedAlpha(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildStaticTransformation
				/// </java-name>
				[Dot42.DexImport("getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z", AccessFlags = 4)]
				protected internal override bool GetChildStaticTransformation(global::Android.Views.View view, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// computeHorizontalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 1)]
				public override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onSingleTapUp
				/// </java-name>
				[Dot42.DexImport("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnSingleTapUp(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onFling
				/// </java-name>
				[Dot42.DexImport("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1)]
				public virtual bool OnFling(global::Android.Views.MotionEvent motionEvent, global::Android.Views.MotionEvent motionEvent1, float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onScroll
				/// </java-name>
				[Dot42.DexImport("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1)]
				public virtual bool OnScroll(global::Android.Views.MotionEvent motionEvent, global::Android.Views.MotionEvent motionEvent1, float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onDown
				/// </java-name>
				[Dot42.DexImport("onDown", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnDown(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLongPress
				/// </java-name>
				[Dot42.DexImport("onLongPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public virtual void OnLongPress(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onShowPress
				/// </java-name>
				[Dot42.DexImport("onShowPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public virtual void OnShowPress(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetSelected
				/// </java-name>
				[Dot42.DexImport("dispatchSetSelected", "(Z)V", AccessFlags = 1)]
				public override void DispatchSetSelected(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetPressed
				/// </java-name>
				[Dot42.DexImport("dispatchSetPressed", "(Z)V", AccessFlags = 4)]
				protected internal override void DispatchSetPressed(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showContextMenuForChild
				/// </java-name>
				[Dot42.DexImport("showContextMenuForChild", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public override bool ShowContextMenuForChild(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// showContextMenu
				/// </java-name>
				[Dot42.DexImport("showContextMenu", "()Z", AccessFlags = 1)]
				public override bool ShowContextMenu() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildDrawingOrder
				/// </java-name>
				[Dot42.DexImport("getChildDrawingOrder", "(II)I", AccessFlags = 4)]
				protected internal override int GetChildDrawingOrder(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Gallery() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContextMenuInfo
				/// </java-name>
				protected internal override global::Android.Views.IContextMenu_IContextMenuInfo ContextMenuInfo
				{
						[Dot42.DexImport("getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", AccessFlags = 4)]
						get{ return default(global::Android.Views.IContextMenu_IContextMenuInfo); }
				}

				/// <java-name>
				/// android/widget/Gallery$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/Gallery$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/GridLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/GridLayout", AccessFlags = 33)]
		public partial class GridLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("HORIZONTAL", "I", AccessFlags = 25)]
				public const int HORIZONTAL = 0;
				/// <java-name>
				/// VERTICAL
				/// </java-name>
				[Dot42.DexImport("VERTICAL", "I", AccessFlags = 25)]
				public const int VERTICAL = 1;
				/// <java-name>
				/// UNDEFINED
				/// </java-name>
				[Dot42.DexImport("UNDEFINED", "I", AccessFlags = 25)]
				public const int UNDEFINED = -2147483648;
				/// <java-name>
				/// ALIGN_BOUNDS
				/// </java-name>
				[Dot42.DexImport("ALIGN_BOUNDS", "I", AccessFlags = 25)]
				public const int ALIGN_BOUNDS = 0;
				/// <java-name>
				/// ALIGN_MARGINS
				/// </java-name>
				[Dot42.DexImport("ALIGN_MARGINS", "I", AccessFlags = 25)]
				public const int ALIGN_MARGINS = 1;
				/// <java-name>
				/// TOP
				/// </java-name>
				[Dot42.DexImport("TOP", "Landroid/widget/GridLayout$Alignment;", AccessFlags = 25)]
				public static readonly global::Android.Widget.GridLayout.Alignment TOP;
				/// <java-name>
				/// BOTTOM
				/// </java-name>
				[Dot42.DexImport("BOTTOM", "Landroid/widget/GridLayout$Alignment;", AccessFlags = 25)]
				public static readonly global::Android.Widget.GridLayout.Alignment BOTTOM;
				/// <java-name>
				/// RIGHT
				/// </java-name>
				[Dot42.DexImport("RIGHT", "Landroid/widget/GridLayout$Alignment;", AccessFlags = 25)]
				public static readonly global::Android.Widget.GridLayout.Alignment RIGHT;
				/// <java-name>
				/// LEFT
				/// </java-name>
				[Dot42.DexImport("LEFT", "Landroid/widget/GridLayout$Alignment;", AccessFlags = 25)]
				public static readonly global::Android.Widget.GridLayout.Alignment LEFT;
				/// <java-name>
				/// CENTER
				/// </java-name>
				[Dot42.DexImport("CENTER", "Landroid/widget/GridLayout$Alignment;", AccessFlags = 25)]
				public static readonly global::Android.Widget.GridLayout.Alignment CENTER;
				/// <java-name>
				/// BASELINE
				/// </java-name>
				[Dot42.DexImport("BASELINE", "Landroid/widget/GridLayout$Alignment;", AccessFlags = 25)]
				public static readonly global::Android.Widget.GridLayout.Alignment BASELINE;
				/// <java-name>
				/// FILL
				/// </java-name>
				[Dot42.DexImport("FILL", "Landroid/widget/GridLayout$Alignment;", AccessFlags = 25)]
				public static readonly global::Android.Widget.GridLayout.Alignment FILL;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public GridLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public GridLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public GridLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/GridLayout$LayoutParams;", AccessFlags = 4)]
				protected internal new virtual global::Android.Widget.GridLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.GridLayout.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/GridLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.GridLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.GridLayout.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/GridLayout$LayoutParams;", AccessFlags = 4)]
				protected internal new virtual global::Android.Widget.GridLayout.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.GridLayout.LayoutParams);
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// spec
				/// </java-name>
				[Dot42.DexImport("spec", "(IILandroid/widget/GridLayout$Alignment;)Landroid/widget/GridLayout$Spec;", AccessFlags = 9)]
				public static global::Android.Widget.GridLayout.JavaSpec Spec(int int32, int int321, global::Android.Widget.GridLayout.Alignment alignment) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.GridLayout.JavaSpec);
				}

				/// <java-name>
				/// spec
				/// </java-name>
				[Dot42.DexImport("spec", "(ILandroid/widget/GridLayout$Alignment;)Landroid/widget/GridLayout$Spec;", AccessFlags = 9)]
				public static global::Android.Widget.GridLayout.JavaSpec Spec(int int32, global::Android.Widget.GridLayout.Alignment alignment) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.GridLayout.JavaSpec);
				}

				/// <java-name>
				/// spec
				/// </java-name>
				[Dot42.DexImport("spec", "(II)Landroid/widget/GridLayout$Spec;", AccessFlags = 9)]
				public static global::Android.Widget.GridLayout.JavaSpec Spec(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.GridLayout.JavaSpec);
				}

				/// <java-name>
				/// spec
				/// </java-name>
				[Dot42.DexImport("spec", "(I)Landroid/widget/GridLayout$Spec;", AccessFlags = 9)]
				public static global::Android.Widget.GridLayout.JavaSpec Spec(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.GridLayout.JavaSpec);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GridLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getOrientation
				/// </java-name>
				public virtual int Orientation
				{
						[Dot42.DexImport("getOrientation", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setOrientation", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRowCount
				/// </java-name>
				public virtual int RowCount
				{
						[Dot42.DexImport("getRowCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRowCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getColumnCount
				/// </java-name>
				public virtual int ColumnCount
				{
						[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setColumnCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getUseDefaultMargins
				/// </java-name>
				public virtual bool IsUseDefaultMargins
				{
						[Dot42.DexImport("getUseDefaultMargins", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setUseDefaultMargins", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAlignmentMode
				/// </java-name>
				public virtual int AlignmentMode
				{
						[Dot42.DexImport("getAlignmentMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setAlignmentMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isRowOrderPreserved
				/// </java-name>
				public virtual bool IsRowOrderPreserved
				{
						[Dot42.DexImport("isRowOrderPreserved", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setRowOrderPreserved", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isColumnOrderPreserved
				/// </java-name>
				public virtual bool IsColumnOrderPreserved
				{
						[Dot42.DexImport("isColumnOrderPreserved", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setColumnOrderPreserved", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/GridLayout$Alignment
				/// </java-name>
				[Dot42.DexImport("android/widget/GridLayout$Alignment", AccessFlags = 1033)]
				public abstract partial class Alignment
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal Alignment() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/widget/GridLayout$Spec
				/// </java-name>
				[Dot42.DexImport("android/widget/GridLayout$Spec", AccessFlags = 9)]
				public partial class JavaSpec
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal JavaSpec() /* MethodBuilder.Create */ 
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

				}

				/// <java-name>
				/// android/widget/GridLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/GridLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// rowSpec
						/// </java-name>
						[Dot42.DexImport("rowSpec", "Landroid/widget/GridLayout$Spec;", AccessFlags = 1)]
						public global::Android.Widget.GridLayout.JavaSpec RowSpec;
						/// <java-name>
						/// columnSpec
						/// </java-name>
						[Dot42.DexImport("columnSpec", "Landroid/widget/GridLayout$Spec;", AccessFlags = 1)]
						public global::Android.Widget.GridLayout.JavaSpec ColumnSpec;
						[Dot42.DexImport("<init>", "(Landroid/widget/GridLayout$Spec;Landroid/widget/GridLayout$Spec;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Widget.GridLayout.JavaSpec spec, global::Android.Widget.GridLayout.JavaSpec spec1) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public LayoutParams() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/widget/GridLayout$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setGravity
						/// </java-name>
						[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
						public virtual void SetGravity(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal override void SetBaseAttributes(global::Android.Content.Res.TypedArray typedArray, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/GridView
		/// </java-name>
		[Dot42.DexImport("android/widget/GridView", AccessFlags = 33)]
		public partial class GridView : global::Android.Widget.AbsListView
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_STRETCH
				/// </java-name>
				[Dot42.DexImport("NO_STRETCH", "I", AccessFlags = 25)]
				public const int NO_STRETCH = 0;
				/// <java-name>
				/// STRETCH_SPACING
				/// </java-name>
				[Dot42.DexImport("STRETCH_SPACING", "I", AccessFlags = 25)]
				public const int STRETCH_SPACING = 1;
				/// <java-name>
				/// STRETCH_COLUMN_WIDTH
				/// </java-name>
				[Dot42.DexImport("STRETCH_COLUMN_WIDTH", "I", AccessFlags = 25)]
				public const int STRETCH_COLUMN_WIDTH = 2;
				/// <java-name>
				/// STRETCH_SPACING_UNIFORM
				/// </java-name>
				[Dot42.DexImport("STRETCH_SPACING_UNIFORM", "I", AccessFlags = 25)]
				public const int STRETCH_SPACING_UNIFORM = 3;
				/// <java-name>
				/// AUTO_FIT
				/// </java-name>
				[Dot42.DexImport("AUTO_FIT", "I", AccessFlags = 25)]
				public const int AUTO_FIT = -1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public GridView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public GridView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public GridView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRemoteViewsAdapter
				/// </java-name>
				[Dot42.DexImport("setRemoteViewsAdapter", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SetRemoteViewsAdapter(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollToPosition
				/// </java-name>
				[Dot42.DexImport("smoothScrollToPosition", "(I)V", AccessFlags = 1)]
				public override void SmoothScrollToPosition(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollByOffset
				/// </java-name>
				[Dot42.DexImport("smoothScrollByOffset", "(I)V", AccessFlags = 1)]
				public virtual void SmoothScrollByOffset(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachLayoutAnimationParameters
				/// </java-name>
				[Dot42.DexImport("attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V", AccessFlags = 4)]
				protected internal override void AttachLayoutAnimationParameters(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layoutChildren
				/// </java-name>
				[Dot42.DexImport("layoutChildren", "()V", AccessFlags = 4)]
				protected internal override void LayoutChildren() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public override void SetSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int int32, int int321, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHorizontalSpacing
				/// </java-name>
				[Dot42.DexImport("setHorizontalSpacing", "(I)V", AccessFlags = 1)]
				public virtual void SetHorizontalSpacing(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVerticalSpacing
				/// </java-name>
				[Dot42.DexImport("setVerticalSpacing", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalSpacing(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColumnWidth
				/// </java-name>
				[Dot42.DexImport("setColumnWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetColumnWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GridView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getStretchMode
				/// </java-name>
				public virtual int StretchMode
				{
						[Dot42.DexImport("getStretchMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setStretchMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNumColumns
				/// </java-name>
				public virtual int NumColumns
				{
						[Dot42.DexImport("getNumColumns", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNumColumns", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/HeaderViewListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/HeaderViewListAdapter", AccessFlags = 33)]
		public partial class HeaderViewListAdapter : global::Android.Widget.IWrapperListAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Landroid/widget/ListAdapter;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/widget/ListView$FixedViewInfo;>;Ljava/util/ArrayLi" +
    "st<Landroid/widget/ListView$FixedViewInfo;>;Landroid/widget/ListAdapter;)V")]
				public HeaderViewListAdapter(global::Java.Util.ArrayList<global::Android.Widget.ListView.FixedViewInfo> arrayList, global::Java.Util.ArrayList<global::Android.Widget.ListView.FixedViewInfo> arrayList1, global::Android.Widget.IListAdapter listAdapter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHeader
				/// </java-name>
				[Dot42.DexImport("removeHeader", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool RemoveHeader(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeFooter
				/// </java-name>
				[Dot42.DexImport("removeFooter", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool RemoveFooter(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1)]
				public virtual bool AreAllItemsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "(I)Z", AccessFlags = 1)]
				public virtual bool IsEnabled(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetItem(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1)]
				public virtual long GetItemId(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// getItemViewType
				/// </java-name>
				[Dot42.DexImport("getItemViewType", "(I)I", AccessFlags = 1)]
				public virtual int GetItemViewType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1)]
				public virtual void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HeaderViewListAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHeadersCount
				/// </java-name>
				public virtual int HeadersCount
				{
						[Dot42.DexImport("getHeadersCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFootersCount
				/// </java-name>
				public virtual int FootersCount
				{
						[Dot42.DexImport("getFootersCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				public virtual bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public virtual int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public virtual bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getViewTypeCount
				/// </java-name>
				public virtual int ViewTypeCount
				{
						[Dot42.DexImport("getViewTypeCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <java-name>
				/// getWrappedAdapter
				/// </java-name>
				public virtual global::Android.Widget.IListAdapter WrappedAdapter
				{
						[Dot42.DexImport("getWrappedAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
				}

		}

		/// <java-name>
		/// android/widget/HorizontalScrollView
		/// </java-name>
		[Dot42.DexImport("android/widget/HorizontalScrollView", AccessFlags = 33)]
		public partial class HorizontalScrollView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public HorizontalScrollView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public HorizontalScrollView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public HorizontalScrollView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// executeKeyEvent
				/// </java-name>
				[Dot42.DexImport("executeKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool ExecuteKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestDisallowInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("requestDisallowInterceptTouchEvent", "(Z)V", AccessFlags = 1)]
				public override void RequestDisallowInterceptTouchEvent(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public override bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal override void OnOverScrolled(int int32, int int321, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pageScroll
				/// </java-name>
				[Dot42.DexImport("pageScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool PageScroll(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// fullScroll
				/// </java-name>
				[Dot42.DexImport("fullScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool FullScroll(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// arrowScroll
				/// </java-name>
				[Dot42.DexImport("arrowScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool ArrowScroll(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// smoothScrollBy
				/// </java-name>
				[Dot42.DexImport("smoothScrollBy", "(II)V", AccessFlags = 17)]
				public void SmoothScrollBy(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollTo
				/// </java-name>
				[Dot42.DexImport("smoothScrollTo", "(II)V", AccessFlags = 17)]
				public void SmoothScrollTo(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// measureChild
				/// </java-name>
				[Dot42.DexImport("measureChild", "(Landroid/view/View;II)V", AccessFlags = 4)]
				protected internal override void MeasureChild(global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// measureChildWithMargins
				/// </java-name>
				[Dot42.DexImport("measureChildWithMargins", "(Landroid/view/View;IIII)V", AccessFlags = 4)]
				protected internal override void MeasureChildWithMargins(global::Android.Views.View view, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScrollDeltaToGetChildRectOnScreen
				/// </java-name>
				[Dot42.DexImport("computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I", AccessFlags = 4)]
				protected internal virtual int ComputeScrollDeltaToGetChildRectOnScreen(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// requestChildFocus
				/// </java-name>
				[Dot42.DexImport("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public override void RequestChildFocus(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRequestFocusInDescendants
				/// </java-name>
				[Dot42.DexImport("onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal override bool OnRequestFocusInDescendants(int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public override bool RequestChildRectangleOnScreen(global::Android.Views.View view, global::Android.Graphics.Rect rect, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(I)V", AccessFlags = 1)]
				public virtual void Fling(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollTo
				/// </java-name>
				[Dot42.DexImport("scrollTo", "(II)V", AccessFlags = 1)]
				public override void ScrollTo(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal HorizontalScrollView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getLeftFadingEdgeStrength
				/// </java-name>
				protected internal override float LeftFadingEdgeStrength
				{
						[Dot42.DexImport("getLeftFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getRightFadingEdgeStrength
				/// </java-name>
				protected internal override float RightFadingEdgeStrength
				{
						[Dot42.DexImport("getRightFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getMaxScrollAmount
				/// </java-name>
				public virtual int MaxScrollAmount
				{
						[Dot42.DexImport("getMaxScrollAmount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isFillViewport
				/// </java-name>
				public virtual bool IsFillViewport
				{
						[Dot42.DexImport("isFillViewport", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFillViewport", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSmoothScrollingEnabled
				/// </java-name>
				public virtual bool IsSmoothScrollingEnabled
				{
						[Dot42.DexImport("isSmoothScrollingEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSmoothScrollingEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setOverScrollMode
				/// </java-name>
				public override int OverScrollMode
				{
						[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/Adapter
		/// </java-name>
		[Dot42.DexImport("android/widget/Adapter", AccessFlags = 1537)]
		public partial interface IAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetItem(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1025)]
				long GetItemId(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View GetView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getItemViewType
				/// </java-name>
				[Dot42.DexImport("getItemViewType", "(I)I", AccessFlags = 1025)]
				int GetItemViewType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCount
				/// </java-name>
				int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasStableIds
				/// </java-name>
				bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getViewTypeCount
				/// </java-name>
				int ViewTypeCount
				{
						[Dot42.DexImport("getViewTypeCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/widget/Adapter
		/// </java-name>
		[Dot42.DexImport("android/widget/Adapter", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IAdapterConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// IGNORE_ITEM_VIEW_TYPE
				/// </java-name>
				[Dot42.DexImport("IGNORE_ITEM_VIEW_TYPE", "I", AccessFlags = 25)]
				public const int IGNORE_ITEM_VIEW_TYPE = -1;
				/// <java-name>
				/// NO_SELECTION
				/// </java-name>
				[Dot42.DexImport("NO_SELECTION", "I", AccessFlags = 25)]
				public const int NO_SELECTION = -2147483648;
		}

		/// <java-name>
		/// android/widget/Checkable
		/// </java-name>
		[Dot42.DexImport("android/widget/Checkable", AccessFlags = 1537)]
		public partial interface ICheckable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1025)]
				void Toggle() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isChecked
				/// </java-name>
				bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1025)]
						set;
				}

		}

		/// <java-name>
		/// android/widget/ExpandableListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ExpandableListAdapter", AccessFlags = 1537)]
		public partial interface IExpandableListAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// registerDataSetObserver
				/// </java-name>
				[Dot42.DexImport("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void RegisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unregisterDataSetObserver
				/// </java-name>
				[Dot42.DexImport("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", AccessFlags = 1025)]
				void UnregisterDataSetObserver(global::Android.Database.DataSetObserver dataSetObserver) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChildrenCount
				/// </java-name>
				[Dot42.DexImport("getChildrenCount", "(I)I", AccessFlags = 1025)]
				int GetChildrenCount(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getGroup
				/// </java-name>
				[Dot42.DexImport("getGroup", "(I)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetGroup(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(II)Ljava/lang/Object;", AccessFlags = 1025)]
				object GetChild(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getGroupId
				/// </java-name>
				[Dot42.DexImport("getGroupId", "(I)J", AccessFlags = 1025)]
				long GetGroupId(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChildId
				/// </java-name>
				[Dot42.DexImport("getChildId", "(II)J", AccessFlags = 1025)]
				long GetChildId(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getGroupView
				/// </java-name>
				[Dot42.DexImport("getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View GetGroupView(int int32, bool boolean, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChildView
				/// </java-name>
				[Dot42.DexImport("getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View GetChildView(int int32, int int321, bool boolean, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isChildSelectable
				/// </java-name>
				[Dot42.DexImport("isChildSelectable", "(II)Z", AccessFlags = 1025)]
				bool IsChildSelectable(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1025)]
				bool AreAllItemsEnabled() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onGroupExpanded
				/// </java-name>
				[Dot42.DexImport("onGroupExpanded", "(I)V", AccessFlags = 1025)]
				void OnGroupExpanded(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onGroupCollapsed
				/// </java-name>
				[Dot42.DexImport("onGroupCollapsed", "(I)V", AccessFlags = 1025)]
				void OnGroupCollapsed(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCombinedChildId
				/// </java-name>
				[Dot42.DexImport("getCombinedChildId", "(JJ)J", AccessFlags = 1025)]
				long GetCombinedChildId(long int64, long int641) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCombinedGroupId
				/// </java-name>
				[Dot42.DexImport("getCombinedGroupId", "(J)J", AccessFlags = 1025)]
				long GetCombinedGroupId(long int64) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getGroupCount
				/// </java-name>
				int GroupCount
				{
						[Dot42.DexImport("getGroupCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasStableIds
				/// </java-name>
				bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isEmpty
				/// </java-name>
				bool IsEmpty
				{
						[Dot42.DexImport("isEmpty", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/widget/Filterable
		/// </java-name>
		[Dot42.DexImport("android/widget/Filterable", AccessFlags = 1537)]
		public partial interface IFilterable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getFilter
				/// </java-name>
				global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/widget/FilterQueryProvider
		/// </java-name>
		[Dot42.DexImport("android/widget/FilterQueryProvider", AccessFlags = 1537)]
		public partial interface IFilterQueryProvider
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// runQuery
				/// </java-name>
				[Dot42.DexImport("runQuery", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", AccessFlags = 1025)]
				global::Android.Database.ICursor RunQuery(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/widget/HeterogeneousExpandableList
		/// </java-name>
		[Dot42.DexImport("android/widget/HeterogeneousExpandableList", AccessFlags = 1537)]
		public partial interface IHeterogeneousExpandableList
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getGroupType
				/// </java-name>
				[Dot42.DexImport("getGroupType", "(I)I", AccessFlags = 1025)]
				int GetGroupType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChildType
				/// </java-name>
				[Dot42.DexImport("getChildType", "(II)I", AccessFlags = 1025)]
				int GetChildType(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getGroupTypeCount
				/// </java-name>
				int GroupTypeCount
				{
						[Dot42.DexImport("getGroupTypeCount", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getChildTypeCount
				/// </java-name>
				int ChildTypeCount
				{
						[Dot42.DexImport("getChildTypeCount", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/widget/ListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ListAdapter", AccessFlags = 1537)]
		public partial interface IListAdapter : global::Android.Widget.IAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// areAllItemsEnabled
				/// </java-name>
				[Dot42.DexImport("areAllItemsEnabled", "()Z", AccessFlags = 1025)]
				bool AreAllItemsEnabled() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "(I)Z", AccessFlags = 1025)]
				bool IsEnabled(int int32) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/widget/ImageButton
		/// </java-name>
		[Dot42.DexImport("android/widget/ImageButton", AccessFlags = 33)]
		public partial class ImageButton : global::Android.Widget.ImageView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ImageButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ImageButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ImageButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSetAlpha
				/// </java-name>
				[Dot42.DexImport("onSetAlpha", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnSetAlpha(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ImageButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/ImageSwitcher
		/// </java-name>
		[Dot42.DexImport("android/widget/ImageSwitcher", AccessFlags = 33)]
		public partial class ImageSwitcher : global::Android.Widget.ViewSwitcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ImageSwitcher(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ImageSwitcher(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageResource
				/// </java-name>
				[Dot42.DexImport("setImageResource", "(I)V", AccessFlags = 1)]
				public virtual void SetImageResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageURI
				/// </java-name>
				[Dot42.DexImport("setImageURI", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetImageURI(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageDrawable
				/// </java-name>
				[Dot42.DexImport("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetImageDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ImageSwitcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/ImageView
		/// </java-name>
		[Dot42.DexImport("android/widget/ImageView", AccessFlags = 33)]
		public partial class ImageView : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ImageView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ImageView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ImageView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void InvalidateDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSetAlpha
				/// </java-name>
				[Dot42.DexImport("onSetAlpha", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnSetAlpha(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAdjustViewBounds
				/// </java-name>
				[Dot42.DexImport("setAdjustViewBounds", "(Z)V", AccessFlags = 1)]
				public virtual void SetAdjustViewBounds(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxWidth
				/// </java-name>
				[Dot42.DexImport("setMaxWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxHeight
				/// </java-name>
				[Dot42.DexImport("setMaxHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxHeight(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageResource
				/// </java-name>
				[Dot42.DexImport("setImageResource", "(I)V", AccessFlags = 1)]
				public virtual void SetImageResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageURI
				/// </java-name>
				[Dot42.DexImport("setImageURI", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetImageURI(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageDrawable
				/// </java-name>
				[Dot42.DexImport("setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetImageDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageBitmap
				/// </java-name>
				[Dot42.DexImport("setImageBitmap", "(Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetImageBitmap(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageState
				/// </java-name>
				[Dot42.DexImport("setImageState", "([IZ)V", AccessFlags = 1)]
				public virtual void SetImageState(int[] int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageLevel
				/// </java-name>
				[Dot42.DexImport("setImageLevel", "(I)V", AccessFlags = 1)]
				public virtual void SetImageLevel(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScaleType
				/// </java-name>
				[Dot42.DexImport("setScaleType", "(Landroid/widget/ImageView$ScaleType;)V", AccessFlags = 1)]
				public virtual void SetScaleType(global::Android.Widget.ImageView.ScaleType scaleType) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getScaleType
				/// </java-name>
				[Dot42.DexImport("getScaleType", "()Landroid/widget/ImageView$ScaleType;", AccessFlags = 1)]
				public virtual global::Android.Widget.ImageView.ScaleType GetScaleType() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.ImageView.ScaleType);
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 1)]
				public new virtual int[] OnCreateDrawableState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFrame
				/// </java-name>
				[Dot42.DexImport("setFrame", "(IIII)Z", AccessFlags = 4)]
				protected internal virtual bool SetFrame(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBaseline
				/// </java-name>
				[Dot42.DexImport("setBaseline", "(I)V", AccessFlags = 1)]
				public virtual void SetBaseline(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V", AccessFlags = 17)]
				public void SetColorFilter(int int32, global::Android.Graphics.PorterDuff.Mode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(I)V", AccessFlags = 17)]
				public void SetColorFilter(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearColorFilter
				/// </java-name>
				[Dot42.DexImport("clearColorFilter", "()V", AccessFlags = 17)]
				public void ClearColorFilter() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColorFilter
				/// </java-name>
				[Dot42.DexImport("setColorFilter", "(Landroid/graphics/ColorFilter;)V", AccessFlags = 1)]
				public virtual void SetColorFilter(global::Android.Graphics.ColorFilter colorFilter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(I)V", AccessFlags = 1)]
				public virtual void SetAlpha(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ImageView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Drawable
				{
						[Dot42.DexImport("getDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getImageMatrix
				/// </java-name>
				public virtual global::Android.Graphics.Matrix ImageMatrix
				{
						[Dot42.DexImport("getImageMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Matrix); }
						[Dot42.DexImport("setImageMatrix", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBaselineAlignBottom
				/// </java-name>
				public virtual bool IsBaselineAlignBottom
				{
						[Dot42.DexImport("getBaselineAlignBottom", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setBaselineAlignBottom", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setSelected
				/// </java-name>
				public override bool IsSelected
				{
						[Dot42.DexImport("setSelected", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setVisibility
				/// </java-name>
				public override int Visibility
				{
						[Dot42.DexImport("setVisibility", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/ImageView$ScaleType
				/// </java-name>
				[Dot42.DexImport("android/widget/ImageView$ScaleType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/widget/ImageView$ScaleType;>;")]
				public sealed class ScaleType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CENTER
						/// </java-name>
						[Dot42.DexImport("CENTER", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType CENTER;
						/// <java-name>
						/// CENTER_CROP
						/// </java-name>
						[Dot42.DexImport("CENTER_CROP", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType CENTER_CROP;
						/// <java-name>
						/// CENTER_INSIDE
						/// </java-name>
						[Dot42.DexImport("CENTER_INSIDE", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType CENTER_INSIDE;
						/// <java-name>
						/// FIT_CENTER
						/// </java-name>
						[Dot42.DexImport("FIT_CENTER", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType FIT_CENTER;
						/// <java-name>
						/// FIT_END
						/// </java-name>
						[Dot42.DexImport("FIT_END", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType FIT_END;
						/// <java-name>
						/// FIT_START
						/// </java-name>
						[Dot42.DexImport("FIT_START", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType FIT_START;
						/// <java-name>
						/// FIT_XY
						/// </java-name>
						[Dot42.DexImport("FIT_XY", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType FIT_XY;
						/// <java-name>
						/// MATRIX
						/// </java-name>
						[Dot42.DexImport("MATRIX", "Landroid/widget/ImageView$ScaleType;", AccessFlags = 16409)]
						public static readonly ScaleType MATRIX;
						private ScaleType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/widget/ImageView$ScaleType;", AccessFlags = 9)]
						public static ScaleType[] Values() /* MethodBuilder.Create */ 
						{
								return default(ScaleType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;", AccessFlags = 9)]
						public static ScaleType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(ScaleType);
						}

				}

		}

		/// <java-name>
		/// android/widget/SectionIndexer
		/// </java-name>
		[Dot42.DexImport("android/widget/SectionIndexer", AccessFlags = 1537)]
		public partial interface ISectionIndexer
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getPositionForSection
				/// </java-name>
				[Dot42.DexImport("getPositionForSection", "(I)I", AccessFlags = 1025)]
				int GetPositionForSection(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSectionForPosition
				/// </java-name>
				[Dot42.DexImport("getSectionForPosition", "(I)I", AccessFlags = 1025)]
				int GetSectionForPosition(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSections
				/// </java-name>
				object[] Sections
				{
						[Dot42.DexImport("getSections", "()[Ljava/lang/Object;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/widget/SpinnerAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SpinnerAdapter", AccessFlags = 1537)]
		public partial interface ISpinnerAdapter : global::Android.Widget.IAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View GetDropDownView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/widget/WrapperListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/WrapperListAdapter", AccessFlags = 1537)]
		public partial interface IWrapperListAdapter : global::Android.Widget.IListAdapter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getWrappedAdapter
				/// </java-name>
				global::Android.Widget.IListAdapter WrappedAdapter
				{
						[Dot42.DexImport("getWrappedAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/widget/LinearLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/LinearLayout", AccessFlags = 33)]
		public partial class LinearLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("HORIZONTAL", "I", AccessFlags = 25)]
				public const int HORIZONTAL = 0;
				/// <java-name>
				/// VERTICAL
				/// </java-name>
				[Dot42.DexImport("VERTICAL", "I", AccessFlags = 25)]
				public const int VERTICAL = 1;
				/// <java-name>
				/// SHOW_DIVIDER_NONE
				/// </java-name>
				[Dot42.DexImport("SHOW_DIVIDER_NONE", "I", AccessFlags = 25)]
				public const int SHOW_DIVIDER_NONE = 0;
				/// <java-name>
				/// SHOW_DIVIDER_BEGINNING
				/// </java-name>
				[Dot42.DexImport("SHOW_DIVIDER_BEGINNING", "I", AccessFlags = 25)]
				public const int SHOW_DIVIDER_BEGINNING = 1;
				/// <java-name>
				/// SHOW_DIVIDER_MIDDLE
				/// </java-name>
				[Dot42.DexImport("SHOW_DIVIDER_MIDDLE", "I", AccessFlags = 25)]
				public const int SHOW_DIVIDER_MIDDLE = 2;
				/// <java-name>
				/// SHOW_DIVIDER_END
				/// </java-name>
				[Dot42.DexImport("SHOW_DIVIDER_END", "I", AccessFlags = 25)]
				public const int SHOW_DIVIDER_END = 4;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public LinearLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public LinearLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public LinearLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public override bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setDividerDrawable
				/// </java-name>
				[Dot42.DexImport("setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetDividerDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHorizontalGravity
				/// </java-name>
				[Dot42.DexImport("setHorizontalGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetHorizontalGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVerticalGravity
				/// </java-name>
				[Dot42.DexImport("setVerticalGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.LinearLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 4)]
				protected internal new virtual global::Android.Widget.LinearLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;" +
    "", AccessFlags = 4)]
				protected internal new virtual global::Android.Widget.LinearLayout.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LinearLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getShowDividers
				/// </java-name>
				public virtual int ShowDividers
				{
						[Dot42.DexImport("getShowDividers", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setShowDividers", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDividerPadding
				/// </java-name>
				public virtual int DividerPadding
				{
						[Dot42.DexImport("getDividerPadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDividerPadding", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isBaselineAligned
				/// </java-name>
				public virtual bool IsBaselineAligned
				{
						[Dot42.DexImport("isBaselineAligned", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setBaselineAligned", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isMeasureWithLargestChildEnabled
				/// </java-name>
				public virtual bool IsMeasureWithLargestChildEnabled
				{
						[Dot42.DexImport("isMeasureWithLargestChildEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setMeasureWithLargestChildEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBaselineAlignedChildIndex
				/// </java-name>
				public virtual int BaselineAlignedChildIndex
				{
						[Dot42.DexImport("getBaselineAlignedChildIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setBaselineAlignedChildIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getWeightSum
				/// </java-name>
				public virtual float WeightSum
				{
						[Dot42.DexImport("getWeightSum", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setWeightSum", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOrientation
				/// </java-name>
				public virtual int Orientation
				{
						[Dot42.DexImport("getOrientation", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setOrientation", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/LinearLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/LinearLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// weight
						/// </java-name>
						[Dot42.DexImport("weight", "F", AccessFlags = 1)]
						public float Weight;
						/// <java-name>
						/// gravity
						/// </java-name>
						[Dot42.DexImport("gravity", "I", AccessFlags = 1)]
						public int Gravity;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(IIF)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// debug
						/// </java-name>
						[Dot42.DexImport("debug", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Debug(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/ListPopupWindow
		/// </java-name>
		[Dot42.DexImport("android/widget/ListPopupWindow", AccessFlags = 33)]
		public partial class ListPopupWindow
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// POSITION_PROMPT_ABOVE
				/// </java-name>
				[Dot42.DexImport("POSITION_PROMPT_ABOVE", "I", AccessFlags = 25)]
				public const int POSITION_PROMPT_ABOVE = 0;
				/// <java-name>
				/// POSITION_PROMPT_BELOW
				/// </java-name>
				[Dot42.DexImport("POSITION_PROMPT_BELOW", "I", AccessFlags = 25)]
				public const int POSITION_PROMPT_BELOW = 1;
				/// <java-name>
				/// MATCH_PARENT
				/// </java-name>
				[Dot42.DexImport("MATCH_PARENT", "I", AccessFlags = 25)]
				public const int MATCH_PARENT = -1;
				/// <java-name>
				/// WRAP_CONTENT
				/// </java-name>
				[Dot42.DexImport("WRAP_CONTENT", "I", AccessFlags = 25)]
				public const int WRAP_CONTENT = -2;
				/// <java-name>
				/// INPUT_METHOD_FROM_FOCUSABLE
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_FROM_FOCUSABLE", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_FROM_FOCUSABLE = 0;
				/// <java-name>
				/// INPUT_METHOD_NEEDED
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_NEEDED", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_NEEDED = 1;
				/// <java-name>
				/// INPUT_METHOD_NOT_NEEDED
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_NOT_NEEDED", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_NOT_NEEDED = 2;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ListPopupWindow(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ListPopupWindow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ListPopupWindow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", AccessFlags = 1)]
				public ListPopupWindow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAdapter
				/// </java-name>
				[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
				public virtual void SetAdapter(global::Android.Widget.IListAdapter listAdapter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setListSelector
				/// </java-name>
				[Dot42.DexImport("setListSelector", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetListSelector(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentWidth
				/// </java-name>
				[Dot42.DexImport("setContentWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetContentWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnItemClickListener
				/// </java-name>
				[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnItemClickListener(global::Android.Widget.AdapterView<object>.IOnItemClickListener onItemClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnItemSelectedListener
				/// </java-name>
				[Dot42.DexImport("setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)V", AccessFlags = 1)]
				public virtual void SetOnItemSelectedListener(global::Android.Widget.AdapterView<object>.IOnItemSelectedListener onItemSelectedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPromptView
				/// </java-name>
				[Dot42.DexImport("setPromptView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetPromptView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// postShow
				/// </java-name>
				[Dot42.DexImport("postShow", "()V", AccessFlags = 1)]
				public virtual void PostShow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDismissListener
				/// </java-name>
				[Dot42.DexImport("setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V", AccessFlags = 1)]
				public virtual void SetOnDismissListener(global::Android.Widget.PopupWindow.IOnDismissListener onDismissListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public virtual void SetSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearListSelection
				/// </java-name>
				[Dot42.DexImport("clearListSelection", "()V", AccessFlags = 1)]
				public virtual void ClearListSelection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performItemClick
				/// </java-name>
				[Dot42.DexImport("performItemClick", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformItemClick(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyPreIme
				/// </java-name>
				[Dot42.DexImport("onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyPreIme(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ListPopupWindow() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPromptPosition
				/// </java-name>
				public virtual int PromptPosition
				{
						[Dot42.DexImport("getPromptPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setPromptPosition", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isModal
				/// </java-name>
				public virtual bool IsModal
				{
						[Dot42.DexImport("isModal", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setModal", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSoftInputMode
				/// </java-name>
				public virtual int SoftInputMode
				{
						[Dot42.DexImport("getSoftInputMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSoftInputMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBackground
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Background
				{
						[Dot42.DexImport("getBackground", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getAnimationStyle
				/// </java-name>
				public virtual int AnimationStyle
				{
						[Dot42.DexImport("getAnimationStyle", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setAnimationStyle", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAnchorView
				/// </java-name>
				public virtual global::Android.Views.View AnchorView
				{
						[Dot42.DexImport("getAnchorView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
						[Dot42.DexImport("setAnchorView", "(Landroid/view/View;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getHorizontalOffset
				/// </java-name>
				public virtual int HorizontalOffset
				{
						[Dot42.DexImport("getHorizontalOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setHorizontalOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getVerticalOffset
				/// </java-name>
				public virtual int VerticalOffset
				{
						[Dot42.DexImport("getVerticalOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setVerticalOffset", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setWidth", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setHeight", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInputMethodMode
				/// </java-name>
				public virtual int InputMethodMode
				{
						[Dot42.DexImport("getInputMethodMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setInputMethodMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isShowing
				/// </java-name>
				public virtual bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isInputMethodNotNeeded
				/// </java-name>
				public virtual bool IsInputMethodNotNeeded
				{
						[Dot42.DexImport("isInputMethodNotNeeded", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getSelectedItem
				/// </java-name>
				public virtual object SelectedItem
				{
						[Dot42.DexImport("getSelectedItem", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <java-name>
				/// getSelectedItemPosition
				/// </java-name>
				public virtual int SelectedItemPosition
				{
						[Dot42.DexImport("getSelectedItemPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSelectedItemId
				/// </java-name>
				public virtual long SelectedItemId
				{
						[Dot42.DexImport("getSelectedItemId", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getSelectedView
				/// </java-name>
				public virtual global::Android.Views.View SelectedView
				{
						[Dot42.DexImport("getSelectedView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getListView
				/// </java-name>
				public virtual global::Android.Widget.ListView ListView
				{
						[Dot42.DexImport("getListView", "()Landroid/widget/ListView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.ListView); }
				}

		}

		/// <java-name>
		/// android/widget/ListView
		/// </java-name>
		[Dot42.DexImport("android/widget/ListView", AccessFlags = 33)]
		public partial class ListView : global::Android.Widget.AbsListView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ListView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ListView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addHeaderView
				/// </java-name>
				[Dot42.DexImport("addHeaderView", "(Landroid/view/View;Ljava/lang/Object;Z)V", AccessFlags = 1)]
				public virtual void AddHeaderView(global::Android.Views.View view, object @object, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addHeaderView
				/// </java-name>
				[Dot42.DexImport("addHeaderView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddHeaderView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeHeaderView
				/// </java-name>
				[Dot42.DexImport("removeHeaderView", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool RemoveHeaderView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addFooterView
				/// </java-name>
				[Dot42.DexImport("addFooterView", "(Landroid/view/View;Ljava/lang/Object;Z)V", AccessFlags = 1)]
				public virtual void AddFooterView(global::Android.Views.View view, object @object, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFooterView
				/// </java-name>
				[Dot42.DexImport("addFooterView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddFooterView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeFooterView
				/// </java-name>
				[Dot42.DexImport("removeFooterView", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool RemoveFooterView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setRemoteViewsAdapter
				/// </java-name>
				[Dot42.DexImport("setRemoteViewsAdapter", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void SetRemoteViewsAdapter(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public override bool RequestChildRectangleOnScreen(global::Android.Views.View view, global::Android.Graphics.Rect rect, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// smoothScrollToPosition
				/// </java-name>
				[Dot42.DexImport("smoothScrollToPosition", "(I)V", AccessFlags = 1)]
				public override void SmoothScrollToPosition(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollByOffset
				/// </java-name>
				[Dot42.DexImport("smoothScrollByOffset", "(I)V", AccessFlags = 1)]
				public virtual void SmoothScrollByOffset(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layoutChildren
				/// </java-name>
				[Dot42.DexImport("layoutChildren", "()V", AccessFlags = 4)]
				protected internal override void LayoutChildren() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelection
				/// </java-name>
				[Dot42.DexImport("setSelection", "(I)V", AccessFlags = 1)]
				public override void SetSelection(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelectionFromTop
				/// </java-name>
				[Dot42.DexImport("setSelectionFromTop", "(II)V", AccessFlags = 1)]
				public virtual void SetSelectionFromTop(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelectionAfterHeaderView
				/// </java-name>
				[Dot42.DexImport("setSelectionAfterHeaderView", "()V", AccessFlags = 1)]
				public virtual void SetSelectionAfterHeaderView() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int int32, int int321, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawChild
				/// </java-name>
				[Dot42.DexImport("drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", AccessFlags = 4)]
				protected internal override bool DrawChild(global::Android.Graphics.Canvas canvas, global::Android.Views.View view, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setHeaderDividersEnabled
				/// </java-name>
				[Dot42.DexImport("setHeaderDividersEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetHeaderDividersEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFooterDividersEnabled
				/// </java-name>
				[Dot42.DexImport("setFooterDividersEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetFooterDividersEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findViewTraversal
				/// </java-name>
				[Dot42.DexImport("findViewTraversal", "(I)Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View FindViewTraversal(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// findViewWithTagTraversal
				/// </java-name>
				[Dot42.DexImport("findViewWithTagTraversal", "(Ljava/lang/Object;)Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View FindViewWithTagTraversal(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ListView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMaxScrollAmount
				/// </java-name>
				public virtual int MaxScrollAmount
				{
						[Dot42.DexImport("getMaxScrollAmount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHeaderViewsCount
				/// </java-name>
				public virtual int HeaderViewsCount
				{
						[Dot42.DexImport("getHeaderViewsCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFooterViewsCount
				/// </java-name>
				public virtual int FooterViewsCount
				{
						[Dot42.DexImport("getFooterViewsCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getAdapter
				/// </java-name>
				public override global::Android.Widget.IListAdapter Adapter
				{
						[Dot42.DexImport("getAdapter", "()Landroid/widget/ListAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.IListAdapter); }
						[Dot42.DexImport("setAdapter", "(Landroid/widget/ListAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// canAnimate
				/// </java-name>
				protected internal override bool CanAnimate
				{
						[Dot42.DexImport("canAnimate", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getItemsCanFocus
				/// </java-name>
				public virtual bool IsItemsCanFocus
				{
						[Dot42.DexImport("getItemsCanFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setItemsCanFocus", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isOpaque
				/// </java-name>
				public override bool IsOpaque
				{
						[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDivider
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Divider
				{
						[Dot42.DexImport("getDivider", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setDivider", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDividerHeight
				/// </java-name>
				public virtual int DividerHeight
				{
						[Dot42.DexImport("getDividerHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDividerHeight", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOverscrollHeader
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable OverscrollHeader
				{
						[Dot42.DexImport("getOverscrollHeader", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setOverscrollHeader", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOverscrollFooter
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable OverscrollFooter
				{
						[Dot42.DexImport("getOverscrollFooter", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setOverscrollFooter", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCheckItemIds
				/// </java-name>
				public virtual long[] CheckItemIds
				{
						[Dot42.DexImport("getCheckItemIds", "()[J", AccessFlags = 1)]
						get{ return default(long[]); }
				}

				/// <java-name>
				/// setCacheColorHint
				/// </java-name>
				public override int CacheColorHint
				{
						[Dot42.DexImport("setCacheColorHint", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/ListView$FixedViewInfo
				/// </java-name>
				[Dot42.DexImport("android/widget/ListView$FixedViewInfo", AccessFlags = 1)]
				public partial class FixedViewInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// view
						/// </java-name>
						[Dot42.DexImport("view", "Landroid/view/View;", AccessFlags = 1)]
						public global::Android.Views.View View;
						/// <java-name>
						/// data
						/// </java-name>
						[Dot42.DexImport("data", "Ljava/lang/Object;", AccessFlags = 1)]
						public object Data;
						/// <java-name>
						/// isSelectable
						/// </java-name>
						[Dot42.DexImport("isSelectable", "Z", AccessFlags = 1)]
						public bool IsSelectable;
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/widget/ListView;", AccessFlags = 4112)]
						internal readonly global::Android.Widget.ListView This_0;
						[Dot42.DexImport("<init>", "(Landroid/widget/ListView;)V", AccessFlags = 1)]
						public FixedViewInfo(global::Android.Widget.ListView listView) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal FixedViewInfo() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/MediaController
		/// </java-name>
		[Dot42.DexImport("android/widget/MediaController", AccessFlags = 33)]
		public partial class MediaController : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public MediaController(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Z)V", AccessFlags = 1)]
				public MediaController(global::Android.Content.Context context, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MediaController(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 1)]
				public new virtual void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMediaPlayer
				/// </java-name>
				[Dot42.DexImport("setMediaPlayer", "(Landroid/widget/MediaController$MediaPlayerControl;)V", AccessFlags = 1)]
				public virtual void SetMediaPlayer(global::Android.Widget.MediaController.IMediaPlayerControl mediaPlayerControl) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAnchorView
				/// </java-name>
				[Dot42.DexImport("setAnchorView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetAnchorView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "(I)V", AccessFlags = 1)]
				public virtual void Show(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 1)]
				public virtual void Hide() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPrevNextListeners
				/// </java-name>
				[Dot42.DexImport("setPrevNextListeners", "(Landroid/view/View$OnClickListener;Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetPrevNextListeners(global::Android.Views.View.IOnClickListener onClickListener, global::Android.Views.View.IOnClickListener onClickListener1) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MediaController() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isShowing
				/// </java-name>
				public virtual bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1)]
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

				/// <java-name>
				/// android/widget/MediaController$MediaPlayerControl
				/// </java-name>
				[Dot42.DexImport("android/widget/MediaController$MediaPlayerControl", AccessFlags = 1545)]
				public partial interface IMediaPlayerControl
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// start
						/// </java-name>
						[Dot42.DexImport("start", "()V", AccessFlags = 1025)]
						void Start() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// pause
						/// </java-name>
						[Dot42.DexImport("pause", "()V", AccessFlags = 1025)]
						void Pause() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// seekTo
						/// </java-name>
						[Dot42.DexImport("seekTo", "(I)V", AccessFlags = 1025)]
						void SeekTo(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// getDuration
						/// </java-name>
						int Duration
						{
								[Dot42.DexImport("getDuration", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getCurrentPosition
						/// </java-name>
						int CurrentPosition
						{
								[Dot42.DexImport("getCurrentPosition", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// isPlaying
						/// </java-name>
						bool IsPlaying
						{
								[Dot42.DexImport("isPlaying", "()Z", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getBufferPercentage
						/// </java-name>
						int BufferPercentage
						{
								[Dot42.DexImport("getBufferPercentage", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// canPause
						/// </java-name>
						bool CanPause
						{
								[Dot42.DexImport("canPause", "()Z", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// canSeekBackward
						/// </java-name>
						bool CanSeekBackward
						{
								[Dot42.DexImport("canSeekBackward", "()Z", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// canSeekForward
						/// </java-name>
						bool CanSeekForward
						{
								[Dot42.DexImport("canSeekForward", "()Z", AccessFlags = 1025)]
								get;
						}

				}

		}

		/// <java-name>
		/// android/widget/MultiAutoCompleteTextView
		/// </java-name>
		[Dot42.DexImport("android/widget/MultiAutoCompleteTextView", AccessFlags = 33)]
		public partial class MultiAutoCompleteTextView : global::Android.Widget.AutoCompleteTextView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MultiAutoCompleteTextView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public MultiAutoCompleteTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public MultiAutoCompleteTextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTokenizer
				/// </java-name>
				[Dot42.DexImport("setTokenizer", "(Landroid/widget/MultiAutoCompleteTextView$Tokenizer;)V", AccessFlags = 1)]
				public virtual void SetTokenizer(global::Android.Widget.MultiAutoCompleteTextView.ITokenizer tokenizer) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performFiltering
				/// </java-name>
				[Dot42.DexImport("performFiltering", "(Ljava/lang/CharSequence;I)V", AccessFlags = 4)]
				protected internal override void PerformFiltering(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enoughToFilter
				/// </java-name>
				[Dot42.DexImport("enoughToFilter", "()Z", AccessFlags = 1)]
				public override bool EnoughToFilter() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performValidation
				/// </java-name>
				[Dot42.DexImport("performValidation", "()V", AccessFlags = 1)]
				public override void PerformValidation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performFiltering
				/// </java-name>
				[Dot42.DexImport("performFiltering", "(Ljava/lang/CharSequence;III)V", AccessFlags = 4)]
				protected internal virtual void PerformFiltering(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// replaceText
				/// </java-name>
				[Dot42.DexImport("replaceText", "(Ljava/lang/CharSequence;)V", AccessFlags = 4)]
				protected internal override void ReplaceText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MultiAutoCompleteTextView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/widget/MultiAutoCompleteTextView$CommaTokenizer
				/// </java-name>
				[Dot42.DexImport("android/widget/MultiAutoCompleteTextView$CommaTokenizer", AccessFlags = 9)]
				public partial class CommaTokenizer : global::Android.Widget.MultiAutoCompleteTextView.ITokenizer
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CommaTokenizer() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// findTokenStart
						/// </java-name>
						[Dot42.DexImport("findTokenStart", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1)]
						public virtual int FindTokenStart(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// findTokenEnd
						/// </java-name>
						[Dot42.DexImport("findTokenEnd", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1)]
						public virtual int FindTokenEnd(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// terminateToken
						/// </java-name>
						[Dot42.DexImport("terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1)]
						public virtual global::Java.Lang.ICharSequence TerminateToken(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(global::Java.Lang.ICharSequence);
						}

				}

				/// <java-name>
				/// android/widget/MultiAutoCompleteTextView$Tokenizer
				/// </java-name>
				[Dot42.DexImport("android/widget/MultiAutoCompleteTextView$Tokenizer", AccessFlags = 1545)]
				public partial interface ITokenizer
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// findTokenStart
						/// </java-name>
						[Dot42.DexImport("findTokenStart", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1025)]
						int FindTokenStart(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// findTokenEnd
						/// </java-name>
						[Dot42.DexImport("findTokenEnd", "(Ljava/lang/CharSequence;I)I", AccessFlags = 1025)]
						int FindTokenEnd(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// terminateToken
						/// </java-name>
						[Dot42.DexImport("terminateToken", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
						global::Java.Lang.ICharSequence TerminateToken(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/NumberPicker
		/// </java-name>
		[Dot42.DexImport("android/widget/NumberPicker", AccessFlags = 33)]
		public partial class NumberPicker : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public NumberPicker(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public NumberPicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public NumberPicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool DispatchTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool DispatchTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollBy
				/// </java-name>
				[Dot42.DexImport("scrollBy", "(II)V", AccessFlags = 1)]
				public override void ScrollBy(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnValueChangedListener
				/// </java-name>
				[Dot42.DexImport("setOnValueChangedListener", "(Landroid/widget/NumberPicker$OnValueChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnValueChangedListener(global::Android.Widget.NumberPicker.IOnValueChangeListener onValueChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnScrollListener
				/// </java-name>
				[Dot42.DexImport("setOnScrollListener", "(Landroid/widget/NumberPicker$OnScrollListener;)V", AccessFlags = 1)]
				public virtual void SetOnScrollListener(global::Android.Widget.NumberPicker.IOnScrollListener onScrollListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFormatter
				/// </java-name>
				[Dot42.DexImport("setFormatter", "(Landroid/widget/NumberPicker$Formatter;)V", AccessFlags = 1)]
				public virtual void SetFormatter(global::Android.Widget.NumberPicker.IFormatter formatter) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnLongPressUpdateInterval
				/// </java-name>
				[Dot42.DexImport("setOnLongPressUpdateInterval", "(J)V", AccessFlags = 1)]
				public virtual void SetOnLongPressUpdateInterval(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1)]
				public override void SendAccessibilityEvent(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal NumberPicker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSolidColor
				/// </java-name>
				public override int SolidColor
				{
						[Dot42.DexImport("getSolidColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getWrapSelectorWheel
				/// </java-name>
				public virtual bool IsWrapSelectorWheel
				{
						[Dot42.DexImport("getWrapSelectorWheel", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setWrapSelectorWheel", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getValue
				/// </java-name>
				public virtual int Value
				{
						[Dot42.DexImport("getValue", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setValue", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMinValue
				/// </java-name>
				public virtual int MinValue
				{
						[Dot42.DexImport("getMinValue", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMinValue", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMaxValue
				/// </java-name>
				public virtual int MaxValue
				{
						[Dot42.DexImport("getMaxValue", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMaxValue", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDisplayedValues
				/// </java-name>
				public virtual string[] DisplayedValues
				{
						[Dot42.DexImport("getDisplayedValues", "()[Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string[]); }
						[Dot42.DexImport("setDisplayedValues", "([Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTopFadingEdgeStrength
				/// </java-name>
				protected internal override float TopFadingEdgeStrength
				{
						[Dot42.DexImport("getTopFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getBottomFadingEdgeStrength
				/// </java-name>
				protected internal override float BottomFadingEdgeStrength
				{
						[Dot42.DexImport("getBottomFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/NumberPicker$Formatter
				/// </java-name>
				[Dot42.DexImport("android/widget/NumberPicker$Formatter", AccessFlags = 1545)]
				public partial interface IFormatter
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// format
						/// </java-name>
						[Dot42.DexImport("format", "(I)Ljava/lang/String;", AccessFlags = 1025)]
						string Format(int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/NumberPicker$OnScrollListener
				/// </java-name>
				[Dot42.DexImport("android/widget/NumberPicker$OnScrollListener", AccessFlags = 1545, IgnoreFromJava = true, Priority = 1)]
				public static partial class IOnScrollListenerConstants
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// SCROLL_STATE_IDLE
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_IDLE", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_IDLE = 0;
						/// <java-name>
						/// SCROLL_STATE_TOUCH_SCROLL
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_TOUCH_SCROLL", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_TOUCH_SCROLL = 1;
						/// <java-name>
						/// SCROLL_STATE_FLING
						/// </java-name>
						[Dot42.DexImport("SCROLL_STATE_FLING", "I", AccessFlags = 25)]
						public const int SCROLL_STATE_FLING = 2;
				}

				/// <java-name>
				/// android/widget/NumberPicker$OnScrollListener
				/// </java-name>
				[Dot42.DexImport("android/widget/NumberPicker$OnScrollListener", AccessFlags = 1545)]
				public partial interface IOnScrollListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onScrollStateChange
						/// </java-name>
						[Dot42.DexImport("onScrollStateChange", "(Landroid/widget/NumberPicker;I)V", AccessFlags = 1025)]
						void OnScrollStateChange(global::Android.Widget.NumberPicker numberPicker, int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/NumberPicker$OnValueChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/NumberPicker$OnValueChangeListener", AccessFlags = 1545)]
				public partial interface IOnValueChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onValueChange
						/// </java-name>
						[Dot42.DexImport("onValueChange", "(Landroid/widget/NumberPicker;II)V", AccessFlags = 1025)]
						void OnValueChange(global::Android.Widget.NumberPicker numberPicker, int int32, int int321) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/OverScroller
		/// </java-name>
		[Dot42.DexImport("android/widget/OverScroller", AccessFlags = 33)]
		public partial class OverScroller
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public OverScroller(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
				public OverScroller(global::Android.Content.Context context, global::Android.Views.Animations.IInterpolator interpolator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;FF)V", AccessFlags = 1)]
				public OverScroller(global::Android.Content.Context context, global::Android.Views.Animations.IInterpolator interpolator, float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;FFZ)V", AccessFlags = 1)]
				public OverScroller(global::Android.Content.Context context, global::Android.Views.Animations.IInterpolator interpolator, float single, float single1, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFriction
				/// </java-name>
				[Dot42.DexImport("setFriction", "(F)V", AccessFlags = 17)]
				public void SetFriction(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forceFinished
				/// </java-name>
				[Dot42.DexImport("forceFinished", "(Z)V", AccessFlags = 17)]
				public void ForceFinished(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeScrollOffset", "()Z", AccessFlags = 1)]
				public virtual bool ComputeScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startScroll
				/// </java-name>
				[Dot42.DexImport("startScroll", "(IIII)V", AccessFlags = 1)]
				public virtual void StartScroll(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startScroll
				/// </java-name>
				[Dot42.DexImport("startScroll", "(IIIII)V", AccessFlags = 1)]
				public virtual void StartScroll(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// springBack
				/// </java-name>
				[Dot42.DexImport("springBack", "(IIIIII)Z", AccessFlags = 1)]
				public virtual bool SpringBack(int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(IIIIIIII)V", AccessFlags = 1)]
				public virtual void Fling(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(IIIIIIIIII)V", AccessFlags = 1)]
				public virtual void Fling(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327, int int328, int int329) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyHorizontalEdgeReached
				/// </java-name>
				[Dot42.DexImport("notifyHorizontalEdgeReached", "(III)V", AccessFlags = 1)]
				public virtual void NotifyHorizontalEdgeReached(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyVerticalEdgeReached
				/// </java-name>
				[Dot42.DexImport("notifyVerticalEdgeReached", "(III)V", AccessFlags = 1)]
				public virtual void NotifyVerticalEdgeReached(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// abortAnimation
				/// </java-name>
				[Dot42.DexImport("abortAnimation", "()V", AccessFlags = 1)]
				public virtual void AbortAnimation() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal OverScroller() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isFinished
				/// </java-name>
				public bool IsFinished
				{
						[Dot42.DexImport("isFinished", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getCurrX
				/// </java-name>
				public int CurrX
				{
						[Dot42.DexImport("getCurrX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCurrY
				/// </java-name>
				public int CurrY
				{
						[Dot42.DexImport("getCurrY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCurrVelocity
				/// </java-name>
				public virtual float CurrVelocity
				{
						[Dot42.DexImport("getCurrVelocity", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getStartX
				/// </java-name>
				public int StartX
				{
						[Dot42.DexImport("getStartX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getStartY
				/// </java-name>
				public int StartY
				{
						[Dot42.DexImport("getStartY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFinalX
				/// </java-name>
				public int FinalX
				{
						[Dot42.DexImport("getFinalX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFinalY
				/// </java-name>
				public int FinalY
				{
						[Dot42.DexImport("getFinalY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isOverScrolled
				/// </java-name>
				public virtual bool IsOverScrolled
				{
						[Dot42.DexImport("isOverScrolled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/widget/PopupMenu
		/// </java-name>
		[Dot42.DexImport("android/widget/PopupMenu", AccessFlags = 33)]
		public partial class PopupMenu
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/View;)V", AccessFlags = 1)]
				public PopupMenu(global::Android.Content.Context context, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(I)V", AccessFlags = 1)]
				public virtual void Inflate(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnMenuItemClickListener
				/// </java-name>
				[Dot42.DexImport("setOnMenuItemClickListener", "(Landroid/widget/PopupMenu$OnMenuItemClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnMenuItemClickListener(global::Android.Widget.PopupMenu.IOnMenuItemClickListener onMenuItemClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDismissListener
				/// </java-name>
				[Dot42.DexImport("setOnDismissListener", "(Landroid/widget/PopupMenu$OnDismissListener;)V", AccessFlags = 1)]
				public virtual void SetOnDismissListener(global::Android.Widget.PopupMenu.IOnDismissListener onDismissListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PopupMenu() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMenu
				/// </java-name>
				public virtual global::Android.Views.IMenu Menu
				{
						[Dot42.DexImport("getMenu", "()Landroid/view/Menu;", AccessFlags = 1)]
						get{ return default(global::Android.Views.IMenu); }
				}

				/// <java-name>
				/// getMenuInflater
				/// </java-name>
				public virtual global::Android.Views.MenuInflater MenuInflater
				{
						[Dot42.DexImport("getMenuInflater", "()Landroid/view/MenuInflater;", AccessFlags = 1)]
						get{ return default(global::Android.Views.MenuInflater); }
				}

				/// <java-name>
				/// android/widget/PopupMenu$OnMenuItemClickListener
				/// </java-name>
				[Dot42.DexImport("android/widget/PopupMenu$OnMenuItemClickListener", AccessFlags = 1545)]
				public partial interface IOnMenuItemClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onMenuItemClick
						/// </java-name>
						[Dot42.DexImport("onMenuItemClick", "(Landroid/view/MenuItem;)Z", AccessFlags = 1025)]
						bool OnMenuItemClick(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/PopupMenu$OnDismissListener
				/// </java-name>
				[Dot42.DexImport("android/widget/PopupMenu$OnDismissListener", AccessFlags = 1545)]
				public partial interface IOnDismissListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDismiss
						/// </java-name>
						[Dot42.DexImport("onDismiss", "(Landroid/widget/PopupMenu;)V", AccessFlags = 1025)]
						void OnDismiss(global::Android.Widget.PopupMenu popupMenu) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/PopupWindow
		/// </java-name>
		[Dot42.DexImport("android/widget/PopupWindow", AccessFlags = 33)]
		public partial class PopupWindow
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// INPUT_METHOD_FROM_FOCUSABLE
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_FROM_FOCUSABLE", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_FROM_FOCUSABLE = 0;
				/// <java-name>
				/// INPUT_METHOD_NEEDED
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_NEEDED", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_NEEDED = 1;
				/// <java-name>
				/// INPUT_METHOD_NOT_NEEDED
				/// </java-name>
				[Dot42.DexImport("INPUT_METHOD_NOT_NEEDED", "I", AccessFlags = 25)]
				public const int INPUT_METHOD_NOT_NEEDED = 2;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public PopupWindow() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/View;)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public PopupWindow(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/View;II)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/View;IIZ)V", AccessFlags = 1)]
				public PopupWindow(global::Android.Views.View view, int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIgnoreCheekPress
				/// </java-name>
				[Dot42.DexImport("setIgnoreCheekPress", "()V", AccessFlags = 1)]
				public virtual void SetIgnoreCheekPress() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTouchInterceptor
				/// </java-name>
				[Dot42.DexImport("setTouchInterceptor", "(Landroid/view/View$OnTouchListener;)V", AccessFlags = 1)]
				public virtual void SetTouchInterceptor(global::Android.Views.View.IOnTouchListener onTouchListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWindowLayoutMode
				/// </java-name>
				[Dot42.DexImport("setWindowLayoutMode", "(II)V", AccessFlags = 1)]
				public virtual void SetWindowLayoutMode(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showAtLocation
				/// </java-name>
				[Dot42.DexImport("showAtLocation", "(Landroid/view/View;III)V", AccessFlags = 1)]
				public virtual void ShowAtLocation(global::Android.Views.View view, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showAsDropDown
				/// </java-name>
				[Dot42.DexImport("showAsDropDown", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void ShowAsDropDown(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showAsDropDown
				/// </java-name>
				[Dot42.DexImport("showAsDropDown", "(Landroid/view/View;II)V", AccessFlags = 1)]
				public virtual void ShowAsDropDown(global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMaxAvailableHeight
				/// </java-name>
				[Dot42.DexImport("getMaxAvailableHeight", "(Landroid/view/View;)I", AccessFlags = 1)]
				public virtual int GetMaxAvailableHeight(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMaxAvailableHeight
				/// </java-name>
				[Dot42.DexImport("getMaxAvailableHeight", "(Landroid/view/View;I)I", AccessFlags = 1)]
				public virtual int GetMaxAvailableHeight(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// dismiss
				/// </java-name>
				[Dot42.DexImport("dismiss", "()V", AccessFlags = 1)]
				public virtual void Dismiss() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDismissListener
				/// </java-name>
				[Dot42.DexImport("setOnDismissListener", "(Landroid/widget/PopupWindow$OnDismissListener;)V", AccessFlags = 1)]
				public virtual void SetOnDismissListener(global::Android.Widget.PopupWindow.IOnDismissListener onDismissListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "()V", AccessFlags = 1)]
				public virtual void Update() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(II)V", AccessFlags = 1)]
				public virtual void Update(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(IIII)V", AccessFlags = 1)]
				public virtual void Update(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(IIIIZ)V", AccessFlags = 1)]
				public virtual void Update(int int32, int int321, int int322, int int323, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/view/View;II)V", AccessFlags = 1)]
				public virtual void Update(global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// update
				/// </java-name>
				[Dot42.DexImport("update", "(Landroid/view/View;IIII)V", AccessFlags = 1)]
				public virtual void Update(global::Android.Views.View view, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBackground
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Background
				{
						[Dot42.DexImport("getBackground", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <java-name>
				/// getAnimationStyle
				/// </java-name>
				public virtual int AnimationStyle
				{
						[Dot42.DexImport("getAnimationStyle", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setAnimationStyle", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getContentView
				/// </java-name>
				public virtual global::Android.Views.View ContentView
				{
						[Dot42.DexImport("getContentView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
						[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isFocusable
				/// </java-name>
				public virtual bool IsFocusable
				{
						[Dot42.DexImport("isFocusable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInputMethodMode
				/// </java-name>
				public virtual int InputMethodMode
				{
						[Dot42.DexImport("getInputMethodMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setInputMethodMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSoftInputMode
				/// </java-name>
				public virtual int SoftInputMode
				{
						[Dot42.DexImport("getSoftInputMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSoftInputMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isTouchable
				/// </java-name>
				public virtual bool IsTouchable
				{
						[Dot42.DexImport("isTouchable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setTouchable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isOutsideTouchable
				/// </java-name>
				public virtual bool IsOutsideTouchable
				{
						[Dot42.DexImport("isOutsideTouchable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setOutsideTouchable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isClippingEnabled
				/// </java-name>
				public virtual bool IsClippingEnabled
				{
						[Dot42.DexImport("isClippingEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setClippingEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSplitTouchEnabled
				/// </java-name>
				public virtual bool IsSplitTouchEnabled
				{
						[Dot42.DexImport("isSplitTouchEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSplitTouchEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setHeight", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setWidth", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isShowing
				/// </java-name>
				public virtual bool IsShowing
				{
						[Dot42.DexImport("isShowing", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isAboveAnchor
				/// </java-name>
				public virtual bool IsAboveAnchor
				{
						[Dot42.DexImport("isAboveAnchor", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/widget/PopupWindow$OnDismissListener
				/// </java-name>
				[Dot42.DexImport("android/widget/PopupWindow$OnDismissListener", AccessFlags = 1545)]
				public partial interface IOnDismissListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDismiss
						/// </java-name>
						[Dot42.DexImport("onDismiss", "()V", AccessFlags = 1025)]
						void OnDismiss() /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/ProgressBar
		/// </java-name>
		[Dot42.DexImport("android/widget/ProgressBar", AccessFlags = 33)]
		public partial class ProgressBar : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ProgressBar(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ProgressBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ProgressBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// postInvalidate
				/// </java-name>
				[Dot42.DexImport("postInvalidate", "()V", AccessFlags = 1)]
				public override void PostInvalidate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementProgressBy
				/// </java-name>
				[Dot42.DexImport("incrementProgressBy", "(I)V", AccessFlags = 49)]
				public void IncrementProgressBy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// incrementSecondaryProgressBy
				/// </java-name>
				[Dot42.DexImport("incrementSecondaryProgressBy", "(I)V", AccessFlags = 49)]
				public void IncrementSecondaryProgressBy(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInterpolator(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void OnVisibilityChanged(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void InvalidateDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 36)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 36)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ProgressBar() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isIndeterminate
				/// </java-name>
				public virtual bool IsIndeterminate
				{
						[Dot42.DexImport("isIndeterminate", "()Z", AccessFlags = 33)]
						get{ return default(bool); }
						[Dot42.DexImport("setIndeterminate", "(Z)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getIndeterminateDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable IndeterminateDrawable
				{
						[Dot42.DexImport("getIndeterminateDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getProgressDrawable
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable ProgressDrawable
				{
						[Dot42.DexImport("getProgressDrawable", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
						[Dot42.DexImport("setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getProgress
				/// </java-name>
				public virtual int Progress
				{
						[Dot42.DexImport("getProgress", "()I", AccessFlags = 33)]
						get{ return default(int); }
						[Dot42.DexImport("setProgress", "(I)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getSecondaryProgress
				/// </java-name>
				public virtual int SecondaryProgress
				{
						[Dot42.DexImport("getSecondaryProgress", "()I", AccessFlags = 33)]
						get{ return default(int); }
						[Dot42.DexImport("setSecondaryProgress", "(I)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getMax
				/// </java-name>
				public virtual int Max
				{
						[Dot42.DexImport("getMax", "()I", AccessFlags = 33)]
						get{ return default(int); }
						[Dot42.DexImport("setMax", "(I)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// getInterpolator
				/// </java-name>
				public virtual global::Android.Views.Animations.IInterpolator Interpolator
				{
						[Dot42.DexImport("getInterpolator", "()Landroid/view/animation/Interpolator;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.IInterpolator); }
						[Dot42.DexImport("setInterpolator", "(Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setVisibility
				/// </java-name>
				public override int Visibility
				{
						[Dot42.DexImport("setVisibility", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/QuickContactBadge
		/// </java-name>
		[Dot42.DexImport("android/widget/QuickContactBadge", AccessFlags = 33)]
		public partial class QuickContactBadge : global::Android.Widget.ImageView, global::Android.Views.View.IOnClickListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// mExcludeMimes
				/// </java-name>
				[Dot42.DexImport("mExcludeMimes", "[Ljava/lang/String;", AccessFlags = 4)]
				protected internal string[] MExcludeMimes;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public QuickContactBadge(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public QuickContactBadge(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public QuickContactBadge(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMode
				/// </java-name>
				[Dot42.DexImport("setMode", "(I)V", AccessFlags = 1)]
				public virtual void SetMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageToDefault
				/// </java-name>
				[Dot42.DexImport("setImageToDefault", "()V", AccessFlags = 1)]
				public virtual void SetImageToDefault() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assignContactUri
				/// </java-name>
				[Dot42.DexImport("assignContactUri", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void AssignContactUri(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assignContactFromEmail
				/// </java-name>
				[Dot42.DexImport("assignContactFromEmail", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void AssignContactFromEmail(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// assignContactFromPhone
				/// </java-name>
				[Dot42.DexImport("assignContactFromPhone", "(Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void AssignContactFromPhone(string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setExcludeMimes
				/// </java-name>
				[Dot42.DexImport("setExcludeMimes", "([Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetExcludeMimes(string[] @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal QuickContactBadge() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/RadioButton
		/// </java-name>
		[Dot42.DexImport("android/widget/RadioButton", AccessFlags = 33)]
		public partial class RadioButton : global::Android.Widget.CompoundButton
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RadioButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RadioButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public RadioButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1)]
				public override void Toggle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RadioButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/RadioGroup
		/// </java-name>
		[Dot42.DexImport("android/widget/RadioGroup", AccessFlags = 33)]
		public partial class RadioGroup : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RadioGroup(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RadioGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", AccessFlags = 1)]
				public override void SetOnHierarchyChangeListener(global::Android.Views.ViewGroup.IOnHierarchyChangeListener onHierarchyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// check
				/// </java-name>
				[Dot42.DexImport("check", "(I)V", AccessFlags = 1)]
				public virtual void Check(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearCheck
				/// </java-name>
				[Dot42.DexImport("clearCheck", "()V", AccessFlags = 1)]
				public virtual void ClearCheck() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnCheckedChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnCheckedChangeListener", "(Landroid/widget/RadioGroup$OnCheckedChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnCheckedChangeListener(global::Android.Widget.RadioGroup.IOnCheckedChangeListener onCheckedChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RadioGroup$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.RadioGroup.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.RadioGroup.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RadioGroup() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCheckedRadioButtonId
				/// </java-name>
				public virtual int CheckedRadioButtonId
				{
						[Dot42.DexImport("getCheckedRadioButtonId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/widget/RadioGroup$OnCheckedChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/RadioGroup$OnCheckedChangeListener", AccessFlags = 1545)]
				public partial interface IOnCheckedChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCheckedChanged
						/// </java-name>
						[Dot42.DexImport("onCheckedChanged", "(Landroid/widget/RadioGroup;I)V", AccessFlags = 1025)]
						void OnCheckedChanged(global::Android.Widget.RadioGroup radioGroup, int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/RadioGroup$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/RadioGroup$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Widget.LinearLayout.LayoutParams
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(IIF)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal override void SetBaseAttributes(global::Android.Content.Res.TypedArray typedArray, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/RatingBar
		/// </java-name>
		[Dot42.DexImport("android/widget/RatingBar", AccessFlags = 33)]
		public partial class RatingBar : global::Android.Widget.AbsSeekBar
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public RatingBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RatingBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RatingBar(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIsIndicator
				/// </java-name>
				[Dot42.DexImport("setIsIndicator", "(Z)V", AccessFlags = 1)]
				public virtual void SetIsIndicator(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 36)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RatingBar() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getOnRatingBarChangeListener
				/// </java-name>
				public virtual global::Android.Widget.RatingBar.IOnRatingBarChangeListener OnRatingBarChangeListener
				{
						[Dot42.DexImport("getOnRatingBarChangeListener", "()Landroid/widget/RatingBar$OnRatingBarChangeListener;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.RatingBar.IOnRatingBarChangeListener); }
						[Dot42.DexImport("setOnRatingBarChangeListener", "(Landroid/widget/RatingBar$OnRatingBarChangeListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isIndicator
				/// </java-name>
				public virtual bool IsIndicator
				{
						[Dot42.DexImport("isIndicator", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getNumStars
				/// </java-name>
				public virtual int NumStars
				{
						[Dot42.DexImport("getNumStars", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNumStars", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRating
				/// </java-name>
				public virtual float Rating
				{
						[Dot42.DexImport("getRating", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setRating", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getStepSize
				/// </java-name>
				public virtual float StepSize
				{
						[Dot42.DexImport("getStepSize", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setStepSize", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setMax
				/// </java-name>
				public override int Max
				{
						[Dot42.DexImport("setMax", "(I)V", AccessFlags = 33)]
						set{ }
				}

				/// <java-name>
				/// android/widget/RatingBar$OnRatingBarChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/RatingBar$OnRatingBarChangeListener", AccessFlags = 1545)]
				public partial interface IOnRatingBarChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onRatingChanged
						/// </java-name>
						[Dot42.DexImport("onRatingChanged", "(Landroid/widget/RatingBar;FZ)V", AccessFlags = 1025)]
						void OnRatingChanged(global::Android.Widget.RatingBar ratingBar, float single, bool boolean) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/RelativeLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/RelativeLayout", AccessFlags = 33)]
		public partial class RelativeLayout : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TRUE
				/// </java-name>
				[Dot42.DexImport("TRUE", "I", AccessFlags = 25)]
				public const int TRUE = -1;
				/// <java-name>
				/// LEFT_OF
				/// </java-name>
				[Dot42.DexImport("LEFT_OF", "I", AccessFlags = 25)]
				public const int LEFT_OF = 0;
				/// <java-name>
				/// RIGHT_OF
				/// </java-name>
				[Dot42.DexImport("RIGHT_OF", "I", AccessFlags = 25)]
				public const int RIGHT_OF = 1;
				/// <java-name>
				/// ABOVE
				/// </java-name>
				[Dot42.DexImport("ABOVE", "I", AccessFlags = 25)]
				public const int ABOVE = 2;
				/// <java-name>
				/// BELOW
				/// </java-name>
				[Dot42.DexImport("BELOW", "I", AccessFlags = 25)]
				public const int BELOW = 3;
				/// <java-name>
				/// ALIGN_BASELINE
				/// </java-name>
				[Dot42.DexImport("ALIGN_BASELINE", "I", AccessFlags = 25)]
				public const int ALIGN_BASELINE = 4;
				/// <java-name>
				/// ALIGN_LEFT
				/// </java-name>
				[Dot42.DexImport("ALIGN_LEFT", "I", AccessFlags = 25)]
				public const int ALIGN_LEFT = 5;
				/// <java-name>
				/// ALIGN_TOP
				/// </java-name>
				[Dot42.DexImport("ALIGN_TOP", "I", AccessFlags = 25)]
				public const int ALIGN_TOP = 6;
				/// <java-name>
				/// ALIGN_RIGHT
				/// </java-name>
				[Dot42.DexImport("ALIGN_RIGHT", "I", AccessFlags = 25)]
				public const int ALIGN_RIGHT = 7;
				/// <java-name>
				/// ALIGN_BOTTOM
				/// </java-name>
				[Dot42.DexImport("ALIGN_BOTTOM", "I", AccessFlags = 25)]
				public const int ALIGN_BOTTOM = 8;
				/// <java-name>
				/// ALIGN_PARENT_LEFT
				/// </java-name>
				[Dot42.DexImport("ALIGN_PARENT_LEFT", "I", AccessFlags = 25)]
				public const int ALIGN_PARENT_LEFT = 9;
				/// <java-name>
				/// ALIGN_PARENT_TOP
				/// </java-name>
				[Dot42.DexImport("ALIGN_PARENT_TOP", "I", AccessFlags = 25)]
				public const int ALIGN_PARENT_TOP = 10;
				/// <java-name>
				/// ALIGN_PARENT_RIGHT
				/// </java-name>
				[Dot42.DexImport("ALIGN_PARENT_RIGHT", "I", AccessFlags = 25)]
				public const int ALIGN_PARENT_RIGHT = 11;
				/// <java-name>
				/// ALIGN_PARENT_BOTTOM
				/// </java-name>
				[Dot42.DexImport("ALIGN_PARENT_BOTTOM", "I", AccessFlags = 25)]
				public const int ALIGN_PARENT_BOTTOM = 12;
				/// <java-name>
				/// CENTER_IN_PARENT
				/// </java-name>
				[Dot42.DexImport("CENTER_IN_PARENT", "I", AccessFlags = 25)]
				public const int CENTER_IN_PARENT = 13;
				/// <java-name>
				/// CENTER_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("CENTER_HORIZONTAL", "I", AccessFlags = 25)]
				public const int CENTER_HORIZONTAL = 14;
				/// <java-name>
				/// CENTER_VERTICAL
				/// </java-name>
				[Dot42.DexImport("CENTER_VERTICAL", "I", AccessFlags = 25)]
				public const int CENTER_VERTICAL = 15;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public RelativeLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public RelativeLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public RelativeLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public override bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setIgnoreGravity
				/// </java-name>
				[Dot42.DexImport("setIgnoreGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetIgnoreGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHorizontalGravity
				/// </java-name>
				[Dot42.DexImport("setHorizontalGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetHorizontalGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVerticalGravity
				/// </java-name>
				[Dot42.DexImport("setVerticalGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetVerticalGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RelativeLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.RelativeLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.RelativeLayout.LayoutParams);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RelativeLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/widget/RelativeLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/RelativeLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Views.ViewGroup.MarginLayoutParams
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// alignWithParent
						/// </java-name>
						[Dot42.DexImport("alignWithParent", "Z", AccessFlags = 1)]
						public bool AlignWithParent;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// debug
						/// </java-name>
						[Dot42.DexImport("debug", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
						public virtual string Debug(string @string) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

						/// <java-name>
						/// addRule
						/// </java-name>
						[Dot42.DexImport("addRule", "(I)V", AccessFlags = 1)]
						public virtual void AddRule(int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// addRule
						/// </java-name>
						[Dot42.DexImport("addRule", "(II)V", AccessFlags = 1)]
						public virtual void AddRule(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getRules
						/// </java-name>
						public virtual int[] Rules
						{
								[Dot42.DexImport("getRules", "()[I", AccessFlags = 1)]
								get{ return default(int[]); }
						}

				}

		}

		/// <java-name>
		/// android/widget/RemoteViews
		/// </java-name>
		[Dot42.DexImport("android/widget/RemoteViews", AccessFlags = 33)]
		public partial class RemoteViews : global::Android.OS.IParcelable, global::Android.Views.LayoutInflater.IFilter
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Widget.RemoteViews> CREATOR;
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public RemoteViews(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public RemoteViews(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/widget/RemoteViews;", AccessFlags = 1)]
				public virtual global::Android.Widget.RemoteViews Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.RemoteViews);
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void AddView(int int32, global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "(I)V", AccessFlags = 1)]
				public virtual void RemoveAllViews(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showNext
				/// </java-name>
				[Dot42.DexImport("showNext", "(I)V", AccessFlags = 1)]
				public virtual void ShowNext(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showPrevious
				/// </java-name>
				[Dot42.DexImport("showPrevious", "(I)V", AccessFlags = 1)]
				public virtual void ShowPrevious(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDisplayedChild
				/// </java-name>
				[Dot42.DexImport("setDisplayedChild", "(II)V", AccessFlags = 1)]
				public virtual void SetDisplayedChild(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setViewVisibility
				/// </java-name>
				[Dot42.DexImport("setViewVisibility", "(II)V", AccessFlags = 1)]
				public virtual void SetViewVisibility(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextViewText
				/// </java-name>
				[Dot42.DexImport("setTextViewText", "(ILjava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetTextViewText(int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageViewResource
				/// </java-name>
				[Dot42.DexImport("setImageViewResource", "(II)V", AccessFlags = 1)]
				public virtual void SetImageViewResource(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageViewUri
				/// </java-name>
				[Dot42.DexImport("setImageViewUri", "(ILandroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetImageViewUri(int int32, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImageViewBitmap
				/// </java-name>
				[Dot42.DexImport("setImageViewBitmap", "(ILandroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetImageViewBitmap(int int32, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEmptyView
				/// </java-name>
				[Dot42.DexImport("setEmptyView", "(II)V", AccessFlags = 1)]
				public virtual void SetEmptyView(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChronometer
				/// </java-name>
				[Dot42.DexImport("setChronometer", "(IJLjava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetChronometer(int int32, long int64, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setProgressBar
				/// </java-name>
				[Dot42.DexImport("setProgressBar", "(IIIZ)V", AccessFlags = 1)]
				public virtual void SetProgressBar(int int32, int int321, int int322, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnClickPendingIntent
				/// </java-name>
				[Dot42.DexImport("setOnClickPendingIntent", "(ILandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetOnClickPendingIntent(int int32, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPendingIntentTemplate
				/// </java-name>
				[Dot42.DexImport("setPendingIntentTemplate", "(ILandroid/app/PendingIntent;)V", AccessFlags = 1)]
				public virtual void SetPendingIntentTemplate(int int32, global::Android.App.PendingIntent pendingIntent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnClickFillInIntent
				/// </java-name>
				[Dot42.DexImport("setOnClickFillInIntent", "(ILandroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetOnClickFillInIntent(int int32, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextColor
				/// </java-name>
				[Dot42.DexImport("setTextColor", "(II)V", AccessFlags = 1)]
				public virtual void SetTextColor(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRemoteAdapter
				/// </java-name>
				[Dot42.DexImport("setRemoteAdapter", "(IILandroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetRemoteAdapter(int int32, int int321, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRemoteAdapter
				/// </java-name>
				[Dot42.DexImport("setRemoteAdapter", "(ILandroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetRemoteAdapter(int int32, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScrollPosition
				/// </java-name>
				[Dot42.DexImport("setScrollPosition", "(II)V", AccessFlags = 1)]
				public virtual void SetScrollPosition(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRelativeScrollPosition
				/// </java-name>
				[Dot42.DexImport("setRelativeScrollPosition", "(II)V", AccessFlags = 1)]
				public virtual void SetRelativeScrollPosition(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBoolean
				/// </java-name>
				[Dot42.DexImport("setBoolean", "(ILjava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetBoolean(int int32, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(ILjava/lang/String;B)V", AccessFlags = 1)]
				public virtual void SetByte(int int32, string @string, sbyte sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setByte
				/// </java-name>
				[Dot42.DexImport("setByte", "(ILjava/lang/String;B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetByte(int int32, string @string, byte @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setShort
				/// </java-name>
				[Dot42.DexImport("setShort", "(ILjava/lang/String;S)V", AccessFlags = 1)]
				public virtual void SetShort(int int32, string @string, short int16) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInt
				/// </java-name>
				[Dot42.DexImport("setInt", "(ILjava/lang/String;I)V", AccessFlags = 1)]
				public virtual void SetInt(int int32, string @string, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLong
				/// </java-name>
				[Dot42.DexImport("setLong", "(ILjava/lang/String;J)V", AccessFlags = 1)]
				public virtual void SetLong(int int32, string @string, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFloat
				/// </java-name>
				[Dot42.DexImport("setFloat", "(ILjava/lang/String;F)V", AccessFlags = 1)]
				public virtual void SetFloat(int int32, string @string, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDouble
				/// </java-name>
				[Dot42.DexImport("setDouble", "(ILjava/lang/String;D)V", AccessFlags = 1)]
				public virtual void SetDouble(int int32, string @string, double @double) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChar
				/// </java-name>
				[Dot42.DexImport("setChar", "(ILjava/lang/String;C)V", AccessFlags = 1)]
				public virtual void SetChar(int int32, string @string, char @char) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setString
				/// </java-name>
				[Dot42.DexImport("setString", "(ILjava/lang/String;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetString(int int32, string @string, string string1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCharSequence
				/// </java-name>
				[Dot42.DexImport("setCharSequence", "(ILjava/lang/String;Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetCharSequence(int int32, string @string, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUri
				/// </java-name>
				[Dot42.DexImport("setUri", "(ILjava/lang/String;Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetUri(int int32, string @string, global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBitmap
				/// </java-name>
				[Dot42.DexImport("setBitmap", "(ILjava/lang/String;Landroid/graphics/Bitmap;)V", AccessFlags = 1)]
				public virtual void SetBitmap(int int32, string @string, global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBundle
				/// </java-name>
				[Dot42.DexImport("setBundle", "(ILjava/lang/String;Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void SetBundle(int int32, string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIntent
				/// </java-name>
				[Dot42.DexImport("setIntent", "(ILjava/lang/String;Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetIntent(int int32, string @string, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setContentDescription
				/// </java-name>
				[Dot42.DexImport("setContentDescription", "(ILjava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetContentDescription(int int32, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(Landroid/content/Context;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View Apply(global::Android.Content.Context context, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// reapply
				/// </java-name>
				[Dot42.DexImport("reapply", "(Landroid/content/Context;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void Reapply(global::Android.Content.Context context, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLoadClass
				/// </java-name>
				[Dot42.DexImport("onLoadClass", "(Ljava/lang/Class;)Z", AccessFlags = 1)]
				public virtual bool OnLoadClass(global::System.Type type) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal RemoteViews() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPackage
				/// </java-name>
				public virtual string Package
				{
						[Dot42.DexImport("getPackage", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getLayoutId
				/// </java-name>
				public virtual int LayoutId
				{
						[Dot42.DexImport("getLayoutId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/widget/RemoteViews$ActionException
				/// </java-name>
				[Dot42.DexImport("android/widget/RemoteViews$ActionException", AccessFlags = 9)]
				public partial class ActionException : global::System.SystemException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/Exception;)V", AccessFlags = 1)]
						public ActionException(global::System.Exception exception) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public ActionException(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal ActionException() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/widget/RemoteViews$RemoteView
				/// </java-name>
				[Dot42.DexImport("android/widget/RemoteViews$RemoteView", AccessFlags = 9737)]
				public partial interface IRemoteView : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/RemoteViewsService
		/// </java-name>
		[Dot42.DexImport("android/widget/RemoteViewsService", AccessFlags = 1057)]
		public abstract partial class RemoteViewsService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public RemoteViewsService() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 1)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <java-name>
				/// onGetViewFactory
				/// </java-name>
				[Dot42.DexImport("onGetViewFactory", "(Landroid/content/Intent;)Landroid/widget/RemoteViewsService$RemoteViewsFactory;", AccessFlags = 1025)]
				public abstract global::Android.Widget.RemoteViewsService.IRemoteViewsFactory OnGetViewFactory(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// android/widget/RemoteViewsService$RemoteViewsFactory
				/// </java-name>
				[Dot42.DexImport("android/widget/RemoteViewsService$RemoteViewsFactory", AccessFlags = 1545)]
				public partial interface IRemoteViewsFactory
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCreate
						/// </java-name>
						[Dot42.DexImport("onCreate", "()V", AccessFlags = 1025)]
						void OnCreate() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDataSetChanged
						/// </java-name>
						[Dot42.DexImport("onDataSetChanged", "()V", AccessFlags = 1025)]
						void OnDataSetChanged() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDestroy
						/// </java-name>
						[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1025)]
						void OnDestroy() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// getViewAt
						/// </java-name>
						[Dot42.DexImport("getViewAt", "(I)Landroid/widget/RemoteViews;", AccessFlags = 1025)]
						global::Android.Widget.RemoteViews GetViewAt(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// getItemId
						/// </java-name>
						[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1025)]
						long GetItemId(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// getCount
						/// </java-name>
						int Count
						{
								[Dot42.DexImport("getCount", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getLoadingView
						/// </java-name>
						global::Android.Widget.RemoteViews LoadingView
						{
								[Dot42.DexImport("getLoadingView", "()Landroid/widget/RemoteViews;", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// getViewTypeCount
						/// </java-name>
						int ViewTypeCount
						{
								[Dot42.DexImport("getViewTypeCount", "()I", AccessFlags = 1025)]
								get;
						}

						/// <java-name>
						/// hasStableIds
						/// </java-name>
						bool HasStableIds
						{
								[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1025)]
								get;
						}

				}

		}

		/// <java-name>
		/// android/widget/ResourceCursorAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ResourceCursorAdapter", AccessFlags = 1057)]
		public abstract partial class ResourceCursorAdapter : global::Android.Widget.CursorAdapter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/database/Cursor;)V", AccessFlags = 1)]
				public ResourceCursorAdapter(global::Android.Content.Context context, int int32, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/database/Cursor;Z)V", AccessFlags = 1)]
				public ResourceCursorAdapter(global::Android.Content.Context context, int int32, global::Android.Database.ICursor cursor, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/database/Cursor;I)V", AccessFlags = 1)]
				public ResourceCursorAdapter(global::Android.Content.Context context, int int32, global::Android.Database.ICursor cursor, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newView
				/// </java-name>
				[Dot42.DexImport("newView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landr" +
    "oid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View NewView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newDropDownView
				/// </java-name>
				[Dot42.DexImport("newDropDownView", "(Landroid/content/Context;Landroid/database/Cursor;Landroid/view/ViewGroup;)Landr" +
    "oid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View NewDropDownView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setViewResource
				/// </java-name>
				[Dot42.DexImport("setViewResource", "(I)V", AccessFlags = 1)]
				public virtual void SetViewResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDropDownViewResource
				/// </java-name>
				[Dot42.DexImport("setDropDownViewResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDropDownViewResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ResourceCursorAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/ResourceCursorTreeAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/ResourceCursorTreeAdapter", AccessFlags = 1057)]
		public abstract partial class ResourceCursorTreeAdapter : global::Android.Widget.CursorTreeAdapter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;IIII)V", AccessFlags = 1)]
				public ResourceCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;III)V", AccessFlags = 1)]
				public ResourceCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;II)V", AccessFlags = 1)]
				public ResourceCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newChildView
				/// </java-name>
				[Dot42.DexImport("newChildView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Land" +
    "roid/view/View;", AccessFlags = 1)]
				protected internal override global::Android.Views.View NewChildView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newGroupView
				/// </java-name>
				[Dot42.DexImport("newGroupView", "(Landroid/content/Context;Landroid/database/Cursor;ZLandroid/view/ViewGroup;)Land" +
    "roid/view/View;", AccessFlags = 1)]
				protected internal override global::Android.Views.View NewGroupView(global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ResourceCursorTreeAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/Scroller
		/// </java-name>
		[Dot42.DexImport("android/widget/Scroller", AccessFlags = 33)]
		public partial class Scroller
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Scroller(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;)V", AccessFlags = 1)]
				public Scroller(global::Android.Content.Context context, global::Android.Views.Animations.IInterpolator interpolator) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/animation/Interpolator;Z)V", AccessFlags = 1)]
				public Scroller(global::Android.Content.Context context, global::Android.Views.Animations.IInterpolator interpolator, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFriction
				/// </java-name>
				[Dot42.DexImport("setFriction", "(F)V", AccessFlags = 17)]
				public void SetFriction(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forceFinished
				/// </java-name>
				[Dot42.DexImport("forceFinished", "(Z)V", AccessFlags = 17)]
				public void ForceFinished(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeScrollOffset", "()Z", AccessFlags = 1)]
				public virtual bool ComputeScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startScroll
				/// </java-name>
				[Dot42.DexImport("startScroll", "(IIII)V", AccessFlags = 1)]
				public virtual void StartScroll(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startScroll
				/// </java-name>
				[Dot42.DexImport("startScroll", "(IIIII)V", AccessFlags = 1)]
				public virtual void StartScroll(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(IIIIIIII)V", AccessFlags = 1)]
				public virtual void Fling(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// abortAnimation
				/// </java-name>
				[Dot42.DexImport("abortAnimation", "()V", AccessFlags = 1)]
				public virtual void AbortAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// extendDuration
				/// </java-name>
				[Dot42.DexImport("extendDuration", "(I)V", AccessFlags = 1)]
				public virtual void ExtendDuration(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// timePassed
				/// </java-name>
				[Dot42.DexImport("timePassed", "()I", AccessFlags = 1)]
				public virtual int TimePassed() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Scroller() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isFinished
				/// </java-name>
				public bool IsFinished
				{
						[Dot42.DexImport("isFinished", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public int Duration
				{
						[Dot42.DexImport("getDuration", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCurrX
				/// </java-name>
				public int CurrX
				{
						[Dot42.DexImport("getCurrX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCurrY
				/// </java-name>
				public int CurrY
				{
						[Dot42.DexImport("getCurrY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCurrVelocity
				/// </java-name>
				public virtual float CurrVelocity
				{
						[Dot42.DexImport("getCurrVelocity", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getStartX
				/// </java-name>
				public int StartX
				{
						[Dot42.DexImport("getStartX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getStartY
				/// </java-name>
				public int StartY
				{
						[Dot42.DexImport("getStartY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFinalX
				/// </java-name>
				public virtual int FinalX
				{
						[Dot42.DexImport("getFinalX", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setFinalX", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFinalY
				/// </java-name>
				public virtual int FinalY
				{
						[Dot42.DexImport("getFinalY", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setFinalY", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/ScrollView
		/// </java-name>
		[Dot42.DexImport("android/widget/ScrollView", AccessFlags = 33)]
		public partial class ScrollView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ScrollView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ScrollView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ScrollView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public override bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// executeKeyEvent
				/// </java-name>
				[Dot42.DexImport("executeKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool ExecuteKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestDisallowInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("requestDisallowInterceptTouchEvent", "(Z)V", AccessFlags = 1)]
				public override void RequestDisallowInterceptTouchEvent(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal override void OnOverScrolled(int int32, int int321, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// pageScroll
				/// </java-name>
				[Dot42.DexImport("pageScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool PageScroll(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// fullScroll
				/// </java-name>
				[Dot42.DexImport("fullScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool FullScroll(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// arrowScroll
				/// </java-name>
				[Dot42.DexImport("arrowScroll", "(I)Z", AccessFlags = 1)]
				public virtual bool ArrowScroll(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// smoothScrollBy
				/// </java-name>
				[Dot42.DexImport("smoothScrollBy", "(II)V", AccessFlags = 17)]
				public void SmoothScrollBy(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// smoothScrollTo
				/// </java-name>
				[Dot42.DexImport("smoothScrollTo", "(II)V", AccessFlags = 17)]
				public void SmoothScrollTo(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// measureChild
				/// </java-name>
				[Dot42.DexImport("measureChild", "(Landroid/view/View;II)V", AccessFlags = 4)]
				protected internal override void MeasureChild(global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// measureChildWithMargins
				/// </java-name>
				[Dot42.DexImport("measureChildWithMargins", "(Landroid/view/View;IIII)V", AccessFlags = 4)]
				protected internal override void MeasureChildWithMargins(global::Android.Views.View view, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScrollDeltaToGetChildRectOnScreen
				/// </java-name>
				[Dot42.DexImport("computeScrollDeltaToGetChildRectOnScreen", "(Landroid/graphics/Rect;)I", AccessFlags = 4)]
				protected internal virtual int ComputeScrollDeltaToGetChildRectOnScreen(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// requestChildFocus
				/// </java-name>
				[Dot42.DexImport("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public override void RequestChildFocus(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRequestFocusInDescendants
				/// </java-name>
				[Dot42.DexImport("onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal override bool OnRequestFocusInDescendants(int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public override bool RequestChildRectangleOnScreen(global::Android.Views.View view, global::Android.Graphics.Rect rect, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fling
				/// </java-name>
				[Dot42.DexImport("fling", "(I)V", AccessFlags = 1)]
				public virtual void Fling(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollTo
				/// </java-name>
				[Dot42.DexImport("scrollTo", "(II)V", AccessFlags = 1)]
				public override void ScrollTo(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScrollView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTopFadingEdgeStrength
				/// </java-name>
				protected internal override float TopFadingEdgeStrength
				{
						[Dot42.DexImport("getTopFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getBottomFadingEdgeStrength
				/// </java-name>
				protected internal override float BottomFadingEdgeStrength
				{
						[Dot42.DexImport("getBottomFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getMaxScrollAmount
				/// </java-name>
				public virtual int MaxScrollAmount
				{
						[Dot42.DexImport("getMaxScrollAmount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isFillViewport
				/// </java-name>
				public virtual bool IsFillViewport
				{
						[Dot42.DexImport("isFillViewport", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFillViewport", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSmoothScrollingEnabled
				/// </java-name>
				public virtual bool IsSmoothScrollingEnabled
				{
						[Dot42.DexImport("isSmoothScrollingEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSmoothScrollingEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setOverScrollMode
				/// </java-name>
				public override int OverScrollMode
				{
						[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/SearchView
		/// </java-name>
		[Dot42.DexImport("android/widget/SearchView", AccessFlags = 33)]
		public partial class SearchView : global::Android.Widget.LinearLayout, global::Android.Views.ICollapsibleActionView
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public SearchView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public SearchView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSearchableInfo
				/// </java-name>
				[Dot42.DexImport("setSearchableInfo", "(Landroid/app/SearchableInfo;)V", AccessFlags = 1)]
				public virtual void SetSearchableInfo(global::Android.App.SearchableInfo searchableInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImeOptions
				/// </java-name>
				[Dot42.DexImport("setImeOptions", "(I)V", AccessFlags = 1)]
				public virtual void SetImeOptions(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInputType
				/// </java-name>
				[Dot42.DexImport("setInputType", "(I)V", AccessFlags = 1)]
				public virtual void SetInputType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnQueryTextListener
				/// </java-name>
				[Dot42.DexImport("setOnQueryTextListener", "(Landroid/widget/SearchView$OnQueryTextListener;)V", AccessFlags = 1)]
				public virtual void SetOnQueryTextListener(global::Android.Widget.SearchView.IOnQueryTextListener onQueryTextListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnCloseListener
				/// </java-name>
				[Dot42.DexImport("setOnCloseListener", "(Landroid/widget/SearchView$OnCloseListener;)V", AccessFlags = 1)]
				public virtual void SetOnCloseListener(global::Android.Widget.SearchView.IOnCloseListener onCloseListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnQueryTextFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnQueryTextFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnQueryTextFocusChangeListener(global::Android.Views.View.IOnFocusChangeListener onFocusChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnSuggestionListener
				/// </java-name>
				[Dot42.DexImport("setOnSuggestionListener", "(Landroid/widget/SearchView$OnSuggestionListener;)V", AccessFlags = 1)]
				public virtual void SetOnSuggestionListener(global::Android.Widget.SearchView.IOnSuggestionListener onSuggestionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnSearchClickListener
				/// </java-name>
				[Dot42.DexImport("setOnSearchClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnSearchClickListener(global::Android.Views.View.IOnClickListener onClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setQuery
				/// </java-name>
				[Dot42.DexImport("setQuery", "(Ljava/lang/CharSequence;Z)V", AccessFlags = 1)]
				public virtual void SetQuery(global::Java.Lang.ICharSequence charSequence, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setQueryHint
				/// </java-name>
				[Dot42.DexImport("setQueryHint", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetQueryHint(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIconifiedByDefault
				/// </java-name>
				[Dot42.DexImport("setIconifiedByDefault", "(Z)V", AccessFlags = 1)]
				public virtual void SetIconifiedByDefault(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxWidth
				/// </java-name>
				[Dot42.DexImport("setMaxWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActionViewCollapsed
				/// </java-name>
				[Dot42.DexImport("onActionViewCollapsed", "()V", AccessFlags = 1)]
				public virtual void OnActionViewCollapsed() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onActionViewExpanded
				/// </java-name>
				[Dot42.DexImport("onActionViewExpanded", "()V", AccessFlags = 1)]
				public virtual void OnActionViewExpanded() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SearchView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getQuery
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Query
				{
						[Dot42.DexImport("getQuery", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <java-name>
				/// isIconfiedByDefault
				/// </java-name>
				public virtual bool IsIconfiedByDefault
				{
						[Dot42.DexImport("isIconfiedByDefault", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isIconified
				/// </java-name>
				public virtual bool IsIconified
				{
						[Dot42.DexImport("isIconified", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setIconified", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSubmitButtonEnabled
				/// </java-name>
				public virtual bool IsSubmitButtonEnabled
				{
						[Dot42.DexImport("isSubmitButtonEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSubmitButtonEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isQueryRefinementEnabled
				/// </java-name>
				public virtual bool IsQueryRefinementEnabled
				{
						[Dot42.DexImport("isQueryRefinementEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setQueryRefinementEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSuggestionsAdapter
				/// </java-name>
				public virtual global::Android.Widget.CursorAdapter SuggestionsAdapter
				{
						[Dot42.DexImport("getSuggestionsAdapter", "()Landroid/widget/CursorAdapter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.CursorAdapter); }
						[Dot42.DexImport("setSuggestionsAdapter", "(Landroid/widget/CursorAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/SearchView$OnSuggestionListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SearchView$OnSuggestionListener", AccessFlags = 1545)]
				public partial interface IOnSuggestionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSuggestionSelect
						/// </java-name>
						[Dot42.DexImport("onSuggestionSelect", "(I)Z", AccessFlags = 1025)]
						bool OnSuggestionSelect(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onSuggestionClick
						/// </java-name>
						[Dot42.DexImport("onSuggestionClick", "(I)Z", AccessFlags = 1025)]
						bool OnSuggestionClick(int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/SearchView$OnCloseListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SearchView$OnCloseListener", AccessFlags = 1545)]
				public partial interface IOnCloseListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onClose
						/// </java-name>
						[Dot42.DexImport("onClose", "()Z", AccessFlags = 1025)]
						bool OnClose() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/SearchView$OnQueryTextListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SearchView$OnQueryTextListener", AccessFlags = 1545)]
				public partial interface IOnQueryTextListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onQueryTextSubmit
						/// </java-name>
						[Dot42.DexImport("onQueryTextSubmit", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
						bool OnQueryTextSubmit(string @string) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onQueryTextChange
						/// </java-name>
						[Dot42.DexImport("onQueryTextChange", "(Ljava/lang/String;)Z", AccessFlags = 1025)]
						bool OnQueryTextChange(string @string) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/SeekBar
		/// </java-name>
		[Dot42.DexImport("android/widget/SeekBar", AccessFlags = 33)]
		public partial class SeekBar : global::Android.Widget.AbsSeekBar
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public SeekBar(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public SeekBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public SeekBar(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnSeekBarChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnSeekBarChangeListener", "(Landroid/widget/SeekBar$OnSeekBarChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnSeekBarChangeListener(global::Android.Widget.SeekBar.IOnSeekBarChangeListener onSeekBarChangeListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SeekBar() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// android/widget/SeekBar$OnSeekBarChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SeekBar$OnSeekBarChangeListener", AccessFlags = 1545)]
				public partial interface IOnSeekBarChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onProgressChanged
						/// </java-name>
						[Dot42.DexImport("onProgressChanged", "(Landroid/widget/SeekBar;IZ)V", AccessFlags = 1025)]
						void OnProgressChanged(global::Android.Widget.SeekBar seekBar, int int32, bool boolean) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onStartTrackingTouch
						/// </java-name>
						[Dot42.DexImport("onStartTrackingTouch", "(Landroid/widget/SeekBar;)V", AccessFlags = 1025)]
						void OnStartTrackingTouch(global::Android.Widget.SeekBar seekBar) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onStopTrackingTouch
						/// </java-name>
						[Dot42.DexImport("onStopTrackingTouch", "(Landroid/widget/SeekBar;)V", AccessFlags = 1025)]
						void OnStopTrackingTouch(global::Android.Widget.SeekBar seekBar) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/ShareActionProvider
		/// </java-name>
		[Dot42.DexImport("android/widget/ShareActionProvider", AccessFlags = 33)]
		public partial class ShareActionProvider : global::Android.Views.ActionProvider
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_SHARE_HISTORY_FILE_NAME
				/// </java-name>
				[Dot42.DexImport("DEFAULT_SHARE_HISTORY_FILE_NAME", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DEFAULT_SHARE_HISTORY_FILE_NAME = "share_history.xml";
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ShareActionProvider(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnShareTargetSelectedListener
				/// </java-name>
				[Dot42.DexImport("setOnShareTargetSelectedListener", "(Landroid/widget/ShareActionProvider$OnShareTargetSelectedListener;)V", AccessFlags = 1)]
				public virtual void SetOnShareTargetSelectedListener(global::Android.Widget.ShareActionProvider.IOnShareTargetSelectedListener onShareTargetSelectedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateActionView
				/// </java-name>
				[Dot42.DexImport("onCreateActionView", "()Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View OnCreateActionView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onPrepareSubMenu
				/// </java-name>
				[Dot42.DexImport("onPrepareSubMenu", "(Landroid/view/SubMenu;)V", AccessFlags = 1)]
				public override void OnPrepareSubMenu(global::Android.Views.ISubMenu subMenu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setShareHistoryFileName
				/// </java-name>
				[Dot42.DexImport("setShareHistoryFileName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetShareHistoryFileName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setShareIntent
				/// </java-name>
				[Dot42.DexImport("setShareIntent", "(Landroid/content/Intent;)V", AccessFlags = 1)]
				public virtual void SetShareIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ShareActionProvider() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// hasSubMenu
				/// </java-name>
				public override bool HasSubMenu
				{
						[Dot42.DexImport("hasSubMenu", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/widget/ShareActionProvider$OnShareTargetSelectedListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ShareActionProvider$OnShareTargetSelectedListener", AccessFlags = 1545)]
				public partial interface IOnShareTargetSelectedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onShareTargetSelected
						/// </java-name>
						[Dot42.DexImport("onShareTargetSelected", "(Landroid/widget/ShareActionProvider;Landroid/content/Intent;)Z", AccessFlags = 1025)]
						bool OnShareTargetSelected(global::Android.Widget.ShareActionProvider shareActionProvider, global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/SimpleAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SimpleAdapter", AccessFlags = 33)]
		public partial class SimpleAdapter : global::Android.Widget.BaseAdapter, global::Android.Widget.IFilterable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[I)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/List<+Ljava/util/Map<Ljava/lang/String;*>;>;" +
    "I[Ljava/lang/String;[I)V")]
				public SimpleAdapter(global::Android.Content.Context context, global::Java.Util.IList<global::Java.Util.IMap<string, object>> list, int int32, string[] @string, int[] int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetItem(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getItemId
				/// </java-name>
				[Dot42.DexImport("getItemId", "(I)J", AccessFlags = 1)]
				public override long GetItemId(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getView
				/// </java-name>
				[Dot42.DexImport("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setDropDownViewResource
				/// </java-name>
				[Dot42.DexImport("setDropDownViewResource", "(I)V", AccessFlags = 1)]
				public virtual void SetDropDownViewResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDropDownView
				/// </java-name>
				[Dot42.DexImport("getDropDownView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetDropDownView(int int32, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setViewImage
				/// </java-name>
				[Dot42.DexImport("setViewImage", "(Landroid/widget/ImageView;I)V", AccessFlags = 1)]
				public virtual void SetViewImage(global::Android.Widget.ImageView imageView, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setViewImage
				/// </java-name>
				[Dot42.DexImport("setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewImage(global::Android.Widget.ImageView imageView, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setViewText
				/// </java-name>
				[Dot42.DexImport("setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewText(global::Android.Widget.TextView textView, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SimpleAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getCount
				/// </java-name>
				public override int Count
				{
						[Dot42.DexImport("getCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getViewBinder
				/// </java-name>
				public virtual global::Android.Widget.SimpleAdapter.IViewBinder ViewBinder
				{
						[Dot42.DexImport("getViewBinder", "()Landroid/widget/SimpleAdapter$ViewBinder;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.SimpleAdapter.IViewBinder); }
						[Dot42.DexImport("setViewBinder", "(Landroid/widget/SimpleAdapter$ViewBinder;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Widget.Filter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/widget/Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.Filter); }
				}

				/// <java-name>
				/// android/widget/SimpleAdapter$ViewBinder
				/// </java-name>
				[Dot42.DexImport("android/widget/SimpleAdapter$ViewBinder", AccessFlags = 1545)]
				public partial interface IViewBinder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// setViewValue
						/// </java-name>
						[Dot42.DexImport("setViewValue", "(Landroid/view/View;Ljava/lang/Object;Ljava/lang/String;)Z", AccessFlags = 1025)]
						bool SetViewValue(global::Android.Views.View view, object @object, string @string) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/SimpleCursorAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SimpleCursorAdapter", AccessFlags = 33)]
		public partial class SimpleCursorAdapter : global::Android.Widget.ResourceCursorAdapter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/database/Cursor;[Ljava/lang/String;[I)V", AccessFlags = 1)]
				public SimpleCursorAdapter(global::Android.Content.Context context, int int32, global::Android.Database.ICursor cursor, string[] @string, int[] int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;ILandroid/database/Cursor;[Ljava/lang/String;[II)V", AccessFlags = 1)]
				public SimpleCursorAdapter(global::Android.Content.Context context, int int32, global::Android.Database.ICursor cursor, string[] @string, int[] int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindView
				/// </java-name>
				[Dot42.DexImport("bindView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;)V", AccessFlags = 1)]
				public override void BindView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setViewImage
				/// </java-name>
				[Dot42.DexImport("setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewImage(global::Android.Widget.ImageView imageView, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setViewText
				/// </java-name>
				[Dot42.DexImport("setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewText(global::Android.Widget.TextView textView, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// convertToString
				/// </java-name>
				[Dot42.DexImport("convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", AccessFlags = 1)]
				public override global::Java.Lang.ICharSequence ConvertToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <java-name>
				/// swapCursor
				/// </java-name>
				[Dot42.DexImport("swapCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", AccessFlags = 1)]
				public override global::Android.Database.ICursor SwapCursor(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Database.ICursor);
				}

				/// <java-name>
				/// changeCursorAndColumns
				/// </java-name>
				[Dot42.DexImport("changeCursorAndColumns", "(Landroid/database/Cursor;[Ljava/lang/String;[I)V", AccessFlags = 1)]
				public virtual void ChangeCursorAndColumns(global::Android.Database.ICursor cursor, string[] @string, int[] int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SimpleCursorAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getViewBinder
				/// </java-name>
				public virtual global::Android.Widget.SimpleCursorAdapter.IViewBinder ViewBinder
				{
						[Dot42.DexImport("getViewBinder", "()Landroid/widget/SimpleCursorAdapter$ViewBinder;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.SimpleCursorAdapter.IViewBinder); }
						[Dot42.DexImport("setViewBinder", "(Landroid/widget/SimpleCursorAdapter$ViewBinder;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getStringConversionColumn
				/// </java-name>
				public virtual int StringConversionColumn
				{
						[Dot42.DexImport("getStringConversionColumn", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setStringConversionColumn", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCursorToStringConverter
				/// </java-name>
				public virtual global::Android.Widget.SimpleCursorAdapter.ICursorToStringConverter CursorToStringConverter
				{
						[Dot42.DexImport("getCursorToStringConverter", "()Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.SimpleCursorAdapter.ICursorToStringConverter); }
						[Dot42.DexImport("setCursorToStringConverter", "(Landroid/widget/SimpleCursorAdapter$CursorToStringConverter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/SimpleCursorAdapter$CursorToStringConverter
				/// </java-name>
				[Dot42.DexImport("android/widget/SimpleCursorAdapter$CursorToStringConverter", AccessFlags = 1545)]
				public partial interface ICursorToStringConverter
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// convertToString
						/// </java-name>
						[Dot42.DexImport("convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", AccessFlags = 1025)]
						global::Java.Lang.ICharSequence ConvertToString(global::Android.Database.ICursor cursor) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/SimpleCursorAdapter$ViewBinder
				/// </java-name>
				[Dot42.DexImport("android/widget/SimpleCursorAdapter$ViewBinder", AccessFlags = 1545)]
				public partial interface IViewBinder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// setViewValue
						/// </java-name>
						[Dot42.DexImport("setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", AccessFlags = 1025)]
						bool SetViewValue(global::Android.Views.View view, global::Android.Database.ICursor cursor, int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/SimpleCursorTreeAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SimpleCursorTreeAdapter", AccessFlags = 1057)]
		public abstract partial class SimpleCursorTreeAdapter : global::Android.Widget.ResourceCursorTreeAdapter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[III[Ljav" +
    "a/lang/String;[I)V", AccessFlags = 1)]
				public SimpleCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int int32, int int321, string[] @string, int[] int322, int int323, int int324, string[] string1, int[] int325) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;II[Ljava/lang/String;[II[Ljava" +
    "/lang/String;[I)V", AccessFlags = 1)]
				public SimpleCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int int32, int int321, string[] @string, int[] int322, int int323, string[] string1, int[] int324) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/database/Cursor;I[Ljava/lang/String;[II[Ljava/" +
    "lang/String;[I)V", AccessFlags = 1)]
				public SimpleCursorTreeAdapter(global::Android.Content.Context context, global::Android.Database.ICursor cursor, int int32, string[] @string, int[] int321, int int322, string[] string1, int[] int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindChildView
				/// </java-name>
				[Dot42.DexImport("bindChildView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 4)]
				protected internal override void BindChildView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bindGroupView
				/// </java-name>
				[Dot42.DexImport("bindGroupView", "(Landroid/view/View;Landroid/content/Context;Landroid/database/Cursor;Z)V", AccessFlags = 4)]
				protected internal override void BindGroupView(global::Android.Views.View view, global::Android.Content.Context context, global::Android.Database.ICursor cursor, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setViewImage
				/// </java-name>
				[Dot42.DexImport("setViewImage", "(Landroid/widget/ImageView;Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal virtual void SetViewImage(global::Android.Widget.ImageView imageView, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setViewText
				/// </java-name>
				[Dot42.DexImport("setViewText", "(Landroid/widget/TextView;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewText(global::Android.Widget.TextView textView, string @string) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SimpleCursorTreeAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getViewBinder
				/// </java-name>
				public virtual global::Android.Widget.SimpleCursorTreeAdapter.IViewBinder ViewBinder
				{
						[Dot42.DexImport("getViewBinder", "()Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.SimpleCursorTreeAdapter.IViewBinder); }
						[Dot42.DexImport("setViewBinder", "(Landroid/widget/SimpleCursorTreeAdapter$ViewBinder;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/SimpleCursorTreeAdapter$ViewBinder
				/// </java-name>
				[Dot42.DexImport("android/widget/SimpleCursorTreeAdapter$ViewBinder", AccessFlags = 1545)]
				public partial interface IViewBinder
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// setViewValue
						/// </java-name>
						[Dot42.DexImport("setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", AccessFlags = 1025)]
						bool SetViewValue(global::Android.Views.View view, global::Android.Database.ICursor cursor, int int32) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/SimpleExpandableListAdapter
		/// </java-name>
		[Dot42.DexImport("android/widget/SimpleExpandableListAdapter", AccessFlags = 33)]
		public partial class SimpleExpandableListAdapter : global::Android.Widget.BaseExpandableListAdapter
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/List;I[Ljava/lang/String;[ILjava/util/List;I" +
    "[Ljava/lang/String;[I)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/List<+Ljava/util/Map<Ljava/lang/String;*>;>;" +
    "I[Ljava/lang/String;[ILjava/util/List<+Ljava/util/List<+Ljava/util/Map<Ljava/lan" +
    "g/String;*>;>;>;I[Ljava/lang/String;[I)V")]
				public SimpleExpandableListAdapter(global::Android.Content.Context context, global::Java.Util.IList<global::Java.Util.IMap<string, object>> list, int int32, string[] @string, int[] int321, global::Java.Util.IList<global::Java.Util.IList<global::Java.Util.IMap<string, object>>> list1, int int322, string[] string1, int[] int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;" +
    "I[Ljava/lang/String;[I)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/List<+Ljava/util/Map<Ljava/lang/String;*>;>;" +
    "II[Ljava/lang/String;[ILjava/util/List<+Ljava/util/List<+Ljava/util/Map<Ljava/la" +
    "ng/String;*>;>;>;I[Ljava/lang/String;[I)V")]
				public SimpleExpandableListAdapter(global::Android.Content.Context context, global::Java.Util.IList<global::Java.Util.IMap<string, object>> list, int int32, int int321, string[] @string, int[] int322, global::Java.Util.IList<global::Java.Util.IList<global::Java.Util.IMap<string, object>>> list1, int int323, string[] string1, int[] int324) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Ljava/util/List;II[Ljava/lang/String;[ILjava/util/List;" +
    "II[Ljava/lang/String;[I)V", AccessFlags = 1, Signature = "(Landroid/content/Context;Ljava/util/List<+Ljava/util/Map<Ljava/lang/String;*>;>;" +
    "II[Ljava/lang/String;[ILjava/util/List<+Ljava/util/List<+Ljava/util/Map<Ljava/la" +
    "ng/String;*>;>;>;II[Ljava/lang/String;[I)V")]
				public SimpleExpandableListAdapter(global::Android.Content.Context context, global::Java.Util.IList<global::Java.Util.IMap<string, object>> list, int int32, int int321, string[] @string, int[] int322, global::Java.Util.IList<global::Java.Util.IList<global::Java.Util.IMap<string, object>>> list1, int int323, int int324, string[] string1, int[] int325) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(II)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetChild(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getChildId
				/// </java-name>
				[Dot42.DexImport("getChildId", "(II)J", AccessFlags = 1)]
				public override long GetChildId(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getChildView
				/// </java-name>
				[Dot42.DexImport("getChildView", "(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetChildView(int int32, int int321, bool boolean, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newChildView
				/// </java-name>
				[Dot42.DexImport("newChildView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View NewChildView(bool boolean, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// getChildrenCount
				/// </java-name>
				[Dot42.DexImport("getChildrenCount", "(I)I", AccessFlags = 1)]
				public override int GetChildrenCount(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getGroup
				/// </java-name>
				[Dot42.DexImport("getGroup", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetGroup(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getGroupId
				/// </java-name>
				[Dot42.DexImport("getGroupId", "(I)J", AccessFlags = 1)]
				public override long GetGroupId(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getGroupView
				/// </java-name>
				[Dot42.DexImport("getGroupView", "(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View GetGroupView(int int32, bool boolean, global::Android.Views.View view, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// newGroupView
				/// </java-name>
				[Dot42.DexImport("newGroupView", "(ZLandroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View NewGroupView(bool boolean, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// isChildSelectable
				/// </java-name>
				[Dot42.DexImport("isChildSelectable", "(II)Z", AccessFlags = 1)]
				public override bool IsChildSelectable(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SimpleExpandableListAdapter() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getGroupCount
				/// </java-name>
				public override int GroupCount
				{
						[Dot42.DexImport("getGroupCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// hasStableIds
				/// </java-name>
				public override bool HasStableIds
				{
						[Dot42.DexImport("hasStableIds", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/widget/SlidingDrawer
		/// </java-name>
		[Dot42.DexImport("android/widget/SlidingDrawer", AccessFlags = 33)]
		public partial class SlidingDrawer : global::Android.Views.ViewGroup
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ORIENTATION_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_HORIZONTAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_HORIZONTAL = 0;
				/// <java-name>
				/// ORIENTATION_VERTICAL
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_VERTICAL", "I", AccessFlags = 25)]
				public const int ORIENTATION_VERTICAL = 1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public SlidingDrawer(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public SlidingDrawer(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// toggle
				/// </java-name>
				[Dot42.DexImport("toggle", "()V", AccessFlags = 1)]
				public virtual void Toggle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// animateToggle
				/// </java-name>
				[Dot42.DexImport("animateToggle", "()V", AccessFlags = 1)]
				public virtual void AnimateToggle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// open
				/// </java-name>
				[Dot42.DexImport("open", "()V", AccessFlags = 1)]
				public virtual void Open() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1)]
				public virtual void Close() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// animateClose
				/// </java-name>
				[Dot42.DexImport("animateClose", "()V", AccessFlags = 1)]
				public virtual void AnimateClose() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// animateOpen
				/// </java-name>
				[Dot42.DexImport("animateOpen", "()V", AccessFlags = 1)]
				public virtual void AnimateOpen() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDrawerOpenListener
				/// </java-name>
				[Dot42.DexImport("setOnDrawerOpenListener", "(Landroid/widget/SlidingDrawer$OnDrawerOpenListener;)V", AccessFlags = 1)]
				public virtual void SetOnDrawerOpenListener(global::Android.Widget.SlidingDrawer.IOnDrawerOpenListener onDrawerOpenListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDrawerCloseListener
				/// </java-name>
				[Dot42.DexImport("setOnDrawerCloseListener", "(Landroid/widget/SlidingDrawer$OnDrawerCloseListener;)V", AccessFlags = 1)]
				public virtual void SetOnDrawerCloseListener(global::Android.Widget.SlidingDrawer.IOnDrawerCloseListener onDrawerCloseListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDrawerScrollListener
				/// </java-name>
				[Dot42.DexImport("setOnDrawerScrollListener", "(Landroid/widget/SlidingDrawer$OnDrawerScrollListener;)V", AccessFlags = 1)]
				public virtual void SetOnDrawerScrollListener(global::Android.Widget.SlidingDrawer.IOnDrawerScrollListener onDrawerScrollListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unlock
				/// </java-name>
				[Dot42.DexImport("unlock", "()V", AccessFlags = 1)]
				public virtual void Unlock() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lock
				/// </java-name>
				[Dot42.DexImport("lock", "()V", AccessFlags = 1)]
				public virtual void Lock() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SlidingDrawer() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHandle
				/// </java-name>
				public virtual global::Android.Views.View Handle
				{
						[Dot42.DexImport("getHandle", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getContent
				/// </java-name>
				public virtual global::Android.Views.View Content
				{
						[Dot42.DexImport("getContent", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// isOpened
				/// </java-name>
				public virtual bool IsOpened
				{
						[Dot42.DexImport("isOpened", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMoving
				/// </java-name>
				public virtual bool IsMoving
				{
						[Dot42.DexImport("isMoving", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/widget/SlidingDrawer$OnDrawerScrollListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SlidingDrawer$OnDrawerScrollListener", AccessFlags = 1545)]
				public partial interface IOnDrawerScrollListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onScrollStarted
						/// </java-name>
						[Dot42.DexImport("onScrollStarted", "()V", AccessFlags = 1025)]
						void OnScrollStarted() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onScrollEnded
						/// </java-name>
						[Dot42.DexImport("onScrollEnded", "()V", AccessFlags = 1025)]
						void OnScrollEnded() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/SlidingDrawer$OnDrawerCloseListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SlidingDrawer$OnDrawerCloseListener", AccessFlags = 1545)]
				public partial interface IOnDrawerCloseListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDrawerClosed
						/// </java-name>
						[Dot42.DexImport("onDrawerClosed", "()V", AccessFlags = 1025)]
						void OnDrawerClosed() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/SlidingDrawer$OnDrawerOpenListener
				/// </java-name>
				[Dot42.DexImport("android/widget/SlidingDrawer$OnDrawerOpenListener", AccessFlags = 1545)]
				public partial interface IOnDrawerOpenListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDrawerOpened
						/// </java-name>
						[Dot42.DexImport("onDrawerOpened", "()V", AccessFlags = 1025)]
						void OnDrawerOpened() /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/Space
		/// </java-name>
		[Dot42.DexImport("android/widget/Space", AccessFlags = 49)]
		public sealed partial class Space : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Space(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Space(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Space(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Space() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/Spinner
		/// </java-name>
		[Dot42.DexImport("android/widget/Spinner", AccessFlags = 33)]
		public partial class Spinner : global::Android.Widget.AbsSpinner, global::Android.Content.IDialogInterface_IOnClickListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// MODE_DIALOG
				/// </java-name>
				[Dot42.DexImport("MODE_DIALOG", "I", AccessFlags = 25)]
				public const int MODE_DIALOG = 0;
				/// <java-name>
				/// MODE_DROPDOWN
				/// </java-name>
				[Dot42.DexImport("MODE_DROPDOWN", "I", AccessFlags = 25)]
				public const int MODE_DROPDOWN = 1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Spinner(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public Spinner(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Spinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Spinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", AccessFlags = 1)]
				public Spinner(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
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
				/// onClick
				/// </java-name>
				[Dot42.DexImport("onClick", "(Landroid/content/DialogInterface;I)V", AccessFlags = 1)]
				public virtual void OnClick(global::Android.Content.IDialogInterface dialogInterface, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPromptId
				/// </java-name>
				[Dot42.DexImport("setPromptId", "(I)V", AccessFlags = 1)]
				public virtual void SetPromptId(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Spinner() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPrompt
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Prompt
				{
						[Dot42.DexImport("getPrompt", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setPrompt", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setAdapter
				/// </java-name>
				public override global::Android.Widget.ISpinnerAdapter Adapter
				{
						[Dot42.DexImport("setAdapter", "(Landroid/widget/SpinnerAdapter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setOnItemClickListener
				/// </java-name>
				public override global::Android.Widget.AdapterView<global::Android.Widget.ISpinnerAdapter>.IOnItemClickListener OnItemClickListener
				{
						[Dot42.DexImport("setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/StackView
		/// </java-name>
		[Dot42.DexImport("android/widget/StackView", AccessFlags = 33)]
		public partial class StackView : global::Android.Widget.AdapterViewAnimator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public StackView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public StackView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public StackView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showNext
				/// </java-name>
				[Dot42.DexImport("showNext", "()V", AccessFlags = 1)]
				public override void ShowNext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showPrevious
				/// </java-name>
				[Dot42.DexImport("showPrevious", "()V", AccessFlags = 1)]
				public override void ShowPrevious() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnInterceptTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// advance
				/// </java-name>
				[Dot42.DexImport("advance", "()V", AccessFlags = 1)]
				public override void Advance() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal StackView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/Switch
		/// </java-name>
		[Dot42.DexImport("android/widget/Switch", AccessFlags = 33)]
		public partial class Switch : global::Android.Widget.CompoundButton
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Switch(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public Switch(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public Switch(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSwitchTextAppearance
				/// </java-name>
				[Dot42.DexImport("setSwitchTextAppearance", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetSwitchTextAppearance(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSwitchTypeface
				/// </java-name>
				[Dot42.DexImport("setSwitchTypeface", "(Landroid/graphics/Typeface;I)V", AccessFlags = 1)]
				public virtual void SetSwitchTypeface(global::Android.Graphics.Typeface typeface, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSwitchTypeface
				/// </java-name>
				[Dot42.DexImport("setSwitchTypeface", "(Landroid/graphics/Typeface;)V", AccessFlags = 1)]
				public virtual void SetSwitchTypeface(global::Android.Graphics.Typeface typeface) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 1)]
				public new virtual void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Switch() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTextOn
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence TextOn
				{
						[Dot42.DexImport("getTextOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setTextOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTextOff
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence TextOff
				{
						[Dot42.DexImport("getTextOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setTextOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCompoundPaddingRight
				/// </java-name>
				public override int CompoundPaddingRight
				{
						[Dot42.DexImport("getCompoundPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// setChecked
				/// </java-name>
				public override bool IsChecked
				{
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/TabHost
		/// </java-name>
		[Dot42.DexImport("android/widget/TabHost", AccessFlags = 33)]
		public partial class TabHost : global::Android.Widget.FrameLayout, global::Android.Views.ViewTreeObserver.IOnTouchModeChangeListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TabHost(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TabHost(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// newTabSpec
				/// </java-name>
				[Dot42.DexImport("newTabSpec", "(Ljava/lang/String;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
				public virtual global::Android.Widget.TabHost.TabSpec NewTabSpec(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.TabHost.TabSpec);
				}

				/// <java-name>
				/// setup
				/// </java-name>
				[Dot42.DexImport("setup", "()V", AccessFlags = 1)]
				public virtual void Setup() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1)]
				public override void SendAccessibilityEvent(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setup
				/// </java-name>
				[Dot42.DexImport("setup", "(Landroid/app/LocalActivityManager;)V", AccessFlags = 1)]
				public virtual void Setup(global::Android.App.LocalActivityManager localActivityManager) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchModeChanged
				/// </java-name>
				[Dot42.DexImport("onTouchModeChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnTouchModeChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addTab
				/// </java-name>
				[Dot42.DexImport("addTab", "(Landroid/widget/TabHost$TabSpec;)V", AccessFlags = 1)]
				public virtual void AddTab(global::Android.Widget.TabHost.TabSpec tabSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearAllTabs
				/// </java-name>
				[Dot42.DexImport("clearAllTabs", "()V", AccessFlags = 1)]
				public virtual void ClearAllTabs() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCurrentTabByTag
				/// </java-name>
				[Dot42.DexImport("setCurrentTabByTag", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetCurrentTabByTag(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void DispatchWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnTabChangedListener
				/// </java-name>
				[Dot42.DexImport("setOnTabChangedListener", "(Landroid/widget/TabHost$OnTabChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnTabChangedListener(global::Android.Widget.TabHost.IOnTabChangeListener onTabChangeListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TabHost() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTabWidget
				/// </java-name>
				public virtual global::Android.Widget.TabWidget TabWidget
				{
						[Dot42.DexImport("getTabWidget", "()Landroid/widget/TabWidget;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TabWidget); }
				}

				/// <java-name>
				/// getCurrentTab
				/// </java-name>
				public virtual int CurrentTab
				{
						[Dot42.DexImport("getCurrentTab", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCurrentTab", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrentTabTag
				/// </java-name>
				public virtual string CurrentTabTag
				{
						[Dot42.DexImport("getCurrentTabTag", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCurrentTabView
				/// </java-name>
				public virtual global::Android.Views.View CurrentTabView
				{
						[Dot42.DexImport("getCurrentTabView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getCurrentView
				/// </java-name>
				public virtual global::Android.Views.View CurrentView
				{
						[Dot42.DexImport("getCurrentView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getTabContentView
				/// </java-name>
				public virtual global::Android.Widget.FrameLayout TabContentView
				{
						[Dot42.DexImport("getTabContentView", "()Landroid/widget/FrameLayout;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.FrameLayout); }
				}

				/// <java-name>
				/// android/widget/TabHost$TabSpec
				/// </java-name>
				[Dot42.DexImport("android/widget/TabHost$TabSpec", AccessFlags = 1)]
				public partial class TabSpec
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// this$0
						/// </java-name>
						[Dot42.DexImport("this$0", "Landroid/widget/TabHost;", AccessFlags = 4112)]
						internal readonly global::Android.Widget.TabHost This_0;
						[Dot42.DexImport("<init>", "(Landroid/widget/TabHost;)V", AccessFlags = 0)]
						internal TabSpec(global::Android.Widget.TabHost tabHost) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setIndicator
						/// </java-name>
						[Dot42.DexImport("setIndicator", "(Ljava/lang/CharSequence;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetIndicator(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <java-name>
						/// setIndicator
						/// </java-name>
						[Dot42.DexImport("setIndicator", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Landroid/widget/Tab" +
    "Host$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetIndicator(global::Java.Lang.ICharSequence charSequence, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <java-name>
						/// setIndicator
						/// </java-name>
						[Dot42.DexImport("setIndicator", "(Landroid/view/View;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetIndicator(global::Android.Views.View view) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <java-name>
						/// setContent
						/// </java-name>
						[Dot42.DexImport("setContent", "(I)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetContent(int int32) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <java-name>
						/// setContent
						/// </java-name>
						[Dot42.DexImport("setContent", "(Landroid/widget/TabHost$TabContentFactory;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetContent(global::Android.Widget.TabHost.ITabContentFactory tabContentFactory) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						/// <java-name>
						/// setContent
						/// </java-name>
						[Dot42.DexImport("setContent", "(Landroid/content/Intent;)Landroid/widget/TabHost$TabSpec;", AccessFlags = 1)]
						public virtual TabSpec SetContent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
						{
								return default(TabSpec);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal TabSpec() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

						/// <java-name>
						/// getTag
						/// </java-name>
						public virtual string Tag
						{
								[Dot42.DexImport("getTag", "()Ljava/lang/String;", AccessFlags = 1)]
								get{ return default(string); }
						}

				}

				/// <java-name>
				/// android/widget/TabHost$TabContentFactory
				/// </java-name>
				[Dot42.DexImport("android/widget/TabHost$TabContentFactory", AccessFlags = 1545)]
				public partial interface ITabContentFactory
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// createTabContent
						/// </java-name>
						[Dot42.DexImport("createTabContent", "(Ljava/lang/String;)Landroid/view/View;", AccessFlags = 1025)]
						global::Android.Views.View CreateTabContent(string @string) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/widget/TabHost$OnTabChangeListener
				/// </java-name>
				[Dot42.DexImport("android/widget/TabHost$OnTabChangeListener", AccessFlags = 1545)]
				public partial interface IOnTabChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTabChanged
						/// </java-name>
						[Dot42.DexImport("onTabChanged", "(Ljava/lang/String;)V", AccessFlags = 1025)]
						void OnTabChanged(string @string) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/TableLayout
		/// </java-name>
		[Dot42.DexImport("android/widget/TableLayout", AccessFlags = 33)]
		public partial class TableLayout : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TableLayout(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TableLayout(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", AccessFlags = 1)]
				public override void SetOnHierarchyChangeListener(global::Android.Views.ViewGroup.IOnHierarchyChangeListener onHierarchyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public override void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setColumnCollapsed
				/// </java-name>
				[Dot42.DexImport("setColumnCollapsed", "(IZ)V", AccessFlags = 1)]
				public virtual void SetColumnCollapsed(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isColumnCollapsed
				/// </java-name>
				[Dot42.DexImport("isColumnCollapsed", "(I)Z", AccessFlags = 1)]
				public virtual bool IsColumnCollapsed(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setColumnStretchable
				/// </java-name>
				[Dot42.DexImport("setColumnStretchable", "(IZ)V", AccessFlags = 1)]
				public virtual void SetColumnStretchable(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isColumnStretchable
				/// </java-name>
				[Dot42.DexImport("isColumnStretchable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsColumnStretchable(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setColumnShrinkable
				/// </java-name>
				[Dot42.DexImport("setColumnShrinkable", "(IZ)V", AccessFlags = 1)]
				public virtual void SetColumnShrinkable(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isColumnShrinkable
				/// </java-name>
				[Dot42.DexImport("isColumnShrinkable", "(I)Z", AccessFlags = 1)]
				public virtual bool IsColumnShrinkable(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableLayout$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.TableLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.TableLayout.LayoutParams);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;" +
    "", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TableLayout() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isShrinkAllColumns
				/// </java-name>
				public virtual bool IsShrinkAllColumns
				{
						[Dot42.DexImport("isShrinkAllColumns", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setShrinkAllColumns", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isStretchAllColumns
				/// </java-name>
				public virtual bool IsStretchAllColumns
				{
						[Dot42.DexImport("isStretchAllColumns", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setStretchAllColumns", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/TableLayout$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/TableLayout$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Widget.LinearLayout.LayoutParams
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(IIF)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public LayoutParams() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal override void SetBaseAttributes(global::Android.Content.Res.TypedArray typedArray, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/TableRow
		/// </java-name>
		[Dot42.DexImport("android/widget/TableRow", AccessFlags = 33)]
		public partial class TableRow : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TableRow(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TableRow(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", AccessFlags = 1)]
				public override void SetOnHierarchyChangeListener(global::Android.Views.ViewGroup.IOnHierarchyChangeListener onHierarchyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getVirtualChildAt
				/// </java-name>
				[Dot42.DexImport("getVirtualChildAt", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetVirtualChildAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableRow$LayoutParams;", AccessFlags = 1)]
				public new virtual global::Android.Widget.TableRow.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.TableRow.LayoutParams);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal override bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;" +
    "", AccessFlags = 4)]
				protected internal override global::Android.Widget.LinearLayout.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.LinearLayout.LayoutParams);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TableRow() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getVirtualChildCount
				/// </java-name>
				public virtual int VirtualChildCount
				{
						[Dot42.DexImport("getVirtualChildCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/widget/TableRow$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/widget/TableRow$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams : global::Android.Widget.LinearLayout.LayoutParams
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// column
						/// </java-name>
						[Dot42.DexImport("column", "I", AccessFlags = 1)]
						public int Column;
						/// <java-name>
						/// span
						/// </java-name>
						[Dot42.DexImport("span", "I", AccessFlags = 1)]
						public int Span;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(IIF)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321, float single) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public LayoutParams() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
						public LayoutParams(int int32) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Views.ViewGroup.MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal override void SetBaseAttributes(global::Android.Content.Res.TypedArray typedArray, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/widget/TabWidget
		/// </java-name>
		[Dot42.DexImport("android/widget/TabWidget", AccessFlags = 33)]
		public partial class TabWidget : global::Android.Widget.LinearLayout, global::Android.Views.View.IOnFocusChangeListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TabWidget(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TabWidget(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TabWidget(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildDrawingOrder
				/// </java-name>
				[Dot42.DexImport("getChildDrawingOrder", "(II)I", AccessFlags = 4)]
				protected internal override int GetChildDrawingOrder(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChildTabViewAt
				/// </java-name>
				[Dot42.DexImport("getChildTabViewAt", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetChildTabViewAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setDividerDrawable
				/// </java-name>
				[Dot42.DexImport("setDividerDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void SetDividerDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDividerDrawable
				/// </java-name>
				[Dot42.DexImport("setDividerDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetDividerDrawable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLeftStripDrawable
				/// </java-name>
				[Dot42.DexImport("setLeftStripDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetLeftStripDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLeftStripDrawable
				/// </java-name>
				[Dot42.DexImport("setLeftStripDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetLeftStripDrawable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRightStripDrawable
				/// </java-name>
				[Dot42.DexImport("setRightStripDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetRightStripDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRightStripDrawable
				/// </java-name>
				[Dot42.DexImport("setRightStripDrawable", "(I)V", AccessFlags = 1)]
				public virtual void SetRightStripDrawable(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// childDrawableStateChanged
				/// </java-name>
				[Dot42.DexImport("childDrawableStateChanged", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void ChildDrawableStateChanged(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public new virtual void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCurrentTab
				/// </java-name>
				[Dot42.DexImport("setCurrentTab", "(I)V", AccessFlags = 1)]
				public virtual void SetCurrentTab(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// focusCurrentTab
				/// </java-name>
				[Dot42.DexImport("focusCurrentTab", "(I)V", AccessFlags = 1)]
				public virtual void FocusCurrentTab(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "()V", AccessFlags = 1)]
				public override void RemoveAllViews() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAccessibilityEventUnchecked
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void SendAccessibilityEventUnchecked(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChange
				/// </java-name>
				[Dot42.DexImport("onFocusChange", "(Landroid/view/View;Z)V", AccessFlags = 1)]
				public virtual void OnFocusChange(global::Android.Views.View view, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TabWidget() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTabCount
				/// </java-name>
				public virtual int TabCount
				{
						[Dot42.DexImport("getTabCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isStripEnabled
				/// </java-name>
				public virtual bool IsStripEnabled
				{
						[Dot42.DexImport("isStripEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setStripEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
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
		/// android/widget/TextSwitcher
		/// </java-name>
		[Dot42.DexImport("android/widget/TextSwitcher", AccessFlags = 33)]
		public partial class TextSwitcher : global::Android.Widget.ViewSwitcher
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TextSwitcher(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TextSwitcher(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCurrentText
				/// </java-name>
				[Dot42.DexImport("setCurrentText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetCurrentText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextSwitcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/widget/TextView
		/// </java-name>
		[Dot42.DexImport("android/widget/TextView", AccessFlags = 33)]
		public partial class TextView : global::Android.Views.View, global::Android.Views.ViewTreeObserver.IOnPreDrawListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TextView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TextView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTypeface
				/// </java-name>
				[Dot42.DexImport("setTypeface", "(Landroid/graphics/Typeface;I)V", AccessFlags = 1)]
				public virtual void SetTypeface(global::Android.Graphics.Typeface typeface, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// length
				/// </java-name>
				[Dot42.DexImport("length", "()I", AccessFlags = 1)]
				public virtual int Length() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setCompoundDrawables
				/// </java-name>
				[Dot42.DexImport("setCompoundDrawables", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid" +
    "/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetCompoundDrawables(global::Android.Graphics.Drawables.Drawable drawable, global::Android.Graphics.Drawables.Drawable drawable1, global::Android.Graphics.Drawables.Drawable drawable2, global::Android.Graphics.Drawables.Drawable drawable3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCompoundDrawablesWithIntrinsicBounds
				/// </java-name>
				[Dot42.DexImport("setCompoundDrawablesWithIntrinsicBounds", "(IIII)V", AccessFlags = 1)]
				public virtual void SetCompoundDrawablesWithIntrinsicBounds(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCompoundDrawablesWithIntrinsicBounds
				/// </java-name>
				[Dot42.DexImport("setCompoundDrawablesWithIntrinsicBounds", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;Landroid" +
    "/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetCompoundDrawablesWithIntrinsicBounds(global::Android.Graphics.Drawables.Drawable drawable, global::Android.Graphics.Drawables.Drawable drawable1, global::Android.Graphics.Drawables.Drawable drawable2, global::Android.Graphics.Drawables.Drawable drawable3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public override void SetPadding(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextAppearance
				/// </java-name>
				[Dot42.DexImport("setTextAppearance", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetTextAppearance(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextSize
				/// </java-name>
				[Dot42.DexImport("setTextSize", "(IF)V", AccessFlags = 1)]
				public virtual void SetTextSize(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextColor
				/// </java-name>
				[Dot42.DexImport("setTextColor", "(I)V", AccessFlags = 1)]
				public virtual void SetTextColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextColor
				/// </java-name>
				[Dot42.DexImport("setTextColor", "(Landroid/content/res/ColorStateList;)V", AccessFlags = 1)]
				public virtual void SetTextColor(global::Android.Content.Res.ColorStateList colorStateList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHighlightColor
				/// </java-name>
				[Dot42.DexImport("setHighlightColor", "(I)V", AccessFlags = 1)]
				public virtual void SetHighlightColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setShadowLayer
				/// </java-name>
				[Dot42.DexImport("setShadowLayer", "(FFFI)V", AccessFlags = 1)]
				public virtual void SetShadowLayer(float single, float single1, float single2, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHintTextColor
				/// </java-name>
				[Dot42.DexImport("setHintTextColor", "(I)V", AccessFlags = 17)]
				public void SetHintTextColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHintTextColor
				/// </java-name>
				[Dot42.DexImport("setHintTextColor", "(Landroid/content/res/ColorStateList;)V", AccessFlags = 17)]
				public void SetHintTextColor(global::Android.Content.Res.ColorStateList colorStateList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLinkTextColor
				/// </java-name>
				[Dot42.DexImport("setLinkTextColor", "(I)V", AccessFlags = 17)]
				public void SetLinkTextColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLinkTextColor
				/// </java-name>
				[Dot42.DexImport("setLinkTextColor", "(Landroid/content/res/ColorStateList;)V", AccessFlags = 17)]
				public void SetLinkTextColor(global::Android.Content.Res.ColorStateList colorStateList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHorizontallyScrolling
				/// </java-name>
				[Dot42.DexImport("setHorizontallyScrolling", "(Z)V", AccessFlags = 1)]
				public virtual void SetHorizontallyScrolling(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMinLines
				/// </java-name>
				[Dot42.DexImport("setMinLines", "(I)V", AccessFlags = 1)]
				public virtual void SetMinLines(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMinHeight
				/// </java-name>
				[Dot42.DexImport("setMinHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetMinHeight(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxLines
				/// </java-name>
				[Dot42.DexImport("setMaxLines", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxLines(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxHeight
				/// </java-name>
				[Dot42.DexImport("setMaxHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxHeight(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLines
				/// </java-name>
				[Dot42.DexImport("setLines", "(I)V", AccessFlags = 1)]
				public virtual void SetLines(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHeight
				/// </java-name>
				[Dot42.DexImport("setHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetHeight(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMinEms
				/// </java-name>
				[Dot42.DexImport("setMinEms", "(I)V", AccessFlags = 1)]
				public virtual void SetMinEms(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMinWidth
				/// </java-name>
				[Dot42.DexImport("setMinWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMinWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxEms
				/// </java-name>
				[Dot42.DexImport("setMaxEms", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxEms(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxWidth
				/// </java-name>
				[Dot42.DexImport("setMaxWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEms
				/// </java-name>
				[Dot42.DexImport("setEms", "(I)V", AccessFlags = 1)]
				public virtual void SetEms(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWidth
				/// </java-name>
				[Dot42.DexImport("setWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLineSpacing
				/// </java-name>
				[Dot42.DexImport("setLineSpacing", "(FF)V", AccessFlags = 1)]
				public virtual void SetLineSpacing(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
				public void Append(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// append
				/// </java-name>
				[Dot42.DexImport("append", "(Ljava/lang/CharSequence;II)V", AccessFlags = 1)]
				public virtual void Append(global::Java.Lang.ICharSequence charSequence, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public new virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public new virtual void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEditableFactory
				/// </java-name>
				[Dot42.DexImport("setEditableFactory", "(Landroid/text/Editable$Factory;)V", AccessFlags = 17)]
				public void SetEditableFactory(global::Android.Text.IEditable_Factory iEditable_Factory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSpannableFactory
				/// </java-name>
				[Dot42.DexImport("setSpannableFactory", "(Landroid/text/Spannable$Factory;)V", AccessFlags = 17)]
				public void SetSpannableFactory(global::Android.Text.ISpannable_Factory iSpannable_Factory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextKeepState
				/// </java-name>
				[Dot42.DexImport("setTextKeepState", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
				public void SetTextKeepState(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", AccessFlags = 1)]
				public virtual void SetText(global::Java.Lang.ICharSequence charSequence, global::Android.Widget.TextView.BufferType bufferType) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "([CII)V", AccessFlags = 17)]
				public void SetText(char[] @char, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTextKeepState
				/// </java-name>
				[Dot42.DexImport("setTextKeepState", "(Ljava/lang/CharSequence;Landroid/widget/TextView$BufferType;)V", AccessFlags = 17)]
				public void SetTextKeepState(global::Java.Lang.ICharSequence charSequence, global::Android.Widget.TextView.BufferType bufferType) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(I)V", AccessFlags = 17)]
				public void SetText(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(ILandroid/widget/TextView$BufferType;)V", AccessFlags = 17)]
				public void SetText(int int32, global::Android.Widget.TextView.BufferType bufferType) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setHint
				/// </java-name>
				[Dot42.DexImport("setHint", "(I)V", AccessFlags = 17)]
				public void SetHint(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setRawInputType
				/// </java-name>
				[Dot42.DexImport("setRawInputType", "(I)V", AccessFlags = 1)]
				public virtual void SetRawInputType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setImeActionLabel
				/// </java-name>
				[Dot42.DexImport("setImeActionLabel", "(Ljava/lang/CharSequence;I)V", AccessFlags = 1)]
				public virtual void SetImeActionLabel(global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnEditorActionListener
				/// </java-name>
				[Dot42.DexImport("setOnEditorActionListener", "(Landroid/widget/TextView$OnEditorActionListener;)V", AccessFlags = 1)]
				public virtual void SetOnEditorActionListener(global::Android.Widget.TextView.IOnEditorActionListener onEditorActionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onEditorAction
				/// </java-name>
				[Dot42.DexImport("onEditorAction", "(I)V", AccessFlags = 1)]
				public virtual void OnEditorAction(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInputExtras
				/// </java-name>
				[Dot42.DexImport("setInputExtras", "(I)V", AccessFlags = 1)]
				public virtual void SetInputExtras(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputExtras
				/// </java-name>
				[Dot42.DexImport("getInputExtras", "(Z)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle GetInputExtras(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <java-name>
				/// setError
				/// </java-name>
				[Dot42.DexImport("setError", "(Ljava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetError(global::Java.Lang.ICharSequence charSequence, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFrame
				/// </java-name>
				[Dot42.DexImport("setFrame", "(IIII)Z", AccessFlags = 4)]
				protected internal virtual bool SetFrame(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPreDraw
				/// </java-name>
				[Dot42.DexImport("onPreDraw", "()Z", AccessFlags = 1)]
				public virtual bool OnPreDraw() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal override bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void InvalidateDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSetAlpha
				/// </java-name>
				[Dot42.DexImport("onSetAlpha", "(I)Z", AccessFlags = 4)]
				protected internal override bool OnSetAlpha(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setTextIsSelectable
				/// </java-name>
				[Dot42.DexImport("setTextIsSelectable", "(Z)V", AccessFlags = 1)]
				public virtual void SetTextIsSelectable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFocusedRect
				/// </java-name>
				[Dot42.DexImport("getFocusedRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public override void GetFocusedRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLineBounds
				/// </java-name>
				[Dot42.DexImport("getLineBounds", "(ILandroid/graphics/Rect;)I", AccessFlags = 1)]
				public virtual int GetLineBounds(int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onKeyPreIme
				/// </java-name>
				[Dot42.DexImport("onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyPreIme(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyMultiple(int int32, int int321, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCheckIsTextEditor
				/// </java-name>
				[Dot42.DexImport("onCheckIsTextEditor", "()Z", AccessFlags = 1)]
				public override bool OnCheckIsTextEditor() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCreateInputConnection
				/// </java-name>
				[Dot42.DexImport("onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;" +
    "", AccessFlags = 1)]
				public override global::Android.Views.Inputmethod.IInputConnection OnCreateInputConnection(global::Android.Views.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.IInputConnection);
				}

				/// <java-name>
				/// extractText
				/// </java-name>
				[Dot42.DexImport("extractText", "(Landroid/view/inputmethod/ExtractedTextRequest;Landroid/view/inputmethod/Extract" +
    "edText;)Z", AccessFlags = 1)]
				public virtual bool ExtractText(global::Android.Views.Inputmethod.ExtractedTextRequest extractedTextRequest, global::Android.Views.Inputmethod.ExtractedText extractedText) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setExtractedText
				/// </java-name>
				[Dot42.DexImport("setExtractedText", "(Landroid/view/inputmethod/ExtractedText;)V", AccessFlags = 1)]
				public virtual void SetExtractedText(global::Android.Views.Inputmethod.ExtractedText extractedText) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCommitCompletion
				/// </java-name>
				[Dot42.DexImport("onCommitCompletion", "(Landroid/view/inputmethod/CompletionInfo;)V", AccessFlags = 1)]
				public virtual void OnCommitCompletion(global::Android.Views.Inputmethod.CompletionInfo completionInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCommitCorrection
				/// </java-name>
				[Dot42.DexImport("onCommitCorrection", "(Landroid/view/inputmethod/CorrectionInfo;)V", AccessFlags = 1)]
				public virtual void OnCommitCorrection(global::Android.Views.Inputmethod.CorrectionInfo correctionInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// beginBatchEdit
				/// </java-name>
				[Dot42.DexImport("beginBatchEdit", "()V", AccessFlags = 1)]
				public virtual void BeginBatchEdit() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endBatchEdit
				/// </java-name>
				[Dot42.DexImport("endBatchEdit", "()V", AccessFlags = 1)]
				public virtual void EndBatchEdit() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onBeginBatchEdit
				/// </java-name>
				[Dot42.DexImport("onBeginBatchEdit", "()V", AccessFlags = 1)]
				public virtual void OnBeginBatchEdit() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onEndBatchEdit
				/// </java-name>
				[Dot42.DexImport("onEndBatchEdit", "()V", AccessFlags = 1)]
				public virtual void OnEndBatchEdit() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPrivateIMECommand
				/// </java-name>
				[Dot42.DexImport("onPrivateIMECommand", "(Ljava/lang/String;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool OnPrivateIMECommand(string @string, global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// resetResolvedLayoutDirection
				/// </java-name>
				[Dot42.DexImport("resetResolvedLayoutDirection", "()V", AccessFlags = 4)]
				protected internal virtual void ResetResolvedLayoutDirection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIncludeFontPadding
				/// </java-name>
				[Dot42.DexImport("setIncludeFontPadding", "(Z)V", AccessFlags = 1)]
				public virtual void SetIncludeFontPadding(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bringPointIntoView
				/// </java-name>
				[Dot42.DexImport("bringPointIntoView", "(I)Z", AccessFlags = 1)]
				public virtual bool BringPointIntoView(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// moveCursorToVisibleOffset
				/// </java-name>
				[Dot42.DexImport("moveCursorToVisibleOffset", "()Z", AccessFlags = 1)]
				public virtual bool MoveCursorToVisibleOffset() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public override void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// debug
				/// </java-name>
				[Dot42.DexImport("debug", "(I)V", AccessFlags = 1)]
				public virtual void Debug(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSingleLine
				/// </java-name>
				[Dot42.DexImport("setSingleLine", "()V", AccessFlags = 1)]
				public virtual void SetSingleLine() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAllCaps
				/// </java-name>
				[Dot42.DexImport("setAllCaps", "(Z)V", AccessFlags = 1)]
				public virtual void SetAllCaps(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSingleLine
				/// </java-name>
				[Dot42.DexImport("setSingleLine", "(Z)V", AccessFlags = 1)]
				public virtual void SetSingleLine(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMarqueeRepeatLimit
				/// </java-name>
				[Dot42.DexImport("setMarqueeRepeatLimit", "(I)V", AccessFlags = 1)]
				public virtual void SetMarqueeRepeatLimit(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelectAllOnFocus
				/// </java-name>
				[Dot42.DexImport("setSelectAllOnFocus", "(Z)V", AccessFlags = 1)]
				public virtual void SetSelectAllOnFocus(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCursorVisible
				/// </java-name>
				[Dot42.DexImport("setCursorVisible", "(Z)V", AccessFlags = 1)]
				public virtual void SetCursorVisible(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTextChanged
				/// </java-name>
				[Dot42.DexImport("onTextChanged", "(Ljava/lang/CharSequence;III)V", AccessFlags = 4)]
				protected internal virtual void OnTextChanged(global::Java.Lang.ICharSequence charSequence, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSelectionChanged
				/// </java-name>
				[Dot42.DexImport("onSelectionChanged", "(II)V", AccessFlags = 4)]
				protected internal virtual void OnSelectionChanged(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addTextChangedListener
				/// </java-name>
				[Dot42.DexImport("addTextChangedListener", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void AddTextChangedListener(global::Android.Text.ITextWatcher textWatcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeTextChangedListener
				/// </java-name>
				[Dot42.DexImport("removeTextChangedListener", "(Landroid/text/TextWatcher;)V", AccessFlags = 1)]
				public virtual void RemoveTextChangedListener(global::Android.Text.ITextWatcher textWatcher) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onStartTemporaryDetach
				/// </java-name>
				[Dot42.DexImport("onStartTemporaryDetach", "()V", AccessFlags = 1)]
				public override void OnStartTemporaryDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishTemporaryDetach
				/// </java-name>
				[Dot42.DexImport("onFinishTemporaryDetach", "()V", AccessFlags = 1)]
				public override void OnFinishTemporaryDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal override void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void OnVisibilityChanged(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearComposingText
				/// </java-name>
				[Dot42.DexImport("clearComposingText", "()V", AccessFlags = 1)]
				public virtual void ClearComposingText() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// didTouchFocusSelect
				/// </java-name>
				[Dot42.DexImport("didTouchFocusSelect", "()Z", AccessFlags = 1)]
				public virtual bool DidTouchFocusSelect() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cancelLongPress
				/// </java-name>
				[Dot42.DexImport("cancelLongPress", "()V", AccessFlags = 1)]
				public override void CancelLongPress() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setScroller
				/// </java-name>
				[Dot42.DexImport("setScroller", "(Landroid/widget/Scroller;)V", AccessFlags = 1)]
				public virtual void SetScroller(global::Android.Widget.Scroller scroller) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal override int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// findViewsWithText
				/// </java-name>
				[Dot42.DexImport("findViewsWithText", "(Ljava/util/ArrayList;Ljava/lang/CharSequence;I)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;Ljava/lang/CharSequence;I)V")]
				public override void FindViewsWithText(global::Java.Util.ArrayList<global::Android.Views.View> arrayList, global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTextColors
				/// </java-name>
				[Dot42.DexImport("getTextColors", "(Landroid/content/Context;Landroid/content/res/TypedArray;)Landroid/content/res/C" +
    "olorStateList;", AccessFlags = 9)]
				public static global::Android.Content.Res.ColorStateList GetTextColors(global::Android.Content.Context context, global::Android.Content.Res.TypedArray typedArray) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Content.Res.ColorStateList);
				}

				/// <java-name>
				/// getTextColor
				/// </java-name>
				[Dot42.DexImport("getTextColor", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)I", AccessFlags = 9)]
				public static int GetTextColor(global::Android.Content.Context context, global::Android.Content.Res.TypedArray typedArray, int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onKeyShortcut
				/// </java-name>
				[Dot42.DexImport("onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyShortcut(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1)]
				public override void SendAccessibilityEvent(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTextContextMenuItem
				/// </java-name>
				[Dot42.DexImport("onTextContextMenuItem", "(I)Z", AccessFlags = 1)]
				public virtual bool OnTextContextMenuItem(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performLongClick
				/// </java-name>
				[Dot42.DexImport("performLongClick", "()Z", AccessFlags = 1)]
				public override bool PerformLongClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onScrollChanged
				/// </java-name>
				[Dot42.DexImport("onScrollChanged", "(IIII)V", AccessFlags = 4)]
				protected internal override void OnScrollChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getOffsetForPosition
				/// </java-name>
				[Dot42.DexImport("getOffsetForPosition", "(FF)I", AccessFlags = 1)]
				public virtual int GetOffsetForPosition(float single, float single1) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// onDragEvent
				/// </java-name>
				[Dot42.DexImport("onDragEvent", "(Landroid/view/DragEvent;)Z", AccessFlags = 1)]
				public override bool OnDragEvent(global::Android.Views.DragEvent dragEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// resolveTextDirection
				/// </java-name>
				[Dot42.DexImport("resolveTextDirection", "()V", AccessFlags = 4)]
				protected internal virtual void ResolveTextDirection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resolveDrawables
				/// </java-name>
				[Dot42.DexImport("resolveDrawables", "()V", AccessFlags = 4)]
				protected internal virtual void ResolveDrawables() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetResolvedDrawables
				/// </java-name>
				[Dot42.DexImport("resetResolvedDrawables", "()V", AccessFlags = 4)]
				protected internal virtual void ResetResolvedDrawables() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDefaultEditable
				/// </java-name>
				protected internal virtual bool IsDefaultEditable
				{
						[Dot42.DexImport("getDefaultEditable", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDefaultMovementMethod
				/// </java-name>
				protected internal virtual global::Android.Text.Method.IMovementMethod DefaultMovementMethod
				{
						[Dot42.DexImport("getDefaultMovementMethod", "()Landroid/text/method/MovementMethod;", AccessFlags = 4)]
						get{ return default(global::Android.Text.Method.IMovementMethod); }
				}

				/// <java-name>
				/// getText
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getEditableText
				/// </java-name>
				public virtual global::Android.Text.IEditable EditableText
				{
						[Dot42.DexImport("getEditableText", "()Landroid/text/Editable;", AccessFlags = 1)]
						get{ return default(global::Android.Text.IEditable); }
				}

				/// <java-name>
				/// getLineHeight
				/// </java-name>
				public virtual int LineHeight
				{
						[Dot42.DexImport("getLineHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLayout
				/// </java-name>
				public global::Android.Text.Layout Layout
				{
						[Dot42.DexImport("getLayout", "()Landroid/text/Layout;", AccessFlags = 17)]
						get{ return default(global::Android.Text.Layout); }
				}

				/// <java-name>
				/// getKeyListener
				/// </java-name>
				public virtual global::Android.Text.Method.IKeyListener KeyListener
				{
						[Dot42.DexImport("getKeyListener", "()Landroid/text/method/KeyListener;", AccessFlags = 17)]
						get{ return default(global::Android.Text.Method.IKeyListener); }
						[Dot42.DexImport("setKeyListener", "(Landroid/text/method/KeyListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMovementMethod
				/// </java-name>
				public global::Android.Text.Method.IMovementMethod MovementMethod
				{
						[Dot42.DexImport("getMovementMethod", "()Landroid/text/method/MovementMethod;", AccessFlags = 17)]
						get{ return default(global::Android.Text.Method.IMovementMethod); }
						[Dot42.DexImport("setMovementMethod", "(Landroid/text/method/MovementMethod;)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getTransformationMethod
				/// </java-name>
				public global::Android.Text.Method.ITransformationMethod TransformationMethod
				{
						[Dot42.DexImport("getTransformationMethod", "()Landroid/text/method/TransformationMethod;", AccessFlags = 17)]
						get{ return default(global::Android.Text.Method.ITransformationMethod); }
						[Dot42.DexImport("setTransformationMethod", "(Landroid/text/method/TransformationMethod;)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getCompoundPaddingTop
				/// </java-name>
				public virtual int CompoundPaddingTop
				{
						[Dot42.DexImport("getCompoundPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCompoundPaddingBottom
				/// </java-name>
				public virtual int CompoundPaddingBottom
				{
						[Dot42.DexImport("getCompoundPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCompoundPaddingLeft
				/// </java-name>
				public virtual int CompoundPaddingLeft
				{
						[Dot42.DexImport("getCompoundPaddingLeft", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCompoundPaddingRight
				/// </java-name>
				public virtual int CompoundPaddingRight
				{
						[Dot42.DexImport("getCompoundPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getExtendedPaddingTop
				/// </java-name>
				public virtual int ExtendedPaddingTop
				{
						[Dot42.DexImport("getExtendedPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getExtendedPaddingBottom
				/// </java-name>
				public virtual int ExtendedPaddingBottom
				{
						[Dot42.DexImport("getExtendedPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTotalPaddingLeft
				/// </java-name>
				public virtual int TotalPaddingLeft
				{
						[Dot42.DexImport("getTotalPaddingLeft", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTotalPaddingRight
				/// </java-name>
				public virtual int TotalPaddingRight
				{
						[Dot42.DexImport("getTotalPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTotalPaddingTop
				/// </java-name>
				public virtual int TotalPaddingTop
				{
						[Dot42.DexImport("getTotalPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTotalPaddingBottom
				/// </java-name>
				public virtual int TotalPaddingBottom
				{
						[Dot42.DexImport("getTotalPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCompoundDrawables
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable[] CompoundDrawables
				{
						[Dot42.DexImport("getCompoundDrawables", "()[Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable[]); }
				}

				/// <java-name>
				/// getCompoundDrawablePadding
				/// </java-name>
				public virtual int CompoundDrawablePadding
				{
						[Dot42.DexImport("getCompoundDrawablePadding", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCompoundDrawablePadding", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAutoLinkMask
				/// </java-name>
				public int AutoLinkMask
				{
						[Dot42.DexImport("getAutoLinkMask", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setAutoLinkMask", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getTextSize
				/// </java-name>
				public virtual float TextSize
				{
						[Dot42.DexImport("getTextSize", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setTextSize", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTextScaleX
				/// </java-name>
				public virtual float TextScaleX
				{
						[Dot42.DexImport("getTextScaleX", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setTextScaleX", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTypeface
				/// </java-name>
				public virtual global::Android.Graphics.Typeface Typeface
				{
						[Dot42.DexImport("getTypeface", "()Landroid/graphics/Typeface;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Typeface); }
						[Dot42.DexImport("setTypeface", "(Landroid/graphics/Typeface;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTextColors
				/// </java-name>
				public global::Android.Content.Res.ColorStateList TextColors
				{
						[Dot42.DexImport("getTextColors", "()Landroid/content/res/ColorStateList;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <java-name>
				/// getCurrentTextColor
				/// </java-name>
				public int CurrentTextColor
				{
						[Dot42.DexImport("getCurrentTextColor", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPaint
				/// </java-name>
				public virtual global::Android.Text.TextPaint Paint
				{
						[Dot42.DexImport("getPaint", "()Landroid/text/TextPaint;", AccessFlags = 1)]
						get{ return default(global::Android.Text.TextPaint); }
				}

				/// <java-name>
				/// getLinksClickable
				/// </java-name>
				public bool IsLinksClickable
				{
						[Dot42.DexImport("getLinksClickable", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setLinksClickable", "(Z)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getUrls
				/// </java-name>
				public virtual global::Android.Text.Style.URLSpan[] Urls
				{
						[Dot42.DexImport("getUrls", "()[Landroid/text/style/URLSpan;", AccessFlags = 1)]
						get{ return default(global::Android.Text.Style.URLSpan[]); }
				}

				/// <java-name>
				/// getHintTextColors
				/// </java-name>
				public global::Android.Content.Res.ColorStateList HintTextColors
				{
						[Dot42.DexImport("getHintTextColors", "()Landroid/content/res/ColorStateList;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <java-name>
				/// getCurrentHintTextColor
				/// </java-name>
				public int CurrentHintTextColor
				{
						[Dot42.DexImport("getCurrentHintTextColor", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLinkTextColors
				/// </java-name>
				public global::Android.Content.Res.ColorStateList LinkTextColors
				{
						[Dot42.DexImport("getLinkTextColors", "()Landroid/content/res/ColorStateList;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.ColorStateList); }
				}

				/// <java-name>
				/// getGravity
				/// </java-name>
				public virtual int Gravity
				{
						[Dot42.DexImport("getGravity", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPaintFlags
				/// </java-name>
				public virtual int PaintFlags
				{
						[Dot42.DexImport("getPaintFlags", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setPaintFlags", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFreezesText
				/// </java-name>
				public virtual bool IsFreezesText
				{
						[Dot42.DexImport("getFreezesText", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFreezesText", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getHint
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Hint
				{
						[Dot42.DexImport("getHint", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setHint", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				public virtual int InputType
				{
						[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setInputType", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getImeOptions
				/// </java-name>
				public virtual int ImeOptions
				{
						[Dot42.DexImport("getImeOptions", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setImeOptions", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getImeActionLabel
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence ImeActionLabel
				{
						[Dot42.DexImport("getImeActionLabel", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
				}

				/// <java-name>
				/// getImeActionId
				/// </java-name>
				public virtual int ImeActionId
				{
						[Dot42.DexImport("getImeActionId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPrivateImeOptions
				/// </java-name>
				public virtual string PrivateImeOptions
				{
						[Dot42.DexImport("getPrivateImeOptions", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setPrivateImeOptions", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getError
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Error
				{
						[Dot42.DexImport("getError", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setError", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFilters
				/// </java-name>
				public virtual global::Android.Text.IInputFilter[] Filters
				{
						[Dot42.DexImport("getFilters", "()[Landroid/text/InputFilter;", AccessFlags = 1)]
						get{ return default(global::Android.Text.IInputFilter[]); }
						[Dot42.DexImport("setFilters", "([Landroid/text/InputFilter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isPaddingOffsetRequired
				/// </java-name>
				protected internal override bool IsPaddingOffsetRequired
				{
						[Dot42.DexImport("isPaddingOffsetRequired", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLeftPaddingOffset
				/// </java-name>
				protected internal override int LeftPaddingOffset
				{
						[Dot42.DexImport("getLeftPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTopPaddingOffset
				/// </java-name>
				protected internal override int TopPaddingOffset
				{
						[Dot42.DexImport("getTopPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBottomPaddingOffset
				/// </java-name>
				protected internal override int BottomPaddingOffset
				{
						[Dot42.DexImport("getBottomPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRightPaddingOffset
				/// </java-name>
				protected internal override int RightPaddingOffset
				{
						[Dot42.DexImport("getRightPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isTextSelectable
				/// </java-name>
				public virtual bool IsTextSelectable
				{
						[Dot42.DexImport("isTextSelectable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLineCount
				/// </java-name>
				public virtual int LineCount
				{
						[Dot42.DexImport("getLineCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSelectionStart
				/// </java-name>
				public virtual int SelectionStart
				{
						[Dot42.DexImport("getSelectionStart", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSelectionEnd
				/// </java-name>
				public virtual int SelectionEnd
				{
						[Dot42.DexImport("getSelectionEnd", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// hasSelection
				/// </java-name>
				public virtual bool HasSelection
				{
						[Dot42.DexImport("hasSelection", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getEllipsize
				/// </java-name>
				public virtual global::Android.Text.TextUtils.TruncateAt Ellipsize
				{
						[Dot42.DexImport("getEllipsize", "()Landroid/text/TextUtils$TruncateAt;", AccessFlags = 1)]
						get{ return default(global::Android.Text.TextUtils.TruncateAt); }
						[Dot42.DexImport("setEllipsize", "(Landroid/text/TextUtils$TruncateAt;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLeftFadingEdgeStrength
				/// </java-name>
				protected internal override float LeftFadingEdgeStrength
				{
						[Dot42.DexImport("getLeftFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getRightFadingEdgeStrength
				/// </java-name>
				protected internal override float RightFadingEdgeStrength
				{
						[Dot42.DexImport("getRightFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// isInputMethodTarget
				/// </java-name>
				public virtual bool IsInputMethodTarget
				{
						[Dot42.DexImport("isInputMethodTarget", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isSuggestionsEnabled
				/// </java-name>
				public virtual bool IsSuggestionsEnabled
				{
						[Dot42.DexImport("isSuggestionsEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getCustomSelectionActionModeCallback
				/// </java-name>
				public virtual global::Android.Views.ActionMode.ICallback CustomSelectionActionModeCallback
				{
						[Dot42.DexImport("getCustomSelectionActionModeCallback", "()Landroid/view/ActionMode$Callback;", AccessFlags = 1)]
						get{ return default(global::Android.Views.ActionMode.ICallback); }
						[Dot42.DexImport("setCustomSelectionActionModeCallback", "(Landroid/view/ActionMode$Callback;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setSelected
				/// </java-name>
				public override bool IsSelected
				{
						[Dot42.DexImport("setSelected", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/widget/TextView$BufferType
				/// </java-name>
				[Dot42.DexImport("android/widget/TextView$BufferType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/widget/TextView$BufferType;>;")]
				public sealed class BufferType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// EDITABLE
						/// </java-name>
						[Dot42.DexImport("EDITABLE", "Landroid/widget/TextView$BufferType;", AccessFlags = 16409)]
						public static readonly BufferType EDITABLE;
						/// <java-name>
						/// NORMAL
						/// </java-name>
						[Dot42.DexImport("NORMAL", "Landroid/widget/TextView$BufferType;", AccessFlags = 16409)]
						public static readonly BufferType NORMAL;
						/// <java-name>
						/// SPANNABLE
						/// </java-name>
						[Dot42.DexImport("SPANNABLE", "Landroid/widget/TextView$BufferType;", AccessFlags = 16409)]
						public static readonly BufferType SPANNABLE;
						private BufferType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/widget/TextView$BufferType;", AccessFlags = 9)]
						public static BufferType[] Values() /* MethodBuilder.Create */ 
						{
								return default(BufferType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/widget/TextView$BufferType;", AccessFlags = 9)]
						public static BufferType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(BufferType);
						}

				}

				/// <java-name>
				/// android/widget/TextView$SavedState
				/// </java-name>
				[Dot42.DexImport("android/widget/TextView$SavedState", AccessFlags = 9)]
				public partial class SavedState : global::Android.Views.View.BaseSavedState
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// CREATOR
						/// </java-name>
						[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
						public static readonly global::Android.OS.IParcelable_ICreator<SavedState> CREATOR;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal SavedState() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// writeToParcel
						/// </java-name>
						[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
						public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
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

				}

				/// <java-name>
				/// android/widget/TextView$OnEditorActionListener
				/// </java-name>
				[Dot42.DexImport("android/widget/TextView$OnEditorActionListener", AccessFlags = 1545)]
				public partial interface IOnEditorActionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onEditorAction
						/// </java-name>
						[Dot42.DexImport("onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnEditorAction(global::Android.Widget.TextView textView, int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/TimePicker
		/// </java-name>
		[Dot42.DexImport("android/widget/TimePicker", AccessFlags = 33)]
		public partial class TimePicker : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TimePicker(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TimePicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TimePicker(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 4)]
				protected internal override void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
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
				/// setOnTimeChangedListener
				/// </java-name>
				[Dot42.DexImport("setOnTimeChangedListener", "(Landroid/widget/TimePicker$OnTimeChangedListener;)V", AccessFlags = 1)]
				public virtual void SetOnTimeChangedListener(global::Android.Widget.TimePicker.IOnTimeChangedListener onTimeChangedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIs24HourView
				/// </java-name>
				[Dot42.DexImport("setIs24HourView", "(Ljava/lang/Boolean;)V", AccessFlags = 1)]
				public virtual void SetIs24HourView(bool? boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public override bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TimePicker() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public override bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrentHour
				/// </java-name>
				public virtual int? CurrentHour
				{
						[Dot42.DexImport("getCurrentHour", "()Ljava/lang/Integer;", AccessFlags = 1)]
						get{ return default(int?); }
						[Dot42.DexImport("setCurrentHour", "(Ljava/lang/Integer;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// is24HourView
				/// </java-name>
				public virtual bool Is24HourView
				{
						[Dot42.DexImport("is24HourView", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getCurrentMinute
				/// </java-name>
				public virtual int? CurrentMinute
				{
						[Dot42.DexImport("getCurrentMinute", "()Ljava/lang/Integer;", AccessFlags = 1)]
						get{ return default(int?); }
						[Dot42.DexImport("setCurrentMinute", "(Ljava/lang/Integer;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/widget/TimePicker$OnTimeChangedListener
				/// </java-name>
				[Dot42.DexImport("android/widget/TimePicker$OnTimeChangedListener", AccessFlags = 1545)]
				public partial interface IOnTimeChangedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTimeChanged
						/// </java-name>
						[Dot42.DexImport("onTimeChanged", "(Landroid/widget/TimePicker;II)V", AccessFlags = 1025)]
						void OnTimeChanged(global::Android.Widget.TimePicker timePicker, int int32, int int321) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/Toast
		/// </java-name>
		[Dot42.DexImport("android/widget/Toast", AccessFlags = 33)]
		public partial class Toast
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LENGTH_SHORT
				/// </java-name>
				[Dot42.DexImport("LENGTH_SHORT", "I", AccessFlags = 25)]
				public const int LENGTH_SHORT = 0;
				/// <java-name>
				/// LENGTH_LONG
				/// </java-name>
				[Dot42.DexImport("LENGTH_LONG", "I", AccessFlags = 25)]
				public const int LENGTH_LONG = 1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Toast(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// cancel
				/// </java-name>
				[Dot42.DexImport("cancel", "()V", AccessFlags = 1)]
				public virtual void Cancel() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMargin
				/// </java-name>
				[Dot42.DexImport("setMargin", "(FF)V", AccessFlags = 1)]
				public virtual void SetMargin(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(III)V", AccessFlags = 1)]
				public virtual void SetGravity(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// makeText
				/// </java-name>
				[Dot42.DexImport("makeText", "(Landroid/content/Context;Ljava/lang/CharSequence;I)Landroid/widget/Toast;", AccessFlags = 9)]
				public static global::Android.Widget.Toast MakeText(global::Android.Content.Context context, global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.Toast);
				}

				/// <java-name>
				/// makeText
				/// </java-name>
				[Dot42.DexImport("makeText", "(Landroid/content/Context;II)Landroid/widget/Toast;", AccessFlags = 9)]
				public static global::Android.Widget.Toast MakeText(global::Android.Content.Context context, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.Toast);
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(I)V", AccessFlags = 1)]
				public virtual void SetText(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetText(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Toast() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getView
				/// </java-name>
				public virtual global::Android.Views.View View
				{
						[Dot42.DexImport("getView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
						[Dot42.DexImport("setView", "(Landroid/view/View;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public virtual int Duration
				{
						[Dot42.DexImport("getDuration", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDuration", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getHorizontalMargin
				/// </java-name>
				public virtual float HorizontalMargin
				{
						[Dot42.DexImport("getHorizontalMargin", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getVerticalMargin
				/// </java-name>
				public virtual float VerticalMargin
				{
						[Dot42.DexImport("getVerticalMargin", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getGravity
				/// </java-name>
				public virtual int Gravity
				{
						[Dot42.DexImport("getGravity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getXOffset
				/// </java-name>
				public virtual int XOffset
				{
						[Dot42.DexImport("getXOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getYOffset
				/// </java-name>
				public virtual int YOffset
				{
						[Dot42.DexImport("getYOffset", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/widget/ToggleButton
		/// </java-name>
		[Dot42.DexImport("android/widget/ToggleButton", AccessFlags = 33)]
		public partial class ToggleButton : global::Android.Widget.CompoundButton
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ToggleButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ToggleButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ToggleButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public override void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal override void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public override void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ToggleButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTextOn
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence TextOn
				{
						[Dot42.DexImport("getTextOn", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setTextOn", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTextOff
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence TextOff
				{
						[Dot42.DexImport("getTextOff", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setTextOff", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// setChecked
				/// </java-name>
				public override bool IsChecked
				{
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/TwoLineListItem
		/// </java-name>
		[Dot42.DexImport("android/widget/TwoLineListItem", AccessFlags = 33)]
		public partial class TwoLineListItem : global::Android.Widget.RelativeLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TwoLineListItem(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TwoLineListItem(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TwoLineListItem(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal override void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TwoLineListItem() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getText1
				/// </java-name>
				public virtual global::Android.Widget.TextView Text1
				{
						[Dot42.DexImport("getText1", "()Landroid/widget/TextView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TextView); }
				}

				/// <java-name>
				/// getText2
				/// </java-name>
				public virtual global::Android.Widget.TextView Text2
				{
						[Dot42.DexImport("getText2", "()Landroid/widget/TextView;", AccessFlags = 1)]
						get{ return default(global::Android.Widget.TextView); }
				}

		}

		/// <java-name>
		/// android/widget/VideoView
		/// </java-name>
		[Dot42.DexImport("android/widget/VideoView", AccessFlags = 33)]
		public partial class VideoView : global::Android.Views.SurfaceView, global::Android.Widget.MediaController.IMediaPlayerControl
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public VideoView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public VideoView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public VideoView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resolveAdjustedSize
				/// </java-name>
				[Dot42.DexImport("resolveAdjustedSize", "(II)I", AccessFlags = 1)]
				public virtual int ResolveAdjustedSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setVideoPath
				/// </java-name>
				[Dot42.DexImport("setVideoPath", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetVideoPath(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setVideoURI
				/// </java-name>
				[Dot42.DexImport("setVideoURI", "(Landroid/net/Uri;)V", AccessFlags = 1)]
				public virtual void SetVideoURI(global::Android.Net.Uri uri) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopPlayback
				/// </java-name>
				[Dot42.DexImport("stopPlayback", "()V", AccessFlags = 1)]
				public virtual void StopPlayback() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMediaController
				/// </java-name>
				[Dot42.DexImport("setMediaController", "(Landroid/widget/MediaController;)V", AccessFlags = 1)]
				public virtual void SetMediaController(global::Android.Widget.MediaController mediaController) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnPreparedListener
				/// </java-name>
				[Dot42.DexImport("setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V", AccessFlags = 1)]
				public virtual void SetOnPreparedListener(global::Android.Media.MediaPlayer.IOnPreparedListener onPreparedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnCompletionListener
				/// </java-name>
				[Dot42.DexImport("setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V", AccessFlags = 1)]
				public virtual void SetOnCompletionListener(global::Android.Media.MediaPlayer.IOnCompletionListener onCompletionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnErrorListener
				/// </java-name>
				[Dot42.DexImport("setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V", AccessFlags = 1)]
				public virtual void SetOnErrorListener(global::Android.Media.MediaPlayer.IOnErrorListener onErrorListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
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
				/// suspend
				/// </java-name>
				[Dot42.DexImport("suspend", "()V", AccessFlags = 1)]
				public virtual void Suspend() /* MethodBuilder.Create */ 
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
				/// seekTo
				/// </java-name>
				[Dot42.DexImport("seekTo", "(I)V", AccessFlags = 1)]
				public virtual void SeekTo(int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal VideoView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public virtual int Duration
				{
						[Dot42.DexImport("getDuration", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCurrentPosition
				/// </java-name>
				public virtual int CurrentPosition
				{
						[Dot42.DexImport("getCurrentPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isPlaying
				/// </java-name>
				public virtual bool IsPlaying
				{
						[Dot42.DexImport("isPlaying", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getBufferPercentage
				/// </java-name>
				public virtual int BufferPercentage
				{
						[Dot42.DexImport("getBufferPercentage", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// canPause
				/// </java-name>
				public virtual bool CanPause
				{
						[Dot42.DexImport("canPause", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// canSeekBackward
				/// </java-name>
				public virtual bool CanSeekBackward
				{
						[Dot42.DexImport("canSeekBackward", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// canSeekForward
				/// </java-name>
				public virtual bool CanSeekForward
				{
						[Dot42.DexImport("canSeekForward", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/widget/ViewAnimator
		/// </java-name>
		[Dot42.DexImport("android/widget/ViewAnimator", AccessFlags = 33)]
		public partial class ViewAnimator : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ViewAnimator(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewAnimator(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showNext
				/// </java-name>
				[Dot42.DexImport("showNext", "()V", AccessFlags = 1)]
				public virtual void ShowNext() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showPrevious
				/// </java-name>
				[Dot42.DexImport("showPrevious", "()V", AccessFlags = 1)]
				public virtual void ShowPrevious() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "()V", AccessFlags = 1)]
				public override void RemoveAllViews() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeView
				/// </java-name>
				[Dot42.DexImport("removeView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void RemoveView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewAt
				/// </java-name>
				[Dot42.DexImport("removeViewAt", "(I)V", AccessFlags = 1)]
				public override void RemoveViewAt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewInLayout
				/// </java-name>
				[Dot42.DexImport("removeViewInLayout", "(Landroid/view/View;)V", AccessFlags = 1)]
				public override void RemoveViewInLayout(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViews
				/// </java-name>
				[Dot42.DexImport("removeViews", "(II)V", AccessFlags = 1)]
				public override void RemoveViews(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewsInLayout
				/// </java-name>
				[Dot42.DexImport("removeViewsInLayout", "(II)V", AccessFlags = 1)]
				public override void RemoveViewsInLayout(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setInAnimation
				/// </java-name>
				[Dot42.DexImport("setInAnimation", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetInAnimation(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOutAnimation
				/// </java-name>
				[Dot42.DexImport("setOutAnimation", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public virtual void SetOutAnimation(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAnimateFirstView
				/// </java-name>
				[Dot42.DexImport("setAnimateFirstView", "(Z)V", AccessFlags = 1)]
				public virtual void SetAnimateFirstView(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ViewAnimator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getDisplayedChild
				/// </java-name>
				public virtual int DisplayedChild
				{
						[Dot42.DexImport("getDisplayedChild", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDisplayedChild", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrentView
				/// </java-name>
				public virtual global::Android.Views.View CurrentView
				{
						[Dot42.DexImport("getCurrentView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getInAnimation
				/// </java-name>
				public virtual global::Android.Views.Animations.Animation InAnimation
				{
						[Dot42.DexImport("getInAnimation", "()Landroid/view/animation/Animation;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.Animation); }
						[Dot42.DexImport("setInAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOutAnimation
				/// </java-name>
				public virtual global::Android.Views.Animations.Animation OutAnimation
				{
						[Dot42.DexImport("getOutAnimation", "()Landroid/view/animation/Animation;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.Animation); }
						[Dot42.DexImport("setOutAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public override int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// android/widget/ViewFlipper
		/// </java-name>
		[Dot42.DexImport("android/widget/ViewFlipper", AccessFlags = 33)]
		public partial class ViewFlipper : global::Android.Widget.ViewAnimator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ViewFlipper(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewFlipper(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal override void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal override void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal override void OnWindowVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFlipInterval
				/// </java-name>
				[Dot42.DexImport("setFlipInterval", "(I)V", AccessFlags = 1)]
				public virtual void SetFlipInterval(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startFlipping
				/// </java-name>
				[Dot42.DexImport("startFlipping", "()V", AccessFlags = 1)]
				public virtual void StartFlipping() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopFlipping
				/// </java-name>
				[Dot42.DexImport("stopFlipping", "()V", AccessFlags = 1)]
				public virtual void StopFlipping() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ViewFlipper() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isFlipping
				/// </java-name>
				public virtual bool IsFlipping
				{
						[Dot42.DexImport("isFlipping", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isAutoStart
				/// </java-name>
				public virtual bool IsAutoStart
				{
						[Dot42.DexImport("isAutoStart", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAutoStart", "(Z)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/widget/ViewSwitcher
		/// </java-name>
		[Dot42.DexImport("android/widget/ViewSwitcher", AccessFlags = 33)]
		public partial class ViewSwitcher : global::Android.Widget.ViewAnimator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ViewSwitcher(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewSwitcher(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public override void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFactory
				/// </java-name>
				[Dot42.DexImport("setFactory", "(Landroid/widget/ViewSwitcher$ViewFactory;)V", AccessFlags = 1)]
				public virtual void SetFactory(global::Android.Widget.ViewSwitcher.IViewFactory viewFactory) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// reset
				/// </java-name>
				[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
				public virtual void Reset() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ViewSwitcher() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNextView
				/// </java-name>
				public virtual global::Android.Views.View NextView
				{
						[Dot42.DexImport("getNextView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// android/widget/ViewSwitcher$ViewFactory
				/// </java-name>
				[Dot42.DexImport("android/widget/ViewSwitcher$ViewFactory", AccessFlags = 1545)]
				public partial interface IViewFactory
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// makeView
						/// </java-name>
						[Dot42.DexImport("makeView", "()Landroid/view/View;", AccessFlags = 1025)]
						global::Android.Views.View MakeView() /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/ZoomButton
		/// </java-name>
		[Dot42.DexImport("android/widget/ZoomButton", AccessFlags = 33)]
		public partial class ZoomButton : global::Android.Widget.ImageButton, global::Android.Views.View.IOnLongClickListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ZoomButton(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ZoomButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ZoomButton(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setZoomSpeed
				/// </java-name>
				[Dot42.DexImport("setZoomSpeed", "(J)V", AccessFlags = 1)]
				public virtual void SetZoomSpeed(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLongClick
				/// </java-name>
				[Dot42.DexImport("onLongClick", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool OnLongClick(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchUnhandledMove
				/// </java-name>
				[Dot42.DexImport("dispatchUnhandledMove", "(Landroid/view/View;I)Z", AccessFlags = 1)]
				public override bool DispatchUnhandledMove(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ZoomButton() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
		/// android/widget/ZoomButtonsController
		/// </java-name>
		[Dot42.DexImport("android/widget/ZoomButtonsController", AccessFlags = 33)]
		public partial class ZoomButtonsController : global::Android.Views.View.IOnTouchListener
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/view/View;)V", AccessFlags = 1)]
				public ZoomButtonsController(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZoomInEnabled
				/// </java-name>
				[Dot42.DexImport("setZoomInEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetZoomInEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZoomOutEnabled
				/// </java-name>
				[Dot42.DexImport("setZoomOutEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetZoomOutEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZoomSpeed
				/// </java-name>
				[Dot42.DexImport("setZoomSpeed", "(J)V", AccessFlags = 1)]
				public virtual void SetZoomSpeed(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnZoomListener
				/// </java-name>
				[Dot42.DexImport("setOnZoomListener", "(Landroid/widget/ZoomButtonsController$OnZoomListener;)V", AccessFlags = 1)]
				public virtual void SetOnZoomListener(global::Android.Widget.ZoomButtonsController.IOnZoomListener onZoomListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFocusable
				/// </java-name>
				[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
				public virtual void SetFocusable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouch
				/// </java-name>
				[Dot42.DexImport("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouch(global::Android.Views.View view, global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ZoomButtonsController() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isAutoDismissed
				/// </java-name>
				public virtual bool IsAutoDismissed
				{
						[Dot42.DexImport("isAutoDismissed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAutoDismissed", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isVisible
				/// </java-name>
				public virtual bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setVisible", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getContainer
				/// </java-name>
				public virtual global::Android.Views.ViewGroup Container
				{
						[Dot42.DexImport("getContainer", "()Landroid/view/ViewGroup;", AccessFlags = 1)]
						get{ return default(global::Android.Views.ViewGroup); }
				}

				/// <java-name>
				/// getZoomControls
				/// </java-name>
				public virtual global::Android.Views.View ZoomControls
				{
						[Dot42.DexImport("getZoomControls", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// android/widget/ZoomButtonsController$OnZoomListener
				/// </java-name>
				[Dot42.DexImport("android/widget/ZoomButtonsController$OnZoomListener", AccessFlags = 1545)]
				public partial interface IOnZoomListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onVisibilityChanged
						/// </java-name>
						[Dot42.DexImport("onVisibilityChanged", "(Z)V", AccessFlags = 1025)]
						void OnVisibilityChanged(bool boolean) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onZoom
						/// </java-name>
						[Dot42.DexImport("onZoom", "(Z)V", AccessFlags = 1025)]
						void OnZoom(bool boolean) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/widget/ZoomControls
		/// </java-name>
		[Dot42.DexImport("android/widget/ZoomControls", AccessFlags = 33)]
		public partial class ZoomControls : global::Android.Widget.LinearLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ZoomControls(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ZoomControls(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnZoomInClickListener
				/// </java-name>
				[Dot42.DexImport("setOnZoomInClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnZoomInClickListener(global::Android.Views.View.IOnClickListener onClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnZoomOutClickListener
				/// </java-name>
				[Dot42.DexImport("setOnZoomOutClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnZoomOutClickListener(global::Android.Views.View.IOnClickListener onClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZoomSpeed
				/// </java-name>
				[Dot42.DexImport("setZoomSpeed", "(J)V", AccessFlags = 1)]
				public virtual void SetZoomSpeed(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 1)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 1)]
				public virtual void Hide() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIsZoomInEnabled
				/// </java-name>
				[Dot42.DexImport("setIsZoomInEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetIsZoomInEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIsZoomOutEnabled
				/// </java-name>
				[Dot42.DexImport("setIsZoomOutEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetIsZoomOutEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ZoomControls() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// hasFocus
				/// </java-name>
				public override bool HasFocus
				{
						[Dot42.DexImport("hasFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

}

