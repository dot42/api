#pragma warning disable 1717
namespace Android.AccessibilityServices
{
		/// <summary>
		///  <para>An accessibility service runs in the background and receives callbacks by the system when AccessibilityEvents are fired. Such events denote some state transition in the user interface, for example, the focus has changed, a button has been clicked, etc. Such a service can optionally request the capability for querying the content of the active window. Development of an accessibility service requires extending this class and implementing its abstract methods.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating AccessibilityServices, read the  developer guide.</para> <para> </para> <para> <h3>Lifecycle</h3></para> <para>The lifecycle of an accessibility service is managed exclusively by the system and follows the established service life cycle. Additionally, starting or stopping an accessibility service is triggered exclusively by an explicit user action through enabling or disabling it in the device settings. After the system binds to a service it calls AccessibilityService#onServiceConnected(). This method can be overriden by clients that want to perform post binding setup. </para> <para> <h3>Declaration</h3></para> <para>An accessibility is declared as any other service in an AndroidManifest.xml but it must also specify that it handles the "android.accessibilityservice.AccessibilityService" android.content.Intent. Failure to declare this intent will cause the system to ignore the accessibility service. Additionally an accessibility service must request the android.Manifest.permission#BIND_ACCESSIBILITY_SERVICE permission to ensure that only the system can bind to it. Failure to declare this intent will cause the system to ignore the accessibility service. Following is an example declaration: </para> <para> <pre> &lt;service android:name=".MyAccessibilityService"
		///         android:permission="android.permission.BIND_ACCESSIBILITY_SERVICE"&gt;
		///     &lt;intent-filter&gt;
		///         &lt;action android:name="android.accessibilityservice.AccessibilityService" /&gt;
		///     &lt;/intent-filter&gt;
		///     . . .
		/// &lt;/service&gt;</pre>  <h3>Configuration</h3></para> <para>An accessibility service can be configured to receive specific types of accessibility events, listen only to specific packages, get events from each type only once in a given time frame, retrieve window content, specify a settings activity, etc. </para> <para>There are two approaches for configuring an accessibility service: </para> <para> <ul> <li> <para>Providing a meta-data entry in the manifest when declaring the service. A service declaration with a meta-data tag is presented below:  <pre> &lt;service android:name=".MyAccessibilityService"&gt;
		///     &lt;intent-filter&gt;
		///         &lt;action android:name="android.accessibilityservice.AccessibilityService" /&gt;
		///     &lt;/intent-filter&gt;
		///     &lt;meta-data android:name="android.accessibilityservice" android:resource="@xml/accessibilityservice" /&gt;
		/// &lt;/service&gt;</pre> </para> <para> <b>Note:</b> This approach enables setting all properties. </para> <para></para> <para>For more details refer to SERVICE_META_DATA and  <code>&lt;accessibility-service&gt;</code>. </para> <para></para></li> <li> <para>Calling AccessibilityService#setServiceInfo(AccessibilityServiceInfo). Note that this method can be called any time to dynamically change the service configuration. </para> <para> <b>Note:</b> This approach enables setting only dynamically configurable properties: AccessibilityServiceInfo#eventTypes, AccessibilityServiceInfo#feedbackType, AccessibilityServiceInfo#flags, AccessibilityServiceInfo#notificationTimeout, AccessibilityServiceInfo#packageNames </para> <para></para> <para>For more details refer to AccessibilityServiceInfo. </para> <para></para></li></ul> <h3>Retrieving window content</h3></para> <para>A service can specify in its declaration that it can retrieve the active window content which is represented as a tree of AccessibilityNodeInfo. Note that declaring this capability requires that the service declares its configuration via an XML resource referenced by SERVICE_META_DATA. </para> <para>For security purposes an accessibility service can retrieve only the content of the currently active window. The currently active window is defined as the window from which was fired the last event of the following types: AccessibilityEvent#TYPE_WINDOW_STATE_CHANGED, AccessibilityEvent#TYPE_VIEW_HOVER_ENTER, AccessibilityEvent#TYPE_VIEW_HOVER_EXIT, In other words, the last window that was shown or the last window that the user has touched during touch exploration. </para> <para>The entry point for retrieving window content is through calling AccessibilityEvent.getSource() of the last received event of the above types or a previous event from the same window (see AccessibilityEvent.getWindowId()). Invoking this method will return an AccessibilityNodeInfo that can be used to traverse the window content which represented as a tree of such objects. </para> <para> <b>Note</b> An accessibility service may have requested to be notified for a subset of the event types, thus be unaware that the active window has changed. Therefore accessibility service that would like to retrieve window content should:  <ul> <li> <para>Register for all event types with no notification timeout and keep track for the active window by calling AccessibilityEvent#getWindowId() of the last received event and compare this with the AccessibilityNodeInfo#getWindowId() before calling retrieval methods on the latter.  </para></li> <li> <para>Prepare that a retrieval method on AccessibilityNodeInfo may fail since the active window has changed and the service did not get the accessibility event yet. Note that it is possible to have a retrieval method failing even adopting the strategy specified in the previous bullet because the accessibility event dispatch is asynchronous and crosses process boundaries.  </para></li></ul></para> <para> <h3>Notification strategy</h3></para> <para>For each feedback type only one accessibility service is notified. Services are notified in the order of registration. Hence, if two services are registered for the same feedback type in the same package the first one wins. It is possible however, to register a service as the default one for a given feedback type. In such a case this service is invoked if no other service was interested in the event. In other words, default services do not compete with other services and are notified last regardless of the registration order. This enables "generic" accessibility services that work reasonably well with most applications to coexist with "polished" ones that are targeted for specific applications. </para> <para> <b>Note:</b> The event notification timeout is useful to avoid propagating events to the client too frequently since this is accomplished via an expensive interprocess call. One can think of the timeout as a criteria to determine when event generation has settled down.</para> <para> <h3>Event types</h3></para> <para> <ul> <li> <para>AccessibilityEvent#TYPE_VIEW_CLICKED </para></li> <li> <para>AccessibilityEvent#TYPE_VIEW_LONG_CLICKED </para></li> <li> <para>AccessibilityEvent#TYPE_VIEW_FOCUSED </para></li> <li> <para>AccessibilityEvent#TYPE_VIEW_SELECTED </para></li> <li> <para>AccessibilityEvent#TYPE_VIEW_TEXT_CHANGED </para></li> <li> <para>AccessibilityEvent#TYPE_WINDOW_STATE_CHANGED </para></li> <li> <para>AccessibilityEvent#TYPE_NOTIFICATION_STATE_CHANGED </para></li> <li> <para>AccessibilityEvent#TYPE_TOUCH_EXPLORATION_GESTURE_START </para></li> <li> <para>AccessibilityEvent#TYPE_TOUCH_EXPLORATION_GESTURE_END </para></li> <li> <para>AccessibilityEvent#TYPE_VIEW_HOVER_ENTER </para></li> <li> <para>AccessibilityEvent#TYPE_VIEW_HOVER_EXIT </para></li> <li> <para>AccessibilityEvent#TYPE_VIEW_SCROLLED </para></li> <li> <para>AccessibilityEvent#TYPE_VIEW_TEXT_SELECTION_CHANGED </para></li> <li> <para>AccessibilityEvent#TYPE_WINDOW_CONTENT_CHANGED </para></li></ul> <h3>Feedback types</h3></para> <para> <ul> <li> <para>AccessibilityServiceInfo#FEEDBACK_AUDIBLE </para></li> <li> <para>AccessibilityServiceInfo#FEEDBACK_HAPTIC </para></li> <li> <para>AccessibilityServiceInfo#FEEDBACK_AUDIBLE </para></li> <li> <para>AccessibilityServiceInfo#FEEDBACK_VISUAL </para></li> <li> <para>AccessibilityServiceInfo#FEEDBACK_GENERIC </para></li></ul> <para>AccessibilityEvent </para> <para>AccessibilityServiceInfo </para> <para>android.view.accessibility.AccessibilityManager </para></para>    
		/// </summary>
		/// <java-name>
		/// android/accessibilityservice/AccessibilityService
		/// </java-name>
		[Dot42.DexImport("android/accessibilityservice/AccessibilityService", AccessFlags = 1057)]
		public abstract partial class AccessibilityService : global::Android.App.Service
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>The user has performed a swipe up gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_UP
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_UP", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_UP = 1;
				/// <summary>
				///  <para>The user has performed a swipe down gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_DOWN
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_DOWN", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_DOWN = 2;
				/// <summary>
				///  <para>The user has performed a swipe left gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_LEFT
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_LEFT", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_LEFT = 3;
				/// <summary>
				///  <para>The user has performed a swipe right gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_RIGHT
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_RIGHT", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_RIGHT = 4;
				/// <summary>
				///  <para>The user has performed a swipe left and right gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_LEFT_AND_RIGHT
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_LEFT_AND_RIGHT", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_LEFT_AND_RIGHT = 5;
				/// <summary>
				///  <para>The user has performed a swipe right and left gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_RIGHT_AND_LEFT
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_RIGHT_AND_LEFT", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_RIGHT_AND_LEFT = 6;
				/// <summary>
				///  <para>The user has performed a swipe up and down gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_UP_AND_DOWN
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_UP_AND_DOWN", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_UP_AND_DOWN = 7;
				/// <summary>
				///  <para>The user has performed a swipe down and up gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_DOWN_AND_UP
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_DOWN_AND_UP", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_DOWN_AND_UP = 8;
				/// <summary>
				///  <para>The user has performed a left and up gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_LEFT_AND_UP
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_LEFT_AND_UP", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_LEFT_AND_UP = 9;
				/// <summary>
				///  <para>The user has performed a left and down gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_LEFT_AND_DOWN
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_LEFT_AND_DOWN", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_LEFT_AND_DOWN = 10;
				/// <summary>
				///  <para>The user has performed a right and up gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_RIGHT_AND_UP
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_RIGHT_AND_UP", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_RIGHT_AND_UP = 11;
				/// <summary>
				///  <para>The user has performed a right and down gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_RIGHT_AND_DOWN
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_RIGHT_AND_DOWN", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_RIGHT_AND_DOWN = 12;
				/// <summary>
				///  <para>The user has performed an up and left gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_UP_AND_LEFT
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_UP_AND_LEFT", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_UP_AND_LEFT = 13;
				/// <summary>
				///  <para>The user has performed an up and right gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_UP_AND_RIGHT
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_UP_AND_RIGHT", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_UP_AND_RIGHT = 14;
				/// <summary>
				///  <para>The user has performed an down and left gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_DOWN_AND_LEFT
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_DOWN_AND_LEFT", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_DOWN_AND_LEFT = 15;
				/// <summary>
				///  <para>The user has performed an down and right gesture on the touch screen. </para>        
				/// </summary>
				/// <java-name>
				/// GESTURE_SWIPE_DOWN_AND_RIGHT
				/// </java-name>
				[Dot42.DexImport("GESTURE_SWIPE_DOWN_AND_RIGHT", "I", AccessFlags = 25)]
				public const int GESTURE_SWIPE_DOWN_AND_RIGHT = 16;
				/// <summary>
				///  <para>The Intent that must be declared as handled by the service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.accessibilityservice.AccessibilityService";
				/// <summary>
				///  <para>Name under which an AccessibilityService component publishes information about itself. This meta-data must reference an XML resource containing an  <code>&lt;accessibility-service&gt;</code> tag. This is a a sample XML file configuring an accessibility service:  <pre> &lt;accessibility-service
				///     android:accessibilityEventTypes="typeViewClicked|typeViewFocused"
				///     android:packageNames="foo.bar, foo.baz"
				///     android:accessibilityFeedbackType="feedbackSpoken"
				///     android:notificationTimeout="100"
				///     android:accessibilityFlags="flagDefault"
				///     android:settingsActivity="foo.bar.TestBackActivity"
				///     android:canRetrieveWindowContent="true"
				///     android:canRequestTouchExplorationMode="true"
				///     android:canRequestEnhancedWebAccessibility="true"
				///     . . .
				/// /&gt;</pre> </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_META_DATA
				/// </java-name>
				[Dot42.DexImport("SERVICE_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_META_DATA = "android.accessibilityservice";
				/// <summary>
				///  <para>Action to go back. </para>        
				/// </summary>
				/// <java-name>
				/// GLOBAL_ACTION_BACK
				/// </java-name>
				[Dot42.DexImport("GLOBAL_ACTION_BACK", "I", AccessFlags = 25)]
				public const int GLOBAL_ACTION_BACK = 1;
				/// <summary>
				///  <para>Action to go home. </para>        
				/// </summary>
				/// <java-name>
				/// GLOBAL_ACTION_HOME
				/// </java-name>
				[Dot42.DexImport("GLOBAL_ACTION_HOME", "I", AccessFlags = 25)]
				public const int GLOBAL_ACTION_HOME = 2;
				/// <summary>
				///  <para>Action to open the recent apps. </para>        
				/// </summary>
				/// <java-name>
				/// GLOBAL_ACTION_RECENTS
				/// </java-name>
				[Dot42.DexImport("GLOBAL_ACTION_RECENTS", "I", AccessFlags = 25)]
				public const int GLOBAL_ACTION_RECENTS = 3;
				/// <summary>
				///  <para>Action to open the notifications. </para>        
				/// </summary>
				/// <java-name>
				/// GLOBAL_ACTION_NOTIFICATIONS
				/// </java-name>
				[Dot42.DexImport("GLOBAL_ACTION_NOTIFICATIONS", "I", AccessFlags = 25)]
				public const int GLOBAL_ACTION_NOTIFICATIONS = 4;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccessibilityService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Callback for android.view.accessibility.AccessibilityEvents.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// onAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("onAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1025)]
				public abstract void OnAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Callback for interrupting the accessibility feedback. </para>        
				/// </summary>
				/// <java-name>
				/// onInterrupt
				/// </java-name>
				[Dot42.DexImport("onInterrupt", "()V", AccessFlags = 1025)]
				public abstract void OnInterrupt() /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>This method is a part of the AccessibilityService lifecycle and is called after the system has successfully bound to the service. If is convenient to use this method for setting the AccessibilityServiceInfo.</para> <para> <para>AccessibilityServiceInfo </para> <para>setServiceInfo(AccessibilityServiceInfo) </para></para>        
				/// </summary>
				/// <java-name>
				/// onServiceConnected
				/// </java-name>
				[Dot42.DexImport("onServiceConnected", "()V", AccessFlags = 4)]
				protected internal virtual void OnServiceConnected() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Called by the system when the user performs a specific gesture on the touch screen.</para> <para> <b>Note:</b> To receive gestures an accessibility service must request that the device is in touch exploration mode by setting the android.accessibilityservice.AccessibilityServiceInfo#FLAG_REQUEST_TOUCH_EXPLORATION_MODE flag.</para> <para> <para>GESTURE_SWIPE_UP </para> <para>GESTURE_SWIPE_UP_AND_LEFT </para> <para>GESTURE_SWIPE_UP_AND_DOWN </para> <para>GESTURE_SWIPE_UP_AND_RIGHT </para> <para>GESTURE_SWIPE_DOWN </para> <para>GESTURE_SWIPE_DOWN_AND_LEFT </para> <para>GESTURE_SWIPE_DOWN_AND_UP </para> <para>GESTURE_SWIPE_DOWN_AND_RIGHT </para> <para>GESTURE_SWIPE_LEFT </para> <para>GESTURE_SWIPE_LEFT_AND_UP </para> <para>GESTURE_SWIPE_LEFT_AND_RIGHT </para> <para>GESTURE_SWIPE_LEFT_AND_DOWN </para> <para>GESTURE_SWIPE_RIGHT </para> <para>GESTURE_SWIPE_RIGHT_AND_UP </para> <para>GESTURE_SWIPE_RIGHT_AND_LEFT </para> <para>GESTURE_SWIPE_RIGHT_AND_DOWN </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the gesture was handled.</para>
				/// </returns>
				/// <java-name>
				/// onGesture
				/// </java-name>
				[Dot42.DexImport("onGesture", "(I)Z", AccessFlags = 4)]
				protected internal virtual bool OnGesture(int gestureId) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Performs a global action. Such an action can be performed at any moment regardless of the current application or user location in that application. For example going back, going home, opening recents, etc.</para> <para> <para>GLOBAL_ACTION_BACK </para> <para>GLOBAL_ACTION_HOME </para> <para>GLOBAL_ACTION_NOTIFICATIONS </para> <para>GLOBAL_ACTION_RECENTS </para></para>        
				/// </summary>
				/// <returns>
				///  <para>Whether the action was successfully performed.</para>
				/// </returns>
				/// <java-name>
				/// performGlobalAction
				/// </java-name>
				[Dot42.DexImport("performGlobalAction", "(I)Z", AccessFlags = 17)]
				public bool PerformGlobalAction(int action) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				///  <para>Implement to return the implementation of the internal accessibility service interface. </para>        
				/// </summary>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.OS.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.OS.IBinder);
				}

				/// <summary>
				///  <para>Gets the root node in the currently active window if this service can retrieve window content.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The root node if this service can retrieve window content. </para>
				/// </returns>
				/// <java-name>
				/// getRootInActiveWindow
				/// </java-name>
				public virtual global::Android.Views.Accessibility.AccessibilityNodeInfo RootInActiveWindow
				{
						[Dot42.DexImport("getRootInActiveWindow", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Views.Accessibility.AccessibilityNodeInfo); }
				}

				/// <summary>
				///  <para>Gets the an AccessibilityServiceInfo describing this AccessibilityService. This method is useful if one wants to change some of the dynamically configurable properties at runtime.</para> <para> <para>AccessibilityServiceInfo </para></para>        
				/// </summary>
				/// <returns>
				///  <para>The accessibility service info.</para>
				/// </returns>
				/// <java-name>
				/// getServiceInfo
				/// </java-name>
				public global::Android.AccessibilityServices.AccessibilityServiceInfo ServiceInfo
				{
						[Dot42.DexImport("getServiceInfo", "()Landroid/accessibilityservice/AccessibilityServiceInfo;", AccessFlags = 17)]
						get{ return default(global::Android.AccessibilityServices.AccessibilityServiceInfo); }
						[Dot42.DexImport("setServiceInfo", "(Landroid/accessibilityservice/AccessibilityServiceInfo;)V", AccessFlags = 17)]
						set{ }
				}

		}

