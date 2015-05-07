#pragma warning disable 1717
namespace Android.Views
{
		/// <summary>
		///  <para>A Parcelable implementation that should be used by inheritance hierarchies to ensure the state of all classes along the chain is saved. </para>    
		/// </summary>
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
				/// <summary>
				///  <para>Constructor called by derived classes when creating their SavedState objects</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal AbsSavedState(global::Android.OS.IParcelable superState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor called by derived classes when creating their SavedState objects</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 4)]
				protected internal AbsSavedState(global::Android.OS.Parcel superState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>A ContextWrapper that allows you to modify the theme from what is in the wrapped context. </para>    
		/// </summary>
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
				public ContextThemeWrapper(global::Android.Content.Context @base, int themeres) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// attachBaseContext
				/// </java-name>
				[Dot42.DexImport("attachBaseContext", "(Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal override void AttachBaseContext(global::Android.Content.Context newBase) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTheme
				/// </java-name>
				[Dot42.DexImport("setTheme", "(I)V", AccessFlags = 1)]
				public override void SetTheme(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSystemService
				/// </java-name>
				[Dot42.DexImport("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", AccessFlags = 1)]
				public override object GetSystemService(string name) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Called by setTheme and getTheme to apply a theme resource to the current Theme object. Can override to change the default (simple) behavior. This method will not be called in multiple threads simultaneously.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onApplyThemeResource
				/// </java-name>
				[Dot42.DexImport("onApplyThemeResource", "(Landroid/content/res/Resources$Theme;IZ)V", AccessFlags = 4)]
				protected internal virtual void OnApplyThemeResource(global::Android.Content.Res.Resources.Theme theme, int resid, bool first) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Provides information about the size and density of a logical display. </para> <para>The display area is described in two different ways.  <ul> <li> <para>The application display area specifies the part of the display that may contain an application window, excluding the system decorations. The application display area may be smaller than the real display area because the system subtracts the space needed for decor elements such as the status bar. Use the following methods to query the application display area: getSize, getRectSize and getMetrics. </para></li> <li> <para>The real display area specifies the part of the display that contains content including the system decorations. Even so, the real display area may be smaller than the physical size of the display if the window manager is emulating a smaller display using (adb shell am display-size). Use the following methods to query the real display area: getRealSize, getRealMetrics. </para></li></ul></para> <para>A logical display does not necessarily represent a particular physical display device such as the built-in screen or an external monitor. The contents of a logical display may be presented on one or more physical displays according to the devices that are currently attached and whether mirroring has been enabled. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/Display
		/// </java-name>
		[Dot42.DexImport("android/view/Display", AccessFlags = 33)]
		public partial class Display
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The default Display id, which is the id of the built-in primary display assuming there is one. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_DISPLAY
				/// </java-name>
				[Dot42.DexImport("DEFAULT_DISPLAY", "I", AccessFlags = 25)]
				public const int DEFAULT_DISPLAY = 0;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Display() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets display metrics that describe the size and density of this display. </para> <para>The size is adjusted based on the current rotation of the display. </para> <para>The size returned by this method does not necessarily represent the actual raw size (native resolution) of the display. The returned size may be adjusted to exclude certain system decor elements that are always visible. It may also be scaled to provide compatibility with older applications that were originally designed for smaller displays. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getMetrics
				/// </java-name>
				[Dot42.DexImport("getMetrics", "(Landroid/util/DisplayMetrics;)V", AccessFlags = 1)]
				public virtual void GetMetrics(global::Android.Util.DisplayMetrics outMetrics) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the display id. </para> <para>Each logical display has a unique id. The default display has id DEFAULT_DISPLAY. </para>        
				/// </summary>
				/// <java-name>
				/// getDisplayId
				/// </java-name>
				public virtual int DisplayId
				{
						[Dot42.DexImport("getDisplayId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getSize(Point) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public virtual int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getSize(Point) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public virtual int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the rotation of the screen from its "natural" orientation. The returned value may be Surface.ROTATION_0 (no rotation), Surface.ROTATION_90, Surface.ROTATION_180, or Surface.ROTATION_270. For example, if a device has a naturally tall screen, and the user has turned it on its side to go into a landscape orientation, the value returned here may be either Surface.ROTATION_90 or Surface.ROTATION_270 depending on the direction it was turned. The angle is the rotation of the drawn graphics on the screen, which is the opposite direction of the physical rotation of the device. For example, if the device is rotated 90 degrees counter-clockwise, to compensate rendering will be rotated by 90 degrees clockwise and thus the returned value here will be Surface.ROTATION_90. </para>        
				/// </summary>
				/// <java-name>
				/// getRotation
				/// </java-name>
				public virtual int Rotation
				{
						[Dot42.DexImport("getRotation", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use getRotation </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>orientation of this display. </para>
				/// </returns>
				/// <java-name>
				/// getOrientation
				/// </java-name>
				public virtual int Orientation
				{
						[Dot42.DexImport("getOrientation", "()I", AccessFlags = 257)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the pixel format of the display.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is no longer supported. The result is always PixelFormat#RGBA_8888. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>One of the constants defined in android.graphics.PixelFormat.</para>
				/// </returns>
				/// <java-name>
				/// getPixelFormat
				/// </java-name>
				public virtual int PixelFormat
				{
						[Dot42.DexImport("getPixelFormat", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the refresh rate of this display in frames per second. </para>        
				/// </summary>
				/// <java-name>
				/// getRefreshRate
				/// </java-name>
				public virtual float RefreshRate
				{
						[Dot42.DexImport("getRefreshRate", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

		}

		/// <summary>
		///  <para>The algorithm used for finding the next focusable view in a given direction from a view that currently has focus. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Find the next view to take focus in root's descendants, starting from the view that currently is focused. </para>        
				/// </summary>
				/// <returns>
				///  <para>The next focusable view, or null if none exists. </para>
				/// </returns>
				/// <java-name>
				/// findNextFocus
				/// </java-name>
				[Dot42.DexImport("findNextFocus", "(Landroid/view/ViewGroup;Landroid/view/View;I)Landroid/view/View;", AccessFlags = 17)]
				public global::Android.Views.View FindNextFocus(global::Android.Views.ViewGroup root, global::Android.Views.View focused, int direction) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Find the next view to take focus in root's descendants, searching from a particular rectangle in root's coordinates. </para>        
				/// </summary>
				/// <returns>
				///  <para>The next focusable view, or null if none exists. </para>
				/// </returns>
				/// <java-name>
				/// findNextFocusFromRect
				/// </java-name>
				[Dot42.DexImport("findNextFocusFromRect", "(Landroid/view/ViewGroup;Landroid/graphics/Rect;I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindNextFocusFromRect(global::Android.Views.ViewGroup root, global::Android.Graphics.Rect focusedRect, int direction) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Find the nearest touchable view to the specified view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The nearest touchable view, or null if none exists. </para>
				/// </returns>
				/// <java-name>
				/// findNearestTouchable
				/// </java-name>
				[Dot42.DexImport("findNearestTouchable", "(Landroid/view/ViewGroup;III[I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindNearestTouchable(global::Android.Views.ViewGroup root, int x, int y, int direction, int[] deltas) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Get the focus finder for this thread. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				public static global::Android.Views.FocusFinder Instance
				{
						[Dot42.DexImport("getInstance", "()Landroid/view/FocusFinder;", AccessFlags = 9)]
						get{ return default(global::Android.Views.FocusFinder); }
				}

		}

		/// <summary>
		///  <para>Detects various gestures and events using the supplied MotionEvents. The OnGestureListener callback will notify users when a particular motion event has occurred. This class should only be used with MotionEvents reported via touch (don't use for trackball events).</para> <para>To use this class:  <ul> <li> <para>Create an instance of the <c>GestureDetector </c> for your View </para></li> <li> <para>In the View#onTouchEvent(MotionEvent) method ensure you call onTouchEvent(MotionEvent). The methods defined in your callback will be executed when the events occur. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/view/GestureDetector
		/// </java-name>
		[Dot42.DexImport("android/view/GestureDetector", AccessFlags = 33)]
		public partial class GestureDetector
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a GestureDetector with the supplied listener. This variant of the constructor should be used from a non-UI thread (as it allows specifying the Handler).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.view.GestureDetector.OnGestureListener, android.os.Handler) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Views.GestureDetector.IOnGestureListener listener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a GestureDetector with the supplied listener. You may only use this constructor from a UI thread (this is the usual situation).  <para>android.os.Handler::Handler()</para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.view.GestureDetector.OnGestureListener) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Views.GestureDetector.IOnGestureListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a GestureDetector with the supplied listener. This variant of the constructor should be used from a non-UI thread (as it allows specifying the Handler).</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.view.GestureDetector.OnGestureListener, android.os.Handler) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Content.Context listener, global::Android.Views.GestureDetector.IOnGestureListener handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a GestureDetector with the supplied listener that runs deferred events on the thread associated with the supplied android.os.Handler.  <para>android.os.Handler::Handler()</para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroi" +
    "d/os/Handler;)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Content.Context context, global::Android.Views.GestureDetector.IOnGestureListener listener, global::Android.OS.Handler handler) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a GestureDetector with the supplied listener that runs deferred events on the thread associated with the supplied android.os.Handler.  <para>android.os.Handler::Handler()</para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroi" +
    "d/os/Handler;Z)V", AccessFlags = 1)]
				public GestureDetector(global::Android.Content.Context context, global::Android.Views.GestureDetector.IOnGestureListener listener, global::Android.OS.Handler handler, bool unused) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the listener which will be called for double-tap and related gestures.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnDoubleTapListener
				/// </java-name>
				[Dot42.DexImport("setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V", AccessFlags = 1)]
				public virtual void SetOnDoubleTapListener(global::Android.Views.GestureDetector.IOnDoubleTapListener onDoubleTapListener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set whether longpress is enabled, if this is enabled when a user presses and holds down you get a longpress event and nothing further. If it's disabled the user can press and hold down and then later moved their finger and you will get scroll events. By default longpress is enabled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setIsLongpressEnabled
				/// </java-name>
				[Dot42.DexImport("setIsLongpressEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetIsLongpressEnabled(bool isLongpressEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Analyzes the given motion event and if applicable triggers the appropriate callbacks on the OnGestureListener supplied.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the OnGestureListener consumed the event, else false. </para>
				/// </returns>
				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal GestureDetector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if longpress is enabled, else false. </para>
				/// </returns>
				/// <java-name>
				/// isLongpressEnabled
				/// </java-name>
				public virtual bool IsLongpressEnabled
				{
						[Dot42.DexImport("isLongpressEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>A convenience class to extend when you only want to listen for a subset of all the gestures. This implements all methods in the OnGestureListener and OnDoubleTapListener but does nothing and return <c>false </c> for all applicable methods. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Notified when a tap occurs with the up MotionEvent that triggered it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onSingleTapUp
						/// </java-name>
						[Dot42.DexImport("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
						public virtual bool OnSingleTapUp(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Notified when a long press occurs with the initial on down MotionEvent that trigged it.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onLongPress
						/// </java-name>
						[Dot42.DexImport("onLongPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
						public virtual void OnLongPress(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notified when a scroll occurs with the initial on down MotionEvent and the current move MotionEvent. The distance in x and y is also supplied for convenience.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onScroll
						/// </java-name>
						[Dot42.DexImport("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1)]
						public virtual bool OnScroll(global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float distanceX, float distanceY) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Notified of a fling event when it occurs with the initial on down MotionEvent and the matching up MotionEvent. The calculated velocity is supplied along the x and y axis in pixels per second.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onFling
						/// </java-name>
						[Dot42.DexImport("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1)]
						public virtual bool OnFling(global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float velocityX, float velocityY) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>The user has performed a down MotionEvent and not performed a move or up yet. This event is commonly used to provide visual feedback to the user to let them know that their action has been recognized i.e. highlight an element.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onShowPress
						/// </java-name>
						[Dot42.DexImport("onShowPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
						public virtual void OnShowPress(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Notified when a tap occurs with the down MotionEvent that triggered it. This will be triggered immediately for every down event. All other events should be preceded by this.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onDown
						/// </java-name>
						[Dot42.DexImport("onDown", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
						public virtual bool OnDown(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Notified when a double-tap occurs.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onDoubleTap
						/// </java-name>
						[Dot42.DexImport("onDoubleTap", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
						public virtual bool OnDoubleTap(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Notified when an event within a double-tap gesture occurs, including the down, move, and up events.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onDoubleTapEvent
						/// </java-name>
						[Dot42.DexImport("onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
						public virtual bool OnDoubleTapEvent(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Notified when a single-tap occurs. </para> <para>Unlike OnGestureListener#onSingleTapUp(MotionEvent), this will only be called after the detector is confident that the user's first tap is not followed by a second tap leading to a double-tap gesture.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onSingleTapConfirmed
						/// </java-name>
						[Dot42.DexImport("onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
						public virtual bool OnSingleTapConfirmed(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

				}

				/// <summary>
				///  <para>The listener that is used to notify when a double-tap or a confirmed single-tap occur. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/GestureDetector$OnDoubleTapListener
				/// </java-name>
				[Dot42.DexImport("android/view/GestureDetector$OnDoubleTapListener", AccessFlags = 1545)]
				public partial interface IOnDoubleTapListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Notified when a single-tap occurs. </para> <para>Unlike OnGestureListener#onSingleTapUp(MotionEvent), this will only be called after the detector is confident that the user's first tap is not followed by a second tap leading to a double-tap gesture.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onSingleTapConfirmed
						/// </java-name>
						[Dot42.DexImport("onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnSingleTapConfirmed(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notified when a double-tap occurs.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onDoubleTap
						/// </java-name>
						[Dot42.DexImport("onDoubleTap", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnDoubleTap(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notified when an event within a double-tap gesture occurs, including the down, move, and up events.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onDoubleTapEvent
						/// </java-name>
						[Dot42.DexImport("onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnDoubleTapEvent(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>The listener that is used to notify when gestures occur. If you want to listen for all the different gestures then implement this interface. If you only want to listen for a subset it might be easier to extend SimpleOnGestureListener. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/GestureDetector$OnGestureListener
				/// </java-name>
				[Dot42.DexImport("android/view/GestureDetector$OnGestureListener", AccessFlags = 1545)]
				public partial interface IOnGestureListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Notified when a tap occurs with the down MotionEvent that triggered it. This will be triggered immediately for every down event. All other events should be preceded by this.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onDown
						/// </java-name>
						[Dot42.DexImport("onDown", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnDown(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>The user has performed a down MotionEvent and not performed a move or up yet. This event is commonly used to provide visual feedback to the user to let them know that their action has been recognized i.e. highlight an element.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onShowPress
						/// </java-name>
						[Dot42.DexImport("onShowPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1025)]
						void OnShowPress(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notified when a tap occurs with the up MotionEvent that triggered it.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onSingleTapUp
						/// </java-name>
						[Dot42.DexImport("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnSingleTapUp(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notified when a scroll occurs with the initial on down MotionEvent and the current move MotionEvent. The distance in x and y is also supplied for convenience.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onScroll
						/// </java-name>
						[Dot42.DexImport("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1025)]
						bool OnScroll(global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float distanceX, float distanceY) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notified when a long press occurs with the initial on down MotionEvent that trigged it.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onLongPress
						/// </java-name>
						[Dot42.DexImport("onLongPress", "(Landroid/view/MotionEvent;)V", AccessFlags = 1025)]
						void OnLongPress(global::Android.Views.MotionEvent e) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Notified of a fling event when it occurs with the initial on down MotionEvent and the matching up MotionEvent. The calculated velocity is supplied along the x and y axis in pixels per second.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the event is consumed, else false </para>
						/// </returns>
						/// <java-name>
						/// onFling
						/// </java-name>
						[Dot42.DexImport("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", AccessFlags = 1025)]
						bool OnFling(global::Android.Views.MotionEvent e1, global::Android.Views.MotionEvent e2, float velocityX, float velocityY) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Standard constants and tools for placing an object within a potentially larger container. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/Gravity
		/// </java-name>
		[Dot42.DexImport("android/view/Gravity", AccessFlags = 33)]
		public partial class Gravity
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constant indicating that no gravity has been set </para>        
				/// </summary>
				/// <java-name>
				/// NO_GRAVITY
				/// </java-name>
				[Dot42.DexImport("NO_GRAVITY", "I", AccessFlags = 25)]
				public const int NO_GRAVITY = 0;
				/// <summary>
				///  <para>Raw bit indicating the gravity for an axis has been specified. </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_SPECIFIED
				/// </java-name>
				[Dot42.DexImport("AXIS_SPECIFIED", "I", AccessFlags = 25)]
				public const int AXIS_SPECIFIED = 1;
				/// <summary>
				///  <para>Raw bit controlling how the left/top edge is placed. </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_PULL_BEFORE
				/// </java-name>
				[Dot42.DexImport("AXIS_PULL_BEFORE", "I", AccessFlags = 25)]
				public const int AXIS_PULL_BEFORE = 2;
				/// <summary>
				///  <para>Raw bit controlling how the right/bottom edge is placed. </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_PULL_AFTER
				/// </java-name>
				[Dot42.DexImport("AXIS_PULL_AFTER", "I", AccessFlags = 25)]
				public const int AXIS_PULL_AFTER = 4;
				/// <summary>
				///  <para>Raw bit controlling whether the right/bottom edge is clipped to its container, based on the gravity direction being applied. </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_CLIP
				/// </java-name>
				[Dot42.DexImport("AXIS_CLIP", "I", AccessFlags = 25)]
				public const int AXIS_CLIP = 8;
				/// <summary>
				///  <para>Bits defining the horizontal axis. </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_X_SHIFT
				/// </java-name>
				[Dot42.DexImport("AXIS_X_SHIFT", "I", AccessFlags = 25)]
				public const int AXIS_X_SHIFT = 0;
				/// <summary>
				///  <para>Bits defining the vertical axis. </para>        
				/// </summary>
				/// <java-name>
				/// AXIS_Y_SHIFT
				/// </java-name>
				[Dot42.DexImport("AXIS_Y_SHIFT", "I", AccessFlags = 25)]
				public const int AXIS_Y_SHIFT = 4;
				/// <summary>
				///  <para>Push object to the top of its container, not changing its size. </para>        
				/// </summary>
				/// <java-name>
				/// TOP
				/// </java-name>
				[Dot42.DexImport("TOP", "I", AccessFlags = 25)]
				public const int TOP = 48;
				/// <summary>
				///  <para>Push object to the bottom of its container, not changing its size. </para>        
				/// </summary>
				/// <java-name>
				/// BOTTOM
				/// </java-name>
				[Dot42.DexImport("BOTTOM", "I", AccessFlags = 25)]
				public const int BOTTOM = 80;
				/// <summary>
				///  <para>Push object to the left of its container, not changing its size. </para>        
				/// </summary>
				/// <java-name>
				/// LEFT
				/// </java-name>
				[Dot42.DexImport("LEFT", "I", AccessFlags = 25)]
				public const int LEFT = 3;
				/// <summary>
				///  <para>Push object to the right of its container, not changing its size. </para>        
				/// </summary>
				/// <java-name>
				/// RIGHT
				/// </java-name>
				[Dot42.DexImport("RIGHT", "I", AccessFlags = 25)]
				public const int RIGHT = 5;
				/// <summary>
				///  <para>Place object in the vertical center of its container, not changing its size. </para>        
				/// </summary>
				/// <java-name>
				/// CENTER_VERTICAL
				/// </java-name>
				[Dot42.DexImport("CENTER_VERTICAL", "I", AccessFlags = 25)]
				public const int CENTER_VERTICAL = 16;
				/// <summary>
				///  <para>Grow the vertical size of the object if needed so it completely fills its container. </para>        
				/// </summary>
				/// <java-name>
				/// FILL_VERTICAL
				/// </java-name>
				[Dot42.DexImport("FILL_VERTICAL", "I", AccessFlags = 25)]
				public const int FILL_VERTICAL = 112;
				/// <summary>
				///  <para>Place object in the horizontal center of its container, not changing its size. </para>        
				/// </summary>
				/// <java-name>
				/// CENTER_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("CENTER_HORIZONTAL", "I", AccessFlags = 25)]
				public const int CENTER_HORIZONTAL = 1;
				/// <summary>
				///  <para>Grow the horizontal size of the object if needed so it completely fills its container. </para>        
				/// </summary>
				/// <java-name>
				/// FILL_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("FILL_HORIZONTAL", "I", AccessFlags = 25)]
				public const int FILL_HORIZONTAL = 7;
				/// <summary>
				///  <para>Place the object in the center of its container in both the vertical and horizontal axis, not changing its size. </para>        
				/// </summary>
				/// <java-name>
				/// CENTER
				/// </java-name>
				[Dot42.DexImport("CENTER", "I", AccessFlags = 25)]
				public const int CENTER = 17;
				/// <summary>
				///  <para>Grow the horizontal and vertical size of the object if needed so it completely fills its container. </para>        
				/// </summary>
				/// <java-name>
				/// FILL
				/// </java-name>
				[Dot42.DexImport("FILL", "I", AccessFlags = 25)]
				public const int FILL = 119;
				/// <summary>
				///  <para>Flag to clip the edges of the object to its container along the vertical axis. </para>        
				/// </summary>
				/// <java-name>
				/// CLIP_VERTICAL
				/// </java-name>
				[Dot42.DexImport("CLIP_VERTICAL", "I", AccessFlags = 25)]
				public const int CLIP_VERTICAL = 128;
				/// <summary>
				///  <para>Flag to clip the edges of the object to its container along the horizontal axis. </para>        
				/// </summary>
				/// <java-name>
				/// CLIP_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("CLIP_HORIZONTAL", "I", AccessFlags = 25)]
				public const int CLIP_HORIZONTAL = 8;
				/// <summary>
				///  <para>Binary mask to get the absolute horizontal gravity of a gravity. </para>        
				/// </summary>
				/// <java-name>
				/// HORIZONTAL_GRAVITY_MASK
				/// </java-name>
				[Dot42.DexImport("HORIZONTAL_GRAVITY_MASK", "I", AccessFlags = 25)]
				public const int HORIZONTAL_GRAVITY_MASK = 7;
				/// <summary>
				///  <para>Binary mask to get the vertical gravity of a gravity. </para>        
				/// </summary>
				/// <java-name>
				/// VERTICAL_GRAVITY_MASK
				/// </java-name>
				[Dot42.DexImport("VERTICAL_GRAVITY_MASK", "I", AccessFlags = 25)]
				public const int VERTICAL_GRAVITY_MASK = 112;
				/// <summary>
				///  <para>Special constant to enable clipping to an overall display along the vertical dimension. This is not applied by default by apply(int, int, int, Rect, int, int, Rect); you must do so yourself by calling applyDisplay. </para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_CLIP_VERTICAL
				/// </java-name>
				[Dot42.DexImport("DISPLAY_CLIP_VERTICAL", "I", AccessFlags = 25)]
				public const int DISPLAY_CLIP_VERTICAL = 268435456;
				/// <summary>
				///  <para>Special constant to enable clipping to an overall display along the horizontal dimension. This is not applied by default by apply(int, int, int, Rect, int, int, Rect); you must do so yourself by calling applyDisplay. </para>        
				/// </summary>
				/// <java-name>
				/// DISPLAY_CLIP_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("DISPLAY_CLIP_HORIZONTAL", "I", AccessFlags = 25)]
				public const int DISPLAY_CLIP_HORIZONTAL = 16777216;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Gravity() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply a gravity constant to an object. This suppose that the layout direction is LTR.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(IIILandroid/graphics/Rect;Landroid/graphics/Rect;)V", AccessFlags = 9)]
				public static void Apply(int gravity, int w, int h, global::Android.Graphics.Rect container, global::Android.Graphics.Rect outRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply a gravity constant to an object.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// apply
				/// </java-name>
				[Dot42.DexImport("apply", "(IIILandroid/graphics/Rect;IILandroid/graphics/Rect;)V", AccessFlags = 9)]
				public static void Apply(int gravity, int w, int h, global::Android.Graphics.Rect container, int xAdj, int yAdj, global::Android.Graphics.Rect outRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Apply additional gravity behavior based on the overall "display" that an object exists in. This can be used after apply(int, int, int, Rect, int, int, Rect) to place the object within a visible display. By default this moves or clips the object to be visible in the display; the gravity flags DISPLAY_CLIP_HORIZONTAL and DISPLAY_CLIP_VERTICAL can be used to change this behavior.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// applyDisplay
				/// </java-name>
				[Dot42.DexImport("applyDisplay", "(ILandroid/graphics/Rect;Landroid/graphics/Rect;)V", AccessFlags = 9)]
				public static void ApplyDisplay(int gravity, global::Android.Graphics.Rect display, global::Android.Graphics.Rect inoutObj) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Indicate whether the supplied gravity has a vertical pull.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the supplied gravity has a vertical pull </para>
				/// </returns>
				/// <java-name>
				/// isVertical
				/// </java-name>
				[Dot42.DexImport("isVertical", "(I)Z", AccessFlags = 9)]
				public static bool IsVertical(int gravity) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicate whether the supplied gravity has an horizontal pull.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the supplied gravity has an horizontal pull </para>
				/// </returns>
				/// <java-name>
				/// isHorizontal
				/// </java-name>
				[Dot42.DexImport("isHorizontal", "(I)Z", AccessFlags = 9)]
				public static bool IsHorizontal(int gravity) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

		}

		/// <summary>
		///  <para>Constants to be used to perform haptic feedback effects via View#performHapticFeedback(int) </para>    
		/// </summary>
		/// <java-name>
		/// android/view/HapticFeedbackConstants
		/// </java-name>
		[Dot42.DexImport("android/view/HapticFeedbackConstants", AccessFlags = 33)]
		public partial class HapticFeedbackConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The user has performed a long press on an object that is resulting in an action being performed. </para>        
				/// </summary>
				/// <java-name>
				/// LONG_PRESS
				/// </java-name>
				[Dot42.DexImport("LONG_PRESS", "I", AccessFlags = 25)]
				public const int LONG_PRESS = 0;
				/// <summary>
				///  <para>The user has pressed on a virtual on-screen key. </para>        
				/// </summary>
				/// <java-name>
				/// VIRTUAL_KEY
				/// </java-name>
				[Dot42.DexImport("VIRTUAL_KEY", "I", AccessFlags = 25)]
				public const int VIRTUAL_KEY = 1;
				/// <summary>
				///  <para>The user has pressed a soft keyboard key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARD_TAP
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_TAP", "I", AccessFlags = 25)]
				public const int KEYBOARD_TAP = 3;
				/// <summary>
				///  <para>Flag for View.performHapticFeedback(int, int): Ignore the setting in the view for whether to perform haptic feedback, do it always. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_IGNORE_VIEW_SETTING
				/// </java-name>
				[Dot42.DexImport("FLAG_IGNORE_VIEW_SETTING", "I", AccessFlags = 25)]
				public const int FLAG_IGNORE_VIEW_SETTING = 1;
				/// <summary>
				///  <para>Flag for View.performHapticFeedback(int, int): Ignore the global setting for whether to perform haptic feedback, do it always. </para>        
				/// </summary>
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

		/// <summary>
		///  <para>Extension of Menu for context menus providing functionality to modify the header of the context menu. </para> <para>Context menus do not support item shortcuts and item icons. </para> <para>To show a context menu on long click, most clients will want to call Activity#registerForContextMenu and override Activity#onCreateContextMenu.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about creating menus, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/view/ContextMenu
		/// </java-name>
		[Dot42.DexImport("android/view/ContextMenu", AccessFlags = 1537)]
		public partial interface IContextMenu : global::Android.Views.IMenu
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Sets the context menu header's title to the title given in  <b>titleRes</b> resource identifier.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This ContextMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderTitle
				/// </java-name>
				[Dot42.DexImport("setHeaderTitle", "(I)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderTitle(int titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the context menu header's title to the title given in  <b>titleRes</b> resource identifier.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This ContextMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderTitle
				/// </java-name>
				[Dot42.DexImport("setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderTitle(global::Java.Lang.ICharSequence titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the context menu header's icon to the icon given in  <b>iconRes</b> resource id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This ContextMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderIcon
				/// </java-name>
				[Dot42.DexImport("setHeaderIcon", "(I)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderIcon(int iconRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the context menu header's icon to the icon given in  <b>iconRes</b> resource id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This ContextMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderIcon
				/// </java-name>
				[Dot42.DexImport("setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderIcon(global::Android.Graphics.Drawables.Drawable iconRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the header of the context menu to the View given in  <b>view</b>. This replaces the header title and icon (and those replace this).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This ContextMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderView
				/// </java-name>
				[Dot42.DexImport("setHeaderView", "(Landroid/view/View;)Landroid/view/ContextMenu;", AccessFlags = 1025)]
				global::Android.Views.IContextMenu SetHeaderView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Clears the header of the context menu. </para>        
				/// </summary>
				/// <java-name>
				/// clearHeader
				/// </java-name>
				[Dot42.DexImport("clearHeader", "()V", AccessFlags = 1025)]
				void ClearHeader() /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Additional information regarding the creation of the context menu. For example, AdapterViews use this to pass the exact item position within the adapter that initiated the context menu. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/ContextMenu$ContextMenuInfo
		/// </java-name>
		[Dot42.DexImport("android/view/ContextMenu$ContextMenuInfo", AccessFlags = 1545)]
		public partial interface IContextMenu_IContextMenuInfo
 /* scope: __dot42__ */ 
		{
		}

		/// <summary>
		///  <para>Interface for managing the items in a menu. </para> <para>By default, every Activity supports an options menu of actions or options. You can add items to this menu and handle clicks on your additions. The easiest way of adding menu items is inflating an XML file into the Menu via MenuInflater. The easiest way of attaching code to clicks is via Activity#onOptionsItemSelected(MenuItem) and Activity#onContextItemSelected(MenuItem). </para> <para>Different menu types support different features:  <ol> <li> <para> <b>Context menus</b>: Do not support item shortcuts and item icons. </para></li> <li> <para> <b>Options menus</b>: The  <b>icon menus</b> do not support item check marks and only show the item's condensed title. The  <b>expanded menus</b> (only available if six or more menu items are visible, reached via the 'More' item in the icon menu) do not show item icons, and item check marks are discouraged. </para></li> <li> <para> <b>Sub menus</b>: Do not support item icons, or nested sub menus. </para></li></ol></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating menus, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/view/Menu
		/// </java-name>
		[Dot42.DexImport("android/view/Menu", AccessFlags = 1537)]
		public partial interface IMenu
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Add a new item to the menu. This item displays the given title for its label.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly added menu item. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem Add(global::Java.Lang.ICharSequence titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a new item to the menu. This item displays the given title for its label.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly added menu item. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem Add(int titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Variation on add(int, int, int, CharSequence) that takes a string resource identifier instead of the string itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly added menu item. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem Add(int groupId, int itemId, int order, global::Java.Lang.ICharSequence titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Variation on add(int, int, int, CharSequence) that takes a string resource identifier instead of the string itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly added menu item. </para>
				/// </returns>
				/// <java-name>
				/// add
				/// </java-name>
				[Dot42.DexImport("add", "(IIII)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem Add(int groupId, int itemId, int order, int titleRes) /* MethodBuilder.Create */ ;

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

				/// <summary>
				///  <para>Variation on addSubMenu(int, int, int, CharSequence) that takes a string resource identifier for the title instead of the string itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly added sub-menu </para>
				/// </returns>
				/// <java-name>
				/// addSubMenu
				/// </java-name>
				[Dot42.DexImport("addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu AddSubMenu(int groupId, int itemId, int order, global::Java.Lang.ICharSequence titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Variation on addSubMenu(int, int, int, CharSequence) that takes a string resource identifier for the title instead of the string itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The newly added sub-menu </para>
				/// </returns>
				/// <java-name>
				/// addSubMenu
				/// </java-name>
				[Dot42.DexImport("addSubMenu", "(IIII)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu AddSubMenu(int groupId, int itemId, int order, int titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Add a group of menu items corresponding to actions that can be performed for a particular Intent. The Intent is most often configured with a null action, the data that the current activity is working with, and includes either the Intent#CATEGORY_ALTERNATIVE or Intent#CATEGORY_SELECTED_ALTERNATIVE to find activities that have said they would like to be included as optional action. You can, however, use any Intent you want.</para> <para>See android.content.pm.PackageManager#queryIntentActivityOptions for more * details on the  <b>caller</b>,  <b>specifics</b>, and  <b>intent</b> arguments. The list returned by that function is used to populate the resulting menu items.</para> <para>All of the menu items of possible options for the intent will be added with the given group and id. You can use the group to control ordering of the items in relation to other items in the menu. Normally this function will automatically remove any existing items in the menu in the same group and place a divider above and below the added items; this behavior can be modified with the  <b>flags</b> parameter. For each of the generated items MenuItem#setIntent is called to associate the appropriate Intent with the item; this means the activity will automatically be started for you without having to do anything else.</para> <para> <para>FLAG_APPEND_TO_GROUP </para> <para>MenuItem::setIntent </para> <para>android.content.pm.PackageManager::queryIntentActivityOptions </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of menu items that were added.</para>
				/// </returns>
				/// <java-name>
				/// addIntentOptions
				/// </java-name>
				[Dot42.DexImport("addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Inte" +
    "nt;I[Landroid/view/MenuItem;)I", AccessFlags = 1025)]
				int AddIntentOptions(int groupId, int itemId, int order, global::Android.Content.ComponentName caller, global::Android.Content.Intent[] specifics, global::Android.Content.Intent intent, int flags, global::Android.Views.IMenuItem[] outSpecificItems) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove the item with the given identifier.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeItem
				/// </java-name>
				[Dot42.DexImport("removeItem", "(I)V", AccessFlags = 1025)]
				void RemoveItem(int id) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove all items in the given group.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeGroup
				/// </java-name>
				[Dot42.DexImport("removeGroup", "(I)V", AccessFlags = 1025)]
				void RemoveGroup(int groupId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Remove all existing items from the menu, leaving it empty as if it had just been created. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1025)]
				void Clear() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Control whether a particular group of items can show a check mark. This is similar to calling MenuItem#setCheckable on all of the menu items with the given group identifier, but in addition you can control whether this group contains a mutually-exclusive set items. This should be called after the items of the group have been added to the menu.</para> <para> <para>MenuItem::setCheckable </para> <para>MenuItem::setChecked </para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupCheckable
				/// </java-name>
				[Dot42.DexImport("setGroupCheckable", "(IZZ)V", AccessFlags = 1025)]
				void SetGroupCheckable(int group, bool checkable, bool exclusive) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Show or hide all menu items that are in the given group.</para> <para> <para>MenuItem::setVisible </para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupVisible
				/// </java-name>
				[Dot42.DexImport("setGroupVisible", "(IZ)V", AccessFlags = 1025)]
				void SetGroupVisible(int group, bool visible) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Enable or disable all menu items that are in the given group.</para> <para> <para>MenuItem::setEnabled </para></para>        
				/// </summary>
				/// <java-name>
				/// setGroupEnabled
				/// </java-name>
				[Dot42.DexImport("setGroupEnabled", "(IZ)V", AccessFlags = 1025)]
				void SetGroupEnabled(int group, bool enabled) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the menu item with a particular identifier.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The menu item object, or null if there is no item with this identifier. </para>
				/// </returns>
				/// <java-name>
				/// findItem
				/// </java-name>
				[Dot42.DexImport("findItem", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem FindItem(int id) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Get the number of items in the menu. Note that this will change any times items are added or removed from the menu.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The item count. </para>
				/// </returns>
				/// <java-name>
				/// size
				/// </java-name>
				[Dot42.DexImport("size", "()I", AccessFlags = 1025)]
				int Size() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the menu item at the given index.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The menu item. </para>
				/// </returns>
				/// <java-name>
				/// getItem
				/// </java-name>
				[Dot42.DexImport("getItem", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem GetItem(int index) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Closes the menu, if open. </para>        
				/// </summary>
				/// <java-name>
				/// close
				/// </java-name>
				[Dot42.DexImport("close", "()V", AccessFlags = 1025)]
				void Close() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Execute the menu item action associated with the given shortcut character.</para> <para> <para>FLAG_PERFORM_NO_CLOSE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the given shortcut exists and is shown, returns true; else returns false.</para>
				/// </returns>
				/// <java-name>
				/// performShortcut
				/// </java-name>
				[Dot42.DexImport("performShortcut", "(ILandroid/view/KeyEvent;I)Z", AccessFlags = 1025)]
				bool PerformShortcut(int keyCode, global::Android.Views.KeyEvent @event, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Is a keypress one of the defined shortcut keys for this window. </para>        
				/// </summary>
				/// <java-name>
				/// isShortcutKey
				/// </java-name>
				[Dot42.DexImport("isShortcutKey", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				bool IsShortcutKey(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Execute the menu item action associated with the given menu identifier.</para> <para> <para>FLAG_PERFORM_NO_CLOSE </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If the given identifier exists and is shown, returns true; else returns false.</para>
				/// </returns>
				/// <java-name>
				/// performIdentifierAction
				/// </java-name>
				[Dot42.DexImport("performIdentifierAction", "(II)Z", AccessFlags = 1025)]
				bool PerformIdentifierAction(int id, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Control whether the menu should be running in qwerty mode (alphabetic shortcuts) or 12-key mode (numeric shortcuts).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setQwertyMode
				/// </java-name>
				[Dot42.DexImport("setQwertyMode", "(Z)V", AccessFlags = 1025)]
				void SetQwertyMode(bool isQwerty) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return whether the menu currently has item items that are visible.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if there is one or more item visible, else false. </para>
				/// </returns>
				/// <java-name>
				/// hasVisibleItems
				/// </java-name>
				bool HasVisibleItems
				{
						[Dot42.DexImport("hasVisibleItems", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Interface for managing the items in a menu. </para> <para>By default, every Activity supports an options menu of actions or options. You can add items to this menu and handle clicks on your additions. The easiest way of adding menu items is inflating an XML file into the Menu via MenuInflater. The easiest way of attaching code to clicks is via Activity#onOptionsItemSelected(MenuItem) and Activity#onContextItemSelected(MenuItem). </para> <para>Different menu types support different features:  <ol> <li> <para> <b>Context menus</b>: Do not support item shortcuts and item icons. </para></li> <li> <para> <b>Options menus</b>: The  <b>icon menus</b> do not support item check marks and only show the item's condensed title. The  <b>expanded menus</b> (only available if six or more menu items are visible, reached via the 'More' item in the icon menu) do not show item icons, and item check marks are discouraged. </para></li> <li> <para> <b>Sub menus</b>: Do not support item icons, or nested sub menus. </para></li></ol></para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating menus, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/view/Menu
		/// </java-name>
		[Dot42.DexImport("android/view/Menu", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class IMenuConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Value to use for group and item identifier integers when you don't care about them. </para>        
				/// </summary>
				/// <java-name>
				/// NONE
				/// </java-name>
				[Dot42.DexImport("NONE", "I", AccessFlags = 25)]
				public const int NONE = 0;
				/// <summary>
				///  <para>First value for group and item identifier integers. </para>        
				/// </summary>
				/// <java-name>
				/// FIRST
				/// </java-name>
				[Dot42.DexImport("FIRST", "I", AccessFlags = 25)]
				public const int FIRST = 1;
				/// <summary>
				///  <para>Category code for the order integer for items/groups that are part of a container  or/add this with your base value. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_CONTAINER
				/// </java-name>
				[Dot42.DexImport("CATEGORY_CONTAINER", "I", AccessFlags = 25)]
				public const int CATEGORY_CONTAINER = 65536;
				/// <summary>
				///  <para>Category code for the order integer for items/groups that are provided by the system  or/add this with your base value. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_SYSTEM
				/// </java-name>
				[Dot42.DexImport("CATEGORY_SYSTEM", "I", AccessFlags = 25)]
				public const int CATEGORY_SYSTEM = 131072;
				/// <summary>
				///  <para>Category code for the order integer for items/groups that are user-supplied secondary (infrequently used) options  or/add this with your base value. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_SECONDARY
				/// </java-name>
				[Dot42.DexImport("CATEGORY_SECONDARY", "I", AccessFlags = 25)]
				public const int CATEGORY_SECONDARY = 196608;
				/// <summary>
				///  <para>Category code for the order integer for items/groups that are alternative actions on the data that is currently displayed  or/add this with your base value. </para>        
				/// </summary>
				/// <java-name>
				/// CATEGORY_ALTERNATIVE
				/// </java-name>
				[Dot42.DexImport("CATEGORY_ALTERNATIVE", "I", AccessFlags = 25)]
				public const int CATEGORY_ALTERNATIVE = 262144;
				/// <summary>
				///  <para>Flag for addIntentOptions: if set, do not automatically remove any existing menu items in the same group. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_APPEND_TO_GROUP
				/// </java-name>
				[Dot42.DexImport("FLAG_APPEND_TO_GROUP", "I", AccessFlags = 25)]
				public const int FLAG_APPEND_TO_GROUP = 1;
				/// <summary>
				///  <para>Flag for performShortcut: if set, do not close the menu after executing the shortcut. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_PERFORM_NO_CLOSE
				/// </java-name>
				[Dot42.DexImport("FLAG_PERFORM_NO_CLOSE", "I", AccessFlags = 25)]
				public const int FLAG_PERFORM_NO_CLOSE = 1;
				/// <summary>
				///  <para>Flag for performShortcut(int, KeyEvent, int): if set, always close the menu after executing the shortcut. Closing the menu also resets the prepared state. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALWAYS_PERFORM_CLOSE
				/// </java-name>
				[Dot42.DexImport("FLAG_ALWAYS_PERFORM_CLOSE", "I", AccessFlags = 25)]
				public const int FLAG_ALWAYS_PERFORM_CLOSE = 2;
		}

		/// <summary>
		///  <para>Interface for direct access to a previously created menu item. </para> <para>An Item is returned by calling one of the android.view.Menu#add methods. </para> <para>For a feature set of specific menu types, see Menu.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about creating menus, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/view/MenuItem
		/// </java-name>
		[Dot42.DexImport("android/view/MenuItem", AccessFlags = 1537)]
		public partial interface IMenuItem
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Change the title associated with this item. </para> <para>Some menu types do not sufficient space to show the full title, and instead a condensed title is preferred. See Menu for more information.</para> <para> <para>setTitleCondensed(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the title associated with this item. </para> <para>Some menu types do not sufficient space to show the full title, and instead a condensed title is preferred. See Menu for more information.</para> <para> <para>setTitleCondensed(CharSequence) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetTitle(int title) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the condensed title associated with this item. The condensed title is used in situations where the normal title may be too long to be displayed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setTitleCondensed
				/// </java-name>
				[Dot42.DexImport("setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetTitleCondensed(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the icon associated with this item. This icon will not always be shown, so the title should be sufficient in describing this item. See Menu for the menu types that support icons.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetIcon(global::Android.Graphics.Drawables.Drawable icon) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the icon associated with this item. This icon will not always be shown, so the title should be sufficient in describing this item. See Menu for the menu types that support icons.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetIcon(int icon) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the Intent associated with this item. By default there is no Intent associated with a menu item. If you set one, and nothing else handles the item, then the default behavior will be to call android.content.Context#startActivity with the given Intent.</para> <para>Note that setIntent() can not be used with the versions of Menu#add that take a Runnable, because Runnable#run does not return a value so there is no way to tell if it handled the item. In this case it is assumed that the Runnable always handles the item, and the intent will never be started.</para> <para> <para>getIntent </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setIntent
				/// </java-name>
				[Dot42.DexImport("setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetIntent(global::Android.Content.Intent intent) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change both the numeric and alphabetic shortcut associated with this item. Note that the shortcut will be triggered when the key that generates the given character is pressed alone or along with with the alt key. Also note that case is not significant and that alphabetic shortcut characters will be displayed in lower case. </para> <para>See Menu for the menu types that support shortcuts.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setShortcut
				/// </java-name>
				[Dot42.DexImport("setShortcut", "(CC)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetShortcut(char numericChar, char alphaChar) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the numeric shortcut associated with this item. </para> <para>See Menu for the menu types that support shortcuts.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setNumericShortcut
				/// </java-name>
				[Dot42.DexImport("setNumericShortcut", "(C)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetNumericShortcut(char numericChar) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the alphabetic shortcut associated with this item. The shortcut will be triggered when the key that generates the given character is pressed alone or along with with the alt key. Case is not significant and shortcut characters will be displayed in lower case. Note that menu items with the characters ' <b></b>' or ' <br></br>' as shortcuts will get triggered by the Delete key or Carriage Return key, respectively. </para> <para>See Menu for the menu types that support shortcuts.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setAlphabeticShortcut
				/// </java-name>
				[Dot42.DexImport("setAlphabeticShortcut", "(C)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetAlphabeticShortcut(char alphaChar) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Control whether this item can display a check mark. Setting this does not actually display a check mark (see setChecked for that); rather, it ensures there is room in the item in which to display a check mark. </para> <para>See Menu for the menu types that support check marks.</para> <para> <para>setChecked </para> <para>isCheckable </para> <para>Menu::setGroupCheckable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setCheckable
				/// </java-name>
				[Dot42.DexImport("setCheckable", "(Z)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetCheckable(bool checkable) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Control whether this item is shown with a check mark. Note that you must first have enabled checking with setCheckable or else the check mark will not appear. If this item is a member of a group that contains mutually-exclusive items (set via Menu#setGroupCheckable(int, boolean, boolean), the other items in the group will be unchecked. </para> <para>See Menu for the menu types that support check marks.</para> <para> <para>setCheckable </para> <para>isChecked </para> <para>Menu::setGroupCheckable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetChecked(bool @checked) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the visibility of the menu item. Even if a menu item is not visible, it may still be invoked via its shortcut (to completely disable an item, set it to invisible and disabled).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setVisible
				/// </java-name>
				[Dot42.DexImport("setVisible", "(Z)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetVisible(bool visible) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets whether the menu item is enabled. Disabling a menu item will not allow it to be invoked via its shortcut. The menu item will still be visible.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetEnabled(bool enabled) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a custom listener for invocation of this menu item. In most situations, it is more efficient and easier to use Activity#onOptionsItemSelected(MenuItem) or Activity#onContextItemSelected(MenuItem).</para> <para> <para>Activity::onOptionsItemSelected(MenuItem) </para> <para>Activity::onContextItemSelected(MenuItem) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This Item so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setOnMenuItemClickListener
				/// </java-name>
				[Dot42.DexImport("setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;", AccessFlags = 1025)]
				global::Android.Views.IMenuItem SetOnMenuItemClickListener(global::Android.Views.IMenuItem_IOnMenuItemClickListener menuItemClickListener) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Return the identifier for this menu item. The identifier can not be changed after the menu is created.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The menu item's identifier. </para>
				/// </returns>
				/// <java-name>
				/// getItemId
				/// </java-name>
				int ItemId
				{
						[Dot42.DexImport("getItemId", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the group identifier that this menu item is part of. The group identifier can not be changed after the menu is created.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The menu item's group identifier. </para>
				/// </returns>
				/// <java-name>
				/// getGroupId
				/// </java-name>
				int GroupId
				{
						[Dot42.DexImport("getGroupId", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the category and order within the category of this item. This item will be shown before all items (within its category) that have order greater than this value. </para> <para>An order integer contains the item's category (the upper bits of the integer; set by or/add the category with the order within the category) and the ordering of the item within that category (the lower bits). Example categories are Menu#CATEGORY_SYSTEM, Menu#CATEGORY_SECONDARY, Menu#CATEGORY_ALTERNATIVE, Menu#CATEGORY_CONTAINER. See Menu for a full list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The order of this item. </para>
				/// </returns>
				/// <java-name>
				/// getOrder
				/// </java-name>
				int Order
				{
						[Dot42.DexImport("getOrder", "()I", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Retrieve the current title of the item.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The title. </para>
				/// </returns>
				/// <java-name>
				/// getTitle
				/// </java-name>
				global::Java.Lang.ICharSequence Title
				{
						[Dot42.DexImport("getTitle", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Retrieve the current condensed title of the item. If a condensed title was never set, it will return the normal title.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The condensed title, if it exists. Otherwise the normal title. </para>
				/// </returns>
				/// <java-name>
				/// getTitleCondensed
				/// </java-name>
				global::Java.Lang.ICharSequence TitleCondensed
				{
						[Dot42.DexImport("getTitleCondensed", "()Ljava/lang/CharSequence;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the icon for this item as a Drawable (getting it from resources if it hasn't been loaded before).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The icon as a Drawable. </para>
				/// </returns>
				/// <java-name>
				/// getIcon
				/// </java-name>
				global::Android.Graphics.Drawables.Drawable Icon
				{
						[Dot42.DexImport("getIcon", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the Intent associated with this item. This returns a reference to the Intent which you can change as desired to modify what the Item is holding.</para> <para> <para>setIntent </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the last value supplied to setIntent, or null. </para>
				/// </returns>
				/// <java-name>
				/// getIntent
				/// </java-name>
				global::Android.Content.Intent Intent
				{
						[Dot42.DexImport("getIntent", "()Landroid/content/Intent;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the char for this menu item's numeric (12-key) shortcut.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Numeric character to use as a shortcut. </para>
				/// </returns>
				/// <java-name>
				/// getNumericShortcut
				/// </java-name>
				char NumericShortcut
				{
						[Dot42.DexImport("getNumericShortcut", "()C", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the char for this menu item's alphabetic shortcut.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Alphabetic character to use as a shortcut. </para>
				/// </returns>
				/// <java-name>
				/// getAlphabeticShortcut
				/// </java-name>
				char AlphabeticShortcut
				{
						[Dot42.DexImport("getAlphabeticShortcut", "()C", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return whether the item can currently display a check mark.</para> <para> <para>setCheckable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If a check mark can be displayed, returns true.</para>
				/// </returns>
				/// <java-name>
				/// isCheckable
				/// </java-name>
				bool IsCheckable
				{
						[Dot42.DexImport("isCheckable", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return whether the item is currently displaying a check mark.</para> <para> <para>setChecked </para></para>        
				/// </summary>
				/// <returns>
				///  <para>If a check mark is displayed, returns true.</para>
				/// </returns>
				/// <java-name>
				/// isChecked
				/// </java-name>
				bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the visibility of the menu item.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If true the item is visible; else it is hidden. </para>
				/// </returns>
				/// <java-name>
				/// isVisible
				/// </java-name>
				bool IsVisible
				{
						[Dot42.DexImport("isVisible", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the enabled state of the menu item.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If true the item is enabled and hence invokable; else it is not. </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Check whether this item has an associated sub-menu. I.e. it is a sub-menu of another menu.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If true this item has a menu; else it is a normal item. </para>
				/// </returns>
				/// <java-name>
				/// hasSubMenu
				/// </java-name>
				bool HasSubMenu
				{
						[Dot42.DexImport("hasSubMenu", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Get the sub-menu to be invoked when this item is selected, if it has one. See hasSubMenu().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The associated menu if there is one, else null </para>
				/// </returns>
				/// <java-name>
				/// getSubMenu
				/// </java-name>
				global::Android.Views.ISubMenu SubMenu
				{
						[Dot42.DexImport("getSubMenu", "()Landroid/view/SubMenu;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Gets the extra information linked to this menu item. This extra information is set by the View that added this menu item to the menu.</para> <para> <para>OnCreateContextMenuListener </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The extra information linked to the View that added this menu item to the menu. This can be null. </para>
				/// </returns>
				/// <java-name>
				/// getMenuInfo
				/// </java-name>
				global::Android.Views.IContextMenu_IContextMenuInfo MenuInfo
				{
						[Dot42.DexImport("getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Interface definition for a callback to be invoked when a menu item is clicked.</para> <para> <para>Activity::onContextItemSelected(MenuItem) </para> <para>Activity::onOptionsItemSelected(MenuItem) </para></para>    
		/// </summary>
		/// <java-name>
		/// android/view/MenuItem$OnMenuItemClickListener
		/// </java-name>
		[Dot42.DexImport("android/view/MenuItem$OnMenuItemClickListener", AccessFlags = 1545)]
		public partial interface IMenuItem_IOnMenuItemClickListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called when a menu item has been invoked. This is the first code that is executed; if it returns true, no other callbacks will be executed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true to consume this click and prevent others from executing. </para>
				/// </returns>
				/// <java-name>
				/// onMenuItemClick
				/// </java-name>
				[Dot42.DexImport("onMenuItemClick", "(Landroid/view/MenuItem;)Z", AccessFlags = 1025)]
				bool OnMenuItemClick(global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>This exception is thrown by an inflater on error conditions. </para>    
		/// </summary>
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
				public InflateException(string detailMessage, global::System.Exception throwable) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Describes the capabilities of a particular input device. </para> <para>Each input device may support multiple classes of input. For example, a multi-function keyboard may compose the capabilities of a standard keyboard together with a track pad mouse or other pointing device. </para> <para>Some input devices present multiple distinguishable sources of input. Applications can query the framework about the characteristics of each distinct source. </para> <para>As a further wrinkle, different kinds of input sources uses different coordinate systems to describe motion events. Refer to the comments on the input source constants for the appropriate interpretation. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/InputDevice
		/// </java-name>
		[Dot42.DexImport("android/view/InputDevice", AccessFlags = 49)]
		public sealed partial class InputDevice : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>A mask for input source classes.</para> <para>Each distinct input source constant has one or more input source class bits set to specify the desired interpretation for its input events. </para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_CLASS_MASK
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_MASK", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_MASK = 255;
				/// <summary>
				///  <para>The input source has buttons or keys. Examples: SOURCE_KEYBOARD, SOURCE_DPAD.</para> <para>A KeyEvent should be interpreted as a button or key press.</para> <para>Use getKeyCharacterMap to query the device's button and key mappings. </para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_CLASS_BUTTON
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_BUTTON", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_BUTTON = 1;
				/// <summary>
				///  <para>The input source is a pointing device associated with a display. Examples: SOURCE_TOUCHSCREEN, SOURCE_MOUSE.</para> <para>A MotionEvent should be interpreted as absolute coordinates in display units according to the View hierarchy. Pointer down/up indicated when the finger touches the display or when the selection button is pressed/released.</para> <para>Use getMotionRange to query the range of the pointing device. Some devices permit touches outside the display area so the effective range may be somewhat smaller or larger than the actual display size. </para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_CLASS_POINTER
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_POINTER", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_POINTER = 2;
				/// <summary>
				///  <para>The input source is a trackball navigation device. Examples: SOURCE_TRACKBALL.</para> <para>A MotionEvent should be interpreted as relative movements in device-specific units used for navigation purposes. Pointer down/up indicates when the selection button is pressed/released.</para> <para>Use getMotionRange to query the range of motion. </para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_CLASS_TRACKBALL
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_TRACKBALL", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_TRACKBALL = 4;
				/// <summary>
				///  <para>The input source is an absolute positioning device not associated with a display (unlike SOURCE_CLASS_POINTER).</para> <para>A MotionEvent should be interpreted as absolute coordinates in device-specific surface units.</para> <para>Use getMotionRange to query the range of positions. </para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_CLASS_POSITION
				/// </java-name>
				[Dot42.DexImport("SOURCE_CLASS_POSITION", "I", AccessFlags = 25)]
				public const int SOURCE_CLASS_POSITION = 8;
				/// <summary>
				///  <para>The input source is unknown. </para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("SOURCE_UNKNOWN", "I", AccessFlags = 25)]
				public const int SOURCE_UNKNOWN = 0;
				/// <summary>
				///  <para>The input source is a keyboard.</para> <para>This source indicates pretty much anything that has buttons. Use getKeyboardType() to determine whether the keyboard has alphabetic keys and can be used to enter text.</para> <para> <para>SOURCE_CLASS_BUTTON </para></para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("SOURCE_KEYBOARD", "I", AccessFlags = 25)]
				public const int SOURCE_KEYBOARD = 257;
				/// <summary>
				///  <para>The input source is a DPad.</para> <para> <para>SOURCE_CLASS_BUTTON </para></para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_DPAD
				/// </java-name>
				[Dot42.DexImport("SOURCE_DPAD", "I", AccessFlags = 25)]
				public const int SOURCE_DPAD = 513;
				/// <summary>
				///  <para>The input source is a touch screen pointing device.</para> <para> <para>SOURCE_CLASS_POINTER </para></para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_TOUCHSCREEN
				/// </java-name>
				[Dot42.DexImport("SOURCE_TOUCHSCREEN", "I", AccessFlags = 25)]
				public const int SOURCE_TOUCHSCREEN = 4098;
				/// <summary>
				///  <para>The input source is a mouse pointing device. This code is also used for other mouse-like pointing devices such as trackpads and trackpoints.</para> <para> <para>SOURCE_CLASS_POINTER </para></para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_MOUSE
				/// </java-name>
				[Dot42.DexImport("SOURCE_MOUSE", "I", AccessFlags = 25)]
				public const int SOURCE_MOUSE = 8194;
				/// <summary>
				///  <para>The input source is a trackball.</para> <para> <para>SOURCE_CLASS_TRACKBALL </para></para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_TRACKBALL
				/// </java-name>
				[Dot42.DexImport("SOURCE_TRACKBALL", "I", AccessFlags = 25)]
				public const int SOURCE_TRACKBALL = 65540;
				/// <summary>
				///  <para>The input source is a touch pad or digitizer tablet that is not associated with a display (unlike SOURCE_TOUCHSCREEN).</para> <para> <para>SOURCE_CLASS_POSITION </para></para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_TOUCHPAD
				/// </java-name>
				[Dot42.DexImport("SOURCE_TOUCHPAD", "I", AccessFlags = 25)]
				public const int SOURCE_TOUCHPAD = 1048584;
				/// <summary>
				///  <para>A special input source constant that is used when filtering input devices to match devices that provide any type of input source. </para>        
				/// </summary>
				/// <java-name>
				/// SOURCE_ANY
				/// </java-name>
				[Dot42.DexImport("SOURCE_ANY", "I", AccessFlags = 25)]
				public const int SOURCE_ANY = -256;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_X.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_X instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_X
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_X", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_X = 0;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_Y.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_Y instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_Y
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_Y", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_Y = 1;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_PRESSURE.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_PRESSURE instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_PRESSURE
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_PRESSURE", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_PRESSURE = 2;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_SIZE.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_SIZE instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_SIZE
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_SIZE", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_SIZE = 3;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_TOUCH_MAJOR.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_TOUCH_MAJOR instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_TOUCH_MAJOR
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_TOUCH_MAJOR", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_TOUCH_MAJOR = 4;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_TOUCH_MINOR.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_TOUCH_MINOR instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_TOUCH_MINOR
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_TOUCH_MINOR", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_TOUCH_MINOR = 5;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_TOOL_MAJOR.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_TOOL_MAJOR instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_TOOL_MAJOR
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_TOOL_MAJOR", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_TOOL_MAJOR = 6;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_TOOL_MINOR.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_TOOL_MINOR instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_TOOL_MINOR
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_TOOL_MINOR", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_TOOL_MINOR = 7;
				/// <summary>
				///  <para>Constant for retrieving the range of values for MotionEvent#AXIS_ORIENTATION.</para> <para> <para>getMotionRange </para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use MotionEvent#AXIS_ORIENTATION instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MOTION_RANGE_ORIENTATION
				/// </java-name>
				[Dot42.DexImport("MOTION_RANGE_ORIENTATION", "I", AccessFlags = 25)]
				public const int MOTION_RANGE_ORIENTATION = 8;
				/// <summary>
				///  <para>There is no keyboard. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARD_TYPE_NONE
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_TYPE_NONE", "I", AccessFlags = 25)]
				public const int KEYBOARD_TYPE_NONE = 0;
				/// <summary>
				///  <para>The keyboard is not fully alphabetic. It may be a numeric keypad or an assortment of buttons that are not mapped as alphabetic keys suitable for text input. </para>        
				/// </summary>
				/// <java-name>
				/// KEYBOARD_TYPE_NON_ALPHABETIC
				/// </java-name>
				[Dot42.DexImport("KEYBOARD_TYPE_NON_ALPHABETIC", "I", AccessFlags = 25)]
				public const int KEYBOARD_TYPE_NON_ALPHABETIC = 1;
				/// <summary>
				///  <para>The keyboard supports a complement of alphabetic keys. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Gets information about the input device with the specified id. </para>        
				/// </summary>
				/// <returns>
				///  <para>The input device or null if not found. </para>
				/// </returns>
				/// <java-name>
				/// getDevice
				/// </java-name>
				[Dot42.DexImport("getDevice", "(I)Landroid/view/InputDevice;", AccessFlags = 9)]
				public static global::Android.Views.InputDevice GetDevice(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.InputDevice);
				}

				/// <summary>
				///  <para>Gets information about the range of values for a particular MotionEvent axis. If the device supports multiple sources, the same axis may have different meanings for each source. Returns information about the first axis found for any source. To obtain information about the axis for a specific source, use getMotionRange(int, int).</para> <para> <para>MotionEvent::AXIS_X </para> <para>MotionEvent::AXIS_Y </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The range of values, or null if the requested axis is not supported by the device.</para>
				/// </returns>
				/// <java-name>
				/// getMotionRange
				/// </java-name>
				[Dot42.DexImport("getMotionRange", "(I)Landroid/view/InputDevice$MotionRange;", AccessFlags = 1)]
				public global::Android.Views.InputDevice.MotionRange GetMotionRange(int axis) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.InputDevice.MotionRange);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Gets the ids of all input devices in the system. </para>        
				/// </summary>
				/// <returns>
				///  <para>The input device ids. </para>
				/// </returns>
				/// <java-name>
				/// getDeviceIds
				/// </java-name>
				public static int[] DeviceIds
				{
						[Dot42.DexImport("getDeviceIds", "()[I", AccessFlags = 9)]
						get{ return default(int[]); }
				}

				/// <summary>
				///  <para>Gets the input device id. </para> <para>Each input device receives a unique id when it is first configured by the system. The input device id may change when the system is restarted or if the input device is disconnected, reconnected or reconfigured at any time. If you require a stable identifier for a device that persists across boots and reconfigurations, use getDescriptor(). </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The input device id. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public int Id
				{
						[Dot42.DexImport("getId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the name of this input device. </para>        
				/// </summary>
				/// <returns>
				///  <para>The input device name. </para>
				/// </returns>
				/// <java-name>
				/// getName
				/// </java-name>
				public string Name
				{
						[Dot42.DexImport("getName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Gets the input sources supported by this input device as a combined bitfield. </para>        
				/// </summary>
				/// <returns>
				///  <para>The supported input sources. </para>
				/// </returns>
				/// <java-name>
				/// getSources
				/// </java-name>
				public int Sources
				{
						[Dot42.DexImport("getSources", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the keyboard type. </para>        
				/// </summary>
				/// <returns>
				///  <para>The keyboard type. </para>
				/// </returns>
				/// <java-name>
				/// getKeyboardType
				/// </java-name>
				public int KeyboardType
				{
						[Dot42.DexImport("getKeyboardType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the key character map associated with this input device. </para>        
				/// </summary>
				/// <returns>
				///  <para>The key character map. </para>
				/// </returns>
				/// <java-name>
				/// getKeyCharacterMap
				/// </java-name>
				public global::Android.Views.KeyCharacterMap KeyCharacterMap
				{
						[Dot42.DexImport("getKeyCharacterMap", "()Landroid/view/KeyCharacterMap;", AccessFlags = 1)]
						get{ return default(global::Android.Views.KeyCharacterMap); }
				}

				/// <summary>
				///  <para>Provides information about the range of values for a particular MotionEvent axis.</para> <para> <para>InputDevice::getMotionRange(int) </para></para>    
				/// </summary>
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

						/// <summary>
						///  <para>Gets the inclusive minimum value for the axis. </para>        
						/// </summary>
						/// <returns>
						///  <para>The inclusive minimum value. </para>
						/// </returns>
						/// <java-name>
						/// getMin
						/// </java-name>
						public float Min
						{
								[Dot42.DexImport("getMin", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <summary>
						///  <para>Gets the inclusive maximum value for the axis. </para>        
						/// </summary>
						/// <returns>
						///  <para>The inclusive maximum value. </para>
						/// </returns>
						/// <java-name>
						/// getMax
						/// </java-name>
						public float Max
						{
								[Dot42.DexImport("getMax", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <summary>
						///  <para>Gets the range of the axis (difference between maximum and minimum). </para>        
						/// </summary>
						/// <returns>
						///  <para>The range of values. </para>
						/// </returns>
						/// <java-name>
						/// getRange
						/// </java-name>
						public float Range
						{
								[Dot42.DexImport("getRange", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <summary>
						///  <para>Gets the extent of the center flat position with respect to this axis. </para> <para>For example, a flat value of 8 means that the center position is between -8 and +8. This value is mainly useful for calibrating self-centering devices. </para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The extent of the center flat position. </para>
						/// </returns>
						/// <java-name>
						/// getFlat
						/// </java-name>
						public float Flat
						{
								[Dot42.DexImport("getFlat", "()F", AccessFlags = 1)]
								get{ return default(float); }
						}

						/// <summary>
						///  <para>Gets the error tolerance for input device measurements with respect to this axis. </para> <para>For example, a value of 2 indicates that the measured value may be up to +/- 2 units away from the actual value due to noise and device sensitivity limitations. </para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>The error tolerance. </para>
						/// </returns>
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

		/// <summary>
		///  <para>Common base class for input events. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				[Dot42.DexImport("android/os/Parcelable", "writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1025)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				///  <para>Gets the id for the device that this event came from. An id of zero indicates that the event didn't come from a physical device and maps to the default keymap. The other numbers are arbitrary and you shouldn't depend on the values.</para> <para> <para>InputDevice::getDevice </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The device id. </para>
				/// </returns>
				/// <java-name>
				/// getDeviceId
				/// </java-name>
				public int DeviceId
				{
						[Dot42.DexImport("getDeviceId", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the device that this event came from.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The device, or null if unknown. </para>
				/// </returns>
				/// <java-name>
				/// getDevice
				/// </java-name>
				public global::Android.Views.InputDevice Device
				{
						[Dot42.DexImport("getDevice", "()Landroid/view/InputDevice;", AccessFlags = 17)]
						get{ return default(global::Android.Views.InputDevice); }
				}

				/// <summary>
				///  <para>Gets the source of the event.</para> <para> <para>InputDevice::getSources </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The event source or InputDevice#SOURCE_UNKNOWN if unknown. </para>
				/// </returns>
				/// <java-name>
				/// getSource
				/// </java-name>
				public int Source
				{
						[Dot42.DexImport("getSource", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

		}

		/// <summary>
		///  <para>An input queue provides a mechanism for an application to receive incoming input events. Currently only usable from native code. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Interface to receive notification of when an InputQueue is associated and dissociated with a thread. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/InputQueue$Callback
				/// </java-name>
				[Dot42.DexImport("android/view/InputQueue$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the given InputQueue is now associated with the thread making this call, so it can start receiving events from it. </para>        
						/// </summary>
						/// <java-name>
						/// onInputQueueCreated
						/// </java-name>
						[Dot42.DexImport("onInputQueueCreated", "(Landroid/view/InputQueue;)V", AccessFlags = 1025)]
						void OnInputQueueCreated(global::Android.Views.InputQueue queue) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when the given InputQueue is no longer associated with the thread and thus not dispatching events. </para>        
						/// </summary>
						/// <java-name>
						/// onInputQueueDestroyed
						/// </java-name>
						[Dot42.DexImport("onInputQueueDestroyed", "(Landroid/view/InputQueue;)V", AccessFlags = 1025)]
						void OnInputQueueDestroyed(global::Android.Views.InputQueue queue) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Subclass of Menu for sub menus. </para> <para>Sub menus do not support item icons, or nested sub menus.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about creating menus, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/view/SubMenu
		/// </java-name>
		[Dot42.DexImport("android/view/SubMenu", AccessFlags = 1537)]
		public partial interface ISubMenu : global::Android.Views.IMenu
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Sets the submenu header's title to the title given in  <b>titleRes</b> resource identifier.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This SubMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderTitle
				/// </java-name>
				[Dot42.DexImport("setHeaderTitle", "(I)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderTitle(int titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the submenu header's title to the title given in  <b>titleRes</b> resource identifier.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This SubMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderTitle
				/// </java-name>
				[Dot42.DexImport("setHeaderTitle", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderTitle(global::Java.Lang.ICharSequence titleRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the submenu header's icon to the icon given in  <b>iconRes</b> resource id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This SubMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderIcon
				/// </java-name>
				[Dot42.DexImport("setHeaderIcon", "(I)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderIcon(int iconRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the submenu header's icon to the icon given in  <b>iconRes</b> resource id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This SubMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderIcon
				/// </java-name>
				[Dot42.DexImport("setHeaderIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderIcon(global::Android.Graphics.Drawables.Drawable iconRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the header of the submenu to the View given in  <b>view</b>. This replaces the header title and icon (and those replace this).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This SubMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setHeaderView
				/// </java-name>
				[Dot42.DexImport("setHeaderView", "(Landroid/view/View;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetHeaderView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Clears the header of the submenu. </para>        
				/// </summary>
				/// <java-name>
				/// clearHeader
				/// </java-name>
				[Dot42.DexImport("clearHeader", "()V", AccessFlags = 1025)]
				void ClearHeader() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the icon associated with this submenu's item in its parent menu.</para> <para> <para>MenuItem::setIcon(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This SubMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(I)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetIcon(int iconRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the icon associated with this submenu's item in its parent menu.</para> <para> <para>MenuItem::setIcon(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>This SubMenu so additional setters can be called. </para>
				/// </returns>
				/// <java-name>
				/// setIcon
				/// </java-name>
				[Dot42.DexImport("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/SubMenu;", AccessFlags = 1025)]
				global::Android.Views.ISubMenu SetIcon(global::Android.Graphics.Drawables.Drawable iconRes) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Gets the MenuItem that represents this submenu in the parent menu. Use this for setting additional item attributes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The MenuItem that launches the submenu when invoked. </para>
				/// </returns>
				/// <java-name>
				/// getItem
				/// </java-name>
				global::Android.Views.IMenuItem Item
				{
						[Dot42.DexImport("getItem", "()Landroid/view/MenuItem;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Abstract interface to someone holding a display surface. Allows you to control the surface size and format, edit the pixels in the surface, and monitor changes to the surface. This interface is typically available through the SurfaceView class.</para> <para>When using this interface from a thread other than the one running its SurfaceView, you will want to carefully read the methods lockCanvas and Callback.surfaceCreated(). </para>    
		/// </summary>
		/// <java-name>
		/// android/view/SurfaceHolder
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder", AccessFlags = 1537)]
		public partial interface ISurfaceHolder
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Add a Callback interface for this holder. There can several Callback interfaces associated with a holder.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addCallback
				/// </java-name>
				[Dot42.DexImport("addCallback", "(Landroid/view/SurfaceHolder$Callback;)V", AccessFlags = 1025)]
				void AddCallback(global::Android.Views.ISurfaceHolder_ICallback callback) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Removes a previously added Callback interface from this holder.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeCallback
				/// </java-name>
				[Dot42.DexImport("removeCallback", "(Landroid/view/SurfaceHolder$Callback;)V", AccessFlags = 1025)]
				void RemoveCallback(global::Android.Views.ISurfaceHolder_ICallback callback) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Sets the surface's type.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(I)V", AccessFlags = 1025)]
				void SetType(int type) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Make the surface a fixed size. It will never change from this size. When working with a SurfaceView, this must be called from the same thread running the SurfaceView's window.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFixedSize
				/// </java-name>
				[Dot42.DexImport("setFixedSize", "(II)V", AccessFlags = 1025)]
				void SetFixedSize(int width, int height) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Allow the surface to resized based on layout of its container (this is the default). When this is enabled, you should monitor Callback#surfaceChanged for changes to the size of the surface. When working with a SurfaceView, this must be called from the same thread running the SurfaceView's window. </para>        
				/// </summary>
				/// <java-name>
				/// setSizeFromLayout
				/// </java-name>
				[Dot42.DexImport("setSizeFromLayout", "()V", AccessFlags = 1025)]
				void SetSizeFromLayout() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the desired PixelFormat of the surface. The default is OPAQUE. When working with a SurfaceView, this must be called from the same thread running the SurfaceView's window.</para> <para> <para>android.graphics.PixelFormat </para></para>        
				/// </summary>
				/// <java-name>
				/// setFormat
				/// </java-name>
				[Dot42.DexImport("setFormat", "(I)V", AccessFlags = 1025)]
				void SetFormat(int format) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Enable or disable option to keep the screen turned on while this surface is displayed. The default is false, allowing it to turn off. This is safe to call from any thread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setKeepScreenOn
				/// </java-name>
				[Dot42.DexImport("setKeepScreenOn", "(Z)V", AccessFlags = 1025)]
				void SetKeepScreenOn(bool screenOn) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Start editing the pixels in the surface. The returned Canvas can be used to draw into the surface's bitmap. A null is returned if the surface has not been created or otherwise cannot be edited. You will usually need to implement Callback.surfaceCreated to find out when the Surface is available for use.</para> <para>The content of the Surface is never preserved between unlockCanvas() and lockCanvas(), for this reason, every pixel within the Surface area must be written. The only exception to this rule is when a dirty rectangle is specified, in which case, non-dirty pixels will be preserved.</para> <para>If you call this repeatedly when the Surface is not ready (before Callback.surfaceCreated or after Callback.surfaceDestroyed), your calls will be throttled to a slow rate in order to avoid consuming CPU.</para> <para>If null is not returned, this function internally holds a lock until the corresponding unlockCanvasAndPost call, preventing SurfaceView from creating, destroying, or modifying the surface while it is being drawn. This can be more convenient than accessing the Surface directly, as you do not need to do special synchronization with a drawing thread in Callback.surfaceDestroyed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Canvas Use to draw into the surface. </para>
				/// </returns>
				/// <java-name>
				/// lockCanvas
				/// </java-name>
				[Dot42.DexImport("lockCanvas", "()Landroid/graphics/Canvas;", AccessFlags = 1025)]
				global::Android.Graphics.Canvas LockCanvas() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Just like lockCanvas() but allows specification of a dirty rectangle. Every pixel within that rectangle must be written; however pixels outside the dirty rectangle will be preserved by the next call to lockCanvas().</para> <para> <para>android.view.SurfaceHolder::lockCanvas</para></para>        
				/// </summary>
				/// <returns>
				///  <para>Canvas Use to draw into the surface. </para>
				/// </returns>
				/// <java-name>
				/// lockCanvas
				/// </java-name>
				[Dot42.DexImport("lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", AccessFlags = 1025)]
				global::Android.Graphics.Canvas LockCanvas(global::Android.Graphics.Rect dirty) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Finish editing pixels in the surface. After this call, the surface's current pixels will be shown on the screen, but its content is lost, in particular there is no guarantee that the content of the Surface will remain unchanged when lockCanvas() is called again.</para> <para> <para>lockCanvas()</para></para>        
				/// </summary>
				/// <java-name>
				/// unlockCanvasAndPost
				/// </java-name>
				[Dot42.DexImport("unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", AccessFlags = 1025)]
				void UnlockCanvasAndPost(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Use this method to find out if the surface is in the process of being created from Callback methods. This is intended to be used with Callback#surfaceChanged.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the surface is in the process of being created. </para>
				/// </returns>
				/// <java-name>
				/// isCreating
				/// </java-name>
				bool IsCreating
				{
						[Dot42.DexImport("isCreating", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Retrieve the current size of the surface. Note: do not modify the returned Rect. This is only safe to call from the thread of SurfaceView's window, or while inside of lockCanvas().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Rect The surface's dimensions. The left and top are always 0. </para>
				/// </returns>
				/// <java-name>
				/// getSurfaceFrame
				/// </java-name>
				global::Android.Graphics.Rect SurfaceFrame
				{
						[Dot42.DexImport("getSurfaceFrame", "()Landroid/graphics/Rect;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Direct access to the surface object. The Surface may not always be available  for example when using a SurfaceView the holder's Surface is not created until the view has been attached to the window manager and performed a layout in order to determine the dimensions and screen position of the Surface. You will thus usually need to implement Callback.surfaceCreated to find out when the Surface is available for use.</para> <para>Note that if you directly access the Surface from another thread, it is critical that you correctly implement Callback.surfaceCreated and Callback.surfaceDestroyed to ensure that thread only accesses the Surface while it is valid, and that the Surface does not get destroyed while the thread is using it.</para> <para>This method is intended to be used by frameworks which often need direct access to the Surface object (usually to pass it to native code).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Surface The surface. </para>
				/// </returns>
				/// <java-name>
				/// getSurface
				/// </java-name>
				global::Android.Views.Surface Surface
				{
						[Dot42.DexImport("getSurface", "()Landroid/view/Surface;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Exception that is thrown from lockCanvas when called on a Surface whose type is SURFACE_TYPE_PUSH_BUFFERS. </para>    
		/// </summary>
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

		/// <summary>
		///  <para>A client may implement this interface to receive information about changes to the surface. When used with a SurfaceView, the Surface being held is only available between calls to surfaceCreated(SurfaceHolder) and surfaceDestroyed(SurfaceHolder). The Callback is set with SurfaceHolder.addCallback method. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/SurfaceHolder$Callback
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder$Callback", AccessFlags = 1545)]
		public partial interface ISurfaceHolder_ICallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This is called immediately after the surface is first created. Implementations of this should start up whatever rendering code they desire. Note that only one thread can ever draw into a Surface, so you should not draw into the Surface here if your normal rendering will be in another thread.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// surfaceCreated
				/// </java-name>
				[Dot42.DexImport("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1025)]
				void SurfaceCreated(global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This is called immediately after any structural changes (format or size) have been made to the surface. You should at this point update the imagery in the surface. This method is always called at least once, after surfaceCreated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// surfaceChanged
				/// </java-name>
				[Dot42.DexImport("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", AccessFlags = 1025)]
				void SurfaceChanged(global::Android.Views.ISurfaceHolder holder, int format, int width, int height) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This is called immediately before a surface is being destroyed. After returning from this call, you should no longer try to access this surface. If you have a rendering thread that directly accesses the surface, you must ensure that thread is no longer touching the Surface before returning from this function.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// surfaceDestroyed
				/// </java-name>
				[Dot42.DexImport("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1025)]
				void SurfaceDestroyed(global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Additional callbacks that can be received for Callback. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/SurfaceHolder$Callback2
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder$Callback2", AccessFlags = 1545)]
		public partial interface ISurfaceHolder_ICallback2 : global::Android.Views.ISurfaceHolder_ICallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called when the application needs to redraw the content of its surface, after it is resized or for some other reason. By not returning from here until the redraw is complete, you can ensure that the user will not see your surface in a bad state (at its new size before it has been correctly drawn that way). This will typically be preceeded by a call to surfaceChanged.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// surfaceRedrawNeeded
				/// </java-name>
				[Dot42.DexImport("surfaceRedrawNeeded", "(Landroid/view/SurfaceHolder;)V", AccessFlags = 1025)]
				void SurfaceRedrawNeeded(global::Android.Views.ISurfaceHolder holder) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Abstract interface to someone holding a display surface. Allows you to control the surface size and format, edit the pixels in the surface, and monitor changes to the surface. This interface is typically available through the SurfaceView class.</para> <para>When using this interface from a thread other than the one running its SurfaceView, you will want to carefully read the methods lockCanvas and Callback.surfaceCreated(). </para>    
		/// </summary>
		/// <java-name>
		/// android/view/SurfaceHolder
		/// </java-name>
		[Dot42.DexImport("android/view/SurfaceHolder", AccessFlags = 1537, IgnoreFromJava = true, Priority = 1)]
		public static partial class ISurfaceHolderConstants
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SURFACE_TYPE_NORMAL
				/// </java-name>
				[Dot42.DexImport("SURFACE_TYPE_NORMAL", "I", AccessFlags = 25)]
				public const int SURFACE_TYPE_NORMAL = 0;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SURFACE_TYPE_HARDWARE
				/// </java-name>
				[Dot42.DexImport("SURFACE_TYPE_HARDWARE", "I", AccessFlags = 25)]
				public const int SURFACE_TYPE_HARDWARE = 1;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SURFACE_TYPE_GPU
				/// </java-name>
				[Dot42.DexImport("SURFACE_TYPE_GPU", "I", AccessFlags = 25)]
				public const int SURFACE_TYPE_GPU = 2;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// SURFACE_TYPE_PUSH_BUFFERS
				/// </java-name>
				[Dot42.DexImport("SURFACE_TYPE_PUSH_BUFFERS", "I", AccessFlags = 25)]
				public const int SURFACE_TYPE_PUSH_BUFFERS = 3;
		}

		/// <summary>
		///  <para>Interface to let you add and remove child views to an Activity. To get an instance of this class, call Context.getSystemService(). </para>    
		/// </summary>
		/// <java-name>
		/// android/view/ViewManager
		/// </java-name>
		[Dot42.DexImport("android/view/ViewManager", AccessFlags = 1537)]
		public partial interface IViewManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Assign the passed LayoutParams to the passed View and add the view to the window. </para> <para>Throws android.view.WindowManager.BadTokenException for certain programming errors, such as adding a second view to a window without removing the first view. </para> <para>Throws android.view.WindowManager.InvalidDisplayException if the window is on a secondary Display and the specified display can't be found (see android.app.Presentation). </para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1025)]
				void AddView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// updateViewLayout
				/// </java-name>
				[Dot42.DexImport("updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1025)]
				void UpdateViewLayout(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// removeView
				/// </java-name>
				[Dot42.DexImport("removeView", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void RemoveView(global::Android.Views.View view) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		///  <para>Defines the responsibilities for a class that will be a parent of a View. This is the API that a view sees when it wants to interact with its parent. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/ViewParent
		/// </java-name>
		[Dot42.DexImport("android/view/ViewParent", AccessFlags = 1537)]
		public partial interface IViewParent
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Called when something has changed which has invalidated the layout of a child of this view parent. This will schedule a layout pass of the view tree. </para>        
				/// </summary>
				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1025)]
				void RequestLayout() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when a child wants the view hierarchy to gather and report transparent regions to the window compositor. Views that "punch" holes in the view hierarchy, such as SurfaceView can use this API to improve performance of the system. When no such a view is present in the hierarchy, this optimization in unnecessary and might slightly reduce the view hierarchy performance.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestTransparentRegion
				/// </java-name>
				[Dot42.DexImport("requestTransparentRegion", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void RequestTransparentRegion(global::Android.Views.View child) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>All or part of a child is dirty and needs to be redrawn.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateChild
				/// </java-name>
				[Dot42.DexImport("invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V", AccessFlags = 1025)]
				void InvalidateChild(global::Android.Views.View child, global::Android.Graphics.Rect r) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>All or part of a child is dirty and needs to be redrawn.</para> <para>The location array is an array of two int values which respectively define the left and the top position of the dirty child.</para> <para>This method must return the parent of this ViewParent if the specified rectangle must be invalidated in the parent. If the specified rectangle does not require invalidation in the parent or if the parent does not exist, this method must return null.</para> <para>When this method returns a non-null value, the location array must have been updated with the left and top coordinates of this ViewParent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the parent of this ViewParent or null </para>
				/// </returns>
				/// <java-name>
				/// invalidateChildInParent
				/// </java-name>
				[Dot42.DexImport("invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;", AccessFlags = 1025)]
				global::Android.Views.IViewParent InvalidateChildInParent(int[] location, global::Android.Graphics.Rect r) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when a child of this parent wants focus</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestChildFocus
				/// </java-name>
				[Dot42.DexImport("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1025)]
				void RequestChildFocus(global::Android.Views.View child, global::Android.Views.View focused) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Tell view hierarchy that the global view attributes need to be re-evaluated.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// recomputeViewAttributes
				/// </java-name>
				[Dot42.DexImport("recomputeViewAttributes", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void RecomputeViewAttributes(global::Android.Views.View child) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when a child of this parent is giving up focus</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// clearChildFocus
				/// </java-name>
				[Dot42.DexImport("clearChildFocus", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void ClearChildFocus(global::Android.Views.View child) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Compute the visible part of a rectangular region defined in terms of a child view's coordinates.</para> <para>Returns the clipped visible part of the rectangle  <code>r</code>, defined in the  <code>child</code>'s local coordinate system.  <code>r</code> is modified by this method to contain the result, expressed in the global (root) coordinate system.</para> <para>The resulting rectangle is always axis aligned. If a rotation is applied to a node in the View hierarchy, the result is the axis-aligned bounding box of the visible rectangle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting rectangle is not empty, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// getChildVisibleRect
				/// </java-name>
				[Dot42.DexImport("getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z", AccessFlags = 1025)]
				bool GetChildVisibleRect(global::Android.Views.View child, global::Android.Graphics.Rect r, global::Android.Graphics.Point offset) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Find the nearest view in the specified direction that wants to take focus</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// focusSearch
				/// </java-name>
				[Dot42.DexImport("focusSearch", "(Landroid/view/View;I)Landroid/view/View;", AccessFlags = 1025)]
				global::Android.Views.View FocusSearch(global::Android.Views.View v, int direction) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the z order of the child so it's on top of all other children. This ordering change may affect layout, if this container uses an order-dependent layout scheme (e.g., LinearLayout). Prior to android.os.Build.VERSION_CODES#KITKAT this method should be followed by calls to requestLayout() and View#invalidate() on this parent to force the parent to redraw with the new child ordering.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// bringChildToFront
				/// </java-name>
				[Dot42.DexImport("bringChildToFront", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void BringChildToFront(global::Android.Views.View child) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Tells the parent that a new focusable view has become available. This is to handle transitions from the case where there are no focusable views to the case where the first focusable view appears.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// focusableViewAvailable
				/// </java-name>
				[Dot42.DexImport("focusableViewAvailable", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void FocusableViewAvailable(global::Android.Views.View v) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Bring up a context menu for the specified view or its ancestors.</para> <para>In most cases, a subclass does not need to override this. However, if the subclass is added directly to the window manager (for example, ViewManager#addView(View, android.view.ViewGroup.LayoutParams)) then it should override this and show the context menu.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if a context menu was displayed </para>
				/// </returns>
				/// <java-name>
				/// showContextMenuForChild
				/// </java-name>
				[Dot42.DexImport("showContextMenuForChild", "(Landroid/view/View;)Z", AccessFlags = 1025)]
				bool ShowContextMenuForChild(global::Android.Views.View originalView) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Have the parent populate the specified context menu if it has anything to add (and then recurse on its parent).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createContextMenu
				/// </java-name>
				[Dot42.DexImport("createContextMenu", "(Landroid/view/ContextMenu;)V", AccessFlags = 1025)]
				void CreateContextMenu(global::Android.Views.IContextMenu menu) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method is called on the parent when a child's drawable state has changed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// childDrawableStateChanged
				/// </java-name>
				[Dot42.DexImport("childDrawableStateChanged", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void ChildDrawableStateChanged(global::Android.Views.View child) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when a child does not want this parent and its ancestors to intercept touch events with ViewGroup#onInterceptTouchEvent(MotionEvent).</para> <para>This parent should pass this call onto its parents. This parent must obey this request for the duration of the touch (that is, only clear the flag after this parent has received an up or a cancel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// requestDisallowInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("requestDisallowInterceptTouchEvent", "(Z)V", AccessFlags = 1025)]
				void RequestDisallowInterceptTouchEvent(bool disallowIntercept) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Called when a child of this group wants a particular rectangle to be positioned onto the screen. ViewGroups overriding this can trust that:  <ul> <li> <para>child will be a direct child of this group </para></li> <li> <para>rectangle will be in the child's coordinates </para></li></ul></para> <para>ViewGroups overriding this should uphold the contract:</para> <para> <ul> <li> <para>nothing will change if the rectangle is already visible </para></li> <li> <para>the view port will be scrolled only just enough to make the rectangle visible  <ul> <li></li></ul>child The direct child making the request. </para></li></ul></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the group scrolled to handle the operation </para>
				/// </returns>
				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1025)]
				bool RequestChildRectangleOnScreen(global::Android.Views.View child, global::Android.Graphics.Rect rectangle, bool immediate) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Indicates whether layout was requested on this view parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if layout was requested, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// isLayoutRequested
				/// </java-name>
				bool IsLayoutRequested
				{
						[Dot42.DexImport("isLayoutRequested", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Returns the parent if it exists, or null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a ViewParent or null if this ViewParent does not have a parent </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				global::Android.Views.IViewParent Parent
				{
						[Dot42.DexImport("getParent", "()Landroid/view/ViewParent;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>The interface that apps use to talk to the window manager. </para> <para>Use  <code>Context.getSystemService(Context.WINDOW_SERVICE)</code> to get one of these. </para> <para>Each window manager instance is bound to a particular Display. To obtain a WindowManager for a different display, use Context#createDisplayContext to obtain a Context for that display, then use  <code>Context.getSystemService(Context.WINDOW_SERVICE)</code> to get the WindowManager. </para> <para>The simplest way to show a window on another display is to create a Presentation. The presentation will automatically obtain a WindowManager and Context for that display. </para> <para> <para>android.content.Context::getSystemService </para> <para>android.content.Context::WINDOW_SERVICE </para></para>    
		/// </summary>
		/// <java-name>
		/// android/view/WindowManager
		/// </java-name>
		[Dot42.DexImport("android/view/WindowManager", AccessFlags = 1537)]
		public partial interface IWindowManager : global::Android.Views.IViewManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Special variation of removeView that immediately invokes the given view hierarchy's View.onDetachedFromWindow() methods before returning. This is not for normal applications; using it correctly requires great care.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeViewImmediate
				/// </java-name>
				[Dot42.DexImport("removeViewImmediate", "(Landroid/view/View;)V", AccessFlags = 1025)]
				void RemoveViewImmediate(global::Android.Views.View view) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns the Display upon which this WindowManager instance will create new windows. </para> <para>Despite the name of this method, the display that is returned is not necessarily the primary display of the system (see Display#DEFAULT_DISPLAY). The returned display could instead be a secondary display that this window manager instance is managing. Think of it as the display that this WindowManager instance uses by default. </para> <para>To create windows on a different display, you need to obtain a WindowManager for that Display. (See the WindowManager class documentation for more information.) </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The display that this window manager is managing. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultDisplay
				/// </java-name>
				global::Android.Views.Display DefaultDisplay
				{
						[Dot42.DexImport("getDefaultDisplay", "()Landroid/view/Display;", AccessFlags = 1025)]
						get;
				}

		}

		/// <summary>
		///  <para>Exception that is thrown when trying to add view whose WindowManager.LayoutParams WindowManager.LayoutParams#token is invalid. </para>    
		/// </summary>
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
				/// <summary>
				///  <para>X position for this window. With the default gravity it is ignored. When using Gravity#LEFT or Gravity#START or Gravity#RIGHT or Gravity#END it provides an offset from the given edge. </para>        
				/// </summary>
				/// <java-name>
				/// x
				/// </java-name>
				[Dot42.DexImport("x", "I", AccessFlags = 1)]
				public int X;
				/// <summary>
				///  <para>Y position for this window. With the default gravity it is ignored. When using Gravity#TOP or Gravity#BOTTOM it provides an offset from the given edge. </para>        
				/// </summary>
				/// <java-name>
				/// y
				/// </java-name>
				[Dot42.DexImport("y", "I", AccessFlags = 1)]
				public int Y;
				/// <summary>
				///  <para>Indicates how much of the extra space will be allocated horizontally to the view associated with these LayoutParams. Specify 0 if the view should not be stretched. Otherwise the extra pixels will be pro-rated among all views whose weight is greater than 0. </para>        
				/// </summary>
				/// <java-name>
				/// horizontalWeight
				/// </java-name>
				[Dot42.DexImport("horizontalWeight", "F", AccessFlags = 1)]
				public float HorizontalWeight;
				/// <summary>
				///  <para>Indicates how much of the extra space will be allocated vertically to the view associated with these LayoutParams. Specify 0 if the view should not be stretched. Otherwise the extra pixels will be pro-rated among all views whose weight is greater than 0. </para>        
				/// </summary>
				/// <java-name>
				/// verticalWeight
				/// </java-name>
				[Dot42.DexImport("verticalWeight", "F", AccessFlags = 1)]
				public float VerticalWeight;
				/// <summary>
				///  <para>The general type of window. There are three main classes of window types:  <ul> <li> <para> <b>Application windows</b> (ranging from FIRST_APPLICATION_WINDOW to LAST_APPLICATION_WINDOW) are normal top-level application windows. For these types of windows, the token must be set to the token of the activity they are a part of (this will normally be done for you if token is null). </para></li> <li> <para> <b>Sub-windows</b> (ranging from FIRST_SUB_WINDOW to LAST_SUB_WINDOW) are associated with another top-level window. For these types of windows, the token must be the token of the window it is attached to. </para></li> <li> <para> <b>System windows</b> (ranging from FIRST_SYSTEM_WINDOW to LAST_SYSTEM_WINDOW) are special types of windows for use by the system for specific purposes. They should not normally be used by applications, and a special permission is required to use them. </para></li></ul></para> <para> <para>TYPE_BASE_APPLICATION </para> <para>TYPE_APPLICATION </para> <para>TYPE_APPLICATION_STARTING </para> <para>TYPE_APPLICATION_PANEL </para> <para>TYPE_APPLICATION_MEDIA </para> <para>TYPE_APPLICATION_SUB_PANEL </para> <para>TYPE_APPLICATION_ATTACHED_DIALOG </para> <para>TYPE_STATUS_BAR </para> <para>TYPE_SEARCH_BAR </para> <para>TYPE_PHONE </para> <para>TYPE_SYSTEM_ALERT </para> <para>TYPE_KEYGUARD </para> <para>TYPE_TOAST </para> <para>TYPE_SYSTEM_OVERLAY </para> <para>TYPE_PRIORITY_PHONE </para> <para>TYPE_STATUS_BAR_PANEL </para> <para>TYPE_SYSTEM_DIALOG </para> <para>TYPE_KEYGUARD_DIALOG </para> <para>TYPE_SYSTEM_ERROR </para> <para>TYPE_INPUT_METHOD </para> <para>TYPE_INPUT_METHOD_DIALOG </para></para>        
				/// </summary>
				/// <java-name>
				/// type
				/// </java-name>
				[Dot42.DexImport("type", "I", AccessFlags = 1)]
				public int Type;
				/// <summary>
				///  <para>Start of window types that represent normal application windows. </para>        
				/// </summary>
				/// <java-name>
				/// FIRST_APPLICATION_WINDOW
				/// </java-name>
				[Dot42.DexImport("FIRST_APPLICATION_WINDOW", "I", AccessFlags = 25)]
				public const int FIRST_APPLICATION_WINDOW = 1;
				/// <summary>
				///  <para>Window type: an application window that serves as the "base" window of the overall application; all other application windows will appear on top of it. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_BASE_APPLICATION
				/// </java-name>
				[Dot42.DexImport("TYPE_BASE_APPLICATION", "I", AccessFlags = 25)]
				public const int TYPE_BASE_APPLICATION = 1;
				/// <summary>
				///  <para>Window type: a normal application window. The token must be an Activity token identifying who the window belongs to. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_APPLICATION
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION = 2;
				/// <summary>
				///  <para>Window type: special application window that is displayed while the application is starting. Not for use by applications themselves; this is used by the system to display something until the application can show its own windows. In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_APPLICATION_STARTING
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_STARTING", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_STARTING = 3;
				/// <summary>
				///  <para>End of types of application windows. </para>        
				/// </summary>
				/// <java-name>
				/// LAST_APPLICATION_WINDOW
				/// </java-name>
				[Dot42.DexImport("LAST_APPLICATION_WINDOW", "I", AccessFlags = 25)]
				public const int LAST_APPLICATION_WINDOW = 99;
				/// <summary>
				///  <para>Start of types of sub-windows. The token of these windows must be set to the window they are attached to. These types of windows are kept next to their attached window in Z-order, and their coordinate space is relative to their attached window. </para>        
				/// </summary>
				/// <java-name>
				/// FIRST_SUB_WINDOW
				/// </java-name>
				[Dot42.DexImport("FIRST_SUB_WINDOW", "I", AccessFlags = 25)]
				public const int FIRST_SUB_WINDOW = 1000;
				/// <summary>
				///  <para>Window type: a panel on top of an application window. These windows appear on top of their attached window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_APPLICATION_PANEL
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_PANEL", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_PANEL = 1000;
				/// <summary>
				///  <para>Window type: window for showing media (such as video). These windows are displayed behind their attached window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_APPLICATION_MEDIA
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_MEDIA", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_MEDIA = 1001;
				/// <summary>
				///  <para>Window type: a sub-panel on top of an application window. These windows are displayed on top their attached window and any TYPE_APPLICATION_PANEL panels. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_APPLICATION_SUB_PANEL
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_SUB_PANEL", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_SUB_PANEL = 1002;
				/// <summary>
				///  <para>Window type: like TYPE_APPLICATION_PANEL, but layout of the window happens as that of a top-level window,  <b>not</b> as a child of its container. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_APPLICATION_ATTACHED_DIALOG
				/// </java-name>
				[Dot42.DexImport("TYPE_APPLICATION_ATTACHED_DIALOG", "I", AccessFlags = 25)]
				public const int TYPE_APPLICATION_ATTACHED_DIALOG = 1003;
				/// <summary>
				///  <para>End of types of sub-windows. </para>        
				/// </summary>
				/// <java-name>
				/// LAST_SUB_WINDOW
				/// </java-name>
				[Dot42.DexImport("LAST_SUB_WINDOW", "I", AccessFlags = 25)]
				public const int LAST_SUB_WINDOW = 1999;
				/// <summary>
				///  <para>Start of system-specific window types. These are not normally created by applications. </para>        
				/// </summary>
				/// <java-name>
				/// FIRST_SYSTEM_WINDOW
				/// </java-name>
				[Dot42.DexImport("FIRST_SYSTEM_WINDOW", "I", AccessFlags = 25)]
				public const int FIRST_SYSTEM_WINDOW = 2000;
				/// <summary>
				///  <para>Window type: the status bar. There can be only one status bar window; it is placed at the top of the screen, and all other windows are shifted down so they are below it. In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_STATUS_BAR
				/// </java-name>
				[Dot42.DexImport("TYPE_STATUS_BAR", "I", AccessFlags = 25)]
				public const int TYPE_STATUS_BAR = 2000;
				/// <summary>
				///  <para>Window type: the search bar. There can be only one search bar window; it is placed at the top of the screen. In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_SEARCH_BAR
				/// </java-name>
				[Dot42.DexImport("TYPE_SEARCH_BAR", "I", AccessFlags = 25)]
				public const int TYPE_SEARCH_BAR = 2001;
				/// <summary>
				///  <para>Window type: phone. These are non-application windows providing user interaction with the phone (in particular incoming calls). These windows are normally placed above all applications, but behind the status bar. In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PHONE
				/// </java-name>
				[Dot42.DexImport("TYPE_PHONE", "I", AccessFlags = 25)]
				public const int TYPE_PHONE = 2002;
				/// <summary>
				///  <para>Window type: system window, such as low power alert. These windows are always on top of application windows. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_SYSTEM_ALERT
				/// </java-name>
				[Dot42.DexImport("TYPE_SYSTEM_ALERT", "I", AccessFlags = 25)]
				public const int TYPE_SYSTEM_ALERT = 2003;
				/// <summary>
				///  <para>Window type: keyguard window. In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_KEYGUARD
				/// </java-name>
				[Dot42.DexImport("TYPE_KEYGUARD", "I", AccessFlags = 25)]
				public const int TYPE_KEYGUARD = 2004;
				/// <summary>
				///  <para>Window type: transient notifications. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TOAST
				/// </java-name>
				[Dot42.DexImport("TYPE_TOAST", "I", AccessFlags = 25)]
				public const int TYPE_TOAST = 2005;
				/// <summary>
				///  <para>Window type: system overlay windows, which need to be displayed on top of everything else. These windows must not take input focus, or they will interfere with the keyguard. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_SYSTEM_OVERLAY
				/// </java-name>
				[Dot42.DexImport("TYPE_SYSTEM_OVERLAY", "I", AccessFlags = 25)]
				public const int TYPE_SYSTEM_OVERLAY = 2006;
				/// <summary>
				///  <para>Window type: priority phone UI, which needs to be displayed even if the keyguard is active. These windows must not take input focus, or they will interfere with the keyguard. In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_PRIORITY_PHONE
				/// </java-name>
				[Dot42.DexImport("TYPE_PRIORITY_PHONE", "I", AccessFlags = 25)]
				public const int TYPE_PRIORITY_PHONE = 2007;
				/// <summary>
				///  <para>Window type: panel that slides out from the status bar In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_SYSTEM_DIALOG
				/// </java-name>
				[Dot42.DexImport("TYPE_SYSTEM_DIALOG", "I", AccessFlags = 25)]
				public const int TYPE_SYSTEM_DIALOG = 2008;
				/// <summary>
				///  <para>Window type: dialogs that the keyguard shows In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_KEYGUARD_DIALOG
				/// </java-name>
				[Dot42.DexImport("TYPE_KEYGUARD_DIALOG", "I", AccessFlags = 25)]
				public const int TYPE_KEYGUARD_DIALOG = 2009;
				/// <summary>
				///  <para>Window type: internal system error windows, appear on top of everything they can. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_SYSTEM_ERROR
				/// </java-name>
				[Dot42.DexImport("TYPE_SYSTEM_ERROR", "I", AccessFlags = 25)]
				public const int TYPE_SYSTEM_ERROR = 2010;
				/// <summary>
				///  <para>Window type: internal input methods windows, which appear above the normal UI. Application windows may be resized or panned to keep the input focus visible while this window is displayed. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INPUT_METHOD
				/// </java-name>
				[Dot42.DexImport("TYPE_INPUT_METHOD", "I", AccessFlags = 25)]
				public const int TYPE_INPUT_METHOD = 2011;
				/// <summary>
				///  <para>Window type: internal input methods dialog windows, which appear above the current input method window. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_INPUT_METHOD_DIALOG
				/// </java-name>
				[Dot42.DexImport("TYPE_INPUT_METHOD_DIALOG", "I", AccessFlags = 25)]
				public const int TYPE_INPUT_METHOD_DIALOG = 2012;
				/// <summary>
				///  <para>Window type: wallpaper window, placed behind any window that wants to sit on top of the wallpaper. In multiuser systems shows only on the owning user's window. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("TYPE_WALLPAPER", "I", AccessFlags = 25)]
				public const int TYPE_WALLPAPER = 2013;
				/// <summary>
				///  <para>Window type: panel that slides out from over the status bar In multiuser systems shows on all users' windows. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_STATUS_BAR_PANEL
				/// </java-name>
				[Dot42.DexImport("TYPE_STATUS_BAR_PANEL", "I", AccessFlags = 25)]
				public const int TYPE_STATUS_BAR_PANEL = 2014;
				/// <summary>
				///  <para>End of types of system windows. </para>        
				/// </summary>
				/// <java-name>
				/// LAST_SYSTEM_WINDOW
				/// </java-name>
				[Dot42.DexImport("LAST_SYSTEM_WINDOW", "I", AccessFlags = 25)]
				public const int LAST_SYSTEM_WINDOW = 2999;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// memoryType
				/// </java-name>
				[Dot42.DexImport("memoryType", "I", AccessFlags = 1)]
				public int MemoryType;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MEMORY_TYPE_NORMAL
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_NORMAL", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_NORMAL = 0;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MEMORY_TYPE_HARDWARE
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_HARDWARE", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_HARDWARE = 1;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MEMORY_TYPE_GPU
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_GPU", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_GPU = 2;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>this is ignored, this value is set automatically when needed. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MEMORY_TYPE_PUSH_BUFFERS
				/// </java-name>
				[Dot42.DexImport("MEMORY_TYPE_PUSH_BUFFERS", "I", AccessFlags = 25)]
				public const int MEMORY_TYPE_PUSH_BUFFERS = 3;
				/// <summary>
				///  <para>Various behavioral options/flags. Default is none.</para> <para> <para>FLAG_ALLOW_LOCK_WHILE_SCREEN_ON </para> <para>FLAG_DIM_BEHIND </para> <para>FLAG_NOT_FOCUSABLE </para> <para>FLAG_NOT_TOUCHABLE </para> <para>FLAG_NOT_TOUCH_MODAL </para> <para>FLAG_TOUCHABLE_WHEN_WAKING </para> <para>FLAG_KEEP_SCREEN_ON </para> <para>FLAG_LAYOUT_IN_SCREEN </para> <para>FLAG_LAYOUT_NO_LIMITS </para> <para>FLAG_FULLSCREEN </para> <para>FLAG_FORCE_NOT_FULLSCREEN </para> <para>FLAG_SECURE </para> <para>FLAG_SCALED </para> <para>FLAG_IGNORE_CHEEK_PRESSES </para> <para>FLAG_LAYOUT_INSET_DECOR </para> <para>FLAG_ALT_FOCUSABLE_IM </para> <para>FLAG_WATCH_OUTSIDE_TOUCH </para> <para>FLAG_SHOW_WHEN_LOCKED </para> <para>FLAG_SHOW_WALLPAPER </para> <para>FLAG_TURN_SCREEN_ON </para> <para>FLAG_DISMISS_KEYGUARD </para> <para>FLAG_SPLIT_TOUCH </para> <para>FLAG_HARDWARE_ACCELERATED </para> <para>FLAG_LOCAL_FOCUS_MODE </para></para>        
				/// </summary>
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <summary>
				///  <para>Window flag: as long as this window is visible to the user, allow the lock screen to activate while the screen is on. This can be used independently, or in combination with FLAG_KEEP_SCREEN_ON and/or FLAG_SHOW_WHEN_LOCKED </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALLOW_LOCK_WHILE_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("FLAG_ALLOW_LOCK_WHILE_SCREEN_ON", "I", AccessFlags = 25)]
				public const int FLAG_ALLOW_LOCK_WHILE_SCREEN_ON = 1;
				/// <summary>
				///  <para>Window flag: everything behind this window will be dimmed. Use dimAmount to control the amount of dim. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_DIM_BEHIND
				/// </java-name>
				[Dot42.DexImport("FLAG_DIM_BEHIND", "I", AccessFlags = 25)]
				public const int FLAG_DIM_BEHIND = 2;
				/// <summary>
				///  <para>Window flag: blur everything behind this window.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Blurring is no longer supported. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// FLAG_BLUR_BEHIND
				/// </java-name>
				[Dot42.DexImport("FLAG_BLUR_BEHIND", "I", AccessFlags = 25)]
				public const int FLAG_BLUR_BEHIND = 4;
				/// <summary>
				///  <para>Window flag: this window won't ever get key input focus, so the user can not send key or other button events to it. Those will instead go to whatever focusable window is behind it. This flag will also enable FLAG_NOT_TOUCH_MODAL whether or not that is explicitly set.</para> <para>Setting this flag also implies that the window will not need to interact with a soft input method, so it will be Z-ordered and positioned independently of any active input method (typically this means it gets Z-ordered on top of the input method, so it can use the full screen for its content and cover the input method if needed. You can use FLAG_ALT_FOCUSABLE_IM to modify this behavior. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_NOT_FOCUSABLE
				/// </java-name>
				[Dot42.DexImport("FLAG_NOT_FOCUSABLE", "I", AccessFlags = 25)]
				public const int FLAG_NOT_FOCUSABLE = 8;
				/// <summary>
				///  <para>Window flag: this window can never receive touch events. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_NOT_TOUCHABLE
				/// </java-name>
				[Dot42.DexImport("FLAG_NOT_TOUCHABLE", "I", AccessFlags = 25)]
				public const int FLAG_NOT_TOUCHABLE = 16;
				/// <summary>
				///  <para>Window flag: even when this window is focusable (its FLAG_NOT_FOCUSABLE is not set), allow any pointer events outside of the window to be sent to the windows behind it. Otherwise it will consume all pointer events itself, regardless of whether they are inside of the window. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_NOT_TOUCH_MODAL
				/// </java-name>
				[Dot42.DexImport("FLAG_NOT_TOUCH_MODAL", "I", AccessFlags = 25)]
				public const int FLAG_NOT_TOUCH_MODAL = 32;
				/// <summary>
				///  <para>Window flag: when set, if the device is asleep when the touch screen is pressed, you will receive this first touch event. Usually the first touch event is consumed by the system since the user can not see what they are pressing on. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_TOUCHABLE_WHEN_WAKING
				/// </java-name>
				[Dot42.DexImport("FLAG_TOUCHABLE_WHEN_WAKING", "I", AccessFlags = 25)]
				public const int FLAG_TOUCHABLE_WHEN_WAKING = 64;
				/// <summary>
				///  <para>Window flag: as long as this window is visible to the user, keep the device's screen turned on and bright. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_KEEP_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("FLAG_KEEP_SCREEN_ON", "I", AccessFlags = 25)]
				public const int FLAG_KEEP_SCREEN_ON = 128;
				/// <summary>
				///  <para>Window flag: place the window within the entire screen, ignoring decorations around the border (such as the status bar). The window must correctly position its contents to take the screen decoration into account. This flag is normally set for you by Window as described in Window#setFlags. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_LAYOUT_IN_SCREEN
				/// </java-name>
				[Dot42.DexImport("FLAG_LAYOUT_IN_SCREEN", "I", AccessFlags = 25)]
				public const int FLAG_LAYOUT_IN_SCREEN = 256;
				/// <summary>
				///  <para>Window flag: allow window to extend outside of the screen. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_LAYOUT_NO_LIMITS
				/// </java-name>
				[Dot42.DexImport("FLAG_LAYOUT_NO_LIMITS", "I", AccessFlags = 25)]
				public const int FLAG_LAYOUT_NO_LIMITS = 512;
				/// <summary>
				///  <para>Window flag: hide all screen decorations (such as the status bar) while this window is displayed. This allows the window to use the entire display space for itself  the status bar will be hidden when an app window with this flag set is on the top layer. A fullscreen window will ignore a value of SOFT_INPUT_ADJUST_RESIZE for the window's softInputMode field; the window will stay fullscreen and will not resize.</para> <para>This flag can be controlled in your theme through the android.R.attr#windowFullscreen attribute; this attribute is automatically set for you in the standard fullscreen themes such as android.R.style#Theme_NoTitleBar_Fullscreen, android.R.style#Theme_Black_NoTitleBar_Fullscreen, android.R.style#Theme_Light_NoTitleBar_Fullscreen, android.R.style#Theme_Holo_NoActionBar_Fullscreen, android.R.style#Theme_Holo_Light_NoActionBar_Fullscreen, android.R.style#Theme_DeviceDefault_NoActionBar_Fullscreen, and android.R.style#Theme_DeviceDefault_Light_NoActionBar_Fullscreen.</para>        
				/// </summary>
				/// <java-name>
				/// FLAG_FULLSCREEN
				/// </java-name>
				[Dot42.DexImport("FLAG_FULLSCREEN", "I", AccessFlags = 25)]
				public const int FLAG_FULLSCREEN = 1024;
				/// <summary>
				///  <para>Window flag: override FLAG_FULLSCREEN and force the screen decorations (such as the status bar) to be shown. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_FORCE_NOT_FULLSCREEN
				/// </java-name>
				[Dot42.DexImport("FLAG_FORCE_NOT_FULLSCREEN", "I", AccessFlags = 25)]
				public const int FLAG_FORCE_NOT_FULLSCREEN = 2048;
				/// <summary>
				///  <para>Window flag: turn on dithering when compositing this window to the screen.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This flag is no longer used. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// FLAG_DITHER
				/// </java-name>
				[Dot42.DexImport("FLAG_DITHER", "I", AccessFlags = 25)]
				public const int FLAG_DITHER = 4096;
				/// <summary>
				///  <para>Window flag: treat the content of the window as secure, preventing it from appearing in screenshots or from being viewed on non-secure displays.</para> <para>See android.view.Display#FLAG_SECURE for more details about secure surfaces and secure displays. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SECURE
				/// </java-name>
				[Dot42.DexImport("FLAG_SECURE", "I", AccessFlags = 25)]
				public const int FLAG_SECURE = 8192;
				/// <summary>
				///  <para>Window flag: a special mode where the layout parameters are used to perform scaling of the surface when it is composited to the screen. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SCALED
				/// </java-name>
				[Dot42.DexImport("FLAG_SCALED", "I", AccessFlags = 25)]
				public const int FLAG_SCALED = 16384;
				/// <summary>
				///  <para>Window flag: intended for windows that will often be used when the user is holding the screen against their face, it will aggressively filter the event stream to prevent unintended presses in this situation that may not be desired for a particular window, when such an event stream is detected, the application will receive a CANCEL motion event to indicate this so applications can handle this accordingly by taking no action on the event until the finger is released. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_IGNORE_CHEEK_PRESSES
				/// </java-name>
				[Dot42.DexImport("FLAG_IGNORE_CHEEK_PRESSES", "I", AccessFlags = 25)]
				public const int FLAG_IGNORE_CHEEK_PRESSES = 32768;
				/// <summary>
				///  <para>Window flag: a special option only for use in combination with FLAG_LAYOUT_IN_SCREEN. When requesting layout in the screen your window may appear on top of or behind screen decorations such as the status bar. By also including this flag, the window manager will report the inset rectangle needed to ensure your content is not covered by screen decorations. This flag is normally set for you by Window as described in Window#setFlags. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_LAYOUT_INSET_DECOR
				/// </java-name>
				[Dot42.DexImport("FLAG_LAYOUT_INSET_DECOR", "I", AccessFlags = 25)]
				public const int FLAG_LAYOUT_INSET_DECOR = 65536;
				/// <summary>
				///  <para>Window flag: invert the state of FLAG_NOT_FOCUSABLE with respect to how this window interacts with the current method. That is, if FLAG_NOT_FOCUSABLE is set and this flag is set, then the window will behave as if it needs to interact with the input method and thus be placed behind/away from it; if FLAG_NOT_FOCUSABLE is not set and this flag is set, then the window will behave as if it doesn't need to interact with the input method and can be placed to use more space and cover the input method. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_ALT_FOCUSABLE_IM
				/// </java-name>
				[Dot42.DexImport("FLAG_ALT_FOCUSABLE_IM", "I", AccessFlags = 25)]
				public const int FLAG_ALT_FOCUSABLE_IM = 131072;
				/// <summary>
				///  <para>Window flag: if you have set FLAG_NOT_TOUCH_MODAL, you can set this flag to receive a single special MotionEvent with the action MotionEvent.ACTION_OUTSIDE for touches that occur outside of your window. Note that you will not receive the full down/move/up gesture, only the location of the first down as an ACTION_OUTSIDE. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_WATCH_OUTSIDE_TOUCH
				/// </java-name>
				[Dot42.DexImport("FLAG_WATCH_OUTSIDE_TOUCH", "I", AccessFlags = 25)]
				public const int FLAG_WATCH_OUTSIDE_TOUCH = 262144;
				/// <summary>
				///  <para>Window flag: special flag to let windows be shown when the screen is locked. This will let application windows take precedence over key guard or any other lock screens. Can be used with FLAG_KEEP_SCREEN_ON to turn screen on and display windows directly before showing the key guard window. Can be used with FLAG_DISMISS_KEYGUARD to automatically fully dismisss non-secure keyguards. This flag only applies to the top-most full-screen window. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SHOW_WHEN_LOCKED
				/// </java-name>
				[Dot42.DexImport("FLAG_SHOW_WHEN_LOCKED", "I", AccessFlags = 25)]
				public const int FLAG_SHOW_WHEN_LOCKED = 524288;
				/// <summary>
				///  <para>Window flag: ask that the system wallpaper be shown behind your window. The window surface must be translucent to be able to actually see the wallpaper behind it; this flag just ensures that the wallpaper surface will be there if this window actually has translucent regions.</para> <para>This flag can be controlled in your theme through the android.R.attr#windowShowWallpaper attribute; this attribute is automatically set for you in the standard wallpaper themes such as android.R.style#Theme_Wallpaper, android.R.style#Theme_Wallpaper_NoTitleBar, android.R.style#Theme_Wallpaper_NoTitleBar_Fullscreen, android.R.style#Theme_Holo_Wallpaper, android.R.style#Theme_Holo_Wallpaper_NoTitleBar, android.R.style#Theme_DeviceDefault_Wallpaper, and android.R.style#Theme_DeviceDefault_Wallpaper_NoTitleBar.</para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SHOW_WALLPAPER
				/// </java-name>
				[Dot42.DexImport("FLAG_SHOW_WALLPAPER", "I", AccessFlags = 25)]
				public const int FLAG_SHOW_WALLPAPER = 1048576;
				/// <summary>
				///  <para>Window flag: when set as a window is being added or made visible, once the window has been shown then the system will poke the power manager's user activity (as if the user had woken up the device) to turn the screen on. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_TURN_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("FLAG_TURN_SCREEN_ON", "I", AccessFlags = 25)]
				public const int FLAG_TURN_SCREEN_ON = 2097152;
				/// <summary>
				///  <para>Window flag: when set the window will cause the keyguard to be dismissed, only if it is not a secure lock keyguard. Because such a keyguard is not needed for security, it will never re-appear if the user navigates to another window (in contrast to FLAG_SHOW_WHEN_LOCKED, which will only temporarily hide both secure and non-secure keyguards but ensure they reappear when the user moves to another UI that doesn't hide them). If the keyguard is currently active and is secure (requires an unlock pattern) than the user will still need to confirm it before seeing this window, unless FLAG_SHOW_WHEN_LOCKED has also been set. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_DISMISS_KEYGUARD
				/// </java-name>
				[Dot42.DexImport("FLAG_DISMISS_KEYGUARD", "I", AccessFlags = 25)]
				public const int FLAG_DISMISS_KEYGUARD = 4194304;
				/// <summary>
				///  <para>Mask for softInputMode of the bits that determine the desired visibility state of the soft input area for this window. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_MASK_STATE
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_MASK_STATE", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_MASK_STATE = 15;
				/// <summary>
				///  <para>Visibility state for softInputMode: no state has been specified. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_STATE_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_UNSPECIFIED = 0;
				/// <summary>
				///  <para>Visibility state for softInputMode: please don't change the state of the soft input area. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_STATE_UNCHANGED
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_UNCHANGED", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_UNCHANGED = 1;
				/// <summary>
				///  <para>Visibility state for softInputMode: please hide any soft input area when normally appropriate (when the user is navigating forward to your window). </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_STATE_HIDDEN
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_HIDDEN", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_HIDDEN = 2;
				/// <summary>
				///  <para>Visibility state for softInputMode: please always hide any soft input area when this window receives focus. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_STATE_ALWAYS_HIDDEN
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_ALWAYS_HIDDEN", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_ALWAYS_HIDDEN = 3;
				/// <summary>
				///  <para>Visibility state for softInputMode: please show the soft input area when normally appropriate (when the user is navigating forward to your window). </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_STATE_VISIBLE
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_VISIBLE", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_VISIBLE = 4;
				/// <summary>
				///  <para>Visibility state for softInputMode: please always make the soft input area visible when this window receives input focus. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_STATE_ALWAYS_VISIBLE
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_STATE_ALWAYS_VISIBLE", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_STATE_ALWAYS_VISIBLE = 5;
				/// <summary>
				///  <para>Mask for softInputMode of the bits that determine the way that the window should be adjusted to accommodate the soft input window. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_MASK_ADJUST
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_MASK_ADJUST", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_MASK_ADJUST = 240;
				/// <summary>
				///  <para>Adjustment option for softInputMode: nothing specified. The system will try to pick one or the other depending on the contents of the window. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_ADJUST_UNSPECIFIED
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_ADJUST_UNSPECIFIED", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_ADJUST_UNSPECIFIED = 0;
				/// <summary>
				///  <para>Adjustment option for softInputMode: set to allow the window to be resized when an input method is shown, so that its contents are not covered by the input method. This can  <b>not</b> be combined with SOFT_INPUT_ADJUST_PAN; if neither of these are set, then the system will try to pick one or the other depending on the contents of the window. If the window's layout parameter flags include FLAG_FULLSCREEN, this value for softInputMode will be ignored; the window will not resize, but will stay fullscreen. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_ADJUST_RESIZE
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_ADJUST_RESIZE", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_ADJUST_RESIZE = 16;
				/// <summary>
				///  <para>Adjustment option for softInputMode: set to have a window pan when an input method is shown, so it doesn't need to deal with resizing but just panned by the framework to ensure the current input focus is visible. This can  <b>not</b> be combined with SOFT_INPUT_ADJUST_RESIZE; if neither of these are set, then the system will try to pick one or the other depending on the contents of the window. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_ADJUST_PAN
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_ADJUST_PAN", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_ADJUST_PAN = 32;
				/// <summary>
				///  <para>Bit for softInputMode: set when the user has navigated forward to the window. This is normally set automatically for you by the system, though you may want to set it in certain cases when you are displaying a window yourself. This flag will always be cleared automatically after the window is displayed. </para>        
				/// </summary>
				/// <java-name>
				/// SOFT_INPUT_IS_FORWARD_NAVIGATION
				/// </java-name>
				[Dot42.DexImport("SOFT_INPUT_IS_FORWARD_NAVIGATION", "I", AccessFlags = 25)]
				public const int SOFT_INPUT_IS_FORWARD_NAVIGATION = 256;
				/// <summary>
				///  <para>Default value for screenBrightness and buttonBrightness indicating that the brightness value is not overridden for this window and normal brightness policy should be used. </para>        
				/// </summary>
				/// <java-name>
				/// BRIGHTNESS_OVERRIDE_NONE
				/// </java-name>
				[Dot42.DexImport("BRIGHTNESS_OVERRIDE_NONE", "F", AccessFlags = 25)]
				public const float BRIGHTNESS_OVERRIDE_NONE = -1F;
				/// <summary>
				///  <para>Value for screenBrightness and buttonBrightness indicating that the screen or button backlight brightness should be set to the lowest value when this window is in front. </para>        
				/// </summary>
				/// <java-name>
				/// BRIGHTNESS_OVERRIDE_OFF
				/// </java-name>
				[Dot42.DexImport("BRIGHTNESS_OVERRIDE_OFF", "F", AccessFlags = 25)]
				public const float BRIGHTNESS_OVERRIDE_OFF = 0F;
				/// <summary>
				///  <para>Value for screenBrightness and buttonBrightness indicating that the screen or button backlight brightness should be set to the hightest value when this window is in front. </para>        
				/// </summary>
				/// <java-name>
				/// BRIGHTNESS_OVERRIDE_FULL
				/// </java-name>
				[Dot42.DexImport("BRIGHTNESS_OVERRIDE_FULL", "F", AccessFlags = 25)]
				public const float BRIGHTNESS_OVERRIDE_FULL = 1F;
				/// <summary>
				///  <para>Desired operating mode for any soft input area. May be any combination of:</para> <para> <ul> <li> <para>One of the visibility states SOFT_INPUT_STATE_UNSPECIFIED, SOFT_INPUT_STATE_UNCHANGED, SOFT_INPUT_STATE_HIDDEN, SOFT_INPUT_STATE_ALWAYS_VISIBLE, or SOFT_INPUT_STATE_VISIBLE. </para></li> <li> <para>One of the adjustment options SOFT_INPUT_ADJUST_UNSPECIFIED, SOFT_INPUT_ADJUST_RESIZE, or SOFT_INPUT_ADJUST_PAN. </para></li></ul></para> <para>This flag can be controlled in your theme through the android.R.attr#windowSoftInputMode attribute.</para>        
				/// </summary>
				/// <java-name>
				/// softInputMode
				/// </java-name>
				[Dot42.DexImport("softInputMode", "I", AccessFlags = 1)]
				public int SoftInputMode;
				/// <summary>
				///  <para>Placement of window within the screen as per Gravity. Both int, int, android.graphics.Rect, int, int, android.graphics.Rect) Gravity.apply and Gravity.applyDisplay are used during window layout, with this value given as the desired gravity. For example you can specify Gravity.DISPLAY_CLIP_HORIZONTAL and Gravity.DISPLAY_CLIP_VERTICAL here to control the behavior of Gravity.applyDisplay.</para> <para> <para>Gravity </para></para>        
				/// </summary>
				/// <java-name>
				/// gravity
				/// </java-name>
				[Dot42.DexImport("gravity", "I", AccessFlags = 1)]
				public int Gravity;
				/// <summary>
				///  <para>The horizontal margin, as a percentage of the container's width, between the container and the widget. See int, int, android.graphics.Rect, int, int, android.graphics.Rect) Gravity.apply for how this is used. This field is added with x to supply the  <b>xAdj</b> parameter. </para>        
				/// </summary>
				/// <java-name>
				/// horizontalMargin
				/// </java-name>
				[Dot42.DexImport("horizontalMargin", "F", AccessFlags = 1)]
				public float HorizontalMargin;
				/// <summary>
				///  <para>The vertical margin, as a percentage of the container's height, between the container and the widget. See int, int, android.graphics.Rect, int, int, android.graphics.Rect) Gravity.apply for how this is used. This field is added with y to supply the  <b>yAdj</b> parameter. </para>        
				/// </summary>
				/// <java-name>
				/// verticalMargin
				/// </java-name>
				[Dot42.DexImport("verticalMargin", "F", AccessFlags = 1)]
				public float VerticalMargin;
				/// <summary>
				///  <para>The desired bitmap format. May be one of the constants in android.graphics.PixelFormat. Default is OPAQUE. </para>        
				/// </summary>
				/// <java-name>
				/// format
				/// </java-name>
				[Dot42.DexImport("format", "I", AccessFlags = 1)]
				public int Format;
				/// <summary>
				///  <para>A style resource defining the animations to use for this window. This must be a system resource; it can not be an application resource because the window manager does not have access to applications. </para>        
				/// </summary>
				/// <java-name>
				/// windowAnimations
				/// </java-name>
				[Dot42.DexImport("windowAnimations", "I", AccessFlags = 1)]
				public int WindowAnimations;
				/// <summary>
				///  <para>An alpha value to apply to this entire window. An alpha of 1.0 means fully opaque and 0.0 means fully transparent </para>        
				/// </summary>
				/// <java-name>
				/// alpha
				/// </java-name>
				[Dot42.DexImport("alpha", "F", AccessFlags = 1)]
				public float Alpha;
				/// <summary>
				///  <para>When FLAG_DIM_BEHIND is set, this is the amount of dimming to apply. Range is from 1.0 for completely opaque to 0.0 for no dim. </para>        
				/// </summary>
				/// <java-name>
				/// dimAmount
				/// </java-name>
				[Dot42.DexImport("dimAmount", "F", AccessFlags = 1)]
				public float DimAmount;
				/// <summary>
				///  <para>This can be used to override the user's preferred brightness of the screen. A value of less than 0, the default, means to use the preferred screen brightness. 0 to 1 adjusts the brightness from dark to full bright. </para>        
				/// </summary>
				/// <java-name>
				/// screenBrightness
				/// </java-name>
				[Dot42.DexImport("screenBrightness", "F", AccessFlags = 1)]
				public float ScreenBrightness;
				/// <summary>
				///  <para>This can be used to override the standard behavior of the button and keyboard backlights. A value of less than 0, the default, means to use the standard backlight behavior. 0 to 1 adjusts the brightness from dark to full bright. </para>        
				/// </summary>
				/// <java-name>
				/// buttonBrightness
				/// </java-name>
				[Dot42.DexImport("buttonBrightness", "F", AccessFlags = 1)]
				public float ButtonBrightness;
				/// <summary>
				///  <para>Identifier for this window. This will usually be filled in for you. </para>        
				/// </summary>
				/// <java-name>
				/// token
				/// </java-name>
				[Dot42.DexImport("token", "Landroid/os/IBinder;", AccessFlags = 1)]
				public global::Android.OS.IBinder Token;
				/// <summary>
				///  <para>Name of the package owning this window. </para>        
				/// </summary>
				/// <java-name>
				/// packageName
				/// </java-name>
				[Dot42.DexImport("packageName", "Ljava/lang/String;", AccessFlags = 1)]
				public string PackageName;
				/// <summary>
				///  <para>Specific orientation value for a window. May be any of the same values allowed for android.content.pm.ActivityInfo#screenOrientation. If not set, a default value of android.content.pm.ActivityInfo#SCREEN_ORIENTATION_UNSPECIFIED will be used. </para>        
				/// </summary>
				/// <java-name>
				/// screenOrientation
				/// </java-name>
				[Dot42.DexImport("screenOrientation", "I", AccessFlags = 1)]
				public int ScreenOrientation;
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

				/// <summary>
				///  <para>Given a particular set of window manager flags, determine whether such a window may be a target for an input method when it has focus. In particular, this checks the FLAG_NOT_FOCUSABLE and FLAG_ALT_FOCUSABLE_IM flags and returns true if the combination of the two corresponds to a window that needs to be behind the input method so that the user can type into it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if such a window should be behind/interact with an input method, false if not. </para>
				/// </returns>
				/// <java-name>
				/// mayUseInputMethod
				/// </java-name>
				[Dot42.DexImport("mayUseInputMethod", "(I)Z", AccessFlags = 9)]
				public static bool MayUseInputMethod(int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
				/// <java-name>
				/// describeContents
				/// </java-name>
				[Dot42.DexImport("describeContents", "()I", AccessFlags = 1)]
				public virtual int DescribeContents() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// copyFrom
				/// </java-name>
				[Dot42.DexImport("copyFrom", "(Landroid/view/WindowManager$LayoutParams;)I", AccessFlags = 17)]
				public int CopyFrom(global::Android.Views.IWindowManager_LayoutParams o) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// debug
				/// </java-name>
				[Dot42.DexImport("debug", "(Ljava/lang/String;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string Debug(string output) /* MethodBuilder.Create */ 
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

		/// <summary>
		///  <para>Describes the keys provided by a keyboard device and their associated labels. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/KeyCharacterMap
		/// </java-name>
		[Dot42.DexImport("android/view/KeyCharacterMap", AccessFlags = 33)]
		public partial class KeyCharacterMap
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The id of the device's primary built in keyboard is always 0.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This constant should no longer be used because there is no guarantee that a device has a built-in keyboard that can be used for typing text. There might not be a built-in keyboard, the built-in keyboard might be a NUMERIC or SPECIAL_FUNCTION keyboard, or there might be multiple keyboards installed including external keyboards. When interpreting key presses received from the framework, applications should use the device id specified in the KeyEvent received. When synthesizing key presses for delivery elsewhere or when translating key presses from unknown keyboards, applications should use the special VIRTUAL_KEYBOARD device id. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// BUILT_IN_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("BUILT_IN_KEYBOARD", "I", AccessFlags = 25)]
				public const int BUILT_IN_KEYBOARD = 0;
				/// <summary>
				///  <para>A numeric (12-key) keyboard. </para> <para>A numeric keyboard supports text entry using a multi-tap approach. It may be necessary to tap a key multiple times to generate the desired letter or symbol. </para> <para>This type of keyboard is generally designed for thumb typing. </para>        
				/// </summary>
				/// <java-name>
				/// NUMERIC
				/// </java-name>
				[Dot42.DexImport("NUMERIC", "I", AccessFlags = 25)]
				public const int NUMERIC = 1;
				/// <summary>
				///  <para>A keyboard with all the letters, but with more than one letter per key. </para> <para>This type of keyboard is generally designed for thumb typing. </para>        
				/// </summary>
				/// <java-name>
				/// PREDICTIVE
				/// </java-name>
				[Dot42.DexImport("PREDICTIVE", "I", AccessFlags = 25)]
				public const int PREDICTIVE = 2;
				/// <summary>
				///  <para>A keyboard with all the letters, and maybe some numbers. </para> <para>An alphabetic keyboard supports text entry directly but may have a condensed layout with a small form factor. In contrast to a full keyboard, some symbols may only be accessible using special on-screen character pickers. In addition, to improve typing speed and accuracy, the framework provides special affordances for alphabetic keyboards such as auto-capitalization and toggled / locked shift and alt keys. </para> <para>This type of keyboard is generally designed for thumb typing. </para>        
				/// </summary>
				/// <java-name>
				/// ALPHA
				/// </java-name>
				[Dot42.DexImport("ALPHA", "I", AccessFlags = 25)]
				public const int ALPHA = 3;
				/// <summary>
				///  <para>This private-use character is used to trigger Unicode character input by hex digits. </para>        
				/// </summary>
				/// <java-name>
				/// HEX_INPUT
				/// </java-name>
				[Dot42.DexImport("HEX_INPUT", "C", AccessFlags = 25)]
				public const char HEX_INPUT = '';
				/// <summary>
				///  <para>This private-use character is used to bring up a character picker for miscellaneous symbols. </para>        
				/// </summary>
				/// <java-name>
				/// PICKER_DIALOG_INPUT
				/// </java-name>
				[Dot42.DexImport("PICKER_DIALOG_INPUT", "C", AccessFlags = 25)]
				public const char PICKER_DIALOG_INPUT = '';
				/// <java-name>
				/// COMBINING_ACCENT
				/// </java-name>
				[Dot42.DexImport("COMBINING_ACCENT", "I", AccessFlags = 25)]
				public const int COMBINING_ACCENT = -2147483648;
				/// <summary>
				///  <para>Mask the return value from get(int, int) with this value to get a printable representation of the accent character of a "dead key." </para>        
				/// </summary>
				/// <java-name>
				/// COMBINING_ACCENT_MASK
				/// </java-name>
				[Dot42.DexImport("COMBINING_ACCENT_MASK", "I", AccessFlags = 25)]
				public const int COMBINING_ACCENT_MASK = 2147483647;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal KeyCharacterMap() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Loads the key character maps for the keyboard with the specified device id.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The associated key character map. </para>
				/// </returns>
				/// <java-name>
				/// load
				/// </java-name>
				[Dot42.DexImport("load", "(I)Landroid/view/KeyCharacterMap;", AccessFlags = 9)]
				public static global::Android.Views.KeyCharacterMap Load(int deviceId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyCharacterMap);
				}

				/// <summary>
				///  <para>Gets the Unicode character generated by the specified key and meta key state combination. </para> <para>Returns the Unicode character that the specified key would produce when the specified meta bits (see MetaKeyKeyListener) were active. </para> <para>Returns 0 if the key is not one that is used to type Unicode characters. </para> <para>If the return value has bit COMBINING_ACCENT set, the key is a "dead key" that should be combined with another to actually produce a character  see getDeadChar  after masking with COMBINING_ACCENT_MASK. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The associated character or combining accent, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(II)I", AccessFlags = 1)]
				public virtual int Get(int keyCode, int metaState) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Gets the number or symbol associated with the key. </para> <para>The character value is returned, not the numeric value. If the key is not a number, but is a symbol, the symbol is retuned. </para> <para>This method is intended to to support dial pads and other numeric or symbolic entry on keyboards where certain keys serve dual function as alphabetic and symbolic keys. This method returns the number or symbol associated with the key independent of whether the user has pressed the required modifier. </para> <para>For example, on one particular keyboard the keys on the top QWERTY row generate numbers when ALT is pressed such that ALT-Q maps to '1'. So for that keyboard when getNumber is called with KeyEvent#KEYCODE_Q it returns '1' so that the user can type numbers without pressing ALT when it makes sense. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The associated numeric or symbolic character, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getNumber
				/// </java-name>
				[Dot42.DexImport("getNumber", "(I)C", AccessFlags = 1)]
				public virtual char GetNumber(int keyCode) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Gets the first character in the character array that can be generated by the specified key code. </para> <para>This is a convenience function that returns the same value as getMatch(keyCode, chars, 0). </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The matching associated character, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getMatch
				/// </java-name>
				[Dot42.DexImport("getMatch", "(I[C)C", AccessFlags = 1)]
				public virtual char GetMatch(int keyCode, char[] chars) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Gets the first character in the character array that can be generated by the specified key code. If there are multiple choices, prefers the one that would be generated with the specified meta key modifier state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The matching associated character, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getMatch
				/// </java-name>
				[Dot42.DexImport("getMatch", "(I[CI)C", AccessFlags = 1)]
				public virtual char GetMatch(int keyCode, char[] chars, int metaState) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Gets the primary character for this key. In other words, the label that is physically printed on it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The display label character, or 0 if none (eg. for non-printing keys). </para>
				/// </returns>
				/// <java-name>
				/// getDisplayLabel
				/// </java-name>
				[Dot42.DexImport("getDisplayLabel", "(I)C", AccessFlags = 1)]
				public virtual char GetDisplayLabel(int keyCode) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Get the character that is produced by combining the dead key producing accent with the key producing character c. For example, getDeadChar('`', 'e') returns  <egrave></egrave>. getDeadChar('^', ' ') returns '^' and getDeadChar('^', '^') returns '^'.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The combined character, or 0 if the characters cannot be combined. </para>
				/// </returns>
				/// <java-name>
				/// getDeadChar
				/// </java-name>
				[Dot42.DexImport("getDeadChar", "(II)I", AccessFlags = 9)]
				public static int GetDeadChar(int accent, int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get the character conversion data for a given key code.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>instead use KeyCharacterMap#getDisplayLabel(int), KeyCharacterMap#getNumber(int) or KeyCharacterMap#get(int, int). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the key was mapped. If the key was not mapped, results is not modified.</para>
				/// </returns>
				/// <java-name>
				/// getKeyData
				/// </java-name>
				[Dot42.DexImport("getKeyData", "(ILandroid/view/KeyCharacterMap$KeyData;)Z", AccessFlags = 1)]
				public virtual bool GetKeyData(int keyCode, global::Android.Views.KeyCharacterMap.KeyData results) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get an array of KeyEvent objects that if put into the input stream could plausibly generate the provided sequence of characters. It is not guaranteed that the sequence is the only way to generate these events or that it is optimal. </para> <para>This function is primarily offered for instrumentation and testing purposes. It may fail to map characters to key codes. In particular, the key character map for the built-in keyboard device id may be empty. Consider using the key character map associated with the virtual keyboard device id instead. </para> <para>For robust text entry, do not use this function. Instead construct a KeyEvent with action code KeyEvent#ACTION_MULTIPLE that contains the desired string using KeyEvent#KeyEvent(long, String, int, int). </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An array of KeyEvent objects, or null if the given char array can not be generated using the current key character map. </para>
				/// </returns>
				/// <java-name>
				/// getEvents
				/// </java-name>
				[Dot42.DexImport("getEvents", "([C)[Landroid/view/KeyEvent;", AccessFlags = 1)]
				public virtual global::Android.Views.KeyEvent[] GetEvents(char[] chars) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent[]);
				}

				/// <summary>
				///  <para>Returns true if the specified key produces a glyph.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the key is a printing key. </para>
				/// </returns>
				/// <java-name>
				/// isPrintingKey
				/// </java-name>
				[Dot42.DexImport("isPrintingKey", "(I)Z", AccessFlags = 1)]
				public virtual bool IsPrintingKey(int keyCode) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~KeyCharacterMap() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Queries the framework about whether any physical keys exist on the any keyboard attached to the device that are capable of producing the given key code.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if at least one attached keyboard supports the specified key code. </para>
				/// </returns>
				/// <java-name>
				/// deviceHasKey
				/// </java-name>
				[Dot42.DexImport("deviceHasKey", "(I)Z", AccessFlags = 9)]
				public static bool DeviceHasKey(int keyCode) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Queries the framework about whether any physical keys exist on the any keyboard attached to the device that are capable of producing the given array of key codes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A new array of the same size as the key codes array whose elements are set to true if at least one attached keyboard supports the corresponding key code at the same index in the key codes array. </para>
				/// </returns>
				/// <java-name>
				/// deviceHasKeys
				/// </java-name>
				[Dot42.DexImport("deviceHasKeys", "([I)[Z", AccessFlags = 9)]
				public static bool[] DeviceHasKeys(int[] keyCodes) /* MethodBuilder.Create */ 
				{
						return default(bool[]);
				}

				/// <summary>
				///  <para>Gets the keyboard type. Returns NUMERIC, PREDICTIVE, ALPHA, FULL or SPECIAL_FUNCTION. </para> <para>Different keyboard types have different semantics. Refer to the documentation associated with the keyboard type constants for details. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The keyboard type. </para>
				/// </returns>
				/// <java-name>
				/// getKeyboardType
				/// </java-name>
				public virtual int KeyboardType
				{
						[Dot42.DexImport("getKeyboardType", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Describes the character mappings associated with a key.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>instead use KeyCharacterMap#getDisplayLabel(int), KeyCharacterMap#getNumber(int) and KeyCharacterMap#get(int, int). </para></xrefdescription></xrefsect></para>    
				/// </summary>
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
						/// <summary>
						///  <para>The display label (see getDisplayLabel). </para>        
						/// </summary>
						/// <java-name>
						/// displayLabel
						/// </java-name>
						[Dot42.DexImport("displayLabel", "C", AccessFlags = 1)]
						public char DisplayLabel;
						/// <summary>
						///  <para>The "number" value (see getNumber). </para>        
						/// </summary>
						/// <java-name>
						/// number
						/// </java-name>
						[Dot42.DexImport("number", "C", AccessFlags = 1)]
						public char Number;
						/// <summary>
						///  <para>The character that will be generated in various meta states (the same ones used for get and defined as KeyEvent#META_SHIFT_ON and KeyEvent#META_ALT_ON).  <table> <row> <entry> <para>Index</para></entry> <entry> <para>Value </para></entry></row> <row> <entry> <para>0</para></entry> <entry> <para>no modifiers </para></entry></row> <row> <entry> <para>1</para></entry> <entry> <para>caps </para></entry></row> <row> <entry> <para>2</para></entry> <entry> <para>alt </para></entry></row> <row> <entry> <para>3</para></entry> <entry> <para>caps + alt </para></entry></row></table></para>        
						/// </summary>
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

		/// <summary>
		///  <para>Object used to report key and button events. </para> <para>Each key press is described by a sequence of key events. A key press starts with a key event with ACTION_DOWN. If the key is held sufficiently long that it repeats, then the initial down is followed additional key events with ACTION_DOWN and a non-zero value for getRepeatCount(). The last key event is a ACTION_UP for the key up. If the key press is canceled, the key up event will have the FLAG_CANCELED flag set. </para> <para>Key events are generally accompanied by a key code (getKeyCode()), scan code (getScanCode()) and meta state (getMetaState()). Key code constants are defined in this class. Scan code constants are raw device-specific codes obtained from the OS and so are not generally meaningful to applications unless interpreted using the KeyCharacterMap. Meta states describe the pressed state of key modifiers such as META_SHIFT_ON or META_ALT_ON. </para> <para>Key codes typically correspond one-to-one with individual keys on an input device. Many keys and key combinations serve quite different functions on different input devices so care must be taken when interpreting them. Always use the KeyCharacterMap associated with the input device when mapping keys to characters. Be aware that there may be multiple key input devices active at the same time and each will have its own key character map. </para> <para>As soft input methods can use multiple and inventive ways of inputting text, there is no guarantee that any key press on a soft keyboard will generate a key event: this is left to the IME's discretion, and in fact sending such events is discouraged. You should never rely on receiving KeyEvents for any key on a soft input method. In particular, the default software keyboard will never send any key event to any application targetting Jelly Bean or later, and will only send events for some presses of the delete and return keys to applications targetting Ice Cream Sandwich or earlier. Be aware that other software input methods may never send key events regardless of the version. Consider using editor actions like android.view.inputmethod.EditorInfo#IME_ACTION_DONE if you need specific interaction with the software keyboard, as it gives more visibility to the user as to how your application will react to key presses. </para> <para>When interacting with an IME, the framework may deliver key events with the special action ACTION_MULTIPLE that either specifies that single repeated key code or a sequence of characters to insert. </para> <para>In general, the framework cannot guarantee that the key events it delivers to a view always constitute complete key sequences since some events may be dropped or modified by containing views before they are delivered. The view implementation should be prepared to handle FLAG_CANCELED and should tolerate anomalous situations such as receiving a new ACTION_DOWN without first having received an ACTION_UP for the prior key press. </para> <para>Refer to InputDevice for more information about how different kinds of input devices and sources represent keys and buttons. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/KeyEvent
		/// </java-name>
		[Dot42.DexImport("android/view/KeyEvent", AccessFlags = 33)]
		public partial class KeyEvent : global::Android.Views.InputEvent, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Key code constant: Unknown key code. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_UNKNOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_UNKNOWN = 0;
				/// <summary>
				///  <para>Key code constant: Soft Left key. Usually situated below the display on phones and used as a multi-function feature key for selecting a software defined function shown on the bottom left of the display. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SOFT_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SOFT_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_SOFT_LEFT = 1;
				/// <summary>
				///  <para>Key code constant: Soft Right key. Usually situated below the display on phones and used as a multi-function feature key for selecting a software defined function shown on the bottom right of the display. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SOFT_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SOFT_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_SOFT_RIGHT = 2;
				/// <summary>
				///  <para>Key code constant: Home key. This key is handled by the framework and is never delivered to applications. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_HOME
				/// </java-name>
				[Dot42.DexImport("KEYCODE_HOME", "I", AccessFlags = 25)]
				public const int KEYCODE_HOME = 3;
				/// <summary>
				///  <para>Key code constant: Back key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BACK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BACK", "I", AccessFlags = 25)]
				public const int KEYCODE_BACK = 4;
				/// <summary>
				///  <para>Key code constant: Call key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_CALL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CALL", "I", AccessFlags = 25)]
				public const int KEYCODE_CALL = 5;
				/// <summary>
				///  <para>Key code constant: End Call key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_ENDCALL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ENDCALL", "I", AccessFlags = 25)]
				public const int KEYCODE_ENDCALL = 6;
				/// <summary>
				///  <para>Key code constant: '0' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_0
				/// </java-name>
				[Dot42.DexImport("KEYCODE_0", "I", AccessFlags = 25)]
				public const int KEYCODE_0 = 7;
				/// <summary>
				///  <para>Key code constant: '1' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_1", "I", AccessFlags = 25)]
				public const int KEYCODE_1 = 8;
				/// <summary>
				///  <para>Key code constant: '2' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_2", "I", AccessFlags = 25)]
				public const int KEYCODE_2 = 9;
				/// <summary>
				///  <para>Key code constant: '3' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_3
				/// </java-name>
				[Dot42.DexImport("KEYCODE_3", "I", AccessFlags = 25)]
				public const int KEYCODE_3 = 10;
				/// <summary>
				///  <para>Key code constant: '4' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_4
				/// </java-name>
				[Dot42.DexImport("KEYCODE_4", "I", AccessFlags = 25)]
				public const int KEYCODE_4 = 11;
				/// <summary>
				///  <para>Key code constant: '5' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_5
				/// </java-name>
				[Dot42.DexImport("KEYCODE_5", "I", AccessFlags = 25)]
				public const int KEYCODE_5 = 12;
				/// <summary>
				///  <para>Key code constant: '6' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_6
				/// </java-name>
				[Dot42.DexImport("KEYCODE_6", "I", AccessFlags = 25)]
				public const int KEYCODE_6 = 13;
				/// <summary>
				///  <para>Key code constant: '7' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_7
				/// </java-name>
				[Dot42.DexImport("KEYCODE_7", "I", AccessFlags = 25)]
				public const int KEYCODE_7 = 14;
				/// <summary>
				///  <para>Key code constant: '8' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_8
				/// </java-name>
				[Dot42.DexImport("KEYCODE_8", "I", AccessFlags = 25)]
				public const int KEYCODE_8 = 15;
				/// <summary>
				///  <para>Key code constant: '9' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_9
				/// </java-name>
				[Dot42.DexImport("KEYCODE_9", "I", AccessFlags = 25)]
				public const int KEYCODE_9 = 16;
				/// <summary>
				///  <para>Key code constant: '*' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_STAR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_STAR", "I", AccessFlags = 25)]
				public const int KEYCODE_STAR = 17;
				/// <summary>
				///  <para>Key code constant: '#' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_POUND
				/// </java-name>
				[Dot42.DexImport("KEYCODE_POUND", "I", AccessFlags = 25)]
				public const int KEYCODE_POUND = 18;
				/// <summary>
				///  <para>Key code constant: Directional Pad Up key. May also be synthesized from trackball motions. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_DPAD_UP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_UP", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_UP = 19;
				/// <summary>
				///  <para>Key code constant: Directional Pad Down key. May also be synthesized from trackball motions. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_DPAD_DOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_DOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_DOWN = 20;
				/// <summary>
				///  <para>Key code constant: Directional Pad Left key. May also be synthesized from trackball motions. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_DPAD_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_LEFT = 21;
				/// <summary>
				///  <para>Key code constant: Directional Pad Right key. May also be synthesized from trackball motions. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_DPAD_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_RIGHT = 22;
				/// <summary>
				///  <para>Key code constant: Directional Pad Center key. May also be synthesized from trackball motions. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_DPAD_CENTER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DPAD_CENTER", "I", AccessFlags = 25)]
				public const int KEYCODE_DPAD_CENTER = 23;
				/// <summary>
				///  <para>Key code constant: Volume Up key. Adjusts the speaker volume up. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_VOLUME_UP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_VOLUME_UP", "I", AccessFlags = 25)]
				public const int KEYCODE_VOLUME_UP = 24;
				/// <summary>
				///  <para>Key code constant: Volume Down key. Adjusts the speaker volume down. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_VOLUME_DOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_VOLUME_DOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_VOLUME_DOWN = 25;
				/// <summary>
				///  <para>Key code constant: Power key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_POWER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_POWER", "I", AccessFlags = 25)]
				public const int KEYCODE_POWER = 26;
				/// <summary>
				///  <para>Key code constant: Camera key. Used to launch a camera application or take pictures. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_CAMERA
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CAMERA", "I", AccessFlags = 25)]
				public const int KEYCODE_CAMERA = 27;
				/// <summary>
				///  <para>Key code constant: Clear key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_CLEAR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_CLEAR", "I", AccessFlags = 25)]
				public const int KEYCODE_CLEAR = 28;
				/// <summary>
				///  <para>Key code constant: 'A' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_A
				/// </java-name>
				[Dot42.DexImport("KEYCODE_A", "I", AccessFlags = 25)]
				public const int KEYCODE_A = 29;
				/// <summary>
				///  <para>Key code constant: 'B' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_B
				/// </java-name>
				[Dot42.DexImport("KEYCODE_B", "I", AccessFlags = 25)]
				public const int KEYCODE_B = 30;
				/// <summary>
				///  <para>Key code constant: 'C' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_C
				/// </java-name>
				[Dot42.DexImport("KEYCODE_C", "I", AccessFlags = 25)]
				public const int KEYCODE_C = 31;
				/// <summary>
				///  <para>Key code constant: 'D' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_D
				/// </java-name>
				[Dot42.DexImport("KEYCODE_D", "I", AccessFlags = 25)]
				public const int KEYCODE_D = 32;
				/// <summary>
				///  <para>Key code constant: 'E' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_E
				/// </java-name>
				[Dot42.DexImport("KEYCODE_E", "I", AccessFlags = 25)]
				public const int KEYCODE_E = 33;
				/// <summary>
				///  <para>Key code constant: 'F' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_F
				/// </java-name>
				[Dot42.DexImport("KEYCODE_F", "I", AccessFlags = 25)]
				public const int KEYCODE_F = 34;
				/// <summary>
				///  <para>Key code constant: 'G' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_G
				/// </java-name>
				[Dot42.DexImport("KEYCODE_G", "I", AccessFlags = 25)]
				public const int KEYCODE_G = 35;
				/// <summary>
				///  <para>Key code constant: 'H' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_H
				/// </java-name>
				[Dot42.DexImport("KEYCODE_H", "I", AccessFlags = 25)]
				public const int KEYCODE_H = 36;
				/// <summary>
				///  <para>Key code constant: 'I' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_I
				/// </java-name>
				[Dot42.DexImport("KEYCODE_I", "I", AccessFlags = 25)]
				public const int KEYCODE_I = 37;
				/// <summary>
				///  <para>Key code constant: 'J' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_J
				/// </java-name>
				[Dot42.DexImport("KEYCODE_J", "I", AccessFlags = 25)]
				public const int KEYCODE_J = 38;
				/// <summary>
				///  <para>Key code constant: 'K' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_K
				/// </java-name>
				[Dot42.DexImport("KEYCODE_K", "I", AccessFlags = 25)]
				public const int KEYCODE_K = 39;
				/// <summary>
				///  <para>Key code constant: 'L' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_L
				/// </java-name>
				[Dot42.DexImport("KEYCODE_L", "I", AccessFlags = 25)]
				public const int KEYCODE_L = 40;
				/// <summary>
				///  <para>Key code constant: 'M' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_M
				/// </java-name>
				[Dot42.DexImport("KEYCODE_M", "I", AccessFlags = 25)]
				public const int KEYCODE_M = 41;
				/// <summary>
				///  <para>Key code constant: 'N' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_N
				/// </java-name>
				[Dot42.DexImport("KEYCODE_N", "I", AccessFlags = 25)]
				public const int KEYCODE_N = 42;
				/// <summary>
				///  <para>Key code constant: 'O' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_O
				/// </java-name>
				[Dot42.DexImport("KEYCODE_O", "I", AccessFlags = 25)]
				public const int KEYCODE_O = 43;
				/// <summary>
				///  <para>Key code constant: 'P' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_P
				/// </java-name>
				[Dot42.DexImport("KEYCODE_P", "I", AccessFlags = 25)]
				public const int KEYCODE_P = 44;
				/// <summary>
				///  <para>Key code constant: 'Q' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_Q
				/// </java-name>
				[Dot42.DexImport("KEYCODE_Q", "I", AccessFlags = 25)]
				public const int KEYCODE_Q = 45;
				/// <summary>
				///  <para>Key code constant: 'R' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_R
				/// </java-name>
				[Dot42.DexImport("KEYCODE_R", "I", AccessFlags = 25)]
				public const int KEYCODE_R = 46;
				/// <summary>
				///  <para>Key code constant: 'S' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_S
				/// </java-name>
				[Dot42.DexImport("KEYCODE_S", "I", AccessFlags = 25)]
				public const int KEYCODE_S = 47;
				/// <summary>
				///  <para>Key code constant: 'T' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_T
				/// </java-name>
				[Dot42.DexImport("KEYCODE_T", "I", AccessFlags = 25)]
				public const int KEYCODE_T = 48;
				/// <summary>
				///  <para>Key code constant: 'U' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_U
				/// </java-name>
				[Dot42.DexImport("KEYCODE_U", "I", AccessFlags = 25)]
				public const int KEYCODE_U = 49;
				/// <summary>
				///  <para>Key code constant: 'V' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_V
				/// </java-name>
				[Dot42.DexImport("KEYCODE_V", "I", AccessFlags = 25)]
				public const int KEYCODE_V = 50;
				/// <summary>
				///  <para>Key code constant: 'W' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_W
				/// </java-name>
				[Dot42.DexImport("KEYCODE_W", "I", AccessFlags = 25)]
				public const int KEYCODE_W = 51;
				/// <summary>
				///  <para>Key code constant: 'X' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_X
				/// </java-name>
				[Dot42.DexImport("KEYCODE_X", "I", AccessFlags = 25)]
				public const int KEYCODE_X = 52;
				/// <summary>
				///  <para>Key code constant: 'Y' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_Y
				/// </java-name>
				[Dot42.DexImport("KEYCODE_Y", "I", AccessFlags = 25)]
				public const int KEYCODE_Y = 53;
				/// <summary>
				///  <para>Key code constant: 'Z' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_Z
				/// </java-name>
				[Dot42.DexImport("KEYCODE_Z", "I", AccessFlags = 25)]
				public const int KEYCODE_Z = 54;
				/// <summary>
				///  <para>Key code constant: ',' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_COMMA
				/// </java-name>
				[Dot42.DexImport("KEYCODE_COMMA", "I", AccessFlags = 25)]
				public const int KEYCODE_COMMA = 55;
				/// <summary>
				///  <para>Key code constant: '.' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_PERIOD
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PERIOD", "I", AccessFlags = 25)]
				public const int KEYCODE_PERIOD = 56;
				/// <summary>
				///  <para>Key code constant: Left Alt modifier key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_ALT_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ALT_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_ALT_LEFT = 57;
				/// <summary>
				///  <para>Key code constant: Right Alt modifier key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_ALT_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ALT_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_ALT_RIGHT = 58;
				/// <summary>
				///  <para>Key code constant: Left Shift modifier key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SHIFT_LEFT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SHIFT_LEFT", "I", AccessFlags = 25)]
				public const int KEYCODE_SHIFT_LEFT = 59;
				/// <summary>
				///  <para>Key code constant: Right Shift modifier key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SHIFT_RIGHT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SHIFT_RIGHT", "I", AccessFlags = 25)]
				public const int KEYCODE_SHIFT_RIGHT = 60;
				/// <summary>
				///  <para>Key code constant: Tab key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_TAB
				/// </java-name>
				[Dot42.DexImport("KEYCODE_TAB", "I", AccessFlags = 25)]
				public const int KEYCODE_TAB = 61;
				/// <summary>
				///  <para>Key code constant: Space key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SPACE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SPACE", "I", AccessFlags = 25)]
				public const int KEYCODE_SPACE = 62;
				/// <summary>
				///  <para>Key code constant: Symbol modifier key. Used to enter alternate symbols. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SYM
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SYM", "I", AccessFlags = 25)]
				public const int KEYCODE_SYM = 63;
				/// <summary>
				///  <para>Key code constant: Explorer special function key. Used to launch a browser application. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_EXPLORER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_EXPLORER", "I", AccessFlags = 25)]
				public const int KEYCODE_EXPLORER = 64;
				/// <summary>
				///  <para>Key code constant: Envelope special function key. Used to launch a mail application. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_ENVELOPE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ENVELOPE", "I", AccessFlags = 25)]
				public const int KEYCODE_ENVELOPE = 65;
				/// <summary>
				///  <para>Key code constant: Enter key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_ENTER
				/// </java-name>
				[Dot42.DexImport("KEYCODE_ENTER", "I", AccessFlags = 25)]
				public const int KEYCODE_ENTER = 66;
				/// <summary>
				///  <para>Key code constant: Backspace key. Deletes characters before the insertion point, unlike KEYCODE_FORWARD_DEL. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_DEL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_DEL", "I", AccessFlags = 25)]
				public const int KEYCODE_DEL = 67;
				/// <summary>
				///  <para>Key code constant: '`' (backtick) key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_GRAVE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_GRAVE", "I", AccessFlags = 25)]
				public const int KEYCODE_GRAVE = 68;
				/// <summary>
				///  <para>Key code constant: '-'. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MINUS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MINUS", "I", AccessFlags = 25)]
				public const int KEYCODE_MINUS = 69;
				/// <summary>
				///  <para>Key code constant: '=' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_EQUALS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_EQUALS", "I", AccessFlags = 25)]
				public const int KEYCODE_EQUALS = 70;
				/// <summary>
				///  <para>Key code constant: '[' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_LEFT_BRACKET
				/// </java-name>
				[Dot42.DexImport("KEYCODE_LEFT_BRACKET", "I", AccessFlags = 25)]
				public const int KEYCODE_LEFT_BRACKET = 71;
				/// <summary>
				///  <para>Key code constant: ']' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_RIGHT_BRACKET
				/// </java-name>
				[Dot42.DexImport("KEYCODE_RIGHT_BRACKET", "I", AccessFlags = 25)]
				public const int KEYCODE_RIGHT_BRACKET = 72;
				/// <summary>
				///  <para>Key code constant: '\' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BACKSLASH
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BACKSLASH", "I", AccessFlags = 25)]
				public const int KEYCODE_BACKSLASH = 73;
				/// <summary>
				///  <para>Key code constant: ';' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SEMICOLON
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SEMICOLON", "I", AccessFlags = 25)]
				public const int KEYCODE_SEMICOLON = 74;
				/// <summary>
				///  <para>Key code constant: ''' (apostrophe) key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_APOSTROPHE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_APOSTROPHE", "I", AccessFlags = 25)]
				public const int KEYCODE_APOSTROPHE = 75;
				/// <summary>
				///  <para>Key code constant: '/' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SLASH
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SLASH", "I", AccessFlags = 25)]
				public const int KEYCODE_SLASH = 76;
				/// <summary>
				///  <para>Key code constant: '@' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_AT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_AT", "I", AccessFlags = 25)]
				public const int KEYCODE_AT = 77;
				/// <summary>
				///  <para>Key code constant: Number modifier key. Used to enter numeric symbols. This key is not Num Lock; it is more like KEYCODE_ALT_LEFT and is interpreted as an ALT key by android.text.method.MetaKeyKeyListener. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_NUM
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NUM", "I", AccessFlags = 25)]
				public const int KEYCODE_NUM = 78;
				/// <summary>
				///  <para>Key code constant: Headset Hook key. Used to hang up calls and stop media. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_HEADSETHOOK
				/// </java-name>
				[Dot42.DexImport("KEYCODE_HEADSETHOOK", "I", AccessFlags = 25)]
				public const int KEYCODE_HEADSETHOOK = 79;
				/// <summary>
				///  <para>Key code constant: Camera Focus key. Used to focus the camera. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_FOCUS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_FOCUS", "I", AccessFlags = 25)]
				public const int KEYCODE_FOCUS = 80;
				/// <summary>
				///  <para>Key code constant: '+' key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_PLUS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PLUS", "I", AccessFlags = 25)]
				public const int KEYCODE_PLUS = 81;
				/// <summary>
				///  <para>Key code constant: Menu key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MENU
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MENU", "I", AccessFlags = 25)]
				public const int KEYCODE_MENU = 82;
				/// <summary>
				///  <para>Key code constant: Notification key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_NOTIFICATION
				/// </java-name>
				[Dot42.DexImport("KEYCODE_NOTIFICATION", "I", AccessFlags = 25)]
				public const int KEYCODE_NOTIFICATION = 83;
				/// <summary>
				///  <para>Key code constant: Search key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SEARCH
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SEARCH", "I", AccessFlags = 25)]
				public const int KEYCODE_SEARCH = 84;
				/// <summary>
				///  <para>Key code constant: Play/Pause media key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MEDIA_PLAY_PAUSE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_PLAY_PAUSE", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_PLAY_PAUSE = 85;
				/// <summary>
				///  <para>Key code constant: Stop media key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MEDIA_STOP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_STOP", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_STOP = 86;
				/// <summary>
				///  <para>Key code constant: Play Next media key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MEDIA_NEXT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_NEXT", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_NEXT = 87;
				/// <summary>
				///  <para>Key code constant: Play Previous media key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MEDIA_PREVIOUS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_PREVIOUS", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_PREVIOUS = 88;
				/// <summary>
				///  <para>Key code constant: Rewind media key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MEDIA_REWIND
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_REWIND", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_REWIND = 89;
				/// <summary>
				///  <para>Key code constant: Fast Forward media key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MEDIA_FAST_FORWARD
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MEDIA_FAST_FORWARD", "I", AccessFlags = 25)]
				public const int KEYCODE_MEDIA_FAST_FORWARD = 90;
				/// <summary>
				///  <para>Key code constant: Mute key. Mutes the microphone, unlike KEYCODE_VOLUME_MUTE. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_MUTE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_MUTE", "I", AccessFlags = 25)]
				public const int KEYCODE_MUTE = 91;
				/// <summary>
				///  <para>Key code constant: Page Up key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_PAGE_UP
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PAGE_UP", "I", AccessFlags = 25)]
				public const int KEYCODE_PAGE_UP = 92;
				/// <summary>
				///  <para>Key code constant: Page Down key. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_PAGE_DOWN
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PAGE_DOWN", "I", AccessFlags = 25)]
				public const int KEYCODE_PAGE_DOWN = 93;
				/// <summary>
				///  <para>Key code constant: Picture Symbols modifier key. Used to switch symbol sets (Emoji, Kao-moji). </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_PICTSYMBOLS
				/// </java-name>
				[Dot42.DexImport("KEYCODE_PICTSYMBOLS", "I", AccessFlags = 25)]
				public const int KEYCODE_PICTSYMBOLS = 94;
				/// <summary>
				///  <para>Key code constant: Switch Charset modifier key. Used to switch character sets (Kanji, Katakana). </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_SWITCH_CHARSET
				/// </java-name>
				[Dot42.DexImport("KEYCODE_SWITCH_CHARSET", "I", AccessFlags = 25)]
				public const int KEYCODE_SWITCH_CHARSET = 95;
				/// <summary>
				///  <para>Key code constant: A Button key. On a game controller, the A button should be either the button labeled A or the first button on the bottom row of controller buttons. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_A
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_A", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_A = 96;
				/// <summary>
				///  <para>Key code constant: B Button key. On a game controller, the B button should be either the button labeled B or the second button on the bottom row of controller buttons. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_B
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_B", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_B = 97;
				/// <summary>
				///  <para>Key code constant: C Button key. On a game controller, the C button should be either the button labeled C or the third button on the bottom row of controller buttons. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_C
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_C", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_C = 98;
				/// <summary>
				///  <para>Key code constant: X Button key. On a game controller, the X button should be either the button labeled X or the first button on the upper row of controller buttons. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_X
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_X", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_X = 99;
				/// <summary>
				///  <para>Key code constant: Y Button key. On a game controller, the Y button should be either the button labeled Y or the second button on the upper row of controller buttons. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_Y
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_Y", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_Y = 100;
				/// <summary>
				///  <para>Key code constant: Z Button key. On a game controller, the Z button should be either the button labeled Z or the third button on the upper row of controller buttons. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_Z
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_Z", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_Z = 101;
				/// <summary>
				///  <para>Key code constant: L1 Button key. On a game controller, the L1 button should be either the button labeled L1 (or L) or the top left trigger button. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_L1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_L1", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_L1 = 102;
				/// <summary>
				///  <para>Key code constant: R1 Button key. On a game controller, the R1 button should be either the button labeled R1 (or R) or the top right trigger button. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_R1
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_R1", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_R1 = 103;
				/// <summary>
				///  <para>Key code constant: L2 Button key. On a game controller, the L2 button should be either the button labeled L2 or the bottom left trigger button. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_L2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_L2", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_L2 = 104;
				/// <summary>
				///  <para>Key code constant: R2 Button key. On a game controller, the R2 button should be either the button labeled R2 or the bottom right trigger button. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_R2
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_R2", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_R2 = 105;
				/// <summary>
				///  <para>Key code constant: Left Thumb Button key. On a game controller, the left thumb button indicates that the left (or only) joystick is pressed. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_THUMBL
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_THUMBL", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_THUMBL = 106;
				/// <summary>
				///  <para>Key code constant: Right Thumb Button key. On a game controller, the right thumb button indicates that the right joystick is pressed. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_THUMBR
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_THUMBR", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_THUMBR = 107;
				/// <summary>
				///  <para>Key code constant: Start Button key. On a game controller, the button labeled Start. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_START
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_START", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_START = 108;
				/// <summary>
				///  <para>Key code constant: Select Button key. On a game controller, the button labeled Select. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_SELECT
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_SELECT", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_SELECT = 109;
				/// <summary>
				///  <para>Key code constant: Mode Button key. On a game controller, the button labeled Mode. </para>        
				/// </summary>
				/// <java-name>
				/// KEYCODE_BUTTON_MODE
				/// </java-name>
				[Dot42.DexImport("KEYCODE_BUTTON_MODE", "I", AccessFlags = 25)]
				public const int KEYCODE_BUTTON_MODE = 110;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>There are now more than MAX_KEYCODE keycodes. Use getMaxKeyCode() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// MAX_KEYCODE
				/// </java-name>
				[Dot42.DexImport("MAX_KEYCODE", "I", AccessFlags = 25)]
				public const int MAX_KEYCODE = 84;
				/// <summary>
				///  <para>getAction value: the key has been pressed down. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_DOWN = 0;
				/// <summary>
				///  <para>getAction value: the key has been released. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_UP", "I", AccessFlags = 25)]
				public const int ACTION_UP = 1;
				/// <summary>
				///  <para>getAction value: multiple duplicate key events have occurred in a row, or a complex string is being delivered. If the key code is not {#link KEYCODE_UNKNOWN then the {#link getRepeatCount() method returns the number of times the given key code should be executed. Otherwise, if the key code is KEYCODE_UNKNOWN, then this is a sequence of characters as returned by getCharacters. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MULTIPLE
				/// </java-name>
				[Dot42.DexImport("ACTION_MULTIPLE", "I", AccessFlags = 25)]
				public const int ACTION_MULTIPLE = 2;
				/// <summary>
				///  <para>This mask is used to check whether one of the ALT meta keys is pressed.</para> <para> <para>isAltPressed() </para> <para>getMetaState() </para> <para>KEYCODE_ALT_LEFT </para> <para>KEYCODE_ALT_RIGHT </para></para>        
				/// </summary>
				/// <java-name>
				/// META_ALT_ON
				/// </java-name>
				[Dot42.DexImport("META_ALT_ON", "I", AccessFlags = 25)]
				public const int META_ALT_ON = 2;
				/// <summary>
				///  <para>This mask is used to check whether the left ALT meta key is pressed.</para> <para> <para>isAltPressed() </para> <para>getMetaState() </para> <para>KEYCODE_ALT_LEFT </para></para>        
				/// </summary>
				/// <java-name>
				/// META_ALT_LEFT_ON
				/// </java-name>
				[Dot42.DexImport("META_ALT_LEFT_ON", "I", AccessFlags = 25)]
				public const int META_ALT_LEFT_ON = 16;
				/// <summary>
				///  <para>This mask is used to check whether the right the ALT meta key is pressed.</para> <para> <para>isAltPressed() </para> <para>getMetaState() </para> <para>KEYCODE_ALT_RIGHT </para></para>        
				/// </summary>
				/// <java-name>
				/// META_ALT_RIGHT_ON
				/// </java-name>
				[Dot42.DexImport("META_ALT_RIGHT_ON", "I", AccessFlags = 25)]
				public const int META_ALT_RIGHT_ON = 32;
				/// <summary>
				///  <para>This mask is used to check whether one of the SHIFT meta keys is pressed.</para> <para> <para>isShiftPressed() </para> <para>getMetaState() </para> <para>KEYCODE_SHIFT_LEFT </para> <para>KEYCODE_SHIFT_RIGHT </para></para>        
				/// </summary>
				/// <java-name>
				/// META_SHIFT_ON
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_ON", "I", AccessFlags = 25)]
				public const int META_SHIFT_ON = 1;
				/// <summary>
				///  <para>This mask is used to check whether the left SHIFT meta key is pressed.</para> <para> <para>isShiftPressed() </para> <para>getMetaState() </para> <para>KEYCODE_SHIFT_LEFT </para></para>        
				/// </summary>
				/// <java-name>
				/// META_SHIFT_LEFT_ON
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_LEFT_ON", "I", AccessFlags = 25)]
				public const int META_SHIFT_LEFT_ON = 64;
				/// <summary>
				///  <para>This mask is used to check whether the right SHIFT meta key is pressed.</para> <para> <para>isShiftPressed() </para> <para>getMetaState() </para> <para>KEYCODE_SHIFT_RIGHT </para></para>        
				/// </summary>
				/// <java-name>
				/// META_SHIFT_RIGHT_ON
				/// </java-name>
				[Dot42.DexImport("META_SHIFT_RIGHT_ON", "I", AccessFlags = 25)]
				public const int META_SHIFT_RIGHT_ON = 128;
				/// <summary>
				///  <para>This mask is used to check whether the SYM meta key is pressed.</para> <para> <para>isSymPressed() </para> <para>getMetaState() </para></para>        
				/// </summary>
				/// <java-name>
				/// META_SYM_ON
				/// </java-name>
				[Dot42.DexImport("META_SYM_ON", "I", AccessFlags = 25)]
				public const int META_SYM_ON = 4;
				/// <summary>
				///  <para>This mask is set if the device woke because of this key event. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_WOKE_HERE
				/// </java-name>
				[Dot42.DexImport("FLAG_WOKE_HERE", "I", AccessFlags = 25)]
				public const int FLAG_WOKE_HERE = 1;
				/// <summary>
				///  <para>This mask is set if the key event was generated by a software keyboard. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_SOFT_KEYBOARD
				/// </java-name>
				[Dot42.DexImport("FLAG_SOFT_KEYBOARD", "I", AccessFlags = 25)]
				public const int FLAG_SOFT_KEYBOARD = 2;
				/// <summary>
				///  <para>This mask is set if we don't want the key event to cause us to leave touch mode. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_KEEP_TOUCH_MODE
				/// </java-name>
				[Dot42.DexImport("FLAG_KEEP_TOUCH_MODE", "I", AccessFlags = 25)]
				public const int FLAG_KEEP_TOUCH_MODE = 4;
				/// <summary>
				///  <para>This mask is set if an event was known to come from a trusted part of the system. That is, the event is known to come from the user, and could not have been spoofed by a third party component. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_FROM_SYSTEM
				/// </java-name>
				[Dot42.DexImport("FLAG_FROM_SYSTEM", "I", AccessFlags = 25)]
				public const int FLAG_FROM_SYSTEM = 8;
				/// <summary>
				///  <para>This mask is used for compatibility, to identify enter keys that are coming from an IME whose enter key has been auto-labelled "next" or "done". This allows TextView to dispatch these as normal enter keys for old applications, but still do the appropriate action when receiving them. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_EDITOR_ACTION
				/// </java-name>
				[Dot42.DexImport("FLAG_EDITOR_ACTION", "I", AccessFlags = 25)]
				public const int FLAG_EDITOR_ACTION = 16;
				/// <summary>
				///  <para>When associated with up key events, this indicates that the key press has been canceled. Typically this is used with virtual touch screen keys, where the user can slide from the virtual key area on to the display: in that case, the application will receive a canceled up event and should not perform the action normally associated with the key. Note that for this to work, the application can not perform an action for a key until it receives an up or the long press timeout has expired. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_CANCELED
				/// </java-name>
				[Dot42.DexImport("FLAG_CANCELED", "I", AccessFlags = 25)]
				public const int FLAG_CANCELED = 32;
				/// <summary>
				///  <para>This key event was generated by a virtual (on-screen) hard key area. Typically this is an area of the touchscreen, outside of the regular display, dedicated to "hardware" buttons. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_VIRTUAL_HARD_KEY
				/// </java-name>
				[Dot42.DexImport("FLAG_VIRTUAL_HARD_KEY", "I", AccessFlags = 25)]
				public const int FLAG_VIRTUAL_HARD_KEY = 64;
				/// <summary>
				///  <para>This flag is set for the first key repeat that occurs after the long press timeout. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_LONG_PRESS
				/// </java-name>
				[Dot42.DexImport("FLAG_LONG_PRESS", "I", AccessFlags = 25)]
				public const int FLAG_LONG_PRESS = 128;
				/// <summary>
				///  <para>Set when a key event has FLAG_CANCELED set because a long press action was executed while it was down. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_CANCELED_LONG_PRESS
				/// </java-name>
				[Dot42.DexImport("FLAG_CANCELED_LONG_PRESS", "I", AccessFlags = 25)]
				public const int FLAG_CANCELED_LONG_PRESS = 256;
				/// <summary>
				///  <para>Set for ACTION_UP when this event's key code is still being tracked from its initial down. That is, somebody requested that tracking started on the key down and a long press has not caused the tracking to be canceled. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_TRACKING
				/// </java-name>
				[Dot42.DexImport("FLAG_TRACKING", "I", AccessFlags = 25)]
				public const int FLAG_TRACKING = 512;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.KeyEvent> CREATOR;
				/// <summary>
				///  <para>Copy an existing key event, modifying its action.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(II)V", AccessFlags = 1)]
				public KeyEvent(int origEvent, int action) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new key event.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JJIII)V", AccessFlags = 1)]
				public KeyEvent(long downTime, long eventTime, int action, int code, int repeat) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new key event.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JJIIII)V", AccessFlags = 1)]
				public KeyEvent(long downTime, long eventTime, int action, int code, int repeat, int metaState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new key event.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JJIIIIII)V", AccessFlags = 1)]
				public KeyEvent(long downTime, long eventTime, int action, int code, int repeat, int metaState, int deviceId, int scancode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new key event.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JJIIIIIII)V", AccessFlags = 1)]
				public KeyEvent(long downTime, long eventTime, int action, int code, int repeat, int metaState, int deviceId, int scancode, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new key event.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JJIIIIIIII)V", AccessFlags = 1)]
				public KeyEvent(long downTime, long eventTime, int action, int code, int repeat, int metaState, int deviceId, int scancode, int flags, int source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new key event for a string of characters. The key code, action, repeat count and source will automatically be set to KEYCODE_UNKNOWN, ACTION_MULTIPLE, 0, and InputDevice#SOURCE_KEYBOARD for you.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(JLjava/lang/String;II)V", AccessFlags = 1)]
				public KeyEvent(long time, string characters, int deviceId, int flags) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/view/KeyEvent;)V", AccessFlags = 1)]
				public KeyEvent(global::Android.Views.KeyEvent @in) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Copy an existing key event, modifying its time and repeat count.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use changeTimeRepeat(KeyEvent, long, int) instead.</para></xrefdescription></xrefsect></para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/KeyEvent;JI)V", AccessFlags = 1)]
				public KeyEvent(global::Android.Views.KeyEvent origEvent, long eventTime, int newRepeat) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the character that is produced by putting accent on the character c. For example, getDeadChar('`', 'e') returns  <egrave></egrave>. </para>        
				/// </summary>
				/// <java-name>
				/// getDeadChar
				/// </java-name>
				[Dot42.DexImport("getDeadChar", "(II)I", AccessFlags = 9)]
				public static int GetDeadChar(int accent, int c) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Create a new key event that is the same as the given one, but whose event time and repeat count are replaced with the given value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// changeTimeRepeat
				/// </java-name>
				[Dot42.DexImport("changeTimeRepeat", "(Landroid/view/KeyEvent;JI)Landroid/view/KeyEvent;", AccessFlags = 9)]
				public static global::Android.Views.KeyEvent ChangeTimeRepeat(global::Android.Views.KeyEvent @event, long eventTime, int newRepeat) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent);
				}

				/// <summary>
				///  <para>Create a new key event that is the same as the given one, but whose event time and repeat count are replaced with the given value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// changeTimeRepeat
				/// </java-name>
				[Dot42.DexImport("changeTimeRepeat", "(Landroid/view/KeyEvent;JII)Landroid/view/KeyEvent;", AccessFlags = 9)]
				public static global::Android.Views.KeyEvent ChangeTimeRepeat(global::Android.Views.KeyEvent @event, long eventTime, int newRepeat, int newFlags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent);
				}

				/// <summary>
				///  <para>Create a new key event that is the same as the given one, but whose action is replaced with the given value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// changeAction
				/// </java-name>
				[Dot42.DexImport("changeAction", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;", AccessFlags = 9)]
				public static global::Android.Views.KeyEvent ChangeAction(global::Android.Views.KeyEvent @event, int action) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent);
				}

				/// <summary>
				///  <para>Create a new key event that is the same as the given one, but whose flags are replaced with the given value.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// changeFlags
				/// </java-name>
				[Dot42.DexImport("changeFlags", "(Landroid/view/KeyEvent;I)Landroid/view/KeyEvent;", AccessFlags = 9)]
				public static global::Android.Views.KeyEvent ChangeFlags(global::Android.Views.KeyEvent @event, int flags) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.KeyEvent);
				}

				/// <summary>
				///  <para>Returns true if this key code is a modifier key. </para> <para>For the purposes of this function, KEYCODE_CAPS_LOCK, KEYCODE_SCROLL_LOCK, and KEYCODE_NUM_LOCK are not considered modifier keys. Consequently, this function return false for those keys. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the key code is one of KEYCODE_SHIFT_LEFT KEYCODE_SHIFT_RIGHT, KEYCODE_ALT_LEFT, KEYCODE_ALT_RIGHT, KEYCODE_CTRL_LEFT, KEYCODE_CTRL_RIGHT, KEYCODE_META_LEFT, or KEYCODE_META_RIGHT, KEYCODE_SYM, KEYCODE_NUM, KEYCODE_FUNCTION. </para>
				/// </returns>
				/// <java-name>
				/// isModifierKey
				/// </java-name>
				[Dot42.DexImport("isModifierKey", "(I)Z", AccessFlags = 9)]
				public static bool IsModifierKey(int keyCode) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Call this during Callback#onKeyDown to have the system track the key through its final up (possibly including a long press). Note that only one key can be tracked at a time  if another key down event is received while a previous one is being tracked, tracking is stopped on the previous event. </para>        
				/// </summary>
				/// <java-name>
				/// startTracking
				/// </java-name>
				[Dot42.DexImport("startTracking", "()V", AccessFlags = 17)]
				public void StartTracking() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets the Unicode character generated by the specified key and meta key state combination. </para> <para>Returns the Unicode character that the specified key would produce when the specified meta bits (see MetaKeyKeyListener) were active. </para> <para>Returns 0 if the key is not one that is used to type Unicode characters. </para> <para>If the return value has bit KeyCharacterMap#COMBINING_ACCENT set, the key is a "dead key" that should be combined with another to actually produce a character  see KeyCharacterMap#getDeadChar  after masking with KeyCharacterMap#COMBINING_ACCENT_MASK. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The associated character or combining accent, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getUnicodeChar
				/// </java-name>
				[Dot42.DexImport("getUnicodeChar", "(I)I", AccessFlags = 1)]
				public virtual int GetUnicodeChar(int metaState) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Get the character conversion data for a given key code.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>instead use getDisplayLabel(), getNumber() or getUnicodeChar(int). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the key was mapped. If the key was not mapped, results is not modified.</para>
				/// </returns>
				/// <java-name>
				/// getKeyData
				/// </java-name>
				[Dot42.DexImport("getKeyData", "(Landroid/view/KeyCharacterMap$KeyData;)Z", AccessFlags = 1)]
				public virtual bool GetKeyData(global::Android.Views.KeyCharacterMap.KeyData results) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Gets the first character in the character array that can be generated by the specified key code. </para> <para>This is a convenience function that returns the same value as getMatch(chars, 0). </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The matching associated character, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getMatch
				/// </java-name>
				[Dot42.DexImport("getMatch", "([C)C", AccessFlags = 1)]
				public virtual char GetMatch(char[] chars) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para>Gets the first character in the character array that can be generated by the specified key code. If there are multiple choices, prefers the one that would be generated with the specified meta key modifier state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The matching associated character, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getMatch
				/// </java-name>
				[Dot42.DexImport("getMatch", "([CI)C", AccessFlags = 1)]
				public virtual char GetMatch(char[] chars, int metaState) /* MethodBuilder.Create */ 
				{
						return default(char);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use dispatch(Callback, DispatcherState, Object) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// dispatch
				/// </java-name>
				[Dot42.DexImport("dispatch", "(Landroid/view/KeyEvent$Callback;)Z", AccessFlags = 17)]
				public bool Dispatch(global::Android.Views.KeyEvent.ICallback receiver) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Deliver this key event to a Callback interface. If this is an ACTION_MULTIPLE event and it is not handled, then an attempt will be made to deliver a single normal event.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The return value from the Callback method that was called. </para>
				/// </returns>
				/// <java-name>
				/// dispatch
				/// </java-name>
				[Dot42.DexImport("dispatch", "(Landroid/view/KeyEvent$Callback;Landroid/view/KeyEvent$DispatcherState;Ljava/lan" +
    "g/Object;)Z", AccessFlags = 17)]
				public bool Dispatch(global::Android.Views.KeyEvent.ICallback receiver, global::Android.Views.KeyEvent.DispatcherState state, object target) /* MethodBuilder.Create */ 
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
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the maximum keycode. </para>        
				/// </summary>
				/// <java-name>
				/// getMaxKeyCode
				/// </java-name>
				public static int MaxKeyCode
				{
						[Dot42.DexImport("getMaxKeyCode", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Is this a system key? System keys can not be used for menu shortcuts.</para> <para>TODO: this information should come from a table somewhere. TODO: should the dpad keys be here? arguably, because they also shouldn't be menu shortcuts </para>        
				/// </summary>
				/// <java-name>
				/// isSystem
				/// </java-name>
				public bool IsSystem
				{
						[Dot42.DexImport("isSystem", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the state of the meta keys.</para> <para> <para>isAltPressed() </para> <para>isShiftPressed() </para> <para>isSymPressed() </para> <para>isCtrlPressed() </para> <para>isMetaPressed() </para> <para>isFunctionPressed() </para> <para>isCapsLockOn() </para> <para>isNumLockOn() </para> <para>isScrollLockOn() </para> <para>META_ALT_ON </para> <para>META_ALT_LEFT_ON </para> <para>META_ALT_RIGHT_ON </para> <para>META_SHIFT_ON </para> <para>META_SHIFT_LEFT_ON </para> <para>META_SHIFT_RIGHT_ON </para> <para>META_SYM_ON </para> <para>META_FUNCTION_ON </para> <para>META_CTRL_ON </para> <para>META_CTRL_LEFT_ON </para> <para>META_CTRL_RIGHT_ON </para> <para>META_META_ON </para> <para>META_META_LEFT_ON </para> <para>META_META_RIGHT_ON </para> <para>META_CAPS_LOCK_ON </para> <para>META_NUM_LOCK_ON </para> <para>META_SCROLL_LOCK_ON </para> <para>getModifiers </para></para>        
				/// </summary>
				/// <returns>
				///  <para>an integer in which each bit set to 1 represents a pressed meta key</para>
				/// </returns>
				/// <java-name>
				/// getMetaState
				/// </java-name>
				public int MetaState
				{
						[Dot42.DexImport("getMetaState", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the flags for this key event.</para> <para> <para>FLAG_WOKE_HERE </para></para>        
				/// </summary>
				/// <java-name>
				/// getFlags
				/// </java-name>
				public int Flags
				{
						[Dot42.DexImport("getFlags", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the pressed state of the ALT meta key.</para> <para> <para>KEYCODE_ALT_LEFT </para> <para>KEYCODE_ALT_RIGHT </para> <para>META_ALT_ON </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the ALT key is pressed, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isAltPressed
				/// </java-name>
				public bool IsAltPressed
				{
						[Dot42.DexImport("isAltPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the pressed state of the SHIFT meta key.</para> <para> <para>KEYCODE_SHIFT_LEFT </para> <para>KEYCODE_SHIFT_RIGHT </para> <para>META_SHIFT_ON </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the SHIFT key is pressed, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isShiftPressed
				/// </java-name>
				public bool IsShiftPressed
				{
						[Dot42.DexImport("isShiftPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the pressed state of the SYM meta key.</para> <para> <para>KEYCODE_SYM </para> <para>META_SYM_ON </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the SYM key is pressed, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// isSymPressed
				/// </java-name>
				public bool IsSymPressed
				{
						[Dot42.DexImport("isSymPressed", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Retrieve the action of this key event. May be either ACTION_DOWN, ACTION_UP, or ACTION_MULTIPLE.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The event action: ACTION_DOWN, ACTION_UP, or ACTION_MULTIPLE. </para>
				/// </returns>
				/// <java-name>
				/// getAction
				/// </java-name>
				public int Action
				{
						[Dot42.DexImport("getAction", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>For ACTION_UP events, indicates that the event has been canceled as per FLAG_CANCELED. </para>        
				/// </summary>
				/// <java-name>
				/// isCanceled
				/// </java-name>
				public bool IsCanceled
				{
						[Dot42.DexImport("isCanceled", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>For ACTION_UP events, indicates that the event is still being tracked from its initial down event as per FLAG_TRACKING. </para>        
				/// </summary>
				/// <java-name>
				/// isTracking
				/// </java-name>
				public bool IsTracking
				{
						[Dot42.DexImport("isTracking", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>For ACTION_DOWN events, indicates that the event has been canceled as per FLAG_LONG_PRESS. </para>        
				/// </summary>
				/// <java-name>
				/// isLongPress
				/// </java-name>
				public bool IsLongPress
				{
						[Dot42.DexImport("isLongPress", "()Z", AccessFlags = 17)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Retrieve the key code of the key event. This is the physical key that was pressed,  <b>not</b> the Unicode character.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The key code of the event. </para>
				/// </returns>
				/// <java-name>
				/// getKeyCode
				/// </java-name>
				public int KeyCode
				{
						[Dot42.DexImport("getKeyCode", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>For the special case of a ACTION_MULTIPLE event with key code of KEYCODE_UNKNOWN, this is a raw string of characters associated with the event. In all other cases it is null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a String of 1 or more characters associated with the event. </para>
				/// </returns>
				/// <java-name>
				/// getCharacters
				/// </java-name>
				public string Characters
				{
						[Dot42.DexImport("getCharacters", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Retrieve the hardware key id of this key event. These values are not reliable and vary from device to device.</para> <para>{} Mostly this is here for debugging purposes. </para>        
				/// </summary>
				/// <java-name>
				/// getScanCode
				/// </java-name>
				public int ScanCode
				{
						[Dot42.DexImport("getScanCode", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Retrieve the repeat count of the event. For both key up and key down events, this is the number of times the key has repeated with the first down starting at 0 and counting up from there. For multiple key events, this is the number of down/up pairs that have occurred.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of times the key has repeated. </para>
				/// </returns>
				/// <java-name>
				/// getRepeatCount
				/// </java-name>
				public int RepeatCount
				{
						[Dot42.DexImport("getRepeatCount", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Retrieve the time of the most recent key down event, in the android.os.SystemClock#uptimeMillis time base. If this is a down event, this will be the same as getEventTime(). Note that when chording keys, this value is the down time of the most recently pressed key, which may  <b>not</b> be the same physical key of this event.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the most recent key down time, in the android.os.SystemClock#uptimeMillis time base </para>
				/// </returns>
				/// <java-name>
				/// getDownTime
				/// </java-name>
				public long DownTime
				{
						[Dot42.DexImport("getDownTime", "()J", AccessFlags = 17)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Retrieve the time this event occurred, in the android.os.SystemClock#uptimeMillis time base.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the time this event occurred, in the android.os.SystemClock#uptimeMillis time base. </para>
				/// </returns>
				/// <java-name>
				/// getEventTime
				/// </java-name>
				public long EventTime
				{
						[Dot42.DexImport("getEventTime", "()J", AccessFlags = 17)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Gets the primary character for this key. In other words, the label that is physically printed on it.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The display label character, or 0 if none (eg. for non-printing keys). </para>
				/// </returns>
				/// <java-name>
				/// getDisplayLabel
				/// </java-name>
				public virtual char DisplayLabel
				{
						[Dot42.DexImport("getDisplayLabel", "()C", AccessFlags = 1)]
						get{ return default(char); }
				}

				/// <summary>
				///  <para>Gets the Unicode character generated by the specified key and meta key state combination. </para> <para>Returns the Unicode character that the specified key would produce when the specified meta bits (see MetaKeyKeyListener) were active. </para> <para>Returns 0 if the key is not one that is used to type Unicode characters. </para> <para>If the return value has bit KeyCharacterMap#COMBINING_ACCENT set, the key is a "dead key" that should be combined with another to actually produce a character  see KeyCharacterMap#getDeadChar  after masking with KeyCharacterMap#COMBINING_ACCENT_MASK. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The associated character or combining accent, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getUnicodeChar
				/// </java-name>
				public virtual int UnicodeChar
				{
						[Dot42.DexImport("getUnicodeChar", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the number or symbol associated with the key. </para> <para>The character value is returned, not the numeric value. If the key is not a number, but is a symbol, the symbol is retuned. </para> <para>This method is intended to to support dial pads and other numeric or symbolic entry on keyboards where certain keys serve dual function as alphabetic and symbolic keys. This method returns the number or symbol associated with the key independent of whether the user has pressed the required modifier. </para> <para>For example, on one particular keyboard the keys on the top QWERTY row generate numbers when ALT is pressed such that ALT-Q maps to '1'. So for that keyboard when getNumber is called with KeyEvent#KEYCODE_Q it returns '1' so that the user can type numbers without pressing ALT when it makes sense. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The associated numeric or symbolic character, or 0 if none. </para>
				/// </returns>
				/// <java-name>
				/// getNumber
				/// </java-name>
				public virtual char Number
				{
						[Dot42.DexImport("getNumber", "()C", AccessFlags = 1)]
						get{ return default(char); }
				}

				/// <summary>
				///  <para>Returns true if this key produces a glyph.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the key is a printing key. </para>
				/// </returns>
				/// <java-name>
				/// isPrintingKey
				/// </java-name>
				public virtual bool IsPrintingKey
				{
						[Dot42.DexImport("isPrintingKey", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Use with KeyEvent#dispatch(Callback, DispatcherState, Object) for more advanced key dispatching, such as long presses. </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Reset back to initial state. </para>        
						/// </summary>
						/// <java-name>
						/// reset
						/// </java-name>
						[Dot42.DexImport("reset", "()V", AccessFlags = 1)]
						public virtual void Reset() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Stop any tracking associated with this target. </para>        
						/// </summary>
						/// <java-name>
						/// reset
						/// </java-name>
						[Dot42.DexImport("reset", "(Ljava/lang/Object;)V", AccessFlags = 1)]
						public virtual void Reset(object target) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Start tracking the key code associated with the given event. This can only be called on a key down. It will allow you to see any long press associated with the key, and will result in KeyEvent#isTracking return true on the long press and up events.</para> <para>This is only needed if you are directly dispatching events, rather than handling them in Callback#onKeyDown. </para>        
						/// </summary>
						/// <java-name>
						/// startTracking
						/// </java-name>
						[Dot42.DexImport("startTracking", "(Landroid/view/KeyEvent;Ljava/lang/Object;)V", AccessFlags = 1)]
						public virtual void StartTracking(global::Android.Views.KeyEvent @event, object target) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Return true if the key event is for a key code that is currently being tracked by the dispatcher. </para>        
						/// </summary>
						/// <java-name>
						/// isTracking
						/// </java-name>
						[Dot42.DexImport("isTracking", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
						public virtual bool IsTracking(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Keep track of the given event's key code as having performed an action with a long press, so no action should occur on the up. </para> <para>This is only needed if you are directly dispatching events, rather than handling them in Callback#onKeyLongPress. </para>        
						/// </summary>
						/// <java-name>
						/// performedLongPress
						/// </java-name>
						[Dot42.DexImport("performedLongPress", "(Landroid/view/KeyEvent;)V", AccessFlags = 1)]
						public virtual void PerformedLongPress(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Handle key up event to stop tracking. This resets the dispatcher state, and updates the key event state based on it. </para> <para>This is only needed if you are directly dispatching events, rather than handling them in Callback#onKeyUp. </para>        
						/// </summary>
						/// <java-name>
						/// handleUpEvent
						/// </java-name>
						[Dot42.DexImport("handleUpEvent", "(Landroid/view/KeyEvent;)V", AccessFlags = 1)]
						public virtual void HandleUpEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
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
						/// <summary>
						///  <para>Called when a key down event has occurred. If you return true, you can first call KeyEvent.startTracking() to have the framework track the event through its onKeyUp(int, KeyEvent) and also call your onKeyLongPress(int, KeyEvent) if it occurs.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
						/// </returns>
						/// <java-name>
						/// onKeyDown
						/// </java-name>
						[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a long press has occurred. If you return true, the final key up will have KeyEvent#FLAG_CANCELED and KeyEvent#FLAG_CANCELED_LONG_PRESS set. Note that in order to receive this callback, someone in the event change  <b>must</b> return true from onKeyDown  <b>and</b> call KeyEvent#startTracking() on the event.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
						/// </returns>
						/// <java-name>
						/// onKeyLongPress
						/// </java-name>
						[Dot42.DexImport("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKeyLongPress(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a key up event has occurred.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
						/// </returns>
						/// <java-name>
						/// onKeyUp
						/// </java-name>
						[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when multiple down/up pairs of the same key have occurred in a row.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
						/// </returns>
						/// <java-name>
						/// onKeyMultiple
						/// </java-name>
						[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKeyMultiple(int keyCode, int count, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Instantiates a layout XML file into its corresponding android.view.View objects. It is never used directly. Instead, use android.app.Activity#getLayoutInflater() or Context#getSystemService to retrieve a standard LayoutInflater instance that is already hooked up to the current context and correctly configured for the device you are running on. For example:</para> <para> <pre>LayoutInflater inflater = (LayoutInflater)context.getSystemService
		///      (Context.LAYOUT_INFLATER_SERVICE);</pre></para> <para>To create a new LayoutInflater with an additional Factory for your own views, you can use cloneInContext to clone an existing ViewFactory, and then call setFactory on it to include your Factory.</para> <para>For performance reasons, view inflation relies heavily on pre-processing of XML files that is done at build time. Therefore, it is not currently possible to use LayoutInflater with an XmlPullParser over a plain XML file at runtime; it only works with an XmlPullParser returned from a compiled resource (R. <b>something</b> file.)</para> <para> <para>Context::getSystemService </para></para>    
		/// </summary>
		/// <java-name>
		/// android/view/LayoutInflater
		/// </java-name>
		[Dot42.DexImport("android/view/LayoutInflater", AccessFlags = 1057)]
		public abstract partial class LayoutInflater
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a new LayoutInflater instance associated with a particular Context. Applications will almost always want to use Context.getSystemService() to retrieve the standard Context.INFLATER_SERVICE.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal LayoutInflater(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a new LayoutInflater instance that is a copy of an existing LayoutInflater, optionally with its Context changed. For use in implementing cloneInContext.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/view/LayoutInflater;Landroid/content/Context;)V", AccessFlags = 4)]
				protected internal LayoutInflater(global::Android.Views.LayoutInflater original, global::Android.Content.Context newContext) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Obtains the LayoutInflater from the given context. </para>        
				/// </summary>
				/// <java-name>
				/// from
				/// </java-name>
				[Dot42.DexImport("from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;", AccessFlags = 9)]
				public static global::Android.Views.LayoutInflater From(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.LayoutInflater);
				}

				/// <summary>
				///  <para>Create a copy of the existing LayoutInflater object, with the copy pointing to a different Context than the original. This is used by ContextThemeWrapper to create a new LayoutInflater to go along with the new Context theme.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a brand spanking new LayoutInflater object associated with the given Context. </para>
				/// </returns>
				/// <java-name>
				/// cloneInContext
				/// </java-name>
				[Dot42.DexImport("cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;", AccessFlags = 1025)]
				public abstract global::Android.Views.LayoutInflater CloneInContext(global::Android.Content.Context newContext) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Inflate a new view hierarchy from the specified xml resource. Throws InflateException if there is an error.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The root View of the inflated hierarchy. If root was supplied, this is the root View; otherwise it is the root of the inflated XML file. </para>
				/// </returns>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(ILandroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View Inflate(int resource, global::Android.Views.ViewGroup root) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Inflate a new view hierarchy from the specified xml resource. Throws InflateException if there is an error.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The root View of the inflated hierarchy. If root was supplied, this is the root View; otherwise it is the root of the inflated XML file. </para>
				/// </returns>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View Inflate(global::Org.Xmlpull.V1.IXmlPullParser resource, global::Android.Views.ViewGroup root) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Low-level function for instantiating a view by name. This attempts to instantiate a view class of the given  <b>name</b> found in this LayoutInflater's ClassLoader.</para> <para>There are two things that can happen in an error case: either the exception describing the error will be thrown, or a null will be returned. You must deal with both possibilities  the former will happen the first time createView() is called for a class of a particular name, the latter every time there-after for that class name.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>View The newly instantiated view, or null. </para>
				/// </returns>
				/// <java-name>
				/// createView
				/// </java-name>
				[Dot42.DexImport("createView", "(Ljava/lang/String;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/Vi" +
    "ew;", AccessFlags = 17)]
				public global::Android.Views.View CreateView(string name, string prefix, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>This routine is responsible for creating the correct subclass of View given the xml element name. Override it to handle custom view objects. If you override this in your subclass be sure to call through to super.onCreateView(name) for names you do not recognize.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>View The View created. </para>
				/// </returns>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.View OnCreateView(string name, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal LayoutInflater() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the context we are running in, for access to resources, class loader, etc. </para>        
				/// </summary>
				/// <java-name>
				/// getContext
				/// </java-name>
				public virtual global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <summary>
				///  <para>Return the current Factory (or null). This is called on each element name. If the factory returns a View, add that to the hierarchy. If it returns null, proceed to call onCreateView(name). </para>        
				/// </summary>
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

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The Filter currently used by this LayoutInflater to restrict the set of Views that are allowed to be inflated. </para>
				/// </returns>
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
				/// android/view/LayoutInflater$Factory
				/// </java-name>
				[Dot42.DexImport("android/view/LayoutInflater$Factory", AccessFlags = 1545)]
				public partial interface IFactory
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Hook you can supply that is called when inflating from a LayoutInflater. You can use this to customize the tag names available in your XML layout files.</para> <para>Note that it is good practice to prefix these custom names with your package (i.e., com.coolcompany.apps) to avoid conflicts with system names.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>View Newly created view. Return null for the default behavior. </para>
						/// </returns>
						/// <java-name>
						/// onCreateView
						/// </java-name>
						[Dot42.DexImport("onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/" +
    "view/View;", AccessFlags = 1025)]
						global::Android.Views.View OnCreateView(string name, global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Hook to allow clients of the LayoutInflater to restrict the set of Views that are allowed to be inflated. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/LayoutInflater$Filter
				/// </java-name>
				[Dot42.DexImport("android/view/LayoutInflater$Filter", AccessFlags = 1545)]
				public partial interface IFilter
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Hook to allow clients of the LayoutInflater to restrict the set of Views that are allowed to be inflated.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if this class is allowed to be inflated, or false otherwise </para>
						/// </returns>
						/// <java-name>
						/// onLoadClass
						/// </java-name>
						[Dot42.DexImport("onLoadClass", "(Ljava/lang/Class;)Z", AccessFlags = 1025)]
						bool OnLoadClass(global::System.Type clazz) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>This class is used to instantiate menu XML files into Menu objects. </para> <para>For performance reasons, menu inflation relies heavily on pre-processing of XML files that is done at build time. Therefore, it is not currently possible to use MenuInflater with an XmlPullParser over a plain XML file at runtime; it only works with an XmlPullParser returned from a compiled resource (R.  <b>something</b> file.) </para>    
		/// </summary>
		/// <java-name>
		/// android/view/MenuInflater
		/// </java-name>
		[Dot42.DexImport("android/view/MenuInflater", AccessFlags = 33)]
		public partial class MenuInflater
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructs a menu inflater.</para> <para> <para>Activity::getMenuInflater() </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public MenuInflater(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Inflate a menu hierarchy from the specified XML resource. Throws InflateException if there is an error.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(ILandroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void Inflate(int menuRes, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal MenuInflater() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Object used to report movement (mouse, pen, finger, trackball) events. Motion events may hold either absolute or relative movements and other data, depending on the type of device.</para> <para> <h3>Overview</h3></para> <para>Motion events describe movements in terms of an action code and a set of axis values. The action code specifies the state change that occurred such as a pointer going down or up. The axis values describe the position and other movement properties. </para> <para>For example, when the user first touches the screen, the system delivers a touch event to the appropriate View with the action code ACTION_DOWN and a set of axis values that include the X and Y coordinates of the touch and information about the pressure, size and orientation of the contact area. </para> <para>Some devices can report multiple movement traces at the same time. Multi-touch screens emit one movement trace for each finger. The individual fingers or other objects that generate movement traces are referred to as  <b>pointers</b>. Motion events contain information about all of the pointers that are currently active even if some of them have not moved since the last event was delivered. </para> <para>The number of pointers only ever changes by one as individual pointers go up and down, except when the gesture is canceled. </para> <para>Each pointer has a unique id that is assigned when it first goes down (indicated by ACTION_DOWN or ACTION_POINTER_DOWN). A pointer id remains valid until the pointer eventually goes up (indicated by ACTION_UP or ACTION_POINTER_UP) or when the gesture is canceled (indicated by ACTION_CANCEL). </para> <para>The MotionEvent class provides many methods to query the position and other properties of pointers, such as getX(int), getY(int), getAxisValue, getPointerId(int), getToolType(int), and many others. Most of these methods accept the pointer index as a parameter rather than the pointer id. The pointer index of each pointer in the event ranges from 0 to one less than the value returned by getPointerCount(). </para> <para>The order in which individual pointers appear within a motion event is undefined. Thus the pointer index of a pointer can change from one event to the next but the pointer id of a pointer is guaranteed to remain constant as long as the pointer remains active. Use the getPointerId(int) method to obtain the pointer id of a pointer to track it across all subsequent motion events in a gesture. Then for successive motion events, use the findPointerIndex(int) method to obtain the pointer index for a given pointer id in that motion event. </para> <para>Mouse and stylus buttons can be retrieved using getButtonState(). It is a good idea to check the button state while handling ACTION_DOWN as part of a touch event. The application may choose to perform some different action if the touch event starts due to a secondary button click, such as presenting a context menu. </para> <para> <h3>Batching</h3></para> <para>For efficiency, motion events with ACTION_MOVE may batch together multiple movement samples within a single object. The most current pointer coordinates are available using getX(int) and getY(int). Earlier coordinates within the batch are accessed using getHistoricalX(int, int) and getHistoricalY(int, int). The coordinates are "historical" only insofar as they are older than the current coordinates in the batch; however, they are still distinct from any other coordinates reported in prior motion events. To process all coordinates in the batch in time order, first consume the historical coordinates then consume the current coordinates. </para> <para>Example: Consuming all samples for all pointers in a motion event in time order. </para> <para> <pre> <code>
		/// void printSamples(MotionEvent ev) {
		///     final int historySize = ev.getHistorySize();
		///     final int pointerCount = ev.getPointerCount();
		///     for (int h = 0; h &lt; historySize; h++) {
		///         System.out.printf("At time %d:", ev.getHistoricalEventTime(h));
		///         for (int p = 0; p &lt; pointerCount; p++) {
		///             System.out.printf("  pointer %d: (%f,%f)",
		///                 ev.getPointerId(p), ev.getHistoricalX(p, h), ev.getHistoricalY(p, h));
		///         }
		///     }
		///     System.out.printf("At time %d:", ev.getEventTime());
		///     for (int p = 0; p &lt; pointerCount; p++) {
		///         System.out.printf("  pointer %d: (%f,%f)",
		///             ev.getPointerId(p), ev.getX(p), ev.getY(p));
		///     }
		/// }
		/// </code></pre></para> <para> <h3>Device Types</h3></para> <para>The interpretation of the contents of a MotionEvent varies significantly depending on the source class of the device. </para> <para>On pointing devices with source class InputDevice#SOURCE_CLASS_POINTER such as touch screens, the pointer coordinates specify absolute positions such as view X/Y coordinates. Each complete gesture is represented by a sequence of motion events with actions that describe pointer state transitions and movements. A gesture starts with a motion event with ACTION_DOWN that provides the location of the first pointer down. As each additional pointer that goes down or up, the framework will generate a motion event with ACTION_POINTER_DOWN or ACTION_POINTER_UP accordingly. Pointer movements are described by motion events with ACTION_MOVE. Finally, a gesture end either when the final pointer goes up as represented by a motion event with ACTION_UP or when gesture is canceled with ACTION_CANCEL. </para> <para>Some pointing devices such as mice may support vertical and/or horizontal scrolling. A scroll event is reported as a generic motion event with ACTION_SCROLL that includes the relative scroll offset in the AXIS_VSCROLL and AXIS_HSCROLL axes. See getAxisValue(int) for information about retrieving these additional axes. </para> <para>On trackball devices with source class InputDevice#SOURCE_CLASS_TRACKBALL, the pointer coordinates specify relative movements as X/Y deltas. A trackball gesture consists of a sequence of movements described by motion events with ACTION_MOVE interspersed with occasional ACTION_DOWN or ACTION_UP motion events when the trackball button is pressed or released. </para> <para>On joystick devices with source class InputDevice#SOURCE_CLASS_JOYSTICK, the pointer coordinates specify the absolute position of the joystick axes. The joystick axis values are normalized to a range of -1.0 to 1.0 where 0.0 corresponds to the center position. More information about the set of available axes and the range of motion can be obtained using InputDevice#getMotionRange. Some common joystick axes are AXIS_X, AXIS_Y, AXIS_HAT_X, AXIS_HAT_Y, AXIS_Z and AXIS_RZ. </para> <para>Refer to InputDevice for more information about how different kinds of input devices and sources represent pointer coordinates. </para> <para> <h3>Consistency Guarantees</h3></para> <para>Motion events are always delivered to views as a consistent stream of events. What constitutes a consistent stream varies depending on the type of device. For touch events, consistency implies that pointers go down one at a time, move around as a group and then go up one at a time or are canceled. </para> <para>While the framework tries to deliver consistent streams of motion events to views, it cannot guarantee it. Some events may be dropped or modified by containing views in the application before they are delivered thereby making the stream of events inconsistent. Views should always be prepared to handle ACTION_CANCEL and should tolerate anomalous situations such as receiving a new ACTION_DOWN without first having received an ACTION_UP for the prior gesture. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/MotionEvent
		/// </java-name>
		[Dot42.DexImport("android/view/MotionEvent", AccessFlags = 49)]
		public sealed partial class MotionEvent : global::Android.Views.InputEvent, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Bit mask of the parts of the action code that are the action itself. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MASK
				/// </java-name>
				[Dot42.DexImport("ACTION_MASK", "I", AccessFlags = 25)]
				public const int ACTION_MASK = 255;
				/// <summary>
				///  <para>Constant for getActionMasked: A pressed gesture has started, the motion contains the initial starting location. </para> <para>This is also a good time to check the button state to distinguish secondary and tertiary button clicks and handle them appropriately. Use getButtonState to retrieve the button state. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_DOWN = 0;
				/// <summary>
				///  <para>Constant for getActionMasked: A pressed gesture has finished, the motion contains the final release location as well as any intermediate points since the last down or move event. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_UP", "I", AccessFlags = 25)]
				public const int ACTION_UP = 1;
				/// <summary>
				///  <para>Constant for getActionMasked: A change has happened during a press gesture (between ACTION_DOWN and ACTION_UP). The motion contains the most recent point, as well as any intermediate points since the last down or move event. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_MOVE
				/// </java-name>
				[Dot42.DexImport("ACTION_MOVE", "I", AccessFlags = 25)]
				public const int ACTION_MOVE = 2;
				/// <summary>
				///  <para>Constant for getActionMasked: The current gesture has been aborted. You will not receive any more points in it. You should treat this as an up event, but not perform any action that you normally would. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CANCEL
				/// </java-name>
				[Dot42.DexImport("ACTION_CANCEL", "I", AccessFlags = 25)]
				public const int ACTION_CANCEL = 3;
				/// <summary>
				///  <para>Constant for getActionMasked: A movement has happened outside of the normal bounds of the UI element. This does not provide a full gesture, but only the initial location of the movement/touch. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_OUTSIDE
				/// </java-name>
				[Dot42.DexImport("ACTION_OUTSIDE", "I", AccessFlags = 25)]
				public const int ACTION_OUTSIDE = 4;
				/// <summary>
				///  <para>Constant for getActionMasked: A non-primary pointer has gone down. </para> <para>Use getActionIndex to retrieve the index of the pointer that changed. </para> <para>The index is encoded in the ACTION_POINTER_INDEX_MASK bits of the unmasked action returned by getAction. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_DOWN = 5;
				/// <summary>
				///  <para>Constant for getActionMasked: A non-primary pointer has gone up. </para> <para>Use getActionIndex to retrieve the index of the pointer that changed. </para> <para>The index is encoded in the ACTION_POINTER_INDEX_MASK bits of the unmasked action returned by getAction. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_UP", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_UP = 6;
				/// <summary>
				///  <para>Bits in the action code that represent a pointer index, used with ACTION_POINTER_DOWN and ACTION_POINTER_UP. Shifting down by ACTION_POINTER_INDEX_SHIFT provides the actual pointer index where the data for the pointer going up or down can be found; you can get its identifier with getPointerId(int) and the actual data with getX(int) etc.</para> <para> <para>getActionIndex </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_INDEX_MASK
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_INDEX_MASK", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_INDEX_MASK = 65280;
				/// <summary>
				///  <para>Bit shift for the action bits holding the pointer index as defined by ACTION_POINTER_INDEX_MASK.</para> <para> <para>getActionIndex </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_INDEX_SHIFT
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_INDEX_SHIFT", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_INDEX_SHIFT = 8;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ACTION_POINTER_INDEX_MASK to retrieve the data index associated with ACTION_POINTER_DOWN. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_1_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_1_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_1_DOWN = 5;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ACTION_POINTER_INDEX_MASK to retrieve the data index associated with ACTION_POINTER_DOWN. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_2_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_2_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_2_DOWN = 261;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ACTION_POINTER_INDEX_MASK to retrieve the data index associated with ACTION_POINTER_DOWN. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_3_DOWN
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_3_DOWN", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_3_DOWN = 517;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ACTION_POINTER_INDEX_MASK to retrieve the data index associated with ACTION_POINTER_UP. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_1_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_1_UP", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_1_UP = 6;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ACTION_POINTER_INDEX_MASK to retrieve the data index associated with ACTION_POINTER_UP. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_2_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_2_UP", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_2_UP = 262;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use ACTION_POINTER_INDEX_MASK to retrieve the data index associated with ACTION_POINTER_UP. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_3_UP
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_3_UP", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_3_UP = 518;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Renamed to ACTION_POINTER_INDEX_MASK to match the actual data contained in these bits. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_ID_MASK
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_ID_MASK", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_ID_MASK = 65280;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Renamed to ACTION_POINTER_INDEX_SHIFT to match the actual data contained in these bits. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_POINTER_ID_SHIFT
				/// </java-name>
				[Dot42.DexImport("ACTION_POINTER_ID_SHIFT", "I", AccessFlags = 25)]
				public const int ACTION_POINTER_ID_SHIFT = 8;
				/// <summary>
				///  <para>This flag indicates that the window that received this motion event is partly or wholly obscured by another visible window above it. This flag is set to true even if the event did not directly pass through the obscured area. A security sensitive application can check this flag to identify situations in which a malicious application may have covered up part of its content for the purpose of misleading the user or hijacking touches. An appropriate response might be to drop the suspect touches or to take additional precautions to confirm the user's actual intent. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_WINDOW_IS_OBSCURED
				/// </java-name>
				[Dot42.DexImport("FLAG_WINDOW_IS_OBSCURED", "I", AccessFlags = 25)]
				public const int FLAG_WINDOW_IS_OBSCURED = 1;
				/// <summary>
				///  <para>Flag indicating the motion event intersected the top edge of the screen. </para>        
				/// </summary>
				/// <java-name>
				/// EDGE_TOP
				/// </java-name>
				[Dot42.DexImport("EDGE_TOP", "I", AccessFlags = 25)]
				public const int EDGE_TOP = 1;
				/// <summary>
				///  <para>Flag indicating the motion event intersected the bottom edge of the screen. </para>        
				/// </summary>
				/// <java-name>
				/// EDGE_BOTTOM
				/// </java-name>
				[Dot42.DexImport("EDGE_BOTTOM", "I", AccessFlags = 25)]
				public const int EDGE_BOTTOM = 2;
				/// <summary>
				///  <para>Flag indicating the motion event intersected the left edge of the screen. </para>        
				/// </summary>
				/// <java-name>
				/// EDGE_LEFT
				/// </java-name>
				[Dot42.DexImport("EDGE_LEFT", "I", AccessFlags = 25)]
				public const int EDGE_LEFT = 4;
				/// <summary>
				///  <para>Flag indicating the motion event intersected the right edge of the screen. </para>        
				/// </summary>
				/// <java-name>
				/// EDGE_RIGHT
				/// </java-name>
				[Dot42.DexImport("EDGE_RIGHT", "I", AccessFlags = 25)]
				public const int EDGE_RIGHT = 8;
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
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(JJII[I[Landroid/view/MotionEvent$PointerCoords;IFFIIII)Landroid/view/MotionEvent" +
    ";", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(long int64, long int641, int int32, int int321, int[] int322, global::Android.Views.MotionEvent.PointerCoords[] pointerCoords, int int323, float single, float single1, int int324, int int325, int int326, int int327) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <summary>
				///  <para>Create a new MotionEvent, filling in all of the basic values that define the motion.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(JJIFFFFIFFII)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(long downTime, long eventTime, int action, float x, float y, float pressure, float size, int metaState, float xPrecision, float yPrecision, int deviceId, int edgeFlags) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Create a new MotionEvent, filling in a subset of the basic motion values. Those not specified here are: device id (always 0), pressure and size (always 1), x and y precision (always 1), and edgeFlags (always 0).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(JJIFFI)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(long downTime, long eventTime, int action, float x, float y, int metaState) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <summary>
				///  <para>Create a new MotionEvent, copying from an existing one. </para>        
				/// </summary>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent Obtain(global::Android.Views.MotionEvent other) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <summary>
				///  <para>Create a new MotionEvent, copying from an existing one, but not including any historical point information. </para>        
				/// </summary>
				/// <java-name>
				/// obtainNoHistory
				/// </java-name>
				[Dot42.DexImport("obtainNoHistory", "(Landroid/view/MotionEvent;)Landroid/view/MotionEvent;", AccessFlags = 9)]
				public static global::Android.Views.MotionEvent ObtainNoHistory(global::Android.Views.MotionEvent other) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.MotionEvent);
				}

				/// <summary>
				///  <para>Recycle the MotionEvent, to be re-used by a later caller. After calling this function you must not ever touch the event again. </para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 17)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the pointer identifier associated with a particular pointer data index is this event. The identifier tells you the actual pointer number associated with the data, accounting for individual pointers going up and down since the start of the current gesture. </para>        
				/// </summary>
				/// <java-name>
				/// getPointerId
				/// </java-name>
				[Dot42.DexImport("getPointerId", "(I)I", AccessFlags = 17)]
				public int GetPointerId(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Given a pointer identifier, find the index of its data in the event.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns either the index of the pointer (for use with getX(int) et al.), or -1 if there is no data available for that pointer identifier. </para>
				/// </returns>
				/// <java-name>
				/// findPointerIndex
				/// </java-name>
				[Dot42.DexImport("findPointerIndex", "(I)I", AccessFlags = 17)]
				public int FindPointerIndex(int pointerId) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the X coordinate of this event for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index). Whole numbers are pixels; the value may have a fraction for input devices that are sub-pixel precise.  <para>AXIS_X </para></para>        
				/// </summary>
				/// <java-name>
				/// getX
				/// </java-name>
				[Dot42.DexImport("getX", "(I)F", AccessFlags = 17)]
				public float GetX(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the Y coordinate of this event for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index). Whole numbers are pixels; the value may have a fraction for input devices that are sub-pixel precise.  <para>AXIS_Y </para></para>        
				/// </summary>
				/// <java-name>
				/// getY
				/// </java-name>
				[Dot42.DexImport("getY", "(I)F", AccessFlags = 17)]
				public float GetY(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the current pressure of this event for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index). The pressure generally ranges from 0 (no pressure at all) to 1 (normal pressure), however values higher than 1 may be generated depending on the calibration of the input device.  <para>AXIS_PRESSURE </para></para>        
				/// </summary>
				/// <java-name>
				/// getPressure
				/// </java-name>
				[Dot42.DexImport("getPressure", "(I)F", AccessFlags = 17)]
				public float GetPressure(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a scaled value of the approximate size for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index). This represents some approximation of the area of the screen being pressed; the actual value in pixels corresponding to the touch is normalized with the device specific range of values and scaled to a value between 0 and 1. The value of size can be used to determine fat touch events.  <para>AXIS_SIZE </para></para>        
				/// </summary>
				/// <java-name>
				/// getSize
				/// </java-name>
				[Dot42.DexImport("getSize", "(I)F", AccessFlags = 17)]
				public float GetSize(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the length of the major axis of an ellipse that describes the touch area at the point of contact for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index).  <para>AXIS_TOUCH_MAJOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getTouchMajor
				/// </java-name>
				[Dot42.DexImport("getTouchMajor", "(I)F", AccessFlags = 17)]
				public float GetTouchMajor(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the length of the minor axis of an ellipse that describes the touch area at the point of contact for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index).  <para>AXIS_TOUCH_MINOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getTouchMinor
				/// </java-name>
				[Dot42.DexImport("getTouchMinor", "(I)F", AccessFlags = 17)]
				public float GetTouchMinor(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the length of the major axis of an ellipse that describes the size of the approaching tool for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index). The tool area represents the estimated size of the finger or pen that is touching the device independent of its actual touch area at the point of contact.  <para>AXIS_TOOL_MAJOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getToolMajor
				/// </java-name>
				[Dot42.DexImport("getToolMajor", "(I)F", AccessFlags = 17)]
				public float GetToolMajor(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the length of the minor axis of an ellipse that describes the size of the approaching tool for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index). The tool area represents the estimated size of the finger or pen that is touching the device independent of its actual touch area at the point of contact.  <para>AXIS_TOOL_MINOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getToolMinor
				/// </java-name>
				[Dot42.DexImport("getToolMinor", "(I)F", AccessFlags = 17)]
				public float GetToolMinor(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns the orientation of the touch area and tool area in radians clockwise from vertical for the given pointer  <b>index</b> (use getPointerId(int) to find the pointer identifier for this index). An angle of 0 radians indicates that the major axis of contact is oriented upwards, is perfectly circular or is of unknown orientation. A positive angle indicates that the major axis of contact is oriented to the right. A negative angle indicates that the major axis of contact is oriented to the left. The full range is from -PI/2 radians (finger pointing fully left) to PI/2 radians (finger pointing fully right).  <para>AXIS_ORIENTATION </para></para>        
				/// </summary>
				/// <java-name>
				/// getOrientation
				/// </java-name>
				[Dot42.DexImport("getOrientation", "(I)F", AccessFlags = 17)]
				public float GetOrientation(int pointerIndex) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Populates a PointerCoords object with pointer coordinate data for the specified pointer index.</para> <para> <para>PointerCoords </para></para>        
				/// </summary>
				/// <java-name>
				/// getPointerCoords
				/// </java-name>
				[Dot42.DexImport("getPointerCoords", "(ILandroid/view/MotionEvent$PointerCoords;)V", AccessFlags = 17)]
				public void GetPointerCoords(int pointerIndex, global::Android.Views.MotionEvent.PointerCoords outPointerCoords) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the time that a historical movement occurred between this event and the previous event, in the android.os.SystemClock#uptimeMillis time base. </para> <para>This only applies to ACTION_MOVE events. </para> <para> <para>getHistorySize </para> <para>getEventTime </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the time that a historical movement occurred between this event and the previous event, in the android.os.SystemClock#uptimeMillis time base.</para>
				/// </returns>
				/// <java-name>
				/// getHistoricalEventTime
				/// </java-name>
				[Dot42.DexImport("getHistoricalEventTime", "(I)J", AccessFlags = 17)]
				public long GetHistoricalEventTime(int pos) /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				///  <para>getHistoricalX(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getX() </para> <para>AXIS_X </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalX
				/// </java-name>
				[Dot42.DexImport("getHistoricalX", "(I)F", AccessFlags = 17)]
				public float GetHistoricalX(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>getHistoricalY(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getY() </para> <para>AXIS_Y </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalY
				/// </java-name>
				[Dot42.DexImport("getHistoricalY", "(I)F", AccessFlags = 17)]
				public float GetHistoricalY(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>getHistoricalPressure(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getPressure() </para> <para>AXIS_PRESSURE </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalPressure
				/// </java-name>
				[Dot42.DexImport("getHistoricalPressure", "(I)F", AccessFlags = 17)]
				public float GetHistoricalPressure(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>getHistoricalSize(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getSize() </para> <para>AXIS_SIZE </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalSize
				/// </java-name>
				[Dot42.DexImport("getHistoricalSize", "(I)F", AccessFlags = 17)]
				public float GetHistoricalSize(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>getHistoricalTouchMajor(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getTouchMajor() </para> <para>AXIS_TOUCH_MAJOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalTouchMajor
				/// </java-name>
				[Dot42.DexImport("getHistoricalTouchMajor", "(I)F", AccessFlags = 17)]
				public float GetHistoricalTouchMajor(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>getHistoricalTouchMinor(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getTouchMinor() </para> <para>AXIS_TOUCH_MINOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalTouchMinor
				/// </java-name>
				[Dot42.DexImport("getHistoricalTouchMinor", "(I)F", AccessFlags = 17)]
				public float GetHistoricalTouchMinor(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>getHistoricalToolMajor(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getToolMajor() </para> <para>AXIS_TOOL_MAJOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalToolMajor
				/// </java-name>
				[Dot42.DexImport("getHistoricalToolMajor", "(I)F", AccessFlags = 17)]
				public float GetHistoricalToolMajor(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>getHistoricalToolMinor(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getToolMinor() </para> <para>AXIS_TOOL_MINOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalToolMinor
				/// </java-name>
				[Dot42.DexImport("getHistoricalToolMinor", "(I)F", AccessFlags = 17)]
				public float GetHistoricalToolMinor(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>getHistoricalOrientation(int, int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>getHistorySize </para> <para>getOrientation() </para> <para>AXIS_ORIENTATION </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalOrientation
				/// </java-name>
				[Dot42.DexImport("getHistoricalOrientation", "(I)F", AccessFlags = 17)]
				public float GetHistoricalOrientation(int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical X coordinate, as per getX(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getX(int) </para> <para>AXIS_X </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalX
				/// </java-name>
				[Dot42.DexImport("getHistoricalX", "(II)F", AccessFlags = 17)]
				public float GetHistoricalX(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical Y coordinate, as per getY(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getY(int) </para> <para>AXIS_Y </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalY
				/// </java-name>
				[Dot42.DexImport("getHistoricalY", "(II)F", AccessFlags = 17)]
				public float GetHistoricalY(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical pressure coordinate, as per getPressure(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getPressure(int) </para> <para>AXIS_PRESSURE </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalPressure
				/// </java-name>
				[Dot42.DexImport("getHistoricalPressure", "(II)F", AccessFlags = 17)]
				public float GetHistoricalPressure(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical size coordinate, as per getSize(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getSize(int) </para> <para>AXIS_SIZE </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalSize
				/// </java-name>
				[Dot42.DexImport("getHistoricalSize", "(II)F", AccessFlags = 17)]
				public float GetHistoricalSize(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical touch major axis coordinate, as per getTouchMajor(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getTouchMajor(int) </para> <para>AXIS_TOUCH_MAJOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalTouchMajor
				/// </java-name>
				[Dot42.DexImport("getHistoricalTouchMajor", "(II)F", AccessFlags = 17)]
				public float GetHistoricalTouchMajor(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical touch minor axis coordinate, as per getTouchMinor(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getTouchMinor(int) </para> <para>AXIS_TOUCH_MINOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalTouchMinor
				/// </java-name>
				[Dot42.DexImport("getHistoricalTouchMinor", "(II)F", AccessFlags = 17)]
				public float GetHistoricalTouchMinor(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical tool major axis coordinate, as per getToolMajor(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getToolMajor(int) </para> <para>AXIS_TOOL_MAJOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalToolMajor
				/// </java-name>
				[Dot42.DexImport("getHistoricalToolMajor", "(II)F", AccessFlags = 17)]
				public float GetHistoricalToolMajor(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical tool minor axis coordinate, as per getToolMinor(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getToolMinor(int) </para> <para>AXIS_TOOL_MINOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalToolMinor
				/// </java-name>
				[Dot42.DexImport("getHistoricalToolMinor", "(II)F", AccessFlags = 17)]
				public float GetHistoricalToolMinor(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Returns a historical orientation coordinate, as per getOrientation(int), that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getOrientation(int) </para> <para>AXIS_ORIENTATION </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalOrientation
				/// </java-name>
				[Dot42.DexImport("getHistoricalOrientation", "(II)F", AccessFlags = 17)]
				public float GetHistoricalOrientation(int pointerIndex, int pos) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Populates a PointerCoords object with historical pointer coordinate data, as per getPointerCoords, that occurred between this event and the previous event for the given pointer. Only applies to ACTION_MOVE events.</para> <para> <para>getHistorySize </para> <para>getPointerCoords </para> <para>PointerCoords </para></para>        
				/// </summary>
				/// <java-name>
				/// getHistoricalPointerCoords
				/// </java-name>
				[Dot42.DexImport("getHistoricalPointerCoords", "(IILandroid/view/MotionEvent$PointerCoords;)V", AccessFlags = 17)]
				public void GetHistoricalPointerCoords(int pointerIndex, int pos, global::Android.Views.MotionEvent.PointerCoords outPointerCoords) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adjust this event's location. </para>        
				/// </summary>
				/// <java-name>
				/// offsetLocation
				/// </java-name>
				[Dot42.DexImport("offsetLocation", "(FF)V", AccessFlags = 17)]
				public void OffsetLocation(float deltaX, float deltaY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set this event's location. Applies offsetLocation with a delta from the current location to the given new location.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setLocation
				/// </java-name>
				[Dot42.DexImport("setLocation", "(FF)V", AccessFlags = 17)]
				public void SetLocation(float x, float y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a new movement to the batch of movements in this event. The event's current location, position and size is updated to the new values. The current values in the event are added to a list of historical values.</para> <para>Only applies to ACTION_MOVE or ACTION_HOVER_MOVE events.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addBatch
				/// </java-name>
				[Dot42.DexImport("addBatch", "(JFFFFI)V", AccessFlags = 17)]
				public void AddBatch(long eventTime, float x, float y, float pressure, float size, int metaState) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a new movement to the batch of movements in this event. The event's current location, position and size is updated to the new values. The current values in the event are added to a list of historical values.</para> <para>Only applies to ACTION_MOVE or ACTION_HOVER_MOVE events.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addBatch
				/// </java-name>
				[Dot42.DexImport("addBatch", "(J[Landroid/view/MotionEvent$PointerCoords;I)V", AccessFlags = 17)]
				public void AddBatch(long eventTime, global::Android.Views.MotionEvent.PointerCoords[] pointerCoords, int metaState) /* MethodBuilder.Create */ 
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
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public override void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("android/os/Parcelable", "describeContents", "()I", AccessFlags = 1025)]
				public override int DescribeContents() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Return the kind of action being performed. Consider using getActionMasked and getActionIndex to retrieve the separate masked action and pointer index. </para>        
				/// </summary>
				/// <returns>
				///  <para>The action, such as ACTION_DOWN or the combination of ACTION_POINTER_DOWN with a shifted pointer index. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Return the masked action being performed, without pointer index information. Use getActionIndex to return the index associated with pointer actions. </para>        
				/// </summary>
				/// <returns>
				///  <para>The action, such as ACTION_DOWN or ACTION_POINTER_DOWN. </para>
				/// </returns>
				/// <java-name>
				/// getActionMasked
				/// </java-name>
				public int ActionMasked
				{
						[Dot42.DexImport("getActionMasked", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>For ACTION_POINTER_DOWN or ACTION_POINTER_UP as returned by getActionMasked, this returns the associated pointer index. The index may be used with getPointerId(int), getX(int), getY(int), getPressure(int), and getSize(int) to get information about the pointer that has gone down or up. </para>        
				/// </summary>
				/// <returns>
				///  <para>The index associated with the action. </para>
				/// </returns>
				/// <java-name>
				/// getActionIndex
				/// </java-name>
				public int ActionIndex
				{
						[Dot42.DexImport("getActionIndex", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Gets the motion event flags.</para> <para> <para>FLAG_WINDOW_IS_OBSCURED </para></para>        
				/// </summary>
				/// <java-name>
				/// getFlags
				/// </java-name>
				public int Flags
				{
						[Dot42.DexImport("getFlags", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the time (in ms) when the user originally pressed down to start a stream of position events. </para>        
				/// </summary>
				/// <java-name>
				/// getDownTime
				/// </java-name>
				public long DownTime
				{
						[Dot42.DexImport("getDownTime", "()J", AccessFlags = 17)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Retrieve the time this event occurred, in the android.os.SystemClock#uptimeMillis time base.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the time this event occurred, in the android.os.SystemClock#uptimeMillis time base. </para>
				/// </returns>
				/// <java-name>
				/// getEventTime
				/// </java-name>
				public long EventTime
				{
						[Dot42.DexImport("getEventTime", "()J", AccessFlags = 17)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>getX(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_X </para></para>        
				/// </summary>
				/// <java-name>
				/// getX
				/// </java-name>
				public float X
				{
						[Dot42.DexImport("getX", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>getY(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_Y </para></para>        
				/// </summary>
				/// <java-name>
				/// getY
				/// </java-name>
				public float Y
				{
						[Dot42.DexImport("getY", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>getPressure(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_PRESSURE </para></para>        
				/// </summary>
				/// <java-name>
				/// getPressure
				/// </java-name>
				public float Pressure
				{
						[Dot42.DexImport("getPressure", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>getSize(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_SIZE </para></para>        
				/// </summary>
				/// <java-name>
				/// getSize
				/// </java-name>
				public float Size
				{
						[Dot42.DexImport("getSize", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>getTouchMajor(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_TOUCH_MAJOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getTouchMajor
				/// </java-name>
				public float TouchMajor
				{
						[Dot42.DexImport("getTouchMajor", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>getTouchMinor(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_TOUCH_MINOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getTouchMinor
				/// </java-name>
				public float TouchMinor
				{
						[Dot42.DexImport("getTouchMinor", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>getToolMajor(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_TOOL_MAJOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getToolMajor
				/// </java-name>
				public float ToolMajor
				{
						[Dot42.DexImport("getToolMajor", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>getToolMinor(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_TOOL_MINOR </para></para>        
				/// </summary>
				/// <java-name>
				/// getToolMinor
				/// </java-name>
				public float ToolMinor
				{
						[Dot42.DexImport("getToolMinor", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>getOrientation(int) for the first pointer index (may be an arbitrary pointer identifier).</para> <para> <para>AXIS_ORIENTATION </para></para>        
				/// </summary>
				/// <java-name>
				/// getOrientation
				/// </java-name>
				public float Orientation
				{
						[Dot42.DexImport("getOrientation", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>The number of pointers of data contained in this event. Always &gt;= 1. </para>        
				/// </summary>
				/// <java-name>
				/// getPointerCount
				/// </java-name>
				public int PointerCount
				{
						[Dot42.DexImport("getPointerCount", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the state of any meta / modifier keys that were in effect when the event was generated. This is the same values as those returned by KeyEvent.getMetaState.</para> <para> <para>KeyEvent::getMetaState() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>an integer in which each bit set to 1 represents a pressed meta key</para>
				/// </returns>
				/// <java-name>
				/// getMetaState
				/// </java-name>
				public int MetaState
				{
						[Dot42.DexImport("getMetaState", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the original raw X coordinate of this event. For touch events on the screen, this is the original location of the event on the screen, before it had been adjusted for the containing window and views.</para> <para> <para>getX(int) </para> <para>AXIS_X </para></para>        
				/// </summary>
				/// <java-name>
				/// getRawX
				/// </java-name>
				public float RawX
				{
						[Dot42.DexImport("getRawX", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Returns the original raw Y coordinate of this event. For touch events on the screen, this is the original location of the event on the screen, before it had been adjusted for the containing window and views.</para> <para> <para>getY(int) </para> <para>AXIS_Y </para></para>        
				/// </summary>
				/// <java-name>
				/// getRawY
				/// </java-name>
				public float RawY
				{
						[Dot42.DexImport("getRawY", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the precision of the X coordinates being reported. You can multiply this number with getX to find the actual hardware value of the X coordinate.  <para>AXIS_X </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the precision of X coordinates being reported.</para>
				/// </returns>
				/// <java-name>
				/// getXPrecision
				/// </java-name>
				public float XPrecision
				{
						[Dot42.DexImport("getXPrecision", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the precision of the Y coordinates being reported. You can multiply this number with getY to find the actual hardware value of the Y coordinate.  <para>AXIS_Y </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the precision of Y coordinates being reported.</para>
				/// </returns>
				/// <java-name>
				/// getYPrecision
				/// </java-name>
				public float YPrecision
				{
						[Dot42.DexImport("getYPrecision", "()F", AccessFlags = 17)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Returns the number of historical points in this event. These are movements that have occurred between this event and the previous event. This only applies to ACTION_MOVE events  all other actions will have a size of 0.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the number of historical points in the event. </para>
				/// </returns>
				/// <java-name>
				/// getHistorySize
				/// </java-name>
				public int HistorySize
				{
						[Dot42.DexImport("getHistorySize", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns a bitfield indicating which edges, if any, were touched by this MotionEvent. For touch events, clients can use this to determine if the user's finger was touching the edge of the display.</para> <para>This property is only set for ACTION_DOWN events.</para> <para> <para>EDGE_LEFT </para> <para>EDGE_TOP </para> <para>EDGE_RIGHT </para> <para>EDGE_BOTTOM </para></para>        
				/// </summary>
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

				/// <summary>
				///  <para>Transfer object for pointer coordinates.</para> <para>Objects of this type can be used to specify the pointer coordinates when creating new MotionEvent objects and to query pointer coordinates in bulk.</para> <para>Refer to InputDevice for information about how different kinds of input devices and sources represent pointer coordinates. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/MotionEvent$PointerCoords
				/// </java-name>
				[Dot42.DexImport("android/view/MotionEvent$PointerCoords", AccessFlags = 25)]
				public sealed partial class PointerCoords
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The X component of the pointer movement.</para> <para> <para>MotionEvent::AXIS_X </para></para>        
						/// </summary>
						/// <java-name>
						/// x
						/// </java-name>
						[Dot42.DexImport("x", "F", AccessFlags = 1)]
						public float X;
						/// <summary>
						///  <para>The Y component of the pointer movement.</para> <para> <para>MotionEvent::AXIS_Y </para></para>        
						/// </summary>
						/// <java-name>
						/// y
						/// </java-name>
						[Dot42.DexImport("y", "F", AccessFlags = 1)]
						public float Y;
						/// <summary>
						///  <para>A normalized value that describes the pressure applied to the device by a finger or other tool. The pressure generally ranges from 0 (no pressure at all) to 1 (normal pressure), although values higher than 1 may be generated depending on the calibration of the input device.</para> <para> <para>MotionEvent::AXIS_PRESSURE </para></para>        
						/// </summary>
						/// <java-name>
						/// pressure
						/// </java-name>
						[Dot42.DexImport("pressure", "F", AccessFlags = 1)]
						public float Pressure;
						/// <summary>
						///  <para>A normalized value that describes the approximate size of the pointer touch area in relation to the maximum detectable size of the device. It represents some approximation of the area of the screen being pressed; the actual value in pixels corresponding to the touch is normalized with the device specific range of values and scaled to a value between 0 and 1. The value of size can be used to determine fat touch events.</para> <para> <para>MotionEvent::AXIS_SIZE </para></para>        
						/// </summary>
						/// <java-name>
						/// size
						/// </java-name>
						[Dot42.DexImport("size", "F", AccessFlags = 1)]
						public float Size;
						/// <summary>
						///  <para>The length of the major axis of an ellipse that describes the touch area at the point of contact. If the device is a touch screen, the length is reported in pixels, otherwise it is reported in device-specific units.</para> <para> <para>MotionEvent::AXIS_TOUCH_MAJOR </para></para>        
						/// </summary>
						/// <java-name>
						/// touchMajor
						/// </java-name>
						[Dot42.DexImport("touchMajor", "F", AccessFlags = 1)]
						public float TouchMajor;
						/// <summary>
						///  <para>The length of the minor axis of an ellipse that describes the touch area at the point of contact. If the device is a touch screen, the length is reported in pixels, otherwise it is reported in device-specific units.</para> <para> <para>MotionEvent::AXIS_TOUCH_MINOR </para></para>        
						/// </summary>
						/// <java-name>
						/// touchMinor
						/// </java-name>
						[Dot42.DexImport("touchMinor", "F", AccessFlags = 1)]
						public float TouchMinor;
						/// <summary>
						///  <para>The length of the major axis of an ellipse that describes the size of the approaching tool. The tool area represents the estimated size of the finger or pen that is touching the device independent of its actual touch area at the point of contact. If the device is a touch screen, the length is reported in pixels, otherwise it is reported in device-specific units.</para> <para> <para>MotionEvent::AXIS_TOOL_MAJOR </para></para>        
						/// </summary>
						/// <java-name>
						/// toolMajor
						/// </java-name>
						[Dot42.DexImport("toolMajor", "F", AccessFlags = 1)]
						public float ToolMajor;
						/// <summary>
						///  <para>The length of the minor axis of an ellipse that describes the size of the approaching tool. The tool area represents the estimated size of the finger or pen that is touching the device independent of its actual touch area at the point of contact. If the device is a touch screen, the length is reported in pixels, otherwise it is reported in device-specific units.</para> <para> <para>MotionEvent::AXIS_TOOL_MINOR </para></para>        
						/// </summary>
						/// <java-name>
						/// toolMinor
						/// </java-name>
						[Dot42.DexImport("toolMinor", "F", AccessFlags = 1)]
						public float ToolMinor;
						/// <summary>
						///  <para>The orientation of the touch area and tool area in radians clockwise from vertical. An angle of 0 radians indicates that the major axis of contact is oriented upwards, is perfectly circular or is of unknown orientation. A positive angle indicates that the major axis of contact is oriented to the right. A negative angle indicates that the major axis of contact is oriented to the left. The full range is from -PI/2 radians (finger pointing fully left) to PI/2 radians (finger pointing fully right).</para> <para> <para>MotionEvent::AXIS_ORIENTATION </para></para>        
						/// </summary>
						/// <java-name>
						/// orientation
						/// </java-name>
						[Dot42.DexImport("orientation", "F", AccessFlags = 1)]
						public float Orientation;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public PointerCoords() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <summary>
		///  <para>Helper class for receiving notifications from the SensorManager when the orientation of the device has changed. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/OrientationEventListener
		/// </java-name>
		[Dot42.DexImport("android/view/OrientationEventListener", AccessFlags = 1057)]
		public abstract partial class OrientationEventListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returned from onOrientationChanged when the device orientation cannot be determined (typically when the device is in a close to flat position).</para> <para> <para>onOrientationChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// ORIENTATION_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_UNKNOWN", "I", AccessFlags = 25)]
				public const int ORIENTATION_UNKNOWN = -1;
				/// <summary>
				///  <para>Creates a new OrientationEventListener.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public OrientationEventListener(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new OrientationEventListener.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public OrientationEventListener(global::Android.Content.Context context, int rate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables the OrientationEventListener so it will monitor the sensor and call onOrientationChanged when the device orientation changes. </para>        
				/// </summary>
				/// <java-name>
				/// enable
				/// </java-name>
				[Dot42.DexImport("enable", "()V", AccessFlags = 1)]
				public virtual void Enable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Disables the OrientationEventListener. </para>        
				/// </summary>
				/// <java-name>
				/// disable
				/// </java-name>
				[Dot42.DexImport("disable", "()V", AccessFlags = 1)]
				public virtual void Disable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the orientation of the device has changed. orientation parameter is in degrees, ranging from 0 to 359. orientation is 0 degrees when the device is oriented in its natural position, 90 degrees when its left side is at the top, 180 degrees when it is upside down, and 270 degrees when its right side is to the top. ORIENTATION_UNKNOWN is returned when the device is close to flat and the orientation cannot be determined.</para> <para> <para>ORIENTATION_UNKNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// onOrientationChanged
				/// </java-name>
				[Dot42.DexImport("onOrientationChanged", "(I)V", AccessFlags = 1025)]
				public abstract void OnOrientationChanged(int orientation) /* MethodBuilder.Create */ ;

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

		/// <summary>
		///  <para>Helper class for receiving notifications from the SensorManager when the orientation of the device has changed.  <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use android.view.OrientationEventListener instead. This class internally uses the OrientationEventListener. </para></xrefdescription></xrefsect></para>    
		/// </summary>
		/// <java-name>
		/// android/view/OrientationListener
		/// </java-name>
		[Dot42.DexImport("android/view/OrientationListener", AccessFlags = 1057)]
		public abstract partial class OrientationListener : global::Android.Hardware.ISensorListener
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Returned from onOrientationChanged when the device orientation cannot be determined (typically when the device is in a close to flat position).</para> <para> <para>onOrientationChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// ORIENTATION_UNKNOWN
				/// </java-name>
				[Dot42.DexImport("ORIENTATION_UNKNOWN", "I", AccessFlags = 25)]
				public const int ORIENTATION_UNKNOWN = -1;
				/// <summary>
				///  <para>Creates a new OrientationListener.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public OrientationListener(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new OrientationListener.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public OrientationListener(global::Android.Content.Context context, int rate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables the OrientationListener so it will monitor the sensor and call onOrientationChanged when the device orientation changes. </para>        
				/// </summary>
				/// <java-name>
				/// enable
				/// </java-name>
				[Dot42.DexImport("enable", "()V", AccessFlags = 1)]
				public virtual void Enable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Disables the OrientationListener. </para>        
				/// </summary>
				/// <java-name>
				/// disable
				/// </java-name>
				[Dot42.DexImport("disable", "()V", AccessFlags = 1)]
				public virtual void Disable() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the accuracy of a sensor has changed. See SensorManager for details.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onAccuracyChanged
				/// </java-name>
				[Dot42.DexImport("onAccuracyChanged", "(II)V", AccessFlags = 1)]
				public virtual void OnAccuracyChanged(int sensor, int accuracy) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when sensor values have changed. The length and contents of the values array vary depending on which sensor is being monitored. See SensorManager for details on possible sensor types.</para> <para>&lt;u&gt;Definition of the coordinate system used below.&lt;/u&gt;</para> <para>The X axis refers to the screen's horizontal axis (the small edge in portrait mode, the long edge in landscape mode) and points to the right. </para> <para>The Y axis refers to the screen's vertical axis and points towards the top of the screen (the origin is in the lower-left corner). </para> <para>The Z axis points toward the sky when the device is lying on its back on a table. </para> <para> <b>IMPORTANT NOTE:</b> The axis  <b>&lt;u&gt;are swapped&lt;/u&gt;</b> when the device's screen orientation changes. To access the unswapped values, use indices 3, 4 and 5 in values[].</para> <para>SENSOR_ORIENTATION, SENSOR_ORIENTATION_RAW:</para> <para>All values are angles in degrees.</para> <para>values[0]: Azimuth, rotation around the Z axis (0&lt;=azimuth&lt;360). 0 = North, 90 = East, 180 = South, 270 = West</para> <para>values[1]: Pitch, rotation around X axis (-180&lt;=pitch&lt;=180), with positive values when the z-axis moves toward the y-axis.</para> <para>values[2]: Roll, rotation around Y axis (-90&lt;=roll&lt;=90), with positive values when the z-axis moves toward the x-axis.</para> <para>Note that this definition of yaw, pitch and roll is different from the traditional definition used in aviation where the X axis is along the long side of the plane (tail to nose).</para> <para>SENSOR_ACCELEROMETER:</para> <para>All values are in SI units (m/s^2) and measure contact forces.</para> <para>values[0]: force applied by the device on the x-axis </para> <para>values[1]: force applied by the device on the y-axis </para> <para>values[2]: force applied by the device on the z-axis</para> <para>&lt;u&gt;Examples&lt;/u&gt;: When the device is pushed on its left side toward the right, the x acceleration value is negative (the device applies a reaction force to the push toward the left)</para> <para>When the device lies flat on a table, the acceleration value is -STANDARD_GRAVITY, which correspond to the force the device applies on the table in reaction to gravity.</para> <para>SENSOR_MAGNETIC_FIELD:</para> <para>All values are in micro-Tesla (uT) and measure the ambient magnetic field in the X, Y and -Z axis. </para> <para> <b>&lt;u&gt;Note:&lt;/u&gt;</b> the magnetic field's Z axis is inverted.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onSensorChanged
				/// </java-name>
				[Dot42.DexImport("onSensorChanged", "(I[F)V", AccessFlags = 1)]
				public virtual void OnSensorChanged(int sensor, float[] values) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Look at android.view.OrientationEventListener#onOrientationChanged for method description and usage  <para>ORIENTATION_UNKNOWN </para></para>        
				/// </summary>
				/// <java-name>
				/// onOrientationChanged
				/// </java-name>
				[Dot42.DexImport("onOrientationChanged", "(I)V", AccessFlags = 1025)]
				public abstract void OnOrientationChanged(int orientation) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal OrientationListener() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Detects scaling transformation gestures using the supplied MotionEvents. The OnScaleGestureListener callback will notify users when a particular gesture event has occurred.</para> <para>This class should only be used with MotionEvents reported via touch.</para> <para>To use this class:  <ul> <li> <para>Create an instance of the <c>ScaleGestureDetector </c> for your View </para></li> <li> <para>In the View#onTouchEvent(MotionEvent) method ensure you call onTouchEvent(MotionEvent). The methods defined in your callback will be executed when the events occur. </para></li></ul></para>    
		/// </summary>
		/// <java-name>
		/// android/view/ScaleGestureDetector
		/// </java-name>
		[Dot42.DexImport("android/view/ScaleGestureDetector", AccessFlags = 33)]
		public partial class ScaleGestureDetector
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a ScaleGestureDetector with the supplied listener. You may only use this constructor from a Looper thread.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/view/ScaleGestureDetector$OnScaleGestureListen" +
    "er;)V", AccessFlags = 1)]
				public ScaleGestureDetector(global::Android.Content.Context context, global::Android.Views.ScaleGestureDetector.IOnScaleGestureListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Accepts MotionEvents and dispatches events to a OnScaleGestureListener when appropriate.</para> <para>Applications should pass a complete and consistent event stream to this method. A complete and consistent event stream involves all MotionEvents from the initial ACTION_DOWN to the final ACTION_UP or ACTION_CANCEL.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the event was processed and the detector wants to receive the rest of the MotionEvents in this event stream. </para>
				/// </returns>
				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ScaleGestureDetector() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns <c>true </c> if a scale gesture is in progress. </para>        
				/// </summary>
				/// <java-name>
				/// isInProgress
				/// </java-name>
				public virtual bool IsInProgress
				{
						[Dot42.DexImport("isInProgress", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Get the X coordinate of the current gesture's focal point. If a gesture is in progress, the focal point is between each of the pointers forming the gesture.</para> <para>If isInProgress() would return false, the result of this function is undefined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>X coordinate of the focal point in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getFocusX
				/// </java-name>
				public virtual float FocusX
				{
						[Dot42.DexImport("getFocusX", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Get the Y coordinate of the current gesture's focal point. If a gesture is in progress, the focal point is between each of the pointers forming the gesture.</para> <para>If isInProgress() would return false, the result of this function is undefined.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Y coordinate of the focal point in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getFocusY
				/// </java-name>
				public virtual float FocusY
				{
						[Dot42.DexImport("getFocusY", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the average distance between each of the pointers forming the gesture in progress through the focal point.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Distance between pointers in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentSpan
				/// </java-name>
				public virtual float CurrentSpan
				{
						[Dot42.DexImport("getCurrentSpan", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the previous average distance between each of the pointers forming the gesture in progress through the focal point.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Previous distance between pointers in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getPreviousSpan
				/// </java-name>
				public virtual float PreviousSpan
				{
						[Dot42.DexImport("getPreviousSpan", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the scaling factor from the previous scale event to the current event. This value is defined as (getCurrentSpan() / getPreviousSpan()).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current scaling factor. </para>
				/// </returns>
				/// <java-name>
				/// getScaleFactor
				/// </java-name>
				public virtual float ScaleFactor
				{
						[Dot42.DexImport("getScaleFactor", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Return the time difference in milliseconds between the previous accepted scaling event and the current scaling event.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Time difference since the last scaling event in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getTimeDelta
				/// </java-name>
				public virtual long TimeDelta
				{
						[Dot42.DexImport("getTimeDelta", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Return the event time of the current event being processed.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Current event time in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getEventTime
				/// </java-name>
				public virtual long EventTime
				{
						[Dot42.DexImport("getEventTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>A convenience class to extend when you only want to listen for a subset of scaling-related events. This implements all methods in OnScaleGestureListener but does nothing. OnScaleGestureListener#onScale(ScaleGestureDetector) returns  <c>false </c> so that a subclass can retrieve the accumulated scale factor in an overridden onScaleEnd. OnScaleGestureListener#onScaleBegin(ScaleGestureDetector) returns  <c>true </c> . </para>    
				/// </summary>
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

						/// <summary>
						///  <para>Responds to scaling events for a gesture in progress. Reported by pointer motion.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Whether or not the detector should consider this event as handled. If an event was not handled, the detector will continue to accumulate movement until an event is handled. This can be useful if an application, for example, only wants to update scaling factors if the change is greater than 0.01. </para>
						/// </returns>
						/// <java-name>
						/// onScale
						/// </java-name>
						[Dot42.DexImport("onScale", "(Landroid/view/ScaleGestureDetector;)Z", AccessFlags = 1)]
						public virtual bool OnScale(global::Android.Views.ScaleGestureDetector detector) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Responds to the beginning of a scaling gesture. Reported by new pointers going down.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Whether or not the detector should continue recognizing this gesture. For example, if a gesture is beginning with a focal point outside of a region where it makes sense, onScaleBegin() may return false to ignore the rest of the gesture. </para>
						/// </returns>
						/// <java-name>
						/// onScaleBegin
						/// </java-name>
						[Dot42.DexImport("onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", AccessFlags = 1)]
						public virtual bool OnScaleBegin(global::Android.Views.ScaleGestureDetector detector) /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <summary>
						///  <para>Responds to the end of a scale gesture. Reported by existing pointers going up.</para> <para>Once a scale has ended, ScaleGestureDetector#getFocusX() and ScaleGestureDetector#getFocusY() will return focal point of the pointers remaining on the screen.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onScaleEnd
						/// </java-name>
						[Dot42.DexImport("onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", AccessFlags = 1)]
						public virtual void OnScaleEnd(global::Android.Views.ScaleGestureDetector detector) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <summary>
				///  <para>The listener for receiving notifications when gestures occur. If you want to listen for all the different gestures then implement this interface. If you only want to listen for a subset it might be easier to extend SimpleOnScaleGestureListener.</para> <para>An application will receive events in the following order:  <ul> <li> <para>One OnScaleGestureListener#onScaleBegin(ScaleGestureDetector) </para></li> <li> <para>Zero or more OnScaleGestureListener#onScale(ScaleGestureDetector) </para></li> <li> <para>One OnScaleGestureListener#onScaleEnd(ScaleGestureDetector) </para></li></ul></para>    
				/// </summary>
				/// <java-name>
				/// android/view/ScaleGestureDetector$OnScaleGestureListener
				/// </java-name>
				[Dot42.DexImport("android/view/ScaleGestureDetector$OnScaleGestureListener", AccessFlags = 1545)]
				public partial interface IOnScaleGestureListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Responds to scaling events for a gesture in progress. Reported by pointer motion.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Whether or not the detector should consider this event as handled. If an event was not handled, the detector will continue to accumulate movement until an event is handled. This can be useful if an application, for example, only wants to update scaling factors if the change is greater than 0.01. </para>
						/// </returns>
						/// <java-name>
						/// onScale
						/// </java-name>
						[Dot42.DexImport("onScale", "(Landroid/view/ScaleGestureDetector;)Z", AccessFlags = 1025)]
						bool OnScale(global::Android.Views.ScaleGestureDetector detector) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Responds to the beginning of a scaling gesture. Reported by new pointers going down.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Whether or not the detector should continue recognizing this gesture. For example, if a gesture is beginning with a focal point outside of a region where it makes sense, onScaleBegin() may return false to ignore the rest of the gesture. </para>
						/// </returns>
						/// <java-name>
						/// onScaleBegin
						/// </java-name>
						[Dot42.DexImport("onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", AccessFlags = 1025)]
						bool OnScaleBegin(global::Android.Views.ScaleGestureDetector detector) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Responds to the end of a scale gesture. Reported by existing pointers going up.</para> <para>Once a scale has ended, ScaleGestureDetector#getFocusX() and ScaleGestureDetector#getFocusY() will return focal point of the pointers remaining on the screen.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onScaleEnd
						/// </java-name>
						[Dot42.DexImport("onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", AccessFlags = 1025)]
						void OnScaleEnd(global::Android.Views.ScaleGestureDetector detector) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Constants to be used to play sound effects via View#playSoundEffect(int) </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Get the sonification constant for the focus directions. </para>        
				/// </summary>
				/// <returns>
				///  <para>The appropriate sonification constant. </para>
				/// </returns>
				/// <java-name>
				/// getContantForFocusDirection
				/// </java-name>
				[Dot42.DexImport("getContantForFocusDirection", "(I)I", AccessFlags = 9)]
				public static int GetContantForFocusDirection(int direction) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

		}

		/// <summary>
		///  <para>Handle onto a raw buffer that is being managed by the screen compositor. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/Surface
		/// </java-name>
		[Dot42.DexImport("android/view/Surface", AccessFlags = 33)]
		public partial class Surface : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// HIDDEN
				/// </java-name>
				[Dot42.DexImport("HIDDEN", "I", AccessFlags = 25)]
				public const int HIDDEN = 4;
				/// <java-name>
				/// HARDWARE
				/// </java-name>
				[Dot42.DexImport("HARDWARE", "I", AccessFlags = 25)]
				public const int HARDWARE = 16;
				/// <java-name>
				/// GPU
				/// </java-name>
				[Dot42.DexImport("GPU", "I", AccessFlags = 25)]
				public const int GPU = 40;
				/// <java-name>
				/// SECURE
				/// </java-name>
				[Dot42.DexImport("SECURE", "I", AccessFlags = 25)]
				public const int SECURE = 128;
				/// <java-name>
				/// NON_PREMULTIPLIED
				/// </java-name>
				[Dot42.DexImport("NON_PREMULTIPLIED", "I", AccessFlags = 25)]
				public const int NON_PREMULTIPLIED = 256;
				/// <java-name>
				/// PUSH_BUFFERS
				/// </java-name>
				[Dot42.DexImport("PUSH_BUFFERS", "I", AccessFlags = 25)]
				public const int PUSH_BUFFERS = 512;
				/// <java-name>
				/// FX_SURFACE_NORMAL
				/// </java-name>
				[Dot42.DexImport("FX_SURFACE_NORMAL", "I", AccessFlags = 25)]
				public const int FX_SURFACE_NORMAL = 0;
				/// <java-name>
				/// FX_SURFACE_BLUR
				/// </java-name>
				[Dot42.DexImport("FX_SURFACE_BLUR", "I", AccessFlags = 25)]
				public const int FX_SURFACE_BLUR = 65536;
				/// <java-name>
				/// FX_SURFACE_DIM
				/// </java-name>
				[Dot42.DexImport("FX_SURFACE_DIM", "I", AccessFlags = 25)]
				public const int FX_SURFACE_DIM = 131072;
				/// <java-name>
				/// FX_SURFACE_MASK
				/// </java-name>
				[Dot42.DexImport("FX_SURFACE_MASK", "I", AccessFlags = 25)]
				public const int FX_SURFACE_MASK = 983040;
				/// <java-name>
				/// SURFACE_HIDDEN
				/// </java-name>
				[Dot42.DexImport("SURFACE_HIDDEN", "I", AccessFlags = 25)]
				public const int SURFACE_HIDDEN = 1;
				/// <java-name>
				/// SURFACE_FROZEN
				/// </java-name>
				[Dot42.DexImport("SURFACE_FROZEN", "I", AccessFlags = 25)]
				public const int SURFACE_FROZEN = 2;
				/// <java-name>
				/// SURACE_FROZEN
				/// </java-name>
				[Dot42.DexImport("SURACE_FROZEN", "I", AccessFlags = 25)]
				public const int SURACE_FROZEN = 2;
				/// <java-name>
				/// SURFACE_DITHER
				/// </java-name>
				[Dot42.DexImport("SURFACE_DITHER", "I", AccessFlags = 25)]
				public const int SURFACE_DITHER = 4;
				/// <java-name>
				/// SURFACE_BLUR_FREEZE
				/// </java-name>
				[Dot42.DexImport("SURFACE_BLUR_FREEZE", "I", AccessFlags = 25)]
				public const int SURFACE_BLUR_FREEZE = 16;
				/// <summary>
				///  <para>Rotation constant: 0 degree rotation (natural orientation) </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_0
				/// </java-name>
				[Dot42.DexImport("ROTATION_0", "I", AccessFlags = 25)]
				public const int ROTATION_0 = 0;
				/// <summary>
				///  <para>Rotation constant: 90 degree rotation. </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_90
				/// </java-name>
				[Dot42.DexImport("ROTATION_90", "I", AccessFlags = 25)]
				public const int ROTATION_90 = 1;
				/// <summary>
				///  <para>Rotation constant: 180 degree rotation. </para>        
				/// </summary>
				/// <java-name>
				/// ROTATION_180
				/// </java-name>
				[Dot42.DexImport("ROTATION_180", "I", AccessFlags = 25)]
				public const int ROTATION_180 = 2;
				/// <summary>
				///  <para>Rotation constant: 270 degree rotation. </para>        
				/// </summary>
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
				/// <summary>
				///  <para>Create an empty surface, which will later be filled in by readFromParcel().  </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal Surface() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gets a Canvas for drawing into this surface.</para> <para>After drawing into the provided Canvas, the caller must invoke unlockCanvasAndPost to post the new contents to the surface.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A canvas for drawing into the surface.</para>
				/// </returns>
				/// <java-name>
				/// lockCanvas
				/// </java-name>
				[Dot42.DexImport("lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Canvas LockCanvas(global::Android.Graphics.Rect inOutDirty) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Canvas);
				}

				/// <summary>
				///  <para>Posts the new contents of the Canvas to the surface and releases the Canvas.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unlockCanvasAndPost
				/// </java-name>
				[Dot42.DexImport("unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", AccessFlags = 257)]
				public virtual void UnlockCanvasAndPost(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This API has been removed and is not supported. Do not use. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// unlockCanvas
				/// </java-name>
				[Dot42.DexImport("unlockCanvas", "(Landroid/graphics/Canvas;)V", AccessFlags = 257)]
				public virtual void UnlockCanvas(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setOrientation
				/// </java-name>
				[Dot42.DexImport("setOrientation", "(II)V", AccessFlags = 9)]
				public static void SetOrientation(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLayer
				/// </java-name>
				[Dot42.DexImport("setLayer", "(I)V", AccessFlags = 257)]
				public virtual void SetLayer(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPosition
				/// </java-name>
				[Dot42.DexImport("setPosition", "(II)V", AccessFlags = 257)]
				public virtual void SetPosition(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSize
				/// </java-name>
				[Dot42.DexImport("setSize", "(II)V", AccessFlags = 257)]
				public virtual void SetSize(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// hide
				/// </java-name>
				[Dot42.DexImport("hide", "()V", AccessFlags = 257)]
				public virtual void Hide() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// show
				/// </java-name>
				[Dot42.DexImport("show", "()V", AccessFlags = 257)]
				public virtual void Show() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setTransparentRegionHint
				/// </java-name>
				[Dot42.DexImport("setTransparentRegionHint", "(Landroid/graphics/Region;)V", AccessFlags = 257)]
				public virtual void SetTransparentRegionHint(global::Android.Graphics.Region region) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAlpha
				/// </java-name>
				[Dot42.DexImport("setAlpha", "(F)V", AccessFlags = 257)]
				public virtual void SetAlpha(float single) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMatrix
				/// </java-name>
				[Dot42.DexImport("setMatrix", "(FFFF)V", AccessFlags = 257)]
				public virtual void SetMatrix(float single, float single1, float single2, float single3) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// freeze
				/// </java-name>
				[Dot42.DexImport("freeze", "()V", AccessFlags = 257)]
				public virtual void Freeze() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// unfreeze
				/// </java-name>
				[Dot42.DexImport("unfreeze", "()V", AccessFlags = 257)]
				public virtual void Unfreeze() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFreezeTint
				/// </java-name>
				[Dot42.DexImport("setFreezeTint", "(I)V", AccessFlags = 257)]
				public virtual void SetFreezeTint(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFlags
				/// </java-name>
				[Dot42.DexImport("setFlags", "(II)V", AccessFlags = 257)]
				public virtual void SetFlags(int int32, int int321) /* MethodBuilder.Create */ 
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
				///  <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable. </para>
				/// </returns>
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
				public virtual void ReadFromParcel(global::Android.OS.Parcel source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Flatten this object in to a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 257)]
				public virtual void WriteToParcel(global::Android.OS.Parcel dest, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// finalize
				/// </java-name>
				[Dot42.DexImport("finalize", "()V", AccessFlags = 4)]
				extern ~Surface() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Returns true if this object holds a valid surface.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if it holds a physical surface, so lockCanvas() will succeed. Otherwise returns false. </para>
				/// </returns>
				/// <java-name>
				/// isValid
				/// </java-name>
				public virtual bool IsValid
				{
						[Dot42.DexImport("isValid", "()Z", AccessFlags = 257)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Exception thrown when a Canvas couldn't be locked with Surface#lockCanvas, or when a SurfaceTexture could not successfully be allocated. </para>    
				/// </summary>
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

		/// <summary>
		///  <para>Provides a dedicated drawing surface embedded inside of a view hierarchy. You can control the format of this surface and, if you like, its size; the SurfaceView takes care of placing the surface at the correct location on the screen</para> <para>The surface is Z ordered so that it is behind the window holding its SurfaceView; the SurfaceView punches a hole in its window to allow its surface to be displayed. The view hierarchy will take care of correctly compositing with the Surface any siblings of the SurfaceView that would normally appear on top of it. This can be used to place overlays such as buttons on top of the Surface, though note however that it can have an impact on performance since a full alpha-blended composite will be performed each time the Surface changes.</para> <para>The transparent region that makes the surface visible is based on the layout positions in the view hierarchy. If the post-layout transform properties are used to draw a sibling view on top of the SurfaceView, the view may not be properly composited with the surface.</para> <para>Access to the underlying surface is provided via the SurfaceHolder interface, which can be retrieved by calling getHolder.</para> <para>The Surface will be created for you while the SurfaceView's window is visible; you should implement SurfaceHolder.Callback#surfaceCreated and SurfaceHolder.Callback#surfaceDestroyed to discover when the Surface is created and destroyed as the window is shown and hidden.</para> <para>One of the purposes of this class is to provide a surface in which a secondary thread can render into the screen. If you are going to use it this way, you need to be aware of some threading semantics:</para> <para> <ul> <li> <para>All SurfaceView and SurfaceHolder.Callback methods will be called from the thread running the SurfaceView's window (typically the main thread of the application). They thus need to correctly synchronize with any state that is also touched by the drawing thread. </para></li> <li> <para>You must ensure that the drawing thread only touches the underlying Surface while it is valid  between SurfaceHolder.Callback.surfaceCreated() and SurfaceHolder.Callback.surfaceDestroyed(). </para></li></ul></para>    
		/// </summary>
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
				public SurfaceView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public SurfaceView(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
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
				protected internal override void OnWindowVisibilityChanged(int visibility) /* MethodBuilder.Create */ 
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
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Control whether the surface view's surface is placed on top of another regular surface view in the window (but still behind the window itself). This is typically used to place overlays on top of an underlying media surface view.</para> <para>Note that this must be set before the surface view's containing window is attached to the window manager.</para> <para>Calling this overrides any previous call to setZOrderOnTop. </para>        
				/// </summary>
				/// <java-name>
				/// setZOrderMediaOverlay
				/// </java-name>
				[Dot42.DexImport("setZOrderMediaOverlay", "(Z)V", AccessFlags = 1)]
				public virtual void SetZOrderMediaOverlay(bool isMediaOverlay) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Control whether the surface view's surface is placed on top of its window. Normally it is placed behind the window, to allow it to (for the most part) appear to composite with the views in the hierarchy. By setting this, you cause it to be placed above the window. This means that none of the contents of the window this SurfaceView is in will be visible on top of its surface.</para> <para>Note that this must be set before the surface view's containing window is attached to the window manager.</para> <para>Calling this overrides any previous call to setZOrderMediaOverlay. </para>        
				/// </summary>
				/// <java-name>
				/// setZOrderOnTop
				/// </java-name>
				[Dot42.DexImport("setZOrderOnTop", "(Z)V", AccessFlags = 1)]
				public virtual void SetZOrderOnTop(bool onTop) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal SurfaceView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the SurfaceHolder providing access and control over this SurfaceView's underlying surface.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>SurfaceHolder The holder of the surface. </para>
				/// </returns>
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

		/// <summary>
		///  <para>Helper class to handle situations where you want a view to have a larger touch area than its actual view bounds. The view whose touch area is changed is called the delegate view. This class should be used by an ancestor of the delegate. To use a TouchDelegate, first create an instance that specifies the bounds that should be mapped to the delegate and the delegate view itself. </para> <para>The ancestor should then forward all of its touch events received in its android.view.View#onTouchEvent(MotionEvent) to onTouchEvent(MotionEvent). </para>    
		/// </summary>
		/// <java-name>
		/// android/view/TouchDelegate
		/// </java-name>
		[Dot42.DexImport("android/view/TouchDelegate", AccessFlags = 33)]
		public partial class TouchDelegate
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The touchable region of the View extends above its actual extent. </para>        
				/// </summary>
				/// <java-name>
				/// ABOVE
				/// </java-name>
				[Dot42.DexImport("ABOVE", "I", AccessFlags = 25)]
				public const int ABOVE = 1;
				/// <summary>
				///  <para>The touchable region of the View extends below its actual extent. </para>        
				/// </summary>
				/// <java-name>
				/// BELOW
				/// </java-name>
				[Dot42.DexImport("BELOW", "I", AccessFlags = 25)]
				public const int BELOW = 2;
				/// <summary>
				///  <para>The touchable region of the View extends to the left of its actual extent. </para>        
				/// </summary>
				/// <java-name>
				/// TO_LEFT
				/// </java-name>
				[Dot42.DexImport("TO_LEFT", "I", AccessFlags = 25)]
				public const int TO_LEFT = 4;
				/// <summary>
				///  <para>The touchable region of the View extends to the right of its actual extent. </para>        
				/// </summary>
				/// <java-name>
				/// TO_RIGHT
				/// </java-name>
				[Dot42.DexImport("TO_RIGHT", "I", AccessFlags = 25)]
				public const int TO_RIGHT = 8;
				/// <summary>
				///  <para>Constructor</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/graphics/Rect;Landroid/view/View;)V", AccessFlags = 1)]
				public TouchDelegate(global::Android.Graphics.Rect bounds, global::Android.Views.View delegateView) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Will forward touch events to the delegate view if the event is within the bounds specified in the constructor.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event was forwarded to the delegate, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TouchDelegate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Helper for tracking the velocity of touch events, for implementing flinging and other such gestures.</para> <para>Use obtain to retrieve a new instance of the class when you are going to begin tracking. Put the motion events you receive into it with addMovement(MotionEvent). When you want to determine the velocity call computeCurrentVelocity(int) and then call getXVelocity(int) and getYVelocity(int) to retrieve the velocity for each pointer id. </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Retrieve a new VelocityTracker object to watch the velocity of a motion. Be sure to call recycle when done. You should generally only maintain an active object while tracking a movement, so that the VelocityTracker can be re-used elsewhere.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a new VelocityTracker. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/VelocityTracker;", AccessFlags = 9)]
				public static global::Android.Views.VelocityTracker Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.VelocityTracker);
				}

				/// <summary>
				///  <para>Return a VelocityTracker object back to be re-used by others. You must not touch the object after calling this function. </para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Reset the velocity tracker back to its initial state. </para>        
				/// </summary>
				/// <java-name>
				/// clear
				/// </java-name>
				[Dot42.DexImport("clear", "()V", AccessFlags = 1)]
				public void Clear() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add a user's movement to the tracker. You should call this for the initial MotionEvent#ACTION_DOWN, the following MotionEvent#ACTION_MOVE events that you receive, and the final MotionEvent#ACTION_UP. You can, however, call this for whichever events you desire.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addMovement
				/// </java-name>
				[Dot42.DexImport("addMovement", "(Landroid/view/MotionEvent;)V", AccessFlags = 1)]
				public void AddMovement(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Equivalent to invoking computeCurrentVelocity(int, float) with a maximum velocity of Float.MAX_VALUE.</para> <para> <para>computeCurrentVelocity(int, float) </para></para>        
				/// </summary>
				/// <java-name>
				/// computeCurrentVelocity
				/// </java-name>
				[Dot42.DexImport("computeCurrentVelocity", "(I)V", AccessFlags = 1)]
				public void ComputeCurrentVelocity(int units) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compute the current velocity based on the points that have been collected. Only call this when you actually want to retrieve velocity information, as it is relatively expensive. You can then retrieve the velocity with getXVelocity() and getYVelocity().</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// computeCurrentVelocity
				/// </java-name>
				[Dot42.DexImport("computeCurrentVelocity", "(IF)V", AccessFlags = 1)]
				public void ComputeCurrentVelocity(int units, float maxVelocity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the last computed X velocity. You must first call computeCurrentVelocity(int) before calling this function.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The previously computed X velocity. </para>
				/// </returns>
				/// <java-name>
				/// getXVelocity
				/// </java-name>
				[Dot42.DexImport("getXVelocity", "(I)F", AccessFlags = 1)]
				public float GetXVelocity(int id) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Retrieve the last computed Y velocity. You must first call computeCurrentVelocity(int) before calling this function.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The previously computed Y velocity. </para>
				/// </returns>
				/// <java-name>
				/// getYVelocity
				/// </java-name>
				[Dot42.DexImport("getYVelocity", "(I)F", AccessFlags = 1)]
				public float GetYVelocity(int id) /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <summary>
				///  <para>Retrieve the last computed X velocity. You must first call computeCurrentVelocity(int) before calling this function.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The previously computed X velocity. </para>
				/// </returns>
				/// <java-name>
				/// getXVelocity
				/// </java-name>
				public float XVelocity
				{
						[Dot42.DexImport("getXVelocity", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Retrieve the last computed Y velocity. You must first call computeCurrentVelocity(int) before calling this function.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The previously computed Y velocity. </para>
				/// </returns>
				/// <java-name>
				/// getYVelocity
				/// </java-name>
				public float YVelocity
				{
						[Dot42.DexImport("getYVelocity", "()F", AccessFlags = 1)]
						get{ return default(float); }
				}

		}

		/// <summary>
		///  <para>This class represents the basic building block for user interface components. A View occupies a rectangular area on the screen and is responsible for drawing and event handling. View is the base class for  <b>widgets</b>, which are used to create interactive UI components (buttons, text fields, etc.). The android.view.ViewGroup subclass is the base class for  <b>layouts</b>, which are invisible containers that hold other Views (or other ViewGroups) and define their layout properties. </para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For information about using this class to develop your application's user interface, read the  developer guide. </para> <para>  <h3>Using Views</h3></para> <para>All of the views in a window are arranged in a single tree. You can add views either from code or by specifying a tree of views in one or more XML layout files. There are many specialized subclasses of views that act as controls or are capable of displaying text, images, or other content. </para> <para>Once you have created a tree of views, there are typically a few types of common operations you may wish to perform:  <ul> <li> <para> <b>Set properties:</b> for example setting the text of a android.widget.TextView. The available properties and the methods that set them will vary among the different subclasses of views. Note that properties that are known at build time can be set in the XML layout files. </para></li> <li> <para> <b>Set focus:</b> The framework will handled moving focus in response to user input. To force focus to a specific view, call requestFocus. </para></li> <li> <para> <b>Set up listeners:</b> Views allow clients to set listeners that will be notified when something interesting happens to the view. For example, all views will let you set a listener to be notified when the view gains or loses focus. You can register such a listener using setOnFocusChangeListener(android.view.View.OnFocusChangeListener). Other view subclasses offer more specialized listeners. For example, a Button exposes a listener to notify clients when the button is clicked. </para></li> <li> <para> <b>Set visibility:</b> You can hide or show views using setVisibility(int). </para></li></ul></para> <para> <b> Note: The Android framework is responsible for measuring, laying out and drawing views. You should not call methods that perform these actions on views yourself unless you are actually implementing a android.view.ViewGroup. </b></para> <para>  <h3>Implementing a Custom View</h3></para> <para>To implement a custom view, you will usually begin by providing overrides for some of the standard methods that the framework calls on all views. You do not need to override all of these methods. In fact, you can start by just overriding onDraw(android.graphics.Canvas).  <table></table></para> <para>Category </para> <para>Methods </para> <para>Description &lt;/thead&gt;</para> <para>&lt;tbody&gt; </para> <para>Creation </para> <para>Constructors </para> <para>There is a form of the constructor that are called when the view is created from code and a form that is called when the view is inflated from a layout file. The second form should parse and apply any attributes defined in the layout file.   </para> <para> <code>onFinishInflate()</code> </para> <para>Called after a view and all of its children has been inflated from XML. </para> <para>Layout </para> <para> <code>onMeasure(int, int)</code> </para> <para>Called to determine the size requirements for this view and all of its children.   </para> <para> <code>onLayout(boolean, int, int, int, int)</code> </para> <para>Called when this view should assign a size and position to all of its children.   </para> <para> <code>onSizeChanged(int, int, int, int)</code> </para> <para>Called when the size of this view has changed.  </para> <para>Drawing </para> <para> <code>onDraw(android.graphics.Canvas)</code> </para> <para>Called when the view should render its content.  </para> <para>Event processing </para> <para> <code>onKeyDown(int, KeyEvent)</code> </para> <para>Called when a new hardware key event occurs.   </para> <para> <code>onKeyUp(int, KeyEvent)</code> </para> <para>Called when a hardware key up event occurs.   </para> <para> <code>onTrackballEvent(MotionEvent)</code> </para> <para>Called when a trackball motion event occurs.   </para> <para> <code>onTouchEvent(MotionEvent)</code> </para> <para>Called when a touch screen motion event occurs.  </para> <para>Focus </para> <para> <code>onFocusChanged(boolean, int, android.graphics.Rect)</code> </para> <para>Called when the view gains or loses focus.  </para> <para> <code>onWindowFocusChanged(boolean)</code> </para> <para>Called when the window containing the view gains or loses focus.  </para> <para>Attaching </para> <para> <code>onAttachedToWindow()</code> </para> <para>Called when the view is attached to a window.  </para> <para> <code>onDetachedFromWindow</code> </para> <para>Called when the view is detached from its window.  </para> <para> <code>onWindowVisibilityChanged(int)</code> </para> <para>Called when the visibility of the window containing the view has changed.   &lt;/tbody&gt;</para> <para>  <h3>IDs</h3></para> <para>Views may have an integer id associated with them. These ids are typically assigned in the layout XML files, and are used to find specific views within the view tree. A common pattern is to:  <ul> <li> <para>Define a Button in the layout file and assign it a unique ID.  <pre>
		/// &lt;Button
		///     android:id="@+id/my_button"
		///     android:layout_width="wrap_content"
		///     android:layout_height="wrap_content"
		///     android:text="@string/my_button_text"/&gt;
		/// </pre> </para></li> <li> <para>From the onCreate method of an Activity, find the Button  <pre>
		///      Button myButton = (Button) findViewById(R.id.my_button);
		/// </pre> </para></li></ul></para> <para>View IDs need not be unique throughout the tree, but it is good practice to ensure that they are at least unique within the part of the tree you are searching. </para> <para>  <h3>Position</h3></para> <para>The geometry of a view is that of a rectangle. A view has a location, expressed as a pair of  <b>left</b> and  <b>top</b> coordinates, and two dimensions, expressed as a width and a height. The unit for location and dimensions is the pixel. </para> <para>It is possible to retrieve the location of a view by invoking the methods getLeft() and getTop(). The former returns the left, or X, coordinate of the rectangle representing the view. The latter returns the top, or Y, coordinate of the rectangle representing the view. These methods both return the location of the view relative to its parent. For instance, when getLeft() returns 20, that means the view is located 20 pixels to the right of the left edge of its direct parent. </para> <para>In addition, several convenience methods are offered to avoid unnecessary computations, namely getRight() and getBottom(). These methods return the coordinates of the right and bottom edges of the rectangle representing the view. For instance, calling getRight() is similar to the following computation:  <code>getLeft() + getWidth()</code> (see  for more information about the width.) </para> <para>  <h3>Size, padding and margins</h3></para> <para>The size of a view is expressed with a width and a height. A view actually possess two pairs of width and height values. </para> <para>The first pair is known as  <b>measured width</b> and  <b>measured height</b>. These dimensions define how big a view wants to be within its parent (see  for more details.) The measured dimensions can be obtained by calling getMeasuredWidth() and getMeasuredHeight(). </para> <para>The second pair is simply known as  <b>width</b> and  <b>height</b>, or sometimes  <b>drawing width</b> and  <b>drawing height</b>. These dimensions define the actual size of the view on screen, at drawing time and after layout. These values may, but do not have to, be different from the measured width and height. The width and height can be obtained by calling getWidth() and getHeight(). </para> <para>To measure its dimensions, a view takes into account its padding. The padding is expressed in pixels for the left, top, right and bottom parts of the view. Padding can be used to offset the content of the view by a specific amount of pixels. For instance, a left padding of 2 will push the view's content by 2 pixels to the right of the left edge. Padding can be set using the setPadding(int, int, int, int) or setPaddingRelative(int, int, int, int) method and queried by calling getPaddingLeft(), getPaddingTop(), getPaddingRight(), getPaddingBottom(), getPaddingStart(), getPaddingEnd(). </para> <para>Even though a view can define a padding, it does not provide any support for margins. However, view groups provide such a support. Refer to android.view.ViewGroup and android.view.ViewGroup.MarginLayoutParams for further information. </para> <para>  <h3>Layout</h3></para> <para>Layout is a two pass process: a measure pass and a layout pass. The measuring pass is implemented in measure(int, int) and is a top-down traversal of the view tree. Each view pushes dimension specifications down the tree during the recursion. At the end of the measure pass, every view has stored its measurements. The second pass happens in layout(int,int,int,int) and is also top-down. During this pass each parent is responsible for positioning all of its children using the sizes computed in the measure pass. </para> <para>When a view's measure() method returns, its getMeasuredWidth() and getMeasuredHeight() values must be set, along with those for all of that view's descendants. A view's measured width and measured height values must respect the constraints imposed by the view's parents. This guarantees that at the end of the measure pass, all parents accept all of their children's measurements. A parent view may call measure() more than once on its children. For example, the parent may measure each child once with unspecified dimensions to find out how big they want to be, then call measure() on them again with actual numbers if the sum of all the children's unconstrained sizes is too big or too small. </para> <para>The measure pass uses two classes to communicate dimensions. The MeasureSpec class is used by views to tell their parents how they want to be measured and positioned. The base LayoutParams class just describes how big the view wants to be for both width and height. For each dimension, it can specify one of:  <ul> <li> <para>an exact number </para></li> <li> <para>MATCH_PARENT, which means the view wants to be as big as its parent (minus padding) </para></li> <li> <para>WRAP_CONTENT, which means that the view wants to be just big enough to enclose its content (plus padding). </para></li></ul>There are subclasses of LayoutParams for different subclasses of ViewGroup. For example, AbsoluteLayout has its own subclass of LayoutParams which adds an X and Y value. </para> <para>MeasureSpecs are used to push requirements down the tree from parent to child. A MeasureSpec can be in one of three modes:  <ul> <li> <para>UNSPECIFIED: This is used by a parent to determine the desired dimension of a child view. For example, a LinearLayout may call measure() on its child with the height set to UNSPECIFIED and a width of EXACTLY 240 to find out how tall the child view wants to be given a width of 240 pixels. </para></li> <li> <para>EXACTLY: This is used by the parent to impose an exact size on the child. The child must use this size, and guarantee that all of its descendants will fit within this size. </para></li> <li> <para>AT_MOST: This is used by the parent to impose a maximum size on the child. The child must gurantee that it and all of its descendants will fit within this size. </para></li></ul></para> <para>To intiate a layout, call requestLayout. This method is typically called by a view on itself when it believes that is can no longer fit within its current bounds. </para> <para>  <h3>Drawing</h3></para> <para>Drawing is handled by walking the tree and rendering each view that intersects the invalid region. Because the tree is traversed in-order, this means that parents will draw before (i.e., behind) their children, with siblings drawn in the order they appear in the tree. If you set a background drawable for a View, then the View will draw it for you before calling back to its  <code>onDraw()</code> method. </para> <para>Note that the framework will not draw views that are not in the invalid region. </para> <para>To force a view to draw, call invalidate(). </para> <para>  <h3>Event Handling and Threading</h3></para> <para>The basic cycle of a view is as follows:  <ol> <li> <para>An event comes in and is dispatched to the appropriate view. The view handles the event and notifies any listeners. </para></li> <li> <para>If in the course of processing the event, the view's bounds may need to be changed, the view will call requestLayout(). </para></li> <li> <para>Similarly, if in the course of processing the event the view's appearance may need to be changed, the view will call invalidate(). </para></li> <li> <para>If either requestLayout() or invalidate() were called, the framework will take care of measuring, laying out, and drawing the tree as appropriate. </para></li></ol></para> <para> <b>Note: The entire view tree is single threaded. You must always be on the UI thread when calling any method on any view.</b> If you are doing work on other threads and want to update the state of a view from that thread, you should use a Handler. </para> <para>  <h3>Focus Handling</h3></para> <para>The framework will handle routine focus movement in response to user input. This includes changing the focus as views are removed or hidden, or as new views become available. Views indicate their willingness to take focus through the isFocusable method. To change whether a view can take focus, call setFocusable(boolean). When in touch mode (see notes below) views indicate whether they still would like focus via isFocusableInTouchMode and can change this via setFocusableInTouchMode(boolean). </para> <para>Focus movement is based on an algorithm which finds the nearest neighbor in a given direction. In rare cases, the default algorithm may not match the intended behavior of the developer. In these situations, you can provide explicit overrides by using these XML attributes in the layout file:  <pre>
		/// nextFocusDown
		/// nextFocusLeft
		/// nextFocusRight
		/// nextFocusUp
		/// </pre> </para> <para>To get a particular view to take focus, call requestFocus(). </para> <para>  <h3>Touch Mode</h3></para> <para>When a user is navigating a user interface via directional keys such as a D-pad, it is necessary to give focus to actionable items such as buttons so the user can see what will take input. If the device has touch capabilities, however, and the user begins interacting with the interface by touching it, it is no longer necessary to always highlight, or give focus to, a particular view. This motivates a mode for interaction named 'touch mode'. </para> <para>For a touch capable device, once the user touches the screen, the device will enter touch mode. From this point onward, only views for which isFocusableInTouchMode is true will be focusable, such as text editing widgets. Other views that are touchable, like buttons, will not take focus when touched; they will only fire the on click listeners. </para> <para>Any time a user hits a directional key, such as a D-pad direction, the view device will exit touch mode, and find a view to take focus, so that the user may resume interacting with the user interface without touching the screen again. </para> <para>The touch mode state is maintained across android.app.Activitys. Call isInTouchMode to see whether the device is currently in touch mode. </para> <para>  <h3>Scrolling</h3></para> <para>The framework provides basic support for views that wish to internally scroll their content. This includes keeping track of the X and Y scroll offset as well as mechanisms for drawing scrollbars. See scrollBy(int, int), scrollTo(int, int), and awakenScrollBars() for more details. </para> <para>  <h3>Tags</h3></para> <para>Unlike IDs, tags are not used to identify views. Tags are essentially an extra piece of information that can be associated with a view. They are most often used as a convenience to store data related to views in the views themselves rather than by putting them in a separate structure. </para> <para>  <h3>Properties</h3></para> <para>The View class exposes an ALPHA property, as well as several transform-related properties, such as TRANSLATION_X and TRANSLATION_Y. These properties are available both in the Property form as well as in similarly-named setter/getter methods (such as setAlpha(float) for ALPHA). These properties can be used to set persistent state associated with these rendering-related properties on the view. The properties and methods can also be used in conjunction with Animator-based animations, described more in the  section. </para> <para>  <h3>Animation</h3></para> <para>Starting with Android 3.0, the preferred way of animating views is to use the android.animation package APIs. These Animator-based classes change actual properties of the View object, such as alpha and translationX. This behavior is contrasted to that of the pre-3.0 Animation-based classes, which instead animate only how the view is drawn on the display. In particular, the ViewPropertyAnimator class makes animating these View properties particularly easy and efficient. </para> <para>Alternatively, you can use the pre-3.0 animation classes to animate how Views are rendered. You can attach an Animation object to a view using setAnimation(Animation) or startAnimation(Animation). The animation can alter the scale, rotation, translation and alpha of a view over time. If the animation is attached to a view that has children, the animation will affect the entire subtree rooted by that node. When an animation is started, the framework will take care of redrawing the appropriate views until the animation completes. </para> <para>  <h3>Security</h3></para> <para>Sometimes it is essential that an application be able to verify that an action is being performed with the full knowledge and consent of the user, such as granting a permission request, making a purchase or clicking on an advertisement. Unfortunately, a malicious application could try to spoof the user into performing these actions, unaware, by concealing the intended purpose of the view. As a remedy, the framework offers a touch filtering mechanism that can be used to improve the security of views that provide access to sensitive functionality. </para> <para>To enable touch filtering, call setFilterTouchesWhenObscured(boolean) or set the android:filterTouchesWhenObscured layout attribute to true. When enabled, the framework will discard touches that are received whenever the view's window is obscured by another visible window. As a result, the view will not receive touches whenever a toast, dialog or other window appears above the view's window. </para> <para>For more fine-grained control over security, consider overriding the onFilterTouchEventForSecurity(MotionEvent) method to implement your own security policy. See also MotionEvent#FLAG_WINDOW_IS_OBSCURED. </para> <para>ref android.R.styleable::View_alpha  ref android.R.styleable::View_background  ref android.R.styleable::View_clickable  ref android.R.styleable::View_contentDescription  ref android.R.styleable::View_drawingCacheQuality  ref android.R.styleable::View_duplicateParentState  ref android.R.styleable::View_id  ref android.R.styleable::View_requiresFadingEdge  ref android.R.styleable::View_fadeScrollbars  ref android.R.styleable::View_fadingEdgeLength  ref android.R.styleable::View_filterTouchesWhenObscured  ref android.R.styleable::View_fitsSystemWindows  ref android.R.styleable::View_isScrollContainer  ref android.R.styleable::View_focusable  ref android.R.styleable::View_focusableInTouchMode  ref android.R.styleable::View_hapticFeedbackEnabled  ref android.R.styleable::View_keepScreenOn  ref android.R.styleable::View_layerType  ref android.R.styleable::View_layoutDirection  ref android.R.styleable::View_longClickable  ref android.R.styleable::View_minHeight  ref android.R.styleable::View_minWidth  ref android.R.styleable::View_nextFocusDown  ref android.R.styleable::View_nextFocusLeft  ref android.R.styleable::View_nextFocusRight  ref android.R.styleable::View_nextFocusUp  ref android.R.styleable::View_onClick  ref android.R.styleable::View_padding  ref android.R.styleable::View_paddingBottom  ref android.R.styleable::View_paddingLeft  ref android.R.styleable::View_paddingRight  ref android.R.styleable::View_paddingTop  ref android.R.styleable::View_paddingStart  ref android.R.styleable::View_paddingEnd  ref android.R.styleable::View_saveEnabled  ref android.R.styleable::View_rotation  ref android.R.styleable::View_rotationX  ref android.R.styleable::View_rotationY  ref android.R.styleable::View_scaleX  ref android.R.styleable::View_scaleY  ref android.R.styleable::View_scrollX  ref android.R.styleable::View_scrollY  ref android.R.styleable::View_scrollbarSize  ref android.R.styleable::View_scrollbarStyle  ref android.R.styleable::View_scrollbars  ref android.R.styleable::View_scrollbarDefaultDelayBeforeFade  ref android.R.styleable::View_scrollbarFadeDuration  ref android.R.styleable::View_scrollbarTrackHorizontal  ref android.R.styleable::View_scrollbarThumbHorizontal  ref android.R.styleable::View_scrollbarThumbVertical  ref android.R.styleable::View_scrollbarTrackVertical  ref android.R.styleable::View_scrollbarAlwaysDrawHorizontalTrack  ref android.R.styleable::View_scrollbarAlwaysDrawVerticalTrack  ref android.R.styleable::View_soundEffectsEnabled  ref android.R.styleable::View_tag  ref android.R.styleable::View_textAlignment  ref android.R.styleable::View_textDirection  ref android.R.styleable::View_transformPivotX  ref android.R.styleable::View_transformPivotY  ref android.R.styleable::View_translationX  ref android.R.styleable::View_translationY  ref android.R.styleable::View_visibility</para> <para> <para>android.view.ViewGroup </para></para>    
		/// </summary>
		/// <java-name>
		/// android/view/View
		/// </java-name>
		[Dot42.DexImport("android/view/View", AccessFlags = 33)]
		public partial class View : global::Android.Graphics.Drawables.Drawable.ICallback, global::Android.Views.KeyEvent.ICallback, global::Android.Views.Accessibility.IAccessibilityEventSource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The logging tag used by this class with android.util.Log. </para>        
				/// </summary>
				/// <java-name>
				/// VIEW_LOG_TAG
				/// </java-name>
				[Dot42.DexImport("VIEW_LOG_TAG", "Ljava/lang/String;", AccessFlags = 28)]
				protected internal const string VIEW_LOG_TAG = "View";
				/// <summary>
				///  <para>Used to mark a View that has no ID. </para>        
				/// </summary>
				/// <java-name>
				/// NO_ID
				/// </java-name>
				[Dot42.DexImport("NO_ID", "I", AccessFlags = 25)]
				public const int NO_ID = -1;
				/// <summary>
				///  <para>This view is visible. Use with setVisibility and </para>        
				/// </summary>
				/// <java-name>
				/// VISIBLE
				/// </java-name>
				[Dot42.DexImport("VISIBLE", "I", AccessFlags = 25)]
				public const int VISIBLE = 0;
				/// <summary>
				///  <para>This view is invisible, but it still takes up space for layout purposes. Use with setVisibility and </para>        
				/// </summary>
				/// <java-name>
				/// INVISIBLE
				/// </java-name>
				[Dot42.DexImport("INVISIBLE", "I", AccessFlags = 25)]
				public const int INVISIBLE = 4;
				/// <summary>
				///  <para>This view is invisible, and it doesn't take any space for layout purposes. Use with setVisibility and </para>        
				/// </summary>
				/// <java-name>
				/// GONE
				/// </java-name>
				[Dot42.DexImport("GONE", "I", AccessFlags = 25)]
				public const int GONE = 8;
				/// <summary>
				///  <para>Enables low quality mode for the drawing cache.</para>        
				/// </summary>
				/// <java-name>
				/// DRAWING_CACHE_QUALITY_LOW
				/// </java-name>
				[Dot42.DexImport("DRAWING_CACHE_QUALITY_LOW", "I", AccessFlags = 25)]
				public const int DRAWING_CACHE_QUALITY_LOW = 524288;
				/// <summary>
				///  <para>Enables high quality mode for the drawing cache.</para>        
				/// </summary>
				/// <java-name>
				/// DRAWING_CACHE_QUALITY_HIGH
				/// </java-name>
				[Dot42.DexImport("DRAWING_CACHE_QUALITY_HIGH", "I", AccessFlags = 25)]
				public const int DRAWING_CACHE_QUALITY_HIGH = 1048576;
				/// <summary>
				///  <para>Enables automatic quality mode for the drawing cache.</para>        
				/// </summary>
				/// <java-name>
				/// DRAWING_CACHE_QUALITY_AUTO
				/// </java-name>
				[Dot42.DexImport("DRAWING_CACHE_QUALITY_AUTO", "I", AccessFlags = 25)]
				public const int DRAWING_CACHE_QUALITY_AUTO = 0;
				/// <summary>
				///  <para>The scrollbar style to display the scrollbars inside the content area, without increasing the padding. The scrollbars will be overlaid with translucency on the view's content. </para>        
				/// </summary>
				/// <java-name>
				/// SCROLLBARS_INSIDE_OVERLAY
				/// </java-name>
				[Dot42.DexImport("SCROLLBARS_INSIDE_OVERLAY", "I", AccessFlags = 25)]
				public const int SCROLLBARS_INSIDE_OVERLAY = 0;
				/// <summary>
				///  <para>The scrollbar style to display the scrollbars inside the padded area, increasing the padding of the view. The scrollbars will not overlap the content area of the view. </para>        
				/// </summary>
				/// <java-name>
				/// SCROLLBARS_INSIDE_INSET
				/// </java-name>
				[Dot42.DexImport("SCROLLBARS_INSIDE_INSET", "I", AccessFlags = 25)]
				public const int SCROLLBARS_INSIDE_INSET = 16777216;
				/// <summary>
				///  <para>The scrollbar style to display the scrollbars at the edge of the view, without increasing the padding. The scrollbars will be overlaid with translucency. </para>        
				/// </summary>
				/// <java-name>
				/// SCROLLBARS_OUTSIDE_OVERLAY
				/// </java-name>
				[Dot42.DexImport("SCROLLBARS_OUTSIDE_OVERLAY", "I", AccessFlags = 25)]
				public const int SCROLLBARS_OUTSIDE_OVERLAY = 33554432;
				/// <summary>
				///  <para>The scrollbar style to display the scrollbars at the edge of the view, increasing the padding of the view. The scrollbars will only overlap the background, if any. </para>        
				/// </summary>
				/// <java-name>
				/// SCROLLBARS_OUTSIDE_INSET
				/// </java-name>
				[Dot42.DexImport("SCROLLBARS_OUTSIDE_INSET", "I", AccessFlags = 25)]
				public const int SCROLLBARS_OUTSIDE_INSET = 50331648;
				/// <summary>
				///  <para>View flag indicating that the screen should remain on while the window containing this view is visible to the user. This effectively takes care of automatically setting the WindowManager's WindowManager.LayoutParams#FLAG_KEEP_SCREEN_ON. </para>        
				/// </summary>
				/// <java-name>
				/// KEEP_SCREEN_ON
				/// </java-name>
				[Dot42.DexImport("KEEP_SCREEN_ON", "I", AccessFlags = 25)]
				public const int KEEP_SCREEN_ON = 67108864;
				/// <summary>
				///  <para>View flag indicating whether this view should have sound effects enabled for events such as clicking and touching. </para>        
				/// </summary>
				/// <java-name>
				/// SOUND_EFFECTS_ENABLED
				/// </java-name>
				[Dot42.DexImport("SOUND_EFFECTS_ENABLED", "I", AccessFlags = 25)]
				public const int SOUND_EFFECTS_ENABLED = 134217728;
				/// <summary>
				///  <para>View flag indicating whether this view should have haptic feedback enabled for events such as long presses. </para>        
				/// </summary>
				/// <java-name>
				/// HAPTIC_FEEDBACK_ENABLED
				/// </java-name>
				[Dot42.DexImport("HAPTIC_FEEDBACK_ENABLED", "I", AccessFlags = 25)]
				public const int HAPTIC_FEEDBACK_ENABLED = 268435456;
				/// <summary>
				///  <para>View flag indicating whether addFocusables(ArrayList, int, int) should add all focusable Views regardless if they are focusable in touch mode. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUSABLES_ALL
				/// </java-name>
				[Dot42.DexImport("FOCUSABLES_ALL", "I", AccessFlags = 25)]
				public const int FOCUSABLES_ALL = 0;
				/// <summary>
				///  <para>View flag indicating whether addFocusables(ArrayList, int, int) should add only Views focusable in touch mode. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUSABLES_TOUCH_MODE
				/// </java-name>
				[Dot42.DexImport("FOCUSABLES_TOUCH_MODE", "I", AccessFlags = 25)]
				public const int FOCUSABLES_TOUCH_MODE = 1;
				/// <summary>
				///  <para>Use with focusSearch(int). Move focus to the previous selectable item. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_BACKWARD
				/// </java-name>
				[Dot42.DexImport("FOCUS_BACKWARD", "I", AccessFlags = 25)]
				public const int FOCUS_BACKWARD = 1;
				/// <summary>
				///  <para>Use with focusSearch(int). Move focus to the next selectable item. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_FORWARD
				/// </java-name>
				[Dot42.DexImport("FOCUS_FORWARD", "I", AccessFlags = 25)]
				public const int FOCUS_FORWARD = 2;
				/// <summary>
				///  <para>Use with focusSearch(int). Move focus to the left. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_LEFT
				/// </java-name>
				[Dot42.DexImport("FOCUS_LEFT", "I", AccessFlags = 25)]
				public const int FOCUS_LEFT = 17;
				/// <summary>
				///  <para>Use with focusSearch(int). Move focus up. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_UP
				/// </java-name>
				[Dot42.DexImport("FOCUS_UP", "I", AccessFlags = 25)]
				public const int FOCUS_UP = 33;
				/// <summary>
				///  <para>Use with focusSearch(int). Move focus to the right. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_RIGHT
				/// </java-name>
				[Dot42.DexImport("FOCUS_RIGHT", "I", AccessFlags = 25)]
				public const int FOCUS_RIGHT = 66;
				/// <summary>
				///  <para>Use with focusSearch(int). Move focus down. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_DOWN
				/// </java-name>
				[Dot42.DexImport("FOCUS_DOWN", "I", AccessFlags = 25)]
				public const int FOCUS_DOWN = 130;
				/// <summary>
				///  <para>Base View state sets Indicates the view has no states set. States are used with android.graphics.drawable.Drawable to change the drawing of the view depending on its state.</para> <para> <para>android.graphics.drawable.Drawable </para> <para>getDrawableState() </para></para>        
				/// </summary>
				/// <java-name>
				/// EMPTY_STATE_SET
				/// </java-name>
				[Dot42.DexImport("EMPTY_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] EMPTY_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is enabled. States are used with android.graphics.drawable.Drawable to change the drawing of the view depending on its state.</para> <para> <para>android.graphics.drawable.Drawable </para> <para>getDrawableState() </para></para>        
				/// </summary>
				/// <java-name>
				/// ENABLED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is focused. States are used with android.graphics.drawable.Drawable to change the drawing of the view depending on its state.</para> <para> <para>android.graphics.drawable.Drawable </para> <para>getDrawableState() </para></para>        
				/// </summary>
				/// <java-name>
				/// FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is selected. States are used with android.graphics.drawable.Drawable to change the drawing of the view depending on its state.</para> <para> <para>android.graphics.drawable.Drawable </para> <para>getDrawableState() </para></para>        
				/// </summary>
				/// <java-name>
				/// SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] SELECTED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view's window has focus. States are used with android.graphics.drawable.Drawable to change the drawing of the view depending on its state.</para> <para> <para>android.graphics.drawable.Drawable </para> <para>getDrawableState() </para></para>        
				/// </summary>
				/// <java-name>
				/// WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is enabled and has the focus.</para> <para> <para>ENABLED_STATE_SET </para> <para>FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// ENABLED_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is enabled and selected.</para> <para> <para>ENABLED_STATE_SET </para> <para>SELECTED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// ENABLED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_SELECTED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is enabled and that its window has focus.</para> <para> <para>ENABLED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// ENABLED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is focused and selected.</para> <para> <para>FOCUSED_STATE_SET </para> <para>SELECTED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// FOCUSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_SELECTED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view has the focus and that its window has the focus.</para> <para> <para>FOCUSED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// FOCUSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is selected and that its window has the focus.</para> <para> <para>SELECTED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is enabled, focused and selected.</para> <para> <para>ENABLED_STATE_SET </para> <para>FOCUSED_STATE_SET </para> <para>SELECTED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// ENABLED_FOCUSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_FOCUSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_FOCUSED_SELECTED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is enabled, focused and its window has the focus.</para> <para> <para>ENABLED_STATE_SET </para> <para>FOCUSED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is enabled, selected and its window has the focus.</para> <para> <para>ENABLED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is focused, selected and its window has the focus.</para> <para> <para>FOCUSED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is enabled, focused, selected and its window has the focus.</para> <para> <para>ENABLED_STATE_SET </para> <para>FOCUSED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed and its window has the focus.</para> <para> <para>PRESSED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed and selected.</para> <para> <para>PRESSED_STATE_SET </para> <para>SELECTED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_SELECTED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, selected and its window has the focus.</para> <para> <para>PRESSED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed and focused.</para> <para> <para>PRESSED_STATE_SET </para> <para>FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, focused and its window has the focus.</para> <para> <para>PRESSED_STATE_SET </para> <para>FOCUSED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_FOCUSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_FOCUSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_FOCUSED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, focused and selected.</para> <para> <para>PRESSED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_FOCUSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_FOCUSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_FOCUSED_SELECTED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, focused, selected and its window has the focus.</para> <para> <para>PRESSED_STATE_SET </para> <para>FOCUSED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed and enabled.</para> <para> <para>PRESSED_STATE_SET </para> <para>ENABLED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_ENABLED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, enabled and its window has the focus.</para> <para> <para>PRESSED_STATE_SET </para> <para>ENABLED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_ENABLED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, enabled and selected.</para> <para> <para>PRESSED_STATE_SET </para> <para>ENABLED_STATE_SET </para> <para>SELECTED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_ENABLED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_SELECTED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, enabled, selected and its window has the focus.</para> <para> <para>PRESSED_STATE_SET </para> <para>ENABLED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, enabled and focused.</para> <para> <para>PRESSED_STATE_SET </para> <para>ENABLED_STATE_SET </para> <para>FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_ENABLED_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, enabled, focused and its window has the focus.</para> <para> <para>PRESSED_STATE_SET </para> <para>ENABLED_STATE_SET </para> <para>FOCUSED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_FOCUSED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, enabled, focused and selected.</para> <para> <para>PRESSED_STATE_SET </para> <para>ENABLED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_ENABLED_FOCUSED_SELECTED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_FOCUSED_SELECTED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_FOCUSED_SELECTED_STATE_SET;
				/// <summary>
				///  <para>Indicates the view is pressed, enabled, focused, selected and its window has the focus.</para> <para> <para>PRESSED_STATE_SET </para> <para>ENABLED_STATE_SET </para> <para>SELECTED_STATE_SET </para> <para>FOCUSED_STATE_SET </para> <para>WINDOW_FOCUSED_STATE_SET </para></para>        
				/// </summary>
				/// <java-name>
				/// PRESSED_ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET
				/// </java-name>
				[Dot42.DexImport("PRESSED_ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET", "[I", AccessFlags = 28)]
				protected internal static readonly int[] PRESSED_ENABLED_FOCUSED_SELECTED_WINDOW_FOCUSED_STATE_SET;
				/// <summary>
				///  <para>Always allow a user to over-scroll this view, provided it is a view that can scroll.</para> <para> <para>getOverScrollMode() </para> <para>setOverScrollMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// OVER_SCROLL_ALWAYS
				/// </java-name>
				[Dot42.DexImport("OVER_SCROLL_ALWAYS", "I", AccessFlags = 25)]
				public const int OVER_SCROLL_ALWAYS = 0;
				/// <summary>
				///  <para>Allow a user to over-scroll this view only if the content is large enough to meaningfully scroll, provided it is a view that can scroll.</para> <para> <para>getOverScrollMode() </para> <para>setOverScrollMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// OVER_SCROLL_IF_CONTENT_SCROLLS
				/// </java-name>
				[Dot42.DexImport("OVER_SCROLL_IF_CONTENT_SCROLLS", "I", AccessFlags = 25)]
				public const int OVER_SCROLL_IF_CONTENT_SCROLLS = 1;
				/// <summary>
				///  <para>Never allow a user to over-scroll this view.</para> <para> <para>getOverScrollMode() </para> <para>setOverScrollMode(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// OVER_SCROLL_NEVER
				/// </java-name>
				[Dot42.DexImport("OVER_SCROLL_NEVER", "I", AccessFlags = 25)]
				public const int OVER_SCROLL_NEVER = 2;
				/// <summary>
				///  <para>Simple constructor to use when creating a view from code.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public View(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Constructor that is called when inflating a view from XML. This is called when a view is being constructed from an XML file, supplying attributes that were specified in the XML file. This version uses a default style of 0, so the only attribute values applied are those in the Context's Theme and the given AttributeSet.</para> <para>The method onFinishInflate() will be called after all children have been added.</para> <para> <para>View(Context, AttributeSet, int) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public View(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform inflation from XML and apply a class-specific base style. This constructor of View allows subclasses to use their own base style when they are inflating. For example, a Button class's constructor would call this version of the super class constructor and supply  <code>R.attr.buttonStyle</code> for  <b>defStyle</b>; this allows the theme's button style to modify all of the base view attributes (in particular its background) as well as the Button class's attributes.</para> <para> <para>View(Context, AttributeSet) </para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public View(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes the fading edges from a given set of styled attributes. This method should be called by subclasses that need fading edges and when an instance of these subclasses is created programmatically rather than being inflated from XML. This method is automatically called when the XML is inflated. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initializeFadingEdge
				/// </java-name>
				[Dot42.DexImport("initializeFadingEdge", "(Landroid/content/res/TypedArray;)V", AccessFlags = 4)]
				protected internal virtual void InitializeFadingEdge(global::Android.Content.Res.TypedArray a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the size of the faded edge used to indicate that more content in this view is available. Will not change whether the fading edge is enabled; use setVerticalFadingEdgeEnabled(boolean) or setHorizontalFadingEdgeEnabled(boolean) to enable the fading edge for the vertical or horizontal fading edges.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFadingEdgeLength
				/// </java-name>
				[Dot42.DexImport("setFadingEdgeLength", "(I)V", AccessFlags = 1)]
				public virtual void SetFadingEdgeLength(int length) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Initializes the scrollbars from a given set of styled attributes. This method should be called by subclasses that need scrollbars and when an instance of these subclasses is created programmatically rather than being inflated from XML. This method is automatically called when the XML is inflated. </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initializeScrollbars
				/// </java-name>
				[Dot42.DexImport("initializeScrollbars", "(Landroid/content/res/TypedArray;)V", AccessFlags = 4)]
				protected internal virtual void InitializeScrollbars(global::Android.Content.Res.TypedArray a) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when this view is clicked. If this view is not clickable, it becomes clickable.</para> <para> <para>setClickable(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setOnClickListener
				/// </java-name>
				[Dot42.DexImport("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnClickListener(global::Android.Views.View.IOnClickListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when this view is clicked and held. If this view is not long clickable, it becomes long clickable.</para> <para> <para>setLongClickable(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// setOnLongClickListener
				/// </java-name>
				[Dot42.DexImport("setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", AccessFlags = 1)]
				public virtual void SetOnLongClickListener(global::Android.Views.View.IOnLongClickListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the context menu for this view is being built. If this view is not long clickable, it becomes long clickable.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnCreateContextMenuListener
				/// </java-name>
				[Dot42.DexImport("setOnCreateContextMenuListener", "(Landroid/view/View$OnCreateContextMenuListener;)V", AccessFlags = 1)]
				public virtual void SetOnCreateContextMenuListener(global::Android.Views.View.IOnCreateContextMenuListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this view's OnClickListener, if it is defined. Performs all normal actions associated with clicking: reporting accessibility event, playing a sound, etc.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True there was an assigned OnClickListener that was called, false otherwise is returned. </para>
				/// </returns>
				/// <java-name>
				/// performClick
				/// </java-name>
				[Dot42.DexImport("performClick", "()Z", AccessFlags = 1)]
				public virtual bool PerformClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Call this view's OnLongClickListener, if it is defined. Invokes the context menu if the OnLongClickListener did not consume the event.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if one of the above receivers consumed the event, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// performLongClick
				/// </java-name>
				[Dot42.DexImport("performLongClick", "()Z", AccessFlags = 1)]
				public virtual bool PerformLongClick() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Bring up the context menu for this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether a context menu was displayed. </para>
				/// </returns>
				/// <java-name>
				/// showContextMenu
				/// </java-name>
				[Dot42.DexImport("showContextMenu", "()Z", AccessFlags = 1)]
				public virtual bool ShowContextMenu() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Register a callback to be invoked when a hardware key is pressed in this view. Key presses in software input methods will generally not trigger the methods of this listener. </para>        
				/// </summary>
				/// <java-name>
				/// setOnKeyListener
				/// </java-name>
				[Dot42.DexImport("setOnKeyListener", "(Landroid/view/View$OnKeyListener;)V", AccessFlags = 1)]
				public virtual void SetOnKeyListener(global::Android.Views.View.IOnKeyListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when a touch event is sent to this view. </para>        
				/// </summary>
				/// <java-name>
				/// setOnTouchListener
				/// </java-name>
				[Dot42.DexImport("setOnTouchListener", "(Landroid/view/View$OnTouchListener;)V", AccessFlags = 1)]
				public virtual void SetOnTouchListener(global::Android.Views.View.IOnTouchListener l) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Request that a rectangle of this view be visible on the screen, scrolling if necessary just enough.</para> <para>A View should call this if it maintains some notion of which part of its content is interesting. For example, a text editing view should call this when its cursor moves.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether any parent scrolled. </para>
				/// </returns>
				/// <java-name>
				/// requestRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestRectangleOnScreen", "(Landroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool RequestRectangleOnScreen(global::Android.Graphics.Rect rectangle) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Request that a rectangle of this view be visible on the screen, scrolling if necessary just enough.</para> <para>A View should call this if it maintains some notion of which part of its content is interesting. For example, a text editing view should call this when its cursor moves.</para> <para>When  <code>immediate</code> is set to true, scrolling will not be animated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether any parent scrolled. </para>
				/// </returns>
				/// <java-name>
				/// requestRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestRectangleOnScreen", "(Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public virtual bool RequestRectangleOnScreen(global::Android.Graphics.Rect rectangle, bool immediate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when this view wants to give up focus. If focus is cleared onFocusChanged(boolean, int, android.graphics.Rect) is called. </para> <para> <b>Note:</b> When a View clears focus the framework is trying to give focus to the first focusable View from the top. Hence, if this View is the first from the top that can take focus, then all callbacks related to clearing focus will be invoked after wich the framework will give focus to this view. </para>        
				/// </summary>
				/// <java-name>
				/// clearFocus
				/// </java-name>
				[Dot42.DexImport("clearFocus", "()V", AccessFlags = 1)]
				public virtual void ClearFocus() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the view system when the focus state of this view changes. When the focus change event is caused by directional navigation, direction and previouslyFocusedRect provide insight into where the focus is coming from. When overriding, be sure to call up through to the super class so that the standard focus handling will occur.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onFocusChanged
				/// </java-name>
				[Dot42.DexImport("onFocusChanged", "(ZILandroid/graphics/Rect;)V", AccessFlags = 4)]
				protected internal virtual void OnFocusChanged(bool gainFocus, int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sends an accessibility event of the given type. If accessibility is not enabled this method has no effect. The default implementation calls onInitializeAccessibilityEvent(AccessibilityEvent) first to populate information about the event source (this View), then calls dispatchPopulateAccessibilityEvent(AccessibilityEvent) to populate the text content of the event source including its descendants, and last calls ViewParent#requestSendAccessibilityEvent(View, AccessibilityEvent) on its parent to resuest sending of the event to interested parties. </para> <para>If an AccessibilityDelegate has been specified via calling setAccessibilityDelegate(AccessibilityDelegate) its AccessibilityDelegate#sendAccessibilityEvent(View, int) is responsible for handling this call. </para> <para> <para>onInitializeAccessibilityEvent(AccessibilityEvent) </para> <para>dispatchPopulateAccessibilityEvent(AccessibilityEvent) </para> <para>ViewParent::requestSendAccessibilityEvent(View, AccessibilityEvent) </para> <para>AccessibilityDelegate </para></para>        
				/// </summary>
				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1)]
				public virtual void SendAccessibilityEvent(int eventType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method behaves exactly as sendAccessibilityEvent(int) but takes as an argument an empty AccessibilityEvent and does not perform a check whether accessibility is enabled. </para> <para>If an AccessibilityDelegate has been specified via calling setAccessibilityDelegate(AccessibilityDelegate) its AccessibilityDelegate#sendAccessibilityEventUnchecked(View, AccessibilityEvent) is responsible for handling this call. </para> <para> <para>sendAccessibilityEvent(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// sendAccessibilityEventUnchecked
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public virtual void SendAccessibilityEventUnchecked(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatches an AccessibilityEvent to the View first and then to its children for adding their text content to the event. Note that the event text is populated in a separate dispatch path since we add to the event not only the text of the source but also the text of all its descendants. A typical implementation will call onPopulateAccessibilityEvent(AccessibilityEvent) on the this view and then call the dispatchPopulateAccessibilityEvent(AccessibilityEvent) on each child. Override this method if custom population of the event text content is required. </para> <para>If an AccessibilityDelegate has been specified via calling setAccessibilityDelegate(AccessibilityDelegate) its AccessibilityDelegate#dispatchPopulateAccessibilityEvent(View, AccessibilityEvent) is responsible for handling this call. </para> <para> <b>Note:</b> Accessibility events of certain types are not dispatched for populating the event text via this method. For details refer to AccessibilityEvent. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event population was completed. </para>
				/// </returns>
				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Find the view in the hierarchy rooted at this view that currently has focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The view that currently has focus, or null if no focused view can be found. </para>
				/// </returns>
				/// <java-name>
				/// findFocus
				/// </java-name>
				[Dot42.DexImport("findFocus", "()Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindFocus() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Change whether this view is one of the set of scrollable containers in its window. This will be used to determine whether the window can resize or must pan when a soft input area is open  scrollable containers allow the window to use resize mode since the container will appropriately shrink.</para> <para>ref android.R.styleable::View_isScrollContainer </para>        
				/// </summary>
				/// <java-name>
				/// setScrollContainer
				/// </java-name>
				[Dot42.DexImport("setScrollContainer", "(Z)V", AccessFlags = 1)]
				public virtual void SetScrollContainer(bool isScrollContainer) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the view hierarchy when the content insets for a window have changed, to allow it to adjust its content to fit within those windows. The content insets tell you the space that the status bar, input method, and other system windows infringe on the application's window.</para> <para>You do not normally need to deal with this function, since the default window decoration given to applications takes care of applying it to the content of the window. If you use SYSTEM_UI_FLAG_LAYOUT_FULLSCREEN or SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION this will not be the case, and your content can be placed under those system elements. You can then use this method within your view hierarchy if you have parts of your UI which you would like to ensure are not being covered.</para> <para>The default implementation of this method simply applies the content insets to the view's padding, consuming that content (modifying the insets to be 0), and returning true. This behavior is off by default, but can be enabled through setFitsSystemWindows(boolean).</para> <para>This function's traversal down the hierarchy is depth-first. The same content insets object is propagated down the hierarchy, so any changes made to it will be seen by all following views (including potentially ones above in the hierarchy since this is a depth-first traversal). The first view that returns true will abort the entire traversal.</para> <para>The default implementation works well for a situation where it is used with a container that covers the entire window, allowing it to apply the appropriate insets to its content on all edges. If you need a more complicated layout (such as two different views fitting system windows, one on the top of the window, and one on the bottom), you can override the method and handle the insets however you would like. Note that the insets provided by the framework are always relative to the far edges of the window, not accounting for the location of the called view within that window. (In fact when this method is called you do not yet know where the layout will place the view, as it is done before layout happens.)</para> <para>Note: unlike many View methods, there is no dispatch phase to this call. If you are overriding it in a ViewGroup and want to allow the call to continue to your children, you must be sure to call the super implementation.</para> <para>Here is a sample layout that makes use of fitting system windows to have controls for a video view placed inside of the window decorations that it hides and shows. This can be used with code like the second sample (video player) shown in setSystemUiVisibility(int).</para> <para>{ development/samples/ApiDemos/res/layout/video_player.xml complete}</para> <para> <para>getFitsSystemWindows() </para> <para>setFitsSystemWindows(boolean) </para> <para>setSystemUiVisibility(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para> <c>true </c> if this view applied the insets and it should not continue propagating further down the hierarchy, <c>false </c> otherwise. </para>
				/// </returns>
				/// <java-name>
				/// fitSystemWindows
				/// </java-name>
				[Dot42.DexImport("fitSystemWindows", "(Landroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal virtual bool FitSystemWindows(global::Android.Graphics.Rect insets) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If this view doesn't do any drawing on its own, set this flag to allow further optimizations. By default, this flag is not set on View, but could be set on some View subclasses such as ViewGroup.</para> <para>Typically, if you override onDraw(android.graphics.Canvas) you should clear this flag.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setWillNotDraw
				/// </java-name>
				[Dot42.DexImport("setWillNotDraw", "(Z)V", AccessFlags = 1)]
				public virtual void SetWillNotDraw(bool willNotDraw) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether or not this View draws on its own.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this view has nothing to draw, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// willNotDraw
				/// </java-name>
				[Dot42.DexImport("willNotDraw", "()Z", AccessFlags = 1)]
				public virtual bool WillNotDraw() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>When a View's drawing cache is enabled, drawing is redirected to an offscreen bitmap. Some views, like an ImageView, must be able to bypass this mechanism if they already draw a single bitmap, to avoid unnecessary usage of the memory.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setWillNotCacheDrawing
				/// </java-name>
				[Dot42.DexImport("setWillNotCacheDrawing", "(Z)V", AccessFlags = 1)]
				public virtual void SetWillNotCacheDrawing(bool willNotCacheDrawing) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether or not this View can cache its drawing or not.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this view does not cache its drawing, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// willNotCacheDrawing
				/// </java-name>
				[Dot42.DexImport("willNotCacheDrawing", "()Z", AccessFlags = 1)]
				public virtual bool WillNotCacheDrawing() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Dispatch setPressed to all of this View's children.</para> <para> <para>setPressed(boolean)</para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchSetPressed
				/// </java-name>
				[Dot42.DexImport("dispatchSetPressed", "(Z)V", AccessFlags = 4)]
				protected internal virtual void DispatchSetPressed(bool pressed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Find the nearest view in the specified direction that can take focus. This does not actually give focus to that view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The nearest focusable in the specified direction, or null if none can be found. </para>
				/// </returns>
				/// <java-name>
				/// focusSearch
				/// </java-name>
				[Dot42.DexImport("focusSearch", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FocusSearch(int direction) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>This method is the last chance for the focused view and its ancestors to respond to an arrow key. This is called when the focused view did not consume the key internally, nor could the view system find a new view in the requested direction to give focus to.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the this view consumed this unhandled move. </para>
				/// </returns>
				/// <java-name>
				/// dispatchUnhandledMove
				/// </java-name>
				[Dot42.DexImport("dispatchUnhandledMove", "(Landroid/view/View;I)Z", AccessFlags = 1)]
				public virtual bool DispatchUnhandledMove(global::Android.Views.View focused, int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Find and return all focusable views that are descendants of this view, possibly including this view if it is focusable itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A list of focusable views </para>
				/// </returns>
				/// <java-name>
				/// getFocusables
				/// </java-name>
				[Dot42.DexImport("getFocusables", "(I)Ljava/util/ArrayList;", AccessFlags = 1, Signature = "(I)Ljava/util/ArrayList<Landroid/view/View;>;")]
				public virtual global::Java.Util.ArrayList<global::Android.Views.View> GetFocusables(int direction) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ArrayList<global::Android.Views.View>);
				}

				/// <summary>
				///  <para>Add any focusable views that are descendants of this view (possibly including this view if it is focusable itself) to views. If we are in touch mode, only add views that are also focusable in touch mode.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addFocusables
				/// </java-name>
				[Dot42.DexImport("addFocusables", "(Ljava/util/ArrayList;I)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;I)V")]
				public virtual void AddFocusables(global::Java.Util.ArrayList<global::Android.Views.View> views, int direction) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds any focusable views that are descendants of this view (possibly including this view if it is focusable itself) to views. This method adds all focusable views regardless if we are in touch mode or only views focusable in touch mode if we are in touch mode or only views that can take accessibility focus if accessibility is enabeld depending on the focusable mode paramater.</para> <para> <para>FOCUSABLES_ALL </para> <para>FOCUSABLES_TOUCH_MODE </para></para>        
				/// </summary>
				/// <java-name>
				/// addFocusables
				/// </java-name>
				[Dot42.DexImport("addFocusables", "(Ljava/util/ArrayList;II)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;II)V")]
				public virtual void AddFocusables(global::Java.Util.ArrayList<global::Android.Views.View> views, int direction, int focusableMode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Add any touchable views that are descendants of this view (possibly including this view if it is touchable itself) to views.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addTouchables
				/// </java-name>
				[Dot42.DexImport("addTouchables", "(Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;)V")]
				public virtual void AddTouchables(global::Java.Util.ArrayList<global::Android.Views.View> views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this to try to give focus to a specific view or to one of its descendants.</para> <para>A view will not actually take focus if it is not focusable (isFocusable returns false), or if it is focusable and it is not focusable in touch mode (isFocusableInTouchMode) while the device is in touch mode.</para> <para>See also focusSearch(int), which is what you call to say that you have focus, and you want your parent to look for the next one.</para> <para>This is equivalent to calling requestFocus(int, Rect) with arguments FOCUS_DOWN and  <code>null</code>.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether this view or one of its descendants actually took focus. </para>
				/// </returns>
				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "()Z", AccessFlags = 17)]
				public bool RequestFocus() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Call this to try to give focus to a specific view or to one of its descendants and give it a hint about what direction focus is heading.</para> <para>A view will not actually take focus if it is not focusable (isFocusable returns false), or if it is focusable and it is not focusable in touch mode (isFocusableInTouchMode) while the device is in touch mode.</para> <para>See also focusSearch(int), which is what you call to say that you have focus, and you want your parent to look for the next one.</para> <para>This is equivalent to calling requestFocus(int, Rect) with  <code>null</code> set for the previously focused rectangle.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether this view or one of its descendants actually took focus. </para>
				/// </returns>
				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "(I)Z", AccessFlags = 17)]
				public bool RequestFocus(int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Call this to try to give focus to a specific view or to one of its descendants and give it hints about the direction and a specific rectangle that the focus is coming from. The rectangle can help give larger views a finer grained hint about where focus is coming from, and therefore, where to show selection, or forward focus change internally.</para> <para>A view will not actually take focus if it is not focusable (isFocusable returns false), or if it is focusable and it is not focusable in touch mode (isFocusableInTouchMode) while the device is in touch mode.</para> <para>A View will not take focus if it is not visible.</para> <para>A View will not take focus if one of its parents has android.view.ViewGroup#getDescendantFocusability() equal to ViewGroup#FOCUS_BLOCK_DESCENDANTS.</para> <para>See also focusSearch(int), which is what you call to say that you have focus, and you want your parent to look for the next one.</para> <para>You may wish to override this method if your custom View has an internal View that it wishes to forward the request to.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether this view or one of its descendants actually took focus. </para>
				/// </returns>
				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "(ILandroid/graphics/Rect;)Z", AccessFlags = 1)]
				public virtual bool RequestFocus(int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Call this to try to give focus to a specific view or to one of its descendants. This is a special variant of requestFocus() that will allow views that are not focuable in touch mode to request focus when they are touched.</para> <para> <para>isInTouchMode() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether this view or one of its descendants actually took focus.</para>
				/// </returns>
				/// <java-name>
				/// requestFocusFromTouch
				/// </java-name>
				[Dot42.DexImport("requestFocusFromTouch", "()Z", AccessFlags = 17)]
				public bool RequestFocusFromTouch() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This is called when a container is going to temporarily detach a child, with ViewGroup.detachViewFromParent. It will either be followed by onFinishTemporaryDetach() or onDetachedFromWindow() when the container is done. </para>        
				/// </summary>
				/// <java-name>
				/// onStartTemporaryDetach
				/// </java-name>
				[Dot42.DexImport("onStartTemporaryDetach", "()V", AccessFlags = 1)]
				public virtual void OnStartTemporaryDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called after onStartTemporaryDetach when the container is done changing the view. </para>        
				/// </summary>
				/// <java-name>
				/// onFinishTemporaryDetach
				/// </java-name>
				[Dot42.DexImport("onFinishTemporaryDetach", "()V", AccessFlags = 1)]
				public virtual void OnFinishTemporaryDetach() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatch a key event before it is processed by any input method associated with the view hierarchy. This can be used to intercept key events in special situations before the IME consumes them; a typical example would be handling the BACK key to update the application's UI instead of allowing the IME to see it and close itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event was handled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// dispatchKeyEventPreIme
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyEventPreIme(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Dispatch a key event to the next view on the focus path. This path runs from the top of the view tree down to the currently focused view. If this view has focus, it will dispatch to itself. Otherwise it will dispatch the next node down the focus path. This method also fires any key listeners.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event was handled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Dispatches a key shortcut event.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event was handled by the view, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// dispatchKeyShortcutEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyShortcutEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Pass the touch screen motion event down to the target view, or this view if it is the target.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event was handled by the view, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Filter the touch event to apply security policies.</para> <para> <para>getFilterTouchesWhenObscured </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event should be dispatched, false if the event should be dropped.</para>
				/// </returns>
				/// <java-name>
				/// onFilterTouchEventForSecurity
				/// </java-name>
				[Dot42.DexImport("onFilterTouchEventForSecurity", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnFilterTouchEventForSecurity(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Pass a trackball motion event down to the focused view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event was handled by the view, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTrackballEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called when the window containing this view gains or loses window focus. ViewGroups should override to route to their children.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void DispatchWindowFocusChanged(bool hasFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the window containing this view gains or loses focus. Note that this is separate from view focus: to receive key events, both your view and its window must have focus. If a window is displayed on top of yours that takes input focus, then your own window will lose focus but the view focus will remain unchanged.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnWindowFocusChanged(bool hasWindowFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatch a view visibility change down the view hierarchy. ViewGroups should override to route to their children. </para>        
				/// </summary>
				/// <java-name>
				/// dispatchVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal virtual void DispatchVisibilityChanged(global::Android.Views.View changedView, int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the visibility of the view or an ancestor of the view is changed. </para>        
				/// </summary>
				/// <java-name>
				/// onVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal virtual void OnVisibilityChanged(global::Android.Views.View changedView, int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatch a hint about whether this view is displayed. For instance, when a View moves out of the screen, it might receives a display hint indicating the view is not displayed. Applications should not  <b>rely</b> on this hint as there is no guarantee that they will receive one.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchDisplayHint
				/// </java-name>
				[Dot42.DexImport("dispatchDisplayHint", "(I)V", AccessFlags = 1)]
				public virtual void DispatchDisplayHint(int hint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Gives this view a hint about whether is displayed or not. For instance, when a View moves out of the screen, it might receives a display hint indicating the view is not displayed. Applications should not  <b>rely</b> on this hint as there is no guarantee that they will receive one.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onDisplayHint
				/// </java-name>
				[Dot42.DexImport("onDisplayHint", "(I)V", AccessFlags = 4)]
				protected internal virtual void OnDisplayHint(int hint) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatch a window visibility change down the view hierarchy. ViewGroups should override to route to their children.</para> <para> <para>onWindowVisibilityChanged(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowVisibilityChanged", "(I)V", AccessFlags = 1)]
				public virtual void DispatchWindowVisibilityChanged(int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the window containing has change its visibility (between GONE, INVISIBLE, and VISIBLE). Note that this tells you whether or not your window is being made visible to the window manager; this does  <b>not</b> tell you whether or not your window is obscured by other windows on the screen, even if it is itself visible.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("onWindowVisibilityChanged", "(I)V", AccessFlags = 4)]
				protected internal virtual void OnWindowVisibilityChanged(int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Retrieve the overall visible display size in which the window this view is attached to has been positioned in. This takes into account screen decorations above the window, for both cases where the window itself is being position inside of them or the window is being placed under then and covered insets are used for the window to position its content inside. In effect, this tells you the available area where content can be placed and remain visible to users.</para> <para>This function requires an IPC back to the window manager to retrieve the requested information, so should not be used in performance critical code like drawing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getWindowVisibleDisplayFrame
				/// </java-name>
				[Dot42.DexImport("getWindowVisibleDisplayFrame", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetWindowVisibleDisplayFrame(global::Android.Graphics.Rect outRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatch a notification about a resource configuration change down the view hierarchy. ViewGroups should override to route to their children.</para> <para> <para>onConfigurationChanged(android.content.res.Configuration) </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public virtual void DispatchConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the current configuration of the resources being used by the application have changed. You can use this to decide when to reload resources that can changed based on orientation and other configuration characterstics. You only need to use this if you are not relying on the normal android.app.Activity mechanism of recreating the activity instance upon a configuration change.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 4)]
				protected internal virtual void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Handle a key event before it is processed by any input method associated with the view hierarchy. This can be used to intercept key events in special situations before the IME consumes them; a typical example would be handling the BACK key to update the application's UI instead of allowing the IME to see it and close itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyPreIme
				/// </java-name>
				[Dot42.DexImport("onKeyPreIme", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyPreIme(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of KeyEvent.Callback.onKeyDown(): perform press of the view when KeyEvent#KEYCODE_DPAD_CENTER or KeyEvent#KEYCODE_ENTER is released, if the view is enabled and clickable.</para> <para>Key presses in software keyboards will generally NOT trigger this listener, although some may elect to do so in some situations. Do not rely on this to catch software key presses.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onKeyDown
				/// </java-name>
				[Dot42.DexImport("onKeyDown", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyDown(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of KeyEvent.Callback.onKeyLongPress(): always returns false (doesn't handle the event). </para> <para>Key presses in software keyboards will generally NOT trigger this listener, although some may elect to do so in some situations. Do not rely on this to catch software key presses. </para>        
				/// </summary>
				/// <java-name>
				/// onKeyLongPress
				/// </java-name>
				[Dot42.DexImport("onKeyLongPress", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyLongPress(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of KeyEvent.Callback.onKeyUp(): perform clicking of the view when KeyEvent#KEYCODE_DPAD_CENTER or KeyEvent#KEYCODE_ENTER is released. </para> <para>Key presses in software keyboards will generally NOT trigger this listener, although some may elect to do so in some situations. Do not rely on this to catch software key presses.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onKeyUp
				/// </java-name>
				[Dot42.DexImport("onKeyUp", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyUp(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Default implementation of KeyEvent.Callback.onKeyMultiple(): always returns false (doesn't handle the event). </para> <para>Key presses in software keyboards will generally NOT trigger this listener, although some may elect to do so in some situations. Do not rely on this to catch software key presses.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onKeyMultiple
				/// </java-name>
				[Dot42.DexImport("onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyMultiple(int keyCode, int repeatCount, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called on the focused view when a key shortcut event is not handled. Override this method to implement local key shortcuts for the View. Key shortcuts can also be implemented by setting the shortcut property of menu items.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>If you handled the event, return true. If you want to allow the event to be handled by the next receiver, return false. </para>
				/// </returns>
				/// <java-name>
				/// onKeyShortcut
				/// </java-name>
				[Dot42.DexImport("onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool OnKeyShortcut(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Check whether the called view is a text editor, in which case it would make sense to automatically display a soft input window for it. Subclasses should override this if they implement onCreateInputConnection(EditorInfo) to return true if a call on that method would return a non-null InputConnection, and they are really a first-class editor that the user would normally start typing on when the go into a window containing your view.</para> <para>The default implementation always returns false. This does  <b>not</b> mean that its onCreateInputConnection(EditorInfo) will not be called or the user can not otherwise perform edits on your view; it is just a hint to the system that this is not the primary purpose of this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if this view is a text editor, else false. </para>
				/// </returns>
				/// <java-name>
				/// onCheckIsTextEditor
				/// </java-name>
				[Dot42.DexImport("onCheckIsTextEditor", "()Z", AccessFlags = 1)]
				public virtual bool OnCheckIsTextEditor() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Create a new InputConnection for an InputMethod to interact with the view. The default implementation returns null, since it doesn't support input methods. You can override this to implement such support. This is only needed for views that take focus and text input.</para> <para>When implementing this, you probably also want to implement onCheckIsTextEditor() to indicate you will return a non-null InputConnection.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateInputConnection
				/// </java-name>
				[Dot42.DexImport("onCreateInputConnection", "(Landroid/view/inputmethod/EditorInfo;)Landroid/view/inputmethod/InputConnection;" +
    "", AccessFlags = 1)]
				public virtual global::Android.Views.Inputmethod.IInputConnection OnCreateInputConnection(global::Android.Views.Inputmethod.EditorInfo outAttrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Inputmethod.IInputConnection);
				}

				/// <summary>
				///  <para>Called by the android.view.inputmethod.InputMethodManager when a view who is not the current input connection target is trying to make a call on the manager. The default implementation returns false; you can override this to return true for certain views if you are performing InputConnection proxying to them. </para>        
				/// </summary>
				/// <returns>
				///  <para>Return true to allow the call, false to reject. </para>
				/// </returns>
				/// <java-name>
				/// checkInputConnectionProxy
				/// </java-name>
				[Dot42.DexImport("checkInputConnectionProxy", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool CheckInputConnectionProxy(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Show the context menu for this view. It is not safe to hold on to the menu after returning from this method.</para> <para>You should normally not overload this method. Overload onCreateContextMenu(ContextMenu) or define an OnCreateContextMenuListener to add items to the context menu.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// createContextMenu
				/// </java-name>
				[Dot42.DexImport("createContextMenu", "(Landroid/view/ContextMenu;)V", AccessFlags = 1)]
				public virtual void CreateContextMenu(global::Android.Views.IContextMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Views should implement this if the view itself is going to add items to the context menu.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onCreateContextMenu
				/// </java-name>
				[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;)V", AccessFlags = 4)]
				protected internal virtual void OnCreateContextMenu(global::Android.Views.IContextMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement this method to handle trackball motion events. The  <b>relative</b> movement of the trackball since the last event can be retrieve with MotionEvent.getX() and MotionEvent.getY(). These are normalized so that a movement of 1 corresponds to the user pressing one DPAD key (so they will often be fractional values, representing the more fine-grained movement information available from a trackball).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event was handled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onTrackballEvent
				/// </java-name>
				[Dot42.DexImport("onTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTrackballEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Implement this method to handle touch screen motion events. </para> <para>If this method is used to detect click actions, it is recommended that the actions be performed by implementing and calling performClick(). This will ensure consistent system behavior, including:  <ul> <li> <para>obeying click sound preferences </para></li> <li> <para>dispatching OnClickListener calls </para></li> <li> <para>handling ACTION_CLICK when accessibility features are enabled </para></li></ul></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the event was handled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// onTouchEvent
				/// </java-name>
				[Dot42.DexImport("onTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Cancels a pending long press. Your subclass can use this if you want the context menu to come up if the user presses and holds at the same place, but you don't want it to come up if they press and then move around enough to cause scrolling. </para>        
				/// </summary>
				/// <java-name>
				/// cancelLongPress
				/// </java-name>
				[Dot42.DexImport("cancelLongPress", "()V", AccessFlags = 1)]
				public virtual void CancelLongPress() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the view's z order in the tree, so it's on top of other sibling views. This ordering change may affect layout, if the parent container uses an order-dependent layout scheme (e.g., LinearLayout). Prior to android.os.Build.VERSION_CODES#KITKAT this method should be followed by calls to requestLayout() and View#invalidate() on the view's parent to force the parent to redraw with the new child ordering.</para> <para> <para>ViewGroup::bringChildToFront(View) </para></para>        
				/// </summary>
				/// <java-name>
				/// bringToFront
				/// </java-name>
				[Dot42.DexImport("bringToFront", "()V", AccessFlags = 1)]
				public virtual void BringToFront() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called in response to an internal scroll in this view (i.e., the view scrolled its own contents). This is typically as a result of scrollBy(int, int) or scrollTo(int, int) having been called.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onScrollChanged
				/// </java-name>
				[Dot42.DexImport("onScrollChanged", "(IIII)V", AccessFlags = 4)]
				protected internal virtual void OnScrollChanged(int l, int t, int oldl, int oldt) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called during layout when the size of this view has changed. If you were just added to the view hierarchy, you're called with the old values of 0.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onSizeChanged
				/// </java-name>
				[Dot42.DexImport("onSizeChanged", "(IIII)V", AccessFlags = 4)]
				protected internal virtual void OnSizeChanged(int w, int h, int oldw, int oldh) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by draw to draw the child views. This may be overridden by derived classes to gain control just before its children are drawn (but after its own view has been drawn). </para>        
				/// </summary>
				/// <java-name>
				/// dispatchDraw
				/// </java-name>
				[Dot42.DexImport("dispatchDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal virtual void DispatchDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Return the visible drawing bounds of your view. Fills in the output rectangle with the values from getScrollX(), getScrollY(), getWidth(), and getHeight(). These bounds do not account for any transformation properties currently set on the view, such as setScaleX(float) or setRotation(float).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getDrawingRect
				/// </java-name>
				[Dot42.DexImport("getDrawingRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetDrawingRect(global::Android.Graphics.Rect outRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Hit rectangle in parent's coordinates</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getHitRect
				/// </java-name>
				[Dot42.DexImport("getHitRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetHitRect(global::Android.Graphics.Rect outRect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>When a view has focus and the user navigates away from it, the next view is searched for starting from the rectangle filled in by this method.</para> <para>By default, the rectangle is the getDrawingRect(android.graphics.Rect)) of the view. However, if your view maintains some idea of internal selection, such as a cursor, or a selected row or column, you should override this method and fill in a more specific rectangle.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getFocusedRect
				/// </java-name>
				[Dot42.DexImport("getFocusedRect", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetFocusedRect(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>If some part of this view is not clipped by any of its parents, then return that area in r in global (root) coordinates. To convert r to local coordinates (without taking possible View rotations into account), offset it by -globalOffset (e.g. r.offset(-globalOffset.x, -globalOffset.y)). If the view is completely clipped or translated out, return false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if r is non-empty (i.e. part of the view is visible at the root level. </para>
				/// </returns>
				/// <java-name>
				/// getGlobalVisibleRect
				/// </java-name>
				[Dot42.DexImport("getGlobalVisibleRect", "(Landroid/graphics/Rect;Landroid/graphics/Point;)Z", AccessFlags = 1)]
				public virtual bool GetGlobalVisibleRect(global::Android.Graphics.Rect r, global::Android.Graphics.Point globalOffset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getGlobalVisibleRect
				/// </java-name>
				[Dot42.DexImport("getGlobalVisibleRect", "(Landroid/graphics/Rect;)Z", AccessFlags = 17)]
				public bool GetGlobalVisibleRect(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLocalVisibleRect
				/// </java-name>
				[Dot42.DexImport("getLocalVisibleRect", "(Landroid/graphics/Rect;)Z", AccessFlags = 17)]
				public bool GetLocalVisibleRect(global::Android.Graphics.Rect r) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Offset this view's vertical location by the specified number of pixels.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offsetTopAndBottom
				/// </java-name>
				[Dot42.DexImport("offsetTopAndBottom", "(I)V", AccessFlags = 1)]
				public virtual void OffsetTopAndBottom(int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset this view's horizontal location by the specified amount of pixels.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// offsetLeftAndRight
				/// </java-name>
				[Dot42.DexImport("offsetLeftAndRight", "(I)V", AccessFlags = 1)]
				public virtual void OffsetLeftAndRight(int offset) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the scrolled position of your view. This will cause a call to onScrollChanged(int, int, int, int) and the view will be invalidated. </para>        
				/// </summary>
				/// <java-name>
				/// scrollTo
				/// </java-name>
				[Dot42.DexImport("scrollTo", "(II)V", AccessFlags = 1)]
				public virtual void ScrollTo(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Move the scrolled position of your view. This will cause a call to onScrollChanged(int, int, int, int) and the view will be invalidated. </para>        
				/// </summary>
				/// <java-name>
				/// scrollBy
				/// </java-name>
				[Dot42.DexImport("scrollBy", "(II)V", AccessFlags = 1)]
				public virtual void ScrollBy(int x, int y) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Trigger the scrollbars to draw. When invoked this method starts an animation to fade the scrollbars out after a default delay. If a subclass provides animated scrolling, the start delay should equal the duration of the scrolling animation.</para> <para>The animation starts only if at least one of the scrollbars is enabled, as specified by isHorizontalScrollBarEnabled() and isVerticalScrollBarEnabled(). When the animation is started, this method returns true, and false otherwise. If the animation is started, this method calls invalidate(); in that case the caller should not call invalidate().</para> <para>This method should be invoked every time a subclass directly updates the scroll parameters.</para> <para>This method is automatically invoked by scrollBy(int, int) and scrollTo(int, int).</para> <para> <para>awakenScrollBars(int) </para> <para>scrollBy(int, int) </para> <para>scrollTo(int, int) </para> <para>isHorizontalScrollBarEnabled() </para> <para>isVerticalScrollBarEnabled() </para> <para>setHorizontalScrollBarEnabled(boolean) </para> <para>setVerticalScrollBarEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the animation is played, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// awakenScrollBars
				/// </java-name>
				[Dot42.DexImport("awakenScrollBars", "()Z", AccessFlags = 4)]
				protected internal virtual bool AwakenScrollBars() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Trigger the scrollbars to draw. When invoked this method starts an animation to fade the scrollbars out after a fixed delay. If a subclass provides animated scrolling, the start delay should equal the duration of the scrolling animation. </para> <para>The animation starts only if at least one of the scrollbars is enabled, as specified by isHorizontalScrollBarEnabled() and isVerticalScrollBarEnabled(). When the animation is started, this method returns true, and false otherwise. If the animation is started, this method calls invalidate(); in that case the caller should not call invalidate(). </para> <para>This method should be invoked everytime a subclass directly updates the scroll parameters. </para> <para> <para>scrollBy(int, int) </para> <para>scrollTo(int, int) </para> <para>isHorizontalScrollBarEnabled() </para> <para>isVerticalScrollBarEnabled() </para> <para>setHorizontalScrollBarEnabled(boolean) </para> <para>setVerticalScrollBarEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the animation is played, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// awakenScrollBars
				/// </java-name>
				[Dot42.DexImport("awakenScrollBars", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool AwakenScrollBars(int startDelay) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Trigger the scrollbars to draw. When invoked this method starts an animation to fade the scrollbars out after a fixed delay. If a subclass provides animated scrolling, the start delay should equal the duration of the scrolling animation. </para> <para>The animation starts only if at least one of the scrollbars is enabled, as specified by isHorizontalScrollBarEnabled() and isVerticalScrollBarEnabled(). When the animation is started, this method returns true, and false otherwise. If the animation is started, this method calls invalidate() if the invalidate parameter is set to true; in that case the caller should not call invalidate(). </para> <para>This method should be invoked everytime a subclass directly updates the scroll parameters. </para> <para> <para>scrollBy(int, int) </para> <para>scrollTo(int, int) </para> <para>isHorizontalScrollBarEnabled() </para> <para>isVerticalScrollBarEnabled() </para> <para>setHorizontalScrollBarEnabled(boolean) </para> <para>setVerticalScrollBarEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the animation is played, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// awakenScrollBars
				/// </java-name>
				[Dot42.DexImport("awakenScrollBars", "(IZ)Z", AccessFlags = 4)]
				protected internal virtual bool AwakenScrollBars(int startDelay, bool invalidate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Mark the area defined by dirty as needing to be drawn. If the view is visible, onDraw(android.graphics.Canvas) will be called at some point in the future. This must be called from a UI thread. To call from a non-UI thread, call postInvalidate().</para> <para>WARNING: This method is destructive to dirty. </para>        
				/// </summary>
				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void Invalidate(global::Android.Graphics.Rect dirty) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Mark the area defined by the rect (l,t,r,b) as needing to be drawn. The coordinates of the dirty rect are relative to the view. If the view is visible, onDraw(android.graphics.Canvas) will be called at some point in the future. This must be called from a UI thread. To call from a non-UI thread, call postInvalidate(). </para>        
				/// </summary>
				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "(IIII)V", AccessFlags = 1)]
				public virtual void Invalidate(int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invalidate the whole view. If the view is visible, onDraw(android.graphics.Canvas) will be called at some point in the future. This must be called from a UI thread. To call from a non-UI thread, call postInvalidate(). </para>        
				/// </summary>
				/// <java-name>
				/// invalidate
				/// </java-name>
				[Dot42.DexImport("invalidate", "()V", AccessFlags = 1)]
				public virtual void Invalidate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Causes the Runnable to be added to the message queue. The runnable will be run on the user interface thread.</para> <para> <para>postDelayed </para> <para>removeCallbacks </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the Runnable was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting.</para>
				/// </returns>
				/// <java-name>
				/// post
				/// </java-name>
				[Dot42.DexImport("post", "(Ljava/lang/Runnable;)Z", AccessFlags = 1)]
				public virtual bool Post(global::Java.Lang.IRunnable action) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Causes the Runnable to be added to the message queue, to be run after the specified amount of time elapses. The runnable will be run on the user interface thread.</para> <para> <para>post </para> <para>removeCallbacks </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the Runnable was successfully placed in to the message queue. Returns false on failure, usually because the looper processing the message queue is exiting. Note that a result of true does not mean the Runnable will be processed  if the looper is quit before the delivery time of the message occurs then the message will be dropped.</para>
				/// </returns>
				/// <java-name>
				/// postDelayed
				/// </java-name>
				[Dot42.DexImport("postDelayed", "(Ljava/lang/Runnable;J)Z", AccessFlags = 1)]
				public virtual bool PostDelayed(global::Java.Lang.IRunnable action, long delayMillis) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Removes the specified Runnable from the message queue.</para> <para> <para>post </para> <para>postDelayed </para> <para>postOnAnimation </para> <para>postOnAnimationDelayed </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this view could ask the Handler to remove the Runnable, false otherwise. When the returned value is true, the Runnable may or may not have been actually removed from the message queue (for instance, if the Runnable was not in the queue already.)</para>
				/// </returns>
				/// <java-name>
				/// removeCallbacks
				/// </java-name>
				[Dot42.DexImport("removeCallbacks", "(Ljava/lang/Runnable;)Z", AccessFlags = 1)]
				public virtual bool RemoveCallbacks(global::Java.Lang.IRunnable action) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Cause an invalidate to happen on a subsequent cycle through the event loop. Use this to invalidate the View from a non-UI thread.</para> <para>This method can be invoked from outside of the UI thread only when this View is attached to a window.</para> <para> <para>invalidate() </para> <para>postInvalidateDelayed(long) </para></para>        
				/// </summary>
				/// <java-name>
				/// postInvalidate
				/// </java-name>
				[Dot42.DexImport("postInvalidate", "()V", AccessFlags = 1)]
				public virtual void PostInvalidate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cause an invalidate of the specified area to happen on a subsequent cycle through the event loop. Use this to invalidate the View from a non-UI thread.</para> <para>This method can be invoked from outside of the UI thread only when this View is attached to a window.</para> <para> <para>invalidate(int, int, int, int) </para> <para>invalidate(Rect) </para> <para>postInvalidateDelayed(long, int, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// postInvalidate
				/// </java-name>
				[Dot42.DexImport("postInvalidate", "(IIII)V", AccessFlags = 1)]
				public virtual void PostInvalidate(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cause an invalidate to happen on a subsequent cycle through the event loop. Waits for the specified amount of time.</para> <para>This method can be invoked from outside of the UI thread only when this View is attached to a window.</para> <para> <para>invalidate() </para> <para>postInvalidate() </para></para>        
				/// </summary>
				/// <java-name>
				/// postInvalidateDelayed
				/// </java-name>
				[Dot42.DexImport("postInvalidateDelayed", "(J)V", AccessFlags = 1)]
				public virtual void PostInvalidateDelayed(long delayMilliseconds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cause an invalidate of the specified area to happen on a subsequent cycle through the event loop. Waits for the specified amount of time.</para> <para>This method can be invoked from outside of the UI thread only when this View is attached to a window.</para> <para> <para>invalidate(int, int, int, int) </para> <para>invalidate(Rect) </para> <para>postInvalidate(int, int, int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// postInvalidateDelayed
				/// </java-name>
				[Dot42.DexImport("postInvalidateDelayed", "(JIIII)V", AccessFlags = 1)]
				public virtual void PostInvalidateDelayed(long delayMilliseconds, int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by a parent to request that a child update its values for mScrollX and mScrollY if necessary. This will typically be done if the child is animating a scroll using a Scroller object. </para>        
				/// </summary>
				/// <java-name>
				/// computeScroll
				/// </java-name>
				[Dot42.DexImport("computeScroll", "()V", AccessFlags = 1)]
				public virtual void ComputeScroll() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Compute the horizontal range that the horizontal scrollbar represents.</para> <para>The range is expressed in arbitrary units that must be the same as the units used by computeHorizontalScrollExtent() and computeHorizontalScrollOffset().</para> <para>The default range is the drawing width of this view.</para> <para> <para>computeHorizontalScrollExtent() </para> <para>computeHorizontalScrollOffset() </para> <para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the total horizontal range represented by the horizontal scrollbar</para>
				/// </returns>
				/// <java-name>
				/// computeHorizontalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollRange", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeHorizontalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compute the horizontal offset of the horizontal scrollbar's thumb within the horizontal range. This value is used to compute the position of the thumb within the scrollbar's track.</para> <para>The range is expressed in arbitrary units that must be the same as the units used by computeHorizontalScrollRange() and computeHorizontalScrollExtent().</para> <para>The default offset is the scroll offset of this view.</para> <para> <para>computeHorizontalScrollRange() </para> <para>computeHorizontalScrollExtent() </para> <para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the horizontal offset of the scrollbar's thumb</para>
				/// </returns>
				/// <java-name>
				/// computeHorizontalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollOffset", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeHorizontalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compute the horizontal extent of the horizontal scrollbar's thumb within the horizontal range. This value is used to compute the length of the thumb within the scrollbar's track.</para> <para>The range is expressed in arbitrary units that must be the same as the units used by computeHorizontalScrollRange() and computeHorizontalScrollOffset().</para> <para>The default extent is the drawing width of this view.</para> <para> <para>computeHorizontalScrollRange() </para> <para>computeHorizontalScrollOffset() </para> <para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the horizontal extent of the scrollbar's thumb</para>
				/// </returns>
				/// <java-name>
				/// computeHorizontalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeHorizontalScrollExtent", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeHorizontalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compute the vertical range that the vertical scrollbar represents.</para> <para>The range is expressed in arbitrary units that must be the same as the units used by computeVerticalScrollExtent() and computeVerticalScrollOffset().</para> <para></para> <para>The default range is the drawing height of this view.</para> <para> <para>computeVerticalScrollExtent() </para> <para>computeVerticalScrollOffset() </para> <para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the total vertical range represented by the vertical scrollbar</para>
				/// </returns>
				/// <java-name>
				/// computeVerticalScrollRange
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollRange", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeVerticalScrollRange() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compute the vertical offset of the vertical scrollbar's thumb within the horizontal range. This value is used to compute the position of the thumb within the scrollbar's track.</para> <para>The range is expressed in arbitrary units that must be the same as the units used by computeVerticalScrollRange() and computeVerticalScrollExtent().</para> <para>The default offset is the scroll offset of this view.</para> <para> <para>computeVerticalScrollRange() </para> <para>computeVerticalScrollExtent() </para> <para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the vertical offset of the scrollbar's thumb</para>
				/// </returns>
				/// <java-name>
				/// computeVerticalScrollOffset
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollOffset", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeVerticalScrollOffset() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Compute the vertical extent of the horizontal scrollbar's thumb within the vertical range. This value is used to compute the length of the thumb within the scrollbar's track.</para> <para>The range is expressed in arbitrary units that must be the same as the units used by computeVerticalScrollRange() and computeVerticalScrollOffset().</para> <para>The default extent is the drawing height of this view.</para> <para> <para>computeVerticalScrollRange() </para> <para>computeVerticalScrollOffset() </para> <para>android.widget.ScrollBarDrawable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the vertical extent of the scrollbar's thumb</para>
				/// </returns>
				/// <java-name>
				/// computeVerticalScrollExtent
				/// </java-name>
				[Dot42.DexImport("computeVerticalScrollExtent", "()I", AccessFlags = 4)]
				protected internal virtual int ComputeVerticalScrollExtent() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Request the drawing of the horizontal and the vertical scrollbar. The scrollbars are painted only if they have been awakened first.</para> <para> <para>awakenScrollBars(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// onDrawScrollBars
				/// </java-name>
				[Dot42.DexImport("onDrawScrollBars", "(Landroid/graphics/Canvas;)V", AccessFlags = 20)]
				protected internal void OnDrawScrollBars(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement this to do your drawing.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onDraw
				/// </java-name>
				[Dot42.DexImport("onDraw", "(Landroid/graphics/Canvas;)V", AccessFlags = 4)]
				protected internal virtual void OnDraw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when the view is attached to a window. At this point it has a Surface and will start drawing. Note that this function is guaranteed to be called before onDraw(android.graphics.Canvas), however it may be called any time before the first onDraw  including before or after onMeasure(int, int).</para> <para> <para>onDetachedFromWindow() </para></para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 4)]
				protected internal virtual void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called when the view is detached from a window. At this point it no longer has a surface for drawing.</para> <para> <para>onAttachedToWindow() </para></para>        
				/// </summary>
				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 4)]
				protected internal virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Store this view hierarchy's frozen state into the given container.</para> <para> <para>restoreHierarchyState(android.util.SparseArray) </para> <para>dispatchSaveInstanceState(android.util.SparseArray) </para> <para>onSaveInstanceState() </para></para>        
				/// </summary>
				/// <java-name>
				/// saveHierarchyState
				/// </java-name>
				[Dot42.DexImport("saveHierarchyState", "(Landroid/util/SparseArray;)V", AccessFlags = 1, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				public virtual void SaveHierarchyState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by saveHierarchyState(android.util.SparseArray) to store the state for this view and its children. May be overridden to modify how freezing happens to a view's children; for example, some views may want to not store state for their children.</para> <para> <para>dispatchRestoreInstanceState(android.util.SparseArray) </para> <para>saveHierarchyState(android.util.SparseArray) </para> <para>onSaveInstanceState() </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal virtual void DispatchSaveInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Hook allowing a view to generate a representation of its internal state that can later be used to create a new instance with that same state. This state should only contain information that is not persistent or can not be reconstructed later. For example, you will never store your current position on screen because that will be computed again when a new instance of the view is placed in its view hierarchy. </para> <para>Some examples of things you may store here: the current cursor position in a text view (but usually not the text itself since that is stored in a content provider or other persistent storage), the currently selected item in a list view.</para> <para> <para>onRestoreInstanceState(android.os.Parcelable) </para> <para>saveHierarchyState(android.util.SparseArray) </para> <para>dispatchSaveInstanceState(android.util.SparseArray) </para> <para>setSaveEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns a Parcelable object containing the view's current dynamic state, or null if there is nothing interesting to save. The default implementation returns null. </para>
				/// </returns>
				/// <java-name>
				/// onSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("onSaveInstanceState", "()Landroid/os/Parcelable;", AccessFlags = 4)]
				protected internal virtual global::Android.OS.IParcelable OnSaveInstanceState() /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IParcelable);
				}

				/// <summary>
				///  <para>Restore this view hierarchy's frozen state from the given container.</para> <para> <para>saveHierarchyState(android.util.SparseArray) </para> <para>dispatchRestoreInstanceState(android.util.SparseArray) </para> <para>onRestoreInstanceState(android.os.Parcelable) </para></para>        
				/// </summary>
				/// <java-name>
				/// restoreHierarchyState
				/// </java-name>
				[Dot42.DexImport("restoreHierarchyState", "(Landroid/util/SparseArray;)V", AccessFlags = 1, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				public virtual void RestoreHierarchyState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by restoreHierarchyState(android.util.SparseArray) to retrieve the state for this view and its children. May be overridden to modify how restoring happens to a view's children; for example, some views may want to not store state for their children.</para> <para> <para>dispatchSaveInstanceState(android.util.SparseArray) </para> <para>restoreHierarchyState(android.util.SparseArray) </para> <para>onRestoreInstanceState(android.os.Parcelable) </para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal virtual void DispatchRestoreInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Hook allowing a view to re-apply a representation of its internal state that had previously been generated by onSaveInstanceState. This function will never be called with a null state.</para> <para> <para>onSaveInstanceState() </para> <para>restoreHierarchyState(android.util.SparseArray) </para> <para>dispatchRestoreInstanceState(android.util.SparseArray) </para></para>        
				/// </summary>
				/// <java-name>
				/// onRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", AccessFlags = 4)]
				protected internal virtual void OnRestoreInstanceState(global::Android.OS.IParcelable state) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the bitmap in which this view drawing is cached. The returned bitmap is null when caching is disabled. If caching is enabled and the cache is not ready, this method will create it. Calling draw(android.graphics.Canvas) will not draw from the cache when the cache is enabled. To benefit from the cache, you must request the drawing cache by calling this method and draw it on screen if the returned bitmap is not null.</para> <para>Note about auto scaling in compatibility mode: When auto scaling is not enabled, this method will create a bitmap of the same size as this view. Because this bitmap will be drawn scaled by the parent ViewGroup, the result on screen might show scaling artifacts. To avoid such artifacts, you should call this method by setting the auto scaling to true. Doing so, however, will generate a bitmap of a different size than the view. This implies that your application must be able to handle this size.</para> <para> <para>setDrawingCacheEnabled(boolean) </para> <para>isDrawingCacheEnabled() </para> <para>buildDrawingCache(boolean) </para> <para>destroyDrawingCache() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A bitmap representing this view or null if cache is disabled.</para>
				/// </returns>
				/// <java-name>
				/// getDrawingCache
				/// </java-name>
				[Dot42.DexImport("getDrawingCache", "(Z)Landroid/graphics/Bitmap;", AccessFlags = 1)]
				public virtual global::Android.Graphics.Bitmap GetDrawingCache(bool autoScale) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Bitmap);
				}

				/// <summary>
				///  <para>Frees the resources used by the drawing cache. If you call buildDrawingCache() manually without calling setDrawingCacheEnabled(true), you should cleanup the cache with this method afterwards.</para> <para> <para>setDrawingCacheEnabled(boolean) </para> <para>buildDrawingCache() </para> <para>getDrawingCache() </para></para>        
				/// </summary>
				/// <java-name>
				/// destroyDrawingCache
				/// </java-name>
				[Dot42.DexImport("destroyDrawingCache", "()V", AccessFlags = 1)]
				public virtual void DestroyDrawingCache() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Calling this method is equivalent to calling  <code>buildDrawingCache(false)</code>.</para> <para> <para>buildDrawingCache(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// buildDrawingCache
				/// </java-name>
				[Dot42.DexImport("buildDrawingCache", "()V", AccessFlags = 1)]
				public virtual void BuildDrawingCache() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Forces the drawing cache to be built if the drawing cache is invalid.</para> <para>If you call buildDrawingCache() manually without calling setDrawingCacheEnabled(true), you should cleanup the cache by calling destroyDrawingCache() afterwards.</para> <para>Note about auto scaling in compatibility mode: When auto scaling is not enabled, this method will create a bitmap of the same size as this view. Because this bitmap will be drawn scaled by the parent ViewGroup, the result on screen might show scaling artifacts. To avoid such artifacts, you should call this method by setting the auto scaling to true. Doing so, however, will generate a bitmap of a different size than the view. This implies that your application must be able to handle this size.</para> <para>You should avoid calling this method when hardware acceleration is enabled. If you do not need the drawing cache bitmap, calling this method will increase memory usage and cause the view to be rendered in software once, thus negatively impacting performance.</para> <para> <para>getDrawingCache() </para> <para>destroyDrawingCache() </para></para>        
				/// </summary>
				/// <java-name>
				/// buildDrawingCache
				/// </java-name>
				[Dot42.DexImport("buildDrawingCache", "(Z)V", AccessFlags = 1)]
				public virtual void BuildDrawingCache(bool autoScale) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Manually render this view (and all of its children) to the given Canvas. The view must have already done a full layout before this function is called. When implementing a view, implement onDraw(android.graphics.Canvas) instead of overriding this method. If you do need to override this method, call the superclass version.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// draw
				/// </java-name>
				[Dot42.DexImport("draw", "(Landroid/graphics/Canvas;)V", AccessFlags = 1)]
				public virtual void Draw(global::Android.Graphics.Canvas canvas) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Assign a size and position to a view and all of its descendants</para> <para>This is the second phase of the layout mechanism. (The first is measuring). In this phase, each parent calls layout on all of its children to position them. This is typically done using the child measurements that were stored in the measure pass().</para> <para>Derived classes should not override this method. Derived classes with children should override onLayout. In that method, they should call layout on each of their children.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// layout
				/// </java-name>
				[Dot42.DexImport("layout", "(IIII)V", AccessFlags = 17)]
				public void Layout(int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called from layout when this view should assign a size and position to each of its children.</para> <para>Derived classes with children should override this method and call layout on each of their children. </para>        
				/// </summary>
				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 4)]
				protected internal virtual void OnLayout(bool changed, int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Finalize inflating a view from XML. This is called as the last phase of inflation, after all child views have been added.</para> <para>Even if the subclass overrides onFinishInflate, they should always be sure to call the super method, so that we get called. </para>        
				/// </summary>
				/// <java-name>
				/// onFinishInflate
				/// </java-name>
				[Dot42.DexImport("onFinishInflate", "()V", AccessFlags = 4)]
				protected internal virtual void OnFinishInflate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invalidates the specified Drawable.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// invalidateDrawable
				/// </java-name>
				[Dot42.DexImport("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void InvalidateDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Schedules an action on a drawable to occur at a specified time.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// scheduleDrawable
				/// </java-name>
				[Dot42.DexImport("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", AccessFlags = 1)]
				public virtual void ScheduleDrawable(global::Android.Graphics.Drawables.Drawable who, global::Java.Lang.IRunnable what, long when) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancels a scheduled action on a drawable.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawables.Drawable who, global::Java.Lang.IRunnable what) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unschedule any events associated with the given Drawable. This can be used when selecting a new Drawable into a view, so that the previous one is completely unscheduled.</para> <para> <para>drawableStateChanged </para></para>        
				/// </summary>
				/// <java-name>
				/// unscheduleDrawable
				/// </java-name>
				[Dot42.DexImport("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void UnscheduleDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>If your view subclass is displaying its own Drawable objects, it should override this function and return true for any Drawable it is displaying. This allows animations for those drawables to be scheduled.</para> <para>Be sure to call through to the super class when overriding this function.</para> <para> <para>unscheduleDrawable(android.graphics.drawable.Drawable) </para> <para>drawableStateChanged() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>boolean If true than the Drawable is being displayed in the view; else false and it is not allowed to animate.</para>
				/// </returns>
				/// <java-name>
				/// verifyDrawable
				/// </java-name>
				[Dot42.DexImport("verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", AccessFlags = 4)]
				protected internal virtual bool VerifyDrawable(global::Android.Graphics.Drawables.Drawable who) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>This function is called whenever the state of the view changes in such a way that it impacts the state of drawables being shown.</para> <para>Be sure to call through to the superclass when overriding this function.</para> <para> <para>Drawable::setState(int[]) </para></para>        
				/// </summary>
				/// <java-name>
				/// drawableStateChanged
				/// </java-name>
				[Dot42.DexImport("drawableStateChanged", "()V", AccessFlags = 4)]
				protected internal virtual void DrawableStateChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this to force a view to update its drawable state. This will cause drawableStateChanged to be called on this view. Views that are interested in the new state should call getDrawableState.</para> <para> <para>drawableStateChanged </para> <para>getDrawableState </para></para>        
				/// </summary>
				/// <java-name>
				/// refreshDrawableState
				/// </java-name>
				[Dot42.DexImport("refreshDrawableState", "()V", AccessFlags = 1)]
				public virtual void RefreshDrawableState() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Generate the new android.graphics.drawable.Drawable state for this view. This is called by the view system when the cached Drawable state is determined to be invalid. To retrieve the current state, you should use getDrawableState.</para> <para> <para>mergeDrawableStates(int[], int[]) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns an array holding the current Drawable state of the view.</para>
				/// </returns>
				/// <java-name>
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal virtual int[] OnCreateDrawableState(int extraSpace) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Merge your own state values in  <b>additionalState</b> into the base state values  <b>baseState</b> that were returned by onCreateDrawableState(int).</para> <para> <para>onCreateDrawableState(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>As a convenience, the  <b>baseState</b> array you originally passed into the function is returned.</para>
				/// </returns>
				/// <java-name>
				/// mergeDrawableStates
				/// </java-name>
				[Dot42.DexImport("mergeDrawableStates", "([I[I)[I", AccessFlags = 12)]
				protected internal static int[] MergeDrawableStates(int[] baseState, int[] additionalState) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Sets the background color for this view. </para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundColor
				/// </java-name>
				[Dot42.DexImport("setBackgroundColor", "(I)V", AccessFlags = 1)]
				public virtual void SetBackgroundColor(int color) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the background to a given resource. The resource should refer to a Drawable object or 0 to remove the background. ref android.R.styleable::View_background </para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundResource
				/// </java-name>
				[Dot42.DexImport("setBackgroundResource", "(I)V", AccessFlags = 1)]
				public virtual void SetBackgroundResource(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>use setBackground(Drawable) instead </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1)]
				public virtual void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable background) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the padding. The view may add on the space required to display the scrollbars, depending on the style and visibility of the scrollbars. So the values returned from getPaddingLeft, getPaddingTop, getPaddingRight and getPaddingBottom may be different from the values set in this call.</para> <para>ref android.R.styleable::View_padding  ref android.R.styleable::View_paddingBottom  ref android.R.styleable::View_paddingLeft  ref android.R.styleable::View_paddingRight  ref android.R.styleable::View_paddingTop </para>        
				/// </summary>
				/// <java-name>
				/// setPadding
				/// </java-name>
				[Dot42.DexImport("setPadding", "(IIII)V", AccessFlags = 1)]
				public virtual void SetPadding(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dispatch setSelected to all of this View's children.</para> <para> <para>setSelected(boolean)</para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchSetSelected
				/// </java-name>
				[Dot42.DexImport("dispatchSetSelected", "(Z)V", AccessFlags = 4)]
				protected internal virtual void DispatchSetSelected(bool selected) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes the coordinates of this view on the screen. The argument must be an array of two integers. After the method returns, the array contains the x and y location in that order.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getLocationOnScreen
				/// </java-name>
				[Dot42.DexImport("getLocationOnScreen", "([I)V", AccessFlags = 1)]
				public virtual void GetLocationOnScreen(int[] location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Computes the coordinates of this view in its window. The argument must be an array of two integers. After the method returns, the array contains the x and y location in that order.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getLocationInWindow
				/// </java-name>
				[Dot42.DexImport("getLocationInWindow", "([I)V", AccessFlags = 1)]
				public virtual void GetLocationInWindow(int[] location) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Look for a child view with the given id. If this view has the given id, return this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The view that has the given id in the hierarchy or null </para>
				/// </returns>
				/// <java-name>
				/// findViewById
				/// </java-name>
				[Dot42.DexImport("findViewById", "(I)Landroid/view/View;", AccessFlags = 17)]
				public global::Android.Views.View FindViewById(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Look for a child view with the given tag. If this view has the given tag, return this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The View that has the given tag in the hierarchy or null </para>
				/// </returns>
				/// <java-name>
				/// findViewWithTag
				/// </java-name>
				[Dot42.DexImport("findViewWithTag", "(Ljava/lang/Object;)Landroid/view/View;", AccessFlags = 17)]
				public global::Android.Views.View FindViewWithTag(object tag) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Returns the tag associated with this view and the specified key.</para> <para> <para>#setTag(int, Object) </para> <para>getTag() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Object stored in this view as a tag</para>
				/// </returns>
				/// <java-name>
				/// getTag
				/// </java-name>
				[Dot42.DexImport("getTag", "(I)Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object GetTag(int key) /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <summary>
				///  <para>Sets a tag associated with this view and a key. A tag can be used to mark a view in its hierarchy and does not have to be unique within the hierarchy. Tags can also be used to store data within a view without resorting to another data structure.</para> <para>The specified key should be an id declared in the resources of the application to ensure it is unique (see the &lt;a href={}guide/topics/resources/more-resources.html#Id"&gt;ID resource type). Keys identified as belonging to the Android framework or not associated with any package will cause an IllegalArgumentException to be thrown.</para> <para> <para>#setTag(Object) </para> <para>getTag(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setTag
				/// </java-name>
				[Dot42.DexImport("setTag", "(ILjava/lang/Object;)V", AccessFlags = 1)]
				public virtual void SetTag(int key, object tag) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this when something has changed which has invalidated the layout of this view. This will schedule a layout pass of the view tree. This should not be called while the view hierarchy is currently in a layout pass (isInLayout(). If layout is happening, the request may be honored at the end of the current layout pass (and then layout will run again) or after the current frame is drawn and the next layout occurs.</para> <para>Subclasses which override this method should call the superclass method to handle possible request-during-layout errors correctly.</para>        
				/// </summary>
				/// <java-name>
				/// requestLayout
				/// </java-name>
				[Dot42.DexImport("requestLayout", "()V", AccessFlags = 1)]
				public virtual void RequestLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Forces this view to be laid out during the next layout pass. This method does not call requestLayout() or forceLayout() on the parent. </para>        
				/// </summary>
				/// <java-name>
				/// forceLayout
				/// </java-name>
				[Dot42.DexImport("forceLayout", "()V", AccessFlags = 1)]
				public virtual void ForceLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This is called to find out how big a view should be. The parent supplies constraint information in the width and height parameters. </para> <para>The actual measurement work of a view is performed in onMeasure(int, int), called by this method. Therefore, only onMeasure(int, int) can and must be overridden by subclasses. </para> <para> <para>onMeasure(int, int) </para></para>        
				/// </summary>
				/// <java-name>
				/// measure
				/// </java-name>
				[Dot42.DexImport("measure", "(II)V", AccessFlags = 17)]
				public void Measure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Measure the view and its content to determine the measured width and the measured height. This method is invoked by measure(int, int) and should be overriden by subclasses to provide accurate and efficient measurement of their contents. </para> <para> <b>CONTRACT:</b> When overriding this method, you  <b>must</b> call setMeasuredDimension(int, int) to store the measured width and height of this view. Failure to do so will trigger an  <code>IllegalStateException</code>, thrown by measure(int, int). Calling the superclass' onMeasure(int, int) is a valid use. </para> <para>The base class implementation of measure defaults to the background size, unless a larger size is allowed by the MeasureSpec. Subclasses should override onMeasure(int, int) to provide better measurements of their content. </para> <para>If this method is overridden, it is the subclass's responsibility to make sure the measured height and width are at least the view's minimum height and width (getSuggestedMinimumHeight() and getSuggestedMinimumWidth()). </para> <para> <para>getMeasuredWidth() </para> <para>getMeasuredHeight() </para> <para>setMeasuredDimension(int, int) </para> <para>getSuggestedMinimumHeight() </para> <para>getSuggestedMinimumWidth() </para> <para>android.view.View.MeasureSpec::getMode(int) </para> <para>android.view.View.MeasureSpec::getSize(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal virtual void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>This method must be called by onMeasure(int, int) to store the measured width and measured height. Failing to do so will trigger an exception at measurement time.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setMeasuredDimension
				/// </java-name>
				[Dot42.DexImport("setMeasuredDimension", "(II)V", AccessFlags = 20)]
				protected internal void SetMeasuredDimension(int measuredWidth, int measuredHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Version of resolveSizeAndState(int, int, int) returning only the MEASURED_SIZE_MASK bits of the result. </para>        
				/// </summary>
				/// <java-name>
				/// resolveSize
				/// </java-name>
				[Dot42.DexImport("resolveSize", "(II)I", AccessFlags = 9)]
				public static int ResolveSize(int size, int measureSpec) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Utility to return a default size. Uses the supplied size if the MeasureSpec imposed no constraints. Will get larger if allowed by the MeasureSpec.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The size this view should be. </para>
				/// </returns>
				/// <java-name>
				/// getDefaultSize
				/// </java-name>
				[Dot42.DexImport("getDefaultSize", "(II)I", AccessFlags = 9)]
				public static int GetDefaultSize(int size, int measureSpec) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Sets the minimum height of the view. It is not guaranteed the view will be able to achieve this minimum height (for example, if its parent layout constrains it with less available height).</para> <para> <para>getMinimumHeight()</para>ref android.R.styleable::View_minHeight </para>        
				/// </summary>
				/// <java-name>
				/// setMinimumHeight
				/// </java-name>
				[Dot42.DexImport("setMinimumHeight", "(I)V", AccessFlags = 1)]
				public virtual void SetMinimumHeight(int minHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets the minimum width of the view. It is not guaranteed the view will be able to achieve this minimum width (for example, if its parent layout constrains it with less available width).</para> <para> <para>getMinimumWidth()</para>ref android.R.styleable::View_minWidth </para>        
				/// </summary>
				/// <java-name>
				/// setMinimumWidth
				/// </java-name>
				[Dot42.DexImport("setMinimumWidth", "(I)V", AccessFlags = 1)]
				public virtual void SetMinimumWidth(int minWidth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start the specified animation now.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// startAnimation
				/// </java-name>
				[Dot42.DexImport("startAnimation", "(Landroid/view/animation/Animation;)V", AccessFlags = 1)]
				public virtual void StartAnimation(global::Android.Views.Animations.Animation animation) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Cancels any animations for this view. </para>        
				/// </summary>
				/// <java-name>
				/// clearAnimation
				/// </java-name>
				[Dot42.DexImport("clearAnimation", "()V", AccessFlags = 1)]
				public virtual void ClearAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invoked by a parent ViewGroup to notify the start of the animation currently associated with this view. If you override this method, always call super.onAnimationStart();</para> <para> <para>setAnimation(android.view.animation.Animation) </para> <para>getAnimation() </para></para>        
				/// </summary>
				/// <java-name>
				/// onAnimationStart
				/// </java-name>
				[Dot42.DexImport("onAnimationStart", "()V", AccessFlags = 4)]
				protected internal virtual void OnAnimationStart() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invoked by a parent ViewGroup to notify the end of the animation currently associated with this view. If you override this method, always call super.onAnimationEnd();</para> <para> <para>setAnimation(android.view.animation.Animation) </para> <para>getAnimation() </para></para>        
				/// </summary>
				/// <java-name>
				/// onAnimationEnd
				/// </java-name>
				[Dot42.DexImport("onAnimationEnd", "()V", AccessFlags = 4)]
				protected internal virtual void OnAnimationEnd() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Invoked if there is a Transform that involves alpha. Subclass that can draw themselves with the specified alpha should return true, and then respect that alpha when their onDraw() is called. If this returns false then the view may be redirected to draw into an offscreen buffer to fulfill the request, which will look fine, but may be slower than if the subclass handles it internally. The default implementation returns false.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the view can draw with the specified alpha. </para>
				/// </returns>
				/// <java-name>
				/// onSetAlpha
				/// </java-name>
				[Dot42.DexImport("onSetAlpha", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool OnSetAlpha(int alpha) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Play a sound effect for this view.</para> <para>The framework will play sound effects for some built in actions, such as clicking, but you may wish to play these effects in your widget, for instance, for internal navigation.</para> <para>The sound effect will only be played if sound effects are enabled by the user, and isSoundEffectsEnabled() is true.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// playSoundEffect
				/// </java-name>
				[Dot42.DexImport("playSoundEffect", "(I)V", AccessFlags = 1)]
				public virtual void PlaySoundEffect(int soundConstant) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>BZZZTT!!1!</para> <para>Provide haptic feedback to the user for this view.</para> <para>The framework will provide haptic feedback for some built in actions, such as long presses, but you may wish to provide feedback for your own widget.</para> <para>The feedback will only be performed if isHapticFeedbackEnabled() is true.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// performHapticFeedback
				/// </java-name>
				[Dot42.DexImport("performHapticFeedback", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformHapticFeedback(int feedbackConstant) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>BZZZTT!!1!</para> <para>Like performHapticFeedback(int), with additional options.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// performHapticFeedback
				/// </java-name>
				[Dot42.DexImport("performHapticFeedback", "(II)Z", AccessFlags = 1)]
				public virtual bool PerformHapticFeedback(int feedbackConstant, int flags) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Inflate a view from an XML resource. This convenience method wraps the LayoutInflater class, which provides a full range of options for view inflation.</para> <para> <para>LayoutInflater </para></para>        
				/// </summary>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "(Landroid/content/Context;ILandroid/view/ViewGroup;)Landroid/view/View;", AccessFlags = 9)]
				public static global::Android.Views.View Inflate(global::Android.Content.Context context, int resource, global::Android.Views.ViewGroup root) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Scroll the view with standard behavior for scrolling beyond the normal content boundaries. Views that call this method should override onOverScrolled(int, int, boolean, boolean) to respond to the results of an over-scroll operation.</para> <para>Views can use this method to handle any touch or fling-based scrolling.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if scrolling was clamped to an over-scroll boundary along either axis, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// overScrollBy
				/// </java-name>
				[Dot42.DexImport("overScrollBy", "(IIIIIIIIZ)Z", AccessFlags = 4)]
				protected internal virtual bool OverScrollBy(int deltaX, int deltaY, int scrollX, int scrollY, int scrollRangeX, int scrollRangeY, int maxOverScrollX, int maxOverScrollY, bool isTouchEvent) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Called by overScrollBy(int, int, int, int, int, int, int, int, boolean) to respond to the results of an over-scroll operation.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onOverScrolled
				/// </java-name>
				[Dot42.DexImport("onOverScrolled", "(IIZZ)V", AccessFlags = 4)]
				protected internal virtual void OnOverScrolled(int scrollX, int scrollY, bool clampedX, bool clampedY) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal View() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the size of the vertical faded edges used to indicate that more content in this view is visible.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The size in pixels of the vertical faded edge or 0 if vertical faded edges are not enabled for this view.  ref android.R.styleable::View_fadingEdgeLength </para>
				/// </returns>
				/// <java-name>
				/// getVerticalFadingEdgeLength
				/// </java-name>
				public virtual int VerticalFadingEdgeLength
				{
						[Dot42.DexImport("getVerticalFadingEdgeLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the size of the horizontal faded edges used to indicate that more content in this view is visible.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The size in pixels of the horizontal faded edge or 0 if horizontal faded edges are not enabled for this view.  ref android.R.styleable::View_fadingEdgeLength </para>
				/// </returns>
				/// <java-name>
				/// getHorizontalFadingEdgeLength
				/// </java-name>
				public virtual int HorizontalFadingEdgeLength
				{
						[Dot42.DexImport("getHorizontalFadingEdgeLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the width of the vertical scrollbar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The width in pixels of the vertical scrollbar or 0 if there is no vertical scrollbar. </para>
				/// </returns>
				/// <java-name>
				/// getVerticalScrollbarWidth
				/// </java-name>
				public virtual int VerticalScrollbarWidth
				{
						[Dot42.DexImport("getVerticalScrollbarWidth", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the height of the horizontal scrollbar.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The height in pixels of the horizontal scrollbar or 0 if there is no horizontal scrollbar. </para>
				/// </returns>
				/// <java-name>
				/// getHorizontalScrollbarHeight
				/// </java-name>
				protected internal virtual int HorizontalScrollbarHeight
				{
						[Dot42.DexImport("getHorizontalScrollbarHeight", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the focus-change callback registered for this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The callback, or null if one is not registered. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns true if this view has focus iteself, or is the ancestor of the view that has focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this view has or contains focus, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// hasFocus
				/// </java-name>
				public virtual bool HasFocus
				{
						[Dot42.DexImport("hasFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns true if this view is focusable or if it contains a reachable View for which hasFocusable() returns true. A "reachable hasFocusable()" is a View whose parents do not block descendants focus.</para> <para>Only VISIBLE views are considered focusable.</para> <para> <para>ViewGroup::FOCUS_BLOCK_DESCENDANTS </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the view is focusable or if the view contains a focusable View, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// hasFocusable
				/// </java-name>
				public virtual bool HasFocusable
				{
						[Dot42.DexImport("hasFocusable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the View description. It briefly describes the view and is primarily used for accessibility support. Set this property to enable better accessibility support for your application. This is especially true for views that do not have textual representation (For example, ImageButton).</para> <para>ref android.R.styleable::View_contentDescription </para>        
				/// </summary>
				/// <returns>
				///  <para>The content description.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns true if this view has focus</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this view has focus, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isFocused
				/// </java-name>
				public virtual bool IsFocused
				{
						[Dot42.DexImport("isFocused", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the quality of the drawing cache.</para> <para> <para>setDrawingCacheQuality(int) </para> <para>setDrawingCacheEnabled(boolean) </para> <para>isDrawingCacheEnabled()</para>ref android.R.styleable::View_drawingCacheQuality </para>        
				/// </summary>
				/// <returns>
				///  <para>One of DRAWING_CACHE_QUALITY_AUTO, DRAWING_CACHE_QUALITY_LOW, or DRAWING_CACHE_QUALITY_HIGH</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns whether the screen should remain on, corresponding to the current value of KEEP_SCREEN_ON.</para> <para> <para>setKeepScreenOn(boolean)</para>ref android.R.styleable::View_keepScreenOn </para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if KEEP_SCREEN_ON is set.</para>
				/// </returns>
				/// <java-name>
				/// getKeepScreenOn
				/// </java-name>
				public virtual bool KeepScreenOn
				{
						[Dot42.DexImport("getKeepScreenOn", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setKeepScreenOn", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the id of the view to use when the next focus is FOCUS_LEFT. ref android.R.styleable::View_nextFocusLeft </para>        
				/// </summary>
				/// <returns>
				///  <para>The next focus ID, or NO_ID if the framework should decide automatically.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Gets the id of the view to use when the next focus is FOCUS_RIGHT. ref android.R.styleable::View_nextFocusRight </para>        
				/// </summary>
				/// <returns>
				///  <para>The next focus ID, or NO_ID if the framework should decide automatically.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Gets the id of the view to use when the next focus is FOCUS_UP. ref android.R.styleable::View_nextFocusUp </para>        
				/// </summary>
				/// <returns>
				///  <para>The next focus ID, or NO_ID if the framework should decide automatically.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Gets the id of the view to use when the next focus is FOCUS_DOWN. ref android.R.styleable::View_nextFocusDown </para>        
				/// </summary>
				/// <returns>
				///  <para>The next focus ID, or NO_ID if the framework should decide automatically.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the visibility of this view and all of its ancestors</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this view and all of its ancestors are VISIBLE </para>
				/// </returns>
				/// <java-name>
				/// isShown
				/// </java-name>
				public virtual bool IsShown
				{
						[Dot42.DexImport("isShown", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the visibility status for this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>One of VISIBLE, INVISIBLE, or GONE.  ref android.R.styleable::View_visibility </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the enabled status for this view. The interpretation of the enabled state varies by subclass.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this view is enabled, false otherwise. </para>
				/// </returns>
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

				/// <summary>
				///  <para> <para>setSoundEffectsEnabled(boolean) </para> <para>playSoundEffect(int)  ref android.R.styleable::View_soundEffectsEnabled </para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether this view should have sound effects enabled for events such as clicking and touching.</para>
				/// </returns>
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

				/// <summary>
				///  <para> <para>setHapticFeedbackEnabled(boolean) </para> <para>performHapticFeedback(int)  ref android.R.styleable::View_hapticFeedbackEnabled </para></para>        
				/// </summary>
				/// <returns>
				///  <para>whether this view should have haptic feedback enabled for events long presses.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether this view reacts to click events or not.</para> <para> <para>setClickable(boolean)  ref android.R.styleable::View_clickable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the view is clickable, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether this view reacts to long click events or not.</para> <para> <para>setLongClickable(boolean)  ref android.R.styleable::View_longClickable </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the view is long clickable, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether the view is currently in pressed state. Unless setPressed(boolean) is explicitly called, only clickable views can enter the pressed state.</para> <para> <para>setPressed(boolean) </para> <para>isClickable() </para> <para>setClickable(boolean)</para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the view is currently pressed, false otherwise </para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether this view will save its state (that is, whether its onSaveInstanceState method will be called).</para> <para> <para>setSaveEnabled(boolean)  ref android.R.styleable::View_saveEnabled </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the view state saving is enabled, else false.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Gets whether the framework should discard touches when the view's window is obscured by another visible window. Refer to the View security documentation for more details.</para> <para> <para>setFilterTouchesWhenObscured(boolean)  ref android.R.styleable::View_filterTouchesWhenObscured </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if touch filtering is enabled.</para>
				/// </returns>
				/// <java-name>
				/// getFilterTouchesWhenObscured
				/// </java-name>
				public virtual bool FilterTouchesWhenObscured
				{
						[Dot42.DexImport("getFilterTouchesWhenObscured", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFilterTouchesWhenObscured", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Returns whether this View is able to take focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this view can take focus, or false otherwise.  ref android.R.styleable::View_focusable </para>
				/// </returns>
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

				/// <summary>
				///  <para>When a view is focusable, it may not want to take focus when in touch mode. For example, a button would like focus when the user is navigating via a D-pad so that the user can click on it, but once the user starts touching the screen, the button shouldn't take focus </para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the view is focusable in touch mode.  ref android.R.styleable::View_focusableInTouchMode </para>
				/// </returns>
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

				/// <summary>
				///  <para>Find and return all touchable views that are descendants of this view, possibly including this view if it is touchable itself.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A list of touchable views </para>
				/// </returns>
				/// <java-name>
				/// getTouchables
				/// </java-name>
				public virtual global::Java.Util.ArrayList<global::Android.Views.View> Touchables
				{
						[Dot42.DexImport("getTouchables", "()Ljava/util/ArrayList;", AccessFlags = 1, Signature = "()Ljava/util/ArrayList<Landroid/view/View;>;")]
						get{ return default(global::Java.Util.ArrayList<global::Android.Views.View>); }
				}

				/// <summary>
				///  <para>Return the global KeyEvent.DispatcherState for this view's window. Returns null if the view is not currently attached to the window. Normally you will not need to use this directly, but just use the standard high-level event callbacks like onKeyDown(int, KeyEvent). </para>        
				/// </summary>
				/// <java-name>
				/// getKeyDispatcherState
				/// </java-name>
				public virtual global::Android.Views.KeyEvent.DispatcherState KeyDispatcherState
				{
						[Dot42.DexImport("getKeyDispatcherState", "()Landroid/view/KeyEvent$DispatcherState;", AccessFlags = 1)]
						get{ return default(global::Android.Views.KeyEvent.DispatcherState); }
				}

				/// <summary>
				///  <para>Returns true if this view is in a window that currently has window focus. Note that this is not the same as the view itself having focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this view is in a window that currently has window focus. </para>
				/// </returns>
				/// <java-name>
				/// hasWindowFocus
				/// </java-name>
				public virtual bool HasWindowFocus
				{
						[Dot42.DexImport("hasWindowFocus", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the current visibility of the window this view is attached to (either GONE, INVISIBLE, or VISIBLE).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the current visibility of the view's window. </para>
				/// </returns>
				/// <java-name>
				/// getWindowVisibility
				/// </java-name>
				public virtual int WindowVisibility
				{
						[Dot42.DexImport("getWindowVisibility", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns whether the device is currently in touch mode. Touch mode is entered once the user begins interacting with the device by touch, and affects various things like whether focus is always visible to the user.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the device is in touch mode. </para>
				/// </returns>
				/// <java-name>
				/// isInTouchMode
				/// </java-name>
				public virtual bool IsInTouchMode
				{
						[Dot42.DexImport("isInTouchMode", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the context the view is running in, through which it can access the current theme, resources, etc.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The view's Context. </para>
				/// </returns>
				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <summary>
				///  <para>Views should implement this if they have extra information to associate with the context menu. The return result is supplied as a parameter to the OnCreateContextMenuListener#onCreateContextMenu(ContextMenu, View, ContextMenuInfo) callback.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Extra information about the item for which the context menu should be shown. This information will vary across different subclasses of View. </para>
				/// </returns>
				/// <java-name>
				/// getContextMenuInfo
				/// </java-name>
				protected internal virtual global::Android.Views.IContextMenu_IContextMenuInfo ContextMenuInfo
				{
						[Dot42.DexImport("getContextMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", AccessFlags = 4)]
						get{ return default(global::Android.Views.IContextMenu_IContextMenuInfo); }
				}

				/// <summary>
				///  <para>Gets the TouchDelegate for this View. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Gets the parent of this view. Note that the parent is a ViewParent and not necessarily a View.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Parent of this view. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Android.Views.IViewParent Parent
				{
						[Dot42.DexImport("getParent", "()Landroid/view/ViewParent;", AccessFlags = 17)]
						get{ return default(global::Android.Views.IViewParent); }
				}

				/// <summary>
				///  <para>Return the scrolled left position of this view. This is the left edge of the displayed part of your view. You do not need to draw any pixels farther left, since those are outside of the frame of your view on screen.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The left edge of the displayed part of your view, in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getScrollX
				/// </java-name>
				public int ScrollX
				{
						[Dot42.DexImport("getScrollX", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the scrolled top position of this view. This is the top edge of the displayed part of your view. You do not need to draw any pixels above it, since those are outside of the frame of your view on screen.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The top edge of the displayed part of your view, in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getScrollY
				/// </java-name>
				public int ScrollY
				{
						[Dot42.DexImport("getScrollY", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the width of the your view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The width of your view, in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getWidth
				/// </java-name>
				public int Width
				{
						[Dot42.DexImport("getWidth", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the height of your view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The height of your view, in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getHeight
				/// </java-name>
				public int Height
				{
						[Dot42.DexImport("getHeight", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Like getMeasuredWidthAndState(), but only returns the raw width component (that is the result is masked by MEASURED_SIZE_MASK).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The raw measured width of this view. </para>
				/// </returns>
				/// <java-name>
				/// getMeasuredWidth
				/// </java-name>
				public int MeasuredWidth
				{
						[Dot42.DexImport("getMeasuredWidth", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Like getMeasuredHeightAndState(), but only returns the raw width component (that is the result is masked by MEASURED_SIZE_MASK).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The raw measured height of this view. </para>
				/// </returns>
				/// <java-name>
				/// getMeasuredHeight
				/// </java-name>
				public int MeasuredHeight
				{
						[Dot42.DexImport("getMeasuredHeight", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Top position of this view relative to its parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The top of this view, in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getTop
				/// </java-name>
				public int Top
				{
						[Dot42.DexImport("getTop", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Bottom position of this view relative to its parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The bottom of this view, in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getBottom
				/// </java-name>
				public int Bottom
				{
						[Dot42.DexImport("getBottom", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Left position of this view relative to its parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The left edge of this view, in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getLeft
				/// </java-name>
				public int Left
				{
						[Dot42.DexImport("getLeft", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Right position of this view relative to its parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The right edge of this view, in pixels. </para>
				/// </returns>
				/// <java-name>
				/// getRight
				/// </java-name>
				public int Right
				{
						[Dot42.DexImport("getRight", "()I", AccessFlags = 17)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the LayoutParams associated with this view. All views should have layout parameters. These supply parameters to the  <b>parent</b> of this view specifying how it should be arranged. There are many subclasses of ViewGroup.LayoutParams, and these correspond to the different subclasses of ViewGroup that are responsible for arranging their children.</para> <para>This method may return null if this View is not attached to a parent ViewGroup or setLayoutParams(android.view.ViewGroup.LayoutParams) was not invoked successfully. When a View is attached to a parent ViewGroup, this method must not return null.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The LayoutParams associated with this view, or null if no parameters have been set yet </para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether this View is opaque. An opaque View guarantees that it will draw all the pixels overlapping its bounds using a fully opaque color.</para> <para>Subclasses of View should override this method whenever possible to indicate whether an instance is opaque. Opaque Views are treated in a special way by the View hierarchy, possibly allowing it to perform optimizations during invalidate/draw passes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this View is guaranteed to be fully opaque, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isOpaque
				/// </java-name>
				public virtual bool IsOpaque
				{
						[Dot42.DexImport("isOpaque", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A handler associated with the thread running the View. This handler can be used to pump events in the UI events queue. </para>
				/// </returns>
				/// <java-name>
				/// getHandler
				/// </java-name>
				public virtual global::Android.OS.Handler Handler
				{
						[Dot42.DexImport("getHandler", "()Landroid/os/Handler;", AccessFlags = 1)]
						get{ return default(global::Android.OS.Handler); }
				}

				/// <summary>
				///  <para>Indicate whether the horizontal edges are faded when the view is scrolled horizontally.</para> <para> <para>setHorizontalFadingEdgeEnabled(boolean)</para>ref android.R.styleable::View_requiresFadingEdge </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the horizontal edges should are faded on scroll, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicate whether the vertical edges are faded when the view is scrolled horizontally.</para> <para> <para>setVerticalFadingEdgeEnabled(boolean)</para>ref android.R.styleable::View_requiresFadingEdge </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the vertical edges should are faded on scroll, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the strength, or intensity, of the top faded edge. The strength is a value between 0.0 (no fade) and 1.0 (full fade). The default implementation returns 0.0 or 1.0 but no value in between.</para> <para>Subclasses should override this method to provide a smoother fade transition when scrolling occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the intensity of the top fade as a float between 0.0f and 1.0f </para>
				/// </returns>
				/// <java-name>
				/// getTopFadingEdgeStrength
				/// </java-name>
				protected internal virtual float TopFadingEdgeStrength
				{
						[Dot42.DexImport("getTopFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Returns the strength, or intensity, of the bottom faded edge. The strength is a value between 0.0 (no fade) and 1.0 (full fade). The default implementation returns 0.0 or 1.0 but no value in between.</para> <para>Subclasses should override this method to provide a smoother fade transition when scrolling occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the intensity of the bottom fade as a float between 0.0f and 1.0f </para>
				/// </returns>
				/// <java-name>
				/// getBottomFadingEdgeStrength
				/// </java-name>
				protected internal virtual float BottomFadingEdgeStrength
				{
						[Dot42.DexImport("getBottomFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Returns the strength, or intensity, of the left faded edge. The strength is a value between 0.0 (no fade) and 1.0 (full fade). The default implementation returns 0.0 or 1.0 but no value in between.</para> <para>Subclasses should override this method to provide a smoother fade transition when scrolling occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the intensity of the left fade as a float between 0.0f and 1.0f </para>
				/// </returns>
				/// <java-name>
				/// getLeftFadingEdgeStrength
				/// </java-name>
				protected internal virtual float LeftFadingEdgeStrength
				{
						[Dot42.DexImport("getLeftFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Returns the strength, or intensity, of the right faded edge. The strength is a value between 0.0 (no fade) and 1.0 (full fade). The default implementation returns 0.0 or 1.0 but no value in between.</para> <para>Subclasses should override this method to provide a smoother fade transition when scrolling occurs.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the intensity of the right fade as a float between 0.0f and 1.0f </para>
				/// </returns>
				/// <java-name>
				/// getRightFadingEdgeStrength
				/// </java-name>
				protected internal virtual float RightFadingEdgeStrength
				{
						[Dot42.DexImport("getRightFadingEdgeStrength", "()F", AccessFlags = 4)]
						get{ return default(float); }
				}

				/// <summary>
				///  <para>Indicate whether the horizontal scrollbar should be drawn or not. The scrollbar is not drawn by default.</para> <para> <para>setHorizontalScrollBarEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the horizontal scrollbar should be painted, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicate whether the vertical scrollbar should be drawn or not. The scrollbar is not drawn by default.</para> <para> <para>setVerticalScrollBarEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the vertical scrollbar should be painted, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns true if scrollbars will fade when this view is not scrolling</para> <para>ref android.R.styleable::View_fadeScrollbars </para>        
				/// </summary>
				/// <returns>
				///  <para>true if scrollbar fading is enabled</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the current scrollbar style.</para> <para> <para>SCROLLBARS_INSIDE_OVERLAY </para> <para>SCROLLBARS_INSIDE_INSET </para> <para>SCROLLBARS_OUTSIDE_OVERLAY </para> <para>SCROLLBARS_OUTSIDE_INSET</para>ref android.R.styleable::View_scrollbarStyle </para>        
				/// </summary>
				/// <returns>
				///  <para>the current scrollbar style </para>
				/// </returns>
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

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The number of times this view has been attached to a window </para>
				/// </returns>
				/// <java-name>
				/// getWindowAttachCount
				/// </java-name>
				protected internal virtual int WindowAttachCount
				{
						[Dot42.DexImport("getWindowAttachCount", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Retrieve a unique token identifying the window this view is attached to. </para>        
				/// </summary>
				/// <returns>
				///  <para>Return the window's token for use in WindowManager.LayoutParams.token. </para>
				/// </returns>
				/// <java-name>
				/// getWindowToken
				/// </java-name>
				public virtual global::Android.OS.IBinder WindowToken
				{
						[Dot42.DexImport("getWindowToken", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IBinder); }
				}

				/// <summary>
				///  <para>Retrieve a unique token identifying the top-level "real" window of the window that this view is attached to. That is, this is like getWindowToken, except if the window this view in is a panel window (attached to another containing window), then the token of the containing window is returned instead.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the associated window token, either getWindowToken() or the containing window's token. </para>
				/// </returns>
				/// <java-name>
				/// getApplicationWindowToken
				/// </java-name>
				public virtual global::Android.OS.IBinder ApplicationWindowToken
				{
						[Dot42.DexImport("getApplicationWindowToken", "()Landroid/os/IBinder;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IBinder); }
				}

				/// <summary>
				///  <para>Return the time at which the drawing of the view hierarchy started.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the drawing start time in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getDrawingTime
				/// </java-name>
				public virtual long DrawingTime
				{
						[Dot42.DexImport("getDrawingTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>Indicates whether this duplicates its drawable state from its parent.</para> <para> <para>getDrawableState() </para> <para>setDuplicateParentStateEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this view's drawable state is duplicated from the parent, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether the drawing cache is enabled for this view.</para> <para> <para>setDrawingCacheEnabled(boolean) </para> <para>getDrawingCache() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the drawing cache is enabled</para>
				/// </returns>
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

				/// <summary>
				///  <para>Calling this method is equivalent to calling  <code>getDrawingCache(false)</code>.</para> <para> <para>getDrawingCache(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A non-scaled bitmap representing this view or null if cache is disabled.</para>
				/// </returns>
				/// <java-name>
				/// getDrawingCache
				/// </java-name>
				public virtual global::Android.Graphics.Bitmap DrawingCache
				{
						[Dot42.DexImport("getDrawingCache", "()Landroid/graphics/Bitmap;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Bitmap); }
				}

				/// <summary>
				///  <para> <para>setDrawingCacheBackgroundColor(int)</para></para>        
				/// </summary>
				/// <returns>
				///  <para>The background color to used for the drawing cache's bitmap </para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether this View is currently in edit mode. A View is usually in edit mode when displayed within a developer tool. For instance, if this View is being drawn by a visual user interface builder, this method should return true.</para> <para>Subclasses should check the return value of this method to provide different behaviors if their normal behavior might interfere with the host environment. For instance: the class spawns a thread in its constructor, the drawing code relies on device-specific features, etc.</para> <para>This method is usually checked in the drawing code of custom widgets.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this View is in edit mode, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isInEditMode
				/// </java-name>
				public virtual bool IsInEditMode
				{
						[Dot42.DexImport("isInEditMode", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>If the View draws content inside its padding and enables fading edges, it needs to support padding offsets. Padding offsets are added to the fading edges to extend the length of the fade so that it covers pixels drawn inside the padding.</para> <para>Subclasses of this class should override this method if they need to draw content inside the padding.</para> <para> <para>getLeftPaddingOffset() </para> <para>getRightPaddingOffset() </para> <para>getTopPaddingOffset() </para> <para>getBottomPaddingOffset()</para> <para>CURRENT </para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if padding offset must be applied, false otherwise.</para>
				/// </returns>
				/// <java-name>
				/// isPaddingOffsetRequired
				/// </java-name>
				protected internal virtual bool IsPaddingOffsetRequired
				{
						[Dot42.DexImport("isPaddingOffsetRequired", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Amount by which to extend the left fading region. Called only when isPaddingOffsetRequired() returns true.</para> <para> <para>isPaddingOffsetRequired()</para> <para>CURRENT </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The left padding offset in pixels.</para>
				/// </returns>
				/// <java-name>
				/// getLeftPaddingOffset
				/// </java-name>
				protected internal virtual int LeftPaddingOffset
				{
						[Dot42.DexImport("getLeftPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Amount by which to extend the right fading region. Called only when isPaddingOffsetRequired() returns true.</para> <para> <para>isPaddingOffsetRequired()</para> <para>CURRENT </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The right padding offset in pixels.</para>
				/// </returns>
				/// <java-name>
				/// getRightPaddingOffset
				/// </java-name>
				protected internal virtual int RightPaddingOffset
				{
						[Dot42.DexImport("getRightPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Amount by which to extend the top fading region. Called only when isPaddingOffsetRequired() returns true.</para> <para> <para>isPaddingOffsetRequired()</para> <para>CURRENT </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The top padding offset in pixels.</para>
				/// </returns>
				/// <java-name>
				/// getTopPaddingOffset
				/// </java-name>
				protected internal virtual int TopPaddingOffset
				{
						[Dot42.DexImport("getTopPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Amount by which to extend the bottom fading region. Called only when isPaddingOffsetRequired() returns true.</para> <para> <para>isPaddingOffsetRequired()</para> <para>CURRENT </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The bottom padding offset in pixels.</para>
				/// </returns>
				/// <java-name>
				/// getBottomPaddingOffset
				/// </java-name>
				protected internal virtual int BottomPaddingOffset
				{
						[Dot42.DexImport("getBottomPaddingOffset", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Override this if your view is known to always be drawn on top of a solid color background, and needs to draw fading edges. Returning a non-zero color enables the view system to optimize the drawing of the fading edges. If you do return a non-zero color, the alpha should be set to 0xFF.</para> <para> <para>setVerticalFadingEdgeEnabled(boolean) </para> <para>setHorizontalFadingEdgeEnabled(boolean)</para></para>        
				/// </summary>
				/// <returns>
				///  <para>The known solid color background for this view, or 0 if the color may vary </para>
				/// </returns>
				/// <java-name>
				/// getSolidColor
				/// </java-name>
				public virtual int SolidColor
				{
						[Dot42.DexImport("getSolidColor", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates whether or not this view's layout will be requested during the next hierarchy layout pass.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the layout will be forced during next layout pass </para>
				/// </returns>
				/// <java-name>
				/// isLayoutRequested
				/// </java-name>
				public virtual bool IsLayoutRequested
				{
						[Dot42.DexImport("isLayoutRequested", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the resources associated with this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Resources object. </para>
				/// </returns>
				/// <java-name>
				/// getResources
				/// </java-name>
				public virtual global::Android.Content.Res.Resources Resources
				{
						[Dot42.DexImport("getResources", "()Landroid/content/res/Resources;", AccessFlags = 1)]
						get{ return default(global::Android.Content.Res.Resources); }
				}

				/// <summary>
				///  <para>Return an array of resource IDs of the drawable states representing the current state of the view.</para> <para> <para>Drawable::setState(int[]) </para> <para>drawableStateChanged() </para> <para>onCreateDrawableState(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The current drawable state</para>
				/// </returns>
				/// <java-name>
				/// getDrawableState
				/// </java-name>
				public int[] DrawableState
				{
						[Dot42.DexImport("getDrawableState", "()[I", AccessFlags = 17)]
						get{ return default(int[]); }
				}

				/// <summary>
				///  <para>Gets the background drawable</para> <para> <para>setBackground(Drawable)</para>ref android.R.styleable::View_background </para>        
				/// </summary>
				/// <returns>
				///  <para>The drawable used as the background for this view, if any.</para>
				/// </returns>
				/// <java-name>
				/// getBackground
				/// </java-name>
				public virtual global::Android.Graphics.Drawables.Drawable Background
				{
						[Dot42.DexImport("getBackground", "()Landroid/graphics/drawable/Drawable;", AccessFlags = 1)]
						get{ return default(global::Android.Graphics.Drawables.Drawable); }
				}

				/// <summary>
				///  <para>Returns the top padding of this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the top padding in pixels </para>
				/// </returns>
				/// <java-name>
				/// getPaddingTop
				/// </java-name>
				public virtual int PaddingTop
				{
						[Dot42.DexImport("getPaddingTop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the bottom padding of this view. If there are inset and enabled scrollbars, this value may include the space required to display the scrollbars as well.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the bottom padding in pixels </para>
				/// </returns>
				/// <java-name>
				/// getPaddingBottom
				/// </java-name>
				public virtual int PaddingBottom
				{
						[Dot42.DexImport("getPaddingBottom", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the left padding of this view. If there are inset and enabled scrollbars, this value may include the space required to display the scrollbars as well.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the left padding in pixels </para>
				/// </returns>
				/// <java-name>
				/// getPaddingLeft
				/// </java-name>
				public virtual int PaddingLeft
				{
						[Dot42.DexImport("getPaddingLeft", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the right padding of this view. If there are inset and enabled scrollbars, this value may include the space required to display the scrollbars as well.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the right padding in pixels </para>
				/// </returns>
				/// <java-name>
				/// getPaddingRight
				/// </java-name>
				public virtual int PaddingRight
				{
						[Dot42.DexImport("getPaddingRight", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Indicates the selection state of this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the view is selected, false otherwise </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the ViewTreeObserver for this view's hierarchy. The view tree observer can be used to get notifications when global events, like layout, happen.</para> <para>The returned ViewTreeObserver observer is not guaranteed to remain valid for the lifetime of this View. If the caller of this method keeps a long-lived reference to ViewTreeObserver, it should always check for the return value of ViewTreeObserver#isAlive().</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The ViewTreeObserver for this view's hierarchy. </para>
				/// </returns>
				/// <java-name>
				/// getViewTreeObserver
				/// </java-name>
				public virtual global::Android.Views.ViewTreeObserver ViewTreeObserver
				{
						[Dot42.DexImport("getViewTreeObserver", "()Landroid/view/ViewTreeObserver;", AccessFlags = 1)]
						get{ return default(global::Android.Views.ViewTreeObserver); }
				}

				/// <summary>
				///  <para>Finds the topmost view in the current view hierarchy.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the topmost view containing this view </para>
				/// </returns>
				/// <java-name>
				/// getRootView
				/// </java-name>
				public virtual global::Android.Views.View RootView
				{
						[Dot42.DexImport("getRootView", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Returns this view's identifier.</para> <para> <para>setId(int) </para> <para>findViewById(int)  ref android.R.styleable::View_id </para></para>        
				/// </summary>
				/// <returns>
				///  <para>a positive integer used to identify the view or NO_ID if the view has no ID</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns this view's tag.</para> <para> <para>#setTag(Object) </para> <para>getTag(int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>the Object stored in this view as a tag</para>
				/// </returns>
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

				/// <summary>
				///  <para>Return the offset of the widget's text baseline from the widget's top boundary. If this widget does not support baseline alignment, this method returns -1. </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the offset of the baseline within the widget's bounds or -1 if baseline alignment is not supported </para>
				/// </returns>
				/// <java-name>
				/// getBaseline
				/// </java-name>
				public virtual int Baseline
				{
						[Dot42.DexImport("getBaseline", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the suggested minimum height that the view should use. This returns the maximum of the view's minimum height and the background's minimum height (android.graphics.drawable.Drawable#getMinimumHeight()). </para> <para>When being used in onMeasure(int, int), the caller should still ensure the returned height is within the requirements of the parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The suggested minimum height of the view. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestedMinimumHeight
				/// </java-name>
				protected internal virtual int SuggestedMinimumHeight
				{
						[Dot42.DexImport("getSuggestedMinimumHeight", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the suggested minimum width that the view should use. This returns the maximum of the view's minimum width) and the background's minimum width (android.graphics.drawable.Drawable#getMinimumWidth()). </para> <para>When being used in onMeasure(int, int), the caller should still ensure the returned width is within the requirements of the parent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The suggested minimum width of the view. </para>
				/// </returns>
				/// <java-name>
				/// getSuggestedMinimumWidth
				/// </java-name>
				protected internal virtual int SuggestedMinimumWidth
				{
						[Dot42.DexImport("getSuggestedMinimumWidth", "()I", AccessFlags = 4)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Get the animation currently associated with this view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The animation that is currently playing or scheduled to play for this view. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the over-scroll mode for this view. The result will be one of OVER_SCROLL_ALWAYS (default), OVER_SCROLL_IF_CONTENT_SCROLLS (allow over-scrolling only if the view content is larger than the container), or OVER_SCROLL_NEVER.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>This view's over-scroll mode. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Base class for derived classes that want to save and restore their own state in android.view.View#onSaveInstanceState(). </para>    
				/// </summary>
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

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the context menu for this view is being built. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/View$OnCreateContextMenuListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnCreateContextMenuListener", AccessFlags = 1545)]
				public partial interface IOnCreateContextMenuListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the context menu for this view is being built. It is not safe to hold onto the menu after this method returns.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onCreateContextMenu
						/// </java-name>
						[Dot42.DexImport("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMe" +
    "nuInfo;)V", AccessFlags = 1025)]
						void OnCreateContextMenu(global::Android.Views.IContextMenu menu, global::Android.Views.View v, global::Android.Views.IContextMenu_IContextMenuInfo menuInfo) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when a view is clicked. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/View$OnClickListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnClickListener", AccessFlags = 1545)]
				public partial interface IOnClickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a view has been clicked.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onClick
						/// </java-name>
						[Dot42.DexImport("onClick", "(Landroid/view/View;)V", AccessFlags = 1025)]
						void OnClick(global::Android.Views.View v) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the focus state of a view changed. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/View$OnFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnFocusChangeListener", AccessFlags = 1545)]
				public partial interface IOnFocusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when the focus state of a view has changed.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onFocusChange
						/// </java-name>
						[Dot42.DexImport("onFocusChange", "(Landroid/view/View;Z)V", AccessFlags = 1025)]
						void OnFocusChange(global::Android.Views.View v, bool hasFocus) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when a view has been clicked and held. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/View$OnLongClickListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnLongClickListener", AccessFlags = 1545)]
				public partial interface IOnLongClickListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a view has been clicked and held.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the callback consumed the long click, false otherwise. </para>
						/// </returns>
						/// <java-name>
						/// onLongClick
						/// </java-name>
						[Dot42.DexImport("onLongClick", "(Landroid/view/View;)Z", AccessFlags = 1025)]
						bool OnLongClick(global::Android.Views.View v) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when a touch event is dispatched to this view. The callback will be invoked before the touch event is given to the view. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/View$OnTouchListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnTouchListener", AccessFlags = 1545)]
				public partial interface IOnTouchListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a touch event is dispatched to a view. This allows listeners to get a chance to respond before the target view.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the listener has consumed the event, false otherwise. </para>
						/// </returns>
						/// <java-name>
						/// onTouch
						/// </java-name>
						[Dot42.DexImport("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool OnTouch(global::Android.Views.View v, global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when a hardware key event is dispatched to this view. The callback will be invoked before the key event is given to the view. This is only useful for hardware keyboards; a software input method has no obligation to trigger this listener. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/View$OnKeyListener
				/// </java-name>
				[Dot42.DexImport("android/view/View$OnKeyListener", AccessFlags = 1545)]
				public partial interface IOnKeyListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a hardware key is dispatched to a view. This allows listeners to get a chance to respond before the target view. </para> <para>Key presses in software keyboards will generally NOT trigger this method, although some may elect to do so in some situations. Do not assume a software input method has to be key-based; even if it is, it may use key presses in a different way than you expect, so there is no way to reliably catch soft input key presses.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>True if the listener has consumed the event, false otherwise. </para>
						/// </returns>
						/// <java-name>
						/// onKey
						/// </java-name>
						[Dot42.DexImport("onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool OnKey(global::Android.Views.View v, int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>A MeasureSpec encapsulates the layout requirements passed from parent to child. Each MeasureSpec represents a requirement for either the width or the height. A MeasureSpec is comprised of a size and a mode. There are three possible modes: </para> <para>MeasureSpecs are implemented as ints to reduce object allocation. This class is provided to pack and unpack the &lt;size, mode&gt; tuple into the int. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/View$MeasureSpec
				/// </java-name>
				[Dot42.DexImport("android/view/View$MeasureSpec", AccessFlags = 9)]
				public partial class MeasureSpec
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Measure specification mode: The parent has not imposed any constraint on the child. It can be whatever size it wants. </para>        
						/// </summary>
						/// <java-name>
						/// UNSPECIFIED
						/// </java-name>
						[Dot42.DexImport("UNSPECIFIED", "I", AccessFlags = 25)]
						public const int UNSPECIFIED = 0;
						/// <summary>
						///  <para>Measure specification mode: The parent has determined an exact size for the child. The child is going to be given those bounds regardless of how big it wants to be. </para>        
						/// </summary>
						/// <java-name>
						/// EXACTLY
						/// </java-name>
						[Dot42.DexImport("EXACTLY", "I", AccessFlags = 25)]
						public const int EXACTLY = 1073741824;
						/// <summary>
						///  <para>Measure specification mode: The child can be as large as it wants up to the specified size. </para>        
						/// </summary>
						/// <java-name>
						/// AT_MOST
						/// </java-name>
						[Dot42.DexImport("AT_MOST", "I", AccessFlags = 25)]
						public const int AT_MOST = -2147483648;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public MeasureSpec() /* MethodBuilder.Create */ 
						{
						}

						/// <summary>
						///  <para>Creates a measure specification based on the supplied size and mode.</para> <para>The mode must always be one of the following:  <ul> <li> <para>android.view.View.MeasureSpec#UNSPECIFIED </para></li> <li> <para>android.view.View.MeasureSpec#EXACTLY </para></li> <li> <para>android.view.View.MeasureSpec#AT_MOST </para></li></ul></para> <para> <b>Note:</b> On API level 17 and lower, makeMeasureSpec's implementation was such that the order of arguments did not matter and overflow in either value could impact the resulting MeasureSpec. android.widget.RelativeLayout was affected by this bug. Apps targeting API levels greater than 17 will get the fixed, more strict behavior.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the measure specification based on size and mode </para>
						/// </returns>
						/// <java-name>
						/// makeMeasureSpec
						/// </java-name>
						[Dot42.DexImport("makeMeasureSpec", "(II)I", AccessFlags = 9)]
						public static int MakeMeasureSpec(int size, int mode) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Extracts the mode from the supplied measure specification.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>android.view.View.MeasureSpec#UNSPECIFIED, android.view.View.MeasureSpec#AT_MOST or android.view.View.MeasureSpec#EXACTLY </para>
						/// </returns>
						/// <java-name>
						/// getMode
						/// </java-name>
						[Dot42.DexImport("getMode", "(I)I", AccessFlags = 9)]
						public static int GetMode(int measureSpec) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Extracts the size from the supplied measure specification.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>the size in pixels defined in the supplied measure specification </para>
						/// </returns>
						/// <java-name>
						/// getSize
						/// </java-name>
						[Dot42.DexImport("getSize", "(I)I", AccessFlags = 9)]
						public static int GetSize(int measureSpec) /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <summary>
						///  <para>Returns a String representation of the specified measure specification.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>a String with the following format: "MeasureSpec: MODE SIZE" </para>
						/// </returns>
						/// <java-name>
						/// toString
						/// </java-name>
						[Dot42.DexImport("toString", "(I)Ljava/lang/String;", AccessFlags = 9)]
						public static string ToString(int measureSpec) /* MethodBuilder.Create */ 
						{
								return default(string);
						}

				}

		}

		/// <summary>
		///  <para>Contains methods to standard constants used in the UI for timeouts, sizes, and distances. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/ViewConfiguration
		/// </java-name>
		[Dot42.DexImport("android/view/ViewConfiguration", AccessFlags = 33)]
		public partial class ViewConfiguration
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use android.view.ViewConfiguration#get(android.content.Context) instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ViewConfiguration() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a configuration for the specified context. The configuration depends on various parameters of the context, like the dimension of the display or the density of the display.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// get
				/// </java-name>
				[Dot42.DexImport("get", "(Landroid/content/Context;)Landroid/view/ViewConfiguration;", AccessFlags = 9)]
				public static global::Android.Views.ViewConfiguration Get(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewConfiguration);
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getScaledScrollBarSize() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>The width of the horizontal scrollbar and the height of the vertical scrollbar in dips</para>
				/// </returns>
				/// <java-name>
				/// getScrollBarSize
				/// </java-name>
				public static int ScrollBarSize
				{
						[Dot42.DexImport("getScrollBarSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The width of the horizontal scrollbar and the height of the vertical scrollbar in pixels </para>
				/// </returns>
				/// <java-name>
				/// getScaledScrollBarSize
				/// </java-name>
				public virtual int ScaledScrollBarSize
				{
						[Dot42.DexImport("getScaledScrollBarSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Duration of the fade when scrollbars fade away in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getScrollBarFadeDuration
				/// </java-name>
				public static int ScrollBarFadeDuration
				{
						[Dot42.DexImport("getScrollBarFadeDuration", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Default delay before the scrollbars fade in milliseconds </para>
				/// </returns>
				/// <java-name>
				/// getScrollDefaultDelay
				/// </java-name>
				public static int ScrollDefaultDelay
				{
						[Dot42.DexImport("getScrollDefaultDelay", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getScaledFadingEdgeLength() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the length of the fading edges in dips</para>
				/// </returns>
				/// <java-name>
				/// getFadingEdgeLength
				/// </java-name>
				public static int FadingEdgeLength
				{
						[Dot42.DexImport("getFadingEdgeLength", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the length of the fading edges in pixels </para>
				/// </returns>
				/// <java-name>
				/// getScaledFadingEdgeLength
				/// </java-name>
				public virtual int ScaledFadingEdgeLength
				{
						[Dot42.DexImport("getScaledFadingEdgeLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the duration in milliseconds of the pressed state in child components. </para>
				/// </returns>
				/// <java-name>
				/// getPressedStateDuration
				/// </java-name>
				public static int PressedStateDuration
				{
						[Dot42.DexImport("getPressedStateDuration", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the duration in milliseconds before a press turns into a long press </para>
				/// </returns>
				/// <java-name>
				/// getLongPressTimeout
				/// </java-name>
				public static int LongPressTimeout
				{
						[Dot42.DexImport("getLongPressTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the duration in milliseconds we will wait to see if a touch event is a tap or a scroll. If the user does not move within this interval, it is considered to be a tap. </para>
				/// </returns>
				/// <java-name>
				/// getTapTimeout
				/// </java-name>
				public static int TapTimeout
				{
						[Dot42.DexImport("getTapTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the duration in milliseconds we will wait to see if a touch event is a jump tap. If the user does not move within this interval, it is considered to be a tap. </para>
				/// </returns>
				/// <java-name>
				/// getJumpTapTimeout
				/// </java-name>
				public static int JumpTapTimeout
				{
						[Dot42.DexImport("getJumpTapTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the duration in milliseconds between the first tap's up event and the second tap's down event for an interaction to be considered a double-tap. </para>
				/// </returns>
				/// <java-name>
				/// getDoubleTapTimeout
				/// </java-name>
				public static int DoubleTapTimeout
				{
						[Dot42.DexImport("getDoubleTapTimeout", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getScaledEdgeSlop() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Inset in dips to look for touchable content when the user touches the edge of the screen</para>
				/// </returns>
				/// <java-name>
				/// getEdgeSlop
				/// </java-name>
				public static int EdgeSlop
				{
						[Dot42.DexImport("getEdgeSlop", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Inset in pixels to look for touchable content when the user touches the edge of the screen </para>
				/// </returns>
				/// <java-name>
				/// getScaledEdgeSlop
				/// </java-name>
				public virtual int ScaledEdgeSlop
				{
						[Dot42.DexImport("getScaledEdgeSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getScaledTouchSlop() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Distance in dips a touch can wander before we think the user is scrolling</para>
				/// </returns>
				/// <java-name>
				/// getTouchSlop
				/// </java-name>
				public static int TouchSlop
				{
						[Dot42.DexImport("getTouchSlop", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Distance in pixels a touch can wander before we think the user is scrolling </para>
				/// </returns>
				/// <java-name>
				/// getScaledTouchSlop
				/// </java-name>
				public virtual int ScaledTouchSlop
				{
						[Dot42.DexImport("getScaledTouchSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Distance in pixels a touch can wander before we think the user is scrolling a full page </para>
				/// </returns>
				/// <java-name>
				/// getScaledPagingTouchSlop
				/// </java-name>
				public virtual int ScaledPagingTouchSlop
				{
						[Dot42.DexImport("getScaledPagingTouchSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Distance in pixels between the first touch and second touch to still be considered a double tap </para>
				/// </returns>
				/// <java-name>
				/// getScaledDoubleTapSlop
				/// </java-name>
				public virtual int ScaledDoubleTapSlop
				{
						[Dot42.DexImport("getScaledDoubleTapSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getScaledWindowTouchSlop() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Distance in dips a touch must be outside the bounds of a window for it to be counted as outside the window for purposes of dismissing that window.</para>
				/// </returns>
				/// <java-name>
				/// getWindowTouchSlop
				/// </java-name>
				public static int WindowTouchSlop
				{
						[Dot42.DexImport("getWindowTouchSlop", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Distance in pixels a touch must be outside the bounds of a window for it to be counted as outside the window for purposes of dismissing that window. </para>
				/// </returns>
				/// <java-name>
				/// getScaledWindowTouchSlop
				/// </java-name>
				public virtual int ScaledWindowTouchSlop
				{
						[Dot42.DexImport("getScaledWindowTouchSlop", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getScaledMinimumFlingVelocity() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Minimum velocity to initiate a fling, as measured in dips per second.</para>
				/// </returns>
				/// <java-name>
				/// getMinimumFlingVelocity
				/// </java-name>
				public static int MinimumFlingVelocity
				{
						[Dot42.DexImport("getMinimumFlingVelocity", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Minimum velocity to initiate a fling, as measured in pixels per second. </para>
				/// </returns>
				/// <java-name>
				/// getScaledMinimumFlingVelocity
				/// </java-name>
				public virtual int ScaledMinimumFlingVelocity
				{
						[Dot42.DexImport("getScaledMinimumFlingVelocity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getScaledMaximumFlingVelocity() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>Maximum velocity to initiate a fling, as measured in dips per second.</para>
				/// </returns>
				/// <java-name>
				/// getMaximumFlingVelocity
				/// </java-name>
				public static int MaximumFlingVelocity
				{
						[Dot42.DexImport("getMaximumFlingVelocity", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Maximum velocity to initiate a fling, as measured in pixels per second. </para>
				/// </returns>
				/// <java-name>
				/// getScaledMaximumFlingVelocity
				/// </java-name>
				public virtual int ScaledMaximumFlingVelocity
				{
						[Dot42.DexImport("getScaledMaximumFlingVelocity", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>The maximum drawing cache size expressed in bytes.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getScaledMaximumDrawingCacheSize() instead. </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum size of View's drawing cache expressed in bytes</para>
				/// </returns>
				/// <java-name>
				/// getMaximumDrawingCacheSize
				/// </java-name>
				public static int MaximumDrawingCacheSize
				{
						[Dot42.DexImport("getMaximumDrawingCacheSize", "()I", AccessFlags = 9)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>The maximum drawing cache size expressed in bytes.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the maximum size of View's drawing cache expressed in bytes </para>
				/// </returns>
				/// <java-name>
				/// getScaledMaximumDrawingCacheSize
				/// </java-name>
				public virtual int ScaledMaximumDrawingCacheSize
				{
						[Dot42.DexImport("getScaledMaximumDrawingCacheSize", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The maximum distance a View should overscroll by when showing edge effects (in pixels). </para>
				/// </returns>
				/// <java-name>
				/// getScaledOverscrollDistance
				/// </java-name>
				public virtual int ScaledOverscrollDistance
				{
						[Dot42.DexImport("getScaledOverscrollDistance", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The maximum distance a View should overfling by when showing edge effects (in pixels). </para>
				/// </returns>
				/// <java-name>
				/// getScaledOverflingDistance
				/// </java-name>
				public virtual int ScaledOverflingDistance
				{
						[Dot42.DexImport("getScaledOverflingDistance", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>The amount of time that the zoom controls should be displayed on the screen expressed in milliseconds.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the time the zoom controls should be visible expressed in milliseconds. </para>
				/// </returns>
				/// <java-name>
				/// getZoomControlsTimeout
				/// </java-name>
				public static long ZoomControlsTimeout
				{
						[Dot42.DexImport("getZoomControlsTimeout", "()J", AccessFlags = 9)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>The amount of time a user needs to press the relevant key to bring up the global actions dialog.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>how long a user needs to press the relevant key to bring up the global actions dialog. </para>
				/// </returns>
				/// <java-name>
				/// getGlobalActionKeyTimeout
				/// </java-name>
				public static long GlobalActionKeyTimeout
				{
						[Dot42.DexImport("getGlobalActionKeyTimeout", "()J", AccessFlags = 9)]
						get{ return default(long); }
				}

				/// <summary>
				///  <para>The amount of friction applied to scrolls and flings.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A scalar dimensionless value representing the coefficient of friction. </para>
				/// </returns>
				/// <java-name>
				/// getScrollFriction
				/// </java-name>
				public static float ScrollFriction
				{
						[Dot42.DexImport("getScrollFriction", "()F", AccessFlags = 9)]
						get{ return default(float); }
				}

		}

		/// <summary>
		///  <para>Various debugging/tracing tools related to View and the view hierarchy. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/ViewDebug
		/// </java-name>
		[Dot42.DexImport("android/view/ViewDebug", AccessFlags = 33)]
		public partial class ViewDebug
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This flag is now unused </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// TRACE_HIERARCHY
				/// </java-name>
				[Dot42.DexImport("TRACE_HIERARCHY", "Z", AccessFlags = 25)]
				public const bool TRACE_HIERARCHY = false;
				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This flag is now unused </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// TRACE_RECYCLER
				/// </java-name>
				[Dot42.DexImport("TRACE_RECYCLER", "Z", AccessFlags = 25)]
				public const bool TRACE_RECYCLER = false;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public ViewDebug() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now unused and invoking it is a no-op </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V", AccessFlags = 137)]
				public static void Trace(global::Android.Views.View view, global::Android.Views.ViewDebug.RecyclerTraceType type, params int[] parameters) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now unused and invoking it is a no-op </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// startRecyclerTracing
				/// </java-name>
				[Dot42.DexImport("startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V", AccessFlags = 9)]
				public static void StartRecyclerTracing(string prefix, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now unused and invoking it is a no-op </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// stopRecyclerTracing
				/// </java-name>
				[Dot42.DexImport("stopRecyclerTracing", "()V", AccessFlags = 9)]
				public static void StopRecyclerTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now unused and invoking it is a no-op </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// trace
				/// </java-name>
				[Dot42.DexImport("trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V", AccessFlags = 9)]
				public static void Trace(global::Android.Views.View view, global::Android.Views.ViewDebug.HierarchyTraceType type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now unused and invoking it is a no-op </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// startHierarchyTracing
				/// </java-name>
				[Dot42.DexImport("startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V", AccessFlags = 9)]
				public static void StartHierarchyTracing(string prefix, global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>This method is now unused and invoking it is a no-op </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <java-name>
				/// stopHierarchyTracing
				/// </java-name>
				[Dot42.DexImport("stopHierarchyTracing", "()V", AccessFlags = 9)]
				public static void StopHierarchyTracing() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Dump view info for id based instrument test generation (and possibly further data analysis). The results are dumped to the log. </para>        
				/// </summary>
				/// <java-name>
				/// dumpCapturedView
				/// </java-name>
				[Dot42.DexImport("dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V", AccessFlags = 9)]
				public static void DumpCapturedView(string tag, object view) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>This annotation can be used to mark fields and methods to be dumped when the view is captured. Methods with this annotation must have no arguments and must return a valid type of data. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewDebug$CapturedViewProperty
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$CapturedViewProperty", AccessFlags = 9737)]
				public partial interface ICapturedViewProperty : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>When retrieveReturn is true, we need to retrieve second level methods e.g., we need myView.getFirstLevelMethod().getSecondLevelMethod() we will set retrieveReturn = true on the annotation of myView.getFirstLevelMethod() </para>        
						/// </summary>
						/// <returns>
						///  <para>true if we need the second level methods </para>
						/// </returns>
						/// <java-name>
						/// retrieveReturn
						/// </java-name>
						[Dot42.DexImport("retrieveReturn", "()Z", AccessFlags = 1025)]
						bool RetrieveReturn() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Defines a mapping from a flag to a String. Such a mapping can be used in an  to provide more meaningful values to the end user.</para> <para> <para>android.view.ViewDebug.ExportedProperty </para></para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewDebug$FlagToString
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$FlagToString", AccessFlags = 9737)]
				public partial interface IFlagToString : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The mask to apply to the original value.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>An arbitrary int value. </para>
						/// </returns>
						/// <java-name>
						/// mask
						/// </java-name>
						[Dot42.DexImport("mask", "()I", AccessFlags = 1025)]
						int Mask() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>The value to compare to the result of:  <code>original value &amp; mask()</code>.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>An arbitrary value. </para>
						/// </returns>
						/// <java-name>
						/// equals
						/// </java-name>
						[Dot42.DexImport("equals", "()I", AccessFlags = 1025)]
						int Equals() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>The String to use in place of the original int value.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>An arbitrary non-null String. </para>
						/// </returns>
						/// <java-name>
						/// name
						/// </java-name>
						[Dot42.DexImport("name", "()Ljava/lang/String;", AccessFlags = 1025)]
						string Name() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Indicates whether to output the flag when the test is true, or false. Defaults to true. </para>        
						/// </summary>
						/// <java-name>
						/// outputIf
						/// </java-name>
						[Dot42.DexImport("outputIf", "()Z", AccessFlags = 1025)]
						bool OutputIf() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Defines a mapping from an int value to a String. Such a mapping can be used in an  to provide more meaningful values to the end user.</para> <para> <para>android.view.ViewDebug.ExportedProperty </para></para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewDebug$IntToString
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$IntToString", AccessFlags = 9737)]
				public partial interface IIntToString : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The original int value to map to a String.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>An arbitrary int value. </para>
						/// </returns>
						/// <java-name>
						/// from
						/// </java-name>
						[Dot42.DexImport("from", "()I", AccessFlags = 1025)]
						int From() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>The String to use in place of the original int value.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>An arbitrary non-null String. </para>
						/// </returns>
						/// <java-name>
						/// to
						/// </java-name>
						[Dot42.DexImport("to", "()Ljava/lang/String;", AccessFlags = 1025)]
						string To() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>This annotation can be used to mark fields and methods to be dumped by the view server. Only non-void methods with no arguments can be annotated by this annotation. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewDebug$ExportedProperty
				/// </java-name>
				[Dot42.DexImport("android/view/ViewDebug$ExportedProperty", AccessFlags = 9737)]
				public partial interface IExportedProperty : global::Java.Lang.Annotation.IAnnotation
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>When resolveId is true, and if the annotated field/method return value is an int, the value is converted to an Android's resource name.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if the property's value must be transformed into an Android resource name, false otherwise </para>
						/// </returns>
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

		/// <summary>
		///  <para>A  <code>ViewGroup</code> is a special view that can contain other views (called children.) The view group is the base class for layouts and views containers. This class also defines the android.view.ViewGroup.LayoutParams class which serves as the base class for layouts parameters. </para> <para>Also see LayoutParams for layout attributes. </para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating user interface layouts, read the  developer guide.</para> <para></para> <para>Here is a complete implementation of a custom ViewGroup that implements a simple android.widget.FrameLayout along with the ability to stack children in left and right gutters.</para> <para>{ development/samples/ApiDemos/src/com/example/android/apis/view/CustomLayout.java Complete}</para> <para>If you are implementing XML layout attributes as shown in the example, this is the corresponding definition for them that would go in  <code>res/values/attrs.xml</code>:</para> <para>{ development/samples/ApiDemos/res/values/attrs.xml CustomLayout}</para> <para>Finally the layout manager can be used in an XML layout like so:</para> <para>{ development/samples/ApiDemos/res/layout/custom_layout.xml Complete}</para> <para>ref android.R.styleable::ViewGroup_clipChildren  ref android.R.styleable::ViewGroup_clipToPadding  ref android.R.styleable::ViewGroup_layoutAnimation  ref android.R.styleable::ViewGroup_animationCache  ref android.R.styleable::ViewGroup_persistentDrawingCache  ref android.R.styleable::ViewGroup_alwaysDrawnWithCache  ref android.R.styleable::ViewGroup_addStatesFromChildren  ref android.R.styleable::ViewGroup_descendantFocusability  ref android.R.styleable::ViewGroup_animateLayoutChanges  ref android.R.styleable::ViewGroup_splitMotionEvents  ref android.R.styleable::ViewGroup_layoutMode </para>    
		/// </summary>
		/// <java-name>
		/// android/view/ViewGroup
		/// </java-name>
		[Dot42.DexImport("android/view/ViewGroup", AccessFlags = 1057)]
		public abstract partial class ViewGroup : global::Android.Views.View, global::Android.Views.IViewParent, global::Android.Views.IViewManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>This view will get focus before any of its descendants. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_BEFORE_DESCENDANTS
				/// </java-name>
				[Dot42.DexImport("FOCUS_BEFORE_DESCENDANTS", "I", AccessFlags = 25)]
				public const int FOCUS_BEFORE_DESCENDANTS = 131072;
				/// <summary>
				///  <para>This view will get focus only if none of its descendants want it. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_AFTER_DESCENDANTS
				/// </java-name>
				[Dot42.DexImport("FOCUS_AFTER_DESCENDANTS", "I", AccessFlags = 25)]
				public const int FOCUS_AFTER_DESCENDANTS = 262144;
				/// <summary>
				///  <para>This view will block any of its descendants from getting focus, even if they are focusable. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_BLOCK_DESCENDANTS
				/// </java-name>
				[Dot42.DexImport("FOCUS_BLOCK_DESCENDANTS", "I", AccessFlags = 25)]
				public const int FOCUS_BLOCK_DESCENDANTS = 393216;
				/// <summary>
				///  <para>Used to indicate that no drawing cache should be kept in memory. </para>        
				/// </summary>
				/// <java-name>
				/// PERSISTENT_NO_CACHE
				/// </java-name>
				[Dot42.DexImport("PERSISTENT_NO_CACHE", "I", AccessFlags = 25)]
				public const int PERSISTENT_NO_CACHE = 0;
				/// <summary>
				///  <para>Used to indicate that the animation drawing cache should be kept in memory. </para>        
				/// </summary>
				/// <java-name>
				/// PERSISTENT_ANIMATION_CACHE
				/// </java-name>
				[Dot42.DexImport("PERSISTENT_ANIMATION_CACHE", "I", AccessFlags = 25)]
				public const int PERSISTENT_ANIMATION_CACHE = 1;
				/// <summary>
				///  <para>Used to indicate that the scrolling drawing cache should be kept in memory. </para>        
				/// </summary>
				/// <java-name>
				/// PERSISTENT_SCROLLING_CACHE
				/// </java-name>
				[Dot42.DexImport("PERSISTENT_SCROLLING_CACHE", "I", AccessFlags = 25)]
				public const int PERSISTENT_SCROLLING_CACHE = 2;
				/// <summary>
				///  <para>Used to indicate that all drawing caches should be kept in memory. </para>        
				/// </summary>
				/// <java-name>
				/// PERSISTENT_ALL_CACHES
				/// </java-name>
				[Dot42.DexImport("PERSISTENT_ALL_CACHES", "I", AccessFlags = 25)]
				public const int PERSISTENT_ALL_CACHES = 3;
				/// <summary>
				///  <para>We clip to padding when FLAG_CLIP_TO_PADDING and FLAG_PADDING_NOT_NULL are set at the same time. </para>        
				/// </summary>
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
				public ViewGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ViewGroup(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Called when a child of this parent wants focus</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// requestChildFocus
				/// </java-name>
				[Dot42.DexImport("requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RequestChildFocus(global::Android.Views.View child, global::Android.Views.View focused) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Tells the parent that a new focusable view has become available. This is to handle transitions from the case where there are no focusable views to the case where the first focusable view appears.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// focusableViewAvailable
				/// </java-name>
				[Dot42.DexImport("focusableViewAvailable", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void FocusableViewAvailable(global::Android.Views.View v) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Bring up a context menu for the specified view or its ancestors.</para> <para>In most cases, a subclass does not need to override this. However, if the subclass is added directly to the window manager (for example, ViewManager#addView(View, android.view.ViewGroup.LayoutParams)) then it should override this and show the context menu.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>true if a context menu was displayed</para>
				/// </returns>
				/// <java-name>
				/// showContextMenuForChild
				/// </java-name>
				[Dot42.DexImport("showContextMenuForChild", "(Landroid/view/View;)Z", AccessFlags = 1)]
				public virtual bool ShowContextMenuForChild(global::Android.Views.View originalView) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Find the nearest view in the specified direction that wants to take focus.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// focusSearch
				/// </java-name>
				[Dot42.DexImport("focusSearch", "(Landroid/view/View;I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FocusSearch(global::Android.Views.View focused, int direction) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para> <para>Called when a child of this group wants a particular rectangle to be positioned onto the screen. ViewGroups overriding this can trust that:  <ul> <li> <para>child will be a direct child of this group </para></li> <li> <para>rectangle will be in the child's coordinates </para></li></ul></para> <para>ViewGroups overriding this should uphold the contract:</para> <para> <ul> <li> <para>nothing will change if the rectangle is already visible </para></li> <li> <para>the view port will be scrolled only just enough to make the rectangle visible  <ul> <li></li></ul>child The direct child making the request. </para></li></ul></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the group scrolled to handle the operation</para>
				/// </returns>
				/// <java-name>
				/// requestChildRectangleOnScreen
				/// </java-name>
				[Dot42.DexImport("requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z", AccessFlags = 1)]
				public virtual bool RequestChildRectangleOnScreen(global::Android.Views.View child, global::Android.Graphics.Rect rectangle, bool immediate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchUnhandledMove
				/// </java-name>
				[Dot42.DexImport("dispatchUnhandledMove", "(Landroid/view/View;I)Z", AccessFlags = 1)]
				public override bool DispatchUnhandledMove(global::Android.Views.View focused, int direction) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Called when a child of this parent is giving up focus</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// clearChildFocus
				/// </java-name>
				[Dot42.DexImport("clearChildFocus", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void ClearChildFocus(global::Android.Views.View child) /* MethodBuilder.Create */ 
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
				public override void AddFocusables(global::Java.Util.ArrayList<global::Android.Views.View> views, int direction, int focusableMode) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public override void DispatchWindowFocusChanged(bool hasFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addTouchables
				/// </java-name>
				[Dot42.DexImport("addTouchables", "(Ljava/util/ArrayList;)V", AccessFlags = 1, Signature = "(Ljava/util/ArrayList<Landroid/view/View;>;)V")]
				public override void AddTouchables(global::Java.Util.ArrayList<global::Android.Views.View> views) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchDisplayHint
				/// </java-name>
				[Dot42.DexImport("dispatchDisplayHint", "(I)V", AccessFlags = 1)]
				public override void DispatchDisplayHint(int hint) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchVisibilityChanged", "(Landroid/view/View;I)V", AccessFlags = 4)]
				protected internal override void DispatchVisibilityChanged(global::Android.Views.View changedView, int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchWindowVisibilityChanged
				/// </java-name>
				[Dot42.DexImport("dispatchWindowVisibilityChanged", "(I)V", AccessFlags = 1)]
				public override void DispatchWindowVisibilityChanged(int visibility) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1)]
				public override void DispatchConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Tell view hierarchy that the global view attributes need to be re-evaluated.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// recomputeViewAttributes
				/// </java-name>
				[Dot42.DexImport("recomputeViewAttributes", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RecomputeViewAttributes(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Change the z order of the child so it's on top of all other children. This ordering change may affect layout, if this container uses an order-dependent layout scheme (e.g., LinearLayout). Prior to android.os.Build.VERSION_CODES#KITKAT this method should be followed by calls to requestLayout() and View#invalidate() on this parent to force the parent to redraw with the new child ordering.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// bringChildToFront
				/// </java-name>
				[Dot42.DexImport("bringChildToFront", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void BringChildToFront(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchKeyEventPreIme
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEventPreIme(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchKeyShortcutEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public override bool DispatchKeyShortcutEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool DispatchTrackballEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public override bool DispatchTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para> <para>Called when a child does not want this parent and its ancestors to intercept touch events with ViewGroup#onInterceptTouchEvent(MotionEvent).</para> <para>This parent should pass this call onto its parents. This parent must obey this request for the duration of the touch (that is, only clear the flag after this parent has received an up or a cancel.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// requestDisallowInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("requestDisallowInterceptTouchEvent", "(Z)V", AccessFlags = 1)]
				public virtual void RequestDisallowInterceptTouchEvent(bool disallowIntercept) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implement this method to intercept all touch screen motion events. This allows you to watch events as they are dispatched to your children, and take ownership of the current gesture at any point.</para> <para>Using this function takes some care, as it has a fairly complicated interaction with View.onTouchEvent(MotionEvent), and using it requires implementing that method as well as this one in the correct way. Events will be received in the following order:</para> <para> <ol> <li> <para>You will receive the down event here. </para></li> <li> <para>The down event will be handled either by a child of this view group, or given to your own onTouchEvent() method to handle; this means you should implement onTouchEvent() to return true, so you will continue to see the rest of the gesture (instead of looking for a parent view to handle it). Also, by returning true from onTouchEvent(), you will not receive any following events in onInterceptTouchEvent() and all touch processing must happen in onTouchEvent() like normal. </para></li> <li> <para>For as long as you return false from this function, each following event (up to and including the final up) will be delivered first here and then to the target's onTouchEvent(). </para></li> <li> <para>If you return true from here, you will not receive any following events: the target view will receive the same event but with the action MotionEvent#ACTION_CANCEL, and all further events will be delivered to your onTouchEvent() method and no longer appear here. </para></li></ol></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Return true to steal motion events from the children and have them dispatched to this ViewGroup through onTouchEvent(). The current target will receive an ACTION_CANCEL event, and no further messages will be delivered here. </para>
				/// </returns>
				/// <java-name>
				/// onInterceptTouchEvent
				/// </java-name>
				[Dot42.DexImport("onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool OnInterceptTouchEvent(global::Android.Views.MotionEvent ev) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Looks for a view to give focus to respecting the setting specified by getDescendantFocusability().</para> <para>Uses onRequestFocusInDescendants(int, android.graphics.Rect) to find focus within the children of this group when appropriate.</para> <para> <para>FOCUS_BEFORE_DESCENDANTS </para> <para>FOCUS_AFTER_DESCENDANTS </para> <para>FOCUS_BLOCK_DESCENDANTS </para> <para>onRequestFocusInDescendants(int, android.graphics.Rect) </para></para>        
				/// </summary>
				/// <java-name>
				/// requestFocus
				/// </java-name>
				[Dot42.DexImport("requestFocus", "(ILandroid/graphics/Rect;)Z", AccessFlags = 1)]
				public override bool RequestFocus(int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Look for a descendant to call View#requestFocus on. Called by ViewGroup#requestFocus(int, android.graphics.Rect) when it wants to request focus within its children. Override this to customize how your ViewGroup requests focus within its children. </para>        
				/// </summary>
				/// <returns>
				///  <para>Whether focus was taken. </para>
				/// </returns>
				/// <java-name>
				/// onRequestFocusInDescendants
				/// </java-name>
				[Dot42.DexImport("onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal virtual bool OnRequestFocusInDescendants(int direction, global::Android.Graphics.Rect previouslyFocusedRect) /* MethodBuilder.Create */ 
				{
						return default(bool);
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
				protected internal override void DispatchSaveInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform dispatching of a saveHierarchyState(android.util.SparseArray) freeze()} to only this view, not to its children. For use when overriding dispatchSaveInstanceState(android.util.SparseArray) dispatchFreeze()} to allow subclasses to freeze their own state but not the state of their children.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchFreezeSelfOnly
				/// </java-name>
				[Dot42.DexImport("dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal virtual void DispatchFreezeSelfOnly(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchRestoreInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform dispatching of a restoreHierarchyState(android.util.SparseArray) to only this view, not to its children. For use when overriding dispatchRestoreInstanceState(android.util.SparseArray) to allow subclasses to thaw their own state but not the state of their children.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// dispatchThawSelfOnly
				/// </java-name>
				[Dot42.DexImport("dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal virtual void DispatchThawSelfOnly(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enables or disables the drawing cache for each child of this view group.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setChildrenDrawingCacheEnabled
				/// </java-name>
				[Dot42.DexImport("setChildrenDrawingCacheEnabled", "(Z)V", AccessFlags = 4)]
				protected internal virtual void SetChildrenDrawingCacheEnabled(bool enabled) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Returns the index of the child to draw for this iteration. Override this if you want to change the drawing order of children. By default, it returns i. </para> <para>NOTE: In order for this method to be called, you must enable child ordering first by calling setChildrenDrawingOrderEnabled(boolean).</para> <para> <para>setChildrenDrawingOrderEnabled(boolean) </para> <para>isChildrenDrawingOrderEnabled() </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The index of the child to draw this iteration.</para>
				/// </returns>
				/// <java-name>
				/// getChildDrawingOrder
				/// </java-name>
				[Dot42.DexImport("getChildDrawingOrder", "(II)I", AccessFlags = 4)]
				protected internal virtual int GetChildDrawingOrder(int childCount, int i) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Draw one child of this View Group. This method is responsible for getting the canvas in the right state. This includes clipping, translating so that the child's scrolled origin is at 0, 0, and applying any animation transformations.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if an invalidate() was issued </para>
				/// </returns>
				/// <java-name>
				/// drawChild
				/// </java-name>
				[Dot42.DexImport("drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", AccessFlags = 4)]
				protected internal virtual bool DrawChild(global::Android.Graphics.Canvas canvas, global::Android.Views.View child, long drawingTime) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>By default, children are clipped to their bounds before drawing. This allows view groups to override this behavior for animations, etc.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setClipChildren
				/// </java-name>
				[Dot42.DexImport("setClipChildren", "(Z)V", AccessFlags = 1)]
				public virtual void SetClipChildren(bool clipChildren) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>By default, children are clipped to the padding of the ViewGroup. This allows view groups to override this behavior</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setClipToPadding
				/// </java-name>
				[Dot42.DexImport("setClipToPadding", "(Z)V", AccessFlags = 1)]
				public virtual void SetClipToPadding(bool clipToPadding) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetSelected
				/// </java-name>
				[Dot42.DexImport("dispatchSetSelected", "(Z)V", AccessFlags = 1)]
				public new virtual void DispatchSetSelected(bool selected) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// dispatchSetPressed
				/// </java-name>
				[Dot42.DexImport("dispatchSetPressed", "(Z)V", AccessFlags = 4)]
				protected internal override void DispatchSetPressed(bool pressed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>When this property is set to true, this ViewGroup supports static transformations on children; this causes getChildStaticTransformation(View, android.view.animation.Transformation) to be invoked when a child is drawn.</para> <para>Any subclass overriding getChildStaticTransformation(View, android.view.animation.Transformation) should set this property to true.</para> <para> <para>getChildStaticTransformation(View, android.view.animation.Transformation) </para></para>        
				/// </summary>
				/// <java-name>
				/// setStaticTransformationsEnabled
				/// </java-name>
				[Dot42.DexImport("setStaticTransformationsEnabled", "(Z)V", AccessFlags = 4)]
				protected internal virtual void SetStaticTransformationsEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Sets  <code>t</code> to be the static transformation of the child, if set, returning a boolean to indicate whether a static transform was set. The default implementation simply returns  <code>false</code>; subclasses may override this method for different behavior. setStaticTransformationsEnabled(boolean) must be set to true for this method to be called.</para> <para> <para>setStaticTransformationsEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the transformation was set, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// getChildStaticTransformation
				/// </java-name>
				[Dot42.DexImport("getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z", AccessFlags = 4)]
				protected internal virtual bool GetChildStaticTransformation(global::Android.Views.View child, global::Android.Views.Animations.Transformation t) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Adds a child view. If no layout parameters are already set on the child, the default parameters for this ViewGroup are set on the child.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para> <para>generateDefaultLayoutParams() </para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a child view. If no layout parameters are already set on the child, the default parameters for this ViewGroup are set on the child.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para> <para>generateDefaultLayoutParams() </para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View child, int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a child view with this ViewGroup's default layout parameters and the specified width and height.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;II)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View child, int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a child view. If no layout parameters are already set on the child, the default parameters for this ViewGroup are set on the child.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para> <para>generateDefaultLayoutParams() </para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View child, global::Android.Views.ViewGroup.LayoutParams index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a child view with this ViewGroup's default layout parameters and the specified width and height.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addView
				/// </java-name>
				[Dot42.DexImport("addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddView(global::Android.Views.View child, int width, global::Android.Views.ViewGroup.LayoutParams height) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateViewLayout
				/// </java-name>
				[Dot42.DexImport("updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void UpdateViewLayout(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkLayoutParams
				/// </java-name>
				[Dot42.DexImport("checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal virtual bool CheckLayoutParams(global::Android.Views.ViewGroup.LayoutParams p) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Register a callback to be invoked when a child is added to or removed from this view.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setOnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", AccessFlags = 1)]
				public virtual void SetOnHierarchyChangeListener(global::Android.Views.ViewGroup.IOnHierarchyChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Adds a view during layout. This is useful if in your onLayout() method, you need to add more views (as does the list view for example).</para> <para>If index is negative, it means put it at the end of the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the child was added, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// addViewInLayout
				/// </java-name>
				[Dot42.DexImport("addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z", AccessFlags = 4)]
				protected internal virtual bool AddViewInLayout(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Adds a view during layout. This is useful if in your onLayout() method, you need to add more views (as does the list view for example).</para> <para>If index is negative, it means put it at the end of the list.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the child was added, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// addViewInLayout
				/// </java-name>
				[Dot42.DexImport("addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z", AccessFlags = 4)]
				protected internal virtual bool AddViewInLayout(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params, bool preventRequestLayout) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Prevents the specified child to be laid out during the next layout pass.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// cleanupLayoutState
				/// </java-name>
				[Dot42.DexImport("cleanupLayoutState", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void CleanupLayoutState(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Subclasses should override this method to set layout animation parameters on the supplied child.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// attachLayoutAnimationParameters
				/// </java-name>
				[Dot42.DexImport("attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V", AccessFlags = 4)]
				protected internal virtual void AttachLayoutAnimationParameters(global::Android.Views.View child, global::Android.Views.ViewGroup.LayoutParams @params, int index, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para>        
				/// </summary>
				/// <java-name>
				/// removeView
				/// </java-name>
				[Dot42.DexImport("removeView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RemoveView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes a view during layout. This is useful if in your onLayout() method, you need to remove more views.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeViewInLayout
				/// </java-name>
				[Dot42.DexImport("removeViewInLayout", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RemoveViewInLayout(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes a range of views during layout. This is useful if in your onLayout() method, you need to remove more views.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeViewsInLayout
				/// </java-name>
				[Dot42.DexImport("removeViewsInLayout", "(II)V", AccessFlags = 1)]
				public virtual void RemoveViewsInLayout(int start, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the view at the specified position in the group.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeViewAt
				/// </java-name>
				[Dot42.DexImport("removeViewAt", "(I)V", AccessFlags = 1)]
				public virtual void RemoveViewAt(int index) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Removes the specified range of views from the group.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// removeViews
				/// </java-name>
				[Dot42.DexImport("removeViews", "(II)V", AccessFlags = 1)]
				public virtual void RemoveViews(int start, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Call this method to remove all child views from the ViewGroup.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para>        
				/// </summary>
				/// <java-name>
				/// removeAllViews
				/// </java-name>
				[Dot42.DexImport("removeAllViews", "()V", AccessFlags = 1)]
				public virtual void RemoveAllViews() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by a ViewGroup subclass to remove child views from itself, when it must first know its size on screen before it can calculate how many child views it will render. An example is a Gallery or a ListView, which may "have" 50 children, but actually only render the number of children that can currently fit inside the object on screen. Do not call this method unless you are extending ViewGroup and understand the view measuring and layout pipeline.</para> <para> <b>Note:</b> do not invoke this method from draw(android.graphics.Canvas), onDraw(android.graphics.Canvas), dispatchDraw(android.graphics.Canvas) or any related method.</para>        
				/// </summary>
				/// <java-name>
				/// removeAllViewsInLayout
				/// </java-name>
				[Dot42.DexImport("removeAllViewsInLayout", "()V", AccessFlags = 1)]
				public virtual void RemoveAllViewsInLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Finishes the removal of a detached view. This method will dispatch the detached from window event and notify the hierarchy change listener. </para> <para>This method is intended to be lightweight and makes no assumptions about whether the parent or child should be redrawn. Proper use of this method will include also making any appropriate requestLayout() or invalidate() calls. For example, callers can post a Runnable which performs a requestLayout() on the next frame, after all detach/remove calls are finished, causing layout to be run prior to redrawing the view hierarchy.</para> <para> <para>attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) </para> <para>detachAllViewsFromParent() </para> <para>detachViewFromParent(View) </para> <para>detachViewFromParent(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// removeDetachedView
				/// </java-name>
				[Dot42.DexImport("removeDetachedView", "(Landroid/view/View;Z)V", AccessFlags = 4)]
				protected internal virtual void RemoveDetachedView(global::Android.Views.View child, bool animate) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Attaches a view to this view group. Attaching a view assigns this group as the parent, sets the layout parameters and puts the view in the list of children so that it can be retrieved by calling getChildAt(int). </para> <para>This method is intended to be lightweight and makes no assumptions about whether the parent or child should be redrawn. Proper use of this method will include also making any appropriate requestLayout() or invalidate() calls. For example, callers can post a Runnable which performs a requestLayout() on the next frame, after all detach/attach calls are finished, causing layout to be run prior to redrawing the view hierarchy. </para> <para>This method should be called only for views which were detached from their parent.</para> <para> <para>removeDetachedView(View, boolean) </para> <para>detachAllViewsFromParent() </para> <para>detachViewFromParent(View) </para> <para>detachViewFromParent(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// attachViewToParent
				/// </java-name>
				[Dot42.DexImport("attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 4)]
				protected internal virtual void AttachViewToParent(global::Android.Views.View child, int index, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Detaches a view from its parent. Detaching a view should be followed either by a call to attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) or a call to removeDetachedView(View, boolean). Detachment should only be temporary; reattachment or removal should happen within the same drawing cycle as detachment. When a view is detached, its parent is null and cannot be retrieved by a call to getChildAt(int).</para> <para> <para>detachViewFromParent(int) </para> <para>detachViewsFromParent(int, int) </para> <para>detachAllViewsFromParent() </para> <para>attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) </para> <para>removeDetachedView(View, boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// detachViewFromParent
				/// </java-name>
				[Dot42.DexImport("detachViewFromParent", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void DetachViewFromParent(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Detaches a view from its parent. Detaching a view should be followed either by a call to attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) or a call to removeDetachedView(View, boolean). Detachment should only be temporary; reattachment or removal should happen within the same drawing cycle as detachment. When a view is detached, its parent is null and cannot be retrieved by a call to getChildAt(int).</para> <para> <para>detachViewFromParent(int) </para> <para>detachViewsFromParent(int, int) </para> <para>detachAllViewsFromParent() </para> <para>attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) </para> <para>removeDetachedView(View, boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// detachViewFromParent
				/// </java-name>
				[Dot42.DexImport("detachViewFromParent", "(I)V", AccessFlags = 4)]
				protected internal virtual void DetachViewFromParent(int child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Detaches a range of views from their parents. Detaching a view should be followed either by a call to attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) or a call to removeDetachedView(View, boolean). Detachment should only be temporary; reattachment or removal should happen within the same drawing cycle as detachment. When a view is detached, its parent is null and cannot be retrieved by a call to getChildAt(int).</para> <para> <para>detachViewFromParent(View) </para> <para>detachViewFromParent(int) </para> <para>detachAllViewsFromParent() </para> <para>attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) </para> <para>removeDetachedView(View, boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// detachViewsFromParent
				/// </java-name>
				[Dot42.DexImport("detachViewsFromParent", "(II)V", AccessFlags = 4)]
				protected internal virtual void DetachViewsFromParent(int start, int count) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Detaches all views from the parent. Detaching a view should be followed either by a call to attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) or a call to removeDetachedView(View, boolean). Detachment should only be temporary; reattachment or removal should happen within the same drawing cycle as detachment. When a view is detached, its parent is null and cannot be retrieved by a call to getChildAt(int).</para> <para> <para>detachViewFromParent(View) </para> <para>detachViewFromParent(int) </para> <para>detachViewsFromParent(int, int) </para> <para>attachViewToParent(View, int, android.view.ViewGroup.LayoutParams) </para> <para>removeDetachedView(View, boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// detachAllViewsFromParent
				/// </java-name>
				[Dot42.DexImport("detachAllViewsFromParent", "()V", AccessFlags = 4)]
				protected internal virtual void DetachAllViewsFromParent() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Don't call or override this method. It is used for the implementation of the view hierarchy. </para>        
				/// </summary>
				/// <java-name>
				/// invalidateChild
				/// </java-name>
				[Dot42.DexImport("invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V", AccessFlags = 17)]
				public void InvalidateChild(global::Android.Views.View child, global::Android.Graphics.Rect dirty) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Don't call or override this method. It is used for the implementation of the view hierarchy.</para> <para>This implementation returns null if this ViewGroup does not have a parent, if this ViewGroup is already fully invalidated or if the dirty rectangle does not intersect with this ViewGroup's bounds. </para>        
				/// </summary>
				/// <java-name>
				/// invalidateChildInParent
				/// </java-name>
				[Dot42.DexImport("invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;", AccessFlags = 1)]
				public virtual global::Android.Views.IViewParent InvalidateChildInParent(int[] location, global::Android.Graphics.Rect dirty) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.IViewParent);
				}

				/// <summary>
				///  <para>Offset a rectangle that is in a descendant's coordinate space into our coordinate space. </para>        
				/// </summary>
				/// <java-name>
				/// offsetDescendantRectToMyCoords
				/// </java-name>
				[Dot42.DexImport("offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V", AccessFlags = 17)]
				public void OffsetDescendantRectToMyCoords(global::Android.Views.View descendant, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Offset a rectangle that is in our coordinate space into an ancestor's coordinate space. </para>        
				/// </summary>
				/// <java-name>
				/// offsetRectIntoDescendantCoords
				/// </java-name>
				[Dot42.DexImport("offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V", AccessFlags = 17)]
				public void OffsetRectIntoDescendantCoords(global::Android.Views.View descendant, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Compute the visible part of a rectangular region defined in terms of a child view's coordinates.</para> <para>Returns the clipped visible part of the rectangle  <code>r</code>, defined in the  <code>child</code>'s local coordinate system.  <code>r</code> is modified by this method to contain the result, expressed in the global (root) coordinate system.</para> <para>The resulting rectangle is always axis aligned. If a rotation is applied to a node in the View hierarchy, the result is the axis-aligned bounding box of the visible rectangle.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>true if the resulting rectangle is not empty, false otherwise</para>
				/// </returns>
				/// <java-name>
				/// getChildVisibleRect
				/// </java-name>
				[Dot42.DexImport("getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z", AccessFlags = 1)]
				public virtual bool GetChildVisibleRect(global::Android.Views.View child, global::Android.Graphics.Rect r, global::Android.Graphics.Point offset) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onLayout
				/// </java-name>
				[Dot42.DexImport("onLayout", "(ZIIII)V", AccessFlags = 1028)]
				protected internal override void OnLayout(bool changed, int l, int t, int r, int b) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Runs the layout animation. Calling this method triggers a relayout of this view group. </para>        
				/// </summary>
				/// <java-name>
				/// startLayoutAnimation
				/// </java-name>
				[Dot42.DexImport("startLayoutAnimation", "()V", AccessFlags = 1)]
				public virtual void StartLayoutAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Schedules the layout animation to be played after the next layout pass of this view group. This can be used to restart the layout animation when the content of the view group changes or when the activity is paused and resumed. </para>        
				/// </summary>
				/// <java-name>
				/// scheduleLayoutAnimation
				/// </java-name>
				[Dot42.DexImport("scheduleLayoutAnimation", "()V", AccessFlags = 1)]
				public virtual void ScheduleLayoutAnimation() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a new set of layout parameters based on the supplied attributes set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an instance of android.view.ViewGroup.LayoutParams or one of its descendants </para>
				/// </returns>
				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 1)]
				public virtual global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <summary>
				///  <para>Returns a new set of layout parameters based on the supplied attributes set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an instance of android.view.ViewGroup.LayoutParams or one of its descendants </para>
				/// </returns>
				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", AccessFlags = 4)]
				protected internal virtual global::Android.Views.ViewGroup.LayoutParams GenerateLayoutParams(global::Android.Views.ViewGroup.LayoutParams attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.ViewGroup.LayoutParams);
				}

				/// <summary>
				///  <para>Returns a set of default layout parameters. These parameters are requested when the View passed to addView(View) has no layout parameters already set. If null is returned, an exception is thrown from addView.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a set of default layout parameters or null </para>
				/// </returns>
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
				protected internal virtual void Debug(int depth) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns the position in the group of the specified child view.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a positive integer representing the position of the view in the group, or -1 if the view does not exist in the group </para>
				/// </returns>
				/// <java-name>
				/// indexOfChild
				/// </java-name>
				[Dot42.DexImport("indexOfChild", "(Landroid/view/View;)I", AccessFlags = 1)]
				public virtual int IndexOfChild(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Returns the view at the specified position in the group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the view at the specified position or null if the position does not exist within the group </para>
				/// </returns>
				/// <java-name>
				/// getChildAt
				/// </java-name>
				[Dot42.DexImport("getChildAt", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View GetChildAt(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Ask all of the children of this view to measure themselves, taking into account both the MeasureSpec requirements for this view and its padding. We skip children that are in the GONE state The heavy lifting is done in getChildMeasureSpec.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// measureChildren
				/// </java-name>
				[Dot42.DexImport("measureChildren", "(II)V", AccessFlags = 4)]
				protected internal virtual void MeasureChildren(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ask one of the children of this view to measure itself, taking into account both the MeasureSpec requirements for this view and its padding. The heavy lifting is done in getChildMeasureSpec.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// measureChild
				/// </java-name>
				[Dot42.DexImport("measureChild", "(Landroid/view/View;II)V", AccessFlags = 4)]
				protected internal virtual void MeasureChild(global::Android.Views.View child, int parentWidthMeasureSpec, int parentHeightMeasureSpec) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Ask one of the children of this view to measure itself, taking into account both the MeasureSpec requirements for this view and its padding and margins. The child must have MarginLayoutParams The heavy lifting is done in getChildMeasureSpec.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// measureChildWithMargins
				/// </java-name>
				[Dot42.DexImport("measureChildWithMargins", "(Landroid/view/View;IIII)V", AccessFlags = 4)]
				protected internal virtual void MeasureChildWithMargins(global::Android.Views.View child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Does the hard part of measureChildren: figuring out the MeasureSpec to pass to a particular child. This method figures out the right MeasureSpec for one dimension (height or width) of one child view.</para> <para>The goal is to combine information from our MeasureSpec with the LayoutParams of the child to get the best possible results. For example, if the this view knows its size (because its MeasureSpec has a mode of EXACTLY), and the child has indicated in its LayoutParams that it wants to be the same size as the parent, the parent should ask the child to layout given an exact size.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a MeasureSpec integer for the child </para>
				/// </returns>
				/// <java-name>
				/// getChildMeasureSpec
				/// </java-name>
				[Dot42.DexImport("getChildMeasureSpec", "(III)I", AccessFlags = 9)]
				public static int GetChildMeasureSpec(int spec, int padding, int childDimension) /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Removes any pending animations for views that have been removed. Call this if you don't want animations for exiting views to stack up. </para>        
				/// </summary>
				/// <java-name>
				/// clearDisappearingChildren
				/// </java-name>
				[Dot42.DexImport("clearDisappearingChildren", "()V", AccessFlags = 1)]
				public virtual void ClearDisappearingChildren() /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para> <para>Called when a child wants the view hierarchy to gather and report transparent regions to the window compositor. Views that "punch" holes in the view hierarchy, such as SurfaceView can use this API to improve performance of the system. When no such a view is present in the hierarchy, this optimization in unnecessary and might slightly reduce the view hierarchy performance.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// requestTransparentRegion
				/// </java-name>
				[Dot42.DexImport("requestTransparentRegion", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void RequestTransparentRegion(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// fitSystemWindows
				/// </java-name>
				[Dot42.DexImport("fitSystemWindows", "(Landroid/graphics/Rect;)Z", AccessFlags = 4)]
				protected internal override bool FitSystemWindows(global::Android.Graphics.Rect insets) /* MethodBuilder.Create */ 
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
				/// onCreateDrawableState
				/// </java-name>
				[Dot42.DexImport("onCreateDrawableState", "(I)[I", AccessFlags = 4)]
				protected internal override int[] OnCreateDrawableState(int extraSpace) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Sets whether this ViewGroup's drawable states also include its children's drawable states. This is used, for example, to make a group appear to be focused when its child EditText or button is focused. </para>        
				/// </summary>
				/// <java-name>
				/// setAddStatesFromChildren
				/// </java-name>
				[Dot42.DexImport("setAddStatesFromChildren", "(Z)V", AccessFlags = 1)]
				public virtual void SetAddStatesFromChildren(bool addsStates) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns whether this ViewGroup's drawable states also include its children's drawable states. This is used, for example, to make a group appear to be focused when its child EditText or button is focused. </para>        
				/// </summary>
				/// <java-name>
				/// addStatesFromChildren
				/// </java-name>
				[Dot42.DexImport("addStatesFromChildren", "()Z", AccessFlags = 1)]
				public virtual bool AddStatesFromChildren() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>If addStatesFromChildren is true, refreshes this group's drawable state (to include the states from its children). </para>        
				/// </summary>
				/// <java-name>
				/// childDrawableStateChanged
				/// </java-name>
				[Dot42.DexImport("childDrawableStateChanged", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void ChildDrawableStateChanged(global::Android.Views.View child) /* MethodBuilder.Create */ 
				{
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
				public override void CreateContextMenu(global::Android.Views.IContextMenu menu) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
				}

				/// <summary>
				///  <para>Gets the descendant focusability of this view group. The descendant focusability defines the relationship between this view group and its descendants when looking for a view to take focus in requestFocus(int, android.graphics.Rect).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>one of FOCUS_BEFORE_DESCENDANTS, FOCUS_AFTER_DESCENDANTS, FOCUS_BLOCK_DESCENDANTS. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the focused child of this view, if any. The child may have focus or contain focus.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the focused child or null. </para>
				/// </returns>
				/// <java-name>
				/// getFocusedChild
				/// </java-name>
				public virtual global::Android.Views.View FocusedChild
				{
						[Dot42.DexImport("getFocusedChild", "()Landroid/view/View;", AccessFlags = 1)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Returns true if this view has or contains focus</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this view has or contains focus </para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether the view group has the ability to animate its children after the first layout.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the children can be animated, false otherwise </para>
				/// </returns>
				/// <java-name>
				/// canAnimate
				/// </java-name>
				protected internal virtual bool CanAnimate
				{
						[Dot42.DexImport("canAnimate", "()Z", AccessFlags = 4)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the layout animation controller used to animate the group's children.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>the current animation controller </para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether the children's drawing cache is used during a layout animation. By default, the drawing cache is enabled but this will prevent nested layout animations from working. To nest animations, you must disable the cache.</para> <para> <para>setAnimationCacheEnabled(boolean) </para> <para>View::setDrawingCacheEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the animation cache is enabled, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether this ViewGroup will always try to draw its children using their drawing cache. By default this property is enabled.</para> <para> <para>setAlwaysDrawnWithCacheEnabled(boolean) </para> <para>setChildrenDrawnWithCacheEnabled(boolean) </para> <para>View::setDrawingCacheEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if the animation cache is enabled, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether the ViewGroup is currently drawing its children using their drawing cache.</para> <para> <para>setAlwaysDrawnWithCacheEnabled(boolean) </para> <para>setChildrenDrawnWithCacheEnabled(boolean) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if children should be drawn with their cache, false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Indicates whether the ViewGroup is drawing its children in the order defined by getChildDrawingOrder(int, int).</para> <para> <para>setChildrenDrawingOrderEnabled(boolean) </para> <para>getChildDrawingOrder(int, int) </para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if children drawing order is defined by getChildDrawingOrder(int, int), false otherwise</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns an integer indicating what types of drawing caches are kept in memory.</para> <para> <para>setPersistentDrawingCache(int) </para> <para>setAnimationCacheEnabled(boolean)</para></para>        
				/// </summary>
				/// <returns>
				///  <para>one or a combination of PERSISTENT_NO_CACHE, PERSISTENT_ANIMATION_CACHE, PERSISTENT_SCROLLING_CACHE and PERSISTENT_ALL_CACHES </para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the number of children in the group.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a positive integer representing the number of children in the group </para>
				/// </returns>
				/// <java-name>
				/// getChildCount
				/// </java-name>
				public virtual int ChildCount
				{
						[Dot42.DexImport("getChildCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Returns the animation listener to which layout animation events are sent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>an android.view.animation.Animation.AnimationListener </para>
				/// </returns>
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

				/// <summary>
				///  <para>Per-child layout information for layouts that support margins. See ViewGroup Margin Layout Attributes for a list of all child view attributes that this class supports. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewGroup$MarginLayoutParams
				/// </java-name>
				[Dot42.DexImport("android/view/ViewGroup$MarginLayoutParams", AccessFlags = 9)]
				public partial class MarginLayoutParams : global::Android.Views.ViewGroup.LayoutParams
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>The left margin in pixels of the child. Call ViewGroup#setLayoutParams(LayoutParams) after reassigning a new value to this field. </para>        
						/// </summary>
						/// <java-name>
						/// leftMargin
						/// </java-name>
						[Dot42.DexImport("leftMargin", "I", AccessFlags = 1)]
						public int LeftMargin;
						/// <summary>
						///  <para>The top margin in pixels of the child. Call ViewGroup#setLayoutParams(LayoutParams) after reassigning a new value to this field. </para>        
						/// </summary>
						/// <java-name>
						/// topMargin
						/// </java-name>
						[Dot42.DexImport("topMargin", "I", AccessFlags = 1)]
						public int TopMargin;
						/// <summary>
						///  <para>The right margin in pixels of the child. Call ViewGroup#setLayoutParams(LayoutParams) after reassigning a new value to this field. </para>        
						/// </summary>
						/// <java-name>
						/// rightMargin
						/// </java-name>
						[Dot42.DexImport("rightMargin", "I", AccessFlags = 1)]
						public int RightMargin;
						/// <summary>
						///  <para>The bottom margin in pixels of the child. Call ViewGroup#setLayoutParams(LayoutParams) after reassigning a new value to this field. </para>        
						/// </summary>
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

						/// <summary>
						///  <para>Sets the margins, in pixels. A call to android.view.View#requestLayout() needs to be done so that the new margins are taken into account. Left and right margins may be overriden by android.view.View#requestLayout() depending on layout direction.</para> <para>ref android.R.styleable::ViewGroup_MarginLayout_layout_marginLeft  ref android.R.styleable::ViewGroup_MarginLayout_layout_marginTop  ref android.R.styleable::ViewGroup_MarginLayout_layout_marginRight  ref android.R.styleable::ViewGroup_MarginLayout_layout_marginBottom </para>        
						/// </summary>
						/// <java-name>
						/// setMargins
						/// </java-name>
						[Dot42.DexImport("setMargins", "(IIII)V", AccessFlags = 1)]
						public virtual void SetMargins(int left, int top, int right, int bottom) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal MarginLayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>LayoutParams are used by views to tell their parents how they want to be laid out. See ViewGroup Layout Attributes for a list of all child view attributes that this class supports.</para> <para>The base LayoutParams class just describes how big the view wants to be for both width and height. For each dimension, it can specify one of:  <ul> <li> <para>FILL_PARENT (renamed MATCH_PARENT in API Level 8 and higher), which means that the view wants to be as big as its parent (minus padding) </para></li> <li> <para>WRAP_CONTENT, which means that the view wants to be just big enough to enclose its content (plus padding) </para></li> <li> <para>an exact number </para></li></ul>There are subclasses of LayoutParams for different subclasses of ViewGroup. For example, AbsoluteLayout has its own subclass of LayoutParams which adds an X and Y value.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating user interface layouts, read the  developer guide.</para> <para></para> <para>ref android.R.styleable::ViewGroup_Layout_layout_height  ref android.R.styleable::ViewGroup_Layout_layout_width </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewGroup$LayoutParams
				/// </java-name>
				[Dot42.DexImport("android/view/ViewGroup$LayoutParams", AccessFlags = 9)]
				public partial class LayoutParams
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Special value for the height or width requested by a View. FILL_PARENT means that the view wants to be as big as its parent, minus the parent's padding, if any. This value is deprecated starting in API Level 8 and replaced by MATCH_PARENT. </para>        
						/// </summary>
						/// <java-name>
						/// FILL_PARENT
						/// </java-name>
						[Dot42.DexImport("FILL_PARENT", "I", AccessFlags = 25)]
						public const int FILL_PARENT = -1;
						/// <summary>
						///  <para>Special value for the height or width requested by a View. MATCH_PARENT means that the view wants to be as big as its parent, minus the parent's padding, if any. Introduced in API Level 8. </para>        
						/// </summary>
						/// <java-name>
						/// MATCH_PARENT
						/// </java-name>
						[Dot42.DexImport("MATCH_PARENT", "I", AccessFlags = 25)]
						public const int MATCH_PARENT = -1;
						/// <summary>
						///  <para>Special value for the height or width requested by a View. WRAP_CONTENT means that the view wants to be just large enough to fit its own internal content, taking its own padding into account. </para>        
						/// </summary>
						/// <java-name>
						/// WRAP_CONTENT
						/// </java-name>
						[Dot42.DexImport("WRAP_CONTENT", "I", AccessFlags = 25)]
						public const int WRAP_CONTENT = -2;
						/// <summary>
						///  <para>Information about how wide the view wants to be. Can be one of the constants FILL_PARENT (replaced by MATCH_PARENT , in API Level 8) or WRAP_CONTENT. or an exact size. </para>        
						/// </summary>
						/// <java-name>
						/// width
						/// </java-name>
						[Dot42.DexImport("width", "I", AccessFlags = 1)]
						public int Width;
						/// <summary>
						///  <para>Information about how tall the view wants to be. Can be one of the constants FILL_PARENT (replaced by MATCH_PARENT , in API Level 8) or WRAP_CONTENT. or an exact size. </para>        
						/// </summary>
						/// <java-name>
						/// height
						/// </java-name>
						[Dot42.DexImport("height", "I", AccessFlags = 1)]
						public int Height;
						/// <summary>
						///  <para>Used to animate layouts. </para>        
						/// </summary>
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

						/// <summary>
						///  <para>Extracts the layout parameters from the supplied attributes.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// setBaseAttributes
						/// </java-name>
						[Dot42.DexImport("setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", AccessFlags = 4)]
						protected internal virtual void SetBaseAttributes(global::Android.Content.Res.TypedArray a, int widthAttr, int heightAttr) /* MethodBuilder.Create */ 
						{
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal LayoutParams() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the hierarchy within this view changed. The hierarchy changes whenever a child is added to or removed from this view. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewGroup$OnHierarchyChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewGroup$OnHierarchyChangeListener", AccessFlags = 1545)]
				public partial interface IOnHierarchyChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called when a new child is added to a parent view.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onChildViewAdded
						/// </java-name>
						[Dot42.DexImport("onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1025)]
						void OnChildViewAdded(global::Android.Views.View parent, global::Android.Views.View child) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a child is removed from a parent view.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onChildViewRemoved
						/// </java-name>
						[Dot42.DexImport("onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1025)]
						void OnChildViewRemoved(global::Android.Views.View parent, global::Android.Views.View child) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A ViewStub is an invisible, zero-sized View that can be used to lazily inflate layout resources at runtime.</para> <para>When a ViewStub is made visible, or when inflate() is invoked, the layout resource is inflated. The ViewStub then replaces itself in its parent with the inflated View or Views. Therefore, the ViewStub exists in the view hierarchy until setVisibility(int) or inflate() is invoked.</para> <para>The inflated View is added to the ViewStub's parent with the ViewStub's layout parameters. Similarly, you can define/override the inflate View's id by using the ViewStub's inflatedId property. For instance:</para> <para> <pre>
		///     &lt;ViewStub android:id="@+id/stub"
		///               android:inflatedId="@+id/subTree"
		///               android:layout="@layout/mySubTree"
		///               android:layout_width="120dip"
		///               android:layout_height="40dip" /&gt;
		/// </pre></para> <para>The ViewStub thus defined can be found using the id "stub." After inflation of the layout resource "mySubTree," the ViewStub is removed from its parent. The View created by inflating the layout resource "mySubTree" can be found using the id "subTree," specified by the inflatedId property. The inflated View is finally assigned a width of 120dip and a height of 40dip.</para> <para>The preferred way to perform the inflation of the layout resource is the following:</para> <para> <pre>
		///     ViewStub stub = (ViewStub) findViewById(R.id.stub);
		///     View inflated = stub.inflate();
		/// </pre></para> <para>When inflate() is invoked, the ViewStub is replaced by the inflated View and the inflated View is returned. This lets applications get a reference to the inflated View without executing an extra findViewById().</para> <para>ref android.R.styleable::ViewStub_inflatedId  ref android.R.styleable::ViewStub_layout </para>    
		/// </summary>
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

				/// <summary>
				///  <para>Creates a new ViewStub with the specified layout resource.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public ViewStub(global::Android.Content.Context context, int layoutResource) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new ViewStub with the specified layout resource.</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", AccessFlags = 1)]
				public ViewStub(global::Android.Content.Context context, global::Android.Util.IAttributeSet layoutResource) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", AccessFlags = 1)]
				public ViewStub(global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onMeasure
				/// </java-name>
				[Dot42.DexImport("onMeasure", "(II)V", AccessFlags = 4)]
				protected internal override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Inflates the layout resource identified by getLayoutResource() and replaces this StubbedView in its parent by the inflated layout resource.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The inflated layout resource. </para>
				/// </returns>
				/// <java-name>
				/// inflate
				/// </java-name>
				[Dot42.DexImport("inflate", "()Landroid/view/View;", AccessFlags = 1)]
				public global::Android.Views.View Inflate() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Specifies the inflate listener to be notified after this ViewStub successfully inflated its layout resource.</para> <para> <para>android.view.ViewStub.OnInflateListener </para></para>        
				/// </summary>
				/// <java-name>
				/// setOnInflateListener
				/// </java-name>
				[Dot42.DexImport("setOnInflateListener", "(Landroid/view/ViewStub$OnInflateListener;)V", AccessFlags = 1)]
				public void SetOnInflateListener(global::Android.Views.ViewStub.IOnInflateListener inflateListener) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal ViewStub() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Returns the id taken by the inflated view. If the inflated id is View#NO_ID, the inflated view keeps its original id.</para> <para> <para>setInflatedId(int)  ref android.R.styleable::ViewStub_inflatedId </para></para>        
				/// </summary>
				/// <returns>
				///  <para>A positive integer used to identify the inflated view or NO_ID if the inflated view should keep its id.</para>
				/// </returns>
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

				/// <summary>
				///  <para>Returns the layout resource that will be used by setVisibility(int) or inflate() to replace this StubbedView in its parent by another view.</para> <para> <para>setLayoutResource(int) </para> <para>setVisibility(int) </para> <para>inflate()  ref android.R.styleable::ViewStub_layout </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The layout resource identifier used to inflate the new View.</para>
				/// </returns>
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

				/// <summary>
				///  <para>When visibility is set to VISIBLE or INVISIBLE, inflate() is invoked and this StubbedView is replaced in its parent by the inflated layout resource. After that calls to this function are passed through to the inflated view.</para> <para> <para>inflate() </para></para>        
				/// </summary>
				/// <java-name>
				/// setVisibility
				/// </java-name>
				public override int Visibility
				{
						[Dot42.DexImport("setVisibility", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Listener used to receive a notification after a ViewStub has successfully inflated its layout resource.</para> <para> <para>android.view.ViewStub::setOnInflateListener(android.view.ViewStub.OnInflateListener) </para></para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewStub$OnInflateListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewStub$OnInflateListener", AccessFlags = 1545)]
				public partial interface IOnInflateListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Invoked after a ViewStub successfully inflated its layout resource. This method is invoked after the inflated view was added to the hierarchy but before the layout pass.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onInflate
						/// </java-name>
						[Dot42.DexImport("onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V", AccessFlags = 1025)]
						void OnInflate(global::Android.Views.ViewStub stub, global::Android.Views.View inflated) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>A view tree observer is used to register listeners that can be notified of global changes in the view tree. Such global events include, but are not limited to, layout of the whole tree, beginning of the drawing pass, touch mode change....</para> <para>A ViewTreeObserver should never be instantiated by applications as it is provided by the views hierarchy. Refer to android.view.View#getViewTreeObserver() for more information. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/ViewTreeObserver
		/// </java-name>
		[Dot42.DexImport("android/view/ViewTreeObserver", AccessFlags = 49)]
		public sealed partial class ViewTreeObserver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Creates a new ViewTreeObserver. This constructor should not be called </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal ViewTreeObserver() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the focus state within the view tree changes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addOnGlobalFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("addOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V", AccessFlags = 1)]
				public void AddOnGlobalFocusChangeListener(global::Android.Views.ViewTreeObserver.IOnGlobalFocusChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a previously installed focus change callback.</para> <para> <para>addOnGlobalFocusChangeListener(OnGlobalFocusChangeListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// removeOnGlobalFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("removeOnGlobalFocusChangeListener", "(Landroid/view/ViewTreeObserver$OnGlobalFocusChangeListener;)V", AccessFlags = 1)]
				public void RemoveOnGlobalFocusChangeListener(global::Android.Views.ViewTreeObserver.IOnGlobalFocusChangeListener victim) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the global layout state or the visibility of views within the view tree changes</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addOnGlobalLayoutListener
				/// </java-name>
				[Dot42.DexImport("addOnGlobalLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V", AccessFlags = 1)]
				public void AddOnGlobalLayoutListener(global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a previously installed global layout callback</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use removeOnGlobalLayoutListener instead</para></xrefdescription></xrefsect></para> <para> <para>addOnGlobalLayoutListener(OnGlobalLayoutListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// removeGlobalOnLayoutListener
				/// </java-name>
				[Dot42.DexImport("removeGlobalOnLayoutListener", "(Landroid/view/ViewTreeObserver$OnGlobalLayoutListener;)V", AccessFlags = 1)]
				public void RemoveGlobalOnLayoutListener(global::Android.Views.ViewTreeObserver.IOnGlobalLayoutListener victim) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the view tree is about to be drawn</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addOnPreDrawListener
				/// </java-name>
				[Dot42.DexImport("addOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V", AccessFlags = 1)]
				public void AddOnPreDrawListener(global::Android.Views.ViewTreeObserver.IOnPreDrawListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a previously installed pre-draw callback</para> <para> <para>addOnPreDrawListener(OnPreDrawListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// removeOnPreDrawListener
				/// </java-name>
				[Dot42.DexImport("removeOnPreDrawListener", "(Landroid/view/ViewTreeObserver$OnPreDrawListener;)V", AccessFlags = 1)]
				public void RemoveOnPreDrawListener(global::Android.Views.ViewTreeObserver.IOnPreDrawListener victim) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when a view has been scrolled.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addOnScrollChangedListener
				/// </java-name>
				[Dot42.DexImport("addOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V", AccessFlags = 1)]
				public void AddOnScrollChangedListener(global::Android.Views.ViewTreeObserver.IOnScrollChangedListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a previously installed scroll-changed callback</para> <para> <para>addOnScrollChangedListener(OnScrollChangedListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// removeOnScrollChangedListener
				/// </java-name>
				[Dot42.DexImport("removeOnScrollChangedListener", "(Landroid/view/ViewTreeObserver$OnScrollChangedListener;)V", AccessFlags = 1)]
				public void RemoveOnScrollChangedListener(global::Android.Views.ViewTreeObserver.IOnScrollChangedListener victim) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Register a callback to be invoked when the invoked when the touch mode changes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addOnTouchModeChangeListener
				/// </java-name>
				[Dot42.DexImport("addOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V", AccessFlags = 1)]
				public void AddOnTouchModeChangeListener(global::Android.Views.ViewTreeObserver.IOnTouchModeChangeListener listener) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove a previously installed touch mode change callback</para> <para> <para>addOnTouchModeChangeListener(OnTouchModeChangeListener) </para></para>        
				/// </summary>
				/// <java-name>
				/// removeOnTouchModeChangeListener
				/// </java-name>
				[Dot42.DexImport("removeOnTouchModeChangeListener", "(Landroid/view/ViewTreeObserver$OnTouchModeChangeListener;)V", AccessFlags = 1)]
				public void RemoveOnTouchModeChangeListener(global::Android.Views.ViewTreeObserver.IOnTouchModeChangeListener victim) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies registered listeners that a global layout happened. This can be called manually if you are forcing a layout on a View or a hierarchy of Views that are not attached to a Window or in the GONE state. </para>        
				/// </summary>
				/// <java-name>
				/// dispatchOnGlobalLayout
				/// </java-name>
				[Dot42.DexImport("dispatchOnGlobalLayout", "()V", AccessFlags = 17)]
				public void DispatchOnGlobalLayout() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies registered listeners that the drawing pass is about to start. If a listener returns true, then the drawing pass is canceled and rescheduled. This can be called manually if you are forcing the drawing on a View or a hierarchy of Views that are not attached to a Window or in the GONE state.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if the current draw should be canceled and resceduled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// dispatchOnPreDraw
				/// </java-name>
				[Dot42.DexImport("dispatchOnPreDraw", "()Z", AccessFlags = 17)]
				public bool DispatchOnPreDraw() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Indicates whether this ViewTreeObserver is alive. When an observer is not alive, any call to a method (except this one) will throw an exception.</para> <para>If an application keeps a long-lived reference to this ViewTreeObserver, it should always check for the result of this method before calling any other method.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if this object is alive and be used, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isAlive
				/// </java-name>
				public bool IsAlive
				{
						[Dot42.DexImport("isAlive", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when something in the view tree has been scrolled. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewTreeObserver$OnScrollChangedListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnScrollChangedListener", AccessFlags = 1545)]
				public partial interface IOnScrollChangedListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when something in the view tree has been scrolled. </para>        
						/// </summary>
						/// <java-name>
						/// onScrollChanged
						/// </java-name>
						[Dot42.DexImport("onScrollChanged", "()V", AccessFlags = 1025)]
						void OnScrollChanged() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the touch mode changes. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewTreeObserver$OnTouchModeChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnTouchModeChangeListener", AccessFlags = 1545)]
				public partial interface IOnTouchModeChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when the touch mode changes.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onTouchModeChanged
						/// </java-name>
						[Dot42.DexImport("onTouchModeChanged", "(Z)V", AccessFlags = 1025)]
						void OnTouchModeChanged(bool isInTouchMode) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the view tree is about to be drawn. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewTreeObserver$OnPreDrawListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnPreDrawListener", AccessFlags = 1545)]
				public partial interface IOnPreDrawListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when the view tree is about to be drawn. At this point, all views in the tree have been measured and given a frame. Clients can use this to adjust their scroll bounds or even to request a new layout before drawing occurs.</para> <para> <para>android.view.View::onMeasure </para> <para>android.view.View::onLayout </para> <para>android.view.View::onDraw </para></para>        
						/// </summary>
						/// <returns>
						///  <para>Return true to proceed with the current drawing pass, or false to cancel.</para>
						/// </returns>
						/// <java-name>
						/// onPreDraw
						/// </java-name>
						[Dot42.DexImport("onPreDraw", "()Z", AccessFlags = 1025)]
						bool OnPreDraw() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the global layout state or the visibility of views within the view tree changes. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewTreeObserver$OnGlobalLayoutListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnGlobalLayoutListener", AccessFlags = 1545)]
				public partial interface IOnGlobalLayoutListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when the global layout state or the visibility of views within the view tree changes </para>        
						/// </summary>
						/// <java-name>
						/// onGlobalLayout
						/// </java-name>
						[Dot42.DexImport("onGlobalLayout", "()V", AccessFlags = 1025)]
						void OnGlobalLayout() /* MethodBuilder.Create */ ;

				}

				/// <summary>
				///  <para>Interface definition for a callback to be invoked when the focus state within the view tree changes. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/ViewTreeObserver$OnGlobalFocusChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/ViewTreeObserver$OnGlobalFocusChangeListener", AccessFlags = 1545)]
				public partial interface IOnGlobalFocusChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Callback method to be invoked when the focus changes in the view tree. When the view tree transitions from touch mode to non-touch mode, oldFocus is null. When the view tree transitions from non-touch mode to touch mode, newFocus is null. When focus changes in non-touch mode (without transition from or to touch mode) either oldFocus or newFocus can be null.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onGlobalFocusChanged
						/// </java-name>
						[Dot42.DexImport("onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", AccessFlags = 1025)]
						void OnGlobalFocusChanged(global::Android.Views.View oldFocus, global::Android.Views.View newFocus) /* MethodBuilder.Create */ ;

				}

		}

		/// <summary>
		///  <para>Abstract base class for a top-level window look and behavior policy. An instance of this class should be used as the top-level view added to the window manager. It provides standard UI policies such as a background, title area, default key processing, etc.</para> <para>The only existing implementation of this abstract class is android.policy.PhoneWindow, which you should instantiate when needing a Window. Eventually that class will be refactored and a factory method added for creating Window instances without knowing about a particular implementation. </para>    
		/// </summary>
		/// <java-name>
		/// android/view/Window
		/// </java-name>
		[Dot42.DexImport("android/view/Window", AccessFlags = 1057)]
		public abstract partial class Window
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Flag for the "options panel" feature. This is enabled by default. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_OPTIONS_PANEL
				/// </java-name>
				[Dot42.DexImport("FEATURE_OPTIONS_PANEL", "I", AccessFlags = 25)]
				public const int FEATURE_OPTIONS_PANEL = 0;
				/// <summary>
				///  <para>Flag for the "no title" feature, turning off the title at the top of the screen. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_NO_TITLE
				/// </java-name>
				[Dot42.DexImport("FEATURE_NO_TITLE", "I", AccessFlags = 25)]
				public const int FEATURE_NO_TITLE = 1;
				/// <summary>
				///  <para>Flag for the progress indicator feature </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_PROGRESS
				/// </java-name>
				[Dot42.DexImport("FEATURE_PROGRESS", "I", AccessFlags = 25)]
				public const int FEATURE_PROGRESS = 2;
				/// <summary>
				///  <para>Flag for having an icon on the left side of the title bar </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_LEFT_ICON
				/// </java-name>
				[Dot42.DexImport("FEATURE_LEFT_ICON", "I", AccessFlags = 25)]
				public const int FEATURE_LEFT_ICON = 3;
				/// <summary>
				///  <para>Flag for having an icon on the right side of the title bar </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_RIGHT_ICON
				/// </java-name>
				[Dot42.DexImport("FEATURE_RIGHT_ICON", "I", AccessFlags = 25)]
				public const int FEATURE_RIGHT_ICON = 4;
				/// <summary>
				///  <para>Flag for indeterminate progress </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_INDETERMINATE_PROGRESS
				/// </java-name>
				[Dot42.DexImport("FEATURE_INDETERMINATE_PROGRESS", "I", AccessFlags = 25)]
				public const int FEATURE_INDETERMINATE_PROGRESS = 5;
				/// <summary>
				///  <para>Flag for the context menu. This is enabled by default. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_CONTEXT_MENU
				/// </java-name>
				[Dot42.DexImport("FEATURE_CONTEXT_MENU", "I", AccessFlags = 25)]
				public const int FEATURE_CONTEXT_MENU = 6;
				/// <summary>
				///  <para>Flag for custom title. You cannot combine this feature with other title features. </para>        
				/// </summary>
				/// <java-name>
				/// FEATURE_CUSTOM_TITLE
				/// </java-name>
				[Dot42.DexImport("FEATURE_CUSTOM_TITLE", "I", AccessFlags = 25)]
				public const int FEATURE_CUSTOM_TITLE = 7;
				/// <summary>
				///  <para>Flag for setting the progress bar's visibility to VISIBLE </para>        
				/// </summary>
				/// <java-name>
				/// PROGRESS_VISIBILITY_ON
				/// </java-name>
				[Dot42.DexImport("PROGRESS_VISIBILITY_ON", "I", AccessFlags = 25)]
				public const int PROGRESS_VISIBILITY_ON = -1;
				/// <summary>
				///  <para>Flag for setting the progress bar's visibility to GONE </para>        
				/// </summary>
				/// <java-name>
				/// PROGRESS_VISIBILITY_OFF
				/// </java-name>
				[Dot42.DexImport("PROGRESS_VISIBILITY_OFF", "I", AccessFlags = 25)]
				public const int PROGRESS_VISIBILITY_OFF = -2;
				/// <summary>
				///  <para>Flag for setting the progress bar's indeterminate mode on </para>        
				/// </summary>
				/// <java-name>
				/// PROGRESS_INDETERMINATE_ON
				/// </java-name>
				[Dot42.DexImport("PROGRESS_INDETERMINATE_ON", "I", AccessFlags = 25)]
				public const int PROGRESS_INDETERMINATE_ON = -3;
				/// <summary>
				///  <para>Flag for setting the progress bar's indeterminate mode off </para>        
				/// </summary>
				/// <java-name>
				/// PROGRESS_INDETERMINATE_OFF
				/// </java-name>
				[Dot42.DexImport("PROGRESS_INDETERMINATE_OFF", "I", AccessFlags = 25)]
				public const int PROGRESS_INDETERMINATE_OFF = -4;
				/// <summary>
				///  <para>Starting value for the (primary) progress </para>        
				/// </summary>
				/// <java-name>
				/// PROGRESS_START
				/// </java-name>
				[Dot42.DexImport("PROGRESS_START", "I", AccessFlags = 25)]
				public const int PROGRESS_START = 0;
				/// <summary>
				///  <para>Ending value for the (primary) progress </para>        
				/// </summary>
				/// <java-name>
				/// PROGRESS_END
				/// </java-name>
				[Dot42.DexImport("PROGRESS_END", "I", AccessFlags = 25)]
				public const int PROGRESS_END = 10000;
				/// <summary>
				///  <para>Lowest possible value for the secondary progress </para>        
				/// </summary>
				/// <java-name>
				/// PROGRESS_SECONDARY_START
				/// </java-name>
				[Dot42.DexImport("PROGRESS_SECONDARY_START", "I", AccessFlags = 25)]
				public const int PROGRESS_SECONDARY_START = 20000;
				/// <summary>
				///  <para>Highest possible value for the secondary progress </para>        
				/// </summary>
				/// <java-name>
				/// PROGRESS_SECONDARY_END
				/// </java-name>
				[Dot42.DexImport("PROGRESS_SECONDARY_END", "I", AccessFlags = 25)]
				public const int PROGRESS_SECONDARY_END = 30000;
				/// <summary>
				///  <para>The default features enabled </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT_FEATURES
				/// </java-name>
				[Dot42.DexImport("DEFAULT_FEATURES", "I", AccessFlags = 28)]
				protected internal const int DEFAULT_FEATURES = 65;
				/// <summary>
				///  <para>The ID that the main layout in the XML layout file should have. </para>        
				/// </summary>
				/// <java-name>
				/// ID_ANDROID_CONTENT
				/// </java-name>
				[Dot42.DexImport("ID_ANDROID_CONTENT", "I", AccessFlags = 25)]
				public const int ID_ANDROID_CONTENT = 16908290;
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public Window(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the window manager for use by this Window to, for example, display panels. This is  <b>not</b> used for displaying the Window itself  that must be done by the client.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setWindowManager
				/// </java-name>
				[Dot42.DexImport("setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetWindowManager(global::Android.Views.IWindowManager wm, global::Android.OS.IBinder appToken, string appName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Take ownership of this window's surface. The window's view hierarchy will no longer draw into the surface, though it will otherwise continue to operate (such as for receiving input events). The given SurfaceHolder callback will be used to tell you about state changes to the surface. </para>        
				/// </summary>
				/// <java-name>
				/// takeSurface
				/// </java-name>
				[Dot42.DexImport("takeSurface", "(Landroid/view/SurfaceHolder$Callback2;)V", AccessFlags = 1025)]
				public abstract void TakeSurface(global::Android.Views.ISurfaceHolder_ICallback2 callback) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Take ownership of this window's InputQueue. The window will no longer read and dispatch input events from the queue; it is your responsibility to do so. </para>        
				/// </summary>
				/// <java-name>
				/// takeInputQueue
				/// </java-name>
				[Dot42.DexImport("takeInputQueue", "(Landroid/view/InputQueue$Callback;)V", AccessFlags = 1025)]
				public abstract void TakeInputQueue(global::Android.Views.InputQueue.ICallback callback) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the width and height layout parameters of the window. The default for both of these is MATCH_PARENT; you can change them to WRAP_CONTENT or an absolute value to make a window that is not full-screen.</para> <para> <para>ViewGroup.LayoutParams::height </para> <para>ViewGroup.LayoutParams::width </para></para>        
				/// </summary>
				/// <java-name>
				/// setLayout
				/// </java-name>
				[Dot42.DexImport("setLayout", "(II)V", AccessFlags = 1)]
				public virtual void SetLayout(int width, int height) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the gravity of the window, as per the Gravity constants. This controls how the window manager is positioned in the overall window; it is only useful when using WRAP_CONTENT for the layout width or height.</para> <para> <para>Gravity </para> <para>setLayout </para></para>        
				/// </summary>
				/// <java-name>
				/// setGravity
				/// </java-name>
				[Dot42.DexImport("setGravity", "(I)V", AccessFlags = 1)]
				public virtual void SetGravity(int gravity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the type of the window, as per the WindowManager.LayoutParams types.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setType
				/// </java-name>
				[Dot42.DexImport("setType", "(I)V", AccessFlags = 1)]
				public virtual void SetType(int type) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the format of window, as per the PixelFormat types. This overrides the default format that is selected by the Window based on its window decorations.</para> <para> <para>PixelFormat </para></para>        
				/// </summary>
				/// <java-name>
				/// setFormat
				/// </java-name>
				[Dot42.DexImport("setFormat", "(I)V", AccessFlags = 1)]
				public virtual void SetFormat(int format) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specify custom animations to use for the window, as per WindowManager.LayoutParams.windowAnimations. Providing anything besides 0 here will override the animations the window would normally retrieve from its theme. </para>        
				/// </summary>
				/// <java-name>
				/// setWindowAnimations
				/// </java-name>
				[Dot42.DexImport("setWindowAnimations", "(I)V", AccessFlags = 1)]
				public virtual void SetWindowAnimations(int resId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specify an explicit soft input mode to use for the window, as per WindowManager.LayoutParams.softInputMode. Providing anything besides "unspecified" here will override the input mode the window would normally retrieve from its theme. </para>        
				/// </summary>
				/// <java-name>
				/// setSoftInputMode
				/// </java-name>
				[Dot42.DexImport("setSoftInputMode", "(I)V", AccessFlags = 1)]
				public virtual void SetSoftInputMode(int mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience function to set the flag bits as specified in flags, as per setFlags.  <para>setFlags </para> <para>clearFlags </para></para>        
				/// </summary>
				/// <java-name>
				/// addFlags
				/// </java-name>
				[Dot42.DexImport("addFlags", "(I)V", AccessFlags = 1)]
				public virtual void AddFlags(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Convenience function to clear the flag bits as specified in flags, as per setFlags.  <para>setFlags </para> <para>addFlags </para></para>        
				/// </summary>
				/// <java-name>
				/// clearFlags
				/// </java-name>
				[Dot42.DexImport("clearFlags", "(I)V", AccessFlags = 1)]
				public virtual void ClearFlags(int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the flags of the window, as per the WindowManager.LayoutParams flags.</para> <para>Note that some flags must be set before the window decoration is created (by the first call to setContentView(View, android.view.ViewGroup.LayoutParams) or getDecorView(): WindowManager.LayoutParams#FLAG_LAYOUT_IN_SCREEN and WindowManager.LayoutParams#FLAG_LAYOUT_INSET_DECOR. These will be set for you based on the android.R.attr#windowIsFloating attribute.</para> <para> <para>addFlags </para> <para>clearFlags </para></para>        
				/// </summary>
				/// <java-name>
				/// setFlags
				/// </java-name>
				[Dot42.DexImport("setFlags", "(II)V", AccessFlags = 1)]
				public virtual void SetFlags(int flags, int mask) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Enable extended screen features. This must be called before setContentView(). May be called as many times as desired as long as it is before setContentView(). If not called, no extended features will be available. You can not turn off a feature once it is requested. You canot use other title features with FEATURE_CUSTOM_TITLE.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The features that are now set. </para>
				/// </returns>
				/// <java-name>
				/// requestFeature
				/// </java-name>
				[Dot42.DexImport("requestFeature", "(I)Z", AccessFlags = 1)]
				public virtual bool RequestFeature(int featureId) /* MethodBuilder.Create */ 
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

				/// <summary>
				///  <para>Finds a view that was identified by the id attribute from the XML that was processed in android.app.Activity#onCreate. This will implicitly call getDecorView for you, with all of the associated side-effects.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The view if found or null otherwise. </para>
				/// </returns>
				/// <java-name>
				/// findViewById
				/// </java-name>
				[Dot42.DexImport("findViewById", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.Views.View FindViewById(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.View);
				}

				/// <summary>
				///  <para>Convenience for setContentView(View, android.view.ViewGroup.LayoutParams) to set the screen content from a layout resource. The resource will be inflated, adding all top-level views to the screen.</para> <para> <para>setContentView(View, android.view.ViewGroup.LayoutParams) </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(I)V", AccessFlags = 1025)]
				public abstract void SetContentView(int layoutResID) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Convenience for setContentView(View, android.view.ViewGroup.LayoutParams) to set the screen content from a layout resource. The resource will be inflated, adding all top-level views to the screen.</para> <para> <para>setContentView(View, android.view.ViewGroup.LayoutParams) </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1025)]
				public abstract void SetContentView(global::Android.Views.View layoutResID) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the screen content to an explicit view. This view is placed directly into the screen's view hierarchy. It can itself be a complex view hierarchy.</para> <para>Note that calling this function "locks in" various characteristics of the window that can not, from this point forward, be changed: the features that have been requested with requestFeature(int), and certain window flags as described in setFlags(int, int).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1025)]
				public abstract void SetContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Variation on setContentView(View, android.view.ViewGroup.LayoutParams) to add an additional content view to the screen. Added after any existing ones in the screen  existing views are NOT removed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// addContentView
				/// </java-name>
				[Dot42.DexImport("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1025)]
				public abstract void AddContentView(global::Android.Views.View view, global::Android.Views.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTitle
				/// </java-name>
				[Dot42.DexImport("setTitle", "(Ljava/lang/CharSequence;)V", AccessFlags = 1025)]
				public abstract void SetTitle(global::Java.Lang.ICharSequence title) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setTitleColor
				/// </java-name>
				[Dot42.DexImport("setTitleColor", "(I)V", AccessFlags = 1025)]
				public abstract void SetTitleColor(int textColor) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// openPanel
				/// </java-name>
				[Dot42.DexImport("openPanel", "(ILandroid/view/KeyEvent;)V", AccessFlags = 1025)]
				public abstract void OpenPanel(int featureId, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closePanel
				/// </java-name>
				[Dot42.DexImport("closePanel", "(I)V", AccessFlags = 1025)]
				public abstract void ClosePanel(int featureId) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// togglePanel
				/// </java-name>
				[Dot42.DexImport("togglePanel", "(ILandroid/view/KeyEvent;)V", AccessFlags = 1025)]
				public abstract void TogglePanel(int featureId, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performPanelShortcut
				/// </java-name>
				[Dot42.DexImport("performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z", AccessFlags = 1025)]
				public abstract bool PerformPanelShortcut(int featureId, int keyCode, global::Android.Views.KeyEvent @event, int flags) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performPanelIdentifierAction
				/// </java-name>
				[Dot42.DexImport("performPanelIdentifierAction", "(III)Z", AccessFlags = 1025)]
				public abstract bool PerformPanelIdentifierAction(int featureId, int id, int flags) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// closeAllPanels
				/// </java-name>
				[Dot42.DexImport("closeAllPanels", "()V", AccessFlags = 1025)]
				public abstract void CloseAllPanels() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// performContextMenuIdentifierAction
				/// </java-name>
				[Dot42.DexImport("performContextMenuIdentifierAction", "(II)Z", AccessFlags = 1025)]
				public abstract bool PerformContextMenuIdentifierAction(int id, int flags) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Should be called when the configuration is changed.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onConfigurationChanged
				/// </java-name>
				[Dot42.DexImport("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", AccessFlags = 1025)]
				public abstract void OnConfigurationChanged(global::Android.Content.Res.Configuration newConfig) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Change the background of this window to a Drawable resource. Setting the background to null will make the window be opaque. To make the window transparent, you can use an empty drawable (for instance a ColorDrawable with the color 0 or the system drawable android:drawable/empty.)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundDrawableResource
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawableResource", "(I)V", AccessFlags = 1)]
				public virtual void SetBackgroundDrawableResource(int resid) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Change the background of this window to a custom Drawable. Setting the background to null will make the window be opaque. To make the window transparent, you can use an empty drawable (for instance a ColorDrawable with the color 0 or the system drawable android:drawable/empty.)</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setBackgroundDrawable
				/// </java-name>
				[Dot42.DexImport("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetBackgroundDrawable(global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the value for a drawable feature of this window, from a resource identifier. You must have called requestFeauture(featureId) before calling this function.</para> <para> <para>android.content.res.Resources::getDrawable(int)</para></para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableResource
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableResource", "(II)V", AccessFlags = 1025)]
				public abstract void SetFeatureDrawableResource(int featureId, int resId) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the value for a drawable feature of this window, from a URI. You must have called requestFeature(featureId) before calling this function.</para> <para>The only URI currently supported is "content:", specifying an image in a content provider.</para> <para> <para>android.widget.ImageView::setImageURI</para></para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableUri
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableUri", "(ILandroid/net/Uri;)V", AccessFlags = 1025)]
				public abstract void SetFeatureDrawableUri(int featureId, global::Android.Net.Uri uri) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set an explicit Drawable value for feature of this window. You must have called requestFeature(featureId) before calling this function.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawable
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetFeatureDrawable(int featureId, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set a custom alpha value for the given drawale feature, controlling how much the background is visible through it.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFeatureDrawableAlpha
				/// </java-name>
				[Dot42.DexImport("setFeatureDrawableAlpha", "(II)V", AccessFlags = 1025)]
				public abstract void SetFeatureDrawableAlpha(int featureId, int alpha) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the integer value for a feature. The range of the value depends on the feature being set. For FEATURE_PROGRESSS, it should go from 0 to 10000. At 10000 the progress is complete and the indicator hidden.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// setFeatureInt
				/// </java-name>
				[Dot42.DexImport("setFeatureInt", "(II)V", AccessFlags = 1025)]
				public abstract void SetFeatureInt(int featureId, int value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Request that key events come to this activity. Use this if your activity has no views with focus, but the activity still wants a chance to process key events. </para>        
				/// </summary>
				/// <java-name>
				/// takeKeyEvents
				/// </java-name>
				[Dot42.DexImport("takeKeyEvents", "(Z)V", AccessFlags = 1025)]
				public abstract void TakeKeyEvents(bool get) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Used by custom windows, such as Dialog, to pass the key press event further down the view hierarchy. Application developers should not need to implement or call this. </para>        
				/// </summary>
				/// <java-name>
				/// superDispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public abstract bool SuperDispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Used by custom windows, such as Dialog, to pass the touch screen event further down the view hierarchy. Application developers should not need to implement or call this. </para>        
				/// </summary>
				/// <java-name>
				/// superDispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public abstract bool SuperDispatchTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Used by custom windows, such as Dialog, to pass the trackball event further down the view hierarchy. Application developers should not need to implement or call this. </para>        
				/// </summary>
				/// <java-name>
				/// superDispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
				public abstract bool SuperDispatchTrackballEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Retrieve the current decor view, but only if it has already been created; otherwise returns null.</para> <para> <para>getDecorView </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the top-level window decor or null. </para>
				/// </returns>
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
				public abstract void RestoreHierarchyState(global::Android.OS.Bundle savedInstanceState) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// onActive
				/// </java-name>
				[Dot42.DexImport("onActive", "()V", AccessFlags = 1028)]
				protected internal abstract void OnActive() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Set the default format of window, as per the PixelFormat types. This is the format that will be used unless the client specifies in explicit format with setFormat();</para> <para> <para>setFormat </para> <para>PixelFormat </para></para>        
				/// </summary>
				/// <java-name>
				/// setDefaultWindowFormat
				/// </java-name>
				[Dot42.DexImport("setDefaultWindowFormat", "(I)V", AccessFlags = 4)]
				protected internal virtual void SetDefaultWindowFormat(int format) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChildDrawable
				/// </java-name>
				[Dot42.DexImport("setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V", AccessFlags = 1025)]
				public abstract void SetChildDrawable(int featureId, global::Android.Graphics.Drawables.Drawable drawable) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// setChildInt
				/// </java-name>
				[Dot42.DexImport("setChildInt", "(II)V", AccessFlags = 1025)]
				public abstract void SetChildInt(int featureId, int value) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Is a keypress one of the defined shortcut keys for this window. </para>        
				/// </summary>
				/// <java-name>
				/// isShortcutKey
				/// </java-name>
				[Dot42.DexImport("isShortcutKey", "(ILandroid/view/KeyEvent;)Z", AccessFlags = 1025)]
				public abstract bool IsShortcutKey(int keyCode, global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Window() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <summary>
				///  <para>Return the Context this window policy is running in, for retrieving resources and other information.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Context The Context that was supplied to the constructor. </para>
				/// </returns>
				/// <java-name>
				/// getContext
				/// </java-name>
				public global::Android.Content.Context Context
				{
						[Dot42.DexImport("getContext", "()Landroid/content/Context;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Context); }
				}

				/// <summary>
				///  <para>Return the android.R.styleable#Window attributes from this window's theme. </para>        
				/// </summary>
				/// <java-name>
				/// getWindowStyle
				/// </java-name>
				public global::Android.Content.Res.TypedArray WindowStyle
				{
						[Dot42.DexImport("getWindowStyle", "()Landroid/content/res/TypedArray;", AccessFlags = 17)]
						get{ return default(global::Android.Content.Res.TypedArray); }
				}

				/// <summary>
				///  <para>Return the container for this Window.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Window The containing window, or null if this is a top-level window. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Return the window manager allowing this Window to display its own windows.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>WindowManager The ViewManager. </para>
				/// </returns>
				/// <java-name>
				/// getWindowManager
				/// </java-name>
				public virtual global::Android.Views.IWindowManager WindowManager
				{
						[Dot42.DexImport("getWindowManager", "()Landroid/view/WindowManager;", AccessFlags = 1)]
						get{ return default(global::Android.Views.IWindowManager); }
				}

				/// <summary>
				///  <para>Return the current Callback interface for this window. </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Return whether this window is being displayed with a floating style (based on the android.R.attr#windowIsFloating attribute in the style/theme).</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns true if the window is configured to be displayed floating on top of whatever is behind it. </para>
				/// </returns>
				/// <java-name>
				/// isFloating
				/// </java-name>
				public abstract bool IsFloating
				{
						[Dot42.DexImport("isFloating", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Retrieve the current window attributes associated with this panel.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>WindowManager.LayoutParams Either the existing window attributes object, or a freshly created one if there is none. </para>
				/// </returns>
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

				/// <summary>
				///  <para>Return the window flags that have been explicitly set by the client, so will not be modified by getDecorView. </para>        
				/// </summary>
				/// <java-name>
				/// getForcedWindowFlags
				/// </java-name>
				protected internal int ForcedWindowFlags
				{
						[Dot42.DexImport("getForcedWindowFlags", "()I", AccessFlags = 20)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Has the app specified their own soft input mode? </para>        
				/// </summary>
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

				/// <summary>
				///  <para>Return the view in this Window that currently has focus, or null if there are none. Note that this does not look in any containing Window.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>View The current View with focus or null. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentFocus
				/// </java-name>
				public abstract global::Android.Views.View CurrentFocus
				{
						[Dot42.DexImport("getCurrentFocus", "()Landroid/view/View;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Quick access to the LayoutInflater instance that this Window retrieved from its Context.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>LayoutInflater The shared LayoutInflater. </para>
				/// </returns>
				/// <java-name>
				/// getLayoutInflater
				/// </java-name>
				public abstract global::Android.Views.LayoutInflater LayoutInflater
				{
						[Dot42.DexImport("getLayoutInflater", "()Landroid/view/LayoutInflater;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Retrieve the top-level window decor view (containing the standard window frame/decorations and the client's content inside of that), which can be added as a window to the window manager.</para> <para> <b>Note that calling this function for the first time "locks in" various window characteristics as described in setContentView(View, android.view.ViewGroup.LayoutParams).</b></para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>Returns the top-level window decor view. </para>
				/// </returns>
				/// <java-name>
				/// getDecorView
				/// </java-name>
				public abstract global::Android.Views.View DecorView
				{
						[Dot42.DexImport("getDecorView", "()Landroid/view/View;", AccessFlags = 1025)]
						get;
				}

				/// <summary>
				///  <para>Return the feature bits that are enabled. This is the set of features that were given to requestFeature(), and are being handled by this Window itself or its container. That is, it is the set of requested features that you can actually use.</para> <para>To do: add a public version of this API that allows you to check for features by their feature ID.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int The feature bits. </para>
				/// </returns>
				/// <java-name>
				/// getFeatures
				/// </java-name>
				protected internal int Features
				{
						[Dot42.DexImport("getFeatures", "()I", AccessFlags = 20)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para>Return the feature bits that are being implemented by this Window. This is the set of features that were given to requestFeature(), and are being handled by only this Window itself, not by its containers.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>int The feature bits. </para>
				/// </returns>
				/// <java-name>
				/// getLocalFeatures
				/// </java-name>
				protected internal int LocalFeatures
				{
						[Dot42.DexImport("getLocalFeatures", "()I", AccessFlags = 20)]
						get{ return default(int); }
				}

				/// <summary>
				///  <para> <para>android.app.Activity::getVolumeControlStream() </para></para>        
				/// </summary>
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

				/// <summary>
				///  <para>API from a Window back to its caller. This allows the client to intercept key dispatching, panels and menus, etc. </para>    
				/// </summary>
				/// <java-name>
				/// android/view/Window$Callback
				/// </java-name>
				[Dot42.DexImport("android/view/Window$Callback", AccessFlags = 1545)]
				public partial interface ICallback
 /* scope: __dot42__ */ 
				{
						/// <summary>
						///  <para>Called to process key events. At the very least your implementation must call android.view.Window#superDispatchKeyEvent to do the standard key processing.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>boolean Return true if this event was consumed. </para>
						/// </returns>
						/// <java-name>
						/// dispatchKeyEvent
						/// </java-name>
						[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1025)]
						bool DispatchKeyEvent(global::Android.Views.KeyEvent @event) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called to process touch screen events. At the very least your implementation must call android.view.Window#superDispatchTouchEvent to do the standard touch screen processing.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>boolean Return true if this event was consumed. </para>
						/// </returns>
						/// <java-name>
						/// dispatchTouchEvent
						/// </java-name>
						[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool DispatchTouchEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called to process trackball events. At the very least your implementation must call android.view.Window#superDispatchTrackballEvent to do the standard trackball processing.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>boolean Return true if this event was consumed. </para>
						/// </returns>
						/// <java-name>
						/// dispatchTrackballEvent
						/// </java-name>
						[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1025)]
						bool DispatchTrackballEvent(global::Android.Views.MotionEvent @event) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called to process population of AccessibilityEvents.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>boolean Return true if event population was completed. </para>
						/// </returns>
						/// <java-name>
						/// dispatchPopulateAccessibilityEvent
						/// </java-name>
						[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1025)]
						bool DispatchPopulateAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Instantiate the view to display in the panel for 'featureId'. You can return null, in which case the default content (typically a menu) will be created for you.</para> <para> <para>onPreparePanel </para></para>        
						/// </summary>
						/// <returns>
						///  <para>view The top-level view to place in the panel.</para>
						/// </returns>
						/// <java-name>
						/// onCreatePanelView
						/// </java-name>
						[Dot42.DexImport("onCreatePanelView", "(I)Landroid/view/View;", AccessFlags = 1025)]
						global::Android.Views.View OnCreatePanelView(int featureId) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Initialize the contents of the menu for panel 'featureId'. This is called if onCreatePanelView() returns null, giving you a standard menu in which you can place your items. It is only called once for the panel, the first time it is shown.</para> <para>You can safely hold on to  <b>menu</b> (and any items created from it), making modifications to it as desired, until the next time onCreatePanelMenu() is called for this feature.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>boolean You must return true for the panel to be displayed; if you return false it will not be shown. </para>
						/// </returns>
						/// <java-name>
						/// onCreatePanelMenu
						/// </java-name>
						[Dot42.DexImport("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", AccessFlags = 1025)]
						bool OnCreatePanelMenu(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Prepare a panel to be displayed. This is called right before the panel window is shown, every time it is shown.</para> <para> <para>onCreatePanelView </para></para>        
						/// </summary>
						/// <returns>
						///  <para>boolean You must return true for the panel to be displayed; if you return false it will not be shown.</para>
						/// </returns>
						/// <java-name>
						/// onPreparePanel
						/// </java-name>
						[Dot42.DexImport("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", AccessFlags = 1025)]
						bool OnPreparePanel(int featureId, global::Android.Views.View view, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a panel's menu is opened by the user. This may also be called when the menu is changing from one type to another (for example, from the icon menu to the expanded menu).</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>Return true to allow the menu to open, or false to prevent the menu from opening. </para>
						/// </returns>
						/// <java-name>
						/// onMenuOpened
						/// </java-name>
						[Dot42.DexImport("onMenuOpened", "(ILandroid/view/Menu;)Z", AccessFlags = 1025)]
						bool OnMenuOpened(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a panel's menu item has been selected by the user.</para> <para></para>        
						/// </summary>
						/// <returns>
						///  <para>boolean Return true to finish processing of selection, or false to perform the normal menu handling (calling its Runnable or sending a Message to its target Handler). </para>
						/// </returns>
						/// <java-name>
						/// onMenuItemSelected
						/// </java-name>
						[Dot42.DexImport("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", AccessFlags = 1025)]
						bool OnMenuItemSelected(int featureId, global::Android.Views.IMenuItem item) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>This is called whenever the current window attributes change. </para>        
						/// </summary>
						/// <java-name>
						/// onWindowAttributesChanged
						/// </java-name>
						[Dot42.DexImport("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", AccessFlags = 1025)]
						void OnWindowAttributesChanged(global::Android.Views.IWindowManager_LayoutParams attrs) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>This hook is called whenever the content view of the screen changes (due to a call to Window.setContentView or Window.addContentView). </para>        
						/// </summary>
						/// <java-name>
						/// onContentChanged
						/// </java-name>
						[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1025)]
						void OnContentChanged() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>This hook is called whenever the window focus changes. See View.onWindowFocusChanged(boolean) for more information.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onWindowFocusChanged
						/// </java-name>
						[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1025)]
						void OnWindowFocusChanged(bool hasFocus) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when the window has been attached to the window manager. See View.onAttachedToWindow() for more information. </para>        
						/// </summary>
						/// <java-name>
						/// onAttachedToWindow
						/// </java-name>
						[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 1025)]
						void OnAttachedToWindow() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when the window has been attached to the window manager. See View.onDetachedFromWindow() for more information. </para>        
						/// </summary>
						/// <java-name>
						/// onDetachedFromWindow
						/// </java-name>
						[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1025)]
						void OnDetachedFromWindow() /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when a panel is being closed. If another logical subsequent panel is being opened (and this panel is being closed to make room for the subsequent panel), this method will NOT be called.</para> <para></para>        
						/// </summary>
						/// <java-name>
						/// onPanelClosed
						/// </java-name>
						[Dot42.DexImport("onPanelClosed", "(ILandroid/view/Menu;)V", AccessFlags = 1025)]
						void OnPanelClosed(int featureId, global::Android.Views.IMenu menu) /* MethodBuilder.Create */ ;

						/// <summary>
						///  <para>Called when the user signals the desire to start a search.</para> <para> <para>android.app.Activity::onSearchRequested() </para></para>        
						/// </summary>
						/// <returns>
						///  <para>true if search launched, false if activity refuses (blocks)</para>
						/// </returns>
						/// <java-name>
						/// onSearchRequested
						/// </java-name>
						[Dot42.DexImport("onSearchRequested", "()Z", AccessFlags = 1025)]
						bool OnSearchRequested() /* MethodBuilder.Create */ ;

				}

		}

}

