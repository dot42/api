// Copyright (C) 2014 dot42
//
// Original filename: Android.View.Accessibility.cs
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
namespace Android.View.Accessibility
{
		/// <summary>
		/// <para>This interface is implemented by classes source of AccessibilityEvents.</para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about making applications accessible, read the  developer guide.</para><para>  </para>    
		/// </summary>
		/// <java-name>
		/// android/view/accessibility/AccessibilityEventSource
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityEventSource", AccessFlags = 1537)]
		public partial interface IAccessibilityEventSource
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Handles the request for sending an AccessibilityEvent given the event type. The method must first check if accessibility is on via calling AccessibilityManager.isEnabled(), obtain an AccessibilityEvent from the event pool through calling AccessibilityEvent.obtain(int), populate the event, and send it for dispatch via calling AccessibilityManager.sendAccessibilityEvent(AccessibilityEvent).</para><para><para>AccessibilityEvent </para><simplesectsep></simplesectsep><para>AccessibilityManager</para></para>        
				/// </summary>
				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(I)V", AccessFlags = 1025)]
				void SendAccessibilityEvent(int eventType) /* MethodBuilder.Create */ ;

				/// <summary>
				/// <para>Handles the request for sending an AccessibilityEvent. The method does not guarantee to check if accessibility is on before sending the event for dispatch. It is responsibility of the caller to do the check via calling AccessibilityManager.isEnabled().</para><para><para>AccessibilityEvent </para><simplesectsep></simplesectsep><para>AccessibilityManager</para></para>        
				/// </summary>
				/// <java-name>
				/// sendAccessibilityEventUnchecked
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEventUnchecked", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1025)]
				void SendAccessibilityEventUnchecked(global::Android.View.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ ;

		}

