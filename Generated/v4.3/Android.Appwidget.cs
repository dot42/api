#pragma warning disable 1717
namespace Android.Appwidget
{
		/// <summary>
		///  <para>AppWidgetHost provides the interaction with the AppWidget service for apps, like the home screen, that want to embed AppWidgets in their UI. </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetHost
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetHost", AccessFlags = 33)]
		public partial class AppWidgetHost
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public AppWidgetHost(global::Android.Content.Context context, int hostId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Start receiving onAppWidgetChanged calls for your AppWidgets. Call this when your activity becomes visible, i.e. from onStart() in your Activity. </para>        
				/// </summary>
				/// <java-name>
				/// startListening
				/// </java-name>
				[Dot42.DexImport("startListening", "()V", AccessFlags = 1)]
				public virtual void StartListening() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Stop receiving onAppWidgetChanged calls for your AppWidgets. Call this when your activity is no longer visible, i.e. from onStop() in your Activity. </para>        
				/// </summary>
				/// <java-name>
				/// stopListening
				/// </java-name>
				[Dot42.DexImport("stopListening", "()V", AccessFlags = 1)]
				public virtual void StopListening() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get a appWidgetId for a host in the calling process.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>a appWidgetId </para>
				/// </returns>
				/// <java-name>
				/// allocateAppWidgetId
				/// </java-name>
				[Dot42.DexImport("allocateAppWidgetId", "()I", AccessFlags = 1)]
				public virtual int AllocateAppWidgetId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				///  <para>Stop listening to changes for this AppWidget. </para>        
				/// </summary>
				/// <java-name>
				/// deleteAppWidgetId
				/// </java-name>
				[Dot42.DexImport("deleteAppWidgetId", "(I)V", AccessFlags = 1)]
				public virtual void DeleteAppWidgetId(int appWidgetId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove all records about this host from the AppWidget manager.  <ul> <li> <para>Call this when initializing your database, as it might be because of a data wipe. </para></li> <li> <para>Call this to have the AppWidget manager release all resources associated with your host. Any future calls about this host will cause the records to be re-allocated. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// deleteHost
				/// </java-name>
				[Dot42.DexImport("deleteHost", "()V", AccessFlags = 1)]
				public virtual void DeleteHost() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Remove all records about all hosts for your package.  <ul> <li> <para>Call this when initializing your database, as it might be because of a data wipe. </para></li> <li> <para>Call this to have the AppWidget manager release all resources associated with your host. Any future calls about this host will cause the records to be re-allocated. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// deleteAllHosts
				/// </java-name>
				[Dot42.DexImport("deleteAllHosts", "()V", AccessFlags = 9)]
				public static void DeleteAllHosts() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create the AppWidgetHostView for the given widget. The AppWidgetHost retains a pointer to the newly-created View. </para>        
				/// </summary>
				/// <java-name>
				/// createView
				/// </java-name>
				[Dot42.DexImport("createView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/app" +
    "widget/AppWidgetHostView;", AccessFlags = 17)]
				public global::Android.Appwidget.AppWidgetHostView CreateView(global::Android.Content.Context context, int appWidgetId, global::Android.Appwidget.AppWidgetProviderInfo appWidget) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetHostView);
				}

