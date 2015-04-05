#pragma warning disable 1717
namespace Android.Views.Accessibility
{
		/// <java-name>
		/// android/view/accessibility/AccessibilityEvent
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityEvent", AccessFlags = 49)]
		public sealed partial class AccessibilityEvent : global::Android.Views.Accessibility.AccessibilityRecord, global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// INVALID_POSITION
				/// </java-name>
				[Dot42.DexImport("INVALID_POSITION", "I", AccessFlags = 25)]
				public const int INVALID_POSITION = -1;
				/// <java-name>
				/// MAX_TEXT_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_TEXT_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_TEXT_LENGTH = 500;
				/// <java-name>
				/// TYPE_VIEW_CLICKED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_CLICKED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_CLICKED = 1;
				/// <java-name>
				/// TYPE_VIEW_LONG_CLICKED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_LONG_CLICKED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_LONG_CLICKED = 2;
				/// <java-name>
				/// TYPE_VIEW_SELECTED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_SELECTED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_SELECTED = 4;
				/// <java-name>
				/// TYPE_VIEW_FOCUSED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_FOCUSED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_FOCUSED = 8;
				/// <java-name>
				/// TYPE_VIEW_TEXT_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_TEXT_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_TEXT_CHANGED = 16;
				/// <java-name>
				/// TYPE_WINDOW_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_WINDOW_STATE_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_WINDOW_STATE_CHANGED = 32;
				/// <java-name>
				/// TYPE_NOTIFICATION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_NOTIFICATION_STATE_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_NOTIFICATION_STATE_CHANGED = 64;
				/// <java-name>
				/// TYPE_VIEW_HOVER_ENTER
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_HOVER_ENTER", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_HOVER_ENTER = 128;
				/// <java-name>
				/// TYPE_VIEW_HOVER_EXIT
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_HOVER_EXIT", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_HOVER_EXIT = 256;
				/// <java-name>
				/// TYPE_TOUCH_EXPLORATION_GESTURE_START
				/// </java-name>
				[Dot42.DexImport("TYPE_TOUCH_EXPLORATION_GESTURE_START", "I", AccessFlags = 25)]
				public const int TYPE_TOUCH_EXPLORATION_GESTURE_START = 512;
				/// <java-name>
				/// TYPE_TOUCH_EXPLORATION_GESTURE_END
				/// </java-name>
				[Dot42.DexImport("TYPE_TOUCH_EXPLORATION_GESTURE_END", "I", AccessFlags = 25)]
				public const int TYPE_TOUCH_EXPLORATION_GESTURE_END = 1024;
				/// <java-name>
				/// TYPE_WINDOW_CONTENT_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_WINDOW_CONTENT_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_WINDOW_CONTENT_CHANGED = 2048;
				/// <java-name>
				/// TYPE_VIEW_SCROLLED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_SCROLLED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_SCROLLED = 4096;
				/// <java-name>
				/// TYPE_VIEW_TEXT_SELECTION_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_TEXT_SELECTION_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_TEXT_SELECTION_CHANGED = 8192;
				/// <java-name>
				/// TYPES_ALL_MASK
				/// </java-name>
				[Dot42.DexImport("TYPES_ALL_MASK", "I", AccessFlags = 25)]
				public const int TYPES_ALL_MASK = -1;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Accessibility.AccessibilityEvent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityEvent() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// appendRecord
				/// </java-name>
				[Dot42.DexImport("appendRecord", "(Landroid/view/accessibility/AccessibilityRecord;)V", AccessFlags = 1)]
				public void AppendRecord(global::Android.Views.Accessibility.AccessibilityRecord accessibilityRecord) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRecord
				/// </java-name>
				[Dot42.DexImport("getRecord", "(I)Landroid/view/accessibility/AccessibilityRecord;", AccessFlags = 1)]
				public global::Android.Views.Accessibility.AccessibilityRecord GetRecord(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityRecord);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityEvent Obtain(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityEvent;)Landroid/view/accessibility/Acce" +
    "ssibilityEvent;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityEvent Obtain(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityEvent);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityEvent;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityEvent Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityEvent);
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public override void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// initFromParcel
				/// </java-name>
				[Dot42.DexImport("initFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public void InitFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
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
				/// eventTypeToString
				/// </java-name>
				[Dot42.DexImport("eventTypeToString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string EventTypeToString(int int32) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getRecordCount
				/// </java-name>
				public int RecordCount
				{
						[Dot42.DexImport("getRecordCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getEventType
				/// </java-name>
				public int EventType
				{
						[Dot42.DexImport("getEventType", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setEventType", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getEventTime
				/// </java-name>
				public long EventTime
				{
						[Dot42.DexImport("getEventTime", "()J", AccessFlags = 1)]
						get{ return default(long); }
						[Dot42.DexImport("setEventTime", "(J)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public global::Java.Lang.ICharSequence PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setPackageName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/view/accessibility/AccessibilityManager
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityManager", AccessFlags = 49)]
		public sealed partial class AccessibilityManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public void SendAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// interrupt
				/// </java-name>
				[Dot42.DexImport("interrupt", "()V", AccessFlags = 1)]
				public void Interrupt() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEnabledAccessibilityServiceList
				/// </java-name>
				[Dot42.DexImport("getEnabledAccessibilityServiceList", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/accessibilityservice/AccessibilityServiceInfo;>;")]
				public global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo> GetEnabledAccessibilityServiceList(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo>);
				}

				/// <java-name>
				/// addAccessibilityStateChangeListener
				/// </java-name>
				[Dot42.DexImport("addAccessibilityStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityStateChangeListene" +
    "r;)Z", AccessFlags = 1)]
				public bool AddAccessibilityStateChangeListener(global::Android.Views.Accessibility.AccessibilityManager.IAccessibilityStateChangeListener accessibilityStateChangeListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeAccessibilityStateChangeListener
				/// </java-name>
				[Dot42.DexImport("removeAccessibilityStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityStateChangeListene" +
    "r;)Z", AccessFlags = 1)]
				public bool RemoveAccessibilityStateChangeListener(global::Android.Views.Accessibility.AccessibilityManager.IAccessibilityStateChangeListener accessibilityStateChangeListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isTouchExplorationEnabled
				/// </java-name>
				public bool IsTouchExplorationEnabled
				{
						[Dot42.DexImport("isTouchExplorationEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getAccessibilityServiceList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Content.Pm.ServiceInfo> AccessibilityServiceList
				{
						[Dot42.DexImport("getAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/pm/ServiceInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Content.Pm.ServiceInfo>); }
				}

				/// <java-name>
				/// getInstalledAccessibilityServiceList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo> InstalledAccessibilityServiceList
				{
						[Dot42.DexImport("getInstalledAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/accessibilityservice/AccessibilityServiceInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo>); }
				}

				/// <java-name>
				/// android/view/accessibility/AccessibilityManager$AccessibilityStateChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/accessibility/AccessibilityManager$AccessibilityStateChangeListener", AccessFlags = 1545)]
				public partial interface IAccessibilityStateChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onAccessibilityStateChanged
						/// </java-name>
						[Dot42.DexImport("onAccessibilityStateChanged", "(Z)V", AccessFlags = 1025)]
						void OnAccessibilityStateChanged(bool boolean) /* MethodBuilder.Create */ ;

				}

		}

		/// <java-name>
		/// android/view/accessibility/AccessibilityNodeInfo
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityNodeInfo", AccessFlags = 33)]
		public partial class AccessibilityNodeInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// ACTION_FOCUS
				/// </java-name>
				[Dot42.DexImport("ACTION_FOCUS", "I", AccessFlags = 25)]
				public const int ACTION_FOCUS = 1;
				/// <java-name>
				/// ACTION_CLEAR_FOCUS
				/// </java-name>
				[Dot42.DexImport("ACTION_CLEAR_FOCUS", "I", AccessFlags = 25)]
				public const int ACTION_CLEAR_FOCUS = 2;
				/// <java-name>
				/// ACTION_SELECT
				/// </java-name>
				[Dot42.DexImport("ACTION_SELECT", "I", AccessFlags = 25)]
				public const int ACTION_SELECT = 4;
				/// <java-name>
				/// ACTION_CLEAR_SELECTION
				/// </java-name>
				[Dot42.DexImport("ACTION_CLEAR_SELECTION", "I", AccessFlags = 25)]
				public const int ACTION_CLEAR_SELECTION = 8;
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Accessibility.AccessibilityNodeInfo> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityNodeInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetSource(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.Views.Accessibility.AccessibilityNodeInfo GetChild(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// addChild
				/// </java-name>
				[Dot42.DexImport("addChild", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddChild(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addAction
				/// </java-name>
				[Dot42.DexImport("addAction", "(I)V", AccessFlags = 1)]
				public virtual void AddAction(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// performAction
				/// </java-name>
				[Dot42.DexImport("performAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformAction(int int32) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// findAccessibilityNodeInfosByText
				/// </java-name>
				[Dot42.DexImport("findAccessibilityNodeInfosByText", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/List<Landroid/view/accessibility/AccessibilityNode" +
    "Info;>;")]
				public virtual global::Java.Util.IList<global::Android.Views.Accessibility.AccessibilityNodeInfo> FindAccessibilityNodeInfosByText(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Views.Accessibility.AccessibilityNodeInfo>);
				}

				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetParent(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBoundsInParent
				/// </java-name>
				[Dot42.DexImport("getBoundsInParent", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetBoundsInParent(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBoundsInParent
				/// </java-name>
				[Dot42.DexImport("setBoundsInParent", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetBoundsInParent(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getBoundsInScreen
				/// </java-name>
				[Dot42.DexImport("getBoundsInScreen", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetBoundsInScreen(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setBoundsInScreen
				/// </java-name>
				[Dot42.DexImport("setBoundsInScreen", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetBoundsInScreen(global::Android.Graphics.Rect rect) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setCheckable
				/// </java-name>
				[Dot42.DexImport("setCheckable", "(Z)V", AccessFlags = 1)]
				public virtual void SetCheckable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChecked(bool boolean) /* MethodBuilder.Create */ 
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
				/// setFocused
				/// </java-name>
				[Dot42.DexImport("setFocused", "(Z)V", AccessFlags = 1)]
				public virtual void SetFocused(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSelected
				/// </java-name>
				[Dot42.DexImport("setSelected", "(Z)V", AccessFlags = 1)]
				public virtual void SetSelected(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setClickable
				/// </java-name>
				[Dot42.DexImport("setClickable", "(Z)V", AccessFlags = 1)]
				public virtual void SetClickable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setLongClickable
				/// </java-name>
				[Dot42.DexImport("setLongClickable", "(Z)V", AccessFlags = 1)]
				public virtual void SetLongClickable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Z)V", AccessFlags = 1)]
				public virtual void SetPassword(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScrollable
				/// </java-name>
				[Dot42.DexImport("setScrollable", "(Z)V", AccessFlags = 1)]
				public virtual void SetScrollable(bool boolean) /* MethodBuilder.Create */ 
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
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/View;)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityNodeInfo Obtain(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityNodeInfo Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityNodeInfo;)Landroid/view/accessibility/A" +
    "ccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityNodeInfo Obtain(global::Android.Views.Accessibility.AccessibilityNodeInfo accessibilityNodeInfo) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityNodeInfo);
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public virtual void Recycle() /* MethodBuilder.Create */ 
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getWindowId
				/// </java-name>
				public virtual int WindowId
				{
						[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
						get{ return default(int); }
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
				/// getActions
				/// </java-name>
				public virtual int Actions
				{
						[Dot42.DexImport("getActions", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				public virtual global::Android.Views.Accessibility.AccessibilityNodeInfo Parent
				{
						[Dot42.DexImport("getParent", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Accessibility.AccessibilityNodeInfo); }
				}

				/// <java-name>
				/// isCheckable
				/// </java-name>
				public virtual bool IsCheckable
				{
						[Dot42.DexImport("isCheckable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isChecked
				/// </java-name>
				public virtual bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isFocusable
				/// </java-name>
				public virtual bool IsFocusable
				{
						[Dot42.DexImport("isFocusable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
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
				/// isSelected
				/// </java-name>
				public virtual bool IsSelected
				{
						[Dot42.DexImport("isSelected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isClickable
				/// </java-name>
				public virtual bool IsClickable
				{
						[Dot42.DexImport("isClickable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isLongClickable
				/// </java-name>
				public virtual bool IsLongClickable
				{
						[Dot42.DexImport("isLongClickable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public virtual bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isPassword
				/// </java-name>
				public virtual bool IsPassword
				{
						[Dot42.DexImport("isPassword", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isScrollable
				/// </java-name>
				public virtual bool IsScrollable
				{
						[Dot42.DexImport("isScrollable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getPackageName
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence PackageName
				{
						[Dot42.DexImport("getPackageName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setPackageName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getClassName
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence ClassName
				{
						[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getText
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence Text
				{
						[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
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

		}

		/// <java-name>
		/// android/view/accessibility/AccessibilityRecord
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityRecord", AccessFlags = 33)]
		public partial class AccessibilityRecord
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityRecord() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetSource(global::Android.Views.View view) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChecked(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnabled(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Z)V", AccessFlags = 1)]
				public virtual void SetPassword(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setFullScreen
				/// </java-name>
				[Dot42.DexImport("setFullScreen", "(Z)V", AccessFlags = 1)]
				public virtual void SetFullScreen(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setScrollable
				/// </java-name>
				[Dot42.DexImport("setScrollable", "(Z)V", AccessFlags = 1)]
				public virtual void SetScrollable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityRecord;)Landroid/view/accessibility/Acc" +
    "essibilityRecord;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityRecord Obtain(global::Android.Views.Accessibility.AccessibilityRecord accessibilityRecord) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityRecord);
				}

				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityRecord;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityRecord Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityRecord);
				}

				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public virtual void Recycle() /* MethodBuilder.Create */ 
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
				/// getSource
				/// </java-name>
				public virtual global::Android.Views.Accessibility.AccessibilityNodeInfo Source
				{
						[Dot42.DexImport("getSource", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Accessibility.AccessibilityNodeInfo); }
				}

				/// <java-name>
				/// getWindowId
				/// </java-name>
				public virtual int WindowId
				{
						[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// isChecked
				/// </java-name>
				public virtual bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public virtual bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isPassword
				/// </java-name>
				public virtual bool IsPassword
				{
						[Dot42.DexImport("isPassword", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isFullScreen
				/// </java-name>
				public virtual bool IsFullScreen
				{
						[Dot42.DexImport("isFullScreen", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// isScrollable
				/// </java-name>
				public virtual bool IsScrollable
				{
						[Dot42.DexImport("isScrollable", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <java-name>
				/// getItemCount
				/// </java-name>
				public virtual int ItemCount
				{
						[Dot42.DexImport("getItemCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setItemCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrentItemIndex
				/// </java-name>
				public virtual int CurrentItemIndex
				{
						[Dot42.DexImport("getCurrentItemIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCurrentItemIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFromIndex
				/// </java-name>
				public virtual int FromIndex
				{
						[Dot42.DexImport("getFromIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setFromIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getToIndex
				/// </java-name>
				public virtual int ToIndex
				{
						[Dot42.DexImport("getToIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setToIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getScrollX
				/// </java-name>
				public virtual int ScrollX
				{
						[Dot42.DexImport("getScrollX", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setScrollX", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getScrollY
				/// </java-name>
				public virtual int ScrollY
				{
						[Dot42.DexImport("getScrollY", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setScrollY", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMaxScrollX
				/// </java-name>
				public virtual int MaxScrollX
				{
						[Dot42.DexImport("getMaxScrollX", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMaxScrollX", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getMaxScrollY
				/// </java-name>
				public virtual int MaxScrollY
				{
						[Dot42.DexImport("getMaxScrollY", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMaxScrollY", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAddedCount
				/// </java-name>
				public virtual int AddedCount
				{
						[Dot42.DexImport("getAddedCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setAddedCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRemovedCount
				/// </java-name>
				public virtual int RemovedCount
				{
						[Dot42.DexImport("getRemovedCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRemovedCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getClassName
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence ClassName
				{
						[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getText
				/// </java-name>
				public virtual global::Java.Util.IList<global::Java.Lang.ICharSequence> Text
				{
						[Dot42.DexImport("getText", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/CharSequence;>;")]
						get{ return default(global::Java.Util.IList<global::Java.Lang.ICharSequence>); }
				}

				/// <java-name>
				/// getBeforeText
				/// </java-name>
				public virtual global::Java.Lang.ICharSequence BeforeText
				{
						[Dot42.DexImport("getBeforeText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setBeforeText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
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
				/// getParcelableData
				/// </java-name>
				public virtual global::Android.OS.IParcelable ParcelableData
				{
						[Dot42.DexImport("getParcelableData", "()Landroid/os/Parcelable;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IParcelable); }
						[Dot42.DexImport("setParcelableData", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// android/view/accessibility/AccessibilityEventSource
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityEventSource", AccessFlags = 1537)]
		public partial interface IAccessibilityEventSource
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1025)]
				void SendAccessibilityEvent(int int32) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// sendAccessibilityEventUnchecked
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1025)]
				void SendAccessibilityEventUnchecked(global::Android.Views.Accessibility.AccessibilityEvent accessibilityEvent) /* MethodBuilder.Create */ ;

		}

}

