// Copyright (C) 2014 dot42
//
// Original filename: Android.Appwidget.cs
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
namespace Android.Appwidget
{
		/// <summary>
		/// <para>Describes the meta data for an installed AppWidget provider. The fields in this class correspond to the fields in the <code>&lt;appwidget-provider&gt;</code> xml tag. </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetProviderInfo
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetProviderInfo", AccessFlags = 33)]
		public partial class AppWidgetProviderInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Identity of this AppWidget component. This component should be a android.content.BroadcastReceiver, and it will be sent the AppWidget intents as described in the AppWidget package documentation.</para><para>This field corresponds to the <code>android:name</code> attribute in the <code>&lt;receiver&gt;</code> element in the AndroidManifest.xml file. </para>        
				/// </summary>
				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName Provider;
				/// <summary>
				/// <para>The default height of the widget when added to a host, in dp. The widget will get at least this width, and will often be given more, depending on the host.</para><para>This field corresponds to the <code>android:minWidth</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// minWidth
				/// </java-name>
				[Dot42.DexImport("minWidth", "I", AccessFlags = 1)]
				public int MinWidth;
				/// <summary>
				/// <para>The default height of the widget when added to a host, in dp. The widget will get at least this height, and will often be given more, depending on the host.</para><para>This field corresponds to the <code>android:minHeight</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// minHeight
				/// </java-name>
				[Dot42.DexImport("minHeight", "I", AccessFlags = 1)]
				public int MinHeight;
				/// <summary>
				/// <para>How often, in milliseconds, that this AppWidget wants to be updated. The AppWidget manager may place a limit on how often a AppWidget is updated.</para><para>This field corresponds to the <code>android:updatePeriodMillis</code> attribute in the AppWidget meta-data file.</para><para><b>Note:</b> Updates requested with <code>updatePeriodMillis</code> will not be delivered more than once every 30 minutes.</para>        
				/// </summary>
				/// <java-name>
				/// updatePeriodMillis
				/// </java-name>
				[Dot42.DexImport("updatePeriodMillis", "I", AccessFlags = 1)]
				public int UpdatePeriodMillis;
				/// <summary>
				/// <para>The resource id of the initial layout for this AppWidget. This should be displayed until the RemoteViews for the AppWidget is available.</para><para>This field corresponds to the <code>android:initialLayout</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// initialLayout
				/// </java-name>
				[Dot42.DexImport("initialLayout", "I", AccessFlags = 1)]
				public int InitialLayout;
				/// <summary>
				/// <para>The activity to launch that will configure the AppWidget.</para><para>This class name of field corresponds to the <code>android:configure</code> attribute in the AppWidget meta-data file. The package name always corresponds to the package containing the AppWidget provider. </para>        
				/// </summary>
				/// <java-name>
				/// configure
				/// </java-name>
				[Dot42.DexImport("configure", "Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName Configure;
				/// <summary>
				/// <para>The label to display to the user in the AppWidget picker. If not supplied in the xml, the application label will be used.</para><para>This field corresponds to the <code>android:label</code> attribute in the <code>&lt;receiver&gt;</code> element in the AndroidManifest.xml file. </para>        
				/// </summary>
				/// <java-name>
				/// label
				/// </java-name>
				[Dot42.DexImport("label", "Ljava/lang/String;", AccessFlags = 1)]
				public string Label;
				/// <summary>
				/// <para>The icon to display for this AppWidget in the AppWidget picker. If not supplied in the xml, the application icon will be used.</para><para>This field corresponds to the <code>android:icon</code> attribute in the <code>&lt;receiver&gt;</code> element in the AndroidManifest.xml file. </para>        
				/// </summary>
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <summary>
				/// <para>The view id of the AppWidget subview which should be auto-advanced by the widget's host.</para><para>This field corresponds to the <code>android:autoAdvanceViewId</code> attribute in the AppWidget meta-data file. </para>        
				/// </summary>
				/// <java-name>
				/// autoAdvanceViewId
				/// </java-name>
				[Dot42.DexImport("autoAdvanceViewId", "I", AccessFlags = 1)]
				public int AutoAdvanceViewId;
				/// <summary>
				/// <para>A preview of what the AppWidget will look like after it's configured. If not supplied, the AppWidget's icon will be used.</para><para>This field corresponds to the <code>android:previewImage</code> attribute in the <code>&lt;receiver&gt;</code> element in the AndroidManifest.xml file. </para>        
				/// </summary>
				/// <java-name>
				/// previewImage
				/// </java-name>
				[Dot42.DexImport("previewImage", "I", AccessFlags = 1)]
				public int PreviewImage;
				/// <summary>
				/// <para>Parcelable.Creator that instantiates AppWidgetProviderInfo objects </para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.Appwidget.AppWidgetProviderInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AppWidgetProviderInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Unflatten the AppWidgetProviderInfo from a parcel. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public AppWidgetProviderInfo(global::Android.Os.Parcel @in) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel @out, int flags) /* MethodBuilder.Create */ 
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

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

		}

		/// <summary>
		/// <para>A convenience class to aid in implementing an AppWidget provider. Everything you can do with AppWidgetProvider, you can do with a regular BroadcastReceiver. AppWidgetProvider merely parses the relevant fields out of the Intent that is received in onReceive(Context,Intent), and calls hook methods with the received extras.</para><para>Extend this class and override one or more of the onUpdate, onDeleted, onEnabled or onDisabled methods to implement your own AppWidget functionality. </para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about how to write an app widget provider, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetProvider
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetProvider", AccessFlags = 33)]
		public partial class AppWidgetProvider : global::Android.Content.BroadcastReceiver
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Constructor to initialize AppWidgetProvider. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AppWidgetProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Implements BroadcastReceiver#onReceive to dispatch calls to the various other methods on AppWidgetProvider.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// onReceive
				/// </java-name>
				[Dot42.DexImport("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void OnReceive(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_UPDATE broadcast when this AppWidget provider is being asked to provide RemoteViews for a set of AppWidgets. Override this method to implement your own AppWidget functionality.</para><para>{}</para><para><para>AppWidgetManager::ACTION_APPWIDGET_UPDATE </para></para>        
				/// </summary>
				/// <java-name>
				/// onUpdate
				/// </java-name>
				[Dot42.DexImport("onUpdate", "(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;[I)V", AccessFlags = 1)]
				public virtual void OnUpdate(global::Android.Content.Context context, global::Android.Appwidget.AppWidgetManager appWidgetManager, int[] appWidgetIds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_DELETED broadcast when one or more AppWidget instances have been deleted. Override this method to implement your own AppWidget functionality.</para><para>{}</para><para><para>AppWidgetManager::ACTION_APPWIDGET_DELETED </para></para>        
				/// </summary>
				/// <java-name>
				/// onDeleted
				/// </java-name>
				[Dot42.DexImport("onDeleted", "(Landroid/content/Context;[I)V", AccessFlags = 1)]
				public virtual void OnDeleted(global::Android.Content.Context context, int[] appWidgetIds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_ENABLED broadcast when the a AppWidget for this provider is instantiated. Override this method to implement your own AppWidget functionality.</para><para>{} When the last AppWidget for this provider is deleted, AppWidgetManager#ACTION_APPWIDGET_DISABLED is sent by the AppWidget manager, and onDisabled is called. If after that, an AppWidget for this provider is created again, onEnabled() will be called again.</para><para><para>AppWidgetManager::ACTION_APPWIDGET_ENABLED </para></para>        
				/// </summary>
				/// <java-name>
				/// onEnabled
				/// </java-name>
				[Dot42.DexImport("onEnabled", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void OnEnabled(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called in response to the AppWidgetManager#ACTION_APPWIDGET_DISABLED broadcast, which is sent when the last AppWidget instance for this provider is deleted. Override this method to implement your own AppWidget functionality.</para><para>{}</para><para><para>AppWidgetManager::ACTION_APPWIDGET_DISABLED </para></para>        
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
		/// <para>Provides the glue to show AppWidget views. This class offers automatic animation between updates, and will try recycling old views for each incoming RemoteViews. </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetHostView
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetHostView", AccessFlags = 33)]
		public partial class AppWidgetHostView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Create a host view. Uses default fade animations. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AppWidgetHostView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create a host view. Uses specified animations when pushing updateAppWidget(RemoteViews).</para><para></para>        
				/// </summary>
				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public AppWidgetHostView(global::Android.Content.Context context, int animationIn, int animationOut) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the AppWidget that will be displayed by this view. This method also adds default padding to widgets, as described in getDefaultPaddingForWidget(Context, ComponentName, Rect) and can be overridden in order to add custom padding. </para>        
				/// </summary>
				/// <java-name>
				/// setAppWidget
				/// </java-name>
				[Dot42.DexImport("setAppWidget", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", AccessFlags = 1)]
				public virtual void SetAppWidget(int appWidgetId, global::Android.Appwidget.AppWidgetProviderInfo info) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAppWidgetId
				/// </java-name>
				[Dot42.DexImport("getAppWidgetId", "()I", AccessFlags = 1)]
				public virtual int GetAppWidgetId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getAppWidgetInfo
				/// </java-name>
				[Dot42.DexImport("getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;", AccessFlags = 1)]
				public virtual global::Android.Appwidget.AppWidgetProviderInfo GetAppWidgetInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetProviderInfo);
				}

				/// <summary>
				/// <para><para><para>Called by saveHierarchyState(android.util.SparseArray) to store the state for this view and its children. May be overridden to modify how freezing happens to a view's children; for example, some views may want to not store state for their children.</para><para><para>dispatchRestoreInstanceState(android.util.SparseArray) </para><simplesectsep></simplesectsep><para>saveHierarchyState(android.util.SparseArray) </para><simplesectsep></simplesectsep><para>onSaveInstanceState()</para></para></para> </para>        
				/// </summary>
				/// <java-name>
				/// dispatchSaveInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchSaveInstanceState(global::Android.Util.SparseArray<global::Android.Os.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para><para>Called by restoreHierarchyState(android.util.SparseArray) to retrieve the state for this view and its children. May be overridden to modify how restoring happens to a view's children; for example, some views may want to not store state for their children.</para><para><para>dispatchSaveInstanceState(android.util.SparseArray) </para><simplesectsep></simplesectsep><para>restoreHierarchyState(android.util.SparseArray) </para><simplesectsep></simplesectsep><para>onRestoreInstanceState(android.os.Parcelable)</para></para></para> </para>        
				/// </summary>
				/// <java-name>
				/// dispatchRestoreInstanceState
				/// </java-name>
				[Dot42.DexImport("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", AccessFlags = 4, Signature = "(Landroid/util/SparseArray<Landroid/os/Parcelable;>;)V")]
				protected internal override void DispatchRestoreInstanceState(global::Android.Util.SparseArray<global::Android.Os.IParcelable> container) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para><para>Returns a new set of layout parameters based on the supplied attributes set.</para><para></para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>an instance of android.view.ViewGroup.LayoutParams or one of its descendants</para>
				/// </returns>
				/// <java-name>
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", AccessFlags = 1)]
				public override global::Android.Widget.FrameLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attrs) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.FrameLayout.LayoutParams);
				}

				/// <summary>
				/// <para>Process a set of RemoteViews coming in as an update from the AppWidget provider. Will animate into these new views as needed </para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "(Landroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Draw one child of this View Group. This method is responsible for getting the canvas in the right state. This includes clipping, translating so that the child's scrolled origin is at 0, 0, and applying any animation transformations.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if an invalidate() was issued </para>
				/// </returns>
				/// <java-name>
				/// drawChild
				/// </java-name>
				[Dot42.DexImport("drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z", AccessFlags = 4)]
				protected internal override bool DrawChild(global::Android.Graphics.Canvas canvas, global::Android.View.View child, long drawingTime) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Prepare the given view to be shown. This might include adjusting FrameLayout.LayoutParams before inserting. </para>        
				/// </summary>
				/// <java-name>
				/// prepareView
				/// </java-name>
				[Dot42.DexImport("prepareView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void PrepareView(global::Android.View.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflate and return the default layout requested by AppWidget provider. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultView
				/// </java-name>
				[Dot42.DexImport("getDefaultView", "()Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.View.View GetDefaultView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Inflate and return a view that represents an error state. </para>        
				/// </summary>
				/// <java-name>
				/// getErrorView
				/// </java-name>
				[Dot42.DexImport("getErrorView", "()Landroid/view/View;", AccessFlags = 4)]
				protected internal virtual global::Android.View.View GetErrorView() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AppWidgetHostView() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAppWidgetId
				/// </java-name>
				public int AppWidgetId
				{
				[Dot42.DexImport("getAppWidgetId", "()I", AccessFlags = 1)]
						get{ return GetAppWidgetId(); }
				}

				/// <java-name>
				/// getAppWidgetInfo
				/// </java-name>
				public global::Android.Appwidget.AppWidgetProviderInfo AppWidgetInfo
				{
				[Dot42.DexImport("getAppWidgetInfo", "()Landroid/appwidget/AppWidgetProviderInfo;", AccessFlags = 1)]
						get{ return GetAppWidgetInfo(); }
				}

				/// <summary>
				/// <para>Inflate and return the default layout requested by AppWidget provider. </para>        
				/// </summary>
				/// <java-name>
				/// getDefaultView
				/// </java-name>
				protected internal global::Android.View.View DefaultView
				{
				[Dot42.DexImport("getDefaultView", "()Landroid/view/View;", AccessFlags = 4)]
						get{ return GetDefaultView(); }
				}

				/// <summary>
				/// <para>Inflate and return a view that represents an error state. </para>        
				/// </summary>
				/// <java-name>
				/// getErrorView
				/// </java-name>
				protected internal global::Android.View.View ErrorView
				{
				[Dot42.DexImport("getErrorView", "()Landroid/view/View;", AccessFlags = 4)]
						get{ return GetErrorView(); }
				}

		}

		/// <summary>
		/// <para>AppWidgetHost provides the interaction with the AppWidget service for apps, like the home screen, that want to embed AppWidgets in their UI. </para>    
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
				/// <para>Start receiving onAppWidgetChanged calls for your AppWidgets. Call this when your activity becomes visible, i.e. from onStart() in your Activity. </para>        
				/// </summary>
				/// <java-name>
				/// startListening
				/// </java-name>
				[Dot42.DexImport("startListening", "()V", AccessFlags = 1)]
				public virtual void StartListening() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Stop receiving onAppWidgetChanged calls for your AppWidgets. Call this when your activity is no longer visible, i.e. from onStop() in your Activity. </para>        
				/// </summary>
				/// <java-name>
				/// stopListening
				/// </java-name>
				[Dot42.DexImport("stopListening", "()V", AccessFlags = 1)]
				public virtual void StopListening() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get a appWidgetId for a host in the calling process.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>a appWidgetId </para>
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
				/// <para>Stop listening to changes for this AppWidget. </para>        
				/// </summary>
				/// <java-name>
				/// deleteAppWidgetId
				/// </java-name>
				[Dot42.DexImport("deleteAppWidgetId", "(I)V", AccessFlags = 1)]
				public virtual void DeleteAppWidgetId(int appWidgetId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove all records about this host from the AppWidget manager. <ul><li><para>Call this when initializing your database, as it might be because of a data wipe. </para></li><li><para>Call this to have the AppWidget manager release all resources associated with your host. Any future calls about this host will cause the records to be re-allocated. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// deleteHost
				/// </java-name>
				[Dot42.DexImport("deleteHost", "()V", AccessFlags = 1)]
				public virtual void DeleteHost() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Remove all records about all hosts for your package. <ul><li><para>Call this when initializing your database, as it might be because of a data wipe. </para></li><li><para>Call this to have the AppWidget manager release all resources associated with your host. Any future calls about this host will cause the records to be re-allocated. </para></li></ul></para>        
				/// </summary>
				/// <java-name>
				/// deleteAllHosts
				/// </java-name>
				[Dot42.DexImport("deleteAllHosts", "()V", AccessFlags = 9)]
				public static void DeleteAllHosts() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Create the AppWidgetHostView for the given widget. The AppWidgetHost retains a pointer to the newly-created View. </para>        
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
				/// <para>Called to create the AppWidgetHostView. Override to return a custom subclass if you need it. {} </para>        
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
				/// <para>Called when the AppWidget provider for a AppWidget has been upgraded to a new apk. </para>        
				/// </summary>
				/// <java-name>
				/// onProviderChanged
				/// </java-name>
				[Dot42.DexImport("onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", AccessFlags = 4)]
				protected internal virtual void OnProviderChanged(int appWidgetId, global::Android.Appwidget.AppWidgetProviderInfo appWidget) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Clear the list of Views that have been created by this AppWidgetHost. </para>        
				/// </summary>
				/// <java-name>
				/// clearViews
				/// </java-name>
				[Dot42.DexImport("clearViews", "()V", AccessFlags = 4)]
				protected internal virtual void ClearViews() /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AppWidgetHost() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <summary>
		/// <para>Updates AppWidget state; gets information about installed AppWidget providers and other AppWidget related state.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about creating app widgets, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/appwidget/AppWidgetManager
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetManager", AccessFlags = 33)]
		public partial class AppWidgetManager
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Activity action to launch from your AppWidgetHost activity when you want to pick an AppWidget to display. The AppWidget picker activity will be launched. </para><para>You must supply the following extras: <table><row><entry><para>EXTRA_APPWIDGET_ID </para></entry><entry><para>A newly allocated appWidgetId, which will be bound to the AppWidget provider once the user has selected one.  </para></entry></row></table></para><para>The system will respond with an onActivityResult call with the following extras in the intent: <table><row><entry><para>EXTRA_APPWIDGET_ID </para></entry><entry><para>The appWidgetId that you supplied in the original intent.  </para></entry></row></table></para><para>When you receive the result from the AppWidget pick activity, if the resultCode is android.app.Activity#RESULT_OK, an AppWidget has been selected. You should then check the AppWidgetProviderInfo for the returned AppWidget, and if it has one, launch its configuration activity. If android.app.Activity#RESULT_CANCELED is returned, you should delete the appWidgetId.</para><para><para>ACTION_APPWIDGET_CONFIGURE </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_PICK
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_PICK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_PICK = "android.appwidget.action.APPWIDGET_PICK";
				/// <summary>
				/// <para>Sent when it is time to configure your AppWidget while it is being added to a host. This action is not sent as a broadcast to the AppWidget provider, but as a startActivity to the activity specified in the AppWidgetProviderInfo meta-data.</para><para>The intent will contain the following extras: <table><row><entry><para>EXTRA_APPWIDGET_ID </para></entry><entry><para>The appWidgetId to configure.  </para></entry></row></table></para><para>If you return android.app.Activity#RESULT_OK using Activity.setResult(), the AppWidget will be added, and you will receive an ACTION_APPWIDGET_UPDATE broadcast for this AppWidget. If you return android.app.Activity#RESULT_CANCELED, the host will cancel the add and not display this AppWidget, and you will receive a ACTION_APPWIDGET_DELETED broadcast. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_CONFIGURE
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_CONFIGURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_CONFIGURE = "android.appwidget.action.APPWIDGET_CONFIGURE";
				/// <summary>
				/// <para>An intent extra that contains one appWidgetId. </para><para>The value will be an int that can be retrieved like this: { frameworks/base/tests/appwidgets/AppWidgetHostTest/src/com/android/tests/appwidgethost/AppWidgetHostActivity.java getExtra_EXTRA_APPWIDGET_ID} </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_APPWIDGET_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPWIDGET_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPWIDGET_ID = "appWidgetId";
				/// <summary>
				/// <para>An intent extra that contains multiple appWidgetIds. </para><para>The value will be an int array that can be retrieved like this: { frameworks/base/tests/appwidgets/AppWidgetHostTest/src/com/android/tests/appwidgethost/TestAppWidgetProvider.java getExtra_EXTRA_APPWIDGET_IDS} </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_APPWIDGET_IDS
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPWIDGET_IDS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPWIDGET_IDS = "appWidgetIds";
				/// <summary>
				/// <para>An intent extra to pass to the AppWidget picker containing a java.util.List of AppWidgetProviderInfo objects to mix in to the list of AppWidgets that are installed. (This is how the launcher shows the search widget). </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CUSTOM_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_CUSTOM_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CUSTOM_INFO = "customInfo";
				/// <summary>
				/// <para>An intent extra to pass to the AppWidget picker containing a java.util.List of android.os.Bundle objects to mix in to the list of AppWidgets that are installed. It will be added to the extras object on the android.content.Intent that is returned from the picker activity.</para><para>{} </para>        
				/// </summary>
				/// <java-name>
				/// EXTRA_CUSTOM_EXTRAS
				/// </java-name>
				[Dot42.DexImport("EXTRA_CUSTOM_EXTRAS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CUSTOM_EXTRAS = "customExtras";
				/// <summary>
				/// <para>A sentinel value that the AppWidget manager will never return as a appWidgetId. </para>        
				/// </summary>
				/// <java-name>
				/// INVALID_APPWIDGET_ID
				/// </java-name>
				[Dot42.DexImport("INVALID_APPWIDGET_ID", "I", AccessFlags = 25)]
				public const int INVALID_APPWIDGET_ID = 0;
				/// <summary>
				/// <para>Sent when it is time to update your AppWidget.</para><para>This may be sent in response to a new instance for this AppWidget provider having been instantiated, the requested update interval having lapsed, or the system booting.</para><para>The intent will contain the following extras: <table><row><entry><para>EXTRA_APPWIDGET_IDS </para></entry><entry><para>The appWidgetIds to update. This may be all of the AppWidgets created for this provider, or just a subset. The system tries to send updates for as few AppWidget instances as possible.  </para></entry></row></table></para><para><para>AppWidgetProvider::onUpdate AppWidgetProvider.onUpdate(Context context, AppWidgetManager appWidgetManager, int[] appWidgetIds) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_UPDATE
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_UPDATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_UPDATE = "android.appwidget.action.APPWIDGET_UPDATE";
				/// <summary>
				/// <para>Sent when an instance of an AppWidget is deleted from its host.</para><para>This is a protected intent that can only be sent by the system.</para><para><para>AppWidgetProvider::onDeleted AppWidgetProvider.onDeleted(Context context, int[] appWidgetIds) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_DELETED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_DELETED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_DELETED = "android.appwidget.action.APPWIDGET_DELETED";
				/// <summary>
				/// <para>Sent when an instance of an AppWidget is removed from the last host.</para><para>This is a protected intent that can only be sent by the system.</para><para><para>AppWidgetProvider::onEnabled AppWidgetProvider.onEnabled(Context context) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_DISABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_DISABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_DISABLED = "android.appwidget.action.APPWIDGET_DISABLED";
				/// <summary>
				/// <para>Sent when an instance of an AppWidget is added to a host for the first time. This broadcast is sent at boot time if there is a AppWidgetHost installed with an instance for this provider.</para><para>This is a protected intent that can only be sent by the system.</para><para><para>AppWidgetProvider::onEnabled AppWidgetProvider.onEnabled(Context context) </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_APPWIDGET_ENABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_ENABLED = "android.appwidget.action.APPWIDGET_ENABLED";
				/// <summary>
				/// <para>Field for the manifest meta-data tag.</para><para><para>AppWidgetProviderInfo </para></para>        
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
				/// <para>Get the AppWidgetManager instance to use for the supplied Context object. </para>        
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
				/// <para>Set the RemoteViews to use for the specified appWidgetId.</para><para>Note that the RemoteViews parameter will be cached by the AppWidgetService, and hence should contain a complete representation of the widget. For performing partial widget updates, see partiallyUpdateAppWidget(int, RemoteViews).</para><para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para><para>The total Bitmap memory used by the RemoteViews object cannot exceed that required to fill the screen 1.5 times, ie. (screen width x screen height x 4 x 1.5) bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "([ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(int[] appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the RemoteViews to use for the specified appWidgetId.</para><para>Note that the RemoteViews parameter will be cached by the AppWidgetService, and hence should contain a complete representation of the widget. For performing partial widget updates, see partiallyUpdateAppWidget(int, RemoteViews).</para><para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para><para>The total Bitmap memory used by the RemoteViews object cannot exceed that required to fill the screen 1.5 times, ie. (screen width x screen height x 4 x 1.5) bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "(ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(int appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Perform an incremental update or command on the widget specified by appWidgetId.</para><para>This update differs from updateAppWidget(int, RemoteViews) in that the RemoteViews object which is passed is understood to be an incomplete representation of the widget, and hence is not cached by the AppWidgetService. Note that because these updates are not cached, any state that they modify that is not restored by restoreInstanceState will not persist in the case that the widgets are restored using the cached version in AppWidgetService.</para><para>Use with RemoteViews#showNext(int), RemoteViews#showPrevious(int), RemoteViews#setScrollPosition(int, int) and similar commands.</para><para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para><para>This method will be ignored if a widget has not received a full update via updateAppWidget(int[], RemoteViews).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// partiallyUpdateAppWidget
				/// </java-name>
				[Dot42.DexImport("partiallyUpdateAppWidget", "([ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void PartiallyUpdateAppWidget(int[] appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Perform an incremental update or command on the widget specified by appWidgetId.</para><para>This update differs from updateAppWidget(int, RemoteViews) in that the RemoteViews object which is passed is understood to be an incomplete representation of the widget, and hence is not cached by the AppWidgetService. Note that because these updates are not cached, any state that they modify that is not restored by restoreInstanceState will not persist in the case that the widgets are restored using the cached version in AppWidgetService.</para><para>Use with RemoteViews#showNext(int), RemoteViews#showPrevious(int), RemoteViews#setScrollPosition(int, int) and similar commands.</para><para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para><para>This method will be ignored if a widget has not received a full update via updateAppWidget(int[], RemoteViews).</para><para></para>        
				/// </summary>
				/// <java-name>
				/// partiallyUpdateAppWidget
				/// </java-name>
				[Dot42.DexImport("partiallyUpdateAppWidget", "(ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void PartiallyUpdateAppWidget(int appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Set the RemoteViews to use for the specified appWidgetId.</para><para>Note that the RemoteViews parameter will be cached by the AppWidgetService, and hence should contain a complete representation of the widget. For performing partial widget updates, see partiallyUpdateAppWidget(int, RemoteViews).</para><para>It is okay to call this method both inside an ACTION_APPWIDGET_UPDATE broadcast, and outside of the handler. This method will only work when called from the uid that owns the AppWidget provider.</para><para>The total Bitmap memory used by the RemoteViews object cannot exceed that required to fill the screen 1.5 times, ie. (screen width x screen height x 4 x 1.5) bytes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "(Landroid/content/ComponentName;Landroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(global::Android.Content.ComponentName appWidgetId, global::Android.Widget.RemoteViews views) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies the specified collection view in the specified AppWidget instance to invalidate its data.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// notifyAppWidgetViewDataChanged
				/// </java-name>
				[Dot42.DexImport("notifyAppWidgetViewDataChanged", "([II)V", AccessFlags = 1)]
				public virtual void NotifyAppWidgetViewDataChanged(int[] appWidgetId, int viewId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Notifies the specified collection view in the specified AppWidget instance to invalidate its data.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// notifyAppWidgetViewDataChanged
				/// </java-name>
				[Dot42.DexImport("notifyAppWidgetViewDataChanged", "(II)V", AccessFlags = 1)]
				public virtual void NotifyAppWidgetViewDataChanged(int appWidgetId, int viewId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Return a list of the AppWidget providers that are currently installed. </para>        
				/// </summary>
				/// <java-name>
				/// getInstalledProviders
				/// </java-name>
				[Dot42.DexImport("getInstalledProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/appwidget/AppWidgetProviderInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.Appwidget.AppWidgetProviderInfo> GetInstalledProviders() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Appwidget.AppWidgetProviderInfo>);
				}

				/// <summary>
				/// <para>Get the available info about the AppWidget.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A appWidgetId. If the appWidgetId has not been bound to a provider yet, or you don't have access to that appWidgetId, null is returned. </para>
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
				/// <para>Set the component for a given appWidgetId.</para><para>You need the BIND_APPWIDGET permission or the user must have enabled binding widgets always for your component. This method is used by the AppWidget picker and should not be used by other apps.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// bindAppWidgetId
				/// </java-name>
				[Dot42.DexImport("bindAppWidgetId", "(ILandroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void BindAppWidgetId(int appWidgetId, global::Android.Content.ComponentName provider) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Get the list of appWidgetIds that have been bound to the given AppWidget provider.</para><para></para>        
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
				/// <para>Return a list of the AppWidget providers that are currently installed. </para>        
				/// </summary>
				/// <java-name>
				/// getInstalledProviders
				/// </java-name>
				public global::Java.Util.IList<global::Android.Appwidget.AppWidgetProviderInfo> InstalledProviders
				{
				[Dot42.DexImport("getInstalledProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/appwidget/AppWidgetProviderInfo;>;")]
						get{ return GetInstalledProviders(); }
				}

		}

}