				/// <summary>
				///  <para>Called to create the AppWidgetHostView. Override to return a custom subclass if you need it. {} </para>        
				/// </summary>
				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/app" +
    "widget/AppWidgetHostView;", AccessFlags = 4)]
				protected internal virtual global::Android.Appwidget.AppWidgetHostView OnCreateView(global::Android.Content.Context context, int appWidgetId, global::Android.Appwidget.AppWidgetProviderInfo appWidget) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetHostView);
				}

				/// <summary>
				///  <para>Called when the AppWidget provider for a AppWidget has been upgraded to a new apk. </para>        
				/// </summary>
				/// <java-name>
				/// onProviderChanged
				/// </java-name>
				[Dot42.DexImport("onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", AccessFlags = 4)]
				protected internal virtual void OnProviderChanged(int appWidgetId, global::Android.Appwidget.AppWidgetProviderInfo appWidget) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called when the set of available widgets changes (ie. widget containing packages are added, updated or removed, or widget components are enabled or disabled.) </para>        
				/// </summary>
				/// <java-name>
				/// onProvidersChanged
				/// </java-name>
				[Dot42.DexImport("onProvidersChanged", "()V", AccessFlags = 4)]
				protected internal virtual void OnProvidersChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Clear the list of Views that have been created by this AppWidgetHost. </para>        
				/// </summary>
				/// <java-name>
				/// clearViews
				/// </java-name>
				[Dot42.DexImport("clearViews", "()V", AccessFlags = 4)]
				protected internal virtual void ClearViews() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AppWidgetHost() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		///  <para>Provides the glue to show AppWidget views. This class offers automatic animation between updates, and will try recycling old views for each incoming RemoteViews. </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetHostView
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetHostView", AccessFlags = 33)]
		public partial class AppWidgetHostView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Create a host view. Uses default fade animations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AppWidgetHostView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Create a host view. Uses specified animations when pushing updateAppWidget(RemoteViews).</para> <para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public AppWidgetHostView(global::Android.Content.Context context, int animationIn, int animationOut) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the AppWidget that will be displayed by this view. This method also adds default padding to widgets, as described in getDefaultPaddingForWidget(Context, ComponentName, Rect) and can be overridden in order to add custom padding. </para>        
				/// </summary>
				/// <java-name>
				/// setAppWidget
				/// </java-name>
				[Dot42.DexImport("setAppWidget", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", AccessFlags = 1)]
				public virtual void SetAppWidget(int appWidgetId, global::Android.Appwidget.AppWidgetProviderInfo info) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>As of ICE_CREAM_SANDWICH we are automatically adding padding to widgets targeting ICE_CREAM_SANDWICH and higher. The new widget design guidelines strongly recommend that widget developers do not add extra padding to their widgets. This will help achieve consistency among widgets.</para> <para>Note: this method is only needed by developers of AppWidgetHosts. The method is provided in order for the AppWidgetHost to account for the automatic padding when computing the number of cells to allocate to a particular widget.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>default padding for this widget, in pixels </para>
				/// </returns>
				/// <java-name>
				/// getDefaultPaddingForWidget
				/// </java-name>
				[Dot42.DexImport("getDefaultPaddingForWidget", "(Landroid/content/Context;Landroid/content/ComponentName;Landroid/graphics/Rect;)" +
    "Landroid/graphics/Rect;", AccessFlags = 9)]
				public static global::Android.Graphics.Rect GetDefaultPaddingForWidget(global::Android.Content.Context context, global::Android.Content.ComponentName component, global::Android.Graphics.Rect padding) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
				}

				/// <java-name>
				/// dispatchSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchSaveInstanceState(global::Android.Util.SparseArray<global::Android.OS.IParcelable> container) /* MethodBuilder.Create */ 
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
				///  <para>Provide guidance about the size of this widget to the AppWidgetManager. The widths and heights should correspond to the full area the AppWidgetHostView is given. Padding added by the framework will be accounted for automatically. This information gets embedded into the AppWidget options and causes a callback to the AppWidgetProvider.  <para>AppWidgetProvider::onAppWidgetOptionsChanged(Context, AppWidgetManager, int, Bundle)</para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidgetSize
				/// </java-name>
				[Dot42.DexImport("updateAppWidgetSize", "(Landroid/os/Bundle;IIII)V", AccessFlags = 1)]
				public virtual void UpdateAppWidgetSize(global::Android.OS.Bundle newOptions, int minWidth, int minHeight, int maxWidth, int maxHeight) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Specify some extra information for the widget provider. Causes a callback to the AppWidgetProvider.  <para>AppWidgetProvider::onAppWidgetOptionsChanged(Context, AppWidgetManager, int, Bundle)</para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidgetOptions
				/// </java-name>
				[Dot42.DexImport("updateAppWidgetOptions", "(Landroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidgetOptions(global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", AccessFlags = 1)]
				public override global::Android.Widget.FrameLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.FrameLayout.LayoutParams);
				}

				/// <summary>
				///  <para>Process a set of RemoteViews coming in as an update from the AppWidget provider. Will animate into these new views as needed </para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "(Landroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// drawChild
				/// </java-name>
				[Dot42.DexImport("drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", AccessFlags = 4)]
				protected internal override bool DrawChild(global::Android.Graphics.Canvas canvas, global::Android.Views.View child, long drawingTime) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Prepare the given view to be shown. This might include adjusting FrameLayout.LayoutParams before inserting. </para>        
				/// </summary>
				/// <java-name>
				/// prepareView
				/// </java-name>
				[Dot42.DexImport("prepareView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void PrepareView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onInitializeAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("onInitializeAccessibilityNodeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo;)V", AccessFlags = 1)]
				public override void OnInitializeAccessibilityNodeInfo(global::Android.Views.Accessibility.AccessibilityNodeInfo info) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				protected internal AppWidgetHostView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAppWidgetId
				/// </java-name>
				public virtual int AppWidgetId
				{
						[Dot42.DexImport("getAppWidgetId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getAppWidgetInfo
				/// </java-name>
				public virtual global::Android.Appwidget.AppWidgetProviderInfo AppWidgetInfo
				{
						[Dot42.DexImport("getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Appwidget.AppWidgetProviderInfo); }
				}

				/// <summary>
				///  <para>Inflate and return the default layout requested by AppWidget provider. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultView
				/// </java-name>
				protected internal virtual global::Android.Views.View DefaultView
				{
						[Dot42.DexImport("getDefaultView", "()Landroid/view/View;", AccessFlags = 4)]
						get{ return default(global::Android.Views.View); }
				}

				/// <summary>
				///  <para>Inflate and return a view that represents an error state. </para>        
				/// </summary>
				/// <java-name>
				/// getErrorView
				/// </java-name>
				protected internal virtual global::Android.Views.View ErrorView
				{
						[Dot42.DexImport("getErrorView", "()Landroid/view/View;", AccessFlags = 4)]
						get{ return default(global::Android.Views.View); }
				}

		}

		/// <summary>
		///  <para>Updates AppWidget state; gets information about installed AppWidget providers and other AppWidget related state.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating app widgets, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetManager
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetManager", AccessFlags = 33)]
		public partial class AppWidgetManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Activity action to launch from your AppWidgetHost activity when you want to pick an AppWidget to display. The AppWidget picker activity will be launched. </para> <para>You must supply the following extras:  <table> <row> <entry> <para>EXTRA_APPWIDGET_ID </para></entry> <entry> <para>A newly allocated appWidgetId, which will be bound to the AppWidget provider once the user has selected one.  </para></entry></row></table></para> <para>The system will respond with an onActivityResult call with the following extras in the intent:  <table> <row> <entry> <para>EXTRA_APPWIDGET_ID </para></entry> <entry> <para>The appWidgetId that you supplied in the original intent.  </para></entry></row></table></para> <para>When you receive the result from the AppWidget pick activity, if the resultCode is android.app.Activity#RESULT_OK, an AppWidget has been selected. You should then check the AppWidgetProviderInfo for the returned AppWidget, and if it has one, launch its configuration activity. If android.app.Activity#RESULT_CANCELED is returned, you should delete the appWidgetId.</para> <para> <para>ACTION_APPWIDGET_CONFIGURE </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_PICK
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_PICK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_PICK = "android.appwidget.action.APPWIDGET_PICK";
				/// <summary>
				///  <para>Activity action to launch from your AppWidgetHost activity when you want to bind an AppWidget to display and bindAppWidgetIdIfAllowed returns false. </para> <para>You must supply the following extras:  <table> <row> <entry> <para>EXTRA_APPWIDGET_ID </para></entry> <entry> <para>A newly allocated appWidgetId, which will be bound to the AppWidget provider you provide.  </para></entry></row> <row> <entry> <para>EXTRA_APPWIDGET_PROVIDER </para></entry> <entry> <para>The BroadcastReceiver that will be the AppWidget provider for this AppWidget.   </para></entry></row></table></para> <para>The system will respond with an onActivityResult call with the following extras in the intent:  <table> <row> <entry> <para>EXTRA_APPWIDGET_ID </para></entry> <entry> <para>The appWidgetId that you supplied in the original intent.  </para></entry></row></table></para> <para>When you receive the result from the AppWidget bind activity, if the resultCode is android.app.Activity#RESULT_OK, the AppWidget has been bound. You should then check the AppWidgetProviderInfo for the returned AppWidget, and if it has one, launch its configuration activity. If android.app.Activity#RESULT_CANCELED is returned, you should delete the appWidgetId.</para> <para> <para>ACTION_APPWIDGET_CONFIGURE </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_BIND
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_BIND", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_BIND = "android.appwidget.action.APPWIDGET_BIND";
				/// <summary>
				///  <para>Sent when it is time to configure your AppWidget while it is being added to a host. This action is not sent as a broadcast to the AppWidget provider, but as a startActivity to the activity specified in the AppWidgetProviderInfo meta-data.</para> <para>The intent will contain the following extras:  <table> <row> <entry> <para>EXTRA_APPWIDGET_ID </para></entry> <entry> <para>The appWidgetId to configure.  </para></entry></row></table></para> <para>If you return android.app.Activity#RESULT_OK using Activity.setResult(), the AppWidget will be added, and you will receive an ACTION_APPWIDGET_UPDATE broadcast for this AppWidget. If you return android.app.Activity#RESULT_CANCELED, the host will cancel the add and not display this AppWidget, and you will receive a ACTION_APPWIDGET_DELETED broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_CONFIGURE
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_CONFIGURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_CONFIGURE = "android.appwidget.action.APPWIDGET_CONFIGURE";
				/// <summary>
				///  <para>An intent extra that contains one appWidgetId. </para> <para>The value will be an int that can be retrieved like this: { frameworks/base/tests/appwidgets/AppWidgetHostTest/src/com/android/tests/appwidgethost/AppWidgetHostActivity.java getExtra_EXTRA_APPWIDGET_ID} </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_APPWIDGET_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPWIDGET_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPWIDGET_ID = "appWidgetId";
				/// <summary>
				///  <para>A bundle extra that contains the lower bound on the current width, in dips, of a widget instance. </para>        
				/// </summary>
				/// <java-name>
				/// OPTION_APPWIDGET_MIN_WIDTH
				/// </java-name>
				[Dot42.DexImport("OPTION_APPWIDGET_MIN_WIDTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string OPTION_APPWIDGET_MIN_WIDTH = "appWidgetMinWidth";
				/// <summary>
				///  <para>A bundle extra that contains the lower bound on the current height, in dips, of a widget instance. </para>        
				/// </summary>
				/// <java-name>
				/// OPTION_APPWIDGET_MIN_HEIGHT
				/// </java-name>
				[Dot42.DexImport("OPTION_APPWIDGET_MIN_HEIGHT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string OPTION_APPWIDGET_MIN_HEIGHT = "appWidgetMinHeight";
				/// <summary>
				///  <para>A bundle extra that contains the upper bound on the current width, in dips, of a widget instance. </para>        
				/// </summary>
				/// <java-name>
				/// OPTION_APPWIDGET_MAX_WIDTH
				/// </java-name>
				[Dot42.DexImport("OPTION_APPWIDGET_MAX_WIDTH", "Ljava/lang/String;", AccessFlags = 25)]
				public const string OPTION_APPWIDGET_MAX_WIDTH = "appWidgetMaxWidth";
				/// <summary>
				///  <para>A bundle extra that contains the upper bound on the current width, in dips, of a widget instance. </para>        
				/// </summary>
				/// <java-name>
				/// OPTION_APPWIDGET_MAX_HEIGHT
				/// </java-name>
				[Dot42.DexImport("OPTION_APPWIDGET_MAX_HEIGHT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string OPTION_APPWIDGET_MAX_HEIGHT = "appWidgetMaxHeight";
				/// <summary>
				///  <para>A bundle extra that hints to the AppWidgetProvider the category of host that owns this this widget. Can have the value AppWidgetProviderInfo#WIDGET_CATEGORY_HOME_SCREEN or AppWidgetProviderInfo#WIDGET_CATEGORY_KEYGUARD. </para>        
				/// </summary>
				/// <java-name>
				/// OPTION_APPWIDGET_HOST_CATEGORY
				/// </java-name>
				[Dot42.DexImport("OPTION_APPWIDGET_HOST_CATEGORY", "Ljava/lang/String;", AccessFlags = 25)]
				public const string OPTION_APPWIDGET_HOST_CATEGORY = "appWidgetCategory";
				/// <summary>
				///  <para>An intent extra which points to a bundle of extra information for a particular widget id. In particular this bundle can contain EXTRA_APPWIDGET_WIDTH and EXTRA_APPWIDGET_HEIGHT. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_APPWIDGET_OPTIONS
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPWIDGET_OPTIONS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPWIDGET_OPTIONS = "appWidgetOptions";
				/// <summary>
				///  <para>An intent extra that contains multiple appWidgetIds. </para> <para>The value will be an int array that can be retrieved like this: { frameworks/base/tests/appwidgets/AppWidgetHostTest/src/com/android/tests/appwidgethost/TestAppWidgetProvider.java getExtra_EXTRA_APPWIDGET_IDS} </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_APPWIDGET_IDS
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPWIDGET_IDS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPWIDGET_IDS = "appWidgetIds";
				/// <summary>
				///  <para>An intent extra that contains the component name of a AppWidget provider. </para> <para>The value will be an ComponentName. </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_APPWIDGET_PROVIDER
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPWIDGET_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPWIDGET_PROVIDER = "appWidgetProvider";
				/// <summary>
				///  <para>An intent extra to pass to the AppWidget picker containing a java.util.List of AppWidgetProviderInfo objects to mix in to the list of AppWidgets that are installed. (This is how the launcher shows the search widget). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CUSTOM_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_CUSTOM_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CUSTOM_INFO = "customInfo";
				/// <summary>
				///  <para>An intent extra to pass to the AppWidget picker containing a java.util.List of android.os.Bundle objects to mix in to the list of AppWidgets that are installed. It will be added to the extras object on the android.content.Intent that is returned from the picker activity.</para> <para>{} </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CUSTOM_EXTRAS
				/// </java-name>
				[Dot42.DexImport("EXTRA_CUSTOM_EXTRAS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CUSTOM_EXTRAS = "customExtras";
				/// <summary>
				///  <para>A sentinel value that the AppWidget manager will never return as a appWidgetId. </para>        
				/// </summary>
				/// <java-name>
				/// INVALID_APPWIDGET_ID
				/// </java-name>
				[Dot42.DexImport("INVALID_APPWIDGET_ID", "I", AccessFlags = 25)]
				public const int INVALID_APPWIDGET_ID = 0;
				/// <summary>
				///  <para>Sent when it is time to update your AppWidget.</para> <para>This may be sent in response to a new instance for this AppWidget provider having been instantiated, the requested update interval having lapsed, or the system booting.</para> <para>The intent will contain the following extras:  <table> <row> <entry> <para>EXTRA_APPWIDGET_IDS </para></entry> <entry> <para>The appWidgetIds to update. This may be all of the AppWidgets created for this provider, or just a subset. The system tries to send updates for as few AppWidget instances as possible.  </para></entry></row></table></para> <para> <para>AppWidgetProvider::onUpdate AppWidgetProvider.onUpdate(Context context, AppWidgetManager appWidgetManager, int[] appWidgetIds) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_UPDATE
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_UPDATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_UPDATE = "android.appwidget.action.APPWIDGET_UPDATE";
				/// <summary>
				///  <para>Sent when the custom extras for an AppWidget change.</para> <para>This is a protected intent that can only be sent by the system.</para> <para> <para>AppWidgetProvider::onAppWidgetOptionsChanged AppWidgetProvider.onAppWidgetOptionsChanged(Context context, AppWidgetManager appWidgetManager, int appWidgetId, Bundle newExtras) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_OPTIONS_CHANGED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_OPTIONS_CHANGED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_OPTIONS_CHANGED = "android.appwidget.action.APPWIDGET_UPDATE_OPTIONS";
				/// <summary>
				///  <para>Sent when an instance of an AppWidget is deleted from its host.</para> <para>This is a protected intent that can only be sent by the system.</para> <para> <para>AppWidgetProvider::onDeleted AppWidgetProvider.onDeleted(Context context, int[] appWidgetIds) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_DELETED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_DELETED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_DELETED = "android.appwidget.action.APPWIDGET_DELETED";
				/// <summary>
				///  <para>Sent when an instance of an AppWidget is removed from the last host.</para> <para>This is a protected intent that can only be sent by the system.</para> <para> <para>AppWidgetProvider::onEnabled AppWidgetProvider.onEnabled(Context context) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_DISABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_DISABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_DISABLED = "android.appwidget.action.APPWIDGET_DISABLED";
				/// <summary>
				///  <para>Sent when an instance of an AppWidget is added to a host for the first time. This broadcast is sent at boot time if there is a AppWidgetHost installed with an instance for this provider.</para> <para>This is a protected intent that can only be sent by the system.</para> <para> <para>AppWidgetProvider::onEnabled AppWidgetProvider.onEnabled(Context context) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_ENABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_ENABLED = "android.appwidget.action.APPWIDGET_ENABLED";
				/// <summary>
				///  <para>Field for the manifest meta-data tag.</para> <para> <para>AppWidgetProviderInfo </para></para>        
				/// </summary>
				/// <java-name>
				/// META_DATA_APPWIDGET_PROVIDER
				/// </java-name>
				[Dot42.DexImport("META_DATA_APPWIDGET_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string META_DATA_APPWIDGET_PROVIDER = "android.appwidget.provider";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AppWidgetManager() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the AppWidgetManager instance to use for the supplied Context object. </para>        
				/// </summary>
				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Landroid/content/Context;)Landroid/appwidget/AppWidgetManager;", AccessFlags = 9)]
				public static global::Android.Appwidget.AppWidgetManager GetInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetManager);
				}

				/// <summary>
				///  <para>Set the RemoteViews to use for the specified appWidgetId.</para> <para>Note that the RemoteViews parameter will be cached by the AppWidgetService, and hence should contain a complete representation of the widget. For performing partial widget updates, see partiallyUpdateAppWidget(int, RemoteViews).</para> <para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para> <para>The total Bitmap memory used by the RemoteViews object cannot exceed that required to fill the screen 1.5 times, ie. (screen width x screen height x 4 x 1.5) bytes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "([ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(int[] appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Update the extras for a given widget instance.</para> <para>The extras can be used to embed additional information about this widget to be accessed by the associated widget's AppWidgetProvider.</para> <para> <para>getAppWidgetOptions(int)</para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidgetOptions
				/// </java-name>
				[Dot42.DexImport("updateAppWidgetOptions", "(ILandroid/os/Bundle;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidgetOptions(int appWidgetId, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the extras associated with a given widget instance.</para> <para>The extras can be used to embed additional information about this widget to be accessed by the associated widget's AppWidgetProvider.</para> <para> <para>updateAppWidgetOptions(int, Bundle)</para></para>        
				/// </summary>
				/// <returns>
				///  <para>The options associated with the given widget instance. </para>
				/// </returns>
				/// <java-name>
				/// getAppWidgetOptions
				/// </java-name>
				[Dot42.DexImport("getAppWidgetOptions", "(I)Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.OS.Bundle GetAppWidgetOptions(int appWidgetId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.Bundle);
				}

				/// <summary>
				///  <para>Set the RemoteViews to use for the specified appWidgetId.</para> <para>Note that the RemoteViews parameter will be cached by the AppWidgetService, and hence should contain a complete representation of the widget. For performing partial widget updates, see partiallyUpdateAppWidget(int, RemoteViews).</para> <para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para> <para>The total Bitmap memory used by the RemoteViews object cannot exceed that required to fill the screen 1.5 times, ie. (screen width x screen height x 4 x 1.5) bytes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "(ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(int appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform an incremental update or command on the widget specified by appWidgetId.</para> <para>This update differs from updateAppWidget(int, RemoteViews) in that the RemoteViews object which is passed is understood to be an incomplete representation of the widget, and hence is not cached by the AppWidgetService. Note that because these updates are not cached, any state that they modify that is not restored by restoreInstanceState will not persist in the case that the widgets are restored using the cached version in AppWidgetService.</para> <para>Use with RemoteViews#showNext(int), RemoteViews#showPrevious(int), RemoteViews#setScrollPosition(int, int) and similar commands.</para> <para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para> <para>This method will be ignored if a widget has not received a full update via updateAppWidget(int[], RemoteViews).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// partiallyUpdateAppWidget
				/// </java-name>
				[Dot42.DexImport("partiallyUpdateAppWidget", "([ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void PartiallyUpdateAppWidget(int[] appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Perform an incremental update or command on the widget specified by appWidgetId.</para> <para>This update differs from updateAppWidget(int, RemoteViews) in that the RemoteViews object which is passed is understood to be an incomplete representation of the widget, and hence is not cached by the AppWidgetService. Note that because these updates are not cached, any state that they modify that is not restored by restoreInstanceState will not persist in the case that the widgets are restored using the cached version in AppWidgetService.</para> <para>Use with RemoteViews#showNext(int), RemoteViews#showPrevious(int), RemoteViews#setScrollPosition(int, int) and similar commands.</para> <para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para> <para>This method will be ignored if a widget has not received a full update via updateAppWidget(int[], RemoteViews).</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// partiallyUpdateAppWidget
				/// </java-name>
				[Dot42.DexImport("partiallyUpdateAppWidget", "(ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void PartiallyUpdateAppWidget(int appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Set the RemoteViews to use for the specified appWidgetId.</para> <para>Note that the RemoteViews parameter will be cached by the AppWidgetService, and hence should contain a complete representation of the widget. For performing partial widget updates, see partiallyUpdateAppWidget(int, RemoteViews).</para> <para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para> <para>The total Bitmap memory used by the RemoteViews object cannot exceed that required to fill the screen 1.5 times, ie. (screen width x screen height x 4 x 1.5) bytes.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "(Landroid/content/ComponentName;Landroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(global::Android.Content.ComponentName appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies the specified collection view in the specified AppWidget instance to invalidate its data.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notifyAppWidgetViewDataChanged
				/// </java-name>
				[Dot42.DexImport("notifyAppWidgetViewDataChanged", "([II)V", AccessFlags = 1)]
				public virtual void NotifyAppWidgetViewDataChanged(int[] appWidgetId, int viewId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Notifies the specified collection view in the specified AppWidget instance to invalidate its data.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// notifyAppWidgetViewDataChanged
				/// </java-name>
				[Dot42.DexImport("notifyAppWidgetViewDataChanged", "(II)V", AccessFlags = 1)]
				public virtual void NotifyAppWidgetViewDataChanged(int appWidgetId, int viewId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Get the available info about the AppWidget.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>A appWidgetId. If the appWidgetId has not been bound to a provider yet, or you don't have access to that appWidgetId, null is returned. </para>
				/// </returns>
				/// <java-name>
				/// getAppWidgetInfo
				/// </java-name>
				[Dot42.DexImport("getAppWidgetInfo", "(I)Landroid/appwidget/AppWidgetProviderInfo;", AccessFlags = 1)]
				public virtual global::Android.Appwidget.AppWidgetProviderInfo GetAppWidgetInfo(int appWidgetId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetProviderInfo);
				}

				/// <summary>
				///  <para>Set the component for a given appWidgetId.</para> <para>You need the BIND_APPWIDGET permission or the user must have enabled binding widgets always for your component. Should be used by apps that host widgets; if this method returns false, call ACTION_APPWIDGET_BIND to request permission to bind</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this component has permission to bind the AppWidget </para>
				/// </returns>
				/// <java-name>
				/// bindAppWidgetIdIfAllowed
				/// </java-name>
				[Dot42.DexImport("bindAppWidgetIdIfAllowed", "(ILandroid/content/ComponentName;)Z", AccessFlags = 1)]
				public virtual bool BindAppWidgetIdIfAllowed(int appWidgetId, global::Android.Content.ComponentName provider) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Set the component for a given appWidgetId.</para> <para>You need the BIND_APPWIDGET permission or the user must have enabled binding widgets always for your component. Should be used by apps that host widgets; if this method returns false, call ACTION_APPWIDGET_BIND to request permission to bind</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>true if this component has permission to bind the AppWidget </para>
				/// </returns>
				/// <java-name>
				/// bindAppWidgetIdIfAllowed
				/// </java-name>
				[Dot42.DexImport("bindAppWidgetIdIfAllowed", "(ILandroid/content/ComponentName;Landroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool BindAppWidgetIdIfAllowed(int appWidgetId, global::Android.Content.ComponentName provider, global::Android.OS.Bundle options) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Get the list of appWidgetIds that have been bound to the given AppWidget provider.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// getAppWidgetIds
				/// </java-name>
				[Dot42.DexImport("getAppWidgetIds", "(Landroid/content/ComponentName;)[I", AccessFlags = 1)]
				public virtual int[] GetAppWidgetIds(global::Android.Content.ComponentName provider) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <summary>
				///  <para>Return a list of the AppWidget providers that are currently installed. </para>        
				/// </summary>
				/// <java-name>
				/// getInstalledProviders
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Appwidget.AppWidgetProviderInfo> InstalledProviders
				{
						[Dot42.DexImport("getInstalledProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/appwidget/AppWidgetProviderInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Appwidget.AppWidgetProviderInfo>); }
				}

		}

		/// <summary>
		///  <para>A convenience class to aid in implementing an AppWidget provider. Everything you can do with AppWidgetProvider, you can do with a regular BroadcastReceiver. AppWidgetProvider merely parses the relevant fields out of the Intent that is received in onReceive(Context,Intent), and calls hook methods with the received extras.</para> <para>Extend this class and override one or more of the onUpdate, onDeleted, onEnabled or onDisabled methods to implement your own AppWidget functionality. </para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about how to write an app widget provider, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetProvider
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetProvider", AccessFlags = 33)]
		public partial class AppWidgetProvider : global::Android.Content.BroadcastReceiver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Constructor to initialize AppWidgetProvider. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AppWidgetProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Implements BroadcastReceiver#onReceive to dispatch calls to the various other methods on AppWidgetProvider.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onReceive
				/// </java-name>
				[Dot42.DexImport("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void OnReceive(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_UPDATE broadcast when this AppWidget provider is being asked to provide RemoteViews for a set of AppWidgets. Override this method to implement your own AppWidget functionality.</para> <para>{}</para> <para> <para>AppWidgetManager::ACTION_APPWIDGET_UPDATE </para></para>        
				/// </summary>
				/// <java-name>
				/// onUpdate
				/// </java-name>
				[Dot42.DexImport("onUpdate", "(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;[I)V", AccessFlags = 1)]
				public virtual void OnUpdate(global::Android.Content.Context context, global::Android.Appwidget.AppWidgetManager appWidgetManager, int[] appWidgetIds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_OPTIONS_CHANGED broadcast when this widget has been layed out at a new size.</para> <para>{}</para> <para> <para>AppWidgetManager::ACTION_APPWIDGET_OPTIONS_CHANGED </para></para>        
				/// </summary>
				/// <java-name>
				/// onAppWidgetOptionsChanged
				/// </java-name>
				[Dot42.DexImport("onAppWidgetOptionsChanged", "(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;ILandroid/os/Bundle" +
    ";)V", AccessFlags = 1)]
				public virtual void OnAppWidgetOptionsChanged(global::Android.Content.Context context, global::Android.Appwidget.AppWidgetManager appWidgetManager, int appWidgetId, global::Android.OS.Bundle newOptions) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_DELETED broadcast when one or more AppWidget instances have been deleted. Override this method to implement your own AppWidget functionality.</para> <para>{}</para> <para> <para>AppWidgetManager::ACTION_APPWIDGET_DELETED </para></para>        
				/// </summary>
				/// <java-name>
				/// onDeleted
				/// </java-name>
				[Dot42.DexImport("onDeleted", "(Landroid/content/Context;[I)V", AccessFlags = 1)]
				public virtual void OnDeleted(global::Android.Content.Context context, int[] appWidgetIds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_ENABLED broadcast when the a AppWidget for this provider is instantiated. Override this method to implement your own AppWidget functionality.</para> <para>{} When the last AppWidget for this provider is deleted, AppWidgetManager#ACTION_APPWIDGET_DISABLED is sent by the AppWidget manager, and onDisabled is called. If after that, an AppWidget for this provider is created again, onEnabled() will be called again.</para> <para> <para>AppWidgetManager::ACTION_APPWIDGET_ENABLED </para></para>        
				/// </summary>
				/// <java-name>
				/// onEnabled
				/// </java-name>
				[Dot42.DexImport("onEnabled", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void OnEnabled(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_DISABLED broadcast, which is sent when the last AppWidget instance for this provider is deleted. Override this method to implement your own AppWidget functionality.</para> <para>{}</para> <para> <para>AppWidgetManager::ACTION_APPWIDGET_DISABLED </para></para>        
				/// </summary>
				/// <java-name>
				/// onDisabled
				/// </java-name>
				[Dot42.DexImport("onDisabled", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void OnDisabled(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <summary>
		///  <para>Describes the meta data for an installed AppWidget provider. The fields in this class correspond to the fields in the  <code>&lt;appwidget-provider&gt;</code> xml tag. </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetProviderInfo
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetProviderInfo", AccessFlags = 33)]
		public partial class AppWidgetProviderInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Widget is not resizable. </para>        
				/// </summary>
				/// <java-name>
				/// RESIZE_NONE
				/// </java-name>
				[Dot42.DexImport("RESIZE_NONE", "I", AccessFlags = 25)]
				public const int RESIZE_NONE = 0;
				/// <summary>
				///  <para>Widget is resizable in the horizontal axis only. </para>        
				/// </summary>
				/// <java-name>
				/// RESIZE_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("RESIZE_HORIZONTAL", "I", AccessFlags = 25)]
				public const int RESIZE_HORIZONTAL = 1;
				/// <summary>
				///  <para>Widget is resizable in the vertical axis only. </para>        
				/// </summary>
				/// <java-name>
				/// RESIZE_VERTICAL
				/// </java-name>
				[Dot42.DexImport("RESIZE_VERTICAL", "I", AccessFlags = 25)]
				public const int RESIZE_VERTICAL = 2;
				/// <summary>
				///  <para>Widget is resizable in both the horizontal and vertical axes. </para>        
				/// </summary>
				/// <java-name>
				/// RESIZE_BOTH
				/// </java-name>
				[Dot42.DexImport("RESIZE_BOTH", "I", AccessFlags = 25)]
				public const int RESIZE_BOTH = 3;
				/// <summary>
				///  <para>Indicates that the widget can be displayed on the home screen. This is the default value. </para>        
				/// </summary>
				/// <java-name>
				/// WIDGET_CATEGORY_HOME_SCREEN
				/// </java-name>
				[Dot42.DexImport("WIDGET_CATEGORY_HOME_SCREEN", "I", AccessFlags = 25)]
				public const int WIDGET_CATEGORY_HOME_SCREEN = 1;
				/// <summary>
				///  <para>Indicates that the widget can be displayed on the keyguard. </para>        
				/// </summary>
				/// <java-name>
				/// WIDGET_CATEGORY_KEYGUARD
				/// </java-name>
				[Dot42.DexImport("WIDGET_CATEGORY_KEYGUARD", "I", AccessFlags = 25)]
				public const int WIDGET_CATEGORY_KEYGUARD = 2;
				/// <summary>
				///  <para>Identity of this AppWidget component. This component should be a android.content.BroadcastReceiver, and it will be sent the AppWidget intents as described in the AppWidget package documentation.</para> <para>This field corresponds to the  <code>android:name</code> attribute in the  <code>&lt;receiver&gt;</code> element in the AndroidManifest.xml file. </para>        
				/// </summary>
				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName Provider;
				/// <summary>
				///  <para>The default height of the widget when added to a host, in dp. The widget will get at least this width, and will often be given more, depending on the host.</para> <para>This field corresponds to the  <code>android:minWidth</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// minWidth
				/// </java-name>
				[Dot42.DexImport("minWidth", "I", AccessFlags = 1)]
				public int MinWidth;
				/// <summary>
				///  <para>The default height of the widget when added to a host, in dp. The widget will get at least this height, and will often be given more, depending on the host.</para> <para>This field corresponds to the  <code>android:minHeight</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// minHeight
				/// </java-name>
				[Dot42.DexImport("minHeight", "I", AccessFlags = 1)]
				public int MinHeight;
				/// <summary>
				///  <para>Minimum width (in dp) which the widget can be resized to. This field has no effect if it is greater than minWidth or if horizontal resizing isn't enabled (see resizeMode).</para> <para>This field corresponds to the  <code>android:minResizeWidth</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// minResizeWidth
				/// </java-name>
				[Dot42.DexImport("minResizeWidth", "I", AccessFlags = 1)]
				public int MinResizeWidth;
				/// <summary>
				///  <para>Minimum height (in dp) which the widget can be resized to. This field has no effect if it is greater than minHeight or if vertical resizing isn't enabled (see resizeMode).</para> <para>This field corresponds to the  <code>android:minResizeHeight</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// minResizeHeight
				/// </java-name>
				[Dot42.DexImport("minResizeHeight", "I", AccessFlags = 1)]
				public int MinResizeHeight;
				/// <summary>
				///  <para>How often, in milliseconds, that this AppWidget wants to be updated. The AppWidget manager may place a limit on how often a AppWidget is updated.</para> <para>This field corresponds to the  <code>android:updatePeriodMillis</code> attribute in the AppWidget meta-data file.</para> <para> <b>Note:</b> Updates requested with  <code>updatePeriodMillis</code> will not be delivered more than once every 30 minutes.</para>        
				/// </summary>
				/// <java-name>
				/// updatePeriodMillis
				/// </java-name>
				[Dot42.DexImport("updatePeriodMillis", "I", AccessFlags = 1)]
				public int UpdatePeriodMillis;
				/// <summary>
				///  <para>The resource id of the initial layout for this AppWidget. This should be displayed until the RemoteViews for the AppWidget is available.</para> <para>This field corresponds to the  <code>android:initialLayout</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// initialLayout
				/// </java-name>
				[Dot42.DexImport("initialLayout", "I", AccessFlags = 1)]
				public int InitialLayout;
				/// <summary>
				///  <para>The resource id of the initial layout for this AppWidget when it is displayed on keyguard. This parameter only needs to be provided if the widget can be displayed on the keyguard, see widgetCategory.</para> <para>This field corresponds to the  <code>android:initialKeyguardLayout</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// initialKeyguardLayout
				/// </java-name>
				[Dot42.DexImport("initialKeyguardLayout", "I", AccessFlags = 1)]
				public int InitialKeyguardLayout;
				/// <summary>
				///  <para>The activity to launch that will configure the AppWidget.</para> <para>This class name of field corresponds to the  <code>android:configure</code> attribute in the AppWidget meta-data file. The package name always corresponds to the package containing the AppWidget provider. </para>        
				/// </summary>
				/// <java-name>
				/// configure
				/// </java-name>
				[Dot42.DexImport("configure", "Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName Configure;
				/// <summary>
				///  <para>The label to display to the user in the AppWidget picker. If not supplied in the xml, the application label will be used.</para> <para>This field corresponds to the  <code>android:label</code> attribute in the  <code>&lt;receiver&gt;</code> element in the AndroidManifest.xml file. </para>        
				/// </summary>
				/// <java-name>
				/// label
				/// </java-name>
				[Dot42.DexImport("label", "Ljava/lang/String;", AccessFlags = 1)]
				public string Label;
				/// <summary>
				///  <para>The icon to display for this AppWidget in the AppWidget picker. If not supplied in the xml, the application icon will be used.</para> <para>This field corresponds to the  <code>android:icon</code> attribute in the  <code>&lt;receiver&gt;</code> element in the AndroidManifest.xml file. </para>        
				/// </summary>
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <summary>
				///  <para>The view id of the AppWidget subview which should be auto-advanced by the widget's host.</para> <para>This field corresponds to the  <code>android:autoAdvanceViewId</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// autoAdvanceViewId
				/// </java-name>
				[Dot42.DexImport("autoAdvanceViewId", "I", AccessFlags = 1)]
				public int AutoAdvanceViewId;
				/// <summary>
				///  <para>A preview of what the AppWidget will look like after it's configured. If not supplied, the AppWidget's icon will be used.</para> <para>This field corresponds to the  <code>android:previewImage</code> attribute in the  <code>&lt;receiver&gt;</code> element in the AndroidManifest.xml file. </para>        
				/// </summary>
				/// <java-name>
				/// previewImage
				/// </java-name>
				[Dot42.DexImport("previewImage", "I", AccessFlags = 1)]
				public int PreviewImage;
				/// <summary>
				///  <para>The rules by which a widget can be resized. See RESIZE_NONE, RESIZE_NONE, RESIZE_HORIZONTAL, RESIZE_VERTICAL, RESIZE_BOTH.</para> <para>This field corresponds to the  <code>android:resizeMode</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// resizeMode
				/// </java-name>
				[Dot42.DexImport("resizeMode", "I", AccessFlags = 1)]
				public int ResizeMode;
				/// <summary>
				///  <para>Determines whether this widget can be displayed on the home screen, the keyguard, or both. A widget which is displayed on both needs to ensure that it follows the design guidelines for both widget classes. This can be achieved by querying the AppWidget options in its widget provider's update method.</para> <para>This field corresponds to the  <code>widgetCategory</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// widgetCategory
				/// </java-name>
				[Dot42.DexImport("widgetCategory", "I", AccessFlags = 1)]
				public int WidgetCategory;
				/// <summary>
				///  <para>Parcelable.Creator that instantiates AppWidgetProviderInfo objects </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Appwidget.AppWidgetProviderInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AppWidgetProviderInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Unflatten the AppWidgetProviderInfo from a parcel. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public AppWidgetProviderInfo(global::Android.OS.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.OS.Parcel @out, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Landroid/appwidget/AppWidgetProviderInfo;", AccessFlags = 1)]
				public virtual global::Android.Appwidget.AppWidgetProviderInfo Clone() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetProviderInfo);
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

}