		/// <summary>
		/// <para>This class represents accessibility events that are sent by the system when something notable happens in the user interface. For example, when a android.widget.Button is clicked, a android.view.View is focused, etc. </para><para>An accessibility event is fired by an individual view which populates the event with data for its state and requests from its parent to send the event to interested parties. The parent can optionally add an AccessibilityRecord for itself before dispatching a similar request to its parent. A parent can also choose not to respect the request for sending an event. The accessibility event is sent by the topmost view in the view tree. Therefore, an android.accessibilityservice.AccessibilityService can explore all records in an accessibility event to obtain more information about the context in which the event was fired. </para><para>The main purpose of an accessibility event is to expose enough information for an android.accessibilityservice.AccessibilityService to provide meaningful feedback to the user. Sometimes however, an accessibility service may need more contextual information then the one in the event pay-load. In such cases the service can obtain the event source which is an AccessibilityNodeInfo (snapshot of a View state) which can be used for exploring the window content. Note that the privilege for accessing an event's source, thus the window content, has to be explicitly requested. For more details refer to android.accessibilityservice.AccessibilityService. If an accessibility service has not requested to retrieve the window content the event will not contain reference to its source. Also for events of type TYPE_NOTIFICATION_STATE_CHANGED the source is never available. </para><para>This class represents various semantically different accessibility event types. Each event type has an associated set of related properties. In other words, each event type is characterized via a subset of the properties exposed by this class. For each event type there is a corresponding constant defined in this class. Follows a specification of the event types and their associated properties: </para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about creating and processing AccessibilityEvents, read the  developer guide.</para><para>  </para><para><b>VIEW TYPES</b> </para><para><b>View clicked</b> - represents the event of clicking on a android.view.View like android.widget.Button, android.widget.CompoundButton, etc. <b>Type:</b>TYPE_VIEW_CLICKED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>isPassword() - Whether the source is password. </para></li><li><para>isChecked() - Whether the source is checked. </para></li><li><para>getContentDescription() - The content description of the source. </para></li><li><para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li><li><para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li><li><para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para><para><b>View long clicked</b> - represents the event of long clicking on a android.view.View like android.widget.Button, android.widget.CompoundButton, etc  <b>Type:</b>TYPE_VIEW_LONG_CLICKED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>isPassword() - Whether the source is password. </para></li><li><para>isChecked() - Whether the source is checked. </para></li><li><para>getContentDescription() - The content description of the source. </para></li><li><para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li><li><para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li><li><para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para><para><b>View selected</b> - represents the event of selecting an item usually in the context of an android.widget.AdapterView. <b>Type:</b> TYPE_VIEW_SELECTED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>isPassword() - Whether the source is password. </para></li><li><para>isChecked() - Whether the source is checked. </para></li><li><para>getItemCount() - The number of selectable items of the source. </para></li><li><para>getCurrentItemIndex() - The currently selected item index. </para></li><li><para>getContentDescription() - The content description of the source. </para></li><li><para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li><li><para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li><li><para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para><para><b>View focused</b> - represents the event of focusing a android.view.View. <b>Type:</b> TYPE_VIEW_FOCUSED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>isPassword() - Whether the source is password. </para></li><li><para>isChecked() - Whether the source is checked. </para></li><li><para>getItemCount() - The number of focusable items on the screen. </para></li><li><para>getCurrentItemIndex() - The currently focused item index. </para></li><li><para>getContentDescription() - The content description of the source. </para></li><li><para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li><li><para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li><li><para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para><para><b>View text changed</b> - represents the event of changing the text of an android.widget.EditText. <b>Type:</b> TYPE_VIEW_TEXT_CHANGED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>isPassword() - Whether the source is password. </para></li><li><para>isChecked() - Whether the source is checked. </para></li><li><para>getFromIndex() - The text change start index. </para></li><li><para>getAddedCount() - The number of added characters. </para></li><li><para>getRemovedCount() - The number of removed characters. </para></li><li><para>getBeforeText() - The text of the source before the change. </para></li><li><para>getContentDescription() - The content description of the source. </para></li></ul></para><para><b>View text selection changed</b> - represents the event of changing the text selection of an android.widget.EditText. <b>Type:</b> TYPE_VIEW_TEXT_SELECTION_CHANGED  <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source. </para></li><li><para>isPassword() - Whether the source is password. </para></li><li><para>getFromIndex() - The selection start index. </para></li><li><para>getToIndex() - The selection end index. </para></li><li><para>getItemCount() - The length of the source text. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>getContentDescription() - The content description of the source. </para></li></ul></para><para><b>View text traversed at movement granularity</b> - represents the event of traversing the text of a view at a given granularity. For example, moving to the next word. <b>Type:</b> TYPE_VIEW_TEXT_TRAVERSED_AT_MOVEMENT_GRANULARITY  <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getMovementGranularity() - Sets the granularity at which a view's text was traversed. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>getFromIndex() - The start of the next/previous text at the specified granularity<ul><li><para>inclusive. </para></li></ul></para></li><li><para>getToIndex() - The end of the next/previous text at the specified granularity<ul><li><para>exclusive. </para></li></ul></para></li><li><para>isPassword() - Whether the source is password. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>getContentDescription() - The content description of the source. </para></li><li><para>getMovementGranularity() - Sets the granularity at which a view's text was traversed. </para></li><li><para>getAction() - Gets traversal action which specifies the direction. </para></li></ul></para><para><b>View scrolled</b> - represents the event of scrolling a view. If the source is a descendant of android.widget.AdapterView the scroll is reported in terms of visible items - the first visible item, the last visible item, and the total items - because the the source is unaware of its pixel size since its adapter is responsible for creating views. In all other cases the scroll is reported as the current scroll on the X and Y axis respectively plus the height of the source in pixels. <b>Type:</b> TYPE_VIEW_SCROLLED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>getContentDescription() - The content description of the source. </para></li><li><para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li><li><para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li><li><para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul><b>Note:</b> This event type is not dispatched to descendants though View.dispatchPopulateAccessibilityEvent(AccessibilityEvent), hence the event source android.view.View and the sub-tree rooted at it will not receive calls to View.onPopulateAccessibilityEvent(AccessibilityEvent). The preferred way to add text content to such events is by setting the contentDescription of the source view. </para><para><b>TRANSITION TYPES</b> </para><para><b>Window state changed</b> - represents the event of opening a android.widget.PopupWindow, android.view.Menu, android.app.Dialog, etc. <b>Type:</b> TYPE_WINDOW_STATE_CHANGED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li></ul></para><para><b>Window content changed</b> - represents the event of change in the content of a window. This change can be adding/removing view, changing a view size, etc. </para><para><b>Note:</b> This event is fired only for the window source of the last accessibility event different from TYPE_NOTIFICATION_STATE_CHANGED and its purpose is to notify clients that the content of the user interaction window has changed. <b>Type:</b> TYPE_WINDOW_CONTENT_CHANGED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li></ul><b>Note:</b> This event type is not dispatched to descendants though View.dispatchPopulateAccessibilityEvent(AccessibilityEvent), hence the event source android.view.View and the sub-tree rooted at it will not receive calls to View.onPopulateAccessibilityEvent(AccessibilityEvent). The preferred way to add text content to such events is by setting the contentDescription of the source view. </para><para><b>NOTIFICATION TYPES</b> </para><para><b>Notification state changed</b> - represents the event showing android.app.Notification. <b>Type:</b> TYPE_NOTIFICATION_STATE_CHANGED <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>getParcelableData() - The posted android.app.Notification. </para></li><li><para>getText() - Text for providing more context. </para></li></ul><b>Note:</b> This event type is not dispatched to descendants though View.dispatchPopulateAccessibilityEvent(AccessibilityEvent), hence the event source android.view.View and the sub-tree rooted at it will not receive calls to View.onPopulateAccessibilityEvent(AccessibilityEvent). The preferred way to add text content to such events is by setting the contentDescription of the source view. </para><para><b>EXPLORATION TYPES</b> </para><para><b>View hover enter</b> - represents the event of beginning to hover over a android.view.View. The hover may be generated via exploring the screen by touch or via a pointing device. <b>Type:</b> TYPE_VIEW_HOVER_ENTER <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>getContentDescription() - The content description of the source. </para></li><li><para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li><li><para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li><li><para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para><para><b>View hover exit</b> - represents the event of stopping to hover over a android.view.View. The hover may be generated via exploring the screen by touch or via a pointing device. <b>Type:</b> TYPE_VIEW_HOVER_EXIT <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the source's sub-tree. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li><li><para>getContentDescription() - The content description of the source. </para></li><li><para>getScrollX() - The offset of the source left edge in pixels (without descendants of AdapterView). </para></li><li><para>getScrollY() - The offset of the source top edge in pixels (without descendants of AdapterView). </para></li><li><para>getFromIndex() - The zero based index of the first visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getToIndex() - The zero based index of the last visible item of the source, inclusive (for descendants of AdapterView). </para></li><li><para>getItemCount() - The total items of the source (for descendants of AdapterView). </para></li></ul></para><para><b>Touch interaction start</b> - represents the event of starting a touch interaction, which is the user starts touching the screen. <b>Type:</b> TYPE_TOUCH_INTERACTION_START <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li></ul><b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para><para><b>Touch interaction end</b> - represents the event of ending a touch interaction, which is the user stops touching the screen. <b>Type:</b> TYPE_TOUCH_INTERACTION_END <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li></ul><b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para><para><b>Touch exploration gesture start</b> - represents the event of starting a touch exploring gesture. <b>Type:</b> TYPE_TOUCH_EXPLORATION_GESTURE_START <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li></ul><b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para><para><b>Touch exploration gesture end</b> - represents the event of ending a touch exploring gesture. <b>Type:</b> TYPE_TOUCH_EXPLORATION_GESTURE_END <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li></ul><b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para><para><b>Touch gesture detection start</b> - represents the event of starting a user gesture detection. <b>Type:</b> TYPE_GESTURE_DETECTION_START <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li></ul><b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para><para><b>Touch gesture detection end</b> - represents the event of ending a user gesture detection. <b>Type:</b> TYPE_GESTURE_DETECTION_END <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li></ul><b>Note:</b> This event is fired only by the system and is not passed to the view tree to be populated. </para><para><b>MISCELLANEOUS TYPES</b> </para><para><b>Announcement</b> - represents the event of an application making an announcement. Usually this announcement is related to some sort of a context change for which none of the events representing UI transitions is a good fit. For example, announcing a new page in a book. <b>Type:</b> TYPE_ANNOUNCEMENT <b>Properties:</b> <ul><li><para>getEventType() - The type of the event. </para></li><li><para>getSource() - The source info (for registered clients). </para></li><li><para>getClassName() - The class name of the source. </para></li><li><para>getPackageName() - The package name of the source. </para></li><li><para>getEventTime() - The event time. </para></li><li><para>getText() - The text of the announcement. </para></li><li><para>isEnabled() - Whether the source is enabled. </para></li></ul></para><para><b>Security note</b> </para><para>Since an event contains the text of its source privacy can be compromised by leaking sensitive information such as passwords. To address this issue any event fired in response to manipulation of a PASSWORD field does NOT CONTAIN the text of the password. </para><para><para>android.view.accessibility.AccessibilityManager </para><simplesectsep></simplesectsep><para>android.accessibilityservice.AccessibilityService </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo </para></para>    
		/// </summary>
		/// <java-name>
		/// android/view/accessibility/AccessibilityEvent
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityEvent", AccessFlags = 49)]
		public sealed partial class AccessibilityEvent : global::Android.View.Accessibility.AccessibilityRecord, global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Invalid selection/focus position.</para><para><para>getCurrentItemIndex() </para></para>        
				/// </summary>
				/// <java-name>
				/// INVALID_POSITION
				/// </java-name>
				[Dot42.DexImport("INVALID_POSITION", "I", AccessFlags = 25)]
				public const int INVALID_POSITION = -1;
				/// <summary>
				/// <para>Maximum length of the text fields.</para><para><para>getBeforeText() </para><simplesectsep></simplesectsep><para>getText()  Note: This constant is no longer needed since there is no limit on the length of text that is contained in an accessibility event anymore. </para></para>        
				/// </summary>
				/// <java-name>
				/// MAX_TEXT_LENGTH
				/// </java-name>
				[Dot42.DexImport("MAX_TEXT_LENGTH", "I", AccessFlags = 25)]
				public const int MAX_TEXT_LENGTH = 500;
				/// <summary>
				/// <para>Represents the event of clicking on a android.view.View like android.widget.Button, android.widget.CompoundButton, etc. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_CLICKED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_CLICKED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_CLICKED = 1;
				/// <summary>
				/// <para>Represents the event of long clicking on a android.view.View like android.widget.Button, android.widget.CompoundButton, etc. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_LONG_CLICKED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_LONG_CLICKED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_LONG_CLICKED = 2;
				/// <summary>
				/// <para>Represents the event of selecting an item usually in the context of an android.widget.AdapterView. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_SELECTED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_SELECTED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_SELECTED = 4;
				/// <summary>
				/// <para>Represents the event of setting input focus of a android.view.View. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_FOCUSED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_FOCUSED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_FOCUSED = 8;
				/// <summary>
				/// <para>Represents the event of changing the text of an android.widget.EditText. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_TEXT_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_TEXT_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_TEXT_CHANGED = 16;
				/// <summary>
				/// <para>Represents the event of opening a android.widget.PopupWindow, android.view.Menu, android.app.Dialog, etc. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_WINDOW_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_WINDOW_STATE_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_WINDOW_STATE_CHANGED = 32;
				/// <summary>
				/// <para>Represents the event showing a android.app.Notification. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_NOTIFICATION_STATE_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_NOTIFICATION_STATE_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_NOTIFICATION_STATE_CHANGED = 64;
				/// <summary>
				/// <para>Represents the event of a hover enter over a android.view.View. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_HOVER_ENTER
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_HOVER_ENTER", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_HOVER_ENTER = 128;
				/// <summary>
				/// <para>Represents the event of a hover exit over a android.view.View. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_HOVER_EXIT
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_HOVER_EXIT", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_HOVER_EXIT = 256;
				/// <summary>
				/// <para>Represents the event of starting a touch exploration gesture. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TOUCH_EXPLORATION_GESTURE_START
				/// </java-name>
				[Dot42.DexImport("TYPE_TOUCH_EXPLORATION_GESTURE_START", "I", AccessFlags = 25)]
				public const int TYPE_TOUCH_EXPLORATION_GESTURE_START = 512;
				/// <summary>
				/// <para>Represents the event of ending a touch exploration gesture. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TOUCH_EXPLORATION_GESTURE_END
				/// </java-name>
				[Dot42.DexImport("TYPE_TOUCH_EXPLORATION_GESTURE_END", "I", AccessFlags = 25)]
				public const int TYPE_TOUCH_EXPLORATION_GESTURE_END = 1024;
				/// <summary>
				/// <para>Represents the event of changing the content of a window and more specifically the sub-tree rooted at the event's source. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_WINDOW_CONTENT_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_WINDOW_CONTENT_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_WINDOW_CONTENT_CHANGED = 2048;
				/// <summary>
				/// <para>Represents the event of scrolling a view. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_SCROLLED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_SCROLLED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_SCROLLED = 4096;
				/// <summary>
				/// <para>Represents the event of changing the selection in an android.widget.EditText. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_TEXT_SELECTION_CHANGED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_TEXT_SELECTION_CHANGED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_TEXT_SELECTION_CHANGED = 8192;
				/// <summary>
				/// <para>Represents the event of an application making an announcement. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_ANNOUNCEMENT
				/// </java-name>
				[Dot42.DexImport("TYPE_ANNOUNCEMENT", "I", AccessFlags = 25)]
				public const int TYPE_ANNOUNCEMENT = 16384;
				/// <summary>
				/// <para>Represents the event of gaining accessibility focus. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_ACCESSIBILITY_FOCUSED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_ACCESSIBILITY_FOCUSED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_ACCESSIBILITY_FOCUSED = 32768;
				/// <summary>
				/// <para>Represents the event of clearing accessibility focus. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_ACCESSIBILITY_FOCUS_CLEARED
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_ACCESSIBILITY_FOCUS_CLEARED", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_ACCESSIBILITY_FOCUS_CLEARED = 65536;
				/// <summary>
				/// <para>Represents the event of traversing the text of a view at a given movement granularity. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_VIEW_TEXT_TRAVERSED_AT_MOVEMENT_GRANULARITY
				/// </java-name>
				[Dot42.DexImport("TYPE_VIEW_TEXT_TRAVERSED_AT_MOVEMENT_GRANULARITY", "I", AccessFlags = 25)]
				public const int TYPE_VIEW_TEXT_TRAVERSED_AT_MOVEMENT_GRANULARITY = 131072;
				/// <summary>
				/// <para>Represents the event of beginning gesture detection. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_GESTURE_DETECTION_START
				/// </java-name>
				[Dot42.DexImport("TYPE_GESTURE_DETECTION_START", "I", AccessFlags = 25)]
				public const int TYPE_GESTURE_DETECTION_START = 262144;
				/// <summary>
				/// <para>Represents the event of ending gesture detection. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_GESTURE_DETECTION_END
				/// </java-name>
				[Dot42.DexImport("TYPE_GESTURE_DETECTION_END", "I", AccessFlags = 25)]
				public const int TYPE_GESTURE_DETECTION_END = 524288;
				/// <summary>
				/// <para>Represents the event of the user starting to touch the screen. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TOUCH_INTERACTION_START
				/// </java-name>
				[Dot42.DexImport("TYPE_TOUCH_INTERACTION_START", "I", AccessFlags = 25)]
				public const int TYPE_TOUCH_INTERACTION_START = 1048576;
				/// <summary>
				/// <para>Represents the event of the user ending to touch the screen. </para>        
				/// </summary>
				/// <java-name>
				/// TYPE_TOUCH_INTERACTION_END
				/// </java-name>
				[Dot42.DexImport("TYPE_TOUCH_INTERACTION_END", "I", AccessFlags = 25)]
				public const int TYPE_TOUCH_INTERACTION_END = 2097152;
				/// <java-name>
				/// CONTENT_CHANGE_TYPE_UNDEFINED
				/// </java-name>
				[Dot42.DexImport("CONTENT_CHANGE_TYPE_UNDEFINED", "I", AccessFlags = 25)]
				public const int CONTENT_CHANGE_TYPE_UNDEFINED = 0;
				/// <java-name>
				/// CONTENT_CHANGE_TYPE_SUBTREE
				/// </java-name>
				[Dot42.DexImport("CONTENT_CHANGE_TYPE_SUBTREE", "I", AccessFlags = 25)]
				public const int CONTENT_CHANGE_TYPE_SUBTREE = 1;
				/// <java-name>
				/// CONTENT_CHANGE_TYPE_TEXT
				/// </java-name>
				[Dot42.DexImport("CONTENT_CHANGE_TYPE_TEXT", "I", AccessFlags = 25)]
				public const int CONTENT_CHANGE_TYPE_TEXT = 2;
				/// <java-name>
				/// CONTENT_CHANGE_TYPE_CONTENT_DESCRIPTION
				/// </java-name>
				[Dot42.DexImport("CONTENT_CHANGE_TYPE_CONTENT_DESCRIPTION", "I", AccessFlags = 25)]
				public const int CONTENT_CHANGE_TYPE_CONTENT_DESCRIPTION = 4;
				/// <summary>
				/// <para>Mask for AccessibilityEvent all types.</para><para><para>TYPE_VIEW_CLICKED </para><simplesectsep></simplesectsep><para>TYPE_VIEW_LONG_CLICKED </para><simplesectsep></simplesectsep><para>TYPE_VIEW_SELECTED </para><simplesectsep></simplesectsep><para>TYPE_VIEW_FOCUSED </para><simplesectsep></simplesectsep><para>TYPE_VIEW_TEXT_CHANGED </para><simplesectsep></simplesectsep><para>TYPE_WINDOW_STATE_CHANGED </para><simplesectsep></simplesectsep><para>TYPE_NOTIFICATION_STATE_CHANGED </para><simplesectsep></simplesectsep><para>TYPE_VIEW_HOVER_ENTER </para><simplesectsep></simplesectsep><para>TYPE_VIEW_HOVER_EXIT </para><simplesectsep></simplesectsep><para>TYPE_TOUCH_EXPLORATION_GESTURE_START </para><simplesectsep></simplesectsep><para>TYPE_TOUCH_EXPLORATION_GESTURE_END </para><simplesectsep></simplesectsep><para>TYPE_WINDOW_CONTENT_CHANGED </para><simplesectsep></simplesectsep><para>TYPE_VIEW_SCROLLED </para><simplesectsep></simplesectsep><para>TYPE_VIEW_TEXT_SELECTION_CHANGED </para><simplesectsep></simplesectsep><para>TYPE_ANNOUNCEMENT </para><simplesectsep></simplesectsep><para>TYPE_VIEW_TEXT_TRAVERSED_AT_MOVEMENT_GRANULARITY </para><simplesectsep></simplesectsep><para>TYPE_GESTURE_DETECTION_START </para><simplesectsep></simplesectsep><para>TYPE_GESTURE_DETECTION_END </para><simplesectsep></simplesectsep><para>TYPE_TOUCH_INTERACTION_START </para><simplesectsep></simplesectsep><para>TYPE_TOUCH_INTERACTION_END </para></para>        
				/// </summary>
				/// <java-name>
				/// TYPES_ALL_MASK
				/// </java-name>
				[Dot42.DexImport("TYPES_ALL_MASK", "I", AccessFlags = 25)]
				public const int TYPES_ALL_MASK = -1;
				/// <summary>
				/// <para><para>Parcelable.Creator </para></para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Accessibility.AccessibilityEvent> CREATOR;
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityEvent() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the number of records contained in the event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of records. </para>
				/// </returns>
				/// <java-name>
				/// getRecordCount
				/// </java-name>
				[Dot42.DexImport("getRecordCount", "()I", AccessFlags = 1)]
				public int GetRecordCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Appends an AccessibilityRecord to the end of event records.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// appendRecord
				/// </java-name>
				[Dot42.DexImport("appendRecord", "(Landroid/view/accessibility/AccessibilityRecord;)V", AccessFlags = 1)]
				public void AppendRecord(global::Android.View.Accessibility.AccessibilityRecord record) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the record at a given index.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The record at the specified index. </para>
				/// </returns>
				/// <java-name>
				/// getRecord
				/// </java-name>
				[Dot42.DexImport("getRecord", "(I)Landroid/view/accessibility/AccessibilityRecord;", AccessFlags = 1)]
				public global::Android.View.Accessibility.AccessibilityRecord GetRecord(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityRecord);
				}

				/// <summary>
				/// <para>Gets the event type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The event type. </para>
				/// </returns>
				/// <java-name>
				/// getEventType
				/// </java-name>
				[Dot42.DexImport("getEventType", "()I", AccessFlags = 1)]
				public int GetEventType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getContentChangeTypes
				/// </java-name>
				[Dot42.DexImport("getContentChangeTypes", "()I", AccessFlags = 1)]
				public int GetContentChangeTypes() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setContentChangeTypes
				/// </java-name>
				[Dot42.DexImport("setContentChangeTypes", "(I)V", AccessFlags = 1)]
				public void SetContentChangeTypes(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the event type.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEventType
				/// </java-name>
				[Dot42.DexImport("setEventType", "(I)V", AccessFlags = 1)]
				public void SetEventType(int eventType) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the time in which this event was sent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The event time. </para>
				/// </returns>
				/// <java-name>
				/// getEventTime
				/// </java-name>
				[Dot42.DexImport("getEventTime", "()J", AccessFlags = 1)]
				public long GetEventTime() /* MethodBuilder.Create */ 
				{
						return default(long);
				}

				/// <summary>
				/// <para>Sets the time in which this event was sent.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEventTime
				/// </java-name>
				[Dot42.DexImport("setEventTime", "(J)V", AccessFlags = 1)]
				public void SetEventTime(long eventTime) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the package name of the source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The package name. </para>
				/// </returns>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public global::Java.Lang.ICharSequence GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the package name of the source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPackageName
				/// </java-name>
				[Dot42.DexImport("setPackageName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public void SetPackageName(global::Java.Lang.ICharSequence packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the movement granularity that was traversed.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMovementGranularity
				/// </java-name>
				[Dot42.DexImport("setMovementGranularity", "(I)V", AccessFlags = 1)]
				public void SetMovementGranularity(int granularity) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the movement granularity that was traversed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The granularity. </para>
				/// </returns>
				/// <java-name>
				/// getMovementGranularity
				/// </java-name>
				[Dot42.DexImport("getMovementGranularity", "()I", AccessFlags = 1)]
				public int GetMovementGranularity() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the performed action that triggered this event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAction
				/// </java-name>
				[Dot42.DexImport("setAction", "(I)V", AccessFlags = 1)]
				public void SetAction(int action) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the performed action that triggered this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The action. </para>
				/// </returns>
				/// <java-name>
				/// getAction
				/// </java-name>
				[Dot42.DexImport("getAction", "()I", AccessFlags = 1)]
				public int GetAction() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Returns a cached instance if such is available or a new one is instantiated with its type property set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(I)Landroid/view/accessibility/AccessibilityEvent;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityEvent Obtain(int eventType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityEvent);
				}

				/// <summary>
				/// <para>Returns a cached instance if such is available or a new one is instantiated with its type property set.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityEvent;)Landroid/view/accessibility/Acce" +
    "ssibilityEvent;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityEvent Obtain(global::Android.View.Accessibility.AccessibilityEvent eventType) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityEvent);
				}

				/// <summary>
				/// <para>Returns a cached instance if such is available or a new one is instantiated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityEvent;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityEvent Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityEvent);
				}

				/// <summary>
				/// <para>Recycles an instance back to be reused. </para><para><b>Note: You must not touch the object after calling this function.</b> </para><para></para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public override void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Creates a new instance from a Parcel.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// initFromParcel
				/// </java-name>
				[Dot42.DexImport("initFromParcel", "(Landroid/os/Parcel;)V", AccessFlags = 1)]
				public void InitFromParcel(global::Android.Os.Parcel parcel) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Flatten this object in to a Parcel.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public void WriteToParcel(global::Android.Os.Parcel parcel, int flags) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable.</para>
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
				/// <para>Returns the string representation of an event type. For example, TYPE_VIEW_CLICKED is represented by the string TYPE_VIEW_CLICKED.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The string representation. </para>
				/// </returns>
				/// <java-name>
				/// eventTypeToString
				/// </java-name>
				[Dot42.DexImport("eventTypeToString", "(I)Ljava/lang/String;", AccessFlags = 9)]
				public static string EventTypeToString(int eventType) /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the number of records contained in the event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of records. </para>
				/// </returns>
				/// <java-name>
				/// getRecordCount
				/// </java-name>
				public int RecordCount
				{
				[Dot42.DexImport("getRecordCount", "()I", AccessFlags = 1)]
						get{ return GetRecordCount(); }
				}

				/// <summary>
				/// <para>Gets the event type.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The event type. </para>
				/// </returns>
				/// <java-name>
				/// getEventType
				/// </java-name>
				public int EventType
				{
				[Dot42.DexImport("getEventType", "()I", AccessFlags = 1)]
						get{ return GetEventType(); }
				[Dot42.DexImport("setEventType", "(I)V", AccessFlags = 1)]
						set{ SetEventType(value); }
				}

				/// <java-name>
				/// getContentChangeTypes
				/// </java-name>
				public int ContentChangeTypes
				{
				[Dot42.DexImport("getContentChangeTypes", "()I", AccessFlags = 1)]
						get{ return GetContentChangeTypes(); }
				[Dot42.DexImport("setContentChangeTypes", "(I)V", AccessFlags = 1)]
						set{ SetContentChangeTypes(value); }
				}

				/// <summary>
				/// <para>Gets the time in which this event was sent.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The event time. </para>
				/// </returns>
				/// <java-name>
				/// getEventTime
				/// </java-name>
				public long EventTime
				{
				[Dot42.DexImport("getEventTime", "()J", AccessFlags = 1)]
						get{ return GetEventTime(); }
				[Dot42.DexImport("setEventTime", "(J)V", AccessFlags = 1)]
						set{ SetEventTime(value); }
				}

				/// <summary>
				/// <para>Gets the package name of the source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The package name. </para>
				/// </returns>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				public global::Java.Lang.ICharSequence PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				[Dot42.DexImport("setPackageName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetPackageName(value); }
				}

				/// <summary>
				/// <para>Gets the movement granularity that was traversed.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The granularity. </para>
				/// </returns>
				/// <java-name>
				/// getMovementGranularity
				/// </java-name>
				public int MovementGranularity
				{
				[Dot42.DexImport("getMovementGranularity", "()I", AccessFlags = 1)]
						get{ return GetMovementGranularity(); }
				[Dot42.DexImport("setMovementGranularity", "(I)V", AccessFlags = 1)]
						set{ SetMovementGranularity(value); }
				}

				/// <summary>
				/// <para>Gets the performed action that triggered this event.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The action. </para>
				/// </returns>
				/// <java-name>
				/// getAction
				/// </java-name>
				public int Action
				{
				[Dot42.DexImport("getAction", "()I", AccessFlags = 1)]
						get{ return GetAction(); }
				[Dot42.DexImport("setAction", "(I)V", AccessFlags = 1)]
						set{ SetAction(value); }
				}

		}

		/// <summary>
		/// <para>Represents a record in an AccessibilityEvent and contains information about state change of its source android.view.View. When a view fires an accessibility event it requests from its parent to dispatch the constructed event. The parent may optionally append a record for itself for providing more context to android.accessibilityservice.AccessibilityServices. Hence, accessibility services can facilitate additional accessibility records to enhance feedback. </para><para>Once the accessibility event containing a record is dispatched the record is made immutable and calling a state mutation method generates an error. </para><para><b>Note:</b> Not all properties are applicable to all accessibility event types. For detailed information please refer to AccessibilityEvent. </para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about creating and processing AccessibilityRecords, read the  developer guide.</para><para> </para><para><para>AccessibilityEvent </para><simplesectsep></simplesectsep><para>AccessibilityManager </para><simplesectsep></simplesectsep><para>android.accessibilityservice.AccessibilityService </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo </para></para>    
		/// </summary>
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

				/// <summary>
				/// <para>Sets the event source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetSource(global::Android.View.View source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the source to be a virtual descendant of the given <code>root</code>. If <code>virtualDescendantId</code> equals to View#NO_ID the root is set as the source. </para><para>A virtual descendant is an imaginary View that is reported as a part of the view hierarchy for accessibility purposes. This enables custom views that draw complex content to report them selves as a tree of virtual views, thus conveying their logical structure. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void SetSource(global::Android.View.View root, int virtualDescendantId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the AccessibilityNodeInfo of the event source. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The info of the source. </para>
				/// </returns>
				/// <java-name>
				/// getSource
				/// </java-name>
				[Dot42.DexImport("getSource", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo GetSource() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Gets the id of the window from which the event comes from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The window id. </para>
				/// </returns>
				/// <java-name>
				/// getWindowId
				/// </java-name>
				[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
				public virtual int GetWindowId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets if the source is checked.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the view is checked, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isChecked
				/// </java-name>
				[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
				public virtual bool IsChecked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets if the source is checked.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChecked(bool isChecked) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets if the source is enabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the view is enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets if the source is enabled.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnabled(bool isEnabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets if the source is a password field.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the view is a password field, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isPassword
				/// </java-name>
				[Dot42.DexImport("isPassword", "()Z", AccessFlags = 1)]
				public virtual bool IsPassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets if the source is a password field.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Z)V", AccessFlags = 1)]
				public virtual void SetPassword(bool isPassword) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets if the source is taking the entire screen.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the source is full screen, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isFullScreen
				/// </java-name>
				[Dot42.DexImport("isFullScreen", "()Z", AccessFlags = 1)]
				public virtual bool IsFullScreen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets if the source is taking the entire screen.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFullScreen
				/// </java-name>
				[Dot42.DexImport("setFullScreen", "(Z)V", AccessFlags = 1)]
				public virtual void SetFullScreen(bool isFullScreen) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets if the source is scrollable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the source is scrollable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isScrollable
				/// </java-name>
				[Dot42.DexImport("isScrollable", "()Z", AccessFlags = 1)]
				public virtual bool IsScrollable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets if the source is scrollable.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setScrollable
				/// </java-name>
				[Dot42.DexImport("setScrollable", "(Z)V", AccessFlags = 1)]
				public virtual void SetScrollable(bool scrollable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the number of items that can be visited.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of items. </para>
				/// </returns>
				/// <java-name>
				/// getItemCount
				/// </java-name>
				[Dot42.DexImport("getItemCount", "()I", AccessFlags = 1)]
				public virtual int GetItemCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the number of items that can be visited.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setItemCount
				/// </java-name>
				[Dot42.DexImport("setItemCount", "(I)V", AccessFlags = 1)]
				public virtual void SetItemCount(int itemCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the index of the source in the list of items the can be visited.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current item index. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentItemIndex
				/// </java-name>
				[Dot42.DexImport("getCurrentItemIndex", "()I", AccessFlags = 1)]
				public virtual int GetCurrentItemIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the index of the source in the list of items that can be visited.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCurrentItemIndex
				/// </java-name>
				[Dot42.DexImport("setCurrentItemIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetCurrentItemIndex(int currentItemIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the index of the first character of the changed sequence, or the beginning of a text selection or the index of the first visible item when scrolling.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The index of the first character or selection start or the first visible item. </para>
				/// </returns>
				/// <java-name>
				/// getFromIndex
				/// </java-name>
				[Dot42.DexImport("getFromIndex", "()I", AccessFlags = 1)]
				public virtual int GetFromIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the index of the first character of the changed sequence or the beginning of a text selection or the index of the first visible item when scrolling.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFromIndex
				/// </java-name>
				[Dot42.DexImport("setFromIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetFromIndex(int fromIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the index of text selection end or the index of the last visible item when scrolling.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The index of selection end or last item index. </para>
				/// </returns>
				/// <java-name>
				/// getToIndex
				/// </java-name>
				[Dot42.DexImport("getToIndex", "()I", AccessFlags = 1)]
				public virtual int GetToIndex() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the index of text selection end or the index of the last visible item when scrolling.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setToIndex
				/// </java-name>
				[Dot42.DexImport("setToIndex", "(I)V", AccessFlags = 1)]
				public virtual void SetToIndex(int toIndex) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the scroll offset of the source left edge in pixels.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The scroll. </para>
				/// </returns>
				/// <java-name>
				/// getScrollX
				/// </java-name>
				[Dot42.DexImport("getScrollX", "()I", AccessFlags = 1)]
				public virtual int GetScrollX() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the scroll offset of the source left edge in pixels.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setScrollX
				/// </java-name>
				[Dot42.DexImport("setScrollX", "(I)V", AccessFlags = 1)]
				public virtual void SetScrollX(int scrollX) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the scroll offset of the source top edge in pixels.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The scroll. </para>
				/// </returns>
				/// <java-name>
				/// getScrollY
				/// </java-name>
				[Dot42.DexImport("getScrollY", "()I", AccessFlags = 1)]
				public virtual int GetScrollY() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the scroll offset of the source top edge in pixels.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setScrollY
				/// </java-name>
				[Dot42.DexImport("setScrollY", "(I)V", AccessFlags = 1)]
				public virtual void SetScrollY(int scrollY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the max scroll offset of the source left edge in pixels.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The max scroll. </para>
				/// </returns>
				/// <java-name>
				/// getMaxScrollX
				/// </java-name>
				[Dot42.DexImport("getMaxScrollX", "()I", AccessFlags = 1)]
				public virtual int GetMaxScrollX() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the max scroll offset of the source left edge in pixels.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxScrollX
				/// </java-name>
				[Dot42.DexImport("setMaxScrollX", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxScrollX(int maxScrollX) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the max scroll offset of the source top edge in pixels.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The max scroll. </para>
				/// </returns>
				/// <java-name>
				/// getMaxScrollY
				/// </java-name>
				[Dot42.DexImport("getMaxScrollY", "()I", AccessFlags = 1)]
				public virtual int GetMaxScrollY() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the max scroll offset of the source top edge in pixels.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMaxScrollY
				/// </java-name>
				[Dot42.DexImport("setMaxScrollY", "(I)V", AccessFlags = 1)]
				public virtual void SetMaxScrollY(int maxScrollY) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the number of added characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of added characters. </para>
				/// </returns>
				/// <java-name>
				/// getAddedCount
				/// </java-name>
				[Dot42.DexImport("getAddedCount", "()I", AccessFlags = 1)]
				public virtual int GetAddedCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the number of added characters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAddedCount
				/// </java-name>
				[Dot42.DexImport("setAddedCount", "(I)V", AccessFlags = 1)]
				public virtual void SetAddedCount(int addedCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the number of removed characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of removed characters. </para>
				/// </returns>
				/// <java-name>
				/// getRemovedCount
				/// </java-name>
				[Dot42.DexImport("getRemovedCount", "()I", AccessFlags = 1)]
				public virtual int GetRemovedCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the number of removed characters.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setRemovedCount
				/// </java-name>
				[Dot42.DexImport("setRemovedCount", "(I)V", AccessFlags = 1)]
				public virtual void SetRemovedCount(int removedCount) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the class name of the source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The class name. </para>
				/// </returns>
				/// <java-name>
				/// getClassName
				/// </java-name>
				[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetClassName() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the class name of the source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setClassName
				/// </java-name>
				[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetClassName(global::Java.Lang.ICharSequence className) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the text of the event. The index in the list represents the priority of the text. Specifically, the lower the index the higher the priority.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/CharSequence;>;")]
				public virtual global::Java.Util.IList<global::Java.Lang.ICharSequence> GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Java.Lang.ICharSequence>);
				}

				/// <summary>
				/// <para>Sets the text before a change.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text before the change. </para>
				/// </returns>
				/// <java-name>
				/// getBeforeText
				/// </java-name>
				[Dot42.DexImport("getBeforeText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetBeforeText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the text before a change.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBeforeText
				/// </java-name>
				[Dot42.DexImport("setBeforeText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetBeforeText(global::Java.Lang.ICharSequence beforeText) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the description of the source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The description. </para>
				/// </returns>
				/// <java-name>
				/// getContentDescription
				/// </java-name>
				[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetContentDescription() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the description of the source.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentDescription
				/// </java-name>
				[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetContentDescription(global::Java.Lang.ICharSequence contentDescription) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the Parcelable data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The parcelable data. </para>
				/// </returns>
				/// <java-name>
				/// getParcelableData
				/// </java-name>
				[Dot42.DexImport("getParcelableData", "()Landroid/os/Parcelable;", AccessFlags = 1)]
				public virtual global::Android.Os.IParcelable GetParcelableData() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IParcelable);
				}

				/// <summary>
				/// <para>Sets the Parcelable data of the event.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParcelableData
				/// </java-name>
				[Dot42.DexImport("setParcelableData", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
				public virtual void SetParcelableData(global::Android.Os.IParcelable parcelableData) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns a cached instance if such is available or a new one is instantiated. The instance is initialized with data from the given record.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityRecord;)Landroid/view/accessibility/Acc" +
    "essibilityRecord;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityRecord Obtain(global::Android.View.Accessibility.AccessibilityRecord record) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityRecord);
				}

				/// <summary>
				/// <para>Returns a cached instance if such is available or a new one is instantiated.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityRecord;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityRecord Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityRecord);
				}

				/// <summary>
				/// <para>Return an instance back to be reused. </para><para><b>Note:</b> You must not touch the object after calling this function.</para><para></para>        
				/// </summary>
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

				/// <summary>
				/// <para>Gets the AccessibilityNodeInfo of the event source. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The info of the source. </para>
				/// </returns>
				/// <java-name>
				/// getSource
				/// </java-name>
				public global::Android.View.Accessibility.AccessibilityNodeInfo Source
				{
				[Dot42.DexImport("getSource", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return GetSource(); }
				}

				/// <summary>
				/// <para>Gets the id of the window from which the event comes from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The window id. </para>
				/// </returns>
				/// <java-name>
				/// getWindowId
				/// </java-name>
				public int WindowId
				{
				[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
						get{ return GetWindowId(); }
				}

				/// <summary>
				/// <para>Gets the number of items that can be visited.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of items. </para>
				/// </returns>
				/// <java-name>
				/// getItemCount
				/// </java-name>
				public int ItemCount
				{
				[Dot42.DexImport("getItemCount", "()I", AccessFlags = 1)]
						get{ return GetItemCount(); }
				[Dot42.DexImport("setItemCount", "(I)V", AccessFlags = 1)]
						set{ SetItemCount(value); }
				}

				/// <summary>
				/// <para>Gets the index of the source in the list of items the can be visited.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current item index. </para>
				/// </returns>
				/// <java-name>
				/// getCurrentItemIndex
				/// </java-name>
				public int CurrentItemIndex
				{
				[Dot42.DexImport("getCurrentItemIndex", "()I", AccessFlags = 1)]
						get{ return GetCurrentItemIndex(); }
				[Dot42.DexImport("setCurrentItemIndex", "(I)V", AccessFlags = 1)]
						set{ SetCurrentItemIndex(value); }
				}

				/// <summary>
				/// <para>Gets the index of the first character of the changed sequence, or the beginning of a text selection or the index of the first visible item when scrolling.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The index of the first character or selection start or the first visible item. </para>
				/// </returns>
				/// <java-name>
				/// getFromIndex
				/// </java-name>
				public int FromIndex
				{
				[Dot42.DexImport("getFromIndex", "()I", AccessFlags = 1)]
						get{ return GetFromIndex(); }
				[Dot42.DexImport("setFromIndex", "(I)V", AccessFlags = 1)]
						set{ SetFromIndex(value); }
				}

				/// <summary>
				/// <para>Gets the index of text selection end or the index of the last visible item when scrolling.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The index of selection end or last item index. </para>
				/// </returns>
				/// <java-name>
				/// getToIndex
				/// </java-name>
				public int ToIndex
				{
				[Dot42.DexImport("getToIndex", "()I", AccessFlags = 1)]
						get{ return GetToIndex(); }
				[Dot42.DexImport("setToIndex", "(I)V", AccessFlags = 1)]
						set{ SetToIndex(value); }
				}

				/// <summary>
				/// <para>Gets the scroll offset of the source left edge in pixels.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The scroll. </para>
				/// </returns>
				/// <java-name>
				/// getScrollX
				/// </java-name>
				public int ScrollX
				{
				[Dot42.DexImport("getScrollX", "()I", AccessFlags = 1)]
						get{ return GetScrollX(); }
				[Dot42.DexImport("setScrollX", "(I)V", AccessFlags = 1)]
						set{ SetScrollX(value); }
				}

				/// <summary>
				/// <para>Gets the scroll offset of the source top edge in pixels.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The scroll. </para>
				/// </returns>
				/// <java-name>
				/// getScrollY
				/// </java-name>
				public int ScrollY
				{
				[Dot42.DexImport("getScrollY", "()I", AccessFlags = 1)]
						get{ return GetScrollY(); }
				[Dot42.DexImport("setScrollY", "(I)V", AccessFlags = 1)]
						set{ SetScrollY(value); }
				}

				/// <summary>
				/// <para>Gets the max scroll offset of the source left edge in pixels.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The max scroll. </para>
				/// </returns>
				/// <java-name>
				/// getMaxScrollX
				/// </java-name>
				public int MaxScrollX
				{
				[Dot42.DexImport("getMaxScrollX", "()I", AccessFlags = 1)]
						get{ return GetMaxScrollX(); }
				[Dot42.DexImport("setMaxScrollX", "(I)V", AccessFlags = 1)]
						set{ SetMaxScrollX(value); }
				}

				/// <summary>
				/// <para>Gets the max scroll offset of the source top edge in pixels.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The max scroll. </para>
				/// </returns>
				/// <java-name>
				/// getMaxScrollY
				/// </java-name>
				public int MaxScrollY
				{
				[Dot42.DexImport("getMaxScrollY", "()I", AccessFlags = 1)]
						get{ return GetMaxScrollY(); }
				[Dot42.DexImport("setMaxScrollY", "(I)V", AccessFlags = 1)]
						set{ SetMaxScrollY(value); }
				}

				/// <summary>
				/// <para>Gets the number of added characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of added characters. </para>
				/// </returns>
				/// <java-name>
				/// getAddedCount
				/// </java-name>
				public int AddedCount
				{
				[Dot42.DexImport("getAddedCount", "()I", AccessFlags = 1)]
						get{ return GetAddedCount(); }
				[Dot42.DexImport("setAddedCount", "(I)V", AccessFlags = 1)]
						set{ SetAddedCount(value); }
				}

				/// <summary>
				/// <para>Gets the number of removed characters.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The number of removed characters. </para>
				/// </returns>
				/// <java-name>
				/// getRemovedCount
				/// </java-name>
				public int RemovedCount
				{
				[Dot42.DexImport("getRemovedCount", "()I", AccessFlags = 1)]
						get{ return GetRemovedCount(); }
				[Dot42.DexImport("setRemovedCount", "(I)V", AccessFlags = 1)]
						set{ SetRemovedCount(value); }
				}

				/// <summary>
				/// <para>Gets the class name of the source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The class name. </para>
				/// </returns>
				/// <java-name>
				/// getClassName
				/// </java-name>
				public global::Java.Lang.ICharSequence ClassName
				{
				[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetClassName(); }
				[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetClassName(value); }
				}

				/// <summary>
				/// <para>Gets the text of the event. The index in the list represents the priority of the text. Specifically, the lower the index the higher the priority.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Util.IList<global::Java.Lang.ICharSequence> Text
				{
				[Dot42.DexImport("getText", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/CharSequence;>;")]
						get{ return GetText(); }
				}

				/// <summary>
				/// <para>Sets the text before a change.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text before the change. </para>
				/// </returns>
				/// <java-name>
				/// getBeforeText
				/// </java-name>
				public global::Java.Lang.ICharSequence BeforeText
				{
				[Dot42.DexImport("getBeforeText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetBeforeText(); }
				[Dot42.DexImport("setBeforeText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetBeforeText(value); }
				}

				/// <summary>
				/// <para>Gets the description of the source.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The description. </para>
				/// </returns>
				/// <java-name>
				/// getContentDescription
				/// </java-name>
				public global::Java.Lang.ICharSequence ContentDescription
				{
				[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetContentDescription(); }
				[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetContentDescription(value); }
				}

				/// <summary>
				/// <para>Gets the Parcelable data.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The parcelable data. </para>
				/// </returns>
				/// <java-name>
				/// getParcelableData
				/// </java-name>
				public global::Android.Os.IParcelable ParcelableData
				{
				[Dot42.DexImport("getParcelableData", "()Landroid/os/Parcelable;", AccessFlags = 1)]
						get{ return GetParcelableData(); }
				[Dot42.DexImport("setParcelableData", "(Landroid/os/Parcelable;)V", AccessFlags = 1)]
						set{ SetParcelableData(value); }
				}

		}

		/// <summary>
		/// <para>This class represents a node of the window content as well as actions that can be requested from its source. From the point of view of an android.accessibilityservice.AccessibilityService a window content is presented as tree of accessibility node info which may or may not map one-to-one to the view hierarchy. In other words, a custom view is free to report itself as a tree of accessibility node info. </para><para>Once an accessibility node info is delivered to an accessibility service it is made immutable and calling a state mutation method generates an error. </para><para>Please refer to android.accessibilityservice.AccessibilityService for details about how to obtain a handle to window content as a tree of accessibility node info as well as familiarizing with the security model. </para><para> <h3>Developer Guides</h3></para><para> </para><para>For more information about making applications accessible, read the  developer guide.</para><para> </para><para><para>android.accessibilityservice.AccessibilityService </para><simplesectsep></simplesectsep><para>AccessibilityEvent </para><simplesectsep></simplesectsep><para>AccessibilityManager </para></para>    
		/// </summary>
		/// <java-name>
		/// android/view/accessibility/AccessibilityNodeInfo
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityNodeInfo", AccessFlags = 33)]
		public partial class AccessibilityNodeInfo : global::Android.Os.IParcelable
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>Action that gives input focus to the node. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_FOCUS
				/// </java-name>
				[Dot42.DexImport("ACTION_FOCUS", "I", AccessFlags = 25)]
				public const int ACTION_FOCUS = 1;
				/// <summary>
				/// <para>Action that clears input focus of the node. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CLEAR_FOCUS
				/// </java-name>
				[Dot42.DexImport("ACTION_CLEAR_FOCUS", "I", AccessFlags = 25)]
				public const int ACTION_CLEAR_FOCUS = 2;
				/// <summary>
				/// <para>Action that selects the node. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SELECT
				/// </java-name>
				[Dot42.DexImport("ACTION_SELECT", "I", AccessFlags = 25)]
				public const int ACTION_SELECT = 4;
				/// <summary>
				/// <para>Action that unselects the node. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CLEAR_SELECTION
				/// </java-name>
				[Dot42.DexImport("ACTION_CLEAR_SELECTION", "I", AccessFlags = 25)]
				public const int ACTION_CLEAR_SELECTION = 8;
				/// <summary>
				/// <para>Action that clicks on the node info. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CLICK
				/// </java-name>
				[Dot42.DexImport("ACTION_CLICK", "I", AccessFlags = 25)]
				public const int ACTION_CLICK = 16;
				/// <summary>
				/// <para>Action that long clicks on the node. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_LONG_CLICK
				/// </java-name>
				[Dot42.DexImport("ACTION_LONG_CLICK", "I", AccessFlags = 25)]
				public const int ACTION_LONG_CLICK = 32;
				/// <summary>
				/// <para>Action that gives accessibility focus to the node. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ACCESSIBILITY_FOCUS
				/// </java-name>
				[Dot42.DexImport("ACTION_ACCESSIBILITY_FOCUS", "I", AccessFlags = 25)]
				public const int ACTION_ACCESSIBILITY_FOCUS = 64;
				/// <summary>
				/// <para>Action that clears accessibility focus of the node. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CLEAR_ACCESSIBILITY_FOCUS
				/// </java-name>
				[Dot42.DexImport("ACTION_CLEAR_ACCESSIBILITY_FOCUS", "I", AccessFlags = 25)]
				public const int ACTION_CLEAR_ACCESSIBILITY_FOCUS = 128;
				/// <summary>
				/// <para>Action that requests to go to the next entity in this node's text at a given movement granularity. For example, move to the next character, word, etc. </para><para><b>Arguments:</b> ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT&lt;, ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN<br></br> <b>Example:</b> Move to the previous character and do not extend selection. <code><pre></pre></code></para><para><code><pre>
				///          Bundle arguments = new Bundle();
				///          arguments.putInt(AccessibilityNodeInfo.ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT,
				///                  AccessibilityNodeInfo.MOVEMENT_GRANULARITY_CHARACTER);
				///          arguments.putBoolean(AccessibilityNodeInfo.ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN,
				///                  false);
				///          info.performAction(AccessibilityNodeInfo.ACTION_NEXT_AT_MOVEMENT_GRANULARITY, arguments);
				///        </pre></code></para><para><code> </code></para><para><code></code></para><para><code> <para>ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT </para><simplesectsep></simplesectsep><para>ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN</para><simplesectsep></simplesectsep><para>setMovementGranularities(int) </para><simplesectsep></simplesectsep><para>getMovementGranularities()</para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_CHARACTER </para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_WORD </para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_LINE </para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_PARAGRAPH </para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_PAGE </para></code></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NEXT_AT_MOVEMENT_GRANULARITY
				/// </java-name>
				[Dot42.DexImport("ACTION_NEXT_AT_MOVEMENT_GRANULARITY", "I", AccessFlags = 25)]
				public const int ACTION_NEXT_AT_MOVEMENT_GRANULARITY = 256;
				/// <summary>
				/// <para>Action that requests to go to the previous entity in this node's text at a given movement granularity. For example, move to the next character, word, etc. </para><para><b>Arguments:</b> ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT&lt;, ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN<br></br> <b>Example:</b> Move to the next character and do not extend selection. <code><pre></pre></code></para><para><code><pre>
				///          Bundle arguments = new Bundle();
				///          arguments.putInt(AccessibilityNodeInfo.ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT,
				///                  AccessibilityNodeInfo.MOVEMENT_GRANULARITY_CHARACTER);
				///          arguments.putBoolean(AccessibilityNodeInfo.ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN,
				///                  false);
				///          info.performAction(AccessibilityNodeInfo.ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY,
				///                  arguments);
				///        </pre></code></para><para><code> </code></para><para><code></code></para><para><code> <para>ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT </para><simplesectsep></simplesectsep><para>ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN</para><simplesectsep></simplesectsep><para>setMovementGranularities(int) </para><simplesectsep></simplesectsep><para>getMovementGranularities()</para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_CHARACTER </para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_WORD </para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_LINE </para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_PARAGRAPH </para><simplesectsep></simplesectsep><para>MOVEMENT_GRANULARITY_PAGE </para></code></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY
				/// </java-name>
				[Dot42.DexImport("ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY", "I", AccessFlags = 25)]
				public const int ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY = 512;
				/// <summary>
				/// <para>Action to move to the next HTML element of a given type. For example, move to the BUTTON, INPUT, TABLE, etc. </para><para><b>Arguments:</b> ACTION_ARGUMENT_HTML_ELEMENT_STRING<br></br> <b>Example:</b> <code><pre></pre></code></para><para><code><pre>
				///          Bundle arguments = new Bundle();
				///          arguments.putString(AccessibilityNodeInfo.ACTION_ARGUMENT_HTML_ELEMENT_STRING, "BUTTON");
				///          info.performAction(AccessibilityNodeInfo.ACTION_NEXT_HTML_ELEMENT, arguments);
				///        </pre></code></para><para><code> </code></para><para><code> </code></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_NEXT_HTML_ELEMENT
				/// </java-name>
				[Dot42.DexImport("ACTION_NEXT_HTML_ELEMENT", "I", AccessFlags = 25)]
				public const int ACTION_NEXT_HTML_ELEMENT = 1024;
				/// <summary>
				/// <para>Action to move to the previous HTML element of a given type. For example, move to the BUTTON, INPUT, TABLE, etc. </para><para><b>Arguments:</b> ACTION_ARGUMENT_HTML_ELEMENT_STRING<br></br> <b>Example:</b> <code><pre></pre></code></para><para><code><pre>
				///          Bundle arguments = new Bundle();
				///          arguments.putString(AccessibilityNodeInfo.ACTION_ARGUMENT_HTML_ELEMENT_STRING, "BUTTON");
				///          info.performAction(AccessibilityNodeInfo.ACTION_PREVIOUS_HTML_ELEMENT, arguments);
				///        </pre></code></para><para><code> </code></para><para><code> </code></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PREVIOUS_HTML_ELEMENT
				/// </java-name>
				[Dot42.DexImport("ACTION_PREVIOUS_HTML_ELEMENT", "I", AccessFlags = 25)]
				public const int ACTION_PREVIOUS_HTML_ELEMENT = 2048;
				/// <summary>
				/// <para>Action to scroll the node content forward. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SCROLL_FORWARD
				/// </java-name>
				[Dot42.DexImport("ACTION_SCROLL_FORWARD", "I", AccessFlags = 25)]
				public const int ACTION_SCROLL_FORWARD = 4096;
				/// <summary>
				/// <para>Action to scroll the node content backward. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SCROLL_BACKWARD
				/// </java-name>
				[Dot42.DexImport("ACTION_SCROLL_BACKWARD", "I", AccessFlags = 25)]
				public const int ACTION_SCROLL_BACKWARD = 8192;
				/// <summary>
				/// <para>Action to copy the current selection to the clipboard. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_COPY
				/// </java-name>
				[Dot42.DexImport("ACTION_COPY", "I", AccessFlags = 25)]
				public const int ACTION_COPY = 16384;
				/// <summary>
				/// <para>Action to paste the current clipboard content. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_PASTE
				/// </java-name>
				[Dot42.DexImport("ACTION_PASTE", "I", AccessFlags = 25)]
				public const int ACTION_PASTE = 32768;
				/// <summary>
				/// <para>Action to cut the current selection and place it to the clipboard. </para>        
				/// </summary>
				/// <java-name>
				/// ACTION_CUT
				/// </java-name>
				[Dot42.DexImport("ACTION_CUT", "I", AccessFlags = 25)]
				public const int ACTION_CUT = 65536;
				/// <summary>
				/// <para>Action to set the selection. Performing this action with no arguments clears the selection. </para><para><b>Arguments:</b> ACTION_ARGUMENT_SELECTION_START_INT, ACTION_ARGUMENT_SELECTION_END_INT<br></br> <b>Example:</b> <code><pre></pre></code></para><para><code><pre>
				///          Bundle arguments = new Bundle();
				///          arguments.putInt(AccessibilityNodeInfo.ACTION_ARGUMENT_SELECTION_START_INT, 1);
				///          arguments.putInt(AccessibilityNodeInfo.ACTION_ARGUMENT_SELECTION_END_INT, 2);
				///          info.performAction(AccessibilityNodeInfo.ACTION_SET_SELECTION, arguments);
				///        </pre></code></para><para><code> </code></para><para><code></code></para><para><code> <para>ACTION_ARGUMENT_SELECTION_START_INT </para><simplesectsep></simplesectsep><para>ACTION_ARGUMENT_SELECTION_END_INT </para></code></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_SET_SELECTION
				/// </java-name>
				[Dot42.DexImport("ACTION_SET_SELECTION", "I", AccessFlags = 25)]
				public const int ACTION_SET_SELECTION = 131072;
				/// <java-name>
				/// ACTION_EXPAND
				/// </java-name>
				[Dot42.DexImport("ACTION_EXPAND", "I", AccessFlags = 25)]
				public const int ACTION_EXPAND = 262144;
				/// <java-name>
				/// ACTION_COLLAPSE
				/// </java-name>
				[Dot42.DexImport("ACTION_COLLAPSE", "I", AccessFlags = 25)]
				public const int ACTION_COLLAPSE = 524288;
				/// <java-name>
				/// ACTION_DISMISS
				/// </java-name>
				[Dot42.DexImport("ACTION_DISMISS", "I", AccessFlags = 25)]
				public const int ACTION_DISMISS = 1048576;
				/// <summary>
				/// <para>Argument for which movement granularity to be used when traversing the node text. </para><para><b>Type:</b> int<br></br> <b>Actions:</b> ACTION_NEXT_AT_MOVEMENT_GRANULARITY, ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY </para><para><para>ACTION_NEXT_AT_MOVEMENT_GRANULARITY </para><simplesectsep></simplesectsep><para>ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT
				/// </java-name>
				[Dot42.DexImport("ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT = "ACTION_ARGUMENT_MOVEMENT_GRANULARITY_INT";
				/// <summary>
				/// <para>Argument for which HTML element to get moving to the next/previous HTML element. </para><para><b>Type:</b> String<br></br> <b>Actions:</b> ACTION_NEXT_HTML_ELEMENT, ACTION_PREVIOUS_HTML_ELEMENT </para><para><para>ACTION_NEXT_HTML_ELEMENT </para><simplesectsep></simplesectsep><para>ACTION_PREVIOUS_HTML_ELEMENT </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ARGUMENT_HTML_ELEMENT_STRING
				/// </java-name>
				[Dot42.DexImport("ACTION_ARGUMENT_HTML_ELEMENT_STRING", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ARGUMENT_HTML_ELEMENT_STRING = "ACTION_ARGUMENT_HTML_ELEMENT_STRING";
				/// <summary>
				/// <para>Argument for whether when moving at granularity to extend the selection or to move it otherwise. </para><para><b>Type:</b> boolean<br></br> <b>Actions:</b> ACTION_NEXT_AT_MOVEMENT_GRANULARITY, ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY </para><para><para>ACTION_NEXT_AT_MOVEMENT_GRANULARITY </para><simplesectsep></simplesectsep><para>ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN
				/// </java-name>
				[Dot42.DexImport("ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN = "ACTION_ARGUMENT_EXTEND_SELECTION_BOOLEAN";
				/// <summary>
				/// <para>Argument for specifying the selection start. </para><para><b>Type:</b> int<br></br> <b>Actions:</b> ACTION_SET_SELECTION </para><para><para>ACTION_SET_SELECTION </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ARGUMENT_SELECTION_START_INT
				/// </java-name>
				[Dot42.DexImport("ACTION_ARGUMENT_SELECTION_START_INT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ARGUMENT_SELECTION_START_INT = "ACTION_ARGUMENT_SELECTION_START_INT";
				/// <summary>
				/// <para>Argument for specifying the selection end. </para><para><b>Type:</b> int<br></br> <b>Actions:</b> ACTION_SET_SELECTION </para><para><para>ACTION_SET_SELECTION </para></para>        
				/// </summary>
				/// <java-name>
				/// ACTION_ARGUMENT_SELECTION_END_INT
				/// </java-name>
				[Dot42.DexImport("ACTION_ARGUMENT_SELECTION_END_INT", "Ljava/lang/String;", AccessFlags = 25)]
				public const string ACTION_ARGUMENT_SELECTION_END_INT = "ACTION_ARGUMENT_SELECTION_END_INT";
				/// <summary>
				/// <para>The input focus. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_INPUT
				/// </java-name>
				[Dot42.DexImport("FOCUS_INPUT", "I", AccessFlags = 25)]
				public const int FOCUS_INPUT = 1;
				/// <summary>
				/// <para>The accessibility focus. </para>        
				/// </summary>
				/// <java-name>
				/// FOCUS_ACCESSIBILITY
				/// </java-name>
				[Dot42.DexImport("FOCUS_ACCESSIBILITY", "I", AccessFlags = 25)]
				public const int FOCUS_ACCESSIBILITY = 2;
				/// <summary>
				/// <para>Movement granularity bit for traversing the text of a node by character. </para>        
				/// </summary>
				/// <java-name>
				/// MOVEMENT_GRANULARITY_CHARACTER
				/// </java-name>
				[Dot42.DexImport("MOVEMENT_GRANULARITY_CHARACTER", "I", AccessFlags = 25)]
				public const int MOVEMENT_GRANULARITY_CHARACTER = 1;
				/// <summary>
				/// <para>Movement granularity bit for traversing the text of a node by word. </para>        
				/// </summary>
				/// <java-name>
				/// MOVEMENT_GRANULARITY_WORD
				/// </java-name>
				[Dot42.DexImport("MOVEMENT_GRANULARITY_WORD", "I", AccessFlags = 25)]
				public const int MOVEMENT_GRANULARITY_WORD = 2;
				/// <summary>
				/// <para>Movement granularity bit for traversing the text of a node by line. </para>        
				/// </summary>
				/// <java-name>
				/// MOVEMENT_GRANULARITY_LINE
				/// </java-name>
				[Dot42.DexImport("MOVEMENT_GRANULARITY_LINE", "I", AccessFlags = 25)]
				public const int MOVEMENT_GRANULARITY_LINE = 4;
				/// <summary>
				/// <para>Movement granularity bit for traversing the text of a node by paragraph. </para>        
				/// </summary>
				/// <java-name>
				/// MOVEMENT_GRANULARITY_PARAGRAPH
				/// </java-name>
				[Dot42.DexImport("MOVEMENT_GRANULARITY_PARAGRAPH", "I", AccessFlags = 25)]
				public const int MOVEMENT_GRANULARITY_PARAGRAPH = 8;
				/// <summary>
				/// <para>Movement granularity bit for traversing the text of a node by page. </para>        
				/// </summary>
				/// <java-name>
				/// MOVEMENT_GRANULARITY_PAGE
				/// </java-name>
				[Dot42.DexImport("MOVEMENT_GRANULARITY_PAGE", "I", AccessFlags = 25)]
				public const int MOVEMENT_GRANULARITY_PAGE = 16;
				/// <summary>
				/// <para><para>Parcelable.Creator </para></para>        
				/// </summary>
				/// <java-name>
				/// CREATOR
				/// </java-name>
				[Dot42.DexImport("CREATOR", "Landroid/os/Parcelable$Creator;", AccessFlags = 25)]
				public static readonly global::Android.Os.IParcelable_ICreator<global::Android.View.Accessibility.AccessibilityNodeInfo> CREATOR;
				/// <summary>
				/// <para>Hide constructor from clients. </para>        
				/// </summary>
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal AccessibilityNodeInfo() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the source. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetSource(global::Android.View.View source) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the source to be a virtual descendant of the given <code>root</code>. If <code>virtualDescendantId</code> is View#NO_ID the root is set as the source. </para><para>A virtual descendant is an imaginary View that is reported as a part of the view hierarchy for accessibility purposes. This enables custom views that draw complex content to report themselves as a tree of virtual views, thus conveying their logical structure. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSource
				/// </java-name>
				[Dot42.DexImport("setSource", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void SetSource(global::Android.View.View root, int virtualDescendantId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Find the view that has the specified focus type. The search starts from the view represented by this node info.</para><para><para>FOCUS_INPUT </para><simplesectsep></simplesectsep><para>FOCUS_ACCESSIBILITY </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The node info of the focused view or null.</para>
				/// </returns>
				/// <java-name>
				/// findFocus
				/// </java-name>
				[Dot42.DexImport("findFocus", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo FindFocus(int focus) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Searches for the nearest view in the specified direction that can take the input focus.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The node info for the view that can take accessibility focus. </para>
				/// </returns>
				/// <java-name>
				/// focusSearch
				/// </java-name>
				[Dot42.DexImport("focusSearch", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo FocusSearch(int direction) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Gets the id of the window from which the info comes from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The window id. </para>
				/// </returns>
				/// <java-name>
				/// getWindowId
				/// </java-name>
				[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
				public virtual int GetWindowId() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Refreshes this info with the latest state of the view it represents. </para><para><b>Note:</b> If this method returns false this info is obsolete since it represents a view that is no longer in the view tree and should be recycled. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the refresh succeeded. </para>
				/// </returns>
				/// <java-name>
				/// refresh
				/// </java-name>
				[Dot42.DexImport("refresh", "()Z", AccessFlags = 1)]
				public virtual bool Refresh() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Gets the number of children.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The child count. </para>
				/// </returns>
				/// <java-name>
				/// getChildCount
				/// </java-name>
				[Dot42.DexImport("getChildCount", "()I", AccessFlags = 1)]
				public virtual int GetChildCount() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Get the child at given index. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The child node.</para>
				/// </returns>
				/// <java-name>
				/// getChild
				/// </java-name>
				[Dot42.DexImport("getChild", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo GetChild(int index) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Adds a child. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// addChild
				/// </java-name>
				[Dot42.DexImport("addChild", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void AddChild(global::Android.View.View child) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a virtual child which is a descendant of the given <code>root</code>. If <code>virtualDescendantId</code> is View#NO_ID the root is added as a child. </para><para>A virtual descendant is an imaginary View that is reported as a part of the view hierarchy for accessibility purposes. This enables custom views that draw complex content to report them selves as a tree of virtual views, thus conveying their logical structure. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// addChild
				/// </java-name>
				[Dot42.DexImport("addChild", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void AddChild(global::Android.View.View root, int virtualDescendantId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the actions that can be performed on the node.</para><para><para>AccessibilityNodeInfo::ACTION_FOCUS </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_CLEAR_FOCUS </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_SELECT </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_CLEAR_SELECTION </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_ACCESSIBILITY_FOCUS </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_CLEAR_ACCESSIBILITY_FOCUS </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_CLICK </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_LONG_CLICK </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_NEXT_AT_MOVEMENT_GRANULARITY </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_NEXT_HTML_ELEMENT </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_PREVIOUS_HTML_ELEMENT </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_SCROLL_FORWARD </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_SCROLL_BACKWARD </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The bit mask of with actions.</para>
				/// </returns>
				/// <java-name>
				/// getActions
				/// </java-name>
				[Dot42.DexImport("getActions", "()I", AccessFlags = 1)]
				public virtual int GetActions() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Adds an action that can be performed on the node. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// addAction
				/// </java-name>
				[Dot42.DexImport("addAction", "(I)V", AccessFlags = 1)]
				public virtual void AddAction(int action) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the movement granularities for traversing the text of this node. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setMovementGranularities
				/// </java-name>
				[Dot42.DexImport("setMovementGranularities", "(I)V", AccessFlags = 1)]
				public virtual void SetMovementGranularities(int granularities) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the movement granularities for traversing the text of this node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The bit mask with granularities. </para>
				/// </returns>
				/// <java-name>
				/// getMovementGranularities
				/// </java-name>
				[Dot42.DexImport("getMovementGranularities", "()I", AccessFlags = 1)]
				public virtual int GetMovementGranularities() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Performs an action on the node. </para><para><b>Note:</b> An action can be performed only if the request is made from an android.accessibilityservice.AccessibilityService. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the action was performed.</para>
				/// </returns>
				/// <java-name>
				/// performAction
				/// </java-name>
				[Dot42.DexImport("performAction", "(I)Z", AccessFlags = 1)]
				public virtual bool PerformAction(int action) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Performs an action on the node. </para><para><b>Note:</b> An action can be performed only if the request is made from an android.accessibilityservice.AccessibilityService. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the action was performed.</para>
				/// </returns>
				/// <java-name>
				/// performAction
				/// </java-name>
				[Dot42.DexImport("performAction", "(ILandroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool PerformAction(int action, global::Android.Os.Bundle arguments) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Finds AccessibilityNodeInfos by text. The match is case insensitive containment. The search is relative to this info i.e. this info is the root of the traversed tree.</para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A list of node info. </para>
				/// </returns>
				/// <java-name>
				/// findAccessibilityNodeInfosByText
				/// </java-name>
				[Dot42.DexImport("findAccessibilityNodeInfosByText", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/List<Landroid/view/accessibility/AccessibilityNode" +
    "Info;>;")]
				public virtual global::Java.Util.IList<global::Android.View.Accessibility.AccessibilityNodeInfo> FindAccessibilityNodeInfosByText(string text) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.View.Accessibility.AccessibilityNodeInfo>);
				}

				/// <summary>
				/// <para>Finds AccessibilityNodeInfos by the fully qualified view id's resource name where a fully qualified id is of the from "package:id/id_resource_name". For example, if the target application's package is "foo.bar" and the id resource name is "baz", the fully qualified resource id is "foo.bar:id/baz".</para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para><b>Note:</b> The primary usage of this API is for UI test automation and in order to report the fully qualified view id if an AccessibilityNodeInfo the client has to set the AccessibilityServiceInfo#FLAG_REPORT_VIEW_IDS flag when configuring his android.accessibilityservice.AccessibilityService. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>A list of node info. </para>
				/// </returns>
				/// <java-name>
				/// findAccessibilityNodeInfosByViewId
				/// </java-name>
				[Dot42.DexImport("findAccessibilityNodeInfosByViewId", "(Ljava/lang/String;)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;)Ljava/util/List<Landroid/view/accessibility/AccessibilityNode" +
    "Info;>;")]
				public virtual global::Java.Util.IList<global::Android.View.Accessibility.AccessibilityNodeInfo> FindAccessibilityNodeInfosByViewId(string viewId) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.View.Accessibility.AccessibilityNodeInfo>);
				}

				/// <summary>
				/// <para>Gets the parent. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The parent. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				[Dot42.DexImport("getParent", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo GetParent() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Sets the parent. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetParent(global::Android.View.View parent) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the parent to be a virtual descendant of the given <code>root</code>. If <code>virtualDescendantId</code> equals to View#NO_ID the root is set as the parent. </para><para>A virtual descendant is an imaginary View that is reported as a part of the view hierarchy for accessibility purposes. This enables custom views that draw complex content to report them selves as a tree of virtual views, thus conveying their logical structure. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setParent
				/// </java-name>
				[Dot42.DexImport("setParent", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void SetParent(global::Android.View.View root, int virtualDescendantId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the node bounds in parent coordinates.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBoundsInParent
				/// </java-name>
				[Dot42.DexImport("getBoundsInParent", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetBoundsInParent(global::Android.Graphics.Rect outBounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the node bounds in parent coordinates. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBoundsInParent
				/// </java-name>
				[Dot42.DexImport("setBoundsInParent", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetBoundsInParent(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the node bounds in screen coordinates.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// getBoundsInScreen
				/// </java-name>
				[Dot42.DexImport("getBoundsInScreen", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void GetBoundsInScreen(global::Android.Graphics.Rect outBounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the node bounds in screen coordinates. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setBoundsInScreen
				/// </java-name>
				[Dot42.DexImport("setBoundsInScreen", "(Landroid/graphics/Rect;)V", AccessFlags = 1)]
				public virtual void SetBoundsInScreen(global::Android.Graphics.Rect bounds) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is checkable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is checkable. </para>
				/// </returns>
				/// <java-name>
				/// isCheckable
				/// </java-name>
				[Dot42.DexImport("isCheckable", "()Z", AccessFlags = 1)]
				public virtual bool IsCheckable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is checkable. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setCheckable
				/// </java-name>
				[Dot42.DexImport("setCheckable", "(Z)V", AccessFlags = 1)]
				public virtual void SetCheckable(bool checkable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is checked.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is checked. </para>
				/// </returns>
				/// <java-name>
				/// isChecked
				/// </java-name>
				[Dot42.DexImport("isChecked", "()Z", AccessFlags = 1)]
				public virtual bool IsChecked() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is checked. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setChecked
				/// </java-name>
				[Dot42.DexImport("setChecked", "(Z)V", AccessFlags = 1)]
				public virtual void SetChecked(bool @checked) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is focusable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is focusable. </para>
				/// </returns>
				/// <java-name>
				/// isFocusable
				/// </java-name>
				[Dot42.DexImport("isFocusable", "()Z", AccessFlags = 1)]
				public virtual bool IsFocusable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is focusable. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFocusable
				/// </java-name>
				[Dot42.DexImport("setFocusable", "(Z)V", AccessFlags = 1)]
				public virtual void SetFocusable(bool focusable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is focused.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is focused. </para>
				/// </returns>
				/// <java-name>
				/// isFocused
				/// </java-name>
				[Dot42.DexImport("isFocused", "()Z", AccessFlags = 1)]
				public virtual bool IsFocused() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is focused. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFocused
				/// </java-name>
				[Dot42.DexImport("setFocused", "(Z)V", AccessFlags = 1)]
				public virtual void SetFocused(bool focused) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets whether this node is visible to the user.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>Whether the node is visible to the user. </para>
				/// </returns>
				/// <java-name>
				/// isVisibleToUser
				/// </java-name>
				[Dot42.DexImport("isVisibleToUser", "()Z", AccessFlags = 1)]
				public virtual bool IsVisibleToUser() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is visible to the user. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setVisibleToUser
				/// </java-name>
				[Dot42.DexImport("setVisibleToUser", "(Z)V", AccessFlags = 1)]
				public virtual void SetVisibleToUser(bool visibleToUser) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is accessibility focused.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is accessibility focused. </para>
				/// </returns>
				/// <java-name>
				/// isAccessibilityFocused
				/// </java-name>
				[Dot42.DexImport("isAccessibilityFocused", "()Z", AccessFlags = 1)]
				public virtual bool IsAccessibilityFocused() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is accessibility focused. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setAccessibilityFocused
				/// </java-name>
				[Dot42.DexImport("setAccessibilityFocused", "(Z)V", AccessFlags = 1)]
				public virtual void SetAccessibilityFocused(bool focused) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is selected.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is selected. </para>
				/// </returns>
				/// <java-name>
				/// isSelected
				/// </java-name>
				[Dot42.DexImport("isSelected", "()Z", AccessFlags = 1)]
				public virtual bool IsSelected() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is selected. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setSelected
				/// </java-name>
				[Dot42.DexImport("setSelected", "(Z)V", AccessFlags = 1)]
				public virtual void SetSelected(bool selected) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is clickable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is clickable. </para>
				/// </returns>
				/// <java-name>
				/// isClickable
				/// </java-name>
				[Dot42.DexImport("isClickable", "()Z", AccessFlags = 1)]
				public virtual bool IsClickable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is clickable. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setClickable
				/// </java-name>
				[Dot42.DexImport("setClickable", "(Z)V", AccessFlags = 1)]
				public virtual void SetClickable(bool clickable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is long clickable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is long clickable. </para>
				/// </returns>
				/// <java-name>
				/// isLongClickable
				/// </java-name>
				[Dot42.DexImport("isLongClickable", "()Z", AccessFlags = 1)]
				public virtual bool IsLongClickable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is long clickable. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLongClickable
				/// </java-name>
				[Dot42.DexImport("setLongClickable", "(Z)V", AccessFlags = 1)]
				public virtual void SetLongClickable(bool longClickable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is enabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is enabled. </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public virtual bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is enabled. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEnabled
				/// </java-name>
				[Dot42.DexImport("setEnabled", "(Z)V", AccessFlags = 1)]
				public virtual void SetEnabled(bool enabled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets whether this node is a password.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is a password. </para>
				/// </returns>
				/// <java-name>
				/// isPassword
				/// </java-name>
				[Dot42.DexImport("isPassword", "()Z", AccessFlags = 1)]
				public virtual bool IsPassword() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is a password. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPassword
				/// </java-name>
				[Dot42.DexImport("setPassword", "(Z)V", AccessFlags = 1)]
				public virtual void SetPassword(bool password) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets if the node is scrollable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is scrollable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isScrollable
				/// </java-name>
				[Dot42.DexImport("isScrollable", "()Z", AccessFlags = 1)]
				public virtual bool IsScrollable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets if the node is scrollable. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setScrollable
				/// </java-name>
				[Dot42.DexImport("setScrollable", "(Z)V", AccessFlags = 1)]
				public virtual void SetScrollable(bool scrollable) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets if the node is editable.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the node is editable, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEditable
				/// </java-name>
				[Dot42.DexImport("isEditable", "()Z", AccessFlags = 1)]
				public virtual bool IsEditable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sets whether this node is editable. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setEditable
				/// </java-name>
				[Dot42.DexImport("setEditable", "(Z)V", AccessFlags = 1)]
				public virtual void SetEditable(bool editable) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCollectionInfo
				/// </java-name>
				[Dot42.DexImport("getCollectionInfo", "()Landroid/view/accessibility/AccessibilityNodeInfo$CollectionInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo.CollectionInfo GetCollectionInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo.CollectionInfo);
				}

				/// <java-name>
				/// setCollectionInfo
				/// </java-name>
				[Dot42.DexImport("setCollectionInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo$CollectionInfo;)V", AccessFlags = 1)]
				public virtual void SetCollectionInfo(global::Android.View.Accessibility.AccessibilityNodeInfo.CollectionInfo collectionInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCollectionItemInfo
				/// </java-name>
				[Dot42.DexImport("getCollectionItemInfo", "()Landroid/view/accessibility/AccessibilityNodeInfo$CollectionItemInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo.CollectionItemInfo GetCollectionItemInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo.CollectionItemInfo);
				}

				/// <java-name>
				/// setCollectionItemInfo
				/// </java-name>
				[Dot42.DexImport("setCollectionItemInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo$CollectionItemInfo;)V", AccessFlags = 1)]
				public virtual void SetCollectionItemInfo(global::Android.View.Accessibility.AccessibilityNodeInfo.CollectionItemInfo collectionItemInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getRangeInfo
				/// </java-name>
				[Dot42.DexImport("getRangeInfo", "()Landroid/view/accessibility/AccessibilityNodeInfo$RangeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo.RangeInfo GetRangeInfo() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo.RangeInfo);
				}

				/// <java-name>
				/// setRangeInfo
				/// </java-name>
				[Dot42.DexImport("setRangeInfo", "(Landroid/view/accessibility/AccessibilityNodeInfo$RangeInfo;)V", AccessFlags = 1)]
				public virtual void SetRangeInfo(global::Android.View.Accessibility.AccessibilityNodeInfo.RangeInfo rangeInfo) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isContentInvalid
				/// </java-name>
				[Dot42.DexImport("isContentInvalid", "()Z", AccessFlags = 1)]
				public virtual bool IsContentInvalid() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setContentInvalid
				/// </java-name>
				[Dot42.DexImport("setContentInvalid", "(Z)V", AccessFlags = 1)]
				public virtual void SetContentInvalid(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLiveRegion
				/// </java-name>
				[Dot42.DexImport("getLiveRegion", "()I", AccessFlags = 1)]
				public virtual int GetLiveRegion() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setLiveRegion
				/// </java-name>
				[Dot42.DexImport("setLiveRegion", "(I)V", AccessFlags = 1)]
				public virtual void SetLiveRegion(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isMultiLine
				/// </java-name>
				[Dot42.DexImport("isMultiLine", "()Z", AccessFlags = 1)]
				public virtual bool IsMultiLine() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setMultiLine
				/// </java-name>
				[Dot42.DexImport("setMultiLine", "(Z)V", AccessFlags = 1)]
				public virtual void SetMultiLine(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// canOpenPopup
				/// </java-name>
				[Dot42.DexImport("canOpenPopup", "()Z", AccessFlags = 1)]
				public virtual bool CanOpenPopup() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setCanOpenPopup
				/// </java-name>
				[Dot42.DexImport("setCanOpenPopup", "(Z)V", AccessFlags = 1)]
				public virtual void SetCanOpenPopup(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isDismissable
				/// </java-name>
				[Dot42.DexImport("isDismissable", "()Z", AccessFlags = 1)]
				public virtual bool IsDismissable() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// setDismissable
				/// </java-name>
				[Dot42.DexImport("setDismissable", "(Z)V", AccessFlags = 1)]
				public virtual void SetDismissable(bool boolean) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the package this node comes from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The package name. </para>
				/// </returns>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				[Dot42.DexImport("getPackageName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetPackageName() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the package this node comes from. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setPackageName
				/// </java-name>
				[Dot42.DexImport("setPackageName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetPackageName(global::Java.Lang.ICharSequence packageName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the class this node comes from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The class name. </para>
				/// </returns>
				/// <java-name>
				/// getClassName
				/// </java-name>
				[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetClassName() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the class this node comes from. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setClassName
				/// </java-name>
				[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetClassName(global::Java.Lang.ICharSequence className) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the text of this node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetText() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the text of this node. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setText
				/// </java-name>
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetText(global::Java.Lang.ICharSequence text) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the content description of this node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The content description. </para>
				/// </returns>
				/// <java-name>
				/// getContentDescription
				/// </java-name>
				[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
				public virtual global::Java.Lang.ICharSequence GetContentDescription() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Lang.ICharSequence);
				}

				/// <summary>
				/// <para>Sets the content description of this node. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setContentDescription
				/// </java-name>
				[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
				public virtual void SetContentDescription(global::Java.Lang.ICharSequence contentDescription) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the view for which the view represented by this info serves as a label for accessibility purposes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLabelFor
				/// </java-name>
				[Dot42.DexImport("setLabelFor", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetLabelFor(global::Android.View.View labeled) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the view for which the view represented by this info serves as a label for accessibility purposes. If <code>virtualDescendantId</code> is View#NO_ID the root is set as the labeled. </para><para>A virtual descendant is an imaginary View that is reported as a part of the view hierarchy for accessibility purposes. This enables custom views that draw complex content to report themselves as a tree of virtual views, thus conveying their logical structure. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLabelFor
				/// </java-name>
				[Dot42.DexImport("setLabelFor", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void SetLabelFor(global::Android.View.View root, int virtualDescendantId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the node info for which the view represented by this info serves as a label for accessibility purposes. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The labeled info. </para>
				/// </returns>
				/// <java-name>
				/// getLabelFor
				/// </java-name>
				[Dot42.DexImport("getLabelFor", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo GetLabelFor() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Sets the view which serves as the label of the view represented by this info for accessibility purposes.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLabeledBy
				/// </java-name>
				[Dot42.DexImport("setLabeledBy", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetLabeledBy(global::Android.View.View label) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets the view which serves as the label of the view represented by this info for accessibility purposes. If <code>virtualDescendantId</code> is View#NO_ID the root is set as the label. </para><para>A virtual descendant is an imaginary View that is reported as a part of the view hierarchy for accessibility purposes. This enables custom views that draw complex content to report themselves as a tree of virtual views, thus conveying their logical structure. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setLabeledBy
				/// </java-name>
				[Dot42.DexImport("setLabeledBy", "(Landroid/view/View;I)V", AccessFlags = 1)]
				public virtual void SetLabeledBy(global::Android.View.View root, int virtualDescendantId) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the node info which serves as the label of the view represented by this info for accessibility purposes. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The label. </para>
				/// </returns>
				/// <java-name>
				/// getLabeledBy
				/// </java-name>
				[Dot42.DexImport("getLabeledBy", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo GetLabeledBy() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Sets the fully qualified resource name of the source view's id.</para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setViewIdResourceName
				/// </java-name>
				[Dot42.DexImport("setViewIdResourceName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetViewIdResourceName(string viewIdResName) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Gets the fully qualified resource name of the source view's id.</para><para><b>Note:</b> The primary usage of this API is for UI test automation and in order to report the source view id of an AccessibilityNodeInfo the client has to set the AccessibilityServiceInfo#FLAG_REPORT_VIEW_IDS flag when configuring his android.accessibilityservice.AccessibilityService. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The id resource name. </para>
				/// </returns>
				/// <java-name>
				/// getViewIdResourceName
				/// </java-name>
				[Dot42.DexImport("getViewIdResourceName", "()Ljava/lang/String;", AccessFlags = 1)]
				public virtual string GetViewIdResourceName() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <summary>
				/// <para>Gets the text selection start.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text selection start if there is selection or -1. </para>
				/// </returns>
				/// <java-name>
				/// getTextSelectionStart
				/// </java-name>
				[Dot42.DexImport("getTextSelectionStart", "()I", AccessFlags = 1)]
				public virtual int GetTextSelectionStart() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Gets the text selection end.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text selection end if there is selection or -1. </para>
				/// </returns>
				/// <java-name>
				/// getTextSelectionEnd
				/// </java-name>
				[Dot42.DexImport("getTextSelectionEnd", "()I", AccessFlags = 1)]
				public virtual int GetTextSelectionEnd() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <summary>
				/// <para>Sets the text selection start and end. </para><para><b>Note:</b> Cannot be called from an android.accessibilityservice.AccessibilityService. This class is made immutable before being delivered to an AccessibilityService. </para><para></para>        
				/// </summary>
				/// <java-name>
				/// setTextSelection
				/// </java-name>
				[Dot42.DexImport("setTextSelection", "(II)V", AccessFlags = 1)]
				public virtual void SetTextSelection(int start, int end) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
				public virtual int GetInputType() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// setInputType
				/// </java-name>
				[Dot42.DexImport("setInputType", "(I)V", AccessFlags = 1)]
				public virtual void SetInputType(int int32) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
				public virtual global::Android.Os.Bundle GetExtras() /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.Bundle);
				}

				/// <summary>
				/// <para><para>Describe the kinds of special objects contained in this Parcelable's marshalled representation.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>a bitmask indicating the set of special object types marshalled by the Parcelable.</para>
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
				/// <para>Returns a cached instance if such is available otherwise a new one and sets the source.</para><para><para>setSource(View) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance.</para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/View;)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityNodeInfo Obtain(global::Android.View.View source) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Returns a cached instance if such is available otherwise a new one and sets the source.</para><para><para>setSource(View, int) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance.</para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/View;I)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityNodeInfo Obtain(global::Android.View.View root, int virtualDescendantId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Returns a cached instance if such is available otherwise a new one.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance. </para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityNodeInfo Obtain() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Returns a cached instance if such is available otherwise a new one and sets the source.</para><para><para>setSource(View) </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An instance.</para>
				/// </returns>
				/// <java-name>
				/// obtain
				/// </java-name>
				[Dot42.DexImport("obtain", "(Landroid/view/accessibility/AccessibilityNodeInfo;)Landroid/view/accessibility/A" +
    "ccessibilityNodeInfo;", AccessFlags = 9)]
				public static global::Android.View.Accessibility.AccessibilityNodeInfo Obtain(global::Android.View.Accessibility.AccessibilityNodeInfo source) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Return an instance back to be reused. </para><para><b>Note:</b> You must not touch the object after calling this function.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// recycle
				/// </java-name>
				[Dot42.DexImport("recycle", "()V", AccessFlags = 1)]
				public virtual void Recycle() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Flatten this object in to a Parcel.</para><para></para> </para><para><b>Note:</b> After the instance is written to a parcel it is recycled. You must not touch the object after calling this function. </para>        
				/// </summary>
				/// <java-name>
				/// writeToParcel
				/// </java-name>
				[Dot42.DexImport("writeToParcel", "(Landroid/os/Parcel;I)V", AccessFlags = 1)]
				public virtual void WriteToParcel(global::Android.Os.Parcel parcel, int flags) /* MethodBuilder.Create */ 
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

				/// <summary>
				/// <para>Gets the id of the window from which the info comes from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The window id. </para>
				/// </returns>
				/// <java-name>
				/// getWindowId
				/// </java-name>
				public int WindowId
				{
				[Dot42.DexImport("getWindowId", "()I", AccessFlags = 1)]
						get{ return GetWindowId(); }
				}

				/// <summary>
				/// <para>Gets the number of children.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The child count. </para>
				/// </returns>
				/// <java-name>
				/// getChildCount
				/// </java-name>
				public int ChildCount
				{
				[Dot42.DexImport("getChildCount", "()I", AccessFlags = 1)]
						get{ return GetChildCount(); }
				}

				/// <summary>
				/// <para>Gets the actions that can be performed on the node.</para><para><para>AccessibilityNodeInfo::ACTION_FOCUS </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_CLEAR_FOCUS </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_SELECT </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_CLEAR_SELECTION </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_ACCESSIBILITY_FOCUS </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_CLEAR_ACCESSIBILITY_FOCUS </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_CLICK </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_LONG_CLICK </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_NEXT_AT_MOVEMENT_GRANULARITY </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_PREVIOUS_AT_MOVEMENT_GRANULARITY </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_NEXT_HTML_ELEMENT </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_PREVIOUS_HTML_ELEMENT </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_SCROLL_FORWARD </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo::ACTION_SCROLL_BACKWARD </para></para>        
				/// </summary>
				/// <returns>
				/// <para>The bit mask of with actions.</para>
				/// </returns>
				/// <java-name>
				/// getActions
				/// </java-name>
				public int Actions
				{
				[Dot42.DexImport("getActions", "()I", AccessFlags = 1)]
						get{ return GetActions(); }
				}

				/// <summary>
				/// <para>Gets the movement granularities for traversing the text of this node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The bit mask with granularities. </para>
				/// </returns>
				/// <java-name>
				/// getMovementGranularities
				/// </java-name>
				public int MovementGranularities
				{
				[Dot42.DexImport("getMovementGranularities", "()I", AccessFlags = 1)]
						get{ return GetMovementGranularities(); }
				[Dot42.DexImport("setMovementGranularities", "(I)V", AccessFlags = 1)]
						set{ SetMovementGranularities(value); }
				}

				/// <summary>
				/// <para>Gets the parent. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The parent. </para>
				/// </returns>
				/// <java-name>
				/// getParent
				/// </java-name>
				public global::Android.View.Accessibility.AccessibilityNodeInfo Parent
				{
				[Dot42.DexImport("getParent", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return GetParent(); }
				}

				/// <java-name>
				/// getLiveRegion
				/// </java-name>
				public int LiveRegion
				{
				[Dot42.DexImport("getLiveRegion", "()I", AccessFlags = 1)]
						get{ return GetLiveRegion(); }
				[Dot42.DexImport("setLiveRegion", "(I)V", AccessFlags = 1)]
						set{ SetLiveRegion(value); }
				}

				/// <summary>
				/// <para>Gets the package this node comes from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The package name. </para>
				/// </returns>
				/// <java-name>
				/// getPackageName
				/// </java-name>
				public global::Java.Lang.ICharSequence PackageName
				{
				[Dot42.DexImport("getPackageName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetPackageName(); }
				[Dot42.DexImport("setPackageName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetPackageName(value); }
				}

				/// <summary>
				/// <para>Gets the class this node comes from.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The class name. </para>
				/// </returns>
				/// <java-name>
				/// getClassName
				/// </java-name>
				public global::Java.Lang.ICharSequence ClassName
				{
				[Dot42.DexImport("getClassName", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetClassName(); }
				[Dot42.DexImport("setClassName", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetClassName(value); }
				}

				/// <summary>
				/// <para>Gets the text of this node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text. </para>
				/// </returns>
				/// <java-name>
				/// getText
				/// </java-name>
				public global::Java.Lang.ICharSequence Text
				{
				[Dot42.DexImport("getText", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetText(); }
				[Dot42.DexImport("setText", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetText(value); }
				}

				/// <summary>
				/// <para>Gets the content description of this node.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The content description. </para>
				/// </returns>
				/// <java-name>
				/// getContentDescription
				/// </java-name>
				public global::Java.Lang.ICharSequence ContentDescription
				{
				[Dot42.DexImport("getContentDescription", "()Ljava/lang/CharSequence;", AccessFlags = 1)]
						get{ return GetContentDescription(); }
				[Dot42.DexImport("setContentDescription", "(Ljava/lang/CharSequence;)V", AccessFlags = 1)]
						set{ SetContentDescription(value); }
				}

				/// <summary>
				/// <para>Gets the node info for which the view represented by this info serves as a label for accessibility purposes. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The labeled info. </para>
				/// </returns>
				/// <java-name>
				/// getLabelFor
				/// </java-name>
				public global::Android.View.Accessibility.AccessibilityNodeInfo LabelFor
				{
				[Dot42.DexImport("getLabelFor", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return GetLabelFor(); }
				}

				/// <summary>
				/// <para>Gets the node info which serves as the label of the view represented by this info for accessibility purposes. </para><para><b>Note:</b> It is a client responsibility to recycle the received info by calling AccessibilityNodeInfo#recycle() to avoid creating of multiple instances. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The label. </para>
				/// </returns>
				/// <java-name>
				/// getLabeledBy
				/// </java-name>
				public global::Android.View.Accessibility.AccessibilityNodeInfo LabeledBy
				{
				[Dot42.DexImport("getLabeledBy", "()Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
						get{ return GetLabeledBy(); }
				}

				/// <summary>
				/// <para>Gets the fully qualified resource name of the source view's id.</para><para><b>Note:</b> The primary usage of this API is for UI test automation and in order to report the source view id of an AccessibilityNodeInfo the client has to set the AccessibilityServiceInfo#FLAG_REPORT_VIEW_IDS flag when configuring his android.accessibilityservice.AccessibilityService. </para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The id resource name. </para>
				/// </returns>
				/// <java-name>
				/// getViewIdResourceName
				/// </java-name>
				public string ViewIdResourceName
				{
				[Dot42.DexImport("getViewIdResourceName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return GetViewIdResourceName(); }
				[Dot42.DexImport("setViewIdResourceName", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ SetViewIdResourceName(value); }
				}

				/// <summary>
				/// <para>Gets the text selection start.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text selection start if there is selection or -1. </para>
				/// </returns>
				/// <java-name>
				/// getTextSelectionStart
				/// </java-name>
				public int TextSelectionStart
				{
				[Dot42.DexImport("getTextSelectionStart", "()I", AccessFlags = 1)]
						get{ return GetTextSelectionStart(); }
				}

				/// <summary>
				/// <para>Gets the text selection end.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The text selection end if there is selection or -1. </para>
				/// </returns>
				/// <java-name>
				/// getTextSelectionEnd
				/// </java-name>
				public int TextSelectionEnd
				{
				[Dot42.DexImport("getTextSelectionEnd", "()I", AccessFlags = 1)]
						get{ return GetTextSelectionEnd(); }
				}

				/// <java-name>
				/// getInputType
				/// </java-name>
				public int InputType
				{
				[Dot42.DexImport("getInputType", "()I", AccessFlags = 1)]
						get{ return GetInputType(); }
				[Dot42.DexImport("setInputType", "(I)V", AccessFlags = 1)]
						set{ SetInputType(value); }
				}

				/// <java-name>
				/// getExtras
				/// </java-name>
				public global::Android.Os.Bundle Extras
				{
				[Dot42.DexImport("getExtras", "()Landroid/os/Bundle;", AccessFlags = 1)]
						get{ return GetExtras(); }
				}

				/// <java-name>
				/// android/view/accessibility/AccessibilityNodeInfo$CollectionItemInfo
				/// </java-name>
				[Dot42.DexImport("android/view/accessibility/AccessibilityNodeInfo$CollectionItemInfo", AccessFlags = 25)]
				public sealed partial class CollectionItemInfo
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal CollectionItemInfo() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// obtain
						/// </java-name>
						[Dot42.DexImport("obtain", "(IIIIZ)Landroid/view/accessibility/AccessibilityNodeInfo$CollectionItemInfo;", AccessFlags = 9)]
						public static CollectionItemInfo Obtain(int int32, int int321, int int322, int int323, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(CollectionItemInfo);
						}

						/// <java-name>
						/// getColumnIndex
						/// </java-name>
						[Dot42.DexImport("getColumnIndex", "()I", AccessFlags = 1)]
						public int GetColumnIndex() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getRowIndex
						/// </java-name>
						[Dot42.DexImport("getRowIndex", "()I", AccessFlags = 1)]
						public int GetRowIndex() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getColumnSpan
						/// </java-name>
						[Dot42.DexImport("getColumnSpan", "()I", AccessFlags = 1)]
						public int GetColumnSpan() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getRowSpan
						/// </java-name>
						[Dot42.DexImport("getRowSpan", "()I", AccessFlags = 1)]
						public int GetRowSpan() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// isHeading
						/// </java-name>
						[Dot42.DexImport("isHeading", "()Z", AccessFlags = 1)]
						public bool IsHeading() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getColumnIndex
						/// </java-name>
						public int ColumnIndex
						{
						[Dot42.DexImport("getColumnIndex", "()I", AccessFlags = 1)]
								get{ return GetColumnIndex(); }
						}

						/// <java-name>
						/// getRowIndex
						/// </java-name>
						public int RowIndex
						{
						[Dot42.DexImport("getRowIndex", "()I", AccessFlags = 1)]
								get{ return GetRowIndex(); }
						}

						/// <java-name>
						/// getColumnSpan
						/// </java-name>
						public int ColumnSpan
						{
						[Dot42.DexImport("getColumnSpan", "()I", AccessFlags = 1)]
								get{ return GetColumnSpan(); }
						}

						/// <java-name>
						/// getRowSpan
						/// </java-name>
						public int RowSpan
						{
						[Dot42.DexImport("getRowSpan", "()I", AccessFlags = 1)]
								get{ return GetRowSpan(); }
						}

				}

				/// <java-name>
				/// android/view/accessibility/AccessibilityNodeInfo$CollectionInfo
				/// </java-name>
				[Dot42.DexImport("android/view/accessibility/AccessibilityNodeInfo$CollectionInfo", AccessFlags = 25)]
				public sealed partial class CollectionInfo
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal CollectionInfo() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// obtain
						/// </java-name>
						[Dot42.DexImport("obtain", "(IIZ)Landroid/view/accessibility/AccessibilityNodeInfo$CollectionInfo;", AccessFlags = 9)]
						public static CollectionInfo Obtain(int int32, int int321, bool boolean) /* MethodBuilder.Create */ 
						{
								return default(CollectionInfo);
						}

						/// <java-name>
						/// getRowCount
						/// </java-name>
						[Dot42.DexImport("getRowCount", "()I", AccessFlags = 1)]
						public int GetRowCount() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getColumnCount
						/// </java-name>
						[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
						public int GetColumnCount() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// isHierarchical
						/// </java-name>
						[Dot42.DexImport("isHierarchical", "()Z", AccessFlags = 1)]
						public bool IsHierarchical() /* MethodBuilder.Create */ 
						{
								return default(bool);
						}

						/// <java-name>
						/// getRowCount
						/// </java-name>
						public int RowCount
						{
						[Dot42.DexImport("getRowCount", "()I", AccessFlags = 1)]
								get{ return GetRowCount(); }
						}

						/// <java-name>
						/// getColumnCount
						/// </java-name>
						public int ColumnCount
						{
						[Dot42.DexImport("getColumnCount", "()I", AccessFlags = 1)]
								get{ return GetColumnCount(); }
						}

				}

				/// <java-name>
				/// android/view/accessibility/AccessibilityNodeInfo$RangeInfo
				/// </java-name>
				[Dot42.DexImport("android/view/accessibility/AccessibilityNodeInfo$RangeInfo", AccessFlags = 25)]
				public sealed partial class RangeInfo
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// RANGE_TYPE_INT
						/// </java-name>
						[Dot42.DexImport("RANGE_TYPE_INT", "I", AccessFlags = 25)]
						public const int RANGE_TYPE_INT = 0;
						/// <java-name>
						/// RANGE_TYPE_FLOAT
						/// </java-name>
						[Dot42.DexImport("RANGE_TYPE_FLOAT", "I", AccessFlags = 25)]
						public const int RANGE_TYPE_FLOAT = 1;
						/// <java-name>
						/// RANGE_TYPE_PERCENT
						/// </java-name>
						[Dot42.DexImport("RANGE_TYPE_PERCENT", "I", AccessFlags = 25)]
						public const int RANGE_TYPE_PERCENT = 2;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal RangeInfo() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// obtain
						/// </java-name>
						[Dot42.DexImport("obtain", "(IFFF)Landroid/view/accessibility/AccessibilityNodeInfo$RangeInfo;", AccessFlags = 9)]
						public static RangeInfo Obtain(int int32, float single, float single1, float single2) /* MethodBuilder.Create */ 
						{
								return default(RangeInfo);
						}

						/// <java-name>
						/// getType
						/// </java-name>
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
						public new int GetType() /* MethodBuilder.Create */ 
						{
								return default(int);
						}

						/// <java-name>
						/// getMin
						/// </java-name>
						[Dot42.DexImport("getMin", "()F", AccessFlags = 1)]
						public float GetMin() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// getMax
						/// </java-name>
						[Dot42.DexImport("getMax", "()F", AccessFlags = 1)]
						public float GetMax() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// getCurrent
						/// </java-name>
						[Dot42.DexImport("getCurrent", "()F", AccessFlags = 1)]
						public float GetCurrent() /* MethodBuilder.Create */ 
						{
								return default(float);
						}

						/// <java-name>
						/// getType
						/// </java-name>
						public int Type
						{
						[Dot42.DexImport("getType", "()I", AccessFlags = 1)]
								get{ return GetType(); }
						}

						/// <java-name>
						/// getMin
						/// </java-name>
						public float Min
						{
						[Dot42.DexImport("getMin", "()F", AccessFlags = 1)]
								get{ return GetMin(); }
						}

						/// <java-name>
						/// getMax
						/// </java-name>
						public float Max
						{
						[Dot42.DexImport("getMax", "()F", AccessFlags = 1)]
								get{ return GetMax(); }
						}

						/// <java-name>
						/// getCurrent
						/// </java-name>
						public float Current
						{
						[Dot42.DexImport("getCurrent", "()F", AccessFlags = 1)]
								get{ return GetCurrent(); }
						}

				}

		}

		/// <java-name>
		/// android/view/accessibility/CaptioningManager
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/CaptioningManager", AccessFlags = 33)]
		public partial class CaptioningManager
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
				internal CaptioningManager() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 17)]
				public bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 17)]
				public global::Java.Util.Locale GetLocale() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.Locale);
				}

				/// <java-name>
				/// getFontScale
				/// </java-name>
				[Dot42.DexImport("getFontScale", "()F", AccessFlags = 17)]
				public float GetFontScale() /* MethodBuilder.Create */ 
				{
						return default(float);
				}

				/// <java-name>
				/// getUserStyle
				/// </java-name>
				[Dot42.DexImport("getUserStyle", "()Landroid/view/accessibility/CaptioningManager$CaptionStyle;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.CaptioningManager.CaptionStyle GetUserStyle() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.CaptioningManager.CaptionStyle);
				}

				/// <java-name>
				/// addCaptioningChangeListener
				/// </java-name>
				[Dot42.DexImport("addCaptioningChangeListener", "(Landroid/view/accessibility/CaptioningManager$CaptioningChangeListener;)V", AccessFlags = 1)]
				public virtual void AddCaptioningChangeListener(global::Android.View.Accessibility.CaptioningManager.CaptioningChangeListener captioningChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// removeCaptioningChangeListener
				/// </java-name>
				[Dot42.DexImport("removeCaptioningChangeListener", "(Landroid/view/accessibility/CaptioningManager$CaptioningChangeListener;)V", AccessFlags = 1)]
				public virtual void RemoveCaptioningChangeListener(global::Android.View.Accessibility.CaptioningManager.CaptioningChangeListener captioningChangeListener) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getLocale
				/// </java-name>
				public global::Java.Util.Locale Locale
				{
				[Dot42.DexImport("getLocale", "()Ljava/util/Locale;", AccessFlags = 17)]
						get{ return GetLocale(); }
				}

				/// <java-name>
				/// getFontScale
				/// </java-name>
				public float FontScale
				{
				[Dot42.DexImport("getFontScale", "()F", AccessFlags = 17)]
						get{ return GetFontScale(); }
				}

				/// <java-name>
				/// getUserStyle
				/// </java-name>
				public global::Android.View.Accessibility.CaptioningManager.CaptionStyle UserStyle
				{
				[Dot42.DexImport("getUserStyle", "()Landroid/view/accessibility/CaptioningManager$CaptionStyle;", AccessFlags = 1)]
						get{ return GetUserStyle(); }
				}

				/// <java-name>
				/// android/view/accessibility/CaptioningManager$CaptioningChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/accessibility/CaptioningManager$CaptioningChangeListener", AccessFlags = 1033)]
				public abstract partial class CaptioningChangeListener
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public CaptioningChangeListener() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onEnabledChanged
						/// </java-name>
						[Dot42.DexImport("onEnabledChanged", "(Z)V", AccessFlags = 1)]
						public virtual void OnEnabledChanged(bool boolean) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onUserStyleChanged
						/// </java-name>
						[Dot42.DexImport("onUserStyleChanged", "(Landroid/view/accessibility/CaptioningManager$CaptionStyle;)V", AccessFlags = 1)]
						public virtual void OnUserStyleChanged(global::Android.View.Accessibility.CaptioningManager.CaptionStyle captionStyle) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onLocaleChanged
						/// </java-name>
						[Dot42.DexImport("onLocaleChanged", "(Ljava/util/Locale;)V", AccessFlags = 1)]
						public virtual void OnLocaleChanged(global::Java.Util.Locale locale) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// onFontScaleChanged
						/// </java-name>
						[Dot42.DexImport("onFontScaleChanged", "(F)V", AccessFlags = 1)]
						public virtual void OnFontScaleChanged(float single) /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/view/accessibility/CaptioningManager$CaptionStyle
				/// </java-name>
				[Dot42.DexImport("android/view/accessibility/CaptioningManager$CaptionStyle", AccessFlags = 25)]
				public sealed partial class CaptionStyle
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// EDGE_TYPE_NONE
						/// </java-name>
						[Dot42.DexImport("EDGE_TYPE_NONE", "I", AccessFlags = 25)]
						public const int EDGE_TYPE_NONE = 0;
						/// <java-name>
						/// EDGE_TYPE_OUTLINE
						/// </java-name>
						[Dot42.DexImport("EDGE_TYPE_OUTLINE", "I", AccessFlags = 25)]
						public const int EDGE_TYPE_OUTLINE = 1;
						/// <java-name>
						/// EDGE_TYPE_DROP_SHADOW
						/// </java-name>
						[Dot42.DexImport("EDGE_TYPE_DROP_SHADOW", "I", AccessFlags = 25)]
						public const int EDGE_TYPE_DROP_SHADOW = 2;
						/// <java-name>
						/// foregroundColor
						/// </java-name>
						[Dot42.DexImport("foregroundColor", "I", AccessFlags = 17)]
						public readonly int ForegroundColor;
						/// <java-name>
						/// backgroundColor
						/// </java-name>
						[Dot42.DexImport("backgroundColor", "I", AccessFlags = 17)]
						public readonly int BackgroundColor;
						/// <java-name>
						/// edgeType
						/// </java-name>
						[Dot42.DexImport("edgeType", "I", AccessFlags = 17)]
						public readonly int EdgeType;
						/// <java-name>
						/// edgeColor
						/// </java-name>
						[Dot42.DexImport("edgeColor", "I", AccessFlags = 17)]
						public readonly int EdgeColor;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 0)]
						internal CaptionStyle() /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// getTypeface
						/// </java-name>
						[Dot42.DexImport("getTypeface", "()Landroid/graphics/Typeface;", AccessFlags = 1)]
						public global::Android.Graphics.Typeface GetTypeface() /* MethodBuilder.Create */ 
						{
								return default(global::Android.Graphics.Typeface);
						}

						/// <java-name>
						/// getTypeface
						/// </java-name>
						public global::Android.Graphics.Typeface Typeface
						{
						[Dot42.DexImport("getTypeface", "()Landroid/graphics/Typeface;", AccessFlags = 1)]
								get{ return GetTypeface(); }
						}

				}

		}

		/// <summary>
		/// <para>This class is the contract a client should implement to enable support of a virtual view hierarchy rooted at a given view for accessibility purposes. A virtual view hierarchy is a tree of imaginary Views that is reported as a part of the view hierarchy when an AccessibilityService explores the window content. Since the virtual View tree does not exist this class is responsible for managing the AccessibilityNodeInfos describing that tree to accessibility services. </para><para>The main use case of these APIs is to enable a custom view that draws complex content, for example a monthly calendar grid, to be presented as a tree of logical nodes, for example month days each containing events, thus conveying its logical structure. </para><para>A typical use case is to override View#getAccessibilityNodeProvider() of the View that is a root of a virtual View hierarchy to return an instance of this class. In such a case this instance is responsible for managing AccessibilityNodeInfos describing the virtual sub-tree rooted at the View including the one representing the View itself. Similarly the returned instance is responsible for performing accessibility actions on any virtual view or the root view itself. For example: </para><para><pre>
		///        getAccessibilityNodeProvider(
		///            if (mAccessibilityNodeProvider == null) {
		///                mAccessibilityNodeProvider = new AccessibilityNodeProvider() {
		///                    public boolean performAction(int action, int virtualDescendantId) {
		///                        // Implementation.
		///                        return false;
		///                    }
		/// 
		///                    public List&lt;AccessibilityNodeInfo&gt; findAccessibilityNodeInfosByText(String text,
		///                            int virtualDescendantId) {
		///                        // Implementation.
		///                        return null;
		///                    }
		/// 
		///                    public AccessibilityNodeInfo createAccessibilityNodeInfo(int virtualDescendantId) {
		///                        // Implementation.
		///                        return null;
		///                    }
		///                });
		///        return mAccessibilityNodeProvider;
		///    </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/view/accessibility/AccessibilityNodeProvider
		/// </java-name>
		[Dot42.DexImport("android/view/accessibility/AccessibilityNodeProvider", AccessFlags = 1057)]
		public abstract partial class AccessibilityNodeProvider
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public AccessibilityNodeProvider() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns an AccessibilityNodeInfo representing a virtual view, i.e. a descendant of the host View, with the given <code>virtualViewId</code> or the host View itself if <code>virtualViewId</code> equals to View#NO_ID. </para><para>A virtual descendant is an imaginary View that is reported as a part of the view hierarchy for accessibility purposes. This enables custom views that draw complex content to report them selves as a tree of virtual views, thus conveying their logical structure. </para><para>The implementer is responsible for obtaining an accessibility node info from the pool of reusable instances and setting the desired properties of the node info before returning it. </para><para><para>View::createAccessibilityNodeInfo() </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A populated AccessibilityNodeInfo for a virtual descendant or the host View.</para>
				/// </returns>
				/// <java-name>
				/// createAccessibilityNodeInfo
				/// </java-name>
				[Dot42.DexImport("createAccessibilityNodeInfo", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo CreateAccessibilityNodeInfo(int virtualViewId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

				/// <summary>
				/// <para>Performs an accessibility action on a virtual view, i.e. a descendant of the host View, with the given <code>virtualViewId</code> or the host View itself if <code>virtualViewId</code> equals to View#NO_ID.</para><para><para>View::performAccessibilityAction(int, Bundle) </para><simplesectsep></simplesectsep><para>createAccessibilityNodeInfo(int) </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo </para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if the action was performed.</para>
				/// </returns>
				/// <java-name>
				/// performAction
				/// </java-name>
				[Dot42.DexImport("performAction", "(IILandroid/os/Bundle;)Z", AccessFlags = 1)]
				public virtual bool PerformAction(int virtualViewId, int action, global::Android.Os.Bundle arguments) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Finds AccessibilityNodeInfos by text. The match is case insensitive containment. The search is relative to the virtual view, i.e. a descendant of the host View, with the given <code>virtualViewId</code> or the host View itself <code>virtualViewId</code> equals to View#NO_ID.</para><para><para>createAccessibilityNodeInfo(int) </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo </para></para>        
				/// </summary>
				/// <returns>
				/// <para>A list of node info.</para>
				/// </returns>
				/// <java-name>
				/// findAccessibilityNodeInfosByText
				/// </java-name>
				[Dot42.DexImport("findAccessibilityNodeInfosByText", "(Ljava/lang/String;I)Ljava/util/List;", AccessFlags = 1, Signature = "(Ljava/lang/String;I)Ljava/util/List<Landroid/view/accessibility/AccessibilityNod" +
    "eInfo;>;")]
				public virtual global::Java.Util.IList<global::Android.View.Accessibility.AccessibilityNodeInfo> FindAccessibilityNodeInfosByText(string text, int virtualViewId) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.View.Accessibility.AccessibilityNodeInfo>);
				}

				/// <java-name>
				/// findFocus
				/// </java-name>
				[Dot42.DexImport("findFocus", "(I)Landroid/view/accessibility/AccessibilityNodeInfo;", AccessFlags = 1)]
				public virtual global::Android.View.Accessibility.AccessibilityNodeInfo FindFocus(int int32) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Accessibility.AccessibilityNodeInfo);
				}

		}

		/// <summary>
		/// <para>System level service that serves as an event dispatch for AccessibilityEvents, and provides facilities for querying the accessibility state of the system. Accessibility events are generated when something notable happens in the user interface, for example an android.app.Activity starts, the focus or selection of a android.view.View changes etc. Parties interested in handling accessibility events implement and register an accessibility service which extends android.accessibilityservice.AccessibilityService. </para><para>To obtain a handle to the accessibility manager do the following: </para><para><code> <pre>AccessibilityManager accessibilityManager =
		///           (AccessibilityManager) context.getSystemService(Context.ACCESSIBILITY_SERVICE);</pre> </code> </para><para><para>AccessibilityEvent </para><simplesectsep></simplesectsep><para>AccessibilityNodeInfo </para><simplesectsep></simplesectsep><para>android.accessibilityservice.AccessibilityService </para><simplesectsep></simplesectsep><para>Context::getSystemService </para><simplesectsep></simplesectsep><para>Context::ACCESSIBILITY_SERVICE </para></para>    
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
				/// <para>Returns if the accessibility in the system is enabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if accessibility is enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isEnabled
				/// </java-name>
				[Dot42.DexImport("isEnabled", "()Z", AccessFlags = 1)]
				public bool IsEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns if the touch exploration in the system is enabled.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if touch exploration is enabled, false otherwise. </para>
				/// </returns>
				/// <java-name>
				/// isTouchExplorationEnabled
				/// </java-name>
				[Dot42.DexImport("isTouchExplorationEnabled", "()Z", AccessFlags = 1)]
				public bool IsTouchExplorationEnabled() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Sends an AccessibilityEvent.</para><para><b>Note:</b> The preferred mechanism for sending custom accessibility events is through calling android.view.ViewParent#requestSendAccessibilityEvent(View, AccessibilityEvent) instead of this method to allow predecessors to augment/filter events sent by their descendants. </para>        
				/// </summary>
				/// <java-name>
				/// sendAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V", AccessFlags = 1)]
				public void SendAccessibilityEvent(global::Android.View.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Requests feedback interruption from all accessibility services. </para>        
				/// </summary>
				/// <java-name>
				/// interrupt
				/// </java-name>
				[Dot42.DexImport("interrupt", "()V", AccessFlags = 1)]
				public void Interrupt() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns the ServiceInfos of the installed accessibility services.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use getInstalledAccessibilityServiceList() </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>An unmodifiable list with ServiceInfos.</para>
				/// </returns>
				/// <java-name>
				/// getAccessibilityServiceList
				/// </java-name>
				[Dot42.DexImport("getAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/pm/ServiceInfo;>;")]
				public global::Java.Util.IList<global::Android.Content.Pm.ServiceInfo> GetAccessibilityServiceList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Content.Pm.ServiceInfo>);
				}

				/// <summary>
				/// <para>Returns the AccessibilityServiceInfos of the installed accessibility services.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An unmodifiable list with AccessibilityServiceInfos. </para>
				/// </returns>
				/// <java-name>
				/// getInstalledAccessibilityServiceList
				/// </java-name>
				[Dot42.DexImport("getInstalledAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/accessibilityservice/AccessibilityServiceInfo;>;")]
				public global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo> GetInstalledAccessibilityServiceList() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo>);
				}

				/// <summary>
				/// <para>Returns the AccessibilityServiceInfos of the enabled accessibility services for a given feedback type.</para><para><para>AccessibilityServiceInfo::FEEDBACK_AUDIBLE </para><simplesectsep></simplesectsep><para>AccessibilityServiceInfo::FEEDBACK_GENERIC </para><simplesectsep></simplesectsep><para>AccessibilityServiceInfo::FEEDBACK_HAPTIC </para><simplesectsep></simplesectsep><para>AccessibilityServiceInfo::FEEDBACK_SPOKEN </para><simplesectsep></simplesectsep><para>AccessibilityServiceInfo::FEEDBACK_VISUAL </para></para>        
				/// </summary>
				/// <returns>
				/// <para>An unmodifiable list with AccessibilityServiceInfos.</para>
				/// </returns>
				/// <java-name>
				/// getEnabledAccessibilityServiceList
				/// </java-name>
				[Dot42.DexImport("getEnabledAccessibilityServiceList", "(I)Ljava/util/List;", AccessFlags = 1, Signature = "(I)Ljava/util/List<Landroid/accessibilityservice/AccessibilityServiceInfo;>;")]
				public global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo> GetEnabledAccessibilityServiceList(int feedbackTypeFlags) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo>);
				}

				/// <summary>
				/// <para>Registers an AccessibilityStateChangeListener for changes in the global accessibility state of the system.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if successfully registered. </para>
				/// </returns>
				/// <java-name>
				/// addAccessibilityStateChangeListener
				/// </java-name>
				[Dot42.DexImport("addAccessibilityStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityStateChangeListene" +
    "r;)Z", AccessFlags = 1)]
				public bool AddAccessibilityStateChangeListener(global::Android.View.Accessibility.AccessibilityManager.IAccessibilityStateChangeListener listener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Unregisters an AccessibilityStateChangeListener.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>True if successfully unregistered. </para>
				/// </returns>
				/// <java-name>
				/// removeAccessibilityStateChangeListener
				/// </java-name>
				[Dot42.DexImport("removeAccessibilityStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$AccessibilityStateChangeListene" +
    "r;)Z", AccessFlags = 1)]
				public bool RemoveAccessibilityStateChangeListener(global::Android.View.Accessibility.AccessibilityManager.IAccessibilityStateChangeListener listener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// addTouchExplorationStateChangeListener
				/// </java-name>
				[Dot42.DexImport("addTouchExplorationStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$TouchExplorationStateChangeList" +
    "ener;)Z", AccessFlags = 1)]
				public bool AddTouchExplorationStateChangeListener(global::Android.View.Accessibility.AccessibilityManager.ITouchExplorationStateChangeListener touchExplorationStateChangeListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// removeTouchExplorationStateChangeListener
				/// </java-name>
				[Dot42.DexImport("removeTouchExplorationStateChangeListener", "(Landroid/view/accessibility/AccessibilityManager$TouchExplorationStateChangeList" +
    "ener;)Z", AccessFlags = 1)]
				public bool RemoveTouchExplorationStateChangeListener(global::Android.View.Accessibility.AccessibilityManager.ITouchExplorationStateChangeListener touchExplorationStateChangeListener) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Returns the ServiceInfos of the installed accessibility services.</para><para><xrefsect><xreftitle>Deprecated</xreftitle><xrefdescription><para>Use getInstalledAccessibilityServiceList() </para></xrefdescription></xrefsect></para>        
				/// </summary>
				/// <returns>
				/// <para>An unmodifiable list with ServiceInfos.</para>
				/// </returns>
				/// <java-name>
				/// getAccessibilityServiceList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Content.Pm.ServiceInfo> AccessibilityServiceList
				{
				[Dot42.DexImport("getAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/content/pm/ServiceInfo;>;")]
						get{ return GetAccessibilityServiceList(); }
				}

				/// <summary>
				/// <para>Returns the AccessibilityServiceInfos of the installed accessibility services.</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>An unmodifiable list with AccessibilityServiceInfos. </para>
				/// </returns>
				/// <java-name>
				/// getInstalledAccessibilityServiceList
				/// </java-name>
				public global::Java.Util.IList<global::Android.Accessibilityservice.AccessibilityServiceInfo> InstalledAccessibilityServiceList
				{
				[Dot42.DexImport("getInstalledAccessibilityServiceList", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Landroid/accessibilityservice/AccessibilityServiceInfo;>;")]
						get{ return GetInstalledAccessibilityServiceList(); }
				}

				/// <java-name>
				/// android/view/accessibility/AccessibilityManager$TouchExplorationStateChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/accessibility/AccessibilityManager$TouchExplorationStateChangeListen" +
    "er", AccessFlags = 1545)]
				public partial interface ITouchExplorationStateChangeListener
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// onTouchExplorationStateChanged
						/// </java-name>
						[Dot42.DexImport("onTouchExplorationStateChanged", "(Z)V", AccessFlags = 1025)]
						void OnTouchExplorationStateChanged(bool boolean) /* MethodBuilder.Create */ ;

				}

				/// <summary>
				/// <para>Listener for the system accessibility state. To listen for changes to the accessibility state on the device, implement this interface and register it with the system by calling addAccessibilityStateChangeListener(). </para>    
				/// </summary>
				/// <java-name>
				/// android/view/accessibility/AccessibilityManager$AccessibilityStateChangeListener
				/// </java-name>
				[Dot42.DexImport("android/view/accessibility/AccessibilityManager$AccessibilityStateChangeListener", AccessFlags = 1545)]
				public partial interface IAccessibilityStateChangeListener
 /* scope: __dot42__ */ 
				{
						/// <summary>
						/// <para>Called back on change in the accessibility state.</para><para></para>        
						/// </summary>
						/// <java-name>
						/// onAccessibilityStateChanged
						/// </java-name>
						[Dot42.DexImport("onAccessibilityStateChanged", "(Z)V", AccessFlags = 1025)]
						void OnAccessibilityStateChanged(bool enabled) /* MethodBuilder.Create */ ;

				}

		}

}