		/// <summary>
		///  <para>This class describes an AccessibilityService. The system notifies an AccessibilityService for android.view.accessibility.AccessibilityEvents according to the information encapsulated in this class.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating AccessibilityServices, read the  developer guide.</para> <para> </para> <para>ref android.R.styleable::AccessibilityService_accessibilityEventTypes  ref android.R.styleable::AccessibilityService_accessibilityFeedbackType  ref android.R.styleable::AccessibilityService_accessibilityFlags  ref android.R.styleable::AccessibilityService_canRequestEnhancedWebAccessibility  ref android.R.styleable::AccessibilityService_canRequestFilterKeyEvents  ref android.R.styleable::AccessibilityService_canRequestTouchExplorationMode  ref android.R.styleable::AccessibilityService_canRetrieveWindowContent  ref android.R.styleable::AccessibilityService_description  ref android.R.styleable::AccessibilityService_notificationTimeout  ref android.R.styleable::AccessibilityService_packageNames  ref android.R.styleable::AccessibilityService_settingsActivity</para> <para> <para>AccessibilityService </para> <para>android.view.accessibility.AccessibilityEvent </para> <para>android.view.accessibility.AccessibilityManager </para></para>    
		/// </summary>
		/// <java-name>
		/// android/accessibilityservice/AccessibilityServiceInfo
		/// </java-name>
		[Dot42.DexImport("android/accessibilityservice/AccessibilityServiceInfo", AccessFlags = 33)]
		public partial class AccessibilityServiceInfo : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Denotes spoken feedback. </para>        
				/// </summary>
				/// <java-name>
				/// FEEDBACK_SPOKEN
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_SPOKEN", "I", AccessFlags = 25)]
				public const int FEEDBACK_SPOKEN = 1;
				/// <summary>
				///  <para>Denotes haptic feedback. </para>        
				/// </summary>
				/// <java-name>
				/// FEEDBACK_HAPTIC
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_HAPTIC", "I", AccessFlags = 25)]
				public const int FEEDBACK_HAPTIC = 2;
				/// <summary>
				///  <para>Denotes audible (not spoken) feedback. </para>        
				/// </summary>
				/// <java-name>
				/// FEEDBACK_AUDIBLE
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_AUDIBLE", "I", AccessFlags = 25)]
				public const int FEEDBACK_AUDIBLE = 4;
				/// <summary>
				///  <para>Denotes visual feedback. </para>        
				/// </summary>
				/// <java-name>
				/// FEEDBACK_VISUAL
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_VISUAL", "I", AccessFlags = 25)]
				public const int FEEDBACK_VISUAL = 8;
				/// <summary>
				///  <para>Denotes generic feedback. </para>        
				/// </summary>
				/// <java-name>
				/// FEEDBACK_GENERIC
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_GENERIC", "I", AccessFlags = 25)]
				public const int FEEDBACK_GENERIC = 16;
				/// <summary>
				///  <para>Mask for all feedback types.</para> <para> <para>FEEDBACK_SPOKEN </para> <para>FEEDBACK_HAPTIC </para> <para>FEEDBACK_AUDIBLE </para> <para>FEEDBACK_VISUAL </para> <para>FEEDBACK_GENERIC </para> <para>FEEDBACK_BRAILLE </para></para>        
				/// </summary>
				/// <java-name>
				/// FEEDBACK_ALL_MASK
				/// </java-name>
				[Dot42.DexImport("FEEDBACK_ALL_MASK", "I", AccessFlags = 25)]
				public const int FEEDBACK_ALL_MASK = -1;
				/// <summary>
				///  <para>If an AccessibilityService is the default for a given type. Default service is invoked only if no package specific one exists. In case of more than one package specific service only the earlier registered is notified. </para>        
				/// </summary>
				/// <java-name>
				/// DEFAULT
				/// </java-name>
				[Dot42.DexImport("DEFAULT", "I", AccessFlags = 25)]
				public const int DEFAULT = 1;
				/// <summary>
				///  <para>If this flag is set the system will regard views that are not important for accessibility in addition to the ones that are important for accessibility. That is, views that are marked as not important for accessibility via View#IMPORTANT_FOR_ACCESSIBILITY_NO or View#IMPORTANT_FOR_ACCESSIBILITY_NO_HIDE_DESCENDANTS and views that are marked as potentially important for accessibility via View#IMPORTANT_FOR_ACCESSIBILITY_AUTO for which the system has determined that are not important for accessibility, are reported while querying the window content and also the accessibility service will receive accessibility events from them. </para> <para> <b>Note:</b> For accessibility services targeting API version Build.VERSION_CODES#JELLY_BEAN or higher this flag has to be explicitly set for the system to regard views that are not important for accessibility. For accessibility services targeting API version lower than Build.VERSION_CODES#JELLY_BEAN this flag is ignored and all views are regarded for accessibility purposes. </para> <para>Usually views not important for accessibility are layout managers that do not react to user actions, do not draw any content, and do not have any special semantics in the context of the screen content. For example, a three by three grid can be implemented as three horizontal linear layouts and one vertical, or three vertical linear layouts and one horizontal, or one grid layout, etc. In this context the actual layout mangers used to achieve the grid configuration are not important, rather it is important that there are nine evenly distributed elements. </para>        
				/// </summary>
				/// <java-name>
				/// FLAG_INCLUDE_NOT_IMPORTANT_VIEWS
				/// </java-name>
				[Dot42.DexImport("FLAG_INCLUDE_NOT_IMPORTANT_VIEWS", "I", AccessFlags = 25)]
				public const int FLAG_INCLUDE_NOT_IMPORTANT_VIEWS = 2;
				/// <summary>
				///  <para>This flag requests that the system gets into touch exploration mode. In this mode a single finger moving on the screen behaves as a mouse pointer hovering over the user interface. The system will also detect certain gestures performed on the touch screen and notify this service. The system will enable touch exploration mode if there is at least one accessibility service that has this flag set. Hence, clearing this flag does not guarantee that the device will not be in touch exploration mode since there may be another enabled service that requested it. </para> <para>For accessibility services targeting API version higher than Build.VERSION_CODES#JELLY_BEAN_MR1 that want to set this flag have to declare this capability in their meta-data by setting the attribute canRequestTouchExplorationMode to true, otherwise this flag will be ignored. For how to declare the meta-data of a service refer to { AccessibilityService::SERVICE_META_DATA}. </para> <para>Services targeting API version equal to or lower than Build.VERSION_CODES#JELLY_BEAN_MR1 will work normally, i.e. the first time they are run, if this flag is specified, a dialog is shown to the user to confirm enabling explore by touch. </para> <para> <para>android.R.styleable::AccessibilityService_canRequestTouchExplorationMode </para></para>        
				/// </summary>
				/// <java-name>
				/// FLAG_REQUEST_TOUCH_EXPLORATION_MODE
				/// </java-name>
				[Dot42.DexImport("FLAG_REQUEST_TOUCH_EXPLORATION_MODE", "I", AccessFlags = 25)]
				public const int FLAG_REQUEST_TOUCH_EXPLORATION_MODE = 4;
				/// <summary>
				///  <para>The event types an AccessibilityService is interested in. </para> <para> <b>Can be dynamically set at runtime.</b> </para> <para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_CLICKED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_LONG_CLICKED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_FOCUSED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_SELECTED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_TEXT_CHANGED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_WINDOW_STATE_CHANGED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_NOTIFICATION_STATE_CHANGED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_TOUCH_EXPLORATION_GESTURE_START </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_TOUCH_EXPLORATION_GESTURE_END </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_HOVER_ENTER </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_HOVER_EXIT </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_SCROLLED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_VIEW_TEXT_SELECTION_CHANGED </para> <para>android.view.accessibility.AccessibilityEvent::TYPE_WINDOW_CONTENT_CHANGED </para></para>        
				/// </summary>
				/// <java-name>
				/// eventTypes
				/// </java-name>
				[Dot42.DexImport("eventTypes", "I", AccessFlags = 1)]
				public int EventTypes;
				/// <summary>
				///  <para>The package names an AccessibilityService is interested in. Setting to  <code>null</code> is equivalent to all packages. </para> <para> <b>Can be dynamically set at runtime.</b> </para>        
				/// </summary>
				/// <java-name>
				/// packageNames
				/// </java-name>
				[Dot42.DexImport("packageNames", "[Ljava/lang/String;", AccessFlags = 1)]
				public string[] PackageNames;
				/// <summary>
				///  <para>The feedback type an AccessibilityService provides. </para> <para> <b>Can be dynamically set at runtime.</b> </para> <para> <para>FEEDBACK_AUDIBLE </para> <para>FEEDBACK_GENERIC </para> <para>FEEDBACK_HAPTIC </para> <para>FEEDBACK_SPOKEN </para> <para>FEEDBACK_VISUAL </para> <para>FEEDBACK_BRAILLE </para></para>        
				/// </summary>
				/// <java-name>
				/// feedbackType
				/// </java-name>
				[Dot42.DexImport("feedbackType", "I", AccessFlags = 1)]
				public int FeedbackType;
				/// <summary>
				///  <para>The timeout after the most recent event of a given type before an AccessibilityService is notified. </para> <para> <b>Can be dynamically set at runtime.</b>. </para> <para> <b>Note:</b> The event notification timeout is useful to avoid propagating events to the client too frequently since this is accomplished via an expensive interprocess call. One can think of the timeout as a criteria to determine when event generation has settled down. </para>        
				/// </summary>
				/// <java-name>
				/// notificationTimeout
				/// </java-name>
				[Dot42.DexImport("notificationTimeout", "J", AccessFlags = 1)]
				public long NotificationTimeout;
				/// <summary>
				///  <para>This field represents a set of flags used for configuring an AccessibilityService. </para> <para> <b>Can be dynamically set at runtime.</b> </para> <para> <para>DEFAULT </para> <para>FLAG_INCLUDE_NOT_IMPORTANT_VIEWS </para> <para>FLAG_REQUEST_TOUCH_EXPLORATION_MODE </para> <para>FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITY </para> <para>FLAG_REQUEST_FILTER_KEY_EVENTS </para> <para>FLAG_REPORT_VIEW_IDS </para></para>        
				/// </summary>
				/// <java-name>
				/// flags
				/// </java-name>
				[Dot42.DexImport("flags", "I", AccessFlags = 1)]
				public int Flags;
				/// <summary>
				///  <para> <para>Parcelable.Creator </para></para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.AccessibilityServices.AccessibilityServiceInfo> CREATOR;
				/// <summary>
				///  <para>Creates a new instance. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccessibilityServiceInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>The localized description of the accessibility service. </para> <para> <b>Statically set from meta-data.</b> </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The localized description. </para>
				/// </returns>
				/// <java-name>
				/// loadDescription
				/// </java-name>
				[Dot42.DexImport("loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/String;", AccessFlags = 1)]
				public virtual string LoadDescription(global::Android.Content.PM.PackageManager packageManager) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para> <para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para> <para></para> </para>        
				/// </summary>
				/// <returns>
				///  <para>a bitmask indicating the set of special object types marshalled by the Parcelable.</para>
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
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the string representation of a feedback type. For example, FEEDBACK_SPOKEN is represented by the string FEEDBACK_SPOKEN.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The string representation. </para>
				/// </returns>
				/// <java-name>
				/// feedbackTypeToString
				/// </java-name>
				[Dot42.DexImport("feedbackTypeToString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string FeedbackTypeToString(int feedbackType) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>Returns the string representation of a flag. For example, DEFAULT is represented by the string DEFAULT.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The string representation. </para>
				/// </returns>
				/// <java-name>
				/// flagToString
				/// </java-name>
				[Dot42.DexImport("flagToString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string FlagToString(int flag) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				///  <para>The accessibility service id. </para> <para> <b>Generated by the system.</b> </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The id. </para>
				/// </returns>
				/// <java-name>
				/// getId
				/// </java-name>
				public virtual string Id
				{
						[Dot42.DexImport("getId", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>The service ResolveInfo. </para> <para> <b>Generated by the system.</b> </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The info. </para>
				/// </returns>
				/// <java-name>
				/// getResolveInfo
				/// </java-name>
				public virtual global::Android.Content.PM.ResolveInfo ResolveInfo
				{
						[Dot42.DexImport("getResolveInfo", "()Landroid/content/pm/ResolveInfo;", AccessFlags = 1)]
						get{ return default(global::Android.Content.PM.ResolveInfo); }
				}

				/// <summary>
				///  <para>The settings activity name. </para> <para> <b>Statically set from meta-data.</b> </para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The settings activity name. </para>
				/// </returns>
				/// <java-name>
				/// getSettingsActivityName
				/// </java-name>
				public virtual string SettingsActivityName
				{
						[Dot42.DexImport("getSettingsActivityName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <summary>
				///  <para>Whether this service can retrieve the current window's content. </para> <para> <b>Statically set from meta-data.</b> </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getCapabilities(). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>True if window content can be retrieved.</para>
				/// </returns>
				/// <java-name>
				/// getCanRetrieveWindowContent
				/// </java-name>
				public virtual bool CanRetrieveWindowContent
				{
						[Dot42.DexImport("getCanRetrieveWindowContent", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Gets the non-localized description of the accessibility service. </para> <para> <b>Statically set from meta-data.</b> </para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use loadDescription(PackageManager). </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>The description.</para>
				/// </returns>
				/// <java-name>
				/// getDescription
				/// </java-name>
				public virtual string Description
				{
						[Dot42.DexImport("getDescription", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

}

