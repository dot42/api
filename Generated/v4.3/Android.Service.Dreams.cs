// Copyright (C) 2014 dot42
//
// Original filename: Android.Service.Dreams.cs
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
namespace Android.Service.Dreams
{
		/// <summary>
		/// <para>Extend this class to implement a custom dream (available to the user as a "Daydream").</para><para>Dreams are interactive screensavers launched when a charging device is idle, or docked in a desk dock. Dreams provide another modality for apps to express themselves, tailored for an exhibition/lean-back experience.</para><para>The <c> DreamService </c> lifecycle is as follows:</para><para><ol><li><para>onAttachedToWindow </para><para>Use this for initial setup, such as calling setContentView(). </para></li><li><para>onDreamingStarted </para><para>Your dream has started, so you should begin animations or other behaviors here. </para></li><li><para>onDreamingStopped </para><para>Use this to stop the things you started in onDreamingStarted. </para></li><li><para>onDetachedFromWindow </para><para>Use this to dismantle resources (for example, detach from handlers and listeners). </para></li></ol></para><para>In addition, onCreate and onDestroy (from the Service interface) will also be called, but initialization and teardown should be done by overriding the hooks above.</para><para>To be available to the system, your <c> DreamService </c> should be declared in the manifest as follows:</para><para><pre>
		///    &lt;service
		///        android:name=".MyDream"
		///        android:exported="true"
		///        android:icon="@drawable/my_icon"
		///        android:label="@string/my_dream_label" &gt;
		/// 
		///        &lt;intent-filter&gt;
		///            &lt;action android:name="android.service.dreams.DreamService" /&gt;
		///            &lt;category android:name="android.intent.category.DEFAULT" /&gt;
		///        &lt;/intent-filter&gt;
		/// 
		///        &lt;! Point to additional information for this dream (optional) &gt;
		///        &lt;meta-data
		///            android:name="android.service.dream"
		///            android:resource="@xml/my_dream" /&gt;
		///    &lt;/service&gt;
		///    </pre></para><para>If specified with the <c> &amp;lt;meta-data&amp;gt; </c> element, additional information for the dream is defined using the &lt;dream&gt; element in a separate XML file. Currently, the only addtional information you can provide is for a settings activity that allows the user to configure the dream behavior. For example:</para><para>res/xml/my_dream.xml</para><para><pre>
		///    &lt;dream xmlns:android="http://schemas.android.com/apk/res/android"
		///        android:settingsActivity="com.example.app/.MyDreamSettingsActivity" /&gt;
		///    </pre> </para><para>This makes a Settings button available alongside your dream's listing in the system settings, which when pressed opens the specified activity.</para><para>To specify your dream layout, call setContentView, typically during the onAttachedToWindow callback. For example:</para><para><pre>
		///    public class MyDream extends DreamService {
		/// <span>&amp;#64;Override
		/// public void onAttachedToWindow() {
		///     super.onAttachedToWindow();
		/// 
		///     // Exit dream upon user touch
		///     setInteractive(false);
		///     // Hide system UI
		///     setFullscreen(true);
		///     // Set the dream layout
		///     setContentView(R.layout.dream);
		/// }
		/// </span>
		///    }
		///    </pre> </para>    
		/// </summary>
		/// <java-name>
		/// android/service/dreams/DreamService
		/// </java-name>
		[Dot42.DexImport("android/service/dreams/DreamService", AccessFlags = 33)]
		public partial class DreamService : global::Android.App.Service, global::Android.View.Window.ICallback
 /* scope: __dot42__ */ 
		{
				/// <summary>
				/// <para>The Intent that must be declared as handled by the service. </para>        
				/// </summary>
				/// <java-name>
				/// SERVICE_INTERFACE
				/// </java-name>
				[Dot42.DexImport("SERVICE_INTERFACE", "Ljava/lang/String;", AccessFlags = 25)]
				public const string SERVICE_INTERFACE = "android.service.dreams.DreamService";
				/// <summary>
				/// <para>Name under which a Dream publishes information about itself. This meta-data must reference an XML resource containing a <code>&lt;dream&gt;</code> tag. </para>        
				/// </summary>
				/// <java-name>
				/// DREAM_META_DATA
				/// </java-name>
				[Dot42.DexImport("DREAM_META_DATA", "Ljava/lang/String;", AccessFlags = 25)]
				public const string DREAM_META_DATA = "android.service.dream";
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public DreamService() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Called to process key events. At the very least your implementation must call android.view.Window#superDispatchKeyEvent to do the standard key processing.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Return true if this event was consumed.</para>
				/// </returns>
				/// <java-name>
				/// dispatchKeyEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyEvent(global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Called to process a key shortcut event. At the very least your implementation must call android.view.Window#superDispatchKeyShortcutEvent to do the standard key shortcut processing.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>True if this event was consumed.</para>
				/// </returns>
				/// <java-name>
				/// dispatchKeyShortcutEvent
				/// </java-name>
				[Dot42.DexImport("dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchKeyShortcutEvent(global::Android.View.KeyEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Called to process touch screen events. At the very least your implementation must call android.view.Window#superDispatchTouchEvent to do the standard touch screen processing.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Return true if this event was consumed.</para>
				/// </returns>
				/// <java-name>
				/// dispatchTouchEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTouchEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Called to process trackball events. At the very least your implementation must call android.view.Window#superDispatchTrackballEvent to do the standard trackball processing.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Return true if this event was consumed.</para>
				/// </returns>
				/// <java-name>
				/// dispatchTrackballEvent
				/// </java-name>
				[Dot42.DexImport("dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchTrackballEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Called to process generic motion events. At the very least your implementation must call android.view.Window#superDispatchGenericMotionEvent to do the standard processing.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Return true if this event was consumed.</para>
				/// </returns>
				/// <java-name>
				/// dispatchGenericMotionEvent
				/// </java-name>
				[Dot42.DexImport("dispatchGenericMotionEvent", "(Landroid/view/MotionEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchGenericMotionEvent(global::Android.View.MotionEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Called to process population of AccessibilityEvents.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Return true if event population was completed.</para>
				/// </returns>
				/// <java-name>
				/// dispatchPopulateAccessibilityEvent
				/// </java-name>
				[Dot42.DexImport("dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z", AccessFlags = 1)]
				public virtual bool DispatchPopulateAccessibilityEvent(global::Android.View.Accessibility.AccessibilityEvent @event) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Instantiate the view to display in the panel for 'featureId'. You can return null, in which case the default content (typically a menu) will be created for you.</para><para><para>onPreparePanel</para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>view The top-level view to place in the panel.</para>
				/// </returns>
				/// <java-name>
				/// onCreatePanelView
				/// </java-name>
				[Dot42.DexImport("onCreatePanelView", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View OnCreatePanelView(int featureId) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para><para>Initialize the contents of the menu for panel 'featureId'. This is called if onCreatePanelView() returns null, giving you a standard menu in which you can place your items. It is only called once for the panel, the first time it is shown.</para><para>You can safely hold on to <b>menu</b> (and any items created from it), making modifications to it as desired, until the next time onCreatePanelMenu() is called for this feature.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean You must return true for the panel to be displayed; if you return false it will not be shown.</para>
				/// </returns>
				/// <java-name>
				/// onCreatePanelMenu
				/// </java-name>
				[Dot42.DexImport("onCreatePanelMenu", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnCreatePanelMenu(int featureId, global::Android.View.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Prepare a panel to be displayed. This is called right before the panel window is shown, every time it is shown.</para><para><para>onCreatePanelView</para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean You must return true for the panel to be displayed; if you return false it will not be shown.</para>
				/// </returns>
				/// <java-name>
				/// onPreparePanel
				/// </java-name>
				[Dot42.DexImport("onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnPreparePanel(int featureId, global::Android.View.View view, global::Android.View.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Called when a panel's menu is opened by the user. This may also be called when the menu is changing from one type to another (for example, from the icon menu to the expanded menu).</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>Return true to allow the menu to open, or false to prevent the menu from opening.</para>
				/// </returns>
				/// <java-name>
				/// onMenuOpened
				/// </java-name>
				[Dot42.DexImport("onMenuOpened", "(ILandroid/view/Menu;)Z", AccessFlags = 1)]
				public virtual bool OnMenuOpened(int featureId, global::Android.View.IMenu menu) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para><para>Called when a panel's menu item has been selected by the user.</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>boolean Return true to finish processing of selection, or false to perform the normal menu handling (calling its Runnable or sending a Message to its target Handler).</para>
				/// </returns>
				/// <java-name>
				/// onMenuItemSelected
				/// </java-name>
				[Dot42.DexImport("onMenuItemSelected", "(ILandroid/view/MenuItem;)Z", AccessFlags = 1)]
				public virtual bool OnMenuItemSelected(int featureId, global::Android.View.IMenuItem item) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onWindowAttributesChanged
				/// </java-name>
				[Dot42.DexImport("onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V", AccessFlags = 1)]
				public virtual void OnWindowAttributesChanged(global::Android.View.IWindowManager_LayoutParams attrs) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>This hook is called whenever the content view of the screen changes (due to a call to Window.setContentView or Window.addContentView).</para> </para>        
				/// </summary>
				/// <java-name>
				/// onContentChanged
				/// </java-name>
				[Dot42.DexImport("onContentChanged", "()V", AccessFlags = 1)]
				public virtual void OnContentChanged() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>This hook is called whenever the window focus changes. See View.onWindowFocusChanged(boolean) for more information.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onWindowFocusChanged
				/// </java-name>
				[Dot42.DexImport("onWindowFocusChanged", "(Z)V", AccessFlags = 1)]
				public virtual void OnWindowFocusChanged(bool hasFocus) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Called when the window has been attached to the window manager. See View.onAttachedToWindow() for more information.</para> </para>        
				/// </summary>
				/// <java-name>
				/// onAttachedToWindow
				/// </java-name>
				[Dot42.DexImport("onAttachedToWindow", "()V", AccessFlags = 1)]
				public virtual void OnAttachedToWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Called when the window has been attached to the window manager. See View.onDetachedFromWindow() for more information.</para> </para>        
				/// </summary>
				/// <java-name>
				/// onDetachedFromWindow
				/// </java-name>
				[Dot42.DexImport("onDetachedFromWindow", "()V", AccessFlags = 1)]
				public virtual void OnDetachedFromWindow() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Called when a panel is being closed. If another logical subsequent panel is being opened (and this panel is being closed to make room for the subsequent panel), this method will NOT be called.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onPanelClosed
				/// </java-name>
				[Dot42.DexImport("onPanelClosed", "(ILandroid/view/Menu;)V", AccessFlags = 1)]
				public virtual void OnPanelClosed(int featureId, global::Android.View.IMenu menu) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Called when the user signals the desire to start a search.</para><para><para>android.app.Activity::onSearchRequested() </para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>true if search launched, false if activity refuses (blocks)</para>
				/// </returns>
				/// <java-name>
				/// onSearchRequested
				/// </java-name>
				[Dot42.DexImport("onSearchRequested", "()Z", AccessFlags = 1)]
				public virtual bool OnSearchRequested() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// onWindowStartingActionMode
				/// </java-name>
				[Dot42.DexImport("onWindowStartingActionMode", "(Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", AccessFlags = 1)]
				public virtual global::Android.View.ActionMode OnWindowStartingActionMode(global::Android.View.ActionMode.ICallback callback) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.ActionMode);
				}

				/// <summary>
				/// <para><para>Called when an action mode has been started. The appropriate mode callback method will have already been invoked.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onActionModeStarted
				/// </java-name>
				[Dot42.DexImport("onActionModeStarted", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeStarted(global::Android.View.ActionMode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Called when an action mode has been finished. The appropriate mode callback method will have already been invoked.</para><para></para> </para>        
				/// </summary>
				/// <java-name>
				/// onActionModeFinished
				/// </java-name>
				[Dot42.DexImport("onActionModeFinished", "(Landroid/view/ActionMode;)V", AccessFlags = 1)]
				public virtual void OnActionModeFinished(global::Android.View.ActionMode mode) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retrieves the current android.view.WindowManager for the dream. Behaves similarly to android.app.Activity#getWindowManager().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current window manager, or null if the dream is not started. </para>
				/// </returns>
				/// <java-name>
				/// getWindowManager
				/// </java-name>
				[Dot42.DexImport("getWindowManager", "()Landroid/view/WindowManager;", AccessFlags = 1)]
				public virtual global::Android.View.IWindowManager GetWindowManager() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.IWindowManager);
				}

				/// <summary>
				/// <para>Retrieves the current android.view.Window for the dream. Behaves similarly to android.app.Activity#getWindow().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current window, or null if the dream is not started. </para>
				/// </returns>
				/// <java-name>
				/// getWindow
				/// </java-name>
				[Dot42.DexImport("getWindow", "()Landroid/view/Window;", AccessFlags = 1)]
				public virtual global::Android.View.Window GetWindow() /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.Window);
				}

				/// <summary>
				/// <para>Inflates a layout resource and set it to be the content view for this Dream. Behaves similarly to android.app.Activity#setContentView(int).</para><para>Note: Requires a window, do not call before onAttachedToWindow()</para><para><para>setContentView(android.view.View) </para><simplesectsep></simplesectsep><para>setContentView(android.view.View, android.view.ViewGroup.LayoutParams) </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(I)V", AccessFlags = 1)]
				public virtual void SetContentView(int layoutResID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Inflates a layout resource and set it to be the content view for this Dream. Behaves similarly to android.app.Activity#setContentView(int).</para><para>Note: Requires a window, do not call before onAttachedToWindow()</para><para><para>setContentView(android.view.View) </para><simplesectsep></simplesectsep><para>setContentView(android.view.View, android.view.ViewGroup.LayoutParams) </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.View.View layoutResID) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Sets a view to be the content view for this Dream. Behaves similarly to android.app.Activity#setContentView(android.view.View, android.view.ViewGroup.LayoutParams) in an activity.</para><para>Note: This requires a window, so you should usually call it during onAttachedToWindow() and never earlier (you <b>cannot</b> call it during onCreate).</para><para><para>setContentView(android.view.View) </para><simplesectsep></simplesectsep><para>setContentView(int) </para></para>        
				/// </summary>
				/// <java-name>
				/// setContentView
				/// </java-name>
				[Dot42.DexImport("setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void SetContentView(global::Android.View.View view, global::Android.View.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Adds a view to the Dream's window, leaving other content views in place.</para><para>Note: Requires a window, do not call before onAttachedToWindow()</para><para></para>        
				/// </summary>
				/// <java-name>
				/// addContentView
				/// </java-name>
				[Dot42.DexImport("addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", AccessFlags = 1)]
				public virtual void AddContentView(global::Android.View.View view, global::Android.View.ViewGroup.LayoutParams @params) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Finds a view that was identified by the id attribute from the XML that was processed in onCreate.</para><para>Note: Requires a window, do not call before onAttachedToWindow()</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The view if found or null otherwise. </para>
				/// </returns>
				/// <java-name>
				/// findViewById
				/// </java-name>
				[Dot42.DexImport("findViewById", "(I)Landroid/view/View;", AccessFlags = 1)]
				public virtual global::Android.View.View FindViewById(int id) /* MethodBuilder.Create */ 
				{
						return default(global::Android.View.View);
				}

				/// <summary>
				/// <para>Marks this dream as interactive to receive input events.</para><para>Non-interactive dreams (default) will dismiss on the first input event.</para><para>Interactive dreams should call finish() to dismiss themselves.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setInteractive
				/// </java-name>
				[Dot42.DexImport("setInteractive", "(Z)V", AccessFlags = 1)]
				public virtual void SetInteractive(bool interactive) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether or not this dream is interactive. Defaults to false.</para><para><para>setInteractive(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// isInteractive
				/// </java-name>
				[Dot42.DexImport("isInteractive", "()Z", AccessFlags = 1)]
				public virtual bool IsInteractive() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Controls android.view.WindowManager.LayoutParams#FLAG_FULLSCREEN on the dream's window.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setFullscreen
				/// </java-name>
				[Dot42.DexImport("setFullscreen", "(Z)V", AccessFlags = 1)]
				public virtual void SetFullscreen(bool fullscreen) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether or not this dream is in fullscreen mode. Defaults to false.</para><para><para>setFullscreen(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// isFullscreen
				/// </java-name>
				[Dot42.DexImport("isFullscreen", "()Z", AccessFlags = 1)]
				public virtual bool IsFullscreen() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Marks this dream as keeping the screen bright while dreaming.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// setScreenBright
				/// </java-name>
				[Dot42.DexImport("setScreenBright", "(Z)V", AccessFlags = 1)]
				public virtual void SetScreenBright(bool screenBright) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Returns whether or not this dream keeps the screen bright while dreaming. Defaults to false, allowing the screen to dim if necessary.</para><para><para>setScreenBright(boolean) </para></para>        
				/// </summary>
				/// <java-name>
				/// isScreenBright
				/// </java-name>
				[Dot42.DexImport("isScreenBright", "()Z", AccessFlags = 1)]
				public virtual bool IsScreenBright() /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <summary>
				/// <para>Called when this Dream is constructed. </para>        
				/// </summary>
				/// <java-name>
				/// onCreate
				/// </java-name>
				[Dot42.DexImport("onCreate", "()V", AccessFlags = 1)]
				public override void OnCreate() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when the dream's window has been created and is visible and animation may now begin. </para>        
				/// </summary>
				/// <java-name>
				/// onDreamingStarted
				/// </java-name>
				[Dot42.DexImport("onDreamingStarted", "()V", AccessFlags = 1)]
				public virtual void OnDreamingStarted() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Called when this Dream is stopped, either by external request or by calling finish(), before the window has been removed. </para>        
				/// </summary>
				/// <java-name>
				/// onDreamingStopped
				/// </java-name>
				[Dot42.DexImport("onDreamingStopped", "()V", AccessFlags = 1)]
				public virtual void OnDreamingStopped() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Return the communication channel to the service. May return null if clients can not bind to the service. The returned android.os.IBinder is usually for a complex interface that has been .</para><para><b>Note that unlike other application components, calls on to the IBinder interface returned here may not happen on the main thread of the process</b>. More information about the main thread can be found in .</para><para></para> </para>        
				/// </summary>
				/// <returns>
				/// <para>Return an IBinder through which clients can call on to the service.</para>
				/// </returns>
				/// <java-name>
				/// onBind
				/// </java-name>
				[Dot42.DexImport("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", AccessFlags = 17)]
				public override global::Android.Os.IBinder OnBind(global::Android.Content.Intent intent) /* MethodBuilder.Create */ 
				{
						return default(global::Android.Os.IBinder);
				}

				/// <summary>
				/// <para>Stops the dream, detaches from the window, and wakes up. </para>        
				/// </summary>
				/// <java-name>
				/// finish
				/// </java-name>
				[Dot42.DexImport("finish", "()V", AccessFlags = 17)]
				public void Finish() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para><para>Called by the system to notify a Service that it is no longer used and is being removed. The service should clean up any resources it holds (threads, registered receivers, etc) at this point. Upon return, there will be no more calls in to this Service object and it is effectively dead. Do not call this method directly.</para> </para>        
				/// </summary>
				/// <java-name>
				/// onDestroy
				/// </java-name>
				[Dot42.DexImport("onDestroy", "()V", AccessFlags = 1)]
				public override void OnDestroy() /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Print the Service's state into the given stream. This gets invoked if you run "adb shell dumpsys activity service &amp;lt;yourservicename&amp;gt;" (note that for this command to work, the service must be running, and you must specify a fully-qualified service name). This is distinct from "dumpsys &amp;lt;servicename&amp;gt;", which only works for named system services and which invokes the IBinder#dump method on the IBinder interface registered with ServiceManager.</para><para></para>        
				/// </summary>
				/// <java-name>
				/// dump
				/// </java-name>
				[Dot42.DexImport("dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal override void Dump(global::Java.Io.FileDescriptor fd, global::Java.Io.PrintWriter writer, string[] args) /* MethodBuilder.Create */ 
				{
				}

				/// <summary>
				/// <para>Retrieves the current android.view.WindowManager for the dream. Behaves similarly to android.app.Activity#getWindowManager().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current window manager, or null if the dream is not started. </para>
				/// </returns>
				/// <java-name>
				/// getWindowManager
				/// </java-name>
				public global::Android.View.IWindowManager WindowManager
				{
				[Dot42.DexImport("getWindowManager", "()Landroid/view/WindowManager;", AccessFlags = 1)]
						get{ return GetWindowManager(); }
				}

				/// <summary>
				/// <para>Retrieves the current android.view.Window for the dream. Behaves similarly to android.app.Activity#getWindow().</para><para></para>        
				/// </summary>
				/// <returns>
				/// <para>The current window, or null if the dream is not started. </para>
				/// </returns>
				/// <java-name>
				/// getWindow
				/// </java-name>
				public global::Android.View.Window Window
				{
				[Dot42.DexImport("getWindow", "()Landroid/view/Window;", AccessFlags = 1)]
						get{ return GetWindow(); }
				}

		}

}


