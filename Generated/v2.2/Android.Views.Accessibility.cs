#pragma warning disable 1717
namespace Android.Views.Accessibility
{
		/// <summary>
		///  <para>This class represents accessibility events that are sent by the system when something notable happens in the user interface. For example, when a android.widget.Button is clicked, a android.view.View is focused, etc. </para> <para>An accessibility event is fired by an individual view which populates the event with data for its state and requests from its parent to send the event to interested parties. The parent can optionally add an AccessibilityRecord for itself before dispatching a similar request to its parent. A parent can also choose not to respect the request for sending an event. The accessibility event is sent by the topmost view in the view tree. Therefore, an android.accessibilityservice.AccessibilityService can explore all records in an accessibility event to obtain more information about the context in which the event was fired. </para> <para>The main purpose of an accessibility event is to expose enough information for an android.accessibilityservice.AccessibilityService to provide meaningful feedback to the user. Sometimes however, an accessibility service may need more contextual information then the one in the event pay-load. In such cases the service can obtain the event source which is an AccessibilityNodeInfo (snapshot of a View state) which can be used for exploring the window content. Note that the privilege for accessing an event's source, thus the window content, has to be explicitly requested. For more details refer to android.accessibilityservice.AccessibilityService. If an accessibility service has not requested to retrieve the window content the event will not contain reference to its source. Also for events of type TYPE_NOTIFICATION_STATE_CHANGED the source is never available. </para> <para>This class represents various semantically different accessibility event types. Each event type has an associated set of related properties. In other words, each event type is characterized via a subset of the properties exposed by this class. For each event type there is a corresponding constant defined in this class. Follows a specification of the event types and their associated properties: </para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about creating and processing AccessibilityEvents, read the  developer guide.</para> <para>  </para> <para> <b>VIEW TYPES</b> </para> <para> <b>View clicked</b> - represents the event of clicking on a android.view.View like android.widget.Button, android.widget.CompoundButton, etc.  <b>Type:</b>TYPE_VIEW_CLICKED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>isPassword() - Whether the source is password. </para></li> <li> <para>isChecked() - Whether the source is checked. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li> <li> <para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para> <para> <b>View long clicked</b> - represents the event of long clicking on a android.view.View like android.widget.Button, android.widget.CompoundButton, etc   <b>Type:</b>TYPE_VIEW_LONG_CLICKED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>isPassword() - Whether the source is password. </para></li> <li> <para>isChecked() - Whether the source is checked. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li> <li> <para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para> <para> <b>View selected</b> - represents the event of selecting an item usually in the context of an android.widget.AdapterView.  <b>Type:</b> TYPE_VIEW_SELECTED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>isPassword() - Whether the source is password. </para></li> <li> <para>isChecked() - Whether the source is checked. </para></li> <li> <para>getItemCount() - The number of selectable items of the source. </para></li> <li> <para>getCurrentItemIndex() - The currently selected item index. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li> <li> <para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para> <para> <b>View focused</b> - represents the event of focusing a android.view.View.  <b>Type:</b> TYPE_VIEW_FOCUSED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>isPassword() - Whether the source is password. </para></li> <li> <para>isChecked() - Whether the source is checked. </para></li> <li> <para>getItemCount() - The number of focusable items on the screen. </para></li> <li> <para>getCurrentItemIndex() - The currently focused item index. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li> <li> <para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para> <para> <b>View text changed</b> - represents the event of changing the text of an android.widget.EditText.  <b>Type:</b> TYPE_VIEW_TEXT_CHANGED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>isPassword() - Whether the source is password. </para></li> <li> <para>isChecked() - Whether the source is checked. </para></li> <li> <para>getFromIndex() - The text change start index. </para></li> <li> <para>getAddedCount() - The number of added characters. </para></li> <li> <para>getRemovedCount() - The number of removed characters. </para></li> <li> <para>getBeforeText() - The text of the source before the change. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li></ul></para> <para> <b>View text selection changed</b> - represents the event of changing the text selection of an android.widget.EditText.  <b>Type:</b> TYPE_VIEW_TEXT_SELECTION_CHANGED   <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source. </para></li> <li> <para>isPassword() - Whether the source is password. </para></li> <li> <para>getFromIndex() - The selection start index. </para></li> <li> <para>getToIndex() - The selection end index. </para></li> <li> <para>getItemCount() - The length of the source text. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li></ul></para> <para> <b>View text traversed at movement granularity</b> - represents the event of traversing the text of a view at a given granularity. For example, moving to the next word.  <b>Type:</b> TYPE_VIEW_TEXT_TRAVERSED_AT_MOVEMENT_GRANULARITY   <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getMovementGranularity() - Sets the granularity at which a view's text was traversed. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>getFromIndex() - The start of the next/previous text at the specified granularity <ul> <li> <para>inclusive. </para></li></ul></para></li> <li> <para>getToIndex() - The end of the next/previous text at the specified granularity <ul> <li> <para>exclusive. </para></li></ul></para></li> <li> <para>isPassword() - Whether the source is password. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li> <li> <para>getMovementGranularity() - Sets the granularity at which a view's text was traversed. </para></li> <li> <para>getAction() - Gets traversal action which specifies the direction. </para></li></ul></para> <para> <b>View scrolled</b> - represents the event of scrolling a view. If the source is a descendant of android.widget.AdapterView the scroll is reported in terms of visible items - the first visible item, the last visible item, and the total items - because the the source is unaware of its pixel size since its adapter is responsible for creating views. In all other cases the scroll is reported as the current scroll on the X and Y axis respectively plus the height of the source in pixels.  <b>Type:</b> TYPE_VIEW_SCROLLED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li> <li> <para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul> <b>Note:</b> This event type is not dispatched to descendants though View.dispatchPopulateAccessibilityEvent(AccessibilityEvent), hence the event source android.view.View and the sub-tree rooted at it will not receive calls to View.onPopulateAccessibilityEvent(AccessibilityEvent). The preferred way to add text content to such events is by setting the contentDescription of the source view. </para> <para> <b>TRANSITION TYPES</b> </para> <para> <b>Window state changed</b> - represents the event of opening a android.widget.PopupWindow, android.view.Menu, android.app.Dialog, etc.  <b>Type:</b> TYPE_WINDOW_STATE_CHANGED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li></ul></para> <para> <b>Window content changed</b> - represents the event of change in the content of a window. This change can be adding/removing view, changing a view size, etc. </para> <para> <b>Note:</b> This event is fired only for the window source of the last accessibility event different from TYPE_NOTIFICATION_STATE_CHANGED and its purpose is to notify clients that the content of the user interaction window has changed.  <b>Type:</b> TYPE_WINDOW_CONTENT_CHANGED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getContentChangeTypes() - The type of content changes. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li></ul> <b>Note:</b> This event type is not dispatched to descendants though View.dispatchPopulateAccessibilityEvent(AccessibilityEvent), hence the event source android.view.View and the sub-tree rooted at it will not receive calls to View.onPopulateAccessibilityEvent(AccessibilityEvent). The preferred way to add text content to such events is by setting the contentDescription of the source view. </para> <para> <b>NOTIFICATION TYPES</b> </para> <para> <b>Notification state changed</b> - represents the event showing android.app.Notification.  <b>Type:</b> TYPE_NOTIFICATION_STATE_CHANGED  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>getParcelableData() - The posted android.app.Notification. </para></li> <li> <para>getText() - Text for providing more context. </para></li></ul> <b>Note:</b> This event type is not dispatched to descendants though View.dispatchPopulateAccessibilityEvent(AccessibilityEvent), hence the event source android.view.View and the sub-tree rooted at it will not receive calls to View.onPopulateAccessibilityEvent(AccessibilityEvent). The preferred way to add text content to such events is by setting the contentDescription of the source view. </para> <para> <b>EXPLORATION TYPES</b> </para> <para> <b>View hover enter</b> - represents the event of beginning to hover over a android.view.View. The hover may be generated via exploring the screen by touch or via a pointing device.  <b>Type:</b> TYPE_VIEW_HOVER_ENTER  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li> <li> <para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para> <para> <b>View hover exit</b> - represents the event of stopping to hover over a android.view.View. The hover may be generated via exploring the screen by touch or via a pointing device.  <b>Type:</b> TYPE_VIEW_HOVER_EXIT  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the source's sub-tree. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li> <li> <para>getContentDescription() - The content description of the source. </para></li> <li> <para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li> <li> <para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li> <li> <para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para> <para> <b>Touch interaction start</b> - represents the event of starting a touch interaction, which is the user starts touching the screen.  <b>Type:</b> TYPE_TOUCH_INTERACTION_START  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li></ul> <b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para> <para> <b>Touch interaction end</b> - represents the event of ending a touch interaction, which is the user stops touching the screen.  <b>Type:</b> TYPE_TOUCH_INTERACTION_END  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li></ul> <b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para> <para> <b>Touch exploration gesture start</b> - represents the event of starting a touch exploring gesture.  <b>Type:</b> TYPE_TOUCH_EXPLORATION_GESTURE_START  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li></ul> <b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para> <para> <b>Touch exploration gesture end</b> - represents the event of ending a touch exploring gesture.  <b>Type:</b> TYPE_TOUCH_EXPLORATION_GESTURE_END  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li></ul> <b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para> <para> <b>Touch gesture detection start</b> - represents the event of starting a user gesture detection.  <b>Type:</b> TYPE_GESTURE_DETECTION_START  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li></ul> <b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para> <para> <b>Touch gesture detection end</b> - represents the event of ending a user gesture detection.  <b>Type:</b> TYPE_GESTURE_DETECTION_END  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li></ul> <b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para> <para> <b>MISCELLANEOUS TYPES</b> </para> <para> <b>Announcement</b> - represents the event of an application making an announcement. Usually this announcement is related to some sort of a context change for which none of the events representing UI transitions is a good fit. For example, announcing a new page in a book.  <b>Type:</b> TYPE_ANNOUNCEMENT  <b>Properties:</b>  <ul> <li> <para>getEventType() - The type of the event. </para></li> <li> <para>getSource() - The source info (for registered clients). </para></li> <li> <para>getClassName() - The class name of the source. </para></li> <li> <para>getPackageName() - The package name of the source. </para></li> <li> <para>getEventTime() - The event time. </para></li> <li> <para>getText() - The text of the announcement. </para></li> <li> <para>isEnabled() - Whether the source is enabled. </para></li></ul></para> <para> <b>Security note</b> </para> <para>Since an event contains the text of its source privacy can be compromised by leaking sensitive information such as passwords. To address this issue any event fired in response to manipulation of a PASSWORD field does NOT CONTAIN the text of the password. </para> <para> <para>android.view.accessibility.AccessibilityManager </para> <para>android.accessibilityservice.AccessibilityService </para> <para>AccessibilityNodeInfo </para></para>    
		/// </summary>
		/// <java-name>
		/// android/view/accessibility/AccessibilityEvent
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityEvent", AccessFlags = 49)]
		public sealed partial class AccessibilityEvent : global::Android.OS.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Invalid selection/focus position.</para> <para> <para>getCurrentItemIndex() </para></para>        
				/// </summary>
				/// <java-name>
				/// INVALID_POSITION
				/// </java-name>
				[Dot42.DexImport("INVALID_POSITION", "I", AccessFlags = 25)]
				public const int INVALID_POSITION = -1;
				/// <summary>
				///  <para>Maximum length of the text fields.</para> <para> <para>getBeforeText() </para> <para>getText()  Note: This constant is no longer needed since there is no limit on the length of text that is contained in an accessibility event anymore. </para></para>        
				/// </summary>
				/// <java-name>
				/// MAX_TEXT_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_TEXT_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_TEXT_LENGTH = 500;
				/// <summary>
				///  <para>Represents the event of clicking on a android.view.View like android.widget.Button, android.widget.CompoundButton, etc. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_CLICKED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_CLICKED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_CLICKED = 1;
				/// <summary>
				///  <para>Represents the event of long clicking on a android.view.View like android.widget.Button, android.widget.CompoundButton, etc. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_LONG_CLICKED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_LONG_CLICKED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_LONG_CLICKED = 2;
				/// <summary>
				///  <para>Represents the event of selecting an item usually in the context of an android.widget.AdapterView. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_SELECTED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_SELECTED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_SELECTED = 4;
				/// <summary>
				///  <para>Represents the event of setting input focus of a android.view.View. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_FOCUSED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_FOCUSED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_FOCUSED = 8;
				/// <summary>
				///  <para>Represents the event of changing the text of an android.widget.EditText. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_TEXT_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_TEXT_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_TEXT_CHANGED = 16;
				/// <summary>
				///  <para>Represents the event of opening a android.widget.PopupWindow, android.view.Menu, android.app.Dialog, etc. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_WINDOW_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_WINDOW_STATE_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_WINDOW_STATE_CHANGED = 32;
				/// <summary>
				///  <para>Represents the event showing a android.app.Notification. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NOTIFICATION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_NOTIFICATION_STATE_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_NOTIFICATION_STATE_CHANGED = 64;
				/// <summary>
				///  <para>Mask for AccessibilityEvent all types.</para> <para> <para>TYPE_VIEW_CLICKED </para> <para>TYPE_VIEW_LONG_CLICKED </para> <para>TYPE_VIEW_SELECTED </para> <para>TYPE_VIEW_FOCUSED </para> <para>TYPE_VIEW_TEXT_CHANGED </para> <para>TYPE_WINDOW_STATE_CHANGED </para> <para>TYPE_NOTIFICATION_STATE_CHANGED </para> <para>TYPE_VIEW_HOVER_ENTER </para> <para>TYPE_VIEW_HOVER_EXIT </para> <para>TYPE_TOUCH_EXPLORATION_GESTURE_START </para> <para>TYPE_TOUCH_EXPLORATION_GESTURE_END </para> <para>TYPE_WINDOW_CONTENT_CHANGED </para> <para>TYPE_VIEW_SCROLLED </para> <para>TYPE_VIEW_TEXT_SELECTION_CHANGED </para> <para>TYPE_ANNOUNCEMENT </para> <para>TYPE_VIEW_TEXT_TRAVERSED_AT_MOVEMENT_GRANULARITY </para> <para>TYPE_GESTURE_DETECTION_START </para> <para>TYPE_GESTURE_DETECTION_END </para> <para>TYPE_TOUCH_INTERACTION_START </para> <para>TYPE_TOUCH_INTERACTION_END </para></para>        
				/// </summary>
				/// <java-name>
				/// TYPES_ALL_MASK
				/// </java-name>
				[Dot42.DexImport("TYPES_ALL_MASK", "I", AccessFlags = 25)]
				public const int TYPES_ALL_MASK = -1;
				/// <summary>
				///  <para> <para>Parcelable.Creator </para></para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.OS.IParcelable_ICreator<global::Android.Views.Accessibility.AccessibilityEvent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityEvent() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns a cached instance if such is available or a new one is instantiated with its type property set.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An instance. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityEvent Obtain(int eventType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityEvent);
				}

				/// <summary>
				///  <para>Returns a cached instance if such is available or a new one is instantiated.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>An instance. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityEvent;", AccessFlags = 9)]
				public static global::Android.Views.Accessibility.AccessibilityEvent Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Views.Accessibility.AccessibilityEvent);
				}

				/// <summary>
				///  <para>Recycles an instance back to be reused. </para> <para> <b>Note: You must not touch the object after calling this function.</b> </para> <para></para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Creates a new instance from a Parcel.</para> <para></para>        
				/// </summary>
				/// <java-name>
				/// initFromParcel
				/// </java-name>
				[Dot42.DexImport("initFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public void InitFromParcel(global::Android.OS.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para> <para>Flatten this object in to a Parcel.</para> <para></para> </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.OS.Parcel parcel, int flags) /* MethodBuilder.Create */ 
				{
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
				/// isChecked
				/// </java-name>
				public bool IsChecked
				{
						[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				public bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isPassword
				/// </java-name>
				public bool IsPassword
				{
						[Dot42.DexImport("isPassword", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPassword", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isFullScreen
				/// </java-name>
				public bool IsFullScreen
				{
						[Dot42.DexImport("isFullScreen", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setFullScreen", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the event type.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The event type. </para>
				/// </returns>
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
				/// getItemCount
				/// </java-name>
				public int ItemCount
				{
						[Dot42.DexImport("getItemCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setItemCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCurrentItemIndex
				/// </java-name>
				public int CurrentItemIndex
				{
						[Dot42.DexImport("getCurrentItemIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setCurrentItemIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getFromIndex
				/// </java-name>
				public int FromIndex
				{
						[Dot42.DexImport("getFromIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setFromIndex", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getAddedCount
				/// </java-name>
				public int AddedCount
				{
						[Dot42.DexImport("getAddedCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setAddedCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getRemovedCount
				/// </java-name>
				public int RemovedCount
				{
						[Dot42.DexImport("getRemovedCount", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setRemovedCount", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the time in which this event was sent.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The event time. </para>
				/// </returns>
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
				/// getClassName
				/// </java-name>
				public global::Java.Lang.ICharSequence ClassName
				{
						[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <summary>
				///  <para>Gets the package name of the source.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>The package name. </para>
				/// </returns>
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

				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Util.IList<global::Java.Lang.ICharSequence> Text
				{
						[Dot42.DexImport("getText", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/CharSequence;>;")]
						get{ return default(global::Java.Util.IList<global::Java.Lang.ICharSequence>); }
				}

				/// <java-name>
				/// getBeforeText
				/// </java-name>
				public global::Java.Lang.ICharSequence BeforeText
				{
						[Dot42.DexImport("getBeforeText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setBeforeText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getContentDescription
				/// </java-name>
				public global::Java.Lang.ICharSequence ContentDescription
				{
						[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return default(global::Java.Lang.ICharSequence); }
						[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getParcelableData
				/// </java-name>
				public global::Android.OS.IParcelable ParcelableData
				{
						[Dot42.DexImport("getParcelableData", "()Landroid/os/Parcelable;", AccessFlags = 1)]
						get{ return default(global::Android.OS.IParcelable); }
						[Dot42.DexImport("setParcelableData", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <summary>
		///  <para>System level service that serves as an event dispatch for AccessibilityEvents, and provides facilities for querying the accessibility state of the system. Accessibility events are generated when something notable happens in the user interface, for example an android.app.Activity starts, the focus or selection of a android.view.View changes etc. Parties interested in handling accessibility events implement and register an accessibility service which extends android.accessibilityservice.AccessibilityService. </para> <para>To obtain a handle to the accessibility manager do the following: </para> <para> <code>  <pre>AccessibilityManager accessibilityManager =
		///        (AccessibilityManager) context.getSystemService(Context.ACCESSIBILITY_SERVICE);</pre> </code> </para> <para> <para>AccessibilityEvent </para> <para>AccessibilityNodeInfo </para> <para>android.accessibilityservice.AccessibilityService </para> <para>Context::getSystemService </para> <para>Context::ACCESSIBILITY_SERVICE </para></para>    
		/// </summary>
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

				/// <summary>
				///  <para>Sends an AccessibilityEvent.</para> <para> <b>Note:</b> The preferred mechanism for sending custom accessibility events is through calling android.view.ViewParent#requestSendAccessibilityEvent(View, AccessibilityEvent) instead of this method to allow predecessors to augment/filter events sent by their descendants. </para>        
				/// </summary>
				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public void SendAccessibilityEvent(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Requests feedback interruption from all accessibility services. </para>        
				/// </summary>
				/// <java-name>
				/// interrupt
				/// </java-name>
				[Dot42.DexImport("interrupt", "()V", AccessFlags = 1)]
				public void Interrupt() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				///  <para>Returns if the accessibility in the system is enabled.</para> <para></para>        
				/// </summary>
				/// <returns>
				///  <para>True if accessibility is enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				public bool IsEnabled
				{
						[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
				}

				/// <summary>
				///  <para>Returns the ServiceInfos of the installed accessibility services.</para> <para> <xrefsect> <xreftitle>Deprecated</xreftitle> <xrefdescription> <para>Use getInstalledAccessibilityServiceList() </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				///  <para>An unmodifiable list with ServiceInfos.</para>
				/// </returns>
				/// <java-name>
				/// getAccessibilityServiceList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Content.PM.ServiceInfo> AccessibilityServiceList
				{
						[Dot42.DexImport("getAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/pm/ServiceInfo;>;")]
						get{ return default(global::Java.Util.IList<global::Android.Content.PM.ServiceInfo>); }
				}

		}

		/// <summary>
		///  <para>This interface is implemented by classes source of AccessibilityEvents.</para> <para>  <h3>Developer Guides</h3></para> <para> </para> <para>For more information about making applications accessible, read the  developer guide.</para> <para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/view/accessibility/AccessibilityEventSource
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityEventSource", AccessFlags = 1537)]
		public partial interface IAccessibilityEventSource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				///  <para>Handles the request for sending an AccessibilityEvent given the event type. The method must first check if accessibility is on via calling AccessibilityManager.isEnabled(), obtain an AccessibilityEvent from the event pool through calling AccessibilityEvent.obtain(int), populate the event, and send it for dispatch via calling AccessibilityManager.sendAccessibilityEvent(AccessibilityEvent).</para> <para> <para>AccessibilityEvent </para> <para>AccessibilityManager</para></para>        
				/// </summary>
				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1025)]
				void SendAccessibilityEvent(int eventType) /* MethodBuilder.Create */ ;

				/// <summary>
				///  <para>Handles the request for sending an AccessibilityEvent. The method does not guarantee to check if accessibility is on before sending the event for dispatch. It is responsibility of the caller to do the check via calling AccessibilityManager.isEnabled().</para> <para> <para>AccessibilityEvent </para> <para>AccessibilityManager</para></para>        
				/// </summary>
				/// <java-name>
				/// sendAccessibilityEventUnchecked
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1025)]
				void SendAccessibilityEventUnchecked(global::Android.Views.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ ;

		}

}

