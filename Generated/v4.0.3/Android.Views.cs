#pragma warning disable 1717
namespace Android.Views
{
		/// <java-name>
		/// android/view/AbsSavedState
		/// </java-name>
		[Dot42.DexImport("android/view/AbsSavedState", AccessFlags = 1057)]
		public abstract partial class AbsSavedState : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// EMPTY_STATE
				/// </java-name>
				[Dot42.DexImport("EMPTY_STATE", "Landroid/view/AbsSavedState;", AccessFlags = 25)]
				public static readonly global::Android.Views.AbsSavedState EMPTY_STATE;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.AbsSavedState> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal AbsSavedState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 4)]
				protected internal AbsSavedState(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AbsSavedState() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getSuperState
				/// </java-name>
				public global::Android.OS.IParcelable SuperState
				{
						[Dot42.DexImport("getSuperState", "()Landroid/os/Parcelable;", AccessFlags = 17)]
						get{ return default(global::Android.OS.IParcelable); }
				}

		}

		/// <java-name>
		/// android/view/ActionMode
		/// </java-name>
		[Dot42.DexImport("android/view/ActionMode", AccessFlags = 1057)]
		public abstract partial class ActionMode
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ActionMode() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)V", AccessFlags = 1025)]
				public abstract void SetTitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSubtitle
				/// </java-name>
				[Dot42.DexImport("setSubtitle", "(I)V", AccessFlags = 1025)]
				public abstract void SetSubtitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "()V", AccessFlags = 1025)]
				public abstract void Invalidate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 1025)]
				public abstract void Finish() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTag
				/// </java-name>
				public virtual object Tag
				{
						[Dot42.DexImport("getTag", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
						[Dot42.DexImport("setTag", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMenu
				/// </java-name>
				public abstract global::Android.Views.IMenu Menu
				{
						[Dot42.DexImport("getMenu", "()Landroid/view/Menu;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				public abstract global::Java.Lang.ICharSequence Title
				{
						[Dot42.DexImport("getTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getSubtitle
				/// </java-name>
				public abstract global::Java.Lang.ICharSequence Subtitle
				{
						[Dot42.DexImport("getSubtitle", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setSubtitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getCustomView
				/// </java-name>
				public abstract global::Android.Views.View CustomView
				{
						[Dot42.DexImport("getCustomView", "()Landroid/view/View;", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setCustomView", "(Landroid/view/View;)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// getMenuInflater
				/// </java-name>
				public abstract global::Android.Views.MenuInflater MenuInflater
				{
						[Dot42.DexImport("getMenuInflater", "()Landroid/view/MenuInflater;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// android/view/ActionMode$Callback
				/// </java-name>
				[Dot42.DexImport("android/view/ActionMode$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCreateActionMode
						/// </java-name>
						[Dot42.DexImport("onCreateActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z", AccessFlags = 1025)]
						bool OnCreateActionMode(global::Android.Views.ActionMode actionMode, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onPrepareActionMode
						/// </java-name>
						[Dot42.DexImport("onPrepareActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z", AccessFlags = 1025)]
						bool OnPrepareActionMode(global::Android.Views.ActionMode actionMode, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActionItemClicked
						/// </java-name>
						[Dot42.DexImport("onActionItemClicked", "(Landroid/view/ActionMode;Landroid/view/MenuItem;)Z", AccessFlags = 1025)]
						bool OnActionItemClicked(global::Android.Views.ActionMode actionMode, global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDestroyActionMode
						/// </java-name>
						[Dot42.DexImport("onDestroyActionMode", "(Landroid/view/ActionMode;)V", AccessFlags = 1025)]
						void OnDestroyActionMode(global::Android.Views.ActionMode actionMode) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/ActionProvider
		/// </java-name>
		[Dot42.DexImport("android/view/ActionProvider", AccessFlags = 1057)]
		public abstract partial class ActionProvider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ActionProvider(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateActionView
				/// </java-name>
				[Dot42.DexImport("onCreateActionView", "()Landroid/view/View;", AccessFlags = 1025)]
				public abstract global::Android.Views.View OnCreateActionView() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onPerformDefaultAction
				/// </java-name>
				[Dot42.DexImport("onPerformDefaultAction", "()Z", AccessFlags = 1)]
				public virtual bool OnPerformDefaultAction() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPrepareSubMenu
				/// </java-name>
				[Dot42.DexImport("onPrepareSubMenu", "(Landroid/view/SubMenu;)V", AccessFlags = 1)]
				public virtual void OnPrepareSubMenu(global::Android.Views.ISubMenu subMenu) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ActionProvider() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// hasSubMenu
				/// </java-name>
				public virtual bool HasSubMenu
				{
						[Dot42.DexImport("hasSubMenu", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/view/ContextThemeWrapper
		/// </java-name>
		[Dot42.DexImport("android/view/ContextThemeWrapper", AccessFlags = 33)]
		public partial class ContextThemeWrapper : global::Android.Content.ContextWrapper
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ContextThemeWrapper() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public ContextThemeWrapper(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachBaseContext
				/// </java-name>
				[Dot42.DexImport("attachBaseContext", "(Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal override void AttachBaseContext(global::Android.Content.Context context) /* MethodBuilder.Create */ 
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
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string @string) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// onApplyThemeResource
				/// </java-name>
				[Dot42.DexImport("onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V", AccessFlags = 4)]
				protected internal virtual void OnApplyThemeResource(global::Android.Content.Res.Resources.Theme theme, int int32, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTheme
				/// </java-name>
				public override global::Android.Content.Res.Resources.Theme Theme
				{
						[Dot42.DexImport("getTheme", "()Landroid/content/res/Resources$Theme;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources.Theme); }
				}

		}

		/// <java-name>
		/// android/view/Display
		/// </java-name>
		[Dot42.DexImport("android/view/Display", AccessFlags = 33)]
		public partial class Display
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// DEFAULT_DISPLAY
				/// </java-name>
				[Dot42.DexImport("DEFAULT_DISPLAY", "I", AccessFlags = 25)]
				public const int DEFAULT_DISPLAY = 0;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Display() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "(Landroid/graphics/Point;)V", AccessFlags = 1)]
				public virtual void GetSize(global::Android.Graphics.Point point) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRectSize
				/// </java-name>
				[Dot42.DexImport("getRectSize", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetRectSize(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "(Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void GetMetrics(global::Android.Util.DisplayMetrics displayMetrics) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDisplayId
				/// </java-name>
				public virtual int DisplayId
				{
						[Dot42.DexImport("getDisplayId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRotation
				/// </java-name>
				public virtual int Rotation
				{
						[Dot42.DexImport("getRotation", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getOrientation
				/// </java-name>
				public virtual int Orientation
				{
						[Dot42.DexImport("getOrientation", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPixelFormat
				/// </java-name>
				public virtual int PixelFormat
				{
						[Dot42.DexImport("getPixelFormat", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRefreshRate
				/// </java-name>
				public virtual float RefreshRate
				{
						[Dot42.DexImport("getRefreshRate", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

		}

		/// <java-name>
		/// android/view/DragEvent
		/// </java-name>
		[Dot42.DexImport("android/view/DragEvent", AccessFlags = 33)]
		public partial class DragEvent : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_DRAG_STARTED
				/// </java-name>
				[Dot42.DexImport("ACTION_DRAG_STARTED", "I", AccessFlags = 25)]
				public const int ACTION_DRAG_STARTED = 1;
				/// <java-name>
				/// ACTION_DRAG_LOCATION
				/// </java-name>
				[Dot42.DexImport("ACTION_DRAG_LOCATION", "I", AccessFlags = 25)]
				public const int ACTION_DRAG_LOCATION = 2;
				/// <java-name>
				/// ACTION_DROP
				/// </java-name>
				[Dot42.DexImport("ACTION_DROP", "I", AccessFlags = 25)]
				public const int ACTION_DROP = 3;
				/// <java-name>
				/// ACTION_DRAG_ENDED
				/// </java-name>
				[Dot42.DexImport("ACTION_DRAG_ENDED", "I", AccessFlags = 25)]
				public const int ACTION_DRAG_ENDED = 4;
				/// <java-name>
				/// ACTION_DRAG_ENTERED
				/// </java-name>
				[Dot42.DexImport("ACTION_DRAG_ENTERED", "I", AccessFlags = 25)]
				public const int ACTION_DRAG_ENTERED = 5;
				/// <java-name>
				/// ACTION_DRAG_EXITED
				/// </java-name>
				[Dot42.DexImport("ACTION_DRAG_EXITED", "I", AccessFlags = 25)]
				public const int ACTION_DRAG_EXITED = 6;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.DragEvent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal DragEvent() /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// getAction
				/// </java-name>
				public virtual int Action
				{
						[Dot42.DexImport("getAction", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getX
				/// </java-name>
				public virtual float X
				{
						[Dot42.DexImport("getX", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getY
				/// </java-name>
				public virtual float Y
				{
						[Dot42.DexImport("getY", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getClipData
				/// </java-name>
				public virtual global::Android.Content.ClipData ClipData
				{
						[Dot42.DexImport("getClipData", "()Landroid/content/ClipData;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ClipData); }
				}

				/// <java-name>
				/// getClipDescription
				/// </java-name>
				public virtual global::Android.Content.ClipDescription ClipDescription
				{
						[Dot42.DexImport("getClipDescription", "()Landroid/content/ClipDescription;", AccessFlags = 1)]
						get{ return default(global::Android.Content.ClipDescription); }
				}

				/// <java-name>
				/// getLocalState
				/// </java-name>
				public virtual object LocalState
				{
						[Dot42.DexImport("getLocalState", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
				}

				/// <java-name>
				/// getResult
				/// </java-name>
				public virtual bool IsResult
				{
						[Dot42.DexImport("getResult", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/view/FocusFinder
		/// </java-name>
		[Dot42.DexImport("android/view/FocusFinder", AccessFlags = 33)]
		public partial class FocusFinder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal FocusFinder() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findNextFocus
				/// </java-name>
				[Dot42.DexImport("findNextFocus", "(Landroid/view/ViewGroup;Landroid/view/View;I)Landroid/view/View;", AccessFlags = 17)]
				public global::Android.Views.View FindNextFocus(global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// findNextFocusFromRect
				/// </java-name>
				[Dot42.DexImport("findNextFocusFromRect", "(Landroid/view/ViewGroup;Landroid/graphics/Rect;I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindNextFocusFromRect(global::Android.Views.ViewGroup viewGroup, global::Android.Graphics.Rect rect, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// findNearestTouchable
				/// </java-name>
				[Dot42.DexImport("findNearestTouchable", "(Landroid/view/ViewGroup;III[I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindNearestTouchable(global::Android.Views.ViewGroup viewGroup, int int32, int int321, int int322, int[] int323) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Views.FocusFinder Instance
				{
						[Dot42.DexImport("getInstance", "()Landroid/view/FocusFinder;", AccessFlags = 9)]
						get{ return default(global::Android.Views.FocusFinder); }
				}

		}

		/// <java-name>
		/// android/view/GestureDetector
		/// </java-name>
		[Dot42.DexImport("android/view/GestureDetector", AccessFlags = 33)]
		public partial class GestureDetector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Views.GestureDetector.IOnGestureListener onGestureListener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Views.GestureDetector.IOnGestureListener onGestureListener) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Content.Context context, global::Android.Views.GestureDetector.IOnGestureListener onGestureListener) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroi" +
    "d/os/Handler;)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Content.Context context, global::Android.Views.GestureDetector.IOnGestureListener onGestureListener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroi" +
    "d/os/Handler;Z)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Content.Context context, global::Android.Views.GestureDetector.IOnGestureListener onGestureListener, global::Android.OS.Handler handler, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDoubleTapListener
				/// </java-name>
				[Dot42.DexImport("setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V", AccessFlags = 1)]
				public virtual void SetOnDoubleTapListener(global::Android.Views.GestureDetector.IOnDoubleTapListener onDoubleTapListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIsLongpressEnabled
				/// </java-name>
				[Dot42.DexImport("setIsLongpressEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetIsLongpressEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GestureDetector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isLongpressEnabled
				/// </java-name>
				public virtual bool IsLongpressEnabled
				{
						[Dot42.DexImport("isLongpressEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/view/GestureDetector$SimpleOnGestureListener
				/// </java-name>
				[Dot42.DexImport("android/view/GestureDetector$SimpleOnGestureListener", AccessFlags = 9)]
				public partial class SimpleOnGestureListener : global::Android.Views.GestureDetector.IOnGestureListener, global::Android.Views.GestureDetector.IOnDoubleTapListener
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public SimpleOnGestureListener() /* MethodBuilder.Create */ 
						{
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
						/// onLongPress
						/// </java-name>
						[Dot42.DexImport("onLongPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
						public virtual void OnLongPress(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
						{
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
						/// onFling
						/// </java-name>
						[Dot42.DexImport("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1)]
						public virtual bool OnFling(global::Android.Views.MotionEvent motionEvent, global::Android.Views.MotionEvent motionEvent1, float single, float single1) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// onShowPress
						/// </java-name>
						[Dot42.DexImport("onShowPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
						public virtual void OnShowPress(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
						{
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
						/// onDoubleTap
						/// </java-name>
						[Dot42.DexImport("onDoubleTap", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
						public virtual bool OnDoubleTap(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// onDoubleTapEvent
						/// </java-name>
						[Dot42.DexImport("onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
						public virtual bool OnDoubleTapEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// onSingleTapConfirmed
						/// </java-name>
						[Dot42.DexImport("onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
						public virtual bool OnSingleTapConfirmed(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

				/// <java-name>
				/// android/view/GestureDetector$OnDoubleTapListener
				/// </java-name>
				[Dot42.DexImport("android/view/GestureDetector$OnDoubleTapListener", AccessFlags = 1545)]
				public partial interface IOnDoubleTapListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSingleTapConfirmed
						/// </java-name>
						[Dot42.DexImport("onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnSingleTapConfirmed(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDoubleTap
						/// </java-name>
						[Dot42.DexImport("onDoubleTap", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnDoubleTap(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDoubleTapEvent
						/// </java-name>
						[Dot42.DexImport("onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnDoubleTapEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/GestureDetector$OnGestureListener
				/// </java-name>
				[Dot42.DexImport("android/view/GestureDetector$OnGestureListener", AccessFlags = 1545)]
				public partial interface IOnGestureListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDown
						/// </java-name>
						[Dot42.DexImport("onDown", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnDown(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onShowPress
						/// </java-name>
						[Dot42.DexImport("onShowPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1025)]
						void OnShowPress(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onSingleTapUp
						/// </java-name>
						[Dot42.DexImport("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnSingleTapUp(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onScroll
						/// </java-name>
						[Dot42.DexImport("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1025)]
						bool OnScroll(global::Android.Views.MotionEvent motionEvent, global::Android.Views.MotionEvent motionEvent1, float single, float single1) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onLongPress
						/// </java-name>
						[Dot42.DexImport("onLongPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1025)]
						void OnLongPress(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onFling
						/// </java-name>
						[Dot42.DexImport("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1025)]
						bool OnFling(global::Android.Views.MotionEvent motionEvent, global::Android.Views.MotionEvent motionEvent1, float single, float single1) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/Gravity
		/// </java-name>
		[Dot42.DexImport("android/view/Gravity", AccessFlags = 33)]
		public partial class Gravity
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NO_GRAVITY
				/// </java-name>
				[Dot42.DexImport("NO_GRAVITY", "I", AccessFlags = 25)]
				public const int NO_GRAVITY = 0;
				/// <java-name>
				/// AXIS_SPECIFIED
				/// </java-name>
				[Dot42.DexImport("AXIS_SPECIFIED", "I", AccessFlags = 25)]
				public const int AXIS_SPECIFIED = 1;
				/// <java-name>
				/// AXIS_PULL_BEFORE
				/// </java-name>
				[Dot42.DexImport("AXIS_PULL_BEFORE", "I", AccessFlags = 25)]
				public const int AXIS_PULL_BEFORE = 2;
				/// <java-name>
				/// AXIS_PULL_AFTER
				/// </java-name>
				[Dot42.DexImport("AXIS_PULL_AFTER", "I", AccessFlags = 25)]
				public const int AXIS_PULL_AFTER = 4;
				/// <java-name>
				/// AXIS_CLIP
				/// </java-name>
				[Dot42.DexImport("AXIS_CLIP", "I", AccessFlags = 25)]
				public const int AXIS_CLIP = 8;
				/// <java-name>
				/// AXIS_X_SHIFT
				/// </java-name>
				[Dot42.DexImport("AXIS_X_SHIFT", "I", AccessFlags = 25)]
				public const int AXIS_X_SHIFT = 0;
				/// <java-name>
				/// AXIS_Y_SHIFT
				/// </java-name>
				[Dot42.DexImport("AXIS_Y_SHIFT", "I", AccessFlags = 25)]
				public const int AXIS_Y_SHIFT = 4;
				/// <java-name>
				/// TOP
				/// </java-name>
				[Dot42.DexImport("TOP", "I", AccessFlags = 25)]
				public const int TOP = 48;
				/// <java-name>
				/// BOTTOM
				/// </java-name>
				[Dot42.DexImport("BOTTOM", "I", AccessFlags = 25)]
				public const int BOTTOM = 80;
				/// <java-name>
				/// LEFT
				/// </java-name>
				[Dot42.DexImport("LEFT", "I", AccessFlags = 25)]
				public const int LEFT = 3;
				/// <java-name>
				/// RIGHT
				/// </java-name>
				[Dot42.DexImport("RIGHT", "I", AccessFlags = 25)]
				public const int RIGHT = 5;
				/// <java-name>
				/// CENTER_VERTICAL
				/// </java-name>
				[Dot42.DexImport("CENTER_VERTICAL", "I", AccessFlags = 25)]
				public const int CENTER_VERTICAL = 16;
				/// <java-name>
				/// FILL_VERTICAL
				/// </java-name>
				[Dot42.DexImport("FILL_VERTICAL", "I", AccessFlags = 25)]
				public const int FILL_VERTICAL = 112;
				/// <java-name>
				/// CENTER_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("CENTER_HORIZONTAL", "I", AccessFlags = 25)]
				public const int CENTER_HORIZONTAL = 1;
				/// <java-name>
				/// FILL_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("FILL_HORIZONTAL", "I", AccessFlags = 25)]
				public const int FILL_HORIZONTAL = 7;
				/// <java-name>
				/// CENTER
				/// </java-name>
				[Dot42.DexImport("CENTER", "I", AccessFlags = 25)]
				public const int CENTER = 17;
				/// <java-name>
				/// FILL
				/// </java-name>
				[Dot42.DexImport("FILL", "I", AccessFlags = 25)]
				public const int FILL = 119;
				/// <java-name>
				/// CLIP_VERTICAL
				/// </java-name>
				[Dot42.DexImport("CLIP_VERTICAL", "I", AccessFlags = 25)]
				public const int CLIP_VERTICAL = 128;
				/// <java-name>
				/// CLIP_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("CLIP_HORIZONTAL", "I", AccessFlags = 25)]
				public const int CLIP_HORIZONTAL = 8;
				/// <java-name>
				/// RELATIVE_LAYOUT_DIRECTION
				/// </java-name>
				[Dot42.DexImport("RELATIVE_LAYOUT_DIRECTION", "I", AccessFlags = 25)]
				public const int RELATIVE_LAYOUT_DIRECTION = 8388608;
				/// <java-name>
				/// HORIZONTAL_GRAVITY_MASK
				/// </java-name>
				[Dot42.DexImport("HORIZONTAL_GRAVITY_MASK", "I", AccessFlags = 25)]
				public const int HORIZONTAL_GRAVITY_MASK = 7;
				/// <java-name>
				/// VERTICAL_GRAVITY_MASK
				/// </java-name>
				[Dot42.DexImport("VERTICAL_GRAVITY_MASK", "I", AccessFlags = 25)]
				public const int VERTICAL_GRAVITY_MASK = 112;
				/// <java-name>
				/// DISPLAY_CLIP_VERTICAL
				/// </java-name>
				[Dot42.DexImport("DISPLAY_CLIP_VERTICAL", "I", AccessFlags = 25)]
				public const int DISPLAY_CLIP_VERTICAL = 268435456;
				/// <java-name>
				/// DISPLAY_CLIP_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("DISPLAY_CLIP_HORIZONTAL", "I", AccessFlags = 25)]
				public const int DISPLAY_CLIP_HORIZONTAL = 16777216;
				/// <java-name>
				/// START
				/// </java-name>
				[Dot42.DexImport("START", "I", AccessFlags = 25)]
				public const int START = 8388611;
				/// <java-name>
				/// END
				/// </java-name>
				[Dot42.DexImport("END", "I", AccessFlags = 25)]
				public const int END = 8388613;
				/// <java-name>
				/// RELATIVE_HORIZONTAL_GRAVITY_MASK
				/// </java-name>
				[Dot42.DexImport("RELATIVE_HORIZONTAL_GRAVITY_MASK", "I", AccessFlags = 25)]
				public const int RELATIVE_HORIZONTAL_GRAVITY_MASK = 8388615;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Gravity() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(IIILandroid/graphics/Rect;Landroid/graphics/Rect;)V", AccessFlags = 9)]
				public static void Apply(int int32, int int321, int int322, global::Android.Graphics.Rect rect, global::Android.Graphics.Rect rect1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(IIILandroid/graphics/Rect;IILandroid/graphics/Rect;)V", AccessFlags = 9)]
				public static void Apply(int int32, int int321, int int322, global::Android.Graphics.Rect rect, int int323, int int324, global::Android.Graphics.Rect rect1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// applyDisplay
				/// </java-name>
				[Dot42.DexImport("applyDisplay", "(ILandroid/graphics/Rect;Landroid/graphics/Rect;)V", AccessFlags = 9)]
				public static void ApplyDisplay(int int32, global::Android.Graphics.Rect rect, global::Android.Graphics.Rect rect1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isVertical
				/// </java-name>
				[Dot42.DexImport("isVertical", "(I)Z", AccessFlags = 9)]
				public static bool IsVertical(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isHorizontal
				/// </java-name>
				[Dot42.DexImport("isHorizontal", "(I)Z", AccessFlags = 9)]
				public static bool IsHorizontal(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getAbsoluteGravity
				/// </java-name>
				[Dot42.DexImport("getAbsoluteGravity", "(II)I", AccessFlags = 9)]
				public static int GetAbsoluteGravity(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/view/HapticFeedbackConstants
		/// </java-name>
		[Dot42.DexImport("android/view/HapticFeedbackConstants", AccessFlags = 33)]
		public partial class HapticFeedbackConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// LONG_PRESS
				/// </java-name>
				[Dot42.DexImport("LONG_PRESS", "I", AccessFlags = 25)]
				public const int LONG_PRESS = 0;
				/// <java-name>
				/// VIRTUAL_KEY
				/// </java-name>
				[Dot42.DexImport("VIRTUAL_KEY", "I", AccessFlags = 25)]
				public const int VIRTUAL_KEY = 1;
				/// <java-name>
				/// KEYBOARD_TAP
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_TAP", "I", AccessFlags = 25)]
				public const int KEYBOARD_TAP = 3;
				/// <java-name>
				/// FLAG_IGNORE_VIEW_SETTING
				/// </java-name>
				[Dot42.DexImport("FLAG_IGNORE_VIEW_SETTING", "I", AccessFlags = 25)]
				public const int FLAG_IGNORE_VIEW_SETTING = 1;
				/// <java-name>
				/// FLAG_IGNORE_GLOBAL_SETTING
				/// </java-name>
				[Dot42.DexImport("FLAG_IGNORE_GLOBAL_SETTING", "I", AccessFlags = 25)]
				public const int FLAG_IGNORE_GLOBAL_SETTING = 2;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal HapticFeedbackConstants() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/view/CollapsibleActionView
		/// </java-name>
		[Dot42.DexImport("android/view/CollapsibleActionView", AccessFlags = 1537)]
		public partial interface ICollapsibleActionView
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onActionViewExpanded
				/// </java-name>
				[Dot42.DexImport("onActionViewExpanded", "()V", AccessFlags = 1025)]
				void OnActionViewExpanded() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onActionViewCollapsed
				/// </java-name>
				[Dot42.DexImport("onActionViewCollapsed", "()V", AccessFlags = 1025)]
				void OnActionViewCollapsed() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/ContextMenu
		/// </java-name>
		[Dot42.DexImport("android/view/ContextMenu", AccessFlags = 1537)]
		public partial interface IContextMenu : global::Android.Views.IMenu
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setHeaderTitle
				/// </java-name>
				[Dot42.DexImport("setHeaderTitle", "(I)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderTitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaderTitle
				/// </java-name>
				[Dot42.DexImport("setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaderIcon
				/// </java-name>
				[Dot42.DexImport("setHeaderIcon", "(I)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderIcon(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaderIcon
				/// </java-name>
				[Dot42.DexImport("setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderIcon(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaderView
				/// </java-name>
				[Dot42.DexImport("setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearHeader
				/// </java-name>
				[Dot42.DexImport("clearHeader", "()V", AccessFlags = 1025)]
				void ClearHeader() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/ContextMenu$ContextMenuInfo
		/// </java-name>
		[Dot42.DexImport("android/view/ContextMenu$ContextMenuInfo", AccessFlags = 1545)]
		public partial interface IContextMenu_IContextMenuInfo
 /* scope: __dot42__ */ 
		{
		}

		/// <java-name>
		/// android/view/Menu
		/// </java-name>
		[Dot42.DexImport("android/view/Menu", AccessFlags = 1537)]
		public partial interface IMenu
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem Add(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem Add(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem Add(int int32, int int321, int int322, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(IIII)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem Add(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addSubMenu
				/// </java-name>
				[Dot42.DexImport("addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu AddSubMenu(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addSubMenu
				/// </java-name>
				[Dot42.DexImport("addSubMenu", "(I)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu AddSubMenu(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addSubMenu
				/// </java-name>
				[Dot42.DexImport("addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu AddSubMenu(int int32, int int321, int int322, global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addSubMenu
				/// </java-name>
				[Dot42.DexImport("addSubMenu", "(IIII)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu AddSubMenu(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addIntentOptions
				/// </java-name>
				[Dot42.DexImport("addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Inte" +
    "nt;I[Landroid/view/MenuItem;)I", AccessFlags = 1025)]
				int AddIntentOptions(int int32, int int321, int int322, global::Android.Content.ComponentName componentName, global::Android.Content.Intent[] intent, global::Android.Content.Intent intent1, int int323, global::Android.Views.IMenuItem[] menuItem) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeItem
				/// </java-name>
				[Dot42.DexImport("removeItem", "(I)V", AccessFlags = 1025)]
				void RemoveItem(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeGroup
				/// </java-name>
				[Dot42.DexImport("removeGroup", "(I)V", AccessFlags = 1025)]
				void RemoveGroup(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setGroupCheckable
				/// </java-name>
				[Dot42.DexImport("setGroupCheckable", "(IZZ)V", AccessFlags = 1025)]
				void SetGroupCheckable(int int32, bool boolean, bool boolean1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setGroupVisible
				/// </java-name>
				[Dot42.DexImport("setGroupVisible", "(IZ)V", AccessFlags = 1025)]
				void SetGroupVisible(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setGroupEnabled
				/// </java-name>
				[Dot42.DexImport("setGroupEnabled", "(IZ)V", AccessFlags = 1025)]
				void SetGroupEnabled(int int32, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// findItem
				/// </java-name>
				[Dot42.DexImport("findItem", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem FindItem(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem GetItem(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performShortcut
				/// </java-name>
				[Dot42.DexImport("performShortcut", "(ILandroid/view/KeyEvent;I)Z", AccessFlags = 1025)]
				bool PerformShortcut(int int32, global::Android.Views.KeyEvent keyEvent, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isShortcutKey
				/// </java-name>
				[Dot42.DexImport("isShortcutKey", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool IsShortcutKey(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performIdentifierAction
				/// </java-name>
				[Dot42.DexImport("performIdentifierAction", "(II)Z", AccessFlags = 1025)]
				bool PerformIdentifierAction(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setQwertyMode
				/// </java-name>
				[Dot42.DexImport("setQwertyMode", "(Z)V", AccessFlags = 1025)]
				void SetQwertyMode(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasVisibleItems
				/// </java-name>
				bool HasVisibleItems
				{
						[Dot42.DexImport("hasVisibleItems", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/view/Menu
		/// </java-name>
		[Dot42.DexImport("android/view/Menu", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IMenuConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// NONE
				/// </java-name>
				[Dot42.DexImport("NONE", "I", AccessFlags = 25)]
				public const int NONE = 0;
				/// <java-name>
				/// FIRST
				/// </java-name>
				[Dot42.DexImport("FIRST", "I", AccessFlags = 25)]
				public const int FIRST = 1;
				/// <java-name>
				/// CATEGORY_CONTAINER
				/// </java-name>
				[Dot42.DexImport("CATEGORY_CONTAINER", "I", AccessFlags = 25)]
				public const int CATEGORY_CONTAINER = 65536;
				/// <java-name>
				/// CATEGORY_SYSTEM
				/// </java-name>
				[Dot42.DexImport("CATEGORY_SYSTEM", "I", AccessFlags = 25)]
				public const int CATEGORY_SYSTEM = 131072;
				/// <java-name>
				/// CATEGORY_SECONDARY
				/// </java-name>
				[Dot42.DexImport("CATEGORY_SECONDARY", "I", AccessFlags = 25)]
				public const int CATEGORY_SECONDARY = 196608;
				/// <java-name>
				/// CATEGORY_ALTERNATIVE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_ALTERNATIVE", "I", AccessFlags = 25)]
				public const int CATEGORY_ALTERNATIVE = 262144;
				/// <java-name>
				/// FLAG_APPEND_TO_GROUP
				/// </java-name>
				[Dot42.DexImport("FLAG_APPEND_TO_GROUP", "I", AccessFlags = 25)]
				public const int FLAG_APPEND_TO_GROUP = 1;
				/// <java-name>
				/// FLAG_PERFORM_NO_CLOSE
				/// </java-name>
				[Dot42.DexImport("FLAG_PERFORM_NO_CLOSE", "I", AccessFlags = 25)]
				public const int FLAG_PERFORM_NO_CLOSE = 1;
				/// <java-name>
				/// FLAG_ALWAYS_PERFORM_CLOSE
				/// </java-name>
				[Dot42.DexImport("FLAG_ALWAYS_PERFORM_CLOSE", "I", AccessFlags = 25)]
				public const int FLAG_ALWAYS_PERFORM_CLOSE = 2;
		}

		/// <java-name>
		/// android/view/MenuItem
		/// </java-name>
		[Dot42.DexImport("android/view/MenuItem", AccessFlags = 1537)]
		public partial interface IMenuItem
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetTitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTitleCondensed
				/// </java-name>
				[Dot42.DexImport("setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetTitleCondensed(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetIcon(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetIcon(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIntent
				/// </java-name>
				[Dot42.DexImport("setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setShortcut
				/// </java-name>
				[Dot42.DexImport("setShortcut", "(CC)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetShortcut(char @char, char char1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setNumericShortcut
				/// </java-name>
				[Dot42.DexImport("setNumericShortcut", "(C)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetNumericShortcut(char @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setAlphabeticShortcut
				/// </java-name>
				[Dot42.DexImport("setAlphabeticShortcut", "(C)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetAlphabeticShortcut(char @char) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setCheckable
				/// </java-name>
				[Dot42.DexImport("setCheckable", "(Z)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetCheckable(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetChecked(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(Z)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetVisible(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetEnabled(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOnMenuItemClickListener
				/// </java-name>
				[Dot42.DexImport("setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetOnMenuItemClickListener(global::Android.Views.IMenuItem_IOnMenuItemClickListener menuItem_IOnMenuItemClickListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setShowAsAction
				/// </java-name>
				[Dot42.DexImport("setShowAsAction", "(I)V", AccessFlags = 1025)]
				void SetShowAsAction(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setShowAsActionFlags
				/// </java-name>
				[Dot42.DexImport("setShowAsActionFlags", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetShowAsActionFlags(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setActionView
				/// </java-name>
				[Dot42.DexImport("setActionView", "(Landroid/view/View;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetActionView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setActionView
				/// </java-name>
				[Dot42.DexImport("setActionView", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetActionView(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setActionProvider
				/// </java-name>
				[Dot42.DexImport("setActionProvider", "(Landroid/view/ActionProvider;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetActionProvider(global::Android.Views.ActionProvider actionProvider) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// expandActionView
				/// </java-name>
				[Dot42.DexImport("expandActionView", "()Z", AccessFlags = 1025)]
				bool ExpandActionView() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// collapseActionView
				/// </java-name>
				[Dot42.DexImport("collapseActionView", "()Z", AccessFlags = 1025)]
				bool CollapseActionView() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setOnActionExpandListener
				/// </java-name>
				[Dot42.DexImport("setOnActionExpandListener", "(Landroid/view/MenuItem$OnActionExpandListener;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetOnActionExpandListener(global::Android.Views.IMenuItem_IOnActionExpandListener menuItem_IOnActionExpandListener) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getItemId
				/// </java-name>
				int ItemId
				{
						[Dot42.DexImport("getItemId", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getGroupId
				/// </java-name>
				int GroupId
				{
						[Dot42.DexImport("getGroupId", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getOrder
				/// </java-name>
				int Order
				{
						[Dot42.DexImport("getOrder", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				global::Java.Lang.ICharSequence Title
				{
						[Dot42.DexImport("getTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getTitleCondensed
				/// </java-name>
				global::Java.Lang.ICharSequence TitleCondensed
				{
						[Dot42.DexImport("getTitleCondensed", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getIcon
				/// </java-name>
				global::Android.Graphics.Drawables.Drawable Icon
				{
						[Dot42.DexImport("getIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getIntent
				/// </java-name>
				global::Android.Content.Intent Intent
				{
						[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNumericShortcut
				/// </java-name>
				char NumericShortcut
				{
						[Dot42.DexImport("getNumericShortcut", "()C", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getAlphabeticShortcut
				/// </java-name>
				char AlphabeticShortcut
				{
						[Dot42.DexImport("getAlphabeticShortcut", "()C", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isCheckable
				/// </java-name>
				bool IsCheckable
				{
						[Dot42.DexImport("isCheckable", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isChecked
				/// </java-name>
				bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isVisible
				/// </java-name>
				bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasSubMenu
				/// </java-name>
				bool HasSubMenu
				{
						[Dot42.DexImport("hasSubMenu", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSubMenu
				/// </java-name>
				global::Android.Views.ISubMenu SubMenu
				{
						[Dot42.DexImport("getSubMenu", "()Landroid/view/SubMenu;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getMenuInfo
				/// </java-name>
				global::Android.Views.IContextMenu_IContextMenuInfo MenuInfo
				{
						[Dot42.DexImport("getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getActionView
				/// </java-name>
				global::Android.Views.View ActionView
				{
						[Dot42.DexImport("getActionView", "()Landroid/view/View;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getActionProvider
				/// </java-name>
				global::Android.Views.ActionProvider ActionProvider
				{
						[Dot42.DexImport("getActionProvider", "()Landroid/view/ActionProvider;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isActionViewExpanded
				/// </java-name>
				bool IsActionViewExpanded
				{
						[Dot42.DexImport("isActionViewExpanded", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/view/MenuItem$OnActionExpandListener
		/// </java-name>
		[Dot42.DexImport("android/view/MenuItem$OnActionExpandListener", AccessFlags = 1545)]
		public partial interface IMenuItem_IOnActionExpandListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onMenuItemActionExpand
				/// </java-name>
				[Dot42.DexImport("onMenuItemActionExpand", "(Landroid/view/MenuItem;)Z", AccessFlags = 1025)]
				bool OnMenuItemActionExpand(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onMenuItemActionCollapse
				/// </java-name>
				[Dot42.DexImport("onMenuItemActionCollapse", "(Landroid/view/MenuItem;)Z", AccessFlags = 1025)]
				bool OnMenuItemActionCollapse(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/MenuItem$OnMenuItemClickListener
		/// </java-name>
		[Dot42.DexImport("android/view/MenuItem$OnMenuItemClickListener", AccessFlags = 1545)]
		public partial interface IMenuItem_IOnMenuItemClickListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// onMenuItemClick
				/// </java-name>
				[Dot42.DexImport("onMenuItemClick", "(Landroid/view/MenuItem;)Z", AccessFlags = 1025)]
				bool OnMenuItemClick(global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/MenuItem
		/// </java-name>
		[Dot42.DexImport("android/view/MenuItem", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IMenuItemConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SHOW_AS_ACTION_NEVER
				/// </java-name>
				[Dot42.DexImport("SHOW_AS_ACTION_NEVER", "I", AccessFlags = 25)]
				public const int SHOW_AS_ACTION_NEVER = 0;
				/// <java-name>
				/// SHOW_AS_ACTION_IF_ROOM
				/// </java-name>
				[Dot42.DexImport("SHOW_AS_ACTION_IF_ROOM", "I", AccessFlags = 25)]
				public const int SHOW_AS_ACTION_IF_ROOM = 1;
				/// <java-name>
				/// SHOW_AS_ACTION_ALWAYS
				/// </java-name>
				[Dot42.DexImport("SHOW_AS_ACTION_ALWAYS", "I", AccessFlags = 25)]
				public const int SHOW_AS_ACTION_ALWAYS = 2;
				/// <java-name>
				/// SHOW_AS_ACTION_WITH_TEXT
				/// </java-name>
				[Dot42.DexImport("SHOW_AS_ACTION_WITH_TEXT", "I", AccessFlags = 25)]
				public const int SHOW_AS_ACTION_WITH_TEXT = 4;
				/// <java-name>
				/// SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW
				/// </java-name>
				[Dot42.DexImport("SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW", "I", AccessFlags = 25)]
				public const int SHOW_AS_ACTION_COLLAPSE_ACTION_VIEW = 8;
		}

		/// <java-name>
		/// android/view/InflateException
		/// </java-name>
		[Dot42.DexImport("android/view/InflateException", AccessFlags = 33)]
		public partial class InflateException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public InflateException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InflateException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public InflateException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public InflateException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/view/InputDevice
		/// </java-name>
		[Dot42.DexImport("android/view/InputDevice", AccessFlags = 49)]
		public sealed partial class InputDevice : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SOURCE_CLASS_MASK
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_MASK", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_MASK = 255;
				/// <java-name>
				/// SOURCE_CLASS_BUTTON
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_BUTTON", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_BUTTON = 1;
				/// <java-name>
				/// SOURCE_CLASS_POINTER
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_POINTER", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_POINTER = 2;
				/// <java-name>
				/// SOURCE_CLASS_TRACKBALL
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_TRACKBALL", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_TRACKBALL = 4;
				/// <java-name>
				/// SOURCE_CLASS_POSITION
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_POSITION", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_POSITION = 8;
				/// <java-name>
				/// SOURCE_CLASS_JOYSTICK
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_JOYSTICK", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_JOYSTICK = 16;
				/// <java-name>
				/// SOURCE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("SOURCE_UNKNOWN", "I", AccessFlags = 25)]
				public const int SOURCE_UNKNOWN = 0;
				/// <java-name>
				/// SOURCE_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("SOURCE_KEYBOARD", "I", AccessFlags = 25)]
				public const int SOURCE_KEYBOARD = 257;
				/// <java-name>
				/// SOURCE_DPAD
				/// </java-name>
				[Dot42.DexImport("SOURCE_DPAD", "I", AccessFlags = 25)]
				public const int SOURCE_DPAD = 513;
				/// <java-name>
				/// SOURCE_GAMEPAD
				/// </java-name>
				[Dot42.DexImport("SOURCE_GAMEPAD", "I", AccessFlags = 25)]
				public const int SOURCE_GAMEPAD = 1025;
				/// <java-name>
				/// SOURCE_TOUCHSCREEN
				/// </java-name>
				[Dot42.DexImport("SOURCE_TOUCHSCREEN", "I", AccessFlags = 25)]
				public const int SOURCE_TOUCHSCREEN = 4098;
				/// <java-name>
				/// SOURCE_MOUSE
				/// </java-name>
				[Dot42.DexImport("SOURCE_MOUSE", "I", AccessFlags = 25)]
				public const int SOURCE_MOUSE = 8194;
				/// <java-name>
				/// SOURCE_STYLUS
				/// </java-name>
				[Dot42.DexImport("SOURCE_STYLUS", "I", AccessFlags = 25)]
				public const int SOURCE_STYLUS = 16386;
				/// <java-name>
				/// SOURCE_TRACKBALL
				/// </java-name>
				[Dot42.DexImport("SOURCE_TRACKBALL", "I", AccessFlags = 25)]
				public const int SOURCE_TRACKBALL = 65540;
				/// <java-name>
				/// SOURCE_TOUCHPAD
				/// </java-name>
				[Dot42.DexImport("SOURCE_TOUCHPAD", "I", AccessFlags = 25)]
				public const int SOURCE_TOUCHPAD = 1048584;
				/// <java-name>
				/// SOURCE_JOYSTICK
				/// </java-name>
				[Dot42.DexImport("SOURCE_JOYSTICK", "I", AccessFlags = 25)]
				public const int SOURCE_JOYSTICK = 16777232;
				/// <java-name>
				/// SOURCE_ANY
				/// </java-name>
				[Dot42.DexImport("SOURCE_ANY", "I", AccessFlags = 25)]
				public const int SOURCE_ANY = -256;
				/// <java-name>
				/// MOTION_RANGE_X
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_X", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_X = 0;
				/// <java-name>
				/// MOTION_RANGE_Y
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_Y", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_Y = 1;
				/// <java-name>
				/// MOTION_RANGE_PRESSURE
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_PRESSURE", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_PRESSURE = 2;
				/// <java-name>
				/// MOTION_RANGE_SIZE
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_SIZE", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_SIZE = 3;
				/// <java-name>
				/// MOTION_RANGE_TOUCH_MAJOR
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_TOUCH_MAJOR", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_TOUCH_MAJOR = 4;
				/// <java-name>
				/// MOTION_RANGE_TOUCH_MINOR
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_TOUCH_MINOR", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_TOUCH_MINOR = 5;
				/// <java-name>
				/// MOTION_RANGE_TOOL_MAJOR
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_TOOL_MAJOR", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_TOOL_MAJOR = 6;
				/// <java-name>
				/// MOTION_RANGE_TOOL_MINOR
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_TOOL_MINOR", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_TOOL_MINOR = 7;
				/// <java-name>
				/// MOTION_RANGE_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_ORIENTATION", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_ORIENTATION = 8;
				/// <java-name>
				/// KEYBOARD_TYPE_NONE
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_TYPE_NONE", "I", AccessFlags = 25)]
				public const int KEYBOARD_TYPE_NONE = 0;
				/// <java-name>
				/// KEYBOARD_TYPE_NON_ALPHABETIC
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_TYPE_NON_ALPHABETIC", "I", AccessFlags = 25)]
				public const int KEYBOARD_TYPE_NON_ALPHABETIC = 1;
				/// <java-name>
				/// KEYBOARD_TYPE_ALPHABETIC
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_TYPE_ALPHABETIC", "I", AccessFlags = 25)]
				public const int KEYBOARD_TYPE_ALPHABETIC = 2;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.InputDevice> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InputDevice() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDevice
				/// </java-name>
				[Dot42.DexImport("getDevice", "(I)Landroid/view/InputDevice;", AccessFlags = 9)]
				public static global::Android.Views.InputDevice GetDevice(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.InputDevice);
				}

				/// <java-name>
				/// getMotionRange
				/// </java-name>
				[Dot42.DexImport("getMotionRange", "(I)Landroid/view/InputDevice$MotionRange;", AccessFlags = 1)]
				public global::Android.Views.InputDevice.MotionRange GetMotionRange(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.InputDevice.MotionRange);
				}

				/// <java-name>
				/// getMotionRange
				/// </java-name>
				[Dot42.DexImport("getMotionRange", "(II)Landroid/view/InputDevice$MotionRange;", AccessFlags = 1)]
				public global::Android.Views.InputDevice.MotionRange GetMotionRange(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.InputDevice.MotionRange);
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

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getDeviceIds
				/// </java-name>
				public static int[] DeviceIds
				{
						[Dot42.DexImport("getDeviceIds", "()[I", AccessFlags = 9)]
						get{ return default(int[]); }
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
						[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSources
				/// </java-name>
				public int Sources
				{
						[Dot42.DexImport("getSources", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getKeyboardType
				/// </java-name>
				public int KeyboardType
				{
						[Dot42.DexImport("getKeyboardType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getKeyCharacterMap
				/// </java-name>
				public global::Android.Views.KeyCharacterMap KeyCharacterMap
				{
						[Dot42.DexImport("getKeyCharacterMap", "()Landroid/view/KeyCharacterMap;", AccessFlags = 1)]
						get{ return default(global::Android.Views.KeyCharacterMap); }
				}

				/// <java-name>
				/// getMotionRanges
				/// </java-name>
				public global::Java.Util.IList<global::Android.Views.InputDevice.MotionRange> MotionRanges
				{
						[Dot42.DexImport("getMotionRanges", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/view/InputDevice$MotionRange;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Views.InputDevice.MotionRange>); }
				}

				/// <java-name>
				/// android/view/InputDevice$MotionRange
				/// </java-name>
				[Dot42.DexImport("android/view/InputDevice$MotionRange", AccessFlags = 25)]
				public sealed partial class MotionRange
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal MotionRange() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getAxis
						/// </java-name>
						public int Axis
						{
								[Dot42.DexImport("getAxis", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getSource
						/// </java-name>
						public int Source
						{
								[Dot42.DexImport("getSource", "()I", AccessFlags = 1)]
								get{ return default(int); }
						}

						/// <java-name>
						/// getMin
						/// </java-name>
						public float Min
						{
								[Dot42.DexImport("getMin", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <java-name>
						/// getMax
						/// </java-name>
						public float Max
						{
								[Dot42.DexImport("getMax", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <java-name>
						/// getRange
						/// </java-name>
						public float Range
						{
								[Dot42.DexImport("getRange", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <java-name>
						/// getFlat
						/// </java-name>
						public float Flat
						{
								[Dot42.DexImport("getFlat", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <java-name>
						/// getFuzz
						/// </java-name>
						public float Fuzz
						{
								[Dot42.DexImport("getFuzz", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

				}

		}

		/// <java-name>
		/// android/view/InputEvent
		/// </java-name>
		[Dot42.DexImport("android/view/InputEvent", AccessFlags = 1057)]
		public abstract partial class InputEvent : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.InputEvent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InputEvent() /* MethodBuilder.Create */ 
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

				[Dot42.DexImport("android/os/Parcelable", "writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1025)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getDeviceId
				/// </java-name>
				public abstract int DeviceId
				{
						[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getDevice
				/// </java-name>
				public global::Android.Views.InputDevice Device
				{
						[Dot42.DexImport("getDevice", "()Landroid/view/InputDevice;", AccessFlags = 17)]
						get{ return default(global::Android.Views.InputDevice); }
				}

				/// <java-name>
				/// getSource
				/// </java-name>
				public abstract int Source
				{
						[Dot42.DexImport("getSource", "()I", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/view/InputQueue
		/// </java-name>
		[Dot42.DexImport("android/view/InputQueue", AccessFlags = 49)]
		public sealed partial class InputQueue
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal InputQueue() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/view/InputQueue$Callback
				/// </java-name>
				[Dot42.DexImport("android/view/InputQueue$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onInputQueueCreated
						/// </java-name>
						[Dot42.DexImport("onInputQueueCreated", "(Landroid/view/InputQueue;)V", AccessFlags = 1025)]
						void OnInputQueueCreated(global::Android.Views.InputQueue inputQueue) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onInputQueueDestroyed
						/// </java-name>
						[Dot42.DexImport("onInputQueueDestroyed", "(Landroid/view/InputQueue;)V", AccessFlags = 1025)]
						void OnInputQueueDestroyed(global::Android.Views.InputQueue inputQueue) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/SubMenu
		/// </java-name>
		[Dot42.DexImport("android/view/SubMenu", AccessFlags = 1537)]
		public partial interface ISubMenu : global::Android.Views.IMenu
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// setHeaderTitle
				/// </java-name>
				[Dot42.DexImport("setHeaderTitle", "(I)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderTitle(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaderTitle
				/// </java-name>
				[Dot42.DexImport("setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaderIcon
				/// </java-name>
				[Dot42.DexImport("setHeaderIcon", "(I)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderIcon(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaderIcon
				/// </java-name>
				[Dot42.DexImport("setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderIcon(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setHeaderView
				/// </java-name>
				[Dot42.DexImport("setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearHeader
				/// </java-name>
				[Dot42.DexImport("clearHeader", "()V", AccessFlags = 1025)]
				void ClearHeader() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetIcon(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetIcon(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getItem
				/// </java-name>
				global::Android.Views.IMenuItem Item
				{
						[Dot42.DexImport("getItem", "()Landroid/view/MenuItem;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/view/SurfaceHolder
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder", AccessFlags = 1537)]
		public partial interface ISurfaceHolder
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addCallback
				/// </java-name>
				[Dot42.DexImport("addCallback", "(Landroid/view/SurfaceHolder$Callback;)V", AccessFlags = 1025)]
				void AddCallback(global::Android.Views.ISurfaceHolder_ICallback surfaceHolder_ICallback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeCallback
				/// </java-name>
				[Dot42.DexImport("removeCallback", "(Landroid/view/SurfaceHolder$Callback;)V", AccessFlags = 1025)]
				void RemoveCallback(global::Android.Views.ISurfaceHolder_ICallback surfaceHolder_ICallback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(I)V", AccessFlags = 1025)]
				void SetType(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFixedSize
				/// </java-name>
				[Dot42.DexImport("setFixedSize", "(II)V", AccessFlags = 1025)]
				void SetFixedSize(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setSizeFromLayout
				/// </java-name>
				[Dot42.DexImport("setSizeFromLayout", "()V", AccessFlags = 1025)]
				void SetSizeFromLayout() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFormat
				/// </java-name>
				[Dot42.DexImport("setFormat", "(I)V", AccessFlags = 1025)]
				void SetFormat(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setKeepScreenOn
				/// </java-name>
				[Dot42.DexImport("setKeepScreenOn", "(Z)V", AccessFlags = 1025)]
				void SetKeepScreenOn(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lockCanvas
				/// </java-name>
				[Dot42.DexImport("lockCanvas", "()Landroid/graphics/Canvas;", AccessFlags = 1025)]
				global::Android.Graphics.Canvas LockCanvas() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// lockCanvas
				/// </java-name>
				[Dot42.DexImport("lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", AccessFlags = 1025)]
				global::Android.Graphics.Canvas LockCanvas(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// unlockCanvasAndPost
				/// </java-name>
				[Dot42.DexImport("unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", AccessFlags = 1025)]
				void UnlockCanvasAndPost(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isCreating
				/// </java-name>
				bool IsCreating
				{
						[Dot42.DexImport("isCreating", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSurfaceFrame
				/// </java-name>
				global::Android.Graphics.Rect SurfaceFrame
				{
						[Dot42.DexImport("getSurfaceFrame", "()Landroid/graphics/Rect;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSurface
				/// </java-name>
				global::Android.Views.Surface Surface
				{
						[Dot42.DexImport("getSurface", "()Landroid/view/Surface;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/view/SurfaceHolder$BadSurfaceTypeException
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder$BadSurfaceTypeException", AccessFlags = 9)]
		public partial class ISurfaceHolder_BadSurfaceTypeException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ISurfaceHolder_BadSurfaceTypeException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public ISurfaceHolder_BadSurfaceTypeException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/view/SurfaceHolder$Callback
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder$Callback", AccessFlags = 1545)]
		public partial interface ISurfaceHolder_ICallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// surfaceCreated
				/// </java-name>
				[Dot42.DexImport("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1025)]
				void SurfaceCreated(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// surfaceChanged
				/// </java-name>
				[Dot42.DexImport("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", AccessFlags = 1025)]
				void SurfaceChanged(global::Android.Views.ISurfaceHolder surfaceHolder, int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// surfaceDestroyed
				/// </java-name>
				[Dot42.DexImport("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1025)]
				void SurfaceDestroyed(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/SurfaceHolder$Callback2
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder$Callback2", AccessFlags = 1545)]
		public partial interface ISurfaceHolder_ICallback2 : global::Android.Views.ISurfaceHolder_ICallback
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// surfaceRedrawNeeded
				/// </java-name>
				[Dot42.DexImport("surfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1025)]
				void SurfaceRedrawNeeded(global::Android.Views.ISurfaceHolder surfaceHolder) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/SurfaceHolder
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISurfaceHolderConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// SURFACE_TYPE_NORMAL
				/// </java-name>
				[Dot42.DexImport("SURFACE_TYPE_NORMAL", "I", AccessFlags = 25)]
				public const int SURFACE_TYPE_NORMAL = 0;
				/// <java-name>
				/// SURFACE_TYPE_HARDWARE
				/// </java-name>
				[Dot42.DexImport("SURFACE_TYPE_HARDWARE", "I", AccessFlags = 25)]
				public const int SURFACE_TYPE_HARDWARE = 1;
				/// <java-name>
				/// SURFACE_TYPE_GPU
				/// </java-name>
				[Dot42.DexImport("SURFACE_TYPE_GPU", "I", AccessFlags = 25)]
				public const int SURFACE_TYPE_GPU = 2;
				/// <java-name>
				/// SURFACE_TYPE_PUSH_BUFFERS
				/// </java-name>
				[Dot42.DexImport("SURFACE_TYPE_PUSH_BUFFERS", "I", AccessFlags = 25)]
				public const int SURFACE_TYPE_PUSH_BUFFERS = 3;
		}

		/// <java-name>
		/// android/view/ViewManager
		/// </java-name>
		[Dot42.DexImport("android/view/ViewManager", AccessFlags = 1537)]
		public partial interface IViewManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1025)]
				void AddView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateViewLayout
				/// </java-name>
				[Dot42.DexImport("updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1025)]
				void UpdateViewLayout(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeView
				/// </java-name>
				[Dot42.DexImport("removeView", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void RemoveView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// android/view/ViewParent
		/// </java-name>
		[Dot42.DexImport("android/view/ViewParent", AccessFlags = 1537)]
		public partial interface IViewParent
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1025)]
				void RequestLayout() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// requestTransparentRegion
				/// </java-name>
				[Dot42.DexImport("requestTransparentRegion", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void RequestTransparentRegion(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invalidateChild
				/// </java-name>
				[Dot42.DexImport("invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V", AccessFlags = 1025)]
				void InvalidateChild(global::Android.Views.View view, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invalidateChildInParent
				/// </java-name>
				[Dot42.DexImport("invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;", AccessFlags = 1025)]
				global::Android.Views.IViewParent InvalidateChildInParent(int[] int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// requestChildFocus
				/// </java-name>
				[Dot42.DexImport("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1025)]
				void RequestChildFocus(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// recomputeViewAttributes
				/// </java-name>
				[Dot42.DexImport("recomputeViewAttributes", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void RecomputeViewAttributes(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clearChildFocus
				/// </java-name>
				[Dot42.DexImport("clearChildFocus", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void ClearChildFocus(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getChildVisibleRect
				/// </java-name>
				[Dot42.DexImport("getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z", AccessFlags = 1025)]
				bool GetChildVisibleRect(global::Android.Views.View view, global::Android.Graphics.Rect rect, global::Android.Graphics.Point point) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// focusSearch
				/// </java-name>
				[Dot42.DexImport("focusSearch", "(Landroid/view/View;I)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View FocusSearch(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// bringChildToFront
				/// </java-name>
				[Dot42.DexImport("bringChildToFront", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void BringChildToFront(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// focusableViewAvailable
				/// </java-name>
				[Dot42.DexImport("focusableViewAvailable", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void FocusableViewAvailable(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// showContextMenuForChild
				/// </java-name>
				[Dot42.DexImport("showContextMenuForChild", "(Landroid/view/View;)Z", AccessFlags = 1025)]
				bool ShowContextMenuForChild(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// createContextMenu
				/// </java-name>
				[Dot42.DexImport("createContextMenu", "(Landroid/view/ContextMenu;)V", AccessFlags = 1025)]
				void CreateContextMenu(global::Android.Views.IContextMenu contextMenu) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// startActionModeForChild
				/// </java-name>
				[Dot42.DexImport("startActionModeForChild", "(Landroid/view/View;Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1025)]
				global::Android.Views.ActionMode StartActionModeForChild(global::Android.Views.View view, global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// childDrawableStateChanged
				/// </java-name>
				[Dot42.DexImport("childDrawableStateChanged", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void ChildDrawableStateChanged(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// requestDisallowInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("requestDisallowInterceptTouchEvent", "(Z)V", AccessFlags = 1025)]
				void RequestDisallowInterceptTouchEvent(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1025)]
				bool RequestChildRectangleOnScreen(global::Android.Views.View view, global::Android.Graphics.Rect rect, bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// requestSendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("requestSendAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1025)]
				bool RequestSendAccessibilityEvent(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isLayoutRequested
				/// </java-name>
				bool IsLayoutRequested
				{
						[Dot42.DexImport("isLayoutRequested", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				global::Android.Views.IViewParent Parent
				{
						[Dot42.DexImport("getParent", "()Landroid/view/ViewParent;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/view/WindowManager
		/// </java-name>
		[Dot42.DexImport("android/view/WindowManager", AccessFlags = 1537)]
		public partial interface IWindowManager : global::Android.Views.IViewManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// removeViewImmediate
				/// </java-name>
				[Dot42.DexImport("removeViewImmediate", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void RemoveViewImmediate(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getDefaultDisplay
				/// </java-name>
				global::Android.Views.Display DefaultDisplay
				{
						[Dot42.DexImport("getDefaultDisplay", "()Landroid/view/Display;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// android/view/WindowManager$BadTokenException
		/// </java-name>
		[Dot42.DexImport("android/view/WindowManager$BadTokenException", AccessFlags = 9)]
		public partial class IWindowManager_BadTokenException : global::System.SystemException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IWindowManager_BadTokenException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public IWindowManager_BadTokenException(string @string) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/view/WindowManager$LayoutParams
		/// </java-name>
		[Dot42.DexImport("android/view/WindowManager$LayoutParams", AccessFlags = 9)]
		public partial class IWindowManager_LayoutParams : global::Android.Views.ViewGroup.LayoutParams, global::Android.OS.IParcelable
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
				/// <java-name>
				/// horizontalWeight
				/// </java-name>
				[Dot42.DexImport("horizontalWeight", "F", AccessFlags = 1)]
				public float HorizontalWeight;
				/// <java-name>
				/// verticalWeight
				/// </java-name>
				[Dot42.DexImport("verticalWeight", "F", AccessFlags = 1)]
				public float VerticalWeight;
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "I", AccessFlags = 1)]
				public int Type;
				/// <java-name>
				/// FIRST_APPLICATION_WINDOW
				/// </java-name>
				[Dot42.DexImport("FIRST_APPLICATION_WINDOW", "I", AccessFlags = 25)]
				public const int FIRST_APPLICATION_WINDOW = 1;
				/// <java-name>
				/// TYPE_BASE_APPLICATION
				/// </java-name>
				[Dot42.DexImport("TYPE_BASE_APPLICATION", "I", AccessFlags = 25)]
				public const int TYPE_BASE_APPLICATION = 1;
				/// <java-name>
				/// TYPE_APPLICATION
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION = 2;
				/// <java-name>
				/// TYPE_APPLICATION_STARTING
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_STARTING", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_STARTING = 3;
				/// <java-name>
				/// LAST_APPLICATION_WINDOW
				/// </java-name>
				[Dot42.DexImport("LAST_APPLICATION_WINDOW", "I", AccessFlags = 25)]
				public const int LAST_APPLICATION_WINDOW = 99;
				/// <java-name>
				/// FIRST_SUB_WINDOW
				/// </java-name>
				[Dot42.DexImport("FIRST_SUB_WINDOW", "I", AccessFlags = 25)]
				public const int FIRST_SUB_WINDOW = 1000;
				/// <java-name>
				/// TYPE_APPLICATION_PANEL
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_PANEL", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_PANEL = 1000;
				/// <java-name>
				/// TYPE_APPLICATION_MEDIA
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_MEDIA", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_MEDIA = 1001;
				/// <java-name>
				/// TYPE_APPLICATION_SUB_PANEL
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_SUB_PANEL", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_SUB_PANEL = 1002;
				/// <java-name>
				/// TYPE_APPLICATION_ATTACHED_DIALOG
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_ATTACHED_DIALOG", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_ATTACHED_DIALOG = 1003;
				/// <java-name>
				/// LAST_SUB_WINDOW
				/// </java-name>
				[Dot42.DexImport("LAST_SUB_WINDOW", "I", AccessFlags = 25)]
				public const int LAST_SUB_WINDOW = 1999;
				/// <java-name>
				/// FIRST_SYSTEM_WINDOW
				/// </java-name>
				[Dot42.DexImport("FIRST_SYSTEM_WINDOW", "I", AccessFlags = 25)]
				public const int FIRST_SYSTEM_WINDOW = 2000;
				/// <java-name>
				/// TYPE_STATUS_BAR
				/// </java-name>
				[Dot42.DexImport("TYPE_STATUS_BAR", "I", AccessFlags = 25)]
				public const int TYPE_STATUS_BAR = 2000;
				/// <java-name>
				/// TYPE_SEARCH_BAR
				/// </java-name>
				[Dot42.DexImport("TYPE_SEARCH_BAR", "I", AccessFlags = 25)]
				public const int TYPE_SEARCH_BAR = 2001;
				/// <java-name>
				/// TYPE_PHONE
				/// </java-name>
				[Dot42.DexImport("TYPE_PHONE", "I", AccessFlags = 25)]
				public const int TYPE_PHONE = 2002;
				/// <java-name>
				/// TYPE_SYSTEM_ALERT
				/// </java-name>
				[Dot42.DexImport("TYPE_SYSTEM_ALERT", "I", AccessFlags = 25)]
				public const int TYPE_SYSTEM_ALERT = 2003;
				/// <java-name>
				/// TYPE_KEYGUARD
				/// </java-name>
				[Dot42.DexImport("TYPE_KEYGUARD", "I", AccessFlags = 25)]
				public const int TYPE_KEYGUARD = 2004;
				/// <java-name>
				/// TYPE_TOAST
				/// </java-name>
				[Dot42.DexImport("TYPE_TOAST", "I", AccessFlags = 25)]
				public const int TYPE_TOAST = 2005;
				/// <java-name>
				/// TYPE_SYSTEM_OVERLAY
				/// </java-name>
				[Dot42.DexImport("TYPE_SYSTEM_OVERLAY", "I", AccessFlags = 25)]
				public const int TYPE_SYSTEM_OVERLAY = 2006;
				/// <java-name>
				/// TYPE_PRIORITY_PHONE
				/// </java-name>
				[Dot42.DexImport("TYPE_PRIORITY_PHONE", "I", AccessFlags = 25)]
				public const int TYPE_PRIORITY_PHONE = 2007;
				/// <java-name>
				/// TYPE_SYSTEM_DIALOG
				/// </java-name>
				[Dot42.DexImport("TYPE_SYSTEM_DIALOG", "I", AccessFlags = 25)]
				public const int TYPE_SYSTEM_DIALOG = 2008;
				/// <java-name>
				/// TYPE_KEYGUARD_DIALOG
				/// </java-name>
				[Dot42.DexImport("TYPE_KEYGUARD_DIALOG", "I", AccessFlags = 25)]
				public const int TYPE_KEYGUARD_DIALOG = 2009;
				/// <java-name>
				/// TYPE_SYSTEM_ERROR
				/// </java-name>
				[Dot42.DexImport("TYPE_SYSTEM_ERROR", "I", AccessFlags = 25)]
				public const int TYPE_SYSTEM_ERROR = 2010;
				/// <java-name>
				/// TYPE_INPUT_METHOD
				/// </java-name>
				[Dot42.DexImport("TYPE_INPUT_METHOD", "I", AccessFlags = 25)]
				public const int TYPE_INPUT_METHOD = 2011;
				/// <java-name>
				/// TYPE_INPUT_METHOD_DIALOG
				/// </java-name>
				[Dot42.DexImport("TYPE_INPUT_METHOD_DIALOG", "I", AccessFlags = 25)]
				public const int TYPE_INPUT_METHOD_DIALOG = 2012;
				/// <java-name>
				/// TYPE_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("TYPE_WALLPAPER", "I", AccessFlags = 25)]
				public const int TYPE_WALLPAPER = 2013;
				/// <java-name>
				/// TYPE_STATUS_BAR_PANEL
				/// </java-name>
				[Dot42.DexImport("TYPE_STATUS_BAR_PANEL", "I", AccessFlags = 25)]
				public const int TYPE_STATUS_BAR_PANEL = 2014;
				/// <java-name>
				/// LAST_SYSTEM_WINDOW
				/// </java-name>
				[Dot42.DexImport("LAST_SYSTEM_WINDOW", "I", AccessFlags = 25)]
				public const int LAST_SYSTEM_WINDOW = 2999;
				/// <java-name>
				/// MEMORY_TYPE_NORMAL
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_NORMAL", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_NORMAL = 0;
				/// <java-name>
				/// MEMORY_TYPE_HARDWARE
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_HARDWARE", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_HARDWARE = 1;
				/// <java-name>
				/// MEMORY_TYPE_GPU
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_GPU", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_GPU = 2;
				/// <java-name>
				/// MEMORY_TYPE_PUSH_BUFFERS
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_PUSH_BUFFERS", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_PUSH_BUFFERS = 3;
				/// <java-name>
				/// memoryType
				/// </java-name>
				[Dot42.DexImport("memoryType", "I", AccessFlags = 1)]
				public int MemoryType;
				/// <java-name>
				/// FLAG_ALLOW_LOCK_WHILE_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_LOCK_WHILE_SCREEN_ON", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_LOCK_WHILE_SCREEN_ON = 1;
				/// <java-name>
				/// FLAG_DIM_BEHIND
				/// </java-name>
				[Dot42.DexImport("FLAG_DIM_BEHIND", "I", AccessFlags = 25)]
				public const int FLAG_DIM_BEHIND = 2;
				/// <java-name>
				/// FLAG_BLUR_BEHIND
				/// </java-name>
				[Dot42.DexImport("FLAG_BLUR_BEHIND", "I", AccessFlags = 25)]
				public const int FLAG_BLUR_BEHIND = 4;
				/// <java-name>
				/// FLAG_NOT_FOCUSABLE
				/// </java-name>
				[Dot42.DexImport("FLAG_NOT_FOCUSABLE", "I", AccessFlags = 25)]
				public const int FLAG_NOT_FOCUSABLE = 8;
				/// <java-name>
				/// FLAG_NOT_TOUCHABLE
				/// </java-name>
				[Dot42.DexImport("FLAG_NOT_TOUCHABLE", "I", AccessFlags = 25)]
				public const int FLAG_NOT_TOUCHABLE = 16;
				/// <java-name>
				/// FLAG_NOT_TOUCH_MODAL
				/// </java-name>
				[Dot42.DexImport("FLAG_NOT_TOUCH_MODAL", "I", AccessFlags = 25)]
				public const int FLAG_NOT_TOUCH_MODAL = 32;
				/// <java-name>
				/// FLAG_TOUCHABLE_WHEN_WAKING
				/// </java-name>
				[Dot42.DexImport("FLAG_TOUCHABLE_WHEN_WAKING", "I", AccessFlags = 25)]
				public const int FLAG_TOUCHABLE_WHEN_WAKING = 64;
				/// <java-name>
				/// FLAG_KEEP_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("FLAG_KEEP_SCREEN_ON", "I", AccessFlags = 25)]
				public const int FLAG_KEEP_SCREEN_ON = 128;
				/// <java-name>
				/// FLAG_LAYOUT_IN_SCREEN
				/// </java-name>
				[Dot42.DexImport("FLAG_LAYOUT_IN_SCREEN", "I", AccessFlags = 25)]
				public const int FLAG_LAYOUT_IN_SCREEN = 256;
				/// <java-name>
				/// FLAG_LAYOUT_NO_LIMITS
				/// </java-name>
				[Dot42.DexImport("FLAG_LAYOUT_NO_LIMITS", "I", AccessFlags = 25)]
				public const int FLAG_LAYOUT_NO_LIMITS = 512;
				/// <java-name>
				/// FLAG_FULLSCREEN
				/// </java-name>
				[Dot42.DexImport("FLAG_FULLSCREEN", "I", AccessFlags = 25)]
				public const int FLAG_FULLSCREEN = 1024;
				/// <java-name>
				/// FLAG_FORCE_NOT_FULLSCREEN
				/// </java-name>
				[Dot42.DexImport("FLAG_FORCE_NOT_FULLSCREEN", "I", AccessFlags = 25)]
				public const int FLAG_FORCE_NOT_FULLSCREEN = 2048;
				/// <java-name>
				/// FLAG_DITHER
				/// </java-name>
				[Dot42.DexImport("FLAG_DITHER", "I", AccessFlags = 25)]
				public const int FLAG_DITHER = 4096;
				/// <java-name>
				/// FLAG_SECURE
				/// </java-name>
				[Dot42.DexImport("FLAG_SECURE", "I", AccessFlags = 25)]
				public const int FLAG_SECURE = 8192;
				/// <java-name>
				/// FLAG_SCALED
				/// </java-name>
				[Dot42.DexImport("FLAG_SCALED", "I", AccessFlags = 25)]
				public const int FLAG_SCALED = 16384;
				/// <java-name>
				/// FLAG_IGNORE_CHEEK_PRESSES
				/// </java-name>
				[Dot42.DexImport("FLAG_IGNORE_CHEEK_PRESSES", "I", AccessFlags = 25)]
				public const int FLAG_IGNORE_CHEEK_PRESSES = 32768;
				/// <java-name>
				/// FLAG_LAYOUT_INSET_DECOR
				/// </java-name>
				[Dot42.DexImport("FLAG_LAYOUT_INSET_DECOR", "I", AccessFlags = 25)]
				public const int FLAG_LAYOUT_INSET_DECOR = 65536;
				/// <java-name>
				/// FLAG_ALT_FOCUSABLE_IM
				/// </java-name>
				[Dot42.DexImport("FLAG_ALT_FOCUSABLE_IM", "I", AccessFlags = 25)]
				public const int FLAG_ALT_FOCUSABLE_IM = 131072;
				/// <java-name>
				/// FLAG_WATCH_OUTSIDE_TOUCH
				/// </java-name>
				[Dot42.DexImport("FLAG_WATCH_OUTSIDE_TOUCH", "I", AccessFlags = 25)]
				public const int FLAG_WATCH_OUTSIDE_TOUCH = 262144;
				/// <java-name>
				/// FLAG_SHOW_WHEN_LOCKED
				/// </java-name>
				[Dot42.DexImport("FLAG_SHOW_WHEN_LOCKED", "I", AccessFlags = 25)]
				public const int FLAG_SHOW_WHEN_LOCKED = 524288;
				/// <java-name>
				/// FLAG_SHOW_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("FLAG_SHOW_WALLPAPER", "I", AccessFlags = 25)]
				public const int FLAG_SHOW_WALLPAPER = 1048576;
				/// <java-name>
				/// FLAG_TURN_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("FLAG_TURN_SCREEN_ON", "I", AccessFlags = 25)]
				public const int FLAG_TURN_SCREEN_ON = 2097152;
				/// <java-name>
				/// FLAG_DISMISS_KEYGUARD
				/// </java-name>
				[Dot42.DexImport("FLAG_DISMISS_KEYGUARD", "I", AccessFlags = 25)]
				public const int FLAG_DISMISS_KEYGUARD = 4194304;
				/// <java-name>
				/// FLAG_SPLIT_TOUCH
				/// </java-name>
				[Dot42.DexImport("FLAG_SPLIT_TOUCH", "I", AccessFlags = 25)]
				public const int FLAG_SPLIT_TOUCH = 8388608;
				/// <java-name>
				/// FLAG_HARDWARE_ACCELERATED
				/// </java-name>
				[Dot42.DexImport("FLAG_HARDWARE_ACCELERATED", "I", AccessFlags = 25)]
				public const int FLAG_HARDWARE_ACCELERATED = 16777216;
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <java-name>
				/// SOFT_INPUT_MASK_STATE
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_MASK_STATE", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_MASK_STATE = 15;
				/// <java-name>
				/// SOFT_INPUT_STATE_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_UNSPECIFIED = 0;
				/// <java-name>
				/// SOFT_INPUT_STATE_UNCHANGED
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_UNCHANGED", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_UNCHANGED = 1;
				/// <java-name>
				/// SOFT_INPUT_STATE_HIDDEN
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_HIDDEN", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_HIDDEN = 2;
				/// <java-name>
				/// SOFT_INPUT_STATE_ALWAYS_HIDDEN
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_ALWAYS_HIDDEN", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_ALWAYS_HIDDEN = 3;
				/// <java-name>
				/// SOFT_INPUT_STATE_VISIBLE
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_VISIBLE", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_VISIBLE = 4;
				/// <java-name>
				/// SOFT_INPUT_STATE_ALWAYS_VISIBLE
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_ALWAYS_VISIBLE", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_ALWAYS_VISIBLE = 5;
				/// <java-name>
				/// SOFT_INPUT_MASK_ADJUST
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_MASK_ADJUST", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_MASK_ADJUST = 240;
				/// <java-name>
				/// SOFT_INPUT_ADJUST_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_ADJUST_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_ADJUST_UNSPECIFIED = 0;
				/// <java-name>
				/// SOFT_INPUT_ADJUST_RESIZE
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_ADJUST_RESIZE", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_ADJUST_RESIZE = 16;
				/// <java-name>
				/// SOFT_INPUT_ADJUST_PAN
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_ADJUST_PAN", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_ADJUST_PAN = 32;
				/// <java-name>
				/// SOFT_INPUT_ADJUST_NOTHING
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_ADJUST_NOTHING", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_ADJUST_NOTHING = 48;
				/// <java-name>
				/// SOFT_INPUT_IS_FORWARD_NAVIGATION
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_IS_FORWARD_NAVIGATION", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_IS_FORWARD_NAVIGATION = 256;
				/// <java-name>
				/// softInputMode
				/// </java-name>
				[Dot42.DexImport("softInputMode", "I", AccessFlags = 1)]
				public int SoftInputMode;
				/// <java-name>
				/// gravity
				/// </java-name>
				[Dot42.DexImport("gravity", "I", AccessFlags = 1)]
				public int Gravity;
				/// <java-name>
				/// horizontalMargin
				/// </java-name>
				[Dot42.DexImport("horizontalMargin", "F", AccessFlags = 1)]
				public float HorizontalMargin;
				/// <java-name>
				/// verticalMargin
				/// </java-name>
				[Dot42.DexImport("verticalMargin", "F", AccessFlags = 1)]
				public float VerticalMargin;
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "I", AccessFlags = 1)]
				public int Format;
				/// <java-name>
				/// windowAnimations
				/// </java-name>
				[Dot42.DexImport("windowAnimations", "I", AccessFlags = 1)]
				public int WindowAnimations;
				/// <java-name>
				/// alpha
				/// </java-name>
				[Dot42.DexImport("alpha", "F", AccessFlags = 1)]
				public float Alpha;
				/// <java-name>
				/// dimAmount
				/// </java-name>
				[Dot42.DexImport("dimAmount", "F", AccessFlags = 1)]
				public float DimAmount;
				/// <java-name>
				/// BRIGHTNESS_OVERRIDE_NONE
				/// </java-name>
				[Dot42.DexImport("BRIGHTNESS_OVERRIDE_NONE", "F", AccessFlags = 25)]
				public const float BRIGHTNESS_OVERRIDE_NONE = -1F;
				/// <java-name>
				/// BRIGHTNESS_OVERRIDE_OFF
				/// </java-name>
				[Dot42.DexImport("BRIGHTNESS_OVERRIDE_OFF", "F", AccessFlags = 25)]
				public const float BRIGHTNESS_OVERRIDE_OFF = 0F;
				/// <java-name>
				/// BRIGHTNESS_OVERRIDE_FULL
				/// </java-name>
				[Dot42.DexImport("BRIGHTNESS_OVERRIDE_FULL", "F", AccessFlags = 25)]
				public const float BRIGHTNESS_OVERRIDE_FULL = 1F;
				/// <java-name>
				/// screenBrightness
				/// </java-name>
				[Dot42.DexImport("screenBrightness", "F", AccessFlags = 1)]
				public float ScreenBrightness;
				/// <java-name>
				/// buttonBrightness
				/// </java-name>
				[Dot42.DexImport("buttonBrightness", "F", AccessFlags = 1)]
				public float ButtonBrightness;
				/// <java-name>
				/// token
				/// </java-name>
				[Dot42.DexImport("token", "Landroid/os/IBinder;", AccessFlags = 1)]
				public global::Android.OS.IBinder Token;
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <java-name>
				/// screenOrientation
				/// </java-name>
				[Dot42.DexImport("screenOrientation", "I", AccessFlags = 1)]
				public int ScreenOrientation;
				/// <java-name>
				/// systemUiVisibility
				/// </java-name>
				[Dot42.DexImport("systemUiVisibility", "I", AccessFlags = 1)]
				public int SystemUiVisibility;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.IWindowManager_LayoutParams> CREATOR;
				/// <java-name>
				/// LAYOUT_CHANGED
				/// </java-name>
				[Dot42.DexImport("LAYOUT_CHANGED", "I", AccessFlags = 25)]
				public const int LAYOUT_CHANGED = 1;
				/// <java-name>
				/// TYPE_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_CHANGED = 2;
				/// <java-name>
				/// FLAGS_CHANGED
				/// </java-name>
				[Dot42.DexImport("FLAGS_CHANGED", "I", AccessFlags = 25)]
				public const int FLAGS_CHANGED = 4;
				/// <java-name>
				/// FORMAT_CHANGED
				/// </java-name>
				[Dot42.DexImport("FORMAT_CHANGED", "I", AccessFlags = 25)]
				public const int FORMAT_CHANGED = 8;
				/// <java-name>
				/// ANIMATION_CHANGED
				/// </java-name>
				[Dot42.DexImport("ANIMATION_CHANGED", "I", AccessFlags = 25)]
				public const int ANIMATION_CHANGED = 16;
				/// <java-name>
				/// DIM_AMOUNT_CHANGED
				/// </java-name>
				[Dot42.DexImport("DIM_AMOUNT_CHANGED", "I", AccessFlags = 25)]
				public const int DIM_AMOUNT_CHANGED = 32;
				/// <java-name>
				/// TITLE_CHANGED
				/// </java-name>
				[Dot42.DexImport("TITLE_CHANGED", "I", AccessFlags = 25)]
				public const int TITLE_CHANGED = 64;
				/// <java-name>
				/// ALPHA_CHANGED
				/// </java-name>
				[Dot42.DexImport("ALPHA_CHANGED", "I", AccessFlags = 25)]
				public const int ALPHA_CHANGED = 128;
				/// <java-name>
				/// MEMORY_TYPE_CHANGED
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_CHANGED", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_CHANGED = 256;
				/// <java-name>
				/// SOFT_INPUT_MODE_CHANGED
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_MODE_CHANGED", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_MODE_CHANGED = 512;
				/// <java-name>
				/// SCREEN_ORIENTATION_CHANGED
				/// </java-name>
				[Dot42.DexImport("SCREEN_ORIENTATION_CHANGED", "I", AccessFlags = 25)]
				public const int SCREEN_ORIENTATION_CHANGED = 1024;
				/// <java-name>
				/// SCREEN_BRIGHTNESS_CHANGED
				/// </java-name>
				[Dot42.DexImport("SCREEN_BRIGHTNESS_CHANGED", "I", AccessFlags = 25)]
				public const int SCREEN_BRIGHTNESS_CHANGED = 2048;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public IWindowManager_LayoutParams() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(I)V", AccessFlags = 1)]
				public IWindowManager_LayoutParams(int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public IWindowManager_LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(III)V", AccessFlags = 1)]
				public IWindowManager_LayoutParams(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIIII)V", AccessFlags = 1)]
				public IWindowManager_LayoutParams(int int32, int int321, int int322, int int323, int int324) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(IIIIIII)V", AccessFlags = 1)]
				public IWindowManager_LayoutParams(int int32, int int321, int int322, int int323, int int324, int int325, int int326) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public IWindowManager_LayoutParams(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// mayUseInputMethod
				/// </java-name>
				[Dot42.DexImport("mayUseInputMethod", "(I)Z", AccessFlags = 9)]
				public static bool MayUseInputMethod(int int32) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/view/WindowManager$LayoutParams;)I", AccessFlags = 17)]
				public int CopyFrom(global::Android.Views.IWindowManager_LayoutParams iWindowManager_LayoutParams) /* MethodBuilder.Create */ 
				{
						return default(int);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getTitle
				/// </java-name>
				public global::Java.Lang.ICharSequence Title
				{
						[Dot42.DexImport("getTitle", "()Ljava/lang/CharSequence;", AccessFlags = 17)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 17)]
						set{ }
				}

		}

		/// <java-name>
		/// android/view/KeyCharacterMap
		/// </java-name>
		[Dot42.DexImport("android/view/KeyCharacterMap", AccessFlags = 33)]
		public partial class KeyCharacterMap
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// BUILT_IN_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("BUILT_IN_KEYBOARD", "I", AccessFlags = 25)]
				public const int BUILT_IN_KEYBOARD = 0;
				/// <java-name>
				/// VIRTUAL_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("VIRTUAL_KEYBOARD", "I", AccessFlags = 25)]
				public const int VIRTUAL_KEYBOARD = -1;
				/// <java-name>
				/// NUMERIC
				/// </java-name>
				[Dot42.DexImport("NUMERIC", "I", AccessFlags = 25)]
				public const int NUMERIC = 1;
				/// <java-name>
				/// PREDICTIVE
				/// </java-name>
				[Dot42.DexImport("PREDICTIVE", "I", AccessFlags = 25)]
				public const int PREDICTIVE = 2;
				/// <java-name>
				/// ALPHA
				/// </java-name>
				[Dot42.DexImport("ALPHA", "I", AccessFlags = 25)]
				public const int ALPHA = 3;
				/// <java-name>
				/// FULL
				/// </java-name>
				[Dot42.DexImport("FULL", "I", AccessFlags = 25)]
				public const int FULL = 4;
				/// <java-name>
				/// SPECIAL_FUNCTION
				/// </java-name>
				[Dot42.DexImport("SPECIAL_FUNCTION", "I", AccessFlags = 25)]
				public const int SPECIAL_FUNCTION = 5;
				/// <java-name>
				/// HEX_INPUT
				/// </java-name>
				[Dot42.DexImport("HEX_INPUT", "C", AccessFlags = 25)]
				public const char HEX_INPUT = '';
				/// <java-name>
				/// PICKER_DIALOG_INPUT
				/// </java-name>
				[Dot42.DexImport("PICKER_DIALOG_INPUT", "C", AccessFlags = 25)]
				public const char PICKER_DIALOG_INPUT = '';
				/// <java-name>
				/// MODIFIER_BEHAVIOR_CHORDED
				/// </java-name>
				[Dot42.DexImport("MODIFIER_BEHAVIOR_CHORDED", "I", AccessFlags = 25)]
				public const int MODIFIER_BEHAVIOR_CHORDED = 0;
				/// <java-name>
				/// MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLED
				/// </java-name>
				[Dot42.DexImport("MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLED", "I", AccessFlags = 25)]
				public const int MODIFIER_BEHAVIOR_CHORDED_OR_TOGGLED = 1;
				/// <java-name>
				/// COMBINING_ACCENT
				/// </java-name>
				[Dot42.DexImport("COMBINING_ACCENT", "I", AccessFlags = 25)]
				public const int COMBINING_ACCENT = -2147483648;
				/// <java-name>
				/// COMBINING_ACCENT_MASK
				/// </java-name>
				[Dot42.DexImport("COMBINING_ACCENT_MASK", "I", AccessFlags = 25)]
				public const int COMBINING_ACCENT_MASK = 2147483647;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal KeyCharacterMap() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~KeyCharacterMap() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(I)Landroid/view/KeyCharacterMap;", AccessFlags = 9)]
				public static global::Android.Views.KeyCharacterMap Load(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyCharacterMap);
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)I", AccessFlags = 1)]
				public virtual int Get(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getNumber
				/// </java-name>
				[Dot42.DexImport("getNumber", "(I)C", AccessFlags = 1)]
				public virtual char GetNumber(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getMatch
				/// </java-name>
				[Dot42.DexImport("getMatch", "(I[C)C", AccessFlags = 1)]
				public virtual char GetMatch(int int32, char[] @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getMatch
				/// </java-name>
				[Dot42.DexImport("getMatch", "(I[CI)C", AccessFlags = 1)]
				public virtual char GetMatch(int int32, char[] @char, int int321) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getDisplayLabel
				/// </java-name>
				[Dot42.DexImport("getDisplayLabel", "(I)C", AccessFlags = 1)]
				public virtual char GetDisplayLabel(int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getDeadChar
				/// </java-name>
				[Dot42.DexImport("getDeadChar", "(II)I", AccessFlags = 9)]
				public static int GetDeadChar(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getKeyData
				/// </java-name>
				[Dot42.DexImport("getKeyData", "(ILandroid/view/KeyCharacterMap$KeyData;)Z", AccessFlags = 1)]
				public virtual bool GetKeyData(int int32, global::Android.Views.KeyCharacterMap.KeyData keyData) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getEvents
				/// </java-name>
				[Dot42.DexImport("getEvents", "([C)[Landroid/view/KeyEvent;", AccessFlags = 1)]
				public virtual global::Android.Views.KeyEvent[] GetEvents(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent[]);
				}

				/// <java-name>
				/// isPrintingKey
				/// </java-name>
				[Dot42.DexImport("isPrintingKey", "(I)Z", AccessFlags = 1)]
				public virtual bool IsPrintingKey(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// deviceHasKey
				/// </java-name>
				[Dot42.DexImport("deviceHasKey", "(I)Z", AccessFlags = 9)]
				public static bool DeviceHasKey(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// deviceHasKeys
				/// </java-name>
				[Dot42.DexImport("deviceHasKeys", "([I)[Z", AccessFlags = 9)]
				public static bool[] DeviceHasKeys(int[] int32) /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <java-name>
				/// getKeyboardType
				/// </java-name>
				public virtual int KeyboardType
				{
						[Dot42.DexImport("getKeyboardType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getModifierBehavior
				/// </java-name>
				public virtual int ModifierBehavior
				{
						[Dot42.DexImport("getModifierBehavior", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// android/view/KeyCharacterMap$UnavailableException
				/// </java-name>
				[Dot42.DexImport("android/view/KeyCharacterMap$UnavailableException", AccessFlags = 9)]
				public partial class UnavailableException : global::Android.Util.AndroidRuntimeException
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public UnavailableException(string @string) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal UnavailableException() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/view/KeyCharacterMap$KeyData
				/// </java-name>
				[Dot42.DexImport("android/view/KeyCharacterMap$KeyData", AccessFlags = 9)]
				public partial class KeyData
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// META_LENGTH
						/// </java-name>
						[Dot42.DexImport("META_LENGTH", "I", AccessFlags = 25)]
						public const int META_LENGTH = 4;
						/// <java-name>
						/// displayLabel
						/// </java-name>
						[Dot42.DexImport("displayLabel", "C", AccessFlags = 1)]
						public char DisplayLabel;
						/// <java-name>
						/// number
						/// </java-name>
						[Dot42.DexImport("number", "C", AccessFlags = 1)]
						public char Number;
						/// <java-name>
						/// meta
						/// </java-name>
						[Dot42.DexImport("meta", "[C", AccessFlags = 1)]
						public char[] Meta;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public KeyData() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/view/KeyEvent
		/// </java-name>
		[Dot42.DexImport("android/view/KeyEvent", AccessFlags = 33)]
		public partial class KeyEvent : global::Android.Views.InputEvent, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// KEYCODE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_UNKNOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_UNKNOWN = 0;
				/// <java-name>
				/// KEYCODE_SOFT_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SOFT_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_SOFT_LEFT = 1;
				/// <java-name>
				/// KEYCODE_SOFT_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SOFT_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_SOFT_RIGHT = 2;
				/// <java-name>
				/// KEYCODE_HOME
				/// </java-name>
				[Dot42.DexImport("KEYCODE_HOME", "I", AccessFlags = 25)]
				public const int KEYCODE_HOME = 3;
				/// <java-name>
				/// KEYCODE_BACK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BACK", "I", AccessFlags = 25)]
				public const int KEYCODE_BACK = 4;
				/// <java-name>
				/// KEYCODE_CALL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CALL", "I", AccessFlags = 25)]
				public const int KEYCODE_CALL = 5;
				/// <java-name>
				/// KEYCODE_ENDCALL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ENDCALL", "I", AccessFlags = 25)]
				public const int KEYCODE_ENDCALL = 6;
				/// <java-name>
				/// KEYCODE_0
				/// </java-name>
				[Dot42.DexImport("KEYCODE_0", "I", AccessFlags = 25)]
				public const int KEYCODE_0 = 7;
				/// <java-name>
				/// KEYCODE_1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_1", "I", AccessFlags = 25)]
				public const int KEYCODE_1 = 8;
				/// <java-name>
				/// KEYCODE_2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_2", "I", AccessFlags = 25)]
				public const int KEYCODE_2 = 9;
				/// <java-name>
				/// KEYCODE_3
				/// </java-name>
				[Dot42.DexImport("KEYCODE_3", "I", AccessFlags = 25)]
				public const int KEYCODE_3 = 10;
				/// <java-name>
				/// KEYCODE_4
				/// </java-name>
				[Dot42.DexImport("KEYCODE_4", "I", AccessFlags = 25)]
				public const int KEYCODE_4 = 11;
				/// <java-name>
				/// KEYCODE_5
				/// </java-name>
				[Dot42.DexImport("KEYCODE_5", "I", AccessFlags = 25)]
				public const int KEYCODE_5 = 12;
				/// <java-name>
				/// KEYCODE_6
				/// </java-name>
				[Dot42.DexImport("KEYCODE_6", "I", AccessFlags = 25)]
				public const int KEYCODE_6 = 13;
				/// <java-name>
				/// KEYCODE_7
				/// </java-name>
				[Dot42.DexImport("KEYCODE_7", "I", AccessFlags = 25)]
				public const int KEYCODE_7 = 14;
				/// <java-name>
				/// KEYCODE_8
				/// </java-name>
				[Dot42.DexImport("KEYCODE_8", "I", AccessFlags = 25)]
				public const int KEYCODE_8 = 15;
				/// <java-name>
				/// KEYCODE_9
				/// </java-name>
				[Dot42.DexImport("KEYCODE_9", "I", AccessFlags = 25)]
				public const int KEYCODE_9 = 16;
				/// <java-name>
				/// KEYCODE_STAR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_STAR", "I", AccessFlags = 25)]
				public const int KEYCODE_STAR = 17;
				/// <java-name>
				/// KEYCODE_POUND
				/// </java-name>
				[Dot42.DexImport("KEYCODE_POUND", "I", AccessFlags = 25)]
				public const int KEYCODE_POUND = 18;
				/// <java-name>
				/// KEYCODE_DPAD_UP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_UP", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_UP = 19;
				/// <java-name>
				/// KEYCODE_DPAD_DOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_DOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_DOWN = 20;
				/// <java-name>
				/// KEYCODE_DPAD_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_LEFT = 21;
				/// <java-name>
				/// KEYCODE_DPAD_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_RIGHT = 22;
				/// <java-name>
				/// KEYCODE_DPAD_CENTER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_CENTER", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_CENTER = 23;
				/// <java-name>
				/// KEYCODE_VOLUME_UP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_VOLUME_UP", "I", AccessFlags = 25)]
				public const int KEYCODE_VOLUME_UP = 24;
				/// <java-name>
				/// KEYCODE_VOLUME_DOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_VOLUME_DOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_VOLUME_DOWN = 25;
				/// <java-name>
				/// KEYCODE_POWER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_POWER", "I", AccessFlags = 25)]
				public const int KEYCODE_POWER = 26;
				/// <java-name>
				/// KEYCODE_CAMERA
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CAMERA", "I", AccessFlags = 25)]
				public const int KEYCODE_CAMERA = 27;
				/// <java-name>
				/// KEYCODE_CLEAR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CLEAR", "I", AccessFlags = 25)]
				public const int KEYCODE_CLEAR = 28;
				/// <java-name>
				/// KEYCODE_A
				/// </java-name>
				[Dot42.DexImport("KEYCODE_A", "I", AccessFlags = 25)]
				public const int KEYCODE_A = 29;
				/// <java-name>
				/// KEYCODE_B
				/// </java-name>
				[Dot42.DexImport("KEYCODE_B", "I", AccessFlags = 25)]
				public const int KEYCODE_B = 30;
				/// <java-name>
				/// KEYCODE_C
				/// </java-name>
				[Dot42.DexImport("KEYCODE_C", "I", AccessFlags = 25)]
				public const int KEYCODE_C = 31;
				/// <java-name>
				/// KEYCODE_D
				/// </java-name>
				[Dot42.DexImport("KEYCODE_D", "I", AccessFlags = 25)]
				public const int KEYCODE_D = 32;
				/// <java-name>
				/// KEYCODE_E
				/// </java-name>
				[Dot42.DexImport("KEYCODE_E", "I", AccessFlags = 25)]
				public const int KEYCODE_E = 33;
				/// <java-name>
				/// KEYCODE_F
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F", "I", AccessFlags = 25)]
				public const int KEYCODE_F = 34;
				/// <java-name>
				/// KEYCODE_G
				/// </java-name>
				[Dot42.DexImport("KEYCODE_G", "I", AccessFlags = 25)]
				public const int KEYCODE_G = 35;
				/// <java-name>
				/// KEYCODE_H
				/// </java-name>
				[Dot42.DexImport("KEYCODE_H", "I", AccessFlags = 25)]
				public const int KEYCODE_H = 36;
				/// <java-name>
				/// KEYCODE_I
				/// </java-name>
				[Dot42.DexImport("KEYCODE_I", "I", AccessFlags = 25)]
				public const int KEYCODE_I = 37;
				/// <java-name>
				/// KEYCODE_J
				/// </java-name>
				[Dot42.DexImport("KEYCODE_J", "I", AccessFlags = 25)]
				public const int KEYCODE_J = 38;
				/// <java-name>
				/// KEYCODE_K
				/// </java-name>
				[Dot42.DexImport("KEYCODE_K", "I", AccessFlags = 25)]
				public const int KEYCODE_K = 39;
				/// <java-name>
				/// KEYCODE_L
				/// </java-name>
				[Dot42.DexImport("KEYCODE_L", "I", AccessFlags = 25)]
				public const int KEYCODE_L = 40;
				/// <java-name>
				/// KEYCODE_M
				/// </java-name>
				[Dot42.DexImport("KEYCODE_M", "I", AccessFlags = 25)]
				public const int KEYCODE_M = 41;
				/// <java-name>
				/// KEYCODE_N
				/// </java-name>
				[Dot42.DexImport("KEYCODE_N", "I", AccessFlags = 25)]
				public const int KEYCODE_N = 42;
				/// <java-name>
				/// KEYCODE_O
				/// </java-name>
				[Dot42.DexImport("KEYCODE_O", "I", AccessFlags = 25)]
				public const int KEYCODE_O = 43;
				/// <java-name>
				/// KEYCODE_P
				/// </java-name>
				[Dot42.DexImport("KEYCODE_P", "I", AccessFlags = 25)]
				public const int KEYCODE_P = 44;
				/// <java-name>
				/// KEYCODE_Q
				/// </java-name>
				[Dot42.DexImport("KEYCODE_Q", "I", AccessFlags = 25)]
				public const int KEYCODE_Q = 45;
				/// <java-name>
				/// KEYCODE_R
				/// </java-name>
				[Dot42.DexImport("KEYCODE_R", "I", AccessFlags = 25)]
				public const int KEYCODE_R = 46;
				/// <java-name>
				/// KEYCODE_S
				/// </java-name>
				[Dot42.DexImport("KEYCODE_S", "I", AccessFlags = 25)]
				public const int KEYCODE_S = 47;
				/// <java-name>
				/// KEYCODE_T
				/// </java-name>
				[Dot42.DexImport("KEYCODE_T", "I", AccessFlags = 25)]
				public const int KEYCODE_T = 48;
				/// <java-name>
				/// KEYCODE_U
				/// </java-name>
				[Dot42.DexImport("KEYCODE_U", "I", AccessFlags = 25)]
				public const int KEYCODE_U = 49;
				/// <java-name>
				/// KEYCODE_V
				/// </java-name>
				[Dot42.DexImport("KEYCODE_V", "I", AccessFlags = 25)]
				public const int KEYCODE_V = 50;
				/// <java-name>
				/// KEYCODE_W
				/// </java-name>
				[Dot42.DexImport("KEYCODE_W", "I", AccessFlags = 25)]
				public const int KEYCODE_W = 51;
				/// <java-name>
				/// KEYCODE_X
				/// </java-name>
				[Dot42.DexImport("KEYCODE_X", "I", AccessFlags = 25)]
				public const int KEYCODE_X = 52;
				/// <java-name>
				/// KEYCODE_Y
				/// </java-name>
				[Dot42.DexImport("KEYCODE_Y", "I", AccessFlags = 25)]
				public const int KEYCODE_Y = 53;
				/// <java-name>
				/// KEYCODE_Z
				/// </java-name>
				[Dot42.DexImport("KEYCODE_Z", "I", AccessFlags = 25)]
				public const int KEYCODE_Z = 54;
				/// <java-name>
				/// KEYCODE_COMMA
				/// </java-name>
				[Dot42.DexImport("KEYCODE_COMMA", "I", AccessFlags = 25)]
				public const int KEYCODE_COMMA = 55;
				/// <java-name>
				/// KEYCODE_PERIOD
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PERIOD", "I", AccessFlags = 25)]
				public const int KEYCODE_PERIOD = 56;
				/// <java-name>
				/// KEYCODE_ALT_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ALT_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_ALT_LEFT = 57;
				/// <java-name>
				/// KEYCODE_ALT_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ALT_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_ALT_RIGHT = 58;
				/// <java-name>
				/// KEYCODE_SHIFT_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SHIFT_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_SHIFT_LEFT = 59;
				/// <java-name>
				/// KEYCODE_SHIFT_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SHIFT_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_SHIFT_RIGHT = 60;
				/// <java-name>
				/// KEYCODE_TAB
				/// </java-name>
				[Dot42.DexImport("KEYCODE_TAB", "I", AccessFlags = 25)]
				public const int KEYCODE_TAB = 61;
				/// <java-name>
				/// KEYCODE_SPACE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SPACE", "I", AccessFlags = 25)]
				public const int KEYCODE_SPACE = 62;
				/// <java-name>
				/// KEYCODE_SYM
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SYM", "I", AccessFlags = 25)]
				public const int KEYCODE_SYM = 63;
				/// <java-name>
				/// KEYCODE_EXPLORER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_EXPLORER", "I", AccessFlags = 25)]
				public const int KEYCODE_EXPLORER = 64;
				/// <java-name>
				/// KEYCODE_ENVELOPE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ENVELOPE", "I", AccessFlags = 25)]
				public const int KEYCODE_ENVELOPE = 65;
				/// <java-name>
				/// KEYCODE_ENTER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ENTER", "I", AccessFlags = 25)]
				public const int KEYCODE_ENTER = 66;
				/// <java-name>
				/// KEYCODE_DEL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DEL", "I", AccessFlags = 25)]
				public const int KEYCODE_DEL = 67;
				/// <java-name>
				/// KEYCODE_GRAVE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_GRAVE", "I", AccessFlags = 25)]
				public const int KEYCODE_GRAVE = 68;
				/// <java-name>
				/// KEYCODE_MINUS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MINUS", "I", AccessFlags = 25)]
				public const int KEYCODE_MINUS = 69;
				/// <java-name>
				/// KEYCODE_EQUALS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_EQUALS", "I", AccessFlags = 25)]
				public const int KEYCODE_EQUALS = 70;
				/// <java-name>
				/// KEYCODE_LEFT_BRACKET
				/// </java-name>
				[Dot42.DexImport("KEYCODE_LEFT_BRACKET", "I", AccessFlags = 25)]
				public const int KEYCODE_LEFT_BRACKET = 71;
				/// <java-name>
				/// KEYCODE_RIGHT_BRACKET
				/// </java-name>
				[Dot42.DexImport("KEYCODE_RIGHT_BRACKET", "I", AccessFlags = 25)]
				public const int KEYCODE_RIGHT_BRACKET = 72;
				/// <java-name>
				/// KEYCODE_BACKSLASH
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BACKSLASH", "I", AccessFlags = 25)]
				public const int KEYCODE_BACKSLASH = 73;
				/// <java-name>
				/// KEYCODE_SEMICOLON
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SEMICOLON", "I", AccessFlags = 25)]
				public const int KEYCODE_SEMICOLON = 74;
				/// <java-name>
				/// KEYCODE_APOSTROPHE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_APOSTROPHE", "I", AccessFlags = 25)]
				public const int KEYCODE_APOSTROPHE = 75;
				/// <java-name>
				/// KEYCODE_SLASH
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SLASH", "I", AccessFlags = 25)]
				public const int KEYCODE_SLASH = 76;
				/// <java-name>
				/// KEYCODE_AT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_AT", "I", AccessFlags = 25)]
				public const int KEYCODE_AT = 77;
				/// <java-name>
				/// KEYCODE_NUM
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUM", "I", AccessFlags = 25)]
				public const int KEYCODE_NUM = 78;
				/// <java-name>
				/// KEYCODE_HEADSETHOOK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_HEADSETHOOK", "I", AccessFlags = 25)]
				public const int KEYCODE_HEADSETHOOK = 79;
				/// <java-name>
				/// KEYCODE_FOCUS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_FOCUS", "I", AccessFlags = 25)]
				public const int KEYCODE_FOCUS = 80;
				/// <java-name>
				/// KEYCODE_PLUS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PLUS", "I", AccessFlags = 25)]
				public const int KEYCODE_PLUS = 81;
				/// <java-name>
				/// KEYCODE_MENU
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MENU", "I", AccessFlags = 25)]
				public const int KEYCODE_MENU = 82;
				/// <java-name>
				/// KEYCODE_NOTIFICATION
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NOTIFICATION", "I", AccessFlags = 25)]
				public const int KEYCODE_NOTIFICATION = 83;
				/// <java-name>
				/// KEYCODE_SEARCH
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SEARCH", "I", AccessFlags = 25)]
				public const int KEYCODE_SEARCH = 84;
				/// <java-name>
				/// KEYCODE_MEDIA_PLAY_PAUSE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_PLAY_PAUSE", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_PLAY_PAUSE = 85;
				/// <java-name>
				/// KEYCODE_MEDIA_STOP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_STOP", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_STOP = 86;
				/// <java-name>
				/// KEYCODE_MEDIA_NEXT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_NEXT", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_NEXT = 87;
				/// <java-name>
				/// KEYCODE_MEDIA_PREVIOUS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_PREVIOUS", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_PREVIOUS = 88;
				/// <java-name>
				/// KEYCODE_MEDIA_REWIND
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_REWIND", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_REWIND = 89;
				/// <java-name>
				/// KEYCODE_MEDIA_FAST_FORWARD
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_FAST_FORWARD", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_FAST_FORWARD = 90;
				/// <java-name>
				/// KEYCODE_MUTE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MUTE", "I", AccessFlags = 25)]
				public const int KEYCODE_MUTE = 91;
				/// <java-name>
				/// KEYCODE_PAGE_UP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PAGE_UP", "I", AccessFlags = 25)]
				public const int KEYCODE_PAGE_UP = 92;
				/// <java-name>
				/// KEYCODE_PAGE_DOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PAGE_DOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_PAGE_DOWN = 93;
				/// <java-name>
				/// KEYCODE_PICTSYMBOLS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PICTSYMBOLS", "I", AccessFlags = 25)]
				public const int KEYCODE_PICTSYMBOLS = 94;
				/// <java-name>
				/// KEYCODE_SWITCH_CHARSET
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SWITCH_CHARSET", "I", AccessFlags = 25)]
				public const int KEYCODE_SWITCH_CHARSET = 95;
				/// <java-name>
				/// KEYCODE_BUTTON_A
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_A", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_A = 96;
				/// <java-name>
				/// KEYCODE_BUTTON_B
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_B", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_B = 97;
				/// <java-name>
				/// KEYCODE_BUTTON_C
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_C", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_C = 98;
				/// <java-name>
				/// KEYCODE_BUTTON_X
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_X", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_X = 99;
				/// <java-name>
				/// KEYCODE_BUTTON_Y
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_Y", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_Y = 100;
				/// <java-name>
				/// KEYCODE_BUTTON_Z
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_Z", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_Z = 101;
				/// <java-name>
				/// KEYCODE_BUTTON_L1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_L1", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_L1 = 102;
				/// <java-name>
				/// KEYCODE_BUTTON_R1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_R1", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_R1 = 103;
				/// <java-name>
				/// KEYCODE_BUTTON_L2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_L2", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_L2 = 104;
				/// <java-name>
				/// KEYCODE_BUTTON_R2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_R2", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_R2 = 105;
				/// <java-name>
				/// KEYCODE_BUTTON_THUMBL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_THUMBL", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_THUMBL = 106;
				/// <java-name>
				/// KEYCODE_BUTTON_THUMBR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_THUMBR", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_THUMBR = 107;
				/// <java-name>
				/// KEYCODE_BUTTON_START
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_START", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_START = 108;
				/// <java-name>
				/// KEYCODE_BUTTON_SELECT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_SELECT", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_SELECT = 109;
				/// <java-name>
				/// KEYCODE_BUTTON_MODE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_MODE", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_MODE = 110;
				/// <java-name>
				/// KEYCODE_ESCAPE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ESCAPE", "I", AccessFlags = 25)]
				public const int KEYCODE_ESCAPE = 111;
				/// <java-name>
				/// KEYCODE_FORWARD_DEL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_FORWARD_DEL", "I", AccessFlags = 25)]
				public const int KEYCODE_FORWARD_DEL = 112;
				/// <java-name>
				/// KEYCODE_CTRL_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CTRL_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_CTRL_LEFT = 113;
				/// <java-name>
				/// KEYCODE_CTRL_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CTRL_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_CTRL_RIGHT = 114;
				/// <java-name>
				/// KEYCODE_CAPS_LOCK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CAPS_LOCK", "I", AccessFlags = 25)]
				public const int KEYCODE_CAPS_LOCK = 115;
				/// <java-name>
				/// KEYCODE_SCROLL_LOCK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SCROLL_LOCK", "I", AccessFlags = 25)]
				public const int KEYCODE_SCROLL_LOCK = 116;
				/// <java-name>
				/// KEYCODE_META_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_META_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_META_LEFT = 117;
				/// <java-name>
				/// KEYCODE_META_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_META_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_META_RIGHT = 118;
				/// <java-name>
				/// KEYCODE_FUNCTION
				/// </java-name>
				[Dot42.DexImport("KEYCODE_FUNCTION", "I", AccessFlags = 25)]
				public const int KEYCODE_FUNCTION = 119;
				/// <java-name>
				/// KEYCODE_SYSRQ
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SYSRQ", "I", AccessFlags = 25)]
				public const int KEYCODE_SYSRQ = 120;
				/// <java-name>
				/// KEYCODE_BREAK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BREAK", "I", AccessFlags = 25)]
				public const int KEYCODE_BREAK = 121;
				/// <java-name>
				/// KEYCODE_MOVE_HOME
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MOVE_HOME", "I", AccessFlags = 25)]
				public const int KEYCODE_MOVE_HOME = 122;
				/// <java-name>
				/// KEYCODE_MOVE_END
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MOVE_END", "I", AccessFlags = 25)]
				public const int KEYCODE_MOVE_END = 123;
				/// <java-name>
				/// KEYCODE_INSERT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_INSERT", "I", AccessFlags = 25)]
				public const int KEYCODE_INSERT = 124;
				/// <java-name>
				/// KEYCODE_FORWARD
				/// </java-name>
				[Dot42.DexImport("KEYCODE_FORWARD", "I", AccessFlags = 25)]
				public const int KEYCODE_FORWARD = 125;
				/// <java-name>
				/// KEYCODE_MEDIA_PLAY
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_PLAY", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_PLAY = 126;
				/// <java-name>
				/// KEYCODE_MEDIA_PAUSE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_PAUSE", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_PAUSE = 127;
				/// <java-name>
				/// KEYCODE_MEDIA_CLOSE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_CLOSE", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_CLOSE = 128;
				/// <java-name>
				/// KEYCODE_MEDIA_EJECT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_EJECT", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_EJECT = 129;
				/// <java-name>
				/// KEYCODE_MEDIA_RECORD
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_RECORD", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_RECORD = 130;
				/// <java-name>
				/// KEYCODE_F1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F1", "I", AccessFlags = 25)]
				public const int KEYCODE_F1 = 131;
				/// <java-name>
				/// KEYCODE_F2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F2", "I", AccessFlags = 25)]
				public const int KEYCODE_F2 = 132;
				/// <java-name>
				/// KEYCODE_F3
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F3", "I", AccessFlags = 25)]
				public const int KEYCODE_F3 = 133;
				/// <java-name>
				/// KEYCODE_F4
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F4", "I", AccessFlags = 25)]
				public const int KEYCODE_F4 = 134;
				/// <java-name>
				/// KEYCODE_F5
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F5", "I", AccessFlags = 25)]
				public const int KEYCODE_F5 = 135;
				/// <java-name>
				/// KEYCODE_F6
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F6", "I", AccessFlags = 25)]
				public const int KEYCODE_F6 = 136;
				/// <java-name>
				/// KEYCODE_F7
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F7", "I", AccessFlags = 25)]
				public const int KEYCODE_F7 = 137;
				/// <java-name>
				/// KEYCODE_F8
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F8", "I", AccessFlags = 25)]
				public const int KEYCODE_F8 = 138;
				/// <java-name>
				/// KEYCODE_F9
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F9", "I", AccessFlags = 25)]
				public const int KEYCODE_F9 = 139;
				/// <java-name>
				/// KEYCODE_F10
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F10", "I", AccessFlags = 25)]
				public const int KEYCODE_F10 = 140;
				/// <java-name>
				/// KEYCODE_F11
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F11", "I", AccessFlags = 25)]
				public const int KEYCODE_F11 = 141;
				/// <java-name>
				/// KEYCODE_F12
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F12", "I", AccessFlags = 25)]
				public const int KEYCODE_F12 = 142;
				/// <java-name>
				/// KEYCODE_NUM_LOCK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUM_LOCK", "I", AccessFlags = 25)]
				public const int KEYCODE_NUM_LOCK = 143;
				/// <java-name>
				/// KEYCODE_NUMPAD_0
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_0", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_0 = 144;
				/// <java-name>
				/// KEYCODE_NUMPAD_1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_1", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_1 = 145;
				/// <java-name>
				/// KEYCODE_NUMPAD_2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_2", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_2 = 146;
				/// <java-name>
				/// KEYCODE_NUMPAD_3
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_3", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_3 = 147;
				/// <java-name>
				/// KEYCODE_NUMPAD_4
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_4", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_4 = 148;
				/// <java-name>
				/// KEYCODE_NUMPAD_5
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_5", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_5 = 149;
				/// <java-name>
				/// KEYCODE_NUMPAD_6
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_6", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_6 = 150;
				/// <java-name>
				/// KEYCODE_NUMPAD_7
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_7", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_7 = 151;
				/// <java-name>
				/// KEYCODE_NUMPAD_8
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_8", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_8 = 152;
				/// <java-name>
				/// KEYCODE_NUMPAD_9
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_9", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_9 = 153;
				/// <java-name>
				/// KEYCODE_NUMPAD_DIVIDE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_DIVIDE", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_DIVIDE = 154;
				/// <java-name>
				/// KEYCODE_NUMPAD_MULTIPLY
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_MULTIPLY", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_MULTIPLY = 155;
				/// <java-name>
				/// KEYCODE_NUMPAD_SUBTRACT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_SUBTRACT", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_SUBTRACT = 156;
				/// <java-name>
				/// KEYCODE_NUMPAD_ADD
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_ADD", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_ADD = 157;
				/// <java-name>
				/// KEYCODE_NUMPAD_DOT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_DOT", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_DOT = 158;
				/// <java-name>
				/// KEYCODE_NUMPAD_COMMA
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_COMMA", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_COMMA = 159;
				/// <java-name>
				/// KEYCODE_NUMPAD_ENTER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_ENTER", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_ENTER = 160;
				/// <java-name>
				/// KEYCODE_NUMPAD_EQUALS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_EQUALS", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_EQUALS = 161;
				/// <java-name>
				/// KEYCODE_NUMPAD_LEFT_PAREN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_LEFT_PAREN", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_LEFT_PAREN = 162;
				/// <java-name>
				/// KEYCODE_NUMPAD_RIGHT_PAREN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUMPAD_RIGHT_PAREN", "I", AccessFlags = 25)]
				public const int KEYCODE_NUMPAD_RIGHT_PAREN = 163;
				/// <java-name>
				/// KEYCODE_VOLUME_MUTE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_VOLUME_MUTE", "I", AccessFlags = 25)]
				public const int KEYCODE_VOLUME_MUTE = 164;
				/// <java-name>
				/// KEYCODE_INFO
				/// </java-name>
				[Dot42.DexImport("KEYCODE_INFO", "I", AccessFlags = 25)]
				public const int KEYCODE_INFO = 165;
				/// <java-name>
				/// KEYCODE_CHANNEL_UP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CHANNEL_UP", "I", AccessFlags = 25)]
				public const int KEYCODE_CHANNEL_UP = 166;
				/// <java-name>
				/// KEYCODE_CHANNEL_DOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CHANNEL_DOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_CHANNEL_DOWN = 167;
				/// <java-name>
				/// KEYCODE_ZOOM_IN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ZOOM_IN", "I", AccessFlags = 25)]
				public const int KEYCODE_ZOOM_IN = 168;
				/// <java-name>
				/// KEYCODE_ZOOM_OUT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ZOOM_OUT", "I", AccessFlags = 25)]
				public const int KEYCODE_ZOOM_OUT = 169;
				/// <java-name>
				/// KEYCODE_TV
				/// </java-name>
				[Dot42.DexImport("KEYCODE_TV", "I", AccessFlags = 25)]
				public const int KEYCODE_TV = 170;
				/// <java-name>
				/// KEYCODE_WINDOW
				/// </java-name>
				[Dot42.DexImport("KEYCODE_WINDOW", "I", AccessFlags = 25)]
				public const int KEYCODE_WINDOW = 171;
				/// <java-name>
				/// KEYCODE_GUIDE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_GUIDE", "I", AccessFlags = 25)]
				public const int KEYCODE_GUIDE = 172;
				/// <java-name>
				/// KEYCODE_DVR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DVR", "I", AccessFlags = 25)]
				public const int KEYCODE_DVR = 173;
				/// <java-name>
				/// KEYCODE_BOOKMARK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BOOKMARK", "I", AccessFlags = 25)]
				public const int KEYCODE_BOOKMARK = 174;
				/// <java-name>
				/// KEYCODE_CAPTIONS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CAPTIONS", "I", AccessFlags = 25)]
				public const int KEYCODE_CAPTIONS = 175;
				/// <java-name>
				/// KEYCODE_SETTINGS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SETTINGS", "I", AccessFlags = 25)]
				public const int KEYCODE_SETTINGS = 176;
				/// <java-name>
				/// KEYCODE_TV_POWER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_TV_POWER", "I", AccessFlags = 25)]
				public const int KEYCODE_TV_POWER = 177;
				/// <java-name>
				/// KEYCODE_TV_INPUT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_TV_INPUT", "I", AccessFlags = 25)]
				public const int KEYCODE_TV_INPUT = 178;
				/// <java-name>
				/// KEYCODE_STB_POWER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_STB_POWER", "I", AccessFlags = 25)]
				public const int KEYCODE_STB_POWER = 179;
				/// <java-name>
				/// KEYCODE_STB_INPUT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_STB_INPUT", "I", AccessFlags = 25)]
				public const int KEYCODE_STB_INPUT = 180;
				/// <java-name>
				/// KEYCODE_AVR_POWER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_AVR_POWER", "I", AccessFlags = 25)]
				public const int KEYCODE_AVR_POWER = 181;
				/// <java-name>
				/// KEYCODE_AVR_INPUT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_AVR_INPUT", "I", AccessFlags = 25)]
				public const int KEYCODE_AVR_INPUT = 182;
				/// <java-name>
				/// KEYCODE_PROG_RED
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PROG_RED", "I", AccessFlags = 25)]
				public const int KEYCODE_PROG_RED = 183;
				/// <java-name>
				/// KEYCODE_PROG_GREEN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PROG_GREEN", "I", AccessFlags = 25)]
				public const int KEYCODE_PROG_GREEN = 184;
				/// <java-name>
				/// KEYCODE_PROG_YELLOW
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PROG_YELLOW", "I", AccessFlags = 25)]
				public const int KEYCODE_PROG_YELLOW = 185;
				/// <java-name>
				/// KEYCODE_PROG_BLUE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PROG_BLUE", "I", AccessFlags = 25)]
				public const int KEYCODE_PROG_BLUE = 186;
				/// <java-name>
				/// KEYCODE_APP_SWITCH
				/// </java-name>
				[Dot42.DexImport("KEYCODE_APP_SWITCH", "I", AccessFlags = 25)]
				public const int KEYCODE_APP_SWITCH = 187;
				/// <java-name>
				/// KEYCODE_BUTTON_1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_1", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_1 = 188;
				/// <java-name>
				/// KEYCODE_BUTTON_2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_2", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_2 = 189;
				/// <java-name>
				/// KEYCODE_BUTTON_3
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_3", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_3 = 190;
				/// <java-name>
				/// KEYCODE_BUTTON_4
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_4", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_4 = 191;
				/// <java-name>
				/// KEYCODE_BUTTON_5
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_5", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_5 = 192;
				/// <java-name>
				/// KEYCODE_BUTTON_6
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_6", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_6 = 193;
				/// <java-name>
				/// KEYCODE_BUTTON_7
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_7", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_7 = 194;
				/// <java-name>
				/// KEYCODE_BUTTON_8
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_8", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_8 = 195;
				/// <java-name>
				/// KEYCODE_BUTTON_9
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_9", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_9 = 196;
				/// <java-name>
				/// KEYCODE_BUTTON_10
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_10", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_10 = 197;
				/// <java-name>
				/// KEYCODE_BUTTON_11
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_11", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_11 = 198;
				/// <java-name>
				/// KEYCODE_BUTTON_12
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_12", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_12 = 199;
				/// <java-name>
				/// KEYCODE_BUTTON_13
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_13", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_13 = 200;
				/// <java-name>
				/// KEYCODE_BUTTON_14
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_14", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_14 = 201;
				/// <java-name>
				/// KEYCODE_BUTTON_15
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_15", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_15 = 202;
				/// <java-name>
				/// KEYCODE_BUTTON_16
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_16", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_16 = 203;
				/// <java-name>
				/// KEYCODE_LANGUAGE_SWITCH
				/// </java-name>
				[Dot42.DexImport("KEYCODE_LANGUAGE_SWITCH", "I", AccessFlags = 25)]
				public const int KEYCODE_LANGUAGE_SWITCH = 204;
				/// <java-name>
				/// KEYCODE_MANNER_MODE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MANNER_MODE", "I", AccessFlags = 25)]
				public const int KEYCODE_MANNER_MODE = 205;
				/// <java-name>
				/// KEYCODE_3D_MODE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_3D_MODE", "I", AccessFlags = 25)]
				public const int KEYCODE_3D_MODE = 206;
				/// <java-name>
				/// KEYCODE_CONTACTS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CONTACTS", "I", AccessFlags = 25)]
				public const int KEYCODE_CONTACTS = 207;
				/// <java-name>
				/// KEYCODE_CALENDAR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CALENDAR", "I", AccessFlags = 25)]
				public const int KEYCODE_CALENDAR = 208;
				/// <java-name>
				/// KEYCODE_MUSIC
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MUSIC", "I", AccessFlags = 25)]
				public const int KEYCODE_MUSIC = 209;
				/// <java-name>
				/// KEYCODE_CALCULATOR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CALCULATOR", "I", AccessFlags = 25)]
				public const int KEYCODE_CALCULATOR = 210;
				/// <java-name>
				/// MAX_KEYCODE
				/// </java-name>
				[Dot42.DexImport("MAX_KEYCODE", "I", AccessFlags = 25)]
				public const int MAX_KEYCODE = 84;
				/// <java-name>
				/// ACTION_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_DOWN = 0;
				/// <java-name>
				/// ACTION_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_UP", "I", AccessFlags = 25)]
				public const int ACTION_UP = 1;
				/// <java-name>
				/// ACTION_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("ACTION_MULTIPLE", "I", AccessFlags = 25)]
				public const int ACTION_MULTIPLE = 2;
				/// <java-name>
				/// META_ALT_ON
				/// </java-name>
				[Dot42.DexImport("META_ALT_ON", "I", AccessFlags = 25)]
				public const int META_ALT_ON = 2;
				/// <java-name>
				/// META_ALT_LEFT_ON
				/// </java-name>
				[Dot42.DexImport("META_ALT_LEFT_ON", "I", AccessFlags = 25)]
				public const int META_ALT_LEFT_ON = 16;
				/// <java-name>
				/// META_ALT_RIGHT_ON
				/// </java-name>
				[Dot42.DexImport("META_ALT_RIGHT_ON", "I", AccessFlags = 25)]
				public const int META_ALT_RIGHT_ON = 32;
				/// <java-name>
				/// META_SHIFT_ON
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_ON", "I", AccessFlags = 25)]
				public const int META_SHIFT_ON = 1;
				/// <java-name>
				/// META_SHIFT_LEFT_ON
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_LEFT_ON", "I", AccessFlags = 25)]
				public const int META_SHIFT_LEFT_ON = 64;
				/// <java-name>
				/// META_SHIFT_RIGHT_ON
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_RIGHT_ON", "I", AccessFlags = 25)]
				public const int META_SHIFT_RIGHT_ON = 128;
				/// <java-name>
				/// META_SYM_ON
				/// </java-name>
				[Dot42.DexImport("META_SYM_ON", "I", AccessFlags = 25)]
				public const int META_SYM_ON = 4;
				/// <java-name>
				/// META_FUNCTION_ON
				/// </java-name>
				[Dot42.DexImport("META_FUNCTION_ON", "I", AccessFlags = 25)]
				public const int META_FUNCTION_ON = 8;
				/// <java-name>
				/// META_CTRL_ON
				/// </java-name>
				[Dot42.DexImport("META_CTRL_ON", "I", AccessFlags = 25)]
				public const int META_CTRL_ON = 4096;
				/// <java-name>
				/// META_CTRL_LEFT_ON
				/// </java-name>
				[Dot42.DexImport("META_CTRL_LEFT_ON", "I", AccessFlags = 25)]
				public const int META_CTRL_LEFT_ON = 8192;
				/// <java-name>
				/// META_CTRL_RIGHT_ON
				/// </java-name>
				[Dot42.DexImport("META_CTRL_RIGHT_ON", "I", AccessFlags = 25)]
				public const int META_CTRL_RIGHT_ON = 16384;
				/// <java-name>
				/// META_META_ON
				/// </java-name>
				[Dot42.DexImport("META_META_ON", "I", AccessFlags = 25)]
				public const int META_META_ON = 65536;
				/// <java-name>
				/// META_META_LEFT_ON
				/// </java-name>
				[Dot42.DexImport("META_META_LEFT_ON", "I", AccessFlags = 25)]
				public const int META_META_LEFT_ON = 131072;
				/// <java-name>
				/// META_META_RIGHT_ON
				/// </java-name>
				[Dot42.DexImport("META_META_RIGHT_ON", "I", AccessFlags = 25)]
				public const int META_META_RIGHT_ON = 262144;
				/// <java-name>
				/// META_CAPS_LOCK_ON
				/// </java-name>
				[Dot42.DexImport("META_CAPS_LOCK_ON", "I", AccessFlags = 25)]
				public const int META_CAPS_LOCK_ON = 1048576;
				/// <java-name>
				/// META_NUM_LOCK_ON
				/// </java-name>
				[Dot42.DexImport("META_NUM_LOCK_ON", "I", AccessFlags = 25)]
				public const int META_NUM_LOCK_ON = 2097152;
				/// <java-name>
				/// META_SCROLL_LOCK_ON
				/// </java-name>
				[Dot42.DexImport("META_SCROLL_LOCK_ON", "I", AccessFlags = 25)]
				public const int META_SCROLL_LOCK_ON = 4194304;
				/// <java-name>
				/// META_SHIFT_MASK
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_MASK", "I", AccessFlags = 25)]
				public const int META_SHIFT_MASK = 193;
				/// <java-name>
				/// META_ALT_MASK
				/// </java-name>
				[Dot42.DexImport("META_ALT_MASK", "I", AccessFlags = 25)]
				public const int META_ALT_MASK = 50;
				/// <java-name>
				/// META_CTRL_MASK
				/// </java-name>
				[Dot42.DexImport("META_CTRL_MASK", "I", AccessFlags = 25)]
				public const int META_CTRL_MASK = 28672;
				/// <java-name>
				/// META_META_MASK
				/// </java-name>
				[Dot42.DexImport("META_META_MASK", "I", AccessFlags = 25)]
				public const int META_META_MASK = 458752;
				/// <java-name>
				/// FLAG_WOKE_HERE
				/// </java-name>
				[Dot42.DexImport("FLAG_WOKE_HERE", "I", AccessFlags = 25)]
				public const int FLAG_WOKE_HERE = 1;
				/// <java-name>
				/// FLAG_SOFT_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("FLAG_SOFT_KEYBOARD", "I", AccessFlags = 25)]
				public const int FLAG_SOFT_KEYBOARD = 2;
				/// <java-name>
				/// FLAG_KEEP_TOUCH_MODE
				/// </java-name>
				[Dot42.DexImport("FLAG_KEEP_TOUCH_MODE", "I", AccessFlags = 25)]
				public const int FLAG_KEEP_TOUCH_MODE = 4;
				/// <java-name>
				/// FLAG_FROM_SYSTEM
				/// </java-name>
				[Dot42.DexImport("FLAG_FROM_SYSTEM", "I", AccessFlags = 25)]
				public const int FLAG_FROM_SYSTEM = 8;
				/// <java-name>
				/// FLAG_EDITOR_ACTION
				/// </java-name>
				[Dot42.DexImport("FLAG_EDITOR_ACTION", "I", AccessFlags = 25)]
				public const int FLAG_EDITOR_ACTION = 16;
				/// <java-name>
				/// FLAG_CANCELED
				/// </java-name>
				[Dot42.DexImport("FLAG_CANCELED", "I", AccessFlags = 25)]
				public const int FLAG_CANCELED = 32;
				/// <java-name>
				/// FLAG_VIRTUAL_HARD_KEY
				/// </java-name>
				[Dot42.DexImport("FLAG_VIRTUAL_HARD_KEY", "I", AccessFlags = 25)]
				public const int FLAG_VIRTUAL_HARD_KEY = 64;
				/// <java-name>
				/// FLAG_LONG_PRESS
				/// </java-name>
				[Dot42.DexImport("FLAG_LONG_PRESS", "I", AccessFlags = 25)]
				public const int FLAG_LONG_PRESS = 128;
				/// <java-name>
				/// FLAG_CANCELED_LONG_PRESS
				/// </java-name>
				[Dot42.DexImport("FLAG_CANCELED_LONG_PRESS", "I", AccessFlags = 25)]
				public const int FLAG_CANCELED_LONG_PRESS = 256;
				/// <java-name>
				/// FLAG_TRACKING
				/// </java-name>
				[Dot42.DexImport("FLAG_TRACKING", "I", AccessFlags = 25)]
				public const int FLAG_TRACKING = 512;
				/// <java-name>
				/// FLAG_FALLBACK
				/// </java-name>
				[Dot42.DexImport("FLAG_FALLBACK", "I", AccessFlags = 25)]
				public const int FLAG_FALLBACK = 1024;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.KeyEvent> CREATOR;
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public KeyEvent(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JJIII)V", AccessFlags = 1)]
				public KeyEvent(long int64, long int641, int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JJIIII)V", AccessFlags = 1)]
				public KeyEvent(long int64, long int641, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JJIIIIII)V", AccessFlags = 1)]
				public KeyEvent(long int64, long int641, int int32, int int321, int int322, int int323, int int324, int int325) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JJIIIIIII)V", AccessFlags = 1)]
				public KeyEvent(long int64, long int641, int int32, int int321, int int322, int int323, int int324, int int325, int int326) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JJIIIIIIII)V", AccessFlags = 1)]
				public KeyEvent(long int64, long int641, int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(JLjava/lang/String;II)V", AccessFlags = 1)]
				public KeyEvent(long int64, string @string, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/KeyEvent;)V", AccessFlags = 1)]
				public KeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/KeyEvent;JI)V", AccessFlags = 1)]
				public KeyEvent(global::Android.Views.KeyEvent keyEvent, long int64, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDeadChar
				/// </java-name>
				[Dot42.DexImport("getDeadChar", "(II)I", AccessFlags = 9)]
				public static int GetDeadChar(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// changeTimeRepeat
				/// </java-name>
				[Dot42.DexImport("changeTimeRepeat", "(Landroid/view/KeyEvent;JI)Landroid/view/KeyEvent;", AccessFlags = 9)]
				public static global::Android.Views.KeyEvent ChangeTimeRepeat(global::Android.Views.KeyEvent keyEvent, long int64, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent);
				}

				/// <java-name>
				/// changeTimeRepeat
				/// </java-name>
				[Dot42.DexImport("changeTimeRepeat", "(Landroid/view/KeyEvent;JII)Landroid/view/KeyEvent;", AccessFlags = 9)]
				public static global::Android.Views.KeyEvent ChangeTimeRepeat(global::Android.Views.KeyEvent keyEvent, long int64, int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent);
				}

				/// <java-name>
				/// changeAction
				/// </java-name>
				[Dot42.DexImport("changeAction", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;", AccessFlags = 9)]
				public static global::Android.Views.KeyEvent ChangeAction(global::Android.Views.KeyEvent keyEvent, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent);
				}

				/// <java-name>
				/// changeFlags
				/// </java-name>
				[Dot42.DexImport("changeFlags", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;", AccessFlags = 9)]
				public static global::Android.Views.KeyEvent ChangeFlags(global::Android.Views.KeyEvent keyEvent, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent);
				}

				/// <java-name>
				/// isGamepadButton
				/// </java-name>
				[Dot42.DexImport("isGamepadButton", "(I)Z", AccessFlags = 25)]
				public static bool IsGamepadButton(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(I)V", AccessFlags = 17)]
				public void SetSource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isModifierKey
				/// </java-name>
				[Dot42.DexImport("isModifierKey", "(I)Z", AccessFlags = 9)]
				public static bool IsModifierKey(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// normalizeMetaState
				/// </java-name>
				[Dot42.DexImport("normalizeMetaState", "(I)I", AccessFlags = 9)]
				public static int NormalizeMetaState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// metaStateHasNoModifiers
				/// </java-name>
				[Dot42.DexImport("metaStateHasNoModifiers", "(I)Z", AccessFlags = 9)]
				public static bool MetaStateHasNoModifiers(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// metaStateHasModifiers
				/// </java-name>
				[Dot42.DexImport("metaStateHasModifiers", "(II)Z", AccessFlags = 9)]
				public static bool MetaStateHasModifiers(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hasModifiers
				/// </java-name>
				[Dot42.DexImport("hasModifiers", "(I)Z", AccessFlags = 17)]
				public bool HasModifiers(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startTracking
				/// </java-name>
				[Dot42.DexImport("startTracking", "()V", AccessFlags = 17)]
				public void StartTracking() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getUnicodeChar
				/// </java-name>
				[Dot42.DexImport("getUnicodeChar", "(I)I", AccessFlags = 1)]
				public virtual int GetUnicodeChar(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getKeyData
				/// </java-name>
				[Dot42.DexImport("getKeyData", "(Landroid/view/KeyCharacterMap$KeyData;)Z", AccessFlags = 1)]
				public virtual bool GetKeyData(global::Android.Views.KeyCharacterMap.KeyData keyData) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getMatch
				/// </java-name>
				[Dot42.DexImport("getMatch", "([C)C", AccessFlags = 1)]
				public virtual char GetMatch(char[] @char) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// getMatch
				/// </java-name>
				[Dot42.DexImport("getMatch", "([CI)C", AccessFlags = 1)]
				public virtual char GetMatch(char[] @char, int int32) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <java-name>
				/// dispatch
				/// </java-name>
				[Dot42.DexImport("dispatch", "(Landroid/view/KeyEvent$Callback;)Z", AccessFlags = 17)]
				public bool Dispatch(global::Android.Views.KeyEvent.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatch
				/// </java-name>
				[Dot42.DexImport("dispatch", "(Landroid/view/KeyEvent$Callback;Landroid/view/KeyEvent$DispatcherState;Ljava/lan" +
    "g/Object;)Z", AccessFlags = 17)]
				public bool Dispatch(global::Android.Views.KeyEvent.ICallback callback, global::Android.Views.KeyEvent.DispatcherState dispatcherState, object @object) /* MethodBuilder.Create */ 
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
				/// keyCodeToString
				/// </java-name>
				[Dot42.DexImport("keyCodeToString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string KeyCodeToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// keyCodeFromString
				/// </java-name>
				[Dot42.DexImport("keyCodeFromString", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int KeyCodeFromString(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal KeyEvent() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("android/os/Parcelable", "describeContents", "()I", AccessFlags = 1025)]
				public override int DescribeContents() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getMaxKeyCode
				/// </java-name>
				public static int MaxKeyCode
				{
						[Dot42.DexImport("getMaxKeyCode", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isSystem
				/// </java-name>
				public bool IsSystem
				{
						[Dot42.DexImport("isSystem", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDeviceId
				/// </java-name>
				public override int DeviceId
				{
						[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSource
				/// </java-name>
				public override int Source
				{
						[Dot42.DexImport("getSource", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMetaState
				/// </java-name>
				public int MetaState
				{
						[Dot42.DexImport("getMetaState", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getModifiers
				/// </java-name>
				public int Modifiers
				{
						[Dot42.DexImport("getModifiers", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				public int Flags
				{
						[Dot42.DexImport("getFlags", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getModifierMetaStateMask
				/// </java-name>
				public static int ModifierMetaStateMask
				{
						[Dot42.DexImport("getModifierMetaStateMask", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// hasNoModifiers
				/// </java-name>
				public bool HasNoModifiers
				{
						[Dot42.DexImport("hasNoModifiers", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isAltPressed
				/// </java-name>
				public bool IsAltPressed
				{
						[Dot42.DexImport("isAltPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isShiftPressed
				/// </java-name>
				public bool IsShiftPressed
				{
						[Dot42.DexImport("isShiftPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isSymPressed
				/// </java-name>
				public bool IsSymPressed
				{
						[Dot42.DexImport("isSymPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isCtrlPressed
				/// </java-name>
				public bool IsCtrlPressed
				{
						[Dot42.DexImport("isCtrlPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMetaPressed
				/// </java-name>
				public bool IsMetaPressed
				{
						[Dot42.DexImport("isMetaPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isFunctionPressed
				/// </java-name>
				public bool IsFunctionPressed
				{
						[Dot42.DexImport("isFunctionPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isCapsLockOn
				/// </java-name>
				public bool IsCapsLockOn
				{
						[Dot42.DexImport("isCapsLockOn", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isNumLockOn
				/// </java-name>
				public bool IsNumLockOn
				{
						[Dot42.DexImport("isNumLockOn", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isScrollLockOn
				/// </java-name>
				public bool IsScrollLockOn
				{
						[Dot42.DexImport("isScrollLockOn", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getAction
				/// </java-name>
				public int Action
				{
						[Dot42.DexImport("getAction", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isCanceled
				/// </java-name>
				public bool IsCanceled
				{
						[Dot42.DexImport("isCanceled", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isTracking
				/// </java-name>
				public bool IsTracking
				{
						[Dot42.DexImport("isTracking", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isLongPress
				/// </java-name>
				public bool IsLongPress
				{
						[Dot42.DexImport("isLongPress", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getKeyCode
				/// </java-name>
				public int KeyCode
				{
						[Dot42.DexImport("getKeyCode", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getCharacters
				/// </java-name>
				public string Characters
				{
						[Dot42.DexImport("getCharacters", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getScanCode
				/// </java-name>
				public int ScanCode
				{
						[Dot42.DexImport("getScanCode", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRepeatCount
				/// </java-name>
				public int RepeatCount
				{
						[Dot42.DexImport("getRepeatCount", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDownTime
				/// </java-name>
				public long DownTime
				{
						[Dot42.DexImport("getDownTime", "()J", AccessFlags = 17)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getEventTime
				/// </java-name>
				public long EventTime
				{
						[Dot42.DexImport("getEventTime", "()J", AccessFlags = 17)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getKeyCharacterMap
				/// </java-name>
				public global::Android.Views.KeyCharacterMap KeyCharacterMap
				{
						[Dot42.DexImport("getKeyCharacterMap", "()Landroid/view/KeyCharacterMap;", AccessFlags = 17)]
						get{ return default(global::Android.Views.KeyCharacterMap); }
				}

				/// <java-name>
				/// getDisplayLabel
				/// </java-name>
				public virtual char DisplayLabel
				{
						[Dot42.DexImport("getDisplayLabel", "()C", AccessFlags = 1)]
						get{ return default(char); }
				}

				/// <java-name>
				/// getUnicodeChar
				/// </java-name>
				public virtual int UnicodeChar
				{
						[Dot42.DexImport("getUnicodeChar", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getNumber
				/// </java-name>
				public virtual char Number
				{
						[Dot42.DexImport("getNumber", "()C", AccessFlags = 1)]
						get{ return default(char); }
				}

				/// <java-name>
				/// isPrintingKey
				/// </java-name>
				public virtual bool IsPrintingKey
				{
						[Dot42.DexImport("isPrintingKey", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/view/KeyEvent$DispatcherState
				/// </java-name>
				[Dot42.DexImport("android/view/KeyEvent$DispatcherState", AccessFlags = 9)]
				public partial class DispatcherState
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public DispatcherState() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// reset
						/// </java-name>
						[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
						public virtual void Reset() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// reset
						/// </java-name>
						[Dot42.DexImport("reset", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						public virtual void Reset(object @object) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// startTracking
						/// </java-name>
						[Dot42.DexImport("startTracking", "(Landroid/view/KeyEvent;Ljava/lang/Object;)V", AccessFlags = 1)]
						public virtual void StartTracking(global::Android.Views.KeyEvent keyEvent, object @object) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// isTracking
						/// </java-name>
						[Dot42.DexImport("isTracking", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
						public virtual bool IsTracking(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// performedLongPress
						/// </java-name>
						[Dot42.DexImport("performedLongPress", "(Landroid/view/KeyEvent;)V", AccessFlags = 1)]
						public virtual void PerformedLongPress(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// handleUpEvent
						/// </java-name>
						[Dot42.DexImport("handleUpEvent", "(Landroid/view/KeyEvent;)V", AccessFlags = 1)]
						public virtual void HandleUpEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/view/KeyEvent$Callback
				/// </java-name>
				[Dot42.DexImport("android/view/KeyEvent$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onKeyDown
						/// </java-name>
						[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKeyDown(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onKeyLongPress
						/// </java-name>
						[Dot42.DexImport("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKeyLongPress(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onKeyUp
						/// </java-name>
						[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKeyUp(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onKeyMultiple
						/// </java-name>
						[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKeyMultiple(int int32, int int321, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/LayoutInflater
		/// </java-name>
		[Dot42.DexImport("android/view/LayoutInflater", AccessFlags = 1057)]
		public abstract partial class LayoutInflater
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal LayoutInflater(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/LayoutInflater;Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal LayoutInflater(global::Android.Views.LayoutInflater layoutInflater, global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// from
				/// </java-name>
				[Dot42.DexImport("from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;", AccessFlags = 9)]
				public static global::Android.Views.LayoutInflater From(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.LayoutInflater);
				}

				/// <java-name>
				/// cloneInContext
				/// </java-name>
				[Dot42.DexImport("cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;", AccessFlags = 1025)]
				public abstract global::Android.Views.LayoutInflater CloneInContext(global::Android.Content.Context context) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(ILandroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View Inflate(int int32, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View Inflate(global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(ILandroid/view/ViewGroup;Z)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View Inflate(int int32, global::Android.Views.ViewGroup viewGroup, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;Z)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View Inflate(global::Org.Xmlpull.V1.IXmlPullParser xmlPullParser, global::Android.Views.ViewGroup viewGroup, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// createView
				/// </java-name>
				[Dot42.DexImport("createView", "(Ljava/lang/String;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/Vi" +
    "ew;", AccessFlags = 17)]
				public global::Android.Views.View CreateView(string @string, string string1, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View OnCreateView(string @string, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/view/View;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/V" +
    "iew;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View OnCreateView(global::Android.Views.View view, string @string, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LayoutInflater() /* TypeBuilder.AddDefaultConstructor */ 
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
				/// getFactory
				/// </java-name>
				public virtual global::Android.Views.LayoutInflater.IFactory Factory
				{
						[Dot42.DexImport("getFactory", "()Landroid/view/LayoutInflater$Factory;", AccessFlags = 17)]
						get{ return default(global::Android.Views.LayoutInflater.IFactory); }
						[Dot42.DexImport("setFactory", "(Landroid/view/LayoutInflater$Factory;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFactory2
				/// </java-name>
				public virtual global::Android.Views.LayoutInflater.IFactory2 Factory2
				{
						[Dot42.DexImport("getFactory2", "()Landroid/view/LayoutInflater$Factory2;", AccessFlags = 17)]
						get{ return default(global::Android.Views.LayoutInflater.IFactory2); }
						[Dot42.DexImport("setFactory2", "(Landroid/view/LayoutInflater$Factory2;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFilter
				/// </java-name>
				public virtual global::Android.Views.LayoutInflater.IFilter Filter
				{
						[Dot42.DexImport("getFilter", "()Landroid/view/LayoutInflater$Filter;", AccessFlags = 1)]
						get{ return default(global::Android.Views.LayoutInflater.IFilter); }
						[Dot42.DexImport("setFilter", "(Landroid/view/LayoutInflater$Filter;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/view/LayoutInflater$Factory2
				/// </java-name>
				[Dot42.DexImport("android/view/LayoutInflater$Factory2", AccessFlags = 1545)]
				public partial interface IFactory2 : global::Android.Views.LayoutInflater.IFactory
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCreateView
						/// </java-name>
						[Dot42.DexImport("onCreateView", "(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/Attr" +
    "ibuteSet;)Landroid/view/View;", AccessFlags = 1025)]
						global::Android.Views.View OnCreateView(global::Android.Views.View view, string @string, global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/LayoutInflater$Factory
				/// </java-name>
				[Dot42.DexImport("android/view/LayoutInflater$Factory", AccessFlags = 1545)]
				public partial interface IFactory
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCreateView
						/// </java-name>
						[Dot42.DexImport("onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/" +
    "view/View;", AccessFlags = 1025)]
						global::Android.Views.View OnCreateView(string @string, global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/LayoutInflater$Filter
				/// </java-name>
				[Dot42.DexImport("android/view/LayoutInflater$Filter", AccessFlags = 1545)]
				public partial interface IFilter
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onLoadClass
						/// </java-name>
						[Dot42.DexImport("onLoadClass", "(Ljava/lang/Class;)Z", AccessFlags = 1025)]
						bool OnLoadClass(global::System.Type type) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/MenuInflater
		/// </java-name>
		[Dot42.DexImport("android/view/MenuInflater", AccessFlags = 33)]
		public partial class MenuInflater
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MenuInflater(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(ILandroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void Inflate(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MenuInflater() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/view/MotionEvent
		/// </java-name>
		[Dot42.DexImport("android/view/MotionEvent", AccessFlags = 49)]
		public sealed partial class MotionEvent : global::Android.Views.InputEvent, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// INVALID_POINTER_ID
				/// </java-name>
				[Dot42.DexImport("INVALID_POINTER_ID", "I", AccessFlags = 25)]
				public const int INVALID_POINTER_ID = -1;
				/// <java-name>
				/// ACTION_MASK
				/// </java-name>
				[Dot42.DexImport("ACTION_MASK", "I", AccessFlags = 25)]
				public const int ACTION_MASK = 255;
				/// <java-name>
				/// ACTION_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_DOWN = 0;
				/// <java-name>
				/// ACTION_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_UP", "I", AccessFlags = 25)]
				public const int ACTION_UP = 1;
				/// <java-name>
				/// ACTION_MOVE
				/// </java-name>
				[Dot42.DexImport("ACTION_MOVE", "I", AccessFlags = 25)]
				public const int ACTION_MOVE = 2;
				/// <java-name>
				/// ACTION_CANCEL
				/// </java-name>
				[Dot42.DexImport("ACTION_CANCEL", "I", AccessFlags = 25)]
				public const int ACTION_CANCEL = 3;
				/// <java-name>
				/// ACTION_OUTSIDE
				/// </java-name>
				[Dot42.DexImport("ACTION_OUTSIDE", "I", AccessFlags = 25)]
				public const int ACTION_OUTSIDE = 4;
				/// <java-name>
				/// ACTION_POINTER_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_DOWN = 5;
				/// <java-name>
				/// ACTION_POINTER_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_UP", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_UP = 6;
				/// <java-name>
				/// ACTION_HOVER_MOVE
				/// </java-name>
				[Dot42.DexImport("ACTION_HOVER_MOVE", "I", AccessFlags = 25)]
				public const int ACTION_HOVER_MOVE = 7;
				/// <java-name>
				/// ACTION_SCROLL
				/// </java-name>
				[Dot42.DexImport("ACTION_SCROLL", "I", AccessFlags = 25)]
				public const int ACTION_SCROLL = 8;
				/// <java-name>
				/// ACTION_HOVER_ENTER
				/// </java-name>
				[Dot42.DexImport("ACTION_HOVER_ENTER", "I", AccessFlags = 25)]
				public const int ACTION_HOVER_ENTER = 9;
				/// <java-name>
				/// ACTION_HOVER_EXIT
				/// </java-name>
				[Dot42.DexImport("ACTION_HOVER_EXIT", "I", AccessFlags = 25)]
				public const int ACTION_HOVER_EXIT = 10;
				/// <java-name>
				/// ACTION_POINTER_INDEX_MASK
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_INDEX_MASK", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_INDEX_MASK = 65280;
				/// <java-name>
				/// ACTION_POINTER_INDEX_SHIFT
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_INDEX_SHIFT", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_INDEX_SHIFT = 8;
				/// <java-name>
				/// ACTION_POINTER_1_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_1_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_1_DOWN = 5;
				/// <java-name>
				/// ACTION_POINTER_2_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_2_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_2_DOWN = 261;
				/// <java-name>
				/// ACTION_POINTER_3_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_3_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_3_DOWN = 517;
				/// <java-name>
				/// ACTION_POINTER_1_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_1_UP", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_1_UP = 6;
				/// <java-name>
				/// ACTION_POINTER_2_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_2_UP", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_2_UP = 262;
				/// <java-name>
				/// ACTION_POINTER_3_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_3_UP", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_3_UP = 518;
				/// <java-name>
				/// ACTION_POINTER_ID_MASK
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_ID_MASK", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_ID_MASK = 65280;
				/// <java-name>
				/// ACTION_POINTER_ID_SHIFT
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_ID_SHIFT", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_ID_SHIFT = 8;
				/// <java-name>
				/// FLAG_WINDOW_IS_OBSCURED
				/// </java-name>
				[Dot42.DexImport("FLAG_WINDOW_IS_OBSCURED", "I", AccessFlags = 25)]
				public const int FLAG_WINDOW_IS_OBSCURED = 1;
				/// <java-name>
				/// EDGE_TOP
				/// </java-name>
				[Dot42.DexImport("EDGE_TOP", "I", AccessFlags = 25)]
				public const int EDGE_TOP = 1;
				/// <java-name>
				/// EDGE_BOTTOM
				/// </java-name>
				[Dot42.DexImport("EDGE_BOTTOM", "I", AccessFlags = 25)]
				public const int EDGE_BOTTOM = 2;
				/// <java-name>
				/// EDGE_LEFT
				/// </java-name>
				[Dot42.DexImport("EDGE_LEFT", "I", AccessFlags = 25)]
				public const int EDGE_LEFT = 4;
				/// <java-name>
				/// EDGE_RIGHT
				/// </java-name>
				[Dot42.DexImport("EDGE_RIGHT", "I", AccessFlags = 25)]
				public const int EDGE_RIGHT = 8;
				/// <java-name>
				/// AXIS_X
				/// </java-name>
				[Dot42.DexImport("AXIS_X", "I", AccessFlags = 25)]
				public const int AXIS_X = 0;
				/// <java-name>
				/// AXIS_Y
				/// </java-name>
				[Dot42.DexImport("AXIS_Y", "I", AccessFlags = 25)]
				public const int AXIS_Y = 1;
				/// <java-name>
				/// AXIS_PRESSURE
				/// </java-name>
				[Dot42.DexImport("AXIS_PRESSURE", "I", AccessFlags = 25)]
				public const int AXIS_PRESSURE = 2;
				/// <java-name>
				/// AXIS_SIZE
				/// </java-name>
				[Dot42.DexImport("AXIS_SIZE", "I", AccessFlags = 25)]
				public const int AXIS_SIZE = 3;
				/// <java-name>
				/// AXIS_TOUCH_MAJOR
				/// </java-name>
				[Dot42.DexImport("AXIS_TOUCH_MAJOR", "I", AccessFlags = 25)]
				public const int AXIS_TOUCH_MAJOR = 4;
				/// <java-name>
				/// AXIS_TOUCH_MINOR
				/// </java-name>
				[Dot42.DexImport("AXIS_TOUCH_MINOR", "I", AccessFlags = 25)]
				public const int AXIS_TOUCH_MINOR = 5;
				/// <java-name>
				/// AXIS_TOOL_MAJOR
				/// </java-name>
				[Dot42.DexImport("AXIS_TOOL_MAJOR", "I", AccessFlags = 25)]
				public const int AXIS_TOOL_MAJOR = 6;
				/// <java-name>
				/// AXIS_TOOL_MINOR
				/// </java-name>
				[Dot42.DexImport("AXIS_TOOL_MINOR", "I", AccessFlags = 25)]
				public const int AXIS_TOOL_MINOR = 7;
				/// <java-name>
				/// AXIS_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("AXIS_ORIENTATION", "I", AccessFlags = 25)]
				public const int AXIS_ORIENTATION = 8;
				/// <java-name>
				/// AXIS_VSCROLL
				/// </java-name>
				[Dot42.DexImport("AXIS_VSCROLL", "I", AccessFlags = 25)]
				public const int AXIS_VSCROLL = 9;
				/// <java-name>
				/// AXIS_HSCROLL
				/// </java-name>
				[Dot42.DexImport("AXIS_HSCROLL", "I", AccessFlags = 25)]
				public const int AXIS_HSCROLL = 10;
				/// <java-name>
				/// AXIS_Z
				/// </java-name>
				[Dot42.DexImport("AXIS_Z", "I", AccessFlags = 25)]
				public const int AXIS_Z = 11;
				/// <java-name>
				/// AXIS_RX
				/// </java-name>
				[Dot42.DexImport("AXIS_RX", "I", AccessFlags = 25)]
				public const int AXIS_RX = 12;
				/// <java-name>
				/// AXIS_RY
				/// </java-name>
				[Dot42.DexImport("AXIS_RY", "I", AccessFlags = 25)]
				public const int AXIS_RY = 13;
				/// <java-name>
				/// AXIS_RZ
				/// </java-name>
				[Dot42.DexImport("AXIS_RZ", "I", AccessFlags = 25)]
				public const int AXIS_RZ = 14;
				/// <java-name>
				/// AXIS_HAT_X
				/// </java-name>
				[Dot42.DexImport("AXIS_HAT_X", "I", AccessFlags = 25)]
				public const int AXIS_HAT_X = 15;
				/// <java-name>
				/// AXIS_HAT_Y
				/// </java-name>
				[Dot42.DexImport("AXIS_HAT_Y", "I", AccessFlags = 25)]
				public const int AXIS_HAT_Y = 16;
				/// <java-name>
				/// AXIS_LTRIGGER
				/// </java-name>
				[Dot42.DexImport("AXIS_LTRIGGER", "I", AccessFlags = 25)]
				public const int AXIS_LTRIGGER = 17;
				/// <java-name>
				/// AXIS_RTRIGGER
				/// </java-name>
				[Dot42.DexImport("AXIS_RTRIGGER", "I", AccessFlags = 25)]
				public const int AXIS_RTRIGGER = 18;
				/// <java-name>
				/// AXIS_THROTTLE
				/// </java-name>
				[Dot42.DexImport("AXIS_THROTTLE", "I", AccessFlags = 25)]
				public const int AXIS_THROTTLE = 19;
				/// <java-name>
				/// AXIS_RUDDER
				/// </java-name>
				[Dot42.DexImport("AXIS_RUDDER", "I", AccessFlags = 25)]
				public const int AXIS_RUDDER = 20;
				/// <java-name>
				/// AXIS_WHEEL
				/// </java-name>
				[Dot42.DexImport("AXIS_WHEEL", "I", AccessFlags = 25)]
				public const int AXIS_WHEEL = 21;
				/// <java-name>
				/// AXIS_GAS
				/// </java-name>
				[Dot42.DexImport("AXIS_GAS", "I", AccessFlags = 25)]
				public const int AXIS_GAS = 22;
				/// <java-name>
				/// AXIS_BRAKE
				/// </java-name>
				[Dot42.DexImport("AXIS_BRAKE", "I", AccessFlags = 25)]
				public const int AXIS_BRAKE = 23;
				/// <java-name>
				/// AXIS_DISTANCE
				/// </java-name>
				[Dot42.DexImport("AXIS_DISTANCE", "I", AccessFlags = 25)]
				public const int AXIS_DISTANCE = 24;
				/// <java-name>
				/// AXIS_TILT
				/// </java-name>
				[Dot42.DexImport("AXIS_TILT", "I", AccessFlags = 25)]
				public const int AXIS_TILT = 25;
				/// <java-name>
				/// AXIS_GENERIC_1
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_1", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_1 = 32;
				/// <java-name>
				/// AXIS_GENERIC_2
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_2", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_2 = 33;
				/// <java-name>
				/// AXIS_GENERIC_3
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_3", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_3 = 34;
				/// <java-name>
				/// AXIS_GENERIC_4
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_4", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_4 = 35;
				/// <java-name>
				/// AXIS_GENERIC_5
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_5", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_5 = 36;
				/// <java-name>
				/// AXIS_GENERIC_6
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_6", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_6 = 37;
				/// <java-name>
				/// AXIS_GENERIC_7
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_7", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_7 = 38;
				/// <java-name>
				/// AXIS_GENERIC_8
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_8", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_8 = 39;
				/// <java-name>
				/// AXIS_GENERIC_9
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_9", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_9 = 40;
				/// <java-name>
				/// AXIS_GENERIC_10
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_10", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_10 = 41;
				/// <java-name>
				/// AXIS_GENERIC_11
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_11", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_11 = 42;
				/// <java-name>
				/// AXIS_GENERIC_12
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_12", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_12 = 43;
				/// <java-name>
				/// AXIS_GENERIC_13
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_13", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_13 = 44;
				/// <java-name>
				/// AXIS_GENERIC_14
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_14", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_14 = 45;
				/// <java-name>
				/// AXIS_GENERIC_15
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_15", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_15 = 46;
				/// <java-name>
				/// AXIS_GENERIC_16
				/// </java-name>
				[Dot42.DexImport("AXIS_GENERIC_16", "I", AccessFlags = 25)]
				public const int AXIS_GENERIC_16 = 47;
				/// <java-name>
				/// BUTTON_PRIMARY
				/// </java-name>
				[Dot42.DexImport("BUTTON_PRIMARY", "I", AccessFlags = 25)]
				public const int BUTTON_PRIMARY = 1;
				/// <java-name>
				/// BUTTON_SECONDARY
				/// </java-name>
				[Dot42.DexImport("BUTTON_SECONDARY", "I", AccessFlags = 25)]
				public const int BUTTON_SECONDARY = 2;
				/// <java-name>
				/// BUTTON_TERTIARY
				/// </java-name>
				[Dot42.DexImport("BUTTON_TERTIARY", "I", AccessFlags = 25)]
				public const int BUTTON_TERTIARY = 4;
				/// <java-name>
				/// BUTTON_BACK
				/// </java-name>
				[Dot42.DexImport("BUTTON_BACK", "I", AccessFlags = 25)]
				public const int BUTTON_BACK = 8;
				/// <java-name>
				/// BUTTON_FORWARD
				/// </java-name>
				[Dot42.DexImport("BUTTON_FORWARD", "I", AccessFlags = 25)]
				public const int BUTTON_FORWARD = 16;
				/// <java-name>
				/// TOOL_TYPE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("TOOL_TYPE_UNKNOWN", "I", AccessFlags = 25)]
				public const int TOOL_TYPE_UNKNOWN = 0;
				/// <java-name>
				/// TOOL_TYPE_FINGER
				/// </java-name>
				[Dot42.DexImport("TOOL_TYPE_FINGER", "I", AccessFlags = 25)]
				public const int TOOL_TYPE_FINGER = 1;
				/// <java-name>
				/// TOOL_TYPE_STYLUS
				/// </java-name>
				[Dot42.DexImport("TOOL_TYPE_STYLUS", "I", AccessFlags = 25)]
				public const int TOOL_TYPE_STYLUS = 2;
				/// <java-name>
				/// TOOL_TYPE_MOUSE
				/// </java-name>
				[Dot42.DexImport("TOOL_TYPE_MOUSE", "I", AccessFlags = 25)]
				public const int TOOL_TYPE_MOUSE = 3;
				/// <java-name>
				/// TOOL_TYPE_ERASER
				/// </java-name>
				[Dot42.DexImport("TOOL_TYPE_ERASER", "I", AccessFlags = 25)]
				public const int TOOL_TYPE_ERASER = 4;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.MotionEvent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal MotionEvent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~MotionEvent() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(JJII[Landroid/view/MotionEvent$PointerProperties;[Landroid/view/MotionEvent$Poin" +
    "terCoords;IIFFIIII)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(long int64, long int641, int int32, int int321, global::Android.Views.MotionEvent.PointerProperties[] pointerProperties, global::Android.Views.MotionEvent.PointerCoords[] pointerCoords, int int322, int int323, float single, float single1, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(JJII[I[Landroid/view/MotionEvent$PointerCoords;IFFIIII)Landroid/view/MotionEvent" +
    ";", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(long int64, long int641, int int32, int int321, int[] int322, global::Android.Views.MotionEvent.PointerCoords[] pointerCoords, int int323, float single, float single1, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(long int64, long int641, int int32, float single, float single1, float single2, float single3, int int321, float single4, float single5, int int322, int int323) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(JJIIFFFFIFFII)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(long int64, long int641, int int32, int int321, float single, float single1, float single2, float single3, int int322, float single4, float single5, int int323, int int324) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(JJIFFI)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(long int64, long int641, int int32, float single, float single1, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <java-name>
				/// obtainNoHistory
				/// </java-name>
				[Dot42.DexImport("obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent ObtainNoHistory(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 17)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(I)V", AccessFlags = 17)]
				public void SetSource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAxisValue
				/// </java-name>
				[Dot42.DexImport("getAxisValue", "(I)F", AccessFlags = 17)]
				public float GetAxisValue(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getPointerId
				/// </java-name>
				[Dot42.DexImport("getPointerId", "(I)I", AccessFlags = 17)]
				public int GetPointerId(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getToolType
				/// </java-name>
				[Dot42.DexImport("getToolType", "(I)I", AccessFlags = 17)]
				public int GetToolType(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// findPointerIndex
				/// </java-name>
				[Dot42.DexImport("findPointerIndex", "(I)I", AccessFlags = 17)]
				public int FindPointerIndex(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "(I)F", AccessFlags = 17)]
				public float GetX(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "(I)F", AccessFlags = 17)]
				public float GetY(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getPressure
				/// </java-name>
				[Dot42.DexImport("getPressure", "(I)F", AccessFlags = 17)]
				public float GetPressure(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "(I)F", AccessFlags = 17)]
				public float GetSize(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getTouchMajor
				/// </java-name>
				[Dot42.DexImport("getTouchMajor", "(I)F", AccessFlags = 17)]
				public float GetTouchMajor(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getTouchMinor
				/// </java-name>
				[Dot42.DexImport("getTouchMinor", "(I)F", AccessFlags = 17)]
				public float GetTouchMinor(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getToolMajor
				/// </java-name>
				[Dot42.DexImport("getToolMajor", "(I)F", AccessFlags = 17)]
				public float GetToolMajor(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getToolMinor
				/// </java-name>
				[Dot42.DexImport("getToolMinor", "(I)F", AccessFlags = 17)]
				public float GetToolMinor(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getOrientation
				/// </java-name>
				[Dot42.DexImport("getOrientation", "(I)F", AccessFlags = 17)]
				public float GetOrientation(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getAxisValue
				/// </java-name>
				[Dot42.DexImport("getAxisValue", "(II)F", AccessFlags = 17)]
				public float GetAxisValue(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getPointerCoords
				/// </java-name>
				[Dot42.DexImport("getPointerCoords", "(ILandroid/view/MotionEvent$PointerCoords;)V", AccessFlags = 17)]
				public void GetPointerCoords(int int32, global::Android.Views.MotionEvent.PointerCoords pointerCoords) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getPointerProperties
				/// </java-name>
				[Dot42.DexImport("getPointerProperties", "(ILandroid/view/MotionEvent$PointerProperties;)V", AccessFlags = 17)]
				public void GetPointerProperties(int int32, global::Android.Views.MotionEvent.PointerProperties pointerProperties) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHistoricalEventTime
				/// </java-name>
				[Dot42.DexImport("getHistoricalEventTime", "(I)J", AccessFlags = 17)]
				public long GetHistoricalEventTime(int int32) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <java-name>
				/// getHistoricalX
				/// </java-name>
				[Dot42.DexImport("getHistoricalX", "(I)F", AccessFlags = 17)]
				public float GetHistoricalX(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalY
				/// </java-name>
				[Dot42.DexImport("getHistoricalY", "(I)F", AccessFlags = 17)]
				public float GetHistoricalY(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalPressure
				/// </java-name>
				[Dot42.DexImport("getHistoricalPressure", "(I)F", AccessFlags = 17)]
				public float GetHistoricalPressure(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalSize
				/// </java-name>
				[Dot42.DexImport("getHistoricalSize", "(I)F", AccessFlags = 17)]
				public float GetHistoricalSize(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalTouchMajor
				/// </java-name>
				[Dot42.DexImport("getHistoricalTouchMajor", "(I)F", AccessFlags = 17)]
				public float GetHistoricalTouchMajor(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalTouchMinor
				/// </java-name>
				[Dot42.DexImport("getHistoricalTouchMinor", "(I)F", AccessFlags = 17)]
				public float GetHistoricalTouchMinor(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalToolMajor
				/// </java-name>
				[Dot42.DexImport("getHistoricalToolMajor", "(I)F", AccessFlags = 17)]
				public float GetHistoricalToolMajor(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalToolMinor
				/// </java-name>
				[Dot42.DexImport("getHistoricalToolMinor", "(I)F", AccessFlags = 17)]
				public float GetHistoricalToolMinor(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalOrientation
				/// </java-name>
				[Dot42.DexImport("getHistoricalOrientation", "(I)F", AccessFlags = 17)]
				public float GetHistoricalOrientation(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalAxisValue
				/// </java-name>
				[Dot42.DexImport("getHistoricalAxisValue", "(II)F", AccessFlags = 17)]
				public float GetHistoricalAxisValue(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalX
				/// </java-name>
				[Dot42.DexImport("getHistoricalX", "(II)F", AccessFlags = 17)]
				public float GetHistoricalX(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalY
				/// </java-name>
				[Dot42.DexImport("getHistoricalY", "(II)F", AccessFlags = 17)]
				public float GetHistoricalY(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalPressure
				/// </java-name>
				[Dot42.DexImport("getHistoricalPressure", "(II)F", AccessFlags = 17)]
				public float GetHistoricalPressure(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalSize
				/// </java-name>
				[Dot42.DexImport("getHistoricalSize", "(II)F", AccessFlags = 17)]
				public float GetHistoricalSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalTouchMajor
				/// </java-name>
				[Dot42.DexImport("getHistoricalTouchMajor", "(II)F", AccessFlags = 17)]
				public float GetHistoricalTouchMajor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalTouchMinor
				/// </java-name>
				[Dot42.DexImport("getHistoricalTouchMinor", "(II)F", AccessFlags = 17)]
				public float GetHistoricalTouchMinor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalToolMajor
				/// </java-name>
				[Dot42.DexImport("getHistoricalToolMajor", "(II)F", AccessFlags = 17)]
				public float GetHistoricalToolMajor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalToolMinor
				/// </java-name>
				[Dot42.DexImport("getHistoricalToolMinor", "(II)F", AccessFlags = 17)]
				public float GetHistoricalToolMinor(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalOrientation
				/// </java-name>
				[Dot42.DexImport("getHistoricalOrientation", "(II)F", AccessFlags = 17)]
				public float GetHistoricalOrientation(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalAxisValue
				/// </java-name>
				[Dot42.DexImport("getHistoricalAxisValue", "(III)F", AccessFlags = 17)]
				public float GetHistoricalAxisValue(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getHistoricalPointerCoords
				/// </java-name>
				[Dot42.DexImport("getHistoricalPointerCoords", "(IILandroid/view/MotionEvent$PointerCoords;)V", AccessFlags = 17)]
				public void GetHistoricalPointerCoords(int int32, int int321, global::Android.Views.MotionEvent.PointerCoords pointerCoords) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offsetLocation
				/// </java-name>
				[Dot42.DexImport("offsetLocation", "(FF)V", AccessFlags = 17)]
				public void OffsetLocation(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLocation
				/// </java-name>
				[Dot42.DexImport("setLocation", "(FF)V", AccessFlags = 17)]
				public void SetLocation(float single, float single1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// transform
				/// </java-name>
				[Dot42.DexImport("transform", "(Landroid/graphics/Matrix;)V", AccessFlags = 17)]
				public void Transform(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addBatch
				/// </java-name>
				[Dot42.DexImport("addBatch", "(JFFFFI)V", AccessFlags = 17)]
				public void AddBatch(long int64, float single, float single1, float single2, float single3, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addBatch
				/// </java-name>
				[Dot42.DexImport("addBatch", "(J[Landroid/view/MotionEvent$PointerCoords;I)V", AccessFlags = 17)]
				public void AddBatch(long int64, global::Android.Views.MotionEvent.PointerCoords[] pointerCoords, int int32) /* MethodBuilder.Create */ 
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
				/// axisToString
				/// </java-name>
				[Dot42.DexImport("axisToString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string AxisToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// axisFromString
				/// </java-name>
				[Dot42.DexImport("axisFromString", "(Ljava/lang/String;)I", AccessFlags = 9)]
				public static int AxisFromString(string @string) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("android/os/Parcelable", "describeContents", "()I", AccessFlags = 1025)]
				public override int DescribeContents() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDeviceId
				/// </java-name>
				public override int DeviceId
				{
						[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSource
				/// </java-name>
				public override int Source
				{
						[Dot42.DexImport("getSource", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getAction
				/// </java-name>
				public int Action
				{
						[Dot42.DexImport("getAction", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setAction", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getActionMasked
				/// </java-name>
				public int ActionMasked
				{
						[Dot42.DexImport("getActionMasked", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getActionIndex
				/// </java-name>
				public int ActionIndex
				{
						[Dot42.DexImport("getActionIndex", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFlags
				/// </java-name>
				public int Flags
				{
						[Dot42.DexImport("getFlags", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDownTime
				/// </java-name>
				public long DownTime
				{
						[Dot42.DexImport("getDownTime", "()J", AccessFlags = 17)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getEventTime
				/// </java-name>
				public long EventTime
				{
						[Dot42.DexImport("getEventTime", "()J", AccessFlags = 17)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getX
				/// </java-name>
				public float X
				{
						[Dot42.DexImport("getX", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getY
				/// </java-name>
				public float Y
				{
						[Dot42.DexImport("getY", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getPressure
				/// </java-name>
				public float Pressure
				{
						[Dot42.DexImport("getPressure", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getSize
				/// </java-name>
				public float Size
				{
						[Dot42.DexImport("getSize", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getTouchMajor
				/// </java-name>
				public float TouchMajor
				{
						[Dot42.DexImport("getTouchMajor", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getTouchMinor
				/// </java-name>
				public float TouchMinor
				{
						[Dot42.DexImport("getTouchMinor", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getToolMajor
				/// </java-name>
				public float ToolMajor
				{
						[Dot42.DexImport("getToolMajor", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getToolMinor
				/// </java-name>
				public float ToolMinor
				{
						[Dot42.DexImport("getToolMinor", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getOrientation
				/// </java-name>
				public float Orientation
				{
						[Dot42.DexImport("getOrientation", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getPointerCount
				/// </java-name>
				public int PointerCount
				{
						[Dot42.DexImport("getPointerCount", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMetaState
				/// </java-name>
				public int MetaState
				{
						[Dot42.DexImport("getMetaState", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getButtonState
				/// </java-name>
				public int ButtonState
				{
						[Dot42.DexImport("getButtonState", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRawX
				/// </java-name>
				public float RawX
				{
						[Dot42.DexImport("getRawX", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getRawY
				/// </java-name>
				public float RawY
				{
						[Dot42.DexImport("getRawY", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getXPrecision
				/// </java-name>
				public float XPrecision
				{
						[Dot42.DexImport("getXPrecision", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getYPrecision
				/// </java-name>
				public float YPrecision
				{
						[Dot42.DexImport("getYPrecision", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getHistorySize
				/// </java-name>
				public int HistorySize
				{
						[Dot42.DexImport("getHistorySize", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEdgeFlags
				/// </java-name>
				public int EdgeFlags
				{
						[Dot42.DexImport("getEdgeFlags", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setEdgeFlags", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// android/view/MotionEvent$PointerProperties
				/// </java-name>
				[Dot42.DexImport("android/view/MotionEvent$PointerProperties", AccessFlags = 25)]
				public sealed partial class PointerProperties
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "I", AccessFlags = 1)]
						public int Id;
						/// <java-name>
						/// toolType
						/// </java-name>
						[Dot42.DexImport("toolType", "I", AccessFlags = 1)]
						public int ToolType;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public PointerProperties() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/MotionEvent$PointerProperties;)V", AccessFlags = 1)]
						public PointerProperties(PointerProperties pointerProperties) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// clear
						/// </java-name>
						[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
						public void Clear() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// copyFrom
						/// </java-name>
						[Dot42.DexImport("copyFrom", "(Landroid/view/MotionEvent$PointerProperties;)V", AccessFlags = 1)]
						public void CopyFrom(PointerProperties pointerProperties) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/view/MotionEvent$PointerCoords
				/// </java-name>
				[Dot42.DexImport("android/view/MotionEvent$PointerCoords", AccessFlags = 25)]
				public sealed partial class PointerCoords
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// x
						/// </java-name>
						[Dot42.DexImport("x", "F", AccessFlags = 1)]
						public float X;
						/// <java-name>
						/// y
						/// </java-name>
						[Dot42.DexImport("y", "F", AccessFlags = 1)]
						public float Y;
						/// <java-name>
						/// pressure
						/// </java-name>
						[Dot42.DexImport("pressure", "F", AccessFlags = 1)]
						public float Pressure;
						/// <java-name>
						/// size
						/// </java-name>
						[Dot42.DexImport("size", "F", AccessFlags = 1)]
						public float Size;
						/// <java-name>
						/// touchMajor
						/// </java-name>
						[Dot42.DexImport("touchMajor", "F", AccessFlags = 1)]
						public float TouchMajor;
						/// <java-name>
						/// touchMinor
						/// </java-name>
						[Dot42.DexImport("touchMinor", "F", AccessFlags = 1)]
						public float TouchMinor;
						/// <java-name>
						/// toolMajor
						/// </java-name>
						[Dot42.DexImport("toolMajor", "F", AccessFlags = 1)]
						public float ToolMajor;
						/// <java-name>
						/// toolMinor
						/// </java-name>
						[Dot42.DexImport("toolMinor", "F", AccessFlags = 1)]
						public float ToolMinor;
						/// <java-name>
						/// orientation
						/// </java-name>
						[Dot42.DexImport("orientation", "F", AccessFlags = 1)]
						public float Orientation;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public PointerCoords() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/MotionEvent$PointerCoords;)V", AccessFlags = 1)]
						public PointerCoords(PointerCoords pointerCoords) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// clear
						/// </java-name>
						[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
						public void Clear() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// copyFrom
						/// </java-name>
						[Dot42.DexImport("copyFrom", "(Landroid/view/MotionEvent$PointerCoords;)V", AccessFlags = 1)]
						public void CopyFrom(PointerCoords pointerCoords) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getAxisValue
						/// </java-name>
						[Dot42.DexImport("getAxisValue", "(I)F", AccessFlags = 1)]
						public float GetAxisValue(int int32) /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// setAxisValue
						/// </java-name>
						[Dot42.DexImport("setAxisValue", "(IF)V", AccessFlags = 1)]
						public void SetAxisValue(int int32, float single) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/view/OrientationEventListener
		/// </java-name>
		[Dot42.DexImport("android/view/OrientationEventListener", AccessFlags = 1057)]
		public abstract partial class OrientationEventListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ORIENTATION_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_UNKNOWN", "I", AccessFlags = 25)]
				public const int ORIENTATION_UNKNOWN = -1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public OrientationEventListener(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public OrientationEventListener(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enable
				/// </java-name>
				[Dot42.DexImport("enable", "()V", AccessFlags = 1)]
				public virtual void Enable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disable
				/// </java-name>
				[Dot42.DexImport("disable", "()V", AccessFlags = 1)]
				public virtual void Disable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onOrientationChanged
				/// </java-name>
				[Dot42.DexImport("onOrientationChanged", "(I)V", AccessFlags = 1025)]
				public abstract void OnOrientationChanged(int int32) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal OrientationEventListener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// canDetectOrientation
				/// </java-name>
				public virtual bool CanDetectOrientation
				{
						[Dot42.DexImport("canDetectOrientation", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/view/OrientationListener
		/// </java-name>
		[Dot42.DexImport("android/view/OrientationListener", AccessFlags = 1057)]
		public abstract partial class OrientationListener : global::Android.Hardware.ISensorListener
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ORIENTATION_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_UNKNOWN", "I", AccessFlags = 25)]
				public const int ORIENTATION_UNKNOWN = -1;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public OrientationListener(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public OrientationListener(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// enable
				/// </java-name>
				[Dot42.DexImport("enable", "()V", AccessFlags = 1)]
				public virtual void Enable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// disable
				/// </java-name>
				[Dot42.DexImport("disable", "()V", AccessFlags = 1)]
				public virtual void Disable() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAccuracyChanged
				/// </java-name>
				[Dot42.DexImport("onAccuracyChanged", "(II)V", AccessFlags = 1)]
				public virtual void OnAccuracyChanged(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSensorChanged
				/// </java-name>
				[Dot42.DexImport("onSensorChanged", "(I[F)V", AccessFlags = 1)]
				public virtual void OnSensorChanged(int int32, float[] single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onOrientationChanged
				/// </java-name>
				[Dot42.DexImport("onOrientationChanged", "(I)V", AccessFlags = 1025)]
				public abstract void OnOrientationChanged(int int32) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal OrientationListener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/view/ScaleGestureDetector
		/// </java-name>
		[Dot42.DexImport("android/view/ScaleGestureDetector", AccessFlags = 33)]
		public partial class ScaleGestureDetector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/ScaleGestureDetector$OnScaleGestureListen" +
    "er;)V", AccessFlags = 1)]
				public ScaleGestureDetector(global::Android.Content.Context context, global::Android.Views.ScaleGestureDetector.IOnScaleGestureListener onScaleGestureListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScaleGestureDetector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isInProgress
				/// </java-name>
				public virtual bool IsInProgress
				{
						[Dot42.DexImport("isInProgress", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getFocusX
				/// </java-name>
				public virtual float FocusX
				{
						[Dot42.DexImport("getFocusX", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getFocusY
				/// </java-name>
				public virtual float FocusY
				{
						[Dot42.DexImport("getFocusY", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getCurrentSpan
				/// </java-name>
				public virtual float CurrentSpan
				{
						[Dot42.DexImport("getCurrentSpan", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getCurrentSpanX
				/// </java-name>
				public virtual float CurrentSpanX
				{
						[Dot42.DexImport("getCurrentSpanX", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getCurrentSpanY
				/// </java-name>
				public virtual float CurrentSpanY
				{
						[Dot42.DexImport("getCurrentSpanY", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getPreviousSpan
				/// </java-name>
				public virtual float PreviousSpan
				{
						[Dot42.DexImport("getPreviousSpan", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getPreviousSpanX
				/// </java-name>
				public virtual float PreviousSpanX
				{
						[Dot42.DexImport("getPreviousSpanX", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getPreviousSpanY
				/// </java-name>
				public virtual float PreviousSpanY
				{
						[Dot42.DexImport("getPreviousSpanY", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getScaleFactor
				/// </java-name>
				public virtual float ScaleFactor
				{
						[Dot42.DexImport("getScaleFactor", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getTimeDelta
				/// </java-name>
				public virtual long TimeDelta
				{
						[Dot42.DexImport("getTimeDelta", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getEventTime
				/// </java-name>
				public virtual long EventTime
				{
						[Dot42.DexImport("getEventTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// android/view/ScaleGestureDetector$SimpleOnScaleGestureListener
				/// </java-name>
				[Dot42.DexImport("android/view/ScaleGestureDetector$SimpleOnScaleGestureListener", AccessFlags = 9)]
				public partial class SimpleOnScaleGestureListener : global::Android.Views.ScaleGestureDetector.IOnScaleGestureListener
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public SimpleOnScaleGestureListener() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onScale
						/// </java-name>
						[Dot42.DexImport("onScale", "(Landroid/view/ScaleGestureDetector;)Z", AccessFlags = 1)]
						public virtual bool OnScale(global::Android.Views.ScaleGestureDetector scaleGestureDetector) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// onScaleBegin
						/// </java-name>
						[Dot42.DexImport("onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", AccessFlags = 1)]
						public virtual bool OnScaleBegin(global::Android.Views.ScaleGestureDetector scaleGestureDetector) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// onScaleEnd
						/// </java-name>
						[Dot42.DexImport("onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", AccessFlags = 1)]
						public virtual void OnScaleEnd(global::Android.Views.ScaleGestureDetector scaleGestureDetector) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/view/ScaleGestureDetector$OnScaleGestureListener
				/// </java-name>
				[Dot42.DexImport("android/view/ScaleGestureDetector$OnScaleGestureListener", AccessFlags = 1545)]
				public partial interface IOnScaleGestureListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onScale
						/// </java-name>
						[Dot42.DexImport("onScale", "(Landroid/view/ScaleGestureDetector;)Z", AccessFlags = 1025)]
						bool OnScale(global::Android.Views.ScaleGestureDetector scaleGestureDetector) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onScaleBegin
						/// </java-name>
						[Dot42.DexImport("onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", AccessFlags = 1025)]
						bool OnScaleBegin(global::Android.Views.ScaleGestureDetector scaleGestureDetector) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onScaleEnd
						/// </java-name>
						[Dot42.DexImport("onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", AccessFlags = 1025)]
						void OnScaleEnd(global::Android.Views.ScaleGestureDetector scaleGestureDetector) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/SoundEffectConstants
		/// </java-name>
		[Dot42.DexImport("android/view/SoundEffectConstants", AccessFlags = 33)]
		public partial class SoundEffectConstants
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// CLICK
				/// </java-name>
				[Dot42.DexImport("CLICK", "I", AccessFlags = 25)]
				public const int CLICK = 0;
				/// <java-name>
				/// NAVIGATION_LEFT
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_LEFT", "I", AccessFlags = 25)]
				public const int NAVIGATION_LEFT = 1;
				/// <java-name>
				/// NAVIGATION_UP
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_UP", "I", AccessFlags = 25)]
				public const int NAVIGATION_UP = 2;
				/// <java-name>
				/// NAVIGATION_RIGHT
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_RIGHT", "I", AccessFlags = 25)]
				public const int NAVIGATION_RIGHT = 3;
				/// <java-name>
				/// NAVIGATION_DOWN
				/// </java-name>
				[Dot42.DexImport("NAVIGATION_DOWN", "I", AccessFlags = 25)]
				public const int NAVIGATION_DOWN = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal SoundEffectConstants() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getContantForFocusDirection
				/// </java-name>
				[Dot42.DexImport("getContantForFocusDirection", "(I)I", AccessFlags = 9)]
				public static int GetContantForFocusDirection(int int32) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <java-name>
		/// android/view/Surface
		/// </java-name>
		[Dot42.DexImport("android/view/Surface", AccessFlags = 33)]
		public partial class Surface : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ROTATION_0
				/// </java-name>
				[Dot42.DexImport("ROTATION_0", "I", AccessFlags = 25)]
				public const int ROTATION_0 = 0;
				/// <java-name>
				/// ROTATION_90
				/// </java-name>
				[Dot42.DexImport("ROTATION_90", "I", AccessFlags = 25)]
				public const int ROTATION_90 = 1;
				/// <java-name>
				/// ROTATION_180
				/// </java-name>
				[Dot42.DexImport("ROTATION_180", "I", AccessFlags = 25)]
				public const int ROTATION_180 = 2;
				/// <java-name>
				/// ROTATION_270
				/// </java-name>
				[Dot42.DexImport("ROTATION_270", "I", AccessFlags = 25)]
				public const int ROTATION_270 = 3;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Surface> CREATOR;
				[Dot42.DexImport("<init>", "(Landroid/graphics/SurfaceTexture;)V", AccessFlags = 1)]
				public Surface(global::Android.Graphics.SurfaceTexture surfaceTexture) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// release
				/// </java-name>
				[Dot42.DexImport("release", "()V", AccessFlags = 257)]
				public virtual void Release() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// lockCanvas
				/// </java-name>
				[Dot42.DexImport("lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Canvas LockCanvas(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Canvas);
				}

				/// <java-name>
				/// unlockCanvasAndPost
				/// </java-name>
				[Dot42.DexImport("unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", AccessFlags = 257)]
				public virtual void UnlockCanvasAndPost(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unlockCanvas
				/// </java-name>
				[Dot42.DexImport("unlockCanvas", "(Landroid/graphics/Canvas;)V", AccessFlags = 257)]
				public virtual void UnlockCanvas(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
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
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// readFromParcel
				/// </java-name>
				[Dot42.DexImport("readFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 257)]
				public virtual void ReadFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 257)]
				public virtual void WriteToParcel(global::Android.OS.Parcel parcel, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Surface() /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Surface() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// isValid
				/// </java-name>
				public virtual bool IsValid
				{
						[Dot42.DexImport("isValid", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/view/Surface$OutOfResourcesException
				/// </java-name>
				[Dot42.DexImport("android/view/Surface$OutOfResourcesException", AccessFlags = 9)]
				public partial class OutOfResourcesException : global::System.Exception
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public OutOfResourcesException() /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
						public OutOfResourcesException(string @string) /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/view/SurfaceView
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceView", AccessFlags = 33)]
		public partial class SurfaceView : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public SurfaceView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public SurfaceView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public SurfaceView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
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
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal override void OnWindowVisibilityChanged(int int32) /* MethodBuilder.Create */ 
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
				/// gatherTransparentRegion
				/// </java-name>
				[Dot42.DexImport("gatherTransparentRegion", "(Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public virtual bool GatherTransparentRegion(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
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
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal override void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZOrderMediaOverlay
				/// </java-name>
				[Dot42.DexImport("setZOrderMediaOverlay", "(Z)V", AccessFlags = 1)]
				public virtual void SetZOrderMediaOverlay(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setZOrderOnTop
				/// </java-name>
				[Dot42.DexImport("setZOrderOnTop", "(Z)V", AccessFlags = 1)]
				public virtual void SetZOrderOnTop(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SurfaceView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getHolder
				/// </java-name>
				public virtual global::Android.Views.ISurfaceHolder Holder
				{
						[Dot42.DexImport("getHolder", "()Landroid/view/SurfaceHolder;", AccessFlags = 1)]
						get{ return default(global::Android.Views.ISurfaceHolder); }
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
		/// android/view/TextureView
		/// </java-name>
		[Dot42.DexImport("android/view/TextureView", AccessFlags = 33)]
		public partial class TextureView : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public TextureView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public TextureView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public TextureView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOpaque
				/// </java-name>
				[Dot42.DexImport("setOpaque", "(Z)V", AccessFlags = 1)]
				public virtual void SetOpaque(bool boolean) /* MethodBuilder.Create */ 
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
				/// setLayerType
				/// </java-name>
				[Dot42.DexImport("setLayerType", "(ILandroid/graphics/Paint;)V", AccessFlags = 1)]
				public override void SetLayerType(int int32, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// buildLayer
				/// </java-name>
				[Dot42.DexImport("buildLayer", "()V", AccessFlags = 1)]
				public override void BuildLayer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 17)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 20)]
				protected internal override void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
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
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void OnVisibilityChanged(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTransform
				/// </java-name>
				[Dot42.DexImport("setTransform", "(Landroid/graphics/Matrix;)V", AccessFlags = 1)]
				public virtual void SetTransform(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getTransform
				/// </java-name>
				[Dot42.DexImport("getTransform", "(Landroid/graphics/Matrix;)Landroid/graphics/Matrix;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Matrix GetTransform(global::Android.Graphics.Matrix matrix) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Matrix);
				}

				/// <java-name>
				/// getBitmap
				/// </java-name>
				[Dot42.DexImport("getBitmap", "(II)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetBitmap(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// getBitmap
				/// </java-name>
				[Dot42.DexImport("getBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetBitmap(global::Android.Graphics.Bitmap bitmap) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// lockCanvas
				/// </java-name>
				[Dot42.DexImport("lockCanvas", "()Landroid/graphics/Canvas;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Canvas LockCanvas() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Canvas);
				}

				/// <java-name>
				/// lockCanvas
				/// </java-name>
				[Dot42.DexImport("lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Canvas LockCanvas(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Canvas);
				}

				/// <java-name>
				/// unlockCanvasAndPost
				/// </java-name>
				[Dot42.DexImport("unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void UnlockCanvasAndPost(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TextureView() /* TypeBuilder.AddDefaultConstructor */ 
				{
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
				/// getLayerType
				/// </java-name>
				public override int LayerType
				{
						[Dot42.DexImport("getLayerType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBitmap
				/// </java-name>
				public virtual global::Android.Graphics.Bitmap Bitmap
				{
						[Dot42.DexImport("getBitmap", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Bitmap); }
				}

				/// <java-name>
				/// isAvailable
				/// </java-name>
				public virtual bool IsAvailable
				{
						[Dot42.DexImport("isAvailable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getSurfaceTexture
				/// </java-name>
				public virtual global::Android.Graphics.SurfaceTexture SurfaceTexture
				{
						[Dot42.DexImport("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.SurfaceTexture); }
				}

				/// <java-name>
				/// getSurfaceTextureListener
				/// </java-name>
				public virtual global::Android.Views.TextureView.ISurfaceTextureListener SurfaceTextureListener
				{
						[Dot42.DexImport("getSurfaceTextureListener", "()Landroid/view/TextureView$SurfaceTextureListener;", AccessFlags = 1)]
						get{ return default(global::Android.Views.TextureView.ISurfaceTextureListener); }
						[Dot42.DexImport("setSurfaceTextureListener", "(Landroid/view/TextureView$SurfaceTextureListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/view/TextureView$SurfaceTextureListener
				/// </java-name>
				[Dot42.DexImport("android/view/TextureView$SurfaceTextureListener", AccessFlags = 1545)]
				public partial interface ISurfaceTextureListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSurfaceTextureAvailable
						/// </java-name>
						[Dot42.DexImport("onSurfaceTextureAvailable", "(Landroid/graphics/SurfaceTexture;II)V", AccessFlags = 1025)]
						void OnSurfaceTextureAvailable(global::Android.Graphics.SurfaceTexture surfaceTexture, int int32, int int321) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onSurfaceTextureSizeChanged
						/// </java-name>
						[Dot42.DexImport("onSurfaceTextureSizeChanged", "(Landroid/graphics/SurfaceTexture;II)V", AccessFlags = 1025)]
						void OnSurfaceTextureSizeChanged(global::Android.Graphics.SurfaceTexture surfaceTexture, int int32, int int321) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onSurfaceTextureDestroyed
						/// </java-name>
						[Dot42.DexImport("onSurfaceTextureDestroyed", "(Landroid/graphics/SurfaceTexture;)Z", AccessFlags = 1025)]
						bool OnSurfaceTextureDestroyed(global::Android.Graphics.SurfaceTexture surfaceTexture) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onSurfaceTextureUpdated
						/// </java-name>
						[Dot42.DexImport("onSurfaceTextureUpdated", "(Landroid/graphics/SurfaceTexture;)V", AccessFlags = 1025)]
						void OnSurfaceTextureUpdated(global::Android.Graphics.SurfaceTexture surfaceTexture) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/TouchDelegate
		/// </java-name>
		[Dot42.DexImport("android/view/TouchDelegate", AccessFlags = 33)]
		public partial class TouchDelegate
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ABOVE
				/// </java-name>
				[Dot42.DexImport("ABOVE", "I", AccessFlags = 25)]
				public const int ABOVE = 1;
				/// <java-name>
				/// BELOW
				/// </java-name>
				[Dot42.DexImport("BELOW", "I", AccessFlags = 25)]
				public const int BELOW = 2;
				/// <java-name>
				/// TO_LEFT
				/// </java-name>
				[Dot42.DexImport("TO_LEFT", "I", AccessFlags = 25)]
				public const int TO_LEFT = 4;
				/// <java-name>
				/// TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("TO_RIGHT", "I", AccessFlags = 25)]
				public const int TO_RIGHT = 8;
				[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;Landroid/view/View;)V", AccessFlags = 1)]
				public TouchDelegate(global::Android.Graphics.Rect rect, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TouchDelegate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// android/view/VelocityTracker
		/// </java-name>
		[Dot42.DexImport("android/view/VelocityTracker", AccessFlags = 49)]
		public sealed partial class VelocityTracker
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal VelocityTracker() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/VelocityTracker;", AccessFlags = 9)]
				public static global::Android.Views.VelocityTracker Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.VelocityTracker);
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~VelocityTracker() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addMovement
				/// </java-name>
				[Dot42.DexImport("addMovement", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public void AddMovement(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeCurrentVelocity
				/// </java-name>
				[Dot42.DexImport("computeCurrentVelocity", "(I)V", AccessFlags = 1)]
				public void ComputeCurrentVelocity(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeCurrentVelocity
				/// </java-name>
				[Dot42.DexImport("computeCurrentVelocity", "(IF)V", AccessFlags = 1)]
				public void ComputeCurrentVelocity(int int32, float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getXVelocity
				/// </java-name>
				[Dot42.DexImport("getXVelocity", "(I)F", AccessFlags = 1)]
				public float GetXVelocity(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getYVelocity
				/// </java-name>
				[Dot42.DexImport("getYVelocity", "(I)F", AccessFlags = 1)]
				public float GetYVelocity(int int32) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getXVelocity
				/// </java-name>
				public float XVelocity
				{
						[Dot42.DexImport("getXVelocity", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getYVelocity
				/// </java-name>
				public float YVelocity
				{
						[Dot42.DexImport("getYVelocity", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

		}

		/// <java-name>
		/// android/view/View
		/// </java-name>
		[Dot42.DexImport("android/view/View", AccessFlags = 33)]
		public partial class View : global::Android.Graphics.Drawables.Drawable.ICallback, global::Android.Views.KeyEvent.ICallback, global::Android.Views.Accessibility.IAccessibilityEventSource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// VIEW_LOG_TAG
				/// </java-name>
				[Dot42.DexImport("VIEW_LOG_TAG", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string VIEW_LOG_TAG = "View";
				/// <java-name>
				/// NO_ID
				/// </java-name>
				[Dot42.DexImport("NO_ID", "I", AccessFlags = 25)]
				public const int NO_ID = -1;
				/// <java-name>
				/// VISIBLE
				/// </java-name>
				[Dot42.DexImport("VISIBLE", "I", AccessFlags = 25)]
				public const int VISIBLE = 0;
				/// <java-name>
				/// INVISIBLE
				/// </java-name>
				[Dot42.DexImport("INVISIBLE", "I", AccessFlags = 25)]
				public const int INVISIBLE = 4;
				/// <java-name>
				/// GONE
				/// </java-name>
				[Dot42.DexImport("GONE", "I", AccessFlags = 25)]
				public const int GONE = 8;
				/// <java-name>
				/// DRAWING_CACHE_QUALITY_LOW
				/// </java-name>
				[Dot42.DexImport("DRAWING_CACHE_QUALITY_LOW", "I", AccessFlags = 25)]
				public const int DRAWING_CACHE_QUALITY_LOW = 524288;
				/// <java-name>
				/// DRAWING_CACHE_QUALITY_HIGH
				/// </java-name>
				[Dot42.DexImport("DRAWING_CACHE_QUALITY_HIGH", "I", AccessFlags = 25)]
				public const int DRAWING_CACHE_QUALITY_HIGH = 1048576;
				/// <java-name>
				/// DRAWING_CACHE_QUALITY_AUTO
				/// </java-name>
				[Dot42.DexImport("DRAWING_CACHE_QUALITY_AUTO", "I", AccessFlags = 25)]
				public const int DRAWING_CACHE_QUALITY_AUTO = 0;
				/// <java-name>
				/// SCROLLBARS_INSIDE_OVERLAY
				/// </java-name>
				[Dot42.DexImport("SCROLLBARS_INSIDE_OVERLAY", "I", AccessFlags = 25)]
				public const int SCROLLBARS_INSIDE_OVERLAY = 0;
				/// <java-name>
				/// SCROLLBARS_INSIDE_INSET
				/// </java-name>
				[Dot42.DexImport("SCROLLBARS_INSIDE_INSET", "I", AccessFlags = 25)]
				public const int SCROLLBARS_INSIDE_INSET = 16777216;
				/// <java-name>
				/// SCROLLBARS_OUTSIDE_OVERLAY
				/// </java-name>
				[Dot42.DexImport("SCROLLBARS_OUTSIDE_OVERLAY", "I", AccessFlags = 25)]
				public const int SCROLLBARS_OUTSIDE_OVERLAY = 33554432;
				/// <java-name>
				/// SCROLLBARS_OUTSIDE_INSET
				/// </java-name>
				[Dot42.DexImport("SCROLLBARS_OUTSIDE_INSET", "I", AccessFlags = 25)]
				public const int SCROLLBARS_OUTSIDE_INSET = 50331648;
				/// <java-name>
				/// KEEP_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("KEEP_SCREEN_ON", "I", AccessFlags = 25)]
				public const int KEEP_SCREEN_ON = 67108864;
				/// <java-name>
				/// SOUND_EFFECTS_ENABLED
				/// </java-name>
				[Dot42.DexImport("SOUND_EFFECTS_ENABLED", "I", AccessFlags = 25)]
				public const int SOUND_EFFECTS_ENABLED = 134217728;
				/// <java-name>
				/// HAPTIC_FEEDBACK_ENABLED
				/// </java-name>
				[Dot42.DexImport("HAPTIC_FEEDBACK_ENABLED", "I", AccessFlags = 25)]
				public const int HAPTIC_FEEDBACK_ENABLED = 268435456;
				/// <java-name>
				/// FOCUSABLES_ALL
				/// </java-name>
				[Dot42.DexImport("FOCUSABLES_ALL", "I", AccessFlags = 25)]
				public const int FOCUSABLES_ALL = 0;
				/// <java-name>
				/// FOCUSABLES_TOUCH_MODE
				/// </java-name>
				[Dot42.DexImport("FOCUSABLES_TOUCH_MODE", "I", AccessFlags = 25)]
				public const int FOCUSABLES_TOUCH_MODE = 1;
				/// <java-name>
				/// FOCUS_BACKWARD
				/// </java-name>
				[Dot42.DexImport("FOCUS_BACKWARD", "I", AccessFlags = 25)]
				public const int FOCUS_BACKWARD = 1;
				/// <java-name>
				/// FOCUS_FORWARD
				/// </java-name>
				[Dot42.DexImport("FOCUS_FORWARD", "I", AccessFlags = 25)]
				public const int FOCUS_FORWARD = 2;
				/// <java-name>
				/// FOCUS_LEFT
				/// </java-name>
				[Dot42.DexImport("FOCUS_LEFT", "I", AccessFlags = 25)]
				public const int FOCUS_LEFT = 17;
				/// <java-name>
				/// FOCUS_UP
				/// </java-name>
				[Dot42.DexImport("FOCUS_UP", "I", AccessFlags = 25)]
				public const int FOCUS_UP = 33;
				/// <java-name>
				/// FOCUS_RIGHT
				/// </java-name>
				[Dot42.DexImport("FOCUS_RIGHT", "I", AccessFlags = 25)]
				public const int FOCUS_RIGHT = 66;
				/// <java-name>
				/// FOCUS_DOWN
				/// </java-name>
				[Dot42.DexImport("FOCUS_DOWN", "I", AccessFlags = 25)]
				public const int FOCUS_DOWN = 130;
				/// <java-name>
				/// MEASURED_SIZE_MASK
				/// </java-name>
				[Dot42.DexImport("MEASURED_SIZE_MASK", "I", AccessFlags = 25)]
				public const int MEASURED_SIZE_MASK = 16777215;
				/// <java-name>
				/// MEASURED_STATE_MASK
				/// </java-name>
				[Dot42.DexImport("MEASURED_STATE_MASK", "I", AccessFlags = 25)]
				public const int MEASURED_STATE_MASK = -16777216;
				/// <java-name>
				/// MEASURED_HEIGHT_STATE_SHIFT
				/// </java-name>
				[Dot42.DexImport("MEASURED_HEIGHT_STATE_SHIFT", "I", AccessFlags = 25)]
				public const int MEASURED_HEIGHT_STATE_SHIFT = 16;
				/// <java-name>
				/// MEASURED_STATE_TOO_SMALL
				/// </java-name>
				[Dot42.DexImport("MEASURED_STATE_TOO_SMALL", "I", AccessFlags = 25)]
				public const int MEASURED_STATE_TOO_SMALL = 16777216;
				/// <java-name>
				/// EMPTY_STATE_SET
				/// </java-name>
				[Dot42.DexImport("EMPTY_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] EMPTY_STATE_SET;
				/// <java-name>
				/// ENABLED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_STATE_SET;
				/// <java-name>
				/// FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_STATE_SET;
				/// <java-name>
				/// SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] SELECTED_STATE_SET;
				/// <java-name>
				/// WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// ENABLED_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_FOCUSED_STATE_SET;
				/// <java-name>
				/// ENABLED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_SELECTED_STATE_SET;
				/// <java-name>
				/// ENABLED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// FOCUSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_SELECTED_STATE_SET;
				/// <java-name>
				/// FOCUSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// ENABLED_FOCUSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_FOCUSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_FOCUSED_SELECTED_STATE_SET;
				/// <java-name>
				/// ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_SELECTED_STATE_SET;
				/// <java-name>
				/// PRESSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_FOCUSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_FOCUSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_FOCUSED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_FOCUSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_FOCUSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_FOCUSED_SELECTED_STATE_SET;
				/// <java-name>
				/// PRESSED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_ENABLED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_STATE_SET;
				/// <java-name>
				/// PRESSED_ENABLED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_ENABLED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_SELECTED_STATE_SET;
				/// <java-name>
				/// PRESSED_ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_ENABLED_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// PRESSED_ENABLED_FOCUSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_FOCUSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_FOCUSED_SELECTED_STATE_SET;
				/// <java-name>
				/// PRESSED_ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <java-name>
				/// OVER_SCROLL_ALWAYS
				/// </java-name>
				[Dot42.DexImport("OVER_SCROLL_ALWAYS", "I", AccessFlags = 25)]
				public const int OVER_SCROLL_ALWAYS = 0;
				/// <java-name>
				/// OVER_SCROLL_IF_CONTENT_SCROLLS
				/// </java-name>
				[Dot42.DexImport("OVER_SCROLL_IF_CONTENT_SCROLLS", "I", AccessFlags = 25)]
				public const int OVER_SCROLL_IF_CONTENT_SCROLLS = 1;
				/// <java-name>
				/// OVER_SCROLL_NEVER
				/// </java-name>
				[Dot42.DexImport("OVER_SCROLL_NEVER", "I", AccessFlags = 25)]
				public const int OVER_SCROLL_NEVER = 2;
				/// <java-name>
				/// SYSTEM_UI_FLAG_VISIBLE
				/// </java-name>
				[Dot42.DexImport("SYSTEM_UI_FLAG_VISIBLE", "I", AccessFlags = 25)]
				public const int SYSTEM_UI_FLAG_VISIBLE = 0;
				/// <java-name>
				/// SYSTEM_UI_FLAG_LOW_PROFILE
				/// </java-name>
				[Dot42.DexImport("SYSTEM_UI_FLAG_LOW_PROFILE", "I", AccessFlags = 25)]
				public const int SYSTEM_UI_FLAG_LOW_PROFILE = 1;
				/// <java-name>
				/// SYSTEM_UI_FLAG_HIDE_NAVIGATION
				/// </java-name>
				[Dot42.DexImport("SYSTEM_UI_FLAG_HIDE_NAVIGATION", "I", AccessFlags = 25)]
				public const int SYSTEM_UI_FLAG_HIDE_NAVIGATION = 2;
				/// <java-name>
				/// STATUS_BAR_HIDDEN
				/// </java-name>
				[Dot42.DexImport("STATUS_BAR_HIDDEN", "I", AccessFlags = 25)]
				public const int STATUS_BAR_HIDDEN = 1;
				/// <java-name>
				/// STATUS_BAR_VISIBLE
				/// </java-name>
				[Dot42.DexImport("STATUS_BAR_VISIBLE", "I", AccessFlags = 25)]
				public const int STATUS_BAR_VISIBLE = 0;
				/// <java-name>
				/// FIND_VIEWS_WITH_TEXT
				/// </java-name>
				[Dot42.DexImport("FIND_VIEWS_WITH_TEXT", "I", AccessFlags = 25)]
				public const int FIND_VIEWS_WITH_TEXT = 1;
				/// <java-name>
				/// FIND_VIEWS_WITH_CONTENT_DESCRIPTION
				/// </java-name>
				[Dot42.DexImport("FIND_VIEWS_WITH_CONTENT_DESCRIPTION", "I", AccessFlags = 25)]
				public const int FIND_VIEWS_WITH_CONTENT_DESCRIPTION = 2;
				/// <java-name>
				/// SCROLLBAR_POSITION_DEFAULT
				/// </java-name>
				[Dot42.DexImport("SCROLLBAR_POSITION_DEFAULT", "I", AccessFlags = 25)]
				public const int SCROLLBAR_POSITION_DEFAULT = 0;
				/// <java-name>
				/// SCROLLBAR_POSITION_LEFT
				/// </java-name>
				[Dot42.DexImport("SCROLLBAR_POSITION_LEFT", "I", AccessFlags = 25)]
				public const int SCROLLBAR_POSITION_LEFT = 1;
				/// <java-name>
				/// SCROLLBAR_POSITION_RIGHT
				/// </java-name>
				[Dot42.DexImport("SCROLLBAR_POSITION_RIGHT", "I", AccessFlags = 25)]
				public const int SCROLLBAR_POSITION_RIGHT = 2;
				/// <java-name>
				/// LAYER_TYPE_NONE
				/// </java-name>
				[Dot42.DexImport("LAYER_TYPE_NONE", "I", AccessFlags = 25)]
				public const int LAYER_TYPE_NONE = 0;
				/// <java-name>
				/// LAYER_TYPE_SOFTWARE
				/// </java-name>
				[Dot42.DexImport("LAYER_TYPE_SOFTWARE", "I", AccessFlags = 25)]
				public const int LAYER_TYPE_SOFTWARE = 1;
				/// <java-name>
				/// LAYER_TYPE_HARDWARE
				/// </java-name>
				[Dot42.DexImport("LAYER_TYPE_HARDWARE", "I", AccessFlags = 25)]
				public const int LAYER_TYPE_HARDWARE = 2;
				/// <java-name>
				/// ALPHA
				/// </java-name>
				[Dot42.DexImport("ALPHA", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> ALPHA;
				/// <java-name>
				/// TRANSLATION_X
				/// </java-name>
				[Dot42.DexImport("TRANSLATION_X", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> TRANSLATION_X;
				/// <java-name>
				/// TRANSLATION_Y
				/// </java-name>
				[Dot42.DexImport("TRANSLATION_Y", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> TRANSLATION_Y;
				/// <java-name>
				/// X
				/// </java-name>
				[Dot42.DexImport("X", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> @x;
				/// <java-name>
				/// Y
				/// </java-name>
				[Dot42.DexImport("Y", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> @y;
				/// <java-name>
				/// ROTATION
				/// </java-name>
				[Dot42.DexImport("ROTATION", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> ROTATION;
				/// <java-name>
				/// ROTATION_X
				/// </java-name>
				[Dot42.DexImport("ROTATION_X", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> ROTATION_X;
				/// <java-name>
				/// ROTATION_Y
				/// </java-name>
				[Dot42.DexImport("ROTATION_Y", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> ROTATION_Y;
				/// <java-name>
				/// SCALE_X
				/// </java-name>
				[Dot42.DexImport("SCALE_X", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> SCALE_X;
				/// <java-name>
				/// SCALE_Y
				/// </java-name>
				[Dot42.DexImport("SCALE_Y", "Landroid/util/Property;", AccessFlags = 9)]
				public static global::Android.Util.Property<global::Android.Views.View, float?> SCALE_Y;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public View(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public View(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public View(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initializeFadingEdge
				/// </java-name>
				[Dot42.DexImport("initializeFadingEdge", "(Landroid/content/res/TypedArray;)V", AccessFlags = 4)]
				protected internal virtual void InitializeFadingEdge(global::Android.Content.Res.TypedArray typedArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFadingEdgeLength
				/// </java-name>
				[Dot42.DexImport("setFadingEdgeLength", "(I)V", AccessFlags = 1)]
				public virtual void SetFadingEdgeLength(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initializeScrollbars
				/// </java-name>
				[Dot42.DexImport("initializeScrollbars", "(Landroid/content/res/TypedArray;)V", AccessFlags = 4)]
				protected internal virtual void InitializeScrollbars(global::Android.Content.Res.TypedArray typedArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnLayoutChangeListener
				/// </java-name>
				[Dot42.DexImport("addOnLayoutChangeListener", "(Landroid/view/View$OnLayoutChangeListener;)V", AccessFlags = 1)]
				public virtual void AddOnLayoutChangeListener(global::Android.Views.View.IOnLayoutChangeListener onLayoutChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnLayoutChangeListener
				/// </java-name>
				[Dot42.DexImport("removeOnLayoutChangeListener", "(Landroid/view/View$OnLayoutChangeListener;)V", AccessFlags = 1)]
				public virtual void RemoveOnLayoutChangeListener(global::Android.Views.View.IOnLayoutChangeListener onLayoutChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnAttachStateChangeListener
				/// </java-name>
				[Dot42.DexImport("addOnAttachStateChangeListener", "(Landroid/view/View$OnAttachStateChangeListener;)V", AccessFlags = 1)]
				public virtual void AddOnAttachStateChangeListener(global::Android.Views.View.IOnAttachStateChangeListener onAttachStateChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnAttachStateChangeListener
				/// </java-name>
				[Dot42.DexImport("removeOnAttachStateChangeListener", "(Landroid/view/View$OnAttachStateChangeListener;)V", AccessFlags = 1)]
				public virtual void RemoveOnAttachStateChangeListener(global::Android.Views.View.IOnAttachStateChangeListener onAttachStateChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnClickListener
				/// </java-name>
				[Dot42.DexImport("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnClickListener(global::Android.Views.View.IOnClickListener onClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnLongClickListener
				/// </java-name>
				[Dot42.DexImport("setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnLongClickListener(global::Android.Views.View.IOnLongClickListener onLongClickListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnCreateContextMenuListener
				/// </java-name>
				[Dot42.DexImport("setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V", AccessFlags = 1)]
				public virtual void SetOnCreateContextMenuListener(global::Android.Views.View.IOnCreateContextMenuListener onCreateContextMenuListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performClick
				/// </java-name>
				[Dot42.DexImport("performClick", "()Z", AccessFlags = 1)]
				public virtual bool PerformClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// callOnClick
				/// </java-name>
				[Dot42.DexImport("callOnClick", "()Z", AccessFlags = 1)]
				public virtual bool CallOnClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performLongClick
				/// </java-name>
				[Dot42.DexImport("performLongClick", "()Z", AccessFlags = 1)]
				public virtual bool PerformLongClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// showContextMenu
				/// </java-name>
				[Dot42.DexImport("showContextMenu", "()Z", AccessFlags = 1)]
				public virtual bool ShowContextMenu() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startActionMode
				/// </java-name>
				[Dot42.DexImport("startActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1)]
				public virtual global::Android.Views.ActionMode StartActionMode(global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ActionMode);
				}

				/// <java-name>
				/// setOnKeyListener
				/// </java-name>
				[Dot42.DexImport("setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V", AccessFlags = 1)]
				public virtual void SetOnKeyListener(global::Android.Views.View.IOnKeyListener onKeyListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnTouchListener
				/// </java-name>
				[Dot42.DexImport("setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V", AccessFlags = 1)]
				public virtual void SetOnTouchListener(global::Android.Views.View.IOnTouchListener onTouchListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnGenericMotionListener
				/// </java-name>
				[Dot42.DexImport("setOnGenericMotionListener", "(Landroid/view/View$OnGenericMotionListener;)V", AccessFlags = 1)]
				public virtual void SetOnGenericMotionListener(global::Android.Views.View.IOnGenericMotionListener onGenericMotionListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnHoverListener
				/// </java-name>
				[Dot42.DexImport("setOnHoverListener", "(Landroid/view/View$OnHoverListener;)V", AccessFlags = 1)]
				public virtual void SetOnHoverListener(global::Android.Views.View.IOnHoverListener onHoverListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOnDragListener
				/// </java-name>
				[Dot42.DexImport("setOnDragListener", "(Landroid/view/View$OnDragListener;)V", AccessFlags = 1)]
				public virtual void SetOnDragListener(global::Android.Views.View.IOnDragListener onDragListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool RequestRectangleOnScreen(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public virtual bool RequestRectangleOnScreen(global::Android.Graphics.Rect rect, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clearFocus
				/// </java-name>
				[Dot42.DexImport("clearFocus", "()V", AccessFlags = 1)]
				public virtual void ClearFocus() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal virtual void OnFocusChanged(bool boolean, int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1)]
				public virtual void SendAccessibilityEvent(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAccessibilityEventUnchecked
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public virtual void SendAccessibilityEventUnchecked(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public virtual void OnPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public virtual void OnInitializeAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("createAccessibilityNodeInfo", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.Views.Accessibility.AccessibilityNodeInfo CreateAccessibilityNodeInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public virtual void OnInitializeAccessibilityNodeInfo(global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAccessibilityDelegate
				/// </java-name>
				[Dot42.DexImport("setAccessibilityDelegate", "(Landroid/view/View$AccessibilityDelegate;)V", AccessFlags = 1)]
				public virtual void SetAccessibilityDelegate(global::Android.Views.View.AccessibilityDelegate accessibilityDelegate) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findFocus
				/// </java-name>
				[Dot42.DexImport("findFocus", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindFocus() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setScrollContainer
				/// </java-name>
				[Dot42.DexImport("setScrollContainer", "(Z)V", AccessFlags = 1)]
				public virtual void SetScrollContainer(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fitSystemWindows
				/// </java-name>
				[Dot42.DexImport("fitSystemWindows", "(Landroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal virtual bool FitSystemWindows(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setFitsSystemWindows
				/// </java-name>
				[Dot42.DexImport("setFitsSystemWindows", "(Z)V", AccessFlags = 1)]
				public virtual void SetFitsSystemWindows(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fitsSystemWindows
				/// </java-name>
				[Dot42.DexImport("fitsSystemWindows", "()Z", AccessFlags = 1)]
				public virtual bool FitsSystemWindows() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setWillNotDraw
				/// </java-name>
				[Dot42.DexImport("setWillNotDraw", "(Z)V", AccessFlags = 1)]
				public virtual void SetWillNotDraw(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// willNotDraw
				/// </java-name>
				[Dot42.DexImport("willNotDraw", "()Z", AccessFlags = 1)]
				public virtual bool WillNotDraw() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setWillNotCacheDrawing
				/// </java-name>
				[Dot42.DexImport("setWillNotCacheDrawing", "(Z)V", AccessFlags = 1)]
				public virtual void SetWillNotCacheDrawing(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// willNotCacheDrawing
				/// </java-name>
				[Dot42.DexImport("willNotCacheDrawing", "()Z", AccessFlags = 1)]
				public virtual bool WillNotCacheDrawing() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchSetPressed
				/// </java-name>
				[Dot42.DexImport("dispatchSetPressed", "(Z)V", AccessFlags = 4)]
				protected internal virtual void DispatchSetPressed(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// focusSearch
				/// </java-name>
				[Dot42.DexImport("focusSearch", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FocusSearch(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// dispatchUnhandledMove
				/// </java-name>
				[Dot42.DexImport("dispatchUnhandledMove", "(Landroid/view/View;I)Z", AccessFlags = 1)]
				public virtual bool DispatchUnhandledMove(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getFocusables
				/// </java-name>
				[Dot42.DexImport("getFocusables", "(I)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(I)Ljava/util/ArrayList<Landroid/view/View;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Views.View> GetFocusables(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Views.View>);
				}

				/// <java-name>
				/// addFocusables
				/// </java-name>
				[Dot42.DexImport("addFocusables", "(Ljava/util/ArrayList;I)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;I)V")]
				public virtual void AddFocusables(global::Java.Util.ArrayList<global::Android.Views.View> arrayList, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFocusables
				/// </java-name>
				[Dot42.DexImport("addFocusables", "(Ljava/util/ArrayList;II)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;II)V")]
				public virtual void AddFocusables(global::Java.Util.ArrayList<global::Android.Views.View> arrayList, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findViewsWithText
				/// </java-name>
				[Dot42.DexImport("findViewsWithText", "(Ljava/util/ArrayList;Ljava/lang/CharSequence;I)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;Ljava/lang/CharSequence;I)V")]
				public virtual void FindViewsWithText(global::Java.Util.ArrayList<global::Android.Views.View> arrayList, global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addTouchables
				/// </java-name>
				[Dot42.DexImport("addTouchables", "(Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;)V")]
				public virtual void AddTouchables(global::Java.Util.ArrayList<global::Android.Views.View> arrayList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "()Z", AccessFlags = 17)]
				public bool RequestFocus() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "(I)Z", AccessFlags = 17)]
				public bool RequestFocus(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "(ILandroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool RequestFocus(int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestFocusFromTouch
				/// </java-name>
				[Dot42.DexImport("requestFocusFromTouch", "()Z", AccessFlags = 17)]
				public bool RequestFocusFromTouch() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onStartTemporaryDetach
				/// </java-name>
				[Dot42.DexImport("onStartTemporaryDetach", "()V", AccessFlags = 1)]
				public virtual void OnStartTemporaryDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishTemporaryDetach
				/// </java-name>
				[Dot42.DexImport("onFinishTemporaryDetach", "()V", AccessFlags = 1)]
				public virtual void OnFinishTemporaryDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEventPreIme
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyEventPreIme(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyShortcutEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyShortcutEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onFilterTouchEventForSecurity
				/// </java-name>
				[Dot42.DexImport("onFilterTouchEventForSecurity", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnFilterTouchEventForSecurity(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchHoverEvent
				/// </java-name>
				[Dot42.DexImport("dispatchHoverEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 4)]
				protected internal virtual bool DispatchHoverEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchGenericPointerEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericPointerEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 4)]
				protected internal virtual bool DispatchGenericPointerEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchGenericFocusedEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericFocusedEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 4)]
				protected internal virtual bool DispatchGenericFocusedEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void DispatchWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal virtual void DispatchVisibilityChanged(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal virtual void OnVisibilityChanged(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDisplayHint
				/// </java-name>
				[Dot42.DexImport("dispatchDisplayHint", "(I)V", AccessFlags = 1)]
				public virtual void DispatchDisplayHint(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisplayHint
				/// </java-name>
				[Dot42.DexImport("onDisplayHint", "(I)V", AccessFlags = 4)]
				protected internal virtual void OnDisplayHint(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowVisibilityChanged", "(I)V", AccessFlags = 1)]
				public virtual void DispatchWindowVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal virtual void OnWindowVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getWindowVisibleDisplayFrame
				/// </java-name>
				[Dot42.DexImport("getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetWindowVisibleDisplayFrame(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void DispatchConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 4)]
				protected internal virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onKeyPreIme
				/// </java-name>
				[Dot42.DexImport("onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyPreIme(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
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
				/// onKeyLongPress
				/// </java-name>
				[Dot42.DexImport("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyLongPress(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
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
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyMultiple(int int32, int int321, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onKeyShortcut
				/// </java-name>
				[Dot42.DexImport("onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyShortcut(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCheckIsTextEditor
				/// </java-name>
				[Dot42.DexImport("onCheckIsTextEditor", "()Z", AccessFlags = 1)]
				public virtual bool OnCheckIsTextEditor() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onCreateInputConnection
				/// </java-name>
				[Dot42.DexImport("onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;" +
    "", AccessFlags = 1)]
				public virtual global::Android.Views.Inputmethod.IInputConnection OnCreateInputConnection(global::Android.Views.Inputmethod.EditorInfo editorInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.IInputConnection);
				}

				/// <java-name>
				/// checkInputConnectionProxy
				/// </java-name>
				[Dot42.DexImport("checkInputConnectionProxy", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool CheckInputConnectionProxy(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// createContextMenu
				/// </java-name>
				[Dot42.DexImport("createContextMenu", "(Landroid/view/ContextMenu;)V", AccessFlags = 1)]
				public virtual void CreateContextMenu(global::Android.Views.IContextMenu contextMenu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;)V", AccessFlags = 4)]
				protected internal virtual void OnCreateContextMenu(global::Android.Views.IContextMenu contextMenu) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("onGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onHoverEvent
				/// </java-name>
				[Dot42.DexImport("onHoverEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnHoverEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onHoverChanged
				/// </java-name>
				[Dot42.DexImport("onHoverChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnHoverChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cancelLongPress
				/// </java-name>
				[Dot42.DexImport("cancelLongPress", "()V", AccessFlags = 1)]
				public virtual void CancelLongPress() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bringToFront
				/// </java-name>
				[Dot42.DexImport("bringToFront", "()V", AccessFlags = 1)]
				public virtual void BringToFront() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onScrollChanged
				/// </java-name>
				[Dot42.DexImport("onScrollChanged", "(IIII)V", AccessFlags = 4)]
				protected internal virtual void OnScrollChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal virtual void OnSizeChanged(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal virtual void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDrawingRect
				/// </java-name>
				[Dot42.DexImport("getDrawingRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetDrawingRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCameraDistance
				/// </java-name>
				[Dot42.DexImport("setCameraDistance", "(F)V", AccessFlags = 1)]
				public virtual void SetCameraDistance(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getHitRect
				/// </java-name>
				[Dot42.DexImport("getHitRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetHitRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getFocusedRect
				/// </java-name>
				[Dot42.DexImport("getFocusedRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetFocusedRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getGlobalVisibleRect
				/// </java-name>
				[Dot42.DexImport("getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z", AccessFlags = 1)]
				public virtual bool GetGlobalVisibleRect(global::Android.Graphics.Rect rect, global::Android.Graphics.Point point) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getGlobalVisibleRect
				/// </java-name>
				[Dot42.DexImport("getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z", AccessFlags = 17)]
				public bool GetGlobalVisibleRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLocalVisibleRect
				/// </java-name>
				[Dot42.DexImport("getLocalVisibleRect", "(Landroid/graphics/Rect;)Z", AccessFlags = 17)]
				public bool GetLocalVisibleRect(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// offsetTopAndBottom
				/// </java-name>
				[Dot42.DexImport("offsetTopAndBottom", "(I)V", AccessFlags = 1)]
				public virtual void OffsetTopAndBottom(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offsetLeftAndRight
				/// </java-name>
				[Dot42.DexImport("offsetLeftAndRight", "(I)V", AccessFlags = 1)]
				public virtual void OffsetLeftAndRight(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollTo
				/// </java-name>
				[Dot42.DexImport("scrollTo", "(II)V", AccessFlags = 1)]
				public virtual void ScrollTo(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scrollBy
				/// </java-name>
				[Dot42.DexImport("scrollBy", "(II)V", AccessFlags = 1)]
				public virtual void ScrollBy(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// awakenScrollBars
				/// </java-name>
				[Dot42.DexImport("awakenScrollBars", "()Z", AccessFlags = 4)]
				protected internal virtual bool AwakenScrollBars() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// awakenScrollBars
				/// </java-name>
				[Dot42.DexImport("awakenScrollBars", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool AwakenScrollBars(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// awakenScrollBars
				/// </java-name>
				[Dot42.DexImport("awakenScrollBars", "(IZ)Z", AccessFlags = 4)]
				protected internal virtual bool AwakenScrollBars(int int32, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void Invalidate(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "(IIII)V", AccessFlags = 1)]
				public virtual void Invalidate(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "()V", AccessFlags = 1)]
				public virtual void Invalidate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// post
				/// </java-name>
				[Dot42.DexImport("post", "(Ljava/lang/Runnable;)Z", AccessFlags = 1)]
				public virtual bool Post(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postDelayed
				/// </java-name>
				[Dot42.DexImport("postDelayed", "(Ljava/lang/Runnable;J)Z", AccessFlags = 1)]
				public virtual bool PostDelayed(global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeCallbacks
				/// </java-name>
				[Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;)Z", AccessFlags = 1)]
				public virtual bool RemoveCallbacks(global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// postInvalidate
				/// </java-name>
				[Dot42.DexImport("postInvalidate", "()V", AccessFlags = 1)]
				public virtual void PostInvalidate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// postInvalidate
				/// </java-name>
				[Dot42.DexImport("postInvalidate", "(IIII)V", AccessFlags = 1)]
				public virtual void PostInvalidate(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// postInvalidateDelayed
				/// </java-name>
				[Dot42.DexImport("postInvalidateDelayed", "(J)V", AccessFlags = 1)]
				public virtual void PostInvalidateDelayed(long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// postInvalidateDelayed
				/// </java-name>
				[Dot42.DexImport("postInvalidateDelayed", "(JIIII)V", AccessFlags = 1)]
				public virtual void PostInvalidateDelayed(long int64, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public virtual void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollOffset", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeHorizontalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeHorizontalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollExtent", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeHorizontalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// canScrollHorizontally
				/// </java-name>
				[Dot42.DexImport("canScrollHorizontally", "(I)Z", AccessFlags = 1)]
				public virtual bool CanScrollHorizontally(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// canScrollVertically
				/// </java-name>
				[Dot42.DexImport("canScrollVertically", "(I)Z", AccessFlags = 1)]
				public virtual bool CanScrollVertically(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onDrawScrollBars
				/// </java-name>
				[Dot42.DexImport("onDrawScrollBars", "(Landroid/graphics/Canvas;)V", AccessFlags = 20)]
				protected internal void OnDrawScrollBars(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal virtual void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal virtual void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// saveHierarchyState
				/// </java-name>
				[Dot42.DexImport("saveHierarchyState", "(Landroid/util/SparseArray;)V", AccessFlags = 1, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				public virtual void SaveHierarchyState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal virtual void DispatchSaveInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
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
				[Dot42.DexImport("restoreHierarchyState", "(Landroid/util/SparseArray;)V", AccessFlags = 1, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				public virtual void RestoreHierarchyState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal virtual void DispatchRestoreInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal virtual void OnRestoreInstanceState(global::Android.OS.IParcelable parcelable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLayerType
				/// </java-name>
				[Dot42.DexImport("setLayerType", "(ILandroid/graphics/Paint;)V", AccessFlags = 1)]
				public virtual void SetLayerType(int int32, global::Android.Graphics.Paint paint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// buildLayer
				/// </java-name>
				[Dot42.DexImport("buildLayer", "()V", AccessFlags = 1)]
				public virtual void BuildLayer() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDrawingCache
				/// </java-name>
				[Dot42.DexImport("getDrawingCache", "(Z)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetDrawingCache(bool boolean) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <java-name>
				/// destroyDrawingCache
				/// </java-name>
				[Dot42.DexImport("destroyDrawingCache", "()V", AccessFlags = 1)]
				public virtual void DestroyDrawingCache() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// buildDrawingCache
				/// </java-name>
				[Dot42.DexImport("buildDrawingCache", "()V", AccessFlags = 1)]
				public virtual void BuildDrawingCache() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// buildDrawingCache
				/// </java-name>
				[Dot42.DexImport("buildDrawingCache", "(Z)V", AccessFlags = 1)]
				public virtual void BuildDrawingCache(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// layout
				/// </java-name>
				[Dot42.DexImport("layout", "(IIII)V", AccessFlags = 1)]
				public virtual void Layout(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal virtual void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal virtual void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawables.Drawable drawable, global::Java.Lang.IRunnable runnable, long int64) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawables.Drawable drawable, global::Java.Lang.IRunnable runnable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal virtual bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal virtual void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// refreshDrawableState
				/// </java-name>
				[Dot42.DexImport("refreshDrawableState", "()V", AccessFlags = 1)]
				public virtual void RefreshDrawableState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal virtual int[] OnCreateDrawableState(int int32) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// mergeDrawableStates
				/// </java-name>
				[Dot42.DexImport("mergeDrawableStates", "([I[I)[I", AccessFlags = 12)]
				protected internal static int[] MergeDrawableStates(int[] int32, int[] int321) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public virtual void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBackgroundColor
				/// </java-name>
				[Dot42.DexImport("setBackgroundColor", "(I)V", AccessFlags = 1)]
				public virtual void SetBackgroundColor(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBackgroundResource
				/// </java-name>
				[Dot42.DexImport("setBackgroundResource", "(I)V", AccessFlags = 1)]
				public virtual void SetBackgroundResource(int int32) /* MethodBuilder.Create */ 
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
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public virtual void SetPadding(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetSelected
				/// </java-name>
				[Dot42.DexImport("dispatchSetSelected", "(Z)V", AccessFlags = 4)]
				protected internal virtual void DispatchSetSelected(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetActivated
				/// </java-name>
				[Dot42.DexImport("dispatchSetActivated", "(Z)V", AccessFlags = 4)]
				protected internal virtual void DispatchSetActivated(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocationOnScreen
				/// </java-name>
				[Dot42.DexImport("getLocationOnScreen", "([I)V", AccessFlags = 1)]
				public virtual void GetLocationOnScreen(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocationInWindow
				/// </java-name>
				[Dot42.DexImport("getLocationInWindow", "([I)V", AccessFlags = 1)]
				public virtual void GetLocationInWindow(int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findViewById
				/// </java-name>
				[Dot42.DexImport("findViewById", "(I)Landroid/view/View;", AccessFlags = 17)]
				public global::Android.Views.View FindViewById(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// findViewWithTag
				/// </java-name>
				[Dot42.DexImport("findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;", AccessFlags = 17)]
				public global::Android.Views.View FindViewWithTag(object @object) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				[Dot42.DexImport("getTag", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetTag(int int32) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// setTag
				/// </java-name>
				[Dot42.DexImport("setTag", "(ILjava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetTag(int int32, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public virtual void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// forceLayout
				/// </java-name>
				[Dot42.DexImport("forceLayout", "()V", AccessFlags = 1)]
				public virtual void ForceLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// measure
				/// </java-name>
				[Dot42.DexImport("measure", "(II)V", AccessFlags = 17)]
				public void Measure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal virtual void OnMeasure(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMeasuredDimension
				/// </java-name>
				[Dot42.DexImport("setMeasuredDimension", "(II)V", AccessFlags = 20)]
				protected internal void SetMeasuredDimension(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// combineMeasuredStates
				/// </java-name>
				[Dot42.DexImport("combineMeasuredStates", "(II)I", AccessFlags = 9)]
				public static int CombineMeasuredStates(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// resolveSize
				/// </java-name>
				[Dot42.DexImport("resolveSize", "(II)I", AccessFlags = 9)]
				public static int ResolveSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// resolveSizeAndState
				/// </java-name>
				[Dot42.DexImport("resolveSizeAndState", "(III)I", AccessFlags = 9)]
				public static int ResolveSizeAndState(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getDefaultSize
				/// </java-name>
				[Dot42.DexImport("getDefaultSize", "(II)I", AccessFlags = 9)]
				public static int GetDefaultSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setMinimumHeight
				/// </java-name>
				[Dot42.DexImport("setMinimumHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetMinimumHeight(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMinimumWidth
				/// </java-name>
				[Dot42.DexImport("setMinimumWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMinimumWidth(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startAnimation
				/// </java-name>
				[Dot42.DexImport("startAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public virtual void StartAnimation(global::Android.Views.Animations.Animation animation) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearAnimation
				/// </java-name>
				[Dot42.DexImport("clearAnimation", "()V", AccessFlags = 1)]
				public virtual void ClearAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationStart
				/// </java-name>
				[Dot42.DexImport("onAnimationStart", "()V", AccessFlags = 4)]
				protected internal virtual void OnAnimationStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationEnd
				/// </java-name>
				[Dot42.DexImport("onAnimationEnd", "()V", AccessFlags = 4)]
				protected internal virtual void OnAnimationEnd() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onSetAlpha
				/// </java-name>
				[Dot42.DexImport("onSetAlpha", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool OnSetAlpha(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// playSoundEffect
				/// </java-name>
				[Dot42.DexImport("playSoundEffect", "(I)V", AccessFlags = 1)]
				public virtual void PlaySoundEffect(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performHapticFeedback
				/// </java-name>
				[Dot42.DexImport("performHapticFeedback", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformHapticFeedback(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// performHapticFeedback
				/// </java-name>
				[Dot42.DexImport("performHapticFeedback", "(II)Z", AccessFlags = 1)]
				public virtual bool PerformHapticFeedback(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOnSystemUiVisibilityChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnSystemUiVisibilityChangeListener", "(Landroid/view/View$OnSystemUiVisibilityChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnSystemUiVisibilityChangeListener(global::Android.Views.View.IOnSystemUiVisibilityChangeListener onSystemUiVisibilityChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSystemUiVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchSystemUiVisibilityChanged", "(I)V", AccessFlags = 1)]
				public virtual void DispatchSystemUiVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startDrag
				/// </java-name>
				[Dot42.DexImport("startDrag", "(Landroid/content/ClipData;Landroid/view/View$DragShadowBuilder;Ljava/lang/Object" +
    ";I)Z", AccessFlags = 17)]
				public bool StartDrag(global::Android.Content.ClipData clipData, global::Android.Views.View.DragShadowBuilder dragShadowBuilder, object @object, int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onDragEvent
				/// </java-name>
				[Dot42.DexImport("onDragEvent", "(Landroid/view/DragEvent;)Z", AccessFlags = 1)]
				public virtual bool OnDragEvent(global::Android.Views.DragEvent dragEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchDragEvent
				/// </java-name>
				[Dot42.DexImport("dispatchDragEvent", "(Landroid/view/DragEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchDragEvent(global::Android.Views.DragEvent dragEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 9)]
				public static global::Android.Views.View Inflate(global::Android.Content.Context context, int int32, global::Android.Views.ViewGroup viewGroup) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// overScrollBy
				/// </java-name>
				[Dot42.DexImport("overScrollBy", "(IIIIIIIIZ)Z", AccessFlags = 4)]
				protected internal virtual bool OverScrollBy(int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal virtual void OnOverScrolled(int int32, int int321, bool boolean, bool boolean1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// animate
				/// </java-name>
				[Dot42.DexImport("animate", "()Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator Animate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal View() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getVerticalFadingEdgeLength
				/// </java-name>
				public virtual int VerticalFadingEdgeLength
				{
						[Dot42.DexImport("getVerticalFadingEdgeLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHorizontalFadingEdgeLength
				/// </java-name>
				public virtual int HorizontalFadingEdgeLength
				{
						[Dot42.DexImport("getHorizontalFadingEdgeLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getVerticalScrollbarWidth
				/// </java-name>
				public virtual int VerticalScrollbarWidth
				{
						[Dot42.DexImport("getVerticalScrollbarWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHorizontalScrollbarHeight
				/// </java-name>
				protected internal virtual int HorizontalScrollbarHeight
				{
						[Dot42.DexImport("getHorizontalScrollbarHeight", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getVerticalScrollbarPosition
				/// </java-name>
				public virtual int VerticalScrollbarPosition
				{
						[Dot42.DexImport("getVerticalScrollbarPosition", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setVerticalScrollbarPosition", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOnFocusChangeListener
				/// </java-name>
				public virtual global::Android.Views.View.IOnFocusChangeListener OnFocusChangeListener
				{
						[Dot42.DexImport("getOnFocusChangeListener", "()Landroid/view/View$OnFocusChangeListener;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View.IOnFocusChangeListener); }
						[Dot42.DexImport("setOnFocusChangeListener", "(Landroid/view/View$OnFocusChangeListener;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasOnClickListeners
				/// </java-name>
				public virtual bool HasOnClickListeners
				{
						[Dot42.DexImport("hasOnClickListeners", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasFocus
				/// </java-name>
				public virtual bool HasFocus
				{
						[Dot42.DexImport("hasFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasFocusable
				/// </java-name>
				public virtual bool HasFocusable
				{
						[Dot42.DexImport("hasFocusable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getContentDescription
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence ContentDescription
				{
						[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isFocused
				/// </java-name>
				public virtual bool IsFocused
				{
						[Dot42.DexImport("isFocused", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getDrawingCacheQuality
				/// </java-name>
				public virtual int DrawingCacheQuality
				{
						[Dot42.DexImport("getDrawingCacheQuality", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDrawingCacheQuality", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getKeepScreenOn
				/// </java-name>
				public virtual bool IsKeepScreenOn
				{
						[Dot42.DexImport("getKeepScreenOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setKeepScreenOn", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNextFocusLeftId
				/// </java-name>
				public virtual int NextFocusLeftId
				{
						[Dot42.DexImport("getNextFocusLeftId", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNextFocusLeftId", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNextFocusRightId
				/// </java-name>
				public virtual int NextFocusRightId
				{
						[Dot42.DexImport("getNextFocusRightId", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNextFocusRightId", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNextFocusUpId
				/// </java-name>
				public virtual int NextFocusUpId
				{
						[Dot42.DexImport("getNextFocusUpId", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNextFocusUpId", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNextFocusDownId
				/// </java-name>
				public virtual int NextFocusDownId
				{
						[Dot42.DexImport("getNextFocusDownId", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNextFocusDownId", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getNextFocusForwardId
				/// </java-name>
				public virtual int NextFocusForwardId
				{
						[Dot42.DexImport("getNextFocusForwardId", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setNextFocusForwardId", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isShown
				/// </java-name>
				public virtual bool IsShown
				{
						[Dot42.DexImport("isShown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getVisibility
				/// </java-name>
				public virtual int Visibility
				{
						[Dot42.DexImport("getVisibility", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setVisibility", "(I)V", AccessFlags = 1)]
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
				/// isSoundEffectsEnabled
				/// </java-name>
				public virtual bool IsSoundEffectsEnabled
				{
						[Dot42.DexImport("isSoundEffectsEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSoundEffectsEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isHapticFeedbackEnabled
				/// </java-name>
				public virtual bool IsHapticFeedbackEnabled
				{
						[Dot42.DexImport("isHapticFeedbackEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setHapticFeedbackEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isClickable
				/// </java-name>
				public virtual bool IsClickable
				{
						[Dot42.DexImport("isClickable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setClickable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isLongClickable
				/// </java-name>
				public virtual bool IsLongClickable
				{
						[Dot42.DexImport("isLongClickable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setLongClickable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isPressed
				/// </java-name>
				public virtual bool IsPressed
				{
						[Dot42.DexImport("isPressed", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPressed", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSaveEnabled
				/// </java-name>
				public virtual bool IsSaveEnabled
				{
						[Dot42.DexImport("isSaveEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSaveEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFilterTouchesWhenObscured
				/// </java-name>
				public virtual bool IsFilterTouchesWhenObscured
				{
						[Dot42.DexImport("getFilterTouchesWhenObscured", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFilterTouchesWhenObscured", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isSaveFromParentEnabled
				/// </java-name>
				public virtual bool IsSaveFromParentEnabled
				{
						[Dot42.DexImport("isSaveFromParentEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSaveFromParentEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isFocusable
				/// </java-name>
				public virtual bool IsFocusable
				{
						[Dot42.DexImport("isFocusable", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isFocusableInTouchMode
				/// </java-name>
				public virtual bool IsFocusableInTouchMode
				{
						[Dot42.DexImport("isFocusableInTouchMode", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
						[Dot42.DexImport("setFocusableInTouchMode", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTouchables
				/// </java-name>
				public virtual global::Java.Util.ArrayList<global::Android.Views.View> Touchables
				{
						[Dot42.DexImport("getTouchables", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/view/View;>;")]
						get{ return default(global::Java.Util.ArrayList<global::Android.Views.View>); }
				}

				/// <java-name>
				/// getKeyDispatcherState
				/// </java-name>
				public virtual global::Android.Views.KeyEvent.DispatcherState KeyDispatcherState
				{
						[Dot42.DexImport("getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", AccessFlags = 1)]
						get{ return default(global::Android.Views.KeyEvent.DispatcherState); }
				}

				/// <java-name>
				/// hasWindowFocus
				/// </java-name>
				public virtual bool HasWindowFocus
				{
						[Dot42.DexImport("hasWindowFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getWindowVisibility
				/// </java-name>
				public virtual int WindowVisibility
				{
						[Dot42.DexImport("getWindowVisibility", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isInTouchMode
				/// </java-name>
				public virtual bool IsInTouchMode
				{
						[Dot42.DexImport("isInTouchMode", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// getContextMenuInfo
				/// </java-name>
				protected internal virtual global::Android.Views.IContextMenu_IContextMenuInfo ContextMenuInfo
				{
						[Dot42.DexImport("getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", AccessFlags = 4)]
						get{ return default(global::Android.Views.IContextMenu_IContextMenuInfo); }
				}

				/// <java-name>
				/// isHovered
				/// </java-name>
				public virtual bool IsHovered
				{
						[Dot42.DexImport("isHovered", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setHovered", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTouchDelegate
				/// </java-name>
				public virtual global::Android.Views.TouchDelegate TouchDelegate
				{
						[Dot42.DexImport("getTouchDelegate", "()Landroid/view/TouchDelegate;", AccessFlags = 1)]
						get{ return default(global::Android.Views.TouchDelegate); }
						[Dot42.DexImport("setTouchDelegate", "(Landroid/view/TouchDelegate;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Android.Views.IViewParent Parent
				{
						[Dot42.DexImport("getParent", "()Landroid/view/ViewParent;", AccessFlags = 17)]
						get{ return default(global::Android.Views.IViewParent); }
				}

				/// <java-name>
				/// getScrollX
				/// </java-name>
				public virtual int ScrollX
				{
						[Dot42.DexImport("getScrollX", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setScrollX", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getScrollY
				/// </java-name>
				public virtual int ScrollY
				{
						[Dot42.DexImport("getScrollY", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setScrollY", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMeasuredWidth
				/// </java-name>
				public int MeasuredWidth
				{
						[Dot42.DexImport("getMeasuredWidth", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMeasuredWidthAndState
				/// </java-name>
				public int MeasuredWidthAndState
				{
						[Dot42.DexImport("getMeasuredWidthAndState", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMeasuredHeight
				/// </java-name>
				public int MeasuredHeight
				{
						[Dot42.DexImport("getMeasuredHeight", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMeasuredHeightAndState
				/// </java-name>
				public int MeasuredHeightAndState
				{
						[Dot42.DexImport("getMeasuredHeightAndState", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMeasuredState
				/// </java-name>
				public int MeasuredState
				{
						[Dot42.DexImport("getMeasuredState", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMatrix
				/// </java-name>
				public virtual global::Android.Graphics.Matrix Matrix
				{
						[Dot42.DexImport("getMatrix", "()Landroid/graphics/Matrix;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Matrix); }
				}

				/// <java-name>
				/// getRotation
				/// </java-name>
				public virtual float Rotation
				{
						[Dot42.DexImport("getRotation", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setRotation", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRotationY
				/// </java-name>
				public virtual float RotationY
				{
						[Dot42.DexImport("getRotationY", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setRotationY", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRotationX
				/// </java-name>
				public virtual float RotationX
				{
						[Dot42.DexImport("getRotationX", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setRotationX", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getScaleX
				/// </java-name>
				public virtual float ScaleX
				{
						[Dot42.DexImport("getScaleX", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setScaleX", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getScaleY
				/// </java-name>
				public virtual float ScaleY
				{
						[Dot42.DexImport("getScaleY", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setScaleY", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPivotX
				/// </java-name>
				public virtual float PivotX
				{
						[Dot42.DexImport("getPivotX", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setPivotX", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPivotY
				/// </java-name>
				public virtual float PivotY
				{
						[Dot42.DexImport("getPivotY", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setPivotY", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAlpha
				/// </java-name>
				public virtual float Alpha
				{
						[Dot42.DexImport("getAlpha", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setAlpha", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTop
				/// </java-name>
				public int Top
				{
						[Dot42.DexImport("getTop", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setTop", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getBottom
				/// </java-name>
				public int Bottom
				{
						[Dot42.DexImport("getBottom", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setBottom", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// isDirty
				/// </java-name>
				public virtual bool IsDirty
				{
						[Dot42.DexImport("isDirty", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLeft
				/// </java-name>
				public int Left
				{
						[Dot42.DexImport("getLeft", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setLeft", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getRight
				/// </java-name>
				public int Right
				{
						[Dot42.DexImport("getRight", "()I", AccessFlags = 17)]
						get{ return default(int); }
						[Dot42.DexImport("setRight", "(I)V", AccessFlags = 17)]
						set{ }
				}

				/// <java-name>
				/// getX
				/// </java-name>
				public virtual float X
				{
						[Dot42.DexImport("getX", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setX", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getY
				/// </java-name>
				public virtual float Y
				{
						[Dot42.DexImport("getY", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setY", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTranslationX
				/// </java-name>
				public virtual float TranslationX
				{
						[Dot42.DexImport("getTranslationX", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setTranslationX", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTranslationY
				/// </java-name>
				public virtual float TranslationY
				{
						[Dot42.DexImport("getTranslationY", "()F", AccessFlags = 1)]
						get{ return default(float); }
						[Dot42.DexImport("setTranslationY", "(F)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLayoutParams
				/// </java-name>
				public virtual global::Android.Views.ViewGroup.LayoutParams LayoutParameters
				{
						[Dot42.DexImport("getLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 1)]
						get{ return default(global::Android.Views.ViewGroup.LayoutParams); }
						[Dot42.DexImport("setLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isOpaque
				/// </java-name>
				public virtual bool IsOpaque
				{
						[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getHandler
				/// </java-name>
				public virtual global::Android.OS.Handler Handler
				{
						[Dot42.DexImport("getHandler", "()Landroid/os/Handler;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Handler); }
				}

				/// <java-name>
				/// isHorizontalFadingEdgeEnabled
				/// </java-name>
				public virtual bool IsHorizontalFadingEdgeEnabled
				{
						[Dot42.DexImport("isHorizontalFadingEdgeEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setHorizontalFadingEdgeEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isVerticalFadingEdgeEnabled
				/// </java-name>
				public virtual bool IsVerticalFadingEdgeEnabled
				{
						[Dot42.DexImport("isVerticalFadingEdgeEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setVerticalFadingEdgeEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTopFadingEdgeStrength
				/// </java-name>
				protected internal virtual float TopFadingEdgeStrength
				{
						[Dot42.DexImport("getTopFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getBottomFadingEdgeStrength
				/// </java-name>
				protected internal virtual float BottomFadingEdgeStrength
				{
						[Dot42.DexImport("getBottomFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getLeftFadingEdgeStrength
				/// </java-name>
				protected internal virtual float LeftFadingEdgeStrength
				{
						[Dot42.DexImport("getLeftFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// getRightFadingEdgeStrength
				/// </java-name>
				protected internal virtual float RightFadingEdgeStrength
				{
						[Dot42.DexImport("getRightFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <java-name>
				/// isHorizontalScrollBarEnabled
				/// </java-name>
				public virtual bool IsHorizontalScrollBarEnabled
				{
						[Dot42.DexImport("isHorizontalScrollBarEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setHorizontalScrollBarEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isVerticalScrollBarEnabled
				/// </java-name>
				public virtual bool IsVerticalScrollBarEnabled
				{
						[Dot42.DexImport("isVerticalScrollBarEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setVerticalScrollBarEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isScrollbarFadingEnabled
				/// </java-name>
				public virtual bool IsScrollbarFadingEnabled
				{
						[Dot42.DexImport("isScrollbarFadingEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setScrollbarFadingEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getScrollBarStyle
				/// </java-name>
				public virtual int ScrollBarStyle
				{
						[Dot42.DexImport("getScrollBarStyle", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setScrollBarStyle", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getWindowAttachCount
				/// </java-name>
				protected internal virtual int WindowAttachCount
				{
						[Dot42.DexImport("getWindowAttachCount", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getWindowToken
				/// </java-name>
				public virtual global::Android.OS.IBinder WindowToken
				{
						[Dot42.DexImport("getWindowToken", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IBinder); }
				}

				/// <java-name>
				/// getApplicationWindowToken
				/// </java-name>
				public virtual global::Android.OS.IBinder ApplicationWindowToken
				{
						[Dot42.DexImport("getApplicationWindowToken", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IBinder); }
				}

				/// <java-name>
				/// getDrawingTime
				/// </java-name>
				public virtual long DrawingTime
				{
						[Dot42.DexImport("getDrawingTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// isDuplicateParentStateEnabled
				/// </java-name>
				public virtual bool IsDuplicateParentStateEnabled
				{
						[Dot42.DexImport("isDuplicateParentStateEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setDuplicateParentStateEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLayerType
				/// </java-name>
				public virtual int LayerType
				{
						[Dot42.DexImport("getLayerType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isDrawingCacheEnabled
				/// </java-name>
				public virtual bool IsDrawingCacheEnabled
				{
						[Dot42.DexImport("isDrawingCacheEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setDrawingCacheEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getDrawingCache
				/// </java-name>
				public virtual global::Android.Graphics.Bitmap DrawingCache
				{
						[Dot42.DexImport("getDrawingCache", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Bitmap); }
				}

				/// <java-name>
				/// getDrawingCacheBackgroundColor
				/// </java-name>
				public virtual int DrawingCacheBackgroundColor
				{
						[Dot42.DexImport("getDrawingCacheBackgroundColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDrawingCacheBackgroundColor", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isInEditMode
				/// </java-name>
				public virtual bool IsInEditMode
				{
						[Dot42.DexImport("isInEditMode", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isPaddingOffsetRequired
				/// </java-name>
				protected internal virtual bool IsPaddingOffsetRequired
				{
						[Dot42.DexImport("isPaddingOffsetRequired", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLeftPaddingOffset
				/// </java-name>
				protected internal virtual int LeftPaddingOffset
				{
						[Dot42.DexImport("getLeftPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getRightPaddingOffset
				/// </java-name>
				protected internal virtual int RightPaddingOffset
				{
						[Dot42.DexImport("getRightPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTopPaddingOffset
				/// </java-name>
				protected internal virtual int TopPaddingOffset
				{
						[Dot42.DexImport("getTopPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getBottomPaddingOffset
				/// </java-name>
				protected internal virtual int BottomPaddingOffset
				{
						[Dot42.DexImport("getBottomPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isHardwareAccelerated
				/// </java-name>
				public virtual bool IsHardwareAccelerated
				{
						[Dot42.DexImport("isHardwareAccelerated", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getSolidColor
				/// </java-name>
				public virtual int SolidColor
				{
						[Dot42.DexImport("getSolidColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isLayoutRequested
				/// </java-name>
				public virtual bool IsLayoutRequested
				{
						[Dot42.DexImport("isLayoutRequested", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getResources
				/// </java-name>
				public virtual global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

				/// <java-name>
				/// getDrawableState
				/// </java-name>
				public int[] DrawableState
				{
						[Dot42.DexImport("getDrawableState", "()[I", AccessFlags = 17)]
						get{ return default(int[]); }
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
				/// getPaddingTop
				/// </java-name>
				public virtual int PaddingTop
				{
						[Dot42.DexImport("getPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPaddingBottom
				/// </java-name>
				public virtual int PaddingBottom
				{
						[Dot42.DexImport("getPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPaddingLeft
				/// </java-name>
				public virtual int PaddingLeft
				{
						[Dot42.DexImport("getPaddingLeft", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPaddingRight
				/// </java-name>
				public virtual int PaddingRight
				{
						[Dot42.DexImport("getPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isSelected
				/// </java-name>
				public virtual bool IsSelected
				{
						[Dot42.DexImport("isSelected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setSelected", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isActivated
				/// </java-name>
				public virtual bool IsActivated
				{
						[Dot42.DexImport("isActivated", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setActivated", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getViewTreeObserver
				/// </java-name>
				public virtual global::Android.Views.ViewTreeObserver ViewTreeObserver
				{
						[Dot42.DexImport("getViewTreeObserver", "()Landroid/view/ViewTreeObserver;", AccessFlags = 1)]
						get{ return default(global::Android.Views.ViewTreeObserver); }
				}

				/// <java-name>
				/// getRootView
				/// </java-name>
				public virtual global::Android.Views.View RootView
				{
						[Dot42.DexImport("getRootView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getId
				/// </java-name>
				public virtual int Id
				{
						[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setId", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTag
				/// </java-name>
				public virtual object Tag
				{
						[Dot42.DexImport("getTag", "()Ljava/lang/Object;", AccessFlags = 1)]
						get{ return default(object); }
						[Dot42.DexImport("setTag", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getBaseline
				/// </java-name>
				public virtual int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSuggestedMinimumHeight
				/// </java-name>
				protected internal virtual int SuggestedMinimumHeight
				{
						[Dot42.DexImport("getSuggestedMinimumHeight", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getSuggestedMinimumWidth
				/// </java-name>
				protected internal virtual int SuggestedMinimumWidth
				{
						[Dot42.DexImport("getSuggestedMinimumWidth", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getAnimation
				/// </java-name>
				public virtual global::Android.Views.Animations.Animation Animation
				{
						[Dot42.DexImport("getAnimation", "()Landroid/view/animation/Animation;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.Animation); }
						[Dot42.DexImport("setAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSystemUiVisibility
				/// </java-name>
				public virtual int SystemUiVisibility
				{
						[Dot42.DexImport("getSystemUiVisibility", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setSystemUiVisibility", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getOverScrollMode
				/// </java-name>
				public virtual int OverScrollMode
				{
						[Dot42.DexImport("getOverScrollMode", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setOverScrollMode", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// android/view/View$AccessibilityDelegate
				/// </java-name>
				[Dot42.DexImport("android/view/View$AccessibilityDelegate", AccessFlags = 9)]
				public partial class AccessibilityDelegate
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public AccessibilityDelegate() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// sendAccessibilityEvent
						/// </java-name>
						[Dot42.DexImport("sendAccessibilityEvent", "(Landroid/view/View;I)V", AccessFlags = 1)]
						public virtual void SendAccessibilityEvent(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// sendAccessibilityEventUnchecked
						/// </java-name>
						[Dot42.DexImport("sendAccessibilityEventUnchecked", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
						public virtual void SendAccessibilityEventUnchecked(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// dispatchPopulateAccessibilityEvent
						/// </java-name>
						[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
						public virtual bool DispatchPopulateAccessibilityEvent(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// onPopulateAccessibilityEvent
						/// </java-name>
						[Dot42.DexImport("onPopulateAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
						public virtual void OnPopulateAccessibilityEvent(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onInitializeAccessibilityEvent
						/// </java-name>
						[Dot42.DexImport("onInitializeAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
						public virtual void OnInitializeAccessibilityEvent(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onInitializeAccessibilityNodeInfo
						/// </java-name>
						[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
						public virtual void OnInitializeAccessibilityNodeInfo(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onRequestSendAccessibilityEvent
						/// </java-name>
						[Dot42.DexImport("onRequestSendAccessibilityEvent", "(Landroid/view/ViewGroup;Landroid/view/View;Landroid/view/accessibility/Accessibi" +
    "lityEvent;)Z", AccessFlags = 1)]
						public virtual bool OnRequestSendAccessibilityEvent(global::Android.Views.ViewGroup viewGroup, global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

				/// <java-name>
				/// android/view/View$BaseSavedState
				/// </java-name>
				[Dot42.DexImport("android/view/View$BaseSavedState", AccessFlags = 9)]
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
				/// android/view/View$OnAttachStateChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnAttachStateChangeListener", AccessFlags = 1545)]
				public partial interface IOnAttachStateChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onViewAttachedToWindow
						/// </java-name>
						[Dot42.DexImport("onViewAttachedToWindow", "(Landroid/view/View;)V", AccessFlags = 1025)]
						void OnViewAttachedToWindow(global::Android.Views.View view) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onViewDetachedFromWindow
						/// </java-name>
						[Dot42.DexImport("onViewDetachedFromWindow", "(Landroid/view/View;)V", AccessFlags = 1025)]
						void OnViewDetachedFromWindow(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnSystemUiVisibilityChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnSystemUiVisibilityChangeListener", AccessFlags = 1545)]
				public partial interface IOnSystemUiVisibilityChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onSystemUiVisibilityChange
						/// </java-name>
						[Dot42.DexImport("onSystemUiVisibilityChange", "(I)V", AccessFlags = 1025)]
						void OnSystemUiVisibilityChange(int int32) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnCreateContextMenuListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnCreateContextMenuListener", AccessFlags = 1545)]
				public partial interface IOnCreateContextMenuListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onCreateContextMenu
						/// </java-name>
						[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1025)]
						void OnCreateContextMenu(global::Android.Views.IContextMenu contextMenu, global::Android.Views.View view, global::Android.Views.IContextMenu_IContextMenuInfo contextMenu_IContextMenuInfo) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnClickListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnClickListener", AccessFlags = 1545)]
				public partial interface IOnClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onClick
						/// </java-name>
						[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1025)]
						void OnClick(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnFocusChangeListener", AccessFlags = 1545)]
				public partial interface IOnFocusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onFocusChange
						/// </java-name>
						[Dot42.DexImport("onFocusChange", "(Landroid/view/View;Z)V", AccessFlags = 1025)]
						void OnFocusChange(global::Android.Views.View view, bool boolean) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnDragListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnDragListener", AccessFlags = 1545)]
				public partial interface IOnDragListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onDrag
						/// </java-name>
						[Dot42.DexImport("onDrag", "(Landroid/view/View;Landroid/view/DragEvent;)Z", AccessFlags = 1025)]
						bool OnDrag(global::Android.Views.View view, global::Android.Views.DragEvent dragEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnLongClickListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnLongClickListener", AccessFlags = 1545)]
				public partial interface IOnLongClickListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onLongClick
						/// </java-name>
						[Dot42.DexImport("onLongClick", "(Landroid/view/View;)Z", AccessFlags = 1025)]
						bool OnLongClick(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnGenericMotionListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnGenericMotionListener", AccessFlags = 1545)]
				public partial interface IOnGenericMotionListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGenericMotion
						/// </java-name>
						[Dot42.DexImport("onGenericMotion", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnGenericMotion(global::Android.Views.View view, global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnHoverListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnHoverListener", AccessFlags = 1545)]
				public partial interface IOnHoverListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onHover
						/// </java-name>
						[Dot42.DexImport("onHover", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnHover(global::Android.Views.View view, global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnTouchListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnTouchListener", AccessFlags = 1545)]
				public partial interface IOnTouchListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTouch
						/// </java-name>
						[Dot42.DexImport("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnTouch(global::Android.Views.View view, global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$OnKeyListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnKeyListener", AccessFlags = 1545)]
				public partial interface IOnKeyListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onKey
						/// </java-name>
						[Dot42.DexImport("onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKey(global::Android.Views.View view, int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/View$MeasureSpec
				/// </java-name>
				[Dot42.DexImport("android/view/View$MeasureSpec", AccessFlags = 9)]
				public partial class MeasureSpec
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// UNSPECIFIED
						/// </java-name>
						[Dot42.DexImport("UNSPECIFIED", "I", AccessFlags = 25)]
						public const int UNSPECIFIED = 0;
						/// <java-name>
						/// EXACTLY
						/// </java-name>
						[Dot42.DexImport("EXACTLY", "I", AccessFlags = 25)]
						public const int EXACTLY = 1073741824;
						/// <java-name>
						/// AT_MOST
						/// </java-name>
						[Dot42.DexImport("AT_MOST", "I", AccessFlags = 25)]
						public const int AT_MOST = -2147483648;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public MeasureSpec() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// makeMeasureSpec
						/// </java-name>
						[Dot42.DexImport("makeMeasureSpec", "(II)I", AccessFlags = 9)]
						public static int MakeMeasureSpec(int int32, int int321) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getMode
						/// </java-name>
						[Dot42.DexImport("getMode", "(I)I", AccessFlags = 9)]
						public static int GetMode(int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getSize
						/// </java-name>
						[Dot42.DexImport("getSize", "(I)I", AccessFlags = 9)]
						public static int GetSize(int int32) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
						public static string ToString(int int32) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

				/// <java-name>
				/// android/view/View$DragShadowBuilder
				/// </java-name>
				[Dot42.DexImport("android/view/View$DragShadowBuilder", AccessFlags = 9)]
				public partial class DragShadowBuilder
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Landroid/view/View;)V", AccessFlags = 1)]
						public DragShadowBuilder(global::Android.Views.View view) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public DragShadowBuilder() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onProvideShadowMetrics
						/// </java-name>
						[Dot42.DexImport("onProvideShadowMetrics", "(Landroid/graphics/Point;Landroid/graphics/Point;)V", AccessFlags = 1)]
						public virtual void OnProvideShadowMetrics(global::Android.Graphics.Point point, global::Android.Graphics.Point point1) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onDrawShadow
						/// </java-name>
						[Dot42.DexImport("onDrawShadow", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
						public virtual void OnDrawShadow(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getView
						/// </java-name>
						public global::Android.Views.View View
						{
								[Dot42.DexImport("getView", "()Landroid/view/View;", AccessFlags = 17)]
								get{ return default(global::Android.Views.View); }
						}

				}

				/// <java-name>
				/// android/view/View$OnLayoutChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnLayoutChangeListener", AccessFlags = 1545)]
				public partial interface IOnLayoutChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onLayoutChange
						/// </java-name>
						[Dot42.DexImport("onLayoutChange", "(Landroid/view/View;IIIIIIII)V", AccessFlags = 1025)]
						void OnLayoutChange(global::Android.Views.View view, int int32, int int321, int int322, int int323, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/ViewConfiguration
		/// </java-name>
		[Dot42.DexImport("android/view/ViewConfiguration", AccessFlags = 33)]
		public partial class ViewConfiguration
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ViewConfiguration() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;", AccessFlags = 9)]
				public static global::Android.Views.ViewConfiguration Get(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewConfiguration);
				}

				/// <java-name>
				/// getScrollBarSize
				/// </java-name>
				public static int ScrollBarSize
				{
						[Dot42.DexImport("getScrollBarSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledScrollBarSize
				/// </java-name>
				public virtual int ScaledScrollBarSize
				{
						[Dot42.DexImport("getScaledScrollBarSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScrollBarFadeDuration
				/// </java-name>
				public static int ScrollBarFadeDuration
				{
						[Dot42.DexImport("getScrollBarFadeDuration", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScrollDefaultDelay
				/// </java-name>
				public static int ScrollDefaultDelay
				{
						[Dot42.DexImport("getScrollDefaultDelay", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getFadingEdgeLength
				/// </java-name>
				public static int FadingEdgeLength
				{
						[Dot42.DexImport("getFadingEdgeLength", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledFadingEdgeLength
				/// </java-name>
				public virtual int ScaledFadingEdgeLength
				{
						[Dot42.DexImport("getScaledFadingEdgeLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getPressedStateDuration
				/// </java-name>
				public static int PressedStateDuration
				{
						[Dot42.DexImport("getPressedStateDuration", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLongPressTimeout
				/// </java-name>
				public static int LongPressTimeout
				{
						[Dot42.DexImport("getLongPressTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getKeyRepeatTimeout
				/// </java-name>
				public static int KeyRepeatTimeout
				{
						[Dot42.DexImport("getKeyRepeatTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getKeyRepeatDelay
				/// </java-name>
				public static int KeyRepeatDelay
				{
						[Dot42.DexImport("getKeyRepeatDelay", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTapTimeout
				/// </java-name>
				public static int TapTimeout
				{
						[Dot42.DexImport("getTapTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getJumpTapTimeout
				/// </java-name>
				public static int JumpTapTimeout
				{
						[Dot42.DexImport("getJumpTapTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getDoubleTapTimeout
				/// </java-name>
				public static int DoubleTapTimeout
				{
						[Dot42.DexImport("getDoubleTapTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEdgeSlop
				/// </java-name>
				public static int EdgeSlop
				{
						[Dot42.DexImport("getEdgeSlop", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledEdgeSlop
				/// </java-name>
				public virtual int ScaledEdgeSlop
				{
						[Dot42.DexImport("getScaledEdgeSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getTouchSlop
				/// </java-name>
				public static int TouchSlop
				{
						[Dot42.DexImport("getTouchSlop", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledTouchSlop
				/// </java-name>
				public virtual int ScaledTouchSlop
				{
						[Dot42.DexImport("getScaledTouchSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledPagingTouchSlop
				/// </java-name>
				public virtual int ScaledPagingTouchSlop
				{
						[Dot42.DexImport("getScaledPagingTouchSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledDoubleTapSlop
				/// </java-name>
				public virtual int ScaledDoubleTapSlop
				{
						[Dot42.DexImport("getScaledDoubleTapSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getWindowTouchSlop
				/// </java-name>
				public static int WindowTouchSlop
				{
						[Dot42.DexImport("getWindowTouchSlop", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledWindowTouchSlop
				/// </java-name>
				public virtual int ScaledWindowTouchSlop
				{
						[Dot42.DexImport("getScaledWindowTouchSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMinimumFlingVelocity
				/// </java-name>
				public static int MinimumFlingVelocity
				{
						[Dot42.DexImport("getMinimumFlingVelocity", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledMinimumFlingVelocity
				/// </java-name>
				public virtual int ScaledMinimumFlingVelocity
				{
						[Dot42.DexImport("getScaledMinimumFlingVelocity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMaximumFlingVelocity
				/// </java-name>
				public static int MaximumFlingVelocity
				{
						[Dot42.DexImport("getMaximumFlingVelocity", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledMaximumFlingVelocity
				/// </java-name>
				public virtual int ScaledMaximumFlingVelocity
				{
						[Dot42.DexImport("getScaledMaximumFlingVelocity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getMaximumDrawingCacheSize
				/// </java-name>
				public static int MaximumDrawingCacheSize
				{
						[Dot42.DexImport("getMaximumDrawingCacheSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledMaximumDrawingCacheSize
				/// </java-name>
				public virtual int ScaledMaximumDrawingCacheSize
				{
						[Dot42.DexImport("getScaledMaximumDrawingCacheSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledOverscrollDistance
				/// </java-name>
				public virtual int ScaledOverscrollDistance
				{
						[Dot42.DexImport("getScaledOverscrollDistance", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getScaledOverflingDistance
				/// </java-name>
				public virtual int ScaledOverflingDistance
				{
						[Dot42.DexImport("getScaledOverflingDistance", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getZoomControlsTimeout
				/// </java-name>
				public static long ZoomControlsTimeout
				{
						[Dot42.DexImport("getZoomControlsTimeout", "()J", AccessFlags = 9)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getGlobalActionKeyTimeout
				/// </java-name>
				public static long GlobalActionKeyTimeout
				{
						[Dot42.DexImport("getGlobalActionKeyTimeout", "()J", AccessFlags = 9)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getScrollFriction
				/// </java-name>
				public static float ScrollFriction
				{
						[Dot42.DexImport("getScrollFriction", "()F", AccessFlags = 9)]
						get{ return default(float); }
				}

				/// <java-name>
				/// hasPermanentMenuKey
				/// </java-name>
				public virtual bool HasPermanentMenuKey
				{
						[Dot42.DexImport("hasPermanentMenuKey", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// android/view/ViewDebug
		/// </java-name>
		[Dot42.DexImport("android/view/ViewDebug", AccessFlags = 33)]
		public partial class ViewDebug
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// TRACE_HIERARCHY
				/// </java-name>
				[Dot42.DexImport("TRACE_HIERARCHY", "Z", AccessFlags = 25)]
				public const bool TRACE_HIERARCHY = false;
				/// <java-name>
				/// TRACE_RECYCLER
				/// </java-name>
				[Dot42.DexImport("TRACE_RECYCLER", "Z", AccessFlags = 25)]
				public const bool TRACE_RECYCLER = false;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ViewDebug() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V", AccessFlags = 137)]
				public static void Trace(global::Android.Views.View view, global::Android.Views.ViewDebug.RecyclerTraceType recyclerTraceType, params int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startRecyclerTracing
				/// </java-name>
				[Dot42.DexImport("startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V", AccessFlags = 9)]
				public static void StartRecyclerTracing(string @string, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopRecyclerTracing
				/// </java-name>
				[Dot42.DexImport("stopRecyclerTracing", "()V", AccessFlags = 9)]
				public static void StopRecyclerTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V", AccessFlags = 9)]
				public static void Trace(global::Android.Views.View view, global::Android.Views.ViewDebug.HierarchyTraceType hierarchyTraceType) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startHierarchyTracing
				/// </java-name>
				[Dot42.DexImport("startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V", AccessFlags = 9)]
				public static void StartHierarchyTracing(string @string, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopHierarchyTracing
				/// </java-name>
				[Dot42.DexImport("stopHierarchyTracing", "()V", AccessFlags = 9)]
				public static void StopHierarchyTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dumpCapturedView
				/// </java-name>
				[Dot42.DexImport("dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void DumpCapturedView(string @string, object @object) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/view/ViewDebug$RecyclerTraceType
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$RecyclerTraceType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/view/ViewDebug$RecyclerTraceType;>;")]
				public sealed class RecyclerTraceType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BIND_VIEW
						/// </java-name>
						[Dot42.DexImport("BIND_VIEW", "Landroid/view/ViewDebug$RecyclerTraceType;", AccessFlags = 16409)]
						public static readonly RecyclerTraceType BIND_VIEW;
						/// <java-name>
						/// MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
						/// </java-name>
						[Dot42.DexImport("MOVE_FROM_ACTIVE_TO_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;", AccessFlags = 16409)]
						public static readonly RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP;
						/// <java-name>
						/// MOVE_TO_SCRAP_HEAP
						/// </java-name>
						[Dot42.DexImport("MOVE_TO_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;", AccessFlags = 16409)]
						public static readonly RecyclerTraceType MOVE_TO_SCRAP_HEAP;
						/// <java-name>
						/// NEW_VIEW
						/// </java-name>
						[Dot42.DexImport("NEW_VIEW", "Landroid/view/ViewDebug$RecyclerTraceType;", AccessFlags = 16409)]
						public static readonly RecyclerTraceType NEW_VIEW;
						/// <java-name>
						/// RECYCLE_FROM_ACTIVE_HEAP
						/// </java-name>
						[Dot42.DexImport("RECYCLE_FROM_ACTIVE_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;", AccessFlags = 16409)]
						public static readonly RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP;
						/// <java-name>
						/// RECYCLE_FROM_SCRAP_HEAP
						/// </java-name>
						[Dot42.DexImport("RECYCLE_FROM_SCRAP_HEAP", "Landroid/view/ViewDebug$RecyclerTraceType;", AccessFlags = 16409)]
						public static readonly RecyclerTraceType RECYCLE_FROM_SCRAP_HEAP;
						private RecyclerTraceType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/view/ViewDebug$RecyclerTraceType;", AccessFlags = 9)]
						public static RecyclerTraceType[] Values() /* MethodBuilder.Create */ 
						{
								return default(RecyclerTraceType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;", AccessFlags = 9)]
						public static RecyclerTraceType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(RecyclerTraceType);
						}

				}

				/// <java-name>
				/// android/view/ViewDebug$HierarchyTraceType
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$HierarchyTraceType", AccessFlags = 16409, Signature = "Ljava/lang/Enum<Landroid/view/ViewDebug$HierarchyTraceType;>;")]
				public sealed class HierarchyTraceType
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// BUILD_CACHE
						/// </java-name>
						[Dot42.DexImport("BUILD_CACHE", "Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 16409)]
						public static readonly HierarchyTraceType BUILD_CACHE;
						/// <java-name>
						/// DRAW
						/// </java-name>
						[Dot42.DexImport("DRAW", "Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 16409)]
						public static readonly HierarchyTraceType DRAW;
						/// <java-name>
						/// INVALIDATE
						/// </java-name>
						[Dot42.DexImport("INVALIDATE", "Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 16409)]
						public static readonly HierarchyTraceType INVALIDATE;
						/// <java-name>
						/// INVALIDATE_CHILD
						/// </java-name>
						[Dot42.DexImport("INVALIDATE_CHILD", "Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 16409)]
						public static readonly HierarchyTraceType INVALIDATE_CHILD;
						/// <java-name>
						/// INVALIDATE_CHILD_IN_PARENT
						/// </java-name>
						[Dot42.DexImport("INVALIDATE_CHILD_IN_PARENT", "Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 16409)]
						public static readonly HierarchyTraceType INVALIDATE_CHILD_IN_PARENT;
						/// <java-name>
						/// ON_LAYOUT
						/// </java-name>
						[Dot42.DexImport("ON_LAYOUT", "Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 16409)]
						public static readonly HierarchyTraceType ON_LAYOUT;
						/// <java-name>
						/// ON_MEASURE
						/// </java-name>
						[Dot42.DexImport("ON_MEASURE", "Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 16409)]
						public static readonly HierarchyTraceType ON_MEASURE;
						/// <java-name>
						/// REQUEST_LAYOUT
						/// </java-name>
						[Dot42.DexImport("REQUEST_LAYOUT", "Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 16409)]
						public static readonly HierarchyTraceType REQUEST_LAYOUT;
						private HierarchyTraceType() /* TypeBuilder.AddPrivateDefaultCtor */ 
						{
						}

						/// <java-name>
						/// values
						/// </java-name>
						[Dot42.DexImport("values", "()[Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 9)]
						public static HierarchyTraceType[] Values() /* MethodBuilder.Create */ 
						{
								return default(HierarchyTraceType[]);
						}

						/// <java-name>
						/// valueOf
						/// </java-name>
						[Dot42.DexImport("valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;", AccessFlags = 9)]
						public static HierarchyTraceType ValueOf(string @string) /* MethodBuilder.Create */ 
						{
								return default(HierarchyTraceType);
						}

				}

				/// <java-name>
				/// android/view/ViewDebug$CapturedViewProperty
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$CapturedViewProperty", AccessFlags = 9737)]
				public partial interface ICapturedViewProperty : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// retrieveReturn
						/// </java-name>
						[Dot42.DexImport("retrieveReturn", "()Z", AccessFlags = 1025)]
						bool RetrieveReturn() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/ViewDebug$FlagToString
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$FlagToString", AccessFlags = 9737)]
				public partial interface IFlagToString : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// mask
						/// </java-name>
						[Dot42.DexImport("mask", "()I", AccessFlags = 1025)]
						int Mask() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// equals
						/// </java-name>
						[Dot42.DexImport("equals", "()I", AccessFlags = 1025)]
						int Equals() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// name
						/// </java-name>
						[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 1025)]
						string Name() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// outputIf
						/// </java-name>
						[Dot42.DexImport("outputIf", "()Z", AccessFlags = 1025)]
						bool OutputIf() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/ViewDebug$IntToString
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$IntToString", AccessFlags = 9737)]
				public partial interface IIntToString : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// from
						/// </java-name>
						[Dot42.DexImport("from", "()I", AccessFlags = 1025)]
						int From() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// to
						/// </java-name>
						[Dot42.DexImport("to", "()Ljava/lang/String;", AccessFlags = 1025)]
						string To() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/ViewDebug$ExportedProperty
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$ExportedProperty", AccessFlags = 9737)]
				public partial interface IExportedProperty : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// resolveId
						/// </java-name>
						[Dot42.DexImport("resolveId", "()Z", AccessFlags = 1025)]
						bool ResolveId() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// mapping
						/// </java-name>
						[Dot42.DexImport("mapping", "()[Landroid/view/ViewDebug$IntToString;", AccessFlags = 1025)]
						global::Android.Views.ViewDebug.IIntToString[] Mapping() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// indexMapping
						/// </java-name>
						[Dot42.DexImport("indexMapping", "()[Landroid/view/ViewDebug$IntToString;", AccessFlags = 1025)]
						global::Android.Views.ViewDebug.IIntToString[] IndexMapping() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// flagMapping
						/// </java-name>
						[Dot42.DexImport("flagMapping", "()[Landroid/view/ViewDebug$FlagToString;", AccessFlags = 1025)]
						global::Android.Views.ViewDebug.IFlagToString[] FlagMapping() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// deepExport
						/// </java-name>
						[Dot42.DexImport("deepExport", "()Z", AccessFlags = 1025)]
						bool DeepExport() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// prefix
						/// </java-name>
						[Dot42.DexImport("prefix", "()Ljava/lang/String;", AccessFlags = 1025)]
						string Prefix() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// category
						/// </java-name>
						[Dot42.DexImport("category", "()Ljava/lang/String;", AccessFlags = 1025)]
						string Category() /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/ViewGroup
		/// </java-name>
		[Dot42.DexImport("android/view/ViewGroup", AccessFlags = 1057)]
		public abstract partial class ViewGroup : global::Android.Views.View, global::Android.Views.IViewParent, global::Android.Views.IViewManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FOCUS_BEFORE_DESCENDANTS
				/// </java-name>
				[Dot42.DexImport("FOCUS_BEFORE_DESCENDANTS", "I", AccessFlags = 25)]
				public const int FOCUS_BEFORE_DESCENDANTS = 131072;
				/// <java-name>
				/// FOCUS_AFTER_DESCENDANTS
				/// </java-name>
				[Dot42.DexImport("FOCUS_AFTER_DESCENDANTS", "I", AccessFlags = 25)]
				public const int FOCUS_AFTER_DESCENDANTS = 262144;
				/// <java-name>
				/// FOCUS_BLOCK_DESCENDANTS
				/// </java-name>
				[Dot42.DexImport("FOCUS_BLOCK_DESCENDANTS", "I", AccessFlags = 25)]
				public const int FOCUS_BLOCK_DESCENDANTS = 393216;
				/// <java-name>
				/// PERSISTENT_NO_CACHE
				/// </java-name>
				[Dot42.DexImport("PERSISTENT_NO_CACHE", "I", AccessFlags = 25)]
				public const int PERSISTENT_NO_CACHE = 0;
				/// <java-name>
				/// PERSISTENT_ANIMATION_CACHE
				/// </java-name>
				[Dot42.DexImport("PERSISTENT_ANIMATION_CACHE", "I", AccessFlags = 25)]
				public const int PERSISTENT_ANIMATION_CACHE = 1;
				/// <java-name>
				/// PERSISTENT_SCROLLING_CACHE
				/// </java-name>
				[Dot42.DexImport("PERSISTENT_SCROLLING_CACHE", "I", AccessFlags = 25)]
				public const int PERSISTENT_SCROLLING_CACHE = 2;
				/// <java-name>
				/// PERSISTENT_ALL_CACHES
				/// </java-name>
				[Dot42.DexImport("PERSISTENT_ALL_CACHES", "I", AccessFlags = 25)]
				public const int PERSISTENT_ALL_CACHES = 3;
				/// <java-name>
				/// CLIP_TO_PADDING_MASK
				/// </java-name>
				[Dot42.DexImport("CLIP_TO_PADDING_MASK", "I", AccessFlags = 28)]
				protected internal const int CLIP_TO_PADDING_MASK = 34;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ViewGroup(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ViewGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestChildFocus
				/// </java-name>
				[Dot42.DexImport("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RequestChildFocus(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// focusableViewAvailable
				/// </java-name>
				[Dot42.DexImport("focusableViewAvailable", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void FocusableViewAvailable(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// showContextMenuForChild
				/// </java-name>
				[Dot42.DexImport("showContextMenuForChild", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool ShowContextMenuForChild(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// startActionModeForChild
				/// </java-name>
				[Dot42.DexImport("startActionModeForChild", "(Landroid/view/View;Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1)]
				public virtual global::Android.Views.ActionMode StartActionModeForChild(global::Android.Views.View view, global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ActionMode);
				}

				/// <java-name>
				/// focusSearch
				/// </java-name>
				[Dot42.DexImport("focusSearch", "(Landroid/view/View;I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FocusSearch(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public virtual bool RequestChildRectangleOnScreen(global::Android.Views.View view, global::Android.Graphics.Rect rect, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestSendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("requestSendAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public virtual bool RequestSendAccessibilityEvent(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onRequestSendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onRequestSendAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public virtual bool OnRequestSendAccessibilityEvent(global::Android.Views.View view, global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// clearChildFocus
				/// </java-name>
				[Dot42.DexImport("clearChildFocus", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void ClearChildFocus(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearFocus
				/// </java-name>
				[Dot42.DexImport("clearFocus", "()V", AccessFlags = 1)]
				public override void ClearFocus() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findFocus
				/// </java-name>
				[Dot42.DexImport("findFocus", "()Landroid/view/View;", AccessFlags = 1)]
				public override global::Android.Views.View FindFocus() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// addFocusables
				/// </java-name>
				[Dot42.DexImport("addFocusables", "(Ljava/util/ArrayList;I)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;I)V")]
				public override void AddFocusables(global::Java.Util.ArrayList<global::Android.Views.View> arrayList, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFocusables
				/// </java-name>
				[Dot42.DexImport("addFocusables", "(Ljava/util/ArrayList;II)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;II)V")]
				public override void AddFocusables(global::Java.Util.ArrayList<global::Android.Views.View> arrayList, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findViewsWithText
				/// </java-name>
				[Dot42.DexImport("findViewsWithText", "(Ljava/util/ArrayList;Ljava/lang/CharSequence;I)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;Ljava/lang/CharSequence;I)V")]
				public override void FindViewsWithText(global::Java.Util.ArrayList<global::Android.Views.View> arrayList, global::Java.Lang.ICharSequence charSequence, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void DispatchWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addTouchables
				/// </java-name>
				[Dot42.DexImport("addTouchables", "(Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;)V")]
				public override void AddTouchables(global::Java.Util.ArrayList<global::Android.Views.View> arrayList) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDisplayHint
				/// </java-name>
				[Dot42.DexImport("dispatchDisplayHint", "(I)V", AccessFlags = 1)]
				public override void DispatchDisplayHint(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void DispatchVisibilityChanged(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowVisibilityChanged", "(I)V", AccessFlags = 1)]
				public override void DispatchWindowVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public override void DispatchConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// recomputeViewAttributes
				/// </java-name>
				[Dot42.DexImport("recomputeViewAttributes", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RecomputeViewAttributes(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// bringChildToFront
				/// </java-name>
				[Dot42.DexImport("bringChildToFront", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void BringChildToFront(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDragEvent
				/// </java-name>
				[Dot42.DexImport("dispatchDragEvent", "(Landroid/view/DragEvent;)Z", AccessFlags = 1)]
				public override bool DispatchDragEvent(global::Android.Views.DragEvent dragEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchSystemUiVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchSystemUiVisibilityChanged", "(I)V", AccessFlags = 1)]
				public override void DispatchSystemUiVisibilityChanged(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEventPreIme
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEventPreIme(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
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
				/// dispatchKeyShortcutEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyShortcutEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ 
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
				/// dispatchHoverEvent
				/// </java-name>
				[Dot42.DexImport("dispatchHoverEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 4)]
				protected internal override bool DispatchHoverEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onInterceptHoverEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptHoverEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnInterceptHoverEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchGenericPointerEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericPointerEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 4)]
				protected internal override bool DispatchGenericPointerEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchGenericFocusedEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericFocusedEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 4)]
				protected internal override bool DispatchGenericFocusedEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
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
				/// requestDisallowInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("requestDisallowInterceptTouchEvent", "(Z)V", AccessFlags = 1)]
				public virtual void RequestDisallowInterceptTouchEvent(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnInterceptTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "(ILandroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool RequestFocus(int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onRequestFocusInDescendants
				/// </java-name>
				[Dot42.DexImport("onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal virtual bool OnRequestFocusInDescendants(int int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public override void SetPadding(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
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
				/// dispatchFreezeSelfOnly
				/// </java-name>
				[Dot42.DexImport("dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal virtual void DispatchFreezeSelfOnly(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
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
				/// dispatchThawSelfOnly
				/// </java-name>
				[Dot42.DexImport("dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal virtual void DispatchThawSelfOnly(global::Android.Util.SparseArray<global::Android.OS.IParcelable> sparseArray) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChildrenDrawingCacheEnabled
				/// </java-name>
				[Dot42.DexImport("setChildrenDrawingCacheEnabled", "(Z)V", AccessFlags = 4)]
				protected internal virtual void SetChildrenDrawingCacheEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationStart
				/// </java-name>
				[Dot42.DexImport("onAnimationStart", "()V", AccessFlags = 4)]
				protected internal override void OnAnimationStart() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onAnimationEnd
				/// </java-name>
				[Dot42.DexImport("onAnimationEnd", "()V", AccessFlags = 4)]
				protected internal override void OnAnimationEnd() /* MethodBuilder.Create */ 
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
				/// getChildDrawingOrder
				/// </java-name>
				[Dot42.DexImport("getChildDrawingOrder", "(II)I", AccessFlags = 4)]
				protected internal virtual int GetChildDrawingOrder(int int32, int int321) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// drawChild
				/// </java-name>
				[Dot42.DexImport("drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", AccessFlags = 4)]
				protected internal virtual bool DrawChild(global::Android.Graphics.Canvas canvas, global::Android.Views.View view, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setClipChildren
				/// </java-name>
				[Dot42.DexImport("setClipChildren", "(Z)V", AccessFlags = 1)]
				public virtual void SetClipChildren(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setClipToPadding
				/// </java-name>
				[Dot42.DexImport("setClipToPadding", "(Z)V", AccessFlags = 1)]
				public virtual void SetClipToPadding(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetSelected
				/// </java-name>
				[Dot42.DexImport("dispatchSetSelected", "(Z)V", AccessFlags = 1)]
				public new virtual void DispatchSetSelected(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetActivated
				/// </java-name>
				[Dot42.DexImport("dispatchSetActivated", "(Z)V", AccessFlags = 1)]
				public new virtual void DispatchSetActivated(bool boolean) /* MethodBuilder.Create */ 
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
				/// setStaticTransformationsEnabled
				/// </java-name>
				[Dot42.DexImport("setStaticTransformationsEnabled", "(Z)V", AccessFlags = 4)]
				protected internal virtual void SetStaticTransformationsEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildStaticTransformation
				/// </java-name>
				[Dot42.DexImport("getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z", AccessFlags = 4)]
				protected internal virtual bool GetChildStaticTransformation(global::Android.Views.View view, global::Android.Views.Animations.Transformation transformation) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View view, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;II)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateViewLayout
				/// </java-name>
				[Dot42.DexImport("updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void UpdateViewLayout(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal virtual bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setOnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnHierarchyChangeListener(global::Android.Views.ViewGroup.IOnHierarchyChangeListener onHierarchyChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addViewInLayout
				/// </java-name>
				[Dot42.DexImport("addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal virtual bool AddViewInLayout(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addViewInLayout
				/// </java-name>
				[Dot42.DexImport("addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z", AccessFlags = 4)]
				protected internal virtual bool AddViewInLayout(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams, bool boolean) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// cleanupLayoutState
				/// </java-name>
				[Dot42.DexImport("cleanupLayoutState", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void CleanupLayoutState(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachLayoutAnimationParameters
				/// </java-name>
				[Dot42.DexImport("attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V", AccessFlags = 4)]
				protected internal virtual void AttachLayoutAnimationParameters(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeView
				/// </java-name>
				[Dot42.DexImport("removeView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RemoveView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewInLayout
				/// </java-name>
				[Dot42.DexImport("removeViewInLayout", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RemoveViewInLayout(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewsInLayout
				/// </java-name>
				[Dot42.DexImport("removeViewsInLayout", "(II)V", AccessFlags = 1)]
				public virtual void RemoveViewsInLayout(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViewAt
				/// </java-name>
				[Dot42.DexImport("removeViewAt", "(I)V", AccessFlags = 1)]
				public virtual void RemoveViewAt(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeViews
				/// </java-name>
				[Dot42.DexImport("removeViews", "(II)V", AccessFlags = 1)]
				public virtual void RemoveViews(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "()V", AccessFlags = 1)]
				public virtual void RemoveAllViews() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeAllViewsInLayout
				/// </java-name>
				[Dot42.DexImport("removeAllViewsInLayout", "()V", AccessFlags = 1)]
				public virtual void RemoveAllViewsInLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeDetachedView
				/// </java-name>
				[Dot42.DexImport("removeDetachedView", "(Landroid/view/View;Z)V", AccessFlags = 4)]
				protected internal virtual void RemoveDetachedView(global::Android.Views.View view, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachViewToParent
				/// </java-name>
				[Dot42.DexImport("attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 4)]
				protected internal virtual void AttachViewToParent(global::Android.Views.View view, int int32, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// detachViewFromParent
				/// </java-name>
				[Dot42.DexImport("detachViewFromParent", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void DetachViewFromParent(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// detachViewFromParent
				/// </java-name>
				[Dot42.DexImport("detachViewFromParent", "(I)V", AccessFlags = 4)]
				protected internal virtual void DetachViewFromParent(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// detachViewsFromParent
				/// </java-name>
				[Dot42.DexImport("detachViewsFromParent", "(II)V", AccessFlags = 4)]
				protected internal virtual void DetachViewsFromParent(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// detachAllViewsFromParent
				/// </java-name>
				[Dot42.DexImport("detachAllViewsFromParent", "()V", AccessFlags = 4)]
				protected internal virtual void DetachAllViewsFromParent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateChild
				/// </java-name>
				[Dot42.DexImport("invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V", AccessFlags = 17)]
				public void InvalidateChild(global::Android.Views.View view, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// invalidateChildInParent
				/// </java-name>
				[Dot42.DexImport("invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;", AccessFlags = 1)]
				public virtual global::Android.Views.IViewParent InvalidateChildInParent(int[] int32, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.IViewParent);
				}

				/// <java-name>
				/// offsetDescendantRectToMyCoords
				/// </java-name>
				[Dot42.DexImport("offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V", AccessFlags = 17)]
				public void OffsetDescendantRectToMyCoords(global::Android.Views.View view, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// offsetRectIntoDescendantCoords
				/// </java-name>
				[Dot42.DexImport("offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V", AccessFlags = 17)]
				public void OffsetRectIntoDescendantCoords(global::Android.Views.View view, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildVisibleRect
				/// </java-name>
				[Dot42.DexImport("getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z", AccessFlags = 1)]
				public virtual bool GetChildVisibleRect(global::Android.Views.View view, global::Android.Graphics.Rect rect, global::Android.Graphics.Point point) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// layout
				/// </java-name>
				[Dot42.DexImport("layout", "(IIII)V", AccessFlags = 17)]
				public override void Layout(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 1028)]
				protected internal override void OnLayout(bool boolean, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startLayoutAnimation
				/// </java-name>
				[Dot42.DexImport("startLayoutAnimation", "()V", AccessFlags = 1)]
				public virtual void StartLayoutAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// scheduleLayoutAnimation
				/// </java-name>
				[Dot42.DexImport("scheduleLayoutAnimation", "()V", AccessFlags = 1)]
				public virtual void ScheduleLayoutAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// generateDefaultLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.ViewGroup.LayoutParams GenerateDefaultLayoutParams() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <java-name>
				/// debug
				/// </java-name>
				[Dot42.DexImport("debug", "(I)V", AccessFlags = 4)]
				protected internal virtual void Debug(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// indexOfChild
				/// </java-name>
				[Dot42.DexImport("indexOfChild", "(Landroid/view/View;)I", AccessFlags = 1)]
				public virtual int IndexOfChild(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getChildAt
				/// </java-name>
				[Dot42.DexImport("getChildAt", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetChildAt(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// measureChildren
				/// </java-name>
				[Dot42.DexImport("measureChildren", "(II)V", AccessFlags = 4)]
				protected internal virtual void MeasureChildren(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// measureChild
				/// </java-name>
				[Dot42.DexImport("measureChild", "(Landroid/view/View;II)V", AccessFlags = 4)]
				protected internal virtual void MeasureChild(global::Android.Views.View view, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// measureChildWithMargins
				/// </java-name>
				[Dot42.DexImport("measureChildWithMargins", "(Landroid/view/View;IIII)V", AccessFlags = 4)]
				protected internal virtual void MeasureChildWithMargins(global::Android.Views.View view, int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChildMeasureSpec
				/// </java-name>
				[Dot42.DexImport("getChildMeasureSpec", "(III)I", AccessFlags = 9)]
				public static int GetChildMeasureSpec(int int32, int int321, int int322) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// clearDisappearingChildren
				/// </java-name>
				[Dot42.DexImport("clearDisappearingChildren", "()V", AccessFlags = 1)]
				public virtual void ClearDisappearingChildren() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startViewTransition
				/// </java-name>
				[Dot42.DexImport("startViewTransition", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void StartViewTransition(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// endViewTransition
				/// </java-name>
				[Dot42.DexImport("endViewTransition", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void EndViewTransition(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// gatherTransparentRegion
				/// </java-name>
				[Dot42.DexImport("gatherTransparentRegion", "(Landroid/graphics/Region;)Z", AccessFlags = 1)]
				public virtual bool GatherTransparentRegion(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// requestTransparentRegion
				/// </java-name>
				[Dot42.DexImport("requestTransparentRegion", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RequestTransparentRegion(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fitSystemWindows
				/// </java-name>
				[Dot42.DexImport("fitSystemWindows", "(Landroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal override bool FitSystemWindows(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
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
				/// jumpDrawablesToCurrentState
				/// </java-name>
				[Dot42.DexImport("jumpDrawablesToCurrentState", "()V", AccessFlags = 1)]
				public override void JumpDrawablesToCurrentState() /* MethodBuilder.Create */ 
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
				/// setAddStatesFromChildren
				/// </java-name>
				[Dot42.DexImport("setAddStatesFromChildren", "(Z)V", AccessFlags = 1)]
				public virtual void SetAddStatesFromChildren(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addStatesFromChildren
				/// </java-name>
				[Dot42.DexImport("addStatesFromChildren", "()Z", AccessFlags = 1)]
				public virtual bool AddStatesFromChildren() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// childDrawableStateChanged
				/// </java-name>
				[Dot42.DexImport("childDrawableStateChanged", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void ChildDrawableStateChanged(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetResolvedLayoutDirection
				/// </java-name>
				[Dot42.DexImport("resetResolvedLayoutDirection", "()V", AccessFlags = 4)]
				protected internal virtual void ResetResolvedLayoutDirection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// resetResolvedTextDirection
				/// </java-name>
				[Dot42.DexImport("resetResolvedTextDirection", "()V", AccessFlags = 4)]
				protected internal virtual void ResetResolvedTextDirection() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// shouldDelayChildPressedState
				/// </java-name>
				[Dot42.DexImport("shouldDelayChildPressedState", "()Z", AccessFlags = 1)]
				public virtual bool ShouldDelayChildPressedState() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ViewGroup() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("android/view/ViewParent", "requestLayout", "()V", AccessFlags = 1025)]
				public override void RequestLayout() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				[Dot42.DexImport("android/view/ViewParent", "createContextMenu", "(Landroid/view/ContextMenu;)V", AccessFlags = 1025)]
				public override void CreateContextMenu(global::Android.Views.IContextMenu contextMenu) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <java-name>
				/// getDescendantFocusability
				/// </java-name>
				public virtual int DescendantFocusability
				{
						[Dot42.DexImport("getDescendantFocusability", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setDescendantFocusability", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFocusedChild
				/// </java-name>
				public virtual global::Android.Views.View FocusedChild
				{
						[Dot42.DexImport("getFocusedChild", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// hasFocus
				/// </java-name>
				public override bool HasFocus
				{
						[Dot42.DexImport("hasFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// hasFocusable
				/// </java-name>
				public override bool HasFocusable
				{
						[Dot42.DexImport("hasFocusable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isMotionEventSplittingEnabled
				/// </java-name>
				public virtual bool IsMotionEventSplittingEnabled
				{
						[Dot42.DexImport("isMotionEventSplittingEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setMotionEventSplittingEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLayoutTransition
				/// </java-name>
				public virtual global::Android.Animation.LayoutTransition LayoutTransition
				{
						[Dot42.DexImport("getLayoutTransition", "()Landroid/animation/LayoutTransition;", AccessFlags = 1)]
						get{ return default(global::Android.Animation.LayoutTransition); }
						[Dot42.DexImport("setLayoutTransition", "(Landroid/animation/LayoutTransition;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// canAnimate
				/// </java-name>
				protected internal virtual bool CanAnimate
				{
						[Dot42.DexImport("canAnimate", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getLayoutAnimation
				/// </java-name>
				public virtual global::Android.Views.Animations.LayoutAnimationController LayoutAnimation
				{
						[Dot42.DexImport("getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.LayoutAnimationController); }
						[Dot42.DexImport("setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isAnimationCacheEnabled
				/// </java-name>
				public virtual bool IsAnimationCacheEnabled
				{
						[Dot42.DexImport("isAnimationCacheEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAnimationCacheEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isAlwaysDrawnWithCacheEnabled
				/// </java-name>
				public virtual bool IsAlwaysDrawnWithCacheEnabled
				{
						[Dot42.DexImport("isAlwaysDrawnWithCacheEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAlwaysDrawnWithCacheEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isChildrenDrawnWithCacheEnabled
				/// </java-name>
				protected internal virtual bool IsChildrenDrawnWithCacheEnabled
				{
						[Dot42.DexImport("isChildrenDrawnWithCacheEnabled", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
						[Dot42.DexImport("setChildrenDrawnWithCacheEnabled", "(Z)V", AccessFlags = 4)]
						set{ }
				}

				/// <java-name>
				/// isChildrenDrawingOrderEnabled
				/// </java-name>
				protected internal virtual bool IsChildrenDrawingOrderEnabled
				{
						[Dot42.DexImport("isChildrenDrawingOrderEnabled", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
						[Dot42.DexImport("setChildrenDrawingOrderEnabled", "(Z)V", AccessFlags = 4)]
						set{ }
				}

				/// <java-name>
				/// getPersistentDrawingCache
				/// </java-name>
				public virtual int PersistentDrawingCache
				{
						[Dot42.DexImport("getPersistentDrawingCache", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setPersistentDrawingCache", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getChildCount
				/// </java-name>
				public virtual int ChildCount
				{
						[Dot42.DexImport("getChildCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLayoutAnimationListener
				/// </java-name>
				public virtual global::Android.Views.Animations.Animation.IAnimationListener LayoutAnimationListener
				{
						[Dot42.DexImport("getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Animations.Animation.IAnimationListener); }
						[Dot42.DexImport("setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V", AccessFlags = 1)]
						set{ }
				}

				public override bool IsLayoutRequested
				{
						[Dot42.DexImport("android/view/ViewParent", "isLayoutRequested", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

				public new virtual global::Android.Views.IViewParent Parent
				{
						[Dot42.DexImport("android/view/ViewParent", "getParent", "()Landroid/view/ViewParent;", AccessFlags = 1025)]
						get{ return default(global::Android.Views.IViewParent); }
				}

				/// <java-name>
				/// android/view/ViewGroup$MarginLayoutParams
				/// </java-name>
				[Dot42.DexImport("android/view/ViewGroup$MarginLayoutParams", AccessFlags = 9)]
				public partial class MarginLayoutParams : global::Android.Views.ViewGroup.LayoutParams
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// leftMargin
						/// </java-name>
						[Dot42.DexImport("leftMargin", "I", AccessFlags = 1)]
						public int LeftMargin;
						/// <java-name>
						/// topMargin
						/// </java-name>
						[Dot42.DexImport("topMargin", "I", AccessFlags = 1)]
						public int TopMargin;
						/// <java-name>
						/// rightMargin
						/// </java-name>
						[Dot42.DexImport("rightMargin", "I", AccessFlags = 1)]
						public int RightMargin;
						/// <java-name>
						/// bottomMargin
						/// </java-name>
						[Dot42.DexImport("bottomMargin", "I", AccessFlags = 1)]
						public int BottomMargin;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public MarginLayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public MarginLayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", AccessFlags = 1)]
						public MarginLayoutParams(MarginLayoutParams marginLayoutParams) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public MarginLayoutParams(global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setMargins
						/// </java-name>
						[Dot42.DexImport("setMargins", "(IIII)V", AccessFlags = 1)]
						public virtual void SetMargins(int int32, int int321, int int322, int int323) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal MarginLayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/view/ViewGroup$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/view/ViewGroup$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// FILL_PARENT
						/// </java-name>
						[Dot42.DexImport("FILL_PARENT", "I", AccessFlags = 25)]
						public const int FILL_PARENT = -1;
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
						/// layoutAnimationParameters
						/// </java-name>
						[Dot42.DexImport("layoutAnimationParameters", "Landroid/view/animation/LayoutAnimationController$AnimationParameters;", AccessFlags = 1)]
						public global::Android.Views.Animations.LayoutAnimationController.AnimationParameters LayoutAnimationParameters;
						[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
						public LayoutParams(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
						public LayoutParams(int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
						public LayoutParams(LayoutParams layoutParams) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal virtual void SetBaseAttributes(global::Android.Content.Res.TypedArray typedArray, int int32, int int321) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <java-name>
				/// android/view/ViewGroup$OnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewGroup$OnHierarchyChangeListener", AccessFlags = 1545)]
				public partial interface IOnHierarchyChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onChildViewAdded
						/// </java-name>
						[Dot42.DexImport("onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1025)]
						void OnChildViewAdded(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onChildViewRemoved
						/// </java-name>
						[Dot42.DexImport("onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1025)]
						void OnChildViewRemoved(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/ViewPropertyAnimator
		/// </java-name>
		[Dot42.DexImport("android/view/ViewPropertyAnimator", AccessFlags = 33)]
		public partial class ViewPropertyAnimator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ViewPropertyAnimator() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDuration
				/// </java-name>
				[Dot42.DexImport("setDuration", "(J)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator SetDuration(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// setStartDelay
				/// </java-name>
				[Dot42.DexImport("setStartDelay", "(J)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator SetStartDelay(long int64) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// setInterpolator
				/// </java-name>
				[Dot42.DexImport("setInterpolator", "(Landroid/animation/TimeInterpolator;)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator SetInterpolator(global::Android.Animation.ITimeInterpolator timeInterpolator) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// setListener
				/// </java-name>
				[Dot42.DexImport("setListener", "(Landroid/animation/Animator$AnimatorListener;)Landroid/view/ViewPropertyAnimator" +
    ";", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator SetListener(global::Android.Animation.Animator.IAnimatorListener animatorListener) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// start
				/// </java-name>
				[Dot42.DexImport("start", "()V", AccessFlags = 1)]
				public virtual void Start() /* MethodBuilder.Create */ 
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
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator X(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// xBy
				/// </java-name>
				[Dot42.DexImport("xBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator XBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator Y(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// yBy
				/// </java-name>
				[Dot42.DexImport("yBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator YBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// rotation
				/// </java-name>
				[Dot42.DexImport("rotation", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator Rotation(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// rotationBy
				/// </java-name>
				[Dot42.DexImport("rotationBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator RotationBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// rotationX
				/// </java-name>
				[Dot42.DexImport("rotationX", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator RotationX(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// rotationXBy
				/// </java-name>
				[Dot42.DexImport("rotationXBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator RotationXBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// rotationY
				/// </java-name>
				[Dot42.DexImport("rotationY", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator RotationY(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// rotationYBy
				/// </java-name>
				[Dot42.DexImport("rotationYBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator RotationYBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// translationX
				/// </java-name>
				[Dot42.DexImport("translationX", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator TranslationX(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// translationXBy
				/// </java-name>
				[Dot42.DexImport("translationXBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator TranslationXBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// translationY
				/// </java-name>
				[Dot42.DexImport("translationY", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator TranslationY(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// translationYBy
				/// </java-name>
				[Dot42.DexImport("translationYBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator TranslationYBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// scaleX
				/// </java-name>
				[Dot42.DexImport("scaleX", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator ScaleX(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// scaleXBy
				/// </java-name>
				[Dot42.DexImport("scaleXBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator ScaleXBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// scaleY
				/// </java-name>
				[Dot42.DexImport("scaleY", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator ScaleY(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// scaleYBy
				/// </java-name>
				[Dot42.DexImport("scaleYBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator ScaleYBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// alpha
				/// </java-name>
				[Dot42.DexImport("alpha", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator Alpha(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// alphaBy
				/// </java-name>
				[Dot42.DexImport("alphaBy", "(F)Landroid/view/ViewPropertyAnimator;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewPropertyAnimator AlphaBy(float single) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewPropertyAnimator);
				}

				/// <java-name>
				/// getDuration
				/// </java-name>
				public virtual long Duration
				{
						[Dot42.DexImport("getDuration", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <java-name>
				/// getStartDelay
				/// </java-name>
				public virtual long StartDelay
				{
						[Dot42.DexImport("getStartDelay", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

		}

		/// <java-name>
		/// android/view/ViewStub
		/// </java-name>
		[Dot42.DexImport("android/view/ViewStub", AccessFlags = 49)]
		public sealed partial class ViewStub : global::Android.Views.View
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public ViewStub(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public ViewStub(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewStub(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ViewStub(global::Android.Content.Context context, global::Android.Util.IAttributeSet attributeSet, int int32) /* MethodBuilder.Create */ 
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
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public override void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
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
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "()Landroid/view/View;", AccessFlags = 1)]
				public global::Android.Views.View Inflate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setOnInflateListener
				/// </java-name>
				[Dot42.DexImport("setOnInflateListener", "(Landroid/view/ViewStub$OnInflateListener;)V", AccessFlags = 1)]
				public void SetOnInflateListener(global::Android.Views.ViewStub.IOnInflateListener onInflateListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ViewStub() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getInflatedId
				/// </java-name>
				public int InflatedId
				{
						[Dot42.DexImport("getInflatedId", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setInflatedId", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getLayoutResource
				/// </java-name>
				public int LayoutResource
				{
						[Dot42.DexImport("getLayoutResource", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setLayoutResource", "(I)V", AccessFlags = 1)]
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
				/// android/view/ViewStub$OnInflateListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewStub$OnInflateListener", AccessFlags = 1545)]
				public partial interface IOnInflateListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onInflate
						/// </java-name>
						[Dot42.DexImport("onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V", AccessFlags = 1025)]
						void OnInflate(global::Android.Views.ViewStub viewStub, global::Android.Views.View view) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/ViewTreeObserver
		/// </java-name>
		[Dot42.DexImport("android/view/ViewTreeObserver", AccessFlags = 49)]
		public sealed partial class ViewTreeObserver
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ViewTreeObserver() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnGlobalFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V", AccessFlags = 1)]
				public void AddOnGlobalFocusChangeListener(global::Android.Views.ViewTreeObserver.IOnGlobalFocusChangeListener onGlobalFocusChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnGlobalFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V", AccessFlags = 1)]
				public void RemoveOnGlobalFocusChangeListener(global::Android.Views.ViewTreeObserver.IOnGlobalFocusChangeListener onGlobalFocusChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnGlobalLayoutListener
				/// </java-name>
				[Dot42.DexImport("addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V", AccessFlags = 1)]
				public void AddOnGlobalLayoutListener(global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener onGlobalLayoutListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeGlobalOnLayoutListener
				/// </java-name>
				[Dot42.DexImport("removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V", AccessFlags = 1)]
				public void RemoveGlobalOnLayoutListener(global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener onGlobalLayoutListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnPreDrawListener
				/// </java-name>
				[Dot42.DexImport("addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V", AccessFlags = 1)]
				public void AddOnPreDrawListener(global::Android.Views.ViewTreeObserver.IOnPreDrawListener onPreDrawListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnPreDrawListener
				/// </java-name>
				[Dot42.DexImport("removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V", AccessFlags = 1)]
				public void RemoveOnPreDrawListener(global::Android.Views.ViewTreeObserver.IOnPreDrawListener onPreDrawListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnScrollChangedListener
				/// </java-name>
				[Dot42.DexImport("addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V", AccessFlags = 1)]
				public void AddOnScrollChangedListener(global::Android.Views.ViewTreeObserver.IOnScrollChangedListener onScrollChangedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnScrollChangedListener
				/// </java-name>
				[Dot42.DexImport("removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V", AccessFlags = 1)]
				public void RemoveOnScrollChangedListener(global::Android.Views.ViewTreeObserver.IOnScrollChangedListener onScrollChangedListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addOnTouchModeChangeListener
				/// </java-name>
				[Dot42.DexImport("addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V", AccessFlags = 1)]
				public void AddOnTouchModeChangeListener(global::Android.Views.ViewTreeObserver.IOnTouchModeChangeListener onTouchModeChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeOnTouchModeChangeListener
				/// </java-name>
				[Dot42.DexImport("removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V", AccessFlags = 1)]
				public void RemoveOnTouchModeChangeListener(global::Android.Views.ViewTreeObserver.IOnTouchModeChangeListener onTouchModeChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchOnGlobalLayout
				/// </java-name>
				[Dot42.DexImport("dispatchOnGlobalLayout", "()V", AccessFlags = 17)]
				public void DispatchOnGlobalLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchOnPreDraw
				/// </java-name>
				[Dot42.DexImport("dispatchOnPreDraw", "()Z", AccessFlags = 17)]
				public bool DispatchOnPreDraw() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isAlive
				/// </java-name>
				public bool IsAlive
				{
						[Dot42.DexImport("isAlive", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// android/view/ViewTreeObserver$OnScrollChangedListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnScrollChangedListener", AccessFlags = 1545)]
				public partial interface IOnScrollChangedListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onScrollChanged
						/// </java-name>
						[Dot42.DexImport("onScrollChanged", "()V", AccessFlags = 1025)]
						void OnScrollChanged() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/ViewTreeObserver$OnTouchModeChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnTouchModeChangeListener", AccessFlags = 1545)]
				public partial interface IOnTouchModeChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTouchModeChanged
						/// </java-name>
						[Dot42.DexImport("onTouchModeChanged", "(Z)V", AccessFlags = 1025)]
						void OnTouchModeChanged(bool boolean) /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/ViewTreeObserver$OnPreDrawListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnPreDrawListener", AccessFlags = 1545)]
				public partial interface IOnPreDrawListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onPreDraw
						/// </java-name>
						[Dot42.DexImport("onPreDraw", "()Z", AccessFlags = 1025)]
						bool OnPreDraw() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/ViewTreeObserver$OnGlobalLayoutListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnGlobalLayoutListener", AccessFlags = 1545)]
				public partial interface IOnGlobalLayoutListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGlobalLayout
						/// </java-name>
						[Dot42.DexImport("onGlobalLayout", "()V", AccessFlags = 1025)]
						void OnGlobalLayout() /* MethodBuilder.Create */ ;

				}

				/// <java-name>
				/// android/view/ViewTreeObserver$OnGlobalFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnGlobalFocusChangeListener", AccessFlags = 1545)]
				public partial interface IOnGlobalFocusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onGlobalFocusChanged
						/// </java-name>
						[Dot42.DexImport("onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1025)]
						void OnGlobalFocusChanged(global::Android.Views.View view, global::Android.Views.View view1) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/Window
		/// </java-name>
		[Dot42.DexImport("android/view/Window", AccessFlags = 1057)]
		public abstract partial class Window
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// FEATURE_OPTIONS_PANEL
				/// </java-name>
				[Dot42.DexImport("FEATURE_OPTIONS_PANEL", "I", AccessFlags = 25)]
				public const int FEATURE_OPTIONS_PANEL = 0;
				/// <java-name>
				/// FEATURE_NO_TITLE
				/// </java-name>
				[Dot42.DexImport("FEATURE_NO_TITLE", "I", AccessFlags = 25)]
				public const int FEATURE_NO_TITLE = 1;
				/// <java-name>
				/// FEATURE_PROGRESS
				/// </java-name>
				[Dot42.DexImport("FEATURE_PROGRESS", "I", AccessFlags = 25)]
				public const int FEATURE_PROGRESS = 2;
				/// <java-name>
				/// FEATURE_LEFT_ICON
				/// </java-name>
				[Dot42.DexImport("FEATURE_LEFT_ICON", "I", AccessFlags = 25)]
				public const int FEATURE_LEFT_ICON = 3;
				/// <java-name>
				/// FEATURE_RIGHT_ICON
				/// </java-name>
				[Dot42.DexImport("FEATURE_RIGHT_ICON", "I", AccessFlags = 25)]
				public const int FEATURE_RIGHT_ICON = 4;
				/// <java-name>
				/// FEATURE_INDETERMINATE_PROGRESS
				/// </java-name>
				[Dot42.DexImport("FEATURE_INDETERMINATE_PROGRESS", "I", AccessFlags = 25)]
				public const int FEATURE_INDETERMINATE_PROGRESS = 5;
				/// <java-name>
				/// FEATURE_CONTEXT_MENU
				/// </java-name>
				[Dot42.DexImport("FEATURE_CONTEXT_MENU", "I", AccessFlags = 25)]
				public const int FEATURE_CONTEXT_MENU = 6;
				/// <java-name>
				/// FEATURE_CUSTOM_TITLE
				/// </java-name>
				[Dot42.DexImport("FEATURE_CUSTOM_TITLE", "I", AccessFlags = 25)]
				public const int FEATURE_CUSTOM_TITLE = 7;
				/// <java-name>
				/// FEATURE_ACTION_BAR
				/// </java-name>
				[Dot42.DexImport("FEATURE_ACTION_BAR", "I", AccessFlags = 25)]
				public const int FEATURE_ACTION_BAR = 8;
				/// <java-name>
				/// FEATURE_ACTION_BAR_OVERLAY
				/// </java-name>
				[Dot42.DexImport("FEATURE_ACTION_BAR_OVERLAY", "I", AccessFlags = 25)]
				public const int FEATURE_ACTION_BAR_OVERLAY = 9;
				/// <java-name>
				/// FEATURE_ACTION_MODE_OVERLAY
				/// </java-name>
				[Dot42.DexImport("FEATURE_ACTION_MODE_OVERLAY", "I", AccessFlags = 25)]
				public const int FEATURE_ACTION_MODE_OVERLAY = 10;
				/// <java-name>
				/// PROGRESS_VISIBILITY_ON
				/// </java-name>
				[Dot42.DexImport("PROGRESS_VISIBILITY_ON", "I", AccessFlags = 25)]
				public const int PROGRESS_VISIBILITY_ON = -1;
				/// <java-name>
				/// PROGRESS_VISIBILITY_OFF
				/// </java-name>
				[Dot42.DexImport("PROGRESS_VISIBILITY_OFF", "I", AccessFlags = 25)]
				public const int PROGRESS_VISIBILITY_OFF = -2;
				/// <java-name>
				/// PROGRESS_INDETERMINATE_ON
				/// </java-name>
				[Dot42.DexImport("PROGRESS_INDETERMINATE_ON", "I", AccessFlags = 25)]
				public const int PROGRESS_INDETERMINATE_ON = -3;
				/// <java-name>
				/// PROGRESS_INDETERMINATE_OFF
				/// </java-name>
				[Dot42.DexImport("PROGRESS_INDETERMINATE_OFF", "I", AccessFlags = 25)]
				public const int PROGRESS_INDETERMINATE_OFF = -4;
				/// <java-name>
				/// PROGRESS_START
				/// </java-name>
				[Dot42.DexImport("PROGRESS_START", "I", AccessFlags = 25)]
				public const int PROGRESS_START = 0;
				/// <java-name>
				/// PROGRESS_END
				/// </java-name>
				[Dot42.DexImport("PROGRESS_END", "I", AccessFlags = 25)]
				public const int PROGRESS_END = 10000;
				/// <java-name>
				/// PROGRESS_SECONDARY_START
				/// </java-name>
				[Dot42.DexImport("PROGRESS_SECONDARY_START", "I", AccessFlags = 25)]
				public const int PROGRESS_SECONDARY_START = 20000;
				/// <java-name>
				/// PROGRESS_SECONDARY_END
				/// </java-name>
				[Dot42.DexImport("PROGRESS_SECONDARY_END", "I", AccessFlags = 25)]
				public const int PROGRESS_SECONDARY_END = 30000;
				/// <java-name>
				/// DEFAULT_FEATURES
				/// </java-name>
				[Dot42.DexImport("DEFAULT_FEATURES", "I", AccessFlags = 28)]
				protected internal const int DEFAULT_FEATURES = 65;
				/// <java-name>
				/// ID_ANDROID_CONTENT
				/// </java-name>
				[Dot42.DexImport("ID_ANDROID_CONTENT", "I", AccessFlags = 25)]
				public const int ID_ANDROID_CONTENT = 16908290;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Window(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWindowManager
				/// </java-name>
				[Dot42.DexImport("setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetWindowManager(global::Android.Views.IWindowManager windowManager, global::Android.OS.IBinder binder, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWindowManager
				/// </java-name>
				[Dot42.DexImport("setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;Z)V", AccessFlags = 1)]
				public virtual void SetWindowManager(global::Android.Views.IWindowManager windowManager, global::Android.OS.IBinder binder, string @string, bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// takeSurface
				/// </java-name>
				[Dot42.DexImport("takeSurface", "(Landroid/view/SurfaceHolder$Callback2;)V", AccessFlags = 1025)]
				public abstract void TakeSurface(global::Android.Views.ISurfaceHolder_ICallback2 surfaceHolder_ICallback2) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// takeInputQueue
				/// </java-name>
				[Dot42.DexImport("takeInputQueue", "(Landroid/view/InputQueue$Callback;)V", AccessFlags = 1025)]
				public abstract void TakeInputQueue(global::Android.Views.InputQueue.ICallback callback) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setLayout
				/// </java-name>
				[Dot42.DexImport("setLayout", "(II)V", AccessFlags = 1)]
				public virtual void SetLayout(int int32, int int321) /* MethodBuilder.Create */ 
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
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(I)V", AccessFlags = 1)]
				public virtual void SetType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFormat
				/// </java-name>
				[Dot42.DexImport("setFormat", "(I)V", AccessFlags = 1)]
				public virtual void SetFormat(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setWindowAnimations
				/// </java-name>
				[Dot42.DexImport("setWindowAnimations", "(I)V", AccessFlags = 1)]
				public virtual void SetWindowAnimations(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSoftInputMode
				/// </java-name>
				[Dot42.DexImport("setSoftInputMode", "(I)V", AccessFlags = 1)]
				public virtual void SetSoftInputMode(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addFlags
				/// </java-name>
				[Dot42.DexImport("addFlags", "(I)V", AccessFlags = 1)]
				public virtual void AddFlags(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clearFlags
				/// </java-name>
				[Dot42.DexImport("clearFlags", "(I)V", AccessFlags = 1)]
				public virtual void ClearFlags(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFlags
				/// </java-name>
				[Dot42.DexImport("setFlags", "(II)V", AccessFlags = 1)]
				public virtual void SetFlags(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setDimAmount
				/// </java-name>
				[Dot42.DexImport("setDimAmount", "(F)V", AccessFlags = 1)]
				public virtual void SetDimAmount(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// requestFeature
				/// </java-name>
				[Dot42.DexImport("requestFeature", "(I)Z", AccessFlags = 1)]
				public virtual bool RequestFeature(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// makeActive
				/// </java-name>
				[Dot42.DexImport("makeActive", "()V", AccessFlags = 17)]
				public void MakeActive() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// findViewById
				/// </java-name>
				[Dot42.DexImport("findViewById", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindViewById(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(I)V", AccessFlags = 1025)]
				public abstract void SetContentView(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1025)]
				public abstract void SetContentView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1025)]
				public abstract void SetContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// addContentView
				/// </java-name>
				[Dot42.DexImport("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1025)]
				public abstract void AddContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams layoutParams) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
				public abstract void SetTitle(global::Java.Lang.ICharSequence charSequence) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTitleColor
				/// </java-name>
				[Dot42.DexImport("setTitleColor", "(I)V", AccessFlags = 1025)]
				public abstract void SetTitleColor(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openPanel
				/// </java-name>
				[Dot42.DexImport("openPanel", "(ILandroid/view/KeyEvent;)V", AccessFlags = 1025)]
				public abstract void OpenPanel(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closePanel
				/// </java-name>
				[Dot42.DexImport("closePanel", "(I)V", AccessFlags = 1025)]
				public abstract void ClosePanel(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// togglePanel
				/// </java-name>
				[Dot42.DexImport("togglePanel", "(ILandroid/view/KeyEvent;)V", AccessFlags = 1025)]
				public abstract void TogglePanel(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// invalidatePanelMenu
				/// </java-name>
				[Dot42.DexImport("invalidatePanelMenu", "(I)V", AccessFlags = 1025)]
				public abstract void InvalidatePanelMenu(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performPanelShortcut
				/// </java-name>
				[Dot42.DexImport("performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z", AccessFlags = 1025)]
				public abstract bool PerformPanelShortcut(int int32, int int321, global::Android.Views.KeyEvent keyEvent, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performPanelIdentifierAction
				/// </java-name>
				[Dot42.DexImport("performPanelIdentifierAction", "(III)Z", AccessFlags = 1025)]
				public abstract bool PerformPanelIdentifierAction(int int32, int int321, int int322) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closeAllPanels
				/// </java-name>
				[Dot42.DexImport("closeAllPanels", "()V", AccessFlags = 1025)]
				public abstract void CloseAllPanels() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performContextMenuIdentifierAction
				/// </java-name>
				[Dot42.DexImport("performContextMenuIdentifierAction", "(II)Z", AccessFlags = 1025)]
				public abstract bool PerformContextMenuIdentifierAction(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1025)]
				public abstract void OnConfigurationChanged(global::Android.Content.Res.Configuration configuration) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setBackgroundDrawableResource
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawableResource", "(I)V", AccessFlags = 1)]
				public virtual void SetBackgroundDrawableResource(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeatureDrawableResource
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableResource", "(II)V", AccessFlags = 1025)]
				public abstract void SetFeatureDrawableResource(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeatureDrawableUri
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableUri", "(ILandroid/net/Uri;)V", AccessFlags = 1025)]
				public abstract void SetFeatureDrawableUri(int int32, global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeatureDrawable
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetFeatureDrawable(int int32, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeatureDrawableAlpha
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableAlpha", "(II)V", AccessFlags = 1025)]
				public abstract void SetFeatureDrawableAlpha(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setFeatureInt
				/// </java-name>
				[Dot42.DexImport("setFeatureInt", "(II)V", AccessFlags = 1025)]
				public abstract void SetFeatureInt(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// takeKeyEvents
				/// </java-name>
				[Dot42.DexImport("takeKeyEvents", "(Z)V", AccessFlags = 1025)]
				public abstract void TakeKeyEvents(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// superDispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public abstract bool SuperDispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// superDispatchKeyShortcutEvent
				/// </java-name>
				[Dot42.DexImport("superDispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public abstract bool SuperDispatchKeyShortcutEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// superDispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public abstract bool SuperDispatchTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// superDispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public abstract bool SuperDispatchTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// superDispatchGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("superDispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public abstract bool SuperDispatchGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// peekDecorView
				/// </java-name>
				[Dot42.DexImport("peekDecorView", "()Landroid/view/View;", AccessFlags = 1025)]
				public abstract global::Android.Views.View PeekDecorView() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// saveHierarchyState
				/// </java-name>
				[Dot42.DexImport("saveHierarchyState", "()Landroid/os/Bundle;", AccessFlags = 1025)]
				public abstract global::Android.OS.Bundle SaveHierarchyState() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// restoreHierarchyState
				/// </java-name>
				[Dot42.DexImport("restoreHierarchyState", "(Landroid/os/Bundle;)V", AccessFlags = 1025)]
				public abstract void RestoreHierarchyState(global::Android.OS.Bundle bundle) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onActive
				/// </java-name>
				[Dot42.DexImport("onActive", "()V", AccessFlags = 1028)]
				protected internal abstract void OnActive() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// hasFeature
				/// </java-name>
				[Dot42.DexImport("hasFeature", "(I)Z", AccessFlags = 1)]
				public virtual bool HasFeature(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setDefaultWindowFormat
				/// </java-name>
				[Dot42.DexImport("setDefaultWindowFormat", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetDefaultWindowFormat(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChildDrawable
				/// </java-name>
				[Dot42.DexImport("setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetChildDrawable(int int32, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setChildInt
				/// </java-name>
				[Dot42.DexImport("setChildInt", "(II)V", AccessFlags = 1025)]
				public abstract void SetChildInt(int int32, int int321) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isShortcutKey
				/// </java-name>
				[Dot42.DexImport("isShortcutKey", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public abstract bool IsShortcutKey(int int32, global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setUiOptions
				/// </java-name>
				[Dot42.DexImport("setUiOptions", "(I)V", AccessFlags = 1)]
				public virtual void SetUiOptions(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setUiOptions
				/// </java-name>
				[Dot42.DexImport("setUiOptions", "(II)V", AccessFlags = 1)]
				public virtual void SetUiOptions(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Window() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <java-name>
				/// getWindowStyle
				/// </java-name>
				public global::Android.Content.Res.TypedArray WindowStyle
				{
						[Dot42.DexImport("getWindowStyle", "()Landroid/content/res/TypedArray;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.TypedArray); }
				}

				/// <java-name>
				/// getContainer
				/// </java-name>
				public virtual global::Android.Views.Window Container
				{
						[Dot42.DexImport("getContainer", "()Landroid/view/Window;", AccessFlags = 17)]
						get{ return default(global::Android.Views.Window); }
						[Dot42.DexImport("setContainer", "(Landroid/view/Window;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// hasChildren
				/// </java-name>
				public bool HasChildren
				{
						[Dot42.DexImport("hasChildren", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getWindowManager
				/// </java-name>
				public virtual global::Android.Views.IWindowManager WindowManager
				{
						[Dot42.DexImport("getWindowManager", "()Landroid/view/WindowManager;", AccessFlags = 1)]
						get{ return default(global::Android.Views.IWindowManager); }
				}

				/// <java-name>
				/// getCallback
				/// </java-name>
				public virtual global::Android.Views.Window.ICallback Callback
				{
						[Dot42.DexImport("getCallback", "()Landroid/view/Window$Callback;", AccessFlags = 17)]
						get{ return default(global::Android.Views.Window.ICallback); }
						[Dot42.DexImport("setCallback", "(Landroid/view/Window$Callback;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isFloating
				/// </java-name>
				public abstract bool IsFloating
				{
						[Dot42.DexImport("isFloating", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getAttributes
				/// </java-name>
				public virtual global::Android.Views.IWindowManager_LayoutParams Attributes
				{
						[Dot42.DexImport("getAttributes", "()Landroid/view/WindowManager$LayoutParams;", AccessFlags = 17)]
						get{ return default(global::Android.Views.IWindowManager_LayoutParams); }
						[Dot42.DexImport("setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getForcedWindowFlags
				/// </java-name>
				protected internal int ForcedWindowFlags
				{
						[Dot42.DexImport("getForcedWindowFlags", "()I", AccessFlags = 20)]
						get{ return default(int); }
				}

				/// <java-name>
				/// hasSoftInputMode
				/// </java-name>
				protected internal bool HasSoftInputMode
				{
						[Dot42.DexImport("hasSoftInputMode", "()Z", AccessFlags = 20)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isActive
				/// </java-name>
				public bool IsActive
				{
						[Dot42.DexImport("isActive", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getCurrentFocus
				/// </java-name>
				public abstract global::Android.Views.View CurrentFocus
				{
						[Dot42.DexImport("getCurrentFocus", "()Landroid/view/View;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				public abstract global::Android.Views.LayoutInflater LayoutInflater
				{
						[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getDecorView
				/// </java-name>
				public abstract global::Android.Views.View DecorView
				{
						[Dot42.DexImport("getDecorView", "()Landroid/view/View;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getFeatures
				/// </java-name>
				protected internal int Features
				{
						[Dot42.DexImport("getFeatures", "()I", AccessFlags = 20)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getLocalFeatures
				/// </java-name>
				protected internal int LocalFeatures
				{
						[Dot42.DexImport("getLocalFeatures", "()I", AccessFlags = 20)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getVolumeControlStream
				/// </java-name>
				public abstract int VolumeControlStream
				{
						[Dot42.DexImport("getVolumeControlStream", "()I", AccessFlags = 1025)]
						get;
						[Dot42.DexImport("setVolumeControlStream", "(I)V", AccessFlags = 1025)]
						set;
				}

				/// <java-name>
				/// android/view/Window$Callback
				/// </java-name>
				[Dot42.DexImport("android/view/Window$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// dispatchKeyEvent
						/// </java-name>
						[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool DispatchKeyEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// dispatchKeyShortcutEvent
						/// </java-name>
						[Dot42.DexImport("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool DispatchKeyShortcutEvent(global::Android.Views.KeyEvent keyEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// dispatchTouchEvent
						/// </java-name>
						[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool DispatchTouchEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// dispatchTrackballEvent
						/// </java-name>
						[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool DispatchTrackballEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// dispatchGenericMotionEvent
						/// </java-name>
						[Dot42.DexImport("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool DispatchGenericMotionEvent(global::Android.Views.MotionEvent motionEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// dispatchPopulateAccessibilityEvent
						/// </java-name>
						[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1025)]
						bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onCreatePanelView
						/// </java-name>
						[Dot42.DexImport("onCreatePanelView", "(I)Landroid/view/View;", AccessFlags = 1025)]
						global::Android.Views.View OnCreatePanelView(int int32) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onCreatePanelMenu
						/// </java-name>
						[Dot42.DexImport("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", AccessFlags = 1025)]
						bool OnCreatePanelMenu(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onPreparePanel
						/// </java-name>
						[Dot42.DexImport("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", AccessFlags = 1025)]
						bool OnPreparePanel(int int32, global::Android.Views.View view, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onMenuOpened
						/// </java-name>
						[Dot42.DexImport("onMenuOpened", "(ILandroid/view/Menu;)Z", AccessFlags = 1025)]
						bool OnMenuOpened(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onMenuItemSelected
						/// </java-name>
						[Dot42.DexImport("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", AccessFlags = 1025)]
						bool OnMenuItemSelected(int int32, global::Android.Views.IMenuItem menuItem) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onWindowAttributesChanged
						/// </java-name>
						[Dot42.DexImport("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", AccessFlags = 1025)]
						void OnWindowAttributesChanged(global::Android.Views.IWindowManager_LayoutParams iWindowManager_LayoutParams) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onContentChanged
						/// </java-name>
						[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1025)]
						void OnContentChanged() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onWindowFocusChanged
						/// </java-name>
						[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1025)]
						void OnWindowFocusChanged(bool boolean) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onAttachedToWindow
						/// </java-name>
						[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 1025)]
						void OnAttachedToWindow() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onDetachedFromWindow
						/// </java-name>
						[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1025)]
						void OnDetachedFromWindow() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onPanelClosed
						/// </java-name>
						[Dot42.DexImport("onPanelClosed", "(ILandroid/view/Menu;)V", AccessFlags = 1025)]
						void OnPanelClosed(int int32, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onSearchRequested
						/// </java-name>
						[Dot42.DexImport("onSearchRequested", "()Z", AccessFlags = 1025)]
						bool OnSearchRequested() /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onWindowStartingActionMode
						/// </java-name>
						[Dot42.DexImport("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1025)]
						global::Android.Views.ActionMode OnWindowStartingActionMode(global::Android.Views.ActionMode.ICallback callback) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActionModeStarted
						/// </java-name>
						[Dot42.DexImport("onActionModeStarted", "(Landroid/view/ActionMode;)V", AccessFlags = 1025)]
						void OnActionModeStarted(global::Android.Views.ActionMode actionMode) /* MethodBuilder.Create */ ;

						/// <java-name>
						/// onActionModeFinished
						/// </java-name>
						[Dot42.DexImport("onActionModeFinished", "(Landroid/view/ActionMode;)V", AccessFlags = 1025)]
						void OnActionModeFinished(global::Android.Views.ActionMode actionMode) /* MethodBuilder.Create */ ;

				}

		}

}

