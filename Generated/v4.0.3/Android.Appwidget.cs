#pragma warning disable 1717
namespace Android.Appwidget
{
		/// <java-name>
		/// android/appwidget/AppWidgetHost
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetHost", AccessFlags = 33)]
		public partial class AppWidgetHost
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;I)V", AccessFlags = 1)]
				public AppWidgetHost(global::Android.Content.Context context, int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// startListening
				/// </java-name>
				[Dot42.DexImport("startListening", "()V", AccessFlags = 1)]
				public virtual void StartListening() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// stopListening
				/// </java-name>
				[Dot42.DexImport("stopListening", "()V", AccessFlags = 1)]
				public virtual void StopListening() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// allocateAppWidgetId
				/// </java-name>
				[Dot42.DexImport("allocateAppWidgetId", "()I", AccessFlags = 1)]
				public virtual int AllocateAppWidgetId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// deleteAppWidgetId
				/// </java-name>
				[Dot42.DexImport("deleteAppWidgetId", "(I)V", AccessFlags = 1)]
				public virtual void DeleteAppWidgetId(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteHost
				/// </java-name>
				[Dot42.DexImport("deleteHost", "()V", AccessFlags = 1)]
				public virtual void DeleteHost() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// deleteAllHosts
				/// </java-name>
				[Dot42.DexImport("deleteAllHosts", "()V", AccessFlags = 9)]
				public static void DeleteAllHosts() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// createView
				/// </java-name>
				[Dot42.DexImport("createView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/app" +
    "widget/AppWidgetHostView;", AccessFlags = 17)]
				public global::Android.Appwidget.AppWidgetHostView CreateView(global::Android.Content.Context context, int int32, global::Android.Appwidget.AppWidgetProviderInfo appWidgetProviderInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetHostView);
				}

				/// <java-name>
				/// onCreateView
				/// </java-name>
				[Dot42.DexImport("onCreateView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/app" +
    "widget/AppWidgetHostView;", AccessFlags = 4)]
				protected internal virtual global::Android.Appwidget.AppWidgetHostView OnCreateView(global::Android.Content.Context context, int int32, global::Android.Appwidget.AppWidgetProviderInfo appWidgetProviderInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetHostView);
				}

				/// <java-name>
				/// onProviderChanged
				/// </java-name>
				[Dot42.DexImport("onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", AccessFlags = 4)]
				protected internal virtual void OnProviderChanged(int int32, global::Android.Appwidget.AppWidgetProviderInfo appWidgetProviderInfo) /* MethodBuilder.Create */ 
				{
				}

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

		/// <java-name>
		/// android/appwidget/AppWidgetHostView
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetHostView", AccessFlags = 33)]
		public partial class AppWidgetHostView : global::Android.Widget.FrameLayout
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public AppWidgetHostView(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/content/Context;II)V", AccessFlags = 1)]
				public AppWidgetHostView(global::Android.Content.Context context, int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setAppWidget
				/// </java-name>
				[Dot42.DexImport("setAppWidget", "(ILandroid/appwidget/AppWidgetProviderInfo;)V", AccessFlags = 1)]
				public virtual void SetAppWidget(int int32, global::Android.Appwidget.AppWidgetProviderInfo appWidgetProviderInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getDefaultPaddingForWidget
				/// </java-name>
				[Dot42.DexImport("getDefaultPaddingForWidget", "(Landroid/content/Context;Landroid/content/ComponentName;Landroid/graphics/Rect;)" +
    "Landroid/graphics/Rect;", AccessFlags = 9)]
				public static global::Android.Graphics.Rect GetDefaultPaddingForWidget(global::Android.Content.Context context, global::Android.Content.ComponentName componentName, global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Graphics.Rect);
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
				/// generateLayoutParams
				/// </java-name>
				[Dot42.DexImport("generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", AccessFlags = 1)]
				public override global::Android.Widget.FrameLayout.LayoutParams GenerateLayoutParams(global::Android.Util.IAttributeSet attributeSet) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Widget.FrameLayout.LayoutParams);
				}

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
				protected internal override bool DrawChild(global::Android.Graphics.Canvas canvas, global::Android.Views.View view, long int64) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// prepareView
				/// </java-name>
				[Dot42.DexImport("prepareView", "(Landroid/view/View;)V", AccessFlags = 4)]
				protected internal virtual void PrepareView(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal AppWidgetHostView() /* TypeBuilder.AddDefaultConstructor */ 
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

				/// <java-name>
				/// getDefaultView
				/// </java-name>
				protected internal virtual global::Android.Views.View DefaultView
				{
						[Dot42.DexImport("getDefaultView", "()Landroid/view/View;", AccessFlags = 4)]
						get{ return default(global::Android.Views.View); }
				}

				/// <java-name>
				/// getErrorView
				/// </java-name>
				protected internal virtual global::Android.Views.View ErrorView
				{
						[Dot42.DexImport("getErrorView", "()Landroid/view/View;", AccessFlags = 4)]
						get{ return default(global::Android.Views.View); }
				}

		}

		/// <java-name>
		/// android/appwidget/AppWidgetManager
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetManager", AccessFlags = 33)]
		public partial class AppWidgetManager
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_APPWIDGET_PICK
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_PICK", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_PICK = "android.appwidget.action.APPWIDGET_PICK";
				/// <java-name>
				/// ACTION_APPWIDGET_CONFIGURE
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_CONFIGURE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_CONFIGURE = "android.appwidget.action.APPWIDGET_CONFIGURE";
				/// <java-name>
				/// EXTRA_APPWIDGET_ID
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPWIDGET_ID", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPWIDGET_ID = "appWidgetId";
				/// <java-name>
				/// EXTRA_APPWIDGET_IDS
				/// </java-name>
				[Dot42.DexImport("EXTRA_APPWIDGET_IDS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_APPWIDGET_IDS = "appWidgetIds";
				/// <java-name>
				/// EXTRA_CUSTOM_INFO
				/// </java-name>
				[Dot42.DexImport("EXTRA_CUSTOM_INFO", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CUSTOM_INFO = "customInfo";
				/// <java-name>
				/// EXTRA_CUSTOM_EXTRAS
				/// </java-name>
				[Dot42.DexImport("EXTRA_CUSTOM_EXTRAS", "Ljava/lang/String;", AccessFlags = 25)]
				public const string EXTRA_CUSTOM_EXTRAS = "customExtras";
				/// <java-name>
				/// INVALID_APPWIDGET_ID
				/// </java-name>
				[Dot42.DexImport("INVALID_APPWIDGET_ID", "I", AccessFlags = 25)]
				public const int INVALID_APPWIDGET_ID = 0;
				/// <java-name>
				/// ACTION_APPWIDGET_UPDATE
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_UPDATE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_UPDATE = "android.appwidget.action.APPWIDGET_UPDATE";
				/// <java-name>
				/// ACTION_APPWIDGET_DELETED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_DELETED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_DELETED = "android.appwidget.action.APPWIDGET_DELETED";
				/// <java-name>
				/// ACTION_APPWIDGET_DISABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_DISABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_DISABLED = "android.appwidget.action.APPWIDGET_DISABLED";
				/// <java-name>
				/// ACTION_APPWIDGET_ENABLED
				/// </java-name>
				[Dot42.DexImport("ACTION_APPWIDGET_ENABLED", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_APPWIDGET_ENABLED = "android.appwidget.action.APPWIDGET_ENABLED";
				/// <java-name>
				/// META_DATA_APPWIDGET_PROVIDER
				/// </java-name>
				[Dot42.DexImport("META_DATA_APPWIDGET_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
				public const string META_DATA_APPWIDGET_PROVIDER = "android.appwidget.provider";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AppWidgetManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Landroid/content/Context;)Landroid/appwidget/AppWidgetManager;", AccessFlags = 9)]
				public static global::Android.Appwidget.AppWidgetManager GetInstance(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetManager);
				}

				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "([ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(int[] int32, global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "(ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(int int32, global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// partiallyUpdateAppWidget
				/// </java-name>
				[Dot42.DexImport("partiallyUpdateAppWidget", "([ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void PartiallyUpdateAppWidget(int[] int32, global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// partiallyUpdateAppWidget
				/// </java-name>
				[Dot42.DexImport("partiallyUpdateAppWidget", "(ILandroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void PartiallyUpdateAppWidget(int int32, global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// updateAppWidget
				/// </java-name>
				[Dot42.DexImport("updateAppWidget", "(Landroid/content/ComponentName;Landroid/widget/RemoteViews;)V", AccessFlags = 1)]
				public virtual void UpdateAppWidget(global::Android.Content.ComponentName componentName, global::Android.Widget.RemoteViews remoteViews) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyAppWidgetViewDataChanged
				/// </java-name>
				[Dot42.DexImport("notifyAppWidgetViewDataChanged", "([II)V", AccessFlags = 1)]
				public virtual void NotifyAppWidgetViewDataChanged(int[] int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// notifyAppWidgetViewDataChanged
				/// </java-name>
				[Dot42.DexImport("notifyAppWidgetViewDataChanged", "(II)V", AccessFlags = 1)]
				public virtual void NotifyAppWidgetViewDataChanged(int int32, int int321) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAppWidgetInfo
				/// </java-name>
				[Dot42.DexImport("getAppWidgetInfo", "(I)Landroid/appwidget/AppWidgetProviderInfo;", AccessFlags = 1)]
				public virtual global::Android.Appwidget.AppWidgetProviderInfo GetAppWidgetInfo(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Appwidget.AppWidgetProviderInfo);
				}

				/// <java-name>
				/// bindAppWidgetId
				/// </java-name>
				[Dot42.DexImport("bindAppWidgetId", "(ILandroid/content/ComponentName;)V", AccessFlags = 1)]
				public virtual void BindAppWidgetId(int int32, global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAppWidgetIds
				/// </java-name>
				[Dot42.DexImport("getAppWidgetIds", "(Landroid/content/ComponentName;)[I", AccessFlags = 1)]
				public virtual int[] GetAppWidgetIds(global::Android.Content.ComponentName componentName) /* MethodBuilder.Create */ 
				{
						return default(int[]);
				}

				/// <java-name>
				/// getInstalledProviders
				/// </java-name>
				public virtual global::Java.Util.IList<global::Android.Appwidget.AppWidgetProviderInfo> InstalledProviders
				{
						[Dot42.DexImport("getInstalledProviders", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/appwidget/AppWidgetProviderInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Appwidget.AppWidgetProviderInfo>); }
				}

		}

		/// <java-name>
		/// android/appwidget/AppWidgetProvider
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetProvider", AccessFlags = 33)]
		public partial class AppWidgetProvider : global::Android.Content.BroadcastReceiver
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AppWidgetProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onReceive
				/// </java-name>
				[Dot42.DexImport("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", AccessFlags = 1)]
				public override void OnReceive(global::Android.Content.Context context, global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onUpdate
				/// </java-name>
				[Dot42.DexImport("onUpdate", "(Landroid/content/Context;Landroid/appwidget/AppWidgetManager;[I)V", AccessFlags = 1)]
				public virtual void OnUpdate(global::Android.Content.Context context, global::Android.Appwidget.AppWidgetManager appWidgetManager, int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDeleted
				/// </java-name>
				[Dot42.DexImport("onDeleted", "(Landroid/content/Context;[I)V", AccessFlags = 1)]
				public virtual void OnDeleted(global::Android.Content.Context context, int[] int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onEnabled
				/// </java-name>
				[Dot42.DexImport("onEnabled", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void OnEnabled(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// onDisabled
				/// </java-name>
				[Dot42.DexImport("onDisabled", "(Landroid/content/Context;)V", AccessFlags = 1)]
				public virtual void OnDisabled(global::Android.Content.Context context) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// android/appwidget/AppWidgetProviderInfo
		/// </java-name>
		[Dot42.DexImport("android/appwidget/AppWidgetProviderInfo", AccessFlags = 33)]
		public partial class AppWidgetProviderInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// RESIZE_NONE
				/// </java-name>
				[Dot42.DexImport("RESIZE_NONE", "I", AccessFlags = 25)]
				public const int RESIZE_NONE = 0;
				/// <java-name>
				/// RESIZE_HORIZONTAL
				/// </java-name>
				[Dot42.DexImport("RESIZE_HORIZONTAL", "I", AccessFlags = 25)]
				public const int RESIZE_HORIZONTAL = 1;
				/// <java-name>
				/// RESIZE_VERTICAL
				/// </java-name>
				[Dot42.DexImport("RESIZE_VERTICAL", "I", AccessFlags = 25)]
				public const int RESIZE_VERTICAL = 2;
				/// <java-name>
				/// RESIZE_BOTH
				/// </java-name>
				[Dot42.DexImport("RESIZE_BOTH", "I", AccessFlags = 25)]
				public const int RESIZE_BOTH = 3;
				/// <java-name>
				/// provider
				/// </java-name>
				[Dot42.DexImport("provider", "Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName Provider;
				/// <java-name>
				/// minWidth
				/// </java-name>
				[Dot42.DexImport("minWidth", "I", AccessFlags = 1)]
				public int MinWidth;
				/// <java-name>
				/// minHeight
				/// </java-name>
				[Dot42.DexImport("minHeight", "I", AccessFlags = 1)]
				public int MinHeight;
				/// <java-name>
				/// minResizeWidth
				/// </java-name>
				[Dot42.DexImport("minResizeWidth", "I", AccessFlags = 1)]
				public int MinResizeWidth;
				/// <java-name>
				/// minResizeHeight
				/// </java-name>
				[Dot42.DexImport("minResizeHeight", "I", AccessFlags = 1)]
				public int MinResizeHeight;
				/// <java-name>
				/// updatePeriodMillis
				/// </java-name>
				[Dot42.DexImport("updatePeriodMillis", "I", AccessFlags = 1)]
				public int UpdatePeriodMillis;
				/// <java-name>
				/// initialLayout
				/// </java-name>
				[Dot42.DexImport("initialLayout", "I", AccessFlags = 1)]
				public int InitialLayout;
				/// <java-name>
				/// configure
				/// </java-name>
				[Dot42.DexImport("configure", "Landroid/content/ComponentName;", AccessFlags = 1)]
				public global::Android.Content.ComponentName Configure;
				/// <java-name>
				/// label
				/// </java-name>
				[Dot42.DexImport("label", "Ljava/lang/String;", AccessFlags = 1)]
				public string Label;
				/// <java-name>
				/// icon
				/// </java-name>
				[Dot42.DexImport("icon", "I", AccessFlags = 1)]
				public int Icon;
				/// <java-name>
				/// autoAdvanceViewId
				/// </java-name>
				[Dot42.DexImport("autoAdvanceViewId", "I", AccessFlags = 1)]
				public int AutoAdvanceViewId;
				/// <java-name>
				/// previewImage
				/// </java-name>
				[Dot42.DexImport("previewImage", "I", AccessFlags = 1)]
				public int PreviewImage;
				/// <java-name>
				/// resizeMode
				/// </java-name>
				[Dot42.DexImport("resizeMode", "I", AccessFlags = 1)]
				public int ResizeMode;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Appwidget.AppWidgetProviderInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AppWidgetProviderInfo() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public AppWidgetProviderInfo(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
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

